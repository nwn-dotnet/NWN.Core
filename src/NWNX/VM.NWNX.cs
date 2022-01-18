using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace NWN.Core
{
  public static partial class VM
  {
    public static class NWNX
    {
      static NWNX()
      {
        if (NWNCore.FunctionHandler == null)
        {
          throw new InvalidOperationException("Attempted to call a VM function before NWN.Core was initialised. Initialise NWN.Core first using NWNCore.Init()");
        }
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void SetFunction(string plugin, string method) => NWNCore.NativeFunctions.NWNXSetFunction(plugin, method);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(int value) => NWNCore.NativeFunctions.NWNXPushInt(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(float value) => NWNCore.NativeFunctions.NWNXPushFloat(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(string value)
      {
        IntPtr charPtr = GetNullTerminatedString(value);
        NWNCore.NativeFunctions.NWNXPushRawString(charPtr);
        Marshal.FreeHGlobal(charPtr);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(uint value) => NWNCore.NativeFunctions.NWNXPushObject(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(Vector3 vector)
      {
        NWNCore.NativeFunctions.NWNXPushFloat(vector.X);
        NWNCore.NativeFunctions.NWNXPushFloat(vector.Y);
        NWNCore.NativeFunctions.NWNXPushFloat(vector.Z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(IntPtr refValue, int engineType)
      {
        switch (engineType)
        {
          case NWScript.ENGINE_STRUCTURE_EFFECT:
            NWNCore.NativeFunctions.NWNXPushEffect(refValue);
            break;
          case NWScript.ENGINE_STRUCTURE_ITEMPROPERTY:
            NWNCore.NativeFunctions.NWNXPushItemProperty(refValue);
            break;
          case NWScript.ENGINE_STRUCTURE_LOCATION:
            Vector3 pos = NWScript.GetPositionFromLocation(refValue);
            NWNCore.NativeFunctions.NWNXPushFloat(NWScript.GetFacingFromLocation(refValue));
            NWNCore.NativeFunctions.NWNXPushFloat(pos.Z);
            NWNCore.NativeFunctions.NWNXPushFloat(pos.Y);
            NWNCore.NativeFunctions.NWNXPushFloat(pos.X);
            NWNCore.NativeFunctions.NWNXPushObject(NWScript.GetAreaFromLocation(refValue));
            break;
          default:
            throw new NotSupportedException($"Native engine type not supported: {engineType}");
        }
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void Call() => NWNCore.NativeFunctions.NWNXCallFunction();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static int StackPopInt() => NWNCore.NativeFunctions.NWNXPopInt();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static float StackPopFloat() => NWNCore.NativeFunctions.NWNXPopFloat();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static string? StackPopString() => ReadNullTerminatedString(NWNCore.NativeFunctions.NWNXPopRawString());

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static uint StackPopObject() => NWNCore.NativeFunctions.NWNXPopObject();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static Vector3 StackPopVector()
      {
        float z = NWNCore.NativeFunctions.NWNXPopFloat();
        float y = NWNCore.NativeFunctions.NWNXPopFloat();
        float x = NWNCore.NativeFunctions.NWNXPopFloat();

        return new Vector3(x, y, z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static IntPtr StackPopStruct(int engineType)
      {
        return engineType switch
        {
          NWScript.ENGINE_STRUCTURE_EFFECT => NWNCore.NativeFunctions.NWNXPopEffect(),
          NWScript.ENGINE_STRUCTURE_ITEMPROPERTY => NWNCore.NativeFunctions.NWNXPopItemProperty(),
          _ => throw new NotSupportedException($"Native engine type not supported: {engineType}")
        };
      }
    }
  }
}
