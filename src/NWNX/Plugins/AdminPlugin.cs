namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Administration)]
  public class AdminPlugin
  {
    public const string NWNX_Administration = "NWNX_Administration";

    ///< @private
    /// @name Administration Options
    /// @anchor admin_opts
    ///
    /// @{
    public const int NWNX_ADMINISTRATION_OPTION_ALL_KILLABLE = 0;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_NON_PARTY_KILLABLE = 1;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_REQUIRE_RESURRECTION = 2;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_STOLEN_ITEMS = 3;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_ITEMS = 4;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_EXP = 5;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_GOLD = 6;

    // TRUE/FALSE
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_GOLD_NUM = 7;
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_EXP_NUM = 8;
    public const int NWNX_ADMINISTRATION_OPTION_LOSE_ITEMS_NUM = 9;
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
    /// @}
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
    /// @}
    /// Gets the current player password.
    /// <returns>The current player password.</returns>
    public static string GetPlayerPassword()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "GetPlayerPassword");
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Sets the password for players to login.
    /// <param name="password">The password to use.</param>
    public static void SetPlayerPassword(string password)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "SetPlayerPassword");
      VM.NWNX.StackPush(password);
      VM.NWNX.Call();
    }

    /// Clears the player password required to login.
    public static void ClearPlayerPassword()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "ClearPlayerPassword");
      VM.NWNX.Call();
    }

    /// Gets the current DM password.
    /// <returns>The current DM password.</returns>
    public static string GetDMPassword()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "GetDMPassword");
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Sets the password for DMs to login.
    /// <param name="password">The password to use.</param>
    public static void SetDMPassword(string password)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "SetDMPassword");
      VM.NWNX.StackPush(password);
      VM.NWNX.Call();
    }

    /// Signals the server to immediately shut down.
    public static void ShutdownServer()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "ShutdownServer");
      VM.NWNX.Call();
    }

    /// Deletes the player character from the servervault
    ///
    /// The PC will be immediately booted from the game with a "Delete Character" message
    ///
    /// <param name="oPC">The player to delete.</param>
    /// <param name="bPreserveBackup">If true, it will leave the file on server, only appending ".deleted0" to the bic filename.</param>
    public static void DeletePlayerCharacter(uint oPC, int bPreserveBackup)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "DeletePlayerCharacter");
      VM.NWNX.StackPush(bPreserveBackup);
      VM.NWNX.StackPush(oPC);
      VM.NWNX.Call();
    }

    /// Bans the provided IP.
    /// <param name="ip">The IP Address to ban.</param>
    public static void AddBannedIP(string ip)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "AddBannedIP");
      VM.NWNX.StackPush(ip);
      VM.NWNX.Call();
    }

    /// Removes the ban on the provided IP.
    /// <param name="ip">The IP Address to unban.</param>
    public static void RemoveBannedIP(string ip)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "RemoveBannedIP");
      VM.NWNX.StackPush(ip);
      VM.NWNX.Call();
    }

    /// Bans the provided Public CD Key.
    /// <param name="key">The Public CD Key to ban.</param>
    public static void AddBannedCDKey(string key)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "AddBannedCDKey");
      VM.NWNX.StackPush(key);
      VM.NWNX.Call();
    }

    /// Removes the ban on the provided Public CD Key.
    /// <param name="key">The Public CD Key to unban.</param>
    public static void RemoveBannedCDKey(string key)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "RemoveBannedCDKey");
      VM.NWNX.StackPush(key);
      VM.NWNX.Call();
    }

    /// Bans the provided playername.
    /// <param name="playerName">The player name (community name) to ban.</param>
    /// @warning A user can change their playername at will.
    public static void AddBannedPlayerName(string playerName)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "AddBannedPlayerName");
      VM.NWNX.StackPush(playerName);
      VM.NWNX.Call();
    }

    /// Removes the ban on the provided playername.
    /// <param name="playerName">The player name (community name) to unban.</param>
    public static void RemoveBannedPlayerName(string playerName)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "RemoveBannedPlayerName");
      VM.NWNX.StackPush(playerName);
      VM.NWNX.Call();
    }

    /// Get a list of all banned IPs/Keys/names as a string.
    /// <returns>A string with a listing of the banned IPs/Keys/names.</returns>
    public static string GetBannedList()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "GetBannedList");
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Set the module's name as shown to the serverlist.
    /// <param name="name">The name to give the module.</param>
    public static void SetModuleName(string name)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "SetModuleName");
      VM.NWNX.StackPush(name);
      VM.NWNX.Call();
    }

    /// Set the server's name as shown to the serverlist.
    /// <param name="name">The name to give the server.</param>
    public static void SetServerName(string name)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "SetServerName");
      VM.NWNX.StackPush(name);
      VM.NWNX.Call();
    }

    /// Returns the server's name as shown to the serverlist.
    public static string GetServerName()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "GetServerName");
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get an @ref admin_opts "Administration Option" value.
    /// <param name="option">An @ref admin_opts "Administration Option".</param>
    /// <returns>The current setting for the supplied option from @ref admin_opts "Administration Options".</returns>
    public static int GetPlayOption(int option)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "GetPlayOption");
      VM.NWNX.StackPush(option);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set an @ref admin_opts "Administration Options" to a value.
    /// <param name="option">The option to adjust from @ref admin_opts "Administration Options".</param>
    /// <param name="value">The new value for the option.</param>
    public static void SetPlayOption(int option, int value)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "SetPlayOption");
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(option);
      VM.NWNX.Call();
    }

    /// Delete the TURD of playerName + characterName.
    ///
    /// At times a PC may get stuck in a permanent crash loop when attempting to log
    /// in. This function allows administrators to delete their Temporary User
    /// Resource Data where the PC's current location is stored allowing them to log
    /// into the starting area.
    ///
    /// <param name="playerName">The community (login name).</param>
    /// <param name="characterName">The character name.</param>
    /// <returns>Returns TRUE if successful</returns>
    public static int DeleteTURD(string playerName, string characterName)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "DeleteTURD");
      VM.NWNX.StackPush(characterName);
      VM.NWNX.StackPush(playerName);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get an @ref admin_debug "Administration Debug Type" value.
    /// <param name="type">An @ref admin_debug "Administration Debug Type".</param>
    /// <returns>The current value for the supplied debug type from @ref admin_debug "Administration Debug Types".</returns>
    public static int GetDebugValue(int type)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "GetDebugValue");
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set an @ref admin_debug "Administration Debug Type" to a value.
    /// <param name="type">The debug type to adjust from @ref admin_debug "Administration Debug Types".</param>
    /// <param name="state">The new state for the debug type, TRUE or FALSE</param>
    public static void SetDebugValue(int type, int state)
    {
      VM.NWNX.SetFunction(NWNX_Administration, "SetDebugValue");
      VM.NWNX.StackPush(state);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// Reload all rules (2da stuff etc).
    /// @warning DANGER, DRAGONS. Bad things may or may not happen.
    public static void ReloadRules()
    {
      VM.NWNX.SetFunction(NWNX_Administration, "ReloadRules");
      VM.NWNX.Call();
    }

    /// @}
  }
}
