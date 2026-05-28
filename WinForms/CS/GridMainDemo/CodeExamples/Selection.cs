using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Selection", "Selection.cs")]
    public static class Selection {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(10);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        

        #region Selection
        [CodeExampleCase("Enable multiple row/cell selection"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("OptionsSelection", "MultiSelect", "MultiSelectMode")]
        public static void EnableMultipleSelection(GridControl gridControl, GridView gridView) {            
            // This property controls whether multi-select feature is enabled
            gridView.OptionsSelection.MultiSelect = true;
            // Controls whether multiple cells or rows can be selected
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            // Available modes:
            // CellSelect - Individual cells and blocks of cells can be selected.  
            // CheckBoxRowSelect - Multiple rows can be selected using the mouse, keyboard and built-in Check column. Individual cells cannot be selected. 
            // RowSelect - Multiple rows can be selected using the mouse and keyboard. Individual cells cannot be selected.
        }

        [CodeExampleCase("Select/unselect cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectCell", "UnselectCell")]
        public static void SelectUnselectCells(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;

            // Selects the cell.
            gridView.SelectCell(2, gridView.Columns["Name"]);

            SimpleButton btnUnselect = new SimpleButton { Parent = gridControl.Parent, Text = "Unselect cell", Dock = DockStyle.Top };
            btnUnselect.Click += (s, e) => {
                // Unselects a cell
                gridView.UnselectCell(2, gridView.Columns["Name"]);
            };
        }

        [CodeExampleCase("Select/unselect rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectRow", "UnSelectRow")]
        public static void SelectUnselectRows(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

            // Selects the row.
            gridView.SelectRow(2);

            SimpleButton btnUnselect = new SimpleButton { Parent = gridControl.Parent, Text = "Unselect row", Dock = DockStyle.Top };
            btnUnselect.Click += (s, e) => {
                // Unselects a row.
                gridView.UnselectRow(2);
            };
        }

        [CodeExampleCase("Select cell ranges"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectCells")]
        public static void SelectUnselectCellRange(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.CellSelect;

            // Clear previous selection.
            gridView.ClearSelection();

            int startRowHandle = 2;
            int endRowHandle = 4;
            GridColumn startColumn = gridView.Columns["ID"];
            GridColumn endColumn = gridView.Columns["Mark"];
            // Selects multiple cells.
            gridView.SelectCells(startRowHandle, startColumn, endRowHandle, endColumn);
        }

        [CodeExampleCase("Select row ranges"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SelectRows")]
        public static void SelectUnselectRowRange(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

            // Clear previous selection.
            gridView.ClearSelection();

            // Selects multiple rows.
            gridView.SelectRows(2,5);
        }

        [CodeExampleCase("Obtain selected rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GetSelectedRows")]
        public static void ObtainSelectedRows(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;

            gridView.SelectRows(2, 4);

            //Display currently selected rows in a separate form
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Obtain selected rows", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                BindingList<SampleData> selectedRows = new BindingList<SampleData>();

                foreach (int rowHandle in gridView.GetSelectedRows())
                    selectedRows.Add(gridView.GetRow(rowHandle) as SampleData);

                XtraForm frm = new XtraForm { StartPosition = FormStartPosition.CenterParent };
                GridView frmGridView = new GridView();
                GridControl frmGrid = new GridControl {
                    MainView = frmGridView,
                    Parent = frm,
                    DataSource = selectedRows,
                    Dock = DockStyle.Fill
                };
                frm.ShowDialog(gridControl.FindForm());
            };
        }

        [CodeExampleCase("Prevent rows from being selected"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GetSelectedRows", "UnselectRow")]
        public static void PreventSelectUnselectRows(GridControl gridControl, GridView gridView) {
            gridView.OptionsSelection.MultiSelect = true;
            gridView.OptionsSelection.MultiSelectMode = GridMultiSelectMode.RowSelect;
            gridView.SelectRows(2, 5);

            List<int> rowsWhichCannotBeSelected = new List<int> { 0, 1, 6, 7, 8, 9 };

            //This property is used to avoid recursive invocation of the SelectionChanged event handler
            bool lockSelectionChanged = false;
            // The SelectionChanged event fires each time selection is changed in multiple selection mode
            gridView.SelectionChanged += (s, e) => {
                if (lockSelectionChanged) return;
                lockSelectionChanged = true;
                GridView view = s as GridView;

                foreach (int rowHandle in view.GetSelectedRows()) {
                    if (rowsWhichCannotBeSelected.Contains(rowHandle))
                        view.UnselectRow(rowHandle);
                }
                lockSelectionChanged = false;
            };
        }

        [CodeExampleCase("How to select a column in Excel style"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AppearanceCell")]
        public static void SelectColumnExcelStyle(GridControl gridControl, GridView gridView) {
            List<string> selectedColumns = new List<string>();
            gridView.MouseDown += (object sender, MouseEventArgs e) => {
                GridView view = sender as GridView;
                GridHitInfo info = view.CalcHitInfo(new Point(e.X, e.Y)); // Obtain Hit Information identifying a visual element of the control under a specific point
                if (info.InColumn) {
                    if (!selectedColumns.Contains(info.Column.FieldName)) {
                        info.Column.AppearanceCell.Assign(view.PaintAppearance.SelectedRow); // Modify the selected column's visual settings like color, font etc
                        selectedColumns.Add(info.Column.FieldName);
                    }
                    else {
                        selectedColumns.Remove(info.Column.FieldName);
                        info.Column.AppearanceCell.Reset(); // Reset the appearance settings to their default values
                    }
                    DXMouseEventArgs.GetMouseArgs(e).Handled = true;
                }
            };
        }

        #endregion
    }
}
