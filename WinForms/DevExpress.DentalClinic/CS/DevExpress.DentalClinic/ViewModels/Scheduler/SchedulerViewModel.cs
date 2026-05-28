using System;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.View;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModel {
    public class SchedulerViewModel: IDisposable {
        public SchedulerViewModel() {
            Appointments = new XPCollection<Appointment>(Session);
            Doctors = new XPCollection<Doctor>(Session);
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        public void Dispose() {
            Appointments?.Dispose();
            Doctors?.Dispose();
            sessionCore?.Dispose();
        }
        void OnReloadData(ReloadDataMessage message) {
            Appointments = new XPCollection<Appointment>(Session);
            Doctors = new XPCollection<Doctor>(Session);
            ReloadResource = !ReloadResource;
        }
        public virtual bool ReloadResource {
            get;
            set;
        }
        UnitOfWork sessionCore;
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        public virtual XPCollection<Appointment> Appointments {
            get;
            protected set;
        }
        public virtual XPCollection<Doctor> Doctors {
            get;
            protected set;
        }
        IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("Flyout"); }
        }
        public void CreateOrEditAppointment(AppointmentInfo appointmentInfo) {
            var viewModel = ViewModelSource.Create<AppointmentViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.Date = appointmentInfo.Date;
            viewModel.ResourceId = appointmentInfo.ResourceId;
            viewModel.AppointmentId = (appointmentInfo.Id != null) ? (int)appointmentInfo.Id : -1;
            DocumentManagerService.CreateDocument(nameof(AppointmentView), viewModel).Show();
        }
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
    }
    public class AppointmentInfo {
        public object Id { get; set; }
        public DateTime Date { get; set; }
        public object ResourceId { get; set; }
    }
}
