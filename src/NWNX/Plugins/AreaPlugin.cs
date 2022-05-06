using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Area)]
  public class AreaPlugin
  {
    public const string NWNX_Area = "NWNX_Area";

    ///&lt; @private
    /// @name Area PVP Settings
    /// @anchor area_pvp
    /// @{
    public const int NWNX_AREA_PVP_SETTING_NO_PVP = 0;
    public const int NWNX_AREA_PVP_SETTING_PARTY_PVP = 1;
    public const int NWNX_AREA_PVP_SETTING_FULL_PVP = 2;
    public const int NWNX_AREA_PVP_SETTING_SERVER_DEFAULT = 3;

    // @}
    /// @name Area Weather Settings
    /// @anchor area_weather
    /// @{
    public const int NWNX_AREA_WEATHER_CHANCE_RAIN = 0;
    public const int NWNX_AREA_WEATHER_CHANCE_SNOW = 1;
    public const int NWNX_AREA_WEATHER_CHANCE_LIGHTNING = 2;

    // @}
    /// @name Area Day Night Cycle Settings
    /// @anchor area_daynight
    /// @{
    public const int NWNX_AREA_DAYNIGHTCYCLE_CYCLE_DAY_NIGHT = 0;
    public const int NWNX_AREA_DAYNIGHTCYCLE_ALWAYS_BRIGHT = 1;
    public const int NWNX_AREA_DAYNIGHTCYCLE_ALWAYS_DARK = 2;

    // @}
    /// @name Area Sun/Moon Color Settings
    /// @anchor area_color
    /// @{
    public const int NWNX_AREA_COLOR_TYPE_MOON_AMBIENT = 0;
    public const int NWNX_AREA_COLOR_TYPE_MOON_DIFFUSE = 1;
    public const int NWNX_AREA_COLOR_TYPE_SUN_AMBIENT = 2;
    public const int NWNX_AREA_COLOR_TYPE_SUN_DIFFUSE = 3;

    // @}
    /// A tile info struct
    /// Gets the number of players in area.
    /// <param name="area">The area object.</param>
    /// <returns>The player count for the area.</returns>
    public static int GetNumberOfPlayersInArea(uint area)
    {
      const string sFunc = "GetNumberOfPlayersInArea";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the creature that last entered area.
    /// <param name="area">The area object.</param>
    /// <returns>The most recent creature to enter the area.</returns>
    public static uint GetLastEntered(uint area)
    {
      const string sFunc = "GetLastEntered";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Gets the creature that last left area
    /// <param name="area">The area object.</param>
    public static uint GetLastLeft(uint area)
    {
      const string sFunc = "GetLastLeft";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Get the PVP setting of area
    /// <param name="area">The area object.</param>
    /// <returns>Returns the @ref area_pvp &quot;PVP Setting&quot; for the area.</returns>
    public static int GetPVPSetting(uint area)
    {
      const string sFunc = "GetPVPSetting";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the PVP setting of area
    /// <param name="area">The area object.</param>
    /// <param name="pvpSetting">One of @ref area_pvp the &quot;PVP Settings&quot;.</param>
    public static void SetPVPSetting(uint area, int pvpSetting)
    {
      const string sFunc = "SetPVPSetting";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(pvpSetting);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the spot modifier of area
    /// <param name="area">The area object.</param>
    /// <returns>The value of the Spot skill modifier for this area.</returns>
    public static int GetAreaSpotModifier(uint area)
    {
      const string sFunc = "GetAreaSpotModifier";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the spot modifier of area
    /// <param name="area">The area object.</param>
    /// <param name="spotModifier">The modifier to the Spot skill for this area.</param>
    /// @sa NWNX_SkillRanks_SetAreaModifier() to change any skill modifier.
    public static void SetAreaSpotModifier(uint area, int spotModifier)
    {
      const string sFunc = "SetAreaSpotModifier";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(spotModifier);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the listen modifer of area
    /// <param name="area">The area object.</param>
    /// <returns>The value of the Listen skill modifier for this area.</returns>
    public static int GetAreaListenModifier(uint area)
    {
      const string sFunc = "GetAreaListenModifier";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the listen modifier of area
    /// <param name="area">The area object.</param>
    /// <param name="listenModifier">The modifier to the Listen skill for this area.</param>
    /// @sa NWNX_SkillRanks_SetAreaModifier() to change any skill modifier.
    public static void SetAreaListenModifier(uint area, int listenModifier)
    {
      const string sFunc = "SetAreaListenModifier";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(listenModifier);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Checks the No Resting area flag
    /// <param name="area">The area object.</param>
    /// <returns>TRUE if resting is not allowed in area.</returns>
    public static int GetNoRestingAllowed(uint area)
    {
      const string sFunc = "GetNoRestingAllowed";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set whether to disable resting in the area.
    /// <param name="area">The area object.</param>
    /// <param name="bNoRestingAllowed">TRUE to disable resting in the area.</param>
    public static void SetNoRestingAllowed(uint area, int bNoRestingAllowed)
    {
      const string sFunc = "SetNoRestingAllowed";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(bNoRestingAllowed);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the wind power in area
    /// <param name="area">The area object.</param>
    /// <returns>The wind power for the area. (0-2)</returns>
    public static int GetWindPower(uint area)
    {
      const string sFunc = "GetWindPower";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the wind power in area
    /// <param name="area">The area object.</param>
    /// <param name="windPower">Set to 0, 1 or 2.</param>
    public static void SetWindPower(uint area, int windPower)
    {
      const string sFunc = "SetWindPower";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(windPower);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the weather chance of type in area
    /// <param name="type">A @ref area_weather &quot;Weather Setting&quot;.</param>
    /// <param name="area">The area object.</param>
    /// <returns>The percentage chance for the weather type. (0-100)</returns>
    public static int GetWeatherChance(uint area, int type)
    {
      const string sFunc = "GetWeatherChance";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the weather chance of type in area
    /// <param name="area">The area object.</param>
    /// <param name="type">A @ref area_weather &quot;Weather Setting&quot;.</param>
    /// <param name="chance">The chance this weather event occurs.</param>
    public static void SetWeatherChance(uint area, int type, int chance)
    {
      const string sFunc = "SetWeatherChance";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(chance);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the fog clip distance in area
    /// <param name="area">The area object.</param>
    /// <returns>The fog clip distance.</returns>
    public static float GetFogClipDistance(uint area)
    {
      const string sFunc = "GetFogClipDistance";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set the fog clip distance in area
    /// <param name="area">The area object.</param>
    /// <param name="distance">The new fog clip distance.</param>
    public static void SetFogClipDistance(uint area, float distance)
    {
      const string sFunc = "SetFogClipDistance";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(distance);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the shadow opacity of area
    /// <param name="area">The area object.</param>
    /// <returns>The shadow opacity for the area. (0-100)</returns>
    public static int GetShadowOpacity(uint area)
    {
      const string sFunc = "GetShadowOpacity";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the shadow opacity of area
    /// <param name="area">The area object.</param>
    /// <param name="shadowOpacity">The shadow opacity to set for the area (0-100).</param>
    public static void SetShadowOpacity(uint area, int shadowOpacity)
    {
      const string sFunc = "SetShadowOpacity";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(shadowOpacity);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the day/night cycle of area
    /// <param name="area">The area object.</param>
    /// <returns>The @ref area_daynight &quot;Day Night Cycle Setting&quot;.</returns>
    public static int GetDayNightCycle(uint area)
    {
      const string sFunc = "GetDayNightCycle";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the day/night cycle of area
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_daynight &quot;Day Night Cycle Setting&quot;.</param>
    public static void SetDayNightCycle(uint area, int type)
    {
      const string sFunc = "SetDayNightCycle";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the Sun/Moon Ambient/Diffuse colors of area
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_color &quot;Sun/Moon Color Setting&quot;.</param>
    /// <returns>A FOG_COLOR_* or a custom value, -1 on error.</returns>
    public static int GetSunMoonColors(uint area, int type)
    {
      const string sFunc = "GetSunMoonColors";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the Sun/Moon Ambient/Diffuse colors of area
    // type = NWNX_AREA_COLOR_TYPE_*
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_color &quot;Sun/Moon Color Setting&quot;.</param>
    /// <param name="color">= A FOG_COLOR_*.</param>
    /// @note The color can also be represented as a hex RGB number if specific color shades are desired.
    /// The format of a hex specified color would be 0xFFEEDD where
    ///  * FF would represent the amount of red in the color
    ///  * EE would represent the amount of green in the color
    ///  * DD would represent the amount of blue in the color.
    public static void SetSunMoonColors(uint area, int type, int color)
    {
      const string sFunc = "SetSunMoonColors";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(color);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Create and returns a transition (square shaped of specified size) at a location.
    /// <param name="area">The area object.</param>
    /// <param name="target">A door or waypoint object.</param>
    /// <param name="x,y,z">The position to create the transition.</param>
    /// <param name="size">The size of the square.</param>
    /// <param name="tag">If specified, the returning object will have this tag.</param>
    /// @sa NWNX_Object_SetTriggerGeometry() if you wish to draw the transition as something other than a square.
    public static uint CreateTransition(uint area, uint target, float x, float y, float z, float size = 2.0f, string tag = "")
    {
      const string sFunc = "CreateTransition";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(size);
      VM.NWNX.StackPush(z);
      VM.NWNX.StackPush(y);
      VM.NWNX.StackPush(x);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Get the state of a tile animation loop.
    /// <param name="oArea">The area object.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    /// <param name="nAnimLoop">The loop to check. (1-3)</param>
    /// <returns>TRUE if the loop is enabled.</returns>
    public static int GetTileAnimationLoop(uint oArea, float fTileX, float fTileY, int nAnimLoop)
    {
      const string sFunc = "GetTileAnimationLoop";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(nAnimLoop);
      VM.NWNX.StackPush(fTileY);
      VM.NWNX.StackPush(fTileX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the state of a tile animation loop.
    /// <param name="oArea">The area object.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    /// <param name="nAnimLoop">The loop to set (1-3).</param>
    /// <param name="bEnabled">TRUE or FALSE.</param>
    /// @note Requires clients to re-enter the area for it to take effect
    public static void SetTileAnimationLoop(uint oArea, float fTileX, float fTileY, int nAnimLoop, int bEnabled)
    {
      const string sFunc = "SetTileAnimationLoop";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(bEnabled);
      VM.NWNX.StackPush(nAnimLoop);
      VM.NWNX.StackPush(fTileY);
      VM.NWNX.StackPush(fTileX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
    }

    /// Get the name of the tile model from any location.
    /// <param name="oArea">The area name.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    public static string GetTileModelResRef(uint oArea, float fTileX, float fTileY)
    {
      const string sFunc = "GetTileModelResRef";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(fTileY);
      VM.NWNX.StackPush(fTileX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Test to see if there&apos;s a direct, walkable line between two points in the area.
    /// <param name="oArea">The area object.</param>
    /// <param name="fStartX,">fStartY The starting points.</param>
    /// <param name="fEndX,">fEndY The ending points.</param>
    /// <param name="fPerSpace">The personal space of a creature. Found in appearance.2da.</param>
    /// <param name="fHeight">The height of a creature. Found in appearance.2da.</param>
    /// <param name="bIgnoreDoors">Whether to ignore doors in the check.</param>
    /// <returns></returns>
    ///  * 1 if there is a direct walkable line.
    ///  * -1 if the line is blocked by terrain.
    ///  * -2 if the line is blocked by a placeable.
    ///  * -3 if the line is blocked by a creature.
    public static int TestDirectLine(uint oArea, float fStartX, float fStartY, float fEndX, float fEndY, float fPerSpace, float fHeight, int bIgnoreDoors = FALSE)
    {
      const string sFunc = "TestDirectLine";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(bIgnoreDoors);
      VM.NWNX.StackPush(fHeight);
      VM.NWNX.StackPush(fPerSpace);
      VM.NWNX.StackPush(fEndY);
      VM.NWNX.StackPush(fEndX);
      VM.NWNX.StackPush(fStartY);
      VM.NWNX.StackPush(fStartX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get if the area music is playing.
    /// <param name="oArea">The area object.</param>
    /// <param name="bBattleMusic">Set to TRUE to get if the battle music is playing.</param>
    /// <returns>TRUE if music is playing</returns>
    public static int GetMusicIsPlaying(uint oArea, int bBattleMusic = FALSE)
    {
      const string sFunc = "GetMusicIsPlaying";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(bBattleMusic);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Create and return a generic trigger (square shaped of specified size) at a location.
    /// <param name="oArea">The area object.</param>
    /// <param name="fX,">fY, fZ The position to create the trigger.</param>
    /// <param name="sTag">If specified, the returned trigger will have this tag.</param>
    /// <param name="fSize">The size of the square.</param>
    /// @sa NWNX_Object_SetTriggerGeometry() if you wish to draw the trigger as something other than a square.
    public static uint CreateGenericTrigger(uint oArea, float fX, float fY, float fZ, string sTag = "", float fSize = 1.0f)
    {
      const string sFunc = "CreateGenericTrigger";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(fSize);
      VM.NWNX.StackPush(sTag);
      VM.NWNX.StackPush(fZ);
      VM.NWNX.StackPush(fY);
      VM.NWNX.StackPush(fX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Add oObject to the ExportGIT exclusion list, objects on this list won&apos;t be exported when NWNX_Area_ExportGIT() is called.
    /// <param name="oObject">The object to add</param>
    public static void AddObjectToExclusionList(uint oObject)
    {
      const string sFunc = "AddObjectToExclusionList";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
    }

    /// Remove oObject from the ExportGIT exclusion list.
    /// <param name="oObject">The object to add</param>
    public static void RemoveObjectFromExclusionList(uint oObject)
    {
      const string sFunc = "RemoveObjectFromExclusionList";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
    }

    /// Export the .git file of oArea to the UserDirectory/nwnx folder, or to the location of sAlias.
    /// @note Take care with local objects set on objects, they will likely not reference the same object after a server restart.
    /// <param name="oArea">The area to export the .git file of.</param>
    /// <param name="sFileName">The filename, 16 characters or less and should be lowercase. If left blank the resref of oArea will be used.</param>
    /// <param name="bExportVarTable">If TRUE, local variables set on oArea will be exported too.</param>
    /// <param name="bExportUUID">If TRUE, the UUID of oArea will be exported, if it has one.</param>
    /// <param name="nObjectFilter">One or more OBJECT_TYPE_* constants. These object will not be exported. For example OBJECT_TYPE_CREATURE | OBJECT_TYPE_DOOR</param>
    /// will not export creatures and doors. Use OBJECT_TYPE_ALL to filter all objects or 0 to export all objects.
    /// <param name="sAlias">The alias of the resource directory to add the .git file to. Default: UserDirectory/nwnx</param>
    /// <returns>TRUE if exported successfully, FALSE if not.</returns>
    public static int ExportGIT(uint oArea, string sFileName = "", int bExportVarTable = TRUE, int bExportUUID = TRUE, int nObjectFilter = 0, string sAlias = "NWNX")
    {
      const string sFunc = "ExportGIT";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(sAlias);
      VM.NWNX.StackPush(nObjectFilter);
      VM.NWNX.StackPush(bExportUUID);
      VM.NWNX.StackPush(bExportVarTable);
      VM.NWNX.StackPush(sFileName);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the tile info of the tile at [fTileX, fTileY] in oArea.
    /// <param name="oArea">The area name.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    /// <returns>A NWNX_Area_TileInfo struct with tile info.</returns>
    public static TileInfo GetTileInfo(uint oArea, float fTileX, float fTileY)
    {
      const string sFunc = "GetTileInfo";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(fTileY);
      VM.NWNX.StackPush(fTileX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      TileInfo str = default;
      str.nGridY = VM.NWNX.StackPopInt();
      str.nGridX = VM.NWNX.StackPopInt();
      str.nOrientation = VM.NWNX.StackPopInt();
      str.nHeight = VM.NWNX.StackPopInt();
      str.nID = VM.NWNX.StackPopInt();
      return str;
    }

    /// Export the .are file of oArea to the UserDirectory/nwnx folder, or to the location of sAlias.
    /// <param name="oArea">The area to export the .are file of.</param>
    /// <param name="sFileName">The filename, 16 characters or less and should be lowercase. This will also be the resref of the area.</param>
    /// <param name="sNewName">Optional new name of the area. Leave blank to use the current name.</param>
    /// <param name="sNewTag">Optional new tag of the area. Leave blank to use the current tag.</param>
    /// <param name="sAlias">The alias of the resource directory to add the .are file to. Default: UserDirectory/nwnx</param>
    /// <returns>TRUE if exported successfully, FALSE if not.</returns>
    public static int ExportARE(uint oArea, string sFileName, string sNewName = "", string sNewTag = "", string sAlias = "NWNX")
    {
      const string sFunc = "ExportARE";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(sAlias);
      VM.NWNX.StackPush(sNewTag);
      VM.NWNX.StackPush(sNewName);
      VM.NWNX.StackPush(sFileName);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the ambient sound playing in an area during the day.
    /// <param name="oArea">The area to get the sound of.</param>
    /// <returns>The ambient soundtrack. See ambientsound.2da.</returns>
    public static int GetAmbientSoundDay(uint oArea)
    {
      const string sFunc = "GetAmbientSoundDay";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the ambient sound playing in an area during the night.
    /// <param name="oArea">The area to get the sound of.</param>
    /// <returns>The ambient soundtrack. See ambientsound.2da.</returns>
    public static int GetAmbientSoundNight(uint oArea)
    {
      const string sFunc = "GetAmbientSoundNight";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the volume of the ambient sound playing in an area during the day.
    /// <param name="oArea">The area to get the sound volume of.</param>
    /// <returns>The volume.</returns>
    public static int GetAmbientSoundDayVolume(uint oArea)
    {
      const string sFunc = "GetAmbientSoundDayVolume";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the volume of the ambient sound playing in an area during the night.
    /// <param name="oArea">The area to get the sound volume of.</param>
    /// <returns>The volume.</returns>
    public static int GetAmbientSoundNightVolume(uint oArea)
    {
      const string sFunc = "GetAmbientSoundNightVolume";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Create a sound object.
    /// <param name="oArea">The area where to create the sound object.</param>
    /// <param name="vPosition">The area position where to create the sound object.</param>
    /// <param name="sResRef">The ResRef of the sound object.</param>
    /// <returns>The sound object.</returns>
    public static uint CreateSoundObject(uint oArea, System.Numerics.Vector3 vPosition, string sResRef)
    {
      const string sFunc = "CreateSoundObject";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(sResRef);
      VM.NWNX.StackPush(vPosition.Z);
      VM.NWNX.StackPush(vPosition.Y);
      VM.NWNX.StackPush(vPosition.X);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Rotates an existing area, including all objects within (excluding PCs).
    /// @note Functions while clients are in the area, but not recommended as tiles/walkmesh only updates on area load, and this may result in unexpected clientside results.
    /// <param name="oArea">The area to be rotated</param>
    /// <param name="nRotation">How many 90 degrees clockwise to rotate (1-3).</param>
    public static void RotateArea(uint oArea, int nRotation)
    {
      const string sFunc = "RotateArea";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(nRotation);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
    }

    /// Get the tile info of the tile at nIndex in the tile array.
    /// <param name="oArea">The area.</param>
    /// <param name="nIndex">The index of the tile.</param>
    /// <returns>A NWNX_Area_TileInfo struct with tile info.</returns>
    public static TileInfo GetTileInfoByTileIndex(uint oArea, int nIndex)
    {
      const string sFunc = "GetTileInfoByTileIndex";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      TileInfo str = default;
      str.nGridY = VM.NWNX.StackPopInt();
      str.nGridX = VM.NWNX.StackPopInt();
      str.nOrientation = VM.NWNX.StackPopInt();
      str.nHeight = VM.NWNX.StackPopInt();
      str.nID = VM.NWNX.StackPopInt();
      return str;
    }

    /// Check if there is a path between two positions in an area.
    /// @note Does not care about doors or placeables, only checks tile path nodes.
    /// <param name="oArea">The area.</param>
    /// <param name="vStartPosition">The start position.</param>
    /// <param name="vEndPosition">The end position.</param>
    /// <param name="nMaxDepth">The max depth of the DFS tree. A good value is AreaWidth * AreaHeight.</param>
    /// <returns>TRUE if there is a path between vStartPosition and vEndPosition, FALSE if not or on error.</returns>
    public static int GetPathExists(uint oArea, System.Numerics.Vector3 vStartPosition, System.Numerics.Vector3 vEndPosition, int nMaxDepth)
    {
      const string sFunc = "GetPathExists";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(nMaxDepth);
      VM.NWNX.StackPush(vEndPosition.Y);
      VM.NWNX.StackPush(vEndPosition.X);
      VM.NWNX.StackPush(vStartPosition.Y);
      VM.NWNX.StackPush(vStartPosition.X);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get oArea&apos;s flags, interior/underground etc.
    /// <param name="oArea">The area.</param>
    /// <returns>The raw flags bitmask or -1 on error.</returns>
    public static int GetAreaFlags(uint oArea)
    {
      const string sFunc = "GetAreaFlags";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set oArea&apos;s raw flags bitmask.
    /// @note You&apos;ll have to do any bitwise operations yourself.
    /// @note Requires clients to reload the area to get any updated flags.
    /// <param name="oArea">The area.</param>
    /// <param name="nFlags">The flags.</param>
    public static void SetAreaFlags(uint oArea, int nFlags)
    {
      const string sFunc = "SetAreaFlags";
      VM.NWNX.SetFunction(NWNX_Area, sFunc);
      VM.NWNX.StackPush(nFlags);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
    }

    // @}
  }

  public struct TileInfo
  {
    public int nID;
    public int nHeight;
    public int nOrientation;
    public int nGridX;
    public int nGridY;
  }
}
