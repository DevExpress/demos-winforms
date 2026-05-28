using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevExpress.XtraScheduler.Demos {
    public class CarScheduling {
        [Key]
        public Int64 Id { get; set; }
        public bool AllDay { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int Label { get; set; }
        public int EventType { get; set; }
        public string Location { get; set; }
        public string Subject { get; set; }
        public string RecurrenceInfo { get; set; }
        public string ReminderInfo { get; set; }
        public Int32? CarId { get; set; }
        public double Price { get; set; }
    }
}
