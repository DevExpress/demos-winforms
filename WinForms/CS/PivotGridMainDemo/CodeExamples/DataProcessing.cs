using DevExpress.Internal;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Data Processing", "DataProcessing.cs")]
    public static class DataProcessing {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();

            pivotGridControl.BeginInit();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;

            PivotGridField fieldOrderYear = new PivotGridField();
            fieldOrderYear.Area = PivotArea.ColumnArea;
            fieldOrderYear.Caption = "Order Year";
            fieldOrderYear.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear);
            fieldOrderYear.Name = "fieldOrderYear";

            PivotGridField fieldOrderDate = new PivotGridField();
            fieldOrderDate.Area = PivotArea.ColumnArea;
            fieldOrderDate.Caption = "Order Quarter";
            fieldOrderDate.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter);
            fieldOrderDate.Name = "fieldOrderQuarter";

            PivotGridField fieldProductAmount = new PivotGridField();
            fieldProductAmount.Area = PivotArea.DataArea;
            fieldProductAmount.Caption = "Product Sales";
            fieldProductAmount.CellFormat.FormatString = "c";
            fieldProductAmount.CellFormat.FormatType = FormatType.Numeric;
            fieldProductAmount.DataBinding = new DataSourceColumnBinding("ProductAmount");
            fieldProductAmount.Name = "fieldProductAmount";

            PivotGridField fieldProductName = new PivotGridField();
            fieldProductName.Area = PivotArea.RowArea;
            fieldProductName.Caption = "Product";
            fieldProductName.DataBinding = new DataSourceColumnBinding("ProductName");
            fieldProductName.Name = "fieldProductName";

            pivotGridControl.Fields.AddRange(new PivotGridField[] {
                fieldProductAmount,
                fieldProductName,
                fieldOrderYear,
                fieldOrderDate
            });

            PivotGridGroup pivotGridGroup1 = new PivotGridGroup();
            pivotGridGroup1.Fields.Add(fieldOrderYear);
            pivotGridGroup1.Fields.Add(fieldOrderDate);
            pivotGridControl.Groups.Add(pivotGridGroup1);

            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.OptionsView.ShowColumnTotals = false;
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;

            string tableName = "CustomerReports";
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

        [CodeExampleCase("Cross Group Summary")]
        [CodeExampleUnderlineTokens("DataBinding", "RunningTotalBinding")]
        [CodeExampleDataFile("nwind.xml")]
        public static void CrossGroupSummary(PivotGridControl pivotGridControl) {
            pivotGridControl.Fields["fieldProductAmount"].DataBinding = new RunningTotalBinding(
                new DataSourceColumnBinding("ProductAmount"), CalculationPartitioningCriteria.RowValue, PivotSummaryType.Sum);
        }
    }
}
