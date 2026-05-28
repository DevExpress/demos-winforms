using System;
using DevExpress.XtraScheduler;

namespace DevExpress.XtraScheduler.Demos {

    public partial class AgendaViewModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public AgendaViewModule() {
            InitializeComponent();
            PrepareViews();
        }

        void AgendaViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage1);
            UpdateControls();
        }

        void PrepareViews() {
            this.schedulerControl.AgendaView.Enabled = true;
            this.schedulerControl.FullWeekView.Enabled = false;
            this.schedulerControl.DayView.Enabled = false;
            this.schedulerControl.WeekView.Enabled = false;
            this.schedulerControl.MonthView.Enabled = false;
            this.schedulerControl.WorkWeekView.Enabled = false;
            this.schedulerControl.TimelineView.Enabled = false;
            this.schedulerControl.GanttView.Enabled = false;
        }

        private void UpdateControls() {
            this.spinDaysCount.EditValue = schedulerControl.AgendaView.DayCount;
            this.cbStatus.EditValue = this.schedulerControl.AgendaView.AppointmentDisplayOptions.StatusDisplayType;
            this.ceShowLabel.Checked = this.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowLabel;
            this.ceShowResource.Checked = this.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowResource;
        }

        private void spinDaysCount_EditValueChanged(object sender, System.EventArgs e) {
            schedulerControl.AgendaView.DayCount = Convert.ToInt32(spinDaysCount.EditValue);
        }

        private void cbStatus_EditValueChanged(object sender, EventArgs e) {
            if (!typeof(AppointmentStatusDisplayType).IsAssignableFrom(this.cbStatus.EditValue.GetType()))
                return;
            this.schedulerControl.AgendaView.AppointmentDisplayOptions.StatusDisplayType = (AppointmentStatusDisplayType)this.cbStatus.EditValue;
        }

        private void ceShowLabel_CheckedChanged(object sender, EventArgs e) {
            this.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowLabel = this.ceShowLabel.Checked;
        }

        private void ceShowResource_CheckedChanged(object sender, EventArgs e) {
            this.schedulerControl.AgendaView.AppointmentDisplayOptions.ShowResource = this.ceShowResource.Checked;
        }
    }

}
