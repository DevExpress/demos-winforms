using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid.Demos.Helpers;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class OLAPDrillDown : TutorialControl {
		public OLAPDrillDown() {
			CreateWaitDialog();
			InitializeComponent();

			bool success = OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, true);

			controlPanel.Visible = !success;
			paddingPanel.Visible = !success;

		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			pivotGridControl.ExpandAll();
			pivotGridControl.Cells.FocusedCell = new Point(1, 12);
		}
        //<pivotGridControl>
		private void pivotGridControl_CellDoubleClick(object sender, PivotCellEventArgs e) {
            try {;
                using(DrillDownForm form = new DrillDownForm(e.CreateDrillDownDataSource()))
                    form.ShowDialog();
            } catch(Exception ex) {
                XtraMessageBox.Show(ex.Message);
            }
		}
        //</pivotGridControl>

	}
}
