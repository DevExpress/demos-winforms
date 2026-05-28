using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Repository;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraEditors;
using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
    public partial class InplaceEditors : TutorialControl {
        [FlagsAttribute]
        enum Colors { None = 0, Red = 1, Green = 2, Blue = 4, Yellow = 8, Black = 16 };
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }

        //<gridControl1>
        private GridEditorCollection gridEditors;
        //</gridControl1>

        public InplaceEditors() {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            gridView1.OptionsMenu.ShowAutoFilterRowItem = false;
            InitLookUpDataTable();
            repositoryItemCheckedComboBoxEdit1.SetFlags(typeof(Colors));
            //<gridControl1>
            this.gridEditors = new GridEditorCollection();
            InitInplaceEditors();
            this.gridControl1.DataSource = gridEditors;
            //</gridControl1>
            gridPopup.ForceInitialize();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "InplaceEditors" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "InplaceEditors"; }
        }


        void AddRecordToLookUpDataTable(string fName, string department) {
            DataRow row = this.dataTableLookUp.NewRow();
            row["clnId"] = this.dataTableLookUp.Rows.Count + 1;
            row["clnName"] = fName;
            row["clnDepartment"] = department;
            this.dataTableLookUp.Rows.Add(row);
        }
        void InitLookUpDataTable() {
            AddRecordToLookUpDataTable("Paul Bailey", Properties.Resources.Management);
            AddRecordToLookUpDataTable("Brad Barnes", Properties.Resources.QA);
            AddRecordToLookUpDataTable("Jerry Campbell", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Carl Lucas", Properties.Resources.Documentation);
            AddRecordToLookUpDataTable("Peter Dolan", Properties.Resources.Marketing);
            AddRecordToLookUpDataTable("Ryan Fischer", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Ricard Fischer", Properties.Resources.Marketing);
            AddRecordToLookUpDataTable("Tom Hamlett", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Mark Hamilton", Properties.Resources.QA);
            AddRecordToLookUpDataTable("Steve Lee", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Jimmy Lewis", Properties.Resources.Support);
            AddRecordToLookUpDataTable("Jeffrey McClain", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Andrew Miller", Properties.Resources.Documentation);
            AddRecordToLookUpDataTable("Dave Murrel", Properties.Resources.QA);
            AddRecordToLookUpDataTable("Bert Parkins", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Mike Roller", Properties.Resources.RD);
            AddRecordToLookUpDataTable("Ray Shipman", Properties.Resources.Support);
        }

        //<gridControl1>
        void InitInplaceEditors() {
            this.gridEditors.Add(this.repositoryItemTextEdit, Properties.Resources.TextEdit, Properties.Resources.TextEditText);
            this.gridEditors.Add(this.repositoryItemButtonEdit, Properties.Resources.ButtonEdit, Properties.Resources.ClickMe);
            this.gridEditors.Add(this.repositoryItemCheckEdit, Properties.Resources.CheckEdit, false);
            this.gridEditors.Add(this.repositoryItemSpinEdit, Properties.Resources.SpinEdit, 20);
            this.gridEditors.Add(this.repositoryItemDateEdit, Properties.Resources.DateEdit, TutorialConstants.Now);
            this.gridEditors.Add(this.repositoryItemTimeEdit, Properties.Resources.TimeEdit, TutorialConstants.Now);
            this.gridEditors.Add(this.repositoryItemLookUpEdit, Properties.Resources.LookUpEdit, 3);
            this.gridEditors.Add(this.repositoryItemPopupContainerEdit, Properties.Resources.PopupContainer, 3);
            this.gridEditors.Add(this.repositoryItemProgressBar, Properties.Resources.ProgressBar, 30);
            this.gridEditors.Add(this.repositoryItemComboBox, Properties.Resources.ComboBox, "United States");
            this.gridEditors.Add(this.repositoryItemImageComboBox, Properties.Resources.ImageComboBox, 2);
            this.gridEditors.Add(this.repositoryItemMRUEdit, Properties.Resources.MRUEdit, Properties.Resources.MRUQuestion);
            this.gridEditors.Add(this.repositoryItemPictureEdit, Properties.Resources.Picture, this.pictureBox1.Image);
            this.gridEditors.Add(this.repositoryItemMemoEdit, Properties.Resources.MemoEdit, Properties.Resources.MemoText);
            this.gridEditors.Add(this.repositoryItemImageEdit, Properties.Resources.ImageEdit, this.pictureBox1.Image);
            this.gridEditors.Add(this.repositoryItemMemoExEdit, Properties.Resources.MemoExEdit, Properties.Resources.MemoText);
            this.gridEditors.Add(this.repositoryItemRadioGroup, Properties.Resources.RadioGroup, 1);
            this.gridEditors.Add(this.repositoryItemHyperLinkEdit, Properties.Resources.Hyperlink, "http://www.devexpress.com");
            this.gridEditors.Add(this.repositoryItemCalcEdit, Properties.Resources.Calculator, 100.25);
            this.gridEditors.Add(this.repositoryItemColorEdit, Properties.Resources.ColorEdit, System.Drawing.Color.Blue);
            this.gridEditors.Add(this.repositoryItemTrackBar1, Properties.Resources.TrackBar, 4);
            this.gridEditors.Add(this.repositoryItemFontEdit1, Properties.Resources.FontEdit, this.Font.FontFamily.GetName(0));
            this.gridEditors.Add(this.repositoryItemCheckedComboBoxEdit1, Properties.Resources.CheckedComboBox, Colors.Red | Colors.Blue | Colors.Yellow);
        }
        //</gridControl1>

        //<gridControl1>
        private void gridView1_CustomRowCellEdit(object sender, DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventArgs e) {
            if (e.Column == this.gridEditorValue) {
                GridEditorItem item = gridView1.GetRow(e.RowHandle) as GridEditorItem;
                if (item != null) e.RepositoryItem = item.RepositoryItem;
            }
        }
        //</gridControl1>

        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            XtraMessageBox.Show(Properties.Resources.ButtonMessage, Application.ProductName);
        }

        private string PopupContainerUserByID(object id) {
            foreach (DataRow row in dataTableLookUp.Rows)
                if (row["clnId"].Equals(id))
                    return row["clnName"].ToString();
            return "";
        }

        private void PopupContainerFindRowByEditValue() {
            if (popupContainerControl.OwnerEdit == null) return;
            DataRowView row;
            for (int i = 0; i < dataTableLookUp.DefaultView.Count; i++) {
                row = dataTableLookUp.DefaultView[i];
                if (row.Row["clnId"].Equals(popupContainerControl.OwnerEdit.EditValue))
                    for (int k = 0; k < gridView1Popup.DataRowCount; k++) {
                        if (gridView1Popup.GetRow(k) == row) {
                            gridView1Popup.FocusedRowHandle = k;
                            return;
                        }
                    }
            }
        }
        private void PopupContainerClosePopup() {
            if (popupContainerControl.OwnerEdit != null)
                popupContainerControl.OwnerEdit.ClosePopup();
        }

        private void repositoryItemPopupContainerEdit_QueryDisplayText(object sender, DevExpress.XtraEditors.Controls.QueryDisplayTextEventArgs e) {
            e.DisplayText = PopupContainerUserByID(e.EditValue);
        }

        private void repositoryItemPopupContainerEdit_QueryResultValue(object sender, DevExpress.XtraEditors.Controls.QueryResultValueEventArgs e) {
            if (this.gridView1Popup.FocusedRowHandle >= 0)
                e.Value = this.gridView1Popup.GetDataRow(this.gridView1Popup.FocusedRowHandle)["clnId"];
        }
        private void repositoryItemPopupContainerEdit_QueryPopUp(object sender, System.ComponentModel.CancelEventArgs e) {
            PopupContainerFindRowByEditValue();
        }

        private void gridPopup_BindingContextChanged(object sender, System.EventArgs e) {
            PopupContainerFindRowByEditValue();
        }

        private void gridView1Popup_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) PopupContainerClosePopup();
        }

        private void gridView1Popup_DoubleClick(object sender, System.EventArgs e) {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo info = gridView1Popup.CalcHitInfo(gridPopup.PointToClient(MousePosition));
            if (info.InRow)
                PopupContainerClosePopup();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) {
            GridEditorItem item = gridView1.GetRow(e.FocusedRowHandle) as GridEditorItem;
            if(item != null) {
                propertyGridPanel1.SelectedObject = item.RepositoryItem;
                tabNavigationPage1.Text = string.Format("{0} {1}", item.Name, Properties.Resources.Properties);
            }
        }

        private void repositoryItemMRUEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
            DevExpress.XtraEditors.MRUEdit edit = sender as DevExpress.XtraEditors.MRUEdit;
            if (edit.Properties.Buttons.IndexOf(e.Button) != edit.Properties.ActionButtonIndex) {
                ColorDialog dlg = new ColorDialog();
                if (dlg.ShowDialog() == DialogResult.OK) {
                    Color c = dlg.Color;
                    string colorName = (c.IsNamedColor) ? c.Name : c.ToString();
                    edit.EditValue = colorName;
                    edit.Properties.Items.Add(edit.Text);
                }
            }
        }
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }

    //<gridControl1>
    public class GridEditorItem {
        string fName;
        object fValue;
        RepositoryItem fRepositoryItem;

        public GridEditorItem(RepositoryItem fRepositoryItem, string fName, object fValue) {
            this.fRepositoryItem = fRepositoryItem;
            this.fName = fName;
            this.fValue = fValue;
        }
        public string Name { get { return this.fName; } }
        public object Value { get { return this.fValue; } set { this.fValue = value; } }
        public RepositoryItem RepositoryItem { get { return this.fRepositoryItem; } }
    }

    class GridEditorCollection : ArrayList {
        public GridEditorCollection() {
        }
        public new GridEditorItem this[int index] { get { return base[index] as GridEditorItem; } }
        public void Add(RepositoryItem fRepositoryItem, string fName, object fValue) {
            base.Add(new GridEditorItem(fRepositoryItem, fName, fValue));
        }
    }
    //</gridControl1>

}
