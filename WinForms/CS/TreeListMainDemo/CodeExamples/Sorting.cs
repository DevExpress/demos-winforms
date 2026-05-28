namespace Examples {
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;

    [CodeExampleClass("Sorting", "Sorting.cs")]
    public static class Sorting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.Load += (s, e) =>
                treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("Sorting by the specific column")]
        [CodeExampleUnderlineTokens("SortOrder")]
        public static void ColumnSort(TreeList treeList) {
            // Set sorting for the specific column
            treeList.Columns["MeanRadiusByEarth"].SortOrder = SortOrder.Ascending;
        }
        [CodeExampleCase("Sorting by multiple columns")]
        [CodeExampleUnderlineTokens("SortOrder", "BeginSort", "EndSort")]
        public static void MultiColumnSort(TreeList treeList) {
            // Set sorting for multiple columns
            treeList.BeginSort();
            treeList.Columns["MeanRadiusByEarth"].SortOrder = SortOrder.Ascending;
            treeList.Columns["MeanRadiusInKM"].SortOrder = SortOrder.Descending;
            treeList.EndSort();
        }
        [CodeExampleCase("Sorting by the related column"), CodeExampleVersionID(171)]
        [CodeExampleUnderlineTokens("SortOrder", "FieldNameSort", "FilterBySortField")]
        public static void AnotherColumnSort(TreeList treeList) {
            // set sorting for the specific column (FilterBySortField should be enabled)
            TreeListColumn colName = treeList.Columns["Name"];
            colName.OptionsFilter.FilterBySortField = DevExpress.Utils.DefaultBoolean.True;
            colName.FieldNameSort = "MeanRadiusByEarth";
            colName.SortOrder = SortOrder.Ascending;
        }
        [CodeExampleCase("Custom sorting"), CodeExampleVersionID(171), SpaceObjectCS]
        [CodeExampleUnderlineTokens("CustomColumnSort", "SortMode")]
        public static void CustomColumnSort(TreeList treeList) {
            // Setup custom column sorting
            TreeListColumn column = treeList.Columns["MeanRadiusInKM"];
            column.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            column.SortOrder = SortOrder.Ascending;
            // Handle the CustomColumnSort event
            treeList.CustomColumnSort += (sender, e) =>
            {
                if(e.Column.FieldName == "MeanRadiusInKM") {
                    var spaceObject1 = (SpaceObject)e.RowObject1;
                    var spaceObject2 = (SpaceObject)e.RowObject2;
                    // default comparison
                    e.Result = (e.SortOrder == SortOrder.Ascending) ?
                        spaceObject1.MeanRadiusInKM.CompareTo(spaceObject2.MeanRadiusInKM) :
                        spaceObject2.MeanRadiusInKM.CompareTo(spaceObject1.MeanRadiusInKM);
                    
                    //Always show Asteroids at the bottom
                    const string Asteroid = "Asteroid";
                    if(spaceObject1.TypeOfObject == Asteroid && spaceObject2.TypeOfObject != Asteroid)
                        e.Result = (e.SortOrder == SortOrder.Ascending) ? 1 : -1;
                    if(spaceObject2.TypeOfObject == Asteroid && spaceObject1.TypeOfObject != Asteroid)
                        e.Result = (e.SortOrder == SortOrder.Ascending) ? -1 : 1;
                }
            };
        }
    }
}
