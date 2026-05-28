using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.Layout;
using DevExpress.Utils.Extensions;
using DevExpress.Utils.Drawing;
using DevExpress.XtraLayout.Demos.Controls;
using DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.Utils;

namespace DevExpress.XtraLayout.Demos {
    public partial class StackLayout : XtraLayoutPanelTutorialControl {
        public StackLayout() {
            InitializeComponent();
        }
        protected override XtraLayoutPanelDemoViewBase CreateView() {
            return new LoginView();
        }
        protected override DragDropControllerBase CreateDragController() {
            return new StackLayoutDragDropController(View);
        }
        protected override EditorPropertiesObjectBase CreateEditorProperties(Control control) {
            return new StackEditorPropertiesObject(View.StackPanel, control);
        }
        public new LoginView View { get { return (LoginView)base.View; } }
    }


    public class StackEditorPropertiesObject : EditorPropertiesObjectBase {
        private readonly StackPanel stackPanel;
        public StackEditorPropertiesObject(StackPanel stackPanel ,Control control)
            : base(control) {
            Guard.ArgumentNotNull(stackPanel, "stackPanel");
            this.stackPanel = stackPanel;
        }
        [Category(CategoryName.Layout)]
        public bool UseSkinIndents {
            get {
                return stackPanel.UseSkinIndents;
            }
            set {
                stackPanel.UseSkinIndents = value;
            }
        }
    }


    public sealed class StackPanelAdornerObject : LayoutPanelAdornerObject {
        readonly Point _start;
        readonly Point _end;

        public StackPanelAdornerObject(Point start, Point end) : base(true) {
            this._start = start;
            this._end = end;
        }
        public Point Start { get { return _start; } }
        public Point End { get { return _end; } }
    }


    public sealed class StackPanelAdornerPainter : LayoutPanelAdornerPainterBase {
        const int IBarSize = 4;

        public StackPanelAdornerPainter() {
        }
        protected override void OnPaint(LayoutPanelAdornerPaintInfo e) {
            StackPanelAdornerObject adorner = (StackPanelAdornerObject)e.Adorner;
            DrawHorzIBar(e.Cache, adorner.Start, adorner.End, e.LayoutPanel.BackColor);
        }
        private void DrawHorzIBar(GraphicsCache cache, Point start, Point end, Color backColor) {
            Pen barPen = backColor != Color.Empty && backColor.GetBrightness() < 0.5 ? SystemPens.ControlLight : SystemPens.ControlText;
            cache.DrawLine(barPen, start, end);
            cache.DrawLine(barPen, start.WithOffset(0, -IBarSize), start.WithOffset(0, IBarSize));
            cache.DrawLine(barPen, end.WithOffset(0, -IBarSize), end.WithOffset(0, IBarSize));
        }
    }


    public sealed class StackLayoutDragDropController : DragDropControllerBase {
        StackPanelLayoutItem targetItem;
        StackPanelLayout layout;

        public StackLayoutDragDropController(LoginView view) : base(view) {
            this.targetItem = null;
            this.layout = null;
        }
        protected override void StartDragDropCore() {
            layout = LayoutPanel.CalculateLayout();
        }
        protected override void OnMouseOverCore() {
            targetItem = layout.Return(x => x.GetItemByPoint(MousePosition));
        }
        protected override void DoDragDropCore(Type controlType) {
            if(targetItem == null) return;
            Control control = LayoutPanel.AddControl(CustomControlFactory.CreateControl(controlType));
            LayoutPanel.Controls.SetChildIndex(control, targetItem.GetDragDropTargetIndex(MousePosition));
        }
        protected override LayoutPanelAdornerObject CalculateAdornerObject() {
            if(targetItem == null) return NullLayoutPanelAdornerObject.Instance;
            if(targetItem.MarginBounds.TopHalfRect().Contains(MousePosition)) {
                return new StackPanelAdornerObject(targetItem.MarginBounds.LeftTop(), targetItem.MarginBounds.RightTop());
            }
            return new StackPanelAdornerObject(targetItem.MarginBounds.LeftBottom(), targetItem.MarginBounds.RightBottom());
        }
        protected override LayoutPanelAdornerPainterBase CreateAdornerPainter() {
            return new StackPanelAdornerPainter();
        }
        public new StackPanel LayoutPanel { get { return (StackPanel)base.LayoutPanel; } }
    }
}
