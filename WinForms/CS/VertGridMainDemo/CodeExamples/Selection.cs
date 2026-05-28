using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Selection", "Selection.cs")]
    public static class Selection {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(10);
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        #region Selection
        [CodeExampleCase("Enable multiple row/cell selection"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("OptionsSelection", "MultiSelect", "MultiSelectMode")]
        public static void EnableMultipleSelection(VGridControl vGridControl) {
            // Specifies whether or not end-users can select multiple rows or cells.
            vGridControl.OptionsSelectionAndFocus.MultiSelect = true;
            // Specifies whether a user can select individual cells, or only entire rows. 
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.CellSelect;
            // Available property values: RecordSelect, CellSelect, RowSelect
        }

        [CodeExampleCase("Select/deselect cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectCell", "UnselectCell")]
        public static void SelectUnselectCells(VGridControl vGridControl) {
            vGridControl.OptionsSelectionAndFocus.MultiSelect = true;
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.CellSelect;

            // Selects the cell.
            vGridControl.SelectCell(1, "Name");
            vGridControl.SelectCell(2, "Name");


            SimpleButton btnUnselect = new SimpleButton { Parent = vGridControl.Parent, Text = "Deselect cell", Dock = DockStyle.Top };
            btnUnselect.Click += (s, e) => {
                // Deselect a cell
                vGridControl.UnselectCell(1, "Name");
                vGridControl.UnselectCell(2, "Name");
            };
        }

        [CodeExampleCase("Select/deselect rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectRow", "UnSelectRow")]
        public static void SelectUnselectRows(VGridControl vGridControl) {
            vGridControl.OptionsSelectionAndFocus.MultiSelect = true;
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.RowSelect;

            // Selects the row.
            vGridControl.SelectRow("Name");

            SimpleButton btnUnselect = new SimpleButton { Parent = vGridControl.Parent, Text = "Deselect row", Dock = DockStyle.Top };
            btnUnselect.Click += (s, e) => {
                // Deselect a row.
                vGridControl.UnselectRow("Name");
            };
        }

        [CodeExampleCase("Select/deselect records"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectRecord", "UnSelectRecord")]
        public static void SelectUnselectRecords(VGridControl vGridControl) {
            vGridControl.OptionsSelectionAndFocus.MultiSelect = true;
            vGridControl.OptionsSelectionAndFocus.MultiSelectMode = MultiSelectMode.RecordSelect;

            // Selects the record.
            vGridControl.SelectRecord(2);

            SimpleButton btnUnselect = new SimpleButton { Parent = vGridControl.Parent, Text = "Deselect record", Dock = DockStyle.Top };
            btnUnselect.Click += (s, e) => {
                // Deselect a record.
                vGridControl.UnselectRecord(2);
            };
        }
        #endregion Selection
    }
}
