using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace NWN.Core.Native
{
  [CustomMarshaller(typeof(string), MarshalMode.Default, typeof(NwStringMarshaller))]
  [CustomMarshaller(typeof(string), MarshalMode.ManagedToUnmanagedIn, typeof(ManagedToUnmanagedIn))]
  public static unsafe class NwStringMarshaller
  {
    private static Encoding encoding;

    internal static Encoding Encoding
    {
      get => encoding;
      set
      {
        if (!value.IsSingleByte)
        {
          throw new InvalidOperationException("Encoding must use single-byte code points.");
        }

        encoding = value;
      }
    }

    static NwStringMarshaller()
    {
      Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      encoding = Encoding.GetEncoding("windows-1252");
    }

    internal ref struct ManagedToUnmanagedIn
    {
      private byte* unmanaged;
      private bool allocated;

      public void FromManaged(string? managed)
      {
        if (managed == null)
        {
          return;
        }

        unmanaged = (byte*)Marshal.AllocHGlobal(managed.Length + 1);
        allocated = true;

        // Write string to buffer.
        Encoding.GetBytes(managed, new Span<byte>(unmanaged, managed.Length));

        // Write null terminator
        unmanaged[managed.Length] = 0;
      }

      public byte* ToUnmanaged()
      {
        return unmanaged;
      }

      public void Free()
      {
        if (allocated)
        {
          Marshal.FreeHGlobal((IntPtr)unmanaged);
        }
      }
    }

    public static string? ConvertToManaged(byte* unmanaged)
    {
      if (unmanaged == (byte*)IntPtr.Zero)
      {
        return null;
      }

      return Encoding.GetString(unmanaged, GetStringLength(unmanaged));
    }

    private static int GetStringLength(byte* unmanaged)
    {
      byte* walk = unmanaged;
      while (*walk != 0)
      {
        walk++;
      }

      return (int)(walk - unmanaged);
    }
  }
}
