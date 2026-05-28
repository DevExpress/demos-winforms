using System;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;

namespace DevExpress.XtraGrid.Demos {
    /// <summary>
    /// Summary description for SortingBySummary.
    /// </summary>
    public partial class SortingBySummary : TutorialControl {
        public SortingBySummary() {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            DemoHelper.AddCategoryImagesToEdit(repositoryItemImageComboBox1);

            // TODO: Add any initialization after the InitForm call

            //<gridControl1>
            /*
            ~Note: the following properties are set at design time and listed here only for demonstration purposes.
            gridView1.GroupSummary.AddRange(new GridSummaryItem[] {
                new GridGroupSummaryItem(SummaryItemType.Count, "Product Name", null, "(Product: Count {0})"),
                new GridGroupSummaryItem(SummaryItemType.Sum, "Order Sum", null, "(Orders: Sum {0:c})"),
                new GridGroupSummaryItem(SummaryItemType.Average, "Unit Price", null, "(Price: Avg {0:c})")});
            */
            //</gridControl1>
        }
        protected override string[] WhatsThisCodeFileNames {
            get { return new string[] { "SortingBySummary" }; }
        }
        protected override string WhatsThisXMLFileName {
            get { return "SortingBySummary"; }
        }
        public override DevExpress.XtraGrid.Views.Base.BaseView ExportView { get { return gridView1; } }
        private void SortingBySummary_Load(object sender, System.EventArgs e) {
            gridControl1.DataSource = GroupIntervalData.CreateDataTable(500, false);
            cbeSorting.SelectedIndex = 4;
        }
        //<cbeSorting>
        GridColumn GroupColumn { get { return gridColumn5; } }
        int CurrentSummaryItemIndex { get { return (int)cbeSorting.SelectedIndex / 2 - 1; } }
        ColumnSortOrder CurrentSortOrder { get { return cbeSorting.SelectedIndex % 2 == 0 ? ColumnSortOrder.Ascending : ColumnSortOrder.Descending; } }

        private void cbeSorting_SelectedIndexChanged(object sender, System.EventArgs e) {
            gridView1.BeginSort();
            try {
                gridView1.GroupSummarySortInfo.Clear();
                GroupColumn.SortOrder = CurrentSortOrder;
                if(CurrentSummaryItemIndex >= 0)
                    gridView1.GroupSummarySortInfo.Add(
                        gridView1.GroupSummary[CurrentSummaryItemIndex], CurrentSortOrder, GroupColumn);
            }
            finally {
                gridView1.EndSort();
            }
        }
        //</cbeSorting>
        string[] columns = new string[] { "Empty", "Product", "Order", "Price" };
        private void gridView1_GridMenuItemClick(object sender, DevExpress.XtraGrid.Views.Grid.GridMenuItemClickEventArgs e) {
            if(e.MenuType != GridMenuType.Column ||
                e.SummaryItem == null) return;
            cbeSorting.SelectedIndex = -1;
            int index = -1;
            for(int i = 1; i < columns.Length; i++)
                if(e.DXMenuItem.Caption.IndexOf(columns[i], StringComparison.OrdinalIgnoreCase) > -1) index = i * 2;
            if(e.SummaryFormat.Equals($"{SortOrder.Descending}")) index += 1;
            cbeSorting.SelectedIndex = index;
            e.Handled = true;
        }
        #region GenerateReport

        public override bool AllowGenerateReport { get { return false; } }

        #endregion
    }
}
