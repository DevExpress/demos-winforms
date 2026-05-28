using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.Internal;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraPrinting;

namespace DevExpress.XtraVerticalGrid.Demos {
    public class TutorialControl : TutorialControlBase {
        public TutorialControl() { }
        protected override string ModulesFolder {
            get { return "VertGridMainDemo\\Modules"; }
        }
        protected override string CodeInfoFolder {
            get { return "DevExpress.XtraVerticalGrid.Demos.CodeInfo"; }
        }
        public VGridRibbonMenuManager VertGridRibbonMenuManager {
            get { return RibbonMenuManager as VGridRibbonMenuManager; }
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            var vGrid = ctrl as VGridControlBase;
            if(vGrid != null)
                vGrid.MenuManager = manager;
        }
        public virtual VGridControlBase ViewOptionsControl {
            get { return null; }
        }
        void HideCustomization(ControlCollection collection) {
            foreach(Control ctrl in collection) {
                HideCustomization(ctrl.Controls);
                if(ctrl is VGridControlBase)
                    ((VGridControlBase)ctrl).DestroyCustomization();
            }
        }
        protected override void DoHide() {
            HideCustomization(this.Controls);
        }
        protected virtual void InitNWindData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(DBFileName != string.Empty)
                InitXMLData(DBFileName);
        }
        protected virtual void InitMDBData(string connectionString) { }
        protected virtual void InitXMLData(string xmlFileName) { }
        #region Print and Export
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.RTF | ExportFormats.DOCX | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions {
            get { return ExportControl != null; }
        }
        public virtual VGridControlBase ExportControl {
            get { return null; }
        }
        protected override void ExportToCore(String filename, string ext) {
            if(ExportControl == null)
                return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf") ExportControl.ExportToRtf(filename);
            if(ext == "docx") ExportControl.ExportToDocx(filename);
            if(ext == "pdf") ExportControl.ExportToPdf(filename);
            if(ext == "mht") ExportControl.ExportToMht(filename, new MhtExportOptions());
            if(ext == "html") ExportControl.ExportToHtml(filename);
            if(ext == "txt") ExportControl.ExportToText(filename);
            if(ext == "xls") ExportControl.ExportToXls(filename);
            if(ext == "xlsx") ExportControl.ExportToXlsx(filename);
            Cursor.Current = currentCursor;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToMHT() {
            ExportTo("mht", "MHT document (*.mht)|*.mht");
        }
        protected override void ExportToXLS() {
            ExportTo("xls", "XLS document (*.xls)|*.xls");
        }
        protected override void ExportToXLSX() {
            ExportTo("xlsx", "XLSX document (*.xlsx)|*.xlsx");
        }
        protected override void ExportToRTF() {
            ExportTo("rtf", "RTF document (*.rtf)|*.rtf");
        }
        protected override void ExportToDOCX() {
            ExportTo("docx", "DOCX document (*.docx)|*.docx");
        }
        protected override void ExportToText() {
            ExportTo("txt", "Text document (*.txt)|*.txt");
        }
        protected override void PrintPreview() {
            if(this.ExportControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.ExportControl.ShowRibbonPrintPreview();
                else this.ExportControl.ShowPrintPreview();
            }
        }
        #endregion
    }
    #region MenuManager
    public class VGridRibbonMenuManager : RibbonMenuManager {
        VGridControlBase currentVGrid = null;
        BarSubItem bsiViewOptions;
        public VGridRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon);
        }
        void CreateOptionsMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = "Options";
            bsiViewOptions = new BarSubItem();
            bsiViewOptions.Caption = "View\n Options";
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View");
            ribbonControl.Items.Add(bsiViewOptions);
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions);
        }
        public void RefreshOptionsMenu(VGridControlBase vGrid) {
            currentVGrid = vGrid;
            ShowReservGroup1(vGrid != null);
            LookAndFeelMenu.ClearOptionItems(Manager);
            LookAndFeelMenu.AddOptionsMenu(bsiViewOptions, ViewOptions, new ItemClickEventHandler(miViewOptions_Click), Manager);
        }
        object ViewOptions {
            get {
                if(currentVGrid == null) return null;
                return currentVGrid.OptionsView;
            }
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem item = e.Item as OptionBarItem;
            if(currentVGrid != null && item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(item.Caption, ViewOptions, item.Checked);
                LookAndFeelMenu.InitOptionsMenu(bsiViewOptions, ViewOptions);
            }
        }
    }
    #endregion MenuManager
    public static class LicenseInfo {
        public static void SetToolTipController(TutorialControl module, VGridControl grid) {
            grid.ToolTipController = module.LicenseToolTipController;
            module.LicenseToolTipController.OnLicenseChanged += (s, e) =>
                e.Info = GetLicenseInfo(e.Row);
            module.LicenseToolTipController.UpdateMaskOptions(grid);
        }
        static string GetLicenseInfo(object obj) {
            var item = obj as VehiclesData.OrderItem;
            if(item != null)
                return item.Model.LicenseInfo;
            return null;
        }
    }
}
