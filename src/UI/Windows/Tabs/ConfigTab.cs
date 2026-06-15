using UnityEngine;

namespace MalumMenu;

public class ConfigTab : ITab
{
    public string name => "配置";

    public void Draw()
    {
        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.EndVertical();
    }

    private void DrawGeneral()
    {
        CheatToggles.openConfig = GUILayout.Toggle(CheatToggles.openConfig, " 打开配置");

        CheatToggles.reloadConfig = GUILayout.Toggle(CheatToggles.reloadConfig, " 重新加载配置");

        CheatToggles.saveProfile = GUILayout.Toggle(CheatToggles.saveProfile, " 保存配置到档案");

        CheatToggles.loadProfile = GUILayout.Toggle(CheatToggles.loadProfile, " 从档案加载配置");
    }
}
