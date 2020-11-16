using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Nwn.Server.Interop;

namespace Nwn.Server
{
  public class NwnServer
  {
    #region Static Members
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

    #endregion

    #region Fields
    private NwnReference _self = NwnReference.INVALID;
    private Stack<NwnReference> _selfStack = new Stack<NwnReference>();
    internal Dictionary<string, Script> Scripts { get; set; } = new Dictionary<string, Script>();
    private readonly Dictionary<ulong, ActionDelegate> _closures = new Dictionary<ulong, ActionDelegate>();
    private ulong nextEventId;

    private NativeFunctions _functions;
    private NativeEvents _events;
    #endregion

    #region Properties
    internal NwnReference Self => _self;
    #endregion

    #region Plugins
    public Chat Chat { get; }
    #endregion

    #region Constructors
    public NwnServer(IntPtr nativeHandlesPtr, int nativeHandlesLength)
    {
      if (nativeHandlesPtr == IntPtr.Zero)
        throw new Exception("Received NULL bootstrap structure");

      int expectedLength = Marshal.SizeOf(typeof(NativeFunctions));
      if (nativeHandlesLength < expectedLength)
        throw new Exception($"Received bootstrap structure too small - actual={nativeHandlesLength}, expected={expectedLength}");

      if (nativeHandlesLength > expectedLength)
      {
        Console.WriteLine($"WARNING: Received bootstrap structure bigger than expected - actual={nativeHandlesLength}, expected={expectedLength}");
        Console.WriteLine("         This usually means that native code version is ahead of the managed code");
      }

      _functions = Marshal.PtrToStructure<NativeFunctions>(nativeHandlesPtr);
      RegisterHandles();
      RegisterNativeEventHandles();

      //Setup Plugins
      Chat = new Chat(this);
    }
    #endregion

    #region Private Methods
    private void RegisterHandles()
    {
      _events.MainLoop = OnTick;
      _events.RunScript = RunScript;
      _events.Closure = Closure;
      _events.Signal = OnSignal;
    }

    private void RegisterNativeEventHandles()
    {
      int size = Marshal.SizeOf(typeof(NativeEvents));
      IntPtr ptr = Marshal.AllocHGlobal(size);
      try
      {
        Marshal.StructureToPtr(_events, ptr, false);
        _functions.RegisterHandlers(ptr, (uint)size);
      }
      finally
      {
        Marshal.FreeHGlobal(ptr);
      }
    }

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

    #endregion

    #region Native Routines
    int RunScript(string script, uint oidSelf)
    {
      var self = new NwnReference(oidSelf);

      if(_self.IsValid())
        _selfStack.Push(self);

      _self = self;

      try
      {
        return (!Scripts.TryGetValue(script, out var nwnScript)) ? Script.NOT_HANDLED : nwnScript.ExecuteValue();
      }
      catch(Exception ex)
      {
        Console.WriteLine(ex);
        return Script.NOT_HANDLED;
      }
      finally
      {
        _self = _selfStack.Any() ? _selfStack.Pop() : NwnReference.INVALID;
      }
    }

    //Used by the native function wrappers for some reason.
    void Closure(ulong eid, uint oidSelf)
    {
      var old = _self;
      _self = new NwnReference(oidSelf);

      SafeInvoke(() => _closures[eid].Invoke());

      _closures.Remove(eid);
      _self = old;
    }

    internal void ClosureAssignCommand(uint obj, ActionDelegate func)
    {
      if (_functions.ClosureAssignCommand(obj, nextEventId) != 0)
        _closures.Add(nextEventId++, func);
    }

    internal void ClosureDelayCommand(uint obj, float duration, ActionDelegate func)
    {
      if (_functions.ClosureDelayCommand(obj, duration, nextEventId) != 0)
        _closures.Add(nextEventId++, func);
    }

    internal void ClosureActionDoCommand(uint obj, ActionDelegate func)
    {
      if (_functions.ClosureActionDoCommand(obj, nextEventId) != 0)
        _closures.Add(nextEventId++, func);
    }
    #endregion

    #region VM
    public void Call(string plugin, string method, params object[] args)
    {
      _functions.nwnxSetFunction(plugin, method);

      foreach (var arg in args)
        PushToNativeStack(arg);

      _functions.nwnxCallFunction();
    }

    private void PushToNativeStack(object arg)
    {
      if (arg is int i) _functions.nwnxPushInt(i);
      else if (arg is float f) _functions.nwnxPushFloat(f);
      else if (arg is string s) _functions.nwnxPushString(s);
      else if (arg is NwnReference o) _functions.nwnxPushObject(o.ID);
      else if (arg is NwnEngineAsset e)
      {
        switch (e.Type)
        {
          case EngineAssetType.Effect:
            _functions.nwnxPushEffect(e.Ptr);
            break;
          case EngineAssetType.ItemProperty:
            _functions.nwnxPushItemProperty(e.Ptr);
            break;
          case EngineAssetType.Location:
            Vector3 pos = _functions.GetPositionFromLocation(e.Ptr);
            _functions.nwnxPushFloat(_functions.GetFacingFromLocation(e.Ptr));
            _functions.nwnxPushFloat(pos.Z);
            _functions.nwnxPushFloat(pos.Y);
            _functions.nwnxPushFloat(pos.X);
            _functions.nwnxPushObject(_functions.GetAreaFromLocation(e.Ptr));
            break;
          default:
            throw new NotSupportedException($"Native engine type not supported: {e.Type}");
        }
      }
      else if (arg is Vector3 v)
      {
        _functions.nwnxPushFloat(v.X);
        _functions.nwnxPushFloat(v.Y);
        _functions.nwnxPushFloat(v.Z);
      }
    }
    #endregion

    public static void Foo()
    {
      var nwn = NwnServer.Instance;
      nwn.Chat.ServerChannel.SendMessage("DOOOM!");
      nwn.Chat.MessageArrived += (x, y) => { if (y.Message.Contains("shit")) y.Skip = true; };
    }
  }
}
