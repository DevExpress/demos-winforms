using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class TotalsLocation : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public TotalsLocation() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

		private void TotalsLocation_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			pivotGridControl1.ValueImages = CategoryImageList;
			InitComboBoxes();
		}

		void InitComboBoxes() {
            rgColumnsLocation.SelectedIndex = pivotGridControl1.OptionsView.ColumnTotalsLocation == PivotTotalsLocation.Near ? 0 : 1;

            if (pivotGridControl1.OptionsView.RowTotalsLocation == PivotRowTotalsLocation.Near) 
                rgRowsLocation.SelectedIndex = 0;
            else if (pivotGridControl1.OptionsView.RowTotalsLocation == PivotRowTotalsLocation.Far)
                rgRowsLocation.SelectedIndex = 1;
            else
                rgRowsLocation.SelectedIndex = 2;
		}

		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}
        //<rgRowsLocation>
        private void rgRow_SelectedIndexChanged(object sender, EventArgs e) {
            switch(rgRowsLocation.SelectedIndex) {
                case 0:
                    pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near;
                    break;
                case 1:
                    pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Far;
                    break;
                case 2:
                    pivotGridControl1.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
                    if (!pivotGridControl1.OptionsView.ShowRowTotals)
                        pivotGridControl1.OptionsView.ShowRowTotals = true;
                    break;
            }
        }
        //</rgRowsLocation>
        //<rgColumnsLocation>
        private void rgColumn_SelectedIndexChanged_1(object sender, EventArgs e) {
            switch(rgColumnsLocation.SelectedIndex) {
                case 0:
                    pivotGridControl1.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near;
                    break;
                case 1:
                    pivotGridControl1.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Far;
                    break;
            }
        }
        //</rgColumnsLocation>
    }
}

