namespace DevExpress.DentalClinic.ViewModel {
    using System.ComponentModel;
    using DevExpress.DentalClinic.Model;
    using DevExpress.DentalClinic.View;
    using DevExpress.Mvvm;
    using System.Linq;
    using DevExpress.Mvvm.POCO;
    using DevExpress.Xpo;

    public class PatientViewModel : ISupportParameter, IEditViewModel {
        public PatientViewModel() {
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        object ISupportParameter.Parameter {
            get { return PatientId; }
            set { PatientId = (int)value; }
        }
        public virtual int PatientId {
            get;
            set;
        }
        public virtual int UnassignedProcedureCount { get; set; }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        public void Load() {
            UpdateUnassignedProcedureCount();
            ShowPersonalInformation();
            if(PatientId >= 0)
                ShowAdditionalViews();
        }
        void OnReloadData(ReloadDataMessage message) {
            UpdateUnassignedProcedureCount();
        }
        public void ShowAdditionalViews() {
            ShowProcedures();
            ShowTreatmentPlan();
            ShowInvoices();
        }
        protected IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>(); }
        }
        void ShowPersonalInformation() {
            var document = DocumentManagerService.CreateDocument(nameof(PersonalInformationView), PatientId, this);
            document.Title = "Personal Information";
            document.Show();
        }
        void ShowProcedures() {
            var document = DocumentManagerService.CreateDocument(nameof(ProcedureCollectionView), PatientId, this);
            document.Title = "Procedures";
            document.Show();
        }
        void ShowTreatmentPlan() {
            var document = DocumentManagerService.CreateDocument(nameof(TreatmentPlanView), PatientId, this);
            document.Title = "Treatment Plan";
            document.Show();
        }
        void ShowInvoices() {
            var document = DocumentManagerService.CreateDocument(nameof(InvoiceCollectionView), PatientId, this);
            document.Title = "Invoices";
            document.Show();
        }
        void UpdateUnassignedProcedureCount() {
            using(var session = SessionProvider.CreateSession()) {
                var patient = session.GetObjectByKey<Patient>(PatientId);
                if(patient == null) return;
                UnassignedProcedureCount = patient.UnassignedProcedureCollection.Count;
            }
        }
        bool IEditViewModel.CanNavigateFrom() {
            var document = DocumentManagerService.Documents.FirstOrDefault(x =>x.Content is IEditViewModel);
            if(document == null) return true;
            var viewModel = document.Content as IEditViewModel;
            return viewModel.CanNavigateFrom();
        } 
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
    }
}
