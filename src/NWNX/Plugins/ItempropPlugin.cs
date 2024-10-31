using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_ItemProperty)]
  public class ItempropPlugin
  {
    public const string NWNX_ItemProperty = "NWNX_ItemProperty";

    ///&lt; @private
    /// An unpacked itemproperty.
    /// Convert native itemproperty type to unpacked structure.
    /// <param name="ip">The itemproperty to convert.</param>
    /// <returns>A constructed NWNX_IPUnpacked.</returns>
    public static NWNX_IPUnpacked UnpackIP(System.IntPtr ip)
    {
      const string sFunc = "UnpackIP";
      VM.NWNX.SetFunction(NWNX_ItemProperty, sFunc);
      VM.NWNX.StackPush(ENGINE_STRUCTURE_ITEMPROPERTY, ip);
      VM.NWNX.Call();
      NWNX_IPUnpacked n = default;
      n.sID = VM.NWNX.StackPopString();
      n.nProperty = VM.NWNX.StackPopInt();
      n.nSubType = VM.NWNX.StackPopInt();
      n.nCostTable = VM.NWNX.StackPopInt();
      n.nCostTableValue = VM.NWNX.StackPopInt();
      n.nParam1 = VM.NWNX.StackPopInt();
      n.nParam1Value = VM.NWNX.StackPopInt();
      n.nUsesPerDay = VM.NWNX.StackPopInt();
      n.nChanceToAppear = VM.NWNX.StackPopInt();
      n.bUsable = VM.NWNX.StackPopInt();
      n.nSpellId = VM.NWNX.StackPopInt();
      n.oCreator = VM.NWNX.StackPopObject();
      n.sTag = VM.NWNX.StackPopString();
      return n;
    }

    /// Convert unpacked itemproperty structure to native type.
    /// <param name="ip">The NWNX_IPUnpacked structure to convert.</param>
    /// <returns>The itemproperty.</returns>
    public static System.IntPtr PackIP(NWNX_IPUnpacked n)
    {
      const string sFunc = "PackIP";
      VM.NWNX.SetFunction(NWNX_ItemProperty, sFunc);
      VM.NWNX.StackPush(n.sTag);
      VM.NWNX.StackPush(n.oCreator);
      VM.NWNX.StackPush(n.nSpellId);
      VM.NWNX.StackPush(n.bUsable);
      VM.NWNX.StackPush(n.nChanceToAppear);
      VM.NWNX.StackPush(n.nUsesPerDay);
      VM.NWNX.StackPush(n.nParam1Value);
      VM.NWNX.StackPush(n.nParam1);
      VM.NWNX.StackPush(n.nCostTableValue);
      VM.NWNX.StackPush(n.nCostTable);
      VM.NWNX.StackPush(n.nSubType);
      VM.NWNX.StackPush(n.nProperty);
      VM.NWNX.Call();
      return VM.NWNX.StackPopStruct(ENGINE_STRUCTURE_ITEMPROPERTY);
    }

    /// Gets the active item property at the index
    /// <param name="oItem">- the item with the property</param>
    /// <param name="nIndex">- the index such as returned by some Item Events</param>
    /// <returns>A constructed NWNX_IPUnpacked, except for creator, and spell id.</returns>
    public static NWNX_IPUnpacked GetActiveProperty(uint oItem, int nIndex)
    {
      const string sFunc = "GetActiveProperty";
      VM.NWNX.SetFunction(NWNX_ItemProperty, sFunc);
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      NWNX_IPUnpacked n = default;
      n.nProperty = VM.NWNX.StackPopInt();
      n.nSubType = VM.NWNX.StackPopInt();
      n.nCostTable = VM.NWNX.StackPopInt();
      n.nCostTableValue = VM.NWNX.StackPopInt();
      n.nParam1 = VM.NWNX.StackPopInt();
      n.nParam1Value = VM.NWNX.StackPopInt();
      n.nUsesPerDay = VM.NWNX.StackPopInt();
      n.nChanceToAppear = VM.NWNX.StackPopInt();
      n.bUsable = VM.NWNX.StackPopInt();
      n.sTag = VM.NWNX.StackPopString();
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
