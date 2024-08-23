using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NWN.Core.Native;

namespace NWN.Core
{
  /// <summary>
  /// Exported C++ functions from NWNX_DotNET.
  /// </summary>
  public static partial class NWNCore
  {
    [LibraryImport("NWNX_DotNET", EntryPoint = "RequestHook")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IntPtr RequestHook(IntPtr address, IntPtr managedFuncPtr, int priority);

    [LibraryImport("NWNX_DotNET", EntryPoint = "ReturnHook")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void ReturnHook(IntPtr hook);

    [LibraryImport("NWNX_DotNET", EntryPoint = "RequestFunctionHook")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static unsafe partial FunctionHook* RequestFunctionHook(IntPtr address, IntPtr managedFuncPtr, int priority);

    [LibraryImport("NWNX_DotNET", EntryPoint = "ReturnFunctionHook")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static unsafe partial void ReturnFunctionHook(FunctionHook* hook);
  }
}
