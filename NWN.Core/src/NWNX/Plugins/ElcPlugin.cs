using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_ELC)]
  public class ElcPlugin
  {
    public const string NWNX_ELC = "NWNX_ELC";

    ///&lt; @private
    /// @anchor elc_fail_type
    /// @name ELC Failure Types
    /// @{
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_NONE = 0;
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_CHARACTER = 1;
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_ITEM = 2;
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_SKILL = 3;
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_FEAT = 4;
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_SPELL = 5;
    public const int NWNX_ELC_VALIDATION_FAILURE_TYPE_CUSTOM = 6;

    // @}
    /// @anchor elc_fail_subtype
    /// @name ELC Failure Subtypes
    /// @{
    public const int NWNX_ELC_SUBTYPE_NONE = 0;
    public const int NWNX_ELC_SUBTYPE_SERVER_LEVEL_RESTRICTION = 1;
    public const int NWNX_ELC_SUBTYPE_LEVEL_HACK = 2;
    public const int NWNX_ELC_SUBTYPE_COLORED_NAME = 3;
    public const int NWNX_ELC_SUBTYPE_UNIDENTIFIED_EQUIPPED_ITEM = 4;
    public const int NWNX_ELC_SUBTYPE_MIN_EQUIP_LEVEL = 5;
    public const int NWNX_ELC_SUBTYPE_NON_PC_CHARACTER = 6;
    public const int NWNX_ELC_SUBTYPE_DM_CHARACTER = 7;
    public const int NWNX_ELC_SUBTYPE_NON_PLAYER_RACE = 8;
    public const int NWNX_ELC_SUBTYPE_NON_PLAYER_CLASS = 9;
    public const int NWNX_ELC_SUBTYPE_CLASS_LEVEL_RESTRICTION = 10;
    public const int NWNX_ELC_SUBTYPE_PRESTIGE_CLASS_REQUIREMENTS = 11;
    public const int NWNX_ELC_SUBTYPE_CLASS_ALIGNMENT_RESTRICTION = 12;
    public const int NWNX_ELC_SUBTYPE_STARTING_ABILITY_VALUE_MAX = 13;
    public const int NWNX_ELC_SUBTYPE_ABILITY_POINT_BUY_SYSTEM_CALCULATION = 14;
    public const int NWNX_ELC_SUBTYPE_CLASS_SPELLCASTER_INVALID_PRIMARY_STAT = 15;
    public const int NWNX_ELC_SUBTYPE_EPIC_LEVEL_FLAG = 16;
    public const int NWNX_ELC_SUBTYPE_TOO_MANY_HITPOINTS = 17;
    public const int NWNX_ELC_SUBTYPE_UNUSABLE_SKILL = 18;
    public const int NWNX_ELC_SUBTYPE_NOT_ENOUGH_SKILLPOINTS = 19;
    public const int NWNX_ELC_SUBTYPE_INVALID_NUM_RANKS_IN_CLASS_SKILL = 20;
    public const int NWNX_ELC_SUBTYPE_INVALID_NUM_RANKS_IN_NON_CLASS_SKILL = 21;
    public const int NWNX_ELC_SUBTYPE_INVALID_NUM_REMAINING_SKILL_POINTS = 22;
    public const int NWNX_ELC_SUBTYPE_INVALID_FEAT = 23;
    public const int NWNX_ELC_SUBTYPE_FEAT_REQUIRED_SPELL_LEVEL_NOT_MET = 24;
    public const int NWNX_ELC_SUBTYPE_FEAT_REQUIRED_BASE_ATTACK_BONUS_NOT_MET = 25;
    public const int NWNX_ELC_SUBTYPE_FEAT_REQUIRED_ABILITY_VALUE_NOT_MET = 26;
    public const int NWNX_ELC_SUBTYPE_FEAT_REQUIRED_SKILL_NOT_MET = 27;
    public const int NWNX_ELC_SUBTYPE_FEAT_REQUIRED_FEAT_NOT_MET = 28;
    public const int NWNX_ELC_SUBTYPE_TOO_MANY_FEATS_THIS_LEVEL = 29;
    public const int NWNX_ELC_SUBTYPE_FEAT_NOT_AVAILABLE_TO_CLASS = 30;
    public const int NWNX_ELC_SUBTYPE_FEAT_IS_NORMAL_FEAT_ONLY = 31;
    public const int NWNX_ELC_SUBTYPE_FEAT_IS_BONUS_FEAT_ONLY = 32;
    public const int NWNX_ELC_SUBTYPE_SPELL_INVALID_SPELL_GAIN_WIZARD = 33;
    public const int NWNX_ELC_SUBTYPE_SPELL_INVALID_SPELL_GAIN_BARD_SORCERER = 34;
    public const int NWNX_ELC_SUBTYPE_SPELL_INVALID_SPELL_GAIN_OTHER_CLASSES = 35;
    public const int NWNX_ELC_SUBTYPE_INVALID_SPELL = 36;
    public const int NWNX_ELC_SUBTYPE_SPELL_INVALID_SPELL_LEVEL = 37;
    public const int NWNX_ELC_SUBTYPE_SPELL_MINIMUM_ABILITY = 40;
    public const int NWNX_ELC_SUBTYPE_SPELL_RESTRICTED_SPELL_SCHOOL = 41;
    public const int NWNX_ELC_SUBTYPE_SPELL_ALREADY_KNOWN = 42;
    public const int NWNX_ELC_SUBTYPE_SPELL_WIZARD_EXCEEDS_NUMSPELLS_TO_ADD = 43;
    public const int NWNX_ELC_SUBTYPE_ILLEGAL_REMOVED_SPELL = 44;
    public const int NWNX_ELC_SUBTYPE_REMOVED_NOT_KNOWN_SPELL = 45;
    public const int NWNX_ELC_SUBTYPE_INVALID_NUM_SPELLS = 46;
    public const int NWNX_ELC_SUBTYPE_SPELL_LIST_COMPARISON = 47;
    public const int NWNX_ELC_SUBTYPE_SKILL_LIST_COMPARISON = 48;
    public const int NWNX_ELC_SUBTYPE_FEAT_LIST_COMPARISON = 49;
    public const int NWNX_ELC_SUBTYPE_MISC_SAVING_THROW = 50;
    public const int NWNX_ELC_SUBTYPE_NUM_FEAT_COMPARISON = 51;
    public const int NWNX_ELC_SUBTYPE_NUM_MULTICLASS = 52;

    // @}
    /// Sets the script that runs whenever an ELC validation failure happens
    /// <param name="sScript">The script name.</param>
    public static void SetELCScript(string sScript)
    {
      const string sFunc = "SetELCScript";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.StackPush(sScript);
      VM.NWNX.Call();
    }

    /// Enables a custom ELC Check that will call the ELC Script with the
    /// NWNX_ELC_VALIDATION_FAILURE_TYPE_CUSTOM type.
    /// <param name="bEnabled">TRUE to use this check.</param>
    /// @note Only runs if you have an ELC script set, be sure to skip this check
    /// if a player doesn&apos;t fail your custom check otherwise they won&apos;t be able to log in
    public static void EnableCustomELCCheck(int bEnabled)
    {
      const string sFunc = "EnableCustomELCCheck";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.StackPush(bEnabled);
      VM.NWNX.Call();
    }

    /// Skip an ELC Validation Failure Event
    /// @note Only to be called in the ELC Script
    public static void SkipValidationFailure()
    {
      const string sFunc = "SkipValidationFailure";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
    }

    /// Get the validation failure type
    /// <returns>A @ref elc_fail_type &quot;Validation Failure Type&quot;</returns>
    /// @note Only to be called in the ELC Script
    public static int GetValidationFailureType()
    {
      const string sFunc = "GetValidationFailureType";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the validation failure subtype
    /// <returns>A @ref elc_fail_subtype &quot;Validation Failure Subtype&quot;</returns>
    /// @note Only to be called in the ELC Script
    public static int GetValidationFailureSubType()
    {
      const string sFunc = "GetValidationFailureSubType";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the failure message
    /// <returns>The talk table strref the player receives.</returns>
    /// @note Only to be called in the ELC Script
    public static int GetValidationFailureMessageStrRef()
    {
      const string sFunc = "GetValidationFailureMessageStrRef";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the failure message
    /// <param name="nStrRef">The talk table strref the player receives, must be &gt; 0.</param>
    /// @note Only to be called in the ELC Script
    public static void SetValidationFailureMessageStrRef(int nStrRef)
    {
      const string sFunc = "SetValidationFailureMessageStrRef";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.StackPush(nStrRef);
      VM.NWNX.Call();
    }

    /// Get the item that failed ILR validation
    /// <returns>The object that caused the ILR validation failure. Returns OBJECT_INVALID on error.</returns>
    /// @note Only to be called in the ELC Script during a
    /// NWNX_ELC_VALIDATION_FAILURE_TYPE_ITEM validation failure.
    public static uint GetValidationFailureItem()
    {
      const string sFunc = "GetValidationFailureItem";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Get the character level at which the validation failure occurred
    /// <returns>The character level or -1 on error.</returns>
    /// @remark May not always return a level, depending on where the failure occurred.
    /// @note Only to be called in the ELC Script
    public static int GetValidationFailureLevel()
    {
      const string sFunc = "GetValidationFailureLevel";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the ID of the skill that failed ELC validation
    /// <returns>The skill ID or -1 on error.</returns>
    /// @remark May not always return a skill id, depending on the validation failure subtype.
    /// @note Only to be called in the ELC Script during a
    /// NWNX_ELC_VALIDATION_FAILURE_TYPE_SKILL validation failure.
    public static int GetValidationFailureSkillID()
    {
      const string sFunc = "GetValidationFailureSkillID";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the ID of the feat that failed ELC validation
    /// <returns>The feat ID or -1 on error</returns>
    /// @remark May not always return a feat id, depending on the validation failure subtype.
    /// @note Only to be called in the ELC Script during a
    /// NWNX_ELC_VALIDATION_FAILURE_TYPE_FEAT validation failure.
    public static int GetValidationFailureFeatID()
    {
      const string sFunc = "GetValidationFailureFeatID";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get the ID of the spell that failed ELC validation
    /// <returns>The spell ID or -1 on error</returns>
    /// @remark May not always return a spell id, depending on the validation failure subtype.
    /// @note Only to be called in the ELC Script during a
    /// NWNX_ELC_VALIDATION_FAILURE_TYPE_SPELL validation failure.
    public static int GetValidationFailureSpellID()
    {
      const string sFunc = "GetValidationFailureSpellID";
      VM.NWNX.SetFunction(NWNX_ELC, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    // @}
  }
}
