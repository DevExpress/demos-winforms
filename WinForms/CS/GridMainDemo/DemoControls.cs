using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.ActiveDemos;
using DevExpress.DXperience.Demos;
using DevExpress.Export;
using DevExpress.Internal;
using DevExpress.Tutorials;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Blending;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.ReportGeneration;
using DevExpress.XtraReports.UI;
using static DevExpress.XtraGrid.Demos.VehiclesData;

namespace DevExpress.XtraGrid.Demos {
    public class GridRibbonMenuManager : RibbonMenuManager {
        BaseView view = null;
        XtraGridBlending blending = null;
        BarSubItem bsiViewOptions, bsiSelectionOptions;
        BarCheckItem bciAlphaBlendingUsing;
        BarButtonItem bbiAlphaBlendingAdjustment;
        public GridRibbonMenuManager(RibbonMainForm form) : base(form) {
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon);
            CreateBlendingMenu(form.ReservGroup2, form.Ribbon);
        }
        void CreateBlendingMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = Properties.Resources.AlphaBlending;
            bciAlphaBlendingUsing = new CheckBarItem(Manager, Properties.Resources.UsingString, new ItemClickEventHandler(miUsing_Click));
            bbiAlphaBlendingAdjustment = new ButtonBarItem(Manager, Properties.Resources.Adjustment, new ItemClickEventHandler(miAdjustment_Click));
            bbiAlphaBlendingAdjustment.Glyph = Utils.ResourceImageHelper.CreateImageFromResourcesEx("DevExpress.XtraGrid.Demos.Images.Blending.png", typeof(frmMain).Assembly);
            ribbonPageGroup.ItemLinks.Add(bciAlphaBlendingUsing);
            ribbonPageGroup.ItemLinks.Add(bbiAlphaBlendingAdjustment);
        }
        void CreateOptionsMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = Properties.Resources.Options;
            bsiViewOptions = new BarSubItem();
            bsiSelectionOptions = new BarSubItem();
            bsiViewOptions.Caption = Properties.Resources.ViewOptions;
            bsiSelectionOptions.Caption = Properties.Resources.SelectionOptions;
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View");
            MainFormHelper.SetBarButtonImage(bsiSelectionOptions, "LayoutOptions");
            ribbonControl.Items.Add(bsiViewOptions);
            ribbonControl.Items.Add(bsiSelectionOptions);
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions);
            ribbonPageGroup.ItemLinks.Add(bsiSelectionOptions);
        }
        public void RefreshOptionsMenu(BaseView view) {
            GridOptionsView ov = new GridOptionsView();
            ShowReservGroup1(view != null);
            this.view = view;
            LookAndFeelMenu.ClearOptionItems(Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, new ItemClickEventHandler(miViewOptions_Click), Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiSelectionOptions, SelectionOptions, new ItemClickEventHandler(miSelectionViewOptions_Click), Manager);
        }
        object ViewOptions {
            get {
                if(view is GridView) return ((GridView)view).OptionsView;
                if(view is CardView) return ((CardView)view).OptionsView;
                return null;
            }
        }
        object SelectionOptions {
            get {
                if(view is GridView) return ((GridView)view).OptionsSelection;
                return null;
            }
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(view != null && item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), ViewOptions, item.Checked);
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions);
            }
        }
        void miSelectionViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(view != null && item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Tag.ToString(), SelectionOptions, item.Checked);
                LookAndFeelMenu.InitOptionsMenu(bsiSelectionOptions, SelectionOptions);
            }
        }
        public void InitBlendingMenu(XtraGridBlending blending) {
            this.blending = blending;
            ShowReservGroup2(blending != null);
            if(blending != null) {
                bciAlphaBlendingUsing.Checked = blending.Enabled;
                bbiAlphaBlendingAdjustment.Enabled = blending.Enabled;
            }
        }
        void miUsing_Click(object sender, ItemClickEventArgs e) {
            Application.DoEvents();
            CheckBarItem item = e.Item as CheckBarItem;
            if(blending != null && item != null) {
                blending.Enabled = item.Checked;
                bbiAlphaBlendingAdjustment.Enabled = item.Checked;
            }
        }
        void miAdjustment_Click(object sender, ItemClickEventArgs e) {
            if(blending != null) {
                blending.ShowDialog();
            }
        }
    }
    public class TutorialControl : DevExpress.DXperience.Demos.TutorialControlBase {
        public GridRibbonMenuManager GridRibbonMenuManager { get { return RibbonMenuManager as GridRibbonMenuManager; } }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            GridControl grid = ctrl as XtraGrid.GridControl;
            if(grid != null)
                grid.MenuManager = manager;
            XtraEditors.ScrollBarBase scrollBar = ctrl as XtraEditors.ScrollBarBase;
            if(scrollBar != null && FluentScrollBars)
                XtraEditors.ScrollBarBase.ApplyUIMode(scrollBar, XtraEditors.ScrollUIMode.Fluent);
            BaseEdit be = ctrl as BaseEdit;
            if(be != null)
                be.MenuManager = manager;
        }
        protected virtual bool FluentScrollBars {
            get { return false; }
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.DOCX | ExportFormats.RTF | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions { get { return ExportView != null; } }
        public override bool AllowGenerateReport { get { return true; } }
        public virtual BaseView ExportView { get { return null; } }
        public virtual bool AllowCellImagesExport { get { return false; } }
        public virtual bool ShowViewOptions { get { return false; } }
        protected virtual PaintView[] PaintViews { get { return null; } }
        protected override string ModulesFolder { get { return "GridMainDemo\\Modules\\"; } }
        protected override string CodeInfoFolder { get { return "DevExpress.XtraGrid.Demos.CodeInfo"; } }
        #region Active Demo
        ActiveDemoResults fActiveDemoResults = null;
        private ActiveDemo fActiveDemo = null;
        public override void RunActiveDemo() {
            if(IsActiveDemo) return;
            ActiveDemoResults.Clear();
            fActiveDemo = CreateActiveDemo();
            RunGridActiveDemo(fActiveDemo as ActiveGridDemo);
            ActiveActionsCancelMode cancelMode = fActiveDemo.Actions.CancelMode;
            fActiveDemo.Dispose();
            fActiveDemo = null;
            if(cancelMode == ActiveActionsCancelMode.UnknownTopWindow)
                System.Windows.Forms.MessageBox.Show(Properties.Resources.ActiveDemoWarning); //TODO
            if(cancelMode == ActiveActionsCancelMode.UserCancel)
                System.Windows.Forms.MessageBox.Show(Properties.Resources.ActiveDemoCanceled);
        }
        public bool IsActiveDemo { get { return fActiveDemo != null; } }
        protected virtual ActiveDemo CreateActiveDemo() {
            return new ActiveDemo();
        }
        protected ActiveDemoResults ActiveDemoResults {
            get {
                if(fActiveDemoResults == null) fActiveDemoResults = new ActiveDemoResults(this);
                return fActiveDemoResults;
            }
        }
        protected virtual void RunGridActiveDemo(ActiveGridDemo fActiveDemo) { }
        protected override void OnVisibleChanged(object sender, EventArgs e) {
            if(fActiveDemoResults != null)
                if(!this.Visible) ActiveDemoResults.Hide();
            base.OnVisibleChanged(sender, e);
        }
        #endregion
        #region InitData
        protected virtual void InitNWindData() {
            string DBFileName = string.Empty;

            DBFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml");
            if(DBFileName != string.Empty) {
                TutorialHelper.DataSetConvertByteToImage(InitNWindXMLData(DBFileName));
            }
        }
        protected internal virtual void UpdateRibbonItems() { }
        protected virtual void InitVehiclesData() {
            string DBFileName = string.Empty;

            DBFileName = DevAVDataDirectoryHelper.GetFile("Vehicles.xml");
            if(DBFileName != string.Empty) {
                InitXMLData(DBFileName);
            }
        }
        protected virtual DataSet InitNWindXMLData(string dataFileName) {
            return null;
        }
        protected virtual void InitXMLData(string dataFileName) {
        }
        protected virtual DataSet NWindDataSet() {
            string DBFileName = string.Empty;
            DataSet ds = new DataSet();

            DBFileName = DevAVDataDirectoryHelper.GetFile("nwind.xml");
            if(DBFileName != string.Empty) {
                InitXMLData(DBFileName, ds);
            }
            TutorialHelper.DataSetConvertByteToImage(ds);
            return ds;
        }
        protected virtual void InitXMLData(string dataFileName, DataSet ds) {
        }
        protected virtual void InitIssueListData(dsIssueList ds, GridControl grid = null) {
            string DBFileName = string.Empty;

            DBFileName = DevAVDataDirectoryHelper.GetFile("IssueList.xml");
            if(DBFileName != string.Empty) {
                ds.ReadXml(DBFileName, XmlReadMode.InferSchema);
                UpdateIssueListData(ds.Items, 100);
            }
            if(grid != null) {
                grid.DataSource = ds.Items.
                    OrderBy(r => r.Status).
                    OrderBy(r => r.Priority).
                    OrderBy(r => !r.Type).
                    OrderBy(r => r.ProjectID).ToList();
            }
        }
        void UpdateIssueListData(dsIssueList.ItemsDataTable table, int newRowsCount) {
            int days = (TutorialConstants.Now.Date - new DateTime(2004, 8, 29)).Days;
            foreach(dsIssueList.ItemsRow row in table) {
                row.CreatedDate = row.CreatedDate.AddDays(days);
                if(!row.IsModifiedDateNull())
                    row.ModifiedDate = row.ModifiedDate.AddDays(days);
                if(!row.IsFixedDateNull())
                    row.FixedDate = row.FixedDate.AddDays(days);
            }
            for(int i = 0; i < newRowsCount; i++) {
                DateTime createdDate = TutorialConstants.Today.AddDays(-TutorialConstants.Random.Next(40));
                dsIssueList.ItemsRow row1 = table[i % table.Rows.Count];
                dsIssueList.ItemsRow row2 = table[TutorialConstants.Random.Next(newRowsCount) % table.Rows.Count];
                table.Rows.Add(new object[] {createdDate, row2.CreatorID, row1.Description, GetFixedDate(createdDate, row2.Status, TutorialConstants.Random), i + 100,
                GetModifiedDate(createdDate, row2.Status, TutorialConstants.Random), row1.Name, row2.OwnerID, row2.Priority, row2.ProjectID, row2.Resolution, row2.Status, row2.Type});
            }
        }
        DateTime? GetFixedDate(DateTime createdDate, int status, Data.Utils.NonCryptographicRandom rnd) {
            if(status < 3) return null;
            DateTime ret = createdDate.AddDays(rnd.Next(7));
            if(ret > TutorialConstants.Today) return TutorialConstants.Today; else return ret;
        }
        DateTime? GetModifiedDate(DateTime createdDate, int status, Data.Utils.NonCryptographicRandom rnd) {
            if(status == 1) return null;
            DateTime ret = createdDate.AddDays(rnd.Next(5));
            if(ret > TutorialConstants.Today) return TutorialConstants.Today; else return ret;
        }
        protected virtual void InitCustomersPaymentData(dsContacts ds) {
            string DBFileName = string.Empty;

            DBFileName = DevAVDataDirectoryHelper.GetFile("Payment.xml");
            if(DBFileName != string.Empty) {
                ds.ReadXml(DBFileName);
            }
        }
        #endregion
        #region Print and Export
        protected override void ExportToCore(String filename, string ext) {
            if(ExportView == null) return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") ExportView.ExportToRtf(filename);
            if(ext == "docx") ExportView.ExportToDocx(filename);
            if(ext == "pdf") ExportView.ExportToPdf(filename);
            if(ext == "mht") ExportView.ExportToMht(filename);
            if(ext == "html") ExportView.ExportToHtml(filename);
            if(ext == "txt") ExportView.ExportToText(filename);
            if(ext == "xls") ExportToXlsInternal(filename);
            if(ext == "xlsx") ExportToXlsxInternal(filename);
            Cursor.Current = currentCursor;
        }
        void ExportToXlsxInternal(string filename) {
            var options = new XlsxExportOptionsEx();
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula;
            if(!(ExportView is GridView))
                options.ExportType = ExportType.WYSIWYG;
            if(AllowCellImagesExport)
                options.AllowCellImages = Utils.DefaultBoolean.True;
            ExportView.ExportToXlsx(filename, options);
        }
        void ExportToXlsInternal(string filename) {
            var options = new XlsExportOptionsEx();
            options.UnboundExpressionExportMode = UnboundExpressionExportMode.AsFormula;
            if(!(ExportView is GridView))
                options.ExportType = ExportType.WYSIWYG;
            ExportView.ExportToXls(filename, options);
        }
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
        protected override void ExportToText() {
            ExportTo("txt", Properties.Resources.TextFilter);
        }
        protected override void PrintPreview() {
            if(this.ExportView != null && this.ExportView.GridControl != null) {
                ExportView.PrintInitialize += ExportView_PrintInitialize;
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.ExportView.GridControl.ShowRibbonPrintPreview();
                else this.ExportView.GridControl.ShowPrintPreview();
                ExportView.PrintInitialize -= ExportView_PrintInitialize;
            }
        }
        protected override void GenerateReport() {
            bool useExpressionBindings = XtraReports.Configuration.Settings.Default.UserDesignerOptions.DataBindingMode != DataBindingMode.Bindings;
            XtraReport report = ReportGenerator.GenerateReport(ExportView, null, useExpressionBindings);
            report.ShowRibbonDesignerDialog();
        }
        void ExportView_PrintInitialize(object sender, PrintInitializeEventArgs e) {
            PageHeaderFooter phf = e.Link.PageHeaderFooter as PageHeaderFooter;
            phf.Footer.Content.Clear();
            phf.Footer.Content.AddRange(new string[] { "", "", "[Page # of Pages #]" });
            phf.Footer.LineAlignment = BrickAlignment.Far;

            e.Link.RtfReportHeader = @"{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}
{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\qc\lang9\f0\fs32 " + TutorialName + @"\par}\xd\x\a";
        }
        #endregion
        protected void SetEditLicenseInfo(RepositoryItem edit, ColumnView view) {
            LicenseToolTipController.SetEditLicenseInfo(edit, view);
        }
    }
    public class PaintView {
        readonly BaseView fView = null;
        string fAppearanceName = "";
        public PaintView(BaseView fView, string fAppearanceName) {
            this.fView = fView;
            this.fAppearanceName = fAppearanceName;
        }
        public BaseView View {
            get { return fView; }
        }
        public string AppearanceName {
            get { return fAppearanceName; }
        }
    }
    public static class LicenseInfo {
        public static void SetToolTipController(TutorialControl module, GridControl grid) {
            grid.ToolTipController = module.LicenseToolTipController;
            module.LicenseToolTipController.OnLicenseChanged += (s, e) =>
                e.Info = GetLicenseInfo(e.Row);
            module.LicenseToolTipController.UpdateMaskOptions(grid);
            grid.ViewRegistered += (s, e) => module.LicenseToolTipController.UpdateMaskOptions(grid);
        }
        static string GetLicenseInfo(object obj) {
            var model = obj as Model;
            if(model != null)
                return model.LicenseInfo;
            var item = obj as VehiclesData.OrderItem;
            if(item != null)
                return item.Model.LicenseInfo;
            var row = obj as DataRowView;
            if(row != null)
                return VehiclesData.GetLicenseInfo(row.Row);
            return null;
        }
    }
}
