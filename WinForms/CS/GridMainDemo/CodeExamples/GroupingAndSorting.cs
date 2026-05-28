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
using System.Collections;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Group and sort data", "GroupingAndSorting.cs")]
    public static class GroupingAndSorting {
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

        #region Grouping and Sorting
        [CodeExampleCase("Sort against columns"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SortOrder")]
        public static void SortAgainstColumns(GridControl gridControl, GridView gridView) {
            // The SortOrder property value is used to determine 
            // which sort order is currently applied to the column
            gridView.Columns["Length"].SortOrder = ColumnSortOrder.Ascending;
            gridView.Columns["Mark"].SortOrder = ColumnSortOrder.Descending;
        }
        [CodeExampleCase("Custom sorting"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomColumnSort", "SortMode", "Result")]
        public static void CustomSorting(GridControl gridControl, GridView gridView) {
            // Custom Column Sorting            
            GridColumn column = gridView.Columns["Length"];
            column.SortMode = ColumnSortMode.Custom;
            gridView.CustomColumnSort += (sender, e) => {
                // Always show 0 at the bottom
                if (e.Column.FieldName == "Length") {
                    if ((double)e.Value1 == 0 && (double)e.Value2 != 0) {
                        e.Result = e.SortOrder == ColumnSortOrder.Ascending ? 1 : -1;
                    }
                    else if ((double)e.Value2 == 0 && (double)e.Value1 != 0) {
                        e.Result = e.SortOrder == ColumnSortOrder.Ascending ? -1 : 1;
                    }
                    else {
                        // default comparison
                        e.Result = Comparer.Default.Compare(e.Value1, e.Value2);
                    }
                    e.Handled = true;
                }
            };
            column.SortOrder = ColumnSortOrder.Ascending;
        }
        [CodeExampleCase("Hide group rows’ expand/collapse buttons"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomDrawGroupRow")]
        public static void HideGroupRowButton(GridControl gridControl, GridView gridView) {            
            gridView.Columns[0].Group();
            // Allows you to paint group rows manually
            gridView.CustomDrawGroupRow += (s, e) => {
                GridGroupRowInfo ggri = e.Info as GridGroupRowInfo;
                // Reduce the size of the expand-collapse button to zero
                ggri.ButtonBounds = Rectangle.Empty;
            };
        }
        [CodeExampleCase("Prevent group rows from being collapsed"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GroupRowCollapsing", "Allow")]
        public static void PreventCollapsingGroupRows(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Mark"].Group();
            gridView.ExpandAllGroups();
            // The GroupRowCollapsing event is raised on an attempt to collapse a group row
            gridView.GroupRowCollapsing += (s, e) => {
                GridView view = s as GridView;
                // Restricting Full Collapse
                if(e.RowHandle == GridControl.InvalidRowHandle)
                    e.Allow = false;
                else {
                    // Restricting "Checked" group rows from being collapsed
                    if((bool)view.GetGroupRowValue(e.RowHandle))
                        e.Allow = false;
                }
            };
        }
        [CodeExampleCase("Prevent group rows from being expanded"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("GroupRowExpanding", "Allow")]
        public static void PreventExpandingGroupRows(GridControl gridControl, GridView gridView) {            
            gridView.Columns["Mark"].Group();
            // The GroupRowExpanding event is raised on an attempt to expand a group row
            gridView.GroupRowExpanding += (s, e) => {
                GridView view = s as GridView;
                // Restricting Full Expand
                if(e.RowHandle == GridControl.InvalidRowHandle)
                    e.Allow = false;
                else {
                    // Restricting "Checked" group rows from being expanded
                    if((bool)view.GetGroupRowValue(e.RowHandle))
                        e.Allow = false;
                }
            };
        }
        #endregion

    }
}
