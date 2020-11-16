using System.Runtime.InteropServices;

namespace NWN.Core
{
  public static partial class NWNCore
  {
    public delegate void MainLoopHandlerDelegate(ulong frame);

    public delegate int RunScriptHandlerDelegate(string script, uint oid);

    public delegate void ClosureHandlerDelegate(ulong eid, uint oid);

    public delegate void SignalHandlerDelegate(string signal);

    [StructLayout(LayoutKind.Sequential)]
    public struct NativeEventHandles
    {
      public MainLoopHandlerDelegate MainLoop;
      public RunScriptHandlerDelegate RunScript;
      public ClosureHandlerDelegate Closure;
      public SignalHandlerDelegate Signal;
    }
  }
}
