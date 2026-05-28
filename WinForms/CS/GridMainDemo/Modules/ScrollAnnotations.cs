using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Demos;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Annotations;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.Drawing;

namespace DevExpress.XtraGrid.Demos {
    public partial class ScrollAnnotations : TutorialControl {
        public ScrollAnnotations() {
            InitializeComponent();
            gridControl.DataSource = TaskGenerator.Default.GenerateSource(400);
            InitEditors();
            gridView.ClearSelection();
            gridView.ApplyFindFilter("QA");
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "ScrollAnnotations" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "ScrollAnnotations"; }
        }
        void InitEditors() {
            repositoryItemPriorityComboBox.AddImages(svgImageCollection);
            repositoryItemDescriptionComboBox.Items.Add("", true, 3);
            repositoryItemCompletedComboBox.Items.Add("", true, 2);
            stylesSource.DataSource = style;
        }
        void OnRowCellStyle(object sender, RowCellStyleEventArgs e) {
            EmployeeTask task = gridView.GetRow(e.RowHandle) as EmployeeTask;
            if(task != null && task.IsCompleted)
                e.Appearance.FontStyleDelta = (FontStyle.Italic | FontStyle.Strikeout);
        }
        Utils.Design.ISvgPaletteProvider GetPalette() {
            return Utils.Svg.SvgPaletteHelper.GetSvgPalette(gridControl.LookAndFeel, Utils.Drawing.ObjectState.Normal);
        }
        // Addding bookmark items
        //<gridControl>
        readonly HashSet<int> bookmarks = new HashSet<int>() { 5, 17, 74 };
        void OnCustomScrollAnnotation(object sender, GridCustomScrollAnnotationsEventArgs e) {
            int[] rowHandles = bookmarks.Select(x => gridView.GetRowHandle(x)).ToArray();
            e.SetAnnotations(DevExpress.LookAndFeel.DXSkinColors.IconColors.Blue, rowHandles);
        }
        void OnCustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e) {
            if(e.RowHandle >= 0) {
                if(e.Info.ImageIndex == GridPainter.IndicatorError ||
                    e.Info.ImageIndex == GridPainter.IndicatorFocusedError) {
                    // suppress error indicator
                    e.Info.ImageIndex = (e.RowHandle == gridView.FocusedRowHandle) ? GridPainter.IndicatorFocused : -1;
                }
                if(!ceBookmarksEnabled.Checked || !bookmarks.Contains(gridView.GetDataSourceRowIndex(e.RowHandle)))
                    return;
                e.DefaultDraw();
                var bookmarkImage = svgImageCollection.GetImage("bookmark", GetPalette(), ScaleDPI.ScaleSize(new Size(8, 8)));
                var imageBounds = PlacementHelper.Arrange(bookmarkImage.Size, e.Bounds, ContentAlignment.MiddleLeft);
                e.Cache.DrawImageUnscaled(bookmarkImage, imageBounds);
                e.Handled = true;
            }
        }
        //</gridControl>
        // Bookmark items navigation
        //<gridControl>
        void OnKeyDown(object sender, KeyEventArgs e) {
            if(e.KeyData == (Keys.F2 | Keys.Control) || e.KeyData == (Keys.B | Keys.Control))
                e.Handled = ToggleBookmark(gridView.FocusedRowHandle);
            // navigating via shortcuts
            if(e.KeyData == Keys.F2)
                e.Handled = gridView.MoveToNextScrollAnnotation(ScrollAnnotationKind.Custom);
            if(e.KeyData == (Keys.F2 | Keys.Shift))
                e.Handled = gridView.MoveToPrevScrollAnnotation(ScrollAnnotationKind.Custom);
        }
        bool ToggleBookmark(int handle) {
            int dataIndex = gridView.GetDataSourceRowIndex(handle);
            if(dataIndex < 0)
                return false;
            if(!bookmarks.Remove(dataIndex))
                bookmarks.Add(dataIndex);
            gridView.RefreshScrollAnnotations(ScrollAnnotationKind.Custom);
            gridView.InvalidateRow(handle);
            return true;
        }
        //</gridControl>
        void OnMouseDown(object sender, MouseEventArgs e) {
            if(e.Button != MouseButtons.Left)
                return;
            var hitInfo = gridView.CalcHitInfo(e.Location);
            if(hitInfo.InRowCell && hitInfo.Column == descriptionColumn) {
                EmployeeTask task = gridView.GetRow(hitInfo.RowHandle) as EmployeeTask;
                if(task != null && task.HasDescription)
                    ToolTipController.DefaultController.ShowHint(task.Description, ToolTipLocation.RightCenter);
            }
        }
        //<optionsPage>
        readonly AnnotationsStyle style = new AnnotationsStyle();
        void OnScrollAnnotationsStyle(object sender, GridScrollAnnotationsStyleEventArgs e) {
            var styleColor = style.GetColor(e.Kind);
            if(!styleColor.IsEmpty)
                e.Color = styleColor;
        }
        void OnAnnotationsStyleChanged(object sender, ListChangedEventArgs e) {
            if(e.ListChangedType == ListChangedType.ItemChanged)
                gridView.InvalidateScrollAnnotations();
        }
        void OnAnnotationsEnabledChanged(object sender, EventArgs e) {
            bool _enabled = ((CheckEdit)sender).Checked;
            DefaultBoolean _show = _enabled ? DefaultBoolean.True : DefaultBoolean.False;
            if(sender == ceErrorsEnabled) {
                layoutControlItemForErrors.Enabled = _enabled;
                gridView.OptionsScrollAnnotations.ShowErrors = _show;
            }
            if(sender == ceFocusedEnabled) {
                layoutControlItemForFocused.Enabled = _enabled;
                gridView.OptionsScrollAnnotations.ShowFocusedRow = _show;
            }
            if(sender == ceBookmarksEnabled)
                gridView.OptionsScrollAnnotations.ShowCustomAnnotations = _show;
        }
        //</optionsPage>
    }
    public class AnnotationsStyle {
        readonly Dictionary<ScrollAnnotationKind, Color> colors = new Dictionary<ScrollAnnotationKind, Color>();
        public Color ErrorsColor {
            get { return GetColor(ScrollAnnotationKind.Errors); }
            set { colors[ScrollAnnotationKind.Errors] = value; }
        }
        public Color SearchResultsColor {
            get { return GetColor(ScrollAnnotationKind.SearchResults); }
            set { colors[ScrollAnnotationKind.SearchResults] = value; }
        }
        public Color FocusColor {
            get { return GetColor(ScrollAnnotationKind.FocusedRow); }
            set { colors[ScrollAnnotationKind.FocusedRow] = value; }
        }
        public Color GetColor(ScrollAnnotationKind kind) {
            Color color;
            return colors.TryGetValue(kind, out color) ? color : Color.Empty;
        }
    }
}
