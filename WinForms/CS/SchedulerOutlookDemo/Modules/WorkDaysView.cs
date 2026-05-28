using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Demos.DemoData;

namespace DevExpress.XtraScheduler.Demos {
    public partial class WorkWeekViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {

        public WorkWeekViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            HideUnusedViews();
            this.weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays;
            this.weekDaysCheckEdit1.MinimumSize = new System.Drawing.Size(0, 20);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(0, 20);
        }
        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        public override CommonRibbon CommonRibbonPanel { get { return this.commonRibbon1; } }
        protected override Control OptionsPane { get { return this.spOptionsPane; } }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.chkShowOverAppointment.Checked = true;
                this.cbTimeIndicatorVisibility.EditValue = TimeIndicatorVisibility.DaysBeforeToday;
                this.cbTimeMarkerVisibility.EditValue = TimeMarkerVisibility.TodayView;
                this.cbTimeMarkerStyle.EditValue = TimeMarkerStyle.Default;
                this.weekDaysCheckEdit1.WeekDays = WeekDays.WorkDays;
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        internal override void UpdateOptionsFromControl() {
            base.UpdateOptionsFromControl();
            Scheduler.BeginUpdate();
            try {
                this.chkShowWorkTimeOnly.Checked = Scheduler.WorkWeekView.ShowWorkTimeOnly;
                this.chkShowOverAppointment.Checked = Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment;
                this.cbTimeIndicatorVisibility.EditValue = Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.Visibility;
                this.cbTimeMarkerVisibility.EditValue = Scheduler.WorkWeekView.TimeMarkerVisibility;
                this.cbTimeMarkerStyle.EditValue = Scheduler.WorkWeekView.TimeMarkerStyle;
                this.weekDaysCheckEdit1.WeekDays = this.schedulerControl.WorkDays.GetWeekDays();
            }
            finally {
                Scheduler.EndUpdate();
            }
        }
        
        protected override IEnumerable<string> GetGlobalOptionIgnoreList() {
            return new string[] {
                "ShowTimeIndicatorOverAppointment",
                "TimeMarkerVisibility",
                "WorkDays"
            };
        }

        void WorkWeekViewModule_Load(object sender, System.EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(this.schedulerControl);
            TimeRegionHelper.Attach(Scheduler);
            ResetOptions();
        }

        void schedulerControl_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e) {
            if (e.Menu.Id == SchedulerMenuItemId.DefaultMenu || e.Menu.Id == SchedulerMenuItemId.RulerMenu)
                e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu);
        }

        void WorkWeekViewModule_VisibleChanged(object sender, System.EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.WorkWeek;
        }

        void chkShowOverAppointment_CheckedChanged(object sender, EventArgs e) {
            Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.ShowOverAppointment = this.chkShowOverAppointment.Checked;
        }

        void cbTimeIndicatorVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.WorkWeekView.TimeIndicatorDisplayOptions.Visibility = (TimeIndicatorVisibility)this.cbTimeIndicatorVisibility.EditValue;
        }

        void cbTimeMarkerVisibility_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.WorkWeekView.TimeMarkerVisibility = (TimeMarkerVisibility)this.cbTimeMarkerVisibility.EditValue;
        }
        void cbTimeMarkerStyle_EditValueChanged(object sender, EventArgs e) {
            Scheduler.WorkWeekView.TimeMarkerStyle = (TimeMarkerStyle)this.cbTimeMarkerStyle.EditValue;
        }
        void chkShowWorkTimeOnly_CheckedChanged(object sender, EventArgs e) {
            Scheduler.WorkWeekView.ShowWorkTimeOnly = this.chkShowWorkTimeOnly.Checked;
        }

        void weekDaysCheckEdit1_WeekDaysChanged(object sender, EventArgs e) {
            WeekDays weekDays = this.weekDaysCheckEdit1.WeekDays;
            WorkDaysCollection workDays = this.schedulerControl.WorkDays;
            workDays.BeginUpdate();
            workDays.Clear();
            if (!weekDays.Equals((WeekDays)0))
                workDays.Add(new WeekDaysWorkDay(weekDays));
            workDays.EndUpdate();
        }

        void HideUnusedViews() {
            this.schedulerControl.DayView.Enabled = false;
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
            this.schedulerControl.YearView.Enabled = false;
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
    }
}

