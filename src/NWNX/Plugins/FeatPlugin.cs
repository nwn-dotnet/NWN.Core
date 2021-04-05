using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Feat)]
  public class FeatPlugin
  {
    public const string NWNX_Feat = "NWNX_Feat";

    ///&lt; @private
    /// @name Feat Modifiers
    /// @anchor feat_modifiers
    ///
    /// @{
    public const int NWNX_FEAT_MODIFIER_INVALID = 0;
    public const int NWNX_FEAT_MODIFIER_AB = 1;
    public const int NWNX_FEAT_MODIFIER_ABILITY = 2;
    public const int NWNX_FEAT_MODIFIER_ABVSRACE = 3;
    public const int NWNX_FEAT_MODIFIER_AC = 4;
    public const int NWNX_FEAT_MODIFIER_ACVSRACE = 5;
    public const int NWNX_FEAT_MODIFIER_ARCANESPELLFAILURE = 6;
    public const int NWNX_FEAT_MODIFIER_CONCEALMENT = 7;
    public const int NWNX_FEAT_MODIFIER_DMGIMMUNITY = 8;
    public const int NWNX_FEAT_MODIFIER_DMGREDUCTION = 9;
    public const int NWNX_FEAT_MODIFIER_DMGRESIST = 10;
    public const int NWNX_FEAT_MODIFIER_IMMUNITY = 11;
    public const int NWNX_FEAT_MODIFIER_MOVEMENTSPEED = 12;
    public const int NWNX_FEAT_MODIFIER_REGENERATION = 13;
    public const int NWNX_FEAT_MODIFIER_SAVE = 14;
    public const int NWNX_FEAT_MODIFIER_SAVEVSRACE = 15;
    public const int NWNX_FEAT_MODIFIER_SAVEVSTYPE = 16;
    public const int NWNX_FEAT_MODIFIER_SAVEVSTYPERACE = 17;
    public const int NWNX_FEAT_MODIFIER_SPELLIMMUNITY = 18;
    public const int NWNX_FEAT_MODIFIER_SRCHARGEN = 19;
    public const int NWNX_FEAT_MODIFIER_SRINCLEVEL = 20;
    public const int NWNX_FEAT_MODIFIER_SPELLSAVEDC = 21;
    public const int NWNX_FEAT_MODIFIER_BONUSSPELL = 22;
    public const int NWNX_FEAT_MODIFIER_TRUESEEING = 23;
    public const int NWNX_FEAT_MODIFIER_SEEINVISIBLE = 24;
    public const int NWNX_FEAT_MODIFIER_ULTRAVISION = 25;
    public const int NWNX_FEAT_MODIFIER_HASTE = 26;
    public const int NWNX_FEAT_MODIFIER_VISUALEFFECT = 27;

    ///@}
    /// Sets a feat modifier.
    /// <param name="iFeat">The Feat constant or value in feat.2da.</param>
    /// <param name="iMod">The @ref feat_modifiers &quot;feat modifier&quot; to set.</param>
    /// <param name="iParam1,">iParam2, iParam3, iParam4 The parameters for this feat modifier.</param>
    public static void SetFeatModifier(int iFeat, int iMod, int iParam1 = -559038737, int iParam2 = -559038737, int iParam3 = -559038737, int iParam4 = -559038737)
    {
      const string sFunc = "SetFeatModifier";
      VM.NWNX.SetFunction(NWNX_Feat, sFunc);
      VM.NWNX.StackPush(iParam4);
      VM.NWNX.StackPush(iParam3);
      VM.NWNX.StackPush(iParam2);
      VM.NWNX.StackPush(iParam1);
      VM.NWNX.StackPush(iMod);
      VM.NWNX.StackPush(iFeat);
      VM.NWNX.Call();
    }

    // @}
  }
}
