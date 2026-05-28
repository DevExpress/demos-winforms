using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Sort data", "Sorting.cs")]
    public static class Sorting {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            VGridControl vGridControl = new VGridControl();
            vGridControl.Dock = DockStyle.Fill;
            vGridControl.Parent = sampleHost;
            vGridControl.RowHeaderWidth = ScaleUtils.ScaleValue(120);
            vGridControl.RecordWidth = ScaleUtils.ScaleValue(140);
            vGridControl.DataSource = SampleData.GetData(10);
            return new object[] { vGridControl };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as VGridControl).Dispose();
        }

        #region Sorting
        [CodeExampleCase("Sort against columns"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("SortOrder")]
        public static void SortAgainstColumns(VGridControl vGridControl) {
            // The SortOrder property value is used to determine 
            // which sort order is currently applied to the column
            vGridControl.Rows["Length"].Properties.SortOrder = ColumnSortOrder.Ascending;
            vGridControl.Rows["Mark"].Properties.SortOrder = ColumnSortOrder.Descending;
        }
        #endregion
    }
}
