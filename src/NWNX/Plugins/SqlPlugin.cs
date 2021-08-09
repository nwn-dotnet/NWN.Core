using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_SQL)]
  public class SqlPlugin
  {
    public const string NWNX_SQL = "NWNX_SQL";

    ///&lt; @private
    /// Prepares the provided query for execution.
    /// @note This does not execute the query. Will also clear any previous state.
    /// <param name="query">The query to prepare.</param>
    /// <returns>TRUE if the query was successfully prepared.</returns>
    public static int PrepareQuery(string query)
    {
      const string sFunc = "PrepareQuery";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(query);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Executes a query which has been prepared.
    /// <returns>The ID of this query if successful, else FALSE.</returns>
    public static int ExecutePreparedQuery()
    {
      const string sFunc = "ExecutePreparedQuery";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Directly execute an SQL query.
    /// @note Clears previously prepared query states.
    /// <returns>The ID of this query if successful, else FALSE.</returns>
    public static int ExecuteQuery(string query)
    {
      if (PrepareQuery(query) == TRUE)
      {
        int ret = ExecutePreparedQuery();
        DestroyPreparedQuery();
        return VM.NWNX.StackPopInt();
      }
      return VM.NWNX.StackPopInt();
    }

    /// @anchor sql_rtrnr
    /// <returns>TRUE if one or more rows are ready, FALSE otherwise.</returns>
    public static int ReadyToReadNextRow()
    {
      const string sFunc = "ReadyToReadNextRow";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// @anchor sql_rnr
    /// Reads the next row of returned data.
    /// @remark Should only be called after a successful call to @ref sql_rtrnr &quot;NWNX_SQL_ReadyToReadNextRow()&quot;.
    public static void ReadNextRow()
    {
      const string sFunc = "ReadNextRow";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
    }

    /// <param name="column">The column to read in the active row.</param>
    /// <returns>Data at the nth (0-based) column of the active row.</returns>
    /// @remark Should only be called after a successful call to @ref sql_rnr &quot;NWNX_SQL_ReadNextRow()&quot;.
    public static string ReadDataInActiveRow(int column = 0)
    {
      const string sFunc = "ReadDataInActiveRow";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(column);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Set the int value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedInt(int position, int value)
    {
      const string sFunc = "PreparedInt";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(position);
      VM.NWNX.Call();
    }

    /// Set the string value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedString(int position, string value)
    {
      const string sFunc = "PreparedString";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(position);
      VM.NWNX.Call();
    }

    /// Set the float value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedFloat(int position, float value)
    {
      const string sFunc = "PreparedFloat";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(position);
      VM.NWNX.Call();
    }

    /// Set the ObjectId value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedObjectId(int position, uint value)
    {
      const string sFunc = "PreparedObjectId";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(position);
      VM.NWNX.Call();
    }

    /// Set the full serialized object value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="base64">Use base64-encoded string format if TRUE (default), otherwise use binary format.</param>
    public static void PreparedObjectFull(int position, uint value, int base64 = TRUE)
    {
      const string sFunc = "PreparedObjectFull";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(base64);
      VM.NWNX.StackPush(value);
      VM.NWNX.StackPush(position);
      VM.NWNX.Call();
    }

    /// Set the NULL value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    public static void PreparedNULL(int position)
    {
      const string sFunc = "PreparedNULL";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(position);
      VM.NWNX.Call();
    }

    /// Like NWNX_SQL_ReadDataInActiveRow, but for full serialized objects.
    ///
    /// The object will be deserialized and created in the game. New object ID is returned.
    ///
    /// The exact behavior depends on type of deserialized object and owner object:
    ///   * If object is an item, and owner if placeable, creature or container, the item will be created in its inventory
    ///   * If owner is an area, the object will be created on the ground at Vector(x,y,z)
    ///   * Otherwise, the object will be created outside the world and needs to be ported manually.
    ///
    /// <param name="column">The column to read in the active row.</param>
    /// <param name="owner">The owner of the object.</param>
    /// <param name="x,">y, z The vector for objects to be placed in areas.</param>
    /// <param name="base64">Use base64-encoded string format if TRUE (default), otherwise use binary format.</param>
    /// <returns>The deserialized object.</returns>
    public static uint ReadFullObjectInActiveRow(int column = 0, uint owner = OBJECT_INVALID, float x = 0.0f, float y = 0.0f, float z = 0.0f, int base64 = TRUE)
    {
      const string sFunc = "ReadFullObjectInActiveRow";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.StackPush(base64);
      VM.NWNX.StackPush(z);
      VM.NWNX.StackPush(y);
      VM.NWNX.StackPush(x);
      VM.NWNX.StackPush(owner);
      VM.NWNX.StackPush(column);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    /// Gets the rows affected by a query.
    /// @remark This command is for non-row-based statements like INSERT, UPDATE, DELETE, etc.
    /// <returns>Number of rows affected by SQL statement or -1 if the query was not non-row-based.</returns>
    public static int GetAffectedRows()
    {
      const string sFunc = "GetAffectedRows";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Gets the database type.
    /// <returns>The database type we&apos;re interacting with.</returns>
    /// @remark This is the same value as the value of NWNX_SQL_TYPE environment variable.
    public static string GetDatabaseType()
    {
      const string sFunc = "GetDatabaseType";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Free any resources attached to an existing prepared query.
    /// @remark Resources are automatically freed when a new query is prepared, so calling this isn&apos;t necessary.
    public static void DestroyPreparedQuery()
    {
      const string sFunc = "DestroyPreparedQuery";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
    }

    /// <returns>The last error message generated by the database.</returns>
    public static string GetLastError()
    {
      const string sFunc = "GetLastError";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Gets the number of parameteres expected by a prepared query.
    /// <returns>Returns the number of parameters expected by the prepared query or -1 if no query is prepared.</returns>
    public static int GetPreparedQueryParamCount()
    {
      const string sFunc = "GetPreparedQueryParamCount";
      VM.NWNX.SetFunction(NWNX_SQL, sFunc);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    // @}
  }
}
