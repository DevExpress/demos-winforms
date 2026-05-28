using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExpress.XtraScheduler.Demos {
    public class MedicalAppointment {
        [Key]
        public Int64 Id { get; set; }
        public bool AllDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Int64? PatientId { get; set; }
        [ForeignKey("PatientId")]
        public Patient Patient { get; set; }
        public string Note { get; set; }
        public int PaymentStatusId { get; set; }
        public int IssueId { get; set; }
        public int EventType { get; set; }
        public string Location { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public Int64? MedicId { get; set; }
    }
}
