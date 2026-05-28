using DevExpress.Internal;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.PivotGrid;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraPivotGrid.Data;

namespace DevExpress.XtraPivotGrid.Demos.CodeExamples {
    [CodeExampleClass("Layout", "Layout.cs")]
    public static class Layout {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            PivotGridControl pivotGridControl = new PivotGridControl();
            pivotGridControl.DataSourceChanged += (s, e) => { pivotGridControl.BestFit(); };

            pivotGridControl.BeginInit();
            pivotGridControl.OptionsData.DataProcessingEngine = PivotDataProcessingEngine.Optimized;
            pivotGridControl.Fields.Add(new PivotGridField("Country", PivotArea.RowArea) { TopValueCount = 3 });
            pivotGridControl.Fields.Add(new PivotGridField("City", PivotArea.RowArea));
            pivotGridControl.Fields.Add(new PivotGridField("Quantity", PivotArea.DataArea));
            pivotGridControl.Fields.Add(new PivotGridField("ExtendedPrice", PivotArea.DataArea) { Caption = "Price" });
            pivotGridControl.Fields.Add(new PivotGridField() { Name = "fieldYear", Area = PivotArea.ColumnArea, DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateYear), Caption = "Year", TopValueCount = 2 });
            pivotGridControl.Fields.Add(new PivotGridField() { Name = "fieldQuarter", Area = PivotArea.ColumnArea, DataBinding = new DataSourceColumnBinding("OrderDate", PivotGroupInterval.DateQuarter), Caption = "Quarter" });

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

        [CodeExampleCase("Totals Location")]
        [CodeExampleUnderlineTokens("OptionsView", "RowTotalsLocation", "ColumnTotalsLocation")]
        [CodeExampleDataFile("nwind.xml")]
        public static void TotalsLocation(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Tree;
            pivotGridControl.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near;
        }

        [CodeExampleCase("Totals Visibility")]
        [CodeExampleUnderlineTokens("OptionsView", "ShowRowTotals", "ShowColumnTotals", "ShowColumnGrandTotals", "ShowRowGrandTotals", "ShowTotalsForSingleValues")]
        [CodeExampleDataFile("nwind.xml")]
        public static void TotalsVisibility(PivotGridControl pivotGridControl) {
            CheckEdit ceShowTotalsForSingleValues = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Totals For Single Values", Checked = false, Dock = DockStyle.Top };
            ceShowTotalsForSingleValues.CheckedChanged += (s, e) => {
                // Specify whether to display totals for the field values which contain a single nested field value.
                pivotGridControl.OptionsView.ShowTotalsForSingleValues = ceShowTotalsForSingleValues.Checked;
            };
            CheckEdit ceShowTotals = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Totals", Checked = true, Dock = DockStyle.Top };
            ceShowTotals.CheckedChanged += (s, e) => {
                // Specify whether to display Row and Column totals.
                pivotGridControl.OptionsView.ShowColumnTotals = ceShowTotals.Checked;
                pivotGridControl.OptionsView.ShowRowTotals = ceShowTotals.Checked;
                // Disable the Show Totals For Single Values check edit control if the Show Totals check edit control is unchecked.
                ceShowTotalsForSingleValues.Enabled = ceShowTotals.Checked;
            };
            CheckEdit ceShowGrandTotals = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Grand Totals", Checked = true, Dock = DockStyle.Top };
            ceShowGrandTotals.CheckedChanged += (s, e) => {
                // Sets whether to display Grand Totals.
                pivotGridControl.OptionsView.ShowColumnGrandTotals = ceShowGrandTotals.Checked;
                pivotGridControl.OptionsView.ShowRowGrandTotals = ceShowGrandTotals.Checked;

            };
        }

        [CodeExampleCase("Row Field Totals")]
        [CodeExampleUnderlineTokens("TotalsVisibility", "AutomaticTotals", "CustomTotals", "None")]
        [CodeExampleDataFile("nwind.xml")]
        public static void RowFieldTotals(PivotGridControl pivotGridControl) {
            // Create a custom total object and specify a custom format string to display its data.
            PivotGridCustomTotal averageTotal = new PivotGridCustomTotal(PivotSummaryType.Average);
            averageTotal.Format.FormatType = FormatType.Custom;
            averageTotal.Format.FormatString = "Custom Average of {0}";

            // Add custom totals to the field. The totals use different aggregate functions.
            pivotGridControl.Fields["Country"].CustomTotals.AddRange(new PivotGridCustomTotal[] {
                new PivotGridCustomTotal(PivotSummaryType.Min),
                new PivotGridCustomTotal(PivotSummaryType.Max),
                averageTotal
            });

            ComboBoxEdit cbeCountryTotals = new ComboBoxEdit() { Parent = pivotGridControl.Parent, Text = "Show Data Fields in Rows", Dock = DockStyle.Top };
            cbeCountryTotals.Properties.Items.AddRange(new string[] { "Automatic Totals", "Custom Totals", "None" });
            cbeCountryTotals.SelectedIndex = 0;
            cbeCountryTotals.SelectedIndexChanged += (s, e) => {
                // Specify a kind of totals to display depending on the value selected in the Country Totals combo box.
                switch((string)cbeCountryTotals.SelectedItem) {
                    case "Automatic Totals": pivotGridControl.Fields["Country"].TotalsVisibility = PivotTotalsVisibility.AutomaticTotals; break;
                    case "Custom Totals": pivotGridControl.Fields["Country"].TotalsVisibility = PivotTotalsVisibility.CustomTotals; break;
                    case "None": pivotGridControl.Fields["Country"].TotalsVisibility = PivotTotalsVisibility.None; break;
                }
            };
        }

        [CodeExampleCase("Data Fields Position")]
        [CodeExampleUnderlineTokens("OptionsDataField", "Area", "AreaIndex")]
        [CodeExampleDataFile("nwind.xml")]
        public static void DataFieldsPosition(PivotGridControl pivotGridControl) {
            pivotGridControl.OptionsDataField.Area = PivotDataArea.ColumnArea;
            CheckEdit ceDataFieldArea = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Data Fields in Rows", Dock = DockStyle.Top };
            ceDataFieldArea.CheckedChanged += (s, e) => {
                // Move Data Fields to the Row or Column area.
                pivotGridControl.OptionsDataField.Area = ceDataFieldArea.Checked ? PivotDataArea.RowArea : PivotDataArea.ColumnArea;
            };
            CheckEdit ceDataFieldAreaIndex = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Data Fields Before Other Fields", Dock = DockStyle.Top };
            ceDataFieldAreaIndex.CheckedChanged += (s, e) => {
                // Position data fields inside the area.
                pivotGridControl.OptionsDataField.AreaIndex = ceDataFieldAreaIndex.Checked ? 0 : -1;
            };
        }

        [CodeExampleCase("Data Cells Visibility")]
        [CodeExampleUnderlineTokens("Options", "ShowValues", "ShowTotals", "ShowGrandTotal")]
        [CodeExampleDataFile("nwind.xml")]
        public static void DataCellsVisibility(PivotGridControl pivotGridControl) {
            // The layout is changed to show totals at the grid's left side.
            pivotGridControl.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near;

            CheckEdit ceShowValues = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Values", Checked = true, Dock = DockStyle.Top };
            ceShowValues.CheckedChanged += (s, e) => {
                // Show or hide data cells.
                pivotGridControl.Fields["Quantity"].Options.ShowValues = ceShowValues.Checked;
            };
            CheckEdit ceShowTotals = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Totals", Checked = true, Dock = DockStyle.Top };
            ceShowTotals.CheckedChanged += (s, e) => {
                // Show or hide cells with totals.
                pivotGridControl.Fields["Quantity"].Options.ShowTotals = ceShowTotals.Checked;
            };
            CheckEdit ceShowGrandTotals = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Show Grand Totals", Checked = true, Dock = DockStyle.Top };
            ceShowGrandTotals.CheckedChanged += (s, e) => {
                // Show or hide cells with grand totals.
                pivotGridControl.Fields["Quantity"].Options.ShowGrandTotal = ceShowGrandTotals.Checked;
            };
        }

        [CodeExampleCase("Hiding certain rows and columns")]
        [CodeExampleUnderlineTokens("CustomFieldValueCells", "GetCellCount", "GetCell", "Remove")]
        [CodeExampleDataFile("nwind.xml")]
        public static void HidingCertainFieldValues(PivotGridControl pivotGridControl) {
            // Handle this event to hide specific column and row field values.
            pivotGridControl.CustomFieldValueCells += (s, e) => {
                if(Convert.ToString(pivotGridControl.Tag) != "HideFieldValues")
                    return;
                bool isColumn = false;

                // Iterates through all row headers.
                for(int i = e.GetCellCount(isColumn) - 1; i >= 0; i--) {
                    FieldValueCell cell = e.GetCell(isColumn, i);
                    if(cell == null) continue;

                    // If the current header relates to the "Salzburg" field value,
                    // and it is not the Total Row header,
                    // the header and all related rows are removed.
                    if(object.Equals(cell.Value, "Salzburg") && cell.ValueType != PivotGridValueType.Total)
                        e.Remove(cell);
                }
            };
            CheckEdit ceHideFieldValues = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Hide the 'Salzburg' field values", Dock = DockStyle.Top };
            ceHideFieldValues.CheckedChanged += (s, e) => {
                // Store the operation description in the Tag property and update the layout.
                pivotGridControl.Tag = ceHideFieldValues.Checked ? "HideFieldValues" : "";
                pivotGridControl.LayoutChanged();
            };
        }

        [CodeExampleCase("Hiding certain data cells")]
        [CodeExampleUnderlineTokens("CustomFieldValueCells", "FindAllCells", "Remove")]
        [CodeExampleDataFile("nwind.xml")]
        public static void HidingCertainDataCells(PivotGridControl pivotGridControl) {
            // Handle this event to hide columns and rows where all cells meet certain criteria.
            pivotGridControl.CustomFieldValueCells += (s, e) => {
                if(Convert.ToString(pivotGridControl.Tag) != "HideDataCells") {
                    return;
                }
                else {
                    bool isColumn = true;

                    // Find columns where all cells match a certain condition.
                    foreach(FieldValueCell cell in e.FindAllCells(isColumn, (dataCellValues) => dataCellValues.Any(c => Convert.ToDecimal(c) > 400) ? false : true)) {
                        e.Remove(cell);
                    }
                }
            };

            CheckEdit ceHideDataCells = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Hide all columns where cells have values less then 500", Dock = DockStyle.Top };
            ceHideDataCells.CheckedChanged += (s, e) => {
                // Store the operation description in the Tag property and update the layout.
                pivotGridControl.Tag = ceHideDataCells.Checked ? "HideDataCells" : "";
                pivotGridControl.LayoutChanged();
            };

        }

        [CodeExampleCase("Split Field Values")]
        [CodeExampleUnderlineTokens("CustomFieldValueCells", "FieldValueSplitData", "FieldValueCell", "Split")]
        [CodeExampleDataFile("nwind.xml")]
        public static void SplitFieldValues(PivotGridControl pivotGridControl) {
            // Adjust the pivot grid layout.
            pivotGridControl.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Near;
            var fieldAveragePrice = new PivotGridField("ExtendedPrice", PivotArea.DataArea) { Name = "fieldAveragePrice", SummaryType = PivotSummaryType.Average, Caption = "Price Avg" };
            fieldAveragePrice.Options.ShowValues = false;
            fieldAveragePrice.Options.ShowTotals = false;
            pivotGridControl.Fields.Add(fieldAveragePrice);

            // Handle this event to hide columns and rows where all cells match certain criteria.
            pivotGridControl.CustomFieldValueCells += (s, e) => {
                if(Convert.ToString(pivotGridControl.Tag) != "SplitFieldValue")
                    return;
                bool isColumn = true;
                // Define a predicate that returns true if the cell is a Grand Total header.
                Predicate<FieldValueCell> condition =
                new Predicate<FieldValueCell>(delegate (FieldValueCell matchCell) {
                    return matchCell.ValueType == PivotGridValueType.GrandTotal && matchCell.Field == null;
                });
                // Create a cell definition list containing the newly created cells.
                var cells = new FieldValueSplitData[] { new FieldValueSplitData("Quantity", 1), new FieldValueSplitData("Prices", 2) };
                // Split the Grand Total cells.
                e.Split(isColumn, condition, cells);
            };
            CheckEdit ceSplitFieldValues = new CheckEdit() { Parent = pivotGridControl.Parent, Text = "Split the Grand Total field value", Dock = DockStyle.Top };
            ceSplitFieldValues.CheckedChanged += (s, e) => {
                // Store the operation description in the Tag property and update the layout.
                pivotGridControl.Tag = ceSplitFieldValues.Checked ? "SplitFieldValue" : "";
                pivotGridControl.LayoutChanged();
            };
        }
        [CodeExampleCase("Hit cell info")]
        [CodeExampleUnderlineTokens("CalcHitInfo", "CellInfo")]
        [CodeExampleDataFile("nwind.xml")]
        public static void HitCellInfo(PivotGridControl pivotGridControl) {
            MemoEdit hitInfoText = new MemoEdit() { Parent = pivotGridControl.Parent, ReadOnly = true, Dock = DockStyle.Top, Height = 50 };
            hitInfoText.Properties.ScrollBars = ScrollBars.None;
            pivotGridControl.MouseMove += (s, e) => {
                var info = pivotGridControl.CalcHitInfo(new System.Drawing.Point(e.X, e.Y));
                if(info == null || info.CellInfo == null) {
                    hitInfoText.Text = "";
                    return;
                }
                var cellInfo = info.CellInfo;
                hitInfoText.Text = string.Format("Value: {0}		Cell indexis: [{1},{2}]		Data field: {3}",
                    Equals(cellInfo.Value, null) ? "empty" : cellInfo.Value,
                    cellInfo.ColumnIndex,
                    cellInfo.RowIndex,
                    cellInfo.DataField != null ? cellInfo.DataField.ToString() : "");
                var rowFields = cellInfo.GetRowFields();
                if(rowFields.Length > 0) {
                    hitInfoText.Text += Environment.NewLine + "Row fields	";
                    hitInfoText.Text += rowFields.Aggregate("", (text, f) => text + string.Format("	'{0}' : {1}", f.ToString(), f.GetDisplayText(cellInfo.GetFieldValue(f))));
                }
                var colFields = cellInfo.GetColumnFields();
                if(colFields.Length > 0) {
                    hitInfoText.Text += Environment.NewLine + "Column fields	";
                    hitInfoText.Text += colFields.Aggregate("", (text, f) => text + string.Format("	'{0}' : {1}", f.ToString(), f.GetDisplayText(cellInfo.GetFieldValue(f))));
                }
            };
        }
        [CodeExampleCase("Hit value info")]
        [CodeExampleUnderlineTokens("CalcHitInfo", "ValueInfo")]
        [CodeExampleDataFile("nwind.xml")]
        public static void HitValueInfo(PivotGridControl pivotGridControl) {
            MemoEdit hitInfoText = new MemoEdit() { Parent = pivotGridControl.Parent, ReadOnly = true, Dock = DockStyle.Top, Height = 40 };
            hitInfoText.Properties.ScrollBars = ScrollBars.None;
            pivotGridControl.MouseMove += (s, e) => {
                var info = pivotGridControl.CalcHitInfo(new System.Drawing.Point(e.X, e.Y));
                if(info == null || info.ValueInfo == null) {
                    hitInfoText.Text = "";
                    return;
                }
                var valueInfo = info.ValueInfo;
                hitInfoText.Text = string.Format("Field: {0}", valueInfo.Field);
                hitInfoText.Text += valueInfo.Value == null ? "" : string.Format("	Value: {0}", valueInfo.Value);
                if(valueInfo.Field == null)
                    hitInfoText.Text += Environment.NewLine + "grand total";
                else if(valueInfo.Field.AreaIndex > 0 && valueInfo.Field.Area != PivotArea.DataArea) {
                    hitInfoText.Text += Environment.NewLine + "Parent fields   ";
                    for(int i = 0; i < valueInfo.Field.AreaIndex; i++) {
                        var parentField = pivotGridControl.GetFieldByArea(valueInfo.Field.Area, i);
                        hitInfoText.Text += string.Format("	'{0}' : {1}", parentField.ToString(), parentField.GetDisplayText(valueInfo.GetHigherLevelFieldValue(parentField)));
                    }
                }
            };
        }
        [CodeExampleCase("Hit headers info")]
        [CodeExampleUnderlineTokens("CalcHitInfo", "HeadersAreaInfo")]
        [CodeExampleDataFile("nwind.xml")]
        public static void HitHeadersInfo(PivotGridControl pivotGridControl) {
            MemoEdit hitInfoText = new MemoEdit() { Parent = pivotGridControl.Parent, ReadOnly = true, Dock = DockStyle.Top, Height = 30 };
            hitInfoText.Properties.ScrollBars = ScrollBars.None;
            pivotGridControl.MouseMove += (s, e) => {
                var info = pivotGridControl.CalcHitInfo(new System.Drawing.Point(e.X, e.Y));
                if(info == null || info.HeadersAreaInfo == null) {
                    hitInfoText.Text = "";
                    return;
                }
                hitInfoText.Text = string.Format("Area: {0}", info.HeadersAreaInfo.Area);
                hitInfoText.Text += info.HeadersAreaInfo.Field == null ? "" : string.Format("	Field: {0}", info.HeadersAreaInfo.Field);
            };
        }
    }
}
