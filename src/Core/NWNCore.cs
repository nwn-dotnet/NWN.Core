using System.Runtime.InteropServices;
using System.Text;
using NWN.Core.Native;

namespace NWN.Core
{
  public static partial class NWNCore
  {
    /// <summary>
    /// Gets or sets the encoding to use for native/managed string conversion.<br/>
    /// Defaults to windows-1252.
    /// </summary>
    public static Encoding Encoding
    {
      get => NwStringMarshaller.Encoding;
      set => NwStringMarshaller.Encoding = value;
    }

    internal static ICoreFunctionHandler? FunctionHandler;

    public static void Init(ICoreFunctionHandler functionHandler)
    {
      Marshal.PrelinkAll(typeof(NWNCore));
      FunctionHandler = functionHandler;
    }

    public static unsafe void Init(out CoreGameManager coreGameManager)
    {
      coreGameManager = new CoreGameManager();
      Init(coreGameManager);

      RegisterMainLoopHandler(&CoreGameManager.MainLoopHandler);
      RegisterRunScriptHandler(&CoreGameManager.RunScriptHandler);
      RegisterClosureHandler(&CoreGameManager.ClosureHandler);
      RegisterSignalHandler(&CoreGameManager.SignalHandler);
      RegisterAssertHandler(&CoreGameManager.AssertFailHandler);
      RegisterCrashHandler(&CoreGameManager.CrashHandler);
    }
  }
}
