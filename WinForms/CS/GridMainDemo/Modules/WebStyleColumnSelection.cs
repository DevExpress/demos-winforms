using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors;
using DevExpress.Utils.Svg;

namespace DevExpress.XtraGrid.Demos {
    public partial class WebStyleColumnSelection : TutorialControl {
        bool _initData = false;
        int[] unboundSelectedRows, selectedRows = new int[] { };
        public WebStyleColumnSelection() {
            InitializeComponent();
            InitNWindData();
            InitEditors();
            InitData();
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "WebStyleColumnSelection" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "WebStyleColumnSelection"; }
        }
        public override BaseView ExportView { get { return gridView1; } }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            string tblGrid = "Order Details", tblLookUp = "Products";
            DataSet ds = new DataSet();

            SetWaitDialogCaption(Properties.Resources.LoadingOrderDetails);

            ds.ReadXml(dataFileName);
            gridControl1.DataSource = OrderItem.GetOrderItems(ds.Tables[tblGrid]);
            repositoryItemLookUpEdit1.DataSource = ds.Tables[tblLookUp];
            return ds;
        }

        void InitEditors() {
            foreach(DefaultBoolean val in Enum.GetValues(typeof(DefaultBoolean))) {
                icbShowCheckBoxSelectorInGroupRow.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowCheckBoxSelectorInHeader.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
                icbShowCheckBoxSelectorInPrintExport.Properties.Items.Add(new ImageComboBoxItem(EnumTitlesKeeper<DefaultBoolean>.GetTitle(val), val, -1));
            }
        }
        void InitData() {
            _initData = true;
            try {
                icbShowCheckBoxSelectorInGroupRow.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow;
                icbShowCheckBoxSelectorInHeader.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader;
                icbShowCheckBoxSelectorInPrintExport.EditValue = gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport;
                cePrintSelectedRowsOnly.Checked = gridView1.OptionsPrint.PrintSelectedRowsOnly;
            } finally { }
            _initData = false;
        }

        //<icbShowCheckBoxSelectorInGroupRow>
        private void icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initData) return;
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit; 
            gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = (DefaultBoolean)edit.EditValue;
        }
        //</icbShowCheckBoxSelectorInGroupRow>

        //<icbShowCheckBoxSelectorInHeader>
        private void icbShowCheckBoxSelectorInColumnHeader_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initData) return;
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit; 
            gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = (DefaultBoolean)edit.EditValue;
        }
        //</icbShowCheckBoxSelectorInHeader>

        //<icbShowCheckBoxSelectorInPrintExport>
        private void icbShowCheckBoxSelectorInPrintExport_SelectedIndexChanged(object sender, EventArgs e) {
            if(_initData) return;
            ImageComboBoxEdit edit = sender as ImageComboBoxEdit; 
            gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = (DefaultBoolean)edit.EditValue;
        }
        //</icbShowCheckBoxSelectorInPrintExport>

        //<cePrintSelectedRowsOnly>
        private void cePrintSelectedRowsOnly_CheckedChanged(object sender, EventArgs e) {
            if(_initData) return;
            CheckEdit edit = sender as CheckEdit; 
            gridView1.OptionsPrint.PrintSelectedRowsOnly = edit.Checked;
        }
        //</cePrintSelectedRowsOnly>
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion

        private void simpleButton1_Click(object sender, EventArgs e) {
            Cursor currentCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            gridControl1.ShowRibbonPrintPreview();
            Cursor.Current = currentCursor;
        }
        //<ceBindSelection>
        void ceBindSelection_CheckedChanged(object sender, EventArgs e) {
            CheckEdit edit = sender as CheckEdit;
            if(edit.Checked)
                unboundSelectedRows = gridView1.GetSelectedRows();
            else selectedRows = gridView1.GetSelectedRows();
            gridView1.OptionsSelection.CheckBoxSelectorField = edit.Checked ? "Selector" : string.Empty;
			gridView1.ClearSelection();
            var rows = edit.Checked ? selectedRows : unboundSelectedRows;
            DevExpress.Utils.Extensions.EnumerableExtensions.ForEach(rows, new Action<int>(gridView1.SelectRow));
        }
        //</ceBindSelection>
    }
}
