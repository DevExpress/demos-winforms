using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class UnboundModeModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public UnboundModeModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        private void UnboundModeModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
	}
}
