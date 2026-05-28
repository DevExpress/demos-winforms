namespace DevExpress.DentalClinic.Model {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Linq;
    using DevExpress.Data.Utils.Security;
    using DevExpress.ExpressApp.Security;
    using DevExpress.Persistent.Base;
    using DevExpress.Persistent.Base.Security;
    using DevExpress.Persistent.BaseImpl;
    using DevExpress.Persistent.BaseImpl.PermissionPolicy;
    using DevExpress.Persistent.Validation;
    using DevExpress.Xpo;

    public class Employee : BaseObject,
        IPermissionPolicyUser, ISecurityUser, ISecurityUserWithRoles,
        IAuthenticationActiveDirectoryUser, IAuthenticationStandardUser,
        IDataErrorInfo {
        public Employee(Session session)
            : base(session) {
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
            addressCore = new Address(Session);
            pictureCore = new Picture(Session);
        }
        //
        string firstNameCore;
        public string FirstName {
            get { return firstNameCore; }
            set { SetPropertyValue(nameof(FirstName), ref firstNameCore, value); }
        }
        string lastNameCore;
        public string LastName {
            get { return lastNameCore; }
            set { SetPropertyValue(nameof(LastName), ref lastNameCore, value); }
        }
        [PersistentAlias("Concat(FirstName, ' ', LastName)")]
        public string FullName {
            get { return EvaluateAlias("FullName") as string; }
        }
        DateTime birthdayCore;
        public DateTime Birthday {
            get { return birthdayCore; }
            set { SetPropertyValue(nameof(Birthday), ref birthdayCore, value); }
        }
        string emailCore;
        public string Email {
            get { return emailCore; }
            set { SetPropertyValue(nameof(Email), ref emailCore, value); }
        }
        string phoneCore;
        public string Phone {
            get { return phoneCore; }
            set { SetPropertyValue(nameof(Phone), ref phoneCore, value); }
        }
        [NonPersistent]
        public Image Photo {
            get { return Picture.Image; }
            set { Picture.Image = value; }
        }
        Picture pictureCore;
        [Aggregated]
        public Picture Picture {
            get { return pictureCore; }
            set { SetPropertyValue(nameof(Picture), ref pictureCore, value); }
        }
        Address addressCore;
        [Aggregated]
        public Address Address {
            get { return addressCore; }
            set { SetPropertyValue(nameof(Address), ref addressCore, value); }
        }
        string notesCore;
        [Size(SizeAttribute.Unlimited)]
        public string Notes {
            get { return notesCore; }
            set { SetPropertyValue(nameof(Notes), ref notesCore, value); }
        }
        private bool changePasswordOnFirstLogon;
        public bool ChangePasswordOnFirstLogon {
            get { return changePasswordOnFirstLogon; }
            set { SetPropertyValue(nameof(ChangePasswordOnFirstLogon), ref changePasswordOnFirstLogon, value); }
        }
        readonly SensitiveData storedPasswordData = SensitiveData.CreateForCurrentUser();
        [Browsable(false), Size(SizeAttribute.Unlimited), Persistent, SecurityBrowsable]
        protected string StoredPassword {
            get { return storedPasswordData.Text; }
            set { storedPasswordData.Text = value; }
        }
        public bool ComparePassword(string password) {
            return PasswordCryptographer.VerifyHashedPasswordDelegate(StoredPassword, password);
        }
        public void SetPassword(string password) {
            StoredPassword = PasswordCryptographer.HashPasswordDelegate(password);
            OnChanged(nameof(StoredPassword));
        }
        IList<ISecurityRole> ISecurityUserWithRoles.Roles {
            get {
                IList<ISecurityRole> result = new List<ISecurityRole>();
                foreach(EmployeeRole role in EmployeeRoles)
                    result.Add(role);
                return result;
            }
        }
        [Association("Employees-EmployeeRoles")]
        [RuleRequiredField("EmployeeRoleIsRequired", DefaultContexts.Save,
            TargetCriteria = "IsActive",
            CustomMessageTemplate = "An active employee must have at least one role assigned")]
        public XPCollection<EmployeeRole> EmployeeRoles {
            get { return GetCollection<EmployeeRole>(nameof(EmployeeRoles)); }
        }
        bool isActiveCore = true;
        public bool IsActive {
            get { return isActiveCore; }
            set { SetPropertyValue(nameof(IsActive), ref isActiveCore, value); }
        }
        string userNameCore = String.Empty;
        [RuleRequiredField("UserUserNameRequired", DefaultContexts.Save)]
        [RuleUniqueValue("UserUserNameIsUnique", DefaultContexts.Save,
            "The login with the entered user name was already registered within the system.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string UserName {
            get { return userNameCore; }
            set { SetPropertyValue(nameof(UserName), ref userNameCore, value); }
        }
        IEnumerable<IPermissionPolicyRole> IPermissionPolicyUser.Roles {
            get { return EmployeeRoles.OfType<IPermissionPolicyRole>(); }
        }
        public string Error => null;
        public string this[string columnName] {
            get { return Mvvm.IDataErrorInfoHelper.GetErrorText(this, columnName); }
        }
    }

    [ImageName("BO_Role")]
    public class EmployeeRole : PermissionPolicyRoleBase, IPermissionPolicyRoleWithUsers {
        public EmployeeRole(Session session)
            : base(session) {
        }
        [Association("Employees-EmployeeRoles")]
        public XPCollection<Employee> Employees {
            get { return GetCollection<Employee>(nameof(Employees)); }
        }
        IEnumerable<IPermissionPolicyUser> IPermissionPolicyRoleWithUsers.Users {
            get { return Employees.OfType<IPermissionPolicyUser>(); }
        }
    }
}
