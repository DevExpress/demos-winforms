using DevExpress.XtraReports.Extensions;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.CustomDraw {
    public class PreviewControl : ReportModule {
        protected override XtraReport CreateReport() {
            CustomDraw.Report rep = new CustomDraw.Report();
            ReportDesignExtension.AssociateReportWithExtension(rep, XtraReportsDemos.ReportNames.CustomDraw);
            return rep;
        }
    }
}
