using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace XtraReportsDemos.PollingReport {
    public class PreviewControl : ReportModule {
        bool showResults = false;
        int pollCount = 3;
        readonly IList<ResultingData> data = new List<ResultingData>();

        protected override XtraReport CreateReport() {
            if(showResults) {
                ResultingReport resultingReport = new XtraReportsDemos.PollingReport.ResultingReport();
                resultingReport.PollingLink.PreviewClick += Link_PreviewClick;
                resultingReport.ResultingReportDS.DataSource = data;
                resultingReport.Parameters["paramPollCount"].Value = ++pollCount;
                return resultingReport;
            }
            else {
                PollingReport pollingReport = new XtraReportsDemos.PollingReport.PollingReport();
                pollingReport.ResultingLink.PreviewClick += Link_PreviewClick;
                return pollingReport;
            }
        }
        void Link_PreviewClick(object sender, PreviewMouseEventArgs e) {
            showResults = !showResults;
            if(Report is PollingReport)
                ((PollingReport)Report).UpdateData(data);
            DisposeReport();
            Activate();
        }
    }
}

