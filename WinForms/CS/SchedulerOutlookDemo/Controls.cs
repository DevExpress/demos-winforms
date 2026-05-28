using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.Utils.Menu;
using DevExpress.DXperience.Demos;      
using DevExpress.XtraPrinting;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExpress.XtraScheduler.Demos {
    public class TutorialControl : TutorialControlBase, IDXMenuManager {
        private LookAndFeelMenu menu = null;
        IDXMenuManager fMenuManager;
        HashSet<string> GlobalOptionIgnoreList { get; set; }
        public TutorialControl() {
            GlobalOptionIgnoreList = new HashSet<string>(GetGlobalOptionIgnoreList());
        }

        public virtual SchedulerControl Scheduler { get { return null; } }
        public virtual CommonRibbon CommonRibbonPanel { get { return null; } }
        [DefaultValue(true)]
        public override bool AutoMergeRibbon { get { return true; } set { } }


        protected virtual IEnumerable<string> GetGlobalOptionIgnoreList() {
            return new List<string>();
        }
        
        public virtual bool CanApplyGlobalOption(string propertyName) {
            if (GlobalOptionIgnoreList.Contains(propertyName))
                return false;
            return true;
        }
        protected virtual Control OptionsPane { get { return null; } }

        [DefaultValue(null)]
        public LookAndFeelMenu DemoMainMenu {
            get { return menu; }
            set {
                if (menu == value) return;
                this.menu = value;
            }
        }

        OutlookForm OutlookParentForm {
            get {
                return FindForm() as OutlookForm;
            }
        }

        void IDXMenuManager.ShowPopupMenu(DXPopupMenu menu, Control control, Point pos) {
            MenuManagerHelper.ShowMenu(menu, LookAndFeel, fMenuManager, control, pos);
        }
        IDXMenuManager IDXMenuManager.Clone(Form newForm) { return this; }
        void IDXMenuManager.DisposeManager() { }
        [DefaultValue(null)]
        public IDXMenuManager MenuManager {
            get { return fMenuManager; }
            set { fMenuManager = value; }
        }

        public virtual bool ShowOptions { get { return false; } } //TODO

        public virtual void ResetOptions() {
        }
        protected override void SetControlManager(Control ctrl, DevExpress.XtraBars.BarManager manager) {
            DevExpress.XtraScheduler.SchedulerControl schedulerControl = ctrl as DevExpress.XtraScheduler.SchedulerControl;
            if (schedulerControl != null) schedulerControl.MenuManager = manager;
            DevExpress.XtraEditors.BaseEdit be = ctrl as DevExpress.XtraEditors.BaseEdit;
            if (be != null) be.MenuManager = manager;
        }
        protected override void AllowExport() {
            EnabledPrintExportActions(true, true, ExportFormats.None, false);
        }
        public void SetModulesSubMenu(BarButtonItem buttonItem) {
            if (OutlookParentForm != null)
                OutlookParentForm.SetModulesPopupMenu(buttonItem);
        }

        public virtual void UpdateOptionsPaneVisibility(bool isVisible) {
            if (OptionsPane == null)
                return;
            OptionsPane.Visible = isVisible;
        }

        internal virtual void UpdateOptionsFromControl() {
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (Scheduler != null)
                Scheduler.EditAppointmentFormShowing += OnSchedulerControlEditAppointmentFormShowing;
        }

        protected override void DoShow() {
            base.DoShow();
            MergeRibbon();
        }
        void MergeRibbon() {
            if (OutlookParentForm == null)
                return;
            RibbonControl parentRibbon = OutlookParentForm.Ribbon;
            String state = parentRibbon.Tag as String;
            if (String.IsNullOrEmpty(state)) {
                parentRibbon.Tag = "initialized";
                RibbonPage page = parentRibbon.MergedPages.Union(parentRibbon.Pages).Where(x => x.Text == CommonRibbon.DefaultPageName).FirstOrDefault();
                if (page == null)
                    return;
                parentRibbon.SelectPage(page);
            }
        }

        void OnSchedulerControlEditAppointmentFormShowing(object sender, AppointmentFormEventArgs e) {
            SchedulerControl schedulerControl = ((SchedulerControl)sender);
            OutlookAppointmentForm form = new OutlookAppointmentForm(schedulerControl, e.Appointment, e.OpenRecurrenceForm);
            try {
                e.DialogResult = form.ShowDialog();
                e.Handled = true;
            } finally {
                form.Dispose();
            }
        }
        #region Print and Export
        protected override void ExportToCore(String filename, string ext) {
            if (Scheduler == null) return;
            ComponentPrinter printer = new ComponentPrinter(Scheduler);
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
            if (Scheduler != null)
                Scheduler.ShowPrintPreview();
        }
        protected override void Print() {
            if (Scheduler != null)
                Scheduler.Print();
        }        
        #endregion
    }
}
