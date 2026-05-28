using System;
using DevExpress.XtraScheduler;

namespace DevExpress.XtraScheduler.Demos {
    public partial class DayViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public DayViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            PrepareViews();            
            this.spinDaysCount.EditValueChanged += new System.EventHandler(this.spinDaysCount_EditValueChanged);
            // TODO: Add any initialization after the InitializeComponent call
        }
        
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
        protected DayViewAppointmentDisplayOptions DisplayOptions { get { return (DayViewAppointmentDisplayOptions)schedulerControl.DayView.AppointmentDisplayOptions; } }
        TimeIndicatorDisplayOptions TimeIndicatorDisplayOptions { get { return (TimeIndicatorDisplayOptions)schedulerControl.DayView.TimeIndicatorDisplayOptions; } }

        void PrepareViews() {
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.WorkWeekView.Enabled = false;
            this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
        }
        private void DayViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
            UpdateControls();
        }

        private void UpdateControls() {
            chkShowRightTimeRuler.Checked = true;
            chkShowWorkTimeOnly.Checked = schedulerControl.DayView.ShowWorkTimeOnly;
            chkShowAllDayArea.Checked = schedulerControl.DayView.ShowAllDayArea;
            chkShowDayHeaders.Checked = schedulerControl.DayView.ShowDayHeaders;
            chkAppointmentShadows.Checked = DisplayOptions.ShowShadows;
            chkShowOverAppointment.Checked = TimeIndicatorDisplayOptions.ShowOverAppointment;
            spinDaysCount.EditValue = schedulerControl.DayView.DayCount;

            cbAllDayStatus.EditValue = DisplayOptions.AllDayAppointmentsStatusDisplayType;
            cbStatus.EditValue = DisplayOptions.StatusDisplayType;
            cbSnapToCellsMode.EditValue = DisplayOptions.SnapToCellsMode;
            cbTimeIndicatorVisibility.EditValue = TimeIndicatorDisplayOptions.Visibility;
            cbTimeMarkerVisibility.EditValue = schedulerControl.DayView.TimeMarkerVisibility;
        }
        private void chkShowWorkTimeOnly_CheckedChanged(object sender, System.EventArgs e) {
            schedulerControl.DayView.ShowWorkTimeOnly = chkShowWorkTimeOnly.Checked;
        }

        private void chkShowAllDayArea_CheckedChanged(object sender, System.EventArgs e) {
            schedulerControl.DayView.ShowAllDayArea = chkShowAllDayArea.Checked;
        }

        private void chkShowDayHeaders_CheckedChanged(object sender, System.EventArgs e) {
            schedulerControl.DayView.ShowDayHeaders = chkShowDayHeaders.Checked;
        }

        private void chkAppointmentShadows_CheckedChanged(object sender, System.EventArgs e) {
            schedulerControl.DayView.AppointmentDisplayOptions.ShowShadows = chkAppointmentShadows.Checked;
        }

        private void spinDaysCount_EditValueChanged(object sender, System.EventArgs e) {
            schedulerControl.DayView.DayCount = Convert.ToInt32(spinDaysCount.EditValue);
        }

        private void schedulerControl_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu) {
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
            }
        }
        private void DayViewModule_VisibleChanged(object sender, System.EventArgs e) {
            schedulerControl.ActiveViewType = SchedulerViewType.Day;
        }

        private void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
            DisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
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
            schedulerControl.DayView.TimeMarkerVisibility = (TimeMarkerVisibility)cbTimeMarkerVisibility.EditValue;
        }

        private void chkShowRightTimeRuler_CheckedChanged(object sender, EventArgs e) {
            int timeRulersCount = schedulerControl.DayView.TimeRulers.Count;
            for (int i = 0; i < timeRulersCount; i++) {
                TimeRuler timeRuler = schedulerControl.DayView.TimeRulers[i];
                if (timeRuler.HorizontalAlignment == TimeRulerHorizontalAlignment.Far)
                    timeRuler.Visible = chkShowRightTimeRuler.Checked;
            }
        }

        private void chkStatusOrientation_CheckedChanged(object sender, EventArgs e) {
            schedulerControl.DayView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = chkStatusOrientation.Checked;
        }
    }
}

