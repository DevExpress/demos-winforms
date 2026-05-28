using System;
using System.ComponentModel;
using System.Linq;
using DevExpress.DentalClinic.Model;
using DevExpress.DentalClinic.Services;
using DevExpress.ExpressApp;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.ViewModel {
    public class InvoiceViewModel : IDocumentContent, IDisposable {
        
        public InvoiceViewModel() {
            ButtonText = DentalClinicStringId.Create;
            InvoiceHeader = DentalClinicStringId.InvoiceNew;
            Session.ObjectChanged += OnSessionObjectChanged;
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
        UnitOfWork sessionCore;
        public UnitOfWork Session {
            get {
                if(sessionCore == null)
                    sessionCore = SessionProvider.CreateSession();
                return sessionCore;
            }
        }
        public virtual Patient Patient { get; set; }
        public virtual Invoice Invoice { get; set; }
        public virtual int PatientId { get; set; }
        public virtual int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public virtual XPCollection<ProcedureItem> Procedures { get; set; }
        public virtual decimal Discount { get; set; }
        public virtual string ButtonText { get; set; }
        public virtual string InvoiceHeader { get; set; }
        bool IsNewInvoice { get; set; }
        protected void OnDiscountChanged() {
            Invoice.GrandTotal = Invoice.Total - (Invoice.Total * (Discount / 100));
            Invoice.Discount = Discount;
        }
        public void SetInvoice(int invoiceId) {
            Invoice = Session.GetObjectByKey<Invoice>(invoiceId);
            Appointment = Invoice.Appointment;
            Patient = Invoice.Patient;
            Discount = Invoice.Discount;
            Procedures = Appointment.ProcedureCollection;
            ButtonText = DentalClinicStringId.Save;
            IsNewInvoice = false;
            InvoiceHeader = string.Format(DentalClinicStringId.InvoiceEdit, Invoice.Oid);
        }
        protected void OnPatientIdChanged() {
            Invoice = new Invoice(Session);
            Patient = Session.GetObjectByKey<Patient>(PatientId);
            Invoice.Patient = Patient;
            Invoice.Date = DateTime.Now;
            Appointment = Session.GetObjectByKey<Appointment>(AppointmentId);
            Invoice.Doctor = Appointment.Doctor;
            Invoice.Appointment = Appointment;
            Invoice.Total = Appointment.ProcedureCollection.Sum(x => x.Procedure.Price);
            Discount = Invoice.Discount;
            Invoice.GrandTotal = Invoice.Total - (Invoice.Total * (Discount / 100));
            Procedures = Appointment.ProcedureCollection;
            InvoiceHeader = DentalClinicStringId.InvoiceNew;
            IsNewInvoice = true;
        }
        public bool CanSave() {
            return Session.TrackingChanges;
        }
        public void Save() {
            SaveCore();
        }
        void SaveCore(bool showMessage = true) {
            if(IsNewInvoice) {
                foreach(var item in Procedures) {
                    Invoice.InvoiceItems.Add(new InvoiceItem(Session)
                    {
                        Invoice = Invoice,
                        Procedure = item.Procedure,
                        ProcedurePrice = item.Procedure.Price,
                        Discount = Discount,
                        Total = item.Procedure.Price - (item.Procedure.Price * (Discount / 100))
                    });
                }
            }
            Session.CommitChanges();
            Messenger.Default.Send(ReloadDataMessage.AllData);
            if(showMessage && IsNewInvoice)
                MessageBoxService.ShowMessage(DentalClinicStringId.NewInvoiceMessage, DentalClinicStringId.NewInvoiceCaption, MessageButton.OK);
        }
        public void Clear() {
            Session.DropChanges();
        }
        public void Print() {
            if(Session.GetObjectsToSave().Count != 0) {
                var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNo);
                if(result == MessageResult.Yes)
                    SaveCore(false);
                if(result == MessageResult.No) {
                    Clear();
                    return;
                }
            }
            PrintReportService.PrintInvoice(Invoice.Oid);
        }
        void IDocumentContent.OnClose(CancelEventArgs e) {
            if(Session.GetObjectsToSave().Count == 0)
                return;
            var result = MessageBoxService.ShowMessage(DentalClinicStringId.SaveMessage, "", MessageButton.YesNoCancel);
            if(result == MessageResult.Yes)
                Save();
            if(result == MessageResult.No)
                Clear();
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
                Clear();
        }
        IDocumentOwner IDocumentContent.DocumentOwner { get; set; }
        object IDocumentContent.Title => string.Empty;
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
        IMessageBoxService MessageBoxService { get { return this.GetService<IMessageBoxService>(); } }
        IPrintReportService PrintReportService { get { return this.GetService<IPrintReportService>(); } }
    }
}
