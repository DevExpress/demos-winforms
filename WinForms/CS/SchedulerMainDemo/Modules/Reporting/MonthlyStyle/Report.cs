using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.MonthlyStyle {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

        public Report() {
            InitializeComponent();
        }

        public bool PrintExactlyOneMonth {
            get { return reportMonthView1.ExactlyOneMonth; }
            set { reportMonthView1.ExactlyOneMonth = value; }
        }
        public int VisibleResourceCount {
            get { return reportMonthView1.VisibleResourceCount; }
            set { reportMonthView1.VisibleResourceCount = value; }
        }
        public bool DontPrintWeekends {
            get { return horizontalWeek1.VisibleWeekDays.Equals(WeekDays.WorkDays); }
            set {
                if (value)
                    horizontalWeek1.VisibleWeekDays = WeekDays.WorkDays;
                else {
                    horizontalWeek1.VisibleWeekDays = WeekDays.EveryDay;
                }
            }
        }
        public bool CompressWeekend { get { return horizontalWeek1.CompressWeekend; } set { horizontalWeek1.CompressWeekend = value; } }
        public int ColumnCount { 
            get { return reportMonthView1.VisibleWeekDayColumnCount; } 
            set {
                if (reportMonthView1.VisibleWeekDayColumnCount == value)
                    return;

                reportMonthView1.VisibleWeekDayColumnCount = value;
                OnColumnCountChanged();
            } 
        }

        private void OnColumnCountChanged() {
            if (ColumnCount == 2) {
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
