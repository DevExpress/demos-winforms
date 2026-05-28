using System;
using DevExpress.Utils;

namespace DevExpress.XtraScheduler.Demos {
	public partial class AppearanceModule : DevExpress.XtraScheduler.Demos.TutorialControl {
		public AppearanceModule() {
			// This call is required by the Windows Form Designer.
			InitializeComponent();

			// TODO: Add any initialization after the InitializeComponent call
		}
		public override SchedulerControl PrintingSchedulerControl { get { return schedulerControl; } }
		protected bool IsSchedulerAppearances { get { return rgrpEdit.SelectedIndex == 0; } }
		protected bool IsViewAppearances { get { return rgrpEdit.SelectedIndex == 1; } }
		protected bool IsResourceColorSchemas { get { return rgrpEdit.SelectedIndex == 2; } }

		private void DayViewModule_Load(object sender, System.EventArgs e) {
            CarsDataHelper.FillData(schedulerControl, schedulerStorage);
        }
		private void btnEdit_Click(object sender, EventArgs e) {
			if (IsResourceColorSchemas)
				EditColorSchemas(schedulerControl.ResourceColorSchemas);
			else {
				BaseViewAppearance app = IsSchedulerAppearances ? schedulerControl.Appearance : schedulerControl.ActiveView.Appearance;
				EditAppearances(app);
			}
		}
		void EditAppearances(BaseAppearanceCollection appearances) {
			AppearancesEditForm frm = new AppearancesEditForm(appearances, this.FindForm());
			frm.ShowDialog();
		}
		void EditColorSchemas(SchedulerColorSchemaCollection colorSchemas) {
			ColorSchemasEditForm frm = new ColorSchemasEditForm(colorSchemas, this.FindForm());
			frm.ShowDialog();
		}
	}
}
