using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Layout;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Extensions;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel {
    public partial class DetailView : XtraLayoutPanelDemoViewBase {
        Rectangle _newColumnButtonRect;
        Rectangle _newRowButtonRect;
        ObjectState _newRowButtonState;
        ObjectState _newColumnButtonState;

        public DetailView() {
            InitializeComponent();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool ShowGrid {
            get { return tablePanel.ShowGrid == DefaultBoolean.True; }
            set {
                tablePanel.ShowGrid = value ? DefaultBoolean.True : DefaultBoolean.False;
                InvalidatePanel();
            }
        }
        static readonly object markerObj = new object();
        protected override void InitializeControls() {
            base.InitializeControls();
            deHireDate.DateTime = TutorialConstants.Now - TimeSpan.FromDays(365 * 5);
            deBirthDate.DateTime = TutorialConstants.Now - TimeSpan.FromDays(365 * 35);
            tablePanel.ForEachTableEntity(x => x.Tag = markerObj);
        }
        public override void ResetLayout() {
            LayoutPanel.SuspendLayout();
            try {
                base.ResetLayout();
                for(int n = tablePanel.Rows.Count - 1; n >= 0; n--) {
                    if(!ReferenceEquals(tablePanel.Rows[n].Tag, markerObj)) tablePanel.Rows.RemoveAt(n);
                }
                for(int n = tablePanel.Columns.Count - 1; n >= 0; n--) {
                    if(!ReferenceEquals(tablePanel.Columns[n].Tag, markerObj)) tablePanel.Columns.RemoveAt(n);
                }
            }
            finally {
                LayoutPanel.ResumeLayout();
            }

        }

        #region Rects

        Rectangle NewColumnButtonRect {
            get { return _newColumnButtonRect; }
            set {
                if(NewColumnButtonRect == value) return;
                _newColumnButtonRect = value;
                InvalidatePanel();
            }
        }
        Rectangle NewRowButtonRect {
            get { return _newRowButtonRect; }
            set {
                if(NewRowButtonRect == value) return;
                _newRowButtonRect = value;
                InvalidatePanel();
            }
        }
        ObjectState NewColumnButtonState {
            get { return _newColumnButtonState; }
            set {
                if(NewColumnButtonState == value) return;
                _newColumnButtonState = value;
                InvalidatePanel();
            }
        }
        ObjectState NewRowButtonState {
            get { return _newRowButtonState; }
            set {
                if(NewRowButtonState == value) return;
                _newRowButtonState = value;
                InvalidatePanel();
            }
        }

        #endregion

        #region Paint

        void OnTablePanelPaint(object sender, PaintEventArgs e) {
            CalculateRectangles();
            using(GraphicsCache cache = new GraphicsCache(e)) {
                if(ShowGrid) DrawButtons(cache);
            }
        }
        private void DrawButtons(GraphicsCache cache) {
            cache.DrawImageUnscaled(CreateColumnImage, NewColumnButtonRect);
            cache.DrawImageUnscaled(CreateRowImage, NewRowButtonRect);
        }

        #endregion

        #region Events

        void OnTablePanelMouseUp(object sender, MouseEventArgs e) {
            CalculateObjectStates(e);
        }
        void OnTablePanelMouseDown(object sender, MouseEventArgs e) {
            CalculateObjectStates(e);
        }
        void OnTablePanelMouseMove(object sender, MouseEventArgs e) {
            CalculateRectangles();
            CalculateObjectStates(e);
        }
        void OnTablePanelMouseClick(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left) return;

            if(NewColumnButtonRect.Contains(e.Location)) {
                CreateColumn();
            }
            else if(NewRowButtonRect.Contains(e.Location)) {
                CreateRow();
            }
        }

        #endregion

        #region Calculations

        static readonly Size ButtonSize = ScaleUtils.ScaleValue(new Size(16, 16));

        private void CalculateRectangles() {
            NewColumnButtonRect = LayoutPanel.Bounds.RightTop().CreateRect(ButtonSize).WithOffset(-ButtonSize.Width, ButtonSize.Height);
            NewRowButtonRect = LayoutPanel.Bounds.RightBottom().CreateRect(ButtonSize).WithOffset(-ButtonSize.Width, -ButtonSize.Height);
        }
        private void CalculateObjectStates(MouseEventArgs e) {
            NewColumnButtonState = CalculateObjectStateCore(NewColumnButtonRect, e);
            NewRowButtonState = CalculateObjectStateCore(NewRowButtonRect, e);
        }
        private ObjectState CalculateObjectStateCore(Rectangle bounds, MouseEventArgs e) {
            return bounds.Contains(e.Location) && (e.Button & MouseButtons.Left) == 0 ? ObjectState.Hot : ObjectState.Normal;
        }

        #endregion

        private void CreateColumn() {
            tablePanel.Columns.Add(new TablePanelColumn(TablePanelEntityStyle.Relative, 50f));
        }
        private void CreateRow() {
            tablePanel.Rows.Add(new TablePanelRow(TablePanelEntityStyle.Absolute, 38f));
        }
        private void InvalidatePanel() {
            LayoutPanel.Invalidate();
        }
        private Image CreateColumnImage {
            get { return imageList.GetImage(NewColumnButtonState == ObjectState.Hot ? 1 : 0, new Size(16, 16)); }
        }
        private Image CreateRowImage {
            get { return imageList.GetImage(NewRowButtonState == ObjectState.Hot ? 3 : 2, new Size(16, 16)); }
        }
        public override XtraLayoutPanelBase LayoutPanel { get { return tablePanel; } }
        public TablePanel TableLayoutPanel { get { return tablePanel; } }
    }
}
