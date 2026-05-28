namespace Examples {
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;

    [CodeExampleClass("Summaries", "Summaries.cs")]
    public static class Summaries {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.Load += (s, e) =>
            {
                treeList.ExpandAll();
                treeList.Columns["Name"].BestFit();
            };
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Create total summaries")]
        [CodeExampleUnderlineTokens("ShowSummaryFooter", "SummaryFooter", "SummaryFooterStrFormat")]
        public static void CreateTotalSummaries(TreeList treeList) {
            // Enable summary footer UI element for the entire TreeList
            treeList.OptionsView.ShowSummaryFooter = true;
            // Setup total summaries for the specific columns
            TreeListColumn colName = treeList.Columns["Name"];
            colName.AllNodesSummary = true;
            colName.SummaryFooter = SummaryItemType.Count;
            colName.SummaryFooterStrFormat = "Total Count = {0}";
            
            TreeListColumn colMeanRadiusInKM = treeList.Columns["MeanRadiusInKM"];
            colMeanRadiusInKM.AllNodesSummary = true;
            colMeanRadiusInKM.SummaryFooter = SummaryItemType.Max;
            
            TreeListColumn colMeanRadiusByEarth = treeList.Columns["MeanRadiusByEarth"];
            colMeanRadiusByEarth.AllNodesSummary = true;
            colMeanRadiusByEarth.SummaryFooter = SummaryItemType.Min;
        }
        [CodeExampleCase("Create row summaries")]
        [CodeExampleUnderlineTokens("ShowRowFooterSummary", "RowFooterSummary", "RowFooterSummaryStrFormat", "SummaryItemType")]
        public static void CreateRowSummaries(TreeList treeList) {
            // Enable summary footer UI element for rows
            treeList.OptionsView.ShowRowFooterSummary = true;
            // Setup row-summaries for the specific columns
            TreeListColumn colName = treeList.Columns["Name"];
            colName.AllNodesSummary = true;
            colName.RowFooterSummary = SummaryItemType.Count;
            colName.RowFooterSummaryStrFormat = "Row Count = {0}";
            
            TreeListColumn colMeanRadiusInKM = treeList.Columns["MeanRadiusInKM"];
            colMeanRadiusInKM.AllNodesSummary = true;
            colMeanRadiusInKM.RowFooterSummary = SummaryItemType.Max;
            colMeanRadiusInKM.RowFooterSummaryStrFormat = "Row Max: {0}";
            
            TreeListColumn colMeanRadiusByEarth = treeList.Columns["MeanRadiusByEarth"];
            colMeanRadiusByEarth.AllNodesSummary = true;
            colMeanRadiusByEarth.RowFooterSummary = SummaryItemType.Min;
        }
    }
}
