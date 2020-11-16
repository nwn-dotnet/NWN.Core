using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWN.Core
{
  public struct NwnEngineAsset
  {
    public IntPtr Ptr { get; set; }
    public EngineAssetType Type { get; set; }
  }
}
