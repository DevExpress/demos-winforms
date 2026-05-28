using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using System.ComponentModel;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Filtering;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Filter and search", "FilterAndSearch.cs")]
    public static class FilterAndSearch {
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

        #region Filtering and Searching
        [CodeExampleCase("Filter data using ActiveFilterString"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ActiveFilterString")]
        public static void FilterGridViewInCodeUsingActiveFilterString(GridControl gridControl, GridView gridView) {
            gridView.ActiveFilterString = "Contains([Name], 'Blue')";
        }

        [CodeExampleCase("Filter data using ActiveFilter"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ActiveFilterCriteria", "ActiveFilter")]
        public static void FilterGridViewInCode(GridControl gridControl, GridView gridView) {
            SimpleButton btnAddFilter = new SimpleButton { Parent = gridControl.Parent, Text = "Add additional filter", Dock = DockStyle.Top };
            btnAddFilter.Click += (s, e) => {
                // The ActiveFilter property returns an object which represents the filter criteria for the current View
                gridView.ActiveFilter.Add(gridView.Columns["ID"], new ColumnFilterInfo(string.Format("[{0}] > '3'", "ID"), ""));
            };

            SimpleButton bthApplyFilter = new SimpleButton { Parent = gridControl.Parent, Text = "Apply new filter", Dock = DockStyle.Top };
            bthApplyFilter.Click += (s, e) => {
                CriteriaOperator expr1 = new BinaryOperator("ID", 2, BinaryOperatorType.GreaterOrEqual);
                CriteriaOperator expr2 = new BinaryOperator("Length", 25, BinaryOperatorType.Greater);

                // Use the ActiveFilterCriteria property to specify the filter criteria 
                // by using the DevExpress.Data.Filtering.CriteriaOperator object
                gridView.ActiveFilterCriteria = GroupOperator.Or(new CriteriaOperator[] { expr1, expr2 });
            };
            CheckEdit chkFilterEnabled = new CheckEdit { Parent = gridControl.Parent, Text = "ActiveFilterEnabled ", Dock = DockStyle.Top };

            // The filter can be temporarily disabled by using the GridView.ActiveFilterEnabled property
            chkFilterEnabled.DataBindings.Add(new Binding("EditValue", gridView, "ActiveFilterEnabled", false, DataSourceUpdateMode.OnPropertyChanged));
        }
        [CodeExampleCase("Search using the Find Panel"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ApplyFindFilter")]
        public static void SetFindPanelTextInCode(GridControl gridControl, GridView gridView) {            
            // The AlwaysVisible property is used to determine whether the Find Panel is always visible
            gridView.OptionsFind.AlwaysVisible = true;
            // The ApplyFindFilter method searches for the specified string, using the search functionality provided by the Find Panel
            // You can call this method in code, to manually invoke the search.
            gridView.ApplyFindFilter("Blue");
        }
        [CodeExampleCase("Display a custom filter dialog"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomFilterDialog", "ShowFilterEditor")]
        public static void CustomFilterDialog(GridControl gridControl, GridView gridView) {            
            foreach (GridColumn col in gridView.Columns)
                col.OptionsFilter.FilterPopupMode = FilterPopupMode.List;
            // The CustomFilterDialog event allows replacing the default CustomFilterDialog with custom filtering facilities.
            gridView.CustomFilterDialog += (s, e) => {
                gridView.GridControl.BeginInvoke(new MethodInvoker(() => { 
                    gridView.ShowFilterEditor(e.Column); 
                }));
                e.Handled = true;
            };
        }
        [CodeExampleCase("Show the Filter Editor"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShowFilterEditor")]
        public static void ShowFilterEditor(GridControl gridControl, GridView gridView) {
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Show Filter Editor", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                // Display the Filter Editor
                gridView.ShowFilterEditor(gridView.FocusedColumn);
            };
        }

        [CodeExampleCase("Filter rows dynamically"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomRowFilter", "Visible")]
        public static void CustomRowFilter(GridControl gridControl, GridView gridView) {            
            // The CustomRowFilter event allows you to hide rows or make them visible regardless of the active filter.
            gridView.CustomRowFilter += (s, e) => {
                GridView view = s as GridView;
                BindingList<SampleData> lst = view.DataSource as BindingList<SampleData>;
                SampleData current = lst[e.ListSourceRow];
                if (current.ID > 2)
                    e.Visible = true;
                else
                    e.Visible = false;

                e.Handled = true;
            };
        }
        [CodeExampleCase("Customize the Filter Editor when it is displayed"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ShowFilterEditor", "FilterEditorCreated", "BeforeShowValueEditor")]
        public static void FilterEditorCreated(GridControl gridControl, GridView gridView) {            
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Show Filter Editor", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.ShowFilterEditor(gridView.Columns["ID"]);
            };

            ShowValueEditorEventHandler handler = (s, e) => {
                if (e.CurrentNode.FirstOperand.PropertyName != "ID") return;
                e.CustomRepositoryItem = new RepositoryItemSpinEdit();
            };

            // Handle this event to customize the FilterEditor or prevent it from being displayed
            gridView.FilterEditorCreated += (s, e) => {
                e.FilterControl.BeforeShowValueEditor -= handler;
                e.FilterControl.BeforeShowValueEditor += handler;
            };
        }
        [CodeExampleCase("Replace a filter when it is applied"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ActiveFilterCriteria", "SubstituteFilter", "Filter")]
        public static void SubstituteFilter(GridControl gridControl, GridView gridView) {           
            SimpleButton b = new SimpleButton { Parent = gridControl.Parent, Text = "Apply Filter", Dock = DockStyle.Top };
            b.Click += (s, e) => {
                gridView.ActiveFilterCriteria = CriteriaOperator.Parse(string.Format("{0} > 0", "ID"));
            };

            //Handle the SubstituteFilter event to replace a filter applied with another filter.
               //Do not modify the existing filter object assigned to the Filter event parameter. 
               //To replace this filter, assign a new filter criterion to this parameter.     
            gridView.SubstituteFilter += (s, e) => {
                //Display records with ID <5 
                e.Filter &= CriteriaOperator.Parse(string.Format("{0} < 5", "ID"));
            };
        }
        [CodeExampleCase("Obtain filtered rows"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("ActiveFilterString")]
        public static void GetFilteredRows(GridControl gridControl, GridView gridView) {
            gridView.ActiveFilterString = "Contains([Name], 'Blue')";

            SimpleButton btnObtainFilteredRows = new SimpleButton { Parent = gridControl.Parent, Text = "Obtain filtered rows", Dock = DockStyle.Top };
            btnObtainFilteredRows.Click += (s, e) => {
                List<SampleData> filteredRows = new List<SampleData>();
                for(int i = 0; i < gridView.RowCount; i++) { // traverse through all currently visible rows within GridView
                    SampleData row = (SampleData)gridView.GetRow(i); // obtain an object that represents the processed row in a grid data source
                    filteredRows.Add(row);
                }

                XtraMessageBox.Show(string.Format("Filtered rows: {0}", filteredRows.Count));
            };

        }
        [CodeExampleCase("Hide duplicate values"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomRowFilter")]
        public static void HideDuplicateValues(GridControl gridControl, GridView gridView) {
            // Handle this event to hide particular rows based on your own rules
            gridView.CustomRowFilter += (s, e) => {
                IList<SampleData> dataSource = gridControl.DataSource as IList<SampleData>;
                SampleData currentRow = dataSource[e.ListSourceRow];
                SampleData processedRow;
                for(int i = e.ListSourceRow - 1; i > -1; i--) {
                    processedRow = dataSource[i];
                    if(currentRow.Mark == processedRow.Mark) {
                        e.Visible = false;
                        e.Handled = true;
                        break;
                    }
                }
            };
        }
        #endregion

    }
}
