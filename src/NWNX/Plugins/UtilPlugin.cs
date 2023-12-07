using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Util)]
  public class UtilPlugin
  {
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
      const string sFunc = "GetCurrentScriptName";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(depth);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Gets a string that contains the ascii table.
    /// @note The character at index 0 is a space.
    /// <returns>A string that contains all characters at their position (e.g. &apos;A&apos; at 65).</returns>
    public static string GetAsciiTableString()
    {
      const string sFunc = "GetAsciiTableString";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Gets an integer hash of a string.
    /// <param name="str">The string to hash.</param>
    /// <returns>The hashed string as an integer.</returns>
    public static int Hash(string str)
    {
      const string sFunc = "Hash";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(str);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the last modified timestamp (mtime) of the module file in seconds.
    /// <returns>The mtime of the module file.</returns>
    public static int GetModuleMtime()
    {
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the module short file name.
    /// <returns>The module file as a string.</returns>
    public static string GetModuleFile()
    {
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Gets the value of customTokenNumber.
    /// <param name="customTokenNumber">The token number to query.</param>
    /// <returns>The string representation of the token value.</returns>
    public static string GetCustomToken(int customTokenNumber)
    {
      const string sFunc = "GetCustomToken";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(customTokenNumber);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Convert an effect type to an itemproperty type.
    /// <param name="e">The effect to convert to an itemproperty.</param>
    /// <returns>The converted itemproperty.</returns>
    public static System.IntPtr EffectToItemProperty(System.IntPtr e)
    {
      const string sFunc = "EffectTypeCast";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(e, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    /// Convert an itemproperty type to an effect type.
    /// <param name="ip">The itemproperty to convert to an effect.</param>
    /// <returns>The converted effect.</returns>
    public static System.IntPtr ItemPropertyToEffect(System.IntPtr ip)
    {
      const string sFunc = "EffectTypeCast";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    /// Strip any color codes from a string.
    /// <param name="str">The string to strip of color.</param>
    /// <returns>The new string without any color codes.</returns>
    public static string StripColors(string str)
    {
      const string sFunc = "StripColors";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(str);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Retrieves an environment variable.
    /// <param name="sVarname">The environment variable to query.</param>
    /// <returns>The value of the environment variable.</returns>
    public static string GetEnvironmentVariable(string sVarname)
    {
      const string sFunc = "GetEnvironmentVariable";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sVarname);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Gets the module real life minutes per in game hour.
    /// <returns>The minutes per hour.</returns>
    public static int GetMinutesPerHour()
    {
      const string sFunc = "GetMinutesPerHour";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set module real life minutes per in game hour.
    /// <param name="minutes">The minutes per hour.</param>
    public static void SetMinutesPerHour(int minutes)
    {
      const string sFunc = "SetMinutesPerHour";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(minutes);
      VM.NWNX.Call();
    }

    /// @anchor util_encode_url
    /// Encodes a string for usage in a URL.
    /// <param name="str">The string to encode for a URL.</param>
    /// <returns>The url encoded string.</returns>
    public static string EncodeStringForURL(string sURL)
    {
      const string sFunc = "EncodeStringForURL";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sURL);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
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
      const string sFunc = "GetFirstResRef";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(bModuleResourcesOnly);
      VM.NWNX.StackPush(sRegexFilter);
      VM.NWNX.StackPush(nType);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the next resref.
    /// <returns>The next resref found or &quot;&quot; if none is found.</returns>
    public static string GetNextResRef()
    {
      const string sFunc = "GetNextResRef";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the last created object.
    /// <param name="nObjectType">Does not take the NWScript OBJECT_TYPE_* constants.</param>
    /// Use NWNX_Consts_TranslateNWScriptObjectType() to get their NWNX equivalent.
    /// <param name="nNthLast">The nth last object created.</param>
    /// <returns>The last created object. On error, this returns OBJECT_INVALID.</returns>
    public static uint GetLastCreatedObject(int nObjectType, int nNthLast = 1)
    {
      const string sFunc = "GetLastCreatedObject";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(nNthLast);
      VM.NWNX.StackPush(nObjectType);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
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
      const string sFunc = "AddScript";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sAlias);
      VM.NWNX.StackPush(bWrapIntoMain);
      VM.NWNX.StackPush(sScriptData);
      VM.NWNX.StackPush(sFileName);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Adds a nss file to the UserDirectory/nwnx folder, or to the location of sAlias.
    /// @note Will override existing nss files that are in the module
    /// <param name="sFileName">The script filename without extension, 16 or less characters.</param>
    /// <param name="sContents">The contents of the nss file</param>
    /// <param name="sAlias">The alias of the resource directory to add the nss file to. Default: UserDirectory/nwnx</param>
    /// <returns>TRUE on success.</returns>
    public static int AddNSSFile(string sFileName, string sContents, string sAlias = "NWNX")
    {
      const string sFunc = "AddNSSFile";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sAlias);
      VM.NWNX.StackPush(sContents);
      VM.NWNX.StackPush(sFileName);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Remove sFileName of nType from the UserDirectory/nwnx folder, or from the location of sAlias.
    /// <param name="sFileName">The filename without extension, 16 or less characters.</param>
    /// <param name="nType">The @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sAlias">The alias of the resource directory to remove the file from. Default: UserDirectory/nwnx</param>
    /// <returns>TRUE on success.</returns>
    public static int RemoveNWNXResourceFile(string sFileName, int nType, string sAlias = "NWNX")
    {
      const string sFunc = "RemoveNWNXResourceFile";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sAlias);
      VM.NWNX.StackPush(nType);
      VM.NWNX.StackPush(sFileName);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the NWScript instruction limit.
    /// <param name="nInstructionLimit">The new limit or -1 to reset to default.</param>
    public static void SetInstructionLimit(int nInstructionLimit)
    {
      const string sFunc = "SetInstructionLimit";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(nInstructionLimit);
      VM.NWNX.Call();
    }

    /// Get the NWScript instruction limit.
    public static int GetInstructionLimit()
    {
      const string sFunc = "GetInstructionLimit";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the number of NWScript instructions currently executed.
    /// <param name="nInstructions">The number of instructions, must be &gt;= 0.</param>
    public static void SetInstructionsExecuted(int nInstructions)
    {
      const string sFunc = "SetInstructionsExecuted";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(nInstructions);
      VM.NWNX.Call();
    }

    /// Get the number of NWScript instructions currently executed.
    public static int GetInstructionsExecuted()
    {
      const string sFunc = "GetInstructionsExecuted";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Register a server console command that will execute a script chunk.
    /// @note Example usage: NWNX_Util_RegisterServerConsoleCommand(&quot;test&quot;, &quot;PrintString(\&quot;Test Command -&gt; Args: $args\&quot;);&quot;);
    /// <param name="sCommand">The name of the command.</param>
    /// <param name="sScriptChunk">The script chunk to run. You can use $args to get the console command arguments.</param>
    /// <returns>TRUE on success.</returns>
    public static int RegisterServerConsoleCommand(string sCommand, string sScriptChunk)
    {
      const string sFunc = "RegisterServerConsoleCommand";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sScriptChunk);
      VM.NWNX.StackPush(sCommand);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Unregister a server console command that was registered with NWNX_Util_RegisterServerConsoleCommand().
    /// <param name="sCommand">The name of the command.</param>
    public static void UnregisterServerConsoleCommand(string sCommand)
    {
      const string sFunc = "UnregisterServerConsoleCommand";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sCommand);
      VM.NWNX.Call();
    }

    /// Determines if the given plugin exists and is enabled.
    /// <param name="sPlugin">The name of the plugin to check. This is the case sensitive plugin name as used by NWNX_CallFunction, NWNX_PushArgumentX</param>
    /// @note Example usage: NWNX_Util_PluginExists(&quot;NWNX_Creature&quot;);
    /// <returns>TRUE if the plugin exists and is enabled, otherwise FALSE.</returns>
    public static int PluginExists(string sPlugin)
    {
      WriteTimestampedLogEntry("WARNING:  NWNX_Util_PluginExists is deprecated.  You should migrate to NWNX_PluginExists.");
      return VM.NWNX.StackPopInt();
    }

    /// Gets the server&apos;s current working user folder.
    /// <returns>The absolute path of the server&apos;s home directory (-userDirectory)</returns>
    public static string GetUserDirectory()
    {
      const string sFunc = "GetUserDirectory";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the return value of the last run script with a StartingConditional
    /// <returns>Return value of the last run script.</returns>
    public static int GetScriptReturnValue()
    {
      const string sFunc = "GetScriptReturnValue";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Create a door.
    /// <param name="sResRef">The ResRef of the door.</param>
    /// <param name="locLocation">The location to create the door at.</param>
    /// <param name="sNewTag">An optional new tag for the door.</param>
    /// <param name="nAppearanceType">An optional index into doortypes.2da for appearance.</param>
    /// <returns>The door, or OBJECT_INVALID on failure.</returns>
    public static uint CreateDoor(string sResRef, System.IntPtr locLocation, string sNewTag = "", int nAppearanceType = -1)
    {
      const string sFunc = "CreateDoor";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      System.Numerics.Vector3 vPosition = GetPositionFromLocation(locLocation);
      VM.NWNX.StackPush(nAppearanceType);
      VM.NWNX.StackPush(sNewTag);
      VM.NWNX.StackPush(GetFacingFromLocation(locLocation));
      VM.NWNX.StackPush(vPosition.Z);
      VM.NWNX.StackPush(vPosition.Y);
      VM.NWNX.StackPush(vPosition.X);
      VM.NWNX.StackPush(GetAreaFromLocation(locLocation));
      VM.NWNX.StackPush(sResRef);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Set the object that will be returned by GetItemActivator.
    /// <param name="oObject">An object.</param>
    public static void SetItemActivator(uint oObject)
    {
      const string sFunc = "SetItemActivator";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
    }

    /// Get the world time as calendar day and time of day.
    /// @note This function is useful for calculating effect expiry times.
    /// <param name="fAdjustment">An adjustment in seconds, 0.0f will return the current world time,</param>
    /// positive or negative values will return a world time in the future or past.
    /// <returns>A NWNX_Util_WorldTime struct with the calendar day and time of day.</returns>
    public static WorldTime GetWorldTime(float fAdjustment = 0.0f)
    {
      const string sFunc = "GetWorldTime";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(fAdjustment);
      VM.NWNX.Call();
      WorldTime strWorldTime = default;
      strWorldTime.nTimeOfDay = VM.NWNX.StackPopInt();
      strWorldTime.nCalendarDay = VM.NWNX.StackPopInt();
      return strWorldTime;
    }

    /// Set a server-side resource override.
    /// <param name="nResType">A @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sOldName">The old resource name, 16 characters or less.</param>
    /// <param name="sNewName">The new resource name or &quot;&quot; to clear a previous override, 16 characters or less.</param>
    public static void SetResourceOverride(int nResType, string sOldName, string sNewName)
    {
      const string sFunc = "SetResourceOverride";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sNewName);
      VM.NWNX.StackPush(sOldName);
      VM.NWNX.StackPush(nResType);
      VM.NWNX.Call();
    }

    /// Get a server-side resource override.
    /// <param name="nResType">A @ref resref_types &quot;Resref Type&quot;.</param>
    /// <param name="sName">The name of the resource, 16 characters or less.</param>
    /// <returns>The resource override, or &quot;&quot; if one is not set.</returns>
    public static string GetResourceOverride(int nResType, string sName)
    {
      const string sFunc = "GetResourceOverride";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sName);
      VM.NWNX.StackPush(nResType);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get if a script param is set.
    /// <param name="sParamName">The script parameter name to check.</param>
    /// <returns>TRUE if the script param is set, FALSE if not or on error.</returns>
    public static int GetScriptParamIsSet(string sParamName)
    {
      const string sFunc = "GetScriptParamIsSet";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sParamName);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the module dawn hour.
    /// <param name="nDawnHour">The new dawn hour</param>
    public static void SetDawnHour(int nDawnHour)
    {
      const string sFunc = "SetDawnHour";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(nDawnHour);
      VM.NWNX.Call();
    }

    /// Set the module dusk hour.
    /// <param name="nDuskHour">The new dusk hour</param>
    public static void SetDuskHour(int nDuskHour)
    {
      const string sFunc = "SetDuskHour";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(nDuskHour);
      VM.NWNX.Call();
    }

    /// <returns>Returns the number of microseconds since midnight on January 1, 1970.</returns>
    public static HighResTimestamp GetHighResTimeStamp()
    {
      HighResTimestamp t = default;
      const string sFunc = "GetHighResTimeStamp";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      t.microseconds = VM.NWNX.StackPopInt();
      t.seconds = VM.NWNX.StackPopInt();
      return t;
    }

    /// <returns>Return name of a terminal, &quot;&quot; if not a TTY</returns>
    public static string GetTTY()
    {
      const string sFunc = "GetTTY";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Set the currently running script event.
    /// <param name="nEventID">The ID of the event.</param>
    public static void SetCurrentlyRunningEvent(int nEventID)
    {
      const string sFunc = "SetCurrentlyRunningEvent";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(nEventID);
      VM.NWNX.Call();
    }

    /// Calculate the levenshtein distance of two strings
    /// <param name="sString">The string to compare with.</param>
    /// <param name="sCompareTo">The string to compare sString to.</param>
    /// <returns>The number of characters different between the compared strings.</returns>
    public static int GetStringLevenshteinDistance(string sString, string sCompareTo)
    {
      const string sFunc = "LevenshteinDistance";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(sCompareTo);
      VM.NWNX.StackPush(sString);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sends a full object update of oObjectToUpdate to all clients
    /// <param name="oObjectToUpdate">The object to update</param>
    /// <param name="oPlayer">The player for which the objects needs to update, OBJECT_INVALID for all players</param>
    public static void UpdateClientObject(uint oObjectToUpdate, uint oPlayer = OBJECT_INVALID)
    {
      const string sFunc = "UpdateClientObject";
      VM.NWNX.SetFunction(NWNX_Util, sFunc);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.StackPush(oObjectToUpdate);
      VM.NWNX.Call();
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
