namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Creature)]
    public class CreaturePlugin
    {
        public const string NWNX_Creature = "NWNX_Creature";

        // /< @private
        // / @name Creature Movement Rates
        // / @anchor creature_movement_rates
        // /
        // / The various types of movement rates.
        // / @{
        public const int NWNX_CREATURE_MOVEMENT_RATE_PC = 0;
        public const int NWNX_CREATURE_MOVEMENT_RATE_IMMOBILE = 1;
        public const int NWNX_CREATURE_MOVEMENT_RATE_VERY_SLOW = 2;
        public const int NWNX_CREATURE_MOVEMENT_RATE_SLOW = 3;
        public const int NWNX_CREATURE_MOVEMENT_RATE_NORMAL = 4;
        public const int NWNX_CREATURE_MOVEMENT_RATE_FAST = 5;
        public const int NWNX_CREATURE_MOVEMENT_RATE_VERY_FAST = 6;
        public const int NWNX_CREATURE_MOVEMENT_RATE_DEFAULT = 7;
        public const int NWNX_CREATURE_MOVEMENT_RATE_DM_FAST = 8;

        // / @}
        // / @name Creature Movement Types
        // / @anchor creature_movement_types
        // /
        // / The various types of movement types.
        // / @{
        public const int NWNX_CREATURE_MOVEMENT_TYPE_STATIONARY = 0;
        public const int NWNX_CREATURE_MOVEMENT_TYPE_WALK = 1;
        public const int NWNX_CREATURE_MOVEMENT_TYPE_RUN = 2;
        public const int NWNX_CREATURE_MOVEMENT_TYPE_SIDESTEP = 3;
        public const int NWNX_CREATURE_MOVEMENT_TYPE_WALK_BACKWARDS = 4;

        // / @}
        // / @name Cleric Domains
        // / @anchor cleric_domains
        // /
        // / The clerical domains.
        // / @{
        public const int NWNX_CREATURE_CLERIC_DOMAIN_AIR = 0;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_ANIMAL = 1;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_DEATH = 3;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_DESTRUCTION = 4;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_EARTH = 5;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_EVIL = 6;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_FIRE = 7;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_GOOD = 8;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_HEALING = 9;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_KNOWLEDGE = 10;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_MAGIC = 13;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_PLANT = 14;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_PROTECTION = 15;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_STRENGTH = 16;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_SUN = 17;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_TRAVEL = 18;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_TRICKERY = 19;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_WAR = 20;
        public const int NWNX_CREATURE_CLERIC_DOMAIN_WATER = 21;

        // / @}
        // / @name Bonus Types
        // / @anchor bonus_types
        // /
        // / Used with NWNX_Creature_GetTotalEffectBonus() these are the types of temporary bonuses from effects.
        // / @{
        public const int NWNX_CREATURE_BONUS_TYPE_ATTACK = 1;
        public const int NWNX_CREATURE_BONUS_TYPE_DAMAGE = 2;
        public const int NWNX_CREATURE_BONUS_TYPE_SAVING_THROW = 3;
        public const int NWNX_CREATURE_BONUS_TYPE_ABILITY = 4;
        public const int NWNX_CREATURE_BONUS_TYPE_SKILL = 5;
        public const int NWNX_CREATURE_BONUS_TYPE_TOUCH_ATTACK = 6;

        // / @}
        // / @struct NWNX_Creature_SpecialAbility
        // / @brief A creature special ability.
        // / @struct NWNX_Creature_MemorisedSpell
        // / @brief A memorised spell structure.
        // / @brief Gives the creature a feat.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @remark Consider also using NWNX_Creature_AddFeatByLevel() to properly allocate the feat to a level
        public static void AddFeat(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "AddFeat");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gives the creature a feat assigned at a level
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @param level The level they gained the feat.
        // / @remark Adds the feat to the stat list at the provided level.
        public static void AddFeatByLevel(uint creature, int feat, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "AddFeatByLevel");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Removes a feat from a creature.
        // / @param creature The creature object.
        // / @param feat The feat id.
        public static void RemoveFeat(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RemoveFeat");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Determines if the creature knows a feat.
        // / @note This differs from native @nwn{GetHasFeat} which returns FALSE if the feat has no more uses per day.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @return TRUE if the creature has the feat, regardless if they have any usages left or not.
        public static int GetKnowsFeat(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetKnowsFeat");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Returns the count of feats learned at the provided level.
        // / @param creature The creature object.
        // / @param level The level.
        // / @return The count of feats.
        public static int GetFeatCountByLevel(uint creature, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatCountByLevel");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Returns the feat learned at the level and index.
        // / @param creature The creature object.
        // / @param level The level.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetFeatCountByLevel().
        // / @return The feat id at the index.
        public static int GetFeatByLevel(uint creature, int level, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatByLevel");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Returns the creature level where the specified feat was learned.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @return The character level that the specified feat was granted, otherwise 0 if the creature does not have this feat.
        public static int GetFeatGrantLevel(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatGrantLevel");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get the total number of feats known by creature.
        // / @param creature The creature object.
        // / @return The total feat count for the creature.
        public static int GetFeatCount(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatCount");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Returns the creature's feat at a given index
        // / @param creature The creature object.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetFeatCount();
        // / @return The feat id at the index.
        public static int GetFeatByIndex(uint creature, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatByIndex");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets if creature meets feat requirements.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @return TRUE if creature meets all requirements to take given feat
        public static int GetMeetsFeatRequirements(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMeetsFeatRequirements");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the count of special abilities of the creature.
        // / @param creature The creature object.
        // / @return The total special ability count.
        public static int GetSpecialAbilityCount(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetSpecialAbilityCount");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Returns the creature's special ability at a given index.
        // / @param creature The creature object.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetSpecialAbilityCount().
        // / @return An NWNX_Creature_SpecialAbility struct.
        public static SpecialAbility GetSpecialAbility(uint creature, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetSpecialAbility");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            SpecialAbility retVal;
            retVal.level = Internal.NativeFunctions.nwnxPopInt();
            retVal.ready = Internal.NativeFunctions.nwnxPopInt();
            retVal.id = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Adds a special ability to a creature.
        // / @param creature The creature object.
        // / @param ability An NWNX_Creature_SpecialAbility struct.
        public static void AddSpecialAbility(uint creature, SpecialAbility ability)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "AddSpecialAbility");
            Internal.NativeFunctions.nwnxPushInt(ability.id);
            Internal.NativeFunctions.nwnxPushInt(ability.ready);
            Internal.NativeFunctions.nwnxPushInt(ability.level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Removes a special ability from a creature.
        // / @param creature The creature object.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetSpecialAbilityCount().
        public static void RemoveSpecialAbility(uint creature, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RemoveSpecialAbility");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets a special ability at the index for the creature.
        // / @param creature The creature object.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetSpecialAbilityCount().
        // / @param ability An NWNX_Creature_SpecialAbility struct.
        public static void SetSpecialAbility(uint creature, int index, SpecialAbility ability)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSpecialAbility");
            Internal.NativeFunctions.nwnxPushInt(ability.id);
            Internal.NativeFunctions.nwnxPushInt(ability.ready);
            Internal.NativeFunctions.nwnxPushInt(ability.level);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the class taken by the creature at the provided level.
        // / @param creature The creature object.
        // / @param level The level.
        // / @return The class id.
        public static int GetClassByLevel(uint creature, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetClassByLevel");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the base AC for the creature.
        // / @param creature The creature object.
        // / @param ac The base AC to set for the creature.
        public static void SetBaseAC(uint creature, int ac)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetBaseAC");
            Internal.NativeFunctions.nwnxPushInt(ac);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the base AC for the creature.
        // / @param creature The creature object.
        // / @return The base AC.
        public static int GetBaseAC(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetBaseAC");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the ability score of the creature to the value.
        // / @param creature The creature object.
        // / @param ability The ability constant.
        // / @param value The value to set.
        // / @deprecated Use NWNX_Creature_SetRawAbilityScore(). This will be removed in future NWNX releases.
        public static void SetAbilityScore(uint creature, int ability, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetAbilityScore");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushInt(ability);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the ability score of the creature to the provided value.
        // / @note Does not apply racial bonuses/penalties.
        // / @param creature The creature object.
        // / @param ability The ability constant.
        // / @param value The value to set.
        public static void SetRawAbilityScore(uint creature, int ability, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetRawAbilityScore");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushInt(ability);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the ability score of the creature.
        // / @note Does not apply racial bonuses/penalties.
        // / @param creature The creature object.
        // / @param ability The ability constant.
        // / @return The ability score.
        public static int GetRawAbilityScore(uint creature, int ability)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetRawAbilityScore");
            Internal.NativeFunctions.nwnxPushInt(ability);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Adjusts the ability score of a creature.
        // / @note Does not apply racial bonuses/penalties.
        // / @param creature The creature object.
        // / @param ability The ability constant.
        // / @param modifier The modifier value.
        public static void ModifyRawAbilityScore(uint creature, int ability, int modifier)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "ModifyRawAbilityScore");
            Internal.NativeFunctions.nwnxPushInt(modifier);
            Internal.NativeFunctions.nwnxPushInt(ability);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the raw ability score a polymorphed creature had prior to polymorphing.
        // / @note For Strength, Dexterity and Constitution only.
        // / @param creature The creature object.
        // / @param ability The ability constant.
        // / @return The raw ability score.
        public static int GetPrePolymorphAbilityScore(uint creature, int ability)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetPrePolymorphAbilityScore");
            Internal.NativeFunctions.nwnxPushInt(ability);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the count of memorised spells for a creature's class at a level.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @return The memorised spell count.
        public static int GetMemorisedSpellCountByLevel(uint creature, int @class, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMemorisedSpellCountByLevel");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the memorised spell at a class level's index.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetMemorisedSpellCountByLevel().
        // / @return An NWNX_Creature_MemorisedSpell() struct.
        public static MemorisedSpell GetMemorisedSpell(uint creature, int @class, int level, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMemorisedSpell");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            MemorisedSpell retVal;
            retVal.domain = Internal.NativeFunctions.nwnxPopInt();
            retVal.meta = Internal.NativeFunctions.nwnxPopInt();
            retVal.ready = Internal.NativeFunctions.nwnxPopInt();
            retVal.id = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Sets the memorised spell at a class level's index.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetMemorisedSpellCountByLevel().
        // / @param spell An NWNX_Creature_MemorisedSpell() struct.
        public static void SetMemorisedSpell(uint creature, int @class, int level, int index, MemorisedSpell spell)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetMemorisedSpell");
            Internal.NativeFunctions.nwnxPushInt(spell.id);
            Internal.NativeFunctions.nwnxPushInt(spell.ready);
            Internal.NativeFunctions.nwnxPushInt(spell.meta);
            Internal.NativeFunctions.nwnxPushInt(spell.domain);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the remaining spell slots (innate casting) at a class level's index.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @return The remaining spell slot count.
        public static int GetRemainingSpellSlots(uint creature, int @class, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetRemainingSpellSlots");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the remaining spell slots (innate casting) at a class level.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param slots The remaining spell slots to set.
        public static void SetRemainingSpellSlots(uint creature, int @class, int level, int slots)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetRemainingSpellSlots");
            Internal.NativeFunctions.nwnxPushInt(slots);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the maximum spell slots (innate casting) at a class level.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @return The maximum spell slot count.
        public static int GetMaxSpellSlots(uint creature, int @class, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMaxSpellSlots");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the known spell count (innate casting) at a class level.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @return The known spell count.
        public static int GetKnownSpellCount(uint creature, int @class, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetKnownSpellCount");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the known spell at a class level's index.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetKnownSpellCount().
        // / @return The spell id.
        public static int GetKnownSpell(uint creature, int @class, int level, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetKnownSpell");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Add a spell to a creature's spellbook for class.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param spellId The spell to remove.
        public static void AddKnownSpell(uint creature, int @class, int level, int spellId)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "AddKnownSpell");
            Internal.NativeFunctions.nwnxPushInt(spellId);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Remove a spell from creature's spellbook for class.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param spellId The spell to remove.
        public static void RemoveKnownSpell(uint creature, int @class, int level, int spellId)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RemoveKnownSpell");
            Internal.NativeFunctions.nwnxPushInt(spellId);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Clear a specific spell from the creature's spellbook for class
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param spellId The spell to clear.
        public static void ClearMemorisedKnownSpells(uint creature, int @class, int spellId)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "ClearMemorisedKnownSpells");
            Internal.NativeFunctions.nwnxPushInt(spellId);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Clear the memorised spell of the creature for the class, level and index.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param level The spell level.
        // / @param index The index. Index bounds: 0 <= index < NWNX_Creature_GetMemorisedSpellCountByLevel().
        public static void ClearMemorisedSpell(uint creature, int @class, int level, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "ClearMemorisedSpell");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets whether or not creature has a specialist school of wizardry.
        // / @param creature The creature object.
        // / @return TRUE if the wizard specializes.
        // / @deprecated Use GetSpecialization(). This will be removed in future NWNX releases.
        public static int GetWizardSpecialization(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetWizardSpecialization");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets creature's wizard specialist school.
        // / @param creature The creature object.
        // / @param school The wizard school constant.
        // / @deprecated Use NWNX_Creature_SetSpecialization(). This will be removed in future NWNX releases.
        public static void SetWizardSpecialization(uint creature, int school)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetWizardSpecialization");
            Internal.NativeFunctions.nwnxPushInt(school);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the maximum hit points for creature for level.
        // / @param creature The creature object.
        // / @param level The level.
        // / @return The maximum hit points a creature can have for the class at the provided level.
        public static int GetMaxHitPointsByLevel(uint creature, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMaxHitPointsByLevel");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the maximum hit points for creature.
        // / @param creature The creature object.
        // / @param level The level.
        // / @param value The amount to set the max hit points.
        public static void SetMaxHitPointsByLevel(uint creature, int level, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetMaxHitPointsByLevel");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's movement rate.
        // / @param creature The creature object.
        // / @param rate The movement rate.
        public static void SetMovementRate(uint creature, int rate)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetMovementRate");
            Internal.NativeFunctions.nwnxPushInt(rate);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Returns the creature's current movement rate factor.
        // / @remark Base movement rate factor is 1.0.
        // / @param creature The creature object.
        // / @return The current movement rate factor.
        public static float GetMovementRateFactor(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMovementRateFactor");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopFloat();
        }

        // / @brief Sets the creature's current movement rate factor.
        // / @note Base movement rate factor is 1.0.
        // / @param creature The creature object.
        // / @param rate The rate to set.
        public static void SetMovementRateFactor(uint creature, float rate)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetMovementRateFactor");
            Internal.NativeFunctions.nwnxPushFloat(rate);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Returns the creature's current movement type
        // / @param creature The creature object.
        // / @return An NWNX_CREATURE_MOVEMENT_TYPE_* constant.
        public static int GetMovementType(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetMovementType");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the maximum movement rate a creature can have while walking (not running)
        // / @remark This allows a creature with movement speed enhancements to walk at a normal rate.
        // / @param creature The creature object.
        // / @param fWalkRate The walk rate to apply. Setting the value to -1.0 will remove the cap.
        // / Default value is 2000.0, which is the base human walk speed.
        public static void SetWalkRateCap(uint creature, float fWalkRate = 2000.0f)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetWalkRateCap");
            Internal.NativeFunctions.nwnxPushFloat(fWalkRate);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's raw good/evil alignment value.
        // / @param creature The creature object.
        // / @param value The value to set.
        public static void SetAlignmentGoodEvil(uint creature, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetAlignmentGoodEvil");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's raw law/chaos alignment value.
        // / @param creature The creature object.
        // / @param value The value to set.
        public static void SetAlignmentLawChaos(uint creature, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetAlignmentLawChaos");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets one of creature's cleric domains.
        // / @param creature The creature object.
        // / @param index The first or second domain.
        // / @deprecated Use GetDomain(). This will be removed in future NWNX releases.
        public static int GetClericDomain(uint creature, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetClericDomain");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets one of creature's cleric domains.
        // / @param creature The creature object.
        // / @param index The first or second domain.
        // / @param domain The domain constant to set.
        // / @deprecated Use NWNX_Creature_SetDomain(). This will be removed in future NWNX releases.
        public static void SetClericDomain(uint creature, int index, int domain)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetClericDomain");
            Internal.NativeFunctions.nwnxPushInt(domain);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the soundset index for creature.
        // / @param creature The creature object.
        // / @return The soundset used by the creature.
        public static int GetSoundset(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetSoundset");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set the soundset index for creature.
        // / @param creature The creature object.
        // / @param soundset The soundset index.
        public static void SetSoundset(uint creature, int soundset)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSoundset");
            Internal.NativeFunctions.nwnxPushInt(soundset);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set the base ranks in a skill for creature
        // / @param creature The creature object.
        // / @param skill The skill id.
        // / @param rank The value to set as the skill rank.
        public static void SetSkillRank(uint creature, int skill, int rank)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSkillRank");
            Internal.NativeFunctions.nwnxPushInt(rank);
            Internal.NativeFunctions.nwnxPushInt(skill);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set the class ID in a particular position for a creature.
        // / @param creature The creature object.
        // / @param position Should be 0, 1, or 2 depending on how many classes the creature
        // / has and which is to be modified.
        // / @param classID A valid ID number in classes.2da and between 0 and 255.
        public static void SetClassByPosition(uint creature, int position, int classID)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetClassByPosition");
            Internal.NativeFunctions.nwnxPushInt(classID);
            Internal.NativeFunctions.nwnxPushInt(position);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set the level at the given position for a creature.
        // / @note A creature should already have a class in that position.
        // / @param creature The creature object.
        // / @param position Should be 0, 1, or 2 depending on how many classes the creature
        // / has and which is to be modified.
        // / @param level The level to set.
        public static void SetLevelByPosition(uint creature, int position, int level)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetLevelByPosition");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushInt(position);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's base attack bonus (BAB).
        // / @note Modifying the BAB will also affect the creature's attacks per round and its
        // / eligibility for feats, prestige classes, etc.
        // / @param creature The creature object.
        // / @param bab The BAB value. Should be between 0 and 254. Setting BAB to 0 will cause the
        // / creature to revert to its original BAB based on its classes and levels. A creature can
        // / never have an actual BAB of zero.
        // / @remark The base game has a function @nwn{SetBaseAttackBonus}, which actually sets
        // / the bonus attacks per round for a creature, not the BAB.
        public static void SetBaseAttackBonus(uint creature, int bab)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetBaseAttackBonus");
            Internal.NativeFunctions.nwnxPushInt(bab);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the creatures current attacks per round (using equipped weapon).
        // / @param creature The creature object.
        // / @param bBaseAPR If TRUE, will return the base attacks per round, based on BAB and
        // / equipped weapons, regardless of overrides set by calls to @nwn{SetBaseAttackBonus} builtin function.
        // / @return The attacks per round.
        public static int GetAttacksPerRound(uint creature, int bBaseAPR = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetAttacksPerRound");
            Internal.NativeFunctions.nwnxPushInt(bBaseAPR);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the creature gender.
        // / @param creature The creature object.
        // / @param gender The GENDER_ constant.
        public static void SetGender(uint creature, int gender)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetGender");
            Internal.NativeFunctions.nwnxPushInt(gender);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Restore all creature feat uses.
        // / @param creature The creature object.
        public static void RestoreFeats(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RestoreFeats");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Restore all creature special ability uses.
        // / @param creature The creature object.
        public static void RestoreSpecialAbilities(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RestoreSpecialAbilities");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Restore all creature spells per day for given level.
        // / @param creature The creature object.
        // / @param level The level to restore. If -1, all spells are restored.
        public static void RestoreSpells(uint creature, int level = -1)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RestoreSpells");
            Internal.NativeFunctions.nwnxPushInt(level);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Restore uses for all items carried by the creature.
        // / @param creature The creature object.
        public static void RestoreItems(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "RestoreItems");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the creature size.
        // / @param creature The creature object.
        // / @param size Use CREATURE_SIZE_* constants.
        public static void SetSize(uint creature, int size)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSize");
            Internal.NativeFunctions.nwnxPushInt(size);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the creature's remaining unspent skill points.
        // / @param creature The creature object.
        // / @return The remaining unspent skill points.
        public static int GetSkillPointsRemaining(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetSkillPointsRemaining");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the creature's remaining unspent skill points.
        // / @param creature The creature object.
        // / @param skillpoints The value to set.
        public static void SetSkillPointsRemaining(uint creature, int skillpoints)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSkillPointsRemaining");
            Internal.NativeFunctions.nwnxPushInt(skillpoints);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the creature's racial type
        // / @param creature The creature object.
        // / @param racialtype The racial type to set.
        public static void SetRacialType(uint creature, int racialtype)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetRacialType");
            Internal.NativeFunctions.nwnxPushInt(racialtype);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the creature's gold without sending a feedback message
        // / @param creature The creature object.
        // / @param gold The amount of gold to set for their creature.
        public static void SetGold(uint creature, int gold)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetGold");
            Internal.NativeFunctions.nwnxPushInt(gold);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets corpse decay time in milliseconds
        // / @param creature The creature object.
        // / @param nDecayTime The corpse decay time.
        public static void SetCorpseDecayTime(uint creature, int nDecayTime)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCorpseDecayTime");
            Internal.NativeFunctions.nwnxPushInt(nDecayTime);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the creature's base save.
        // / @param creature The creature object.
        // / @param which One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL
        // / @return The base save value.
        // / @note This will include any modifiers set in the toolset.
        public static int GetBaseSavingThrow(uint creature, int which)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetBaseSavingThrow");
            Internal.NativeFunctions.nwnxPushInt(which);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the creature's base save.
        // / @param creature The creature object.
        // / @param which One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL
        // / @param value The base save value.
        public static void SetBaseSavingThrow(uint creature, int which, int value)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetBaseSavingThrow");
            Internal.NativeFunctions.nwnxPushInt(value);
            Internal.NativeFunctions.nwnxPushInt(which);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Add levels of class to the creature, bypassing all validation
        // / @param creature The creature object.
        // / @param class The class id.
        // / @param count The amount of levels of class to add.
        // / @note This will not work on player characters.
        public static void LevelUp(uint creature, int @class, int count = 1)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "LevelUp");
            Internal.NativeFunctions.nwnxPushInt(count);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Remove last levels from a creature.
        // / @param creature The creature object.
        // / @param count The amount of levels to decrement.
        // / @note This will not work on player characters.
        public static void LevelDown(uint creature, int count = 1)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "LevelDown");
            Internal.NativeFunctions.nwnxPushInt(count);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the creature's challenge rating
        // / @param creature The creature object.
        // / @param fCR The challenge rating.
        public static void SetChallengeRating(uint creature, float fCR)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetChallengeRating");
            Internal.NativeFunctions.nwnxPushFloat(fCR);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Returns the creature's highest attack bonus based on its own stats.
        // / @note AB vs. Type and +AB on Gauntlets are excluded
        // / @param creature The creature object.
        // / @param isMelee
        // /   * TRUE: Get Melee/Unarmed Attack Bonus
        // /   * FALSE: Get Ranged Attack Bonus
        // /   * -1: Get Attack Bonus depending on the weapon creature has equipped in its right hand
        // /       Defaults to Melee Attack Bonus if weapon is invalid or no weapon
        // / @param isTouchAttack If the attack was a touch attack.
        // / @param isOffhand If the attack was with the offhand.
        // / @param includeBaseAttackBonus Should the result include the base attack bonus.
        // / @return The highest attack bonus.
        public static int GetAttackBonus(uint creature, int isMelee = -1, int isTouchAttack = NWScript.FALSE, int isOffhand = NWScript.FALSE, int includeBaseAttackBonus = NWScript.TRUE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetAttackBonus");
            Internal.NativeFunctions.nwnxPushInt(includeBaseAttackBonus);
            Internal.NativeFunctions.nwnxPushInt(isOffhand);
            Internal.NativeFunctions.nwnxPushInt(isTouchAttack);
            Internal.NativeFunctions.nwnxPushInt(isMelee);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get highest level version of feat possessed by creature.
        // / @remark For feats that increment in power, for example, barbarian rage.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @return The highest level version of the feat.
        public static int GetHighestLevelOfFeat(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetHighestLevelOfFeat");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get feat remaining uses.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @return The amount of remaining uses.
        public static int GetFeatRemainingUses(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatRemainingUses");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get feat total uses.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @return The total uses.
        public static int GetFeatTotalUses(uint creature, int feat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFeatTotalUses");
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set feat remaining uses.
        // / @param creature The creature object.
        // / @param feat The feat id.
        // / @param uses The amount of remaining uses.
        public static void SetFeatRemainingUses(uint creature, int feat, int uses)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetFeatRemainingUses");
            Internal.NativeFunctions.nwnxPushInt(uses);
            Internal.NativeFunctions.nwnxPushInt(feat);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get total effect bonus
        // / @remark This exposes the actual bonus value beyond a player's base scores to attack, damage bonus, saves,
        // / skills, ability scores, and touch attack provided by spells, equipment, potions etc.
        // / @param creature The creature object.
        // / @param bonusType A @ref bonus_types "Bonus Type"
        // / @param target A target object. Used to calculate bonuses versus specific races, alignments, etc.
        // / @param isElemental If a damage bonus includes elemental damage.
        // / @param isForceMax If the bonus should return the maximum possible.
        // / @param savetype A SAVING_THROW_* constant.
        // / @param saveSpecificType A SAVING_THROW_TYPE_* constant.
        // / @param skill A skill id.
        // / @param abilityScore An ABILITY_* constant.
        // / @param isOffhand Whether the attack is an offhand attack.
        // / @return The bonus value.
        public static int GetTotalEffectBonus(uint creature, int bonusType = NWNX_CREATURE_BONUS_TYPE_ATTACK, uint target = NWScript.OBJECT_INVALID, int isElemental = 0, int isForceMax = 0, int savetype = -1, int saveSpecificType = -1, int skill = -1, int abilityScore = -1, int isOffhand = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetTotalEffectBonus");
            Internal.NativeFunctions.nwnxPushInt(isOffhand);
            Internal.NativeFunctions.nwnxPushInt(abilityScore);
            Internal.NativeFunctions.nwnxPushInt(skill);
            Internal.NativeFunctions.nwnxPushInt(saveSpecificType);
            Internal.NativeFunctions.nwnxPushInt(savetype);
            Internal.NativeFunctions.nwnxPushInt(isForceMax);
            Internal.NativeFunctions.nwnxPushInt(isElemental);
            Internal.NativeFunctions.nwnxPushObject(target);
            Internal.NativeFunctions.nwnxPushInt(bonusType);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set the original first or last name of creature
        // / @param creature The creature object.
        // / @param name The name to give the creature.
        // / @param isLastName TRUE to change their last name, FALSE for first.
        // / @note For PCs this will persist to the .bic file if saved. Requires a relog to update.
        public static void SetOriginalName(uint creature, string name, int isLastName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetOriginalName");
            Internal.NativeFunctions.nwnxPushInt(isLastName);
            Internal.NativeFunctions.nwnxPushString(name);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the original first or last name of creature
        // / @param creature The creature object.
        // / @param isLastName TRUE to get last name, FALSE for first name.
        // / @return The original first or last name of the creature.
        public static string GetOriginalName(uint creature, int isLastName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetOriginalName");
            Internal.NativeFunctions.nwnxPushInt(isLastName);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Set creature's spell resistance
        // / @param creature The creature object.
        // / @param sr The spell resistance.
        // / @warning This setting will be overwritten by effects and once those effects fade the old setting (typically 0) will be set.
        public static void SetSpellResistance(uint creature, int sr)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSpellResistance");
            Internal.NativeFunctions.nwnxPushInt(sr);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's animal companion creature type
        // / @param creature The master creature object.
        // / @param type The type from ANIMAL_COMPANION_CREATURE_TYPE_*.
        public static void SetAnimalCompanionCreatureType(uint creature, int type)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetAnimalCompanionCreatureType");
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's familiar creature type
        // / @param creature The master creature object.
        // / @param type The type from FAMILIAR_CREATURE_TYPE_*.
        public static void SetFamiliarCreatureType(uint creature, int type)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetFamiliarCreatureType");
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's animal companion's name
        // / @param creature The master creature object.
        // / @param name The name to give their animal companion.
        public static void SetAnimalCompanionName(uint creature, string name)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetAnimalCompanionName");
            Internal.NativeFunctions.nwnxPushString(name);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set creature's familiar's name
        // / @param creature The master creature object.
        // / @param name The name to give their familiar.
        public static void SetFamiliarName(uint creature, string name)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetFamiliarName");
            Internal.NativeFunctions.nwnxPushString(name);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get whether the creature can be disarmed.
        // / @param creature The creature object.
        // / @return TRUE if the creature can be disarmed.
        public static int GetDisarmable(uint creature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetDisarmable");
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set whether a creature can be disarmed.
        // / @param creature The creature object.
        // / @param disarmable Set to TRUE if the creature can be disarmed.
        public static void SetDisarmable(uint creature, int disarmable)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetDisarmable");
            Internal.NativeFunctions.nwnxPushInt(disarmable);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets one of creature's domains.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param index The first or second domain.
        // / @deprecated Use GetDomain(). This will be removed in future NWNX releases.
        public static int GetDomain(uint creature, int @class, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetDomain");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets one of creature's domains.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param index The first or second domain.
        // / @param domain The domain constant to set.
        public static void SetDomain(uint creature, int @class, int index, int domain)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetDomain");
            Internal.NativeFunctions.nwnxPushInt(domain);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the creature's specialist school.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @deprecated Use GetSpecialization(). This will be removed in future NWNX releases.
        public static int GetSpecialization(uint creature, int @class)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetSpecialization");
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets creature's specialist school.
        // / @param creature The creature object.
        // / @param class The class id from classes.2da. (Not class index 0-2)
        // / @param school The school constant.
        public static void SetSpecialization(uint creature, int @class, int school)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetSpecialization");
            Internal.NativeFunctions.nwnxPushInt(school);
            Internal.NativeFunctions.nwnxPushInt(@class);
            Internal.NativeFunctions.nwnxPushObject(creature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets oCreatures faction to be the faction with id nFactionId.
        // / @param oCreature The creature.
        // / @param nFactionId The faction id we want the creature to join.
        public static void SetFaction(uint oCreature, int nFactionId)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetFaction");
            Internal.NativeFunctions.nwnxPushInt(nFactionId);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the faction id from oCreature
        // / @param oCreature the creature we wish to query against
        // / @return faction id as an integer, -1 when used against invalid creature or invalid object.
        public static int GetFaction(uint oCreature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFaction");
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get whether a creature is flat-footed.
        // / @param The creature object.
        // / @return TRUE if the creature is flat-footed.
        public static int GetFlatFooted(uint oCreature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetFlatFooted");
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Serialize oCreature's quickbar to a base64 string
        // / @param oCreature The creature.
        // / @return A base64 string representation of oCreature's quickbar.
        public static string SerializeQuickbar(uint oCreature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SerializeQuickbar");
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Deserialize sSerializedQuickbar for oCreature
        // / @param oCreature The creature.
        // / @param sSerializedQuickbar A base64 string of a quickbar
        // / @return TRUE on success
        public static int DeserializeQuickbar(uint oCreature, string sSerializedQuickbar)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "DeserializeQuickbar");
            Internal.NativeFunctions.nwnxPushString(sSerializedQuickbar);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets a caster level modifier for oCreature
        // / @param oCreature the target creature
        // / @param nClass the class that this modifier will apply to
        // / @param nModifier the modifier to apply
        // / @param bPersist whether the modifier should be persisted to the .bic file if applicable
        public static void SetCasterLevelModifier(uint oCreature, int nClass, int nModifier, int bPersist = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCasterLevelModifier");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nModifier);
            Internal.NativeFunctions.nwnxPushInt(nClass);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the current caster level modifier for oCreature
        // / @param oCreature the target creature
        // / @param nClass the creature caster class
        // / @return the current caster level modifier for the creature
        public static int GetCasterLevelModifier(uint oCreature, int nClass)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetCasterLevelModifier");
            Internal.NativeFunctions.nwnxPushInt(nClass);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets a caster level override for oCreature
        // / @param oCreature the target creature
        // / @param nClass the class that this modifier will apply to
        // / @param nCasterLevel the caster level override to apply
        // / @param bPersist whether the override should be persisted to the .bic file if applicable
        public static void SetCasterLevelOverride(uint oCreature, int nClass, int nCasterLevel, int bPersist = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCasterLevelOverride");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nCasterLevel);
            Internal.NativeFunctions.nwnxPushInt(nClass);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the current caster level override for oCreature
        // / @param oCreature the target creature
        // / @param nClass the creature caster class
        // / @return the current caster level override for the creature or -1 if not set
        public static int GetCasterLevelOverride(uint oCreature, int nClass)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetCasterLevelOverride");
            Internal.NativeFunctions.nwnxPushInt(nClass);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Move a creature to limbo.
        // / @param The creature object.
        public static void JumpToLimbo(uint oCreature)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "JumpToLimbo");
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the critical hit multiplier modifier for the creature
        // / @param oCreature The target creature
        // / @param nModifier The modifier to apply
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @param bPersist Whether the modifier should persist to .bic file if applicable
        // / @note Persistence is activated each server reset by first use of either 'SetCriticalMultiplier*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
        public static void SetCriticalMultiplierModifier(uint oCreature, int nModifier, int nHand = 0, int bPersist = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCriticalMultiplierModifier");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushInt(nModifier);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the critical hit multiplier modifier for the Creature
        // / @param oCreature The target creature
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @return the current critical hit multiplier modifier for the creature
        public static int GetCriticalMultiplierModifier(uint oCreature, int nHand = 0)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetCriticalMultiplierModifier");
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the critical hit multiplier override for the creature.
        // / @param oCreature The target creature
        // / @param nOverride The override value to apply. -1 to clear override.
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @param bPersist whether the modifier should be persisted to the .bic file if applicable
        // / @note Persistence is activated each server reset by first use of either 'SetCriticalMultiplier*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
        public static void SetCriticalMultiplierOverride(uint oCreature, int nOverride, int nHand = 0, int bPersist = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCriticalMultiplierOverride");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushInt(nOverride);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the critical hit multiplier override for the Creature
        // / @param oCreature The target creature
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @return the current critical hit multiplier override for the creature. No override == -1
        public static int GetCriticalMultiplierOverride(uint oCreature, int nHand = 0)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetCriticalMultiplierOverride");
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the critical hit range modifier for the creature.
        // / @param oCreature The target creature
        // / @param nModifier The modifier to apply. Positive modifiers reduce critical chance. (I.e. From 18-20, a +1 results in crit range of 19-20)
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @param bPersist whether the modifier should be persisted to the .bic file if applicable
        // / @note Persistence is activated each server reset by first use of either 'SetCriticalRange*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
        public static void SetCriticalRangeModifier(uint oCreature, int nModifier, int nHand = 0, int bPersist = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCriticalRangeModifier");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushInt(nModifier);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the critical hit range modifier for the creature.
        // / @param oCreature The target creature
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @return the current critical hit range modifier for the creature
        public static int GetCriticalRangeModifier(uint oCreature, int nHand = 0)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetCriticalRangeModifier");
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets the critical hit range Override for the creature.
        // / @param oCreature The target creature
        // / @param nOverride The new minimum roll to crit. i.e nOverride of 15 results in crit range of 15-20. -1 to clear override.
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @param bPersist whether the modifier should be persisted to the .bic file if applicable
        // / @note Persistence is activated each server reset by first use of either 'SetCriticalRange*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
        public static void SetCriticalRangeOverride(uint oCreature, int nOverride, int nHand = 0, int bPersist = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "SetCriticalRangeOverride");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushInt(nOverride);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the critical hit range Override for the creature.
        // / @param oCreature The target creature
        // / @param nHand 0 for all attacks, 1 for Mainhand, 2 for Offhand
        // / @return the current critical hit range override for the creature. No override == -1.
        public static int GetCriticalRangeOverride(uint oCreature, int nHand = 0)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "GetCriticalRangeOverride");
            Internal.NativeFunctions.nwnxPushInt(nHand);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Add oAssociate as nAssociateType to oCreature
        // / @warning Only basic checks are done so care must be taken when using this function
        // / @param oCreature The creature to add oAssociate to
        // / @param oAssociate The associate, must be a NPC
        // / @param nAssociateType The associate type, one of ASSOCIATE_TYPE_*, except _NONE
        public static void AddAssociate(uint oCreature, uint oAssociate, int nAssociateType) 
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Creature, "AddAssociate");
            Internal.NativeFunctions.nwnxPushInt(nAssociateType);
            Internal.NativeFunctions.nwnxPushObject(oAssociate);
            Internal.NativeFunctions.nwnxPushObject(oCreature);
            Internal.NativeFunctions.nwnxCallFunction();
        }
        // / @}
    }

    public struct SpecialAbility
        {
            public int id;
            public int ready;
            public int level;
        }

        public struct MemorisedSpell
        {
            public int id;
            public int ready;
            public int meta;
            public int domain;
        }
}
