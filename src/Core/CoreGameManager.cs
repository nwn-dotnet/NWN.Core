using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NWN.Core.Native;

namespace NWN.Core
{
  /// <summary>
  /// Simple GameManager implementation. Used by default if no manager is specified during bootstrap.
  /// </summary>
  public sealed class CoreGameManager : ICoreFunctionHandler
  {
    // Hook-able Events
    public delegate void ServerLoopEvent(ulong frame);

    /// <inheritdoc cref="ICoreEventHandler.OnMainLoop"/>
    public static event ServerLoopEvent? OnServerLoop;

    public delegate void SignalEvent(string signal);

    /// <inheritdoc cref="ICoreEventHandler.OnSignal"/>
    public static event SignalEvent? OnSignal;

    public delegate void RunScriptEvent(string scriptName, uint objectSelf, out int scriptHandleResult);

    /// <inheritdoc cref="ICoreEventHandler.OnRunScript"/>
    public static event RunScriptEvent? OnRunScript;

    // Native Management
    private static readonly Stack<uint> scriptContexts = new Stack<uint>();
    private static readonly Dictionary<ulong, Action> closures = new Dictionary<ulong, Action>();
    private static ulong nextEventId;

    private const uint ObjectInvalid = 0x7F000000;
    private static uint objectSelf = ObjectInvalid;

    // Interface Implementations
    uint ICoreFunctionHandler.ObjectSelf => objectSelf;

    [UnmanagedCallersOnly]
    internal static void MainLoopHandler(ulong frame) => OnServerLoop?.Invoke(frame);

    [UnmanagedCallersOnly]
    internal static unsafe void SignalHandler(IntPtr pSignal) => OnSignal?.Invoke(NwStringMarshaller.ConvertToManaged((byte*)pSignal)!);

    [UnmanagedCallersOnly]
    internal static void AssertFailHandler(IntPtr pMessage, IntPtr pStackTrace)
    {
      StackTrace managedStackTrace = new StackTrace(true);
      Console.Error.WriteLine(managedStackTrace.ToString());
    }

    [UnmanagedCallersOnly]
    internal static unsafe void CrashHandler(int signal, IntPtr pStackTrace)
    {
      Console.Error.WriteLine(NwStringMarshaller.ConvertToManaged((byte*)pStackTrace));

      StackTrace managedStackTrace = new StackTrace(true);
      Console.Error.WriteLine(managedStackTrace.ToString());
    }

    [UnmanagedCallersOnly]
    internal static unsafe int RunScriptHandler(IntPtr pScript, uint oidSelf)
    {
      int retVal = -1;
      objectSelf = oidSelf;
      scriptContexts.Push(oidSelf);
      string? script = NwStringMarshaller.ConvertToManaged((byte*)pScript);

      try
      {
        OnRunScript?.Invoke(script!, oidSelf, out retVal);
      }
      catch (Exception e)
      {
        Console.WriteLine(e);
      }

      scriptContexts.Pop();
      objectSelf = scriptContexts.Count == 0 ? ObjectInvalid : scriptContexts.Peek();
      return retVal;
    }

    [UnmanagedCallersOnly]
    internal static void ClosureHandler(ulong eid, uint oidSelf)
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
