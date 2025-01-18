using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_SkillRanks)]
  public class SkillranksPlugin
  {
    /// @addtogroup skillranks SkillRanks
    /// Enhances and allows for manipulation of skill rank calculations including the ability to build custom
    /// skill related feats as well as modifying stock feats.
    /// @{
    /// @file nwnx_skillranks.nss
    public const string NWNX_SkillRanks = "NWNX_SkillRanks";

    ///&lt; @private
    /// @name SkillRanks Key Abilities
    /// @anchor skr_key_abilities
    ///
    /// The abilities as bits
    /// @{
    public const int NWNX_SKILLRANKS_KEY_ABILITY_STRENGTH = 1;

    ///&lt; Strength
    public const int NWNX_SKILLRANKS_KEY_ABILITY_DEXTERITY = 2;

    ///&lt; Dexterity
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CONSTITUTION = 4;

    ///&lt; Constitution
    public const int NWNX_SKILLRANKS_KEY_ABILITY_INTELLIGENCE = 8;

    ///&lt; Intelligence
    public const int NWNX_SKILLRANKS_KEY_ABILITY_WISDOM = 16;

    ///&lt; Wisdom
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CHARISMA = 32;

    ///&lt; Charisma
    ///@}
    /// @name SkillRanks Key Ability Calculation Method
    /// @anchor skr_key_ability_calc_bits
    ///
    /// Constants used to calculate the ability modifier for a skill.
    /// @{
    /// @warning Use only one of these calculations in your mask! If you use more than one the first will be used.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_MIN = 64;

    ///&lt; Use the minimum value of the provided ability scores.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_MAX = 128;

    ///&lt; Use the maximum value of the provided ability scores.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_AVERAGE = 256;

    ///&lt; Use the average value of the provided ability scores.
    public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_SUM = 512;

    ///&lt; Use the sum of the provided ability scores.
    ///@}
    /// A feat that manipulates skill ranks.
    /// <param name="iSkill">The skill to check the feat count.</param>
    /// <returns>The count of feats for a specific skill.</returns>
    public static int GetSkillFeatCountForSkill(int iSkill)
    {
      NWNXPushInt(iSkill);
      NWNXCall(NWNX_SkillRanks, "GetSkillFeatCountForSkill");
      return NWNXPopInt();
    }

    /// Returns a skill feat.
    /// <param name="iSkill">The skill.</param>
    /// <param name="iFeat">The feat.</param>
    /// <returns>A constructed NWNX_SkillRanks_SkillFeat.</returns>
    public static SkillFeat GetSkillFeat(int iSkill, int iFeat)
    {
      NWNXPushInt(iFeat);
      NWNXPushInt(iSkill);
      NWNXCall(NWNX_SkillRanks, "GetSkillFeat");
      SkillFeat skillFeat = default;
      skillFeat.iSkill = iSkill;
      skillFeat.iFeat = iFeat;
      skillFeat.iModifier = NWNXPopInt();
      skillFeat.iFocusFeat = NWNXPopInt();
      skillFeat.sClasses = NWNXPopString();
      skillFeat.fClassLevelMod = NWNXPopFloat();
      skillFeat.iAreaFlagsRequired = NWNXPopInt();
      skillFeat.iAreaFlagsForbidden = NWNXPopInt();
      skillFeat.iDayOrNight = NWNXPopInt();
      skillFeat.bBypassArmorCheckPenalty = NWNXPopInt();
      skillFeat.iKeyAbilityMask = NWNXPopInt();
      return skillFeat;
    }

    /// Returns a skill feat by index.
    /// @remark Generally used in a loop with NWNX_SkillRanks_GetSkillFeatCountForSkill().
    /// <param name="iSkill">The skill.</param>
    /// <param name="iIndex">The index in the list of feats for the skill.</param>
    /// <returns>A constructed NWNX_SkillRanks_SkillFeat.</returns>
    public static SkillFeat GetSkillFeatForSkillByIndex(int iSkill, int iIndex)
    {
      NWNXPushInt(iIndex);
      NWNXPushInt(iSkill);
      NWNXCall(NWNX_SkillRanks, "GetSkillFeatForSkillByIndex");
      SkillFeat skillFeat = default;
      skillFeat.iSkill = iSkill;
      skillFeat.iFeat = NWNXPopInt();
      skillFeat.iModifier = NWNXPopInt();
      skillFeat.iFocusFeat = NWNXPopInt();
      skillFeat.sClasses = NWNXPopString();
      skillFeat.fClassLevelMod = NWNXPopFloat();
      skillFeat.iAreaFlagsRequired = NWNXPopInt();
      skillFeat.iAreaFlagsForbidden = NWNXPopInt();
      skillFeat.iDayOrNight = NWNXPopInt();
      skillFeat.bBypassArmorCheckPenalty = NWNXPopInt();
      skillFeat.iKeyAbilityMask = NWNXPopInt();
      return skillFeat;
    }

    /// Modifies or creates a skill feat.
    /// <param name="skillFeat">The defined NWNX_SkillRanks_SkillFeat.</param>
    /// <param name="createIfNonExistent">TRUE to create if the feat does not exist.</param>
    public static void SetSkillFeat(SkillFeat skillFeat, int createIfNonExistent = FALSE)
    {
      NWNXPushInt(createIfNonExistent);
      NWNXPushInt(skillFeat.iKeyAbilityMask);
      NWNXPushInt(skillFeat.bBypassArmorCheckPenalty);
      NWNXPushInt(skillFeat.iDayOrNight);
      NWNXPushInt(skillFeat.iAreaFlagsForbidden);
      NWNXPushInt(skillFeat.iAreaFlagsRequired);
      NWNXPushFloat(skillFeat.fClassLevelMod);
      NWNXPushString(GetStringRight(skillFeat.sClasses, GetStringLength( skillFeat.sClasses) -FindSubString( skillFeat.sClasses, "1")));
      NWNXPushInt(skillFeat.iFocusFeat);
      NWNXPushInt(skillFeat.iModifier);
      NWNXPushInt(skillFeat.iFeat);
      NWNXPushInt(skillFeat.iSkill);
      NWNXCall(NWNX_SkillRanks, "SetSkillFeat");
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
      if (GetStringLength( skillFeat.sClasses) <255)
      {
        int i;
        string sPad = "";
        for (i=0; i<255-GetStringLength( skillFeat.sClasses); i++)
        {
          sPad = sPad+"0";
        }
        skillFeat.sClasses = sPad+skillFeat.sClasses;
      }
      skillFeat.sClasses = GetStringLeft( skillFeat.sClasses, 254-iClass) +"1"+GetStringRight( skillFeat.sClasses, iClass);
      return skillFeat;
    }

    /// Change the modifier value for Skill Focus and Epic Skill Focus feats.
    ///
    /// The stock modifier on Skill Focus and Epic Skill Focus are 3 and 10 respectively, these can be
    /// changed with this function.
    /// <param name="iModifier">The new value for the feat modifier.</param>
    /// <param name="iEpic">Set to TRUE to change the value for Epic Skill Focus.</param>
    public static void SetSkillFeatFocusModifier(int iModifier, int epicFocus = FALSE)
    {
      NWNXPushInt(epicFocus);
      NWNXPushInt(iModifier);
      NWNXCall(NWNX_SkillRanks, "SetSkillFeatFocusModifier");
    }

    /// Gets the current penalty to Dexterity based skills when blind.
    /// <returns>The penalty to Dexterity when blind.</returns>
    public static int GetBlindnessPenalty()
    {
      NWNXCall(NWNX_SkillRanks, "GetBlindnessPenalty");
      return NWNXPopInt();
    }

    /// Set the value the Dexterity based skills get decreased due to blindness.
    /// @remark Default is 4.
    /// <param name="iModifier">The penalty to Dexterity when blind.</param>
    public static void SetBlindnessPenalty(int iModifier)
    {
      NWNXPushInt(iModifier);
      NWNXCall(NWNX_SkillRanks, "SetBlindnessPenalty");
    }

    /// Get a skill modifier for an area.
    /// <param name="oArea">The area.</param>
    /// <param name="iSkill">The skill to check.</param>
    /// <returns>The modifier to that skill in the area.</returns>
    public static int GetAreaModifier(uint oArea, int iSkill)
    {
      NWNXPushInt(iSkill);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_SkillRanks, "GetAreaModifier");
      return NWNXPopInt();
    }

    /// Sets a skill modifier for the area.
    /// <param name="oArea">The area.</param>
    /// <param name="iSkill">The skill to change.</param>
    /// <param name="iModifier">The modifier to the skill in the area.</param>
    public static void SetAreaModifier(uint oArea, int iSkill, int iModifier)
    {
      NWNXPushInt(iModifier);
      NWNXPushInt(iSkill);
      NWNXPushObject(oArea);
      NWNXCall(NWNX_SkillRanks, "SetAreaModifier");
    }

    // @}
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
