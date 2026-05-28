using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.PivotGrid;
using DevExpress.Utils.Menu;
using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    public partial class RunTimeChangeSummaryType : DevExpress.XtraPivotGrid.Demos.TutorialControl {
        public RunTimeChangeSummaryType() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();

            pivotGridControl1.DataSource = GetNWindData("SalesPerson");
            UpdateDataFields();
            UpdateHintLabelVisibility();
        }
        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }


        void UpdateHintLabelVisibility() {
            layoutControlItem3.Visibility = checkEdit2.Checked ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        //<checkEdit1>
        //<checkEdit2>
        void checkEdit_CheckedChanged(object sender, EventArgs e) {
            UpdateDataFields();
            UpdateHintLabelVisibility();
        }

        void UpdateDataFields() {
            pivotGridControl1.BeginUpdate();
            PivotGridFieldCollection fields = pivotGridControl1.Fields;
            List<PivotGridField> dataFields = pivotGridControl1.GetFieldsByArea(PivotArea.DataArea);
            foreach(var field in dataFields)
                fields.Remove(field);

            if(checkEdit1.Checked) {
                PivotSummaryType[] summaryTypes = new PivotSummaryType[] {
                    PivotSummaryType.Sum, PivotSummaryType.Average, PivotSummaryType.Count, PivotSummaryType.Max
                };
                foreach(var summaryType in summaryTypes) {
                    fields.Add(CreateDataField((PivotSummaryType)summaryType));
                }
                pivotGridControl1.Fields["ProductName"].Width = 350;
            } else {
                PivotGridField dataField = CreateDataField(PivotSummaryType.Sum);
                fields.Add(dataField);
                dataField.Appearance.Header.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
                dataField.Appearance.Header.Options.UseBackColor = true;
                pivotGridControl1.Fields["ProductName"].Width = 200;
            }
            pivotGridControl1.EndUpdate();
        }
        PivotGridField CreateDataField(PivotSummaryType summaryType) {
            PivotGridField field = new PivotGridField();
            field.Options.ShowSummaryTypeName = true;
            field.Options.AllowRunTimeSummaryChange = checkEdit2.Checked;
            field.DataBinding = new ExpressionDataBinding("[Discount]*[Extended Price]");
            field.Area = PivotArea.DataArea;
            field.Caption = "Discount";
            field.SummaryType = summaryType;
            field.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            field.CellFormat.FormatString = "c2";
            return field;
        }
        //</checkEdit2>
        //</checkEdit1>        

    }
}
