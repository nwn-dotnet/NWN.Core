namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Player)]
    public class PlayerPlugin
    {
        public const string NWNX_Player = "NWNX_Player";

        ///< @private
        /// A quickbar slot.
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

        /// @}
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

        /// @}
        /// Force display placeable examine window for player
        /// @note If used on a placeable in a different area than the player, the portait will not be shown.
        /// <param name="player">The player object.</param>
        /// <param name="placeable">The placeable object.</param>
        public static void ForcePlaceableExamineWindow(uint player, uint placeable)
        {
            VM.NWNX.SetFunction(NWNX_Player, "ForcePlaceableExamineWindow");
            VM.NWNX.StackPush(placeable);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Force opens the target object's inventory for the player.
        /// @note
        /// * If the placeable is in a different area than the player, the portrait will not be shown
        /// * The placeable's open/close animations will be played
        /// * Clicking the 'close' button will cause the player to walk to the placeable If the placeable is in a
        /// different area, the player will just walk to the edge of the current area and stop.
        /// This action can be cancelled manually.
        /// * Walking will close the placeable automatically.
        /// <param name="player">The player object.</param>
        /// <param name="placeable">The placeable object.</param>
        public static void ForcePlaceableInventoryWindow(uint player, uint placeable)
        {
            VM.NWNX.SetFunction(NWNX_Player, "ForcePlaceableInventoryWindow");
            VM.NWNX.StackPush(placeable);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Starts displaying a timing bar.
        /// <param name="player">The player object.</param>
        /// <param name="seconds">The length of time the timing bar will complete.</param>
        /// <param name="script">The script to run at the bar's completion.</param>
        /// <param name="type">The @ref timing_bar_types "Timing Bar Type"</param>
        /// @remark Only one timing bar can be ran at the same time.
        public static void StartGuiTimingBar(uint player, float seconds, string script = "", int type = NWNX_PLAYER_TIMING_BAR_CUSTOM)
        {
            VM.NWNX.SetFunction(NWNX_Player, "StartGuiTimingBar");
            VM.NWNX.StackPush(type);
            VM.NWNX.StackPush(script);
            VM.NWNX.StackPush(seconds);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Stop displaying a timing bar.
        /// <param name="player">The player object.</param>
        /// <param name="script">The script to run when stopped.</param>
        public static void StopGuiTimingBar(uint player, string script = "")
        {
            VM.NWNX.SetFunction(NWNX_Player, "StopGuiTimingBar");
            VM.NWNX.StackPush(script);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Sets whether the player should always walk when given movement commands.
        /// <param name="player">The player object.</param>
        /// <param name="bWalk">TRUE to set the player to always walk.</param>
        /// @remark Clicking on the ground or using WASD will trigger walking instead of running.
        public static void SetAlwaysWalk(uint player, int bWalk = NWScript.TRUE)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetAlwaysWalk");
            VM.NWNX.StackPush(bWalk);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Gets the player's quickbar slot info
        /// <param name="player">The player object.</param>
        /// <param name="slot">Slot ID 0-35</param>
        /// <returns>An NWNX_Player_QuickBarSlot struct.</returns>
        public static QuickBarSlot GetQuickBarSlot(uint player, int slot)
        {
            VM.NWNX.SetFunction(NWNX_Player, "GetQuickBarSlot");
            VM.NWNX.StackPush(slot);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
            QuickBarSlot retVal;
            retVal.oAssociate = VM.NWNX.StackPopObject();
            retVal.nAssociateType = VM.NWNX.StackPopInt();
            retVal.nDomainLevel = VM.NWNX.StackPopInt();
            retVal.nMetaType = VM.NWNX.StackPopInt();
            retVal.nINTParam1 = VM.NWNX.StackPopInt();
            retVal.sToolTip = VM.NWNX.StackPopString();
            retVal.sCommandLine = VM.NWNX.StackPopString();
            retVal.sCommandLabel = VM.NWNX.StackPopString();
            retVal.sResRef = VM.NWNX.StackPopString();
            retVal.nMultiClass = VM.NWNX.StackPopInt();
            retVal.nObjectType = VM.NWNX.StackPopInt();
            retVal.oSecondaryItem = VM.NWNX.StackPopObject();
            retVal.oItem = VM.NWNX.StackPopObject();
            return retVal;
        }

        /// Sets the player's quickbar slot info
        /// <param name="player">The player object.</param>
        /// <param name="slot">Slot ID 0-35</param>
        /// <param name="qbs">An NWNX_Player_QuickBarSlot struct.</param>
        public static void SetQuickBarSlot(uint player, int slot, QuickBarSlot qbs)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetQuickBarSlot");
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

        /// Get the name of the .bic file associated with the player's character.
        /// <param name="player">The player object.</param>
        /// <returns>The filename for this player's bic. (Not including the ".bic")</returns>
        public static string GetBicFileName(uint player)
        {
            VM.NWNX.SetFunction(NWNX_Player, "GetBicFileName");
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
            VM.NWNX.SetFunction(NWNX_Player, "ShowVisualEffect");
            VM.NWNX.StackPush(position);
            VM.NWNX.StackPush(effectId);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Changes the daytime music track for the given player only
        /// <param name="player">The player object.</param>
        /// <param name="track">The track id to play.</param>
        public static void MusicBackgroundChangeDay(uint player, int track)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBackgroundChangeDay");
            VM.NWNX.StackPush(track);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Changes the nighttime music track for the given player only
        /// <param name="player">The player object.</param>
        /// <param name="track">The track id to play.</param>
        public static void MusicBackgroundChangeNight(uint player, int track)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBackgroundChangeNight");
            VM.NWNX.StackPush(track);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Starts the background music for the given player only
        /// <param name="player">The player object.</param>
        public static void MusicBackgroundStart(uint player)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBackgroundStart");
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Stops the background music for the given player only
        /// <param name="player">The player object.</param>
        public static void MusicBackgroundStop(uint player)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBackgroundStop");
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Changes the battle music track for the given player only
        /// <param name="player">The player object.</param>
        /// <param name="track">The track id to play.</param>
        public static void MusicBattleChange(uint player, int track)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBattleChange");
            VM.NWNX.StackPush(track);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Starts the battle music for the given player only
        /// <param name="player">The player object.</param>
        public static void MusicBattleStart(uint player)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBattleStart");
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Stops the battle music for the given player only
        /// <param name="player">The player object.</param>
        public static void MusicBattleStop(uint player)
        {
            VM.NWNX.SetFunction(NWNX_Player, "MusicBattleStop");
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Play a sound at the location of target for the given player only
        /// <param name="player">The player object.</param>
        /// <param name="sound">The sound resref.</param>
        /// <param name="target">The target object for the sound to originate. If target OBJECT_INVALID the sound</param>
        /// will play at the location of the player.
        public static void PlaySound(uint player, string sound, uint target = NWScript.OBJECT_INVALID)
        {
            VM.NWNX.SetFunction(NWNX_Player, "PlaySound");
            VM.NWNX.StackPush(target);
            VM.NWNX.StackPush(sound);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Toggle a placeable's usable flag for the given player only
        /// <param name="player">The player object.</param>
        /// <param name="placeable">The placeable object.</param>
        /// <param name="usable">TRUE for usable.</param>
        public static void SetPlaceableUsable(uint player, uint placeable, int usable)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetPlaceableUsable");
            VM.NWNX.StackPush(usable);
            VM.NWNX.StackPush(placeable);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Override player's rest duration
        /// <param name="player">The player object.</param>
        /// <param name="duration">The duration of rest in milliseconds, 1000 = 1 second. Minimum duration of 10ms. -1 clears the override.</param>
        public static void SetRestDuration(uint player, int duration)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetRestDuration");
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
            VM.NWNX.SetFunction(NWNX_Player, "ApplyInstantVisualEffectToObject");
            VM.NWNX.StackPush(visualeffect);
            VM.NWNX.StackPush(target);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Refreshes the players character sheet
        /// <param name="player">The player object.</param>
        /// @note You may need to use DelayCommand if you're manipulating values
        /// through nwnx and forcing a UI refresh, 0.5s seemed to be fine
        public static void UpdateCharacterSheet(uint player)
        {
            VM.NWNX.SetFunction(NWNX_Player, "UpdateCharacterSheet");
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Allows player to open target's inventory
        /// <param name="player">The player object.</param>
        /// <param name="target">The target object, must be a creature or another player.</param>
        /// <param name="open">TRUE to open.</param>
        /// @remark Only works if player and target are in the same area.
        public static void OpenInventory(uint player, uint target, int open = NWScript.TRUE)
        {
            VM.NWNX.SetFunction(NWNX_Player, "OpenInventory");
            VM.NWNX.StackPush(open);
            VM.NWNX.StackPush(target);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Get player's area exploration state
        /// <param name="player">The player object.</param>
        /// <param name="area">The area object.</param>
        /// <returns>A string representation of the tiles explored for that area.</returns>
        public static string GetAreaExplorationState(uint player, uint area)
        {
            VM.NWNX.SetFunction(NWNX_Player, "GetAreaExplorationState");
            VM.NWNX.StackPush(area);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Set player's area exploration state.
        /// <param name="player">The player object.</param>
        /// <param name="area">The area object.</param>
        /// <param name="str">An encoded string obtained with NWNX_Player_GetAreaExplorationState()</param>
        public static void SetAreaExplorationState(uint player, uint area, string str)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetAreaExplorationState");
            VM.NWNX.StackPush(str);
            VM.NWNX.StackPush(area);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Override player's rest animation.
        /// <param name="oPlayer">The player object.</param>
        /// <param name="nAnimation">The NWNX animation id. This does not take ANIMATION_LOOPING_* or</param>
        /// ANIMATION_FIREFORGET_* constants. Instead use NWNX_Consts_TranslateNWScriptAnimation() to get
        /// the NWNX equivalent. -1 to clear the override.
        public static void SetRestAnimation(uint oPlayer, int nAnimation)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetRestAnimation");
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
            VM.NWNX.SetFunction(NWNX_Player, "SetObjectVisualTransformOverride");
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
        /// @note Only really works with looping effects: VFX_DUR_*. Other types *kind* of work, they'll play when
        /// reentering the area and the object is in view or when they come back in view range.
        public static void ApplyLoopingVisualEffectToObject(uint player, uint target, int visualeffect)
        {
            VM.NWNX.SetFunction(NWNX_Player, "ApplyLoopingVisualEffectToObject");
            VM.NWNX.StackPush(visualeffect);
            VM.NWNX.StackPush(target);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
        }

        /// Override the name of placeable for player only
        /// <param name="player">The player object.</param>
        /// <param name="placeable">The placeable object.</param>
        /// <param name="name">The name for the placeable for this player, "" to clear the override.</param>
        public static void SetPlaceableNameOverride(uint player, uint placeable, string name)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetPlaceableNameOverride");
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
            VM.NWNX.SetFunction(NWNX_Player, "GetQuestCompleted");
            VM.NWNX.StackPush(sQuestName);
            VM.NWNX.StackPush(player);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Place waypoints on module load representing where a PC should start
        ///
        /// This will require storing the PC's cd key or community name (depending on how you store in your vault)
        /// and bic_filename along with routinely updating their location in some persistent method like OnRest,
        /// OnAreaEnter and OnClentExit.
        ///
        /// <param name="sCDKeyOrCommunityName">The Public CD Key or Community Name of the player, this will depend on your vault type.</param>
        /// <param name="sBicFileName">The filename for the character. Retrieved with NWNX_Player_GetBicFileName().</param>
        /// <param name="oWP">The waypoint object to place where the PC should start.</param>
        /// <param name="bFirstConnectOnly">Set to FALSE if you would like the PC to go to this location every time they login instead</param>
        /// of just every server restart.
        public static void SetPersistentLocation(string sCDKeyOrCommunityName, string sBicFileName, uint oWP, int bFirstConnectOnly = NWScript.TRUE)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetPersistentLocation");
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
            VM.NWNX.SetFunction(NWNX_Player, "UpdateItemName");
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
        public static int PossessCreature(uint oPossessor, uint oPossessed, int bMindImmune = NWScript.TRUE, int bCreateDefaultQB = NWScript.FALSE)
        {
            VM.NWNX.SetFunction(NWNX_Player, "PossessCreature");
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
            VM.NWNX.SetFunction(NWNX_Player, "GetPlatformId");
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
            VM.NWNX.SetFunction(NWNX_Player, "GetLanguage");
            VM.NWNX.StackPush(oPlayer);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Override sOldResName with sNewResName of nResType for oPlayer.
        /// @warning If sNewResName does not exist on oPlayer's client it will crash their game.
        /// <param name="oPlayer">The player object.</param>
        /// <param name="nResType">The res type, see nwnx_util.nss for constants.</param>
        /// <param name="sOldResName">The old res name, 16 characters or less.</param>
        /// <param name="sNewResName">The new res name or "" to clear a previous override, 16 characters or less.</param>
        public static void SetResManOverride(uint oPlayer, int nResType, string sOldResName, string sNewResName)
        {
            VM.NWNX.SetFunction(NWNX_Player, "SetResManOverride");
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
            VM.NWNX.SetFunction(NWNX_Player, "SetCustomToken");
            VM.NWNX.StackPush(sTokenValue);
            VM.NWNX.StackPush(nCustomTokenNumber);
            VM.NWNX.StackPush(oPlayer);
            VM.NWNX.Call();
        }

        /// @}
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
}