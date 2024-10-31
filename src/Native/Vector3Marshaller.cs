using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;

namespace NWN.Core.Native
{
  [CustomMarshaller(typeof(Vector3), MarshalMode.Default, typeof(Vector3Marshaller))]
  public static class Vector3Marshaller
  {
    [StructLayout(LayoutKind.Sequential)]
    internal readonly struct Unmanaged
    {
      public readonly float X;
      public readonly float Y;
      public readonly float Z;

      public Unmanaged(float x, float y, float z)
      {
        X = x;
        Y = y;
        Z = z;
      }
    }

    internal static Unmanaged ConvertToUnmanaged(Vector3 vector)
    {
      return new Unmanaged(vector.X, vector.Y, vector.Z);
    }

    internal static Vector3 ConvertToManaged(Unmanaged unmanaged)
    {
      return new Vector3(unmanaged.X, unmanaged.Y, unmanaged.Z);
    }
  }
}
