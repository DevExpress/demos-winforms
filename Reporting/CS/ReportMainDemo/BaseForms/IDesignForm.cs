using System.Windows.Forms;
using DevExpress.XtraReports.UserDesigner;

namespace XtraReportsDemos {
    interface IDesignForm {
        Form Form { get; }
        XRDesignPanel ActiveXRDesignPanel { get; }
        void OpenReport(DevExpress.XtraReports.UI.XtraReport newReport);
    }
}
