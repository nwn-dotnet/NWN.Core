using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NWN.Core
{
  public static partial class NWNCore
  {
    /// <summary>
    /// Gets or sets the encoding to use for native/managed string conversion.<br/>
    /// Defaults to windows-1252.
    /// </summary>
    public static Encoding Encoding { get; set; } = null!;

    internal static ICoreFunctionHandler? FunctionHandler;

    internal static NativeHandles NativeFunctions;

    // We hold a reference to prevent GC of the delegates.
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

    public static int Init(IntPtr nativeHandlesPtr, int nativeHandlesLength, ICoreFunctionHandler functionHandler, NativeEventHandles eventCallbackHandles)
    {
      int result = Init(nativeHandlesPtr, nativeHandlesLength, functionHandler);
      if (result == 0)
      {
        RegisterEventHandles(eventCallbackHandles);
      }

      return result;
    }

    public static int Init(IntPtr nativeHandlesPtr, int nativeHandlesLength, ICoreFunctionHandler functionHandler)
    {
      Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      Encoding = Encoding.GetEncoding("windows-1252");
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

    public static int Init(IntPtr nativeHandlesPtr, int nativeHandlesLength, out CoreGameManager coreGameManager)
    {
      coreGameManager = new CoreGameManager();
      return Init(nativeHandlesPtr, nativeHandlesLength, coreGameManager, coreGameManager);
    }

    public static void RegisterEventHandles(ICoreEventHandler eventHandler)
    {
      NativeEventHandles eventHandles;
      eventHandles.MainLoop = eventHandler.OnMainLoop;
      eventHandles.RunScript = eventHandler.OnRunScript;
      eventHandles.Closure = eventHandler.OnClosure;
      eventHandles.Signal = eventHandler.OnSignal;

      RegisterEventHandles(eventHandles);
    }

    public static void RegisterEventHandles(NativeEventHandles eventCallbackHandles)
    {
      if (FunctionHandler == null)
      {
        throw new InvalidOperationException("Init must be called first with a valid function handler.");
      }

      eventHandles = eventCallbackHandles;
      int size = Marshal.SizeOf(typeof(NativeEventHandles));
      IntPtr ptr = Marshal.AllocHGlobal(size);
      Marshal.StructureToPtr(eventHandles, ptr, false);
      NativeFunctions.RegisterHandlers(ptr, (uint)size);
      Marshal.FreeHGlobal(ptr);
    }
  }
}
