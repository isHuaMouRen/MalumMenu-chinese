using UnityEngine;

namespace MalumMenu;

public class ConsoleTab : ITab
{
    public string name => "控制台";

    public void Draw()
    {
        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.EndVertical();
    }

    private void DrawGeneral()
    {
        CheatToggles.showConsole = GUILayout.Toggle(CheatToggles.showConsole, " 显示控制台");

        CheatToggles.logDeaths = GUILayout.Toggle(CheatToggles.logDeaths, " 记录死亡日志");

        CheatToggles.logShapeshifts = GUILayout.Toggle(CheatToggles.logShapeshifts, " 记录变形日志");

        CheatToggles.logVents = GUILayout.Toggle(CheatToggles.logVents, " 记录通风管日志");
    }
}
