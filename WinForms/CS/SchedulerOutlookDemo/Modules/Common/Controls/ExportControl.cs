using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Serializing.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraScheduler.iCalendar;
using DevExpress.XtraScheduler.iCalendar.Components;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ExportControl : XtraUserControl {
        DXPopupMenu menuExport;
        Form mainForm;
        ExportTarget _selectedExport;

        public ExportControl(Form mainForm) : this() {
            this.mainForm = mainForm;
        }

        public ExportControl() {
            InitializeComponent();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            SelectedExport = ExportTarget.Pdf;
            this.menuExport = new DXPopupMenu();
            AddExportTarget(ExportTarget.Pdf);
            AddExportTarget(ExportTarget.Html);
            AddExportTarget(ExportTarget.Image);
            this.btnExportViaReporting.DropDownControl = this.menuExport;
            this.menuExport.BeforePopup += menuExport_BeforePopup;
            UpdateBackColor();
        }
        [DefaultValue(null)]
        public ExportTarget SelectedExport {
            get { return this._selectedExport; }
            set {
                ExportTarget newValue = value;
                if (this._selectedExport.Equals(newValue))
                    return;
                this._selectedExport = newValue;
                this.btnExportViaReporting.Text = string.Format("Export To {0}", SelectedExport);
            }
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            if (this.mainForm != null)
                this.btnExportViaReporting.MenuManager = MenuManagerHelper.FindMenuManager(this.mainForm);
        }

        void AddExportTarget(ExportTarget target) {
            DXMenuCheckItem exportItem = new DXMenuCheckItem() {
                Caption = target.ToString(),
                Tag = target
            };
            this.menuExport.Items.Add(exportItem);
            exportItem.Click += OnExportItemClick;
        }

        void OnExportItemClick(object sender, EventArgs e) {
            SelectedExport = (ExportTarget)((DXMenuItem)sender).Tag;
        }

        void menuExport_BeforePopup(object sender, EventArgs e) {
            foreach (DXMenuCheckItem item in this.menuExport.Items)
                item.Checked = object.Equals(item.Tag, SelectedExport);
        }

        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            UpdateBackColor();
        }

        void UpdateBackColor() {
            this.layoutControl1.BackColor = ColorHelper.GetControlColor(LookAndFeel);
        }

        void btnExportViaReporting_Click(object sender, EventArgs e) {
            ReportExporter exporter = ReportExporter.Create(SelectedExport, DemosInfo.CurrentScheduler);
            if (exporter == null)
                return;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = exporter.Filter;
            dialog.AddExtension = true;
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;
            exporter.Do(dialog.FileName);
        }

        void OnBtnExportViaiCalendarClick(object sender, EventArgs e) {
            iCalendarExporter exporter = new iCalendarExporter(DemosInfo.CurrentScheduler.DataStorage);
            exporter.AppointmentExporting += OnExporterAppointmentExporting;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "iCalendar files (*.ics)|*.ics";
            dialog.AddExtension = true;
            if (dialog.ShowDialog(this) != DialogResult.OK)
                return;
            exporter.Export(dialog.FileName);
            exporter.AppointmentExporting -= OnExporterAppointmentExporting;
        }

        private void OnExporterAppointmentExporting(object sender, AppointmentExportingEventArgs e) {
            iCalendarAppointmentExportingEventArgs args = e as iCalendarAppointmentExportingEventArgs;
            CustomProperty customProperty = args.VEvent.CustomProperties["X-DEVEXPRESS-CUSTOMFIELD-PRIORITY"] as CustomProperty;
            customProperty.Value = ObjectConverter.ObjectToString((int)e.Appointment.CustomFields["Priority"]);
        }
    }

    public abstract class ReportExporter {
        public static ReportExporter Create(ExportTarget target, SchedulerControl scheduler) {
            switch (target) {
                case ExportTarget.Pdf:
                    return new ReportToPdfExporter(scheduler);
                case ExportTarget.Image:
                    return new ReportToImageExporter(scheduler);
                case ExportTarget.Html:
                    return new ReportToHtmlExporter(scheduler);
            }
            return null;
        }

        public ReportExporter(SchedulerControl scheduler) {
            Scheduler = scheduler;
        }

        public SchedulerControl Scheduler { get; private set; }
        public virtual string Filter { get { return "All files(*.*)| *.* "; } }

        public void Do(string fileName) {
            XtraSchedulerReport newReport = SchedulerReportFactory.Create(ReportType.DailyStyle);
            SchedulerControlPrintAdapter controlPrintAdapter = new SchedulerControlPrintAdapter(DemosInfo.CurrentScheduler);
            newReport.SchedulerAdapter = controlPrintAdapter;
            newReport.SchedulerAdapter.EnableSmartSync = false;
            newReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema;
            newReport.PrintingSystem.ClearContent();
            newReport.CreateDocument(true);
            Export(newReport, fileName);
        }
        protected abstract void Export(XtraSchedulerReport report, string fileName);
    }

    public class ReportToPdfExporter : ReportExporter {
        public ReportToPdfExporter(SchedulerControl scheduler) : base(scheduler) {
        }

        public override string Filter { get { return "Pdf files(*.pdf)| *.pdf"; } }

        protected override void Export(XtraSchedulerReport report, string fileName) {
            report.ExportToPdf(fileName);
        }
    }

    public class ReportToHtmlExporter : ReportExporter {
        public ReportToHtmlExporter(SchedulerControl scheduler) : base(scheduler) {
        }

        public override string Filter { get { return "Html files(*.html)| *.html"; } }

        protected override void Export(XtraSchedulerReport report, string fileName) {
            report.ExportToHtml(fileName);
        }
    }

    public class ReportToImageExporter : ReportExporter {
        Dictionary<string, DXImageFormat> imageFormatResolver;

        public ReportToImageExporter(SchedulerControl scheduler) : base(scheduler) {
            this.imageFormatResolver = new Dictionary<string, DXImageFormat>();
            this.imageFormatResolver.Add(".png", DXImageFormat.Png);
            this.imageFormatResolver.Add(".jpg", DXImageFormat.Jpeg);
            this.imageFormatResolver.Add(".bmp", DXImageFormat.Bmp);
            this.imageFormatResolver.Add(".gif", DXImageFormat.Gif);
        }

        public override string Filter { get { return GetFilter(); } }

        protected override void Export(XtraSchedulerReport report, string fileName) {
            DXImageFormat imageFormat = GetImageFormatFromFileName(fileName);
            report.ExportToImage(fileName, imageFormat);
        }

        string GetFilter() {
            List<String> filterStrings = new List<String>();
            foreach (KeyValuePair<string, DXImageFormat> item in this.imageFormatResolver) 
                filterStrings.Add(String.Format("{0} (*{1}) | *{1}", item.Value.ToString().ToUpper(), item.Key));
            return String.Join("|", filterStrings);
        }

        DXImageFormat GetImageFormatFromFileName(string fileName) {
            string extension = Path.GetExtension(fileName);
            DXImageFormat result = DXImageFormat.Png;
            if (this.imageFormatResolver.TryGetValue(extension, out result))
                return result;
            return DXImageFormat.Png;
        }
    }

}
