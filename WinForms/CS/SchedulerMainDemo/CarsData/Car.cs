using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace DevExpress.XtraScheduler.Demos {
    public class Car {
        public Car(int carId, string caption) {
            Id = carId;
            Caption = caption;
        }

        [Key]
        public Int32 Id { get; set; }
        public string Caption { get; set; }
    }
}
