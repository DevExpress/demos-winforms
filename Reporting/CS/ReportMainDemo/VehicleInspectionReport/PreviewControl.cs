using DevExpress.XtraPrinting.Preview;

namespace XtraReportsDemos.VehicleInspectionReport {
    class PreviewControl : ReportModule {
        static PreviewControl() {
            EditingFieldExtensionsWin.Instance.RegisterImageEditor("DamageDiagram", "Damage Diagram",
                new ImageEditorOptions() { AllowLoadImage = false, AllowChangeSizeOptions = false, AllowDraw = true, AllowClear = false });
        }
        protected override void OnSetViewer() {
            Viewer.SetPageView(2, 1);
        }
        protected override void OnAfterReportPrint() {
            if(Viewer != null)
                Viewer.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.HighlightEditingFields, new object[] { true });
        }
        protected override DevExpress.XtraReports.UI.XtraReport CreateReport() {
            return new Report();
        }
    }
}
