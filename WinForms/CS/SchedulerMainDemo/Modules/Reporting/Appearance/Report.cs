using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.Appearance
{
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

		public Report() {

			InitializeComponent();
		}
        public ReportDayViewAppearance Appearances {get { return reportDayView1.Appearance; } }

        public PrintColorSchema AppointmentsColorSchema { 
            get { return dayViewTimeCells1.PrintColorSchemas.Appointment; } 
            set { dayViewTimeCells1.PrintColorSchemas.Appointment = value; } 
        }
        public PrintColorSchema ReportColorSchema {get { return this.PrintColorSchema; }
            set { this.PrintColorSchema = value; }
        }
    }
}
