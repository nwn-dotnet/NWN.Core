using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Util)]
  public class UtilPlugin
  {
    /// @addtogroup util Util
    /// Provides various utility functions that don&apos;t have a better home
    /// @{
    /// @file nwnx_util.nss
    public const string NWNX_Util = "NWNX_Util";

    ///&lt; @private
    /// @name Resref Types
    /// @anchor resref_types
    /// Constants for the various types of resrefs.
    ///
    /// @{
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

    ///@}
    /// A world time struct
    /// A high resolution timestamp
    /// Gets the name of the currently executing script.
    /// @note If depth is &gt; 0, it will return the name of the script that called this one via ExecuteScript().
    /// <param name="depth">to seek the executing script.</param>
    /// <returns>The name of the currently executing script.</returns>
    public static string GetCurrentScriptName(int depth = 0)
    {
      NWNXPushInt(depth);
      NWNXCall(NWNX_Util, "GetCurrentScriptName");
      return NWNXPopString();
    }

    /// Gets a string that contains the ascii table.
    /// @note The character at index 0 is a space.
    /// <returns>A string that contains all characters at their position (e.g. &apos;A&apos; at 65).</returns>
    public static string GetAsciiTableString()
    {
      NWNXCall(NWNX_Util, "GetAsciiTableString");
      return NWNXPopString();
    }

    /// Gets an integer hash of a string.
    /// <param name="str">The string to hash.</param>
    /// <returns>The hashed string as an integer.</returns>
    public static int Hash(string str)
    {
      NWNXPushString(str);
      NWNXCall(NWNX_Util, "Hash");
      return NWNXPopInt();
    }

    /// Gets the last modified timestamp (mtime) of the module file in seconds.
    /// <returns>The mtime of the module file.</returns>
    public static int GetModuleMtime()
    {
      NWNXCall(NWNX_Util, "GetModuleMtime");
      return NWNXPopInt();
    }

    /// Gets the module short file name.
    /// <returns>The module file as a string.</returns>
    public static string GetModuleFile()
    {
      NWNXCall(NWNX_Util, "GetModuleFile");
      return NWNXPopString();
    }

    /// Gets the value of customTokenNumber.
    /// <param name="customTokenNumber">The token number to query.</param>
    /// <returns>The string representation of the token value.</returns>
    public static string GetCustomToken(int customTokenNumber)
    {
      NWNXPushInt(customTokenNumber);
      NWNXCall(NWNX_Util, "GetCustomToken");
      return NWNXPopString();
    }

    /// Convert an effect type to an itemproperty type.
    /// <param name="e">The effect to convert to an itemproperty.</param>
    /// <returns>The converted itemproperty.</returns>
    public static System.IntPtr EffectToItemProperty(System.IntPtr e)
    {
      NWNXPushEffect(e);
      NWNXCall(NWNX_Util, "EffectTypeCast");
      return NWNXPopItemProperty();
    }

    /// Convert an itemproperty type to an effect type.
    /// <param name="ip">The itemproperty to convert to an effect.</param>
    /// <returns>The converted effect.</returns>
    public static System.IntPtr ItemPropertyToEffect(System.IntPtr ip)
    {
      NWNXPushItemProperty(ip);
      NWNXCall(NWNX_Util, "EffectTypeCast");
      return NWNXPopEffect();
    }

    /// Strip any color codes from a string.
    /// <param name="str">The string to strip of color.</param>
    /// <returns>The new string without any color codes.</returns>
    public static string StripColors(string str)
    {
      NWNXPushString(str);
      NWNXCall(NWNX_Util, "StripColors");
      return NWNXPopString();
    }

    /// Retrieves an environment variable.
    /// <param name="sVarname">The environment variable to query.</param>
    /// <returns>The value of the environment variable.</returns>
    public static string GetEnvironmentVariable(string sVarname)
    {
      NWNXPushString(sVarname);
      NWNXCall(NWNX_Util, "GetEnvironmentVariable");
      return NWNXPopString();
    }

    /// Gets the module real life minutes per in game hour.
    /// <returns>The minutes per hour.</returns>
    public static int GetMinutesPerHour()
    {
      NWNXCall(NWNX_Util, "GetMinutesPerHour");
      return NWNXPopInt();
    }

    /// Set module real life minutes per in game hour.
    /// <param name="minutes">The minutes per hour.</param>
    public static void SetMinutesPerHour(int minutes)
    {
      NWNXPushInt(minutes);
      NWNXCall(NWNX_Util, "SetMinutesPerHour");
    }

    /// @anchor util_encode_url
    /// Encodes a string for usage in a URL.
    /// <param name="str">The string to encode for a URL.</param>
    /// <returns>The url encoded string.</returns>
    public static string EncodeStringForURL(string sURL)
    {
      NWNXPushString(sURL);
      NWNXCall(NWNX_Util, "EncodeStringForURL");
      return NWNXPopString();
    }

    /// Get the first resref of nType.
    /// <param name="nType">A @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sRegexFilter">Lets you filter out resrefs using a regexfilter.</param>
    /// For example: **nwnx_.\*** gets you all scripts prefixed with nwnx_
    /// when using the NSS resref type.
    /// <param name="bModuleResourcesOnly">If TRUE only custom resources will be returned.</param>
    /// <returns>The first resref found or &quot;&quot; if none is found.</returns>
    public static string GetFirstResRef(int nType, string sRegexFilter = "", int bModuleResourcesOnly = TRUE)
    {
      NWNXPushInt(bModuleResourcesOnly);
      NWNXPushString(sRegexFilter);
      NWNXPushInt(nType);
      NWNXCall(NWNX_Util, "GetFirstResRef");
      return NWNXPopString();
    }

    /// Get the next resref.
    /// <returns>The next resref found or &quot;&quot; if none is found.</returns>
    public static string GetNextResRef()
    {
      NWNXCall(NWNX_Util, "GetNextResRef");
      return NWNXPopString();
    }

    /// Get the last created object.
    /// <param name="nObjectType">Does not take the NWScript OBJECT_TYPE_* constants.</param>
    /// Use NWNX_Consts_TranslateNWScriptObjectType() to get their NWNX equivalent.
    /// <param name="nNthLast">The nth last object created.</param>
    /// <returns>The last created object. On error, this returns OBJECT_INVALID.</returns>
    public static uint GetLastCreatedObject(int nObjectType, int nNthLast = 1)
    {
      NWNXPushInt(nNthLast);
      NWNXPushInt(nObjectType);
      NWNXCall(NWNX_Util, "GetLastCreatedObject");
      return NWNXPopObject();
    }

    /// Compiles and adds a script to the UserDirectory/nwnx folder, or to the location of sAlias.
    /// @note Will override existing scripts that are in the module.
    /// <param name="sFileName">The script filename without extension, 16 or less characters.</param>
    /// <param name="sScriptData">The script data to compile</param>
    /// <param name="bWrapIntoMain">Set to TRUE to wrap sScriptData into void main(){}.</param>
    /// <param name="sAlias">The alias of the resource directory to add the ncs file to. Default: UserDirectory/nwnx</param>
    /// <returns>&quot;&quot; on success, or the compilation error.</returns>
    public static string AddScript(string sFileName, string sScriptData, int bWrapIntoMain = FALSE, string sAlias = "NWNX")
    {
      NWNXPushString(sAlias);
      NWNXPushInt(bWrapIntoMain);
      NWNXPushString(sScriptData);
      NWNXPushString(sFileName);
      NWNXCall(NWNX_Util, "AddScript");
      return NWNXPopString();
    }

    /// Adds a nss file to the UserDirectory/nwnx folder, or to the location of sAlias.
    /// @note Will override existing nss files that are in the module
    /// <param name="sFileName">The script filename without extension, 16 or less characters.</param>
    /// <param name="sContents">The contents of the nss file</param>
    /// <param name="sAlias">The alias of the resource directory to add the nss file to. Default: UserDirectory/nwnx</param>
    /// <returns>TRUE on success.</returns>
    public static int AddNSSFile(string sFileName, string sContents, string sAlias = "NWNX")
    {
      NWNXPushString(sAlias);
      NWNXPushString(sContents);
      NWNXPushString(sFileName);
      NWNXCall(NWNX_Util, "AddNSSFile");
      return NWNXPopInt();
    }

    /// Remove sFileName of nType from the UserDirectory/nwnx folder, or from the location of sAlias.
    /// <param name="sFileName">The filename without extension, 16 or less characters.</param>
    /// <param name="nType">The @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sAlias">The alias of the resource directory to remove the file from. Default: UserDirectory/nwnx</param>
    /// <returns>TRUE on success.</returns>
    public static int RemoveNWNXResourceFile(string sFileName, int nType, string sAlias = "NWNX")
    {
      NWNXPushString(sAlias);
      NWNXPushInt(nType);
      NWNXPushString(sFileName);
      NWNXCall(NWNX_Util, "RemoveNWNXResourceFile");
      return NWNXPopInt();
    }

    /// Set the NWScript instruction limit.
    /// <param name="nInstructionLimit">The new limit or -1 to reset to default.</param>
    public static void SetInstructionLimit(int nInstructionLimit)
    {
      NWNXPushInt(nInstructionLimit);
      NWNXCall(NWNX_Util, "SetInstructionLimit");
    }

    /// Get the NWScript instruction limit.
    public static int GetInstructionLimit()
    {
      NWNXCall(NWNX_Util, "GetInstructionLimit");
      return NWNXPopInt();
    }

    /// Set the number of NWScript instructions currently executed.
    /// <param name="nInstructions">The number of instructions, must be &gt;= 0.</param>
    public static void SetInstructionsExecuted(int nInstructions)
    {
      NWNXPushInt(nInstructions);
      NWNXCall(NWNX_Util, "SetInstructionsExecuted");
    }

    /// Get the number of NWScript instructions currently executed.
    public static int GetInstructionsExecuted()
    {
      NWNXCall(NWNX_Util, "GetInstructionsExecuted");
      return NWNXPopInt();
    }

    /// Register a server console command that will execute a script chunk.
    /// @note Example usage: NWNX_Util_RegisterServerConsoleCommand(&quot;test&quot;, &quot;PrintString(\&quot;Test Command -&gt; Args: $args\&quot;);&quot;);
    /// <param name="sCommand">The name of the command.</param>
    /// <param name="sScriptChunk">The script chunk to run. You can use $args to get the console command arguments.</param>
    /// <returns>TRUE on success.</returns>
    public static int RegisterServerConsoleCommand(string sCommand, string sScriptChunk)
    {
      NWNXPushString(sScriptChunk);
      NWNXPushString(sCommand);
      NWNXCall(NWNX_Util, "RegisterServerConsoleCommand");
      return NWNXPopInt();
    }

    /// Unregister a server console command that was registered with NWNX_Util_RegisterServerConsoleCommand().
    /// <param name="sCommand">The name of the command.</param>
    public static void UnregisterServerConsoleCommand(string sCommand)
    {
      NWNXPushString(sCommand);
      NWNXCall(NWNX_Util, "UnregisterServerConsoleCommand");
    }

    /// Gets the server&apos;s current working user folder.
    /// <returns>The absolute path of the server&apos;s home directory (-userDirectory)</returns>
    public static string GetUserDirectory()
    {
      NWNXCall(NWNX_Util, "GetUserDirectory");
      return NWNXPopString();
    }

    /// Get the return value of the last run script with a StartingConditional
    /// <returns>Return value of the last run script.</returns>
    public static int GetScriptReturnValue()
    {
      NWNXCall(NWNX_Util, "GetScriptReturnValue");
      return NWNXPopInt();
    }

    /// Create a door.
    /// <param name="sResRef">The ResRef of the door.</param>
    /// <param name="locLocation">The location to create the door at.</param>
    /// <param name="sNewTag">An optional new tag for the door.</param>
    /// <param name="nAppearanceType">An optional index into doortypes.2da for appearance.</param>
    /// <returns>The door, or OBJECT_INVALID on failure.</returns>
    public static uint CreateDoor(string sResRef, System.IntPtr locLocation, string sNewTag = "", int nAppearanceType = -1)
    {
      NWNXPushInt(nAppearanceType);
      NWNXPushString(sNewTag);
      NWNXPushLocation(locLocation);
      NWNXPushString(sResRef);
      NWNXCall(NWNX_Util, "CreateDoor");
      return NWNXPopObject();
    }

    /// Set the object that will be returned by GetItemActivator.
    /// <param name="oObject">An object.</param>
    public static void SetItemActivator(uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Util, "SetItemActivator");
    }

    /// Get the world time as calendar day and time of day.
    /// @note This function is useful for calculating effect expiry times.
    /// <param name="fAdjustment">An adjustment in seconds, 0.0f will return the current world time,</param>
    /// positive or negative values will return a world time in the future or past.
    /// <returns>A NWNX_Util_WorldTime struct with the calendar day and time of day.</returns>
    public static WorldTime GetWorldTime(float fAdjustment = 0.0f)
    {
      NWNXPushFloat(fAdjustment);
      NWNXCall(NWNX_Util, "GetWorldTime");
      WorldTime strWorldTime = default;
      strWorldTime.nTimeOfDay = NWNXPopInt();
      strWorldTime.nCalendarDay = NWNXPopInt();
      return strWorldTime;
    }

    /// Set a server-side resource override.
    /// <param name="nResType">A @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sOldName">The old resource name, 16 characters or less.</param>
    /// <param name="sNewName">The new resource name or &quot;&quot; to clear a previous override, 16 characters or less.</param>
    public static void SetResourceOverride(int nResType, string sOldName, string sNewName)
    {
      NWNXPushString(sNewName);
      NWNXPushString(sOldName);
      NWNXPushInt(nResType);
      NWNXCall(NWNX_Util, "SetResourceOverride");
    }

    /// Get a server-side resource override.
    /// <param name="nResType">A @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sName">The name of the resource, 16 characters or less.</param>
    /// <returns>The resource override, or &quot;&quot; if one is not set.</returns>
    public static string GetResourceOverride(int nResType, string sName)
    {
      NWNXPushString(sName);
      NWNXPushInt(nResType);
      NWNXCall(NWNX_Util, "GetResourceOverride");
      return NWNXPopString();
    }

    /// Get if a script param is set.
    /// <param name="sParamName">The script parameter name to check.</param>
    /// <returns>TRUE if the script param is set, FALSE if not or on error.</returns>
    public static int GetScriptParamIsSet(string sParamName)
    {
      NWNXPushString(sParamName);
      NWNXCall(NWNX_Util, "GetScriptParamIsSet");
      return NWNXPopInt();
    }

    /// Set the module dawn hour.
    /// <param name="nDawnHour">The new dawn hour</param>
    public static void SetDawnHour(int nDawnHour)
    {
      NWNXPushInt(nDawnHour);
      NWNXCall(NWNX_Util, "SetDawnHour");
    }

    /// Get the module dawn hour.
    /// <returns>The dawn hour</returns>
    public static int GetDawnHour()
    {
      NWNXCall(NWNX_Util, "GetDawnHour");
      return NWNXPopInt();
    }

    /// Set the module dusk hour.
    /// <param name="nDuskHour">The new dusk hour</param>
    public static void SetDuskHour(int nDuskHour)
    {
      NWNXPushInt(nDuskHour);
      NWNXCall(NWNX_Util, "SetDuskHour");
    }

    /// Get the module dusk hour.
    /// <returns>The dusk hour</returns>
    public static int GetDuskHour()
    {
      NWNXCall(NWNX_Util, "GetDuskHour");
      return NWNXPopInt();
    }

    /// <returns>Returns the number of microseconds since midnight on January 1, 1970.</returns>
    public static HighResTimestamp GetHighResTimeStamp()
    {
      HighResTimestamp t = default;
      NWNXCall(NWNX_Util, "GetHighResTimeStamp");
      t.microseconds = NWNXPopInt();
      t.seconds = NWNXPopInt();
      return t;
    }

    /// <returns>Return name of a terminal, &quot;&quot; if not a TTY</returns>
    public static string GetTTY()
    {
      NWNXCall(NWNX_Util, "GetTTY");
      return NWNXPopString();
    }

    /// Set the currently running script event.
    /// <param name="nEventID">The ID of the event.</param>
    public static void SetCurrentlyRunningEvent(int nEventID)
    {
      NWNXPushInt(nEventID);
      NWNXCall(NWNX_Util, "SetCurrentlyRunningEvent");
    }

    /// Calculate the levenshtein distance of two strings
    /// <param name="sString">The string to compare with.</param>
    /// <param name="sCompareTo">The string to compare sString to.</param>
    /// <returns>The number of characters different between the compared strings.</returns>
    public static int GetStringLevenshteinDistance(string sString, string sCompareTo)
    {
      NWNXPushString(sCompareTo);
      NWNXPushString(sString);
      NWNXCall(NWNX_Util, "GetStringLevenshteinDistance");
      return NWNXPopInt();
    }

    /// Sends a full object update of oObjectToUpdate to all clients
    /// <param name="oObjectToUpdate">The object to update</param>
    /// <param name="oPlayer">The player for which the objects needs to update, OBJECT_INVALID for all players</param>
    public static void UpdateClientObject(uint oObjectToUpdate, uint oPlayer = OBJECT_INVALID)
    {
      NWNXPushObject(oPlayer);
      NWNXPushObject(oObjectToUpdate);
      NWNXCall(NWNX_Util, "UpdateClientObject");
    }

    /// Clean a resource directory, deleting all files of nResType.
    /// <param name="sAlias">A resource directory alias, NWNX or one defined in the custom resource directory file.</param>
    /// <param name="nResType">The type of file to delete or 0xFFFF for all types.</param>
    /// <returns>TRUE if successful, FALSE on error.</returns>
    public static int CleanResourceDirectory(string sAlias, int nResType = 65535)
    {
      NWNXPushInt(nResType);
      NWNXPushString(sAlias);
      NWNXCall(NWNX_Util, "CleanResourceDirectory");
      return NWNXPopInt();
    }

    /// Return the filename of the tlk file.
    /// <returns>The name</returns>
    public static string GetModuleTlkFile()
    {
      const string sFunc = "GetModuleTlkFile";
      NWNXCall(NWNX_Util, sFunc);
      return NWNXPopString();
    }

    /// Update a resource directory by having ResMan reindex it.
    /// <param name="sAlias">A resource directory alias, eg: TEMP</param>
    /// <returns>TRUE if successful, FALSE on error.</returns>
    public static int UpdateResourceDirectory(string sAlias)
    {
      NWNXPushString(sAlias);
      NWNXCall(NWNX_Util, "UpdateResourceDirectory");
      return NWNXPopInt();
    }

    // @}
  }

  public struct WorldTime
  {
    public int nCalendarDay;
    public int nTimeOfDay;
  }

  public struct HighResTimestamp
  {
    public int seconds;
    public int microseconds;
  }
}
