using System;

namespace NWN.Core
{
  public static partial class NWScript
  {
    static NWScript()
    {
      if (NWNCore.FunctionHandler == null)
      {
        throw new InvalidOperationException("Attempted to call an NWScript function before NWN.Core was initialised.\n" +
          "Initialise NWN.Core first using NWNCore.Init()");
      }
    }
  }
}
