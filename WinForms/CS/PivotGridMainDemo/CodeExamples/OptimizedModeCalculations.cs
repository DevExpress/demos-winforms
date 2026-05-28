using DevExpress.Internal;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Optimized Mode", "OptimizedModeCalculations.cs")]
    public static class OptimizedModeCalculations {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();

            pivotGridControl.BeginInit();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField fieldOrderYear = new PivotGridField();
            fieldOrderYear.Area = PivotArea.RowArea;
            fieldOrderYear.Caption = "Order Year";
            fieldOrderYear.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear);
            fieldOrderYear.Name = "fOrderYear";

            PivotGridField fieldOrderMonth = new PivotGridField();
            fieldOrderMonth.Area = PivotArea.RowArea;
            fieldOrderMonth.Caption = "Order Month";
            fieldOrderMonth.DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateMonth);
            fieldOrderMonth.Name = "fOrderQuarter";

            PivotGridField fieldProductAmount = new PivotGridField();

            fieldProductAmount.Area = PivotArea.DataArea;
            fieldProductAmount.Caption = "Product Sales";
            fieldProductAmount.Name = "fExtendedPrice";

            PivotGridField fieldProductAmountRunningTotal = new PivotGridField();

            fieldProductAmountRunningTotal.Area = PivotArea.DataArea;
            fieldProductAmountRunningTotal.Caption = "Running Total";
            fieldProductAmountRunningTotal.Name = "fRunningTotal";

            PivotGridField fieldProductAmountMoving = new PivotGridField();

            fieldProductAmountMoving.Area = PivotArea.DataArea;
            fieldProductAmountMoving.Caption = "Moving Average";
            fieldProductAmountMoving.Name = "fMovingAverage";

            PivotGridField fieldProductAmountDifference = new PivotGridField();

            fieldProductAmountDifference.Area = PivotArea.DataArea;
            fieldProductAmountDifference.Caption = "Difference";
            fieldProductAmountDifference.Name = "fDifference";

            PivotGridField fieldProductAmountRank = new PivotGridField();

            fieldProductAmountRank.Area = PivotArea.DataArea;
            fieldProductAmountRank.Caption = "Rank";
            fieldProductAmountRank.Name = "fRank";

            PivotGridField fieldProductAmountPercentOfTotal = new PivotGridField();

            fieldProductAmountPercentOfTotal.Area = PivotArea.DataArea;
            fieldProductAmountPercentOfTotal.Caption = "Percent Of Total";
            fieldProductAmountPercentOfTotal.Name = "fPercentOfTotal";
            fieldProductAmountPercentOfTotal.CellFormat.FormatType = FormatType.Numeric;
            fieldProductAmountPercentOfTotal.CellFormat.FormatString = "P1";


            pivotGridControl.Fields.AddRange(new PivotGridField[] {
                fieldProductAmount,
                fieldProductAmountRunningTotal,
                fieldProductAmountMoving,
                fieldProductAmountDifference,
                fieldProductAmountRank,
                fieldProductAmountPercentOfTotal,
                fieldOrderYear,
                fieldOrderMonth
            });

            pivotGridControl.Dock = DockStyle.Fill;
            pivotGridControl.OptionsView.ShowColumnGrandTotalHeader = false;
            pivotGridControl.OptionsView.ShowDataHeaders = false;
            pivotGridControl.OptionsView.ShowFilterHeaders = false;
            pivotGridControl.OptionsView.ShowColumnHeaders = false;
            pivotGridControl.OptionsCustomization.AllowFilterBySummary = false;

            string tableName = "Invoices";
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

        [CodeExampleCase("Field Calculation Bindings")]
        [CodeExampleUnderlineTokens("RunningTotalBinding", "MovingCalculationBinding", "DifferenceBinding", "RankBinding", "PercentOfTotalBinding")]
        [CodeExampleDataFile("nwind.xml")]
        public static void PivotCalculations(PivotGridControl pivotGridControl) {
            DataSourceColumnBinding productAmountBinding = new DataSourceColumnBinding("ExtendedPrice");
            //Bind a field to a column in the data source.
            pivotGridControl.Fields["fExtendedPrice"].DataBinding = new DataSourceColumnBinding("ExtendedPrice");
            //Calculate a running summary on the column.
            pivotGridControl.Fields["fRunningTotal"].DataBinding = new RunningTotalBinding(
                productAmountBinding, CalculationPartitioningCriteria.ColumnValue, PivotSummaryType.Sum);
            //Calculate the average of the preceding, current and following values in the column.
            pivotGridControl.Fields["fMovingAverage"].DataBinding = new MovingCalculationBinding(
                productAmountBinding, CalculationPartitioningCriteria.ColumnValue, PivotSummaryType.Average, 1, 1);
            //Calculate a difference between the preceding and current value in the column.
            pivotGridControl.Fields["fDifference"].DataBinding = new DifferenceBinding(
                productAmountBinding, CalculationPartitioningCriteria.ColumnValue, DifferenceTarget.Previous, DifferenceType.Absolute);
            //Calculate a rank for each value in the column in a pivot field group.
            pivotGridControl.Fields["fRank"].DataBinding = new RankBinding(
                productAmountBinding, CalculationPartitioningCriteria.ColumnValueAndRowParentValue, RankType.Unique, PivotSortOrder.Descending);
            //Calculate the percentage of each value in the column out of the sum of the values in a pivot field group.
            pivotGridControl.Fields["fPercentOfTotal"].DataBinding = new PercentOfTotalBinding(
                productAmountBinding, CalculationPartitioningCriteria.ColumnValueAndRowParentValue);
            pivotGridControl.BestFit();
        }
    }
}
