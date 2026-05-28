using System;
using System.ComponentModel.DataAnnotations;

namespace DevExpress.XtraScheduler.Demos {
    public class HospitalDepartment {
        [Key]
        public Int64 Id { get; set; }
        public string Name { get; set; }
    }
}
