namespace DevExpress.DentalClinic.View {
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGauges.Core.Model;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Columns;
    using DevExpress.XtraGrid.Registrator;
    using DevExpress.XtraGrid.Views.Base;
    using DevExpress.XtraGrid.Views.Base.Handler;
    using DevExpress.XtraGrid.Views.Base.ViewInfo;
    using DevExpress.XtraGrid.Views.Grid;
    using DevExpress.XtraGrid.Views.Grid.Handler;
    using DevExpress.XtraGrid.Views.Grid.ViewInfo;
    public class GroupedGridView : GridView {
        public GroupedGridView() {
            OptionsBehavior.AutoExpandAllGroups = true;
            OptionsSelection.MultiSelectMode = GridMultiSelectMode.CheckBoxRowSelect;
            OptionsSelection.MultiSelect = true;
        }
        public GroupedGridView(GridControl ownerGrid) : base(ownerGrid) {
        }
        [DefaultValue("")]
        public string FieldsToMerge { get; set; } = "";
        [DefaultValue(true)]
        public bool AutoMergeComplexFields { get; set; } = true;
        protected virtual bool AllowGroupProcessing { get { return GroupCount > 0 && (AutoMergeComplexFields || !string.IsNullOrEmpty(FieldsToMerge)); } }
        protected virtual bool AutoScrollFirstGroup { get { return AllowGroupProcessing; } }
        public override bool CanGroupColumn(GridColumn column) { //allow only one group level
            if(!base.CanGroupColumn(column)) return false;
            if(!AllowGroupProcessing) return true;
            if(column.GroupIndex > -1) return true;
            if(GroupCount > 0) return false;
            return true;
        }
        protected override int CheckTopRowIndex(int newTopRowIndex) {
            newTopRowIndex = base.CheckTopRowIndex(newTopRowIndex);
            if(AutoScrollFirstGroup && !IsPixelScrolling) {
                if(newTopRowIndex < 1) newTopRowIndex = 1;
            }
            return newTopRowIndex;
        }
        protected override void InternalSetTopRowIndex(int newTopRowIndex) {
            if(AutoScrollFirstGroup && !IsPixelScrolling) {
                if(newTopRowIndex < 1) newTopRowIndex = 1;
            }
            base.InternalSetTopRowIndex(newTopRowIndex);
        }
        protected override void UpdateVScrollArgs(ScrollArgs args) {
            base.UpdateVScrollArgs(args);
            if(AutoScrollFirstGroup && !IsPixelScrolling) {
                if(args.Maximum > 1) {
                    args.Minimum = 1;
                }
            }
        }
        public override void SelectRow(int rowHandle) {
            base.SelectRow(rowHandle);
            if(!AllowGroupProcessing) return;
            if(rowHandle < 0) return;
            ChangeSelection(GetParentRowHandle(rowHandle), true);
        }
        public override void UnselectRow(int rowHandle) {
            base.UnselectRow(rowHandle);
            if(!AllowGroupProcessing) return;
            if(rowHandle < 0) return;
            ChangeSelection(GetParentRowHandle(rowHandle), false);
        }
        void ChangeSelection(int groupRow, bool setSelected) {
            if(!IsValidRowHandle(groupRow)) return;
            int c = GetChildRowCount(groupRow);
            for(int n = 0; n < c; n++) {
                if(setSelected) base.SelectRow(GetChildRowHandle(groupRow, n));
                else base.UnselectRow(GetChildRowHandle(groupRow, n));
            }
        }
        protected override string ViewName { get { return "GroupedGridView"; } }
        protected override bool RaiseCustomPrintGroupRow(DevExpress.XtraPrinting.BrickGraphics graph, int rowHandle, int level, ref Rectangle rowBounds) {
            if(!AllowGroupProcessing)
                return base.RaiseCustomPrintGroupRow(graph, rowHandle, level, ref rowBounds);
            if(rowHandle == -1) { //skip first row
                rowBounds.Height = 0;
                return true;
            }
            rowBounds.Height = 3;
            graph.DrawBrick(new DevExpress.XtraPrinting.NativeBricks.XETextBrick(), rowBounds);
            return true;
        }
        protected override int PrintLevelIndent {
            get {
                if(!AllowGroupProcessing) return base.PrintLevelIndent;
                return 0;
            }
        }
        bool inCopyToClipboard = false;
        protected override bool GetDataRowText(StringBuilder sb, int rowHandle) {
            try {
                inCopyToClipboard = true;
                return base.GetDataRowText(sb, rowHandle);
            }
            finally {
                inCopyToClipboard = false;
            }
        }
        protected override string GetRowCellDisplayTextCore(int rowHandle, GridColumn column, DevExpress.XtraEditors.ViewInfo.BaseEditViewInfo bev, object value, bool forGroupRow) {
            if(AllowGroupProcessing && inCopyToClipboard && !forGroupRow) {
                if(CanSkipCurrentCell(rowHandle, column)) return "";
            }
            return base.GetRowCellDisplayTextCore(rowHandle, column, bev, value, forGroupRow);
        }
        protected override bool GetRowText(StringBuilder sb, int rowHandle, int minGroupLevel, int dataLevel) {
            if(!AllowGroupProcessing) return base.GetRowText(sb, rowHandle, minGroupLevel, dataLevel);
            if(IsGroupRow(rowHandle)) {
                if(rowHandle == -1) return false;
                //caret return will be added anyway
                return true;
            }
            return base.GetRowText(sb, rowHandle, minGroupLevel, dataLevel);
        }
        protected override bool RaiseCustomPrintCell(GridCellInfo cell, Rectangle r, PrintCellHelperInfo info, out DevExpress.XtraPrinting.VisualBrick brick) {
            brick = null;
            if(!AllowGroupProcessing) return base.RaiseCustomPrintCell(cell, r, info, out brick);
            if(CanSkipCurrentCell(cell.RowHandle, cell.Column)) {
                var item = GetColumnDefaultRepositoryItem(null);
                info.EditValue = null;
                info.PrintHLines = false;
                info.DisplayText = "";
                info.Sides &= (~DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Bottom);
                brick = item.GetBrick(info);
                return true;
            }
            else {
                info.Sides &= (~DevExpress.XtraPrinting.BorderSide.Top);

            }
            return false;
        }
        bool CanMergeColumn(GridColumn column) {
            if(!AllowGroupProcessing || column == null || string.IsNullOrEmpty(column.FieldName)) return false;
            if(column == CheckboxSelectorColumn) return true;
            if(AutoMergeComplexFields && !string.IsNullOrEmpty(column.FieldName) && column.FieldName.Contains('.')) return true;
            if(string.IsNullOrEmpty(FieldsToMerge)) return true;
            int startIndex = 0;
            while(true) {
                int fieldLength = column.FieldName.Length;
                var i = FieldsToMerge.IndexOf(column.FieldName, startIndex);
                if(i == -1) return false;

                if(i + fieldLength >= FieldsToMerge.Length || (i + fieldLength < FieldsToMerge.Length && FieldsToMerge[i + fieldLength] == ';')) {
                    if(i == 0 || FieldsToMerge[i - 1] == ';') return true;
                }
                startIndex++;
            }
        }
        bool CanSkipCurrentCell(int rowHandle, GridColumn column) {
            if(column == null) return false;
            if(!CanMergeColumn(column)) return false;
            var groupColumn = GroupedColumns[0];
            object groupValue = GetRowCellValue(rowHandle, groupColumn);
            object prevGroupValue = GetRowCellValue(rowHandle - 1, groupColumn);
            if(groupValue == null || prevGroupValue == null || !Object.Equals(groupValue, prevGroupValue))
                return false;
            var value = GetRowCellValue(rowHandle, column);
            var prevValue = GetRowCellValue(rowHandle - 1, column);
            if(Object.Equals(value, prevValue) || (column == CheckboxSelectorColumn && CheckboxSelectorColumn != null)) {
                return true;
            }
            return false;
        }
        protected override void RaiseCustomDrawCell(RowCellCustomDrawEventArgs e) {
            base.RaiseCustomDrawCell(e);
            if(e.Handled) return;
            var cell = e.Cell as GridCellInfo;
            cell.AllowDrawCellEdit = true;
            if(!AllowGroupProcessing || e.RowHandle < 1) return;
            if(!CanSkipCurrentCell(e.RowHandle, e.Column)) return;
            var prevRowInfo = ViewInfo.GetGridRowInfo(e.RowHandle - 1);
            if(prevRowInfo == null) return;
            cell.AllowDrawCellEdit = false;
        }
        protected override void RaiseCustomDrawGroupRow(RowObjectCustomDrawEventArgs e) {
            base.RaiseCustomDrawGroupRow(e);
            if(e.Handled || !AllowGroupProcessing) return;
            e.Handled = true;
            if(e.RowHandle == -1) return;
            Rectangle rect = new Rectangle(0, 0, e.Bounds.Width, 2);
            rect = PlacementHelper.Arrange(rect.Size, e.Bounds, ContentAlignment.BottomCenter);
            ViewInfo.PaintAppearance.HorzLine.FillRectangle(e.Cache, rect);
        }
        protected override bool AllowMasterDetail { get { return false; } }
        protected override bool TrySmoothMakeRowVisible { get { return true; } }
        protected override void DoChangeFocusedRow(int currentRowHandle, int newRowHandle, bool raiseUpdateCurrentRow) {
            if(!AllowGroupProcessing) return;
            var originalTarget = newRowHandle;
            if(IsGroupRow(newRowHandle)) {
                var prevIndex = GetVisibleIndex(currentRowHandle);
                var current = GetVisibleIndex(newRowHandle);
                if(current > prevIndex || current < 1) {
                    newRowHandle = GetChildRowHandle(newRowHandle, 0);
                }
                else {
                    var vi = GetPrevVisibleRow(current);
                    if(vi > -1) newRowHandle = GetVisibleRowHandle(vi);
                    else GetChildRowHandle(-1, 0);
                }
            }

            if(originalTarget == -1) TopRowIndex = 0;
            base.DoChangeFocusedRow(currentRowHandle, newRowHandle, raiseUpdateCurrentRow);
        }
        protected override void SetRowExpandedCore(int rowHandle, bool expanded, bool recursive, bool canAnimate) {
            if(!expanded && AllowGroupProcessing) return;
            base.SetRowExpandedCore(rowHandle, true, recursive, canAnimate);
        }
        protected override void OnAfterSmartScroll(Rectangle scrollableBounds, Point offset) {
            base.OnAfterSmartScroll(scrollableBounds, offset);
            if(!AllowGroupProcessing) return;
            for(int n = 0; n < ViewInfo.RowsInfo.Count; n++) {
                var row = ViewInfo.RowsInfo[n];
                if(row.IsGroupRow) continue;
                if(row.TotalBounds.IntersectsWith(scrollableBounds)) {
                    var d = row.TotalBounds.Top - scrollableBounds.Top - Math.Abs(offset.X);
                    if(d < 10)
                        InvalidateRect(row.TotalBounds);
                }
            }
        }
        public override void InvalidateHitObject(BaseHitInfo hit) {
            base.InvalidateHitObject(hit);
            if(!AllowGroupProcessing) return;
            var gridHit = hit as GridHitInfo;
            if(gridHit.InRow && IsAllowRowHotTrack()) {
                InvalidateRows();
            }
        }
        protected override bool IsRowHotTracked(int rowHandle) {
            if(!AllowGroupProcessing) return base.IsRowHotTracked(rowHandle);
            if(base.IsRowHotTracked(rowHandle)) return true;
            int hotRow = ViewInfo.SelectionInfo.HotRowHandle;
            if(!IsAllowRowHotTrack() || hotRow == GridControl.InvalidRowHandle) return false;
            if(IsGroupRow(rowHandle)) return false;
            var parentHotRow = IsGroupRow(hotRow) ? hotRow : GetParentRowHandle(hotRow);
            var parentCurrentRow = GetParentRowHandle(rowHandle);
            return parentHotRow == parentCurrentRow;
        }
        protected override void UpdatePaintAppearanceDefaults() {
            base.UpdatePaintAppearanceDefaults();
            if(IsAllowRowHotTrack()) {
                ((AppearanceObjectEx)PaintAppearance.HotTrackedRow).Options.HighPriority = true;
            }
        }

    }
    public class GroupedGridControl : GridControl {
        protected override void RegisterAvailableViewsCore(InfoCollection collection) {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GroupedGridViewRegistrator());
        }
    }
    public class GroupedGridViewInfo : GridViewInfo {
        public GroupedGridViewInfo(GroupedGridView gridView) : base(gridView) {
        }
        protected override void CalcGroupRowHeight() {
            base.CalcGroupRowHeight();
            GroupRowDefaultHeight = GroupRowMinHeight = ScaledGroupRowHeight;
        }
        public override int CalcRowHeight(Graphics graphics, int rowHandle, int rowVisibleIndex, int min, int level, bool useCache, GridColumnsInfo columns) {
            if(View.IsGroupRow(rowHandle)) return ScaleVertical(2);
            return base.CalcRowHeight(graphics, rowHandle, rowVisibleIndex, min, level, useCache, columns);

        }
    }
    public class GroupedGridHandler : GridHandler {
        public GroupedGridHandler(GroupedGridView gridView) : base(gridView) {
        }
    }
    public class GroupedGridViewRegistrator : GridInfoRegistrator {
        public override string ViewName { get { return "GroupedGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new GroupedGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new GroupedGridViewInfo(view as GroupedGridView); }
        public override BaseViewHandler CreateHandler(BaseView view) { return new GroupedGridHandler(view as GroupedGridView); }
    }
}
