using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.XtraScheduler.Demos {
    public class Patient {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
    }
}
