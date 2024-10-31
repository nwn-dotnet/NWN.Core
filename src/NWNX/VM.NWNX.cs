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
    public static partial class NWNX
    {
      static NWNX()
      {
        if (NWNCore.FunctionHandler == null)
        {
          throw new InvalidOperationException("Attempted to call a VM function before NWN.Core was initialised. Initialise NWN.Core first using NWNCore.Init()");
        }
      }

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXSetFunction")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial void SetFunction([MarshalUsing(typeof(Utf16StringMarshaller))] string plugin, [MarshalUsing(typeof(Utf16StringMarshaller))] string function);

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushInt")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial void StackPush(int value);

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushFloat")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial void StackPush(float value);

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushRawString")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial void StackPush([MarshalUsing(typeof(NwStringMarshaller))] string? value);

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushObject")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial void StackPush(uint value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(Vector3 vector)
      {
        StackPush(vector.X);
        StackPush(vector.Y);
        StackPush(vector.Z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(int engineType, IntPtr refValue)
      {
        switch (engineType)
        {
          case NWScript.ENGINE_STRUCTURE_EFFECT:
            PushEffect(refValue);
            break;
          case NWScript.ENGINE_STRUCTURE_ITEMPROPERTY:
            PushItemProperty(refValue);
            break;
          case NWScript.ENGINE_STRUCTURE_LOCATION:
            Vector3 pos = NWScript.GetPositionFromLocation(refValue);
            StackPush(NWScript.GetFacingFromLocation(refValue));
            StackPush(pos.Z);
            StackPush(pos.Y);
            StackPush(pos.X);
            StackPush(NWScript.GetAreaFromLocation(refValue));
            break;
          default:
            throw new NotSupportedException($"Native engine type not supported: {engineType}");
        }
      }

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushEffect")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      internal static partial void PushEffect(IntPtr value);

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPushItemProperty")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      internal static partial void PushItemProperty(IntPtr value);

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXCallFunction")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial void Call();

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopInt")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial int StackPopInt();

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopFloat")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial float StackPopFloat();

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopRawString")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      [return: MarshalUsing(typeof(NwStringMarshaller))]
      public static partial string? StackPopString();

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopObject")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      public static partial uint StackPopObject();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static Vector3 StackPopVector()
      {
        float z = StackPopFloat();
        float y = StackPopFloat();
        float x = StackPopFloat();

        return new Vector3(x, y, z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static IntPtr StackPopStruct(int engineType)
      {
        return engineType switch
        {
          NWScript.ENGINE_STRUCTURE_EFFECT => PopEffect(),
          NWScript.ENGINE_STRUCTURE_ITEMPROPERTY => PopItemProperty(),
          _ => throw new NotSupportedException($"Native engine type not supported: {engineType}")
        };
      }

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopEffect")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      internal static partial IntPtr PopEffect();

      [LibraryImport("NWNX_DotNET", EntryPoint = "NWNXPopItemProperty")]
      [UnmanagedCallConv(CallConvs = new[] { typeof(CallConvCdecl) })]
      internal static partial IntPtr PopItemProperty();
    }
  }
}
