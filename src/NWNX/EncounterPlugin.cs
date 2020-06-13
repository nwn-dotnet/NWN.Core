namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Encounter)]
    public class EncounterPlugin
    {
        public const string NWNX_Encounter = "NWNX_Encounter";

        // /< @private
        // / @brief A creature list entry for an encounter.
        // / @brief Get the number of creatures in the encounter list
        // / @param encounter The encounter object.
        // / @return The number of creatures in the encounter list.
        public static int GetNumberOfCreaturesInEncounterList(uint encounter)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "GetNumberOfCreaturesInEncounterList");
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the encounter creature list entry at the specified index
        // / @param encounter The encounter object.
        // / @param index The index of the creature in the encounter list.
        // / @return An NWNX_Encounter_CreatureListEntry.
        public static CreatureListEntry GetEncounterCreatureByIndex(uint encounter, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "GetEncounterCreatureByIndex");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
            CreatureListEntry retVal;
            retVal.unique = Internal.NativeFunctions.nwnxPopInt();
            retVal.challengeRating = Internal.NativeFunctions.nwnxPopFloat();
            retVal.resref = Internal.NativeFunctions.nwnxPopString();
            return retVal;
        }

        // / @brief Set the encounter creature list entry at the specified index
        // / @param encounter The encounter object.
        // / @param index The index of the creature in the encounter list.
        // / @param creatureEntry The NWNX_Encounter_CreatureListEntry.
        public static void SetEncounterCreatureByIndex(uint encounter, int index, CreatureListEntry creatureEntry)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "SetEncounterCreatureByIndex");
            Internal.NativeFunctions.nwnxPushString(creatureEntry.resref);
            Internal.NativeFunctions.nwnxPushFloat(creatureEntry.challengeRating);
            Internal.NativeFunctions.nwnxPushInt(creatureEntry.unique);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the faction id of encounter
        // / @param encounter The encounter object.
        // / @return The faction id.
        public static int GetFactionId(uint encounter)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "GetFactionId");
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set the faction id of encounter.
        // / @param encounter The encounter object.
        // / @param factionId The faction id.
        public static void SetFactionId(uint encounter, int factionId)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "SetFactionId");
            Internal.NativeFunctions.nwnxPushInt(factionId);
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get if encounter is player triggered only.
        // / @param encounter The encounter object.
        // / @return TRUE is encounter is player triggered only.
        public static int GetPlayerTriggeredOnly(uint encounter)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "GetPlayerTriggeredOnly");
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set if encounter is player triggered only.
        // / @param encounter The encounter object.
        // / @param playerTriggeredOnly TRUE/FALSE
        public static void SetPlayerTriggeredOnly(uint encounter, int playerTriggeredOnly)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "SetPlayerTriggeredOnly");
            Internal.NativeFunctions.nwnxPushInt(playerTriggeredOnly);
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the reset time of encounter.
        // / @param encounter The encounter object.
        // / @return The seconds the encounter is defined to reset.
        public static int GetResetTime(uint encounter)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "GetResetTime");
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set the reset time of encounter.
        // / @param encounter The encounter object.
        // / @param resetTime The seconds the encounter will reset.
        public static void SetResetTime(uint encounter, int resetTime)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Encounter, "SetResetTime");
            Internal.NativeFunctions.nwnxPushInt(resetTime);
            Internal.NativeFunctions.nwnxPushObject(encounter);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
    }

        public struct CreatureListEntry
        {
            public string resref;
            public float challengeRating;
            public int unique;
        }
}
