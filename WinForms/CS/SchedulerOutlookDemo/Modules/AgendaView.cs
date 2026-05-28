using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Demos.DemoData;

namespace DevExpress.XtraScheduler.Demos {
    public partial class AgendaViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        const string AppointmentCss = @"
.subject {
    font-size: 1em;
    font-weight: bold;
}
.description {
    font-size: 1em;
}
.location {
    font-weight: bold;
}
";
        const string AppointmentTemplate = @"
            <div class=""subject"">${Appointment.Subject}</div>
            <p class=""description"">${Appointment.Description}</p>
            <p class=""location"">${Appointment.Location}</p>
";
        public AgendaViewModule() {
            InitializeComponent();
            HideUnusedViews();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }

        void AgendaViewModule_Load(object sender, System.EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(Scheduler);
            ResetOptions();
        }
        
        void spinDaysCount_EditValueChanged(object sender, System.EventArgs e) {
            Scheduler.AgendaView.DayCount = Convert.ToInt32(this.spinDaysCount.EditValue);
        }

        void cbStatus_EditValueChanged(object sender, EventArgs e) {
            if (!typeof(AppointmentStatusDisplayType).IsAssignableFrom(this.cbStatus.EditValue.GetType()))
                return;
            Scheduler.AgendaView.AppointmentDisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
        }

        void ceShowLabel_CheckedChanged(object sender, EventArgs e) {
            Scheduler.AgendaView.AppointmentDisplayOptions.ShowLabel = this.ceShowLabel.Checked;
        }

        void ceShowResource_CheckedChanged(object sender, EventArgs e) {
            Scheduler.AgendaView.AppointmentDisplayOptions.ShowResource = this.ceShowResource.Checked;
        }

        void chkAllowHtml_CheckedChanged(object sender, EventArgs e) {
            if (this.chkAllowHtmlText.Checked) {
                this.schedulerControl.AgendaView.HtmlTemplates.Appointment.Template = AppointmentTemplate;
                this.schedulerControl.AgendaView.HtmlTemplates.Appointment.Styles = AppointmentCss;
            } else {
                this.schedulerControl.AgendaView.HtmlTemplates.Appointment.Template = String.Empty;
                this.schedulerControl.AgendaView.HtmlTemplates.Appointment.Styles = String.Empty;
            }
            Scheduler.AgendaView.AppointmentDisplayOptions.AllowMultiLineSubject = this.chkAllowHtmlText.Checked;
        }

        void HideUnusedViews() {
            Scheduler.AgendaView.Enabled = true;
            Scheduler.FullWeekView.Enabled = false;
            Scheduler.DayView.Enabled = false;
            Scheduler.WeekView.Enabled = false;
            Scheduler.MonthView.Enabled = false;
            Scheduler.WorkWeekView.Enabled = false;
            Scheduler.TimelineView.Enabled = false;
            Scheduler.GanttView.Enabled = false;
            Scheduler.YearView.Enabled = false;
        }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.spinDaysCount.EditValue = 10;
                this.cbStatus.EditValue = AppointmentStatusDisplayType.Bounds;
                this.ceShowLabel.Checked = true;
                this.ceShowResource.Checked = false;
                this.chkAllowHtmlText.Checked = true;
            } finally {
                Scheduler.EndUpdate();
            }
        }

        internal override void UpdateOptionsFromControl() {
            base.UpdateOptionsFromControl();
            Scheduler.BeginUpdate();
            try {
                this.spinDaysCount.EditValue = Scheduler.AgendaView.DayCount;
                this.cbStatus.EditValue = Scheduler.AgendaView.AppointmentDisplayOptions.StatusDisplayType;
                this.ceShowLabel.Checked = Scheduler.AgendaView.AppointmentDisplayOptions.ShowLabel;
                this.ceShowResource.Checked = Scheduler.AgendaView.AppointmentDisplayOptions.ShowResource;
                this.chkAllowHtmlText.Checked = Scheduler.AgendaView.HtmlTemplates.Appointment.Template != null;
            } finally {
                Scheduler.EndUpdate();
            }
        }
    }

}
