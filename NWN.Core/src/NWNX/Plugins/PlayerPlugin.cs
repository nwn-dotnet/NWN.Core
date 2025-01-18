using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Player)]
  public class PlayerPlugin
  {
    /// @addtogroup player
    /// Functions exposing additional player properties.
    /// @{
    /// @file nwnx_player.nss
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
      NWNXPushObject(placeable);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ForcePlaceableExamineWindow");
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
      NWNXPushObject(placeable);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ForcePlaceableInventoryWindow");
    }

    /// Starts displaying a timing bar.
    /// <param name="player">The player object.</param>
    /// <param name="seconds">The length of time the timing bar will complete.</param>
    /// <param name="script">The script to run at the bar&apos;s completion.</param>
    /// <param name="type">The @ref timing_bar_types &quot;Timing Bar Type&quot;</param>
    /// @remark Only one timing bar can be ran at the same time.
    public static void StartGuiTimingBar(uint player, float seconds, string script = "", int type = NWNX_PLAYER_TIMING_BAR_CUSTOM)
    {
      if (GetLocalInt(player, "NWNX_PLAYER_GUI_TIMING_ACTIVE") == TRUE)
      return ;
      NWNXPushInt(type);
      NWNXPushFloat(seconds);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "StartGuiTimingBar");
      int id = GetLocalInt( player, "NWNX_PLAYER_GUI_TIMING_ID") +1;
      SetLocalInt(player, "NWNX_PLAYER_GUI_TIMING_ACTIVE", id);
      SetLocalInt(player, "NWNX_PLAYER_GUI_TIMING_ID", id);
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
      NWNXPushInt(bWalk);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "SetAlwaysWalk");
    }

    /// Gets the player&apos;s quickbar slot info
    /// <param name="player">The player object.</param>
    /// <param name="slot">Slot ID 0-35</param>
    /// <returns>An NWNX_Player_QuickBarSlot struct.</returns>
    public static QuickBarSlot GetQuickBarSlot(uint player, int slot)
    {
      QuickBarSlot qbs = default;
      NWNXPushInt(slot);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "GetQuickBarSlot");
      qbs.oAssociate = NWNXPopObject();
      qbs.nAssociateType = NWNXPopInt();
      qbs.nDomainLevel = NWNXPopInt();
      qbs.nMetaType = NWNXPopInt();
      qbs.nINTParam1 = NWNXPopInt();
      qbs.sToolTip = NWNXPopString();
      qbs.sCommandLine = NWNXPopString();
      qbs.sCommandLabel = NWNXPopString();
      qbs.sResRef = NWNXPopString();
      qbs.nMultiClass = NWNXPopInt();
      qbs.nObjectType = NWNXPopInt();
      qbs.oSecondaryItem = NWNXPopObject();
      qbs.oItem = NWNXPopObject();
      return qbs;
    }

    /// Sets the player&apos;s quickbar slot info
    /// <param name="player">The player object.</param>
    /// <param name="slot">Slot ID 0-35</param>
    /// <param name="qbs">An NWNX_Player_QuickBarSlot struct.</param>
    public static void SetQuickBarSlot(uint player, int slot, QuickBarSlot qbs)
    {
      NWNXPushObject(qbs.oItem);
      NWNXPushObject(qbs.oSecondaryItem);
      NWNXPushInt(qbs.nObjectType);
      NWNXPushInt(qbs.nMultiClass);
      NWNXPushString(qbs.sResRef);
      NWNXPushString(qbs.sCommandLabel);
      NWNXPushString(qbs.sCommandLine);
      NWNXPushString(qbs.sToolTip);
      NWNXPushInt(qbs.nINTParam1);
      NWNXPushInt(qbs.nMetaType);
      NWNXPushInt(qbs.nDomainLevel);
      NWNXPushInt(qbs.nAssociateType);
      NWNXPushObject(qbs.oAssociate);
      NWNXPushInt(slot);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "SetQuickBarSlot");
    }

    /// Get the name of the .bic file associated with the player&apos;s character.
    /// <param name="player">The player object.</param>
    /// <returns>The filename for this player&apos;s bic. (Not including the &quot;.bic&quot;)</returns>
    public static string GetBicFileName(uint player)
    {
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "GetBicFileName");
      return NWNXPopString();
    }

    /// Plays the VFX at the target position in current area for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="effectId">The effect id.</param>
    /// <param name="position">The position to play the visual effect.</param>
    /// <param name="scale">The scale of the effect</param>
    /// <param name="translate">A translation vector to offset the position of the effect</param>
    /// <param name="rotate">A rotation vector to rotate the effect</param>
    public static void ShowVisualEffect(uint player, int effectId, System.Numerics.Vector3 position, float scale = 1.0f, System.Numerics.Vector3 translate = default, System.Numerics.Vector3 rotate = default)
    {
      NWNXPushVector(rotate);
      NWNXPushVector(translate);
      NWNXPushFloat(scale);
      NWNXPushVector(position);
      NWNXPushInt(effectId);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ShowVisualEffect");
    }

    /// Changes the daytime music track for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="track">The track id to play.</param>
    public static void MusicBackgroundChangeDay(uint player, int track)
    {
      NWNXPushInt(track);
      NWNXPushInt(TRUE);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ChangeBackgroundMusic");
    }

    /// Changes the nighttime music track for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="track">The track id to play.</param>
    public static void MusicBackgroundChangeNight(uint player, int track)
    {
      NWNXPushInt(track);
      NWNXPushInt(FALSE);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ChangeBackgroundMusic");
    }

    /// Starts the background music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBackgroundStart(uint player)
    {
      NWNXPushInt(TRUE);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "PlayBackgroundMusic");
    }

    /// Stops the background music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBackgroundStop(uint player)
    {
      NWNXPushInt(FALSE);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "PlayBackgroundMusic");
    }

    /// Changes the battle music track for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="track">The track id to play.</param>
    public static void MusicBattleChange(uint player, int track)
    {
      NWNXPushInt(track);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ChangeBattleMusic");
    }

    /// Starts the battle music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBattleStart(uint player)
    {
      NWNXPushInt(TRUE);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "PlayBattleMusic");
    }

    /// Stops the battle music for the given player only
    /// <param name="player">The player object.</param>
    public static void MusicBattleStop(uint player)
    {
      NWNXPushInt(FALSE);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "PlayBattleMusic");
    }

    /// Play a sound at the location of target for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="sound">The sound resref.</param>
    /// <param name="target">The target object for the sound to originate. If target OBJECT_INVALID the sound</param>
    /// will play at the location of the player.
    public static void PlaySound(uint player, string sound, uint target = OBJECT_INVALID)
    {
      NWNXPushObject(target);
      NWNXPushString(sound);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "PlaySound");
    }

    /// Toggle a placeable&apos;s usable flag for the given player only
    /// <param name="player">The player object.</param>
    /// <param name="placeable">The placeable object.</param>
    /// <param name="usable">TRUE for usable.</param>
    public static void SetPlaceableUsable(uint player, uint placeable, int usable)
    {
      NWNXPushInt(usable);
      NWNXPushObject(placeable);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "SetPlaceableUsable");
    }

    /// Override player&apos;s rest duration
    /// <param name="player">The player object.</param>
    /// <param name="duration">The duration of rest in milliseconds, 1000 = 1 second. Minimum duration of 10ms. -1 clears the override.</param>
    public static void SetRestDuration(uint player, int duration)
    {
      NWNXPushInt(duration);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "SetRestDuration");
    }

    /// Apply visualeffect to target that only player can see
    /// <param name="player">The player object.</param>
    /// <param name="target">The target object to play the effect upon.</param>
    /// <param name="visualeffect">The visual effect id.</param>
    /// <param name="scale">The scale of the effect</param>
    /// <param name="translate">A translation vector to offset the position of the effect</param>
    /// <param name="rotate">A rotation vector to rotate the effect</param>
    /// @note Only works with instant effects: VFX_COM_*, VFX_FNF_*, VFX_IMP_*
    public static void ApplyInstantVisualEffectToObject(uint player, uint target, int visualeffect, float scale = 1.0f, System.Numerics.Vector3 translate = default, System.Numerics.Vector3 rotate = default)
    {
      NWNXPushVector(rotate);
      NWNXPushVector(translate);
      NWNXPushFloat(scale);
      NWNXPushInt(visualeffect);
      NWNXPushObject(target);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ApplyInstantVisualEffectToObject");
    }

    /// Refreshes the players character sheet
    /// <param name="player">The player object.</param>
    /// @note You may need to use DelayCommand if you&apos;re manipulating values
    /// through nwnx and forcing a UI refresh, 0.5s seemed to be fine
    public static void UpdateCharacterSheet(uint player)
    {
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "UpdateCharacterSheet");
    }

    /// Allows player to open target&apos;s inventory
    /// <param name="player">The player object.</param>
    /// <param name="target">The target object, must be a creature or another player.</param>
    /// <param name="open">TRUE to open.</param>
    /// @remark Only works if player and target are in the same area.
    public static void OpenInventory(uint player, uint target, int open = TRUE)
    {
      NWNXPushInt(open);
      NWNXPushObject(target);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "OpenInventory");
    }

    /// Get player&apos;s area exploration state
    /// <param name="player">The player object.</param>
    /// <param name="area">The area object.</param>
    /// <returns>A string representation of the tiles explored for that area.</returns>
    public static string GetAreaExplorationState(uint player, uint area)
    {
      NWNXPushObject(area);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "GetAreaExplorationState");
      return NWNXPopString();
    }

    /// Set player&apos;s area exploration state.
    /// <param name="player">The player object.</param>
    /// <param name="area">The area object.</param>
    /// <param name="str">An encoded string obtained with NWNX_Player_GetAreaExplorationState()</param>
    public static void SetAreaExplorationState(uint player, uint area, string str)
    {
      NWNXPushString(str);
      NWNXPushObject(area);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "SetAreaExplorationState");
    }

    /// Override player&apos;s rest animation.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="nAnimation">The NWNX animation id. This does not take ANIMATION_LOOPING_* or</param>
    /// ANIMATION_FIREFORGET_* constants. Instead use NWNX_Consts_TranslateNWScriptAnimation() to get
    /// the NWNX equivalent. -1 to clear the override.
    public static void SetRestAnimation(uint oPlayer, int nAnimation)
    {
      NWNXPushInt(nAnimation);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetRestAnimation");
    }

    /// Override a visual transform on the given object that only player will see.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The target object. Can be any valid Creature, Placeable, Item or Door.</param>
    /// <param name="nTransform">One of OBJECT_VISUAL_TRANSFORM_* or -1 to remove the override.</param>
    /// <param name="fValue">Depends on the transformation to apply.</param>
    public static void SetObjectVisualTransformOverride(uint oPlayer, uint oObject, int nTransform, float fValue)
    {
      NWNXPushFloat(fValue);
      NWNXPushInt(nTransform);
      NWNXPushObject(oObject);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetObjectVisualTransformOverride");
    }

    /// Apply a looping visualeffect to a target that only player can see
    /// <param name="player">The player object.</param>
    /// <param name="target">The target object.</param>
    /// <param name="visualeffect">A VFX_DUR_*. Calling again will remove an applied effect. -1 to remove all effects</param>
    /// @note Only really works with looping effects: VFX_DUR_*. Other types *kind* of work, they&apos;ll play when
    /// reentering the area and the object is in view or when they come back in view range.
    public static void ApplyLoopingVisualEffectToObject(uint player, uint target, int visualeffect)
    {
      NWNXPushInt(visualeffect);
      NWNXPushObject(target);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "ApplyLoopingVisualEffectToObject");
    }

    /// Override the name of placeable for player only
    /// <param name="player">The player object.</param>
    /// <param name="placeable">The placeable object.</param>
    /// <param name="name">The name for the placeable for this player, &quot;&quot; to clear the override.</param>
    public static void SetPlaceableNameOverride(uint player, uint placeable, string name)
    {
      NWNXPushString(name);
      NWNXPushObject(placeable);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "SetPlaceableNameOverride");
    }

    /// Gets whether a quest has been completed by a player
    /// <param name="player">The player object.</param>
    /// <param name="sQuestName">The name identifier of the quest from the Journal Editor.</param>
    /// <returns>TRUE if the quest has been completed. -1 if the player does not have the journal entry.</returns>
    public static int GetQuestCompleted(uint player, string sQuestName)
    {
      NWNXPushString(sQuestName);
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "GetQuestCompleted");
      return NWNXPopInt();
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
      NWNXPushInt(bFirstConnectOnly);
      NWNXPushObject(oWP);
      NWNXPushString(sBicFileName);
      NWNXPushString(sCDKeyOrCommunityName);
      NWNXCall(NWNX_Player, "SetPersistentLocation");
    }

    /// Force an item name to be updated.
    /// @note This is a workaround for bug that occurs when updating item names in open containers.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oItem">The item object.</param>
    public static void UpdateItemName(uint oPlayer, uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "UpdateItemName");
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
      NWNXPushInt(bCreateDefaultQB);
      NWNXPushInt(bMindImmune);
      NWNXPushObject(oPossessed);
      NWNXPushObject(oPossessor);
      NWNXCall(NWNX_Player, "PossessCreature");
      return NWNXPopInt();
    }

    /// Returns the platform ID of the given player (NWNX_PLAYER_PLATFORM_*)
    /// <param name="oPlayer">The player object.</param>
    public static int GetPlatformId(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "GetPlatformId");
      return NWNXPopInt();
    }

    /// Returns the game language of the given player (uses NWNX_DIALOG_LANGUAGE_*)
    /// @details This function returns the ID of the game language displayed to the player.
    /// Uses the same constants as nwnx_dialog.
    /// <param name="oPlayer">The player object.</param>
    public static int GetLanguage(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "GetLanguage");
      return NWNXPopInt();
    }

    /// Override sOldResName with sNewResName of nResType for oPlayer.
    /// @warning If sNewResName does not exist on oPlayer&apos;s client it will crash their game.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="nResType">The res type, see nwnx_util.nss for constants.</param>
    /// <param name="sOldResName">The old res name, 16 characters or less.</param>
    /// <param name="sNewResName">The new res name or &quot;&quot; to clear a previous override, 16 characters or less.</param>
    public static void SetResManOverride(uint oPlayer, int nResType, string sOldResName, string sNewResName)
    {
      NWNXPushString(sNewResName);
      NWNXPushString(sOldResName);
      NWNXPushInt(nResType);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetResManOverride");
    }

    /// Set nCustomTokenNumber to sTokenValue for oPlayer only.
    /// @note The basegame SetCustomToken() will override any personal tokens.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="nCustomTokenNumber">The token number.</param>
    /// <param name="sTokenValue">The token text.</param>
    public static void SetCustomToken(uint oPlayer, int nCustomTokenNumber, string sTokenValue)
    {
      NWNXPushString(sTokenValue);
      NWNXPushInt(nCustomTokenNumber);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetCustomToken");
    }

    /// Override the name of creature for player only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oCreature">The creature object.</param>
    /// <param name="sName">The name for the creature for this player, &quot;&quot; to clear the override.</param>
    public static void SetCreatureNameOverride(uint oPlayer, uint oCreature, string sName)
    {
      NWNXPushString(sName);
      NWNXPushObject(oCreature);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetCreatureNameOverride");
    }

    /// Display floaty text above oCreature for oPlayer only.
    /// @note This will also display the floaty text above creatures that are not part of oPlayer&apos;s faction.
    /// <param name="oPlayer">The player to display the text to.</param>
    /// <param name="oCreature">The creature to display the text above.</param>
    /// <param name="sText">The text to display.</param>
    /// <param name="bChatWindow">If TRUE, sText will be displayed in oPlayer&apos;s chat window.</param>
    public static void FloatingTextStringOnCreature(uint oPlayer, uint oCreature, string sText, int bChatWindow = TRUE)
    {
      NWNXPushInt(bChatWindow);
      NWNXPushString(sText);
      NWNXPushObject(oCreature);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "FloatingTextStringOnCreature");
    }

    /// Toggle oPlayer&apos;s PlayerDM status.
    /// @note This function does nothing for actual DMClient DMs or players with a client version &lt; 8193.14
    /// <param name="oPlayer">The player.</param>
    /// <param name="bIsDM">TRUE to toggle dm mode on, FALSE for off.</param>
    public static void ToggleDM(uint oPlayer, int bIsDM)
    {
      NWNXPushInt(bIsDM);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "ToggleDM");
    }

    /// Override the mouse cursor of oObject for oPlayer only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The object.</param>
    /// <param name="nCursor">The cursor, one of MOUSECURSOR_*. -1 to clear the override.</param>
    public static void SetObjectMouseCursorOverride(uint oPlayer, uint oObject, int nCursor)
    {
      NWNXPushInt(nCursor);
      NWNXPushObject(oObject);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetObjectMouseCursorOverride");
    }

    /// Override the hilite color of oObject for oPlayer only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The object.</param>
    /// <param name="nColor">The color in 0xRRGGBB format, -1 to clear the override.</param>
    public static void SetObjectHiliteColorOverride(uint oPlayer, uint oObject, int nColor)
    {
      NWNXPushInt(nColor);
      NWNXPushObject(oObject);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetObjectHiliteColorOverride");
    }

    /// Remove effects with sEffectTag from oPlayer&apos;s TURD
    /// @note This function should be called in the NWNX_ON_CLIENT_DISCONNECT_AFTER event, OnClientLeave is too early for the TURD to exist.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="sEffectTag">The effect tag.</param>
    public static void RemoveEffectFromTURD(uint oPlayer, string sEffectTag)
    {
      NWNXPushString(sEffectTag);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "RemoveEffectFromTURD");
    }

    /// Set the location oPlayer will spawn when logging in to the server.
    /// @note This function is best called in the NWNX_ON_ELC_VALIDATE_CHARACTER_BEFORE event, OnClientEnter will be too late.
    /// <param name="oPlayer">The player object.</param>
    /// <param name="locSpawn">The location.</param>
    public static void SetSpawnLocation(uint oPlayer, System.IntPtr locSpawn)
    {
      NWNXPushLocation(locSpawn);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetSpawnLocation");
    }

    /// Resends palettes to a DM.
    /// <param name="oPlayer">- the DM to send them to.</param>
    public static void SendDMAllCreatorLists(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SendDMAllCreatorLists");
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
      NWNXPushInt(nSilentUpdate);
      NWNXPushInt(journalEntry.nTimeOfDay);
      NWNXPushInt(journalEntry.nCalendarDay);
      NWNXPushInt(journalEntry.nUpdated);
      NWNXPushInt(journalEntry.nQuestDisplayed);
      NWNXPushInt(journalEntry.nQuestCompleted);
      NWNXPushInt(journalEntry.nPriority);
      NWNXPushInt(journalEntry.nState);
      NWNXPushString(journalEntry.sTag);
      NWNXPushString(journalEntry.sText);
      NWNXPushString(journalEntry.sName);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "AddCustomJournalEntry");
      return NWNXPopInt();
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
      JournalEntry entry = default;
      NWNXPushString(questTag);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "GetJournalEntry");
      entry.nUpdated = NWNXPopInt();
      if (entry.nUpdated==-1)
      {
        return entry;
      }
      entry.nQuestDisplayed = NWNXPopInt();
      entry.nQuestCompleted = NWNXPopInt();
      entry.nPriority = NWNXPopInt();
      entry.nState = NWNXPopInt();
      entry.nTimeOfDay = NWNXPopInt();
      entry.nCalendarDay = NWNXPopInt();
      entry.sName = NWNXPopString();
      entry.sText = NWNXPopString();
      entry.sTag = questTag;
      return entry;
    }

    /// Closes any store oPlayer may have open.
    /// <param name="oPlayer">The player object.</param>
    public static void CloseStore(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "CloseStore");
    }

    /// Override nStrRef from the TlkTable with sOverride for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nStrRef">The StrRef.</param>
    /// <param name="sOverride">The new value for nStrRef or &quot;&quot; to remove the override.</param>
    /// <param name="bRestoreGlobal">If TRUE, when removing a personal override it will attempt to restore the global override if it exists.</param>
    /// @note Overrides will not persist through relogging.
    public static void SetTlkOverride(uint oPlayer, int nStrRef, string sOverride, int bRestoreGlobal = TRUE)
    {
      NWNXPushInt(bRestoreGlobal);
      NWNXPushString(sOverride);
      NWNXPushInt(nStrRef);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetTlkOverride");
    }

    /// Make the player reload it&apos;s TlkTable.
    /// <param name="oPlayer">The player.</param>
    public static void ReloadTlk(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "ReloadTlk");
    }

    /// Update wind for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="vDirection">The Wind&apos;s direction.</param>
    /// <param name="fMagnitude">The Wind&apos;s magnitude.</param>
    /// <param name="fYaw">The Wind&apos;s yaw.</param>
    /// <param name="fPitch">The Wind&apos;s pitch.</param>
    public static void UpdateWind(uint oPlayer, System.Numerics.Vector3 vDirection, float fMagnitude, float fYaw, float fPitch)
    {
      NWNXPushFloat(fPitch);
      NWNXPushFloat(fYaw);
      NWNXPushFloat(fMagnitude);
      NWNXPushVector(vDirection);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "UpdateWind");
    }

    /// Update the SkyBox for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nSkyBox">The Skybox ID.</param>
    public static void UpdateSkyBox(uint oPlayer, int nSkyBox)
    {
      NWNXPushInt(nSkyBox);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "UpdateSkyBox");
    }

    /// Update Sun and Moon Fog Color for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nSunFogColor">The int value of Sun Fog color.</param>
    /// <param name="nMoonFogColor">The int value of Moon Fog color.</param>
    public static void UpdateFogColor(uint oPlayer, int nSunFogColor, int nMoonFogColor)
    {
      NWNXPushInt(nMoonFogColor);
      NWNXPushInt(nSunFogColor);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "UpdateFogColor");
    }

    /// Update Sun and Moon Fog Amount for oPlayer only.
    /// <param name="oPlayer">The player.</param>
    /// <param name="nSunFogAmount">The int value of Sun Fog amount (range 0-255).</param>
    /// <param name="nMoonFogAmount">The int value of Moon Fog amount (range 0-255).</param>
    public static void UpdateFogAmount(uint oPlayer, int nSunFogAmount, int nMoonFogAmount)
    {
      NWNXPushInt(nMoonFogAmount);
      NWNXPushInt(nSunFogAmount);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "UpdateFogAmount");
    }

    /// Return&apos;s the currently-possessed game object of a player.
    /// <param name="oPlayer">The player object (e.g. from GetFirst/NextPC()).</param>
    /// <returns>the actual game object of oPlayer, or OBJECT_INVALID on error.</returns>
    public static uint GetGameObject(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "GetGameObject");
      return NWNXPopObject();
    }

    /// Override the ui discovery mask of oObject for oPlayer only
    /// <param name="oPlayer">The player object.</param>
    /// <param name="oObject">The target object.</param>
    /// <param name="nMask">A mask of OBJECT_UI_DISCOVERY_*, or -1 to clear the override</param>
    public static void SetObjectUiDiscoveryMaskOverride(uint oPlayer, uint oObject, int nMask)
    {
      NWNXPushInt(nMask);
      NWNXPushObject(oObject);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SetObjectUiDiscoveryMaskOverride");
    }

    /// Send a party invite from oInviter to oPlayer
    /// <param name="oPlayer">The player to invite</param>
    /// <param name="oInviter">The one inviting the player</param>
    /// <param name="bForceInvite">TRUE: Sends the invite even if the target ignores invites</param>
    /// <param name="bHideDialog">TRUE: Does not show the party invitation dialog</param>
    public static void SendPartyInvite(uint oPlayer, uint oInviter, int bForceInvite = FALSE, int bHideDialog = FALSE)
    {
      NWNXPushInt(bHideDialog);
      NWNXPushInt(bForceInvite);
      NWNXPushObject(oInviter);
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "SendPartyInvite");
    }

    /// Get the TURD for oPlayer
    /// <param name="oPlayer">The offline player to get the TURD from</param>
    /// <returns>the TURD object of oPlayer, or OBJECT_INVALID if no TURD exists</returns>
    public static uint GetTURD(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "GetTURD");
      return NWNXPopObject();
    }

    /// Reloads the color palettes for oPlayer
    /// <param name="oPlayer">The player to reload the color palette for</param>
    public static void ReloadColorPalettes(uint oPlayer)
    {
      NWNXPushObject(oPlayer);
      NWNXCall(NWNX_Player, "ReloadColorPalettes");
    }

    // @}
    public static void INTERNAL_StopGuiTimingBar(uint player, string script = "", int id = -1)
    {
      int activeId = GetLocalInt(player, "NWNX_PLAYER_GUI_TIMING_ACTIVE");
      if (activeId==0)
      return ;
      if (id!=-1&&id!=activeId)
      return ;
      DeleteLocalInt(player, "NWNX_PLAYER_GUI_TIMING_ACTIVE");
      NWNXPushObject(player);
      NWNXCall(NWNX_Player, "StopGuiTimingBar");
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
