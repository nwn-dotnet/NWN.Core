using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NWN.Core
{
  public struct NwnReference
  {
    public static NwnReference INVALID { get; } = new NwnReference(0x7F000000);
    public uint _id;
    public uint ID => _id;

    public NwnReference(uint id) => _id = id;

    public bool IsValid() => _id != INVALID.ID;

    public override bool Equals(object? obj) => (obj is NwnReference o) && Equals(o);
    public bool Equals(NwnReference o) => _id == o._id;
    public override int GetHashCode() => _id.GetHashCode();
    public static bool operator ==(NwnReference a, NwnReference b) => a.Equals(b);
    public static bool operator !=(NwnReference a, NwnReference b) => !a.Equals(b);
  }
}
