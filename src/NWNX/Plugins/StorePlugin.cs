using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Store)]
  public class StorePlugin
  {
    public const string NWNX_Store = "NWNX_Store";

    ///&lt; @private
    /// Return status of a base item purchase status.
    /// <param name="oStore">The store object.</param>
    /// <param name="nBaseItem">A BASE_ITEM_* value</param>
    /// <returns>TRUE if the quest has been completed. -1 if the player does not have the journal entry.</returns>
    public static int GetIsRestrictedBuyItem(uint oStore, int nBaseItem)
    {
      const string sFunc = "GetIsRestrictedBuyItem";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(nBaseItem);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Return the blackmarket mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <returns>mark down of a store, -1 on error</returns>
    public static int GetBlackMarketMarkDown(uint oStore)
    {
      const string sFunc = "GetBlackMarketMarkDown";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the blackmarket mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <param name="nValue">The amount.</param>
    public static void SetBlackMarketMarkDown(uint oStore, int nValue)
    {
      const string sFunc = "SetBlackMarketMarkDown";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(nValue);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
    }

    /// Return the mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <returns>mark down of a store, -1 on error</returns>
    public static int GetMarkDown(uint oStore)
    {
      const string sFunc = "GetMarkDown";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <param name="nValue">The amount.</param>
    public static void SetMarkDown(uint oStore, int nValue)
    {
      const string sFunc = "SetMarkDown";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(nValue);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
    }

    /// Return the mark up of a store
    /// <param name="oStore">The store object.</param>
    /// <returns>mark up of a store, -1 on error</returns>
    public static int GetMarkUp(uint oStore)
    {
      const string sFunc = "GetMarkUp";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set the mark up of a store
    /// <param name="oStore">The store object.</param>
    /// <param name="nValue">The amount.</param>
    public static void SetMarkUp(uint oStore, int nValue)
    {
      const string sFunc = "SetMarkUp";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(nValue);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
    }

    /// Return current customer count
    /// <param name="oStore">The store object.</param>
    /// <returns>count, or -1 on error</returns>
    public static int GetCurrentCustomersCount(uint oStore)
    {
      const string sFunc = "GetCurrentCustomersCount";
      VM.NWNX.SetFunction(NWNX_Store, sFunc);
      VM.NWNX.StackPush(oStore);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    // @}
  }
}
