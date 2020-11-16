using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static NWN.Core.NWNCore;

namespace NWN.Core.Server
{
  public class NwnServer : IGameManager
  {
    #region Static Members
    private static NativeHandles _nativeFunctions;
    private static NativeEventHandles _eventHandles;

    public static NwnServer Instance { get; private set; }
    public static int IntializeInstance(IntPtr nativeHandlesPtr, int nativeHandlesLength)
    {
      try
      {
        Instance = new NwnServer(nativeHandlesPtr, nativeHandlesLength);
        return 0;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
        return 1;
      }
    }

    private static void RegisterHandles()
    {
      _eventHandles.MainLoop = GameManager.OnMainLoop;
      _eventHandles.RunScript = GameManager.OnRunScript;
      _eventHandles.Closure = GameManager.OnClosure;
      _eventHandles.Signal = GameManager.OnSignal;
    }

    private static void RegisterNativeEventHandles()
    {
      int size = Marshal.SizeOf(typeof(NativeEventHandles));
      IntPtr ptr = Marshal.AllocHGlobal(size);
      Marshal.StructureToPtr(_eventHandles, ptr, false);
      _nativeFunctions.RegisterHandlers(ptr, (uint)size);
      Marshal.FreeHGlobal(ptr);
    }
    #endregion

    #region Fields
    private NwnReference _self = NwnReference.INVALID;
    private Stack<NwnReference> _selfStack = new Stack<NwnReference>();
    public Dictionary<string, Script> Scripts { get; set; } = new Dictionary<string, Script>();
    private readonly Dictionary<ulong, ActionDelegate> _closures = new Dictionary<ulong, ActionDelegate>();
    private ulong nextEventId;
    #endregion

    #region Plugins
    public Chat Chat { get; }
    #endregion

    #region Constructors
    public NwnServer(IntPtr nativeHandlesPtr, int nativeHandlesLength)
    {
      if (nativeHandlesPtr == IntPtr.Zero)
        throw new Exception("Received NULL bootstrap structure");

      int expectedLength = Marshal.SizeOf(typeof(NativeHandles));
      if (nativeHandlesLength < expectedLength)
        throw new Exception($"Received bootstrap structure too small - actual={nativeHandlesLength}, expected={expectedLength}");

      if (nativeHandlesLength > expectedLength)
      {
        Console.WriteLine($"WARNING: Received bootstrap structure bigger than expected - actual={nativeHandlesLength}, expected={expectedLength}");
        Console.WriteLine("         This usually means that native code version is ahead of the managed code");
      }

      _nativeFunctions = Marshal.PtrToStructure<NativeHandles>(nativeHandlesPtr);
      RegisterHandles();
      RegisterNativeEventHandles();

      //Setup Plugins
      Chat = new Chat(this);
    }
    #endregion

    #region Private Methods
    private static void SafeInvoke(Action target)
    {
      try
      {
        target();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.Message);
      }
    }
    #endregion

    #region Events
    #region TickEventArgs Subclass
    public class TickEventArgs : EventArgs
    {
      public ulong Frame { get; private set; }
      internal TickEventArgs(ulong frame) => Frame = frame;
    }
    #endregion

    public event System.EventHandler<TickEventArgs> Tick;
    protected void OnTick(ulong frame) => OnTick(new TickEventArgs(frame));
    protected virtual void OnTick(TickEventArgs e) => SafeInvoke(() => Tick?.Invoke(this, e));

    #region SignalEventArgs Subclass
    public class SignalEventArgs : EventArgs
    {
      public string Signal { get; private set; }
      internal SignalEventArgs(string signal) => Signal = signal ?? throw new ArgumentNullException(nameof(signal));
    }
    #endregion

    public event global::System.EventHandler<SignalEventArgs> Signal;
    protected void OnSignal(string signal) => OnSignal(new SignalEventArgs(signal));
    protected virtual void OnSignal(SignalEventArgs e) => SafeInvoke(() => Signal?.Invoke(this, e));

    #region RunScriptEventArgs Subclass
    public class RunScriptEventArgs : CancelEventArgs
    {
      public string Script { get; private set; }
      public NwnReference Self { get; private set; }
      internal RunScriptEventArgs(string script, NwnReference self)
      {
        Script = script;
        Self = self;
      }
    }
    #endregion

    public event global::System.EventHandler<RunScriptEventArgs> RunScript;
    protected bool OnRunScript(string script, NwnReference self) => OnRunScript(new RunScriptEventArgs(script, self));
    protected virtual bool OnRunScript(RunScriptEventArgs e)
    {
      SafeInvoke(() => RunScript?.Invoke(this, e));
      return !e.Cancel;
    }
    #endregion

    #region Interface Implementations
    uint IGameManager.ObjectSelf => _self.ID;
    void IGameManager.OnMainLoop(ulong frame) => OnTick(frame);
    void IGameManager.OnSignal(string signal) => OnSignal(signal);

    int IGameManager.OnRunScript(string script, uint oidSelf)
    {
      var self = new NwnReference(oidSelf);

      if (!OnRunScript(script, self))
        return Script.SCRIPT_NOT_HANDLED;

      if(_self != NwnReference.INVALID)
        _selfStack.Push(self);

      _self = self;

      try
      {
        return (!Scripts.TryGetValue(script, out var nwnScript)) ? Script.SCRIPT_NOT_HANDLED : nwnScript.Execute();
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex);
        return Script.SCRIPT_NOT_HANDLED;
      }
      finally
      {
        _self = _selfStack.Any() ? _selfStack.Pop() : NwnReference.INVALID;
      }
    }

    void IGameManager.OnClosure(ulong eid, uint oidSelf)
    {
      var old = _self;
      _self = new NwnReference(oidSelf);

      SafeInvoke(() => _closures[eid].Invoke());

      _closures.Remove(eid);
      _self = old;
    }

    void IGameManager.ClosureAssignCommand(uint obj, ActionDelegate func)
    {
      if (VM.ClosureAssignCommand(obj, nextEventId) != 0)
        _closures.Add(nextEventId++, func);
    }

    void IGameManager.ClosureDelayCommand(uint obj, float duration, ActionDelegate func)
    {
      if (VM.ClosureDelayCommand(obj, duration, nextEventId) != 0)
        _closures.Add(nextEventId++, func);
    }

    void IGameManager.ClosureActionDoCommand(uint obj, ActionDelegate func)
    {
      if (VM.ClosureActionDoCommand(obj, nextEventId) != 0)
        _closures.Add(nextEventId++, func);
    }
    #endregion

    #region VM
    public void Call(string plugin, string method, params object[] args)
    {
      _nativeFunctions.nwnxSetFunction(plugin, method);

      foreach (var arg in args)
        PushToNativeStack(arg);

      _nativeFunctions.nwnxCallFunction();
    }

    private static void PushToNativeStack(object arg)
    {
      if (arg is int i) _nativeFunctions.nwnxPushInt(i);
      else if (arg is float f) _nativeFunctions.nwnxPushFloat(f);
      else if (arg is string s) _nativeFunctions.nwnxPushString(s);
      else if (arg is NwnReference o) _nativeFunctions.nwnxPushObject(o.ID);
      else if (arg is NwnEngineAsset e)
      {
        switch (e.Type)
        {
          case EngineAssetType.Effect:
            NWNCore.NativeFunctions.nwnxPushEffect(e.Ptr);
            break;
          case EngineAssetType.ItemProperty:
            NWNCore.NativeFunctions.nwnxPushItemProperty(e.Ptr);
            break;
          case EngineAssetType.Location:
            Vector3 pos = NWScript.GetPositionFromLocation(e.Ptr);
            NWNCore.NativeFunctions.nwnxPushFloat(NWScript.GetFacingFromLocation(e.Ptr));
            NWNCore.NativeFunctions.nwnxPushFloat(pos.Z);
            NWNCore.NativeFunctions.nwnxPushFloat(pos.Y);
            NWNCore.NativeFunctions.nwnxPushFloat(pos.X);
            NWNCore.NativeFunctions.nwnxPushObject(NWScript.GetAreaFromLocation(e.Ptr));
            break;
          default:
            throw new NotSupportedException($"Native engine type not supported: {e.Type}");
        }
      }
      else if (arg is Vector3 v)
      {
        _nativeFunctions.nwnxPushFloat(v.X);
        _nativeFunctions.nwnxPushFloat(v.Y);
        _nativeFunctions.nwnxPushFloat(v.Z);
      }
    }
    #endregion

    public void Foo()
    {
      Chat.ServerMsg.SendMessage("DOOOM!");
      Chat.MessageArrived += (x, y) => { if (y.Message.Contains("shit")) y.Skip = true; };
    }
  }
}
