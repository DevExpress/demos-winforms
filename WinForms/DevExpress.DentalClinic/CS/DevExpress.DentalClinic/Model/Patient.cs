namespace DevExpress.DentalClinic.Model {
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Drawing;
    using DevExpress.Data.Filtering;
    using DevExpress.Xpo;

    public class Patient : XPObject, System.ComponentModel.IDataErrorInfo {
        XPCollection<ProcedureItem> unassignedProcedureCollection;
        public Patient(Session uow)
            : base(uow) {
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
            addressCore = new Address(Session);
            pictureCore = new Picture(Session);
        }
        string firstNameCore;
        [Required]
        public string FirstName {
            get { return firstNameCore; }
            set { SetPropertyValue(nameof(FirstName), ref firstNameCore, value); }
        }
        string lastNameCore;
        [Required]
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
        [Required, EmailAddress]
        public string Email {
            get { return emailCore; }
            set { SetPropertyValue(nameof(Email), ref emailCore, value); }
        }
        string phoneCore;
        [Required, Phone]
        public string Phone {
            get { return phoneCore; }
            set { SetPropertyValue(nameof(Phone), ref phoneCore, value); }
        }
        Image photoCore;
        [NonPersistent]
        public Image Photo {
            get {
                if(photoCore == null)
                    photoCore = Picture.GetImage();
                return photoCore; ;
            }
            set {
                if(photoCore == value) return;
                if(photoCore != null)
                    photoCore.Dispose();
                photoCore = value;
                Picture.Image = value;
            }
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
        [Xpo.Association]
        public XPCollection<Invoice> InvoiceCollection {
            get { return GetCollection<Invoice>(); }
        }
        [Xpo.Association]
        public XPCollection<Appointment> AppointmentCollection {
            get { return GetCollection<Appointment>(); }
        }
        [Xpo.Association]
        public XPCollection<ProcedureItem> ProcedureCollection { 
            get { return GetCollection<ProcedureItem>(); } 
        }
        public XPCollection<ProcedureItem> UnassignedProcedureCollection {
            get {
                if(unassignedProcedureCollection == null) {
                    var filter = new NullOperator(nameof(ProcedureItem.Appointment));
                    unassignedProcedureCollection = new XPCollection<ProcedureItem>(ProcedureCollection, filter);
                }
                return unassignedProcedureCollection; 
            }
        }
        [Xpo.Association("Document-Patient")]
        public XPCollection<Document> DocumentCollection {
            get { return GetCollection<Document>(); }
        }
        [Xpo.Association]
        public XPCollection<MissingTooth> MissingToothCollection {
            get { return GetCollection<MissingTooth>(); }
        }
        string notesCore;
        [Size(SizeAttribute.Unlimited)]
        public string Notes {
            get { return notesCore; }
            set { SetPropertyValue(nameof(Notes), ref notesCore, value); }
        }
        string complaintsCore;
        [Size(SizeAttribute.Unlimited)]
        public string Complaints {
            get { return complaintsCore; }
            set { SetPropertyValue(nameof(Complaints), ref complaintsCore, value); }
        }
        string allergiesCore;
        [Size(SizeAttribute.Unlimited)]
        public string Allergies {
            get { return allergiesCore; }
            set { SetPropertyValue(nameof(Allergies), ref allergiesCore, value); }
        }
        public string Error => null;
        public string this[string columnName] => Mvvm.IDataErrorInfoHelper.GetErrorText(this, columnName);
    }
}
