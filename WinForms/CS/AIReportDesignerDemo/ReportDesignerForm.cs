using DevExpress.Utils;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.AIIntegration.WinForms.Reporting;

namespace DevExpress.AI.ReportDesigner.Demo {
    public partial class ReportDesignerForm : RibbonForm {
        public ReportDesignerForm() {
            InitializeComponent();
#if NET
            behaviorManager1.Attach<ReportModifyBehavior>(reportDesigner1);
#endif
            Icon = LoadDefaultIcon();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            reportDesigner1.OpenReport(new XtraReportsDemos.NorthwindTraders.InvoiceReport());
        }

        Icon LoadDefaultIcon() {
            var assembly = typeof(ReportDesignerForm).Assembly;
            return ResourceImageHelper.CreateIconFromResources(assembly.GetManifestResourceNames().First(x => x.Contains("AppIcon.ico")), assembly);
        }
    }
}
