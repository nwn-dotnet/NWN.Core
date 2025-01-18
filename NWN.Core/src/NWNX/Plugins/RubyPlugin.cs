using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Ruby)]
  public class RubyPlugin
  {
    /// @addtogroup ruby Ruby
    /// Allows users to execute arbitrary Ruby from the game.
    /// @{
    /// @file nwnx_ruby.nss
    public const string NWNX_Ruby = "NWNX_Ruby";

    ///&lt; @private
    public static string Evaluate(string sCode)
    {
      NWNXPushString(sCode);
      NWNXCall(NWNX_Ruby, "Evaluate");
      return NWNXPopString();
    }

    /// Evaluates some ruby code.
    /// <param name="sCode">The code to evaluate.</param>
    /// <returns>The output of the call.</returns>
    // @}
  }
}
