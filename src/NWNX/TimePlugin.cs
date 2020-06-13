namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Time)]
    public class TimePlugin
    {
        public const string NWNX_Time = "NWNX_Time";

        // /< @private
        // / @brief Returns the current date.
        // / @return The date in the format (mm/dd/yyyy).
        public static string GetSystemDate()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Time, "GetSystemDate");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Returns current time.
        // / @return The current time in the format (24:mm:ss).
        public static string GetSystemTime()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Time, "GetSystemTime");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @return Returns the number of seconds since midnight on January 1, 1970.
        public static int GetTimeStamp()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Time, "GetTimeStamp");
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief A high resolution timestamp
        // / @return Returns the number of microseconds since midnight on January 1, 1970.
        public static HighResTimestamp GetHighResTimeStamp()
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Time, "GetHighResTimeStamp");
            Internal.NativeFunctions.nwnxCallFunction();
            HighResTimestamp retVal;
            retVal.microseconds = Internal.NativeFunctions.nwnxPopInt();
            retVal.seconds = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @}
    }

        public struct HighResTimestamp
        {
            public int seconds;
            public int microseconds;
        }
}
