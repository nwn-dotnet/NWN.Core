using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Lua)]
  public class LuaPlugin
  {
    /// @addtogroup lua LUA
    /// Execute Lua code and generate events in NWScript
    /// @{
    /// @file nwnx_lua.nss
    public const string NWNX_Lua = "NWNX_Lua";

    ///&lt; @private
    /// Evaluate LUA code.
    /// <param name="sCode">The code to evaluate.</param>
    public static void EvalVoid(string sCode)
    {
      NWNXPushString(sCode);
      NWNXCall(NWNX_Lua, "EvalVoid");
    }

    /// Evaluate LUA code and return the output.
    /// <param name="sCode">The code to evaluate.</param>
    /// <returns>The result of the Lua code execution.</returns>
    public static string Eval(string sCode)
    {
      NWNXPushString(sCode);
      NWNXCall(NWNX_Lua, "Eval");
      return NWNXPopString();
    }

    /// Generate events in NWScript to receive on the Lua side.
    ///
    /// Executes all the Lua functions registered to listen to that event in order of priority.
    /// For details on events just look at the three *Event() functions in preload.lua.
    public static void RunEvent(string sEvent, uint oObject, string sExtra = "")
    {
      NWNXPushString(sExtra);
      NWNXPushObject(oObject);
      NWNXPushString(sEvent);
      NWNXCall(NWNX_Lua, "RunEvent");
    }

    // @}
  }
}
