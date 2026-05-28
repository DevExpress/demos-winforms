using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos {
    public partial class SchedulerPrint : XtraUserControl {
        XtraReport report;

        public SchedulerPrint() {
            InitializeComponent();
            this.printSettingsControl.SelectedPrinterName = PageSettingsHelper.DefaultPageSettings.PrinterSettings.PrinterName;
        }

        protected override void OnVisibleChanged(EventArgs e) {
            base.OnVisibleChanged(e);
            if (!Visible) {
                this.controlPrintAdapter1.SchedulerControl = null;
                this.reportPreviewControl1.Visible = false;
                return;
            }
            if (this.controlPrintAdapter1.SchedulerControl == DemosInfo.CurrentScheduler)
                return;
            this.controlPrintAdapter1.SchedulerControl = DemosInfo.CurrentScheduler;
            UpdateReport(ReportType.DailyStyle);
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            this.printSettingsControl.SetSettings(new PrintStylesControl(UpdateReport, ReportType.DailyStyle));
        }

        void UpdateReport(ReportType reportType) {
            if (this.report != null) {
                this.reportPreviewControl1.DocumentSource = null;
                this.report.PrintingSystem.AfterBuildPages -= OnPrintingSystemAfterBuildPages;
                this.report.Dispose();
            }

            XtraSchedulerReport newReport = SchedulerReportFactory.Create(reportType);
            newReport.SchedulerAdapter = this.controlPrintAdapter1;
            newReport.SchedulerAdapter.EnableSmartSync = reportType == ReportType.TriFoldStyle;
            newReport.PrintColorSchema = DemoUtils.ReportPrintColorSchema;
            this.report = newReport;
            this.reportPreviewControl1.DocumentSource = newReport;
            newReport.PrintingSystem.ClearContent();
            newReport.CreateDocument(true);
            newReport.PrintingSystem.AfterBuildPages -= OnPrintingSystemAfterBuildPages;
            newReport.PrintingSystem.AfterBuildPages += OnPrintingSystemAfterBuildPages;
        }

        void OnPrintingSystemAfterBuildPages(object sender, EventArgs e) {
            if (this.printSettingsControl.IsHandleCreated)
                this.printSettingsControl.BeginInvoke(new Action<bool>(OnPrintingSystemAfterBuildPagesInUIThread), ((PrintingSystemBase)sender).PageCount > 0);
        }

        void OnPrintingSystemAfterBuildPagesInUIThread(bool isEnabled) {
            this.printSettingsControl.PrintEnabled = isEnabled;
            this.reportPreviewControl1.Visible = true;
        }

        void OnSettingsControlPrintClick(object sender, EventArgs e) {
            using (ReportPrintTool tool = new ReportPrintTool(this.report)) {
                tool.Print(this.printSettingsControl.SelectedPrinterName);
            }
        }

        void OnSettingsControlPrintOptionsClick(object sender, EventArgs e) {
            using (ReportPrintTool tool = new ReportPrintTool(this.report)) {
                tool.PrintDialog(FindForm(), LookAndFeel);
            }
        }
    }

    public static class SchedulerReportFactory {
        static SchedulerReportFactory() {
            DirectoryInfo directoryInfo = new DirectoryInfo(DemoUtils.GetFolderRelativePath("SchedulerReportTemplates"));
            ReportPathDictionary = new Dictionary<ReportType, string>();
            FileInfo[] reportTemplates = directoryInfo.GetFiles("*.schrepx");
            RegisterReport("DailyStyleFitToPage", ReportType.DailyStyle, reportTemplates);
            RegisterReport("WeeklyStyle", ReportType.WeeklyAgendaStyle, reportTemplates);
            RegisterReport("TrifoldStandard", ReportType.TriFoldStyle, reportTemplates);
            //RegisterReport("", ReportType.CalendarDetailsStyle, reportTemplates);
            RegisterReport("MonthlyStyle", ReportType.MonthlyCalendarStyle, reportTemplates);
            RegisterReport("DailyStyleFitToPage", ReportType.WeeklyCalendarStyle, reportTemplates);
        }

        static Dictionary<ReportType, string> ReportPathDictionary { get; set; }

        public static XtraSchedulerReport Create(ReportType type) {
            string reportPath = String.Empty;
            if (!ReportPathDictionary.TryGetValue(type, out reportPath))
                return null;
            XtraSchedulerReport report = new XtraSchedulerReport();
            report.LoadLayout(reportPath);
            return report;
        }

        static void RegisterReport(string name, ReportType reportType, IEnumerable<FileInfo> fileInfos) {
            FileInfo fileInfo = fileInfos.FirstOrDefault(x => Path.GetFileNameWithoutExtension(x.Name) == name);
            if (fileInfo == null)
                return;
            ReportPathDictionary.Add(reportType, fileInfo.FullName);
        }
    }
}
