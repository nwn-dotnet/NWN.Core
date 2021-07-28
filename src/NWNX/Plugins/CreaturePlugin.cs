using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Creature)]
  public class CreaturePlugin
  {
    public const string NWNX_Creature = "NWNX_Creature";

    ///&lt; @private
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

    // @}
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

    // @}
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

    // @}
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

    // @}
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
      const string sFunc = "AddFeat";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "AddFeatByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "RemoveFeat";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Removes the creature a feat assigned at a level
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <param name="level">The level they gained the feat.</param>
    /// @remark Removes the feat from the stat list at the provided level. Does not remove the feat from the creature, use
    /// NWNX_Creature_RemoveFeat for this.
    public static void RemoveFeatByLevel(uint creature, int feat, int level)
    {
      const string sFunc = "RemoveFeatByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(level);
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
      const string sFunc = "GetKnowsFeat";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetFeatCountByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the feat learned at the level and index.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetFeatCountByLevel().</param>
    /// <returns>The feat id at the index.</returns>
    public static int GetFeatByLevel(uint creature, int level, int index)
    {
      const string sFunc = "GetFeatByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetFeatGrantLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetFeatCount";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the creature&apos;s feat at a given index
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetFeatCount();</param>
    /// <returns>The feat id at the index.</returns>
    public static int GetFeatByIndex(uint creature, int index)
    {
      const string sFunc = "GetFeatByIndex";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetMeetsFeatRequirements";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetSpecialAbilityCount";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the creature&apos;s special ability at a given index.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetSpecialAbilityCount().</param>
    /// <returns>An NWNX_Creature_SpecialAbility struct.</returns>
    public static SpecialAbility GetSpecialAbility(uint creature, int index)
    {
      const string sFunc = "GetSpecialAbility";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "AddSpecialAbility";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(ability.id);
      VM.NWNX.StackPush(ability.ready);
      VM.NWNX.StackPush(ability.level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Removes a special ability from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetSpecialAbilityCount().</param>
    public static void RemoveSpecialAbility(uint creature, int index)
    {
      const string sFunc = "RemoveSpecialAbility";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets a special ability at the index for the creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetSpecialAbilityCount().</param>
    /// <param name="ability">An NWNX_Creature_SpecialAbility struct.</param>
    public static void SetSpecialAbility(uint creature, int index, SpecialAbility ability)
    {
      const string sFunc = "SetSpecialAbility";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetClassByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetBaseAC";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(ac);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get the base AC for the creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The base AC.</returns>
    public static int GetBaseAC(uint creature)
    {
      const string sFunc = "GetBaseAC";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetRawAbilityScore";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetRawAbilityScore";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "ModifyRawAbilityScore";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetPrePolymorphAbilityScore";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(ability);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the count of memorised spells for a creature&apos;s class at a level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The memorised spell count.</returns>
    public static int GetMemorisedSpellCountByLevel(uint creature, int @class, int level)
    {
      const string sFunc = "GetMemorisedSpellCountByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the memorised spell at a class level&apos;s index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetMemorisedSpellCountByLevel().</param>
    /// <returns>An NWNX_Creature_MemorisedSpell() struct.</returns>
    public static MemorisedSpell GetMemorisedSpell(uint creature, int @class, int level, int index)
    {
      const string sFunc = "GetMemorisedSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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

    /// Sets the memorised spell at a class level&apos;s index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetMemorisedSpellCountByLevel().</param>
    /// <param name="spell">An NWNX_Creature_MemorisedSpell() struct.</param>
    public static void SetMemorisedSpell(uint creature, int @class, int level, int index, MemorisedSpell spell)
    {
      const string sFunc = "SetMemorisedSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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

    /// Gets the remaining spell slots (innate casting) at a class level&apos;s index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The remaining spell slot count.</returns>
    public static int GetRemainingSpellSlots(uint creature, int @class, int level)
    {
      const string sFunc = "GetRemainingSpellSlots";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetRemainingSpellSlots";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetMaxSpellSlots";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetKnownSpellCount";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the known spell at a class level&apos;s index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetKnownSpellCount().</param>
    /// <returns>The spell id.</returns>
    public static int GetKnownSpell(uint creature, int @class, int level, int index)
    {
      const string sFunc = "GetKnownSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Add a spell to a creature&apos;s spellbook for class.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="spellId">The spell to remove.</param>
    public static void AddKnownSpell(uint creature, int @class, int level, int spellId)
    {
      const string sFunc = "AddKnownSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(spellId);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Remove a spell from creature&apos;s spellbook for class.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="spellId">The spell to remove.</param>
    public static void RemoveKnownSpell(uint creature, int @class, int level, int spellId)
    {
      const string sFunc = "RemoveKnownSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(spellId);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Clear a specific spell from the creature&apos;s spellbook for class
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="spellId">The spell to clear.</param>
    public static void ClearMemorisedKnownSpells(uint creature, int @class, int spellId)
    {
      const string sFunc = "ClearMemorisedKnownSpells";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(spellId);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Clear the memorised spell of the creature for the class, level and index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetMemorisedSpellCountByLevel().</param>
    public static void ClearMemorisedSpell(uint creature, int @class, int level, int index)
    {
      const string sFunc = "ClearMemorisedSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetMaxHitPointsByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetMaxHitPointsByLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s movement rate.
    /// <param name="creature">The creature object.</param>
    /// <param name="rate">The movement rate.</param>
    public static void SetMovementRate(uint creature, int rate)
    {
      const string sFunc = "SetMovementRate";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(rate);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Returns the creature&apos;s current movement rate factor.
    /// @remark Base movement rate factor is 1.0.
    /// <param name="creature">The creature object.</param>
    /// <returns>The current movement rate factor.</returns>
    public static float GetMovementRateFactor(uint creature)
    {
      const string sFunc = "GetMovementRateFactor";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Sets the creature&apos;s current movement rate factor.
    /// @note Base movement rate factor is 1.0.
    /// <param name="creature">The creature object.</param>
    /// <param name="rate">The rate to set.</param>
    public static void SetMovementRateFactor(uint creature, float factor)
    {
      const string sFunc = "SetMovementRateFactor";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(factor);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature&apos;s maximum movement rate cap.
    /// @note Default movement rate cap is 1.5.
    /// <param name="creature">The creature object.</param>
    /// <param name="cap">The cap to set.</param>
    public static void SetMovementRateFactorCap(uint creature, float cap)
    {
      const string sFunc = "SetMovementRateFactorCap";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(cap);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Returns the creature&apos;s current movement type
    /// <param name="creature">The creature object.</param>
    /// <returns>An NWNX_CREATURE_MOVEMENT_TYPE_* constant.</returns>
    public static int GetMovementType(uint creature)
    {
      const string sFunc = "GetMovementType";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetWalkRateCap";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fWalkRate);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s raw good/evil alignment value.
    /// <param name="creature">The creature object.</param>
    /// <param name="value">The value to set.</param>
    public static void SetAlignmentGoodEvil(uint creature, int value)
    {
      const string sFunc = "SetAlignmentGoodEvil";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s raw law/chaos alignment value.
    /// <param name="creature">The creature object.</param>
    /// <param name="value">The value to set.</param>
    public static void SetAlignmentLawChaos(uint creature, int value)
    {
      const string sFunc = "SetAlignmentLawChaos";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get the soundset index for creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The soundset used by the creature.</returns>
    public static int GetSoundset(uint creature)
    {
      const string sFunc = "GetSoundset";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the soundset index for creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="soundset">The soundset index.</param>
    public static void SetSoundset(uint creature, int soundset)
    {
      const string sFunc = "SetSoundset";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetSkillRank";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
    /// <param name="bUpdateLevels">determines whether the method will replace all occurrences</param>
    /// of the old class in CNWLevelStats with the new classID.
    public static void SetClassByPosition(uint creature, int position, int classID, int bUpdateLevels = TRUE)
    {
      const string sFunc = "SetClassByPosition";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bUpdateLevels);
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
      const string sFunc = "SetLevelByPosition";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(position);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s base attack bonus (BAB).
    /// @note Modifying the BAB will also affect the creature&apos;s attacks per round and its
    /// eligibility for feats, prestige classes, etc.
    /// <param name="creature">The creature object.</param>
    /// <param name="bab">The BAB value. Should be between 0 and 254. Setting BAB to 0 will cause the</param>
    /// creature to revert to its original BAB based on its classes and levels. A creature can
    /// never have an actual BAB of zero.
    /// @remark The base game has a function @nwn{SetBaseAttackBonus}, which actually sets
    /// the bonus attacks per round for a creature, not the BAB.
    public static void SetBaseAttackBonus(uint creature, int bab)
    {
      const string sFunc = "SetBaseAttackBonus";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bab);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creatures current attacks per round (using equipped weapon).
    /// <param name="creature">The creature object.</param>
    /// <param name="bBaseAPR">If TRUE, will return the base attacks per round, based on BAB and</param>
    /// equipped weapons, regardless of overrides set by calls to @nwn{SetBaseAttackBonus} builtin function.
    /// <returns>The attacks per round.</returns>
    public static int GetAttacksPerRound(uint creature, int bBaseAPR = FALSE)
    {
      const string sFunc = "GetAttacksPerRound";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetGender";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(gender);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore all creature feat uses.
    /// <param name="creature">The creature object.</param>
    public static void RestoreFeats(uint creature)
    {
      const string sFunc = "RestoreFeats";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore all creature special ability uses.
    /// <param name="creature">The creature object.</param>
    public static void RestoreSpecialAbilities(uint creature)
    {
      const string sFunc = "RestoreSpecialAbilities";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore all creature spells per day for given level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level to restore. If -1, all spells are restored.</param>
    public static void RestoreSpells(uint creature, int level = -1)
    {
      const string sFunc = "RestoreSpells";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(level);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Restore uses for all items carried by the creature.
    /// <param name="creature">The creature object.</param>
    public static void RestoreItems(uint creature)
    {
      const string sFunc = "RestoreItems";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature size.
    /// <param name="creature">The creature object.</param>
    /// <param name="size">Use CREATURE_SIZE_* constants.</param>
    public static void SetSize(uint creature, int size)
    {
      const string sFunc = "SetSize";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(size);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creature&apos;s remaining unspent skill points.
    /// <param name="creature">The creature object.</param>
    /// <returns>The remaining unspent skill points.</returns>
    public static int GetSkillPointsRemaining(uint creature)
    {
      const string sFunc = "GetSkillPointsRemaining";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the creature&apos;s remaining unspent skill points.
    /// <param name="creature">The creature object.</param>
    /// <param name="skillpoints">The value to set.</param>
    public static void SetSkillPointsRemaining(uint creature, int skillpoints)
    {
      const string sFunc = "SetSkillPointsRemaining";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(skillpoints);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature&apos;s racial type
    /// <param name="creature">The creature object.</param>
    /// <param name="racialtype">The racial type to set.</param>
    public static void SetRacialType(uint creature, int racialtype)
    {
      const string sFunc = "SetRacialType";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(racialtype);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature&apos;s gold without sending a feedback message
    /// <param name="creature">The creature object.</param>
    /// <param name="gold">The amount of gold to set for their creature.</param>
    public static void SetGold(uint creature, int gold)
    {
      const string sFunc = "SetGold";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(gold);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets corpse decay time in milliseconds
    /// <param name="creature">The creature object.</param>
    /// <param name="nDecayTime">The corpse decay time.</param>
    public static void SetCorpseDecayTime(uint creature, int nDecayTime)
    {
      const string sFunc = "SetCorpseDecayTime";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nDecayTime);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creature&apos;s base save.
    /// <param name="creature">The creature object.</param>
    /// <param name="which">One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL</param>
    /// <returns>The base save value.</returns>
    /// @note This will include any modifiers set in the toolset.
    public static int GetBaseSavingThrow(uint creature, int which)
    {
      const string sFunc = "GetBaseSavingThrow";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(which);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the creature&apos;s base save.
    /// <param name="creature">The creature object.</param>
    /// <param name="which">One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL</param>
    /// <param name="value">The base save value.</param>
    public static void SetBaseSavingThrow(uint creature, int which, int value)
    {
      const string sFunc = "SetBaseSavingThrow";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "LevelUp";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "LevelDown";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(count);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Sets the creature&apos;s challenge rating
    /// <param name="creature">The creature object.</param>
    /// <param name="fCR">The challenge rating.</param>
    public static void SetChallengeRating(uint creature, float fCR)
    {
      const string sFunc = "SetChallengeRating";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fCR);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Returns the creature&apos;s highest attack bonus based on its own stats.
    /// @note AB vs. Type and +AB on Gauntlets are excluded
    /// <param name="creature">The creature object.</param>
    /// <param name="isMelee"></param>
    ///   * TRUE: Get Melee/Unarmed Attack Bonus
    ///   * FALSE: Get Ranged Attack Bonus
    ///   * -1: Get Attack Bonus depending on the weapon creature has equipped in its right hand
    ///       Defaults to Melee Attack Bonus if weapon is invalid or no weapon
    /// <param name="isTouchAttack">If the attack was a touch attack.</param>
    /// <param name="isOffhand">If the attack was with the offhand.</param>
    /// <param name="includeBaseAttackBonus">Should the result include the base attack bonus.</param>
    /// <returns>The highest attack bonus.</returns>
    public static int GetAttackBonus(uint creature, int isMelee = -1, int isTouchAttack = FALSE, int isOffhand = FALSE, int includeBaseAttackBonus = TRUE)
    {
      const string sFunc = "GetAttackBonus";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      if (isMelee==-1)
      {
        uint oWeapon = GetItemInSlot(INVENTORY_SLOT_RIGHTHAND, creature);
        if (GetIsObjectValid(oWeapon) == TRUE)
        {
          isMelee = GetWeaponRanged(oWeapon);
        }
        else
        {
          isMelee = TRUE;
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
      const string sFunc = "GetHighestLevelOfFeat";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetFeatRemainingUses";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetFeatTotalUses";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetFeatRemainingUses";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(uses);
      VM.NWNX.StackPush(feat);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get total effect bonus
    /// @remark This exposes the actual bonus value beyond a player&apos;s base scores to attack, damage bonus, saves,
    /// skills, ability scores, and touch attack provided by spells, equipment, potions etc.
    /// <param name="creature">The creature object.</param>
    /// <param name="bonusType">A @ref bonus_types &quot;Bonus Type&quot;</param>
    /// <param name="target">A target object. Used to calculate bonuses versus specific races, alignments, etc.</param>
    /// <param name="isElemental">If a damage bonus includes elemental damage.</param>
    /// <param name="isForceMax">If the bonus should return the maximum possible.</param>
    /// <param name="savetype">A SAVING_THROW_* constant.</param>
    /// <param name="saveSpecificType">A SAVING_THROW_TYPE_* constant.</param>
    /// <param name="skill">A skill id.</param>
    /// <param name="abilityScore">An ABILITY_* constant.</param>
    /// <param name="isOffhand">Whether the attack is an offhand attack.</param>
    /// <returns>The bonus value.</returns>
    public static int GetTotalEffectBonus(uint creature, int bonusType = NWNX_CREATURE_BONUS_TYPE_ATTACK, uint target = OBJECT_INVALID, int isElemental = 0, int isForceMax = 0, int savetype = -1, int saveSpecificType = -1, int skill = -1, int abilityScore = -1, int isOffhand = FALSE)
    {
      const string sFunc = "GetTotalEffectBonus";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetOriginalName";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetOriginalName";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(isLastName);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Set creature&apos;s spell resistance
    /// <param name="creature">The creature object.</param>
    /// <param name="sr">The spell resistance.</param>
    /// @warning This setting will be overwritten by effects and once those effects fade the old setting (typically 0) will be set.
    public static void SetSpellResistance(uint creature, int sr)
    {
      const string sFunc = "SetSpellResistance";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(sr);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s animal companion creature type
    /// <param name="creature">The master creature object.</param>
    /// <param name="type">The type from ANIMAL_COMPANION_CREATURE_TYPE_*.</param>
    public static void SetAnimalCompanionCreatureType(uint creature, int type)
    {
      const string sFunc = "SetAnimalCompanionCreatureType";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s familiar creature type
    /// <param name="creature">The master creature object.</param>
    /// <param name="type">The type from FAMILIAR_CREATURE_TYPE_*.</param>
    public static void SetFamiliarCreatureType(uint creature, int type)
    {
      const string sFunc = "SetFamiliarCreatureType";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s animal companion&apos;s name
    /// <param name="creature">The master creature object.</param>
    /// <param name="name">The name to give their animal companion.</param>
    public static void SetAnimalCompanionName(uint creature, string name)
    {
      const string sFunc = "SetAnimalCompanionName";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(name);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Set creature&apos;s familiar&apos;s name
    /// <param name="creature">The master creature object.</param>
    /// <param name="name">The name to give their familiar.</param>
    public static void SetFamiliarName(uint creature, string name)
    {
      const string sFunc = "SetFamiliarName";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(name);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Get whether the creature can be disarmed.
    /// <param name="creature">The creature object.</param>
    /// <returns>TRUE if the creature can be disarmed.</returns>
    public static int GetDisarmable(uint creature)
    {
      const string sFunc = "GetDisarmable";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set whether a creature can be disarmed.
    /// <param name="creature">The creature object.</param>
    /// <param name="disarmable">Set to TRUE if the creature can be disarmed.</param>
    public static void SetDisarmable(uint creature, int disarmable)
    {
      const string sFunc = "SetDisarmable";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(disarmable);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets one of creature&apos;s domains.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="index">The first or second domain.</param>
    /// @deprecated Use GetDomain(). This will be removed in future NWNX releases.
    public static int GetDomain(uint creature, int @class, int index)
    {
      WriteTimestampedLogEntry("NWNX_Creature: GetDomain() is deprecated. Please use the basegame's GetDomain() instead");
      return VM.NWNX.StackPopInt();
    }

    /// Sets one of creature&apos;s domains.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="index">The first or second domain.</param>
    /// <param name="domain">The domain constant to set.</param>
    public static void SetDomain(uint creature, int @class, int index, int domain)
    {
      const string sFunc = "SetDomain";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(domain);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(@class);
      VM.NWNX.StackPush(creature);
      VM.NWNX.Call();
    }

    /// Gets the creature&apos;s specialist school.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// @deprecated Use GetSpecialization(). This will be removed in future NWNX releases.
    public static int GetSpecialization(uint creature, int @class)
    {
      WriteTimestampedLogEntry("NWNX_Creature: GetSpecialization() is deprecated. Please use the basegame's GetSpecialization() instead");
      return VM.NWNX.StackPopInt();
    }

    /// Sets creature&apos;s specialist school.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="school">The school constant.</param>
    public static void SetSpecialization(uint creature, int @class, int school)
    {
      const string sFunc = "SetSpecialization";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetFaction";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nFactionId);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the faction id from oCreature
    /// <param name="oCreature">the creature we wish to query against</param>
    /// <returns>faction id as an integer, -1 when used against invalid creature or invalid object.</returns>
    public static int GetFaction(uint oCreature)
    {
      const string sFunc = "GetFaction";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get whether a creature is flat-footed.
    /// <param name="oCreature">The creature object.</param>
    /// <returns>TRUE if the creature is flat-footed.</returns>
    public static int GetFlatFooted(uint oCreature)
    {
      const string sFunc = "GetFlatFooted";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Serialize oCreature&apos;s quickbar to a base64 string
    /// <param name="oCreature">The creature.</param>
    /// <returns>A base64 string representation of oCreature&apos;s quickbar.</returns>
    public static string SerializeQuickbar(uint oCreature)
    {
      const string sFunc = "SerializeQuickbar";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "DeserializeQuickbar";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
    public static void SetCasterLevelModifier(uint oCreature, int nClass, int nModifier, int bPersist = FALSE)
    {
      const string sFunc = "SetCasterLevelModifier";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetCasterLevelModifier";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
    public static void SetCasterLevelOverride(uint oCreature, int nClass, int nCasterLevel, int bPersist = FALSE)
    {
      const string sFunc = "SetCasterLevelOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetCasterLevelOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nClass);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Move a creature to limbo.
    /// <param name="oCreature">The creature object.</param>
    public static void JumpToLimbo(uint oCreature)
    {
      const string sFunc = "JumpToLimbo";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Sets the critical hit multiplier modifier for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nModifier">The modifier to apply</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file if applicable</param>
    /// <param name="nBaseItem">Applies the.modifier only when the attack used this baseitem. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// @note Persistence is activated each server reset by the first use of either &apos;SetCriticalMultiplier*&apos; functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalMultiplierModifier(uint oCreature, int nModifier, int nHand = 0, int bPersist = FALSE, int nBaseItem = -1)
    {
      const string sFunc = "SetCriticalMultiplierModifier";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nModifier);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the critical hit multiplier modifier for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem modifer to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit multiplier modifier for the creature</returns>
    public static int GetCriticalMultiplierModifier(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      const string sFunc = "GetCriticalMultiplierModifier";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the critical hit multiplier override for the Creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nOverride">The override value to apply. -1 to clear override.</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file if applicable</param>
    /// <param name="nBaseItem">Applies the.Override only when the attack used this baseitem. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// @note Persistence is activated each server reset by the first use of either &apos;SetCriticalMultiplier*&apos; functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalMultiplierOverride(uint oCreature, int nOverride, int nHand = 0, int bPersist = FALSE, int nBaseItem = -1)
    {
      const string sFunc = "SetCriticalMultiplierOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nOverride);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the critical hit multiplier override for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem Override to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit multiplier override for the creature. No override == -1</returns>
    public static int GetCriticalMultiplierOverride(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      const string sFunc = "GetCriticalMultiplierOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the critical hit range modifier for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nModifier">The modifier to apply. Positive modifiers reduce critical chance. (I.e. From 18-20, a +1 results in crit range of 19-20)</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file if applicable</param>
    /// <param name="nBaseItem">Applies the.modifier only when the attack used this baseitem. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// @note Persistence is activated each server reset by the first use of either &apos;SetCriticalRange*&apos; functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalRangeModifier(uint oCreature, int nModifier, int nHand = 0, int bPersist = FALSE, int nBaseItem = -1)
    {
      const string sFunc = "SetCriticalRangeModifier";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nModifier);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the critical hit range modifier for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem modifer to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit range modifier for the creature</returns>
    public static int GetCriticalRangeModifier(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      const string sFunc = "GetCriticalRangeModifier";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the critical hit range Override for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nOverride">The new minimum roll to crit. i.e nOverride of 15 results in crit range of 15-20. -1 to clear override.</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file if applicable</param>
    /// <param name="nBaseItem">Applies the.Override only when the attack used this baseitem. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// @note Persistence is activated each server reset by the first use of either &apos;SetCriticalRange*&apos; functions. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetCriticalRangeOverride(uint oCreature, int nOverride, int nHand = 0, int bPersist = FALSE, int nBaseItem = -1)
    {
      const string sFunc = "SetCriticalRangeOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nHand);
      VM.NWNX.StackPush(nOverride);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Sets the critical hit range Override for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem Override to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit range override for the creature. No override == -1</returns>
    public static int GetCriticalRangeOverride(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      const string sFunc = "GetCriticalRangeOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nBaseItem);
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
      const string sFunc = "AddAssociate";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetEffectIconFlashing";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bFlashing);
      VM.NWNX.StackPush(nIconId);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Override the damage level of oCreature.
    /// @note Damage levels are the damage state under a creature&apos;s name, for example: &apos;Near Death&apos;
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nDamageLevel">A damage level, see damagelevels.2da. Allowed values: 0-255 or -1 to remove the override.</param>
    public static void OverrideDamageLevel(uint oCreature, int nDamageLevel)
    {
      const string sFunc = "OverrideDamageLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nDamageLevel);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Set the encounter source of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="oEncounter">The source encounter</param>
    public static void SetEncounter(uint oCreature, uint oEncounter)
    {
      const string sFunc = "SetEncounter";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oEncounter);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get the encounter source of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>The encounter, OBJECT_INVALID if not part of an encounter or on error</returns>
    public static uint GetEncounter(uint oCreature)
    {
      const string sFunc = "GetEncounter";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Get if oCreature is currently bartering.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>TRUE if oCreature is bartering, FALSE if not or on error.</returns>
    public static int GetIsBartering(uint oCreature)
    {
      const string sFunc = "GetIsBartering";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets caster level for the last item used. Use in a spellhook or spell event before to set caster level for any spells cast from the item.
    /// <param name="oCreature">the creature who used the item.</param>
    /// <param name="nCasterLvl">the desired caster level.</param>
    public static void SetLastItemCasterLevel(uint oCreature, int nCasterLvl)
    {
      const string sFunc = "SetLastItemCasterLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nCasterLvl);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the caster level of the last item used.
    /// <param name="oCreature">the creature who used the item.</param>
    /// <returns>returns the creatures last used item&apos;s level.</returns>
    public static int GetLastItemCasterLevel(uint oCreature)
    {
      const string sFunc = "GetLastItemCasterLevel";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the Armor classed of attacked against versus
    /// <param name="oAttacked">The one being attacked</param>
    /// <param name="oVersus">The one doing the attacking</param>
    /// <param name="nTouch">TRUE for touch attacks</param>
    /// <returns>-255 on Error, Flat footed AC if oVersus is invalid or the Attacked AC versus oVersus.</returns>
    public static int GetArmorClassVersus(uint oAttacked, uint oVersus, int nTouch = FALSE)
    {
      const string sFunc = "GetArmorClassVersus";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "GetWalkAnimation";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the current walk animation of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nAnimation">The walk animation number.</param>
    public static void SetWalkAnimation(uint oCreature, int nAnimation)
    {
      const string sFunc = "SetWalkAnimation";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetAttackRollOverride";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
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
      const string sFunc = "SetParryAllAttacks";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bParry);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets the NoPermanentDeath flag of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>TRUE/FALSE or -1 on error.</returns>
    public static int GetNoPermanentDeath(uint oCreature)
    {
      const string sFunc = "GetNoPermanentDeath";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the NoPermanentDeath flag of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="bNoPermanentDeath">TRUE/FALSE.</param>
    public static void SetNoPermanentDeath(uint oCreature, int bNoPermanentDeath)
    {
      const string sFunc = "SetNoPermanentDeath";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bNoPermanentDeath);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Compute a safe location for oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="vPosition">The starting position.</param>
    /// <param name="fRadius">The search radius around vPosition.</param>
    /// <param name="bWalkStraightLineRequired">Whether the creature must be able to walk in a straight line to the position.</param>
    /// <returns>A safe location as vector, will return vPosition if one wasn&apos;t found. Returns {0.0, 0.0, 0.0} on error.</returns>
    public static System.Numerics.Vector3 ComputeSafeLocation(uint oCreature, System.Numerics.Vector3 vPosition, float fRadius = 20.0f, int bWalkStraightLineRequired = TRUE)
    {
      const string sFunc = "ComputeSafeLocation";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bWalkStraightLineRequired);
      VM.NWNX.StackPush(fRadius);
      VM.NWNX.StackPush(vPosition.X);
      VM.NWNX.StackPush(vPosition.Y);
      VM.NWNX.StackPush(vPosition.Z);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      System.Numerics.Vector3 v = default;
      v.Z = VM.NWNX.StackPopFloat();
      v.Y = VM.NWNX.StackPopFloat();
      v.X = VM.NWNX.StackPopFloat();
      return v;
    }

    /// Update oCreature&apos;s perception of oTargetCreature.
    /// <param name="oCreature">The creature.</param>
    /// <param name="oTargetCreature">The target creature.</param>
    public static void DoPerceptionUpdateOnCreature(uint oCreature, uint oTargetCreature)
    {
      const string sFunc = "DoPerceptionUpdateOnCreature";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oTargetCreature);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get a creatures personal space (meters from center to non-creature objects).
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures personal space.</returns>
    public static float GetPersonalSpace(uint oCreature)
    {
      const string sFunc = "GetPersonalSpace";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set a creatures personal space (meters from center to non-creature objects).
    /// <param name="oCreature">The creature.</param>
    /// <param name="fPerspace">The creatures personal space.</param>
    public static void SetPersonalSpace(uint oCreature, float fPerspace)
    {
      const string sFunc = "SetPersonalSpace";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fPerspace);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get a creatures creature personal space (meters from center to other creatures).
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures creature personal space.</returns>
    public static float GetCreaturePersonalSpace(uint oCreature)
    {
      const string sFunc = "GetCreaturePersonalSpace";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set a creatures creature personal space (meters from center to other creatures).
    /// <param name="oCreature">The creature.</param>
    /// <param name="fCrePerspace">The creatures creature personal space.</param>
    public static void SetCreaturePersonalSpace(uint oCreature, float fCrePerspace)
    {
      const string sFunc = "SetCreaturePersonalSpace";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fCrePerspace);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get a creatures height.
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures height.</returns>
    public static float GetHeight(uint oCreature)
    {
      const string sFunc = "GetHeight";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set a creatures height.
    /// <param name="oCreature">The creature.</param>
    /// <param name="fHeight">The creatures height.</param>
    public static void SetHeight(uint oCreature, float fHeight)
    {
      const string sFunc = "SetHeight";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fHeight);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get a creatures hit distance.
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures hit distance.</returns>
    public static float GetHitDistance(uint oCreature)
    {
      const string sFunc = "GetHitDistance";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set a creatures hit distance.
    /// <param name="oCreature">The creature.</param>
    /// <param name="fHitDist">The creatures hit distance.</param>
    public static void SetHitDistance(uint oCreature, float fHitDist)
    {
      const string sFunc = "SetHitDistance";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fHitDist);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get a creatures preferred attack distance.
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures preferred attack distance.</returns>
    public static float GetPreferredAttackDistance(uint oCreature)
    {
      const string sFunc = "GetPreferredAttackDistance";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    /// Set a creatures preferred attack distance.
    /// <param name="oCreature">The creature.</param>
    /// <param name="fPrefAtckDist">The creatures preferred attack distance.</param>
    public static void SetPreferredAttackDistance(uint oCreature, float fPrefAtckDist)
    {
      const string sFunc = "SetPreferredAttackDistance";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(fPrefAtckDist);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Get the skill penalty from wearing armor.
    /// <param name="oCreature">The creature.</param>
    public static int GetArmorCheckPenalty(uint oCreature)
    {
      const string sFunc = "GetArmorCheckPenalty";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the skill penalty from wearing a shield.
    /// <param name="oCreature">The creature.</param>
    public static int GetShieldCheckPenalty(uint oCreature)
    {
      const string sFunc = "GetShieldCheckPenalty";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets a chance for normal Effect Immunities to be bypassed
    /// <param name="oCreature">The affected creature</param>
    /// <param name="nImmunityType">&apos;IMMUNITY_TYPE_*&apos; to bypass. By default affects outgoing effects (oCreature -&gt; another creature). Use a negative (-IMMUNITY_TYPE_*) to affect incoming effects instead (another creature -&gt; oCreature) use 255/-255 to bypass ALL Immunities.</param>
    /// <param name="nChance">The chance (of 100%) to bypass the immunity check. A Positive chance results in NOT IMMUNE. A Negative chance results in IMMUNE.</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file (for PCs)</param>
    /// @note Persistence is enabled after a server reset by the first use of this function. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    /// @note Where an Outgoing and Incoming bypass both attempt opposing outcomes, both are ignored and the immunity status without bypass will apply.
    public static void SetBypassEffectImmunity(uint oCreature, int nImmunityType, int nChance = 100, int bPersist = FALSE)
    {
      const string sFunc = "SetBypassEffectImmunity";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(bPersist);
      VM.NWNX.StackPush(nChance);
      VM.NWNX.StackPush(nImmunityType);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Gets a chance for normal Effect Immunities to be bypassed
    /// <param name="oCreature">The target creature</param>
    /// <param name="nImmunityType">&apos;IMMUNITY_TYPE_*&apos; to retrieve the current chance for bypass: Positive gets outgoing effects (oCreature -&gt; another creature). Negative (-IMMUNITY_TYPE_*) gets incoming effects (another creature -&gt; oCreature).</param>
    /// <returns>the current critical hit multiplier modifier for the creature</returns>
    public static int GetBypassEffectImmunity(uint oCreature, int nImmunityType)
    {
      const string sFunc = "GetBypassEffectImmunity";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nImmunityType);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets the killer of oCreature to oKiller.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="oKiller">The killer.</param>
    public static void SetLastKiller(uint oCreature, uint oKiller)
    {
      const string sFunc = "SetLastKiller";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oKiller);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Instantly cast a spell at a target or location.
    /// @note oCreature must be in the same area as oTarget or locTarget.
    /// @note Does not care if oCreature can&apos;t cast spells or doesn&apos;t know the spell. Does not consume spell slots.
    /// <param name="oCreature">The caster.</param>
    /// <param name="oTarget">The target, use OBJECT_INVALID to cast at a location.</param>
    /// <param name="locTarget">The location, only used when oTarget is OBJECT_INVALID.</param>
    /// <param name="nSpellID">The spell ID.</param>
    /// <param name="nCasterLevel">The caster level of the spell.</param>
    /// <param name="fProjectileTime">The time in seconds for the projectile to reach the target. 0.0f for no projectile.</param>
    /// <param name="nProjectilePathType">A PROJECTILE_PATH_TYPE_* constant.</param>
    /// <param name="nProjectileSpellID">An optional spell ID which to use the projectile vfx of. -1 to use nSpellID&apos;s projectile vfx.</param>
    public static void DoItemCastSpell(uint oCreature, uint oTarget, System.IntPtr locTarget, int nSpellID, int nCasterLevel, float fProjectileTime, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT, int nProjectileSpellID = -1)
    {
      const string sFunc = "DoItemCastSpell";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      uint oArea = GetAreaFromLocation(locTarget);
      System.Numerics.Vector3 vPosition = GetPositionFromLocation(locTarget);
      VM.NWNX.StackPush(nProjectileSpellID);
      VM.NWNX.StackPush(nProjectilePathType);
      VM.NWNX.StackPush(fProjectileTime);
      VM.NWNX.StackPush(nCasterLevel);
      VM.NWNX.StackPush(nSpellID);
      VM.NWNX.StackPush(vPosition.Z);
      VM.NWNX.StackPush(vPosition.Y);
      VM.NWNX.StackPush(vPosition.X);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.StackPush(oTarget);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
    }

    /// Have oCreature instantly equip oItem to nInventorySlot.
    /// <param name="oCreature">The creature.</param>
    /// <param name="oItem">The item, must be possessed by oCreature.</param>
    /// <param name="nInventorySlot">An INVENTORY_SLOT_* constant.</param>
    /// <returns>TRUE on success, FALSE on failure.</returns>
    public static int RunEquip(uint oCreature, uint oItem, int nInventorySlot)
    {
      const string sFunc = "RunEquip";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(nInventorySlot);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Have oCreature instantly unequip oItem.
    /// <param name="oCreature">The creature.</param>
    /// <param name="oItem">The item, must be possessed by oCreature.</param>
    /// <returns>TRUE on success, FALSE on failure.</returns>
    public static int RunUnequip(uint oCreature, uint oItem)
    {
      const string sFunc = "RunUnequip";
      VM.NWNX.SetFunction(NWNX_Creature, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    // @}
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
