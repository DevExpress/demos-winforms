using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraPivotGrid.Demos.Helpers;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class OlapCustomTotals : TutorialControl {
		PivotGridField fieldQuantity,
			fieldCategories;
		public OlapCustomTotals() {
			CreateWaitDialog();
			InitializeComponent();

            bool success = OLAPConfigurator.ConnectToAdventureWorks(pivotGridControl, true);

            paddingPanel.Visible = !success;
            panelError.Visible = !success;
            separator1.Visible = !success;
            layoutControlGroup1.Enabled = success;

			fieldCategories = pivotGridControl.Fields[OLAPConfigurator.CategoriesFieldName];
			if(fieldCategories != null)
				fieldCategories.TotalsVisibility = PivotTotalsVisibility.CustomTotals;

			fieldQuantity = pivotGridControl.Fields[OLAPConfigurator.OrderQuantityFieldName];
			if(fieldQuantity != null) {
				fieldQuantity.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
				fieldQuantity.TotalCellFormat.FormatString = "f2";
			}            
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl; } }
		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			if(fieldCategories != null) {
				fieldCategories.ExpandValue("Beverages");
				SetCustomTotals(fieldCategories.CustomTotals);
			}
            UpdateListBoxColor(totalsListBox);
		}
        protected override void OnStyleChanged() {
            base.OnStyleChanged();
            UpdateListBoxColor(totalsListBox);
        }
        //<totalsListBox>
		void chListBox_ItemCheck(object sender, DevExpress.XtraEditors.Controls.ItemCheckEventArgs e) {
			if(fieldCategories != null)
				SetCustomTotals(fieldCategories.CustomTotals);
		}

        void SetCustomTotals(PivotGridCustomTotalCollection totals){
			totals.Clear();
			for(int i = 0; i < totalsListBox.Items.Count; i++)
				if(totalsListBox.Items[i].CheckState == CheckState.Checked)
					totals.Add((PivotSummaryType)Enum.Parse(typeof(PivotSummaryType), (string)totalsListBox.Items[i].Value));
		}
        //</totalsListBox>
	}
}
