namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_SkillRanks)]
  public class SkillranksPlugin
  {
    public const string NWNX_SkillRanks = "NWNX_SkillRanks";

    ///< @private
    /// @name SkillRanks Key Abilities
    /// @anchor skr_key_abilities
    ///
    /// The abilities as bits
    /// @{
    public const int NWNX_SKILLRANKS_KEY_ABILITY_STRENGTH = 1;

    ///< Strength
    public const int NWNX_SKILLRANKS_KEY_ABILITY_DEXTERITY = 2;

    ///< Dexterity
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CONSTITUTION = 4;

    ///< Constitution
    public const int NWNX_SKILLRANKS_KEY_ABILITY_INTELLIGENCE = 8;

    ///< Intelligence
    public const int NWNX_SKILLRANKS_KEY_ABILITY_WISDOM = 16;

    ///< Wisdom
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CHARISMA = 32;

    ///< Charisma
    ///@}
    /// @name SkillRanks Key Ability Calculation Method
    /// @anchor skr_key_ability_calc_bits
    ///
    /// Constants used to calculate the ability modifier for a skill.
    /// @{
    /// @warning Use only one of these calculations in your mask! If you use more than one the first will be used.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_MIN = 64;

    ///< Use the minimum value of the provided ability scores.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_MAX = 128;

    ///< Use the maximum value of the provided ability scores.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_AVERAGE = 256;

    ///< Use the average value of the provided ability scores.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_SUM = 512;

    ///< Use the sum of the provided ability scores.
    ///@}
    /// A feat that manipulates skill ranks.
    /// <param name="iSkill">The skill to check the feat count.</param>
    /// <returns>The count of feats for a specific skill.</returns>
    public static int GetSkillFeatCountForSkill(int iSkill)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "GetSkillFeatCountForSkill");
      VM.NWNX.StackPush(iSkill);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns a skill feat.
    /// <param name="iSkill">The skill.</param>
    /// <param name="iFeat">The feat.</param>
    /// <returns>A constructed NWNX_SkillRanks_SkillFeat.</returns>
    public static SkillFeat GetSkillFeat(int iSkill, int iFeat)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "GetSkillFeat");
      VM.NWNX.StackPush(iFeat);
      VM.NWNX.StackPush(iSkill);
      VM.NWNX.Call();
      SkillFeat skillFeat = default;
      skillFeat.iSkill = iSkill;
      skillFeat.iFeat = iFeat;
      skillFeat.iModifier = VM.NWNX.StackPopInt();
      skillFeat.iFocusFeat = VM.NWNX.StackPopInt();
      skillFeat.sClasses = VM.NWNX.StackPopString();
      skillFeat.fClassLevelMod = VM.NWNX.StackPopFloat();
      skillFeat.iAreaFlagsRequired = VM.NWNX.StackPopInt();
      skillFeat.iAreaFlagsForbidden = VM.NWNX.StackPopInt();
      skillFeat.iDayOrNight = VM.NWNX.StackPopInt();
      skillFeat.bBypassArmorCheckPenalty = VM.NWNX.StackPopInt();
      skillFeat.iKeyAbilityMask = VM.NWNX.StackPopInt();
      return skillFeat;
    }

    /// Returns a skill feat by index.
    /// @remark Generally used in a loop with NWNX_SkillRanks_GetSkillFeatCountForSkill().
    /// <param name="iSkill">The skill.</param>
    /// <param name="iIndex">The index in the list of feats for the skill.</param>
    /// <returns>A constructed NWNX_SkillRanks_SkillFeat.</returns>
    public static SkillFeat GetSkillFeatForSkillByIndex(int iSkill, int iIndex)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "GetSkillFeatForSkillByIndex");
      VM.NWNX.StackPush(iIndex);
      VM.NWNX.StackPush(iSkill);
      VM.NWNX.Call();
      SkillFeat skillFeat = default;
      skillFeat.iSkill = iSkill;
      skillFeat.iFeat = VM.NWNX.StackPopInt();
      skillFeat.iModifier = VM.NWNX.StackPopInt();
      skillFeat.iFocusFeat = VM.NWNX.StackPopInt();
      skillFeat.sClasses = VM.NWNX.StackPopString();
      skillFeat.fClassLevelMod = VM.NWNX.StackPopFloat();
      skillFeat.iAreaFlagsRequired = VM.NWNX.StackPopInt();
      skillFeat.iAreaFlagsForbidden = VM.NWNX.StackPopInt();
      skillFeat.iDayOrNight = VM.NWNX.StackPopInt();
      skillFeat.bBypassArmorCheckPenalty = VM.NWNX.StackPopInt();
      skillFeat.iKeyAbilityMask = VM.NWNX.StackPopInt();
      return skillFeat;
    }

    /// Modifies or creates a skill feat.
    /// <param name="skillFeat">The defined NWNX_SkillRanks_SkillFeat.</param>
    /// <param name="createIfNonExistent">TRUE to create if the feat does not exist.</param>
    public static void SetSkillFeat(SkillFeat skillFeat, int createIfNonExistent = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "SetSkillFeat");
      VM.NWNX.StackPush(createIfNonExistent);
      VM.NWNX.StackPush(skillFeat.iKeyAbilityMask);
      VM.NWNX.StackPush(skillFeat.bBypassArmorCheckPenalty);
      VM.NWNX.StackPush(skillFeat.iDayOrNight);
      VM.NWNX.StackPush(skillFeat.iAreaFlagsForbidden);
      VM.NWNX.StackPush(skillFeat.iAreaFlagsRequired);
      VM.NWNX.StackPush(skillFeat.fClassLevelMod);
      VM.NWNX.StackPush( NWScript.GetStringRight( skillFeat.sClasses, NWScript.GetStringLength( skillFeat.sClasses) -NWScript.FindSubString( skillFeat.sClasses, "1") ));
      VM.NWNX.StackPush(skillFeat.iFocusFeat);
      VM.NWNX.StackPush(skillFeat.iModifier);
      VM.NWNX.StackPush(skillFeat.iFeat);
      VM.NWNX.StackPush(skillFeat.iSkill);
      VM.NWNX.Call();
    }

    /// Add classes to a skill feat instead of working with the NWNX_SkillRanks_SkillFeat::sClasses string.
    ///
    /// Manipulating the sClasses string in the NWNX_SkillRanks_SkillFeat struct can be difficult. This
    /// function allows the builder to enter one class at a time.
    /// <param name="skillFeat">The NWNX_SkillRanks_SkillFeat for which the sClasses field will be modifier.</param>
    /// <param name="iClass">The class to add to the Skill Feat.</param>
    /// <returns>The updated NWNX_SkillRanks_SkillFeat.</returns>
    public static SkillFeat AddSkillFeatClass(SkillFeat skillFeat, int iClass)
    {
      if (NWScript.GetStringLength( skillFeat.sClasses) <255)
      {
        int i;
        string sPad = "";
        for (i=0; i<255-NWScript.GetStringLength( skillFeat.sClasses); i++)
        {
          sPad = sPad+"0";
        }
        skillFeat.sClasses = sPad+skillFeat.sClasses;
      }
      skillFeat.sClasses = NWScript.GetStringLeft( skillFeat.sClasses, 254-iClass) +"1"+NWScript.GetStringRight( skillFeat.sClasses, iClass);
      return skillFeat;
    }

    /// Change the modifier value for Skill Focus and Epic Skill Focus feats.
    ///
    /// The stock modifier on Skill Focus and Epic Skill Focus are 3 and 10 respectively, these can be
    /// changed with this function.
    /// <param name="iModifier">The new value for the feat modifier.</param>
    /// <param name="iEpic">Set to TRUE to change the value for Epic Skill Focus.</param>
    public static void SetSkillFeatFocusModifier(int iModifier, int epicFocus = NWScript.FALSE)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "SetSkillFeatFocusModifier");
      VM.NWNX.StackPush(epicFocus);
      VM.NWNX.StackPush(iModifier);
      VM.NWNX.Call();
    }

    /// Gets the current penalty to Dexterity based skills when blind.
    /// <returns>The penalty to Dexterity when blind.</returns>
    public static int GetBlindnessPenalty()
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "GetBlindnessPenalty");
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the value the Dexterity based skills get decreased due to blindness.
    /// @remark Default is 4.
    /// <param name="iModifier">The penalty to Dexterity when blind.</param>
    public static void SetBlindnessPenalty(int iModifier)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "SetBlindnessPenalty");
      VM.NWNX.StackPush(iModifier);
      VM.NWNX.Call();
    }

    /// Get a skill modifier for an area.
    /// <param name="oArea">The area.</param>
    /// <param name="iSkill">The skill to check.</param>
    /// <returns>The modifier to that skill in the area.</returns>
    public static int GetAreaModifier(uint oArea, int iSkill)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "GetAreaModifier");
      VM.NWNX.StackPush(iSkill);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sets a skill modifier for the area.
    /// <param name="oArea">The area.</param>
    /// <param name="iSkill">The skill to change.</param>
    /// <param name="iModifier">The modifier to the skill in the area.</param>
    public static void SetAreaModifier(uint oArea, int iSkill, int iModifier)
    {
      VM.NWNX.SetFunction(NWNX_SkillRanks, "SetAreaModifier");
      VM.NWNX.StackPush(iModifier);
      VM.NWNX.StackPush(iSkill);
      VM.NWNX.StackPush(oArea);
      VM.NWNX.Call();
    }

    /// @}
  }

  public struct SkillFeat
  {
    public int iSkill;
    public int iFeat;
    public int iModifier;
    public int iFocusFeat;
    public string sClasses;
    public float fClassLevelMod;
    public int iAreaFlagsRequired;
    public int iAreaFlagsForbidden;
    public int iDayOrNight;
    public int bBypassArmorCheckPenalty;
    public int iKeyAbilityMask;
  }
}
