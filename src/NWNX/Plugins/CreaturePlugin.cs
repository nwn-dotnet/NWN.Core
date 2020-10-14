namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Creature)]
  public class CreaturePlugin
  {
    public const string NWNX_Creature = "NWNX_Creature";

    ///< @private
    /// @name Creature Movement Rates
    /// @anchor creature_movement_rates
    ///
    /// The various types of movement rates.
    /// @{
    public const int NWNX_CREATURE_MOVEMENT_RATE_PC = 0;
    public const int NWNX_CREATURE_MOVEMENT_RATE_IMMOBILE = 1;
    public const int NWNX_CREATURE_MOVEMENT_RATE_VERY_SLOW = 2;
    public const int NWNX_CREATURE_MOVEMENT_RATE_SLOW = 3;
    public const int NWNX_CREATURE_MOVEMENT_RATE_NORMAL = 4;
    public const int NWNX_CREATURE_MOVEMENT_RATE_FAST = 5;
    public const int NWNX_CREATURE_MOVEMENT_RATE_VERY_FAST = 6;
    public const int NWNX_CREATURE_MOVEMENT_RATE_DEFAULT = 7;
    public const int NWNX_CREATURE_MOVEMENT_RATE_DM_FAST = 8;

    /// @}
    /// @name Creature Movement Types
    /// @anchor creature_movement_types
    ///
    /// The various types of movement types.
    /// @{
    public const int NWNX_CREATURE_MOVEMENT_TYPE_STATIONARY = 0;
    public const int NWNX_CREATURE_MOVEMENT_TYPE_WALK = 1;
    public const int NWNX_CREATURE_MOVEMENT_TYPE_RUN = 2;
    public const int NWNX_CREATURE_MOVEMENT_TYPE_SIDESTEP = 3;
    public const int NWNX_CREATURE_MOVEMENT_TYPE_WALK_BACKWARDS = 4;

    /// @}
    /// @name Cleric Domains
    /// @anchor cleric_domains
    ///
    /// The clerical domains.
    /// @{
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

    /// @}
    /// @name Bonus Types
    /// @anchor bonus_types
    ///
    /// Used with NWNX_Creature_GetTotalEffectBonus() these are the types of temporary bonuses from effects.
    /// @{
    public const int NWNX_CREATURE_BONUS_TYPE_ATTACK = 1;
    public const int NWNX_CREATURE_BONUS_TYPE_DAMAGE = 2;
    public const int NWNX_CREATURE_BONUS_TYPE_SAVING_THROW = 3;
    public const int NWNX_CREATURE_BONUS_TYPE_ABILITY = 4;
    public const int NWNX_CREATURE_BONUS_TYPE_SKILL = 5;
    public const int NWNX_CREATURE_BONUS_TYPE_TOUCH_ATTACK = 6;

    /// @}
    /// @struct NWNX_Creature_SpecialAbility
    /// A creature special ability.
    /// @struct NWNX_Creature_MemorisedSpell
    /// A memorised spell structure.
    /// Gives the creature a feat.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// @remark Consider also using NWNX_Creature_AddFeatByLevel() to properly allocate the feat to a level
    public static void AddFeat(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "AddFeat");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gives the creature a feat assigned at a level
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <param name="level">The level they gained the feat.</param>
    /// @remark Adds the feat to the stat list at the provided level.
    public static void AddFeatByLevel(uint creature, int feat, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "AddFeatByLevel");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Removes a feat from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    public static void RemoveFeat(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RemoveFeat");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Determines if the creature knows a feat.
    /// @note This differs from native @nwn{GetHasFeat} which returns FALSE if the feat has no more uses per day.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>TRUE if the creature has the feat, regardless if they have any usages left or not.</returns>
    public static int GetKnowsFeat(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetKnowsFeat");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the count of feats learned at the provided level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The count of feats.</returns>
    public static int GetFeatCountByLevel(uint creature, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatCountByLevel");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the feat learned at the level and index.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetFeatCountByLevel().</param>
    /// <returns>The feat id at the index.</returns>
    public static int GetFeatByLevel(uint creature, int level, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatByLevel");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the creature level where the specified feat was learned.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The character level that the specified feat was granted, otherwise 0 if the creature does not have this feat.</returns>
    public static int GetFeatGrantLevel(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatGrantLevel");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the total number of feats known by creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The total feat count for the creature.</returns>
    public static int GetFeatCount(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatCount");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the creature's feat at a given index
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetFeatCount();</param>
    /// <returns>The feat id at the index.</returns>
    public static int GetFeatByIndex(uint creature, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatByIndex");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets if creature meets feat requirements.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>TRUE if creature meets all requirements to take given feat</returns>
    public static int GetMeetsFeatRequirements(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMeetsFeatRequirements");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the count of special abilities of the creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The total special ability count.</returns>
    public static int GetSpecialAbilityCount(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetSpecialAbilityCount");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the creature's special ability at a given index.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetSpecialAbilityCount().</param>
    /// <returns>An NWNX_Creature_SpecialAbility struct.</returns>
    public static SpecialAbility GetSpecialAbility(uint creature, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetSpecialAbility");
      SpecialAbility ability = default;
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      ability.level = VM.NWNX.StackPopInt();
      ability.ready = VM.NWNX.StackPopInt();
      ability.id = VM.NWNX.StackPopInt();
      return ability;
    }

    /// Adds a special ability to a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">An NWNX_Creature_SpecialAbility struct.</param>
    public static void AddSpecialAbility(uint creature, SpecialAbility ability)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "AddSpecialAbility");
      VM.NWNX.StackPush(ability.id);
      VM.NWNX.StackPush(ability.ready);
      VM.NWNX.StackPush(ability.level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Removes a special ability from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetSpecialAbilityCount().</param>
    public static void RemoveSpecialAbility(uint creature, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RemoveSpecialAbility");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets a special ability at the index for the creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetSpecialAbilityCount().</param>
    /// <param name="ability">An NWNX_Creature_SpecialAbility struct.</param>
    public static void SetSpecialAbility(uint creature, int index, SpecialAbility ability)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSpecialAbility");
      VM.NWNX.StackPush(ability.id);
      VM.NWNX.StackPush(ability.ready);
      VM.NWNX.StackPush(ability.level);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get the class taken by the creature at the provided level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The class id.</returns>
    public static int GetClassByLevel(uint creature, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetClassByLevel");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the base AC for the creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="ac">The base AC to set for the creature.</param>
    public static void SetBaseAC(uint creature, int ac)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetBaseAC");
      VM.NWNX.StackPush(ac);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get the base AC for the creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The base AC.</returns>
    public static int GetBaseAC(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetBaseAC");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the ability score of the creature to the provided value.
    /// @note Does not apply racial bonuses/penalties.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <param name="value">The value to set.</param>
    public static void SetRawAbilityScore(uint creature, int ability, int value)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetRawAbilityScore");
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(ability);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the ability score of the creature.
    /// @note Does not apply racial bonuses/penalties.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <returns>The ability score.</returns>
    public static int GetRawAbilityScore(uint creature, int ability)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetRawAbilityScore");
      VM.NWNX.StackPush(ability);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Adjusts the ability score of a creature.
    /// @note Does not apply racial bonuses/penalties.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <param name="modifier">The modifier value.</param>
    public static void ModifyRawAbilityScore(uint creature, int ability, int modifier)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "ModifyRawAbilityScore");
      VM.NWNX.StackPush(modifier);
      VM.NWNX.StackPush(ability);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the raw ability score a polymorphed creature had prior to polymorphing.
    /// @note For Strength, Dexterity and Constitution only.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <returns>The raw ability score.</returns>
    public static int GetPrePolymorphAbilityScore(uint creature, int ability)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetPrePolymorphAbilityScore");
      VM.NWNX.StackPush(ability);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the count of memorised spells for a creature's class at a level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The memorised spell count.</returns>
    public static int GetMemorisedSpellCountByLevel(uint creature, int @class, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMemorisedSpellCountByLevel");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the memorised spell at a class level's index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetMemorisedSpellCountByLevel().</param>
    /// <returns>An NWNX_Creature_MemorisedSpell() struct.</returns>
    public static MemorisedSpell GetMemorisedSpell(uint creature, int @class, int level, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMemorisedSpell");
      MemorisedSpell spell = default;
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      spell.domain = VM.NWNX.StackPopInt();
      spell.meta = VM.NWNX.StackPopInt();
      spell.ready = VM.NWNX.StackPopInt();
      spell.id = VM.NWNX.StackPopInt();
      return spell;
    }

    /// Sets the memorised spell at a class level's index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetMemorisedSpellCountByLevel().</param>
    /// <param name="spell">An NWNX_Creature_MemorisedSpell() struct.</param>
    public static void SetMemorisedSpell(uint creature, int @class, int level, int index, MemorisedSpell spell)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetMemorisedSpell");
      VM.NWNX.StackPush(spell.id);
      VM.NWNX.StackPush(spell.ready);
      VM.NWNX.StackPush(spell.meta);
      VM.NWNX.StackPush(spell.domain);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the remaining spell slots (innate casting) at a class level's index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The remaining spell slot count.</returns>
    public static int GetRemainingSpellSlots(uint creature, int @class, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetRemainingSpellSlots");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the remaining spell slots (innate casting) at a class level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="slots">The remaining spell slots to set.</param>
    public static void SetRemainingSpellSlots(uint creature, int @class, int level, int slots)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetRemainingSpellSlots");
      VM.NWNX.StackPush(slots);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the maximum spell slots (innate casting) at a class level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The maximum spell slot count.</returns>
    public static int GetMaxSpellSlots(uint creature, int @class, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMaxSpellSlots");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the known spell count (innate casting) at a class level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The known spell count.</returns>
    public static int GetKnownSpellCount(uint creature, int @class, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetKnownSpellCount");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the known spell at a class level's index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetKnownSpellCount().</param>
    /// <returns>The spell id.</returns>
    public static int GetKnownSpell(uint creature, int @class, int level, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetKnownSpell");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Add a spell to a creature's spellbook for class.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="spellId">The spell to remove.</param>
    public static void AddKnownSpell(uint creature, int @class, int level, int spellId)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "AddKnownSpell");
      VM.NWNX.StackPush(spellId);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Remove a spell from creature's spellbook for class.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="spellId">The spell to remove.</param>
    public static void RemoveKnownSpell(uint creature, int @class, int level, int spellId)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RemoveKnownSpell");
      VM.NWNX.StackPush(spellId);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Clear a specific spell from the creature's spellbook for class
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="spellId">The spell to clear.</param>
    public static void ClearMemorisedKnownSpells(uint creature, int @class, int spellId)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "ClearMemorisedKnownSpells");
      VM.NWNX.StackPush(spellId);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Clear the memorised spell of the creature for the class, level and index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 <= index < NWNX_Creature_GetMemorisedSpellCountByLevel().</param>
    public static void ClearMemorisedSpell(uint creature, int @class, int level, int index)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "ClearMemorisedSpell");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the maximum hit points for creature for level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The maximum hit points a creature can have for the class at the provided level.</returns>
    public static int GetMaxHitPointsByLevel(uint creature, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMaxHitPointsByLevel");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the maximum hit points for creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <param name="value">The amount to set the max hit points.</param>
    public static void SetMaxHitPointsByLevel(uint creature, int level, int value)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetMaxHitPointsByLevel");
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's movement rate.
    /// <param name="creature">The creature object.</param>
    /// <param name="rate">The movement rate.</param>
    public static void SetMovementRate(uint creature, int rate)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetMovementRate");
      VM.NWNX.StackPush(rate);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Returns the creature's current movement rate factor.
    /// @remark Base movement rate factor is 1.0.
    /// <param name="creature">The creature object.</param>
    /// <returns>The current movement rate factor.</returns>
    public static float GetMovementRateFactor(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMovementRateFactor");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Sets the creature's current movement rate factor.
    /// @note Base movement rate factor is 1.0.
    /// <param name="creature">The creature object.</param>
    /// <param name="rate">The rate to set.</param>
    public static void SetMovementRateFactor(uint creature, float factor)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetMovementRateFactor");
      VM.NWNX.StackPush(factor);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature's maximum movement rate cap.
    /// @note Default movement rate cap is 1.5.
    /// <param name="creature">The creature object.</param>
    /// <param name="cap">The cap to set.</param>
    public static void SetMovementRateFactorCap(uint creature, float cap)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetMovementRateFactorCap");
      VM.NWNX.StackPush(cap);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Returns the creature's current movement type
    /// <param name="creature">The creature object.</param>
    /// <returns>An NWNX_CREATURE_MOVEMENT_TYPE_* constant.</returns>
    public static int GetMovementType(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetMovementType");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the maximum movement rate a creature can have while walking (not running)
    /// @remark This allows a creature with movement speed enhancements to walk at a normal rate.
    /// <param name="creature">The creature object.</param>
    /// <param name="fWalkRate">The walk rate to apply. Setting the value to -1.0 will remove the cap.</param>
    /// Default value is 2000.0, which is the base human walk speed.
    public static void SetWalkRateCap(uint creature, float fWalkRate = 2000.0f)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetWalkRateCap");
      VM.NWNX.StackPush(fWalkRate);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's raw good/evil alignment value.
    /// <param name="creature">The creature object.</param>
    /// <param name="value">The value to set.</param>
    public static void SetAlignmentGoodEvil(uint creature, int value)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetAlignmentGoodEvil");
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's raw law/chaos alignment value.
    /// <param name="creature">The creature object.</param>
    /// <param name="value">The value to set.</param>
    public static void SetAlignmentLawChaos(uint creature, int value)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetAlignmentLawChaos");
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get the soundset index for creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The soundset used by the creature.</returns>
    public static int GetSoundset(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetSoundset");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the soundset index for creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="soundset">The soundset index.</param>
    public static void SetSoundset(uint creature, int soundset)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSoundset");
      VM.NWNX.StackPush(soundset);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set the base ranks in a skill for creature
    /// <param name="creature">The creature object.</param>
    /// <param name="skill">The skill id.</param>
    /// <param name="rank">The value to set as the skill rank.</param>
    public static void SetSkillRank(uint creature, int skill, int rank)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSkillRank");
      VM.NWNX.StackPush(rank);
      VM.NWNX.StackPush(skill);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set the class ID in a particular position for a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="position">Should be 0, 1, or 2 depending on how many classes the creature</param>
    /// has and which is to be modified.
    /// <param name="classID">A valid ID number in classes.2da and between 0 and 255.</param>
    public static void SetClassByPosition(uint creature, int position, int classID)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetClassByPosition");
      VM.NWNX.StackPush(classID);
      VM.NWNX.StackPush(position);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set the level at the given position for a creature.
    /// @note A creature should already have a class in that position.
    /// <param name="creature">The creature object.</param>
    /// <param name="position">Should be 0, 1, or 2 depending on how many classes the creature</param>
    /// has and which is to be modified.
    /// <param name="level">The level to set.</param>
    public static void SetLevelByPosition(uint creature, int position, int level)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetLevelByPosition");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(position);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's base attack bonus (BAB).
    /// @note Modifying the BAB will also affect the creature's attacks per round and its
    /// eligibility for feats, prestige classes, etc.
    /// <param name="creature">The creature object.</param>
    /// <param name="bab">The BAB value. Should be between 0 and 254. Setting BAB to 0 will cause the</param>
    /// creature to revert to its original BAB based on its classes and levels. A creature can
    /// never have an actual BAB of zero.
    /// @remark The base game has a function @nwn{SetBaseAttackBonus}, which actually sets
    /// the bonus attacks per round for a creature, not the BAB.
    public static void SetBaseAttackBonus(uint creature, int bab)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetBaseAttackBonus");
      VM.NWNX.StackPush(bab);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creatures current attacks per round (using equipped weapon).
    /// <param name="creature">The creature object.</param>
    /// <param name="bBaseAPR">If TRUE, will return the base attacks per round, based on BAB and</param>
    /// equipped weapons, regardless of overrides set by calls to @nwn{SetBaseAttackBonus} builtin function.
    /// <returns>The attacks per round.</returns>
    public static int GetAttacksPerRound(uint creature, int bBaseAPR = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetAttacksPerRound");
      VM.NWNX.StackPush(bBaseAPR);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the creature gender.
    /// <param name="creature">The creature object.</param>
    /// <param name="gender">The GENDER_ constant.</param>
    public static void SetGender(uint creature, int gender)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetGender");
      VM.NWNX.StackPush(gender);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore all creature feat uses.
    /// <param name="creature">The creature object.</param>
    public static void RestoreFeats(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RestoreFeats");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore all creature special ability uses.
    /// <param name="creature">The creature object.</param>
    public static void RestoreSpecialAbilities(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RestoreSpecialAbilities");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore all creature spells per day for given level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level to restore. If -1, all spells are restored.</param>
    public static void RestoreSpells(uint creature, int level = -1)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RestoreSpells");
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore uses for all items carried by the creature.
    /// <param name="creature">The creature object.</param>
    public static void RestoreItems(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "RestoreItems");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature size.
    /// <param name="creature">The creature object.</param>
    /// <param name="size">Use CREATURE_SIZE_* constants.</param>
    public static void SetSize(uint creature, int size)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSize");
      VM.NWNX.StackPush(size);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creature's remaining unspent skill points.
    /// <param name="creature">The creature object.</param>
    /// <returns>The remaining unspent skill points.</returns>
    public static int GetSkillPointsRemaining(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetSkillPointsRemaining");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the creature's remaining unspent skill points.
    /// <param name="creature">The creature object.</param>
    /// <param name="skillpoints">The value to set.</param>
    public static void SetSkillPointsRemaining(uint creature, int skillpoints)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSkillPointsRemaining");
      VM.NWNX.StackPush(skillpoints);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature's racial type
    /// <param name="creature">The creature object.</param>
    /// <param name="racialtype">The racial type to set.</param>
    public static void SetRacialType(uint creature, int racialtype)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetRacialType");
      VM.NWNX.StackPush(racialtype);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature's gold without sending a feedback message
    /// <param name="creature">The creature object.</param>
    /// <param name="gold">The amount of gold to set for their creature.</param>
    public static void SetGold(uint creature, int gold)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetGold");
      VM.NWNX.StackPush(gold);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets corpse decay time in milliseconds
    /// <param name="creature">The creature object.</param>
    /// <param name="nDecayTime">The corpse decay time.</param>
    public static void SetCorpseDecayTime(uint creature, int nDecayTime)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCorpseDecayTime");
      VM.NWNX.StackPush(nDecayTime);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creature's base save.
    /// <param name="creature">The creature object.</param>
    /// <param name="which">One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL</param>
    /// <returns>The base save value.</returns>
    /// @note This will include any modifiers set in the toolset.
    public static int GetBaseSavingThrow(uint creature, int which)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetBaseSavingThrow");
      VM.NWNX.StackPush(which);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the creature's base save.
    /// <param name="creature">The creature object.</param>
    /// <param name="which">One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL</param>
    /// <param name="value">The base save value.</param>
    public static void SetBaseSavingThrow(uint creature, int which, int value)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetBaseSavingThrow");
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(which);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Add levels of class to the creature, bypassing all validation
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id.</param>
    /// <param name="count">The amount of levels of class to add.</param>
    /// @note This will not work on player characters.
    public static void LevelUp(uint creature, int @class, int count = 1)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "LevelUp");
      VM.NWNX.StackPush(count);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Remove last levels from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="count">The amount of levels to decrement.</param>
    /// @note This will not work on player characters.
    public static void LevelDown(uint creature, int count = 1)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "LevelDown");
      VM.NWNX.StackPush(count);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature's challenge rating
    /// <param name="creature">The creature object.</param>
    /// <param name="fCR">The challenge rating.</param>
    public static void SetChallengeRating(uint creature, float fCR)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetChallengeRating");
      VM.NWNX.StackPush(fCR);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Returns the creature's highest attack bonus based on its own stats.
    /// @note AB vs. Type and +AB on Gauntlets are excluded
    /// <param name="creature">The creature object.</param>
    /// @param isMelee</param>
    ///   * TRUE: Get Melee/Unarmed Attack Bonus
    ///   * FALSE: Get Ranged Attack Bonus
    ///   * -1: Get Attack Bonus depending on the weapon creature has equipped in its right hand
    ///       Defaults to Melee Attack Bonus if weapon is invalid or no weapon
    /// <param name="isTouchAttack">If the attack was a touch attack.</param>
    /// <param name="isOffhand">If the attack was with the offhand.</param>
    /// <param name="includeBaseAttackBonus">Should the result include the base attack bonus.</param>
    /// <returns>The highest attack bonus.</returns>
    public static int GetAttackBonus(uint creature, int isMelee = -1, int isTouchAttack = NWScript.FALSE, int isOffhand = NWScript.FALSE, int includeBaseAttackBonus = NWScript.TRUE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetAttackBonus");
      if (isMelee==-1)
      {
        uint oWeapon = NWScript.GetItemInSlot(NWScript.INVENTORY_SLOT_RIGHTHAND, creature);
        if (NWScript.GetIsObjectValid(oWeapon) == NWScript.TRUE)
        {
          isMelee = NWScript.GetWeaponRanged(oWeapon);
        }
        else
        {
          isMelee = NWScript.TRUE;
        }
      }
      VM.NWNX.StackPush(includeBaseAttackBonus);
      VM.NWNX.StackPush(isOffhand);
      VM.NWNX.StackPush(isTouchAttack);
      VM.NWNX.StackPush(isMelee);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get highest level version of feat possessed by creature.
    /// @remark For feats that increment in power, for example, barbarian rage.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The highest level version of the feat.</returns>
    public static int GetHighestLevelOfFeat(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetHighestLevelOfFeat");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get feat remaining uses.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The amount of remaining uses.</returns>
    public static int GetFeatRemainingUses(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatRemainingUses");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get feat total uses.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The total uses.</returns>
    public static int GetFeatTotalUses(uint creature, int feat)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFeatTotalUses");
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set feat remaining uses.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <param name="uses">The amount of remaining uses.</param>
    public static void SetFeatRemainingUses(uint creature, int feat, int uses)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetFeatRemainingUses");
      VM.NWNX.StackPush(uses);
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get total effect bonus
    /// @remark This exposes the actual bonus value beyond a player's base scores to attack, damage bonus, saves,
    /// skills, ability scores, and touch attack provided by spells, equipment, potions etc.
    /// <param name="creature">The creature object.</param>
    /// <param name="bonusType">A @ref bonus_types "Bonus Type"</param>
    /// <param name="target">A target object. Used to calculate bonuses versus specific races, alignments, etc.</param>
    /// <param name="isElemental">If a damage bonus includes elemental damage.</param>
    /// <param name="isForceMax">If the bonus should return the maximum possible.</param>
    /// <param name="savetype">A SAVING_THROW_* constant.</param>
    /// <param name="saveSpecificType">A SAVING_THROW_TYPE_* constant.</param>
    /// <param name="skill">A skill id.</param>
    /// <param name="abilityScore">An ABILITY_* constant.</param>
    /// <param name="isOffhand">Whether the attack is an offhand attack.</param>
    /// <returns>The bonus value.</returns>
    public static int GetTotalEffectBonus(uint creature, int bonusType = NWNX_CREATURE_BONUS_TYPE_ATTACK, uint target = NWScript.OBJECT_INVALID, int isElemental = 0, int isForceMax = 0, int savetype = -1, int saveSpecificType = -1, int skill = -1, int abilityScore = -1, int isOffhand = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetTotalEffectBonus");
      VM.NWNX.StackPush(isOffhand);
      VM.NWNX.StackPush(abilityScore);
      VM.NWNX.StackPush(skill);
      VM.NWNX.StackPush(saveSpecificType);
      VM.NWNX.StackPush(savetype);
      VM.NWNX.StackPush(isForceMax);
      VM.NWNX.StackPush(isElemental);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(bonusType);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the original first or last name of creature
    /// <param name="creature">The creature object.</param>
    /// <param name="name">The name to give the creature.</param>
    /// <param name="isLastName">TRUE to change their last name, FALSE for first.</param>
    /// @note For PCs this will persist to the .bic file if saved. Requires a relog to update.
    public static void SetOriginalName(uint creature, string name, int isLastName)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetOriginalName");
      VM.NWNX.StackPush(isLastName);
      VM.NWNX.StackPush(name);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get the original first or last name of creature
    /// <param name="creature">The creature object.</param>
    /// <param name="isLastName">TRUE to get last name, FALSE for first name.</param>
    /// <returns>The original first or last name of the creature.</returns>
    public static string GetOriginalName(uint creature, int isLastName)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetOriginalName");
      VM.NWNX.StackPush(isLastName);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Set creature's spell resistance
    /// <param name="creature">The creature object.</param>
    /// <param name="sr">The spell resistance.</param>
    /// @warning This setting will be overwritten by effects and once those effects fade the old setting (typically 0) will be set.
    public static void SetSpellResistance(uint creature, int sr)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSpellResistance");
      VM.NWNX.StackPush(sr);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's animal companion creature type
    /// <param name="creature">The master creature object.</param>
    /// <param name="type">The type from ANIMAL_COMPANION_CREATURE_TYPE_*.</param>
    public static void SetAnimalCompanionCreatureType(uint creature, int type)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetAnimalCompanionCreatureType");
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's familiar creature type
    /// <param name="creature">The master creature object.</param>
    /// <param name="type">The type from FAMILIAR_CREATURE_TYPE_*.</param>
    public static void SetFamiliarCreatureType(uint creature, int type)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetFamiliarCreatureType");
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's animal companion's name
    /// <param name="creature">The master creature object.</param>
    /// <param name="name">The name to give their animal companion.</param>
    public static void SetAnimalCompanionName(uint creature, string name)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetAnimalCompanionName");
      VM.NWNX.StackPush(name);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature's familiar's name
    /// <param name="creature">The master creature object.</param>
    /// <param name="name">The name to give their familiar.</param>
    public static void SetFamiliarName(uint creature, string name)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetFamiliarName");
      VM.NWNX.StackPush(name);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get whether the creature can be disarmed.
    /// <param name="creature">The creature object.</param>
    /// <returns>TRUE if the creature can be disarmed.</returns>
    public static int GetDisarmable(uint creature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetDisarmable");
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set whether a creature can be disarmed.
    /// <param name="creature">The creature object.</param>
    /// <param name="disarmable">Set to TRUE if the creature can be disarmed.</param>
    public static void SetDisarmable(uint creature, int disarmable)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetDisarmable");
      VM.NWNX.StackPush(disarmable);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets one of creature's domains.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="index">The first or second domain.</param>
    /// @deprecated Use GetDomain(). This will be removed in future NWNX releases.
    public static int GetDomain(uint creature, int @class, int index)
    {
      NWScript.WriteTimestampedLogEntry("NWNX_Creature: GetDomain() is deprecated. Please use the basegame's GetDomain() instead");
      return VM.NWNX.StackPopInt();
    }

    /// Sets one of creature's domains.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="index">The first or second domain.</param>
    /// <param name="domain">The domain constant to set.</param>
    public static void SetDomain(uint creature, int @class, int index, int domain)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetDomain");
      VM.NWNX.StackPush(domain);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creature's specialist school.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// @deprecated Use GetSpecialization(). This will be removed in future NWNX releases.
    public static int GetSpecialization(uint creature, int @class)
    {
      NWScript.WriteTimestampedLogEntry("NWNX_Creature: GetSpecialization() is deprecated. Please use the basegame's GetSpecialization() instead");
      return VM.NWNX.StackPopInt();
    }

    /// Sets creature's specialist school.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="school">The school constant.</param>
    public static void SetSpecialization(uint creature, int @class, int school)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetSpecialization");
      VM.NWNX.StackPush(school);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets oCreatures faction to be the faction with id nFactionId.
    /// <param name="oCreature">The creature.</param>
    /// <param name="nFactionId">The faction id we want the creature to join.</param>
    public static void SetFaction(uint oCreature, int nFactionId)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetFaction");
      VM.NWNX.StackPush(nFactionId);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the faction id from oCreature
    /// <param name="oCreature">the creature we wish to query against</param>
    /// <returns>faction id as an integer, -1 when used against invalid creature or invalid object.</returns>
    public static int GetFaction(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFaction");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get whether a creature is flat-footed.
    /// <param name="oCreature">The creature object.</param>
    /// <returns>TRUE if the creature is flat-footed.</returns>
    public static int GetFlatFooted(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetFlatFooted");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Serialize oCreature's quickbar to a base64 string
    /// <param name="oCreature">The creature.</param>
    /// <returns>A base64 string representation of oCreature's quickbar.</returns>
    public static string SerializeQuickbar(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SerializeQuickbar");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Deserialize sSerializedQuickbar for oCreature
    /// <param name="oCreature">The creature.</param>
    /// <param name="sSerializedQuickbar">A base64 string of a quickbar</param>
    /// <returns>TRUE on success</returns>
    public static int DeserializeQuickbar(uint oCreature, string sSerializedQuickbar)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "DeserializeQuickbar");
      VM.NWNX.StackPush(sSerializedQuickbar);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets a caster level modifier for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the class that this modifier will apply to</param>
    /// <param name="nModifier">the modifier to apply</param>
    /// <param name="bPersist">whether the modifier should be persisted to the .bic file if applicable</param>
    public static void SetCasterLevelModifier(uint oCreature, int nClass, int nModifier, int bPersist = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCasterLevelModifier");
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nModifier);
      VM.NWNX.StackPush(nClass);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the current caster level modifier for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the creature caster class</param>
    /// <returns>the current caster level modifier for the creature</returns>
    public static int GetCasterLevelModifier(uint oCreature, int nClass)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetCasterLevelModifier");
      VM.NWNX.StackPush(nClass);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets a caster level override for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the class that this modifier will apply to</param>
    /// <param name="nCasterLevel">the caster level override to apply</param>
    /// <param name="bPersist">whether the override should be persisted to the .bic file if applicable</param>
    public static void SetCasterLevelOverride(uint oCreature, int nClass, int nCasterLevel, int bPersist = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCasterLevelOverride");
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nCasterLevel);
      VM.NWNX.StackPush(nClass);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the current caster level override for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the creature caster class</param>
    /// <returns>the current caster level override for the creature or -1 if not set</returns>
    public static int GetCasterLevelOverride(uint oCreature, int nClass)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetCasterLevelOverride");
      VM.NWNX.StackPush(nClass);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Move a creature to limbo.
    /// <param name="oCreature">The creature object.</param>
    public static void JumpToLimbo(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "JumpToLimbo");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Sets the critical hit multiplier modifier for the creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nModifier">The modifier to apply</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file if applicable</param>
    /// @note Persistence is activated each server reset by first use of either 'SetCriticalMultiplier*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalMultiplierModifier(uint oCreature, int nModifier, int nHand = 0, int bPersist = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCriticalMultiplierModifier");
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nModifier);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the critical hit multiplier modifier for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <returns>the current critical hit multiplier modifier for the creature</returns>
    public static int GetCriticalMultiplierModifier(uint oCreature, int nHand = 0)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetCriticalMultiplierModifier");
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the critical hit multiplier override for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nOverride">The override value to apply. -1 to clear override.</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">whether the modifier should be persisted to the .bic file if applicable</param>
    /// @note Persistence is activated each server reset by first use of either 'SetCriticalMultiplier*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalMultiplierOverride(uint oCreature, int nOverride, int nHand = 0, int bPersist = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCriticalMultiplierOverride");
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nOverride);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the critical hit multiplier override for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <returns>the current critical hit multiplier override for the creature. No override == -1</returns>
    public static int GetCriticalMultiplierOverride(uint oCreature, int nHand = 0)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetCriticalMultiplierOverride");
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the critical hit range modifier for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nModifier">The modifier to apply. Positive modifiers reduce critical chance. (I.e. From 18-20, a +1 results in crit range of 19-20)</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">whether the modifier should be persisted to the .bic file if applicable</param>
    /// @note Persistence is activated each server reset by first use of either 'SetCriticalRange*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalRangeModifier(uint oCreature, int nModifier, int nHand = 0, int bPersist = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCriticalRangeModifier");
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nModifier);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the critical hit range modifier for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <returns>the current critical hit range modifier for the creature</returns>
    public static int GetCriticalRangeModifier(uint oCreature, int nHand = 0)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetCriticalRangeModifier");
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the critical hit range Override for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nOverride">The new minimum roll to crit. i.e nOverride of 15 results in crit range of 15-20. -1 to clear override.</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">whether the modifier should be persisted to the .bic file if applicable</param>
    /// @note Persistence is activated each server reset by first use of either 'SetCriticalRange*' functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalRangeOverride(uint oCreature, int nOverride, int nHand = 0, int bPersist = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetCriticalRangeOverride");
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nOverride);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Sets the critical hit range Override for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <returns>the current critical hit range override for the creature. No override == -1.</returns>
    public static int GetCriticalRangeOverride(uint oCreature, int nHand = 0)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetCriticalRangeOverride");
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Add oAssociate as nAssociateType to oCreature
    /// @warning Only basic checks are done so care must be taken when using this function
    /// <param name="oCreature">The creature to add oAssociate to</param>
    /// <param name="oAssociate">The associate, must be a NPC</param>
    /// <param name="nAssociateType">The associate type, one of ASSOCIATE_TYPE_*, except _NONE</param>
    public static void AddAssociate(uint oCreature, uint oAssociate, int nAssociateType)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "AddAssociate");
      VM.NWNX.StackPush(nAssociateType);
      VM.NWNX.StackPush(oAssociate);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Set whether an effect icon is flashing or not.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nIconId">The icon id, see effecticons.2da.</param>
    /// <param name="bFlashing">TRUE for flashing, FALSE for not flashing.</param>
    public static void SetEffectIconFlashing(uint oCreature, int nIconId, int bFlashing)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetEffectIconFlashing");
      VM.NWNX.StackPush(bFlashing);
      VM.NWNX.StackPush(nIconId);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Override the damage level of oCreature.
    /// @note Damage levels are the damage state under a creature's name, for example: 'Near Death'
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nDamageLevel">A damage level, see damagelevels.2da. Allowed values: 0-255 or -1 to remove the override.</param>
    public static void OverrideDamageLevel(uint oCreature, int nDamageLevel)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "OverrideDamageLevel");
      VM.NWNX.StackPush(nDamageLevel);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Set the encounter source of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="oEncounter">The source encounter</param>
    public static void SetEncounter(uint oCreature, uint oEncounter)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetEncounter");
      VM.NWNX.StackPush(oEncounter);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get the encounter source of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>The encounter, OBJECT_INVALID if not part of an encounter or on error</returns>
    public static uint GetEncounter(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetEncounter");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Get if oCreature is currently bartering.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>TRUE if oCreature is bartering, FALSE if not or on error.</returns>
    public static int GetIsBartering(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetIsBartering");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets caster level for the last item used. Use in a spellhook or spell event before to set caster level for any spells cast from the item.
    /// <param name="oCreature">the creature who used the item.</param>
    /// <param name="nCasterLvl">the desired caster level.</param>
    public static void SetLastItemCasterLevel(uint oCreature, int nCasterLvl)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetLastItemCasterLevel");
      VM.NWNX.StackPush(nCasterLvl);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the caster level of the last item used.
    /// <param name="oCreature">the creature who used the item.</param>
    /// <returns>returns the creatures last used item's level.</returns>
    public static int GetLastItemCasterLevel(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetLastItemCasterLevel");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the Armor classed of attacked against versus
    /// <param name="oAttacked">The one being attacked</param>
    /// <param name="oVersus">The one doing the attacking</param>
    /// <param name="nTouch">TRUE for touch attacks</param>
    /// <returns>-255 on Error, Flat footed AC if oVersus is invalid or the Attacked AC versus oVersus.</returns>
    public static int GetArmorClassVersus(uint oAttacked, uint oVersus, int nTouch = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetArmorClassVersus");
      VM.NWNX.StackPush(nTouch);
      VM.NWNX.StackPush(oVersus);
      VM.NWNX.StackPush(oAttacked);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the current walk animation of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>-1 on Error, otherwise the walk animation number</returns>
    public static int GetWalkAnimation(uint oCreature)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "GetWalkAnimation");
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the current walk animation of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nAnimation">The walk animation number.</param>
    public static void SetWalkAnimation(uint oCreature, int nAnimation)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetWalkAnimation");
      VM.NWNX.StackPush(nAnimation);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Changes the attack modifier depending on the dice roll. Used to skip autofail on 1 and autosucceed on 20 as well.
    /// <param name="oCreature">The attacking creature, use OBJECT_INVALID for all.</param>
    /// <param name="nRoll">The dice roll to modify.</param>
    /// <param name="nModifier">The modifier to the attack, use 0 to turn off autofail for 1/autosucceed for 20 with no attack modifier value.</param>
    public static void SetAttackRollOverride(uint oCreature, int nRoll, int nModifier)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetAttackRollOverride");
      VM.NWNX.StackPush(nModifier);
      VM.NWNX.StackPush(nRoll);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Works like the tweak but can be turned on and off for all creatures or single ones.
    /// <param name="oCreature">The parrying creature, use OBJECT_INVALID for all.</param>
    /// <param name="bParry">TRUE to parry all attacks.</param>
    /// @note Use this command on_module_load instead of the NWNX_TWEAKS_PARRY_ALL_ATTACKS tweak if using NWNX_Creature_SetAttackRollOverride()
    public static void SetParryAllAttacks(uint oCreature, int bParry)
    {
      VM.NWNX.SetFunction(NWNX_Creature, "SetParryAllAttacks");
      VM.NWNX.StackPush(bParry);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// @}
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
