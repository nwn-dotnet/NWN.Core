namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Damage)]
    public class DamagePlugin
    {
        public const string NWNX_Damage = "NWNX_Damage";

        // /< @private
        // / @struct NWNX_Damage_DamageEventData
        // / @brief Damage Event Data
        // / @struct NWNX_Damage_AttackEventData
        // / @brief Attack Event Data
        // / @struct NWNX_Damage_DamageData
        // / @brief Used for DealDamage
        // / @brief Sets the script to run with a damage event.
        // / @param sScript The script that will handle the damage event.
        // / @param oOwner An object if only executing for a specific object or OBJECT_INVALID for global.
        public static void SetDamageEventScript(string sScript, uint oOwner = NWScript.OBJECT_INVALID)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "SetDamageEventScript");
            Internal.NativeFunctions.nwnxPushObject(oOwner);
            Internal.NativeFunctions.nwnxPushString(sScript);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get Damage Event Data
        // / @return A NWNX_Damage_DamageEventData struct.
        // / @note To use only in the Damage Event Script.
        public static DamageEventData GetDamageEventData()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "GetDamageEventData");
            Internal.NativeFunctions.nwnxCallFunction();
            DamageEventData retVal;
            retVal.iBase = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSonic = Internal.NativeFunctions.nwnxPopInt();
            retVal.iPositive = Internal.NativeFunctions.nwnxPopInt();
            retVal.iNegative = Internal.NativeFunctions.nwnxPopInt();
            retVal.iFire = Internal.NativeFunctions.nwnxPopInt();
            retVal.iElectrical = Internal.NativeFunctions.nwnxPopInt();
            retVal.iDivine = Internal.NativeFunctions.nwnxPopInt();
            retVal.iCold = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAcid = Internal.NativeFunctions.nwnxPopInt();
            retVal.iMagical = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSlash = Internal.NativeFunctions.nwnxPopInt();
            retVal.iPierce = Internal.NativeFunctions.nwnxPopInt();
            retVal.iBludgeoning = Internal.NativeFunctions.nwnxPopInt();
            retVal.oDamager = Internal.NativeFunctions.nwnxPopObject();
            return retVal;
        }

        // / @brief Set Damage Event Data
        // / @param data A NWNX_Damage_DamageEventData struct.
        // / @note To use only in the Damage Event Script.
        public static void SetDamageEventData(DamageEventData data)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "SetDamageEventData");
            Internal.NativeFunctions.nwnxPushObject(data.oDamager);
            Internal.NativeFunctions.nwnxPushInt(data.iBludgeoning);
            Internal.NativeFunctions.nwnxPushInt(data.iPierce);
            Internal.NativeFunctions.nwnxPushInt(data.iSlash);
            Internal.NativeFunctions.nwnxPushInt(data.iMagical);
            Internal.NativeFunctions.nwnxPushInt(data.iAcid);
            Internal.NativeFunctions.nwnxPushInt(data.iCold);
            Internal.NativeFunctions.nwnxPushInt(data.iDivine);
            Internal.NativeFunctions.nwnxPushInt(data.iElectrical);
            Internal.NativeFunctions.nwnxPushInt(data.iFire);
            Internal.NativeFunctions.nwnxPushInt(data.iNegative);
            Internal.NativeFunctions.nwnxPushInt(data.iPositive);
            Internal.NativeFunctions.nwnxPushInt(data.iSonic);
            Internal.NativeFunctions.nwnxPushInt(data.iBase);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Sets the script to run with an attack event.
        // / @param sScript The script that will handle the attack event.
        // / @param oOwner An object if only executing for a specific object or OBJECT_INVALID for global.
        public static void SetAttackEventScript(string sScript, uint oOwner = NWScript.OBJECT_INVALID)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "SetAttackEventScript");
            Internal.NativeFunctions.nwnxPushObject(oOwner);
            Internal.NativeFunctions.nwnxPushString(sScript);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get Attack Event Data
        // / @return A NWNX_Damage_AttackEventData struct.
        // / @note To use only in the Attack Event Script.
        public static AttackEventData GetAttackEventData()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "GetAttackEventData");
            Internal.NativeFunctions.nwnxCallFunction();
            AttackEventData retVal;
            retVal.iSneakAttack = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAttackType = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAttackResult = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAttackNumber = Internal.NativeFunctions.nwnxPopInt();
            retVal.iBase = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSonic = Internal.NativeFunctions.nwnxPopInt();
            retVal.iPositive = Internal.NativeFunctions.nwnxPopInt();
            retVal.iNegative = Internal.NativeFunctions.nwnxPopInt();
            retVal.iFire = Internal.NativeFunctions.nwnxPopInt();
            retVal.iElectrical = Internal.NativeFunctions.nwnxPopInt();
            retVal.iDivine = Internal.NativeFunctions.nwnxPopInt();
            retVal.iCold = Internal.NativeFunctions.nwnxPopInt();
            retVal.iAcid = Internal.NativeFunctions.nwnxPopInt();
            retVal.iMagical = Internal.NativeFunctions.nwnxPopInt();
            retVal.iSlash = Internal.NativeFunctions.nwnxPopInt();
            retVal.iPierce = Internal.NativeFunctions.nwnxPopInt();
            retVal.iBludgeoning = Internal.NativeFunctions.nwnxPopInt();
            retVal.oTarget = Internal.NativeFunctions.nwnxPopObject();
            return retVal;
        }

        // / @brief Set Attack Event Data
        // / @param data A NWNX_Damage_AttackEventData struct.
        // / @note To use only in the Attack Event Script.
        public static void SetAttackEventData(AttackEventData data)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "SetAttackEventData");
            Internal.NativeFunctions.nwnxPushObject(data.oTarget);
            Internal.NativeFunctions.nwnxPushInt(data.iBludgeoning);
            Internal.NativeFunctions.nwnxPushInt(data.iPierce);
            Internal.NativeFunctions.nwnxPushInt(data.iSlash);
            Internal.NativeFunctions.nwnxPushInt(data.iMagical);
            Internal.NativeFunctions.nwnxPushInt(data.iAcid);
            Internal.NativeFunctions.nwnxPushInt(data.iCold);
            Internal.NativeFunctions.nwnxPushInt(data.iDivine);
            Internal.NativeFunctions.nwnxPushInt(data.iElectrical);
            Internal.NativeFunctions.nwnxPushInt(data.iFire);
            Internal.NativeFunctions.nwnxPushInt(data.iNegative);
            Internal.NativeFunctions.nwnxPushInt(data.iPositive);
            Internal.NativeFunctions.nwnxPushInt(data.iSonic);
            Internal.NativeFunctions.nwnxPushInt(data.iBase);
            Internal.NativeFunctions.nwnxPushInt(data.iAttackNumber);
            Internal.NativeFunctions.nwnxPushInt(data.iAttackResult);
            Internal.NativeFunctions.nwnxPushInt(data.iAttackType);
            Internal.NativeFunctions.nwnxPushInt(data.iSneakAttack);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Deal damage to a target.
        // / @remark Permits multiple damage types and checks enhancement bonus for overcoming DR.
        // / @param data A NWNX_Damage_DamageData struct.
        // / @param oTarget The target object on whom the damage is dealt.
        // / @param oSource The source of the damage.
        // / @param iRanged Whether the attack should be treated as ranged by the engine (for example when considering damage inflicted by Acid Sheath and other such effects)
        public static void DealDamage(DamageData data, uint oTarget, uint oSource = NWScript.OBJECT_INVALID, int iRanged = NWScript.FALSE)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Damage, "DealDamage");
            Internal.NativeFunctions.nwnxPushInt(iRanged);
            Internal.NativeFunctions.nwnxPushObject(oSource);
            Internal.NativeFunctions.nwnxPushObject(oTarget);
            Internal.NativeFunctions.nwnxPushInt(data.iBludgeoning);
            Internal.NativeFunctions.nwnxPushInt(data.iPierce);
            Internal.NativeFunctions.nwnxPushInt(data.iSlash);
            Internal.NativeFunctions.nwnxPushInt(data.iMagical);
            Internal.NativeFunctions.nwnxPushInt(data.iAcid);
            Internal.NativeFunctions.nwnxPushInt(data.iCold);
            Internal.NativeFunctions.nwnxPushInt(data.iDivine);
            Internal.NativeFunctions.nwnxPushInt(data.iElectrical);
            Internal.NativeFunctions.nwnxPushInt(data.iFire);
            Internal.NativeFunctions.nwnxPushInt(data.iNegative);
            Internal.NativeFunctions.nwnxPushInt(data.iPositive);
            Internal.NativeFunctions.nwnxPushInt(data.iSonic);
            Internal.NativeFunctions.nwnxPushInt(data.iPower);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
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
