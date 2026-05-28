using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class WeekViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {

		public WeekViewModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			PrepareViews();
		}

		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected AppointmentDisplayOptions DisplayOptions { get { return schedulerControl.WeekView.AppointmentDisplayOptions; } }

		void PrepareViews() {
			this.schedulerControl.DayView.Enabled = true;
			this.schedulerControl.WorkWeekView.Enabled = false;
			this.schedulerControl.MonthView.Enabled = false;
			this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
        }

		private void WeekViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
            UpdateControls();
		}
		void UpdateControls() {
			AppointmentDisplayOptions options = DisplayOptions;
			chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.StartTimeVisibility);
			chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.EndTimeVisibility);

			cbTimeDisplayType.EditValue = options.TimeDisplayType;
			cbStatus.EditValue = options.StatusDisplayType;
		}
		private void WeekViewModule_VisibleChanged(object sender, System.EventArgs e) {
			schedulerControl.ActiveViewType = SchedulerViewType.Week;
		}

		private void chkStartTimeVisibility_CheckStateChanged(object sender, EventArgs e) {
			DisplayOptions.StartTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkStartTimeVisibility.CheckState);
		}

		private void chkEndTimeVisibility_CheckStateChanged(object sender, EventArgs e) {
			DisplayOptions.EndTimeVisibility = DemoUtils.CheckStateToTimeVisibility(chkEndTimeVisibility.CheckState);
		}

		private void cbTimeDisplayType_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.TimeDisplayType = (AppointmentTimeDisplayType)cbTimeDisplayType.EditValue;
		}

		private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)cbStatus.EditValue;
		}

        private void chkStatusOrientation_CheckedChanged(object sender, EventArgs e) {
            WeekViewAppointmentDisplayOptionsEx weekViewOptions = DisplayOptions as WeekViewAppointmentDisplayOptionsEx;
            if(weekViewOptions != null) weekViewOptions.ShowAppointmentStatusVertically = chkStatusOrientation.Checked;
        }
	}
}
