using System;
using System.Runtime.InteropServices;

namespace NWN.Core
{
  public static partial class NWNCore
  {
    public delegate void MainLoopHandlerDelegate(ulong frame);

    public delegate int RunScriptHandlerDelegate(string script, uint oid);

    public delegate void ClosureHandlerDelegate(ulong eid, uint oid);

    public delegate void SignalHandlerDelegate(string signal);

    public delegate void AssertHandlerDelegate(string message, string stackTrace);

    public delegate void CrashHandlerDelegate(int signal, string stackTrace);

    [StructLayout(LayoutKind.Sequential)]
    public struct NativeEventHandles
    {
      public MainLoopHandlerDelegate MainLoop;
      public RunScriptHandlerDelegate RunScript;
      public ClosureHandlerDelegate Closure;
      public SignalHandlerDelegate Signal;
      public AssertHandlerDelegate AssertFail;
      public CrashHandlerDelegate CrashHandler;
    }

#if !NETCOREAPP3_1
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct NativeEventHandlesUnmanaged
    {
      public delegate* unmanaged<ulong, void> MainLoop;
      public delegate* unmanaged<IntPtr, uint, int> RunScript;
      public delegate* unmanaged<ulong, uint, void> Closure;
      public delegate* unmanaged<IntPtr, void> Signal;
      public delegate* unmanaged<IntPtr, IntPtr, void> AssertFail;
      public delegate* unmanaged<int, IntPtr, void> CrashHandler;
    }
#endif
  }
}
