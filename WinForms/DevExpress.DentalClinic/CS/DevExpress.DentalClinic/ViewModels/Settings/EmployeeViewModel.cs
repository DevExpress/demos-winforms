using System;
using System.ComponentModel;
using DevExpress.DentalClinic.Model;
using DevExpress.ExpressApp;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModel {
    public class EmployeeViewModel : IEditViewModel, ISupportParameter, IDisposable {
        public EmployeeViewModel() {
            EmployeeId = (Guid)SessionProvider.Security.UserId;
            Employee = Session.GetObjectByKey<Employee>(EmployeeId);
            Session.ObjectChanged += OnSessionObjectChanged;
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        public void Dispose() {
            if(sessionCore != null) {
                sessionCore.ObjectChanged -= OnSessionObjectChanged;
                sessionCore.Dispose();
            }
        }
        public virtual Guid EmployeeId {
            get;
            set;
        }
        void OnReloadData(ReloadDataMessage message) {
            if(IsSendingReloadDataMessage) return;
            EmployeeId = (Guid)SessionProvider.Security.UserId;
        }
        void OnSessionObjectChanged(object sender, ObjectChangeEventArgs e) {
            this.RaiseCanExecuteChanged(x => x.Save());
        }
        UnitOfWork sessionCore;
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        public virtual Employee Employee {
            get;
            protected set;
        }
        int sendingReloadDataMessage;
        bool IsSendingReloadDataMessage {
            get { return sendingReloadDataMessage > 0; }
        }
        public bool CanSave() {
            return Session.GetObjectsToSave().Count > 0 && !HasValidationErrors();
        }
        public void Save() {
            Session.CommitChanges();
            SendReloadDataMessage();
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
        public void ChangePassword() {
            DocumentManagerService.CreateDocument(nameof(Views.Settings.ChangePasswordView), Employee.Oid, this).Show();
            Session.Reload(Employee);
        }
        bool HasValidationErrors() {
            IDataErrorInfo dataErrorInfo = Employee as IDataErrorInfo;
            return (dataErrorInfo != null) && Mvvm.IDataErrorInfoHelper.HasErrors(dataErrorInfo);
        }
        public void OnEmployeeIdChanged() {
            Employee = Session.GetObjectByKey<Employee>(EmployeeId);
        }
        bool IEditViewModel.CanNavigateFrom() {
            if(Session.GetObjectsToSave().Count == 0 && !HasValidationErrors()) return true;
            if(HasValidationErrors()) {
                MessageBoxService.ShowMessage("Incorrect UserName", "", MessageButton.OK);
                return false;
            }
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNoCancel);
            if(result == MessageResult.Yes)
                Save();
            if(result == MessageResult.No)
                Session.DropChanges();
            if(result == MessageResult.Cancel)
                return false;
            return true;
        }
        ISecuredObjectSpaceService SessionProvider {
            get { return this.GetService<ISecuredObjectSpaceService>(); }
        }
        IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("Flyout"); }
        }
        IMessageBoxService MessageBoxService { get { return this.GetService<IMessageBoxService>(); } }
        object ISupportParameter.Parameter {
            get { return EmployeeId; }
            set {
                if(value != null)
                    EmployeeId = (Guid)value;
            }
        }
    }
}
