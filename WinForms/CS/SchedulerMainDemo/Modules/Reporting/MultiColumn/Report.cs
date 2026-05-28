using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.MultiColumn
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

		public Report() {

			InitializeComponent();
		}
        public int VisibleWeekDayColumnCount {
			get { return reportWeekView1.VisibleWeekDayColumnCount; }
            set {
                if (reportWeekView1.VisibleWeekDayColumnCount == value)
                    return;
                reportWeekView1.VisibleWeekDayColumnCount = value;
                OnVisibleWeekDayColumnCountChanged();
            }
		}
        public ColumnArrangementMode ColumnArrangement { 
            get { return reportWeekView1.ColumnArrangement; }
            set { reportWeekView1.ColumnArrangement = value; }
        }
        private void OnVisibleWeekDayColumnCountChanged() {
            if (VisibleWeekDayColumnCount == 2) {
                this.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.Odd;
                this.calendarControl1.PrintInColumn = PrintInColumnMode.Even;
                this.timeIntervalInfo1.PrintContentMode = PrintContentMode.AllColumns;
            } else {
                this.timeIntervalInfo1.PrintInColumn = PrintInColumnMode.All;
                this.calendarControl1.PrintInColumn = PrintInColumnMode.All;
                this.timeIntervalInfo1.PrintContentMode = PrintContentMode.CurrentColumn;
            }
        }

	}
}
