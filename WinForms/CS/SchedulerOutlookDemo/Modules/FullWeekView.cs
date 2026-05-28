using DevExpress.XtraEditors;
using DevExpress.XtraScheduler.Demos.DemoData;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class FullWeekViewModule : TutorialControl {
        public FullWeekViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            HideUnusedViews();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl1; } }
        public override CommonRibbon CommonRibbonPanel { get { return this.commonRibbon1; } }
        protected override Control OptionsPane { get { return this.spOptionPanel; } }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.chkShowWorkTimeOnly.Checked = true;
                this.chkShowAllDayArea.Checked = true;
                this.chkShowDayHeaders.Checked = true;
                this.chkAppointmentShadows.Checked = false;
                this.chkShowOverAppointment.Checked = true;
                this.chkStatusOrientation.Checked = true;
                this.chkStretchAppointments.Checked = true;
                this.cbAllDayStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.cbStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.cbSnapToCellsMode.EditValue = AppointmentSnapToCellsMode.Auto;
                this.cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.DaysBeforeToday;
                this.cbTimeMarkerVisibility.EditValue = TimeMarkerVisibility.TodayView;
                this.cbTimeMarkerStyle.EditValue = TimeMarkerStyle.Default;
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        internal override void UpdateOptionsFromControl() {
            base.UpdateOptionsFromControl();
            Scheduler.BeginUpdate();
            try {
                this.chkShowWorkTimeOnly.Checked = Scheduler.FullWeekView.ShowWorkTimeOnly;
                this.chkShowAllDayArea.Checked = Scheduler.FullWeekView.ShowAllDayArea;
                this.chkShowDayHeaders.Checked = Scheduler.FullWeekView.ShowDayHeaders;
                this.chkAppointmentShadows.Checked = Scheduler.FullWeekView.AppointmentDisplayOptions.ShowShadows;
                this.cbStatus.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.StatusDisplayType;
                this.cbAllDayStatus.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType;
                this.cbSnapToCellsMode.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.SnapToCellsMode;
                this.chkShowOverAppointment.Checked = Scheduler.FullWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment;
                this.cbTimeIndicatorVisibility.EditValue = Scheduler.FullWeekView.TimeIndicatorDisplayOptions.Visibility;
                this.cbTimeMarkerVisibility.EditValue = Scheduler.FullWeekView.TimeMarkerVisibility;
                this.cbTimeMarkerStyle.EditValue = Scheduler.FullWeekView.TimeMarkerStyle;
                this.chkStatusOrientation.Checked = Scheduler.FullWeekView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically;
                this.cbColumnWidthMode.EditValue = Scheduler.FullWeekView.ColumnWidthMode;
                this.spinColumnWidth.EditValue = Scheduler.FullWeekView.ColumnWidth;
                this.spinAppointmentWidth.EditValue = Scheduler.FullWeekView.AppointmentDisplayOptions.AppointmentWidth;
                this.chkStretchAppointments.Checked = Scheduler.FullWeekView.AppointmentDisplayOptions.StretchAppointments;
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        protected override IEnumerable<string> GetGlobalOptionIgnoreList() {
            return new string[] {
                "ShowAllDayArea",
                "ShowDayHeaders",
                "AppointmentStatusDisplayType",
                "ShowTimeIndicatorOverAppointment",
                "TimeMarkerVisibility",
                "ShowAllDayAppointmentStatusVertically",
            };
        }

        void FullWeekViewModule_Load(object sender, System.EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(this.schedulerControl1);
            TimeRegionHelper.Attach(Scheduler);
            ResetOptions();
        }

        void chkShowWorkTimeOnly_CheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.ShowWorkTimeOnly = this.chkShowWorkTimeOnly.Checked;
        }

        void chkShowAllDayArea_CheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.ShowAllDayArea = this.chkShowAllDayArea.Checked;
        }

        void chkShowDayHeaders_CheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.ShowDayHeaders = this.chkShowDayHeaders.Checked;
        }

        void chkAppointmentShadows_CheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.AppointmentDisplayOptions.ShowShadows = this.chkAppointmentShadows.Checked;
        }

        void schedulerControl_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu)
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
        }

        void FullWeekViewModule_VisibleChanged(object sender, EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.FullWeek;
        }

        void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.AppointmentDisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
        }

        void cbAllDayStatus_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.AppointmentDisplayOptions.AllDayAppointmentsStatusDisplayType = (AppointmentStatusDisplayType)this.cbAllDayStatus.EditValue;
        }

        void cbSnapToCellsMode_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.AppointmentDisplayOptions.SnapToCellsMode = (AppointmentSnapToCellsMode)this.cbSnapToCellsMode.EditValue;
        }

        void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = this.chkShowOverAppointment.Checked;
        }

        void cbTimeIndicatorVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)this.cbTimeIndicatorVisibility.EditValue;
        }

        void cbTimeMarkerVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.TimeMarkerVisibility = (TimeMarkerVisibility)this.cbTimeMarkerVisibility.EditValue;
        }
        void cbTimeMarkerStyle_EditValueChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.TimeMarkerStyle = (TimeMarkerStyle)this.cbTimeMarkerStyle.EditValue;
        }
        void chkStatusOrientation_CheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.AppointmentDisplayOptions.ShowAllDayAppointmentStatusVertically = this.chkStatusOrientation.Checked;
        }

        void HideUnusedViews() {
            this.schedulerControl1.FullWeekView.Enabled = true;
            this.schedulerControl1.DayView.Enabled = false;
            this.schedulerControl1.WeekView.Enabled = false;
            this.schedulerControl1.MonthView.Enabled = false;
            this.schedulerControl1.WorkWeekView.Enabled = false;
            this.schedulerControl1.TimelineView.Enabled = false;
            this.schedulerControl1.GanttView.Enabled = false;
            this.schedulerControl1.AgendaView.Enabled = false;
            this.schedulerControl1.YearView.Enabled = false;
        }

        void chkCustomGroup_CheckedChanged(object sender, EventArgs e) {
            if (this.chkCustomGroup.Checked)
                Scheduler.CustomAppointmentGroup += CustomAppointmentGroup;
            else
                Scheduler.CustomAppointmentGroup -= CustomAppointmentGroup;
            Scheduler.Refresh();
        }

        void CustomAppointmentGroup(object sender, CustomAppointmentGroupEventArgs e) {
            e.GroupKey = (int)e.AppointmentLayoutInfo.Appointment.LabelKey;
        }

        void cbColumnWidthModeEditValueChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.ColumnWidthMode = (ColumnWidthMode)this.cbColumnWidthMode.EditValue;
            this.spinColumnWidth.Enabled = Scheduler.FullWeekView.ColumnWidthMode == ColumnWidthMode.Fixed;
            this.spinAppointmentWidth.Enabled = Scheduler.FullWeekView.ColumnWidthMode == ColumnWidthMode.Auto;
        }

        void spinColumnWidthEditValueChanged(object sender, EventArgs e) {
            SpinEdit spinEdit = (SpinEdit)sender;
            int value = (int)spinEdit.Value;
            if (value < 0)
                return;
            Scheduler.FullWeekView.ColumnWidth = value;
        }

        void spinAppointmentWidthEditValueChanged(object sender, EventArgs e) {
            SpinEdit spinEdit = (SpinEdit)sender;
            int value = (int)spinEdit.Value;
            if (value < 0)
                return;
            Scheduler.FullWeekView.AppointmentDisplayOptions.AppointmentWidth = value;
        }

        void chkStretchAppointmentsCheckedChanged(object sender, EventArgs e) {
            Scheduler.FullWeekView.AppointmentDisplayOptions.StretchAppointments = this.chkStretchAppointments.Checked;
        }
    }
}
