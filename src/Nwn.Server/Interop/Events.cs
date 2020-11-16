using System;
using System.Runtime.InteropServices;

namespace Nwn.Server.Interop
{
  internal delegate void MainLoopHandlerDelegate(ulong frame);

  internal delegate int RunScriptHandlerDelegate(string script, uint oid);

  internal delegate void ClosureHandlerDelegate(ulong eid, uint oid);

  internal delegate void SignalHandlerDelegate(string signal);

  [StructLayout(LayoutKind.Sequential)]
  internal struct NativeEvents
  {
    internal MainLoopHandlerDelegate MainLoop;
    internal RunScriptHandlerDelegate RunScript;
    internal ClosureHandlerDelegate Closure;
    internal SignalHandlerDelegate Signal;

    public void Register(NativeFunctions functions)
    {
      int size = Marshal.SizeOf(typeof(NativeEvents));
      IntPtr ptr = Marshal.AllocHGlobal(size);
      try
      {
        Marshal.StructureToPtr(this, ptr, false);
        functions.RegisterHandlers(ptr, (uint)size);
      }
      finally
      {
        Marshal.FreeHGlobal(ptr);
      }
    }
  }
}
