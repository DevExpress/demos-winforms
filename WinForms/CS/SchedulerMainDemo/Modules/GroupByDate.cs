namespace DevExpress.XtraScheduler.Demos {
    public partial class GroupByDateModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public GroupByDateModule() {
			InitializeComponent();
		}
		public override SchedulerControl PrintingSchedulerControl {
            get { return schedulerControl; }
        }
		private void GroupByDateModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
        }
	}
}
