# NWN.Core #
A NuGet package implementing core functionality for the [NWNXEE](https://github.com/nwnxee/unified "NWNXEE") DotNET plugin.

## Why should I care about NWN.Core? ##
NWN.Core is a low-level function wrapper that exposes all engine events, NWScript and relevant NWNX functionality to C#.

It is designed to follow as close as possible to the native NwScript and NWNX APIs to maintain maximum coverage of the base game functions.
The library is automatically updated to match latest NWNEE and NWNXEE versions.

NWN.Core exposes the base game functions by sorting them into static classes, and does not include object wrappers/enums or utilize other C# features. 

It can serve both as a primary tool in its own right for simpler setups and as a base for more elegant or abstract solutions.

## Getting started ##
Before getting started, you will need to install .NET 5 or greater. Installation instructions can be found [here](https://docs.microsoft.com/en-au/dotnet/core/install/linux).

1. Create a new C# project and add NWN.Core using [nuget](https://www.nuget.org/packages/NWN.Core). You can do this via the command line by opening the project directory, and running `dotnet add package NWN.Core`.

2. To correctly initialise NWN.Core, you will need to bootstrap it. Here is a minimal example:

```csharp
using System;
using NWN.Core;

namespace NWN
{
  public static class Internal
  {
    public static int Bootstrap(IntPtr nativeHandlesPtr, int nativeHandlesLength)
    {
      int retVal = NWNCore.Init(nativeHandlesPtr, nativeHandlesLength, out CoreGameManager coreGameManager);
      coreGameManager.OnSignal += OnSignal;
      coreGameManager.OnServerLoop += OnServerLoop;
      coreGameManager.OnRunScript += OnRunScript;

      return retVal;
    }

    private static void OnRunScript(string scriptName, uint objectSelf, out int scriptHandlerResult) { scriptHandlerResult = -1; }

    private static void OnSignal(string signal) {}

    private static void OnServerLoop(ulong frame) {}
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
    modbin/
    |----YourProject.dll
    |----NWN.Core.dll
```

7. Configure NWNX options to the following:

|Option|Notes|
|-|-|
| NWNX_DOTNET_ASSEMBLY | Where `YourProject.dll` was built and copied to in step 5, without the extension. E.g: `NWNX_DOTNET_ASSEMBLY=/nwn/home/modbin/YourProject` |
| NWNX_DOTNET_ENTRYPOINT | Can be left blank, UNLESS you put your Bootstrap function in a different namespace/class instead of "NWN.Internal" |

8. Run the server as mentioned in the instructions [here](https://github.com/nwnxee/unified#running-the-server-native).

## Consuming Game Events

Once you have bootstrapped the library, you are all set to use the API!

NWN.Core sends 3 different events that can be hooked once you have bootstrapped the library.

```csharp
      int retVal = NWNCore.Init(nativeHandlesPtr, nativeHandlesLength, out CoreGameManager coreGameManager);
      coreGameManager.OnSignal += OnSignal;
      coreGameManager.OnServerLoop += OnServerLoop;
      coreGameManager.OnRunScript += OnRunScript;
```

The right assignment of `+=` is the name of your function to handle the event.

As an example, to write the module name to the console once the server starts:

```csharp
using System;
using NWN.Core;

namespace NWN
{
  public static class Internal
  {
    public static int Bootstrap(IntPtr nativeHandlesPtr, int nativeHandlesLength)
    {
      // Bootstrap NWN.Core
      int retVal = NWNCore.Init(nativeHandlesPtr, nativeHandlesLength, out CoreGameManager coreGameManager);
      
      // Register "private static void OnSignal" as the "OnSignal" handler.
      coreGameManager.OnSignal += OnSignal;

      // Return the bootstrap result.
      return retVal;
    }

    // Since this was assigned as the OnSignal handler, it will be called on startup and shutdown.
    private static void OnSignal(string signal)
    {
      // Check for the correct signal.
      if (signal == "ON_MODULE_LOAD_FINISH")
      {
        // Get the module name.
        string moduleName = NWScript.GetModuleName();
        
        // Write the module name to the server console.
        Console.WriteLine(moduleName);
      }
    }
  }
}
```

### OnMainLoop ###
This function is called on every repetition of the server's main loop. Nothing expensive should be done here, for obvious reasons.

### OnRunScript ###
This function is called every time that the server attempts to call a native NWScript file (.ncs). Its parameters are the name of the script called and the object on which the script was called (and which will represent the value of the NWScript constant OBJECT_SELF in the script itself). The scriptHandlerResult value of this function can be -1, 0, or 1, each signifying something different:
```
-1 : Function not handled by DotNET. This will attempt to call any actual .ncs with the right name.
0 : FALSE
1 : TRUE
```
A result of either TRUE or FALSE will prevent any .ncs file with the same name from being called. The value is discarded except in the case of StartingConditional scripts, where it represents the return value of the StartingConditional() function. Most implementations will use some method such as a dictionary of delegates to control custom behavior based on the script name passed, but the details are left up to the individual.

### OnSignal ###
This function is called during significant server events. The string parameter indicates which signal has occurred.
```
"ON_MODULE_LOAD_FINISH" - Called just before the OnModuleLoad event. Perform any init requiring NWScript usage here.
"ON_DESTROY_SERVER" - Called just before the server will be shutdown. Perform any cleanup/flushing here.
```

## Contribute ##
If you would like to contribute, you are more than welcome to join the NWNXEE DotNET Discord [here](https://discord.gg/BY9cq3Q "NWNXEE DotNET Discord"). We welcome contributions and suggestions of all kinds.

## Credits ##
The NWNXEE DotNET plugin was written by [Milos Tijanic](https://github.com/mtijanic "Milos Tijanic").
This library was inspired by the [NWN DotNET Module Template](https://github.com/urothis/nwn-dotnet-module-template "NWN DotNET Module Template"), which began as a fork of [nwnstuff/nwn-csharp](https://github.com/nwnstuff/nwn-csharp/ "nwn-csharp").
