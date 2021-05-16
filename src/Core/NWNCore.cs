using System;
using System.Runtime.InteropServices;

namespace NWN.Core
{
  public static partial class NWNCore
  {
    internal static ICoreFunctionHandler? FunctionHandler;

    internal static NativeHandles NativeFunctions;
    private static NativeEventHandles eventHandles;

    public static int Init(IntPtr nativeHandlesPtr, int nativeHandlesLength, ICoreFunctionHandler functionHandler, ICoreEventHandler eventHandler)
    {
      int result = Init(nativeHandlesPtr, nativeHandlesLength, functionHandler);
      if (result == 0)
      {
        RegisterEventHandles(eventHandler);
      }

      return result;
    }

    public static int Init(IntPtr nativeHandlesPtr, int nativeHandlesLength, ICoreFunctionHandler functionHandler)
    {
      FunctionHandler = functionHandler;

      if (nativeHandlesPtr == IntPtr.Zero)
      {
        Console.WriteLine("Received NULL bootstrap structure");
        return 1;
      }

      int expectedLength = Marshal.SizeOf(typeof(NativeHandles));
      if (nativeHandlesLength < expectedLength)
      {
        Console.WriteLine($"Received bootstrap structure too small - actual={nativeHandlesLength}, expected={expectedLength}");
        return 1;
      }

      if (nativeHandlesLength > expectedLength)
      {
        Console.WriteLine($"WARNING: Received bootstrap structure bigger than expected - actual={nativeHandlesLength}, expected={expectedLength}");
        Console.WriteLine("         This usually means that native code version is ahead of the managed code");
      }

      NativeFunctions = Marshal.PtrToStructure<NativeHandles>(nativeHandlesPtr);
      return 0;
    }

    private static void RegisterEventHandles(ICoreEventHandler eventHandler)
    {
      eventHandles.MainLoop = eventHandler.OnMainLoop;
      eventHandles.RunScript = eventHandler.OnRunScript;
      eventHandles.Closure = eventHandler.OnClosure;
      eventHandles.Signal = eventHandler.OnSignal;

      int size = Marshal.SizeOf(typeof(NativeEventHandles));
      IntPtr ptr = Marshal.AllocHGlobal(size);
      Marshal.StructureToPtr(eventHandles, ptr, false);
      NativeFunctions.RegisterHandlers(ptr, (uint)size);
      Marshal.FreeHGlobal(ptr);
    }
  }
}
