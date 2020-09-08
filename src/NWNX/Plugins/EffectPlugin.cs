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
            VM.NWNX.StackPush(e, NWScript.ENGINE_STRUCTURE_EFFECT);
            VM.NWNX.Call();
            EffectUnpacked retVal;
            retVal.sTag = VM.NWNX.StackPopString();
            retVal.vParam1 = VM.NWNX.StackPopVector();
            retVal.vParam0 = VM.NWNX.StackPopVector();
            retVal.oParam3 = VM.NWNX.StackPopObject();
            retVal.oParam2 = VM.NWNX.StackPopObject();
            retVal.oParam1 = VM.NWNX.StackPopObject();
            retVal.oParam0 = VM.NWNX.StackPopObject();
            retVal.sParam5 = VM.NWNX.StackPopString();
            retVal.sParam4 = VM.NWNX.StackPopString();
            retVal.sParam3 = VM.NWNX.StackPopString();
            retVal.sParam2 = VM.NWNX.StackPopString();
            retVal.sParam1 = VM.NWNX.StackPopString();
            retVal.sParam0 = VM.NWNX.StackPopString();
            retVal.fParam3 = VM.NWNX.StackPopFloat();
            retVal.fParam2 = VM.NWNX.StackPopFloat();
            retVal.fParam1 = VM.NWNX.StackPopFloat();
            retVal.fParam0 = VM.NWNX.StackPopFloat();
            retVal.nParam7 = VM.NWNX.StackPopInt();
            retVal.nParam6 = VM.NWNX.StackPopInt();
            retVal.nParam5 = VM.NWNX.StackPopInt();
            retVal.nParam4 = VM.NWNX.StackPopInt();
            retVal.nParam3 = VM.NWNX.StackPopInt();
            retVal.nParam2 = VM.NWNX.StackPopInt();
            retVal.nParam1 = VM.NWNX.StackPopInt();
            retVal.nParam0 = VM.NWNX.StackPopInt();
            retVal.nNumIntegers = VM.NWNX.StackPopInt();
            retVal.bLinkRightValid = VM.NWNX.StackPopInt();
            retVal.eLinkRight = VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_EFFECT);
            retVal.bLinkLeftValid = VM.NWNX.StackPopInt();
            retVal.eLinkLeft = VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_EFFECT);
            retVal.nCasterLevel = VM.NWNX.StackPopInt();
            retVal.bShowIcon = VM.NWNX.StackPopInt();
            retVal.bExpose = VM.NWNX.StackPopInt();
            retVal.nSpellId = VM.NWNX.StackPopInt();
            retVal.oCreator = VM.NWNX.StackPopObject();
            retVal.nExpiryTimeOfDay = VM.NWNX.StackPopInt();
            retVal.nExpiryCalendarDay = VM.NWNX.StackPopInt();
            retVal.fDuration = VM.NWNX.StackPopFloat();
            retVal.nSubType = VM.NWNX.StackPopInt();
            retVal.nType = VM.NWNX.StackPopInt();
            return retVal;
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
            VM.NWNX.StackPush(e.eLinkLeft, NWScript.ENGINE_STRUCTURE_EFFECT);
            VM.NWNX.StackPush(e.bLinkLeftValid);
            VM.NWNX.StackPush(e.eLinkRight, NWScript.ENGINE_STRUCTURE_EFFECT);
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
            VM.NWNX.StackPush(e.vParam0);
            VM.NWNX.StackPush(e.vParam1);
            VM.NWNX.StackPush(e.sTag);
            VM.NWNX.Call();
            return VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_EFFECT);
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
            VM.NWNX.StackPush(e, NWScript.ENGINE_STRUCTURE_EFFECT);
            VM.NWNX.Call();
            return VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_EFFECT);
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
            VM.NWNX.StackPush(eNew, NWScript.ENGINE_STRUCTURE_EFFECT);
            VM.NWNX.StackPush(eOld, NWScript.ENGINE_STRUCTURE_EFFECT);
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