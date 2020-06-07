using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_SpellChecker)]
    public class SpellcheckPlugin
    {
        public const string NWNX_SpellChecker = "NWNX_SpellChecker";

        // /< @private
        // / @brief Finds misspells in a string.
        // / @param sentence The sentence to check.
        // / @return The spelling mistakes in the sentence, comma delimited. Returns blank if no errors or if .so file
        // / is improperly installed.
        // / @note If it returns an error in every word, even when spelled correctly, the dictionary is not set up correctly.
        // / @warning These functions can be performance heavy, do limit how many calls and/or how long of a sentence is passed.
        // / Make use of **DelayCommands** and **AssignCommands**
        public static string FindMisspell(string sentence)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SpellChecker, "FindMisspell");
            Internal.NativeFunctions.nwnxPushString(sentence);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Get suggestions on a single word, comma delimited.
        // / @param word The string to check for suggestions.
        // / @return A comma delimited lists of suggestions for a word. Returns blank if no errors or if .so file is improperly
        // / installed.
        // / @warning These functions can be performance heavy, do limit how many calls and/or how long of a sentence is passed.
        // / Make use of **DelayCommands** and **AssignCommands**
        public static string GetSuggestSpell(string word)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_SpellChecker, "GetSuggestSpell");
            Internal.NativeFunctions.nwnxPushString(word);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @}
    }
}
