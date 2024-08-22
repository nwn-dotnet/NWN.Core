using System.Runtime.InteropServices;

namespace NWN.Core.Native
{
  [StructLayout(LayoutKind.Sequential)]
  public readonly unsafe struct FunctionHook
  {
    public readonly void* m_originalFunction;
    public readonly void* m_newFunction;
    public readonly int m_order;
    public readonly void* m_funchook;
    public readonly void* m_trampoline;
  }
}
