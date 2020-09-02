namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Item)]
    public class ItemPlugin
    {
        public const string NWNX_Item = "NWNX_Item";

        ///< @private
        /// Set an item's weight.
        /// @note Will not persist through saving.
        /// <param name="oItem">The item object.</param>
        /// <param name="weight">The weight, note this is in tenths of pounds.</param>
        public static void SetWeight(uint oItem, int weight)
        {
            VM.NWNX.SetFunction(NWNX_Item, "SetWeight");
            VM.NWNX.StackPush(weight);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
        }

        /// Set an item's base value in gold pieces.
        /// @remark Total cost = base_value + additional_value.
        /// @remark Equivalent to SetGoldPieceValue NWNX2 function.
        /// @note Will not persist through saving.
        /// <param name="oItem">The item object.</param>
        /// <param name="gold">The base gold value.</param>
        public static void SetBaseGoldPieceValue(uint oItem, int gold)
        {
            VM.NWNX.SetFunction(NWNX_Item, "SetBaseGoldPieceValue");
            VM.NWNX.StackPush(gold);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
        }

        /// Set an item's additional value in gold pieces.
        /// @remark Total cost = base_value + additional_value.
        /// @note Will persist through saving.
        /// <param name="oItem">The item object.</param>
        /// <param name="gold">The additional gold value.</param>
        public static void SetAddGoldPieceValue(uint oItem, int gold)
        {
            VM.NWNX.SetFunction(NWNX_Item, "SetAddGoldPieceValue");
            VM.NWNX.StackPush(gold);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
        }

        /// Get an item's base value in gold pieces.
        /// <param name="oItem">The item object.</param>
        /// <returns>The base gold piece value for the item.</returns>
        public static int GetBaseGoldPieceValue(uint oItem)
        {
            VM.NWNX.SetFunction(NWNX_Item, "GetBaseGoldPieceValue");
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Get an item's additional value in gold pieces.
        /// <param name="oItem">The item object.</param>
        /// <returns>The additional gold piece value for the item.</returns>
        public static int GetAddGoldPieceValue(uint oItem)
        {
            VM.NWNX.SetFunction(NWNX_Item, "GetAddGoldPieceValue");
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set an item's base item type.
        /// @warning This will not be visible until the item is refreshed (e.g. drop and take the item,
        /// or logging out and back in).
        /// <param name="oItem">The item object.</param>
        /// <param name="nBaseItem">The new base item.</param>
        public static void SetBaseItemType(uint oItem, int nBaseItem)
        {
            VM.NWNX.SetFunction(NWNX_Item, "SetBaseItemType");
            VM.NWNX.StackPush(nBaseItem);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
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
        /// function 'clear colour override', which clears the per-part override for that part.
        public static void SetItemAppearance(uint oItem, int nType, int nIndex, int nValue)
        {
            VM.NWNX.SetFunction(NWNX_Item, "SetItemAppearance");
            VM.NWNX.StackPush(nValue);
            VM.NWNX.StackPush(nIndex);
            VM.NWNX.StackPush(nType);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
        }

        /// Return a string containing the entire appearance for an item.
        /// @sa NWNX_Item_RestoreItemAppearance
        /// <param name="oItem">The item object.</param>
        /// <returns>A string representing the item's appearance.</returns>
        public static string GetEntireItemAppearance(uint oItem)
        {
            VM.NWNX.SetFunction(NWNX_Item, "GetEntireItemAppearance");
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Restores an item's appearance using the value retrieved through NWNX_Item_GetEntireItemAppearance().
        /// <param name="oItem">The item object.</param>
        /// <param name="sApp">A string representing the item's appearance.</param>
        public static void RestoreItemAppearance(uint oItem, string sApp)
        {
            VM.NWNX.SetFunction(NWNX_Item, "RestoreItemAppearance");
            VM.NWNX.StackPush(sApp);
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
        }

        /// Get an item's base armor class
        /// <param name="oItem">The item object.</param>
        /// <returns>The base armor class.</returns>
        public static int GetBaseArmorClass(uint oItem)
        {
            VM.NWNX.SetFunction(NWNX_Item, "GetBaseArmorClass");
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Get an item's minimum level required to equip.
        /// <param name="oItem">The item object.</param>
        /// <returns>The minimum level required to equip the item.</returns>
        public static int GetMinEquipLevel(uint oItem)
        {
            VM.NWNX.SetFunction(NWNX_Item, "GetMinEquipLevel");
            VM.NWNX.StackPush(oItem);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// @}
    }
}