namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Effect)]
  public class EffectPlugin
  {
    public const string NWNX_Effect = "NWNX_Effect";

    // /< @private
    // / An unpacked effect
    // / @brief Convert native effect type to unpacked structure.
    // / @param e The effect to convert.
    // / @return A constructed NWNX_EffectUnpacked.
    public static EffectUnpacked UnpackEffect(System.IntPtr e)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Effect, "UnpackEffect");
      Internal.NativeFunctions.nwnxPushEffect(e);
      Internal.NativeFunctions.nwnxCallFunction();
      EffectUnpacked retVal;
      retVal.sTag = Internal.NativeFunctions.nwnxPopString();
      retVal.oParam3 = Internal.NativeFunctions.nwnxPopObject();
      retVal.oParam2 = Internal.NativeFunctions.nwnxPopObject();
      retVal.oParam1 = Internal.NativeFunctions.nwnxPopObject();
      retVal.oParam0 = Internal.NativeFunctions.nwnxPopObject();
      retVal.sParam5 = Internal.NativeFunctions.nwnxPopString();
      retVal.sParam4 = Internal.NativeFunctions.nwnxPopString();
      retVal.sParam3 = Internal.NativeFunctions.nwnxPopString();
      retVal.sParam2 = Internal.NativeFunctions.nwnxPopString();
      retVal.sParam1 = Internal.NativeFunctions.nwnxPopString();
      retVal.sParam0 = Internal.NativeFunctions.nwnxPopString();
      retVal.fParam3 = Internal.NativeFunctions.nwnxPopFloat();
      retVal.fParam2 = Internal.NativeFunctions.nwnxPopFloat();
      retVal.fParam1 = Internal.NativeFunctions.nwnxPopFloat();
      retVal.fParam0 = Internal.NativeFunctions.nwnxPopFloat();
      retVal.nParam7 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam6 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam5 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam4 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam3 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam2 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam1 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nParam0 = Internal.NativeFunctions.nwnxPopInt();
      retVal.nNumIntegers = Internal.NativeFunctions.nwnxPopInt();
      retVal.bLinkRightValid = Internal.NativeFunctions.nwnxPopInt();
      retVal.eLinkRight = Internal.NativeFunctions.nwnxPopEffect();
      retVal.bLinkLeftValid = Internal.NativeFunctions.nwnxPopInt();
      retVal.eLinkLeft = Internal.NativeFunctions.nwnxPopEffect();
      retVal.nCasterLevel = Internal.NativeFunctions.nwnxPopInt();
      retVal.bShowIcon = Internal.NativeFunctions.nwnxPopInt();
      retVal.bExpose = Internal.NativeFunctions.nwnxPopInt();
      retVal.nSpellId = Internal.NativeFunctions.nwnxPopInt();
      retVal.oCreator = Internal.NativeFunctions.nwnxPopObject();
      retVal.nExpiryTimeOfDay = Internal.NativeFunctions.nwnxPopInt();
      retVal.nExpiryCalendarDay = Internal.NativeFunctions.nwnxPopInt();
      retVal.fDuration = Internal.NativeFunctions.nwnxPopFloat();
      retVal.nSubType = Internal.NativeFunctions.nwnxPopInt();
      retVal.nType = Internal.NativeFunctions.nwnxPopInt();
      return retVal;
    }

    // / @brief Convert unpacked effect structure to native type.
    // / @param e The NWNX_EffectUnpacked structure to convert.
    // / @return The effect.
    public static System.IntPtr PackEffect(EffectUnpacked e)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Effect, "PackEffect");
      Internal.NativeFunctions.nwnxPushInt(e.nType);
      Internal.NativeFunctions.nwnxPushInt(e.nSubType);
      Internal.NativeFunctions.nwnxPushFloat(e.fDuration);
      Internal.NativeFunctions.nwnxPushInt(e.nExpiryCalendarDay);
      Internal.NativeFunctions.nwnxPushInt(e.nExpiryTimeOfDay);
      Internal.NativeFunctions.nwnxPushObject(e.oCreator);
      Internal.NativeFunctions.nwnxPushInt(e.nSpellId);
      Internal.NativeFunctions.nwnxPushInt(e.bExpose);
      Internal.NativeFunctions.nwnxPushInt(e.bShowIcon);
      Internal.NativeFunctions.nwnxPushInt(e.nCasterLevel);
      Internal.NativeFunctions.nwnxPushEffect(e.eLinkLeft);
      Internal.NativeFunctions.nwnxPushInt(e.bLinkLeftValid);
      Internal.NativeFunctions.nwnxPushEffect(e.eLinkRight);
      Internal.NativeFunctions.nwnxPushInt(e.bLinkRightValid);
      Internal.NativeFunctions.nwnxPushInt(e.nNumIntegers);
      Internal.NativeFunctions.nwnxPushInt(e.nParam0);
      Internal.NativeFunctions.nwnxPushInt(e.nParam1);
      Internal.NativeFunctions.nwnxPushInt(e.nParam2);
      Internal.NativeFunctions.nwnxPushInt(e.nParam3);
      Internal.NativeFunctions.nwnxPushInt(e.nParam4);
      Internal.NativeFunctions.nwnxPushInt(e.nParam5);
      Internal.NativeFunctions.nwnxPushInt(e.nParam6);
      Internal.NativeFunctions.nwnxPushInt(e.nParam7);
      Internal.NativeFunctions.nwnxPushFloat(e.fParam0);
      Internal.NativeFunctions.nwnxPushFloat(e.fParam1);
      Internal.NativeFunctions.nwnxPushFloat(e.fParam2);
      Internal.NativeFunctions.nwnxPushFloat(e.fParam3);
      Internal.NativeFunctions.nwnxPushString(e.sParam0);
      Internal.NativeFunctions.nwnxPushString(e.sParam1);
      Internal.NativeFunctions.nwnxPushString(e.sParam2);
      Internal.NativeFunctions.nwnxPushString(e.sParam3);
      Internal.NativeFunctions.nwnxPushString(e.sParam4);
      Internal.NativeFunctions.nwnxPushString(e.sParam5);
      Internal.NativeFunctions.nwnxPushObject(e.oParam0);
      Internal.NativeFunctions.nwnxPushObject(e.oParam1);
      Internal.NativeFunctions.nwnxPushObject(e.oParam2);
      Internal.NativeFunctions.nwnxPushObject(e.oParam3);
      Internal.NativeFunctions.nwnxPushString(e.sTag);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopEffect();
    }

    // / @brief Set a script with optional data that runs when an effect expires
    // / @param e The effect.
    // / @param script The script to run when the effect expires.
    // / @param data Any other data you wish to send back to the script.
    // / @remark OBJECT_SELF in the script is the object the effect is applied to.
    // / @note Only works for TEMPORARY and PERMANENT effects applied to an object.
    public static System.IntPtr SetEffectExpiredScript(System.IntPtr e, string script, string data = "")
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Effect, "SetEffectExpiredScript");
      Internal.NativeFunctions.nwnxPushString(data);
      Internal.NativeFunctions.nwnxPushString(script);
      Internal.NativeFunctions.nwnxPushEffect(e);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopEffect();
    }

    // / @brief Get the data set with NWNX_Effect_SetEffectExpiredScript()
    // / @note Should only be called from a script set with NWNX_Effect_SetEffectExpiredScript().
    // / @return The data attached to the effect.
    public static string GetEffectExpiredData()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Effect, "GetEffectExpiredData");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Get the effect creator.
    // / @note Should only be called from a script set with NWNX_Effect_SetEffectExpiredScript().
    // / @return The object from which the effect originated.
    public static uint GetEffectExpiredCreator()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Effect, "GetEffectExpiredCreator");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopObject();
    }

    // / @}
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
    public string sTag;
  }
}