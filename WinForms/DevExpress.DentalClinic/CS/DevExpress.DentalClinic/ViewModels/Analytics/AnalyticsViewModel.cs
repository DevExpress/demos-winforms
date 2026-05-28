namespace DevExpress.DentalClinic.ViewModel {
    using DevExpress.DentalClinic.View;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public class AnalyticsViewModel {
        protected IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>(); }
        }
        public void Load() {
            ShowDashboardView();
            ShowProcedureHistoryView();
        }
        public void ShowDashboardView() {
            var document = DocumentManagerService.CreateDocument(nameof(DashboardView), null, this);
            document.Title = "Analytics";
            document.Show();
        }
        public void ShowProcedureHistoryView() {
            var document = DocumentManagerService.CreateDocument(nameof(ProcedureHistoryView), null, this);
            document.Title = "Invoices";
            document.Show();
        }
    }
}
