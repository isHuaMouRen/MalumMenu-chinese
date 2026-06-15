using UnityEngine;

namespace MalumMenu;

public class ModesTab : ITab
{
    public string name => "Mod设置";

    public void Draw()
    {
        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.EndVertical();
    }

    private void DrawGeneral()
    {
        CheatToggles.rgbMode = GUILayout.Toggle(CheatToggles.rgbMode, " RGB 模式");

        CheatToggles.stealthMode = GUILayout.Toggle(CheatToggles.stealthMode, " 隐身模式");

        CheatToggles.panicMode = GUILayout.Toggle(CheatToggles.panicMode, " 应急模式");
    }
}
