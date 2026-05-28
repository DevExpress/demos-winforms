using System;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.Model {
    public class Procedure : XPObject {
        string nameCore;
        decimal priceCore;
        TimeSpan durationCore;
        ProcedureGroup groupCore;
        ProcedureType typeCore;
        bool checkedCore;
        public Procedure(Session session) : base(session) { }
        public string Name {
            get { return nameCore; }
            set { SetPropertyValue(nameof(Name), ref nameCore, value); }
        }
        public decimal Price {
            get { return priceCore; }
            set { SetPropertyValue(nameof(Price), ref priceCore, value); }
        }
        public TimeSpan Duration {
            get { return durationCore; }
            set { SetPropertyValue(nameof(Duration), ref durationCore, value); }
        }
        public ProcedureGroup Group {
            get { return groupCore; }
            set { SetPropertyValue(nameof(Group), ref groupCore, value); }
        }
        public ProcedureType Type {
            get { return typeCore; }
            set { SetPropertyValue(nameof(Type), ref typeCore, value); }
        }
        [NonPersistent]
        public bool Checked {
            get { return checkedCore; }
            set { SetPropertyValue(nameof(Checked), ref checkedCore, value); }
        }
    }
    [Flags]
    public enum ProcedureGroup { Diagnosis = 0, Restoration = 1, RootCanal = 2, Hygiene = 4, Whitening = 8, Prosthetics= 16, Implantation = 32, Orthodontics = 64, Surgery = 128 }
    public enum ProcedureType { General, Tooth }
    public class ProcedureItem : XPObject {
        Patient patientCore;
        Procedure procedureCore;
        Appointment appointmentCore;
        int toothNumberCore;
        bool checkedCore = true;
        public ProcedureItem(Session session) : base(session) { }
        [Association]
        public Patient Patient {
            get { return patientCore; }
            set { SetPropertyValue(nameof(Patient), ref patientCore, value); }
        }
        [Association]
        public Appointment Appointment {
            get { return appointmentCore; }
            set { SetPropertyValue(nameof(Appointment), ref appointmentCore, value); }
        }
        public Procedure Procedure {
            get { return procedureCore; }
            set { SetPropertyValue(nameof(Procedure), ref procedureCore, value); }
        }
        public int ToothNumber {
            get { return toothNumberCore; }
            set { SetPropertyValue(nameof(ToothNumber), ref toothNumberCore, value); }
        }
        [NonPersistent]
        public bool Checked {
            get { return checkedCore; }
            set { SetPropertyValue(nameof(Checked), ref checkedCore, value); }
        }
    }
}
