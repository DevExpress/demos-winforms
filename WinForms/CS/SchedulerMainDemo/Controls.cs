using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrinting;
using DevExpress.XtraBars.Ribbon;

namespace DevExpress.XtraScheduler.Demos {
    public class TutorialControl : TutorialControlBase, IDXMenuManager {
        private LookAndFeelMenu menu = null;
        IDXMenuManager fMenuManager;

        public TutorialControl() { }

        public virtual SchedulerControl PrintingSchedulerControl { get { return null; } }
        public override bool AutoMergeRibbon { get { return true; } set { } }

        public LookAndFeelMenu DemoMainMenu {
            get { return menu; }
            set {
                if (menu == value) return;
                this.menu = value;
            }
        }

        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos);
        }
        IDXMenuManager IDXMenuManager.Clone(Form newForm) { return this; }
        void IDXMenuManager.DisposeManager() { }

        public IDXMenuManager MenuManager {
            get { return fMenuManager; }
            set { fMenuManager = value; }
        }

        public virtual bool ShowOptions { get { return false; } } //TODO

        protected override void SetControlManager(Control ctrl, DevExpress.XtraBars.BarManager manager) {
            DevExpress.XtraScheduler.SchedulerControl scheduler = ctrl as DevExpress.XtraScheduler.SchedulerControl;
            if (scheduler != null) scheduler.MenuManager = manager;
            DevExpress.XtraEditors.BaseEdit be = ctrl as DevExpress.XtraEditors.BaseEdit;
            if (be != null) be.MenuManager = manager;
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, true, ExportFormats.None, false);
        }
        protected override void DoShow() {
            base.DoShow();
            MergeRibbon();
        }
        void MergeRibbon() {
            if (ParentFormMain == null)
                return;
            RibbonControl parentRibbon = ParentFormMain.Ribbon;
            RibbonPage page = parentRibbon.MergedPages["File"];
            RibbonPageGroup group = ParentFormMain.ReservGroup1.Page.Groups["rpgAbout"];
            if (page != null && group != null && page.Groups.GetGroupByName("rpgAbout") == null) {
                page.Groups.Add((RibbonPageGroup)group.Clone());
            }
        }

        #region Print and Export
        protected override void ExportToCore(String filename, string ext) {
            if (PrintingSchedulerControl == null) return;
            ComponentPrinter printer = new ComponentPrinter(PrintingSchedulerControl);
            Cursor oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            if (ext == "pdf") printer.Export(ExportTarget.Pdf, filename);
            if (ext == "html") printer.Export(ExportTarget.Html, filename);
            if (ext == "mht") printer.Export(ExportTarget.Mht, filename);
            if (ext == "img") printer.Export(ExportTarget.Image, filename);
            Cursor.Current = oldCursor;
        }
        protected override void ExportToPDF() {
            ExportTo("pdf", "PDF document (*.pdf)|*.pdf");
        }
        protected override void ExportToHTML() {
            ExportTo("html", "HTML document (*.html)|*.html");
        }
        protected override void ExportToImage() {
            ExportTo("img", "BMP image (*.bmp)|*.bmp|EMF image (*.emf)|*.emf|WMF image (*.wmf)|*.wmf|GIF image (*.gif)|*.gif|JPEG image (*.jpg)|*.jpg|PNG image (*.png)|*.png|TIFF image (*.tiff)|*.tiff");
        }
        protected override void PrintPreview() {
            if (PrintingSchedulerControl != null)
                PrintingSchedulerControl.ShowPrintPreview();
        }
        protected override void Print() {
            if (PrintingSchedulerControl != null)
                PrintingSchedulerControl.Print();
        }
        #endregion
    }
}
