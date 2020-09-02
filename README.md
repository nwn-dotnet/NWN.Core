# NWN.Core #
_A NuGet package implementing core functionality for the [NWNXEE](https://github.com/nwnxee/unified "NWNXEE") DotNET plugin._

## Why should I care about NWN.Core? ##
_NWN.Core is a regularly-maintained library which exposes all engine events, NWScript and relevant NWNX functionality to C#. Because it maps as closely as possible to the internal and external functions which it calls, it can serve both as a primary tool in its own right for simpler setups and as a base for more elegant or abstract solutions. The user can be certain that they will have the latest updates to the API without worrying about any loss of efficiency or speed._

_For the same reason, this project does not contain an implementation of the core IGameManager interface, which is required for the resulting library to be called by NWNXEE; this implementation is left up to the user. For examples of how this interface can be leveraged to create complex module systems, see the Example directory (TBD)._

## Features ##
> One to one exposing of NWScript and NWNX functions sorted into C# static classes.
> Regular updates to match latest NWNEE and NWNXEE versions.

## How to Use ##
_First, NWNXEE DotNET must be set up and working per the instructions [here](https://github.com/nwnxee/unified/tree/master/Plugins/DotNET "NWNXEE DotNet Instructions")._

_Next, the NWN.Core NuGet package may be added to an empty C# project. In order for the appropriate functions to be called, the IGameManager interface must be implemented. This will result in several functions:_

### Bootstrap ###
_This function is called when the library is loaded. It should generally take the form:_

```csharp
public static int Bootstrap(IntPtr ptr, int nativeHandlesLength) {
            // Do whatever other initialization you want to do here.
            return NWNCore.Init(ptr, nativeHandlesLength, Instance);
        }
```

### OnMainLoop ###
_This function is called on every repetition of the server's main loop. Nothing expensive should be done here, for obvious reasons._

### OnRunScript ###
_This function is called every time that the server attempts to call a native NWScript file (.ncs). Its parameters are the name of the script called and the object on which the script was called (and which will represent the value of the NWScript constant OBJECT_SELF in the script itself). The return value of this function can be -1, 0, or 1, each signifying something different:_
```
-1 : Function not handled by DotNET. This will attempt to call any actual .ncs with the right name.
0 : FALSE
1 : TRUE
```
_A result of either TRUE or FALSE will prevent any .ncs file with the same name from being called. The value is discarded except in the case of StartingConditional scripts, where it represents the return value of the StartingConditional() function. Most implementations will use some method such as a dictionary of delegates to control custom behavior based on the script name passed, but the details are left up to the individual._

### OnSignal ###
_This function is called during significant server events. The string parameter indicates which signal has occurred._
```
"ON_MODULE_LOAD_FINISH" - Called just before the OnModuleLoad event. Perform any init requiring NWScript usage here.
"ON_DESTROY_SERVER" - Called just before the server will be shutdown. Perform any cleanup/flushing here.
```

### Closure Functions ###
_These functions deal with delayed commands and other engine actions that happen at a later time. They are called by the engine. It is not recommended to change or alter these unless you know what you are doing and want a specific result. A functional implementation you may use is given here:_

```csharp
        public void OnClosure(ulong eid, uint oidSelf) {
            var old = ObjectSelf;
            ObjectSelf = oidSelf;
            try {
                Closures[eid].Run();
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
            }
            Closures.Remove(eid);
            ObjectSelf = old;
        }

        // Closures are for events that happen separately on the stack, specifically AssignCommand, DelayCommand,
        // and ActionDoCommand. Most implementations do not change these.
        public void ClosureAssignCommand(uint obj, ActionDelegate func) {
            if (VM.ClosureAssignCommand(obj, NextEventId) != 0)
                Closures.Add(NextEventId++, new Closure { OwnerObject = obj, Run = func });
        }

        public void ClosureDelayCommand(uint obj, float duration, ActionDelegate func) {
            if (VM.ClosureDelayCommand(obj, duration, NextEventId) != 0)
                Closures.Add(NextEventId++, new Closure { OwnerObject = obj, Run = func });
        }

        public void ClosureActionDoCommand(uint obj, ActionDelegate func) {
            if (VM.ClosureActionDoCommand(obj, NextEventId) != 0)
                Closures.Add(NextEventId++, new Closure { OwnerObject = obj, Run = func });
        }
```
_Once your interface is fully implemented, ensure that your output DLL is named NWN.dll and the following environment variables for NWNX are set:_
```
NWNX_DOTNET_SKIP=n
NWNX_DOTNET_ASSEMBLY=/nwn/dotnet/NWN
NWNX_DOTNET_ENTRYPOINT=NWN.ServerCore
```
_Replace ``ServerCore`` in ``NWN.ServerCore`` with the name of your class which implements IGameManager._

_Now you may place your DLL in the appropriate directory given in the env variable above, and start NWNX!_

## Contribute ##
_If you would like to contribute, you are more than welcome to join the NWNXEE DotNET Discord [here](https://discord.gg/BY9cq3Q "NWNXEE DotNET Discord"). We welcome contributions and suggestions of all kinds._

## Credits ##
_The NWNXEE DotNET plugin was written by [Milos Tijanic](https://github.com/mtijanic "Milos Tijanic")._
_This library was inspired by the [NWN DotNET Module Template](https://github.com/urothis/nwn-dotnet-module-template "NWN DotNET Module Template"), which began as a fork of [nwnstuff/nwn-csharp](https://github.com/nwnstuff/nwn-csharp/ "nwn-csharp")._
