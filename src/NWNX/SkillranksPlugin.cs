namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_SkillRanks)]
    public class SkillranksPlugin
    {
        public const string NWNX_SkillRanks = "NWNX_SkillRanks";

        // /< @private
        // / @name SkillRanks Key Abilities
        // / @anchor skr_key_abilities
        // /
        // / The abilities as bits
        // / @{
        public const int NWNX_SKILLRANKS_KEY_ABILITY_STRENGTH = 1;

        // /< Strength
        public const int NWNX_SKILLRANKS_KEY_ABILITY_DEXTERITY = 2;

        // /< Dexterity
        public const int NWNX_SKILLRANKS_KEY_ABILITY_CONSTITUTION = 4;

        // /< Constitution
        public const int NWNX_SKILLRANKS_KEY_ABILITY_INTELLIGENCE = 8;

        // /< Intelligence
        public const int NWNX_SKILLRANKS_KEY_ABILITY_WISDOM = 16;

        // /< Wisdom
        public const int NWNX_SKILLRANKS_KEY_ABILITY_CHARISMA = 32;

        // /< Charisma
        // /@}
        // / @name SkillRanks Key Ability Calculation Method
        // / @anchor skr_key_ability_calc_bits
        // /
        // / Constants used to calculate the ability modifier for a skill.
        // / @{
        // / @warning Use only one of these calculations in your mask! If you use more than one the first will be used.
        public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_MIN = 64;

        // /< Use the minimum value of the provided ability scores.
        public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_MAX = 128;

        // /< Use the maximum value of the provided ability scores.
        public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_AVERAGE = 256;

        // /< Use the average value of the provided ability scores.
        public const int NWNX_SKILLRANKS_KEY_ABILITY_CALC_SUM = 512;

        // /< Use the sum of the provided ability scores.
        // /@}
        // / @brief A feat that manipulates skill ranks.
        // / @param iSkill The skill to check the feat count.
        // / @return The count of feats for a specific skill.
        public static int GetSkillFeatCountForSkill(int iSkill)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "GetSkillFeatCountForSkill");
            Internal.NativeFunctions.nwnxPushInt(iSkill);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Returns a skill feat.
        // / @param iSkill The skill.
        // / @param iFeat The feat.
        // / @return A constructed NWNX_SkillRanks_SkillFeat.
        public static SkillFeat GetSkillFeat(int iSkill, int iFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "GetSkillFeat");
            Internal.NativeFunctions.nwnxPushInt(iFeat);
            Internal.NativeFunctions.nwnxPushInt(iSkill);
            Internal.NativeFunctions.nwnxCallFunction();
            SkillFeat retVal;
            retVal.iKeyAbilityMask = Internal.NativeFunctions.nwnxPopInt();
            retVal.bBypassArmorCheckPenalty = Internal.NativeFunctions.nwnxPopInt();
            retVal.iDayOrNight = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAreaFlagsForbidden = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAreaFlagsRequired = Internal.NativeFunctions.nwnxPopInt();
            retVal.fClassLevelMod = Internal.NativeFunctions.nwnxPopFloat();
            retVal.sClasses = Internal.NativeFunctions.nwnxPopString();
            retVal.iFocusFeat = Internal.NativeFunctions.nwnxPopInt();
            retVal.iModifier = Internal.NativeFunctions.nwnxPopInt();
            retVal.iFeat = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSkill = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Returns a skill feat by index.
        // / @remark Generally used in a loop with NWNX_SkillRanks_GetSkillFeatCountForSkill().
        // / @param iSkill The skill.
        // / @param iIndex The index in the list of feats for the skill.
        // / @return A constructed NWNX_SkillRanks_SkillFeat.
        public static SkillFeat GetSkillFeatForSkillByIndex(int iSkill, int iIndex)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "GetSkillFeatForSkillByIndex");
            Internal.NativeFunctions.nwnxPushInt(iIndex);
            Internal.NativeFunctions.nwnxPushInt(iSkill);
            Internal.NativeFunctions.nwnxCallFunction();
            SkillFeat retVal;
            retVal.iKeyAbilityMask = Internal.NativeFunctions.nwnxPopInt();
            retVal.bBypassArmorCheckPenalty = Internal.NativeFunctions.nwnxPopInt();
            retVal.iDayOrNight = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAreaFlagsForbidden = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAreaFlagsRequired = Internal.NativeFunctions.nwnxPopInt();
            retVal.fClassLevelMod = Internal.NativeFunctions.nwnxPopFloat();
            retVal.sClasses = Internal.NativeFunctions.nwnxPopString();
            retVal.iFocusFeat = Internal.NativeFunctions.nwnxPopInt();
            retVal.iModifier = Internal.NativeFunctions.nwnxPopInt();
            retVal.iFeat = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSkill = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Modifies or creates a skill feat.
        // / @param skillFeat The defined NWNX_SkillRanks_SkillFeat.
        // / @param createIfNonExistent TRUE to create if the feat does not exist.
        public static void SetSkillFeat(SkillFeat skillFeat, int createIfNonExistent = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "SetSkillFeat");
            Internal.NativeFunctions.nwnxPushInt(createIfNonExistent);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iSkill);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iFeat);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iModifier);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iFocusFeat);
            Internal.NativeFunctions.nwnxPushString(skillFeat.sClasses);
            Internal.NativeFunctions.nwnxPushFloat(skillFeat.fClassLevelMod);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iAreaFlagsRequired);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iAreaFlagsForbidden);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iDayOrNight);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.bBypassArmorCheckPenalty);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iKeyAbilityMask);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Add classes to a skill feat instead of working with the NWNX_SkillRanks_SkillFeat::sClasses string.
        // /
        // / Manipulating the sClasses string in the NWNX_SkillRanks_SkillFeat struct can be difficult. This
        // / function allows the builder to enter one class at a time.
        // / @param skillFeat The NWNX_SkillRanks_SkillFeat for which the sClasses field will be modifier.
        // / @param iClass The class to add to the Skill Feat.
        // / @return The updated NWNX_SkillRanks_SkillFeat.
        public static SkillFeat AddSkillFeatClass(SkillFeat skillFeat, int iClass)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "AddSkillFeatClass");
            Internal.NativeFunctions.nwnxPushInt(iClass);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iSkill);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iFeat);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iModifier);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iFocusFeat);
            Internal.NativeFunctions.nwnxPushString(skillFeat.sClasses);
            Internal.NativeFunctions.nwnxPushFloat(skillFeat.fClassLevelMod);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iAreaFlagsRequired);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iAreaFlagsForbidden);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iDayOrNight);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.bBypassArmorCheckPenalty);
            Internal.NativeFunctions.nwnxPushInt(skillFeat.iKeyAbilityMask);
            Internal.NativeFunctions.nwnxCallFunction();
            SkillFeat retVal;
            retVal.iKeyAbilityMask = Internal.NativeFunctions.nwnxPopInt();
            retVal.bBypassArmorCheckPenalty = Internal.NativeFunctions.nwnxPopInt();
            retVal.iDayOrNight = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAreaFlagsForbidden = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAreaFlagsRequired = Internal.NativeFunctions.nwnxPopInt();
            retVal.fClassLevelMod = Internal.NativeFunctions.nwnxPopFloat();
            retVal.sClasses = Internal.NativeFunctions.nwnxPopString();
            retVal.iFocusFeat = Internal.NativeFunctions.nwnxPopInt();
            retVal.iModifier = Internal.NativeFunctions.nwnxPopInt();
            retVal.iFeat = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSkill = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Change the modifier value for Skill Focus and Epic Skill Focus feats.
        // /
        // / The stock modifier on Skill Focus and Epic Skill Focus are 3 and 10 respectively, these can be
        // / changed with this function.
        // / @param iModifier The new value for the feat modifier.
        // / @param iEpic Set to TRUE to change the value for Epic Skill Focus.
        public static void SetSkillFeatFocusModifier(int iModifier, int iEpic = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "SetSkillFeatFocusModifier");
            Internal.NativeFunctions.nwnxPushInt(iEpic);
            Internal.NativeFunctions.nwnxPushInt(iModifier);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets the current penalty to Dexterity based skills when blind.
        // / @return The penalty to Dexterity when blind.
        public static int GetBlindnessPenalty()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "GetBlindnessPenalty");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set the value the Dexterity based skills get decreased due to blindness.
        // / @remark Default is 4.
        // / @param iModifier The penalty to Dexterity when blind.
        public static void SetBlindnessPenalty(int iModifier)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "SetBlindnessPenalty");
            Internal.NativeFunctions.nwnxPushInt(iModifier);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get a skill modifier for an area.
        // / @param oArea The area.
        // / @param iSkill The skill to check.
        // / @return The modifier to that skill in the area.
        public static int GetAreaModifier(uint oArea, int iSkill)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "GetAreaModifier");
            Internal.NativeFunctions.nwnxPushInt(iSkill);
            Internal.NativeFunctions.nwnxPushObject(oArea);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets a skill modifier for the area.
        // / @param oArea The area.
        // / @param iSkill The skill to change.
        // / @param iModifier The modifier to the skill in the area.
        public static void SetAreaModifier(uint oArea, int iSkill, int iModifier)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SkillRanks, "SetAreaModifier");
            Internal.NativeFunctions.nwnxPushInt(iModifier);
            Internal.NativeFunctions.nwnxPushInt(iSkill);
            Internal.NativeFunctions.nwnxPushObject(oArea);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
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
