using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Reveal)]
  public class RevealPlugin
  {
    /// @addtogroup reveal Reveal
    /// Allows the selective revealing of a stealthing character to another character or their party.
    /// @{
    /// @file nwnx_reveal.nss
    public const string NWNX_Reveal = "NWNX_Reveal";

    ///&lt; @private
    /// @name Reveal Detection Methods
    /// @{
    public const int NWNX_REVEAL_SEEN = 1;

    ///&lt; Seen
    public const int NWNX_REVEAL_HEARD = 0;

    ///&lt; Heard
    ///@}
    /// Selectively reveals the character to an observer until the next time they stealth out of sight.
    /// <param name="oHiding">The creature who is stealthed.</param>
    /// <param name="oObserver">The creature to whom the hider is revealed.</param>
    /// <param name="iDetectionMethod">Can be specified to determine whether the hidden creature is seen or heard.</param>
    public static void RevealTo(uint oHiding, uint oObserver, int iDetectionMethod = NWNX_REVEAL_HEARD)
    {
      NWNXPushInt(iDetectionMethod);
      NWNXPushObject(oObserver);
      NWNXPushObject(oHiding);
      NWNXCall(NWNX_Reveal, "RevealTo");
    }

    /// Sets whether a character remains visible to their party through stealth.
    /// <param name="oHiding">The creature who is stealthed.</param>
    /// <param name="bReveal">TRUE for visible.</param>
    /// <param name="iDetectionMethod">Can be specified to determine whether the hidden creature is seen or heard.</param>
    public static void SetRevealToParty(uint oHiding, int bReveal, int iDetectionMethod = NWNX_REVEAL_HEARD)
    {
      NWNXPushInt(iDetectionMethod);
      NWNXPushInt(bReveal);
      NWNXPushObject(oHiding);
      NWNXCall(NWNX_Reveal, "SetRevealToParty");
    }

    // @}
  }
}
