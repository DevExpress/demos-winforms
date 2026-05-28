using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for CellMerging.
    /// </summary>
    public partial class CellMerging : TutorialControl {
        public CellMerging() {
            // This call is required by the Windows.Forms Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            gridView1.OptionsView.MergedCellEditMode = MergedCellEditMode.FocusedCell;
            // TODO: Add any initialization after the InitForm call
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "CellMerging" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "CellMerging"; }
        }
        private void CellMerging_Load(object sender, System.EventArgs e) {
            InitIssueListData(dsIssueList1, gridControl1);
            InitEditing();
            UpdateEditors();
        }
        void InitEditing() {
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeDefault, MergedCellEditMode.Default, -1);
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeDisabled, MergedCellEditMode.Disabled, -1);
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeFocusedCell, MergedCellEditMode.FocusedCell, -1);
            icbEditMode.Properties.Items.Add(Properties.Resources.MergedCellEditModeVisibleCells, MergedCellEditMode.VisibleCells, -1);
            ceMerging.Checked = gridView1.OptionsView.AllowCellMerge;
            icbEditMode.EditValue = gridView1.OptionsView.MergedCellEditMode;
        }
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView {
            get {
                return gridView1;
            }
        }
        //<ceMerging>
        private void ceMerging_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            gridView1.OptionsView.AllowCellMerge = edit.Checked;
            UpdateEditors();
        }
        void UpdateEditors() {
            icbEditMode.Enabled = ceMerging.Checked;
        }
        //</ceMerging>
        //<simpleButton1>
        private void simpleButton1_Click(object sender, EventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }
        //</simpleButton1>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
        //<icbEditMode>
        private void icbEditMode_SelectedIndexChanged(object sender, EventArgs e) {
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit;
            gridView1.OptionsView.MergedCellEditMode = (MergedCellEditMode)edit.EditValue;
        }
        //</icbEditMode>
        private void gridView1_CustomColumnDisplayText(object sender, Views.Base.CustomColumnDisplayTextEventArgs e) {
            if(e.Column == colModifiedDate || e.Column == colFixedDate)
                if(DateTime.MinValue.Equals(e.Value))
                    e.DisplayText = string.Empty;
        }
    }
}
