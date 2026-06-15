using UnityEngine;

namespace MalumMenu;

public class ChatTab : ITab
{
    public string name => "聊天";

    public void Draw()
    {
        GUILayout.BeginVertical(GUILayout.Width(MenuUI.windowWidth * 0.425f));

        DrawGeneral();

        GUILayout.Space(15);

        DrawTextbox();

        GUILayout.EndVertical();
    }

    private void DrawGeneral()
    {
        CheatToggles.enableChat = GUILayout.Toggle(CheatToggles.enableChat, " 启用聊天");

        CheatToggles.bypassUrlBlock = GUILayout.Toggle(CheatToggles.bypassUrlBlock, " 绕过URL屏蔽");

        CheatToggles.lowerRateLimits = GUILayout.Toggle(CheatToggles.lowerRateLimits, " 降低发送频率限制");
    }

    private void DrawTextbox()
    {
        GUILayout.Label("输入框", GUIStylePreset.TabSubtitle);

        CheatToggles.unlockCharacters = GUILayout.Toggle(CheatToggles.unlockCharacters, " 解锁额外字符");

        CheatToggles.longerMessages = GUILayout.Toggle(CheatToggles.longerMessages, " 允许更长的消息");

        CheatToggles.unlockClipboard = GUILayout.Toggle(CheatToggles.unlockClipboard, " 解锁剪贴板");
    }
}
