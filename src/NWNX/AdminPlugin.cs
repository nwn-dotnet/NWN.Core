using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_Administration)]
    public class AdminPlugin
    {
        public const string NWNX_Administration = "NWNX_Administration";

        // /< @private
        // / @name Administration Options
        // / @anchor admin_opts
        // /
        // / @{
        public const int NWNX_ADMINISTRATION_OPTION_ALL_KILLABLE = 0;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_NON_PARTY_KILLABLE = 1;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_REQUIRE_RESURRECTION = 2;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_STOLEN_ITEMS = 3;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_ITEMS = 4;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_EXP = 5;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_GOLD = 6;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_GOLD_NUM = 7;
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_EXP_NUM = 8;
        public const int NWNX_ADMINISTRATION_OPTION_LOSE_ITEMS_NUM = 9;
        public const int NWNX_ADMINISTRATION_OPTION_PVP_SETTING = 10;

        //  0 = No PVP, 1 = Party PVP, 2 = Full PVP
        public const int NWNX_ADMINISTRATION_OPTION_PAUSE_AND_PLAY = 11;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_ONE_PARTY_ONLY = 12;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_ENFORCE_LEGAL_CHARACTERS = 13;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_ITEM_LEVEL_RESTRICTIONS = 14;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_CDKEY_BANLIST_ALLOWLIST = 15;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_DISALLOW_SHOUTING = 16;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_SHOW_DM_JOIN_MESSAGE = 17;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_BACKUP_SAVED_CHARACTERS = 18;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_AUTO_FAIL_SAVE_ON_1 = 19;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_VALIDATE_SPELLS = 20;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_EXAMINE_EFFECTS = 21;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_EXAMINE_CHALLENGE_RATING = 22;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_USE_MAX_HITPOINTS = 23;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_RESTORE_SPELLS_USES = 24;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_RESET_ENCOUNTER_SPAWN_POOL = 25;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_OPTION_HIDE_HITPOINTS_GAINED = 26;

        //  TRUE/FALSE
        // / @}
        // / @name Administration Debug Types
        // / @anchor admin_debug
        // /
        // / @{
        public const int NWNX_ADMINISTRATION_DEBUG_COMBAT = 0;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_DEBUG_SAVING_THROW = 1;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_DEBUG_MOVEMENT_SPEED = 2;

        //  TRUE/FALSE
        public const int NWNX_ADMINISTRATION_DEBUG_HIT_DIE = 3;

        //  TRUE/FALSE
        // / @}
        // / @brief Gets the current player password.
        // / @return The current player password.
        public static string GetPlayerPassword()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "GetPlayerPassword");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Sets the password for players to login.
        // / @param password The password to use.
        public static void SetPlayerPassword(string password)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "SetPlayerPassword");
            Internal.NativeFunctions.nwnxPushString(password);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Clears the player password required to login.
        public static void ClearPlayerPassword()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "ClearPlayerPassword");
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the current DM password.
        // / @return The current DM password.
        public static string GetDMPassword()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "GetDMPassword");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Sets the password for DMs to login.
        // / @param password The password to use.
        public static void SetDMPassword(string password)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "SetDMPassword");
            Internal.NativeFunctions.nwnxPushString(password);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Signals the server to immediately shut down.
        public static void ShutdownServer()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "ShutdownServer");
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Deletes the player character from the servervault
        // /
        // / The PC will be immediately booted from the game with a "Delete Character" message
        // /
        // / @param oPC The player to delete.
        // / @param bPreserveBackup If true, it will leave the file on server, only appending ".deleted0" to the bic filename.
        public static void DeletePlayerCharacter(uint oPC, int bPreserveBackup = NWScript.TRUE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "DeletePlayerCharacter");
            Internal.NativeFunctions.nwnxPushInt(bPreserveBackup);
            Internal.NativeFunctions.nwnxPushObject(oPC);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Bans the provided IP.
        // / @param ip The IP Address to ban.
        public static void AddBannedIP(string ip)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "AddBannedIP");
            Internal.NativeFunctions.nwnxPushString(ip);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Removes the ban on the provided IP.
        // / @param ip The IP Address to unban.
        public static void RemoveBannedIP(string ip)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "RemoveBannedIP");
            Internal.NativeFunctions.nwnxPushString(ip);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Bans the provided Public CD Key.
        // / @param key The Public CD Key to ban.
        public static void AddBannedCDKey(string key)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "AddBannedCDKey");
            Internal.NativeFunctions.nwnxPushString(key);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Removes the ban on the provided Public CD Key.
        // / @param key The Public CD Key to unban.
        public static void RemoveBannedCDKey(string key)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "RemoveBannedCDKey");
            Internal.NativeFunctions.nwnxPushString(key);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Bans the provided playername.
        // / @param playerName The player name (community name) to ban.
        // / @warning A user can change their playername at will.
        public static void AddBannedPlayerName(string playerName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "AddBannedPlayerName");
            Internal.NativeFunctions.nwnxPushString(playerName);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Removes the ban on the provided playername.
        // / @param playerName The player name (community name) to unban.
        public static void RemoveBannedPlayerName(string playerName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "RemoveBannedPlayerName");
            Internal.NativeFunctions.nwnxPushString(playerName);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get a list of all banned IPs/Keys/names as a string.
        // / @return A string with a listing of the banned IPs/Keys/names.
        public static string GetBannedList()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "GetBannedList");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Set the module's name as shown to the serverlist.
        // / @param name The name to give the module.
        public static void SetModuleName(string name)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "SetModuleName");
            Internal.NativeFunctions.nwnxPushString(name);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set the server's name as shown to the serverlist.
        // / @param name The name to give the server.
        public static void SetServerName(string name)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "SetServerName");
            Internal.NativeFunctions.nwnxPushString(name);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Returns the server's name as shown to the serverlist.
        public static string GetServerName()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "GetServerName");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Get an @ref admin_opts "Administration Option" value.
        // / @param option An @ref admin_opts "Administration Option".
        // / @return The current setting for the supplied option from @ref admin_opts "Administration Options".
        public static int GetPlayOption(int option)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "GetPlayOption");
            Internal.NativeFunctions.nwnxPushInt(option);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set an @ref admin_opts "Administration Options" to a value.
        // / @param option The option to adjust from @ref admin_opts "Administration Options".
        // / @param value The new value for the option.
        public static void SetPlayOption(int option, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "SetPlayOption");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushInt(option);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete the TURD of playerName + characterName.
        // /
        // / At times a PC may get stuck in a permanent crash loop when attempting to log
        // / in. This function allows administrators to delete their Temporary User
        // / Resource Data where the PC's current location is stored allowing them to log
        // / into the starting area.
        // /
        // / @param playerName The community (login name).
        // / @param characterName The character name.
        // / @return Returns TRUE if successful
        public static int DeleteTURD(string playerName, string characterName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "DeleteTURD");
            Internal.NativeFunctions.nwnxPushString(characterName);
            Internal.NativeFunctions.nwnxPushString(playerName);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get an @ref admin_debug "Administration Debug Type" value.
        // / @param type An @ref admin_debug "Administration Debug Type".
        // / @return The current value for the supplied debug type from @ref admin_debug "Administration Debug Types".
        public static int GetDebugValue(int type)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "GetDebugValue");
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set an @ref admin_debug "Administration Debug Type" to a value.
        // / @param type The debug type to adjust from @ref admin_debug "Administration Debug Types".
        // / @param state The new state for the debug type, TRUE or FALSE
        public static void SetDebugValue(int type, int state)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "SetDebugValue");
            Internal.NativeFunctions.nwnxPushInt(state);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Reload all rules (2da stuff etc).
        // / @warning DANGER, DRAGONS. Bad things may or may not happen.
        public static void ReloadRules()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Administration, "ReloadRules");
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
    }
}
