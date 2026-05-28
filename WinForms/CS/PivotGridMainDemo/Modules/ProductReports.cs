using System;
using System.Collections;
using DevExpress.Data.PivotGrid;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for ProductReports.
    /// </summary>
    public partial class ProductReports : TutorialControl {
        public ProductReports() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        private void ProductReports_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("ProductReports");
            cbeDate.SelectedIndex = 1;
            rgReport.SelectedIndex = 0;
            pivotGridControl1.ValueImages = CategoryImageList;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldProductSales.ImageIndex = 3;
        }

        private void pivotGridControl1_FieldValueDisplayText(object sender, DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventArgs e) {
            int value;
            if(e.Field == fieldShippedMonth && e.Value != null && Int32.TryParse(e.Value.ToString(), out value) && value > 0 && value <= 12) {
                e.DisplayText = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[value - 1];
                if(e.ValueType == PivotGridValueType.Total) 
                    e.DisplayText += " Total";
            }
        }
        //<rgReport>
        void SetReport() {
            DoShow();
            pivotGridControl1.BeginUpdate();
            try {
                layoutControlItem3.Visibility = rgReport.SelectedIndex == 1 ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
                layoutControlItem4.Visibility = rgReport.SelectedIndex == 2 ? XtraLayout.Utils.LayoutVisibility.Always : XtraLayout.Utils.LayoutVisibility.Never;
                //layoutControlItem3.ContentVisible = rgReport.SelectedIndex == 1;
                //layoutControlItem4.ContentVisible = rgReport.SelectedIndex == 2;
                fieldShippedMonth.Visible = rgReport.SelectedIndex == 2;
                foreach(PivotGridField field in pivotGridControl1.Fields)
                    field.Area = PivotArea.FilterArea;
                fieldProductSales.Area = PivotArea.DataArea;
                fieldCategoryName.CustomTotals.Clear();
                fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.AutomaticTotals;
                fieldCategoryName.Area = 0;
                fieldProductName.SortBySummaryInfo.Field = null;
                fieldProductName.SortOrder = PivotSortOrder.Ascending;
                fieldProductName.TopValueCount = 0;
                fieldAverageSale.Visible = fieldMinimumSale.Visible = false;
                pivotGridControl1.Groups[0].Clear();
                switch(rgReport.SelectedIndex) {
                    case 0:
                        fieldCategoryName.Area = PivotArea.RowArea;
                        break;
                    case 1:
                        fieldProductName.Area = PivotArea.RowArea;
                        if(ceCategories.Checked) {
                            fieldCategoryName.Area = PivotArea.RowArea;
                            fieldCategoryName.AreaIndex = 0;
                        }
                        else fieldCategoryName.Area = PivotArea.FilterArea;
                        break;
                    case 2:
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldProductName.Area = PivotArea.RowArea;
                        SetDateInterval();
                        break;
                    case 3:
                        fieldCategoryName.TotalsVisibility = PivotTotalsVisibility.CustomTotals;
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldProductName.Area = PivotArea.RowArea;
                        SetDateInterval(true);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Average);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Sum);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Max);
                        fieldCategoryName.CustomTotals.Add(PivotSummaryType.Min);
                        break;
                    case 4:
                        fieldShippedQuarter.SetAreaPosition(PivotArea.RowArea, 0);
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldAverageSale.SetAreaPosition(PivotArea.DataArea, 1);
                        fieldMinimumSale.SetAreaPosition(PivotArea.DataArea, 2);
                        fieldAverageSale.Visible = fieldMinimumSale.Visible = true;
                        break;
                    case 5:
                        fieldProductName.Area = PivotArea.RowArea;
                        fieldCategoryName.Area = PivotArea.RowArea;
                        fieldProductName.SortBySummaryInfo.Field = fieldProductSales;
                        fieldProductName.SortOrder = PivotSortOrder.Descending;
                        fieldProductName.TopValueCount = 3;
                        break;
                }
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</rgReport>
        //<cbeDate>
        void SetDateInterval() { SetDateInterval(false); }
        void SetDateInterval(bool showYearAndQuarter) {
            if(cbeDate.SelectedIndex == 3 && !showYearAndQuarter)
                pivotGridControl1.Groups[0].AddRange(new PivotGridFieldBase[] { fieldShippedYear, fieldShippedQuarter, fieldShippedMonth });
            else pivotGridControl1.Groups[0].Clear();
            fieldShippedYear.Area = (cbeDate.SelectedIndex == 0 || cbeDate.SelectedIndex == 3 || showYearAndQuarter) ? PivotArea.ColumnArea : PivotArea.FilterArea;
            fieldShippedQuarter.Area = (cbeDate.SelectedIndex == 1 || cbeDate.SelectedIndex == 3 || showYearAndQuarter) ? PivotArea.ColumnArea : PivotArea.FilterArea;
            fieldShippedMonth.Area = (cbeDate.SelectedIndex == 2 || cbeDate.SelectedIndex == 3) ? PivotArea.ColumnArea : PivotArea.FilterArea;
            if(showYearAndQuarter) fieldShippedMonth.Area = PivotArea.FilterArea;
            fieldShippedYear.AreaIndex = 0;
            fieldShippedQuarter.AreaIndex = 1;
            fieldShippedMonth.AreaIndex = 2;
        }
        //</cbeDate>
        
        private void rgReport_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetReport();
        }        

        private void ceCategories_CheckedChanged(object sender, System.EventArgs e) {
            SetReport();
        }
        
        private void cbeDate_SelectedIndexChanged(object sender, System.EventArgs e) {
            pivotGridControl1.BeginUpdate();
            try {
                SetDateInterval();
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }        
        //<ceDrillDown>
        void pivotGridControl1_CellDoubleClick(object sender, DevExpress.XtraPivotGrid.PivotCellEventArgs e) {
            if(!ceDrillDown.Checked) return;
            using(DrillDownForm form = new DrillDownForm(e.CreateDrillDownDataSource()))
                form.ShowDialog();
        }
        //</ceDrillDown>
        void pivotGridControl1_FieldValueImageIndex(object sender, DevExpress.XtraPivotGrid.PivotFieldImageIndexEventArgs e) {
            if(e.Field == fieldCategoryName && Comparer.Equals(e.ValueType, PivotGridValueType.Value))
                e.ImageIndex = GetCategoryIndexByName(e.Value);
        }
    }
}
