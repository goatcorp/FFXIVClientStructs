using FFXIVClientStructs.FFXIV.Client.System.Framework;
using UserFileEvent = FFXIVClientStructs.FFXIV.Client.UI.Misc.UserFileManager.UserFileEvent;

namespace FFXIVClientStructs.FFXIV.Client.UI.Misc;

// Client::UI::Misc::FlagStatusModule
//   Client::UI::Misc::UserFileManager::UserFileEvent
// ctor "E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? 49 8B D4 E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? 49 8B D4 E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? 49 8B D4 E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8D 8F ?? ?? ?? ?? E8"
[GenerateInterop]
[Inherits<UserFileEvent>]
[StructLayout(LayoutKind.Explicit, Size = 0x2A8)]
public unsafe partial struct FlagStatusModule {
    public static FlagStatusModule* Instance() => Framework.Instance()->GetUIModule()->GetFlagStatusModule();

    /// <remarks>
    /// 13 = Default Currency Setting (Index of Rotation array in UIModule.UIModuleHelpers.CurrencySettings)
    /// </remarks>
    [FieldOffset(0x1A4), FixedSizeArray] internal FixedSizeArray64<byte> _flags;
}
