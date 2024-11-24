using Dalamud.Configuration;
using Dalamud.Plugin;
using System;

namespace IceBox;

[Serializable]
public class Config : IPluginConfiguration
{
    public int Version { get; set; } = 0;

    public bool IsConfigWindowMovable { get; set; } = true;
    public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;

    // the below exist just to make saving less cumbersome
    public void Save()
    {
        IceBox.PluginInterface.SavePluginConfig(this);
    }
}
