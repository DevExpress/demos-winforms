using DevExpress.Internal;
using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.XtraCharts;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Chart Integration", "ChartIntegration.cs")]
    public static class ChartIntegration {
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

        [CodeExampleCase("Preparing data")]
        [CodeExampleUnderlineTokens("cellZeroValueThreshold", "CustomChartDataSourceData")]
        [CodeExampleDataFile("nwind.xml")]
        public static void ChartCustomData(PivotGridControl pivotGridControl) {
            ChartControl chartControl = new ChartControl() { Parent = pivotGridControl.Parent, Dock = DockStyle.Bottom, Height = 150 };
            chartControl.CrosshairEnabled = DefaultBoolean.False;
            chartControl.DataSource = pivotGridControl;

            int cellZeroValueThreshold = 10000;
            pivotGridControl.CustomChartDataSourceData += (s, e) => {
                if(e.ItemType == PivotChartItemType.CellItem) {
                    if(e.Value == DBNull.Value || (decimal)e.Value < Convert.ToDecimal(cellZeroValueThreshold)) {
                        e.Value = 0;
                    }
                }
            };
        }
    }
}
