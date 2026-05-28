using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.View;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Utils.DragDrop;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModel {
    public class TreatmentPlanViewModel : ISupportParameter, IDisposable {
        public TreatmentPlanViewModel() {
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
            Doctors = new XPCollection<Doctor>(Session);
        }
        public void Dispose() {
            Appointments?.Dispose();
            Doctors?.Dispose();
            sessionCore?.Dispose();
        }
        void OnReloadData(ReloadDataMessage message) {
            if(IsSendingReloadDataMessage) return;
            sessionCore = null;
            OnPatientIdChanged();
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
        public virtual XPCollection<Doctor> Doctors {
            get;
            protected set;
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
        protected virtual void OnPatientIdChanged() {
            Patient = Session.GetObjectByKey<Patient>(PatientId);
            UnassignedProcedures = Patient.UnassignedProcedureCollection;
            Appointments = new XPCollection<Appointment>(Session);
            RaiseCanExecuteChanged();
        }
        public virtual XPCollection<ProcedureItem> UnassignedProcedures {
            get;
            protected set;
        }
        public virtual XPCollection<Appointment> Appointments {
            get;
            protected set;
        }
        IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("Flyout"); }
        }
        int sendingReloadDataMessage;
        bool IsSendingReloadDataMessage { 
            get { return sendingReloadDataMessage > 0; } 
        }
        public bool CanCreateAppointment(object resourceId) {
            return UnassignedProcedures.Count > 0;
        }
        public bool CanRemoveAllProcedures() {
            return UnassignedProcedures.Count > 0;
        }
        public void CreateAppointment(object resourceId) {
            var viewModel = ViewModelSource.Create<AppointmentViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.ResourceId = resourceId;
            viewModel.PatientId = PatientId;
            viewModel.LockChangePatient = true;
            DocumentManagerService.CreateDocument(nameof(AppointmentView), viewModel).Show();
        }
        public void RemoveProcedure(ProcedureItem procedure) {
            RemoveProcedureCore(procedure, true);
        }
        public void RemoveAllProcedures() {
            for(int i = UnassignedProcedures.Count - 1; i >= 0 ; i--)
                RemoveProcedureCore(UnassignedProcedures[i], false);
            CommitChanges();
        }
        void RemoveProcedureCore(ProcedureItem procedure, bool canCommitChanges = true) {
            Patient.UnassignedProcedureCollection.Remove(procedure);
            Patient.ProcedureCollection.Remove(procedure);
            if(canCommitChanges)
                CommitChanges();
        }
        public void CreateOrEditAppointment(AppointmentInfo appointmentInfo) {
            var viewModel = ViewModelSource.Create<AppointmentViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.Date = appointmentInfo.Date;
            viewModel.ResourceId = appointmentInfo.ResourceId;
            viewModel.AppointmentId = (appointmentInfo.Id != null) ? (int)appointmentInfo.Id : -1;
            DocumentManagerService.CreateDocument(nameof(AppointmentView), viewModel).Show();
        }
        public void OnAppointmentInserted() {
            if(isOuterDrag)
                Session.CommitChanges();
        }
        HashSet<int> draggedRowIndices; bool isOuterDrag;
        public void OnPrepareSchedulerDragData(PrepareDragDataArgs e) {
            isOuterDrag = true;
            draggedRowIndices = new HashSet<int>((int[])e.DataObject.GetData(typeof(int[])));
            if(draggedRowIndices == null) return;
            var appointments = new XtraScheduler.AppointmentBaseCollection();
            var apt = e.CreateAppointment();
            apt.Subject = Patient.FullName;
            apt.Duration = GetDurationOfDraggedProcedures();
            apt.LabelKey = GetLeadGroupOfDraggedProcedures();
            apt.StatusKey = apt.LabelKey;
            apt.CustomFields["AppointmentDuration"] = apt.Duration;
            apt.CustomFields["AppointmentStatus"] = AppointmentStatus.Open;
            apt.CustomFields["Patient"] = Patient;
            appointments.Add(apt);
            e.DragData = new XtraScheduler.SchedulerDragData(appointments);
        }
        public void OnDragSchedulerAppointment(DragDataArgs e) {
            if(!isOuterDrag) return;
            var draggedProceduresDuration = GetDurationOfDraggedProcedures();
            var conflictedAppointment = e.GetAppointmentsBetween(e.EditedAppointment.Start, e.EditedAppointment.End).FirstOrDefault();
            try {
                if(conflictedAppointment == null) return;
                var conflictedAppointmentDataObj = GetAssociatedDataObject(conflictedAppointment);
                if(conflictedAppointmentDataObj.Patient == null || conflictedAppointmentDataObj.Patient.Oid != Patient.Oid) {
                    e.Allow = false;
                    return;
                }
                DateTime newStart = conflictedAppointmentDataObj.Date;
                TimeSpan newDuration = conflictedAppointmentDataObj.EndDate + draggedProceduresDuration - conflictedAppointmentDataObj.Date;
                var conflictedAppointmentsOnMerge = e.GetAppointmentsBetween(newStart, newStart + newDuration);
                conflictedAppointmentsOnMerge.Remove(conflictedAppointment);
                if(conflictedAppointmentsOnMerge.Any()) {
                    newDuration = conflictedAppointmentDataObj.EndDate + draggedProceduresDuration - conflictedAppointmentDataObj.Date;
                    newStart = conflictedAppointmentsOnMerge.Min(x => x.Start) - newDuration;
                    conflictedAppointmentsOnMerge = e.GetAppointmentsBetween(newStart, newStart + newDuration);
                    conflictedAppointmentsOnMerge.Remove(conflictedAppointment);
                }
                if(e.Allow = !conflictedAppointmentsOnMerge.Any()) {
                    e.EditedAppointment.Start = newStart;
                    e.EditedAppointment.Duration = newDuration;
                }
            }
            finally {
                if(e.Allow && conflictedAppointment != null) {
                    if(!e.AdditionalAppointments.Contains(conflictedAppointment)) {
                        if(e.AdditionalAppointments.Any())
                            e.AdditionalAppointments.Clear();
                        e.AdditionalAppointments.Add(conflictedAppointment);
                    }
                }
                else {
                    e.AdditionalAppointments.Clear();
                    e.EditedAppointment.Duration = draggedProceduresDuration;
                }
            }
        }
        public void OnDragSchedulerAppointments(XtraScheduler.AppointmentsDragEventArgs e) {
            if(!isOuterDrag) return;
            foreach(var aptInfo in e.AdditionalAppointmentInfos)
                aptInfo.EditedAppointment.Start = DateTime.MinValue;
        }
        public void OnDropSchedulerAppointment(DragDataArgs e) {
            if(!isOuterDrag) return;
            var conflictedAppointment = e.GetAppointmentsBetween(e.EditedAppointment.Start, e.EditedAppointment.End).FirstOrDefault();
            if(conflictedAppointment == null) return;
            e.Allow = false;
            var conflictedAppointmentDataObj = GetAssociatedDataObject(conflictedAppointment);
            var procedureItems = GetDraggedProcedures();
            procedureItems.ForEach(p => UnassignedProcedures.Remove(p));
            conflictedAppointmentDataObj.ProcedureCollection.AddRange(procedureItems);
            conflictedAppointmentDataObj.Duration = GetDurationOfProcedures(conflictedAppointmentDataObj.ProcedureCollection);
            var conflictedAppointmentsOnMerge = e.GetAppointmentsBetween(conflictedAppointmentDataObj.Date, conflictedAppointmentDataObj.EndDate);
            conflictedAppointmentsOnMerge.Remove(conflictedAppointment);
            if(conflictedAppointmentsOnMerge.Any())
                conflictedAppointmentDataObj.Date = conflictedAppointmentsOnMerge.Min(x => x.Start) - conflictedAppointmentDataObj.Duration;
            conflictedAppointment.End = conflictedAppointmentDataObj.EndDate;
            isOuterDrag = false;
            CommitChanges();
        }
        public void OnDropSchedulerAppointmentComplete(XtraScheduler.AppointmentDropCompleteEventArgs e) {
            if(!isOuterDrag) return;
            var procedureItems = GetDraggedProcedures();
            procedureItems.ForEach(p => UnassignedProcedures.Remove(p));
            var draggableAppointment = e.Appointments.First();
            var draggableAppointmentDataObj = GetAssociatedDataObject(draggableAppointment);
            draggableAppointmentDataObj.ProcedureCollection.AddRange(procedureItems);
            isOuterDrag = false;
            CommitChanges();
        }
        List<ProcedureItem> GetDraggedProcedures() {
            return GetUnassignedProcedures(draggedRowIndices);
        }
        TimeSpan GetDurationOfProcedures(IEnumerable<ProcedureItem> procedureItems) {
            return procedureItems.Select(p => p.Procedure.Duration).Aggregate(TimeSpan.Zero, (r, x) => r + x);
        }
        TimeSpan GetDurationOfDraggedProcedures() {
            return GetDurationOfProcedures(GetDraggedProcedures());
        }
        ProcedureGroup GetLeadGroupOfDraggedProcedures() {
            return GetDraggedProcedures().First().Procedure.Group;
        }
        List<ProcedureItem> GetUnassignedProcedures(HashSet<int> rowIndices) {
            return UnassignedProcedures.Where((x, i) => rowIndices.Contains(i)).ToList();
        }
        Appointment GetAssociatedDataObject(XtraScheduler.Appointment appointment) {
            return Appointments.FirstOrDefault(x => x.Oid == (int)appointment.Id);
        }
        public void OnTileViewDragDrop(DragDropEventArgs e) {
            var appointmentsToInsert = (e.Data as object[])?
                .OfType<Appointment>()
                .Where(a => a.Patient == Patient)
                .ToList();
            if(appointmentsToInsert == null)
                return;
            foreach(var insertAppointment in appointmentsToInsert) {
                for(int i = insertAppointment.ProcedureCollection.Count - 1; i >= 0; i--) {
                    var procedureItem = insertAppointment.ProcedureCollection[i];
                    procedureItem.Appointment = null;
                    UnassignedProcedures.Add(procedureItem);
                }
                Session.Delete(insertAppointment);
            }
            CommitChanges();
        }
        public void OnTileViewEndDragDrop(EndDragDropEventArgs e) {
            isOuterDrag = false;
        }
        bool commitChangesInProcess;
        public void CommitChanges() {
            if(commitChangesInProcess) return;
            commitChangesInProcess = true;
            Session.CommitChanges();
            RaiseCanExecuteChanged();
            SendReloadDataMessage();
            commitChangesInProcess = false;
        }
        void SendReloadDataMessage() {
            try {
                sendingReloadDataMessage++;
                Messenger.Default.Send(ReloadDataMessage.AllData);
            }
            finally {
                sendingReloadDataMessage--;
            }
        }
        void RaiseCanExecuteChanged() {
            this.RaiseCanExecuteChanged(x => x.CreateAppointment(null));
            this.RaiseCanExecuteChanged(x => x.RemoveAllProcedures());
        }
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
    }
    public class PrepareDragDataArgs {
        readonly XtraScheduler.SchedulerControl scheduler;
        readonly XtraScheduler.PrepareDragDataEventArgs eventArgs;
        public PrepareDragDataArgs(XtraScheduler.SchedulerControl scheduler, XtraScheduler.PrepareDragDataEventArgs eventArgs) {
            this.scheduler = scheduler;
            this.eventArgs = eventArgs;
        }
        public System.Windows.Forms.IDataObject DataObject {
            get { return eventArgs.DataObject; }
        }
        public XtraScheduler.SchedulerDragData DragData {
            set { eventArgs.DragData = value; }
        }
        public XtraScheduler.Appointment CreateAppointment() {
            var appointment = scheduler.DataStorage.CreateAppointment(XtraScheduler.AppointmentType.Normal);
            appointment.ResourceId = scheduler.SelectedResource.Id;
            appointment.LabelKey = LabelMappingConverter.HighlightLabelId;
            return appointment;
        }
    }
    public class DragDataArgs {
        readonly XtraScheduler.SchedulerControl scheduler;
        readonly XtraScheduler.AppointmentDragEventArgs eventArgs;
        public DragDataArgs(XtraScheduler.SchedulerControl scheduler, XtraScheduler.AppointmentDragEventArgs eventArgs) {
            this.scheduler = scheduler;
            this.eventArgs = eventArgs;
        }
        public bool Allow { get { return eventArgs.Allow; } set { eventArgs.Allow = value; } }
        public bool ForceUpdateFromStorage { get { return eventArgs.ForceUpdateFromStorage; } set { eventArgs.ForceUpdateFromStorage = value; } }
        public XtraScheduler.Appointment SourceAppointment { get { return eventArgs.SourceAppointment; } }
        public XtraScheduler.Appointment EditedAppointment { get { return eventArgs.EditedAppointment; } }
        public XtraScheduler.AppointmentBaseCollection AdditionalAppointments { get { return eventArgs.AdditionalAppointments; } }
        public XtraScheduler.TimeInterval HitInterval { get { return eventArgs.HitInterval; } }
        public XtraScheduler.Resource HitResource { get { return eventArgs.HitResource; } }
        public XtraScheduler.ResourceIdCollection NewAppointmentResourceIds { get { return eventArgs.NewAppointmentResourceIds; } set { eventArgs.NewAppointmentResourceIds = value; } }
        public bool CopyEffect { get { return eventArgs.CopyEffect; } }
        public IList<DevExpress.XtraScheduler.Appointment> GetAppointmentsBetween(DateTime start, DateTime end) {
            return scheduler.DataStorage.GetAppointments(start, end).Where(x => Object.Equals(x.ResourceId, scheduler.SelectedResource.Id)).ToList();
        } 
    }
}
