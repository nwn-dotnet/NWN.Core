namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Appearance)]
  public class AppearancePlugin
  {
    public const string NWNX_Appearance = "NWNX_Appearance";

    /// @name Appearance Types
    /// @anchor appearance_types
    ///
    /// The various types of changes that can be made to how a PC is perceived.

    public const int NWNX_APPEARANCE_TYPE_APPEARANCE = 0;

    ///APPEARANCE_TYPE_* or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_GENDER = 1;

    ///GENDER_* or -1 to remove
    /// 0-GetMaxHitPoints(oCreature) or -1 to remove
    /// @note This is visual only. Does not change the Examine Window health status.
    public const int NWNX_APPEARANCE_TYPE_HITPOINTS = 2;
    public const int NWNX_APPEARANCE_TYPE_HAIR_COLOR = 3;

    ///0-175 or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_SKIN_COLOR = 4;

    /// 0-175 or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_PHENOTYPE = 5;

    ///PHENOTYPE_* or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_HEAD_TYPE = 6;

    ///0-? or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_SOUNDSET = 7;

    ///See soundset.2da or -1 to remove
    public const int NWNX_APPEARANCE_TYPE_TAIL_TYPE = 8;

    ///CREATURE_TAIL_TYPE_* or see tailmodel.2da, -1 to remove
    public const int NWNX_APPEARANCE_TYPE_WING_TYPE = 9;

    ///CREATURE_WING_TYPE_* or see wingmodel.2da, -1 to remove
    public const int NWNX_APPEARANCE_TYPE_FOOTSTEP_SOUND = 10;

    ///0-17 or see footstepsounds.2da, -1 to remove
    /// See portraits.2da, -1 to remove
    /// @note Does not change the Examine Window portrait.
    public const int NWNX_APPEARANCE_TYPE_PORTRAIT = 11;


    /// Override a creature's appearance type for a player.
    /// <param name="oPlayer">The player who will see/hear things differently.</param>
    /// <param name="oCreature">The target creature whose appearance type to alter for oPlayer. Can be a PC.</param>
    /// <param name="nType">The @ref appearance_types "Appearance Type" to set or -1 to fully remove override.</param>
    /// <param name="nValue">The new value for the appearance type.</param>
    public static void SetOverride(uint oPlayer, uint oCreature, int nType, int nValue)
    {
      VM.NWNX.SetFunction(NWNX_Appearance, "SetOverride");
      VM.NWNX.StackPush(nValue);
      VM.NWNX.StackPush(nType);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Get a creature's appearance type for a player.
    /// <param name="oPlayer">The player who see/hear things differently.</param>
    /// <param name="oCreature">The target creature whose appearance type is altered for oPlayer. Can be a PC.</param>
    /// <param name="nType">The @ref appearance_types "Appearance Type" to get.</param>
    /// <returns>The value for the appearance type or -1 when not set.</returns>
    public static int GetOverride(uint oPlayer, uint oCreature, int nType)
    {
      VM.NWNX.SetFunction(NWNX_Appearance, "GetOverride");
      VM.NWNX.StackPush(nType);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }
  }
}
