using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Item)]
  public class ItemPlugin
  {
    /// @addtogroup item Item
    /// Functions exposing additional item properties.
    /// @{
    /// @file nwnx_item.nss
    public const string NWNX_Item = "NWNX_Item";

    ///&lt; @private
    /// Set an item&apos;s weight.
    /// @note Will not persist through saving.
    /// <param name="oItem">The item object.</param>
    /// <param name="weight">The weight, note this is in tenths of pounds.</param>
    public static void SetWeight(uint oItem, int w)
    {
      NWNXPushInt(w);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetWeight");
    }

    /// Set an item&apos;s base value in gold pieces.
    /// @remark Total cost = base_value + additional_value.
    /// @remark Equivalent to SetGoldPieceValue NWNX2 function.
    /// @note Will not persist through saving.
    /// @note This value will also revert if item is identified or player relogs into server.
    /// <param name="oItem">The item object.</param>
    /// <param name="gold">The base gold value.</param>
    public static void SetBaseGoldPieceValue(uint oItem, int g)
    {
      NWNXPushInt(g);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetBaseGoldPieceValue");
    }

    /// Set an item&apos;s additional value in gold pieces.
    /// @remark Total cost = base_value + additional_value.
    /// @note Will persist through saving.
    /// <param name="oItem">The item object.</param>
    /// <param name="gold">The additional gold value.</param>
    public static void SetAddGoldPieceValue(uint oItem, int g)
    {
      NWNXPushInt(g);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetAddGoldPieceValue");
    }

    /// Get an item&apos;s base value in gold pieces.
    /// <param name="oItem">The item object.</param>
    /// <returns>The base gold piece value for the item.</returns>
    public static int GetBaseGoldPieceValue(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetBaseGoldPieceValue");
      return NWNXPopInt();
    }

    /// Get an item&apos;s additional value in gold pieces.
    /// <param name="oItem">The item object.</param>
    /// <returns>The additional gold piece value for the item.</returns>
    public static int GetAddGoldPieceValue(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetAddGoldPieceValue");
      return NWNXPopInt();
    }

    /// Set an item&apos;s base item type.
    /// @warning This will not be visible until the item is refreshed (e.g. drop and take the item,
    /// or logging out and back in).
    /// <param name="oItem">The item object.</param>
    /// <param name="nBaseItem">The new base item.</param>
    public static void SetBaseItemType(uint oItem, int nBaseItem)
    {
      NWNXPushInt(nBaseItem);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetBaseItemType");
    }

    /// Make a single change to the appearance of an item.
    /// @warning This will not be visible to PCs until the item is refreshed for them (e.g. by logging out and back in).
    ///
    /// Helmet models and simple items ignore nIndex.
    /// ```
    /// nType                            nIndex                              nValue
    /// ITEM_APPR_TYPE_SIMPLE_MODEL      [Ignored]                           Model #
    /// ITEM_APPR_TYPE_WEAPON_COLOR      ITEM_APPR_WEAPON_COLOR_*            0-255
    /// ITEM_APPR_TYPE_WEAPON_MODEL      ITEM_APPR_WEAPON_MODEL_*            Model #
    /// ITEM_APPR_TYPE_ARMOR_MODEL       ITEM_APPR_ARMOR_MODEL_*             Model #
    /// ITEM_APPR_TYPE_ARMOR_COLOR       ITEM_APPR_ARMOR_COLOR_* [0]         0-255 [1]
    /// ```
    ///
    /// [0] Where ITEM_APPR_TYPE_ARMOR_COLOR is specified, if per-part coloring is
    /// desired, the following equation can be used for nIndex to achieve that:
    ///
    /// ITEM_APPR_ARMOR_NUM_COLORS + (ITEM_APPR_ARMOR_MODEL_ * ITEM_APPR_ARMOR_NUM_COLORS) + ITEM_APPR_ARMOR_COLOR_
    ///
    /// For example, to change the CLOTH1 channel of the torso, nIndex would be:
    ///
    ///     6 + (7 * 6) + 2 = 50
    ///
    /// [1] When specifying per-part coloring, the value 255 corresponds with the logical
    /// function &apos;clear colour override&apos;, which clears the per-part override for that part.
    /// <param name="oItem">The item</param>
    /// <param name="nType">The type</param>
    /// <param name="nIndex">The index</param>
    /// <param name="nValue">The value</param>
    /// <param name="bUpdateCreatureAppearance">If TRUE, also update the appearance of oItem&apos;s possessor. Only works for armor/helmets/cloaks. Will remove the item from the quickbar as side effect.</param>
    public static void SetItemAppearance(uint oItem, int nType, int nIndex, int nValue, int bUpdateCreatureAppearance = FALSE)
    {
      NWNXPushInt(bUpdateCreatureAppearance);
      NWNXPushInt(nValue);
      NWNXPushInt(nIndex);
      NWNXPushInt(nType);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetItemAppearance");
    }

    /// Return a string containing the entire appearance for an item.
    /// @sa NWNX_Item_RestoreItemAppearance
    /// <param name="oItem">The item object.</param>
    /// <returns>A string representing the item&apos;s appearance.</returns>
    public static string GetEntireItemAppearance(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetEntireItemAppearance");
      return NWNXPopString();
    }

    /// Restores an item&apos;s appearance using the value retrieved through NWNX_Item_GetEntireItemAppearance().
    /// <param name="oItem">The item object.</param>
    /// <param name="sApp">A string representing the item&apos;s appearance.</param>
    public static void RestoreItemAppearance(uint oItem, string sApp)
    {
      NWNXPushString(sApp);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "RestoreItemAppearance");
    }

    /// Get an item&apos;s base armor class
    /// <param name="oItem">The item object.</param>
    /// <returns>The base armor class.</returns>
    public static int GetBaseArmorClass(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetBaseArmorClass");
      return NWNXPopInt();
    }

    /// Get an item&apos;s minimum level required to equip.
    /// <param name="oItem">The item object.</param>
    /// <returns>The minimum level required to equip the item.</returns>
    public static int GetMinEquipLevel(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetMinEquipLevel");
      return NWNXPopInt();
    }

    /// Move oItem to oTarget
    /// @remark Moving items from a container to the inventory of the container&apos;s owner (or the other way around) is always &quot;silent&quot; and won&apos;t trigger feedback messages
    /// <param name="oItem">The item object.</param>
    /// <param name="oTarget">The target bag/creature/placeable or store object to move oItem to.</param>
    /// <param name="bHideAllFeedback">Hides all feedback messages generated by losing/acquiring items</param>
    /// <returns>TRUE if the item was successfully moved to the target, otherwise FALSE</returns>
    public static int MoveTo(uint oItem, uint oTarget, int bHideAllFeedback = FALSE)
    {
      NWNXPushInt(bHideAllFeedback);
      NWNXPushObject(oTarget);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "MoveTo");
      return NWNXPopInt();
    }

    /// Set a modifier to the Minimum Level to Equip (Item Level Restriction).
    /// <param name="oItem">The item object.</param>
    /// <param name="nModifier">the modifier to apply (After any Override)</param>
    /// <param name="bPersist">Whether the modifier should persist to gff field. Strongly Recommended to be TRUE (See warning)</param>
    /// @note This function (or override partner) must be used each server reset to re-enable persistence. Recommended use on OBJECT_INVALID OnModuleLoad.
    /// @warning if Persistence is FALSE, or not re-enabled, beware characters may trigger ELC logging in with now-invalid ItemLevelRestrictions equipped.
    public static void SetMinEquipLevelModifier(uint oItem, int nModifier, int bPersist = TRUE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nModifier);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetMinEquipLevelModifier");
    }

    /// Gets the applied modifier to the Minimum Level to Equip (Item Level Restriction).
    /// <param name="oItem">The item object.</param>
    public static int GetMinEquipLevelModifier(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetMinEquipLevelModifier");
      return NWNXPopInt();
    }

    /// Set an override to the Minimum Level to Equip (Item Level Restriction).
    /// <param name="oItem">The item object.</param>
    /// <param name="nOverride">the nOverride to apply (Before any Modifier)</param>
    /// <param name="bPersist">Whether the modifier should persist to gff field. Strongly Recommended to be TRUE (See warning)</param>
    /// @note This function (or modifier partner) must be used each server reset to re-enable persistence. Recommended use on OBJECT_INVALID OnModuleLoad.
    /// @warning if Persistence is FALSE, or not re-enabled, beware characters may trigger ELC logging in with now-invalid ItemLevelRestrictions equipped.
    public static void SetMinEquipLevelOverride(uint oItem, int nOverride, int bPersist = TRUE)
    {
      NWNXPushInt(bPersist);
      NWNXPushInt(nOverride);
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "SetMinEquipLevelOverride");
    }

    /// Gets the applied override to the Minimum Level to Equip (Item Level Restriction).
    /// <param name="oItem">The item object.</param>
    public static int GetMinEquipLevelOverride(uint oItem)
    {
      NWNXPushObject(oItem);
      NWNXCall(NWNX_Item, "GetMinEquipLevelOverride");
      return NWNXPopInt();
    }

    // @}
  }
}
