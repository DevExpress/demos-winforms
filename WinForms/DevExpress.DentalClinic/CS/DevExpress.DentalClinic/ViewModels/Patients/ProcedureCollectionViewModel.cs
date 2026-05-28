using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.DentalClinic.Model;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModel {
    public class ProcedureCollectionViewModel : ISupportParameter, IDisposable {
        UnitOfWork sessionCore;
        XPCollection<Procedure> procedureSource;
        public ProcedureCollectionViewModel() {
            procedureSource = new XPCollection<Procedure>(Session);
            Procedures = new BindingList<Procedure>(procedureSource);
            AddedProcedures = new BindingList<AddedProcedureInfo>();
            Procedures.ListChanged += (s, e) => OnProceduresChanged();
            UpdateAddedProceduresCost();
        }
        public void Dispose() {
            procedureSource?.Dispose();
            sessionCore?.Dispose();
        }
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        object ISupportParameter.Parameter {
            get { return PatientId; }
            set { PatientId = (int)value; }
        }
        public virtual int PatientId {
            get;
            protected set;
        }
        public Patient Patient {
            get;
            protected set;
        }
        public virtual string AddedProceduresCost { 
            get; 
            protected set;
        }
        public BindingList<Procedure> Procedures {
            get;
            protected set;
        }
        public virtual ProcedureGroup SelectedGroup { 
            get; set; 
        }
        public virtual IEnumerable<int> Selection {
            get;
            set;
        }
        public virtual ProcedureGroup[] EnabledGroups {
            get; 
            protected set;
        }
        public virtual ProcedureType[] EnabledTypes {
            get;
            protected set;
        }
        public BindingList<AddedProcedureInfo> AddedProcedures {
            get;
            protected set;
        }
        public virtual List<ProcedureItem> CompletedProcedures {
            get;
            protected set;
        }
        public virtual List<ProcedureItem> OpenedProcedures {
            get;
            protected set;
        }
        protected void OnPatientIdChanged() {
            Patient = Session.Query<Patient>().Where(x => x.Oid == PatientId).FirstOrDefault();
            UpdateProcedures();
            OnSelectionChanged();
        }
        protected void OnProceduresChanged() {
            this.RaiseCanExecuteChanged(x => x.AddProcedures());
        }
        protected void OnSelectionChanged() {
            UpdateEnabledGroups();
            this.RaiseCanExecuteChanged(x => x.AddProcedures());
        }
        protected void OnSelectedGroupChanged() {
            UpdateEnabledTypes();
        }
        public void UpdateEnabledGroups() {
            UpdateEnabledTypes();
            var procedureTypes = new List<ProcedureType> { ProcedureType.General, ProcedureType.Tooth };
            if(Selection == null || !Selection.Any())
                procedureTypes.Remove(ProcedureType.Tooth);
            EnabledGroups = Procedures.Where(x => procedureTypes.Contains(x.Type)).Select(x => x.Group).ToArray();
        }
        public void UpdateEnabledTypes() {
            var procedureTypes = new List<ProcedureType> { ProcedureType.General, ProcedureType.Tooth };
            if(Selection == null || !Selection.Any())
                procedureTypes.Remove(ProcedureType.Tooth);
            EnabledTypes =  procedureTypes.Where(x => Procedures.Where(p => p.Group == SelectedGroup).Any(p => p.Type == x)).ToArray();
        }
        public bool CanAddProcedures() {
            return AddedProcedures.Any();
        }
        public void AddProcedures() {
            foreach(var addedProcedureInfo in AddedProcedures) {
                Patient.UnassignedProcedureCollection.Add(new ProcedureItem(Session) {
                    Patient = Patient,
                    Procedure = addedProcedureInfo.Procedure,
                    ToothNumber = addedProcedureInfo.ToothNumber
                });
            }
            ClearAddedProcedures();
            Selection = null;
            Session.CommitChanges();
            UpdateProcedures();
            Messenger.Default.Send(ReloadDataMessage.AllData);
        }
        void UpdateProcedures() {
            CompletedProcedures = Patient.AppointmentCollection
                .Where(x => x.Status == AppointmentStatus.Completed)
                .SelectMany(x => x.ProcedureCollection)
                .ToList();
            OpenedProcedures = Patient.AppointmentCollection
                .Where(x => x.Status == AppointmentStatus.Open)
                .SelectMany(x => x.ProcedureCollection)
                .Concat(Patient.UnassignedProcedureCollection)
                .ToList();
        }
        public void AddProcedure(Procedure procedure) {
            if(procedure.Type == ProcedureType.General)
                AddedProcedures.Add(new AddedProcedureInfo { ToothNumber = -1, Procedure = procedure });
            else {
                foreach(var itemNumber in Selection) {
                    AddedProcedures.Add(new AddedProcedureInfo { ToothNumber = itemNumber, Procedure = procedure });
                }
            }
            UpdateAddedProceduresCost();
            this.RaiseCanExecuteChanged(x => x.AddProcedures());
        }
        public void RemoveProcedure(AddedProcedureInfo addedProcedureInfo) {
            AddedProcedures.Remove(addedProcedureInfo);
            UpdateAddedProceduresCost();
            this.RaiseCanExecuteChanged(x => x.AddProcedures());
        }
        void ClearAddedProcedures() {
            AddedProcedures.Clear();
            UpdateAddedProceduresCost();
        }
        void UpdateAddedProceduresCost() {
            AddedProceduresCost = AddedProcedures.Sum(x => x.Procedure.Price).ToString("c");
        }
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
    }
    public class AddedProcedureInfo {
        public int ToothNumber { get; set; }
        public Procedure Procedure { get; set; }
    }
}
