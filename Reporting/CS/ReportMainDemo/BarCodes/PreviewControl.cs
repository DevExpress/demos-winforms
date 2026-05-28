using DevExpress.XtraReports.UI;


namespace XtraReportsDemos.BarCodes {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            return new BarCodeTypesReport();
        }
    }
}

