using System;
using System.Collections.Generic;
using DevExpress.XtraCharts;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class CustomChartData : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        enum RowFieldValueExportRule {
            ProductName = 0,
            CategoryAndProduct = 1,
            CategoryEncoded = 2
        };

        static string[] categories = new string[] { "Beverages", "Condiments", "Confections", "Dairy Products",
            "Grains/Cereals", "Meat/Poultry", "Produce", "Seafood" };

        RowFieldValueExportRule exportRule;

        RowFieldValueExportRule RowExportRule {
            get { return exportRule; }
            set { exportRule = value; }
        }
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl; } }

        public CustomChartData() {
            CreateWaitDialog();
            InitializeComponent();

            chartControl.CrosshairOptions.ShowArgumentLine = false;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            comboChartType.Properties.Items.AddRange(new ViewType[] {
                ViewType.Bar, ViewType.StackedBar, ViewType.FullStackedBar,
                ViewType.Point, ViewType.Line, ViewType.StepLine, ViewType.Spline, 
                ViewType.Area, ViewType.SplineArea, ViewType.StackedArea, ViewType.StackedSplineArea,
                ViewType.FullStackedArea, ViewType.FullStackedSplineArea
            });
            comboChartType.SelectedItem = ViewType.Line;
            RowExportRule = RowFieldValueExportRule.ProductName;
            cbRowFieldValuesExportRule.Properties.Items.AddRange(
                new string[] { "ProductName", "Category/ProductName", "Encoded Product Category" });
            cbRowFieldValuesExportRule.SelectedIndex = 0;
            pivotGridControl.DataSource = GetNWindData("SalesPerson");
            CollapseValues();
            SetSelection();
            chartControl.DataSource = pivotGridControl;
        }
        void CollapseValues() {
            fieldCategoryName.CollapseAll();
            fieldCategoryName.ExpandValue("Condiments");
            fieldYear.CollapseAll();
            fieldYear.ExpandValue(2014);
            fieldQuarter.CollapseAll();
            fieldQuarter.ExpandValue(3);
        }
        void SetSelection() {
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Condiments", "Aniseed Syrup" });
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Condiments", "Chef Anton's Cajun Seasoning" });
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Condiments", "Chef Anton's Gumbo Mix" });
        }
        //<comboChartType>
        void comboBoxEdit2_SelectedIndexChanged(object sender, EventArgs e) {
            chartControl.SeriesTemplate.ChangeView((ViewType)comboChartType.SelectedItem);
        }
        //</comboChartType>
        //<checkShowPointLabels>
        void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            chartControl.SeriesTemplate.LabelsVisibility = checkShowPointLabels.Checked ?
                DevExpress.Utils.DefaultBoolean.True : DevExpress.Utils.DefaultBoolean.False;
        }
        //</checkShowPointLabels>

        //<seCellZeroValueThreshold>
        void pivotGridControl1_CustomChartDataSourceData(object sender, PivotCustomChartDataSourceDataEventArgs e) {            
            if(e.ItemType == PivotChartItemType.CellItem)
                if(e.Value == DBNull.Value || (decimal)e.Value < Convert.ToDecimal(seCellZeroValueThreshold.Value))
                    e.Value = 0;
            //</seCellZeroValueThreshold>
            if(e.ItemType == PivotChartItemType.RowItem) {
                bool isCategoryNameField = object.Equals(e.FieldValueInfo.Field, fieldCategoryName);
                switch(RowExportRule) {
                    case RowFieldValueExportRule.ProductName:
                        if(isCategoryNameField)
                            e.Value = string.Format("{0} Category", e.FieldValueInfo.Value);
                        else
                            e.Value = e.FieldValueInfo.Value;
                        break;
                    case RowFieldValueExportRule.CategoryAndProduct:
                        if(isCategoryNameField)
                            e.Value = string.Format("{0}/Total", e.FieldValueInfo.Value);
                        else
                            e.Value = string.Format("{0}/{1}", e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName), e.FieldValueInfo.Value);
                        break;
                    case RowFieldValueExportRule.CategoryEncoded:
                        string categoryName = string.Format("{0}", isCategoryNameField ? e.FieldValueInfo.Value : e.FieldValueInfo.GetHigherLevelFieldValue(fieldCategoryName));
                        e.Value = EncodeCategoryName(categoryName);
                        break;
                }

            }
        }
        //<cbRowFieldValuesExportRule>
        void cbRowFieldValuesExportRule_SelectedIndexChanged(object sender, EventArgs e) {
            RowExportRule = ((RowFieldValueExportRule)cbRowFieldValuesExportRule.SelectedIndex);
            if(RowExportRule == RowFieldValueExportRule.CategoryEncoded)
                pivotGridControl.OptionsChartDataSource.ProvideRowFieldValuesAsType = typeof(Char);
            else
                pivotGridControl.OptionsChartDataSource.ProvideRowFieldValuesAsType = typeof(string);
        }
        //</cbRowFieldValuesExportRule>

        //<seCellZeroValueThreshold>
        void seCellZeroValueThreshold_EditValueChanged(object sender, EventArgs e) {
            pivotGridControl.RefreshData();
        }
        //</seCellZeroValueThreshold>
        Char EncodeCategoryName(string categoryName) {
            for(int i = 0; i < categories.Length; i++) {
                if(categories[i] == categoryName)
                    return Convert.ToChar(Convert.ToInt32('A') + i);
            }
            return 'Z';
        }
    }
}
