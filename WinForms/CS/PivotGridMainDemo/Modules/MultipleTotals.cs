using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class MultipleTotals : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public MultipleTotals() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        //<pivotGridControl1>
		private void MultipleTotals_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			fieldYear.Group.FilterValues.FilterType = PivotFilterType.Included;
			fieldYear.Group.FilterValues.Values.Add(2015);
			pivotGridControl1.ValueImages = CategoryImageList;
			InitCustomTotals();
		}
        
		void InitCustomTotals() {
			fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.CustomTotals;
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Average);
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Sum);
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Max);
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Min);
			fieldCategoryName.CustomTotals.Add(PivotSummaryType.Count);
		}

		private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
				e.ImageIndex = GetCategoryIndexByName(e.Value);
			if(e.ValueType == PivotGridValueType.CustomTotal) 
				if(e.CustomTotal.SummaryType == PivotSummaryType.Sum && e.Field.Area != PivotArea.DataArea)
					e.ImageIndex = 8;
		}
        //</pivotGridControl1>
	}
}

