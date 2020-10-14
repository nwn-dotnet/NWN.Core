namespace NWN.Core.NWNX
{
  [NWNXPlugin(NWNX_Data)]
  public class DataPlugin
  {
    public const string NWNX_Data = "NWNX_Data";

    public const int NWNX_DATA_INVALID_INDEX = -1;
    public const int NWNX_DATA_TYPE_FLOAT = 0;
    public const int NWNX_DATA_TYPE_INTEGER = 1;
    public const int NWNX_DATA_TYPE_OBJECT = 2;
    public const int NWNX_DATA_TYPE_STRING = 3;

    /// @defgroup data_array_at Array At
    /// Returns the element at the index.
    /// @ingroup data
    /// <param name="obj">The object.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="index">The index.</param>
    /// <returns>The element of associated type.</returns>

    public static float Array_At_Flt(uint obj, string tag, int index)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayAt");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_FLOAT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopFloat();
    }

    public static int Array_At_Int(uint obj, string tag, int index)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayAt");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_INTEGER);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static uint Array_At_Obj(uint obj, string tag, int index)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayAt");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_OBJECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopObject();
    }

    public static string Array_At_Str(uint obj, string tag, int index)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayAt");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_STRING);
      VM.NWNX.Call();
      return VM.NWNX.StackPopString();
    }

    /// Clears the entire array, such that size==0.
    public static void Array_Clear(int type, uint obj, string tag)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayClear");
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// @defgroup data_array_contains Array Contains
    /// Checks if array contains the element.
    /// @ingroup data
    /// <param name="obj">The object.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="element">The element.</param>
    /// <returns>TRUE if the collection contains the element.</returns>

    public static int Array_Contains_Flt(uint obj, string tag, float element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayContains");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_FLOAT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static int Array_Contains_Int(uint obj, string tag, int element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayContains");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_INTEGER);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static int Array_Contains_Obj(uint obj, string tag, uint element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayContains");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_OBJECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static int Array_Contains_Str(uint obj, string tag, string element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayContains");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_STRING);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Copies the array of name otherTag over the array of name tag.
    public static void Array_Copy(int type, uint obj, string tag, string otherTag)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayCopy");
      VM.NWNX.StackPush(otherTag);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// Erases the element at index, and shuffles any elements from index size-1 to index + 1 left.
    public static void Array_Erase(int type, uint obj, string tag, int index)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayErase");
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// @defgroup data_array_find Array Find
    /// Get the index at which the element is located.
    /// @ingroup data
    /// <param name="obj">The object.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="element">The element.</param>
    /// <returns>Returns the index at which the element is located, or ARRAY_INVALID_INDEX.</returns>

    public static int Array_Find_Flt(uint obj, string tag, float element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayFind");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_FLOAT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static int Array_Find_Int(uint obj, string tag, int element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayFind");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_INTEGER);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static int Array_Find_Obj(uint obj, string tag, uint element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayFind");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_OBJECT);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    public static int Array_Find_Str(uint obj, string tag, string element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayFind");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_STRING);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// @defgroup data_array_insert Array Insert
    /// Inserts the element at the index, where size > index >= 0.
    /// @ingroup data
    /// <param name="obj">The object.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="index">The index.</param>
    /// <param name="element">The element.</param>

    public static void Array_Insert_Flt(uint obj, string tag, int index, float element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayInsert");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_FLOAT);
      VM.NWNX.Call();
    }

    public static void Array_Insert_Int(uint obj, string tag, int index, int element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayInsert");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_INTEGER);
      VM.NWNX.Call();
    }

    public static void Array_Insert_Obj(uint obj, string tag, int index, uint element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayInsert");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_OBJECT);
      VM.NWNX.Call();
    }

    public static void Array_Insert_Str(uint obj, string tag, int index, string element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayInsert");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_STRING);
      VM.NWNX.Call();
    }

    /// @defgroup data_array_pushback Array Pushback
    /// Pushes an element to the back of the collection.
    /// @remark Functionally identical to an insert at index size-1.
    /// @ingroup data
    /// <param name="obj">The object.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="element">The element.</param>

    public static void Array_PushBack_Flt(uint obj, string tag, float element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayPushBack");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_FLOAT);
      VM.NWNX.Call();
    }

    public static void Array_PushBack_Int(uint obj, string tag, int element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayPushBack");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_INTEGER);
      VM.NWNX.Call();
    }

    public static void Array_PushBack_Obj(uint obj, string tag, uint element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayPushBack");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_OBJECT);
      VM.NWNX.Call();
    }

    public static void Array_PushBack_Str(uint obj, string tag, string element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayPushBack");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_STRING);
      VM.NWNX.Call();
    }

    /// Resizes the array. If the array is shrinking, it chops off elements at the ned.
    public static void Array_Resize(int type, uint obj, string tag, int size)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayResize");
      VM.NWNX.StackPush(size);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// Reorders the array such each possible permutation of elements has equal probability of appearance.
    public static void Array_Shuffle(int type, uint obj, string tag)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArrayShuffle");
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// Returns the size of the array.
    public static int Array_Size(int type, uint obj, string tag)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySize");
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
      return VM.NWNX.StackPopInt();
    }

    /// Sorts the collection based on descending order.
    public static void Array_SortAscending(int type, uint obj, string tag)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySortAscending");
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// Sorts the collection based on descending order.
    public static void Array_SortDescending(int type, uint obj, string tag)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySortDescending");
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(type);
      VM.NWNX.Call();
    }

    /// @defgroup data_array_set Array Set
    /// Sets the element at the index, where size > index >= 0.
    /// @ingroup data
    /// <param name="obj">The object.</param>
    /// <param name="tag">The tag.</param>
    /// <param name="index">The index.</param>
    /// <param name="element">The element.</param>

    public static void Array_Set_Flt(uint obj, string tag, int index, float element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySet");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_FLOAT);
      VM.NWNX.Call();
    }

    public static void Array_Set_Int(uint obj, string tag, int index, int element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySet");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_INTEGER);
      VM.NWNX.Call();
    }

    public static void Array_Set_Obj(uint obj, string tag, int index, uint element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySet");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_OBJECT);
      VM.NWNX.Call();
    }

    public static void Array_Set_Str(uint obj, string tag, int index, string element)
    {
      VM.NWNX.SetFunction(NWNX_Data, "ArraySet");
      VM.NWNX.StackPush(element);
      VM.NWNX.StackPush(index);
      VM.NWNX.StackPush(tag);
      VM.NWNX.StackPush(obj);
      VM.NWNX.StackPush(NWNX_DATA_TYPE_STRING);
      VM.NWNX.Call();
    }
  }
}
