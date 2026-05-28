using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Unbound Columns", "UnboundColumns.cs")]
    public static class UnboundColumns {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new DevExpress.XtraGrid.GridControl();
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
        #region Unbound Columns
        [CodeExampleCase("Unbound editable column"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AddField", "CustomUnboundColumnData", "UnboundDataType")]
        public static void CreatingUnboundColumnWithEditing(GridControl gridControl, GridView gridView) {
            // Creating an unbound column that supports editing
            GridColumn unboundColumn = gridView.Columns.AddField("CustomData");
            unboundColumn.UnboundDataType = typeof(string);
            unboundColumn.Visible = true;
            // Handling the CustomUnboundColumnData event
            Dictionary<int, string> unboundData = new Dictionary<int, string>();
            unboundData[5] = "Can live up to 20 years!";
            gridView.CustomUnboundColumnData += (sender, e) => {
                if(e.Column.FieldName == "CustomData") {
                    if(e.IsGetData) {
                        string value = null;
                        if(unboundData.TryGetValue(e.ListSourceRowIndex, out value))
                            e.Value = value;
                    }
                    if(e.IsSetData && e.Value != null)
                        unboundData[e.ListSourceRowIndex] = e.Value.ToString();
                }
            };
        }
        [CodeExampleCase("Provide data using an expression"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AddField", "UnboundExpression")]
        public static void CreatingUnboundColumnByUsingUnboundExpression(GridControl gridControl, GridView gridView) {
            // Creating an readonly unbound column by using an unbound expression
            GridColumn unboundColumn = gridView.Columns.AddField("Unbound");
            unboundColumn.OptionsColumn.AllowEdit = false;
            unboundColumn.UnboundDataType = typeof(int);
            unboundColumn.UnboundExpression = "Round([Length])";
            unboundColumn.Visible = true;
        }
        #endregion
    }
}
