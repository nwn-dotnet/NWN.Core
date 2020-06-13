namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_ItemProperty)]
    public class ItempropPlugin
    {
        public const string NWNX_ItemProperty = "NWNX_ItemProperty";

        // /< @private
        // / @brief An unpacked itemproperty.
        // / @brief Convert native itemproperty type to unpacked structure.
        // / @param ip The itemproperty to convert.
        // / @return A constructed NWNX_IPUnpacked.
        public static IPUnpacked UnpackIP(System.IntPtr ip)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_ItemProperty, "UnpackIP");
            Internal.NativeFunctions.nwnxPushItemProperty(ip);
            Internal.NativeFunctions.nwnxCallFunction();
            IPUnpacked retVal;
            retVal.sTag = Internal.NativeFunctions.nwnxPopString();
            retVal.oCreator = Internal.NativeFunctions.nwnxPopObject();
            retVal.nSpellId = Internal.NativeFunctions.nwnxPopInt();
            retVal.bUsable = Internal.NativeFunctions.nwnxPopInt();
            retVal.nChanceToAppear = Internal.NativeFunctions.nwnxPopInt();
            retVal.nUsesPerDay = Internal.NativeFunctions.nwnxPopInt();
            retVal.nParam1Value = Internal.NativeFunctions.nwnxPopInt();
            retVal.nParam1 = Internal.NativeFunctions.nwnxPopInt();
            retVal.nCostTableValue = Internal.NativeFunctions.nwnxPopInt();
            retVal.nCostTable = Internal.NativeFunctions.nwnxPopInt();
            retVal.nSubType = Internal.NativeFunctions.nwnxPopInt();
            retVal.nProperty = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Convert unpacked itemproperty structure to native type.
        // / @param ip The NWNX_IPUnpacked structure to convert.
        // / @return The itemproperty.
        public static System.IntPtr PackIP(IPUnpacked ip)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_ItemProperty, "PackIP");
            Internal.NativeFunctions.nwnxPushInt(ip.nProperty);
            Internal.NativeFunctions.nwnxPushInt(ip.nSubType);
            Internal.NativeFunctions.nwnxPushInt(ip.nCostTable);
            Internal.NativeFunctions.nwnxPushInt(ip.nCostTableValue);
            Internal.NativeFunctions.nwnxPushInt(ip.nParam1);
            Internal.NativeFunctions.nwnxPushInt(ip.nParam1Value);
            Internal.NativeFunctions.nwnxPushInt(ip.nUsesPerDay);
            Internal.NativeFunctions.nwnxPushInt(ip.nChanceToAppear);
            Internal.NativeFunctions.nwnxPushInt(ip.bUsable);
            Internal.NativeFunctions.nwnxPushInt(ip.nSpellId);
            Internal.NativeFunctions.nwnxPushObject(ip.oCreator);
            Internal.NativeFunctions.nwnxPushString(ip.sTag);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopItemProperty();
        }

        // / @}
    }

        public struct IPUnpacked
        {
            public int nProperty;
            public int nSubType;
            public int nCostTable;
            public int nCostTableValue;
            public int nParam1;
            public int nParam1Value;
            public int nUsesPerDay;
            public int nChanceToAppear;
            public int bUsable;
            public int nSpellId;
            public uint oCreator;
            public string sTag;
        }
}
