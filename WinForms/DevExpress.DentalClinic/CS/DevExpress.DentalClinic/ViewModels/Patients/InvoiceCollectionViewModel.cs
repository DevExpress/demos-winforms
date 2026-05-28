namespace DevExpress.DentalClinic.ViewModel {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using DevExpress.DentalClinic.Model;
    using DevExpress.DentalClinic.View;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;

    public class InvoiceCollectionViewModel : ISupportParameter {
        public InvoiceCollectionViewModel() {
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        object ISupportParameter.Parameter {
            get { return PatientId; }
            set { PatientId = (int)value; }
        }
        public virtual int PatientId {
            get;
            protected set;
        }
        public virtual List<InvoiceInfo> Invoices {
            get;
            protected set;
        }
        public virtual InvoiceInfo SelectedEntity {
            get;
            set;
        }
        protected void OnPatientIdChanged() {
            LoadInvoices();
        }
        public void Edit(int invoiceId) {
            if(invoiceId == -1) return;
            var viewModel = ViewModelSource.Create<InvoiceViewModel>();
            viewModel.SetParentViewModel(this);
            viewModel.SetInvoice(invoiceId);
            DocumentManagerService.CreateDocument(nameof(InvoiceView), viewModel).Show();
        }
        void OnReloadData(ReloadDataMessage message) {
            LoadInvoices();
        }
        void LoadInvoices() {
            using(var session = SessionProvider.CreateSession()) {
                var patient = session.GetObjectByKey<Patient>(PatientId);
                Invoices = patient.InvoiceCollection
                    .SelectMany(x => x.InvoiceItems)
                    .Select(x => new InvoiceInfo()
                    {
                        InvoiceId = x.Invoice.Oid,
                        Date = x.Invoice.Date,
                        Doctor = x.Invoice.Doctor.FullName,
                        Procedure = x.Procedure.Name,
                        Total = x.Total,
                        Discount = x.Invoice.Discount,
                        Bill = x.Invoice.GrandTotal,
                        Status = (int)x.Invoice.PaymentStatus
                    }).ToList();
            }
        }
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
        IDocumentManagerService DocumentManagerService {
            get { return this.GetService<IDocumentManagerService>("Flyout"); }
        }
    }
    // DTO
    public class InvoiceInfo {
        public int InvoiceId { get; set; }
        public DateTime Date { get; set; }
        public string Doctor { get; set; }
        public string Procedure { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Bill { get; set; }
        public int Status { get; set; }
    }
    public enum InvoiceInfoStatus {
        [Display(Name = "<backcolor=@DisabledText><b><color=255, 255, 255>  Unpaid  </b>")]
        Unpaid,
        [Display(Name = "<backcolor=@Success><b><color=255, 255, 255>  Paid In Full  </b>")]
        PaidInFull,
        [Display(Name = "<backcolor=@Danger><b><color=255, 255, 255>  Refund In Full  </b>")]
        RefundInFull
    }
    public class ReloadDataMessage {
        public readonly static ReloadDataMessage AllData = new ReloadDataMessage();
        ReloadDataMessage() { }
    }
}
