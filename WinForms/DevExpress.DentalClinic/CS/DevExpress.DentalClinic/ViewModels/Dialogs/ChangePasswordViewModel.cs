using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using DevExpress.Data.Utils.Security;
using DevExpress.DentalClinic.Model;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModels {
    public class ChangePasswordViewModel : ISupportParameter, IDocumentContent, IDisposable {
        public ChangePasswordViewModel() {
            PasswordData = new PasswordData();
        }
        public void Dispose() {
            sessionCore?.Dispose();
        }
        UnitOfWork sessionCore;
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        object ISupportParameter.Parameter {
            get { return EmployeeId; }
            set { EmployeeId = (Guid)value; }
        }
        public virtual PasswordData PasswordData {
            get;
            protected set;
        }
        public virtual Guid EmployeeId {
            get;
            protected set;
        }
        public virtual void OnEmployeeIdChanged() {
            Employee = Session.GetObjectByKey<Employee>(EmployeeId);
        }
        public virtual Employee Employee {
            get;
            protected set;
        }
        public bool CanSavePassword() {
            return !HasErrors;
        }
        public virtual void SavePassword() {
            if(Employee.ComparePassword(PasswordData.OldPassword)) {
                Employee.SetPassword(PasswordData.NewPassword);
                Session.CommitChanges();
                (this as IDocumentContent).DocumentOwner.Close(this, true);
            }
            else
                MessageBoxService.ShowMessage(DentalClinicStringId.WrongPassword);
        }
        public virtual bool HasErrors {
            get;
            protected set;
        }
        protected void OnHasErrorsChanged() {
            this.RaiseCanExecuteChanged(x => x.SavePassword());
        }
        public void ValidatePassword() {
            var validationResults = new List<ValidationResult>();
            var validationContext = new ValidationContext(PasswordData);
            HasErrors = !Validator.TryValidateObject(PasswordData, validationContext, validationResults, true);
            var errorProviderService = this.GetService<IErrorProviderService>();
            errorProviderService.Update(validationResults);
        }
        void IDocumentContent.OnClose(CancelEventArgs e) {
            if(Session.GetObjectsToSave().Count == 0)
                return;
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNoCancel);
            if(result == MessageResult.Yes)
                SavePassword();
            if(result == MessageResult.Cancel)
                e.Cancel = true;
        }
        void IDocumentContent.OnDestroy() {
            if(Session.GetObjectsToSave().Count == 0)
                return;
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNo);
            if(result == MessageResult.Yes)
                SavePassword();
        }
        ISecuredObjectSpaceService SessionProvider {
            get { return this.GetService<ISecuredObjectSpaceService>(); }
        }
        IMessageBoxService MessageBoxService {
            get { return this.GetService<IMessageBoxService>(); }
        }
        IDocumentOwner IDocumentContent.DocumentOwner { get; set; }
        object IDocumentContent.Title => string.Empty;
    }
    //
    public class PasswordData {
        public PasswordData() {
            OldPassword = string.Empty;
        }
        readonly SensitiveData oldPasswordData = SensitiveData.CreateForCurrentUser();
        [DataType(DataType.Password)]
        public string OldPassword {
            get { return oldPasswordData.Text; }
            set { oldPasswordData.Text = value; }
        }
        readonly SensitiveData newPasswordData = SensitiveData.CreateForCurrentUser();
        [DataType(DataType.Password)]
        public string NewPassword {
            get { return newPasswordData.Text; }
            set { newPasswordData.Text = value; }
        }
        readonly SensitiveData repeatPasswordData = SensitiveData.CreateForCurrentUser();
        [DataType(DataType.Password)]
        [Compare("NewPassword", ErrorMessage = "The new and confirmation passwords do not match")]
        public string RepeatPassword {
            get { return repeatPasswordData.Text; }
            set { repeatPasswordData.Text = value; }
        }
    }
    public interface IErrorProviderService {
        void Update(IReadOnlyCollection<ValidationResult> errors);
    }
}
