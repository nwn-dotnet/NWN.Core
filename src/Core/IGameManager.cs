using System;

namespace NWN.Core
{
  [Obsolete("IGameManager has been split into two interfaces to make event registration optional.\n" +
    "Consider implementing ICoreEventHandler/ICoreFunctionHandler instead.\n" +
    "IGameManager will be removed in a future release.")]
  public interface IGameManager : ICoreEventHandler, ICoreFunctionHandler {}
}
