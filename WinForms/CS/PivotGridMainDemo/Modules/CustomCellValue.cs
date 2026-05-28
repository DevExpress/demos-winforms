using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class CustomCellValue : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public CustomCellValue() {
            CreateWaitDialog();
            InitializeComponent();
        }

        private void CustomCellValue_Load(object sender, EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("CustomerReports");


        }
        //<pivotGridControl1>
        private void pivotGridControl1_CustomCellValue(object sender, PivotCellValueEventArgs e) {
            if(e.RowValueType == PivotGridValueType.Total) {
                e.Value = null;
                for(int index = e.RowIndex - 1; index >= 0 && e.Value == null; index--) {
                    if(!Comparer.Equals(pivotGridControl1.GetFieldValueType(false, index), PivotGridValueType.Value)) break;
                    e.Value = e.GetCellValue(e.ColumnIndex, index);
                }
            }
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, PivotFieldDisplayTextEventArgs e) {
            if(e.Field == fieldOrderYear && e.ValueType == PivotGridValueType.Total) {
                e.DisplayText = "Last Quarter Amount";
            }
        }
        //</pivotGridControl1>
    }
}
