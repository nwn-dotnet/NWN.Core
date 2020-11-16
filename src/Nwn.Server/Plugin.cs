using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwn.Server
{
  public abstract class Plugin
  {
    protected string Name { get; private set; }
    public NwnServer Server { get; private set; }

    public Plugin(NwnServer server) => Server = server ?? throw new ArgumentNullException(nameof(server));

    protected void Call(string method, params object[] args) => Server.Call(Name, method, args);
    protected int CallInt32(string method, params object[] args) => throw new NotImplementedException();
    protected int CallFloat(string method, params object[] args) => throw new NotImplementedException();
    protected string CallString(string method, params object[] args) => throw new NotImplementedException();
    protected NwnReference CallObj(string method, params object[] args) => throw new NotImplementedException();
  }
}
