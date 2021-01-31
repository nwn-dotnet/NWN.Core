using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Time)]
  public class TimePlugin
  {
    public const string NWNX_Time = "NWNX_Time";

    ///< @private
    /// Returns the current date.
    /// @deprecated Use SQLite functions (see inc_sqlite_time). This will be removed in future NWNX releases.
    /// <returns>The date in the format (mm/dd/yyyy).</returns>
    public static string GetSystemDate()
    {
      WriteTimestampedLogEntry("WARNING:  NWNX_Time is deprecated.  You should migrate to SQLite based functions (see inc_sqlite_time).");
      return VM.NWNX.StackPopString();
    }

    /// Returns current time.
    /// @deprecated Use SQLite functions (see inc_sqlite_time). This will be removed in future NWNX releases.
    /// <returns>The current time in the format (24:mm:ss).</returns>
    public static string GetSystemTime()
    {
      WriteTimestampedLogEntry("WARNING:  NWNX_Time is deprecated.  You should migrate to SQLite based functions (see inc_sqlite_time).");
      return VM.NWNX.StackPopString();
    }

    /// @deprecated Use SQLite functions (see inc_sqlite_time). This will be removed in future NWNX releases.
    /// <returns>Returns the number of seconds since midnight on January 1, 1970.</returns>
    public static int GetTimeStamp()
    {
      WriteTimestampedLogEntry("WARNING:  NWNX_Time is deprecated.  You should migrate to SQLite based functions (see inc_sqlite_time).");
      return VM.NWNX.StackPopInt();
    }

    /// A high resolution timestamp
    /// @deprecated Use NWNX_Util_GetHighResTimeStamp(). This will be removed in future NWNX releases.
    /// <returns>Returns the number of microseconds since midnight on January 1, 1970.</returns>
    public static HighResTimestamp GetHighResTimeStamp()
    {
      WriteTimestampedLogEntry("WARNING:  NWNX_Time is deprecated.  GetHighResTimeStamp is moving to NWNX_Util.");
      NWNX_Util_HighResTimestamp u = NWNX_Util_GetHighResTimeStamp();
      HighResTimestamp t = default;
      t.seconds = u.seconds;
      t.microseconds = u.microseconds;
      return t;
    }

    /// @}
  }

  public struct HighResTimestamp
  {
    public int seconds;
    public int microseconds;
  }
}
