using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Administration)]
  public class AdminPlugin
  {
    /// @addtogroup admin Administration
    /// Various admin related functions
    /// @{
    /// @file nwnx_admin.nss
    public const string NWNX_Administration = "NWNX_Administration";

    ///&lt; @private
    /// @name Administration Options
    /// @anchor admin_opts
    ///
    /// @{
    public const int NWNX_ADMINISTRATION_OPTION_ALL_KILLABLE = 0;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_NON_PARTY_KILLABLE = 1;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_REQUIRE_RESURRECTION = 2;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_STOLEN_ITEMS = 3;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_ITEMS = 4;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_EXP = 5;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_GOLD = 6;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_GOLD_NUM = 7;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_EXP_NUM = 8;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_ITEMS_NUM = 9;

    // DOES NOT DO ANYTHING
    public const int NWNX_ADMINISTRATION_OPTION_PVP_SETTING = 10;

    // 0 = No PVP, 1 = Party PVP, 2 = Full PVP
    public const int NWNX_ADMINISTRATION_OPTION_PAUSE_AND_PLAY = 11;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_ONE_PARTY_ONLY = 12;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_ENFORCE_LEGAL_CHARACTERS = 13;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_ITEM_LEVEL_RESTRICTIONS = 14;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_CDKEY_BANLIST_ALLOWLIST = 15;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_DISALLOW_SHOUTING = 16;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_SHOW_DM_JOIN_MESSAGE = 17;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_BACKUP_SAVED_CHARACTERS = 18;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_AUTO_FAIL_SAVE_ON_1 = 19;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_VALIDATE_SPELLS = 20;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_EXAMINE_EFFECTS = 21;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_EXAMINE_CHALLENGE_RATING = 22;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_USE_MAX_HITPOINTS = 23;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_RESTORE_SPELLS_USES = 24;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_RESET_ENCOUNTER_SPAWN_POOL = 25;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_HIDE_HITPOINTS_GAINED = 26;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_PLAYER_PARTY_CONTROL = 27;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_SHOW_PLAYER_JOIN_MESSAGES = 28;

    // TRUE/FALSE
    // @}
    /// @name Administration Debug Types
    /// @anchor admin_debug
    ///
    /// @{
    public const int NWNX_ADMINISTRATION_DEBUG_COMBAT = 0;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_DEBUG_SAVING_THROW = 1;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_DEBUG_MOVEMENT_SPEED = 2;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_DEBUG_HIT_DIE = 3;

    // TRUE/FALSE
    // @}
    /// Gets the current player password.
    /// <returns>The current player password.</returns>
    public static string GetPlayerPassword()
    {
      NWNXCall(NWNX_Administration, "GetPlayerPassword");
      return NWNXPopString();
    }

    /// Sets the password for players to login.
    /// <param name="password">The password to use.</param>
    public static void SetPlayerPassword(string password)
    {
      NWNXPushString(password);
      NWNXCall(NWNX_Administration, "SetPlayerPassword");
    }

    /// Clears the player password required to login.
    public static void ClearPlayerPassword()
    {
      NWNXCall(NWNX_Administration, "ClearPlayerPassword");
    }

    /// Gets the current DM password.
    /// <returns>The current DM password.</returns>
    public static string GetDMPassword()
    {
      NWNXCall(NWNX_Administration, "GetDMPassword");
      return NWNXPopString();
    }

    /// Sets the password for DMs to login.
    /// <param name="password">The password to use.</param>
    public static void SetDMPassword(string password)
    {
      NWNXPushString(password);
      NWNXCall(NWNX_Administration, "SetDMPassword");
    }

    /// Signals the server to immediately shut down.
    public static void ShutdownServer()
    {
      NWNXCall(NWNX_Administration, "ShutdownServer");
    }

    /// Deletes the player character from the servervault
    ///
    /// The PC will be immediately booted from the game with a &quot;Delete Character&quot; message
    ///
    /// <param name="oPC">The player to delete.</param>
    /// <param name="bPreserveBackup">If true, it will leave the file on server, only appending &quot;.deleted0&quot; to the bic filename.</param>
    /// <param name="sKickMessage">An optional kick message, if left blank it will default to &quot;Delete Character&quot; as reason.</param>
    public static void DeletePlayerCharacter(uint oPC, int bPreserveBackup = TRUE, string sKickMessage = "")
    {
      NWNXPushString(sKickMessage);
      NWNXPushInt(bPreserveBackup);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Administration, "DeletePlayerCharacter");
    }

    /// Bans the provided IP.
    /// <param name="ip">The IP Address to ban.</param>
    public static void AddBannedIP(string ip)
    {
      NWNXPushString(ip);
      NWNXCall(NWNX_Administration, "AddBannedIP");
    }

    /// Removes the ban on the provided IP.
    /// <param name="ip">The IP Address to unban.</param>
    public static void RemoveBannedIP(string ip)
    {
      NWNXPushString(ip);
      NWNXCall(NWNX_Administration, "RemoveBannedIP");
    }

    /// Bans the provided Public CD Key.
    /// <param name="key">The Public CD Key to ban.</param>
    public static void AddBannedCDKey(string key)
    {
      NWNXPushString(key);
      NWNXCall(NWNX_Administration, "AddBannedCDKey");
    }

    /// Removes the ban on the provided Public CD Key.
    /// <param name="key">The Public CD Key to unban.</param>
    public static void RemoveBannedCDKey(string key)
    {
      NWNXPushString(key);
      NWNXCall(NWNX_Administration, "RemoveBannedCDKey");
    }

    /// Bans the provided playername.
    /// <param name="playerName">The player name (community name) to ban.</param>
    /// @warning A user can change their playername at will.
    public static void AddBannedPlayerName(string playerName)
    {
      NWNXPushString(playerName);
      NWNXCall(NWNX_Administration, "AddBannedPlayerName");
    }

    /// Removes the ban on the provided playername.
    /// <param name="playerName">The player name (community name) to unban.</param>
    public static void RemoveBannedPlayerName(string playerName)
    {
      NWNXPushString(playerName);
      NWNXCall(NWNX_Administration, "RemoveBannedPlayerName");
    }

    /// Get a list of all banned IPs/Keys/names as a string.
    /// <returns>A string with a listing of the banned IPs/Keys/names.</returns>
    public static string GetBannedList()
    {
      NWNXCall(NWNX_Administration, "GetBannedList");
      return NWNXPopString();
    }

    /// Set the module&apos;s name as shown to the serverlist.
    /// <param name="name">The name to give the module.</param>
    public static void SetModuleName(string name)
    {
      NWNXPushString(name);
      NWNXCall(NWNX_Administration, "SetModuleName");
    }

    /// Set the server&apos;s name as shown to the serverlist.
    /// <param name="name">The name to give the server.</param>
    public static void SetServerName(string name)
    {
      NWNXPushString(name);
      NWNXCall(NWNX_Administration, "SetServerName");
    }

    /// Returns the server&apos;s name as shown to the serverlist.
    public static string GetServerName()
    {
      NWNXCall(NWNX_Administration, "GetServerName");
      return NWNXPopString();
    }

    /// Get an @ref admin_opts &quot;Administration Option&quot; value.
    /// <param name="option">An @ref admin_opts &quot;Administration Option&quot;.</param>
    /// <returns>The current setting for the supplied option from @ref admin_opts &quot;Administration Options&quot;.</returns>
    public static int GetPlayOption(int option)
    {
      NWNXPushInt(option);
      NWNXCall(NWNX_Administration, "GetPlayOption");
      return NWNXPopInt();
    }

    /// Set an @ref admin_opts &quot;Administration Options&quot; to a value.
    /// <param name="option">The option to adjust from @ref admin_opts &quot;Administration Options&quot;.</param>
    /// <param name="value">The new value for the option.</param>
    public static void SetPlayOption(int option, int value)
    {
      NWNXPushInt(value);
      NWNXPushInt(option);
      NWNXCall(NWNX_Administration, "SetPlayOption");
    }

    /// Delete the TURD of playerName + characterName.
    ///
    /// At times a PC may get stuck in a permanent crash loop when attempting to log
    /// in. This function allows administrators to delete their Temporary User
    /// Resource Data where the PC&apos;s current location is stored allowing them to log
    /// into the starting area.
    ///
    /// <param name="playerName">The community (login name).</param>
    /// <param name="characterName">The character name.</param>
    /// <returns>Returns TRUE if successful.</returns>
    public static int DeleteTURD(string playerName, string characterName)
    {
      NWNXPushString(characterName);
      NWNXPushString(playerName);
      NWNXCall(NWNX_Administration, "DeleteTURD");
      return NWNXPopInt();
    }

    /// Get an @ref admin_debug &quot;Administration Debug Type&quot; value.
    /// <param name="type">An @ref admin_debug &quot;Administration Debug Type&quot;.</param>
    /// <returns>The current value for the supplied debug type from @ref admin_debug &quot;Administration Debug Types&quot;.</returns>
    public static int GetDebugValue(int type)
    {
      NWNXPushInt(type);
      NWNXCall(NWNX_Administration, "GetDebugValue");
      return NWNXPopInt();
    }

    /// Set an @ref admin_debug &quot;Administration Debug Type&quot; to a value.
    /// <param name="type">The debug type to adjust from @ref admin_debug &quot;Administration Debug Types&quot;.</param>
    /// <param name="state">The new state for the debug type, TRUE or FALSE</param>
    public static void SetDebugValue(int type, int state)
    {
      NWNXPushInt(state);
      NWNXPushInt(type);
      NWNXCall(NWNX_Administration, "SetDebugValue");
    }

    /// Reload all rules (2da stuff etc).
    /// @warning DANGER, DRAGONS. Bad things may or may not happen.
    public static void ReloadRules()
    {
      NWNXCall(NWNX_Administration, "ReloadRules");
    }

    /// Get the servers minimum level.
    /// <returns>The minimum level for the server.</returns>
    public static int GetMinLevel()
    {
      NWNXCall(NWNX_Administration, "GetMinLevel");
      return NWNXPopInt();
    }

    /// Set the servers minimum level.
    /// <param name="nLevel">The minimum level for the server.</param>
    public static void SetMinLevel(int nLevel)
    {
      NWNXPushInt(nLevel);
      NWNXCall(NWNX_Administration, "SetMinLevel");
    }

    /// Get the servers maximum level.
    /// <returns>The maximum level for the server.</returns>
    public static int GetMaxLevel()
    {
      NWNXCall(NWNX_Administration, "GetMaxLevel");
      return NWNXPopInt();
    }

    /// Set the servers maximum level.
    /// @note Attention when using this and the MaxLevel plugin. They both change the same value.
    /// <param name="nLevel">The maximum level for the server.</param>
    public static void SetMaxLevel(int nLevel)
    {
      NWNXPushInt(nLevel);
      NWNXCall(NWNX_Administration, "SetMaxLevel");
    }

    // @}
  }
}
