using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwn.Server
{
  public abstract class Script : IDisposable
  {
    public const int NOT_HANDLED = -1;

    public Script(NwnServer server) => server.Scripts.Add(Name, this);

    public int Value = 0;
    public NwnServer Server { get; set; }
    public abstract string Name { get; }
    public abstract void Execute();
    public int ExecuteValue()
    {
      Execute();
      return Value;
    }

    public void Dispose() => Server.Scripts.Remove(Name);
  }
}
