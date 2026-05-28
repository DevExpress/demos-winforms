namespace DevExpress.DentalClinic.Model {
    using DevExpress.Xpo;

    public class InvoiceItem : XPObject {
        public InvoiceItem(Session session)
            : base(session) {
        }
        decimal discountCore;
        public decimal Discount {
            get { return discountCore; }
            set { SetPropertyValue(nameof(Discount), ref discountCore, value); }
        }
        decimal totalCore;
        public decimal Total {
            get { return totalCore; }
            set { SetPropertyValue(nameof(Total), ref totalCore, value); }
        }
        Invoice invoiceCore;
        [Association]
        public Invoice Invoice {
            get { return invoiceCore; }
            set { SetPropertyValue(nameof(Invoice), ref invoiceCore, value); }
        }
        Procedure procedureCore;
        public Procedure Procedure { //todo
            get { return procedureCore; }
            set { SetPropertyValue(nameof(Procedure), ref procedureCore, value); }
        }
        decimal procedurePriceCore;
        public decimal ProcedurePrice {
            get { return procedurePriceCore; }
            set { SetPropertyValue(nameof(ProcedurePrice), ref procedurePriceCore, value); }
        }
    }
}
