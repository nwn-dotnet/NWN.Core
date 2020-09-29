namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Util)]
    public class UtilPlugin
    {
        public const string NWNX_Util = "NWNX_Util";

        ///< @private
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
        /// Gets the name of the currently executing script.
        /// @note If depth is > 0, it will return the name of the script that called this one via ExecuteScript().
        /// <param name="depth">to seek the executing script.</param>
        /// <returns>The name of the currently executing script.</returns>
        public static string GetCurrentScriptName(int depth = 0)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetCurrentScriptName");
            VM.NWNX.StackPush(depth);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Gets a string that contains the ascii table.
        /// @note The character at index 0 is a space.
        /// <returns>A string that contains all characters at their position (e.g. 'A' at 65).</returns>
        public static string GetAsciiTableString()
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetAsciiTableString");
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Gets an integer hash of a string.
        /// <param name="str">The string to hash.</param>
        /// <returns>The hashed string as an integer.</returns>
        public static int Hash(string str)
        {
            VM.NWNX.SetFunction(NWNX_Util, "Hash");
            VM.NWNX.StackPush(str);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Gets the value of customTokenNumber.
        /// <param name="customTokenNumber">The token number to query.</param>
        /// <returns>The string representation of the token value.</returns>
        public static string GetCustomToken(int customTokenNumber)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetCustomToken");
            VM.NWNX.StackPush(customTokenNumber);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Convert an effect type to an itemproperty type.
        /// <param name="e">The effect to convert to an itemproperty.</param>
        /// <returns>The converted itemproperty.</returns>
        public static System.IntPtr EffectToItemProperty(System.IntPtr e)
        {
            VM.NWNX.SetFunction(NWNX_Util, "EffectTypeCast");
            VM.NWNX.StackPush(e, NWScript.ENGINE_STRUCTURE_EFFECT);
            VM.NWNX.Call();
            return VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_ITEM_PROPERTY);
        }

        ///
        /// Convert an itemproperty type to an effect type.
        /// <param name="ip">The itemproperty to convert to an effect.</param>
        /// <returns>The converted effect.</returns>
        public static System.IntPtr ItemPropertyToEffect(System.IntPtr ip)
        {
            VM.NWNX.SetFunction(NWNX_Util, "EffectTypeCast");
            VM.NWNX.StackPush(ip, NWScript.ENGINE_STRUCTURE_ITEM_PROPERTY);
            VM.NWNX.Call();
            return VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_EFFECT);
        }

        /// Strip any color codes from a string.
        /// <param name="str">The string to strip of color.</param>
        /// <returns>The new string without any color codes.</returns>
        public static string StripColors(string str)
        {
            VM.NWNX.SetFunction(NWNX_Util, "StripColors");
            VM.NWNX.StackPush(str);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Determines if the supplied resref exists.
        /// <param name="resref">The resref to check.</param>
        /// <param name="type">The @ref resref_types "Resref Type".</param>
        /// <returns>TRUE/FALSE</returns>
        public static int IsValidResRef(string resref, int type = NWNX_UTIL_RESREF_TYPE_CREATURE)
        {
            VM.NWNX.SetFunction(NWNX_Util, "IsValidResRef");
            VM.NWNX.StackPush(type);
            VM.NWNX.StackPush(resref);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Retrieves an environment variable.
        /// <param name="sVarname">The environment variable to query.</param>
        /// <returns>The value of the environment variable.</returns>
        public static string GetEnvironmentVariable(string sVarname)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetEnvironmentVariable");
            VM.NWNX.StackPush(sVarname);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Gets the module real life minutes per in game hour.
        /// <returns>The minutes per hour.</returns>
        public static int GetMinutesPerHour()
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetMinutesPerHour");
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set module real life minutes per in game hour.
        /// <param name="minutes">The minutes per hour.</param>
        public static void SetMinutesPerHour(int minutes)
        {
            VM.NWNX.SetFunction(NWNX_Util, "SetMinutesPerHour");
            VM.NWNX.StackPush(minutes);
            VM.NWNX.Call();
        }

        /// @anchor util_encode_url
        /// Encodes a string for usage in a URL.
        /// <param name="str">The string to encode for a URL.</param>
        /// <returns>The url encoded string.</returns>
        public static string EncodeStringForURL(string sURL)
        {
            VM.NWNX.SetFunction(NWNX_Util, "EncodeStringForURL");
            VM.NWNX.StackPush(sURL);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// @anchor twoda_row_count
        /// Gets the row count for a 2da.
        /// <param name="str">The 2da to check (do not include the .2da).</param>
        /// <returns>The amount of rows in the 2da.</returns>
        public static int Get2DARowCount(string str)
        {
            VM.NWNX.SetFunction(NWNX_Util, "Get2DARowCount");
            VM.NWNX.StackPush(str);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Get the first resref of nType.
        /// <param name="nType">A @ref resref_types "Resref Type".</param>
        /// <param name="sRegexFilter">Lets you filter out resrefs using a regexfilter.</param>
        /// For example: **nwnx_.\*** gets you all scripts prefixed with nwnx_
        /// when using the NSS resref type.
        /// <param name="bModuleResourcesOnly">If TRUE only custom resources will be returned.</param>
        /// <returns>The first resref found or "" if none is found.</returns>
        public static string GetFirstResRef(int nType, string sRegexFilter = "", int bModuleResourcesOnly = NWScript.TRUE)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetFirstResRef");
            VM.NWNX.StackPush(bModuleResourcesOnly);
            VM.NWNX.StackPush(sRegexFilter);
            VM.NWNX.StackPush(nType);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Get the next resref.
        /// <returns>The next resref found or "" if none is found.</returns>
        public static string GetNextResRef()
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetNextResRef");
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Get the ticks per second of the server.
        /// @remark Useful to dynamically detect lag and adjust behavior accordingly.
        /// <returns>The ticks per second.</returns>
        public static int GetServerTicksPerSecond()
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetServerTicksPerSecond");
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Get the last created object.
        /// <param name="nObjectType">Does not take the NWScript OBJECT_TYPE_* constants.</param>
        /// Use NWNX_Consts_TranslateNWScriptObjectType() to get their NWNX equivalent.
        /// <param name="nNthLast">The nth last object created.</param>
        /// <returns>The last created object. On error, this returns OBJECT_INVALID.</returns>
        public static uint GetLastCreatedObject(int nObjectType, int nNthLast = 1)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetLastCreatedObject");
            VM.NWNX.StackPush(nNthLast);
            VM.NWNX.StackPush(nObjectType);
            VM.NWNX.Call();
            return VM.NWNX.StackPopObject();
        }

        /// Compiles and adds a script to the UserDirectory/nwnx folder.
        /// @note Will override existing scripts that are in the module.
        /// <param name="sFileName">The script filename without extension, 16 or less characters.</param>
        /// <param name="sScriptData">The script data to compile</param>
        /// <param name="bWrapIntoMain">Set to TRUE to wrap sScriptData into void main(){}.</param>
        /// <returns>"" on success, or the compilation error.</returns>
        public static string AddScript(string sFileName, string sScriptData, int bWrapIntoMain = NWScript.FALSE)
        {
            VM.NWNX.SetFunction(NWNX_Util, "AddScript");
            VM.NWNX.StackPush(bWrapIntoMain);
            VM.NWNX.StackPush(sScriptData);
            VM.NWNX.StackPush(sFileName);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Gets the contents of a .nss script file as a string.
        /// <param name="sScriptName">The name of the script to get the contents of.</param>
        /// <param name="nMaxLength">The max length of the return string, -1 to get everything</param>
        /// <returns>The script file contents or "" on error.</returns>
        public static string GetNSSContents(string sScriptName, int nMaxLength = -1)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetNSSContents");
            VM.NWNX.StackPush(nMaxLength);
            VM.NWNX.StackPush(sScriptName);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Adds a nss file to the UserDirectory/nwnx folder.
        /// @note Will override existing nss files that are in the module
        /// <param name="sFileName">The script filename without extension, 16 or less characters.</param>
        /// <param name="sContents">The contents of the nss file</param>
        /// <returns>TRUE on success.</returns>
        public static int AddNSSFile(string sFileName, string sContents)
        {
            VM.NWNX.SetFunction(NWNX_Util, "AddNSSFile");
            VM.NWNX.StackPush(sContents);
            VM.NWNX.StackPush(sFileName);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Remove sFileName of nType from the UserDirectory/nwnx folder.
        /// <param name="sFileName">The filename without extension, 16 or less characters.</param>
        /// <param name="nType">The @ref resref_types "Resref Type".</param>
        /// <returns>TRUE on success.</returns>
        public static int RemoveNWNXResourceFile(string sFileName, int nType)
        {
            VM.NWNX.SetFunction(NWNX_Util, "RemoveNWNXResourceFile");
            VM.NWNX.StackPush(nType);
            VM.NWNX.StackPush(sFileName);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set the NWScript instruction limit
        /// <param name="nInstructionLimit">The new limit or -1 to reset to default.</param>
        public static void SetInstructionLimit(int nInstructionLimit)
        {
            VM.NWNX.SetFunction(NWNX_Util, "SetInstructionLimit");
            VM.NWNX.StackPush(nInstructionLimit);
            VM.NWNX.Call();
        }

        /// Register a server console command that will execute a script chunk.
        /// @note Example usage: NWNX_Util_RegisterServerConsoleCommand("test", "PrintString(\"Test Command -> Args: $args\");");
        /// <param name="sCommand">The name of the command.</param>
        /// <param name="sScriptChunk">The script chunk to run. You can use $args to get the console command arguments.</param>
        /// <returns>TRUE on success.</returns>
        public static int RegisterServerConsoleCommand(string sCommand, string sScriptChunk)
        {
            VM.NWNX.SetFunction(NWNX_Util, "RegisterServerConsoleCommand");
            VM.NWNX.StackPush(sScriptChunk);
            VM.NWNX.StackPush(sCommand);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Unregister a server console command that was registered with NWNX_Util_RegisterServerConsoleCommand().
        /// <param name="sCommand">The name of the command.</param>
        public static void UnregisterServerConsoleCommand(string sCommand)
        {
            VM.NWNX.SetFunction(NWNX_Util, "UnregisterServerConsoleCommand");
            VM.NWNX.StackPush(sCommand);
            VM.NWNX.Call();
        }

        /// Determines if the given plugin exists and is enabled.
        /// <param name="sPlugin">The name of the plugin to check. This is the case sensitive plugin name as used by NWNX_CallFunction, NWNX_PushArgumentX</param>
        /// @note Example usage: NWNX_Util_PluginExists("NWNX_Creature");
        /// <returns>TRUE if the plugin exists and is enabled, otherwise FALSE.</returns>
        public static int PluginExists(string sPlugin)
        {
            VM.NWNX.SetFunction(NWNX_Util, "PluginExists");
            VM.NWNX.StackPush(sPlugin);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Gets the server's current working user folder.
        /// <returns>The absolute path of the server's home directory (-userDirectory)</returns>
        public static string GetUserDirectory()
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetUserDirectory");
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Get the return value of the last run script with a StartingConditional
        /// <returns>Return value of the last run script.</returns>
        public static int GetScriptReturnValue()
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetScriptReturnValue");
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Create a door.
        /// <param name="sResRef">The ResRef of the door.</param>
        /// <param name="locLocation">The location to create the door at.</param>
        /// <param name="sNewTag">An optional new tag for the door.</param>
        /// <returns>The door, or OBJECT_INVALID on failure.</returns>
        public static uint CreateDoor(string sResRef, System.IntPtr locLocation, string sNewTag)
        {
            VM.NWNX.SetFunction(NWNX_Util, "CreateDoor");
            System.Numerics.Vector3 vPosition = NWScript.GetPositionFromLocation(locLocation);
            VM.NWNX.StackPush(sNewTag);
            VM.NWNX.StackPush(NWScript.GetFacingFromLocation(locLocation));
            VM.NWNX.StackPush(vPosition.Z);
            VM.NWNX.StackPush(vPosition.Y);
            VM.NWNX.StackPush(vPosition.X);
            VM.NWNX.StackPush(NWScript.GetAreaFromLocation(locLocation));
            VM.NWNX.StackPush(sResRef);
            VM.NWNX.Call();
            return VM.NWNX.StackPopObject();
        }

        /// Set the object that will be returned by GetItemActivator.
        /// <param name="oObject">An object.</param>
        public static void SetItemActivator(uint oObject)
        {
            VM.NWNX.SetFunction(NWNX_Util, "SetItemActivator");
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
            VM.NWNX.SetFunction(NWNX_Util, "GetWorldTime");
            VM.NWNX.StackPush(fAdjustment);
            VM.NWNX.Call();
            WorldTime strWorldTime = default;
            strWorldTime.nTimeOfDay = VM.NWNX.StackPopInt();
            strWorldTime.nCalendarDay = VM.NWNX.StackPopInt();
            return strWorldTime;
        }

        /// Set a server-side resource override.
        /// <param name="nResType">A @ref resref_types "Resref Type".</param>
        /// <param name="sOldName">The old resource name, 16 characters or less.</param>
        /// <param name="sNewName">The new resource name or "" to clear a previous override, 16 characters or less.</param>
        public static void SetResourceOverride(int nResType, string sOldName, string sNewName)
        {
            VM.NWNX.SetFunction(NWNX_Util, "SetResourceOverride");
            VM.NWNX.StackPush(sNewName);
            VM.NWNX.StackPush(sOldName);
            VM.NWNX.StackPush(nResType);
            VM.NWNX.Call();
        }

        /// Get a server-side resource override.
        /// <param name="nResType">A @ref resref_types "Resref Type".</param>
        /// <param name="sName">The name of the resource, 16 characters or less.</param>
        /// <returns>The resource override, or "" if one is not set.</returns>
        public static string GetResourceOverride(int nResType, string sName)
        {
            VM.NWNX.SetFunction(NWNX_Util, "GetResourceOverride");
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
            VM.NWNX.SetFunction(NWNX_Util, "GetScriptParamIsSet");
            VM.NWNX.StackPush(sParamName);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// @}
    }

    public struct WorldTime
    {
        public int nCalendarDay;
        public int nTimeOfDay;
    }
}