using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;

namespace ImGuiNET
{
    public unsafe partial struct ImGuiTableSettings
    {
        public uint ID;
        public ImGuiTableFlags SaveFlags;
        public float RefScale;
        public short ColumnsCount;
        public short ColumnsCountMax;
        public byte WantApply;
    }
    public unsafe partial struct ImGuiTableSettingsPtr
    {
        public ImGuiTableSettings* NativePtr { get; }
        public ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => NativePtr = nativePtr;
        public ImGuiTableSettingsPtr(IntPtr nativePtr) => NativePtr = (ImGuiTableSettings*)nativePtr;
        public static implicit operator ImGuiTableSettingsPtr(ImGuiTableSettings* nativePtr) => new ImGuiTableSettingsPtr(nativePtr);
        public static implicit operator ImGuiTableSettings* (ImGuiTableSettingsPtr wrappedPtr) => wrappedPtr.NativePtr;
        public static implicit operator ImGuiTableSettingsPtr(IntPtr nativePtr) => new ImGuiTableSettingsPtr(nativePtr);
        public static implicit operator IntPtr(ImGuiTableSettingsPtr self) => (IntPtr)self.NativePtr;
        public ref uint ID => ref Unsafe.AsRef<uint>(&NativePtr->ID);
        public ref ImGuiTableFlags SaveFlags => ref Unsafe.AsRef<ImGuiTableFlags>(&NativePtr->SaveFlags);
        public ref float RefScale => ref Unsafe.AsRef<float>(&NativePtr->RefScale);
        public ref short ColumnsCount => ref Unsafe.AsRef<short>(&NativePtr->ColumnsCount);
        public ref short ColumnsCountMax => ref Unsafe.AsRef<short>(&NativePtr->ColumnsCountMax);
        public ref bool WantApply => ref Unsafe.AsRef<bool>(&NativePtr->WantApply);
        public void Destroy()
        {
            ImGuiNative.ImGuiTableSettings_destroy((ImGuiTableSettings*)(NativePtr));
        }
        public ImGuiTableColumnSettingsPtr GetColumnSettings()
        {
            ImGuiTableColumnSettings* ret = ImGuiNative.ImGuiTableSettings_GetColumnSettings((ImGuiTableSettings*)(NativePtr));
            return new ImGuiTableColumnSettingsPtr(ret);
        }
    }
}
