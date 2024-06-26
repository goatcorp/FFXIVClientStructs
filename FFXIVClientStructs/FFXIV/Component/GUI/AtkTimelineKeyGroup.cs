namespace FFXIVClientStructs.FFXIV.Component.GUI;

[StructLayout(LayoutKind.Explicit, Size = 0x10)]
public unsafe struct AtkTimelineKeyGroup {
    [FieldOffset(0x00)] public ushort KeyFrameCount;
    [FieldOffset(0x02)] public AtkTimelineKeyGroupType Type;
    [FieldOffset(0x08)] public AtkTimelineKeyFrame* KeyFrames;
}

public enum AtkTimelineKeyGroupType : ushort {
    Float2,
    Float,
    Byte,
    NodeTint,
    UShort,
    RGB,
    Label,
    Short,
    None = 0xFFFF
}
