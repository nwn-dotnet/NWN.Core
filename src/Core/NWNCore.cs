using System;
using System.Runtime.InteropServices;

namespace NWN.Core
{
    public static partial class NWNCore
    {
#pragma warning disable CS8618
        internal static IGameManager GameManager;
#pragma warning restore CS8618

        internal static NativeHandles NativeFunctions;
        private static NativeEventHandles eventHandles;

        public static int Init(IntPtr nativeHandlesPtr, int nativeHandlesLength, IGameManager gameManager)
        {
            GameManager = gameManager;

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
            RegisterHandles();
            RegisterNativeEventHandles();
            return 0;
        }

        private static void RegisterHandles()
        {
            eventHandles.MainLoop = GameManager.OnMainLoop;
            eventHandles.RunScript = GameManager.OnRunScript;
            eventHandles.Closure = GameManager.OnClosure;
            eventHandles.Signal = GameManager.OnSignal;
        }

        private static void RegisterNativeEventHandles()
        {
            int size = Marshal.SizeOf(typeof(NativeEventHandles));
            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(eventHandles, ptr, false);
            NativeFunctions.RegisterHandlers(ptr, (uint) size);
            Marshal.FreeHGlobal(ptr);
        }
    }
}