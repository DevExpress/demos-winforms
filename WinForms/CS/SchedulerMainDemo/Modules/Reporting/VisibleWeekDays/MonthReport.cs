using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.VisibleWeekDays
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class MonthReport : XtraSchedulerReport, IVisibleWeekDaysReport {

		public MonthReport() {

			InitializeComponent();
		}
        public WeekDays VisibleWeekDays {
            get { return this.horizontalWeek1.VisibleWeekDays; }
            set { this.horizontalWeek1.VisibleWeekDays = value; }
        }

    }
}
