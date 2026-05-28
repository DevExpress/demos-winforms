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
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Controls;
using DevExpress.Data.Filtering;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Cell editors", "CellEditors.cs")]
    public static class CellEditors {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(10);
            gridView.PopulateColumns();

            return new object[] { gridControl, gridView };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }

        #region Cell editors

        [CodeExampleCase("Assign in-place editors dynamically"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("spinEdit", "calcEdit", "CustomRowCellEdit")]
        public static void AssignInPalceEditorsDynamically(GridControl gridControl, GridView gridView) {
            RepositoryItemSpinEdit spinEdit = new RepositoryItemSpinEdit();
            RepositoryItemCalcEdit calcEdit = new RepositoryItemCalcEdit();

            gridView.Columns["Length"].ShowButtonMode = ShowButtonModeEnum.ShowAlways;

            // Handle this event to assign editors to individual cells
            gridView.CustomRowCellEdit += (sender, e) => {
                GridView view = sender as GridView;
                if(e.Column.FieldName == "Length") {
                    bool boolVal = (bool)view.GetRowCellValue(e.RowHandle, "Mark");
                    if(boolVal)
                        e.RepositoryItem = spinEdit;
                    else
                        e.RepositoryItem = calcEdit;
                }
            };
        }

        [CodeExampleCase("Override the default in-place editor for certain cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomRowCellEditForEditing", "gridLookUpEdit")]
        public static void OverrideTheDefaultInPlaceEditorForCertainCells(GridControl gridControl, GridView gridView) {
            RepositoryItemGridLookUpEdit gridLookUpEdit = new RepositoryItemGridLookUpEdit() {
                DisplayMember = "ID",
                ValueMember = "ID",
            };
            gridControl.RepositoryItems.Add(gridLookUpEdit);
            // The ID column uses a text editor by default.
            // The CustomRowCellEditForEditing event is handled to override this editor for rows. 
            gridView.CustomRowCellEditForEditing += (sender, e) => {
                if(e.Column.FieldName == "ID") {
                    // Assign data to gridLookUpEdit dynamically
                    gridLookUpEdit.DataSource = SampleData.GetData(10);
                    e.RepositoryItem = gridLookUpEdit;
                }
            };
            gridView.ShowEditor();
            (gridView.ActiveEditor as GridLookUpEdit).ShowPopup();
        }

        [CodeExampleCase("Assign in-place editors (repository items)"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ColumnEdit")]
        public static void AssignInPlaceEditors(GridControl gridControl, GridView gridView) {
            // Assign a repository item to a column            
            RepositoryItemToggleSwitch edit = new RepositoryItemToggleSwitch();
            gridControl.RepositoryItems.Add(edit);
            gridView.Columns["Mark"].ColumnEdit = edit;
        }

        [CodeExampleCase("Show buttons in grid cells"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ColumnEdit", "ShowButtonMode")]
        public static void ShowButtonsInGridCells(GridControl gridControl, GridView gridView) {
            // Show a button in a grid cell            
            RepositoryItemButtonEdit edit = new RepositoryItemButtonEdit();
            edit.ButtonClick += (sender, e) => {
                if(e.Button.Kind == ButtonPredefines.Delete) {
                    if(XtraMessageBox.Show("Do you wish to remove this row?", "Confirmation Dialog", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        gridView.DeleteRow(gridView.FocusedRowHandle);
                    }
                }
            };
            edit.Buttons[0].Kind = ButtonPredefines.Delete;
            edit.Buttons[0].Caption = "Custom Button";
            gridControl.RepositoryItems.Add(edit);
            GridColumn column = gridView.Columns["ID"];
            column.ColumnEdit = edit;
            column.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
        }

        [CodeExampleCase("In-place mode immediate post changes"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ColumnEdit")]
        public static void InplaceModeImmediatePostChanges(GridControl gridControl, GridView gridView) {
            // Immediate post changes
            RepositoryItemCheckEdit edit = new RepositoryItemCheckEdit() {
                InplaceModeImmediatePostChanges = DefaultBoolean.True
            };
            gridControl.RepositoryItems.Add(edit);
            gridView.Columns["Mark"].ColumnEdit = edit;

            GridColumn messageColumn = new GridColumn() {
                FieldName = "Message",
                Visible = true,
                UnboundDataType = typeof(string),
                UnboundExpression = "Iif([Mark], '', 'Not available in your region')",
            };
            gridView.Columns.Add(messageColumn);
        }

        #endregion
    }
}
