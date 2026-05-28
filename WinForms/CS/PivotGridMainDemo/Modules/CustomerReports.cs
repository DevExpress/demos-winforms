using DevExpress.Utils;

namespace DevExpress.XtraPivotGrid.Demos.Modules {
    /// <summary>
    /// Summary description for CustomerReports.
    /// </summary>
    public partial class CustomerReports : TutorialControl {
        public CustomerReports() {
            //
            // Required for Windows Form Designer support
            //
            CreateWaitDialog();
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        public override PivotGridControl ViewOptionsControl { get { return pivotGridControl1; } }
        public override PivotGridControl ExportControl { get { return pivotGridControl1; } }

        private void CustomerReports_Load(object sender, System.EventArgs e) {
            pivotGridControl1.DataSource = GetNWindData("CustomerReports");
            InitComboBox();
            rgReport.SelectedIndex = 0;
            pivotGridControl1.HeaderImages = HeadersImageList;
            fieldCompanyName.ImageIndex = 2;
        }

        void InitComboBox() {
            object[] values = fieldOrderYear.GetUniqueValues();
            foreach(object obj in values)
                cbeYear.Properties.Items.Add(obj);
            cbeYear.SelectedIndex = 1;
            values = fieldOrderQuarter.GetUniqueValues();
            foreach(object obj in values)
                cbeQuarter.Properties.Items.Add(obj);
            cbeQuarter.SelectedIndex = 0;
        }
        //<rgReport>
        void SetReport() {
            DoShow();
            pivotGridControl1.BeginUpdate();
            try {
                fieldOrderYear.Group.FilterValues.Reset();
                cbeYearItem.ContentVisible = rgReport.SelectedIndex == 1;
                cbeQuarteritem.ContentVisible = rgReport.SelectedIndex == 1;
                pivotGridControl1.OptionsView.ShowColumnGrandTotals = rgReport.SelectedIndex != 1;
                if(rgReport.SelectedIndex != 1)
                    pivotGridControl1.OptionsView.ShowColumnTotals = true;
                DefaultBoolean parameter = (rgReport.SelectedIndex == 1) ? DefaultBoolean.False : DefaultBoolean.Default;
                fieldOrderQuarter.Options.AllowFilter = fieldOrderQuarter.Options.AllowSort =
                    fieldOrderYear.Options.AllowFilter = fieldOrderYear.Options.AllowSort = parameter;
                fieldCompanyName.Area = fieldProductName.Area = PivotArea.RowArea;
                fieldOrderYear.Area = fieldOrderQuarter.Area = PivotArea.ColumnArea;
                fieldProductAmount.Area = PivotArea.DataArea;
                fieldProductName.TopValueCount = fieldCompanyName.TopValueCount = 0;
                fieldProductName.SortOrder = fieldCompanyName.SortOrder = PivotSortOrder.Ascending;
                fieldProductName.SortBySummaryInfo.Field = null;
                fieldCompanyName.SortBySummaryInfo.Field = null;
                switch(rgReport.SelectedIndex) {
                    case 0:
                        fieldCompanyName.AreaIndex = 0;
                        break;
                    case 1:
                        fieldProductName.Area = 0;
                        SetYearFilter();
                        break;
                    case 2:
                        fieldCompanyName.AreaIndex = 0;
                        fieldOrderYear.Area = fieldOrderQuarter.Area = PivotArea.FilterArea;
                        fieldProductName.SortBySummaryInfo.Field = fieldProductAmount;
                        fieldProductName.SortOrder = PivotSortOrder.Descending;
                        fieldProductName.TopValueCount = 2;
                        break;
                    case 3:
                        fieldProductName.Area = PivotArea.FilterArea;
                        fieldOrderYear.Area = fieldOrderQuarter.Area = PivotArea.FilterArea;
                        fieldCompanyName.SortBySummaryInfo.Field = fieldProductAmount;
                        fieldCompanyName.SortOrder = PivotSortOrder.Descending;
                        fieldCompanyName.TopValueCount = 10;
                        break;
                }
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //</rgReport>
        //<cbeYear>
        //<cbeQuarter>
        void SetYearFilter() {
            object[] valuesYear = fieldOrderYear.GetUniqueValues();
            object[] valuesQuarter = fieldOrderQuarter.GetUniqueValues();
            pivotGridControl1.BeginUpdate();
            try {
                PivotGridGroup group = fieldOrderYear.Group;
                group.FilterValues.Reset();
                group.FilterValues.FilterType = PivotFilterType.Included;
                PivotGroupFilterValue yearValue = group.FilterValues.Values.Add(cbeYear.SelectedItem);
                pivotGridControl1.OptionsView.ShowColumnTotals = cbeQuarter.SelectedIndex == 0;
                if(cbeQuarter.SelectedIndex != 0)
                    yearValue.ChildValues.Add(cbeQuarter.SelectedItem);
            }
            finally {
                pivotGridControl1.EndUpdate();
            }
        }
        //<skip>
        void rgReport_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetReport();
        }
        //</skip>
        void cbeQuarter_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetYearFilter();
        }
        void cbeYear_SelectedIndexChanged(object sender, System.EventArgs e) {
            SetYearFilter();
        }
        //</cbeQuarter> 
        //</cbeYear>
    }
}
