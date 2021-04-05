using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Encounter)]
  public class EncounterPlugin
  {
    public const string NWNX_Encounter = "NWNX_Encounter";

    ///&lt; @private
    /// A creature list entry for an encounter.
    /// Get the number of creatures in the encounter list
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The number of creatures in the encounter list.</returns>
    public static int GetNumberOfCreaturesInEncounterList(uint encounter)
    {
      const string sFunc = "GetNumberOfCreaturesInEncounterList";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the encounter creature list entry at the specified index
    /// <param name="encounter">The encounter object.</param>
    /// <param name="index">The index of the creature in the encounter list.</param>
    /// <returns>An NWNX_Encounter_CreatureListEntry.</returns>
    public static CreatureListEntry GetEncounterCreatureByIndex(uint encounter, int index)
    {
      const string sFunc = "GetEncounterCreatureByIndex";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      CreatureListEntry creatureEntry = default;
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      creatureEntry.alreadyUsed = VM.NWNX.StackPopInt();
      creatureEntry.unique = VM.NWNX.StackPopInt();
      creatureEntry.challengeRating = VM.NWNX.StackPopFloat();
      creatureEntry.resref = VM.NWNX.StackPopString();
      return creatureEntry;
    }

    /// Set the encounter creature list entry at the specified index
    /// <param name="encounter">The encounter object.</param>
    /// <param name="index">The index of the creature in the encounter list.</param>
    /// <param name="creatureEntry">The NWNX_Encounter_CreatureListEntry.</param>
    public static void SetEncounterCreatureByIndex(uint encounter, int index, CreatureListEntry creatureEntry)
    {
      const string sFunc = "SetEncounterCreatureByIndex";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(creatureEntry.alreadyUsed);
      VM.NWNX.StackPush(creatureEntry.unique);
      VM.NWNX.StackPush(creatureEntry.challengeRating);
      VM.NWNX.StackPush(creatureEntry.resref);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get the faction id of encounter
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The faction id.</returns>
    public static int GetFactionId(uint encounter)
    {
      const string sFunc = "GetFactionId";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the faction id of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="factionId">The faction id.</param>
    public static void SetFactionId(uint encounter, int factionId)
    {
      const string sFunc = "SetFactionId";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(factionId);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get if encounter is player triggered only.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>TRUE if encounter is player triggered only.</returns>
    public static int GetPlayerTriggeredOnly(uint encounter)
    {
      const string sFunc = "GetPlayerTriggeredOnly";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set if encounter is player triggered only.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="playerTriggeredOnly">TRUE/FALSE</param>
    public static void SetPlayerTriggeredOnly(uint encounter, int playerTriggeredOnly)
    {
      const string sFunc = "SetPlayerTriggeredOnly";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(playerTriggeredOnly);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get if the encounter respawns or not.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>TRUE if the encounter does respawn, FALSE otherwise.</returns>
    public static int GetCanReset(uint encounter)
    {
      const string sFunc = "GetCanReset";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set if the encounter respawns or not.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="reset">Does the encounter respawn TRUE or FALSE.</param>
    public static void SetCanReset(uint encounter, int reset)
    {
      const string sFunc = "SetCanReset";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(reset);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get the reset time of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The seconds the encounter is defined to reset.</returns>
    public static int GetResetTime(uint encounter)
    {
      const string sFunc = "GetResetTime";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the reset time of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="resetTime">The seconds the encounter will reset.</param>
    public static void SetResetTime(uint encounter, int resetTime)
    {
      const string sFunc = "SetResetTime";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(resetTime);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get the number of spawn points of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The count of the spawn points for the encounter.</returns>
    public static int GetNumberOfSpawnPoints(uint encounter)
    {
      const string sFunc = "GetNumberOfSpawnPoints";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the spawn point list entry at the specified index
    /// <param name="encounter">The encounter object.</param>
    /// <param name="index">The index of the spawn point in the encounter list.</param>
    /// <returns>Location of spawn point.</returns>
    public static System.IntPtr GetSpawnPointByIndex(uint encounter, int index)
    {
      const string sFunc = "GetSpawnPointByIndex";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      float o = VM.NWNX.StackPopFloat();
      float z = VM.NWNX.StackPopFloat();
      float y = VM.NWNX.StackPopFloat();
      float x = VM.NWNX.StackPopFloat();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    /// Get the minimum amount of creatures that encounter will spawn.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>the minimal amount.</returns>
    public static int GetMinNumSpawned(uint encounter)
    {
      const string sFunc = "GetMinNumSpawned";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the maximum amount of creatures that encounter will spawn.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>the maximal amount.</returns>
    public static int GetMaxNumSpawned(uint encounter)
    {
      const string sFunc = "GetMaxNumSpawned";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the current number of creatures that are spawned and alive
    /// <param name="encounter">The encounter object.</param>
    /// <returns>amount of creatures</returns>
    public static int GetCurrentNumSpawned(uint encounter)
    {
      const string sFunc = "GetCurrentNumSpawned";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the geometry of an encounter
    /// <param name="oEncounter:">The encounter object.</param>
    /// <returns>A string of vertex positions.</returns>
    public static string GetGeometry(uint oEncounter)
    {
      const string sFunc = "GetGeometry";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(oEncounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
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
      const string sFunc = "SetGeometry";
      VM.NWNX.SetFunction(NWNX_Encounter, sFunc);
      VM.NWNX.StackPush(sGeometry);
      VM.NWNX.StackPush(oEncounter);
      VM.NWNX.Call();
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
