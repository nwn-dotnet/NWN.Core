namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_SQL)]
  public class SqlPlugin
  {
    public const string NWNX_SQL = "NWNX_SQL";

    // /< @private
    // / @brief Prepares the provided query for execution.
    // / @note This does not execute the query. Will also clear any previous state.
    // / @param query The query to prepare.
    // / @return TRUE if the query was successfully prepared.
    public static int PrepareQuery(string query)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "PrepareQuery");
      Internal.NativeFunctions.nwnxPushString(query);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Executes a query which has been prepared.
    // / @return The ID of this query if successful, else FALSE.
    public static int ExecutePreparedQuery()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "ExecutePreparedQuery");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @brief Directly execute an SQL query.
    // / @note Clears previously prepared query states.
    // / @return The ID of this query if successful, else FALSE.
    public static int ExecuteQuery(string query)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "ExecuteQuery");
      Internal.NativeFunctions.nwnxPushString(query);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @anchor sql_rtrnr
    // / @return TRUE if one or more rows are ready, FALSE otherwise.
    public static int ReadyToReadNextRow()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "ReadyToReadNextRow");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @anchor sql_rnr
    // / @brief Reads the next row of returned data.
    // / @remark Should only be called after a successful call to @ref sql_rtrnr "NWNX_SQL_ReadyToReadNextRow()".
    public static void ReadNextRow()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "ReadNextRow");
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @param column The column to read in the active row.
    // / @return Data at the nth (0-based) column of the active row.
    // / @remark Should only be called after a successful call to @ref sql_rnr "NWNX_SQL_ReadNextRow()".
    public static string ReadDataInActiveRow(int column = 0)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "ReadDataInActiveRow");
      Internal.NativeFunctions.nwnxPushInt(column);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Set the int value of a prepared statement at given position.
    // / @param position The nth ? in a prepared statement.
    // / @param value The value to set.
    public static void PreparedInt(int position, int value)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "PreparedInt");
      Internal.NativeFunctions.nwnxPushInt(value);
      Internal.NativeFunctions.nwnxPushInt(position);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Set the string value of a prepared statement at given position.
    // / @param position The nth ? in a prepared statement.
    // / @param value The value to set.
    public static void PreparedString(int position, string value)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "PreparedString");
      Internal.NativeFunctions.nwnxPushString(value);
      Internal.NativeFunctions.nwnxPushInt(position);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Set the float value of a prepared statement at given position.
    // / @param position The nth ? in a prepared statement.
    // / @param value The value to set.
    public static void PreparedFloat(int position, float value)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "PreparedFloat");
      Internal.NativeFunctions.nwnxPushFloat(value);
      Internal.NativeFunctions.nwnxPushInt(position);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Set the ObjectId value of a prepared statement at given position.
    // / @param position The nth ? in a prepared statement.
    // / @param value The value to set.
    public static void PreparedObjectId(int position, uint value)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "PreparedObjectId");
      Internal.NativeFunctions.nwnxPushObject(value);
      Internal.NativeFunctions.nwnxPushInt(position);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Set the full serialized object value of a prepared statement at given position.
    // / @param position The nth ? in a prepared statement.
    // / @param value The value to set.
    // / @param base64 Use base64-encoded string format if TRUE (default), otherwise use binary format.
    public static void PreparedObjectFull(int position, uint value, int base64 = NWScript.TRUE)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "PreparedObjectFull");
      Internal.NativeFunctions.nwnxPushInt(base64);
      Internal.NativeFunctions.nwnxPushObject(value);
      Internal.NativeFunctions.nwnxPushInt(position);
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @brief Like NWNX_SQL_ReadDataInActiveRow, but for full serialized objects.
    // /
    // / The object will be deserialized and created in the game. New object ID is returned.
    // /
    // / The exact behavior depends on type of deserialized object and owner object:
    // /   * If object is an item, and owner if placeable, creature or container, the item will be created in its inventory
    // /   * If owner is an area, the object will be created on the ground at Vector(x,y,z)
    // /   * Otherwise, the object will be created outside the world and needs to be ported manually.
    // /
    // / @param column The column to read in the active row.
    // / @param owner The owner of the object.
    // / @param x, y, z The vector for objects to be placed in areas.
    // / @param base64 Use base64-encoded string format if TRUE (default), otherwise use binary format.
    // / @return The deserialized object.
    public static uint ReadFullObjectInActiveRow(int column = 0, uint owner = NWScript.OBJECT_INVALID, float x = 0.0f, float y = 0.0f, float z = 0.0f, int base64 = NWScript.TRUE)
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "ReadFullObjectInActiveRow");
      Internal.NativeFunctions.nwnxPushInt(base64);
      Internal.NativeFunctions.nwnxPushFloat(z);
      Internal.NativeFunctions.nwnxPushFloat(y);
      Internal.NativeFunctions.nwnxPushFloat(x);
      Internal.NativeFunctions.nwnxPushObject(owner);
      Internal.NativeFunctions.nwnxPushInt(column);
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopObject();
    }

    // / @brief Gets the rows affected by a query.
    // / @remark This command is for non-row-based statements like INSERT, UPDATE, DELETE, etc.
    // / @return Number of rows affected by SQL statement or -1 if the query was not non-row-based.
    public static int GetAffectedRows()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "GetAffectedRows");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / Gets the database type.
    // / @return The database type we're interacting with.
    // / @remark This is the same value as the value of NWNX_SQL_TYPE environment variable.
    public static string GetDatabaseType()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "GetDatabaseType");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Free any resources attached to an existing prepared query.
    // / @remark Resources are automatically freed when a new query is prepared, so calling this isn't necessary.
    public static void DestroyPreparedQuery()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "DestroyPreparedQuery");
      Internal.NativeFunctions.nwnxCallFunction();
    }

    // / @return The last error message generated by the database.
    public static string GetLastError()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "GetLastError");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopString();
    }

    // / @brief Gets the number of parameteres expected by a prepared query.
    // / @return Returns the number of parameters expected by the prepared query or -1 if no query is prepared.
    public static int GetPreparedQueryParamCount()
    {
      Internal.NativeFunctions.nwnxSetFunction(NWNX_SQL, "GetPreparedQueryParamCount");
      Internal.NativeFunctions.nwnxCallFunction();
      return Internal.NativeFunctions.nwnxPopInt();
    }

    // / @}
  }
}