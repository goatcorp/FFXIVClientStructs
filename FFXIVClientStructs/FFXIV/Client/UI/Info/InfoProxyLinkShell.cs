using FFXIVClientStructs.FFXIV.Client.System.String;

namespace FFXIVClientStructs.FFXIV.Client.UI.Info;

[InfoProxy(InfoProxyId.LinkShell)]
[StructLayout(LayoutKind.Explicit, Size = 0x1E8)]
public unsafe partial struct InfoProxyLinkShell {
    [FieldOffset(0x000)] public InfoProxyInterface InfoProxyInterface;
    [FieldOffset(0x038)] public Utf8String UnkString0;
    [FieldOffset(0x0A0)] public Utf8String UnkString1;

    [FixedSizeArray<Entry>(8)]
    [FieldOffset(0x108)] public fixed byte LinkShells[8 * 0x18];

    [MemberFunction("3B 51 10 73 0F 8B C2 48 83 C0 0B")]
    public partial ulong* GetLinkshellInfo(uint index);

    [MemberFunction("E8 ?? ?? ?? ?? 4C 8B C8 44 8D 47 01")]
    public partial byte* GetLinkshellName(ulong* info);

    //0x20 bytes
    [StructLayout(LayoutKind.Explicit, Size = 0x18)]
    public struct Entry {

    }
}
