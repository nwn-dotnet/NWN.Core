using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Core)]
  public class CorePlugin
  {
    public const string NWNX_Core = "NWNX_Core";

    /// Determines if the given plugin exists and is enabled.
    /// <param name="sPlugin">The name of the plugin to check. This is the case sensitive plugin name as used by NWNX_CallFunction, NWNX_PushArgumentX</param>
    /// @note Example usage: NWNX_Util_PluginExists(&quot;NWNX_Creature&quot;);
    /// <returns>TRUE if the plugin exists and is enabled, otherwise FALSE.</returns>
    public static int PluginExists(string sPlugin)
    {
      NWNXPushString(sPlugin);
      NWNXCall(NWNX_Core, "PluginExists");
      return NWNXPopInt();
    }
  }
}
