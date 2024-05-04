using System;
using System.Reflection;
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

    // We hold a reference to prevent GC of the delegates.
    private static object eventHandles;

    public static int Init(ICoreFunctionHandler functionHandler, ICoreEventHandler eventHandler)
    {
      int result = Init(functionHandler);
      if (result == 0)
      {
        RegisterEventHandles(eventHandler);
      }

      return result;
    }

    public static int Init(ICoreFunctionHandler functionHandler, NativeEventHandles eventCallbackHandles)
    {
      int result = Init(functionHandler);
      if (result == 0)
      {
        RegisterEventHandles(eventCallbackHandles);
      }

      return result;
    }

#if !NETCOREAPP3_1
    public static int Init(ICoreFunctionHandler functionHandler, NativeEventHandlesUnmanaged eventCallbackHandles)
    {
      int result = Init(functionHandler);
      if (result == 0)
      {
        RegisterEventHandles(eventCallbackHandles);
      }

      return result;
    }
#endif

    public static int Init(ICoreFunctionHandler functionHandler)
    {
      Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      Encoding = Encoding.GetEncoding("windows-1252");
      Marshal.PrelinkAll(typeof(NWNCore));
      FunctionHandler = functionHandler;

      return 0;
    }

    public static int Init(out CoreGameManager coreGameManager)
    {
      coreGameManager = new CoreGameManager();
      return Init(coreGameManager, coreGameManager);
    }

    public static void RegisterEventHandles(ICoreEventHandler eventHandler)
    {
      NativeEventHandles eventHandles;
      eventHandles.MainLoop = eventHandler.OnMainLoop;
      eventHandles.RunScript = eventHandler.OnRunScript;
      eventHandles.Closure = eventHandler.OnClosure;
      eventHandles.Signal = eventHandler.OnSignal;
      eventHandles.AssertFail = eventHandler.OnAssertFail;
      eventHandles.CrashHandler = eventHandler.CrashHandler;

      RegisterEventHandles(eventHandles);
    }

    public static void RegisterEventHandles<T>(T eventCallbackHandles) where T : struct
    {
      if (FunctionHandler == null)
      {
        throw new InvalidOperationException("Init must be called first with a valid function handler.");
      }

      int expectedSize = Marshal.SizeOf<NativeEventHandles>();
      int actualSize = Marshal.SizeOf<T>();

      if (actualSize != expectedSize)
      {
        throw new InvalidOperationException($"Invalid event handle structure specified. Expected size {expectedSize}, Actual size: {actualSize}");
      }

      eventHandles = eventCallbackHandles;
      IntPtr ptr = Marshal.AllocHGlobal(actualSize);
      Marshal.StructureToPtr(eventHandles, ptr, false);
      RegisterHandlers(ptr, (uint)actualSize);
      Marshal.FreeHGlobal(ptr);
    }
  }
}
