using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Damage)]
  public class DamagePlugin
  {
    /// @addtogroup damage Damage
    /// Run a script before damage and attack events allowing for modification. Includes function to arbitrarily apply damage.
    /// @{
    /// @file nwnx_damage.nss
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
      NWNXPushObject(oOwner);
      NWNXPushString(sScript);
      NWNXPushString("DAMAGE");
      NWNXCall(NWNX_Damage, "SetEventScript");
    }

    /// Get Damage Event Data
    /// <returns>A NWNX_Damage_DamageEventData struct.</returns>
    /// @note To use only in the Damage Event Script.
    public static DamageEventData GetDamageEventData()
    {
      DamageEventData data = default;
      NWNXCall(NWNX_Damage, "GetDamageEventData");
      data.oDamager = NWNXPopObject();
      data.iBludgeoning = NWNXPopInt();
      data.iPierce = NWNXPopInt();
      data.iSlash = NWNXPopInt();
      data.iMagical = NWNXPopInt();
      data.iAcid = NWNXPopInt();
      data.iCold = NWNXPopInt();
      data.iDivine = NWNXPopInt();
      data.iElectrical = NWNXPopInt();
      data.iFire = NWNXPopInt();
      data.iNegative = NWNXPopInt();
      data.iPositive = NWNXPopInt();
      data.iSonic = NWNXPopInt();
      data.iBase = NWNXPopInt();
      data.iCustom1 = NWNXPopInt();
      data.iCustom2 = NWNXPopInt();
      data.iCustom3 = NWNXPopInt();
      data.iCustom4 = NWNXPopInt();
      data.iCustom5 = NWNXPopInt();
      data.iCustom6 = NWNXPopInt();
      data.iCustom7 = NWNXPopInt();
      data.iCustom8 = NWNXPopInt();
      data.iCustom9 = NWNXPopInt();
      data.iCustom10 = NWNXPopInt();
      data.iCustom11 = NWNXPopInt();
      data.iCustom12 = NWNXPopInt();
      data.iCustom13 = NWNXPopInt();
      data.iCustom14 = NWNXPopInt();
      data.iCustom15 = NWNXPopInt();
      data.iCustom16 = NWNXPopInt();
      data.iCustom17 = NWNXPopInt();
      data.iCustom18 = NWNXPopInt();
      data.iCustom19 = NWNXPopInt();
      data.iSpellId = NWNXPopInt();
      return data;
    }

    /// Set Damage Event Data
    /// <param name="data">A NWNX_Damage_DamageEventData struct.</param>
    /// @note To use only in the Damage Event Script.
    public static void SetDamageEventData(DamageEventData data)
    {
      NWNXPushInt(data.iCustom19);
      NWNXPushInt(data.iCustom18);
      NWNXPushInt(data.iCustom17);
      NWNXPushInt(data.iCustom16);
      NWNXPushInt(data.iCustom15);
      NWNXPushInt(data.iCustom14);
      NWNXPushInt(data.iCustom13);
      NWNXPushInt(data.iCustom12);
      NWNXPushInt(data.iCustom11);
      NWNXPushInt(data.iCustom10);
      NWNXPushInt(data.iCustom9);
      NWNXPushInt(data.iCustom8);
      NWNXPushInt(data.iCustom7);
      NWNXPushInt(data.iCustom6);
      NWNXPushInt(data.iCustom5);
      NWNXPushInt(data.iCustom4);
      NWNXPushInt(data.iCustom3);
      NWNXPushInt(data.iCustom2);
      NWNXPushInt(data.iCustom1);
      NWNXPushInt(data.iBase);
      NWNXPushInt(data.iSonic);
      NWNXPushInt(data.iPositive);
      NWNXPushInt(data.iNegative);
      NWNXPushInt(data.iFire);
      NWNXPushInt(data.iElectrical);
      NWNXPushInt(data.iDivine);
      NWNXPushInt(data.iCold);
      NWNXPushInt(data.iAcid);
      NWNXPushInt(data.iMagical);
      NWNXPushInt(data.iSlash);
      NWNXPushInt(data.iPierce);
      NWNXPushInt(data.iBludgeoning);
      NWNXCall(NWNX_Damage, "SetDamageEventData");
    }

    /// Sets the script to run with an attack event.
    /// <param name="sScript">The script that will handle the attack event.</param>
    /// <param name="oOwner">An object if only executing for a specific object or OBJECT_INVALID for global.</param>
    public static void SetAttackEventScript(string sScript, uint oOwner = OBJECT_INVALID)
    {
      NWNXPushObject(oOwner);
      NWNXPushString(sScript);
      NWNXPushString("ATTACK");
      NWNXCall(NWNX_Damage, "SetEventScript");
    }

    /// Get Attack Event Data
    /// <returns>A NWNX_Damage_AttackEventData struct.</returns>
    /// @note To use only in the Attack Event Script.
    public static AttackEventData GetAttackEventData()
    {
      AttackEventData data = default;
      NWNXCall(NWNX_Damage, "GetAttackEventData");
      data.oTarget = NWNXPopObject();
      data.iBludgeoning = NWNXPopInt();
      data.iPierce = NWNXPopInt();
      data.iSlash = NWNXPopInt();
      data.iMagical = NWNXPopInt();
      data.iAcid = NWNXPopInt();
      data.iCold = NWNXPopInt();
      data.iDivine = NWNXPopInt();
      data.iElectrical = NWNXPopInt();
      data.iFire = NWNXPopInt();
      data.iNegative = NWNXPopInt();
      data.iPositive = NWNXPopInt();
      data.iSonic = NWNXPopInt();
      data.iBase = NWNXPopInt();
      data.iCustom1 = NWNXPopInt();
      data.iCustom2 = NWNXPopInt();
      data.iCustom3 = NWNXPopInt();
      data.iCustom4 = NWNXPopInt();
      data.iCustom5 = NWNXPopInt();
      data.iCustom6 = NWNXPopInt();
      data.iCustom7 = NWNXPopInt();
      data.iCustom8 = NWNXPopInt();
      data.iCustom9 = NWNXPopInt();
      data.iCustom10 = NWNXPopInt();
      data.iCustom11 = NWNXPopInt();
      data.iCustom12 = NWNXPopInt();
      data.iCustom13 = NWNXPopInt();
      data.iCustom14 = NWNXPopInt();
      data.iCustom15 = NWNXPopInt();
      data.iCustom16 = NWNXPopInt();
      data.iCustom17 = NWNXPopInt();
      data.iCustom18 = NWNXPopInt();
      data.iCustom19 = NWNXPopInt();
      data.iAttackNumber = NWNXPopInt();
      data.iAttackResult = NWNXPopInt();
      data.iWeaponAttackType = NWNXPopInt();
      data.iSneakAttack = NWNXPopInt();
      data.bKillingBlow = NWNXPopInt();
      data.iAttackType = NWNXPopInt();
      data.iToHitRoll = NWNXPopInt();
      data.iToHitModifier = NWNXPopInt();
      return data;
    }

    /// Set Attack Event Data
    /// <param name="data">A NWNX_Damage_AttackEventData struct.</param>
    /// @note To use only in the Attack Event Script.
    /// @note Setting iSneakAttack will only change the attack roll message and floating text feedback. Immunities and damage will have already been resolved by the time the attack event script is ran.
    public static void SetAttackEventData(AttackEventData data)
    {
      NWNXPushInt(data.iSneakAttack);
      NWNXPushInt(data.iAttackResult);
      NWNXPushInt(data.iCustom19);
      NWNXPushInt(data.iCustom18);
      NWNXPushInt(data.iCustom17);
      NWNXPushInt(data.iCustom16);
      NWNXPushInt(data.iCustom15);
      NWNXPushInt(data.iCustom14);
      NWNXPushInt(data.iCustom13);
      NWNXPushInt(data.iCustom12);
      NWNXPushInt(data.iCustom11);
      NWNXPushInt(data.iCustom10);
      NWNXPushInt(data.iCustom9);
      NWNXPushInt(data.iCustom8);
      NWNXPushInt(data.iCustom7);
      NWNXPushInt(data.iCustom6);
      NWNXPushInt(data.iCustom5);
      NWNXPushInt(data.iCustom4);
      NWNXPushInt(data.iCustom3);
      NWNXPushInt(data.iCustom2);
      NWNXPushInt(data.iCustom1);
      NWNXPushInt(data.iBase);
      NWNXPushInt(data.iSonic);
      NWNXPushInt(data.iPositive);
      NWNXPushInt(data.iNegative);
      NWNXPushInt(data.iFire);
      NWNXPushInt(data.iElectrical);
      NWNXPushInt(data.iDivine);
      NWNXPushInt(data.iCold);
      NWNXPushInt(data.iAcid);
      NWNXPushInt(data.iMagical);
      NWNXPushInt(data.iSlash);
      NWNXPushInt(data.iPierce);
      NWNXPushInt(data.iBludgeoning);
      NWNXCall(NWNX_Damage, "SetAttackEventData");
    }

    /// Deal damage to a target.
    /// @remark Permits multiple damage types and checks enhancement bonus for overcoming DR.
    /// <param name="data">A NWNX_Damage_DamageData struct.</param>
    /// <param name="oTarget">The target object on whom the damage is dealt.</param>
    /// <param name="oSource">The source of the damage.</param>
    /// <param name="iRanged">Whether the attack should be treated as ranged by the engine (for example when considering damage inflicted by Acid Sheath and other such effects)</param>
    public static void DealDamage(DamageData data, uint oTarget, uint oSource, int iRanged = FALSE)
    {
      NWNXPushInt(iRanged);
      NWNXPushInt(data.iPower);
      NWNXPushInt(data.iCustom19);
      NWNXPushInt(data.iCustom18);
      NWNXPushInt(data.iCustom17);
      NWNXPushInt(data.iCustom16);
      NWNXPushInt(data.iCustom15);
      NWNXPushInt(data.iCustom14);
      NWNXPushInt(data.iCustom13);
      NWNXPushInt(data.iCustom12);
      NWNXPushInt(data.iCustom11);
      NWNXPushInt(data.iCustom10);
      NWNXPushInt(data.iCustom9);
      NWNXPushInt(data.iCustom8);
      NWNXPushInt(data.iCustom7);
      NWNXPushInt(data.iCustom6);
      NWNXPushInt(data.iCustom5);
      NWNXPushInt(data.iCustom4);
      NWNXPushInt(data.iCustom3);
      NWNXPushInt(data.iCustom2);
      NWNXPushInt(data.iCustom1);
      NWNXPushInt(0);
      NWNXPushInt(data.iSonic);
      NWNXPushInt(data.iPositive);
      NWNXPushInt(data.iNegative);
      NWNXPushInt(data.iFire);
      NWNXPushInt(data.iElectrical);
      NWNXPushInt(data.iDivine);
      NWNXPushInt(data.iCold);
      NWNXPushInt(data.iAcid);
      NWNXPushInt(data.iMagical);
      NWNXPushInt(data.iSlash);
      NWNXPushInt(data.iPierce);
      NWNXPushInt(data.iBludgeoning);
      NWNXPushObject(oTarget);
      NWNXPushObject(oSource);
      NWNXCall(NWNX_Damage, "DealDamage");
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
