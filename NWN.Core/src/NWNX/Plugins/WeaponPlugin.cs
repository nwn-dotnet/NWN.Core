using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Weapon)]
  public class WeaponPlugin
  {
    /// @addtogroup weapon Weapon
    /// Functions exposing additional weapon properties.
    /// @{
    /// @file nwnx_weapon.nss
    public const string NWNX_Weapon = "NWNX_Weapon";

    ///&lt; @private
    /// @name Weapons Options
    /// @anchor wpn_opts
    ///
    /// Options constants to be used with NWNX_Weapon_SetOption function.
    /// @{
    public const int NWNX_WEAPON_OPT_GRTFOCUS_AB_BONUS = 0;

    ///&lt; Greater Focus Attack Bonus
    public const int NWNX_WEAPON_OPT_GRTSPEC_DAM_BONUS = 1;

    ///&lt; Greater Specialization Damage Bonus
    ///@}
    // Get Event Data Constants
    public const int NWNX_WEAPON_GETDATA_DC = 0;

    ///&lt; Get Devastating Critical Data
    // Set Event Data Constants
    public const int NWNX_WEAPON_SETDATA_DC_BYPASS = 0;

    ///&lt; Set Devastating Critical Bypass
    /// Devastating critical event data
    /// Set nFeat as weapon focus feat for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponFocusFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponFocusFeat");
    }

    /// Set required creature size for a weapon base item to be finessable.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nSize">The creature size minimum to consider this weapon finessable.</param>
    public static void SetWeaponFinesseSize(int nBaseItem, int nSize)
    {
      NWNXPushInt(nSize);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponFinesseSize");
    }

    /// Get required creature size for a weapon base item to be finessable.
    /// <param name="nBaseItem">The base item id.</param>
    public static int GetWeaponFinesseSize(int nBaseItem)
    {
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "GetWeaponFinesseSize");
      return NWNXPopInt();
    }

    /// Set weapon base item to be considered as unarmed for weapon finesse feat.
    /// <param name="nBaseItem">The base item id.</param>
    public static void SetWeaponUnarmed(int nBaseItem)
    {
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponUnarmed");
    }

    /// Set a feat as weapon improved critical for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponImprovedCriticalFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponImprovedCriticalFeat");
    }

    /// Set a feat as weapon specialization for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponSpecializationFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponSpecializationFeat");
    }

    /// Set a feat as epic weapon focus for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponFocusFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetEpicWeaponFocusFeat");
    }

    /// Set a feat as epic weapon specialization for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponSpecializationFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetEpicWeaponSpecializationFeat");
    }

    /// Set a feat as epic weapon overwhelming critical for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponOverwhelmingCriticalFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetEpicWeaponOverwhelmingCriticalFeat");
    }

    /// Set a feat as epic weapon devastating critical for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponDevastatingCriticalFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetEpicWeaponDevastatingCriticalFeat");
    }

    /// Set a feat as weapon of choice for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponOfChoiceFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponOfChoiceFeat");
    }

    /// Set a feat as greater weapon specialization for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetGreaterWeaponSpecializationFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetGreaterWeaponSpecializationFeat");
    }

    /// Set a feat as greater weapon focus for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetGreaterWeaponFocusFeat(int nBaseItem, int nFeat)
    {
      NWNXPushInt(nFeat);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetGreaterWeaponFocusFeat");
    }

    /// Set base item as monk weapon.
    /// <param name="nBaseItem">The base item id.</param>
    /// @deprecated Use baseitems.2da. This will be removed in future NWNX releases.
    public static void SetWeaponIsMonkWeapon(int nBaseItem)
    {
      WriteTimestampedLogEntry("NWNX_Weapon_SetWeaponIsMonkWeapon() is deprecated. Please use baseitems.2da instead.");
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetWeaponIsMonkWeapon");
    }

    /// Set plugin options.
    /// <param name="nOption">The option to change from @ref wpn_opts &quot;Weapon Options&quot;.</param>
    /// <param name="nVal">The new value of the option.</param>
    public static void SetOption(int nOption, int nVal)
    {
      NWNXPushInt(nVal);
      NWNXPushInt(nOption);
      NWNXCall(NWNX_Weapon, "SetOption");
    }

    /// Set Devastating Critical Event Script.
    /// <param name="sScript">The script to call when a Devastating Critical occurs.</param>
    public static void SetDevastatingCriticalEventScript(string sScript)
    {
      NWNXPushString(sScript);
      NWNXCall(NWNX_Weapon, "SetDevastatingCriticalEventScript");
    }

    /// Get Devastating Critical Event Data.
    /// @note This is only for use with the Devastating Critical Event Script.
    /// <returns>An NWNX_Weapon_DevastatingCriticalEvent_Data struct.</returns>
    public static DevastatingCriticalEvent_Data GetDevastatingCriticalEventData()
    {
      DevastatingCriticalEvent_Data data = default;
      NWNXPushInt(NWNX_WEAPON_GETDATA_DC);
      NWNXCall(NWNX_Weapon, "GetEventData");
      data.oWeapon = NWNXPopObject();
      data.oTarget = NWNXPopObject();
      data.nDamage = NWNXPopInt();
      return data;
    }

    /// Bypass Devastating Critical.
    /// @note This is only for use with the Devastating Critical Event Script.
    public static void BypassDevastatingCritical()
    {
      NWNXPushInt(1);
      NWNXPushInt(NWNX_WEAPON_SETDATA_DC_BYPASS);
      NWNXCall(NWNX_Weapon, "SetEventData");
    }

    /// Sets weapon to gain .5 strength bonus.
    /// <param name="oWeapon">Should be a melee weapon.</param>
    /// <param name="nEnable">TRUE for bonus. FALSE to turn off bonus.</param>
    /// <param name="bPersist">whether the two hand state should persist to the gff file.</param>
    public static void SetOneHalfStrength(uint oWeapon, int nEnable, int bPersist = FALSE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nEnable);
      NWNXPushObject(oWeapon);
      NWNXCall(NWNX_Weapon, "SetOneHalfStrength");
    }

    /// Gets if the weapon is set to gain addition .5 strength bonus
    /// <param name="oWeapon">the weapon</param>
    /// <returns>FALSE/0 if weapon is not receiving the bonus. TRUE/1 if it does.</returns>
    public static int GetOneHalfStrength(uint oWeapon)
    {
      NWNXPushObject(oWeapon);
      NWNXCall(NWNX_Weapon, "GetOneHalfStrength");
      return NWNXPopInt();
    }

    /// Override the max attack distance of ranged weapons.
    /// <param name="nBaseItem">The baseitem id.</param>
    /// <param name="fMax">The maximum attack distance. Default is 40.0f.</param>
    /// <param name="fMaxPassive">The maximum passive attack distance. Default is 20.0f. Seems to be used by the engine to determine a new nearby target when needed.</param>
    /// <param name="fPreferred">The preferred attack distance. See the PrefAttackDist column in baseitems.2da, default seems to be 30.0f for ranged weapons.</param>
    /// @note fMaxPassive should probably be lower than fMax, half of fMax seems to be a good start. fPreferred should be at least ~0.5f lower than fMax.
    public static void SetMaxRangedAttackDistanceOverride(int nBaseItem, float fMax, float fMaxPassive, float fPreferred)
    {
      NWNXPushFloat(fPreferred);
      NWNXPushFloat(fMaxPassive);
      NWNXPushFloat(fMax);
      NWNXPushInt(nBaseItem);
      NWNXCall(NWNX_Weapon, "SetMaxRangedAttackDistanceOverride");
    }

    // @}
  }

  public struct DevastatingCriticalEvent_Data
  {
    public uint oWeapon;
    public uint oTarget;
    public int nDamage;
  }
}
