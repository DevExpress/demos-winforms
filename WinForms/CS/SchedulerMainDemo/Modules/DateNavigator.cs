using System;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraScheduler.Demos {
	public partial class DateNavigatorModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public DateNavigatorModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void MonthViewModule_Load(object sender, System.EventArgs e) {
			chkBoldAppointmentDates.Checked = dateNavigator1.BoldAppointmentDates;
			chkShowTodayButton.Checked = dateNavigator1.ShowTodayButton;
			chkShowWeekNumbers.Checked = dateNavigator1.ShowWeekNumbers;
			cbWeekNumberRule.EditValue = dateNavigator1.WeekNumberRule;
            cbNavigationMode.EditValue = dateNavigator1.NavigationMode;
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
        }
		private void chkBoldAppointmentDates_CheckedChanged(object sender, System.EventArgs e) {
			dateNavigator1.BoldAppointmentDates = chkBoldAppointmentDates.Checked;
		}
		private void chkShowTodayButton_CheckedChanged(object sender, System.EventArgs e) {
			dateNavigator1.ShowTodayButton = chkShowTodayButton.Checked;
		}
		private void chkShowWeekNumbers_CheckedChanged(object sender, System.EventArgs e) {
			dateNavigator1.ShowWeekNumbers = chkShowWeekNumbers.Checked;
		}
		private void cbWeekNumberRule_SelectedIndexChanged(object sender, System.EventArgs e) {
			dateNavigator1.WeekNumberRule = (WeekNumberRule)cbWeekNumberRule.EditValue;
		}

        private void cbNavigationMode_SelectedIndexChanged(object sender, EventArgs e) {
            dateNavigator1.NavigationMode = (DateNavigationMode)cbNavigationMode.EditValue;
        }
	}
}
