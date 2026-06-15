using UnityEngine;

namespace MalumMenu;

public class HostOnlyTab : ITab
{
    public string name => "仅主持人";

    public void Draw()
    {
        GUILayout.BeginHorizontal();

        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.Space(15);

        DrawMurder();

        GUILayout.Space(15);

        DrawGameState();

        GUILayout.EndVertical();

        GUILayout.BeginVertical();

        DrawMeetings();

        GUILayout.EndVertical();

        GUILayout.EndHorizontal();
    }

    private void DrawGeneral()
    {
        CheatToggles.killVanished = GUILayout.Toggle(CheatToggles.killVanished, " 隐身时击杀");

        CheatToggles.killAnyone = GUILayout.Toggle(CheatToggles.killAnyone, " 击杀任何人");

        CheatToggles.noKillCd = GUILayout.Toggle(CheatToggles.noKillCd, " 无击杀冷却");

        CheatToggles.showProtectMenu = GUILayout.Toggle(CheatToggles.showProtectMenu, " 显示保护菜单");

        // CheatToggles.forceRole = GUILayout.Toggle(CheatToggles.forceRole, " Force Role");

        // CheatToggles.noOptionsLimits = GUILayout.Toggle(CheatToggles.noOptionsLimits, " No Options Limits");
    }

    private void DrawMurder()
    {
        GUILayout.Label("击杀", GUIStylePreset.TabSubtitle);

        CheatToggles.killPlayer = GUILayout.Toggle(CheatToggles.killPlayer, " 杀死玩家(传送到玩家)");

        CheatToggles.telekillPlayer = GUILayout.Toggle(CheatToggles.telekillPlayer, " 杀死玩家");

        CheatToggles.killAllCrew = GUILayout.Toggle(CheatToggles.killAllCrew, " 杀死所有船员");

        CheatToggles.killAllImps = GUILayout.Toggle(CheatToggles.killAllImps, " 杀死所有伪装者");

        CheatToggles.killAll = GUILayout.Toggle(CheatToggles.killAll, " 杀死所有人");
    }

    private void DrawGameState()
    {
        GUILayout.Label("游戏状态", GUIStylePreset.TabSubtitle);

        CheatToggles.forceStartGame = GUILayout.Toggle(CheatToggles.forceStartGame, " 强制开启游戏");

        CheatToggles.noGameEnd = GUILayout.Toggle(CheatToggles.noGameEnd, " 永无止境的游戏");
    }

    private void DrawMeetings()
    {
        GUILayout.Label("讨论", GUIStylePreset.TabSubtitle);

        CheatToggles.skipMeeting = GUILayout.Toggle(CheatToggles.skipMeeting, " 跳过讨论");

        CheatToggles.voteImmune = GUILayout.Toggle(CheatToggles.voteImmune, " 免疫投票");

        CheatToggles.ejectPlayer = GUILayout.Toggle(CheatToggles.ejectPlayer, " 放逐玩家");
    }
}
