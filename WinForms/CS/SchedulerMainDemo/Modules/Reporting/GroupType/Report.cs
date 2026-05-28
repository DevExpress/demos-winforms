using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.GroupType {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

		public Report() {

			InitializeComponent();
		}
        
        public SchedulerGroupType GroupType {
            get { return reportWeekView1.GroupType; }
            set { reportWeekView1.GroupType = value; }
        }

        private void resourceInfo1_CustomizeText(object sender, TextCustomizingEventArgs e) {
            ResourceTextCustomizingEventArgs args = (ResourceTextCustomizingEventArgs)e;
            if ((args.Resources.Count == 1) && (args.Resources[0].Id.Equals(EmptyResourceId.Id)))
                args.Text = "Total Report";
        }
	}
}
