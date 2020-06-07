using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_Lua)]
    public class LuaPlugin
    {
        public const string NWNX_Lua = "NWNX_Lua";

        // /< @private
        // / @brief Evaluate LUA code.
        // / @param sCode The code to evaluate.
        public static void EvalVoid(string sCode)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Lua, "EvalVoid");
            Internal.NativeFunctions.nwnxPushString(sCode);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Evaluate LUA code and return the output.
        // / @param sCode The code to evaluate.
        // / @return The result of the Lua code execution.
        public static string Eval(string sCode)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Lua, "Eval");
            Internal.NativeFunctions.nwnxPushString(sCode);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Generate events in NWScript to receive on the Lua side.
        // /
        // / Executes all the Lua functions registered to listen to that event in order of priority.
        // / For details on events just look at the three *Event() functions in preload.lua.
        public static void RunEvent(string sEvent, uint oObject, string sExtra = "")
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Lua, "RunEvent");
            Internal.NativeFunctions.nwnxPushString(sExtra);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxPushString(sEvent);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
    }
}
