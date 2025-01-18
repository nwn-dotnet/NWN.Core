using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Race)]
  public class RacePlugin
  {
    /// @addtogroup race Race
    /// Define racial and subrace characteristics.
    /// @{
    /// @file nwnx_race.nss
    public const string NWNX_Race = "NWNX_Race";

    ///&lt; @private
    /// @name Racial Modifiers
    /// @anchor racial_modifiers
    ///
    /// @{
    public const int NWNX_RACE_MODIFIER_INVALID = 0;
    public const int NWNX_RACE_MODIFIER_AB = 1;
    public const int NWNX_RACE_MODIFIER_ABVSRACE = 2;
    public const int NWNX_RACE_MODIFIER_AC = 3;
    public const int NWNX_RACE_MODIFIER_ACVSRACE = 4;
    public const int NWNX_RACE_MODIFIER_CONCEALMENT = 5;
    public const int NWNX_RACE_MODIFIER_DMGIMMUNITY = 6;
    public const int NWNX_RACE_MODIFIER_DMGREDUCTION = 7;
    public const int NWNX_RACE_MODIFIER_DMGRESIST = 8;
    public const int NWNX_RACE_MODIFIER_FEAT = 9;
    public const int NWNX_RACE_MODIFIER_FEATUSAGE = 10;
    public const int NWNX_RACE_MODIFIER_IMMUNITY = 11;
    public const int NWNX_RACE_MODIFIER_INITIATIVE = 12;
    public const int NWNX_RACE_MODIFIER_MOVEMENTSPEED = 13;
    public const int NWNX_RACE_MODIFIER_RACE = 14;
    public const int NWNX_RACE_MODIFIER_REGENERATION = 15;
    public const int NWNX_RACE_MODIFIER_SAVE = 16;
    public const int NWNX_RACE_MODIFIER_SAVEVSRACE = 17;
    public const int NWNX_RACE_MODIFIER_SAVEVSTYPE = 18;
    public const int NWNX_RACE_MODIFIER_SKILL = 19;
    public const int NWNX_RACE_MODIFIER_SPELLIMMUNITY = 20;
    public const int NWNX_RACE_MODIFIER_SRCHARGEN = 21;
    public const int NWNX_RACE_MODIFIER_SRINCLEVEL = 22;

    ///@}
    /// Sets a racial modifier.
    /// <param name="iRace">The RACIALTYPE_ constant or value in racialtypes.2da.</param>
    /// <param name="iMod">The @ref racial_modifiers &quot;racial modifier&quot; to set.</param>
    /// <param name="iParam1,">iParam2, iParam3 The parameters for this racial modifier.</param>
    public static void SetRacialModifier(int iRace, int iMod, int iParam1, int iParam2 = -559038737, int iParam3 = -559038737)
    {
      NWNXPushInt(iParam3);
      NWNXPushInt(iParam2);
      NWNXPushInt(iParam1);
      NWNXPushInt(iMod);
      NWNXPushInt(iRace);
      NWNXCall(NWNX_Race, "SetRacialModifier");
    }

    /// Gets the parent race for a race.
    /// <param name="iRace">The race to check for a parent.</param>
    /// <returns>The parent race if applicable, if not it just returns the race passed in.</returns>
    public static int GetParentRace(int iRace)
    {
      NWNXPushInt(iRace);
      NWNXCall(NWNX_Race, "GetParentRace");
      return NWNXPopInt();
    }

    /// Associates the race with its favored enemy feat.
    /// <param name="iRace">The race</param>
    /// <param name="iFeat">The feat</param>
    /// @note If a creature has a race that has a parent race then favored enemy bonuses will work for either race against that creature.
    /// For example a creature is a Wild Elf which has a parent race of Elf, an attacker would benefit if they had either Favored Enemy: Elf
    /// or Favored Enemy: Wild Elf
    public static void SetFavoredEnemyFeat(int iRace, int iFeat)
    {
      NWNXPushInt(iFeat);
      NWNXPushInt(iRace);
      NWNXCall(NWNX_Race, "SetFavoredEnemyFeat");
    }

    /// Removes any nwnx_race &apos;Effects&apos; on the targeted creature. Suppression lasts until levelup, next login, or Reactivated by function.
    /// <param name="oCreature">The creature to suppress</param>
    /// @note Not all nwnx_race modifiers are achieved via effect. Those that are not directly consider the creatures current race.
    public static void SuppressCreatureRaceEffects(uint creature)
    {
      NWNXPushObject(creature);
      NWNXCall(NWNX_Race, "SuppressCreatureRaceEffects");
    }

    /// Reactivates the nwnx_race &apos;Effects&apos; on the targeted creature after they were Suppressed.
    /// <param name="oCreature">The creature to reactive</param>
    /// @note Safe to use on non-suppressed creatures - Triggers a refresh of effects but won&apos;t stack.
    public static void ReactivateCreatureRaceEffects(uint oCreature)
    {
      NWNXPushObject(oCreature);
      NWNXCall(NWNX_Race, "ReactivateCreatureRaceEffects");
    }

    // @}
  }
}
