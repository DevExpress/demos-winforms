namespace DevExpress.DentalClinic.ViewModel {
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using DevExpress.DentalClinic.Model;
    using DevExpress.Mvvm;
    using DevExpress.Mvvm.POCO;
    using DevExpress.Xpo;

    public class ProcedureHistoryViewModel {
        public ProcedureHistoryViewModel() {
            Messenger.Default.Register<ReloadDataMessage>(this, OnReloadData);
        }
        public virtual List<ExtendedInvoiceInfo> Invoices {
            get;
            protected set;
        }
        public virtual bool LoadComplete { get; set; }
        async void OnReloadData(ReloadDataMessage message) {
            await Load();
        }
        public async Task Load() {
            var dispatcher = this.GetService<IDispatcherService>();
            List<ExtendedInvoiceInfo> invoices = null;
            using(UnitOfWork session = SessionProvider.CreateSession()) {
                invoices = await session
                    .Query<InvoiceItem>()
                    .Select(x =>
                        new ExtendedInvoiceInfo
                        {
                            InvoiceId = x.Invoice.Oid,
                            PatientName = x.Invoice.Patient.FullName,
                            Date = x.Invoice.Date,
                            Duration = x.Procedure.Duration,
                            Doctor = x.Invoice.Doctor.FullName,
                            Procedure = x.Procedure.Name,
                            Total = x.Total,
                            Discount = x.Discount,
                            Bill = x.Invoice.Total,
                            Status = (int)x.Invoice.PaymentStatus
                        })
                    .ToListAsync();
            }
            await dispatcher.BeginInvoke(() => Invoices = invoices);
            LoadComplete = true;
        }
        ISecuredObjectSpaceService SessionProvider { get { return this.GetService<ISecuredObjectSpaceService>(); } }
    }
    // DTO
    public class ExtendedInvoiceInfo : InvoiceInfo {
        public TimeSpan Duration { get; set; }
        public string PatientName { get; set; }
        public DateTime EndDate {
            get { return Date + Duration; }
        }
        public string TimeInterval {
            get { return $"{Date:t}-{EndDate:t}"; }
        }
    }
}
