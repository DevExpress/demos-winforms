using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class MonthViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public MonthViewModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			PrepareViews();
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected AppointmentDisplayOptions DisplayOptions { get { return schedulerControl.MonthView.AppointmentDisplayOptions; } }

		void PrepareViews() {
			this.schedulerControl.DayView.Enabled = true;
			this.schedulerControl.WeekView.Enabled = false;
			this.schedulerControl.WorkWeekView.Enabled = false;
			this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
        }

		private void MonthViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
            UpdateControls();
		}
		void UpdateControls() {
			AppointmentDisplayOptions options = DisplayOptions;
			chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.StartTimeVisibility);
			chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(options.EndTimeVisibility);

			chkCompressWeekEnd.Checked = schedulerControl.MonthView.CompressWeekend;
			chkShowWeekend.Checked = schedulerControl.MonthView.ShowWeekend;
			chkCompressWeekEnd.Enabled = chkShowWeekend.Checked;

			cbTimeDisplayType.EditValue = options.TimeDisplayType;
			cbStatus.EditValue = options.StatusDisplayType;
			spinWeekCount.EditValue = schedulerControl.MonthView.WeekCount;
		}

		private void chkCompressWeekEnd_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.MonthView.CompressWeekend = chkCompressWeekEnd.Checked;
		}
		private void chkShowWeekend_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl.MonthView.ShowWeekend = chkShowWeekend.Checked;
			chkCompressWeekEnd.Enabled = chkShowWeekend.Checked;
		}
		private void spinWeekCount_EditValueChanged(object sender, System.EventArgs e) {
			schedulerControl.MonthView.WeekCount = Convert.ToInt32(spinWeekCount.EditValue);
		}
		private void MonthViewModule_VisibleChanged(object sender, System.EventArgs e) {
			schedulerControl.ActiveViewType = SchedulerViewType.Month;
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
            MonthViewAppointmentDisplayOptionsEx monthViewOptions = DisplayOptions as MonthViewAppointmentDisplayOptionsEx;
            if(monthViewOptions != null) monthViewOptions.ShowAppointmentStatusVertically = chkStatusOrientation.Checked;
        }
	}
}
