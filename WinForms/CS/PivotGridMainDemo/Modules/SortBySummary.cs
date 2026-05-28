using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class SortBySummary : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public SortBySummary() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();
		}
		public override PivotGridControl ViewOptionsControl {
			get { return pivotGridControl1; }
		}
		public override PivotGridControl ExportControl {
			get { return pivotGridControl1; }
		}
		void SortBySummary_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			fieldYear.FilterValues.FilterType = PivotFilterType.Included;
			fieldYear.FilterValues.Add(2015);
			pivotGridControl1.HeaderImages = HeadersImageList;
			fieldSalesPerson.ImageIndex = 0;
		}
        void pivotGridControl1_CustomDrawCell(object sender, PivotCustomDrawCellEventArgs e) {
			if(Comparer.ReferenceEquals(e.DataField, fieldSalesPerson.SortBySummaryInfo.Field)) {
				e.Appearance.FontStyleDelta = FontStyle.Bold;
			}
        }
    }
}
