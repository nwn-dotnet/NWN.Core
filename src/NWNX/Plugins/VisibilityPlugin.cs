namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Visibility)]
  public class VisibilityPlugin
  {
    public const string NWNX_Visibility = "NWNX_Visibility";


    /// @name Visibility Types
    /// @anchor vis_types
    public const int NWNX_VISIBILITY_DEFAULT = -1;
    public const int NWNX_VISIBILITY_VISIBLE = 0;
    public const int NWNX_VISIBILITY_HIDDEN = 1;
    public const int NWNX_VISIBILITY_DM_ONLY = 2;
    public const int NWNX_VISIBILITY_ALWAYS_VISIBLE = 3;
    public const int NWNX_VISIBILITY_ALWAYS_VISIBLE_DM_ONLY = 4;

    /// Queries the existing visibility override for given (oPlayer, oTarget) pair.
    ///        If oPlayer is OBJECT_INVALID, the global visibility override will be returned.
    ///
    ///  * NWNX_VISIBILITY_DEFAULT = Override not set.
    ///  * NWNX_VISIBILITY_VISIBLE = Target is visible but still adheres to default visibility rules.
    ///  * NWNX_VISIBILITY_HIDDEN  = Target is always hidden.
    ///  * NWNX_VISIBILITY_DM_ONLY = Target is only visible to DMs but still adheres to default visibility rules.
    ///  * NWNX_VISIBILITY_ALWAYS_VISIBLE = Target is always visible in all circumstances.
    ///  * NWNX_VISIBILITY_ALWAYS_VISIBLE_DM_ONLY = Target is always visible only to DMs in all circumstances.
    ///
    /// <param name="oPlayer">The PC Object or OBJECT_INVALID.</param>
    /// <param name="oTarget">The object for which we're querying the visibility override.</param>
    /// <returns>The @ref vis_types "Visibility Type".</returns>
    public static int GetVisibilityOverride(uint oPlayer, uint oTarget)
    {
      VM.NWNX.SetFunction(NWNX_Visibility, "GetVisibilityOverride");
      VM.NWNX.StackPush(oTarget);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Overrides the default visibility rules about how oPlayer perceives oTarget.
    ///        If oPlayer is OBJECT_INVALID, the global visibility override will be set.
    ///
    ///  * NWNX_VISIBILITY_DEFAULT = Remove a set override.
    ///  * NWNX_VISIBILITY_VISIBLE = Target is visible but still adheres to default visibility rules.
    ///  * NWNX_VISIBILITY_HIDDEN  = Target is always hidden.
    ///  * NWNX_VISIBILITY_DM_ONLY = Target is only visible to DMs but still adheres to default visibility rules.
    ///  * NWNX_VISIBILITY_ALWAYS_VISIBLE = Target is always visible in all circumstances.
    ///  * NWNX_VISIBILITY_ALWAYS_VISIBLE_DM_ONLY = Target is always visible to DMs in all circumstances.
    ///
    /// @warning Setting too many objects to ALWAYS_VISIBLE in an area will impact the performance of your players. Use sparingly.
    ///
    /// @note Player state overrides the global state which means if a global state is set
    /// to NWNX_VISIBILITY_HIDDEN or NWNX_VISIBILITY_DM_ONLY but the player's state is
    /// set to NWNX_VISIBILITY_VISIBLE for the target, the object will be visible to the player.
    ///
    /// <param name="oPlayer">The PC Object or OBJECT_INVALID.</param>
    /// <param name="oTarget">The object for which we're altering the visibility.</param>
    /// <param name="nOverride">The visibility type from @ref vis_types "Visibility Types".</param>
    public static void SetVisibilityOverride(uint oPlayer, uint oTarget, int nOverride)
    {
      VM.NWNX.SetFunction(NWNX_Visibility, "SetVisibilityOverride");
      VM.NWNX.StackPush(nOverride);
      VM.NWNX.StackPush(oTarget);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }
  }
}
