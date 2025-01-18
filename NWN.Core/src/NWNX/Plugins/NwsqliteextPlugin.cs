using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_NWSQLiteExtensions)]
  public class NwsqliteextPlugin
  {
    /// @addtogroup nwsqliteextensions NWSQLiteExtensions
    /// Various extensions for the game&apos;s built-in sqlite database.
    /// @{
    /// @file nwnx_nwsqliteext.nss
    public const string NWNX_NWSQLiteExtensions = "NWNX_NWSQLiteExtensions";

    ///&lt; @private
    /// Create a virtual table for s2DA in the module sqlite database.
    /// <param name="s2DA">The 2DA name, cannot be empty.</param>
    /// <param name="sColumnTypeHints">A string containing type hints for the 2DA columns. See this plugin&apos;s readme file for more info.</param>
    /// <param name="sTableName">The table name, will use the 2da name if empty.</param>
    /// <returns>TRUE if the virtual table was created.</returns>
    public static int CreateVirtual2DATable(string s2DA, string sColumnTypeHints = "", string sTableName = "")
    {
      NWNXPushString(sTableName);
      NWNXPushString(sColumnTypeHints);
      NWNXPushString(s2DA);
      NWNXCall(NWNX_NWSQLiteExtensions, "CreateVirtual2DATable");
      return NWNXPopInt();
    }

    // @}
  }
}
