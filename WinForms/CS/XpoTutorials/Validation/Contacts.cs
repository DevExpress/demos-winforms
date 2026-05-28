using System;
using DevExpress.Xpo;
using DevExpress.XtraEditors.DXErrorProvider;

/*
 * Since the release of version 6.3 XPO supports error notifications. To support error notifications, a persistent class 
 * must implement the IDXDataErrorInfo interface. This provides the GetPropertyError method. You should implement this method
 * to provide a validation procedure to verify data. 
 * If persistent objects implement this interface, the bound controls with invalid data will display error/warning icons.
 */
 
namespace DevExpress.Xpo.Demos {
    //<gridControl1>
    public class Contact : XPObject, IDXDataErrorInfo {
        //</gridControl1>
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string email;

        public Contact() {}
        public Contact(Session session) : base(session) {
            this.firstName = "";
            this.lastName = "";
            this.address = "";
            this.phoneNumber = "";
            this.email = "@hotmail.com";
        }
        public Contact(Session session, string firstName, string lastName, string address, string phoneNumber, string email) : base(session){
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public string FirstName {
            get { return firstName; }
            set {
                string oldValue = FirstName;
                if(oldValue == value)
                    return;
                firstName = value;
                OnChanged(nameof(FirstName), oldValue, value);
            }
        }
        public string LastName {
            get { return lastName; }
            set {
                string oldValue = LastName;
                if(oldValue == value)
                    return;
                lastName = value;
                OnChanged(nameof(LastName), oldValue, value);
            }
        }
        public string Address {
            get { return address; }
            set {
                string oldValue = Address;
                if(oldValue == value)
                    return;
                address = value;
                OnChanged(nameof(Address), oldValue, value);
            }
        }
        public string PhoneNumber {
            get { return phoneNumber; }
            set {
                string oldValue = PhoneNumber;
                if(oldValue == value)
                    return;
                phoneNumber = value;
                OnChanged(nameof(PhoneNumber), oldValue, value);
            }

        }
        public string Email {
            get { return email; }
            set {
                string oldValue = Email;
                if(oldValue == value)
                    return;
                email = value;
                OnChanged(nameof(Email), oldValue, value);
            }
        }
        //<gridControl1>
        void IDXDataErrorInfo.GetPropertyError(string propertyName, ErrorInfo info){
            switch(propertyName) {
                case nameof(FirstName) :
                    if(IsStringEmpty(FirstName)) {
                        SetErrorInfo(info, "First Name field can't be empty", ErrorType.Critical);
                    }
                    break;
                case nameof(LastName) :  
                    if(IsStringEmpty(LastName)) {
                        SetErrorInfo(info, "Last Name field can't be empty", ErrorType.Critical);
                    }
                    break;
                case nameof(Address) :  
                    if(IsStringEmpty(Address)) {
                        SetErrorInfo(info, "Address hasn't been entered", ErrorType.Information);
                    }
                    break;
                case nameof(Email) : 
                    if(IsStringEmpty(Email)) {
                        SetErrorInfo(info, "Email hasn't been entered", ErrorType.Information);
                    }
                    else if(!IsEmailCorrect(Email)) {
                        SetErrorInfo(info, "Wrong email address", ErrorType.Warning);
                    }
                    break;
            }
        }
        void IDXDataErrorInfo.GetError(ErrorInfo info) { }
        bool IsStringEmpty(string str) {
            return (str != null && str.Trim().Length == 0);
        }
        bool IsEmailCorrect(string email) {
            return !(email != null && email.IndexOf("@") < 1);
        }
        void SetErrorInfo(ErrorInfo info, string errorText, ErrorType errorType){
            info.ErrorText = errorText;
            info.ErrorType = errorType;
        }
    }
    //</gridControl1>
}
