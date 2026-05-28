using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using System.ComponentModel;
using DevExpress.Utils;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Display format", "DisplayFormat.cs")]
    public static class DisplayFormat {
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
        
        #region Display format
        [CodeExampleCase("Specify column cell display format"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("DisplayFormat", "FormatType", "FormatString")]
        public static void ColumnDisplayFormat(GridControl gridControl, GridView gridView) {
            gridView.Columns["RecordDate"].DisplayFormat.FormatType = FormatType.DateTime;
            gridView.Columns["RecordDate"].DisplayFormat.FormatString = "D";
        }
        [CodeExampleCase("Customize cell display text"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomColumnDisplayText", "DisplayText")]
        public static void CustomCellDisplayText(GridControl gridControl, GridView gridView) {
            // Custom Cell Display Text            
            gridView.CustomColumnDisplayText += (sender, e) => {
                if(e.Column.FieldName == "Length") {
                    double val = (double)e.Value;
                    if (val > 20)
                        e.DisplayText = string.Empty;
                }
            };
        }
        [CodeExampleCase("Customize Filter Panel’s text"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("CustomFilterDisplayText", "Value")]
        public static void CustomFilterDisplayText(GridControl gridControl, GridView gridView) {
            gridView.ActiveFilterString = string.Format("[{0}] = 2 Or [{0}] >= 4", "ID");

            // Handle the event to customize the display text representing the current filter within the filter panel.
            gridView.CustomFilterDisplayText += (sender, e) => {
                GroupOperator go = e.Value as GroupOperator;
                string displayText = string.Empty;
                if(CriteriaOperator.Equals(go, null)) {
                    BinaryOperator bo = e.Value as BinaryOperator;
                    if (!CriteriaOperator.Equals(bo, null)) {
                        OperandProperty op = bo.LeftOperand as OperandProperty;
                        OperandValue ov = bo.RightOperand as OperandValue;
                        displayText = string.Format("{0} {1} {2}", op.PropertyName, bo.OperatorType, ov.Value);
                    }
                }
                else {
                    foreach (BinaryOperator bo in go.Operands) {
                        OperandProperty op = bo.LeftOperand as OperandProperty;
                        OperandValue ov = bo.RightOperand as OperandValue;
                        displayText += string.Format("{0} {1} {2} ; ", op.PropertyName, bo.OperatorType, ov.Value);
                    }
                }
                if(displayText != string.Empty) {
                    //To specify the filter display text, assign the required string
                    //  (or any object whose ToString() method returns the required string)
                    //   to the Value parameter and set the Handled parameter to true.
                    e.Handled = true;
                    e.Value = displayText;
                }
            };
        }
        #endregion
    }
}
