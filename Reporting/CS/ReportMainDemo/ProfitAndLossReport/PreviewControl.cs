namespace XtraReportsDemos.ProfitAndLossReport {
    public class PreviewControl : ReportModule {
        protected override void OnSetViewer() {
            Viewer.SetPageView(DevExpress.XtraPrinting.PageViewModes.PageWidth);
        }
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new Report();
        }
    }
}

