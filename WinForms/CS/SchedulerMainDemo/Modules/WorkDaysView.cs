using System;
using DevExpress.XtraScheduler;

namespace DevExpress.XtraScheduler.Demos {
	public partial class WorkWeekViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        TimeIndicatorDisplayOptions TimeIndicatorDisplayOptions { get { return (TimeIndicatorDisplayOptions)schedulerControl.WorkWeekView.TimeIndicatorDisplayOptions; } }
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        public WorkWeekViewModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			PrepareViews();
			weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays;
		}

		void PrepareViews() {
			this.schedulerControl.DayView.Enabled = false;
			this.schedulerControl.WeekView.Enabled = false;
			this.schedulerControl.MonthView.Enabled = false;
			this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
        }
		private void WorkWeekViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment;
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility;
            cbTimeMarkerVisibility.EditValue = schedulerControl.WorkWeekView.TimeMarkerVisibility;
		}

		void weekDaysCheckEdit1_WeekDaysChanged(object sender, System.EventArgs e) {
			WorkDaysCollection workDays = schedulerControl.WorkDays;
			workDays.BeginUpdate();
			workDays.Clear();
			if (weekDaysCheckEdit1.WeekDays != (WeekDays)0)
				workDays.Add(new WeekDaysWorkDay(weekDaysCheckEdit1.WeekDays));
			workDays.EndUpdate();
		}

		private void schedulerControl_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e) {
			if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu) {
				e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
			}
		}

		private void WorkWeekViewModule_VisibleChanged(object sender, System.EventArgs e) {
			schedulerControl.ActiveViewType = SchedulerViewType.WorkWeek;
		}

        private void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.ShowOverAppointment = chkShowOverAppointment.Checked;
        }

        private void cbTimeIndicatorVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)cbTimeIndicatorVisibility.EditValue;
        }

        private void cbTimeMarkerVisibility_SelectedIndexChanged(object sender, EventArgs e) {
	        schedulerControl.WorkWeekView.TimeMarkerVisibility = (TimeMarkerVisibility)cbTimeMarkerVisibility.EditValue;
        }	
	}
}
