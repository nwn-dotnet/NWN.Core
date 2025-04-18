using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Creature)]
  public class CreaturePlugin
  {
    /// @addtogroup creature Creature
    /// Functions exposing additional creature properties.
    /// @{
    /// @file nwnx_creature.nss
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
    /// @name Ranged Projectile VFX
    /// @anchor ranged_projectile_vfx
    ///
    /// Used with NWNX_Creature_OverrideRangedProjectileVFX() these are the projectile vfx types.
    /// @{
    public const int NWNX_CREATURE_PROJECTILE_VFX_NONE = 0;

    ///&lt; No VFX
    public const int NWNX_CREATURE_PROJECTILE_VFX_ACID = 1;
    public const int NWNX_CREATURE_PROJECTILE_VFX_COLD = 2;
    public const int NWNX_CREATURE_PROJECTILE_VFX_ELECTRICAL = 3;
    public const int NWNX_CREATURE_PROJECTILE_VFX_FIRE = 4;
    public const int NWNX_CREATURE_PROJECTILE_VFX_SONIC = 5;
    public const int NWNX_CREATURE_PROJECTILE_VFX_RANDOM = 6;

    ///&lt; Random Elemental VFX
    // @}
    public const int NWNX_CREATURE_ABILITY_NONE = 6;

    /// @struct NWNX_Creature_SpecialAbility
    /// A creature special ability.
    /// Gives the creature a feat.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// @remark Consider also using NWNX_Creature_AddFeatByLevel() to properly allocate the feat to a level
    public static void AddFeat(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "AddFeat");
    }

    /// Gives the creature a feat assigned at a level
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <param name="level">The level they gained the feat.</param>
    /// @remark Adds the feat to the stat list at the provided level.
    public static void AddFeatByLevel(uint creature, int feat, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "AddFeatByLevel");
    }

    /// Removes a feat from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    public static void RemoveFeat(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RemoveFeat");
    }

    /// Removes the creature a feat assigned at a level
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <param name="level">The level they gained the feat.</param>
    /// @remark Removes the feat from the stat list at the provided level. Does not remove the feat from the creature, use
    /// NWNX_Creature_RemoveFeat for this.
    public static void RemoveFeatByLevel(uint creature, int feat, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RemoveFeatByLevel");
    }

    /// Determines if the creature knows a feat.
    /// @note This differs from native @nwn{GetHasFeat} which returns FALSE if the feat has no more uses per day.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>TRUE if the creature has the feat, regardless if they have any usages left or not.</returns>
    public static int GetKnowsFeat(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetKnowsFeat");
      return NWNXPopInt();
    }

    /// Returns the count of feats learned at the provided level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The count of feats.</returns>
    public static int GetFeatCountByLevel(uint creature, int level)
    {
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatCountByLevel");
      return NWNXPopInt();
    }

    /// Returns the feat learned at the level and index.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetFeatCountByLevel().</param>
    /// <returns>The feat id at the index.</returns>
    public static int GetFeatByLevel(uint creature, int level, int index)
    {
      NWNXPushInt(index);
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatByLevel");
      return NWNXPopInt();
    }

    /// Returns the creature level where the specified feat was learned.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The character level that the specified feat was granted, otherwise 0 if the creature does not have this feat.</returns>
    public static int GetFeatGrantLevel(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatGrantLevel");
      return NWNXPopInt();
    }

    /// Get the total number of feats known by creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The total feat count for the creature.</returns>
    public static int GetFeatCount(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatCount");
      return NWNXPopInt();
    }

    /// Returns the creature&apos;s feat at a given index
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetFeatCount();</param>
    /// <returns>The feat id at the index.</returns>
    public static int GetFeatByIndex(uint creature, int index)
    {
      NWNXPushInt(index);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatByIndex");
      return NWNXPopInt();
    }

    /// Gets if creature meets feat requirements.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>TRUE if creature meets all requirements to take given feat</returns>
    public static int GetMeetsFeatRequirements(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetMeetsFeatRequirements");
      return NWNXPopInt();
    }

    /// Gets the count of special abilities of the creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The total special ability count.</returns>
    public static int GetSpecialAbilityCount(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetSpecialAbilityCount");
      return NWNXPopInt();
    }

    /// Returns the creature&apos;s special ability at a given index.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetSpecialAbilityCount().</param>
    /// <returns>An NWNX_Creature_SpecialAbility struct.</returns>
    public static SpecialAbility GetSpecialAbility(uint creature, int index)
    {
      SpecialAbility ability = default;
      NWNXPushInt(index);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetSpecialAbility");
      ability.level = NWNXPopInt();
      ability.ready = NWNXPopInt();
      ability.id = NWNXPopInt();
      return ability;
    }

    /// Adds a special ability to a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">An NWNX_Creature_SpecialAbility struct.</param>
    public static void AddSpecialAbility(uint creature, SpecialAbility ability)
    {
      NWNXPushInt(ability.id);
      NWNXPushInt(ability.ready);
      NWNXPushInt(ability.level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "AddSpecialAbility");
    }

    /// Removes a special ability from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetSpecialAbilityCount().</param>
    public static void RemoveSpecialAbility(uint creature, int index)
    {
      NWNXPushInt(index);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RemoveSpecialAbility");
    }

    /// Sets a special ability at the index for the creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="index">The index. Index bounds: 0 &lt;= index &lt; NWNX_Creature_GetSpecialAbilityCount().</param>
    /// <param name="ability">An NWNX_Creature_SpecialAbility struct.</param>
    public static void SetSpecialAbility(uint creature, int index, SpecialAbility ability)
    {
      NWNXPushInt(ability.id);
      NWNXPushInt(ability.ready);
      NWNXPushInt(ability.level);
      NWNXPushInt(index);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSpecialAbility");
    }

    /// Get the class taken by the creature at the provided level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The class id.</returns>
    public static int GetClassByLevel(uint creature, int level)
    {
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetClassByLevel");
      return NWNXPopInt();
    }

    /// Sets the base AC for the creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="ac">The base AC to set for the creature.</param>
    public static void SetBaseAC(uint creature, int ac)
    {
      NWNXPushInt(ac);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetBaseAC");
    }

    /// Get the base AC for the creature.
    /// <param name="creature">The creature object.</param>
    /// <returns>The base AC.</returns>
    public static int GetBaseAC(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetBaseAC");
      return NWNXPopInt();
    }

    /// Sets the ability score of the creature to the provided value.
    /// @note Does not apply racial bonuses/penalties.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <param name="value">The value to set.</param>
    public static void SetRawAbilityScore(uint creature, int ability, int value)
    {
      NWNXPushInt(value);
      NWNXPushInt(ability);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetRawAbilityScore");
    }

    /// Gets the ability score of the creature.
    /// @note Does not apply racial bonuses/penalties.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <returns>The ability score.</returns>
    public static int GetRawAbilityScore(uint creature, int ability)
    {
      NWNXPushInt(ability);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetRawAbilityScore");
      return NWNXPopInt();
    }

    /// Adjusts the ability score of a creature.
    /// @note Does not apply racial bonuses/penalties.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <param name="modifier">The modifier value.</param>
    public static void ModifyRawAbilityScore(uint creature, int ability, int modifier)
    {
      NWNXPushInt(modifier);
      NWNXPushInt(ability);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "ModifyRawAbilityScore");
    }

    /// Gets the raw ability score a polymorphed creature had prior to polymorphing.
    /// @note For Strength, Dexterity and Constitution only.
    /// <param name="creature">The creature object.</param>
    /// <param name="ability">The ability constant.</param>
    /// <returns>The raw ability score.</returns>
    public static int GetPrePolymorphAbilityScore(uint creature, int ability)
    {
      NWNXPushInt(ability);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetPrePolymorphAbilityScore");
      return NWNXPopInt();
    }

    /// Gets the remaining spell slots (innate casting) at a class level&apos;s index.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The remaining spell slot count.</returns>
    public static int GetRemainingSpellSlots(uint creature, int @class, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetRemainingSpellSlots");
      return NWNXPopInt();
    }

    /// Sets the remaining spell slots (innate casting) at a class level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="slots">The remaining spell slots to set.</param>
    public static void SetRemainingSpellSlots(uint creature, int @class, int level, int slots)
    {
      NWNXPushInt(slots);
      NWNXPushInt(level);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetRemainingSpellSlots");
    }

    /// Gets the maximum spell slots (innate casting) at a class level.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <returns>The maximum spell slot count.</returns>
    public static int GetMaxSpellSlots(uint creature, int @class, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetMaxSpellSlots");
      return NWNXPopInt();
    }

    /// Add a spell to a creature&apos;s spellbook for class.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="spellId">The spell to remove.</param>
    public static void AddKnownSpell(uint creature, int @class, int level, int spellId)
    {
      NWNXPushInt(spellId);
      NWNXPushInt(level);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "AddKnownSpell");
    }

    /// Remove a spell from creature&apos;s spellbook for class.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="level">The spell level.</param>
    /// <param name="spellId">The spell to remove.</param>
    public static void RemoveKnownSpell(uint creature, int @class, int level, int spellId)
    {
      NWNXPushInt(spellId);
      NWNXPushInt(level);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RemoveKnownSpell");
    }

    /// Gets the maximum hit points for creature for level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The maximum hit points a creature can have for the class at the provided level.</returns>
    public static int GetMaxHitPointsByLevel(uint creature, int level)
    {
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetMaxHitPointsByLevel");
      return NWNXPopInt();
    }

    /// Sets the maximum hit points for creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <param name="value">The amount to set the max hit points.</param>
    public static void SetMaxHitPointsByLevel(uint creature, int level, int value)
    {
      NWNXPushInt(value);
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetMaxHitPointsByLevel");
    }

    /// Set creature&apos;s movement rate.
    /// <param name="creature">The creature object.</param>
    /// <param name="rate">The movement rate.</param>
    public static void SetMovementRate(uint creature, int rate)
    {
      NWNXPushInt(rate);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetMovementRate");
    }

    /// Returns the creature&apos;s current movement rate factor.
    /// @remark Base movement rate factor is 1.0.
    /// <param name="creature">The creature object.</param>
    /// <returns>The current movement rate factor.</returns>
    public static float GetMovementRateFactor(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetMovementRateFactor");
      return NWNXPopFloat();
    }

    /// Sets the creature&apos;s current movement rate factor.
    /// @note Base movement rate factor is 1.0.
    /// <param name="creature">The creature object.</param>
    /// <param name="rate">The rate to set.</param>
    public static void SetMovementRateFactor(uint creature, float factor)
    {
      NWNXPushFloat(factor);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetMovementRateFactor");
    }

    /// Returns the creature&apos;s maximum movement rate cap.
    /// @remark Default movement rate cap is 1.5.
    /// <param name="creature">The creature object.</param>
    /// <returns>The maximum movement rate cap.</returns>
    public static float GetMovementRateFactorCap(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetMovementRateFactorCap");
      return NWNXPopFloat();
    }

    /// Sets the creature&apos;s maximum movement rate cap.
    /// @note Default movement rate cap is 1.5.
    /// <param name="creature">The creature object.</param>
    /// <param name="cap">The cap to set.</param>
    public static void SetMovementRateFactorCap(uint creature, float cap)
    {
      NWNXPushFloat(cap);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetMovementRateFactorCap");
    }

    /// Returns the creature&apos;s current movement type
    /// <param name="creature">The creature object.</param>
    /// <returns>An NWNX_CREATURE_MOVEMENT_TYPE_* constant.</returns>
    public static int GetMovementType(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetMovementType");
      return NWNXPopInt();
    }

    /// Sets the maximum movement rate a creature can have while walking (not running)
    /// @remark This allows a creature with movement speed enhancements to walk at a normal rate.
    /// <param name="creature">The creature object.</param>
    /// <param name="fWalkRate">The walk rate to apply. Setting the value to -1.0 will remove the cap.</param>
    /// Default value is 2000.0, which is the base human walk speed.
    public static void SetWalkRateCap(uint creature, float fWalkRate = 2000.0f)
    {
      NWNXPushFloat(fWalkRate);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetWalkRateCap");
    }

    /// Set creature&apos;s raw good/evil alignment value.
    /// <param name="creature">The creature object.</param>
    /// <param name="value">The value to set.</param>
    public static void SetAlignmentGoodEvil(uint creature, int value)
    {
      NWNXPushInt(value);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetAlignmentGoodEvil");
    }

    /// Set creature&apos;s raw law/chaos alignment value.
    /// <param name="creature">The creature object.</param>
    /// <param name="value">The value to set.</param>
    public static void SetAlignmentLawChaos(uint creature, int value)
    {
      NWNXPushInt(value);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetAlignmentLawChaos");
    }

    /// Set the base ranks in a skill for creature
    /// <param name="creature">The creature object.</param>
    /// <param name="skill">The skill id.</param>
    /// <param name="rank">The value to set as the skill rank.</param>
    public static void SetSkillRank(uint creature, int skill, int rank)
    {
      NWNXPushInt(rank);
      NWNXPushInt(skill);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSkillRank");
    }

    /// Get the ranks in a skill for creature assigned at a level.
    /// <param name="creature">The creature object.</param>
    /// <param name="skill">The skill id.</param>
    /// <param name="level">The level they gained skill ranks.</param>
    /// <returns>The rank in a skill assigned at a level (-1 on error).</returns>
    public static int GetSkillRankByLevel(uint creature, int skill, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(skill);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetSkillRankByLevel");
      return NWNXPopInt();
    }

    /// Set the ranks in a skill for creature assigned at a level.
    /// @note It only affect the leveling array, to know what to do on level-down. To effectivly change the skill rank on the current level, NWNX_Creature_SetSkillRank is also needed.
    /// <param name="creature">The creature object.</param>
    /// <param name="skill">The skill id.</param>
    /// <param name="level">The level they gained skill ranks.</param>
    /// <param name="rank">The value to set as the skill rank.</param>
    public static void SetSkillRankByLevel(uint creature, int skill, int rank, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(rank);
      NWNXPushInt(skill);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSkillRankByLevel");
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
      NWNXPushInt(bUpdateLevels);
      NWNXPushInt(classID);
      NWNXPushInt(position);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetClassByPosition");
    }

    /// Set the level at the given position for a creature.
    /// @note A creature should already have a class in that position.
    /// <param name="creature">The creature object.</param>
    /// <param name="position">Should be 0, 1, or 2 depending on how many classes the creature</param>
    /// has and which is to be modified.
    /// <param name="level">The level to set.</param>
    public static void SetLevelByPosition(uint creature, int position, int level)
    {
      NWNXPushInt(level);
      NWNXPushInt(position);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetLevelByPosition");
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
      NWNXPushInt(bab);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetBaseAttackBonus");
    }

    /// Gets the creatures current attacks per round (using equipped weapon).
    /// <param name="creature">The creature object.</param>
    /// <param name="bBaseAPR">If TRUE, will return the base attacks per round, based on BAB and</param>
    /// equipped weapons, regardless of overrides set by calls to @nwn{SetBaseAttackBonus} builtin function.
    /// <returns>The attacks per round.</returns>
    public static int GetAttacksPerRound(uint creature, int bBaseAPR = FALSE)
    {
      NWNXPushInt(bBaseAPR);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetAttacksPerRound");
      return NWNXPopInt();
    }

    /// Restore all creature feat uses.
    /// <param name="creature">The creature object.</param>
    public static void RestoreFeats(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RestoreFeats");
    }

    /// Restore all creature special ability uses.
    /// <param name="creature">The creature object.</param>
    public static void RestoreSpecialAbilities(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RestoreSpecialAbilities");
    }

    /// Restore uses for all items carried by the creature.
    /// <param name="creature">The creature object.</param>
    public static void RestoreItems(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "RestoreItems");
    }

    /// Sets the creature size.
    /// <param name="creature">The creature object.</param>
    /// <param name="size">Use CREATURE_SIZE_* constants.</param>
    public static void SetSize(uint creature, int size)
    {
      NWNXPushInt(size);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSize");
    }

    /// Gets the creature&apos;s remaining unspent skill points.
    /// <param name="creature">The creature object.</param>
    /// <returns>The remaining unspent skill points.</returns>
    public static int GetSkillPointsRemaining(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetSkillPointsRemaining");
      return NWNXPopInt();
    }

    /// Sets the creature&apos;s remaining unspent skill points.
    /// <param name="creature">The creature object.</param>
    /// <param name="skillpoints">The value to set.</param>
    public static void SetSkillPointsRemaining(uint creature, int skillpoints)
    {
      NWNXPushInt(skillpoints);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSkillPointsRemaining");
    }

    /// Gets the creature&apos;s remaining unspent skill points for level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <returns>The remaining unspent skill points for level.</returns>
    public static int GetSkillPointsRemainingByLevel(uint creature, int level)
    {
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetSkillPointsRemainingByLevel");
      return NWNXPopInt();
    }

    /// Sets the creature&apos;s remaining unspent skill points for level.
    /// <param name="creature">The creature object.</param>
    /// <param name="level">The level.</param>
    /// <param name="value">The value to set for level.</param>
    public static void SetSkillPointsRemainingByLevel(uint creature, int level, int value)
    {
      NWNXPushInt(value);
      NWNXPushInt(level);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSkillPointsRemainingByLevel");
    }

    /// Sets the creature&apos;s racial type
    /// <param name="creature">The creature object.</param>
    /// <param name="racialtype">The racial type to set.</param>
    public static void SetRacialType(uint creature, int racialtype)
    {
      NWNXPushInt(racialtype);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetRacialType");
    }

    /// Sets the creature&apos;s gold without sending a feedback message
    /// <param name="creature">The creature object.</param>
    /// <param name="gold">The amount of gold to set for their creature.</param>
    public static void SetGold(uint creature, int gold)
    {
      NWNXPushInt(gold);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetGold");
    }

    /// Sets corpse decay time in milliseconds
    /// <param name="creature">The creature object.</param>
    /// <param name="nDecayTime">The corpse decay time.</param>
    public static void SetCorpseDecayTime(uint creature, int nDecayTime)
    {
      NWNXPushInt(nDecayTime);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetCorpseDecayTime");
    }

    /// Gets the creature&apos;s base save.
    /// <param name="creature">The creature object.</param>
    /// <param name="which">One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL</param>
    /// <returns>The base save value.</returns>
    /// @note This will include any modifiers set in the toolset.
    public static int GetBaseSavingThrow(uint creature, int which)
    {
      NWNXPushInt(which);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetBaseSavingThrow");
      return NWNXPopInt();
    }

    /// Sets the creature&apos;s base save.
    /// <param name="creature">The creature object.</param>
    /// <param name="which">One of SAVING_THROW_FORT, SAVING_THROW_REFLEX or SAVING_THROW_WILL</param>
    /// <param name="value">The base save value.</param>
    public static void SetBaseSavingThrow(uint creature, int which, int value)
    {
      NWNXPushInt(value);
      NWNXPushInt(which);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetBaseSavingThrow");
    }

    /// Add levels of class to the creature, bypassing all validation
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id.</param>
    /// <param name="count">The amount of levels of class to add.</param>
    /// <param name="package">The class package to use for leveling up (PACKAGE_INVALID = starting package)</param>
    /// @note This will not work on player characters.
    public static void LevelUp(uint creature, int @class, int count = 1, int package = PACKAGE_INVALID)
    {
      NWNXPushInt(package);
      NWNXPushInt(count);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "LevelUp");
    }

    /// Remove last levels from a creature.
    /// <param name="creature">The creature object.</param>
    /// <param name="count">The amount of levels to decrement.</param>
    /// @note This will not work on player characters.
    public static void LevelDown(uint creature, int count = 1)
    {
      NWNXPushInt(count);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "LevelDown");
    }

    /// Sets the creature&apos;s challenge rating
    /// <param name="creature">The creature object.</param>
    /// <param name="fCR">The challenge rating.</param>
    public static void SetChallengeRating(uint creature, float fCR)
    {
      NWNXPushFloat(fCR);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetChallengeRating");
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
      NWNXPushInt(includeBaseAttackBonus);
      NWNXPushInt(isOffhand);
      NWNXPushInt(isTouchAttack);
      NWNXPushInt(isMelee);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetAttackBonus");
      return NWNXPopInt();
    }

    /// Get highest level version of feat possessed by creature.
    /// @remark For feats that increment in power, for example, barbarian rage.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The highest level version of the feat.</returns>
    public static int GetHighestLevelOfFeat(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetHighestLevelOfFeat");
      return NWNXPopInt();
    }

    /// Get feat remaining uses.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The amount of remaining uses.</returns>
    public static int GetFeatRemainingUses(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatRemainingUses");
      return NWNXPopInt();
    }

    /// Get feat total uses.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <returns>The total uses.</returns>
    public static int GetFeatTotalUses(uint creature, int feat)
    {
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetFeatTotalUses");
      return NWNXPopInt();
    }

    /// Set feat remaining uses.
    /// <param name="creature">The creature object.</param>
    /// <param name="feat">The feat id.</param>
    /// <param name="uses">The amount of remaining uses.</param>
    public static void SetFeatRemainingUses(uint creature, int feat, int uses)
    {
      NWNXPushInt(uses);
      NWNXPushInt(feat);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetFeatRemainingUses");
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
      NWNXPushInt(isOffhand);
      NWNXPushInt(abilityScore);
      NWNXPushInt(skill);
      NWNXPushInt(saveSpecificType);
      NWNXPushInt(savetype);
      NWNXPushInt(isForceMax);
      NWNXPushInt(isElemental);
      NWNXPushObject(target);
      NWNXPushInt(bonusType);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetTotalEffectBonus");
      return NWNXPopInt();
    }

    /// Set the original first or last name of creature
    /// <param name="creature">The creature object.</param>
    /// <param name="name">The name to give the creature.</param>
    /// <param name="isLastName">TRUE to change their last name, FALSE for first.</param>
    /// @note For PCs this will persist to the .bic file if saved. Requires a relog to update.
    public static void SetOriginalName(uint creature, string name, int isLastName)
    {
      NWNXPushInt(isLastName);
      NWNXPushString(name);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetOriginalName");
    }

    /// Get the original first or last name of creature
    /// <param name="creature">The creature object.</param>
    /// <param name="isLastName">TRUE to get last name, FALSE for first name.</param>
    /// <returns>The original first or last name of the creature.</returns>
    public static string GetOriginalName(uint creature, int isLastName)
    {
      NWNXPushInt(isLastName);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetOriginalName");
      return NWNXPopString();
    }

    /// Set creature&apos;s spell resistance
    /// <param name="creature">The creature object.</param>
    /// <param name="sr">The spell resistance.</param>
    /// @warning This setting will be overwritten by effects and once those effects fade the old setting (typically 0) will be set.
    public static void SetSpellResistance(uint creature, int sr)
    {
      NWNXPushInt(sr);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSpellResistance");
    }

    /// Set creature&apos;s animal companion creature type
    /// <param name="creature">The master creature object.</param>
    /// <param name="type">The type from ANIMAL_COMPANION_CREATURE_TYPE_*.</param>
    public static void SetAnimalCompanionCreatureType(uint creature, int type)
    {
      NWNXPushInt(type);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetAnimalCompanionCreatureType");
    }

    /// Set creature&apos;s familiar creature type
    /// <param name="creature">The master creature object.</param>
    /// <param name="type">The type from FAMILIAR_CREATURE_TYPE_*.</param>
    public static void SetFamiliarCreatureType(uint creature, int type)
    {
      NWNXPushInt(type);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetFamiliarCreatureType");
    }

    /// Set creature&apos;s animal companion&apos;s name
    /// <param name="creature">The master creature object.</param>
    /// <param name="name">The name to give their animal companion.</param>
    public static void SetAnimalCompanionName(uint creature, string name)
    {
      NWNXPushString(name);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetAnimalCompanionName");
    }

    /// Set creature&apos;s familiar&apos;s name
    /// <param name="creature">The master creature object.</param>
    /// <param name="name">The name to give their familiar.</param>
    public static void SetFamiliarName(uint creature, string name)
    {
      NWNXPushString(name);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetFamiliarName");
    }

    /// Get whether the creature can be disarmed.
    /// <param name="creature">The creature object.</param>
    /// <returns>TRUE if the creature can be disarmed.</returns>
    public static int GetDisarmable(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "GetDisarmable");
      return NWNXPopInt();
    }

    /// Set whether a creature can be disarmed.
    /// <param name="creature">The creature object.</param>
    /// <param name="disarmable">Set to TRUE if the creature can be disarmed.</param>
    public static void SetDisarmable(uint creature, int disarmable)
    {
      NWNXPushInt(disarmable);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetDisarmable");
    }

    /// Sets one of creature&apos;s domains.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="index">The first or second domain.</param>
    /// <param name="domain">The domain constant to set.</param>
    public static void SetDomain(uint creature, int @class, int index, int domain)
    {
      NWNXPushInt(domain);
      NWNXPushInt(index);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetDomain");
    }

    /// Sets creature&apos;s specialist school.
    /// <param name="creature">The creature object.</param>
    /// <param name="class">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="school">The school constant.</param>
    public static void SetSpecialization(uint creature, int @class, int school)
    {
      NWNXPushInt(school);
      NWNXPushInt(@class);
      NWNXPushObject(creature);
      NWNXCall(NWNX_Creature, "SetSpecialization");
    }

    /// Sets oCreatures faction to be the faction with id nFactionId.
    /// <param name="oCreature">The creature.</param>
    /// <param name="nFactionId">The faction id we want the creature to join.</param>
    public static void SetFaction(uint oCreature, int nFactionId)
    {
      NWNXPushInt(nFactionId);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetFaction");
    }

    /// Gets the faction id from oCreature
    /// <param name="oCreature">the creature we wish to query against</param>
    /// <returns>faction id as an integer, -1 when used against invalid creature or invalid object.</returns>
    public static int GetFaction(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetFaction");
      return NWNXPopInt();
    }

    /// Get whether a creature is flat-footed.
    /// <param name="oCreature">The creature object.</param>
    /// <returns>TRUE if the creature is flat-footed.</returns>
    public static int GetFlatFooted(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetFlatFooted");
      return NWNXPopInt();
    }

    /// Serialize oCreature&apos;s quickbar to a base64 string
    /// <param name="oCreature">The creature.</param>
    /// <returns>A base64 string representation of oCreature&apos;s quickbar.</returns>
    public static string SerializeQuickbar(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SerializeQuickbar");
      return NWNXPopString();
    }

    /// Deserialize sSerializedQuickbar for oCreature
    /// <param name="oCreature">The creature.</param>
    /// <param name="sSerializedQuickbar">A base64 string of a quickbar</param>
    /// <returns>TRUE on success</returns>
    public static int DeserializeQuickbar(uint oCreature, string sSerializedQuickbar)
    {
      NWNXPushString(sSerializedQuickbar);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "DeserializeQuickbar");
      return NWNXPopInt();
    }

    /// Sets a caster level modifier for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the class that this modifier will apply to</param>
    /// <param name="nModifier">the modifier to apply</param>
    /// <param name="bPersist">whether the modifier should be persisted to the .bic file if applicable</param>
    public static void SetCasterLevelModifier(uint oCreature, int nClass, int nModifier, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nModifier);
      NWNXPushInt(nClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCasterLevelModifier");
    }

    /// Gets the current caster level modifier for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the creature caster class</param>
    /// <returns>the current caster level modifier for the creature</returns>
    public static int GetCasterLevelModifier(uint oCreature, int nClass)
    {
      NWNXPushInt(nClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCasterLevelModifier");
      return NWNXPopInt();
    }

    /// Sets a caster level override for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the class that this modifier will apply to</param>
    /// <param name="nCasterLevel">the caster level override to apply</param>
    /// <param name="bPersist">whether the override should be persisted to the .bic file if applicable</param>
    public static void SetCasterLevelOverride(uint oCreature, int nClass, int nCasterLevel, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nCasterLevel);
      NWNXPushInt(nClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCasterLevelOverride");
    }

    /// Gets the current caster level override for oCreature
    /// <param name="oCreature">the target creature</param>
    /// <param name="nClass">the creature caster class</param>
    /// <returns>the current caster level override for the creature or -1 if not set</returns>
    public static int GetCasterLevelOverride(uint oCreature, int nClass)
    {
      NWNXPushInt(nClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCasterLevelOverride");
      return NWNXPopInt();
    }

    /// Move a creature to limbo.
    /// <param name="oCreature">The creature object.</param>
    public static void JumpToLimbo(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "JumpToLimbo");
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
      NWNXPushInt(nBaseItem);
      NWNXPushInt(bPersist);
      NWNXPushInt(nHand);
      NWNXPushInt(nModifier);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCriticalMultiplierModifier");
    }

    /// Gets the critical hit multiplier modifier for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem modifer to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit multiplier modifier for the creature</returns>
    public static int GetCriticalMultiplierModifier(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      NWNXPushInt(nBaseItem);
      NWNXPushInt(nHand);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCriticalMultiplierModifier");
      return NWNXPopInt();
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
      NWNXPushInt(nBaseItem);
      NWNXPushInt(bPersist);
      NWNXPushInt(nHand);
      NWNXPushInt(nOverride);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCriticalMultiplierOverride");
    }

    /// Gets the critical hit multiplier override for the Creature
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem Override to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit multiplier override for the creature. No override == -1</returns>
    public static int GetCriticalMultiplierOverride(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      NWNXPushInt(nBaseItem);
      NWNXPushInt(nHand);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCriticalMultiplierOverride");
      return NWNXPopInt();
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
      NWNXPushInt(nBaseItem);
      NWNXPushInt(bPersist);
      NWNXPushInt(nHand);
      NWNXPushInt(nModifier);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCriticalRangeModifier");
    }

    /// Gets the critical hit range modifier for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem modifer to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit range modifier for the creature</returns>
    public static int GetCriticalRangeModifier(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      NWNXPushInt(nBaseItem);
      NWNXPushInt(nHand);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCriticalRangeModifier");
      return NWNXPopInt();
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
      NWNXPushInt(nBaseItem);
      NWNXPushInt(bPersist);
      NWNXPushInt(nHand);
      NWNXPushInt(nOverride);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCriticalRangeOverride");
    }

    /// Sets the critical hit range Override for the creature.
    /// <param name="oCreature">The target creature</param>
    /// <param name="nHand">0 for all attacks, 1 for Mainhand, 2 for Offhand</param>
    /// <param name="nBaseItem">The baseitem Override to retrieve. BASE_ITEM_GLOVES for Unarmed, &apos;-1&apos; for all</param>
    /// <returns>the current critical hit range override for the creature. No override == -1</returns>
    public static int GetCriticalRangeOverride(uint oCreature, int nHand = 0, int nBaseItem = -1)
    {
      NWNXPushInt(nBaseItem);
      NWNXPushInt(nHand);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCriticalRangeOverride");
      return NWNXPopInt();
    }

    /// Add oAssociate as nAssociateType to oCreature
    /// @warning Only basic checks are done so care must be taken when using this function
    /// <param name="oCreature">The creature to add oAssociate to</param>
    /// <param name="oAssociate">The associate, must be a NPC</param>
    /// <param name="nAssociateType">The associate type, one of ASSOCIATE_TYPE_*, except _NONE</param>
    public static void AddAssociate(uint oCreature, uint oAssociate, int nAssociateType)
    {
      NWNXPushInt(nAssociateType);
      NWNXPushObject(oAssociate);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "AddAssociate");
    }

    /// Override the damage level of oCreature.
    /// @note Damage levels are the damage state under a creature&apos;s name, for example: &apos;Near Death&apos;
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nDamageLevel">A damage level, see damagelevels.2da. Allowed values: 0-255 or -1 to remove the override.</param>
    public static void OverrideDamageLevel(uint oCreature, int nDamageLevel)
    {
      NWNXPushInt(nDamageLevel);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "OverrideDamageLevel");
    }

    /// Set the encounter source of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="oEncounter">The source encounter</param>
    public static void SetEncounter(uint oCreature, uint oEncounter)
    {
      NWNXPushObject(oEncounter);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetEncounter");
    }

    /// Get the encounter source of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>The encounter, OBJECT_INVALID if not part of an encounter or on error</returns>
    public static uint GetEncounter(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetEncounter");
      return NWNXPopObject();
    }

    /// Get if oCreature is currently bartering.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>TRUE if oCreature is bartering, FALSE if not or on error.</returns>
    public static int GetIsBartering(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetIsBartering");
      return NWNXPopInt();
    }

    /// Sets caster level for the last item used. Use in a spellhook or spell event before to set caster level for any spells cast from the item.
    /// <param name="oCreature">the creature who used the item.</param>
    /// <param name="nCasterLvl">the desired caster level.</param>
    public static void SetLastItemCasterLevel(uint oCreature, int nCasterLvl)
    {
      NWNXPushInt(nCasterLvl);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetLastItemCasterLevel");
    }

    /// Gets the caster level of the last item used.
    /// <param name="oCreature">the creature who used the item.</param>
    /// <returns>returns the creatures last used item&apos;s level.</returns>
    public static int GetLastItemCasterLevel(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetLastItemCasterLevel");
      return NWNXPopInt();
    }

    /// Gets the Armor classed of attacked against versus
    /// <param name="oAttacked">The one being attacked</param>
    /// <param name="oVersus">The one doing the attacking</param>
    /// <param name="nTouch">TRUE for touch attacks</param>
    /// <returns>-255 on Error, Flat footed AC if oVersus is invalid or the Attacked AC versus oVersus.</returns>
    public static int GetArmorClassVersus(uint oAttacked, uint oVersus, int nTouch = FALSE)
    {
      NWNXPushInt(nTouch);
      NWNXPushObject(oVersus);
      NWNXPushObject(oAttacked);
      NWNXCall(NWNX_Creature, "GetArmorClassVersus");
      return NWNXPopInt();
    }

    /// Gets the current walk animation of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>-1 on Error, otherwise the walk animation number</returns>
    public static int GetWalkAnimation(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetWalkAnimation");
      return NWNXPopInt();
    }

    /// Sets the current walk animation of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="nAnimation">The walk animation number.</param>
    public static void SetWalkAnimation(uint oCreature, int nAnimation)
    {
      NWNXPushInt(nAnimation);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetWalkAnimation");
    }

    /// Changes the attack modifier depending on the dice roll. Used to skip autofail on 1 and autosucceed on 20 as well.
    /// <param name="oCreature">The attacking creature, use OBJECT_INVALID for all.</param>
    /// <param name="nRoll">The dice roll to modify.</param>
    /// <param name="nModifier">The modifier to the attack, use 0 to turn off autofail for 1/autosucceed for 20 with no attack modifier value.</param>
    public static void SetAttackRollOverride(uint oCreature, int nRoll, int nModifier)
    {
      NWNXPushInt(nModifier);
      NWNXPushInt(nRoll);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetAttackRollOverride");
    }

    /// Works like the tweak but can be turned on and off for all creatures or single ones.
    /// <param name="oCreature">The parrying creature, use OBJECT_INVALID for all.</param>
    /// <param name="bParry">TRUE to parry all attacks.</param>
    /// @note Use this command on_module_load instead of the NWNX_TWEAKS_PARRY_ALL_ATTACKS tweak if using NWNX_Creature_SetAttackRollOverride()
    public static void SetParryAllAttacks(uint oCreature, int bParry)
    {
      NWNXPushInt(bParry);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetParryAllAttacks");
    }

    /// Gets the NoPermanentDeath flag of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <returns>TRUE/FALSE or -1 on error.</returns>
    public static int GetNoPermanentDeath(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetNoPermanentDeath");
      return NWNXPopInt();
    }

    /// Sets the NoPermanentDeath flag of oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="bNoPermanentDeath">TRUE/FALSE.</param>
    public static void SetNoPermanentDeath(uint oCreature, int bNoPermanentDeath)
    {
      NWNXPushInt(bNoPermanentDeath);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetNoPermanentDeath");
    }

    /// Compute a safe location for oCreature.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="vPosition">The starting position.</param>
    /// <param name="fRadius">The search radius around vPosition.</param>
    /// <param name="bWalkStraightLineRequired">Whether the creature must be able to walk in a straight line to the position.</param>
    /// <returns>A safe location as vector, will return vPosition if one wasn&apos;t found. Returns {0.0, 0.0, 0.0} on error.</returns>
    public static System.Numerics.Vector3 ComputeSafeLocation(uint oCreature, System.Numerics.Vector3 vPosition, float fRadius = 20.0f, int bWalkStraightLineRequired = TRUE)
    {
      NWNXPushInt(bWalkStraightLineRequired);
      NWNXPushFloat(fRadius);
      NWNXPushVector(vPosition);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "ComputeSafeLocation");
      return NWNXPopVector( );
    }

    /// Update oCreature&apos;s perception of oTargetCreature.
    /// <param name="oCreature">The creature.</param>
    /// <param name="oTargetCreature">The target creature.</param>
    public static void DoPerceptionUpdateOnCreature(uint oCreature, uint oTargetCreature)
    {
      NWNXPushObject(oTargetCreature);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "DoPerceptionUpdateOnCreature");
    }

    /// Get a creatures personal space (meters from center to non-creature objects).
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures personal space.</returns>
    public static float GetPersonalSpace(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetPersonalSpace");
      return NWNXPopFloat();
    }

    /// Set a creatures personal space (meters from center to non-creature objects).
    /// <param name="oCreature">The creature.</param>
    /// <param name="fPerspace">The creatures personal space.</param>
    public static void SetPersonalSpace(uint oCreature, float fPerspace)
    {
      NWNXPushFloat(fPerspace);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetPersonalSpace");
    }

    /// Get a creatures creature personal space (meters from center to other creatures).
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures creature personal space.</returns>
    public static float GetCreaturePersonalSpace(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetCreaturePersonalSpace");
      return NWNXPopFloat();
    }

    /// Set a creatures creature personal space (meters from center to other creatures).
    /// <param name="oCreature">The creature.</param>
    /// <param name="fCrePerspace">The creatures creature personal space.</param>
    public static void SetCreaturePersonalSpace(uint oCreature, float fCrePerspace)
    {
      NWNXPushFloat(fCrePerspace);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetCreaturePersonalSpace");
    }

    /// Get a creatures height.
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures height.</returns>
    public static float GetHeight(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetHeight");
      return NWNXPopFloat();
    }

    /// Set a creatures height.
    /// <param name="oCreature">The creature.</param>
    /// <param name="fHeight">The creatures height.</param>
    public static void SetHeight(uint oCreature, float fHeight)
    {
      NWNXPushFloat(fHeight);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetHeight");
    }

    /// Get a creatures hit distance.
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures hit distance.</returns>
    public static float GetHitDistance(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetHitDistance");
      return NWNXPopFloat();
    }

    /// Set a creatures hit distance.
    /// <param name="oCreature">The creature.</param>
    /// <param name="fHitDist">The creatures hit distance.</param>
    public static void SetHitDistance(uint oCreature, float fHitDist)
    {
      NWNXPushFloat(fHitDist);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetHitDistance");
    }

    /// Get a creatures preferred attack distance.
    /// <param name="oCreature">The creature.</param>
    /// <returns>The creatures preferred attack distance.</returns>
    public static float GetPreferredAttackDistance(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetPreferredAttackDistance");
      return NWNXPopFloat();
    }

    /// Set a creatures preferred attack distance.
    /// <param name="oCreature">The creature.</param>
    /// <param name="fPrefAtckDist">The creatures preferred attack distance.</param>
    public static void SetPreferredAttackDistance(uint oCreature, float fPrefAtckDist)
    {
      NWNXPushFloat(fPrefAtckDist);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetPreferredAttackDistance");
    }

    /// Get the skill penalty from wearing armor.
    /// <param name="oCreature">The creature.</param>
    public static int GetArmorCheckPenalty(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetArmorCheckPenalty");
      return NWNXPopInt();
    }

    /// Get the skill penalty from wearing a shield.
    /// <param name="oCreature">The creature.</param>
    public static int GetShieldCheckPenalty(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetShieldCheckPenalty");
      return NWNXPopInt();
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
      NWNXPushInt(bPersist);
      NWNXPushInt(nChance);
      NWNXPushInt(nImmunityType);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetBypassEffectImmunity");
    }

    /// Gets a chance for normal Effect Immunities to be bypassed
    /// <param name="oCreature">The target creature</param>
    /// <param name="nImmunityType">&apos;IMMUNITY_TYPE_*&apos; to retrieve the current chance for bypass: Positive gets outgoing effects (oCreature -&gt; another creature). Negative (-IMMUNITY_TYPE_*) gets incoming effects (another creature -&gt; oCreature).</param>
    /// <returns>the current critical hit multiplier modifier for the creature</returns>
    public static int GetBypassEffectImmunity(uint oCreature, int nImmunityType)
    {
      NWNXPushInt(nImmunityType);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetBypassEffectImmunity");
      return NWNXPopInt();
    }

    /// Sets the killer of oCreature to oKiller.
    /// <param name="oCreature">The target creature.</param>
    /// <param name="oKiller">The killer.</param>
    public static void SetLastKiller(uint oCreature, uint oKiller)
    {
      NWNXPushObject(oKiller);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetLastKiller");
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
    /// <param name="oItem">The spell cast item retrieved by GetSpellCastItem().</param>
    /// <param name="sImpactScript">The spell impact script. Set to &quot;****&quot;&quot; to not run any impact script. If left blank, will execute nSpellID&apos;s impact script.</param>
    public static void DoItemCastSpell(uint oCreature, uint oTarget, System.IntPtr locTarget, int nSpellID, int nCasterLevel, float fProjectileTime, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT, int nProjectileSpellID = -1, uint oItem = OBJECT_INVALID, string sImpactScript = "")
    {
      NWNXPushString(sImpactScript);
      NWNXPushObject(oItem);
      NWNXPushInt(nProjectileSpellID);
      NWNXPushInt(nProjectilePathType);
      NWNXPushFloat(fProjectileTime);
      NWNXPushInt(nCasterLevel);
      NWNXPushInt(nSpellID);
      NWNXPushLocation(locTarget);
      NWNXPushObject(oTarget);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "DoItemCastSpell");
    }

    /// Have oCreature instantly equip oItem to nInventorySlot.
    /// <param name="oCreature">The creature.</param>
    /// <param name="oItem">The item, must be possessed by oCreature.</param>
    /// <param name="nInventorySlot">An INVENTORY_SLOT_* constant.</param>
    /// <returns>TRUE on success, FALSE on failure.</returns>
    public static int RunEquip(uint oCreature, uint oItem, int nInventorySlot)
    {
      NWNXPushInt(nInventorySlot);
      NWNXPushObject(oItem);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "RunEquip");
      return NWNXPopInt();
    }

    /// Have oCreature instantly unequip oItem.
    /// <param name="oCreature">The creature.</param>
    /// <param name="oItem">The item, must be possessed by oCreature.</param>
    /// <returns>TRUE on success, FALSE on failure.</returns>
    public static int RunUnequip(uint oCreature, uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "RunUnequip");
      return NWNXPopInt();
    }

    /// Override the elemental projectile visual effect of ranged/throwing weapons.
    /// <param name="oCreature">The creature.</param>
    /// <param name="nProjectileVFX">A @ref ranged_projectile_vfx &quot;NWNX_CREATURE_PROJECTILE_VFX_*&quot; constant or -1 to remove the override.</param>
    /// <param name="bPersist">Whether the vfx should persist to the .bic file (for PCs).</param>
    /// @note Persistence is enabled after a server reset by the first use of this function. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void OverrideRangedProjectileVFX(uint oCreature, int nProjectileVFX, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nProjectileVFX);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "OverrideRangedProjectileVFX");
    }

    /// Sets a custom Initiative modifier
    /// <param name="oCreature">The affected creature</param>
    /// <param name="nMod">The amount to adjust their initiative (+/-).</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file (for PCs)</param>
    /// @note Persistence is enabled after a server reset by the first use of this function. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    /// @warning This modifier takes precedence over an NWNX_Race Initiative modifier; they&apos;re not additive
    public static void SetInitiativeModifier(uint oCreature, int nMod, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nMod);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetInitiativeModifier");
    }

    /// Gets the custom Initiative modifier.
    /// <param name="oCreature">The target creature</param>
    /// <returns>the current custom initiative modifier for the creature</returns>
    public static int GetInitiativeModifier(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetInitiativeModifier");
      return NWNXPopInt();
    }

    /// Gets the Body Bag of a creature
    /// <param name="oCreature">The target creature</param>
    /// <returns>The creatures assigned Body Bag</returns>
    public static uint GetBodyBag(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetBodyBag");
      return NWNXPopObject();
    }

    /// Add a cast spell action to oCreature&apos;s action queue.
    /// <param name="oCreature">The creature casting the spell.</param>
    /// <param name="oTarget">The target, to cast at a location use the area as target.</param>
    /// <param name="vTargetLocation">The target location.</param>
    /// <param name="nSpellID">The spell ID.</param>
    /// <param name="nMultiClass">The character class position to cast the spell as. 0 = First Class, 1 = Second Class, 3 = Third Class. To cast a cheat spell use 255 and to cast a special ability use 254.</param>
    /// <param name="nMetaMagic">A METAMAGIC_* constant, except METAMAGIC_ANY.</param>
    /// <param name="nDomainLevel">The domain level if casting a domain spell.</param>
    /// <param name="nProjectilePathType">A PROJECTILE_PATH_TYPE_* constant.</param>
    /// <param name="bInstant">TRUE to instantly cast the spell.</param>
    /// <param name="bClearActions">TRUE to clear all actions.</param>
    /// <param name="bAddToFront">TRUE to add the cast spell action to the front of the action queue.</param>
    /// <returns>TRUE if the action was successfully added to oCreature&apos;s action queue.</returns>
    public static int AddCastSpellActions(uint oCreature, uint oTarget, System.Numerics.Vector3 vTargetLocation, int nSpellID, int nMultiClass, int nMetaMagic = METAMAGIC_NONE, int nDomainLevel = 0, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT, int bInstant = FALSE, int bClearActions = FALSE, int bAddToFront = FALSE)
    {
      NWNXPushInt(bAddToFront);
      NWNXPushInt(bClearActions);
      NWNXPushInt(bInstant);
      NWNXPushInt(nProjectilePathType);
      NWNXPushInt(nDomainLevel);
      NWNXPushInt(nMetaMagic);
      NWNXPushInt(nMultiClass);
      NWNXPushInt(nSpellID);
      NWNXPushVector(vTargetLocation);
      NWNXPushObject(oTarget);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "AddCastSpellActions");
      return NWNXPopInt();
    }

    /// Get whether oCreature is flanking oTargetCreature.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="oTargetCreature">The target creature object.</param>
    /// <returns>TRUE if oCreature is flanking oTargetCreature.</returns>
    public static int GetIsFlanking(uint oCreature, uint oTargetCreature)
    {
      NWNXPushObject(oTargetCreature);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetIsFlanking");
      return NWNXPopInt();
    }

    /// Decrements the remaining spell slots (innate casting) at a class level.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="nClass">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="nSpellLevel">The spell level.</param>
    public static void DecrementRemainingSpellSlots(uint oCreature, int nClass, int nSpellLevel)
    {
      NWNXPushInt(nSpellLevel);
      NWNXPushInt(nClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "DecrementRemainingSpellSlots");
    }

    /// Increments the remaining spell slots (innate casting) at a class level.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="nClass">The class id from classes.2da. (Not class index 0-2)</param>
    /// <param name="nSpellLevel">The spell level.</param>
    public static void IncrementRemainingSpellSlots(uint oCreature, int nClass, int nSpellLevel)
    {
      NWNXPushInt(nSpellLevel);
      NWNXPushInt(nClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "IncrementRemainingSpellSlots");
    }

    /// Gets the maximum number of bonus attacks a creature can have from EffectModifyAttacks().
    /// <param name="oCreature">The creature.</param>
    /// <returns>The maximum number of bonus attacks or 0 on error.</returns>
    public static int GetMaximumBonusAttacks(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetMaximumBonusAttacks");
      return NWNXPopInt();
    }

    /// Sets the maximum number of bonus attacks a creature can have from EffectModifyAttacks().
    /// @note This function also removes the limit of 5 bonus attacks from EffectModifyAttacks().
    /// <param name="oCreature">The creature.</param>
    /// <param name="nMaxBonusAttacks">The maximum number of bonus attacks. Values &lt; 0 will set the limit back to the default of 5.</param>
    /// <param name="bPersist">Whether the modifier should persist to .bic file (for PCs).</param>
    /// @note Persistence is enabled after a server reset by the first use of this function. Recommended to trigger on a dummy target OnModuleLoad to enable persistence.
    public static void SetMaximumBonusAttacks(uint oCreature, int nMaxBonusAttacks, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nMaxBonusAttacks);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetMaximumBonusAttacks");
    }

    /// Inserts a cleave or great cleave attack into oCreature&apos;s current attack round against the nearest enemy within melee reach.
    /// <param name="oCreature">The creature object.</param>
    /// @note oCreature must have the cleave or great cleave feats, must be in combat, and must have available attacks remaining in their combat round to use for cleave attack.
    public static void DoCleaveAttack(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "DoCleaveAttack");
    }

    /// Gets the current object oCreature&apos;s orientation is locked to.
    /// <param name="oCreature">The creature object.</param>
    /// <returns>The object oCreature&apos;s orientation is locked to, or OBJECT_INVALID if oCreature&apos;s orientation is not locked.</returns>
    public static uint GetLockOrientationToObject(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetLockOrientationToObject");
      return NWNXPopObject();
    }

    /// Locks oCreature&apos;s orientation to always face oTarget.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="oTarget">The target to lock oCreature&apos;s orientation to. Use OBJECT_INVALID to remove the orientation lock.</param>
    public static void SetLockOrientationToObject(uint oCreature, uint oTarget)
    {
      NWNXPushObject(oTarget);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetLockOrientationToObject");
    }

    /// Causes oCreature to broadcast an Attack of Opportunity against themself.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="oSingleCreature">A single creature to broadcast the Attack of Opporunity to. Use OBJECT_INVALID to broadcast to all nearby enemies.</param>
    /// <param name="bMovement">Whether the Attack of Opportunity was caused by movement.</param>
    public static void BroadcastAttackOfOpportunity(uint oCreature, uint oSingleCreature = OBJECT_INVALID, int bMovement = FALSE)
    {
      NWNXPushInt(bMovement);
      NWNXPushObject(oSingleCreature);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "BroadcastAttackOfOpportunity");
    }

    /// Returns the maximum price oStore will buy items from oCreature for.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="oStore">The store object.</param>
    /// <returns>The max buy price override. -1 = No maximum buy price, -2 = No override set.</returns>
    public static int GetMaxSellToStorePriceOverride(uint oCreature, uint oStore)
    {
      NWNXPushObject(oStore);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetMaxSellToStorePriceOverride");
      return NWNXPopInt();
    }

    /// Overrides the maximum price oStore will buy items from oCreature for.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="oStore">The store object.</param>
    /// <param name="nMaxSellToPrice">The maximum buy price override. -1 = No maximum buy price, -2 = Remove the override.</param>
    public static void SetMaxSellToStorePriceOverride(uint oCreature, uint oStore, int nMaxSellToPrice)
    {
      NWNXPushInt(nMaxSellToPrice);
      NWNXPushObject(oStore);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetMaxSellToStorePriceOverride");
    }

    /// Returns the creature&apos;s ability increase for nLevel.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="nLevel">The level.</param>
    /// <returns>An ABILITY_* constant, NWNX_CREATURE_ABILITY_NONE or -1 on error</returns>
    public static int GetAbilityIncreaseByLevel(uint oCreature, int nLevel)
    {
      NWNXPushInt(nLevel);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetAbilityIncreaseByLevel");
      return NWNXPopInt();
    }

    /// Sets the creature&apos;s ability increase for nLevel.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="nLevel">The level.</param>
    /// <param name="nAbility">ABILITY_* constant or NWNX_CREATURE_ABILITY_NONE</param>
    public static void SetAbilityIncreaseByLevel(uint oCreature, int nLevel, int nAbility)
    {
      NWNXPushInt(nAbility);
      NWNXPushInt(nLevel);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetAbilityIncreaseByLevel");
    }

    /// Returns the creature&apos;s maximum attack range to a target
    /// <param name="oCreature">The creature object.</param>
    /// <param name="oTarget">The target to get the maximum attack range to</param>
    /// <returns>The maximum attack range for oCreature to oTarget</returns>
    public static float GetMaxAttackRange(uint oCreature, uint oTarget)
    {
      NWNXPushObject(oTarget);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetMaxAttackRange");
      return NWNXPopFloat();
    }

    /// Returns the creature&apos;s multiclass limit.
    /// @note Only works on player characters.
    /// <param name="oCreature">The creature object. Has to be a player character.</param>
    /// <returns>The PCs multiclass limit. Returns 0 if no limit is set.</returns>
    public static int GetMulticlassLimit(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetMulticlassLimit");
      return NWNXPopInt();
    }

    /// Sets the creature&apos;s multiclass limit.
    /// @note Only works on player characters and only for future level ups.
    /// Classes already taken will continue to be available on level up.
    /// The limit must be lower than the server limit set in ruleset.2da MULTICLASS_LIMIT.
    /// Setting a value of 0 will remove the limit.
    /// <param name="oCreature">The creature object. Has to be a player character.</param>
    /// <param name="nLimit">The multiclass limit.</param>
    /// <param name="bPersist">Whether the limit should persist to the .bic file.</param>
    /// @note Persistence is enabled after a server reset by the first use of this function.
    public static void SetMulticlassLimit(uint oCreature, int nLimit, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nLimit);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "SetMulticlassLimit");
    }

    /// Gets the creature&apos;s number of bonus spells.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="nMultiClass">The character class position, starting at 0.</param>
    /// <param name="nSpellLevel">The spell level, 0 to 9.</param>
    public static int GetNumberOfBonusSpells(uint oCreature, int nMultiClass, int nSpellLevel)
    {
      NWNXPushInt(nSpellLevel);
      NWNXPushInt(nMultiClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "GetNumberOfBonusSpells");
      return NWNXPopInt();
    }

    /// Modifies the creature&apos;s number of bonus spells.
    /// <param name="oCreature">The creature object.</param>
    /// <param name="nMultiClass">The character class position, starting at 0.</param>
    /// <param name="nSpellLevel">The spell level, 0 to 9.</param>
    /// <param name="nDelta">The value to change the number of bonus spells by. Can be negative.</param>
    public static void ModifyNumberBonusSpells(uint oCreature, int nMultiClass, int nSpellLevel, int nDelta)
    {
      NWNXPushInt(nDelta);
      NWNXPushInt(nSpellLevel);
      NWNXPushInt(nMultiClass);
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Creature, "ModifyNumberBonusSpells");
    }

    // @}
  }

  public struct SpecialAbility
  {
    public int id;
    public int ready;
    public int level;
  }
}
