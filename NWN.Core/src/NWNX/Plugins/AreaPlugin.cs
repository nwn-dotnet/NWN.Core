using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Area)]
  public class AreaPlugin
  {
    /// @addtogroup area Area
    /// Functions exposing additional area properties as well as creating transitions.
    /// @{
    /// @file nwnx_area.nss
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
    /// Area wind info struct
    /// Gets the number of players in area.
    /// <param name="area">The area object.</param>
    /// <returns>The player count for the area.</returns>
    public static int GetNumberOfPlayersInArea(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetNumberOfPlayersInArea");
      return NWNXPopInt();
    }

    /// Gets the creature that last entered area.
    /// <param name="area">The area object.</param>
    /// <returns>The most recent creature to enter the area.</returns>
    public static uint GetLastEntered(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetLastEntered");
      return NWNXPopObject();
    }

    /// Gets the creature that last left area
    /// <param name="area">The area object.</param>
    public static uint GetLastLeft(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetLastLeft");
      return NWNXPopObject();
    }

    /// Get the PVP setting of area
    /// <param name="area">The area object.</param>
    /// <returns>Returns the @ref area_pvp &quot;PVP Setting&quot; for the area.</returns>
    public static int GetPVPSetting(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetPVPSetting");
      return NWNXPopInt();
    }

    /// Set the PVP setting of area
    /// <param name="area">The area object.</param>
    /// <param name="pvpSetting">One of @ref area_pvp the &quot;PVP Settings&quot;.</param>
    public static void SetPVPSetting(uint area, int pvpSetting)
    {
      NWNXPushInt(pvpSetting);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetPVPSetting");
    }

    /// Get the spot modifier of area
    /// <param name="area">The area object.</param>
    /// <returns>The value of the Spot skill modifier for this area.</returns>
    public static int GetAreaSpotModifier(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetAreaSpotModifier");
      return NWNXPopInt();
    }

    /// Set the spot modifier of area
    /// <param name="area">The area object.</param>
    /// <param name="spotModifier">The modifier to the Spot skill for this area.</param>
    /// @sa NWNX_SkillRanks_SetAreaModifier() to change any skill modifier.
    public static void SetAreaSpotModifier(uint area, int spotModifier)
    {
      NWNXPushInt(spotModifier);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetAreaSpotModifier");
    }

    /// Get the listen modifer of area
    /// <param name="area">The area object.</param>
    /// <returns>The value of the Listen skill modifier for this area.</returns>
    public static int GetAreaListenModifier(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetAreaListenModifier");
      return NWNXPopInt();
    }

    /// Set the listen modifier of area
    /// <param name="area">The area object.</param>
    /// <param name="listenModifier">The modifier to the Listen skill for this area.</param>
    /// @sa NWNX_SkillRanks_SetAreaModifier() to change any skill modifier.
    public static void SetAreaListenModifier(uint area, int listenModifier)
    {
      NWNXPushInt(listenModifier);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetAreaListenModifier");
    }

    /// Checks the No Resting area flag
    /// <param name="area">The area object.</param>
    /// <returns>TRUE if resting is not allowed in area.</returns>
    public static int GetNoRestingAllowed(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetNoRestingAllowed");
      return NWNXPopInt();
    }

    /// Set whether to disable resting in the area.
    /// <param name="area">The area object.</param>
    /// <param name="bNoRestingAllowed">TRUE to disable resting in the area.</param>
    public static void SetNoRestingAllowed(uint area, int bNoRestingAllowed)
    {
      NWNXPushInt(bNoRestingAllowed);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetNoRestingAllowed");
    }

    /// Get the wind power in area
    /// <param name="area">The area object.</param>
    /// <returns>The wind power for the area. (0-2)</returns>
    public static int GetWindPower(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetWindPower");
      return NWNXPopInt();
    }

    /// Set the wind power in area
    /// <param name="area">The area object.</param>
    /// <param name="windPower">Set to 0, 1 or 2.</param>
    public static void SetWindPower(uint area, int windPower)
    {
      NWNXPushInt(windPower);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetWindPower");
    }

    /// Get the weather chance of type in area
    /// <param name="type">A @ref area_weather &quot;Weather Setting&quot;.</param>
    /// <param name="area">The area object.</param>
    /// <returns>The percentage chance for the weather type. (0-100)</returns>
    public static int GetWeatherChance(uint area, int type)
    {
      NWNXPushInt(type);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetWeatherChance");
      return NWNXPopInt();
    }

    /// Set the weather chance of type in area
    /// <param name="area">The area object.</param>
    /// <param name="type">A @ref area_weather &quot;Weather Setting&quot;.</param>
    /// <param name="chance">The chance this weather event occurs.</param>
    public static void SetWeatherChance(uint area, int type, int chance)
    {
      NWNXPushInt(chance);
      NWNXPushInt(type);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetWeatherChance");
    }

    /// Get the fog clip distance in area
    /// <param name="area">The area object.</param>
    /// <returns>The fog clip distance.</returns>
    public static float GetFogClipDistance(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetFogClipDistance");
      return NWNXPopFloat();
    }

    /// Set the fog clip distance in area
    /// <param name="area">The area object.</param>
    /// <param name="distance">The new fog clip distance.</param>
    public static void SetFogClipDistance(uint area, float distance)
    {
      NWNXPushFloat(distance);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetFogClipDistance");
    }

    /// Get the shadow opacity of area
    /// <param name="area">The area object.</param>
    /// <returns>The shadow opacity for the area. (0-100)</returns>
    public static int GetShadowOpacity(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetShadowOpacity");
      return NWNXPopInt();
    }

    /// Set the shadow opacity of area
    /// <param name="area">The area object.</param>
    /// <param name="shadowOpacity">The shadow opacity to set for the area (0-100).</param>
    public static void SetShadowOpacity(uint area, int shadowOpacity)
    {
      NWNXPushInt(shadowOpacity);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetShadowOpacity");
    }

    /// Get the day/night cycle of area
    /// <param name="area">The area object.</param>
    /// <returns>The @ref area_daynight &quot;Day Night Cycle Setting&quot;.</returns>
    public static int GetDayNightCycle(uint area)
    {
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetDayNightCycle");
      return NWNXPopInt();
    }

    /// Set the day/night cycle of area
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_daynight &quot;Day Night Cycle Setting&quot;.</param>
    public static void SetDayNightCycle(uint area, int type)
    {
      NWNXPushInt(type);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetDayNightCycle");
    }

    /// Get the Sun/Moon Ambient/Diffuse colors of area
    /// <param name="area">The area object.</param>
    /// <param name="type">= A @ref area_color &quot;Sun/Moon Color Setting&quot;.</param>
    /// <returns>A FOG_COLOR_* or a custom value, -1 on error.</returns>
    public static int GetSunMoonColors(uint area, int type)
    {
      NWNXPushInt(type);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "GetSunMoonColors");
      return NWNXPopInt();
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
      NWNXPushInt(color);
      NWNXPushInt(type);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "SetSunMoonColors");
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
      NWNXPushString(tag);
      NWNXPushFloat(size);
      NWNXPushFloat(z);
      NWNXPushFloat(y);
      NWNXPushFloat(x);
      NWNXPushObject(target);
      NWNXPushObject(area);
      NWNXCall(NWNX_Area, "CreateTransition");
      return NWNXPopObject();
    }

    /// Get the state of a tile animation loop.
    /// <param name="oArea">The area object.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    /// <param name="nAnimLoop">The loop to check. (1-3)</param>
    /// <returns>TRUE if the loop is enabled.</returns>
    public static int GetTileAnimationLoop(uint oArea, float fTileX, float fTileY, int nAnimLoop)
    {
      NWNXPushInt(nAnimLoop);
      NWNXPushFloat(fTileY);
      NWNXPushFloat(fTileX);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetTileAnimationLoop");
      return NWNXPopInt();
    }

    /// Set the state of a tile animation loop.
    /// <param name="oArea">The area object.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    /// <param name="nAnimLoop">The loop to set (1-3).</param>
    /// <param name="bEnabled">TRUE or FALSE.</param>
    /// @note Requires clients to re-enter the area for it to take effect
    public static void SetTileAnimationLoop(uint oArea, float fTileX, float fTileY, int nAnimLoop, int bEnabled)
    {
      NWNXPushInt(bEnabled);
      NWNXPushInt(nAnimLoop);
      NWNXPushFloat(fTileY);
      NWNXPushFloat(fTileX);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "SetTileAnimationLoop");
    }

    /// Get the name of the tile model from any location.
    /// <param name="oArea">The area name.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    public static string GetTileModelResRef(uint oArea, float fTileX, float fTileY)
    {
      NWNXPushFloat(fTileY);
      NWNXPushFloat(fTileX);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetTileModelResRef");
      return NWNXPopString();
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
      NWNXPushInt(bIgnoreDoors);
      NWNXPushFloat(fHeight);
      NWNXPushFloat(fPerSpace);
      NWNXPushFloat(fEndY);
      NWNXPushFloat(fEndX);
      NWNXPushFloat(fStartY);
      NWNXPushFloat(fStartX);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "TestDirectLine");
      return NWNXPopInt();
    }

    /// Get if the area music is playing.
    /// <param name="oArea">The area object.</param>
    /// <param name="bBattleMusic">Set to TRUE to get if the battle music is playing.</param>
    /// <returns>TRUE if music is playing</returns>
    public static int GetMusicIsPlaying(uint oArea, int bBattleMusic = FALSE)
    {
      NWNXPushInt(bBattleMusic);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetMusicIsPlaying");
      return NWNXPopInt();
    }

    /// Create and return a generic trigger (square shaped of specified size) at a location.
    /// <param name="oArea">The area object.</param>
    /// <param name="fX,">fY, fZ The position to create the trigger.</param>
    /// <param name="sTag">If specified, the returned trigger will have this tag.</param>
    /// <param name="fSize">The size of the square.</param>
    /// @sa NWNX_Object_SetTriggerGeometry() if you wish to draw the trigger as something other than a square.
    public static uint CreateGenericTrigger(uint oArea, float fX, float fY, float fZ, string sTag = "", float fSize = 1.0f)
    {
      NWNXPushFloat(fSize);
      NWNXPushString(sTag);
      NWNXPushFloat(fZ);
      NWNXPushFloat(fY);
      NWNXPushFloat(fX);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "CreateGenericTrigger");
      return NWNXPopObject();
    }

    /// Add oObject to the ExportGIT exclusion list, objects on this list won&apos;t be exported when NWNX_Area_ExportGIT() is called.
    /// <param name="oObject">The object to add</param>
    public static void AddObjectToExclusionList(uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Area, "AddObjectToExclusionList");
    }

    /// Remove oObject from the ExportGIT exclusion list.
    /// <param name="oObject">The object to add</param>
    public static void RemoveObjectFromExclusionList(uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Area, "RemoveObjectFromExclusionList");
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
      NWNXPushString(sAlias);
      NWNXPushInt(nObjectFilter);
      NWNXPushInt(bExportUUID);
      NWNXPushInt(bExportVarTable);
      NWNXPushString(sFileName);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "ExportGIT");
      return NWNXPopInt();
    }

    /// Get the tile info of the tile at [fTileX, fTileY] in oArea.
    /// <param name="oArea">The area name.</param>
    /// <param name="fTileX,">fTileY The coordinates of the tile.</param>
    /// <returns>A NWNX_Area_TileInfo struct with tile info.</returns>
    public static TileInfo GetTileInfo(uint oArea, float fTileX, float fTileY)
    {
      NWNXPushFloat(fTileY);
      NWNXPushFloat(fTileX);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetTileInfo");
      TileInfo str = default;
      str.nGridY = NWNXPopInt();
      str.nGridX = NWNXPopInt();
      str.nOrientation = NWNXPopInt();
      str.nHeight = NWNXPopInt();
      str.nID = NWNXPopInt();
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
      NWNXPushString(sAlias);
      NWNXPushString(sNewTag);
      NWNXPushString(sNewName);
      NWNXPushString(sFileName);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "ExportARE");
      return NWNXPopInt();
    }

    /// Get the ambient sound playing in an area during the day.
    /// <param name="oArea">The area to get the sound of.</param>
    /// <returns>The ambient soundtrack. See ambientsound.2da.</returns>
    public static int GetAmbientSoundDay(uint oArea)
    {
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetAmbientSoundDay");
      return NWNXPopInt();
    }

    /// Get the ambient sound playing in an area during the night.
    /// <param name="oArea">The area to get the sound of.</param>
    /// <returns>The ambient soundtrack. See ambientsound.2da.</returns>
    public static int GetAmbientSoundNight(uint oArea)
    {
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetAmbientSoundNight");
      return NWNXPopInt();
    }

    /// Get the volume of the ambient sound playing in an area during the day.
    /// <param name="oArea">The area to get the sound volume of.</param>
    /// <returns>The volume.</returns>
    public static int GetAmbientSoundDayVolume(uint oArea)
    {
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetAmbientSoundDayVolume");
      return NWNXPopInt();
    }

    /// Get the volume of the ambient sound playing in an area during the night.
    /// <param name="oArea">The area to get the sound volume of.</param>
    /// <returns>The volume.</returns>
    public static int GetAmbientSoundNightVolume(uint oArea)
    {
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetAmbientSoundNightVolume");
      return NWNXPopInt();
    }

    /// Create a sound object.
    /// <param name="oArea">The area where to create the sound object.</param>
    /// <param name="vPosition">The area position where to create the sound object.</param>
    /// <param name="sResRef">The ResRef of the sound object.</param>
    /// <returns>The sound object.</returns>
    public static uint CreateSoundObject(uint oArea, System.Numerics.Vector3 vPosition, string sResRef)
    {
      NWNXPushString(sResRef);
      NWNXPushVector(vPosition);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "CreateSoundObject");
      return NWNXPopObject();
    }

    /// Rotates an existing area, including all objects within (excluding PCs).
    /// @note Functions while clients are in the area, but not recommended as tiles/walkmesh only updates on area load, and this may result in unexpected clientside results.
    /// <param name="oArea">The area to be rotated</param>
    /// <param name="nRotation">How many 90 degrees clockwise to rotate (1-3).</param>
    public static void RotateArea(uint oArea, int nRotation)
    {
      NWNXPushInt(nRotation);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "RotateArea");
    }

    /// Get the tile info of the tile at nIndex in the tile array.
    /// <param name="oArea">The area.</param>
    /// <param name="nIndex">The index of the tile.</param>
    /// <returns>A NWNX_Area_TileInfo struct with tile info.</returns>
    public static TileInfo GetTileInfoByTileIndex(uint oArea, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetTileInfoByTileIndex");
      TileInfo str = default;
      str.nGridY = NWNXPopInt();
      str.nGridX = NWNXPopInt();
      str.nOrientation = NWNXPopInt();
      str.nHeight = NWNXPopInt();
      str.nID = NWNXPopInt();
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
      NWNXPushInt(nMaxDepth);
      NWNXPushVector(vEndPosition);
      NWNXPushVector(vStartPosition);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetPathExists");
      return NWNXPopInt();
    }

    /// Get oArea&apos;s flags, interior/underground etc.
    /// <param name="oArea">The area.</param>
    /// <returns>The raw flags bitmask or -1 on error.</returns>
    public static int GetAreaFlags(uint oArea)
    {
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetAreaFlags");
      return NWNXPopInt();
    }

    /// Set oArea&apos;s raw flags bitmask.
    /// @note You&apos;ll have to do any bitwise operations yourself.
    /// @note Requires clients to reload the area to get any updated flags.
    /// <param name="oArea">The area.</param>
    /// <param name="nFlags">The flags.</param>
    public static void SetAreaFlags(uint oArea, int nFlags)
    {
      NWNXPushInt(nFlags);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "SetAreaFlags");
    }

    /// Get oArea&apos;s detailed win data.
    /// @note vDirection returns [0.0, 0.0, 0.0] if not set previously with SetAreaWind nwscript function.
    /// <param name="oArea">The area.</param>
    public static AreaWind GetAreaWind(uint oArea)
    {
      AreaWind data = default;
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "GetAreaWind");
      data.fPitch = NWNXPopFloat();
      data.fYaw = NWNXPopFloat();
      data.fMagnitude = NWNXPopFloat();
      data.vDirection = NWNXPopVector();
      return data;
    }

    /// Set the default discoverability mask for objects in an area.
    /// <param name="oArea">The area or OBJECT_INVALID to set a global mask for all areas. Per area masks will override the global mask.</param>
    /// <param name="nObjectTypes">A mask of OBJECT_TYPE_* constants or OBJECT_TYPE_ALL for all suitable object types. Currently only works on Creatures, Doors (Hilite only), Items and Useable Placeables.</param>
    /// <param name="nMask">A mask of OBJECT_UI_DISCOVERY_*</param>
    /// <param name="bForceUpdate">If TRUE, will update the discovery mask of ALL objects in the area or module(if oArea == OBJECT_INVALID), according to the current mask. Use with care.</param>
    public static void SetDefaultObjectUiDiscoveryMask(uint oArea, int nObjectTypes, int nMask, int bForceUpdate = FALSE)
    {
      NWNXPushInt(bForceUpdate);
      NWNXPushInt(nMask);
      NWNXPushInt(nObjectTypes);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_Area, "SetDefaultObjectUiDiscoveryMask");
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

  public struct AreaWind
  {
    public System.Numerics.Vector3 vDirection;
    public float fMagnitude;
    public float fYaw;
    public float fPitch;
  }
}
