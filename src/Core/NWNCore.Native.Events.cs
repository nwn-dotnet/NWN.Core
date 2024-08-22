using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NWN.Core
{
  public static unsafe partial class NWNCore
  {
    [LibraryImport("NWNX_DotNET", EntryPoint = "RegisterMainLoopHandler")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RegisterMainLoopHandler(delegate* unmanaged<ulong, void> handler);

    [LibraryImport("NWNX_DotNET", EntryPoint = "RegisterRunScriptHandler")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RegisterRunScriptHandler(delegate* unmanaged<IntPtr, uint, int> handler);

    [LibraryImport("NWNX_DotNET", EntryPoint = "RegisterClosureHandler")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RegisterClosureHandler(delegate* unmanaged<ulong, uint, void> handler);

    [LibraryImport("NWNX_DotNET", EntryPoint = "RegisterSignalHandler")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RegisterSignalHandler(delegate* unmanaged<IntPtr, void> handler);

    [LibraryImport("NWNX_DotNET", EntryPoint = "RegisterAssertHandler")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RegisterAssertHandler(delegate* unmanaged<IntPtr, IntPtr, void> handler);

    [LibraryImport("NWNX_DotNET", EntryPoint = "RegisterCrashHandler")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void RegisterCrashHandler(delegate* unmanaged<int, IntPtr, void> handler);
  }
}
