using System;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Columns", "Columns.cs")]
    public static class Columns {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new DevExpress.XtraGrid.GridControl();
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
        #region Columns
        [CodeExampleCase("Add columns manually"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AddVisible", "AutoPopulateColumns")]
        public static void AddColumnsManually(GridControl gridControl, GridView gridView) {
            // The AutoPopulateColumns property is used to determine
            // whether columns should be created automatically for all fields in the underlying data source 
            // when the View doesn't contain any columns
            gridView.OptionsBehavior.AutoPopulateColumns = false;            
            // The AddVisible method adds a new column, binds it to the specified field and makes this column visible
            gridView.Columns.AddVisible("ID");
            gridView.Columns.AddVisible("Name");
        }
        #endregion
    }
}
