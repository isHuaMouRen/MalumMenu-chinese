using UnityEngine;

namespace MalumMenu;

public class ESPTab : ITab
{
    public string name => "ESP";

    public void Draw()
    {
        GUILayout.BeginHorizontal();

        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.Space(15);

        DrawCamera();

        GUILayout.EndVertical();

        GUILayout.BeginVertical();

        DrawTracers();

        GUILayout.Space(15);

        DrawMinimap();

        GUILayout.EndVertical();

        GUILayout.EndHorizontal();
    }

    private void DrawGeneral()
    {
        CheatToggles.seePlayerInfo = GUILayout.Toggle(CheatToggles.seePlayerInfo, " 查看玩家信息");

        CheatToggles.seeRoles = GUILayout.Toggle(CheatToggles.seeRoles, " 查看身份");

        CheatToggles.seeGhosts = GUILayout.Toggle(CheatToggles.seeGhosts, " 幽灵可视");

        CheatToggles.noShadows = GUILayout.Toggle(CheatToggles.noShadows, " 无阴影");

        CheatToggles.taskArrows = GUILayout.Toggle(CheatToggles.taskArrows, " 任务箭头");

        CheatToggles.revealVotes = GUILayout.Toggle(CheatToggles.revealVotes, " 可视投票");

        CheatToggles.seeLobbyInfo = GUILayout.Toggle(CheatToggles.seeLobbyInfo, " 查看房间信息");
    }

    private void DrawCamera()
    {
        GUILayout.Label("相机", GUIStylePreset.TabSubtitle);

        CheatToggles.zoomOut = GUILayout.Toggle(CheatToggles.zoomOut, " 缩放");

        CheatToggles.spectate = GUILayout.Toggle(CheatToggles.spectate, " 观察者");

        CheatToggles.freecam = GUILayout.Toggle(CheatToggles.freecam, " 自由视角");
    }

    private void DrawTracers()
    {
        GUILayout.Label("射线", GUIStylePreset.TabSubtitle);

        CheatToggles.tracersCrew = GUILayout.Toggle(CheatToggles.tracersCrew, " 船员");

        CheatToggles.tracersImps = GUILayout.Toggle(CheatToggles.tracersImps, " 伪装者");

        CheatToggles.tracersGhosts = GUILayout.Toggle(CheatToggles.tracersGhosts, " 幽灵");

        CheatToggles.tracersBodies = GUILayout.Toggle(CheatToggles.tracersBodies, " 尸体");

        CheatToggles.colorBasedTracers = GUILayout.Toggle(CheatToggles.colorBasedTracers, " 根据颜色区分");

        CheatToggles.distanceBasedTracers = GUILayout.Toggle(CheatToggles.distanceBasedTracers, " 根据距离区分");
    }

    private void DrawMinimap()
    {
        GUILayout.Label("小地图", GUIStylePreset.TabSubtitle);

        CheatToggles.mapCrew = GUILayout.Toggle(CheatToggles.mapCrew, " 船员");

        CheatToggles.mapImps = GUILayout.Toggle(CheatToggles.mapImps, " 内鬼");

        CheatToggles.mapGhosts = GUILayout.Toggle(CheatToggles.mapGhosts, " 幽灵");

        CheatToggles.colorBasedMap = GUILayout.Toggle(CheatToggles.colorBasedMap, " 根据颜色区分");
    }
}
