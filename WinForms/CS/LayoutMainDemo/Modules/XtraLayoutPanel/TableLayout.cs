using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Layout;
using DevExpress.Utils.Extensions;
using DevExpress.XtraLayout.Demos.Controls;
using DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel;

namespace DevExpress.XtraLayout.Demos {
    public partial class TableLayout : XtraLayoutPanelTutorialControl {
        public TableLayout() {
            InitializeComponent();
            ceShowGrid.Checked = View.ShowGrid;
        }

        #region Handlers

        void OnShowGridCheckedChanged(object sender, EventArgs e) {
            CheckEdit checkEdit = (CheckEdit)sender;
            View.ShowGrid = checkEdit.Checked;
        }

        #endregion

        protected override XtraLayoutPanelDemoViewBase CreateView() {
            return new DetailView();
        }
        protected override DragDropControllerBase CreateDragController() {
            return new TableLayoutDragDropController(View);
        }
        protected override EditorPropertiesObjectBase CreateEditorProperties(Control control) {
            return new TableEditorPropertiesObject(View.TableLayoutPanel, control);
        }
        public new DetailView View { get { return (DetailView)base.View; } }
    }


    public class TableEditorPropertiesObject : EditorPropertiesObjectBase {
        readonly TablePanel tablePanel;

        public TableEditorPropertiesObject(TablePanel tablePanel, Control control) : base(control) {
            Guard.ArgumentNotNull(tablePanel, "tablePanel");
            this.tablePanel = tablePanel;
        }
        [Category(CategoryName.Layout)]
        public int Column {
            get { return tablePanel.GetColumn(Control); }
            set {
                if(value < 0) value = 0;
                tablePanel.SetColumn(Control, value);
            }
        }
        [Category(CategoryName.Layout)]
        public int Row {
            get { return tablePanel.GetRow(Control); }
            set {
                if(value < 0) value = 0;
                tablePanel.SetRow(Control, value);
            }
        }
        [Category(CategoryName.Layout)]
        public int ColumnSpan {
            get { return tablePanel.GetColumnSpan(Control); }
            set {
                if(value < 1) value = 1;
                tablePanel.SetColumnSpan(Control, value);
            }
        }
        [Category(CategoryName.Layout)]
        public int RowSpan {
            get { return tablePanel.GetRowSpan(Control); }
            set {
                if(value < 1) value = 1;
                tablePanel.SetRowSpan(Control, value);
            }
        }
        [Category(CategoryName.Layout)]
        public bool UseSkinIndents {
            get {
                return tablePanel.UseSkinIndents;
            }
            set {
                tablePanel.UseSkinIndents = value;
            }
        }
    }


    public sealed class TablePanelAdornerPainter : LayoutPanelAdornerPainterBase {
        public TablePanelAdornerPainter() {
        }
        protected override void OnPaint(LayoutPanelAdornerPaintInfo e) {
            TablePanelAdornerObject adorner = (TablePanelAdornerObject)e.Adorner;
            DXControlPaint.DrawDashedBorder(e.Cache.Graphics, adorner.Bounds, e.LayoutPanel.GetBackColor(), 2f);
        }
    }


    public sealed class TablePanelAdornerObject : LayoutPanelAdornerObject {
        readonly Rectangle _bounds;
        
        public TablePanelAdornerObject(Rectangle bounds) : base(true) {
            this._bounds = bounds;
        }
        public Rectangle Bounds { get { return _bounds; } }
    }


    public sealed class TableLayoutDragDropController : DragDropControllerBase {
        TablePanelCell targetCell;
        TablePanelLayout layout;

        public TableLayoutDragDropController(DetailView view) : base(view) {
            this.targetCell = null;
            this.layout = null;
        }
        protected override void StartDragDropCore() {
            layout = LayoutPanel.CalculateLayout();
        }
        protected override void OnMouseOverCore() {
            targetCell = layout.Return(x => x.GetCell(MousePosition));
        }
        protected override void DoDragDropCore(Type controlType) {
            if(targetCell == null || targetCell.IsOccupied) return;
            Control control = LayoutPanel.AddControl(CustomControlFactory.CreateControl(controlType));
            LayoutPanel.SetCell(control, targetCell.Row, targetCell.Column);
        }
        protected override bool AllowDragDropCore(Point point) {
            if(targetCell == null || targetCell.IsOccupied) return false;
            return true;
        }
        protected override LayoutPanelAdornerPainterBase CreateAdornerPainter() {
            return new TablePanelAdornerPainter();
        }
        protected override LayoutPanelAdornerObject CalculateAdornerObject() {
            if(targetCell == null) return NullLayoutPanelAdornerObject.Instance;
            return new TablePanelAdornerObject(targetCell.Bounds);
        }
        public new TablePanel LayoutPanel { get { return (TablePanel)base.LayoutPanel; } }
    }
}
