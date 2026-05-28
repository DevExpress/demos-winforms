using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class TimelineViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {

		public TimelineViewModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			PrepareViews();
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected AppointmentDisplayOptions DisplayOptions { get { return schedulerControl.TimelineView.AppointmentDisplayOptions; } }
        TimeIndicatorDisplayOptions TimeIndicatorDisplayOptions { get { return (TimeIndicatorDisplayOptions)schedulerControl.TimelineView.TimeIndicatorDisplayOptions; } }

		void PrepareViews() {
			this.schedulerControl.DayView.Enabled = true;
			this.schedulerControl.WeekView.Enabled = false;
			this.schedulerControl.WorkWeekView.Enabled = false;
			this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
        }

		private void TimelineViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
            UpdateControls();
		}
		private void TimelineViewModule_VisibleChanged(object sender, System.EventArgs e) {
			schedulerControl.ActiveViewType = SchedulerViewType.Timeline;
		}
		void UpdateControls() {
			AppointmentDisplayOptions options = DisplayOptions;
			chkAutoHeight.Checked = options.AppointmentAutoHeight;
			spinHeight.Value = options.AppointmentHeight;
			cbSnapToCellsMode.EditValue = options.SnapToCellsMode;
			cbStatus.EditValue = options.StatusDisplayType;
			chkSelectionBarVisible.Checked = schedulerControl.TimelineView.SelectionBar.Visible;
			spinSelectionBarHeight.Value = schedulerControl.TimelineView.SelectionBar.Height;
            UpdateTimeScaleWidthTrackBar();
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment;
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility;
		}

        private void UpdateTimeScaleWidthTrackBar() {
            trckScaleWidth.Value = schedulerControl.TimelineView.GetBaseTimeScale().Width;
            trckScaleWidth.Enabled = schedulerControl.TimelineView.Scales.Count > 0;
        }
        private void chkSelectionBarVisible_CheckedChanged(object sender, EventArgs e) {
			schedulerControl.TimelineView.SelectionBar.Visible = chkSelectionBarVisible.Checked;
		}
		private void spinSelectionBarHeight_EditValueChanged(object sender, EventArgs e) {
			schedulerControl.TimelineView.SelectionBar.Height = Convert.ToInt32(spinSelectionBarHeight.Value);
		}
		private void btnEditScales_Click(object sender, EventArgs e) {
			EditTimeScales(schedulerControl.TimelineView.Scales);
            UpdateTimeScaleWidthTrackBar();
		}
		void EditTimeScales(TimeScaleCollection scales) {
			TimeScalesEditForm frm = new TimeScalesEditForm(scales, this.FindForm());
			frm.ShowDialog();
		}
		private void chkAutoHeight_CheckedChanged(object sender, EventArgs e) {
			DisplayOptions.AppointmentAutoHeight = chkAutoHeight.Checked;
		}

		private void spinHeight_EditValueChanged(object sender, EventArgs e) {
			DisplayOptions.AppointmentHeight = Convert.ToInt32(spinHeight.Value);
		}

		private void cbStatus_EditValueChanged(object sender, EventArgs e) {
            if (!typeof(AppointmentStatusDisplayType).IsAssignableFrom(this.cbStatus.EditValue.GetType()))
                return;
            DisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)cbStatus.EditValue;
		}

		private void cbSnapToCellsMode_EditValueChanged(object sender, EventArgs e) {
			DisplayOptions.SnapToCellsMode = (AppointmentSnapToCellsMode)cbSnapToCellsMode.EditValue;
		}

        private void trckScaleWidth_EditValueChanged(object sender, EventArgs e) {
            schedulerControl.TimelineView.GetBaseTimeScale().Width = trckScaleWidth.Value;
        }

        private void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked;
        }

        private void cbTimeIndicatorVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)cbTimeIndicatorVisibility.EditValue;
        }

        private void chkStatusOrientation_CheckedChanged(object sender, EventArgs e) {
            TimelineViewAppointmentDisplayOptionsEx timelineViewOptions = DisplayOptions as TimelineViewAppointmentDisplayOptionsEx;
            if(timelineViewOptions != null) timelineViewOptions.ShowAppointmentStatusVertically = chkStatusOrientation.Checked;
        }
	}
}
