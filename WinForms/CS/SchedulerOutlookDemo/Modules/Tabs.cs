using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraScheduler.Demos;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Demos.DemoData;

namespace DevExpress.XtraScheduler.Demos {
    public partial class Tabs : TutorialControl {
        public Tabs() {
            InitializeComponent();
            HideUnusedViews();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl; } }

        void Tabs_Load(object sender, EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(Scheduler, false);
            ResetOptions();
        }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            GroupByParentId();
            Scheduler.DayView.DayCount = 3;
            Scheduler.GroupType = SchedulerGroupType.Resource;
            Scheduler.DayView.ResourcesPerPage = 2;
            Scheduler.DayView.ShowWorkTimeOnly = true;
            Scheduler.WorkWeekView.ShowWorkTimeOnly = true;
            Scheduler.WorkWeekView.ResourcesPerPage = 2;
            Scheduler.FullWeekView.ShowWorkTimeOnly = true;
            Scheduler.FullWeekView.ResourcesPerPage = 2;
            this.cmbAppointmentDisplayMode.EditValue = AppointmentDisplayMode.AllResources;
            this.cmbResourceDisplayStyle.EditValue = ResourceDisplayStyle.Tabs;
            this.chkShowAddButton.Checked = Scheduler.OptionsView.ResourceCategories.ShowAddButton;
            this.chkShowCloseButton.Checked = Scheduler.OptionsView.ResourceCategories.ShowCloseButton;
            Scheduler.EndUpdate();
        }

        void GroupByParentId() {
            var categories = this.schedulerDataStorage1.Resources.Items
                .GroupBy(x => x.ParentId ?? x.Id)
                .Select(x => new ResourceCategory(x));
            foreach (ResourceCategory category in categories)
                Scheduler.ResourceCategories.Add(category);
        }

        void HideUnusedViews() {
            this.schedulerControl.AgendaView.Enabled = false;
        }

        void cmbAppointmentDisplayMode_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.OptionsView.ResourceCategories.AppointmentDisplayMode = (AppointmentDisplayMode)this.cmbAppointmentDisplayMode.EditValue;
        }

        void cmbResourceDisplayStyle_SelectedIndexChanged(object sender, EventArgs e) {
            Scheduler.OptionsView.ResourceCategories.ResourceDisplayStyle = (ResourceDisplayStyle)this.cmbResourceDisplayStyle.EditValue;
        }

        void chkShowAddButton_CheckedChanged(object sender, EventArgs e) {
            Scheduler.OptionsView.ResourceCategories.ShowAddButton = this.chkShowAddButton.Checked;
        }

        void chkShowCloseButton_CheckedChanged(object sender, EventArgs e) {
            Scheduler.OptionsView.ResourceCategories.ShowCloseButton = this.chkShowCloseButton.Checked;
        }
    }
}
