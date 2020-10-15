namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Encounter)]
  public class EncounterPlugin
  {
    public const string NWNX_Encounter = "NWNX_Encounter";

    ///< @private
    /// A creature list entry for an encounter.
    /// Get the number of creatures in the encounter list
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The number of creatures in the encounter list.</returns>
    public static int GetNumberOfCreaturesInEncounterList(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetNumberOfCreaturesInEncounterList");
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
      VM.NWNX.SetFunction(NWNX_Encounter, "GetEncounterCreatureByIndex");
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
      VM.NWNX.SetFunction(NWNX_Encounter, "SetEncounterCreatureByIndex");
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
      VM.NWNX.SetFunction(NWNX_Encounter, "GetFactionId");
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the faction id of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="factionId">The faction id.</param>
    public static void SetFactionId(uint encounter, int factionId)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "SetFactionId");
      VM.NWNX.StackPush(factionId);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get if encounter is player triggered only.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>TRUE if encounter is player triggered only.</returns>
    public static int GetPlayerTriggeredOnly(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetPlayerTriggeredOnly");
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set if encounter is player triggered only.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="playerTriggeredOnly">TRUE/FALSE</param>
    public static void SetPlayerTriggeredOnly(uint encounter, int playerTriggeredOnly)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "SetPlayerTriggeredOnly");
      VM.NWNX.StackPush(playerTriggeredOnly);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get the reset time of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The seconds the encounter is defined to reset.</returns>
    public static int GetResetTime(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetResetTime");
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the reset time of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <param name="resetTime">The seconds the encounter will reset.</param>
    public static void SetResetTime(uint encounter, int resetTime)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "SetResetTime");
      VM.NWNX.StackPush(resetTime);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
    }

    /// Get the number of spawn points of encounter.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>The count of the spawn points for the encounter.</returns>
    public static int GetNumberOfSpawnPoints(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetNumberOfSpawnPoints");
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
      VM.NWNX.SetFunction(NWNX_Encounter, "GetSpawnPointByIndex");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      float o = VM.NWNX.StackPopFloat();
      float z = VM.NWNX.StackPopFloat();
      float y = VM.NWNX.StackPopFloat();
      float x = VM.NWNX.StackPopFloat();
      return VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_LOCATION);
    }

    /// Get the minimum amount of creatures that encounter will spawn.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>the minimal amount.</returns>
    public static int GetMinNumSpawned(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetMinNumSpawned");
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the maximum amount of creatures that encounter will spawn.
    /// <param name="encounter">The encounter object.</param>
    /// <returns>the maximal amount.</returns>
    public static int GetMaxNumSpawned(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetMaxNumSpawned");
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the current number of creatures that are spawned and alive
    /// <param name="encounter">The encounter object.</param>
    /// <returns>amount of creatures</returns>
    public static int GetCurrentNumSpawned(uint encounter)
    {
      VM.NWNX.SetFunction(NWNX_Encounter, "GetCurrentNumSpawned");
      VM.NWNX.StackPush(encounter);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// @}
  }

  public struct CreatureListEntry
  {
    public string resref;
    public float challengeRating;
    public int unique;
    public int alreadyUsed;
  }
}
