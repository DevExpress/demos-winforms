namespace Examples {
    using System;
    using System.Windows.Forms;
    using DevExpress.Data.Filtering;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;

    [CodeExampleClass("Filter and search", "FilterAndSearch.cs")]
    public static class FilterAndSearch {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.Load += (s, e) => treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Search using the Find Panel")]
        [CodeExampleUnderlineTokens("ApplyFindFilter")]
        public static void SetFindPanelTextInCode(TreeList treeList) {
            //The AlwaysVisible property is used to determine whether the Find Panel is always visible.
            treeList.OptionsFind.AlwaysVisible = true;
            //The ApplyFindFilter method searches for the specified string, using the search functionality provided by the Find Panel
            //    You can call this method in code, to manually invoke the search.
            treeList.ApplyFindFilter("Sa 5");
        }
        [CodeExampleCase("Search by specific columns using the Find Panel")]
        [CodeExampleUnderlineTokens("ApplyFindFilter")]
        public static void ColumnFindPanelSearch(TreeList treeList) {
            //The AlwaysVisible property is used to determine whether the Find Panel is always visible.
            treeList.OptionsFind.AlwaysVisible = true;
            // Perform search by the for the specific column
            treeList.ApplyFindFilter("Name:Sa");

            //You can also specify the columns which will be used for searching
            //   using the OptionsFind.FindFilterColumns property
            //treeList.OptionsFind.FindFilterColumns = "Name";
            //treeList.ApplyFindFilter("Sa"); 
        }
        [CodeExampleCase("Filter data"), CodeExampleVersionID(171)]
        [CodeExampleUnderlineTokens("ActiveFilterString")]
        public static void ActiveFilterString(TreeList treeList) {
            // Set filter string.
            treeList.ActiveFilterString = "Contains(Name, 'Sa') OR MeanRadiusByEarth > 5";
        }
        [CodeExampleCase("Filter by the specific column"), CodeExampleVersionID(171)]
        [CodeExampleUnderlineTokens("ActiveFilter")]
        public static void ActiveFilter(TreeList treeList) {
            // The ActiveFilter property returns an object which represents the filter criteria for the TreeList.
            treeList.ActiveFilter.Add(treeList.Columns["Name"], new TreeListColumnFilterInfo("Contains(Name, 'Sa')"));
        }
        [CodeExampleCase("Filter using AutoFilterRow"), CodeExampleVersionID(171)]
        [CodeExampleUnderlineTokens("AutoFilter", "SetAutoFilterValue")]
        public static void AutoFilterRow(TreeList treeList) {
            treeList.OptionsView.ShowAutoFilterRow = true;
            // Set auto-filter for the specific column.
            treeList.SetAutoFilterValue(treeList.Columns["Name"], "Sa", AutoFilterCondition.Contains);
        }
        [CodeExampleCase("Filter nodes dynamically"), CodeExampleVersionID(171)]
        [CodeExampleUnderlineTokens("CustomRowFilter", "Handled")]
        public static void CustomNodeFilter(TreeList treeList) {
            //The CustomRowFilter event allows you to hide nodes or make them visible regardless of the active filter.
            treeList.CustomRowFilter += (s, e) =>
            {
                e.Visible = (double)e.Node["MeanRadiusByEarth"] > 5.0;
                e.Handled = true;
            };
        }
    }
}
