using System;

namespace NWN.Core.NWNX
{
  [AttributeUsage(AttributeTargets.Class)]
  public class NWNXPluginAttribute : Attribute
  {
    public readonly string PluginName;

    public NWNXPluginAttribute(string pluginName) => PluginName = pluginName;
  }
}
