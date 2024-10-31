using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NWN.Core.Native;

namespace NWN.Core
{
  /// <summary>
  /// Additional function exports from NWNX_DotNET.<br/>
  /// VM functions are not defined here. See <see cref="VM"/>.
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
