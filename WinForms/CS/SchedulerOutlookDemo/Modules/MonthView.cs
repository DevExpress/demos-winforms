using DevExpress.XtraScheduler.Demos.DemoData;
using DevExpress.XtraScheduler.Localization;
using DevExpress.XtraScheduler.Native;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class MonthViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {

        public MonthViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            HideUnusedViews();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        protected override Control OptionsPane { get { return this.spOptionPanel; } }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.chkStartTimeVisibility.CheckState = CheckState.Unchecked;
                this.chkEndTimeVisibility.CheckState = CheckState.Unchecked;

                this.chkCompressWeekEnd.Checked = false;
                this.chkShowWeekend.Checked = true;
                this.chkCompressWeekEnd.Enabled = this.chkShowWeekend.Checked;
                this.chkStretchAppointments.Enabled = !this.chkCompressWeekEnd.Checked;
                this.cbStretchAppointmentsMode.EditValue = StretchAppointmentsMode.GrowAndShrink;
                this.chkStatusOrientation.Checked = true;

                this.cbTimeDisplayType.EditValue = AppointmentTimeDisplayType.Text;
                this.cbStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.spinWeekCount.EditValue = 4;
                this.chkStretchAppointments.Checked = Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointments;
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        internal override void UpdateOptionsFromControl() {
            base.UpdateOptionsFromControl();
            Scheduler.BeginUpdate();
            try {
                this.chkCompressWeekEnd.Checked = Scheduler.MonthView.CompressWeekend;
                this.chkShowWeekend.Checked = Scheduler.MonthView.ShowWeekend;
                this.chkCompressWeekEnd.Enabled = this.chkShowWeekend.Checked;
                this.chkStretchAppointments.Enabled = !this.chkCompressWeekEnd.Checked;
                this.spinWeekCount.EditValue = Scheduler.MonthView.WeekCount;
                this.chkStartTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(Scheduler.MonthView.AppointmentDisplayOptions.StartTimeVisibility);
                this.chkEndTimeVisibility.CheckState = DemoUtils.TimeVisibilityToCheckState(Scheduler.MonthView.AppointmentDisplayOptions.EndTimeVisibility);
                this.cbTimeDisplayType.EditValue = Scheduler.MonthView.AppointmentDisplayOptions.TimeDisplayType;
                this.cbStatus.EditValue = Scheduler.MonthView.AppointmentDisplayOptions.StatusDisplayType;
                this.cbStretchAppointmentsMode.EditValue = Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointmentsMode;
                this.chkStatusOrientation.Checked = Scheduler.MonthView.AppointmentDisplayOptions.ShowAppointmentStatusVertically;
                this.chkStretchAppointments.Checked = Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointments;
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        protected override IEnumerable<string> GetGlobalOptionIgnoreList() {
            return new string[] {
                "CompressWeekEnd",
                "ShowWeekEnd",
                "ShowStartTime",
                "ShowEndTime",
                "AppointmentStatusDisplayType",
                "ShowAppointmentStatusVertically",
            };
        }

        void MonthViewModule_Load(object sender, System.EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start.AddDays(-7);
            SchedulerDataHelper.Attach(this.schedulerControl);
            ResetOptions();
        }

        void chkCompressWeekEnd_CheckedChanged(object sender, System.EventArgs e) {
            Scheduler.MonthView.CompressWeekend = this.chkCompressWeekEnd.Checked;
            this.chkStretchAppointments.Enabled = !this.chkCompressWeekEnd.Checked;
        }

        void chkShowWeekend_CheckedChanged(object sender, System.EventArgs e) {
            Scheduler.MonthView.ShowWeekend = this.chkShowWeekend.Checked;
            this.chkCompressWeekEnd.Enabled = this.chkShowWeekend.Checked;
        }

        void spinWeekCount_EditValueChanged(object sender, System.EventArgs e) {
            Scheduler.MonthView.WeekCount = Convert.ToInt32(this.spinWeekCount.EditValue);
        }

        void MonthViewModule_VisibleChanged(object sender, System.EventArgs e) {
            Scheduler.ActiveViewType = SchedulerViewType.Month;
        }

        void chkStartTimeVisibility_CheckStateChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.StartTimeVisibility = DemoUtils.CheckStateToTimeVisibility(this.chkStartTimeVisibility.CheckState);
        }

        void chkEndTimeVisibility_CheckStateChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.EndTimeVisibility = DemoUtils.CheckStateToTimeVisibility(this.chkEndTimeVisibility.CheckState);
        }

        void cbTimeDisplayType_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.TimeDisplayType = (AppointmentTimeDisplayType)this.cbTimeDisplayType.EditValue;
        }

        void cbStatus_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
        }

        void chkStatusOrientation_CheckedChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.ShowAppointmentStatusVertically = this.chkStatusOrientation.Checked;
        }

        void chkStretchAppointments_CheckedChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointments = this.chkStretchAppointments.Checked;
        }

        void HideUnusedViews() {
            this.schedulerControl.DayView.Enabled = true;
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.WorkWeekView.Enabled = false;
            this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
            this.schedulerControl.YearView.Enabled = false;
        }

        void chkCustomSort_CheckedChanged(object sender, EventArgs e) {
            if (this.chkCustomSort.Checked) {
                Scheduler.CustomAppointmentSort += CustomAppointmentSort;
                this.chkCustomGroup.Checked = false;
            }
            else
                Scheduler.CustomAppointmentSort -= CustomAppointmentSort;
            Scheduler.Refresh();
        }

        void chkCustomGroup_CheckedChanged(object sender, EventArgs e) {
            if (this.chkCustomGroup.Checked) {
                Scheduler.CustomAppointmentGroup += CustomAppointmentGroup;
                this.chkCustomSort.Checked = false;
            }
            else
                Scheduler.CustomAppointmentGroup -= CustomAppointmentGroup;
            Scheduler.Refresh();
        }

        void CustomAppointmentSort(object sender, CustomAppointmentSortEventArgs e) {
            IAppointmentLayoutInfo viewInfoX = e.AppointmentLayoutInfo1;
            IAppointmentLayoutInfo viewInfoY = e.AppointmentLayoutInfo2;
            e.Result = viewInfoX.Start.CompareTo(viewInfoY.Start);
            if (e.Result != 0)
                return;
            e.Result = -viewInfoX.End.CompareTo(viewInfoY.End);
            if (e.Result != 0)
                return;
            Appointment aptX = viewInfoX.Appointment;
            Appointment aptY = viewInfoY.Appointment;
            e.Result = ((int)aptX.LabelKey).CompareTo((int)aptY.LabelKey);
            if (e.Result != 0)
                return;
            e.Result = aptX.Start.CompareTo(aptY.Start);
            if (e.Result != 0)
                return;
            e.Result = -aptX.End.CompareTo(aptY.End);
        }

        void CustomAppointmentGroup(object sender, CustomAppointmentGroupEventArgs e) {
            e.GroupKey = (int)e.AppointmentLayoutInfo.Appointment.LabelKey;
        }

        private void cbStretchAppointmentsMode_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.MonthView.AppointmentDisplayOptions.StretchAppointmentsMode = (StretchAppointmentsMode)this.cbStretchAppointmentsMode.EditValue;
        }

        private void schedulerControl_AppointmentFlyoutShowing(object sender, AppointmentFlyoutShowingEventArgs e) {             
            AppointmentStatus status = schedulerDataStorage.Appointments.Statuses.GetById(e.FlyoutData.Appointment.StatusKey);
            string statusImage = status.Type.ToString();               
            e.HtmlTemplate.Styles += String.Format(".colorized-area {{\n  background-color: #{0:X};\n}}\n.with-status {{\n  background-image: url(\"{1}\")",
                e.FlyoutData.SubjectAppearance.BackColor.ToArgb(), statusImage);
        }

        private void schedulerControl_CustomAppointmentFlyoutTemplateValue(object sender, CustomAppointmentFlyoutTemplateValueEventArgs e) {
            if("Reminder".Equals(e.FieldName)) {
                if(e.Appointment.HasReminder) {
                    e.FieldValue = HumanReadableTimeSpanHelper.ToString(e.Appointment.Reminder.TimeBeforeStart);
                }
                else {
                    e.FieldValue = SchedulerLocalizer.GetString(SchedulerStringId.Caption_NoneReminder);
                }
            }
        }
    }
}
