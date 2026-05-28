using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DataAccess.Sql;
using DevExpress.DataAccess.Wizard.Services;
using DevExpress.Utils;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;

namespace DevExpress.DentalClinic.Services {
    public interface IPrintReportService {
        void PrintInvoice(object invoiceId);
        void PrintPlan(object patientId);
    }
    public class PrintReportService : IPrintReportService, IConnectionProviderService {
        void IPrintReportService.PrintInvoice(object invoiceId) {
            using(var invoice = new InvoiceReport()) {
                invoice.PrintingSystem.AddService(typeof(IConnectionProviderService), this);
                invoice.Parameters["invoiceId"].Value = invoiceId;
                using(var tool = new ReportPrintTool(invoice))
                    tool.ShowRibbonPreviewDialog();
            }
        }
        void IPrintReportService.PrintPlan(object patientId) {
            using(var report = new TreatmentPlanReport()) {
                report.PrintingSystem.AddService(typeof(IConnectionProviderService), this);
                report.Parameters["patientID"].Value = patientId;
                using(ReportPrintTool tool = new ReportPrintTool(report))
                    tool.ShowRibbonPreviewDialog();
            }
        }
        SqlDataConnection IConnectionProviderService.LoadConnection(string connectionName) {
            var dbPath = DBPathHelper.EnsureWriteable(Application.StartupPath, "DentalCabinet.db");
            return new SqlDataConnection("dental", new SQLiteConnectionParameters(dbPath, string.Empty));
        }
    }
}
