namespace DevExpress.XtraGrid.Demos.CodeExamples {
    using System;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Views.Grid;
    using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

    [CodeExampleClass("Add and remove rows", "AddAndRemoveRows.cs")]
    public static class AddAndRemoveRows {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            gridControl.DataSource = SampleData.GetData(6);
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        #region Add and remove rows
        [CodeExampleCase("Use New Item Row to add rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("NewItemRowPosition")]
        public static void UseNewItemRowToAddRows(GridControl gridControl, GridView gridView) {
            // Display a New Item Row to add rows to the View.
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top; // Available modes: Top, Bottom, None
        }
        [CodeExampleCase("Init newly added rows in a custom manner"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("InitNewRow")]
        public static void InitNewRow(GridControl gridControl, GridView gridView) {
            gridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;

            //Handle the InitNewRow event to initialize newly added rows. To initialize row cells use the SetRowCellValue method
            gridView.InitNewRow += (s, e) => {
                GridView view = s as GridView;
                view.SetRowCellValue(e.RowHandle, view.Columns["RecordDate"], DateTime.Today); // Set the new row cell value
                view.SetRowCellValue(e.RowHandle, view.Columns["Name"], "CustomName");
                int newRowID = Convert.ToInt32(view.GetRowCellValue(e.RowHandle, "ID")); // Obtain the new row cell value 
                view.SetRowCellValue(e.RowHandle, view.Columns["Notes"], string.Format("Row ID: {0}", newRowID));
            };
        }
        [CodeExampleCase("Remove rows with the Ctrl+Delete shortcut"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("DeleteSelectedRows")]
        public static void RemoveRowWhenShortCutIsPressed(GridControl gridControl, GridView gridView) {
            gridView.OptionsBehavior.Editable = false;
            // Handle the ProcessGridKey event to process key presses before they are processed by the gridcontrol.
            gridControl.ProcessGridKey += (s, e) => {
                if (e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control) {
                    if (XtraMessageBox.Show("Delete row(s)?", "Delete rows dialog", MessageBoxButtons.YesNo) !=
                      DialogResult.Yes)
                        return;
                    GridControl grid = s as GridControl;
                    GridView view = grid.FocusedView as GridView;
                     //Deletes the selected rows in multiple selection mode or focused row
                     //  in single selection mode. 
                    view.DeleteSelectedRows();
                }
            };
        }
        [CodeExampleCase("Prevent a row from being deleted"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("DeleteSelectedRows", "RowDeleting")]
        public static void PreventDeletingRow(GridControl gridControl, GridView gridView) {
            gridView.OptionsBehavior.Editable = false;

            SimpleButton btnDeleteRow = new SimpleButton { Parent = gridControl.Parent, Text = "Delete focused row", Dock = DockStyle.Top };
            btnDeleteRow.Click += (s, e) => {
                //Deletes the selected rows in multiple selection mode or focused row
                //   in single selection mode. 
                gridView.DeleteSelectedRows();
            };
            //The RowDeleting event allows you to prevent row deletion
            gridView.RowDeleting += (s, e) => {
                e.Cancel = XtraMessageBox.Show(string.Format("Delete row? (RowHandle = {0} ListSourceIndex = {1})", e.RowHandle, e.ListSourceIndex),
                    "Delete rows dialog", MessageBoxButtons.YesNo) != DialogResult.Yes;
            };
        }
        #endregion
    }
}
