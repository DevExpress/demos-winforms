using System;
using DevExpress.Xpo;

namespace DevExpress.XtraScheduler.Demos {
    // XP object
    public class OlAppointment : XPObject {
        public OlAppointment(Session session) : base(session) { }

        public DateTime Start; // Appointment.Start
        public DateTime End;          // Appointment.End

        public string Subject;           // Appointment.Subject

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string Body;       // Appointment.Description

        public bool AllDayEvent;     // Appointment.AllDay
        public int BusyStatus;               // Appointment.Status
        public string Location;          // Appointment.Location

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string RecurrencePattern;        // Appointment.RecurrenceInfo

        [Size(SizeAttribute.Unlimited)]  // !!! To set the Memo field type.
        public string ReminderSet;          // Appointment.ReminderInfo

        public int AppointmentType;      // Appointment.Type
        public int Label;                // Appointment.Label

		[Size(SizeAttribute.Unlimited)]  // (GUID) !!! To set the text field type. 
        public string EntryID; // ForeignIdFieldName
    }
}
