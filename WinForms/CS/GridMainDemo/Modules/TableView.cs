using System;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Base;
//<icbNewItemRow>
using DevExpress.XtraGrid.Views.Grid;
//</icbNewItemRow>
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for TableView.
    /// </summary>
    public partial class TableView : TutorialControl {
        public TableView() {
            CreateWaitDialog();
            InitializeComponent();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "TableView" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "TableView"; }
        }
        bool updateLayout = false;
        bool firstSearch = true;
        //<sbStart>
        string[] searshString = new string[] { "c", "a", "{BS}", "h", "a", "n", "{BS}", "{BS}", "e", "f", " ", "a", "n", "t", "o", "n", "'", "s", " ", "c", 
            "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{DOWN}", "^{HOME}", "{RIGHT}" };
        int searchKeyIndex = 0;
        //</sbStart>
        #region Init
        public override BaseView ExportView { 
            get { return gridView1; } 
        }
        void TableView_Load(object sender, System.EventArgs e) {
            InitNWindData();
            InitEditing();
            SetButtonEnabled();
            gridView1_Layout(gridView1, EventArgs.Empty);
        }
        public override bool ShowViewOptions {
            get { return true; }
        }
        string tblGrid = "Order Details";
        string tblLookUp = "Products";
        DataSet ds = new DataSet();
        protected override DataSet InitNWindXMLData(string dataFileName) {
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            ds.ReadXml(dataFileName);
            gridControl1.DataSource = ds.Tables[tblGrid];
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            return ds;
        }
        void InitEditing() {
            icbNewItemRow.Properties.Items.Add(Properties.Resources.None, NewItemRowPosition.None, -1);
            icbNewItemRow.Properties.Items.Add(Properties.Resources.Top, NewItemRowPosition.Top, -1);
            icbNewItemRow.Properties.Items.Add(Properties.Resources.Bottom, NewItemRowPosition.Bottom, -1);
            icbButtons.Properties.Items.Add(Properties.Resources.DefaultString, ShowButtonModeEnum.Default, -1);
            icbButtons.Properties.Items.Add(Properties.Resources.ShowAlways, ShowButtonModeEnum.ShowAlways, -1);
            icbButtons.Properties.Items.Add(Properties.Resources.ShowForFocusedCell, ShowButtonModeEnum.ShowForFocusedCell, -1);
            icbButtons.Properties.Items.Add(Properties.Resources.ShowForFocusedRow, ShowButtonModeEnum.ShowForFocusedRow, -1);
            icbButtons.Properties.Items.Add(Properties.Resources.ShowOnlyInEditor, ShowButtonModeEnum.ShowOnlyInEditor, -1);
            icbButtons.EditValue = gridView1.OptionsView.ShowButtonMode;
            icbSelectMode.Properties.Items.Add(Properties.Resources.RowSelect, GridMultiSelectMode.RowSelect, -1);
            icbSelectMode.Properties.Items.Add(Properties.Resources.CellSelect, GridMultiSelectMode.CellSelect, -1);
            icbSelectMode.Properties.Items.Add(Properties.Resources.CheckBoxRowSelect, GridMultiSelectMode.CheckBoxRowSelect, -1);
            icbSelectMode.EditValue = gridView1.OptionsSelection.MultiSelectMode;
            chEdit.Checked = gridView1.OptionsBehavior.Editable;
            ceHotTrackRow.Checked = gridView1.OptionsSelection.EnableAppearanceHotTrackedRow == DefaultBoolean.True;
            icbInHeaderFilterMode.Properties.Items.Add(Properties.Resources.FilterModeDisabled, GridInHeaderSearchMode.Disabled, -1);
            icbInHeaderFilterMode.Properties.Items.Add(Properties.Resources.FilterModeTextFilter, GridInHeaderSearchMode.TextFilter, -1);
            icbInHeaderFilterMode.Properties.Items.Add(Properties.Resources.FilterModeTextSearch, GridInHeaderSearchMode.TextSearch, -1);
            icbInHeaderFilterMode.EditValue = gridView1.OptionsFilter.InHeaderSearchMode;
            icbShowSearchResults.Properties.Items.Add(Properties.Resources.ShowResultsModeNone, ShowInHeaderSearchResultsMode.None, -1);
            icbShowSearchResults.Properties.Items.Add(Properties.Resources.ShowResultsModeText, ShowInHeaderSearchResultsMode.Text, -1);
            icbShowSearchResults.Properties.Items.Add(Properties.Resources.ShowResultsModeTextAndPosition, ShowInHeaderSearchResultsMode.TextAndPosition, -1);
            icbShowSearchResults.EditValue = gridView1.OptionsFilter.ShowInHeaderSearchResults;
            gridControl1.UseEmbeddedNavigator = true;
            UpdateShowSearchResultsVisible();
        }
        #endregion
        #region Editing
        void gridView1_Layout(object sender, System.EventArgs e) {
            updateLayout = true;
            icbNewItemRow.EditValue = gridView1.OptionsView.NewItemRowPosition;
            ceMultiSelect.Checked = gridView1.OptionsSelection.MultiSelect;
            SetPosition();
            updateLayout = false;
        }
        void navigationPane1_SelectedPageChanged(object sender, XtraBars.Navigation.SelectedPageChangedEventArgs e) {
            if(e.Page == navigationPage2) {
                gridView1.OptionsBehavior.AllowIncrementalSearch = true;
                if(firstSearch) StartSearch();
                firstSearch = false;
            }
            else {
                gridView1.OptionsBehavior.AllowIncrementalSearch = false;
                if(!firstSearch) StopSearch();
            }
        }
        #endregion
        #region NewItemRow
        //<icbNewItemRow>
        void icbNewItemRow_SelectedIndexChanged(object sender, System.EventArgs e) {
            //<skip>
            if(updateLayout) return;
            //</skip>
            gridView1.OptionsView.NewItemRowPosition = (NewItemRowPosition)icbNewItemRow.EditValue;
            SetPosition();
            //<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1);
            //</skip>
        }
        void SetPosition() {
            if(gridView1.OptionsView.NewItemRowPosition == NewItemRowPosition.Bottom && gridView1.SortInfo.GroupCount == 0) {
                gridView1.FocusedRowHandle = gridView1.RowCount - 2;
                gridView1.MakeRowVisible(gridView1.FocusedRowHandle, false);
            }
        }
        //</icbNewItemRow>
        void gridView1_InitNewRow(object sender, DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs e) {
            DataRow row = gridView1.GetDataRow(e.RowHandle);
            int orderId = 99999;
            row["Quantity"] = 1;
            row["UnitPrice"] = 0;
            row["Discount"] = 0;
            row["OrderID"] = orderId;
            AddOrderParentRow(orderId);
        }
        void AddOrderParentRow(int id) {
            foreach(DataRow row in ds.Tables["Orders"].Rows)
                if(id.Equals(row["OrderID"])) return;
            ds.Tables["Orders"].Rows.Add(new object[] { id });
        }
        #endregion
        #region Incremental Search
        //<sbStart>
        void StartSearch() {
            sbStart.Enabled = false;
            searchKeyIndex = 0;
            lbEvent.Text = Properties.Resources.TableView_AutoSearch;
            gridView1.FocusedColumn = gridColumn2;
            timer1.Start();
        }
        void StopSearch() {
            sbStart.Enabled = true;
            timer1.Stop();
            lbEvent.Text = Properties.Resources.TableView_IncrementalSearch;
        }
        void timer1_Tick(object sender, System.EventArgs e) {
            if(Form.ActiveForm == null || !this.Visible) return;
            gridControl1.Focus();
            if(searchKeyIndex > searshString.Length - 1)
                searchKeyIndex = 0;
            else {
                SendKeys.Send(searshString[searchKeyIndex]);
                searchKeyIndex++;
            }
        }
        void gridControl1_ProcessGridKey(object sender, System.Windows.Forms.KeyEventArgs e) {
            if(e.KeyCode == Keys.Escape) StopSearch();
        }
        void gridControl1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            StopSearch();
        }
        void sbStart_Click(object sender, System.EventArgs e) {
            StartSearch();
        }
        //</sbStart>
        #endregion
        #region Editing And Navigation
        //<icbButtons>
        void icbButtons_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.OptionsView.ShowButtonMode = (ShowButtonModeEnum)icbButtons.EditValue;
        }
        //</icbButtons>
        //<chEdit>
        void chEdit_CheckedChanged(object sender, System.EventArgs e) {
            gridView1.OptionsBehavior.Editable = chEdit.Checked;
        }
        //</chEdit>
        bool EditRecord() {
            DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(row == null) 
                return false;
            StopSearch();
            using(PopupForm frm = new PopupForm()) {
                frm.InitData(this.FindForm(), gridControl1, gridView1, row);
                bool ret = frm.ShowDialog() == DialogResult.OK;
                if(ret) {
                    row.ItemArray = frm.Row.ItemArray;
                    row.EndEdit();
                }
                return ret;
            }
        }
        void gridControl1_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e) {
            if(e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Edit) {
                EditRecord();
                e.Handled = true;
            }
            if(e.Button.ButtonType == DevExpress.XtraEditors.NavigatorButtonType.Append) {
                gridView1.AddNewRow();
                if(EditRecord())
                    gridView1.UpdateCurrentRow();
                else gridView1.CancelUpdateCurrentRow();
                e.Handled = true;
            }
        }
        #endregion
        #region MultiSelect
        void UpdateSelection() {
            bool updateCells = gridView1.OptionsSelection.MultiSelectMode == GridMultiSelectMode.CellSelect;
            if(ceMultiSelect.Checked) {
                if(!updateCells) {
                    gridView1.SelectRange(4, 20);
                    sbRecords.Text = Properties.Resources.ShowSelectedRecords;
                }
                else {
                    gridView1.ClearSelection();
                    gridView1.SelectCells(5, gridView1.Columns["ProductID"], 15, gridView1.Columns["Quantity"]);
                    sbRecords.Text = Properties.Resources.ShowSelectedValues;
                }
            }
        }
        //<ceMultiSelect>
        void ceMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            //<skip>
            SetButtonEnabled();
            if(updateLayout) return;
            //</skip>
            gridView1.OptionsSelection.MultiSelect = ce.Checked;
            UpdateSelection();
            //<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(gridView1);
            //</skip>
        }
        //</ceMultiSelect>
        void SetButtonEnabled() {
            sbRecords.Enabled = gridView1.SelectedRowsCount > 0 && ceMultiSelect.Checked;
            icbSelectMode.Enabled = ceMultiSelect.Checked;
        }
        void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            SetButtonEnabled();
        }
        //<sbRecords>
        void sbRecords_Click(object sender, System.EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(gridView1), gridView1.OptionsSelection.MultiSelectMode == 
                GridMultiSelectMode.CellSelect ? Properties.Resources.SelectedCells : Properties.Resources.SelectedRows);
        }
        string GetSelectedRows(GridView view) {
            string ret = "";
            int rowIndex = -1;
            if(view.OptionsSelection.MultiSelectMode != GridMultiSelectMode.CellSelect) {
                foreach(int i in gridView1.GetSelectedRows()) {
                    DataRow row = gridView1.GetDataRow(i);
                    if(ret != "") ret += "\r\n";
                    ret += string.Format("{2}: #{0} {1}", row["OrderID"], gridView1.GetRowCellDisplayText(i, gridColumn2), Properties.Resources.Order);
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
        //<icbSelectMode>
        void icbSelectMode_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.OptionsSelection.MultiSelectMode = (GridMultiSelectMode)icbSelectMode.EditValue;
            UpdateSelection();
        }
        //</icbSelectMode>
        #endregion
        //<ceHotTrackRow>
        void ceHotTrackRow_CheckedChanged(object sender, EventArgs e) {
            CheckEdit ce = sender as CheckEdit;
            gridView1.OptionsSelection.EnableAppearanceHotTrackedRow = ce.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</ceHotTrackRow>
        private void icbInHeaderFilterMode_SelectedIndexChanged(object sender, EventArgs e) {
            ImageComboBoxEdit icb = sender as ImageComboBoxEdit;
            gridView1.ClearInHeaderSearchText();
            gridView1.OptionsFilter.InHeaderSearchMode = (GridInHeaderSearchMode)icb.EditValue;
            UpdateShowSearchResultsVisible();
        }

        void UpdateShowSearchResultsVisible() {
            lciShowSearchResults.Visibility = gridView1.OptionsFilter.InHeaderSearchMode == GridInHeaderSearchMode.TextSearch ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
        }
        private void icbShowSearchResults_SelectedIndexChanged(object sender, EventArgs e) {
            ImageComboBoxEdit icb = sender as ImageComboBoxEdit;
            gridView1.OptionsFilter.ShowInHeaderSearchResults = (ShowInHeaderSearchResultsMode)icb.EditValue;
        }
    }
}
