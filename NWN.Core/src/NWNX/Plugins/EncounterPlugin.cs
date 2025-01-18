using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Encounter)]
  public class EncounterPlugin
  {
    /// @addtogroup encounter Encounter
    /// Functions exposing additional encounter properties.
    /// @{
    /// @file nwnx_encounter.nss
    public const string NWNX_Encounter = "NWNX_Encounter";

    ///&lt; @private
    /// A creature list entry for an encounter.
    /// Immediately destroys the specified encounter object.
    /// <param name="encounter">The encounter object.</param>
    public static void Destroy(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "Destroy");
    }

    /// Get the number of creatures in the encounter list
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The number of creatures in the encounter list.</returns>
    public static int GetNumberOfCreaturesInEncounterList(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetNumberOfCreaturesInEncounterList");
      return NWNXPopInt();
    }

    /// Gets the encounter creature list entry at the specified index
    /// <param name="encounter">The encounter object.</param>
    /// <param name="index">The index of the creature in the encounter list.</param>
    /// <returns>An NWNX_Encounter_CreatureListEntry.</returns>
    public static CreatureListEntry GetEncounterCreatureByIndex(uint encounter, int index)
    {
      CreatureListEntry creatureEntry = default;
      NWNXPushInt(index);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetEncounterCreatureByIndex");
      creatureEntry.alreadyUsed = NWNXPopInt();
      creatureEntry.unique = NWNXPopInt();
      creatureEntry.challengeRating = NWNXPopFloat();
      creatureEntry.resref = NWNXPopString();
      return creatureEntry;
    }

    /// Set the encounter creature list entry at the specified index
    /// <param name="encounter">The encounter object.</param>
    /// <param name="index">The index of the creature in the encounter list.</param>
    /// <param name="creatureEntry">The NWNX_Encounter_CreatureListEntry.</param>
    public static void SetEncounterCreatureByIndex(uint encounter, int index, CreatureListEntry creatureEntry)
    {
      NWNXPushInt(creatureEntry.alreadyUsed);
      NWNXPushInt(creatureEntry.unique);
      NWNXPushFloat(creatureEntry.challengeRating);
      NWNXPushString(creatureEntry.resref);
      NWNXPushInt(index);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "SetEncounterCreatureByIndex");
    }

    /// Get the faction id of encounter
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The faction id.</returns>
    public static int GetFactionId(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetFactionId");
      return NWNXPopInt();
    }

    /// Set the faction id of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="factionId">The faction id.</param>
    public static void SetFactionId(uint encounter, int factionId)
    {
      NWNXPushInt(factionId);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "SetFactionId");
    }

    /// Get if encounter is player triggered only.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>TRUE if encounter is player triggered only.</returns>
    public static int GetPlayerTriggeredOnly(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetPlayerTriggeredOnly");
      return NWNXPopInt();
    }

    /// Set if encounter is player triggered only.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="playerTriggeredOnly">TRUE/FALSE</param>
    public static void SetPlayerTriggeredOnly(uint encounter, int playerTriggeredOnly)
    {
      NWNXPushInt(playerTriggeredOnly);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "SetPlayerTriggeredOnly");
    }

    /// Get if the encounter respawns or not.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>TRUE if the encounter does respawn, FALSE otherwise.</returns>
    public static int GetCanReset(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetCanReset");
      return NWNXPopInt();
    }

    /// Set if the encounter respawns or not.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="reset">Does the encounter respawn TRUE or FALSE.</param>
    public static void SetCanReset(uint encounter, int reset)
    {
      NWNXPushInt(reset);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "SetCanReset");
    }

    /// Get the reset time of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The seconds the encounter is defined to reset.</returns>
    public static int GetResetTime(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetResetTime");
      return NWNXPopInt();
    }

    /// Set the reset time of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="resetTime">The seconds the encounter will reset.</param>
    public static void SetResetTime(uint encounter, int resetTime)
    {
      NWNXPushInt(resetTime);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "SetResetTime");
    }

    /// Get the number of spawn points of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The count of the spawn points for the encounter.</returns>
    public static int GetNumberOfSpawnPoints(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetNumberOfSpawnPoints");
      return NWNXPopInt();
    }

    /// Gets the spawn point list entry at the specified index
    /// <param name="encounter">The encounter object.</param>
    /// <param name="index">The index of the spawn point in the encounter list.</param>
    /// <returns>Location of spawn point.</returns>
    public static System.IntPtr GetSpawnPointByIndex(uint encounter, int index)
    {
      NWNXPushInt(index);
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetSpawnPointByIndex");
      float fOrientation = NWNXPopFloat();
      System.Numerics.Vector3 vPosition = NWNXPopVector();
      return NWNXPopLocation();
    }

    /// Get the minimum amount of creatures that encounter will spawn.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>the minimal amount.</returns>
    public static int GetMinNumSpawned(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetMinNumSpawned");
      return NWNXPopInt();
    }

    /// Get the maximum amount of creatures that encounter will spawn.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>the maximal amount.</returns>
    public static int GetMaxNumSpawned(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetMaxNumSpawned");
      return NWNXPopInt();
    }

    /// Get the current number of creatures that are spawned and alive
    /// <param name="encounter">The encounter object.</param>
    /// <returns>amount of creatures</returns>
    public static int GetCurrentNumSpawned(uint encounter)
    {
      NWNXPushObject(encounter);
      NWNXCall(NWNX_Encounter, "GetCurrentNumSpawned");
      return NWNXPopInt();
    }

    /// Get the geometry of an encounter
    /// <param name="oEncounter:">The encounter object.</param>
    /// <returns>A string of vertex positions.</returns>
    public static string GetGeometry(uint oEncounter)
    {
      NWNXPushObject(oEncounter);
      NWNXCall(NWNX_Encounter, "GetGeometry");
      return NWNXPopString();
    }

    /// Set the geometry of an encounter with a list of vertex positions
    /// <param name="oTrigger">The encounter object.</param>
    /// <param name="sGeometry">Needs to be in the following format -&gt; {x.x, y.y, z.z} or {x.x, y.y}</param>
    /// Example Geometry: &quot;{1.0, 1.0, 0.0}{4.0, 1.0, 0.0}{4.0, 4.0, 0.0}{1.0, 4.0, 0.0}&quot;
    ///
    /// @remark The Z position is optional and will be calculated dynamically based
    /// on terrain height if it&apos;s not provided.
    ///
    /// @remark The minimum number of vertices is 3.
    public static void SetGeometry(uint oEncounter, string sGeometry)
    {
      NWNXPushString(sGeometry);
      NWNXPushObject(oEncounter);
      NWNXCall(NWNX_Encounter, "SetGeometry");
    }

    // @}
  }

  public struct CreatureListEntry
  {
    public string resref;
    public float challengeRating;
    public int unique;
    public int alreadyUsed;
  }
}
