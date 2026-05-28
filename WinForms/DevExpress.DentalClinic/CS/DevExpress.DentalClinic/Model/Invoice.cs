namespace DevExpress.DentalClinic.Model {
    using System;
    using DevExpress.Xpo;

    public class Invoice : XPObject {
        public Invoice(Session session)
             : base(session) {
        }
        Patient patientCore;
        [Association]
        public Patient Patient {
            get { return patientCore; }
            set { SetPropertyValue(nameof(Patient), ref patientCore, value); }
        }
        Appointment appointmentCore;
        public Appointment Appointment {
            get { return appointmentCore; }
            set { SetPropertyValue(nameof(Appointment), ref appointmentCore, value); }
        }
        Doctor doctorCore;
        public Doctor Doctor {
            get { return doctorCore; }
            set { SetPropertyValue(nameof(Doctor), ref doctorCore, value); }
        }
        DateTime dateCore;
        public DateTime Date {
            get { return dateCore; }
            set { SetPropertyValue(nameof(Date), ref dateCore, value); }
        }
        PaymentMethod paymentMethodCore;
        public PaymentMethod PaymentMethod {
            get { return paymentMethodCore; }
            set { SetPropertyValue(nameof(PaymentMethod), ref paymentMethodCore, value); }
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
        decimal grandTotalCore;
        public decimal GrandTotal {
            get { return grandTotalCore; }
            set { SetPropertyValue(nameof(GrandTotal), ref grandTotalCore, value); }
        }
        PaymentStatus paymentStatusCore;
        public PaymentStatus PaymentStatus {
            get { return paymentStatusCore; }
            set { SetPropertyValue(nameof(PaymentStatus), ref paymentStatusCore, value); }
        }
        [Association]
        public XPCollection<InvoiceItem> InvoiceItems {
            get { return GetCollection<InvoiceItem>(); }
        }
    }
    //
    public enum PaymentMethod { 
        Cash, 
        Card 
    }
    public enum PaymentStatus { 
        Unpaid,
        [System.ComponentModel.DataAnnotations.Display(Name = "Paid In Full")]
        PaidInFull,
        [System.ComponentModel.DataAnnotations.Display(Name = "Refund In Full")]
        RefundInFull 
    }
}
