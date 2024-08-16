using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Damage)]
  public class DamagePlugin
  {
    public const string NWNX_Damage = "NWNX_Damage";

    ///&lt; @private
    /// @struct NWNX_Damage_DamageEventData
    /// Damage Event Data
    /// @struct NWNX_Damage_AttackEventData
    /// Attack Event Data
    /// @struct NWNX_Damage_DamageData
    /// Used for DealDamage
    /// Sets the script to run with a damage event.
    /// <param name="sScript">The script that will handle the damage event.</param>
    /// <param name="oOwner">An object if only executing for a specific object or OBJECT_INVALID for global.</param>
    public static void SetDamageEventScript(string sScript, uint oOwner = OBJECT_INVALID)
    {
      const string sFunc = "SetEventScript";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(oOwner);
      VM.NWNX.StackPush(sScript);
      VM.NWNX.StackPush("DAMAGE");
      VM.NWNX.Call();
    }

    /// Get Damage Event Data
    /// <returns>A NWNX_Damage_DamageEventData struct.</returns>
    /// @note To use only in the Damage Event Script.
    public static DamageEventData GetDamageEventData()
    {
      const string sFunc = "GetDamageEventData";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      DamageEventData data = default;
      VM.NWNX.Call();
      data.oDamager = VM.NWNX.StackPopObject();
      data.iBludgeoning = VM.NWNX.StackPopInt();
      data.iPierce = VM.NWNX.StackPopInt();
      data.iSlash = VM.NWNX.StackPopInt();
      data.iMagical = VM.NWNX.StackPopInt();
      data.iAcid = VM.NWNX.StackPopInt();
      data.iCold = VM.NWNX.StackPopInt();
      data.iDivine = VM.NWNX.StackPopInt();
      data.iElectrical = VM.NWNX.StackPopInt();
      data.iFire = VM.NWNX.StackPopInt();
      data.iNegative = VM.NWNX.StackPopInt();
      data.iPositive = VM.NWNX.StackPopInt();
      data.iSonic = VM.NWNX.StackPopInt();
      data.iBase = VM.NWNX.StackPopInt();
      data.iCustom1 = VM.NWNX.StackPopInt();
      data.iCustom2 = VM.NWNX.StackPopInt();
      data.iCustom3 = VM.NWNX.StackPopInt();
      data.iCustom4 = VM.NWNX.StackPopInt();
      data.iCustom5 = VM.NWNX.StackPopInt();
      data.iCustom6 = VM.NWNX.StackPopInt();
      data.iCustom7 = VM.NWNX.StackPopInt();
      data.iCustom8 = VM.NWNX.StackPopInt();
      data.iCustom9 = VM.NWNX.StackPopInt();
      data.iCustom10 = VM.NWNX.StackPopInt();
      data.iCustom11 = VM.NWNX.StackPopInt();
      data.iCustom12 = VM.NWNX.StackPopInt();
      data.iCustom13 = VM.NWNX.StackPopInt();
      data.iCustom14 = VM.NWNX.StackPopInt();
      data.iCustom15 = VM.NWNX.StackPopInt();
      data.iCustom16 = VM.NWNX.StackPopInt();
      data.iCustom17 = VM.NWNX.StackPopInt();
      data.iCustom18 = VM.NWNX.StackPopInt();
      data.iCustom19 = VM.NWNX.StackPopInt();
      data.iSpellId = VM.NWNX.StackPopInt();
      return data;
    }

    /// Set Damage Event Data
    /// <param name="data">A NWNX_Damage_DamageEventData struct.</param>
    /// @note To use only in the Damage Event Script.
    public static void SetDamageEventData(DamageEventData data)
    {
      const string sFunc = "SetDamageEventData";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(data.iCustom19);
      VM.NWNX.StackPush(data.iCustom18);
      VM.NWNX.StackPush(data.iCustom17);
      VM.NWNX.StackPush(data.iCustom16);
      VM.NWNX.StackPush(data.iCustom15);
      VM.NWNX.StackPush(data.iCustom14);
      VM.NWNX.StackPush(data.iCustom13);
      VM.NWNX.StackPush(data.iCustom12);
      VM.NWNX.StackPush(data.iCustom11);
      VM.NWNX.StackPush(data.iCustom10);
      VM.NWNX.StackPush(data.iCustom9);
      VM.NWNX.StackPush(data.iCustom8);
      VM.NWNX.StackPush(data.iCustom7);
      VM.NWNX.StackPush(data.iCustom6);
      VM.NWNX.StackPush(data.iCustom5);
      VM.NWNX.StackPush(data.iCustom4);
      VM.NWNX.StackPush(data.iCustom3);
      VM.NWNX.StackPush(data.iCustom2);
      VM.NWNX.StackPush(data.iCustom1);
      VM.NWNX.StackPush(data.iBase);
      VM.NWNX.StackPush(data.iSonic);
      VM.NWNX.StackPush(data.iPositive);
      VM.NWNX.StackPush(data.iNegative);
      VM.NWNX.StackPush(data.iFire);
      VM.NWNX.StackPush(data.iElectrical);
      VM.NWNX.StackPush(data.iDivine);
      VM.NWNX.StackPush(data.iCold);
      VM.NWNX.StackPush(data.iAcid);
      VM.NWNX.StackPush(data.iMagical);
      VM.NWNX.StackPush(data.iSlash);
      VM.NWNX.StackPush(data.iPierce);
      VM.NWNX.StackPush(data.iBludgeoning);
      VM.NWNX.Call();
    }

    /// Sets the script to run with an attack event.
    /// <param name="sScript">The script that will handle the attack event.</param>
    /// <param name="oOwner">An object if only executing for a specific object or OBJECT_INVALID for global.</param>
    public static void SetAttackEventScript(string sScript, uint oOwner = OBJECT_INVALID)
    {
      const string sFunc = "SetEventScript";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(oOwner);
      VM.NWNX.StackPush(sScript);
      VM.NWNX.StackPush("ATTACK");
      VM.NWNX.Call();
    }

    /// Get Attack Event Data
    /// <returns>A NWNX_Damage_AttackEventData struct.</returns>
    /// @note To use only in the Attack Event Script.
    public static AttackEventData GetAttackEventData()
    {
      const string sFunc = "GetAttackEventData";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      AttackEventData data = default;
      VM.NWNX.Call();
      data.oTarget = VM.NWNX.StackPopObject();
      data.iBludgeoning = VM.NWNX.StackPopInt();
      data.iPierce = VM.NWNX.StackPopInt();
      data.iSlash = VM.NWNX.StackPopInt();
      data.iMagical = VM.NWNX.StackPopInt();
      data.iAcid = VM.NWNX.StackPopInt();
      data.iCold = VM.NWNX.StackPopInt();
      data.iDivine = VM.NWNX.StackPopInt();
      data.iElectrical = VM.NWNX.StackPopInt();
      data.iFire = VM.NWNX.StackPopInt();
      data.iNegative = VM.NWNX.StackPopInt();
      data.iPositive = VM.NWNX.StackPopInt();
      data.iSonic = VM.NWNX.StackPopInt();
      data.iBase = VM.NWNX.StackPopInt();
      data.iCustom1 = VM.NWNX.StackPopInt();
      data.iCustom2 = VM.NWNX.StackPopInt();
      data.iCustom3 = VM.NWNX.StackPopInt();
      data.iCustom4 = VM.NWNX.StackPopInt();
      data.iCustom5 = VM.NWNX.StackPopInt();
      data.iCustom6 = VM.NWNX.StackPopInt();
      data.iCustom7 = VM.NWNX.StackPopInt();
      data.iCustom8 = VM.NWNX.StackPopInt();
      data.iCustom9 = VM.NWNX.StackPopInt();
      data.iCustom10 = VM.NWNX.StackPopInt();
      data.iCustom11 = VM.NWNX.StackPopInt();
      data.iCustom12 = VM.NWNX.StackPopInt();
      data.iCustom13 = VM.NWNX.StackPopInt();
      data.iCustom14 = VM.NWNX.StackPopInt();
      data.iCustom15 = VM.NWNX.StackPopInt();
      data.iCustom16 = VM.NWNX.StackPopInt();
      data.iCustom17 = VM.NWNX.StackPopInt();
      data.iCustom18 = VM.NWNX.StackPopInt();
      data.iCustom19 = VM.NWNX.StackPopInt();
      data.iAttackNumber = VM.NWNX.StackPopInt();
      data.iAttackResult = VM.NWNX.StackPopInt();
      data.iWeaponAttackType = VM.NWNX.StackPopInt();
      data.iSneakAttack = VM.NWNX.StackPopInt();
      data.bKillingBlow = VM.NWNX.StackPopInt();
      data.iAttackType = VM.NWNX.StackPopInt();
      data.iToHitRoll = VM.NWNX.StackPopInt();
      data.iToHitModifier = VM.NWNX.StackPopInt();
      return data;
    }

    /// Set Attack Event Data
    /// <param name="data">A NWNX_Damage_AttackEventData struct.</param>
    /// @note To use only in the Attack Event Script.
    /// @note Setting iSneakAttack will only change the attack roll message and floating text feedback. Immunities and damage will have already been resolved by the time the attack event script is ran.
    public static void SetAttackEventData(AttackEventData data)
    {
      const string sFunc = "SetAttackEventData";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(data.iSneakAttack);
      VM.NWNX.StackPush(data.iAttackResult);
      VM.NWNX.StackPush(data.iCustom19);
      VM.NWNX.StackPush(data.iCustom18);
      VM.NWNX.StackPush(data.iCustom17);
      VM.NWNX.StackPush(data.iCustom16);
      VM.NWNX.StackPush(data.iCustom15);
      VM.NWNX.StackPush(data.iCustom14);
      VM.NWNX.StackPush(data.iCustom13);
      VM.NWNX.StackPush(data.iCustom12);
      VM.NWNX.StackPush(data.iCustom11);
      VM.NWNX.StackPush(data.iCustom10);
      VM.NWNX.StackPush(data.iCustom9);
      VM.NWNX.StackPush(data.iCustom8);
      VM.NWNX.StackPush(data.iCustom7);
      VM.NWNX.StackPush(data.iCustom6);
      VM.NWNX.StackPush(data.iCustom5);
      VM.NWNX.StackPush(data.iCustom4);
      VM.NWNX.StackPush(data.iCustom3);
      VM.NWNX.StackPush(data.iCustom2);
      VM.NWNX.StackPush(data.iCustom1);
      VM.NWNX.StackPush(data.iBase);
      VM.NWNX.StackPush(data.iSonic);
      VM.NWNX.StackPush(data.iPositive);
      VM.NWNX.StackPush(data.iNegative);
      VM.NWNX.StackPush(data.iFire);
      VM.NWNX.StackPush(data.iElectrical);
      VM.NWNX.StackPush(data.iDivine);
      VM.NWNX.StackPush(data.iCold);
      VM.NWNX.StackPush(data.iAcid);
      VM.NWNX.StackPush(data.iMagical);
      VM.NWNX.StackPush(data.iSlash);
      VM.NWNX.StackPush(data.iPierce);
      VM.NWNX.StackPush(data.iBludgeoning);
      VM.NWNX.Call();
    }

    /// Deal damage to a target.
    /// @remark Permits multiple damage types and checks enhancement bonus for overcoming DR.
    /// <param name="data">A NWNX_Damage_DamageData struct.</param>
    /// <param name="oTarget">The target object on whom the damage is dealt.</param>
    /// <param name="oSource">The source of the damage.</param>
    /// <param name="iRanged">Whether the attack should be treated as ranged by the engine (for example when considering damage inflicted by Acid Sheath and other such effects)</param>
    public static void DealDamage(DamageData data, uint oTarget, uint oSource, int iRanged = FALSE)
    {
      const string sFunc = "DealDamage";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(iRanged);
      VM.NWNX.StackPush(data.iPower);
      VM.NWNX.StackPush(data.iCustom19);
      VM.NWNX.StackPush(data.iCustom18);
      VM.NWNX.StackPush(data.iCustom17);
      VM.NWNX.StackPush(data.iCustom16);
      VM.NWNX.StackPush(data.iCustom15);
      VM.NWNX.StackPush(data.iCustom14);
      VM.NWNX.StackPush(data.iCustom13);
      VM.NWNX.StackPush(data.iCustom12);
      VM.NWNX.StackPush(data.iCustom11);
      VM.NWNX.StackPush(data.iCustom10);
      VM.NWNX.StackPush(data.iCustom9);
      VM.NWNX.StackPush(data.iCustom8);
      VM.NWNX.StackPush(data.iCustom7);
      VM.NWNX.StackPush(data.iCustom6);
      VM.NWNX.StackPush(data.iCustom5);
      VM.NWNX.StackPush(data.iCustom4);
      VM.NWNX.StackPush(data.iCustom3);
      VM.NWNX.StackPush(data.iCustom2);
      VM.NWNX.StackPush(data.iCustom1);
      VM.NWNX.StackPush(0);
      VM.NWNX.StackPush(data.iSonic);
      VM.NWNX.StackPush(data.iPositive);
      VM.NWNX.StackPush(data.iNegative);
      VM.NWNX.StackPush(data.iFire);
      VM.NWNX.StackPush(data.iElectrical);
      VM.NWNX.StackPush(data.iDivine);
      VM.NWNX.StackPush(data.iCold);
      VM.NWNX.StackPush(data.iAcid);
      VM.NWNX.StackPush(data.iMagical);
      VM.NWNX.StackPush(data.iSlash);
      VM.NWNX.StackPush(data.iPierce);
      VM.NWNX.StackPush(data.iBludgeoning);
      VM.NWNX.StackPush(oTarget);
      VM.NWNX.StackPush(oSource);
      VM.NWNX.Call();
    }

    // @}
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
    public int iCustom1;
    public int iCustom2;
    public int iCustom3;
    public int iCustom4;
    public int iCustom5;
    public int iCustom6;
    public int iCustom7;
    public int iCustom8;
    public int iCustom9;
    public int iCustom10;
    public int iCustom11;
    public int iCustom12;
    public int iCustom13;
    public int iCustom14;
    public int iCustom15;
    public int iCustom16;
    public int iCustom17;
    public int iCustom18;
    public int iCustom19;
    public int iSpellId;
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
    public int iCustom1;
    public int iCustom2;
    public int iCustom3;
    public int iCustom4;
    public int iCustom5;
    public int iCustom6;
    public int iCustom7;
    public int iCustom8;
    public int iCustom9;
    public int iCustom10;
    public int iCustom11;
    public int iCustom12;
    public int iCustom13;
    public int iCustom14;
    public int iCustom15;
    public int iCustom16;
    public int iCustom17;
    public int iCustom18;
    public int iCustom19;
    public int iAttackNumber;
    public int iAttackResult;
    public int iWeaponAttackType;
    public int iSneakAttack;
    public int iAttackType;
    public int bKillingBlow;
    public int iToHitRoll;
    public int iToHitModifier;
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
    public int iCustom1;
    public int iCustom2;
    public int iCustom3;
    public int iCustom4;
    public int iCustom5;
    public int iCustom6;
    public int iCustom7;
    public int iCustom8;
    public int iCustom9;
    public int iCustom10;
    public int iCustom11;
    public int iCustom12;
    public int iCustom13;
    public int iCustom14;
    public int iCustom15;
    public int iCustom16;
    public int iCustom17;
    public int iCustom18;
    public int iCustom19;
    public int iPower;
  }
}
