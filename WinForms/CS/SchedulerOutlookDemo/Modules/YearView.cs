using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Demos.DemoData;
using DevExpress.Utils;

namespace DevExpress.XtraScheduler.Demos {
    public partial class YearViewModule : TutorialControl {
        public YearViewModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            HideUnusedViews();
            this.cbFirstDayOfWeek.Properties.Items.AddEnum(typeof(FirstDayOfWeek));
            this.cbFirstDayOfWeek.EditValue = Scheduler.OptionsView.FirstDayOfWeek;

            this.cbHighlightWeekends.Properties.Items.AddEnum(typeof(DefaultBoolean));
            this.cbHighlightWeekends.EditValue = Scheduler.Views.YearView.HighlightWeekends;

            this.cbShowOutOfScopeDays.Properties.Items.AddEnum(typeof(DefaultBoolean));
            this.cbShowOutOfScopeDays.EditValue = Scheduler.Views.YearView.ShowOutOfScopeDays;

            this.schedulerControl.YearView.AppointmentDisplayOptions.StatusDisplayType = AppointmentStatusDisplayType.Never;

            this.cbStretchAppointmentsMode.EditValue = StretchAppointmentsMode.GrowAndShrink;
            this.chkStretchAppointments.Checked = Scheduler.YearView.AppointmentDisplayOptions.StretchAppointments;
            this.commonRibbon.GroupByRibbonPageGroupVisible = false;
            this.commonRibbon.SwitchViewPageGroupVisible = false;
            UpdateAppointmentHeight();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        public override CommonRibbon CommonRibbonPanel { get { return this.commonRibbon; } }
        protected override Control OptionsPane { get { return this.spOptionPanel; } }

        void OnMonthCountEditValueChanged(object sender, EventArgs e) {
            Scheduler.YearView.MonthCount = (int)this.spinMonthCount.Value;
        }

        void OnFirstDayOfWeekSelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.OptionsView.FirstDayOfWeek = (FirstDayOfWeek)this.cbFirstDayOfWeek.EditValue;
        }
        void cbHighlightWeekends_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.Views.YearView.HighlightWeekends = (DefaultBoolean)this.cbHighlightWeekends.EditValue;
        }
        void cbShowOutOfScopeDays_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.Views.YearView.ShowOutOfScopeDays = (DefaultBoolean)this.cbShowOutOfScopeDays.EditValue;
        }

        void OnAppointmentHeightEditValueChanged(object sender, EventArgs e) {
            UpdateAppointmentHeight();
        }
        void UpdateAppointmentHeight() {
            Scheduler.YearView.AppointmentDisplayOptions.AppointmentHeight = (int)this.spinAppointmentHeight.Value;
        }

        void HideUnusedViews() {
            this.schedulerControl.DayView.Enabled = false;
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.WorkWeekView.Enabled = false;
            this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.AgendaView.Enabled = false;
            this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.YearView.Enabled = true;
        }
        void YearView_Load(object sender, System.EventArgs e) {
            Scheduler.Start = new DateTime(DateTime.Now.Year, 1, 1);
            SchedulerDataHelper.AttachYearView(Scheduler);
            ResetOptions();
        }

        private void cbStretchAppointmentsMode_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.YearView.AppointmentDisplayOptions.StretchAppointmentsMode = (StretchAppointmentsMode)this.cbStretchAppointmentsMode.EditValue;
        }

        private void chkStretchAppointments_CheckedChanged(object sender, EventArgs e) {
            Scheduler.YearView.AppointmentDisplayOptions.StretchAppointments = this.chkStretchAppointments.Checked;
        }
    }
}
