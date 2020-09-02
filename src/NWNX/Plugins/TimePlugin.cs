namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Time)]
    public class TimePlugin
    {
        public const string NWNX_Time = "NWNX_Time";

        ///< @private
        /// Returns the current date.
        /// <returns>The date in the format (mm/dd/yyyy).</returns>
        public static string GetSystemDate()
        {
            VM.NWNX.SetFunction(NWNX_Time, "GetSystemDate");
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Returns current time.
        /// <returns>The current time in the format (24:mm:ss).</returns>
        public static string GetSystemTime()
        {
            VM.NWNX.SetFunction(NWNX_Time, "GetSystemTime");
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// <returns>Returns the number of seconds since midnight on January 1, 1970.</returns>
        public static int GetTimeStamp()
        {
            VM.NWNX.SetFunction(NWNX_Time, "GetTimeStamp");
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// A high resolution timestamp
        /// <returns>Returns the number of microseconds since midnight on January 1, 1970.</returns>
        public static HighResTimestamp GetHighResTimeStamp()
        {
            VM.NWNX.SetFunction(NWNX_Time, "GetHighResTimeStamp");
            VM.NWNX.Call();
            HighResTimestamp retVal;
            retVal.microseconds = VM.NWNX.StackPopInt();
            retVal.seconds = VM.NWNX.StackPopInt();
            return retVal;
        }

        /// @}
    }

    public struct HighResTimestamp
    {
        public int seconds;
        public int microseconds;
    }
}