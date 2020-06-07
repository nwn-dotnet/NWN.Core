using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_Weapon)]
    public class WeaponPlugin
    {
        public const string NWNX_Weapon = "NWNX_Weapon";

        // /< @private
        // / @name Weapons Options
        // / @anchor wpn_opts
        // /
        // / Options constants to be used with NWNX_Weapon_SetOption function.
        // / @{
        public const int NWNX_WEAPON_OPT_GRTFOCUS_AB_BONUS = 0;

        // /< Greater Focus Attack Bonus
        public const int NWNX_WEAPON_OPT_GRTSPEC_DAM_BONUS = 1;

        // /< Greater Specialization Damage Bonus
        // /@}
        //  Get Event Data Constants
        public const int NWNX_WEAPON_GETDATA_DC = 0;

        // /< Get Devastating Critical Data
        //  Set Event Data Constants
        public const int NWNX_WEAPON_SETDATA_DC_BYPASS = 0;

        // /< Set Devastating Critical Bypass
        // / Devastating critical event data
        // / @brief Set nFeat as weapon focus feat for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetWeaponFocusFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponFocusFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set required creature size for a weapon base item to be finessable.
        // / @param nBaseItem The base item id.
        // / @param nSize The creature size minimum to consider this weapon finessable.
        public static void SetWeaponFinesseSize(int nBaseItem, int nSize)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponFinesseSize");
            Internal.NativeFunctions.nwnxPushInt(nSize);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get required creature size for a weapon base item to be finessable.
        // / @param nBaseItem The base item id.
        public static int GetWeaponFinesseSize(int nBaseItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "GetWeaponFinesseSize");
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set weapon base item to be considered as unarmed for weapon finesse feat.
        // / @param nBaseItem The base item id.
        public static void SetWeaponUnarmed(int nBaseItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponUnarmed");
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as weapon improved critical for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetWeaponImprovedCriticalFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponImprovedCriticalFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as weapon specialization for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetWeaponSpecializationFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponSpecializationFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as epic weapon focus for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetEpicWeaponFocusFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetEpicWeaponFocusFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as epic weapon specialization for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetEpicWeaponSpecializationFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetEpicWeaponSpecializationFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as epic weapon overwhelming critical for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetEpicWeaponOverwhelmingCriticalFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetEpicWeaponOverwhelmingCriticalFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as epic weapon devastating critical for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetEpicWeaponDevastatingCriticalFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetEpicWeaponDevastatingCriticalFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as weapon of choice for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetWeaponOfChoiceFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponOfChoiceFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as greater weapon specialization for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetGreaterWeaponSpecializationFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetGreaterWeaponSpecializationFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set a feat as greater weapon focus for a base item.
        // / @param nBaseItem The base item id.
        // / @param nFeat The feat to set.
        public static void SetGreaterWeaponFocusFeat(int nBaseItem, int nFeat)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetGreaterWeaponFocusFeat");
            Internal.NativeFunctions.nwnxPushInt(nFeat);
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set base item as monk weapon.
        // / @param nBaseItem The base item id.
        public static void SetWeaponIsMonkWeapon(int nBaseItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetWeaponIsMonkWeapon");
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set plugin options.
        // / @param nOption The option to change from @ref wpn_opts "Weapon Options".
        // / @param nVal The new value of the option.
        public static void SetOption(int nOption, int nVal)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetOption");
            Internal.NativeFunctions.nwnxPushInt(nVal);
            Internal.NativeFunctions.nwnxPushInt(nOption);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set Devastating Critical Event Script.
        // / @param sScript The script to call when a Devastating Critical occurs.
        public static void SetDevastatingCriticalEventScript(string sScript)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "SetDevastatingCriticalEventScript");
            Internal.NativeFunctions.nwnxPushString(sScript);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get Devastating Critical Event Data.
        // / @note This is only for use with the Devastating Critical Event Script.
        // / @return An NWNX_Weapon_DevastatingCriticalEvent_Data struct.
        public static DevastatingCriticalEvent_Data GetDevastatingCriticalEventData()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "GetDevastatingCriticalEventData");
            Internal.NativeFunctions.nwnxCallFunction();
            DevastatingCriticalEvent_Data retVal;
            retVal.nDamage = Internal.NativeFunctions.nwnxPopInt();
            retVal.oTarget = Internal.NativeFunctions.nwnxPopObject();
            retVal.oWeapon = Internal.NativeFunctions.nwnxPopObject();
            return retVal;
        }

        // / @brief Bypass Devastating Critical.
        // / @note This is only for use with the Devastating Critical Event Script.
        public static void BypassDevastatingCritical()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Weapon, "BypassDevastatingCritical");
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
    }

        public struct DevastatingCriticalEvent_Data
        {
            public uint oWeapon;
            public uint oTarget;
            public int nDamage;
        }
}
