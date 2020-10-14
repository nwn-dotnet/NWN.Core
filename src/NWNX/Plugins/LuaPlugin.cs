namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Lua)]
  public class LuaPlugin
  {
    public const string NWNX_Lua = "NWNX_Lua";

    ///< @private
    /// Evaluate LUA code.
    /// <param name="sCode">The code to evaluate.</param>
    public static void EvalVoid(string sCode)
    {
      VM.NWNX.SetFunction(NWNX_Lua, "EvalVoid");
      VM.NWNX.StackPush(sCode);
      VM.NWNX.Call();
    }

    /// Evaluate LUA code and return the output.
    /// <param name="sCode">The code to evaluate.</param>
    /// <returns>The result of the Lua code execution.</returns>
    public static string Eval(string sCode)
    {
      VM.NWNX.SetFunction(NWNX_Lua, "Eval");
      VM.NWNX.StackPush(sCode);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Generate events in NWScript to receive on the Lua side.
    ///
    /// Executes all the Lua functions registered to listen to that event in order of priority.
    /// For details on events just look at the three *Event() functions in preload.lua.
    public static void RunEvent(string sEvent, uint oObject, string sExtra = "")
    {
      VM.NWNX.SetFunction(NWNX_Lua, "RunEvent");
      VM.NWNX.StackPush(sExtra);
      VM.NWNX.StackPush(oObject);
      VM.NWNX.StackPush(sEvent);
      VM.NWNX.Call();
    }

    /// @}
  }
}
