using System;
using System.Numerics;
using System.Runtime.CompilerServices;

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
      public static void SetFunction(string plugin, string method) => NWNCore.NWNXSetFunction(plugin, method);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(int value) => NWNCore.NWNXPushInt(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(float value) => NWNCore.NWNXPushFloat(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(string value) => NWNCore.NWNXPushRawString(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(uint value) => NWNCore.NWNXPushObject(value);

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(Vector3 vector)
      {
        NWNCore.NWNXPushFloat(vector.X);
        NWNCore.NWNXPushFloat(vector.Y);
        NWNCore.NWNXPushFloat(vector.Z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void StackPush(IntPtr refValue, int engineType)
      {
        switch (engineType)
        {
          case NWScript.ENGINE_STRUCTURE_EFFECT:
            NWNCore.NWNXPushEffect(refValue);
            break;
          case NWScript.ENGINE_STRUCTURE_ITEMPROPERTY:
            NWNCore.NWNXPushItemProperty(refValue);
            break;
          case NWScript.ENGINE_STRUCTURE_LOCATION:
            Vector3 pos = NWScript.GetPositionFromLocation(refValue);
            NWNCore.NWNXPushFloat(NWScript.GetFacingFromLocation(refValue));
            NWNCore.NWNXPushFloat(pos.Z);
            NWNCore.NWNXPushFloat(pos.Y);
            NWNCore.NWNXPushFloat(pos.X);
            NWNCore.NWNXPushObject(NWScript.GetAreaFromLocation(refValue));
            break;
          default:
            throw new NotSupportedException($"Native engine type not supported: {engineType}");
        }
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static void Call() => NWNCore.NWNXCallFunction();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static int StackPopInt() => NWNCore.NWNXPopInt();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static float StackPopFloat() => NWNCore.NWNXPopFloat();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static string? StackPopString() => NWNCore.NWNXPopRawString();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static uint StackPopObject() => NWNCore.NWNXPopObject();

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static Vector3 StackPopVector()
      {
        float z = NWNCore.NWNXPopFloat();
        float y = NWNCore.NWNXPopFloat();
        float x = NWNCore.NWNXPopFloat();

        return new Vector3(x, y, z);
      }

      [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
      public static IntPtr StackPopStruct(int engineType)
      {
        return engineType switch
        {
          NWScript.ENGINE_STRUCTURE_EFFECT => NWNCore.NWNXPopEffect(),
          NWScript.ENGINE_STRUCTURE_ITEMPROPERTY => NWNCore.NWNXPopItemProperty(),
          _ => throw new NotSupportedException($"Native engine type not supported: {engineType}")
        };
      }
    }
  }
}
