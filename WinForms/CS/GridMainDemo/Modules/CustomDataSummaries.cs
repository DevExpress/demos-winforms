using System;
using System.Drawing;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;
using DevExpress.Data;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Menu;
using DevExpress.Mvvm.Native;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for CustomDataSummaries.
    /// </summary>
    public partial class CustomDataSummaries : TutorialControl {
        public CustomDataSummaries() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();

            InitNWindData();

            gridControl2.RefreshDataSource();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //

            //<gridControl2>
            /*
            ~Note: the following code is generated at design time and listed here only for demonstration purposes.
            ~Create two group summaries (Custom and Count):
            gridView2.GroupSummary.AddRange(new GridSummaryItem[] {
                new GridGroupSummaryItem(SummaryItemType.Custom, "Freight", null, "(Order Count [WHERE Freight &gt;= 100 = {0}])"),
                new GridGroupSummaryItem(SummaryItemType.Count, "OrderID", null, "(Total Order Count = {0})")});

            ~Create a Custom total summary:
            colFreight.Summary.AddRange(new GridSummaryItem[] {
                new GridColumnSummaryItem(SummaryItemType.Custom, "Freight", "Custom SUM={0:c}")});
            */
            //</gridControl2>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "CustomDataSummaries" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "CustomDataSummaries"; }
        }
        int totalCount;
        decimal totalSum;
        AppearanceDefault footerApp = new AppearanceDefault(Color.Red, Color.Empty,
                    new Font(AppearanceObject.DefaultFont, FontStyle.Bold));

        #region Init
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView2; } }
        private GridView CustomGridView { get { return gridView2; } }
        protected override DataSet InitNWindXMLData(string dataFileName) {
            DataSet ds = new DataSet();
            SetWaitDialogCaption(Properties.Resources.LoadingTables);
            ds.ReadXml(dataFileName);
            gridControl2.DataSource = ds.Tables["Orders"];
            repositoryItemLookUpEdit2.DataSource = ds.Tables["Customers"];
            repositoryItemLookUpEdit3.DisplayMember = "Name";
            repositoryItemLookUpEdit3.DataSource = ds.Tables["Employees"];
            return ds;
        }

        private void CustomDataSummaries_Load(object sender, System.EventArgs e) {
            UpdateCaptions(numCustom.Value);
        }
        #endregion
        #region Custom summaries
        //<gridControl2>
        void InitStartValue() {
            totalCount = 0;
            totalSum = 0;
        }
        private void gridView2_CustomSummaryCalculate(object sender, DevExpress.Data.CustomSummaryEventArgs e) {
            if(e.SummaryProcess == CustomSummaryProcess.Start) {
                InitStartValue();
            }
            if(e.SummaryProcess == CustomSummaryProcess.Calculate) {
                if(e.FieldValue != null && e.FieldValue != DBNull.Value)
                    if((decimal)e.FieldValue >= numCustom.Value) {
                        if(e.IsGroupSummary) totalCount++;
                        if(e.IsTotalSummary) totalSum += (decimal)e.FieldValue;
                    }
                if(e.IsGroupSummary)
                    e.TotalValue = totalCount;
                if(e.IsTotalSummary)
                    e.TotalValue = totalSum;
            }
        }
        //</gridControl2>

        //<numCustom>
        private void numCustom_ValueChanged(object sender, System.EventArgs e) {
            CustomGridView.UpdateSummary();
            //<skip>
            UpdateCaptions(numCustom.Value);
            //</skip>
        }
        //</numCustom>

        void UpdateCaptions(decimal d) {
            CustomGridView.GroupSummary[0].DisplayFormat = string.Format(Properties.Resources.CustomOrderCountCaption, d) + " = {0})";
            gridView2.FormatConditions[0].Value1 = d;
        }
        #endregion
        #region Custom summaries appearance
        private void gridView2_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e) {
            GridViewFooterMenu menu = e.Menu as GridViewFooterMenu;
            if(menu != null && menu.Column != null) {
                if(menu.Column.FieldName == "Freight")
                    foreach(DXMenuItem item in menu.Items)
                        item.Enabled = false;
            }
        }

        private void gridView2_CustomDrawFooterCell(object sender, DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventArgs e) {
            if(e.Column.FieldName == "Freight")
                AppearanceHelper.Apply(e.Appearance, footerApp);
        }
        #endregion
        #region ReportGeneration
        public override bool AllowGenerateReport { get { return false; } }
        #endregion
    }
}
