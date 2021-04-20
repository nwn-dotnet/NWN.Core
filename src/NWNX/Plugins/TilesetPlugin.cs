using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Tileset)]
  public class TilesetPlugin
  {
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
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      TilesetData str = default;
      str.bHasHeightTransition = VM.NWNX.StackPopInt();
      str.bInterior = VM.NWNX.StackPopInt();
      str.sUnlocalizedName = VM.NWNX.StackPopString();
      str.nDisplayNameStrRef = VM.NWNX.StackPopInt();
      str.sFloorTerrain = VM.NWNX.StackPopString();
      str.sDefaultTerrain = VM.NWNX.StackPopString();
      str.sBorderTerrain = VM.NWNX.StackPopString();
      str.nNumGroups = VM.NWNX.StackPopInt();
      str.nNumCrossers = VM.NWNX.StackPopInt();
      str.nNumTerrain = VM.NWNX.StackPopInt();
      str.fHeightTransition = VM.NWNX.StackPopFloat();
      str.nNumTileData = VM.NWNX.StackPopInt();
      return str;
    }

    /// Get the name of sTileset&apos;s terrain at nIndex.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nIndex">The index of the terrain. Range: NWNX_Tileset_TilesetData.nNumTerrain &gt; nIndex &gt;= 0</param>
    /// <returns>The terrain name or &quot;&quot; on error.</returns>
    public static string GetTilesetTerrain(string sTileset, int nIndex)
    {
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the name of sTileset&apos;s crosser at nIndex.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nIndex">The index of the crosser. Range: NWNX_Tileset_TilesetData.nNumCrossers &gt; nIndex &gt;= 0</param>
    /// <returns>The crosser name or &quot;&quot; on error.</returns>
    public static string GetTilesetCrosser(string sTileset, int nIndex)
    {
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get general data of the group at nIndex in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nIndex">The index of the group. Range: NWNX_Tileset_TilesetData.nNumGroups &gt; nIndex &gt;= 0</param>
    /// <returns>A NWNX_Tileset_TilesetGroupData struct.</returns>
    public static TilesetGroupData GetTilesetGroupData(string sTileset, int nIndex)
    {
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      TilesetGroupData str = default;
      str.nColumns = VM.NWNX.StackPopInt();
      str.nRows = VM.NWNX.StackPopInt();
      str.nStrRef = VM.NWNX.StackPopInt();
      str.sName = VM.NWNX.StackPopString();
      return str;
    }

    /// Get the tile ID at nTileIndex in nGroupIndex of sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nGroupIndex">The index of the group. Range: NWNX_Tileset_TilesetData.nNumGroups &gt; nGroupIndex &gt;= 0</param>
    /// <param name="nTileIndex">The index of the tile. Range: (NWNX_Tileset_TilesetGroupData.nRows * NWNX_Tileset_TilesetGroupData.nColumns) &gt; nTileIndex &gt;= 0</param>
    /// <returns>The tile ID or 0 on error.</returns>
    public static int GetTilesetGroupTile(string sTileset, int nGroupIndex, int nTileIndex)
    {
      VM.NWNX.StackPush(nTileIndex);
      VM.NWNX.StackPush(nGroupIndex);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the model name of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>The model name or &quot;&quot; on error.</returns>
    public static string GetTileModel(string sTileset, int nTileID)
    {
      VM.NWNX.StackPush(nTileID);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the minimap texture name of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>The minimap texture name or &quot;&quot; on error.</returns>
    public static string GetTileMinimapTexture(string sTileset, int nTileID)
    {
      VM.NWNX.StackPush(nTileID);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the edges and corners of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>A NWNX_Tileset_TileEdgesAndCorners struct.</returns>
    public static TileEdgesAndCorners GetTileEdgesAndCorners(string sTileset, int nTileID)
    {
      VM.NWNX.StackPush(nTileID);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      TileEdgesAndCorners str = default;
      str.sLeft = VM.NWNX.StackPopString();
      str.sBottomLeft = VM.NWNX.StackPopString();
      str.sBottom = VM.NWNX.StackPopString();
      str.sBottomRight = VM.NWNX.StackPopString();
      str.sRight = VM.NWNX.StackPopString();
      str.sTopRight = VM.NWNX.StackPopString();
      str.sTop = VM.NWNX.StackPopString();
      str.sTopLeft = VM.NWNX.StackPopString();
      return str;
    }

    /// Get the number of doors of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <returns>The amount of doors.</returns>
    public static int GetTileNumDoors(string sTileset, int nTileID)
    {
      VM.NWNX.StackPush(nTileID);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the door data of a tile in sTileset.
    /// <param name="sTileset">The tileset.</param>
    /// <param name="nTileID">The tile ID.</param>
    /// <param name="nIndex">The index of the door. Range: NWNX_Tileset_GetTileNumDoors() &gt; nIndex &gt;= 0</param>
    /// <returns>A NWNX_Tileset_TileDoorData struct.</returns>
    public static TileDoorData GetTileDoorData(string sTileset, int nTileID, int nIndex = 0)
    {
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(nTileID);
      VM.NWNX.StackPush(sTileset);
      VM.NWNX.Call();
      TileDoorData str = default;
      str.fOrientation = VM.NWNX.StackPopFloat();
      str.fZ = VM.NWNX.StackPopFloat();
      str.fY = VM.NWNX.StackPopFloat();
      str.fX = VM.NWNX.StackPopFloat();
      str.nType = VM.NWNX.StackPopInt();
      return str;
    }

    /// Override the tiles of sAreaResRef with data in sOverrideName.
    /// <param name="sAreaResRef">The resref of the area to override.</param>
    /// <param name="sOverrideName">The name of the override containing the custom tile data or &quot;&quot; to remove the override.</param>
    public static void SetAreaTileOverride(string sAreaResRef, string sOverrideName)
    {
      VM.NWNX.StackPush(sOverrideName);
      VM.NWNX.StackPush(sAreaResRef);
      VM.NWNX.Call();
    }

    /// Create a tile override named sOverrideName.
    /// <param name="sOverrideName">The name of the override.</param>
    /// <param name="sTileSet">The tileset the override should use.</param>
    /// <param name="nWidth">The width of the area. Valid values: 1-32.</param>
    /// <param name="nHeight">The height of the area. Valid values: 1-32.</param>
    public static void CreateTileOverride(string sOverrideName, string sTileSet, int nWidth, int nHeight)
    {
      VM.NWNX.StackPush(nHeight);
      VM.NWNX.StackPush(nWidth);
      VM.NWNX.StackPush(sTileSet);
      VM.NWNX.StackPush(sOverrideName);
      VM.NWNX.Call();
    }

    /// Delete a tile override named sOverrideName.
    /// @note This will also delete all custom tile data associated with sOverrideName.
    /// <param name="sOverrideName">The name of the override.</param>
    public static void DeleteTileOverride(string sOverrideName)
    {
      VM.NWNX.StackPush(sOverrideName);
      VM.NWNX.Call();
    }

    /// Set custom tile data for the tile at nIndex in sOverrideName.
    /// @note An override must first be created with NWNX_Tileset_CreateTileOverride().
    /// <param name="sOverrideName">The name of the override.</param>
    /// <param name="nIndex">The index of the tile.</param>
    /// <param name="strCustomTileData">A NWNX_Tileset_CustomTileData struct.</param>
    public static void SetOverrideTileData(string sOverrideName, int nIndex, CustomTileData strCustomTileData)
    {
      VM.NWNX.StackPush(strCustomTileData.bAnimLoop3);
      VM.NWNX.StackPush(strCustomTileData.bAnimLoop2);
      VM.NWNX.StackPush(strCustomTileData.bAnimLoop1);
      VM.NWNX.StackPush(strCustomTileData.nSourceLightColor2);
      VM.NWNX.StackPush(strCustomTileData.nSourceLightColor1);
      VM.NWNX.StackPush(strCustomTileData.nMainLightColor2);
      VM.NWNX.StackPush(strCustomTileData.nMainLightColor1);
      VM.NWNX.StackPush(strCustomTileData.nHeight);
      VM.NWNX.StackPush(strCustomTileData.nOrientation);
      VM.NWNX.StackPush(strCustomTileData.nTileID);
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(sOverrideName);
      VM.NWNX.Call();
    }

    /// Delete custom tile data of the tile at nIndex in sOverrideName.
    /// <param name="sOverrideName">The name of the override.</param>
    /// <param name="nIndex">The tile&apos;s index or -1 to remove all custom tile data.</param>
    public static void DeleteOverrideTileData(string sOverrideName, int nIndex)
    {
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(sOverrideName);
      VM.NWNX.Call();
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
