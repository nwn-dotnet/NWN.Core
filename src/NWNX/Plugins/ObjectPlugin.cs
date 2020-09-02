namespace NWN.Core.NWNX
{
    [NWNXPlugin(NWNX_Object)]
    public class ObjectPlugin
    {
        public const string NWNX_Object = "NWNX_Object";

        ///< @private
        /// @anchor object_localvar_types
        /// @name Local Variable Types
        /// @{
        public const int NWNX_OBJECT_LOCALVAR_TYPE_INT = 1;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_FLOAT = 2;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_STRING = 3;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_OBJECT = 4;
        public const int NWNX_OBJECT_LOCALVAR_TYPE_LOCATION = 5;

        /// @}
        /// @anchor object_internal_types
        /// @name Internal Object Types
        /// @{
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

        /// @}
        /// A local variable structure.
        /// Gets the count of all local variables.
        /// <param name="obj">The object.</param>
        /// <returns>The count.</returns>
        public static int GetLocalVariableCount(uint obj)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetLocalVariableCount");
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Gets the local variable at the provided index of the provided object.
        /// <param name="obj">The object.</param>
        /// <param name="index">The index.</param>
        /// @note Index bounds: 0 >= index < NWNX_Object_GetLocalVariableCount().
        /// <returns>An NWNX_Object_LocalVariable struct.</returns>
        public static LocalVariable GetLocalVariable(uint obj, int index)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetLocalVariable");
            VM.NWNX.StackPush(index);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            LocalVariable retVal;
            retVal.key = VM.NWNX.StackPopString();
            retVal.type = VM.NWNX.StackPopInt();
            return retVal;
        }

        /// Convert an object id to the actual object.
        /// <param name="id">The object id.</param>
        /// <returns>An object from the provided object ID.</returns>
        /// @remark This is the counterpart to ObjectToString.
        public static uint StringToObject(string id)
        {
            VM.NWNX.SetFunction(NWNX_Object, "StringToObject");
            VM.NWNX.StackPush(id);
            VM.NWNX.Call();
            return VM.NWNX.StackPopObject();
        }

        /// Set an object's position.
        /// <param name="obj">The object.</param>
        /// <param name="pos">A vector position.</param>
        public static void SetPosition(uint obj, System.Numerics.Vector3 pos)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetPosition");
            VM.NWNX.StackPush(pos);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Set an object's hit points.
        /// <param name="obj">The object.</param>
        /// <param name="hp">The hit points.</param>
        public static void SetCurrentHitPoints(uint obj, int hp)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetCurrentHitPoints");
            VM.NWNX.StackPush(hp);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Adjust an object's maximum hit points
        /// @note Will not work on PCs.
        /// <param name="obj">The object.</param>
        /// <param name="hp">The maximum hit points.</param>
        public static void SetMaxHitPoints(uint obj, int hp)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetMaxHitPoints");
            VM.NWNX.StackPush(hp);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Serialize a full object to a base64 string
        /// <param name="obj">The object.</param>
        /// <returns>A base64 string representation of the object.</returns>
        /// @note includes locals, inventory, etc
        public static string Serialize(uint obj)
        {
            VM.NWNX.SetFunction(NWNX_Object, "Serialize");
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Deserialize the object.
        /// @note The object will be created outside of the world and needs to be manually positioned at a location/inventory.
        /// <param name="serialized">The base64 string.</param>
        /// <returns>The object.</returns>
        public static uint Deserialize(string serialized)
        {
            VM.NWNX.SetFunction(NWNX_Object, "Deserialize");
            VM.NWNX.StackPush(serialized);
            VM.NWNX.Call();
            return VM.NWNX.StackPopObject();
        }

        /// Gets the dialog resref.
        /// <param name="obj">The object.</param>
        /// <returns>The name of the dialog resref.</returns>
        public static string GetDialogResref(uint obj)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetDialogResref");
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Sets the dialog resref.
        /// <param name="obj">The object.</param>
        /// <param name="dialog">The name of the dialog resref.</param>
        public static void SetDialogResref(uint obj, string dialog)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetDialogResref");
            VM.NWNX.StackPush(dialog);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Set oPlaceable's appearance.
        /// @note Will not update for PCs until they re-enter the area.
        /// <param name="oPlaceable">The placeable.</param>
        /// <param name="nAppearance">The appearance id.</param>
        public static void SetAppearance(uint oPlaceable, int nAppearance)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetAppearance");
            VM.NWNX.StackPush(nAppearance);
            VM.NWNX.StackPush(oPlaceable);
            VM.NWNX.Call();
        }

        /// Get oPlaceable's appearance.
        /// <param name="oPlaceable">The placeable.</param>
        /// <returns>The appearance id.</returns>
        public static int GetAppearance(uint oPlaceable)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetAppearance");
            VM.NWNX.StackPush(oPlaceable);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Determine if an object has a visual effect.
        /// <param name="obj">The object.</param>
        /// <param name="nVFX">The visual effect id.</param>
        /// <returns>TRUE if the object has the visual effect applied to it</returns>
        public static int GetHasVisualEffect(uint obj, int nVFX)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetHasVisualEffect");
            VM.NWNX.StackPush(nVFX);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Check if an item can fit in an object's inventory.
        /// <param name="obj">The object with an inventory.</param>
        /// <param name="baseitem">The base item id to check for a fit.</param>
        /// <returns>TRUE if an item of base item type can fit in object's inventory</returns>
        public static int CheckFit(uint obj, int baseitem)
        {
            VM.NWNX.SetFunction(NWNX_Object, "CheckFit");
            VM.NWNX.StackPush(baseitem);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Get an object's damage immunity.
        /// <param name="obj">The object.</param>
        /// <param name="damageType">The damage type to check for immunity. Use DAMAGE_TYPE_* constants.</param>
        /// <returns>Damage immunity as a percentage.</returns>
        public static int GetDamageImmunity(uint obj, int damageType)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetDamageImmunity");
            VM.NWNX.StackPush(damageType);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Add or move an object.
        /// <param name="obj">The object.</param>
        /// <param name="area">The area.</param>
        /// <param name="pos">The position.</param>
        public static void AddToArea(uint obj, uint area, System.Numerics.Vector3 pos)
        {
            VM.NWNX.SetFunction(NWNX_Object, "AddToArea");
            VM.NWNX.StackPush(pos);
            VM.NWNX.StackPush(area);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Get placeable's static setting
        /// <param name="obj">The object.</param>
        /// <returns>TRUE if placeable is static.</returns>
        public static int GetPlaceableIsStatic(uint obj)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetPlaceableIsStatic");
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set placeable as static or not.
        /// @note Will not update for PCs until they re-enter the area.
        /// <param name="obj">The object.</param>
        /// <param name="isStatic">TRUE/FALSE</param>
        public static void SetPlaceableIsStatic(uint obj, int isStatic)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetPlaceableIsStatic");
            VM.NWNX.StackPush(isStatic);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Gets if a door/placeable auto-removes the key after use.
        /// <param name="obj">The object.</param>
        /// <returns>TRUE/FALSE or -1 on error.</returns>
        public static int GetAutoRemoveKey(uint obj)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetAutoRemoveKey");
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Sets if a door/placeable auto-removes the key after use.
        /// <param name="obj">The object.</param>
        /// <param name="bRemoveKey">TRUE/FALSE</param>
        public static void SetAutoRemoveKey(uint obj, int bRemoveKey)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetAutoRemoveKey");
            VM.NWNX.StackPush(bRemoveKey);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Get the geometry of a trigger
        /// <param name="oTrigger">The trigger object.</param>
        /// <returns>A string of vertex positions.</returns>
        public static string GetTriggerGeometry(uint oTrigger)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetTriggerGeometry");
            VM.NWNX.StackPush(oTrigger);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Set the geometry of a trigger with a list of vertex positions
        /// <param name="oTrigger">The trigger object.</param>
        /// <param name="sGeometry">Needs to be in the following format -> {x.x, y.y, z.z} or {x.x, y.y}</param>
        /// Example Geometry: "{1.0, 1.0, 0.0}{4.0, 1.0, 0.0}{4.0, 4.0, 0.0}{1.0, 4.0, 0.0}"
        ///
        /// @remark The Z position is optional and will be calculated dynamically based
        /// on terrain height if it's not provided.
        ///
        /// @remark The minimum number of vertices is 3.
        public static void SetTriggerGeometry(uint oTrigger, string sGeometry)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetTriggerGeometry");
            VM.NWNX.StackPush(sGeometry);
            VM.NWNX.StackPush(oTrigger);
            VM.NWNX.Call();
        }

        /// Add an effect to an object that displays an icon and has no other effect.
        /// @remark See effecticons.2da for a list of possible effect icons.
        /// <param name="obj">The object to apply the effect.</param>
        /// <param name="nIcon">The icon id.</param>
        /// <param name="fDuration">If specified the effect will be temporary and last this length in seconds, otherwise the effect</param>
        /// will be permanent.
        public static void AddIconEffect(uint obj, int nIcon, float fDuration = 0.0f)
        {
            VM.NWNX.SetFunction(NWNX_Object, "AddIconEffect");
            VM.NWNX.StackPush(fDuration);
            VM.NWNX.StackPush(nIcon);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Remove an icon effect from an object that was added by the NWNX_Object_AddIconEffect() function.
        /// <param name="obj">The object.</param>
        /// <param name="nIcon">The icon id.</param>
        public static void RemoveIconEffect(uint obj, int nIcon)
        {
            VM.NWNX.SetFunction(NWNX_Object, "RemoveIconEffect");
            VM.NWNX.StackPush(nIcon);
            VM.NWNX.StackPush(obj);
            VM.NWNX.Call();
        }

        /// Export an object to the UserDirectory/nwnx folder.
        /// <param name="sFileName">The filename without extension, 16 or less characters.</param>
        /// <param name="oObject">The object to export. Valid object types: Creature, Item, Placeable, Waypoint, Door, Store, Trigger</param>
        public static void Export(string sFileName, uint oObject)
        {
            VM.NWNX.SetFunction(NWNX_Object, "Export");
            VM.NWNX.StackPush(oObject);
            VM.NWNX.StackPush(sFileName);
            VM.NWNX.Call();
        }

        /// Get oObject's persistent integer variable sVarName.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <returns>The value or 0 on error.</returns>
        /// @deprecated Please use NWNX_Object_GetInt()
        public static int GetPersistentInt(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetPersistentInt");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set oObject's persistent integer variable sVarName to nValue.
        /// @note The value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <param name="nValue">The integer value to to set</param>
        /// @deprecated Please use NWNX_Object_SetInt()
        public static void SetPersistentInt(uint oObject, string sVarName, int nValue)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetPersistentInt");
            VM.NWNX.StackPush(nValue);
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete oObject's persistent integer variable sVarName.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// @deprecated Please use NWNX_Object_DeleteInt()
        public static void DeletePersistentInt(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeletePersistentInt");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Get oObject's persistent string variable sVarName.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <returns>The value or "" on error.</returns>
        /// @deprecated Please use NWNX_Object_GetString()
        public static string GetPersistentString(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetPersistentString");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Set oObject's persistent string variable sVarName to sValue.
        /// @note The value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <param name="sValue">The string value to to set</param>
        /// @deprecated Please use NWNX_Object_SetString()
        public static void SetPersistentString(uint oObject, string sVarName, string sValue)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetPersistentString");
            VM.NWNX.StackPush(sValue);
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete oObject's persistent string variable sVarName.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// @deprecated Please use NWNX_Object_DeleteString()
        public static void DeletePersistentString(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeletePersistentString");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Get oObject's persistent float variable sVarName.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <returns>The value or 0.0f on error.</returns>
        /// @deprecated Please use NWNX_Object_GetFloat()
        public static float GetPersistentFloat(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetPersistentFloat");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopFloat();
        }

        /// Set oObject's persistent float variable sVarName to fValue.
        /// @note The value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <param name="fValue">The float value to to set</param>
        /// @deprecated Please use NWNX_Object_SetFloat()
        public static void SetPersistentFloat(uint oObject, string sVarName, float fValue)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetPersistentFloat");
            VM.NWNX.StackPush(fValue);
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete oObject's persistent float variable sVarName.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// @deprecated Please use NWNX_Object_DeleteFloat()
        public static void DeletePersistentFloat(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeletePersistentFloat");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Get oObject's integer variable sVarName.
        /// <param name="oObject">The object to get the variable from.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <returns>The value or 0 on error.</returns>
        public static int GetInt(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetInt");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Set oObject's integer variable sVarName to nValue.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <param name="nValue">The integer value to to set</param>
        /// <param name="bPersist">When TRUE, the value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.</param>
        public static void SetInt(uint oObject, string sVarName, int nValue, int bPersist)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetInt");
            VM.NWNX.StackPush(bPersist);
            VM.NWNX.StackPush(nValue);
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete oObject's integer variable sVarName.
        /// <param name="oObject">The object to delete the variable from.</param>
        /// <param name="sVarName">The variable name.</param>
        public static void DeleteInt(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeleteInt");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Get oObject's string variable sVarName.
        /// <param name="oObject">The object to get the variable from.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <returns>The value or "" on error.</returns>
        public static string GetString(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetString");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Set oObject's string variable sVarName to sValue.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <param name="sValue">The string value to to set</param>
        /// <param name="bPersist">When TRUE, the value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.</param>
        public static void SetString(uint oObject, string sVarName, string sValue, int bPersist)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetString");
            VM.NWNX.StackPush(bPersist);
            VM.NWNX.StackPush(sValue);
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete oObject's string variable sVarName.
        /// <param name="oObject">The object to delete the variable from.</param>
        /// <param name="sVarName">The variable name.</param>
        public static void DeleteString(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeleteString");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Get oObject's float variable sVarName.
        /// <param name="oObject">The object to get the variable from.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <returns>The value or 0.0f on error.</returns>
        public static float GetFloat(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetFloat");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopFloat();
        }

        /// Set oObject's float variable sVarName to fValue.
        /// <param name="oObject">The object to set the variable on.</param>
        /// <param name="sVarName">The variable name.</param>
        /// <param name="fValue">The float value to to set</param>
        /// <param name="bPersist">When TRUE, the value is persisted to GFF, this means that it'll be saved in the .bic file of a player's character or when an object is serialized.</param>
        public static void SetFloat(uint oObject, string sVarName, float fValue, int bPersist)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetFloat");
            VM.NWNX.StackPush(bPersist);
            VM.NWNX.StackPush(fValue);
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete oObject's persistent float variable sVarName.
        /// <param name="oObject">The object to delete the variable from.</param>
        /// <param name="sVarName">The variable name.</param>
        public static void DeleteFloat(uint oObject, string sVarName)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeleteFloat");
            VM.NWNX.StackPush(sVarName);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Delete any variables that match sRegex
        /// @note It will only remove variables set by NWNX_Object_Set{Int|String|Float}()
        /// <param name="oObject">The object to delete the variables from.</param>
        /// <param name="sRegex">The regular expression, for example .*Test.* removes every variable that has Test in it.</param>
        public static void DeleteVarRegex(uint oObject, string sRegex)
        {
            VM.NWNX.SetFunction(NWNX_Object, "DeleteVarRegex");
            VM.NWNX.StackPush(sRegex);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Get if vPosition is inside oTrigger's geometry.
        /// @note The Z value of vPosition is ignored.
        /// <param name="oTrigger">The trigger.</param>
        /// <param name="vPosition">The position.</param>
        /// <returns>TRUE if vPosition is inside oTrigger's geometry.</returns>
        public static int GetPositionIsInTrigger(uint oTrigger, System.Numerics.Vector3 vPosition)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetPositionIsInTrigger");
            VM.NWNX.StackPush(vPosition);
            VM.NWNX.StackPush(oTrigger);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Gets the given object's internal type (NWNX_OBJECT_TYPE_INTERNAL_*)
        /// <param name="oObject">The object.</param>
        /// <returns>The object's type (NWNX_OBJECT_TYPE_INTERNAL_*)</returns>
        public static int GetInternalObjectType(uint oObject)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetInternalObjectType");
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Have oObject acquire oItem.
        /// @note Useful to give deserialized items to an object, may not work if oItem is already possessed by an object.
        /// <param name="oObject">The object receiving oItem, must be a Creature, Placeable, Store or Item</param>
        /// <param name="oItem">The item.</param>
        /// <returns>TRUE on success.</returns>
        public static int AcquireItem(uint oObject, uint oItem)
        {
            VM.NWNX.SetFunction(NWNX_Object, "AcquireItem");
            VM.NWNX.StackPush(oItem);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Cause oObject to face fDirection.
        /// @note This function is almost identical to SetFacing(), the only difference being that it allows you to specify
        /// the target object without the use of AssignCommand(). This is useful when you want to change the facing of an object
        /// in an ExecuteScriptChunk() call where AssignCommand() does not work.
        /// <param name="oObject">The object to change its facing of</param>
        /// <param name="fDirection">The direction the object should face</param>
        public static void SetFacing(uint oObject, float fDirection)
        {
            VM.NWNX.SetFunction(NWNX_Object, "SetFacing");
            VM.NWNX.StackPush(fDirection);
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Clear all spell effects oObject has applied to others.
        /// <param name="oObject">The object that applied the spell effects.</param>
        public static void ClearSpellEffectsOnOthers(uint oObject)
        {
            VM.NWNX.SetFunction(NWNX_Object, "ClearSpellEffectsOnOthers");
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
        }

        /// Peek at the UUID of oObject without assigning one if it does not have one
        /// <param name="oObject">The object</param>
        /// <returns>The UUID or "" when the object does not have or cannot have an UUID</returns>
        public static string PeekUUID(uint oObject)
        {
            VM.NWNX.SetFunction(NWNX_Object, "PeekUUID");
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopString();
        }

        /// Get if oDoor has a visible model.
        /// <param name="oDoor">The door</param>
        /// <returns>TRUE if oDoor has a visible model</returns>
        public static int GetDoorHasVisibleModel(uint oDoor)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetDoorHasVisibleModel");
            VM.NWNX.StackPush(oDoor);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// Get if oObject is destroyable.
        /// <param name="oObject">The object</param>
        /// <returns>TRUE if oObject is destroyable.</returns>
        public static int GetIsDestroyable(uint oObject)
        {
            VM.NWNX.SetFunction(NWNX_Object, "GetIsDestroyable");
            VM.NWNX.StackPush(oObject);
            VM.NWNX.Call();
            return VM.NWNX.StackPopInt();
        }

        /// @}
    }

    public struct LocalVariable
    {
        public int type;
        public string key;
    }
}