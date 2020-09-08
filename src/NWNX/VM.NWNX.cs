using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace NWN.Core
{
    public static partial class VM
    {
        public static class NWNX
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void SetFunction(string plugin, string method) => NWNCore.NativeFunctions.nwnxSetFunction(plugin, method);

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void StackPush(int value) => NWNCore.NativeFunctions.nwnxPushInt(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void StackPush(float value) => NWNCore.NativeFunctions.nwnxPushFloat(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void StackPush(string value) => NWNCore.NativeFunctions.nwnxPushString(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void StackPush(uint value) => NWNCore.NativeFunctions.nwnxPushObject(value);

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void StackPush(Vector3 vector)
            {
                NWNCore.NativeFunctions.nwnxPushFloat(vector.X);
                NWNCore.NativeFunctions.nwnxPushFloat(vector.Y);
                NWNCore.NativeFunctions.nwnxPushFloat(vector.Z);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void StackPush(IntPtr refValue, int engineType)
            {
                switch (engineType)
                {
                    case NWScript.ENGINE_STRUCTURE_EFFECT:
                        NWNCore.NativeFunctions.nwnxPushEffect(refValue);
                        break;
                    case NWScript.ENGINE_STRUCTURE_ITEM_PROPERTY:
                        NWNCore.NativeFunctions.nwnxPushItemProperty(refValue);
                        break;
                    default:
                        throw new NotSupportedException($"Native engine type not supported: {engineType}");
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static void Call() => NWNCore.NativeFunctions.nwnxCallFunction();

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static int StackPopInt() => NWNCore.NativeFunctions.nwnxPopInt();

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static float StackPopFloat() => NWNCore.NativeFunctions.nwnxPopFloat();

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static string StackPopString() => NWNCore.NativeFunctions.nwnxPopString();

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static uint StackPopObject() => NWNCore.NativeFunctions.nwnxPopObject();

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static Vector3 StackPopVector()
            {
                float z = NWNCore.NativeFunctions.nwnxPopFloat();
                float y = NWNCore.NativeFunctions.nwnxPopFloat();
                float x = NWNCore.NativeFunctions.nwnxPopFloat();

                return new Vector3(x, y, z);
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
            public static IntPtr StackPopStruct(int engineType)
            {
                switch (engineType)
                {
                    case NWScript.ENGINE_STRUCTURE_EFFECT:
                        return NWNCore.NativeFunctions.nwnxPopEffect();
                    case NWScript.ENGINE_STRUCTURE_ITEM_PROPERTY:
                        return NWNCore.NativeFunctions.nwnxPopItemProperty();
                    default:
                        throw new NotSupportedException($"Native engine type not supported: {engineType}");
                }
            }
        }
    }
}