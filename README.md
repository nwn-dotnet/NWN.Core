# NWN.Core #
A function library for base NWN and NWNX plugin nwscript functions.

## Why should I care about NWN.Core? ##
NWN.Core is a low-level function wrapper that exposes all engine events, NWScript and relevant NWNX functionality to C#.

It is designed to follow as close as possible to the native NwScript and NWNX APIs to maintain maximum coverage of the base game functions.
The library is automatically updated to match latest NWNEE and NWNXEE versions.

NWN.Core exposes the base game functions by sorting them into static classes, and does not include object wrappers/enums or utilize other C# features.

It is mainly intended to be consumed by other libraries for more elegant and abstracted solutions, but can be configured with a minimal wrapper for simple applications.

## Getting started ##
Before getting started, you will need to install .NET 8 or greater. Installation instructions can be found [here](https://docs.microsoft.com/en-au/dotnet/core/install/linux).

1. Create a new C# project and add NWN.Core using [nuget](https://www.nuget.org/packages/NWN.Core). You can do this via the command line by opening the project directory, and running `dotnet add package NWN.Core`.

2. To correctly initialise NWN.Core, you will need to bootstrap it. Here is a minimal example:

```csharp
using System;
using System.Runtime.InteropServices;
using NWN.Core;
using NWNX.NET;
using NWNX.NET.Native;

namespace NWN
{
  public static unsafe class Internal
  {
    private static readonly MyFunctionHandler myFunctionHandler = new MyFunctionHandler();

    public static void Bootstrap()
    {
      NWNCore.Init(myFunctionHandler); // Bootstrap NWN Core
      NWNXAPI.RegisterRunScriptHandler(&OnRunScript); // Register script handler function
    }

    [UnmanagedCallersOnly]
    private static int OnRunScript(IntPtr scriptPtr, uint oidSelf)
    {
      string? script = scriptPtr.ReadNullTerminatedString(); // Convert script into usable name.
      myFunctionHandler.ObjectSelf = oidSelf; // Update OBJECT_SELF constant.

      if (script == "my_script") // Check the script name matches our expected value
      {
        NWScript.WriteTimestampedLogEntry("Code from C#!");
        return 0; // Signal that we handled this script call, and to skip any .nss scripts with the same name
      }

      return ~0;
    }
  }

  public class MyFunctionHandler : ICoreFunctionHandler
  {
    public uint ObjectSelf { get; set; }

    // Advanced setup - required for AssignCommand/DelayCommand/ActionDoCommand functions in NwScript
    public void ClosureAssignCommand(uint obj, Action func) {}
    public void ClosureDelayCommand(uint obj, float duration, Action func) {}
    public void ClosureActionDoCommand(uint obj, Action func) {}
  }
}
```

3. Download and extract the dedicated server package: [Server packages](https://forums.beamdog.com/discussion/67157/server-download-packages-and-docker-support/p1)
4. Download and extract NWNX: https://github.com/nwnxee/unified/releases
5. Build your project and copy the output binaries (bin/Debug or bin/Release) to a directory next to the files you extracted in step 2 and 3.
6. The directory structure should look like the following:
```
    bin/
    |----linux-x86
         |----nwserver-linux
         |----NWNX_DotNET.so
    dotnet/
    |----YourProject.dll
    |----NWN.Core.dll
    |----NWNX.NET.dll
```

7. Configure NWNX options to the following:

|Option| Notes                                                                                                                                      |
|-|--------------------------------------------------------------------------------------------------------------------------------------------|
| NWNX_DOTNET_ASSEMBLY | Where `YourProject.dll` was built and copied to in step 5, without the extension. E.g: `NWNX_DOTNET_ASSEMBLY=/nwn/home/dotnet/YourProject` |
| NWNX_DOTNET_ENTRYPOINT | Can be left blank, UNLESS you put your Bootstrap function in a different namespace/class instead of "NWN.Internal"                         |

8. Run the server as mentioned in the instructions [here](https://github.com/nwnxee/unified#running-the-server-native).

## Consuming Game Events

Once you have bootstrapped the library, you are all set to use the API!

There are a few events that can be used through the underlying NWNX API:

```csharp
      NWNCore.Init(myFunctionHandler);
      NWNXAPI.RegisterRunScriptHandler(&OnRunScript);
      NWNXAPI.RegisterMainLoopHandler(&OnMainLoop);
      NWNXAPI.RegisterSignalHandler(&OnSignal);
```

The method parameter is the name of your function to handle the event.

As an example, to write the module name to the console once the server starts:

```csharp
using System;
using System.Runtime.InteropServices;
using NWN.Core;
using NWNX.NET;
using NWNX.NET.Native;

namespace NWN
{
  public static unsafe class Internal
  {
    private static readonly MyFunctionHandler myFunctionHandler = new MyFunctionHandler();

    public static void Bootstrap()
    {
      // Bootstrap NWN.Core
      NWNCore.Init(myFunctionHandler);

      // Register "private static void OnSignal" as the "OnSignal" handler.
      NWNXAPI.RegisterSignalHandler(&OnSignal);
    }

    [UnmanagedCallersOnly]
    private static void OnSignal(IntPtr signalPtr)
    {
      // Convert signal to usable format
      string? signal = signalPtr.ReadNullTerminatedString();

      // Check for correct signal
      if (signal == "ON_MODULE_LOAD_FINISH")
      {
        // Get the module name.
        string moduleName = NWScript.GetModuleName();

        // Write the module name to the server console.
        Console.WriteLine(moduleName);
      }
    }
  }

  public class MyFunctionHandler : ICoreFunctionHandler
  {
    public uint ObjectSelf { get; set; }

    // Advanced setup - required for AssignCommand/DelayCommand/ActionDoCommand functions in NwScript
    public void ClosureAssignCommand(uint obj, Action func) {}
    public void ClosureDelayCommand(uint obj, float duration, Action func) {}
    public void ClosureActionDoCommand(uint obj, Action func) {}
  }
}
```

### NWNXAPI.RegisterMainLoopHandler ###
This function is called on every repetition of the server's main loop. Nothing expensive should be done here, for obvious reasons.

### NWNXAPI.RegisterRunScriptHandler ###
This function is called every time that the server attempts to call a native NWScript file (.ncs). Its parameters are the name of the script called and the object on which the script was called (and which will represent the value of the NWScript constant OBJECT_SELF in the script itself). The scriptHandlerResult value of this function can be -1, 0, or 1, each signifying something different:
```
-1 : Function not handled by DotNET. This will attempt to call any actual .ncs with the right name.
0 : FALSE
1 : TRUE
```
A result of either TRUE or FALSE will prevent any .ncs file with the same name from being called. The value is discarded except in the case of StartingConditional scripts, where it represents the return value of the StartingConditional() function. Most implementations will use some method such as a dictionary of delegates to control custom behavior based on the script name passed, but the details are left up to the individual.

### RegisterSignalHandler ###
This function is called during significant server events. The string parameter indicates which signal has occurred.
```
"ON_MODULE_LOAD_FINISH" - Called just before the OnModuleLoad event. Perform any init requiring NWScript usage here.
"ON_DESTROY_SERVER" - Called just before the server will be shutdown. Perform any cleanup/flushing here.
```

## Memory & Engine Structures
When you use an engine structure (E.g. effects, item properties), you must manually "free" the structure after you have finished using it with `VM.FreeGameDefinedStructure`. Failure to do so will cause a memory leak.

A good pattern is to implement "wrapper" classes that handles this cleanup logic for you:

```csharp
  public abstract class EngineStructure
  {
    public abstract int StructureId { get; }

    public IntPtr Handle;

    protected EngineStructure(IntPtr handle)
    {
      Handle = handle;
    }

    ~EngineStructure()
    {
      VM.FreeGameDefinedStructure(StructureId, Handle);
    }

    public static implicit operator IntPtr(EngineStructure engineStructure) => engineStructure.Handle;
  }

  public class Effect : EngineStructure
  {
    public Effect(IntPtr handle) : base(handle) {}
    public override int StructureId => NWScript.ENGINE_STRUCTURE_EFFECT;
    public static implicit operator Effect(IntPtr intPtr) => new Effect(intPtr);
  }

  public class Event : EngineStructure
  {
    public Event(IntPtr handle) : base(handle) {}
    public override int StructureId => NWScript.ENGINE_STRUCTURE_EVENT;
    public static implicit operator Event(IntPtr intPtr) => new Event(intPtr);
  }

  public class Location : EngineStructure
  {
    public Location(IntPtr handle) : base(handle) {}
    public override int StructureId => NWScript.ENGINE_STRUCTURE_LOCATION;
    public static implicit operator Location(IntPtr intPtr) => new Location(intPtr);
  }

  public class Talent : EngineStructure
  {
    public Talent(IntPtr handle) : base(handle) {}
    public override int StructureId => NWScript.ENGINE_STRUCTURE_TALENT;
    public static implicit operator Talent(IntPtr intPtr) => new Talent(intPtr);
  }

  public class ItemProperty : EngineStructure
  {
    public ItemProperty(IntPtr handle) : base(handle) {}
    public override int StructureId => NWScript.ENGINE_STRUCTURE_ITEMPROPERTY;
    public static implicit operator ItemProperty(IntPtr intPtr) => new ItemProperty(intPtr);
  }

  public class SQLQuery : EngineStructure
  {
    public SQLQuery(IntPtr handle) : base(handle) {}
    public override int StructureId => NWScript.ENGINE_STRUCTURE_SQLQUERY;
    public static implicit operator SQLQuery(IntPtr intPtr) => new SQLQuery(intPtr);
  }
```

You can then use the NWScript API like this, and the cleanup will be done automatically:

```csharp
    public static void KillCreature(uint creature)
    {
      Effect effect = NWScript.EffectDeath();
      NWScript.ApplyEffectToObject(NWScript.DURATION_TYPE_INSTANT, effect, creature);
    }
```

## Contribute ##
If you would like to contribute, you are more than welcome to join the NWNXEE Developer Discord [here](https://discord.gg/CukSHZq "NWNXEE Developer Discord"). We welcome contributions and suggestions of all kinds.

## Credits ##
The NWNXEE DotNET plugin was written by [Milos Tijanic](https://github.com/mtijanic "Milos Tijanic").
This library was inspired by the [NWN DotNET Module Template](https://github.com/urothis/nwn-dotnet-module-template "NWN DotNET Module Template"), which began as a fork of [nwnstuff/nwn-csharp](https://github.com/nwnstuff/nwn-csharp/ "nwn-csharp").
