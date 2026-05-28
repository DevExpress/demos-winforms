using System;
using System.Linq;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.ViewInfo;
using System.Drawing;

namespace DevExpress.XtraScheduler.Demos {
    public class PropertyListControl : PropertyGridControl {
        protected override BaseViewInfo CreateViewInfo(bool isPrinting) {
            return new MySingleViewInfo(this, isPrinting);
        }
    }

    public class MySingleViewInfo : SingleRecordViewInfo {
        public MySingleViewInfo(VGridControlBase grid, bool isPrinting) : base(grid, isPrinting) { }
        protected override Rectangle GetScrollRect(Rectangle windowRect) {
            return Rectangle.Inflate(base.GetScrollRect(windowRect), 1, 1);
        }
    }
}
