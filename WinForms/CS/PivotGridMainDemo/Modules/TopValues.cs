using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraPivotGrid.Localization;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
	public partial class TopValues : DevExpress.XtraPivotGrid.Demos.TutorialControl {
		public TopValues() {
			// This call is required by the Windows Form Designer.
			CreateWaitDialog();
			InitializeComponent();
		}
		public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
		public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        //<icbField>
		private void TopValues_Load(object sender, System.EventArgs e) {
			pivotGridControl1.DataSource = GetNWindData("SalesPerson");
			InitComboBoxes();
			icbField.SelectedIndex = icbField.Properties.Items.Count - 1;;
			pivotGridControl1.HeaderImages = HeadersImageList;
			pivotGridControl1.ValueImages = CategoryImageList;
			fieldSalesPerson.ImageIndex = 0;
            pivotGridControl1.OptionsCustomization.AllowFilterBySummary = false;
		}

		void InitComboBoxes() {
			foreach(PivotGridField field in pivotGridControl1.Fields) 
				if(field.SortBySummaryInfo.Field == fieldExtendedPrice) 
					icbField.Properties.Items.Add(new ImageComboBoxItem(field.Caption.ToString(), field, -1));
		}        
		private void icbField_SelectedIndexChanged(object sender, System.EventArgs e) {
			pivotGridControl1.BeginUpdate();
			foreach(PivotGridField field in pivotGridControl1.Fields) 
				if(field.SortBySummaryInfo.Field == fieldExtendedPrice) {
					field.Area = PivotArea.RowArea;
					bool IsVisible = field == (PivotGridField)icbField.EditValue;
					field.Visible = IsVisible;
					if(IsVisible) {
						seTop.Properties.MaxValue = field.GetUniqueValues().Length;
						SetFieldTop();
					}
				}
			pivotGridControl1.EndUpdate();
		}
        //</icbField>
        //<seTop>
        //<ceTopValuesShowOthers>
		private void seTop_EditValueChanged(object sender, System.EventArgs e) {
			SetFieldTop();
		}        
		void SetFieldTop() {
			PivotGridField field = icbField.EditValue as PivotGridField;            
			if(field == null) return;            
			field.TopValueCount = Convert.ToInt32(seTop.Value);
			field.TopValueShowOthers = ceTopValuesShowOthers.Checked;            
		}
        //</ceTopValuesShowOthers>
        //</seTop>
		void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
			if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value) && !e.IsOthersValue) 
				e.ImageIndex = GetCategoryIndexByName(e.Value);
		}
		void ceTopValuesShowOthers_CheckedChanged(object sender, System.EventArgs e) {
			SetFieldTop();
		}
		void pivotGridControl1_CustomDrawFieldValue(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventArgs e) {
			if(e.IsOthersValue)
				e.Appearance.FontStyleDelta = FontStyle.Bold;
		}
	}
}
