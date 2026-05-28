using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Rows;
using SampleDataSourceFile = DevExpress.XtraVerticalGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraVerticalGrid.Demos.CodeExamples {
    [CodeExampleClass("Unbound Columns", "UnboundColumns.cs")]
    public static class UnboundColumns {
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

        #region Unbound Columns
        [CodeExampleCase("Unbound editable column"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AddField", "CustomUnboundColumnData", "UnboundDataType")]
        public static void CreatingUnboundColumnWithEditing(VGridControl vGridControl) {
            // Creating an unbound column that supports editing
            vGridControl.Rows.Add(new EditorRow("CustomData"));
            var unboundRowProps = vGridControl.Rows["CustomData"].Properties;
            unboundRowProps.Caption = "CustomData";
            unboundRowProps.UnboundDataType = typeof(string);
            // Handling the CustomUnboundColumnData event
            Dictionary<int, string> unboundData = new Dictionary<int, string>();
            unboundData[1] = "Can live up to 20 years!";
            vGridControl.CustomUnboundData += (sender, e) => {
                if(e.RowProperties.FieldName == "CustomData") {
                    if(e.IsGetData) {
                        string data = null;
                        if(unboundData.TryGetValue(e.ListSourceRowIndex, out data))
                            e.Value = data;
                    }
                    if(e.IsSetData && e.Value != null)
                        unboundData[e.ListSourceRowIndex] = e.Value.ToString();
                }
            };
        }
        [CodeExampleCase("Provide data using an expression"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("AddField", "UnboundExpression")]
        public static void CreatingUnboundColumnByUsingUnboundExpression(VGridControl vGridControl) {
            // Creating an readonly unbound column by using an unbound expression
            vGridControl.Rows.Add(new EditorRow("Unbound"));
            var unboundRowProps = vGridControl.Rows["Unbound"].Properties;
            unboundRowProps.AllowEdit = false;
            unboundRowProps.UnboundDataType = typeof(int);
            unboundRowProps.UnboundExpression = "Round([Length])";
        }
        #endregion
    }
}
