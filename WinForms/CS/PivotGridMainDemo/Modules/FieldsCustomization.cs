using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraPivotGrid.Customization;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class FieldsCustomization : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public FieldsCustomization() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();
        }
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        bool showCustomization = false;
        private void FieldsCustomization_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            InitComboBoxes();
            pivotGridControl1.ValueImages = CategoryImageList;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldSalesPerson.ImageIndex = 0;
            fieldOrderID.ImageIndex = 1;
        }

        void InitComboBoxes() {

            icbCustomizationStyle.Properties.Items.Add("Excel", CustomizationFormStyle.Excel2007, -1);
            icbCustomizationStyle.Properties.Items.Add("Simple", CustomizationFormStyle.Simple, -1);
            icbCustomizationStyle.EditValue = pivotGridControl1.OptionsCustomization.CustomizationFormStyle;
        }
        protected override void OnLayoutCalculated() {
            base.OnLayoutCalculated();
            pivotGridControl1.FieldsCustomization(pivotGridControl1.PointToScreen(new Point(Width - 300, layoutControlGroup2.Height + 30)));
            pivotGridControl1.CustomizationForm.TopMost = true;
        }
        void InitCustomization(bool show) {
            showCustomization = show;
            sbCustomizationForm.Text = showCustomization ? "Hide Customization Form" : "Show Customization Form";
        }

        void ReShowCustomizationForm() {
            if(showCustomization) {
                pivotGridControl1.DestroyCustomization();
                Point showPoint = pivotGridControl1.CustomizationFormBounds.Location;
                pivotGridControl1.FieldsCustomization(showPoint);
            }
        }

        private void pivotGridControl1_ShowCustomizationForm(object sender, System.EventArgs e) {
            InitCustomization(true);
        }

        private void pivotGridControl1_HideCustomizationForm(object sender, System.EventArgs e) {
            InitCustomization(false);
        }

        //<sbCustomizationForm>
        private void sbCustomizationForm_Click(object sender, System.EventArgs e) {
            if(showCustomization)
                pivotGridControl1.DestroyCustomization();
            else
                pivotGridControl1.FieldsCustomization();
        }
        //</sbCustomizationForm>

        private void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }

        //<icbCustomizationStyle>
        private void icbCustomizationStyle_SelectedIndexChanged(object sender, EventArgs e) {
            CustomizationFormStyle style = (CustomizationFormStyle)icbCustomizationStyle.EditValue;
            pivotGridControl1.OptionsCustomization.CustomizationFormStyle = style;
            XtraLayout.Utils.LayoutVisibility checkBoxesVisibility =
                style == CustomizationFormStyle.Excel2007
                ? XtraLayout.Utils.LayoutVisibility.Always
                : XtraLayout.Utils.LayoutVisibility.Never;

            lciAllowFilter.Visibility = checkBoxesVisibility;
            lciAllowSort.Visibility = checkBoxesVisibility;
            ReShowCustomizationForm();
        }
        //</icbCustomizationStyle>

        //<ceSearchBox>
        private void OnSearchBoxVisibilityChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsCustomization.CustomizationFormSearchBoxVisible = ceSearchBox.Checked;
            ReShowCustomizationForm();
        }
        //</ceSearchBox>

        //<ceAllowFilter>
        private void ceAllowFilter_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = ceAllowFilter.Checked;
        }
        //</ceAllowFilter>

        //<ceAllowSort>
        private void ceAllowSort_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = ceAllowSort.Checked;
        }
        //</ceAllowSort>

    }
}

