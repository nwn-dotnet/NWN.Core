namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Ruby)]
  public class RubyPlugin
  {
    public const string NWNX_Ruby = "NWNX_Ruby";

    /// Evaluates some ruby code.
    /// <param name="sCode">The code to evaluate.</param>
    /// <returns>The output of the call.</returns>
    public static string Evaluate(string sCode)
    {
      VM.NWNX.SetFunction(NWNX_Ruby, "Evaluate");
      VM.NWNX.StackPush(sCode);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }
  }
}
