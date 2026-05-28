using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class CompactLayout : TutorialControl {
        protected override bool HideCustFormWhenSwitchDemo {
            get { return true; }
        }
        public CompactLayout() {
            CreateWaitDialog();
            InitializeComponent();
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }
        protected bool IsCompactLayout { get { return (bool)groupLayout.EditValue; } }

        void CompactLayout_Load(object sender, EventArgs e) {
            pivotGridControl1.BeginUpdate();
            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            pivotGridControl1.ValueImages = CategoryImageList;

            pivotGridControl1.OptionsCustomization.AllowFilterInCustomizationForm = true;
            pivotGridControl1.OptionsCustomization.AllowSortInCustomizationForm = true;
            pivotGridControl1.EndUpdate();
            groupLayout.SelectedIndex = 0;
            ChangeCustomizationFormState();
        }

        void pivotGridControl1_FieldValueImageIndex(object sender, PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && (IsCompactLayout || Comparer.Equals(e.ValueType, PivotGridValueType.Value)))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }

        //<groupLayout>
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            pivotGridControl1.OptionsView.ShowColumnHeaders = !IsCompactLayout;
            pivotGridControl1.OptionsView.ShowRowHeaders = !IsCompactLayout;
            pivotGridControl1.OptionsView.ShowDataHeaders = !IsCompactLayout;
            pivotGridControl1.OptionsView.RowTotalsLocation = IsCompactLayout ? PivotRowTotalsLocation.Tree : PivotRowTotalsLocation.Far;
            pivotGridControl1.BestFit();
        }
        //</groupLayout>
        bool customizationFormShown = false;
        void ChangeCustomizationFormState() {
            if(customizationFormShown) {
                pivotGridControl1.HideCustomization();
            } else {
                pivotGridControl1.ShowCustomization();
            }
        }
        void simpleButton1_Click(object sender, EventArgs e) {
            ChangeCustomizationFormState();
        }

        private void pivotGridControl1_HideCustomizationForm(object sender, EventArgs e) {
            simpleButton1.Text = "Show Customization Form";
            customizationFormShown = false;
        }

        private void pivotGridControl1_ShowCustomizationForm(object sender, EventArgs e) {
            simpleButton1.Text = "Hide Customization Form";
            customizationFormShown = true;
        }
    }
}
