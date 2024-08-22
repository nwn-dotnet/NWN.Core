using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using NWN.Core.Native;

namespace NWN.Core
{
  /// <summary>
  /// Exported C++ functions from NWNX_DotNET.
  /// </summary>
  public static partial class NWNCore
  {
    [LibraryImport("NWNX_DotNET", EntryPoint = "CallBuiltIn")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void CallBuiltIn(int id);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushInteger")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushInteger(int value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushFloat")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushFloat(float value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushString([MarshalUsing(typeof(Utf16StringMarshaller))] string? value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushObject")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushObject(uint value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushVector")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushVector([MarshalUsing(typeof(Vector3Marshaller))] Vector3 value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushGameDefinedStructure")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushGameDefinedStructure(int type, IntPtr value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopInteger")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int StackPopInteger();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopFloat")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial float StackPopFloat();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(Utf16StringMarshaller))]
    public static partial string StackPopString();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopObject")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial uint StackPopObject();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopVector")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(Vector3Marshaller))]
    public static partial Vector3 StackPopVector();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopGameDefinedStructure")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IntPtr StackPopGameDefinedStructure(int type);

    [LibraryImport("NWNX_DotNET", EntryPoint = "FreeGameDefinedStructure")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IntPtr FreeGameDefinedStructure(int type, IntPtr value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "ClosureAssignCommand")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int ClosureAssignCommand(uint oid, ulong eventId);

    [LibraryImport("NWNX_DotNET", EntryPoint = "ClosureDelayCommand")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int ClosureDelayCommand(uint oid, float duration, ulong eventId);

    [LibraryImport("NWNX_DotNET", EntryPoint = "ClosureActionDoCommand")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int ClosureActionDoCommand(uint oid, ulong eventId);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXSetFunction")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXSetFunction([MarshalUsing(typeof(Utf16StringMarshaller))] string plugin, [MarshalUsing(typeof(Utf16StringMarshaller))] string function);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushInt")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushInt(int n);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushFloat")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushFloat(float f);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushObject")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushObject(uint o);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushString([MarshalUsing(typeof(Utf16StringMarshaller))] string s);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushEffect")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushEffect(IntPtr value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushItemProperty")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushItemProperty(IntPtr value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopInt")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int NWNXPopInt();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopFloat")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial float NWNXPopFloat();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopObject")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial uint NWNXPopObject();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(Utf16StringMarshaller))]
    public static partial string NWNXPopString();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopEffect")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IntPtr NWNXPopEffect();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopItemProperty")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IntPtr NWNXPopItemProperty();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXCallFunction")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXCallFunction();

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

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushRawString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPushRawString([MarshalUsing(typeof(NwStringMarshaller))] string? value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopRawString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(NwStringMarshaller))]
    public static partial string? StackPopRawString();

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushRawString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void NWNXPushRawString([MarshalUsing(typeof(NwStringMarshaller))] string? value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopRawString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(NwStringMarshaller))]
    public static partial string? NWNXPopRawString();
  }
}
