namespace DevExpress.XtraScheduler.Demos {
    public partial class GroupByResourceModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public GroupByResourceModule() {
			InitializeComponent();
		}
		public override SchedulerControl PrintingSchedulerControl {
            get { return schedulerControl; }
        }
		void GroupByResourceModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerDataStorage);
        }
	}
}
