namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Ruby)]
  public class RubyPlugin
  {
    public const string NWNX_Ruby = "NWNX_Ruby";

    // /< @private
    public static string Evaluate(string sCode)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Ruby, "Evaluate");
      Internal.NativeFunctions.nwnxPushString(sCode);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Evaluates some ruby code.
    // / @param sCode The code to evaluate.
    // / @return The output of the call.
    // / @}
  }
}