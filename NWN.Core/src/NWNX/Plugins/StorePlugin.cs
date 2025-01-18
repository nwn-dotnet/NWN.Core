using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Store)]
  public class StorePlugin
  {
    /// @addtogroup store
    /// Functions exposing additional store properties.
    /// @{
    /// @file nwnx_store.nss
    public const string NWNX_Store = "NWNX_Store";

    ///&lt; @private
    /// Return status of a base item purchase status.
    /// <param name="oStore">The store object.</param>
    /// <param name="nBaseItem">A BASE_ITEM_* value</param>
    /// <returns>TRUE if the quest has been completed. -1 if the player does not have the journal entry.</returns>
    public static int GetIsRestrictedBuyItem(uint oStore, int nBaseItem)
    {
      NWNXPushInt(nBaseItem);
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "GetIsRestrictedBuyItem");
      return NWNXPopInt();
    }

    /// Return the blackmarket mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <returns>mark down of a store, -1 on error</returns>
    public static int GetBlackMarketMarkDown(uint oStore)
    {
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "GetBlackMarketMarkDown");
      return NWNXPopInt();
    }

    /// Set the blackmarket mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <param name="nValue">The amount.</param>
    public static void SetBlackMarketMarkDown(uint oStore, int nValue)
    {
      NWNXPushInt(nValue);
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "SetBlackMarketMarkDown");
    }

    /// Return the mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <returns>mark down of a store, -1 on error</returns>
    public static int GetMarkDown(uint oStore)
    {
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "GetMarkDown");
      return NWNXPopInt();
    }

    /// Set the mark down of a store
    /// <param name="oStore">The store object.</param>
    /// <param name="nValue">The amount.</param>
    public static void SetMarkDown(uint oStore, int nValue)
    {
      NWNXPushInt(nValue);
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "SetMarkDown");
    }

    /// Return the mark up of a store
    /// <param name="oStore">The store object.</param>
    /// <returns>mark up of a store, -1 on error</returns>
    public static int GetMarkUp(uint oStore)
    {
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "GetMarkUp");
      return NWNXPopInt();
    }

    /// Set the mark up of a store
    /// <param name="oStore">The store object.</param>
    /// <param name="nValue">The amount.</param>
    public static void SetMarkUp(uint oStore, int nValue)
    {
      NWNXPushInt(nValue);
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "SetMarkUp");
    }

    /// Return current customer count
    /// <param name="oStore">The store object.</param>
    /// <returns>count, or -1 on error</returns>
    public static int GetCurrentCustomersCount(uint oStore)
    {
      NWNXPushObject(oStore);
      NWNXCall(NWNX_Store, "GetCurrentCustomersCount");
      return NWNXPopInt();
    }

    // @}
  }
}
