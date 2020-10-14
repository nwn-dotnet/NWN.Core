namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_SpellChecker)]
  public class SpellcheckPlugin
  {
    public const string NWNX_SpellChecker = "NWNX_SpellChecker";

    ///< @private
    /// Finds misspells in a string.
    /// <param name="sentence">The sentence to check.</param>
    /// <returns>The spelling mistakes in the sentence, comma delimited. Returns blank if no errors or if .so file</returns>
    /// is improperly installed.
    /// @note If it returns an error in every word, even when spelled correctly, the dictionary is not set up correctly.
    /// @warning These functions can be performance heavy, do limit how many calls and/or how long of a sentence is passed.
    /// Make use of **DelayCommands** and **AssignCommands**
    public static string FindMisspell(string sentence)
    {
      VM.NWNX.SetFunction(NWNX_SpellChecker, "FindMisspell");
      VM.NWNX.StackPush(sentence);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Get suggestions on a single word, comma delimited.
    /// <param name="word">The string to check for suggestions.</param>
    /// <returns>A comma delimited lists of suggestions for a word. Returns blank if no errors or if .so file is improperly</returns>
    /// installed.
    /// @warning These functions can be performance heavy, do limit how many calls and/or how long of a sentence is passed.
    /// Make use of **DelayCommands** and **AssignCommands**
    public static string GetSuggestSpell(string word)
    {
      VM.NWNX.SetFunction(NWNX_SpellChecker, "GetSuggestSpell");
      VM.NWNX.StackPush(word);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// @}
  }
}
