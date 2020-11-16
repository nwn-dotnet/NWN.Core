using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWN.Core.Server
{
  public abstract class Script
  {
    public const int SCRIPT_NOT_HANDLED = -1;

    public int Value = 0;
    public NwnServer Server { get; set; }
    public string Name { get; set; }
    public abstract void Execute();
  }
}
