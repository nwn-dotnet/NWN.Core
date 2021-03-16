using static NWN.Core.NWScript;

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
    public static void SetDamageEventScript(string sScript, uint oOwner = OBJECT_INVALID)
    {
      const string sFunc = "SetEventScript";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(oOwner);
      VM.NWNX.StackPush(sScript);
      VM.NWNX.StackPush( "DAMAGE");
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
      return data;
    }

    /// Set Damage Event Data
    /// <param name="data">A NWNX_Damage_DamageEventData struct.</param>
    /// @note To use only in the Damage Event Script.
    public static void SetDamageEventData(DamageEventData data)
    {
      const string sFunc = "SetDamageEventData";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
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
      VM.NWNX.StackPush( "ATTACK");
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
      data.iAttackNumber = VM.NWNX.StackPopInt();
      data.iAttackResult = VM.NWNX.StackPopInt();
      data.iWeaponAttackType = VM.NWNX.StackPopInt();
      data.iSneakAttack = VM.NWNX.StackPopInt();
      data.bKillingBlow = VM.NWNX.StackPopInt();
      data.iAttackType = VM.NWNX.StackPopInt();
      return data;
    }

    /// Set Attack Event Data
    /// <param name="data">A NWNX_Damage_AttackEventData struct.</param>
    /// @note To use only in the Attack Event Script.
    public static void SetAttackEventData(AttackEventData data)
    {
      const string sFunc = "SetAttackEventData";
      VM.NWNX.SetFunction(NWNX_Damage, sFunc);
      VM.NWNX.StackPush(data.iAttackResult);
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
    public int iWeaponAttackType;
    public int iSneakAttack;
    public int iAttackType;
    public int bKillingBlow;
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
