using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Watchcat)]
  public class WatchcatPlugin
  {
    /// @addtogroup watchcat Watchcat
    /// Functions to steer Watchcat.
    /// @{
    /// @file nwnx_watchcat.nss
    public const string NWNX_Watchcat = "NWNX_Watchcat";

    ///&lt; @private
    /// Marks the currently-running script as immune to watchcat. While the script runs, Watchcat will ignore any server stalls that occur.
    public static void DisableUntilScriptExit()
    {
      NWNXCall(NWNX_Watchcat, "DisableUntilScriptExit");
    }

    // @}
  }
}
