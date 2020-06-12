using System;
using System.Runtime.InteropServices;

namespace NWN
{
    public static partial class Internal
    {
        #pragma warning disable CS8618
        private static IGameManager gameManager;
        #pragma warning restore CS8618

        public static uint ObjectSelf => gameManager.ObjectSelf;
        public static NativeHandles NativeFunctions;
        public static ManagedHandles ManagedFunctions;
        private static NativeEventHandles eventHandles;

        public static int Bootstrap(IntPtr nativeHandlesPtr, int nativeHandlesLength, IGameManager gameManager)
        {
            Internal.gameManager = gameManager;

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
            eventHandles.MainLoop = gameManager.OnMainLoop;
            eventHandles.RunScript = gameManager.OnRunScript;
            eventHandles.Closure = gameManager.OnClosure;

            ManagedFunctions.ClosureAssignCommand = gameManager.ClosureAssignCommand;
            ManagedFunctions.ClosureDelayCommand = gameManager.ClosureDelayCommand;
            ManagedFunctions.ClosureActionDoCommand = gameManager.ClosureActionDoCommand;
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
