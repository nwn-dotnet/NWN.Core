namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Item)]
    public class ItemPlugin
    {
        public const string NWNX_Item = "NWNX_Item";

        // /< @private
        // / @brief Set an item's weight.
        // / @note Will not persist through saving.
        // / @param oItem The item object.
        // / @param weight The weight, note this is in tenths of pounds.
        public static void SetWeight(uint oItem, int weight)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "SetWeight");
            Internal.NativeFunctions.nwnxPushInt(weight);
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set an item's base value in gold pieces.
        // / @remark Total cost = base_value + additional_value.
        // / @remark Equivalent to SetGoldPieceValue NWNX2 function.
        // / @note Will not persist through saving.
        // / @param oItem The item object.
        // / @param gold The base gold value.
        public static void SetBaseGoldPieceValue(uint oItem, int gold)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "SetBaseGoldPieceValue");
            Internal.NativeFunctions.nwnxPushInt(gold);
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set an item's additional value in gold pieces.
        // / @remark Total cost = base_value + additional_value.
        // / @note Will persist through saving.
        // / @param oItem The item object.
        // / @param gold The additional gold value.
        public static void SetAddGoldPieceValue(uint oItem, int gold)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "SetAddGoldPieceValue");
            Internal.NativeFunctions.nwnxPushInt(gold);
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get an item's base value in gold pieces.
        // / @param oItem The item object.
        // / @return The base gold piece value for the item.
        public static int GetBaseGoldPieceValue(uint oItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "GetBaseGoldPieceValue");
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get an item's additional value in gold pieces.
        // / @param oItem The item object.
        // / @return The additional gold piece value for the item.
        public static int GetAddGoldPieceValue(uint oItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "GetAddGoldPieceValue");
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set an item's base item type.
        // / @warning This will not be visible until the item is refreshed (e.g. drop and take the item,
        // / or logging out and back in).
        // / @param oItem The item object.
        // / @param nBaseItem The new base item.
        public static void SetBaseItemType(uint oItem, int nBaseItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "SetBaseItemType");
            Internal.NativeFunctions.nwnxPushInt(nBaseItem);
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Make a single change to the appearance of an item.
        // / @warning This will not be visible to PCs until the item is refreshed for them (e.g. by logging out and back in).
        // /
        // / Helmet models and simple items ignore nIndex.
        // / ```
        // / nType                            nIndex                              nValue
        // / ITEM_APPR_TYPE_SIMPLE_MODEL      [Ignored]                           Model #
        // / ITEM_APPR_TYPE_WEAPON_COLOR      ITEM_APPR_WEAPON_COLOR_*            0-255
        // / ITEM_APPR_TYPE_WEAPON_MODEL      ITEM_APPR_WEAPON_MODEL_*            Model #
        // / ITEM_APPR_TYPE_ARMOR_MODEL       ITEM_APPR_ARMOR_MODEL_*             Model #
        // / ITEM_APPR_TYPE_ARMOR_COLOR       ITEM_APPR_ARMOR_COLOR_* [0]         0-255 [1]
        // / ```
        // /
        // / [0] Where ITEM_APPR_TYPE_ARMOR_COLOR is specified, if per-part coloring is
        // / desired, the following equation can be used for nIndex to achieve that:
        // /
        // / ITEM_APPR_ARMOR_NUM_COLORS + (ITEM_APPR_ARMOR_MODEL_ * ITEM_APPR_ARMOR_NUM_COLORS) + ITEM_APPR_ARMOR_COLOR_
        // /
        // / For example, to change the CLOTH1 channel of the torso, nIndex would be:
        // /
        // /     6 + (7 * 6) + 2 = 50
        // /
        // / [1] When specifying per-part coloring, the value 255 corresponds with the logical
        // / function 'clear colour override', which clears the per-part override for that part.
        public static void SetItemAppearance(uint oItem, int nType, int nIndex, int nValue)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "SetItemAppearance");
            Internal.NativeFunctions.nwnxPushInt(nValue);
            Internal.NativeFunctions.nwnxPushInt(nIndex);
            Internal.NativeFunctions.nwnxPushInt(nType);
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Return a string containing the entire appearance for an item.
        // / @sa NWNX_Item_RestoreItemAppearance
        // / @param oItem The item object.
        // / @return A string representing the item's appearance.
        public static string GetEntireItemAppearance(uint oItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "GetEntireItemAppearance");
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Restores an item's appearance using the value retrieved through NWNX_Item_GetEntireItemAppearance().
        // / @param oItem The item object.
        // / @param sApp A string representing the item's appearance.
        public static void RestoreItemAppearance(uint oItem, string sApp)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "RestoreItemAppearance");
            Internal.NativeFunctions.nwnxPushString(sApp);
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get an item's base armor class
        // / @param oItem The item object.
        // / @return The base armor class.
        public static int GetBaseArmorClass(uint oItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "GetBaseArmorClass");
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get an item's minimum level required to equip.
        // / @param oItem The item object.
        // / @return The minimum level required to equip the item.
        public static int GetMinEquipLevel(uint oItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Item, "GetMinEquipLevel");
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @}
    }
}
