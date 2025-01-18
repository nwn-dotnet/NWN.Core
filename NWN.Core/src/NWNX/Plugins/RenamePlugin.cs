using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Rename)]
  public class RenamePlugin
  {
    /// @addtogroup rename Rename
    /// Facilitates renaming, overriding and customization of player names.
    /// @{
    /// @file nwnx_rename.nss
    public const string NWNX_Rename = "NWNX_Rename";

    ///&lt; @private
    /// @anchor rename_comm_name_override_type
    /// @name Community Name Override Type
    /// @{
    public const int NWNX_RENAME_PLAYERNAME_DEFAULT = 0;

    ///&lt; Don&apos;t rename
    public const int NWNX_RENAME_PLAYERNAME_OBFUSCATE = 1;

    ///&lt; Generate random string for Community Name
    public const int NWNX_RENAME_PLAYERNAME_OVERRIDE = 2;

    ///&lt; Use character name specified
    public const int NWNX_RENAME_PLAYERNAME_ANONYMOUS = 3;

    ///&lt; Use the value of the NWNX_RENAME_ANONYMOUS_NAME environment variable
    ///@}
    /// Set a PC&apos;s character name and community name on the player list.
    /// <param name="oTarget">The PC whose name is being overridden.</param>
    /// <param name="sNewName">The new name.</param>
    /// <param name="sPrefix">The prefix for their character name, sometimes used for a color code.</param>
    /// <param name="sSuffix">The suffix for their character name.</param>
    /// <param name="iPlayerNameState">How to change the Community Name, use @ref rename_comm_name_override_type &quot;Community Name Override Type&quot;.</param>
    /// <param name="oObserver">If specified, the character name will appear to that specific observer as set, this overrides a global setting.</param>
    /// @note Will not persist through saving, resets or logout.
    public static void SetPCNameOverride(uint oTarget, string sNewName, string sPrefix = "", string sSuffix = "", int iPlayerNameState = NWNX_RENAME_PLAYERNAME_DEFAULT, uint oObserver = OBJECT_INVALID)
    {
      NWNXPushObject(oObserver);
      NWNXPushInt(iPlayerNameState);
      NWNXPushString(sSuffix);
      NWNXPushString(sPrefix);
      NWNXPushString(sNewName);
      NWNXPushObject(oTarget);
      NWNXCall(NWNX_Rename, "SetPCNameOverride");
    }

    /// Gets a PC&apos;s name as overridden.
    /// <param name="oTarget">The PC whose name to query.</param>
    /// <param name="oObserver">The specific observer.</param>
    /// <returns>The PC&apos;s name as overridden either per observer or globally.</returns>
    /// @note If you wish to get a PC&apos;s true name use `GetName(oPC, TRUE)`.
    public static string GetPCNameOverride(uint oTarget, uint oObserver = OBJECT_INVALID)
    {
      NWNXPushObject(oObserver);
      NWNXPushObject(oTarget);
      NWNXCall(NWNX_Rename, "GetPCNameOverride");
      return NWNXPopString();
    }

    /// Clears an overridden PC Name.
    /// <param name="oTarget">The PC whose overridden name to clear, use OBJECT_INVALID if you&apos;re clearing all overrides for an observer.</param>
    /// <param name="oObserver">The observer whose overriden name of oTarget is being cleared.</param>
    /// If oTarget is OBJECT_INVALID then all overrides are cleared.
    /// <param name="clearAll">If true, both the global and personal overrides will be cleared for that target PC.</param>
    /// Requires oObserver be OBJECT_INVALID.
    public static void ClearPCNameOverride(uint oTarget, uint oObserver = OBJECT_INVALID, int clearAll = FALSE)
    {
      NWNXPushInt(clearAll);
      NWNXPushObject(oObserver);
      NWNXPushObject(oTarget);
      NWNXCall(NWNX_Rename, "ClearPCNameOverride");
    }

    // @}
  }
}
