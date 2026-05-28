using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class ConditionalSortBySummary : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public ConditionalSortBySummary() {
			CreateWaitDialog();
			InitializeComponent();
		}

		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        //<pivotGridControl1>
		private void ConditionalSortBySummary_Load(object sender, EventArgs e) {
			pivotGridControl1.BeginUpdate();
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			fieldYear.FilterValues.ValuesIncluded = new object[] { 2014 };
			fieldSalesPerson.SortBySummaryInfo.Field = fieldDiscount;
			fieldSalesPerson.SortBySummaryInfo.Conditions.Add(new PivotGridFieldSortCondition(fieldYear, 2014));
			fieldSalesPerson.SortBySummaryInfo.Conditions.Add(new PivotGridFieldSortCondition(fieldMonth, 8));
			pivotGridControl1.EndUpdate();
		}
        //</pivotGridControl1>
	}
}
