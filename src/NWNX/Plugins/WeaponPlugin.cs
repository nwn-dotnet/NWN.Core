using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Weapon)]
  public class WeaponPlugin
  {
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
      const string sFunc = "SetWeaponFocusFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set required creature size for a weapon base item to be finessable.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nSize">The creature size minimum to consider this weapon finessable.</param>
    public static void SetWeaponFinesseSize(int nBaseItem, int nSize)
    {
      const string sFunc = "SetWeaponFinesseSize";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nSize);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Get required creature size for a weapon base item to be finessable.
    /// <param name="nBaseItem">The base item id.</param>
    public static int GetWeaponFinesseSize(int nBaseItem)
    {
      const string sFunc = "GetWeaponFinesseSize";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set weapon base item to be considered as unarmed for weapon finesse feat.
    /// <param name="nBaseItem">The base item id.</param>
    public static void SetWeaponUnarmed(int nBaseItem)
    {
      const string sFunc = "SetWeaponUnarmed";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as weapon improved critical for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponImprovedCriticalFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetWeaponImprovedCriticalFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as weapon specialization for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponSpecializationFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetWeaponSpecializationFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as epic weapon focus for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponFocusFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetEpicWeaponFocusFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as epic weapon specialization for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponSpecializationFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetEpicWeaponSpecializationFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as epic weapon overwhelming critical for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponOverwhelmingCriticalFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetEpicWeaponOverwhelmingCriticalFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as epic weapon devastating critical for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetEpicWeaponDevastatingCriticalFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetEpicWeaponDevastatingCriticalFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as weapon of choice for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetWeaponOfChoiceFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetWeaponOfChoiceFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as greater weapon specialization for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetGreaterWeaponSpecializationFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetGreaterWeaponSpecializationFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set a feat as greater weapon focus for a base item.
    /// <param name="nBaseItem">The base item id.</param>
    /// <param name="nFeat">The feat to set.</param>
    public static void SetGreaterWeaponFocusFeat(int nBaseItem, int nFeat)
    {
      const string sFunc = "SetGreaterWeaponFocusFeat";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nFeat);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set base item as monk weapon.
    /// <param name="nBaseItem">The base item id.</param>
    /// @deprecated Use baseitems.2da. This will be removed in future NWNX releases.
    public static void SetWeaponIsMonkWeapon(int nBaseItem)
    {
      WriteTimestampedLogEntry("NWNX_Weapon_SetWeaponIsMonkWeapon() is deprecated. Please use baseitems.2da instead.");
      const string sFunc = "SetWeaponIsMonkWeapon";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
    }

    /// Set plugin options.
    /// <param name="nOption">The option to change from @ref wpn_opts &quot;Weapon Options&quot;.</param>
    /// <param name="nVal">The new value of the option.</param>
    public static void SetOption(int nOption, int nVal)
    {
      const string sFunc = "SetOption";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(nVal);
      VM.NWNX.StackPush(nOption);
      VM.NWNX.Call();
    }

    /// Set Devastating Critical Event Script.
    /// <param name="sScript">The script to call when a Devastating Critical occurs.</param>
    public static void SetDevastatingCriticalEventScript(string sScript)
    {
      const string sFunc = "SetDevastatingCriticalEventScript";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(sScript);
      VM.NWNX.Call();
    }

    /// Get Devastating Critical Event Data.
    /// @note This is only for use with the Devastating Critical Event Script.
    /// <returns>An NWNX_Weapon_DevastatingCriticalEvent_Data struct.</returns>
    public static DevastatingCriticalEvent_Data GetDevastatingCriticalEventData()
    {
      const string sFunc = "GetEventData";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      DevastatingCriticalEvent_Data data = default;
      VM.NWNX.StackPush(NWNX_WEAPON_GETDATA_DC);
      VM.NWNX.Call();
      data.oWeapon = VM.NWNX.StackPopObject();
      data.oTarget = VM.NWNX.StackPopObject();
      data.nDamage = VM.NWNX.StackPopInt();
      return data;
    }

    /// Bypass Devastating Critical.
    /// @note This is only for use with the Devastating Critical Event Script.
    public static void BypassDevastatingCritical()
    {
      const string sFunc = "SetEventData";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(1);
      VM.NWNX.StackPush(NWNX_WEAPON_SETDATA_DC_BYPASS);
      VM.NWNX.Call();
    }

    /// Sets weapon to gain .5 strength bonus.
    /// <param name="oWeapon">Should be a melee weapon.</param>
    /// <param name="nEnable">TRUE for bonus. FALSE to turn off bonus.</param>
    /// <param name="bPersist">whether the two hand state should persist to the gff file.</param>
    public static void SetOneHalfStrength(uint oWeapon, int nEnable, int bPersist = FALSE)
    {
      const string sFunc = "SetOneHalfStrength";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
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
      const string sFunc = "GetOneHalfStrength";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(oWeapon);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Override the max attack distance of ranged weapons.
    /// <param name="nBaseItem">The baseitem id.</param>
    /// <param name="fMax">The maximum attack distance. Default is 40.0f.</param>
    /// <param name="fMaxPassive">The maximum passive attack distance. Default is 20.0f. Seems to be used by the engine to determine a new nearby target when needed.</param>
    /// <param name="fPreferred">The preferred attack distance. See the PrefAttackDist column in baseitems.2da, default seems to be 30.0f for ranged weapons.</param>
    /// @note fMaxPassive should probably be lower than fMax, half of fMax seems to be a good start. fPreferred should be at least ~0.5f lower than fMax.
    public static void SetMaxRangedAttackDistanceOverride(int nBaseItem, float fMax, float fMaxPassive, float fPreferred)
    {
      const string sFunc = "SetMaxRangedAttackDistanceOverride";
      VM.NWNX.SetFunction(NWNX_Weapon, sFunc);
      VM.NWNX.StackPush(fPreferred);
      VM.NWNX.StackPush(fMaxPassive);
      VM.NWNX.StackPush(fMax);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.Call();
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
