namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Reveal)]
  public class RevealPlugin
  {
    public const string NWNX_Reveal = "NWNX_Reveal";

    // /< @private
    // / @name Reveal Detection Methods
    // / @{
    public const int NWNX_REVEAL_SEEN = 1;

    // /< Seen
    public const int NWNX_REVEAL_HEARD = 0;

    // /< Heard
    // /@}
    // / @brief Selectively reveals the character to an observer until the next time they stealth out of sight.
    // / @param oHiding The creature who is stealthed.
    // / @param oObserver The creature to whom the hider is revealed.
    // / @param iDetectionMethod Can be specified to determine whether the hidden creature is seen or heard.
    public static void RevealTo(uint oHiding, uint oObserver, int iDetectionMethod = NWNX_REVEAL_HEARD)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Reveal, "RevealTo");
      Internal.NativeFunctions.nwnxPushInt(iDetectionMethod);
      Internal.NativeFunctions.nwnxPushObject(oObserver);
      Internal.NativeFunctions.nwnxPushObject(oHiding);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Sets whether a character remains visible to their party through stealth.
    // / @param oHiding The creature who is stealthed.
    // / @param bReveal TRUE for visible.
    // / @param iDetectionMethod Can be specified to determine whether the hidden creature is seen or heard.
    public static void SetRevealToParty(uint oHiding, int bReveal, int iDetectionMethod = NWNX_REVEAL_HEARD)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Reveal, "SetRevealToParty");
      Internal.NativeFunctions.nwnxPushInt(iDetectionMethod);
      Internal.NativeFunctions.nwnxPushInt(bReveal);
      Internal.NativeFunctions.nwnxPushObject(oHiding);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @}
  }
}