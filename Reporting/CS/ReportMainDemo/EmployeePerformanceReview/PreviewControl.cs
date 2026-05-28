using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.EmployeePerformanceReview {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new Report();
        }
        protected override void OnAfterReportPrint() {
            if(Viewer != null)
                Viewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields, new object[] { true });
        }
    }
}
