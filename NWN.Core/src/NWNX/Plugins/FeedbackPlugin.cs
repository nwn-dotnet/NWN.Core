using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Feedback)]
  public class FeedbackPlugin
  {
    /// @addtogroup feedback Feedback
    /// Allows combatlog, feedback and journal updated messages to be hidden globally or per player.
    /// @note
    /// * If oPC == OBJECT_INVALID it will get/set the global state:
    ///    * TRUE = Message is globally hidden
    ///    * FALSE = Message is not globally hidden
    /// * If oPC is a valid player it will get/set the personal state:
    ///    * TRUE = Message is hidden for oPC
    ///    * FALSE = Message is not hidden for oPC
    ///    * -1 = Personal state is not set for Message
    /// @{
    /// @file nwnx_feedback.nss
    public const string NWNX_Feedback = "NWNX_Feedback";

    ///&lt; @private
    /// @name Combat Log Message Types
    /// @anchor combat_log_msgs
    /// @{
    public const int NWNX_FEEDBACK_COMBATLOG_SIMPLE_ADJECTIVE = 1;

    // Simple_Adjective: &lt;charname&gt; : &lt;adjective described by strref&gt;
    public const int NWNX_FEEDBACK_COMBATLOG_SIMPLE_DAMAGE = 2;

    // Simple_Damage: &lt;charname&gt; damaged : &lt;amount&gt;
    public const int NWNX_FEEDBACK_COMBATLOG_COMPLEX_DAMAGE = 3;

    // Complex_Damage: &lt;charname&gt; damages &lt;charname&gt; : &lt;amount&gt;
    public const int NWNX_FEEDBACK_COMBATLOG_COMPLEX_DEATH = 4;

    // Complex_Death: &lt;charname&gt; killed &lt;charname&gt;
    public const int NWNX_FEEDBACK_COMBATLOG_COMPLEX_ATTACK = 5;

    // Complex_Attack: &lt;charname&gt; attacks &lt;charname&gt; : *hit* / *miss* / *parried* : (&lt;attack roll&gt; + &lt;attack mod&gt; = &lt;modified total&gt;)
    public const int NWNX_FEEDBACK_COMBATLOG_SPECIAL_ATTACK = 6;

    // Special_Attack: &lt;charname&gt; attempts &lt;special attack&gt; on &lt;charname&gt; : *success* / *failure* : (&lt;attack roll&gt; + &lt;attack mod&gt; = &lt;modified roll&gt;)
    public const int NWNX_FEEDBACK_COMBATLOG_SAVING_THROW = 7;

    // Saving_Throw: &lt;charname&gt; : &lt;saving throw type&gt; : *success* / *failure* : (&lt;saving throw roll&gt; + &lt;saving throw modifier&gt; = &lt;modified total&gt;)
    public const int NWNX_FEEDBACK_COMBATLOG_CAST_SPELL = 8;

    // Cast_Spell: &lt;charname&gt; casts &lt;spell name&gt; : Spellcraft check *failure* / *success*
    public const int NWNX_FEEDBACK_COMBATLOG_USE_SKILL = 9;

    // Use_Skill: &lt;charname&gt; : &lt;skill name&gt; : *success* / *failure* : (&lt;skill roll&gt; + &lt;skill modifier&gt; = &lt;modified total&gt; vs &lt;DC&gt; )
    public const int NWNX_FEEDBACK_COMBATLOG_SPELL_RESISTANCE = 10;

    // Spell_Resistance: &lt;charname&gt; : Spell Resistance &lt;SR value&gt; : *success* / *failure*
    public const int NWNX_FEEDBACK_COMBATLOG_FEEDBACK = 11;

    // Reason skill/feat/ability failed, SendMessageToPC() NOTE: This hides ALL feedback messages, to hide individual messages use NWNX_Feedback_SetFeedbackMessageHidden()
    public const int NWNX_FEEDBACK_COMBATLOG_COUNTERSPELL = 12;

    // Counterspel: &lt;charname&gt; casts &lt;spell name&gt; : *spell countered by* : &lt;charname&gt; casting &lt;spell name&gt;
    public const int NWNX_FEEDBACK_COMBATLOG_TOUCHATTACK = 13;

    // TouchAttack: &lt;charname&gt; attempts &lt;melee/ranged touch attack&gt; on &lt;charname&gt; : *hit/miss/critical* : (&lt;attack roll&gt; + &lt;attack mod&gt; = &lt;modified roll&gt;)
    public const int NWNX_FEEDBACK_COMBATLOG_INITIATIVE = 14;

    // Initiative: &lt;charname&gt; : Initiative Roll : &lt;total&gt; : (&lt;roll&gt; + &lt;modifier&gt; = &lt;total&gt;)
    public const int NWNX_FEEDBACK_COMBATLOG_DISPEL_MAGIC = 15;

    // Dispel_Magic: Dispel Magic : &lt;charname&gt; : &lt;spell name&gt;, &lt;spell name&gt;, &lt;spell name&gt;...
    public const int NWNX_FEEDBACK_COMBATLOG_POLYMORPH = 17;

    // Doesn&apos;t go through the function that the plugin hooks, so does nothing.
    public const int NWNX_FEEDBACK_COMBATLOG_FEEDBACKSTRING = 18;

    // Custom feedback for objects requiring a key
    public const int NWNX_FEEDBACK_COMBATLOG_VIBRATE = 19;

    // Controller vibration
    public const int NWNX_FEEDBACK_COMBATLOG_UNLOCKACHIEVEMENT = 20;

    // Unlock Campaign Achievement
    public const int NWNX_FEEDBACK_COMBATLOG_POSTAURSTRING = 22;

    // PostString messages
    public const int NWNX_FEEDBACK_COMBATLOG_ENTERTARGETINGMODE = 23;

    // Enter Targeting Mode
    // @}
    /// @name Feedback Message Types
    /// @anchor feedback_msgs
    /// @{
    public const int NWNX_FEEDBACK_SKILL_CANT_USE = 0;

    /// Skill Feedback Messages
    public const int NWNX_FEEDBACK_SKILL_CANT_USE_TIMER = 1;
    public const int NWNX_FEEDBACK_SKILL_ANIMALEMPATHY_VALID_TARGETS = 2;
    public const int NWNX_FEEDBACK_SKILL_TAUNT_VALID_TARGETS = 3;
    public const int NWNX_FEEDBACK_SKILL_TAUNT_TARGET_IMMUNE = 223;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_STOLE_ITEM = 4;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_STOLE_GOLD = 5;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_ATTEMPTING_TO_STEAL = 46;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_ATTEMPT_DETECTED = 150;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_STOLE_ITEM_TARGET = 47;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_STOLE_GOLD_TARGET = 48;
    public const int NWNX_FEEDBACK_SKILL_PICKPOCKET_TARGET_BROKE = 57;
    public const int NWNX_FEEDBACK_SKILL_HEAL_TARGET_NOT_DISPSND = 55;
    public const int NWNX_FEEDBACK_SKILL_HEAL_VALID_TARGETS = 56;
    public const int NWNX_FEEDBACK_SKILL_STEALTH_IN_COMBAT = 60;

    /// Miscellaneous Targetting Messages
    public const int NWNX_FEEDBACK_TARGET_UNAWARE = 6;
    public const int NWNX_FEEDBACK_ACTION_NOT_POSSIBLE_STATUS = 7;
    public const int NWNX_FEEDBACK_ACTION_NOT_POSSIBLE_PVP = 187;
    public const int NWNX_FEEDBACK_ACTION_CANT_REACH_TARGET = 218;
    public const int NWNX_FEEDBACK_ACTION_NO_LOOT = 247;

    /// Miscellaneous Feedback Messages
    public const int NWNX_FEEDBACK_WEIGHT_TOO_ENCUMBERED_TO_RUN = 8;
    public const int NWNX_FEEDBACK_WEIGHT_TOO_ENCUMBERED_WALK_SLOW = 9;
    public const int NWNX_FEEDBACK_WEIGHT_TOO_ENCUMBERED_CANT_PICKUP = 10;
    public const int NWNX_FEEDBACK_STATS_LEVELUP = 11;
    public const int NWNX_FEEDBACK_INVENTORY_FULL = 12;
    public const int NWNX_FEEDBACK_CONTAINER_FULL = 212;
    public const int NWNX_FEEDBACK_TRAP_TRIGGERED = 82;
    public const int NWNX_FEEDBACK_DAMAGE_HEALED = 151;
    public const int NWNX_FEEDBACK_EXPERIENCE_GAINNED = 182;
    public const int NWNX_FEEDBACK_EXPERIENCE_LOST = 183;
    public const int NWNX_FEEDBACK_JOURNALUPDATED = 184;

    // Doesn&apos;t actually work, use:
    // NWNX_Feedback_{Get/Set}JournalUpdatedMessageHidden()
    public const int NWNX_FEEDBACK_BARTER_CANCELLED = 185;

    /// Mode activation/deactivation Messages
    public const int NWNX_FEEDBACK_DETECT_MODE_ACTIVATED = 83;
    public const int NWNX_FEEDBACK_DETECT_MODE_DEACTIVATED = 84;
    public const int NWNX_FEEDBACK_STEALTH_MODE_ACTIVATED = 85;
    public const int NWNX_FEEDBACK_STEALTH_MODE_DEACTIVATED = 86;
    public const int NWNX_FEEDBACK_PARRY_MODE_ACTIVATED = 87;
    public const int NWNX_FEEDBACK_PARRY_MODE_DEACTIVATED = 88;
    public const int NWNX_FEEDBACK_POWER_ATTACK_MODE_ACTIVATED = 89;
    public const int NWNX_FEEDBACK_POWER_ATTACK_MODE_DEACTIVATED = 90;
    public const int NWNX_FEEDBACK_IMPROVED_POWER_ATTACK_MODE_ACTIVATED = 91;
    public const int NWNX_FEEDBACK_IMPROVED_POWER_ATTACK_MODE_DEACTIVATED = 92;
    public const int NWNX_FEEDBACK_RAPID_SHOT_MODE_ACTIVATED = 166;
    public const int NWNX_FEEDBACK_RAPID_SHOT_MODE_DEACTIVATED = 167;
    public const int NWNX_FEEDBACK_FLURRY_OF_BLOWS_MODE_ACTIVATED = 168;
    public const int NWNX_FEEDBACK_FLURRY_OF_BLOWS_MODE_DEACTIVATED = 169;
    public const int NWNX_FEEDBACK_EXPERTISE_MODE_ACTIVATED = 227;
    public const int NWNX_FEEDBACK_EXPERTISE_MODE_DEACTIVATED = 228;
    public const int NWNX_FEEDBACK_IMPROVED_EXPERTISE_MODE_ACTIVATED = 229;
    public const int NWNX_FEEDBACK_IMPROVED_EXPERTISE_MODE_DEACTIVATED = 230;
    public const int NWNX_FEEDBACK_DEFENSIVE_CAST_MODE_ACTIVATED = 231;
    public const int NWNX_FEEDBACK_DEFENSIVE_CAST_MODE_DEACTIVATED = 232;
    public const int NWNX_FEEDBACK_MODE_CANNOT_USE_WEAPONS = 188;
    public const int NWNX_FEEDBACK_DIRTY_FIGHTING_MODE_ACTIVATED = 237;
    public const int NWNX_FEEDBACK_DIRTY_FIGHTING_MODE_DEACTIVATED = 238;
    public const int NWNX_FEEDBACK_DEFENSIVE_STANCE_MODE_ACTIVATED = 252;
    public const int NWNX_FEEDBACK_DEFENSIVE_STANCE_MODE_DEACTIVATED = 253;

    /// Equipping Feedback Messages
    public const int NWNX_FEEDBACK_EQUIP_SKILL_SPELL_MODIFIERS = 71;
    public const int NWNX_FEEDBACK_EQUIP_UNIDENTIFIED = 76;
    public const int NWNX_FEEDBACK_EQUIP_MONK_ABILITIES = 77;
    public const int NWNX_FEEDBACK_EQUIP_INSUFFICIENT_LEVEL = 98;
    public const int NWNX_FEEDBACK_EQUIP_PROFICIENCIES = 119;
    public const int NWNX_FEEDBACK_EQUIP_WEAPON_TOO_LARGE = 120;
    public const int NWNX_FEEDBACK_EQUIP_WEAPON_TOO_SMALL = 260;
    public const int NWNX_FEEDBACK_EQUIP_ONE_HANDED_WEAPON = 121;
    public const int NWNX_FEEDBACK_EQUIP_TWO_HANDED_WEAPON = 122;
    public const int NWNX_FEEDBACK_EQUIP_WEAPON_SWAPPED_OUT = 123;
    public const int NWNX_FEEDBACK_EQUIP_ONE_CHAIN_WEAPON = 124;
    public const int NWNX_FEEDBACK_EQUIP_NATURAL_AC_NO_STACK = 189;
    public const int NWNX_FEEDBACK_EQUIP_ARMOUR_AC_NO_STACK = 190;
    public const int NWNX_FEEDBACK_EQUIP_SHIELD_AC_NO_STACK = 191;
    public const int NWNX_FEEDBACK_EQUIP_DEFLECTION_AC_NO_STACK = 192;
    public const int NWNX_FEEDBACK_EQUIP_NO_ARMOR_COMBAT = 193;
    public const int NWNX_FEEDBACK_EQUIP_RANGER_ABILITIES = 200;
    public const int NWNX_FEEDBACK_EQUIP_ALIGNMENT = 207;
    public const int NWNX_FEEDBACK_EQUIP_CLASS = 208;
    public const int NWNX_FEEDBACK_EQUIP_RACE = 209;
    public const int NWNX_FEEDBACK_UNEQUIP_NO_ARMOR_COMBAT = 194;

    /// Action Feedback Messages
    public const int NWNX_FEEDBACK_OBJECT_LOCKED = 13;
    public const int NWNX_FEEDBACK_OBJECT_NOT_LOCKED = 14;
    public const int NWNX_FEEDBACK_OBJECT_SPECIAL_KEY = 15;
    public const int NWNX_FEEDBACK_OBJECT_USED_KEY = 16;
    public const int NWNX_FEEDBACK_REST_EXCITED_CANT_REST = 17;
    public const int NWNX_FEEDBACK_REST_BEGINNING_REST = 18;
    public const int NWNX_FEEDBACK_REST_FINISHED_REST = 19;
    public const int NWNX_FEEDBACK_REST_CANCEL_REST = 20;
    public const int NWNX_FEEDBACK_REST_NOT_ALLOWED_IN_AREA = 54;
    public const int NWNX_FEEDBACK_REST_NOT_ALLOWED_BY_POSSESSED_FAMILIAR = 153;
    public const int NWNX_FEEDBACK_REST_NOT_ALLOWED_ENEMIES = 186;
    public const int NWNX_FEEDBACK_REST_CANT_UNDER_THIS_EFFECT = 213;
    public const int NWNX_FEEDBACK_CAST_LOST_TARGET = 21;
    public const int NWNX_FEEDBACK_CAST_CANT_CAST = 22;
    public const int NWNX_FEEDBACK_CAST_CNTRSPELL_TARGET_LOST_TARGET = 52;
    public const int NWNX_FEEDBACK_CAST_ARCANE_SPELL_FAILURE = 61;
    public const int NWNX_FEEDBACK_CAST_CNTRSPELL_TARGET_ARCANE_SPELL_FAILURE = 118;
    public const int NWNX_FEEDBACK_CAST_ENTANGLE_CONCENTRATION_FAILURE = 65;
    public const int NWNX_FEEDBACK_CAST_CNTRSPELL_TARGET_ENTANGLE_CONCENTRATION_FAILURE = 147;
    public const int NWNX_FEEDBACK_CAST_SPELL_INTERRUPTED = 72;
    public const int NWNX_FEEDBACK_CAST_EFFECT_SPELL_FAILURE = 236;
    public const int NWNX_FEEDBACK_CAST_CANT_CAST_WHILE_POLYMORPHED = 107;
    public const int NWNX_FEEDBACK_CAST_USE_HANDS = 210;
    public const int NWNX_FEEDBACK_CAST_USE_MOUTH = 211;
    public const int NWNX_FEEDBACK_CAST_DEFCAST_CONCENTRATION_FAILURE = 233;
    public const int NWNX_FEEDBACK_CAST_DEFCAST_CONCENTRATION_SUCCESS = 240;
    public const int NWNX_FEEDBACK_USEITEM_CANT_USE = 23;
    public const int NWNX_FEEDBACK_CONVERSATION_TOOFAR = 58;
    public const int NWNX_FEEDBACK_CONVERSATION_BUSY = 59;
    public const int NWNX_FEEDBACK_CONVERSATION_IN_COMBAT = 152;
    public const int NWNX_FEEDBACK_CHARACTER_INTRANSIT = 74;
    public const int NWNX_FEEDBACK_CHARACTER_OUTTRANSIT = 75;
    public const int NWNX_FEEDBACK_USEITEM_NOT_EQUIPPED = 244;
    public const int NWNX_FEEDBACK_DROPITEM_CANT_DROP = 245;
    public const int NWNX_FEEDBACK_DROPITEM_CANT_GIVE = 246;
    public const int NWNX_FEEDBACK_CLIENT_SERVER_SPELL_MISMATCH = 259;

    /// Combat feedback messages
    public const int NWNX_FEEDBACK_COMBAT_RUNNING_OUT_OF_AMMO = 24;
    public const int NWNX_FEEDBACK_COMBAT_OUT_OF_AMMO = 25;
    public const int NWNX_FEEDBACK_COMBAT_HENCHMAN_OUT_OF_AMMO = 241;
    public const int NWNX_FEEDBACK_COMBAT_DAMAGE_IMMUNITY = 62;
    public const int NWNX_FEEDBACK_COMBAT_SPELL_IMMUNITY = 68;
    public const int NWNX_FEEDBACK_COMBAT_DAMAGE_RESISTANCE = 63;
    public const int NWNX_FEEDBACK_COMBAT_DAMAGE_RESISTANCE_REMAINING = 66;
    public const int NWNX_FEEDBACK_COMBAT_DAMAGE_REDUCTION = 64;
    public const int NWNX_FEEDBACK_COMBAT_DAMAGE_REDUCTION_REMAINING = 67;
    public const int NWNX_FEEDBACK_COMBAT_SPELL_LEVEL_ABSORPTION = 69;
    public const int NWNX_FEEDBACK_COMBAT_SPELL_LEVEL_ABSORPTION_REMAINING = 70;
    public const int NWNX_FEEDBACK_COMBAT_WEAPON_NOT_EFFECTIVE = 117;
    public const int NWNX_FEEDBACK_COMBAT_EPIC_DODGE_ATTACK_EVADED = 234;
    public const int NWNX_FEEDBACK_COMBAT_MASSIVE_DAMAGE = 235;
    public const int NWNX_FEEDBACK_COMBAT_SAVED_VS_MASSIVE_DAMAGE = 254;
    public const int NWNX_FEEDBACK_COMBAT_SAVED_VS_DEVASTATING_CRITICAL = 257;

    /// Feat Feedback Messages
    public const int NWNX_FEEDBACK_FEAT_SAP_VALID_TARGETS = 26;
    public const int NWNX_FEEDBACK_FEAT_KNOCKDOWN_VALID_TARGETS = 27;
    public const int NWNX_FEEDBACK_FEAT_IMPKNOCKDOWN_VALID_TARGETS = 28;
    public const int NWNX_FEEDBACK_FEAT_CALLED_SHOT_NO_LEGS = 29;
    public const int NWNX_FEEDBACK_FEAT_CALLED_SHOT_NO_ARMS = 30;
    public const int NWNX_FEEDBACK_FEAT_SMITE_GOOD_TARGET_NOT_GOOD = 239;
    public const int NWNX_FEEDBACK_FEAT_SMITE_EVIL_TARGET_NOT_EVIL = 53;
    public const int NWNX_FEEDBACK_FEAT_QUIVERING_PALM_HIGHER_LEVEL = 73;
    public const int NWNX_FEEDBACK_FEAT_KEEN_SENSE_DETECT = 195;
    public const int NWNX_FEEDBACK_FEAT_USE_UNARMED = 198;
    public const int NWNX_FEEDBACK_FEAT_USES = 199;
    public const int NWNX_FEEDBACK_FEAT_USE_WEAPON_OF_CHOICE = 243;

    /// Party Feedback Messages
    public const int NWNX_FEEDBACK_PARTY_NEW_LEADER = 31;
    public const int NWNX_FEEDBACK_PARTY_MEMBER_KICKED = 32;
    public const int NWNX_FEEDBACK_PARTY_KICKED_YOU = 33;
    public const int NWNX_FEEDBACK_PARTY_ALREADY_CONSIDERING = 34;
    public const int NWNX_FEEDBACK_PARTY_ALREADY_INVOLVED = 35;
    public const int NWNX_FEEDBACK_PARTY_SENT_INVITATION = 36;
    public const int NWNX_FEEDBACK_PARTY_RECEIVED_INVITATION = 37;
    public const int NWNX_FEEDBACK_PARTY_JOINED = 38;
    public const int NWNX_FEEDBACK_PARTY_INVITATION_IGNORED = 39;
    public const int NWNX_FEEDBACK_PARTY_YOU_IGNORED_INVITATION = 40;
    public const int NWNX_FEEDBACK_PARTY_INVITATION_REJECTED = 41;
    public const int NWNX_FEEDBACK_PARTY_YOU_REJECTED_INVITATION = 42;
    public const int NWNX_FEEDBACK_PARTY_INVITATION_EXPIRED = 43;
    public const int NWNX_FEEDBACK_PARTY_LEFT_PARTY = 44;
    public const int NWNX_FEEDBACK_PARTY_YOU_LEFT = 45;
    public const int NWNX_FEEDBACK_PARTY_HENCHMAN_LIMIT = 49;
    public const int NWNX_FEEDBACK_PARTY_CANNOT_LEAVE_THE_ONE_PARTY = 196;
    public const int NWNX_FEEDBACK_PARTY_CANNOT_KICK_FROM_THE_ONE_PARTY = 197;
    public const int NWNX_FEEDBACK_PARTY_YOU_INVITED_NON_SINGLETON = 202;
    public const int NWNX_FEEDBACK_PVP_REACTION_DISLIKESYOU = 203;

    /// Item Feedback Messages
    public const int NWNX_FEEDBACK_ITEM_RECEIVED = 50;
    public const int NWNX_FEEDBACK_ITEM_LOST = 51;
    public const int NWNX_FEEDBACK_ITEM_EJECTED = 96;
    public const int NWNX_FEEDBACK_ITEM_USE_UNIDENTIFIED = 97;
    public const int NWNX_FEEDBACK_ITEM_GOLD_GAINED = 148;
    public const int NWNX_FEEDBACK_ITEM_GOLD_LOST = 149;

    /// Spell Scroll Learning
    public const int NWNX_FEEDBACK_LEARN_SCROLL_NOT_SCROLL = 78;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_CLASS = 79;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_LEVEL = 80;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_ABILITY = 81;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_OPPOSITION = 219;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_POSSESS = 220;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_KNOWN = 221;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_CANT_LEARN_DIVINE = 224;
    public const int NWNX_FEEDBACK_LEARN_SCROLL_SUCCESS = 222;

    /// Floaty text feedback
    public const int NWNX_FEEDBACK_FLOATY_TEXT_STRREF = 93;
    public const int NWNX_FEEDBACK_FLOATY_TEXT_STRING = 94;

    /// Store feedback
    public const int NWNX_FEEDBACK_CANNOT_SELL_PLOT_ITEM = 99;
    public const int NWNX_FEEDBACK_CANNOT_SELL_CONTAINER = 100;
    public const int NWNX_FEEDBACK_CANNOT_SELL_ITEM = 101;
    public const int NWNX_FEEDBACK_NOT_ENOUGH_GOLD = 102;
    public const int NWNX_FEEDBACK_TRANSACTION_SUCCEEDED = 103;
    public const int NWNX_FEEDBACK_PRICE_TOO_HIGH = 248;
    public const int NWNX_FEEDBACK_STORE_NOT_ENOUGH_GOLD = 249;
    public const int NWNX_FEEDBACK_CANNOT_SELL_STOLEN_ITEM = 250;
    public const int NWNX_FEEDBACK_CANNOT_SELL_RESTRICTED_ITEM = 251;

    /// Portal control feedback
    public const int NWNX_FEEDBACK_PORTAL_TIMEDOUT = 104;
    public const int NWNX_FEEDBACK_PORTAL_INVALID = 105;

    /// Chat feedback
    public const int NWNX_FEEDBACK_CHAT_TELL_PLAYER_NOT_FOUND = 106;

    /// Alignment Feedback
    public const int NWNX_FEEDBACK_ALIGNMENT_SHIFT = 108;
    public const int NWNX_FEEDBACK_ALIGNMENT_PARTY_SHIFT = 111;
    public const int NWNX_FEEDBACK_ALIGNMENT_CHANGE = 109;
    public const int NWNX_FEEDBACK_ALIGNMENT_RESTRICTED_BY_CLASS_LOST = 110;
    public const int NWNX_FEEDBACK_ALIGNMENT_RESTRICTED_BY_CLASS_GAIN = 115;
    public const int NWNX_FEEDBACK_ALIGNMENT_RESTRICTED_WARNING_LOSS = 116;
    public const int NWNX_FEEDBACK_ALIGNMENT_RESTRICTED_WARNING_GAIN = 112;
    public const int NWNX_FEEDBACK_ALIGNMENT_EPITOME_GAINED = 113;
    public const int NWNX_FEEDBACK_ALIGNMENT_EPITOME_LOST = 114;

    /// Immunity Feedback
    public const int NWNX_FEEDBACK_IMMUNITY_DISEASE = 125;
    public const int NWNX_FEEDBACK_IMMUNITY_CRITICAL_HIT = 126;
    public const int NWNX_FEEDBACK_IMMUNITY_DEATH_MAGIC = 127;
    public const int NWNX_FEEDBACK_IMMUNITY_FEAR = 128;
    public const int NWNX_FEEDBACK_IMMUNITY_KNOCKDOWN = 129;
    public const int NWNX_FEEDBACK_IMMUNITY_PARALYSIS = 130;
    public const int NWNX_FEEDBACK_IMMUNITY_NEGATIVE_LEVEL = 131;
    public const int NWNX_FEEDBACK_IMMUNITY_MIND_SPELLS = 132;
    public const int NWNX_FEEDBACK_IMMUNITY_POISON = 133;
    public const int NWNX_FEEDBACK_IMMUNITY_SNEAK_ATTACK = 134;
    public const int NWNX_FEEDBACK_IMMUNITY_SLEEP = 135;
    public const int NWNX_FEEDBACK_IMMUNITY_DAZE = 136;
    public const int NWNX_FEEDBACK_IMMUNITY_CONFUSION = 137;
    public const int NWNX_FEEDBACK_IMMUNITY_STUN = 138;
    public const int NWNX_FEEDBACK_IMMUNITY_BLINDNESS = 139;
    public const int NWNX_FEEDBACK_IMMUNITY_DEAFNESS = 140;
    public const int NWNX_FEEDBACK_IMMUNITY_CURSE = 141;
    public const int NWNX_FEEDBACK_IMMUNITY_CHARM = 142;
    public const int NWNX_FEEDBACK_IMMUNITY_DOMINATE = 143;
    public const int NWNX_FEEDBACK_IMMUNITY_ENTANGLE = 144;
    public const int NWNX_FEEDBACK_IMMUNITY_SILENCE = 145;
    public const int NWNX_FEEDBACK_IMMUNITY_SLOW = 146;

    /// Associates
    public const int NWNX_FEEDBACK_ASSOCIATE_SUMMONED = 154;
    public const int NWNX_FEEDBACK_ASSOCIATE_UNSUMMONING = 155;
    public const int NWNX_FEEDBACK_ASSOCIATE_UNSUMMONING_BECAUSE_REST = 156;
    public const int NWNX_FEEDBACK_ASSOCIATE_UNSUMMONING_BECAUSE_DIED = 157;
    public const int NWNX_FEEDBACK_ASSOCIATE_DOMINATED = 158;
    public const int NWNX_FEEDBACK_ASSOCIATE_DOMINATION_ENDED = 159;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_RECOVER_TRAP = 170;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_BARTER = 171;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_EQUIP = 172;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_REPOSITORY_MOVE = 173;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_PICK_UP = 174;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_DROP = 175;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_UNEQUIP = 176;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_REST = 177;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_DIALOGUE = 178;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_GIVE_ITEM = 179;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_TAKE_ITEM = 180;
    public const int NWNX_FEEDBACK_ASSOCIATE_POSSESSED_CANNOT_USE_CONTAINER = 181;

    /// Miscellaneous Feedback
    public const int NWNX_FEEDBACK_SCRIPT_ERROR = 160;
    public const int NWNX_FEEDBACK_ACTION_LIST_OVERFLOW = 161;
    public const int NWNX_FEEDBACK_EFFECT_LIST_OVERFLOW = 162;
    public const int NWNX_FEEDBACK_AI_UPDATE_TIME_OVERFLOW = 163;
    public const int NWNX_FEEDBACK_ACTION_LIST_WIPE_OVERFLOW = 164;
    public const int NWNX_FEEDBACK_EFFECT_LIST_WIPE_OVERFLOW = 165;
    public const int NWNX_FEEDBACK_SEND_MESSAGE_TO_PC = 204;
    public const int NWNX_FEEDBACK_SEND_MESSAGE_TO_PC_STRREF = 242;

    /// Misc GUI feedback
    public const int NWNX_FEEDBACK_GUI_ONLY_PARTY_LEADER_MAY_CLICK = 201;
    public const int NWNX_FEEDBACK_PAUSED = 205;
    public const int NWNX_FEEDBACK_UNPAUSED = 206;
    public const int NWNX_FEEDBACK_REST_YOU_MAY_NOT_AT_THIS_TIME = 214;
    public const int NWNX_FEEDBACK_GUI_CHAR_EXPORT_REQUEST_SENT = 215;
    public const int NWNX_FEEDBACK_GUI_CHAR_EXPORTED_SUCCESSFULLY = 216;
    public const int NWNX_FEEDBACK_GUI_ERROR_CHAR_NOT_EXPORTED = 217;
    public const int NWNX_FEEDBACK_CAMERA_BG = 255;
    public const int NWNX_FEEDBACK_CAMERA_EQ = 256;
    public const int NWNX_FEEDBACK_CAMERA_CHASECAM = 258;
    public const int NWNX_FEEDBACK_SAVING = 225;
    public const int NWNX_FEEDBACK_SAVE_COMPLETE = 226;

    // @}
    /// Gets if feedback message is hidden.
    /// <param name="nMessage">The message identifier from @ref feedback_msgs &quot;Feedback Messages&quot;.</param>
    /// <param name="oPC">The PC or OBJECT_INVALID for a global setting.</param>
    /// <returns>TRUE if the message is hidden.</returns>
    public static int GetFeedbackMessageHidden(int nMessage, uint oPC = OBJECT_INVALID)
    {
      NWNXPushInt(nMessage);
      NWNXPushInt(0);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Feedback, "GetMessageHidden");
      return NWNXPopInt();
    }

    /// Sets if feedback message is hidden.
    /// <param name="nMessage">The message identifier.</param>
    /// <param name="isHidden">TRUE/FALSE</param>
    /// <param name="oPC">The PC or OBJECT_INVALID for a global setting.</param>
    /// @note Personal state overrides the global state which means if a global state is set
    /// to TRUE but the personal state is set to FALSE, the message will be shown to the PC.
    public static void SetFeedbackMessageHidden(int nMessage, int isHidden, uint oPC = OBJECT_INVALID)
    {
      NWNXPushInt(isHidden);
      NWNXPushInt(nMessage);
      NWNXPushInt(0);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Feedback, "SetMessageHidden");
    }

    /// Gets if combat log message is hidden.
    /// <param name="nMessage">The message identifier from @ref combat_log_msgs &quot;Combat Log Messages&quot;.</param>
    /// <param name="oPC">The PC or OBJECT_INVALID for a global setting.</param>
    /// <returns>TRUE if the message is hidden.</returns>
    public static int GetCombatLogMessageHidden(int nMessage, uint oPC = OBJECT_INVALID)
    {
      NWNXPushInt(nMessage);
      NWNXPushInt(1);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Feedback, "GetMessageHidden");
      return NWNXPopInt();
    }

    /// Sets if combat log message is hidden.
    /// <param name="nMessage">The message identifier.</param>
    /// <param name="isHidden">TRUE/FALSE</param>
    /// <param name="oPC">The PC or OBJECT_INVALID for a global setting.</param>
    /// @note Personal state overrides the global state which means if a global state is set
    /// to TRUE but the personal state is set to FALSE, the message will be shown to the PC.
    public static void SetCombatLogMessageHidden(int nMessage, int isHidden, uint oPC = OBJECT_INVALID)
    {
      NWNXPushInt(isHidden);
      NWNXPushInt(nMessage);
      NWNXPushInt(1);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Feedback, "SetMessageHidden");
    }

    /// Gets if the journal update message is hidden.
    /// <param name="oPC">The PC or OBJECT_INVALID for a global setting.</param>
    /// <returns>TRUE if the message is hidden.</returns>
    public static int GetJournalUpdatedMessageHidden(uint oPC = OBJECT_INVALID)
    {
      NWNXPushInt(0);
      NWNXPushInt(2);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Feedback, "GetMessageHidden");
      return NWNXPopInt();
    }

    /// Sets if journal update message is hidden.
    /// <param name="isHidden">TRUE/FALSE</param>
    /// <param name="oPC">The PC or OBJECT_INVALID for a global setting.</param>
    /// @note Personal state overrides the global state which means if a global state is set
    /// to TRUE but the personal state is set to FALSE, the message will be shown to the PC.
    public static void SetJournalUpdatedMessageHidden(int isHidden, uint oPC = OBJECT_INVALID)
    {
      NWNXPushInt(isHidden);
      NWNXPushInt(0);
      NWNXPushInt(2);
      NWNXPushObject(oPC);
      NWNXCall(NWNX_Feedback, "SetMessageHidden");
    }

    /// Set whether to use a blacklist or whitelist mode for feedback messages
    /// <param name="bWhitelist">TRUE for all messages to be hidden by default, default FALSE.</param>
    public static void SetFeedbackMessageMode(int bWhitelist)
    {
      NWNXPushInt(bWhitelist);
      NWNXPushInt(0);
      NWNXCall(NWNX_Feedback, "SetFeedbackMode");
    }

    /// Set whether to use a blacklist or whitelist mode for combat log messages
    /// <param name="bWhitelist">TRUE for all messages to be hidden by default, default FALSE.</param>
    /// @note If using Whitelist, be sure to whitelist NWNX_FEEDBACK_COMBATLOG_FEEDBACK for feedback messages to work.
    public static void SetCombatLogMessageMode(int bWhitelist)
    {
      NWNXPushInt(bWhitelist);
      NWNXPushInt(1);
      NWNXCall(NWNX_Feedback, "SetFeedbackMode");
    }

    // @}
  }
}
