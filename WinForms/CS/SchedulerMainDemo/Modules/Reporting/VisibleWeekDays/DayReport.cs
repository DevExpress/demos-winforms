using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
    public partial class DayReport : XtraSchedulerReport, IVisibleWeekDaysReport {

        public DayReport() {

			InitializeComponent();
		}
        public WeekDays VisibleWeekDays {
            get { return this.dayViewTimeCells1.VisibleWeekDays; }
            set { this.dayViewTimeCells1.VisibleWeekDays = value; }
        }
        public int DayCount {
            get { return this.reportDayView1.VisibleDayCount; }
            set { this.reportDayView1.VisibleDayCount = value; }
        }
	}
}
