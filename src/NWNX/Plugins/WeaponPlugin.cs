namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Weapon)]
    public class WeaponPlugin
    {
        public const string NWNX_Weapon = "NWNX_Weapon";

        ///< @private
        /// @name Weapons Options
        /// @anchor wpn_opts
        ///
        /// Options constants to be used with NWNX_Weapon_SetOption function.
        /// @{
        public const int NWNX_WEAPON_OPT_GRTFOCUS_AB_BONUS = 0;

        ///< Greater Focus Attack Bonus
        public const int NWNX_WEAPON_OPT_GRTSPEC_DAM_BONUS = 1;

        ///< Greater Specialization Damage Bonus
        ///@}
        // Get Event Data Constants
        public const int NWNX_WEAPON_GETDATA_DC = 0;

        ///< Get Devastating Critical Data
        // Set Event Data Constants
        public const int NWNX_WEAPON_SETDATA_DC_BYPASS = 0;

        ///< Set Devastating Critical Bypass
        /// Devastating critical event data
        /// Set nFeat as weapon focus feat for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetWeaponFocusFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponFocusFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set required creature size for a weapon base item to be finessable.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nSize">The creature size minimum to consider this weapon finessable.</param>
        public static void SetWeaponFinesseSize(int nBaseItem, int nSize)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponFinesseSize");
            VM.NWNX.StackPush(nSize);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Get required creature size for a weapon base item to be finessable.
        /// <param name="nBaseItem">The base item id.</param>
        public static int GetWeaponFinesseSize(int nBaseItem)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "GetWeaponFinesseSize");
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set weapon base item to be considered as unarmed for weapon finesse feat.
        /// <param name="nBaseItem">The base item id.</param>
        public static void SetWeaponUnarmed(int nBaseItem)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponUnarmed");
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as weapon improved critical for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetWeaponImprovedCriticalFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponImprovedCriticalFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as weapon specialization for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetWeaponSpecializationFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponSpecializationFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as epic weapon focus for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetEpicWeaponFocusFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetEpicWeaponFocusFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as epic weapon specialization for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetEpicWeaponSpecializationFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetEpicWeaponSpecializationFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as epic weapon overwhelming critical for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetEpicWeaponOverwhelmingCriticalFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetEpicWeaponOverwhelmingCriticalFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as epic weapon devastating critical for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetEpicWeaponDevastatingCriticalFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetEpicWeaponDevastatingCriticalFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as weapon of choice for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetWeaponOfChoiceFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponOfChoiceFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as greater weapon specialization for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetGreaterWeaponSpecializationFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetGreaterWeaponSpecializationFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set a feat as greater weapon focus for a base item.
        /// <param name="nBaseItem">The base item id.</param>
        /// <param name="nFeat">The feat to set.</param>
        public static void SetGreaterWeaponFocusFeat(int nBaseItem, int nFeat)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetGreaterWeaponFocusFeat");
            VM.NWNX.StackPush(nFeat);
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set base item as monk weapon.
        /// <param name="nBaseItem">The base item id.</param>
        public static void SetWeaponIsMonkWeapon(int nBaseItem)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetWeaponIsMonkWeapon");
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.Call();
        }

        /// Set plugin options.
        /// <param name="nOption">The option to change from @ref wpn_opts "Weapon Options".</param>
        /// <param name="nVal">The new value of the option.</param>
        public static void SetOption(int nOption, int nVal)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetOption");
            VM.NWNX.StackPush(nVal);
            VM.NWNX.StackPush(nOption);
            VM.NWNX.Call();
        }

        /// Set Devastating Critical Event Script.
        /// <param name="sScript">The script to call when a Devastating Critical occurs.</param>
        public static void SetDevastatingCriticalEventScript(string sScript)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetDevastatingCriticalEventScript");
            VM.NWNX.StackPush(sScript);
            VM.NWNX.Call();
        }

        /// Get Devastating Critical Event Data.
        /// @note This is only for use with the Devastating Critical Event Script.
        /// <returns>An NWNX_Weapon_DevastatingCriticalEvent_Data struct.</returns>
        public static DevastatingCriticalEvent_Data GetDevastatingCriticalEventData()
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "GetDevastatingCriticalEventData");
            VM.NWNX.Call();
            DevastatingCriticalEvent_Data retVal;
            retVal.nDamage = VM.NWNX.StackPopInt();
            retVal.oTarget = VM.NWNX.StackPopObject();
            retVal.oWeapon = VM.NWNX.StackPopObject();
            return retVal;
        }

        /// Bypass Devastating Critical.
        /// @note This is only for use with the Devastating Critical Event Script.
        public static void BypassDevastatingCritical()
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "BypassDevastatingCritical");
            VM.NWNX.Call();
        }

        /// Sets weapon to gain .5 strength bonus.
        /// <param name="oWeapon">Should be a melee weapon.</param>
        /// <param name="nEnable">TRUE for bonus. FALSE to turn off bonus.</param>
        /// <param name="bPersist">whether the two hand state should persist to the gff file.</param>
        public static void SetOneHalfStrength(uint oWeapon, int nEnable, int bPersist = NWScript.FALSE)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "SetOneHalfStrength");
            VM.NWNX.StackPush(bPersist);
            VM.NWNX.StackPush(nEnable);
            VM.NWNX.StackPush(oWeapon);
            VM.NWNX.Call();
        }

        /// Gets if the weapon is set to gain addition .5 strength bonus
        /// <param name="oWeapon">the weapon</param>
        /// <returns>FALSE/0 if weapon is not receiving the bonus. TRUE/1 if it does.</returns>
        public static int GetOneHalfStrength(uint oWeapon)
        {
            VM.NWNX.SetFunction(NWNX_Weapon, "GetOneHalfStrength");
            VM.NWNX.StackPush(oWeapon);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// @}
    }

    public struct DevastatingCriticalEvent_Data
    {
        public uint oWeapon;
        public uint oTarget;
        public int nDamage;
    }
}