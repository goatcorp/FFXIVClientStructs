using FFXIVClientStructs.FFXIV.Component.GUI;

namespace FFXIVClientStructs.FFXIV.Client.UI;

// Client::UI::AddonChatLogPanel
//   Component::GUI::AtkUnitBase
//     Component::GUI::AtkEventListener
[Addon("ChatLogPanel_0", "ChatLogPanel_1", "ChatLogPanel_2", "ChatLogPanel_3")]
[GenerateInterop]
[Inherits<AtkUnitBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x3E0)]
public unsafe partial struct AddonChatLogPanel {
    [FieldOffset(0x268)] public AtkTextNode* ChatText;

    [FieldOffset(0x278)] public LogViewer LogViewer;
}
