using static NWN.Core.NWScript;

namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_SQL)]
  public class SqlPlugin
  {
    /// @addtogroup sql SQL
    /// Functions to interface with a database through SQL
    /// @{
    /// @file nwnx_sql.nss
    public const string NWNX_SQL = "NWNX_SQL";

    ///&lt; @private
    /// Prepares the provided query for execution.
    /// @note This does not execute the query. Will also clear any previous state.
    /// <param name="query">The query to prepare.</param>
    /// <returns>TRUE if the query was successfully prepared.</returns>
    public static int PrepareQuery(string query)
    {
      NWNXPushString(query);
      NWNXCall(NWNX_SQL, "PrepareQuery");
      return NWNXPopInt();
    }

    /// Executes a query which has been prepared.
    /// <returns>The ID of this query if successful, else FALSE.</returns>
    public static int ExecutePreparedQuery()
    {
      NWNXCall(NWNX_SQL, "ExecutePreparedQuery");
      return NWNXPopInt();
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
        return NWNXPopInt();
      }
      return NWNXPopInt();
    }

    /// @anchor sql_rtrnr
    /// <returns>TRUE if one or more rows are ready, FALSE otherwise.</returns>
    public static int ReadyToReadNextRow()
    {
      NWNXCall(NWNX_SQL, "ReadyToReadNextRow");
      return NWNXPopInt();
    }

    /// @anchor sql_rnr
    /// Reads the next row of returned data.
    /// @remark Should only be called after a successful call to @ref sql_rtrnr &quot;NWNX_SQL_ReadyToReadNextRow()&quot;.
    public static void ReadNextRow()
    {
      NWNXCall(NWNX_SQL, "ReadNextRow");
    }

    /// <param name="column">The column to read in the active row.</param>
    /// <returns>Data at the nth (0-based) column of the active row.</returns>
    /// @remark Should only be called after a successful call to @ref sql_rnr &quot;NWNX_SQL_ReadNextRow()&quot;.
    public static string ReadDataInActiveRow(int column = 0)
    {
      NWNXPushInt(column);
      NWNXCall(NWNX_SQL, "ReadDataInActiveRow");
      return NWNXPopString();
    }

    /// Set the int value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedInt(int position, int value)
    {
      NWNXPushInt(value);
      NWNXPushInt(position);
      NWNXCall(NWNX_SQL, "PreparedInt");
    }

    /// Set the string value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedString(int position, string value)
    {
      NWNXPushString(value);
      NWNXPushInt(position);
      NWNXCall(NWNX_SQL, "PreparedString");
    }

    /// Set the float value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedFloat(int position, float value)
    {
      NWNXPushFloat(value);
      NWNXPushInt(position);
      NWNXCall(NWNX_SQL, "PreparedFloat");
    }

    /// Set the ObjectId value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedObjectId(int position, uint value)
    {
      NWNXPushObject(value);
      NWNXPushInt(position);
      NWNXCall(NWNX_SQL, "PreparedObjectId");
    }

    /// Set the full serialized object value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    /// <param name="base64">Use base64-encoded string format if TRUE (default), otherwise use binary format.</param>
    public static void PreparedObjectFull(int position, uint value, int base64 = TRUE)
    {
      NWNXPushInt(base64);
      NWNXPushObject(value);
      NWNXPushInt(position);
      NWNXCall(NWNX_SQL, "PreparedObjectFull");
    }

    /// Set the NULL value of a prepared statement at given position.
    /// <param name="position">The nth ? in a prepared statement.</param>
    public static void PreparedNULL(int position)
    {
      NWNXPushInt(position);
      NWNXCall(NWNX_SQL, "PreparedNULL");
    }

    /// Set the Json value of a prepared statement at given position. 
    /// Convienence function to match other Prepared(type) functions.
    /// <param name="position">The nth ? in a prepared statement.</param>
    /// <param name="value">The value to set.</param>
    public static void PreparedJson(int position, System.IntPtr value)
    {
      PreparedString(position, JsonDump(value));
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
      NWNXPushInt(base64);
      NWNXPushFloat(z);
      NWNXPushFloat(y);
      NWNXPushFloat(x);
      NWNXPushObject(owner);
      NWNXPushInt(column);
      NWNXCall(NWNX_SQL, "ReadFullObjectInActiveRow");
      return NWNXPopObject();
    }

    /// Gets the rows affected by a query.
    /// @remark This command is for non-row-based statements like INSERT, UPDATE, DELETE, etc.
    /// <returns>Number of rows affected by SQL statement or -1 if the query was not non-row-based.</returns>
    public static int GetAffectedRows()
    {
      NWNXCall(NWNX_SQL, "GetAffectedRows");
      return NWNXPopInt();
    }

    /// Gets the database type.
    /// <returns>The database type we&apos;re interacting with.</returns>
    /// @remark This is the same value as the value of NWNX_SQL_TYPE environment variable.
    public static string GetDatabaseType()
    {
      NWNXCall(NWNX_SQL, "GetDatabaseType");
      return NWNXPopString();
    }

    /// Free any resources attached to an existing prepared query.
    /// @remark Resources are automatically freed when a new query is prepared, so calling this isn&apos;t necessary.
    public static void DestroyPreparedQuery()
    {
      NWNXCall(NWNX_SQL, "DestroyPreparedQuery");
    }

    /// <returns>The last error message generated by the database.</returns>
    public static string GetLastError()
    {
      NWNXCall(NWNX_SQL, "GetLastError");
      return NWNXPopString();
    }

    /// Gets the number of parameteres expected by a prepared query.
    /// <returns>Returns the number of parameters expected by the prepared query or -1 if no query is prepared.</returns>
    public static int GetPreparedQueryParamCount()
    {
      NWNXCall(NWNX_SQL, "GetPreparedQueryParamCount");
      return NWNXPopInt();
    }

    /// Set the next query to return full binary results **ON THE FIRST COLUMN ONLY**.
    /// @note This is ONLY needed on PostgreSQL, and ONLY if you want to deserialize raw bytea in NWNX_SQL_ReadFullObjectInActiveRow with base64=FALSE.
    public static void PostgreSQL_SetNextQueryResultsBinaryMode()
    {
      NWNXCall(NWNX_SQL, "PostgreSQL_SetNextQueryResultsBinaryMode");
    }

    // @}
  }
}
