using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Appearance)]
  public class AppearancePlugin
  {
    public const string NWNX_Appearance = "NWNX_Appearance";

    ///&lt; @private
    /// @name Appearance Types
    /// @anchor appearance_types
    ///
    /// The various types of changes that can be made to how a PC is perceived.
    /// @{
    public const int NWNX_APPEARANCE_TYPE_APPEARANCE = 0;

    ///&lt; APPEARANCE_TYPE_* or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_GENDER = 1;

    ///&lt; GENDER_* or -1 to remove
    /// 0-GetMaxHitPoints(oCreature) or -1 to remove
    /// @note This is visual only. Does not change the Examine Window health status.
    public const int NWNX_APPEARANCE_TYPE_HITPOINTS = 2;
    public const int NWNX_APPEARANCE_TYPE_HAIR_COLOR = 3;

    ///&lt; 0-175 or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_SKIN_COLOR = 4;

    ///&lt; 0-175 or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_PHENOTYPE = 5;

    ///&lt; PHENOTYPE_* or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_HEAD_TYPE = 6;

    ///&lt; 0-? or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_SOUNDSET = 7;

    ///&lt; See soundset.2da or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_TAIL_TYPE = 8;

    ///&lt; CREATURE_TAIL_TYPE_* or see tailmodel.2da, -1 to remove
    public const int NWNX_APPEARANCE_TYPE_WING_TYPE = 9;

    ///&lt; CREATURE_WING_TYPE_* or see wingmodel.2da, -1 to remove
    public const int NWNX_APPEARANCE_TYPE_FOOTSTEP_SOUND = 10;

    ///&lt; 0-17 or see footstepsounds.2da, -1 to remove
    /// See portraits.2da, -1 to remove
    /// @note Does not change the Examine Window portrait.
    public const int NWNX_APPEARANCE_TYPE_PORTRAIT = 11;

    ///@}
    /// Override a creature&apos;s appearance type for a player.
    /// <param name="oPlayer">The player who will see/hear things differently.</param>
    /// <param name="oCreature">The target creature whose appearance type to alter for oPlayer. Can be a PC.</param>
    /// <param name="nType">The @ref appearance_types &quot;Appearance Type&quot; to set or -1 to fully remove override.</param>
    /// <param name="nValue">The new value for the appearance type.</param>
    public static void SetOverride(uint oPlayer, uint oCreature, int nType, int nValue)
    {
      const string sFunc = "SetOverride";
      VM.NWNX.SetFunction(NWNX_Appearance, sFunc);
      VM.NWNX.StackPush(nValue);
      VM.NWNX.StackPush(nType);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Get a creature&apos;s appearance type for a player.
    /// <param name="oPlayer">The player who see/hear things differently.</param>
    /// <param name="oCreature">The target creature whose appearance type is altered for oPlayer. Can be a PC.</param>
    /// <param name="nType">The @ref appearance_types &quot;Appearance Type&quot; to get.</param>
    /// <returns>The value for the appearance type or -1 when not set.</returns>
    public static int GetOverride(uint oPlayer, uint oCreature, int nType)
    {
      const string sFunc = "GetOverride";
      VM.NWNX.SetFunction(NWNX_Appearance, sFunc);
      VM.NWNX.StackPush(nType);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    // @}
  }
}
