namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_ItemProperty)]
    public class ItempropPlugin
    {
        public const string NWNX_ItemProperty = "NWNX_ItemProperty";

        ///< @private
        /// An unpacked itemproperty.
        /// Convert native itemproperty type to unpacked structure.
        /// <param name="ip">The itemproperty to convert.</param>
        /// <returns>A constructed NWNX_IPUnpacked.</returns>
        public static IPUnpacked UnpackIP(System.IntPtr ip)
        {
            VM.NWNX.SetFunction(NWNX_ItemProperty, "UnpackIP");
            VM.NWNX.StackPush(ip, NWScript.ENGINE_STRUCTURE_ITEM_PROPERTY);
            VM.NWNX.Call();
            IPUnpacked retVal;
            retVal.sTag = VM.NWNX.StackPopString();
            retVal.oCreator = VM.NWNX.StackPopObject();
            retVal.nSpellId = VM.NWNX.StackPopInt();
            retVal.bUsable = VM.NWNX.StackPopInt();
            retVal.nChanceToAppear = VM.NWNX.StackPopInt();
            retVal.nUsesPerDay = VM.NWNX.StackPopInt();
            retVal.nParam1Value = VM.NWNX.StackPopInt();
            retVal.nParam1 = VM.NWNX.StackPopInt();
            retVal.nCostTableValue = VM.NWNX.StackPopInt();
            retVal.nCostTable = VM.NWNX.StackPopInt();
            retVal.nSubType = VM.NWNX.StackPopInt();
            retVal.nProperty = VM.NWNX.StackPopInt();
            return retVal;
        }

        /// Convert unpacked itemproperty structure to native type.
        /// <param name="ip">The NWNX_IPUnpacked structure to convert.</param>
        /// <returns>The itemproperty.</returns>
        public static System.IntPtr PackIP(IPUnpacked ip)
        {
            VM.NWNX.SetFunction(NWNX_ItemProperty, "PackIP");
            VM.NWNX.StackPush(ip.nProperty);
            VM.NWNX.StackPush(ip.nSubType);
            VM.NWNX.StackPush(ip.nCostTable);
            VM.NWNX.StackPush(ip.nCostTableValue);
            VM.NWNX.StackPush(ip.nParam1);
            VM.NWNX.StackPush(ip.nParam1Value);
            VM.NWNX.StackPush(ip.nUsesPerDay);
            VM.NWNX.StackPush(ip.nChanceToAppear);
            VM.NWNX.StackPush(ip.bUsable);
            VM.NWNX.StackPush(ip.nSpellId);
            VM.NWNX.StackPush(ip.oCreator);
            VM.NWNX.StackPush(ip.sTag);
            VM.NWNX.Call();
            return VM.NWNX.StackPopStruct(NWScript.ENGINE_STRUCTURE_ITEM_PROPERTY);
        }

        /// Gets the active item property at the index
        /// <param name="oItem">- the item with the property</param>
        /// <param name="nIndex">- the index such as returned by some Item Events</param>
        /// <returns>A constructed NWNX_IPUnpacked, except for creator, and spell id.</returns>
        public static IPUnpacked GetActiveProperty(uint oItem, int nIndex)
        {
            VM.NWNX.SetFunction(NWNX_ItemProperty, "GetActiveProperty");
            VM.NWNX.StackPush(nIndex);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
            IPUnpacked retVal;
            retVal.sTag = VM.NWNX.StackPopString();
            retVal.oCreator = VM.NWNX.StackPopObject();
            retVal.nSpellId = VM.NWNX.StackPopInt();
            retVal.bUsable = VM.NWNX.StackPopInt();
            retVal.nChanceToAppear = VM.NWNX.StackPopInt();
            retVal.nUsesPerDay = VM.NWNX.StackPopInt();
            retVal.nParam1Value = VM.NWNX.StackPopInt();
            retVal.nParam1 = VM.NWNX.StackPopInt();
            retVal.nCostTableValue = VM.NWNX.StackPopInt();
            retVal.nCostTable = VM.NWNX.StackPopInt();
            retVal.nSubType = VM.NWNX.StackPopInt();
            retVal.nProperty = VM.NWNX.StackPopInt();
            return retVal;
        }

        /// @}
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