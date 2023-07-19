using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ImGuiNET
{
    public static unsafe partial class ImGuiNative
    {
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igAcceptDragDropPayload(byte* type, ImGuiDragDropFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igActivateItem(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igAddContextHook(IntPtr context, ImGuiContextHook* hook);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAddSettingsHandler(ImGuiSettingsHandler* handler);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igAlignTextToFramePadding();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButton(byte* str_id, ImGuiDir dir);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igArrowButtonEx(byte* str_id, ImGuiDir dir, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBegin(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChild_Str(byte* str_id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChild_ID(uint id, Vector2 size, byte border, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildEx(byte* name, uint id, Vector2 size_arg, byte border, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginChildFrame(uint id, Vector2 size, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginColumns(byte* str_id, int count, ImGuiOldColumnFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginCombo(byte* label, byte* preview_value, ImGuiComboFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginComboPopup(uint popup_id, ImRect bb, ImGuiComboFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginComboPreview();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDisabled(byte disabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDockableDragDropSource(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDockableDragDropTarget(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginDocked(ImGuiWindow* window, byte* p_open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropSource(ImGuiDragDropFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTarget();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginDragDropTargetCustom(ImRect bb, uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBeginGroup();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginListBox(byte* label, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMainMenuBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenu(byte* label, byte enabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginMenuEx(byte* label, byte* icon, byte enabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopup(byte* str_id, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextItem(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextVoid(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupContextWindow(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupEx(uint id, ImGuiWindowFlags extra_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginPopupModal(byte* name, byte* p_open, ImGuiWindowFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBar(byte* str_id, ImGuiTabBarFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabBarEx(ImGuiTabBar* tab_bar, ImRect bb, ImGuiTabBarFlags flags, ImGuiDockNode* dock_node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTabItem(byte* label, byte* p_open, ImGuiTabItemFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTable(byte* str_id, int column, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTableEx(byte* name, uint id, int columns_count, ImGuiTableFlags flags, Vector2 outer_size, float inner_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTooltip();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginTooltipEx(ImGuiTooltipFlags tooltip_flags, ImGuiWindowFlags extra_window_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igBeginViewportSideBar(byte* name, ImGuiViewport* viewport, ImGuiDir dir, float size, ImGuiWindowFlags window_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBack(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayBehind(ImGuiWindow* window, ImGuiWindow* above_window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToDisplayFront(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBringWindowToFocusFront(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBullet();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igBulletText(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButton(byte* label, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonBehavior(ImRect bb, uint id, byte* out_hovered, byte* out_held, ImGuiButtonFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igButtonEx(byte* label, Vector2 size_arg, ImGuiButtonFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcItemSize(Vector2* pOut, Vector2 size, float default_w, float default_h);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcItemWidth();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawFlags igCalcRoundingFlagsForRectInRect(ImRect r_in, ImRect r_outer, float threshold);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcTextSize(Vector2* pOut, byte* text, byte* text_end, byte hide_text_after_double_hash, float wrap_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igCalcTypematicRepeatAmount(float t0, float t1, float repeat_delay, float repeat_rate);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCalcWindowNextAutoFitSize(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igCalcWrapWidthForPos(Vector2 pos, float wrap_pos_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCallContextHooks(IntPtr context, ImGuiContextHookType type);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckbox(byte* label, byte* v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_IntPtr(byte* label, int* flags, int flags_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_UintPtr(byte* label, uint* flags, uint flags_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_S64Ptr(byte* label, long* flags, long flags_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCheckboxFlags_U64Ptr(byte* label, ulong* flags, ulong flags_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearActiveID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearDragDrop();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearIniSettings();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClearWindowSettings(byte* name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCloseButton(uint id, Vector2 pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igCloseCurrentPopup();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsExceptModals();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupsOverWindow(ImGuiWindow* ref_window, byte restore_focus_to_window_under_popup);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igClosePopupToLevel(int remaining, byte restore_focus_to_window_under_popup);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapseButton(uint id, Vector2 pos, ImGuiDockNode* dock_node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeader_TreeNodeFlags(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCollapsingHeader_BoolPtr(byte* label, byte* p_visible, ImGuiTreeNodeFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorButton(byte* desc_id, Vector4 col, ImGuiColorEditFlags flags, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igColorConvertFloat4ToU32(Vector4 @in);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertHSVtoRGB(float h, float s, float v, float* out_r, float* out_g, float* out_b);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertRGBtoHSV(float r, float g, float b, float* out_h, float* out_s, float* out_v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorConvertU32ToFloat4(Vector4* pOut, uint @in);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit3(byte* label, float* col, ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorEdit4(byte* label, float* col, ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorEditOptionsPopup(float* col, ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker3(byte* label, float* col, ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igColorPicker4(byte* label, float* col, ImGuiColorEditFlags flags, float* ref_col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorPickerOptionsPopup(float* ref_col, ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColorTooltip(byte* text, float* col, ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igColumns(int count, byte* id, byte border);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCombo_Str_arr(byte* label, int* current_item, char* * items, int items_count, int popup_max_height_in_items);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igCombo_Str(byte* label, int* current_item, byte* items_separated_by_zeros, int popup_max_height_in_items);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey igConvertShortcutMod(ImGuiKey key_chord);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey igConvertSingleModFlagToKey(IntPtr ctx, ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igCreateContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igCreateNewWindowSettings(byte* name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeApplyFromText(byte* buf, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDataTypeApplyOp(ImGuiDataType data_type, int op, void* output, void* arg_1, void* arg_2);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDataTypeClamp(ImGuiDataType data_type, void* p_data, void* p_min, void* p_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeCompare(ImGuiDataType data_type, void* arg_1, void* arg_2);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDataTypeFormatString(byte* buf, int buf_size, ImGuiDataType data_type, void* p_data, byte* format);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDataTypeInfo* igDataTypeGetInfo(ImGuiDataType data_type);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDebugCheckVersionAndDataLayout(byte* version_str, uint sz_io, uint sz_style, uint sz_vec2, uint sz_vec4, uint sz_drawvert, uint sz_drawidx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugDrawItemRect(uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugHookIdInfo(uint id, ImGuiDataType data_type, void* data_id, void* data_id_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLocateItem(uint target_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLocateItemOnHover(uint target_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLocateItemResolveWithLastItem();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugLog(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeColumns(ImGuiOldColumns* columns);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDockNode(ImGuiDockNode* node, byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawCmdShowMeshAndBoundingBox(ImDrawList* out_draw_list, ImDrawList* draw_list, ImDrawCmd* draw_cmd, byte show_mesh, byte show_aabb);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeDrawList(ImGuiWindow* window, ImGuiViewportP* viewport, ImDrawList* draw_list, byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeFont(ImFont* font);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeFontGlyph(ImFont* font, ImFontGlyph* glyph);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeInputTextState(ImGuiInputTextState* state);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeStorage(ImGuiStorage* storage, byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTabBar(ImGuiTabBar* tab_bar, byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTable(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeTableSettings(ImGuiTableSettings* settings);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeViewport(ImGuiViewportP* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindow(ImGuiWindow* window, byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowSettings(ImGuiWindowSettings* settings);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsList(ImVector* windows, byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugNodeWindowsListByBeginStackParent(ImGuiWindow** windows, int windows_size, ImGuiWindow* parent_in_begin_stack);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugRenderKeyboardPreview(ImDrawList* draw_list);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugRenderViewportThumbnail(ImDrawList* draw_list, ImGuiViewportP* viewport, ImRect bb);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugStartItemPicker();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDebugTextEncoding(byte* text);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyContext(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyPlatformWindow(ImGuiViewportP* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDestroyPlatformWindows();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockBuilderAddNode(uint node_id, ImGuiDockNodeFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyDockSpace(uint src_dockspace_id, uint dst_dockspace_id, ImVector* in_window_remap_pairs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyNode(uint src_node_id, uint dst_node_id, ImVector* out_node_remap_pairs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderCopyWindowSettings(byte* src_name, byte* dst_name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderDockWindow(byte* window_name, uint node_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderFinish(uint node_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockBuilderGetCentralNode(uint node_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockBuilderGetNode(uint node_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNode(uint node_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNodeChildNodes(uint node_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderRemoveNodeDockedWindows(uint node_id, byte clear_settings_refs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderSetNodePos(uint node_id, Vector2 pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockBuilderSetNodeSize(uint node_id, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockBuilderSplitNode(uint node_id, ImGuiDir split_dir, float size_ratio_for_node_at_dir, uint* out_id_at_dir, uint* out_id_at_opposite_dir);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockContextCalcDropPosForDocking(ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload_window, ImGuiDockNode* payload_node, ImGuiDir split_dir, byte split_outer, Vector2* out_pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextClearNodes(IntPtr ctx, uint root_id, byte clear_settings_refs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextEndFrame(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockContextFindNodeByID(IntPtr ctx, uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockContextGenNodeID(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextInitialize(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextNewFrameUpdateDocking(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextNewFrameUpdateUndocking(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextProcessUndockNode(IntPtr ctx, ImGuiDockNode* node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextProcessUndockWindow(IntPtr ctx, ImGuiWindow* window, byte clear_persistent_docking_ref);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueDock(IntPtr ctx, ImGuiWindow* target, ImGuiDockNode* target_node, ImGuiWindow* payload, ImGuiDir split_dir, float split_ratio, byte split_outer);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueUndockNode(IntPtr ctx, ImGuiDockNode* node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextQueueUndockWindow(IntPtr ctx, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextRebuildNodes(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockContextShutdown(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockNodeBeginAmendTabBar(ImGuiDockNode* node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockNodeEndAmendTabBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igDockNodeGetDepth(ImGuiDockNode* node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igDockNodeGetRootNode(ImGuiDockNode* node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockNodeGetWindowMenuButtonId(ImGuiDockNode* node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDockNodeIsInHierarchyOf(ImGuiDockNode* node, ImGuiDockNode* parent);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDockNodeWindowMenuHandler_Default(IntPtr ctx, ImGuiDockNode* node, ImGuiTabBar* tab_bar);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockSpace(uint id, Vector2 size, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igDockSpaceOverViewport(ImGuiViewport* viewport, ImGuiDockNodeFlags flags, ImGuiWindowClass* window_class);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragBehavior(uint id, ImGuiDataType data_type, void* p_v, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat2(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat3(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloat4(byte* label, float* v, float v_speed, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragFloatRange2(byte* label, float* v_current_min, float* v_current_max, float v_speed, float v_min, float v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt2(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt3(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragInt4(byte* label, int* v, float v_speed, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragIntRange2(byte* label, int* v_current_min, int* v_current_max, float v_speed, int v_min, int v_max, byte* format, byte* format_max, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalar(byte* label, ImGuiDataType data_type, void* p_data, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igDragScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, float v_speed, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igDummy(Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEnd();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChild();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndChildFrame();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndColumns();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndCombo();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndComboPreview();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDisabled();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropSource();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndDragDropTarget();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndFrame();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndGroup();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndListBox();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMainMenuBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenu();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndMenuBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndPopup();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTabItem();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTable();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igEndTooltip();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckEndFrameRecover(ImGuiErrorLogCallback log_callback, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckEndWindowRecover(ImGuiErrorLogCallback log_callback, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igErrorCheckUsingSetCursorPosToExtendParentBoundaries();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopup(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFindBestWindowPosForPopupEx(Vector2* pOut, Vector2 ref_pos, Vector2 size, ImGuiDir* last_dir, ImRect r_outer, ImRect r_avoid, ImGuiPopupPositionPolicy policy);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindBottomMostVisibleWindowWithinBeginStack(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewportP* igFindHoveredViewportFromPlatformWindowStack(Vector2 mouse_platform_pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* igFindOrCreateColumns(ImGuiWindow* window, uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igFindRenderedTextEnd(byte* text, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* igFindSettingsHandler(byte* type_name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igFindViewportByID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igFindViewportByPlatformHandle(void* platform_handle);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igFindWindowByName(byte* name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igFindWindowDisplayIndex(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettingsByID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* igFindWindowSettingsByWindow(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusTopMostWindowUnderOne(ImGuiWindow* under_this_window, ImGuiWindow* ignore_window, ImGuiViewport* filter_viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igFocusWindow(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcAwakeTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientMiscBuffers();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGcCompactTransientWindowBuffers(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetActiveID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetAllocatorFunctions(IntPtr* p_alloc_func, IntPtr* p_free_func, void** p_user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawList_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetBackgroundDrawList_ViewportPtr(ImGuiViewport* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetClipboardText();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32_Col(ImGuiCol idx, float alpha_mul);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32_Vec4(Vector4 col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColorU32_U32(uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnIndex();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnNormFromOffset(ImGuiOldColumns* columns, float offset);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffset(int column_index);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnOffsetFromNorm(ImGuiOldColumns* columns, float offset_norm);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetColumnsCount();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetColumnsID(byte* str_id, int count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetColumnWidth(int column_index);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionAvail(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMax(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetContentRegionMaxAbs(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetCurrentContext();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetCurrentFocusScope();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* igGetCurrentTabBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* igGetCurrentTable();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindow();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetCurrentWindowRead();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorPos(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosX();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetCursorPosY();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorScreenPos(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetCursorStartPos(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetDefaultFont();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* igGetDragDropPayload();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* igGetDrawData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igGetDrawListSharedData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetFocusID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* igGetFont();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFontSize();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetFontTexUvWhitePixel(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawList_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawList_ViewportPtr(ImGuiViewport* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetForegroundDrawList_WindowPtr(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetFrameCount();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeight();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetFrameHeightWithSpacing();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetHoveredID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_Str(byte* str_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetID_Ptr(void* ptr_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDWithSeed_Str(byte* str_id_begin, byte* str_id_end, uint seed);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetIDWithSeed_Int(int n, uint seed);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* igGetInputTextState(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* igGetIO();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern nint igGetItemFlags();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetItemID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMax(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectMin(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetItemRectSize(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiItemStatusFlags igGetItemStatusFlags();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetKeyChordName(ImGuiKey key_chord, byte* out_buf, int out_buf_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyData* igGetKeyData_ContextPtr(IntPtr ctx, ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyData* igGetKeyData_Key(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey igGetKeyIndex(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetKeyMagnitude2d(Vector2* pOut, ImGuiKey key_left, ImGuiKey key_right, ImGuiKey key_up, ImGuiKey key_down);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetKeyName(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetKeyOwner(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyOwnerData* igGetKeyOwnerData(IntPtr ctx, ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetKeyPressedAmount(ImGuiKey key, float repeat_delay, float rate);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetMainViewport();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igGetMouseClickedCount(ImGuiMouseButton button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMouseCursor igGetMouseCursor();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMouseDragDelta(Vector2* pOut, ImGuiMouseButton button, float lock_threshold);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePos(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetMousePosOnOpeningCurrentPopup(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetNavTweakPressedAmount(ImGuiAxis axis);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* igGetPlatformIO();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetPopupAllowedExtentRect(ImRect* pOut, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxX();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollMaxY();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollX();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetScrollY();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyRoutingData* igGetShortcutRoutingData(ImGuiKey key_chord);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStorage* igGetStateStorage();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* igGetStyle();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetStyleColorName(ImGuiCol idx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* igGetStyleColorVec4(ImGuiCol idx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDataVarInfo* igGetStyleVarInfo(ImGuiStyleVar idx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeight();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTextLineHeightWithSpacing();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igGetTime();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostAndVisiblePopupModal();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* igGetTopMostPopupModal();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetTreeNodeToLabelSpacing();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetTypematicRepeatRate(ImGuiInputFlags flags, float* repeat_delay, float* repeat_rate);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igGetVersion();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* igGetViewportPlatformMonitor(ImGuiViewport* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igGetWindowAlwaysWantOwnTabBar(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMax(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowContentRegionMin(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowDockID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* igGetWindowDockNode();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowDpiScale();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* igGetWindowDrawList();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowHeight();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowPos(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeBorderID(ImGuiWindow* window, ImGuiDir dir);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowResizeCornerID(ImGuiWindow* window, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igGetWindowScrollbarID(ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowScrollbarRect(ImRect* pOut, ImGuiWindow* window, ImGuiAxis axis);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igGetWindowSize(Vector2* pOut);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* igGetWindowViewport();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igGetWindowWidth();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImAbs_Int(int x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImAbs_Float(float x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImAbs_double(double x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImage(IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 tint_col, Vector4 border_col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButton(byte* str_id, IntPtr user_texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImageButtonEx(uint id, IntPtr texture_id, Vector2 size, Vector2 uv0, Vector2 uv1, Vector4 bg_col, Vector4 tint_col, ImGuiButtonFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImAlphaBlendColors(uint col_a, uint col_b);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, float t);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPoint(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierCubicClosestPointCasteljau(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 p, float tess_tol);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBezierQuadraticCalc(Vector2* pOut, Vector2 p1, Vector2 p2, Vector2 p3, float t);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArrayClearAllBits(uint* arr, int bitcount);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArrayClearBit(uint* arr, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImBitArrayGetStorageSizeInBytes(int bitcount);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBit(uint* arr, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImBitArraySetBitRange(uint* arr, int n, int n2);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImBitArrayTestBit(uint* arr, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankA(byte c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImCharIsBlankW(uint c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImClamp(Vector2* pOut, Vector2 v, Vector2 mn, Vector2 mx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImDot(Vector2 a, Vector2 b);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImExponentialMovingAverage(float avg, float sample, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImFileClose(IntPtr file);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileGetSize(IntPtr file);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igImFileLoadToMemory(byte* filename, byte* mode, uint* out_file_size, int padding_bytes);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr igImFileOpen(byte* filename, byte* mode);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileRead(void* data, ulong size, ulong count, IntPtr file);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong igImFileWrite(void* data, ulong size, ulong count, IntPtr file);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloor_Float(float f);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloor_Vec2(Vector2* pOut, Vector2 v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImFloorSigned_Float(float f);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFloorSigned_Vec2(Vector2* pOut, Vector2 v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildFinish(ImFontAtlas* atlas);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildInit(ImFontAtlas* atlas);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyCalcLookupTable(byte* out_table, float in_multiply_factor);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildMultiplyRectAlpha8(byte* table, byte* pixels, int x, int y, int w, int h, int stride);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildPackCustomRects(ImFontAtlas* atlas, void* stbrp_context_opaque);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRender32bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, uint in_marker_pixel_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildRender8bppRectFromString(ImFontAtlas* atlas, int x, int y, int w, int h, byte* in_str, byte in_marker_char, byte in_marker_pixel_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFontAtlasBuildSetupFont(ImFontAtlas* atlas, ImFont* font, ImFontConfig* font_config, float ascent, float descent);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr* igImFontAtlasGetBuilderForStbTruetype();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImFormatString(byte* buf, uint buf_size, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImFormatStringToTempBuffer(byte** out_buf, byte** out_buf_end, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDir igImGetDirQuadrantFromDelta(float dx, float dy);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashData(void* data, uint data_size, uint seed);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igImHashStr(byte* data, uint data_size, uint seed);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImInvLength(Vector2 lhs, float fail_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsFloatAboveGuaranteedIntegerPrecision(float f);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo_Int(int v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImIsPowerOfTwo_U64(ulong v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqr_Vec2(Vector2 lhs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLengthSqr_Vec4(Vector4 lhs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec2Float(Vector2* pOut, Vector2 a, Vector2 b, float t);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec2Vec2(Vector2* pOut, Vector2 a, Vector2 b, Vector2 t);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLerp_Vec4(Vector4* pOut, Vector4 a, Vector4 b, float t);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLinearSweep(float current, float target, float speed);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImLineClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 p);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImLog_Float(float x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImLog_double(double x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMax(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMin(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImModPositive(int a, int b);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImMul(Vector2* pOut, Vector2 lhs, Vector2 rhs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindEnd(byte* format);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatFindStart(byte* format);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImParseFormatPrecision(byte* format, int default_value);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImParseFormatSanitizeForPrinting(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatSanitizeForScanning(byte* fmt_in, byte* fmt_out, uint fmt_out_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImParseFormatTrimDecorations(byte* format, byte* buf, uint buf_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImPow_Float(float x, float y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImPow_double(double x, double y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImRotate(Vector2* pOut, Vector2 v, float cos_a, float sin_a);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImRsqrt_Float(float x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImRsqrt_double(double x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSaturate(float f);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImSign_Float(float x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern double igImSign_double(double x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* igImStrbolW(int* buf_mid_line, int* buf_begin);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrchrRange(byte* str_begin, byte* str_end, byte c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdup(byte* str);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrdupcpy(byte* dst, uint* p_dst_size, byte* str);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStreolRange(byte* str, byte* str_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStricmp(byte* str1, byte* str2);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStristr(byte* haystack, byte* haystack_end, byte* needle, byte* needle_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrlenW(int* str);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrncpy(byte* dst, byte* src, uint count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImStrnicmp(byte* str1, byte* str2, uint count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImStrSkipBlank(byte* str);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImStrTrimBlanks(byte* str);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCharFromUtf8(uint* out_char, byte* in_text, byte* in_text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igImTextCharToUtf8(byte* out_buf, uint c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountCharsFromUtf8(byte* in_text, byte* in_text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromChar(byte* in_text, byte* in_text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextCountUtf8BytesFromStr(int* in_text, int* in_text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrFromUtf8(int* out_buf, int out_buf_size, byte* in_text, byte* in_text_end, byte** in_remaining);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImTextStrToUtf8(byte* out_buf, int out_buf_size, int* in_text, int* in_text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImToUpper(byte c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igImTriangleArea(Vector2 a, Vector2 b, Vector2 c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleBarycentricCoords(Vector2 a, Vector2 b, Vector2 c, Vector2 p, float* out_u, float* out_v, float* out_w);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igImTriangleClosestPoint(Vector2* pOut, Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igImTriangleContainsPoint(Vector2 a, Vector2 b, Vector2 c, Vector2 p);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igImUpperPowerOfTwo(int v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igIndent(float indent_w);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInitialize();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputDouble(byte* label, double* v, double step, double step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat(byte* label, float* v, float step, float step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat2(byte* label, float* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat3(byte* label, float* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputFloat4(byte* label, float* v, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt(byte* label, int* v, int step, int step_fast, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt2(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt3(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputInt4(byte* label, int* v, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_step, void* p_step_fast, byte* format, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputText(byte* label, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igInputTextDeactivateHook(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextEx(byte* label, byte* hint, byte* buf, int buf_size, Vector2 size_arg, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextMultiline(byte* label, byte* buf, uint buf_size, Vector2 size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInputTextWithHint(byte* label, byte* hint, byte* buf, uint buf_size, ImGuiInputTextFlags flags, ImGuiInputTextCallback callback, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igInvisibleButton(byte* str_id, Vector2 size, ImGuiButtonFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsActiveIdUsingNavDir(ImGuiDir dir);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAliasKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemActive();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemFocused();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyItemHovered();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsAnyMouseDown();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsClippedEx(ImRect bb, uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropActive();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsDragDropPayloadBeingAccepted();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsGamepadKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActivated();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemActive();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemClicked(ImGuiMouseButton mouse_button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivated();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemDeactivatedAfterEdit();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemEdited();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemFocused();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemHovered(ImGuiHoveredFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledOpen();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemToggledSelection();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsItemVisible();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyboardKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown_Nil(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyDown_ID(ImGuiKey key, uint owner_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed_Bool(ImGuiKey key, byte repeat);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressed_ID(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyPressedMap(ImGuiKey key, byte repeat);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased_Nil(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsKeyReleased_ID(ImGuiKey key, uint owner_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsLegacyKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked_Bool(ImGuiMouseButton button, byte repeat);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseClicked_ID(ImGuiMouseButton button, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDoubleClicked(ImGuiMouseButton button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown_Nil(ImGuiMouseButton button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDown_ID(ImGuiMouseButton button, uint owner_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragging(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseDragPastThreshold(ImGuiMouseButton button, float lock_threshold);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseHoveringRect(Vector2 r_min, Vector2 r_max, byte clip);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMousePosValid(Vector2* mouse_pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased_Nil(ImGuiMouseButton button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsMouseReleased_ID(ImGuiMouseButton button, uint owner_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNamedKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsNamedKeyOrModKey(ImGuiKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpen_Str(byte* str_id, ImGuiPopupFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsPopupOpen_ID(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisible_Nil(Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsRectVisible_Vec2(Vector2 rect_min, Vector2 rect_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAbove(ImGuiWindow* potential_above, ImGuiWindow* potential_below);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowAppearing();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowChildOf(ImGuiWindow* window, ImGuiWindow* potential_parent, byte popup_hierarchy, byte dock_hierarchy);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowCollapsed();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowContentHoverable(ImGuiWindow* window, ImGuiHoveredFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowDocked();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowFocused(ImGuiFocusedFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowHovered(ImGuiHoveredFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowNavFocusable(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igIsWindowWithinBeginStackOf(ImGuiWindow* window, ImGuiWindow* potential_parent);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemAdd(ImRect bb, uint id, ImRect* nav_bb, nint extra_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igItemHoverable(ImRect bb, uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSize_Vec2(Vector2 size, float text_baseline_y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igItemSize_Rect(ImRect bb, float text_baseline_y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igKeepAliveID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLabelText(byte* label, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igListBox_Str_arr(byte* label, int* current_item, char* * items, int items_count, int height_in_items);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromDisk(byte* ini_filename);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLoadIniSettingsFromMemory(byte* ini_data, uint ini_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igLocalizeGetMsg(ImGuiLocKey key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLocalizeRegisterEntries(ImGuiLocEntry* entries, int count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogBegin(ImGuiLogType type, int auto_open_depth);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogButtons();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogFinish();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogRenderedText(Vector2* ref_pos, byte* text, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogSetNextTextDecoration(byte* prefix, byte* suffix);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogText(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToBuffer(int auto_open_depth);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToClipboard(int auto_open_depth);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToFile(int auto_open_depth, byte* filename);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igLogToTTY(int auto_open_depth);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirty_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkIniSettingsDirty_WindowPtr(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMarkItemEdited(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* igMemAlloc(uint size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igMemFree(void* ptr);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItem_Bool(byte* label, byte* shortcut, byte selected, byte enabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItem_BoolPtr(byte* label, byte* shortcut, byte* p_selected, byte enabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igMenuItemEx(byte* label, byte* icon, byte* shortcut, byte selected, byte enabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKey igMouseButtonToKey(ImGuiMouseButton button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitRequestApplyResult();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavInitWindow(ImGuiWindow* window, byte force_reinit);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestApplyResult();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igNavMoveRequestButNoResultYet();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestCancel();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestForward(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestResolveWithLastItem(ImGuiNavItemData* result);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestSubmit(ImGuiDir move_dir, ImGuiDir clip_dir, ImGuiNavMoveFlags move_flags, ImGuiScrollFlags scroll_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNavMoveRequestTryWrapping(ImGuiWindow* window, ImGuiNavMoveFlags move_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewFrame();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNewLine();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igNextColumn();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup_Str(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopup_ID(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupEx(uint id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igOpenPopupOnItemClick(byte* str_id, ImGuiPopupFlags popup_flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotHistogram_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPlotLines_FloatPtr(byte* label, float* values, int values_count, int values_offset, byte* overlay_text, float scale_min, float scale_max, Vector2 graph_size, int stride);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopButtonRepeat();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopClipRect();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopColumnsBackground();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFocusScope();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopFont();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopID();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemFlag();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopItemWidth();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleColor(int count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopStyleVar(int count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopTabStop();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPopTextWrapPos();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igProgressBar(float fraction, Vector2 size_arg, byte* overlay);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushButtonRepeat(byte repeat);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushClipRect(Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnClipRect(int column_index);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushColumnsBackground();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFocusScope(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushFont(ImFont* font);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_Str(byte* str_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_StrStr(byte* str_id_begin, byte* str_id_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_Ptr(void* ptr_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushID_Int(int int_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemFlag(nint option, byte enabled);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushItemWidth(float item_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushMultiItemsWidths(int components, float width_full);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushOverrideID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColor_U32(ImGuiCol idx, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleColor_Vec4(ImGuiCol idx, Vector4 col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVar_Float(ImGuiStyleVar idx, float val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushStyleVar_Vec2(ImGuiStyleVar idx, Vector2 val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushTabStop(byte tab_stop);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igPushTextWrapPos(float wrap_local_pos_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButton_Bool(byte* label, byte active);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igRadioButton_IntPtr(byte* label, int* v, int v_button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveContextHook(IntPtr context, uint hook_to_remove);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRemoveSettingsHandler(byte* type_name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRender();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrow(ImDrawList* draw_list, Vector2 pos, uint col, ImGuiDir dir, float scale);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowDockMenu(ImDrawList* draw_list, Vector2 p_min, float sz, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderArrowPointingAt(ImDrawList* draw_list, Vector2 pos, Vector2 half_sz, ImGuiDir direction, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderBullet(ImDrawList* draw_list, Vector2 pos, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderCheckMark(ImDrawList* draw_list, Vector2 pos, uint col, float sz);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderColorRectWithAlphaCheckerboard(ImDrawList* draw_list, Vector2 p_min, Vector2 p_max, uint fill_col, float grid_step, Vector2 grid_off, float rounding, ImDrawFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderDragDropTargetRect(ImRect bb);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrame(Vector2 p_min, Vector2 p_max, uint fill_col, byte border, float rounding);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderFrameBorder(Vector2 p_min, Vector2 p_max, float rounding);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderMouseCursor(Vector2 pos, float scale, ImGuiMouseCursor mouse_cursor, uint col_fill, uint col_border, uint col_shadow);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderNavHighlight(ImRect bb, uint id, ImGuiNavHighlightFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderPlatformWindowsDefault(void* platform_render_arg, void* renderer_render_arg);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledRangeH(ImDrawList* draw_list, ImRect rect, uint col, float x_start_norm, float x_end_norm, float rounding);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderRectFilledWithHole(ImDrawList* draw_list, ImRect outer, ImRect inner, uint col, float rounding);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderText(Vector2 pos, byte* text, byte* text_end, byte hide_text_after_hash);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClipped(Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextClippedEx(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, byte* text, byte* text_end, Vector2* text_size_if_known, Vector2 align, ImRect* clip_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextEllipsis(ImDrawList* draw_list, Vector2 pos_min, Vector2 pos_max, float clip_max_x, float ellipsis_max_x, byte* text, byte* text_end, Vector2* text_size_if_known);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igRenderTextWrapped(Vector2 pos, byte* text, byte* text_end, float wrap_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igResetMouseDragDelta(ImGuiMouseButton button);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSameLine(float offset_from_start_x, float spacing);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSaveIniSettingsToDisk(byte* ini_filename);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igSaveIniSettingsToMemory(uint* out_ini_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScaleWindowsInViewport(ImGuiViewportP* viewport, float scale);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollbar(ImGuiAxis axis);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igScrollbarEx(ImRect bb, uint id, ImGuiAxis axis, long* p_scroll_v, long avail_v, long contents_v, ImDrawFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToBringRectIntoView(ImGuiWindow* window, ImRect rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToItem(ImGuiScrollFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToRect(ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igScrollToRectEx(Vector2* pOut, ImGuiWindow* window, ImRect rect, ImGuiScrollFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectable_Bool(byte* label, byte selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSelectable_BoolPtr(byte* label, byte* p_selected, ImGuiSelectableFlags flags, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparator();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorEx(ImGuiSeparatorFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorText(byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSeparatorTextEx(uint id, byte* label, byte* label_end, float extra_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveID(uint id, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetActiveIdUsingAllKeyboardKeys();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetAllocatorFunctions(IntPtr alloc_func, IntPtr free_func, void* user_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetClipboardText(byte* text);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColorEditOptions(ImGuiColorEditFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnOffset(int column_index, float offset_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetColumnWidth(int column_index, float width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentContext(IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentFont(ImFont* font);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCurrentViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPos(Vector2 local_pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosX(float local_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorPosY(float local_y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetCursorScreenPos(Vector2 pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetDragDropPayload(byte* type, void* data, uint sz, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetFocusID(uint id, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetHoveredID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemAllowOverlap();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemDefaultFocus();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetItemKeyOwner(ImGuiKey key, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyboardFocusHere(int offset);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyOwner(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetKeyOwnersForKeyChord(ImGuiKey key, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetLastItemData(uint item_id, nint in_flags, ImGuiItemStatusFlags status_flags, ImRect item_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetMouseCursor(ImGuiMouseCursor cursor_type);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavID(uint id, ImGuiNavLayer nav_layer, uint focus_scope_id, ImRect rect_rel);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNavWindow(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextFrameWantCaptureKeyboard(byte want_capture_keyboard);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextFrameWantCaptureMouse(byte want_capture_mouse);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemOpen(byte is_open, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextItemWidth(float item_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowBgAlpha(float alpha);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowClass(ImGuiWindowClass* window_class);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowCollapsed(byte collapsed, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowContentSize(Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowDockID(uint dock_id, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowFocus();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowPos(Vector2 pos, ImGuiCond cond, Vector2 pivot);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowScroll(Vector2 scroll);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSize(Vector2 size, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowSizeConstraints(Vector2 size_min, Vector2 size_max, ImGuiSizeCallback custom_callback, void* custom_callback_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetNextWindowViewport(uint viewport_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosX_Float(float local_x, float center_x_ratio);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosX_WindowPtr(ImGuiWindow* window, float local_x, float center_x_ratio);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosY_Float(float local_y, float center_y_ratio);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollFromPosY_WindowPtr(ImGuiWindow* window, float local_y, float center_y_ratio);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereX(float center_x_ratio);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollHereY(float center_y_ratio);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollX_Float(float scroll_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollX_WindowPtr(ImGuiWindow* window, float scroll_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollY_Float(float scroll_y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetScrollY_WindowPtr(ImGuiWindow* window, float scroll_y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSetShortcutRouting(ImGuiKey key_chord, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetStateStorage(ImGuiStorage* storage);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTabItemClosed(byte* tab_or_docked_window_label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetTooltip(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowClipRectBeforeSetChannel(ImGuiWindow* window, ImRect clip_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_Bool(byte collapsed, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_Str(byte* name, byte collapsed, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowCollapsed_WindowPtr(ImGuiWindow* window, byte collapsed, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowDock(ImGuiWindow* window, uint dock_id, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocus_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFocus_Str(byte* name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowFontScale(float scale);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowHiddendAndSkipItemsForCurrentFrame(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowHitTestHole(ImGuiWindow* window, Vector2 pos, Vector2 size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_Vec2(Vector2 pos, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_Str(byte* name, Vector2 pos, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowPos_WindowPtr(ImGuiWindow* window, Vector2 pos, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_Vec2(Vector2 size, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_Str(byte* name, Vector2 size, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowSize_WindowPtr(ImGuiWindow* window, Vector2 size, ImGuiCond cond);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSetWindowViewport(ImGuiWindow* window, ImGuiViewportP* viewport);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearColorGradientKeepAlpha(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 gradient_p0, Vector2 gradient_p1, uint col0, uint col1);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShadeVertsLinearUV(ImDrawList* draw_list, int vert_start_idx, int vert_end_idx, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, byte clamp);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShortcut(ImGuiKey key_chord, uint owner_id, ImGuiInputFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowAboutWindow(byte* p_open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDebugLogWindow(byte* p_open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowDemoWindow(byte* p_open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontAtlas(ImFontAtlas* atlas);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowFontSelector(byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowMetricsWindow(byte* p_open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowStackToolWindow(byte* p_open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowStyleEditor(ImGuiStyle* @ref);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igShowStyleSelector(byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShowUserGuide();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShrinkWidths(ImGuiShrinkWidthItem* items, int count, float width_excess);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igShutdown();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderAngle(byte* label, float* v_rad, float v_degrees_min, float v_degrees_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderBehavior(ImRect bb, uint id, ImGuiDataType data_type, void* p_v, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags, ImRect* out_grab_bb);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat2(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat3(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderFloat4(byte* label, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt2(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt3(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderInt4(byte* label, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalar(byte* label, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSliderScalarN(byte* label, ImGuiDataType data_type, void* p_data, int components, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSmallButton(byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igSpacing();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igSplitterBehavior(ImRect bb, uint id, ImGuiAxis axis, float* size1, float* size2, float min_size1, float min_size2, float hover_extend, float hover_visibility_delay, uint bg_col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindow(ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStartMouseMovingWindowOrNode(ImGuiWindow* window, ImGuiDockNode* node, byte undock_floating_node);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsClassic(ImGuiStyle* dst);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsDark(ImGuiStyle* dst);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igStyleColorsLight(ImGuiStyle* dst);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarAddTab(ImGuiTabBar* tab_bar, ImGuiTabItemFlags tab_flags, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarCloseTab(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindMostRecentlySelectedTabForActiveWindow(ImGuiTabBar* tab_bar);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByID(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarFindTabByOrder(ImGuiTabBar* tab_bar, int order);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* igTabBarGetCurrentTab(ImGuiTabBar* tab_bar);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTabBarGetTabName(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTabBarGetTabOrder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabBarProcessReorder(ImGuiTabBar* tab_bar);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueFocus(ImGuiTabBar* tab_bar, ImGuiTabItem* tab);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorder(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, int offset);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarQueueReorderFromMousePos(ImGuiTabBar* tab_bar, ImGuiTabItem* tab, Vector2 mouse_pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabBarRemoveTab(ImGuiTabBar* tab_bar, uint tab_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemBackground(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemButton(byte* label, ImGuiTabItemFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize_Str(Vector2* pOut, byte* label, byte has_close_button_or_unsaved_marker);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemCalcSize_WindowPtr(Vector2* pOut, ImGuiWindow* window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTabItemEx(ImGuiTabBar* tab_bar, byte* label, byte* p_open, ImGuiTabItemFlags flags, ImGuiWindow* docked_window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTabItemLabelAndCloseButton(ImDrawList* draw_list, ImRect bb, ImGuiTabItemFlags flags, Vector2 frame_padding, byte* label, uint tab_id, uint close_button_id, byte is_contents_visible, byte* out_just_closed, byte* out_text_clipped);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginApplyRequests(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginCell(ImGuiTable* table, int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableBeginContextMenuPopup(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginInitMemory(ImGuiTable* table, int columns_count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableBeginRow(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableDrawBorders(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableDrawContextMenu(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableEndCell(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableEndRow(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* igTableFindByID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableFixColumnSortDirection(ImGuiTable* table, ImGuiTableColumn* column);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactSettings();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactTransientBuffers_TablePtr(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGcCompactTransientBuffers_TableTempDataPtr(ImGuiTableTempData* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableGetBoundSettings(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableGetCellBgRect(ImRect* pOut, ImGuiTable* table, int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnCount();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnFlags igTableGetColumnFlags(int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetColumnIndex();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnName_Int(int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* igTableGetColumnName_TablePtr(ImGuiTable* table, int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSortDirection igTableGetColumnNextSortDirection(ImGuiTableColumn* column);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igTableGetColumnResizeID(ImGuiTable* table, int column_n, int instance_no);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetColumnWidthAuto(ImGuiTable* table, ImGuiTableColumn* column);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetHeaderRowHeight();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetHoveredColumn();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableInstanceData* igTableGetInstanceData(ImGuiTable* table, int instance_no);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint igTableGetInstanceID(ImGuiTable* table, int instance_no);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float igTableGetMaxColumnWidth(ImGuiTable* table, int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int igTableGetRowIndex();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* igTableGetSortSpecs();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeader(byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableHeadersRow();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableLoadSettings(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableMergeDrawChannels(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableNextColumn();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableNextRow(ImGuiTableRowFlags row_flags, float min_row_height);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableOpenContextMenu(int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePopBackgroundChannel();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTablePushBackgroundChannel();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableRemove(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableResetSettings(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSaveSettings(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetBgColor(ImGuiTableBgTarget target, uint color, int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnEnabled(int column_n, byte v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTableSetColumnIndex(int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnSortDirection(int column_n, ImGuiSortDirection sort_direction, byte append_to_sort_specs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidth(int column_n, float width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidthAutoAll(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetColumnWidthAutoSingle(ImGuiTable* table, int column_n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSettingsAddSettingsHandler();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsCreate(uint id, int columns_count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* igTableSettingsFindByID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupColumn(byte* label, ImGuiTableColumnFlags flags, float init_width_or_weight, uint user_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupDrawChannels(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSetupScrollFreeze(int cols, int rows);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSortSpecsBuild(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableSortSpecsSanitize(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateBorders(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateColumnsWeightFromWidth(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTableUpdateLayout(ImGuiTable* table);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputIsActive(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputScalar(ImRect bb, uint id, byte* label, ImGuiDataType data_type, void* p_data, byte* format, void* p_clamp_min, void* p_clamp_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTempInputText(ImRect bb, uint id, byte* label, byte* buf, int buf_size, ImGuiInputTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTestKeyOwner(ImGuiKey key, uint owner_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTestShortcutRouting(ImGuiKey key_chord, uint owner_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igText(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextColored(Vector4 col, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextDisabled(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextEx(byte* text, byte* text_end, ImGuiTextFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextUnformatted(byte* text, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTextWrapped(byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTranslateWindowsInViewport(ImGuiViewportP* viewport, Vector2 old_pos, Vector2 new_pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNode_Str(byte* label);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNode_StrStr(byte* str_id, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNode_Ptr(void* ptr_id, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeBehavior(uint id, ImGuiTreeNodeFlags flags, byte* label, byte* label_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeEx_Str(byte* label, ImGuiTreeNodeFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeEx_StrStr(byte* str_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeEx_Ptr(void* ptr_id, ImGuiTreeNodeFlags flags, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreeNodeSetOpen(uint id, byte open);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igTreeNodeUpdateNextOpen(uint id, ImGuiTreeNodeFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePop();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePush_Str(byte* str_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePush_Ptr(void* ptr_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igTreePushOverrideID(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUnindent(float indent_w);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateHoveredWindowAndCaptureFlags();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateInputEvents(byte trickle_fast_inputs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowEndFrame();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateMouseMovingWindowNewFrame();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdatePlatformWindows();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igUpdateWindowParentAndRootLinks(ImGuiWindow* window, ImGuiWindowFlags flags, ImGuiWindow* parent_window);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Bool(byte* prefix, byte b);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Int(byte* prefix, int v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Uint(byte* prefix, uint v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igValue_Float(byte* prefix, float v, byte* float_format);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderFloat(byte* label, Vector2 size, float* v, float v_min, float v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderInt(byte* label, Vector2 size, int* v, int v_min, int v_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte igVSliderScalar(byte* label, Vector2 size, ImGuiDataType data_type, void* p_data, void* p_min, void* p_max, byte* format, ImGuiSliderFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowRectAbsToRel(ImRect* pOut, ImGuiWindow* window, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void igWindowRectRelToAbs(ImRect* pOut, ImGuiWindow* window, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_Clear(ImBitVector* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_ClearBit(ImBitVector* self, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_Create(ImBitVector* self, int sz);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImBitVector_SetBit(ImBitVector* self, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImBitVector_TestBit(ImBitVector* self, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_destroy(ImColor* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_HSV(ImColor* pOut, float h, float s, float v, float a);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Float(float r, float g, float b, float a);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Vec4(Vector4 col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_Int(int r, int g, int b, int a);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImColor* ImColor_ImColor_U32(uint rgba);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImColor_SetHSV(ImColor* self, float h, float s, float v, float a);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawCmd_destroy(ImDrawCmd* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImDrawCmd_GetTexID(ImDrawCmd* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawCmd* ImDrawCmd_ImDrawCmd();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_Clear(ImDrawData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_DeIndexAllBuffers(ImDrawData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_destroy(ImDrawData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawData* ImDrawData_ImDrawData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawData_ScaleClipRects(ImDrawData* self, Vector2 fb_scale);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_Clear(ImDrawDataBuilder* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_ClearFreeMemory(ImDrawDataBuilder* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawDataBuilder_FlattenIntoSingleLayer(ImDrawDataBuilder* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImDrawDataBuilder_GetDrawListCount(ImDrawDataBuilder* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImDrawList__CalcCircleAutoSegmentCount(ImDrawList* self, float radius);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ClearFreeMemory(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedClipRect(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedTextureID(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__OnChangedVtxOffset(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToFastEx(ImDrawList* self, Vector2 center, float radius, int a_min_sample, int a_max_sample, int a_step);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PathArcToN(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__PopUnusedDrawCmd(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__ResetForNewFrame(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList__TryMergeDrawCmds(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierCubic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddBezierQuadratic(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCallback(ImDrawList* self, IntPtr callback, void* callback_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircle(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddCircleFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddConvexPolyFilled(ImDrawList* self, Vector2* points, int num_points, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddDrawCmd(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImage(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageQuad(ImDrawList* self, IntPtr user_texture_id, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, Vector2 uv1, Vector2 uv2, Vector2 uv3, Vector2 uv4, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddImageRounded(ImDrawList* self, IntPtr user_texture_id, Vector2 p_min, Vector2 p_max, Vector2 uv_min, Vector2 uv_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddLine(ImDrawList* self, Vector2 p1, Vector2 p2, uint col, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgon(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddNgonFilled(ImDrawList* self, Vector2 center, float radius, uint col, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddPolyline(ImDrawList* self, Vector2* points, int num_points, uint col, ImDrawFlags flags, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuad(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddQuadFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, Vector2 p4, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRect(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilled(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col, float rounding, ImDrawFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddRectFilledMultiColor(ImDrawList* self, Vector2 p_min, Vector2 p_max, uint col_upr_left, uint col_upr_right, uint col_bot_right, uint col_bot_left);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText_Vec2(ImDrawList* self, Vector2 pos, uint col, byte* text_begin, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddText_FontPtr(ImDrawList* self, ImFont* font, float font_size, Vector2 pos, uint col, byte* text_begin, byte* text_end, float wrap_width, Vector4* cpu_fine_clip_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangle(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_AddTriangleFilled(ImDrawList* self, Vector2 p1, Vector2 p2, Vector2 p3, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsMerge(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSetCurrent(ImDrawList* self, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_ChannelsSplit(ImDrawList* self, int count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_CloneOutput(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_destroy(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMax(Vector2* pOut, ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_GetClipRectMin(Vector2* pOut, ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawList* ImDrawList_ImDrawList(IntPtr shared_data);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcTo(ImDrawList* self, Vector2 center, float radius, float a_min, float a_max, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathArcToFast(ImDrawList* self, Vector2 center, float radius, int a_min_of_12, int a_max_of_12);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierCubicCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, Vector2 p4, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathBezierQuadraticCurveTo(ImDrawList* self, Vector2 p2, Vector2 p3, int num_segments);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathClear(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathFillConvex(ImDrawList* self, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineTo(ImDrawList* self, Vector2 pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathLineToMergeDuplicate(ImDrawList* self, Vector2 pos);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathRect(ImDrawList* self, Vector2 rect_min, Vector2 rect_max, float rounding, ImDrawFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PathStroke(ImDrawList* self, uint col, ImDrawFlags flags, float thickness);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopClipRect(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PopTextureID(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimQuadUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 c, Vector2 d, Vector2 uv_a, Vector2 uv_b, Vector2 uv_c, Vector2 uv_d, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRect(ImDrawList* self, Vector2 a, Vector2 b, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimRectUV(ImDrawList* self, Vector2 a, Vector2 b, Vector2 uv_a, Vector2 uv_b, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimReserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimUnreserve(ImDrawList* self, int idx_count, int vtx_count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteIdx(ImDrawList* self, ushort idx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PrimWriteVtx(ImDrawList* self, Vector2 pos, Vector2 uv, uint col);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRect(ImDrawList* self, Vector2 clip_rect_min, Vector2 clip_rect_max, byte intersect_with_current_clip_rect);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushClipRectFullScreen(ImDrawList* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawList_PushTextureID(ImDrawList* self, IntPtr texture_id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_destroy(IntPtr self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImDrawListSharedData_ImDrawListSharedData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSharedData_SetCircleTessellationMaxError(IntPtr self, float max_error);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Clear(ImDrawListSplitter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_ClearFreeMemory(ImDrawListSplitter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_destroy(ImDrawListSplitter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImDrawListSplitter* ImDrawListSplitter_ImDrawListSplitter();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Merge(ImDrawListSplitter* self, ImDrawList* draw_list);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_SetCurrentChannel(ImDrawListSplitter* self, ImDrawList* draw_list, int channel_idx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImDrawListSplitter_Split(ImDrawListSplitter* self, ImDrawList* draw_list, int count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddGlyph(ImFont* self, ImFontConfig* src_cfg, int c, float x0, float y0, float x1, float y1, float u0, float v0, float u1, float v1, float advance_x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_AddRemapChar(ImFont* self, int dst, int src, byte overwrite_dst);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_BuildLookupTable(ImFont* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_CalcTextSizeA(Vector2* pOut, ImFont* self, float size, float max_width, float wrap_width, byte* text_begin, byte* text_end, byte** remaining);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_CalcWordWrapPositionA(ImFont* self, float scale, byte* text, byte* text_end, float wrap_width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_ClearOutputData(ImFont* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_destroy(ImFont* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyph(ImFont* self, int c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyph* ImFont_FindGlyphNoFallback(ImFont* self, int c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImFont_GetCharAdvance(ImFont* self, int c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImFont_GetDebugName(ImFont* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_GrowIndex(ImFont* self, int new_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFont_ImFont();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsGlyphRangeUnused(ImFont* self, uint c_begin, uint c_last);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFont_IsLoaded(ImFont* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderChar(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, int c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_RenderText(ImFont* self, ImDrawList* draw_list, float size, Vector2 pos, uint col, Vector4 clip_rect, byte* text_begin, byte* text_end, float wrap_width, byte cpu_fine_clip);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFont_SetGlyphVisible(ImFont* self, int c, byte visible);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectFontGlyph(ImFontAtlas* self, ImFont* font, int id, int width, int height, float advance_x, Vector2 offset);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImFontAtlas_AddCustomRectRegular(ImFontAtlas* self, int width, int height);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFont(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontDefault(ImFontAtlas* self, ImFontConfig* font_cfg);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromFileTTF(ImFontAtlas* self, byte* filename, float size_pixels, ImFontConfig* font_cfg, int* glyph_ranges);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedBase85TTF(ImFontAtlas* self, byte* compressed_font_data_base85, float size_pixels, ImFontConfig* font_cfg, int* glyph_ranges);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryCompressedTTF(ImFontAtlas* self, void* compressed_font_data, int compressed_font_size, float size_pixels, ImFontConfig* font_cfg, int* glyph_ranges);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFont* ImFontAtlas_AddFontFromMemoryTTF(ImFontAtlas* self, void* font_data, int font_size, float size_pixels, ImFontConfig* font_cfg, int* glyph_ranges);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_Build(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_CalcCustomRectUV(ImFontAtlas* self, ImFontAtlasCustomRect* rect, Vector2* out_uv_min, Vector2* out_uv_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_Clear(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearFonts(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearInputData(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_ClearTexData(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_destroy(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlas_GetCustomRectByIndex(ImFontAtlas* self, int index);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesChineseFull(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesChineseSimplifiedCommon(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesCyrillic(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesDefault(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesGreek(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesJapanese(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesKorean(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesThai(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImFontAtlas_GetGlyphRangesVietnamese(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_GetMouseCursorTexData(ImFontAtlas* self, ImGuiMouseCursor cursor, Vector2* out_offset, Vector2* out_size, Vector2* out_uv_border, Vector2* out_uv_fill);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsAlpha8(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, byte** out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_GetTexDataAsRGBA32(ImFontAtlas* self, IntPtr* out_pixels, int* out_width, int* out_height, int* out_bytes_per_pixel);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlas* ImFontAtlas_ImFontAtlas();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlas_IsBuilt(ImFontAtlas* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlas_SetTexID(ImFontAtlas* self, IntPtr id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontAtlasCustomRect_destroy(ImFontAtlasCustomRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontAtlasCustomRect* ImFontAtlasCustomRect_ImFontAtlasCustomRect();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontAtlasCustomRect_IsPacked(ImFontAtlasCustomRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontConfig_destroy(ImFontConfig* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontConfig* ImFontConfig_ImFontConfig();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddChar(ImFontGlyphRangesBuilder* self, int c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddRanges(ImFontGlyphRangesBuilder* self, int* ranges);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_AddText(ImFontGlyphRangesBuilder* self, byte* text, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_BuildRanges(ImFontGlyphRangesBuilder* self, ImVector* out_ranges);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_Clear(ImFontGlyphRangesBuilder* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_destroy(ImFontGlyphRangesBuilder* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImFontGlyphRangesBuilder_GetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImFontGlyphRangesBuilder* ImFontGlyphRangesBuilder_ImFontGlyphRangesBuilder();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImFontGlyphRangesBuilder_SetBit(ImFontGlyphRangesBuilder* self, uint n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiComboPreviewData_destroy(ImGuiComboPreviewData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiComboPreviewData* ImGuiComboPreviewData_ImGuiComboPreviewData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiContext_destroy(IntPtr self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ImGuiContext_ImGuiContext(ImFontAtlas* shared_font_atlas);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiContextHook_destroy(ImGuiContextHook* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiContextHook* ImGuiContextHook_ImGuiContextHook();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiDataVarInfo_GetVarPtr(ImGuiDataVarInfo* self, void* parent);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockContext_destroy(ImGuiDockContext* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockContext* ImGuiDockContext_ImGuiDockContext();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_destroy(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiDockNode* ImGuiDockNode_ImGuiDockNode(uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsCentralNode(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsDockSpace(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsEmpty(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsFloatingNode(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsHiddenTabBar(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsLeafNode(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsNoTabBar(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsRootNode(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiDockNode_IsSplitNode(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_Rect(ImRect* pOut, ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_SetLocalFlags(ImGuiDockNode* self, ImGuiDockNodeFlags flags);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiDockNode_UpdateMergedFlags(ImGuiDockNode* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputEvent_destroy(ImGuiInputEvent* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputEvent* ImGuiInputEvent_ImGuiInputEvent();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_ClearSelection(ImGuiInputTextCallbackData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_DeleteChars(ImGuiInputTextCallbackData* self, int pos, int bytes_count);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_destroy(ImGuiInputTextCallbackData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextCallbackData_HasSelection(ImGuiInputTextCallbackData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextCallbackData* ImGuiInputTextCallbackData_ImGuiInputTextCallbackData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_InsertChars(ImGuiInputTextCallbackData* self, int pos, byte* text, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextCallbackData_SelectAll(ImGuiInputTextCallbackData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextDeactivatedState_ClearFreeMemory(ImGuiInputTextDeactivatedState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextDeactivatedState_destroy(ImGuiInputTextDeactivatedState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextDeactivatedState* ImGuiInputTextDeactivatedState_ImGuiInputTextDeactivatedState();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearFreeMemory(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearSelection(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_ClearText(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorAnimReset(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_CursorClamp(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_destroy(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetCursorPos(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetRedoAvailCount(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetSelectionEnd(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetSelectionStart(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiInputTextState_GetUndoAvailCount(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiInputTextState_HasSelection(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiInputTextState* ImGuiInputTextState_ImGuiInputTextState();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_OnKeyPressed(ImGuiInputTextState* self, int key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiInputTextState_SelectAll(ImGuiInputTextState* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddFocusEvent(ImGuiIO* self, byte focused);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacter(ImGuiIO* self, uint c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharactersUTF8(ImGuiIO* self, byte* str);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddInputCharacterUTF16(ImGuiIO* self, ushort c);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddKeyAnalogEvent(ImGuiIO* self, ImGuiKey key, byte down, float v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddKeyEvent(ImGuiIO* self, ImGuiKey key, byte down);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseButtonEvent(ImGuiIO* self, int button, byte down);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMousePosEvent(ImGuiIO* self, float x, float y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseSourceEvent(ImGuiIO* self, ImGuiMouseSource source);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseViewportEvent(ImGuiIO* self, uint id);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_AddMouseWheelEvent(ImGuiIO* self, float wheel_x, float wheel_y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputCharacters(ImGuiIO* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_ClearInputKeys(ImGuiIO* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_destroy(ImGuiIO* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiIO* ImGuiIO_ImGuiIO();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_SetAppAcceptingEvents(ImGuiIO* self, byte accepting_events);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiIO_SetKeyEventNativeData(ImGuiIO* self, ImGuiKey key, int native_keycode, int native_scancode, int native_legacy_index);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyOwnerData_destroy(ImGuiKeyOwnerData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyOwnerData* ImGuiKeyOwnerData_ImGuiKeyOwnerData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyRoutingData_destroy(ImGuiKeyRoutingData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyRoutingData* ImGuiKeyRoutingData_ImGuiKeyRoutingData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyRoutingTable_Clear(ImGuiKeyRoutingTable* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiKeyRoutingTable_destroy(ImGuiKeyRoutingTable* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiKeyRoutingTable* ImGuiKeyRoutingTable_ImGuiKeyRoutingTable();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiLastItemData_destroy(ImGuiLastItemData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiLastItemData* ImGuiLastItemData_ImGuiLastItemData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_Begin(ImGuiListClipper* self, int items_count, float items_height);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_destroy(ImGuiListClipper* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_End(ImGuiListClipper* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipper_ForceDisplayRangeByIndices(ImGuiListClipper* self, int item_min, int item_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipper* ImGuiListClipper_ImGuiListClipper();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiListClipper_Step(ImGuiListClipper* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipperData_destroy(ImGuiListClipperData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipperData* ImGuiListClipperData_ImGuiListClipperData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiListClipperData_Reset(ImGuiListClipperData* self, ImGuiListClipper* clipper);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipperRange ImGuiListClipperRange_FromIndices(int min, int max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiListClipperRange ImGuiListClipperRange_FromPositions(float y1, float y2, int off_min, int off_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_CalcNextTotalWidth(ImGuiMenuColumns* self, byte update_offsets);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiMenuColumns_DeclColumns(ImGuiMenuColumns* self, float w_icon, float w_label, float w_shortcut, float w_mark);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_destroy(ImGuiMenuColumns* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiMenuColumns* ImGuiMenuColumns_ImGuiMenuColumns();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiMenuColumns_Update(ImGuiMenuColumns* self, float spacing, byte window_reappearing);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavItemData_Clear(ImGuiNavItemData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNavItemData_destroy(ImGuiNavItemData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNavItemData* ImGuiNavItemData_ImGuiNavItemData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_ClearFlags(ImGuiNextItemData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextItemData_destroy(ImGuiNextItemData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextItemData* ImGuiNextItemData_ImGuiNextItemData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_ClearFlags(ImGuiNextWindowData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiNextWindowData_destroy(ImGuiNextWindowData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiNextWindowData* ImGuiNextWindowData_ImGuiNextWindowData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOldColumnData_destroy(ImGuiOldColumnData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumnData* ImGuiOldColumnData_ImGuiOldColumnData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOldColumns_destroy(ImGuiOldColumns* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOldColumns* ImGuiOldColumns_ImGuiOldColumns();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiOnceUponAFrame_destroy(ImGuiOnceUponAFrame* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiOnceUponAFrame* ImGuiOnceUponAFrame_ImGuiOnceUponAFrame();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_Clear(ImGuiPayload* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPayload_destroy(ImGuiPayload* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPayload* ImGuiPayload_ImGuiPayload();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDataType(ImGuiPayload* self, byte* type);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsDelivery(ImGuiPayload* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiPayload_IsPreview(ImGuiPayload* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformImeData_destroy(ImGuiPlatformImeData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformImeData* ImGuiPlatformImeData_ImGuiPlatformImeData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformIO_destroy(ImGuiPlatformIO* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformIO* ImGuiPlatformIO_ImGuiPlatformIO();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPlatformMonitor_destroy(ImGuiPlatformMonitor* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPlatformMonitor* ImGuiPlatformMonitor_ImGuiPlatformMonitor();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPopupData_destroy(ImGuiPopupData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPopupData* ImGuiPopupData_ImGuiPopupData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiPtrOrIndex_destroy(ImGuiPtrOrIndex* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Ptr(void* ptr);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiPtrOrIndex* ImGuiPtrOrIndex_ImGuiPtrOrIndex_Int(int index);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiSettingsHandler_destroy(ImGuiSettingsHandler* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiSettingsHandler* ImGuiSettingsHandler_ImGuiSettingsHandler();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackLevelInfo_destroy(ImGuiStackLevelInfo* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStackLevelInfo* ImGuiStackLevelInfo_ImGuiStackLevelInfo();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackSizes_CompareWithContextState(ImGuiStackSizes* self, IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackSizes_destroy(ImGuiStackSizes* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStackSizes* ImGuiStackSizes_ImGuiStackSizes();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackSizes_SetToContextState(ImGuiStackSizes* self, IntPtr ctx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStackTool_destroy(ImGuiStackTool* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStackTool* ImGuiStackTool_ImGuiStackTool();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_BuildSortByKey(ImGuiStorage* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_Clear(ImGuiStorage* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiStorage_GetBool(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiStorage_GetBoolRef(ImGuiStorage* self, uint key, byte default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiStorage_GetFloat(ImGuiStorage* self, uint key, float default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float* ImGuiStorage_GetFloatRef(ImGuiStorage* self, uint key, float default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiStorage_GetInt(ImGuiStorage* self, uint key, int default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* ImGuiStorage_GetIntRef(ImGuiStorage* self, uint key, int default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void* ImGuiStorage_GetVoidPtr(ImGuiStorage* self, uint key);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void** ImGuiStorage_GetVoidPtrRef(ImGuiStorage* self, uint key, void* default_val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetAllInt(ImGuiStorage* self, int val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetBool(ImGuiStorage* self, uint key, byte val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetFloat(ImGuiStorage* self, uint key, float val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetInt(ImGuiStorage* self, uint key, int val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStorage_SetVoidPtr(ImGuiStorage* self, uint key, void* val);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStoragePair_destroy(ImGuiStoragePair* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Int(uint _key, int _val_i);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Float(uint _key, float _val_f);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStoragePair* ImGuiStoragePair_ImGuiStoragePair_Ptr(uint _key, void* _val_p);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_destroy(ImGuiStyle* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyle* ImGuiStyle_ImGuiStyle();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyle_ScaleAllSizes(ImGuiStyle* self, float scale_factor);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiStyleMod_destroy(ImGuiStyleMod* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Int(ImGuiStyleVar idx, int v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Float(ImGuiStyleVar idx, float v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiStyleMod* ImGuiStyleMod_ImGuiStyleMod_Vec2(ImGuiStyleVar idx, Vector2 v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabBar_destroy(ImGuiTabBar* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabBar* ImGuiTabBar_ImGuiTabBar();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTabItem_destroy(ImGuiTabItem* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTabItem* ImGuiTabItem_ImGuiTabItem();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTable_destroy(ImGuiTable* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTable* ImGuiTable_ImGuiTable();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumn_destroy(ImGuiTableColumn* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumn* ImGuiTableColumn_ImGuiTableColumn();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSettings_destroy(ImGuiTableColumnSettings* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSettings* ImGuiTableColumnSettings_ImGuiTableColumnSettings();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableColumnSortSpecs_destroy(ImGuiTableColumnSortSpecs* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSortSpecs* ImGuiTableColumnSortSpecs_ImGuiTableColumnSortSpecs();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableInstanceData_destroy(ImGuiTableInstanceData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableInstanceData* ImGuiTableInstanceData_ImGuiTableInstanceData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSettings_destroy(ImGuiTableSettings* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableColumnSettings* ImGuiTableSettings_GetColumnSettings(ImGuiTableSettings* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSettings* ImGuiTableSettings_ImGuiTableSettings();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableSortSpecs_destroy(ImGuiTableSortSpecs* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableSortSpecs* ImGuiTableSortSpecs_ImGuiTableSortSpecs();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTableTempData_destroy(ImGuiTableTempData* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTableTempData* ImGuiTableTempData_ImGuiTableTempData();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_append(ImGuiTextBuffer* self, byte* str, byte* str_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_appendf(ImGuiTextBuffer* self, byte* fmt);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_begin(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_c_str(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_clear(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_destroy(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextBuffer_empty(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextBuffer_end(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextBuffer* ImGuiTextBuffer_ImGuiTextBuffer();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextBuffer_reserve(ImGuiTextBuffer* self, int capacity);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextBuffer_size(ImGuiTextBuffer* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Build(ImGuiTextFilter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_Clear(ImGuiTextFilter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextFilter_destroy(ImGuiTextFilter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_Draw(ImGuiTextFilter* self, byte* label, float width);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextFilter* ImGuiTextFilter_ImGuiTextFilter(byte* default_filter);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_IsActive(ImGuiTextFilter* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextFilter_PassFilter(ImGuiTextFilter* self, byte* text, byte* text_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextIndex_append(ImGuiTextIndex* self, byte* Base, int old_size, int new_size);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextIndex_clear(ImGuiTextIndex* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextIndex_get_line_begin(ImGuiTextIndex* self, byte* Base, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiTextIndex_get_line_end(ImGuiTextIndex* self, byte* Base, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern int ImGuiTextIndex_size(ImGuiTextIndex* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_destroy(ImGuiTextRange* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImGuiTextRange_empty(ImGuiTextRange* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiTextRange* ImGuiTextRange_ImGuiTextRange_Str(byte* _b, byte* _e);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiTextRange_split(ImGuiTextRange* self, byte separator, ImVector* @out);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_destroy(ImGuiViewport* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewport_GetWorkCenter(Vector2* pOut, ImGuiViewport* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewport* ImGuiViewport_ImGuiViewport();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_CalcWorkRectPos(Vector2* pOut, ImGuiViewportP* self, Vector2 off_min);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_CalcWorkRectSize(Vector2* pOut, ImGuiViewportP* self, Vector2 off_min, Vector2 off_max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_ClearRequestFlags(ImGuiViewportP* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_destroy(ImGuiViewportP* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetBuildWorkRect(ImRect* pOut, ImGuiViewportP* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetMainRect(ImRect* pOut, ImGuiViewportP* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_GetWorkRect(ImRect* pOut, ImGuiViewportP* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiViewportP* ImGuiViewportP_ImGuiViewportP();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiViewportP_UpdateWorkRect(ImGuiViewportP* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_CalcFontSize(ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_destroy(ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetID_Str(ImGuiWindow* self, byte* str, byte* str_end);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetID_Ptr(ImGuiWindow* self, void* ptr);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetID_Int(ImGuiWindow* self, int n);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ImGuiWindow_GetIDFromRectangle(ImGuiWindow* self, ImRect r_abs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindow* ImGuiWindow_ImGuiWindow(IntPtr context, byte* name);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_MenuBarHeight(ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_MenuBarRect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_Rect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImGuiWindow_TitleBarHeight(ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindow_TitleBarRect(ImRect* pOut, ImGuiWindow* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowClass_destroy(ImGuiWindowClass* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowClass* ImGuiWindowClass_ImGuiWindowClass();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImGuiWindowSettings_destroy(ImGuiWindowSettings* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* ImGuiWindowSettings_GetName(ImGuiWindowSettings* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImGuiWindowSettings* ImGuiWindowSettings_ImGuiWindowSettings();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Add_Vec2(ImRect* self, Vector2 p);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Add_Rect(ImRect* self, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWith(ImRect* self, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ClipWithFull(ImRect* self, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Contains_Vec2(ImRect* self, Vector2 p);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Contains_Rect(ImRect* self, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_destroy(ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Expand_Float(ImRect* self, float amount);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Expand_Vec2(ImRect* self, Vector2 amount);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Floor(ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetArea(ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBL(Vector2* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetBR(Vector2* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetCenter(Vector2* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetHeight(ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetSize(Vector2* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTL(Vector2* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_GetTR(Vector2* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern float ImRect_GetWidth(ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Vec2(Vector2 min, Vector2 max);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Vec4(Vector4 v);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImRect* ImRect_ImRect_Float(float x1, float y1, float x2, float y2);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_IsInverted(ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte ImRect_Overlaps(ImRect* self, ImRect r);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_ToVec4(Vector4* pOut, ImRect* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_Translate(ImRect* self, Vector2 d);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateX(ImRect* self, float dx);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImRect_TranslateY(ImRect* self, float dy);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec1_destroy(ImVec1* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec1* ImVec1_ImVec1_Float(float _x);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2_destroy(Vector2* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector2* ImVec2_ImVec2_Float(float _x, float _y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec2ih_destroy(ImVec2ih* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_short(short _x, short _y);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern ImVec2ih* ImVec2ih_ImVec2ih_Vec2(Vector2 rhs);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern void ImVec4_destroy(Vector4* self);
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4_Nil();
        [DllImport("cnative", CallingConvention = CallingConvention.Cdecl)]
        public static extern Vector4* ImVec4_ImVec4_Float(float _x, float _y, float _z, float _w);
    }
}
