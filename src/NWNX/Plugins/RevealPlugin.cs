using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Reveal)]
  public class RevealPlugin
  {
    public const string NWNX_Reveal = "NWNX_Reveal";

    ///< @private
    /// @name Reveal Detection Methods
    /// @{
    public const int NWNX_REVEAL_SEEN = 1;

    ///< Seen
    public const int NWNX_REVEAL_HEARD = 0;

    ///< Heard
    ///@}
    /// Selectively reveals the character to an observer until the next time they stealth out of sight.
    /// <param name="oHiding">The creature who is stealthed.</param>
    /// <param name="oObserver">The creature to whom the hider is revealed.</param>
    /// <param name="iDetectionMethod">Can be specified to determine whether the hidden creature is seen or heard.</param>
    public static void RevealTo(uint oHiding, uint oObserver, int iDetectionMethod = NWNX_REVEAL_HEARD)
    {
      const string sFunc = "RevealTo";
      VM.NWNX.SetFunction(NWNX_Reveal, sFunc);
      VM.NWNX.StackPush(iDetectionMethod);
      VM.NWNX.StackPush(oObserver);
      VM.NWNX.StackPush(oHiding);
      VM.NWNX.Call();
    }

    /// Sets whether a character remains visible to their party through stealth.
    /// <param name="oHiding">The creature who is stealthed.</param>
    /// <param name="bReveal">TRUE for visible.</param>
    /// <param name="iDetectionMethod">Can be specified to determine whether the hidden creature is seen or heard.</param>
    public static void SetRevealToParty(uint oHiding, int bReveal, int iDetectionMethod = NWNX_REVEAL_HEARD)
    {
      const string sFunc = "SetRevealToParty";
      VM.NWNX.SetFunction(NWNX_Reveal, sFunc);
      VM.NWNX.StackPush(iDetectionMethod);
      VM.NWNX.StackPush(bReveal);
      VM.NWNX.StackPush(oHiding);
      VM.NWNX.Call();
    }

    /// @}
  }
}
