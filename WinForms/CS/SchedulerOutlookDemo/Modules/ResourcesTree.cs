using System;
using DevExpress.XtraScheduler.Demos.DemoData;
using System.Windows.Forms;

namespace DevExpress.XtraScheduler.Demos {
    public partial class ResourcesTreeModule : TutorialControl {
        public ResourcesTreeModule() {
            InitializeComponent();
        }

        public override SchedulerControl Scheduler { get { return this.schedulerControl1; } }
        protected override Control OptionsPane { get { return this.spOptionPane; } }

        public override void ResetOptions() {
            base.ResetOptions();
            Scheduler.BeginUpdate();
            try {
                this.chkShowResourceHeaders.Checked = false;
                this.chkAutoHeightCells.Checked = false;
                this.chkAutoFilterRow.Checked = true;
                this.spinResourcesPerPage.EditValue = Math.Min(4, Scheduler.DataStorage.Resources.Count);
            }
            finally {
                Scheduler.EndUpdate();
            }
        }

        void ResourcesTreeModule_Load(object sender, System.EventArgs e) {
            Scheduler.Start = SchedulerDataHelper.Start;
            SchedulerDataHelper.Attach(Scheduler, false);
            ResetOptions();
        }
        void chkAutoFilterRow_CheckedChanged(object sender, EventArgs e) {
            this.resourcesTree1.OptionsView.ShowAutoFilterRow = this.chkAutoFilterRow.Checked;
        }

        void chkShowResourceHeaders_CheckedChanged(object sender, EventArgs args) {
            Scheduler.TimelineView.ShowResourceHeaders = this.chkShowResourceHeaders.Checked;
        }

        void chkAutoHeightCells_CheckedChanged(object sender, EventArgs args) {
            Scheduler.TimelineView.CellsAutoHeightOptions.AutoHeightMode = this.chkAutoHeightCells.Checked ? SchedulerCellAutoHeightMode.Full : SchedulerCellAutoHeightMode.None;
        }

        void spinResourcesPerPage_EditValueChanged(object sender, System.EventArgs e) {
            Scheduler.TimelineView.ResourcesPerPage = Convert.ToInt32(this.spinResourcesPerPage.EditValue);
        }

        void schedulerControl1_ActiveViewChanged(object sender, EventArgs e) {
            bool isEnabled = Scheduler.ActiveViewType == SchedulerViewType.Timeline;
            this.chkShowResourceHeaders.Enabled = isEnabled;
            this.chkAutoHeightCells.Enabled = isEnabled;
            this.spinResourcesPerPage.Enabled = isEnabled;
        }
        void resourcesTree1_LayoutUpdated(object sender, EventArgs e) {
            this.spinResourcesPerPage.EditValue = this.schedulerControl1.ActiveView.ResourcesPerPage;
        }
    }
}
