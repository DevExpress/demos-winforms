using System;
using DevExpress.XtraScheduler.Commands;

namespace DevExpress.XtraScheduler.Demos {
    public partial class SchedulerRibbonBarsModule : DevExpress.XtraScheduler.Demos.TutorialControl {
        public SchedulerRibbonBarsModule() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            schedulerControl.DayView.ShowWorkTimeOnly = true;
            schedulerControl.WorkWeekView.ShowWorkTimeOnly = true;
            // TODO: Add any initialization after the InitializeComponent call
        }
        public override bool AutoMergeRibbon { get { return false; } set { } }
        public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }

        private void SchedulerBarsModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }

        private void ribbonControl1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            CommitAndCloseInplaceEditorCommand command = new CommitAndCloseInplaceEditorCommand(schedulerControl);
            command.Execute();
        }
    }
}

