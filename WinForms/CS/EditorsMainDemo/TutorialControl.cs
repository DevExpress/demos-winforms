using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos;
using DevExpress.Export;
using DevExpress.Internal;
using DevExpress.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraLayout;
using DevExpress.XtraPrinting;
using DevExpress.XtraTab;
using DevExpress.XtraVerticalGrid;

namespace DevExpress.XtraEditors.Demos {
    public class TutorialControl : TutorialControlBase {
        List<Panel> centerControls = new List<Panel>();
        public TutorialControl() {
            this.Padding = Padding.Empty;
            this.SizeChanged += (s, e) => UpdatePosition();
            SubscribeOnEvents();
        }
        protected virtual bool AllowCenterControls {
            get { return true; }
        }
        protected override string ModulesFolder {
            get { return "EditorsMainDemo\\Modules"; }
        }
        protected override string CodeInfoFolder {
            get { return "DevExpress.XtraEditors.Demos.CodeInfo"; }
        }

        void UpdatePosition() {
            foreach(Panel pnl in centerControls) {
                if(pnl.Parent == null)
                    continue;
                pnl.Location = new Point((pnl.Parent.Width - pnl.Width) / 2, (pnl.Parent.Height - pnl.Height) / 2);
            }
        }
        #region Export

        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.XLS | ExportFormats.DOCX | ExportFormats.RTF | ExportFormats.XLSX, false);
        }
        public virtual BaseView ExportView { get { return null; } }
        protected override void ExportToPDF() {
            ExportTo("pdf", Properties.Resources.PDFFilter);
        }
        protected override void ExportToHTML() {
            ExportTo("html", Properties.Resources.HTMLFilter);
        }
        protected override void ExportToMHT() {
            ExportTo("mht", Properties.Resources.MHTFilter);
        }
        protected override void ExportToXLS() {
            ExportTo("xls", Properties.Resources.XLSFilter);
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", Properties.Resources.XLSXFilter);
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", Properties.Resources.RTFFilter);
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", Properties.Resources.DOCXFilter);
        }
        protected override void ExportToCore(String filename, string ext) {
            if(ExportView == null) return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") ExportView.ExportToRtf(filename);
            if(ext == "pdf") ExportView.ExportToPdf(filename);
            if(ext == "docx") ExportView.ExportToDocx(filename);
            if(ext == "html") ExportView.ExportToHtml(filename);
            if(ext == "xls") ExportViewToXls(filename);
            if(ext == "xlsx") ExportViewToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        void ExportViewToXlsx(string filename) {
            var options = new XlsxExportOptionsEx();
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula;
            ExportView.ExportToXlsx(filename, options);
        }
        void ExportViewToXls(string filename) {
            var options = new XlsExportOptionsEx();
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula;
            ExportView.ExportToXls(filename, options);
        }
        protected override void PrintPreview() {
            if(ExportView != null && ExportView.GridControl != null) {
                ExportView.PrintInitialize += ExportView_PrintInitialize;
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    ExportView.GridControl.ShowRibbonPrintPreview();
                else ExportView.GridControl.ShowPrintPreview();
                ExportView.PrintInitialize -= ExportView_PrintInitialize;
            }
        }
        void ExportView_PrintInitialize(object sender, PrintInitializeEventArgs e) {
            PageHeaderFooter phf = e.Link.PageHeaderFooter as PageHeaderFooter;
            if(phf != null) {
                phf.Footer.Content.Clear();
                phf.Footer.Content.AddRange(new string[] { "", "", "[Page # of Pages #]" });
                phf.Footer.LineAlignment = BrickAlignment.Far;
            }
            e.Link.RtfReportHeader = @"{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\qc\lang9\f0\fs32 " + TutorialName + @"\par}\xd\x\a";
        }

        #endregion
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            GridControl grid = ctrl as GridControl;
            if(grid != null) grid.MenuManager = manager;
            PropertyGridControl pGrid = ctrl as PropertyGridControl;
            if(pGrid != null) pGrid.MenuManager = manager;
            BaseEdit be = ctrl as BaseEdit;
            if(be != null) be.MenuManager = manager;
        }
        public override bool AllowPrintOptions {
            get { return false; }
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if(AllowCenterControls) {
                foreach(Control ctrl in this.Controls) {
                    XtraTabControl tabControl = ctrl as XtraTabControl;
                    if(tabControl != null) UpdateTabControlPosition(tabControl);
                    var tablePanel = ctrl as Utils.Layout.TablePanel;
                    if(tablePanel != null) CalcTablePanelBounds(tablePanel);
                    TabPane tabPane = ctrl as TabPane;
                    if(tabPane != null) UpdateTabPanePosition(tabPane);
                }
                UpdatePosition();
            }
            CalcContentCore();
        }
        protected virtual void CalcContentCore() { }
        protected virtual void OnLookAndFeelChanged(object sender, EventArgs e) {
            CalcContentCore();
        }
        protected virtual void SubscribeOnEvents() {
            if(LookAndFeel != null)
                LookAndFeel.StyleChanged += OnLookAndFeelChanged;
        }
        protected virtual void UnsubscribeOnEvents() {
            if(LookAndFeel != null)
                LookAndFeel.StyleChanged -= OnLookAndFeelChanged;
        }
        protected override void OnSizeChanged(EventArgs e) {
            base.OnSizeChanged(e);
            if(lockCalcContentCore == 0)
                CalcContentCore();
        }
        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if(Visible) CalcContentCore();
        }
        int lockCalcContentCore = 0;
        protected override void DoDpiChange(int deviceDpiOld, int deviceDpiNew) {
            lockCalcContentCore++;
            base.DoDpiChange(deviceDpiOld, deviceDpiNew);
        }
        protected override void DoDpiChangeAfterParent() {
            base.DoDpiChangeAfterParent();
            lockCalcContentCore--;
            if(Visible)
                BeginInvoke(new Action(() => {
                    CalcContentCore();
                }));
        }
        protected void CalcLayoutControlBounds(LayoutControl layout) {
            if(layout == null || layout.Parent == null || !layout.Parent.IsHandleCreated)
                return;
            Size bestSize = CalcBestSize(layout);
            layout.SetBounds((layout.Parent.Width - bestSize.Width) / 2, (layout.Parent.Height - bestSize.Height) / 2, bestSize.Width, bestSize.Height);
        }
        protected void CalcTablePanelBounds(Utils.Layout.TablePanel tablePanel) {
            if(tablePanel == null || tablePanel.Parent == null || !tablePanel.Parent.IsHandleCreated)
                return;
            Size bestSize = tablePanel.Size;
            tablePanel.SetBounds(
                    (tablePanel.Parent.Width - bestSize.Width) / 2,
                    (tablePanel.Parent.Height - bestSize.Height) / 2,
                    bestSize.Width, bestSize.Height
                );
        }
        Size CalcBestSize(LayoutControl layout) {
            Size minSize = layout.Root.MinSize;
            VScrollBar vScrBar = layout.Controls.Cast<Control>().FirstOrDefault(control => control is VScrollBar) as VScrollBar;
            HScrollBar hScrBar = layout.Controls.Cast<Control>().FirstOrDefault(control => control is HScrollBar) as HScrollBar;
            if(vScrBar == null || hScrBar == null)
                return layout.Size;
            int bestWidth = Math.Min(layout.Parent.Width, minSize.Width);
            int bestHeight = Math.Min(layout.Parent.Height, minSize.Height);
            bool wasCalcWidth = false;
            if(bestWidth < minSize.Width) {
                bestHeight += hScrBar.Height;
                wasCalcWidth = true;
            }
            if(bestHeight < minSize.Height) {
                bestWidth += vScrBar.Width;
                if(!wasCalcWidth && bestWidth < minSize.Width) {
                    bestHeight += hScrBar.Height;
                }
            }
            return new Size(Math.Min(layout.Parent.Width, bestWidth), Math.Min(layout.Parent.Height, bestHeight));
        }
        protected virtual void UpdateTabControlPosition(XtraTabControl tabControl) {
            tabControl.SelectedPageChanged += (s, e) => UpdatePosition();
            foreach(XtraTabPage page in tabControl.TabPages) {
                if(page != null) UpdatePagePosition(page);
            }
        }
        protected virtual void UpdateTabPanePosition(TabPane tabPane) {
            tabPane.SelectedPageChanged += (s, e) => UpdatePosition();
        }
        protected void CalcTrackBarBestSize(TrackBarControl trackBar) {
            trackBar.Properties.AutoSize = false;
            var viewInfo = trackBar.GetViewInfo() as DevExpress.XtraEditors.ViewInfo.TrackBarViewInfo;
            if(viewInfo != null)
                viewInfo.AllowDrawFocusRect = false;
            int bestHeight = trackBar.CalcBestSize().Height;
            trackBar.MinimumSize = new Size(trackBar.MinimumSize.Width, bestHeight);
            trackBar.MaximumSize = new Size(trackBar.MaximumSize.Width, bestHeight);
            trackBar.Height = bestHeight;
        }
        protected virtual void UpdatePagePosition(XtraTabPage page) {
            Panel pnl = new Panel();
            int _left = 100, _right = 0, _top = 100, _bottom = 0;
            for(int i = page.Controls.Count - 1; i >= 0; i--) {
                Control ctrl = page.Controls[i];
                if(ctrl is PopupContainerControl || ctrl is PopupControlContainer || ctrl is FlyoutPanel) continue;
                if(_left > ctrl.Left) _left = ctrl.Left;
                if(_right < ctrl.Right) _right = ctrl.Right;
                if(_top > ctrl.Top) _top = ctrl.Top;
                if(_bottom < ctrl.Bottom) _bottom = ctrl.Bottom;
                ctrl.Parent = pnl;
            }
            pnl.Parent = page;
            pnl.Size = new Size(_right + _left, _bottom + _top);
            centerControls.Add(pnl);
        }
        protected override void Dispose(bool disposing) {
            UnsubscribeOnEvents();
            base.Dispose(disposing);
        }
        static DataSet nwindDataSet;
        protected static DataSet NWindDataSet {
            get { return nwindDataSet ?? (nwindDataSet = LoadNWindDataSet()); }
        }
        static DataSet LoadNWindDataSet() {
            var nwind = new DataSet();
            string dbFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                nwind.ReadXml(dbFileName);
                DevExpress.Tutorials.TutorialHelper.DataSetConvertByteToImage(nwind);
            }
            return nwind;
        }
    }

    public class MatchFunction : ICustomFunctionDisplayAttributes {
        public const string FunctionName = "Match";
        static readonly MatchFunction Instance = new MatchFunction();
        MatchFunction() { }
        //
        public static void Register() {
            CriteriaOperator.RegisterCustomFunction(Instance);
        }
        public static bool Unregister() {
            return CriteriaOperator.UnregisterCustomFunction(Instance);
        }
        public static CriteriaOperator Criteria(string property, IEnumerable<string> tags) {
            List<CriteriaOperator> operands = new List<CriteriaOperator>();
            operands.Add(new OperandProperty(property));
            foreach(var tag in tags)
                operands.Add(new ConstantValue(tag));
            return new FunctionOperator(FunctionName, operands);
        }
        #region ICustomFunctionOperatorBrowsable Members
        public FunctionCategory Category {
            get { return FunctionCategory.Text; }
        }
        public string Description {
            get { return "Selects items that match the specified tags."; }
        }
        public bool IsValidOperandCount(int count) {
            return count > 1;
        }
        public bool IsValidOperandType(int operandIndex, int operandCount, Type type) {
            return type == typeof(string);
        }
        public int MaxOperandCount {
            get { return int.MaxValue; }
        }
        public int MinOperandCount {
            get { return 2; }
        }
        #endregion
        #region ICustomFunctionDisplayAttributes
        public string DisplayName {
            get { return "Match"; }
        }
        public object Image {
            get { return null; }
        }
        #endregion
        #region ICustomFunctionOperator Members
        readonly string[] splitSymbols = new string[] { ",", ";" };
        public object Evaluate(params object[] operands) {
            if(operands != null && operands.Length > 1 && operands[0] != null) {
                var sourceParts = operands[0].ToString()
                    .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim());
                var sourceTags = new HashSet<string>(sourceParts, StringComparer.OrdinalIgnoreCase);
                foreach(string tag in operands.Skip(1)) {
                    if(sourceTags.Contains(tag))
                        return true;
                }
            }
            return false;
        }
        public string Name {
            get { return FunctionName; }
        }
        public Type ResultType(params Type[] operands) {
            return typeof(bool);
        }
        #endregion
    }
}
