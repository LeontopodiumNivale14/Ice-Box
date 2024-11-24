using System.Drawing;
using System.Reflection;
using ECommons.SimpleGui;

namespace IceBox.Windows;

public class MainWindow : ConfigWindow, IDisposable
{   
    private const string LogoManifestResource = "Ice_Box.Data.Portrit.png";
    private const uint SidebarWindowWidth = 203;
    private Point logoSize = new(210, 203);
    private const float LogoScale = 1f;

    public MainWindow() {}
    public void Dispose() { }

    public static void SetWindowProperties()
    {
        var width = SidebarWindowWidth;

        EzConfigGui.Window.Size = new Vector2(width, 500);
        EzConfigGui.Window.SizeConstraints = new()
        {
            MinimumSize = new Vector2(width, 320),
            MaximumSize = new Vector2(1920, 1080),
        };

        EzConfigGui.Window.SizeCondition = ImGuiCond.Always;

        EzConfigGui.Window.Flags |= ImGuiWindowFlags.AlwaysAutoResize;
        EzConfigGui.Window.Flags |= ImGuiWindowFlags.NoSavedSettings;

        EzConfigGui.Window.AllowClickthrough = false;
        EzConfigGui.Window.AllowPinning = false;
    }

    public override void Draw()
    {
        if (Svc.Texture.GetFromManifestResource(Assembly.GetExecutingAssembly(), LogoManifestResource).TryGetWrap(out var logo, out var _))
        {
            var maxWidth = 375 * 2 * 0.85f * ImGuiHelpers.GlobalScale;
            var ratio = maxWidth / logoSize.X;
            var scaledLogoSize = new Vector2(logoSize.X * LogoScale, logoSize.Y * LogoScale);
            ImGui.Image(logo.ImGuiHandle, scaledLogoSize);
        }
        else
        {
            ImGui.Text("Image not found.");
        }
        ImGui.Spacing();

        // ImGui.TextColored(Example.enabled ? new Vector4(0.0f, 1.0f, 0.0f, 1.0f) : new Vector4(1.0f, 0.0f, 0.0f, 1.0f), $"Are we working: {(Example.enabled ? "Yes" : "No")}");

    }
}
