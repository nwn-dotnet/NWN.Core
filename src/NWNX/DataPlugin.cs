using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_Data)]
    public class DataPlugin
    {
        public const string NWNX_Data = "NWNX_Data";

        // /< @private
        public const int NWNX_DATA_INVALID_INDEX = -1;
        public const int NWNX_DATA_TYPE_FLOAT = 0;
        public const int NWNX_DATA_TYPE_INTEGER = 1;
        public const int NWNX_DATA_TYPE_OBJECT = 2;
        public const int NWNX_DATA_TYPE_STRING = 3;

        // / @defgroup data_array_at Array At
        // / @brief Returns the element at the index.
        // / @ingroup data
        // / @param obj The object.
        // / @param tag The tag.
        // / @param index The index.
        // / @return The element of associated type.
        // / @{
        public static float Array_At_Flt(uint obj, string tag, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Flt");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopFloat();
        }

        public static int Array_At_Int(uint obj, string tag, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Int");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static uint Array_At_Obj(uint obj, string tag, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Obj");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopObject();
        }

        public static string Array_At_Str(uint obj, string tag, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Str");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @}
        // / Clears the entire array, such that size==0.
        public static void Array_Clear(int type, uint obj, string tag)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Clear");
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @defgroup data_array_contains Array Contains
        // / @brief Checks if array contains the element.
        // / @ingroup data
        // / @param obj The object.
        // / @param tag The tag.
        // / @param element The element.
        // / @return TRUE if the collection contains the element.
        // / @{
        public static int Array_Contains_Flt(uint obj, string tag, float element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Flt");
            Internal.NativeFunctions.nwnxPushFloat(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static int Array_Contains_Int(uint obj, string tag, int element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Int");
            Internal.NativeFunctions.nwnxPushInt(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static int Array_Contains_Obj(uint obj, string tag, uint element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Obj");
            Internal.NativeFunctions.nwnxPushObject(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static int Array_Contains_Str(uint obj, string tag, string element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Str");
            Internal.NativeFunctions.nwnxPushString(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @}
        // / Copies the array of name otherTag over the array of name tag.
        public static void Array_Copy(int type, uint obj, string tag, string otherTag)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Copy");
            Internal.NativeFunctions.nwnxPushString(otherTag);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / Erases the element at index, and shuffles any elements from index size-1 to index + 1 left.
        public static void Array_Erase(int type, uint obj, string tag, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Erase");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @defgroup data_array_find Array Find
        // / @brief Get the index at which the element is located.
        // / @ingroup data
        // / @param obj The object.
        // / @param tag The tag.
        // / @param element The element.
        // / @return Returns the index at which the element is located, or ARRAY_INVALID_INDEX.
        // / @{
        public static int Array_Find_Flt(uint obj, string tag, float element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Flt");
            Internal.NativeFunctions.nwnxPushFloat(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static int Array_Find_Int(uint obj, string tag, int element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Int");
            Internal.NativeFunctions.nwnxPushInt(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static int Array_Find_Obj(uint obj, string tag, uint element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Obj");
            Internal.NativeFunctions.nwnxPushObject(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        public static int Array_Find_Str(uint obj, string tag, string element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Str");
            Internal.NativeFunctions.nwnxPushString(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @}
        // / @defgroup data_array_insert Array Insert
        // / @brief Inserts the element at the index, where size > index >= 0.
        // / @ingroup data
        // / @param obj The object.
        // / @param tag The tag.
        // / @param index The index.
        // / @param element The element.
        // / @{
        public static void Array_Insert_Flt(uint obj, string tag, int index, float element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Flt");
            Internal.NativeFunctions.nwnxPushFloat(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_Insert_Int(uint obj, string tag, int index, int element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Int");
            Internal.NativeFunctions.nwnxPushInt(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_Insert_Obj(uint obj, string tag, int index, uint element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Obj");
            Internal.NativeFunctions.nwnxPushObject(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_Insert_Str(uint obj, string tag, int index, string element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Str");
            Internal.NativeFunctions.nwnxPushString(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
        // / @defgroup data_array_pushback Array Pushback
        // / @brief Pushes an element to the back of the collection.
        // / @remark Functionally identical to an insert at index size-1.
        // / @ingroup data
        // / @param obj The object.
        // / @param tag The tag.
        // / @param element The element.
        // / @{
        public static void Array_PushBack_Flt(uint obj, string tag, float element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Flt");
            Internal.NativeFunctions.nwnxPushFloat(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_PushBack_Int(uint obj, string tag, int element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Int");
            Internal.NativeFunctions.nwnxPushInt(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_PushBack_Obj(uint obj, string tag, uint element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Obj");
            Internal.NativeFunctions.nwnxPushObject(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_PushBack_Str(uint obj, string tag, string element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Str");
            Internal.NativeFunctions.nwnxPushString(element);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
        // / Resizes the array. If the array is shrinking, it chops off elements at the ned.
        public static void Array_Resize(int type, uint obj, string tag, int size)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Resize");
            Internal.NativeFunctions.nwnxPushInt(size);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / Reorders the array such each possible permutation of elements has equal probability of appearance.
        public static void Array_Shuffle(int type, uint obj, string tag)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Shuffle");
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / Returns the size of the array.
        public static int Array_Size(int type, uint obj, string tag)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Size");
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / Sorts the collection based on descending order.
        public static void Array_SortAscending(int type, uint obj, string tag)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "SortAscending");
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / Sorts the collection based on descending order.
        public static void Array_SortDescending(int type, uint obj, string tag)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "SortDescending");
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxPushInt(type);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @defgroup data_array_set Array Set
        // / @brief Sets the element at the index, where size > index >= 0.
        // / @ingroup data
        // / @param obj The object.
        // / @param tag The tag.
        // / @param index The index.
        // / @param element The element.
        // / @{
        public static void Array_Set_Flt(uint obj, string tag, int index, float element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Flt");
            Internal.NativeFunctions.nwnxPushFloat(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_Set_Int(uint obj, string tag, int index, int element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Int");
            Internal.NativeFunctions.nwnxPushInt(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_Set_Obj(uint obj, string tag, int index, uint element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Obj");
            Internal.NativeFunctions.nwnxPushObject(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        public static void Array_Set_Str(uint obj, string tag, int index, string element)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Data, "Str");
            Internal.NativeFunctions.nwnxPushString(element);
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushString(tag);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @}
        // / @}
    }
}
