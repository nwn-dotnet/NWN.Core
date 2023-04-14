using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Player)]
  public class PlayerPlugin
  {
    public const string NWNX_Player = "NWNX_Player";

    ///&lt; @private
    /// A quickbar slot.
    /// A journal entry.
    /// @name Timing Bar Types
    /// @anchor timing_bar_types
    ///
    /// The various types of timing bars.
    /// @{
    public const int NWNX_PLAYER_TIMING_BAR_TRAP_FLAG = 1;
    public const int NWNX_PLAYER_TIMING_BAR_TRAP_RECOVER = 2;
    public const int NWNX_PLAYER_TIMING_BAR_TRAP_DISARM = 3;
    public const int NWNX_PLAYER_TIMING_BAR_TRAP_EXAMINE = 4;
    public const int NWNX_PLAYER_TIMING_BAR_TRAP_SET = 5;
    public const int NWNX_PLAYER_TIMING_BAR_REST = 6;
    public const int NWNX_PLAYER_TIMING_BAR_UNLOCK = 7;
    public const int NWNX_PLAYER_TIMING_BAR_LOCK = 8;
    public const int NWNX_PLAYER_TIMING_BAR_CUSTOM = 10;

    // @}
    /// @name Platform IDs
    /// @anchor platform_ids
    /// @{
    public const int NWNX_PLAYER_PLATFORM_INVALID = 0;
    public const int NWNX_PLAYER_PLATFORM_WINDOWS_X86 = 1;
    public const int NWNX_PLAYER_PLATFORM_WINDOWS_X64 = 2;
    public const int NWNX_PLAYER_PLATFORM_LINUX_X86 = 10;
    public const int NWNX_PLAYER_PLATFORM_LINUX_X64 = 11;
    public const int NWNX_PLAYER_PLATFORM_LINUX_ARM32 = 12;
    public const int NWNX_PLAYER_PLATFORM_LINUX_ARM64 = 13;
    public const int NWNX_PLAYER_PLATFORM_MAC_X86 = 20;
    public const int NWNX_PLAYER_PLATFORM_MAC_X64 = 21;
    public const int NWNX_PLAYER_PLATFORM_IOS = 30;
    public const int NWNX_PLAYER_PLATFORM_ANDROID_ARM32 = 40;
    public const int NWNX_PLAYER_PLATFORM_ANDROID_ARM64 = 41;
    public const int NWNX_PLAYER_PLATFORM_ANDROID_X64 = 42;
    public const int NWNX_PLAYER_PLATFORM_NINTENDO_SWITCH = 50;
    public const int NWNX_PLAYER_PLATFORM_MICROSOFT_XBOXONE = 60;
    public const int NWNX_PLAYER_PLATFORM_SONY_PS4 = 70;

    // @}
    /// Force display placeable examine window for player
    /// @note If used on a placeable in a different area than the player, the portait will not be shown.
    /// <param name="player">The player object.</param>
    /// <param name="placeable">The placeable object.</param>
    public static void ForcePlaceableExamineWindow(uint player, uint placeable)
    {
      const string sFunc = "ForcePlaceableExamineWindow";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(placeable);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Force opens the target object&apos;s inventory for the player.
    /// @note
    /// * If the placeable is in a different area than the player, the portrait will not be shown
    /// * The placeable&apos;s open/close animations will be played
    /// * Clicking the &apos;close&apos; button will cause the player to walk to the placeable If the placeable is in a
    /// different area, the player will just walk to the edge of the current area and stop.
    /// This action can be cancelled manually.
    /// * Walking will close the placeable automatically.
    /// <param name="player">The player object.</param>
    /// <param name="placeable">The placeable object.</param>
    public static void ForcePlaceableInventoryWindow(uint player, uint placeable)
    {
      const string sFunc = "ForcePlaceableInventoryWindow";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(placeable);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Starts displaying a timing bar.
    /// <param name="player">The player object.</param>
    /// <param name="seconds">The length of time the timing bar will complete.</param>
    /// <param name="script">The script to run at the bar&apos;s completion.</param>
    /// <param name="type">The @ref timing_bar_types &quot;Timing Bar Type&quot;</param>
    /// @remark Only one timing bar can be ran at the same time.
    public static void StartGuiTimingBar(uint player, float seconds, string script = "", int type = NWNX_PLAYER_TIMING_BAR_CUSTOM)
    {
      if (GetLocalInt(player,  "NWNX_PLAYER_GUI_TIMING_ACTIVE") == TRUE)
      return ;
      const string sFunc = "StartGuiTimingBar";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(type);
      VM.NWNX.StackPush(seconds);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
      int id = GetLocalInt( player, "NWNX_PLAYER_GUI_TIMING_ID") +1;
      SetLocalInt(player,  "NWNX_PLAYER_GUI_TIMING_ACTIVE", id);
      SetLocalInt(player,  "NWNX_PLAYER_GUI_TIMING_ID", id);
      DelayCommand(seconds, () => INTERNAL_StopGuiTimingBar(player, script, id));
    }

    /// Stop displaying a timing bar.
    /// <param name="player">The player object.</param>
    /// <param name="script">The script to run when stopped.</param>
    public static void StopGuiTimingBar(uint player, string script = "")
    {
      INTERNAL_StopGuiTimingBar(player, script, -1);
    }

    /// Sets whether the player should always walk when given movement commands.
    /// <param name="player">The player object.</param>
    /// <param name="bWalk">TRUE to set the player to always walk.</param>
    /// @remark Clicking on the ground or using WASD will trigger walking instead of running.
    public static void SetAlwaysWalk(uint player, int bWalk = TRUE)
    {
      const string sFunc = "SetAlwaysWalk";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(bWalk);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Gets the player&apos;s quickbar slot info
    /// <param name="player">The player object.</param>
    /// <param name="slot">Slot ID 0-35</param>
    /// <returns>An NWNX_Player_QuickBarSlot struct.</returns>
    public static QuickBarSlot GetQuickBarSlot(uint player, int slot)
    {
      const string sFunc = "GetQuickBarSlot";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      QuickBarSlot qbs = default;
      VM.NWNX.StackPush(slot);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
      qbs.oAssociate = VM.NWNX.StackPopObject();
      qbs.nAssociateType = VM.NWNX.StackPopInt();
      qbs.nDomainLevel = VM.NWNX.StackPopInt();
      qbs.nMetaType = VM.NWNX.StackPopInt();
      qbs.nINTParam1 = VM.NWNX.StackPopInt();
      qbs.sToolTip = VM.NWNX.StackPopString();
      qbs.sCommandLine = VM.NWNX.StackPopString();
      qbs.sCommandLabel = VM.NWNX.StackPopString();
      qbs.sResRef = VM.NWNX.StackPopString();
      qbs.nMultiClass = VM.NWNX.StackPopInt();
      qbs.nObjectType = VM.NWNX.StackPopInt();
      qbs.oSecondaryItem = VM.NWNX.StackPopObject();
      qbs.oItem = VM.NWNX.StackPopObject();
      return qbs;
    }

    /// Sets the player&apos;s quickbar slot info
    /// <param name="player">The player object.</param>
    /// <param name="slot">Slot ID 0-35</param>
    /// <param name="qbs">An NWNX_Player_QuickBarSlot struct.</param>
    public static void SetQuickBarSlot(uint player, int slot, QuickBarSlot qbs)
    {
      const string sFunc = "SetQuickBarSlot";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(qbs.oItem);
      VM.NWNX.StackPush(qbs.oSecondaryItem);
      VM.NWNX.StackPush(qbs.nObjectType);
      VM.NWNX.StackPush(qbs.nMultiClass);
      VM.NWNX.StackPush(qbs.sResRef);
      VM.NWNX.StackPush(qbs.sCommandLabel);
      VM.NWNX.StackPush(qbs.sCommandLine);
      VM.NWNX.StackPush(qbs.sToolTip);
      VM.NWNX.StackPush(qbs.nINTParam1);
      VM.NWNX.StackPush(qbs.nMetaType);
      VM.NWNX.StackPush(qbs.nDomainLevel);
      VM.NWNX.StackPush(qbs.nAssociateType);
      VM.NWNX.StackPush(qbs.oAssociate);
      VM.NWNX.StackPush(slot);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Get the name of the .bic file associated with the player&apos;s character.
    /// <param name="player">The player object.</param>
    /// <returns>The filename for this player&apos;s bic. (Not including the &quot;.bic&quot;)</returns>
    public static string GetBicFileName(uint player)
    {
      const string sFunc = "GetBicFileName";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Plays the VFX at the target position in current area for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="effectId">The effect id.</param>
    /// <param name="position">The position to play the visual effect.</param>
    public static void ShowVisualEffect(uint player, int effectId, System.Numerics.Vector3 position)
    {
      const string sFunc = "ShowVisualEffect";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(position.X);
      VM.NWNX.StackPush(position.Y);
      VM.NWNX.StackPush(position.Z);
      VM.NWNX.StackPush(effectId);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Changes the daytime music track for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="track">The track id to play.</param>
    public static void MusicBackgroundChangeDay(uint player, int track)
    {
      const string sFunc = "ChangeBackgroundMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(track);
      VM.NWNX.StackPush(TRUE);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Changes the nighttime music track for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="track">The track id to play.</param>
    public static void MusicBackgroundChangeNight(uint player, int track)
    {
      const string sFunc = "ChangeBackgroundMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(track);
      VM.NWNX.StackPush(FALSE);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Starts the background music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBackgroundStart(uint player)
    {
      const string sFunc = "PlayBackgroundMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(TRUE);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Stops the background music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBackgroundStop(uint player)
    {
      const string sFunc = "PlayBackgroundMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(FALSE);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Changes the battle music track for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="track">The track id to play.</param>
    public static void MusicBattleChange(uint player, int track)
    {
      const string sFunc = "ChangeBattleMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(track);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Starts the battle music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBattleStart(uint player)
    {
      const string sFunc = "PlayBattleMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(TRUE);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Stops the battle music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBattleStop(uint player)
    {
      const string sFunc = "PlayBattleMusic";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(FALSE);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Play a sound at the location of target for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="sound">The sound resref.</param>
    /// <param name="target">The target object for the sound to originate. If target OBJECT_INVALID the sound</param>
    /// will play at the location of the player.
    public static void PlaySound(uint player, string sound, uint target = OBJECT_INVALID)
    {
      const string sFunc = "PlaySound";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(sound);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Toggle a placeable&apos;s usable flag for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="placeable">The placeable object.</param>
    /// <param name="usable">TRUE for usable.</param>
    public static void SetPlaceableUsable(uint player, uint placeable, int usable)
    {
      const string sFunc = "SetPlaceableUsable";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(usable);
      VM.NWNX.StackPush(placeable);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Override player&apos;s rest duration
    /// <param name="player">The player object.</param>
    /// <param name="duration">The duration of rest in milliseconds, 1000 = 1 second. Minimum duration of 10ms. -1 clears the override.</param>
    public static void SetRestDuration(uint player, int duration)
    {
      const string sFunc = "SetRestDuration";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(duration);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Apply visualeffect to target that only player can see
    /// <param name="player">The player object.</param>
    /// <param name="target">The target object to play the effect upon.</param>
    /// <param name="visualeffect">The visual effect id.</param>
    /// @note Only works with instant effects: VFX_COM_*, VFX_FNF_*, VFX_IMP_*
    public static void ApplyInstantVisualEffectToObject(uint player, uint target, int visualeffect)
    {
      const string sFunc = "ApplyInstantVisualEffectToObject";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(visualeffect);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Refreshes the players character sheet
    /// <param name="player">The player object.</param>
    /// @note You may need to use DelayCommand if you&apos;re manipulating values
    /// through nwnx and forcing a UI refresh, 0.5s seemed to be fine
    public static void UpdateCharacterSheet(uint player)
    {
      const string sFunc = "UpdateCharacterSheet";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Allows player to open target&apos;s inventory
    /// <param name="player">The player object.</param>
    /// <param name="target">The target object, must be a creature or another player.</param>
    /// <param name="open">TRUE to open.</param>
    /// @remark Only works if player and target are in the same area.
    public static void OpenInventory(uint player, uint target, int open = TRUE)
    {
      const string sFunc = "OpenInventory";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(open);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Get player&apos;s area exploration state
    /// <param name="player">The player object.</param>
    /// <param name="area">The area object.</param>
    /// <returns>A string representation of the tiles explored for that area.</returns>
    public static string GetAreaExplorationState(uint player, uint area)
    {
      const string sFunc = "GetAreaExplorationState";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(area);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Set player&apos;s area exploration state.
    /// <param name="player">The player object.</param>
    /// <param name="area">The area object.</param>
    /// <param name="str">An encoded string obtained with NWNX_Player_GetAreaExplorationState()</param>
    public static void SetAreaExplorationState(uint player, uint area, string str)
    {
      const string sFunc = "SetAreaExplorationState";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(str);
      VM.NWNX.StackPush(area);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Override player&apos;s rest animation.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="nAnimation">The NWNX animation id. This does not take ANIMATION_LOOPING_* or</param>
    /// ANIMATION_FIREFORGET_* constants. Instead use NWNX_Consts_TranslateNWScriptAnimation() to get
    /// the NWNX equivalent. -1 to clear the override.
    public static void SetRestAnimation(uint oPlayer, int nAnimation)
    {
      const string sFunc = "SetRestAnimation";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nAnimation);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Override a visual transform on the given object that only player will see.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The target object. Can be any valid Creature, Placeable, Item or Door.</param>
    /// <param name="nTransform">One of OBJECT_VISUAL_TRANSFORM_* or -1 to remove the override.</param>
    /// <param name="fValue">Depends on the transformation to apply.</param>
    public static void SetObjectVisualTransformOverride(uint oPlayer, uint oObject, int nTransform, float fValue)
    {
      const string sFunc = "SetObjectVisualTransformOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(fValue);
      VM.NWNX.StackPush(nTransform);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Apply a looping visualeffect to a target that only player can see
    /// <param name="player">The player object.</param>
    /// <param name="target">The target object.</param>
    /// <param name="visualeffect">A VFX_DUR_*. Calling again will remove an applied effect. -1 to remove all effects</param>
    /// @note Only really works with looping effects: VFX_DUR_*. Other types *kind* of work, they&apos;ll play when
    /// reentering the area and the object is in view or when they come back in view range.
    public static void ApplyLoopingVisualEffectToObject(uint player, uint target, int visualeffect)
    {
      const string sFunc = "ApplyLoopingVisualEffectToObject";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(visualeffect);
      VM.NWNX.StackPush(target);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Override the name of placeable for player only
    /// <param name="player">The player object.</param>
    /// <param name="placeable">The placeable object.</param>
    /// <param name="name">The name for the placeable for this player, &quot;&quot; to clear the override.</param>
    public static void SetPlaceableNameOverride(uint player, uint placeable, string name)
    {
      const string sFunc = "SetPlaceableNameOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(name);
      VM.NWNX.StackPush(placeable);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
    }

    /// Gets whether a quest has been completed by a player
    /// <param name="player">The player object.</param>
    /// <param name="sQuestName">The name identifier of the quest from the Journal Editor.</param>
    /// <returns>TRUE if the quest has been completed. -1 if the player does not have the journal entry.</returns>
    public static int GetQuestCompleted(uint player, string sQuestName)
    {
      const string sFunc = "GetQuestCompleted";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(sQuestName);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Place waypoints on module load representing where a PC should start
    ///
    /// This will require storing the PC&apos;s cd key or community name (depending on how you store in your vault)
    /// and bic_filename along with routinely updating their location in some persistent method like OnRest,
    /// OnAreaEnter and OnClentExit.
    ///
    /// <param name="sCDKeyOrCommunityName">The Public CD Key or Community Name of the player, this will depend on your vault type.</param>
    /// <param name="sBicFileName">The filename for the character. Retrieved with NWNX_Player_GetBicFileName().</param>
    /// <param name="oWP">The waypoint object to place where the PC should start.</param>
    /// <param name="bFirstConnectOnly">Set to FALSE if you would like the PC to go to this location every time they login instead</param>
    /// of just every server restart.
    public static void SetPersistentLocation(string sCDKeyOrCommunityName, string sBicFileName, uint oWP, int bFirstConnectOnly = TRUE)
    {
      const string sFunc = "SetPersistentLocation";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(bFirstConnectOnly);
      VM.NWNX.StackPush(oWP);
      VM.NWNX.StackPush(sBicFileName);
      VM.NWNX.StackPush(sCDKeyOrCommunityName);
      VM.NWNX.Call();
    }

    /// Force an item name to be updated.
    /// @note This is a workaround for bug that occurs when updating item names in open containers.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oItem">The item object.</param>
    public static void UpdateItemName(uint oPlayer, uint oItem)
    {
      const string sFunc = "UpdateItemName";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Possesses a creature by temporarily making them a familiar
    /// @details This command allows a PC to possess an NPC by temporarily adding them as a familiar. It will work
    /// if the player already has an existing familiar. The creatures must be in the same area. Unpossession can be
    /// done with the regular @nwn{UnpossessFamiliar} commands.
    /// @note The possessed creature will send automap data back to the possessor.
    /// If you wish to prevent this you may wish to use NWNX_Player_GetAreaExplorationState() and
    /// NWNX_Player_SetAreaExplorationState() before and after the possession.
    /// @note The possessing creature will be left wherever they were when beginning the possession. You may wish
    /// to use @nwn{EffectCutsceneImmobilize} and @nwn{EffectCutsceneGhost} to hide them.
    /// <param name="oPossessor">The possessor player object.</param>
    /// <param name="oPossessed">The possessed creature object. Only works on NPCs.</param>
    /// <param name="bMindImmune">If FALSE will remove the mind immunity effect on the possessor.</param>
    /// <param name="bCreateDefaultQB">If TRUE will populate the quick bar with default buttons.</param>
    /// <returns>TRUE if possession succeeded.</returns>
    public static int PossessCreature(uint oPossessor, uint oPossessed, int bMindImmune = TRUE, int bCreateDefaultQB = FALSE)
    {
      const string sFunc = "PossessCreature";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(bCreateDefaultQB);
      VM.NWNX.StackPush(bMindImmune);
      VM.NWNX.StackPush(oPossessed);
      VM.NWNX.StackPush(oPossessor);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the platform ID of the given player (NWNX_PLAYER_PLATFORM_*)
    /// <param name="oPlayer">The player object.</param>
    public static int GetPlatformId(uint oPlayer)
    {
      const string sFunc = "GetPlatformId";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the game language of the given player (uses NWNX_DIALOG_LANGUAGE_*)
    /// @details This function returns the ID of the game language displayed to the player.
    /// Uses the same constants as nwnx_dialog.
    /// <param name="oPlayer">The player object.</param>
    public static int GetLanguage(uint oPlayer)
    {
      const string sFunc = "GetLanguage";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Override sOldResName with sNewResName of nResType for oPlayer.
    /// @warning If sNewResName does not exist on oPlayer&apos;s client it will crash their game.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="nResType">The res type, see nwnx_util.nss for constants.</param>
    /// <param name="sOldResName">The old res name, 16 characters or less.</param>
    /// <param name="sNewResName">The new res name or &quot;&quot; to clear a previous override, 16 characters or less.</param>
    public static void SetResManOverride(uint oPlayer, int nResType, string sOldResName, string sNewResName)
    {
      const string sFunc = "SetResManOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(sNewResName);
      VM.NWNX.StackPush(sOldResName);
      VM.NWNX.StackPush(nResType);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Set nCustomTokenNumber to sTokenValue for oPlayer only.
    /// @note The basegame SetCustomToken() will override any personal tokens.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="nCustomTokenNumber">The token number.</param>
    /// <param name="sTokenValue">The token text.</param>
    public static void SetCustomToken(uint oPlayer, int nCustomTokenNumber, string sTokenValue)
    {
      const string sFunc = "SetCustomToken";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(sTokenValue);
      VM.NWNX.StackPush(nCustomTokenNumber);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Override the name of creature for player only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oCreature">The creature object.</param>
    /// <param name="sName">The name for the creature for this player, &quot;&quot; to clear the override.</param>
    public static void SetCreatureNameOverride(uint oPlayer, uint oCreature, string sName)
    {
      const string sFunc = "SetCreatureNameOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(sName);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Display floaty text above oCreature for oPlayer only.
    /// @note This will also display the floaty text above creatures that are not part of oPlayer&apos;s faction.
    /// <param name="oPlayer">The player to display the text to.</param>
    /// <param name="oCreature">The creature to display the text above.</param>
    /// <param name="sText">The text to display.</param>
    public static void FloatingTextStringOnCreature(uint oPlayer, uint oCreature, string sText)
    {
      const string sFunc = "FloatingTextStringOnCreature";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(sText);
      VM.NWNX.StackPush(oCreature);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Toggle oPlayer&apos;s PlayerDM status.
    /// @note This function does nothing for actual DMClient DMs or players with a client version &lt; 8193.14
    /// <param name="oPlayer">The player.</param>
    /// <param name="bIsDM">TRUE to toggle dm mode on, FALSE for off.</param>
    public static void ToggleDM(uint oPlayer, int bIsDM)
    {
      const string sFunc = "ToggleDM";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(bIsDM);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Override the mouse cursor of oObject for oPlayer only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The object.</param>
    /// <param name="nCursor">The cursor, one of MOUSECURSOR_*. -1 to clear the override.</param>
    public static void SetObjectMouseCursorOverride(uint oPlayer, uint oObject, int nCursor)
    {
      const string sFunc = "SetObjectMouseCursorOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nCursor);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Override the hilite color of oObject for oPlayer only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The object.</param>
    /// <param name="nColor">The color in 0xRRGGBB format, -1 to clear the override.</param>
    public static void SetObjectHiliteColorOverride(uint oPlayer, uint oObject, int nColor)
    {
      const string sFunc = "SetObjectHiliteColorOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nColor);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Remove effects with sEffectTag from oPlayer&apos;s TURD
    /// @note This function should be called in the NWNX_ON_CLIENT_DISCONNECT_AFTER event, OnClientLeave is too early for the TURD to exist.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="sEffectTag">The effect tag.</param>
    public static void RemoveEffectFromTURD(uint oPlayer, string sEffectTag)
    {
      const string sFunc = "RemoveEffectFromTURD";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(sEffectTag);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Set the location oPlayer will spawn when logging in to the server.
    /// @note This function is best called in the NWNX_ON_ELC_VALIDATE_CHARACTER_BEFORE event, OnClientEnter will be too late.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="locSpawn">The location.</param>
    public static void SetSpawnLocation(uint oPlayer, System.IntPtr locSpawn)
    {
      const string sFunc = "SetSpawnLocation";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      System.Numerics.Vector3 vPosition = GetPositionFromLocation(locSpawn);
      VM.NWNX.StackPush(GetFacingFromLocation(locSpawn));
      VM.NWNX.StackPush(vPosition.Z);
      VM.NWNX.StackPush(vPosition.Y);
      VM.NWNX.StackPush(vPosition.X);
      VM.NWNX.StackPush(GetAreaFromLocation(locSpawn));
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Resends palettes to a DM.
    /// <param name="oPlayer">- the DM to send them to.</param>
    public static void SendDMAllCreatorLists(uint oPlayer)
    {
      const string sFunc = "SendDMAllCreatorLists";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Give a custom journal entry to oPlayer.
    /// @warning Custom entries are wiped on client enter - they must be reapplied.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="journalEntry">The journal entry in the form of a struct.</param>
    /// <param name="nSilentUpdate">0 = Notify player via sound effects and feedback message, 1 = Suppress sound effects and feedback message</param>
    /// <returns>a positive number to indicate the new amount of journal entries on the player.</returns>
    /// @note In contrast to conventional nwn journal entries - this method will overwrite entries with the same tag, so the index / count of entries
    /// will only increase if you add new entries with unique tags
    public static int AddCustomJournalEntry(uint oPlayer, JournalEntry journalEntry, int nSilentUpdate = 0)
    {
      const string sFunc = "AddCustomJournalEntry";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nSilentUpdate);
      VM.NWNX.StackPush(journalEntry.nTimeOfDay);
      VM.NWNX.StackPush(journalEntry.nCalendarDay);
      VM.NWNX.StackPush(journalEntry.nUpdated);
      VM.NWNX.StackPush(journalEntry.nQuestDisplayed);
      VM.NWNX.StackPush(journalEntry.nQuestCompleted);
      VM.NWNX.StackPush(journalEntry.nPriority);
      VM.NWNX.StackPush(journalEntry.nState);
      VM.NWNX.StackPush(journalEntry.sTag);
      VM.NWNX.StackPush(journalEntry.sText);
      VM.NWNX.StackPush(journalEntry.sName);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns a struct containing a journal entry that can then be modified.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="questTag">The quest tag you wish to get the journal entry for.</param>
    /// <returns>a struct containing the journal entry data.</returns>
    /// @note This method will return -1 for the Updated field in the event that no matching journal entry was found,
    /// only the last matching quest tag will be returned. Eg: If you add 3 journal updates to a player, only the 3rd one will be returned as
    /// that is the active one that the player currently sees.
    public static JournalEntry GetJournalEntry(uint oPlayer, string questTag)
    {
      const string sFunc = "GetJournalEntry";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      JournalEntry entry = default;
      VM.NWNX.StackPush(questTag);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      entry.nUpdated = VM.NWNX.StackPopInt();
      if (entry.nUpdated==-1)
      {
        return entry;
      }
      entry.nQuestDisplayed = VM.NWNX.StackPopInt();
      entry.nQuestCompleted = VM.NWNX.StackPopInt();
      entry.nPriority = VM.NWNX.StackPopInt();
      entry.nState = VM.NWNX.StackPopInt();
      entry.nTimeOfDay = VM.NWNX.StackPopInt();
      entry.nCalendarDay = VM.NWNX.StackPopInt();
      entry.sName = VM.NWNX.StackPopString();
      entry.sText = VM.NWNX.StackPopString();
      entry.sTag = questTag;
      return entry;
    }

    /// Closes any store oPlayer may have open.
    /// <param name="oPlayer">The player object.</param>
    public static void CloseStore(uint oPlayer)
    {
      const string sFunc = "CloseStore";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Override nStrRef from the TlkTable with sOverride for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nStrRef">The StrRef.</param>
    /// <param name="sOverride">The new value for nStrRef or &quot;&quot; to remove the override.</param>
    /// <param name="bRestoreGlobal">If TRUE, when removing a personal override it will attempt to restore the global override if it exists.</param>
    /// @note Overrides will not persist through relogging.
    public static void SetTlkOverride(uint oPlayer, int nStrRef, string sOverride, int bRestoreGlobal = TRUE)
    {
      const string sFunc = "SetTlkOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(bRestoreGlobal);
      VM.NWNX.StackPush(sOverride);
      VM.NWNX.StackPush(nStrRef);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Update wind for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="vDirection">The Wind&apos;s direction.</param>
    /// <param name="fMagnitude">The Wind&apos;s magnitude.</param>
    /// <param name="fYaw">The Wind&apos;s yaw.</param>
    /// <param name="fPitch">The Wind&apos;s pitch.</param>
    public static void UpdateWind(uint oPlayer, System.Numerics.Vector3 vDirection, float fMagnitude, float fYaw, float fPitch)
    {
      const string sFunc = "UpdateWind";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(fPitch);
      VM.NWNX.StackPush(fYaw);
      VM.NWNX.StackPush(fMagnitude);
      VM.NWNX.StackPush(vDirection.X);
      VM.NWNX.StackPush(vDirection.Y);
      VM.NWNX.StackPush(vDirection.Z);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Update the SkyBox for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nSkyBox">The Skybox ID.</param>
    public static void UpdateSkyBox(uint oPlayer, int nSkyBox)
    {
      const string sFunc = "UpdateSkyBox";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nSkyBox);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Update Sun and Moon Fog Color for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nSunFogColor">The int value of Sun Fog color.</param>
    /// <param name="nMoonFogColor">The int value of Moon Fog color.</param>
    public static void UpdateFogColor(uint oPlayer, int nSunFogColor, int nMoonFogColor)
    {
      const string sFunc = "UpdateFogColor";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nMoonFogColor);
      VM.NWNX.StackPush(nSunFogColor);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Update Sun and Moon Fog Amount for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nSunFogAmount">The int value of Sun Fog amount (range 0-255).</param>
    /// <param name="nMoonFogAmount">The int value of Moon Fog amount (range 0-255).</param>
    public static void UpdateFogAmount(uint oPlayer, int nSunFogAmount, int nMoonFogAmount)
    {
      const string sFunc = "UpdateFogAmount";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nMoonFogAmount);
      VM.NWNX.StackPush(nSunFogAmount);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Return&apos;s the currently-possessed game object of a player.
    /// <param name="oPlayer">The player object (e.g. from GetFirst/NextPC()).</param>
    /// <returns>the actual game object of oPlayer, or OBJECT_INVALID on error.</returns>
    public static uint GetGameObject(uint oPlayer)
    {
      const string sFunc = "GetGameObject";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Override the ui discovery mask of oObject for oPlayer only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The target object.</param>
    /// <param name="nMask">A mask of OBJECT_UI_DISCOVERY_*, or -1 to clear the override</param>
    public static void SetObjectUiDiscoveryMaskOverride(uint oPlayer, uint oObject, int nMask)
    {
      const string sFunc = "SetObjectUiDiscoveryMaskOverride";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(nMask);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    /// Send a party invite from oInviter to oPlayer
    /// <param name="oPlayer">The player to invite</param>
    /// <param name="oInviter">The one inviting the player</param>
    /// <param name="bForceInvite">TRUE: Sends the invite even if the target ignores invites</param>
    /// <param name="bHideDialog">TRUE: Does not show the party invitation dialog</param>
    public static void SendPartyInvite(uint oPlayer, uint oInviter, int bForceInvite = FALSE, int bHideDialog = FALSE)
    {
      const string sFunc = "SendPartyInvite";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(bHideDialog);
      VM.NWNX.StackPush(bForceInvite);
      VM.NWNX.StackPush(oInviter);
      VM.NWNX.StackPush(oPlayer);
      VM.NWNX.Call();
    }

    // @}
    public static void INTERNAL_StopGuiTimingBar(uint player, string script = "", int id = -1)
    {
      int activeId = GetLocalInt(player,  "NWNX_PLAYER_GUI_TIMING_ACTIVE");
      if (activeId==0)
      return ;
      if (id!=-1&&id!=activeId)
      return ;
      DeleteLocalInt(player,  "NWNX_PLAYER_GUI_TIMING_ACTIVE");
      const string sFunc = "StopGuiTimingBar";
      VM.NWNX.SetFunction(NWNX_Player, sFunc);
      VM.NWNX.StackPush(player);
      VM.NWNX.Call();
      if (script!="")
      {
        ExecuteScript(script, player);
      }
    }

  }

  public struct QuickBarSlot
  {
    public uint oItem;
    public uint oSecondaryItem;
    public int nObjectType;
    public int nMultiClass;
    public string sResRef;
    public string sCommandLabel;
    public string sCommandLine;
    public string sToolTip;
    public int nINTParam1;
    public int nMetaType;
    public int nDomainLevel;
    public int nAssociateType;
    public uint oAssociate;
  }

  public struct JournalEntry
  {
    public string sName;
    public string sText;
    public string sTag;
    public int nState;
    public int nPriority;
    public int nQuestCompleted;
    public int nQuestDisplayed;
    public int nUpdated;
    public int nCalendarDay;
    public int nTimeOfDay;
  }
}
