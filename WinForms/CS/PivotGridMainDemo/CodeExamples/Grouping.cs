using DevExpress.Internal;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Grouping", "Grouping.cs")]
    public static class Grouping {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();

            pivotGridControl.BeginInit();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField fieldProductName = new PivotGridField();
            fieldProductName.Area = PivotArea.RowArea;
            fieldProductName.Caption = "Product";
            fieldProductName.DataBinding = new DataSourceColumnBinding("ProductName");
            fieldProductName.Name = "fieldProductName";

            PivotGridField fieldSales = new PivotGridField();
            fieldSales.Area = PivotArea.DataArea;
            fieldSales.Caption = "Product Sales";
            fieldSales.DataBinding = new DataSourceColumnBinding("ProductSales");
            fieldSales.Name = "fieldProductSales";

            PivotGridField fieldShippedDate = new PivotGridField();
            fieldShippedDate.Area = PivotArea.ColumnArea;
            fieldShippedDate.Caption = "Shipped Date";
            fieldShippedDate.DataBinding = new DataSourceColumnBinding("ShippedDate", PivotGroupInterval.DateYear);
            fieldShippedDate.Name = "fieldShippedDate";

            pivotGridControl.Fields.AddRange(new PivotGridField[] {
                fieldProductName,
                fieldSales,
                fieldShippedDate
            });

            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.OptionsData.AutoExpandGroups = DefaultBoolean.False;

            string tableName = "ProductReports";
            string dbFileName = DataDirectoryHelper.GetDataFile("nwind.xml");
            if(!string.IsNullOrEmpty(dbFileName)) {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(dbFileName);
                pivotGridControl.DataSource = dataSet.Tables[tableName].DefaultView;
            }
            pivotGridControl.EndInit();
            pivotGridControl.Parent = sampleHost;

            return new object[] { pivotGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as PivotGridControl).Dispose();
        }

        [CodeExampleCase("Alphabetical Grouping")]
        [CodeExampleUnderlineTokens("DataBinding", "ExpressionDataBinding")]
        [CodeExampleDataFile("nwind.xml")]
        public static void AlphabeticalGrouping(PivotGridControl pivotGridControl) {
            PivotGridField fieldProductGroup = new PivotGridField();
            fieldProductGroup.Area = PivotArea.RowArea;
            fieldProductGroup.Caption = "Product Group";
            fieldProductGroup.AreaIndex = 0;
            fieldProductGroup.DataBinding = new ExpressionDataBinding(
                "iif(Substring([ProductName], 0, 1) < 'F', 'A-E', Substring([ProductName], 0, 1) < 'T', 'F-S', 'T-Z')");
            pivotGridControl.Fields.Add(fieldProductGroup);
        }
        [CodeExampleCase("Date-Time Grouping")]
        [CodeExampleUnderlineTokens("DataBinding", "ExpressionDataBinding")]
        [CodeExampleDataFile("nwind.xml")]
        public static void DateTimeGrouping(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsMenu.ShowDateTimeGroupIntervalItems = DateTimeGroupIntervals.None;
            PivotGridField fieldYearQuarter = pivotGridControl.GetFieldByArea(PivotArea.ColumnArea, 0);
            fieldYearQuarter.Caption = "Year - Quarter";
            fieldYearQuarter.DataBinding = new ExpressionDataBinding(
                "Concat(GetYear([ShippedDate]), ' - ', GetQuarter([ShippedDate]))");
        }
    }
}
