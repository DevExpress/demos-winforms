using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.View;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModel {
    public class AppointmentViewModel : IDocumentContent, IDisposable {
        UnitOfWork sessionCore;
        public AppointmentViewModel() {
            ButtonText = DentalClinicStringId.Create;
            AppointmentHeader = string.Format(DentalClinicStringId.AppointmentEdit, AppointmentId);
            InvoiceText = "Create Invoice";
            Session.ObjectChanged += OnSessionObjectChanged;
            TimeIndex = -1;
        }
        public void Dispose() {
            if(sessionCore != null) {
                sessionCore.ObjectChanged -= OnSessionObjectChanged;
                sessionCore.Dispose();
            }
        }
        void OnSessionObjectChanged(object sender, ObjectChangeEventArgs e) {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        public virtual TimeSpan Duration { get; set; }
        public virtual int PatientId { get; set; }
        public virtual int AppointmentId { get; set; }
        public virtual object ResourceId { get; set; }
        public virtual PatientInfo PatientInfo { get; set; }
        public virtual DoctorInfo DoctorInfo { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual List<PatientInfo> Patients { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual List<DoctorInfo> Doctors { get; set; }
        public virtual XPCollection<ProcedureItem> Procedures { get; set; }
        public virtual DateTime? Date { get; set; }
        public virtual DateTimeRange? InitialDateTimeRange { get; set; }
        public virtual object TimeValue { get; set; }

        public virtual int TimeIndex { get; set; }
        public virtual string ButtonText { get; set; }
        public virtual string InvoiceText { get; set; }
        public virtual string AppointmentHeader { get; set; }
        public virtual bool LockChangePatient { get; set; }
        public virtual bool ShouldCreateNewPatient { get; set; }
        public virtual string NewPatientFirstName { get; set; }
        public virtual string NewPatientLastName { get; set; }
        public virtual string NewPatientPhone { get; set; }
        protected int ConsultationProcedureId { get; set; }
        public virtual List<DateTime> FreeDays { get; set; }
        public virtual IEnumerable<DateTimeRange> FreeTimes { get; set; }
        public virtual List<IGrouping<DateTime, DateTimeRange>> Dates { get; set; }
        public void DisableDay() { }
        protected void OnDateChanged() {
            FreeTimes = null;
            LoadFreeDays();
        }
        bool shouldRemoveInitDateTimeRange;
        public void LoadFreeDays() {
            if(FreeDateTimeService == null) return;
            if(shouldRemoveInitDateTimeRange && InitialDateTimeRange != null && Dates != null && InitialDateTimeRange.Value.Start != Date) {
                Dates = Dates.SelectMany(x => x).Where(x => x != InitialDateTimeRange).OrderBy(x => x.Start).GroupBy(x => x.Start.Date).ToList();
                FreeDateTimeService.Dates = Dates;
                FreeDateTimeService.FreeDays = new HashSet<DateTime>(Dates.Select(x => x.Key.Date));
                FreeDateTimeService.LastAppointmentDay = FreeDateTimeService.FreeDays.LastOrDefault();
                shouldRemoveInitDateTimeRange = false;
            }
            if(Date.HasValue && Appointment != null && Appointment.Doctor != null && Dates == null) {
                var freeIntervals = ScheduleHelper.GetFreeIntervals(Session, Appointment.Doctor.Oid, Appointment.Duration);
                var currentDateTimeRange = Appointment.Oid > 0 ? new DateTimeRange(Appointment.Date, Appointment.Duration) : (DateTimeRange?)null;
                if(InitialDateTimeRange == null && currentDateTimeRange != null && !freeIntervals.Contains(currentDateTimeRange.Value)) {
                    InitialDateTimeRange = currentDateTimeRange;
                    freeIntervals = freeIntervals.Union(new[] { currentDateTimeRange.Value }).OrderBy(x => x.Start).ToList();
                    shouldRemoveInitDateTimeRange = true;
                }
                Dates = freeIntervals.GroupBy(x => x.Start.Date).ToList();
                FreeDateTimeService.FreeDays = new HashSet<DateTime>(Dates.Select(x => x.Key.Date));
                FreeDateTimeService.LastAppointmentDay = FreeDateTimeService.FreeDays.LastOrDefault();
            }
            if(Duration.TotalMinutes <= 0) return;
            if(Dates != null) {
                FreeDateTimeService.Dates = Dates;
                FreeTimes = Dates.FirstOrDefault(x => x.Key.Date == Date.Value.Date);
                var lastapp = Dates.LastOrDefault();
                if(FreeTimes == null && lastapp != null && Date.Value.Date > lastapp.Key.Date) {
                    FreeTimes = ScheduleHelper.GetEmptyIntervals(Date.GetValueOrDefault(), Duration);
                }
                var currentDate = Appointment.Oid > 0 ? new DateTimeRange[] { new DateTimeRange(Appointment.Date, Appointment.Duration) } : null;
                if(FreeTimes != null && currentDate != null)
                    FreeTimes = FreeTimes.Union(currentDate);
                if(FreeTimes == null && currentDate != null)
                    FreeTimes = currentDate;
                if(FreeTimes != null)
                    FreeDateTimeService.FreeTimes = new HashSet<DateTimeRange>(FreeTimes);
            }
        }
        protected void OnDoctorInfoChanged() {
            if(DoctorInfo == null) return;
            Doctor = Session.GetObjectByKey<Doctor>(DoctorInfo.DoctorId);
            OnDateChanged();
        }
        protected void OnDoctorChanged() {
            Appointment.Doctor = Doctor;
            if(Doctor != null)
                DoctorInfo = Doctors.FirstOrDefault(x => x.DoctorId == Doctor.Oid);
            else
                DoctorInfo = null;
            Dates = null;
            FreeTimes = null;
        }
        protected void OnPatientInfoChanged() {
            if(PatientInfo == null) return;
            Patient = Session.GetObjectByKey<Patient>(PatientInfo.PatientId);
        }
        protected void OnPatientChanged() {
            if(Patient != null && Patient.UnassignedProcedureCollection != Procedures && Appointment.Oid < 0)
                SetProcedures(Patient.UnassignedProcedureCollection);
            Appointment.Patient = Patient;
            if(Patient != null)
                PatientInfo = Patients.FirstOrDefault(x => x.PatientId == Patient.Oid);
            else
                PatientInfo = null;
            bool haveInvoice = Patient?.InvoiceCollection?.Any(q => q.Appointment?.Oid == AppointmentId) ?? false;
            InvoiceText = haveInvoice ? "Edit Invoice" : "Create Invoice";
        }
        protected void OnNewPatientFirstNameChanged() {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        protected void OnNewPatientLastNameChanged() {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        protected void OnNewPatientPhoneChanged() {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        void SetProcedures(XPCollection<ProcedureItem> procedures) {
            if(Procedures != null)
                Procedures.ListChanged -= OnProceduresListChanged;
            Procedures = procedures;
            Procedures.ListChanged += OnProceduresListChanged;
            OnProceduresListChanged(this, null);
        }
        protected void OnPatientIdChanged() {
            if(Appointment == null)
                Appointment = new Appointment(Session);
            LoadPatientsAndDoctors();
            Patient = Session.GetObjectByKey<Patient>(PatientId);
            Appointment.Patient = Patient;
            Appointment.Date = DateTime.Now;
            Appointment.AllDayEvent = false;
            if(Doctor == null && ResourceId != null)
                Doctor = Session.GetObjectByKey<Doctor>(ResourceId);
            SetProcedures(Patient.UnassignedProcedureCollection);
        }
        protected void OnShouldCreateNewPatientChanged() {
            if(ShouldCreateNewPatient) {
                SetProcedures(Appointment.ProcedureCollection);
                var procedureItem = new ProcedureItem(Session);
                procedureItem.Procedure = Session.GetObjectByKey<Procedure>(ConsultationProcedureId);
                Procedures.Add(procedureItem);
            }
            else {
                var consultationProcedureItem = Procedures.FirstOrDefault(x => x.Procedure.Oid == ConsultationProcedureId);
                Procedures.Remove(consultationProcedureItem);
                if(Patient != null)
                    SetProcedures(Patient.UnassignedProcedureCollection);
            }
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        public virtual IEnumerable<ProcedureItem> Selection { get; set; }
        public virtual bool CanCreateInvoice() {
            return Appointment.Oid != -1;
        }
        public void CreateInvoice() {
            var viewModel = ViewModelSource.Create<InvoiceViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.AppointmentId = Appointment.Oid;
            viewModel.PatientId = Patient.Oid;
            if(Patient.InvoiceCollection != null) {
                Invoice invoice = null;
                foreach(Invoice item in Patient.InvoiceCollection) {
                    if(item?.Appointment.Oid == Appointment.Oid) {
                        invoice = item;
                        break;
                    }
                }
                if(invoice != null)
                    viewModel.SetInvoice(invoice.Oid);
            }
            DocumentManagerService.CreateDocument(nameof(InvoiceView), viewModel).Show();
            (this as IDocumentContent).DocumentOwner.Close(this);
        }
        protected void OnAppointmentIdChanged() {
            Appointment = Session.GetObjectByKey<Appointment>(AppointmentId);
            ButtonText = DentalClinicStringId.Save;
            AppointmentHeader = string.Format(DentalClinicStringId.AppointmentEdit, AppointmentId);
            if(Appointment == null) {
                Appointment = new Appointment(Session);
                Appointment.Date = Date.GetValueOrDefault(DateTime.Now);
                Appointment.AllDayEvent = false;
                ButtonText = DentalClinicStringId.Create;
                AppointmentHeader = DentalClinicStringId.AppointmentNew;
            }
            else
                LockChangePatient = true;
            LoadPatientsAndDoctors();
            Patient = Appointment.Patient;
            Doctor = Appointment.Doctor;
            if(Doctor == null && ResourceId != null)
                Doctor = Session.GetObjectByKey<Doctor>(ResourceId);
            var procedures = new XPCollection<Procedure>(Session);
            var consultationProcedure = procedures.FirstOrDefault(x => x.Name.StartsWith("Consultation"));
            ConsultationProcedureId = consultationProcedure.Oid;
            SetProcedures(Appointment.ProcedureCollection);
        }
        void LoadPatientsAndDoctors() {
            using(var session = SessionProvider.CreateSession()) {
                var patients = session.Query<Patient>()
                    .Select(x => new PatientInfo()
                    {
                        PatientId = x.Oid,
                        Name = x.FirstName + " " + x.LastName,
                        Phone = x.Phone,
                    }).ToList();
                Patients = patients;
                var doctors = session.Query<Doctor>()
                    .Select(x => new DoctorInfo
                    {
                        DoctorId = x.Oid,
                        Name = x.FirstName + " " + x.LastName
                    }).ToList();
                Doctors = doctors;
            }
        }
        void OnProceduresListChanged(object sender, ListChangedEventArgs e) {
            Duration = new TimeSpan(Procedures.Where(x => x.Checked).Sum(x => x.Procedure.Duration.Ticks));
            if(Appointment.Duration.TotalMinutes != Duration.TotalMinutes)
                Appointment.Duration = Duration;
            this.RaiseCanExecuteChanged(x => x.Save());
            Dates = null;
            FreeTimes = null;
            LoadFreeDays();
        }
        public bool CanSave() {
            if(Patient == null && !ShouldCreateNewPatient) return false;
            if(Session.GetObjectsToSave().Count == 0)
                return false;
            if(ShouldCreateNewPatient && (string.IsNullOrEmpty(NewPatientFirstName) || string.IsNullOrEmpty(NewPatientLastName) || string.IsNullOrEmpty(NewPatientPhone))) {
                return false;
            }
            if(TimeIndex < 0 && TimeValue == null) return false;
            return Procedures.Where(x => x.Checked).Any();
        }
        protected virtual void OnTimeIndexChanged() {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        public void Save() {
            if(ShouldCreateNewPatient) {
                var patient = new Patient(Session);
                patient.FirstName = NewPatientFirstName;
                patient.LastName = NewPatientLastName;
                patient.Phone = NewPatientPhone;
                var consultationProcedure = Procedures.FirstOrDefault(x => x.Procedure.Oid == ConsultationProcedureId);
                patient.ProcedureCollection.Add(consultationProcedure);
                consultationProcedure.Patient = patient;
                Appointment.Patient = patient;
            }
            var procedures = Procedures.Where(x => x.Checked).ToList();
            while(Appointment.ProcedureCollection.Count > 0) {
                Appointment.ProcedureCollection.Remove(Appointment.ProcedureCollection[0]);
            }
            Appointment.ProcedureCollection.AddRange(procedures);
            Session.CommitChanges();
            Messenger.Default.Send(ReloadDataMessage.AllData);
        }
        public void ClearChanges() {
            Session.DropChanges();
        }
        void IDocumentContent.OnClose(CancelEventArgs e) {
            if(Session.GetObjectsToSave().Count == 0)
                return;
            if(!CanSave()) {
                var dialogResult = MessageBoxService.ShowMessage(DentalClinicStringId.CloseMessage, "", MessageButton.YesNo);
                if(dialogResult == MessageResult.Yes)
                    ClearChanges();
                else
                    e.Cancel = true;
                return;
            }
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNoCancel);
            if(result == MessageResult.Yes)
                Save();
            if(result == MessageResult.No)
                ClearChanges();
            if(result == MessageResult.Cancel)
                e.Cancel = true;
        }
        void IDocumentContent.OnDestroy() {
            if(Session.GetObjectsToSave().Count == 0)
                return;
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNo);
            if(result == MessageResult.Yes)
                Save();
            if(result == MessageResult.No)
                ClearChanges();
        }
        IDocumentOwner IDocumentContent.DocumentOwner { get; set; }
        object IDocumentContent.Title => string.Empty;
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
        IMessageBoxService MessageBoxService { get { return this.GetService<IMessageBoxService>(); } }
        IDocumentManagerService DocumentManagerService { get { return this.GetService<IDocumentManagerService>("Flyout"); } }
        IFreeDateTimeService FreeDateTimeService { get { return this.GetService<IFreeDateTimeService>(); } }

    }
    public class DoctorInfo {
        public Guid DoctorId { get; set; }
        public string Name { get; set; }
    }
}
