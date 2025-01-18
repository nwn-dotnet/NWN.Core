using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_ItemProperty)]
  public class ItempropPlugin
  {
    /// @addtogroup itemproperty ItemProperty
    /// Utility functions to manipulate the builtin itemproperty type.
    /// @{
    /// @file nwnx_itemprop.nss
    public const string NWNX_ItemProperty = "NWNX_ItemProperty";

    ///&lt; @private
    /// An unpacked itemproperty.
    /// Convert native itemproperty type to unpacked structure.
    /// <param name="ip">The itemproperty to convert.</param>
    /// <returns>A constructed NWNX_IPUnpacked.</returns>
    public static NWNX_IPUnpacked UnpackIP(System.IntPtr ip)
    {
      NWNXPushItemProperty(ip);
      NWNXCall(NWNX_ItemProperty, "UnpackIP");
      NWNX_IPUnpacked n = default;
      n.sID = NWNXPopString();
      n.nProperty = NWNXPopInt();
      n.nSubType = NWNXPopInt();
      n.nCostTable = NWNXPopInt();
      n.nCostTableValue = NWNXPopInt();
      n.nParam1 = NWNXPopInt();
      n.nParam1Value = NWNXPopInt();
      n.nUsesPerDay = NWNXPopInt();
      n.nChanceToAppear = NWNXPopInt();
      n.bUsable = NWNXPopInt();
      n.nSpellId = NWNXPopInt();
      n.oCreator = NWNXPopObject();
      n.sTag = NWNXPopString();
      return n;
    }

    /// Convert unpacked itemproperty structure to native type.
    /// <param name="ip">The NWNX_IPUnpacked structure to convert.</param>
    /// <returns>The itemproperty.</returns>
    public static System.IntPtr PackIP(NWNX_IPUnpacked n)
    {
      NWNXPushString(n.sTag);
      NWNXPushObject(n.oCreator);
      NWNXPushInt(n.nSpellId);
      NWNXPushInt(n.bUsable);
      NWNXPushInt(n.nChanceToAppear);
      NWNXPushInt(n.nUsesPerDay);
      NWNXPushInt(n.nParam1Value);
      NWNXPushInt(n.nParam1);
      NWNXPushInt(n.nCostTableValue);
      NWNXPushInt(n.nCostTable);
      NWNXPushInt(n.nSubType);
      NWNXPushInt(n.nProperty);
      NWNXCall(NWNX_ItemProperty, "PackIP");
      return NWNXPopItemProperty();
    }

    /// Gets the active item property at the index
    /// <param name="oItem">- the item with the property</param>
    /// <param name="nIndex">- the index such as returned by some Item Events</param>
    /// <returns>A constructed NWNX_IPUnpacked, except for creator, and spell id.</returns>
    public static NWNX_IPUnpacked GetActiveProperty(uint oItem, int nIndex)
    {
      NWNXPushInt(nIndex);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_ItemProperty, "GetActiveProperty");
      NWNX_IPUnpacked n = default;
      n.nProperty = NWNXPopInt();
      n.nSubType = NWNXPopInt();
      n.nCostTable = NWNXPopInt();
      n.nCostTableValue = NWNXPopInt();
      n.nParam1 = NWNXPopInt();
      n.nParam1Value = NWNXPopInt();
      n.nUsesPerDay = NWNXPopInt();
      n.nChanceToAppear = NWNXPopInt();
      n.bUsable = NWNXPopInt();
      n.sTag = NWNXPopString();
      return n;
    }

    // @}
  }

  public struct NWNX_IPUnpacked
  {
    public string sID;
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
