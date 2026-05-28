using DevExpress.Internal;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.Data.PivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Sorting", "Sorting.cs")]
    public static class Sorting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();
            pivotGridControl.DataSourceChanged += (s, e) => { pivotGridControl.BestFit(); };
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            pivotGridControl.BeginInit();
            pivotGridControl.Fields.Add(new PivotGridField("Country", PivotArea.RowArea));
            pivotGridControl.Fields.Add(new PivotGridField("ExtendedPrice", PivotArea.DataArea) { Caption = "Price" });
            pivotGridControl.Fields.Add(new PivotGridField() { Name = "fieldMonth", Area = PivotArea.ColumnArea, Caption = "Month", DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateMonth) });

            pivotGridControl.Dock = DockStyle.Fill;

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

        [CodeExampleCase("Sort Order")]
        [CodeExampleUnderlineTokens("SortOrder")]
        [CodeExampleDataFile("nwind.xml")]
        public static void SortOrder(PivotGridControl pivotGridControl) {
            // Specify the field sort order: Ascending or Descending.
            pivotGridControl.Fields["Country"].SortOrder = PivotSortOrder.Ascending;
        }

        [CodeExampleCase("Sort Mode")]
        [CodeExampleUnderlineTokens("SortMode")]
        [CodeExampleDataFile("nwind.xml")]
        public static void SortMode(PivotGridControl pivotGridControl) {
            // Specify whether the field's data is sorted based on Value or DisplayText.
            pivotGridControl.Fields["OrderDate"].SortMode = PivotSortMode.Value;
        }

        [CodeExampleCase("Top N")]
        [CodeExampleUnderlineTokens("TopValueCount", "TopValueShowOthers", "TopValueType")]
        [CodeExampleDataFile("nwind.xml")]
        public static void TopN(PivotGridControl pivotGridControl) {
            var fieldCountry = pivotGridControl.Fields["Country"];
            // Specify the number of field values to display for the Country field (top N).
            fieldCountry.TopValueCount = 5;
            // Specify whether to display the "Others" item.
            fieldCountry.TopValueShowOthers = true;
            // Specify whether the TopValueCount value is the absolute number of field values or a percentage ratio.
            fieldCountry.TopValueType = PivotTopValueType.Absolute;
        }

        [CodeExampleCase("Sorting By Summary")]
        [CodeExampleUnderlineTokens("SortBySummaryInfo", "Field", "Conditions", "PivotGridFieldSortCondition")]
        [CodeExampleDataFile("nwind.xml")]
        public static void SortingBySummary(PivotGridControl pivotGridControl) {
            var fieldCountry = pivotGridControl.Fields["Country"];
            // Specify a field whose summary values define the sort order. The Pivot Grid sorts field values by a Grand Total column/row of the specified field.
            fieldCountry.SortBySummaryInfo.Field = pivotGridControl.Fields["ExtendedPrice"];
            // A field may relate to several pivot columns. Specify conditions that identify a column or row by which the field is sorted.
            fieldCountry.SortBySummaryInfo.Conditions.Add(
                new PivotGridFieldSortCondition(pivotGridControl.Fields["OrderDate"], 3));
            // Specify the sort order.
            fieldCountry.SortOrder = PivotSortOrder.Descending;
        }
    }
}
