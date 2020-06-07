using NWN;

namespace NWNX
{
    [NWNXPlugin(NWNX_Object)]
    public class ObjectPlugin
    {
        public const string NWNX_Object = "NWNX_Object";

        // /< @private
        // / @anchor object_localvar_types
        // / @name Local Variable Types
        // / @{
        public const int NWNX_OBJECT_LOCALVAR_TYPE_INT = 1;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_FLOAT = 2;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_STRING = 3;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_OBJECT = 4;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_LOCATION = 5;

        // / @}
        // / @anchor object_internal_types
        // / @name Internal Object Types
        // / @{
        public const int NWNX_OBJECT_TYPE_INTERNAL_INVALID = -1;
        public const int NWNX_OBJECT_TYPE_INTERNAL_GUI = 1;
        public const int NWNX_OBJECT_TYPE_INTERNAL_TILE = 2;
        public const int NWNX_OBJECT_TYPE_INTERNAL_MODULE = 3;
        public const int NWNX_OBJECT_TYPE_INTERNAL_AREA = 4;
        public const int NWNX_OBJECT_TYPE_INTERNAL_CREATURE = 5;
        public const int NWNX_OBJECT_TYPE_INTERNAL_ITEM = 6;
        public const int NWNX_OBJECT_TYPE_INTERNAL_TRIGGER = 7;
        public const int NWNX_OBJECT_TYPE_INTERNAL_PROJECTILE = 8;
        public const int NWNX_OBJECT_TYPE_INTERNAL_PLACEABLE = 9;
        public const int NWNX_OBJECT_TYPE_INTERNAL_DOOR = 10;
        public const int NWNX_OBJECT_TYPE_INTERNAL_AREAOFEFFECT = 11;
        public const int NWNX_OBJECT_TYPE_INTERNAL_WAYPOINT = 12;
        public const int NWNX_OBJECT_TYPE_INTERNAL_ENCOUNTER = 13;
        public const int NWNX_OBJECT_TYPE_INTERNAL_STORE = 14;
        public const int NWNX_OBJECT_TYPE_INTERNAL_PORTAL = 15;
        public const int NWNX_OBJECT_TYPE_INTERNAL_SOUND = 16;

        // / @}
        // / A local variable structure.
        // / @brief Gets the count of all local variables.
        // / @param obj The object.
        // / @return The count.
        public static int GetLocalVariableCount(uint obj)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetLocalVariableCount");
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the local variable at the provided index of the provided object.
        // / @param obj The object.
        // / @param index The index.
        // / @note Index bounds: 0 >= index < NWNX_Object_GetLocalVariableCount().
        // / @return An NWNX_Object_LocalVariable struct.
        public static LocalVariable GetLocalVariable(uint obj, int index)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetLocalVariable");
            Internal.NativeFunctions.nwnxPushInt(index);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            LocalVariable retVal;
            retVal.key = Internal.NativeFunctions.nwnxPopString();
            retVal.type = Internal.NativeFunctions.nwnxPopInt();
            return retVal;
        }

        // / @brief Convert an object id to the actual object.
        // / @param id The object id.
        // / @return An object from the provided object ID.
        // / @remark This is the counterpart to ObjectToString.
        public static uint StringToObject(string id)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "StringToObject");
            Internal.NativeFunctions.nwnxPushString(id);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopObject();
        }

        // / @brief Set an object's position.
        // / @param obj The object.
        // / @param pos A vector position.
        public static void SetPosition(uint obj, System.Numerics.Vector3 pos)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetPosition");
            Internal.NativeFunctions.nwnxPushFloat(pos.Z);
            Internal.NativeFunctions.nwnxPushFloat(pos.Y);
            Internal.NativeFunctions.nwnxPushFloat(pos.X);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set an object's hit points.
        // / @param obj The object.
        // / @param hp The hit points.
        public static void SetCurrentHitPoints(uint obj, int hp)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetCurrentHitPoints");
            Internal.NativeFunctions.nwnxPushInt(hp);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Adjust an object's maximum hit points
        // / @note Will not work on PCs.
        // / @param obj The object.
        // / @param hp The maximum hit points.
        public static void SetMaxHitPoints(uint obj, int hp)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetMaxHitPoints");
            Internal.NativeFunctions.nwnxPushInt(hp);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Serialize a full object to a base64 string
        // / @param obj The object.
        // / @return A base64 string representation of the object.
        // / @note includes locals, inventory, etc
        public static string Serialize(uint obj)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "Serialize");
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Deserialize the object.
        // / @note The object will be created outside of the world and needs to be manually positioned at a location/inventory.
        // / @param serialized The base64 string.
        // / @return The object.
        public static uint Deserialize(string serialized)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "Deserialize");
            Internal.NativeFunctions.nwnxPushString(serialized);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopObject();
        }

        // / @brief Gets the dialog resref.
        // / @param obj The object.
        // / @return The name of the dialog resref.
        public static string GetDialogResref(uint obj)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetDialogResref");
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Sets the dialog resref.
        // / @param obj The object.
        // / @param dialog The name of the dialog resref.
        public static void SetDialogResref(uint obj, string dialog)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetDialogResref");
            Internal.NativeFunctions.nwnxPushString(dialog);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Set oPlaceable's appearance.
        // / @note Will not update for PCs until they re-enter the area.
        // / @param oPlaceable The placeable.
        // / @param nAppearance The appearance id.
        public static void SetAppearance(uint oPlaceable, int nAppearance)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetAppearance");
            Internal.NativeFunctions.nwnxPushInt(nAppearance);
            Internal.NativeFunctions.nwnxPushObject(oPlaceable);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oPlaceable's appearance.
        // / @param oPlaceable The placeable.
        // / @return The appearance id.
        public static int GetAppearance(uint oPlaceable)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetAppearance");
            Internal.NativeFunctions.nwnxPushObject(oPlaceable);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Determine if an object has a visual effect.
        // / @param obj The object.
        // / @param nVFX The visual effect id.
        // / @return TRUE if the object has the visual effect applied to it
        public static int GetHasVisualEffect(uint obj, int nVFX)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetHasVisualEffect");
            Internal.NativeFunctions.nwnxPushInt(nVFX);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Check if an item can fit in an object's inventory.
        // / @param obj The object with an inventory.
        // / @param baseitem The base item id to check for a fit.
        // / @return TRUE if an item of base item type can fit in object's inventory
        public static int CheckFit(uint obj, int baseitem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "CheckFit");
            Internal.NativeFunctions.nwnxPushInt(baseitem);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get an object's damage immunity.
        // / @param obj The object.
        // / @param damageType The damage type to check for immunity. Use DAMAGE_TYPE_* constants.
        // / @return Damage immunity as a percentage.
        public static int GetDamageImmunity(uint obj, int damageType)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetDamageImmunity");
            Internal.NativeFunctions.nwnxPushInt(damageType);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Add or move an object.
        // / @param obj The object.
        // / @param area The area.
        // / @param pos The position.
        public static void AddToArea(uint obj, uint area, System.Numerics.Vector3 pos)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "AddToArea");
            Internal.NativeFunctions.nwnxPushFloat(pos.Z);
            Internal.NativeFunctions.nwnxPushFloat(pos.Y);
            Internal.NativeFunctions.nwnxPushFloat(pos.X);
            Internal.NativeFunctions.nwnxPushObject(area);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get placeable's static setting
        // / @param obj The object.
        // / @return TRUE if placeable is static.
        public static int GetPlaceableIsStatic(uint obj)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetPlaceableIsStatic");
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set placeable as static or not.
        // / @note Will not update for PCs until they re-enter the area.
        // / @param obj The object.
        // / @param isStatic TRUE/FALSE
        public static void SetPlaceableIsStatic(uint obj, int isStatic)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetPlaceableIsStatic");
            Internal.NativeFunctions.nwnxPushInt(isStatic);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Gets if a door/placeable auto-removes the key after use.
        // / @param obj The object.
        // / @return TRUE/FALSE or -1 on error.
        public static int GetAutoRemoveKey(uint obj)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetAutoRemoveKey");
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Sets if a door/placeable auto-removes the key after use.
        // / @param obj The object.
        // / @param bRemoveKey TRUE/FALSE
        public static void SetAutoRemoveKey(uint obj, int bRemoveKey)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetAutoRemoveKey");
            Internal.NativeFunctions.nwnxPushInt(bRemoveKey);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get the geometry of a trigger
        // / @param oTrigger The trigger object.
        // / @return A string of vertex positions.
        public static string GetTriggerGeometry(uint oTrigger)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetTriggerGeometry");
            Internal.NativeFunctions.nwnxPushObject(oTrigger);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Set the geometry of a trigger with a list of vertex positions
        // / @param oTrigger The trigger object.
        // / @param sGeometry Needs to be in the following format -> {x.x, y.y, z.z} or {x.x, y.y}
        // / Example Geometry: "{1.0, 1.0, 0.0}{4.0, 1.0, 0.0}{4.0, 4.0, 0.0}{1.0, 4.0, 0.0}"
        // /
        // / @remark The Z position is optional and will be calculated dynamically based
        // / on terrain height if it's not provided.
        // /
        // / @remark The minimum number of vertices is 3.
        public static void SetTriggerGeometry(uint oTrigger, string sGeometry)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetTriggerGeometry");
            Internal.NativeFunctions.nwnxPushString(sGeometry);
            Internal.NativeFunctions.nwnxPushObject(oTrigger);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Add an effect to an object that displays an icon and has no other effect.
        // / @remark See effecticons.2da for a list of possible effect icons.
        // / @param obj The object to apply the effect.
        // / @param nIcon The icon id.
        // / @param fDuration If specified the effect will be temporary and last this length in seconds, otherwise the effect
        // / will be permanent.
        public static void AddIconEffect(uint obj, int nIcon, float fDuration = 0.0f)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "AddIconEffect");
            Internal.NativeFunctions.nwnxPushFloat(fDuration);
            Internal.NativeFunctions.nwnxPushInt(nIcon);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Remove an icon effect from an object that was added by the NWNX_Object_AddIconEffect() function.
        // / @param obj The object.
        // / @param nIcon The icon id.
        public static void RemoveIconEffect(uint obj, int nIcon)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "RemoveIconEffect");
            Internal.NativeFunctions.nwnxPushInt(nIcon);
            Internal.NativeFunctions.nwnxPushObject(obj);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Export an object to the UserDirectory/nwnx folder.
        // / @param sFileName The filename without extension, 16 or less characters.
        // / @param oObject The object to export. Valid object types: Creature, Item, Placeable, Waypoint, Door, Store, Trigger
        public static void Export(string sFileName, uint oObject)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "Export");
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxPushString(sFileName);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oObject's persistent integer variable sVarName.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @return The value or 0 on error.
        // / @deprecated Please use NWNX_Object_GetInt()
        public static int GetPersistentInt(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetPersistentInt");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set oObject's persistent integer variable sVarName to nValue.
        // / @note The value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @param nValue The integer value to to set
        // / @deprecated Please use NWNX_Object_SetInt()
        public static void SetPersistentInt(uint oObject, string sVarName, int nValue)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetPersistentInt");
            Internal.NativeFunctions.nwnxPushInt(nValue);
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete oObject's persistent integer variable sVarName.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @deprecated Please use NWNX_Object_DeleteInt()
        public static void DeletePersistentInt(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeletePersistentInt");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oObject's persistent string variable sVarName.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @return The value or "" on error.
        // / @deprecated Please use NWNX_Object_GetString()
        public static string GetPersistentString(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetPersistentString");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Set oObject's persistent string variable sVarName to sValue.
        // / @note The value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @param sValue The string value to to set
        // / @deprecated Please use NWNX_Object_SetString()
        public static void SetPersistentString(uint oObject, string sVarName, string sValue)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetPersistentString");
            Internal.NativeFunctions.nwnxPushString(sValue);
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete oObject's persistent string variable sVarName.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @deprecated Please use NWNX_Object_DeleteString()
        public static void DeletePersistentString(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeletePersistentString");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oObject's persistent float variable sVarName.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @return The value or 0.0f on error.
        // / @deprecated Please use NWNX_Object_GetFloat()
        public static float GetPersistentFloat(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetPersistentFloat");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopFloat();
        }

        // / @brief Set oObject's persistent float variable sVarName to fValue.
        // / @note The value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @param fValue The float value to to set
        // / @deprecated Please use NWNX_Object_SetFloat()
        public static void SetPersistentFloat(uint oObject, string sVarName, float fValue)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetPersistentFloat");
            Internal.NativeFunctions.nwnxPushFloat(fValue);
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete oObject's persistent float variable sVarName.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @deprecated Please use NWNX_Object_DeleteFloat()
        public static void DeletePersistentFloat(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeletePersistentFloat");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oObject's integer variable sVarName.
        // / @param oObject The object to get the variable from.
        // / @param sVarName The variable name.
        // / @return The value or 0 on error.
        public static int GetInt(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetInt");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Set oObject's integer variable sVarName to nValue.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @param nValue The integer value to to set
        // / @param bPersist When TRUE, the value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        public static void SetInt(uint oObject, string sVarName, int nValue, int bPersist)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetInt");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushInt(nValue);
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete oObject's integer variable sVarName.
        // / @param oObject The object to delete the variable from.
        // / @param sVarName The variable name.
        public static void DeleteInt(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeleteInt");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oObject's string variable sVarName.
        // / @param oObject The object to get the variable from.
        // / @param sVarName The variable name.
        // / @return The value or "" on error.
        public static string GetString(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetString");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Set oObject's string variable sVarName to sValue.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @param sValue The string value to to set
        // / @param bPersist When TRUE, the value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        public static void SetString(uint oObject, string sVarName, string sValue, int bPersist)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetString");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushString(sValue);
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete oObject's string variable sVarName.
        // / @param oObject The object to delete the variable from.
        // / @param sVarName The variable name.
        public static void DeleteString(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeleteString");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get oObject's float variable sVarName.
        // / @param oObject The object to get the variable from.
        // / @param sVarName The variable name.
        // / @return The value or 0.0f on error.
        public static float GetFloat(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetFloat");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopFloat();
        }

        // / @brief Set oObject's float variable sVarName to fValue.
        // / @param oObject The object to set the variable on.
        // / @param sVarName The variable name.
        // / @param fValue The float value to to set
        // / @param bPersist When TRUE, the value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        public static void SetFloat(uint oObject, string sVarName, float fValue, int bPersist)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetFloat");
            Internal.NativeFunctions.nwnxPushInt(bPersist);
            Internal.NativeFunctions.nwnxPushFloat(fValue);
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete oObject's persistent float variable sVarName.
        // / @param oObject The object to delete the variable from.
        // / @param sVarName The variable name.
        public static void DeleteFloat(uint oObject, string sVarName)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeleteFloat");
            Internal.NativeFunctions.nwnxPushString(sVarName);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Delete any variables that match sRegex
        // / @note It will only remove variables set by NWNX_Object_Set{Int|String|Float}()
        // / @param oObject The object to delete the variables from.
        // / @param sRegex The regular expression, for example .*Test.* removes every variable that has Test in it.
        public static void DeleteVarRegex(uint oObject, string sRegex)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "DeleteVarRegex");
            Internal.NativeFunctions.nwnxPushString(sRegex);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Get if vPosition is inside oTrigger's geometry.
        // / @note The Z value of vPosition is ignored.
        // / @param oTrigger The trigger.
        // / @param vPosition The position.
        // / @return TRUE if vPosition is inside oTrigger's geometry.
        public static int GetPositionIsInTrigger(uint oTrigger, System.Numerics.Vector3 vPosition)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetPositionIsInTrigger");
            Internal.NativeFunctions.nwnxPushFloat(vPosition.Z);
            Internal.NativeFunctions.nwnxPushFloat(vPosition.Y);
            Internal.NativeFunctions.nwnxPushFloat(vPosition.X);
            Internal.NativeFunctions.nwnxPushObject(oTrigger);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Gets the given object's internal type (NWNX_OBJECT_TYPE_INTERNAL_*)
        // / @param oObject The object.
        // / @return The object's type (NWNX_OBJECT_TYPE_INTERNAL_*)
        public static int GetInternalObjectType(uint oObject)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetInternalObjectType");
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Have oObject acquire oItem.
        // / @note Useful to give deserialized items to an object, may not work if oItem is already possessed by an object.
        // / @param oObject The object receiving oItem, must be a Creature, Placeable, Store or Item
        // / @param oItem The item.
        // / @return TRUE on success.
        public static int AcquireItem(uint oObject, uint oItem)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "AcquireItem");
            Internal.NativeFunctions.nwnxPushObject(oItem);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Cause oObject to face fDirection.
        // / @note This function is almost identical to SetFacing(), the only difference being that it allows you to specify
        // / the target object without the use of AssignCommand(). This is useful when you want to change the facing of an object
        // / in an ExecuteScriptChunk() call where AssignCommand() does not work.
        // / @param oObject The object to change its facing of
        // / @param fDirection The direction the object should face
        public static void SetFacing(uint oObject, float fDirection)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "SetFacing");
            Internal.NativeFunctions.nwnxPushFloat(fDirection);
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Clear all spell effects oObject has applied to others.
        // / @param oObject The object that applied the spell effects.
        public static void ClearSpellEffectsOnOthers(uint oObject)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "ClearSpellEffectsOnOthers");
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
        }

        // / @brief Peek at the UUID of oObject without assigning one if it does not have one
        // / @param oObject The object
        // / @return The UUID or "" when the object does not have or cannot have an UUID
        public static string PeekUUID(uint oObject)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "PeekUUID");
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopString();
        }

        // / @brief Get if oDoor has a visible model.
        // / @param oDoor The door
        // / @return TRUE if oDoor has a visible model
        public static int GetDoorHasVisibleModel(uint oDoor)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetDoorHasVisibleModel");
            Internal.NativeFunctions.nwnxPushObject(oDoor);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @brief Get if oObject is destroyable.
        // / @param oObject The object
        // / @return TRUE if oObject is destroyable.
        public static int GetIsDestroyable(uint oObject)
        {
            Internal.NativeFunctions.nwnxSetFunction(NWNX_Object, "GetIsDestroyable");
            Internal.NativeFunctions.nwnxPushObject(oObject);
            Internal.NativeFunctions.nwnxCallFunction();
            return Internal.NativeFunctions.nwnxPopInt();
        }

        // / @}
    }

        public struct LocalVariable
        {
            public int type;
            public string key;
        }
}
