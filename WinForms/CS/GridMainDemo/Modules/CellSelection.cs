using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.DXperience.Demos;
using DevExpress.Utils.Behaviors.Common;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for CellSelection.
    /// </summary>
    public partial class CellSelection : TutorialControl {
        public CellSelection() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            InitNWindData();
            InitEditors();
            InitSelection();
            InitBehaviors();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "CellSelection" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "CellSelection"; }
        }
        bool updateValues = false;
        #region Init
        private GridView CurrentGridView { get { return gridView1; } }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet dataSet = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            dataSet.ReadXml(dataFileName);
            gridControl1.DataSource = dataSet.Tables["Customers"];
            return dataSet;
        }
        void InitEditors() {
            foreach(GridMultiSelectMode mode in Enum.GetValues(typeof(GridMultiSelectMode)))
                icbSelectMode.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<GridMultiSelectMode>.GetTitle(mode), mode, -1));
            updateValues = true;
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode;
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect;
            updateValues = false;
        }
        void InitSelection() {
            gridControl1.ForceInitialize();
            gridView1.SelectCellAnchorRange(3, colCompanyName, 12, colPostalCode);
        }
        void InitBehaviors() {
            UpdateMultiCellEditBehavior();
        }
        #endregion
        //<ceMultiSelect>
        private void ceMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            gridView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked;
            SetButtonEnabled();
        }
        //</ceMultiSelect>
        private void ceMultiCellEdit_CheckedChanged(object sender, EventArgs e) {
            if(updateValues) return;
            UpdateMultiCellEditBehavior();
        }
        void UpdateMultiCellEditBehavior() {
            if(ceMultiCellEdit.Checked)
                behaviorManager.Attach<MultiCellEditBehavior>(gridView1);
            else
                behaviorManager.Detach<MultiCellEditBehavior>(gridView1);
        }
        //<icbSelectMode>
        private void icbSelectMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            if(updateValues) return;
            gridView1.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)icbSelectMode.EditValue;
            sbRecords.Text = gridView1.OptionsSelection.MultiSelectMode == 
                GridMultiSelectMode.CellSelect ? Properties.Resources.ShowSelectedValues : Properties.Resources.ShowSelectedRecords;
        }
        //</icbSelectMode>
        void SetButtonEnabled() {
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 && ceMultiSelect.Checked;
            icbSelectMode.Enabled = ceMultiSelect.Checked;
        }
        //<icbTranslucentColors>
        private void icbTranslucentColors_CheckedChanged(object sender, System.EventArgs e) {
            if(icbTranslucentColors.Checked) {
                gridView1.Appearance.SelectedRow.BackColor = Color.FromArgb(30, 0, 0, 240);
                gridView1.Appearance.FocusedRow.BackColor = Color.FromArgb(60, 0, 0, 240);
            }
            else {
                gridView1.Appearance.SelectedRow.Reset();
                gridView1.Appearance.FocusedRow.Reset();
            }
        }
        //</icbTranslucentColors>
        //<sbRecords>
        private void sbRecords_Click(object sender, System.EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView1), 
                gridView1.OptionsSelection.MultiSelectMode == 
                GridMultiSelectMode.CellSelect ? Properties.Resources.SelectedCells : Properties.Resources.SelectedRows);
        }
        //</sbRecords>
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            SetButtonEnabled();
        }
        //<sbRecords>
        string GetSelectedRows(GridView view) {
            string ret = "";
            int rowIndex = -1;
            if(view.OptionsSelection.MultiSelectMode != GridMultiSelectMode.CellSelect) {
                foreach(int i in gridView1.GetSelectedRows()) {
                    DataRow row = gridView1.GetDataRow(i);
                    if(ret != "") ret += "\r\n";
                    ret += string.Format("{2}: {0} (#{1})", row["CompanyName"], i, Properties.Resources.CompanyName);
                }
            }
            else {
                foreach(GridCell cell in view.GetSelectedCells()) {
                    if(rowIndex != cell.RowHandle) {
                        if(ret != "") ret += "\r\n";
                        ret += string.Format("{1}: #{0}", cell.RowHandle, Properties.Resources.Row);
                    }
                    ret += "\r\n    " + view.GetRowCellDisplayText(cell.RowHandle, cell.Column);
                    rowIndex = cell.RowHandle;
                }
            }
            return ret;
        }
        //</sbRecords>
    }
}
