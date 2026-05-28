using System;
using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;

namespace DevExpress.XtraCharts.Demos {
    public partial class PivotGridChartingDemo : ChartDemoModuleWithOptions {
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public PivotGridChartingDemo() {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            DataView dataSource = BindChartToData("SalesPerson");
            if(dataSource == null)
                return;
            pivotGridControl.DataSource = dataSource;
            SetFilter();
            SetSelection();
            UpdateColorizerKeys();
            chart.DataSource = pivotGridControl;
        }
        DataView BindChartToData(string tableName) {
            DataSet ds = new DataSet();
            using(OleDbConnection connection = new OleDbConnection()) {
                string path = Utils.GetRelativePath("nwind.mdb");
                if(path.Length > 0)
                    Utils.SetConnectionString(connection, path);
                else {
                    XtraMessageBox.Show("The \"nwind.mdb\" file not found.", "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                try {
                    File.SetAttributes(path, File.GetAttributes(path) & ~FileAttributes.ReadOnly);
                    using(OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + tableName, connection)) {
                        adapter.Fill(ds, tableName);
                    }
                }
                catch(OleDbException e) {
                    XtraMessageBox.Show(e.Message, "Error occurred", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            return ds.Tables[tableName].DefaultView;
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("SpellChecker", "CRRSP01")]
        void SetFilter() {
            fieldProductName.FilterValues.SetValues(new object[] {
                "Chai",
                "Chang",
                "Chocolade",
                "Filo Mix",
                "Geitost",
                "Ikura",
                "Konbu",
                "Maxilaku",
                "Pavlova",
                "Spegesild",
                "Tourtiere"
            }, PivotFilterType.Included, true);
            fieldOrderYear.FilterValues.SetValues(new object[] { 2015 }, PivotFilterType.Included, true);
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("SpellChecker", "CRRSP01")]
        void SetSelection() {
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chocolade" });
            pivotGridControl.Cells.SetSelectionByFieldValues(false, new object[] { "Chai" });
        }
        void UpdateColorizerKeys() {
            SeriesKeyColorColorizer colorizer = (SeriesKeyColorColorizer)chart.SeriesTemplate.SeriesColorizer;
            colorizer.Keys.Clear();
            if(checkEditGenerateSeriesByColumns.Checked)
                FillColorizerKeysByColumns(colorizer.Keys);
            else
                FillColorizerKeysByRows(colorizer.Keys);
        }
        void FillColorizerKeysByRows(KeyCollection keys) {
            int count = Math.Min(pivotGridControl.Cells.RowCount - 1, pivotGridControl.OptionsChartDataSource.MaxAllowedSeriesCount);
            for(int i = 0; i < count; i++)
                keys.Add(pivotGridControl.GetFieldValue(fieldProductName, i));
        }
        void FillColorizerKeysByColumns(KeyCollection keys) {
            int count = Math.Min(pivotGridControl.Cells.ColumnCount - 1, pivotGridControl.OptionsChartDataSource.MaxAllowedSeriesCount);
            for(int i = 0; i < count; i++) {
                int monthNumber = (int)pivotGridControl.GetFieldValue(fieldOrderDate, i);
                keys.Add(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(monthNumber));
            }
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            UpdateColorizerKeys();
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            chart.SeriesTemplate.LabelsVisibility = Utils.CovertBoolToDefaultBoolean(checkEditLabelVisible.Checked);
            chart.CrosshairEnabled = Utils.CovertBoolToDefaultBoolean(!checkEditLabelVisible.Checked);
        }
        void checkEditGenerateSeriesByColumns_CheckedChanged(object sender, EventArgs e) {
            bool generateFromColumn = checkEditGenerateSeriesByColumns.Checked;
            pivotGridControl.OptionsChartDataSource.ProvideDataByColumns = generateFromColumn;
            lciShowRowGrandTotal.Enabled = generateFromColumn;
            lciShowColumnGrandTotal.Enabled = !generateFromColumn;
        }
        void checkEditSelectionOnly_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.SelectionOnly = checkEditSelectionOnly.Checked;
        }
        void checkEditShowColumnGrandTotals_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideColumnGrandTotals = checkEditShowColumnGrandTotal.Checked;
        }
        void checkEditShowRowGrandTotals_CheckedChanged(object sender, EventArgs e) {
            pivotGridControl.OptionsChartDataSource.ProvideRowGrandTotals = checkEditShowRowGrandTotal.Checked;
        }
    }
}
