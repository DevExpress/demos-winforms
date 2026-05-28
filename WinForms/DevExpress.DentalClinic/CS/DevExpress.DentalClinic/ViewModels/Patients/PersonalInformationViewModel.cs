namespace DevExpress.DentalClinic.ViewModel {
    using System;
    using System.IO;
    using DevExpress.DentalClinic.Model;
    using DevExpress.DentalClinic.Services;
    using DevExpress.DentalClinic.View;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using DevExpress.Xpo;

    public class PersonalInformationViewModel : ISupportParameter, IEditViewModel, IDisposable {
        readonly UnitOfWork Session;
        public PersonalInformationViewModel() {
            Session = SessionProvider.CreateSession();
            Session.ObjectChanged += OnSessionObjectChanged;
        }
        public void Dispose() {
            if(Session != null) {
                Session.ObjectChanged -= OnSessionObjectChanged;
                Session.Dispose();
            }
        }
        void OnSessionObjectChanged(object sender, ObjectChangeEventArgs e) {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        object ISupportParameter.Parameter {
            get { return PatientId; }
            set { PatientId = (int)value; }
        }
        public virtual int PatientId {
            get;
            protected set;
        }
        public virtual Patient Patient {
            get;
            protected set;
        }
        public bool IsNew {
            get { return PatientId == -1; }
        }
        protected virtual void OnPatientIdChanged() {
            if(IsNew)
                Patient = new Patient(Session);
            else
                Patient = Session.GetObjectByKey<Patient>(PatientId);
        }
        protected bool HasObjectsToSave {
            get { return Session.GetObjectsToSave().Count > 0; }
        }
        protected bool HasValidationErrors {
            get { return IDataErrorInfoHelper.HasErrors(Patient); }
        }
        public bool CanSave() {
            return HasObjectsToSave && !HasValidationErrors;
        }
        public void Save() {
            Session.CommitChanges();
            if(IsNew) {
                PatientId = Patient.Oid;
                var viewModel = this.GetParentViewModel<PatientViewModel>();
                viewModel.PatientId = PatientId;
                viewModel.ShowAdditionalViews();
            }
            Messenger.Default.Send(ReloadDataMessage.AllData);
        }
        public void CreateInvoice() {
            var viewModel = ViewModelSource.Create<InvoiceViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.PatientId = Patient.Oid;
            DocumentManagerService.CreateDocument(nameof(InvoiceView), viewModel).Show();
        }
        public void CreateAppointment() {
            var viewModel = ViewModelSource.Create<AppointmentViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.PatientId = Patient.Oid;
            DocumentManagerService.CreateDocument(nameof(AppointmentView), viewModel).Show();
        }
        public virtual bool CanAddComplaint() {
            return PatientId > 0;
        }
        bool IEditViewModel.CanNavigateFrom() {
            if(!HasObjectsToSave)
                return true;
            if(HasValidationErrors) {
                if(MessageBoxService.ShowMessage(DentalClinicStringId.ChangesNotCompletedMessage, nameof(Patient), MessageButton.YesNo) == MessageResult.No) 
                    return false;
                Session.DropChanges();
                return true;
            }
            var saveResult = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, nameof(Patient), MessageButton.YesNoCancel);
            if(saveResult == MessageResult.Cancel)
                return false;
            if(saveResult == MessageResult.Yes)
                Save();
            else
                Session.DropChanges();
            return true;
        }
        public void LoadDocument() {
            if(OpenFileDialogService.ShowDialog()) {
                var fileName = OpenFileDialogService.GetFullFileName();
                Document document = new Document(Session);
                using(FileStream stream = new FileStream(fileName, FileMode.Open))
                    document.LoadFromStream(Path.GetFileName(fileName), stream);
                document.Date = DateTime.Now;
                Patient.DocumentCollection.Add(document);
                Session.CommitChanges();
            }
        }
        public void EditAppointment(int appointmentID) {
            var viewModel = ViewModelSource.Create<AppointmentViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.AppointmentId = appointmentID;
            viewModel.LockChangePatient = true;
            DocumentManagerService.CreateDocument(nameof(AppointmentView), viewModel).Show();
        }
        public void OpenDocument(Document document) {
            string documentFilePath = Path.Combine(Path.GetTempPath(), document.Name);
            try {
                using(var fs = File.Create(documentFilePath))
                    document.SaveToStream(fs);
                Data.Utils.SafeProcess.Start(documentFilePath);
            }
            catch { }
        }
        public void RemoveDocument(Document document) {
            Patient.DocumentCollection.Remove(document);
            Session.CommitChanges();
        }
        public bool CanPrintPlan() {
            return PatientId > 0;
        }
        public void PrintPlan() {
            PrintReportService.PrintPlan(PatientId);
        }
        IOpenFileDialogService OpenFileDialogService {
            get { return this.GetService<IOpenFileDialogService>(); }
        }
        IDialogService DialogService {
            get { return this.GetService<IDialogService>(); }
        }
        IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("Flyout"); }
        }
        ISecuredObjectSpaceService SessionProvider {
            get { return this.GetService<ISecuredObjectSpaceService>(); }
        }
        IMessageBoxService MessageBoxService {
            get { return this.GetService<IMessageBoxService>(); }
        }
        IPrintReportService PrintReportService {
            get { return this.GetService<IPrintReportService>(); }
        }
    }
}
