namespace NWN.Core.NWNX {
  [NWNXPlugin(NWNX_Regex)]
  public class RegexPlugin {
    public const string NWNX_Regex = "NWNX_Regex";

    // /< @private
    // / @param str The string to search.
    // / @param regex The regular expression to use when searching.
    // / @return TRUE if string matches the regular expression.
    public static int Search(string str, string regex) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Regex, "Search");
      Internal.NativeFunctions.nwnxPushString(regex);
      Internal.NativeFunctions.nwnxPushString(str);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Replaces any matches of the regular expression with a string.
    // / @param str The string to search.
    // / @param regex The regular expression to use when searching.
    // / @param replace The string to replace the matches with.
    // / @param firstOnly Set to TRUE to only replace the first match.
    // / @return A new string with any replacements made.
    public static string Replace(string str, string regex, string replace = "", int firstOnly = NWScript.FALSE) {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_Regex, "Replace");
      Internal.NativeFunctions.nwnxPushInt(firstOnly);
      Internal.NativeFunctions.nwnxPushString(replace);
      Internal.NativeFunctions.nwnxPushString(regex);
      Internal.NativeFunctions.nwnxPushString(str);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @}
  }
}