using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nwn.Server
{
  public struct NwnEngineAsset
  {
    public IntPtr Ptr { get; set; }
    public EngineAssetType Type { get; set; }
  }
}
