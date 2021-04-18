using System;
using System.Collections.Generic;

namespace NWN.Core
{
  /// <summary>
  /// Simple GameManager implementation. Used by default if no manager is specified during bootstrap.
  /// </summary>
  public class CoreGameManager : ICoreFunctionHandler, ICoreEventHandler
  {
    // Hook-able Events
    public delegate void ServerLoopEvent(ulong frame);
    public event ServerLoopEvent? OnServerLoop;

    public delegate void SignalEvent(string signal);
    public event SignalEvent? OnSignal;

    public delegate void RunScriptEvent(string scriptName, uint objectSelf, out int scriptHandleResult);
    public event RunScriptEvent? OnRunScript;

    // Native Management
    private readonly Stack<uint> scriptContexts = new Stack<uint>();
    private readonly Dictionary<ulong, ActionDelegate> closures = new Dictionary<ulong, ActionDelegate>();
    private ulong nextEventId;

    private const uint ObjectInvalid = 0x7F000000;
    private uint objectSelf = ObjectInvalid;

    // Interface Implementations
    uint ICoreFunctionHandler.ObjectSelf => objectSelf;

    void ICoreEventHandler.OnMainLoop(ulong frame)
        => OnServerLoop?.Invoke(frame);

    void ICoreEventHandler.OnSignal(string signal)
        => OnSignal?.Invoke(signal);

    int ICoreEventHandler.OnRunScript(string script, uint oidSelf)
    {
      int retVal = -1;
      objectSelf = oidSelf;
      scriptContexts.Push(oidSelf);

      try
      {
        OnRunScript?.Invoke(script, oidSelf, out retVal);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      scriptContexts.Pop();
      objectSelf = scriptContexts.Count == 0 ? ObjectInvalid : scriptContexts.Peek();
      return retVal;
    }

    void ICoreEventHandler.OnClosure(ulong eid, uint oidSelf)
    {
      uint old = objectSelf;
      objectSelf = oidSelf;

      try
      {
        closures[eid].Invoke();
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      closures.Remove(eid);
      objectSelf = old;
    }

    void ICoreFunctionHandler.ClosureAssignCommand(uint obj, ActionDelegate func)
    {
      if (VM.ClosureAssignCommand(obj, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }

    void ICoreFunctionHandler.ClosureDelayCommand(uint obj, float duration, ActionDelegate func)
    {
      if (VM.ClosureDelayCommand(obj, duration, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }

    void ICoreFunctionHandler.ClosureActionDoCommand(uint obj, ActionDelegate func)
    {
      if (VM.ClosureActionDoCommand(obj, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }
  }
}
