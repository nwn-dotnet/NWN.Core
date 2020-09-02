namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Regex)]
    public class RegexPlugin
    {
        public const string NWNX_Regex = "NWNX_Regex";

        ///< @private
        /// <param name="str">The string to search.</param>
        /// <param name="regex">The regular expression to use when searching.</param>
        /// <returns>TRUE if string matches the regular expression.</returns>
        public static int Search(string str, string regex)
        {
            VM.NWNX.SetFunction(NWNX_Regex, "Search");
            VM.NWNX.StackPush(regex);
            VM.NWNX.StackPush(str);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Replaces any matches of the regular expression with a string.
        /// <param name="str">The string to search.</param>
        /// <param name="regex">The regular expression to use when searching.</param>
        /// <param name="replace">The string to replace the matches with.</param>
        /// <param name="firstOnly">Set to TRUE to only replace the first match.</param>
        /// <returns>A new string with any replacements made.</returns>
        public static string Replace(string str, string regex, string replace = "", int firstOnly = NWScript.FALSE)
        {
            VM.NWNX.SetFunction(NWNX_Regex, "Replace");
            VM.NWNX.StackPush(firstOnly);
            VM.NWNX.StackPush(replace);
            VM.NWNX.StackPush(regex);
            VM.NWNX.StackPush(str);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// @}
    }
}