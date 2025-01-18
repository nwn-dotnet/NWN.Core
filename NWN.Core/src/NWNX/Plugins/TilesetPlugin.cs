using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Tileset)]
  public class TilesetPlugin
  {
    /// @addtogroup tileset Tileset
    /// An advanced plugin that exposes additional tileset and tile properties and allows builders to override the tiles of an area created with CreateArea().
    /// @{
    /// @file nwnx_tileset.nss
    public const string NWNX_Tileset = "NWNX_Tileset";

    ///&lt; @private
    /// A structure containing general tileset data.
    /// A structure containing the group data for a tileset.
    /// A structure containing the edge and corner types of a tile.
    /// A structure containing the door data for a tile.
    /// A structure containing custom tile data,
    /// Get general data of sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <returns>A NWNX_Tileset_TilesetData struct.</returns>
    public static TilesetData GetTilesetData(string sTileset)
    {
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTilesetData");
      TilesetData str = default;
      str.bHasHeightTransition = NWNXPopInt();
      str.bInterior = NWNXPopInt();
      str.sUnlocalizedName = NWNXPopString();
      str.nDisplayNameStrRef = NWNXPopInt();
      str.sFloorTerrain = NWNXPopString();
      str.sDefaultTerrain = NWNXPopString();
      str.sBorderTerrain = NWNXPopString();
      str.nNumGroups = NWNXPopInt();
      str.nNumCrossers = NWNXPopInt();
      str.nNumTerrain = NWNXPopInt();
      str.fHeightTransition = NWNXPopFloat();
      str.nNumTileData = NWNXPopInt();
      return str;
    }

    /// Get the name of sTileset&apos;s terrain at nIndex.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nIndex">The index of the terrain. Range: NWNX_Tileset_TilesetData.nNumTerrain &gt; nIndex &gt;= 0</param>
    /// <returns>The terrain name or &quot;&quot; on error.</returns>
    public static string GetTilesetTerrain(string sTileset, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTilesetTerrain");
      return NWNXPopString();
    }

    /// Get the name of sTileset&apos;s crosser at nIndex.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nIndex">The index of the crosser. Range: NWNX_Tileset_TilesetData.nNumCrossers &gt; nIndex &gt;= 0</param>
    /// <returns>The crosser name or &quot;&quot; on error.</returns>
    public static string GetTilesetCrosser(string sTileset, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTilesetCrosser");
      return NWNXPopString();
    }

    /// Get general data of the group at nIndex in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nIndex">The index of the group. Range: NWNX_Tileset_TilesetData.nNumGroups &gt; nIndex &gt;= 0</param>
    /// <returns>A NWNX_Tileset_TilesetGroupData struct.</returns>
    public static TilesetGroupData GetTilesetGroupData(string sTileset, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTilesetGroupData");
      TilesetGroupData str = default;
      str.nColumns = NWNXPopInt();
      str.nRows = NWNXPopInt();
      str.nStrRef = NWNXPopInt();
      str.sName = NWNXPopString();
      return str;
    }

    /// Get the tile ID at nTileIndex in nGroupIndex of sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nGroupIndex">The index of the group. Range: NWNX_Tileset_TilesetData.nNumGroups &gt; nGroupIndex &gt;= 0</param>
    /// <param name="nTileIndex">The index of the tile. Range: (NWNX_Tileset_TilesetGroupData.nRows * NWNX_Tileset_TilesetGroupData.nColumns) &gt; nTileIndex &gt;= 0</param>
    /// <returns>The tile ID or 0 on error.</returns>
    public static int GetTilesetGroupTile(string sTileset, int nGroupIndex, int nTileIndex)
    {
      NWNXPushInt(nTileIndex);
      NWNXPushInt(nGroupIndex);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTilesetGroupTile");
      return NWNXPopInt();
    }

    /// Get the model name of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>The model name or &quot;&quot; on error.</returns>
    public static string GetTileModel(string sTileset, int nTileID)
    {
      NWNXPushInt(nTileID);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTileModel");
      return NWNXPopString();
    }

    /// Get the minimap texture name of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>The minimap texture name or &quot;&quot; on error.</returns>
    public static string GetTileMinimapTexture(string sTileset, int nTileID)
    {
      NWNXPushInt(nTileID);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTileMinimapTexture");
      return NWNXPopString();
    }

    /// Get the edges and corners of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>A NWNX_Tileset_TileEdgesAndCorners struct.</returns>
    public static TileEdgesAndCorners GetTileEdgesAndCorners(string sTileset, int nTileID)
    {
      NWNXPushInt(nTileID);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTileEdgesAndCorners");
      TileEdgesAndCorners str = default;
      str.sLeft = NWNXPopString();
      str.sBottomLeft = NWNXPopString();
      str.sBottom = NWNXPopString();
      str.sBottomRight = NWNXPopString();
      str.sRight = NWNXPopString();
      str.sTopRight = NWNXPopString();
      str.sTop = NWNXPopString();
      str.sTopLeft = NWNXPopString();
      return str;
    }

    /// Get the number of doors of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>The amount of doors.</returns>
    public static int GetTileNumDoors(string sTileset, int nTileID)
    {
      NWNXPushInt(nTileID);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTileNumDoors");
      return NWNXPopInt();
    }

    /// Get the door data of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <param name="nIndex">The index of the door. Range: NWNX_Tileset_GetTileNumDoors() &gt; nIndex &gt;= 0</param>
    /// <returns>A NWNX_Tileset_TileDoorData struct.</returns>
    public static TileDoorData GetTileDoorData(string sTileset, int nTileID, int nIndex = 0)
    {
      NWNXPushInt(nIndex);
      NWNXPushInt(nTileID);
      NWNXPushString(sTileset);
      NWNXCall(NWNX_Tileset, "GetTileDoorData");
      TileDoorData str = default;
      str.fOrientation = NWNXPopFloat();
      str.fZ = NWNXPopFloat();
      str.fY = NWNXPopFloat();
      str.fX = NWNXPopFloat();
      str.nType = NWNXPopInt();
      return str;
    }

    /// Override the tiles of sAreaResRef with data in sOverrideName.
    /// <param name="sAreaResRef">The resref of the area to override.</param>
    /// <param name="sOverrideName">The name of the override containing the custom tile data or &quot;&quot; to remove the override.</param>
    public static void SetAreaTileOverride(string sAreaResRef, string sOverrideName)
    {
      NWNXPushString(sOverrideName);
      NWNXPushString(sAreaResRef);
      NWNXCall(NWNX_Tileset, "SetAreaTileOverride");
    }

    /// Create a tile override named sOverrideName.
    /// <param name="sOverrideName">The name of the override.</param>
    /// <param name="sTileSet">The tileset the override should use.</param>
    /// <param name="nWidth">The width of the area. Valid values: 1-32.</param>
    /// <param name="nHeight">The height of the area. Valid values: 1-32.</param>
    public static void CreateTileOverride(string sOverrideName, string sTileSet, int nWidth, int nHeight)
    {
      NWNXPushInt(nHeight);
      NWNXPushInt(nWidth);
      NWNXPushString(sTileSet);
      NWNXPushString(sOverrideName);
      NWNXCall(NWNX_Tileset, "CreateTileOverride");
    }

    /// Delete a tile override named sOverrideName.
    /// @note This will also delete all custom tile data associated with sOverrideName.
    /// <param name="sOverrideName">The name of the override.</param>
    public static void DeleteTileOverride(string sOverrideName)
    {
      NWNXPushString(sOverrideName);
      NWNXCall(NWNX_Tileset, "DeleteTileOverride");
    }

    /// Set custom tile data for the tile at nIndex in sOverrideName.
    /// @note An override must first be created with NWNX_Tileset_CreateTileOverride().
    /// <param name="sOverrideName">The name of the override.</param>
    /// <param name="nIndex">The index of the tile.</param>
    /// <param name="strCustomTileData">A NWNX_Tileset_CustomTileData struct.</param>
    public static void SetOverrideTileData(string sOverrideName, int nIndex, CustomTileData strCustomTileData)
    {
      NWNXPushInt(strCustomTileData.bAnimLoop3);
      NWNXPushInt(strCustomTileData.bAnimLoop2);
      NWNXPushInt(strCustomTileData.bAnimLoop1);
      NWNXPushInt(strCustomTileData.nSourceLightColor2);
      NWNXPushInt(strCustomTileData.nSourceLightColor1);
      NWNXPushInt(strCustomTileData.nMainLightColor2);
      NWNXPushInt(strCustomTileData.nMainLightColor1);
      NWNXPushInt(strCustomTileData.nHeight);
      NWNXPushInt(strCustomTileData.nOrientation);
      NWNXPushInt(strCustomTileData.nTileID);
      NWNXPushInt(nIndex);
      NWNXPushString(sOverrideName);
      NWNXCall(NWNX_Tileset, "SetOverrideTileData");
    }

    /// Delete custom tile data of the tile at nIndex in sOverrideName.
    /// <param name="sOverrideName">The name of the override.</param>
    /// <param name="nIndex">The tile&apos;s index or -1 to remove all custom tile data.</param>
    public static void DeleteOverrideTileData(string sOverrideName, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushString(sOverrideName);
      NWNXCall(NWNX_Tileset, "DeleteOverrideTileData");
    }

    // @}
  }

  public struct TilesetData
  {
    public int nNumTileData;
    public float fHeightTransition;
    public int nNumTerrain;
    public int nNumCrossers;
    public int nNumGroups;
    public string sBorderTerrain;
    public string sDefaultTerrain;
    public string sFloorTerrain;
    public int nDisplayNameStrRef;
    public string sUnlocalizedName;
    public int bInterior;
    public int bHasHeightTransition;
  }

  public struct TilesetGroupData
  {
    public string sName;
    public int nStrRef;
    public int nRows;
    public int nColumns;
  }

  public struct TileEdgesAndCorners
  {
    public string sTopLeft;
    public string sTop;
    public string sTopRight;
    public string sRight;
    public string sBottomRight;
    public string sBottom;
    public string sBottomLeft;
    public string sLeft;
  }

  public struct TileDoorData
  {
    public int nType;
    public float fX;
    public float fY;
    public float fZ;
    public float fOrientation;
  }

  public struct CustomTileData
  {
    public int nTileID;
    public int nOrientation;
    public int nHeight;
    public int nMainLightColor1;
    public int nMainLightColor2;
    public int nSourceLightColor1;
    public int nSourceLightColor2;
    public int bAnimLoop1;
    public int bAnimLoop2;
    public int bAnimLoop3;
  }
}
