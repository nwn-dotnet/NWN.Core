using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace NWN.Core
{
  public partial class NWScript
  {
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void StackPush(int value) => Internal.NativeFunctions.StackPushInteger(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void StackPush(float value) => Internal.NativeFunctions.StackPushFloat(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void StackPush(string value) => Internal.NativeFunctions.StackPushString(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void StackPush(uint value) => Internal.NativeFunctions.StackPushObject(value);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void StackPush(Vector3 vector) => Internal.NativeFunctions.StackPushVector(vector);
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void StackPush(IntPtr refValue, int engineType) => Internal.NativeFunctions.StackPushGameDefinedStructure(engineType, refValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static void Call(int functionId) => Internal.NativeFunctions.CallBuiltIn(functionId);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static int StackPopInt() => Internal.NativeFunctions.StackPopInteger();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static float StackPopFloat() => Internal.NativeFunctions.StackPopFloat();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static string StackPopString() => Internal.NativeFunctions.StackPopString();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static uint StackPopObject() => Internal.NativeFunctions.StackPopObject();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static Vector3 StackPopVector() => Internal.NativeFunctions.StackPopVector();
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    private static IntPtr StackPopStruct(int engineType) => Internal.NativeFunctions.StackPopGameDefinedStructure(engineType);
  }
}