using DevExpress.Utils.Menu;
using DevExpress.XtraScheduler.Commands;
using System;

namespace DevExpress.XtraScheduler.Demos {
	public partial class TimeZonesModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public TimeZonesModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();
            this.schedulerControl.PopupMenuShowing += schedulerControl_PopupMenuShowing;
			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

		private void TimeZonesModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
            UpdateControls();
		}

		private void UpdateControls() {
			schedulerControl.DayView.TimeRulers[1].UseClientTimeZone = false;
			schedulerControl.WorkWeekView.TimeRulers[1].UseClientTimeZone = false;
			edtTimeZone.TimeZoneId = schedulerControl.OptionsBehavior.ClientTimeZoneId;
		}
		private void edtTimeZone_EditValueChanged(object sender, EventArgs e) {
			schedulerControl.OptionsBehavior.ClientTimeZoneId = edtTimeZone.TimeZoneId;
			string caption = schedulerControl.OptionsBehavior.ClientTimeZoneId.ToString();
			schedulerControl.DayView.TimeRulers[2].Caption = caption;
			schedulerControl.WorkWeekView.TimeRulers[2].Caption = caption;
            schedulerControl.FullWeekView.TimeRulers[2].Caption = caption;
		}
        private void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == DevExpress.XtraScheduler.SchedulerMenuItemId.AppointmentMenu) {
                SplitAppointmentOperationCommand command = new SplitAppointmentOperationCommand(schedulerControl);
                SchedulerMenuItemCommandWinAdapter menuItemCommandAdapter = new SchedulerMenuItemCommandWinAdapter(command);
                DXMenuItem menuItem = (DXMenuItem)menuItemCommandAdapter.CreateMenuItem(DXMenuItemPriority.Normal);
                menuItem.BeginGroup = true;
                e.Menu.Items.Add(menuItem);
            }
        }
	}
}

