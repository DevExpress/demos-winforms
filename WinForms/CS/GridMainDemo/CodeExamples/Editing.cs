using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.XtraGrid.Views.Base;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Edit cells and obtain cell values", "Editing.cs")]
    public static class Editing {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(6);
            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }


        #region Helpers

        [CodeExampleNestedClass("")]
        public static class DemoHelper {

            public static Image GetDeleteImage() {
                return GetImage(Brushes.Red);
            }

            public static Image GetEditImage() {
                return GetImage(Brushes.Green);
            }

            public static Image GetImage(Brush b) {
                Image img = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(img)) {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(b, new Rectangle(0, 0, img.Width - 1, img.Height - 1));
                }
                return img;
            }
        }

        #endregion

        #region Edit cells and obtain cell values
        [CodeExampleCase("Non editable mode"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("Editable")]
        public static void MakeGridViewNonEditable(GridControl gridControl, GridView gridView) {
            // The Editable property allows end-users to invoke cell editors 
            gridView.OptionsBehavior.Editable = false;
        }
        [CodeExampleCase("Read-only mode (allow copying individual cell values)"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ReadOnly")]
        public static void MakeGridViewReadOnly(GridControl gridControl, GridView gridView) {
            // The ReadOnly property enables the read-only status for the current View. 
            gridView.OptionsBehavior.ReadOnly = true;
        }
        [CodeExampleCase("Read-only mode for certain cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShownEditor")]
        public static void MakeCertainCellsReadOnly(GridControl gridControl, GridView gridView) {
            // You can handle the ShownEditor event to manage the 
            // settings of an active editor
            gridView.ShownEditor += (s, e) => {
                GridView view = s as GridView;
                view.ActiveEditor.Properties.ReadOnly = gridView.FocusedColumn.FieldName == "ID" && gridView.FocusedRowHandle % 2 == 0;
            };
        }
        [CodeExampleCase("Prohibit editing certain GridView's cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShowingEditor")]
        public static void PreventEditingCertainCells(GridControl gridControl, GridView gridView) {
            // You can handle the ShowingEditor event to cancel editor activation
            gridView.ShowingEditor += (s, e) => {
                e.Cancel = gridView.FocusedColumn.FieldName == "ID" && gridView.FocusedRowHandle % 2 == 0;
            };
        }
        [CodeExampleCase("Change column cell values based on another column values"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CellValueChanged")]
        public static void ChangingCellValuesBasedOnOtherCellValues(GridControl gridControl, GridView gridView) {
            // Changing cell values of one column based on values of another one            
            gridView.CellValueChanged += (sender, e) => {
                GridView view = sender as GridView;
                if (e.Column.FieldName == "Length") {
                    double doubleVal = (double)e.Value;
                    view.SetRowCellValue(e.RowHandle, "Mark", doubleVal > 10);
                }
            };
        }
        [CodeExampleCase("Iterating through grid rows and accessing cell values"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GetRowCellValue")]
        public static void IteratingThroughGridRowsAndAccessingCellValues(GridControl gridControl, GridView gridView) {
            // Iterating through grid rows and accessing cell values            
            string text = "Ids of rows that have the checked state" + Environment.NewLine;
            for (int i = 0; i < gridView.DataRowCount; i++) {
                bool boolVal = (bool)gridView.GetRowCellValue(i, "Mark");
                if (boolVal) {
                    object id = gridView.GetRowCellValue(i, "ID");
                    text += id.ToString() + Environment.NewLine;
                }
            }
            XtraMessageBox.Show(text);
        }
        [CodeExampleCase("Cell commands to edit and delete rows", new Type[] { typeof(DemoHelper) }), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomRowCellEditForEditing", "CustomRowCellEdit", "ShowingEditor", "EditFormPrepared")]
        public static void CommandsColumn(GridControl gridControl, GridView gridView) {
            // Create the Commands column editor
            RepositoryItemButtonEdit commandsEdit = new RepositoryItemButtonEdit { AutoHeight = false, Name = "CommandsEdit", TextEditStyle = TextEditStyles.HideTextEditor };
            commandsEdit.Buttons.Clear();
            commandsEdit.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Glyph, "Edit", -1, true, true, false, ImageLocation.MiddleLeft, DemoHelper.GetEditImage()),
            new EditorButton(ButtonPredefines.Glyph, "Delete", -1, true, true, false, ImageLocation.MiddleLeft, DemoHelper.GetDeleteImage())});

            // Create an unbound Commands column
            GridColumn _commandsColumn = gridView.Columns.AddField("Commands");
            _commandsColumn.UnboundDataType = typeof(object);
            _commandsColumn.Visible = true;
            _commandsColumn.Width = 100;

            // Hide commandsColumn from EditForm
            _commandsColumn.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;

            // Display commands only for focused row
            gridView.CustomRowCellEdit += (s, e) => {
                if (e.RowHandle == gridView.FocusedRowHandle && e.Column == _commandsColumn)
                    e.RepositoryItem = commandsEdit;
            };
            gridView.CustomRowCellEditForEditing += (s, e) => {
                if (e.RowHandle == gridView.FocusedRowHandle && e.Column == _commandsColumn)
                    e.RepositoryItem = commandsEdit;
            };

            // Allow only commandsColumn to be edited
            gridView.ShowingEditor += (s, e) => {
                e.Cancel = gridView.FocusedColumn != _commandsColumn;
            };

            gridView.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            gridView.OptionsBehavior.EditingMode = GridEditingMode.EditFormInplace;

            // Perform a specific action when an EditorButton is clicked
            commandsEdit.ButtonClick += (s, e) => {
                switch (e.Button.Caption) {
                    case "Edit":
                        // Start edit a row using EditForm
                        gridView.CloseEditor();
                        gridView.ShowEditForm();
                        break;
                    case "Delete":
                        // Delete focused row
                        gridControl.BeginInvoke(new MethodInvoker(() => { gridView.DeleteRow(gridView.FocusedRowHandle); }));
                        break;
                }
            };
        }
        [CodeExampleCase("Post data to an underlying data source immediately"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("EditValueChanged", "ShownEditor", "PostEditor", "UpdateCurrentRow", "HiddenEditor", "RowUpdated")]
        public static void PostDataToAnUnderlyingDataSourceImmediately(GridControl gridControl, GridView gridView) {

            EventHandler editValueChanged = (s, e) => {
                gridView.PostEditor();
                gridView.UpdateCurrentRow();
            };

            BaseEdit edit = null;
            gridView.ShownEditor += (s, e) => {
                GridView view = s as GridView;
                edit = view.ActiveEditor;
                edit.EditValueChanged += editValueChanged;
            };
            gridView.HiddenEditor += (s, e) => {
                edit.EditValueChanged -= editValueChanged;
                edit = null;
            };
            gridView.RowUpdated += (s, e) => {
                //  Post data to a connected data base here
                XtraMessageBox.Show("Row is updated.");
            };
        }
        [CodeExampleCase("Disable buttons in certain rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("RepositoryItemButtonEdit", "Assign", "CustomRowCellEdit")]
        public static void DisableButtonsInCertainRows(GridControl gridControl, GridView gridView) {

            gridView.OptionsView.ShowButtonMode = ShowButtonModeEnum.ShowAlways;

            RepositoryItemButtonEdit riButtonEditEnabled = new RepositoryItemButtonEdit();
            riButtonEditEnabled.Buttons.Clear();
            riButtonEditEnabled.Buttons.Add(new EditorButton(ButtonPredefines.Plus, "Copy cell value"));
            riButtonEditEnabled.Buttons.Add(new EditorButton(ButtonPredefines.Delete, "Clear this cell"));

            RepositoryItemButtonEdit riButtonEditDisabled = new RepositoryItemButtonEdit();
            // Create a similar RepositoryItem 
            riButtonEditDisabled.Assign(riButtonEditEnabled);
            // Disable all buttons
            riButtonEditDisabled.Buttons.ToList<EditorButton>().ForEach(button => button.Enabled = false);

            gridView.CustomRowCellEdit += (s, e) => {
                if (e.Column.FieldName == "Notes") {
                    GridView view = s as GridView;
                    bool actionsAvailable = Convert.ToBoolean(view.GetRowCellValue(e.RowHandle,"Mark"));
                    e.RepositoryItem = actionsAvailable ? riButtonEditEnabled : riButtonEditDisabled;
                }
            };
        }

        #endregion
    }
}
