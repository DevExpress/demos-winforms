using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Mvvm;

namespace DevExpress.DentalClinic {
    public interface IFreeDateTimeService {
        HashSet<DateTime> FreeDays { get; set; }
        DateTime LastAppointmentDay { get; set; }
        HashSet<DateTimeRange> FreeTimes { get; set; }
        List<IGrouping<DateTime, DateTimeRange>> Dates { get; set; }
    }

    public class FreeDateTimeService : IFreeDateTimeService {
        public HashSet<DateTime> FreeDays { get; set; }
        public HashSet<DateTimeRange> FreeTimes { get; set; }
        public DateTime LastAppointmentDay { get; set; }
        public List<IGrouping<DateTime, DateTimeRange>> Dates { get; set; }
    }

}
