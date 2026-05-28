namespace DevExpress.DentalClinic.Model {
    using System.ComponentModel;
    using DevExpress.Xpo;

    public class Doctor : Employee {
        public Doctor(Session session) 
            : base(session) {
        }
        [Association]
        public XPCollection<Appointment> AppointmentCollection {
            get { return GetCollection<Appointment>(); }
        }
    }
}
