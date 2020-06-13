using System;

namespace NWN.Core
{
    public class Effect
    {
        public IntPtr Handle;
        public Effect(IntPtr handle) => Handle = handle;
        ~Effect() { Internal.NativeFunctions.FreeEffect(Handle); }

        public static implicit operator IntPtr(Effect effect) => effect.Handle;
        public static implicit operator Effect(IntPtr intPtr) => new Effect(intPtr);
    }

    public class Event
    {
        public IntPtr Handle;
        public Event(IntPtr handle) => Handle = handle;
        ~Event() { Internal.NativeFunctions.FreeEvent(Handle); }

        public static implicit operator IntPtr(Event effect) => effect.Handle;
        public static implicit operator Event(IntPtr intPtr) => new Event(intPtr);
    }

    public class Location
    {
        public IntPtr Handle;
        public Location(IntPtr handle) => Handle = handle;
        ~Location() { Internal.NativeFunctions.FreeLocation(Handle); }

        public static implicit operator IntPtr(Location effect) => effect.Handle;
        public static implicit operator Location(IntPtr intPtr) => new Location(intPtr);
    }

    public class Talent
    {
        public IntPtr Handle;
        public Talent(IntPtr handle) => Handle = handle;
        ~Talent() { Internal.NativeFunctions.FreeTalent(Handle); }

        public static implicit operator IntPtr(Talent effect) => effect.Handle;
        public static implicit operator Talent(IntPtr intPtr) => new Talent(intPtr);
    }

    public class ItemProperty
    {
        public IntPtr Handle;
        public ItemProperty(IntPtr handle) => Handle = handle;
        ~ItemProperty() { Internal.NativeFunctions.FreeItemProperty(Handle); }

        public static implicit operator IntPtr(ItemProperty effect) => effect.Handle;
        public static implicit operator ItemProperty(IntPtr intPtr) => new ItemProperty(intPtr);
    }

    public delegate void ActionDelegate();
}
