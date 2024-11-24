using System;
using System.Numerics;
using Dalamud.Interface.Windowing;
using ImGuiNET;

namespace IceBox.Windows;

internal class SettingsWindow : Window, IDisposable
{
    // We give this window a constant ID using ###
    // This allows for labels being dynamic, like "{FPS Counter}fps###XYZ counter window",
    // and the window ID will always be "###XYZ counter window" for ImGui
    public static new readonly string WindowName = "Config";
    public SettingsWindow() : base(WindowName)
    {
        Flags = ImGuiWindowFlags.NoResize | ImGuiWindowFlags.NoCollapse | ImGuiWindowFlags.NoScrollbar |
                ImGuiWindowFlags.NoScrollWithMouse;

        Size = new Vector2(232, 90);
        SizeCondition = ImGuiCond.Always;
    }

    public void Dispose() { }


    public override void Draw()
    {
        // can't ref a property, so use a local copy
        var configValue = Configuration.SomePropertyToBeSavedAndWithADefault;
        if (ImGui.Checkbox("Random Config Bool", ref configValue))
        {
            Configuration.SomePropertyToBeSavedAndWithADefault = configValue;
            // can save immediately on change, if you don't want to provide a "Save and Close" button
            Configuration.Save();
        }

        var movable = Configuration.IsConfigWindowMovable;
        if (ImGui.Checkbox("Movable Config Window", ref movable))
        {
            Configuration.IsConfigWindowMovable = movable;
            Configuration.Save();
        }
    }
}
