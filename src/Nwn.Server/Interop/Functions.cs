using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

namespace Nwn.Server.Interop
{
  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate IntPtr GetFunctionPointerDelegate(string name);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void RegisterHandlersDelegate(IntPtr handlers, uint size);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void CallBuiltInDelegate(int id);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushIntegerDelegate(int value);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushFloatDelegate(float value);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushStringDelegate(string value);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushStringUTF8Delegate(string value);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushObjectDelegate(uint value);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushVectorDelegate(Vector3 value);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void StackPushGameDefinedStructureDelegate(int type, IntPtr str);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate int StackPopIntegerDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate float StackPopFloatDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate string StackPopStringDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate string StackPopStringUTF8Delegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate uint StackPopObjectDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate Vector3 StackPopVectorDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate IntPtr StackPopGameDefinedStructureDelegate(int type);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void FreeEffectDelegate(IntPtr ptr);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void FreeEventDelegate(IntPtr ptr);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void FreeLocationDelegate(IntPtr ptr);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void FreeTalentDelegate(IntPtr ptr);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void FreeItemPropertyDelegate(IntPtr ptr);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate IntPtr FreeGameDefinedStructureDelegate(int type, IntPtr str);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate int ClosureAssignCommandDelegate(uint oid, ulong eventId);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate int ClosureDelayCommandDelegate(uint oid, float duration, ulong eventId);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate int ClosureActionDoCommandDelegate(uint oid, ulong eventId);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxSetFunctionDelegate(string plugin, string function);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushIntDelegate(int n);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushFloatDelegate(float f);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushObjectDelegate(uint o);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushStringDelegate(string s);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushStringUTF8Delegate(string s);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushEffectDelegate(IntPtr e);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxPushItemPropertyDelegate(IntPtr ip);

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate int nwnxPopIntDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate float nwnxPopFloatDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate uint nwnxPopObjectDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate string nwnxPopStringDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate string nwnxPopStringUTF8Delegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate IntPtr nwnxPopEffectDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate IntPtr nwnxPopItemPropertyDelegate();

  [SuppressUnmanagedCodeSecurity]
  [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
  internal delegate void nwnxCallFunctionDelegate();

  [StructLayout(LayoutKind.Sequential)]
  internal readonly partial struct NativeFunctions
  {
    internal readonly GetFunctionPointerDelegate GetFunctionPointer;
    internal readonly RegisterHandlersDelegate RegisterHandlers;
    internal readonly CallBuiltInDelegate CallBuiltIn;
    internal readonly StackPushIntegerDelegate StackPushInteger;
    internal readonly StackPushFloatDelegate StackPushFloat;
    internal readonly StackPushStringDelegate StackPushString;
    internal readonly StackPushStringUTF8Delegate StackPushStringUTF8;
    internal readonly StackPushObjectDelegate StackPushObject;
    internal readonly StackPushVectorDelegate StackPushVector;
    internal readonly StackPushGameDefinedStructureDelegate StackPushGameDefinedStructure;
    internal readonly StackPopIntegerDelegate StackPopInteger;
    internal readonly StackPopFloatDelegate StackPopFloat;
    internal readonly StackPopStringDelegate StackPopString;
    internal readonly StackPopStringUTF8Delegate StackPopStringUTF8;
    internal readonly StackPopObjectDelegate StackPopObject;
    internal readonly StackPopVectorDelegate StackPopVector;
    internal readonly StackPopGameDefinedStructureDelegate StackPopGameDefinedStructure;
    internal readonly FreeGameDefinedStructureDelegate FreeGameDefinedStructure;
    internal readonly ClosureAssignCommandDelegate ClosureAssignCommand;
    internal readonly ClosureDelayCommandDelegate ClosureDelayCommand;
    internal readonly ClosureActionDoCommandDelegate ClosureActionDoCommand;
    internal readonly nwnxSetFunctionDelegate nwnxSetFunction;
    internal readonly nwnxPushIntDelegate nwnxPushInt;
    internal readonly nwnxPushFloatDelegate nwnxPushFloat;
    internal readonly nwnxPushObjectDelegate nwnxPushObject;
    internal readonly nwnxPushStringDelegate nwnxPushString;
    internal readonly nwnxPushStringUTF8Delegate nwnxPushStringUTF8;
    internal readonly nwnxPushEffectDelegate nwnxPushEffect;
    internal readonly nwnxPushItemPropertyDelegate nwnxPushItemProperty;
    internal readonly nwnxPopIntDelegate nwnxPopInt;
    internal readonly nwnxPopFloatDelegate nwnxPopFloat;
    internal readonly nwnxPopObjectDelegate nwnxPopObject;
    internal readonly nwnxPopStringDelegate nwnxPopString;
    internal readonly nwnxPopStringUTF8Delegate nwnxPopStringUTF8;
    internal readonly nwnxPopEffectDelegate nwnxPopEffect;
    internal readonly nwnxPopItemPropertyDelegate nwnxPopItemProperty;
    internal readonly nwnxCallFunctionDelegate nwnxCallFunction;

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StackPush(int value) => StackPushInteger(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StackPush(float value) => StackPushFloat(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StackPush(string value) => StackPushString(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StackPush(uint value) => StackPushObject(value);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StackPush(Vector3 vector) => StackPushVector(vector);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void StackPush(IntPtr refValue, int engineType) => StackPushGameDefinedStructure(engineType, refValue);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public void Call(int functionId) => CallBuiltIn(functionId);

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public int StackPopInt() => StackPopInteger();

    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public IntPtr StackPopStruct(int engineType) => StackPopGameDefinedStructure(engineType);
  }
}
