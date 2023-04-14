using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Item)]
  public class ItemPlugin
  {
    public const string NWNX_Item = "NWNX_Item";

    ///&lt; @private
    /// Set an item&apos;s weight.
    /// @note Will not persist through saving.
    /// <param name="oItem">The item object.</param>
    /// <param name="weight">The weight, note this is in tenths of pounds.</param>
    public static void SetWeight(uint oItem, int w)
    {
      const string sFunc = "SetWeight";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(w);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
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
      const string sFunc = "SetBaseGoldPieceValue";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(g);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
    }

    /// Set an item&apos;s additional value in gold pieces.
    /// @remark Total cost = base_value + additional_value.
    /// @note Will persist through saving.
    /// <param name="oItem">The item object.</param>
    /// <param name="gold">The additional gold value.</param>
    public static void SetAddGoldPieceValue(uint oItem, int g)
    {
      const string sFunc = "SetAddGoldPieceValue";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(g);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
    }

    /// Get an item&apos;s base value in gold pieces.
    /// <param name="oItem">The item object.</param>
    /// <returns>The base gold piece value for the item.</returns>
    public static int GetBaseGoldPieceValue(uint oItem)
    {
      const string sFunc = "GetBaseGoldPieceValue";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get an item&apos;s additional value in gold pieces.
    /// <param name="oItem">The item object.</param>
    /// <returns>The additional gold piece value for the item.</returns>
    public static int GetAddGoldPieceValue(uint oItem)
    {
      const string sFunc = "GetAddGoldPieceValue";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Set an item&apos;s base item type.
    /// @warning This will not be visible until the item is refreshed (e.g. drop and take the item,
    /// or logging out and back in).
    /// <param name="oItem">The item object.</param>
    /// <param name="nBaseItem">The new base item.</param>
    public static void SetBaseItemType(uint oItem, int nBaseItem)
    {
      const string sFunc = "SetBaseItemType";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
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
    /// function &apos;clear colour override&apos;, which clears the per-part override for that part.
    public static void SetItemAppearance(uint oItem, int nType, int nIndex, int nValue)
    {
      const string sFunc = "SetItemAppearance";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(nValue);
      VM.NWNX.StackPush(nIndex);
      VM.NWNX.StackPush(nType);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
    }

    /// Return a string containing the entire appearance for an item.
    /// @sa NWNX_Item_RestoreItemAppearance
    /// <param name="oItem">The item object.</param>
    /// <returns>A string representing the item&apos;s appearance.</returns>
    public static string GetEntireItemAppearance(uint oItem)
    {
      const string sFunc = "GetEntireItemAppearance";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Restores an item&apos;s appearance using the value retrieved through NWNX_Item_GetEntireItemAppearance().
    /// <param name="oItem">The item object.</param>
    /// <param name="sApp">A string representing the item&apos;s appearance.</param>
    public static void RestoreItemAppearance(uint oItem, string sApp)
    {
      const string sFunc = "RestoreItemAppearance";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(sApp);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
    }

    /// Get an item&apos;s base armor class
    /// <param name="oItem">The item object.</param>
    /// <returns>The base armor class.</returns>
    public static int GetBaseArmorClass(uint oItem)
    {
      const string sFunc = "GetBaseArmorClass";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Get an item&apos;s minimum level required to equip.
    /// <param name="oItem">The item object.</param>
    /// <returns>The minimum level required to equip the item.</returns>
    public static int GetMinEquipLevel(uint oItem)
    {
      const string sFunc = "GetMinEquipLevel";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Move oItem to oTarget
    /// @remark Moving items from a container to the inventory of the container&apos;s owner (or the other way around) is always &quot;silent&quot; and won&apos;t trigger feedback messages
    /// <param name="oItem">The item object.</param>
    /// <param name="oTarget">The target bag/creature/placeable or store object to move oItem to.</param>
    /// <param name="bHideAllFeedback">Hides all feedback messages generated by losing/acquiring items</param>
    /// <returns>TRUE if the item was successfully moved to the target, otherwise FALSE</returns>
    public static int MoveTo(uint oItem, uint oTarget, int bHideAllFeedback = FALSE)
    {
      const string sFunc = "MoveTo";
      VM.NWNX.SetFunction(NWNX_Item, sFunc);
      VM.NWNX.StackPush(bHideAllFeedback);
      VM.NWNX.StackPush(oTarget);
      VM.NWNX.StackPush(oItem);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    // @}
  }
}
