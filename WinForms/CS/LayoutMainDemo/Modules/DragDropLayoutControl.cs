using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraLayout.Dragging;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.HitInfo;
using DevExpress.XtraEditors;

namespace DevExpress.XtraLayout.Demos.Modules {
    public interface IDragManager {
        BaseLayoutItem DragItem { get; set;}
        void SetDragCursor(DragDropEffects effect);
    }
    public partial class DragDropLayoutControl : XtraUserControl {
        public DragDropLayoutControl() {
            InitializeComponent();
        }
        IDragManager DragManager { get { return Parent.Parent as IDragManager; } }
        BaseLayoutItem newDragItem = null;
        private void layoutControl2_MouseDown(object sender, MouseEventArgs e) {

            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            BaseLayoutItemHitInfo hi = dragDropLayout.CalcHitInfo(new Point(e.X, e.Y));
            TabbedGroupHitInfo tghi = hi as TabbedGroupHitInfo;
            if(tghi != null && tghi.TabbedGroupHotPageIndex >= 0) newDragItem = ((TabbedControlGroup)hi.Item).TabPages[tghi.TabbedGroupHotPageIndex];
            else newDragItem = hi.Item;
        }
        private void layoutControl2_MouseMove(object sender, MouseEventArgs e) {
            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            if(newDragItem == null || e.Button != MouseButtons.Left || (newDragItem.Parent == null && newDragItem.Owner != null)) return;
            DragManager.DragItem = newDragItem;
            dragDropLayout.DoDragDrop(DragManager.DragItem, DragDropEffects.Copy);
            newDragItem = null;
        }
        private void layoutControl2_DragDrop(object sender, DragEventArgs e) {
            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            if(dragController != null && DragManager.DragItem != null) {
                if(DragManager.DragItem.Owner == null || DragManager.DragItem.Parent == null)
                    dragController.DragWildItem();
                else
                    dragController.Drag();
                Focus();
            }
            HideDragHelper();
            Parent.Cursor = Cursors.Default;
            DragManager.DragItem = null;
        }
        private void layoutControl2_DragEnter(object sender, DragEventArgs e) {
            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            dragController = null;
            ShowDragHelper();
        }
        private void layoutControl2_DragLeave(object sender, EventArgs e) {
            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            HideDragHelper();
        }
        private void layoutControl2_DragOver(object sender, DragEventArgs e) {
            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            UpdateDragHelper(new Point(e.X, e.Y));
            e.Effect = DragDropEffects.Copy;
            DragManager.SetDragCursor(e.Effect);
        }
        private void layoutControl2_GiveFeedback(object sender, GiveFeedbackEventArgs e) {
            if(((ILayoutControl)this.dragDropLayout).EnableCustomizationMode || this.DesignMode) return;
            e.UseDefaultCursors = false;
        }
        //dragHelper
        DragFrameWindow window;
        LayoutItemDragController dragController = null;
        protected DragFrameWindow DragFrameWindow {
            get {
                if(window == null) window = new DragFrameWindow(dragDropLayout);
                return window;
            }
        }
        protected void ShowDragHelper() {
            if(DragManager.DragItem == null) return;
            DragFrameWindow.Visible = true;
        }
        protected void HideDragHelper() {
            DragFrameWindow.Reset();
            DragFrameWindow.Visible = false;
        }
        protected void UpdateDragHelper(Point p) {
            if(DragManager.DragItem == null) return;
            p = dragDropLayout.PointToClient(p);
            dragController = new LayoutItemDragController(DragManager.DragItem, dragDropLayout.Root, new Point(p.X, p.Y));
            DragFrameWindow.DragController = dragController;
        }

        
    }
}
