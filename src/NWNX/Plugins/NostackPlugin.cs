using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_NoStack)]
  public class NostackPlugin
  {
    public const string NWNX_NoStack = "NWNX_NoStack";

    ///&lt; @private
    /// @name Spell Effect Bonus Types
    /// @anchor spell_bonus_types
    ///
    /// Used with NWNX_NoStack_SetSpellBonusType() these are the effect bonus types.
    /// @{
    public const int NWNX_NOSTACK_EFFECT_TYPE_ENHANCEMENT = 0;
    public const int NWNX_NOSTACK_EFFECT_TYPE_CIRCUMSTANCE = 1;
    public const int NWNX_NOSTACK_EFFECT_TYPE_COMPETENCE = 2;
    public const int NWNX_NOSTACK_EFFECT_TYPE_INSIGHT = 3;
    public const int NWNX_NOSTACK_EFFECT_TYPE_LUCK = 4;
    public const int NWNX_NOSTACK_EFFECT_TYPE_MORALE = 5;
    public const int NWNX_NOSTACK_EFFECT_TYPE_PROFANE = 6;
    public const int NWNX_NOSTACK_EFFECT_TYPE_RESISTANCE = 7;
    public const int NWNX_NOSTACK_EFFECT_TYPE_SACRED = 8;

    // @}
    /// Sets a spell bonus type to be used by the NoStack feature.
    /// <param name="spell">The spell ID from spells.2da.</param>
    /// <param name="type">The new type.</param>
    public static void SetSpellBonusType(int spell, int type)
    {
      const string sFunc = "SetSpellBonusType";
      VM.NWNX.SetFunction(NWNX_NoStack, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(spell);
      VM.NWNX.Call();
    }

    // @}
  }
}
