using System;
using DevExpress.XtraScheduler.Commands;

namespace DevExpress.XtraScheduler.Demos {
	public partial class SchedulerBarsModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public SchedulerBarsModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            this.schedulerControl.DayView.ShowWorkTimeOnly = true;
            this.schedulerControl.WorkWeekView.ShowWorkTimeOnly = true;
			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void SchedulerBarsModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }

		private void barManager1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
			CommitAndCloseInplaceEditorCommand command = new CommitAndCloseInplaceEditorCommand(schedulerControl);
			command.Execute();
		}
	}
}

