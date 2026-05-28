using System;
using DevExpress.XtraScheduler;

namespace DevExpress.XtraScheduler.Demos {
    public partial class FullWeekViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public FullWeekViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();

            PrepareViews();
        }

        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl1; } }
		protected DayViewAppointmentDisplayOptions DisplayOptions { get { return (DayViewAppointmentDisplayOptions)schedulerControl1.FullWeekView.AppointmentDisplayOptions; } }
        TimeIndicatorDisplayOptions TimeIndicatorDisplayOptions { get { return (TimeIndicatorDisplayOptions)schedulerControl1.FullWeekView.TimeIndicatorDisplayOptions; } }

        void PrepareViews() {
            this.schedulerControl1.FullWeekView.Enabled = true;
            this.schedulerControl1.DayView.Enabled = false;
            this.schedulerControl1.WeekView.Enabled = false;
            this.schedulerControl1.MonthView.Enabled = false;
            this.schedulerControl1.WorkWeekView.Enabled = false;
            this.schedulerControl1.TimelineView.Enabled = false;
            this.schedulerControl1.GanttView.Enabled = false;
            this.schedulerControl1.AgendaView.Enabled = false;
        }
        private void FullWeekViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl1, schedulerDataStorage);
            chkShowWorkTimeOnly.Checked = schedulerControl1.FullWeekView.ShowWorkTimeOnly;
			chkShowAllDayArea.Checked = schedulerControl1.FullWeekView.ShowAllDayArea;
			chkShowDayHeaders.Checked = schedulerControl1.FullWeekView.ShowDayHeaders;
			chkAppointmentShadows.Checked = DisplayOptions.ShowShadows;
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment;

			cbAllDayStatus.EditValue = DisplayOptions.AllDayAppointmentsStatusDisplayType;
			cbStatus.EditValue = DisplayOptions.StatusDisplayType;
			cbSnapToCellsMode.EditValue = DisplayOptions.SnapToCellsMode;
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility;
            cbTimeMarkerVisibility.EditValue = schedulerControl1.FullWeekView.TimeMarkerVisibility;
        }

		private void chkShowWorkTimeOnly_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl1.FullWeekView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked;
		}

		private void chkShowAllDayArea_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl1.FullWeekView.ShowAllDayArea = chkShowAllDayArea.Checked;
		}

		private void chkShowDayHeaders_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl1.FullWeekView.ShowDayHeaders = chkShowDayHeaders.Checked;
		}

		private void chkAppointmentShadows_CheckedChanged(object sender, System.EventArgs e) {
			schedulerControl1.FullWeekView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked;
		}

		private void schedulerControl_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e) {
			if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu) {
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
			}
		}
		private void FullWeekViewModule_VisibleChanged(object sender, System.EventArgs e) {
			schedulerControl1.ActiveViewType = SchedulerViewType.FullWeek;
		}

		private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)cbStatus.EditValue;
		}

		private void cbAllDayStatus_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.AllDayAppointmentsStatusDisplayType = (AppointmentStatusDisplayType)cbAllDayStatus.EditValue;
		}

		private void cbSnapToCellsMode_SelectedIndexChanged(object sender, EventArgs e) {
			DisplayOptions.SnapToCellsMode = (AppointmentSnapToCellsMode)cbSnapToCellsMode.EditValue;
		}

        private void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked;
        }

        private void cbTimeIndicatorVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)cbTimeIndicatorVisibility.EditValue;
        }

        private void cbTimeMarkerVisibility_SelectedIndexChanged(object sender, EventArgs e) {
	        schedulerControl1.FullWeekView.TimeMarkerVisibility = (TimeMarkerVisibility)cbTimeMarkerVisibility.EditValue;
        }

        private void chkStatusOrientation_CheckedChanged(object sender, EventArgs e) {
            DayViewAppointmentDisplayOptionsEx dayViewOptions = DisplayOptions as DayViewAppointmentDisplayOptionsEx;
            if(dayViewOptions != null) dayViewOptions.ShowAllDayAppointmentStatusVertically = chkStatusOrientation.Checked;
        }	
    }
}
