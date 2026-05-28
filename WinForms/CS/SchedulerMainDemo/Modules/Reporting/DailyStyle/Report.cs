using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.DailyStyle
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

		public Report() {

			InitializeComponent();
		}
        public SchedulerGroupType GroupType { get { return this.reportDayView1.GroupType; } set { this.reportDayView1.GroupType = value; } }
        public int VisibleResourceCount { get { return this.reportDayView1.VisibleResourceCount; } set { this.reportDayView1.VisibleResourceCount = value; } }
        public TimeSpan TimeScale { get { return this.dayViewTimeCells1.TimeScale; } set { this.dayViewTimeCells1.TimeScale = value; } }
        public TimeOfDayInterval VisibleTime { get { return this.dayViewTimeCells1.VisibleTime; } set { this.dayViewTimeCells1.VisibleTime = value; } }
        public bool PrintAllAppointments { get { return dayViewTimeCells1.ExtraCells.Visible; } set { dayViewTimeCells1.ExtraCells.Visible = value; } }
        public int VisibleDayCount { get { return this.reportDayView1.VisibleDayCount; } set { this.reportDayView1.VisibleDayCount = value; } }
	}
}
