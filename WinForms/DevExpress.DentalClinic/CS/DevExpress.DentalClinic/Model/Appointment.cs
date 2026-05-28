using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;

namespace DevExpress.DentalClinic.Model {
    public class Appointment : XPObject {
        public Appointment(Session session) : base(session) { }
        Patient patientCore;
        [Association]
        public Patient Patient {
            get { return patientCore; }
            set { SetPropertyValue(nameof(Patient), ref patientCore, value); }
        }
        Doctor doctorCore;
        [Association]
        public Doctor Doctor {
            get { return doctorCore; }
            set { SetPropertyValue(nameof(Doctor), ref doctorCore, value); }
        }
        DateTime dateCore;
        public DateTime Date {
            get { return dateCore; }
            set { SetPropertyValue(nameof(Date), ref dateCore, value); }
        }
        [Association]
        public XPCollection<ProcedureItem> ProcedureCollection { get { return GetCollection<ProcedureItem>(nameof(ProcedureCollection)); } }
        TimeSpan durationCore;
        public TimeSpan Duration {
            get { return durationCore; }
            set { SetPropertyValue(nameof(Duration), ref durationCore, value); }
        }
        bool allDayEventCore;
        public bool AllDayEvent {
            get { return allDayEventCore; }
            set { SetPropertyValue(nameof(AllDayEvent), ref allDayEventCore, value); }
        }
        AppointmentStatus statusCore;
        public AppointmentStatus Status {
            get { return statusCore; }
            set { SetPropertyValue(nameof(Status), ref statusCore, value); }
        }
        string commentCore;
        public string Comment {
            get { return commentCore; }
            set { SetPropertyValue(nameof(Comment), ref commentCore, value); }
        }
        [NonPersistent]
        public DateTime EndDate {
            get { return Date + durationCore; }
        }
        [NonPersistent]
        public ProcedureGroup ProcedureGroup {
            get {
                var procedure = ProcedureCollection.FirstOrDefault();
                if(procedure != null)
                    return procedure.Procedure.Group;
                return ProcedureGroup.Diagnosis;
            }
        }
        [NonPersistent]
        public string Description { 
            get {
                var descriptionStringBuilder = new StringBuilder();
                foreach(var procedureItem in ProcedureCollection) {
                    descriptionStringBuilder.AppendLine($"• {procedureItem.Procedure.Name}");
                }
                return descriptionStringBuilder.ToString();
            }
        }
    }
    public enum AppointmentStatus { Open, Completed, Failed, Canceled }
}
