using DevExpress.Internal;
using System.Data;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.Utils;
using DevExpress.Data.PivotGrid;
using DevExpress.Data;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Intermediate Level Aggregations (Optimized Mode)", "Aggr.cs")]
    public static class Aggr {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();
            pivotGridControl.DataSourceChanged += (s, e) => { pivotGridControl.BestFit(); };

            pivotGridControl.BeginInit();
            var f1 = new PivotGridField("Country", PivotArea.RowArea);
            f1.Name = "f1";
            pivotGridControl.Fields.Add(f1);
            var f2 = new PivotGridField() { Caption = "Year", Area = PivotArea.ColumnArea, DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear) };
            f2.Name = "f2";
            pivotGridControl.Fields.Add(f2);
            var f3 = new PivotGridField("ExtendedPrice", PivotArea.DataArea) { Caption = "Extended price" };
            f3.Name = "f3";
            pivotGridControl.Fields.Add(f3);

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

        [CodeExampleCase("Filter Sales by Year and Country")]
        [CodeExampleUnderlineTokens("Aggr", "OrderDate", "Country")]
        [CodeExampleDataFile("nwind.xml")]
        public static void FilterCountryBySumOfPriceInYear(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField field = new PivotGridField {
                Name = "SalesByYearByCountry",
                Area = PivotArea.FilterArea,
                DataBinding = new ExpressionDataBinding("Aggr(Sum([ExtendedPrice]), GetYear([OrderDate]), [Country])")
            };
            pivotGridControl.Fields.Add(field);
            pivotGridControl.ActiveFilter.CriteriaString = "[SalesByYearByCountry] > 30000";
        }
        [CodeExampleCase("Average sales by Year")]
        [CodeExampleUnderlineTokens("Aggr", "OrderDate", "Country")]
        [CodeExampleDataFile("nwind.xml")]
        public static void AverageInTotals(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField salesByYearByCountry = new PivotGridField() {
                Area = PivotArea.DataArea,
                Caption = "Average sales by year",
                SummaryType = PivotSummaryType.Average,
                Name = "SalesByYearByCountry"
            };
            salesByYearByCountry.DataBinding = new ExpressionDataBinding("aggr(Sum([ExtendedPrice]), GetYear([OrderDate]), [Country])");
            salesByYearByCountry.Options.ShowValues = false;
            salesByYearByCountry.CellFormat.FormatType = FormatType.Numeric;
            salesByYearByCountry.CellFormat.FormatString = "c2";

            PivotGridField percentOfMaxSalesByYear = new PivotGridField() {
                Name = "PercentOfMaxSalesByYear",
                Caption = "Percent of Max Sales by Year",
                Area = PivotArea.DataArea,
            };
            percentOfMaxSalesByYear.DataBinding = new ExpressionDataBinding("Sum([ExtendedPrice]) / Max(aggr( Max([SalesByYearByCountry]), GetYear([OrderDate])))");
            percentOfMaxSalesByYear.Options.ShowGrandTotal = false;
            percentOfMaxSalesByYear.Options.ShowExpressionEditorMenu = true;
            percentOfMaxSalesByYear.CellFormat.FormatType = FormatType.Custom;
            percentOfMaxSalesByYear.CellFormat.FormatString = "p";

            pivotGridControl.Fields.Add(salesByYearByCountry);
            pivotGridControl.Fields.Add(percentOfMaxSalesByYear);
            pivotGridControl.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near;
            pivotGridControl.Appearance.FieldValue.Options.UseTextOptions = true;
            pivotGridControl.Appearance.FieldValue.TextOptions.Trimming = Trimming.Word;
            pivotGridControl.Appearance.FieldValue.TextOptions.WordWrap = WordWrap.Wrap;
            pivotGridControl.OptionsDataField.ColumnValueLineCount = 2;
        }
        [CodeExampleCase("Grouping by Year of first sale")]
        [CodeExampleUnderlineTokens("Aggr", "Min", "Country", "OrderDate")]
        [CodeExampleDataFile("nwind.xml")]
        public static void GroupByFirstYear(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            PivotGridField yearOfFirstSale = new PivotGridField() { Area = PivotArea.RowArea, AreaIndex = 0, Caption = "Year of first sale" };
            yearOfFirstSale.DataBinding = new ExpressionDataBinding("Aggr(Min(GetYear([OrderDate])), [Country])");
            yearOfFirstSale.Options.ShowTotals = false;
            pivotGridControl.Fields.Add(yearOfFirstSale);
        }
    }
}
