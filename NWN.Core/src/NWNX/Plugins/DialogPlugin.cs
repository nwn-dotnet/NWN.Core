using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Dialog)]
  public class DialogPlugin
  {
    /// @addtogroup dialog Dialog
    /// Functions exposing additional dialog properties
    /// @{
    /// @file nwnx_dialog.nss
    public const string NWNX_Dialog = "NWNX_Dialog";

    ///&lt; @private
    /// @name Dialog Node Types
    /// @anchor dialog_node_types
    /// @{
    public const int NWNX_DIALOG_NODE_TYPE_INVALID = -1;
    public const int NWNX_DIALOG_NODE_TYPE_STARTING_NODE = 0;
    public const int NWNX_DIALOG_NODE_TYPE_ENTRY_NODE = 1;
    public const int NWNX_DIALOG_NODE_TYPE_REPLY_NODE = 2;

    // @}
    /// @name Dialog Script Types
    /// @anchor dialog_script_types
    /// @{
    public const int NWNX_DIALOG_SCRIPT_TYPE_OTHER = 0;
    public const int NWNX_DIALOG_SCRIPT_TYPE_STARTING_CONDITIONAL = 1;
    public const int NWNX_DIALOG_SCRIPT_TYPE_ACTION_TAKEN = 2;

    // @}
    /// @name Dialog Languages
    /// @anchor dialog_languages
    /// @{
    public const int NWNX_DIALOG_LANGUAGE_ENGLISH = 0;
    public const int NWNX_DIALOG_LANGUAGE_FRENCH = 1;
    public const int NWNX_DIALOG_LANGUAGE_GERMAN = 2;
    public const int NWNX_DIALOG_LANGUAGE_ITALIAN = 3;
    public const int NWNX_DIALOG_LANGUAGE_SPANISH = 4;
    public const int NWNX_DIALOG_LANGUAGE_POLISH = 5;
    public const int NWNX_DIALOG_LANGUAGE_KOREAN = 128;
    public const int NWNX_DIALOG_LANGUAGE_CHINESE_TRADITIONAL = 129;
    public const int NWNX_DIALOG_LANGUAGE_CHINESE_SIMPLIFIED = 130;
    public const int NWNX_DIALOG_LANGUAGE_JAPANESE = 131;

    // @}
    /// Get the @ref dialog_node_types &quot;Node Type&quot; of the current text node
    /// <returns>A @ref dialog_node_types &quot;Node Type&quot;.  If called out of dialog, returns NWNX_DIALOG_NODE_TYPE_INVALID</returns>
    public static int GetCurrentNodeType()
    {
      NWNXCall(NWNX_Dialog, "GetCurrentNodeType");
      return NWNXPopInt();
    }

    /// Get the @ref dialog_script_types &quot;Script Type&quot; of the current text node
    /// <returns>A @ref dialog_script_types &quot;Node Type&quot;. If called out of dialog, returns NWNX_DIALOG_SCRIPT_TYPE_OTHER</returns>
    public static int GetCurrentScriptType()
    {
      NWNXCall(NWNX_Dialog, "GetCurrentScriptType");
      return NWNXPopInt();
    }

    /// Get the absolute ID of the current node in the conversation
    /// @note NWNX_DIALOG_NODE_TYPE_ENTRY_NODE and NWNX_DIALOG_NODE_TYPE_REPLY_NODE nodes
    /// have different namespaces, so they can share the same ID
    /// <returns>The absolute ID in the dialog. If called out of dialog, returns -1</returns>
    public static int GetCurrentNodeID()
    {
      NWNXCall(NWNX_Dialog, "GetCurrentNodeID");
      return NWNXPopInt();
    }

    /// Get the index of the current node in the list of replies/entries.
    /// @note The index is zero based, and counts items not displayed due to a StartingConditional.
    /// <returns>The index of the current node.</returns>
    public static int GetCurrentNodeIndex()
    {
      NWNXCall(NWNX_Dialog, "GetCurrentNodeIndex");
      return NWNXPopInt();
    }

    /// Get the text of the current node
    /// <param name="language">The @ref dialog_languages &quot;language&quot; of the text.</param>
    /// <param name="gender">The gender for the text.</param>
    public static string GetCurrentNodeText(int language = NWNX_DIALOG_LANGUAGE_ENGLISH, int gender = GENDER_MALE)
    {
      NWNXPushInt(gender);
      NWNXPushInt(language);
      NWNXCall(NWNX_Dialog, "GetCurrentNodeText");
      return NWNXPopString();
    }

    /// Set the text of the current node for given language/gender
    /// @note This will only work in a starting conditional script (action take comes after the text is displayed)
    /// <param name="text">The text for the node.</param>
    /// <param name="language">The @ref dialog_languages &quot;language&quot; of the text.</param>
    /// <param name="gender">The gender for the text.</param>
    public static void SetCurrentNodeText(string text, int language = NWNX_DIALOG_LANGUAGE_ENGLISH, int gender = GENDER_MALE)
    {
      NWNXPushInt(gender);
      NWNXPushInt(language);
      NWNXPushString(text);
      NWNXCall(NWNX_Dialog, "SetCurrentNodeText");
    }

    /// End a conversation oObject is involved in, it will fire the OnAbort script of the conversation
    /// @warning Calling this from a conversation script will crash your server.
    /// <param name="oObject">The object in a conversation</param>
    public static void End(uint oObject)
    {
      NWNXPushObject(oObject);
      NWNXCall(NWNX_Dialog, "End");
    }

    // @}
  }
}
