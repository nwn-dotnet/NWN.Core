namespace NWN.Core
{
  public static partial class NWScript
  {
    public const uint OBJECT_INVALID = 0x7F000000;
    public static uint OBJECT_SELF => NWNCore.FunctionHandler!.ObjectSelf;

    public const int ENGINE_NUM_STRUCTURES = 8;
    public const int ENGINE_STRUCTURE_EFFECT = 0;
    public const int ENGINE_STRUCTURE_EVENT = 1;
    public const int ENGINE_STRUCTURE_LOCATION = 2;
    public const int ENGINE_STRUCTURE_TALENT = 3;
    public const int ENGINE_STRUCTURE_ITEMPROPERTY = 4;
    public const int ENGINE_STRUCTURE_SQLQUERY = 5;
    public const int ENGINE_STRUCTURE_CASSOWARY = 6;
    public const int ENGINE_STRUCTURE_JSON = 7;
    ///  Constants
    public const int NUM_INVENTORY_SLOTS = 18;
    public const int TRUE = 1;
    public const int FALSE = 0;
    public const float DIRECTION_EAST = 0.0f;
    public const float DIRECTION_NORTH = 90.0f;
    public const float DIRECTION_WEST = 180.0f;
    public const float DIRECTION_SOUTH = 270.0f;
    public const float PI = 3.141592f;
    public const int ATTITUDE_NEUTRAL = 0;
    public const int ATTITUDE_AGGRESSIVE = 1;
    public const int ATTITUDE_DEFENSIVE = 2;
    public const int ATTITUDE_SPECIAL = 3;
    public const int TALKVOLUME_TALK = 0;
    public const int TALKVOLUME_WHISPER = 1;
    public const int TALKVOLUME_SHOUT = 2;
    public const int TALKVOLUME_SILENT_TALK = 3;
    public const int TALKVOLUME_SILENT_SHOUT = 4;
    public const int TALKVOLUME_PARTY = 5;
    public const int TALKVOLUME_TELL = 6;
    public const int INVENTORY_SLOT_HEAD = 0;
    public const int INVENTORY_SLOT_CHEST = 1;
    public const int INVENTORY_SLOT_BOOTS = 2;
    public const int INVENTORY_SLOT_ARMS = 3;
    public const int INVENTORY_SLOT_RIGHTHAND = 4;
    public const int INVENTORY_SLOT_LEFTHAND = 5;
    public const int INVENTORY_SLOT_CLOAK = 6;
    public const int INVENTORY_SLOT_LEFTRING = 7;
    public const int INVENTORY_SLOT_RIGHTRING = 8;
    public const int INVENTORY_SLOT_NECK = 9;
    public const int INVENTORY_SLOT_BELT = 10;
    public const int INVENTORY_SLOT_ARROWS = 11;
    public const int INVENTORY_SLOT_BULLETS = 12;
    public const int INVENTORY_SLOT_BOLTS = 13;
    public const int INVENTORY_SLOT_CWEAPON_L = 14;
    public const int INVENTORY_SLOT_CWEAPON_R = 15;
    public const int INVENTORY_SLOT_CWEAPON_B = 16;
    public const int INVENTORY_SLOT_CARMOUR = 17;

    /// Effect type constants
    public const int DURATION_TYPE_INSTANT = 0;
    public const int DURATION_TYPE_TEMPORARY = 1;
    public const int DURATION_TYPE_PERMANENT = 2;
    public const int SUBTYPE_MAGICAL = 8;
    public const int SUBTYPE_SUPERNATURAL = 16;
    public const int SUBTYPE_EXTRAORDINARY = 24;
    public const int ABILITY_STRENGTH = 0;

    ///  should be the same as in nwseffectlist.cpp
    public const int ABILITY_DEXTERITY = 1;
    public const int ABILITY_CONSTITUTION = 2;
    public const int ABILITY_INTELLIGENCE = 3;
    public const int ABILITY_WISDOM = 4;
    public const int ABILITY_CHARISMA = 5;
    public const int SHAPE_SPELLCYLINDER = 0;
    public const int SHAPE_CONE = 1;
    public const int SHAPE_CUBE = 2;
    public const int SHAPE_SPELLCONE = 3;
    public const int SHAPE_SPHERE = 4;
    public const int METAMAGIC_NONE = 0;
    public const int METAMAGIC_EMPOWER = 1;
    public const int METAMAGIC_EXTEND = 2;
    public const int METAMAGIC_MAXIMIZE = 4;
    public const int METAMAGIC_QUICKEN = 8;
    public const int METAMAGIC_SILENT = 16;
    public const int METAMAGIC_STILL = 32;
    public const int METAMAGIC_ANY = 255;
    public const int OBJECT_TYPE_CREATURE = 1;
    public const int OBJECT_TYPE_ITEM = 2;
    public const int OBJECT_TYPE_TRIGGER = 4;
    public const int OBJECT_TYPE_DOOR = 8;
    public const int OBJECT_TYPE_AREA_OF_EFFECT = 16;
    public const int OBJECT_TYPE_WAYPOINT = 32;
    public const int OBJECT_TYPE_PLACEABLE = 64;
    public const int OBJECT_TYPE_STORE = 128;
    public const int OBJECT_TYPE_ENCOUNTER = 256;
    public const int OBJECT_TYPE_TILE = 512;
    public const int OBJECT_TYPE_ALL = 32767;
    public const int OBJECT_TYPE_INVALID = 32767;
    public const int GENDER_MALE = 0;
    public const int GENDER_FEMALE = 1;
    public const int GENDER_BOTH = 2;
    public const int GENDER_OTHER = 3;
    public const int GENDER_NONE = 4;
    public const int DAMAGE_TYPE_BLUDGEONING = 1;
    public const int DAMAGE_TYPE_PIERCING = 2;
    public const int DAMAGE_TYPE_SLASHING = 4;
    public const int DAMAGE_TYPE_MAGICAL = 8;
    public const int DAMAGE_TYPE_ACID = 16;
    public const int DAMAGE_TYPE_COLD = 32;
    public const int DAMAGE_TYPE_DIVINE = 64;
    public const int DAMAGE_TYPE_ELECTRICAL = 128;
    public const int DAMAGE_TYPE_FIRE = 256;
    public const int DAMAGE_TYPE_NEGATIVE = 512;
    public const int DAMAGE_TYPE_POSITIVE = 1024;
    public const int DAMAGE_TYPE_SONIC = 2048;

    ///  The base weapon damage is the base damage delivered by the weapon before<br/>
    ///  any additional types of damage (e.g. fire) have been added.
    public const int DAMAGE_TYPE_BASE_WEAPON = 4096;

    ///  Special versus flag just for AC effects
    public const int AC_VS_DAMAGE_TYPE_ALL = 4103;
    public const int DAMAGE_BONUS_1 = 1;
    public const int DAMAGE_BONUS_2 = 2;
    public const int DAMAGE_BONUS_3 = 3;
    public const int DAMAGE_BONUS_4 = 4;
    public const int DAMAGE_BONUS_5 = 5;
    public const int DAMAGE_BONUS_1d4 = 6;
    public const int DAMAGE_BONUS_1d6 = 7;
    public const int DAMAGE_BONUS_1d8 = 8;
    public const int DAMAGE_BONUS_1d10 = 9;
    public const int DAMAGE_BONUS_2d6 = 10;
    public const int DAMAGE_BONUS_2d8 = 11;
    public const int DAMAGE_BONUS_2d4 = 12;
    public const int DAMAGE_BONUS_2d10 = 13;
    public const int DAMAGE_BONUS_1d12 = 14;
    public const int DAMAGE_BONUS_2d12 = 15;
    public const int DAMAGE_BONUS_6 = 16;
    public const int DAMAGE_BONUS_7 = 17;
    public const int DAMAGE_BONUS_8 = 18;
    public const int DAMAGE_BONUS_9 = 19;
    public const int DAMAGE_BONUS_10 = 20;
    public const int DAMAGE_BONUS_11 = 21;
    public const int DAMAGE_BONUS_12 = 22;
    public const int DAMAGE_BONUS_13 = 23;
    public const int DAMAGE_BONUS_14 = 24;
    public const int DAMAGE_BONUS_15 = 25;
    public const int DAMAGE_BONUS_16 = 26;
    public const int DAMAGE_BONUS_17 = 27;
    public const int DAMAGE_BONUS_18 = 28;
    public const int DAMAGE_BONUS_19 = 29;
    public const int DAMAGE_BONUS_20 = 30;
    public const int DAMAGE_POWER_NORMAL = 0;
    public const int DAMAGE_POWER_PLUS_ONE = 1;
    public const int DAMAGE_POWER_PLUS_TWO = 2;
    public const int DAMAGE_POWER_PLUS_THREE = 3;
    public const int DAMAGE_POWER_PLUS_FOUR = 4;
    public const int DAMAGE_POWER_PLUS_FIVE = 5;
    public const int DAMAGE_POWER_ENERGY = 6;
    public const int DAMAGE_POWER_PLUS_SIX = 7;
    public const int DAMAGE_POWER_PLUS_SEVEN = 8;
    public const int DAMAGE_POWER_PLUS_EIGHT = 9;
    public const int DAMAGE_POWER_PLUS_NINE = 10;
    public const int DAMAGE_POWER_PLUS_TEN = 11;
    public const int DAMAGE_POWER_PLUS_ELEVEN = 12;
    public const int DAMAGE_POWER_PLUS_TWELVE = 13;
    public const int DAMAGE_POWER_PLUS_THIRTEEN = 14;
    public const int DAMAGE_POWER_PLUS_FOURTEEN = 15;
    public const int DAMAGE_POWER_PLUS_FIFTEEN = 16;
    public const int DAMAGE_POWER_PLUS_SIXTEEN = 17;
    public const int DAMAGE_POWER_PLUS_SEVENTEEN = 18;
    public const int DAMAGE_POWER_PLUS_EIGHTEEN = 19;
    public const int DAMAGE_POWER_PLUS_NINTEEN = 20;
    public const int DAMAGE_POWER_PLUS_TWENTY = 21;
    public const int ATTACK_BONUS_MISC = 0;
    public const int ATTACK_BONUS_ONHAND = 1;
    public const int ATTACK_BONUS_OFFHAND = 2;
    public const int AC_DODGE_BONUS = 0;
    public const int AC_NATURAL_BONUS = 1;
    public const int AC_ARMOUR_ENCHANTMENT_BONUS = 2;
    public const int AC_SHIELD_ENCHANTMENT_BONUS = 3;
    public const int AC_DEFLECTION_BONUS = 4;
    public const int MISS_CHANCE_TYPE_NORMAL = 0;
    public const int MISS_CHANCE_TYPE_VS_RANGED = 1;
    public const int MISS_CHANCE_TYPE_VS_MELEE = 2;
    public const int DOOR_ACTION_OPEN = 0;
    public const int DOOR_ACTION_UNLOCK = 1;
    public const int DOOR_ACTION_BASH = 2;
    public const int DOOR_ACTION_IGNORE = 3;
    public const int DOOR_ACTION_KNOCK = 4;
    public const int PLACEABLE_ACTION_USE = 0;
    public const int PLACEABLE_ACTION_UNLOCK = 1;
    public const int PLACEABLE_ACTION_BASH = 2;
    public const int PLACEABLE_ACTION_KNOCK = 4;
    public const int RACIAL_TYPE_DWARF = 0;
    public const int RACIAL_TYPE_ELF = 1;
    public const int RACIAL_TYPE_GNOME = 2;
    public const int RACIAL_TYPE_HALFLING = 3;
    public const int RACIAL_TYPE_HALFELF = 4;
    public const int RACIAL_TYPE_HALFORC = 5;
    public const int RACIAL_TYPE_HUMAN = 6;
    public const int RACIAL_TYPE_ABERRATION = 7;
    public const int RACIAL_TYPE_ANIMAL = 8;
    public const int RACIAL_TYPE_BEAST = 9;
    public const int RACIAL_TYPE_CONSTRUCT = 10;
    public const int RACIAL_TYPE_DRAGON = 11;
    public const int RACIAL_TYPE_HUMANOID_GOBLINOID = 12;
    public const int RACIAL_TYPE_HUMANOID_MONSTROUS = 13;
    public const int RACIAL_TYPE_HUMANOID_ORC = 14;
    public const int RACIAL_TYPE_HUMANOID_REPTILIAN = 15;
    public const int RACIAL_TYPE_ELEMENTAL = 16;
    public const int RACIAL_TYPE_FEY = 17;
    public const int RACIAL_TYPE_GIANT = 18;
    public const int RACIAL_TYPE_MAGICAL_BEAST = 19;
    public const int RACIAL_TYPE_OUTSIDER = 20;
    public const int RACIAL_TYPE_SHAPECHANGER = 23;
    public const int RACIAL_TYPE_UNDEAD = 24;
    public const int RACIAL_TYPE_VERMIN = 25;
    public const int RACIAL_TYPE_ALL = 28;
    public const int RACIAL_TYPE_INVALID = 28;
    public const int RACIAL_TYPE_OOZE = 29;
    public const int ALIGNMENT_ALL = 0;
    public const int ALIGNMENT_NEUTRAL = 1;
    public const int ALIGNMENT_LAWFUL = 2;
    public const int ALIGNMENT_CHAOTIC = 3;
    public const int ALIGNMENT_GOOD = 4;
    public const int ALIGNMENT_EVIL = 5;
    public const int SAVING_THROW_ALL = 0;
    public const int SAVING_THROW_FORT = 1;
    public const int SAVING_THROW_REFLEX = 2;
    public const int SAVING_THROW_WILL = 3;
    public const int SAVING_THROW_TYPE_ALL = 0;
    public const int SAVING_THROW_TYPE_NONE = 0;
    public const int SAVING_THROW_TYPE_MIND_SPELLS = 1;
    public const int SAVING_THROW_TYPE_POISON = 2;
    public const int SAVING_THROW_TYPE_DISEASE = 3;
    public const int SAVING_THROW_TYPE_FEAR = 4;
    public const int SAVING_THROW_TYPE_SONIC = 5;
    public const int SAVING_THROW_TYPE_ACID = 6;
    public const int SAVING_THROW_TYPE_FIRE = 7;
    public const int SAVING_THROW_TYPE_ELECTRICITY = 8;
    public const int SAVING_THROW_TYPE_POSITIVE = 9;
    public const int SAVING_THROW_TYPE_NEGATIVE = 10;
    public const int SAVING_THROW_TYPE_DEATH = 11;
    public const int SAVING_THROW_TYPE_COLD = 12;
    public const int SAVING_THROW_TYPE_DIVINE = 13;
    public const int SAVING_THROW_TYPE_TRAP = 14;
    public const int SAVING_THROW_TYPE_SPELL = 15;
    public const int SAVING_THROW_TYPE_GOOD = 16;
    public const int SAVING_THROW_TYPE_EVIL = 17;
    public const int SAVING_THROW_TYPE_LAW = 18;
    public const int SAVING_THROW_TYPE_CHAOS = 19;
    public const int IMMUNITY_TYPE_NONE = 0;
    public const int IMMUNITY_TYPE_MIND_SPELLS = 1;
    public const int IMMUNITY_TYPE_POISON = 2;
    public const int IMMUNITY_TYPE_DISEASE = 3;
    public const int IMMUNITY_TYPE_FEAR = 4;
    public const int IMMUNITY_TYPE_TRAP = 5;
    public const int IMMUNITY_TYPE_PARALYSIS = 6;
    public const int IMMUNITY_TYPE_BLINDNESS = 7;
    public const int IMMUNITY_TYPE_DEAFNESS = 8;
    public const int IMMUNITY_TYPE_SLOW = 9;
    public const int IMMUNITY_TYPE_ENTANGLE = 10;
    public const int IMMUNITY_TYPE_SILENCE = 11;
    public const int IMMUNITY_TYPE_STUN = 12;
    public const int IMMUNITY_TYPE_SLEEP = 13;
    public const int IMMUNITY_TYPE_CHARM = 14;
    public const int IMMUNITY_TYPE_DOMINATE = 15;
    public const int IMMUNITY_TYPE_CONFUSED = 16;
    public const int IMMUNITY_TYPE_CURSED = 17;
    public const int IMMUNITY_TYPE_DAZED = 18;
    public const int IMMUNITY_TYPE_ABILITY_DECREASE = 19;
    public const int IMMUNITY_TYPE_ATTACK_DECREASE = 20;
    public const int IMMUNITY_TYPE_DAMAGE_DECREASE = 21;
    public const int IMMUNITY_TYPE_DAMAGE_IMMUNITY_DECREASE = 22;
    public const int IMMUNITY_TYPE_AC_DECREASE = 23;
    public const int IMMUNITY_TYPE_MOVEMENT_SPEED_DECREASE = 24;
    public const int IMMUNITY_TYPE_SAVING_THROW_DECREASE = 25;
    public const int IMMUNITY_TYPE_SPELL_RESISTANCE_DECREASE = 26;
    public const int IMMUNITY_TYPE_SKILL_DECREASE = 27;
    public const int IMMUNITY_TYPE_KNOCKDOWN = 28;
    public const int IMMUNITY_TYPE_NEGATIVE_LEVEL = 29;
    public const int IMMUNITY_TYPE_SNEAK_ATTACK = 30;
    public const int IMMUNITY_TYPE_CRITICAL_HIT = 31;
    public const int IMMUNITY_TYPE_DEATH = 32;
    public const int AREA_TRANSITION_RANDOM = 0;
    public const int AREA_TRANSITION_USER_DEFINED = 1;
    public const int AREA_TRANSITION_CITY_01 = 2;
    public const int AREA_TRANSITION_CITY_02 = 3;
    public const int AREA_TRANSITION_CITY_03 = 4;
    public const int AREA_TRANSITION_CITY_04 = 5;
    public const int AREA_TRANSITION_CITY_05 = 6;
    public const int AREA_TRANSITION_CRYPT_01 = 7;
    public const int AREA_TRANSITION_CRYPT_02 = 8;
    public const int AREA_TRANSITION_CRYPT_03 = 9;
    public const int AREA_TRANSITION_CRYPT_04 = 10;
    public const int AREA_TRANSITION_CRYPT_05 = 11;
    public const int AREA_TRANSITION_DUNGEON_01 = 12;
    public const int AREA_TRANSITION_DUNGEON_02 = 13;
    public const int AREA_TRANSITION_DUNGEON_03 = 14;
    public const int AREA_TRANSITION_DUNGEON_04 = 15;
    public const int AREA_TRANSITION_DUNGEON_05 = 16;
    public const int AREA_TRANSITION_DUNGEON_06 = 17;
    public const int AREA_TRANSITION_DUNGEON_07 = 18;
    public const int AREA_TRANSITION_DUNGEON_08 = 19;
    public const int AREA_TRANSITION_MINES_01 = 20;
    public const int AREA_TRANSITION_MINES_02 = 21;
    public const int AREA_TRANSITION_MINES_03 = 22;
    public const int AREA_TRANSITION_MINES_04 = 23;
    public const int AREA_TRANSITION_MINES_05 = 24;
    public const int AREA_TRANSITION_MINES_06 = 25;
    public const int AREA_TRANSITION_MINES_07 = 26;
    public const int AREA_TRANSITION_MINES_08 = 27;
    public const int AREA_TRANSITION_MINES_09 = 28;
    public const int AREA_TRANSITION_SEWER_01 = 29;
    public const int AREA_TRANSITION_SEWER_02 = 30;
    public const int AREA_TRANSITION_SEWER_03 = 31;
    public const int AREA_TRANSITION_SEWER_04 = 32;
    public const int AREA_TRANSITION_SEWER_05 = 33;
    public const int AREA_TRANSITION_CASTLE_01 = 34;
    public const int AREA_TRANSITION_CASTLE_02 = 35;
    public const int AREA_TRANSITION_CASTLE_03 = 36;
    public const int AREA_TRANSITION_CASTLE_04 = 37;
    public const int AREA_TRANSITION_CASTLE_05 = 38;
    public const int AREA_TRANSITION_CASTLE_06 = 39;
    public const int AREA_TRANSITION_CASTLE_07 = 40;
    public const int AREA_TRANSITION_CASTLE_08 = 41;
    public const int AREA_TRANSITION_INTERIOR_01 = 42;
    public const int AREA_TRANSITION_INTERIOR_02 = 43;
    public const int AREA_TRANSITION_INTERIOR_03 = 44;
    public const int AREA_TRANSITION_INTERIOR_04 = 45;
    public const int AREA_TRANSITION_INTERIOR_05 = 46;
    public const int AREA_TRANSITION_INTERIOR_06 = 47;
    public const int AREA_TRANSITION_INTERIOR_07 = 48;
    public const int AREA_TRANSITION_INTERIOR_08 = 49;
    public const int AREA_TRANSITION_INTERIOR_09 = 50;
    public const int AREA_TRANSITION_INTERIOR_10 = 51;
    public const int AREA_TRANSITION_INTERIOR_11 = 52;
    public const int AREA_TRANSITION_INTERIOR_12 = 53;
    public const int AREA_TRANSITION_INTERIOR_13 = 54;
    public const int AREA_TRANSITION_INTERIOR_14 = 55;
    public const int AREA_TRANSITION_INTERIOR_15 = 56;
    public const int AREA_TRANSITION_INTERIOR_16 = 57;
    public const int AREA_TRANSITION_FOREST_01 = 58;
    public const int AREA_TRANSITION_FOREST_02 = 59;
    public const int AREA_TRANSITION_FOREST_03 = 60;
    public const int AREA_TRANSITION_FOREST_04 = 61;
    public const int AREA_TRANSITION_FOREST_05 = 62;
    public const int AREA_TRANSITION_RURAL_01 = 63;
    public const int AREA_TRANSITION_RURAL_02 = 64;
    public const int AREA_TRANSITION_RURAL_03 = 65;
    public const int AREA_TRANSITION_RURAL_04 = 66;
    public const int AREA_TRANSITION_RURAL_05 = 67;
    public const int AREA_TRANSITION_WRURAL_01 = 68;
    public const int AREA_TRANSITION_WRURAL_02 = 69;
    public const int AREA_TRANSITION_WRURAL_03 = 70;
    public const int AREA_TRANSITION_WRURAL_04 = 71;
    public const int AREA_TRANSITION_WRURAL_05 = 72;
    public const int AREA_TRANSITION_DESERT_01 = 73;
    public const int AREA_TRANSITION_DESERT_02 = 74;
    public const int AREA_TRANSITION_DESERT_03 = 75;
    public const int AREA_TRANSITION_DESERT_04 = 76;
    public const int AREA_TRANSITION_DESERT_05 = 77;
    public const int AREA_TRANSITION_RUINS_01 = 78;
    public const int AREA_TRANSITION_RUINS_02 = 79;
    public const int AREA_TRANSITION_RUINS_03 = 80;
    public const int AREA_TRANSITION_RUINS_04 = 81;
    public const int AREA_TRANSITION_RUINS_05 = 82;
    public const int AREA_TRANSITION_CARAVAN_WINTER = 83;
    public const int AREA_TRANSITION_CARAVAN_DESERT = 84;
    public const int AREA_TRANSITION_CARAVAN_RURAL = 85;
    public const int AREA_TRANSITION_MAGICAL_01 = 86;
    public const int AREA_TRANSITION_MAGICAL_02 = 87;
    public const int AREA_TRANSITION_UNDERDARK_01 = 88;
    public const int AREA_TRANSITION_UNDERDARK_02 = 89;
    public const int AREA_TRANSITION_UNDERDARK_03 = 90;
    public const int AREA_TRANSITION_UNDERDARK_04 = 91;
    public const int AREA_TRANSITION_UNDERDARK_05 = 92;
    public const int AREA_TRANSITION_UNDERDARK_06 = 93;
    public const int AREA_TRANSITION_UNDERDARK_07 = 94;
    public const int AREA_TRANSITION_BEHOLDER_01 = 95;
    public const int AREA_TRANSITION_BEHOLDER_02 = 96;
    public const int AREA_TRANSITION_DROW_01 = 97;
    public const int AREA_TRANSITION_DROW_02 = 98;
    public const int AREA_TRANSITION_ILLITHID_01 = 99;
    public const int AREA_TRANSITION_ILLITHID_02 = 100;
    public const int AREA_TRANSITION_WASTELAND_01 = 101;
    public const int AREA_TRANSITION_WASTELAND_02 = 102;
    public const int AREA_TRANSITION_WASTELAND_03 = 103;
    public const int AREA_TRANSITION_DROW_03 = 104;
    public const int AREA_TRANSITION_DROW_04 = 105;

    ///  Legacy area-transition constants.  Do not delete these.
    public const int AREA_TRANSITION_CITY = 2;
    public const int AREA_TRANSITION_CRYPT = 7;
    public const int AREA_TRANSITION_FOREST = 58;
    public const int AREA_TRANSITION_RURAL = 63;
    public const int BODY_NODE_HAND = 0;
    public const int BODY_NODE_CHEST = 1;
    public const int BODY_NODE_MONSTER_0 = 2;
    public const int BODY_NODE_MONSTER_1 = 3;
    public const int BODY_NODE_MONSTER_2 = 4;
    public const int BODY_NODE_MONSTER_3 = 5;
    public const int BODY_NODE_MONSTER_4 = 6;
    public const int BODY_NODE_MONSTER_5 = 7;
    public const int BODY_NODE_MONSTER_6 = 8;
    public const int BODY_NODE_MONSTER_7 = 9;
    public const int BODY_NODE_MONSTER_8 = 10;
    public const int BODY_NODE_MONSTER_9 = 11;
    public const float RADIUS_SIZE_SMALL = 1.67f;
    public const float RADIUS_SIZE_MEDIUM = 3.33f;
    public const float RADIUS_SIZE_LARGE = 5.0f;
    public const float RADIUS_SIZE_HUGE = 6.67f;
    public const float RADIUS_SIZE_GARGANTUAN = 8.33f;
    public const float RADIUS_SIZE_COLOSSAL = 10.0f;

    ///  these are magic numbers.  they should correspond to the values layed out in ExecuteCommandGetEffectType
    public const int EFFECT_TYPE_INVALIDEFFECT = 0;
    public const int EFFECT_TYPE_DAMAGE_RESISTANCE = 1;

    /// int EFFECT_TYPE_ABILITY_BONUS               = 2;
    public const int EFFECT_TYPE_REGENERATE = 3;

    /// int EFFECT_TYPE_SAVING_THROW_BONUS          = 4;<br/>
    /// int EFFECT_TYPE_MODIFY_AC                   = 5;<br/>
    /// int EFFECT_TYPE_ATTACK_BONUS                = 6;
    public const int EFFECT_TYPE_DAMAGE_REDUCTION = 7;

    /// int EFFECT_TYPE_DAMAGE_BONUS                = 8;
    public const int EFFECT_TYPE_TEMPORARY_HITPOINTS = 9;

    /// int EFFECT_TYPE_DAMAGE_IMMUNITY             = 10;
    public const int EFFECT_TYPE_ENTANGLE = 11;
    public const int EFFECT_TYPE_INVULNERABLE = 12;
    public const int EFFECT_TYPE_DEAF = 13;
    public const int EFFECT_TYPE_RESURRECTION = 14;
    public const int EFFECT_TYPE_IMMUNITY = 15;

    /// int EFFECT_TYPE_BLIND                       = 16;
    public const int EFFECT_TYPE_ENEMY_ATTACK_BONUS = 17;
    public const int EFFECT_TYPE_ARCANE_SPELL_FAILURE = 18;

    /// int EFFECT_TYPE_MOVEMENT_SPEED              = 19;
    public const int EFFECT_TYPE_AREA_OF_EFFECT = 20;
    public const int EFFECT_TYPE_BEAM = 21;

    /// int EFFECT_TYPE_SPELL_RESISTANCE            = 22;
    public const int EFFECT_TYPE_CHARMED = 23;
    public const int EFFECT_TYPE_CONFUSED = 24;
    public const int EFFECT_TYPE_FRIGHTENED = 25;
    public const int EFFECT_TYPE_DOMINATED = 26;
    public const int EFFECT_TYPE_PARALYZE = 27;
    public const int EFFECT_TYPE_DAZED = 28;
    public const int EFFECT_TYPE_STUNNED = 29;
    public const int EFFECT_TYPE_SLEEP = 30;
    public const int EFFECT_TYPE_POISON = 31;
    public const int EFFECT_TYPE_DISEASE = 32;
    public const int EFFECT_TYPE_CURSE = 33;
    public const int EFFECT_TYPE_SILENCE = 34;
    public const int EFFECT_TYPE_TURNED = 35;
    public const int EFFECT_TYPE_HASTE = 36;
    public const int EFFECT_TYPE_SLOW = 37;
    public const int EFFECT_TYPE_ABILITY_INCREASE = 38;
    public const int EFFECT_TYPE_ABILITY_DECREASE = 39;
    public const int EFFECT_TYPE_ATTACK_INCREASE = 40;
    public const int EFFECT_TYPE_ATTACK_DECREASE = 41;
    public const int EFFECT_TYPE_DAMAGE_INCREASE = 42;
    public const int EFFECT_TYPE_DAMAGE_DECREASE = 43;
    public const int EFFECT_TYPE_DAMAGE_IMMUNITY_INCREASE = 44;
    public const int EFFECT_TYPE_DAMAGE_IMMUNITY_DECREASE = 45;
    public const int EFFECT_TYPE_AC_INCREASE = 46;
    public const int EFFECT_TYPE_AC_DECREASE = 47;
    public const int EFFECT_TYPE_MOVEMENT_SPEED_INCREASE = 48;
    public const int EFFECT_TYPE_MOVEMENT_SPEED_DECREASE = 49;
    public const int EFFECT_TYPE_SAVING_THROW_INCREASE = 50;
    public const int EFFECT_TYPE_SAVING_THROW_DECREASE = 51;
    public const int EFFECT_TYPE_SPELL_RESISTANCE_INCREASE = 52;
    public const int EFFECT_TYPE_SPELL_RESISTANCE_DECREASE = 53;
    public const int EFFECT_TYPE_SKILL_INCREASE = 54;
    public const int EFFECT_TYPE_SKILL_DECREASE = 55;
    public const int EFFECT_TYPE_INVISIBILITY = 56;
    public const int EFFECT_TYPE_IMPROVEDINVISIBILITY = 57;
    public const int EFFECT_TYPE_DARKNESS = 58;
    public const int EFFECT_TYPE_DISPELMAGICALL = 59;
    public const int EFFECT_TYPE_ELEMENTALSHIELD = 60;
    public const int EFFECT_TYPE_NEGATIVELEVEL = 61;
    public const int EFFECT_TYPE_POLYMORPH = 62;
    public const int EFFECT_TYPE_SANCTUARY = 63;
    public const int EFFECT_TYPE_TRUESEEING = 64;
    public const int EFFECT_TYPE_SEEINVISIBLE = 65;
    public const int EFFECT_TYPE_TIMESTOP = 66;
    public const int EFFECT_TYPE_BLINDNESS = 67;
    public const int EFFECT_TYPE_SPELLLEVELABSORPTION = 68;
    public const int EFFECT_TYPE_DISPELMAGICBEST = 69;
    public const int EFFECT_TYPE_ULTRAVISION = 70;
    public const int EFFECT_TYPE_MISS_CHANCE = 71;
    public const int EFFECT_TYPE_CONCEALMENT = 72;
    public const int EFFECT_TYPE_SPELL_IMMUNITY = 73;
    public const int EFFECT_TYPE_VISUALEFFECT = 74;
    public const int EFFECT_TYPE_DISAPPEARAPPEAR = 75;
    public const int EFFECT_TYPE_SWARM = 76;
    public const int EFFECT_TYPE_TURN_RESISTANCE_DECREASE = 77;
    public const int EFFECT_TYPE_TURN_RESISTANCE_INCREASE = 78;
    public const int EFFECT_TYPE_PETRIFY = 79;
    public const int EFFECT_TYPE_CUTSCENE_PARALYZE = 80;
    public const int EFFECT_TYPE_ETHEREAL = 81;
    public const int EFFECT_TYPE_SPELL_FAILURE = 82;
    public const int EFFECT_TYPE_CUTSCENEGHOST = 83;
    public const int EFFECT_TYPE_CUTSCENEIMMOBILIZE = 84;
    public const int EFFECT_TYPE_RUNSCRIPT = 85;
    public const int EFFECT_TYPE_ICON = 86;
    public const int ITEM_APPR_TYPE_SIMPLE_MODEL = 0;
    public const int ITEM_APPR_TYPE_WEAPON_COLOR = 1;
    public const int ITEM_APPR_TYPE_WEAPON_MODEL = 2;
    public const int ITEM_APPR_TYPE_ARMOR_MODEL = 3;
    public const int ITEM_APPR_TYPE_ARMOR_COLOR = 4;
    public const int ITEM_APPR_NUM_TYPES = 5;
    public const int ITEM_APPR_ARMOR_COLOR_LEATHER1 = 0;
    public const int ITEM_APPR_ARMOR_COLOR_LEATHER2 = 1;
    public const int ITEM_APPR_ARMOR_COLOR_CLOTH1 = 2;
    public const int ITEM_APPR_ARMOR_COLOR_CLOTH2 = 3;
    public const int ITEM_APPR_ARMOR_COLOR_METAL1 = 4;
    public const int ITEM_APPR_ARMOR_COLOR_METAL2 = 5;
    public const int ITEM_APPR_ARMOR_NUM_COLORS = 6;
    public const int ITEM_APPR_ARMOR_MODEL_RFOOT = 0;
    public const int ITEM_APPR_ARMOR_MODEL_LFOOT = 1;
    public const int ITEM_APPR_ARMOR_MODEL_RSHIN = 2;
    public const int ITEM_APPR_ARMOR_MODEL_LSHIN = 3;
    public const int ITEM_APPR_ARMOR_MODEL_LTHIGH = 4;
    public const int ITEM_APPR_ARMOR_MODEL_RTHIGH = 5;
    public const int ITEM_APPR_ARMOR_MODEL_PELVIS = 6;
    public const int ITEM_APPR_ARMOR_MODEL_TORSO = 7;
    public const int ITEM_APPR_ARMOR_MODEL_BELT = 8;
    public const int ITEM_APPR_ARMOR_MODEL_NECK = 9;
    public const int ITEM_APPR_ARMOR_MODEL_RFOREARM = 10;
    public const int ITEM_APPR_ARMOR_MODEL_LFOREARM = 11;
    public const int ITEM_APPR_ARMOR_MODEL_RBICEP = 12;
    public const int ITEM_APPR_ARMOR_MODEL_LBICEP = 13;
    public const int ITEM_APPR_ARMOR_MODEL_RSHOULDER = 14;
    public const int ITEM_APPR_ARMOR_MODEL_LSHOULDER = 15;
    public const int ITEM_APPR_ARMOR_MODEL_RHAND = 16;
    public const int ITEM_APPR_ARMOR_MODEL_LHAND = 17;
    public const int ITEM_APPR_ARMOR_MODEL_ROBE = 18;
    public const int ITEM_APPR_ARMOR_NUM_MODELS = 19;
    public const int ITEM_APPR_WEAPON_MODEL_BOTTOM = 0;
    public const int ITEM_APPR_WEAPON_MODEL_MIDDLE = 1;
    public const int ITEM_APPR_WEAPON_MODEL_TOP = 2;
    public const int ITEM_APPR_WEAPON_COLOR_BOTTOM = 0;
    public const int ITEM_APPR_WEAPON_COLOR_MIDDLE = 1;
    public const int ITEM_APPR_WEAPON_COLOR_TOP = 2;
    public const int ITEM_PROPERTY_ABILITY_BONUS = 0;
    public const int ITEM_PROPERTY_AC_BONUS = 1;
    public const int ITEM_PROPERTY_AC_BONUS_VS_ALIGNMENT_GROUP = 2;
    public const int ITEM_PROPERTY_AC_BONUS_VS_DAMAGE_TYPE = 3;
    public const int ITEM_PROPERTY_AC_BONUS_VS_RACIAL_GROUP = 4;
    public const int ITEM_PROPERTY_AC_BONUS_VS_SPECIFIC_ALIGNMENT = 5;
    public const int ITEM_PROPERTY_ENHANCEMENT_BONUS = 6;
    public const int ITEM_PROPERTY_ENHANCEMENT_BONUS_VS_ALIGNMENT_GROUP = 7;
    public const int ITEM_PROPERTY_ENHANCEMENT_BONUS_VS_RACIAL_GROUP = 8;
    public const int ITEM_PROPERTY_ENHANCEMENT_BONUS_VS_SPECIFIC_ALIGNEMENT = 9;
    public const int ITEM_PROPERTY_DECREASED_ENHANCEMENT_MODIFIER = 10;
    public const int ITEM_PROPERTY_BASE_ITEM_WEIGHT_REDUCTION = 11;
    public const int ITEM_PROPERTY_BONUS_FEAT = 12;
    public const int ITEM_PROPERTY_BONUS_SPELL_SLOT_OF_LEVEL_N = 13;
    public const int ITEM_PROPERTY_CAST_SPELL = 15;
    public const int ITEM_PROPERTY_DAMAGE_BONUS = 16;
    public const int ITEM_PROPERTY_DAMAGE_BONUS_VS_ALIGNMENT_GROUP = 17;
    public const int ITEM_PROPERTY_DAMAGE_BONUS_VS_RACIAL_GROUP = 18;
    public const int ITEM_PROPERTY_DAMAGE_BONUS_VS_SPECIFIC_ALIGNMENT = 19;
    public const int ITEM_PROPERTY_IMMUNITY_DAMAGE_TYPE = 20;
    public const int ITEM_PROPERTY_DECREASED_DAMAGE = 21;
    public const int ITEM_PROPERTY_DAMAGE_REDUCTION = 22;
    public const int ITEM_PROPERTY_DAMAGE_RESISTANCE = 23;
    public const int ITEM_PROPERTY_DAMAGE_VULNERABILITY = 24;
    public const int ITEM_PROPERTY_DARKVISION = 26;
    public const int ITEM_PROPERTY_DECREASED_ABILITY_SCORE = 27;
    public const int ITEM_PROPERTY_DECREASED_AC = 28;
    public const int ITEM_PROPERTY_DECREASED_SKILL_MODIFIER = 29;
    public const int ITEM_PROPERTY_ENHANCED_CONTAINER_REDUCED_WEIGHT = 32;
    public const int ITEM_PROPERTY_EXTRA_MELEE_DAMAGE_TYPE = 33;
    public const int ITEM_PROPERTY_EXTRA_RANGED_DAMAGE_TYPE = 34;
    public const int ITEM_PROPERTY_HASTE = 35;
    public const int ITEM_PROPERTY_HOLY_AVENGER = 36;
    public const int ITEM_PROPERTY_IMMUNITY_MISCELLANEOUS = 37;
    public const int ITEM_PROPERTY_IMPROVED_EVASION = 38;
    public const int ITEM_PROPERTY_SPELL_RESISTANCE = 39;
    public const int ITEM_PROPERTY_SAVING_THROW_BONUS = 40;
    public const int ITEM_PROPERTY_SAVING_THROW_BONUS_SPECIFIC = 41;
    public const int ITEM_PROPERTY_KEEN = 43;
    public const int ITEM_PROPERTY_LIGHT = 44;
    public const int ITEM_PROPERTY_MIGHTY = 45;
    public const int ITEM_PROPERTY_MIND_BLANK = 46;
    public const int ITEM_PROPERTY_NO_DAMAGE = 47;
    public const int ITEM_PROPERTY_ON_HIT_PROPERTIES = 48;
    public const int ITEM_PROPERTY_DECREASED_SAVING_THROWS = 49;
    public const int ITEM_PROPERTY_DECREASED_SAVING_THROWS_SPECIFIC = 50;
    public const int ITEM_PROPERTY_REGENERATION = 51;
    public const int ITEM_PROPERTY_SKILL_BONUS = 52;
    public const int ITEM_PROPERTY_IMMUNITY_SPECIFIC_SPELL = 53;
    public const int ITEM_PROPERTY_IMMUNITY_SPELL_SCHOOL = 54;
    public const int ITEM_PROPERTY_THIEVES_TOOLS = 55;
    public const int ITEM_PROPERTY_ATTACK_BONUS = 56;
    public const int ITEM_PROPERTY_ATTACK_BONUS_VS_ALIGNMENT_GROUP = 57;
    public const int ITEM_PROPERTY_ATTACK_BONUS_VS_RACIAL_GROUP = 58;
    public const int ITEM_PROPERTY_ATTACK_BONUS_VS_SPECIFIC_ALIGNMENT = 59;
    public const int ITEM_PROPERTY_DECREASED_ATTACK_MODIFIER = 60;
    public const int ITEM_PROPERTY_UNLIMITED_AMMUNITION = 61;
    public const int ITEM_PROPERTY_USE_LIMITATION_ALIGNMENT_GROUP = 62;
    public const int ITEM_PROPERTY_USE_LIMITATION_CLASS = 63;
    public const int ITEM_PROPERTY_USE_LIMITATION_RACIAL_TYPE = 64;
    public const int ITEM_PROPERTY_USE_LIMITATION_SPECIFIC_ALIGNMENT = 65;
    public const int ITEM_PROPERTY_USE_LIMITATION_TILESET = 66;
    public const int ITEM_PROPERTY_REGENERATION_VAMPIRIC = 67;
    public const int ITEM_PROPERTY_TRAP = 70;
    public const int ITEM_PROPERTY_TRUE_SEEING = 71;
    public const int ITEM_PROPERTY_ON_MONSTER_HIT = 72;
    public const int ITEM_PROPERTY_TURN_RESISTANCE = 73;
    public const int ITEM_PROPERTY_MASSIVE_CRITICALS = 74;
    public const int ITEM_PROPERTY_FREEDOM_OF_MOVEMENT = 75;

    ///  no longer working, poison is now a on_hit subtype
    public const int ITEM_PROPERTY_POISON = 76;
    public const int ITEM_PROPERTY_MONSTER_DAMAGE = 77;
    public const int ITEM_PROPERTY_IMMUNITY_SPELLS_BY_LEVEL = 78;
    public const int ITEM_PROPERTY_SPECIAL_WALK = 79;
    public const int ITEM_PROPERTY_HEALERS_KIT = 80;
    public const int ITEM_PROPERTY_WEIGHT_INCREASE = 81;
    public const int ITEM_PROPERTY_ONHITCASTSPELL = 82;
    public const int ITEM_PROPERTY_VISUALEFFECT = 83;
    public const int ITEM_PROPERTY_ARCANE_SPELL_FAILURE = 84;
    public const int ITEM_PROPERTY_MATERIAL = 85;
    public const int ITEM_PROPERTY_QUALITY = 86;
    public const int ITEM_PROPERTY_ADDITIONAL = 87;
    public const int BASE_ITEM_SHORTSWORD = 0;
    public const int BASE_ITEM_LONGSWORD = 1;
    public const int BASE_ITEM_BATTLEAXE = 2;
    public const int BASE_ITEM_BASTARDSWORD = 3;
    public const int BASE_ITEM_LIGHTFLAIL = 4;
    public const int BASE_ITEM_WARHAMMER = 5;
    public const int BASE_ITEM_HEAVYCROSSBOW = 6;
    public const int BASE_ITEM_LIGHTCROSSBOW = 7;
    public const int BASE_ITEM_LONGBOW = 8;
    public const int BASE_ITEM_LIGHTMACE = 9;
    public const int BASE_ITEM_HALBERD = 10;
    public const int BASE_ITEM_SHORTBOW = 11;
    public const int BASE_ITEM_TWOBLADEDSWORD = 12;
    public const int BASE_ITEM_GREATSWORD = 13;
    public const int BASE_ITEM_SMALLSHIELD = 14;
    public const int BASE_ITEM_TORCH = 15;
    public const int BASE_ITEM_ARMOR = 16;
    public const int BASE_ITEM_HELMET = 17;
    public const int BASE_ITEM_GREATAXE = 18;
    public const int BASE_ITEM_AMULET = 19;
    public const int BASE_ITEM_ARROW = 20;
    public const int BASE_ITEM_BELT = 21;
    public const int BASE_ITEM_DAGGER = 22;
    public const int BASE_ITEM_MISCSMALL = 24;
    public const int BASE_ITEM_BOLT = 25;
    public const int BASE_ITEM_BOOTS = 26;
    public const int BASE_ITEM_BULLET = 27;
    public const int BASE_ITEM_CLUB = 28;
    public const int BASE_ITEM_MISCMEDIUM = 29;
    public const int BASE_ITEM_DART = 31;
    public const int BASE_ITEM_DIREMACE = 32;
    public const int BASE_ITEM_DOUBLEAXE = 33;
    public const int BASE_ITEM_MISCLARGE = 34;
    public const int BASE_ITEM_HEAVYFLAIL = 35;
    public const int BASE_ITEM_GLOVES = 36;
    public const int BASE_ITEM_LIGHTHAMMER = 37;
    public const int BASE_ITEM_HANDAXE = 38;
    public const int BASE_ITEM_HEALERSKIT = 39;
    public const int BASE_ITEM_KAMA = 40;
    public const int BASE_ITEM_KATANA = 41;
    public const int BASE_ITEM_KUKRI = 42;
    public const int BASE_ITEM_MISCTALL = 43;
    public const int BASE_ITEM_MAGICROD = 44;
    public const int BASE_ITEM_MAGICSTAFF = 45;
    public const int BASE_ITEM_MAGICWAND = 46;
    public const int BASE_ITEM_MORNINGSTAR = 47;
    public const int BASE_ITEM_POTIONS = 49;
    public const int BASE_ITEM_QUARTERSTAFF = 50;
    public const int BASE_ITEM_RAPIER = 51;
    public const int BASE_ITEM_RING = 52;
    public const int BASE_ITEM_SCIMITAR = 53;
    public const int BASE_ITEM_SCROLL = 54;
    public const int BASE_ITEM_SCYTHE = 55;
    public const int BASE_ITEM_LARGESHIELD = 56;
    public const int BASE_ITEM_TOWERSHIELD = 57;
    public const int BASE_ITEM_SHORTSPEAR = 58;
    public const int BASE_ITEM_SHURIKEN = 59;
    public const int BASE_ITEM_SICKLE = 60;
    public const int BASE_ITEM_SLING = 61;
    public const int BASE_ITEM_THIEVESTOOLS = 62;
    public const int BASE_ITEM_THROWINGAXE = 63;
    public const int BASE_ITEM_TRAPKIT = 64;
    public const int BASE_ITEM_KEY = 65;
    public const int BASE_ITEM_LARGEBOX = 66;
    public const int BASE_ITEM_MISCWIDE = 68;
    public const int BASE_ITEM_CSLASHWEAPON = 69;
    public const int BASE_ITEM_CPIERCWEAPON = 70;
    public const int BASE_ITEM_CBLUDGWEAPON = 71;
    public const int BASE_ITEM_CSLSHPRCWEAP = 72;
    public const int BASE_ITEM_CREATUREITEM = 73;
    public const int BASE_ITEM_BOOK = 74;
    public const int BASE_ITEM_SPELLSCROLL = 75;
    public const int BASE_ITEM_GOLD = 76;
    public const int BASE_ITEM_GEM = 77;
    public const int BASE_ITEM_BRACER = 78;
    public const int BASE_ITEM_MISCTHIN = 79;
    public const int BASE_ITEM_CLOAK = 80;
    public const int BASE_ITEM_GRENADE = 81;
    public const int BASE_ITEM_TRIDENT = 95;
    public const int BASE_ITEM_BLANK_POTION = 101;
    public const int BASE_ITEM_BLANK_SCROLL = 102;
    public const int BASE_ITEM_BLANK_WAND = 103;
    public const int BASE_ITEM_ENCHANTED_POTION = 104;
    public const int BASE_ITEM_ENCHANTED_SCROLL = 105;
    public const int BASE_ITEM_ENCHANTED_WAND = 106;
    public const int BASE_ITEM_DWARVENWARAXE = 108;
    public const int BASE_ITEM_CRAFTMATERIALMED = 109;
    public const int BASE_ITEM_CRAFTMATERIALSML = 110;
    public const int BASE_ITEM_WHIP = 111;
    public const int BASE_ITEM_INVALID = 256;
    public const int VFX_NONE = -1;
    public const int VFX_DUR_BLUR = 0;
    public const int VFX_DUR_DARKNESS = 1;
    public const int VFX_DUR_ENTANGLE = 2;
    public const int VFX_DUR_FREEDOM_OF_MOVEMENT = 3;
    public const int VFX_DUR_GLOBE_INVULNERABILITY = 4;
    public const int VFX_DUR_BLACKOUT = 5;
    public const int VFX_DUR_INVISIBILITY = 6;
    public const int VFX_DUR_MIND_AFFECTING_NEGATIVE = 7;
    public const int VFX_DUR_MIND_AFFECTING_POSITIVE = 8;
    public const int VFX_DUR_GHOSTLY_VISAGE = 9;
    public const int VFX_DUR_ETHEREAL_VISAGE = 10;
    public const int VFX_DUR_PROT_BARKSKIN = 11;
    public const int VFX_DUR_PROT_GREATER_STONESKIN = 12;
    public const int VFX_DUR_PROT_PREMONITION = 13;
    public const int VFX_DUR_PROT_SHADOW_ARMOR = 14;
    public const int VFX_DUR_PROT_STONESKIN = 15;
    public const int VFX_DUR_SANCTUARY = 16;
    public const int VFX_DUR_WEB = 17;
    public const int VFX_FNF_BLINDDEAF = 18;
    public const int VFX_FNF_DISPEL = 19;
    public const int VFX_FNF_DISPEL_DISJUNCTION = 20;
    public const int VFX_FNF_DISPEL_GREATER = 21;
    public const int VFX_FNF_FIREBALL = 22;
    public const int VFX_FNF_FIRESTORM = 23;
    public const int VFX_FNF_IMPLOSION = 24;

    /// int VFX_FNF_MASS_HASTE = 25 ;
    public const int VFX_FNF_MASS_HEAL = 26;
    public const int VFX_FNF_MASS_MIND_AFFECTING = 27;
    public const int VFX_FNF_METEOR_SWARM = 28;
    public const int VFX_FNF_NATURES_BALANCE = 29;
    public const int VFX_FNF_PWKILL = 30;
    public const int VFX_FNF_PWSTUN = 31;
    public const int VFX_FNF_SUMMON_GATE = 32;
    public const int VFX_FNF_SUMMON_MONSTER_1 = 33;
    public const int VFX_FNF_SUMMON_MONSTER_2 = 34;
    public const int VFX_FNF_SUMMON_MONSTER_3 = 35;
    public const int VFX_FNF_SUMMON_UNDEAD = 36;
    public const int VFX_FNF_SUNBEAM = 37;
    public const int VFX_FNF_TIME_STOP = 38;
    public const int VFX_FNF_WAIL_O_BANSHEES = 39;
    public const int VFX_FNF_WEIRD = 40;
    public const int VFX_FNF_WORD = 41;
    public const int VFX_IMP_AC_BONUS = 42;
    public const int VFX_IMP_ACID_L = 43;
    public const int VFX_IMP_ACID_S = 44;

    /// int VFX_IMP_ALTER_WEAPON = 45 ;
    public const int VFX_IMP_BLIND_DEAF_M = 46;
    public const int VFX_IMP_BREACH = 47;
    public const int VFX_IMP_CONFUSION_S = 48;
    public const int VFX_IMP_DAZED_S = 49;
    public const int VFX_IMP_DEATH = 50;
    public const int VFX_IMP_DISEASE_S = 51;
    public const int VFX_IMP_DISPEL = 52;
    public const int VFX_IMP_DISPEL_DISJUNCTION = 53;
    public const int VFX_IMP_DIVINE_STRIKE_FIRE = 54;
    public const int VFX_IMP_DIVINE_STRIKE_HOLY = 55;
    public const int VFX_IMP_DOMINATE_S = 56;
    public const int VFX_IMP_DOOM = 57;
    public const int VFX_IMP_FEAR_S = 58;

    /// int VFX_IMP_FLAME_L = 59 ;
    public const int VFX_IMP_FLAME_M = 60;
    public const int VFX_IMP_FLAME_S = 61;
    public const int VFX_IMP_FROST_L = 62;
    public const int VFX_IMP_FROST_S = 63;
    public const int VFX_IMP_GREASE = 64;
    public const int VFX_IMP_HASTE = 65;
    public const int VFX_IMP_HEALING_G = 66;
    public const int VFX_IMP_HEALING_L = 67;
    public const int VFX_IMP_HEALING_M = 68;
    public const int VFX_IMP_HEALING_S = 69;
    public const int VFX_IMP_HEALING_X = 70;
    public const int VFX_IMP_HOLY_AID = 71;
    public const int VFX_IMP_KNOCK = 72;
    public const int VFX_BEAM_LIGHTNING = 73;
    public const int VFX_IMP_LIGHTNING_M = 74;
    public const int VFX_IMP_LIGHTNING_S = 75;
    public const int VFX_IMP_MAGBLUE = 76;

    /// int VFX_IMP_MAGBLUE2 = 77 ;<br/>
    /// int VFX_IMP_MAGBLUE3 = 78 ;<br/>
    /// int VFX_IMP_MAGBLUE4 = 79 ;<br/>
    /// int VFX_IMP_MAGBLUE5 = 80 ;
    public const int VFX_IMP_NEGATIVE_ENERGY = 81;
    public const int VFX_DUR_PARALYZE_HOLD = 82;
    public const int VFX_IMP_POISON_L = 83;
    public const int VFX_IMP_POISON_S = 84;
    public const int VFX_IMP_POLYMORPH = 85;
    public const int VFX_IMP_PULSE_COLD = 86;
    public const int VFX_IMP_PULSE_FIRE = 87;
    public const int VFX_IMP_PULSE_HOLY = 88;
    public const int VFX_IMP_PULSE_NEGATIVE = 89;
    public const int VFX_IMP_RAISE_DEAD = 90;
    public const int VFX_IMP_REDUCE_ABILITY_SCORE = 91;
    public const int VFX_IMP_REMOVE_CONDITION = 92;
    public const int VFX_IMP_SILENCE = 93;
    public const int VFX_IMP_SLEEP = 94;
    public const int VFX_IMP_SLOW = 95;
    public const int VFX_IMP_SONIC = 96;
    public const int VFX_IMP_STUN = 97;
    public const int VFX_IMP_SUNSTRIKE = 98;
    public const int VFX_IMP_UNSUMMON = 99;
    public const int VFX_COM_SPECIAL_BLUE_RED = 100;
    public const int VFX_COM_SPECIAL_PINK_ORANGE = 101;
    public const int VFX_COM_SPECIAL_RED_WHITE = 102;
    public const int VFX_COM_SPECIAL_RED_ORANGE = 103;
    public const int VFX_COM_SPECIAL_WHITE_BLUE = 104;
    public const int VFX_COM_SPECIAL_WHITE_ORANGE = 105;
    public const int VFX_COM_BLOOD_REG_WIMP = 106;
    public const int VFX_COM_BLOOD_LRG_WIMP = 107;
    public const int VFX_COM_BLOOD_CRT_WIMP = 108;
    public const int VFX_COM_BLOOD_REG_RED = 109;
    public const int VFX_COM_BLOOD_REG_GREEN = 110;
    public const int VFX_COM_BLOOD_REG_YELLOW = 111;
    public const int VFX_COM_BLOOD_LRG_RED = 112;
    public const int VFX_COM_BLOOD_LRG_GREEN = 113;
    public const int VFX_COM_BLOOD_LRG_YELLOW = 114;
    public const int VFX_COM_BLOOD_CRT_RED = 115;
    public const int VFX_COM_BLOOD_CRT_GREEN = 116;
    public const int VFX_COM_BLOOD_CRT_YELLOW = 117;
    public const int VFX_COM_SPARKS_PARRY = 118;

    /// int VFX_COM_GIB = 119 ;
    public const int VFX_COM_UNLOAD_MODEL = 120;
    public const int VFX_COM_CHUNK_RED_SMALL = 121;
    public const int VFX_COM_CHUNK_RED_MEDIUM = 122;
    public const int VFX_COM_CHUNK_GREEN_SMALL = 123;
    public const int VFX_COM_CHUNK_GREEN_MEDIUM = 124;
    public const int VFX_COM_CHUNK_YELLOW_SMALL = 125;
    public const int VFX_COM_CHUNK_YELLOW_MEDIUM = 126;

    /// int VFX_ITM_ACID = 127 ;<br/>
    /// int VFX_ITM_FIRE = 128 ;<br/>
    /// int VFX_ITM_FROST = 129 ;<br/>
    /// int VFX_ITM_ILLUMINATED_BLUE = 130 ;<br/>
    /// int VFX_ITM_ILLUMINATED_PURPLE = 131 ;<br/>
    /// int VFX_ITM_ILLUMINATED_RED = 132 ;<br/>
    /// int VFX_ITM_LIGHTNING = 133 ;<br/>
    /// int VFX_ITM_PULSING_BLUE = 134 ;<br/>
    /// int VFX_ITM_PULSING_PURPLE = 135 ;<br/>
    /// int VFX_ITM_PULSING_RED = 136 ;<br/>
    /// int VFX_ITM_SMOKING = 137 ;
    public const int VFX_DUR_SPELLTURNING = 138;
    public const int VFX_IMP_IMPROVE_ABILITY_SCORE = 139;
    public const int VFX_IMP_CHARM = 140;
    public const int VFX_IMP_MAGICAL_VISION = 141;

    /// int VFX_IMP_LAW_HELP = 142;<br/>
    /// int VFX_IMP_CHAOS_HELP = 143;
    public const int VFX_IMP_EVIL_HELP = 144;
    public const int VFX_IMP_GOOD_HELP = 145;
    public const int VFX_IMP_DEATH_WARD = 146;
    public const int VFX_DUR_ELEMENTAL_SHIELD = 147;
    public const int VFX_DUR_LIGHT = 148;
    public const int VFX_IMP_MAGIC_PROTECTION = 149;
    public const int VFX_IMP_SUPER_HEROISM = 150;
    public const int VFX_FNF_STORM = 151;
    public const int VFX_IMP_ELEMENTAL_PROTECTION = 152;
    public const int VFX_DUR_LIGHT_BLUE_5 = 153;
    public const int VFX_DUR_LIGHT_BLUE_10 = 154;
    public const int VFX_DUR_LIGHT_BLUE_15 = 155;
    public const int VFX_DUR_LIGHT_BLUE_20 = 156;
    public const int VFX_DUR_LIGHT_YELLOW_5 = 157;
    public const int VFX_DUR_LIGHT_YELLOW_10 = 158;
    public const int VFX_DUR_LIGHT_YELLOW_15 = 159;
    public const int VFX_DUR_LIGHT_YELLOW_20 = 160;
    public const int VFX_DUR_LIGHT_PURPLE_5 = 161;
    public const int VFX_DUR_LIGHT_PURPLE_10 = 162;
    public const int VFX_DUR_LIGHT_PURPLE_15 = 163;
    public const int VFX_DUR_LIGHT_PURPLE_20 = 164;
    public const int VFX_DUR_LIGHT_RED_5 = 165;
    public const int VFX_DUR_LIGHT_RED_10 = 166;
    public const int VFX_DUR_LIGHT_RED_15 = 167;
    public const int VFX_DUR_LIGHT_RED_20 = 168;
    public const int VFX_DUR_LIGHT_ORANGE_5 = 169;
    public const int VFX_DUR_LIGHT_ORANGE_10 = 170;
    public const int VFX_DUR_LIGHT_ORANGE_15 = 171;
    public const int VFX_DUR_LIGHT_ORANGE_20 = 172;
    public const int VFX_DUR_LIGHT_WHITE_5 = 173;
    public const int VFX_DUR_LIGHT_WHITE_10 = 174;
    public const int VFX_DUR_LIGHT_WHITE_15 = 175;
    public const int VFX_DUR_LIGHT_WHITE_20 = 176;
    public const int VFX_DUR_LIGHT_GREY_5 = 177;
    public const int VFX_DUR_LIGHT_GREY_10 = 178;
    public const int VFX_DUR_LIGHT_GREY_15 = 179;
    public const int VFX_DUR_LIGHT_GREY_20 = 180;
    public const int VFX_IMP_MIRV = 181;
    public const int VFX_DUR_DARKVISION = 182;
    public const int VFX_FNF_SOUND_BURST = 183;
    public const int VFX_FNF_STRIKE_HOLY = 184;
    public const int VFX_FNF_LOS_EVIL_10 = 185;
    public const int VFX_FNF_LOS_EVIL_20 = 186;
    public const int VFX_FNF_LOS_EVIL_30 = 187;
    public const int VFX_FNF_LOS_HOLY_10 = 188;
    public const int VFX_FNF_LOS_HOLY_20 = 189;
    public const int VFX_FNF_LOS_HOLY_30 = 190;
    public const int VFX_FNF_LOS_NORMAL_10 = 191;
    public const int VFX_FNF_LOS_NORMAL_20 = 192;
    public const int VFX_FNF_LOS_NORMAL_30 = 193;
    public const int VFX_IMP_HEAD_ACID = 194;
    public const int VFX_IMP_HEAD_FIRE = 195;
    public const int VFX_IMP_HEAD_SONIC = 196;
    public const int VFX_IMP_HEAD_ELECTRICITY = 197;
    public const int VFX_IMP_HEAD_COLD = 198;
    public const int VFX_IMP_HEAD_HOLY = 199;
    public const int VFX_IMP_HEAD_NATURE = 200;
    public const int VFX_IMP_HEAD_HEAL = 201;
    public const int VFX_IMP_HEAD_MIND = 202;
    public const int VFX_IMP_HEAD_EVIL = 203;
    public const int VFX_IMP_HEAD_ODD = 204;
    public const int VFX_DUR_CESSATE_NEUTRAL = 205;
    public const int VFX_DUR_CESSATE_POSITIVE = 206;
    public const int VFX_DUR_CESSATE_NEGATIVE = 207;
    public const int VFX_DUR_MIND_AFFECTING_DISABLED = 208;
    public const int VFX_DUR_MIND_AFFECTING_DOMINATED = 209;
    public const int VFX_BEAM_FIRE = 210;
    public const int VFX_BEAM_COLD = 211;
    public const int VFX_BEAM_HOLY = 212;
    public const int VFX_BEAM_MIND = 213;
    public const int VFX_BEAM_EVIL = 214;
    public const int VFX_BEAM_ODD = 215;
    public const int VFX_BEAM_FIRE_LASH = 216;
    public const int VFX_IMP_DEATH_L = 217;
    public const int VFX_DUR_MIND_AFFECTING_FEAR = 218;
    public const int VFX_FNF_SUMMON_CELESTIAL = 219;
    public const int VFX_DUR_GLOBE_MINOR = 220;
    public const int VFX_IMP_RESTORATION_LESSER = 221;
    public const int VFX_IMP_RESTORATION = 222;
    public const int VFX_IMP_RESTORATION_GREATER = 223;
    public const int VFX_DUR_PROTECTION_ELEMENTS = 224;
    public const int VFX_DUR_PROTECTION_GOOD_MINOR = 225;
    public const int VFX_DUR_PROTECTION_GOOD_MAJOR = 226;
    public const int VFX_DUR_PROTECTION_EVIL_MINOR = 227;
    public const int VFX_DUR_PROTECTION_EVIL_MAJOR = 228;
    public const int VFX_DUR_MAGICAL_SIGHT = 229;
    public const int VFX_DUR_WEB_MASS = 230;
    public const int VFX_FNF_ICESTORM = 231;
    public const int VFX_DUR_PARALYZED = 232;
    public const int VFX_IMP_MIRV_FLAME = 233;
    public const int VFX_IMP_DESTRUCTION = 234;
    public const int VFX_COM_CHUNK_RED_LARGE = 235;
    public const int VFX_COM_CHUNK_BONE_MEDIUM = 236;
    public const int VFX_COM_BLOOD_SPARK_SMALL = 237;
    public const int VFX_COM_BLOOD_SPARK_MEDIUM = 238;
    public const int VFX_COM_BLOOD_SPARK_LARGE = 239;
    public const int VFX_DUR_GHOSTLY_PULSE = 240;
    public const int VFX_FNF_HORRID_WILTING = 241;
    public const int VFX_DUR_BLINDVISION = 242;
    public const int VFX_DUR_LOWLIGHTVISION = 243;
    public const int VFX_DUR_ULTRAVISION = 244;
    public const int VFX_DUR_MIRV_ACID = 245;
    public const int VFX_IMP_HARM = 246;
    public const int VFX_DUR_BLIND = 247;
    public const int VFX_DUR_ANTI_LIGHT_10 = 248;
    public const int VFX_DUR_MAGIC_RESISTANCE = 249;
    public const int VFX_IMP_MAGIC_RESISTANCE_USE = 250;
    public const int VFX_IMP_GLOBE_USE = 251;
    public const int VFX_IMP_WILL_SAVING_THROW_USE = 252;
    public const int VFX_IMP_SPIKE_TRAP = 253;
    public const int VFX_IMP_SPELL_MANTLE_USE = 254;
    public const int VFX_IMP_FORTITUDE_SAVING_THROW_USE = 255;
    public const int VFX_IMP_REFLEX_SAVE_THROW_USE = 256;
    public const int VFX_FNF_GAS_EXPLOSION_ACID = 257;
    public const int VFX_FNF_GAS_EXPLOSION_EVIL = 258;
    public const int VFX_FNF_GAS_EXPLOSION_NATURE = 259;
    public const int VFX_FNF_GAS_EXPLOSION_FIRE = 260;
    public const int VFX_FNF_GAS_EXPLOSION_GREASE = 261;
    public const int VFX_FNF_GAS_EXPLOSION_MIND = 262;
    public const int VFX_FNF_SMOKE_PUFF = 263;
    public const int VFX_IMP_PULSE_WATER = 264;
    public const int VFX_IMP_PULSE_WIND = 265;
    public const int VFX_IMP_PULSE_NATURE = 266;
    public const int VFX_DUR_AURA_COLD = 267;
    public const int VFX_DUR_AURA_FIRE = 268;
    public const int VFX_DUR_AURA_POISON = 269;
    public const int VFX_DUR_AURA_DISEASE = 270;
    public const int VFX_DUR_AURA_ODD = 271;
    public const int VFX_DUR_AURA_SILENCE = 272;
    public const int VFX_IMP_AURA_HOLY = 273;
    public const int VFX_IMP_AURA_UNEARTHLY = 274;
    public const int VFX_IMP_AURA_FEAR = 275;
    public const int VFX_IMP_AURA_NEGATIVE_ENERGY = 276;
    public const int VFX_DUR_BARD_SONG = 277;
    public const int VFX_FNF_HOWL_MIND = 278;
    public const int VFX_FNF_HOWL_ODD = 279;
    public const int VFX_COM_HIT_FIRE = 280;
    public const int VFX_COM_HIT_FROST = 281;
    public const int VFX_COM_HIT_ELECTRICAL = 282;
    public const int VFX_COM_HIT_ACID = 283;
    public const int VFX_COM_HIT_SONIC = 284;
    public const int VFX_FNF_HOWL_WAR_CRY = 285;
    public const int VFX_FNF_SCREEN_SHAKE = 286;
    public const int VFX_FNF_SCREEN_BUMP = 287;
    public const int VFX_COM_HIT_NEGATIVE = 288;
    public const int VFX_COM_HIT_DIVINE = 289;
    public const int VFX_FNF_HOWL_WAR_CRY_FEMALE = 290;
    public const int VFX_DUR_AURA_DRAGON_FEAR = 291;
    public const int VFX_DUR_FLAG_RED = 303;
    public const int VFX_DUR_FLAG_BLUE = 304;
    public const int VFX_DUR_FLAG_GOLD = 305;
    public const int VFX_DUR_FLAG_PURPLE = 306;
    public const int VFX_DUR_FLAG_GOLD_FIXED = 306;
    public const int VFX_DUR_FLAG_PURPLE_FIXED = 305;
    public const int VFX_DUR_TENTACLE = 346;
    public const int VFX_DUR_PETRIFY = 351;
    public const int VFX_DUR_FREEZE_ANIMATION = 352;
    public const int VFX_COM_CHUNK_STONE_SMALL = 353;
    public const int VFX_COM_CHUNK_STONE_MEDIUM = 354;
    public const int VFX_BEAM_SILENT_LIGHTNING = 307;
    public const int VFX_BEAM_SILENT_FIRE = 308;
    public const int VFX_BEAM_SILENT_COLD = 309;
    public const int VFX_BEAM_SILENT_HOLY = 310;
    public const int VFX_BEAM_SILENT_MIND = 311;
    public const int VFX_BEAM_SILENT_EVIL = 312;
    public const int VFX_BEAM_SILENT_ODD = 313;
    public const int VFX_DUR_BIGBYS_INTERPOSING_HAND = 314;
    public const int VFX_IMP_BIGBYS_FORCEFUL_HAND = 315;
    public const int VFX_DUR_BIGBYS_CLENCHED_FIST = 316;
    public const int VFX_DUR_BIGBYS_CRUSHING_HAND = 317;
    public const int VFX_DUR_BIGBYS_GRASPING_HAND = 318;
    public const int VFX_DUR_CALTROPS = 319;
    public const int VFX_DUR_SMOKE = 320;
    public const int VFX_DUR_PIXIEDUST = 321;
    public const int VFX_FNF_DECK = 322;
    public const int VFX_DUR_CUTSCENE_INVISIBILITY = 355;
    public const int VFX_EYES_RED_FLAME_HUMAN_MALE = 360;
    public const int VFX_EYES_RED_FLAME_HUMAN_FEMALE = 361;
    public const int VFX_EYES_RED_FLAME_HALFELF_MALE = 360;
    public const int VFX_EYES_RED_FLAME_HALFELF_FEMALE = 361;
    public const int VFX_EYES_RED_FLAME_DWARF_MALE = 362;
    public const int VFX_EYES_RED_FLAME_DWARF_FEMALE = 363;
    public const int VFX_EYES_RED_FLAME_ELF_MALE = 364;
    public const int VFX_EYES_RED_FLAME_ELF_FEMALE = 365;
    public const int VFX_EYES_RED_FLAME_GNOME_MALE = 366;
    public const int VFX_EYES_RED_FLAME_GNOME_FEMALE = 367;
    public const int VFX_EYES_RED_FLAME_HALFLING_MALE = 368;
    public const int VFX_EYES_RED_FLAME_HALFLING_FEMALE = 369;
    public const int VFX_EYES_RED_FLAME_HALFORC_MALE = 370;
    public const int VFX_EYES_RED_FLAME_HALFORC_FEMALE = 371;
    public const int VFX_EYES_RED_FLAME_TROGLODYTE = 372;
    public const int VFX_EYES_YEL_HUMAN_MALE = 373;
    public const int VFX_EYES_YEL_HUMAN_FEMALE = 374;
    public const int VFX_EYES_YEL_DWARF_MALE = 375;
    public const int VFX_EYES_YEL_DWARF_FEMALE = 376;
    public const int VFX_EYES_YEL_ELF_MALE = 377;
    public const int VFX_EYES_YEL_ELF_FEMALE = 378;
    public const int VFX_EYES_YEL_GNOME_MALE = 379;
    public const int VFX_EYES_YEL_GNOME_FEMALE = 380;
    public const int VFX_EYES_YEL_HALFLING_MALE = 381;
    public const int VFX_EYES_YEL_HALFLING_FEMALE = 382;
    public const int VFX_EYES_YEL_HALFORC_MALE = 383;
    public const int VFX_EYES_YEL_HALFORC_FEMALE = 384;
    public const int VFX_EYES_YEL_TROGLODYTE = 385;
    public const int VFX_EYES_ORG_HUMAN_MALE = 386;
    public const int VFX_EYES_ORG_HUMAN_FEMALE = 387;
    public const int VFX_EYES_ORG_DWARF_MALE = 388;
    public const int VFX_EYES_ORG_DWARF_FEMALE = 389;
    public const int VFX_EYES_ORG_ELF_MALE = 390;
    public const int VFX_EYES_ORG_ELF_FEMALE = 391;
    public const int VFX_EYES_ORG_GNOME_MALE = 392;
    public const int VFX_EYES_ORG_GNOME_FEMALE = 393;
    public const int VFX_EYES_ORG_HALFLING_MALE = 394;
    public const int VFX_EYES_ORG_HALFLING_FEMALE = 395;
    public const int VFX_EYES_ORG_HALFORC_MALE = 396;
    public const int VFX_EYES_ORG_HALFORC_FEMALE = 397;
    public const int VFX_EYES_ORG_TROGLODYTE = 398;
    public const int VFX_DUR_IOUNSTONE = 403;
    public const int VFX_IMP_TORNADO = 407;
    public const int VFX_DUR_GLOW_LIGHT_BLUE = 408;
    public const int VFX_DUR_GLOW_PURPLE = 409;
    public const int VFX_DUR_GLOW_BLUE = 410;
    public const int VFX_DUR_GLOW_RED = 411;
    public const int VFX_DUR_GLOW_LIGHT_RED = 412;
    public const int VFX_DUR_GLOW_YELLOW = 413;
    public const int VFX_DUR_GLOW_LIGHT_YELLOW = 414;
    public const int VFX_DUR_GLOW_GREEN = 415;
    public const int VFX_DUR_GLOW_LIGHT_GREEN = 416;
    public const int VFX_DUR_GLOW_ORANGE = 417;
    public const int VFX_DUR_GLOW_LIGHT_ORANGE = 418;
    public const int VFX_DUR_GLOW_BROWN = 419;
    public const int VFX_DUR_GLOW_LIGHT_BROWN = 420;
    public const int VFX_DUR_GLOW_GREY = 421;
    public const int VFX_DUR_GLOW_WHITE = 422;
    public const int VFX_DUR_GLOW_LIGHT_PURPLE = 423;
    public const int VFX_DUR_GHOST_TRANSPARENT = 424;
    public const int VFX_DUR_GHOST_SMOKE = 425;
    public const int VFX_DUR_GLYPH_OF_WARDING = 445;
    public const int VFX_FNF_SOUND_BURST_SILENT = 446;
    public const int VFX_BEAM_DISINTEGRATE = 447;
    public const int VFX_FNF_ELECTRIC_EXPLOSION = 459;
    public const int VFX_IMP_DUST_EXPLOSION = 460;
    public const int VFX_IMP_PULSE_HOLY_SILENT = 461;
    public const int VFX_DUR_DEATH_ARMOR = 463;
    public const int VFX_DUR_ICESKIN = 465;
    public const int VFX_FNF_SWINGING_BLADE = 473;
    public const int VFX_DUR_INFERNO = 474;
    public const int VFX_FNF_DEMON_HAND = 475;
    public const int VFX_DUR_STONEHOLD = 476;
    public const int VFX_FNF_MYSTICAL_EXPLOSION = 477;
    public const int VFX_DUR_GHOSTLY_VISAGE_NO_SOUND = 478;
    public const int VFX_DUR_GHOST_SMOKE_2 = 479;
    public const int VFX_DUR_FLIES = 480;
    public const int VFX_FNF_SUMMONDRAGON = 481;
    public const int VFX_BEAM_FIRE_W = 482;
    public const int VFX_BEAM_FIRE_W_SILENT = 483;
    public const int VFX_BEAM_CHAIN = 484;
    public const int VFX_BEAM_BLACK = 485;
    public const int VFX_IMP_WALLSPIKE = 486;
    public const int VFX_FNF_GREATER_RUIN = 487;
    public const int VFX_FNF_UNDEAD_DRAGON = 488;
    public const int VFX_DUR_PROT_EPIC_ARMOR = 495;
    public const int VFX_FNF_SUMMON_EPIC_UNDEAD = 496;
    public const int VFX_DUR_PROT_EPIC_ARMOR_2 = 497;
    public const int VFX_DUR_INFERNO_CHEST = 498;
    public const int VFX_DUR_IOUNSTONE_RED = 499;
    public const int VFX_DUR_IOUNSTONE_BLUE = 500;
    public const int VFX_DUR_IOUNSTONE_YELLOW = 501;
    public const int VFX_DUR_IOUNSTONE_GREEN = 502;
    public const int VFX_IMP_MIRV_ELECTRIC = 503;
    public const int VFX_COM_CHUNK_RED_BALLISTA = 504;
    public const int VFX_DUR_INFERNO_NO_SOUND = 505;
    public const int VFX_DUR_AURA_PULSE_RED_WHITE = 512;
    public const int VFX_DUR_AURA_PULSE_BLUE_WHITE = 513;
    public const int VFX_DUR_AURA_PULSE_GREEN_WHITE = 514;
    public const int VFX_DUR_AURA_PULSE_YELLOW_WHITE = 515;
    public const int VFX_DUR_AURA_PULSE_MAGENTA_WHITE = 516;
    public const int VFX_DUR_AURA_PULSE_CYAN_WHITE = 517;
    public const int VFX_DUR_AURA_PULSE_ORANGE_WHITE = 518;
    public const int VFX_DUR_AURA_PULSE_BROWN_WHITE = 519;
    public const int VFX_DUR_AURA_PULSE_PURPLE_WHITE = 520;
    public const int VFX_DUR_AURA_PULSE_GREY_WHITE = 521;
    public const int VFX_DUR_AURA_PULSE_GREY_BLACK = 522;
    public const int VFX_DUR_AURA_PULSE_BLUE_GREEN = 523;
    public const int VFX_DUR_AURA_PULSE_RED_BLUE = 524;
    public const int VFX_DUR_AURA_PULSE_RED_YELLOW = 525;
    public const int VFX_DUR_AURA_PULSE_GREEN_YELLOW = 526;
    public const int VFX_DUR_AURA_PULSE_RED_GREEN = 527;
    public const int VFX_DUR_AURA_PULSE_BLUE_YELLOW = 528;
    public const int VFX_DUR_AURA_PULSE_BLUE_BLACK = 529;
    public const int VFX_DUR_AURA_PULSE_RED_BLACK = 530;
    public const int VFX_DUR_AURA_PULSE_GREEN_BLACK = 531;
    public const int VFX_DUR_AURA_PULSE_YELLOW_BLACK = 532;
    public const int VFX_DUR_AURA_PULSE_MAGENTA_BLACK = 533;
    public const int VFX_DUR_AURA_PULSE_CYAN_BLACK = 534;
    public const int VFX_DUR_AURA_PULSE_ORANGE_BLACK = 535;
    public const int VFX_DUR_AURA_PULSE_BROWN_BLACK = 536;
    public const int VFX_DUR_AURA_PULSE_PURPLE_BLACK = 537;
    public const int VFX_DUR_AURA_PULSE_CYAN_GREEN = 538;
    public const int VFX_DUR_AURA_PULSE_CYAN_BLUE = 539;
    public const int VFX_DUR_AURA_PULSE_CYAN_RED = 540;
    public const int VFX_DUR_AURA_PULSE_CYAN_YELLOW = 541;
    public const int VFX_DUR_AURA_PULSE_MAGENTA_BLUE = 542;
    public const int VFX_DUR_AURA_PULSE_MAGENTA_RED = 543;
    public const int VFX_DUR_AURA_PULSE_MAGENTA_GREEN = 544;
    public const int VFX_DUR_AURA_PULSE_MAGENTA_YELLOW = 545;
    public const int VFX_DUR_AURA_PULSE_RED_ORANGE = 546;
    public const int VFX_DUR_AURA_PULSE_YELLOW_ORANGE = 547;
    public const int VFX_DUR_AURA_RED = 548;
    public const int VFX_DUR_AURA_GREEN = 549;
    public const int VFX_DUR_AURA_BLUE = 550;
    public const int VFX_DUR_AURA_MAGENTA = 551;
    public const int VFX_DUR_AURA_YELLOW = 552;
    public const int VFX_DUR_AURA_WHITE = 553;
    public const int VFX_DUR_AURA_ORANGE = 554;
    public const int VFX_DUR_AURA_BROWN = 555;
    public const int VFX_DUR_AURA_PURPLE = 556;
    public const int VFX_DUR_AURA_CYAN = 557;
    public const int VFX_DUR_AURA_GREEN_DARK = 558;
    public const int VFX_DUR_AURA_GREEN_LIGHT = 559;
    public const int VFX_DUR_AURA_RED_DARK = 560;
    public const int VFX_DUR_AURA_RED_LIGHT = 561;
    public const int VFX_DUR_AURA_BLUE_DARK = 562;
    public const int VFX_DUR_AURA_BLUE_LIGHT = 563;
    public const int VFX_DUR_AURA_YELLOW_DARK = 564;
    public const int VFX_DUR_AURA_YELLOW_LIGHT = 565;
    public const int VFX_DUR_BUBBLES = 566;
    public const int VFX_EYES_GREEN_HUMAN_MALE = 567;
    public const int VFX_EYES_GREEN_HUMAN_FEMALE = 568;
    public const int VFX_EYES_GREEN_HALFELF_MALE = 567;
    public const int VFX_EYES_GREEN_HALFELF_FEMALE = 568;
    public const int VFX_EYES_GREEN_DWARF_MALE = 569;
    public const int VFX_EYES_GREEN_DWARF_FEMALE = 570;
    public const int VFX_EYES_GREEN_ELF_MALE = 571;
    public const int VFX_EYES_GREEN_ELF_FEMALE = 572;
    public const int VFX_EYES_GREEN_GNOME_MALE = 573;
    public const int VFX_EYES_GREEN_GNOME_FEMALE = 574;
    public const int VFX_EYES_GREEN_HALFLING_MALE = 575;
    public const int VFX_EYES_GREEN_HALFLING_FEMALE = 576;
    public const int VFX_EYES_GREEN_HALFORC_MALE = 577;
    public const int VFX_EYES_GREEN_HALFORC_FEMALE = 578;
    public const int VFX_EYES_GREEN_TROGLODYTE = 579;
    public const int VFX_EYES_PUR_HUMAN_MALE = 580;
    public const int VFX_EYES_PUR_HUMAN_FEMALE = 581;
    public const int VFX_EYES_PUR_DWARF_MALE = 582;
    public const int VFX_EYES_PUR_DWARF_FEMALE = 583;
    public const int VFX_EYES_PUR_ELF_MALE = 584;
    public const int VFX_EYES_PUR_ELF_FEMALE = 585;
    public const int VFX_EYES_PUR_GNOME_MALE = 586;
    public const int VFX_EYES_PUR_GNOME_FEMALE = 587;
    public const int VFX_EYES_PUR_HALFLING_MALE = 588;
    public const int VFX_EYES_PUR_HALFLING_FEMALE = 589;
    public const int VFX_EYES_PUR_HALFORC_MALE = 590;
    public const int VFX_EYES_PUR_HALFORC_FEMALE = 591;
    public const int VFX_EYES_PUR_TROGLODYTE = 592;
    public const int VFX_EYES_CYN_HUMAN_MALE = 593;
    public const int VFX_EYES_CYN_HUMAN_FEMALE = 594;
    public const int VFX_EYES_CYN_DWARF_MALE = 595;
    public const int VFX_EYES_CYN_DWARF_FEMALE = 596;
    public const int VFX_EYES_CYN_ELF_MALE = 597;
    public const int VFX_EYES_CYN_ELF_FEMALE = 598;
    public const int VFX_EYES_CYN_GNOME_MALE = 599;
    public const int VFX_EYES_CYN_GNOME_FEMALE = 600;
    public const int VFX_EYES_CYN_HALFLING_MALE = 601;
    public const int VFX_EYES_CYN_HALFLING_FEMALE = 602;
    public const int VFX_EYES_CYN_HALFORC_MALE = 603;
    public const int VFX_EYES_CYN_HALFORC_FEMALE = 604;
    public const int VFX_EYES_CYN_TROGLODYTE = 605;
    public const int VFX_EYES_WHT_HUMAN_MALE = 606;
    public const int VFX_EYES_WHT_HUMAN_FEMALE = 607;
    public const int VFX_EYES_WHT_DWARF_MALE = 608;
    public const int VFX_EYES_WHT_DWARF_FEMALE = 609;
    public const int VFX_EYES_WHT_ELF_MALE = 610;
    public const int VFX_EYES_WHT_ELF_FEMALE = 611;
    public const int VFX_EYES_WHT_GNOME_MALE = 612;
    public const int VFX_EYES_WHT_GNOME_FEMALE = 613;
    public const int VFX_EYES_WHT_HALFLING_MALE = 614;
    public const int VFX_EYES_WHT_HALFLING_FEMALE = 615;
    public const int VFX_EYES_WHT_HALFORC_MALE = 616;
    public const int VFX_EYES_WHT_HALFORC_FEMALE = 617;
    public const int VFX_EYES_WHT_TROGLODYTE = 618;
    public const int VFX_IMP_PDK_GENERIC_PULSE = 623;
    public const int VFX_IMP_PDK_GENERIC_HEAD_HIT = 624;
    public const int VFX_IMP_PDK_RALLYING_CRY = 625;
    public const int VFX_IMP_PDK_HEROIC_SHIELD = 626;
    public const int VFX_IMP_PDK_INSPIRE_COURAGE = 627;
    public const int VFX_DUR_PDK_FEAR = 628;
    public const int VFX_IMP_PDK_WRATH = 629;
    public const int VFX_IMP_PDK_OATH = 630;
    public const int VFX_IMP_PDK_FINAL_STAND = 631;
    public const int VFX_DUR_ARROW_IN_STERNUM = 632;
    public const int VFX_DUR_ARROW_IN_CHEST_LEFT = 633;
    public const int VFX_DUR_ARROW_IN_CHEST_RIGHT = 634;
    public const int VFX_DUR_ARROW_IN_BACK = 635;
    public const int VFX_DUR_ARROW_IN_TEMPLES = 636;
    public const int VFX_DUR_ARROW_IN_FACE = 637;
    public const int VFX_DUR_ARROW_IN_HEAD = 638;
    public const int VFX_DUR_QUILL_IN_CHEST = 639;
    public const int VFX_IMP_STARBURST_GREEN = 644;
    public const int VFX_IMP_STARBURST_RED = 645;
    public const int VFX_IMP_NIGHTMARE_HEAD_HIT = 670;

    /// VFX_Persistent.2da
    public const int AOE_PER_FOGACID = 0;
    public const int AOE_PER_FOGFIRE = 1;
    public const int AOE_PER_FOGSTINK = 2;
    public const int AOE_PER_FOGKILL = 3;
    public const int AOE_PER_FOGMIND = 4;
    public const int AOE_PER_WALLFIRE = 5;
    public const int AOE_PER_WALLWIND = 6;
    public const int AOE_PER_WALLBLADE = 7;
    public const int AOE_PER_WEB = 8;
    public const int AOE_PER_ENTANGLE = 9;

    /// int AOE_PER_CHAOS = 10;
    public const int AOE_PER_DARKNESS = 11;
    public const int AOE_MOB_CIRCEVIL = 12;
    public const int AOE_MOB_CIRCGOOD = 13;
    public const int AOE_MOB_CIRCLAW = 14;
    public const int AOE_MOB_CIRCCHAOS = 15;
    public const int AOE_MOB_FEAR = 16;
    public const int AOE_MOB_BLINDING = 17;
    public const int AOE_MOB_UNEARTHLY = 18;
    public const int AOE_MOB_MENACE = 19;
    public const int AOE_MOB_UNNATURAL = 20;
    public const int AOE_MOB_STUN = 21;
    public const int AOE_MOB_PROTECTION = 22;
    public const int AOE_MOB_FIRE = 23;
    public const int AOE_MOB_FROST = 24;
    public const int AOE_MOB_ELECTRICAL = 25;
    public const int AOE_PER_FOGGHOUL = 26;
    public const int AOE_MOB_TYRANT_FOG = 27;
    public const int AOE_PER_STORM = 28;
    public const int AOE_PER_INVIS_SPHERE = 29;
    public const int AOE_MOB_SILENCE = 30;
    public const int AOE_PER_DELAY_BLAST_FIREBALL = 31;
    public const int AOE_PER_GREASE = 32;
    public const int AOE_PER_CREEPING_DOOM = 33;
    public const int AOE_PER_EVARDS_BLACK_TENTACLES = 34;
    public const int AOE_MOB_INVISIBILITY_PURGE = 35;
    public const int AOE_MOB_DRAGON_FEAR = 36;
    public const int AOE_PER_CUSTOM_AOE = 37;
    public const int AOE_PER_GLYPH_OF_WARDING = 38;
    public const int AOE_PER_FOG_OF_BEWILDERMENT = 39;
    public const int AOE_PER_VINE_MINE_CAMOUFLAGE = 40;
    public const int AOE_MOB_TIDE_OF_BATTLE = 41;
    public const int AOE_PER_STONEHOLD = 42;
    public const int AOE_PER_OVERMIND = 43;
    public const int AOE_MOB_HORRIFICAPPEARANCE = 44;
    public const int AOE_MOB_TROGLODYTE_STENCH = 45;
    public const int SPELL_ALL_SPELLS = -1;

    ///  used for spell immunity.
    public const int SPELL_ACID_FOG = 0;
    public const int SPELL_AID = 1;
    public const int SPELL_ANIMATE_DEAD = 2;
    public const int SPELL_BARKSKIN = 3;
    public const int SPELL_BESTOW_CURSE = 4;
    public const int SPELL_BLADE_BARRIER = 5;
    public const int SPELL_BLESS = 6;
    public const int SPELL_BLESS_WEAPON = 537;
    public const int SPELL_BLINDNESS_AND_DEAFNESS = 8;
    public const int SPELL_BULLS_STRENGTH = 9;
    public const int SPELL_BURNING_HANDS = 10;
    public const int SPELL_CALL_LIGHTNING = 11;

    /// int SPELL_CALM_EMOTIONS = 12;
    public const int SPELL_CATS_GRACE = 13;
    public const int SPELL_CHAIN_LIGHTNING = 14;
    public const int SPELL_CHARM_MONSTER = 15;
    public const int SPELL_CHARM_PERSON = 16;
    public const int SPELL_CHARM_PERSON_OR_ANIMAL = 17;
    public const int SPELL_CIRCLE_OF_DEATH = 18;
    public const int SPELL_CIRCLE_OF_DOOM = 19;
    public const int SPELL_CLAIRAUDIENCE_AND_CLAIRVOYANCE = 20;
    public const int SPELL_CLARITY = 21;
    public const int SPELL_CLOAK_OF_CHAOS = 22;
    public const int SPELL_CLOUDKILL = 23;
    public const int SPELL_COLOR_SPRAY = 24;
    public const int SPELL_CONE_OF_COLD = 25;
    public const int SPELL_CONFUSION = 26;
    public const int SPELL_CONTAGION = 27;
    public const int SPELL_CONTROL_UNDEAD = 28;
    public const int SPELL_CREATE_GREATER_UNDEAD = 29;
    public const int SPELL_CREATE_UNDEAD = 30;
    public const int SPELL_CURE_CRITICAL_WOUNDS = 31;
    public const int SPELL_CURE_LIGHT_WOUNDS = 32;
    public const int SPELL_CURE_MINOR_WOUNDS = 33;
    public const int SPELL_CURE_MODERATE_WOUNDS = 34;
    public const int SPELL_CURE_SERIOUS_WOUNDS = 35;
    public const int SPELL_DARKNESS = 36;
    public const int SPELL_DAZE = 37;
    public const int SPELL_DEATH_WARD = 38;
    public const int SPELL_DELAYED_BLAST_FIREBALL = 39;
    public const int SPELL_DISMISSAL = 40;
    public const int SPELL_DISPEL_MAGIC = 41;
    public const int SPELL_DIVINE_POWER = 42;
    public const int SPELL_DOMINATE_ANIMAL = 43;
    public const int SPELL_DOMINATE_MONSTER = 44;
    public const int SPELL_DOMINATE_PERSON = 45;
    public const int SPELL_DOOM = 46;
    public const int SPELL_ELEMENTAL_SHIELD = 47;
    public const int SPELL_ELEMENTAL_SWARM = 48;
    public const int SPELL_ENDURANCE = 49;
    public const int SPELL_ENDURE_ELEMENTS = 50;
    public const int SPELL_ENERGY_DRAIN = 51;
    public const int SPELL_ENERVATION = 52;
    public const int SPELL_ENTANGLE = 53;
    public const int SPELL_FEAR = 54;
    public const int SPELL_FEEBLEMIND = 55;
    public const int SPELL_FINGER_OF_DEATH = 56;
    public const int SPELL_FIRE_STORM = 57;
    public const int SPELL_FIREBALL = 58;
    public const int SPELL_FLAME_ARROW = 59;
    public const int SPELL_FLAME_LASH = 60;
    public const int SPELL_FLAME_STRIKE = 61;
    public const int SPELL_FREEDOM_OF_MOVEMENT = 62;
    public const int SPELL_GATE = 63;
    public const int SPELL_GHOUL_TOUCH = 64;
    public const int SPELL_GLOBE_OF_INVULNERABILITY = 65;
    public const int SPELL_GREASE = 66;
    public const int SPELL_GREATER_DISPELLING = 67;

    /// int SPELL_GREATER_MAGIC_WEAPON              = 68;
    public const int SPELL_GREATER_PLANAR_BINDING = 69;
    public const int SPELL_GREATER_RESTORATION = 70;

    /// int SPELL_GREATER_SHADOW_CONJURATION = 71;
    public const int SPELL_GREATER_SPELL_BREACH = 72;
    public const int SPELL_GREATER_SPELL_MANTLE = 73;
    public const int SPELL_GREATER_STONESKIN = 74;
    public const int SPELL_GUST_OF_WIND = 75;
    public const int SPELL_HAMMER_OF_THE_GODS = 76;
    public const int SPELL_HARM = 77;
    public const int SPELL_HASTE = 78;
    public const int SPELL_HEAL = 79;
    public const int SPELL_HEALING_CIRCLE = 80;
    public const int SPELL_HOLD_ANIMAL = 81;
    public const int SPELL_HOLD_MONSTER = 82;
    public const int SPELL_HOLD_PERSON = 83;
    public const int SPELL_HOLY_AURA = 84;
    public const int SPELL_HOLY_SWORD = 538;
    public const int SPELL_IDENTIFY = 86;
    public const int SPELL_IMPLOSION = 87;
    public const int SPELL_IMPROVED_INVISIBILITY = 88;
    public const int SPELL_INCENDIARY_CLOUD = 89;
    public const int SPELL_INVISIBILITY = 90;
    public const int SPELL_INVISIBILITY_PURGE = 91;
    public const int SPELL_INVISIBILITY_SPHERE = 92;
    public const int SPELL_KNOCK = 93;
    public const int SPELL_LESSER_DISPEL = 94;
    public const int SPELL_LESSER_MIND_BLANK = 95;
    public const int SPELL_LESSER_PLANAR_BINDING = 96;
    public const int SPELL_LESSER_RESTORATION = 97;
    public const int SPELL_LESSER_SPELL_BREACH = 98;
    public const int SPELL_LESSER_SPELL_MANTLE = 99;
    public const int SPELL_LIGHT = 100;
    public const int SPELL_LIGHTNING_BOLT = 101;
    public const int SPELL_MAGE_ARMOR = 102;
    public const int SPELL_MAGIC_CIRCLE_AGAINST_CHAOS = 103;
    public const int SPELL_MAGIC_CIRCLE_AGAINST_EVIL = 104;
    public const int SPELL_MAGIC_CIRCLE_AGAINST_GOOD = 105;
    public const int SPELL_MAGIC_CIRCLE_AGAINST_LAW = 106;
    public const int SPELL_MAGIC_MISSILE = 107;
    public const int SPELL_MAGIC_VESTMENT = 546;

    /// int SPELL_MAGIC_WEAPON                      = 109;
    public const int SPELL_MASS_BLINDNESS_AND_DEAFNESS = 110;
    public const int SPELL_MASS_CHARM = 111;

    ///  int SPELL_MASS_DOMINATION = 112;
    public const int SPELL_MASS_HASTE = 113;
    public const int SPELL_MASS_HEAL = 114;
    public const int SPELL_MELFS_ACID_ARROW = 115;
    public const int SPELL_METEOR_SWARM = 116;
    public const int SPELL_MIND_BLANK = 117;
    public const int SPELL_MIND_FOG = 118;
    public const int SPELL_MINOR_GLOBE_OF_INVULNERABILITY = 119;
    public const int SPELL_GHOSTLY_VISAGE = 120;
    public const int SPELL_ETHEREAL_VISAGE = 121;
    public const int SPELL_MORDENKAINENS_DISJUNCTION = 122;
    public const int SPELL_MORDENKAINENS_SWORD = 123;
    public const int SPELL_NATURES_BALANCE = 124;
    public const int SPELL_NEGATIVE_ENERGY_PROTECTION = 125;
    public const int SPELL_NEUTRALIZE_POISON = 126;
    public const int SPELL_PHANTASMAL_KILLER = 127;
    public const int SPELL_PLANAR_BINDING = 128;
    public const int SPELL_POISON = 129;
    public const int SPELL_POLYMORPH_SELF = 130;
    public const int SPELL_POWER_WORD_KILL = 131;
    public const int SPELL_POWER_WORD_STUN = 132;
    public const int SPELL_PRAYER = 133;
    public const int SPELL_PREMONITION = 134;
    public const int SPELL_PRISMATIC_SPRAY = 135;
    public const int SPELL_PROTECTION__FROM_CHAOS = 136;
    public const int SPELL_PROTECTION_FROM_ELEMENTS = 137;
    public const int SPELL_PROTECTION_FROM_EVIL = 138;
    public const int SPELL_PROTECTION_FROM_GOOD = 139;
    public const int SPELL_PROTECTION_FROM_LAW = 140;
    public const int SPELL_PROTECTION_FROM_SPELLS = 141;
    public const int SPELL_RAISE_DEAD = 142;
    public const int SPELL_RAY_OF_ENFEEBLEMENT = 143;
    public const int SPELL_RAY_OF_FROST = 144;
    public const int SPELL_REMOVE_BLINDNESS_AND_DEAFNESS = 145;
    public const int SPELL_REMOVE_CURSE = 146;
    public const int SPELL_REMOVE_DISEASE = 147;
    public const int SPELL_REMOVE_FEAR = 148;
    public const int SPELL_REMOVE_PARALYSIS = 149;
    public const int SPELL_RESIST_ELEMENTS = 150;
    public const int SPELL_RESISTANCE = 151;
    public const int SPELL_RESTORATION = 152;
    public const int SPELL_RESURRECTION = 153;
    public const int SPELL_SANCTUARY = 154;
    public const int SPELL_SCARE = 155;
    public const int SPELL_SEARING_LIGHT = 156;
    public const int SPELL_SEE_INVISIBILITY = 157;

    /// int SPELL_SHADES = 158;<br/>
    /// int SPELL_SHADOW_CONJURATION = 159;
    public const int SPELL_SHADOW_SHIELD = 160;
    public const int SPELL_SHAPECHANGE = 161;
    public const int SPELL_SHIELD_OF_LAW = 162;
    public const int SPELL_SILENCE = 163;
    public const int SPELL_SLAY_LIVING = 164;
    public const int SPELL_SLEEP = 165;
    public const int SPELL_SLOW = 166;
    public const int SPELL_SOUND_BURST = 167;
    public const int SPELL_SPELL_RESISTANCE = 168;
    public const int SPELL_SPELL_MANTLE = 169;
    public const int SPELL_SPHERE_OF_CHAOS = 170;
    public const int SPELL_STINKING_CLOUD = 171;
    public const int SPELL_STONESKIN = 172;
    public const int SPELL_STORM_OF_VENGEANCE = 173;
    public const int SPELL_SUMMON_CREATURE_I = 174;
    public const int SPELL_SUMMON_CREATURE_II = 175;
    public const int SPELL_SUMMON_CREATURE_III = 176;
    public const int SPELL_SUMMON_CREATURE_IV = 177;
    public const int SPELL_SUMMON_CREATURE_IX = 178;
    public const int SPELL_SUMMON_CREATURE_V = 179;
    public const int SPELL_SUMMON_CREATURE_VI = 180;
    public const int SPELL_SUMMON_CREATURE_VII = 181;
    public const int SPELL_SUMMON_CREATURE_VIII = 182;
    public const int SPELL_SUNBEAM = 183;
    public const int SPELL_TENSERS_TRANSFORMATION = 184;
    public const int SPELL_TIME_STOP = 185;
    public const int SPELL_TRUE_SEEING = 186;
    public const int SPELL_UNHOLY_AURA = 187;
    public const int SPELL_VAMPIRIC_TOUCH = 188;
    public const int SPELL_VIRTUE = 189;
    public const int SPELL_WAIL_OF_THE_BANSHEE = 190;
    public const int SPELL_WALL_OF_FIRE = 191;
    public const int SPELL_WEB = 192;
    public const int SPELL_WEIRD = 193;
    public const int SPELL_WORD_OF_FAITH = 194;
    public const int SPELLABILITY_AURA_BLINDING = 195;
    public const int SPELLABILITY_AURA_COLD = 196;
    public const int SPELLABILITY_AURA_ELECTRICITY = 197;
    public const int SPELLABILITY_AURA_FEAR = 198;
    public const int SPELLABILITY_AURA_FIRE = 199;
    public const int SPELLABILITY_AURA_MENACE = 200;
    public const int SPELLABILITY_AURA_PROTECTION = 201;
    public const int SPELLABILITY_AURA_STUN = 202;
    public const int SPELLABILITY_AURA_UNEARTHLY_VISAGE = 203;
    public const int SPELLABILITY_AURA_UNNATURAL = 204;
    public const int SPELLABILITY_BOLT_ABILITY_DRAIN_CHARISMA = 205;
    public const int SPELLABILITY_BOLT_ABILITY_DRAIN_CONSTITUTION = 206;
    public const int SPELLABILITY_BOLT_ABILITY_DRAIN_DEXTERITY = 207;
    public const int SPELLABILITY_BOLT_ABILITY_DRAIN_INTELLIGENCE = 208;
    public const int SPELLABILITY_BOLT_ABILITY_DRAIN_STRENGTH = 209;
    public const int SPELLABILITY_BOLT_ABILITY_DRAIN_WISDOM = 210;
    public const int SPELLABILITY_BOLT_ACID = 211;
    public const int SPELLABILITY_BOLT_CHARM = 212;
    public const int SPELLABILITY_BOLT_COLD = 213;
    public const int SPELLABILITY_BOLT_CONFUSE = 214;
    public const int SPELLABILITY_BOLT_DAZE = 215;
    public const int SPELLABILITY_BOLT_DEATH = 216;
    public const int SPELLABILITY_BOLT_DISEASE = 217;
    public const int SPELLABILITY_BOLT_DOMINATE = 218;
    public const int SPELLABILITY_BOLT_FIRE = 219;
    public const int SPELLABILITY_BOLT_KNOCKDOWN = 220;
    public const int SPELLABILITY_BOLT_LEVEL_DRAIN = 221;
    public const int SPELLABILITY_BOLT_LIGHTNING = 222;
    public const int SPELLABILITY_BOLT_PARALYZE = 223;
    public const int SPELLABILITY_BOLT_POISON = 224;
    public const int SPELLABILITY_BOLT_SHARDS = 225;
    public const int SPELLABILITY_BOLT_SLOW = 226;
    public const int SPELLABILITY_BOLT_STUN = 227;
    public const int SPELLABILITY_BOLT_WEB = 228;
    public const int SPELLABILITY_CONE_ACID = 229;
    public const int SPELLABILITY_CONE_COLD = 230;
    public const int SPELLABILITY_CONE_DISEASE = 231;
    public const int SPELLABILITY_CONE_FIRE = 232;
    public const int SPELLABILITY_CONE_LIGHTNING = 233;
    public const int SPELLABILITY_CONE_POISON = 234;
    public const int SPELLABILITY_CONE_SONIC = 235;
    public const int SPELLABILITY_DRAGON_BREATH_ACID = 236;
    public const int SPELLABILITY_DRAGON_BREATH_COLD = 237;
    public const int SPELLABILITY_DRAGON_BREATH_FEAR = 238;
    public const int SPELLABILITY_DRAGON_BREATH_FIRE = 239;
    public const int SPELLABILITY_DRAGON_BREATH_GAS = 240;
    public const int SPELLABILITY_DRAGON_BREATH_LIGHTNING = 241;
    public const int SPELLABILITY_DRAGON_BREATH_PARALYZE = 242;
    public const int SPELLABILITY_DRAGON_BREATH_SLEEP = 243;
    public const int SPELLABILITY_DRAGON_BREATH_SLOW = 244;
    public const int SPELLABILITY_DRAGON_BREATH_WEAKEN = 245;
    public const int SPELLABILITY_DRAGON_WING_BUFFET = 246;
    public const int SPELLABILITY_FEROCITY_1 = 247;
    public const int SPELLABILITY_FEROCITY_2 = 248;
    public const int SPELLABILITY_FEROCITY_3 = 249;
    public const int SPELLABILITY_GAZE_CHARM = 250;
    public const int SPELLABILITY_GAZE_CONFUSION = 251;
    public const int SPELLABILITY_GAZE_DAZE = 252;
    public const int SPELLABILITY_GAZE_DEATH = 253;
    public const int SPELLABILITY_GAZE_DESTROY_CHAOS = 254;
    public const int SPELLABILITY_GAZE_DESTROY_EVIL = 255;
    public const int SPELLABILITY_GAZE_DESTROY_GOOD = 256;
    public const int SPELLABILITY_GAZE_DESTROY_LAW = 257;
    public const int SPELLABILITY_GAZE_DOMINATE = 258;
    public const int SPELLABILITY_GAZE_DOOM = 259;
    public const int SPELLABILITY_GAZE_FEAR = 260;
    public const int SPELLABILITY_GAZE_PARALYSIS = 261;
    public const int SPELLABILITY_GAZE_STUNNED = 262;
    public const int SPELLABILITY_GOLEM_BREATH_GAS = 263;
    public const int SPELLABILITY_HELL_HOUND_FIREBREATH = 264;
    public const int SPELLABILITY_HOWL_CONFUSE = 265;
    public const int SPELLABILITY_HOWL_DAZE = 266;
    public const int SPELLABILITY_HOWL_DEATH = 267;
    public const int SPELLABILITY_HOWL_DOOM = 268;
    public const int SPELLABILITY_HOWL_FEAR = 269;
    public const int SPELLABILITY_HOWL_PARALYSIS = 270;
    public const int SPELLABILITY_HOWL_SONIC = 271;
    public const int SPELLABILITY_HOWL_STUN = 272;
    public const int SPELLABILITY_INTENSITY_1 = 273;
    public const int SPELLABILITY_INTENSITY_2 = 274;
    public const int SPELLABILITY_INTENSITY_3 = 275;
    public const int SPELLABILITY_KRENSHAR_SCARE = 276;
    public const int SPELLABILITY_LESSER_BODY_ADJUSTMENT = 277;
    public const int SPELLABILITY_MEPHIT_SALT_BREATH = 278;
    public const int SPELLABILITY_MEPHIT_STEAM_BREATH = 279;
    public const int SPELLABILITY_MUMMY_BOLSTER_UNDEAD = 280;
    public const int SPELLABILITY_PULSE_DROWN = 281;
    public const int SPELLABILITY_PULSE_SPORES = 282;
    public const int SPELLABILITY_PULSE_WHIRLWIND = 283;
    public const int SPELLABILITY_PULSE_FIRE = 284;
    public const int SPELLABILITY_PULSE_LIGHTNING = 285;
    public const int SPELLABILITY_PULSE_COLD = 286;
    public const int SPELLABILITY_PULSE_NEGATIVE = 287;
    public const int SPELLABILITY_PULSE_HOLY = 288;
    public const int SPELLABILITY_PULSE_DEATH = 289;
    public const int SPELLABILITY_PULSE_LEVEL_DRAIN = 290;
    public const int SPELLABILITY_PULSE_ABILITY_DRAIN_INTELLIGENCE = 291;
    public const int SPELLABILITY_PULSE_ABILITY_DRAIN_CHARISMA = 292;
    public const int SPELLABILITY_PULSE_ABILITY_DRAIN_CONSTITUTION = 293;
    public const int SPELLABILITY_PULSE_ABILITY_DRAIN_DEXTERITY = 294;
    public const int SPELLABILITY_PULSE_ABILITY_DRAIN_STRENGTH = 295;
    public const int SPELLABILITY_PULSE_ABILITY_DRAIN_WISDOM = 296;
    public const int SPELLABILITY_PULSE_POISON = 297;
    public const int SPELLABILITY_PULSE_DISEASE = 298;
    public const int SPELLABILITY_RAGE_3 = 299;
    public const int SPELLABILITY_RAGE_4 = 300;
    public const int SPELLABILITY_RAGE_5 = 301;
    public const int SPELLABILITY_SMOKE_CLAW = 302;
    public const int SPELLABILITY_SUMMON_SLAAD = 303;
    public const int SPELLABILITY_SUMMON_TANARRI = 304;
    public const int SPELLABILITY_TRUMPET_BLAST = 305;
    public const int SPELLABILITY_TYRANT_FOG_MIST = 306;
    public const int SPELLABILITY_BARBARIAN_RAGE = 307;
    public const int SPELLABILITY_TURN_UNDEAD = 308;
    public const int SPELLABILITY_WHOLENESS_OF_BODY = 309;
    public const int SPELLABILITY_QUIVERING_PALM = 310;
    public const int SPELLABILITY_EMPTY_BODY = 311;
    public const int SPELLABILITY_DETECT_EVIL = 312;
    public const int SPELLABILITY_LAY_ON_HANDS = 313;
    public const int SPELLABILITY_AURA_OF_COURAGE = 314;
    public const int SPELLABILITY_SMITE_EVIL = 315;
    public const int SPELLABILITY_REMOVE_DISEASE = 316;
    public const int SPELLABILITY_SUMMON_ANIMAL_COMPANION = 317;
    public const int SPELLABILITY_SUMMON_FAMILIAR = 318;
    public const int SPELLABILITY_ELEMENTAL_SHAPE = 319;
    public const int SPELLABILITY_WILD_SHAPE = 320;

    /// int SPELL_PROTECTION_FROM_ALIGNMENT = 321;<br/>
    /// int SPELL_MAGIC_CIRCLE_AGAINST_ALIGNMENT = 322;<br/>
    /// int SPELL_AURA_VERSUS_ALIGNMENT = 323;
    public const int SPELL_SHADES_SUMMON_SHADOW = 324;

    /// int SPELL_PROTECTION_FROM_ELEMENTS_COLD = 325;<br/>
    /// int SPELL_PROTECTION_FROM_ELEMENTS_FIRE = 326;<br/>
    /// int SPELL_PROTECTION_FROM_ELEMENTS_ACID = 327;<br/>
    /// int SPELL_PROTECTION_FROM_ELEMENTS_SONIC = 328;<br/>
    /// int SPELL_PROTECTION_FROM_ELEMENTS_ELECTRICITY = 329;<br/>
    /// int SPELL_ENDURE_ELEMENTS_COLD = 330;<br/>
    /// int SPELL_ENDURE_ELEMENTS_FIRE = 331;<br/>
    /// int SPELL_ENDURE_ELEMENTS_ACID = 332;<br/>
    /// int SPELL_ENDURE_ELEMENTS_SONIC = 333;<br/>
    /// int SPELL_ENDURE_ELEMENTS_ELECTRICITY = 334;<br/>
    /// int SPELL_RESIST_ELEMENTS_COLD = 335;<br/>
    /// int SPELL_RESIST_ELEMENTS_FIRE = 336;<br/>
    /// int SPELL_RESIST_ELEMENTS_ACID = 337;<br/>
    /// int SPELL_RESIST_ELEMENTS_SONIC = 338;<br/>
    /// int SPELL_RESIST_ELEMENTS_ELECTRICITY = 339;
    public const int SPELL_SHADES_CONE_OF_COLD = 340;
    public const int SPELL_SHADES_FIREBALL = 341;
    public const int SPELL_SHADES_STONESKIN = 342;
    public const int SPELL_SHADES_WALL_OF_FIRE = 343;
    public const int SPELL_SHADOW_CONJURATION_SUMMON_SHADOW = 344;
    public const int SPELL_SHADOW_CONJURATION_DARKNESS = 345;
    public const int SPELL_SHADOW_CONJURATION_INIVSIBILITY = 346;
    public const int SPELL_SHADOW_CONJURATION_MAGE_ARMOR = 347;
    public const int SPELL_SHADOW_CONJURATION_MAGIC_MISSILE = 348;
    public const int SPELL_GREATER_SHADOW_CONJURATION_SUMMON_SHADOW = 349;
    public const int SPELL_GREATER_SHADOW_CONJURATION_ACID_ARROW = 350;
    public const int SPELL_GREATER_SHADOW_CONJURATION_MIRROR_IMAGE = 351;
    public const int SPELL_GREATER_SHADOW_CONJURATION_WEB = 352;
    public const int SPELL_GREATER_SHADOW_CONJURATION_MINOR_GLOBE = 353;
    public const int SPELL_EAGLE_SPLEDOR = 354;
    public const int SPELL_OWLS_WISDOM = 355;
    public const int SPELL_FOXS_CUNNING = 356;
    public const int SPELL_GREATER_EAGLE_SPLENDOR = 357;
    public const int SPELL_GREATER_OWLS_WISDOM = 358;
    public const int SPELL_GREATER_FOXS_CUNNING = 359;
    public const int SPELL_GREATER_BULLS_STRENGTH = 360;
    public const int SPELL_GREATER_CATS_GRACE = 361;
    public const int SPELL_GREATER_ENDURANCE = 362;
    public const int SPELL_AWAKEN = 363;
    public const int SPELL_CREEPING_DOOM = 364;
    public const int SPELL_DARKVISION = 365;
    public const int SPELL_DESTRUCTION = 366;
    public const int SPELL_HORRID_WILTING = 367;
    public const int SPELL_ICE_STORM = 368;
    public const int SPELL_ENERGY_BUFFER = 369;
    public const int SPELL_NEGATIVE_ENERGY_BURST = 370;
    public const int SPELL_NEGATIVE_ENERGY_RAY = 371;
    public const int SPELL_AURA_OF_VITALITY = 372;
    public const int SPELL_WAR_CRY = 373;
    public const int SPELL_REGENERATE = 374;
    public const int SPELL_EVARDS_BLACK_TENTACLES = 375;
    public const int SPELL_LEGEND_LORE = 376;
    public const int SPELL_FIND_TRAPS = 377;
    public const int SPELLABILITY_SUMMON_MEPHIT = 378;
    public const int SPELLABILITY_SUMMON_CELESTIAL = 379;
    public const int SPELLABILITY_BATTLE_MASTERY = 380;
    public const int SPELLABILITY_DIVINE_STRENGTH = 381;
    public const int SPELLABILITY_DIVINE_PROTECTION = 382;
    public const int SPELLABILITY_NEGATIVE_PLANE_AVATAR = 383;
    public const int SPELLABILITY_DIVINE_TRICKERY = 384;
    public const int SPELLABILITY_ROGUES_CUNNING = 385;
    public const int SPELLABILITY_ACTIVATE_ITEM = 386;
    public const int SPELLABILITY_DRAGON_FEAR = 412;
    public const int SPELL_DIVINE_FAVOR = 414;
    public const int SPELL_TRUE_STRIKE = 415;
    public const int SPELL_FLARE = 416;
    public const int SPELL_SHIELD = 417;
    public const int SPELL_ENTROPIC_SHIELD = 418;
    public const int SPELL_CONTINUAL_FLAME = 419;
    public const int SPELL_ONE_WITH_THE_LAND = 420;
    public const int SPELL_CAMOFLAGE = 421;
    public const int SPELL_BLOOD_FRENZY = 422;
    public const int SPELL_BOMBARDMENT = 423;
    public const int SPELL_ACID_SPLASH = 424;
    public const int SPELL_QUILLFIRE = 425;
    public const int SPELL_EARTHQUAKE = 426;
    public const int SPELL_SUNBURST = 427;
    public const int SPELL_ACTIVATE_ITEM_SELF2 = 428;
    public const int SPELL_AURAOFGLORY = 429;
    public const int SPELL_BANISHMENT = 430;
    public const int SPELL_INFLICT_MINOR_WOUNDS = 431;
    public const int SPELL_INFLICT_LIGHT_WOUNDS = 432;
    public const int SPELL_INFLICT_MODERATE_WOUNDS = 433;
    public const int SPELL_INFLICT_SERIOUS_WOUNDS = 434;
    public const int SPELL_INFLICT_CRITICAL_WOUNDS = 435;
    public const int SPELL_BALAGARNSIRONHORN = 436;
    public const int SPELL_DROWN = 437;
    public const int SPELL_OWLS_INSIGHT = 438;
    public const int SPELL_ELECTRIC_JOLT = 439;
    public const int SPELL_FIREBRAND = 440;
    public const int SPELL_WOUNDING_WHISPERS = 441;
    public const int SPELL_AMPLIFY = 442;
    public const int SPELL_ETHEREALNESS = 443;
    public const int SPELL_UNDEATHS_ETERNAL_FOE = 444;
    public const int SPELL_DIRGE = 445;
    public const int SPELL_INFERNO = 446;
    public const int SPELL_ISAACS_LESSER_MISSILE_STORM = 447;
    public const int SPELL_ISAACS_GREATER_MISSILE_STORM = 448;
    public const int SPELL_BANE = 449;
    public const int SPELL_SHIELD_OF_FAITH = 450;
    public const int SPELL_PLANAR_ALLY = 451;
    public const int SPELL_MAGIC_FANG = 452;
    public const int SPELL_GREATER_MAGIC_FANG = 453;
    public const int SPELL_SPIKE_GROWTH = 454;
    public const int SPELL_MASS_CAMOFLAGE = 455;
    public const int SPELL_EXPEDITIOUS_RETREAT = 456;
    public const int SPELL_TASHAS_HIDEOUS_LAUGHTER = 457;
    public const int SPELL_DISPLACEMENT = 458;
    public const int SPELL_BIGBYS_INTERPOSING_HAND = 459;
    public const int SPELL_BIGBYS_FORCEFUL_HAND = 460;
    public const int SPELL_BIGBYS_GRASPING_HAND = 461;
    public const int SPELL_BIGBYS_CLENCHED_FIST = 462;
    public const int SPELL_BIGBYS_CRUSHING_HAND = 463;
    public const int SPELL_GRENADE_FIRE = 464;
    public const int SPELL_GRENADE_TANGLE = 465;
    public const int SPELL_GRENADE_HOLY = 466;
    public const int SPELL_GRENADE_CHOKING = 467;
    public const int SPELL_GRENADE_THUNDERSTONE = 468;
    public const int SPELL_GRENADE_ACID = 469;
    public const int SPELL_GRENADE_CHICKEN = 470;
    public const int SPELL_GRENADE_CALTROPS = 471;
    public const int SPELL_ACTIVATE_ITEM_PORTAL = 472;
    public const int SPELL_DIVINE_MIGHT = 473;
    public const int SPELL_DIVINE_SHIELD = 474;
    public const int SPELL_SHADOW_DAZE = 475;
    public const int SPELL_SUMMON_SHADOW = 476;
    public const int SPELL_SHADOW_EVADE = 477;
    public const int SPELL_TYMORAS_SMILE = 478;
    public const int SPELL_CRAFT_HARPER_ITEM = 479;
    public const int SPELL_FLESH_TO_STONE = 485;
    public const int SPELL_STONE_TO_FLESH = 486;
    public const int SPELL_TRAP_ARROW = 487;
    public const int SPELL_TRAP_BOLT = 488;
    public const int SPELL_TRAP_DART = 493;
    public const int SPELL_TRAP_SHURIKEN = 494;
    public const int SPELLABILITY_BREATH_PETRIFY = 495;
    public const int SPELLABILITY_TOUCH_PETRIFY = 496;
    public const int SPELLABILITY_GAZE_PETRIFY = 497;
    public const int SPELLABILITY_MANTICORE_SPIKES = 498;
    public const int SPELL_ROD_OF_WONDER = 499;
    public const int SPELL_DECK_OF_MANY_THINGS = 500;
    public const int SPELL_ELEMENTAL_SUMMONING_ITEM = 502;
    public const int SPELL_DECK_AVATAR = 503;
    public const int SPELL_DECK_GEMSPRAY = 504;
    public const int SPELL_DECK_BUTTERFLYSPRAY = 505;
    public const int SPELL_HEALINGKIT = 506;
    public const int SPELL_POWERSTONE = 507;
    public const int SPELL_SPELLSTAFF = 508;
    public const int SPELL_CHARGER = 500;
    public const int SPELL_DECHARGER = 510;
    public const int SPELL_KOBOLD_JUMP = 511;
    public const int SPELL_CRUMBLE = 512;
    public const int SPELL_INFESTATION_OF_MAGGOTS = 513;
    public const int SPELL_HEALING_STING = 514;
    public const int SPELL_GREAT_THUNDERCLAP = 515;
    public const int SPELL_BALL_LIGHTNING = 516;
    public const int SPELL_BATTLETIDE = 517;
    public const int SPELL_COMBUST = 518;
    public const int SPELL_DEATH_ARMOR = 519;
    public const int SPELL_GEDLEES_ELECTRIC_LOOP = 520;
    public const int SPELL_HORIZIKAULS_BOOM = 521;
    public const int SPELL_IRONGUTS = 522;
    public const int SPELL_MESTILS_ACID_BREATH = 523;
    public const int SPELL_MESTILS_ACID_SHEATH = 524;
    public const int SPELL_MONSTROUS_REGENERATION = 525;
    public const int SPELL_SCINTILLATING_SPHERE = 526;
    public const int SPELL_STONE_BONES = 527;
    public const int SPELL_UNDEATH_TO_DEATH = 528;
    public const int SPELL_VINE_MINE = 529;
    public const int SPELL_VINE_MINE_ENTANGLE = 530;
    public const int SPELL_VINE_MINE_HAMPER_MOVEMENT = 531;
    public const int SPELL_VINE_MINE_CAMOUFLAGE = 532;
    public const int SPELL_BLACK_BLADE_OF_DISASTER = 533;
    public const int SPELL_SHELGARNS_PERSISTENT_BLADE = 534;
    public const int SPELL_BLADE_THIRST = 535;
    public const int SPELL_DEAFENING_CLANG = 536;
    public const int SPELL_CLOUD_OF_BEWILDERMENT = 569;
    public const int SPELL_KEEN_EDGE = 539;
    public const int SPELL_BLACKSTAFF = 541;
    public const int SPELL_FLAME_WEAPON = 542;
    public const int SPELL_ICE_DAGGER = 543;
    public const int SPELL_MAGIC_WEAPON = 544;
    public const int SPELL_GREATER_MAGIC_WEAPON = 545;
    public const int SPELL_STONEHOLD = 547;
    public const int SPELL_DARKFIRE = 548;
    public const int SPELL_GLYPH_OF_WARDING = 549;
    public const int SPELLABILITY_MINDBLAST = 551;
    public const int SPELLABILITY_CHARMMONSTER = 552;
    public const int SPELL_IOUN_STONE_DUSTY_ROSE = 554;
    public const int SPELL_IOUN_STONE_PALE_BLUE = 555;
    public const int SPELL_IOUN_STONE_SCARLET_BLUE = 556;
    public const int SPELL_IOUN_STONE_BLUE = 557;
    public const int SPELL_IOUN_STONE_DEEP_RED = 558;
    public const int SPELL_IOUN_STONE_PINK = 559;
    public const int SPELL_IOUN_STONE_PINK_GREEN = 560;
    public const int SPELLABILITY_WHIRLWIND = 561;
    public const int SPELLABILITY_COMMAND_THE_HORDE = 571;
    public const int SPELLABILITY_AA_IMBUE_ARROW = 600;
    public const int SPELLABILITY_AA_SEEKER_ARROW_1 = 601;
    public const int SPELLABILITY_AA_SEEKER_ARROW_2 = 602;
    public const int SPELLABILITY_AA_HAIL_OF_ARROWS = 603;
    public const int SPELLABILITY_AA_ARROW_OF_DEATH = 604;
    public const int SPELLABILITY_AS_GHOSTLY_VISAGE = 605;
    public const int SPELLABILITY_AS_DARKNESS = 606;
    public const int SPELLABILITY_AS_INVISIBILITY = 607;
    public const int SPELLABILITY_AS_IMPROVED_INVISIBLITY = 608;
    public const int SPELLABILITY_BG_CREATEDEAD = 609;
    public const int SPELLABILITY_BG_FIENDISH_SERVANT = 610;
    public const int SPELLABILITY_BG_INFLICT_SERIOUS_WOUNDS = 611;
    public const int SPELLABILITY_BG_INFLICT_CRITICAL_WOUNDS = 612;
    public const int SPELLABILITY_BG_CONTAGION = 613;
    public const int SPELLABILITY_BG_BULLS_STRENGTH = 614;
    public const int SPELL_FLYING_DEBRIS = 620;
    public const int SPELLABILITY_DC_DIVINE_WRATH = 622;
    public const int SPELLABILITY_PM_ANIMATE_DEAD = 623;
    public const int SPELLABILITY_PM_SUMMON_UNDEAD = 624;
    public const int SPELLABILITY_PM_UNDEAD_GRAFT_1 = 625;
    public const int SPELLABILITY_PM_UNDEAD_GRAFT_2 = 626;
    public const int SPELLABILITY_PM_SUMMON_GREATER_UNDEAD = 627;
    public const int SPELLABILITY_PM_DEATHLESS_MASTER_TOUCH = 628;
    public const int SPELL_EPIC_HELLBALL = 636;
    public const int SPELL_EPIC_MUMMY_DUST = 637;
    public const int SPELL_EPIC_DRAGON_KNIGHT = 638;
    public const int SPELL_EPIC_MAGE_ARMOR = 639;
    public const int SPELL_EPIC_RUIN = 640;
    public const int SPELLABILITY_DW_DEFENSIVE_STANCE = 641;
    public const int SPELLABILITY_EPIC_MIGHTY_RAGE = 642;
    public const int SPELLABILITY_EPIC_CURSE_SONG = 644;
    public const int SPELLABILITY_EPIC_IMPROVED_WHIRLWIND = 645;
    public const int SPELLABILITY_EPIC_SHAPE_DRAGONKIN = 646;
    public const int SPELLABILITY_EPIC_SHAPE_DRAGON = 647;
    public const int SPELL_CRAFT_DYE_CLOTHCOLOR_1 = 648;
    public const int SPELL_CRAFT_DYE_CLOTHCOLOR_2 = 649;
    public const int SPELL_CRAFT_DYE_LEATHERCOLOR_1 = 650;
    public const int SPELL_CRAFT_DYE_LEATHERCOLOR_2 = 651;
    public const int SPELL_CRAFT_DYE_METALCOLOR_1 = 652;
    public const int SPELL_CRAFT_DYE_METALCOLOR_2 = 653;
    public const int SPELL_CRAFT_ADD_ITEM_PROPERTY = 654;
    public const int SPELL_CRAFT_POISON_WEAPON_OR_AMMO = 655;
    public const int SPELL_CRAFT_CRAFT_WEAPON_SKILL = 656;
    public const int SPELL_CRAFT_CRAFT_ARMOR_SKILL = 657;
    public const int SPELLABILITY_DRAGON_BREATH_NEGATIVE = 698;
    public const int SPELLABILITY_SEAHAG_EVILEYE = 803;
    public const int SPELLABILITY_AURA_HORRIFICAPPEARANCE = 804;
    public const int SPELLABILITY_TROGLODYTE_STENCH = 805;
    public const int SPELL_HORSE_MENU = 812;
    public const int SPELL_HORSE_MOUNT = 813;
    public const int SPELL_HORSE_DISMOUNT = 814;
    public const int SPELL_HORSE_PARTY_MOUNT = 815;
    public const int SPELL_HORSE_PARTY_DISMOUNT = 816;
    public const int SPELL_HORSE_ASSIGN_MOUNT = 817;
    public const int SPELL_PALADIN_SUMMON_MOUNT = 818;

    ///  these constants must match those in poison.2da
    public const int POISON_NIGHTSHADE = 0;
    public const int POISON_SMALL_CENTIPEDE_POISON = 1;
    public const int POISON_BLADE_BANE = 2;
    public const int POISON_GREENBLOOD_OIL = 3;
    public const int POISON_BLOODROOT = 4;
    public const int POISON_PURPLE_WORM_POISON = 5;
    public const int POISON_LARGE_SCORPION_VENOM = 6;
    public const int POISON_WYVERN_POISON = 7;
    public const int POISON_BLUE_WHINNIS = 8;
    public const int POISON_GIANT_WASP_POISON = 9;
    public const int POISON_SHADOW_ESSENCE = 10;
    public const int POISON_BLACK_ADDER_VENOM = 11;
    public const int POISON_DEATHBLADE = 12;
    public const int POISON_MALYSS_ROOT_PASTE = 13;
    public const int POISON_NITHARIT = 14;
    public const int POISON_DRAGON_BILE = 15;
    public const int POISON_SASSONE_LEAF_RESIDUE = 16;
    public const int POISON_TERINAV_ROOT = 17;
    public const int POISON_CARRION_CRAWLER_BRAIN_JUICE = 18;
    public const int POISON_BLACK_LOTUS_EXTRACT = 19;
    public const int POISON_OIL_OF_TAGGIT = 20;
    public const int POISON_ID_MOSS = 21;
    public const int POISON_STRIPED_TOADSTOOL = 22;
    public const int POISON_ARSENIC = 23;
    public const int POISON_LICH_DUST = 24;
    public const int POISON_DARK_REAVER_POWDER = 25;
    public const int POISON_UNGOL_DUST = 26;
    public const int POISON_BURNT_OTHUR_FUMES = 27;
    public const int POISON_CHAOS_MIST = 28;
    public const int POISON_BEBILITH_VENOM = 29;
    public const int POISON_QUASIT_VENOM = 30;
    public const int POISON_PIT_FIEND_ICHOR = 31;
    public const int POISON_ETTERCAP_VENOM = 32;
    public const int POISON_ARANEA_VENOM = 33;
    public const int POISON_TINY_SPIDER_VENOM = 34;
    public const int POISON_SMALL_SPIDER_VENOM = 35;
    public const int POISON_MEDIUM_SPIDER_VENOM = 36;
    public const int POISON_LARGE_SPIDER_VENOM = 37;
    public const int POISON_HUGE_SPIDER_VENOM = 38;
    public const int POISON_GARGANTUAN_SPIDER_VENOM = 39;
    public const int POISON_COLOSSAL_SPIDER_VENOM = 40;
    public const int POISON_PHASE_SPIDER_VENOM = 41;
    public const int POISON_WRAITH_SPIDER_VENOM = 42;
    public const int POISON_IRON_GOLEM = 43;

    ///  these constants match those in disease.2da
    public const int DISEASE_BLINDING_SICKNESS = 0;
    public const int DISEASE_CACKLE_FEVER = 1;
    public const int DISEASE_DEVIL_CHILLS = 2;
    public const int DISEASE_DEMON_FEVER = 3;
    public const int DISEASE_FILTH_FEVER = 4;
    public const int DISEASE_MINDFIRE = 5;
    public const int DISEASE_MUMMY_ROT = 6;
    public const int DISEASE_RED_ACHE = 7;
    public const int DISEASE_SHAKES = 8;
    public const int DISEASE_SLIMY_DOOM = 9;
    public const int DISEASE_RED_SLAAD_EGGS = 10;
    public const int DISEASE_GHOUL_ROT = 11;
    public const int DISEASE_ZOMBIE_CREEP = 12;
    public const int DISEASE_DREAD_BLISTERS = 13;
    public const int DISEASE_BURROW_MAGGOTS = 14;
    public const int DISEASE_SOLDIER_SHAKES = 15;
    public const int DISEASE_VERMIN_MADNESS = 16;

    ///  the thing after CREATURE_TYPE_ should refer to the<br/>
    ///  actual &amp;quot;subtype&amp;quot; in the lists given above.
    public const int CREATURE_TYPE_RACIAL_TYPE = 0;
    public const int CREATURE_TYPE_PLAYER_CHAR = 1;
    public const int CREATURE_TYPE_CLASS = 2;
    public const int CREATURE_TYPE_REPUTATION = 3;
    public const int CREATURE_TYPE_IS_ALIVE = 4;
    public const int CREATURE_TYPE_HAS_SPELL_EFFECT = 5;
    public const int CREATURE_TYPE_DOES_NOT_HAVE_SPELL_EFFECT = 6;
    public const int CREATURE_TYPE_PERCEPTION = 7;

    /// int CREATURE_TYPE_ALIGNMENT       = 2;
    public const int REPUTATION_TYPE_FRIEND = 0;
    public const int REPUTATION_TYPE_ENEMY = 1;
    public const int REPUTATION_TYPE_NEUTRAL = 2;
    public const int PERCEPTION_SEEN_AND_HEARD = 0;
    public const int PERCEPTION_NOT_SEEN_AND_NOT_HEARD = 1;
    public const int PERCEPTION_HEARD_AND_NOT_SEEN = 2;
    public const int PERCEPTION_SEEN_AND_NOT_HEARD = 3;
    public const int PERCEPTION_NOT_HEARD = 4;
    public const int PERCEPTION_HEARD = 5;
    public const int PERCEPTION_NOT_SEEN = 6;
    public const int PERCEPTION_SEEN = 7;
    public const int PLAYER_CHAR_NOT_PC = FALSE;
    public const int PLAYER_CHAR_IS_PC = TRUE;
    public const int CLASS_TYPE_BARBARIAN = 0;
    public const int CLASS_TYPE_BARD = 1;
    public const int CLASS_TYPE_CLERIC = 2;
    public const int CLASS_TYPE_DRUID = 3;
    public const int CLASS_TYPE_FIGHTER = 4;
    public const int CLASS_TYPE_MONK = 5;
    public const int CLASS_TYPE_PALADIN = 6;
    public const int CLASS_TYPE_RANGER = 7;
    public const int CLASS_TYPE_ROGUE = 8;
    public const int CLASS_TYPE_SORCERER = 9;
    public const int CLASS_TYPE_WIZARD = 10;
    public const int CLASS_TYPE_ABERRATION = 11;
    public const int CLASS_TYPE_ANIMAL = 12;
    public const int CLASS_TYPE_CONSTRUCT = 13;
    public const int CLASS_TYPE_HUMANOID = 14;
    public const int CLASS_TYPE_MONSTROUS = 15;
    public const int CLASS_TYPE_ELEMENTAL = 16;
    public const int CLASS_TYPE_FEY = 17;
    public const int CLASS_TYPE_DRAGON = 18;
    public const int CLASS_TYPE_UNDEAD = 19;
    public const int CLASS_TYPE_COMMONER = 20;
    public const int CLASS_TYPE_BEAST = 21;
    public const int CLASS_TYPE_GIANT = 22;
    public const int CLASS_TYPE_MAGICAL_BEAST = 23;
    public const int CLASS_TYPE_OUTSIDER = 24;
    public const int CLASS_TYPE_SHAPECHANGER = 25;
    public const int CLASS_TYPE_VERMIN = 26;
    public const int CLASS_TYPE_SHADOWDANCER = 27;
    public const int CLASS_TYPE_HARPER = 28;
    public const int CLASS_TYPE_ARCANE_ARCHER = 29;
    public const int CLASS_TYPE_ASSASSIN = 30;
    public const int CLASS_TYPE_BLACKGUARD = 31;
    public const int CLASS_TYPE_DIVINECHAMPION = 32;
    public const int CLASS_TYPE_DIVINE_CHAMPION = 32;
    public const int CLASS_TYPE_WEAPON_MASTER = 33;
    public const int CLASS_TYPE_PALEMASTER = 34;
    public const int CLASS_TYPE_PALE_MASTER = 34;
    public const int CLASS_TYPE_SHIFTER = 35;
    public const int CLASS_TYPE_DWARVENDEFENDER = 36;
    public const int CLASS_TYPE_DWARVEN_DEFENDER = 36;
    public const int CLASS_TYPE_DRAGONDISCIPLE = 37;
    public const int CLASS_TYPE_DRAGON_DISCIPLE = 37;
    public const int CLASS_TYPE_OOZE = 38;
    public const int CLASS_TYPE_EYE_OF_GRUUMSH = 39;
    public const int CLASS_TYPE_SHOU_DISCIPLE = 40;
    public const int CLASS_TYPE_PURPLE_DRAGON_KNIGHT = 41;
    public const int CLASS_TYPE_INVALID = 255;

    ///  These are for the LevelUpHenchman command.
    public const int PACKAGE_BARBARIAN = 0;
    public const int PACKAGE_BARD = 1;
    public const int PACKAGE_CLERIC = 2;
    public const int PACKAGE_DRUID = 3;
    public const int PACKAGE_FIGHTER = 4;
    public const int PACKAGE_MONK = 5;
    public const int PACKAGE_PALADIN = 6;
    public const int PACKAGE_RANGER = 7;
    public const int PACKAGE_ROGUE = 8;
    public const int PACKAGE_SORCERER = 9;
    public const int PACKAGE_WIZARDGENERALIST = 10;
    public const int PACKAGE_DRUID_INTERLOPER = 11;
    public const int PACKAGE_DRUID_GRAY = 12;
    public const int PACKAGE_DRUID_DEATH = 13;
    public const int PACKAGE_DRUID_HAWKMASTER = 14;
    public const int PACKAGE_BARBARIAN_BRUTE = 15;
    public const int PACKAGE_BARBARIAN_SLAYER = 16;
    public const int PACKAGE_BARBARIAN_SAVAGE = 17;
    public const int PACKAGE_BARBARIAN_ORCBLOOD = 18;
    public const int PACKAGE_CLERIC_SHAMAN = 19;
    public const int PACKAGE_CLERIC_DEADWALKER = 20;
    public const int PACKAGE_CLERIC_ELEMENTALIST = 21;
    public const int PACKAGE_CLERIC_BATTLE_PRIEST = 22;
    public const int PACKAGE_FIGHTER_FINESSE = 23;
    public const int PACKAGE_FIGHTER_PIRATE = 24;
    public const int PACKAGE_FIGHTER_GLADIATOR = 25;
    public const int PACKAGE_FIGHTER_COMMANDER = 26;
    public const int PACKAGE_WIZARD_ABJURATION = 27;
    public const int PACKAGE_WIZARD_CONJURATION = 28;
    public const int PACKAGE_WIZARD_DIVINATION = 29;
    public const int PACKAGE_WIZARD_ENCHANTMENT = 30;
    public const int PACKAGE_WIZARD_EVOCATION = 31;
    public const int PACKAGE_WIZARD_ILLUSION = 32;
    public const int PACKAGE_WIZARD_NECROMANCY = 33;
    public const int PACKAGE_WIZARD_TRANSMUTATION = 34;
    public const int PACKAGE_SORCERER_ABJURATION = 35;
    public const int PACKAGE_SORCERER_CONJURATION = 36;
    public const int PACKAGE_SORCERER_DIVINATION = 37;
    public const int PACKAGE_SORCERER_ENCHANTMENT = 38;
    public const int PACKAGE_SORCERER_EVOCATION = 39;
    public const int PACKAGE_SORCERER_ILLUSION = 40;
    public const int PACKAGE_SORCERER_NECROMANCY = 41;
    public const int PACKAGE_SORCERER_TRANSMUTATION = 42;
    public const int PACKAGE_BARD_BLADE = 43;
    public const int PACKAGE_BARD_GALLANT = 44;
    public const int PACKAGE_BARD_JESTER = 45;
    public const int PACKAGE_BARD_LOREMASTER = 46;
    public const int PACKAGE_MONK_SPIRIT = 47;
    public const int PACKAGE_MONK_GIFTED = 48;
    public const int PACKAGE_MONK_DEVOUT = 49;
    public const int PACKAGE_MONK_PEASANT = 50;
    public const int PACKAGE_PALADIN_ERRANT = 51;
    public const int PACKAGE_PALADIN_UNDEAD = 52;
    public const int PACKAGE_PALADIN_INQUISITOR = 53;
    public const int PACKAGE_PALADIN_CHAMPION = 54;
    public const int PACKAGE_RANGER_MARKSMAN = 55;
    public const int PACKAGE_RANGER_WARDEN = 56;
    public const int PACKAGE_RANGER_STALKER = 57;
    public const int PACKAGE_RANGER_GIANTKILLER = 58;
    public const int PACKAGE_ROGUE_GYPSY = 59;
    public const int PACKAGE_ROGUE_BANDIT = 60;
    public const int PACKAGE_ROGUE_SCOUT = 61;
    public const int PACKAGE_ROGUE_SWASHBUCKLER = 62;
    public const int PACKAGE_SHADOWDANCER = 63;
    public const int PACKAGE_HARPER = 64;
    public const int PACKAGE_ARCANE_ARCHER = 65;
    public const int PACKAGE_ASSASSIN = 66;
    public const int PACKAGE_BLACKGUARD = 67;
    public const int PACKAGE_NPC_SORCERER = 70;
    public const int PACKAGE_NPC_ROGUE = 71;
    public const int PACKAGE_NPC_BARD = 72;
    public const int PACKAGE_ABERRATION = 73;
    public const int PACKAGE_ANIMAL = 74;
    public const int PACKAGE_CONSTRUCT = 75;
    public const int PACKAGE_HUMANOID = 76;
    public const int PACKAGE_MONSTROUS = 77;
    public const int PACKAGE_ELEMENTAL = 78;
    public const int PACKAGE_FEY = 79;
    public const int PACKAGE_DRAGON = 80;
    public const int PACKAGE_UNDEAD = 81;
    public const int PACKAGE_COMMONER = 82;
    public const int PACKAGE_BEAST = 83;
    public const int PACKAGE_GIANT = 84;
    public const int PACKAGE_MAGICBEAST = 85;
    public const int PACKAGE_OUTSIDER = 86;
    public const int PACKAGE_SHAPECHANGER = 87;
    public const int PACKAGE_VERMIN = 88;
    public const int PACKAGE_DWARVEN_DEFENDER = 89;
    public const int PACKAGE_BARBARIAN_BLACKGUARD = 90;
    public const int PACKAGE_BARD_HARPER = 91;
    public const int PACKAGE_CLERIC_DIVINE = 92;
    public const int PACKAGE_DRUID_SHIFTER = 93;
    public const int PACKAGE_FIGHTER_WEAPONMASTER = 94;
    public const int PACKAGE_MONK_ASSASSIN = 95;
    public const int PACKAGE_PALADIN_DIVINE = 96;
    public const int PACKAGE_RANGER_ARCANEARCHER = 97;
    public const int PACKAGE_ROGUE_SHADOWDANCER = 98;
    public const int PACKAGE_SORCERER_DRAGONDISCIPLE = 99;
    public const int PACKAGE_WIZARD_PALEMASTER = 100;
    public const int PACKAGE_NPC_WIZASSASSIN = 101;
    public const int PACKAGE_NPC_FT_WEAPONMASTER = 102;
    public const int PACKAGE_NPC_RG_SHADOWDANCER = 103;
    public const int PACKAGE_NPC_CLERIC_LINU = 104;
    public const int PACKAGE_NPC_BARBARIAN_DAELAN = 105;
    public const int PACKAGE_NPC_BARD_FIGHTER = 106;
    public const int PACKAGE_NPC_PALADIN_FALLING = 107;
    public const int PACKAGE_SHIFTER = 108;
    public const int PACKAGE_DIVINE_CHAMPION = 109;
    public const int PACKAGE_PALE_MASTER = 110;
    public const int PACKAGE_DRAGON_DISCIPLE = 111;
    public const int PACKAGE_WEAPONMASTER = 112;
    public const int PACKAGE_NPC_FT_WEAPONMASTER_VALEN_2 = 113;
    public const int PACKAGE_NPC_BARD_FIGHTER_SHARWYN2 = 114;
    public const int PACKAGE_NPC_WIZASSASSIN_NATHYRRA = 115;
    public const int PACKAGE_NPC_RG_TOMI_2 = 116;
    public const int PACKAGE_NPC_BARD_DEEKIN_2 = 117;
    public const int PACKAGE_BARBARIAN_BLACKGUARD_2NDCLASS = 118;
    public const int PACKAGE_BARD_HARPER_2NDCLASS = 119;
    public const int PACKAGE_CLERIC_DIVINE_2NDCLASS = 120;
    public const int PACKAGE_DRUID_SHIFTER_2NDCLASS = 121;
    public const int PACKAGE_FIGHTER_WEAPONMASTER_2NDCLASS = 122;
    public const int PACKAGE_MONK_ASSASSIN_2NDCLASS = 123;
    public const int PACKAGE_PALADIN_DIVINE_2NDCLASS = 124;
    public const int PACKAGE_RANGER_ARCANEARCHER_2NDCLASS = 125;
    public const int PACKAGE_ROGUE_SHADOWDANCER_2NDCLASS = 126;
    public const int PACKAGE_SORCERER_DRAGONDISCIPLE_2NDCLASS = 127;
    public const int PACKAGE_WIZARD_PALEMASTER_2NDCLASS = 128;
    public const int PACKAGE_NPC_ARIBETH_PALADIN = 129;
    public const int PACKAGE_NPC_ARIBETH_BLACKGUARD = 130;
    public const int PACKAGE_INVALID = 255;

    ///  These are for GetFirstInPersistentObject() and GetNextInPersistentObject()
    public const int PERSISTENT_ZONE_ACTIVE = 0;
    public const int PERSISTENT_ZONE_FOLLOW = 1;
    public const int STANDARD_FACTION_HOSTILE = 0;
    public const int STANDARD_FACTION_COMMONER = 1;
    public const int STANDARD_FACTION_MERCHANT = 2;
    public const int STANDARD_FACTION_DEFENDER = 3;

    ///  Skill defines
    public const int SKILL_ANIMAL_EMPATHY = 0;
    public const int SKILL_CONCENTRATION = 1;
    public const int SKILL_DISABLE_TRAP = 2;
    public const int SKILL_DISCIPLINE = 3;
    public const int SKILL_HEAL = 4;
    public const int SKILL_HIDE = 5;
    public const int SKILL_LISTEN = 6;
    public const int SKILL_LORE = 7;
    public const int SKILL_MOVE_SILENTLY = 8;
    public const int SKILL_OPEN_LOCK = 9;
    public const int SKILL_PARRY = 10;
    public const int SKILL_PERFORM = 11;
    public const int SKILL_PERSUADE = 12;
    public const int SKILL_PICK_POCKET = 13;
    public const int SKILL_SEARCH = 14;
    public const int SKILL_SET_TRAP = 15;
    public const int SKILL_SPELLCRAFT = 16;
    public const int SKILL_SPOT = 17;
    public const int SKILL_TAUNT = 18;
    public const int SKILL_USE_MAGIC_DEVICE = 19;
    public const int SKILL_APPRAISE = 20;
    public const int SKILL_TUMBLE = 21;
    public const int SKILL_CRAFT_TRAP = 22;
    public const int SKILL_BLUFF = 23;
    public const int SKILL_INTIMIDATE = 24;
    public const int SKILL_CRAFT_ARMOR = 25;
    public const int SKILL_CRAFT_WEAPON = 26;
    public const int SKILL_RIDE = 27;
    public const int SKILL_ALL_SKILLS = 255;
    public const int SUBSKILL_FLAGTRAP = 100;
    public const int SUBSKILL_RECOVERTRAP = 101;
    public const int SUBSKILL_EXAMINETRAP = 102;
    public const int FEAT_ALERTNESS = 0;
    public const int FEAT_AMBIDEXTERITY = 1;
    public const int FEAT_ARMOR_PROFICIENCY_HEAVY = 2;
    public const int FEAT_ARMOR_PROFICIENCY_LIGHT = 3;
    public const int FEAT_ARMOR_PROFICIENCY_MEDIUM = 4;
    public const int FEAT_CALLED_SHOT = 5;
    public const int FEAT_CLEAVE = 6;
    public const int FEAT_COMBAT_CASTING = 7;
    public const int FEAT_DEFLECT_ARROWS = 8;
    public const int FEAT_DISARM = 9;
    public const int FEAT_DODGE = 10;
    public const int FEAT_EMPOWER_SPELL = 11;
    public const int FEAT_EXTEND_SPELL = 12;
    public const int FEAT_EXTRA_TURNING = 13;
    public const int FEAT_GREAT_FORTITUDE = 14;
    public const int FEAT_IMPROVED_CRITICAL_CLUB = 15;
    public const int FEAT_IMPROVED_DISARM = 16;
    public const int FEAT_IMPROVED_KNOCKDOWN = 17;
    public const int FEAT_IMPROVED_PARRY = 18;
    public const int FEAT_IMPROVED_POWER_ATTACK = 19;
    public const int FEAT_IMPROVED_TWO_WEAPON_FIGHTING = 20;
    public const int FEAT_IMPROVED_UNARMED_STRIKE = 21;
    public const int FEAT_IRON_WILL = 22;
    public const int FEAT_KNOCKDOWN = 23;
    public const int FEAT_LIGHTNING_REFLEXES = 24;
    public const int FEAT_MAXIMIZE_SPELL = 25;
    public const int FEAT_MOBILITY = 26;
    public const int FEAT_POINT_BLANK_SHOT = 27;
    public const int FEAT_POWER_ATTACK = 28;
    public const int FEAT_QUICKEN_SPELL = 29;
    public const int FEAT_RAPID_SHOT = 30;
    public const int FEAT_SAP = 31;
    public const int FEAT_SHIELD_PROFICIENCY = 32;
    public const int FEAT_SILENCE_SPELL = 33;
    public const int FEAT_SKILL_FOCUS_ANIMAL_EMPATHY = 34;
    public const int FEAT_SPELL_FOCUS_ABJURATION = 35;
    public const int FEAT_SPELL_PENETRATION = 36;
    public const int FEAT_STILL_SPELL = 37;
    public const int FEAT_STUNNING_FIST = 39;
    public const int FEAT_TOUGHNESS = 40;
    public const int FEAT_TWO_WEAPON_FIGHTING = 41;
    public const int FEAT_WEAPON_FINESSE = 42;
    public const int FEAT_WEAPON_FOCUS_CLUB = 43;
    public const int FEAT_WEAPON_PROFICIENCY_EXOTIC = 44;
    public const int FEAT_WEAPON_PROFICIENCY_MARTIAL = 45;
    public const int FEAT_WEAPON_PROFICIENCY_SIMPLE = 46;
    public const int FEAT_WEAPON_SPECIALIZATION_CLUB = 47;
    public const int FEAT_WEAPON_PROFICIENCY_DRUID = 48;
    public const int FEAT_WEAPON_PROFICIENCY_MONK = 49;
    public const int FEAT_WEAPON_PROFICIENCY_ROGUE = 50;
    public const int FEAT_WEAPON_PROFICIENCY_WIZARD = 51;
    public const int FEAT_IMPROVED_CRITICAL_DAGGER = 52;
    public const int FEAT_IMPROVED_CRITICAL_DART = 53;
    public const int FEAT_IMPROVED_CRITICAL_HEAVY_CROSSBOW = 54;
    public const int FEAT_IMPROVED_CRITICAL_LIGHT_CROSSBOW = 55;
    public const int FEAT_IMPROVED_CRITICAL_LIGHT_MACE = 56;
    public const int FEAT_IMPROVED_CRITICAL_MORNING_STAR = 57;
    public const int FEAT_IMPROVED_CRITICAL_STAFF = 58;
    public const int FEAT_IMPROVED_CRITICAL_SPEAR = 59;
    public const int FEAT_IMPROVED_CRITICAL_SICKLE = 60;
    public const int FEAT_IMPROVED_CRITICAL_SLING = 61;
    public const int FEAT_IMPROVED_CRITICAL_UNARMED_STRIKE = 62;
    public const int FEAT_IMPROVED_CRITICAL_LONGBOW = 63;
    public const int FEAT_IMPROVED_CRITICAL_SHORTBOW = 64;
    public const int FEAT_IMPROVED_CRITICAL_SHORT_SWORD = 65;
    public const int FEAT_IMPROVED_CRITICAL_RAPIER = 66;
    public const int FEAT_IMPROVED_CRITICAL_SCIMITAR = 67;
    public const int FEAT_IMPROVED_CRITICAL_LONG_SWORD = 68;
    public const int FEAT_IMPROVED_CRITICAL_GREAT_SWORD = 69;
    public const int FEAT_IMPROVED_CRITICAL_HAND_AXE = 70;
    public const int FEAT_IMPROVED_CRITICAL_THROWING_AXE = 71;
    public const int FEAT_IMPROVED_CRITICAL_BATTLE_AXE = 72;
    public const int FEAT_IMPROVED_CRITICAL_GREAT_AXE = 73;
    public const int FEAT_IMPROVED_CRITICAL_HALBERD = 74;
    public const int FEAT_IMPROVED_CRITICAL_LIGHT_HAMMER = 75;
    public const int FEAT_IMPROVED_CRITICAL_LIGHT_FLAIL = 76;
    public const int FEAT_IMPROVED_CRITICAL_WAR_HAMMER = 77;
    public const int FEAT_IMPROVED_CRITICAL_HEAVY_FLAIL = 78;
    public const int FEAT_IMPROVED_CRITICAL_KAMA = 79;
    public const int FEAT_IMPROVED_CRITICAL_KUKRI = 80;

    /// int FEAT_IMPROVED_CRITICAL_NUNCHAKU = 81;
    public const int FEAT_IMPROVED_CRITICAL_SHURIKEN = 82;
    public const int FEAT_IMPROVED_CRITICAL_SCYTHE = 83;
    public const int FEAT_IMPROVED_CRITICAL_KATANA = 84;
    public const int FEAT_IMPROVED_CRITICAL_BASTARD_SWORD = 85;
    public const int FEAT_IMPROVED_CRITICAL_DIRE_MACE = 87;
    public const int FEAT_IMPROVED_CRITICAL_DOUBLE_AXE = 88;
    public const int FEAT_IMPROVED_CRITICAL_TWO_BLADED_SWORD = 89;
    public const int FEAT_WEAPON_FOCUS_DAGGER = 90;
    public const int FEAT_WEAPON_FOCUS_DART = 91;
    public const int FEAT_WEAPON_FOCUS_HEAVY_CROSSBOW = 92;
    public const int FEAT_WEAPON_FOCUS_LIGHT_CROSSBOW = 93;
    public const int FEAT_WEAPON_FOCUS_LIGHT_MACE = 94;
    public const int FEAT_WEAPON_FOCUS_MORNING_STAR = 95;
    public const int FEAT_WEAPON_FOCUS_STAFF = 96;
    public const int FEAT_WEAPON_FOCUS_SPEAR = 97;
    public const int FEAT_WEAPON_FOCUS_SICKLE = 98;
    public const int FEAT_WEAPON_FOCUS_SLING = 99;
    public const int FEAT_WEAPON_FOCUS_UNARMED_STRIKE = 100;
    public const int FEAT_WEAPON_FOCUS_LONGBOW = 101;
    public const int FEAT_WEAPON_FOCUS_SHORTBOW = 102;
    public const int FEAT_WEAPON_FOCUS_SHORT_SWORD = 103;
    public const int FEAT_WEAPON_FOCUS_RAPIER = 104;
    public const int FEAT_WEAPON_FOCUS_SCIMITAR = 105;
    public const int FEAT_WEAPON_FOCUS_LONG_SWORD = 106;
    public const int FEAT_WEAPON_FOCUS_GREAT_SWORD = 107;
    public const int FEAT_WEAPON_FOCUS_HAND_AXE = 108;
    public const int FEAT_WEAPON_FOCUS_THROWING_AXE = 109;
    public const int FEAT_WEAPON_FOCUS_BATTLE_AXE = 110;
    public const int FEAT_WEAPON_FOCUS_GREAT_AXE = 111;
    public const int FEAT_WEAPON_FOCUS_HALBERD = 112;
    public const int FEAT_WEAPON_FOCUS_LIGHT_HAMMER = 113;
    public const int FEAT_WEAPON_FOCUS_LIGHT_FLAIL = 114;
    public const int FEAT_WEAPON_FOCUS_WAR_HAMMER = 115;
    public const int FEAT_WEAPON_FOCUS_HEAVY_FLAIL = 116;
    public const int FEAT_WEAPON_FOCUS_KAMA = 117;
    public const int FEAT_WEAPON_FOCUS_KUKRI = 118;

    /// int FEAT_WEAPON_FOCUS_NUNCHAKU = 119;
    public const int FEAT_WEAPON_FOCUS_SHURIKEN = 120;
    public const int FEAT_WEAPON_FOCUS_SCYTHE = 121;
    public const int FEAT_WEAPON_FOCUS_KATANA = 122;
    public const int FEAT_WEAPON_FOCUS_BASTARD_SWORD = 123;
    public const int FEAT_WEAPON_FOCUS_DIRE_MACE = 125;
    public const int FEAT_WEAPON_FOCUS_DOUBLE_AXE = 126;
    public const int FEAT_WEAPON_FOCUS_TWO_BLADED_SWORD = 127;
    public const int FEAT_WEAPON_SPECIALIZATION_DAGGER = 128;
    public const int FEAT_WEAPON_SPECIALIZATION_DART = 129;
    public const int FEAT_WEAPON_SPECIALIZATION_HEAVY_CROSSBOW = 130;
    public const int FEAT_WEAPON_SPECIALIZATION_LIGHT_CROSSBOW = 131;
    public const int FEAT_WEAPON_SPECIALIZATION_LIGHT_MACE = 132;
    public const int FEAT_WEAPON_SPECIALIZATION_MORNING_STAR = 133;
    public const int FEAT_WEAPON_SPECIALIZATION_STAFF = 134;
    public const int FEAT_WEAPON_SPECIALIZATION_SPEAR = 135;
    public const int FEAT_WEAPON_SPECIALIZATION_SICKLE = 136;
    public const int FEAT_WEAPON_SPECIALIZATION_SLING = 137;
    public const int FEAT_WEAPON_SPECIALIZATION_UNARMED_STRIKE = 138;
    public const int FEAT_WEAPON_SPECIALIZATION_LONGBOW = 139;
    public const int FEAT_WEAPON_SPECIALIZATION_SHORTBOW = 140;
    public const int FEAT_WEAPON_SPECIALIZATION_SHORT_SWORD = 141;
    public const int FEAT_WEAPON_SPECIALIZATION_RAPIER = 142;
    public const int FEAT_WEAPON_SPECIALIZATION_SCIMITAR = 143;
    public const int FEAT_WEAPON_SPECIALIZATION_LONG_SWORD = 144;
    public const int FEAT_WEAPON_SPECIALIZATION_GREAT_SWORD = 145;
    public const int FEAT_WEAPON_SPECIALIZATION_HAND_AXE = 146;
    public const int FEAT_WEAPON_SPECIALIZATION_THROWING_AXE = 147;
    public const int FEAT_WEAPON_SPECIALIZATION_BATTLE_AXE = 148;
    public const int FEAT_WEAPON_SPECIALIZATION_GREAT_AXE = 149;
    public const int FEAT_WEAPON_SPECIALIZATION_HALBERD = 150;
    public const int FEAT_WEAPON_SPECIALIZATION_LIGHT_HAMMER = 151;
    public const int FEAT_WEAPON_SPECIALIZATION_LIGHT_FLAIL = 152;
    public const int FEAT_WEAPON_SPECIALIZATION_WAR_HAMMER = 153;
    public const int FEAT_WEAPON_SPECIALIZATION_HEAVY_FLAIL = 154;
    public const int FEAT_WEAPON_SPECIALIZATION_KAMA = 155;
    public const int FEAT_WEAPON_SPECIALIZATION_KUKRI = 156;

    /// int FEAT_WEAPON_SPECIALIZATION_NUNCHAKU = 157;
    public const int FEAT_WEAPON_SPECIALIZATION_SHURIKEN = 158;
    public const int FEAT_WEAPON_SPECIALIZATION_SCYTHE = 159;
    public const int FEAT_WEAPON_SPECIALIZATION_KATANA = 160;
    public const int FEAT_WEAPON_SPECIALIZATION_BASTARD_SWORD = 161;
    public const int FEAT_WEAPON_SPECIALIZATION_DIRE_MACE = 163;
    public const int FEAT_WEAPON_SPECIALIZATION_DOUBLE_AXE = 164;
    public const int FEAT_WEAPON_SPECIALIZATION_TWO_BLADED_SWORD = 165;
    public const int FEAT_SPELL_FOCUS_CONJURATION = 166;
    public const int FEAT_SPELL_FOCUS_DIVINATION = 167;
    public const int FEAT_SPELL_FOCUS_ENCHANTMENT = 168;
    public const int FEAT_SPELL_FOCUS_EVOCATION = 169;
    public const int FEAT_SPELL_FOCUS_ILLUSION = 170;
    public const int FEAT_SPELL_FOCUS_NECROMANCY = 171;
    public const int FEAT_SPELL_FOCUS_TRANSMUTATION = 172;
    public const int FEAT_SKILL_FOCUS_CONCENTRATION = 173;
    public const int FEAT_SKILL_FOCUS_DISABLE_TRAP = 174;
    public const int FEAT_SKILL_FOCUS_DISCIPLINE = 175;
    public const int FEAT_SKILL_FOCUS_HEAL = 177;
    public const int FEAT_SKILL_FOCUS_HIDE = 178;
    public const int FEAT_SKILL_FOCUS_LISTEN = 179;
    public const int FEAT_SKILL_FOCUS_LORE = 180;
    public const int FEAT_SKILL_FOCUS_MOVE_SILENTLY = 181;
    public const int FEAT_SKILL_FOCUS_OPEN_LOCK = 182;
    public const int FEAT_SKILL_FOCUS_PARRY = 183;
    public const int FEAT_SKILL_FOCUS_PERFORM = 184;
    public const int FEAT_SKILL_FOCUS_PERSUADE = 185;
    public const int FEAT_SKILL_FOCUS_PICK_POCKET = 186;
    public const int FEAT_SKILL_FOCUS_SEARCH = 187;
    public const int FEAT_SKILL_FOCUS_SET_TRAP = 188;
    public const int FEAT_SKILL_FOCUS_SPELLCRAFT = 189;
    public const int FEAT_SKILL_FOCUS_SPOT = 190;
    public const int FEAT_SKILL_FOCUS_TAUNT = 192;
    public const int FEAT_SKILL_FOCUS_USE_MAGIC_DEVICE = 193;
    public const int FEAT_BARBARIAN_ENDURANCE = 194;
    public const int FEAT_UNCANNY_DODGE_1 = 195;
    public const int FEAT_DAMAGE_REDUCTION = 196;
    public const int FEAT_BARDIC_KNOWLEDGE = 197;
    public const int FEAT_NATURE_SENSE = 198;
    public const int FEAT_ANIMAL_COMPANION = 199;
    public const int FEAT_WOODLAND_STRIDE = 200;
    public const int FEAT_TRACKLESS_STEP = 201;
    public const int FEAT_RESIST_NATURES_LURE = 202;
    public const int FEAT_VENOM_IMMUNITY = 203;
    public const int FEAT_FLURRY_OF_BLOWS = 204;
    public const int FEAT_EVASION = 206;
    public const int FEAT_MONK_ENDURANCE = 207;
    public const int FEAT_STILL_MIND = 208;
    public const int FEAT_PURITY_OF_BODY = 209;
    public const int FEAT_WHOLENESS_OF_BODY = 211;
    public const int FEAT_IMPROVED_EVASION = 212;
    public const int FEAT_KI_STRIKE = 213;
    public const int FEAT_DIAMOND_BODY = 214;
    public const int FEAT_DIAMOND_SOUL = 215;
    public const int FEAT_PERFECT_SELF = 216;
    public const int FEAT_DIVINE_GRACE = 217;
    public const int FEAT_DIVINE_HEALTH = 219;
    public const int FEAT_SNEAK_ATTACK = 221;
    public const int FEAT_CRIPPLING_STRIKE = 222;
    public const int FEAT_DEFENSIVE_ROLL = 223;
    public const int FEAT_OPPORTUNIST = 224;
    public const int FEAT_SKILL_MASTERY = 225;
    public const int FEAT_UNCANNY_REFLEX = 226;
    public const int FEAT_STONECUNNING = 227;
    public const int FEAT_DARKVISION = 228;
    public const int FEAT_HARDINESS_VERSUS_POISONS = 229;
    public const int FEAT_HARDINESS_VERSUS_SPELLS = 230;
    public const int FEAT_BATTLE_TRAINING_VERSUS_ORCS = 231;
    public const int FEAT_BATTLE_TRAINING_VERSUS_GOBLINS = 232;
    public const int FEAT_BATTLE_TRAINING_VERSUS_GIANTS = 233;
    public const int FEAT_SKILL_AFFINITY_LORE = 234;
    public const int FEAT_IMMUNITY_TO_SLEEP = 235;
    public const int FEAT_HARDINESS_VERSUS_ENCHANTMENTS = 236;
    public const int FEAT_SKILL_AFFINITY_LISTEN = 237;
    public const int FEAT_SKILL_AFFINITY_SEARCH = 238;
    public const int FEAT_SKILL_AFFINITY_SPOT = 239;
    public const int FEAT_KEEN_SENSE = 240;
    public const int FEAT_HARDINESS_VERSUS_ILLUSIONS = 241;
    public const int FEAT_BATTLE_TRAINING_VERSUS_REPTILIANS = 242;
    public const int FEAT_SKILL_AFFINITY_CONCENTRATION = 243;
    public const int FEAT_PARTIAL_SKILL_AFFINITY_LISTEN = 244;
    public const int FEAT_PARTIAL_SKILL_AFFINITY_SEARCH = 245;
    public const int FEAT_PARTIAL_SKILL_AFFINITY_SPOT = 246;
    public const int FEAT_SKILL_AFFINITY_MOVE_SILENTLY = 247;
    public const int FEAT_LUCKY = 248;
    public const int FEAT_FEARLESS = 249;
    public const int FEAT_GOOD_AIM = 250;
    public const int FEAT_UNCANNY_DODGE_2 = 251;
    public const int FEAT_UNCANNY_DODGE_3 = 252;
    public const int FEAT_UNCANNY_DODGE_4 = 253;
    public const int FEAT_UNCANNY_DODGE_5 = 254;
    public const int FEAT_UNCANNY_DODGE_6 = 255;
    public const int FEAT_WEAPON_PROFICIENCY_ELF = 256;
    public const int FEAT_BARD_SONGS = 257;
    public const int FEAT_QUICK_TO_MASTER = 258;
    public const int FEAT_SLIPPERY_MIND = 259;
    public const int FEAT_MONK_AC_BONUS = 260;
    public const int FEAT_FAVORED_ENEMY_DWARF = 261;
    public const int FEAT_FAVORED_ENEMY_ELF = 262;
    public const int FEAT_FAVORED_ENEMY_GNOME = 263;
    public const int FEAT_FAVORED_ENEMY_HALFLING = 264;
    public const int FEAT_FAVORED_ENEMY_HALFELF = 265;
    public const int FEAT_FAVORED_ENEMY_HALFORC = 266;
    public const int FEAT_FAVORED_ENEMY_HUMAN = 267;
    public const int FEAT_FAVORED_ENEMY_ABERRATION = 268;
    public const int FEAT_FAVORED_ENEMY_ANIMAL = 269;
    public const int FEAT_FAVORED_ENEMY_BEAST = 270;
    public const int FEAT_FAVORED_ENEMY_CONSTRUCT = 271;
    public const int FEAT_FAVORED_ENEMY_DRAGON = 272;
    public const int FEAT_FAVORED_ENEMY_GOBLINOID = 273;
    public const int FEAT_FAVORED_ENEMY_MONSTROUS = 274;
    public const int FEAT_FAVORED_ENEMY_ORC = 275;
    public const int FEAT_FAVORED_ENEMY_REPTILIAN = 276;
    public const int FEAT_FAVORED_ENEMY_ELEMENTAL = 277;
    public const int FEAT_FAVORED_ENEMY_FEY = 278;
    public const int FEAT_FAVORED_ENEMY_GIANT = 279;
    public const int FEAT_FAVORED_ENEMY_MAGICAL_BEAST = 280;
    public const int FEAT_FAVORED_ENEMY_OUTSIDER = 281;
    public const int FEAT_FAVORED_ENEMY_SHAPECHANGER = 284;
    public const int FEAT_FAVORED_ENEMY_UNDEAD = 285;
    public const int FEAT_FAVORED_ENEMY_VERMIN = 286;
    public const int FEAT_WEAPON_PROFICIENCY_CREATURE = 289;
    public const int FEAT_WEAPON_SPECIALIZATION_CREATURE = 290;
    public const int FEAT_WEAPON_FOCUS_CREATURE = 291;
    public const int FEAT_IMPROVED_CRITICAL_CREATURE = 292;
    public const int FEAT_BARBARIAN_RAGE = 293;
    public const int FEAT_TURN_UNDEAD = 294;
    public const int FEAT_QUIVERING_PALM = 296;
    public const int FEAT_EMPTY_BODY = 297;

    /// int FEAT_DETECT_EVIL = 298;
    public const int FEAT_LAY_ON_HANDS = 299;
    public const int FEAT_AURA_OF_COURAGE = 300;
    public const int FEAT_SMITE_EVIL = 301;
    public const int FEAT_REMOVE_DISEASE = 302;
    public const int FEAT_SUMMON_FAMILIAR = 303;
    public const int FEAT_ELEMENTAL_SHAPE = 304;
    public const int FEAT_WILD_SHAPE = 305;
    public const int FEAT_WAR_DOMAIN_POWER = 306;
    public const int FEAT_STRENGTH_DOMAIN_POWER = 307;
    public const int FEAT_PROTECTION_DOMAIN_POWER = 308;
    public const int FEAT_LUCK_DOMAIN_POWER = 309;
    public const int FEAT_DEATH_DOMAIN_POWER = 310;
    public const int FEAT_AIR_DOMAIN_POWER = 311;
    public const int FEAT_ANIMAL_DOMAIN_POWER = 312;
    public const int FEAT_DESTRUCTION_DOMAIN_POWER = 313;
    public const int FEAT_EARTH_DOMAIN_POWER = 314;
    public const int FEAT_EVIL_DOMAIN_POWER = 315;
    public const int FEAT_FIRE_DOMAIN_POWER = 316;
    public const int FEAT_GOOD_DOMAIN_POWER = 317;
    public const int FEAT_HEALING_DOMAIN_POWER = 318;
    public const int FEAT_KNOWLEDGE_DOMAIN_POWER = 319;
    public const int FEAT_MAGIC_DOMAIN_POWER = 320;
    public const int FEAT_PLANT_DOMAIN_POWER = 321;
    public const int FEAT_SUN_DOMAIN_POWER = 322;
    public const int FEAT_TRAVEL_DOMAIN_POWER = 323;
    public const int FEAT_TRICKERY_DOMAIN_POWER = 324;
    public const int FEAT_WATER_DOMAIN_POWER = 325;
    public const int FEAT_LOWLIGHTVISION = 354;
    public const int FEAT_IMPROVED_INITIATIVE = 377;
    public const int FEAT_ARTIST = 378;
    public const int FEAT_BLOODED = 379;
    public const int FEAT_BULLHEADED = 380;
    public const int FEAT_COURTLY_MAGOCRACY = 381;
    public const int FEAT_LUCK_OF_HEROES = 382;
    public const int FEAT_RESIST_POISON = 383;
    public const int FEAT_SILVER_PALM = 384;
    public const int FEAT_SNAKEBLOOD = 386;
    public const int FEAT_STEALTHY = 387;
    public const int FEAT_STRONGSOUL = 388;
    public const int FEAT_EXPERTISE = 389;
    public const int FEAT_IMPROVED_EXPERTISE = 390;
    public const int FEAT_GREAT_CLEAVE = 391;
    public const int FEAT_SPRING_ATTACK = 392;
    public const int FEAT_GREATER_SPELL_FOCUS_ABJURATION = 393;
    public const int FEAT_GREATER_SPELL_FOCUS_CONJURATION = 394;
    public const int FEAT_GREATER_SPELL_FOCUS_DIVINIATION = 395;
    public const int FEAT_GREATER_SPELL_FOCUS_DIVINATION = 395;
    public const int FEAT_GREATER_SPELL_FOCUS_ENCHANTMENT = 396;
    public const int FEAT_GREATER_SPELL_FOCUS_EVOCATION = 397;
    public const int FEAT_GREATER_SPELL_FOCUS_ILLUSION = 398;
    public const int FEAT_GREATER_SPELL_FOCUS_NECROMANCY = 399;
    public const int FEAT_GREATER_SPELL_FOCUS_TRANSMUTATION = 400;
    public const int FEAT_GREATER_SPELL_PENETRATION = 401;
    public const int FEAT_THUG = 402;
    public const int FEAT_SKILLFOCUS_APPRAISE = 404;
    public const int FEAT_SKILL_FOCUS_TUMBLE = 406;
    public const int FEAT_SKILL_FOCUS_CRAFT_TRAP = 407;
    public const int FEAT_BLIND_FIGHT = 408;
    public const int FEAT_CIRCLE_KICK = 409;
    public const int FEAT_EXTRA_STUNNING_ATTACK = 410;
    public const int FEAT_RAPID_RELOAD = 411;
    public const int FEAT_ZEN_ARCHERY = 412;
    public const int FEAT_DIVINE_MIGHT = 413;
    public const int FEAT_DIVINE_SHIELD = 414;
    public const int FEAT_ARCANE_DEFENSE_ABJURATION = 415;
    public const int FEAT_ARCANE_DEFENSE_CONJURATION = 416;
    public const int FEAT_ARCANE_DEFENSE_DIVINATION = 417;
    public const int FEAT_ARCANE_DEFENSE_ENCHANTMENT = 418;
    public const int FEAT_ARCANE_DEFENSE_EVOCATION = 419;
    public const int FEAT_ARCANE_DEFENSE_ILLUSION = 420;
    public const int FEAT_ARCANE_DEFENSE_NECROMANCY = 421;
    public const int FEAT_ARCANE_DEFENSE_TRANSMUTATION = 422;
    public const int FEAT_EXTRA_MUSIC = 423;
    public const int FEAT_LINGERING_SONG = 424;
    public const int FEAT_DIRTY_FIGHTING = 425;
    public const int FEAT_RESIST_DISEASE = 426;
    public const int FEAT_RESIST_ENERGY_COLD = 427;
    public const int FEAT_RESIST_ENERGY_ACID = 428;
    public const int FEAT_RESIST_ENERGY_FIRE = 429;
    public const int FEAT_RESIST_ENERGY_ELECTRICAL = 430;
    public const int FEAT_RESIST_ENERGY_SONIC = 431;
    public const int FEAT_HIDE_IN_PLAIN_SIGHT = 433;
    public const int FEAT_SHADOW_DAZE = 434;
    public const int FEAT_SUMMON_SHADOW = 435;
    public const int FEAT_SHADOW_EVADE = 436;
    public const int FEAT_DENEIRS_EYE = 437;
    public const int FEAT_TYMORAS_SMILE = 438;
    public const int FEAT_LLIIRAS_HEART = 439;
    public const int FEAT_CRAFT_HARPER_ITEM = 440;
    public const int FEAT_HARPER_SLEEP = 441;
    public const int FEAT_HARPER_CATS_GRACE = 442;
    public const int FEAT_HARPER_EAGLES_SPLENDOR = 443;
    public const int FEAT_HARPER_INVISIBILITY = 444;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_1 = 445;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_2 = 446;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_3 = 447;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_4 = 448;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_5 = 449;
    public const int FEAT_PRESTIGE_IMBUE_ARROW = 450;
    public const int FEAT_PRESTIGE_SEEKER_ARROW_1 = 451;
    public const int FEAT_PRESTIGE_SEEKER_ARROW_2 = 452;
    public const int FEAT_PRESTIGE_HAIL_OF_ARROWS = 453;
    public const int FEAT_PRESTIGE_ARROW_OF_DEATH = 454;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_1 = 455;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_2 = 456;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_3 = 457;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_4 = 458;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_5 = 459;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_1D6 = 460;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_2D6 = 461;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_3D6 = 462;
    public const int FEAT_PRESTIGE_POISON_SAVE_1 = 463;
    public const int FEAT_PRESTIGE_POISON_SAVE_2 = 464;
    public const int FEAT_PRESTIGE_POISON_SAVE_3 = 465;
    public const int FEAT_PRESTIGE_POISON_SAVE_4 = 466;
    public const int FEAT_PRESTIGE_POISON_SAVE_5 = 467;
    public const int FEAT_PRESTIGE_SPELL_GHOSTLY_VISAGE = 468;
    public const int FEAT_PRESTIGE_DARKNESS = 469;
    public const int FEAT_PRESTIGE_INVISIBILITY_1 = 470;
    public const int FEAT_PRESTIGE_INVISIBILITY_2 = 471;
    public const int FEAT_SMITE_GOOD = 472;
    public const int FEAT_PRESTIGE_DARK_BLESSING = 473;
    public const int FEAT_INFLICT_LIGHT_WOUNDS = 474;
    public const int FEAT_INFLICT_MODERATE_WOUNDS = 475;
    public const int FEAT_INFLICT_SERIOUS_WOUNDS = 476;
    public const int FEAT_INFLICT_CRITICAL_WOUNDS = 477;
    public const int FEAT_BULLS_STRENGTH = 478;
    public const int FEAT_CONTAGION = 479;
    public const int FEAT_EYE_OF_GRUUMSH_BLINDING_SPITTLE = 480;
    public const int FEAT_EYE_OF_GRUUMSH_BLINDING_SPITTLE_2 = 481;
    public const int FEAT_EYE_OF_GRUUMSH_COMMAND_THE_HORDE = 482;
    public const int FEAT_EYE_OF_GRUUMSH_SWING_BLINDLY = 483;
    public const int FEAT_EYE_OF_GRUUMSH_RITUAL_SCARRING = 484;
    public const int FEAT_BLINDSIGHT_5_FEET = 485;
    public const int FEAT_BLINDSIGHT_10_FEET = 486;
    public const int FEAT_EYE_OF_GRUUMSH_SIGHT_OF_GRUUMSH = 487;
    public const int FEAT_BLINDSIGHT_60_FEET = 488;
    public const int FEAT_SHOU_DISCIPLE_DODGE_2 = 489;
    public const int FEAT_EPIC_ARMOR_SKIN = 490;
    public const int FEAT_EPIC_BLINDING_SPEED = 491;
    public const int FEAT_EPIC_DAMAGE_REDUCTION_3 = 492;
    public const int FEAT_EPIC_DAMAGE_REDUCTION_6 = 493;
    public const int FEAT_EPIC_DAMAGE_REDUCTION_9 = 494;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_CLUB = 495;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_DAGGER = 496;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_DART = 497;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_HEAVYCROSSBOW = 498;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_LIGHTCROSSBOW = 499;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_LIGHTMACE = 500;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_MORNINGSTAR = 501;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_QUARTERSTAFF = 502;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SHORTSPEAR = 503;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SICKLE = 504;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SLING = 505;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_UNARMED = 506;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_LONGBOW = 507;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SHORTBOW = 508;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SHORTSWORD = 509;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_RAPIER = 510;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SCIMITAR = 511;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_LONGSWORD = 512;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_GREATSWORD = 513;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_HANDAXE = 514;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_THROWINGAXE = 515;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_BATTLEAXE = 516;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_GREATAXE = 517;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_HALBERD = 518;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_LIGHTHAMMER = 519;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_LIGHTFLAIL = 520;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_WARHAMMER = 521;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_HEAVYFLAIL = 522;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_KAMA = 523;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_KUKRI = 524;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SHURIKEN = 525;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_SCYTHE = 526;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_KATANA = 527;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_BASTARDSWORD = 528;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_DIREMACE = 529;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_DOUBLEAXE = 530;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_TWOBLADEDSWORD = 531;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_CREATURE = 532;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_1 = 533;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_2 = 534;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_3 = 535;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_4 = 536;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_5 = 537;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_6 = 538;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_7 = 539;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_8 = 540;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_9 = 541;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_COLD_10 = 542;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_1 = 543;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_2 = 544;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_3 = 545;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_4 = 546;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_5 = 547;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_6 = 548;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_7 = 549;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_8 = 550;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_9 = 551;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ACID_10 = 552;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_1 = 553;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_2 = 554;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_3 = 555;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_4 = 556;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_5 = 557;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_6 = 558;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_7 = 559;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_8 = 560;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_9 = 561;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_FIRE_10 = 562;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_1 = 563;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_2 = 564;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_3 = 565;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_4 = 566;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_5 = 567;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_6 = 568;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_7 = 569;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_8 = 570;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_9 = 571;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_ELECTRICAL_10 = 572;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_1 = 573;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_2 = 574;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_3 = 575;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_4 = 576;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_5 = 577;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_6 = 578;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_7 = 579;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_8 = 580;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_9 = 581;
    public const int FEAT_EPIC_ENERGY_RESISTANCE_SONIC_10 = 582;
    public const int FEAT_EPIC_FORTITUDE = 583;
    public const int FEAT_EPIC_PROWESS = 584;
    public const int FEAT_EPIC_REFLEXES = 585;
    public const int FEAT_EPIC_REPUTATION = 586;
    public const int FEAT_EPIC_SKILL_FOCUS_ANIMAL_EMPATHY = 587;
    public const int FEAT_EPIC_SKILL_FOCUS_APPRAISE = 588;
    public const int FEAT_EPIC_SKILL_FOCUS_CONCENTRATION = 589;
    public const int FEAT_EPIC_SKILL_FOCUS_CRAFT_TRAP = 590;
    public const int FEAT_EPIC_SKILL_FOCUS_DISABLETRAP = 591;
    public const int FEAT_EPIC_SKILL_FOCUS_DISCIPLINE = 592;
    public const int FEAT_EPIC_SKILL_FOCUS_HEAL = 593;
    public const int FEAT_EPIC_SKILL_FOCUS_HIDE = 594;
    public const int FEAT_EPIC_SKILL_FOCUS_LISTEN = 595;
    public const int FEAT_EPIC_SKILL_FOCUS_LORE = 596;
    public const int FEAT_EPIC_SKILL_FOCUS_MOVESILENTLY = 597;
    public const int FEAT_EPIC_SKILL_FOCUS_OPENLOCK = 598;
    public const int FEAT_EPIC_SKILL_FOCUS_PARRY = 599;
    public const int FEAT_EPIC_SKILL_FOCUS_PERFORM = 600;
    public const int FEAT_EPIC_SKILL_FOCUS_PERSUADE = 601;
    public const int FEAT_EPIC_SKILL_FOCUS_PICKPOCKET = 602;
    public const int FEAT_EPIC_SKILL_FOCUS_SEARCH = 603;
    public const int FEAT_EPIC_SKILL_FOCUS_SETTRAP = 604;
    public const int FEAT_EPIC_SKILL_FOCUS_SPELLCRAFT = 605;
    public const int FEAT_EPIC_SKILL_FOCUS_SPOT = 606;
    public const int FEAT_EPIC_SKILL_FOCUS_TAUNT = 607;
    public const int FEAT_EPIC_SKILL_FOCUS_TUMBLE = 608;
    public const int FEAT_EPIC_SKILL_FOCUS_USEMAGICDEVICE = 609;
    public const int FEAT_EPIC_SPELL_FOCUS_ABJURATION = 610;
    public const int FEAT_EPIC_SPELL_FOCUS_CONJURATION = 611;
    public const int FEAT_EPIC_SPELL_FOCUS_DIVINATION = 612;
    public const int FEAT_EPIC_SPELL_FOCUS_ENCHANTMENT = 613;
    public const int FEAT_EPIC_SPELL_FOCUS_EVOCATION = 614;
    public const int FEAT_EPIC_SPELL_FOCUS_ILLUSION = 615;
    public const int FEAT_EPIC_SPELL_FOCUS_NECROMANCY = 616;
    public const int FEAT_EPIC_SPELL_FOCUS_TRANSMUTATION = 617;
    public const int FEAT_EPIC_SPELL_PENETRATION = 618;
    public const int FEAT_EPIC_WEAPON_FOCUS_CLUB = 619;
    public const int FEAT_EPIC_WEAPON_FOCUS_DAGGER = 620;
    public const int FEAT_EPIC_WEAPON_FOCUS_DART = 621;
    public const int FEAT_EPIC_WEAPON_FOCUS_HEAVYCROSSBOW = 622;
    public const int FEAT_EPIC_WEAPON_FOCUS_LIGHTCROSSBOW = 623;
    public const int FEAT_EPIC_WEAPON_FOCUS_LIGHTMACE = 624;
    public const int FEAT_EPIC_WEAPON_FOCUS_MORNINGSTAR = 625;
    public const int FEAT_EPIC_WEAPON_FOCUS_QUARTERSTAFF = 626;
    public const int FEAT_EPIC_WEAPON_FOCUS_SHORTSPEAR = 627;
    public const int FEAT_EPIC_WEAPON_FOCUS_SICKLE = 628;
    public const int FEAT_EPIC_WEAPON_FOCUS_SLING = 629;
    public const int FEAT_EPIC_WEAPON_FOCUS_UNARMED = 630;
    public const int FEAT_EPIC_WEAPON_FOCUS_LONGBOW = 631;
    public const int FEAT_EPIC_WEAPON_FOCUS_SHORTBOW = 632;
    public const int FEAT_EPIC_WEAPON_FOCUS_SHORTSWORD = 633;
    public const int FEAT_EPIC_WEAPON_FOCUS_RAPIER = 634;
    public const int FEAT_EPIC_WEAPON_FOCUS_SCIMITAR = 635;
    public const int FEAT_EPIC_WEAPON_FOCUS_LONGSWORD = 636;
    public const int FEAT_EPIC_WEAPON_FOCUS_GREATSWORD = 637;
    public const int FEAT_EPIC_WEAPON_FOCUS_HANDAXE = 638;
    public const int FEAT_EPIC_WEAPON_FOCUS_THROWINGAXE = 639;
    public const int FEAT_EPIC_WEAPON_FOCUS_BATTLEAXE = 640;
    public const int FEAT_EPIC_WEAPON_FOCUS_GREATAXE = 641;
    public const int FEAT_EPIC_WEAPON_FOCUS_HALBERD = 642;
    public const int FEAT_EPIC_WEAPON_FOCUS_LIGHTHAMMER = 643;
    public const int FEAT_EPIC_WEAPON_FOCUS_LIGHTFLAIL = 644;
    public const int FEAT_EPIC_WEAPON_FOCUS_WARHAMMER = 645;
    public const int FEAT_EPIC_WEAPON_FOCUS_HEAVYFLAIL = 646;
    public const int FEAT_EPIC_WEAPON_FOCUS_KAMA = 647;
    public const int FEAT_EPIC_WEAPON_FOCUS_KUKRI = 648;
    public const int FEAT_EPIC_WEAPON_FOCUS_SHURIKEN = 649;
    public const int FEAT_EPIC_WEAPON_FOCUS_SCYTHE = 650;
    public const int FEAT_EPIC_WEAPON_FOCUS_KATANA = 651;
    public const int FEAT_EPIC_WEAPON_FOCUS_BASTARDSWORD = 652;
    public const int FEAT_EPIC_WEAPON_FOCUS_DIREMACE = 653;
    public const int FEAT_EPIC_WEAPON_FOCUS_DOUBLEAXE = 654;
    public const int FEAT_EPIC_WEAPON_FOCUS_TWOBLADEDSWORD = 655;
    public const int FEAT_EPIC_WEAPON_FOCUS_CREATURE = 656;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_CLUB = 657;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_DAGGER = 658;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_DART = 659;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_HEAVYCROSSBOW = 660;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_LIGHTCROSSBOW = 661;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_LIGHTMACE = 662;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_MORNINGSTAR = 663;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_QUARTERSTAFF = 664;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SHORTSPEAR = 665;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SICKLE = 666;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SLING = 667;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_UNARMED = 668;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_LONGBOW = 669;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SHORTBOW = 670;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SHORTSWORD = 671;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_RAPIER = 672;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SCIMITAR = 673;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_LONGSWORD = 674;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_GREATSWORD = 675;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_HANDAXE = 676;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_THROWINGAXE = 677;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_BATTLEAXE = 678;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_GREATAXE = 679;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_HALBERD = 680;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_LIGHTHAMMER = 681;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_LIGHTFLAIL = 682;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_WARHAMMER = 683;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_HEAVYFLAIL = 684;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_KAMA = 685;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_KUKRI = 686;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SHURIKEN = 687;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_SCYTHE = 688;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_KATANA = 689;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_BASTARDSWORD = 690;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_DIREMACE = 691;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_DOUBLEAXE = 692;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_TWOBLADEDSWORD = 693;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_CREATURE = 694;
    public const int FEAT_EPIC_WILL = 695;
    public const int FEAT_EPIC_IMPROVED_COMBAT_CASTING = 696;
    public const int FEAT_EPIC_IMPROVED_KI_STRIKE_4 = 697;
    public const int FEAT_EPIC_IMPROVED_KI_STRIKE_5 = 698;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_1 = 699;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_2 = 700;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_3 = 701;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_4 = 702;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_5 = 703;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_6 = 704;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_7 = 705;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_8 = 706;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_9 = 707;
    public const int FEAT_EPIC_IMPROVED_SPELL_RESISTANCE_10 = 708;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_CLUB = 709;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_DAGGER = 710;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_DART = 711;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_HEAVYCROSSBOW = 712;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_LIGHTCROSSBOW = 713;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_LIGHTMACE = 714;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_MORNINGSTAR = 715;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_QUARTERSTAFF = 716;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SHORTSPEAR = 717;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SICKLE = 718;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SLING = 719;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_UNARMED = 720;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_LONGBOW = 721;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SHORTBOW = 722;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SHORTSWORD = 723;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_RAPIER = 724;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SCIMITAR = 725;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_LONGSWORD = 726;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_GREATSWORD = 727;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_HANDAXE = 728;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_THROWINGAXE = 729;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_BATTLEAXE = 730;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_GREATAXE = 731;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_HALBERD = 732;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_LIGHTHAMMER = 733;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_LIGHTFLAIL = 734;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_WARHAMMER = 735;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_HEAVYFLAIL = 736;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_KAMA = 737;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_KUKRI = 738;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SHURIKEN = 739;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_SCYTHE = 740;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_KATANA = 741;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_BASTARDSWORD = 742;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_DIREMACE = 743;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_DOUBLEAXE = 744;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_TWOBLADEDSWORD = 745;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_CREATURE = 746;
    public const int FEAT_EPIC_PERFECT_HEALTH = 747;
    public const int FEAT_EPIC_SELF_CONCEALMENT_10 = 748;
    public const int FEAT_EPIC_SELF_CONCEALMENT_20 = 749;
    public const int FEAT_EPIC_SELF_CONCEALMENT_30 = 750;
    public const int FEAT_EPIC_SELF_CONCEALMENT_40 = 751;
    public const int FEAT_EPIC_SELF_CONCEALMENT_50 = 752;
    public const int FEAT_EPIC_SUPERIOR_INITIATIVE = 753;
    public const int FEAT_EPIC_TOUGHNESS_1 = 754;
    public const int FEAT_EPIC_TOUGHNESS_2 = 755;
    public const int FEAT_EPIC_TOUGHNESS_3 = 756;
    public const int FEAT_EPIC_TOUGHNESS_4 = 757;
    public const int FEAT_EPIC_TOUGHNESS_5 = 758;
    public const int FEAT_EPIC_TOUGHNESS_6 = 759;
    public const int FEAT_EPIC_TOUGHNESS_7 = 760;
    public const int FEAT_EPIC_TOUGHNESS_8 = 761;
    public const int FEAT_EPIC_TOUGHNESS_9 = 762;
    public const int FEAT_EPIC_TOUGHNESS_10 = 763;
    public const int FEAT_EPIC_GREAT_CHARISMA_1 = 764;
    public const int FEAT_EPIC_GREAT_CHARISMA_2 = 765;
    public const int FEAT_EPIC_GREAT_CHARISMA_3 = 766;
    public const int FEAT_EPIC_GREAT_CHARISMA_4 = 767;
    public const int FEAT_EPIC_GREAT_CHARISMA_5 = 768;
    public const int FEAT_EPIC_GREAT_CHARISMA_6 = 769;
    public const int FEAT_EPIC_GREAT_CHARISMA_7 = 770;
    public const int FEAT_EPIC_GREAT_CHARISMA_8 = 771;
    public const int FEAT_EPIC_GREAT_CHARISMA_9 = 772;
    public const int FEAT_EPIC_GREAT_CHARISMA_10 = 773;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_1 = 774;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_2 = 775;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_3 = 776;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_4 = 777;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_5 = 778;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_6 = 779;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_7 = 780;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_8 = 781;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_9 = 782;
    public const int FEAT_EPIC_GREAT_CONSTITUTION_10 = 783;
    public const int FEAT_EPIC_GREAT_DEXTERITY_1 = 784;
    public const int FEAT_EPIC_GREAT_DEXTERITY_2 = 785;
    public const int FEAT_EPIC_GREAT_DEXTERITY_3 = 786;
    public const int FEAT_EPIC_GREAT_DEXTERITY_4 = 787;
    public const int FEAT_EPIC_GREAT_DEXTERITY_5 = 788;
    public const int FEAT_EPIC_GREAT_DEXTERITY_6 = 789;
    public const int FEAT_EPIC_GREAT_DEXTERITY_7 = 790;
    public const int FEAT_EPIC_GREAT_DEXTERITY_8 = 791;
    public const int FEAT_EPIC_GREAT_DEXTERITY_9 = 792;
    public const int FEAT_EPIC_GREAT_DEXTERITY_10 = 793;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_1 = 794;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_2 = 795;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_3 = 796;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_4 = 797;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_5 = 798;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_6 = 799;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_7 = 800;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_8 = 801;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_9 = 802;
    public const int FEAT_EPIC_GREAT_INTELLIGENCE_10 = 803;
    public const int FEAT_EPIC_GREAT_WISDOM_1 = 804;
    public const int FEAT_EPIC_GREAT_WISDOM_2 = 805;
    public const int FEAT_EPIC_GREAT_WISDOM_3 = 806;
    public const int FEAT_EPIC_GREAT_WISDOM_4 = 807;
    public const int FEAT_EPIC_GREAT_WISDOM_5 = 808;
    public const int FEAT_EPIC_GREAT_WISDOM_6 = 809;
    public const int FEAT_EPIC_GREAT_WISDOM_7 = 810;
    public const int FEAT_EPIC_GREAT_WISDOM_8 = 811;
    public const int FEAT_EPIC_GREAT_WISDOM_9 = 812;
    public const int FEAT_EPIC_GREAT_WISDOM_10 = 813;
    public const int FEAT_EPIC_GREAT_STRENGTH_1 = 814;
    public const int FEAT_EPIC_GREAT_STRENGTH_2 = 815;
    public const int FEAT_EPIC_GREAT_STRENGTH_3 = 816;
    public const int FEAT_EPIC_GREAT_STRENGTH_4 = 817;
    public const int FEAT_EPIC_GREAT_STRENGTH_5 = 818;
    public const int FEAT_EPIC_GREAT_STRENGTH_6 = 819;
    public const int FEAT_EPIC_GREAT_STRENGTH_7 = 820;
    public const int FEAT_EPIC_GREAT_STRENGTH_8 = 821;
    public const int FEAT_EPIC_GREAT_STRENGTH_9 = 822;
    public const int FEAT_EPIC_GREAT_STRENGTH_10 = 823;
    public const int FEAT_EPIC_GREAT_SMITING_1 = 824;
    public const int FEAT_EPIC_GREAT_SMITING_2 = 825;
    public const int FEAT_EPIC_GREAT_SMITING_3 = 826;
    public const int FEAT_EPIC_GREAT_SMITING_4 = 827;
    public const int FEAT_EPIC_GREAT_SMITING_5 = 828;
    public const int FEAT_EPIC_GREAT_SMITING_6 = 829;
    public const int FEAT_EPIC_GREAT_SMITING_7 = 830;
    public const int FEAT_EPIC_GREAT_SMITING_8 = 831;
    public const int FEAT_EPIC_GREAT_SMITING_9 = 832;
    public const int FEAT_EPIC_GREAT_SMITING_10 = 833;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_1 = 834;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_2 = 835;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_3 = 836;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_4 = 837;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_5 = 838;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_6 = 839;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_7 = 840;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_8 = 841;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_9 = 842;
    public const int FEAT_EPIC_IMPROVED_SNEAK_ATTACK_10 = 843;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_1 = 844;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_2 = 845;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_3 = 846;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_4 = 847;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_5 = 848;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_6 = 849;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_7 = 850;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_8 = 851;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_9 = 852;
    public const int FEAT_EPIC_IMPROVED_STUNNING_FIST_10 = 853;

    /// int FEAT_EPIC_PLANAR_TURNING     =  854;
    public const int FEAT_EPIC_BANE_OF_ENEMIES = 855;
    public const int FEAT_EPIC_DODGE = 856;
    public const int FEAT_EPIC_AUTOMATIC_QUICKEN_1 = 857;
    public const int FEAT_EPIC_AUTOMATIC_QUICKEN_2 = 858;
    public const int FEAT_EPIC_AUTOMATIC_QUICKEN_3 = 859;
    public const int FEAT_EPIC_AUTOMATIC_SILENT_SPELL_1 = 860;
    public const int FEAT_EPIC_AUTOMATIC_SILENT_SPELL_2 = 861;
    public const int FEAT_EPIC_AUTOMATIC_SILENT_SPELL_3 = 862;
    public const int FEAT_EPIC_AUTOMATIC_STILL_SPELL_1 = 863;
    public const int FEAT_EPIC_AUTOMATIC_STILL_SPELL_2 = 864;
    public const int FEAT_EPIC_AUTOMATIC_STILL_SPELL_3 = 865;
    public const int FEAT_SHOU_DISCIPLE_MARTIAL_FLURRY_LIGHT = 866;
    public const int FEAT_WHIRLWIND_ATTACK = 867;
    public const int FEAT_IMPROVED_WHIRLWIND = 868;
    public const int FEAT_MIGHTY_RAGE = 869;
    public const int FEAT_EPIC_LASTING_INSPIRATION = 870;
    public const int FEAT_CURSE_SONG = 871;
    public const int FEAT_EPIC_WILD_SHAPE_UNDEAD = 872;
    public const int FEAT_EPIC_WILD_SHAPE_DRAGON = 873;
    public const int FEAT_EPIC_SPELL_MUMMY_DUST = 874;
    public const int FEAT_EPIC_SPELL_DRAGON_KNIGHT = 875;
    public const int FEAT_EPIC_SPELL_HELLBALL = 876;
    public const int FEAT_EPIC_SPELL_MAGE_ARMOUR = 877;
    public const int FEAT_EPIC_SPELL_RUIN = 878;
    public const int FEAT_WEAPON_OF_CHOICE_SICKLE = 879;
    public const int FEAT_WEAPON_OF_CHOICE_KAMA = 880;
    public const int FEAT_WEAPON_OF_CHOICE_KUKRI = 881;
    public const int FEAT_KI_DAMAGE = 882;
    public const int FEAT_INCREASE_MULTIPLIER = 883;
    public const int FEAT_SUPERIOR_WEAPON_FOCUS = 884;
    public const int FEAT_KI_CRITICAL = 885;
    public const int FEAT_BONE_SKIN_2 = 886;
    public const int FEAT_BONE_SKIN_4 = 887;
    public const int FEAT_BONE_SKIN_6 = 888;
    public const int FEAT_ANIMATE_DEAD = 889;
    public const int FEAT_SUMMON_UNDEAD = 890;
    public const int FEAT_DEATHLESS_VIGOR = 891;
    public const int FEAT_UNDEAD_GRAFT_1 = 892;
    public const int FEAT_UNDEAD_GRAFT_2 = 893;
    public const int FEAT_TOUGH_AS_BONE = 894;
    public const int FEAT_SUMMON_GREATER_UNDEAD = 895;
    public const int FEAT_DEATHLESS_MASTERY = 896;
    public const int FEAT_DEATHLESS_MASTER_TOUCH = 897;
    public const int FEAT_GREATER_WILDSHAPE_1 = 898;
    public const int FEAT_SHOU_DISCIPLE_MARTIAL_FLURRY_ANY = 899;
    public const int FEAT_GREATER_WILDSHAPE_2 = 900;
    public const int FEAT_GREATER_WILDSHAPE_3 = 901;
    public const int FEAT_HUMANOID_SHAPE = 902;
    public const int FEAT_GREATER_WILDSHAPE_4 = 903;
    public const int FEAT_SACRED_DEFENSE_1 = 904;
    public const int FEAT_SACRED_DEFENSE_2 = 905;
    public const int FEAT_SACRED_DEFENSE_3 = 906;
    public const int FEAT_SACRED_DEFENSE_4 = 907;
    public const int FEAT_SACRED_DEFENSE_5 = 908;
    public const int FEAT_DIVINE_WRATH = 909;
    public const int FEAT_EXTRA_SMITING = 910;
    public const int FEAT_SKILL_FOCUS_CRAFT_ARMOR = 911;
    public const int FEAT_SKILL_FOCUS_CRAFT_WEAPON = 912;
    public const int FEAT_EPIC_SKILL_FOCUS_CRAFT_ARMOR = 913;
    public const int FEAT_EPIC_SKILL_FOCUS_CRAFT_WEAPON = 914;
    public const int FEAT_SKILL_FOCUS_BLUFF = 915;
    public const int FEAT_SKILL_FOCUS_INTIMIDATE = 916;
    public const int FEAT_EPIC_SKILL_FOCUS_BLUFF = 917;
    public const int FEAT_EPIC_SKILL_FOCUS_INTIMIDATE = 918;
    public const int FEAT_WEAPON_OF_CHOICE_CLUB = 919;
    public const int FEAT_WEAPON_OF_CHOICE_DAGGER = 920;
    public const int FEAT_WEAPON_OF_CHOICE_LIGHTMACE = 921;
    public const int FEAT_WEAPON_OF_CHOICE_MORNINGSTAR = 922;
    public const int FEAT_WEAPON_OF_CHOICE_QUARTERSTAFF = 923;
    public const int FEAT_WEAPON_OF_CHOICE_SHORTSPEAR = 924;
    public const int FEAT_WEAPON_OF_CHOICE_SHORTSWORD = 925;
    public const int FEAT_WEAPON_OF_CHOICE_RAPIER = 926;
    public const int FEAT_WEAPON_OF_CHOICE_SCIMITAR = 927;
    public const int FEAT_WEAPON_OF_CHOICE_LONGSWORD = 928;
    public const int FEAT_WEAPON_OF_CHOICE_GREATSWORD = 929;
    public const int FEAT_WEAPON_OF_CHOICE_HANDAXE = 930;
    public const int FEAT_WEAPON_OF_CHOICE_BATTLEAXE = 931;
    public const int FEAT_WEAPON_OF_CHOICE_GREATAXE = 932;
    public const int FEAT_WEAPON_OF_CHOICE_HALBERD = 933;
    public const int FEAT_WEAPON_OF_CHOICE_LIGHTHAMMER = 934;
    public const int FEAT_WEAPON_OF_CHOICE_LIGHTFLAIL = 935;
    public const int FEAT_WEAPON_OF_CHOICE_WARHAMMER = 936;
    public const int FEAT_WEAPON_OF_CHOICE_HEAVYFLAIL = 937;
    public const int FEAT_WEAPON_OF_CHOICE_SCYTHE = 938;
    public const int FEAT_WEAPON_OF_CHOICE_KATANA = 939;
    public const int FEAT_WEAPON_OF_CHOICE_BASTARDSWORD = 940;
    public const int FEAT_WEAPON_OF_CHOICE_DIREMACE = 941;
    public const int FEAT_WEAPON_OF_CHOICE_DOUBLEAXE = 942;
    public const int FEAT_WEAPON_OF_CHOICE_TWOBLADEDSWORD = 943;
    public const int FEAT_BREW_POTION = 944;
    public const int FEAT_SCRIBE_SCROLL = 945;
    public const int FEAT_CRAFT_WAND = 946;
    public const int FEAT_DWARVEN_DEFENDER_DEFENSIVE_STANCE = 947;
    public const int FEAT_DAMAGE_REDUCTION_6 = 948;
    public const int FEAT_PRESTIGE_DEFENSIVE_AWARENESS_1 = 949;
    public const int FEAT_PRESTIGE_DEFENSIVE_AWARENESS_2 = 950;
    public const int FEAT_PRESTIGE_DEFENSIVE_AWARENESS_3 = 951;
    public const int FEAT_WEAPON_FOCUS_DWAXE = 952;
    public const int FEAT_WEAPON_SPECIALIZATION_DWAXE = 953;
    public const int FEAT_IMPROVED_CRITICAL_DWAXE = 954;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_DWAXE = 955;
    public const int FEAT_EPIC_WEAPON_FOCUS_DWAXE = 956;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_DWAXE = 957;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_DWAXE = 958;
    public const int FEAT_WEAPON_OF_CHOICE_DWAXE = 959;
    public const int FEAT_USE_POISON = 960;
    public const int FEAT_DRAGON_ARMOR = 961;
    public const int FEAT_DRAGON_ABILITIES = 962;
    public const int FEAT_DRAGON_IMMUNE_PARALYSIS = 963;
    public const int FEAT_DRAGON_IMMUNE_FIRE = 964;
    public const int FEAT_DRAGON_DIS_BREATH = 965;
    public const int FEAT_EPIC_FIGHTER = 966;
    public const int FEAT_EPIC_BARBARIAN = 967;
    public const int FEAT_EPIC_BARD = 968;
    public const int FEAT_EPIC_CLERIC = 969;
    public const int FEAT_EPIC_DRUID = 970;
    public const int FEAT_EPIC_MONK = 971;
    public const int FEAT_EPIC_PALADIN = 972;
    public const int FEAT_EPIC_RANGER = 973;
    public const int FEAT_EPIC_ROGUE = 974;
    public const int FEAT_EPIC_SORCERER = 975;
    public const int FEAT_EPIC_WIZARD = 976;
    public const int FEAT_EPIC_ARCANE_ARCHER = 977;
    public const int FEAT_EPIC_ASSASSIN = 978;
    public const int FEAT_EPIC_BLACKGUARD = 979;
    public const int FEAT_EPIC_SHADOWDANCER = 980;
    public const int FEAT_EPIC_HARPER_SCOUT = 981;
    public const int FEAT_EPIC_DIVINE_CHAMPION = 982;
    public const int FEAT_EPIC_WEAPON_MASTER = 983;
    public const int FEAT_EPIC_PALE_MASTER = 984;
    public const int FEAT_EPIC_DWARVEN_DEFENDER = 985;
    public const int FEAT_EPIC_SHIFTER = 986;
    public const int FEAT_EPIC_RED_DRAGON_DISC = 987;
    public const int FEAT_EPIC_THUNDERING_RAGE = 988;
    public const int FEAT_EPIC_TERRIFYING_RAGE = 989;
    public const int FEAT_EPIC_SPELL_EPIC_WARDING = 990;
    public const int FEAT_WEAPON_FOCUS_WHIP = 993;
    public const int FEAT_WEAPON_SPECIALIZATION_WHIP = 994;
    public const int FEAT_IMPROVED_CRITICAL_WHIP = 995;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_WHIP = 996;
    public const int FEAT_EPIC_WEAPON_FOCUS_WHIP = 997;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_WHIP = 998;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_WHIP = 999;
    public const int FEAT_WEAPON_OF_CHOICE_WHIP = 1000;
    public const int FEAT_EPIC_CHARACTER = 1001;
    public const int FEAT_EPIC_EPIC_SHADOWLORD = 1002;
    public const int FEAT_EPIC_EPIC_FIEND = 1003;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_6 = 1004;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_7 = 1005;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_8 = 1006;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_4D6 = 1007;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_5D6 = 1008;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_6D6 = 1009;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_7D6 = 1010;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_8D6 = 1011;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_9D6 = 1012;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_10D6 = 1013;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_11D6 = 1014;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_12D6 = 1015;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_13D6 = 1016;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_14D6 = 1017;
    public const int FEAT_BLACKGUARD_SNEAK_ATTACK_15D6 = 1018;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_9 = 1019;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_10 = 1020;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_11 = 1021;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_12 = 1022;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_13 = 1023;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_14 = 1024;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_15 = 1025;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_16 = 1026;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_17 = 1027;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_18 = 1028;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_19 = 1029;
    public const int FEAT_PRESTIGE_DEATH_ATTACK_20 = 1030;
    public const int FEAT_SHOU_DISCIPLE_DODGE_3 = 1031;
    public const int FEAT_DRAGON_HDINCREASE_D6 = 1042;
    public const int FEAT_DRAGON_HDINCREASE_D8 = 1043;
    public const int FEAT_DRAGON_HDINCREASE_D10 = 1044;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_6 = 1045;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_7 = 1046;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_8 = 1047;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_9 = 1048;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_10 = 1049;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_11 = 1050;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_12 = 1051;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_13 = 1052;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_14 = 1053;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_15 = 1054;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_16 = 1055;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_17 = 1056;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_18 = 1057;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_19 = 1058;
    public const int FEAT_PRESTIGE_ENCHANT_ARROW_20 = 1059;
    public const int FEAT_EPIC_OUTSIDER_SHAPE = 1060;
    public const int FEAT_EPIC_CONSTRUCT_SHAPE = 1061;
    public const int FEAT_EPIC_SHIFTER_INFINITE_WILDSHAPE_1 = 1062;
    public const int FEAT_EPIC_SHIFTER_INFINITE_WILDSHAPE_2 = 1063;
    public const int FEAT_EPIC_SHIFTER_INFINITE_WILDSHAPE_3 = 1064;
    public const int FEAT_EPIC_SHIFTER_INFINITE_WILDSHAPE_4 = 1065;
    public const int FEAT_EPIC_SHIFTER_INFINITE_HUMANOID_SHAPE = 1066;
    public const int FEAT_EPIC_BARBARIAN_DAMAGE_REDUCTION = 1067;
    public const int FEAT_EPIC_DRUID_INFINITE_WILDSHAPE = 1068;
    public const int FEAT_EPIC_DRUID_INFINITE_ELEMENTAL_SHAPE = 1069;
    public const int FEAT_PRESTIGE_POISON_SAVE_EPIC = 1070;
    public const int FEAT_EPIC_SUPERIOR_WEAPON_FOCUS = 1071;
    public const int FEAT_WEAPON_FOCUS_TRIDENT = 1072;
    public const int FEAT_WEAPON_SPECIALIZATION_TRIDENT = 1073;
    public const int FEAT_IMPROVED_CRITICAL_TRIDENT = 1074;
    public const int FEAT_EPIC_DEVASTATING_CRITICAL_TRIDENT = 1075;
    public const int FEAT_EPIC_WEAPON_FOCUS_TRIDENT = 1076;
    public const int FEAT_EPIC_WEAPON_SPECIALIZATION_TRIDENT = 1077;
    public const int FEAT_EPIC_OVERWHELMING_CRITICAL_TRIDENT = 1078;
    public const int FEAT_WEAPON_OF_CHOICE_TRIDENT = 1079;
    public const int FEAT_PDK_RALLY = 1080;
    public const int FEAT_PDK_SHIELD = 1081;
    public const int FEAT_PDK_FEAR = 1082;
    public const int FEAT_PDK_WRATH = 1083;
    public const int FEAT_PDK_STAND = 1084;
    public const int FEAT_PDK_INSPIRE_1 = 1085;
    public const int FEAT_PDK_INSPIRE_2 = 1086;
    public const int FEAT_MOUNTED_COMBAT = 1087;
    public const int FEAT_MOUNTED_ARCHERY = 1088;
    public const int FEAT_HORSE_MENU = 1089;
    public const int FEAT_HORSE_MOUNT = 1090;
    public const int FEAT_HORSE_DISMOUNT = 1091;
    public const int FEAT_HORSE_PARTY_MOUNT = 1092;
    public const int FEAT_HORSE_PARTY_DISMOUNT = 1093;
    public const int FEAT_HORSE_ASSIGN_MOUNT = 1094;
    public const int FEAT_PALADIN_SUMMON_MOUNT = 1095;
    public const int FEAT_PLAYER_TOOL_01 = 1106;
    public const int FEAT_PLAYER_TOOL_02 = 1107;
    public const int FEAT_PLAYER_TOOL_03 = 1108;
    public const int FEAT_PLAYER_TOOL_04 = 1109;
    public const int FEAT_PLAYER_TOOL_05 = 1110;
    public const int FEAT_PLAYER_TOOL_06 = 1111;
    public const int FEAT_PLAYER_TOOL_07 = 1112;
    public const int FEAT_PLAYER_TOOL_08 = 1113;
    public const int FEAT_PLAYER_TOOL_09 = 1114;
    public const int FEAT_PLAYER_TOOL_10 = 1115;

    ///  Special Attack Defines
    public const int SPECIAL_ATTACK_INVALID = 0;
    public const int SPECIAL_ATTACK_CALLED_SHOT_LEG = 1;
    public const int SPECIAL_ATTACK_CALLED_SHOT_ARM = 2;
    public const int SPECIAL_ATTACK_SAP = 3;
    public const int SPECIAL_ATTACK_DISARM = 4;
    public const int SPECIAL_ATTACK_IMPROVED_DISARM = 5;
    public const int SPECIAL_ATTACK_KNOCKDOWN = 6;
    public const int SPECIAL_ATTACK_IMPROVED_KNOCKDOWN = 7;
    public const int SPECIAL_ATTACK_STUNNING_FIST = 8;
    public const int SPECIAL_ATTACK_FLURRY_OF_BLOWS = 9;
    public const int SPECIAL_ATTACK_RAPID_SHOT = 10;

    ///  Combat Mode Defines
    public const int COMBAT_MODE_INVALID = 0;
    public const int COMBAT_MODE_PARRY = 1;
    public const int COMBAT_MODE_POWER_ATTACK = 2;
    public const int COMBAT_MODE_IMPROVED_POWER_ATTACK = 3;
    public const int COMBAT_MODE_FLURRY_OF_BLOWS = 4;
    public const int COMBAT_MODE_RAPID_SHOT = 5;
    public const int COMBAT_MODE_EXPERTISE = 6;
    public const int COMBAT_MODE_IMPROVED_EXPERTISE = 7;
    public const int COMBAT_MODE_DEFENSIVE_CASTING = 8;
    public const int COMBAT_MODE_DIRTY_FIGHTING = 9;
    public const int COMBAT_MODE_DEFENSIVE_STANCE = 10;

    ///  These represent the row in the difficulty 2da, rather than<br/>
    ///  a difficulty value.
    public const int ENCOUNTER_DIFFICULTY_VERY_EASY = 0;
    public const int ENCOUNTER_DIFFICULTY_EASY = 1;
    public const int ENCOUNTER_DIFFICULTY_NORMAL = 2;
    public const int ENCOUNTER_DIFFICULTY_HARD = 3;
    public const int ENCOUNTER_DIFFICULTY_IMPOSSIBLE = 4;

    ///  Looping animation constants.
    public const int ANIMATION_LOOPING_PAUSE = 0;
    public const int ANIMATION_LOOPING_PAUSE2 = 1;
    public const int ANIMATION_LOOPING_LISTEN = 2;
    public const int ANIMATION_LOOPING_MEDITATE = 3;
    public const int ANIMATION_LOOPING_WORSHIP = 4;
    public const int ANIMATION_LOOPING_LOOK_FAR = 5;
    public const int ANIMATION_LOOPING_SIT_CHAIR = 6;
    public const int ANIMATION_LOOPING_SIT_CROSS = 7;
    public const int ANIMATION_LOOPING_TALK_NORMAL = 8;
    public const int ANIMATION_LOOPING_TALK_PLEADING = 9;
    public const int ANIMATION_LOOPING_TALK_FORCEFUL = 10;
    public const int ANIMATION_LOOPING_TALK_LAUGHING = 11;
    public const int ANIMATION_LOOPING_GET_LOW = 12;
    public const int ANIMATION_LOOPING_GET_MID = 13;
    public const int ANIMATION_LOOPING_PAUSE_TIRED = 14;
    public const int ANIMATION_LOOPING_PAUSE_DRUNK = 15;
    public const int ANIMATION_LOOPING_DEAD_FRONT = 16;
    public const int ANIMATION_LOOPING_DEAD_BACK = 17;
    public const int ANIMATION_LOOPING_CONJURE1 = 18;
    public const int ANIMATION_LOOPING_CONJURE2 = 19;
    public const int ANIMATION_LOOPING_SPASM = 20;
    public const int ANIMATION_LOOPING_CUSTOM1 = 21;
    public const int ANIMATION_LOOPING_CUSTOM2 = 22;
    public const int ANIMATION_LOOPING_CUSTOM3 = 23;
    public const int ANIMATION_LOOPING_CUSTOM4 = 24;
    public const int ANIMATION_LOOPING_CUSTOM5 = 25;
    public const int ANIMATION_LOOPING_CUSTOM6 = 26;
    public const int ANIMATION_LOOPING_CUSTOM7 = 27;
    public const int ANIMATION_LOOPING_CUSTOM8 = 28;
    public const int ANIMATION_LOOPING_CUSTOM9 = 29;
    public const int ANIMATION_LOOPING_CUSTOM10 = 30;
    public const int ANIMATION_LOOPING_CUSTOM11 = 31;
    public const int ANIMATION_LOOPING_CUSTOM12 = 32;
    public const int ANIMATION_LOOPING_CUSTOM13 = 33;
    public const int ANIMATION_LOOPING_CUSTOM14 = 34;
    public const int ANIMATION_LOOPING_CUSTOM15 = 35;
    public const int ANIMATION_LOOPING_CUSTOM16 = 36;
    public const int ANIMATION_LOOPING_CUSTOM17 = 37;
    public const int ANIMATION_LOOPING_CUSTOM18 = 38;
    public const int ANIMATION_LOOPING_CUSTOM19 = 39;
    public const int ANIMATION_LOOPING_CUSTOM20 = 40;
    public const int ANIMATION_MOUNT1 = 41;
    public const int ANIMATION_DISMOUNT1 = 42;
    public const int ANIMATION_LOOPING_CUSTOM21 = 43;
    public const int ANIMATION_LOOPING_CUSTOM22 = 44;
    public const int ANIMATION_LOOPING_CUSTOM23 = 45;
    public const int ANIMATION_LOOPING_CUSTOM24 = 46;
    public const int ANIMATION_LOOPING_CUSTOM25 = 47;
    public const int ANIMATION_LOOPING_CUSTOM26 = 48;
    public const int ANIMATION_LOOPING_CUSTOM27 = 49;
    public const int ANIMATION_LOOPING_CUSTOM28 = 50;
    public const int ANIMATION_LOOPING_CUSTOM29 = 51;
    public const int ANIMATION_LOOPING_CUSTOM30 = 52;
    public const int ANIMATION_LOOPING_CUSTOM31 = 53;
    public const int ANIMATION_LOOPING_CUSTOM32 = 54;
    public const int ANIMATION_LOOPING_CUSTOM33 = 55;
    public const int ANIMATION_LOOPING_CUSTOM34 = 56;
    public const int ANIMATION_LOOPING_CUSTOM35 = 57;
    public const int ANIMATION_LOOPING_CUSTOM36 = 58;
    public const int ANIMATION_LOOPING_CUSTOM37 = 59;
    public const int ANIMATION_LOOPING_CUSTOM38 = 60;
    public const int ANIMATION_LOOPING_CUSTOM39 = 61;
    public const int ANIMATION_LOOPING_CUSTOM40 = 62;
    public const int ANIMATION_LOOPING_CUSTOM41 = 63;
    public const int ANIMATION_LOOPING_CUSTOM42 = 64;
    public const int ANIMATION_LOOPING_CUSTOM43 = 65;
    public const int ANIMATION_LOOPING_CUSTOM44 = 66;
    public const int ANIMATION_LOOPING_CUSTOM45 = 67;
    public const int ANIMATION_LOOPING_CUSTOM46 = 68;
    public const int ANIMATION_LOOPING_CUSTOM47 = 69;
    public const int ANIMATION_LOOPING_CUSTOM48 = 70;
    public const int ANIMATION_LOOPING_CUSTOM49 = 71;
    public const int ANIMATION_LOOPING_CUSTOM50 = 72;
    public const int ANIMATION_LOOPING_CUSTOM51 = 73;
    public const int ANIMATION_LOOPING_CUSTOM52 = 74;
    public const int ANIMATION_LOOPING_CUSTOM53 = 75;
    public const int ANIMATION_LOOPING_CUSTOM54 = 76;
    public const int ANIMATION_LOOPING_CUSTOM55 = 77;
    public const int ANIMATION_LOOPING_CUSTOM56 = 78;
    public const int ANIMATION_LOOPING_CUSTOM57 = 79;
    public const int ANIMATION_LOOPING_CUSTOM58 = 80;
    public const int ANIMATION_LOOPING_CUSTOM59 = 81;
    public const int ANIMATION_LOOPING_CUSTOM60 = 82;
    public const int ANIMATION_LOOPING_CUSTOM61 = 83;
    public const int ANIMATION_LOOPING_CUSTOM62 = 84;
    public const int ANIMATION_LOOPING_CUSTOM63 = 85;
    public const int ANIMATION_LOOPING_CUSTOM64 = 86;
    public const int ANIMATION_LOOPING_CUSTOM65 = 87;
    public const int ANIMATION_LOOPING_CUSTOM66 = 88;
    public const int ANIMATION_LOOPING_CUSTOM67 = 89;
    public const int ANIMATION_LOOPING_CUSTOM68 = 90;
    public const int ANIMATION_LOOPING_CUSTOM69 = 91;
    public const int ANIMATION_LOOPING_CUSTOM70 = 92;

    ///  Fire and forget animation constants.
    public const int ANIMATION_FIREFORGET_HEAD_TURN_LEFT = 100;
    public const int ANIMATION_FIREFORGET_HEAD_TURN_RIGHT = 101;
    public const int ANIMATION_FIREFORGET_PAUSE_SCRATCH_HEAD = 102;
    public const int ANIMATION_FIREFORGET_PAUSE_BORED = 103;
    public const int ANIMATION_FIREFORGET_SALUTE = 104;
    public const int ANIMATION_FIREFORGET_BOW = 105;
    public const int ANIMATION_FIREFORGET_STEAL = 106;
    public const int ANIMATION_FIREFORGET_GREETING = 107;
    public const int ANIMATION_FIREFORGET_TAUNT = 108;
    public const int ANIMATION_FIREFORGET_VICTORY1 = 109;
    public const int ANIMATION_FIREFORGET_VICTORY2 = 110;
    public const int ANIMATION_FIREFORGET_VICTORY3 = 111;
    public const int ANIMATION_FIREFORGET_READ = 112;
    public const int ANIMATION_FIREFORGET_DRINK = 113;
    public const int ANIMATION_FIREFORGET_DODGE_SIDE = 114;
    public const int ANIMATION_FIREFORGET_DODGE_DUCK = 115;
    public const int ANIMATION_FIREFORGET_SPASM = 116;

    ///  Placeable animation constants
    public const int ANIMATION_PLACEABLE_ACTIVATE = 200;
    public const int ANIMATION_PLACEABLE_DEACTIVATE = 201;
    public const int ANIMATION_PLACEABLE_OPEN = 202;
    public const int ANIMATION_PLACEABLE_CLOSE = 203;

    ///  Door animation constants
    public const int ANIMATION_DOOR_CLOSE = 204;
    public const int ANIMATION_DOOR_OPEN1 = 205;
    public const int ANIMATION_DOOR_OPEN2 = 206;
    public const int ANIMATION_DOOR_DESTROY = 207;
    public const int TALENT_TYPE_SPELL = 0;
    public const int TALENT_TYPE_FEAT = 1;
    public const int TALENT_TYPE_SKILL = 2;

    ///  These must match the values in nwscreature.h and nwccreaturemenu.cpp<br/>
    ///  Cannot use the value -1 because that is used to start a conversation
    public const int ASSOCIATE_COMMAND_STANDGROUND = -2;
    public const int ASSOCIATE_COMMAND_ATTACKNEAREST = -3;
    public const int ASSOCIATE_COMMAND_HEALMASTER = -4;
    public const int ASSOCIATE_COMMAND_FOLLOWMASTER = -5;
    public const int ASSOCIATE_COMMAND_MASTERFAILEDLOCKPICK = -6;
    public const int ASSOCIATE_COMMAND_GUARDMASTER = -7;
    public const int ASSOCIATE_COMMAND_UNSUMMONFAMILIAR = -8;
    public const int ASSOCIATE_COMMAND_UNSUMMONANIMALCOMPANION = -9;
    public const int ASSOCIATE_COMMAND_UNSUMMONSUMMONED = -10;
    public const int ASSOCIATE_COMMAND_MASTERUNDERATTACK = -11;
    public const int ASSOCIATE_COMMAND_RELEASEDOMINATION = -12;
    public const int ASSOCIATE_COMMAND_UNPOSSESSFAMILIAR = -13;
    public const int ASSOCIATE_COMMAND_MASTERSAWTRAP = -14;
    public const int ASSOCIATE_COMMAND_MASTERATTACKEDOTHER = -15;
    public const int ASSOCIATE_COMMAND_MASTERGOINGTOBEATTACKED = -16;
    public const int ASSOCIATE_COMMAND_LEAVEPARTY = -17;
    public const int ASSOCIATE_COMMAND_PICKLOCK = -18;
    public const int ASSOCIATE_COMMAND_INVENTORY = -19;
    public const int ASSOCIATE_COMMAND_DISARMTRAP = -20;
    public const int ASSOCIATE_COMMAND_TOGGLECASTING = -21;
    public const int ASSOCIATE_COMMAND_TOGGLESTEALTH = -22;
    public const int ASSOCIATE_COMMAND_TOGGLESEARCH = -23;

    ///  These match the values in nwscreature.h
    public const int ASSOCIATE_TYPE_NONE = 0;
    public const int ASSOCIATE_TYPE_HENCHMAN = 1;
    public const int ASSOCIATE_TYPE_ANIMALCOMPANION = 2;
    public const int ASSOCIATE_TYPE_FAMILIAR = 3;
    public const int ASSOCIATE_TYPE_SUMMONED = 4;
    public const int ASSOCIATE_TYPE_DOMINATED = 5;

    ///  These must match the list in nwscreaturestats.cpp
    public const int TALENT_CATEGORY_HARMFUL_AREAEFFECT_DISCRIMINANT = 1;
    public const int TALENT_CATEGORY_HARMFUL_RANGED = 2;
    public const int TALENT_CATEGORY_HARMFUL_TOUCH = 3;
    public const int TALENT_CATEGORY_BENEFICIAL_HEALING_AREAEFFECT = 4;
    public const int TALENT_CATEGORY_BENEFICIAL_HEALING_TOUCH = 5;
    public const int TALENT_CATEGORY_BENEFICIAL_CONDITIONAL_AREAEFFECT = 6;
    public const int TALENT_CATEGORY_BENEFICIAL_CONDITIONAL_SINGLE = 7;
    public const int TALENT_CATEGORY_BENEFICIAL_ENHANCEMENT_AREAEFFECT = 8;
    public const int TALENT_CATEGORY_BENEFICIAL_ENHANCEMENT_SINGLE = 9;
    public const int TALENT_CATEGORY_BENEFICIAL_ENHANCEMENT_SELF = 10;
    public const int TALENT_CATEGORY_HARMFUL_AREAEFFECT_INDISCRIMINANT = 11;
    public const int TALENT_CATEGORY_BENEFICIAL_PROTECTION_SELF = 12;
    public const int TALENT_CATEGORY_BENEFICIAL_PROTECTION_SINGLE = 13;
    public const int TALENT_CATEGORY_BENEFICIAL_PROTECTION_AREAEFFECT = 14;
    public const int TALENT_CATEGORY_BENEFICIAL_OBTAIN_ALLIES = 15;
    public const int TALENT_CATEGORY_PERSISTENT_AREA_OF_EFFECT = 16;
    public const int TALENT_CATEGORY_BENEFICIAL_HEALING_POTION = 17;
    public const int TALENT_CATEGORY_BENEFICIAL_CONDITIONAL_POTION = 18;
    public const int TALENT_CATEGORY_DRAGONS_BREATH = 19;
    public const int TALENT_CATEGORY_BENEFICIAL_PROTECTION_POTION = 20;
    public const int TALENT_CATEGORY_BENEFICIAL_ENHANCEMENT_POTION = 21;
    public const int TALENT_CATEGORY_HARMFUL_MELEE = 22;
    public const int INVENTORY_DISTURB_TYPE_ADDED = 0;
    public const int INVENTORY_DISTURB_TYPE_REMOVED = 1;
    public const int INVENTORY_DISTURB_TYPE_STOLEN = 2;
    public const int GUI_PANEL_PLAYER_DEATH = 0;
    public const int GUI_PANEL_MINIMAP = 2;
    public const int GUI_PANEL_COMPASS = 3;
    public const int GUI_PANEL_INVENTORY = 4;
    public const int GUI_PANEL_PLAYERLIST = 5;
    public const int GUI_PANEL_JOURNAL = 6;
    public const int GUI_PANEL_SPELLBOOK = 7;
    public const int GUI_PANEL_CHARACTERSHEET = 8;
    public const int GUI_PANEL_LEVELUP = 9;
    public const int GUI_PANEL_GOLD_INVENTORY = 10;
    public const int GUI_PANEL_GOLD_BARTER = 11;
    public const int GUI_PANEL_EXAMINE_CREATURE = 12;
    public const int GUI_PANEL_EXAMINE_ITEM = 13;
    public const int GUI_PANEL_EXAMINE_PLACEABLE = 14;
    public const int GUI_PANEL_EXAMINE_DOOR = 15;
    public const int VOICE_CHAT_ATTACK = 0;
    public const int VOICE_CHAT_BATTLECRY1 = 1;
    public const int VOICE_CHAT_BATTLECRY2 = 2;
    public const int VOICE_CHAT_BATTLECRY3 = 3;
    public const int VOICE_CHAT_HEALME = 4;
    public const int VOICE_CHAT_HELP = 5;
    public const int VOICE_CHAT_ENEMIES = 6;
    public const int VOICE_CHAT_FLEE = 7;
    public const int VOICE_CHAT_TAUNT = 8;
    public const int VOICE_CHAT_GUARDME = 9;
    public const int VOICE_CHAT_HOLD = 10;
    public const int VOICE_CHAT_GATTACK1 = 11;
    public const int VOICE_CHAT_GATTACK2 = 12;
    public const int VOICE_CHAT_GATTACK3 = 13;
    public const int VOICE_CHAT_PAIN1 = 14;
    public const int VOICE_CHAT_PAIN2 = 15;
    public const int VOICE_CHAT_PAIN3 = 16;
    public const int VOICE_CHAT_NEARDEATH = 17;
    public const int VOICE_CHAT_DEATH = 18;
    public const int VOICE_CHAT_POISONED = 19;
    public const int VOICE_CHAT_SPELLFAILED = 20;
    public const int VOICE_CHAT_WEAPONSUCKS = 21;
    public const int VOICE_CHAT_FOLLOWME = 22;
    public const int VOICE_CHAT_LOOKHERE = 23;
    public const int VOICE_CHAT_GROUP = 24;
    public const int VOICE_CHAT_MOVEOVER = 25;
    public const int VOICE_CHAT_PICKLOCK = 26;
    public const int VOICE_CHAT_SEARCH = 27;
    public const int VOICE_CHAT_HIDE = 28;
    public const int VOICE_CHAT_CANDO = 29;
    public const int VOICE_CHAT_CANTDO = 30;
    public const int VOICE_CHAT_TASKCOMPLETE = 31;
    public const int VOICE_CHAT_ENCUMBERED = 32;
    public const int VOICE_CHAT_SELECTED = 33;
    public const int VOICE_CHAT_HELLO = 34;
    public const int VOICE_CHAT_YES = 35;
    public const int VOICE_CHAT_NO = 36;
    public const int VOICE_CHAT_STOP = 37;
    public const int VOICE_CHAT_REST = 38;
    public const int VOICE_CHAT_BORED = 39;
    public const int VOICE_CHAT_GOODBYE = 40;
    public const int VOICE_CHAT_THANKS = 41;
    public const int VOICE_CHAT_LAUGH = 42;
    public const int VOICE_CHAT_CUSS = 43;
    public const int VOICE_CHAT_CHEER = 44;
    public const int VOICE_CHAT_TALKTOME = 45;
    public const int VOICE_CHAT_GOODIDEA = 46;
    public const int VOICE_CHAT_BADIDEA = 47;
    public const int VOICE_CHAT_THREATEN = 48;
    public const int POLYMORPH_TYPE_WEREWOLF = 0;
    public const int POLYMORPH_TYPE_WERERAT = 1;
    public const int POLYMORPH_TYPE_WERECAT = 2;
    public const int POLYMORPH_TYPE_GIANT_SPIDER = 3;
    public const int POLYMORPH_TYPE_TROLL = 4;
    public const int POLYMORPH_TYPE_UMBER_HULK = 5;
    public const int POLYMORPH_TYPE_PIXIE = 6;
    public const int POLYMORPH_TYPE_ZOMBIE = 7;
    public const int POLYMORPH_TYPE_RED_DRAGON = 8;
    public const int POLYMORPH_TYPE_FIRE_GIANT = 9;
    public const int POLYMORPH_TYPE_BALOR = 10;
    public const int POLYMORPH_TYPE_DEATH_SLAAD = 11;
    public const int POLYMORPH_TYPE_IRON_GOLEM = 12;
    public const int POLYMORPH_TYPE_HUGE_FIRE_ELEMENTAL = 13;
    public const int POLYMORPH_TYPE_HUGE_WATER_ELEMENTAL = 14;
    public const int POLYMORPH_TYPE_HUGE_EARTH_ELEMENTAL = 15;
    public const int POLYMORPH_TYPE_HUGE_AIR_ELEMENTAL = 16;
    public const int POLYMORPH_TYPE_ELDER_FIRE_ELEMENTAL = 17;
    public const int POLYMORPH_TYPE_ELDER_WATER_ELEMENTAL = 18;
    public const int POLYMORPH_TYPE_ELDER_EARTH_ELEMENTAL = 19;
    public const int POLYMORPH_TYPE_ELDER_AIR_ELEMENTAL = 20;
    public const int POLYMORPH_TYPE_BROWN_BEAR = 21;
    public const int POLYMORPH_TYPE_PANTHER = 22;
    public const int POLYMORPH_TYPE_WOLF = 23;
    public const int POLYMORPH_TYPE_BOAR = 24;
    public const int POLYMORPH_TYPE_BADGER = 25;
    public const int POLYMORPH_TYPE_PENGUIN = 26;
    public const int POLYMORPH_TYPE_COW = 27;
    public const int POLYMORPH_TYPE_DOOM_KNIGHT = 28;
    public const int POLYMORPH_TYPE_YUANTI = 29;
    public const int POLYMORPH_TYPE_IMP = 30;
    public const int POLYMORPH_TYPE_QUASIT = 31;
    public const int POLYMORPH_TYPE_SUCCUBUS = 32;
    public const int POLYMORPH_TYPE_DIRE_BROWN_BEAR = 33;
    public const int POLYMORPH_TYPE_DIRE_PANTHER = 34;
    public const int POLYMORPH_TYPE_DIRE_WOLF = 35;
    public const int POLYMORPH_TYPE_DIRE_BOAR = 36;
    public const int POLYMORPH_TYPE_DIRE_BADGER = 37;
    public const int POLYMORPH_TYPE_CELESTIAL_AVENGER = 38;
    public const int POLYMORPH_TYPE_VROCK = 39;
    public const int POLYMORPH_TYPE_CHICKEN = 40;
    public const int POLYMORPH_TYPE_FROST_GIANT_MALE = 41;
    public const int POLYMORPH_TYPE_FROST_GIANT_FEMALE = 42;
    public const int POLYMORPH_TYPE_HEURODIS = 43;
    public const int POLYMORPH_TYPE_JNAH_GIANT_MALE = 44;
    public const int POLYMORPH_TYPE_JNAH_GIANT_FEMAL = 45;
    public const int POLYMORPH_TYPE_WYRMLING_WHITE = 52;
    public const int POLYMORPH_TYPE_WYRMLING_BLUE = 53;
    public const int POLYMORPH_TYPE_WYRMLING_RED = 54;
    public const int POLYMORPH_TYPE_WYRMLING_GREEN = 55;
    public const int POLYMORPH_TYPE_WYRMLING_BLACK = 56;
    public const int POLYMORPH_TYPE_GOLEM_AUTOMATON = 57;
    public const int POLYMORPH_TYPE_MANTICORE = 58;
    public const int POLYMORPH_TYPE_MALE_DROW = 59;
    public const int POLYMORPH_TYPE_HARPY = 60;
    public const int POLYMORPH_TYPE_BASILISK = 61;
    public const int POLYMORPH_TYPE_DRIDER = 62;
    public const int POLYMORPH_TYPE_BEHOLDER = 63;
    public const int POLYMORPH_TYPE_MEDUSA = 64;
    public const int POLYMORPH_TYPE_GARGOYLE = 65;
    public const int POLYMORPH_TYPE_MINOTAUR = 66;
    public const int POLYMORPH_TYPE_SUPER_CHICKEN = 67;
    public const int POLYMORPH_TYPE_MINDFLAYER = 68;
    public const int POLYMORPH_TYPE_DIRETIGER = 69;
    public const int POLYMORPH_TYPE_FEMALE_DROW = 70;
    public const int POLYMORPH_TYPE_ANCIENT_BLUE_DRAGON = 71;
    public const int POLYMORPH_TYPE_ANCIENT_RED_DRAGON = 72;
    public const int POLYMORPH_TYPE_ANCIENT_GREEN_DRAGON = 73;
    public const int POLYMORPH_TYPE_VAMPIRE_MALE = 74;
    public const int POLYMORPH_TYPE_RISEN_LORD = 75;
    public const int POLYMORPH_TYPE_SPECTRE = 76;
    public const int POLYMORPH_TYPE_VAMPIRE_FEMALE = 77;
    public const int POLYMORPH_TYPE_NULL_HUMAN = 78;
    public const int INVISIBILITY_TYPE_NORMAL = 1;
    public const int INVISIBILITY_TYPE_DARKNESS = 2;
    public const int INVISIBILITY_TYPE_IMPROVED = 4;
    public const int CREATURE_SIZE_INVALID = 0;
    public const int CREATURE_SIZE_TINY = 1;
    public const int CREATURE_SIZE_SMALL = 2;
    public const int CREATURE_SIZE_MEDIUM = 3;
    public const int CREATURE_SIZE_LARGE = 4;
    public const int CREATURE_SIZE_HUGE = 5;
    public const int SPELL_SCHOOL_GENERAL = 0;
    public const int SPELL_SCHOOL_ABJURATION = 1;
    public const int SPELL_SCHOOL_CONJURATION = 2;
    public const int SPELL_SCHOOL_DIVINATION = 3;
    public const int SPELL_SCHOOL_ENCHANTMENT = 4;
    public const int SPELL_SCHOOL_EVOCATION = 5;
    public const int SPELL_SCHOOL_ILLUSION = 6;
    public const int SPELL_SCHOOL_NECROMANCY = 7;
    public const int SPELL_SCHOOL_TRANSMUTATION = 8;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_BADGER = 0;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_WOLF = 1;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_BEAR = 2;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_BOAR = 3;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_HAWK = 4;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_PANTHER = 5;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_SPIDER = 6;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_DIREWOLF = 7;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_DIRERAT = 8;
    public const int ANIMAL_COMPANION_CREATURE_TYPE_NONE = 255;
    public const int FAMILIAR_CREATURE_TYPE_BAT = 0;
    public const int FAMILIAR_CREATURE_TYPE_CRAGCAT = 1;
    public const int FAMILIAR_CREATURE_TYPE_HELLHOUND = 2;
    public const int FAMILIAR_CREATURE_TYPE_IMP = 3;
    public const int FAMILIAR_CREATURE_TYPE_FIREMEPHIT = 4;
    public const int FAMILIAR_CREATURE_TYPE_ICEMEPHIT = 5;
    public const int FAMILIAR_CREATURE_TYPE_PIXIE = 6;
    public const int FAMILIAR_CREATURE_TYPE_RAVEN = 7;
    public const int FAMILIAR_CREATURE_TYPE_FAIRY_DRAGON = 8;
    public const int FAMILIAR_CREATURE_TYPE_PSEUDO_DRAGON = 9;
    public const int FAMILIAR_CREATURE_TYPE_EYEBALL = 10;
    public const int FAMILIAR_CREATURE_TYPE_NONE = 255;
    public const int CAMERA_MODE_CHASE_CAMERA = 0;
    public const int CAMERA_MODE_TOP_DOWN = 1;
    public const int CAMERA_MODE_STIFF_CHASE_CAMERA = 2;
    public const int WEATHER_INVALID = -1;
    public const int WEATHER_CLEAR = 0;
    public const int WEATHER_RAIN = 1;
    public const int WEATHER_SNOW = 2;
    public const int WEATHER_USE_AREA_SETTINGS = -1;
    public const int REST_EVENTTYPE_REST_INVALID = 0;
    public const int REST_EVENTTYPE_REST_STARTED = 1;
    public const int REST_EVENTTYPE_REST_FINISHED = 2;
    public const int REST_EVENTTYPE_REST_CANCELLED = 3;
    public const int PROJECTILE_PATH_TYPE_DEFAULT = 0;
    public const int PROJECTILE_PATH_TYPE_HOMING = 1;
    public const int PROJECTILE_PATH_TYPE_BALLISTIC = 2;
    public const int PROJECTILE_PATH_TYPE_HIGH_BALLISTIC = 3;
    public const int PROJECTILE_PATH_TYPE_ACCELERATING = 4;
    public const int GAME_DIFFICULTY_VERY_EASY = 0;
    public const int GAME_DIFFICULTY_EASY = 1;
    public const int GAME_DIFFICULTY_NORMAL = 2;
    public const int GAME_DIFFICULTY_CORE_RULES = 3;
    public const int GAME_DIFFICULTY_DIFFICULT = 4;
    public const int TILE_MAIN_LIGHT_COLOR_BLACK = 0;
    public const int TILE_MAIN_LIGHT_COLOR_DIM_WHITE = 1;
    public const int TILE_MAIN_LIGHT_COLOR_WHITE = 2;
    public const int TILE_MAIN_LIGHT_COLOR_BRIGHT_WHITE = 3;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_YELLOW = 4;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_YELLOW = 5;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_YELLOW = 6;
    public const int TILE_MAIN_LIGHT_COLOR_YELLOW = 7;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_GREEN = 8;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_GREEN = 9;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_GREEN = 10;
    public const int TILE_MAIN_LIGHT_COLOR_GREEN = 11;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_AQUA = 12;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_AQUA = 13;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_AQUA = 14;
    public const int TILE_MAIN_LIGHT_COLOR_AQUA = 15;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_BLUE = 16;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_BLUE = 17;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_BLUE = 18;
    public const int TILE_MAIN_LIGHT_COLOR_BLUE = 19;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_PURPLE = 20;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_PURPLE = 21;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_PURPLE = 22;
    public const int TILE_MAIN_LIGHT_COLOR_PURPLE = 23;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_RED = 24;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_RED = 25;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_RED = 26;
    public const int TILE_MAIN_LIGHT_COLOR_RED = 27;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_DARK_ORANGE = 28;
    public const int TILE_MAIN_LIGHT_COLOR_DARK_ORANGE = 29;
    public const int TILE_MAIN_LIGHT_COLOR_PALE_ORANGE = 30;
    public const int TILE_MAIN_LIGHT_COLOR_ORANGE = 31;
    public const int TILE_SOURCE_LIGHT_COLOR_BLACK = 0;
    public const int TILE_SOURCE_LIGHT_COLOR_WHITE = 1;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_YELLOW = 2;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_YELLOW = 3;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_GREEN = 4;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_GREEN = 5;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_AQUA = 6;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_AQUA = 7;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_BLUE = 8;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_BLUE = 9;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_PURPLE = 10;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_PURPLE = 11;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_RED = 12;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_RED = 13;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_DARK_ORANGE = 14;
    public const int TILE_SOURCE_LIGHT_COLOR_PALE_ORANGE = 15;
    public const int PANEL_BUTTON_MAP = 0;
    public const int PANEL_BUTTON_INVENTORY = 1;
    public const int PANEL_BUTTON_JOURNAL = 2;
    public const int PANEL_BUTTON_CHARACTER = 3;
    public const int PANEL_BUTTON_OPTIONS = 4;
    public const int PANEL_BUTTON_SPELLS = 5;
    public const int PANEL_BUTTON_REST = 6;
    public const int PANEL_BUTTON_PLAYER_VERSUS_PLAYER = 7;
    public const int ACTION_MOVETOPOINT = 0;
    public const int ACTION_PICKUPITEM = 1;
    public const int ACTION_DROPITEM = 2;
    public const int ACTION_ATTACKOBJECT = 3;
    public const int ACTION_CASTSPELL = 4;
    public const int ACTION_OPENDOOR = 5;
    public const int ACTION_CLOSEDOOR = 6;
    public const int ACTION_DIALOGOBJECT = 7;
    public const int ACTION_DISABLETRAP = 8;
    public const int ACTION_RECOVERTRAP = 9;
    public const int ACTION_FLAGTRAP = 10;
    public const int ACTION_EXAMINETRAP = 11;
    public const int ACTION_SETTRAP = 12;
    public const int ACTION_OPENLOCK = 13;
    public const int ACTION_LOCK = 14;
    public const int ACTION_USEOBJECT = 15;
    public const int ACTION_ANIMALEMPATHY = 16;
    public const int ACTION_REST = 17;
    public const int ACTION_TAUNT = 18;
    public const int ACTION_ITEMCASTSPELL = 19;
    public const int ACTION_COUNTERSPELL = 31;
    public const int ACTION_HEAL = 33;
    public const int ACTION_PICKPOCKET = 34;
    public const int ACTION_FOLLOW = 35;
    public const int ACTION_WAIT = 36;
    public const int ACTION_SIT = 37;
    public const int ACTION_SMITEGOOD = 40;
    public const int ACTION_KIDAMAGE = 41;
    public const int ACTION_RANDOMWALK = 43;
    public const int ACTION_INVALID = 65535;
    public const int TRAP_BASE_TYPE_MINOR_SPIKE = 0;
    public const int TRAP_BASE_TYPE_AVERAGE_SPIKE = 1;
    public const int TRAP_BASE_TYPE_STRONG_SPIKE = 2;
    public const int TRAP_BASE_TYPE_DEADLY_SPIKE = 3;
    public const int TRAP_BASE_TYPE_MINOR_HOLY = 4;
    public const int TRAP_BASE_TYPE_AVERAGE_HOLY = 5;
    public const int TRAP_BASE_TYPE_STRONG_HOLY = 6;
    public const int TRAP_BASE_TYPE_DEADLY_HOLY = 7;
    public const int TRAP_BASE_TYPE_MINOR_TANGLE = 8;
    public const int TRAP_BASE_TYPE_AVERAGE_TANGLE = 9;
    public const int TRAP_BASE_TYPE_STRONG_TANGLE = 10;
    public const int TRAP_BASE_TYPE_DEADLY_TANGLE = 11;
    public const int TRAP_BASE_TYPE_MINOR_ACID = 12;
    public const int TRAP_BASE_TYPE_AVERAGE_ACID = 13;
    public const int TRAP_BASE_TYPE_STRONG_ACID = 14;
    public const int TRAP_BASE_TYPE_DEADLY_ACID = 15;
    public const int TRAP_BASE_TYPE_MINOR_FIRE = 16;
    public const int TRAP_BASE_TYPE_AVERAGE_FIRE = 17;
    public const int TRAP_BASE_TYPE_STRONG_FIRE = 18;
    public const int TRAP_BASE_TYPE_DEADLY_FIRE = 19;
    public const int TRAP_BASE_TYPE_MINOR_ELECTRICAL = 20;
    public const int TRAP_BASE_TYPE_AVERAGE_ELECTRICAL = 21;
    public const int TRAP_BASE_TYPE_STRONG_ELECTRICAL = 22;
    public const int TRAP_BASE_TYPE_DEADLY_ELECTRICAL = 23;
    public const int TRAP_BASE_TYPE_MINOR_GAS = 24;
    public const int TRAP_BASE_TYPE_AVERAGE_GAS = 25;
    public const int TRAP_BASE_TYPE_STRONG_GAS = 26;
    public const int TRAP_BASE_TYPE_DEADLY_GAS = 27;
    public const int TRAP_BASE_TYPE_MINOR_FROST = 28;
    public const int TRAP_BASE_TYPE_AVERAGE_FROST = 29;
    public const int TRAP_BASE_TYPE_STRONG_FROST = 30;
    public const int TRAP_BASE_TYPE_DEADLY_FROST = 31;
    public const int TRAP_BASE_TYPE_MINOR_NEGATIVE = 32;
    public const int TRAP_BASE_TYPE_AVERAGE_NEGATIVE = 33;
    public const int TRAP_BASE_TYPE_STRONG_NEGATIVE = 34;
    public const int TRAP_BASE_TYPE_DEADLY_NEGATIVE = 35;
    public const int TRAP_BASE_TYPE_MINOR_SONIC = 36;
    public const int TRAP_BASE_TYPE_AVERAGE_SONIC = 37;
    public const int TRAP_BASE_TYPE_STRONG_SONIC = 38;
    public const int TRAP_BASE_TYPE_DEADLY_SONIC = 39;
    public const int TRAP_BASE_TYPE_MINOR_ACID_SPLASH = 40;
    public const int TRAP_BASE_TYPE_AVERAGE_ACID_SPLASH = 41;
    public const int TRAP_BASE_TYPE_STRONG_ACID_SPLASH = 42;
    public const int TRAP_BASE_TYPE_DEADLY_ACID_SPLASH = 43;
    public const int TRAP_BASE_TYPE_EPIC_ELECTRICAL = 44;
    public const int TRAP_BASE_TYPE_EPIC_FIRE = 45;
    public const int TRAP_BASE_TYPE_EPIC_FROST = 46;
    public const int TRAP_BASE_TYPE_EPIC_SONIC = 47;
    public const int TRACK_RURALDAY1 = 1;
    public const int TRACK_RURALDAY2 = 2;
    public const int TRACK_RURALNIGHT = 3;
    public const int TRACK_FORESTDAY1 = 4;
    public const int TRACK_FORESTDAY2 = 5;
    public const int TRACK_FORESTNIGHT = 6;
    public const int TRACK_DUNGEON1 = 7;
    public const int TRACK_SEWER = 8;
    public const int TRACK_MINES1 = 9;
    public const int TRACK_MINES2 = 10;
    public const int TRACK_CRYPT1 = 11;
    public const int TRACK_CRYPT2 = 12;
    public const int TRACK_DESERT_DAY = 58;
    public const int TRACK_DESERT_NIGHT = 61;
    public const int TRACK_WINTER_DAY = 59;
    public const int TRACK_EVILDUNGEON1 = 13;
    public const int TRACK_EVILDUNGEON2 = 14;
    public const int TRACK_CITYSLUMDAY = 15;
    public const int TRACK_CITYSLUMNIGHT = 16;
    public const int TRACK_CITYDOCKDAY = 17;
    public const int TRACK_CITYDOCKNIGHT = 18;
    public const int TRACK_CITYWEALTHY = 19;
    public const int TRACK_CITYMARKET = 20;
    public const int TRACK_CITYNIGHT = 21;
    public const int TRACK_TAVERN1 = 22;
    public const int TRACK_TAVERN2 = 23;
    public const int TRACK_TAVERN3 = 24;
    public const int TRACK_TAVERN4 = 56;
    public const int TRACK_RICHHOUSE = 25;
    public const int TRACK_STORE = 26;
    public const int TRACK_TEMPLEGOOD = 27;
    public const int TRACK_TEMPLEGOOD2 = 49;
    public const int TRACK_TEMPLEEVIL = 28;
    public const int TRACK_THEME_NWN = 29;
    public const int TRACK_THEME_CHAPTER1 = 30;
    public const int TRACK_THEME_CHAPTER2 = 31;
    public const int TRACK_THEME_CHAPTER3 = 32;
    public const int TRACK_THEME_CHAPTER4 = 33;
    public const int TRACK_BATTLE_RURAL1 = 34;
    public const int TRACK_BATTLE_FOREST1 = 35;
    public const int TRACK_BATTLE_FOREST2 = 36;
    public const int TRACK_BATTLE_DUNGEON1 = 37;
    public const int TRACK_BATTLE_DUNGEON2 = 38;
    public const int TRACK_BATTLE_DUNGEON3 = 39;
    public const int TRACK_BATTLE_CITY1 = 40;
    public const int TRACK_BATTLE_CITY2 = 41;
    public const int TRACK_BATTLE_CITY3 = 42;
    public const int TRACK_BATTLE_CITYBOSS = 43;
    public const int TRACK_BATTLE_FORESTBOSS = 44;
    public const int TRACK_BATTLE_LIZARDBOSS = 45;
    public const int TRACK_BATTLE_DRAGON = 46;
    public const int TRACK_BATTLE_ARIBETH = 47;
    public const int TRACK_BATTLE_ENDBOSS = 48;
    public const int TRACK_BATTLE_DESERT = 57;
    public const int TRACK_BATTLE_WINTER = 60;
    public const int TRACK_CASTLE = 50;
    public const int TRACK_THEME_ARIBETH1 = 51;
    public const int TRACK_THEME_ARIBETH2 = 52;
    public const int TRACK_THEME_GEND = 53;
    public const int TRACK_THEME_MAUGRIM = 54;
    public const int TRACK_THEME_MORAG = 55;
    public const int TRACK_HOTU_THEME = 62;
    public const int TRACK_HOTU_WATERDEEP = 63;
    public const int TRACK_HOTU_UNDERMOUNTAIN = 64;
    public const int TRACK_HOTU_REBELCAMP = 65;
    public const int TRACK_HOTU_FIREPLANE = 66;
    public const int TRACK_HOTU_QUEEN = 67;
    public const int TRACK_HOTU_HELLFROZEOVER = 68;
    public const int TRACK_HOTU_DRACOLICH = 69;
    public const int TRACK_HOTU_BATTLE_SMALL = 70;
    public const int TRACK_HOTU_BATTLE_MED = 71;
    public const int TRACK_HOTU_BATTLE_LARGE = 72;
    public const int TRACK_HOTU_BATTLE_HELL = 73;
    public const int TRACK_HOTU_BATTLE_BOSS1 = 74;
    public const int TRACK_HOTU_BATTLE_BOSS2 = 75;
    public const int STEALTH_MODE_DISABLED = 0;
    public const int STEALTH_MODE_ACTIVATED = 1;
    public const int DETECT_MODE_PASSIVE = 0;
    public const int DETECT_MODE_ACTIVE = 1;
    public const int DEFENSIVE_CASTING_MODE_DISABLED = 0;
    public const int DEFENSIVE_CASTING_MODE_ACTIVATED = 1;
    public const int APPEARANCE_TYPE_INVALID = -1;
    public const int APPEARANCE_TYPE_ALLIP = 186;
    public const int APPEARANCE_TYPE_ARANEA = 157;
    public const int APPEARANCE_TYPE_ARCH_TARGET = 200;
    public const int APPEARANCE_TYPE_ARIBETH = 190;
    public const int APPEARANCE_TYPE_ASABI_CHIEFTAIN = 353;
    public const int APPEARANCE_TYPE_ASABI_SHAMAN = 354;
    public const int APPEARANCE_TYPE_ASABI_WARRIOR = 355;
    public const int APPEARANCE_TYPE_BADGER = 8;
    public const int APPEARANCE_TYPE_BADGER_DIRE = 9;
    public const int APPEARANCE_TYPE_BALOR = 38;
    public const int APPEARANCE_TYPE_BARTENDER = 234;
    public const int APPEARANCE_TYPE_BASILISK = 369;
    public const int APPEARANCE_TYPE_BAT = 10;
    public const int APPEARANCE_TYPE_BAT_HORROR = 11;
    public const int APPEARANCE_TYPE_BEAR_BLACK = 12;
    public const int APPEARANCE_TYPE_BEAR_BROWN = 13;
    public const int APPEARANCE_TYPE_BEAR_DIRE = 15;
    public const int APPEARANCE_TYPE_BEAR_KODIAK = 204;
    public const int APPEARANCE_TYPE_BEAR_POLAR = 14;
    public const int APPEARANCE_TYPE_BEETLE_FIRE = 18;
    public const int APPEARANCE_TYPE_BEETLE_SLICER = 17;
    public const int APPEARANCE_TYPE_BEETLE_STAG = 19;
    public const int APPEARANCE_TYPE_BEETLE_STINK = 20;
    public const int APPEARANCE_TYPE_BEGGER = 220;
    public const int APPEARANCE_TYPE_BLOOD_SAILER = 221;
    public const int APPEARANCE_TYPE_BOAR = 21;
    public const int APPEARANCE_TYPE_BOAR_DIRE = 22;
    public const int APPEARANCE_TYPE_BODAK = 23;
    public const int APPEARANCE_TYPE_BUGBEAR_A = 29;
    public const int APPEARANCE_TYPE_BUGBEAR_B = 30;
    public const int APPEARANCE_TYPE_BUGBEAR_CHIEFTAIN_A = 25;
    public const int APPEARANCE_TYPE_BUGBEAR_CHIEFTAIN_B = 26;
    public const int APPEARANCE_TYPE_BUGBEAR_SHAMAN_A = 27;
    public const int APPEARANCE_TYPE_BUGBEAR_SHAMAN_B = 28;
    public const int APPEARANCE_TYPE_BULETTE = 481;
    public const int APPEARANCE_TYPE_CAT_CAT_DIRE = 95;
    public const int APPEARANCE_TYPE_CAT_COUGAR = 203;
    public const int APPEARANCE_TYPE_CAT_CRAG_CAT = 94;
    public const int APPEARANCE_TYPE_CAT_JAGUAR = 98;
    public const int APPEARANCE_TYPE_CAT_KRENSHAR = 96;
    public const int APPEARANCE_TYPE_CAT_LEOPARD = 93;
    public const int APPEARANCE_TYPE_CAT_LION = 97;
    public const int APPEARANCE_TYPE_CAT_MPANTHER = 306;
    public const int APPEARANCE_TYPE_CAT_PANTHER = 202;
    public const int APPEARANCE_TYPE_CHICKEN = 31;
    public const int APPEARANCE_TYPE_COCKATRICE = 368;
    public const int APPEARANCE_TYPE_COMBAT_DUMMY = 201;
    public const int APPEARANCE_TYPE_CONVICT = 238;
    public const int APPEARANCE_TYPE_COW = 34;
    public const int APPEARANCE_TYPE_CULT_MEMBER = 212;
    public const int APPEARANCE_TYPE_DEER = 35;
    public const int APPEARANCE_TYPE_DEER_STAG = 37;
    public const int APPEARANCE_TYPE_DEVIL = 392;
    public const int APPEARANCE_TYPE_DOG = 176;
    public const int APPEARANCE_TYPE_DOG_BLINKDOG = 174;
    public const int APPEARANCE_TYPE_DOG_DIRE_WOLF = 175;
    public const int APPEARANCE_TYPE_DOG_FENHOUND = 177;
    public const int APPEARANCE_TYPE_DOG_HELL_HOUND = 179;
    public const int APPEARANCE_TYPE_DOG_SHADOW_MASTIF = 180;
    public const int APPEARANCE_TYPE_DOG_WINTER_WOLF = 184;
    public const int APPEARANCE_TYPE_DOG_WOLF = 181;
    public const int APPEARANCE_TYPE_DOG_WORG = 185;
    public const int APPEARANCE_TYPE_DOOM_KNIGHT = 40;
    public const int APPEARANCE_TYPE_DRAGON_BLACK = 41;
    public const int APPEARANCE_TYPE_DRAGON_BLUE = 47;
    public const int APPEARANCE_TYPE_DRAGON_BRASS = 42;
    public const int APPEARANCE_TYPE_DRAGON_BRONZE = 45;
    public const int APPEARANCE_TYPE_DRAGON_COPPER = 43;
    public const int APPEARANCE_TYPE_DRAGON_GOLD = 46;
    public const int APPEARANCE_TYPE_DRAGON_GREEN = 48;
    public const int APPEARANCE_TYPE_DRAGON_RED = 49;
    public const int APPEARANCE_TYPE_DRAGON_SILVER = 44;
    public const int APPEARANCE_TYPE_DRAGON_WHITE = 50;
    public const int APPEARANCE_TYPE_DROW_CLERIC = 215;
    public const int APPEARANCE_TYPE_DROW_FIGHTER = 216;
    public const int APPEARANCE_TYPE_DRUEGAR_CLERIC = 218;
    public const int APPEARANCE_TYPE_DRUEGAR_FIGHTER = 217;
    public const int APPEARANCE_TYPE_DRYAD = 51;
    public const int APPEARANCE_TYPE_DWARF = 0;
    public const int APPEARANCE_TYPE_DWARF_NPC_FEMALE = 248;
    public const int APPEARANCE_TYPE_DWARF_NPC_MALE = 249;
    public const int APPEARANCE_TYPE_ELEMENTAL_AIR = 52;
    public const int APPEARANCE_TYPE_ELEMENTAL_AIR_ELDER = 53;
    public const int APPEARANCE_TYPE_ELEMENTAL_EARTH = 56;
    public const int APPEARANCE_TYPE_ELEMENTAL_EARTH_ELDER = 57;
    public const int APPEARANCE_TYPE_ELEMENTAL_FIRE = 60;
    public const int APPEARANCE_TYPE_ELEMENTAL_FIRE_ELDER = 61;
    public const int APPEARANCE_TYPE_ELEMENTAL_WATER = 69;
    public const int APPEARANCE_TYPE_ELEMENTAL_WATER_ELDER = 68;
    public const int APPEARANCE_TYPE_ELF = 1;
    public const int APPEARANCE_TYPE_ELF_NPC_FEMALE = 245;
    public const int APPEARANCE_TYPE_ELF_NPC_MALE_01 = 246;
    public const int APPEARANCE_TYPE_ELF_NPC_MALE_02 = 247;
    public const int APPEARANCE_TYPE_ETTERCAP = 166;
    public const int APPEARANCE_TYPE_ETTIN = 72;
    public const int APPEARANCE_TYPE_FAERIE_DRAGON = 374;
    public const int APPEARANCE_TYPE_FAIRY = 55;
    public const int APPEARANCE_TYPE_FALCON = 144;
    public const int APPEARANCE_TYPE_FEMALE_01 = 222;
    public const int APPEARANCE_TYPE_FEMALE_02 = 223;
    public const int APPEARANCE_TYPE_FEMALE_03 = 224;
    public const int APPEARANCE_TYPE_FEMALE_04 = 225;
    public const int APPEARANCE_TYPE_FORMIAN_MYRMARCH = 362;
    public const int APPEARANCE_TYPE_FORMIAN_QUEEN = 363;
    public const int APPEARANCE_TYPE_FORMIAN_WARRIOR = 361;
    public const int APPEARANCE_TYPE_FORMIAN_WORKER = 360;
    public const int APPEARANCE_TYPE_GARGOYLE = 73;
    public const int APPEARANCE_TYPE_GHAST = 74;
    public const int APPEARANCE_TYPE_GHOUL = 76;
    public const int APPEARANCE_TYPE_GHOUL_LORD = 77;
    public const int APPEARANCE_TYPE_GIANT_FIRE = 80;
    public const int APPEARANCE_TYPE_GIANT_FIRE_FEMALE = 351;
    public const int APPEARANCE_TYPE_GIANT_FROST = 81;
    public const int APPEARANCE_TYPE_GIANT_FROST_FEMALE = 350;
    public const int APPEARANCE_TYPE_GIANT_HILL = 78;
    public const int APPEARANCE_TYPE_GIANT_MOUNTAIN = 79;
    public const int APPEARANCE_TYPE_GNOLL_WARRIOR = 388;
    public const int APPEARANCE_TYPE_GNOLL_WIZ = 389;
    public const int APPEARANCE_TYPE_GNOME = 2;
    public const int APPEARANCE_TYPE_GNOME_NPC_FEMALE = 243;
    public const int APPEARANCE_TYPE_GNOME_NPC_MALE = 244;
    public const int APPEARANCE_TYPE_GOBLIN_A = 86;
    public const int APPEARANCE_TYPE_GOBLIN_B = 87;
    public const int APPEARANCE_TYPE_GOBLIN_CHIEF_A = 82;
    public const int APPEARANCE_TYPE_GOBLIN_CHIEF_B = 83;
    public const int APPEARANCE_TYPE_GOBLIN_SHAMAN_A = 84;
    public const int APPEARANCE_TYPE_GOBLIN_SHAMAN_B = 85;
    public const int APPEARANCE_TYPE_GOLEM_BONE = 24;
    public const int APPEARANCE_TYPE_GOLEM_CLAY = 91;
    public const int APPEARANCE_TYPE_GOLEM_FLESH = 88;
    public const int APPEARANCE_TYPE_GOLEM_IRON = 89;
    public const int APPEARANCE_TYPE_GOLEM_STONE = 92;
    public const int APPEARANCE_TYPE_GORGON = 367;
    public const int APPEARANCE_TYPE_GRAY_OOZE = 393;
    public const int APPEARANCE_TYPE_GREY_RENDER = 205;
    public const int APPEARANCE_TYPE_GYNOSPHINX = 365;
    public const int APPEARANCE_TYPE_HALFLING = 3;
    public const int APPEARANCE_TYPE_HALFLING_NPC_FEMALE = 250;
    public const int APPEARANCE_TYPE_HALFLING_NPC_MALE = 251;
    public const int APPEARANCE_TYPE_HALF_ELF = 4;
    public const int APPEARANCE_TYPE_HALF_ORC = 5;
    public const int APPEARANCE_TYPE_HALF_ORC_NPC_FEMALE = 252;
    public const int APPEARANCE_TYPE_HALF_ORC_NPC_MALE_01 = 253;
    public const int APPEARANCE_TYPE_HALF_ORC_NPC_MALE_02 = 254;
    public const int APPEARANCE_TYPE_HELMED_HORROR = 100;
    public const int APPEARANCE_TYPE_HEURODIS_LICH = 370;
    public const int APPEARANCE_TYPE_HOBGOBLIN_WARRIOR = 390;
    public const int APPEARANCE_TYPE_HOBGOBLIN_WIZARD = 391;
    public const int APPEARANCE_TYPE_HOOK_HORROR = 102;
    public const int APPEARANCE_TYPE_HOUSE_GUARD = 219;
    public const int APPEARANCE_TYPE_HUMAN = 6;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_01 = 255;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_02 = 256;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_03 = 257;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_04 = 258;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_05 = 259;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_06 = 260;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_07 = 261;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_08 = 262;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_09 = 263;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_10 = 264;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_11 = 265;
    public const int APPEARANCE_TYPE_HUMAN_NPC_FEMALE_12 = 266;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_01 = 267;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_02 = 268;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_03 = 269;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_04 = 270;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_05 = 271;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_06 = 272;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_07 = 273;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_08 = 274;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_09 = 275;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_10 = 276;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_11 = 277;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_12 = 278;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_13 = 279;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_14 = 280;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_15 = 281;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_16 = 282;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_17 = 283;
    public const int APPEARANCE_TYPE_HUMAN_NPC_MALE_18 = 284;
    public const int APPEARANCE_TYPE_IMP = 105;
    public const int APPEARANCE_TYPE_INN_KEEPER = 233;
    public const int APPEARANCE_TYPE_INTELLECT_DEVOURER = 117;
    public const int APPEARANCE_TYPE_INVISIBLE_HUMAN_MALE = 298;
    public const int APPEARANCE_TYPE_INVISIBLE_STALKER = 64;
    public const int APPEARANCE_TYPE_KID_FEMALE = 242;
    public const int APPEARANCE_TYPE_KID_MALE = 241;
    public const int APPEARANCE_TYPE_KOBOLD_A = 302;
    public const int APPEARANCE_TYPE_KOBOLD_B = 305;
    public const int APPEARANCE_TYPE_KOBOLD_CHIEF_A = 300;
    public const int APPEARANCE_TYPE_KOBOLD_CHIEF_B = 303;
    public const int APPEARANCE_TYPE_KOBOLD_SHAMAN_A = 301;
    public const int APPEARANCE_TYPE_KOBOLD_SHAMAN_B = 304;
    public const int APPEARANCE_TYPE_LANTERN_ARCHON = 103;
    public const int APPEARANCE_TYPE_LICH = 39;
    public const int APPEARANCE_TYPE_LIZARDFOLK_A = 134;
    public const int APPEARANCE_TYPE_LIZARDFOLK_B = 135;
    public const int APPEARANCE_TYPE_LIZARDFOLK_SHAMAN_A = 132;
    public const int APPEARANCE_TYPE_LIZARDFOLK_SHAMAN_B = 133;
    public const int APPEARANCE_TYPE_LIZARDFOLK_WARRIOR_A = 130;
    public const int APPEARANCE_TYPE_LIZARDFOLK_WARRIOR_B = 131;
    public const int APPEARANCE_TYPE_LUSKAN_GUARD = 211;
    public const int APPEARANCE_TYPE_MALE_01 = 226;
    public const int APPEARANCE_TYPE_MALE_02 = 227;
    public const int APPEARANCE_TYPE_MALE_03 = 228;
    public const int APPEARANCE_TYPE_MALE_04 = 229;
    public const int APPEARANCE_TYPE_MALE_05 = 230;
    public const int APPEARANCE_TYPE_MANTICORE = 366;
    public const int APPEARANCE_TYPE_MEDUSA = 352;
    public const int APPEARANCE_TYPE_MEPHIT_AIR = 106;
    public const int APPEARANCE_TYPE_MEPHIT_DUST = 107;
    public const int APPEARANCE_TYPE_MEPHIT_EARTH = 108;
    public const int APPEARANCE_TYPE_MEPHIT_FIRE = 109;
    public const int APPEARANCE_TYPE_MEPHIT_ICE = 110;
    public const int APPEARANCE_TYPE_MEPHIT_MAGMA = 114;
    public const int APPEARANCE_TYPE_MEPHIT_OOZE = 112;
    public const int APPEARANCE_TYPE_MEPHIT_SALT = 111;
    public const int APPEARANCE_TYPE_MEPHIT_STEAM = 113;
    public const int APPEARANCE_TYPE_MEPHIT_WATER = 115;
    public const int APPEARANCE_TYPE_MINOGON = 119;
    public const int APPEARANCE_TYPE_MINOTAUR = 120;
    public const int APPEARANCE_TYPE_MINOTAUR_CHIEFTAIN = 121;
    public const int APPEARANCE_TYPE_MINOTAUR_SHAMAN = 122;
    public const int APPEARANCE_TYPE_MOHRG = 123;
    public const int APPEARANCE_TYPE_MUMMY_COMMON = 58;
    public const int APPEARANCE_TYPE_MUMMY_FIGHTER_2 = 59;
    public const int APPEARANCE_TYPE_MUMMY_GREATER = 124;
    public const int APPEARANCE_TYPE_MUMMY_WARRIOR = 125;
    public const int APPEARANCE_TYPE_NWN_AARIN = 188;
    public const int APPEARANCE_TYPE_NWN_ARIBETH_EVIL = 189;
    public const int APPEARANCE_TYPE_NWN_HAEDRALINE = 191;
    public const int APPEARANCE_TYPE_NWN_MAUGRIM = 193;
    public const int APPEARANCE_TYPE_NWN_MORAG = 192;
    public const int APPEARANCE_TYPE_NWN_NASHER = 296;
    public const int APPEARANCE_TYPE_NWN_SEDOS = 297;
    public const int APPEARANCE_TYPE_NW_MILITIA_MEMBER = 210;
    public const int APPEARANCE_TYPE_NYMPH = 126;
    public const int APPEARANCE_TYPE_OCHRE_JELLY_LARGE = 394;
    public const int APPEARANCE_TYPE_OCHRE_JELLY_MEDIUM = 396;
    public const int APPEARANCE_TYPE_OCHRE_JELLY_SMALL = 398;
    public const int APPEARANCE_TYPE_OGRE = 127;
    public const int APPEARANCE_TYPE_OGREB = 207;
    public const int APPEARANCE_TYPE_OGRE_CHIEFTAIN = 128;
    public const int APPEARANCE_TYPE_OGRE_CHIEFTAINB = 208;
    public const int APPEARANCE_TYPE_OGRE_MAGE = 129;
    public const int APPEARANCE_TYPE_OGRE_MAGEB = 209;
    public const int APPEARANCE_TYPE_OLD_MAN = 239;
    public const int APPEARANCE_TYPE_OLD_WOMAN = 240;
    public const int APPEARANCE_TYPE_ORC_A = 140;
    public const int APPEARANCE_TYPE_ORC_B = 141;
    public const int APPEARANCE_TYPE_ORC_CHIEFTAIN_A = 136;
    public const int APPEARANCE_TYPE_ORC_CHIEFTAIN_B = 137;
    public const int APPEARANCE_TYPE_ORC_SHAMAN_A = 138;
    public const int APPEARANCE_TYPE_ORC_SHAMAN_B = 139;
    public const int APPEARANCE_TYPE_OX = 142;
    public const int APPEARANCE_TYPE_PARROT = 7;
    public const int APPEARANCE_TYPE_PENGUIN = 206;
    public const int APPEARANCE_TYPE_PLAGUE_VICTIM = 231;
    public const int APPEARANCE_TYPE_PROSTITUTE_01 = 236;
    public const int APPEARANCE_TYPE_PROSTITUTE_02 = 237;
    public const int APPEARANCE_TYPE_PSEUDODRAGON = 375;
    public const int APPEARANCE_TYPE_QUASIT = 104;
    public const int APPEARANCE_TYPE_RAKSHASA_BEAR_MALE = 294;
    public const int APPEARANCE_TYPE_RAKSHASA_TIGER_FEMALE = 290;
    public const int APPEARANCE_TYPE_RAKSHASA_TIGER_MALE = 293;
    public const int APPEARANCE_TYPE_RAKSHASA_WOLF_MALE = 295;
    public const int APPEARANCE_TYPE_RAT = 386;
    public const int APPEARANCE_TYPE_RAT_DIRE = 387;
    public const int APPEARANCE_TYPE_RAVEN = 145;
    public const int APPEARANCE_TYPE_SAHUAGIN = 65;
    public const int APPEARANCE_TYPE_SAHUAGIN_LEADER = 66;
    public const int APPEARANCE_TYPE_SAHUAGIN_CLERIC = 67;
    public const int APPEARANCE_TYPE_SEAGULL_FLYING = 291;
    public const int APPEARANCE_TYPE_SEAGULL_WALKING = 292;
    public const int APPEARANCE_TYPE_SHADOW = 146;
    public const int APPEARANCE_TYPE_SHADOW_FIEND = 147;
    public const int APPEARANCE_TYPE_SHARK_MAKO = 447;
    public const int APPEARANCE_TYPE_SHARK_HAMMERHEAD = 448;
    public const int APPEARANCE_TYPE_SHARK_GOBLIN = 449;
    public const int APPEARANCE_TYPE_SHIELD_GUARDIAN = 90;
    public const int APPEARANCE_TYPE_SHOP_KEEPER = 232;
    public const int APPEARANCE_TYPE_SKELETAL_DEVOURER = 36;
    public const int APPEARANCE_TYPE_SKELETON_CHIEFTAIN = 182;
    public const int APPEARANCE_TYPE_SKELETON_COMMON = 63;
    public const int APPEARANCE_TYPE_SKELETON_MAGE = 148;
    public const int APPEARANCE_TYPE_SKELETON_PRIEST = 62;
    public const int APPEARANCE_TYPE_SKELETON_WARRIOR = 150;
    public const int APPEARANCE_TYPE_SKELETON_WARRIOR_1 = 70;
    public const int APPEARANCE_TYPE_SKELETON_WARRIOR_2 = 71;
    public const int APPEARANCE_TYPE_SLAAD_BLUE = 151;
    public const int APPEARANCE_TYPE_SLAAD_DEATH = 152;
    public const int APPEARANCE_TYPE_SLAAD_GRAY = 153;
    public const int APPEARANCE_TYPE_SLAAD_GREEN = 154;
    public const int APPEARANCE_TYPE_SLAAD_RED = 155;
    public const int APPEARANCE_TYPE_SPECTRE = 156;
    public const int APPEARANCE_TYPE_SPHINX = 364;
    public const int APPEARANCE_TYPE_SPIDER_DIRE = 158;
    public const int APPEARANCE_TYPE_SPIDER_GIANT = 159;
    public const int APPEARANCE_TYPE_SPIDER_PHASE = 160;
    public const int APPEARANCE_TYPE_SPIDER_SWORD = 161;
    public const int APPEARANCE_TYPE_SPIDER_WRAITH = 162;
    public const int APPEARANCE_TYPE_STINGER = 356;
    public const int APPEARANCE_TYPE_STINGER_CHIEFTAIN = 358;
    public const int APPEARANCE_TYPE_STINGER_MAGE = 359;
    public const int APPEARANCE_TYPE_STINGER_WARRIOR = 357;
    public const int APPEARANCE_TYPE_SUCCUBUS = 163;
    public const int APPEARANCE_TYPE_TROGLODYTE = 451;
    public const int APPEARANCE_TYPE_TROGLODYTE_WARRIOR = 452;
    public const int APPEARANCE_TYPE_TROGLODYTE_CLERIC = 453;
    public const int APPEARANCE_TYPE_TROLL = 167;
    public const int APPEARANCE_TYPE_TROLL_CHIEFTAIN = 164;
    public const int APPEARANCE_TYPE_TROLL_SHAMAN = 165;
    public const int APPEARANCE_TYPE_UMBERHULK = 168;
    public const int APPEARANCE_TYPE_UTHGARD_ELK_TRIBE = 213;
    public const int APPEARANCE_TYPE_UTHGARD_TIGER_TRIBE = 214;
    public const int APPEARANCE_TYPE_VAMPIRE_FEMALE = 288;
    public const int APPEARANCE_TYPE_VAMPIRE_MALE = 289;
    public const int APPEARANCE_TYPE_VROCK = 101;
    public const int APPEARANCE_TYPE_WAITRESS = 235;
    public const int APPEARANCE_TYPE_WAR_DEVOURER = 54;
    public const int APPEARANCE_TYPE_WERECAT = 99;
    public const int APPEARANCE_TYPE_WERERAT = 170;
    public const int APPEARANCE_TYPE_WEREWOLF = 171;
    public const int APPEARANCE_TYPE_WIGHT = 172;
    public const int APPEARANCE_TYPE_WILL_O_WISP = 116;
    public const int APPEARANCE_TYPE_WRAITH = 187;
    public const int APPEARANCE_TYPE_WYRMLING_BLACK = 378;
    public const int APPEARANCE_TYPE_WYRMLING_BLUE = 377;
    public const int APPEARANCE_TYPE_WYRMLING_BRASS = 381;
    public const int APPEARANCE_TYPE_WYRMLING_BRONZE = 383;
    public const int APPEARANCE_TYPE_WYRMLING_COPPER = 382;
    public const int APPEARANCE_TYPE_WYRMLING_GOLD = 385;
    public const int APPEARANCE_TYPE_WYRMLING_GREEN = 379;
    public const int APPEARANCE_TYPE_WYRMLING_RED = 376;
    public const int APPEARANCE_TYPE_WYRMLING_SILVER = 384;
    public const int APPEARANCE_TYPE_WYRMLING_WHITE = 380;
    public const int APPEARANCE_TYPE_YUAN_TI = 285;
    public const int APPEARANCE_TYPE_YUAN_TI_CHIEFTEN = 286;
    public const int APPEARANCE_TYPE_YUAN_TI_WIZARD = 287;
    public const int APPEARANCE_TYPE_ZOMBIE = 198;
    public const int APPEARANCE_TYPE_ZOMBIE_ROTTING = 195;
    public const int APPEARANCE_TYPE_ZOMBIE_TYRANT_FOG = 199;
    public const int APPEARANCE_TYPE_ZOMBIE_WARRIOR_1 = 196;
    public const int APPEARANCE_TYPE_ZOMBIE_WARRIOR_2 = 197;
    public const int APPEARANCE_TYPE_BEHOLDER = 401;
    public const int APPEARANCE_TYPE_BEHOLDER_MAGE = 402;
    public const int APPEARANCE_TYPE_BEHOLDER_EYEBALL = 403;
    public const int APPEARANCE_TYPE_MEPHISTO_BIG = 404;
    public const int APPEARANCE_TYPE_DRACOLICH = 405;
    public const int APPEARANCE_TYPE_DRIDER = 406;
    public const int APPEARANCE_TYPE_DRIDER_CHIEF = 407;
    public const int APPEARANCE_TYPE_DROW_SLAVE = 408;
    public const int APPEARANCE_TYPE_DROW_WIZARD = 409;
    public const int APPEARANCE_TYPE_DROW_MATRON = 410;
    public const int APPEARANCE_TYPE_DUERGAR_SLAVE = 411;
    public const int APPEARANCE_TYPE_DUERGAR_CHIEF = 412;
    public const int APPEARANCE_TYPE_MINDFLAYER = 413;
    public const int APPEARANCE_TYPE_MINDFLAYER_2 = 414;
    public const int APPEARANCE_TYPE_MINDFLAYER_ALHOON = 415;
    public const int APPEARANCE_TYPE_DEEP_ROTHE = 416;
    public const int APPEARANCE_TYPE_DRAGON_SHADOW = 418;
    public const int APPEARANCE_TYPE_HARPY = 419;
    public const int APPEARANCE_TYPE_GOLEM_MITHRAL = 420;
    public const int APPEARANCE_TYPE_GOLEM_ADAMANTIUM = 421;
    public const int APPEARANCE_TYPE_SPIDER_DEMON = 422;
    public const int APPEARANCE_TYPE_SVIRF_MALE = 423;
    public const int APPEARANCE_TYPE_SVIRF_FEMALE = 424;
    public const int APPEARANCE_TYPE_DRAGON_PRIS = 425;
    public const int APPEARANCE_TYPE_SLAAD_BLACK = 426;
    public const int APPEARANCE_TYPE_SLAAD_WHITE = 427;
    public const int APPEARANCE_TYPE_AZER_MALE = 428;
    public const int APPEARANCE_TYPE_AZER_FEMALE = 429;
    public const int APPEARANCE_TYPE_DEMI_LICH = 430;
    public const int APPEARANCE_TYPE_OBJECT_CHAIR = 431;
    public const int APPEARANCE_TYPE_OBJECT_TABLE = 432;
    public const int APPEARANCE_TYPE_OBJECT_CANDLE = 433;
    public const int APPEARANCE_TYPE_OBJECT_CHEST = 434;
    public const int APPEARANCE_TYPE_OBJECT_WHITE = 435;
    public const int APPEARANCE_TYPE_OBJECT_BLUE = 436;
    public const int APPEARANCE_TYPE_OBJECT_CYAN = 437;
    public const int APPEARANCE_TYPE_OBJECT_GREEN = 438;
    public const int APPEARANCE_TYPE_OBJECT_YELLOW = 439;
    public const int APPEARANCE_TYPE_OBJECT_ORANGE = 440;
    public const int APPEARANCE_TYPE_OBJECT_RED = 441;
    public const int APPEARANCE_TYPE_OBJECT_PURPLE = 442;
    public const int APPEARANCE_TYPE_OBJECT_FLAME_SMALL = 443;
    public const int APPEARANCE_TYPE_OBJECT_FLAME_MEDIUM = 444;
    public const int APPEARANCE_TYPE_OBJECT_FLAME_LARGE = 445;
    public const int APPEARANCE_TYPE_DRIDER_FEMALE = 446;
    public const int APPEARANCE_TYPE_SEA_HAG = 454;
    public const int APPEARANCE_TYPE_GOLEM_DEMONFLESH = 468;
    public const int APPEARANCE_TYPE_ANIMATED_CHEST = 469;
    public const int APPEARANCE_TYPE_GELATINOUS_CUBE = 470;
    public const int APPEARANCE_TYPE_MEPHISTO_NORM = 471;
    public const int APPEARANCE_TYPE_BEHOLDER_MOTHER = 472;
    public const int APPEARANCE_TYPE_OBJECT_BOAT = 473;
    public const int APPEARANCE_TYPE_DWARF_GOLEM = 474;
    public const int APPEARANCE_TYPE_DWARF_HALFORC = 475;
    public const int APPEARANCE_TYPE_DROW_WARRIOR_1 = 476;
    public const int APPEARANCE_TYPE_DROW_WARRIOR_2 = 477;
    public const int APPEARANCE_TYPE_DROW_FEMALE_1 = 478;
    public const int APPEARANCE_TYPE_DROW_FEMALE_2 = 479;
    public const int APPEARANCE_TYPE_DROW_WARRIOR_3 = 480;
    public const int PHENOTYPE_NORMAL = 0;
    public const int PHENOTYPE_BIG = 2;
    public const int PHENOTYPE_CUSTOM1 = 3;
    public const int PHENOTYPE_CUSTOM2 = 4;
    public const int PHENOTYPE_CUSTOM3 = 5;
    public const int PHENOTYPE_CUSTOM4 = 6;
    public const int PHENOTYPE_CUSTOM5 = 7;
    public const int PHENOTYPE_CUSTOM6 = 8;
    public const int PHENOTYPE_CUSTOM7 = 9;
    public const int PHENOTYPE_CUSTOM8 = 10;
    public const int PHENOTYPE_CUSTOM9 = 11;
    public const int PHENOTYPE_CUSTOM10 = 12;
    public const int PHENOTYPE_CUSTOM11 = 13;
    public const int PHENOTYPE_CUSTOM12 = 14;
    public const int PHENOTYPE_CUSTOM13 = 15;
    public const int PHENOTYPE_CUSTOM14 = 16;
    public const int PHENOTYPE_CUSTOM15 = 17;
    public const int PHENOTYPE_CUSTOM16 = 18;
    public const int PHENOTYPE_CUSTOM17 = 19;
    public const int PHENOTYPE_CUSTOM18 = 20;
    public const int CAMERA_TRANSITION_TYPE_SNAP = 0;
    public const int CAMERA_TRANSITION_TYPE_CRAWL = 2;
    public const int CAMERA_TRANSITION_TYPE_VERY_SLOW = 5;
    public const int CAMERA_TRANSITION_TYPE_SLOW = 20;
    public const int CAMERA_TRANSITION_TYPE_MEDIUM = 40;
    public const int CAMERA_TRANSITION_TYPE_FAST = 70;
    public const int CAMERA_TRANSITION_TYPE_VERY_FAST = 100;
    public const float FADE_SPEED_SLOWEST = 0.003f;
    public const float FADE_SPEED_SLOW = 0.005f;
    public const float FADE_SPEED_MEDIUM = 0.01f;
    public const float FADE_SPEED_FAST = 0.017f;
    public const float FADE_SPEED_FASTEST = 0.25f;
    public const int EVENT_HEARTBEAT = 1001;
    public const int EVENT_PERCEIVE = 1002;
    public const int EVENT_END_COMBAT_ROUND = 1003;
    public const int EVENT_DIALOGUE = 1004;
    public const int EVENT_ATTACKED = 1005;
    public const int EVENT_DAMAGED = 1006;
    public const int EVENT_DISTURBED = 1008;
    public const int EVENT_SPELL_CAST_AT = 1011;
    public const int AI_LEVEL_INVALID = -1;
    public const int AI_LEVEL_DEFAULT = -1;
    public const int AI_LEVEL_VERY_LOW = 0;
    public const int AI_LEVEL_LOW = 1;
    public const int AI_LEVEL_NORMAL = 2;
    public const int AI_LEVEL_HIGH = 3;
    public const int AI_LEVEL_VERY_HIGH = 4;
    public const int AREA_INVALID = -1;
    public const int AREA_NATURAL = 1;
    public const int AREA_ARTIFICIAL = 0;
    public const int AREA_ABOVEGROUND = 1;
    public const int AREA_UNDERGROUND = 0;
    public const int AREA_HEIGHT = 0;
    public const int AREA_WIDTH = 1;
    public const int PORTRAIT_INVALID = 65535;
    public const int USE_CREATURE_LEVEL = 0;

    ///  The following is all the item property constants...
    public const int IP_CONST_ABILITY_STR = 0;
    public const int IP_CONST_ABILITY_DEX = 1;
    public const int IP_CONST_ABILITY_CON = 2;
    public const int IP_CONST_ABILITY_INT = 3;
    public const int IP_CONST_ABILITY_WIS = 4;
    public const int IP_CONST_ABILITY_CHA = 5;
    public const int IP_CONST_ACMODIFIERTYPE_DODGE = 0;
    public const int IP_CONST_ACMODIFIERTYPE_NATURAL = 1;
    public const int IP_CONST_ACMODIFIERTYPE_ARMOR = 2;
    public const int IP_CONST_ACMODIFIERTYPE_SHIELD = 3;
    public const int IP_CONST_ACMODIFIERTYPE_DEFLECTION = 4;
    public const int IP_CONST_ADDITIONAL_UNKNOWN = 0;
    public const int IP_CONST_ADDITIONAL_CURSED = 1;
    public const int IP_CONST_ALIGNMENTGROUP_ALL = 0;
    public const int IP_CONST_ALIGNMENTGROUP_NEUTRAL = 1;
    public const int IP_CONST_ALIGNMENTGROUP_LAWFUL = 2;
    public const int IP_CONST_ALIGNMENTGROUP_CHAOTIC = 3;
    public const int IP_CONST_ALIGNMENTGROUP_GOOD = 4;
    public const int IP_CONST_ALIGNMENTGROUP_EVIL = 5;
    public const int IP_CONST_ALIGNMENT_LG = 0;
    public const int IP_CONST_ALIGNMENT_LN = 1;
    public const int IP_CONST_ALIGNMENT_LE = 2;
    public const int IP_CONST_ALIGNMENT_NG = 3;
    public const int IP_CONST_ALIGNMENT_TN = 4;
    public const int IP_CONST_ALIGNMENT_NE = 5;
    public const int IP_CONST_ALIGNMENT_CG = 6;
    public const int IP_CONST_ALIGNMENT_CN = 7;
    public const int IP_CONST_ALIGNMENT_CE = 8;
    public const int IP_CONST_RACIALTYPE_DWARF = 0;
    public const int IP_CONST_RACIALTYPE_ELF = 1;
    public const int IP_CONST_RACIALTYPE_GNOME = 2;
    public const int IP_CONST_RACIALTYPE_HALFLING = 3;
    public const int IP_CONST_RACIALTYPE_HALFELF = 4;
    public const int IP_CONST_RACIALTYPE_HALFORC = 5;
    public const int IP_CONST_RACIALTYPE_HUMAN = 6;
    public const int IP_CONST_RACIALTYPE_ABERRATION = 7;
    public const int IP_CONST_RACIALTYPE_ANIMAL = 8;
    public const int IP_CONST_RACIALTYPE_BEAST = 9;
    public const int IP_CONST_RACIALTYPE_CONSTRUCT = 10;
    public const int IP_CONST_RACIALTYPE_DRAGON = 11;
    public const int IP_CONST_RACIALTYPE_HUMANOID_GOBLINOID = 12;
    public const int IP_CONST_RACIALTYPE_HUMANOID_MONSTROUS = 13;
    public const int IP_CONST_RACIALTYPE_HUMANOID_ORC = 14;
    public const int IP_CONST_RACIALTYPE_HUMANOID_REPTILIAN = 15;
    public const int IP_CONST_RACIALTYPE_ELEMENTAL = 16;
    public const int IP_CONST_RACIALTYPE_FEY = 17;
    public const int IP_CONST_RACIALTYPE_GIANT = 18;
    public const int IP_CONST_RACIALTYPE_MAGICAL_BEAST = 19;
    public const int IP_CONST_RACIALTYPE_OUTSIDER = 20;
    public const int IP_CONST_RACIALTYPE_SHAPECHANGER = 23;
    public const int IP_CONST_RACIALTYPE_UNDEAD = 24;
    public const int IP_CONST_RACIALTYPE_VERMIN = 25;
    public const int IP_CONST_UNLIMITEDAMMO_BASIC = 1;
    public const int IP_CONST_UNLIMITEDAMMO_1D6FIRE = 2;
    public const int IP_CONST_UNLIMITEDAMMO_1D6COLD = 3;
    public const int IP_CONST_UNLIMITEDAMMO_1D6LIGHT = 4;
    public const int IP_CONST_UNLIMITEDAMMO_PLUS1 = 11;
    public const int IP_CONST_UNLIMITEDAMMO_PLUS2 = 12;
    public const int IP_CONST_UNLIMITEDAMMO_PLUS3 = 13;
    public const int IP_CONST_UNLIMITEDAMMO_PLUS4 = 14;
    public const int IP_CONST_UNLIMITEDAMMO_PLUS5 = 15;
    public const int IP_CONST_AMMOTYPE_ARROW = 0;
    public const int IP_CONST_AMMOTYPE_BOLT = 1;
    public const int IP_CONST_AMMOTYPE_BULLET = 2;
    public const int IP_CONST_CASTSPELL_NUMUSES_SINGLE_USE = 1;
    public const int IP_CONST_CASTSPELL_NUMUSES_5_CHARGES_PER_USE = 2;
    public const int IP_CONST_CASTSPELL_NUMUSES_4_CHARGES_PER_USE = 3;
    public const int IP_CONST_CASTSPELL_NUMUSES_3_CHARGES_PER_USE = 4;
    public const int IP_CONST_CASTSPELL_NUMUSES_2_CHARGES_PER_USE = 5;
    public const int IP_CONST_CASTSPELL_NUMUSES_1_CHARGE_PER_USE = 6;
    public const int IP_CONST_CASTSPELL_NUMUSES_0_CHARGES_PER_USE = 7;
    public const int IP_CONST_CASTSPELL_NUMUSES_1_USE_PER_DAY = 8;
    public const int IP_CONST_CASTSPELL_NUMUSES_2_USES_PER_DAY = 9;
    public const int IP_CONST_CASTSPELL_NUMUSES_3_USES_PER_DAY = 10;
    public const int IP_CONST_CASTSPELL_NUMUSES_4_USES_PER_DAY = 11;
    public const int IP_CONST_CASTSPELL_NUMUSES_5_USES_PER_DAY = 12;
    public const int IP_CONST_CASTSPELL_NUMUSES_UNLIMITED_USE = 13;
    public const int IP_CONST_DAMAGEBONUS_1 = 1;
    public const int IP_CONST_DAMAGEBONUS_2 = 2;
    public const int IP_CONST_DAMAGEBONUS_3 = 3;
    public const int IP_CONST_DAMAGEBONUS_4 = 4;
    public const int IP_CONST_DAMAGEBONUS_5 = 5;
    public const int IP_CONST_DAMAGEBONUS_1d4 = 6;
    public const int IP_CONST_DAMAGEBONUS_1d6 = 7;
    public const int IP_CONST_DAMAGEBONUS_1d8 = 8;
    public const int IP_CONST_DAMAGEBONUS_1d10 = 9;
    public const int IP_CONST_DAMAGEBONUS_2d6 = 10;
    public const int IP_CONST_DAMAGEBONUS_2d8 = 11;
    public const int IP_CONST_DAMAGEBONUS_2d4 = 12;
    public const int IP_CONST_DAMAGEBONUS_2d10 = 13;
    public const int IP_CONST_DAMAGEBONUS_1d12 = 14;
    public const int IP_CONST_DAMAGEBONUS_2d12 = 15;
    public const int IP_CONST_DAMAGEBONUS_6 = 16;
    public const int IP_CONST_DAMAGEBONUS_7 = 17;
    public const int IP_CONST_DAMAGEBONUS_8 = 18;
    public const int IP_CONST_DAMAGEBONUS_9 = 19;
    public const int IP_CONST_DAMAGEBONUS_10 = 20;
    public const int IP_CONST_DAMAGETYPE_BLUDGEONING = 0;
    public const int IP_CONST_DAMAGETYPE_PIERCING = 1;
    public const int IP_CONST_DAMAGETYPE_SLASHING = 2;
    public const int IP_CONST_DAMAGETYPE_SUBDUAL = 3;
    public const int IP_CONST_DAMAGETYPE_PHYSICAL = 4;
    public const int IP_CONST_DAMAGETYPE_MAGICAL = 5;
    public const int IP_CONST_DAMAGETYPE_ACID = 6;
    public const int IP_CONST_DAMAGETYPE_COLD = 7;
    public const int IP_CONST_DAMAGETYPE_DIVINE = 8;
    public const int IP_CONST_DAMAGETYPE_ELECTRICAL = 9;
    public const int IP_CONST_DAMAGETYPE_FIRE = 10;
    public const int IP_CONST_DAMAGETYPE_NEGATIVE = 11;
    public const int IP_CONST_DAMAGETYPE_POSITIVE = 12;
    public const int IP_CONST_DAMAGETYPE_SONIC = 13;
    public const int IP_CONST_DAMAGEIMMUNITY_5_PERCENT = 1;
    public const int IP_CONST_DAMAGEIMMUNITY_10_PERCENT = 2;
    public const int IP_CONST_DAMAGEIMMUNITY_25_PERCENT = 3;
    public const int IP_CONST_DAMAGEIMMUNITY_50_PERCENT = 4;
    public const int IP_CONST_DAMAGEIMMUNITY_75_PERCENT = 5;
    public const int IP_CONST_DAMAGEIMMUNITY_90_PERCENT = 6;
    public const int IP_CONST_DAMAGEIMMUNITY_100_PERCENT = 7;
    public const int IP_CONST_DAMAGEVULNERABILITY_5_PERCENT = 1;
    public const int IP_CONST_DAMAGEVULNERABILITY_10_PERCENT = 2;
    public const int IP_CONST_DAMAGEVULNERABILITY_25_PERCENT = 3;
    public const int IP_CONST_DAMAGEVULNERABILITY_50_PERCENT = 4;
    public const int IP_CONST_DAMAGEVULNERABILITY_75_PERCENT = 5;
    public const int IP_CONST_DAMAGEVULNERABILITY_90_PERCENT = 6;
    public const int IP_CONST_DAMAGEVULNERABILITY_100_PERCENT = 7;
    public const int IP_CONST_FEAT_ALERTNESS = 0;
    public const int IP_CONST_FEAT_AMBIDEXTROUS = 1;
    public const int IP_CONST_FEAT_CLEAVE = 2;
    public const int IP_CONST_FEAT_COMBAT_CASTING = 3;
    public const int IP_CONST_FEAT_DODGE = 4;
    public const int IP_CONST_FEAT_EXTRA_TURNING = 5;
    public const int IP_CONST_FEAT_KNOCKDOWN = 6;
    public const int IP_CONST_FEAT_POINTBLANK = 7;
    public const int IP_CONST_FEAT_SPELLFOCUSABJ = 8;
    public const int IP_CONST_FEAT_SPELLFOCUSCON = 9;
    public const int IP_CONST_FEAT_SPELLFOCUSDIV = 10;
    public const int IP_CONST_FEAT_SPELLFOCUSENC = 11;
    public const int IP_CONST_FEAT_SPELLFOCUSEVO = 12;
    public const int IP_CONST_FEAT_SPELLFOCUSILL = 13;
    public const int IP_CONST_FEAT_SPELLFOCUSNEC = 14;
    public const int IP_CONST_FEAT_SPELLPENETRATION = 15;
    public const int IP_CONST_FEAT_POWERATTACK = 16;
    public const int IP_CONST_FEAT_TWO_WEAPON_FIGHTING = 17;
    public const int IP_CONST_FEAT_WEAPSPEUNARM = 18;
    public const int IP_CONST_FEAT_WEAPFINESSE = 19;
    public const int IP_CONST_FEAT_IMPCRITUNARM = 20;
    public const int IP_CONST_FEAT_WEAPON_PROF_EXOTIC = 21;
    public const int IP_CONST_FEAT_WEAPON_PROF_MARTIAL = 22;
    public const int IP_CONST_FEAT_WEAPON_PROF_SIMPLE = 23;
    public const int IP_CONST_FEAT_ARMOR_PROF_HEAVY = 24;
    public const int IP_CONST_FEAT_ARMOR_PROF_LIGHT = 25;
    public const int IP_CONST_FEAT_ARMOR_PROF_MEDIUM = 26;
    public const int IP_CONST_FEAT_MOBILITY = 27;
    public const int IP_CONST_FEAT_DISARM = 28;
    public const int IP_CONST_FEAT_WHIRLWIND = 29;
    public const int IP_CONST_FEAT_RAPID_SHOT = 30;
    public const int IP_CONST_FEAT_HIDE_IN_PLAIN_SIGHT = 31;
    public const int IP_CONST_FEAT_SNEAK_ATTACK_1D6 = 32;
    public const int IP_CONST_FEAT_SNEAK_ATTACK_2D6 = 33;
    public const int IP_CONST_FEAT_SNEAK_ATTACK_3D6 = 34;
    public const int IP_CONST_FEAT_SHIELD_PROFICIENCY = 35;
    public const int IP_CONST_FEAT_USE_POISON = 36;
    public const int IP_CONST_FEAT_DISARM_WHIP = 37;
    public const int IP_CONST_FEAT_WEAPON_PROF_CREATURE = 38;
    public const int IP_CONST_FEAT_SNEAK_ATTACK_5D6 = 39;
    public const int IP_CONST_FEAT_PLAYER_TOOL_01 = 53;
    public const int IP_CONST_FEAT_PLAYER_TOOL_02 = 54;
    public const int IP_CONST_FEAT_PLAYER_TOOL_03 = 55;
    public const int IP_CONST_FEAT_PLAYER_TOOL_04 = 56;
    public const int IP_CONST_FEAT_PLAYER_TOOL_05 = 57;
    public const int IP_CONST_FEAT_PLAYER_TOOL_06 = 58;
    public const int IP_CONST_FEAT_PLAYER_TOOL_07 = 59;
    public const int IP_CONST_FEAT_PLAYER_TOOL_08 = 60;
    public const int IP_CONST_FEAT_PLAYER_TOOL_09 = 61;
    public const int IP_CONST_FEAT_PLAYER_TOOL_10 = 62;
    public const int IP_CONST_IMMUNITYMISC_BACKSTAB = 0;
    public const int IP_CONST_IMMUNITYMISC_LEVEL_ABIL_DRAIN = 1;
    public const int IP_CONST_IMMUNITYMISC_MINDSPELLS = 2;
    public const int IP_CONST_IMMUNITYMISC_POISON = 3;
    public const int IP_CONST_IMMUNITYMISC_DISEASE = 4;
    public const int IP_CONST_IMMUNITYMISC_FEAR = 5;
    public const int IP_CONST_IMMUNITYMISC_KNOCKDOWN = 6;
    public const int IP_CONST_IMMUNITYMISC_PARALYSIS = 7;
    public const int IP_CONST_IMMUNITYMISC_CRITICAL_HITS = 8;
    public const int IP_CONST_IMMUNITYMISC_DEATH_MAGIC = 9;
    public const int IP_CONST_LIGHTBRIGHTNESS_DIM = 1;
    public const int IP_CONST_LIGHTBRIGHTNESS_LOW = 2;
    public const int IP_CONST_LIGHTBRIGHTNESS_NORMAL = 3;
    public const int IP_CONST_LIGHTBRIGHTNESS_BRIGHT = 4;
    public const int IP_CONST_LIGHTCOLOR_BLUE = 0;
    public const int IP_CONST_LIGHTCOLOR_YELLOW = 1;
    public const int IP_CONST_LIGHTCOLOR_PURPLE = 2;
    public const int IP_CONST_LIGHTCOLOR_RED = 3;
    public const int IP_CONST_LIGHTCOLOR_GREEN = 4;
    public const int IP_CONST_LIGHTCOLOR_ORANGE = 5;
    public const int IP_CONST_LIGHTCOLOR_WHITE = 6;
    public const int IP_CONST_MONSTERDAMAGE_1d2 = 1;
    public const int IP_CONST_MONSTERDAMAGE_1d3 = 2;
    public const int IP_CONST_MONSTERDAMAGE_1d4 = 3;
    public const int IP_CONST_MONSTERDAMAGE_2d4 = 4;
    public const int IP_CONST_MONSTERDAMAGE_3d4 = 5;
    public const int IP_CONST_MONSTERDAMAGE_4d4 = 6;
    public const int IP_CONST_MONSTERDAMAGE_5d4 = 7;
    public const int IP_CONST_MONSTERDAMAGE_1d6 = 8;
    public const int IP_CONST_MONSTERDAMAGE_2d6 = 9;
    public const int IP_CONST_MONSTERDAMAGE_3d6 = 10;
    public const int IP_CONST_MONSTERDAMAGE_4d6 = 11;
    public const int IP_CONST_MONSTERDAMAGE_5d6 = 12;
    public const int IP_CONST_MONSTERDAMAGE_6d6 = 13;
    public const int IP_CONST_MONSTERDAMAGE_7d6 = 14;
    public const int IP_CONST_MONSTERDAMAGE_8d6 = 15;
    public const int IP_CONST_MONSTERDAMAGE_9d6 = 16;
    public const int IP_CONST_MONSTERDAMAGE_10d6 = 17;
    public const int IP_CONST_MONSTERDAMAGE_1d8 = 18;
    public const int IP_CONST_MONSTERDAMAGE_2d8 = 19;
    public const int IP_CONST_MONSTERDAMAGE_3d8 = 20;
    public const int IP_CONST_MONSTERDAMAGE_4d8 = 21;
    public const int IP_CONST_MONSTERDAMAGE_5d8 = 22;
    public const int IP_CONST_MONSTERDAMAGE_6d8 = 23;
    public const int IP_CONST_MONSTERDAMAGE_7d8 = 24;
    public const int IP_CONST_MONSTERDAMAGE_8d8 = 25;
    public const int IP_CONST_MONSTERDAMAGE_9d8 = 26;
    public const int IP_CONST_MONSTERDAMAGE_10d8 = 27;
    public const int IP_CONST_MONSTERDAMAGE_1d10 = 28;
    public const int IP_CONST_MONSTERDAMAGE_2d10 = 29;
    public const int IP_CONST_MONSTERDAMAGE_3d10 = 30;
    public const int IP_CONST_MONSTERDAMAGE_4d10 = 31;
    public const int IP_CONST_MONSTERDAMAGE_5d10 = 32;
    public const int IP_CONST_MONSTERDAMAGE_6d10 = 33;
    public const int IP_CONST_MONSTERDAMAGE_7d10 = 34;
    public const int IP_CONST_MONSTERDAMAGE_8d10 = 35;
    public const int IP_CONST_MONSTERDAMAGE_9d10 = 36;
    public const int IP_CONST_MONSTERDAMAGE_10d10 = 37;
    public const int IP_CONST_MONSTERDAMAGE_1d12 = 38;
    public const int IP_CONST_MONSTERDAMAGE_2d12 = 39;
    public const int IP_CONST_MONSTERDAMAGE_3d12 = 40;
    public const int IP_CONST_MONSTERDAMAGE_4d12 = 41;
    public const int IP_CONST_MONSTERDAMAGE_5d12 = 42;
    public const int IP_CONST_MONSTERDAMAGE_6d12 = 43;
    public const int IP_CONST_MONSTERDAMAGE_7d12 = 44;
    public const int IP_CONST_MONSTERDAMAGE_8d12 = 45;
    public const int IP_CONST_MONSTERDAMAGE_9d12 = 46;
    public const int IP_CONST_MONSTERDAMAGE_10d12 = 47;
    public const int IP_CONST_MONSTERDAMAGE_1d20 = 48;
    public const int IP_CONST_MONSTERDAMAGE_2d20 = 49;
    public const int IP_CONST_MONSTERDAMAGE_3d20 = 50;
    public const int IP_CONST_MONSTERDAMAGE_4d20 = 51;
    public const int IP_CONST_MONSTERDAMAGE_5d20 = 52;
    public const int IP_CONST_MONSTERDAMAGE_6d20 = 53;
    public const int IP_CONST_MONSTERDAMAGE_7d20 = 54;
    public const int IP_CONST_MONSTERDAMAGE_8d20 = 55;
    public const int IP_CONST_MONSTERDAMAGE_9d20 = 56;
    public const int IP_CONST_MONSTERDAMAGE_10d20 = 57;
    public const int IP_CONST_ONMONSTERHIT_ABILITYDRAIN = 0;
    public const int IP_CONST_ONMONSTERHIT_CONFUSION = 1;
    public const int IP_CONST_ONMONSTERHIT_DISEASE = 2;
    public const int IP_CONST_ONMONSTERHIT_DOOM = 3;
    public const int IP_CONST_ONMONSTERHIT_FEAR = 4;
    public const int IP_CONST_ONMONSTERHIT_LEVELDRAIN = 5;
    public const int IP_CONST_ONMONSTERHIT_POISON = 6;
    public const int IP_CONST_ONMONSTERHIT_SLOW = 7;
    public const int IP_CONST_ONMONSTERHIT_STUN = 8;
    public const int IP_CONST_ONMONSTERHIT_WOUNDING = 9;
    public const int IP_CONST_ONHIT_SLEEP = 0;
    public const int IP_CONST_ONHIT_STUN = 1;
    public const int IP_CONST_ONHIT_HOLD = 2;
    public const int IP_CONST_ONHIT_CONFUSION = 3;
    public const int IP_CONST_ONHIT_DAZE = 5;
    public const int IP_CONST_ONHIT_DOOM = 6;
    public const int IP_CONST_ONHIT_FEAR = 7;
    public const int IP_CONST_ONHIT_KNOCK = 8;
    public const int IP_CONST_ONHIT_SLOW = 9;
    public const int IP_CONST_ONHIT_LESSERDISPEL = 10;
    public const int IP_CONST_ONHIT_DISPELMAGIC = 11;
    public const int IP_CONST_ONHIT_GREATERDISPEL = 12;
    public const int IP_CONST_ONHIT_MORDSDISJUNCTION = 13;
    public const int IP_CONST_ONHIT_SILENCE = 14;
    public const int IP_CONST_ONHIT_DEAFNESS = 15;
    public const int IP_CONST_ONHIT_BLINDNESS = 16;
    public const int IP_CONST_ONHIT_LEVELDRAIN = 17;
    public const int IP_CONST_ONHIT_ABILITYDRAIN = 18;
    public const int IP_CONST_ONHIT_ITEMPOISON = 19;
    public const int IP_CONST_ONHIT_DISEASE = 20;
    public const int IP_CONST_ONHIT_SLAYRACE = 21;
    public const int IP_CONST_ONHIT_SLAYALIGNMENTGROUP = 22;
    public const int IP_CONST_ONHIT_SLAYALIGNMENT = 23;
    public const int IP_CONST_ONHIT_VORPAL = 24;
    public const int IP_CONST_ONHIT_WOUNDING = 25;
    public const int IP_CONST_ONHIT_SAVEDC_14 = 0;
    public const int IP_CONST_ONHIT_SAVEDC_16 = 1;
    public const int IP_CONST_ONHIT_SAVEDC_18 = 2;
    public const int IP_CONST_ONHIT_SAVEDC_20 = 3;
    public const int IP_CONST_ONHIT_SAVEDC_22 = 4;
    public const int IP_CONST_ONHIT_SAVEDC_24 = 5;
    public const int IP_CONST_ONHIT_SAVEDC_26 = 6;
    public const int IP_CONST_ONHIT_DURATION_5_PERCENT_5_ROUNDS = 0;
    public const int IP_CONST_ONHIT_DURATION_10_PERCENT_4_ROUNDS = 1;
    public const int IP_CONST_ONHIT_DURATION_25_PERCENT_3_ROUNDS = 2;
    public const int IP_CONST_ONHIT_DURATION_50_PERCENT_2_ROUNDS = 3;
    public const int IP_CONST_ONHIT_DURATION_75_PERCENT_1_ROUND = 4;
    public const int IP_CONST_ONHIT_CASTSPELL_ACID_FOG = 0;
    public const int IP_CONST_ONHIT_CASTSPELL_BESTOW_CURSE = 1;
    public const int IP_CONST_ONHIT_CASTSPELL_BLADE_BARRIER = 2;
    public const int IP_CONST_ONHIT_CASTSPELL_BLINDNESS_AND_DEAFNESS = 3;
    public const int IP_CONST_ONHIT_CASTSPELL_CALL_LIGHTNING = 4;
    public const int IP_CONST_ONHIT_CASTSPELL_CHAIN_LIGHTNING = 5;
    public const int IP_CONST_ONHIT_CASTSPELL_CLOUDKILL = 6;
    public const int IP_CONST_ONHIT_CASTSPELL_CONFUSION = 7;
    public const int IP_CONST_ONHIT_CASTSPELL_CONTAGION = 8;
    public const int IP_CONST_ONHIT_CASTSPELL_DARKNESS = 9;
    public const int IP_CONST_ONHIT_CASTSPELL_DAZE = 10;
    public const int IP_CONST_ONHIT_CASTSPELL_DELAYED_BLAST_FIREBALL = 11;
    public const int IP_CONST_ONHIT_CASTSPELL_DISMISSAL = 12;
    public const int IP_CONST_ONHIT_CASTSPELL_DISPEL_MAGIC = 13;
    public const int IP_CONST_ONHIT_CASTSPELL_DOOM = 14;
    public const int IP_CONST_ONHIT_CASTSPELL_ENERGY_DRAIN = 15;
    public const int IP_CONST_ONHIT_CASTSPELL_ENERVATION = 16;
    public const int IP_CONST_ONHIT_CASTSPELL_ENTANGLE = 17;
    public const int IP_CONST_ONHIT_CASTSPELL_FEAR = 18;
    public const int IP_CONST_ONHIT_CASTSPELL_FEEBLEMIND = 19;
    public const int IP_CONST_ONHIT_CASTSPELL_FIRE_STORM = 20;
    public const int IP_CONST_ONHIT_CASTSPELL_FIREBALL = 21;
    public const int IP_CONST_ONHIT_CASTSPELL_FLAME_LASH = 22;
    public const int IP_CONST_ONHIT_CASTSPELL_FLAME_STRIKE = 23;
    public const int IP_CONST_ONHIT_CASTSPELL_GHOUL_TOUCH = 24;
    public const int IP_CONST_ONHIT_CASTSPELL_GREASE = 25;
    public const int IP_CONST_ONHIT_CASTSPELL_GREATER_DISPELLING = 26;
    public const int IP_CONST_ONHIT_CASTSPELL_GREATER_SPELL_BREACH = 27;
    public const int IP_CONST_ONHIT_CASTSPELL_GUST_OF_WIND = 28;
    public const int IP_CONST_ONHIT_CASTSPELL_HAMMER_OF_THE_GODS = 29;
    public const int IP_CONST_ONHIT_CASTSPELL_HARM = 30;
    public const int IP_CONST_ONHIT_CASTSPELL_HOLD_ANIMAL = 31;
    public const int IP_CONST_ONHIT_CASTSPELL_HOLD_MONSTER = 32;
    public const int IP_CONST_ONHIT_CASTSPELL_HOLD_PERSON = 33;
    public const int IP_CONST_ONHIT_CASTSPELL_IMPLOSION = 34;
    public const int IP_CONST_ONHIT_CASTSPELL_INCENDIARY_CLOUD = 35;
    public const int IP_CONST_ONHIT_CASTSPELL_LESSER_DISPEL = 36;
    public const int IP_CONST_ONHIT_CASTSPELL_LESSER_SPELL_BREACH = 38;
    public const int IP_CONST_ONHIT_CASTSPELL_LIGHT = 40;
    public const int IP_CONST_ONHIT_CASTSPELL_LIGHTNING_BOLT = 41;
    public const int IP_CONST_ONHIT_CASTSPELL_MAGIC_MISSILE = 42;
    public const int IP_CONST_ONHIT_CASTSPELL_MASS_BLINDNESS_AND_DEAFNESS = 43;
    public const int IP_CONST_ONHIT_CASTSPELL_MASS_CHARM = 44;
    public const int IP_CONST_ONHIT_CASTSPELL_MELFS_ACID_ARROW = 45;
    public const int IP_CONST_ONHIT_CASTSPELL_METEOR_SWARM = 46;
    public const int IP_CONST_ONHIT_CASTSPELL_MIND_FOG = 47;
    public const int IP_CONST_ONHIT_CASTSPELL_PHANTASMAL_KILLER = 49;
    public const int IP_CONST_ONHIT_CASTSPELL_POISON = 50;
    public const int IP_CONST_ONHIT_CASTSPELL_POWER_WORD_KILL = 51;
    public const int IP_CONST_ONHIT_CASTSPELL_POWER_WORD_STUN = 52;
    public const int IP_CONST_ONHIT_CASTSPELL_SCARE = 54;
    public const int IP_CONST_ONHIT_CASTSPELL_SEARING_LIGHT = 55;
    public const int IP_CONST_ONHIT_CASTSPELL_SILENCE = 56;
    public const int IP_CONST_ONHIT_CASTSPELL_SLAY_LIVING = 57;
    public const int IP_CONST_ONHIT_CASTSPELL_SLEEP = 58;
    public const int IP_CONST_ONHIT_CASTSPELL_SLOW = 59;
    public const int IP_CONST_ONHIT_CASTSPELL_SOUND_BURST = 60;
    public const int IP_CONST_ONHIT_CASTSPELL_STINKING_CLOUD = 61;
    public const int IP_CONST_ONHIT_CASTSPELL_STORM_OF_VENGEANCE = 63;
    public const int IP_CONST_ONHIT_CASTSPELL_SUNBEAM = 64;
    public const int IP_CONST_ONHIT_CASTSPELL_VAMPIRIC_TOUCH = 65;
    public const int IP_CONST_ONHIT_CASTSPELL_WAIL_OF_THE_BANSHEE = 66;
    public const int IP_CONST_ONHIT_CASTSPELL_WALL_OF_FIRE = 67;
    public const int IP_CONST_ONHIT_CASTSPELL_WEB = 68;
    public const int IP_CONST_ONHIT_CASTSPELL_WEIRD = 69;
    public const int IP_CONST_ONHIT_CASTSPELL_WORD_OF_FAITH = 70;
    public const int IP_CONST_ONHIT_CASTSPELL_CREEPING_DOOM = 72;
    public const int IP_CONST_ONHIT_CASTSPELL_DESTRUCTION = 73;
    public const int IP_CONST_ONHIT_CASTSPELL_HORRID_WILTING = 74;
    public const int IP_CONST_ONHIT_CASTSPELL_ICE_STORM = 75;
    public const int IP_CONST_ONHIT_CASTSPELL_NEGATIVE_ENERGY_BURST = 76;
    public const int IP_CONST_ONHIT_CASTSPELL_EVARDS_BLACK_TENTACLES = 77;
    public const int IP_CONST_ONHIT_CASTSPELL_ACTIVATE_ITEM = 78;
    public const int IP_CONST_ONHIT_CASTSPELL_FLARE = 79;
    public const int IP_CONST_ONHIT_CASTSPELL_BOMBARDMENT = 80;
    public const int IP_CONST_ONHIT_CASTSPELL_ACID_SPLASH = 81;
    public const int IP_CONST_ONHIT_CASTSPELL_QUILLFIRE = 82;
    public const int IP_CONST_ONHIT_CASTSPELL_EARTHQUAKE = 83;
    public const int IP_CONST_ONHIT_CASTSPELL_SUNBURST = 84;
    public const int IP_CONST_ONHIT_CASTSPELL_BANISHMENT = 85;
    public const int IP_CONST_ONHIT_CASTSPELL_INFLICT_MINOR_WOUNDS = 86;
    public const int IP_CONST_ONHIT_CASTSPELL_INFLICT_LIGHT_WOUNDS = 87;
    public const int IP_CONST_ONHIT_CASTSPELL_INFLICT_MODERATE_WOUNDS = 88;
    public const int IP_CONST_ONHIT_CASTSPELL_INFLICT_SERIOUS_WOUNDS = 89;
    public const int IP_CONST_ONHIT_CASTSPELL_INFLICT_CRITICAL_WOUNDS = 90;
    public const int IP_CONST_ONHIT_CASTSPELL_BALAGARNSIRONHORN = 91;
    public const int IP_CONST_ONHIT_CASTSPELL_DROWN = 92;
    public const int IP_CONST_ONHIT_CASTSPELL_ELECTRIC_JOLT = 93;
    public const int IP_CONST_ONHIT_CASTSPELL_FIREBRAND = 94;
    public const int IP_CONST_ONHIT_CASTSPELL_WOUNDING_WHISPERS = 95;
    public const int IP_CONST_ONHIT_CASTSPELL_UNDEATHS_ETERNAL_FOE = 96;
    public const int IP_CONST_ONHIT_CASTSPELL_INFERNO = 97;
    public const int IP_CONST_ONHIT_CASTSPELL_ISAACS_LESSER_MISSILE_STORM = 98;
    public const int IP_CONST_ONHIT_CASTSPELL_ISAACS_GREATER_MISSILE_STORM = 99;
    public const int IP_CONST_ONHIT_CASTSPELL_BANE = 100;
    public const int IP_CONST_ONHIT_CASTSPELL_SPIKE_GROWTH = 101;
    public const int IP_CONST_ONHIT_CASTSPELL_TASHAS_HIDEOUS_LAUGHTER = 102;
    public const int IP_CONST_ONHIT_CASTSPELL_BIGBYS_INTERPOSING_HAND = 103;
    public const int IP_CONST_ONHIT_CASTSPELL_BIGBYS_FORCEFUL_HAND = 104;
    public const int IP_CONST_ONHIT_CASTSPELL_BIGBYS_GRASPING_HAND = 105;
    public const int IP_CONST_ONHIT_CASTSPELL_BIGBYS_CLENCHED_FIST = 106;
    public const int IP_CONST_ONHIT_CASTSPELL_BIGBYS_CRUSHING_HAND = 107;
    public const int IP_CONST_ONHIT_CASTSPELL_FLESH_TO_STONE = 108;
    public const int IP_CONST_ONHIT_CASTSPELL_STONE_TO_FLESH = 109;
    public const int IP_CONST_ONHIT_CASTSPELL_CRUMBLE = 110;
    public const int IP_CONST_ONHIT_CASTSPELL_INFESTATION_OF_MAGGOTS = 111;
    public const int IP_CONST_ONHIT_CASTSPELL_GREAT_THUNDERCLAP = 112;
    public const int IP_CONST_ONHIT_CASTSPELL_BALL_LIGHTNING = 113;
    public const int IP_CONST_ONHIT_CASTSPELL_GEDLEES_ELECTRIC_LOOP = 114;
    public const int IP_CONST_ONHIT_CASTSPELL_HORIZIKAULS_BOOM = 115;
    public const int IP_CONST_ONHIT_CASTSPELL_MESTILS_ACID_BREATH = 116;
    public const int IP_CONST_ONHIT_CASTSPELL_SCINTILLATING_SPHERE = 117;
    public const int IP_CONST_ONHIT_CASTSPELL_UNDEATH_TO_DEATH = 118;
    public const int IP_CONST_ONHIT_CASTSPELL_STONEHOLD = 119;
    public const int IP_CONST_ONHIT_CASTSPELL_EVIL_BLIGHT = 121;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_TELEPORT = 122;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_SLAYRAKSHASA = 123;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_FIREDAMAGE = 124;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_UNIQUEPOWER = 125;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_PLANARRIFT = 126;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_DARKFIRE = 127;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_EXTRACTBRAIN = 128;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHITFLAMINGSKIN = 129;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_CHAOSSHIELD = 130;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHIT_CONSTRICTWEAPON = 131;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHITRUINARMORBEBILITH = 132;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHITDEMILICHTOUCH = 133;
    public const int IP_CONST_ONHIT_CASTSPELL_ONHITDRACOLICHTOUCH = 134;
    public const int IP_CONST_ONHIT_CASTSPELL_INTELLIGENT_WEAPON_ONHIT = 135;
    public const int IP_CONST_ONHIT_CASTSPELL_PARALYZE_2 = 136;
    public const int IP_CONST_ONHIT_CASTSPELL_DEAFENING_CLNG = 137;
    public const int IP_CONST_ONHIT_CASTSPELL_KNOCKDOWN = 138;
    public const int IP_CONST_ONHIT_CASTSPELL_FREEZE = 139;
    public const int IP_CONST_ONHIT_CASTSPELL_COMBUST = 140;
    public const int IP_CONST_POISON_1D2_STRDAMAGE = 0;
    public const int IP_CONST_POISON_1D2_DEXDAMAGE = 1;
    public const int IP_CONST_POISON_1D2_CONDAMAGE = 2;
    public const int IP_CONST_POISON_1D2_INTDAMAGE = 3;
    public const int IP_CONST_POISON_1D2_WISDAMAGE = 4;
    public const int IP_CONST_POISON_1D2_CHADAMAGE = 5;
    public const int IP_CONST_QUALITY_UNKOWN = 0;
    public const int IP_CONST_QUALITY_DESTROYED = 1;
    public const int IP_CONST_QUALITY_RUINED = 2;
    public const int IP_CONST_QUALITY_VERY_POOR = 3;
    public const int IP_CONST_QUALITY_POOR = 4;
    public const int IP_CONST_QUALITY_BELOW_AVERAGE = 5;
    public const int IP_CONST_QUALITY_AVERAGE = 6;
    public const int IP_CONST_QUALITY_ABOVE_AVERAGE = 7;
    public const int IP_CONST_QUALITY_GOOD = 8;
    public const int IP_CONST_QUALITY_VERY_GOOD = 9;
    public const int IP_CONST_QUALITY_EXCELLENT = 10;
    public const int IP_CONST_QUALITY_MASTERWORK = 11;
    public const int IP_CONST_QUALITY_GOD_LIKE = 12;
    public const int IP_CONST_QUALITY_RAW = 13;
    public const int IP_CONST_QUALITY_CUT = 14;
    public const int IP_CONST_QUALITY_POLISHED = 15;
    public const int IP_CONST_CONTAINERWEIGHTRED_20_PERCENT = 1;
    public const int IP_CONST_CONTAINERWEIGHTRED_40_PERCENT = 2;
    public const int IP_CONST_CONTAINERWEIGHTRED_60_PERCENT = 3;
    public const int IP_CONST_CONTAINERWEIGHTRED_80_PERCENT = 4;
    public const int IP_CONST_CONTAINERWEIGHTRED_100_PERCENT = 5;
    public const int IP_CONST_DAMAGERESIST_5 = 1;
    public const int IP_CONST_DAMAGERESIST_10 = 2;
    public const int IP_CONST_DAMAGERESIST_15 = 3;
    public const int IP_CONST_DAMAGERESIST_20 = 4;
    public const int IP_CONST_DAMAGERESIST_25 = 5;
    public const int IP_CONST_DAMAGERESIST_30 = 6;
    public const int IP_CONST_DAMAGERESIST_35 = 7;
    public const int IP_CONST_DAMAGERESIST_40 = 8;
    public const int IP_CONST_DAMAGERESIST_45 = 9;
    public const int IP_CONST_DAMAGERESIST_50 = 10;
    public const int IP_CONST_SAVEVS_ACID = 1;
    public const int IP_CONST_SAVEVS_COLD = 3;
    public const int IP_CONST_SAVEVS_DEATH = 4;
    public const int IP_CONST_SAVEVS_DISEASE = 5;
    public const int IP_CONST_SAVEVS_DIVINE = 6;
    public const int IP_CONST_SAVEVS_ELECTRICAL = 7;
    public const int IP_CONST_SAVEVS_FEAR = 8;
    public const int IP_CONST_SAVEVS_FIRE = 9;
    public const int IP_CONST_SAVEVS_MINDAFFECTING = 11;
    public const int IP_CONST_SAVEVS_NEGATIVE = 12;
    public const int IP_CONST_SAVEVS_POISON = 13;
    public const int IP_CONST_SAVEVS_POSITIVE = 14;
    public const int IP_CONST_SAVEVS_SONIC = 15;
    public const int IP_CONST_SAVEVS_UNIVERSAL = 0;
    public const int IP_CONST_SAVEBASETYPE_FORTITUDE = 1;
    public const int IP_CONST_SAVEBASETYPE_WILL = 2;
    public const int IP_CONST_SAVEBASETYPE_REFLEX = 3;
    public const int IP_CONST_DAMAGESOAK_5_HP = 1;
    public const int IP_CONST_DAMAGESOAK_10_HP = 2;
    public const int IP_CONST_DAMAGESOAK_15_HP = 3;
    public const int IP_CONST_DAMAGESOAK_20_HP = 4;
    public const int IP_CONST_DAMAGESOAK_25_HP = 5;
    public const int IP_CONST_DAMAGESOAK_30_HP = 6;
    public const int IP_CONST_DAMAGESOAK_35_HP = 7;
    public const int IP_CONST_DAMAGESOAK_40_HP = 8;
    public const int IP_CONST_DAMAGESOAK_45_HP = 9;
    public const int IP_CONST_DAMAGESOAK_50_HP = 10;
    public const int IP_CONST_DAMAGEREDUCTION_1 = 0;
    public const int IP_CONST_DAMAGEREDUCTION_2 = 1;
    public const int IP_CONST_DAMAGEREDUCTION_3 = 2;
    public const int IP_CONST_DAMAGEREDUCTION_4 = 3;
    public const int IP_CONST_DAMAGEREDUCTION_5 = 4;
    public const int IP_CONST_DAMAGEREDUCTION_6 = 5;
    public const int IP_CONST_DAMAGEREDUCTION_7 = 6;
    public const int IP_CONST_DAMAGEREDUCTION_8 = 7;
    public const int IP_CONST_DAMAGEREDUCTION_9 = 8;
    public const int IP_CONST_DAMAGEREDUCTION_10 = 9;
    public const int IP_CONST_DAMAGEREDUCTION_11 = 10;
    public const int IP_CONST_DAMAGEREDUCTION_12 = 11;
    public const int IP_CONST_DAMAGEREDUCTION_13 = 12;
    public const int IP_CONST_DAMAGEREDUCTION_14 = 13;
    public const int IP_CONST_DAMAGEREDUCTION_15 = 14;
    public const int IP_CONST_DAMAGEREDUCTION_16 = 15;
    public const int IP_CONST_DAMAGEREDUCTION_17 = 16;
    public const int IP_CONST_DAMAGEREDUCTION_18 = 17;
    public const int IP_CONST_DAMAGEREDUCTION_19 = 18;
    public const int IP_CONST_DAMAGEREDUCTION_20 = 19;
    public const int IP_CONST_IMMUNITYSPELL_ACID_FOG = 0;
    public const int IP_CONST_IMMUNITYSPELL_AID = 1;
    public const int IP_CONST_IMMUNITYSPELL_BARKSKIN = 2;
    public const int IP_CONST_IMMUNITYSPELL_BESTOW_CURSE = 3;
    public const int IP_CONST_IMMUNITYSPELL_BLINDNESS_AND_DEAFNESS = 6;
    public const int IP_CONST_IMMUNITYSPELL_BURNING_HANDS = 8;
    public const int IP_CONST_IMMUNITYSPELL_CALL_LIGHTNING = 9;
    public const int IP_CONST_IMMUNITYSPELL_CHAIN_LIGHTNING = 12;
    public const int IP_CONST_IMMUNITYSPELL_CHARM_MONSTER = 13;
    public const int IP_CONST_IMMUNITYSPELL_CHARM_PERSON = 14;
    public const int IP_CONST_IMMUNITYSPELL_CHARM_PERSON_OR_ANIMAL = 15;
    public const int IP_CONST_IMMUNITYSPELL_CIRCLE_OF_DEATH = 16;
    public const int IP_CONST_IMMUNITYSPELL_CIRCLE_OF_DOOM = 17;
    public const int IP_CONST_IMMUNITYSPELL_CLOUDKILL = 21;
    public const int IP_CONST_IMMUNITYSPELL_COLOR_SPRAY = 22;
    public const int IP_CONST_IMMUNITYSPELL_CONE_OF_COLD = 23;
    public const int IP_CONST_IMMUNITYSPELL_CONFUSION = 24;
    public const int IP_CONST_IMMUNITYSPELL_CONTAGION = 25;
    public const int IP_CONST_IMMUNITYSPELL_CONTROL_UNDEAD = 26;
    public const int IP_CONST_IMMUNITYSPELL_CURE_CRITICAL_WOUNDS = 27;
    public const int IP_CONST_IMMUNITYSPELL_CURE_LIGHT_WOUNDS = 28;
    public const int IP_CONST_IMMUNITYSPELL_CURE_MINOR_WOUNDS = 29;
    public const int IP_CONST_IMMUNITYSPELL_CURE_MODERATE_WOUNDS = 30;
    public const int IP_CONST_IMMUNITYSPELL_CURE_SERIOUS_WOUNDS = 31;
    public const int IP_CONST_IMMUNITYSPELL_DARKNESS = 32;
    public const int IP_CONST_IMMUNITYSPELL_DAZE = 33;
    public const int IP_CONST_IMMUNITYSPELL_DEATH_WARD = 34;
    public const int IP_CONST_IMMUNITYSPELL_DELAYED_BLAST_FIREBALL = 35;
    public const int IP_CONST_IMMUNITYSPELL_DISMISSAL = 36;
    public const int IP_CONST_IMMUNITYSPELL_DISPEL_MAGIC = 37;
    public const int IP_CONST_IMMUNITYSPELL_DOMINATE_ANIMAL = 39;
    public const int IP_CONST_IMMUNITYSPELL_DOMINATE_MONSTER = 40;
    public const int IP_CONST_IMMUNITYSPELL_DOMINATE_PERSON = 41;
    public const int IP_CONST_IMMUNITYSPELL_DOOM = 42;
    public const int IP_CONST_IMMUNITYSPELL_ENERGY_DRAIN = 46;
    public const int IP_CONST_IMMUNITYSPELL_ENERVATION = 47;
    public const int IP_CONST_IMMUNITYSPELL_ENTANGLE = 48;
    public const int IP_CONST_IMMUNITYSPELL_FEAR = 49;
    public const int IP_CONST_IMMUNITYSPELL_FEEBLEMIND = 50;
    public const int IP_CONST_IMMUNITYSPELL_FINGER_OF_DEATH = 51;
    public const int IP_CONST_IMMUNITYSPELL_FIRE_STORM = 52;
    public const int IP_CONST_IMMUNITYSPELL_FIREBALL = 53;
    public const int IP_CONST_IMMUNITYSPELL_FLAME_ARROW = 54;
    public const int IP_CONST_IMMUNITYSPELL_FLAME_LASH = 55;
    public const int IP_CONST_IMMUNITYSPELL_FLAME_STRIKE = 56;
    public const int IP_CONST_IMMUNITYSPELL_FREEDOM_OF_MOVEMENT = 57;
    public const int IP_CONST_IMMUNITYSPELL_GREASE = 59;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_DISPELLING = 60;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_PLANAR_BINDING = 62;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_SHADOW_CONJURATION = 64;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_SPELL_BREACH = 65;
    public const int IP_CONST_IMMUNITYSPELL_HAMMER_OF_THE_GODS = 68;
    public const int IP_CONST_IMMUNITYSPELL_HARM = 69;
    public const int IP_CONST_IMMUNITYSPELL_HEAL = 71;
    public const int IP_CONST_IMMUNITYSPELL_HEALING_CIRCLE = 72;
    public const int IP_CONST_IMMUNITYSPELL_HOLD_ANIMAL = 73;
    public const int IP_CONST_IMMUNITYSPELL_HOLD_MONSTER = 74;
    public const int IP_CONST_IMMUNITYSPELL_HOLD_PERSON = 75;
    public const int IP_CONST_IMMUNITYSPELL_IMPLOSION = 78;
    public const int IP_CONST_IMMUNITYSPELL_IMPROVED_INVISIBILITY = 79;
    public const int IP_CONST_IMMUNITYSPELL_INCENDIARY_CLOUD = 80;
    public const int IP_CONST_IMMUNITYSPELL_INVISIBILITY_PURGE = 82;
    public const int IP_CONST_IMMUNITYSPELL_LESSER_DISPEL = 84;
    public const int IP_CONST_IMMUNITYSPELL_LESSER_PLANAR_BINDING = 86;
    public const int IP_CONST_IMMUNITYSPELL_LESSER_SPELL_BREACH = 88;
    public const int IP_CONST_IMMUNITYSPELL_LIGHTNING_BOLT = 91;
    public const int IP_CONST_IMMUNITYSPELL_MAGIC_MISSILE = 97;
    public const int IP_CONST_IMMUNITYSPELL_MASS_BLINDNESS_AND_DEAFNESS = 100;
    public const int IP_CONST_IMMUNITYSPELL_MASS_CHARM = 101;
    public const int IP_CONST_IMMUNITYSPELL_MASS_HEAL = 104;
    public const int IP_CONST_IMMUNITYSPELL_MELFS_ACID_ARROW = 105;
    public const int IP_CONST_IMMUNITYSPELL_METEOR_SWARM = 106;
    public const int IP_CONST_IMMUNITYSPELL_MIND_FOG = 108;
    public const int IP_CONST_IMMUNITYSPELL_MORDENKAINENS_DISJUNCTION = 112;
    public const int IP_CONST_IMMUNITYSPELL_PHANTASMAL_KILLER = 116;
    public const int IP_CONST_IMMUNITYSPELL_PLANAR_BINDING = 117;
    public const int IP_CONST_IMMUNITYSPELL_POISON = 118;
    public const int IP_CONST_IMMUNITYSPELL_POWER_WORD_KILL = 120;
    public const int IP_CONST_IMMUNITYSPELL_POWER_WORD_STUN = 121;
    public const int IP_CONST_IMMUNITYSPELL_PRISMATIC_SPRAY = 124;
    public const int IP_CONST_IMMUNITYSPELL_RAY_OF_ENFEEBLEMENT = 131;
    public const int IP_CONST_IMMUNITYSPELL_RAY_OF_FROST = 132;
    public const int IP_CONST_IMMUNITYSPELL_SCARE = 142;
    public const int IP_CONST_IMMUNITYSPELL_SEARING_LIGHT = 143;
    public const int IP_CONST_IMMUNITYSPELL_SHADES = 145;
    public const int IP_CONST_IMMUNITYSPELL_SHADOW_CONJURATION = 146;
    public const int IP_CONST_IMMUNITYSPELL_SILENCE = 150;
    public const int IP_CONST_IMMUNITYSPELL_SLAY_LIVING = 151;
    public const int IP_CONST_IMMUNITYSPELL_SLEEP = 152;
    public const int IP_CONST_IMMUNITYSPELL_SLOW = 153;
    public const int IP_CONST_IMMUNITYSPELL_SOUND_BURST = 154;
    public const int IP_CONST_IMMUNITYSPELL_STINKING_CLOUD = 158;
    public const int IP_CONST_IMMUNITYSPELL_STONESKIN = 159;
    public const int IP_CONST_IMMUNITYSPELL_STORM_OF_VENGEANCE = 160;
    public const int IP_CONST_IMMUNITYSPELL_SUNBEAM = 161;
    public const int IP_CONST_IMMUNITYSPELL_VIRTUE = 165;
    public const int IP_CONST_IMMUNITYSPELL_WAIL_OF_THE_BANSHEE = 166;
    public const int IP_CONST_IMMUNITYSPELL_WEB = 167;
    public const int IP_CONST_IMMUNITYSPELL_WEIRD = 168;
    public const int IP_CONST_IMMUNITYSPELL_WORD_OF_FAITH = 169;
    public const int IP_CONST_IMMUNITYSPELL_MAGIC_CIRCLE_AGAINST_ALIGNMENT = 171;
    public const int IP_CONST_IMMUNITYSPELL_EAGLE_SPLEDOR = 173;
    public const int IP_CONST_IMMUNITYSPELL_OWLS_WISDOM = 174;
    public const int IP_CONST_IMMUNITYSPELL_FOXS_CUNNING = 175;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_EAGLES_SPLENDOR = 176;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_OWLS_WISDOM = 177;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_FOXS_CUNNING = 178;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_BULLS_STRENGTH = 179;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_CATS_GRACE = 180;
    public const int IP_CONST_IMMUNITYSPELL_GREATER_ENDURANCE = 181;
    public const int IP_CONST_IMMUNITYSPELL_AURA_OF_VITALITY = 182;
    public const int IP_CONST_IMMUNITYSPELL_WAR_CRY = 183;
    public const int IP_CONST_IMMUNITYSPELL_REGENERATE = 184;
    public const int IP_CONST_IMMUNITYSPELL_EVARDS_BLACK_TENTACLES = 185;
    public const int IP_CONST_IMMUNITYSPELL_LEGEND_LORE = 186;
    public const int IP_CONST_IMMUNITYSPELL_FIND_TRAPS = 187;
    public const int IP_CONST_SPELLLEVEL_0 = 0;

    ///  hmm are these necessary?
    public const int IP_CONST_SPELLLEVEL_1 = 1;
    public const int IP_CONST_SPELLLEVEL_2 = 2;
    public const int IP_CONST_SPELLLEVEL_3 = 3;
    public const int IP_CONST_SPELLLEVEL_4 = 4;
    public const int IP_CONST_SPELLLEVEL_5 = 5;
    public const int IP_CONST_SPELLLEVEL_6 = 6;
    public const int IP_CONST_SPELLLEVEL_7 = 7;
    public const int IP_CONST_SPELLLEVEL_8 = 8;
    public const int IP_CONST_SPELLLEVEL_9 = 9;
    public const int IP_CONST_CASTSPELL_ACID_FOG_11 = 0;
    public const int IP_CONST_CASTSPELL_ACID_SPLASH_1 = 355;
    public const int IP_CONST_CASTSPELL_ACTIVATE_ITEM = 359;
    public const int IP_CONST_CASTSPELL_AID_3 = 1;
    public const int IP_CONST_CASTSPELL_AMPLIFY_5 = 373;
    public const int IP_CONST_CASTSPELL_ANIMATE_DEAD_10 = 3;
    public const int IP_CONST_CASTSPELL_ANIMATE_DEAD_15 = 4;
    public const int IP_CONST_CASTSPELL_ANIMATE_DEAD_5 = 2;
    public const int IP_CONST_CASTSPELL_AURA_OF_VITALITY_13 = 321;
    public const int IP_CONST_CASTSPELL_AURA_VERSUS_ALIGNMENT_15 = 287;
    public const int IP_CONST_CASTSPELL_AURAOFGLORY_7 = 360;
    public const int IP_CONST_CASTSPELL_AWAKEN_9 = 303;
    public const int IP_CONST_CASTSPELL_BALAGARNSIRONHORN_7 = 367;
    public const int IP_CONST_CASTSPELL_BANE_5 = 380;
    public const int IP_CONST_CASTSPELL_BANISHMENT_15 = 361;
    public const int IP_CONST_CASTSPELL_BARKSKIN_12 = 7;
    public const int IP_CONST_CASTSPELL_BARKSKIN_3 = 5;
    public const int IP_CONST_CASTSPELL_BARKSKIN_6 = 6;
    public const int IP_CONST_CASTSPELL_BESTOW_CURSE_5 = 8;
    public const int IP_CONST_CASTSPELL_BIGBYS_CLENCHED_FIST_20 = 393;
    public const int IP_CONST_CASTSPELL_BIGBYS_CRUSHING_HAND_20 = 394;
    public const int IP_CONST_CASTSPELL_BIGBYS_FORCEFUL_HAND_15 = 391;
    public const int IP_CONST_CASTSPELL_BIGBYS_GRASPING_HAND_17 = 392;
    public const int IP_CONST_CASTSPELL_BIGBYS_INTERPOSING_HAND_15 = 390;
    public const int IP_CONST_CASTSPELL_BLADE_BARRIER_11 = 9;
    public const int IP_CONST_CASTSPELL_BLADE_BARRIER_15 = 10;
    public const int IP_CONST_CASTSPELL_BLESS_2 = 11;
    public const int IP_CONST_CASTSPELL_BLINDNESS_DEAFNESS_3 = 14;
    public const int IP_CONST_CASTSPELL_BLOOD_FRENZY_7 = 353;
    public const int IP_CONST_CASTSPELL_BOMBARDMENT_20 = 354;
    public const int IP_CONST_CASTSPELL_BULLS_STRENGTH_10 = 16;
    public const int IP_CONST_CASTSPELL_BULLS_STRENGTH_15 = 17;
    public const int IP_CONST_CASTSPELL_BULLS_STRENGTH_3 = 15;
    public const int IP_CONST_CASTSPELL_BURNING_HANDS_2 = 18;
    public const int IP_CONST_CASTSPELL_BURNING_HANDS_5 = 19;
    public const int IP_CONST_CASTSPELL_CALL_LIGHTNING_10 = 21;
    public const int IP_CONST_CASTSPELL_CALL_LIGHTNING_5 = 20;
    public const int IP_CONST_CASTSPELL_CAMOFLAGE_5 = 352;
    public const int IP_CONST_CASTSPELL_CATS_GRACE_10 = 26;
    public const int IP_CONST_CASTSPELL_CATS_GRACE_15 = 27;
    public const int IP_CONST_CASTSPELL_CATS_GRACE_3 = 25;
    public const int IP_CONST_CASTSPELL_CHAIN_LIGHTNING_11 = 28;
    public const int IP_CONST_CASTSPELL_CHAIN_LIGHTNING_15 = 29;
    public const int IP_CONST_CASTSPELL_CHAIN_LIGHTNING_20 = 30;
    public const int IP_CONST_CASTSPELL_CHARM_MONSTER_10 = 32;
    public const int IP_CONST_CASTSPELL_CHARM_MONSTER_5 = 31;
    public const int IP_CONST_CASTSPELL_CHARM_PERSON_10 = 34;
    public const int IP_CONST_CASTSPELL_CHARM_PERSON_2 = 33;
    public const int IP_CONST_CASTSPELL_CHARM_PERSON_OR_ANIMAL_10 = 36;
    public const int IP_CONST_CASTSPELL_CHARM_PERSON_OR_ANIMAL_3 = 35;
    public const int IP_CONST_CASTSPELL_CIRCLE_OF_DEATH_11 = 37;
    public const int IP_CONST_CASTSPELL_CIRCLE_OF_DEATH_15 = 38;
    public const int IP_CONST_CASTSPELL_CIRCLE_OF_DEATH_20 = 39;
    public const int IP_CONST_CASTSPELL_CIRCLE_OF_DOOM_15 = 41;
    public const int IP_CONST_CASTSPELL_CIRCLE_OF_DOOM_20 = 42;
    public const int IP_CONST_CASTSPELL_CIRCLE_OF_DOOM_9 = 40;
    public const int IP_CONST_CASTSPELL_CLAIRAUDIENCE_CLAIRVOYANCE_10 = 44;
    public const int IP_CONST_CASTSPELL_CLAIRAUDIENCE_CLAIRVOYANCE_15 = 45;
    public const int IP_CONST_CASTSPELL_CLAIRAUDIENCE_CLAIRVOYANCE_5 = 43;
    public const int IP_CONST_CASTSPELL_CLARITY_3 = 46;
    public const int IP_CONST_CASTSPELL_CLOUDKILL_9 = 48;
    public const int IP_CONST_CASTSPELL_COLOR_SPRAY_2 = 49;
    public const int IP_CONST_CASTSPELL_CONE_OF_COLD_15 = 51;
    public const int IP_CONST_CASTSPELL_CONE_OF_COLD_9 = 50;
    public const int IP_CONST_CASTSPELL_CONFUSION_10 = 53;
    public const int IP_CONST_CASTSPELL_CONFUSION_5 = 52;
    public const int IP_CONST_CASTSPELL_CONTAGION_5 = 54;
    public const int IP_CONST_CASTSPELL_CONTINUAL_FLAME_7 = 350;
    public const int IP_CONST_CASTSPELL_CONTROL_UNDEAD_13 = 55;
    public const int IP_CONST_CASTSPELL_CONTROL_UNDEAD_20 = 56;
    public const int IP_CONST_CASTSPELL_CREATE_GREATER_UNDEAD_15 = 57;
    public const int IP_CONST_CASTSPELL_CREATE_GREATER_UNDEAD_16 = 58;
    public const int IP_CONST_CASTSPELL_CREATE_GREATER_UNDEAD_18 = 59;
    public const int IP_CONST_CASTSPELL_CREATE_UNDEAD_11 = 60;
    public const int IP_CONST_CASTSPELL_CREATE_UNDEAD_14 = 61;
    public const int IP_CONST_CASTSPELL_CREATE_UNDEAD_16 = 62;
    public const int IP_CONST_CASTSPELL_CREEPING_DOOM_13 = 304;
    public const int IP_CONST_CASTSPELL_CURE_CRITICAL_WOUNDS_12 = 64;
    public const int IP_CONST_CASTSPELL_CURE_CRITICAL_WOUNDS_15 = 65;
    public const int IP_CONST_CASTSPELL_CURE_CRITICAL_WOUNDS_7 = 63;
    public const int IP_CONST_CASTSPELL_CURE_LIGHT_WOUNDS_2 = 66;
    public const int IP_CONST_CASTSPELL_CURE_LIGHT_WOUNDS_5 = 67;
    public const int IP_CONST_CASTSPELL_CURE_MINOR_WOUNDS_1 = 68;
    public const int IP_CONST_CASTSPELL_CURE_MODERATE_WOUNDS_10 = 71;
    public const int IP_CONST_CASTSPELL_CURE_MODERATE_WOUNDS_3 = 69;
    public const int IP_CONST_CASTSPELL_CURE_MODERATE_WOUNDS_6 = 70;
    public const int IP_CONST_CASTSPELL_CURE_SERIOUS_WOUNDS_10 = 73;
    public const int IP_CONST_CASTSPELL_CURE_SERIOUS_WOUNDS_5 = 72;
    public const int IP_CONST_CASTSPELL_DARKNESS_3 = 75;
    public const int IP_CONST_CASTSPELL_DARKVISION_3 = 305;
    public const int IP_CONST_CASTSPELL_DARKVISION_6 = 306;
    public const int IP_CONST_CASTSPELL_DAZE_1 = 76;
    public const int IP_CONST_CASTSPELL_DEATH_WARD_7 = 77;
    public const int IP_CONST_CASTSPELL_DELAYED_BLAST_FIREBALL_13 = 78;
    public const int IP_CONST_CASTSPELL_DELAYED_BLAST_FIREBALL_15 = 79;
    public const int IP_CONST_CASTSPELL_DELAYED_BLAST_FIREBALL_20 = 80;
    public const int IP_CONST_CASTSPELL_DESTRUCTION_13 = 307;
    public const int IP_CONST_CASTSPELL_DIRGE_15 = 376;
    public const int IP_CONST_CASTSPELL_DISMISSAL_12 = 82;
    public const int IP_CONST_CASTSPELL_DISMISSAL_18 = 83;
    public const int IP_CONST_CASTSPELL_DISMISSAL_7 = 81;
    public const int IP_CONST_CASTSPELL_DISPEL_MAGIC_10 = 85;
    public const int IP_CONST_CASTSPELL_DISPEL_MAGIC_5 = 84;
    public const int IP_CONST_CASTSPELL_DISPLACEMENT_9 = 389;
    public const int IP_CONST_CASTSPELL_DIVINE_FAVOR_5 = 345;
    public const int IP_CONST_CASTSPELL_DIVINE_MIGHT_5 = 395;
    public const int IP_CONST_CASTSPELL_DIVINE_POWER_7 = 86;
    public const int IP_CONST_CASTSPELL_DIVINE_SHIELD_5 = 396;
    public const int IP_CONST_CASTSPELL_DOMINATE_ANIMAL_5 = 87;
    public const int IP_CONST_CASTSPELL_DOMINATE_MONSTER_17 = 88;
    public const int IP_CONST_CASTSPELL_DOMINATE_PERSON_7 = 89;
    public const int IP_CONST_CASTSPELL_DOOM_2 = 90;
    public const int IP_CONST_CASTSPELL_DOOM_5 = 91;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_ACID_10 = 400;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_COLD_10 = 401;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_FEAR_10 = 402;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_FIRE_10 = 403;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_GAS_10 = 404;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_LIGHTNING_10 = 405;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_PARALYZE_10 = 406;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_SLEEP_10 = 407;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_SLOW_10 = 408;
    public const int IP_CONST_CASTSPELL_DRAGON_BREATH_WEAKEN_10 = 409;
    public const int IP_CONST_CASTSPELL_DROWN_15 = 368;
    public const int IP_CONST_CASTSPELL_EAGLE_SPLEDOR_10 = 289;
    public const int IP_CONST_CASTSPELL_EAGLE_SPLEDOR_15 = 290;
    public const int IP_CONST_CASTSPELL_EAGLE_SPLEDOR_3 = 288;
    public const int IP_CONST_CASTSPELL_EARTHQUAKE_20 = 357;
    public const int IP_CONST_CASTSPELL_ELECTRIC_JOLT_1 = 370;
    public const int IP_CONST_CASTSPELL_ELEMENTAL_SHIELD_12 = 93;
    public const int IP_CONST_CASTSPELL_ELEMENTAL_SHIELD_7 = 92;
    public const int IP_CONST_CASTSPELL_ELEMENTAL_SWARM_17 = 94;
    public const int IP_CONST_CASTSPELL_ENDURANCE_10 = 96;
    public const int IP_CONST_CASTSPELL_ENDURANCE_15 = 97;
    public const int IP_CONST_CASTSPELL_ENDURANCE_3 = 95;
    public const int IP_CONST_CASTSPELL_ENDURE_ELEMENTS_2 = 98;
    public const int IP_CONST_CASTSPELL_ENERGY_BUFFER_11 = 311;
    public const int IP_CONST_CASTSPELL_ENERGY_BUFFER_15 = 312;
    public const int IP_CONST_CASTSPELL_ENERGY_BUFFER_20 = 313;
    public const int IP_CONST_CASTSPELL_ENERGY_DRAIN_17 = 99;
    public const int IP_CONST_CASTSPELL_ENERVATION_7 = 100;
    public const int IP_CONST_CASTSPELL_ENTANGLE_2 = 101;
    public const int IP_CONST_CASTSPELL_ENTANGLE_5 = 102;
    public const int IP_CONST_CASTSPELL_ENTROPIC_SHIELD_5 = 349;
    public const int IP_CONST_CASTSPELL_ETHEREAL_VISAGE_15 = 196;
    public const int IP_CONST_CASTSPELL_ETHEREAL_VISAGE_9 = 195;
    public const int IP_CONST_CASTSPELL_ETHEREALNESS_18 = 374;
    public const int IP_CONST_CASTSPELL_EVARDS_BLACK_TENTACLES_15 = 325;
    public const int IP_CONST_CASTSPELL_EVARDS_BLACK_TENTACLES_7 = 324;
    public const int IP_CONST_CASTSPELL_EXPEDITIOUS_RETREAT_5 = 387;
    public const int IP_CONST_CASTSPELL_FEAR_5 = 103;
    public const int IP_CONST_CASTSPELL_FEEBLEMIND_9 = 104;
    public const int IP_CONST_CASTSPELL_FIND_TRAPS_3 = 327;
    public const int IP_CONST_CASTSPELL_FINGER_OF_DEATH_13 = 105;
    public const int IP_CONST_CASTSPELL_FIRE_STORM_13 = 106;
    public const int IP_CONST_CASTSPELL_FIRE_STORM_18 = 107;
    public const int IP_CONST_CASTSPELL_FIREBALL_10 = 109;
    public const int IP_CONST_CASTSPELL_FIREBALL_5 = 108;
    public const int IP_CONST_CASTSPELL_FIREBRAND_15 = 371;
    public const int IP_CONST_CASTSPELL_FLAME_ARROW_12 = 111;
    public const int IP_CONST_CASTSPELL_FLAME_ARROW_18 = 112;
    public const int IP_CONST_CASTSPELL_FLAME_ARROW_5 = 110;
    public const int IP_CONST_CASTSPELL_FLAME_LASH_10 = 114;
    public const int IP_CONST_CASTSPELL_FLAME_LASH_3 = 113;
    public const int IP_CONST_CASTSPELL_FLAME_STRIKE_12 = 116;
    public const int IP_CONST_CASTSPELL_FLAME_STRIKE_18 = 117;
    public const int IP_CONST_CASTSPELL_FLAME_STRIKE_7 = 115;
    public const int IP_CONST_CASTSPELL_FLARE_1 = 347;
    public const int IP_CONST_CASTSPELL_FLESH_TO_STONE_5 = 398;
    public const int IP_CONST_CASTSPELL_FOXS_CUNNING_10 = 295;
    public const int IP_CONST_CASTSPELL_FOXS_CUNNING_15 = 296;
    public const int IP_CONST_CASTSPELL_FOXS_CUNNING_3 = 294;
    public const int IP_CONST_CASTSPELL_FREEDOM_OF_MOVEMENT_7 = 118;
    public const int IP_CONST_CASTSPELL_GATE_17 = 119;
    public const int IP_CONST_CASTSPELL_GHOSTLY_VISAGE_15 = 194;
    public const int IP_CONST_CASTSPELL_GHOSTLY_VISAGE_3 = 192;
    public const int IP_CONST_CASTSPELL_GHOSTLY_VISAGE_9 = 193;
    public const int IP_CONST_CASTSPELL_GHOUL_TOUCH_3 = 120;
    public const int IP_CONST_CASTSPELL_GLOBE_OF_INVULNERABILITY_11 = 121;
    public const int IP_CONST_CASTSPELL_GREASE_2 = 122;
    public const int IP_CONST_CASTSPELL_GREATER_BULLS_STRENGTH_11 = 300;
    public const int IP_CONST_CASTSPELL_GREATER_CATS_GRACE_11 = 301;
    public const int IP_CONST_CASTSPELL_GREATER_DISPELLING_15 = 124;
    public const int IP_CONST_CASTSPELL_GREATER_DISPELLING_7 = 123;
    public const int IP_CONST_CASTSPELL_GREATER_EAGLES_SPLENDOR_11 = 297;
    public const int IP_CONST_CASTSPELL_GREATER_ENDURANCE_11 = 302;
    public const int IP_CONST_CASTSPELL_GREATER_FOXS_CUNNING_11 = 299;
    public const int IP_CONST_CASTSPELL_GREATER_MAGIC_FANG_9 = 384;
    public const int IP_CONST_CASTSPELL_GREATER_OWLS_WISDOM_11 = 298;
    public const int IP_CONST_CASTSPELL_GREATER_PLANAR_BINDING_15 = 126;
    public const int IP_CONST_CASTSPELL_GREATER_RESTORATION_13 = 127;
    public const int IP_CONST_CASTSPELL_GREATER_SHADOW_CONJURATION_9 = 128;
    public const int IP_CONST_CASTSPELL_GREATER_SPELL_BREACH_11 = 129;
    public const int IP_CONST_CASTSPELL_GREATER_SPELL_MANTLE_17 = 130;
    public const int IP_CONST_CASTSPELL_GREATER_STONESKIN_11 = 131;
    public const int IP_CONST_CASTSPELL_GRENADE_ACID_1 = 341;
    public const int IP_CONST_CASTSPELL_GRENADE_CALTROPS_1 = 343;
    public const int IP_CONST_CASTSPELL_GRENADE_CHICKEN_1 = 342;
    public const int IP_CONST_CASTSPELL_GRENADE_CHOKING_1 = 339;
    public const int IP_CONST_CASTSPELL_GRENADE_FIRE_1 = 336;
    public const int IP_CONST_CASTSPELL_GRENADE_HOLY_1 = 338;
    public const int IP_CONST_CASTSPELL_GRENADE_TANGLE_1 = 337;
    public const int IP_CONST_CASTSPELL_GRENADE_THUNDERSTONE_1 = 340;
    public const int IP_CONST_CASTSPELL_GUST_OF_WIND_10 = 410;
    public const int IP_CONST_CASTSPELL_HAMMER_OF_THE_GODS_12 = 134;
    public const int IP_CONST_CASTSPELL_HAMMER_OF_THE_GODS_7 = 133;
    public const int IP_CONST_CASTSPELL_HARM_11 = 136;
    public const int IP_CONST_CASTSPELL_HASTE_10 = 138;
    public const int IP_CONST_CASTSPELL_HASTE_5 = 137;
    public const int IP_CONST_CASTSPELL_HEAL_11 = 139;
    public const int IP_CONST_CASTSPELL_HEALING_CIRCLE_16 = 141;
    public const int IP_CONST_CASTSPELL_HEALING_CIRCLE_9 = 140;
    public const int IP_CONST_CASTSPELL_HOLD_ANIMAL_3 = 142;
    public const int IP_CONST_CASTSPELL_HOLD_MONSTER_7 = 143;
    public const int IP_CONST_CASTSPELL_HOLD_PERSON_3 = 144;
    public const int IP_CONST_CASTSPELL_HORRID_WILTING_15 = 308;
    public const int IP_CONST_CASTSPELL_HORRID_WILTING_20 = 309;
    public const int IP_CONST_CASTSPELL_ICE_STORM_9 = 310;
    public const int IP_CONST_CASTSPELL_IDENTIFY_3 = 147;
    public const int IP_CONST_CASTSPELL_IMPLOSION_17 = 148;
    public const int IP_CONST_CASTSPELL_IMPROVED_INVISIBILITY_7 = 149;
    public const int IP_CONST_CASTSPELL_INCENDIARY_CLOUD_15 = 150;
    public const int IP_CONST_CASTSPELL_INFERNO_15 = 377;
    public const int IP_CONST_CASTSPELL_INFLICT_CRITICAL_WOUNDS_12 = 366;
    public const int IP_CONST_CASTSPELL_INFLICT_LIGHT_WOUNDS_5 = 363;
    public const int IP_CONST_CASTSPELL_INFLICT_MINOR_WOUNDS_1 = 362;
    public const int IP_CONST_CASTSPELL_INFLICT_MODERATE_WOUNDS_7 = 364;
    public const int IP_CONST_CASTSPELL_INFLICT_SERIOUS_WOUNDS_9 = 365;
    public const int IP_CONST_CASTSPELL_INVISIBILITY_3 = 151;
    public const int IP_CONST_CASTSPELL_INVISIBILITY_PURGE_5 = 152;
    public const int IP_CONST_CASTSPELL_INVISIBILITY_SPHERE_5 = 153;
    public const int IP_CONST_CASTSPELL_ISAACS_GREATER_MISSILE_STORM_15 = 379;
    public const int IP_CONST_CASTSPELL_ISAACS_LESSER_MISSILE_STORM_13 = 378;
    public const int IP_CONST_CASTSPELL_KNOCK_3 = 154;
    public const int IP_CONST_CASTSPELL_LEGEND_LORE_5 = 326;
    public const int IP_CONST_CASTSPELL_LESSER_DISPEL_3 = 155;
    public const int IP_CONST_CASTSPELL_LESSER_DISPEL_5 = 156;
    public const int IP_CONST_CASTSPELL_LESSER_MIND_BLANK_9 = 157;
    public const int IP_CONST_CASTSPELL_LESSER_PLANAR_BINDING_9 = 158;
    public const int IP_CONST_CASTSPELL_LESSER_RESTORATION_3 = 159;
    public const int IP_CONST_CASTSPELL_LESSER_SPELL_BREACH_7 = 160;
    public const int IP_CONST_CASTSPELL_LESSER_SPELL_MANTLE_9 = 161;
    public const int IP_CONST_CASTSPELL_LIGHT_1 = 162;
    public const int IP_CONST_CASTSPELL_LIGHT_5 = 163;
    public const int IP_CONST_CASTSPELL_LIGHTNING_BOLT_10 = 165;
    public const int IP_CONST_CASTSPELL_LIGHTNING_BOLT_5 = 164;
    public const int IP_CONST_CASTSPELL_MAGE_ARMOR_2 = 167;
    public const int IP_CONST_CASTSPELL_MAGIC_CIRCLE_AGAINST_ALIGNMENT_5 = 286;
    public const int IP_CONST_CASTSPELL_MAGIC_FANG_5 = 383;
    public const int IP_CONST_CASTSPELL_MAGIC_MISSILE_3 = 172;
    public const int IP_CONST_CASTSPELL_MAGIC_MISSILE_5 = 173;
    public const int IP_CONST_CASTSPELL_MAGIC_MISSILE_9 = 174;
    public const int IP_CONST_CASTSPELL_MANIPULATE_PORTAL_STONE = 344;
    public const int IP_CONST_CASTSPELL_MASS_BLINDNESS_DEAFNESS_15 = 179;
    public const int IP_CONST_CASTSPELL_MASS_CAMOFLAGE_13 = 386;
    public const int IP_CONST_CASTSPELL_MASS_CHARM_15 = 180;
    public const int IP_CONST_CASTSPELL_MASS_HASTE_11 = 182;
    public const int IP_CONST_CASTSPELL_MASS_HEAL_15 = 183;
    public const int IP_CONST_CASTSPELL_MELFS_ACID_ARROW_3 = 184;
    public const int IP_CONST_CASTSPELL_MELFS_ACID_ARROW_6 = 185;
    public const int IP_CONST_CASTSPELL_MELFS_ACID_ARROW_9 = 186;
    public const int IP_CONST_CASTSPELL_METEOR_SWARM_17 = 187;
    public const int IP_CONST_CASTSPELL_MIND_BLANK_15 = 188;
    public const int IP_CONST_CASTSPELL_MIND_FOG_9 = 189;
    public const int IP_CONST_CASTSPELL_MINOR_GLOBE_OF_INVULNERABILITY_15 = 191;
    public const int IP_CONST_CASTSPELL_MINOR_GLOBE_OF_INVULNERABILITY_7 = 190;
    public const int IP_CONST_CASTSPELL_MORDENKAINENS_DISJUNCTION_17 = 197;
    public const int IP_CONST_CASTSPELL_MORDENKAINENS_SWORD_13 = 198;
    public const int IP_CONST_CASTSPELL_MORDENKAINENS_SWORD_18 = 199;
    public const int IP_CONST_CASTSPELL_NATURES_BALANCE_15 = 200;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_BURST_10 = 315;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_BURST_5 = 314;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_PROTECTION_10 = 202;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_PROTECTION_15 = 203;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_PROTECTION_5 = 201;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_RAY_1 = 316;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_RAY_3 = 317;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_RAY_5 = 318;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_RAY_7 = 319;
    public const int IP_CONST_CASTSPELL_NEGATIVE_ENERGY_RAY_9 = 320;
    public const int IP_CONST_CASTSPELL_NEUTRALIZE_POISON_5 = 204;
    public const int IP_CONST_CASTSPELL_ONE_WITH_THE_LAND_7 = 351;
    public const int IP_CONST_CASTSPELL_OWLS_INSIGHT_15 = 369;
    public const int IP_CONST_CASTSPELL_OWLS_WISDOM_10 = 292;
    public const int IP_CONST_CASTSPELL_OWLS_WISDOM_15 = 293;
    public const int IP_CONST_CASTSPELL_OWLS_WISDOM_3 = 291;
    public const int IP_CONST_CASTSPELL_PHANTASMAL_KILLER_7 = 205;
    public const int IP_CONST_CASTSPELL_PLANAR_ALLY_15 = 382;
    public const int IP_CONST_CASTSPELL_PLANAR_BINDING_11 = 206;
    public const int IP_CONST_CASTSPELL_POISON_5 = 207;
    public const int IP_CONST_CASTSPELL_POLYMORPH_SELF_7 = 208;
    public const int IP_CONST_CASTSPELL_POWER_WORD_KILL_17 = 209;
    public const int IP_CONST_CASTSPELL_POWER_WORD_STUN_13 = 210;
    public const int IP_CONST_CASTSPELL_PRAYER_5 = 211;
    public const int IP_CONST_CASTSPELL_PREMONITION_15 = 212;
    public const int IP_CONST_CASTSPELL_PRISMATIC_SPRAY_13 = 213;
    public const int IP_CONST_CASTSPELL_PROTECTION_FROM_ALIGNMENT_2 = 284;
    public const int IP_CONST_CASTSPELL_PROTECTION_FROM_ALIGNMENT_5 = 285;
    public const int IP_CONST_CASTSPELL_PROTECTION_FROM_ELEMENTS_10 = 217;
    public const int IP_CONST_CASTSPELL_PROTECTION_FROM_ELEMENTS_3 = 216;
    public const int IP_CONST_CASTSPELL_PROTECTION_FROM_SPELLS_13 = 224;
    public const int IP_CONST_CASTSPELL_PROTECTION_FROM_SPELLS_20 = 225;
    public const int IP_CONST_CASTSPELL_QUILLFIRE_8 = 356;
    public const int IP_CONST_CASTSPELL_RAISE_DEAD_9 = 226;
    public const int IP_CONST_CASTSPELL_RAY_OF_ENFEEBLEMENT_2 = 227;
    public const int IP_CONST_CASTSPELL_RAY_OF_FROST_1 = 228;
    public const int IP_CONST_CASTSPELL_REGENERATE_13 = 323;
    public const int IP_CONST_CASTSPELL_REMOVE_BLINDNESS_DEAFNESS_5 = 229;
    public const int IP_CONST_CASTSPELL_REMOVE_CURSE_5 = 230;
    public const int IP_CONST_CASTSPELL_REMOVE_DISEASE_5 = 231;
    public const int IP_CONST_CASTSPELL_REMOVE_FEAR_2 = 232;
    public const int IP_CONST_CASTSPELL_REMOVE_PARALYSIS_3 = 233;
    public const int IP_CONST_CASTSPELL_RESIST_ELEMENTS_10 = 235;
    public const int IP_CONST_CASTSPELL_RESIST_ELEMENTS_3 = 234;
    public const int IP_CONST_CASTSPELL_RESISTANCE_2 = 236;
    public const int IP_CONST_CASTSPELL_RESISTANCE_5 = 237;
    public const int IP_CONST_CASTSPELL_RESTORATION_7 = 238;
    public const int IP_CONST_CASTSPELL_RESURRECTION_13 = 239;
    public const int IP_CONST_CASTSPELL_ROGUES_CUNNING_3 = 328;
    public const int IP_CONST_CASTSPELL_SANCTUARY_2 = 240;
    public const int IP_CONST_CASTSPELL_SCARE_2 = 241;
    public const int IP_CONST_CASTSPELL_SEARING_LIGHT_5 = 242;
    public const int IP_CONST_CASTSPELL_SEE_INVISIBILITY_3 = 243;
    public const int IP_CONST_CASTSPELL_SHADES_11 = 244;
    public const int IP_CONST_CASTSPELL_SHADOW_CONJURATION_7 = 245;
    public const int IP_CONST_CASTSPELL_SHADOW_SHIELD_13 = 246;
    public const int IP_CONST_CASTSPELL_SHAPECHANGE_17 = 247;
    public const int IP_CONST_CASTSPELL_SHIELD_5 = 348;
    public const int IP_CONST_CASTSPELL_SHIELD_OF_FAITH_5 = 381;
    public const int IP_CONST_CASTSPELL_SILENCE_3 = 249;
    public const int IP_CONST_CASTSPELL_SLAY_LIVING_9 = 250;
    public const int IP_CONST_CASTSPELL_SLEEP_2 = 251;
    public const int IP_CONST_CASTSPELL_SLEEP_5 = 252;
    public const int IP_CONST_CASTSPELL_SLOW_5 = 253;
    public const int IP_CONST_CASTSPELL_SOUND_BURST_3 = 254;
    public const int IP_CONST_CASTSPELL_SPECIAL_ALCOHOL_BEER = 330;
    public const int IP_CONST_CASTSPELL_SPECIAL_ALCOHOL_SPIRITS = 332;
    public const int IP_CONST_CASTSPELL_SPECIAL_ALCOHOL_WINE = 331;
    public const int IP_CONST_CASTSPELL_SPECIAL_HERB_BELLADONNA = 333;
    public const int IP_CONST_CASTSPELL_SPECIAL_HERB_GARLIC = 334;
    public const int IP_CONST_CASTSPELL_SPELL_MANTLE_13 = 257;
    public const int IP_CONST_CASTSPELL_SPELL_RESISTANCE_15 = 256;
    public const int IP_CONST_CASTSPELL_SPELL_RESISTANCE_9 = 255;
    public const int IP_CONST_CASTSPELL_SPIKE_GROWTH_9 = 385;
    public const int IP_CONST_CASTSPELL_STINKING_CLOUD_5 = 259;
    public const int IP_CONST_CASTSPELL_STONE_TO_FLESH_5 = 399;
    public const int IP_CONST_CASTSPELL_STONESKIN_7 = 260;
    public const int IP_CONST_CASTSPELL_STORM_OF_VENGEANCE_17 = 261;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_I_2 = 262;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_I_5 = 263;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_II_3 = 264;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_III_5 = 265;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_IV_7 = 266;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_IX_17 = 267;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_V_9 = 268;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_VI_11 = 269;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_VII_13 = 270;
    public const int IP_CONST_CASTSPELL_SUMMON_CREATURE_VIII_15 = 271;
    public const int IP_CONST_CASTSPELL_SUNBEAM_13 = 272;
    public const int IP_CONST_CASTSPELL_SUNBURST_20 = 358;
    public const int IP_CONST_CASTSPELL_TASHAS_HIDEOUS_LAUGHTER_7 = 388;
    public const int IP_CONST_CASTSPELL_TENSERS_TRANSFORMATION_11 = 273;
    public const int IP_CONST_CASTSPELL_TIME_STOP_17 = 274;
    public const int IP_CONST_CASTSPELL_TRUE_SEEING_9 = 275;
    public const int IP_CONST_CASTSPELL_TRUE_STRIKE_5 = 346;
    public const int IP_CONST_CASTSPELL_UNDEATHS_ETERNAL_FOE_20 = 375;
    public const int IP_CONST_CASTSPELL_UNIQUE_POWER = 329;
    public const int IP_CONST_CASTSPELL_UNIQUE_POWER_SELF_ONLY = 335;
    public const int IP_CONST_CASTSPELL_VAMPIRIC_TOUCH_5 = 277;
    public const int IP_CONST_CASTSPELL_VIRTUE_1 = 278;
    public const int IP_CONST_CASTSPELL_WAIL_OF_THE_BANSHEE_17 = 279;
    public const int IP_CONST_CASTSPELL_WALL_OF_FIRE_9 = 280;
    public const int IP_CONST_CASTSPELL_WAR_CRY_7 = 322;
    public const int IP_CONST_CASTSPELL_WEB_3 = 281;
    public const int IP_CONST_CASTSPELL_WEIRD_17 = 282;
    public const int IP_CONST_CASTSPELL_WORD_OF_FAITH_13 = 283;
    public const int IP_CONST_CASTSPELL_WOUNDING_WHISPERS_9 = 372;
    public const int IP_CONST_SPELLSCHOOL_ABJURATION = 0;
    public const int IP_CONST_SPELLSCHOOL_CONJURATION = 1;
    public const int IP_CONST_SPELLSCHOOL_DIVINATION = 2;
    public const int IP_CONST_SPELLSCHOOL_ENCHANTMENT = 3;
    public const int IP_CONST_SPELLSCHOOL_EVOCATION = 4;
    public const int IP_CONST_SPELLSCHOOL_ILLUSION = 5;
    public const int IP_CONST_SPELLSCHOOL_NECROMANCY = 6;
    public const int IP_CONST_SPELLSCHOOL_TRANSMUTATION = 7;
    public const int IP_CONST_SPELLRESISTANCEBONUS_10 = 0;
    public const int IP_CONST_SPELLRESISTANCEBONUS_12 = 1;
    public const int IP_CONST_SPELLRESISTANCEBONUS_14 = 2;
    public const int IP_CONST_SPELLRESISTANCEBONUS_16 = 3;
    public const int IP_CONST_SPELLRESISTANCEBONUS_18 = 4;
    public const int IP_CONST_SPELLRESISTANCEBONUS_20 = 5;
    public const int IP_CONST_SPELLRESISTANCEBONUS_22 = 6;
    public const int IP_CONST_SPELLRESISTANCEBONUS_24 = 7;
    public const int IP_CONST_SPELLRESISTANCEBONUS_26 = 8;
    public const int IP_CONST_SPELLRESISTANCEBONUS_28 = 9;
    public const int IP_CONST_SPELLRESISTANCEBONUS_30 = 10;
    public const int IP_CONST_SPELLRESISTANCEBONUS_32 = 11;
    public const int IP_CONST_TRAPTYPE_SPIKE = 1;
    public const int IP_CONST_TRAPTYPE_HOLY = 2;
    public const int IP_CONST_TRAPTYPE_TANGLE = 3;
    public const int IP_CONST_TRAPTYPE_BLOBOFACID = 4;
    public const int IP_CONST_TRAPTYPE_FIRE = 5;
    public const int IP_CONST_TRAPTYPE_ELECTRICAL = 6;
    public const int IP_CONST_TRAPTYPE_GAS = 7;
    public const int IP_CONST_TRAPTYPE_FROST = 8;
    public const int IP_CONST_TRAPTYPE_ACID_SPLASH = 9;
    public const int IP_CONST_TRAPTYPE_SONIC = 10;
    public const int IP_CONST_TRAPTYPE_NEGATIVE = 11;
    public const int IP_CONST_TRAPSTRENGTH_MINOR = 0;
    public const int IP_CONST_TRAPSTRENGTH_AVERAGE = 1;
    public const int IP_CONST_TRAPSTRENGTH_STRONG = 2;
    public const int IP_CONST_TRAPSTRENGTH_DEADLY = 3;
    public const int IP_CONST_REDUCEDWEIGHT_80_PERCENT = 1;
    public const int IP_CONST_REDUCEDWEIGHT_60_PERCENT = 2;
    public const int IP_CONST_REDUCEDWEIGHT_40_PERCENT = 3;
    public const int IP_CONST_REDUCEDWEIGHT_20_PERCENT = 4;
    public const int IP_CONST_REDUCEDWEIGHT_10_PERCENT = 5;
    public const int IP_CONST_WEIGHTINCREASE_5_LBS = 0;
    public const int IP_CONST_WEIGHTINCREASE_10_LBS = 1;
    public const int IP_CONST_WEIGHTINCREASE_15_LBS = 2;
    public const int IP_CONST_WEIGHTINCREASE_30_LBS = 3;
    public const int IP_CONST_WEIGHTINCREASE_50_LBS = 4;
    public const int IP_CONST_WEIGHTINCREASE_100_LBS = 5;
    public const int IP_CONST_CLASS_BARBARIAN = 0;
    public const int IP_CONST_CLASS_BARD = 1;
    public const int IP_CONST_CLASS_CLERIC = 2;
    public const int IP_CONST_CLASS_DRUID = 3;
    public const int IP_CONST_CLASS_FIGHTER = 4;
    public const int IP_CONST_CLASS_MONK = 5;
    public const int IP_CONST_CLASS_PALADIN = 6;
    public const int IP_CONST_CLASS_RANGER = 7;
    public const int IP_CONST_CLASS_ROGUE = 8;
    public const int IP_CONST_CLASS_SORCERER = 9;
    public const int IP_CONST_CLASS_WIZARD = 10;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_50_PERCENT = 0;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_45_PERCENT = 1;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_40_PERCENT = 2;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_35_PERCENT = 3;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_30_PERCENT = 4;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_25_PERCENT = 5;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_20_PERCENT = 6;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_15_PERCENT = 7;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_10_PERCENT = 8;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_MINUS_5_PERCENT = 9;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_5_PERCENT = 10;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_10_PERCENT = 11;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_15_PERCENT = 12;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_20_PERCENT = 13;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_25_PERCENT = 14;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_30_PERCENT = 15;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_35_PERCENT = 16;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_40_PERCENT = 17;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_45_PERCENT = 18;
    public const int IP_CONST_ARCANE_SPELL_FAILURE_PLUS_50_PERCENT = 19;
    public const int ACTION_MODE_DETECT = 0;
    public const int ACTION_MODE_STEALTH = 1;
    public const int ACTION_MODE_PARRY = 2;
    public const int ACTION_MODE_POWER_ATTACK = 3;
    public const int ACTION_MODE_IMPROVED_POWER_ATTACK = 4;
    public const int ACTION_MODE_COUNTERSPELL = 5;
    public const int ACTION_MODE_FLURRY_OF_BLOWS = 6;
    public const int ACTION_MODE_RAPID_SHOT = 7;
    public const int ACTION_MODE_EXPERTISE = 8;
    public const int ACTION_MODE_IMPROVED_EXPERTISE = 9;
    public const int ACTION_MODE_DEFENSIVE_CAST = 10;
    public const int ACTION_MODE_DIRTY_FIGHTING = 11;
    public const int ITEM_VISUAL_ACID = 0;
    public const int ITEM_VISUAL_COLD = 1;
    public const int ITEM_VISUAL_ELECTRICAL = 2;
    public const int ITEM_VISUAL_FIRE = 3;
    public const int ITEM_VISUAL_SONIC = 4;
    public const int ITEM_VISUAL_HOLY = 5;
    public const int ITEM_VISUAL_EVIL = 6;

    ///  these constants must match those in the skyboxes.2da
    public const int SKYBOX_NONE = 0;
    public const int SKYBOX_GRASS_CLEAR = 1;
    public const int SKYBOX_GRASS_STORM = 2;
    public const int SKYBOX_DESERT_CLEAR = 3;
    public const int SKYBOX_WINTER_CLEAR = 4;
    public const int SKYBOX_ICY = 5;
    public const int FOG_TYPE_ALL = 0;
    public const int FOG_TYPE_SUN = 1;
    public const int FOG_TYPE_MOON = 2;
    public const int FOG_COLOR_RED = 16711680;
    public const int FOG_COLOR_RED_DARK = 6684672;
    public const int FOG_COLOR_GREEN = 65280;
    public const int FOG_COLOR_GREEN_DARK = 23112;
    public const int FOG_COLOR_BLUE = 255;
    public const int FOG_COLOR_BLUE_DARK = 102;
    public const int FOG_COLOR_BLACK = 0;
    public const int FOG_COLOR_WHITE = 16777215;
    public const int FOG_COLOR_GREY = 10066329;
    public const int FOG_COLOR_YELLOW = 16776960;
    public const int FOG_COLOR_YELLOW_DARK = 11184640;
    public const int FOG_COLOR_CYAN = 65535;
    public const int FOG_COLOR_MAGENTA = 16711935;
    public const int FOG_COLOR_ORANGE = 16750848;
    public const int FOG_COLOR_ORANGE_DARK = 13395456;
    public const int FOG_COLOR_BROWN = 10053120;
    public const int FOG_COLOR_BROWN_DARK = 6697728;

    ///  these constants must match those in the AmbientSound.2da
    public const int AMBIENT_SOUND_NONE = 0;
    public const int AMBIENT_SOUND_MEN_WHISPER_INSIDE = 1;
    public const int AMBIENT_SOUND_WOMEN_WHISPER_INSIDE = 2;
    public const int AMBIENT_SOUND_PEOPLE_WHISPER_INSIDE = 3;
    public const int AMBIENT_SOUND_SMALL_GROUP_TALKS_INSIDE = 4;
    public const int AMBIENT_SOUND_MEDIUM_GROUP_TALKS_INSIDE = 5;
    public const int AMBIENT_SOUND_LARGE_GROUP_TALKS_INSIDE = 6;
    public const int AMBIENT_SOUND_COMMONER_TAVERN_TALK = 7;
    public const int AMBIENT_SOUND_NOBLE_TAVERN_TALK = 8;
    public const int AMBIENT_SOUND_CITY_SLUMS_DAY_CROWDED = 9;
    public const int AMBIENT_SOUND_CITY_SLUMS_DAY_SPARSE = 10;
    public const int AMBIENT_SOUND_CITY_SLUMS_NIGHT = 11;
    public const int AMBIENT_SOUND_CITY_DAY_CROWDED = 12;
    public const int AMBIENT_SOUND_CITY_DAY_SPARSE = 13;
    public const int AMBIENT_SOUND_CITY_NIGHT = 14;
    public const int AMBIENT_SOUND_CITY_MARKET = 15;
    public const int AMBIENT_SOUND_CITY_TEMPLE_DISTRICT = 16;
    public const int AMBIENT_SOUND_TOWN_DAY_CROWDED = 17;
    public const int AMBIENT_SOUND_TOWN_DAY_SPARSE = 18;
    public const int AMBIENT_SOUND_TOWN_NIGHT = 19;
    public const int AMBIENT_SOUND_BORDELLO_WOMEN = 20;
    public const int AMBIENT_SOUND_BORDELLO_MEN_AND_WOMEN = 21;
    public const int AMBIENT_SOUND_RIOT_OUTSIDE = 22;
    public const int AMBIENT_SOUND_RIOT_MUFFLED = 23;
    public const int AMBIENT_SOUND_COMBAT_OUTSIDE_1 = 24;
    public const int AMBIENT_SOUND_COMBAT_OUTSIDE_2 = 25;
    public const int AMBIENT_SOUND_COMBAT_MUFFLED_1 = 26;
    public const int AMBIENT_SOUND_COMBAT_MUFFLED_2 = 27;
    public const int AMBIENT_SOUND_DUNGEON_LAKE_LAVA = 28;
    public const int AMBIENT_SOUND_SEWER_SLUDGE_LAKE = 29;
    public const int AMBIENT_SOUND_WIND_SOFT = 30;
    public const int AMBIENT_SOUND_WIND_MEDIUM = 31;
    public const int AMBIENT_SOUND_WIND_STRONG = 32;
    public const int AMBIENT_SOUND_WIND_FOREST = 33;
    public const int AMBIENT_SOUND_GUST_CHASM = 34;
    public const int AMBIENT_SOUND_GUST_CAVERN = 35;
    public const int AMBIENT_SOUND_GUST_GRASS = 36;
    public const int AMBIENT_SOUND_GUST_DRAFT = 37;
    public const int AMBIENT_SOUND_RAIN_LIGHT = 38;
    public const int AMBIENT_SOUND_RAIN_HARD = 39;
    public const int AMBIENT_SOUND_RAIN_STORM_SMALL = 40;
    public const int AMBIENT_SOUND_RAIN_STORM_BIG = 41;
    public const int AMBIENT_SOUND_CAVE_INSECTS_1 = 42;
    public const int AMBIENT_SOUND_CAVE_INSECTS_2 = 43;
    public const int AMBIENT_SOUND_INTERIOR_INSECTS_1 = 44;
    public const int AMBIENT_SOUND_INTERIOR_INSECTS_2 = 45;
    public const int AMBIENT_SOUND_LIZARD_FOLK_CAVE_CRYSTALS = 46;
    public const int AMBIENT_SOUND_SEWERS_1 = 47;
    public const int AMBIENT_SOUND_SEWERS_2 = 48;
    public const int AMBIENT_SOUND_FOREST_DAY_1 = 49;
    public const int AMBIENT_SOUND_FOREST_DAY_2 = 50;
    public const int AMBIENT_SOUND_FOREST_DAY_3 = 51;
    public const int AMBIENT_SOUND_FOREST_DAY_SCARY = 52;
    public const int AMBIENT_SOUND_FOREST_NIGHT_1 = 53;
    public const int AMBIENT_SOUND_FOREST_NIGHT_2 = 54;
    public const int AMBIENT_SOUND_FOREST_NIGHT_SCARY = 55;
    public const int AMBIENT_SOUND_FOREST_MAGICAL = 56;
    public const int AMBIENT_SOUND_EVIL_DUNGEON_SMALL = 57;
    public const int AMBIENT_SOUND_EVIL_DUNGEON_MEDIUM = 58;
    public const int AMBIENT_SOUND_EVIL_DUNGEON_LARGE = 59;
    public const int AMBIENT_SOUND_CAVE_SMALL = 60;
    public const int AMBIENT_SOUND_CAVE_MEDIUM = 61;
    public const int AMBIENT_SOUND_CAVE_LARGE = 62;
    public const int AMBIENT_SOUND_MINE_SMALL = 63;
    public const int AMBIENT_SOUND_MINE_MEDIUM = 64;
    public const int AMBIENT_SOUND_MINE_LARGE = 65;
    public const int AMBIENT_SOUND_CASTLE_INTERIOR_SMALL = 66;
    public const int AMBIENT_SOUND_CASTLE_INTERIOR_MEDIUM = 67;
    public const int AMBIENT_SOUND_CASTLE_INTERIOR_LARGE = 68;
    public const int AMBIENT_SOUND_CRYPT_SMALL = 69;
    public const int AMBIENT_SOUND_CRYPT_MEDIUM_1 = 70;
    public const int AMBIENT_SOUND_CRYPT_MEDIUM_2 = 71;
    public const int AMBIENT_SOUND_HOUSE_INTERIOR_1 = 72;
    public const int AMBIENT_SOUND_HOUSE_INTERIOR_2 = 73;
    public const int AMBIENT_SOUND_HOUSE_INTERIOR_3 = 74;
    public const int AMBIENT_SOUND_KITCHEN_INTERIOR_SMALL = 75;
    public const int AMBIENT_SOUND_KITCHEN_INTERIOR_LARGE = 76;
    public const int AMBIENT_SOUND_HAUNTED_INTERIOR_1 = 77;
    public const int AMBIENT_SOUND_HAUNTED_INTERIOR_2 = 78;
    public const int AMBIENT_SOUND_HAUNTED_INTERIOR_3 = 79;
    public const int AMBIENT_SOUND_BLACK_SMITH = 80;
    public const int AMBIENT_SOUND_PIT_CRIES = 81;
    public const int AMBIENT_SOUND_MAGIC_INTERIOR_SMALL = 82;
    public const int AMBIENT_SOUND_MAGIC_INTERIOR_MEDIUM = 83;
    public const int AMBIENT_SOUND_MAGIC_INTERIOR_LARGE = 84;
    public const int AMBIENT_SOUND_MAGIC_INTERIOR_EVIL = 85;
    public const int AMBIENT_SOUND_MAGICAL_INTERIOR_FIRELAB = 86;
    public const int AMBIENT_SOUND_MAGICAL_INTERIOR_EARTHLAB = 87;
    public const int AMBIENT_SOUND_MAGICAL_INTERIOR_AIRLAB = 88;
    public const int AMBIENT_SOUND_MAGICAL_INTERIOR_WATERLAB = 89;
    public const int AMBIENT_SOUND_WINTER_DAY_WET_XP1 = 90;
    public const int AMBIENT_SOUND_WINTER_DAY_WINDY_XP1 = 91;
    public const int AMBIENT_SOUND_DESERT_DAY_XP1 = 92;
    public const int AMBIENT_SOUND_DESERT_NIGHT_XP1 = 93;
    public const int AMBIENT_SOUND_MONASTERY_INTERIOR_XP1 = 94;
    public const int AMBIENT_SOUND_RUIN_WET_XP1 = 96;
    public const int AMBIENT_SOUND_RUIN_RUMBLING_XP1 = 97;
    public const int AMBIENT_SOUND_RUIN_HAUNTED_XP1 = 98;
    public const int AMBIENT_SOUND_SAND_STORM_LIGHT_XP1 = 99;
    public const int AMBIENT_SOUND_SAND_STORM_EXTREME_XP1 = 100;
    public const int AMBIENT_SOUND_EVIL_DRONE_XP2 = 101;
    public const int AMBIENT_SOUND_PLAIN_OF_FIRE_XP2 = 102;
    public const int AMBIENT_SOUND_FROZEN_HELL_XP2 = 103;
    public const int AMBIENT_SOUND_CAVE_EVIL_1_XP2 = 104;
    public const int AMBIENT_SOUND_CAVE_EVIL_2_XP2 = 105;
    public const int AMBIENT_SOUND_CAVE_EVIL_3_XP2 = 106;
    public const int AMBIENT_SOUND_TAVERN_ROWDY = 107;

    ///  these constants must match those in the FootstepSounds.2da
    public const int FOOTSTEP_TYPE_INVALID = -1;
    public const int FOOTSTEP_TYPE_NORMAL = 0;
    public const int FOOTSTEP_TYPE_LARGE = 1;
    public const int FOOTSTEP_TYPE_DRAGON = 2;
    public const int FOOTSTEP_TYPE_SOFT = 3;
    public const int FOOTSTEP_TYPE_HOOF = 4;
    public const int FOOTSTEP_TYPE_HOOF_LARGE = 5;
    public const int FOOTSTEP_TYPE_BEETLE = 6;
    public const int FOOTSTEP_TYPE_SPIDER = 7;
    public const int FOOTSTEP_TYPE_SKELETON = 8;
    public const int FOOTSTEP_TYPE_LEATHER_WING = 9;
    public const int FOOTSTEP_TYPE_FEATHER_WING = 10;

    /// int FOOTSTEP_TYPE_LIZARD                      = 11; // Was not ever used/fully implemented.
    public const int FOOTSTEP_TYPE_NONE = 12;
    public const int FOOTSTEP_TYPE_SEAGULL = 13;
    public const int FOOTSTEP_TYPE_SHARK = 14;
    public const int FOOTSTEP_TYPE_WATER_NORMAL = 15;
    public const int FOOTSTEP_TYPE_WATER_LARGE = 16;
    public const int FOOTSTEP_TYPE_HORSE = 17;
    public const int FOOTSTEP_TYPE_DEFAULT = 65535;

    ///  these constants must match those in the WingModel.2da
    public const int CREATURE_WING_TYPE_NONE = 0;
    public const int CREATURE_WING_TYPE_DEMON = 1;
    public const int CREATURE_WING_TYPE_ANGEL = 2;
    public const int CREATURE_WING_TYPE_BAT = 3;
    public const int CREATURE_WING_TYPE_DRAGON = 4;
    public const int CREATURE_WING_TYPE_BUTTERFLY = 5;
    public const int CREATURE_WING_TYPE_BIRD = 6;

    ///  these constants must match those in the TailModel.2da
    public const int CREATURE_TAIL_TYPE_NONE = 0;
    public const int CREATURE_TAIL_TYPE_LIZARD = 1;
    public const int CREATURE_TAIL_TYPE_BONE = 2;
    public const int CREATURE_TAIL_TYPE_DEVIL = 3;

    ///  these constants must match those in the CAPart.2da
    public const int CREATURE_PART_RIGHT_FOOT = 0;
    public const int CREATURE_PART_LEFT_FOOT = 1;
    public const int CREATURE_PART_RIGHT_SHIN = 2;
    public const int CREATURE_PART_LEFT_SHIN = 3;
    public const int CREATURE_PART_LEFT_THIGH = 4;
    public const int CREATURE_PART_RIGHT_THIGH = 5;
    public const int CREATURE_PART_PELVIS = 6;
    public const int CREATURE_PART_TORSO = 7;
    public const int CREATURE_PART_BELT = 8;
    public const int CREATURE_PART_NECK = 9;
    public const int CREATURE_PART_RIGHT_FOREARM = 10;
    public const int CREATURE_PART_LEFT_FOREARM = 11;
    public const int CREATURE_PART_RIGHT_BICEP = 12;
    public const int CREATURE_PART_LEFT_BICEP = 13;
    public const int CREATURE_PART_RIGHT_SHOULDER = 14;
    public const int CREATURE_PART_LEFT_SHOULDER = 15;
    public const int CREATURE_PART_RIGHT_HAND = 16;
    public const int CREATURE_PART_LEFT_HAND = 17;
    public const int CREATURE_PART_HEAD = 20;
    public const int CREATURE_MODEL_TYPE_NONE = 0;
    public const int CREATURE_MODEL_TYPE_SKIN = 1;
    public const int CREATURE_MODEL_TYPE_TATTOO = 2;
    public const int CREATURE_MODEL_TYPE_UNDEAD = 255;
    public const int COLOR_CHANNEL_SKIN = 0;
    public const int COLOR_CHANNEL_HAIR = 1;
    public const int COLOR_CHANNEL_TATTOO_1 = 2;
    public const int COLOR_CHANNEL_TATTOO_2 = 3;

    ///  The following resrefs must match those in the tileset&amp;apos;s set file.
    public const string TILESET_RESREF_BEHOLDER_CAVES = "tib01";
    public const string TILESET_RESREF_CASTLE_INTERIOR = "tic01";
    public const string TILESET_RESREF_CITY_EXTERIOR = "tcn01";
    public const string TILESET_RESREF_CITY_INTERIOR = "tin01";
    public const string TILESET_RESREF_CRYPT = "tdc01";
    public const string TILESET_RESREF_DESERT = "ttd01";
    public const string TILESET_RESREF_DROW_INTERIOR = "tid01";
    public const string TILESET_RESREF_DUNGEON = "tde01";
    public const string TILESET_RESREF_FOREST = "ttf01";
    public const string TILESET_RESREF_FROZEN_WASTES = "tti01";
    public const string TILESET_RESREF_ILLITHID_INTERIOR = "tii01";
    public const string TILESET_RESREF_MICROSET = "tms01";
    public const string TILESET_RESREF_MINES_AND_CAVERNS = "tdm01";
    public const string TILESET_RESREF_RUINS = "tdr01";
    public const string TILESET_RESREF_RURAL = "ttr01";
    public const string TILESET_RESREF_RURAL_WINTER = "tts01";
    public const string TILESET_RESREF_SEWERS = "tds01";
    public const string TILESET_RESREF_UNDERDARK = "ttu01";
    public const string TILESET_RESREF_LIZARDFOLK_INTERIOR = "dag01";
    public const string TILESET_RESREF_MEDIEVAL_CITY_2 = "tcm02";
    public const string TILESET_RESREF_MEDIEVAL_RURAL_2 = "trm02";
    public const string TILESET_RESREF_EARLY_WINTER_2 = "trs02";
    public const string TILESET_RESREF_SEASHIPS = "tss13";
    public const string TILESET_RESREF_FOREST_FACELIFT = "ttf02";
    public const string TILESET_RESREF_RURAL_WINTER_FACELIFT = "tts02";
    public const string TILESET_RESREF_STEAMWORKS = "tsw01";
    public const string TILESET_RESREF_BARROWS_INTERIOR = "tbw01";
    public const string TILESET_RESREF_SEA_CAVES = "tdt01";
    public const string TILESET_RESREF_CITY_INTERIOR_2 = "tni01";
    public const string TILESET_RESREF_CASTLE_INTERIOR_2 = "tni02";
    public const string TILESET_RESREF_CASTLE_EXTERIOR_RURAL = "tno01";
    public const string TILESET_RESREF_TROPICAL = "ttz01";
    public const string TILESET_RESREF_FORT_INTERIOR = "twc03";

    ///  These constants determine which name table to use when generating random names.
    public const int NAME_FIRST_GENERIC_MALE = -1;
    public const int NAME_ANIMAL = 0;
    public const int NAME_FAMILIAR = 1;
    public const int NAME_FIRST_DWARF_MALE = 2;
    public const int NAME_FIRST_DWARF_FEMALE = 3;
    public const int NAME_LAST_DWARF = 4;
    public const int NAME_FIRST_ELF_MALE = 5;
    public const int NAME_FIRST_ELF_FEMALE = 6;
    public const int NAME_LAST_ELF = 7;
    public const int NAME_FIRST_GNOME_MALE = 8;
    public const int NAME_FIRST_GNOME_FEMALE = 9;
    public const int NAME_LAST_GNOME = 10;
    public const int NAME_FIRST_HALFELF_MALE = 11;
    public const int NAME_FIRST_HALFELF_FEMALE = 12;
    public const int NAME_LAST_HALFELF = 13;
    public const int NAME_FIRST_HALFLING_MALE = 14;
    public const int NAME_FIRST_HALFLING_FEMALE = 15;
    public const int NAME_LAST_HALFLING = 16;
    public const int NAME_FIRST_HALFORC_MALE = 17;
    public const int NAME_FIRST_HALFORC_FEMALE = 18;
    public const int NAME_LAST_HALFORC = 19;
    public const int NAME_FIRST_HUMAN_MALE = 20;
    public const int NAME_FIRST_HUMAN_FEMALE = 21;
    public const int NAME_LAST_HUMAN = 22;
    public const int EVENT_SCRIPT_MODULE_ON_HEARTBEAT = 3000;
    public const int EVENT_SCRIPT_MODULE_ON_USER_DEFINED_EVENT = 3001;
    public const int EVENT_SCRIPT_MODULE_ON_MODULE_LOAD = 3002;
    public const int EVENT_SCRIPT_MODULE_ON_MODULE_START = 3003;
    public const int EVENT_SCRIPT_MODULE_ON_CLIENT_ENTER = 3004;
    public const int EVENT_SCRIPT_MODULE_ON_CLIENT_EXIT = 3005;
    public const int EVENT_SCRIPT_MODULE_ON_ACTIVATE_ITEM = 3006;
    public const int EVENT_SCRIPT_MODULE_ON_ACQUIRE_ITEM = 3007;
    public const int EVENT_SCRIPT_MODULE_ON_LOSE_ITEM = 3008;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_DEATH = 3009;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_DYING = 3010;
    public const int EVENT_SCRIPT_MODULE_ON_RESPAWN_BUTTON_PRESSED = 3011;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_REST = 3012;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_LEVEL_UP = 3013;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_CANCEL_CUTSCENE = 3014;
    public const int EVENT_SCRIPT_MODULE_ON_EQUIP_ITEM = 3015;
    public const int EVENT_SCRIPT_MODULE_ON_UNEQUIP_ITEM = 3016;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_CHAT = 3017;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_TARGET = 3018;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_GUIEVENT = 3019;
    public const int EVENT_SCRIPT_MODULE_ON_PLAYER_TILE_ACTION = 3020;
    public const int EVENT_SCRIPT_MODULE_ON_NUI_EVENT = 3021;
    public const int EVENT_SCRIPT_AREA_ON_HEARTBEAT = 4000;
    public const int EVENT_SCRIPT_AREA_ON_USER_DEFINED_EVENT = 4001;
    public const int EVENT_SCRIPT_AREA_ON_ENTER = 4002;
    public const int EVENT_SCRIPT_AREA_ON_EXIT = 4003;
    public const int EVENT_SCRIPT_AREAOFEFFECT_ON_HEARTBEAT = 11000;
    public const int EVENT_SCRIPT_AREAOFEFFECT_ON_USER_DEFINED_EVENT = 11001;
    public const int EVENT_SCRIPT_AREAOFEFFECT_ON_OBJECT_ENTER = 11002;
    public const int EVENT_SCRIPT_AREAOFEFFECT_ON_OBJECT_EXIT = 11003;
    public const int EVENT_SCRIPT_CREATURE_ON_HEARTBEAT = 5000;
    public const int EVENT_SCRIPT_CREATURE_ON_NOTICE = 5001;
    public const int EVENT_SCRIPT_CREATURE_ON_SPELLCASTAT = 5002;
    public const int EVENT_SCRIPT_CREATURE_ON_MELEE_ATTACKED = 5003;
    public const int EVENT_SCRIPT_CREATURE_ON_DAMAGED = 5004;
    public const int EVENT_SCRIPT_CREATURE_ON_DISTURBED = 5005;
    public const int EVENT_SCRIPT_CREATURE_ON_END_COMBATROUND = 5006;
    public const int EVENT_SCRIPT_CREATURE_ON_DIALOGUE = 5007;
    public const int EVENT_SCRIPT_CREATURE_ON_SPAWN_IN = 5008;
    public const int EVENT_SCRIPT_CREATURE_ON_RESTED = 5009;
    public const int EVENT_SCRIPT_CREATURE_ON_DEATH = 5010;
    public const int EVENT_SCRIPT_CREATURE_ON_USER_DEFINED_EVENT = 5011;
    public const int EVENT_SCRIPT_CREATURE_ON_BLOCKED_BY_DOOR = 5012;
    public const int EVENT_SCRIPT_TRIGGER_ON_HEARTBEAT = 7000;
    public const int EVENT_SCRIPT_TRIGGER_ON_OBJECT_ENTER = 7001;
    public const int EVENT_SCRIPT_TRIGGER_ON_OBJECT_EXIT = 7002;
    public const int EVENT_SCRIPT_TRIGGER_ON_USER_DEFINED_EVENT = 7003;
    public const int EVENT_SCRIPT_TRIGGER_ON_TRAPTRIGGERED = 7004;
    public const int EVENT_SCRIPT_TRIGGER_ON_DISARMED = 7005;
    public const int EVENT_SCRIPT_TRIGGER_ON_CLICKED = 7006;
    public const int EVENT_SCRIPT_PLACEABLE_ON_CLOSED = 9000;
    public const int EVENT_SCRIPT_PLACEABLE_ON_DAMAGED = 9001;
    public const int EVENT_SCRIPT_PLACEABLE_ON_DEATH = 9002;
    public const int EVENT_SCRIPT_PLACEABLE_ON_DISARM = 9003;
    public const int EVENT_SCRIPT_PLACEABLE_ON_HEARTBEAT = 9004;
    public const int EVENT_SCRIPT_PLACEABLE_ON_INVENTORYDISTURBED = 9005;
    public const int EVENT_SCRIPT_PLACEABLE_ON_LOCK = 9006;
    public const int EVENT_SCRIPT_PLACEABLE_ON_MELEEATTACKED = 9007;
    public const int EVENT_SCRIPT_PLACEABLE_ON_OPEN = 9008;
    public const int EVENT_SCRIPT_PLACEABLE_ON_SPELLCASTAT = 9009;
    public const int EVENT_SCRIPT_PLACEABLE_ON_TRAPTRIGGERED = 9010;
    public const int EVENT_SCRIPT_PLACEABLE_ON_UNLOCK = 9011;
    public const int EVENT_SCRIPT_PLACEABLE_ON_USED = 9012;
    public const int EVENT_SCRIPT_PLACEABLE_ON_USER_DEFINED_EVENT = 9013;
    public const int EVENT_SCRIPT_PLACEABLE_ON_DIALOGUE = 9014;
    public const int EVENT_SCRIPT_PLACEABLE_ON_LEFT_CLICK = 9015;
    public const int EVENT_SCRIPT_DOOR_ON_OPEN = 10000;
    public const int EVENT_SCRIPT_DOOR_ON_CLOSE = 10001;
    public const int EVENT_SCRIPT_DOOR_ON_DAMAGE = 10002;
    public const int EVENT_SCRIPT_DOOR_ON_DEATH = 10003;
    public const int EVENT_SCRIPT_DOOR_ON_DISARM = 10004;
    public const int EVENT_SCRIPT_DOOR_ON_HEARTBEAT = 10005;
    public const int EVENT_SCRIPT_DOOR_ON_LOCK = 10006;
    public const int EVENT_SCRIPT_DOOR_ON_MELEE_ATTACKED = 10007;
    public const int EVENT_SCRIPT_DOOR_ON_SPELLCASTAT = 10008;
    public const int EVENT_SCRIPT_DOOR_ON_TRAPTRIGGERED = 10009;
    public const int EVENT_SCRIPT_DOOR_ON_UNLOCK = 10010;
    public const int EVENT_SCRIPT_DOOR_ON_USERDEFINED = 10011;
    public const int EVENT_SCRIPT_DOOR_ON_CLICKED = 10012;
    public const int EVENT_SCRIPT_DOOR_ON_DIALOGUE = 10013;
    public const int EVENT_SCRIPT_DOOR_ON_FAIL_TO_OPEN = 10014;
    public const int EVENT_SCRIPT_ENCOUNTER_ON_OBJECT_ENTER = 13000;
    public const int EVENT_SCRIPT_ENCOUNTER_ON_OBJECT_EXIT = 13001;
    public const int EVENT_SCRIPT_ENCOUNTER_ON_HEARTBEAT = 13002;
    public const int EVENT_SCRIPT_ENCOUNTER_ON_ENCOUNTER_EXHAUSTED = 13003;
    public const int EVENT_SCRIPT_ENCOUNTER_ON_USER_DEFINED_EVENT = 13004;
    public const int EVENT_SCRIPT_STORE_ON_OPEN = 14000;
    public const int EVENT_SCRIPT_STORE_ON_CLOSE = 14001;
    public const int OBJECT_VISUAL_TRANSFORM_SCALE = 10;
    public const int OBJECT_VISUAL_TRANSFORM_ROTATE_X = 21;
    public const int OBJECT_VISUAL_TRANSFORM_ROTATE_Y = 22;
    public const int OBJECT_VISUAL_TRANSFORM_ROTATE_Z = 23;
    public const int OBJECT_VISUAL_TRANSFORM_TRANSLATE_X = 31;
    public const int OBJECT_VISUAL_TRANSFORM_TRANSLATE_Y = 32;
    public const int OBJECT_VISUAL_TRANSFORM_TRANSLATE_Z = 33;
    public const int OBJECT_VISUAL_TRANSFORM_ANIMATION_SPEED = 40;
    public const int OBJECT_VISUAL_TRANSFORM_LERP_NONE = 0;

    ///  1
    public const int OBJECT_VISUAL_TRANSFORM_LERP_LINEAR = 1;

    ///  x
    public const int OBJECT_VISUAL_TRANSFORM_LERP_SMOOTHSTEP = 2;

    ///  x * x * (3 - 2 * x)
    public const int OBJECT_VISUAL_TRANSFORM_LERP_INVERSE_SMOOTHSTEP = 3;

    ///  0.5 - sin(asin(1.0 - 2.0 * x) / 3.0)
    public const int OBJECT_VISUAL_TRANSFORM_LERP_EASE_IN = 4;

    ///  (1 - cosf(x * M_PI * 0.5))
    public const int OBJECT_VISUAL_TRANSFORM_LERP_EASE_OUT = 5;

    ///  sinf(x * M_PI * 0.5)
    public const int OBJECT_VISUAL_TRANSFORM_LERP_QUADRATIC = 6;

    ///  x * x
    public const int OBJECT_VISUAL_TRANSFORM_LERP_SMOOTHERSTEP = 7;

    ///  (x * x * x * (x * (6.0 * x - 15.0) + 10.0))
    public const int VIBRATOR_MOTOR_ANY = 0;
    public const int VIBRATOR_MOTOR_LEFT = 1;
    public const int VIBRATOR_MOTOR_RIGHT = 2;
    public const int SCREEN_ANCHOR_TOP_LEFT = 0;
    public const int SCREEN_ANCHOR_TOP_RIGHT = 1;
    public const int SCREEN_ANCHOR_BOTTOM_LEFT = 2;
    public const int SCREEN_ANCHOR_BOTTOM_RIGHT = 3;
    public const int SCREEN_ANCHOR_CENTER = 4;
    public const int DOMAIN_AIR = 0;
    public const int DOMAIN_ANIMAL = 1;
    public const int DOMAIN_DEATH = 3;
    public const int DOMAIN_DESTRUCTION = 4;
    public const int DOMAIN_EARTH = 5;
    public const int DOMAIN_EVIL = 6;
    public const int DOMAIN_FIRE = 7;
    public const int DOMAIN_GOOD = 8;
    public const int DOMAIN_HEALING = 9;
    public const int DOMAIN_KNOWLEDGE = 10;
    public const int DOMAIN_MAGIC = 13;
    public const int DOMAIN_PLANT = 14;
    public const int DOMAIN_PROTECTION = 15;
    public const int DOMAIN_STRENGTH = 16;
    public const int DOMAIN_SUN = 17;
    public const int DOMAIN_TRAVEL = 18;
    public const int DOMAIN_TRICKERY = 19;
    public const int DOMAIN_WAR = 20;
    public const int DOMAIN_WATER = 21;
    public const int MOUSECURSOR_DEFAULT = 1;
    public const int MOUSECURSOR_DEFAULT_DOWN = 2;
    public const int MOUSECURSOR_WALK = 3;
    public const int MOUSECURSOR_WALK_DOWN = 4;
    public const int MOUSECURSOR_NOWALK = 5;
    public const int MOUSECURSOR_NOWALK_DOWN = 6;
    public const int MOUSECURSOR_ATTACK = 7;
    public const int MOUSECURSOR_ATTACK_DOWN = 8;
    public const int MOUSECURSOR_NOATTACK = 9;
    public const int MOUSECURSOR_NOATTACK_DOWN = 10;
    public const int MOUSECURSOR_TALK = 11;
    public const int MOUSECURSOR_TALK_DOWN = 12;
    public const int MOUSECURSOR_NOTALK = 13;
    public const int MOUSECURSOR_NOTALK_DOWN = 14;
    public const int MOUSECURSOR_FOLLOW = 15;
    public const int MOUSECURSOR_FOLLOW_DOWN = 16;
    public const int MOUSECURSOR_EXAMINE = 17;
    public const int MOUSECURSOR_EXAMINE_DOWN = 18;
    public const int MOUSECURSOR_NOEXAMINE = 19;
    public const int MOUSECURSOR_NOEXAMINE_DOWN = 20;
    public const int MOUSECURSOR_TRANSITION = 21;
    public const int MOUSECURSOR_TRANSITION_DOWN = 22;
    public const int MOUSECURSOR_DOOR = 23;
    public const int MOUSECURSOR_DOOR_DOWN = 24;
    public const int MOUSECURSOR_USE = 25;
    public const int MOUSECURSOR_USE_DOWN = 26;
    public const int MOUSECURSOR_NOUSE = 27;
    public const int MOUSECURSOR_NOUSE_DOWN = 28;
    public const int MOUSECURSOR_MAGIC = 29;
    public const int MOUSECURSOR_MAGIC_DOWN = 30;
    public const int MOUSECURSOR_NOMAGIC = 31;
    public const int MOUSECURSOR_NOMAGIC_DOWN = 32;
    public const int MOUSECURSOR_DISARM = 33;
    public const int MOUSECURSOR_DISARM_DOWN = 34;
    public const int MOUSECURSOR_NODISARM = 35;
    public const int MOUSECURSOR_NODISARM_DOWN = 36;
    public const int MOUSECURSOR_ACTION = 37;
    public const int MOUSECURSOR_ACTION_DOWN = 38;
    public const int MOUSECURSOR_NOACTION = 39;
    public const int MOUSECURSOR_NOACTION_DOWN = 40;
    public const int MOUSECURSOR_LOCK = 41;
    public const int MOUSECURSOR_LOCK_DOWN = 42;
    public const int MOUSECURSOR_NOLOCK = 43;
    public const int MOUSECURSOR_NOLOCK_DOWN = 44;
    public const int MOUSECURSOR_PUSHPIN = 45;
    public const int MOUSECURSOR_PUSHPIN_DOWN = 46;
    public const int MOUSECURSOR_CREATE = 47;
    public const int MOUSECURSOR_CREATE_DOWN = 48;
    public const int MOUSECURSOR_NOCREATE = 49;
    public const int MOUSECURSOR_NOCREATE_DOWN = 50;
    public const int MOUSECURSOR_KILL = 51;
    public const int MOUSECURSOR_KILL_DOWN = 52;
    public const int MOUSECURSOR_NOKILL = 53;
    public const int MOUSECURSOR_NOKILL_DOWN = 54;
    public const int MOUSECURSOR_HEAL = 55;
    public const int MOUSECURSOR_HEAL_DOWN = 56;
    public const int MOUSECURSOR_NOHEAL = 57;
    public const int MOUSECURSOR_NOHEAL_DOWN = 58;
    public const int MOUSECURSOR_RUNARROW = 59;
    public const int MOUSECURSOR_WALKARROW = 75;
    public const int MOUSECURSOR_PICKUP = 91;
    public const int MOUSECURSOR_PICKUP_DOWN = 92;
    public const int MOUSECURSOR_CUSTOM_00 = 93;

    ///  gui_mp_custom00u
    public const int MOUSECURSOR_CUSTOM_00_DOWN = 94;

    ///  gui_mp_custom00d
    public const int MOUSECURSOR_CUSTOM_99 = 291;

    ///  gui_mp_custom99u
    public const int MOUSECURSOR_CUSTOM_99_DOWN = 292;

    ///  gui_mp_custom99d
    public const float CASSOWARY_STRENGTH_WEAK = 1.0f;
    public const float CASSOWARY_STRENGTH_MEDIUM = 1000.0f;
    public const float CASSOWARY_STRENGTH_STRONG = 1000000.0f;
    public const float CASSOWARY_STRENGTH_REQUIRED = 1001001000.0f;
    public const int RUNSCRIPT_EFFECT_SCRIPT_TYPE_ON_APPLIED = 1;
    public const int RUNSCRIPT_EFFECT_SCRIPT_TYPE_ON_REMOVED = 2;
    public const int RUNSCRIPT_EFFECT_SCRIPT_TYPE_ON_INTERVAL = 3;
    public const int EFFECT_ICON_INVALID = 0;
    public const int EFFECT_ICON_DAMAGE_RESISTANCE = 1;
    public const int EFFECT_ICON_REGENERATE = 2;
    public const int EFFECT_ICON_DAMAGE_REDUCTION = 3;
    public const int EFFECT_ICON_TEMPORARY_HITPOINTS = 4;
    public const int EFFECT_ICON_ENTANGLE = 5;
    public const int EFFECT_ICON_INVULNERABLE = 6;
    public const int EFFECT_ICON_DEAF = 7;
    public const int EFFECT_ICON_FATIGUE = 8;
    public const int EFFECT_ICON_IMMUNITY = 9;
    public const int EFFECT_ICON_BLIND = 10;
    public const int EFFECT_ICON_ENEMY_ATTACK_BONUS = 11;
    public const int EFFECT_ICON_CHARMED = 12;
    public const int EFFECT_ICON_CONFUSED = 13;
    public const int EFFECT_ICON_FRIGHTENED = 14;
    public const int EFFECT_ICON_DOMINATED = 15;
    public const int EFFECT_ICON_PARALYZE = 16;
    public const int EFFECT_ICON_DAZED = 17;
    public const int EFFECT_ICON_STUNNED = 18;
    public const int EFFECT_ICON_SLEEP = 19;
    public const int EFFECT_ICON_POISON = 20;
    public const int EFFECT_ICON_DISEASE = 21;
    public const int EFFECT_ICON_CURSE = 22;
    public const int EFFECT_ICON_SILENCE = 23;
    public const int EFFECT_ICON_TURNED = 24;
    public const int EFFECT_ICON_HASTE = 25;
    public const int EFFECT_ICON_SLOW = 26;
    public const int EFFECT_ICON_ABILITY_INCREASE_STR = 27;
    public const int EFFECT_ICON_ABILITY_DECREASE_STR = 28;
    public const int EFFECT_ICON_ATTACK_INCREASE = 29;
    public const int EFFECT_ICON_ATTACK_DECREASE = 30;
    public const int EFFECT_ICON_DAMAGE_INCREASE = 31;
    public const int EFFECT_ICON_DAMAGE_DECREASE = 32;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_INCREASE = 33;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_DECREASE = 34;
    public const int EFFECT_ICON_AC_INCREASE = 35;
    public const int EFFECT_ICON_AC_DECREASE = 36;
    public const int EFFECT_ICON_MOVEMENT_SPEED_INCREASE = 37;
    public const int EFFECT_ICON_MOVEMENT_SPEED_DECREASE = 38;
    public const int EFFECT_ICON_SAVING_THROW_INCREASE = 39;
    public const int EFFECT_ICON_SAVING_THROW_DECREASE = 40;
    public const int EFFECT_ICON_SPELL_RESISTANCE_INCREASE = 41;
    public const int EFFECT_ICON_SPELL_RESISTANCE_DECREASE = 42;
    public const int EFFECT_ICON_SKILL_INCREASE = 43;
    public const int EFFECT_ICON_SKILL_DECREASE = 44;
    public const int EFFECT_ICON_INVISIBILITY = 45;
    public const int EFFECT_ICON_IMPROVEDINVISIBILITY = 46;
    public const int EFFECT_ICON_DARKNESS = 47;
    public const int EFFECT_ICON_DISPELMAGICALL = 48;
    public const int EFFECT_ICON_ELEMENTALSHIELD = 49;
    public const int EFFECT_ICON_LEVELDRAIN = 50;
    public const int EFFECT_ICON_POLYMORPH = 51;
    public const int EFFECT_ICON_SANCTUARY = 52;
    public const int EFFECT_ICON_TRUESEEING = 53;
    public const int EFFECT_ICON_SEEINVISIBILITY = 54;
    public const int EFFECT_ICON_TIMESTOP = 55;
    public const int EFFECT_ICON_BLINDNESS = 56;
    public const int EFFECT_ICON_SPELLLEVELABSORPTION = 57;
    public const int EFFECT_ICON_DISPELMAGICBEST = 58;
    public const int EFFECT_ICON_ABILITY_INCREASE_DEX = 59;
    public const int EFFECT_ICON_ABILITY_DECREASE_DEX = 60;
    public const int EFFECT_ICON_ABILITY_INCREASE_CON = 61;
    public const int EFFECT_ICON_ABILITY_DECREASE_CON = 62;
    public const int EFFECT_ICON_ABILITY_INCREASE_INT = 63;
    public const int EFFECT_ICON_ABILITY_DECREASE_INT = 64;
    public const int EFFECT_ICON_ABILITY_INCREASE_WIS = 65;
    public const int EFFECT_ICON_ABILITY_DECREASE_WIS = 66;
    public const int EFFECT_ICON_ABILITY_INCREASE_CHA = 67;
    public const int EFFECT_ICON_ABILITY_DECREASE_CHA = 68;
    public const int EFFECT_ICON_IMMUNITY_ALL = 69;
    public const int EFFECT_ICON_IMMUNITY_MIND = 70;
    public const int EFFECT_ICON_IMMUNITY_POISON = 71;
    public const int EFFECT_ICON_IMMUNITY_DISEASE = 72;
    public const int EFFECT_ICON_IMMUNITY_FEAR = 73;
    public const int EFFECT_ICON_IMMUNITY_TRAP = 74;
    public const int EFFECT_ICON_IMMUNITY_PARALYSIS = 75;
    public const int EFFECT_ICON_IMMUNITY_BLINDNESS = 76;
    public const int EFFECT_ICON_IMMUNITY_DEAFNESS = 77;
    public const int EFFECT_ICON_IMMUNITY_SLOW = 78;
    public const int EFFECT_ICON_IMMUNITY_ENTANGLE = 79;
    public const int EFFECT_ICON_IMMUNITY_SILENCE = 80;
    public const int EFFECT_ICON_IMMUNITY_STUN = 81;
    public const int EFFECT_ICON_IMMUNITY_SLEEP = 82;
    public const int EFFECT_ICON_IMMUNITY_CHARM = 83;
    public const int EFFECT_ICON_IMMUNITY_DOMINATE = 84;
    public const int EFFECT_ICON_IMMUNITY_CONFUSE = 85;
    public const int EFFECT_ICON_IMMUNITY_CURSE = 86;
    public const int EFFECT_ICON_IMMUNITY_DAZED = 87;
    public const int EFFECT_ICON_IMMUNITY_ABILITY_DECREASE = 88;
    public const int EFFECT_ICON_IMMUNITY_ATTACK_DECREASE = 89;
    public const int EFFECT_ICON_IMMUNITY_DAMAGE_DECREASE = 90;
    public const int EFFECT_ICON_IMMUNITY_DAMAGE_IMMUNITY_DECREASE = 91;
    public const int EFFECT_ICON_IMMUNITY_AC_DECREASE = 92;
    public const int EFFECT_ICON_IMMUNITY_MOVEMENT_SPEED_DECREASE = 93;
    public const int EFFECT_ICON_IMMUNITY_SAVING_THROW_DECREASE = 94;
    public const int EFFECT_ICON_IMMUNITY_SPELL_RESISTANCE_DECREASE = 95;
    public const int EFFECT_ICON_IMMUNITY_SKILL_DECREASE = 96;
    public const int EFFECT_ICON_IMMUNITY_KNOCKDOWN = 97;
    public const int EFFECT_ICON_IMMUNITY_NEGATIVE_LEVEL = 98;
    public const int EFFECT_ICON_IMMUNITY_SNEAK_ATTACK = 99;
    public const int EFFECT_ICON_IMMUNITY_CRITICAL_HIT = 100;
    public const int EFFECT_ICON_IMMUNITY_DEATH_MAGIC = 101;
    public const int EFFECT_ICON_REFLEX_SAVE_INCREASED = 102;
    public const int EFFECT_ICON_FORT_SAVE_INCREASED = 103;
    public const int EFFECT_ICON_WILL_SAVE_INCREASED = 104;
    public const int EFFECT_ICON_TAUNTED = 105;
    public const int EFFECT_ICON_SPELLIMMUNITY = 106;
    public const int EFFECT_ICON_ETHEREALNESS = 107;
    public const int EFFECT_ICON_CONCEALMENT = 108;
    public const int EFFECT_ICON_PETRIFIED = 109;
    public const int EFFECT_ICON_EFFECT_SPELL_FAILURE = 110;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_MAGIC = 111;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_ACID = 112;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_COLD = 113;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_DIVINE = 114;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_ELECTRICAL = 115;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_FIRE = 116;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_NEGATIVE = 117;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_POSITIVE = 118;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_SONIC = 119;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_MAGIC_DECREASE = 120;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_ACID_DECREASE = 121;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_COLD_DECREASE = 122;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_DIVINE_DECREASE = 123;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_ELECTRICAL_DECREASE = 124;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_FIRE_DECREASE = 125;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_NEGATIVE_DECREASE = 126;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_POSITIVE_DECREASE = 127;
    public const int EFFECT_ICON_DAMAGE_IMMUNITY_SONIC_DECREASE = 128;
    public const int EFFECT_ICON_WOUNDING = 129;
    public const int GUIEVENT_CHATBAR_FOCUS = 1;
    public const int GUIEVENT_CHATBAR_UNFOCUS = 2;
    public const int GUIEVENT_CHARACTERSHEET_SKILL_CLICK = 3;
    public const int GUIEVENT_CHARACTERSHEET_FEAT_CLICK = 4;
    public const int GUIEVENT_EFFECTICON_CLICK = 5;
    public const int GUIEVENT_DEATHPANEL_WAITFORHELP_CLICK = 6;
    public const int GUIEVENT_MINIMAP_MAPPIN_CLICK = 7;
    public const int GUIEVENT_MINIMAP_OPEN = 8;
    public const int GUIEVENT_MINIMAP_CLOSE = 9;
    public const int GUIEVENT_JOURNAL_OPEN = 10;
    public const int GUIEVENT_JOURNAL_CLOSE = 11;
    public const int GUIEVENT_PLAYERLIST_PLAYER_CLICK = 12;
    public const int GUIEVENT_PARTYBAR_PORTRAIT_CLICK = 13;
    public const int GUIEVENT_DISABLED_PANEL_ATTEMPT_OPEN = 14;
    public const int GUIEVENT_COMPASS_CLICK = 15;
    public const int GUIEVENT_LEVELUP_CANCELLED = 16;
    public const int GUIEVENT_AREA_LOADSCREEN_FINISHED = 17;
    public const int GUIEVENT_QUICKCHAT_ACTIVATE = 18;
    public const int GUIEVENT_QUICKCHAT_SELECT = 19;
    public const int GUIEVENT_QUICKCHAT_CLOSE = 20;
    public const int GUIEVENT_SELECT_CREATURE = 21;
    public const int GUIEVENT_UNSELECT_CREATURE = 22;
    public const int GUIEVENT_EXAMINE_OBJECT = 23;
    public const int GUIEVENT_OPTIONS_OPEN = 24;
    public const int GUIEVENT_OPTIONS_CLOSE = 25;
    public const int JSON_TYPE_NULL = 0;

    ///  Also invalid
    public const int JSON_TYPE_OBJECT = 1;
    public const int JSON_TYPE_ARRAY = 2;
    public const int JSON_TYPE_STRING = 3;
    public const int JSON_TYPE_INTEGER = 4;
    public const int JSON_TYPE_FLOAT = 5;
    public const int JSON_TYPE_BOOL = 6;

    ///  The player&amp;apos;s gui width (inner window bounds).
    public const string PLAYER_DEVICE_PROPERTY_GUI_WIDTH = "gui_width";

    ///  The player&amp;apos;s gui height (inner window bounds).
    public const string PLAYER_DEVICE_PROPERTY_GUI_HEIGHT = "gui_height";

    ///  The player&amp;apos;s gui scale, in percent (factor 1.4 = 140)
    public const string PLAYER_DEVICE_PROPERTY_GUI_SCALE = "gui_scale";
    public const int PLAYER_LANGUAGE_INVALID = -1;
    public const int PLAYER_LANGUAGE_ENGLISH = 0;
    public const int PLAYER_LANGUAGE_FRENCH = 1;
    public const int PLAYER_LANGUAGE_GERMAN = 2;
    public const int PLAYER_LANGUAGE_ITALIAN = 3;
    public const int PLAYER_LANGUAGE_SPANISH = 4;
    public const int PLAYER_LANGUAGE_POLISH = 5;
    public const int PLAYER_DEVICE_PLATFORM_INVALID = 0;
    public const int PLAYER_DEVICE_PLATFORM_WINDOWS_X86 = 1;
    public const int PLAYER_DEVICE_PLATFORM_WINDOWS_X64 = 2;
    public const int PLAYER_DEVICE_PLATFORM_LINUX_X86 = 10;
    public const int PLAYER_DEVICE_PLATFORM_LINUX_X64 = 11;
    public const int PLAYER_DEVICE_PLATFORM_LINUX_ARM32 = 12;
    public const int PLAYER_DEVICE_PLATFORM_LINUX_ARM64 = 13;
    public const int PLAYER_DEVICE_PLATFORM_MAC_X86 = 20;
    public const int PLAYER_DEVICE_PLATFORM_MAC_X64 = 21;
    public const int PLAYER_DEVICE_PLATFORM_IOS = 30;
    public const int PLAYER_DEVICE_PLATFORM_ANDROID_ARM32 = 40;
    public const int PLAYER_DEVICE_PLATFORM_ANDROID_ARM64 = 41;
    public const int PLAYER_DEVICE_PLATFORM_ANDROID_X64 = 42;
    public const int PLAYER_DEVICE_PLATFORM_NINTENDO_SWITCH = 50;
    public const int PLAYER_DEVICE_PLATFORM_MICROSOFT_XBOXONE = 60;
    public const int PLAYER_DEVICE_PLATFORM_SONY_PS4 = 70;
    public const int RESTYPE_RES = 0;
    public const int RESTYPE_BMP = 1;
    public const int RESTYPE_MVE = 2;
    public const int RESTYPE_TGA = 3;
    public const int RESTYPE_WAV = 4;
    public const int RESTYPE_WFX = 5;
    public const int RESTYPE_PLT = 6;
    public const int RESTYPE_INI = 7;
    public const int RESTYPE_MP3 = 8;
    public const int RESTYPE_MPG = 9;
    public const int RESTYPE_TXT = 10;
    public const int RESTYPE_KEY = 9999;
    public const int RESTYPE_BIF = 9998;
    public const int RESTYPE_ERF = 9997;
    public const int RESTYPE_IDS = 9996;
    public const int RESTYPE_PLH = 2000;
    public const int RESTYPE_TEX = 2001;
    public const int RESTYPE_MDL = 2002;
    public const int RESTYPE_THG = 2003;
    public const int RESTYPE_FNT = 2005;
    public const int RESTYPE_LUA = 2007;
    public const int RESTYPE_SLT = 2008;
    public const int RESTYPE_NSS = 2009;
    public const int RESTYPE_NCS = 2010;
    public const int RESTYPE_MOD = 2011;
    public const int RESTYPE_ARE = 2012;
    public const int RESTYPE_SET = 2013;
    public const int RESTYPE_IFO = 2014;
    public const int RESTYPE_BIC = 2015;
    public const int RESTYPE_WOK = 2016;
    public const int RESTYPE_2DA = 2017;
    public const int RESTYPE_TLK = 2018;
    public const int RESTYPE_TXI = 2022;
    public const int RESTYPE_GIT = 2023;
    public const int RESTYPE_BTI = 2024;
    public const int RESTYPE_UTI = 2025;
    public const int RESTYPE_BTC = 2026;
    public const int RESTYPE_UTC = 2027;
    public const int RESTYPE_DLG = 2029;
    public const int RESTYPE_ITP = 2030;
    public const int RESTYPE_BTT = 2031;
    public const int RESTYPE_UTT = 2032;
    public const int RESTYPE_DDS = 2033;
    public const int RESTYPE_BTS = 2034;
    public const int RESTYPE_UTS = 2035;
    public const int RESTYPE_LTR = 2036;
    public const int RESTYPE_GFF = 2037;
    public const int RESTYPE_FAC = 2038;
    public const int RESTYPE_BTE = 2039;
    public const int RESTYPE_UTE = 2040;
    public const int RESTYPE_BTD = 2041;
    public const int RESTYPE_UTD = 2042;
    public const int RESTYPE_BTP = 2043;
    public const int RESTYPE_UTP = 2044;
    public const int RESTYPE_DFT = 2045;
    public const int RESTYPE_GIC = 2046;
    public const int RESTYPE_GUI = 2047;
    public const int RESTYPE_CSS = 2048;
    public const int RESTYPE_CCS = 2049;
    public const int RESTYPE_BTM = 2050;
    public const int RESTYPE_UTM = 2051;
    public const int RESTYPE_DWK = 2052;
    public const int RESTYPE_PWK = 2053;
    public const int RESTYPE_BTG = 2054;
    public const int RESTYPE_UTG = 2055;
    public const int RESTYPE_JRL = 2056;
    public const int RESTYPE_SAV = 2057;
    public const int RESTYPE_UTW = 2058;
    public const int RESTYPE_4PC = 2059;
    public const int RESTYPE_SSF = 2060;
    public const int RESTYPE_HAK = 2061;
    public const int RESTYPE_NWM = 2062;
    public const int RESTYPE_BIK = 2063;
    public const int RESTYPE_NDB = 2064;
    public const int RESTYPE_PTM = 2065;
    public const int RESTYPE_PTT = 2066;
    public const int RESTYPE_BAK = 2067;
    public const int RESTYPE_DAT = 2068;
    public const int RESTYPE_SHD = 2069;
    public const int RESTYPE_XBC = 2070;
    public const int RESTYPE_WBM = 2071;
    public const int RESTYPE_MTR = 2072;
    public const int RESTYPE_KTX = 2073;
    public const int RESTYPE_TTF = 2074;
    public const int RESTYPE_SQL = 2075;
    public const int RESTYPE_TML = 2076;
    public const int RESTYPE_SQ3 = 2077;
    public const int RESTYPE_LOD = 2078;
    public const int RESTYPE_GIF = 2079;
    public const int RESTYPE_PNG = 2080;
    public const int RESTYPE_JPG = 2081;
    public const int RESTYPE_CAF = 2082;
    public const string sLanguage = "nwscript";

    ///  Get an integer between 0 and nMaxInteger-1.<br/>
    ///  Return value on error: 0
    public static int Random(int nMaxInteger)
    {
      VM.StackPush(nMaxInteger);
      VM.Call(0);
      return VM.StackPopInt();
    }

    ///  Output sString to the log file.
    public static void PrintString(string sString)
    {
      VM.StackPush(sString);
      VM.Call(1);
    }

    ///  Output a formatted float to the log file.<br/>
    ///  - nWidth should be a value from 0 to 18 inclusive.<br/>
    ///  - nDecimals should be a value from 0 to 9 inclusive.
    public static void PrintFloat(float fFloat, int nWidth = 18, int nDecimals = 9)
    {
      VM.StackPush(nDecimals);
      VM.StackPush(nWidth);
      VM.StackPush(fFloat);
      VM.Call(2);
    }

    ///  Convert fFloat into a string.<br/>
    ///  - nWidth should be a value from 0 to 18 inclusive.<br/>
    ///  - nDecimals should be a value from 0 to 9 inclusive.
    public static string FloatToString(float fFloat, int nWidth = 18, int nDecimals = 9)
    {
      VM.StackPush(nDecimals);
      VM.StackPush(nWidth);
      VM.StackPush(fFloat);
      VM.Call(3);
      return VM.StackPopString();
    }

    ///  Output nInteger to the log file.
    public static void PrintInteger(int nInteger)
    {
      VM.StackPush(nInteger);
      VM.Call(4);
    }

    ///  Output oObject&amp;apos;s ID to the log file.
    public static void PrintObject(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(5);
    }

    ///  Assign aActionToAssign to oActionSubject.<br/>
    ///  * No return value, but if an error occurs, the log file will contain<br/>
    ///    &amp;quot;AssignCommand failed.&amp;quot;<br/>
    ///    (If the object doesn&amp;apos;t exist, nothing happens.)
    public static void AssignCommand(uint oActionSubject, System.Action aActionToAssign)
    {
      NWNCore.FunctionHandler!.ClosureAssignCommand(oActionSubject, aActionToAssign);
      // Function ID 6
    }

    ///  Delay aActionToDelay by fSeconds.<br/>
    ///  * No return value, but if an error occurs, the log file will contain<br/>
    ///    &amp;quot;DelayCommand failed.&amp;quot;.<br/>
    ///  It is suggested that functions which create effects should not be used<br/>
    ///  as parameters to delayed actions.  Instead, the effect should be created in the<br/>
    ///  script and then passed into the action.  For example:<br/>
    ///  effect eDamage = EffectDamage(nDamage, DAMAGE_TYPE_MAGICAL);<br/>
    ///  DelayCommand(fDelay, ApplyEffectToObject(DURATION_TYPE_INSTANT, eDamage, oTarget);
    public static void DelayCommand(float fSeconds, System.Action aActionToDelay)
    {
      NWNCore.FunctionHandler!.ClosureDelayCommand(OBJECT_SELF, fSeconds, aActionToDelay);
      // Function ID 7
    }

    ///  Make oTarget run sScript and then return execution to the calling script.<br/>
    ///  If sScript does not specify a compiled script, nothing happens.
    public static void ExecuteScript(string sScript, uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.StackPush(sScript);
      VM.Call(8);
    }

    ///  Clear all the actions of the caller.<br/>
    ///  * No return value, but if an error occurs, the log file will contain<br/>
    ///    &amp;quot;ClearAllActions failed.&amp;quot;.<br/>
    ///  - nClearCombatState: if true, this will immediately clear the combat state<br/>
    ///    on a creature, which will stop the combat music and allow them to rest,<br/>
    ///    engage in dialog, or other actions that they would normally have to wait for.
    public static void ClearAllActions(int nClearCombatState = FALSE)
    {
      VM.StackPush(nClearCombatState);
      VM.Call(9);
    }

    ///  Cause the caller to face fDirection.<br/>
    ///  - fDirection is expressed as anticlockwise degrees from Due East.<br/>
    ///    DIRECTION_EAST, DIRECTION_NORTH, DIRECTION_WEST and DIRECTION_SOUTH are<br/>
    ///    predefined. (0.0f=East, 90.0f=North, 180.0f=West, 270.0f=South)
    public static void SetFacing(float fDirection)
    {
      VM.StackPush(fDirection);
      VM.Call(10);
    }

    ///  Set the calendar to the specified date.<br/>
    ///  - nYear should be from 0 to 32000 inclusive<br/>
    ///  - nMonth should be from 1 to 12 inclusive<br/>
    ///  - nDay should be from 1 to 28 inclusive<br/>
    ///  1) Time can only be advanced forwards; attempting to set the time backwards<br/>
    ///     will result in no change to the calendar.<br/>
    ///  2) If values larger than the month or day are specified, they will be wrapped<br/>
    ///     around and the overflow will be used to advance the next field.<br/>
    ///     e.g. Specifying a year of 1350, month of 33 and day of 10 will result in<br/>
    ///     the calender being set to a year of 1352, a month of 9 and a day of 10.
    public static void SetCalendar(int nYear, int nMonth, int nDay)
    {
      VM.StackPush(nDay);
      VM.StackPush(nMonth);
      VM.StackPush(nYear);
      VM.Call(11);
    }

    ///  Set the time to the time specified.<br/>
    ///  - nHour should be from 0 to 23 inclusive<br/>
    ///  - nMinute should be from 0 to 59 inclusive<br/>
    ///  - nSecond should be from 0 to 59 inclusive<br/>
    ///  - nMillisecond should be from 0 to 999 inclusive<br/>
    ///  1) Time can only be advanced forwards; attempting to set the time backwards<br/>
    ///     will result in the day advancing and then the time being set to that<br/>
    ///     specified, e.g. if the current hour is 15 and then the hour is set to 3,<br/>
    ///     the day will be advanced by 1 and the hour will be set to 3.<br/>
    ///  2) If values larger than the max hour, minute, second or millisecond are<br/>
    ///     specified, they will be wrapped around and the overflow will be used to<br/>
    ///     advance the next field, e.g. specifying 62 hours, 250 minutes, 10 seconds<br/>
    ///     and 10 milliseconds will result in the calendar day being advanced by 2<br/>
    ///     and the time being set to 18 hours, 10 minutes, 10 milliseconds.
    public static void SetTime(int nHour, int nMinute, int nSecond, int nMillisecond)
    {
      VM.StackPush(nMillisecond);
      VM.StackPush(nSecond);
      VM.StackPush(nMinute);
      VM.StackPush(nHour);
      VM.Call(12);
    }

    ///  Get the current calendar year.
    public static int GetCalendarYear()
    {
      VM.Call(13);
      return VM.StackPopInt();
    }

    ///  Get the current calendar month.
    public static int GetCalendarMonth()
    {
      VM.Call(14);
      return VM.StackPopInt();
    }

    ///  Get the current calendar day.
    public static int GetCalendarDay()
    {
      VM.Call(15);
      return VM.StackPopInt();
    }

    ///  Get the current hour.
    public static int GetTimeHour()
    {
      VM.Call(16);
      return VM.StackPopInt();
    }

    ///  Get the current minute
    public static int GetTimeMinute()
    {
      VM.Call(17);
      return VM.StackPopInt();
    }

    ///  Get the current second
    public static int GetTimeSecond()
    {
      VM.Call(18);
      return VM.StackPopInt();
    }

    ///  Get the current millisecond
    public static int GetTimeMillisecond()
    {
      VM.Call(19);
      return VM.StackPopInt();
    }

    ///  The action subject will generate a random location near its current location<br/>
    ///  and pathfind to it.  ActionRandomwalk never ends, which means it is neccessary<br/>
    ///  to call ClearAllActions in order to allow a creature to perform any other action<br/>
    ///  once ActionRandomWalk has been called.<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;ActionRandomWalk failed.&amp;quot;
    public static void ActionRandomWalk()
    {
      VM.Call(20);
    }

    ///  The action subject will move to lDestination.<br/>
    ///  - lDestination: The object will move to this location.  If the location is<br/>
    ///    invalid or a path cannot be found to it, the command does nothing.<br/>
    ///  - bRun: If this is TRUE, the action subject will run rather than walk<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;MoveToPoint failed.&amp;quot;
    public static void ActionMoveToLocation(System.IntPtr lDestination, int bRun = FALSE)
    {
      VM.StackPush(bRun);
      VM.StackPush(lDestination, ENGINE_STRUCTURE_LOCATION);
      VM.Call(21);
    }

    ///  Cause the action subject to move to a certain distance from oMoveTo.<br/>
    ///  If there is no path to oMoveTo, this command will do nothing.<br/>
    ///  - oMoveTo: This is the object we wish the action subject to move to<br/>
    ///  - bRun: If this is TRUE, the action subject will run rather than walk<br/>
    ///  - fRange: This is the desired distance between the action subject and oMoveTo<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;ActionMoveToObject failed.&amp;quot;
    public static void ActionMoveToObject(uint oMoveTo, int bRun = FALSE, float fRange = 1.0f)
    {
      VM.StackPush(fRange);
      VM.StackPush(bRun);
      VM.StackPush(oMoveTo);
      VM.Call(22);
    }

    ///  Cause the action subject to move to a certain distance away from oFleeFrom.<br/>
    ///  - oFleeFrom: This is the object we wish the action subject to move away from.<br/>
    ///    If oFleeFrom is not in the same area as the action subject, nothing will<br/>
    ///    happen.<br/>
    ///  - bRun: If this is TRUE, the action subject will run rather than walk<br/>
    ///  - fMoveAwayRange: This is the distance we wish the action subject to put<br/>
    ///    between themselves and oFleeFrom<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;ActionMoveAwayFromObject failed.&amp;quot;
    public static void ActionMoveAwayFromObject(uint oFleeFrom, int bRun = FALSE, float fMoveAwayRange = 40.0f)
    {
      VM.StackPush(fMoveAwayRange);
      VM.StackPush(bRun);
      VM.StackPush(oFleeFrom);
      VM.Call(23);
    }

    ///  Get the area that oTarget is currently in<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetArea(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(24);
      return VM.StackPopObject();
    }

    ///  The value returned by this function depends on the object type of the caller:<br/>
    ///  1) If the caller is a door it returns the object that last<br/>
    ///     triggered it.<br/>
    ///  2) If the caller is a trigger, area of effect, module, area or encounter it<br/>
    ///     returns the object that last entered it.<br/>
    ///  * Return value on error: OBJECT_INVALID<br/>
    ///   When used for doors, this should only be called from the OnAreaTransitionClick<br/>
    ///   event.  Otherwise, it should only be called in OnEnter scripts.
    public static uint GetEnteringObject()
    {
      VM.Call(25);
      return VM.StackPopObject();
    }

    ///  Get the object that last left the caller.  This function works on triggers,<br/>
    ///  areas of effect, modules, areas and encounters.<br/>
    ///  * Return value on error: OBJECT_INVALID<br/>
    ///  Should only be called in OnExit scripts.
    public static uint GetExitingObject()
    {
      VM.Call(26);
      return VM.StackPopObject();
    }

    ///  Get the position of oTarget<br/>
    ///  * Return value on error: vector (0.0f, 0.0f, 0.0f)
    public static System.Numerics.Vector3 GetPosition(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(27);
      return VM.StackPopVector();
    }

    ///  Get the direction in which oTarget is facing, expressed as a float between<br/>
    ///  0.0f and 360.0f<br/>
    ///  * Return value on error: -1.0f
    public static float GetFacing(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(28);
      return VM.StackPopFloat();
    }

    ///  Get the possessor of oItem<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetItemPossessor(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(29);
      return VM.StackPopObject();
    }

    ///  Get the object possessed by oCreature with the tag sItemTag<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetItemPossessedBy(uint oCreature, string sItemTag)
    {
      VM.StackPush(sItemTag);
      VM.StackPush(oCreature);
      VM.Call(30);
      return VM.StackPopObject();
    }

    ///  Create an item with the template sItemTemplate in oTarget&amp;apos;s inventory.<br/>
    ///  - nStackSize: This is the stack size of the item to be created<br/>
    ///  - sNewTag: If this string is not empty, it will replace the default tag from the template<br/>
    ///  * Return value: The object that has been created.  On error, this returns<br/>
    ///    OBJECT_INVALID.<br/>
    ///  If the item created was merged into an existing stack of similar items,<br/>
    ///  the function will return the merged stack object. If the merged stack<br/>
    ///  overflowed, the function will return the overflowed stack that was created.
    public static uint CreateItemOnObject(string sItemTemplate, uint oTarget = OBJECT_INVALID, int nStackSize = 1, string sNewTag = "")
    {
      VM.StackPush(sNewTag);
      VM.StackPush(nStackSize);
      VM.StackPush(oTarget);
      VM.StackPush(sItemTemplate);
      VM.Call(31);
      return VM.StackPopObject();
    }

    ///  Equip oItem into nInventorySlot.<br/>
    ///  - nInventorySlot: INVENTORY_SLOT_*<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;ActionEquipItem failed.&amp;quot;<br/>
    /// <br/>
    ///  Note:<br/>
    ///        If the creature already has an item equipped in the slot specified, it will be<br/>
    ///        unequipped automatically by the call to ActionEquipItem.<br/>
    /// <br/>
    ///        In order for ActionEquipItem to succeed the creature must be able to equip the<br/>
    ///        item oItem normally. This means that:<br/>
    ///        1) The item is in the creature&amp;apos;s inventory.<br/>
    ///        2) The item must already be identified (if magical).<br/>
    ///        3) The creature has the level required to equip the item (if magical and ILR is on).<br/>
    ///        4) The creature possesses the required feats to equip the item (such as weapon proficiencies).
    public static void ActionEquipItem(uint oItem, int nInventorySlot)
    {
      VM.StackPush(nInventorySlot);
      VM.StackPush(oItem);
      VM.Call(32);
    }

    ///  Unequip oItem from whatever slot it is currently in.
    public static void ActionUnequipItem(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(33);
    }

    ///  Pick up oItem from the ground.<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;ActionPickUpItem failed.&amp;quot;
    public static void ActionPickUpItem(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(34);
    }

    ///  Put down oItem on the ground.<br/>
    ///  * No return value, but if an error occurs the log file will contain<br/>
    ///    &amp;quot;ActionPutDownItem failed.&amp;quot;
    public static void ActionPutDownItem(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(35);
    }

    ///  Get the last attacker of oAttackee.  This should only be used ONLY in the<br/>
    ///  OnAttacked events for creatures, placeables and doors.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetLastAttacker(uint oAttackee = OBJECT_INVALID)
    {
      VM.StackPush(oAttackee);
      VM.Call(36);
      return VM.StackPopObject();
    }

    ///  Attack oAttackee.<br/>
    ///  - bPassive: If this is TRUE, attack is in passive mode.
    public static void ActionAttack(uint oAttackee, int bPassive = FALSE)
    {
      VM.StackPush(bPassive);
      VM.StackPush(oAttackee);
      VM.Call(37);
    }

    ///  Get the creature nearest to oTarget, subject to all the criteria specified.<br/>
    ///  - nFirstCriteriaType: CREATURE_TYPE_*<br/>
    ///  - nFirstCriteriaValue:<br/>
    ///    -&amp;gt; CLASS_TYPE_* if nFirstCriteriaType was CREATURE_TYPE_CLASS<br/>
    ///    -&amp;gt; SPELL_* if nFirstCriteriaType was CREATURE_TYPE_DOES_NOT_HAVE_SPELL_EFFECT<br/>
    ///       or CREATURE_TYPE_HAS_SPELL_EFFECT<br/>
    ///    -&amp;gt; TRUE or FALSE if nFirstCriteriaType was CREATURE_TYPE_IS_ALIVE<br/>
    ///    -&amp;gt; PERCEPTION_* if nFirstCriteriaType was CREATURE_TYPE_PERCEPTION<br/>
    ///    -&amp;gt; PLAYER_CHAR_IS_PC or PLAYER_CHAR_NOT_PC if nFirstCriteriaType was<br/>
    ///       CREATURE_TYPE_PLAYER_CHAR<br/>
    ///    -&amp;gt; RACIAL_TYPE_* if nFirstCriteriaType was CREATURE_TYPE_RACIAL_TYPE<br/>
    ///    -&amp;gt; REPUTATION_TYPE_* if nFirstCriteriaType was CREATURE_TYPE_REPUTATION<br/>
    ///    For example, to get the nearest PC, use:<br/>
    ///    (CREATURE_TYPE_PLAYER_CHAR, PLAYER_CHAR_IS_PC)<br/>
    ///  - oTarget: We&amp;apos;re trying to find the creature of the specified type that is<br/>
    ///    nearest to oTarget<br/>
    ///  - nNth: We don&amp;apos;t have to find the first nearest: we can find the Nth nearest...<br/>
    ///  - nSecondCriteriaType: This is used in the same way as nFirstCriteriaType to<br/>
    ///    further specify the type of creature that we are looking for.<br/>
    ///  - nSecondCriteriaValue: This is used in the same way as nFirstCriteriaValue<br/>
    ///    to further specify the type of creature that we are looking for.<br/>
    ///  - nThirdCriteriaType: This is used in the same way as nFirstCriteriaType to<br/>
    ///    further specify the type of creature that we are looking for.<br/>
    ///  - nThirdCriteriaValue: This is used in the same way as nFirstCriteriaValue to<br/>
    ///    further specify the type of creature that we are looking for.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetNearestCreature(int nFirstCriteriaType, int nFirstCriteriaValue, uint oTarget = OBJECT_INVALID, int nNth = 1, int nSecondCriteriaType = -1, int nSecondCriteriaValue = -1, int nThirdCriteriaType = -1, int nThirdCriteriaValue = -1)
    {
      VM.StackPush(nThirdCriteriaValue);
      VM.StackPush(nThirdCriteriaType);
      VM.StackPush(nSecondCriteriaValue);
      VM.StackPush(nSecondCriteriaType);
      VM.StackPush(nNth);
      VM.StackPush(oTarget);
      VM.StackPush(nFirstCriteriaValue);
      VM.StackPush(nFirstCriteriaType);
      VM.Call(38);
      return VM.StackPopObject();
    }

    ///  Add a speak action to the action subject.<br/>
    ///  - sStringToSpeak: String to be spoken<br/>
    ///  - nTalkVolume: TALKVOLUME_*
    public static void ActionSpeakString(string sStringToSpeak, int nTalkVolume = TALKVOLUME_TALK)
    {
      VM.StackPush(nTalkVolume);
      VM.StackPush(sStringToSpeak);
      VM.Call(39);
    }

    ///  Cause the action subject to play an animation<br/>
    ///  - nAnimation: ANIMATION_*<br/>
    ///  - fSpeed: Speed of the animation<br/>
    ///  - fDurationSeconds: Duration of the animation (this is not used for Fire and<br/>
    ///    Forget animations)
    public static void ActionPlayAnimation(int nAnimation, float fSpeed = 1.0f, float fDurationSeconds = 0.0f)
    {
      VM.StackPush(fDurationSeconds);
      VM.StackPush(fSpeed);
      VM.StackPush(nAnimation);
      VM.Call(40);
    }

    ///  Get the distance from the caller to oObject in metres.<br/>
    ///  * Return value on error: -1.0f
    public static float GetDistanceToObject(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(41);
      return VM.StackPopFloat();
    }

    ///  * Returns TRUE if oObject is a valid object.
    public static int GetIsObjectValid(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(42);
      return VM.StackPopInt();
    }

    ///  Cause the action subject to open oDoor
    public static void ActionOpenDoor(uint oDoor)
    {
      VM.StackPush(oDoor);
      VM.Call(43);
    }

    ///  Cause the action subject to close oDoor
    public static void ActionCloseDoor(uint oDoor)
    {
      VM.StackPush(oDoor);
      VM.Call(44);
    }

    ///  Change the direction in which the camera is facing<br/>
    ///  - fDirection is expressed as anticlockwise degrees from Due East.<br/>
    ///    (0.0f=East, 90.0f=North, 180.0f=West, 270.0f=South)<br/>
    ///  A value of -1.0f for any parameter will be ignored and instead it will<br/>
    ///  use the current camera value.<br/>
    ///  This can be used to change the way the camera is facing after the player<br/>
    ///  emerges from an area transition.<br/>
    ///  - nTransitionType: CAMERA_TRANSITION_TYPE_*  SNAP will immediately move the<br/>
    ///    camera to the new position, while the other types will result in the camera moving gradually into position<br/>
    ///  Pitch and distance are limited to valid values for the current camera mode:<br/>
    ///  Top Down: Distance = 5-20, Pitch = 1-50<br/>
    ///  Driving camera: Distance = 6 (can&amp;apos;t be changed), Pitch = 1-62<br/>
    ///  Chase: Distance = 5-20, Pitch = 1-50<br/>
    ///  *** NOTE *** In NWN:Hordes of the Underdark the camera limits have been relaxed to the following:<br/>
    ///  Distance 1-25<br/>
    ///  Pitch 1-89
    public static void SetCameraFacing(float fDirection, float fDistance = -1.0f, float fPitch = -1.0f, int nTransitionType = CAMERA_TRANSITION_TYPE_SNAP)
    {
      VM.StackPush(nTransitionType);
      VM.StackPush(fPitch);
      VM.StackPush(fDistance);
      VM.StackPush(fDirection);
      VM.Call(45);
    }

    ///  Play sSoundName<br/>
    ///  - sSoundName: TBD - SS<br/>
    ///  This will play a mono sound from the location of the object running the command.
    public static void PlaySound(string sSoundName)
    {
      VM.StackPush(sSoundName);
      VM.Call(46);
    }

    ///  Get the object at which the caller last cast a spell<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetSpellTargetObject()
    {
      VM.Call(47);
      return VM.StackPopObject();
    }

    ///  This action casts a spell at oTarget.<br/>
    ///  - nSpell: SPELL_*<br/>
    ///  - oTarget: Target for the spell<br/>
    ///  - nMetamagic: METAMAGIC_*<br/>
    ///  - bCheat: If this is TRUE, then the executor of the action doesn&amp;apos;t have to be<br/>
    ///    able to cast the spell.<br/>
    ///  - nDomainLevel: TBD - SS<br/>
    ///  - nProjectilePathType: PROJECTILE_PATH_TYPE_*<br/>
    ///  - bInstantSpell: If this is TRUE, the spell is cast immediately. This allows<br/>
    ///    the end-user to simulate a high-level magic-user having lots of advance<br/>
    ///    warning of impending trouble
    public static void ActionCastSpellAtObject(int nSpell, uint oTarget, int nMetaMagic = METAMAGIC_ANY, int bCheat = FALSE, int nDomainLevel = 0, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT, int bInstantSpell = FALSE)
    {
      VM.StackPush(bInstantSpell);
      VM.StackPush(nProjectilePathType);
      VM.StackPush(nDomainLevel);
      VM.StackPush(bCheat);
      VM.StackPush(nMetaMagic);
      VM.StackPush(oTarget);
      VM.StackPush(nSpell);
      VM.Call(48);
    }

    ///  Get the current hitpoints of oObject<br/>
    ///  * Return value on error: 0
    public static int GetCurrentHitPoints(uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.Call(49);
      return VM.StackPopInt();
    }

    ///  Get the maximum hitpoints of oObject<br/>
    ///  * Return value on error: 0
    public static int GetMaxHitPoints(uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.Call(50);
      return VM.StackPopInt();
    }

    ///  Get oObject&amp;apos;s local integer variable sVarName<br/>
    ///  * Return value on error: 0
    public static int GetLocalInt(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(51);
      return VM.StackPopInt();
    }

    ///  Get oObject&amp;apos;s local float variable sVarName<br/>
    ///  * Return value on error: 0.0f
    public static float GetLocalFloat(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(52);
      return VM.StackPopFloat();
    }

    ///  Get oObject&amp;apos;s local string variable sVarName<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string GetLocalString(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(53);
      return VM.StackPopString();
    }

    ///  Get oObject&amp;apos;s local object variable sVarName<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetLocalObject(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(54);
      return VM.StackPopObject();
    }

    ///  Set oObject&amp;apos;s local integer variable sVarName to nValue
    public static void SetLocalInt(uint oObject, string sVarName, int nValue)
    {
      VM.StackPush(nValue);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(55);
    }

    ///  Set oObject&amp;apos;s local float variable sVarName to nValue
    public static void SetLocalFloat(uint oObject, string sVarName, float fValue)
    {
      VM.StackPush(fValue);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(56);
    }

    ///  Set oObject&amp;apos;s local string variable sVarName to nValue
    public static void SetLocalString(uint oObject, string sVarName, string sValue)
    {
      VM.StackPush(sValue);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(57);
    }

    ///  Set oObject&amp;apos;s local object variable sVarName to nValue
    public static void SetLocalObject(uint oObject, string sVarName, uint oValue)
    {
      VM.StackPush(oValue);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(58);
    }

    ///  Get the length of sString<br/>
    ///  * Return value on error: -1
    public static int GetStringLength(string sString)
    {
      VM.StackPush(sString);
      VM.Call(59);
      return VM.StackPopInt();
    }

    ///  Convert sString into upper case<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string GetStringUpperCase(string sString)
    {
      VM.StackPush(sString);
      VM.Call(60);
      return VM.StackPopString();
    }

    ///  Convert sString into lower case<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string GetStringLowerCase(string sString)
    {
      VM.StackPush(sString);
      VM.Call(61);
      return VM.StackPopString();
    }

    ///  Get nCount characters from the right end of sString<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string GetStringRight(string sString, int nCount)
    {
      VM.StackPush(nCount);
      VM.StackPush(sString);
      VM.Call(62);
      return VM.StackPopString();
    }

    ///  Get nCounter characters from the left end of sString<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string GetStringLeft(string sString, int nCount)
    {
      VM.StackPush(nCount);
      VM.StackPush(sString);
      VM.Call(63);
      return VM.StackPopString();
    }

    ///  Insert sString into sDestination at nPosition<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string InsertString(string sDestination, string sString, int nPosition)
    {
      VM.StackPush(nPosition);
      VM.StackPush(sString);
      VM.StackPush(sDestination);
      VM.Call(64);
      return VM.StackPopString();
    }

    ///  Get nCount characters from sString, starting at nStart<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string GetSubString(string sString, int nStart, int nCount)
    {
      VM.StackPush(nCount);
      VM.StackPush(nStart);
      VM.StackPush(sString);
      VM.Call(65);
      return VM.StackPopString();
    }

    ///  Find the position of sSubstring inside sString<br/>
    ///  - nStart: The character position to start searching at (from the left end of the string).<br/>
    ///  * Return value on error: -1
    public static int FindSubString(string sString, string sSubString, int nStart = 0)
    {
      VM.StackPush(nStart);
      VM.StackPush(sSubString);
      VM.StackPush(sString);
      VM.Call(66);
      return VM.StackPopInt();
    }

    ///  math operations<br/>
    ///  Maths operation: absolute value of fValue
    public static float fabs(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(67);
      return VM.StackPopFloat();
    }

    ///  Maths operation: cosine of fValue
    public static float cos(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(68);
      return VM.StackPopFloat();
    }

    ///  Maths operation: sine of fValue
    public static float sin(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(69);
      return VM.StackPopFloat();
    }

    ///  Maths operation: tan of fValue
    public static float tan(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(70);
      return VM.StackPopFloat();
    }

    ///  Maths operation: arccosine of fValue<br/>
    ///  * Returns zero if fValue &amp;gt; 1 or fValue &amp;lt; -1
    public static float acos(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(71);
      return VM.StackPopFloat();
    }

    ///  Maths operation: arcsine of fValue<br/>
    ///  * Returns zero if fValue &amp;gt;1 or fValue &amp;lt; -1
    public static float asin(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(72);
      return VM.StackPopFloat();
    }

    ///  Maths operation: arctan of fValue
    public static float atan(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(73);
      return VM.StackPopFloat();
    }

    ///  Maths operation: log of fValue<br/>
    ///  * Returns zero if fValue &amp;lt;= zero
    public static float log(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(74);
      return VM.StackPopFloat();
    }

    ///  Maths operation: fValue is raised to the power of fExponent<br/>
    ///  * Returns zero if fValue ==0 and fExponent &amp;lt;0
    public static float pow(float fValue, float fExponent)
    {
      VM.StackPush(fExponent);
      VM.StackPush(fValue);
      VM.Call(75);
      return VM.StackPopFloat();
    }

    ///  Maths operation: square root of fValue<br/>
    ///  * Returns zero if fValue &amp;lt;0
    public static float sqrt(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(76);
      return VM.StackPopFloat();
    }

    ///  Maths operation: integer absolute value of nValue<br/>
    ///  * Return value on error: 0
    public static int abs(int nValue)
    {
      VM.StackPush(nValue);
      VM.Call(77);
      return VM.StackPopInt();
    }

    ///  Create a Heal effect. This should be applied as an instantaneous effect.<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nDamageToHeal &amp;lt; 0.
    public static System.IntPtr EffectHeal(int nDamageToHeal)
    {
      VM.StackPush(nDamageToHeal);
      VM.Call(78);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Damage effect<br/>
    ///  - nDamageAmount: amount of damage to be dealt. This should be applied as an<br/>
    ///    instantaneous effect.<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///  - nDamagePower: DAMAGE_POWER_*
    public static System.IntPtr EffectDamage(int nDamageAmount, int nDamageType = DAMAGE_TYPE_MAGICAL, int nDamagePower = DAMAGE_POWER_NORMAL)
    {
      VM.StackPush(nDamagePower);
      VM.StackPush(nDamageType);
      VM.StackPush(nDamageAmount);
      VM.Call(79);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an Ability Increase effect<br/>
    ///  - bAbilityToIncrease: ABILITY_*
    public static System.IntPtr EffectAbilityIncrease(int nAbilityToIncrease, int nModifyBy)
    {
      VM.StackPush(nModifyBy);
      VM.StackPush(nAbilityToIncrease);
      VM.Call(80);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Damage Resistance effect that removes the first nAmount points of<br/>
    ///  damage of type nDamageType, up to nLimit (or infinite if nLimit is 0)<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///  - nAmount<br/>
    ///  - nLimit
    public static System.IntPtr EffectDamageResistance(int nDamageType, int nAmount, int nLimit = 0)
    {
      VM.StackPush(nLimit);
      VM.StackPush(nAmount);
      VM.StackPush(nDamageType);
      VM.Call(81);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Resurrection effect. This should be applied as an instantaneous effect.
    public static System.IntPtr EffectResurrection()
    {
      VM.Call(82);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Summon Creature effect.  The creature is created and placed into the<br/>
    ///  caller&amp;apos;s party/faction.<br/>
    ///  - sCreatureResref: Identifies the creature to be summoned<br/>
    ///  - nVisualEffectId: VFX_*<br/>
    ///  - fDelaySeconds: There can be delay between the visual effect being played, and the<br/>
    ///    creature being added to the area<br/>
    ///  - nUseAppearAnimation: should this creature play it&amp;apos;s &amp;quot;appear&amp;quot; animation when it is<br/>
    ///    summoned. If zero, it will just fade in somewhere near the target.  If the value is 1<br/>
    ///    it will use the appear animation, and if it&amp;apos;s 2 it will use appear2 (which doesn&amp;apos;t exist for most creatures)
    public static System.IntPtr EffectSummonCreature(string sCreatureResref, int nVisualEffectId = VFX_NONE, float fDelaySeconds = 0.0f, int nUseAppearAnimation = 0)
    {
      VM.StackPush(nUseAppearAnimation);
      VM.StackPush(fDelaySeconds);
      VM.StackPush(nVisualEffectId);
      VM.StackPush(sCreatureResref);
      VM.Call(83);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the level at which this creature cast it&amp;apos;s last spell (or spell-like ability)<br/>
    ///  * Return value on error, or if oCreature has not yet cast a spell: 0;
    public static int GetCasterLevel(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(84);
      return VM.StackPopInt();
    }

    ///  Get the first in-game effect on oCreature.
    public static System.IntPtr GetFirstEffect(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(85);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the next in-game effect on oCreature.
    public static System.IntPtr GetNextEffect(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(86);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Remove eEffect from oCreature.<br/>
    ///  * No return value
    public static void RemoveEffect(uint oCreature, System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.StackPush(oCreature);
      VM.Call(87);
    }

    ///  * Returns TRUE if eEffect is a valid effect. The effect must have been applied to<br/>
    ///  * an object or else it will return FALSE
    public static int GetIsEffectValid(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(88);
      return VM.StackPopInt();
    }

    ///  Get the duration type (DURATION_TYPE_*) of eEffect.<br/>
    ///  * Return value if eEffect is not valid: -1
    public static int GetEffectDurationType(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(89);
      return VM.StackPopInt();
    }

    ///  Get the subtype (SUBTYPE_*) of eEffect.<br/>
    ///  * Return value on error: 0
    public static int GetEffectSubType(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(90);
      return VM.StackPopInt();
    }

    ///  Get the object that created eEffect.<br/>
    ///  * Returns OBJECT_INVALID if eEffect is not a valid effect.
    public static uint GetEffectCreator(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(91);
      return VM.StackPopObject();
    }

    ///  Convert nInteger into a string.<br/>
    ///  * Return value on error: &amp;quot;&amp;quot;
    public static string IntToString(int nInteger)
    {
      VM.StackPush(nInteger);
      VM.Call(92);
      return VM.StackPopString();
    }

    ///  Get the first object in oArea.<br/>
    ///  If no valid area is specified, it will use the caller&amp;apos;s area.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetFirstObjectInArea(uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.Call(93);
      return VM.StackPopObject();
    }

    ///  Get the next object in oArea.<br/>
    ///  If no valid area is specified, it will use the caller&amp;apos;s area.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetNextObjectInArea(uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.Call(94);
      return VM.StackPopObject();
    }

    ///  Get the total from rolling (nNumDice x d2 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d2(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(95);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d3 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d3(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(96);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d4 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d4(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(97);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d6 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d6(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(98);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d8 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d8(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(99);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d10 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d10(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(100);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d12 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d12(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(101);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d20 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d20(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(102);
      return VM.StackPopInt();
    }

    ///  Get the total from rolling (nNumDice x d100 dice).<br/>
    ///  - nNumDice: If this is less than 1, the value 1 will be used.
    public static int d100(int nNumDice = 1)
    {
      VM.StackPush(nNumDice);
      VM.Call(103);
      return VM.StackPopInt();
    }

    ///  Get the magnitude of vVector; this can be used to determine the<br/>
    ///  distance between two points.<br/>
    ///  * Return value on error: 0.0f
    public static float VectorMagnitude(System.Numerics.Vector3 vVector)
    {
      VM.StackPush(vVector);
      VM.Call(104);
      return VM.StackPopFloat();
    }

    ///  Get the metamagic type (METAMAGIC_*) of the last spell cast by the caller<br/>
    ///  * Return value if the caster is not a valid object: -1
    public static int GetMetaMagicFeat()
    {
      VM.Call(105);
      return VM.StackPopInt();
    }

    ///  Get the object type (OBJECT_TYPE_*) of oTarget<br/>
    ///  * Return value if oTarget is not a valid object: -1
    public static int GetObjectType(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(106);
      return VM.StackPopInt();
    }

    ///  Get the racial type (RACIAL_TYPE_*) of oCreature<br/>
    ///  * Return value if oCreature is not a valid creature: RACIAL_TYPE_INVALID
    public static int GetRacialType(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(107);
      return VM.StackPopInt();
    }

    ///  Do a Fortitude Save check for the given DC<br/>
    ///  - oCreature<br/>
    ///  - nDC: Difficulty check<br/>
    ///  - nSaveType: SAVING_THROW_TYPE_*<br/>
    ///  - oSaveVersus<br/>
    ///  Returns: 0 if the saving throw roll failed<br/>
    ///  Returns: 1 if the saving throw roll succeeded<br/>
    ///  Returns: 2 if the target was immune to the save type specified<br/>
    ///  Note: If used within an Area of Effect Object Script (On Enter, OnExit, OnHeartbeat), you MUST pass<br/>
    ///  GetAreaOfEffectCreator() into oSaveVersus!!
    public static int FortitudeSave(uint oCreature, int nDC, int nSaveType = SAVING_THROW_TYPE_NONE, uint oSaveVersus = OBJECT_INVALID)
    {
      VM.StackPush(oSaveVersus);
      VM.StackPush(nSaveType);
      VM.StackPush(nDC);
      VM.StackPush(oCreature);
      VM.Call(108);
      return VM.StackPopInt();
    }

    ///  Does a Reflex Save check for the given DC<br/>
    ///  - oCreature<br/>
    ///  - nDC: Difficulty check<br/>
    ///  - nSaveType: SAVING_THROW_TYPE_*<br/>
    ///  - oSaveVersus<br/>
    ///  Returns: 0 if the saving throw roll failed<br/>
    ///  Returns: 1 if the saving throw roll succeeded<br/>
    ///  Returns: 2 if the target was immune to the save type specified<br/>
    ///  Note: If used within an Area of Effect Object Script (On Enter, OnExit, OnHeartbeat), you MUST pass<br/>
    ///  GetAreaOfEffectCreator() into oSaveVersus!!
    public static int ReflexSave(uint oCreature, int nDC, int nSaveType = SAVING_THROW_TYPE_NONE, uint oSaveVersus = OBJECT_INVALID)
    {
      VM.StackPush(oSaveVersus);
      VM.StackPush(nSaveType);
      VM.StackPush(nDC);
      VM.StackPush(oCreature);
      VM.Call(109);
      return VM.StackPopInt();
    }

    ///  Does a Will Save check for the given DC<br/>
    ///  - oCreature<br/>
    ///  - nDC: Difficulty check<br/>
    ///  - nSaveType: SAVING_THROW_TYPE_*<br/>
    ///  - oSaveVersus<br/>
    ///  Returns: 0 if the saving throw roll failed<br/>
    ///  Returns: 1 if the saving throw roll succeeded<br/>
    ///  Returns: 2 if the target was immune to the save type specified<br/>
    ///  Note: If used within an Area of Effect Object Script (On Enter, OnExit, OnHeartbeat), you MUST pass<br/>
    ///  GetAreaOfEffectCreator() into oSaveVersus!!
    public static int WillSave(uint oCreature, int nDC, int nSaveType = SAVING_THROW_TYPE_NONE, uint oSaveVersus = OBJECT_INVALID)
    {
      VM.StackPush(oSaveVersus);
      VM.StackPush(nSaveType);
      VM.StackPush(nDC);
      VM.StackPush(oCreature);
      VM.Call(110);
      return VM.StackPopInt();
    }

    ///  Get the DC to save against for a spell (10 + spell level + relevant ability<br/>
    ///  bonus).  This can be called by a creature or by an Area of Effect object.
    public static int GetSpellSaveDC()
    {
      VM.Call(111);
      return VM.StackPopInt();
    }

    ///  Set the subtype of eEffect to Magical and return eEffect.<br/>
    ///  (Effects default to magical if the subtype is not set)<br/>
    ///  Magical effects are removed by resting, and by dispel magic
    public static System.IntPtr MagicalEffect(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(112);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Set the subtype of eEffect to Supernatural and return eEffect.<br/>
    ///  (Effects default to magical if the subtype is not set)<br/>
    ///  Permanent supernatural effects are not removed by resting
    public static System.IntPtr SupernaturalEffect(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(113);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Set the subtype of eEffect to Extraordinary and return eEffect.<br/>
    ///  (Effects default to magical if the subtype is not set)<br/>
    ///  Extraordinary effects are removed by resting, but not by dispel magic
    public static System.IntPtr ExtraordinaryEffect(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(114);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an AC Increase effect<br/>
    ///  - nValue: size of AC increase<br/>
    ///  - nModifyType: AC_*_BONUS<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///    * Default value for nDamageType should only ever be used in this function prototype.
    public static System.IntPtr EffectACIncrease(int nValue, int nModifyType = AC_DODGE_BONUS, int nDamageType = AC_VS_DAMAGE_TYPE_ALL)
    {
      VM.StackPush(nDamageType);
      VM.StackPush(nModifyType);
      VM.StackPush(nValue);
      VM.Call(115);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  If oObject is a creature, this will return that creature&amp;apos;s armour class<br/>
    ///  If oObject is an item, door or placeable, this will return zero.<br/>
    ///  - nForFutureUse: this parameter is not currently used<br/>
    ///  * Return value if oObject is not a creature, item, door or placeable: -1
    public static int GetAC(uint oObject, int nForFutureUse = 0)
    {
      VM.StackPush(nForFutureUse);
      VM.StackPush(oObject);
      VM.Call(116);
      return VM.StackPopInt();
    }

    ///  Create a Saving Throw Increase effect<br/>
    ///  - nSave: SAVING_THROW_* (not SAVING_THROW_TYPE_*)<br/>
    ///           SAVING_THROW_ALL<br/>
    ///           SAVING_THROW_FORT<br/>
    ///           SAVING_THROW_REFLEX<br/>
    ///           SAVING_THROW_WILL<br/>
    ///  - nValue: size of the Saving Throw increase<br/>
    ///  - nSaveType: SAVING_THROW_TYPE_* (e.g. SAVING_THROW_TYPE_ACID )
    public static System.IntPtr EffectSavingThrowIncrease(int nSave, int nValue, int nSaveType = SAVING_THROW_TYPE_ALL)
    {
      VM.StackPush(nSaveType);
      VM.StackPush(nValue);
      VM.StackPush(nSave);
      VM.Call(117);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an Attack Increase effect<br/>
    ///  - nBonus: size of attack bonus<br/>
    ///  - nModifierType: ATTACK_BONUS_*
    public static System.IntPtr EffectAttackIncrease(int nBonus, int nModifierType = ATTACK_BONUS_MISC)
    {
      VM.StackPush(nModifierType);
      VM.StackPush(nBonus);
      VM.Call(118);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Damage Reduction effect<br/>
    ///  - nAmount: amount of damage reduction<br/>
    ///  - nDamagePower: DAMAGE_POWER_*<br/>
    ///  - nLimit: How much damage the effect can absorb before disappearing.<br/>
    ///    Set to zero for infinite
    public static System.IntPtr EffectDamageReduction(int nAmount, int nDamagePower, int nLimit = 0)
    {
      VM.StackPush(nLimit);
      VM.StackPush(nDamagePower);
      VM.StackPush(nAmount);
      VM.Call(119);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Damage Increase effect<br/>
    ///  - nBonus: DAMAGE_BONUS_*<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///  NOTE! You *must* use the DAMAGE_BONUS_* constants! Using other values may<br/>
    ///        result in odd behaviour.
    public static System.IntPtr EffectDamageIncrease(int nBonus, int nDamageType = DAMAGE_TYPE_MAGICAL)
    {
      VM.StackPush(nDamageType);
      VM.StackPush(nBonus);
      VM.Call(120);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Convert nRounds into a number of seconds<br/>
    ///  A round is always 6.0 seconds
    public static float RoundsToSeconds(int nRounds)
    {
      VM.StackPush(nRounds);
      VM.Call(121);
      return VM.StackPopFloat();
    }

    ///  Convert nHours into a number of seconds<br/>
    ///  The result will depend on how many minutes there are per hour (game-time)
    public static float HoursToSeconds(int nHours)
    {
      VM.StackPush(nHours);
      VM.Call(122);
      return VM.StackPopFloat();
    }

    ///  Convert nTurns into a number of seconds<br/>
    ///  A turn is always 60.0 seconds
    public static float TurnsToSeconds(int nTurns)
    {
      VM.StackPush(nTurns);
      VM.Call(123);
      return VM.StackPopFloat();
    }

    ///  Get an integer between 0 and 100 (inclusive) to represent oCreature&amp;apos;s<br/>
    ///  Law/Chaos alignment<br/>
    ///  (100=law, 0=chaos)<br/>
    ///  * Return value if oCreature is not a valid creature: -1
    public static int GetLawChaosValue(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(124);
      return VM.StackPopInt();
    }

    ///  Get an integer between 0 and 100 (inclusive) to represent oCreature&amp;apos;s<br/>
    ///  Good/Evil alignment<br/>
    ///  (100=good, 0=evil)<br/>
    ///  * Return value if oCreature is not a valid creature: -1
    public static int GetGoodEvilValue(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(125);
      return VM.StackPopInt();
    }

    ///  Return an ALIGNMENT_* constant to represent oCreature&amp;apos;s law/chaos alignment<br/>
    ///  * Return value if oCreature is not a valid creature: -1
    public static int GetAlignmentLawChaos(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(126);
      return VM.StackPopInt();
    }

    ///  Return an ALIGNMENT_* constant to represent oCreature&amp;apos;s good/evil alignment<br/>
    ///  * Return value if oCreature is not a valid creature: -1
    public static int GetAlignmentGoodEvil(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(127);
      return VM.StackPopInt();
    }

    ///  Get the first object in nShape<br/>
    ///  - nShape: SHAPE_*<br/>
    ///  - fSize:<br/>
    ///    -&amp;gt; If nShape == SHAPE_SPHERE, this is the radius of the sphere<br/>
    ///    -&amp;gt; If nShape == SHAPE_SPELLCYLINDER, this is the length of the cylinder<br/>
    ///       Spell Cylinder&amp;apos;s always have a radius of 1.5m.<br/>
    ///    -&amp;gt; If nShape == SHAPE_CONE, this is the widest radius of the cone<br/>
    ///    -&amp;gt; If nShape == SHAPE_SPELLCONE, this is the length of the cone in the<br/>
    ///       direction of lTarget. Spell cones are always 60 degrees with the origin<br/>
    ///       at OBJECT_SELF.<br/>
    ///    -&amp;gt; If nShape == SHAPE_CUBE, this is half the length of one of the sides of<br/>
    ///       the cube<br/>
    ///  - lTarget: This is the centre of the effect, usually GetSpellTargetLocation(),<br/>
    ///    or the end of a cylinder or cone.<br/>
    ///  - bLineOfSight: This controls whether to do a line-of-sight check on the<br/>
    ///    object returned. Line of sight check is done from origin to target object<br/>
    ///    at a height 1m above the ground<br/>
    ///    (This can be used to ensure that spell effects do not go through walls.)<br/>
    ///  - nObjectFilter: This allows you to filter out undesired object types, using<br/>
    ///    bitwise &amp;quot;or&amp;quot;.<br/>
    ///    For example, to return only creatures and doors, the value for this<br/>
    ///    parameter would be OBJECT_TYPE_CREATURE | OBJECT_TYPE_DOOR<br/>
    ///  - vOrigin: This is only used for cylinders and cones, and specifies the<br/>
    ///    origin of the effect(normally the spell-caster&amp;apos;s position).<br/>
    ///  Return value on error: OBJECT_INVALID
    public static uint GetFirstObjectInShape(int nShape, float fSize, System.IntPtr lTarget, int bLineOfSight = FALSE, int nObjectFilter = OBJECT_TYPE_CREATURE, System.Numerics.Vector3 vOrigin = default)
    {
      VM.StackPush(vOrigin);
      VM.StackPush(nObjectFilter);
      VM.StackPush(bLineOfSight);
      VM.StackPush(lTarget, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(fSize);
      VM.StackPush(nShape);
      VM.Call(128);
      return VM.StackPopObject();
    }

    ///  Get the next object in nShape<br/>
    ///  - nShape: SHAPE_*<br/>
    ///  - fSize:<br/>
    ///    -&amp;gt; If nShape == SHAPE_SPHERE, this is the radius of the sphere<br/>
    ///    -&amp;gt; If nShape == SHAPE_SPELLCYLINDER, this is the length of the cylinder.<br/>
    ///       Spell Cylinder&amp;apos;s always have a radius of 1.5m.<br/>
    ///    -&amp;gt; If nShape == SHAPE_CONE, this is the widest radius of the cone<br/>
    ///    -&amp;gt; If nShape == SHAPE_SPELLCONE, this is the length of the cone in the<br/>
    ///       direction of lTarget. Spell cones are always 60 degrees with the origin<br/>
    ///       at OBJECT_SELF.<br/>
    ///    -&amp;gt; If nShape == SHAPE_CUBE, this is half the length of one of the sides of<br/>
    ///       the cube<br/>
    ///  - lTarget: This is the centre of the effect, usually GetSpellTargetLocation(),<br/>
    ///    or the end of a cylinder or cone.<br/>
    ///  - bLineOfSight: This controls whether to do a line-of-sight check on the<br/>
    ///    object returned. (This can be used to ensure that spell effects do not go<br/>
    ///    through walls.) Line of sight check is done from origin to target object<br/>
    ///    at a height 1m above the ground<br/>
    ///  - nObjectFilter: This allows you to filter out undesired object types, using<br/>
    ///    bitwise &amp;quot;or&amp;quot;. For example, to return only creatures and doors, the value for<br/>
    ///    this parameter would be OBJECT_TYPE_CREATURE | OBJECT_TYPE_DOOR<br/>
    ///  - vOrigin: This is only used for cylinders and cones, and specifies the origin<br/>
    ///    of the effect (normally the spell-caster&amp;apos;s position).<br/>
    ///  Return value on error: OBJECT_INVALID
    public static uint GetNextObjectInShape(int nShape, float fSize, System.IntPtr lTarget, int bLineOfSight = FALSE, int nObjectFilter = OBJECT_TYPE_CREATURE, System.Numerics.Vector3 vOrigin = default)
    {
      VM.StackPush(vOrigin);
      VM.StackPush(nObjectFilter);
      VM.StackPush(bLineOfSight);
      VM.StackPush(lTarget, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(fSize);
      VM.StackPush(nShape);
      VM.Call(129);
      return VM.StackPopObject();
    }

    ///  Create an Entangle effect<br/>
    ///  When applied, this effect will restrict the creature&amp;apos;s movement and apply a<br/>
    ///  (-2) to all attacks and a -4 to AC.
    public static System.IntPtr EffectEntangle()
    {
      VM.Call(130);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Causes object oObject to run the event evToRun. The script on the object that is<br/>
    ///  associated with the event specified will run.<br/>
    ///  Events can be created using the following event functions:<br/>
    ///     EventActivateItem() - This creates an OnActivateItem module event. The script for handling<br/>
    ///                           this event can be set in Module Properties on the Event Tab.<br/>
    ///     EventConversation() - This creates on OnConversation creature event. The script for handling<br/>
    ///                           this event can be set by viewing the Creature Properties on a<br/>
    ///                           creature and then clicking on the Scripts Tab.<br/>
    ///     EventSpellCastAt()  - This creates an OnSpellCastAt event. The script for handling this<br/>
    ///                           event can be set in the Scripts Tab of the Properties menu<br/>
    ///                           for the object.<br/>
    ///     EventUserDefined()  - This creates on OnUserDefined event. The script for handling this event<br/>
    ///                           can be set in the Scripts Tab of the Properties menu for the object/area/module.
    public static void SignalEvent(uint oObject, System.IntPtr evToRun)
    {
      VM.StackPush(evToRun, ENGINE_STRUCTURE_EVENT);
      VM.StackPush(oObject);
      VM.Call(131);
    }

    ///  Create an event of the type nUserDefinedEventNumber<br/>
    ///  Note: This only creates the event. The event wont actually trigger until SignalEvent()<br/>
    ///  is called using this created UserDefined event as an argument.<br/>
    ///  For example:<br/>
    ///      SignalEvent(oObject, EventUserDefined(9999));<br/>
    ///  Once the event has been signaled. The script associated with the OnUserDefined event will<br/>
    ///  run on the object oObject.<br/>
    /// <br/>
    ///  To specify the OnUserDefined script that should run, view the object&amp;apos;s Properties<br/>
    ///  and click on the Scripts Tab. Then specify a script for the OnUserDefined event.<br/>
    ///  From inside the OnUserDefined script call:<br/>
    ///     GetUserDefinedEventNumber() to retrieve the value of nUserDefinedEventNumber<br/>
    ///     that was used when the event was signaled.
    public static System.IntPtr EventUserDefined(int nUserDefinedEventNumber)
    {
      VM.StackPush(nUserDefinedEventNumber);
      VM.Call(132);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EVENT);
    }

    ///  Create a Death effect<br/>
    ///  - nSpectacularDeath: if this is TRUE, the creature to which this effect is<br/>
    ///    applied will die in an extraordinary fashion<br/>
    ///  - nDisplayFeedback
    public static System.IntPtr EffectDeath(int nSpectacularDeath = FALSE, int nDisplayFeedback = TRUE)
    {
      VM.StackPush(nDisplayFeedback);
      VM.StackPush(nSpectacularDeath);
      VM.Call(133);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Knockdown effect<br/>
    ///  This effect knocks creatures off their feet, they will sit until the effect<br/>
    ///  is removed. This should be applied as a temporary effect with a 3 second<br/>
    ///  duration minimum (1 second to fall, 1 second sitting, 1 second to get up).
    public static System.IntPtr EffectKnockdown()
    {
      VM.Call(134);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Give oItem to oGiveTo<br/>
    ///  If oItem is not a valid item, or oGiveTo is not a valid object, nothing will<br/>
    ///  happen.
    public static void ActionGiveItem(uint oItem, uint oGiveTo)
    {
      VM.StackPush(oGiveTo);
      VM.StackPush(oItem);
      VM.Call(135);
    }

    ///  Take oItem from oTakeFrom<br/>
    ///  If oItem is not a valid item, or oTakeFrom is not a valid object, nothing<br/>
    ///  will happen.
    public static void ActionTakeItem(uint oItem, uint oTakeFrom)
    {
      VM.StackPush(oTakeFrom);
      VM.StackPush(oItem);
      VM.Call(136);
    }

    ///  Normalize vVector
    public static System.Numerics.Vector3 VectorNormalize(System.Numerics.Vector3 vVector)
    {
      VM.StackPush(vVector);
      VM.Call(137);
      return VM.StackPopVector();
    }

    ///  Create a Curse effect.<br/>
    ///  - nStrMod: strength modifier<br/>
    ///  - nDexMod: dexterity modifier<br/>
    ///  - nConMod: constitution modifier<br/>
    ///  - nIntMod: intelligence modifier<br/>
    ///  - nWisMod: wisdom modifier<br/>
    ///  - nChaMod: charisma modifier
    public static System.IntPtr EffectCurse(int nStrMod = 1, int nDexMod = 1, int nConMod = 1, int nIntMod = 1, int nWisMod = 1, int nChaMod = 1)
    {
      VM.StackPush(nChaMod);
      VM.StackPush(nWisMod);
      VM.StackPush(nIntMod);
      VM.StackPush(nConMod);
      VM.StackPush(nDexMod);
      VM.StackPush(nStrMod);
      VM.Call(138);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the ability score of type nAbility for a creature (otherwise 0)<br/>
    ///  - oCreature: the creature whose ability score we wish to find out<br/>
    ///  - nAbilityType: ABILITY_*<br/>
    ///  - nBaseAbilityScore: if set to true will return the base ability score without<br/>
    ///                       bonuses (e.g. ability bonuses granted from equipped items).<br/>
    ///  Return value on error: 0
    public static int GetAbilityScore(uint oCreature, int nAbilityType, int nBaseAbilityScore = FALSE)
    {
      VM.StackPush(nBaseAbilityScore);
      VM.StackPush(nAbilityType);
      VM.StackPush(oCreature);
      VM.Call(139);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if oCreature is a dead NPC, dead PC or a dying PC.
    public static int GetIsDead(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(140);
      return VM.StackPopInt();
    }

    ///  Output vVector to the logfile.<br/>
    ///  - vVector<br/>
    ///  - bPrepend: if this is TRUE, the message will be prefixed with &amp;quot;PRINTVECTOR:&amp;quot;
    public static void PrintVector(System.Numerics.Vector3 vVector, int bPrepend)
    {
      VM.StackPush(bPrepend);
      VM.StackPush(vVector);
      VM.Call(141);
    }

    ///  Create a vector with the specified values for x, y and z
    public static System.Numerics.Vector3 Vector(float x = 0.0f, float y = 0.0f, float z = 0.0f)
    {
      VM.StackPush(z);
      VM.StackPush(y);
      VM.StackPush(x);
      VM.Call(142);
      return VM.StackPopVector();
    }

    ///  Cause the caller to face vTarget
    public static void SetFacingPoint(System.Numerics.Vector3 vTarget)
    {
      VM.StackPush(vTarget);
      VM.Call(143);
    }

    ///  Convert fAngle to a vector
    public static System.Numerics.Vector3 AngleToVector(float fAngle)
    {
      VM.StackPush(fAngle);
      VM.Call(144);
      return VM.StackPopVector();
    }

    ///  Convert vVector to an angle
    public static float VectorToAngle(System.Numerics.Vector3 vVector)
    {
      VM.StackPush(vVector);
      VM.Call(145);
      return VM.StackPopFloat();
    }

    ///  The caller will perform a Melee Touch Attack on oTarget<br/>
    ///  This is not an action, and it assumes the caller is already within range of<br/>
    ///  oTarget<br/>
    ///  * Returns 0 on a miss, 1 on a hit and 2 on a critical hit
    public static int TouchAttackMelee(uint oTarget, int bDisplayFeedback = TRUE)
    {
      VM.StackPush(bDisplayFeedback);
      VM.StackPush(oTarget);
      VM.Call(146);
      return VM.StackPopInt();
    }

    ///  The caller will perform a Ranged Touch Attack on oTarget<br/>
    ///  * Returns 0 on a miss, 1 on a hit and 2 on a critical hit
    public static int TouchAttackRanged(uint oTarget, int bDisplayFeedback = TRUE)
    {
      VM.StackPush(bDisplayFeedback);
      VM.StackPush(oTarget);
      VM.Call(147);
      return VM.StackPopInt();
    }

    ///  Create a Paralyze effect
    public static System.IntPtr EffectParalyze()
    {
      VM.Call(148);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Spell Immunity effect.<br/>
    ///  There is a known bug with this function. There *must* be a parameter specified<br/>
    ///  when this is called (even if the desired parameter is SPELL_ALL_SPELLS),<br/>
    ///  otherwise an effect of type EFFECT_TYPE_INVALIDEFFECT will be returned.<br/>
    ///  - nImmunityToSpell: SPELL_*<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nImmunityToSpell is<br/>
    ///    invalid.
    public static System.IntPtr EffectSpellImmunity(int nImmunityToSpell = SPELL_ALL_SPELLS)
    {
      VM.StackPush(nImmunityToSpell);
      VM.Call(149);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Deaf effect
    public static System.IntPtr EffectDeaf()
    {
      VM.Call(150);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the distance in metres between oObjectA and oObjectB.<br/>
    ///  * Return value if either object is invalid: 0.0f
    public static float GetDistanceBetween(uint oObjectA, uint oObjectB)
    {
      VM.StackPush(oObjectB);
      VM.StackPush(oObjectA);
      VM.Call(151);
      return VM.StackPopFloat();
    }

    ///  Set oObject&amp;apos;s local location variable sVarname to lValue
    public static void SetLocalLocation(uint oObject, string sVarName, System.IntPtr lValue)
    {
      VM.StackPush(lValue, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(152);
    }

    ///  Get oObject&amp;apos;s local location variable sVarname
    public static System.IntPtr GetLocalLocation(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(153);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  Create a Sleep effect
    public static System.IntPtr EffectSleep()
    {
      VM.Call(154);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the object which is in oCreature&amp;apos;s specified inventory slot<br/>
    ///  - nInventorySlot: INVENTORY_SLOT_*<br/>
    ///  - oCreature<br/>
    ///  * Returns OBJECT_INVALID if oCreature is not a valid creature or there is no<br/>
    ///    item in nInventorySlot.
    public static uint GetItemInSlot(int nInventorySlot, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nInventorySlot);
      VM.Call(155);
      return VM.StackPopObject();
    }

    ///  Create a Charm effect
    public static System.IntPtr EffectCharmed()
    {
      VM.Call(156);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Confuse effect
    public static System.IntPtr EffectConfused()
    {
      VM.Call(157);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Frighten effect
    public static System.IntPtr EffectFrightened()
    {
      VM.Call(158);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Dominate effect
    public static System.IntPtr EffectDominated()
    {
      VM.Call(159);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Daze effect
    public static System.IntPtr EffectDazed()
    {
      VM.Call(160);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Stun effect
    public static System.IntPtr EffectStunned()
    {
      VM.Call(161);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Set whether oTarget&amp;apos;s action stack can be modified
    public static void SetCommandable(int bCommandable, uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.StackPush(bCommandable);
      VM.Call(162);
    }

    ///  Determine whether oTarget&amp;apos;s action stack can be modified.
    public static int GetCommandable(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(163);
      return VM.StackPopInt();
    }

    ///  Create a Regenerate effect.<br/>
    ///  - nAmount: amount of damage to be regenerated per time interval<br/>
    ///  - fIntervalSeconds: length of interval in seconds
    public static System.IntPtr EffectRegenerate(int nAmount, float fIntervalSeconds)
    {
      VM.StackPush(fIntervalSeconds);
      VM.StackPush(nAmount);
      VM.Call(164);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Movement Speed Increase effect.<br/>
    ///  - nPercentChange - range 0 through 99<br/>
    ///  eg.<br/>
    ///     0 = no change in speed<br/>
    ///    50 = 50% faster<br/>
    ///    99 = almost twice as fast
    public static System.IntPtr EffectMovementSpeedIncrease(int nPercentChange)
    {
      VM.StackPush(nPercentChange);
      VM.Call(165);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the number of hitdice for oCreature.<br/>
    ///  * Return value if oCreature is not a valid creature: 0
    public static int GetHitDice(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(166);
      return VM.StackPopInt();
    }

    ///  The action subject will follow oFollow until a ClearAllActions() is called.<br/>
    ///  - oFollow: this is the object to be followed<br/>
    ///  - fFollowDistance: follow distance in metres<br/>
    ///  * No return value
    public static void ActionForceFollowObject(uint oFollow, float fFollowDistance = 0.0f)
    {
      VM.StackPush(fFollowDistance);
      VM.StackPush(oFollow);
      VM.Call(167);
    }

    ///  Get the Tag of oObject<br/>
    ///  * Return value if oObject is not a valid object: &amp;quot;&amp;quot;
    public static string GetTag(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(168);
      return VM.StackPopString();
    }

    ///  Do a Spell Resistance check between oCaster and oTarget, returning TRUE if<br/>
    ///  the spell was resisted.<br/>
    ///  * Return value if oCaster or oTarget is an invalid object: FALSE<br/>
    ///  * Return value if spell cast is not a player spell: - 1<br/>
    ///  * Return value if spell resisted: 1<br/>
    ///  * Return value if spell resisted via magic immunity: 2<br/>
    ///  * Return value if spell resisted via spell absorption: 3
    public static int ResistSpell(uint oCaster, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oCaster);
      VM.Call(169);
      return VM.StackPopInt();
    }

    ///  Get the effect type (EFFECT_TYPE_*) of eEffect.<br/>
    ///  * Return value if eEffect is invalid: EFFECT_INVALIDEFFECT
    public static int GetEffectType(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(170);
      return VM.StackPopInt();
    }

    ///  Create an Area Of Effect effect in the area of the creature it is applied to.<br/>
    ///  If the scripts are not specified, default ones will be used.
    public static System.IntPtr EffectAreaOfEffect(int nAreaEffectId, string sOnEnterScript = "", string sHeartbeatScript = "", string sOnExitScript = "")
    {
      VM.StackPush(sOnExitScript);
      VM.StackPush(sHeartbeatScript);
      VM.StackPush(sOnEnterScript);
      VM.StackPush(nAreaEffectId);
      VM.Call(171);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  * Returns TRUE if the Faction Ids of the two objects are the same
    public static int GetFactionEqual(uint oFirstObject, uint oSecondObject = OBJECT_INVALID)
    {
      VM.StackPush(oSecondObject);
      VM.StackPush(oFirstObject);
      VM.Call(172);
      return VM.StackPopInt();
    }

    ///  Make oObjectToChangeFaction join the faction of oMemberOfFactionToJoin.<br/>
    ///  NB. ** This will only work for two NPCs **
    public static void ChangeFaction(uint oObjectToChangeFaction, uint oMemberOfFactionToJoin)
    {
      VM.StackPush(oMemberOfFactionToJoin);
      VM.StackPush(oObjectToChangeFaction);
      VM.Call(173);
    }

    ///  * Returns TRUE if oObject is listening for something
    public static int GetIsListening(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(174);
      return VM.StackPopInt();
    }

    ///  Set whether oObject is listening.
    public static void SetListening(uint oObject, int bValue)
    {
      VM.StackPush(bValue);
      VM.StackPush(oObject);
      VM.Call(175);
    }

    ///  Set the string for oObject to listen for.<br/>
    ///  Note: this does not set oObject to be listening.
    public static void SetListenPattern(uint oObject, string sPattern, int nNumber = 0)
    {
      VM.StackPush(nNumber);
      VM.StackPush(sPattern);
      VM.StackPush(oObject);
      VM.Call(176);
    }

    ///  * Returns TRUE if sStringToTest matches sPattern.
    public static int TestStringAgainstPattern(string sPattern, string sStringToTest)
    {
      VM.StackPush(sStringToTest);
      VM.StackPush(sPattern);
      VM.Call(177);
      return VM.StackPopInt();
    }

    ///  Get the appropriate matched string (this should only be used in<br/>
    ///  OnConversation scripts).<br/>
    ///  * Returns the appropriate matched string, otherwise returns &amp;quot;&amp;quot;
    public static string GetMatchedSubstring(int nString)
    {
      VM.StackPush(nString);
      VM.Call(178);
      return VM.StackPopString();
    }

    ///  Get the number of string parameters available.<br/>
    ///  * Returns -1 if no string matched (this could be because of a dialogue event)
    public static int GetMatchedSubstringsCount()
    {
      VM.Call(179);
      return VM.StackPopInt();
    }

    ///  * Create a Visual Effect that can be applied to an object.<br/>
    ///  - nVisualEffectId<br/>
    ///  - nMissEffect: if this is TRUE, a random vector near or past the target will<br/>
    ///    be generated, on which to play the effect
    public static System.IntPtr EffectVisualEffect(int nVisualEffectId, int nMissEffect = FALSE, float fScale = 1.0f, System.Numerics.Vector3 vTranslate = default, System.Numerics.Vector3 vRotate = default)
    {
      VM.StackPush(vRotate);
      VM.StackPush(vTranslate);
      VM.StackPush(fScale);
      VM.StackPush(nMissEffect);
      VM.StackPush(nVisualEffectId);
      VM.Call(180);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the weakest member of oFactionMember&amp;apos;s faction.<br/>
    ///  * Returns OBJECT_INVALID if oFactionMember&amp;apos;s faction is invalid.
    public static uint GetFactionWeakestMember(uint oFactionMember = OBJECT_INVALID, int bMustBeVisible = TRUE)
    {
      VM.StackPush(bMustBeVisible);
      VM.StackPush(oFactionMember);
      VM.Call(181);
      return VM.StackPopObject();
    }

    ///  Get the strongest member of oFactionMember&amp;apos;s faction.<br/>
    ///  * Returns OBJECT_INVALID if oFactionMember&amp;apos;s faction is invalid.
    public static uint GetFactionStrongestMember(uint oFactionMember = OBJECT_INVALID, int bMustBeVisible = TRUE)
    {
      VM.StackPush(bMustBeVisible);
      VM.StackPush(oFactionMember);
      VM.Call(182);
      return VM.StackPopObject();
    }

    ///  Get the member of oFactionMember&amp;apos;s faction that has taken the most hit points<br/>
    ///  of damage.<br/>
    ///  * Returns OBJECT_INVALID if oFactionMember&amp;apos;s faction is invalid.
    public static uint GetFactionMostDamagedMember(uint oFactionMember = OBJECT_INVALID, int bMustBeVisible = TRUE)
    {
      VM.StackPush(bMustBeVisible);
      VM.StackPush(oFactionMember);
      VM.Call(183);
      return VM.StackPopObject();
    }

    ///  Get the member of oFactionMember&amp;apos;s faction that has taken the fewest hit<br/>
    ///  points of damage.<br/>
    ///  * Returns OBJECT_INVALID if oFactionMember&amp;apos;s faction is invalid.
    public static uint GetFactionLeastDamagedMember(uint oFactionMember = OBJECT_INVALID, int bMustBeVisible = TRUE)
    {
      VM.StackPush(bMustBeVisible);
      VM.StackPush(oFactionMember);
      VM.Call(184);
      return VM.StackPopObject();
    }

    ///  Get the amount of gold held by oFactionMember&amp;apos;s faction.<br/>
    ///  * Returns -1 if oFactionMember&amp;apos;s faction is invalid.
    public static int GetFactionGold(uint oFactionMember)
    {
      VM.StackPush(oFactionMember);
      VM.Call(185);
      return VM.StackPopInt();
    }

    ///  Get an integer between 0 and 100 (inclusive) that represents how<br/>
    ///  oSourceFactionMember&amp;apos;s faction feels about oTarget.<br/>
    ///  * Return value on error: -1
    public static int GetFactionAverageReputation(uint oSourceFactionMember, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oSourceFactionMember);
      VM.Call(186);
      return VM.StackPopInt();
    }

    ///  Get an integer between 0 and 100 (inclusive) that represents the average<br/>
    ///  good/evil alignment of oFactionMember&amp;apos;s faction.<br/>
    ///  * Return value on error: -1
    public static int GetFactionAverageGoodEvilAlignment(uint oFactionMember)
    {
      VM.StackPush(oFactionMember);
      VM.Call(187);
      return VM.StackPopInt();
    }

    ///  Get an integer between 0 and 100 (inclusive) that represents the average<br/>
    ///  law/chaos alignment of oFactionMember&amp;apos;s faction.<br/>
    ///  * Return value on error: -1
    public static int GetFactionAverageLawChaosAlignment(uint oFactionMember)
    {
      VM.StackPush(oFactionMember);
      VM.Call(188);
      return VM.StackPopInt();
    }

    ///  Get the average level of the members of the faction.<br/>
    ///  * Return value on error: -1
    public static int GetFactionAverageLevel(uint oFactionMember)
    {
      VM.StackPush(oFactionMember);
      VM.Call(189);
      return VM.StackPopInt();
    }

    ///  Get the average XP of the members of the faction.<br/>
    ///  * Return value on error: -1
    public static int GetFactionAverageXP(uint oFactionMember)
    {
      VM.StackPush(oFactionMember);
      VM.Call(190);
      return VM.StackPopInt();
    }

    ///  Get the most frequent class in the faction - this can be compared with the<br/>
    ///  constants CLASS_TYPE_*.<br/>
    ///  * Return value on error: -1
    public static int GetFactionMostFrequentClass(uint oFactionMember)
    {
      VM.StackPush(oFactionMember);
      VM.Call(191);
      return VM.StackPopInt();
    }

    ///  Get the object faction member with the lowest armour class.<br/>
    ///  * Returns OBJECT_INVALID if oFactionMember&amp;apos;s faction is invalid.
    public static uint GetFactionWorstAC(uint oFactionMember = OBJECT_INVALID, int bMustBeVisible = TRUE)
    {
      VM.StackPush(bMustBeVisible);
      VM.StackPush(oFactionMember);
      VM.Call(192);
      return VM.StackPopObject();
    }

    ///  Get the object faction member with the highest armour class.<br/>
    ///  * Returns OBJECT_INVALID if oFactionMember&amp;apos;s faction is invalid.
    public static uint GetFactionBestAC(uint oFactionMember = OBJECT_INVALID, int bMustBeVisible = TRUE)
    {
      VM.StackPush(bMustBeVisible);
      VM.StackPush(oFactionMember);
      VM.Call(193);
      return VM.StackPopObject();
    }

    ///  Sit in oChair.<br/>
    ///  Note: Not all creatures will be able to sit and not all<br/>
    ///        objects can be sat on.<br/>
    ///        The object oChair must also be marked as usable in the toolset.<br/>
    /// <br/>
    ///  For Example: To get a player to sit in oChair when they click on it,<br/>
    ///  place the following script in the OnUsed event for the object oChair.<br/>
    ///  void main()<br/>
    ///  {<br/>
    ///     object oChair = OBJECT_SELF;<br/>
    ///     AssignCommand(GetLastUsedBy(),ActionSit(oChair));<br/>
    ///  }
    public static void ActionSit(uint oChair)
    {
      VM.StackPush(oChair);
      VM.Call(194);
    }

    ///  In an onConversation script this gets the number of the string pattern<br/>
    ///  matched (the one that triggered the script).<br/>
    ///  * Returns -1 if no string matched
    public static int GetListenPatternNumber()
    {
      VM.Call(195);
      return VM.StackPopInt();
    }

    ///  Jump to an object ID, or as near to it as possible.
    public static void ActionJumpToObject(uint oToJumpTo, int bWalkStraightLineToPoint = TRUE)
    {
      VM.StackPush(bWalkStraightLineToPoint);
      VM.StackPush(oToJumpTo);
      VM.Call(196);
    }

    ///  Get the first waypoint with the specified tag.<br/>
    ///  * Returns OBJECT_INVALID if the waypoint cannot be found.
    public static uint GetWaypointByTag(string sWaypointTag)
    {
      VM.StackPush(sWaypointTag);
      VM.Call(197);
      return VM.StackPopObject();
    }

    ///  Get the destination object for the given object.<br/>
    /// <br/>
    ///  All objects can hold a transition target, but only Doors and Triggers<br/>
    ///  will be made clickable by the game engine (This may change in the<br/>
    ///  future). You can set and query transition targets on other objects for<br/>
    ///  your own scripted purposes.<br/>
    /// <br/>
    ///  * Returns OBJECT_INVALID if oTransition does not hold a target.
    public static uint GetTransitionTarget(uint oTransition)
    {
      VM.StackPush(oTransition);
      VM.Call(198);
      return VM.StackPopObject();
    }

    ///  Link the two supplied effects, returning eChildEffect as a child of<br/>
    ///  eParentEffect.<br/>
    ///  Note: When applying linked effects if the target is immune to all valid<br/>
    ///  effects all other effects will be removed as well. This means that if you<br/>
    ///  apply a visual effect and a silence effect (in a link) and the target is<br/>
    ///  immune to the silence effect that the visual effect will get removed as well.<br/>
    ///  Visual Effects are not considered &amp;quot;valid&amp;quot; effects for the purposes of<br/>
    ///  determining if an effect will be removed or not and as such should never be<br/>
    ///  packaged *only* with other visual effects in a link.
    public static System.IntPtr EffectLinkEffects(System.IntPtr eChildEffect, System.IntPtr eParentEffect)
    {
      VM.StackPush(eParentEffect, ENGINE_STRUCTURE_EFFECT);
      VM.StackPush(eChildEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(199);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the nNth object with the specified tag.<br/>
    ///  - sTag<br/>
    ///  - nNth: the nth object with this tag may be requested<br/>
    ///  * Returns OBJECT_INVALID if the object cannot be found.<br/>
    ///  Note: The module cannot be retrieved by GetObjectByTag(), use GetModule() instead.
    public static uint GetObjectByTag(string sTag, int nNth = 0)
    {
      VM.StackPush(nNth);
      VM.StackPush(sTag);
      VM.Call(200);
      return VM.StackPopObject();
    }

    ///  Adjust the alignment of oSubject.<br/>
    ///  - oSubject<br/>
    ///  - nAlignment:<br/>
    ///    -&amp;gt; ALIGNMENT_LAWFUL/ALIGNMENT_CHAOTIC/ALIGNMENT_GOOD/ALIGNMENT_EVIL: oSubject&amp;apos;s<br/>
    ///       alignment will be shifted in the direction specified<br/>
    ///    -&amp;gt; ALIGNMENT_ALL: nShift will be added to oSubject&amp;apos;s law/chaos and<br/>
    ///       good/evil alignment values<br/>
    ///    -&amp;gt; ALIGNMENT_NEUTRAL: nShift is applied to oSubject&amp;apos;s law/chaos and<br/>
    ///       good/evil alignment values in the direction which is towards neutrality.<br/>
    ///      e.g. If oSubject has a law/chaos value of 10 (i.e. chaotic) and a<br/>
    ///           good/evil value of 80 (i.e. good) then if nShift is 15, the<br/>
    ///           law/chaos value will become (10+15)=25 and the good/evil value will<br/>
    ///           become (80-25)=55<br/>
    ///      Furthermore, the shift will at most take the alignment value to 50 and<br/>
    ///      not beyond.<br/>
    ///      e.g. If oSubject has a law/chaos value of 40 and a good/evil value of 70,<br/>
    ///           then if nShift is 15, the law/chaos value will become 50 and the<br/>
    ///           good/evil value will become 55<br/>
    ///  - nShift: this is the desired shift in alignment<br/>
    ///  - bAllPartyMembers: when TRUE the alignment shift of oSubject also has a<br/>
    ///                      diminished affect all members of oSubject&amp;apos;s party (if oSubject is a Player).<br/>
    ///                      When FALSE the shift only affects oSubject.<br/>
    ///  * No return value
    public static void AdjustAlignment(uint oSubject, int nAlignment, int nShift, int bAllPartyMembers = TRUE)
    {
      VM.StackPush(bAllPartyMembers);
      VM.StackPush(nShift);
      VM.StackPush(nAlignment);
      VM.StackPush(oSubject);
      VM.Call(201);
    }

    ///  Do nothing for fSeconds seconds.
    public static void ActionWait(float fSeconds)
    {
      VM.StackPush(fSeconds);
      VM.Call(202);
    }

    ///  Set the transition bitmap of a player; this should only be called in area<br/>
    ///  transition scripts. This action should be run by the person &amp;quot;clicking&amp;quot; the<br/>
    ///  area transition via AssignCommand.<br/>
    ///  - nPredefinedAreaTransition:<br/>
    ///    -&amp;gt; To use a predefined area transition bitmap, use one of AREA_TRANSITION_*<br/>
    ///    -&amp;gt; To use a custom, user-defined area transition bitmap, use<br/>
    ///       AREA_TRANSITION_USER_DEFINED and specify the filename in the second<br/>
    ///       parameter<br/>
    ///  - sCustomAreaTransitionBMP: this is the filename of a custom, user-defined<br/>
    ///    area transition bitmap
    public static void SetAreaTransitionBMP(int nPredefinedAreaTransition, string sCustomAreaTransitionBMP = "")
    {
      VM.StackPush(sCustomAreaTransitionBMP);
      VM.StackPush(nPredefinedAreaTransition);
      VM.Call(203);
    }

    ///  Starts a conversation with oObjectToConverseWith - this will cause their<br/>
    ///  OnDialog event to fire.<br/>
    ///  - oObjectToConverseWith<br/>
    ///  - sDialogResRef: If this is blank, the creature&amp;apos;s own dialogue file will be used<br/>
    ///  - bPrivateConversation<br/>
    ///  Turn off bPlayHello if you don&amp;apos;t want the initial greeting to play
    public static void ActionStartConversation(uint oObjectToConverseWith, string sDialogResRef = "", int bPrivateConversation = FALSE, int bPlayHello = TRUE)
    {
      VM.StackPush(bPlayHello);
      VM.StackPush(bPrivateConversation);
      VM.StackPush(sDialogResRef);
      VM.StackPush(oObjectToConverseWith);
      VM.Call(204);
    }

    ///  Pause the current conversation.
    public static void ActionPauseConversation()
    {
      VM.Call(205);
    }

    ///  Resume a conversation after it has been paused.
    public static void ActionResumeConversation()
    {
      VM.Call(206);
    }

    ///  Create a Beam effect.<br/>
    ///  - nBeamVisualEffect: VFX_BEAM_*<br/>
    ///  - oEffector: the beam is emitted from this creature<br/>
    ///  - nBodyPart: BODY_NODE_*<br/>
    ///  - bMissEffect: If this is TRUE, the beam will fire to a random vector near or<br/>
    ///    past the target<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nBeamVisualEffect is<br/>
    ///    not valid.
    public static System.IntPtr EffectBeam(int nBeamVisualEffect, uint oEffector, int nBodyPart, int bMissEffect = FALSE, float fScale = 1.0f, System.Numerics.Vector3 vTranslate = default, System.Numerics.Vector3 vRotate = default)
    {
      VM.StackPush(vRotate);
      VM.StackPush(vTranslate);
      VM.StackPush(fScale);
      VM.StackPush(bMissEffect);
      VM.StackPush(nBodyPart);
      VM.StackPush(oEffector);
      VM.StackPush(nBeamVisualEffect);
      VM.Call(207);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get an integer between 0 and 100 (inclusive) that represents how oSource<br/>
    ///  feels about oTarget.<br/>
    ///  -&amp;gt; 0-10 means oSource is hostile to oTarget<br/>
    ///  -&amp;gt; 11-89 means oSource is neutral to oTarget<br/>
    ///  -&amp;gt; 90-100 means oSource is friendly to oTarget<br/>
    ///  * Returns -1 if oSource or oTarget does not identify a valid object
    public static int GetReputation(uint oSource, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oSource);
      VM.Call(208);
      return VM.StackPopInt();
    }

    ///  Adjust how oSourceFactionMember&amp;apos;s faction feels about oTarget by the<br/>
    ///  specified amount.<br/>
    ///  Note: This adjusts Faction Reputation, how the entire faction that<br/>
    ///  oSourceFactionMember is in, feels about oTarget.<br/>
    ///  * No return value<br/>
    ///  Note: You can&amp;apos;t adjust a player character&amp;apos;s (PC) faction towards<br/>
    ///        NPCs, so attempting to make an NPC hostile by passing in a PC object<br/>
    ///        as oSourceFactionMember in the following call will fail:<br/>
    ///        AdjustReputation(oNPC,oPC,-100);<br/>
    ///        Instead you should pass in the PC object as the first<br/>
    ///        parameter as in the following call which should succeed:<br/>
    ///        AdjustReputation(oPC,oNPC,-100);<br/>
    ///  Note: Will fail if oSourceFactionMember is a plot object.
    public static void AdjustReputation(uint oTarget, uint oSourceFactionMember, int nAdjustment)
    {
      VM.StackPush(nAdjustment);
      VM.StackPush(oSourceFactionMember);
      VM.StackPush(oTarget);
      VM.Call(209);
    }

    ///  Get the creature that is currently sitting on the specified object.<br/>
    ///  - oChair<br/>
    ///  * Returns OBJECT_INVALID if oChair is not a valid placeable.
    public static uint GetSittingCreature(uint oChair)
    {
      VM.StackPush(oChair);
      VM.Call(210);
      return VM.StackPopObject();
    }

    ///  Get the creature that is going to attack oTarget.<br/>
    ///  Note: This value is cleared out at the end of every combat round and should<br/>
    ///  not be used in any case except when getting a &amp;quot;going to be attacked&amp;quot; shout<br/>
    ///  from the master creature (and this creature is a henchman)<br/>
    ///  * Returns OBJECT_INVALID if oTarget is not a valid creature.
    public static uint GetGoingToBeAttackedBy(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(211);
      return VM.StackPopObject();
    }

    ///  Create a Spell Resistance Increase effect.<br/>
    ///  - nValue: size of spell resistance increase
    public static System.IntPtr EffectSpellResistanceIncrease(int nValue)
    {
      VM.StackPush(nValue);
      VM.Call(212);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the location of oObject.
    public static System.IntPtr GetLocation(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(213);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  The subject will jump to lLocation instantly (even between areas).<br/>
    ///  If lLocation is invalid, nothing will happen.
    public static void ActionJumpToLocation(System.IntPtr lLocation)
    {
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(214);
    }

    ///  Create a location.
    public static System.IntPtr Location(uint oArea, System.Numerics.Vector3 vPosition, float fOrientation)
    {
      VM.StackPush(fOrientation);
      VM.StackPush(vPosition);
      VM.StackPush(oArea);
      VM.Call(215);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  Apply eEffect at lLocation.
    public static void ApplyEffectAtLocation(int nDurationType, System.IntPtr eEffect, System.IntPtr lLocation, float fDuration = 0.0f)
    {
      VM.StackPush(fDuration);
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.StackPush(nDurationType);
      VM.Call(216);
    }

    ///  * Returns TRUE if oCreature is a Player Controlled character.
    public static int GetIsPC(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(217);
      return VM.StackPopInt();
    }

    ///  Convert fFeet into a number of meters.
    public static float FeetToMeters(float fFeet)
    {
      VM.StackPush(fFeet);
      VM.Call(218);
      return VM.StackPopFloat();
    }

    ///  Convert fYards into a number of meters.
    public static float YardsToMeters(float fYards)
    {
      VM.StackPush(fYards);
      VM.Call(219);
      return VM.StackPopFloat();
    }

    ///  Apply eEffect to oTarget.
    public static void ApplyEffectToObject(int nDurationType, System.IntPtr eEffect, uint oTarget, float fDuration = 0.0f)
    {
      VM.StackPush(fDuration);
      VM.StackPush(oTarget);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.StackPush(nDurationType);
      VM.Call(220);
    }

    ///  The caller will immediately speak sStringToSpeak (this is different from<br/>
    ///  ActionSpeakString)<br/>
    ///  - sStringToSpeak<br/>
    ///  - nTalkVolume: TALKVOLUME_*
    public static void SpeakString(string sStringToSpeak, int nTalkVolume = TALKVOLUME_TALK)
    {
      VM.StackPush(nTalkVolume);
      VM.StackPush(sStringToSpeak);
      VM.Call(221);
    }

    ///  Get the location of the caller&amp;apos;s last spell target.
    public static System.IntPtr GetSpellTargetLocation()
    {
      VM.Call(222);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  Get the position vector from lLocation.
    public static System.Numerics.Vector3 GetPositionFromLocation(System.IntPtr lLocation)
    {
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(223);
      return VM.StackPopVector();
    }

    ///  Get the area&amp;apos;s object ID from lLocation.
    public static uint GetAreaFromLocation(System.IntPtr lLocation)
    {
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(224);
      return VM.StackPopObject();
    }

    ///  Get the orientation value from lLocation.
    public static float GetFacingFromLocation(System.IntPtr lLocation)
    {
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(225);
      return VM.StackPopFloat();
    }

    ///  Get the creature nearest to lLocation, subject to all the criteria specified.<br/>
    ///  - nFirstCriteriaType: CREATURE_TYPE_*<br/>
    ///  - nFirstCriteriaValue:<br/>
    ///    -&amp;gt; CLASS_TYPE_* if nFirstCriteriaType was CREATURE_TYPE_CLASS<br/>
    ///    -&amp;gt; SPELL_* if nFirstCriteriaType was CREATURE_TYPE_DOES_NOT_HAVE_SPELL_EFFECT<br/>
    ///       or CREATURE_TYPE_HAS_SPELL_EFFECT<br/>
    ///    -&amp;gt; TRUE or FALSE if nFirstCriteriaType was CREATURE_TYPE_IS_ALIVE<br/>
    ///    -&amp;gt; PERCEPTION_* if nFirstCriteriaType was CREATURE_TYPE_PERCEPTION<br/>
    ///    -&amp;gt; PLAYER_CHAR_IS_PC or PLAYER_CHAR_NOT_PC if nFirstCriteriaType was<br/>
    ///       CREATURE_TYPE_PLAYER_CHAR<br/>
    ///    -&amp;gt; RACIAL_TYPE_* if nFirstCriteriaType was CREATURE_TYPE_RACIAL_TYPE<br/>
    ///    -&amp;gt; REPUTATION_TYPE_* if nFirstCriteriaType was CREATURE_TYPE_REPUTATION<br/>
    ///    For example, to get the nearest PC, use<br/>
    ///    (CREATURE_TYPE_PLAYER_CHAR, PLAYER_CHAR_IS_PC)<br/>
    ///  - lLocation: We&amp;apos;re trying to find the creature of the specified type that is<br/>
    ///    nearest to lLocation<br/>
    ///  - nNth: We don&amp;apos;t have to find the first nearest: we can find the Nth nearest....<br/>
    ///  - nSecondCriteriaType: This is used in the same way as nFirstCriteriaType to<br/>
    ///    further specify the type of creature that we are looking for.<br/>
    ///  - nSecondCriteriaValue: This is used in the same way as nFirstCriteriaValue<br/>
    ///    to further specify the type of creature that we are looking for.<br/>
    ///  - nThirdCriteriaType: This is used in the same way as nFirstCriteriaType to<br/>
    ///    further specify the type of creature that we are looking for.<br/>
    ///  - nThirdCriteriaValue: This is used in the same way as nFirstCriteriaValue to<br/>
    ///    further specify the type of creature that we are looking for.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetNearestCreatureToLocation(int nFirstCriteriaType, int nFirstCriteriaValue, System.IntPtr lLocation, int nNth = 1, int nSecondCriteriaType = -1, int nSecondCriteriaValue = -1, int nThirdCriteriaType = -1, int nThirdCriteriaValue = -1)
    {
      VM.StackPush(nThirdCriteriaValue);
      VM.StackPush(nThirdCriteriaType);
      VM.StackPush(nSecondCriteriaValue);
      VM.StackPush(nSecondCriteriaType);
      VM.StackPush(nNth);
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(nFirstCriteriaValue);
      VM.StackPush(nFirstCriteriaType);
      VM.Call(226);
      return VM.StackPopObject();
    }

    ///  Get the Nth object nearest to oTarget that is of the specified type.<br/>
    ///  - nObjectType: OBJECT_TYPE_*<br/>
    ///  - oTarget<br/>
    ///  - nNth<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetNearestObject(int nObjectType = OBJECT_TYPE_ALL, uint oTarget = OBJECT_INVALID, int nNth = 1)
    {
      VM.StackPush(nNth);
      VM.StackPush(oTarget);
      VM.StackPush(nObjectType);
      VM.Call(227);
      return VM.StackPopObject();
    }

    ///  Get the nNth object nearest to lLocation that is of the specified type.<br/>
    ///  - nObjectType: OBJECT_TYPE_*<br/>
    ///  - lLocation<br/>
    ///  - nNth<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetNearestObjectToLocation(int nObjectType, System.IntPtr lLocation, int nNth = 1)
    {
      VM.StackPush(nNth);
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(nObjectType);
      VM.Call(228);
      return VM.StackPopObject();
    }

    ///  Get the nth Object nearest to oTarget that has sTag as its tag.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetNearestObjectByTag(string sTag, uint oTarget = OBJECT_INVALID, int nNth = 1)
    {
      VM.StackPush(nNth);
      VM.StackPush(oTarget);
      VM.StackPush(sTag);
      VM.Call(229);
      return VM.StackPopObject();
    }

    ///  Convert nInteger into a floating point number.
    public static float IntToFloat(int nInteger)
    {
      VM.StackPush(nInteger);
      VM.Call(230);
      return VM.StackPopFloat();
    }

    ///  Convert fFloat into the nearest integer.
    public static int FloatToInt(float fFloat)
    {
      VM.StackPush(fFloat);
      VM.Call(231);
      return VM.StackPopInt();
    }

    ///  Convert sNumber into an integer.
    public static int StringToInt(string sNumber)
    {
      VM.StackPush(sNumber);
      VM.Call(232);
      return VM.StackPopInt();
    }

    ///  Convert sNumber into a floating point number.
    public static float StringToFloat(string sNumber)
    {
      VM.StackPush(sNumber);
      VM.Call(233);
      return VM.StackPopFloat();
    }

    ///  Cast spell nSpell at lTargetLocation.<br/>
    ///  - nSpell: SPELL_*<br/>
    ///  - lTargetLocation<br/>
    ///  - nMetaMagic: METAMAGIC_*<br/>
    ///  - bCheat: If this is TRUE, then the executor of the action doesn&amp;apos;t have to be<br/>
    ///    able to cast the spell.<br/>
    ///  - nProjectilePathType: PROJECTILE_PATH_TYPE_*<br/>
    ///  - bInstantSpell: If this is TRUE, the spell is cast immediately; this allows<br/>
    ///    the end-user to simulate<br/>
    ///    a high-level magic user having lots of advance warning of impending trouble.
    public static void ActionCastSpellAtLocation(int nSpell, System.IntPtr lTargetLocation, int nMetaMagic = METAMAGIC_ANY, int bCheat = FALSE, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT, int bInstantSpell = FALSE)
    {
      VM.StackPush(bInstantSpell);
      VM.StackPush(nProjectilePathType);
      VM.StackPush(bCheat);
      VM.StackPush(nMetaMagic);
      VM.StackPush(lTargetLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(nSpell);
      VM.Call(234);
    }

    ///  * Returns TRUE if oSource considers oTarget as an enemy.
    public static int GetIsEnemy(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(235);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if oSource considers oTarget as a friend.
    public static int GetIsFriend(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(236);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if oSource considers oTarget as neutral.
    public static int GetIsNeutral(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(237);
      return VM.StackPopInt();
    }

    ///  Get the PC that is involved in the conversation.<br/>
    ///  * Returns OBJECT_INVALID on error.
    public static uint GetPCSpeaker()
    {
      VM.Call(238);
      return VM.StackPopObject();
    }

    ///  Get a string from the talk table using nStrRef.
    public static string GetStringByStrRef(int nStrRef, int nGender = GENDER_MALE)
    {
      VM.StackPush(nGender);
      VM.StackPush(nStrRef);
      VM.Call(239);
      return VM.StackPopString();
    }

    ///  Causes the creature to speak a translated string.<br/>
    ///  - nStrRef: Reference of the string in the talk table<br/>
    ///  - nTalkVolume: TALKVOLUME_*
    public static void ActionSpeakStringByStrRef(int nStrRef, int nTalkVolume = TALKVOLUME_TALK)
    {
      VM.StackPush(nTalkVolume);
      VM.StackPush(nStrRef);
      VM.Call(240);
    }

    ///  Destroy oObject (irrevocably).<br/>
    ///  This will not work on modules and areas.
    public static void DestroyObject(uint oDestroy, float fDelay = 0.0f)
    {
      VM.StackPush(fDelay);
      VM.StackPush(oDestroy);
      VM.Call(241);
    }

    ///  Get the module.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetModule()
    {
      VM.Call(242);
      return VM.StackPopObject();
    }

    ///  Create an object of the specified type at lLocation.<br/>
    ///  - nObjectType: OBJECT_TYPE_ITEM, OBJECT_TYPE_CREATURE, OBJECT_TYPE_PLACEABLE,<br/>
    ///    OBJECT_TYPE_STORE, OBJECT_TYPE_WAYPOINT<br/>
    ///  - sTemplate<br/>
    ///  - lLocation<br/>
    ///  - bUseAppearAnimation<br/>
    ///  - sNewTag - if this string is not empty, it will replace the default tag from the template
    public static uint CreateObject(int nObjectType, string sTemplate, System.IntPtr lLocation, int bUseAppearAnimation = FALSE, string sNewTag = "")
    {
      VM.StackPush(sNewTag);
      VM.StackPush(bUseAppearAnimation);
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(sTemplate);
      VM.StackPush(nObjectType);
      VM.Call(243);
      return VM.StackPopObject();
    }

    ///  Create an event which triggers the &amp;quot;SpellCastAt&amp;quot; script<br/>
    ///  Note: This only creates the event. The event wont actually trigger until SignalEvent()<br/>
    ///  is called using this created SpellCastAt event as an argument.<br/>
    ///  For example:<br/>
    ///      SignalEvent(oCreature, EventSpellCastAt(oCaster, SPELL_MAGIC_MISSILE, TRUE));<br/>
    ///  This function doesn&amp;apos;t cast the spell specified, it only creates an event so that<br/>
    ///  when the event is signaled on an object, the object will use its OnSpellCastAt script<br/>
    ///  to react to the spell being cast.<br/>
    /// <br/>
    ///  To specify the OnSpellCastAt script that should run, view the Object&amp;apos;s Properties<br/>
    ///  and click on the Scripts Tab. Then specify a script for the OnSpellCastAt event.<br/>
    ///  From inside the OnSpellCastAt script call:<br/>
    ///      GetLastSpellCaster() to get the object that cast the spell (oCaster).<br/>
    ///      GetLastSpell() to get the type of spell cast (nSpell)<br/>
    ///      GetLastSpellHarmful() to determine if the spell cast at the object was harmful.
    public static System.IntPtr EventSpellCastAt(uint oCaster, int nSpell, int bHarmful = TRUE)
    {
      VM.StackPush(bHarmful);
      VM.StackPush(nSpell);
      VM.StackPush(oCaster);
      VM.Call(244);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EVENT);
    }

    ///  This is for use in a &amp;quot;Spell Cast&amp;quot; script, it gets who cast the spell.<br/>
    ///  The spell could have been cast by a creature, placeable or door.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a creature, placeable or door.
    public static uint GetLastSpellCaster()
    {
      VM.Call(245);
      return VM.StackPopObject();
    }

    ///  This is for use in a &amp;quot;Spell Cast&amp;quot; script, it gets the ID of the spell that<br/>
    ///  was cast.
    public static int GetLastSpell()
    {
      VM.Call(246);
      return VM.StackPopInt();
    }

    ///  This is for use in a user-defined script, it gets the event number.
    public static int GetUserDefinedEventNumber()
    {
      VM.Call(247);
      return VM.StackPopInt();
    }

    ///  This is for use in a Spell script, it gets the ID of the spell that is being<br/>
    ///  cast (SPELL_*).
    public static int GetSpellId()
    {
      VM.Call(248);
      return VM.StackPopInt();
    }

    ///  Generate a random name.<br/>
    ///  nNameType: The type of random name to be generated (NAME_*)
    public static string RandomName(int nNameType = NAME_FIRST_GENERIC_MALE)
    {
      VM.StackPush(nNameType);
      VM.Call(249);
      return VM.StackPopString();
    }

    ///  Create a Poison effect.<br/>
    ///  - nPoisonType: POISON_*
    public static System.IntPtr EffectPoison(int nPoisonType)
    {
      VM.StackPush(nPoisonType);
      VM.Call(250);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Disease effect.<br/>
    ///  - nDiseaseType: DISEASE_*
    public static System.IntPtr EffectDisease(int nDiseaseType)
    {
      VM.StackPush(nDiseaseType);
      VM.Call(251);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Silence effect.
    public static System.IntPtr EffectSilence()
    {
      VM.Call(252);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Set the name of oObject.<br/>
    /// <br/>
    ///  - oObject: the object for which you are changing the name (area, creature, placeable, item, or door).<br/>
    ///  - sNewName: the new name that the object will use.<br/>
    ///  Note: SetName() does not work on player objects.<br/>
    ///        Setting an object&amp;apos;s name to &amp;quot;&amp;quot; will make the object<br/>
    ///        revert to using the name it had originally before any<br/>
    ///        SetName() calls were made on the object.
    public static string GetName(uint oObject, int bOriginalName = FALSE)
    {
      VM.StackPush(bOriginalName);
      VM.StackPush(oObject);
      VM.Call(253);
      return VM.StackPopString();
    }

    ///  Use this in a conversation script to get the person with whom you are conversing.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid creature.
    public static uint GetLastSpeaker()
    {
      VM.Call(254);
      return VM.StackPopObject();
    }

    ///  Use this in an OnDialog script to start up the dialog tree.<br/>
    ///  - sResRef: if this is not specified, the default dialog file will be used<br/>
    ///  - oObjectToDialog: if this is not specified the person that triggered the<br/>
    ///    event will be used
    public static int BeginConversation(string sResRef = "", uint oObjectToDialog = OBJECT_INVALID)
    {
      VM.StackPush(oObjectToDialog);
      VM.StackPush(sResRef);
      VM.Call(255);
      return VM.StackPopInt();
    }

    ///  Use this in an OnPerception script to get the object that was perceived.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid creature.
    public static uint GetLastPerceived()
    {
      VM.Call(256);
      return VM.StackPopObject();
    }

    ///  Use this in an OnPerception script to determine whether the object that was<br/>
    ///  perceived was heard.
    public static int GetLastPerceptionHeard()
    {
      VM.Call(257);
      return VM.StackPopInt();
    }

    ///  Use this in an OnPerception script to determine whether the object that was<br/>
    ///  perceived has become inaudible.
    public static int GetLastPerceptionInaudible()
    {
      VM.Call(258);
      return VM.StackPopInt();
    }

    ///  Use this in an OnPerception script to determine whether the object that was<br/>
    ///  perceived was seen.
    public static int GetLastPerceptionSeen()
    {
      VM.Call(259);
      return VM.StackPopInt();
    }

    ///  Use this in an OnClosed script to get the object that closed the door or placeable.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid door or placeable.
    public static uint GetLastClosedBy()
    {
      VM.Call(260);
      return VM.StackPopObject();
    }

    ///  Use this in an OnPerception script to determine whether the object that was<br/>
    ///  perceived has vanished.
    public static int GetLastPerceptionVanished()
    {
      VM.Call(261);
      return VM.StackPopInt();
    }

    ///  Get the first object within oPersistentObject.<br/>
    ///  - oPersistentObject<br/>
    ///  - nResidentObjectType: OBJECT_TYPE_*<br/>
    ///  - nPersistentZone: PERSISTENT_ZONE_ACTIVE. [This could also take the value<br/>
    ///    PERSISTENT_ZONE_FOLLOW, but this is no longer used.]<br/>
    ///  * Returns OBJECT_INVALID if no object is found.
    public static uint GetFirstInPersistentObject(uint oPersistentObject = OBJECT_INVALID, int nResidentObjectType = OBJECT_TYPE_CREATURE, int nPersistentZone = PERSISTENT_ZONE_ACTIVE)
    {
      VM.StackPush(nPersistentZone);
      VM.StackPush(nResidentObjectType);
      VM.StackPush(oPersistentObject);
      VM.Call(262);
      return VM.StackPopObject();
    }

    ///  Get the next object within oPersistentObject.<br/>
    ///  - oPersistentObject<br/>
    ///  - nResidentObjectType: OBJECT_TYPE_*<br/>
    ///  - nPersistentZone: PERSISTENT_ZONE_ACTIVE. [This could also take the value<br/>
    ///    PERSISTENT_ZONE_FOLLOW, but this is no longer used.]<br/>
    ///  * Returns OBJECT_INVALID if no object is found.
    public static uint GetNextInPersistentObject(uint oPersistentObject = OBJECT_INVALID, int nResidentObjectType = OBJECT_TYPE_CREATURE, int nPersistentZone = PERSISTENT_ZONE_ACTIVE)
    {
      VM.StackPush(nPersistentZone);
      VM.StackPush(nResidentObjectType);
      VM.StackPush(oPersistentObject);
      VM.Call(263);
      return VM.StackPopObject();
    }

    ///  This returns the creator of oAreaOfEffectObject.<br/>
    ///  * Returns OBJECT_INVALID if oAreaOfEffectObject is not a valid Area of Effect object.
    public static uint GetAreaOfEffectCreator(uint oAreaOfEffectObject = OBJECT_INVALID)
    {
      VM.StackPush(oAreaOfEffectObject);
      VM.Call(264);
      return VM.StackPopObject();
    }

    ///  Delete oObject&amp;apos;s local integer variable sVarName
    public static void DeleteLocalInt(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(265);
    }

    ///  Delete oObject&amp;apos;s local float variable sVarName
    public static void DeleteLocalFloat(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(266);
    }

    ///  Delete oObject&amp;apos;s local string variable sVarName
    public static void DeleteLocalString(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(267);
    }

    ///  Delete oObject&amp;apos;s local object variable sVarName
    public static void DeleteLocalObject(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(268);
    }

    ///  Delete oObject&amp;apos;s local location variable sVarName
    public static void DeleteLocalLocation(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(269);
    }

    ///  Create a Haste effect.
    public static System.IntPtr EffectHaste()
    {
      VM.Call(270);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Slow effect.
    public static System.IntPtr EffectSlow()
    {
      VM.Call(271);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Convert oObject into a hexadecimal string.
    public static string ObjectToString(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(272);
      return VM.StackPopString();
    }

    ///  Create an Immunity effect.<br/>
    ///  - nImmunityType: IMMUNITY_TYPE_*
    public static System.IntPtr EffectImmunity(int nImmunityType)
    {
      VM.StackPush(nImmunityType);
      VM.Call(273);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  - oCreature<br/>
    ///  - nImmunityType: IMMUNITY_TYPE_*<br/>
    ///  - oVersus: if this is specified, then we also check for the race and<br/>
    ///    alignment of oVersus<br/>
    ///  * Returns TRUE if oCreature has immunity of type nImmunity versus oVersus.
    public static int GetIsImmune(uint oCreature, int nImmunityType, uint oVersus = OBJECT_INVALID)
    {
      VM.StackPush(oVersus);
      VM.StackPush(nImmunityType);
      VM.StackPush(oCreature);
      VM.Call(274);
      return VM.StackPopInt();
    }

    ///  Creates a Damage Immunity Increase effect.<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///  - nPercentImmunity
    public static System.IntPtr EffectDamageImmunityIncrease(int nDamageType, int nPercentImmunity)
    {
      VM.StackPush(nPercentImmunity);
      VM.StackPush(nDamageType);
      VM.Call(275);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Determine whether oEncounter is active.
    public static int GetEncounterActive(uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.Call(276);
      return VM.StackPopInt();
    }

    ///  Set oEncounter&amp;apos;s active state to nNewValue.<br/>
    ///  - nNewValue: TRUE/FALSE<br/>
    ///  - oEncounter
    public static void SetEncounterActive(int nNewValue, uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.StackPush(nNewValue);
      VM.Call(277);
    }

    ///  Get the maximum number of times that oEncounter will spawn.
    public static int GetEncounterSpawnsMax(uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.Call(278);
      return VM.StackPopInt();
    }

    ///  Set the maximum number of times that oEncounter can spawn
    public static void SetEncounterSpawnsMax(int nNewValue, uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.StackPush(nNewValue);
      VM.Call(279);
    }

    ///  Get the number of times that oEncounter has spawned so far
    public static int GetEncounterSpawnsCurrent(uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.Call(280);
      return VM.StackPopInt();
    }

    ///  Set the number of times that oEncounter has spawned so far
    public static void SetEncounterSpawnsCurrent(int nNewValue, uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.StackPush(nNewValue);
      VM.Call(281);
    }

    ///  Use this in an OnItemAcquired script to get the item that was acquired.<br/>
    ///  * Returns OBJECT_INVALID if the module is not valid.
    public static uint GetModuleItemAcquired()
    {
      VM.Call(282);
      return VM.StackPopObject();
    }

    ///  Use this in an OnItemAcquired script to get the creatre that previously<br/>
    ///  possessed the item.<br/>
    ///  * Returns OBJECT_INVALID if the item was picked up from the ground.
    public static uint GetModuleItemAcquiredFrom()
    {
      VM.Call(283);
      return VM.StackPopObject();
    }

    ///  Set the value for a custom token.
    public static void SetCustomToken(int nCustomTokenNumber, string sTokenValue)
    {
      VM.StackPush(sTokenValue);
      VM.StackPush(nCustomTokenNumber);
      VM.Call(284);
    }

    ///  Determine whether oCreature has nFeat, and nFeat is useable.<br/>
    ///  - nFeat: FEAT_*<br/>
    ///  - oCreature
    public static int GetHasFeat(int nFeat, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nFeat);
      VM.Call(285);
      return VM.StackPopInt();
    }

    ///  Determine whether oCreature has nSkill, and nSkill is useable.<br/>
    ///  - nSkill: SKILL_*<br/>
    ///  - oCreature
    public static int GetHasSkill(int nSkill, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nSkill);
      VM.Call(286);
      return VM.StackPopInt();
    }

    ///  Use nFeat on oTarget.<br/>
    ///  - nFeat: FEAT_*<br/>
    ///  - oTarget
    public static void ActionUseFeat(int nFeat, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(nFeat);
      VM.Call(287);
    }

    ///  Runs the action &amp;quot;UseSkill&amp;quot; on the current creature<br/>
    ///  Use nSkill on oTarget.<br/>
    ///  - nSkill: SKILL_*<br/>
    ///  - oTarget<br/>
    ///  - nSubSkill: SUBSKILL_*<br/>
    ///  - oItemUsed: Item to use in conjunction with the skill
    public static void ActionUseSkill(int nSkill, uint oTarget, int nSubSkill = 0, uint oItemUsed = OBJECT_INVALID)
    {
      VM.StackPush(oItemUsed);
      VM.StackPush(nSubSkill);
      VM.StackPush(oTarget);
      VM.StackPush(nSkill);
      VM.Call(288);
    }

    ///  Determine whether oSource sees oTarget.<br/>
    ///  NOTE: This *only* works on creatures, as visibility lists are not<br/>
    ///        maintained for non-creature objects.
    public static int GetObjectSeen(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(289);
      return VM.StackPopInt();
    }

    ///  Determine whether oSource hears oTarget.<br/>
    ///  NOTE: This *only* works on creatures, as visibility lists are not<br/>
    ///        maintained for non-creature objects.
    public static int GetObjectHeard(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(290);
      return VM.StackPopInt();
    }

    ///  Use this in an OnPlayerDeath module script to get the last player that died.
    public static uint GetLastPlayerDied()
    {
      VM.Call(291);
      return VM.StackPopObject();
    }

    ///  Use this in an OnItemLost script to get the item that was lost/dropped.<br/>
    ///  * Returns OBJECT_INVALID if the module is not valid.
    public static uint GetModuleItemLost()
    {
      VM.Call(292);
      return VM.StackPopObject();
    }

    ///  Use this in an OnItemLost script to get the creature that lost the item.<br/>
    ///  * Returns OBJECT_INVALID if the module is not valid.
    public static uint GetModuleItemLostBy()
    {
      VM.Call(293);
      return VM.StackPopObject();
    }

    ///  Do aActionToDo.
    public static void ActionDoCommand(System.Action aActionToDo)
    {
      NWNCore.FunctionHandler!.ClosureActionDoCommand(OBJECT_SELF, aActionToDo);
      // Function ID 294
    }

    ///  Creates a conversation event.<br/>
    ///  Note: This only creates the event. The event wont actually trigger until SignalEvent()<br/>
    ///  is called using this created conversation event as an argument.<br/>
    ///  For example:<br/>
    ///      SignalEvent(oCreature, EventConversation());<br/>
    ///  Once the event has been signaled. The script associated with the OnConversation event will<br/>
    ///  run on the creature oCreature.<br/>
    /// <br/>
    ///  To specify the OnConversation script that should run, view the Creature Properties on<br/>
    ///  the creature and click on the Scripts Tab. Then specify a script for the OnConversation event.
    public static System.IntPtr EventConversation()
    {
      VM.Call(295);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EVENT);
    }

    ///  Set the difficulty level of oEncounter.<br/>
    ///  - nEncounterDifficulty: ENCOUNTER_DIFFICULTY_*<br/>
    ///  - oEncounter
    public static void SetEncounterDifficulty(int nEncounterDifficulty, uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.StackPush(nEncounterDifficulty);
      VM.Call(296);
    }

    ///  Get the difficulty level of oEncounter.
    public static int GetEncounterDifficulty(uint oEncounter = OBJECT_INVALID)
    {
      VM.StackPush(oEncounter);
      VM.Call(297);
      return VM.StackPopInt();
    }

    ///  Get the distance between lLocationA and lLocationB.
    public static float GetDistanceBetweenLocations(System.IntPtr lLocationA, System.IntPtr lLocationB)
    {
      VM.StackPush(lLocationB, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(lLocationA, ENGINE_STRUCTURE_LOCATION);
      VM.Call(298);
      return VM.StackPopFloat();
    }

    ///  Use this in spell scripts to get nDamage adjusted by oTarget&amp;apos;s reflex and<br/>
    ///  evasion saves.<br/>
    ///  - nDamage<br/>
    ///  - oTarget<br/>
    ///  - nDC: Difficulty check<br/>
    ///  - nSaveType: SAVING_THROW_TYPE_*<br/>
    ///  - oSaveVersus
    public static int GetReflexAdjustedDamage(int nDamage, uint oTarget, int nDC, int nSaveType = SAVING_THROW_TYPE_NONE, uint oSaveVersus = OBJECT_INVALID)
    {
      VM.StackPush(oSaveVersus);
      VM.StackPush(nSaveType);
      VM.StackPush(nDC);
      VM.StackPush(oTarget);
      VM.StackPush(nDamage);
      VM.Call(299);
      return VM.StackPopInt();
    }

    ///  Play nAnimation immediately.<br/>
    ///  - nAnimation: ANIMATION_*<br/>
    ///  - fSpeed<br/>
    ///  - fSeconds
    public static void PlayAnimation(int nAnimation, float fSpeed = 1.0f, float fSeconds = 0.0f)
    {
      VM.StackPush(fSeconds);
      VM.StackPush(fSpeed);
      VM.StackPush(nAnimation);
      VM.Call(300);
    }

    ///  Create a Spell Talent.<br/>
    ///  - nSpell: SPELL_*
    public static System.IntPtr TalentSpell(int nSpell)
    {
      VM.StackPush(nSpell);
      VM.Call(301);
      return VM.StackPopStruct(ENGINE_STRUCTURE_TALENT);
    }

    ///  Create a Feat Talent.<br/>
    ///  - nFeat: FEAT_*
    public static System.IntPtr TalentFeat(int nFeat)
    {
      VM.StackPush(nFeat);
      VM.Call(302);
      return VM.StackPopStruct(ENGINE_STRUCTURE_TALENT);
    }

    ///  Create a Skill Talent.<br/>
    ///  - nSkill: SKILL_*
    public static System.IntPtr TalentSkill(int nSkill)
    {
      VM.StackPush(nSkill);
      VM.Call(303);
      return VM.StackPopStruct(ENGINE_STRUCTURE_TALENT);
    }

    ///  Determines whether oObject has any effects applied by nSpell<br/>
    ///  - nSpell: SPELL_*<br/>
    ///  - oObject<br/>
    ///  * The spell id on effects is only valid if the effect is created<br/>
    ///    when the spell script runs. If it is created in a delayed command<br/>
    ///    then the spell id on the effect will be invalid.
    public static int GetHasSpellEffect(int nSpell, uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.StackPush(nSpell);
      VM.Call(304);
      return VM.StackPopInt();
    }

    ///  Get the spell (SPELL_*) that applied eSpellEffect.<br/>
    ///  * Returns -1 if eSpellEffect was applied outside a spell script.
    public static int GetEffectSpellId(System.IntPtr eSpellEffect)
    {
      VM.StackPush(eSpellEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(305);
      return VM.StackPopInt();
    }

    ///  Determine whether oCreature has tTalent.
    public static int GetCreatureHasTalent(System.IntPtr tTalent, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(tTalent, ENGINE_STRUCTURE_TALENT);
      VM.Call(306);
      return VM.StackPopInt();
    }

    ///  Get a random talent of oCreature, within nCategory.<br/>
    ///  - nCategory: TALENT_CATEGORY_*<br/>
    ///  - oCreature
    public static System.IntPtr GetCreatureTalentRandom(int nCategory, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nCategory);
      VM.Call(307);
      return VM.StackPopStruct(ENGINE_STRUCTURE_TALENT);
    }

    ///  Get the best talent (i.e. closest to nCRMax without going over) of oCreature,<br/>
    ///  within nCategory.<br/>
    ///  - nCategory: TALENT_CATEGORY_*<br/>
    ///  - nCRMax: Challenge Rating of the talent<br/>
    ///  - oCreature
    public static System.IntPtr GetCreatureTalentBest(int nCategory, int nCRMax, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nCRMax);
      VM.StackPush(nCategory);
      VM.Call(308);
      return VM.StackPopStruct(ENGINE_STRUCTURE_TALENT);
    }

    ///  Use tChosenTalent on oTarget.
    public static void ActionUseTalentOnObject(System.IntPtr tChosenTalent, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(tChosenTalent, ENGINE_STRUCTURE_TALENT);
      VM.Call(309);
    }

    ///  Use tChosenTalent at lTargetLocation.
    public static void ActionUseTalentAtLocation(System.IntPtr tChosenTalent, System.IntPtr lTargetLocation)
    {
      VM.StackPush(lTargetLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(tChosenTalent, ENGINE_STRUCTURE_TALENT);
      VM.Call(310);
    }

    ///  Get the gold piece value of oItem.<br/>
    ///  * Returns 0 if oItem is not a valid item.
    public static int GetGoldPieceValue(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(311);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if oCreature is of a playable racial type.
    public static int GetIsPlayableRacialType(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(312);
      return VM.StackPopInt();
    }

    ///  Jump to lDestination.  The action is added to the TOP of the action queue.
    public static void JumpToLocation(System.IntPtr lDestination)
    {
      VM.StackPush(lDestination, ENGINE_STRUCTURE_LOCATION);
      VM.Call(313);
    }

    ///  Create a Temporary Hitpoints effect.<br/>
    ///  - nHitPoints: a positive integer<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nHitPoints &amp;lt; 0.
    public static System.IntPtr EffectTemporaryHitpoints(int nHitPoints)
    {
      VM.StackPush(nHitPoints);
      VM.Call(314);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the number of ranks that oTarget has in nSkill.<br/>
    ///  - nSkill: SKILL_*<br/>
    ///  - oTarget<br/>
    ///  - nBaseSkillRank: if set to true returns the number of base skill ranks the target<br/>
    ///                    has (i.e. not including any bonuses from ability scores, feats, etc).<br/>
    ///  * Returns -1 if oTarget doesn&amp;apos;t have nSkill.<br/>
    ///  * Returns 0 if nSkill is untrained.
    public static int GetSkillRank(int nSkill, uint oTarget = OBJECT_INVALID, int nBaseSkillRank = FALSE)
    {
      VM.StackPush(nBaseSkillRank);
      VM.StackPush(oTarget);
      VM.StackPush(nSkill);
      VM.Call(315);
      return VM.StackPopInt();
    }

    ///  Get the attack target of oCreature.<br/>
    ///  This only works when oCreature is in combat.
    public static uint GetAttackTarget(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(316);
      return VM.StackPopObject();
    }

    ///  Get the attack type (SPECIAL_ATTACK_*) of oCreature&amp;apos;s last attack.<br/>
    ///  This only works when oCreature is in combat.
    public static int GetLastAttackType(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(317);
      return VM.StackPopInt();
    }

    ///  Get the attack mode (COMBAT_MODE_*) of oCreature&amp;apos;s last attack.<br/>
    ///  This only works when oCreature is in combat.
    public static int GetLastAttackMode(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(318);
      return VM.StackPopInt();
    }

    ///  Get the master of oAssociate.
    public static uint GetMaster(uint oAssociate = OBJECT_INVALID)
    {
      VM.StackPush(oAssociate);
      VM.Call(319);
      return VM.StackPopObject();
    }

    ///  * Returns TRUE if oCreature is in combat.
    public static int GetIsInCombat(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(320);
      return VM.StackPopInt();
    }

    ///  Get the last command (ASSOCIATE_COMMAND_*) issued to oAssociate.
    public static int GetLastAssociateCommand(uint oAssociate = OBJECT_INVALID)
    {
      VM.StackPush(oAssociate);
      VM.Call(321);
      return VM.StackPopInt();
    }

    ///  Give nGP gold to oCreature.
    public static void GiveGoldToCreature(uint oCreature, int nGP)
    {
      VM.StackPush(nGP);
      VM.StackPush(oCreature);
      VM.Call(322);
    }

    ///  Set the destroyable status of the caller.<br/>
    ///  - bDestroyable: If this is FALSE, the caller does not fade out on death, but<br/>
    ///    sticks around as a corpse.<br/>
    ///  - bRaiseable: If this is TRUE, the caller can be raised via resurrection.<br/>
    ///  - bSelectableWhenDead: If this is TRUE, the caller is selectable after death.
    public static void SetIsDestroyable(int bDestroyable, int bRaiseable = TRUE, int bSelectableWhenDead = FALSE)
    {
      VM.StackPush(bSelectableWhenDead);
      VM.StackPush(bRaiseable);
      VM.StackPush(bDestroyable);
      VM.Call(323);
    }

    ///  Set the locked state of oTarget, which can be a door or a placeable object.
    public static void SetLocked(uint oTarget, int bLocked)
    {
      VM.StackPush(bLocked);
      VM.StackPush(oTarget);
      VM.Call(324);
    }

    ///  Get the locked state of oTarget, which can be a door or a placeable object.
    public static int GetLocked(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(325);
      return VM.StackPopInt();
    }

    ///  Use this in a trigger&amp;apos;s OnClick event script to get the object that last<br/>
    ///  clicked on it.<br/>
    ///  This is identical to GetEnteringObject.<br/>
    ///  GetClickingObject() should not be called from a placeable&amp;apos;s OnClick event,<br/>
    ///  instead use GetPlaceableLastClickedBy();
    public static uint GetClickingObject()
    {
      VM.Call(326);
      return VM.StackPopObject();
    }

    ///  Initialise oTarget to listen for the standard Associates commands.
    public static void SetAssociateListenPatterns(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(327);
    }

    ///  Get the last weapon that oCreature used in an attack.<br/>
    ///  * Returns OBJECT_INVALID if oCreature did not attack, or has no weapon equipped.
    public static uint GetLastWeaponUsed(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(328);
      return VM.StackPopObject();
    }

    ///  Use oPlaceable.
    public static void ActionInteractObject(uint oPlaceable)
    {
      VM.StackPush(oPlaceable);
      VM.Call(329);
    }

    ///  Get the last object that used the placeable object that is calling this function.<br/>
    ///  * Returns OBJECT_INVALID if it is called by something other than a placeable or<br/>
    ///    a door.
    public static uint GetLastUsedBy()
    {
      VM.Call(330);
      return VM.StackPopObject();
    }

    ///  Returns the ability modifier for the specified ability<br/>
    ///  Get oCreature&amp;apos;s ability modifier for nAbility.<br/>
    ///  - nAbility: ABILITY_*<br/>
    ///  - oCreature
    public static int GetAbilityModifier(int nAbility, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nAbility);
      VM.Call(331);
      return VM.StackPopInt();
    }

    ///  Determined whether oItem has been identified.
    public static int GetIdentified(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(332);
      return VM.StackPopInt();
    }

    ///  Set whether oItem has been identified.
    public static void SetIdentified(uint oItem, int bIdentified)
    {
      VM.StackPush(bIdentified);
      VM.StackPush(oItem);
      VM.Call(333);
    }

    ///  Summon an Animal Companion
    public static void SummonAnimalCompanion(uint oMaster = OBJECT_INVALID)
    {
      VM.StackPush(oMaster);
      VM.Call(334);
    }

    ///  Summon a Familiar
    public static void SummonFamiliar(uint oMaster = OBJECT_INVALID)
    {
      VM.StackPush(oMaster);
      VM.Call(335);
    }

    ///  Get the last blocking door encountered by the caller of this function.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid creature.
    public static uint GetBlockingDoor()
    {
      VM.Call(336);
      return VM.StackPopObject();
    }

    ///  - oTargetDoor<br/>
    ///  - nDoorAction: DOOR_ACTION_*<br/>
    ///  * Returns TRUE if nDoorAction can be performed on oTargetDoor.
    public static int GetIsDoorActionPossible(uint oTargetDoor, int nDoorAction)
    {
      VM.StackPush(nDoorAction);
      VM.StackPush(oTargetDoor);
      VM.Call(337);
      return VM.StackPopInt();
    }

    ///  Perform nDoorAction on oTargetDoor.
    public static void DoDoorAction(uint oTargetDoor, int nDoorAction)
    {
      VM.StackPush(nDoorAction);
      VM.StackPush(oTargetDoor);
      VM.Call(338);
    }

    ///  Get the first item in oTarget&amp;apos;s inventory (start to cycle through oTarget&amp;apos;s<br/>
    ///  inventory).<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a creature, item, placeable or store,<br/>
    ///    or if no item is found.
    public static uint GetFirstItemInInventory(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(339);
      return VM.StackPopObject();
    }

    ///  Get the next item in oTarget&amp;apos;s inventory (continue to cycle through oTarget&amp;apos;s<br/>
    ///  inventory).<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a creature, item, placeable or store,<br/>
    ///    or if no item is found.
    public static uint GetNextItemInInventory(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(340);
      return VM.StackPopObject();
    }

    ///  A creature can have up to three classes.  This function determines the<br/>
    ///  creature&amp;apos;s class (CLASS_TYPE_*) based on nClassPosition.<br/>
    ///  - nClassPosition: 1, 2 or 3<br/>
    ///  - oCreature<br/>
    ///  * Returns CLASS_TYPE_INVALID if the oCreature does not have a class in<br/>
    ///    nClassPosition (i.e. a single-class creature will only have a value in<br/>
    ///    nClassLocation=1) or if oCreature is not a valid creature.
    public static int GetClassByPosition(int nClassPosition, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nClassPosition);
      VM.Call(341);
      return VM.StackPopInt();
    }

    ///  A creature can have up to three classes.  This function determines the<br/>
    ///  creature&amp;apos;s class level based on nClass Position.<br/>
    ///  - nClassPosition: 1, 2 or 3<br/>
    ///  - oCreature<br/>
    ///  * Returns 0 if oCreature does not have a class in nClassPosition<br/>
    ///    (i.e. a single-class creature will only have a value in nClassLocation=1)<br/>
    ///    or if oCreature is not a valid creature.
    public static int GetLevelByPosition(int nClassPosition, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nClassPosition);
      VM.Call(342);
      return VM.StackPopInt();
    }

    ///  Determine the levels that oCreature holds in nClassType.<br/>
    ///  - nClassType: CLASS_TYPE_*<br/>
    ///  - oCreature
    public static int GetLevelByClass(int nClassType, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nClassType);
      VM.Call(343);
      return VM.StackPopInt();
    }

    ///  Get the amount of damage of type nDamageType that has been dealt to the caller.<br/>
    ///  - nDamageType: DAMAGE_TYPE_*
    public static int GetDamageDealtByType(int nDamageType)
    {
      VM.StackPush(nDamageType);
      VM.Call(344);
      return VM.StackPopInt();
    }

    ///  Get the total amount of damage that has been dealt to the caller.
    public static int GetTotalDamageDealt()
    {
      VM.Call(345);
      return VM.StackPopInt();
    }

    ///  Get the last object that damaged oObject<br/>
    ///  * Returns OBJECT_INVALID if the passed in object is not a valid object.
    public static uint GetLastDamager(uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.Call(346);
      return VM.StackPopObject();
    }

    ///  Get the last object that disarmed the trap on the caller.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid placeable, trigger or<br/>
    ///    door.
    public static uint GetLastDisarmed()
    {
      VM.Call(347);
      return VM.StackPopObject();
    }

    ///  Get the last object that disturbed the inventory of the caller.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid creature or placeable.
    public static uint GetLastDisturbed()
    {
      VM.Call(348);
      return VM.StackPopObject();
    }

    ///  Get the last object that locked the caller.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid door or placeable.
    public static uint GetLastLocked()
    {
      VM.Call(349);
      return VM.StackPopObject();
    }

    ///  Get the last object that unlocked the caller.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid door or placeable.
    public static uint GetLastUnlocked()
    {
      VM.Call(350);
      return VM.StackPopObject();
    }

    ///  Create a Skill Increase effect.<br/>
    ///  - nSkill: SKILL_*<br/>
    ///  - nValue<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nSkill is invalid.
    public static System.IntPtr EffectSkillIncrease(int nSkill, int nValue)
    {
      VM.StackPush(nValue);
      VM.StackPush(nSkill);
      VM.Call(351);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the type of disturbance (INVENTORY_DISTURB_*) that caused the caller&amp;apos;s<br/>
    ///  OnInventoryDisturbed script to fire.  This will only work for creatures and<br/>
    ///  placeables.
    public static int GetInventoryDisturbType()
    {
      VM.Call(352);
      return VM.StackPopInt();
    }

    ///  get the item that caused the caller&amp;apos;s OnInventoryDisturbed script to fire.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid object.
    public static uint GetInventoryDisturbItem()
    {
      VM.Call(353);
      return VM.StackPopObject();
    }

    ///  Get the henchman belonging to oMaster.<br/>
    ///  * Return OBJECT_INVALID if oMaster does not have a henchman.<br/>
    ///  -nNth: Which henchman to return.
    public static uint GetHenchman(uint oMaster = OBJECT_INVALID, int nNth = 1)
    {
      VM.StackPush(nNth);
      VM.StackPush(oMaster);
      VM.Call(354);
      return VM.StackPopObject();
    }

    ///  Set eEffect to be versus a specific alignment.<br/>
    ///  - eEffect<br/>
    ///  - nLawChaos: ALIGNMENT_LAWFUL/ALIGNMENT_CHAOTIC/ALIGNMENT_ALL<br/>
    ///  - nGoodEvil: ALIGNMENT_GOOD/ALIGNMENT_EVIL/ALIGNMENT_ALL
    public static System.IntPtr VersusAlignmentEffect(System.IntPtr eEffect, int nLawChaos = ALIGNMENT_ALL, int nGoodEvil = ALIGNMENT_ALL)
    {
      VM.StackPush(nGoodEvil);
      VM.StackPush(nLawChaos);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(355);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Set eEffect to be versus nRacialType.<br/>
    ///  - eEffect<br/>
    ///  - nRacialType: RACIAL_TYPE_*
    public static System.IntPtr VersusRacialTypeEffect(System.IntPtr eEffect, int nRacialType)
    {
      VM.StackPush(nRacialType);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(356);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Set eEffect to be versus traps.
    public static System.IntPtr VersusTrapEffect(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(357);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the gender of oCreature.
    public static int GetGender(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(358);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if tTalent is valid.
    public static int GetIsTalentValid(System.IntPtr tTalent)
    {
      VM.StackPush(tTalent, ENGINE_STRUCTURE_TALENT);
      VM.Call(359);
      return VM.StackPopInt();
    }

    ///  Causes the action subject to move away from lMoveAwayFrom.
    public static void ActionMoveAwayFromLocation(System.IntPtr lMoveAwayFrom, int bRun = FALSE, float fMoveAwayRange = 40.0f)
    {
      VM.StackPush(fMoveAwayRange);
      VM.StackPush(bRun);
      VM.StackPush(lMoveAwayFrom, ENGINE_STRUCTURE_LOCATION);
      VM.Call(360);
    }

    ///  Get the target that the caller attempted to attack - this should be used in<br/>
    ///  conjunction with GetAttackTarget(). This value is set every time an attack is<br/>
    ///  made, and is reset at the end of combat.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid creature.
    public static uint GetAttemptedAttackTarget()
    {
      VM.Call(361);
      return VM.StackPopObject();
    }

    ///  Get the type (TALENT_TYPE_*) of tTalent.
    public static int GetTypeFromTalent(System.IntPtr tTalent)
    {
      VM.StackPush(tTalent, ENGINE_STRUCTURE_TALENT);
      VM.Call(362);
      return VM.StackPopInt();
    }

    ///  Get the ID of tTalent.  This could be a SPELL_*, FEAT_* or SKILL_*.
    public static int GetIdFromTalent(System.IntPtr tTalent)
    {
      VM.StackPush(tTalent, ENGINE_STRUCTURE_TALENT);
      VM.Call(363);
      return VM.StackPopInt();
    }

    ///  Get the associate of type nAssociateType belonging to oMaster.<br/>
    ///  - nAssociateType: ASSOCIATE_TYPE_*<br/>
    ///  - nMaster<br/>
    ///  - nTh: Which associate of the specified type to return<br/>
    ///  * Returns OBJECT_INVALID if no such associate exists.
    public static uint GetAssociate(int nAssociateType, uint oMaster = OBJECT_INVALID, int nTh = 1)
    {
      VM.StackPush(nTh);
      VM.StackPush(oMaster);
      VM.StackPush(nAssociateType);
      VM.Call(364);
      return VM.StackPopObject();
    }

    ///  Add oHenchman as a henchman to oMaster<br/>
    ///  If oHenchman is either a DM or a player character, this will have no effect.
    public static void AddHenchman(uint oMaster, uint oHenchman = OBJECT_INVALID)
    {
      VM.StackPush(oHenchman);
      VM.StackPush(oMaster);
      VM.Call(365);
    }

    ///  Remove oHenchman from the service of oMaster, returning them to their original faction.
    public static void RemoveHenchman(uint oMaster, uint oHenchman = OBJECT_INVALID)
    {
      VM.StackPush(oHenchman);
      VM.StackPush(oMaster);
      VM.Call(366);
    }

    ///  Add a journal quest entry to oCreature.<br/>
    ///  - szPlotID: the plot identifier used in the toolset&amp;apos;s Journal Editor<br/>
    ///  - nState: the state of the plot as seen in the toolset&amp;apos;s Journal Editor<br/>
    ///  - oCreature<br/>
    ///  - bAllPartyMembers: If this is TRUE, the entry will show up in the journal of<br/>
    ///    everyone in the party<br/>
    ///  - bAllPlayers: If this is TRUE, the entry will show up in the journal of<br/>
    ///    everyone in the world<br/>
    ///  - bAllowOverrideHigher: If this is TRUE, you can set the state to a lower<br/>
    ///    number than the one it is currently on
    public static void AddJournalQuestEntry(string szPlotID, int nState, uint oCreature, int bAllPartyMembers = TRUE, int bAllPlayers = FALSE, int bAllowOverrideHigher = FALSE)
    {
      VM.StackPush(bAllowOverrideHigher);
      VM.StackPush(bAllPlayers);
      VM.StackPush(bAllPartyMembers);
      VM.StackPush(oCreature);
      VM.StackPush(nState);
      VM.StackPush(szPlotID);
      VM.Call(367);
    }

    ///  Remove a journal quest entry from oCreature.<br/>
    ///  - szPlotID: the plot identifier used in the toolset&amp;apos;s Journal Editor<br/>
    ///  - oCreature<br/>
    ///  - bAllPartyMembers: If this is TRUE, the entry will be removed from the<br/>
    ///    journal of everyone in the party<br/>
    ///  - bAllPlayers: If this is TRUE, the entry will be removed from the journal of<br/>
    ///    everyone in the world
    public static void RemoveJournalQuestEntry(string szPlotID, uint oCreature, int bAllPartyMembers = TRUE, int bAllPlayers = FALSE)
    {
      VM.StackPush(bAllPlayers);
      VM.StackPush(bAllPartyMembers);
      VM.StackPush(oCreature);
      VM.StackPush(szPlotID);
      VM.Call(368);
    }

    ///  Get the public part of the CD Key that oPlayer used when logging in.<br/>
    ///  - nSinglePlayerCDKey: If set to TRUE, the player&amp;apos;s public CD Key will<br/>
    ///    be returned when the player is playing in single player mode<br/>
    ///    (otherwise returns an empty string in single player mode).
    public static string GetPCPublicCDKey(uint oPlayer, int nSinglePlayerCDKey = FALSE)
    {
      VM.StackPush(nSinglePlayerCDKey);
      VM.StackPush(oPlayer);
      VM.Call(369);
      return VM.StackPopString();
    }

    ///  Get the IP address from which oPlayer has connected.
    public static string GetPCIPAddress(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(370);
      return VM.StackPopString();
    }

    ///  Get the name of oPlayer.
    public static string GetPCPlayerName(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(371);
      return VM.StackPopString();
    }

    ///  Sets oPlayer and oTarget to like each other.
    public static void SetPCLike(uint oPlayer, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oPlayer);
      VM.Call(372);
    }

    ///  Sets oPlayer and oTarget to dislike each other.
    public static void SetPCDislike(uint oPlayer, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oPlayer);
      VM.Call(373);
    }

    ///  Send a server message (szMessage) to the oPlayer.
    public static void SendMessageToPC(uint oPlayer, string szMessage)
    {
      VM.StackPush(szMessage);
      VM.StackPush(oPlayer);
      VM.Call(374);
    }

    ///  Get the target at which the caller attempted to cast a spell.<br/>
    ///  This value is set every time a spell is cast and is reset at the end of<br/>
    ///  combat.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid creature.
    public static uint GetAttemptedSpellTarget()
    {
      VM.Call(375);
      return VM.StackPopObject();
    }

    ///  Get the last creature that opened the caller.<br/>
    ///  * Returns OBJECT_INVALID if the caller is not a valid door, placeable or store.
    public static uint GetLastOpenedBy()
    {
      VM.Call(376);
      return VM.StackPopObject();
    }

    ///  Determines the number of times that oCreature has nSpell memorised.<br/>
    ///  - nSpell: SPELL_*<br/>
    ///  - oCreature
    public static int GetHasSpell(int nSpell, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nSpell);
      VM.Call(377);
      return VM.StackPopInt();
    }

    ///  Open oStore for oPC.<br/>
    ///  - nBonusMarkUp is added to the stores default mark up percentage on items sold (-100 to 100)<br/>
    ///  - nBonusMarkDown is added to the stores default mark down percentage on items bought (-100 to 100)
    public static void OpenStore(uint oStore, uint oPC, int nBonusMarkUp = 0, int nBonusMarkDown = 0)
    {
      VM.StackPush(nBonusMarkDown);
      VM.StackPush(nBonusMarkUp);
      VM.StackPush(oPC);
      VM.StackPush(oStore);
      VM.Call(378);
    }

    ///  Create a Turned effect.<br/>
    ///  Turned effects are supernatural by default.
    public static System.IntPtr EffectTurned()
    {
      VM.Call(379);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the first member of oMemberOfFaction&amp;apos;s faction (start to cycle through<br/>
    ///  oMemberOfFaction&amp;apos;s faction).<br/>
    ///  * Returns OBJECT_INVALID if oMemberOfFaction&amp;apos;s faction is invalid.
    public static uint GetFirstFactionMember(uint oMemberOfFaction, int bPCOnly = TRUE)
    {
      VM.StackPush(bPCOnly);
      VM.StackPush(oMemberOfFaction);
      VM.Call(380);
      return VM.StackPopObject();
    }

    ///  Get the next member of oMemberOfFaction&amp;apos;s faction (continue to cycle through<br/>
    ///  oMemberOfFaction&amp;apos;s faction).<br/>
    ///  * Returns OBJECT_INVALID if oMemberOfFaction&amp;apos;s faction is invalid.
    public static uint GetNextFactionMember(uint oMemberOfFaction, int bPCOnly = TRUE)
    {
      VM.StackPush(bPCOnly);
      VM.StackPush(oMemberOfFaction);
      VM.Call(381);
      return VM.StackPopObject();
    }

    ///  Force the action subject to move to lDestination.
    public static void ActionForceMoveToLocation(System.IntPtr lDestination, int bRun = FALSE, float fTimeout = 30.0f)
    {
      VM.StackPush(fTimeout);
      VM.StackPush(bRun);
      VM.StackPush(lDestination, ENGINE_STRUCTURE_LOCATION);
      VM.Call(382);
    }

    ///  Force the action subject to move to oMoveTo.
    public static void ActionForceMoveToObject(uint oMoveTo, int bRun = FALSE, float fRange = 1.0f, float fTimeout = 30.0f)
    {
      VM.StackPush(fTimeout);
      VM.StackPush(fRange);
      VM.StackPush(bRun);
      VM.StackPush(oMoveTo);
      VM.Call(383);
    }

    ///  Get the experience assigned in the journal editor for szPlotID.
    public static int GetJournalQuestExperience(string szPlotID)
    {
      VM.StackPush(szPlotID);
      VM.Call(384);
      return VM.StackPopInt();
    }

    ///  Jump to oToJumpTo (the action is added to the top of the action queue).
    public static void JumpToObject(uint oToJumpTo, int nWalkStraightLineToPoint = 1)
    {
      VM.StackPush(nWalkStraightLineToPoint);
      VM.StackPush(oToJumpTo);
      VM.Call(385);
    }

    ///  Set whether oMapPin is enabled.<br/>
    ///  - oMapPin<br/>
    ///  - nEnabled: 0=Off, 1=On
    public static void SetMapPinEnabled(uint oMapPin, int nEnabled)
    {
      VM.StackPush(nEnabled);
      VM.StackPush(oMapPin);
      VM.Call(386);
    }

    ///  Create a Hit Point Change When Dying effect.<br/>
    ///  - fHitPointChangePerRound: this can be positive or negative, but not zero.<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if fHitPointChangePerRound is 0.
    public static System.IntPtr EffectHitPointChangeWhenDying(float fHitPointChangePerRound)
    {
      VM.StackPush(fHitPointChangePerRound);
      VM.Call(387);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Spawn a GUI panel for the client that controls oPC.<br/>
    ///  Will force show panels disabled with SetGuiPanelDisabled()<br/>
    ///  - oPC<br/>
    ///  - nGUIPanel: GUI_PANEL_*, except GUI_PANEL_COMPASS / GUI_PANEL_LEVELUP / GUI_PANEL_GOLD_* / GUI_PANEL_EXAMINE_*<br/>
    ///  * Nothing happens if oPC is not a player character or if an invalid value is used for nGUIPanel.
    public static void PopUpGUIPanel(uint oPC, int nGUIPanel)
    {
      VM.StackPush(nGUIPanel);
      VM.StackPush(oPC);
      VM.Call(388);
    }

    ///  Clear all personal feelings that oSource has about oTarget.
    public static void ClearPersonalReputation(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(389);
    }

    ///  oSource will temporarily be friends towards oTarget.<br/>
    ///  bDecays determines whether the personal reputation value decays over time<br/>
    ///  fDurationInSeconds is the length of time that the temporary friendship lasts<br/>
    ///  Make oSource into a temporary friend of oTarget using personal reputation.<br/>
    ///  - oTarget<br/>
    ///  - oSource<br/>
    ///  - bDecays: If this is TRUE, the friendship decays over fDurationInSeconds;<br/>
    ///    otherwise it is indefinite.<br/>
    ///  - fDurationInSeconds: This is only used if bDecays is TRUE, it is how long<br/>
    ///    the friendship lasts.<br/>
    ///  Note: If bDecays is TRUE, the personal reputation amount decreases in size<br/>
    ///  over fDurationInSeconds. Friendship will only be in effect as long as<br/>
    ///  (faction reputation + total personal reputation) &amp;gt;= REPUTATION_TYPE_FRIEND.
    public static void SetIsTemporaryFriend(uint oTarget, uint oSource = OBJECT_INVALID, int bDecays = FALSE, float fDurationInSeconds = 180.0f)
    {
      VM.StackPush(fDurationInSeconds);
      VM.StackPush(bDecays);
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(390);
    }

    ///  Make oSource into a temporary enemy of oTarget using personal reputation.<br/>
    ///  - oTarget<br/>
    ///  - oSource<br/>
    ///  - bDecays: If this is TRUE, the enmity decays over fDurationInSeconds;<br/>
    ///    otherwise it is indefinite.<br/>
    ///  - fDurationInSeconds: This is only used if bDecays is TRUE, it is how long<br/>
    ///    the enmity lasts.<br/>
    ///  Note: If bDecays is TRUE, the personal reputation amount decreases in size<br/>
    ///  over fDurationInSeconds. Enmity will only be in effect as long as<br/>
    ///  (faction reputation + total personal reputation) &amp;lt;= REPUTATION_TYPE_ENEMY.
    public static void SetIsTemporaryEnemy(uint oTarget, uint oSource = OBJECT_INVALID, int bDecays = FALSE, float fDurationInSeconds = 180.0f)
    {
      VM.StackPush(fDurationInSeconds);
      VM.StackPush(bDecays);
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(391);
    }

    ///  Make oSource temporarily neutral to oTarget using personal reputation.<br/>
    ///  - oTarget<br/>
    ///  - oSource<br/>
    ///  - bDecays: If this is TRUE, the neutrality decays over fDurationInSeconds;<br/>
    ///    otherwise it is indefinite.<br/>
    ///  - fDurationInSeconds: This is only used if bDecays is TRUE, it is how long<br/>
    ///    the neutrality lasts.<br/>
    ///  Note: If bDecays is TRUE, the personal reputation amount decreases in size<br/>
    ///  over fDurationInSeconds. Neutrality will only be in effect as long as<br/>
    ///  (faction reputation + total personal reputation) &amp;gt; REPUTATION_TYPE_ENEMY and<br/>
    ///  (faction reputation + total personal reputation) &amp;lt; REPUTATION_TYPE_FRIEND.
    public static void SetIsTemporaryNeutral(uint oTarget, uint oSource = OBJECT_INVALID, int bDecays = FALSE, float fDurationInSeconds = 180.0f)
    {
      VM.StackPush(fDurationInSeconds);
      VM.StackPush(bDecays);
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(392);
    }

    ///  Gives nXpAmount to oCreature.
    public static void GiveXPToCreature(uint oCreature, int nXpAmount)
    {
      VM.StackPush(nXpAmount);
      VM.StackPush(oCreature);
      VM.Call(393);
    }

    ///  Sets oCreature&amp;apos;s experience to nXpAmount.
    public static void SetXP(uint oCreature, int nXpAmount)
    {
      VM.StackPush(nXpAmount);
      VM.StackPush(oCreature);
      VM.Call(394);
    }

    ///  Get oCreature&amp;apos;s experience.
    public static int GetXP(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(395);
      return VM.StackPopInt();
    }

    ///  Convert nInteger to hex, returning the hex value as a string.<br/>
    ///  * Return value has the format &amp;quot;0x????????&amp;quot; where each ? will be a hex digit<br/>
    ///    (8 digits in total).
    public static string IntToHexString(int nInteger)
    {
      VM.StackPush(nInteger);
      VM.Call(396);
      return VM.StackPopString();
    }

    ///  Get the base item type (BASE_ITEM_*) of oItem.<br/>
    ///  * Returns BASE_ITEM_INVALID if oItem is an invalid item.
    public static int GetBaseItemType(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(397);
      return VM.StackPopInt();
    }

    ///  Determines whether oItem has nProperty.<br/>
    ///  - oItem<br/>
    ///  - nProperty: ITEM_PROPERTY_*<br/>
    ///  * Returns FALSE if oItem is not a valid item, or if oItem does not have<br/>
    ///    nProperty.
    public static int GetItemHasItemProperty(uint oItem, int nProperty)
    {
      VM.StackPush(nProperty);
      VM.StackPush(oItem);
      VM.Call(398);
      return VM.StackPopInt();
    }

    ///  The creature will equip the melee weapon in its possession that can do the<br/>
    ///  most damage. If no valid melee weapon is found, it will equip the most<br/>
    ///  damaging range weapon. This function should only ever be called in the<br/>
    ///  EndOfCombatRound scripts, because otherwise it would have to stop the combat<br/>
    ///  round to run simulation.<br/>
    ///  - oVersus: You can try to get the most damaging weapon against oVersus<br/>
    ///  - bOffHand
    public static void ActionEquipMostDamagingMelee(uint oVersus = OBJECT_INVALID, int bOffHand = FALSE)
    {
      VM.StackPush(bOffHand);
      VM.StackPush(oVersus);
      VM.Call(399);
    }

    ///  The creature will equip the range weapon in its possession that can do the<br/>
    ///  most damage.<br/>
    ///  If no valid range weapon can be found, it will equip the most damaging melee<br/>
    ///  weapon.<br/>
    ///  - oVersus: You can try to get the most damaging weapon against oVersus
    public static void ActionEquipMostDamagingRanged(uint oVersus = OBJECT_INVALID)
    {
      VM.StackPush(oVersus);
      VM.Call(400);
    }

    ///  Get the Armour Class of oItem.<br/>
    ///  * Return 0 if the oItem is not a valid item, or if oItem has no armour value.
    public static int GetItemACValue(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(401);
      return VM.StackPopInt();
    }

    ///  The creature will rest if not in combat and no enemies are nearby.<br/>
    ///  - bCreatureToEnemyLineOfSightCheck: TRUE to allow the creature to rest if enemies<br/>
    ///                                      are nearby, but the creature can&amp;apos;t see the enemy.<br/>
    ///                                      FALSE the creature will not rest if enemies are<br/>
    ///                                      nearby regardless of whether or not the creature<br/>
    ///                                      can see them, such as if an enemy is close by,<br/>
    ///                                      but is in a different room behind a closed door.
    public static void ActionRest(int bCreatureToEnemyLineOfSightCheck = FALSE)
    {
      VM.StackPush(bCreatureToEnemyLineOfSightCheck);
      VM.Call(402);
    }

    ///  Expose/Hide the entire map of oArea for oPlayer.<br/>
    ///  - oArea: The area that the map will be exposed/hidden for.<br/>
    ///  - oPlayer: The player the map will be exposed/hidden for.<br/>
    ///  - bExplored: TRUE/FALSE. Whether the map should be completely explored or hidden.
    public static void ExploreAreaForPlayer(uint oArea, uint oPlayer, int bExplored = TRUE)
    {
      VM.StackPush(bExplored);
      VM.StackPush(oPlayer);
      VM.StackPush(oArea);
      VM.Call(403);
    }

    ///  The creature will equip the armour in its possession that has the highest<br/>
    ///  armour class.
    public static void ActionEquipMostEffectiveArmor()
    {
      VM.Call(404);
    }

    ///  * Returns TRUE if it is currently day.
    public static int GetIsDay()
    {
      VM.Call(405);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if it is currently night.
    public static int GetIsNight()
    {
      VM.Call(406);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if it is currently dawn.
    public static int GetIsDawn()
    {
      VM.Call(407);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if it is currently dusk.
    public static int GetIsDusk()
    {
      VM.Call(408);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if oCreature was spawned from an encounter.
    public static int GetIsEncounterCreature(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(409);
      return VM.StackPopInt();
    }

    ///  Use this in an OnPlayerDying module script to get the last player who is dying.
    public static uint GetLastPlayerDying()
    {
      VM.Call(410);
      return VM.StackPopObject();
    }

    ///  Get the starting location of the module.
    public static System.IntPtr GetStartingLocation()
    {
      VM.Call(411);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  Make oCreatureToChange join one of the standard factions.<br/>
    ///  ** This will only work on an NPC **<br/>
    ///  - nStandardFaction: STANDARD_FACTION_*
    public static void ChangeToStandardFaction(uint oCreatureToChange, int nStandardFaction)
    {
      VM.StackPush(nStandardFaction);
      VM.StackPush(oCreatureToChange);
      VM.Call(412);
    }

    ///  Play oSound.
    public static void SoundObjectPlay(uint oSound)
    {
      VM.StackPush(oSound);
      VM.Call(413);
    }

    ///  Stop playing oSound.
    public static void SoundObjectStop(uint oSound)
    {
      VM.StackPush(oSound);
      VM.Call(414);
    }

    ///  Set the volume of oSound.<br/>
    ///  - oSound<br/>
    ///  - nVolume: 0-127
    public static void SoundObjectSetVolume(uint oSound, int nVolume)
    {
      VM.StackPush(nVolume);
      VM.StackPush(oSound);
      VM.Call(415);
    }

    ///  Set the position of oSound.
    public static void SoundObjectSetPosition(uint oSound, System.Numerics.Vector3 vPosition)
    {
      VM.StackPush(vPosition);
      VM.StackPush(oSound);
      VM.Call(416);
    }

    ///  Immediately speak a conversation one-liner.<br/>
    ///  - sDialogResRef<br/>
    ///  - oTokenTarget: This must be specified if there are creature-specific tokens<br/>
    ///    in the string.
    public static void SpeakOneLinerConversation(string sDialogResRef = "", uint oTokenTarget = OBJECT_TYPE_INVALID)
    {
      VM.StackPush(oTokenTarget);
      VM.StackPush(sDialogResRef);
      VM.Call(417);
    }

    ///  Get the amount of gold possessed by oTarget.
    public static int GetGold(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(418);
      return VM.StackPopInt();
    }

    ///  Use this in an OnRespawnButtonPressed module script to get the object id of<br/>
    ///  the player who last pressed the respawn button.
    public static uint GetLastRespawnButtonPresser()
    {
      VM.Call(419);
      return VM.StackPopObject();
    }

    ///  * Returns TRUE if oCreature is the Dungeon Master.<br/>
    ///  Note: This will return FALSE if oCreature is a DM Possessed creature.<br/>
    ///  To determine if oCreature is a DM Possessed creature, use GetIsDMPossessed()
    public static int GetIsDM(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(420);
      return VM.StackPopInt();
    }

    ///  Play a voice chat.<br/>
    ///  - nVoiceChatID: VOICE_CHAT_*<br/>
    ///  - oTarget
    public static void PlayVoiceChat(int nVoiceChatID, uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.StackPush(nVoiceChatID);
      VM.Call(421);
    }

    ///  * Returns TRUE if the weapon equipped is capable of damaging oVersus.
    public static int GetIsWeaponEffective(uint oVersus = OBJECT_INVALID, int bOffHand = FALSE)
    {
      VM.StackPush(bOffHand);
      VM.StackPush(oVersus);
      VM.Call(422);
      return VM.StackPopInt();
    }

    ///  Use this in a SpellCast script to determine whether the spell was considered<br/>
    ///  harmful.<br/>
    ///  * Returns TRUE if the last spell cast was harmful.
    public static int GetLastSpellHarmful()
    {
      VM.Call(423);
      return VM.StackPopInt();
    }

    ///  Activate oItem.
    public static System.IntPtr EventActivateItem(uint oItem, System.IntPtr lTarget, uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.StackPush(lTarget, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(oItem);
      VM.Call(424);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EVENT);
    }

    ///  Play the background music for oArea.
    public static void MusicBackgroundPlay(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(425);
    }

    ///  Stop the background music for oArea.
    public static void MusicBackgroundStop(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(426);
    }

    ///  Set the delay for the background music for oArea.<br/>
    ///  - oArea<br/>
    ///  - nDelay: delay in milliseconds
    public static void MusicBackgroundSetDelay(uint oArea, int nDelay)
    {
      VM.StackPush(nDelay);
      VM.StackPush(oArea);
      VM.Call(427);
    }

    ///  Change the background day track for oArea to nTrack.<br/>
    ///  - oArea<br/>
    ///  - nTrack
    public static void MusicBackgroundChangeDay(uint oArea, int nTrack)
    {
      VM.StackPush(nTrack);
      VM.StackPush(oArea);
      VM.Call(428);
    }

    ///  Change the background night track for oArea to nTrack.<br/>
    ///  - oArea<br/>
    ///  - nTrack
    public static void MusicBackgroundChangeNight(uint oArea, int nTrack)
    {
      VM.StackPush(nTrack);
      VM.StackPush(oArea);
      VM.Call(429);
    }

    ///  Play the battle music for oArea.
    public static void MusicBattlePlay(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(430);
    }

    ///  Stop the battle music for oArea.
    public static void MusicBattleStop(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(431);
    }

    ///  Change the battle track for oArea.<br/>
    ///  - oArea<br/>
    ///  - nTrack
    public static void MusicBattleChange(uint oArea, int nTrack)
    {
      VM.StackPush(nTrack);
      VM.StackPush(oArea);
      VM.Call(432);
    }

    ///  Play the ambient sound for oArea.
    public static void AmbientSoundPlay(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(433);
    }

    ///  Stop the ambient sound for oArea.
    public static void AmbientSoundStop(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(434);
    }

    ///  Change the ambient day track for oArea to nTrack.<br/>
    ///  - oArea<br/>
    ///  - nTrack
    public static void AmbientSoundChangeDay(uint oArea, int nTrack)
    {
      VM.StackPush(nTrack);
      VM.StackPush(oArea);
      VM.Call(435);
    }

    ///  Change the ambient night track for oArea to nTrack.<br/>
    ///  - oArea<br/>
    ///  - nTrack
    public static void AmbientSoundChangeNight(uint oArea, int nTrack)
    {
      VM.StackPush(nTrack);
      VM.StackPush(oArea);
      VM.Call(436);
    }

    ///  Get the object that killed the caller.
    public static uint GetLastKiller()
    {
      VM.Call(437);
      return VM.StackPopObject();
    }

    ///  Use this in a spell script to get the item used to cast the spell.
    public static uint GetSpellCastItem()
    {
      VM.Call(438);
      return VM.StackPopObject();
    }

    ///  Use this in an OnItemActivated module script to get the item that was activated.
    public static uint GetItemActivated()
    {
      VM.Call(439);
      return VM.StackPopObject();
    }

    ///  Use this in an OnItemActivated module script to get the creature that<br/>
    ///  activated the item.
    public static uint GetItemActivator()
    {
      VM.Call(440);
      return VM.StackPopObject();
    }

    ///  Use this in an OnItemActivated module script to get the location of the item&amp;apos;s<br/>
    ///  target.
    public static System.IntPtr GetItemActivatedTargetLocation()
    {
      VM.Call(441);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  Use this in an OnItemActivated module script to get the item&amp;apos;s target.
    public static uint GetItemActivatedTarget()
    {
      VM.Call(442);
      return VM.StackPopObject();
    }

    ///  * Returns TRUE if oObject (which is a placeable or a door) is currently open.
    public static int GetIsOpen(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(443);
      return VM.StackPopInt();
    }

    ///  Take nAmount of gold from oCreatureToTakeFrom.<br/>
    ///  - nAmount<br/>
    ///  - oCreatureToTakeFrom: If this is not a valid creature, nothing will happen.<br/>
    ///  - bDestroy: If this is TRUE, the caller will not get the gold.  Instead, the<br/>
    ///    gold will be destroyed and will vanish from the game.
    public static void TakeGoldFromCreature(int nAmount, uint oCreatureToTakeFrom, int bDestroy = FALSE)
    {
      VM.StackPush(bDestroy);
      VM.StackPush(oCreatureToTakeFrom);
      VM.StackPush(nAmount);
      VM.Call(444);
    }

    ///  Determine whether oObject is in conversation.
    public static int IsInConversation(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(445);
      return VM.StackPopInt();
    }

    ///  Create an Ability Decrease effect.<br/>
    ///  - nAbility: ABILITY_*<br/>
    ///  - nModifyBy: This is the amount by which to decrement the ability
    public static System.IntPtr EffectAbilityDecrease(int nAbility, int nModifyBy)
    {
      VM.StackPush(nModifyBy);
      VM.StackPush(nAbility);
      VM.Call(446);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an Attack Decrease effect.<br/>
    ///  - nPenalty<br/>
    ///  - nModifierType: ATTACK_BONUS_*
    public static System.IntPtr EffectAttackDecrease(int nPenalty, int nModifierType = ATTACK_BONUS_MISC)
    {
      VM.StackPush(nModifierType);
      VM.StackPush(nPenalty);
      VM.Call(447);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Damage Decrease effect.<br/>
    ///  - nPenalty<br/>
    ///  - nDamageType: DAMAGE_TYPE_*
    public static System.IntPtr EffectDamageDecrease(int nPenalty, int nDamageType = DAMAGE_TYPE_MAGICAL)
    {
      VM.StackPush(nDamageType);
      VM.StackPush(nPenalty);
      VM.Call(448);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Damage Immunity Decrease effect.<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///  - nPercentImmunity
    public static System.IntPtr EffectDamageImmunityDecrease(int nDamageType, int nPercentImmunity)
    {
      VM.StackPush(nPercentImmunity);
      VM.StackPush(nDamageType);
      VM.Call(449);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an AC Decrease effect.<br/>
    ///  - nValue<br/>
    ///  - nModifyType: AC_*<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///    * Default value for nDamageType should only ever be used in this function prototype.
    public static System.IntPtr EffectACDecrease(int nValue, int nModifyType = AC_DODGE_BONUS, int nDamageType = AC_VS_DAMAGE_TYPE_ALL)
    {
      VM.StackPush(nDamageType);
      VM.StackPush(nModifyType);
      VM.StackPush(nValue);
      VM.Call(450);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Movement Speed Decrease effect.<br/>
    ///  - nPercentChange - range 0 through 99<br/>
    ///  eg.<br/>
    ///     0 = no change in speed<br/>
    ///    50 = 50% slower<br/>
    ///    99 = almost immobile
    public static System.IntPtr EffectMovementSpeedDecrease(int nPercentChange)
    {
      VM.StackPush(nPercentChange);
      VM.Call(451);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Saving Throw Decrease effect.<br/>
    ///  - nSave: SAVING_THROW_* (not SAVING_THROW_TYPE_*)<br/>
    ///           SAVING_THROW_ALL<br/>
    ///           SAVING_THROW_FORT<br/>
    ///           SAVING_THROW_REFLEX<br/>
    ///           SAVING_THROW_WILL<br/>
    ///  - nValue: size of the Saving Throw decrease<br/>
    ///  - nSaveType: SAVING_THROW_TYPE_* (e.g. SAVING_THROW_TYPE_ACID )
    public static System.IntPtr EffectSavingThrowDecrease(int nSave, int nValue, int nSaveType = SAVING_THROW_TYPE_ALL)
    {
      VM.StackPush(nSaveType);
      VM.StackPush(nValue);
      VM.StackPush(nSave);
      VM.Call(452);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Skill Decrease effect.<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nSkill is invalid.
    public static System.IntPtr EffectSkillDecrease(int nSkill, int nValue)
    {
      VM.StackPush(nValue);
      VM.StackPush(nSkill);
      VM.Call(453);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Spell Resistance Decrease effect.
    public static System.IntPtr EffectSpellResistanceDecrease(int nValue)
    {
      VM.StackPush(nValue);
      VM.Call(454);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Determine whether oTarget is a plot object.
    public static int GetPlotFlag(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(455);
      return VM.StackPopInt();
    }

    ///  Set oTarget&amp;apos;s plot object status.
    public static void SetPlotFlag(uint oTarget, int nPlotFlag)
    {
      VM.StackPush(nPlotFlag);
      VM.StackPush(oTarget);
      VM.Call(456);
    }

    ///  Create an Invisibility effect.<br/>
    ///  - nInvisibilityType: INVISIBILITY_TYPE_*<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nInvisibilityType<br/>
    ///    is invalid.
    public static System.IntPtr EffectInvisibility(int nInvisibilityType)
    {
      VM.StackPush(nInvisibilityType);
      VM.Call(457);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Concealment effect.<br/>
    ///  - nPercentage: 1-100 inclusive<br/>
    ///  - nMissChanceType: MISS_CHANCE_TYPE_*<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nPercentage &amp;lt; 1 or<br/>
    ///    nPercentage &amp;gt; 100.
    public static System.IntPtr EffectConcealment(int nPercentage, int nMissType = MISS_CHANCE_TYPE_NORMAL)
    {
      VM.StackPush(nMissType);
      VM.StackPush(nPercentage);
      VM.Call(458);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Darkness effect.
    public static System.IntPtr EffectDarkness()
    {
      VM.Call(459);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Dispel Magic All effect.<br/>
    ///  If no parameter is specified, USE_CREATURE_LEVEL will be used. This will<br/>
    ///  cause the dispel effect to use the level of the creature that created the<br/>
    ///  effect.
    public static System.IntPtr EffectDispelMagicAll(int nCasterLevel = USE_CREATURE_LEVEL)
    {
      VM.StackPush(nCasterLevel);
      VM.Call(460);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an Ultravision effect.
    public static System.IntPtr EffectUltravision()
    {
      VM.Call(461);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Negative Level effect.<br/>
    ///  - nNumLevels: the number of negative levels to apply.<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nNumLevels &amp;gt; 100.
    public static System.IntPtr EffectNegativeLevel(int nNumLevels, int bHPBonus = FALSE)
    {
      VM.StackPush(bHPBonus);
      VM.StackPush(nNumLevels);
      VM.Call(462);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Polymorph effect.
    public static System.IntPtr EffectPolymorph(int nPolymorphSelection, int nLocked = FALSE)
    {
      VM.StackPush(nLocked);
      VM.StackPush(nPolymorphSelection);
      VM.Call(463);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Sanctuary effect.<br/>
    ///  - nDifficultyClass: must be a non-zero, positive number<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nDifficultyClass &amp;lt;= 0.
    public static System.IntPtr EffectSanctuary(int nDifficultyClass)
    {
      VM.StackPush(nDifficultyClass);
      VM.Call(464);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a True Seeing effect.
    public static System.IntPtr EffectTrueSeeing()
    {
      VM.Call(465);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a See Invisible effect.
    public static System.IntPtr EffectSeeInvisible()
    {
      VM.Call(466);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Time Stop effect.
    public static System.IntPtr EffectTimeStop()
    {
      VM.Call(467);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Blindness effect.
    public static System.IntPtr EffectBlindness()
    {
      VM.Call(468);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Determine whether oSource has a friendly reaction towards oTarget, depending<br/>
    ///  on the reputation, PVP setting and (if both oSource and oTarget are PCs),<br/>
    ///  oSource&amp;apos;s Like/Dislike setting for oTarget.<br/>
    ///  Note: If you just want to know how two objects feel about each other in terms<br/>
    ///  of faction and personal reputation, use GetIsFriend() instead.<br/>
    ///  * Returns TRUE if oSource has a friendly reaction towards oTarget
    public static int GetIsReactionTypeFriendly(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(469);
      return VM.StackPopInt();
    }

    ///  Determine whether oSource has a neutral reaction towards oTarget, depending<br/>
    ///  on the reputation, PVP setting and (if both oSource and oTarget are PCs),<br/>
    ///  oSource&amp;apos;s Like/Dislike setting for oTarget.<br/>
    ///  Note: If you just want to know how two objects feel about each other in terms<br/>
    ///  of faction and personal reputation, use GetIsNeutral() instead.<br/>
    ///  * Returns TRUE if oSource has a neutral reaction towards oTarget
    public static int GetIsReactionTypeNeutral(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(470);
      return VM.StackPopInt();
    }

    ///  Determine whether oSource has a Hostile reaction towards oTarget, depending<br/>
    ///  on the reputation, PVP setting and (if both oSource and oTarget are PCs),<br/>
    ///  oSource&amp;apos;s Like/Dislike setting for oTarget.<br/>
    ///  Note: If you just want to know how two objects feel about each other in terms<br/>
    ///  of faction and personal reputation, use GetIsEnemy() instead.<br/>
    ///  * Returns TRUE if oSource has a hostile reaction towards oTarget
    public static int GetIsReactionTypeHostile(uint oTarget, uint oSource = OBJECT_INVALID)
    {
      VM.StackPush(oSource);
      VM.StackPush(oTarget);
      VM.Call(471);
      return VM.StackPopInt();
    }

    ///  Create a Spell Level Absorption effect.<br/>
    ///  - nMaxSpellLevelAbsorbed: maximum spell level that will be absorbed by the<br/>
    ///    effect<br/>
    ///  - nTotalSpellLevelsAbsorbed: maximum number of spell levels that will be<br/>
    ///    absorbed by the effect<br/>
    ///  - nSpellSchool: SPELL_SCHOOL_*<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if:<br/>
    ///    nMaxSpellLevelAbsorbed is not between -1 and 9 inclusive, or nSpellSchool<br/>
    ///    is invalid.
    public static System.IntPtr EffectSpellLevelAbsorption(int nMaxSpellLevelAbsorbed, int nTotalSpellLevelsAbsorbed = 0, int nSpellSchool = SPELL_SCHOOL_GENERAL)
    {
      VM.StackPush(nSpellSchool);
      VM.StackPush(nTotalSpellLevelsAbsorbed);
      VM.StackPush(nMaxSpellLevelAbsorbed);
      VM.Call(472);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Dispel Magic Best effect.<br/>
    ///  If no parameter is specified, USE_CREATURE_LEVEL will be used. This will<br/>
    ///  cause the dispel effect to use the level of the creature that created the<br/>
    ///  effect.
    public static System.IntPtr EffectDispelMagicBest(int nCasterLevel = USE_CREATURE_LEVEL)
    {
      VM.StackPush(nCasterLevel);
      VM.Call(473);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Try to send oTarget to a new server defined by sIPaddress.<br/>
    ///  - oTarget<br/>
    ///  - sIPaddress: this can be numerical &amp;quot;192.168.0.84&amp;quot; or alphanumeric<br/>
    ///    &amp;quot;www.bioware.com&amp;quot;. It can also contain a port &amp;quot;192.168.0.84:5121&amp;quot; or<br/>
    ///    &amp;quot;www.bioware.com:5121&amp;quot;; if the port is not specified, it will default to<br/>
    ///    5121.<br/>
    ///  - sPassword: login password for the destination server<br/>
    ///  - sWaypointTag: if this is set, after portalling the character will be moved<br/>
    ///    to this waypoint if it exists<br/>
    ///  - bSeamless: if this is set, the client wil not be prompted with the<br/>
    ///    information window telling them about the server, and they will not be<br/>
    ///    allowed to save a copy of their character if they are using a local vault<br/>
    ///    character.
    public static void ActivatePortal(uint oTarget, string sIPaddress = "", string sPassword = "", string sWaypointTag = "", int bSeemless = FALSE)
    {
      VM.StackPush(bSeemless);
      VM.StackPush(sWaypointTag);
      VM.StackPush(sPassword);
      VM.StackPush(sIPaddress);
      VM.StackPush(oTarget);
      VM.Call(474);
    }

    ///  Get the number of stacked items that oItem comprises.
    public static int GetNumStackedItems(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(475);
      return VM.StackPopInt();
    }

    ///  Use this on an NPC to cause all creatures within a 10-metre radius to stop<br/>
    ///  what they are doing and sets the NPC&amp;apos;s enemies within this range to be<br/>
    ///  neutral towards the NPC for roughly 3 minutes. If this command is run on a PC<br/>
    ///  or an object that is not a creature, nothing will happen.
    public static void SurrenderToEnemies()
    {
      VM.Call(476);
    }

    ///  Create a Miss Chance effect.<br/>
    ///  - nPercentage: 1-100 inclusive<br/>
    ///  - nMissChanceType: MISS_CHANCE_TYPE_*<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nPercentage &amp;lt; 1 or<br/>
    ///    nPercentage &amp;gt; 100.
    public static System.IntPtr EffectMissChance(int nPercentage, int nMissChanceType = MISS_CHANCE_TYPE_NORMAL)
    {
      VM.StackPush(nMissChanceType);
      VM.StackPush(nPercentage);
      VM.Call(477);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the number of Hitdice worth of Turn Resistance that oUndead may have.<br/>
    ///  This will only work on undead creatures.
    public static int GetTurnResistanceHD(uint oUndead = OBJECT_INVALID)
    {
      VM.StackPush(oUndead);
      VM.Call(478);
      return VM.StackPopInt();
    }

    ///  Get the size (CREATURE_SIZE_*) of oCreature.
    public static int GetCreatureSize(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(479);
      return VM.StackPopInt();
    }

    ///  Create a Disappear/Appear effect.<br/>
    ///  The object will &amp;quot;fly away&amp;quot; for the duration of the effect and will reappear<br/>
    ///  at lLocation.<br/>
    ///  - nAnimation determines which appear and disappear animations to use. Most creatures<br/>
    ///  only have animation 1, although a few have 2 (like beholders)
    public static System.IntPtr EffectDisappearAppear(System.IntPtr lLocation, int nAnimation = 1)
    {
      VM.StackPush(nAnimation);
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(480);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Disappear effect to make the object &amp;quot;fly away&amp;quot; and then destroy<br/>
    ///  itself.<br/>
    ///  - nAnimation determines which appear and disappear animations to use. Most creatures<br/>
    ///  only have animation 1, although a few have 2 (like beholders)
    public static System.IntPtr EffectDisappear(int nAnimation = 1)
    {
      VM.StackPush(nAnimation);
      VM.Call(481);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an Appear effect to make the object &amp;quot;fly in&amp;quot;.<br/>
    ///  - nAnimation determines which appear and disappear animations to use. Most creatures<br/>
    ///  only have animation 1, although a few have 2 (like beholders)
    public static System.IntPtr EffectAppear(int nAnimation = 1)
    {
      VM.StackPush(nAnimation);
      VM.Call(482);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  The action subject will unlock oTarget, which can be a door or a placeable<br/>
    ///  object.
    public static void ActionUnlockObject(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(483);
    }

    ///  The action subject will lock oTarget, which can be a door or a placeable<br/>
    ///  object.
    public static void ActionLockObject(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(484);
    }

    ///  Create a Modify Attacks effect to add attacks.<br/>
    ///  - nAttacks: maximum is 5, even with the effect stacked<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT if nAttacks &amp;gt; 5.
    public static System.IntPtr EffectModifyAttacks(int nAttacks)
    {
      VM.StackPush(nAttacks);
      VM.Call(485);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the last trap detected by oTarget.<br/>
    ///  * Return value on error: OBJECT_INVALID
    public static uint GetLastTrapDetected(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(486);
      return VM.StackPopObject();
    }

    ///  Create a Damage Shield effect which does (nDamageAmount + nRandomAmount)<br/>
    ///  damage to any melee attacker on a successful attack of damage type nDamageType.<br/>
    ///  - nDamageAmount: an integer value<br/>
    ///  - nRandomAmount: DAMAGE_BONUS_*<br/>
    ///  - nDamageType: DAMAGE_TYPE_*<br/>
    ///  NOTE! You *must* use the DAMAGE_BONUS_* constants! Using other values may<br/>
    ///        result in odd behaviour.
    public static System.IntPtr EffectDamageShield(int nDamageAmount, int nRandomAmount, int nDamageType)
    {
      VM.StackPush(nDamageType);
      VM.StackPush(nRandomAmount);
      VM.StackPush(nDamageAmount);
      VM.Call(487);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the trap nearest to oTarget.<br/>
    ///  Note : &amp;quot;trap objects&amp;quot; are actually any trigger, placeable or door that is<br/>
    ///  trapped in oTarget&amp;apos;s area.<br/>
    ///  - oTarget<br/>
    ///  - nTrapDetected: if this is TRUE, the trap returned has to have been detected<br/>
    ///    by oTarget.
    public static uint GetNearestTrapToObject(uint oTarget = OBJECT_INVALID, int nTrapDetected = TRUE)
    {
      VM.StackPush(nTrapDetected);
      VM.StackPush(oTarget);
      VM.Call(488);
      return VM.StackPopObject();
    }

    ///  Get the name of oCreature&amp;apos;s deity.<br/>
    ///  * Returns &amp;quot;&amp;quot; if oCreature is invalid (or if the deity name is blank for<br/>
    ///    oCreature).
    public static string GetDeity(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(489);
      return VM.StackPopString();
    }

    ///  Get the name of oCreature&amp;apos;s sub race.<br/>
    ///  * Returns &amp;quot;&amp;quot; if oCreature is invalid (or if sub race is blank for oCreature).
    public static string GetSubRace(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(490);
      return VM.StackPopString();
    }

    ///  Get oTarget&amp;apos;s base fortitude saving throw value (this will only work for<br/>
    ///  creatures, doors, and placeables).<br/>
    ///  * Returns 0 if oTarget is invalid.
    public static int GetFortitudeSavingThrow(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(491);
      return VM.StackPopInt();
    }

    ///  Get oTarget&amp;apos;s base will saving throw value (this will only work for creatures,<br/>
    ///  doors, and placeables).<br/>
    ///  * Returns 0 if oTarget is invalid.
    public static int GetWillSavingThrow(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(492);
      return VM.StackPopInt();
    }

    ///  Get oTarget&amp;apos;s base reflex saving throw value (this will only work for<br/>
    ///  creatures, doors, and placeables).<br/>
    ///  * Returns 0 if oTarget is invalid.
    public static int GetReflexSavingThrow(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(493);
      return VM.StackPopInt();
    }

    ///  Get oCreature&amp;apos;s challenge rating.<br/>
    ///  * Returns 0.0 if oCreature is invalid.
    public static float GetChallengeRating(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(494);
      return VM.StackPopFloat();
    }

    ///  Get oCreature&amp;apos;s age.<br/>
    ///  * Returns 0 if oCreature is invalid.
    public static int GetAge(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(495);
      return VM.StackPopInt();
    }

    ///  Get oCreature&amp;apos;s movement rate.<br/>
    ///  * Returns 0 if oCreature is invalid.
    public static int GetMovementRate(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(496);
      return VM.StackPopInt();
    }

    ///  Get oCreature&amp;apos;s familiar creature type (FAMILIAR_CREATURE_TYPE_*).<br/>
    ///  * Returns FAMILIAR_CREATURE_TYPE_NONE if oCreature is invalid or does not<br/>
    ///    currently have a familiar.
    public static int GetFamiliarCreatureType(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(497);
      return VM.StackPopInt();
    }

    ///  Get oCreature&amp;apos;s animal companion creature type<br/>
    ///  (ANIMAL_COMPANION_CREATURE_TYPE_*).<br/>
    ///  * Returns ANIMAL_COMPANION_CREATURE_TYPE_NONE if oCreature is invalid or does<br/>
    ///    not currently have an animal companion.
    public static int GetAnimalCompanionCreatureType(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(498);
      return VM.StackPopInt();
    }

    ///  Get oCreature&amp;apos;s familiar&amp;apos;s name.<br/>
    ///  * Returns &amp;quot;&amp;quot; if oCreature is invalid, does not currently<br/>
    ///  have a familiar or if the familiar&amp;apos;s name is blank.
    public static string GetFamiliarName(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(499);
      return VM.StackPopString();
    }

    ///  Get oCreature&amp;apos;s animal companion&amp;apos;s name.<br/>
    ///  * Returns &amp;quot;&amp;quot; if oCreature is invalid, does not currently<br/>
    ///  have an animal companion or if the animal companion&amp;apos;s name is blank.
    public static string GetAnimalCompanionName(uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.Call(500);
      return VM.StackPopString();
    }

    ///  The action subject will fake casting a spell at oTarget; the conjure and cast<br/>
    ///  animations and visuals will occur, nothing else.<br/>
    ///  - nSpell<br/>
    ///  - oTarget<br/>
    ///  - nProjectilePathType: PROJECTILE_PATH_TYPE_*
    public static void ActionCastFakeSpellAtObject(int nSpell, uint oTarget, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT)
    {
      VM.StackPush(nProjectilePathType);
      VM.StackPush(oTarget);
      VM.StackPush(nSpell);
      VM.Call(501);
    }

    ///  The action subject will fake casting a spell at lLocation; the conjure and<br/>
    ///  cast animations and visuals will occur, nothing else.<br/>
    ///  - nSpell<br/>
    ///  - lTarget<br/>
    ///  - nProjectilePathType: PROJECTILE_PATH_TYPE_*
    public static void ActionCastFakeSpellAtLocation(int nSpell, System.IntPtr lTarget, int nProjectilePathType = PROJECTILE_PATH_TYPE_DEFAULT)
    {
      VM.StackPush(nProjectilePathType);
      VM.StackPush(lTarget, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(nSpell);
      VM.Call(502);
    }

    ///  Removes oAssociate from the service of oMaster, returning them to their<br/>
    ///  original faction.
    public static void RemoveSummonedAssociate(uint oMaster, uint oAssociate = OBJECT_INVALID)
    {
      VM.StackPush(oAssociate);
      VM.StackPush(oMaster);
      VM.Call(503);
    }

    ///  Set the camera mode for oPlayer.<br/>
    ///  - oPlayer<br/>
    ///  - nCameraMode: CAMERA_MODE_*<br/>
    ///  * If oPlayer is not player-controlled or nCameraMode is invalid, nothing<br/>
    ///    happens.
    public static void SetCameraMode(uint oPlayer, int nCameraMode)
    {
      VM.StackPush(nCameraMode);
      VM.StackPush(oPlayer);
      VM.Call(504);
    }

    ///  * Returns TRUE if oCreature is resting.
    public static int GetIsResting(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(505);
      return VM.StackPopInt();
    }

    ///  Get the last PC that has rested in the module.
    public static uint GetLastPCRested()
    {
      VM.Call(506);
      return VM.StackPopObject();
    }

    ///  Set the weather for oTarget.<br/>
    ///  - oTarget: if this is GetModule(), all outdoor areas will be modified by the<br/>
    ///    weather constant. If it is an area, oTarget will play the weather only if<br/>
    ///    it is an outdoor area.<br/>
    ///  - nWeather: WEATHER_*<br/>
    ///    -&amp;gt; WEATHER_USER_AREA_SETTINGS will set the area back to random weather.<br/>
    ///    -&amp;gt; WEATHER_CLEAR, WEATHER_RAIN, WEATHER_SNOW will make the weather go to<br/>
    ///       the appropriate precipitation *without stopping*.
    public static void SetWeather(uint oTarget, int nWeather)
    {
      VM.StackPush(nWeather);
      VM.StackPush(oTarget);
      VM.Call(507);
    }

    ///  Determine the type (REST_EVENTTYPE_REST_*) of the last rest event (as<br/>
    ///  returned from the OnPCRested module event).
    public static int GetLastRestEventType()
    {
      VM.Call(508);
      return VM.StackPopInt();
    }

    ///  Shut down the currently loaded module and start a new one (moving all<br/>
    ///  currently-connected players to the starting point.
    public static void StartNewModule(string sModuleName)
    {
      VM.StackPush(sModuleName);
      VM.Call(509);
    }

    ///  Create a Swarm effect.<br/>
    ///  - nLooping: If this is TRUE, for the duration of the effect when one creature<br/>
    ///    created by this effect dies, the next one in the list will be created.  If<br/>
    ///    the last creature in the list dies, we loop back to the beginning and<br/>
    ///    sCreatureTemplate1 will be created, and so on...<br/>
    ///  - sCreatureTemplate1<br/>
    ///  - sCreatureTemplate2<br/>
    ///  - sCreatureTemplate3<br/>
    ///  - sCreatureTemplate4
    public static System.IntPtr EffectSwarm(int nLooping, string sCreatureTemplate1, string sCreatureTemplate2 = "", string sCreatureTemplate3 = "", string sCreatureTemplate4 = "")
    {
      VM.StackPush(sCreatureTemplate4);
      VM.StackPush(sCreatureTemplate3);
      VM.StackPush(sCreatureTemplate2);
      VM.StackPush(sCreatureTemplate1);
      VM.StackPush(nLooping);
      VM.Call(510);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  * Returns TRUE if oItem is a ranged weapon.
    public static int GetWeaponRanged(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(511);
      return VM.StackPopInt();
    }

    ///  Only if we are in a single player game, AutoSave the game.
    public static void DoSinglePlayerAutoSave()
    {
      VM.Call(512);
    }

    ///  Get the game difficulty (GAME_DIFFICULTY_*).
    public static int GetGameDifficulty()
    {
      VM.Call(513);
      return VM.StackPopInt();
    }

    ///  Set the main light color on the tile at lTileLocation.<br/>
    ///  - lTileLocation: the vector part of this is the tile grid (x,y) coordinate of<br/>
    ///    the tile.<br/>
    ///  - nMainLight1Color: TILE_MAIN_LIGHT_COLOR_*<br/>
    ///  - nMainLight2Color: TILE_MAIN_LIGHT_COLOR_*
    public static void SetTileMainLightColor(System.IntPtr lTileLocation, int nMainLight1Color, int nMainLight2Color)
    {
      VM.StackPush(nMainLight2Color);
      VM.StackPush(nMainLight1Color);
      VM.StackPush(lTileLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(514);
    }

    ///  Set the source light color on the tile at lTileLocation.<br/>
    ///  - lTileLocation: the vector part of this is the tile grid (x,y) coordinate of<br/>
    ///    the tile.<br/>
    ///  - nSourceLight1Color: TILE_SOURCE_LIGHT_COLOR_*<br/>
    ///  - nSourceLight2Color: TILE_SOURCE_LIGHT_COLOR_*
    public static void SetTileSourceLightColor(System.IntPtr lTileLocation, int nSourceLight1Color, int nSourceLight2Color)
    {
      VM.StackPush(nSourceLight2Color);
      VM.StackPush(nSourceLight1Color);
      VM.StackPush(lTileLocation, ENGINE_STRUCTURE_LOCATION);
      VM.Call(515);
    }

    ///  All clients in oArea will recompute the static lighting.<br/>
    ///  This can be used to update the lighting after changing any tile lights or if<br/>
    ///  placeables with lights have been added/deleted.
    public static void RecomputeStaticLighting(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(516);
    }

    ///  Get the color (TILE_MAIN_LIGHT_COLOR_*) for the main light 1 of the tile at<br/>
    ///  lTile.<br/>
    ///  - lTile: the vector part of this is the tile grid (x,y) coordinate of the tile.
    public static int GetTileMainLight1Color(System.IntPtr lTile)
    {
      VM.StackPush(lTile, ENGINE_STRUCTURE_LOCATION);
      VM.Call(517);
      return VM.StackPopInt();
    }

    ///  Get the color (TILE_MAIN_LIGHT_COLOR_*) for the main light 2 of the tile at<br/>
    ///  lTile.<br/>
    ///  - lTile: the vector part of this is the tile grid (x,y) coordinate of the<br/>
    ///    tile.
    public static int GetTileMainLight2Color(System.IntPtr lTile)
    {
      VM.StackPush(lTile, ENGINE_STRUCTURE_LOCATION);
      VM.Call(518);
      return VM.StackPopInt();
    }

    ///  Get the color (TILE_SOURCE_LIGHT_COLOR_*) for the source light 1 of the tile<br/>
    ///  at lTile.<br/>
    ///  - lTile: the vector part of this is the tile grid (x,y) coordinate of the<br/>
    ///    tile.
    public static int GetTileSourceLight1Color(System.IntPtr lTile)
    {
      VM.StackPush(lTile, ENGINE_STRUCTURE_LOCATION);
      VM.Call(519);
      return VM.StackPopInt();
    }

    ///  Get the color (TILE_SOURCE_LIGHT_COLOR_*) for the source light 2 of the tile<br/>
    ///  at lTile.<br/>
    ///  - lTile: the vector part of this is the tile grid (x,y) coordinate of the<br/>
    ///    tile.
    public static int GetTileSourceLight2Color(System.IntPtr lTile)
    {
      VM.StackPush(lTile, ENGINE_STRUCTURE_LOCATION);
      VM.Call(520);
      return VM.StackPopInt();
    }

    ///  Make the corresponding panel button on the player&amp;apos;s client start or stop<br/>
    ///  flashing.<br/>
    ///  - oPlayer<br/>
    ///  - nButton: PANEL_BUTTON_*<br/>
    ///  - nEnableFlash: if this is TRUE nButton will start flashing.  It if is FALSE,<br/>
    ///    nButton will stop flashing.
    public static void SetPanelButtonFlash(uint oPlayer, int nButton, int nEnableFlash)
    {
      VM.StackPush(nEnableFlash);
      VM.StackPush(nButton);
      VM.StackPush(oPlayer);
      VM.Call(521);
    }

    ///  Get the current action (ACTION_*) that oObject is executing.
    public static int GetCurrentAction(uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.Call(522);
      return VM.StackPopInt();
    }

    ///  Set how nStandardFaction feels about oCreature.<br/>
    ///  - nStandardFaction: STANDARD_FACTION_*<br/>
    ///  - nNewReputation: 0-100 (inclusive)<br/>
    ///  - oCreature
    public static void SetStandardFactionReputation(int nStandardFaction, int nNewReputation, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nNewReputation);
      VM.StackPush(nStandardFaction);
      VM.Call(523);
    }

    ///  Find out how nStandardFaction feels about oCreature.<br/>
    ///  - nStandardFaction: STANDARD_FACTION_*<br/>
    ///  - oCreature<br/>
    ///  Returns -1 on an error.<br/>
    ///  Returns 0-100 based on the standing of oCreature within the faction nStandardFaction.<br/>
    ///  0-10   :  Hostile.<br/>
    ///  11-89  :  Neutral.<br/>
    ///  90-100 :  Friendly.
    public static int GetStandardFactionReputation(int nStandardFaction, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nStandardFaction);
      VM.Call(524);
      return VM.StackPopInt();
    }

    ///  Display floaty text above the specified creature.<br/>
    ///  The text will also appear in the chat buffer of each player that receives the<br/>
    ///  floaty text.<br/>
    ///  - nStrRefToDisplay: String ref (therefore text is translated)<br/>
    ///  - oCreatureToFloatAbove<br/>
    ///  - bBroadcastToFaction: If this is TRUE then only creatures in the same faction<br/>
    ///    as oCreatureToFloatAbove<br/>
    ///    will see the floaty text, and only if they are within range (30 metres).
    public static void FloatingTextStrRefOnCreature(int nStrRefToDisplay, uint oCreatureToFloatAbove, int bBroadcastToFaction = TRUE)
    {
      VM.StackPush(bBroadcastToFaction);
      VM.StackPush(oCreatureToFloatAbove);
      VM.StackPush(nStrRefToDisplay);
      VM.Call(525);
    }

    ///  Display floaty text above the specified creature.<br/>
    ///  The text will also appear in the chat buffer of each player that receives the<br/>
    ///  floaty text.<br/>
    ///  - sStringToDisplay: String<br/>
    ///  - oCreatureToFloatAbove<br/>
    ///  - bBroadcastToFaction: If this is TRUE then only creatures in the same faction<br/>
    ///    as oCreatureToFloatAbove<br/>
    ///    will see the floaty text, and only if they are within range (30 metres).
    public static void FloatingTextStringOnCreature(string sStringToDisplay, uint oCreatureToFloatAbove, int bBroadcastToFaction = TRUE)
    {
      VM.StackPush(bBroadcastToFaction);
      VM.StackPush(oCreatureToFloatAbove);
      VM.StackPush(sStringToDisplay);
      VM.Call(526);
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns TRUE if oTrapObject is disarmable.
    public static int GetTrapDisarmable(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(527);
      return VM.StackPopInt();
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns TRUE if oTrapObject is detectable.
    public static int GetTrapDetectable(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(528);
      return VM.StackPopInt();
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - oCreature<br/>
    ///  * Returns TRUE if oCreature has detected oTrapObject
    public static int GetTrapDetectedBy(uint oTrapObject, uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.StackPush(oTrapObject);
      VM.Call(529);
      return VM.StackPopInt();
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns TRUE if oTrapObject has been flagged as visible to all creatures.
    public static int GetTrapFlagged(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(530);
      return VM.StackPopInt();
    }

    ///  Get the trap base type (TRAP_BASE_TYPE_*) of oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger
    public static int GetTrapBaseType(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(531);
      return VM.StackPopInt();
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns TRUE if oTrapObject is one-shot (i.e. it does not reset itself<br/>
    ///    after firing.
    public static int GetTrapOneShot(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(532);
      return VM.StackPopInt();
    }

    ///  Get the creator of oTrapObject, the creature that set the trap.<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns OBJECT_INVALID if oTrapObject was created in the toolset.
    public static uint GetTrapCreator(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(533);
      return VM.StackPopObject();
    }

    ///  Get the tag of the key that will disarm oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger
    public static string GetTrapKeyTag(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(534);
      return VM.StackPopString();
    }

    ///  Get the DC for disarming oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger
    public static int GetTrapDisarmDC(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(535);
      return VM.StackPopInt();
    }

    ///  Get the DC for detecting oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger
    public static int GetTrapDetectDC(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(536);
      return VM.StackPopInt();
    }

    ///  * Returns TRUE if a specific key is required to open the lock on oObject.
    public static int GetLockKeyRequired(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(537);
      return VM.StackPopInt();
    }

    ///  Get the tag of the key that will open the lock on oObject.
    public static string GetLockKeyTag(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(538);
      return VM.StackPopString();
    }

    ///  * Returns TRUE if the lock on oObject is lockable.
    public static int GetLockLockable(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(539);
      return VM.StackPopInt();
    }

    ///  Get the DC for unlocking oObject.
    public static int GetLockUnlockDC(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(540);
      return VM.StackPopInt();
    }

    ///  Get the DC for locking oObject.
    public static int GetLockLockDC(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(541);
      return VM.StackPopInt();
    }

    ///  Get the last PC that levelled up.
    public static uint GetPCLevellingUp()
    {
      VM.Call(542);
      return VM.StackPopObject();
    }

    ///  - nFeat: FEAT_*<br/>
    ///  - oObject<br/>
    ///  * Returns TRUE if oObject has effects on it originating from nFeat.
    public static int GetHasFeatEffect(int nFeat, uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.StackPush(nFeat);
      VM.Call(543);
      return VM.StackPopInt();
    }

    ///  Set the status of the illumination for oPlaceable.<br/>
    ///  - oPlaceable<br/>
    ///  - bIlluminate: if this is TRUE, oPlaceable&amp;apos;s illumination will be turned on.<br/>
    ///    If this is FALSE, oPlaceable&amp;apos;s illumination will be turned off.<br/>
    ///  Note: You must call RecomputeStaticLighting() after calling this function in<br/>
    ///  order for the changes to occur visually for the players.<br/>
    ///  SetPlaceableIllumination() buffers the illumination changes, which are then<br/>
    ///  sent out to the players once RecomputeStaticLighting() is called.  As such,<br/>
    ///  it is best to call SetPlaceableIllumination() for all the placeables you wish<br/>
    ///  to set the illumination on, and then call RecomputeStaticLighting() once after<br/>
    ///  all the placeable illumination has been set.<br/>
    ///  * If oPlaceable is not a placeable object, or oPlaceable is a placeable that<br/>
    ///    doesn&amp;apos;t have a light, nothing will happen.
    public static void SetPlaceableIllumination(uint oPlaceable = OBJECT_INVALID, int bIlluminate = TRUE)
    {
      VM.StackPush(bIlluminate);
      VM.StackPush(oPlaceable);
      VM.Call(544);
    }

    ///  * Returns TRUE if the illumination for oPlaceable is on
    public static int GetPlaceableIllumination(uint oPlaceable = OBJECT_INVALID)
    {
      VM.StackPush(oPlaceable);
      VM.Call(545);
      return VM.StackPopInt();
    }

    ///  - oPlaceable<br/>
    ///  - nPlaceableAction: PLACEABLE_ACTION_*<br/>
    ///  * Returns TRUE if nPlacebleAction is valid for oPlaceable.
    public static int GetIsPlaceableObjectActionPossible(uint oPlaceable, int nPlaceableAction)
    {
      VM.StackPush(nPlaceableAction);
      VM.StackPush(oPlaceable);
      VM.Call(546);
      return VM.StackPopInt();
    }

    ///  The caller performs nPlaceableAction on oPlaceable.<br/>
    ///  - oPlaceable<br/>
    ///  - nPlaceableAction: PLACEABLE_ACTION_*
    public static void DoPlaceableObjectAction(uint oPlaceable, int nPlaceableAction)
    {
      VM.StackPush(nPlaceableAction);
      VM.StackPush(oPlaceable);
      VM.Call(547);
    }

    ///  Get the first PC in the player list.<br/>
    ///  This resets the position in the player list for GetNextPC().
    public static uint GetFirstPC()
    {
      VM.Call(548);
      return VM.StackPopObject();
    }

    ///  Get the next PC in the player list.<br/>
    ///  This picks up where the last GetFirstPC() or GetNextPC() left off.
    public static uint GetNextPC()
    {
      VM.Call(549);
      return VM.StackPopObject();
    }

    ///  Set whether or not the creature oDetector has detected the trapped object oTrap.<br/>
    ///  - oTrap: A trapped trigger, placeable or door object.<br/>
    ///  - oDetector: This is the creature that the detected status of the trap is being adjusted for.<br/>
    ///  - bDetected: A Boolean that sets whether the trapped object has been detected or not.
    public static int SetTrapDetectedBy(uint oTrap, uint oDetector, int bDetected = TRUE)
    {
      VM.StackPush(bDetected);
      VM.StackPush(oDetector);
      VM.StackPush(oTrap);
      VM.Call(550);
      return VM.StackPopInt();
    }

    ///  Note: Only placeables, doors and triggers can be trapped.<br/>
    ///  * Returns TRUE if oObject is trapped.
    public static int GetIsTrapped(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(551);
      return VM.StackPopInt();
    }

    ///  Create a Turn Resistance Decrease effect.<br/>
    ///  - nHitDice: a positive number representing the number of hit dice for the<br/>
    /// /  decrease
    public static System.IntPtr EffectTurnResistanceDecrease(int nHitDice)
    {
      VM.StackPush(nHitDice);
      VM.Call(552);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create a Turn Resistance Increase effect.<br/>
    ///  - nHitDice: a positive number representing the number of hit dice for the<br/>
    ///    increase
    public static System.IntPtr EffectTurnResistanceIncrease(int nHitDice)
    {
      VM.StackPush(nHitDice);
      VM.Call(553);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Spawn in the Death GUI.<br/>
    ///  The default (as defined by BioWare) can be spawned in by PopUpGUIPanel, but<br/>
    ///  if you want to turn off the &amp;quot;Respawn&amp;quot; or &amp;quot;Wait for Help&amp;quot; buttons, this is the<br/>
    ///  function to use.<br/>
    ///  - oPC<br/>
    ///  - bRespawnButtonEnabled: if this is TRUE, the &amp;quot;Respawn&amp;quot; button will be enabled<br/>
    ///    on the Death GUI.<br/>
    ///  - bWaitForHelpButtonEnabled: if this is TRUE, the &amp;quot;Wait For Help&amp;quot; button will<br/>
    ///    be enabled on the Death GUI (Note: This button will not appear in single player games).<br/>
    ///  - nHelpStringReference<br/>
    ///  - sHelpString
    public static void PopUpDeathGUIPanel(uint oPC, int bRespawnButtonEnabled = TRUE, int bWaitForHelpButtonEnabled = TRUE, int nHelpStringReference = 0, string sHelpString = "")
    {
      VM.StackPush(sHelpString);
      VM.StackPush(nHelpStringReference);
      VM.StackPush(bWaitForHelpButtonEnabled);
      VM.StackPush(bRespawnButtonEnabled);
      VM.StackPush(oPC);
      VM.Call(554);
    }

    ///  Disable oTrap.<br/>
    ///  - oTrap: a placeable, door or trigger.
    public static void SetTrapDisabled(uint oTrap)
    {
      VM.StackPush(oTrap);
      VM.Call(555);
    }

    ///  Get the last object that was sent as a GetLastAttacker(), GetLastDamager(),<br/>
    ///  GetLastSpellCaster() (for a hostile spell), or GetLastDisturbed() (when a<br/>
    ///  creature is pickpocketed).<br/>
    ///  Note: Return values may only ever be:<br/>
    ///  1) A Creature<br/>
    ///  2) Plot Characters will never have this value set<br/>
    ///  3) Area of Effect Objects will return the AOE creator if they are registered<br/>
    ///     as this value, otherwise they will return INVALID_OBJECT_ID<br/>
    ///  4) Traps will not return the creature that set the trap.<br/>
    ///  5) This value will never be overwritten by another non-creature object.<br/>
    ///  6) This value will never be a dead/destroyed creature
    public static uint GetLastHostileActor(uint oVictim = OBJECT_INVALID)
    {
      VM.StackPush(oVictim);
      VM.Call(556);
      return VM.StackPopObject();
    }

    ///  Force all the characters of the players who are currently in the game to<br/>
    ///  be exported to their respective directories i.e. LocalVault/ServerVault/ etc.
    public static void ExportAllCharacters()
    {
      VM.Call(557);
    }

    ///  Get the Day Track for oArea.
    public static int MusicBackgroundGetDayTrack(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(558);
      return VM.StackPopInt();
    }

    ///  Get the Night Track for oArea.
    public static int MusicBackgroundGetNightTrack(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(559);
      return VM.StackPopInt();
    }

    ///  Write sLogEntry as a timestamped entry into the log file
    public static void WriteTimestampedLogEntry(string sLogEntry)
    {
      VM.StackPush(sLogEntry);
      VM.Call(560);
    }

    ///  Get the module&amp;apos;s name in the language of the server that&amp;apos;s running it.<br/>
    ///  * If there is no entry for the language of the server, it will return an<br/>
    ///    empty string
    public static string GetModuleName()
    {
      VM.Call(561);
      return VM.StackPopString();
    }

    ///  Get the player leader of the faction of which oMemberOfFaction is a member.<br/>
    ///  * Returns OBJECT_INVALID if oMemberOfFaction is not a valid creature,<br/>
    ///    or oMemberOfFaction is a member of a NPC faction.
    public static uint GetFactionLeader(uint oMemberOfFaction)
    {
      VM.StackPush(oMemberOfFaction);
      VM.Call(562);
      return VM.StackPopObject();
    }

    ///  Sends szMessage to all the Dungeon Masters currently on the server.
    public static void SendMessageToAllDMs(string szMessage)
    {
      VM.StackPush(szMessage);
      VM.Call(563);
    }

    ///  End the currently running game, play sEndMovie then return all players to the<br/>
    ///  game&amp;apos;s main menu.
    public static void EndGame(string sEndMovie)
    {
      VM.StackPush(sEndMovie);
      VM.Call(564);
    }

    ///  Remove oPlayer from the server.<br/>
    ///  You can optionally specify a reason to override the text shown to the player.
    public static void BootPC(uint oPlayer, string sReason = "")
    {
      VM.StackPush(sReason);
      VM.StackPush(oPlayer);
      VM.Call(565);
    }

    ///  Counterspell oCounterSpellTarget.
    public static void ActionCounterSpell(uint oCounterSpellTarget)
    {
      VM.StackPush(oCounterSpellTarget);
      VM.Call(566);
    }

    ///  Set the ambient day volume for oArea to nVolume.<br/>
    ///  - oArea<br/>
    ///  - nVolume: 0 - 100
    public static void AmbientSoundSetDayVolume(uint oArea, int nVolume)
    {
      VM.StackPush(nVolume);
      VM.StackPush(oArea);
      VM.Call(567);
    }

    ///  Set the ambient night volume for oArea to nVolume.<br/>
    ///  - oArea<br/>
    ///  - nVolume: 0 - 100
    public static void AmbientSoundSetNightVolume(uint oArea, int nVolume)
    {
      VM.StackPush(nVolume);
      VM.StackPush(oArea);
      VM.Call(568);
    }

    ///  Get the Battle Track for oArea.
    public static int MusicBackgroundGetBattleTrack(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(569);
      return VM.StackPopInt();
    }

    ///  Determine whether oObject has an inventory.<br/>
    ///  * Returns TRUE for creatures and stores, and checks to see if an item or placeable object is a container.<br/>
    ///  * Returns FALSE for all other object types.
    public static int GetHasInventory(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(570);
      return VM.StackPopInt();
    }

    ///  Get the duration (in seconds) of the sound attached to nStrRef<br/>
    ///  * Returns 0.0f if no duration is stored or if no sound is attached
    public static float GetStrRefSoundDuration(int nStrRef)
    {
      VM.StackPush(nStrRef);
      VM.Call(571);
      return VM.StackPopFloat();
    }

    ///  Add oPC to oPartyLeader&amp;apos;s party.  This will only work on two PCs.<br/>
    ///  - oPC: player to add to a party<br/>
    ///  - oPartyLeader: player already in the party
    public static void AddToParty(uint oPC, uint oPartyLeader)
    {
      VM.StackPush(oPartyLeader);
      VM.StackPush(oPC);
      VM.Call(572);
    }

    ///  Remove oPC from their current party. This will only work on a PC.<br/>
    ///  - oPC: removes this player from whatever party they&amp;apos;re currently in.
    public static void RemoveFromParty(uint oPC)
    {
      VM.StackPush(oPC);
      VM.Call(573);
    }

    ///  Returns the stealth mode of the specified creature.<br/>
    ///  - oCreature<br/>
    ///  * Returns a constant STEALTH_MODE_*
    public static int GetStealthMode(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(574);
      return VM.StackPopInt();
    }

    ///  Returns the detection mode of the specified creature.<br/>
    ///  - oCreature<br/>
    ///  * Returns a constant DETECT_MODE_*
    public static int GetDetectMode(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(575);
      return VM.StackPopInt();
    }

    ///  Returns the defensive casting mode of the specified creature.<br/>
    ///  - oCreature<br/>
    ///  * Returns a constant DEFENSIVE_CASTING_MODE_*
    public static int GetDefensiveCastingMode(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(576);
      return VM.StackPopInt();
    }

    ///  returns the appearance type of the specified creature.<br/>
    ///  * returns a constant APPEARANCE_TYPE_* for valid creatures<br/>
    ///  * returns APPEARANCE_TYPE_INVALID for non creatures/invalid creatures
    public static int GetAppearanceType(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(577);
      return VM.StackPopInt();
    }

    ///  SpawnScriptDebugger() will attempt to communicate with the a running script debugger<br/>
    ///  instance. You need to run it yourself, and enable it in Options/Config beforehand.<br/>
    ///  A sample debug server is included with the game installation in utils/.<br/>
    ///  Will only work in singleplayer, NOT on dedicated servers.<br/>
    ///  In order to compile the script for debugging go to Tools-&amp;gt;Options-&amp;gt;Script Editor<br/>
    ///  and check the box labeled &amp;quot;Generate Debug Information When Compiling Scripts&amp;quot;<br/>
    ///  After you have checked the above box, recompile the script that you want to debug.<br/>
    ///  If the script file isn&amp;apos;t compiled for debugging, this command will do nothing.<br/>
    ///  Remove any SpawnScriptDebugger() calls once you have finished<br/>
    ///  debugging the script.
    public static void SpawnScriptDebugger()
    {
      VM.Call(578);
    }

    ///  in an onItemAcquired script, returns the size of the stack of the item<br/>
    ///  that was just acquired.<br/>
    ///  * returns the stack size of the item acquired
    public static int GetModuleItemAcquiredStackSize()
    {
      VM.Call(579);
      return VM.StackPopInt();
    }

    ///  Decrement the remaining uses per day for this creature by one.<br/>
    ///  - oCreature: creature to modify<br/>
    ///  - nFeat: constant FEAT_*
    public static void DecrementRemainingFeatUses(uint oCreature, int nFeat)
    {
      VM.StackPush(nFeat);
      VM.StackPush(oCreature);
      VM.Call(580);
    }

    ///  Decrement the remaining uses per day for this creature by one.<br/>
    ///  - oCreature: creature to modify<br/>
    ///  - nSpell: constant SPELL_*
    public static void DecrementRemainingSpellUses(uint oCreature, int nSpell)
    {
      VM.StackPush(nSpell);
      VM.StackPush(oCreature);
      VM.Call(581);
    }

    ///  returns the template used to create this object (if appropriate)<br/>
    ///  * returns an empty string when no template found
    public static string GetResRef(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(582);
      return VM.StackPopString();
    }

    ///  returns an effect that will petrify the target<br/>
    ///  * currently applies EffectParalyze and the stoneskin visual effect.
    public static System.IntPtr EffectPetrify()
    {
      VM.Call(583);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  duplicates the item and returns a new object<br/>
    ///  oItem - item to copy<br/>
    ///  oTargetInventory - create item in this object&amp;apos;s inventory. If this parameter<br/>
    ///                     is not valid, the item will be created in oItem&amp;apos;s location<br/>
    ///  bCopyVars - copy the local variables from the old item to the new one<br/>
    ///  * returns the new item<br/>
    ///  * returns OBJECT_INVALID for non-items.<br/>
    ///  * can only copy empty item containers. will return OBJECT_INVALID if oItem contains<br/>
    ///    other items.<br/>
    ///  * if it is possible to merge this item with any others in the target location,<br/>
    ///    then it will do so and return the merged object.
    public static uint CopyItem(uint oItem, uint oTargetInventory = OBJECT_INVALID, int bCopyVars = FALSE)
    {
      VM.StackPush(bCopyVars);
      VM.StackPush(oTargetInventory);
      VM.StackPush(oItem);
      VM.Call(584);
      return VM.StackPopObject();
    }

    ///  returns an effect that is guaranteed to paralyze a creature.<br/>
    ///  this effect is identical to EffectParalyze except that it cannot be resisted.
    public static System.IntPtr EffectCutsceneParalyze()
    {
      VM.Call(585);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  returns TRUE if the item CAN be dropped<br/>
    ///  Droppable items will appear on a creature&amp;apos;s remains when the creature is killed.
    public static int GetDroppableFlag(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(586);
      return VM.StackPopInt();
    }

    ///  returns TRUE if the placeable object is usable
    public static int GetUseableFlag(uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.Call(587);
      return VM.StackPopInt();
    }

    ///  returns TRUE if the item is stolen
    public static int GetStolenFlag(uint oStolen)
    {
      VM.StackPush(oStolen);
      VM.Call(588);
      return VM.StackPopInt();
    }

    ///  This stores a float out to the specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static void SetCampaignFloat(string sCampaignName, string sVarName, float flFloat, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(flFloat);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(589);
    }

    ///  This stores an int out to the specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static void SetCampaignInt(string sCampaignName, string sVarName, int nInt, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(nInt);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(590);
    }

    ///  This stores a vector out to the specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static void SetCampaignVector(string sCampaignName, string sVarName, System.Numerics.Vector3 vVector, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(vVector);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(591);
    }

    ///  This stores a location out to the specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static void SetCampaignLocation(string sCampaignName, string sVarName, System.IntPtr locLocation, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(locLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(592);
    }

    ///  This stores a string out to the specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static void SetCampaignString(string sCampaignName, string sVarName, string sString, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sString);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(593);
    }

    ///  This will delete the entire campaign database if it exists.
    public static void DestroyCampaignDatabase(string sCampaignName)
    {
      VM.StackPush(sCampaignName);
      VM.Call(594);
    }

    ///  This will read a float from the  specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static float GetCampaignFloat(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(595);
      return VM.StackPopFloat();
    }

    ///  This will read an int from the  specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static int GetCampaignInt(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(596);
      return VM.StackPopInt();
    }

    ///  This will read a vector from the  specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static System.Numerics.Vector3 GetCampaignVector(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(597);
      return VM.StackPopVector();
    }

    ///  This will read a location from the  specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static System.IntPtr GetCampaignLocation(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(598);
      return VM.StackPopStruct(ENGINE_STRUCTURE_LOCATION);
    }

    ///  This will read a string from the  specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static string GetCampaignString(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(599);
      return VM.StackPopString();
    }

    ///  Duplicates the object specified by oSource.<br/>
    ///  NOTE: this command can be used for copying Creatures, Items, Placeables, Waypoints, Stores, Doors, Triggers.<br/>
    ///  If an owner is specified and the object is an item, it will be put into their inventory<br/>
    ///  Otherwise, it will be created at the location.<br/>
    ///  If a new tag is specified, it will be assigned to the new object.<br/>
    ///  If bCopyLocalState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are copied over.
    public static uint CopyObject(uint oSource, System.IntPtr locLocation, uint oOwner = OBJECT_INVALID, string sNewTag = "", int bCopyLocalState = FALSE)
    {
      VM.StackPush(bCopyLocalState);
      VM.StackPush(sNewTag);
      VM.StackPush(oOwner);
      VM.StackPush(locLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(oSource);
      VM.Call(600);
      return VM.StackPopObject();
    }

    ///  This will remove ANY campaign variable. Regardless of type.
    public static void DeleteCampaignVariable(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(601);
    }

    ///  Stores an object with the given id.<br/>
    ///  NOTE: this command can be used for storing Creatures, Items, Placeables, Waypoints, Stores, Doors, Triggers.<br/>
    ///  Returns 0 if it failled, 1 if it worked.<br/>
    ///  If bSaveObjectState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are saved out<br/>
    ///  (except for Combined Area Format, which always has object state saved out).
    public static int StoreCampaignObject(string sCampaignName, string sVarName, uint oObject, uint oPlayer = OBJECT_INVALID, int bSaveObjectState = FALSE)
    {
      VM.StackPush(bSaveObjectState);
      VM.StackPush(oPlayer);
      VM.StackPush(oObject);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(602);
      return VM.StackPopInt();
    }

    ///  Use RetrieveCampaign with the given id to restore it.<br/>
    ///  If you specify an owner, the object will try to be created in their repository<br/>
    ///  If the owner can&amp;apos;t handle the item (or if it&amp;apos;s a non-item) it will be created at the given location.<br/>
    ///  If bLoadObjectState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are read in.
    public static uint RetrieveCampaignObject(string sCampaignName, string sVarName, System.IntPtr locLocation, uint oOwner = OBJECT_INVALID, uint oPlayer = OBJECT_INVALID, int bLoadObjectState = FALSE)
    {
      VM.StackPush(bLoadObjectState);
      VM.StackPush(oPlayer);
      VM.StackPush(oOwner);
      VM.StackPush(locLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(603);
      return VM.StackPopObject();
    }

    ///  Returns an effect that is guaranteed to dominate a creature<br/>
    ///  Like EffectDominated but cannot be resisted
    public static System.IntPtr EffectCutsceneDominated()
    {
      VM.Call(604);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Returns stack size of an item<br/>
    ///  - oItem: item to query
    public static int GetItemStackSize(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(605);
      return VM.StackPopInt();
    }

    ///  Sets stack size of an item.<br/>
    ///  - oItem: item to change<br/>
    ///  - nSize: new size of stack.  Will be restricted to be between 1 and the<br/>
    ///    maximum stack size for the item type.  If a value less than 1 is passed it<br/>
    ///    will set the stack to 1.  If a value greater than the max is passed<br/>
    ///    then it will set the stack to the maximum size
    public static void SetItemStackSize(uint oItem, int nSize)
    {
      VM.StackPush(nSize);
      VM.StackPush(oItem);
      VM.Call(606);
    }

    ///  Returns charges left on an item<br/>
    ///  - oItem: item to query
    public static int GetItemCharges(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(607);
      return VM.StackPopInt();
    }

    ///  Sets charges left on an item.<br/>
    ///  - oItem: item to change<br/>
    ///  - nCharges: number of charges.  If value below 0 is passed, # charges will<br/>
    ///    be set to 0.  If value greater than maximum is passed, # charges will<br/>
    ///    be set to maximum.  If the # charges drops to 0 the item<br/>
    ///    will be destroyed.
    public static void SetItemCharges(uint oItem, int nCharges)
    {
      VM.StackPush(nCharges);
      VM.StackPush(oItem);
      VM.Call(608);
    }

    ///  ***********************  START OF ITEM PROPERTY FUNCTIONS  **********************<br/>
    ///  adds an item property to the specified item<br/>
    ///  Only temporary and permanent duration types are allowed.
    public static void AddItemProperty(int nDurationType, System.IntPtr ipProperty, uint oItem, float fDuration = 0.0f)
    {
      VM.StackPush(fDuration);
      VM.StackPush(oItem);
      VM.StackPush(ipProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.StackPush(nDurationType);
      VM.Call(609);
    }

    ///  removes an item property from the specified item
    public static void RemoveItemProperty(uint oItem, System.IntPtr ipProperty)
    {
      VM.StackPush(ipProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.StackPush(oItem);
      VM.Call(610);
    }

    ///  if the item property is valid this will return true
    public static int GetIsItemPropertyValid(System.IntPtr ipProperty)
    {
      VM.StackPush(ipProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(611);
      return VM.StackPopInt();
    }

    ///  Gets the first item property on an item
    public static System.IntPtr GetFirstItemProperty(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(612);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Will keep retrieving the next and the next item property on an Item,<br/>
    ///  will return an invalid item property when the list is empty.
    public static System.IntPtr GetNextItemProperty(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(613);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  will return the item property type (ie. holy avenger)
    public static int GetItemPropertyType(System.IntPtr ip)
    {
      VM.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(614);
      return VM.StackPopInt();
    }

    ///  will return the duration type of the item property
    public static int GetItemPropertyDurationType(System.IntPtr ip)
    {
      VM.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(615);
      return VM.StackPopInt();
    }

    ///  Returns Item property ability bonus.  You need to specify an<br/>
    ///  ability constant(IP_CONST_ABILITY_*) and the bonus.  The bonus should<br/>
    ///  be a positive integer between 1 and 12.
    public static System.IntPtr ItemPropertyAbilityBonus(int nAbility, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nAbility);
      VM.Call(616);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property AC bonus.  You need to specify the bonus.<br/>
    ///  The bonus should be a positive integer between 1 and 20. The modifier<br/>
    ///  type depends on the item it is being applied to.
    public static System.IntPtr ItemPropertyACBonus(int nBonus)
    {
      VM.StackPush(nBonus);
      VM.Call(617);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property AC bonus vs. alignment group.  An example of<br/>
    ///  an alignment group is Chaotic, or Good.  You need to specify the<br/>
    ///  alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the AC bonus.<br/>
    ///  The AC bonus should be an integer between 1 and 20.  The modifier<br/>
    ///  type depends on the item it is being applied to.
    public static System.IntPtr ItemPropertyACBonusVsAlign(int nAlignGroup, int nACBonus)
    {
      VM.StackPush(nACBonus);
      VM.StackPush(nAlignGroup);
      VM.Call(618);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property AC bonus vs. Damage type (ie. piercing).  You<br/>
    ///  need to specify the damage type constant(IP_CONST_DAMAGETYPE_*) and the<br/>
    ///  AC bonus.  The AC bonus should be an integer between 1 and 20.  The<br/>
    ///  modifier type depends on the item it is being applied to.<br/>
    ///  NOTE: Only the first 3 damage types may be used here, the 3 basic<br/>
    ///        physical types.
    public static System.IntPtr ItemPropertyACBonusVsDmgType(int nDamageType, int nACBonus)
    {
      VM.StackPush(nACBonus);
      VM.StackPush(nDamageType);
      VM.Call(619);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property AC bonus vs. Racial group.  You need to specify<br/>
    ///  the racial group constant(IP_CONST_RACIALTYPE_*) and the AC bonus.  The AC<br/>
    ///  bonus should be an integer between 1 and 20.  The modifier type depends<br/>
    ///  on the item it is being applied to.
    public static System.IntPtr ItemPropertyACBonusVsRace(int nRace, int nACBonus)
    {
      VM.StackPush(nACBonus);
      VM.StackPush(nRace);
      VM.Call(620);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property AC bonus vs. Specific alignment.  You need to<br/>
    ///  specify the specific alignment constant(IP_CONST_ALIGNMENT_*) and the AC<br/>
    ///  bonus.  The AC bonus should be an integer between 1 and 20.  The<br/>
    ///  modifier type depends on the item it is being applied to.
    public static System.IntPtr ItemPropertyACBonusVsSAlign(int nAlign, int nACBonus)
    {
      VM.StackPush(nACBonus);
      VM.StackPush(nAlign);
      VM.Call(621);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Enhancement bonus.  You need to specify the<br/>
    ///  enhancement bonus.  The Enhancement bonus should be an integer between<br/>
    ///  1 and 20.
    public static System.IntPtr ItemPropertyEnhancementBonus(int nEnhancementBonus)
    {
      VM.StackPush(nEnhancementBonus);
      VM.Call(622);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Enhancement bonus vs. an Alignment group.  You<br/>
    ///  need to specify the alignment group constant(IP_CONST_ALIGNMENTGROUP_*)<br/>
    ///  and the enhancement bonus.  The Enhancement bonus should be an integer<br/>
    ///  between 1 and 20.
    public static System.IntPtr ItemPropertyEnhancementBonusVsAlign(int nAlignGroup, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nAlignGroup);
      VM.Call(623);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Enhancement bonus vs. Racial group.  You need<br/>
    ///  to specify the racial group constant(IP_CONST_RACIALTYPE_*) and the<br/>
    ///  enhancement bonus.  The enhancement bonus should be an integer between<br/>
    ///  1 and 20.
    public static System.IntPtr ItemPropertyEnhancementBonusVsRace(int nRace, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nRace);
      VM.Call(624);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Enhancement bonus vs. a specific alignment.  You<br/>
    ///  need to specify the alignment constant(IP_CONST_ALIGNMENT_*) and the<br/>
    ///  enhancement bonus.  The enhancement bonus should be an integer between<br/>
    ///  1 and 20.
    public static System.IntPtr ItemPropertyEnhancementBonusVsSAlign(int nAlign, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nAlign);
      VM.Call(625);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Enhancment penalty.  You need to specify the<br/>
    ///  enhancement penalty.  The enhancement penalty should be a POSITIVE<br/>
    ///  integer between 1 and 5 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyEnhancementPenalty(int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.Call(626);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property weight reduction.  You need to specify the weight<br/>
    ///  reduction constant(IP_CONST_REDUCEDWEIGHT_*).
    public static System.IntPtr ItemPropertyWeightReduction(int nReduction)
    {
      VM.StackPush(nReduction);
      VM.Call(627);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Bonus Feat.  You need to specify the the feat<br/>
    ///  constant(IP_CONST_FEAT_*).
    public static System.IntPtr ItemPropertyBonusFeat(int nFeat)
    {
      VM.StackPush(nFeat);
      VM.Call(628);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Bonus level spell (Bonus spell of level).  You must<br/>
    ///  specify the class constant(IP_CONST_CLASS_*) of the bonus spell(MUST BE a<br/>
    ///  spell casting class) and the level of the bonus spell.  The level of the<br/>
    ///  bonus spell should be an integer between 0 and 9.
    public static System.IntPtr ItemPropertyBonusLevelSpell(int nClass, int nSpellLevel)
    {
      VM.StackPush(nSpellLevel);
      VM.StackPush(nClass);
      VM.Call(629);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Cast spell.  You must specify the spell constant<br/>
    ///  (IP_CONST_CASTSPELL_*) and the number of uses constant(IP_CONST_CASTSPELL_NUMUSES_*).<br/>
    ///  NOTE: The number after the name of the spell in the constant is the level<br/>
    ///        at which the spell will be cast.  Sometimes there are multiple copies<br/>
    ///        of the same spell but they each are cast at a different level.  The higher<br/>
    ///        the level, the more cost will be added to the item.<br/>
    ///  NOTE: The list of spells that can be applied to an item will depend on the<br/>
    ///        item type.  For instance there are spells that can be applied to a wand<br/>
    ///        that cannot be applied to a potion.  Below is a list of the types and the<br/>
    ///        spells that are allowed to be placed on them.  If you try to put a cast<br/>
    ///        spell effect on an item that is not allowed to have that effect it will<br/>
    ///        not work.<br/>
    ///  NOTE: Even if spells have multiple versions of different levels they are only<br/>
    ///        listed below once.<br/>
    /// <br/>
    ///  WANDS:<br/>
    ///           Acid_Splash<br/>
    ///           Activate_Item<br/>
    ///           Aid<br/>
    ///           Amplify<br/>
    ///           Animate_Dead<br/>
    ///           AuraOfGlory<br/>
    ///           BalagarnsIronHorn<br/>
    ///           Bane<br/>
    ///           Banishment<br/>
    ///           Barkskin<br/>
    ///           Bestow_Curse<br/>
    ///           Bigbys_Clenched_Fist<br/>
    ///           Bigbys_Crushing_Hand<br/>
    ///           Bigbys_Forceful_Hand<br/>
    ///           Bigbys_Grasping_Hand<br/>
    ///           Bigbys_Interposing_Hand<br/>
    ///           Bless<br/>
    ///           Bless_Weapon<br/>
    ///           Blindness/Deafness<br/>
    ///           Blood_Frenzy<br/>
    ///           Bombardment<br/>
    ///           Bulls_Strength<br/>
    ///           Burning_Hands<br/>
    ///           Call_Lightning<br/>
    ///           Camoflage<br/>
    ///           Cats_Grace<br/>
    ///           Charm_Monster<br/>
    ///           Charm_Person<br/>
    ///           Charm_Person_or_Animal<br/>
    ///           Clairaudience/Clairvoyance<br/>
    ///           Clarity<br/>
    ///           Color_Spray<br/>
    ///           Confusion<br/>
    ///           Continual_Flame<br/>
    ///           Cure_Critical_Wounds<br/>
    ///           Cure_Light_Wounds<br/>
    ///           Cure_Minor_Wounds<br/>
    ///           Cure_Moderate_Wounds<br/>
    ///           Cure_Serious_Wounds<br/>
    ///           Darkness<br/>
    ///           Darkvision<br/>
    ///           Daze<br/>
    ///           Death_Ward<br/>
    ///           Dirge<br/>
    ///           Dismissal<br/>
    ///           Dispel_Magic<br/>
    ///           Displacement<br/>
    ///           Divine_Favor<br/>
    ///           Divine_Might<br/>
    ///           Divine_Power<br/>
    ///           Divine_Shield<br/>
    ///           Dominate_Animal<br/>
    ///           Dominate_Person<br/>
    ///           Doom<br/>
    ///           Dragon_Breath_Acid<br/>
    ///           Dragon_Breath_Cold<br/>
    ///           Dragon_Breath_Fear<br/>
    ///           Dragon_Breath_Fire<br/>
    ///           Dragon_Breath_Gas<br/>
    ///           Dragon_Breath_Lightning<br/>
    ///           Dragon_Breath_Paralyze<br/>
    ///           Dragon_Breath_Sleep<br/>
    ///           Dragon_Breath_Slow<br/>
    ///           Dragon_Breath_Weaken<br/>
    ///           Drown<br/>
    ///           Eagle_Spledor<br/>
    ///           Earthquake<br/>
    ///           Electric_Jolt<br/>
    ///           Elemental_Shield<br/>
    ///           Endurance<br/>
    ///           Endure_Elements<br/>
    ///           Enervation<br/>
    ///           Entangle<br/>
    ///           Entropic_Shield<br/>
    ///           Etherealness<br/>
    ///           Expeditious_Retreat<br/>
    ///           Fear<br/>
    ///           Find_Traps<br/>
    ///           Fireball<br/>
    ///           Firebrand<br/>
    ///           Flame_Arrow<br/>
    ///           Flame_Lash<br/>
    ///           Flame_Strike<br/>
    ///           Flare<br/>
    ///           Foxs_Cunning<br/>
    ///           Freedom_of_Movement<br/>
    ///           Ghostly_Visage<br/>
    ///           Ghoul_Touch<br/>
    ///           Grease<br/>
    ///           Greater_Magic_Fang<br/>
    ///           Greater_Magic_Weapon<br/>
    ///           Grenade_Acid<br/>
    ///           Grenade_Caltrops<br/>
    ///           Grenade_Chicken<br/>
    ///           Grenade_Choking<br/>
    ///           Grenade_Fire<br/>
    ///           Grenade_Holy<br/>
    ///           Grenade_Tangle<br/>
    ///           Grenade_Thunderstone<br/>
    ///           Gust_of_wind<br/>
    ///           Hammer_of_the_Gods<br/>
    ///           Haste<br/>
    ///           Hold_Animal<br/>
    ///           Hold_Monster<br/>
    ///           Hold_Person<br/>
    ///           Ice_Storm<br/>
    ///           Identify<br/>
    ///           Improved_Invisibility<br/>
    ///           Inferno<br/>
    ///           Inflict_Critical_Wounds<br/>
    ///           Inflict_Light_Wounds<br/>
    ///           Inflict_Minor_Wounds<br/>
    ///           Inflict_Moderate_Wounds<br/>
    ///           Inflict_Serious_Wounds<br/>
    ///           Invisibility<br/>
    ///           Invisibility_Purge<br/>
    ///           Invisibility_Sphere<br/>
    ///           Isaacs_Greater_Missile_Storm<br/>
    ///           Isaacs_Lesser_Missile_Storm<br/>
    ///           Knock<br/>
    ///           Lesser_Dispel<br/>
    ///           Lesser_Restoration<br/>
    ///           Lesser_Spell_Breach<br/>
    ///           Light<br/>
    ///           Lightning_Bolt<br/>
    ///           Mage_Armor<br/>
    ///           Magic_Circle_against_Alignment<br/>
    ///           Magic_Fang<br/>
    ///           Magic_Missile<br/>
    ///           Manipulate_Portal_Stone<br/>
    ///           Mass_Camoflage<br/>
    ///           Melfs_Acid_Arrow<br/>
    ///           Meteor_Swarm<br/>
    ///           Mind_Blank<br/>
    ///           Mind_Fog<br/>
    ///           Negative_Energy_Burst<br/>
    ///           Negative_Energy_Protection<br/>
    ///           Negative_Energy_Ray<br/>
    ///           Neutralize_Poison<br/>
    ///           One_With_The_Land<br/>
    ///           Owls_Insight<br/>
    ///           Owls_Wisdom<br/>
    ///           Phantasmal_Killer<br/>
    ///           Planar_Ally<br/>
    ///           Poison<br/>
    ///           Polymorph_Self<br/>
    ///           Prayer<br/>
    ///           Protection_from_Alignment<br/>
    ///           Protection_From_Elements<br/>
    ///           Quillfire<br/>
    ///           Ray_of_Enfeeblement<br/>
    ///           Ray_of_Frost<br/>
    ///           Remove_Blindness/Deafness<br/>
    ///           Remove_Curse<br/>
    ///           Remove_Disease<br/>
    ///           Remove_Fear<br/>
    ///           Remove_Paralysis<br/>
    ///           Resist_Elements<br/>
    ///           Resistance<br/>
    ///           Restoration<br/>
    ///           Sanctuary<br/>
    ///           Scare<br/>
    ///           Searing_Light<br/>
    ///           See_Invisibility<br/>
    ///           Shadow_Conjuration<br/>
    ///           Shield<br/>
    ///           Shield_of_Faith<br/>
    ///           Silence<br/>
    ///           Sleep<br/>
    ///           Slow<br/>
    ///           Sound_Burst<br/>
    ///           Spike_Growth<br/>
    ///           Stinking_Cloud<br/>
    ///           Stoneskin<br/>
    ///           Summon_Creature_I<br/>
    ///           Summon_Creature_I<br/>
    ///           Summon_Creature_II<br/>
    ///           Summon_Creature_III<br/>
    ///           Summon_Creature_IV<br/>
    ///           Sunburst<br/>
    ///           Tashas_Hideous_Laughter<br/>
    ///           True_Strike<br/>
    ///           Undeaths_Eternal_Foe<br/>
    ///           Unique_Power<br/>
    ///           Unique_Power_Self_Only<br/>
    ///           Vampiric_Touch<br/>
    ///           Virtue<br/>
    ///           Wall_of_Fire<br/>
    ///           Web<br/>
    ///           Wounding_Whispers<br/>
    /// <br/>
    ///  POTIONS:<br/>
    ///           Activate_Item<br/>
    ///           Aid<br/>
    ///           Amplify<br/>
    ///           AuraOfGlory<br/>
    ///           Bane<br/>
    ///           Barkskin<br/>
    ///           Barkskin<br/>
    ///           Barkskin<br/>
    ///           Bless<br/>
    ///           Bless_Weapon<br/>
    ///           Bless_Weapon<br/>
    ///           Blood_Frenzy<br/>
    ///           Bulls_Strength<br/>
    ///           Bulls_Strength<br/>
    ///           Bulls_Strength<br/>
    ///           Camoflage<br/>
    ///           Cats_Grace<br/>
    ///           Cats_Grace<br/>
    ///           Cats_Grace<br/>
    ///           Clairaudience/Clairvoyance<br/>
    ///           Clairaudience/Clairvoyance<br/>
    ///           Clairaudience/Clairvoyance<br/>
    ///           Clarity<br/>
    ///           Continual_Flame<br/>
    ///           Cure_Critical_Wounds<br/>
    ///           Cure_Critical_Wounds<br/>
    ///           Cure_Critical_Wounds<br/>
    ///           Cure_Light_Wounds<br/>
    ///           Cure_Light_Wounds<br/>
    ///           Cure_Minor_Wounds<br/>
    ///           Cure_Moderate_Wounds<br/>
    ///           Cure_Moderate_Wounds<br/>
    ///           Cure_Moderate_Wounds<br/>
    ///           Cure_Serious_Wounds<br/>
    ///           Cure_Serious_Wounds<br/>
    ///           Cure_Serious_Wounds<br/>
    ///           Darkness<br/>
    ///           Darkvision<br/>
    ///           Darkvision<br/>
    ///           Death_Ward<br/>
    ///           Dispel_Magic<br/>
    ///           Dispel_Magic<br/>
    ///           Displacement<br/>
    ///           Divine_Favor<br/>
    ///           Divine_Might<br/>
    ///           Divine_Power<br/>
    ///           Divine_Shield<br/>
    ///           Dragon_Breath_Acid<br/>
    ///           Dragon_Breath_Cold<br/>
    ///           Dragon_Breath_Fear<br/>
    ///           Dragon_Breath_Fire<br/>
    ///           Dragon_Breath_Gas<br/>
    ///           Dragon_Breath_Lightning<br/>
    ///           Dragon_Breath_Paralyze<br/>
    ///           Dragon_Breath_Sleep<br/>
    ///           Dragon_Breath_Slow<br/>
    ///           Dragon_Breath_Weaken<br/>
    ///           Eagle_Spledor<br/>
    ///           Eagle_Spledor<br/>
    ///           Eagle_Spledor<br/>
    ///           Elemental_Shield<br/>
    ///           Elemental_Shield<br/>
    ///           Endurance<br/>
    ///           Endurance<br/>
    ///           Endurance<br/>
    ///           Endure_Elements<br/>
    ///           Entropic_Shield<br/>
    ///           Ethereal_Visage<br/>
    ///           Ethereal_Visage<br/>
    ///           Etherealness<br/>
    ///           Expeditious_Retreat<br/>
    ///           Find_Traps<br/>
    ///           Foxs_Cunning<br/>
    ///           Foxs_Cunning<br/>
    ///           Foxs_Cunning<br/>
    ///           Freedom_of_Movement<br/>
    ///           Ghostly_Visage<br/>
    ///           Ghostly_Visage<br/>
    ///           Ghostly_Visage<br/>
    ///           Globe_of_Invulnerability<br/>
    ///           Greater_Bulls_Strength<br/>
    ///           Greater_Cats_Grace<br/>
    ///           Greater_Dispelling<br/>
    ///           Greater_Dispelling<br/>
    ///           Greater_Eagles_Splendor<br/>
    ///           Greater_Endurance<br/>
    ///           Greater_Foxs_Cunning<br/>
    ///           Greater_Magic_Weapon<br/>
    ///           Greater_Owls_Wisdom<br/>
    ///           Greater_Restoration<br/>
    ///           Greater_Spell_Mantle<br/>
    ///           Greater_Stoneskin<br/>
    ///           Grenade_Acid<br/>
    ///           Grenade_Caltrops<br/>
    ///           Grenade_Chicken<br/>
    ///           Grenade_Choking<br/>
    ///           Grenade_Fire<br/>
    ///           Grenade_Holy<br/>
    ///           Grenade_Tangle<br/>
    ///           Grenade_Thunderstone<br/>
    ///           Haste<br/>
    ///           Haste<br/>
    ///           Heal<br/>
    ///           Hold_Animal<br/>
    ///           Hold_Monster<br/>
    ///           Hold_Person<br/>
    ///           Identify<br/>
    ///           Invisibility<br/>
    ///           Lesser_Dispel<br/>
    ///           Lesser_Dispel<br/>
    ///           Lesser_Mind_Blank<br/>
    ///           Lesser_Restoration<br/>
    ///           Lesser_Spell_Mantle<br/>
    ///           Light<br/>
    ///           Light<br/>
    ///           Mage_Armor<br/>
    ///           Manipulate_Portal_Stone<br/>
    ///           Mass_Camoflage<br/>
    ///           Mind_Blank<br/>
    ///           Minor_Globe_of_Invulnerability<br/>
    ///           Minor_Globe_of_Invulnerability<br/>
    ///           Mordenkainens_Disjunction<br/>
    ///           Negative_Energy_Protection<br/>
    ///           Negative_Energy_Protection<br/>
    ///           Negative_Energy_Protection<br/>
    ///           Neutralize_Poison<br/>
    ///           One_With_The_Land<br/>
    ///           Owls_Insight<br/>
    ///           Owls_Wisdom<br/>
    ///           Owls_Wisdom<br/>
    ///           Owls_Wisdom<br/>
    ///           Polymorph_Self<br/>
    ///           Prayer<br/>
    ///           Premonition<br/>
    ///           Protection_From_Elements<br/>
    ///           Protection_From_Elements<br/>
    ///           Protection_from_Spells<br/>
    ///           Protection_from_Spells<br/>
    ///           Raise_Dead<br/>
    ///           Remove_Blindness/Deafness<br/>
    ///           Remove_Curse<br/>
    ///           Remove_Disease<br/>
    ///           Remove_Fear<br/>
    ///           Remove_Paralysis<br/>
    ///           Resist_Elements<br/>
    ///           Resist_Elements<br/>
    ///           Resistance<br/>
    ///           Resistance<br/>
    ///           Restoration<br/>
    ///           Resurrection<br/>
    ///           Rogues_Cunning<br/>
    ///           See_Invisibility<br/>
    ///           Shadow_Shield<br/>
    ///           Shapechange<br/>
    ///           Shield<br/>
    ///           Shield_of_Faith<br/>
    ///           Special_Alcohol_Beer<br/>
    ///           Special_Alcohol_Spirits<br/>
    ///           Special_Alcohol_Wine<br/>
    ///           Special_Herb_Belladonna<br/>
    ///           Special_Herb_Garlic<br/>
    ///           Spell_Mantle<br/>
    ///           Spell_Resistance<br/>
    ///           Spell_Resistance<br/>
    ///           Stoneskin<br/>
    ///           Tensers_Transformation<br/>
    ///           True_Seeing<br/>
    ///           True_Strike<br/>
    ///           Unique_Power<br/>
    ///           Unique_Power_Self_Only<br/>
    ///           Virtue<br/>
    /// <br/>
    ///  GENERAL USE (ie. everything else):<br/>
    ///           Just about every spell is useable by all the general use items so instead we<br/>
    ///           will only list the ones that are not allowed:<br/>
    ///           Special_Alcohol_Beer<br/>
    ///           Special_Alcohol_Spirits<br/>
    ///           Special_Alcohol_Wine<br/>
    /// 
    public static System.IntPtr ItemPropertyCastSpell(int nSpell, int nNumUses)
    {
      VM.StackPush(nNumUses);
      VM.StackPush(nSpell);
      VM.Call(630);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage bonus.  You must specify the damage type constant<br/>
    ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).<br/>
    ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,<br/>
    ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
    public static System.IntPtr ItemPropertyDamageBonus(int nDamageType, int nDamage)
    {
      VM.StackPush(nDamage);
      VM.StackPush(nDamageType);
      VM.Call(631);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage bonus vs. Alignment groups.  You must specify the<br/>
    ///  alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the damage type constant<br/>
    ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).<br/>
    ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,<br/>
    ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
    public static System.IntPtr ItemPropertyDamageBonusVsAlign(int nAlignGroup, int nDamageType, int nDamage)
    {
      VM.StackPush(nDamage);
      VM.StackPush(nDamageType);
      VM.StackPush(nAlignGroup);
      VM.Call(632);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage bonus vs. specific race.  You must specify the<br/>
    ///  racial group constant(IP_CONST_RACIALTYPE_*) and the damage type constant<br/>
    ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).<br/>
    ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,<br/>
    ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
    public static System.IntPtr ItemPropertyDamageBonusVsRace(int nRace, int nDamageType, int nDamage)
    {
      VM.StackPush(nDamage);
      VM.StackPush(nDamageType);
      VM.StackPush(nRace);
      VM.Call(633);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage bonus vs. specific alignment.  You must specify the<br/>
    ///  specific alignment constant(IP_CONST_ALIGNMENT_*) and the damage type constant<br/>
    ///  (IP_CONST_DAMAGETYPE_*) and the amount of damage constant(IP_CONST_DAMAGEBONUS_*).<br/>
    ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,<br/>
    ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
    public static System.IntPtr ItemPropertyDamageBonusVsSAlign(int nAlign, int nDamageType, int nDamage)
    {
      VM.StackPush(nDamage);
      VM.StackPush(nDamageType);
      VM.StackPush(nAlign);
      VM.Call(634);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage immunity.  You must specify the damage type constant<br/>
    ///  (IP_CONST_DAMAGETYPE_*) that you want to be immune to and the immune bonus percentage<br/>
    ///  constant(IP_CONST_DAMAGEIMMUNITY_*).<br/>
    ///  NOTE: not all the damage types will work, use only the following: Acid, Bludgeoning,<br/>
    ///        Cold, Electrical, Fire, Piercing, Slashing, Sonic.
    public static System.IntPtr ItemPropertyDamageImmunity(int nDamageType, int nImmuneBonus)
    {
      VM.StackPush(nImmuneBonus);
      VM.StackPush(nDamageType);
      VM.Call(635);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage penalty.  You must specify the damage penalty.<br/>
    ///  The damage penalty should be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyDamagePenalty(int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.Call(636);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage reduction.  You must specify the enhancment level<br/>
    ///  (IP_CONST_DAMAGEREDUCTION_*) that is required to get past the damage reduction<br/>
    ///  and the amount of HP of damage constant(IP_CONST_DAMAGESOAK_*) will be soaked<br/>
    ///  up if your weapon is not of high enough enhancement.
    public static System.IntPtr ItemPropertyDamageReduction(int nEnhancement, int nHPSoak)
    {
      VM.StackPush(nHPSoak);
      VM.StackPush(nEnhancement);
      VM.Call(637);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage resistance.  You must specify the damage type<br/>
    ///  constant(IP_CONST_DAMAGETYPE_*) and the amount of HP of damage constant<br/>
    ///  (IP_CONST_DAMAGERESIST_*) that will be resisted against each round.
    public static System.IntPtr ItemPropertyDamageResistance(int nDamageType, int nHPResist)
    {
      VM.StackPush(nHPResist);
      VM.StackPush(nDamageType);
      VM.Call(638);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property damage vulnerability.  You must specify the damage type<br/>
    ///  constant(IP_CONST_DAMAGETYPE_*) that you want the user to be extra vulnerable to<br/>
    ///  and the percentage vulnerability constant(IP_CONST_DAMAGEVULNERABILITY_*).
    public static System.IntPtr ItemPropertyDamageVulnerability(int nDamageType, int nVulnerability)
    {
      VM.StackPush(nVulnerability);
      VM.StackPush(nDamageType);
      VM.Call(639);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Return Item property Darkvision.
    public static System.IntPtr ItemPropertyDarkvision()
    {
      VM.Call(640);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Return Item property decrease ability score.  You must specify the ability<br/>
    ///  constant(IP_CONST_ABILITY_*) and the modifier constant.  The modifier must be<br/>
    ///  a POSITIVE integer between 1 and 10 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyDecreaseAbility(int nAbility, int nModifier)
    {
      VM.StackPush(nModifier);
      VM.StackPush(nAbility);
      VM.Call(641);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property decrease Armor Class.  You must specify the armor<br/>
    ///  modifier type constant(IP_CONST_ACMODIFIERTYPE_*) and the armor class penalty.<br/>
    ///  The penalty must be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyDecreaseAC(int nModifierType, int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.StackPush(nModifierType);
      VM.Call(642);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property decrease skill.  You must specify the constant for the<br/>
    ///  skill to be decreased(SKILL_*) and the amount of the penalty.  The penalty<br/>
    ///  must be a POSITIVE integer between 1 and 10 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyDecreaseSkill(int nSkill, int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.StackPush(nSkill);
      VM.Call(643);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property container reduced weight.  This is used for special<br/>
    ///  containers that reduce the weight of the objects inside them.  You must<br/>
    ///  specify the container weight reduction type constant(IP_CONST_CONTAINERWEIGHTRED_*).
    public static System.IntPtr ItemPropertyContainerReducedWeight(int nContainerType)
    {
      VM.StackPush(nContainerType);
      VM.Call(644);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property extra melee damage type.  You must specify the extra<br/>
    ///  melee base damage type that you want applied.  It is a constant(IP_CONST_DAMAGETYPE_*).<br/>
    ///  NOTE: only the first 3 base types (piercing, slashing, &amp; bludgeoning are applicable<br/>
    ///        here.<br/>
    ///  NOTE: It is also only applicable to melee weapons.
    public static System.IntPtr ItemPropertyExtraMeleeDamageType(int nDamageType)
    {
      VM.StackPush(nDamageType);
      VM.Call(645);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property extra ranged damage type.  You must specify the extra<br/>
    ///  melee base damage type that you want applied.  It is a constant(IP_CONST_DAMAGETYPE_*).<br/>
    ///  NOTE: only the first 3 base types (piercing, slashing, &amp; bludgeoning are applicable<br/>
    ///        here.<br/>
    ///  NOTE: It is also only applicable to ranged weapons.
    public static System.IntPtr ItemPropertyExtraRangeDamageType(int nDamageType)
    {
      VM.StackPush(nDamageType);
      VM.Call(646);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property haste.
    public static System.IntPtr ItemPropertyHaste()
    {
      VM.Call(647);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Holy Avenger.
    public static System.IntPtr ItemPropertyHolyAvenger()
    {
      VM.Call(648);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property immunity to miscellaneous effects.  You must specify the<br/>
    ///  effect to which the user is immune, it is a constant(IP_CONST_IMMUNITYMISC_*).
    public static System.IntPtr ItemPropertyImmunityMisc(int nImmunityType)
    {
      VM.StackPush(nImmunityType);
      VM.Call(649);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property improved evasion.
    public static System.IntPtr ItemPropertyImprovedEvasion()
    {
      VM.Call(650);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property bonus spell resistance.  You must specify the bonus spell<br/>
    ///  resistance constant(IP_CONST_SPELLRESISTANCEBONUS_*).
    public static System.IntPtr ItemPropertyBonusSpellResistance(int nBonus)
    {
      VM.StackPush(nBonus);
      VM.Call(651);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property saving throw bonus vs. a specific effect or damage type.<br/>
    ///  You must specify the save type constant(IP_CONST_SAVEVS_*) that the bonus is<br/>
    ///  applied to and the bonus that is be applied.  The bonus must be an integer<br/>
    ///  between 1 and 20.
    public static System.IntPtr ItemPropertyBonusSavingThrowVsX(int nBonusType, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nBonusType);
      VM.Call(652);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property saving throw bonus to the base type (ie. will, reflex,<br/>
    ///  fortitude).  You must specify the base type constant(IP_CONST_SAVEBASETYPE_*)<br/>
    ///  to which the user gets the bonus and the bonus that he/she will get.  The<br/>
    ///  bonus must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyBonusSavingThrow(int nBaseSaveType, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nBaseSaveType);
      VM.Call(653);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property keen.  This means a critical threat range of 19-20 on a<br/>
    ///  weapon will be increased to 17-20 etc.
    public static System.IntPtr ItemPropertyKeen()
    {
      VM.Call(654);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property light.  You must specify the intesity constant of the<br/>
    ///  light(IP_CONST_LIGHTBRIGHTNESS_*) and the color constant of the light<br/>
    ///  (IP_CONST_LIGHTCOLOR_*).
    public static System.IntPtr ItemPropertyLight(int nBrightness, int nColor)
    {
      VM.StackPush(nColor);
      VM.StackPush(nBrightness);
      VM.Call(655);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Max range strength modification (ie. mighty).  You must<br/>
    ///  specify the maximum modifier for strength that is allowed on a ranged weapon.<br/>
    ///  The modifier must be a positive integer between 1 and 20.
    public static System.IntPtr ItemPropertyMaxRangeStrengthMod(int nModifier)
    {
      VM.StackPush(nModifier);
      VM.Call(656);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property no damage.  This means the weapon will do no damage in<br/>
    ///  combat.
    public static System.IntPtr ItemPropertyNoDamage()
    {
      VM.Call(657);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property on hit -&amp;gt; do effect property.  You must specify the on<br/>
    ///  hit property constant(IP_CONST_ONHIT_*) and the save DC constant(IP_CONST_ONHIT_SAVEDC_*).<br/>
    ///  Some of the item properties require a special parameter as well.  If the<br/>
    ///  property does not require one you may leave out the last one.  The list of<br/>
    ///  the ones with 3 parameters and what they are are as follows:<br/>
    ///       ABILITYDRAIN      :nSpecial is the ability it is to drain.<br/>
    ///                          constant(IP_CONST_ABILITY_*)<br/>
    ///       BLINDNESS         :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       CONFUSION         :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       DAZE              :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       DEAFNESS          :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       DISEASE           :nSpecial is the type of desease that will effect the victim.<br/>
    ///                          constant(DISEASE_*)<br/>
    ///       DOOM              :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       FEAR              :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       HOLD              :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       ITEMPOISON        :nSpecial is the type of poison that will effect the victim.<br/>
    ///                          constant(IP_CONST_POISON_*)<br/>
    ///       SILENCE           :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       SLAYRACE          :nSpecial is the race that will be slain.<br/>
    ///                          constant(IP_CONST_RACIALTYPE_*)<br/>
    ///       SLAYALIGNMENTGROUP:nSpecial is the alignment group that will be slain(ie. chaotic).<br/>
    ///                          constant(IP_CONST_ALIGNMENTGROUP_*)<br/>
    ///       SLAYALIGNMENT     :nSpecial is the specific alignment that will be slain.<br/>
    ///                          constant(IP_CONST_ALIGNMENT_*)<br/>
    ///       SLEEP             :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       SLOW              :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)<br/>
    ///       STUN              :nSpecial is the duration/percentage of effecting victim.<br/>
    ///                          constant(IP_CONST_ONHIT_DURATION_*)
    public static System.IntPtr ItemPropertyOnHitProps(int nProperty, int nSaveDC, int nSpecial = 0)
    {
      VM.StackPush(nSpecial);
      VM.StackPush(nSaveDC);
      VM.StackPush(nProperty);
      VM.Call(658);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property reduced saving throw vs. an effect or damage type.  You must<br/>
    ///  specify the constant to which the penalty applies(IP_CONST_SAVEVS_*) and the<br/>
    ///  penalty to be applied.  The penalty must be a POSITIVE integer between 1 and 20<br/>
    ///  (ie. 1 = -1).
    public static System.IntPtr ItemPropertyReducedSavingThrowVsX(int nBaseSaveType, int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.StackPush(nBaseSaveType);
      VM.Call(659);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property reduced saving to base type.  You must specify the base<br/>
    ///  type to which the penalty applies (ie. will, reflex, or fortitude) and the penalty<br/>
    ///  to be applied.  The constant for the base type starts with (IP_CONST_SAVEBASETYPE_*).<br/>
    ///  The penalty must be a POSITIVE integer between 1 and 20 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyReducedSavingThrow(int nBonusType, int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.StackPush(nBonusType);
      VM.Call(660);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property regeneration.  You must specify the regeneration amount.<br/>
    ///  The amount must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyRegeneration(int nRegenAmount)
    {
      VM.StackPush(nRegenAmount);
      VM.Call(661);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property skill bonus.  You must specify the skill to which the user<br/>
    ///  will get a bonus(SKILL_*) and the amount of the bonus.  The bonus amount must<br/>
    ///  be an integer between 1 and 50.
    public static System.IntPtr ItemPropertySkillBonus(int nSkill, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nSkill);
      VM.Call(662);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property spell immunity vs. specific spell.  You must specify the<br/>
    ///  spell to which the user will be immune(IP_CONST_IMMUNITYSPELL_*).
    public static System.IntPtr ItemPropertySpellImmunitySpecific(int nSpell)
    {
      VM.StackPush(nSpell);
      VM.Call(663);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property spell immunity vs. spell school.  You must specify the<br/>
    ///  school to which the user will be immune(IP_CONST_SPELLSCHOOL_*).
    public static System.IntPtr ItemPropertySpellImmunitySchool(int nSchool)
    {
      VM.StackPush(nSchool);
      VM.Call(664);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Thieves tools.  You must specify the modifier you wish<br/>
    ///  the tools to have.  The modifier must be an integer between 1 and 12.
    public static System.IntPtr ItemPropertyThievesTools(int nModifier)
    {
      VM.StackPush(nModifier);
      VM.Call(665);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Attack bonus.  You must specify an attack bonus.  The bonus<br/>
    ///  must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyAttackBonus(int nBonus)
    {
      VM.StackPush(nBonus);
      VM.Call(666);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Attack bonus vs. alignment group.  You must specify the<br/>
    ///  alignment group constant(IP_CONST_ALIGNMENTGROUP_*) and the attack bonus.  The<br/>
    ///  bonus must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyAttackBonusVsAlign(int nAlignGroup, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nAlignGroup);
      VM.Call(667);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property attack bonus vs. racial group.  You must specify the<br/>
    ///  racial group constant(IP_CONST_RACIALTYPE_*) and the attack bonus.  The bonus<br/>
    ///  must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyAttackBonusVsRace(int nRace, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nRace);
      VM.Call(668);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property attack bonus vs. a specific alignment.  You must specify<br/>
    ///  the alignment you want the bonus to work against(IP_CONST_ALIGNMENT_*) and the<br/>
    ///  attack bonus.  The bonus must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyAttackBonusVsSAlign(int nAlignment, int nBonus)
    {
      VM.StackPush(nBonus);
      VM.StackPush(nAlignment);
      VM.Call(669);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property attack penalty.  You must specify the attack penalty.<br/>
    ///  The penalty must be a POSITIVE integer between 1 and 5 (ie. 1 = -1).
    public static System.IntPtr ItemPropertyAttackPenalty(int nPenalty)
    {
      VM.StackPush(nPenalty);
      VM.Call(670);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property unlimited ammo.  If you leave the parameter field blank<br/>
    ///  it will be just a normal bolt, arrow, or bullet.  However you may specify that<br/>
    ///  you want the ammunition to do special damage (ie. +1d6 Fire, or +1 enhancement<br/>
    ///  bonus).  For this parmeter you use the constants beginning with:<br/>
    ///       (IP_CONST_UNLIMITEDAMMO_*).
    public static System.IntPtr ItemPropertyUnlimitedAmmo(int nAmmoDamage = IP_CONST_UNLIMITEDAMMO_BASIC)
    {
      VM.StackPush(nAmmoDamage);
      VM.Call(671);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property limit use by alignment group.  You must specify the<br/>
    ///  alignment group(s) that you want to be able to use this item(IP_CONST_ALIGNMENTGROUP_*).
    public static System.IntPtr ItemPropertyLimitUseByAlign(int nAlignGroup)
    {
      VM.StackPush(nAlignGroup);
      VM.Call(672);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property limit use by class.  You must specify the class(es) who<br/>
    ///  are able to use this item(IP_CONST_CLASS_*).
    public static System.IntPtr ItemPropertyLimitUseByClass(int nClass)
    {
      VM.StackPush(nClass);
      VM.Call(673);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property limit use by race.  You must specify the race(s) who are<br/>
    ///  allowed to use this item(IP_CONST_RACIALTYPE_*).
    public static System.IntPtr ItemPropertyLimitUseByRace(int nRace)
    {
      VM.StackPush(nRace);
      VM.Call(674);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property limit use by specific alignment.  You must specify the<br/>
    ///  alignment(s) of those allowed to use the item(IP_CONST_ALIGNMENT_*).
    public static System.IntPtr ItemPropertyLimitUseBySAlign(int nAlignment)
    {
      VM.StackPush(nAlignment);
      VM.Call(675);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  replace this function it does nothing.
    public static System.IntPtr BadBadReplaceMeThisDoesNothing()
    {
      VM.Call(676);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property vampiric regeneration.  You must specify the amount of<br/>
    ///  regeneration.  The regen amount must be an integer between 1 and 20.
    public static System.IntPtr ItemPropertyVampiricRegeneration(int nRegenAmount)
    {
      VM.StackPush(nRegenAmount);
      VM.Call(677);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Trap.  You must specify the trap level constant<br/>
    ///  (IP_CONST_TRAPSTRENGTH_*) and the trap type constant(IP_CONST_TRAPTYPE_*).
    public static System.IntPtr ItemPropertyTrap(int nTrapLevel, int nTrapType)
    {
      VM.StackPush(nTrapType);
      VM.StackPush(nTrapLevel);
      VM.Call(678);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property true seeing.
    public static System.IntPtr ItemPropertyTrueSeeing()
    {
      VM.Call(679);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Monster on hit apply effect property.  You must specify<br/>
    ///  the property that you want applied on hit.  There are some properties that<br/>
    ///  require an additional special parameter to be specified.  The others that<br/>
    ///  don&amp;apos;t require any additional parameter you may just put in the one.  The<br/>
    ///  special cases are as follows:<br/>
    ///       ABILITYDRAIN:nSpecial is the ability to drain.<br/>
    ///                    constant(IP_CONST_ABILITY_*)<br/>
    ///       DISEASE     :nSpecial is the disease that you want applied.<br/>
    ///                    constant(DISEASE_*)<br/>
    ///       LEVELDRAIN  :nSpecial is the number of levels that you want drained.<br/>
    ///                    integer between 1 and 5.<br/>
    ///       POISON      :nSpecial is the type of poison that will effect the victim.<br/>
    ///                    constant(IP_CONST_POISON_*)<br/>
    ///       WOUNDING    :nSpecial is the amount of wounding.<br/>
    ///                    integer between 1 and 5.<br/>
    ///  NOTE: Any that do not appear in the above list do not require the second<br/>
    ///        parameter.<br/>
    ///  NOTE: These can only be applied to monster NATURAL weapons (ie. bite, claw,<br/>
    ///        gore, and slam).  IT WILL NOT WORK ON NORMAL WEAPONS.
    public static System.IntPtr ItemPropertyOnMonsterHitProperties(int nProperty, int nSpecial = 0)
    {
      VM.StackPush(nSpecial);
      VM.StackPush(nProperty);
      VM.Call(680);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property turn resistance.  You must specify the resistance bonus.<br/>
    ///  The bonus must be an integer between 1 and 50.
    public static System.IntPtr ItemPropertyTurnResistance(int nModifier)
    {
      VM.StackPush(nModifier);
      VM.Call(681);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Massive Critical.  You must specify the extra damage<br/>
    ///  constant(IP_CONST_DAMAGEBONUS_*) of the criticals.
    public static System.IntPtr ItemPropertyMassiveCritical(int nDamage)
    {
      VM.StackPush(nDamage);
      VM.Call(682);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property free action.
    public static System.IntPtr ItemPropertyFreeAction()
    {
      VM.Call(683);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property monster damage.  You must specify the amount of damage<br/>
    ///  the monster&amp;apos;s attack will do(IP_CONST_MONSTERDAMAGE_*).<br/>
    ///  NOTE: These can only be applied to monster NATURAL weapons (ie. bite, claw,<br/>
    ///        gore, and slam).  IT WILL NOT WORK ON NORMAL WEAPONS.
    public static System.IntPtr ItemPropertyMonsterDamage(int nDamage)
    {
      VM.StackPush(nDamage);
      VM.Call(684);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property immunity to spell level.  You must specify the level of<br/>
    ///  which that and below the user will be immune.  The level must be an integer<br/>
    ///  between 1 and 9.  By putting in a 3 it will mean the user is immune to all<br/>
    ///  3rd level and lower spells.
    public static System.IntPtr ItemPropertyImmunityToSpellLevel(int nLevel)
    {
      VM.StackPush(nLevel);
      VM.Call(685);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property special walk.  If no parameters are specified it will<br/>
    ///  automatically use the zombie walk.  This will apply the special walk animation<br/>
    ///  to the user.
    public static System.IntPtr ItemPropertySpecialWalk(int nWalkType = 0)
    {
      VM.StackPush(nWalkType);
      VM.Call(686);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property healers kit.  You must specify the level of the kit.<br/>
    ///  The modifier must be an integer between 1 and 12.
    public static System.IntPtr ItemPropertyHealersKit(int nModifier)
    {
      VM.StackPush(nModifier);
      VM.Call(687);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property weight increase.  You must specify the weight increase<br/>
    ///  constant(IP_CONST_WEIGHTINCREASE_*).
    public static System.IntPtr ItemPropertyWeightIncrease(int nWeight)
    {
      VM.StackPush(nWeight);
      VM.Call(688);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  ***********************  END OF ITEM PROPERTY FUNCTIONS  **************************<br/>
    ///  Returns true if 1d20 roll + skill rank is greater than or equal to difficulty<br/>
    ///  - oTarget: the creature using the skill<br/>
    ///  - nSkill: the skill being used<br/>
    ///  - nDifficulty: Difficulty class of skill
    public static int GetIsSkillSuccessful(uint oTarget, int nSkill, int nDifficulty)
    {
      VM.StackPush(nDifficulty);
      VM.StackPush(nSkill);
      VM.StackPush(oTarget);
      VM.Call(689);
      return VM.StackPopInt();
    }

    ///  Creates an effect that inhibits spells<br/>
    ///  - nPercent - percentage of failure<br/>
    ///  - nSpellSchool - the school of spells affected.
    public static System.IntPtr EffectSpellFailure(int nPercent = 100, int nSpellSchool = SPELL_SCHOOL_GENERAL)
    {
      VM.StackPush(nSpellSchool);
      VM.StackPush(nPercent);
      VM.Call(690);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Causes the object to instantly speak a translated string.<br/>
    ///  (not an action, not blocked when uncommandable)<br/>
    ///  - nStrRef: Reference of the string in the talk table<br/>
    ///  - nTalkVolume: TALKVOLUME_*
    public static void SpeakStringByStrRef(int nStrRef, int nTalkVolume = TALKVOLUME_TALK)
    {
      VM.StackPush(nTalkVolume);
      VM.StackPush(nStrRef);
      VM.Call(691);
    }

    ///  Sets the given creature into cutscene mode.  This prevents the player from<br/>
    ///  using the GUI and camera controls.<br/>
    ///  - oCreature: creature in a cutscene<br/>
    ///  - nInCutscene: TRUE to move them into cutscene, FALSE to remove cutscene mode<br/>
    ///  - nLeftClickingEnabled: TRUE to allow the user to interact with the game world using the left mouse button only.<br/>
    ///                          FALSE to stop the user from interacting with the game world.<br/>
    ///  Note: SetCutsceneMode(oPlayer, TRUE) will also make the player &amp;apos;plot&amp;apos; (unkillable).<br/>
    ///  SetCutsceneMode(oPlayer, FALSE) will restore the player&amp;apos;s plot flag to what it<br/>
    ///  was when SetCutsceneMode(oPlayer, TRUE) was called.
    public static void SetCutsceneMode(uint oCreature, int nInCutscene = TRUE, int nLeftClickingEnabled = FALSE)
    {
      VM.StackPush(nLeftClickingEnabled);
      VM.StackPush(nInCutscene);
      VM.StackPush(oCreature);
      VM.Call(692);
    }

    ///  Gets the last player character to cancel from a cutscene.
    public static uint GetLastPCToCancelCutscene()
    {
      VM.Call(693);
      return VM.StackPopObject();
    }

    ///  Gets the length of the specified wavefile, in seconds<br/>
    ///  Only works for sounds used for dialog.
    public static float GetDialogSoundLength(int nStrRef)
    {
      VM.StackPush(nStrRef);
      VM.Call(694);
      return VM.StackPopFloat();
    }

    ///  Fades the screen for the given creature/player from black to regular screen<br/>
    ///  - oCreature: creature controlled by player that should fade from black
    public static void FadeFromBlack(uint oCreature, float fSpeed = FADE_SPEED_MEDIUM)
    {
      VM.StackPush(fSpeed);
      VM.StackPush(oCreature);
      VM.Call(695);
    }

    ///  Fades the screen for the given creature/player from regular screen to black<br/>
    ///  - oCreature: creature controlled by player that should fade to black
    public static void FadeToBlack(uint oCreature, float fSpeed = FADE_SPEED_MEDIUM)
    {
      VM.StackPush(fSpeed);
      VM.StackPush(oCreature);
      VM.Call(696);
    }

    ///  Removes any fading or black screen.<br/>
    ///  - oCreature: creature controlled by player that should be cleared
    public static void StopFade(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(697);
    }

    ///  Sets the screen to black.  Can be used in preparation for a fade-in (FadeFromBlack)<br/>
    ///  Can be cleared by either doing a FadeFromBlack, or by calling StopFade.<br/>
    ///  - oCreature: creature controlled by player that should see black screen
    public static void BlackScreen(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(698);
    }

    ///  Returns the base attach bonus for the given creature.
    public static int GetBaseAttackBonus(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(699);
      return VM.StackPopInt();
    }

    ///  Set a creature&amp;apos;s immortality flag.<br/>
    ///  -oCreature: creature affected<br/>
    ///  -bImmortal: TRUE = creature is immortal and cannot be killed (but still takes damage)<br/>
    ///              FALSE = creature is not immortal and is damaged normally.<br/>
    ///  This scripting command only works on Creature objects.
    public static void SetImmortal(uint oCreature, int bImmortal)
    {
      VM.StackPush(bImmortal);
      VM.StackPush(oCreature);
      VM.Call(700);
    }

    ///  Open&amp;apos;s this creature&amp;apos;s inventory panel for this player<br/>
    ///  - oCreature: creature to view<br/>
    ///  - oPlayer: the owner of this creature will see the panel pop up<br/>
    ///  * DM&amp;apos;s can view any creature&amp;apos;s inventory<br/>
    ///  * Players can view their own inventory, or that of their henchman, familiar or animal companion
    public static void OpenInventory(uint oCreature, uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(oCreature);
      VM.Call(701);
    }

    ///  Stores the current camera mode and position so that it can be restored (using<br/>
    ///  RestoreCameraFacing())
    public static void StoreCameraFacing()
    {
      VM.Call(702);
    }

    ///  Restores the camera mode and position to what they were last time StoreCameraFacing<br/>
    ///  was called.  RestoreCameraFacing can only be called once, and must correspond to a<br/>
    ///  previous call to StoreCameraFacing.
    public static void RestoreCameraFacing()
    {
      VM.Call(703);
    }

    ///  Levels up a creature using default settings.<br/>
    ///  If successfull it returns the level the creature now is, or 0 if it fails.<br/>
    ///  If you want to give them a different level (ie: Give a Fighter a level of Wizard)<br/>
    ///     you can specify that in the nClass.<br/>
    ///  However, if you specify a class to which the creature no package specified,<br/>
    ///    they will use the default package for that class for their levelup choices.<br/>
    ///    (ie: no Barbarian Savage/Wizard Divination combinations)<br/>
    ///  If you turn on bReadyAllSpells, all memorized spells will be ready to cast without resting.<br/>
    ///  if nPackage is PACKAGE_INVALID then it will use the starting package assigned to that class or just the class package
    public static int LevelUpHenchman(uint oCreature, int nClass = CLASS_TYPE_INVALID, int bReadyAllSpells = FALSE, int nPackage = PACKAGE_INVALID)
    {
      VM.StackPush(nPackage);
      VM.StackPush(bReadyAllSpells);
      VM.StackPush(nClass);
      VM.StackPush(oCreature);
      VM.Call(704);
      return VM.StackPopInt();
    }

    ///  Sets the droppable flag on an item<br/>
    ///  - oItem: the item to change<br/>
    ///  - bDroppable: TRUE or FALSE, whether the item should be droppable<br/>
    ///  Droppable items will appear on a creature&amp;apos;s remains when the creature is killed.
    public static void SetDroppableFlag(uint oItem, int bDroppable)
    {
      VM.StackPush(bDroppable);
      VM.StackPush(oItem);
      VM.Call(705);
    }

    ///  Gets the weight of an item, or the total carried weight of a creature in tenths<br/>
    ///  of pounds (as per the baseitems.2da).<br/>
    ///  - oTarget: the item or creature for which the weight is needed
    public static int GetWeight(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(706);
      return VM.StackPopInt();
    }

    ///  Gets the object that acquired the module item.  May be a creature, item, or placeable
    public static uint GetModuleItemAcquiredBy()
    {
      VM.Call(707);
      return VM.StackPopObject();
    }

    ///  Get the immortal flag on a creature
    public static int GetImmortal(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(708);
      return VM.StackPopInt();
    }

    ///  Does a single attack on every hostile creature within 10ft. of the attacker<br/>
    ///  and determines damage accordingly.  If the attacker has a ranged weapon<br/>
    ///  equipped, this will have no effect.<br/>
    ///  ** NOTE ** This is meant to be called inside the spell script for whirlwind<br/>
    ///  attack, it is not meant to be used to queue up a new whirlwind attack.  To do<br/>
    ///  that you need to call ActionUseFeat(FEAT_WHIRLWIND_ATTACK, oEnemy)<br/>
    ///  - int bDisplayFeedback: TRUE or FALSE, whether or not feedback should be<br/>
    ///    displayed<br/>
    ///  - int bImproved: If TRUE, the improved version of whirlwind is used
    public static void DoWhirlwindAttack(int bDisplayFeedback = TRUE, int bImproved = FALSE)
    {
      VM.StackPush(bImproved);
      VM.StackPush(bDisplayFeedback);
      VM.Call(709);
    }

    ///  Gets a value from a 2DA file on the server and returns it as a string<br/>
    ///  avoid using this function in loops<br/>
    ///  - s2DA: the name of the 2da file, 16 chars max<br/>
    ///  - sColumn: the name of the column in the 2da<br/>
    ///  - nRow: the row in the 2da<br/>
    ///  * returns an empty string if file, row, or column not found
    public static string Get2DAString(string s2DA, string sColumn, int nRow)
    {
      VM.StackPush(nRow);
      VM.StackPush(sColumn);
      VM.StackPush(s2DA);
      VM.Call(710);
      return VM.StackPopString();
    }

    ///  Returns an effect of type EFFECT_TYPE_ETHEREAL which works just like EffectSanctuary<br/>
    ///  except that the observers get no saving throw
    public static System.IntPtr EffectEthereal()
    {
      VM.Call(711);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Gets the current AI Level that the creature is running at.<br/>
    ///  Returns one of the following:<br/>
    ///  AI_LEVEL_INVALID, AI_LEVEL_VERY_LOW, AI_LEVEL_LOW, AI_LEVEL_NORMAL, AI_LEVEL_HIGH, AI_LEVEL_VERY_HIGH
    public static int GetAILevel(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(712);
      return VM.StackPopInt();
    }

    ///  Sets the current AI Level of the creature to the value specified. Does not work on Players.<br/>
    ///  The game by default will choose an appropriate AI level for<br/>
    ///  creatures based on the circumstances that the creature is in.<br/>
    ///  Explicitly setting an AI level will over ride the game AI settings.<br/>
    ///  The new setting will last until SetAILevel is called again with the argument AI_LEVEL_DEFAULT.<br/>
    ///  AI_LEVEL_DEFAULT  - Default setting. The game will take over seting the appropriate AI level when required.<br/>
    ///  AI_LEVEL_VERY_LOW - Very Low priority, very stupid, but low CPU usage for AI. Typically used when no players are in the area.<br/>
    ///  AI_LEVEL_LOW      - Low priority, mildly stupid, but slightly more CPU usage for AI. Typically used when not in combat, but a player is in the area.<br/>
    ///  AI_LEVEL_NORMAL   - Normal priority, average AI, but more CPU usage required for AI. Typically used when creature is in combat.<br/>
    ///  AI_LEVEL_HIGH     - High priority, smartest AI, but extremely high CPU usage required for AI. Avoid using this. It is most likely only ever needed for cutscenes.
    public static void SetAILevel(uint oTarget, int nAILevel)
    {
      VM.StackPush(nAILevel);
      VM.StackPush(oTarget);
      VM.Call(713);
    }

    ///  This will return TRUE if the creature running the script is a familiar currently<br/>
    ///  possessed by his master.<br/>
    ///  returns FALSE if not or if the creature object is invalid
    public static int GetIsPossessedFamiliar(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(714);
      return VM.StackPopInt();
    }

    ///  This will cause a Player Creature to unpossess his/her familiar.  It will work if run<br/>
    ///  on the player creature or the possessed familiar.  It does not work in conjunction with<br/>
    ///  any DM possession.
    public static void UnpossessFamiliar(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(715);
    }

    ///  This will return TRUE if the area is flagged as either interior or underground.
    public static int GetIsAreaInterior(uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.Call(716);
      return VM.StackPopInt();
    }

    ///  Send a server message (szMessage) to the oPlayer.
    public static void SendMessageToPCByStrRef(uint oPlayer, int nStrRef)
    {
      VM.StackPush(nStrRef);
      VM.StackPush(oPlayer);
      VM.Call(717);
    }

    ///  Increment the remaining uses per day for this creature by one.<br/>
    ///  Total number of feats per day can not exceed the maximum.<br/>
    ///  - oCreature: creature to modify<br/>
    ///  - nFeat: constant FEAT_*
    public static void IncrementRemainingFeatUses(uint oCreature, int nFeat)
    {
      VM.StackPush(nFeat);
      VM.StackPush(oCreature);
      VM.Call(718);
    }

    ///  Force the character of the player specified to be exported to its respective directory<br/>
    ///  i.e. LocalVault/ServerVault/ etc.
    public static void ExportSingleCharacter(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(719);
    }

    ///  This will play a sound that is associated with a stringRef, it will be a mono sound from the location of the object running the command.<br/>
    ///  if nRunAsAction is off then the sound is forced to play intantly.
    public static void PlaySoundByStrRef(int nStrRef, int nRunAsAction = TRUE)
    {
      VM.StackPush(nRunAsAction);
      VM.StackPush(nStrRef);
      VM.Call(720);
    }

    ///  Set the name of oCreature&amp;apos;s sub race to sSubRace.
    public static void SetSubRace(uint oCreature, string sSubRace)
    {
      VM.StackPush(sSubRace);
      VM.StackPush(oCreature);
      VM.Call(721);
    }

    ///  Set the name of oCreature&amp;apos;s Deity to sDeity.
    public static void SetDeity(uint oCreature, string sDeity)
    {
      VM.StackPush(sDeity);
      VM.StackPush(oCreature);
      VM.Call(722);
    }

    ///  Returns TRUE if the creature oCreature is currently possessed by a DM character.<br/>
    ///  Returns FALSE otherwise.<br/>
    ///  Note: GetIsDMPossessed() will return FALSE if oCreature is the DM character.<br/>
    ///  To determine if oCreature is a DM character use GetIsDM()
    public static int GetIsDMPossessed(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(723);
      return VM.StackPopInt();
    }

    ///  Gets the current weather conditions for the area oArea.<br/>
    ///    Returns: WEATHER_CLEAR, WEATHER_RAIN, WEATHER_SNOW, WEATHER_INVALID<br/>
    ///    Note: If called on an Interior area, this will always return WEATHER_CLEAR.
    public static int GetWeather(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(724);
      return VM.StackPopInt();
    }

    ///  Returns AREA_NATURAL if the area oArea is natural, AREA_ARTIFICIAL otherwise.<br/>
    ///  Returns AREA_INVALID, on an error.
    public static int GetIsAreaNatural(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(725);
      return VM.StackPopInt();
    }

    ///  Returns AREA_ABOVEGROUND if the area oArea is above ground, AREA_UNDERGROUND otherwise.<br/>
    ///  Returns AREA_INVALID, on an error.
    public static int GetIsAreaAboveGround(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(726);
      return VM.StackPopInt();
    }

    ///  Use this to get the item last equipped by a player character in OnPlayerEquipItem..
    public static uint GetPCItemLastEquipped()
    {
      VM.Call(727);
      return VM.StackPopObject();
    }

    ///  Use this to get the player character who last equipped an item in OnPlayerEquipItem..
    public static uint GetPCItemLastEquippedBy()
    {
      VM.Call(728);
      return VM.StackPopObject();
    }

    ///  Use this to get the item last unequipped by a player character in OnPlayerEquipItem..
    public static uint GetPCItemLastUnequipped()
    {
      VM.Call(729);
      return VM.StackPopObject();
    }

    ///  Use this to get the player character who last unequipped an item in OnPlayerUnEquipItem..
    public static uint GetPCItemLastUnequippedBy()
    {
      VM.Call(730);
      return VM.StackPopObject();
    }

    ///  Creates a new copy of an item, while making a single change to the appearance of the item.<br/>
    ///  Helmet models and simple items ignore iIndex.<br/>
    ///  iType                            iIndex                              iNewValue<br/>
    ///  ITEM_APPR_TYPE_SIMPLE_MODEL      [Ignored]                           Model #<br/>
    ///  ITEM_APPR_TYPE_WEAPON_COLOR      ITEM_APPR_WEAPON_COLOR_*            1-4<br/>
    ///  ITEM_APPR_TYPE_WEAPON_MODEL      ITEM_APPR_WEAPON_MODEL_*            Model #<br/>
    ///  ITEM_APPR_TYPE_ARMOR_MODEL       ITEM_APPR_ARMOR_MODEL_*             Model #<br/>
    ///  ITEM_APPR_TYPE_ARMOR_COLOR       ITEM_APPR_ARMOR_COLOR_* [0]         0-175 [1]<br/>
    /// <br/>
    ///  [0] Alternatively, where ITEM_APPR_TYPE_ARMOR_COLOR is specified, if per-part coloring is<br/>
    ///  desired, the following equation can be used for nIndex to achieve that:<br/>
    /// <br/>
    ///    ITEM_APPR_ARMOR_NUM_COLORS + (ITEM_APPR_ARMOR_MODEL_ * ITEM_APPR_ARMOR_NUM_COLORS) + ITEM_APPR_ARMOR_COLOR_<br/>
    /// <br/>
    ///  For example, to change the CLOTH1 channel of the torso, nIndex would be:<br/>
    /// <br/>
    ///    6 + (7 * 6) + 2 = 50<br/>
    /// <br/>
    ///  [1] When specifying per-part coloring, the value 255 is allowed and corresponds with the logical<br/>
    ///  function &amp;apos;clear colour override&amp;apos;, which clears the per-part override for that part.
    public static uint CopyItemAndModify(uint oItem, int nType, int nIndex, int nNewValue, int bCopyVars = FALSE)
    {
      VM.StackPush(bCopyVars);
      VM.StackPush(nNewValue);
      VM.StackPush(nIndex);
      VM.StackPush(nType);
      VM.StackPush(oItem);
      VM.Call(731);
      return VM.StackPopObject();
    }

    ///  Queries the current value of the appearance settings on an item. The parameters are<br/>
    ///  identical to those of CopyItemAndModify().
    public static int GetItemAppearance(uint oItem, int nType, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(nType);
      VM.StackPush(oItem);
      VM.Call(732);
      return VM.StackPopInt();
    }

    ///  Creates an item property that (when applied to a weapon item) causes a spell to be cast<br/>
    ///  when a successful strike is made, or (when applied to armor) is struck by an opponent.<br/>
    ///  - nSpell uses the IP_CONST_ONHIT_CASTSPELL_* constants
    public static System.IntPtr ItemPropertyOnHitCastSpell(int nSpell, int nLevel)
    {
      VM.StackPush(nLevel);
      VM.StackPush(nSpell);
      VM.Call(733);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns the SubType number of the item property. See the 2DA files for value definitions.
    public static int GetItemPropertySubType(System.IntPtr iProperty)
    {
      VM.StackPush(iProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(734);
      return VM.StackPopInt();
    }

    ///  Gets the status of ACTION_MODE_* modes on a creature.
    public static int GetActionMode(uint oCreature, int nMode)
    {
      VM.StackPush(nMode);
      VM.StackPush(oCreature);
      VM.Call(735);
      return VM.StackPopInt();
    }

    ///  Sets the status of modes ACTION_MODE_* on a creature.
    public static void SetActionMode(uint oCreature, int nMode, int nStatus)
    {
      VM.StackPush(nStatus);
      VM.StackPush(nMode);
      VM.StackPush(oCreature);
      VM.Call(736);
    }

    ///  Returns the current arcane spell failure factor of a creature
    public static int GetArcaneSpellFailure(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(737);
      return VM.StackPopInt();
    }

    ///  Makes a player examine the object oExamine. This causes the examination<br/>
    ///  pop-up box to appear for the object specified.
    public static void ActionExamine(uint oExamine)
    {
      VM.StackPush(oExamine);
      VM.Call(738);
    }

    ///  Creates a visual effect (ITEM_VISUAL_*) that may be applied to<br/>
    ///  melee weapons only.
    public static System.IntPtr ItemPropertyVisualEffect(int nEffect)
    {
      VM.StackPush(nEffect);
      VM.Call(739);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Sets the lootable state of a *living* NPC creature.<br/>
    ///  This function will *not* work on players or dead creatures.
    public static void SetLootable(uint oCreature, int bLootable)
    {
      VM.StackPush(bLootable);
      VM.StackPush(oCreature);
      VM.Call(740);
    }

    ///  Returns the lootable state of a creature.
    public static int GetLootable(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(741);
      return VM.StackPopInt();
    }

    ///  Returns the current movement rate factor<br/>
    ///  of the cutscene &amp;apos;camera man&amp;apos;.<br/>
    ///  NOTE: This will be a value between 0.1, 2.0 (10%-200%)
    public static float GetCutsceneCameraMoveRate(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(742);
      return VM.StackPopFloat();
    }

    ///  Sets the current movement rate factor for the cutscene<br/>
    ///  camera man.<br/>
    ///  NOTE: You can only set values between 0.1, 2.0 (10%-200%)
    public static void SetCutsceneCameraMoveRate(uint oCreature, float fRate)
    {
      VM.StackPush(fRate);
      VM.StackPush(oCreature);
      VM.Call(743);
    }

    ///  Returns TRUE if the item is cursed and cannot be dropped
    public static int GetItemCursedFlag(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(744);
      return VM.StackPopInt();
    }

    ///  When cursed, items cannot be dropped
    public static void SetItemCursedFlag(uint oItem, int nCursed)
    {
      VM.StackPush(nCursed);
      VM.StackPush(oItem);
      VM.Call(745);
    }

    ///  Sets the maximum number of henchmen
    public static void SetMaxHenchmen(int nNumHenchmen)
    {
      VM.StackPush(nNumHenchmen);
      VM.Call(746);
    }

    ///  Gets the maximum number of henchmen
    public static int GetMaxHenchmen()
    {
      VM.Call(747);
      return VM.StackPopInt();
    }

    ///  Returns the associate type of the specified creature.<br/>
    ///  - Returns ASSOCIATE_TYPE_NONE if the creature is not the associate of anyone.
    public static int GetAssociateType(uint oAssociate)
    {
      VM.StackPush(oAssociate);
      VM.Call(748);
      return VM.StackPopInt();
    }

    ///  Returns the spell resistance of the specified creature.<br/>
    ///  - Returns 0 if the creature has no spell resistance or an invalid<br/>
    ///    creature is passed in.
    public static int GetSpellResistance(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(749);
      return VM.StackPopInt();
    }

    ///  Changes the current Day/Night cycle for this player to night<br/>
    ///  - oPlayer: which player to change the lighting for<br/>
    ///  - fTransitionTime: how long the transition should take
    public static void DayToNight(uint oPlayer, float fTransitionTime = 0.0f)
    {
      VM.StackPush(fTransitionTime);
      VM.StackPush(oPlayer);
      VM.Call(750);
    }

    ///  Changes the current Day/Night cycle for this player to daylight<br/>
    ///  - oPlayer: which player to change the lighting for<br/>
    ///  - fTransitionTime: how long the transition should take
    public static void NightToDay(uint oPlayer, float fTransitionTime = 0.0f)
    {
      VM.StackPush(fTransitionTime);
      VM.StackPush(oPlayer);
      VM.Call(751);
    }

    ///  Returns whether or not there is a direct line of sight<br/>
    ///  between the two objects. (Not blocked by any geometry).<br/>
    /// <br/>
    ///  PLEASE NOTE: This is an expensive function and may<br/>
    ///               degrade performance if used frequently.
    public static int LineOfSightObject(uint oSource, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oSource);
      VM.Call(752);
      return VM.StackPopInt();
    }

    ///  Returns whether or not there is a direct line of sight<br/>
    ///  between the two vectors. (Not blocked by any geometry).<br/>
    /// <br/>
    ///  This function must be run on a valid object in the area<br/>
    ///  it will not work on the module or area.<br/>
    /// <br/>
    ///  PLEASE NOTE: This is an expensive function and may<br/>
    ///               degrade performance if used frequently.
    public static int LineOfSightVector(System.Numerics.Vector3 vSource, System.Numerics.Vector3 vTarget)
    {
      VM.StackPush(vTarget);
      VM.StackPush(vSource);
      VM.Call(753);
      return VM.StackPopInt();
    }

    ///  Returns the class that the spellcaster cast the<br/>
    ///  spell as.<br/>
    ///  - Returns CLASS_TYPE_INVALID if the caster has<br/>
    ///    no valid class (placeables, etc...)
    public static int GetLastSpellCastClass()
    {
      VM.Call(754);
      return VM.StackPopInt();
    }

    ///  Sets the number of base attacks for the specified<br/>
    ///  creatures. The range of values accepted are from<br/>
    ///  1 to 6<br/>
    ///  Note: This function does not work on Player Characters
    public static void SetBaseAttackBonus(int nBaseAttackBonus, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nBaseAttackBonus);
      VM.Call(755);
    }

    ///  Restores the number of base attacks back to it&amp;apos;s<br/>
    ///  original state.
    public static void RestoreBaseAttackBonus(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(756);
    }

    ///  Creates a cutscene ghost effect, this will allow creatures<br/>
    ///  to pathfind through other creatures without bumping into them<br/>
    ///  for the duration of the effect.
    public static System.IntPtr EffectCutsceneGhost()
    {
      VM.Call(757);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Creates an item property that offsets the effect on arcane spell failure<br/>
    ///  that a particular item has. Parameters come from the ITEM_PROP_ASF_* group.
    public static System.IntPtr ItemPropertyArcaneSpellFailure(int nModLevel)
    {
      VM.StackPush(nModLevel);
      VM.Call(758);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns the amount of gold a store currently has. -1 indicates it is not using gold.<br/>
    ///  -2 indicates the store could not be located.
    public static int GetStoreGold(uint oidStore)
    {
      VM.StackPush(oidStore);
      VM.Call(759);
      return VM.StackPopInt();
    }

    ///  Sets the amount of gold a store has. -1 means the store does not use gold.
    public static void SetStoreGold(uint oidStore, int nGold)
    {
      VM.StackPush(nGold);
      VM.StackPush(oidStore);
      VM.Call(760);
    }

    ///  Gets the maximum amount a store will pay for any item. -1 means price unlimited.<br/>
    ///  -2 indicates the store could not be located.
    public static int GetStoreMaxBuyPrice(uint oidStore)
    {
      VM.StackPush(oidStore);
      VM.Call(761);
      return VM.StackPopInt();
    }

    ///  Sets the maximum amount a store will pay for any item. -1 means price unlimited.
    public static void SetStoreMaxBuyPrice(uint oidStore, int nMaxBuy)
    {
      VM.StackPush(nMaxBuy);
      VM.StackPush(oidStore);
      VM.Call(762);
    }

    ///  Gets the amount a store charges for identifying an item. Default is 100. -1 means<br/>
    ///  the store will not identify items.<br/>
    ///  -2 indicates the store could not be located.
    public static int GetStoreIdentifyCost(uint oidStore)
    {
      VM.StackPush(oidStore);
      VM.Call(763);
      return VM.StackPopInt();
    }

    ///  Sets the amount a store charges for identifying an item. Default is 100. -1 means<br/>
    ///  the store will not identify items.
    public static void SetStoreIdentifyCost(uint oidStore, int nCost)
    {
      VM.StackPush(nCost);
      VM.StackPush(oidStore);
      VM.Call(764);
    }

    ///  Sets the creature&amp;apos;s appearance type to the value specified (uses the APPEARANCE_TYPE_XXX constants)
    public static void SetCreatureAppearanceType(uint oCreature, int nAppearanceType)
    {
      VM.StackPush(nAppearanceType);
      VM.StackPush(oCreature);
      VM.Call(765);
    }

    ///  Returns the default package selected for this creature to level up with<br/>
    ///  - returns PACKAGE_INVALID if error occurs
    public static int GetCreatureStartingPackage(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(766);
      return VM.StackPopInt();
    }

    ///  Returns an effect that when applied will paralyze the target&amp;apos;s legs, rendering<br/>
    ///  them unable to walk but otherwise unpenalized. This effect cannot be resisted.
    public static System.IntPtr EffectCutsceneImmobilize()
    {
      VM.Call(767);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Is this creature in the given subarea? (trigger, area of effect object, etc..)<br/>
    ///  This function will tell you if the creature has triggered an onEnter event,<br/>
    ///  not if it is physically within the space of the subarea
    public static int GetIsInSubArea(uint oCreature, uint oSubArea = OBJECT_INVALID)
    {
      VM.StackPush(oSubArea);
      VM.StackPush(oCreature);
      VM.Call(768);
      return VM.StackPopInt();
    }

    ///  Returns the Cost Table number of the item property. See the 2DA files for value definitions.
    public static int GetItemPropertyCostTable(System.IntPtr iProp)
    {
      VM.StackPush(iProp, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(769);
      return VM.StackPopInt();
    }

    ///  Returns the Cost Table value (index of the cost table) of the item property.<br/>
    ///  See the 2DA files for value definitions.
    public static int GetItemPropertyCostTableValue(System.IntPtr iProp)
    {
      VM.StackPush(iProp, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(770);
      return VM.StackPopInt();
    }

    ///  Returns the Param1 number of the item property. See the 2DA files for value definitions.
    public static int GetItemPropertyParam1(System.IntPtr iProp)
    {
      VM.StackPush(iProp, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(771);
      return VM.StackPopInt();
    }

    ///  Returns the Param1 value of the item property. See the 2DA files for value definitions.
    public static int GetItemPropertyParam1Value(System.IntPtr iProp)
    {
      VM.StackPush(iProp, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(772);
      return VM.StackPopInt();
    }

    ///  Is this creature able to be disarmed? (checks disarm flag on creature, and if<br/>
    ///  the creature actually has a weapon equipped in their right hand that is droppable)
    public static int GetIsCreatureDisarmable(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(773);
      return VM.StackPopInt();
    }

    ///  Sets whether this item is &amp;apos;stolen&amp;apos; or not
    public static void SetStolenFlag(uint oItem, int nStolenFlag)
    {
      VM.StackPush(nStolenFlag);
      VM.StackPush(oItem);
      VM.Call(774);
    }

    ///  Instantly gives this creature the benefits of a rest (restored hitpoints, spells, feats, etc..)
    public static void ForceRest(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(775);
    }

    ///  Forces this player&amp;apos;s camera to be set to this height. Setting this value to zero will<br/>
    ///  restore the camera to the racial default height.
    public static void SetCameraHeight(uint oPlayer, float fHeight = 0.0f)
    {
      VM.StackPush(fHeight);
      VM.StackPush(oPlayer);
      VM.Call(776);
    }

    ///  Changes the sky that is displayed in the specified area.<br/>
    ///  nSkyBox = SKYBOX_* constants (associated with skyboxes.2da)<br/>
    ///  If no valid area (or object) is specified, it uses the area of caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static void SetSkyBox(int nSkyBox, uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.StackPush(nSkyBox);
      VM.Call(777);
    }

    ///  Returns the creature&amp;apos;s currently set PhenoType (body type).
    public static int GetPhenoType(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(778);
      return VM.StackPopInt();
    }

    ///  Sets the creature&amp;apos;s PhenoType (body type) to the type specified.<br/>
    ///  nPhenoType = PHENOTYPE_NORMAL<br/>
    ///  nPhenoType = PHENOTYPE_BIG<br/>
    ///  nPhenoType = PHENOTYPE_CUSTOM* - The custom PhenoTypes should only ever<br/>
    ///  be used if you have specifically created your own custom content that<br/>
    ///  requires the use of a new PhenoType and you have specified the appropriate<br/>
    ///  custom PhenoType in your custom content.<br/>
    ///  SetPhenoType will only work on part based creature (i.e. the starting<br/>
    ///  default playable races).
    public static void SetPhenoType(int nPhenoType, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nPhenoType);
      VM.Call(779);
    }

    ///  Sets the fog color in the area specified.<br/>
    ///  nFogType = FOG_TYPE_* specifies wether the Sun, Moon, or both fog types are set.<br/>
    ///  nFogColor = FOG_COLOR_* specifies the color the fog is being set to.<br/>
    ///  The fog color can also be represented as a hex RGB number if specific color shades<br/>
    ///  are desired.<br/>
    ///  The format of a hex specified color would be 0xFFEEDD where<br/>
    ///  FF would represent the amount of red in the color<br/>
    ///  EE would represent the amount of green in the color<br/>
    ///  DD would represent the amount of blue in the color.<br/>
    ///  If no valid area (or object) is specified, it uses the area of caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static void SetFogColor(int nFogType, int nFogColor, uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.StackPush(nFogColor);
      VM.StackPush(nFogType);
      VM.Call(780);
    }

    ///  Gets the current cutscene state of the player specified by oCreature.<br/>
    ///  Returns TRUE if the player is in cutscene mode.<br/>
    ///  Returns FALSE if the player is not in cutscene mode, or on an error<br/>
    ///  (such as specifying a non creature object).
    public static int GetCutsceneMode(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(781);
      return VM.StackPopInt();
    }

    ///  Gets the skybox that is currently displayed in the specified area.<br/>
    ///  Returns:<br/>
    ///      SKYBOX_* constant<br/>
    ///  If no valid area (or object) is specified, it uses the area of caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static int GetSkyBox(uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.Call(782);
      return VM.StackPopInt();
    }

    ///  Gets the fog color in the area specified.<br/>
    ///  nFogType specifies wether the Sun, or Moon fog type is returned.<br/>
    ///     Valid values for nFogType are FOG_TYPE_SUN or FOG_TYPE_MOON.<br/>
    ///  If no valid area (or object) is specified, it uses the area of caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static int GetFogColor(int nFogType, uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.StackPush(nFogType);
      VM.Call(783);
      return VM.StackPopInt();
    }

    ///  Sets the fog amount in the area specified.<br/>
    ///  nFogType = FOG_TYPE_* specifies wether the Sun, Moon, or both fog types are set.<br/>
    ///  nFogAmount = specifies the density that the fog is being set to.<br/>
    ///  If no valid area (or object) is specified, it uses the area of caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static void SetFogAmount(int nFogType, int nFogAmount, uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.StackPush(nFogAmount);
      VM.StackPush(nFogType);
      VM.Call(784);
    }

    ///  Gets the fog amount in the area specified.<br/>
    ///  nFogType = nFogType specifies wether the Sun, or Moon fog type is returned.<br/>
    ///     Valid values for nFogType are FOG_TYPE_SUN or FOG_TYPE_MOON.<br/>
    ///  If no valid area (or object) is specified, it uses the area of caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static int GetFogAmount(int nFogType, uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.StackPush(nFogType);
      VM.Call(785);
      return VM.StackPopInt();
    }

    ///  returns TRUE if the item CAN be pickpocketed
    public static int GetPickpocketableFlag(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(786);
      return VM.StackPopInt();
    }

    ///  Sets the Pickpocketable flag on an item<br/>
    ///  - oItem: the item to change<br/>
    ///  - bPickpocketable: TRUE or FALSE, whether the item can be pickpocketed.
    public static void SetPickpocketableFlag(uint oItem, int bPickpocketable)
    {
      VM.StackPush(bPickpocketable);
      VM.StackPush(oItem);
      VM.Call(787);
    }

    ///  returns the footstep type of the creature specified.<br/>
    ///  The footstep type determines what the creature&amp;apos;s footsteps sound<br/>
    ///  like when ever they take a step.<br/>
    ///  returns FOOTSTEP_TYPE_INVALID if used on a non-creature object, or if<br/>
    ///  used on creature that has no footstep sounds by default (e.g. Will-O&amp;apos;-Wisp).
    public static int GetFootstepType(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(788);
      return VM.StackPopInt();
    }

    ///  Sets the footstep type of the creature specified.<br/>
    ///  Changing a creature&amp;apos;s footstep type will change the sound that<br/>
    ///  its feet make when ever the creature makes takes a step.<br/>
    ///  By default a creature&amp;apos;s footsteps are detemined by the appearance<br/>
    ///  type of the creature. SetFootstepType() allows you to make a<br/>
    ///  creature use a difference footstep type than it would use by default<br/>
    ///  for its given appearance.<br/>
    ///  - nFootstepType (FOOTSTEP_TYPE_*):<br/>
    ///       FOOTSTEP_TYPE_NORMAL<br/>
    ///       FOOTSTEP_TYPE_LARGE<br/>
    ///       FOOTSTEP_TYPE_DRAGON<br/>
    ///       FOOTSTEP_TYPE_SoFT<br/>
    ///       FOOTSTEP_TYPE_HOOF<br/>
    ///       FOOTSTEP_TYPE_HOOF_LARGE<br/>
    ///       FOOTSTEP_TYPE_BEETLE<br/>
    ///       FOOTSTEP_TYPE_SPIDER<br/>
    ///       FOOTSTEP_TYPE_SKELETON<br/>
    ///       FOOTSTEP_TYPE_LEATHER_WING<br/>
    ///       FOOTSTEP_TYPE_FEATHER_WING<br/>
    ///       FOOTSTEP_TYPE_DEFAULT - Makes the creature use its original default footstep sounds.<br/>
    ///       FOOTSTEP_TYPE_NONE<br/>
    ///  - oCreature: the creature to change the footstep sound for.
    public static void SetFootstepType(int nFootstepType, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nFootstepType);
      VM.Call(789);
    }

    ///  returns the Wing type of the creature specified.<br/>
    ///       CREATURE_WING_TYPE_NONE<br/>
    ///       CREATURE_WING_TYPE_DEMON<br/>
    ///       CREATURE_WING_TYPE_ANGEL<br/>
    ///       CREATURE_WING_TYPE_BAT<br/>
    ///       CREATURE_WING_TYPE_DRAGON<br/>
    ///       CREATURE_WING_TYPE_BUTTERFLY<br/>
    ///       CREATURE_WING_TYPE_BIRD<br/>
    ///  returns CREATURE_WING_TYPE_NONE if used on a non-creature object,<br/>
    ///  if the creature has no wings, or if the creature can not have its<br/>
    ///  wing type changed in the toolset.
    public static int GetCreatureWingType(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(790);
      return VM.StackPopInt();
    }

    ///  Sets the Wing type of the creature specified.<br/>
    ///  - nWingType (CREATURE_WING_TYPE_*)<br/>
    ///       CREATURE_WING_TYPE_NONE<br/>
    ///       CREATURE_WING_TYPE_DEMON<br/>
    ///       CREATURE_WING_TYPE_ANGEL<br/>
    ///       CREATURE_WING_TYPE_BAT<br/>
    ///       CREATURE_WING_TYPE_DRAGON<br/>
    ///       CREATURE_WING_TYPE_BUTTERFLY<br/>
    ///       CREATURE_WING_TYPE_BIRD<br/>
    ///  - oCreature: the creature to change the wing type for.<br/>
    ///  Note: Only two creature model types will support wings.<br/>
    ///  The MODELTYPE for the part based (playable races) &amp;apos;P&amp;apos;<br/>
    ///  and MODELTYPE &amp;apos;W&amp;apos;in the appearance.2da
    public static void SetCreatureWingType(int nWingType, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nWingType);
      VM.Call(791);
    }

    ///  returns the model number being used for the body part and creature specified<br/>
    ///  The model number returned is for the body part when the creature is not wearing<br/>
    ///  armor (i.e. whether or not the creature is wearing armor does not affect<br/>
    ///  the return value).<br/>
    ///  Note: Only works on part based creatures, which is typically restricted to<br/>
    ///  the playable races (unless some new part based custom content has been<br/>
    ///  added to the module).<br/>
    /// <br/>
    ///  returns CREATURE_PART_INVALID if used on a non-creature object,<br/>
    ///  or if the creature does not use a part based model.<br/>
    /// <br/>
    ///  - nPart (CREATURE_PART_*)<br/>
    ///       CREATURE_PART_RIGHT_FOOT<br/>
    ///       CREATURE_PART_LEFT_FOOT<br/>
    ///       CREATURE_PART_RIGHT_SHIN<br/>
    ///       CREATURE_PART_LEFT_SHIN<br/>
    ///       CREATURE_PART_RIGHT_THIGH<br/>
    ///       CREATURE_PART_LEFT_THIGH<br/>
    ///       CREATURE_PART_PELVIS<br/>
    ///       CREATURE_PART_TORSO<br/>
    ///       CREATURE_PART_BELT<br/>
    ///       CREATURE_PART_NECK<br/>
    ///       CREATURE_PART_RIGHT_FOREARM<br/>
    ///       CREATURE_PART_LEFT_FOREARM<br/>
    ///       CREATURE_PART_RIGHT_BICEP<br/>
    ///       CREATURE_PART_LEFT_BICEP<br/>
    ///       CREATURE_PART_RIGHT_SHOULDER<br/>
    ///       CREATURE_PART_LEFT_SHOULDER<br/>
    ///       CREATURE_PART_RIGHT_HAND<br/>
    ///       CREATURE_PART_LEFT_HAND<br/>
    ///       CREATURE_PART_HEAD
    public static int GetCreatureBodyPart(int nPart, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nPart);
      VM.Call(792);
      return VM.StackPopInt();
    }

    ///  Sets the body part model to be used on the creature specified.<br/>
    ///  The model names for parts need to be in the following format:<br/>
    ///    p&amp;lt;m/f&amp;gt;&amp;lt;race letter&amp;gt;&amp;lt;phenotype&amp;gt;_&amp;lt;body part&amp;gt;&amp;lt;model number&amp;gt;.mdl<br/>
    /// <br/>
    ///  - nPart (CREATURE_PART_*)<br/>
    ///       CREATURE_PART_RIGHT_FOOT<br/>
    ///       CREATURE_PART_LEFT_FOOT<br/>
    ///       CREATURE_PART_RIGHT_SHIN<br/>
    ///       CREATURE_PART_LEFT_SHIN<br/>
    ///       CREATURE_PART_RIGHT_THIGH<br/>
    ///       CREATURE_PART_LEFT_THIGH<br/>
    ///       CREATURE_PART_PELVIS<br/>
    ///       CREATURE_PART_TORSO<br/>
    ///       CREATURE_PART_BELT<br/>
    ///       CREATURE_PART_NECK<br/>
    ///       CREATURE_PART_RIGHT_FOREARM<br/>
    ///       CREATURE_PART_LEFT_FOREARM<br/>
    ///       CREATURE_PART_RIGHT_BICEP<br/>
    ///       CREATURE_PART_LEFT_BICEP<br/>
    ///       CREATURE_PART_RIGHT_SHOULDER<br/>
    ///       CREATURE_PART_LEFT_SHOULDER<br/>
    ///       CREATURE_PART_RIGHT_HAND<br/>
    ///       CREATURE_PART_LEFT_HAND<br/>
    ///       CREATURE_PART_HEAD<br/>
    ///  - nModelNumber: CREATURE_MODEL_TYPE_*<br/>
    ///       CREATURE_MODEL_TYPE_NONE<br/>
    ///       CREATURE_MODEL_TYPE_SKIN (not for use on shoulders, pelvis or head).<br/>
    ///       CREATURE_MODEL_TYPE_TATTOO (for body parts that support tattoos, i.e. not heads/feet/hands).<br/>
    ///       CREATURE_MODEL_TYPE_UNDEAD (undead model only exists for the right arm parts).<br/>
    ///  - oCreature: the creature to change the body part for.<br/>
    ///  Note: Only part based creature appearance types are supported.<br/>
    ///  i.e. The model types for the playable races (&amp;apos;P&amp;apos;) in the appearance.2da
    public static void SetCreatureBodyPart(int nPart, int nModelNumber, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nModelNumber);
      VM.StackPush(nPart);
      VM.Call(793);
    }

    ///  returns the Tail type of the creature specified.<br/>
    ///       CREATURE_TAIL_TYPE_NONE<br/>
    ///       CREATURE_TAIL_TYPE_LIZARD<br/>
    ///       CREATURE_TAIL_TYPE_BONE<br/>
    ///       CREATURE_TAIL_TYPE_DEVIL<br/>
    ///  returns CREATURE_TAIL_TYPE_NONE if used on a non-creature object,<br/>
    ///  if the creature has no Tail, or if the creature can not have its<br/>
    ///  Tail type changed in the toolset.
    public static int GetCreatureTailType(uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.Call(794);
      return VM.StackPopInt();
    }

    ///  Sets the Tail type of the creature specified.<br/>
    ///  - nTailType (CREATURE_TAIL_TYPE_*)<br/>
    ///       CREATURE_TAIL_TYPE_NONE<br/>
    ///       CREATURE_TAIL_TYPE_LIZARD<br/>
    ///       CREATURE_TAIL_TYPE_BONE<br/>
    ///       CREATURE_TAIL_TYPE_DEVIL<br/>
    ///  - oCreature: the creature to change the Tail type for.<br/>
    ///  Note: Only two creature model types will support Tails.<br/>
    ///  The MODELTYPE for the part based (playable) races &amp;apos;P&amp;apos;<br/>
    ///  and MODELTYPE &amp;apos;T&amp;apos;in the appearance.2da
    public static void SetCreatureTailType(int nTailType, uint oCreature = OBJECT_INVALID)
    {
      VM.StackPush(oCreature);
      VM.StackPush(nTailType);
      VM.Call(795);
    }

    ///  returns the Hardness of a Door or Placeable object.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  returns -1 on an error or if used on an object that is<br/>
    ///  neither a door nor a placeable object.
    public static int GetHardness(uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.Call(796);
      return VM.StackPopInt();
    }

    ///  Sets the Hardness of a Door or Placeable object.<br/>
    ///  - nHardness: must be between 0 and 250.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  Does nothing if used on an object that is neither<br/>
    ///  a door nor a placeable.
    public static void SetHardness(int nHardness, uint oObject = OBJECT_INVALID)
    {
      VM.StackPush(oObject);
      VM.StackPush(nHardness);
      VM.Call(797);
    }

    ///  When set the object can not be opened unless the<br/>
    ///  opener possesses the required key. The key tag required<br/>
    ///  can be specified either in the toolset, or by using<br/>
    ///  the SetLockKeyTag() scripting command.<br/>
    ///  - oObject: a door, or placeable.<br/>
    ///  - nKeyRequired: TRUE/FALSE
    public static void SetLockKeyRequired(uint oObject, int nKeyRequired = TRUE)
    {
      VM.StackPush(nKeyRequired);
      VM.StackPush(oObject);
      VM.Call(798);
    }

    ///  Set the key tag required to open object oObject.<br/>
    ///  This will only have an effect if the object is set to<br/>
    ///  &amp;quot;Key required to unlock or lock&amp;quot; either in the toolset<br/>
    ///  or by using the scripting command SetLockKeyRequired().<br/>
    ///  - oObject: a door, placeable or trigger.<br/>
    ///  - sNewKeyTag: the key tag required to open the locked object.
    public static void SetLockKeyTag(uint oObject, string sNewKeyTag)
    {
      VM.StackPush(sNewKeyTag);
      VM.StackPush(oObject);
      VM.Call(799);
    }

    ///  Sets whether or not the object can be locked.<br/>
    ///  - oObject: a door or placeable.<br/>
    ///  - nLockable: TRUE/FALSE
    public static void SetLockLockable(uint oObject, int nLockable = TRUE)
    {
      VM.StackPush(nLockable);
      VM.StackPush(oObject);
      VM.Call(800);
    }

    ///  Sets the DC for unlocking the object.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  - nNewUnlockDC: must be between 0 and 250.
    public static void SetLockUnlockDC(uint oObject, int nNewUnlockDC)
    {
      VM.StackPush(nNewUnlockDC);
      VM.StackPush(oObject);
      VM.Call(801);
    }

    ///  Sets the DC for locking the object.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  - nNewLockDC: must be between 0 and 250.
    public static void SetLockLockDC(uint oObject, int nNewLockDC)
    {
      VM.StackPush(nNewLockDC);
      VM.StackPush(oObject);
      VM.Call(802);
    }

    ///  Sets whether or not the trapped object can be disarmed.<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - nDisarmable: TRUE/FALSE
    public static void SetTrapDisarmable(uint oTrapObject, int nDisarmable = TRUE)
    {
      VM.StackPush(nDisarmable);
      VM.StackPush(oTrapObject);
      VM.Call(803);
    }

    ///  Sets whether or not the trapped object can be detected.<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - nDetectable: TRUE/FALSE<br/>
    ///  Note: Setting a trapped object to not be detectable will<br/>
    ///  not make the trap disappear if it has already been detected.
    public static void SetTrapDetectable(uint oTrapObject, int nDetectable = TRUE)
    {
      VM.StackPush(nDetectable);
      VM.StackPush(oTrapObject);
      VM.Call(804);
    }

    ///  Sets whether or not the trap is a one-shot trap<br/>
    ///  (i.e. whether or not the trap resets itself after firing).<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - nOneShot: TRUE/FALSE
    public static void SetTrapOneShot(uint oTrapObject, int nOneShot = TRUE)
    {
      VM.StackPush(nOneShot);
      VM.StackPush(oTrapObject);
      VM.Call(805);
    }

    ///  Set the tag of the key that will disarm oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger
    public static void SetTrapKeyTag(uint oTrapObject, string sKeyTag)
    {
      VM.StackPush(sKeyTag);
      VM.StackPush(oTrapObject);
      VM.Call(806);
    }

    ///  Set the DC for disarming oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - nDisarmDC: must be between 0 and 250.
    public static void SetTrapDisarmDC(uint oTrapObject, int nDisarmDC)
    {
      VM.StackPush(nDisarmDC);
      VM.StackPush(oTrapObject);
      VM.Call(807);
    }

    ///  Set the DC for detecting oTrapObject.<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - nDetectDC: must be between 0 and 250.
    public static void SetTrapDetectDC(uint oTrapObject, int nDetectDC)
    {
      VM.StackPush(nDetectDC);
      VM.StackPush(oTrapObject);
      VM.Call(808);
    }

    ///  Creates a square Trap object.<br/>
    ///  - nTrapType: The base type of trap (TRAP_BASE_TYPE_*)<br/>
    ///  - lLocation: The location and orientation that the trap will be created at.<br/>
    ///  - fSize: The size of the trap. Minimum size allowed is 1.0f.<br/>
    ///  - sTag: The tag of the trap being created.<br/>
    ///  - nFaction: The faction of the trap (STANDARD_FACTION_*).<br/>
    ///  - sOnDisarmScript: The OnDisarm script that will fire when the trap is disarmed.<br/>
    ///                     If &amp;quot;&amp;quot; no script will fire.<br/>
    ///  - sOnTrapTriggeredScript: The OnTrapTriggered script that will fire when the<br/>
    ///                            trap is triggered.<br/>
    ///                            If &amp;quot;&amp;quot; the default OnTrapTriggered script for the trap<br/>
    ///                            type specified will fire instead (as specified in the<br/>
    ///                            traps.2da).
    public static uint CreateTrapAtLocation(int nTrapType, System.IntPtr lLocation, float fSize = 2.0f, string sTag = "", int nFaction = STANDARD_FACTION_HOSTILE, string sOnDisarmScript = "", string sOnTrapTriggeredScript = "")
    {
      VM.StackPush(sOnTrapTriggeredScript);
      VM.StackPush(sOnDisarmScript);
      VM.StackPush(nFaction);
      VM.StackPush(sTag);
      VM.StackPush(fSize);
      VM.StackPush(lLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(nTrapType);
      VM.Call(809);
      return VM.StackPopObject();
    }

    ///  Creates a Trap on the object specified.<br/>
    ///  - nTrapType: The base type of trap (TRAP_BASE_TYPE_*)<br/>
    ///  - oObject: The object that the trap will be created on. Works only on Doors and Placeables.<br/>
    ///  - nFaction: The faction of the trap (STANDARD_FACTION_*).<br/>
    ///  - sOnDisarmScript: The OnDisarm script that will fire when the trap is disarmed.<br/>
    ///                     If &amp;quot;&amp;quot; no script will fire.<br/>
    ///  - sOnTrapTriggeredScript: The OnTrapTriggered script that will fire when the<br/>
    ///                            trap is triggered.<br/>
    ///                            If &amp;quot;&amp;quot; the default OnTrapTriggered script for the trap<br/>
    ///                            type specified will fire instead (as specified in the<br/>
    ///                            traps.2da).<br/>
    ///  Note: After creating a trap on an object, you can change the trap&amp;apos;s properties<br/>
    ///        using the various SetTrap* scripting commands by passing in the object<br/>
    ///        that the trap was created on (i.e. oObject) to any subsequent SetTrap* commands.
    public static void CreateTrapOnObject(int nTrapType, uint oObject, int nFaction = STANDARD_FACTION_HOSTILE, string sOnDisarmScript = "", string sOnTrapTriggeredScript = "")
    {
      VM.StackPush(sOnTrapTriggeredScript);
      VM.StackPush(sOnDisarmScript);
      VM.StackPush(nFaction);
      VM.StackPush(oObject);
      VM.StackPush(nTrapType);
      VM.Call(810);
    }

    ///  Set the Will saving throw value of the Door or Placeable object oObject.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  - nWillSave: must be between 0 and 250.
    public static void SetWillSavingThrow(uint oObject, int nWillSave)
    {
      VM.StackPush(nWillSave);
      VM.StackPush(oObject);
      VM.Call(811);
    }

    ///  Set the Reflex saving throw value of the Door or Placeable object oObject.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  - nReflexSave: must be between 0 and 250.
    public static void SetReflexSavingThrow(uint oObject, int nReflexSave)
    {
      VM.StackPush(nReflexSave);
      VM.StackPush(oObject);
      VM.Call(812);
    }

    ///  Set the Fortitude saving throw value of the Door or Placeable object oObject.<br/>
    ///  - oObject: a door or placeable object.<br/>
    ///  - nFortitudeSave: must be between 0 and 250.
    public static void SetFortitudeSavingThrow(uint oObject, int nFortitudeSave)
    {
      VM.StackPush(nFortitudeSave);
      VM.StackPush(oObject);
      VM.Call(813);
    }

    ///  returns the resref (TILESET_RESREF_*) of the tileset used to create area oArea.<br/>
    ///       TILESET_RESREF_BEHOLDER_CAVES<br/>
    ///       TILESET_RESREF_CASTLE_INTERIOR<br/>
    ///       TILESET_RESREF_CITY_EXTERIOR<br/>
    ///       TILESET_RESREF_CITY_INTERIOR<br/>
    ///       TILESET_RESREF_CRYPT<br/>
    ///       TILESET_RESREF_DESERT<br/>
    ///       TILESET_RESREF_DROW_INTERIOR<br/>
    ///       TILESET_RESREF_DUNGEON<br/>
    ///       TILESET_RESREF_FOREST<br/>
    ///       TILESET_RESREF_FROZEN_WASTES<br/>
    ///       TILESET_RESREF_ILLITHID_INTERIOR<br/>
    ///       TILESET_RESREF_MICROSET<br/>
    ///       TILESET_RESREF_MINES_AND_CAVERNS<br/>
    ///       TILESET_RESREF_RUINS<br/>
    ///       TILESET_RESREF_RURAL<br/>
    ///       TILESET_RESREF_RURAL_WINTER<br/>
    ///       TILESET_RESREF_SEWERS<br/>
    ///       TILESET_RESREF_UNDERDARK<br/>
    ///  * returns an empty string on an error.
    public static string GetTilesetResRef(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(814);
      return VM.StackPopString();
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns TRUE if oTrapObject can be recovered.
    public static int GetTrapRecoverable(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(815);
      return VM.StackPopInt();
    }

    ///  Sets whether or not the trapped object can be recovered.<br/>
    ///  - oTrapObject: a placeable, door or trigger
    public static void SetTrapRecoverable(uint oTrapObject, int nRecoverable = TRUE)
    {
      VM.StackPush(nRecoverable);
      VM.StackPush(oTrapObject);
      VM.Call(816);
    }

    ///  Get the XP scale being used for the module.
    public static int GetModuleXPScale()
    {
      VM.Call(817);
      return VM.StackPopInt();
    }

    ///  Set the XP scale used by the module.<br/>
    ///  - nXPScale: The XP scale to be used. Must be between 0 and 200.
    public static void SetModuleXPScale(int nXPScale)
    {
      VM.StackPush(nXPScale);
      VM.Call(818);
    }

    ///  Get the feedback message that will be displayed when trying to unlock the object oObject.<br/>
    ///  - oObject: a door or placeable.<br/>
    ///  Returns an empty string &amp;quot;&amp;quot; on an error or if the game&amp;apos;s default feedback message is being used
    public static string GetKeyRequiredFeedback(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(819);
      return VM.StackPopString();
    }

    ///  Set the feedback message that is displayed when trying to unlock the object oObject.<br/>
    ///  This will only have an effect if the object is set to<br/>
    ///  &amp;quot;Key required to unlock or lock&amp;quot; either in the toolset<br/>
    ///  or by using the scripting command SetLockKeyRequired().<br/>
    ///  - oObject: a door or placeable.<br/>
    ///  - sFeedbackMessage: the string to be displayed in the player&amp;apos;s text window.<br/>
    ///                      to use the game&amp;apos;s default message, set sFeedbackMessage to &amp;quot;&amp;quot;
    public static void SetKeyRequiredFeedback(uint oObject, string sFeedbackMessage)
    {
      VM.StackPush(sFeedbackMessage);
      VM.StackPush(oObject);
      VM.Call(820);
    }

    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  * Returns TRUE if oTrapObject is active
    public static int GetTrapActive(uint oTrapObject)
    {
      VM.StackPush(oTrapObject);
      VM.Call(821);
      return VM.StackPopInt();
    }

    ///  Sets whether or not the trap is an active trap<br/>
    ///  - oTrapObject: a placeable, door or trigger<br/>
    ///  - nActive: TRUE/FALSE<br/>
    ///  Notes:<br/>
    ///  Setting a trap as inactive will not make the<br/>
    ///  trap disappear if it has already been detected.<br/>
    ///  Call SetTrapDetectedBy() to make a detected trap disappear.<br/>
    ///  To make an inactive trap not detectable call SetTrapDetectable()
    public static void SetTrapActive(uint oTrapObject, int nActive = TRUE)
    {
      VM.StackPush(nActive);
      VM.StackPush(oTrapObject);
      VM.Call(822);
    }

    ///  Locks the player&amp;apos;s camera pitch to its current pitch setting,<br/>
    ///  or unlocks the player&amp;apos;s camera pitch.<br/>
    ///  Stops the player from tilting their camera angle.<br/>
    ///  - oPlayer: A player object.<br/>
    ///  - bLocked: TRUE/FALSE.
    public static void LockCameraPitch(uint oPlayer, int bLocked = TRUE)
    {
      VM.StackPush(bLocked);
      VM.StackPush(oPlayer);
      VM.Call(823);
    }

    ///  Locks the player&amp;apos;s camera distance to its current distance setting,<br/>
    ///  or unlocks the player&amp;apos;s camera distance.<br/>
    ///  Stops the player from being able to zoom in/out the camera.<br/>
    ///  - oPlayer: A player object.<br/>
    ///  - bLocked: TRUE/FALSE.
    public static void LockCameraDistance(uint oPlayer, int bLocked = TRUE)
    {
      VM.StackPush(bLocked);
      VM.StackPush(oPlayer);
      VM.Call(824);
    }

    ///  Locks the player&amp;apos;s camera direction to its current direction,<br/>
    ///  or unlocks the player&amp;apos;s camera direction to enable it to move<br/>
    ///  freely again.<br/>
    ///  Stops the player from being able to rotate the camera direction.<br/>
    ///  - oPlayer: A player object.<br/>
    ///  - bLocked: TRUE/FALSE.
    public static void LockCameraDirection(uint oPlayer, int bLocked = TRUE)
    {
      VM.StackPush(bLocked);
      VM.StackPush(oPlayer);
      VM.Call(825);
    }

    ///  Get the last object that default clicked (left clicked) on the placeable object<br/>
    ///  that is calling this function.<br/>
    ///  Should only be called from a placeables OnClick event.<br/>
    ///  * Returns OBJECT_INVALID if it is called by something other than a placeable.
    public static uint GetPlaceableLastClickedBy()
    {
      VM.Call(826);
      return VM.StackPopObject();
    }

    ///  returns TRUE if the item is flagged as infinite.<br/>
    ///  - oItem: an item.<br/>
    ///  The infinite property affects the buying/selling behavior of the item in a store.<br/>
    ///  An infinite item will still be available to purchase from a store after a player<br/>
    ///  buys the item (non-infinite items will disappear from the store when purchased).
    public static int GetInfiniteFlag(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(827);
      return VM.StackPopInt();
    }

    ///  Sets the Infinite flag on an item<br/>
    ///  - oItem: the item to change<br/>
    ///  - bInfinite: TRUE or FALSE, whether the item should be Infinite<br/>
    ///  The infinite property affects the buying/selling behavior of the item in a store.<br/>
    ///  An infinite item will still be available to purchase from a store after a player<br/>
    ///  buys the item (non-infinite items will disappear from the store when purchased).
    public static void SetInfiniteFlag(uint oItem, int bInfinite = TRUE)
    {
      VM.StackPush(bInfinite);
      VM.StackPush(oItem);
      VM.Call(828);
    }

    ///  Gets the size of the area.<br/>
    ///  - nAreaDimension: The area dimension that you wish to determine.<br/>
    ///       AREA_HEIGHT<br/>
    ///       AREA_WIDTH<br/>
    ///  - oArea: The area that you wish to get the size of.<br/>
    ///  Returns: The number of tiles that the area is wide/high, or zero on an error.<br/>
    ///  If no valid area (or object) is specified, it uses the area of the caller.<br/>
    ///  If an object other than an area is specified, will use the area that the object is currently in.
    public static int GetAreaSize(int nAreaDimension, uint oArea = OBJECT_INVALID)
    {
      VM.StackPush(oArea);
      VM.StackPush(nAreaDimension);
      VM.Call(829);
      return VM.StackPopInt();
    }

    ///  Set the name of oObject.<br/>
    ///  - oObject: the object for which you are changing the name (a creature, placeable, item, or door).<br/>
    ///  - sNewName: the new name that the object will use.<br/>
    ///  Note: SetName() does not work on player objects.<br/>
    ///        Setting an object&amp;apos;s name to &amp;quot;&amp;quot; will make the object<br/>
    ///        revert to using the name it had originally before any<br/>
    ///        SetName() calls were made on the object.
    public static void SetName(uint oObject, string sNewName = "")
    {
      VM.StackPush(sNewName);
      VM.StackPush(oObject);
      VM.Call(830);
    }

    ///  Get the PortraitId of oTarget.<br/>
    ///  - oTarget: the object for which you are getting the portrait Id.<br/>
    ///  Returns: The Portrait Id number being used for the object oTarget.<br/>
    ///           The Portrait Id refers to the row number of the Portraits.2da<br/>
    ///           that this portrait is from.<br/>
    ///           If a custom portrait is being used, oTarget is a player object,<br/>
    ///           or on an error returns PORTRAIT_INVALID. In these instances<br/>
    ///           try using GetPortraitResRef() instead.
    public static int GetPortraitId(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(831);
      return VM.StackPopInt();
    }

    ///  Change the portrait of oTarget to use the Portrait Id specified.<br/>
    ///  - oTarget: the object for which you are changing the portrait.<br/>
    ///  - nPortraitId: The Id of the new portrait to use.<br/>
    ///                 nPortraitId refers to a row in the Portraits.2da<br/>
    ///  Note: Not all portrait Ids are suitable for use with all object types.<br/>
    ///        Setting the portrait Id will also cause the portrait ResRef<br/>
    ///        to be set to the appropriate portrait ResRef for the Id specified.
    public static void SetPortraitId(uint oTarget, int nPortraitId)
    {
      VM.StackPush(nPortraitId);
      VM.StackPush(oTarget);
      VM.Call(832);
    }

    ///  Get the Portrait ResRef of oTarget.<br/>
    ///  - oTarget: the object for which you are getting the portrait ResRef.<br/>
    ///  Returns: The Portrait ResRef being used for the object oTarget.<br/>
    ///           The Portrait ResRef will not include a trailing size letter.
    public static string GetPortraitResRef(uint oTarget = OBJECT_INVALID)
    {
      VM.StackPush(oTarget);
      VM.Call(833);
      return VM.StackPopString();
    }

    ///  Change the portrait of oTarget to use the Portrait ResRef specified.<br/>
    ///  - oTarget: the object for which you are changing the portrait.<br/>
    ///  - sPortraitResRef: The ResRef of the new portrait to use.<br/>
    ///                     The ResRef should not include any trailing size letter ( e.g. po_el_f_09_ ).<br/>
    ///  Note: Not all portrait ResRefs are suitable for use with all object types.<br/>
    ///        Setting the portrait ResRef will also cause the portrait Id<br/>
    ///        to be set to PORTRAIT_INVALID.
    public static void SetPortraitResRef(uint oTarget, string sPortraitResRef)
    {
      VM.StackPush(sPortraitResRef);
      VM.StackPush(oTarget);
      VM.Call(834);
    }

    ///  Set oPlaceable&amp;apos;s useable object status.<br/>
    ///  Note: Only works on non-static placeables.
    public static void SetUseableFlag(uint oPlaceable, int nUseableFlag)
    {
      VM.StackPush(nUseableFlag);
      VM.StackPush(oPlaceable);
      VM.Call(835);
    }

    ///  Get the description of oObject.<br/>
    ///  - oObject: the object from which you are obtaining the description.<br/>
    ///             Can be a creature, item, placeable, door, trigger or module object.<br/>
    ///  - bOriginalDescription:  if set to true any new description specified via a SetDescription scripting command<br/>
    ///                    is ignored and the original object&amp;apos;s description is returned instead.<br/>
    ///  - bIdentified: If oObject is an item, setting this to TRUE will return the identified description,<br/>
    ///                 setting this to FALSE will return the unidentified description. This flag has no<br/>
    ///                 effect on objects other than items.
    public static string GetDescription(uint oObject, int bOriginalDescription = FALSE, int bIdentifiedDescription = TRUE)
    {
      VM.StackPush(bIdentifiedDescription);
      VM.StackPush(bOriginalDescription);
      VM.StackPush(oObject);
      VM.Call(836);
      return VM.StackPopString();
    }

    ///  Set the description of oObject.<br/>
    ///  - oObject: the object for which you are changing the description<br/>
    ///             Can be a creature, placeable, item, door, or trigger.<br/>
    ///  - sNewDescription: the new description that the object will use.<br/>
    ///  - bIdentified: If oObject is an item, setting this to TRUE will set the identified description,<br/>
    ///                 setting this to FALSE will set the unidentified description. This flag has no<br/>
    ///                 effect on objects other than items.<br/>
    ///  Note: Setting an object&amp;apos;s description to &amp;quot;&amp;quot; will make the object<br/>
    ///        revert to using the description it originally had before any<br/>
    ///        SetDescription() calls were made on the object.
    public static void SetDescription(uint oObject, string sNewDescription = "", int bIdentifiedDescription = TRUE)
    {
      VM.StackPush(bIdentifiedDescription);
      VM.StackPush(sNewDescription);
      VM.StackPush(oObject);
      VM.Call(837);
    }

    ///  Get the PC that sent the last player chat(text) message.<br/>
    ///  Should only be called from a module&amp;apos;s OnPlayerChat event script.<br/>
    ///  * Returns OBJECT_INVALID on error.<br/>
    ///  Note: Private tells do not trigger a OnPlayerChat event.
    public static uint GetPCChatSpeaker()
    {
      VM.Call(838);
      return VM.StackPopObject();
    }

    ///  Get the last player chat(text) message that was sent.<br/>
    ///  Should only be called from a module&amp;apos;s OnPlayerChat event script.<br/>
    ///  * Returns empty string &amp;quot;&amp;quot; on error.<br/>
    ///  Note: Private tells do not trigger a OnPlayerChat event.
    public static string GetPCChatMessage()
    {
      VM.Call(839);
      return VM.StackPopString();
    }

    ///  Get the volume of the last player chat(text) message that was sent.<br/>
    ///  Returns one of the following TALKVOLUME_* constants based on the volume setting<br/>
    ///  that the player used to send the chat message.<br/>
    ///                 TALKVOLUME_TALK<br/>
    ///                 TALKVOLUME_WHISPER<br/>
    ///                 TALKVOLUME_SHOUT<br/>
    ///                 TALKVOLUME_SILENT_SHOUT (used for DM chat channel)<br/>
    ///                 TALKVOLUME_PARTY<br/>
    ///  Should only be called from a module&amp;apos;s OnPlayerChat event script.<br/>
    ///  * Returns -1 on error.<br/>
    ///  Note: Private tells do not trigger a OnPlayerChat event.
    public static int GetPCChatVolume()
    {
      VM.Call(840);
      return VM.StackPopInt();
    }

    ///  Set the last player chat(text) message before it gets sent to other players.<br/>
    ///  - sNewChatMessage: The new chat text to be sent onto other players.<br/>
    ///                     Setting the player chat message to an empty string &amp;quot;&amp;quot;,<br/>
    ///                     will cause the chat message to be discarded<br/>
    ///                     (i.e. it will not be sent to other players).<br/>
    ///  Note: The new chat message gets sent after the OnPlayerChat script exits.
    public static void SetPCChatMessage(string sNewChatMessage = "")
    {
      VM.StackPush(sNewChatMessage);
      VM.Call(841);
    }

    ///  Set the last player chat(text) volume before it gets sent to other players.<br/>
    ///  - nTalkVolume: The new volume of the chat text to be sent onto other players.<br/>
    ///                 TALKVOLUME_TALK<br/>
    ///                 TALKVOLUME_WHISPER<br/>
    ///                 TALKVOLUME_SHOUT<br/>
    ///                 TALKVOLUME_SILENT_SHOUT (used for DM chat channel)<br/>
    ///                 TALKVOLUME_PARTY<br/>
    ///                 TALKVOLUME_TELL (sends the chat message privately back to the original speaker)<br/>
    ///  Note: The new chat message gets sent after the OnPlayerChat script exits.
    public static void SetPCChatVolume(int nTalkVolume = TALKVOLUME_TALK)
    {
      VM.StackPush(nTalkVolume);
      VM.Call(842);
    }

    ///  Get the Color of oObject from the color channel specified.<br/>
    ///  - oObject: the object from which you are obtaining the color.<br/>
    ///             Can be a creature that has color information (i.e. the playable races).<br/>
    ///  - nColorChannel: The color channel that you want to get the color value of.<br/>
    ///                    COLOR_CHANNEL_SKIN<br/>
    ///                    COLOR_CHANNEL_HAIR<br/>
    ///                    COLOR_CHANNEL_TATTOO_1<br/>
    ///                    COLOR_CHANNEL_TATTOO_2<br/>
    ///  * Returns -1 on error.
    public static int GetColor(uint oObject, int nColorChannel)
    {
      VM.StackPush(nColorChannel);
      VM.StackPush(oObject);
      VM.Call(843);
      return VM.StackPopInt();
    }

    ///  Set the color channel of oObject to the color specified.<br/>
    ///  - oObject: the object for which you are changing the color.<br/>
    ///             Can be a creature that has color information (i.e. the playable races).<br/>
    ///  - nColorChannel: The color channel that you want to set the color value of.<br/>
    ///                    COLOR_CHANNEL_SKIN<br/>
    ///                    COLOR_CHANNEL_HAIR<br/>
    ///                    COLOR_CHANNEL_TATTOO_1<br/>
    ///                    COLOR_CHANNEL_TATTOO_2<br/>
    ///  - nColorValue: The color you want to set (0-175).
    public static void SetColor(uint oObject, int nColorChannel, int nColorValue)
    {
      VM.StackPush(nColorValue);
      VM.StackPush(nColorChannel);
      VM.StackPush(oObject);
      VM.Call(844);
    }

    ///  Returns Item property Material.  You need to specify the Material Type.<br/>
    ///  - nMasterialType: The Material Type should be a positive integer between 0 and 77 (see iprp_matcost.2da).<br/>
    ///  Note: The Material Type property will only affect the cost of the item if you modify the cost in the iprp_matcost.2da.
    public static System.IntPtr ItemPropertyMaterial(int nMaterialType)
    {
      VM.StackPush(nMaterialType);
      VM.Call(845);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns Item property Quality. You need to specify the Quality.<br/>
    ///  - nQuality:  The Quality of the item property to create (see iprp_qualcost.2da).<br/>
    ///               IP_CONST_QUALITY_*<br/>
    ///  Note: The quality property will only affect the cost of the item if you modify the cost in the iprp_qualcost.2da.
    public static System.IntPtr ItemPropertyQuality(int nQuality)
    {
      VM.StackPush(nQuality);
      VM.Call(846);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns a generic Additional Item property. You need to specify the Additional property.<br/>
    ///  - nProperty: The item property to create (see iprp_addcost.2da).<br/>
    ///               IP_CONST_ADDITIONAL_*<br/>
    ///  Note: The additional property only affects the cost of the item if you modify the cost in the iprp_addcost.2da.
    public static System.IntPtr ItemPropertyAdditional(int nAdditionalProperty)
    {
      VM.StackPush(nAdditionalProperty);
      VM.Call(847);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Sets a new tag for oObject.<br/>
    ///  Will do nothing for invalid objects or the module object.<br/>
    /// <br/>
    ///  Note: Care needs to be taken with this function.<br/>
    ///        Changing the tag for creature with waypoints will make them stop walking them.<br/>
    ///        Changing waypoint, door or trigger tags will break their area transitions.
    public static void SetTag(uint oObject, string sNewTag)
    {
      VM.StackPush(sNewTag);
      VM.StackPush(oObject);
      VM.Call(848);
    }

    ///  Returns the string tag set for the provided effect.<br/>
    ///  - If no tag has been set, returns an empty string.
    public static string GetEffectTag(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(849);
      return VM.StackPopString();
    }

    ///  Tags the effect with the provided string.<br/>
    ///  - Any other tags in the link will be overwritten.
    public static System.IntPtr TagEffect(System.IntPtr eEffect, string sNewTag)
    {
      VM.StackPush(sNewTag);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(850);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Returns the caster level of the creature who created the effect.<br/>
    ///  - If not created by a creature, returns 0.<br/>
    ///  - If created by a spell-like ability, returns 0.
    public static int GetEffectCasterLevel(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(851);
      return VM.StackPopInt();
    }

    ///  Returns the total duration of the effect in seconds.<br/>
    ///  - Returns 0 if the duration type of the effect is not DURATION_TYPE_TEMPORARY.
    public static int GetEffectDuration(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(852);
      return VM.StackPopInt();
    }

    ///  Returns the remaining duration of the effect in seconds.<br/>
    ///  - Returns 0 if the duration type of the effect is not DURATION_TYPE_TEMPORARY.
    public static int GetEffectDurationRemaining(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(853);
      return VM.StackPopInt();
    }

    ///  Returns the string tag set for the provided item property.<br/>
    ///  - If no tag has been set, returns an empty string.
    public static string GetItemPropertyTag(System.IntPtr nProperty)
    {
      VM.StackPush(nProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(854);
      return VM.StackPopString();
    }

    ///  Tags the item property with the provided string.<br/>
    ///  - Any tags currently set on the item property will be overwritten.
    public static System.IntPtr TagItemProperty(System.IntPtr nProperty, string sNewTag)
    {
      VM.StackPush(sNewTag);
      VM.StackPush(nProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(855);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Returns the total duration of the item property in seconds.<br/>
    ///  - Returns 0 if the duration type of the item property is not DURATION_TYPE_TEMPORARY.
    public static int GetItemPropertyDuration(System.IntPtr nProperty)
    {
      VM.StackPush(nProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(856);
      return VM.StackPopInt();
    }

    ///  Returns the remaining duration of the item property in seconds.<br/>
    ///  - Returns 0 if the duration type of the item property is not DURATION_TYPE_TEMPORARY.
    public static int GetItemPropertyDurationRemaining(System.IntPtr nProperty)
    {
      VM.StackPush(nProperty, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.Call(857);
      return VM.StackPopInt();
    }

    ///  Instances a new area from the given sSourceResRef, which needs to be a existing module area.<br/>
    ///  Will optionally set a new area tag and displayed name. The new area is accessible<br/>
    ///  immediately, but initialisation scripts for the area and all contained creatures will only<br/>
    ///  run after the current script finishes (so you can clean up objects before returning).<br/>
    /// <br/>
    ///  Returns the new area, or OBJECT_INVALID on failure.<br/>
    /// <br/>
    ///  Note: When spawning a second instance of a existing area, you will have to manually<br/>
    ///        adjust all transitions (doors, triggers) with the relevant script commands,<br/>
    ///        or players might end up in the wrong area.<br/>
    ///  Note: Areas cannot have duplicate ResRefs, so your new area will have a autogenerated,<br/>
    ///        sequential resref starting with &amp;quot;nw_&amp;quot;; for example: nw_5. You cannot influence this resref.<br/>
    ///        If you destroy an area, that resref will be come free for reuse for the next area created.<br/>
    ///        If you need to know the resref of your new area, you can call GetResRef on it.<br/>
    ///  Note: When instancing an area from a loaded savegame, it will spawn the area as it was at time of save, NOT<br/>
    ///        at module creation. This is because the savegame replaces the module data. Due to technical limitations,<br/>
    ///        polymorphed creatures, personal reputation, and associates will currently fail to restore correctly.
    public static uint CreateArea(string sSourceResRef, string sNewTag = "", string sNewName = "")
    {
      VM.StackPush(sNewName);
      VM.StackPush(sNewTag);
      VM.StackPush(sSourceResRef);
      VM.Call(858);
      return VM.StackPopObject();
    }

    ///  Destroys the given area object and everything in it.<br/>
    /// <br/>
    ///  If the area is in a module, the .are and .git data is left behind and you can spawn from<br/>
    ///  it again. If the area is a temporary copy, the data will be deleted and you cannot spawn it again<br/>
    ///  via the resref.<br/>
    /// <br/>
    ///  Return values:<br/>
    ///     0: Object not an area or invalid.<br/>
    ///    -1: Area contains spawn location and removal would leave module without entrypoint.<br/>
    ///    -2: Players in area.<br/>
    ///     1: Area destroyed successfully.
    public static int DestroyArea(uint oArea)
    {
      VM.StackPush(oArea);
      VM.Call(859);
      return VM.StackPopInt();
    }

    ///  Creates a copy of a existing area, including everything inside of it (except players).<br/>
    ///  Will optionally set a new area tag and displayed name. The new area is accessible<br/>
    ///  immediately, but initialisation scripts for the area and all contained creatures will only<br/>
    ///  run after the current script finishes (so you can clean up objects before returning).<br/>
    /// <br/>
    ///  This is similar to CreateArea, except this variant will copy all changes made to the source<br/>
    ///  area since it has spawned. CreateArea() will instance the area from the .are and .git data<br/>
    ///  as it was at creation.<br/>
    /// <br/>
    ///  Returns the new area, or OBJECT_INVALID on error.<br/>
    /// <br/>
    ///  Note: You will have to manually adjust all transitions (doors, triggers) with the<br/>
    ///        relevant script commands, or players might end up in the wrong area.<br/>
    ///  Note: Areas cannot have duplicate ResRefs, so your new area will have a autogenerated,<br/>
    ///        sequential resref starting with &amp;quot;nw_&amp;quot;; for example: nw_5. You cannot influence this resref.<br/>
    ///        If you destroy an area, that resref will be come free for reuse for the next area created.<br/>
    ///        If you need to know the resref of your new area, you can call GetResRef on it.
    public static uint CopyArea(uint oArea, string sNewTag = "", string sNewName = "")
    {
      VM.StackPush(sNewName);
      VM.StackPush(sNewTag);
      VM.StackPush(oArea);
      VM.Call(860);
      return VM.StackPopObject();
    }

    ///  Returns the first area in the module.
    public static uint GetFirstArea()
    {
      VM.Call(861);
      return VM.StackPopObject();
    }

    ///  Returns the next area in the module (after GetFirstArea), or OBJECT_INVALID if no more<br/>
    ///  areas are loaded.
    public static uint GetNextArea()
    {
      VM.Call(862);
      return VM.StackPopObject();
    }

    ///  Sets the transition target for oTransition.<br/>
    /// <br/>
    ///  Notes:<br/>
    ///  - oTransition can be any valid game object, except areas.<br/>
    ///  - oTarget can be any valid game object with a location, or OBJECT_INVALID (to unlink).<br/>
    ///  - Rebinding a transition will NOT change the other end of the transition; for example,<br/>
    ///    with normal doors you will have to do either end separately.<br/>
    ///  - Any valid game object can hold a transition target, but only some are used by the game engine<br/>
    ///    (doors and triggers). This might change in the future. You can still set and query them for<br/>
    ///    other game objects from nwscript.<br/>
    ///  - Transition target objects are cached: The toolset-configured destination tag is<br/>
    ///    used for a lookup only once, at first use. Thus, attempting to use SetTag() to change the<br/>
    ///    destination for a transition will not work in a predictable fashion.
    public static void SetTransitionTarget(uint oTransition, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(oTransition);
      VM.Call(863);
    }

    ///  Sets whether the provided item should be hidden when equipped.<br/>
    ///  - The intended usage of this function is to provide an easy way to hide helmets, but it<br/>
    ///    can be used equally for any slot which has creature mesh visibility when equipped,<br/>
    ///    e.g.: armour, helm, cloak, left hand, and right hand.<br/>
    ///  - nValue should be TRUE or FALSE.
    public static void SetHiddenWhenEquipped(uint oItem, int nValue)
    {
      VM.StackPush(nValue);
      VM.StackPush(oItem);
      VM.Call(864);
    }

    ///  Returns whether the provided item is hidden when equipped.
    public static int GetHiddenWhenEquipped(uint oItem)
    {
      VM.StackPush(oItem);
      VM.Call(865);
      return VM.StackPopInt();
    }

    ///  Sets if the given creature has explored tile at x, y of the given area.<br/>
    ///  Note that creature needs to be a player- or player-possessed creature.<br/>
    /// <br/>
    ///  Keep in mind that tile exploration also controls object visibility in areas<br/>
    ///  and the fog of war for interior and underground areas.<br/>
    /// <br/>
    ///  Return values:<br/>
    ///   -1: Area or creature invalid.<br/>
    ///    0: Tile was not explored before setting newState.<br/>
    ///    1: Tile was explored before setting newState.
    public static int SetTileExplored(uint creature, uint area, int x, int y, int newState)
    {
      VM.StackPush(newState);
      VM.StackPush(y);
      VM.StackPush(x);
      VM.StackPush(area);
      VM.StackPush(creature);
      VM.Call(866);
      return VM.StackPopInt();
    }

    ///  Returns whether the given tile at x, y, for the given creature in the stated<br/>
    ///  area is visible on the map.<br/>
    ///  Note that creature needs to be a player- or player-possessed creature.<br/>
    /// <br/>
    ///  Keep in mind that tile exploration also controls object visibility in areas<br/>
    ///  and the fog of war for interior and underground areas.<br/>
    /// <br/>
    ///  Return values:<br/>
    ///   -1: Area or creature invalid.<br/>
    ///    0: Tile is not explored yet.<br/>
    ///    1: Tile is explored.
    public static int GetTileExplored(uint creature, uint area, int x, int y)
    {
      VM.StackPush(y);
      VM.StackPush(x);
      VM.StackPush(area);
      VM.StackPush(creature);
      VM.Call(867);
      return VM.StackPopInt();
    }

    ///  Sets the creature to auto-explore the map as it walks around.<br/>
    /// <br/>
    ///  Keep in mind that tile exploration also controls object visibility in areas<br/>
    ///  and the fog of war for interior and underground areas.<br/>
    /// <br/>
    ///  This means that if you turn off auto exploration, it falls to you to manage this<br/>
    ///  through SetTileExplored(); otherwise, the player will not be able to see anything.<br/>
    /// <br/>
    ///  Valid arguments: TRUE and FALSE.<br/>
    ///  Does nothing for non-creatures.<br/>
    ///  Returns the previous state (or -1 if non-creature).
    public static int SetCreatureExploresMinimap(uint creature, int newState)
    {
      VM.StackPush(newState);
      VM.StackPush(creature);
      VM.Call(868);
      return VM.StackPopInt();
    }

    ///  Returns TRUE if the creature is set to auto-explore the map as it walks around (on by default).<br/>
    ///  Returns FALSE if creature is not actually a creature.
    public static int GetCreatureExploresMinimap(uint creature)
    {
      VM.StackPush(creature);
      VM.Call(869);
      return VM.StackPopInt();
    }

    ///  Get the surface material at the given location. (This is<br/>
    ///  equivalent to the walkmesh type).<br/>
    ///  Returns 0 if the location is invalid or has no surface type.
    public static int GetSurfaceMaterial(System.IntPtr at)
    {
      VM.StackPush(at, ENGINE_STRUCTURE_LOCATION);
      VM.Call(870);
      return VM.StackPopInt();
    }

    ///  Returns the z-offset at which the walkmesh is at the given location.<br/>
    ///  Returns -6.0 for invalid locations.
    public static float GetGroundHeight(System.IntPtr at)
    {
      VM.StackPush(at, ENGINE_STRUCTURE_LOCATION);
      VM.Call(871);
      return VM.StackPopFloat();
    }

    ///  Gets the attack bonus limit.<br/>
    ///  - The default value is 20.
    public static int GetAttackBonusLimit()
    {
      VM.Call(872);
      return VM.StackPopInt();
    }

    ///  Gets the damage bonus limit.<br/>
    ///  - The default value is 100.
    public static int GetDamageBonusLimit()
    {
      VM.Call(873);
      return VM.StackPopInt();
    }

    ///  Gets the saving throw bonus limit.<br/>
    ///  - The default value is 20.
    public static int GetSavingThrowBonusLimit()
    {
      VM.Call(874);
      return VM.StackPopInt();
    }

    ///  Gets the ability bonus limit.<br/>
    ///  - The default value is 12.
    public static int GetAbilityBonusLimit()
    {
      VM.Call(875);
      return VM.StackPopInt();
    }

    ///  Gets the ability penalty limit.<br/>
    ///  - The default value is 30.
    public static int GetAbilityPenaltyLimit()
    {
      VM.Call(876);
      return VM.StackPopInt();
    }

    ///  Gets the skill bonus limit.<br/>
    ///  - The default value is 50.
    public static int GetSkillBonusLimit()
    {
      VM.Call(877);
      return VM.StackPopInt();
    }

    ///  Sets the attack bonus limit.<br/>
    ///  - The minimum value is 0.<br/>
    ///  - The maximum value is 255.<br/>
    ///  - This script call will temporarily override user/server configuration for the running module only.
    public static void SetAttackBonusLimit(int nNewLimit)
    {
      VM.StackPush(nNewLimit);
      VM.Call(878);
    }

    ///  Sets the damage bonus limit.<br/>
    ///  - The minimum value is 0.<br/>
    ///  - The maximum value is 255.<br/>
    ///  - This script call will temporarily override user/server configuration for the running module only.
    public static void SetDamageBonusLimit(int nNewLimit)
    {
      VM.StackPush(nNewLimit);
      VM.Call(879);
    }

    ///  Sets the saving throw bonus limit.<br/>
    ///  - The minimum value is 0.<br/>
    ///  - The maximum value is 255.<br/>
    ///  - This script call will temporarily override user/server configuration for the running module only.
    public static void SetSavingThrowBonusLimit(int nNewLimit)
    {
      VM.StackPush(nNewLimit);
      VM.Call(880);
    }

    ///  Sets the ability bonus limit.<br/>
    ///  - The minimum value is 0.<br/>
    ///  - The maximum value is 255.<br/>
    ///  - This script call will temporarily override user/server configuration for the running module only.
    public static void SetAbilityBonusLimit(int nNewLimit)
    {
      VM.StackPush(nNewLimit);
      VM.Call(881);
    }

    ///  Sets the ability penalty limit.<br/>
    ///  - The minimum value is 0.<br/>
    ///  - The maximum value is 255.<br/>
    ///  - This script call will temporarily override user/server configuration for the running module only.
    public static void SetAbilityPenaltyLimit(int nNewLimit)
    {
      VM.StackPush(nNewLimit);
      VM.Call(882);
    }

    ///  Sets the skill bonus limit.<br/>
    ///  - The minimum value is 0.<br/>
    ///  - The maximum value is 255.<br/>
    ///  - This script call will temporarily override user/server configuration for the running module only.
    public static void SetSkillBonusLimit(int nNewLimit)
    {
      VM.StackPush(nNewLimit);
      VM.Call(883);
    }

    ///  Get if oPlayer is currently connected over a relay (instead of directly).<br/>
    ///  Returns FALSE for any other object, including OBJECT_INVALID.
    public static int GetIsPlayerConnectionRelayed(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(884);
      return VM.StackPopInt();
    }

    ///  Returns the event script for the given object and handler.<br/>
    ///  Will return &amp;quot;&amp;quot; if unset, the object is invalid, or the object cannot<br/>
    ///  have the requested handler.
    public static string GetEventScript(uint oObject, int nHandler)
    {
      VM.StackPush(nHandler);
      VM.StackPush(oObject);
      VM.Call(885);
      return VM.StackPopString();
    }

    ///  Sets the given event script for the given object and handler.<br/>
    ///  Returns 1 on success, 0 on failure.<br/>
    ///  Will fail if oObject is invalid or does not have the requested handler.
    public static int SetEventScript(uint oObject, int nHandler, string sScript)
    {
      VM.StackPush(sScript);
      VM.StackPush(nHandler);
      VM.StackPush(oObject);
      VM.Call(886);
      return VM.StackPopInt();
    }

    ///  Gets a visual transform on the given object.<br/>
    ///  - oObject can be any valid Creature, Placeable, Item or Door.<br/>
    ///  - nTransform is one of OBJECT_VISUAL_TRANSFORM_*<br/>
    ///  Returns the current (or default) value.
    public static float GetObjectVisualTransform(uint oObject, int nTransform, int bCurrentLerp = FALSE)
    {
      VM.StackPush(bCurrentLerp);
      VM.StackPush(nTransform);
      VM.StackPush(oObject);
      VM.Call(887);
      return VM.StackPopFloat();
    }

    ///  Sets a visual transform on the given object.<br/>
    ///  - oObject can be any valid Creature, Placeable, Item or Door.<br/>
    ///  - nTransform is one of OBJECT_VISUAL_TRANSFORM_*<br/>
    ///  - fValue depends on the transformation to apply.<br/>
    ///  Returns the old/previous value.
    public static float SetObjectVisualTransform(uint oObject, int nTransform, float fValue, int nLerpType = OBJECT_VISUAL_TRANSFORM_LERP_NONE, float fLerpDuration = 0.0f, int bPauseWithGame = TRUE)
    {
      VM.StackPush(bPauseWithGame);
      VM.StackPush(fLerpDuration);
      VM.StackPush(nLerpType);
      VM.StackPush(fValue);
      VM.StackPush(nTransform);
      VM.StackPush(oObject);
      VM.Call(888);
      return VM.StackPopFloat();
    }

    ///  Sets an integer material shader uniform override.<br/>
    ///  - sMaterial needs to be a material on that object.<br/>
    ///  - sParam needs to be a valid shader parameter already defined on the material.
    public static void SetMaterialShaderUniformInt(uint oObject, string sMaterial, string sParam, int nValue)
    {
      VM.StackPush(nValue);
      VM.StackPush(sParam);
      VM.StackPush(sMaterial);
      VM.StackPush(oObject);
      VM.Call(889);
    }

    ///  Sets a vec4 material shader uniform override.<br/>
    ///  - sMaterial needs to be a material on that object.<br/>
    ///  - sParam needs to be a valid shader parameter already defined on the material.<br/>
    ///  - You can specify a single float value to set just a float, instead of a vec4.
    public static void SetMaterialShaderUniformVec4(uint oObject, string sMaterial, string sParam, float fValue1, float fValue2 = 0.0f, float fValue3 = 0.0f, float fValue4 = 0.0f)
    {
      VM.StackPush(fValue4);
      VM.StackPush(fValue3);
      VM.StackPush(fValue2);
      VM.StackPush(fValue1);
      VM.StackPush(sParam);
      VM.StackPush(sMaterial);
      VM.StackPush(oObject);
      VM.Call(890);
    }

    ///  Resets material shader parameters on the given object:<br/>
    ///  - Supply a material to only reset shader uniforms for meshes with that material.<br/>
    ///  - Supply a parameter to only reset shader uniforms of that name.<br/>
    ///  - Supply both to only reset shader uniforms of that name on meshes with that material.
    public static void ResetMaterialShaderUniforms(uint oObject, string sMaterial = "", string sParam = "")
    {
      VM.StackPush(sParam);
      VM.StackPush(sMaterial);
      VM.StackPush(oObject);
      VM.Call(891);
    }

    ///  Vibrate the player&amp;apos;s device or controller. Does nothing if vibration is not supported.<br/>
    ///  - nMotor is one of VIBRATOR_MOTOR_*<br/>
    ///  - fStrength is between 0.0 and 1.0<br/>
    ///  - fSeconds is the number of seconds to vibrate
    public static void Vibrate(uint oPlayer, int nMotor, float fStrength, float fSeconds)
    {
      VM.StackPush(fSeconds);
      VM.StackPush(fStrength);
      VM.StackPush(nMotor);
      VM.StackPush(oPlayer);
      VM.Call(892);
    }

    ///  Unlock an achievement for the given player who must be logged in.<br/>
    ///  - sId is the achievement ID on the remote server<br/>
    ///  - nLastValue is the previous value of the associated achievement stat<br/>
    ///  - nCurValue is the current value of the associated achievement stat<br/>
    ///  - nMaxValue is the maximum value of the associate achievement stat
    public static void UnlockAchievement(uint oPlayer, string sId, int nLastValue = 0, int nCurValue = 0, int nMaxValue = 0)
    {
      VM.StackPush(nMaxValue);
      VM.StackPush(nCurValue);
      VM.StackPush(nLastValue);
      VM.StackPush(sId);
      VM.StackPush(oPlayer);
      VM.Call(893);
    }

    ///  Execute a script chunk.<br/>
    ///  The script chunk runs immediately, same as ExecuteScript().<br/>
    ///  The script is jitted in place and currently not cached: Each invocation will recompile the script chunk.<br/>
    ///  Note that the script chunk will run as if a separate script. This is not eval().<br/>
    ///  By default, the script chunk is wrapped into void main() {}. Pass in bWrapIntoMain = FALSE to override.<br/>
    ///  Returns &amp;quot;&amp;quot; on success, or the compilation error.
    public static string ExecuteScriptChunk(string sScriptChunk, uint oObject = OBJECT_INVALID, int bWrapIntoMain = TRUE)
    {
      VM.StackPush(bWrapIntoMain);
      VM.StackPush(oObject);
      VM.StackPush(sScriptChunk);
      VM.Call(894);
      return VM.StackPopString();
    }

    ///  Returns a UUID. This UUID will not be associated with any object.<br/>
    ///  The generated UUID is currently a v4.
    public static string GetRandomUUID()
    {
      VM.Call(895);
      return VM.StackPopString();
    }

    ///  Returns the given objects&amp;apos; UUID. This UUID is persisted across save boundaries,<br/>
    ///  like Save/RestoreCampaignObject and save games.<br/>
    /// <br/>
    ///  Thus, reidentification is only guaranteed in scenarios where players cannot introduce<br/>
    ///  new objects (i.e. servervault servers).<br/>
    /// <br/>
    ///  UUIDs are guaranteed to be unique in any single running game.<br/>
    /// <br/>
    ///  If a loaded object would collide with a UUID already present in the game, the<br/>
    ///  object receives no UUID and a warning is emitted to the log. Requesting a UUID<br/>
    ///  for the new object will generate a random one.<br/>
    /// <br/>
    ///  This UUID is useful to, for example:<br/>
    ///  - Safely identify servervault characters<br/>
    ///  - Track serialisable objects (like items or creatures) as they are saved to the<br/>
    ///    campaign DB - i.e. persistent storage chests or dropped items.<br/>
    ///  - Track objects across multiple game instances (in trusted scenarios).<br/>
    /// <br/>
    ///  Currently, the following objects can carry UUIDs:<br/>
    ///    Items, Creatures, Placeables, Triggers, Doors, Waypoints, Stores,<br/>
    ///    Encounters, Areas.<br/>
    /// <br/>
    ///  Will return &amp;quot;&amp;quot; (empty string) when the given object cannot carry a UUID.
    public static string GetObjectUUID(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(896);
      return VM.StackPopString();
    }

    ///  Forces the given object to receive a new UUID, discarding the current value.
    public static void ForceRefreshObjectUUID(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(897);
    }

    ///  Looks up a object on the server by it&amp;apos;s UUID.<br/>
    ///  Returns OBJECT_INVALID if the UUID is not on the server.
    public static uint GetObjectByUUID(string sUUID)
    {
      VM.StackPush(sUUID);
      VM.Call(898);
      return VM.StackPopObject();
    }

    ///  Do not call. This does nothing on this platform except to return an error.
    public static void Reserved899()
    {
      VM.Call(899);
    }

    ///  Makes oPC load texture sNewName instead of sOldName.<br/>
    ///  If oPC is OBJECT_INVALID, it will apply the override to all active players<br/>
    ///  Setting sNewName to &amp;quot;&amp;quot; will clear the override and revert to original.
    public static void SetTextureOverride(string sOldName, string sNewName = "", uint oPC = OBJECT_INVALID)
    {
      VM.StackPush(oPC);
      VM.StackPush(sNewName);
      VM.StackPush(sOldName);
      VM.Call(900);
    }

    ///  Displays sMsg on oPC&amp;apos;s screen.<br/>
    ///  The message is displayed on top of whatever is on the screen, including UI elements<br/>
    ///   nX, nY - coordinates of the first character to be displayed. The value is in terms<br/>
    ///            of character &amp;apos;slot&amp;apos; relative to the nAnchor anchor point.<br/>
    ///            If the number is negative, it is applied from the bottom/right.<br/>
    ///   nAnchor - SCREEN_ANCHOR_* constant<br/>
    ///   fLife - Duration in seconds until the string disappears.<br/>
    ///   nRGBA, nRGBA2 - Colors of the string in 0xRRGGBBAA format. String starts at nRGBA,<br/>
    ///                   but as it nears end of life, it will slowly blend into nRGBA2.<br/>
    ///   nID - Optional ID of a string. If not 0, subsequent calls to PostString will<br/>
    ///         remove the old string with the same ID, even if it&amp;apos;s lifetime has not elapsed.<br/>
    ///         Only positive values are allowed.<br/>
    ///   sFont - If specified, use this custom font instead of default console font.
    public static void PostString(uint oPC, string sMsg, int nX = 0, int nY = 0, int nAnchor = SCREEN_ANCHOR_TOP_LEFT, float fLife = 10.0f, int nRGBA = 2147418367, int nRGBA2 = 2147418367, int nID = 0, string sFont = "")
    {
      VM.StackPush(sFont);
      VM.StackPush(nID);
      VM.StackPush(nRGBA2);
      VM.StackPush(nRGBA);
      VM.StackPush(fLife);
      VM.StackPush(nAnchor);
      VM.StackPush(nY);
      VM.StackPush(nX);
      VM.StackPush(sMsg);
      VM.StackPush(oPC);
      VM.Call(901);
    }

    ///  Returns oCreature&amp;apos;s spell school specialization in nClass (SPELL_SCHOOL_* constants)<br/>
    ///  Unless custom content is used, only Wizards have spell schools<br/>
    ///  Returns -1 on error
    public static int GetSpecialization(uint oCreature, int nClass = CLASS_TYPE_WIZARD)
    {
      VM.StackPush(nClass);
      VM.StackPush(oCreature);
      VM.Call(902);
      return VM.StackPopInt();
    }

    ///  Returns oCreature&amp;apos;s domain in nClass (DOMAIN_* constants)<br/>
    ///  nDomainIndex - 1 or 2<br/>
    ///  Unless custom content is used, only Clerics have domains<br/>
    ///  Returns -1 on error
    public static int GetDomain(uint oCreature, int nDomainIndex = 1, int nClass = CLASS_TYPE_CLERIC)
    {
      VM.StackPush(nClass);
      VM.StackPush(nDomainIndex);
      VM.StackPush(oCreature);
      VM.Call(903);
      return VM.StackPopInt();
    }

    ///  Returns the build number of oPlayer (i.e. 8193).<br/>
    ///  Returns 0 if the given object isn&amp;apos;t a player or did not advertise their build info.
    public static int GetPlayerBuildVersionMajor(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(904);
      return VM.StackPopInt();
    }

    ///  Returns the patch revision of oPlayer (i.e. 8).<br/>
    ///  Returns 0 if the given object isn&amp;apos;t a player or did not advertise their build info.
    public static int GetPlayerBuildVersionMinor(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(905);
      return VM.StackPopInt();
    }

    ///  Returns the script parameter value for a given parameter name.<br/>
    ///  Script parameters can be set for conversation scripts in the toolset&amp;apos;s<br/>
    ///  Conversation Editor, or for any script with SetScriptParam().<br/>
    ///  * Will return &amp;quot;&amp;quot; if a parameter with the given name does not exist.
    public static string GetScriptParam(string sParamName)
    {
      VM.StackPush(sParamName);
      VM.Call(906);
      return VM.StackPopString();
    }

    ///  Set a script parameter value for the next script to be run.<br/>
    ///  Call this function to set parameters right before calling ExecuteScript().
    public static void SetScriptParam(string sParamName, string sParamValue)
    {
      VM.StackPush(sParamValue);
      VM.StackPush(sParamName);
      VM.Call(907);
    }

    ///  Returns the number of uses per day remaining of the given item and item property.<br/>
    ///  * Will return 0 if the given item does not have the requested item property,<br/>
    ///    or the item property is not uses/day.
    public static int GetItemPropertyUsesPerDayRemaining(uint oItem, System.IntPtr ip)
    {
      VM.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.StackPush(oItem);
      VM.Call(908);
      return VM.StackPopInt();
    }

    ///  Sets the number of uses per day remaining of the given item and item property.<br/>
    ///  * Will do nothing if the given item and item property is not uses/day.<br/>
    ///  * Will constrain nUsesPerDay to the maximum allowed as the cost table defines.
    public static void SetItemPropertyUsesPerDayRemaining(uint oItem, System.IntPtr ip, int nUsesPerDay)
    {
      VM.StackPush(nUsesPerDay);
      VM.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.StackPush(oItem);
      VM.Call(909);
    }

    ///  Queue an action to use an active item property.<br/>
    ///  * oItem - item that has the item property to use<br/>
    ///  * ip - item property to use<br/>
    ///  * object oTarget - target<br/>
    ///  * nSubPropertyIndex - specify if your itemproperty has subproperties (such as subradial spells)<br/>
    ///  * bDecrementCharges - decrement charges if item property is limited
    public static void ActionUseItemOnObject(uint oItem, System.IntPtr ip, uint oTarget, int nSubPropertyIndex = 0, int bDecrementCharges = TRUE)
    {
      VM.StackPush(bDecrementCharges);
      VM.StackPush(nSubPropertyIndex);
      VM.StackPush(oTarget);
      VM.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.StackPush(oItem);
      VM.Call(910);
    }

    ///  Queue an action to use an active item property.<br/>
    ///  * oItem - item that has the item property to use<br/>
    ///  * ip - item property to use<br/>
    ///  * location lTarget - target location (must be in the same area as item possessor)<br/>
    ///  * nSubPropertyIndex - specify if your itemproperty has subproperties (such as subradial spells)<br/>
    ///  * bDecrementCharges - decrement charges if item property is limited
    public static void ActionUseItemAtLocation(uint oItem, System.IntPtr ip, System.IntPtr lTarget, int nSubPropertyIndex = 0, int bDecrementCharges = TRUE)
    {
      VM.StackPush(bDecrementCharges);
      VM.StackPush(nSubPropertyIndex);
      VM.StackPush(lTarget, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(ip, ENGINE_STRUCTURE_ITEMPROPERTY);
      VM.StackPush(oItem);
      VM.Call(911);
    }

    ///  Makes oPC enter a targeting mode, letting them select an object as a target<br/>
    ///  If a PC selects a target or cancels out, it will trigger the module OnPlayerTarget event.
    public static void EnterTargetingMode(uint oPC, int nValidObjectTypes = OBJECT_TYPE_ALL, int nMouseCursorId = MOUSECURSOR_MAGIC, int nBadTargetCursor = MOUSECURSOR_NOMAGIC)
    {
      VM.StackPush(nBadTargetCursor);
      VM.StackPush(nMouseCursorId);
      VM.StackPush(nValidObjectTypes);
      VM.StackPush(oPC);
      VM.Call(912);
    }

    ///  Gets the target object in the module OnPlayerTarget event.<br/>
    ///  Returns the area object when the target is the ground.<br/>
    ///  Note: returns OBJECT_INVALID if the player cancelled out of targeting mode.
    public static uint GetTargetingModeSelectedObject()
    {
      VM.Call(913);
      return VM.StackPopObject();
    }

    ///  Gets the target position in the module OnPlayerTarget event.
    public static System.Numerics.Vector3 GetTargetingModeSelectedPosition()
    {
      VM.Call(914);
      return VM.StackPopVector();
    }

    ///  Gets the player object that triggered the OnPlayerTarget event.
    public static uint GetLastPlayerToSelectTarget()
    {
      VM.Call(915);
      return VM.StackPopObject();
    }

    ///  Sets oObject&amp;apos;s hilite color to nColor<br/>
    ///  The nColor format is 0xRRGGBB; -1 clears the color override.
    public static void SetObjectHiliteColor(uint oObject, int nColor = -1)
    {
      VM.StackPush(nColor);
      VM.StackPush(oObject);
      VM.Call(916);
    }

    ///  Sets the cursor (MOUSECURSOR_*) to use when hovering over oObject
    public static void SetObjectMouseCursor(uint oObject, int nCursor = -1)
    {
      VM.StackPush(nCursor);
      VM.StackPush(oObject);
      VM.Call(917);
    }

    ///  Returns TRUE if the given player-controlled creature has DM privileges<br/>
    ///  gained through a player login (as opposed to the DM client).<br/>
    ///  Note: GetIsDM() also returns TRUE for player creature DMs.
    public static int GetIsPlayerDM(uint oCreature)
    {
      VM.StackPush(oCreature);
      VM.Call(918);
      return VM.StackPopInt();
    }

    ///  Sets the detailed wind data for oArea<br/>
    ///  The predefined values in the toolset are:<br/>
    ///    NONE:  vDirection=(1.0, 1.0, 0.0), fMagnitude=0.0, fYaw=0.0,   fPitch=0.0<br/>
    ///    LIGHT: vDirection=(1.0, 1.0, 0.0), fMagnitude=1.0, fYaw=100.0, fPitch=3.0<br/>
    ///    HEAVY: vDirection=(1.0, 1.0, 0.0), fMagnitude=2.0, fYaw=150.0, fPitch=5.0
    public static void SetAreaWind(uint oArea, System.Numerics.Vector3 vDirection, float fMagnitude, float fYaw, float fPitch)
    {
      VM.StackPush(fPitch);
      VM.StackPush(fYaw);
      VM.StackPush(fMagnitude);
      VM.StackPush(vDirection);
      VM.StackPush(oArea);
      VM.Call(919);
    }

    ///  Replace&amp;apos;s oObject&amp;apos;s texture sOld with sNew.<br/>
    ///  Specifying sNew = &amp;quot;&amp;quot; will restore the original texture.<br/>
    ///  If sNew cannot be found, the original texture will be restored.<br/>
    ///  sNew must refer to a simple texture, not PLT
    public static void ReplaceObjectTexture(uint oObject, string sOld, string sNew = "")
    {
      VM.StackPush(sNew);
      VM.StackPush(sOld);
      VM.StackPush(oObject);
      VM.Call(920);
    }

    ///  Destroys the given sqlite database, clearing out all data and schema.<br/>
    ///  This operation is _immediate_ and _irreversible_, even when<br/>
    ///  inside a transaction or running query.<br/>
    ///  Existing active/prepared sqlqueries will remain functional, but any references<br/>
    ///  to stored data or schema members will be invalidated.<br/>
    ///  oObject: Same as SqlPrepareQueryObject().<br/>
    ///           To reset a campaign database, please use DestroyCampaignDatabase().
    public static void SqlDestroyDatabase(uint oObject)
    {
      VM.StackPush(oObject);
      VM.Call(921);
    }

    ///  Returns &amp;quot;&amp;quot; if the last Sql command succeeded; or a human-readable error otherwise.<br/>
    ///  Additionally, all SQL errors are logged to the server log.
    public static string SqlGetError(System.IntPtr sqlQuery)
    {
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(922);
      return VM.StackPopString();
    }

    ///  Sets up a query.<br/>
    ///  This will NOT run the query; only make it available for parameter binding.<br/>
    ///  To run the query, you need to call SqlStep(); even if you do not<br/>
    ///  expect result data.<br/>
    ///  sDatabase: The name of a campaign database.<br/>
    ///             Note that when accessing campaign databases, you do not write access<br/>
    ///             to the builtin tables needed for CampaignDB functionality.<br/>
    ///  N.B.: You can pass sqlqueries into DelayCommand; HOWEVER<br/>
    ///        *** they will NOT survive a game save/load ***<br/>
    ///        Any commands on a restored sqlquery will fail.<br/>
    ///  Please check the SQLite_README.txt file in lang/en/docs/ for the list of builtin functions.
    public static System.IntPtr SqlPrepareQueryCampaign(string sDatabase, string sQuery)
    {
      VM.StackPush(sQuery);
      VM.StackPush(sDatabase);
      VM.Call(923);
      return VM.StackPopStruct(ENGINE_STRUCTURE_SQLQUERY);
    }

    ///  Sets up a query.<br/>
    ///  This will NOT run the query; only make it available for parameter binding.<br/>
    ///  To run the query, you need to call SqlStep(); even if you do not<br/>
    ///  expect result data.<br/>
    ///  oObject: Can be either the module (GetModule()), or a player character.<br/>
    ///           The database is persisted to savegames in case of the module,<br/>
    ///           and to character files in case of a player characters.<br/>
    ///           Other objects cannot carry databases, and this function call<br/>
    ///           will error for them.<br/>
    ///  N.B: Databases on objects (especially player characters!) should be kept<br/>
    ///       to a reasonable size. Delete old data you no longer need.<br/>
    ///       If you attempt to store more than a few megabytes of data on a<br/>
    ///       player creature, you may have a bad time.<br/>
    ///  N.B.: You can pass sqlqueries into DelayCommand; HOWEVER<br/>
    ///        *** they will NOT survive a game save/load ***<br/>
    ///        Any commands on a restored sqlquery will fail.<br/>
    ///  Please check the SQLite_README.txt file in lang/en/docs/ for the list of builtin functions.
    public static System.IntPtr SqlPrepareQueryObject(uint oObject, string sQuery)
    {
      VM.StackPush(sQuery);
      VM.StackPush(oObject);
      VM.Call(924);
      return VM.StackPopStruct(ENGINE_STRUCTURE_SQLQUERY);
    }

    ///  Bind an integer to a named parameter of the given prepared query.<br/>
    ///  Example:<br/>
    ///    sqlquery v = SqlPrepareQueryObject(GetModule(), &amp;quot;insert into test (col) values (@myint);&amp;quot;);<br/>
    ///    SqlBindInt(v, &amp;quot;@myint&amp;quot;, 5);<br/>
    ///    SqlStep(v);
    public static void SqlBindInt(System.IntPtr sqlQuery, string sParam, int nValue)
    {
      VM.StackPush(nValue);
      VM.StackPush(sParam);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(925);
    }

    ///  Bind a float to a named parameter of the given prepared query.
    public static void SqlBindFloat(System.IntPtr sqlQuery, string sParam, float fFloat)
    {
      VM.StackPush(fFloat);
      VM.StackPush(sParam);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(926);
    }

    ///  Bind a string to a named parameter of the given prepared query.
    public static void SqlBindString(System.IntPtr sqlQuery, string sParam, string sString)
    {
      VM.StackPush(sString);
      VM.StackPush(sParam);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(927);
    }

    ///  Bind a vector to a named parameter of the given prepared query.
    public static void SqlBindVector(System.IntPtr sqlQuery, string sParam, System.Numerics.Vector3 vVector)
    {
      VM.StackPush(vVector);
      VM.StackPush(sParam);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(928);
    }

    ///  Bind a object to a named parameter of the given prepared query.<br/>
    ///  Objects are serialized, NOT stored as a reference!<br/>
    ///  Currently supported object types: Creatures, Items, Placeables, Waypoints, Stores, Doors, Triggers, Areas (CAF format)<br/>
    ///  If bSaveObjectState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are saved out<br/>
    ///  (except for Combined Area Format, which always has object state saved out).
    public static void SqlBindObject(System.IntPtr sqlQuery, string sParam, uint oObject, int bSaveObjectState = FALSE)
    {
      VM.StackPush(bSaveObjectState);
      VM.StackPush(oObject);
      VM.StackPush(sParam);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(929);
    }

    ///  Executes the given query and fetches a row; returning true if row data was<br/>
    ///  made available; false otherwise. Note that this will return false even if<br/>
    ///  the query ran successfully but did not return data.<br/>
    ///  You need to call SqlPrepareQuery() and potentially SqlBind* before calling this.<br/>
    ///  Example:<br/>
    ///    sqlquery n = SqlPrepareQueryObject(GetFirstPC(), &amp;quot;select widget from widgets;&amp;quot;);<br/>
    ///    while (SqlStep(n))<br/>
    ///      SendMessageToPC(GetFirstPC(), &amp;quot;Found widget: &amp;quot; + SqlGetString(n, 0));
    public static int SqlStep(System.IntPtr sqlQuery)
    {
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(930);
      return VM.StackPopInt();
    }

    ///  Retrieve a column cast as an integer of the currently stepped row.<br/>
    ///  You can call this after SqlStep() returned TRUE.<br/>
    ///  In case of error, 0 will be returned.<br/>
    ///  In traditional fashion, nIndex starts at 0.
    public static int SqlGetInt(System.IntPtr sqlQuery, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(931);
      return VM.StackPopInt();
    }

    ///  Retrieve a column cast as a float of the currently stepped row.<br/>
    ///  You can call this after SqlStep() returned TRUE.<br/>
    ///  In case of error, 0.0f will be returned.<br/>
    ///  In traditional fashion, nIndex starts at 0.
    public static float SqlGetFloat(System.IntPtr sqlQuery, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(932);
      return VM.StackPopFloat();
    }

    ///  Retrieve a column cast as a string of the currently stepped row.<br/>
    ///  You can call this after SqlStep() returned TRUE.<br/>
    ///  In case of error, a empty string will be returned.<br/>
    ///  In traditional fashion, nIndex starts at 0.
    public static string SqlGetString(System.IntPtr sqlQuery, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(933);
      return VM.StackPopString();
    }

    ///  Retrieve a vector of the currently stepped query.<br/>
    ///  You can call this after SqlStep() returned TRUE.<br/>
    ///  In case of error, a zero vector will be returned.<br/>
    ///  In traditional fashion, nIndex starts at 0.
    public static System.Numerics.Vector3 SqlGetVector(System.IntPtr sqlQuery, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(934);
      return VM.StackPopVector();
    }

    ///  Retrieve a object of the currently stepped query.<br/>
    ///  You can call this after SqlStep() returned TRUE.<br/>
    ///  The object will be spawned into a inventory if it is a item and the receiver<br/>
    ///  has the capability to receive it, otherwise at lSpawnAt.<br/>
    ///  Objects are serialized, NOT stored as a reference!<br/>
    ///  In case of error, INVALID_OBJECT will be returned.<br/>
    ///  In traditional fashion, nIndex starts at 0.<br/>
    ///  If bLoadObjectState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are read in.
    public static uint SqlGetObject(System.IntPtr sqlQuery, int nIndex, System.IntPtr lSpawnAt, uint oInventory = OBJECT_INVALID, int bLoadObjectState = FALSE)
    {
      VM.StackPush(bLoadObjectState);
      VM.StackPush(oInventory);
      VM.StackPush(lSpawnAt, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(nIndex);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(935);
      return VM.StackPopObject();
    }

    ///  Convert sHex, a string containing a hexadecimal object id,<br/>
    ///  into a object reference. Counterpart to ObjectToString().
    public static uint StringToObject(string sHex)
    {
      VM.StackPush(sHex);
      VM.Call(936);
      return VM.StackPopObject();
    }

    ///  Sets the current hitpoints of oObject.<br/>
    ///  * You cannot destroy or revive objects or creatures with this function.<br/>
    ///  * For currently dying PCs, you can only set hitpoints in the range of -9 to 0.<br/>
    ///  * All other objects need to be alive and the range is clamped to 1 and max hitpoints.<br/>
    ///  * This is not considered damage (or healing). It circumvents all combat logic, including damage resistance and reduction.<br/>
    ///  * This is not considered a friendly or hostile combat action. It will not affect factions, nor will it trigger script events.<br/>
    ///  * This will not advise player parties in the combat log.
    public static void SetCurrentHitPoints(uint oObject, int nHitPoints)
    {
      VM.StackPush(nHitPoints);
      VM.StackPush(oObject);
      VM.Call(937);
    }

    ///  Returns the currently executing event (EVENT_SCRIPT_*) or 0 if not determinable.<br/>
    ///  Note: Will return 0 in DelayCommand/AssignCommand.<br/>
    ///  * bInheritParent: If TRUE, ExecuteScript(Chunk) will inherit their event ID from their parent event.<br/>
    ///                    If FALSE, it will return the event ID of the current script, which may be 0.<br/>
    /// <br/>
    ///  Some events can run in the same script context as a previous event (for example: CreatureOnDeath, CreatureOnDamaged)<br/>
    ///  In cases like these calling the function with bInheritParent = TRUE will return the wrong event ID.
    public static int GetCurrentlyRunningEvent(int bInheritParent = TRUE)
    {
      VM.StackPush(bInheritParent);
      VM.Call(938);
      return VM.StackPopInt();
    }

    ///  Get the integer parameter of eEffect at nIndex.<br/>
    ///  * nIndex bounds: 0 &amp;gt;= nIndex &amp;lt; 8.<br/>
    ///  * Some experimentation will be needed to find the right index for the value you wish to determine.<br/>
    ///  Returns: the value or 0 on error/when not set.
    public static int GetEffectInteger(System.IntPtr eEffect, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(939);
      return VM.StackPopInt();
    }

    ///  Get the float parameter of eEffect at nIndex.<br/>
    ///  * nIndex bounds: 0 &amp;gt;= nIndex &amp;lt; 4.<br/>
    ///  * Some experimentation will be needed to find the right index for the value you wish to determine.<br/>
    ///  Returns: the value or 0.0f on error/when not set.
    public static float GetEffectFloat(System.IntPtr eEffect, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(940);
      return VM.StackPopFloat();
    }

    ///  Get the string parameter of eEffect at nIndex.<br/>
    ///  * nIndex bounds: 0 &amp;gt;= nIndex &amp;lt; 6.<br/>
    ///  * Some experimentation will be needed to find the right index for the value you wish to determine.<br/>
    ///  Returns: the value or &amp;quot;&amp;quot; on error/when not set.
    public static string GetEffectString(System.IntPtr eEffect, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(941);
      return VM.StackPopString();
    }

    ///  Get the object parameter of eEffect at nIndex.<br/>
    ///  * nIndex bounds: 0 &amp;gt;= nIndex &amp;lt; 4.<br/>
    ///  * Some experimentation will be needed to find the right index for the value you wish to determine.<br/>
    ///  Returns: the value or OBJECT_INVALID on error/when not set.
    public static uint GetEffectObject(System.IntPtr eEffect, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(942);
      return VM.StackPopObject();
    }

    ///  Get the vector parameter of eEffect at nIndex.<br/>
    ///  * nIndex bounds: 0 &amp;gt;= nIndex &amp;lt; 2.<br/>
    ///  * Some experimentation will be needed to find the right index for the value you wish to determine.<br/>
    ///  Returns: the value or {0.0f, 0.0f, 0.0f} on error/when not set.
    public static System.Numerics.Vector3 GetEffectVector(System.IntPtr eEffect, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(943);
      return VM.StackPopVector();
    }

    ///  Check if nBaseItemType fits in oTarget&amp;apos;s inventory.<br/>
    ///  Note: Does not check inside any container items possessed by oTarget.<br/>
    ///  * nBaseItemType: a BASE_ITEM_* constant.<br/>
    ///  * oTarget: a valid creature, placeable or item.<br/>
    ///  Returns: TRUE if the baseitem type fits, FALSE if not or on error.
    public static int GetBaseItemFitsInInventory(int nBaseItemType, uint oTarget)
    {
      VM.StackPush(oTarget);
      VM.StackPush(nBaseItemType);
      VM.Call(944);
      return VM.StackPopInt();
    }

    ///  Get oObject&amp;apos;s local cassowary variable reference sVarName<br/>
    ///  * Return value on error: empty solver<br/>
    ///  * NB: cassowary types are references, same as objects.<br/>
    ///    Unlike scalars such as int and string, solver references share the same data.<br/>
    ///    Modifications made to one reference are reflected on others.
    public static System.IntPtr GetLocalCassowary(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(945);
      return VM.StackPopStruct(ENGINE_STRUCTURE_CASSOWARY);
    }

    ///  Set a reference to the given solver on oObject.<br/>
    ///  * NB: cassowary types are references, same as objects.<br/>
    ///    Unlike scalars such as int and string, solver references share the same data.<br/>
    ///    Modifications made to one reference are reflected on others.
    public static void SetLocalCassowary(uint oObject, string sVarName, System.IntPtr cSolver)
    {
      VM.StackPush(cSolver, ENGINE_STRUCTURE_CASSOWARY);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(946);
    }

    ///  Delete local solver reference.<br/>
    ///  * NB: cassowary types are references, same as objects.<br/>
    ///    Unlike scalars such as int and string, solver references share the same data.<br/>
    ///    Modifications made to one reference are reflected on others.
    public static void DeleteLocalCassowary(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(947);
    }

    ///  Clear out this solver, removing all state, constraints and suggestions.<br/>
    ///  This is provided as a convenience if you wish to reuse a cassowary variable.<br/>
    ///  It is not necessary to call this for solvers you simply want to let go out of scope.
    public static void CassowaryReset(System.IntPtr cSolver)
    {
      VM.StackPush(cSolver, ENGINE_STRUCTURE_CASSOWARY);
      VM.Call(948);
    }

    ///  Add a constraint to the system.<br/>
    ///  * The constraint needs to be a valid comparison equation, one of: &amp;gt;=, ==, &amp;lt;=.<br/>
    ///  * This implementation is a linear constraint solver.<br/>
    ///  * You cannot multiply or divide variables and expressions with each other.<br/>
    ///    Doing so will result in a error when attempting to add the constraint.<br/>
    ///    (You can, of course, multiply or divide by constants).<br/>
    ///  * fStrength must be &amp;gt;= CASSOWARY_STRENGTH_WEAK &amp;&amp; &amp;lt;= CASSOWARY_STRENGTH_REQUIRED.<br/>
    ///  * Any referenced variables can be retrieved with CassowaryGetValue().<br/>
    ///  * Returns &amp;quot;&amp;quot; on success, or the parser/constraint system error message.
    public static string CassowaryConstrain(System.IntPtr cSolver, string sConstraint, float fStrength = CASSOWARY_STRENGTH_REQUIRED)
    {
      VM.StackPush(fStrength);
      VM.StackPush(sConstraint);
      VM.StackPush(cSolver, ENGINE_STRUCTURE_CASSOWARY);
      VM.Call(949);
      return VM.StackPopString();
    }

    ///  Suggest a value to the solver.<br/>
    ///  * Edit variables are soft constraints and exist as an optimisation for complex systems.<br/>
    ///    You can do the same with Constrain(&amp;quot;v == 5&amp;quot;, CASSOWARY_STRENGTH_xxx); but edit variables<br/>
    ///    allow you to suggest values without having to rebuild the solver.<br/>
    ///  * fStrength must be &amp;gt;= CASSOWARY_STRENGTH_WEAK &amp;&amp; &amp;lt; CASSOWARY_STRENGTH_REQUIRED<br/>
    ///    Suggested values cannot be required, as suggesting a value must not invalidate the solver.
    public static void CassowarySuggestValue(System.IntPtr cSolver, string sVarName, float fValue, float fStrength = CASSOWARY_STRENGTH_STRONG)
    {
      VM.StackPush(fStrength);
      VM.StackPush(fValue);
      VM.StackPush(sVarName);
      VM.StackPush(cSolver, ENGINE_STRUCTURE_CASSOWARY);
      VM.Call(950);
    }

    ///  Get the value for the given variable, or 0.0 on error.
    public static float CassowaryGetValue(System.IntPtr cSolver, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(cSolver, ENGINE_STRUCTURE_CASSOWARY);
      VM.Call(951);
      return VM.StackPopFloat();
    }

    ///  Gets a printable debug state of the given solver, which may help you debug<br/>
    ///  complex systems.
    public static string CassowaryDebug(System.IntPtr cSolver)
    {
      VM.StackPush(cSolver, ENGINE_STRUCTURE_CASSOWARY);
      VM.Call(952);
      return VM.StackPopString();
    }

    ///  Overrides a given strref to always return sValue instead of what is in the TLK file.<br/>
    ///  Setting sValue to &amp;quot;&amp;quot; will delete the override
    public static void SetTlkOverride(int nStrRef, string sValue = "")
    {
      VM.StackPush(sValue);
      VM.StackPush(nStrRef);
      VM.Call(953);
    }

    ///  Constructs a custom itemproperty given all the parameters explicitly.<br/>
    ///  This function can be used in place of all the other ItemPropertyXxx constructors<br/>
    ///  Use GetItemProperty{Type,SubType,CostTableValue,Param1Value} to see the values for a given itemproperty.
    public static System.IntPtr ItemPropertyCustom(int nType, int nSubType = -1, int nCostTableValue = -1, int nParam1Value = -1)
    {
      VM.StackPush(nParam1Value);
      VM.StackPush(nCostTableValue);
      VM.StackPush(nSubType);
      VM.StackPush(nType);
      VM.Call(954);
      return VM.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    ///  Create a RunScript effect.<br/>
    ///  Notes: When applied as instant effect, only sOnAppliedScript will fire.<br/>
    ///         In the scripts, OBJECT_SELF will be the object the effect is applied to.<br/>
    ///  * sOnAppliedScript: An optional script to execute when the effect is applied.<br/>
    ///  * sOnRemovedScript: An optional script to execute when the effect is removed.<br/>
    ///  * sOnIntervalScript: An optional script to execute every fInterval seconds.<br/>
    ///  * fInterval: The interval in seconds, must be &amp;gt;0.0f if an interval script is set.<br/>
    ///               Very low values may have an adverse effect on performance.<br/>
    ///  * sData: An optional string of data saved in the effect, retrievable with GetEffectString() at index 0.
    public static System.IntPtr EffectRunScript(string sOnAppliedScript = "", string sOnRemovedScript = "", string sOnIntervalScript = "", float fInterval = 0.0f, string sData = "")
    {
      VM.StackPush(sData);
      VM.StackPush(fInterval);
      VM.StackPush(sOnIntervalScript);
      VM.StackPush(sOnRemovedScript);
      VM.StackPush(sOnAppliedScript);
      VM.Call(955);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the effect that last triggered an EffectRunScript() script.<br/>
    ///  Note: This can be used to get the creator or tag, among others, of the EffectRunScript() in one of its scripts.<br/>
    ///  * Returns an effect of type EFFECT_TYPE_INVALIDEFFECT when called outside of an EffectRunScript() script.
    public static System.IntPtr GetLastRunScriptEffect()
    {
      VM.Call(956);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Get the script type (RUNSCRIPT_EFFECT_SCRIPT_TYPE_*) of the last triggered EffectRunScript() script.<br/>
    ///  * Returns 0 when called outside of an EffectRunScript() script.
    public static int GetLastRunScriptEffectScriptType()
    {
      VM.Call(957);
      return VM.StackPopInt();
    }

    ///  Hides the effect icon of eEffect and of all effects currently linked to it.
    public static System.IntPtr HideEffectIcon(System.IntPtr eEffect)
    {
      VM.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.Call(958);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Create an Icon effect.<br/>
    ///  * nIconID: The effect icon (EFFECT_ICON_*) to display.<br/>
    ///             Using the icon for Poison/Disease will also color the health bar green/brown, useful to simulate custom poisons/diseases.<br/>
    ///  Returns an effect of type EFFECT_TYPE_INVALIDEFFECT when nIconID is &amp;lt; 1 or &amp;gt; 255.
    public static System.IntPtr EffectIcon(int nIconID)
    {
      VM.StackPush(nIconID);
      VM.Call(959);
      return VM.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    ///  Gets the player that last triggered the module OnPlayerGuiEvent event.
    public static uint GetLastGuiEventPlayer()
    {
      VM.Call(960);
      return VM.StackPopObject();
    }

    ///  Gets the last triggered GUIEVENT_* in the module OnPlayerGuiEvent event.
    public static int GetLastGuiEventType()
    {
      VM.Call(961);
      return VM.StackPopInt();
    }

    ///  Gets an optional integer of specific gui events in the module OnPlayerGuiEvent event.<br/>
    ///  * GUIEVENT_CHATBAR_*: The selected chat channel. Does not indicate the actual used channel.<br/>
    ///                        0 = Shout, 1 = Whisper, 2 = Talk, 3 = Party, 4 = DM<br/>
    ///  * GUIEVENT_CHARACTERSHEET_SKILL_SELECT: The skill ID.<br/>
    ///  * GUIEVENT_CHARACTERSHEET_FEAT_SELECT: The feat ID.<br/>
    ///  * GUIEVENT_EFFECTICON_CLICK: The effect icon ID (EFFECT_ICON_*)<br/>
    ///  * GUIEVENT_DISABLED_PANEL_ATTEMPT_OPEN: The GUI_PANEL_* the player attempted to open.<br/>
    ///  * GUIEVENT_QUICKCHAT_SELECT: The hotkey character representing the option<br/>
    ///  * GUIEVENT_EXAMINE_OBJECT: A GUI_PANEL_EXAMINE_* constant
    public static int GetLastGuiEventInteger()
    {
      VM.Call(962);
      return VM.StackPopInt();
    }

    ///  Gets an optional object of specific gui events in the module OnPlayerGuiEvent event.<br/>
    ///  * GUIEVENT_MINIMAP_MAPPIN_CLICK: The waypoint the map note is attached to.<br/>
    ///  * GUIEVENT_CHARACTERSHEET_*_SELECT: The owner of the character sheet.<br/>
    ///  * GUIEVENT_PLAYERLIST_PLAYER_CLICK: The player clicked on.<br/>
    ///  * GUIEVENT_PARTYBAR_PORTRAIT_CLICK: The creature clicked on.<br/>
    ///  * GUIEVENT_DISABLED_PANEL_ATTEMPT_OPEN: For GUI_PANEL_CHARACTERSHEET, the owner of the character sheet.<br/>
    ///                                          For GUI_PANEL_EXAMINE_*, the object being examined.<br/>
    ///  * GUIEVENT_*SELECT_CREATURE: The creature that was (un)selected<br/>
    ///  * GUIEVENT_EXAMINE_OBJECT: The object being examined.
    public static uint GetLastGuiEventObject()
    {
      VM.Call(963);
      return VM.StackPopObject();
    }

    ///  Disable a gui panel for the client that controls oPlayer.<br/>
    ///  Notes: Will close the gui panel if currently open, except GUI_PANEL_LEVELUP / GUI_PANEL_GOLD_*<br/>
    ///         Does not persist through relogging or in savegames.<br/>
    ///         Will fire a GUIEVENT_DISABLED_PANEL_ATTEMPT_OPEN OnPlayerGuiEvent for some gui panels if a player attempts to open them.<br/>
    ///         You can still force show a panel with PopUpGUIPanel().<br/>
    ///         You can still force examine an object with ActionExamine().<br/>
    ///  * nGuiPanel: A GUI_PANEL_* constant, except GUI_PANEL_PLAYER_DEATH.
    public static void SetGuiPanelDisabled(uint oPlayer, int nGuiPanel, int bDisabled)
    {
      VM.StackPush(bDisabled);
      VM.StackPush(nGuiPanel);
      VM.StackPush(oPlayer);
      VM.Call(964);
    }

    ///  Gets the ID (1..8) of the last tile action performed in OnPlayerTileAction
    public static int GetLastTileActionId()
    {
      VM.Call(965);
      return VM.StackPopInt();
    }

    ///  Gets the target position in the module OnPlayerTileAction event.
    public static System.Numerics.Vector3 GetLastTileActionPosition()
    {
      VM.Call(966);
      return VM.StackPopVector();
    }

    ///  Gets the player object that triggered the OnPlayerTileAction event.
    public static uint GetLastPlayerToDoTileAction()
    {
      VM.Call(967);
      return VM.StackPopObject();
    }

    ///  Parse the given string as a valid json value, and returns the corresponding type.<br/>
    ///  Returns a JSON_TYPE_NULL on error.<br/>
    ///  Check JsonGetError() to see the parse error, if any.<br/>
    ///  NB: The parsed string needs to be in game-local encoding, but the generated json structure<br/>
    ///      will contain UTF-8 data.
    public static System.IntPtr JsonParse(string sJson)
    {
      VM.StackPush(sJson);
      VM.Call(968);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Dump the given json value into a string that can be read back in via JsonParse.<br/>
    ///  nIndent describes the indentation level for pretty-printing; a value of -1 means no indentation and no linebreaks.<br/>
    ///  Returns a string describing JSON_TYPE_NULL on error.<br/>
    ///  NB: The dumped string is in game-local encoding, with all non-ascii characters escaped.
    public static string JsonDump(System.IntPtr jValue, int nIndent = -1)
    {
      VM.StackPush(nIndent);
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(969);
      return VM.StackPopString();
    }

    ///  Describes the type of the given json value.<br/>
    ///  Returns JSON_TYPE_NULL if the value is empty.
    public static int JsonGetType(System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(970);
      return VM.StackPopInt();
    }

    ///  Returns the length of the given json type.<br/>
    ///  For objects, returns the number of top-level keys present.<br/>
    ///  For arrays, returns the number of elements.<br/>
    ///  Null types are of size 0.<br/>
    ///  All other types return 1.
    public static int JsonGetLength(System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(971);
      return VM.StackPopInt();
    }

    ///  Returns the error message if the value has errored out.<br/>
    ///  Currently only describes parse errors.
    public static string JsonGetError(System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(972);
      return VM.StackPopString();
    }

    ///  Create a NULL json value, seeded with a optional error message for JsonGetError().
    public static System.IntPtr JsonNull(string sError = "")
    {
      VM.StackPush(sError);
      VM.Call(973);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Create a empty json object.
    public static System.IntPtr JsonObject()
    {
      VM.Call(974);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Create a empty json array.
    public static System.IntPtr JsonArray()
    {
      VM.Call(975);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Create a json string value.<br/>
    ///  NB: Strings are encoded to UTF-8 from the game-local charset.
    public static System.IntPtr JsonString(string sValue)
    {
      VM.StackPush(sValue);
      VM.Call(976);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Create a json integer value.
    public static System.IntPtr JsonInt(int nValue)
    {
      VM.StackPush(nValue);
      VM.Call(977);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Create a json floating point value.
    public static System.IntPtr JsonFloat(float fValue)
    {
      VM.StackPush(fValue);
      VM.Call(978);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Create a json bool valye.
    public static System.IntPtr JsonBool(int bValue)
    {
      VM.StackPush(bValue);
      VM.Call(979);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a string representation of the json value.<br/>
    ///  Returns &amp;quot;&amp;quot; if the value cannot be represented as a string, or is empty.<br/>
    ///  NB: Strings are decoded from UTF-8 to the game-local charset.
    public static string JsonGetString(System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(980);
      return VM.StackPopString();
    }

    ///  Returns a int representation of the json value, casting where possible.<br/>
    ///  Returns 0 if the value cannot be represented as a float.<br/>
    ///  Use this to parse json bool types.<br/>
    ///  NB: This will narrow down to signed 32 bit, as that is what NWScript int is.<br/>
    ///      If you are trying to read a 64 bit or unsigned integer, you will lose data.<br/>
    ///      You will not lose data if you keep the value as a json element (via Object/ArrayGet).
    public static int JsonGetInt(System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(981);
      return VM.StackPopInt();
    }

    ///  Returns a float representation of the json value, casting where possible.<br/>
    ///  Returns 0.0 if the value cannot be represented as a float.<br/>
    ///  NB: This will narrow doubles down to float.<br/>
    ///      If you are trying to read a double, you will lose data.<br/>
    ///      You will not lose data if you keep the value as a json element (via Object/ArrayGet).
    public static float JsonGetFloat(System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.Call(982);
      return VM.StackPopFloat();
    }

    ///  Returns a json array containing all keys of jObject.<br/>
    ///  Returns a empty array if the object is empty or not a json object, with GetJsonError() filled in.
    public static System.IntPtr JsonObjectKeys(System.IntPtr jObject)
    {
      VM.StackPush(jObject, ENGINE_STRUCTURE_JSON);
      VM.Call(983);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns the key value of sKey on the object jObect.<br/>
    ///  Returns a null json value if jObject is not a object or sKey does not exist on the object, with GetJsonError() filled in.
    public static System.IntPtr JsonObjectGet(System.IntPtr jObject, string sKey)
    {
      VM.StackPush(sKey);
      VM.StackPush(jObject, ENGINE_STRUCTURE_JSON);
      VM.Call(984);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a modified copy of jObject with the key at sKey set to jValue.<br/>
    ///  Returns a json null value if jObject is not a object, with GetJsonError() filled in.
    public static System.IntPtr JsonObjectSet(System.IntPtr jObject, string sKey, System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(sKey);
      VM.StackPush(jObject, ENGINE_STRUCTURE_JSON);
      VM.Call(985);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a modified copy of jObject with the key at sKey deleted.<br/>
    ///  Returns a json null value if jObject is not a object, with GetJsonError() filled in.
    public static System.IntPtr JsonObjectDel(System.IntPtr jObject, string sKey)
    {
      VM.StackPush(sKey);
      VM.StackPush(jObject, ENGINE_STRUCTURE_JSON);
      VM.Call(986);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Gets the json object at jArray index position nIndex.<br/>
    ///  Returns a json null value if the index is out of bounds, with GetJsonError() filled in.
    public static System.IntPtr JsonArrayGet(System.IntPtr jArray, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(jArray, ENGINE_STRUCTURE_JSON);
      VM.Call(987);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a modified copy of jArray with position nIndex set to jValue.<br/>
    ///  Returns a json null value if jArray is not actually an array, with GetJsonError() filled in.<br/>
    ///  Returns a json null value if nIndex is out of bounds, with GetJsonError() filled in.
    public static System.IntPtr JsonArraySet(System.IntPtr jArray, int nIndex, System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(nIndex);
      VM.StackPush(jArray, ENGINE_STRUCTURE_JSON);
      VM.Call(988);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a modified copy of jArray with jValue inserted at position nIndex.<br/>
    ///  All succeeding objects in the array will move by one.<br/>
    ///  By default (-1), inserts objects at the end of the array (&amp;quot;push&amp;quot;).<br/>
    ///  nIndex = 0 inserts at the beginning of the array.<br/>
    ///  Returns a json null value if jArray is not actually an array, with GetJsonError() filled in.<br/>
    ///  Returns a json null value if nIndex is not 0 or -1 and out of bounds, with GetJsonError() filled in.
    public static System.IntPtr JsonArrayInsert(System.IntPtr jArray, System.IntPtr jValue, int nIndex = -1)
    {
      VM.StackPush(nIndex);
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(jArray, ENGINE_STRUCTURE_JSON);
      VM.Call(989);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a modified copy of jArray with the element at position nIndex removed,<br/>
    ///  and the array resized by one.<br/>
    ///  Returns a json null value if jArray is not actually an array, with GetJsonError() filled in.<br/>
    ///  Returns a json null value if nIndex is out of bounds, with GetJsonError() filled in.
    public static System.IntPtr JsonArrayDel(System.IntPtr jArray, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(jArray, ENGINE_STRUCTURE_JSON);
      VM.Call(990);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Transforms the given object into a json structure.<br/>
    ///  The json format is compatible with what https://github.com/niv/neverwinter.nim@1.4.3+ emits.<br/>
    ///  Returns the null json type on errors, or if oObject is not serializable, with GetJsonError() filled in.<br/>
    ///  Supported object types: creature, item, trigger, placeable, door, waypoint, encounter, store, area (combined format)<br/>
    ///  If bSaveObjectState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are saved out<br/>
    ///  (except for Combined Area Format, which always has object state saved out).
    public static System.IntPtr ObjectToJson(uint oObject, int bSaveObjectState = FALSE)
    {
      VM.StackPush(bSaveObjectState);
      VM.StackPush(oObject);
      VM.Call(991);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Deserializes the game object described in jObject.<br/>
    ///  Returns OBJECT_INVALID on errors.<br/>
    ///  Supported object types: creature, item, trigger, placeable, door, waypoint, encounter, store, area (combined format)<br/>
    ///  For areas, locLocation is ignored.<br/>
    ///  If bLoadObjectState is TRUE, local vars, effects, action queue, and transition info (triggers, doors) are read in.
    public static uint JsonToObject(System.IntPtr jObject, System.IntPtr locLocation, uint oOwner = OBJECT_INVALID, int bLoadObjectState = FALSE)
    {
      VM.StackPush(bLoadObjectState);
      VM.StackPush(oOwner);
      VM.StackPush(locLocation, ENGINE_STRUCTURE_LOCATION);
      VM.StackPush(jObject, ENGINE_STRUCTURE_JSON);
      VM.Call(992);
      return VM.StackPopObject();
    }

    ///  Returns the element at the given JSON pointer value.<br/>
    ///  See https://datatracker.ietf.org/doc/html/rfc6901 for details.<br/>
    ///  Returns a json null value on error, with GetJsonError() filled in.
    public static System.IntPtr JsonPointer(System.IntPtr jData, string sPointer)
    {
      VM.StackPush(sPointer);
      VM.StackPush(jData, ENGINE_STRUCTURE_JSON);
      VM.Call(993);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Return a modified copy of jData with jValue inserted at the path described by sPointer.<br/>
    ///  See https://datatracker.ietf.org/doc/html/rfc6901 for details.<br/>
    ///  Returns a json null value on error, with GetJsonError() filled in.<br/>
    ///  jPatch is an array of patch elements, each containing a op, a path, and a value field. Example:<br/>
    ///  [<br/>
    ///    { &amp;quot;op&amp;quot;: &amp;quot;replace&amp;quot;, &amp;quot;path&amp;quot;: &amp;quot;/baz&amp;quot;, &amp;quot;value&amp;quot;: &amp;quot;boo&amp;quot; },<br/>
    ///    { &amp;quot;op&amp;quot;: &amp;quot;add&amp;quot;, &amp;quot;path&amp;quot;: &amp;quot;/hello&amp;quot;, &amp;quot;value&amp;quot;: [&amp;quot;world&amp;quot;] },<br/>
    ///    { &amp;quot;op&amp;quot;: &amp;quot;remove&amp;quot;, &amp;quot;path&amp;quot;: &amp;quot;/foo&amp;quot;}<br/>
    ///  ]<br/>
    ///  Valid operations are: add, remove, replace, move, copy, test
    public static System.IntPtr JsonPatch(System.IntPtr jData, System.IntPtr jPatch)
    {
      VM.StackPush(jPatch, ENGINE_STRUCTURE_JSON);
      VM.StackPush(jData, ENGINE_STRUCTURE_JSON);
      VM.Call(994);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns the diff (described as a json structure you can pass into JsonPatch) between the two objects.<br/>
    ///  Returns a json null value on error, with GetJsonError() filled in.
    public static System.IntPtr JsonDiff(System.IntPtr jLHS, System.IntPtr jRHS)
    {
      VM.StackPush(jRHS, ENGINE_STRUCTURE_JSON);
      VM.StackPush(jLHS, ENGINE_STRUCTURE_JSON);
      VM.Call(995);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns a modified copy of jData with jMerge merged into it. This is an alternative to<br/>
    ///  JsonPatch/JsonDiff, with a syntax more closely resembling the final object.<br/>
    ///  See https://datatracker.ietf.org/doc/html/rfc7386 for details.<br/>
    ///  Returns a json null value on error, with GetJsonError() filled in.
    public static System.IntPtr JsonMerge(System.IntPtr jData, System.IntPtr jMerge)
    {
      VM.StackPush(jMerge, ENGINE_STRUCTURE_JSON);
      VM.StackPush(jData, ENGINE_STRUCTURE_JSON);
      VM.Call(996);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Get oObject&amp;apos;s local json variable sVarName<br/>
    ///  * Return value on error: json null type
    public static System.IntPtr GetLocalJson(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(997);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Set oObject&amp;apos;s local json variable sVarName to jValue
    public static void SetLocalJson(uint oObject, string sVarName, System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(998);
    }

    ///  Delete oObject&amp;apos;s local json variable sVarName
    public static void DeleteLocalJson(uint oObject, string sVarName)
    {
      VM.StackPush(sVarName);
      VM.StackPush(oObject);
      VM.Call(999);
    }

    ///  Bind an json to a named parameter of the given prepared query.<br/>
    ///  Json values are serialised into a string.<br/>
    ///  Example:<br/>
    ///    sqlquery v = SqlPrepareQueryObject(GetModule(), &amp;quot;insert into test (col) values (@myjson);&amp;quot;);<br/>
    ///    SqlBindJson(v, &amp;quot;@myjson&amp;quot;, myJsonObject);<br/>
    ///    SqlStep(v);
    public static void SqlBindJson(System.IntPtr sqlQuery, string sParam, System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(sParam);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(1000);
    }

    ///  Retrieve a column cast as a json value of the currently stepped row.<br/>
    ///  You can call this after SqlStep() returned TRUE.<br/>
    ///  In case of error, a json null value will be returned.<br/>
    ///  In traditional fashion, nIndex starts at 0.
    public static System.IntPtr SqlGetJson(System.IntPtr sqlQuery, int nIndex)
    {
      VM.StackPush(nIndex);
      VM.StackPush(sqlQuery, ENGINE_STRUCTURE_SQLQUERY);
      VM.Call(1001);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  This stores a json out to the specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static void SetCampaignJson(string sCampaignName, string sVarName, System.IntPtr jValue, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(1002);
    }

    ///  This will read a json from the  specified campaign database<br/>
    ///  The database name:<br/>
    ///   - is case insensitive and it must be the same for both set and get functions.<br/>
    ///   - can only contain alphanumeric characters, no spaces.<br/>
    ///  The var name must be unique across the entire database, regardless of the variable type.<br/>
    ///  If you want a variable to pertain to a specific player in the game, provide a player object.
    public static System.IntPtr GetCampaignJson(string sCampaignName, string sVarName, uint oPlayer = OBJECT_INVALID)
    {
      VM.StackPush(oPlayer);
      VM.StackPush(sVarName);
      VM.StackPush(sCampaignName);
      VM.Call(1003);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Gets a device property/capability as advertised by the client.<br/>
    ///  sProperty is one of PLAYER_DEVICE_PROPERTY_xxx.<br/>
    ///  Returns -1 if<br/>
    ///  - the property was never set by the client,<br/>
    ///  - the the actual value is -1,<br/>
    ///  - the player is running a older build that does not advertise device properties,<br/>
    ///  - the player has disabled sending device properties (Options-&amp;gt;Game-&amp;gt;Privacy).
    public static int GetPlayerDeviceProperty(uint oPlayer, string sProperty)
    {
      VM.StackPush(sProperty);
      VM.StackPush(oPlayer);
      VM.Call(1004);
      return VM.StackPopInt();
    }

    ///  Returns the LANGUAGE_xx code of the given player, or -1 if unavailable.
    public static int GetPlayerLanguage(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(1005);
      return VM.StackPopInt();
    }

    ///  Returns one of PLAYER_DEVICE_PLATFORM_xxx, or 0 if unavailable.
    public static int GetPlayerDevicePlatform(uint oPlayer)
    {
      VM.StackPush(oPlayer);
      VM.Call(1006);
      return VM.StackPopInt();
    }

    ///  Deserializes the given resref/template into a JSON structure.<br/>
    ///  Supported GFF resource types:<br/>
    ///  * RESTYPE_CAF (and RESTYPE_ARE, RESTYPE_GIT, RESTYPE_GIC)<br/>
    ///  * RESTYPE_UTC<br/>
    ///  * RESTYPE_UTI<br/>
    ///  * RESTYPE_UTT<br/>
    ///  * RESTYPE_UTP<br/>
    ///  * RESTYPE_UTD<br/>
    ///  * RESTYPE_UTW<br/>
    ///  * RESTYPE_UTE<br/>
    ///  * RESTYPE_UTM<br/>
    ///  Returns a valid gff-type json structure, or a null value with GetJsonError() set.
    public static System.IntPtr TemplateToJson(string sResRef, int nResType)
    {
      VM.StackPush(nResType);
      VM.StackPush(sResRef);
      VM.Call(1007);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Returns the resource location of sResRef.nResType, as seen by the running module.<br/>
    ///  Note for dedicated servers: Checks on the module/server side, not the client.<br/>
    ///  Returns &amp;quot;&amp;quot; if the resource does not exist in the search space.
    public static string ResManGetAliasFor(string sResRef, int nResType)
    {
      VM.StackPush(nResType);
      VM.StackPush(sResRef);
      VM.Call(1008);
      return VM.StackPopString();
    }

    ///  Finds the nNth available resref starting with sPrefix.<br/>
    ///  * Set bSearchBaseData to TRUE to also search base game content stored in your game installation directory.<br/>
    ///    WARNING: This can be very slow.<br/>
    ///  * Set sOnlyKeyTable to a specific keytable to only search the given named keytable (e.g. &amp;quot;OVERRIDE:&amp;quot;).<br/>
    ///  Returns &amp;quot;&amp;quot; if no such resref exists.
    public static string ResManFindPrefix(string sPrefix, int nResType, int nNth = 1, int bSearchBaseData = FALSE, string sOnlyKeyTable = "")
    {
      VM.StackPush(sOnlyKeyTable);
      VM.StackPush(bSearchBaseData);
      VM.StackPush(nNth);
      VM.StackPush(nResType);
      VM.StackPush(sPrefix);
      VM.Call(1009);
      return VM.StackPopString();
    }

    ///  Create a NUI window from the given resref(.jui) for the given player.<br/>
    ///  * The resref needs to be available on the client, not the server.<br/>
    ///  * The token is a integer for ease of handling only. You are not supposed to do anything with it, except store/pass it.<br/>
    ///  * The window ID needs to be alphanumeric and short. Only one window (per client) with the same ID can exist at a time.<br/>
    ///    Re-creating a window with the same id of one already open will immediately close the old one.<br/>
    ///  * See nw_inc_nui.nss for full documentation.<br/>
    ///  Returns the window token on success (&amp;gt;0), or 0 on error.
    public static int NuiCreateFromResRef(uint oPlayer, string sResRef, string sWindowId = "")
    {
      VM.StackPush(sWindowId);
      VM.StackPush(sResRef);
      VM.StackPush(oPlayer);
      VM.Call(1010);
      return VM.StackPopInt();
    }

    ///  Create a NUI window inline for the given player.<br/>
    ///  * The token is a integer for ease of handling only. You are not supposed to do anything with it, except store/pass it.<br/>
    ///  * The window ID needs to be alphanumeric and short. Only one window (per client) with the same ID can exist at a time.<br/>
    ///    Re-creating a window with the same id of one already open will immediately close the old one.<br/>
    ///  * See nw_inc_nui.nss for full documentation.<br/>
    ///  Returns the window token on success (&amp;gt;0), or 0 on error.
    public static int NuiCreate(uint oPlayer, System.IntPtr jNui, string sWindowId = "")
    {
      VM.StackPush(sWindowId);
      VM.StackPush(jNui, ENGINE_STRUCTURE_JSON);
      VM.StackPush(oPlayer);
      VM.Call(1011);
      return VM.StackPopInt();
    }

    ///  You can look up windows by ID, if you gave them one.<br/>
    ///  * Windows with a ID present are singletons - attempting to open a second one with the same ID<br/>
    ///    will fail, even if the json definition is different.<br/>
    ///  Returns the token if found, or 0.
    public static int NuiFindWindow(uint oPlayer, string sId)
    {
      VM.StackPush(sId);
      VM.StackPush(oPlayer);
      VM.Call(1012);
      return VM.StackPopInt();
    }

    ///  Destroys the given window, by token, immediately closing it on the client.<br/>
    ///  Does nothing if nUiToken does not exist on the client.<br/>
    ///  Does not send a close event - this immediately destroys all serverside state.<br/>
    ///  The client will close the window asynchronously.
    public static void NuiDestroy(uint oPlayer, int nUiToken)
    {
      VM.StackPush(nUiToken);
      VM.StackPush(oPlayer);
      VM.Call(1013);
    }

    ///  Returns the originating player of the current event.
    public static uint NuiGetEventPlayer()
    {
      VM.Call(1014);
      return VM.StackPopObject();
    }

    ///  Gets the window token of the current event (or 0 if not in a event).
    public static int NuiGetEventWindow()
    {
      VM.Call(1015);
      return VM.StackPopInt();
    }

    ///  Returns the event type of the current event.<br/>
    ///  * See nw_inc_nui.nss for full documentation of all events.
    public static string NuiGetEventType()
    {
      VM.Call(1016);
      return VM.StackPopString();
    }

    ///  Returns the ID of the widget that triggered the event.
    public static string NuiGetEventElement()
    {
      VM.Call(1017);
      return VM.StackPopString();
    }

    ///  Get the array index of the current event.<br/>
    ///  This can be used to get the index into an array, for example when rendering lists of buttons.<br/>
    ///  Returns -1 if the event is not originating from within an array.
    public static int NuiGetEventArrayIndex()
    {
      VM.Call(1018);
      return VM.StackPopInt();
    }

    ///  Returns the window ID of the window described by nUiToken.<br/>
    ///  Returns &amp;quot;&amp;quot; on error, or if the window has no ID.
    public static string NuiGetWindowId(uint oPlayer, int nUiToken)
    {
      VM.StackPush(nUiToken);
      VM.StackPush(oPlayer);
      VM.Call(1019);
      return VM.StackPopString();
    }

    ///  Gets the json value for the given player, token and bind.<br/>
    ///  * json values can hold all kinds of values; but NUI widgets require specific bind types.<br/>
    ///    It is up to you to either handle this in NWScript, or just set compatible bind types.<br/>
    ///    No auto-conversion happens.<br/>
    ///  Returns a json null value if the bind does not exist.
    public static System.IntPtr NuiGetBind(uint oPlayer, int nUiToken, string sBindName)
    {
      VM.StackPush(sBindName);
      VM.StackPush(nUiToken);
      VM.StackPush(oPlayer);
      VM.Call(1020);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Sets a json value for the given player, token and bind.<br/>
    ///  The value is synced down to the client and can be used in UI binding.<br/>
    ///  When the UI changes the value, it is returned to the server and can be retrieved via NuiGetBind().<br/>
    ///  * json values can hold all kinds of values; but NUI widgets require specific bind types.<br/>
    ///    It is up to you to either handle this in NWScript, or just set compatible bind types.<br/>
    ///    No auto-conversion happens.<br/>
    ///  * If the bind is on the watch list, this will immediately invoke the event handler with the &amp;quot;watch&amp;quot;<br/>
    ///    even type; even before this function returns. Do not update watched binds from within the watch handler<br/>
    ///    unless you enjoy stack overflows.<br/>
    ///  Does nothing if the given player+token is invalid.
    public static void NuiSetBind(uint oPlayer, int nUiToken, string sBindName, System.IntPtr jValue)
    {
      VM.StackPush(jValue, ENGINE_STRUCTURE_JSON);
      VM.StackPush(sBindName);
      VM.StackPush(nUiToken);
      VM.StackPush(oPlayer);
      VM.Call(1021);
    }

    ///  Swaps out the given element (by id) with the given nui layout (partial).<br/>
    ///  * This currently only works with the &amp;quot;group&amp;quot; element type, and the special &amp;quot;_window_&amp;quot; root group.
    public static void NuiSetGroupLayout(uint oPlayer, int nUiToken, string sElement, System.IntPtr jNui)
    {
      VM.StackPush(jNui, ENGINE_STRUCTURE_JSON);
      VM.StackPush(sElement);
      VM.StackPush(nUiToken);
      VM.StackPush(oPlayer);
      VM.Call(1022);
    }

    ///  Mark the given bind name as watched.<br/>
    ///  A watched bind will invoke the NUI script event every time it&amp;apos;s value changes.<br/>
    ///  Be careful with binding nui data inside a watch event handler: It&amp;apos;s easy to accidentally recurse yourself into a stack overflow.
    public static int NuiSetBindWatch(uint oPlayer, int nUiToken, string sBind, int bWatch)
    {
      VM.StackPush(bWatch);
      VM.StackPush(sBind);
      VM.StackPush(nUiToken);
      VM.StackPush(oPlayer);
      VM.Call(1023);
      return VM.StackPopInt();
    }

    ///  Returns the nNth window token of the player, or 0.<br/>
    ///  nNth starts at 0.<br/>
    ///  Iterator is not write-safe: Calling DestroyWindow() will invalidate move following offsets by one.
    public static int NuiGetNthWindow(uint oPlayer, int nNth = 0)
    {
      VM.StackPush(nNth);
      VM.StackPush(oPlayer);
      VM.Call(1024);
      return VM.StackPopInt();
    }

    ///  Return the nNth bind name of the given window, or &amp;quot;&amp;quot;.<br/>
    ///  If bWatched is TRUE, iterates only watched binds.<br/>
    ///  If FALSE, iterates all known binds on the window (either set locally or in UI).
    public static string NuiGetNthBind(uint oPlayer, int nToken, int bWatched, int nNth = 0)
    {
      VM.StackPush(nNth);
      VM.StackPush(bWatched);
      VM.StackPush(nToken);
      VM.StackPush(oPlayer);
      VM.Call(1025);
      return VM.StackPopString();
    }

    ///  Returns the event payload, specific to the event.<br/>
    ///  Returns JsonNull if event has no payload.
    public static System.IntPtr NuiGetEventPayload()
    {
      VM.Call(1026);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Get the userdata of the given window token.<br/>
    ///  Returns JsonNull if the window does not exist on the given player, or has no userdata set.
    public static System.IntPtr NuiGetUserData(uint oPlayer, int nToken)
    {
      VM.StackPush(nToken);
      VM.StackPush(oPlayer);
      VM.Call(1027);
      return VM.StackPopStruct(ENGINE_STRUCTURE_JSON);
    }

    ///  Sets an arbitrary json value as userdata on the given window token.<br/>
    ///  This userdata is not read or handled by the game engine and not sent to clients.<br/>
    ///  This mechanism only exists as a convenience for the programmer to store data bound to a windows&amp;apos; lifecycle.<br/>
    ///  Will do nothing if the window does not exist.
    public static void NuiSetUserData(uint oPlayer, int nToken, System.IntPtr jUserData)
    {
      VM.StackPush(jUserData, ENGINE_STRUCTURE_JSON);
      VM.StackPush(nToken);
      VM.StackPush(oPlayer);
      VM.Call(1028);
    }

  }
}
