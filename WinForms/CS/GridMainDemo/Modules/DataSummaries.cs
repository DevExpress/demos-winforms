using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for DataSummaries.
    /// </summary>
    public partial class DataSummaries : TutorialControl {
        public DataSummaries() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
            InitNWindData();
            InitSummaries();
            InitEditing();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "DataSummaries" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "DataSummaries"; }
        }
        //<gridControl1>
        private GridGroupSummaryItemCollection gsiSummary, gsiMultiSummary, gsiMultiSummaryDetail, gsiDisplaySummary, gsiDisplaySummaryDetails;
        //</gridControl1>

        private bool displaySummary = false;
        #region Init
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return advBandedGridView1; } }


        private GridControl CurrentGrid { get { return gridControl1; } }
        private GridView CurrentView { get { return advBandedGridView1; } }
        private GridView CurrentDetailView { get { return gridView1; } }

        protected override DataSet InitNWindXMLData(string dataFileName) {
            dsNWindProducts1.ReadXml(dataFileName, XmlReadMode.InferSchema);
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1);
            return dsNWindProducts1;
        }
        private void InitEditing() {
            gridControl1.ForceInitialize();
            colSupplierID.GroupIndex = 0;
            colPrice.GroupIndex = 0;
            SetShowFooter(chShowFooter.Checked);
            chAlignSummary.Checked = true;
            OnSummaryChecked(chDisplaySummary);
        }
        private void UpdateMasterDetailSettings() {
            CurrentView.BeginUpdate();
            CurrentView.ExpandAllGroups();
            CurrentView.FocusedRowHandle = 0;
            CurrentView.TopRowIndex = 0;
            CurrentView.SetMasterRowExpanded(CurrentView.FocusedRowHandle, true);
            if (ceMasterDetail.Checked) {
                if (FirstDetailView != null) FirstDetailView.ExpandGroupRow(-1);
            } else CurrentDetailView.ExpandAllGroups();
            CurrentView.EndUpdate();
        }
        GridView FirstDetailView { 
            get {
                return CurrentView.GetDetailView(0, 0) as GridView;
            }
        }
        //<gridControl1>
        private void InitSummaries() {
            /* ~row summary */
            gsiSummary = new GridGroupSummaryItemCollection(CurrentView);
            gsiSummary.Add(SummaryItemType.Count, "ProductID");

            /* ~multi row summary */
            gsiMultiSummary = new GridGroupSummaryItemCollection(CurrentView);
            gsiMultiSummary.Add(SummaryItemType.Count, "ProductID");
            gsiMultiSummary.Add(SummaryItemType.Average, "UnitPrice", null, Properties.Resources.AvgByPriceFormatCurrency);

            /* ~multi row summary for detail */
            gsiMultiSummaryDetail = new GridGroupSummaryItemCollection(CurrentDetailView);
            gsiMultiSummaryDetail.Add(SummaryItemType.Count, "OrderID");
            gsiMultiSummaryDetail.Add(SummaryItemType.Sum, "SubTotal", null, Properties.Resources.SubTotalFormatCurrency);

            /* ~row footer summary */
            gsiDisplaySummary = new GridGroupSummaryItemCollection(CurrentView);
            gsiDisplaySummary.Add(SummaryItemType.Max, "UnitsOnOrder", colUnitsOnOrder, Properties.Resources.MaxFormat);
            gsiDisplaySummary.Add(SummaryItemType.Sum, "UnitsInStock", colUnitsInStock, Properties.Resources.SumFormat);
            gsiDisplaySummary.Add(SummaryItemType.Average, "UnitPrice", colUnitPrice, Properties.Resources.AvgFormatCurrency);
            gsiDisplaySummary.Add(SummaryItemType.Count, "ProductName", colProductName);

            /* ~row footer summary for details */
            gsiDisplaySummaryDetails = new GridGroupSummaryItemCollection(CurrentDetailView);
            gsiDisplaySummaryDetails.Add(SummaryItemType.Sum, "SubTotal", colSubTotal, Properties.Resources.SumFormatCurrency);
            gsiDisplaySummaryDetails.Add(SummaryItemType.Min, "Quantity", colQuantity, Properties.Resources.MinFormat);
        }
        //</gridControl1>

        private void DataSummaries_Load(object sender, System.EventArgs e) {
            UpdateMasterDetailSettings();
        }
        #endregion
        #region Editing
        //<chShowFooter>
        private void SetShowFooter(bool show) {
            CurrentView.OptionsView.ShowFooter = show;
            CurrentDetailView.OptionsView.ShowFooter = show;
        }
        private void chShowFooter_CheckedChanged(object sender, System.EventArgs e) {
            CheckEdit chb = sender as CheckEdit;
            SetShowFooter(chb.Checked);
            
        }
        //</chShowFooter>

        private void SaveDisplaySummary() {
            if (displaySummary) {
                gsiDisplaySummary.Assign(CurrentView.GroupSummary);
                gsiDisplaySummaryDetails.Assign(CurrentDetailView.GroupSummary);
                CurrentView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded;
                CurrentDetailView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleIfExpanded;
            }
            displaySummary = false;
        }
        #endregion
        decimal GetSubTotalFromDataRow(DataRow row) {
            decimal q = Convert.ToDecimal(row["Quantity"]);
            decimal p = Convert.ToDecimal(row["UnitPrice"]);
            decimal d = Convert.ToDecimal(row["Discount"]);
            return q * p * (1 - d);
        }

        private void gridView1_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e) {
            if (e.IsSetData || e.Column.FieldName != "SubTotal") return;
            GridView view = sender as GridView;
            e.Value = GetSubTotalFromDataRow(((DataRowView)e.Row).Row);
        }

        bool updateInfo = false;
        private void chSummary_CheckedChanged(object sender, EventArgs e) {
            if (updateInfo) return;
            OnSummaryChecked(sender as CheckEdit);
        }

        //<gridControl1>
        private void OnSummaryChecked(CheckEdit edit) {
            if(edit.Properties.Tag == null) return;
            updateInfo = true;
            string _caption = edit.Properties.Tag.ToString();
            switch (_caption) {
                case "Summary":
                    chSummary.Checked = true;
                    chAlignSummary.Enabled = false;
                    SaveDisplaySummary();
                    CurrentView.GroupSummary.Assign(gsiSummary);
                    CurrentDetailView.GroupSummary.Assign(gsiSummary);
                    break;
                case "Multi Summary":
                    chMultiSummary.Checked = true;
                    chAlignSummary.Enabled = false;
                    SaveDisplaySummary();
                    CurrentView.GroupSummary.Assign(gsiMultiSummary);
                    CurrentDetailView.GroupSummary.Assign(gsiMultiSummaryDetail);
                    break;
                case "Display Summary":
                    chDisplaySummary.Checked = true;
                    chAlignSummary.Enabled = true;
                    displaySummary = true;
                    CurrentView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
                    CurrentDetailView.OptionsView.GroupFooterShowMode = GroupFooterShowMode.VisibleAlways;
                    CurrentView.GroupSummary.Assign(gsiDisplaySummary);
                    CurrentDetailView.GroupSummary.Assign(gsiDisplaySummaryDetails);
                    break;
            }
            UpdateAlignSummary();
            UpdateMasterDetailSettings();
            updateInfo = false;
        }

        void UpdateAlignSummary() {
            CurrentDetailView.OptionsBehavior.AlignGroupSummaryInGroupRow = 
                chAlignSummary.Enabled && chAlignSummary.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        //</gridControl1>
        void chAlignSummary_CheckedChanged(object sender, EventArgs e) {
            UpdateAlignSummary();
        }

        private void ceMasterDetail_CheckedChanged(object sender, EventArgs e) {
            if(ceMasterDetail.Checked) {
                colOrderID.GroupIndex = -1;
                colPrice.GroupIndex = 0;
                gridControl1.MainView = CurrentView;
                gridControl1.DataSource = dsNWindProducts1.Products;
                colProduct.Visible = false;
            } else {
                colPrice.GroupIndex = -1;
                colOrderID.GroupIndex = 0;
                gridControl1.MainView = CurrentDetailView;
                gridControl1.DataSource = dsNWindProducts1.Order_Details;
                colProduct.VisibleIndex = 0;
            }
            UpdateMasterDetailSettings();
        }
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
