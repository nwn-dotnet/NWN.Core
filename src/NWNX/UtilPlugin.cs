namespace NWN.Core.NWNX {
  [NWNXPlugin(NWNX_Util)]
  public class UtilPlugin {
    public const string NWNX_Util = "NWNX_Util";

    // /< @private
    // / @name Resref Types
    // / @anchor resref_types
    // / Constants for the various types of resrefs.
    // /
    // / @{
    public const int NWNX_UTIL_RESREF_TYPE_NSS = 2009;
    public const int NWNX_UTIL_RESREF_TYPE_NCS = 2010;
    public const int NWNX_UTIL_RESREF_TYPE_AREA_ARE = 2012;
    public const int NWNX_UTIL_RESREF_TYPE_TWODA = 2017;
    public const int NWNX_UTIL_RESREF_TYPE_AREA_GIT = 2023;
    public const int NWNX_UTIL_RESREF_TYPE_ITEM = 2025;
    public const int NWNX_UTIL_RESREF_TYPE_CREATURE = 2027;
    public const int NWNX_UTIL_RESREF_TYPE_DIALOG = 2029;
    public const int NWNX_UTIL_RESREF_TYPE_TRIGGER = 2032;
    public const int NWNX_UTIL_RESREF_TYPE_SOUND = 2035;
    public const int NWNX_UTIL_RESREF_TYPE_ENCOUNTER = 2040;
    public const int NWNX_UTIL_RESREF_TYPE_DOOR = 2042;
    public const int NWNX_UTIL_RESREF_TYPE_PLACEABLE = 2044;
    public const int NWNX_UTIL_RESREF_TYPE_STORE = 2051;
    public const int NWNX_UTIL_RESREF_TYPE_WAYPOINT = 2058;

    // /@}
    // / @brief Gets the name of the currently executing script.
    // / @note If depth is > 0, it will return the name of the script that called this one via ExecuteScript().
    // / @param depth to seek the executing script.
    // / @return The name of the currently executing script.
    public static string GetCurrentScriptName(int depth = 0) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetCurrentScriptName");
      Internal.NativeFunctions.nwnxPushInt(depth);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Gets a string that contains the ascii table.
    // / @note The character at index 0 is a space.
    // / @return A string that contains all characters at their position (e.g. 'A' at 65).
    public static string GetAsciiTableString() {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetAsciiTableString");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Gets an integer hash of a string.
    // / @param str The string to hash.
    // / @return The hashed string as an integer.
    public static int Hash(string str) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "Hash");
      Internal.NativeFunctions.nwnxPushString(str);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Gets the value of customTokenNumber.
    // / @param customTokenNumber The token number to query.
    // / @return The string representation of the token value.
    public static string GetCustomToken(int customTokenNumber) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetCustomToken");
      Internal.NativeFunctions.nwnxPushInt(customTokenNumber);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Convert an effect type to an itemproperty type.
    // / @param e The effect to convert to an itemproperty.
    // / @return The converted itemproperty.
    public static System.IntPtr EffectToItemProperty(System.IntPtr e) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "EffectToItemProperty");
      Internal.NativeFunctions.nwnxPushEffect(e);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopItemProperty();
    }

    // /
    // / @brief Convert an itemproperty type to an effect type.
    // / @param ip The itemproperty to convert to an effect.
    // / @return The converted effect.
    public static System.IntPtr ItemPropertyToEffect(System.IntPtr ip) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "ItemPropertyToEffect");
      Internal.NativeFunctions.nwnxPushItemProperty(ip);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopEffect();
    }

    // / @brief Strip any color codes from a string.
    // / @param str The string to strip of color.
    // / @return The new string without any color codes.
    public static string StripColors(string str) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "StripColors");
      Internal.NativeFunctions.nwnxPushString(str);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Determines if the supplied resref exists.
    // / @param resref The resref to check.
    // / @param type The @ref resref_types "Resref Type".
    // / @return TRUE/FALSE
    public static int IsValidResRef(string resref, int type = NWNX_UTIL_RESREF_TYPE_CREATURE) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "IsValidResRef");
      Internal.NativeFunctions.nwnxPushInt(type);
      Internal.NativeFunctions.nwnxPushString(resref);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Retrieves an environment variable.
    // / @param sVarname The environment variable to query.
    // / @return The value of the environment variable.
    public static string GetEnvironmentVariable(string sVarname) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetEnvironmentVariable");
      Internal.NativeFunctions.nwnxPushString(sVarname);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Gets the module real life minutes per in game hour.
    // / @return The minutes per hour.
    public static int GetMinutesPerHour() {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetMinutesPerHour");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Set module real life minutes per in game hour.
    // / @param minutes The minutes per hour.
    public static void SetMinutesPerHour(int minutes) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "SetMinutesPerHour");
      Internal.NativeFunctions.nwnxPushInt(minutes);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @anchor util_encode_url
    // / @brief Encodes a string for usage in a URL.
    // / @param str The string to encode for a URL.
    // / @return The url encoded string.
    public static string EncodeStringForURL(string str) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "EncodeStringForURL");
      Internal.NativeFunctions.nwnxPushString(str);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @anchor twoda_row_count
    // / @brief Gets the row count for a 2da.
    // / @param str The 2da to check (do not include the .2da).
    // / @return The amount of rows in the 2da.
    public static int Get2DARowCount(string str) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "Get2DARowCount");
      Internal.NativeFunctions.nwnxPushString(str);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Get the first resref of nType.
    // / @param nType A @ref resref_types "Resref Type".
    // / @param sRegexFilter Lets you filter out resrefs using a regexfilter.
    // / For example: **nwnx_.\*** gets you all scripts prefixed with nwnx_
    // / when using the NSS resref type.
    // / @param bModuleResourcesOnly If TRUE only custom resources will be returned.
    // / @return The first resref found or "" if none is found.
    public static string GetFirstResRef(int nType, string sRegexFilter = "", int bModuleResourcesOnly = NWScript.TRUE) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetFirstResRef");
      Internal.NativeFunctions.nwnxPushInt(bModuleResourcesOnly);
      Internal.NativeFunctions.nwnxPushString(sRegexFilter);
      Internal.NativeFunctions.nwnxPushInt(nType);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Get the next resref.
    // / @return The next resref found or "" if none is found.
    public static string GetNextResRef() {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetNextResRef");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Get the ticks per second of the server.
    // / @remark Useful to dynamically detect lag and adjust behavior accordingly.
    // / @return The ticks per second.
    public static int GetServerTicksPerSecond() {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetServerTicksPerSecond");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Get the last created object.
    // / @param nObjectType Does not take the NWScript OBJECT_TYPE_* constants.
    // / Use NWNX_Consts_TranslateNWScriptObjectType() to get their NWNX equivalent.
    // / @param nNthLast The nth last object created.
    // / @return The last created object. On error, this returns OBJECT_INVALID.
    public static uint GetLastCreatedObject(int nObjectType, int nNthLast = 1) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetLastCreatedObject");
      Internal.NativeFunctions.nwnxPushInt(nNthLast);
      Internal.NativeFunctions.nwnxPushInt(nObjectType);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopObject();
    }

    // / @brief Compiles and adds a script to the UserDirectory/nwnx folder.
    // / @note Will override existing scripts that are in the module.
    // / @param sFileName The script filename without extension, 16 or less characters.
    // / @param sScriptData The script data to compile
    // / @param bWrapIntoMain Set to TRUE to wrap sScriptData into void main(){}.
    // / @return "" on success, or the compilation error.
    public static string AddScript(string sFileName, string sScriptData, int bWrapIntoMain = NWScript.FALSE) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "AddScript");
      Internal.NativeFunctions.nwnxPushInt(bWrapIntoMain);
      Internal.NativeFunctions.nwnxPushString(sScriptData);
      Internal.NativeFunctions.nwnxPushString(sFileName);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Gets the contents of a .nss script file as a string.
    // / @param sScriptName The name of the script to get the contents of.
    // / @param nMaxLength The max length of the return string, -1 to get everything
    // / @return The script file contents or "" on error.
    public static string GetNSSContents(string sScriptName, int nMaxLength = -1) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetNSSContents");
      Internal.NativeFunctions.nwnxPushInt(nMaxLength);
      Internal.NativeFunctions.nwnxPushString(sScriptName);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Adds a nss file to the UserDirectory/nwnx folder.
    // / @note Will override existing nss files that are in the module
    // / @param sFileName The script filename without extension, 16 or less characters.
    // / @param sContents The contents of the nss file
    // / @return TRUE on success.
    public static int AddNSSFile(string sFileName, string sContents) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "AddNSSFile");
      Internal.NativeFunctions.nwnxPushString(sContents);
      Internal.NativeFunctions.nwnxPushString(sFileName);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Remove sFileName of nType from the UserDirectory/nwnx folder.
    // / @param sFileName The filename without extension, 16 or less characters.
    // / @param nType The @ref resref_types "Resref Type".
    // / @return TRUE on success.
    public static int RemoveNWNXResourceFile(string sFileName, int nType) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "RemoveNWNXResourceFile");
      Internal.NativeFunctions.nwnxPushInt(nType);
      Internal.NativeFunctions.nwnxPushString(sFileName);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Set the NWScript instruction limit
    // / @param nInstructionLimit The new limit or -1 to reset to default.
    public static void SetInstructionLimit(int nInstructionLimit) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "SetInstructionLimit");
      Internal.NativeFunctions.nwnxPushInt(nInstructionLimit);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Register a server console command that will execute a script chunk.
    // / @note Example usage: NWNX_Util_RegisterServerConsoleCommand("test", "PrintString(\"Test Command -> Args: $args\");");
    // / @param sCommand The name of the command.
    // / @param sScriptChunk The script chunk to run. You can use $args to get the console command arguments.
    // / @return TRUE on success.
    public static int RegisterServerConsoleCommand(string sCommand, string sScriptChunk) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "RegisterServerConsoleCommand");
      Internal.NativeFunctions.nwnxPushString(sScriptChunk);
      Internal.NativeFunctions.nwnxPushString(sCommand);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Unregister a server console command that was registered with NWNX_Util_RegisterServerConsoleCommand().
    // / @param sCommand The name of the command.
    public static void UnregisterServerConsoleCommand(string sCommand) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "UnregisterServerConsoleCommand");
      Internal.NativeFunctions.nwnxPushString(sCommand);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Determines if the given plugin exists and is enabled.
    // / @param sPlugin The name of the plugin to check. This is the case sensitive plugin name as used by NWNX_CallFunction, NWNX_PushArgumentX
    // / @note Example usage: NWNX_Util_PluginExists("NWNX_Creature");
    // / @return TRUE if the plugin exists and is enabled, otherwise FALSE.
    public static int PluginExists(string sPlugin) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "PluginExists");
      Internal.NativeFunctions.nwnxPushString(sPlugin);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Gets the server's current working user folder.
    // / @return The absolute path of the server's home directory (-userDirectory)
    public static string GetUserDirectory() {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetUserDirectory");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Get the return value of the last run script with a StartingConditional
    // / @return Return value of the last run script.
    public static int GetScriptReturnValue() {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Util, "GetScriptReturnValue");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @}
  }
}