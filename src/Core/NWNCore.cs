namespace NWN.Core
{
  public static class NWNCore
  {
    internal static ICoreFunctionHandler? FunctionHandler;

    public static void Init(ICoreFunctionHandler functionHandler)
    {
      FunctionHandler = functionHandler;
    }
  }
}
