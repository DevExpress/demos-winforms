using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DevExpress.ActiveDemos;
using DevExpress.Data.Utils;
using DevExpress.Export;
using DevExpress.Spreadsheet;
using DevExpress.Utils.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraVerticalGrid.ViewInfo;

namespace DevExpress.XtraGrid.Demos {
    public partial class ClipboardTutorial : TutorialControl {
        #region Active Demo
        public override bool HasActiveDemo { get { return true; } }
        protected override ActiveDemo CreateActiveDemo() {
            return new ActiveGridDemo(gridControl1);
        }
        bool activeDemoSelectCellsWithMouse = false;
        protected override void RunGridActiveDemo(ActiveGridDemo activeDemo) {
            try {
                InitActiveDemo();
                Greeting(activeDemo);
                if(activeDemo.Actions.Canceled) return;
                ExpandOptionsBtnClick(activeDemo);
                SelectPropertyGridOption(activeDemo, "AllowHtmlFormat", Utils.DefaultBoolean.True);
                if(activeDemo.Actions.Canceled) return;
                SelectPropertyGridOption(activeDemo, "ClipboardMode", ClipboardMode.Formatted);
                if(activeDemo.Actions.Canceled) return;
                SelectPropertyGridOption(activeDemo, "CopyCollapsedData", Utils.DefaultBoolean.True);
                if(activeDemo.Actions.Canceled) return;
                ExpandOptionsBtnClick(activeDemo);
                ModifyGrid(activeDemo);
                if(activeDemo.Actions.Canceled) return;
                SelectCells(activeDemo);
                if(activeDemo.Actions.Canceled) return;
                PressCopyBtn(activeDemo);
            }
            catch {
                propertyGridControl.ExpandAllRows();
                gridViewPropertiesLayoutGroup.Expanded = false;
                gridView1.ClearSelection();
                gridView1.ClearGrouping();
                gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(60, 0, 0, 240);
                gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
                gridView1.BestFitColumns();
                gridView1.SelectCellAnchorRange(2, colState, 20, colMarketShare);
                ActiveDemoResults.Clear();
                ActiveDemoResults.Hide();
                XtraEditors.XtraMessageBox.Show(gridControl1, "The Active Demo has encountered a problem and needs to close. Try running the DevExpress Components installation in 'Repair' mode to fix the Demo Center.");
            }
        }
        void InitActiveDemo() {
            gridView1.OptionsClipboard.AllowHtmlFormat = Utils.DefaultBoolean.Default;
            gridView1.OptionsClipboard.ClipboardMode = ClipboardMode.Default;
            gridView1.OptionsClipboard.CopyCollapsedData = Utils.DefaultBoolean.Default;
            propertyGridControl.UpdateData();
            gridViewPropertiesLayoutGroup.Expanded = false;
            gridView1.ClearSelection();
            gridView1.ClearGrouping();
            richEditControl.Document.RtfText = string.Empty;
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange());
            webBrowser1.DocumentText = string.Empty;
            gridView1.MouseMove += SelectCellsWithMouse;
        }
        void Greeting(ActiveGridDemo activeDemo) {
            Point mouseTo = new Point(gridControl1.Width / 2, gridControl1.Height / 4);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoGridDataToCopy);
            mouseTo = new Point(7 * gridControl1.Width / 8, gridControl1.Height / 8);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoCustomizeOptions);
        }
        void ExpandOptionsBtnClick(ActiveGridDemo activeDemo) {
            Point mouseTo = new Point(
                gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.X - gridViewPropertiesLayoutGroup.Bounds.X + gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.Width / 2,
                gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.Y - gridViewPropertiesLayoutGroup.Bounds.Y + gridViewPropertiesLayoutGroup.ViewInfo.BorderInfo.ButtonBounds.Height / 2);
            activeDemo.Actions.MouseClick(propertyGridControl, mouseTo);
        }
        void SelectPropertyGridOption(ActiveGridDemo activeDemo, string optionName, object optionValue) {
            int dropDownBtnWidth = SystemInformation.VerticalScrollBarWidth;
            int dropDownBtnHeight = SystemInformation.VerticalScrollBarThumbHeight;
            BaseRowViewInfo allowHtml = propertyGridControl.ViewInfo.GetRowValueInfo(propertyGridControl.GetRowByFieldName(optionName), 0, 0).RowViewInfo;
            Point mouseTo = new Point(
                allowHtml.ValuesRect.X + allowHtml.ValuesRect.Width - dropDownBtnWidth / 2,
                allowHtml.ValuesRect.Y + dropDownBtnWidth / 2);
            activeDemo.Actions.MouseClick(propertyGridControl, mouseTo);
            ActiveActions.Delay(1000);
            XtraEditors.Controls.ImageComboBoxItemCollection items = (propertyGridControl.ActiveEditor.Properties as XtraEditors.Repository.RepositoryItemImageComboBox).Items;
            int index = items.IndexOf(items.FirstOrDefault(x => x.Value.Equals(optionValue.ToString())));
            var cache = GraphicsInfo.Default.AddCache(null);
            mouseTo = new Point(
                allowHtml.ValuesRect.X + allowHtml.ValuesRect.Width / 2,
                allowHtml.ValuesRect.Y + allowHtml.ValuesRect.Height + (int)((index + 0.5) * allowHtml.ValuesInfo[0].Item.Appearance.GetFontHeight(cache)));
            GraphicsInfo.Default.ReleaseGraphics();
            activeDemo.Actions.MoveMousePointTo(propertyGridControl, mouseTo);
            ActiveActions.Delay(500);
            activeDemo.Actions.MouseClick();
            ActiveDemoResults.Add(string.Format("{0} : {1}", optionName, optionValue.ToString()));
        }
        void ModifyGrid(ActiveGridDemo activeDemo) {
            Point mouseTo = new Point(gridControl1.Width / 2, gridControl1.Height / 4);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoModifyLayout);
            activeDemo.GroupByColumn(this.colSalesVsTarget);
            ActiveDemoResults.Add(string.Format(Properties.Resources.ClipboardActiveDemoGroupBy, colSalesVsTarget.ToString()));
            activeDemo.ExpandCollapseRow(gridView1, 0);
            activeDemo.ExpandCollapseRow(gridView1, 1);
            activeDemo.ExpandCollapseRow(gridView1, 2);
            ActiveDemoResults.Add(string.Format(Properties.Resources.ClipboardActiveDemoExpandedRows, 0, 1, 2));
            gridView1.FocusedRowHandle = -7;
        }
        void SelectCells(ActiveGridDemo activeDemo) {
            Point mouseTo = new Point(gridControl1.Width / 2, gridControl1.Height / 4);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoSelectCells);
            Rectangle r1 = (gridView1.GetViewInfo() as GridViewInfo).GetGridRowInfo(-1).Bounds;
            Rectangle r2 = (gridView1.GetViewInfo() as GridViewInfo).GetGridRowInfo(-6).Bounds;
            mouseTo = new Point(r1.Left + r1.Width / 6, r1.Top + r1.Height / 2);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            activeDemoSelectCellsWithMouse = true;
            mouseTo = new Point(r1.Right - r1.Width / 6, r1.Bottom + r1.Height / 2);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            mouseTo = new Point(r2.Right - r2.Width / 6, r2.Top + r2.Height / 2);
            activeDemo.Actions.MoveMousePointTo(gridControl1, mouseTo);
            activeDemoSelectCellsWithMouse = false;
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoCopyWithShortcut);
        }
        void PressCopyBtn(ActiveGridDemo activeDemo) {
            Point mouseTo = new Point(copyPasteButtonLCI.Width / 2, copyPasteButtonLCI.Height / 2);
            activeDemo.Actions.MoveMousePointTo(copyPasteButtonLCI.Control, mouseTo);
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoCopyWithButton);
            activeDemo.Actions.MouseClick(copyPasteButtonLCI.Control, mouseTo);
            mouseTo = new Point(0, 0);
            activeDemo.Actions.MoveMousePointTo(spreadsheetControl1, mouseTo);
            activeDemo.ShowMessage(Properties.Resources.ClipboardActiveDemoSelectionPasted);
        }
        void SelectCellsWithMouse(object sender, MouseEventArgs e) {
            if(!activeDemoSelectCellsWithMouse)
                return;
            GridHitInfo info = gridView1.CalcHitInfo(e.X, e.Y);
            if(info.InGroupRow) {
                gridView1.SelectCells(-1, gridView1.VisibleColumns.First(), info.RowHandle, gridView1.VisibleColumns.Last());
            }
            else
                gridView1.SelectCells(-1, this.colState, info.RowHandle, info.Column);
        }
        #endregion
        public ClipboardTutorial() {
            InitializeComponent();
            Init();
        }
        void Init() {
            gridControl1.DataSource = new BindingList<SaleOverviewData>(SaleOverviewDataGenerator.GenerateSales().ToList());
            propertyGridControl.SelectedObject = gridView1.OptionsClipboard;
            propertyGridControl.ExpandAllRows();
            gridViewPropertiesLayoutGroup.Expanded = false;
            gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(60, 0, 0, 240);
            gridView1.OptionsSelection.EnableAppearanceHideSelection = false;

        }
        internal void PasteClipboardData() {
            PasteHTMLFormat();
            PasteXLSFormat();
            PasteRTFFormat();
        }
        void PasteRTFFormat() {
            richEditControl.Document.RtfText = string.Empty;
            richEditControl.Document.Text = string.Empty;
            try {
                if(gridView1.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                    string rtfText = SafeClipboardWin.Instance.GetData(DataFormats.Rtf) as string;
                    richEditControl.Document.AppendRtfText(rtfText);
                }
                else {
                    string text = SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText) as string;
                    richEditControl.Document.AppendText(text);
                }
            }
            catch { }
        }
        void PasteXLSFormat() {
            spreadsheetControl1.BeginUpdate();
            spreadsheetControl1.ActiveWorksheet.Clear(spreadsheetControl1.ActiveWorksheet.GetDataRange());
            try {
                if(gridView1.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                    Stream stream = SafeClipboardWin.Instance.GetData("Biff8") as Stream;
                    if(stream != null)
                        spreadsheetControl1.LoadDocument(stream, DocumentFormat.Xls);
                }
                else {
                    int nextRow = 0;
                    string text = SafeClipboardWin.Instance.GetData(DataFormats.UnicodeText) as string;
                    foreach(var line in text.Split('\n')) {
                        spreadsheetControl1.ActiveWorksheet.Import(line.Split('\t'), nextRow, 0, false);
                        nextRow++;
                    }
                }
            }
            catch { }
            spreadsheetControl1.ActiveWorksheet.DefaultColumnWidthInPixels = spreadsheetControl1.Width / gridView1.Columns.Count;
            spreadsheetControl1.EndUpdate();
        }
        void PasteHTMLFormat() {
            if(gridView1.OptionsClipboard.ClipboardMode == ClipboardMode.Formatted) {
                string html = "";
                try {
                    html = SafeClipboardWin.Instance.GetData(DataFormats.Html) as string;
                }
                catch { }
                if(string.IsNullOrEmpty(html)) {
                    webBrowser1.DocumentText = string.Empty;
                    return;
                }
                int htmlTagPos = html.IndexOf("<html", StringComparison.OrdinalIgnoreCase);
                if(htmlTagPos < 0)
                    return;
                html = html.Substring(htmlTagPos);
                webBrowser1.DocumentText = html;
            }
            else {
                webBrowser1.DocumentText = "<html><body><p align=\"center\">Copying data in HTML format is not supported in this Clipboard Mode</p></body></html>";
            }
        }
        void ClipboardTutorial_Load(object sender, EventArgs e) {
            gridView1.BestFitColumns();
            gridView1.SelectCellAnchorRange(2, colState, 20, colMarketShare);
        }
        void simpleButtonCopyPaste_Click(object sender, EventArgs e) {
            gridControl1.CopyAndPaste();
        }
        private void layoutControl1_GroupExpandChanged(object sender, XtraLayout.Utils.LayoutGroupEventArgs e) {
            if(gridViewPropertiesLayoutGroup.Expanded) {
                splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Always;
            }
            else splitterItem1.Visibility = XtraLayout.Utils.LayoutVisibility.Never;
        }

        private void gridView1_ShowingEditor(object sender, CancelEventArgs e) {
            e.Cancel = true;
        }
    }
    public class ClipboardGridControl : GridControl {
        ClipboardTutorial userControlCore;
        internal ClipboardTutorial ClipboardTutorial {
            get {
                if(userControlCore == null)
                    userControlCore = Parent.Parent as ClipboardTutorial;
                return userControlCore;
            }
        }
        public void CopyAndPaste() {
            OnKeyDown(new KeyEventArgs(Keys.Control | Keys.C));
        }
        protected override void OnKeyDown(KeyEventArgs e) {
            base.OnKeyDown(e);
            if(e.Control && e.KeyCode == Keys.C) {
                ClipboardTutorial.PasteClipboardData();
            }
        }
    }
}
