using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace NWN.Core
{
  /// <summary>
  /// Simple GameManager implementation. Used by default if no manager is specified during bootstrap.
  /// </summary>
  public class CoreGameManager : ICoreFunctionHandler, ICoreEventHandler
  {
    // Hook-able Events
    public delegate void ServerLoopEvent(ulong frame);

    /// <inheritdoc cref="ICoreEventHandler.OnMainLoop"/>
    public event ServerLoopEvent? OnServerLoop;

    public delegate void SignalEvent(string signal);

    /// <inheritdoc cref="ICoreEventHandler.OnSignal"/>
    public event SignalEvent? OnSignal;

    public delegate void RunScriptEvent(string scriptName, uint objectSelf, out int scriptHandleResult);

    /// <inheritdoc cref="ICoreEventHandler.OnRunScript"/>
    public event RunScriptEvent? OnRunScript;

    // Native Management
    private readonly Stack<uint> scriptContexts = new Stack<uint>();
    private readonly Dictionary<ulong, Action> closures = new Dictionary<ulong, Action>();
    private ulong nextEventId;

    private const uint ObjectInvalid = 0x7F000000;
    private uint objectSelf = ObjectInvalid;

    // Interface Implementations
    uint ICoreFunctionHandler.ObjectSelf => objectSelf;

    void ICoreEventHandler.OnMainLoop(ulong frame)
        => OnServerLoop?.Invoke(frame);

    void ICoreEventHandler.OnSignal(string signal)
        => OnSignal?.Invoke(signal);

    public void OnAssertFail(string message, string stackTrace)
    {
      StackTrace managedStackTrace = new StackTrace(true);
      Console.Error.WriteLine(managedStackTrace.ToString());
    }

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

    void ICoreFunctionHandler.ClosureAssignCommand(uint obj, Action func)
    {
      if (VM.ClosureAssignCommand(obj, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }

    void ICoreFunctionHandler.ClosureDelayCommand(uint obj, float duration, Action func)
    {
      if (VM.ClosureDelayCommand(obj, duration, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }

    void ICoreFunctionHandler.ClosureActionDoCommand(uint obj, Action func)
    {
      if (VM.ClosureActionDoCommand(obj, nextEventId) != 0)
      {
        closures.Add(nextEventId++, func);
      }
    }
  }
}
