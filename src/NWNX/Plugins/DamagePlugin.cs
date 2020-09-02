namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Damage)]
    public class DamagePlugin
    {
        public const string NWNX_Damage = "NWNX_Damage";

        ///< @private
        /// @struct NWNX_Damage_DamageEventData
        /// Damage Event Data
        /// @struct NWNX_Damage_AttackEventData
        /// Attack Event Data
        /// @struct NWNX_Damage_DamageData
        /// Used for DealDamage
        /// Sets the script to run with a damage event.
        /// <param name="sScript">The script that will handle the damage event.</param>
        /// <param name="oOwner">An object if only executing for a specific object or OBJECT_INVALID for global.</param>
        public static void SetDamageEventScript(string sScript, uint oOwner = NWScript.OBJECT_INVALID)
        {
            VM.NWNX.SetFunction(NWNX_Damage, "SetDamageEventScript");
            VM.NWNX.StackPush(oOwner);
            VM.NWNX.StackPush(sScript);
            VM.NWNX.Call();
        }

        /// Get Damage Event Data
        /// <returns>A NWNX_Damage_DamageEventData struct.</returns>
        /// @note To use only in the Damage Event Script.
        public static DamageEventData GetDamageEventData()
        {
            VM.NWNX.SetFunction(NWNX_Damage, "GetDamageEventData");
            VM.NWNX.Call();
            DamageEventData retVal;
            retVal.iBase = VM.NWNX.StackPopInt();
            retVal.iSonic = VM.NWNX.StackPopInt();
            retVal.iPositive = VM.NWNX.StackPopInt();
            retVal.iNegative = VM.NWNX.StackPopInt();
            retVal.iFire = VM.NWNX.StackPopInt();
            retVal.iElectrical = VM.NWNX.StackPopInt();
            retVal.iDivine = VM.NWNX.StackPopInt();
            retVal.iCold = VM.NWNX.StackPopInt();
            retVal.iAcid = VM.NWNX.StackPopInt();
            retVal.iMagical = VM.NWNX.StackPopInt();
            retVal.iSlash = VM.NWNX.StackPopInt();
            retVal.iPierce = VM.NWNX.StackPopInt();
            retVal.iBludgeoning = VM.NWNX.StackPopInt();
            retVal.oDamager = VM.NWNX.StackPopObject();
            return retVal;
        }

        /// Set Damage Event Data
        /// <param name="data">A NWNX_Damage_DamageEventData struct.</param>
        /// @note To use only in the Damage Event Script.
        public static void SetDamageEventData(DamageEventData data)
        {
            VM.NWNX.SetFunction(NWNX_Damage, "SetDamageEventData");
            VM.NWNX.StackPush(data.oDamager);
            VM.NWNX.StackPush(data.iBludgeoning);
            VM.NWNX.StackPush(data.iPierce);
            VM.NWNX.StackPush(data.iSlash);
            VM.NWNX.StackPush(data.iMagical);
            VM.NWNX.StackPush(data.iAcid);
            VM.NWNX.StackPush(data.iCold);
            VM.NWNX.StackPush(data.iDivine);
            VM.NWNX.StackPush(data.iElectrical);
            VM.NWNX.StackPush(data.iFire);
            VM.NWNX.StackPush(data.iNegative);
            VM.NWNX.StackPush(data.iPositive);
            VM.NWNX.StackPush(data.iSonic);
            VM.NWNX.StackPush(data.iBase);
            VM.NWNX.Call();
        }

        /// Sets the script to run with an attack event.
        /// <param name="sScript">The script that will handle the attack event.</param>
        /// <param name="oOwner">An object if only executing for a specific object or OBJECT_INVALID for global.</param>
        public static void SetAttackEventScript(string sScript, uint oOwner = NWScript.OBJECT_INVALID)
        {
            VM.NWNX.SetFunction(NWNX_Damage, "SetAttackEventScript");
            VM.NWNX.StackPush(oOwner);
            VM.NWNX.StackPush(sScript);
            VM.NWNX.Call();
        }

        /// Get Attack Event Data
        /// <returns>A NWNX_Damage_AttackEventData struct.</returns>
        /// @note To use only in the Attack Event Script.
        public static AttackEventData GetAttackEventData()
        {
            VM.NWNX.SetFunction(NWNX_Damage, "GetAttackEventData");
            VM.NWNX.Call();
            AttackEventData retVal;
            retVal.iSneakAttack = VM.NWNX.StackPopInt();
            retVal.iAttackType = VM.NWNX.StackPopInt();
            retVal.iAttackResult = VM.NWNX.StackPopInt();
            retVal.iAttackNumber = VM.NWNX.StackPopInt();
            retVal.iBase = VM.NWNX.StackPopInt();
            retVal.iSonic = VM.NWNX.StackPopInt();
            retVal.iPositive = VM.NWNX.StackPopInt();
            retVal.iNegative = VM.NWNX.StackPopInt();
            retVal.iFire = VM.NWNX.StackPopInt();
            retVal.iElectrical = VM.NWNX.StackPopInt();
            retVal.iDivine = VM.NWNX.StackPopInt();
            retVal.iCold = VM.NWNX.StackPopInt();
            retVal.iAcid = VM.NWNX.StackPopInt();
            retVal.iMagical = VM.NWNX.StackPopInt();
            retVal.iSlash = VM.NWNX.StackPopInt();
            retVal.iPierce = VM.NWNX.StackPopInt();
            retVal.iBludgeoning = VM.NWNX.StackPopInt();
            retVal.oTarget = VM.NWNX.StackPopObject();
            return retVal;
        }

        /// Set Attack Event Data
        /// <param name="data">A NWNX_Damage_AttackEventData struct.</param>
        /// @note To use only in the Attack Event Script.
        public static void SetAttackEventData(AttackEventData data)
        {
            VM.NWNX.SetFunction(NWNX_Damage, "SetAttackEventData");
            VM.NWNX.StackPush(data.oTarget);
            VM.NWNX.StackPush(data.iBludgeoning);
            VM.NWNX.StackPush(data.iPierce);
            VM.NWNX.StackPush(data.iSlash);
            VM.NWNX.StackPush(data.iMagical);
            VM.NWNX.StackPush(data.iAcid);
            VM.NWNX.StackPush(data.iCold);
            VM.NWNX.StackPush(data.iDivine);
            VM.NWNX.StackPush(data.iElectrical);
            VM.NWNX.StackPush(data.iFire);
            VM.NWNX.StackPush(data.iNegative);
            VM.NWNX.StackPush(data.iPositive);
            VM.NWNX.StackPush(data.iSonic);
            VM.NWNX.StackPush(data.iBase);
            VM.NWNX.StackPush(data.iAttackNumber);
            VM.NWNX.StackPush(data.iAttackResult);
            VM.NWNX.StackPush(data.iAttackType);
            VM.NWNX.StackPush(data.iSneakAttack);
            VM.NWNX.Call();
        }

        /// Deal damage to a target.
        /// @remark Permits multiple damage types and checks enhancement bonus for overcoming DR.
        /// <param name="data">A NWNX_Damage_DamageData struct.</param>
        /// <param name="oTarget">The target object on whom the damage is dealt.</param>
        /// <param name="oSource">The source of the damage.</param>
        /// <param name="iRanged">Whether the attack should be treated as ranged by the engine (for example when considering damage inflicted by Acid Sheath and other such effects)</param>
        public static void DealDamage(DamageData data, uint oTarget, uint oSource = NWScript.OBJECT_INVALID, int iRanged = NWScript.FALSE)
        {
            VM.NWNX.SetFunction(NWNX_Damage, "DealDamage");
            VM.NWNX.StackPush(iRanged);
            VM.NWNX.StackPush(oSource);
            VM.NWNX.StackPush(oTarget);
            VM.NWNX.StackPush(data.iBludgeoning);
            VM.NWNX.StackPush(data.iPierce);
            VM.NWNX.StackPush(data.iSlash);
            VM.NWNX.StackPush(data.iMagical);
            VM.NWNX.StackPush(data.iAcid);
            VM.NWNX.StackPush(data.iCold);
            VM.NWNX.StackPush(data.iDivine);
            VM.NWNX.StackPush(data.iElectrical);
            VM.NWNX.StackPush(data.iFire);
            VM.NWNX.StackPush(data.iNegative);
            VM.NWNX.StackPush(data.iPositive);
            VM.NWNX.StackPush(data.iSonic);
            VM.NWNX.StackPush(data.iPower);
            VM.NWNX.Call();
        }

        /// @}
    }

    public struct DamageEventData
    {
        public uint oDamager;
        public int iBludgeoning;
        public int iPierce;
        public int iSlash;
        public int iMagical;
        public int iAcid;
        public int iCold;
        public int iDivine;
        public int iElectrical;
        public int iFire;
        public int iNegative;
        public int iPositive;
        public int iSonic;
        public int iBase;
    }

    public struct AttackEventData
    {
        public uint oTarget;
        public int iBludgeoning;
        public int iPierce;
        public int iSlash;
        public int iMagical;
        public int iAcid;
        public int iCold;
        public int iDivine;
        public int iElectrical;
        public int iFire;
        public int iNegative;
        public int iPositive;
        public int iSonic;
        public int iBase;
        public int iAttackNumber;
        public int iAttackResult;
        public int iAttackType;
        public int iSneakAttack;
    }

    public struct DamageData
    {
        public int iBludgeoning;
        public int iPierce;
        public int iSlash;
        public int iMagical;
        public int iAcid;
        public int iCold;
        public int iDivine;
        public int iElectrical;
        public int iFire;
        public int iNegative;
        public int iPositive;
        public int iSonic;
        public int iPower;
    }
}