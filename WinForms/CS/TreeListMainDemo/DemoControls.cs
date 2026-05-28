using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;

namespace DevExpress.XtraTreeList.Demos {
    public class TutorialControl : TutorialControlBase {
        private DevExpress.Utils.Frames.NotePanel fDescription = null;
        public TutorialControl() { }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DevExpress.Utils.Frames.NotePanel Description {
            get { return fDescription; }
            set {
                fDescription = value;
                OnSetDescription("");
            }
        }
        protected override string CodeInfoFolder { get { return "DevExpress.XtraTreeList.Demos.CodeInfo"; } }
        protected virtual void OnSetDescription(string fDescription) {
            if(fDescription == string.Empty)
                return;
            Description.Text = string.Format(fDescription);
        }
        public TreeListRibbonMenuManager TreeListRibbonMenuManager {
            get { return RibbonMenuManager as TreeListRibbonMenuManager; }
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, ExportFormats.PDF | ExportFormats.HTML | ExportFormats.MHT | ExportFormats.XLS |
                ExportFormats.RTF | ExportFormats.DOCX | ExportFormats.Text | ExportFormats.XLSX, false);
        }
        public override bool AllowPrintOptions {
            get { return false; }
        }
        protected virtual void CreateBarSubItemOptions() { }
        public virtual TreeList MainControl {
            get { return null; }
        }
        protected virtual object Options {
            get { return null; }
        }
        protected virtual string OptionsName {
            get { return string.Empty; }
        }
        public virtual bool InitCustomBarItemOptions(BarSubItem barItemOptions, TreeListRibbonMenuManager manager) {
            if(Options == null || MainControl == null)
                return false;
            barItemOptions.Caption = OptionsName;
            LookAndFeelMenu.AddOptionsMenu(barItemOptions, Options, new ItemClickEventHandler(miViewOptions_Click), manager.Manager);
            return true;
        }
        void miViewOptions_Click(object sender, ItemClickEventArgs e) {
            OptionBarItem _item = e.Item as OptionBarItem;
            if(_item != null) {
                DevExpress.Utils.SetOptions.SetOptionValueByString(_item.Caption, Options, _item.Checked);
                _item.Checked = DevExpress.Utils.SetOptions.OptionValueByString(_item.Tag.ToString(), Options);
            }
        }
        protected override void OnUseEmptyRootPadding() {
            if(MainControl != null)
                MainControl.BorderStyle = XtraEditors.Controls.BorderStyles.NoBorder;
        }
        protected override void DoHide() {
            foreach(Control ctrl in this.Controls)
                if(ctrl is TreeList)
                    ((TreeList)ctrl).DestroyCustomization();
        }
        protected override void SetControlManager(Control ctrl, BarManager manager) {
            DevExpress.XtraTreeList.TreeList _treeList = ctrl as DevExpress.XtraTreeList.TreeList;
            if(_treeList != null) 
                _treeList.MenuManager = manager;
            ScrollBarBase scrollBar = ctrl as ScrollBarBase;
            if(scrollBar != null && FluentScrollBars)
                ScrollBarBase.ApplyUIMode(scrollBar, ScrollUIMode.Fluent);
        }
        protected virtual bool FluentScrollBars {
            get { return false; }
        }
        #region Print and Export
        protected override void ExportToCore(String filename, string ext) {
            if(MainControl == null)
                return;
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if(ext == "rtf")
                MainControl.ExportToRtf(filename);
            if(ext == "docx")
                MainControl.ExportToDocx(filename);
            if(ext == "pdf")
                MainControl.ExportToPdf(filename);
            if(ext == "mht")
                MainControl.ExportToMht(filename, new MhtExportOptions());
            if(ext == "html")
                MainControl.ExportToHtml(filename);
            if(ext == "txt")
                MainControl.ExportToText(filename);
            if(ext == "xls")
                MainControl.ExportToXls(filename);
            if(ext == "xlsx")
                MainControl.ExportToXlsx(filename);
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
            if(this.MainControl != null) {
                if(RibbonMenuManager.PrintOptions.ShowRibbonPreviewForm)
                    this.MainControl.ShowRibbonPrintPreview();
                else
                    this.MainControl.ShowPrintPreview();
            }
        }
        #endregion
    }
    public class TreeListRibbonMenuManager : RibbonMenuManager {
        BarSubItem bsiViewOptions;
        public TreeListRibbonMenuManager(RibbonMainForm form)
            : base(form) {
            CreateOptionsMenu(form.ReservGroup1, form.Ribbon);
        }
        void CreateOptionsMenu(RibbonPageGroup ribbonPageGroup, RibbonControl ribbonControl) {
            ribbonPageGroup.Text = "Options";
            bsiViewOptions = new BarSubItem();
            MainFormHelper.SetBarButtonImage(bsiViewOptions, "View");
            ribbonControl.Items.Add(bsiViewOptions);
            ribbonPageGroup.ItemLinks.Add(bsiViewOptions);
        }
        public void RefreshOptionsMenu(TutorialControl tutorialControl) {
            LookAndFeelMenu.ClearOptionItems(Manager);
            if(tutorialControl != null && tutorialControl.InitCustomBarItemOptions(bsiViewOptions, this))
                ShowReservGroup1(true);
            else
                ShowReservGroup1(false);
        }
    }
    public class DemosHelper {
        public static void ShowDescriptionForm(System.Drawing.Point location, System.Drawing.Size size, string description, string caption) {
            XtraForm frm = new XtraForm() { FormBorderStyle = FormBorderStyle.FixedToolWindow, ShowInTaskbar = false, StartPosition = FormStartPosition.Manual, Text = caption, Size = size };
            MemoEdit tb = new MemoEdit() { Dock = DockStyle.Fill, ReadOnly = true, Text = description };
            frm.Controls.Add(tb);
            frm.Location = DevExpress.Utils.ControlUtils.CalcLocation(location, location, frm.Size);
            frm.Shown += (sender, e) => { tb.DeselectAll(); };
            frm.ShowDialog();
        }
    }
    public static class LicenseInfo {
        public static void SetToolTipController(TutorialControl module, TreeList treeList) {
            treeList.ToolTipController = module.LicenseToolTipController;
            module.LicenseToolTipController.OnLicenseChanged += (s, e) =>
                e.Info = GetLicenseInfo(e.Row);
            module.LicenseToolTipController.UpdateMaskOptions(treeList);
        }
        static string GetLicenseInfo(object obj) {
            var item = obj as VehiclesData.TrademarkBody;
            if(item != null)
                return item.Model.LicenseInfo;
            return null;
        }
    }
}
