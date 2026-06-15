using UnityEngine;

namespace MalumMenu;

public class AnimationsTab : ITab
{
    public string name => "动画";

    public void Draw()
    {
        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.Space(15);

        DrawClientSided();

        GUILayout.EndVertical();
    }

    private void DrawGeneral()
    {
        CheatToggles.animShields = GUILayout.Toggle(CheatToggles.animShields, " 护盾");

        CheatToggles.animAsteroids = GUILayout.Toggle(CheatToggles.animAsteroids, " 小行星射击器");

        CheatToggles.animEmptyGarbage = GUILayout.Toggle(CheatToggles.animEmptyGarbage, " 释放垃圾");

        CheatToggles.animMedScan = GUILayout.Toggle(CheatToggles.animMedScan, " 扫描器");

        CheatToggles.animCamsInUse = GUILayout.Toggle(CheatToggles.animCamsInUse, " 监控摄像头使用中");

        // CheatToggles.animPet = GUILayout.Toggle(CheatToggles.animPet, " Pet");
    }

    private void DrawClientSided()
    {
        GUILayout.Label("仅客户端", GUIStylePreset.TabSubtitle);

        CheatToggles.moonWalk = GUILayout.Toggle(CheatToggles.moonWalk, " 太空步");
    }
}
