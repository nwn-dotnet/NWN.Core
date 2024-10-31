using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using NWN.Core.Native;

namespace NWN.Core
{
  public static partial class VM
  {
    static VM()
    {
      if (NWNCore.FunctionHandler == null)
      {
        throw new InvalidOperationException("Attempted to call a VM function before NWN.Core was initialised. Initialise NWN.Core first using NWNCore.Init()");
      }
    }

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushInteger")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPush(int value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushFloat")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPush(float value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushRawString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPush([MarshalUsing(typeof(NwStringMarshaller))] string? value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushObject")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPush(uint value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushVector")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPush([MarshalUsing(typeof(Vector3Marshaller))] Vector3 value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPushGameDefinedStructure")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void StackPush(int type, IntPtr value);

    [LibraryImport("NWNX_DotNET", EntryPoint = "CallBuiltIn")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial void Call(int id);

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopInteger")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial int StackPopInt();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopFloat")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial float StackPopFloat();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopRawString")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(NwStringMarshaller))]
    public static partial string? StackPopString();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopObject")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial uint StackPopObject();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopVector")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    [return: MarshalUsing(typeof(Vector3Marshaller))]
    public static partial Vector3 StackPopVector();

    [LibraryImport("NWNX_DotNET", EntryPoint = "StackPopGameDefinedStructure")]
    [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
    public static partial IntPtr StackPopStruct(int type);

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
  }
}
