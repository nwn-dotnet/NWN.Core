using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

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

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void StackPush(int value) => NWNCore.StackPushInteger(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void StackPush(float value) => NWNCore.StackPushFloat(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void StackPush(string value)
    {
      IntPtr charPtr = GetNullTerminatedString(value);
      NWNCore.StackPushRawString(charPtr);
      Marshal.FreeHGlobal(charPtr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void StackPush(uint value) => NWNCore.StackPushObject(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void StackPush(Vector3 vector) => NWNCore.StackPushVector(vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void StackPush(IntPtr refValue, int engineType) => NWNCore.StackPushGameDefinedStructure(engineType, refValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void Call(int functionId) => NWNCore.CallBuiltIn(functionId);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int StackPopInt() => NWNCore.StackPopInteger();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static float StackPopFloat() => NWNCore.StackPopFloat();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static string? StackPopString() => ReadNullTerminatedString(NWNCore.StackPopRawString());

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static uint StackPopObject() => NWNCore.StackPopObject();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static Vector3 StackPopVector() => NWNCore.StackPopVector();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static IntPtr StackPopStruct(int engineType) => NWNCore.StackPopGameDefinedStructure(engineType);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void FreeGameDefinedStructure(int type, IntPtr str) => NWNCore.FreeGameDefinedStructure(type, str);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ClosureAssignCommand(uint oid, ulong eventId) => NWNCore.ClosureAssignCommand(oid, eventId);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ClosureDelayCommand(uint oid, float duration, ulong eventId) => NWNCore.ClosureDelayCommand(oid, duration, eventId);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static int ClosureActionDoCommand(uint oid, ulong eventId) => NWNCore.ClosureActionDoCommand(oid, eventId);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static IntPtr RequestHook(IntPtr address, IntPtr managedFuncPtr, int priority) => NWNCore.RequestHook(address, managedFuncPtr, priority);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public static void ReturnHook(IntPtr funcPtr) => NWNCore.ReturnHook(funcPtr);

    public static IntPtr GetNullTerminatedString(string? value)
    {
      if (value == null)
      {
        return IntPtr.Zero;
      }

      byte[] bytes = NWNCore.Encoding.GetBytes(value);
      IntPtr buffer = Marshal.AllocHGlobal(bytes.Length + 1);
      Marshal.Copy(bytes, 0, buffer, bytes.Length);

      // Write null terminator
      Marshal.WriteByte(buffer + bytes.Length, 0);
      return buffer;
    }

    private static unsafe string? ReadNullTerminatedString(IntPtr cString)
    {
      if (cString == IntPtr.Zero)
      {
        return null;
      }

      byte* charPointer = (byte*)cString;
      return NWNCore.Encoding.GetString(charPointer, GetStringLength(charPointer));
    }

    private static unsafe int GetStringLength(byte* cString)
    {
      byte* walk = cString;
      while (*walk != 0)
      {
        walk++;
      }

      return (int)(walk - cString);
    }
  }
}
