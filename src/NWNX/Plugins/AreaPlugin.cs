namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Area)]
  public class AreaPlugin
  {
    public const string NWNX_Area = "NWNX_Area";

    ///< @private
    /// @name Area PVP Settings
    /// @anchor area_pvp
    /// @{
    public const int NWNX_AREA_PVP_SETTING_NO_PVP = 0;
    public const int NWNX_AREA_PVP_SETTING_PARTY_PVP = 1;
    public const int NWNX_AREA_PVP_SETTING_FULL_PVP = 2;
    public const int NWNX_AREA_PVP_SETTING_SERVER_DEFAULT = 3;

    /// @}
    /// @name Area Weather Settings
    /// @anchor area_weather
    /// @{
    public const int NWNX_AREA_WEATHER_CHANCE_RAIN = 0;
    public const int NWNX_AREA_WEATHER_CHANCE_SNOW = 1;
    public const int NWNX_AREA_WEATHER_CHANCE_LIGHTNING = 2;

    /// @}
    /// @name Area Day Night Cycle Settings
    /// @anchor area_daynight
    /// @{
    public const int NWNX_AREA_DAYNIGHTCYCLE_CYCLE_DAY_NIGHT = 0;
    public const int NWNX_AREA_DAYNIGHTCYCLE_ALWAYS_BRIGHT = 1;
    public const int NWNX_AREA_DAYNIGHTCYCLE_ALWAYS_DARK = 2;

    /// @}
    /// @name Area Sun/Moon Color Settings
    /// @anchor area_color
    /// @{
    public const int NWNX_AREA_COLOR_TYPE_MOON_AMBIENT = 0;
    public const int NWNX_AREA_COLOR_TYPE_MOON_DIFFUSE = 1;
    public const int NWNX_AREA_COLOR_TYPE_SUN_AMBIENT = 2;
    public const int NWNX_AREA_COLOR_TYPE_SUN_DIFFUSE = 3;

    /// @}
    /// A tile info struct
    /// Gets the number of players in area.
    /// <param name="area">The area object.</param>
    /// <returns>The player count for the area.</returns>
    public static int GetNumberOfPlayersInArea(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetNumberOfPlayersInArea");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the creature that last entered area.
    /// <param name="area">The area object.</param>
    /// <returns>The most recent creature to enter the area.</returns>
    public static uint GetLastEntered(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetLastEntered");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Gets the creature that last left area
    /// <param name="area">The area object.</param>
    public static uint GetLastLeft(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetLastLeft");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Get the PVP setting of area
    /// <param name="area">The area object.</param>
    /// <returns>Returns the @ref area_pvp "PVP Setting" for the area.</returns>
    public static int GetPVPSetting(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetPVPSetting");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the PVP setting of area
    /// <param name="area">The area object.</param>
    /// <param name="pvpSetting">One of @ref area_pvp the "PVP Settings".</param>
    public static void SetPVPSetting(uint area, int pvpSetting)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetPVPSetting");
      VM.NWNX.StackPush(pvpSetting);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the spot modifier of area
    /// <param name="area">The area object.</param>
    /// <returns>The value of the Spot skill modifier for this area.</returns>
    public static int GetAreaSpotModifier(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetAreaSpotModifier");
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
      VM.NWNX.SetFunction(NWNX_Area, "SetAreaSpotModifier");
      VM.NWNX.StackPush(spotModifier);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the listen modifer of area
    /// <param name="area">The area object.</param>
    /// <returns>The value of the Listen skill modifier for this area.</returns>
    public static int GetAreaListenModifier(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetAreaListenModifier");
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
      VM.NWNX.SetFunction(NWNX_Area, "SetAreaListenModifier");
      VM.NWNX.StackPush(listenModifier);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Checks the No Resting area flag
    /// <param name="area">The area object.</param>
    /// <returns>TRUE if resting is not allowed in area.</returns>
    public static int GetNoRestingAllowed(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetNoRestingAllowed");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set whether to disable resting in the area.
    /// <param name="area">The area object.</param>
    /// <param name="bNoRestingAllowed">TRUE to disable resting in the area.</param>
    public static void SetNoRestingAllowed(uint area, int bNoRestingAllowed)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetNoRestingAllowed");
      VM.NWNX.StackPush(bNoRestingAllowed);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the wind power in area
    /// <param name="area">The area object.</param>
    /// <returns>The wind power for the area. (0-2)</returns>
    public static int GetWindPower(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetWindPower");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the wind power in area
    /// <param name="area">The area object.</param>
    /// <param name="windPower">Set to 0, 1 or 2.</param>
    public static void SetWindPower(uint area, int windPower)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetWindPower");
      VM.NWNX.StackPush(windPower);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the weather chance of type in area
    /// <param name="type">A @ref area_weather "Weather Setting".</param>
    /// <param name="area">The area object.</param>
    /// <returns>The percentage chance for the weather type. (0-100)</returns>
    public static int GetWeatherChance(uint area, int type)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetWeatherChance");
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the weather chance of type in area
    /// <param name="area">The area object.</param>
    /// <param name="type">A @ref area_weather "Weather Setting".</param>
    /// <param name="chance">The chance this weather event occurs.</param>
    public static void SetWeatherChance(uint area, int type, int chance)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetWeatherChance");
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
      VM.NWNX.SetFunction(NWNX_Area, "GetFogClipDistance");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set the fog clip distance in area
    /// <param name="area">The area object.</param>
    /// <param name="distance">The new fog clip distance.</param>
    public static void SetFogClipDistance(uint area, float distance)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetFogClipDistance");
      VM.NWNX.StackPush(distance);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the shadow opacity of area
    /// <param name="area">The area object.</param>
    /// <returns>The shadow opacity for the area. (0-100)</returns>
    public static int GetShadowOpacity(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetShadowOpacity");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the shadow opacity of area
    /// <param name="area">The area object.</param>
    /// <param name="shadowOpacity">The shadow opacity to set for the area (0-100).</param>
    public static void SetShadowOpacity(uint area, int shadowOpacity)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetShadowOpacity");
      VM.NWNX.StackPush(shadowOpacity);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the day/night cycle of area
    /// <param name="area">The area object.</param>
    /// <returns>The @ref area_daynight "Day Night Cycle Setting".</returns>
    public static int GetDayNightCycle(uint area)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetDayNightCycle");
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the day/night cycle of area
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_daynight "Day Night Cycle Setting".</param>
    public static void SetDayNightCycle(uint area, int type)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetDayNightCycle");
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
    }

    /// Get the Sun/Moon Ambient/Diffuse colors of area
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_color "Sun/Moon Color Setting".</param>
    /// <returns>A FOG_COLOR_* or a custom value, -1 on error.</returns>
    public static int GetSunMoonColors(uint area, int type)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetSunMoonColors");
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(area);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the Sun/Moon Ambient/Diffuse colors of area
    // type = NWNX_AREA_COLOR_TYPE_*
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_color "Sun/Moon Color Setting".</param>
    /// <param name="color">= A FOG_COLOR_*.</param>
    /// @note The color can also be represented as a hex RGB number if specific color shades are desired.
    /// The format of a hex specified color would be 0xFFEEDD where
    ///  * FF would represent the amount of red in the color
    ///  * EE would represent the amount of green in the color
    ///  * DD would represent the amount of blue in the color.
    public static void SetSunMoonColors(uint area, int type, int color)
    {
      VM.NWNX.SetFunction(NWNX_Area, "SetSunMoonColors");
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
      VM.NWNX.SetFunction(NWNX_Area, "CreateTransition");
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
      VM.NWNX.SetFunction(NWNX_Area, "GetTileAnimationLoop");
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
      VM.NWNX.SetFunction(NWNX_Area, "SetTileAnimationLoop");
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
      VM.NWNX.SetFunction(NWNX_Area, "GetTileModelResRef");
      VM.NWNX.StackPush(fTileY);
      VM.NWNX.StackPush(fTileX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Test to see if there's a direct, walkable line between two points in the area.
    /// <param name="oArea">The area object.</param>
    /// <param name="fStartX,">fStartY The starting points.</param>
    /// <param name="fEndX,">fEndY The ending points.</param>
    /// <param name="fPerSpace">The personal space of a creature. Found in appearance.2da.</param>
    /// <param name="fHeight">The height of a creature. Found in appearance.2da.</param>
    /// <param name="bIgnoreDoors">Whether to ignore doors in the check.</param>
    /// @return</returns>
    ///  * 1 if there is a direct walkable line.
    ///  * -1 if the line is blocked by terrain.
    ///  * -2 if the line is blocked by a placeable.
    ///  * -3 if the line is blocked by a creature.
    public static int TestDirectLine(uint oArea, float fStartX, float fStartY, float fEndX, float fEndY, float fPerSpace, float fHeight, int bIgnoreDoors = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Area, "TestDirectLine");
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
    public static int GetMusicIsPlaying(uint oArea, int bBattleMusic = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Area, "GetMusicIsPlaying");
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
      VM.NWNX.SetFunction(NWNX_Area, "CreateGenericTrigger");
      VM.NWNX.StackPush(fSize);
      VM.NWNX.StackPush(sTag);
      VM.NWNX.StackPush(fZ);
      VM.NWNX.StackPush(fY);
      VM.NWNX.StackPush(fX);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Add oObject to the ExportGIT exclusion list, objects on this list won't be exported when NWNX_Area_ExportGIT() is called.
    /// <param name="oObject">The object to add</param>
    public static void AddObjectToExclusionList(uint oObject)
    {
      VM.NWNX.SetFunction(NWNX_Area, "AddObjectToExclusionList");
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
    }

    /// Remove oObject from the ExportGIT exclusion list.
    /// <param name="oObject">The object to add</param>
    public static void RemoveObjectFromExclusionList(uint oObject)
    {
      VM.NWNX.SetFunction(NWNX_Area, "RemoveObjectFromExclusionList");
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
    public static int ExportGIT(uint oArea, string sFileName = "", int bExportVarTable = NWScript.TRUE, int bExportUUID = NWScript.TRUE, int nObjectFilter = 0, string sAlias = "NWNX")
    {
      VM.NWNX.SetFunction(NWNX_Area, "ExportGIT");
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
      VM.NWNX.SetFunction(NWNX_Area, "GetTileInfo");
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
      VM.NWNX.SetFunction(NWNX_Area, "ExportARE");
      VM.NWNX.StackPush(sAlias);
      VM.NWNX.StackPush(sNewTag);
      VM.NWNX.StackPush(sNewName);
      VM.NWNX.StackPush(sFileName);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// @}
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
