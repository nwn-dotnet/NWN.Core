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
            VM.NWNX.StackPush(index);
            VM.NWNX.StackPush(encounter);
            VM.NWNX.Call();
            CreatureListEntry retVal;
            retVal.unique = VM.NWNX.StackPopInt();
            retVal.challengeRating = VM.NWNX.StackPopFloat();
            retVal.resref = VM.NWNX.StackPopString();
            return retVal;
        }

        /// Set the encounter creature list entry at the specified index
        /// <param name="encounter">The encounter object.</param>
        /// <param name="index">The index of the creature in the encounter list.</param>
        /// <param name="creatureEntry">The NWNX_Encounter_CreatureListEntry.</param>
        public static void SetEncounterCreatureByIndex(uint encounter, int index, CreatureListEntry creatureEntry)
        {
            VM.NWNX.SetFunction(NWNX_Encounter, "SetEncounterCreatureByIndex");
            VM.NWNX.StackPush(creatureEntry.resref);
            VM.NWNX.StackPush(creatureEntry.challengeRating);
            VM.NWNX.StackPush(creatureEntry.unique);
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
        /// <returns>TRUE is encounter is player triggered only.</returns>
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

        /// @}
    }

    public struct CreatureListEntry
    {
        public string resref;
        public float challengeRating;
        public int unique;
    }
}