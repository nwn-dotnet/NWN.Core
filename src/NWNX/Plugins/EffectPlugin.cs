using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Effect)]
  public class EffectPlugin
  {
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
      const string sFunc = "UnpackEffect";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(e, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
      return __NWNX_Effect_ResolveUnpack( sFunc);
    }

    /// Convert unpacked effect structure to native type.
    /// <param name="e">The NWNX_EffectUnpacked structure to convert.</param>
    /// <returns>The effect.</returns>
    public static System.IntPtr PackEffect(NWNX_EffectUnpacked e)
    {
      const string sFunc = "PackEffect";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      __NWNX_Effect_ResolvePack(sFunc, e);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    /// replace an already applied effect on an object
    /// Only duration, subtype, tag and spell related fields can be overwritten.
    /// @note eNew and eOld need to have the same type.
    /// <returns>Number of internal effects updated.</returns>
    public static int ReplaceEffect(uint obj, System.IntPtr eOld, System.IntPtr eNew)
    {
      const string sFunc = "ReplaceEffect";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(eNew, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.StackPush(eOld, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.StackPush(obj);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the true effect count
    /// <param name="oObject">The object to get the count of.</param>
    /// <returns>the number of effects (item properties and other non-exposed effects included)</returns>
    public static int GetTrueEffectCount(uint oObject)
    {
      const string sFunc = "GetTrueEffectCount";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets a specific effect on an object. This can grab effects normally hidden from developers, such as item properties.
    /// <param name="oObject">The object with the effect</param>
    /// <param name="nIndex">The point in the array to retrieve (0 to GetTrueEffectCount())</param>
    /// <returns>A constructed NWNX_EffectUnpacked.</returns>
    public static NWNX_EffectUnpacked GetTrueEffect(uint oObject, int nIndex)
    {
      const string sFunc = "GetTrueEffect";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
      return __NWNX_Effect_ResolveUnpack( sFunc, FALSE);
    }

    /// Replaces an already applied effect with another.
    /// <param name="oObject">The object with the effect to replace</param>
    /// <param name="nIndex">The array element to be replaced</param>
    /// <param name="e">The unpacked effect to replace it with.</param>
    /// @note Cannot replace an effect with a different type or ID.
    public static void ReplaceEffectByIndex(uint oObject, int nIndex, NWNX_EffectUnpacked e)
    {
      const string sFunc = "ReplaceEffectByIndex";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      __NWNX_Effect_ResolvePack(sFunc, e, TRUE);
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
    }

    /// Removes effect by ID
    /// <param name="oObject">The object to remove the effect from</param>
    /// <param name="sID">The id of the effect, can be retrieved by unpacking effects.</param>
    /// <returns>FALSE/0 on failure TRUE/1 on success.</returns>
    public static int RemoveEffectById(uint oObject, string sID)
    {
      const string sFunc = "RemoveEffectById";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(sID);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Applys an effect, bypassing any processing done by ApplyEffectToObject
    /// <param name="eEffect">The effect to be applied.</param>
    /// <param name="oObject">The object to apply it to.</param>
    public static void Apply(System.IntPtr eEffect, uint oObject)
    {
      const string sFunc = "Apply";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
    }

    /// Sets an effect creator.
    /// <param name="eEffect">The effect to be modified.</param>
    /// <param name="oObject">The effect creator.</param>
    /// <returns>The effect with creator field set.</returns>
    public static System.IntPtr SetEffectCreator(System.IntPtr eEffect, uint oObject)
    {
      const string sFunc = "SetEffectCreator";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    /// Checks if the given effect is valid. Unlike the game builtin, this call considers internal types too.
    /// <param name="eEffect">The effect to check</param>
    /// <returns>TRUE if the effect is valid (including internal types).</returns>
    public static int GetIsEffectValid(System.IntPtr eEffect)
    {
      const string sFunc = "GetIsEffectValid";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(eEffect, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the number of applied effects on the given object.
    /// <param name="oObject">The object to get the applied effect count for.</param>
    /// <returns>The number of applied effects, including internal.</returns>
    public static int GetAppliedEffectCount(uint oObject)
    {
      const string sFunc = "GetAppliedEffectCount";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Returns the nNth applied effect on a object.
    /// <param name="oObject">The object to get the applied effect copy for.</param>
    /// <param name="nNth">The effect index to get.</param>
    /// @note Make sure to check with NWNX_Effect_GetIsEffectValid, as this iterator also includes internal effects.
    /// <returns>A copy of the applied game effect, or a invalid effect.</returns>
    public static System.IntPtr GetAppliedEffect(uint oObject, int nNth)
    {
      const string sFunc = "GetAppliedEffect";
      VM.NWNX.SetFunction(NWNX_Effect, sFunc);
      VM.NWNX.StackPush(nNth);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    // @}
    public static NWNX_EffectUnpacked __NWNX_Effect_ResolveUnpack(string sFunc, int bLink = TRUE)
    {
      NWNX_EffectUnpacked n = default;
      n.sItemProp = VM.NWNX.StackPopString();
      n.sTag = VM.NWNX.StackPopString();
      float fZ = VM.NWNX.StackPopFloat();
      float fY = VM.NWNX.StackPopFloat();
      float fX = VM.NWNX.StackPopFloat();
      n.vParam1 = new System.Numerics.Vector3(fX, fY, fZ);
      fZ = VM.NWNX.StackPopFloat();
      fY = VM.NWNX.StackPopFloat();
      fX = VM.NWNX.StackPopFloat();
      n.vParam0 = new System.Numerics.Vector3(fX, fY, fZ);
      n.oParam3 = VM.NWNX.StackPopObject();
      n.oParam2 = VM.NWNX.StackPopObject();
      n.oParam1 = VM.NWNX.StackPopObject();
      n.oParam0 = VM.NWNX.StackPopObject();
      n.sParam5 = VM.NWNX.StackPopString();
      n.sParam4 = VM.NWNX.StackPopString();
      n.sParam3 = VM.NWNX.StackPopString();
      n.sParam2 = VM.NWNX.StackPopString();
      n.sParam1 = VM.NWNX.StackPopString();
      n.sParam0 = VM.NWNX.StackPopString();
      n.fParam3 = VM.NWNX.StackPopFloat();
      n.fParam2 = VM.NWNX.StackPopFloat();
      n.fParam1 = VM.NWNX.StackPopFloat();
      n.fParam0 = VM.NWNX.StackPopFloat();
      n.nParam7 = VM.NWNX.StackPopInt();
      n.nParam6 = VM.NWNX.StackPopInt();
      n.nParam5 = VM.NWNX.StackPopInt();
      n.nParam4 = VM.NWNX.StackPopInt();
      n.nParam3 = VM.NWNX.StackPopInt();
      n.nParam2 = VM.NWNX.StackPopInt();
      n.nParam1 = VM.NWNX.StackPopInt();
      n.nParam0 = VM.NWNX.StackPopInt();
      n.nNumIntegers = VM.NWNX.StackPopInt();
      if (bLink == TRUE)
      {
        n.bLinkRightValid = VM.NWNX.StackPopInt();
        n.eLinkRight = VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
        n.bLinkLeftValid = VM.NWNX.StackPopInt();
        n.eLinkLeft = VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
      }
      else
      {
        n.bLinkRightValid = FALSE;
        n.bLinkLeftValid = FALSE;
      }
      n.nCasterLevel = VM.NWNX.StackPopInt();
      n.bShowIcon = VM.NWNX.StackPopInt();
      n.bExpose = VM.NWNX.StackPopInt();
      n.nSpellId = VM.NWNX.StackPopInt();
      n.oCreator = VM.NWNX.StackPopObject();
      n.nExpiryTimeOfDay = VM.NWNX.StackPopInt();
      n.nExpiryCalendarDay = VM.NWNX.StackPopInt();
      n.fDuration = VM.NWNX.StackPopFloat();
      n.nSubType = VM.NWNX.StackPopInt();
      n.nType = VM.NWNX.StackPopInt();
      n.sID = VM.NWNX.StackPopString();
      return n;
    }

    public static void __NWNX_Effect_ResolvePack(string sFunc, NWNX_EffectUnpacked e, int bReplace = FALSE)
    {
      if (bReplace == FALSE)
      VM.NWNX.StackPush(e.nType);
      VM.NWNX.StackPush(e.nSubType);
      VM.NWNX.StackPush(e.fDuration);
      VM.NWNX.StackPush(e.nExpiryCalendarDay);
      VM.NWNX.StackPush(e.nExpiryTimeOfDay);
      VM.NWNX.StackPush(e.oCreator);
      VM.NWNX.StackPush(e.nSpellId);
      VM.NWNX.StackPush(e.bExpose);
      VM.NWNX.StackPush(e.bShowIcon);
      VM.NWNX.StackPush(e.nCasterLevel);
      if (bReplace == FALSE)
      {
        VM.NWNX.StackPush(e.eLinkLeft, ENGINE_STRUCTURE_EFFECT);
        VM.NWNX.StackPush(e.bLinkLeftValid);
        VM.NWNX.StackPush(e.eLinkRight, ENGINE_STRUCTURE_EFFECT);
        VM.NWNX.StackPush(e.bLinkRightValid);
      }
      VM.NWNX.StackPush(e.nNumIntegers);
      VM.NWNX.StackPush(e.nParam0);
      VM.NWNX.StackPush(e.nParam1);
      VM.NWNX.StackPush(e.nParam2);
      VM.NWNX.StackPush(e.nParam3);
      VM.NWNX.StackPush(e.nParam4);
      VM.NWNX.StackPush(e.nParam5);
      VM.NWNX.StackPush(e.nParam6);
      VM.NWNX.StackPush(e.nParam7);
      VM.NWNX.StackPush(e.fParam0);
      VM.NWNX.StackPush(e.fParam1);
      VM.NWNX.StackPush(e.fParam2);
      VM.NWNX.StackPush(e.fParam3);
      VM.NWNX.StackPush(e.sParam0);
      VM.NWNX.StackPush(e.sParam1);
      VM.NWNX.StackPush(e.sParam2);
      VM.NWNX.StackPush(e.sParam3);
      VM.NWNX.StackPush(e.sParam4);
      VM.NWNX.StackPush(e.sParam5);
      VM.NWNX.StackPush(e.oParam0);
      VM.NWNX.StackPush(e.oParam1);
      VM.NWNX.StackPush(e.oParam2);
      VM.NWNX.StackPush(e.oParam3);
      VM.NWNX.StackPush(e.vParam0.X);
      VM.NWNX.StackPush(e.vParam0.Y);
      VM.NWNX.StackPush(e.vParam0.Z);
      VM.NWNX.StackPush(e.vParam1.X);
      VM.NWNX.StackPush(e.vParam1.Y);
      VM.NWNX.StackPush(e.vParam1.Z);
      VM.NWNX.StackPush(e.sTag);
      VM.NWNX.StackPush(e.sItemProp);
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
