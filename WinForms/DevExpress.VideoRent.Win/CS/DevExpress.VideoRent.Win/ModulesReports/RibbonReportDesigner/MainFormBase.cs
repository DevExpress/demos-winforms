using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraReports.UserDesigner;

namespace RibbonReportDesigner {
    public class MainFormBase : RibbonForm {
        public MainFormBase() {
            Text = "Report Designer";
#if DEBUG
            Text += $" v{AssemblyInfo.VersionShort}";
#endif
        }
        public virtual void OpenReport(DevExpress.XtraReports.UI.XtraReport newReport) {
        }
        public virtual XRDesignPanel ActiveXRDesignPanel { get { return null; } }
    }
}
