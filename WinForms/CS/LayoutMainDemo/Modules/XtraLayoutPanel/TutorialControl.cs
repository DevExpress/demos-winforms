using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraToolbox;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.Utils.Layout;
using DevExpress.XtraLayout.Demos.Controls;
using DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel;

namespace DevExpress.XtraLayout.Demos {
    public partial class XtraLayoutPanelTutorialControl : TutorialControl {
        readonly XtraLayoutPanelDemoViewBase coreView;
        readonly DragDropControllerBase dragController;
        Control selectedControl;

        public XtraLayoutPanelTutorialControl() {
            InitializeComponent();
            this.coreView = CreateView();
            this.selectedControl = null;
            this.dragController = CreateDragController();
            if(coreView != null)
                AddView();
        }
        protected override void OnFirstLoad() {
            base.OnFirstLoad();
            coreView?.Show();
        }
        bool shouldUpdateViewProperties = true;
        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            if(shouldUpdateViewProperties && coreView != null) {
                coreView.Location = CalculateViewLocation();
                coreView.MinimumSize = coreView.Size;
                shouldUpdateViewProperties = false;
            }
        }
        private void AddView() {
            OnInitialize();
            SubscriveViewEvents(coreView);
            contentPanel.Controls.Add(coreView);
        }
        void OnInitialize() {
            coreView.Initialize();
            tiSimpleButton.Tag = typeof(SimpleButton);
            tiTextEdit.Tag = typeof(TextEdit);
            tiLabel.Tag = typeof(LabelControl);
            tiCheckEdit.Tag = typeof(CheckEdit);
            SelectDefaultControl();
        }

        #region Event Handlers

        void OnViewControlSelectRequest(object sender, ControlEventArgs e) {
            SelectControl(e.Control);
        }
        void OnViewControlDeleteRequest(object sender, ControlEventArgs e) {
            if(selectedControl is ICustomControl) {
                selectedControl.Dispose();
                SelectDefaultControl();
            }
        }
        void OnResetLayoutClick(object sender, EventArgs e) {
            View.ResetLayout();
        }

        #endregion

        #region Drag & Drop

        void OnToolboxDragItemStart(object sender, ToolboxDragItemStartEventArgs e) {
            dragController.StartDragDrop();
            e.Image = ((ToolboxItem)e.Item).CreateToolboxItemImage(View.ForeColor);
            e.Handled = true;
        }
        void OnToolboxDragItemMove(object sender, ToolboxDragItemMoveEventArgs e) {
            e.DragDropEffects = dragController.AllowDragDrop(e.Location) ? DragDropEffects.Link : DragDropEffects.None;
            dragController.OnMouseOver(e.Location);
        }
        void OnToolboxDragItemCancel(object sender, ToolboxDragItemCancelEventArgs e) {
            dragController.CancelDragDrop();
        }
        void OnToolboxDragItemDrop(object sender, ToolboxDragItemDropEventArgs e) {
            dragController.DoDragDrop((Type)e.Item.Tag);
        }

        #endregion

        protected virtual XtraLayoutPanelDemoViewBase CreateView() {
            return null;
        }
        protected virtual DragDropControllerBase CreateDragController() {
            return null;
        }
        protected virtual EditorPropertiesObjectBase CreateEditorProperties(Control control) {
            return null;
        }

        private void SubscriveViewEvents(XtraLayoutPanelDemoViewBase view) {
            view.ControlSelectRequest += OnViewControlSelectRequest;
            view.ControlDeleteRequest += OnViewControlDeleteRequest;
        }
        private void SelectDefaultControl() {
            if(!View.LayoutPanel.ContainerIsEmpty()) SelectControl(View.LayoutPanel.Controls[0]);
        }
        private void SelectControl(Control control) {
            selectedControl = control;
            propertyGridControl.SelectedObject = CreateEditorProperties(control);
        }
        private Point CalculateViewLocation() {
            return rootPanel.Bounds.GetCenterRect(coreView.Size).Location.WithOffset(0, -contentPanel.Bounds.Y);
        }
        public XtraLayoutPanelDemoViewBase View { get { return coreView; } }
    }


    public abstract class DragDropControllerBase {
        readonly XtraLayoutPanelDemoViewBase view;
        readonly LayoutPanelAdornerPainterBase adornerPainter;
        bool isDragActive;
        Point mPosition;

        public DragDropControllerBase(XtraLayoutPanelDemoViewBase view) {
            Guard.ArgumentNotNull(view, "view");
            this.view = view;
            this.isDragActive = false;
            this.mPosition = Point.Empty;
            this.view.LayoutPanel.Paint += OnViewPaint;
            this.adornerPainter = CreateAdornerPainter();
        }

        public void StartDragDrop() {
            isDragActive = true;
            StartDragDropCore();
        }
        public void OnMouseOver(Point point) {
            mPosition = LayoutPanel.PointToClient(point);
            OnMouseOverCore();
            LayoutPanel.Invalidate();
        }
        public void CancelDragDrop() {
            isDragActive = false;
        }
        public void DoDragDrop(Type controlType) {
            isDragActive = false;
            DoDragDropCore(controlType);
            LayoutPanel.Invalidate();
        }
        public bool AllowDragDrop(Point point) {
            if(!view.Bounds.Contains(view.Parent.PointToClient(point))) return false;
            return AllowDragDropCore(point);
        }

        protected abstract void StartDragDropCore();
        protected abstract void OnMouseOverCore();
        protected abstract void DoDragDropCore(Type controlType);
        protected abstract LayoutPanelAdornerObject CalculateAdornerObject();
        protected abstract LayoutPanelAdornerPainterBase CreateAdornerPainter();
        protected virtual bool AllowDragDropCore(Point point) { return true; }

        private void OnViewPaint(object sender, PaintEventArgs e) {
            if(!isDragActive) return;

            using(GraphicsCache cache = new GraphicsCache(e)) {
                adornerPainter.Paint(new LayoutPanelAdornerPaintInfo(LayoutPanel, cache, CalculateAdornerObject()));
            }
        }
        protected Point MousePosition { get { return mPosition; } }
        public XtraLayoutPanelBase LayoutPanel { get { return view.LayoutPanel; } }
    }


    public sealed class LayoutPanelAdornerPaintInfo {
        readonly XtraLayoutPanelBase _layoutPanel;
        readonly GraphicsCache _cache;
        readonly LayoutPanelAdornerObject _adorner;

        public LayoutPanelAdornerPaintInfo(XtraLayoutPanelBase layoutPanel, GraphicsCache cache, LayoutPanelAdornerObject adorner) {
            this._layoutPanel = layoutPanel;
            this._cache = cache;
            this._adorner = adorner;
        }
        public GraphicsCache Cache { get { return _cache; } }
        public LayoutPanelAdornerObject Adorner { get { return _adorner; } }
        public XtraLayoutPanelBase LayoutPanel { get { return _layoutPanel; } }
    }


    public abstract class LayoutPanelAdornerObject {
        readonly bool _visible;

        public LayoutPanelAdornerObject(bool visible) {
            this._visible = visible;
        }
        public bool Visible { get { return _visible; } }
    }


    public abstract class LayoutPanelAdornerPainterBase {
        public LayoutPanelAdornerPainterBase() {
        }
        public void Paint(LayoutPanelAdornerPaintInfo e) {
            if(!e.Adorner.Visible) return;
            OnPaint(e);
        }
        protected abstract void OnPaint(LayoutPanelAdornerPaintInfo e);
    }

    public sealed class NullLayoutPanelAdornerObject : LayoutPanelAdornerObject {
        private NullLayoutPanelAdornerObject(bool visible)
            : base(visible) {
        }
        public static NullLayoutPanelAdornerObject Instance = new NullLayoutPanelAdornerObject(false);
    }


    public abstract class EditorPropertiesObjectBase {
        readonly Control _control;

        public EditorPropertiesObjectBase(Control control) {
            Guard.ArgumentNotNull(control, "control");
            this._control = control;
        }

        [Category(CategoryName.Layout), TypeConverter(typeof(SimpleSizeConverter))]
        public Size Size {
            get { return _control.Size; }
            set {
                value.Width = CheckValueRange(value.Width);
                value.Height = CheckValueRange(value.Height);
                _control.Size = value;
            }
        }
        [Category(CategoryName.Layout)]
        public DockStyle Dock {
            get { return _control.Dock; }
            set { _control.Dock = value; }
        }
        [Category(CategoryName.Layout), TypeConverter(typeof(SimplePaddingConverter))]
        public Padding Margin {
            get { return _control.Margin; }
            set {
                value.Left = CheckValueRange(value.Left, lBound: 0);
                value.Top = CheckValueRange(value.Top, lBound: 0);
                value.Right = CheckValueRange(value.Right, lBound: 0);
                value.Bottom = CheckValueRange(value.Bottom, lBound: 0);
                _control.Margin = value;
            }
        }
        [Category(CategoryName.Appearance)]
        public string Text {
            get { return _control.Text; }
            set { _control.Text = value; }
        }
        [Category("Design")]
        public string Name {
            get { return _control.Name; }
        }

        protected int CheckValueRange(int value, int lBound = 1, int hBound = 500) {
            if(value < lBound) return lBound;
            if(value > hBound) return hBound;
            return value;
        }
        protected Control Control { get { return _control; } }
    }
}
