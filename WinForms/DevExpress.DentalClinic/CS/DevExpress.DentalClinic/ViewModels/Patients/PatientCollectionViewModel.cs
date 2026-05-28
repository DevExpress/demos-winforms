namespace DevExpress.DentalClinic.ViewModel {
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

    public class PatientCollectionViewModel {
        public PatientCollectionViewModel() {
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        public virtual BindingList<PatientInfo> Patients {
            get;
            protected set;
        }
        public IMessageBoxService MessageBoxService {
            get { return this.GetService<IMessageBoxService>(); }
        }
        void OnReloadData(ReloadDataMessage message) {
            if(!CanLoadPatientsAsync()) return;
            LoadPatientsAsync();
        }
        public Task LoadPatientsAsync() {
            var dispatcher = this.GetService<IDispatcherService>();
            return Task.Run(() => {
                using(var session = SessionProvider.CreateSession()) {
#pragma warning disable CS9236 // Compiling requires binding the lambda expression many times.
                    return session.Query<Patient>()
                        .Select(x => new PatientInfo() {
                            PatientId = x.Oid,
                            Name = x.FirstName + " " + x.LastName,
                            Phone = x.Phone,
                            LastVisit = x.AppointmentCollection.Where(a => a.Status == AppointmentStatus.Completed).Max(a => a.Date),
                            NextVisit = x.AppointmentCollection.Where(a => a.Status == AppointmentStatus.Open && a.Date > DateTime.Now).Min(a => a.Date),
                            Status = x.InvoiceCollection.Any(a => a.PaymentStatus == PaymentStatus.Unpaid) ? 0 : 1,
                            Procedures = x.ProcedureCollection.Select(p => new PatientProcedureInfo(p.Appointment) {
                                Name = p.Procedure.Name,
                                Price = p.Procedure.Price
                            }).ToList()
                        }).ToList();
#pragma warning restore CS9236 // Compiling requires binding the lambda expression many times.
                }
            }).ContinueWith(r => {
                dispatcher.BeginInvoke(() => Patients = new BindingList<PatientInfo>(r.Result));
            });
        }
        public bool CanLoadPatientsAsync() {
            return SessionProvider != null;
        }
        public virtual PatientInfo SelectedEntity {
            get;
            set;
        }
        protected INavigationService NavigationService {
            get { return this.GetService<INavigationService>(); }
        }
        public void Edit() {
            if(SelectedEntity != null)
                NavigationService.Navigate(nameof(PatientView), SelectedEntity.PatientId);
        }
        public void New() {
            NavigationService.Navigate(nameof(PatientView), -1);
        }
        public void Remove() {
            if(SelectedEntity == null)
                return;
            var msg = $"Patient {SelectedEntity.Name} will be deleted, are you sure?";
            if(MessageBoxService.ShowMessage(msg, "Dental Clinic App", MessageButton.YesNo) != MessageResult.Yes)
                return;
            using(var session = SessionProvider.CreateSession()) {
                var patient = session.GetObjectByKey<Patient>(SelectedEntity.PatientId);
                if(patient != null) {
                    Patients.Remove(SelectedEntity);
                    session.Delete(patient);
                    session.PurgeDeletedObjects();
                    session.CommitChanges();
                }
            }
        }
        public void Call() {
            MessageBoxService.ShowMessage($"Call {SelectedEntity.Name}, {SelectedEntity.Phone}?", "Dental Clinic App", MessageButton.YesNo);
        }
        public void CreateOrEditAppointment(DateTime? appointmentDateTime) {
            if(SelectedEntity == null)
                return;
            PatientProcedureInfo info = SelectedEntity.Procedures.First(e => e.VisitTime == appointmentDateTime);
            if(info == null)
                return;
            var viewModel = ViewModelSource.Create<AppointmentViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.Date = info?.VisitTime ?? null;
            viewModel.AppointmentId = (info?.AppointmentID != null) ? info.AppointmentID : -1;
            if(viewModel.AppointmentId == -1)
                viewModel.PatientId = SelectedEntity.PatientId;
            viewModel.LockChangePatient = true;
            DocumentManagerService.CreateDocument(nameof(AppointmentView), viewModel).Show();
        }
        public ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
        IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("Flyout"); }
        }
    }
    // DTO
    public class PatientInfo {
        public int PatientId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime? LastVisit { get; set; }
        public DateTime? NextVisit { get; set; }
        public int Status { get; set; }
        public List<PatientProcedureInfo> Procedures { get; set; }
    }
    public class PatientProcedureInfo {
        public PatientProcedureInfo(Appointment appointment) {
            this.DoctorName = appointment?.Doctor?.FullName;
            this.VisitTime = appointment?.Date;
            this.AppointmentID = appointment?.Oid ?? -1;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string DoctorName { get; set; }
        public DateTime? VisitTime { get; set; }
        public int AppointmentID { get; set; }
    }
}
