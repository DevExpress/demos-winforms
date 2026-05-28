using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraGrid.Demos {
    public partial class CardViewControl : DevExpress.XtraGrid.Demos.TutorialControl {
        public CardViewControl() {
            // This call is required by the Windows Form Designer.
            CreateWaitDialog();
            InitializeComponent();
            SetButtonEnabled();
            LicenseInfo.SetToolTipController(this, gridControl1);
            // TODO: Add any initialization after the InitializeComponent call
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "CardViewControl" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "CardViewControl"; }
        }
        bool updateLayout = false;
        int oldMaxColumn = -1;
        int oldMaxRows = -1;
        #region Init
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return cardView1; } }
        private void CardView_Load(object sender, System.EventArgs e) {
            InitVehiclesData();
            InitEditors();
            cardView1_Layout(cardView1, EventArgs.Empty);
        }

        public override bool ShowViewOptions { get { return true; } }

        protected override void InitXMLData(string dataFileName) {
            VehiclesData.InitXMLData(dataFileName, gridControl1);
            VehiclesData.InitColumnViewEditors(cardView1);
        }

        void InitEditors() {
            icbFormat.EditValue = cardView1.CardCaptionFormat;
            seMaxColumns.EditValue = cardView1.MaximumCardColumns;
            seMaxRows.EditValue = cardView1.MaximumCardRows;
            ceAutoHorzWidth.Checked = cardView1.OptionsBehavior.AutoHorzWidth;
            ceMultiSelect.Checked = cardView1.OptionsSelection.MultiSelect;
        }
        #endregion
        #region Editing

        private void cardView1_Layout(object sender, System.EventArgs e) {
            updateLayout = true;
            ceCustomize.Checked = cardView1.OptionsView.ShowQuickCustomizeButton;
            ceButtons.Checked = cardView1.OptionsView.ShowCardExpandButton;
            updateLayout = false;
        }
        #endregion
        #region Customize
        //<ceCustomize>
        private void ceCustomize_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if(updateLayout) return;
            //</skip>
            cardView1.OptionsView.ShowQuickCustomizeButton = ceCustomize.Checked;
            //<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(cardView1);
            //</skip>
        }
        //</ceCustomize>
        //<ceSorting>
        private void ceSorting_CheckedChanged(object sender, System.EventArgs e) {
            foreach(GridColumn col in cardView1.Columns)
                col.OptionsColumn.AllowSort = ceSorting.Checked ? DevExpress.Utils.DefaultBoolean.Default : DevExpress.Utils.DefaultBoolean.False;
        }
        //</ceSorting>
        //<ceFiltering>
        private void ceFiltering_CheckedChanged(object sender, System.EventArgs e) {
            foreach(GridColumn col in cardView1.Columns)
                col.OptionsFilter.AllowFilter = ceFiltering.Checked;
        }
        //</ceFiltering>
        #endregion
        #region Captions
        //<ceImage>
        private void cardView1_CustomCardCaptionImage(object sender, DevExpress.XtraGrid.Views.Card.CardCaptionImageEventArgs e) {
            if(!ceImage.Checked) return;
            VehiclesData.Model model = cardView1.GetRow(e.RowHandle) as VehiclesData.Model;
            e.Image = model.GetSmallTrademarkImage();
        }
        private void cardView1_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e) {
            if(cardView1.FocusedColumn.FieldName == "Trademark")
                this.BeginInvoke(new MethodInvoker(delegate { cardView1.LayoutChanged(); }));
        }
        private void ceImage_CheckedChanged(object sender, System.EventArgs e) {
            cardView1.LayoutChanged();
        }
        //</ceImage>
        //<ceButtons>
        private void ceButtons_CheckedChanged(object sender, System.EventArgs e) {
            //<skip>
            if(updateLayout) return;
            //</skip>
            cardView1.OptionsView.ShowCardExpandButton = ceButtons.Checked;
            //<skip>
            GridRibbonMenuManager.RefreshOptionsMenu(cardView1);
            //</skip>
        }
        //</ceButtons>
        //<icbFormat>
        private void icbFormat_SelectedIndexChanged(object sender, System.EventArgs e) {
            cardView1.CardCaptionFormat = icbFormat.EditValue.ToString();
        }
        //</icbFormat>
        #endregion
        #region Layout

        //<seMaxColumns>
        private void seMaxColumns_EditValueChanged(object sender, System.EventArgs e) {
            int val = Convert.ToInt32(seMaxColumns.Value);
            if(val == 0) {
                val = val > oldMaxColumn ? 1 : -1;
                seMaxColumns.Value = val;
            }
            cardView1.MaximumCardColumns = val;
            oldMaxColumn = val;
        }
        //</seMaxColumns>
        //<seMaxRows>
        private void seMaxRows_EditValueChanged(object sender, System.EventArgs e) {
            int val = Convert.ToInt32(seMaxRows.Value);
            if(val == 0) {
                val = val > oldMaxRows ? 1 : -1;
                seMaxRows.Value = val;
            }
            cardView1.MaximumCardRows = val;
            oldMaxRows = val;
        }
        //</seMaxRows>
        //<ceAutoHorzWidth>
        private void ceAutoHorzWidth_CheckedChanged(object sender, System.EventArgs e) {
            cardView1.OptionsBehavior.AutoHorzWidth = ceAutoHorzWidth.Checked;
        }
        //</ceAutoHorzWidth>
        #endregion
        #region MultiSelect
        //<ceMultiSelect>
        private void ceMultiSelect_CheckedChanged(object sender, System.EventArgs e) {
            cardView1.OptionsSelection.MultiSelect = ceMultiSelect.Checked;
            if(ceMultiSelect.Checked && cardView1.SelectedRowsCount < 2) cardView1.SelectRange(2, 9);
            //<skip>
            SetButtonEnabled();
            //</skip>
        }
        //</ceMultiSelect>
        void SetButtonEnabled() {
            sbRecords.Enabled = cardView1.SelectedRowsCount > 0 && ceMultiSelect.Checked;
        }

        private void cardView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e) {
            SetButtonEnabled();
        }
        //<sbRecords>
        private void sbRecords_Click(object sender, System.EventArgs e) {
            DemosHelper.ShowDescriptionForm(Control.MousePosition, GetSelectedRows(), Properties.Resources.SelectedRows);
        }
        
        string GetSelectedRows() {
            string ret = "";
            foreach(int i in cardView1.GetSelectedRows()) {
                VehiclesData.Model model = cardView1.GetRow(i) as VehiclesData.Model;
                if(ret != "") ret += "\r\n";
                ret += string.Format("{0} {1} : {2:$#,0.00}", model.TrademarkName, model.Name, model.Price);
            }
            return ret;
        }
        //</sbRecords>
        #endregion
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}

