using System;
using DevExpress.XtraScheduler.Reporting;

namespace DevExpress.XtraScheduler.Demos.Reporting.SmartSyncPrinting {
	/// <summary>
	/// Summary description for Report.
	/// </summary>
	public partial class Report : XtraSchedulerReport {

		public Report() {

			InitializeComponent();
		}
        private void resourceInfo1_CustomizeText(object sender, TextCustomizingEventArgs e) {
            ResourceTextCustomizingEventArgs args = (ResourceTextCustomizingEventArgs)e;
            if ((args.Resources.Count == 1) && (args.Resources[0].Id.Equals(EmptyResourceId.Id)))
                args.Text = "Total Report";
        }
	}
}
