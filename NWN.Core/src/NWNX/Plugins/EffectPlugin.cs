using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Effect)]
  public class EffectPlugin
  {
    /// @addtogroup effect Effect
    /// Utility functions to manipulate the builtin effect type.
    /// @{
    /// @file nwnx_effect.nss
    public const string NWNX_Effect = "NWNX_Effect";

    ///&lt; @private
    /// EQUIPPED effects are always associated with a slotted item:
    /// Setting this duration type requires the effect creator
    /// to be set to the (already equipped) item that should remove
    /// this effect when unequipped.
    /// Removal behaviour for effects where the creator is NOT a equipped
    /// item is undefined.
    /// They are not removed by resting, cannot be dispelled, etc.
    public const int DURATION_TYPE_EQUIPPED = 3;

    /// These are feat/racial effects used internally by the game to
    /// implement things like movement speed changes and darkvision.
    /// They cannot be removed by resting, dispelling, etc.
    public const int DURATION_TYPE_INNATE = 4;

    /// An unpacked effect
    /// Convert native effect type to unpacked structure.
    /// <param name="e">The effect to convert.</param>
    /// <returns>A constructed NWNX_EffectUnpacked.</returns>
    public static NWNX_EffectUnpacked UnpackEffect(System.IntPtr e)
    {
      NWNXPushEffect(e);
      NWNXCall(NWNX_Effect, "UnpackEffect");
      return __NWNX_Effect_ResolveUnpack( );
    }

    /// Convert unpacked effect structure to native type.
    /// <param name="e">The NWNX_EffectUnpacked structure to convert.</param>
    /// <returns>The effect.</returns>
    public static System.IntPtr PackEffect(NWNX_EffectUnpacked e)
    {
      __NWNX_Effect_ResolvePack(e);
      NWNXCall(NWNX_Effect, "PackEffect");
      return NWNXPopEffect();
    }

    /// replace an already applied effect on an object
    /// Only duration, subtype, tag and spell related fields can be overwritten.
    /// @note eNew and eOld need to have the same type.
    /// <returns>Number of internal effects updated.</returns>
    public static int ReplaceEffect(uint obj, System.IntPtr eOld, System.IntPtr eNew)
    {
      NWNXPushEffect(eNew);
      NWNXPushEffect(eOld);
      NWNXPushObject(obj);
      NWNXCall(NWNX_Effect, "ReplaceEffect");
      return NWNXPopInt();
    }

    /// Gets the true effect count
    /// <param name="oObject">The object to get the count of.</param>
    /// <returns>the number of effects (item properties and other non-exposed effects included)</returns>
    public static int GetTrueEffectCount(uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Effect, "GetTrueEffectCount");
      return NWNXPopInt();
    }

    /// Gets a specific effect on an object. This can grab effects normally hidden from developers, such as item properties.
    /// <param name="oObject">The object with the effect</param>
    /// <param name="nIndex">The point in the array to retrieve (0 to GetTrueEffectCount())</param>
    /// <returns>A constructed NWNX_EffectUnpacked.</returns>
    public static NWNX_EffectUnpacked GetTrueEffect(uint oObject, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Effect, "GetTrueEffect");
      return __NWNX_Effect_ResolveUnpack( FALSE);
    }

    /// Replaces an already applied effect with another.
    /// <param name="oObject">The object with the effect to replace</param>
    /// <param name="nIndex">The array element to be replaced</param>
    /// <param name="e">The unpacked effect to replace it with.</param>
    /// @note Cannot replace an effect with a different type or ID.
    public static void ReplaceEffectByIndex(uint oObject, int nIndex, NWNX_EffectUnpacked e)
    {
      __NWNX_Effect_ResolvePack(e, TRUE);
      NWNXPushInt(nIndex);
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Effect, "ReplaceEffectByIndex");
    }

    /// Removes effect by ID
    /// <param name="oObject">The object to remove the effect from</param>
    /// <param name="sID">The id of the effect, can be retrieved by unpacking effects.</param>
    /// <returns>FALSE/0 on failure TRUE/1 on success.</returns>
    public static int RemoveEffectById(uint oObject, string sID)
    {
      NWNXPushString(sID);
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Effect, "RemoveEffectById");
      return NWNXPopInt();
    }

    /// Applies an effect, bypassing any processing done by ApplyEffectToObject
    /// <param name="eEffect">The effect to be applied.</param>
    /// <param name="oObject">The object to apply it to.</param>
    public static void Apply(System.IntPtr eEffect, uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXPushEffect(eEffect);
      NWNXCall(NWNX_Effect, "Apply");
    }

    /// Sets an effect creator.
    /// <param name="eEffect">The effect to be modified.</param>
    /// <param name="oObject">The effect creator.</param>
    /// <returns>The effect with creator field set.</returns>
    public static System.IntPtr SetEffectCreator(System.IntPtr eEffect, uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXPushEffect(eEffect);
      NWNXCall(NWNX_Effect, "SetEffectCreator");
      return NWNXPopEffect();
    }

    /// Checks if the given effect is valid. Unlike the game builtin, this call considers internal types too.
    /// <param name="eEffect">The effect to check</param>
    /// <returns>TRUE if the effect is valid (including internal types).</returns>
    public static int GetIsEffectValid(System.IntPtr eEffect)
    {
      NWNXPushEffect(eEffect);
      NWNXCall(NWNX_Effect, "GetIsEffectValid");
      return NWNXPopInt();
    }

    /// Returns the number of applied effects on the given object.
    /// <param name="oObject">The object to get the applied effect count for.</param>
    /// <returns>The number of applied effects, including internal.</returns>
    public static int GetAppliedEffectCount(uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Effect, "GetAppliedEffectCount");
      return NWNXPopInt();
    }

    /// Returns the nNth applied effect on a object.
    /// <param name="oObject">The object to get the applied effect copy for.</param>
    /// <param name="nNth">The effect index to get.</param>
    /// @note Make sure to check with NWNX_Effect_GetIsEffectValid, as this iterator also includes internal effects.
    /// <returns>A copy of the applied game effect, or a invalid effect.</returns>
    public static System.IntPtr GetAppliedEffect(uint oObject, int nNth)
    {
      NWNXPushInt(nNth);
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Effect, "GetAppliedEffect");
      return NWNXPopEffect();
    }

    // @}
    public static NWNX_EffectUnpacked __NWNX_Effect_ResolveUnpack(int bLink = TRUE)
    {
      NWNX_EffectUnpacked n = default;
      n.sItemProp = NWNXPopString();
      n.sTag = NWNXPopString();
      n.vParam1 = NWNXPopVector();
      n.vParam0 = NWNXPopVector();
      n.oParam3 = NWNXPopObject();
      n.oParam2 = NWNXPopObject();
      n.oParam1 = NWNXPopObject();
      n.oParam0 = NWNXPopObject();
      n.sParam5 = NWNXPopString();
      n.sParam4 = NWNXPopString();
      n.sParam3 = NWNXPopString();
      n.sParam2 = NWNXPopString();
      n.sParam1 = NWNXPopString();
      n.sParam0 = NWNXPopString();
      n.fParam3 = NWNXPopFloat();
      n.fParam2 = NWNXPopFloat();
      n.fParam1 = NWNXPopFloat();
      n.fParam0 = NWNXPopFloat();
      n.nParam7 = NWNXPopInt();
      n.nParam6 = NWNXPopInt();
      n.nParam5 = NWNXPopInt();
      n.nParam4 = NWNXPopInt();
      n.nParam3 = NWNXPopInt();
      n.nParam2 = NWNXPopInt();
      n.nParam1 = NWNXPopInt();
      n.nParam0 = NWNXPopInt();
      n.nNumIntegers = NWNXPopInt();
      if (bLink == TRUE)
      {
        n.bLinkRightValid = NWNXPopInt();
        n.eLinkRight = NWNXPopEffect();
        n.bLinkLeftValid = NWNXPopInt();
        n.eLinkLeft = NWNXPopEffect();
      }
      else
      {
        n.bLinkRightValid = FALSE;
        n.bLinkLeftValid = FALSE;
      }
      n.nCasterLevel = NWNXPopInt();
      n.bShowIcon = NWNXPopInt();
      n.bExpose = NWNXPopInt();
      n.nSpellId = NWNXPopInt();
      n.oCreator = NWNXPopObject();
      n.nExpiryTimeOfDay = NWNXPopInt();
      n.nExpiryCalendarDay = NWNXPopInt();
      n.fDuration = NWNXPopFloat();
      n.nSubType = NWNXPopInt();
      n.nType = NWNXPopInt();
      n.sID = NWNXPopString();
      return n;
    }

    public static void __NWNX_Effect_ResolvePack(NWNX_EffectUnpacked e, int bReplace = FALSE)
    {
      if (bReplace == FALSE)
      NWNXPushInt(e.nType);
      NWNXPushInt(e.nSubType);
      NWNXPushFloat(e.fDuration);
      NWNXPushInt(e.nExpiryCalendarDay);
      NWNXPushInt(e.nExpiryTimeOfDay);
      NWNXPushObject(e.oCreator);
      NWNXPushInt(e.nSpellId);
      NWNXPushInt(e.bExpose);
      NWNXPushInt(e.bShowIcon);
      NWNXPushInt(e.nCasterLevel);
      if (bReplace == FALSE)
      {
        NWNXPushEffect(e.eLinkLeft);
        NWNXPushInt(e.bLinkLeftValid);
        NWNXPushEffect(e.eLinkRight);
        NWNXPushInt(e.bLinkRightValid);
      }
      NWNXPushInt(e.nNumIntegers);
      NWNXPushInt(e.nParam0);
      NWNXPushInt(e.nParam1);
      NWNXPushInt(e.nParam2);
      NWNXPushInt(e.nParam3);
      NWNXPushInt(e.nParam4);
      NWNXPushInt(e.nParam5);
      NWNXPushInt(e.nParam6);
      NWNXPushInt(e.nParam7);
      NWNXPushFloat(e.fParam0);
      NWNXPushFloat(e.fParam1);
      NWNXPushFloat(e.fParam2);
      NWNXPushFloat(e.fParam3);
      NWNXPushString(e.sParam0);
      NWNXPushString(e.sParam1);
      NWNXPushString(e.sParam2);
      NWNXPushString(e.sParam3);
      NWNXPushString(e.sParam4);
      NWNXPushString(e.sParam5);
      NWNXPushObject(e.oParam0);
      NWNXPushObject(e.oParam1);
      NWNXPushObject(e.oParam2);
      NWNXPushObject(e.oParam3);
      NWNXPushVector(e.vParam0);
      NWNXPushVector(e.vParam1);
      NWNXPushString(e.sTag);
      NWNXPushString(e.sItemProp);
    }

  }

  public struct NWNX_EffectUnpacked
  {
    public string sID;
    public int nType;
    public int nSubType;
    public float fDuration;
    public int nExpiryCalendarDay;
    public int nExpiryTimeOfDay;
    public uint oCreator;
    public int nSpellId;
    public int bExpose;
    public int bShowIcon;
    public int nCasterLevel;
    public System.IntPtr eLinkLeft;
    public int bLinkLeftValid;
    public System.IntPtr eLinkRight;
    public int bLinkRightValid;
    public int nNumIntegers;
    public int nParam0;
    public int nParam1;
    public int nParam2;
    public int nParam3;
    public int nParam4;
    public int nParam5;
    public int nParam6;
    public int nParam7;
    public float fParam0;
    public float fParam1;
    public float fParam2;
    public float fParam3;
    public string sParam0;
    public string sParam1;
    public string sParam2;
    public string sParam3;
    public string sParam4;
    public string sParam5;
    public uint oParam0;
    public uint oParam1;
    public uint oParam2;
    public uint oParam3;
    public System.Numerics.Vector3 vParam0;
    public System.Numerics.Vector3 vParam1;
    public string sTag;
    public string sItemProp;
  }
}
