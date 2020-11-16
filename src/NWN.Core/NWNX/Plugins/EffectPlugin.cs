using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Effect)]
  public class EffectPlugin
  {
    public const string NWNX_Effect = "NWNX_Effect";

    ///< @private
    /// An unpacked effect
    /// Convert native effect type to unpacked structure.
    /// <param name="e">The effect to convert.</param>
    /// <returns>A constructed NWNX_EffectUnpacked.</returns>
    public static EffectUnpacked UnpackEffect(System.IntPtr e)
    {
      VM.NWNX.SetFunction(NWNX_Effect, "UnpackEffect");
      VM.NWNX.StackPush(e, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
      EffectUnpacked n = default;
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
      n.bLinkRightValid = VM.NWNX.StackPopInt();
      n.eLinkRight = VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
      n.bLinkLeftValid = VM.NWNX.StackPopInt();
      n.eLinkLeft = VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
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
      return n;
    }

    /// Convert unpacked effect structure to native type.
    /// <param name="e">The NWNX_EffectUnpacked structure to convert.</param>
    /// <returns>The effect.</returns>
    public static System.IntPtr PackEffect(EffectUnpacked e)
    {
      VM.NWNX.SetFunction(NWNX_Effect, "PackEffect");
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
      VM.NWNX.StackPush(e.eLinkLeft, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.StackPush(e.bLinkLeftValid);
      VM.NWNX.StackPush(e.eLinkRight, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.StackPush(e.bLinkRightValid);
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
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    /// Set a script with optional data that runs when an effect expires
    /// <param name="e">The effect.</param>
    /// <param name="script">The script to run when the effect expires.</param>
    /// <param name="data">Any other data you wish to send back to the script.</param>
    /// @remark OBJECT_SELF in the script is the object the effect is applied to.
    /// @note Only works for TEMPORARY and PERMANENT effects applied to an object.
    public static System.IntPtr SetEffectExpiredScript(System.IntPtr e, string script, string data = "")
    {
      VM.NWNX.SetFunction(NWNX_Effect, "SetEffectExpiredScript");
      VM.NWNX.StackPush(data);
      VM.NWNX.StackPush(script);
      VM.NWNX.StackPush(e, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_EFFECT);
    }

    /// Get the data set with NWNX_Effect_SetEffectExpiredScript()
    /// @note Should only be called from a script set with NWNX_Effect_SetEffectExpiredScript().
    /// <returns>The data attached to the effect.</returns>
    public static string GetEffectExpiredData()
    {
      VM.NWNX.SetFunction(NWNX_Effect, "GetEffectExpiredData");
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get the effect creator.
    /// @note Should only be called from a script set with NWNX_Effect_SetEffectExpiredScript().
    /// <returns>The object from which the effect originated.</returns>
    public static uint GetEffectExpiredCreator()
    {
      VM.NWNX.SetFunction(NWNX_Effect, "GetEffectExpiredCreator");
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// replace an already applied effect on an object
    /// Only duration, subtype, tag and spell related fields can be overwritten.
    /// @note eNew and eOld need to have the same type.
    /// <returns>Number of internal effects updated.</returns>
    public static int ReplaceEffect(uint obj, System.IntPtr eOld, System.IntPtr eNew)
    {
      VM.NWNX.SetFunction(NWNX_Effect, "ReplaceEffect");
      VM.NWNX.StackPush(eNew, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.StackPush(eOld, ENGINE_STRUCTURE_EFFECT);
      VM.NWNX.StackPush(obj);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// @}
  }

  public struct EffectUnpacked
  {
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
  }
}
