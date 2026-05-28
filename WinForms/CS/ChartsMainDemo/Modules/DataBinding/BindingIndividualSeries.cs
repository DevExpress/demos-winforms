using System;
using System.Linq;
using DevExpress.Data.Filtering;

namespace DevExpress.XtraCharts.Demos {
    public partial class BindingIndividualSeriesDemo : ChartDemoModuleWithOptions {
        ChartControl chart;

        SummaryDataAdapter DevAVNorthDataAdapter { get { return (SummaryDataAdapter)chart.Series[0].DataAdapter; } }
        SummaryDataAdapter DevAVSouthDataAdapter { get { return (SummaryDataAdapter)chart.Series[1].DataAdapter; } }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public BindingIndividualSeriesDemo() {
            InitializeComponent();
            chart.BeginInit();
            gridControl1.DataSource = DevAVNorthDataAdapter.DataSource = SaleItem.GetProductsByCompany(0);
            gridControl1.ForceInitialize();
            gridControl2.DataSource = DevAVSouthDataAdapter.DataSource = SaleItem.GetProductsByCompany(1);
            gridControl2.ForceInitialize();
            chart.EndInit();
        }

        void chart_BoundDataChanged(object sender, EventArgs e) {
            ChartControl.Animate();
        }
        void comboBoxEditFilterBy_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditFilterBy.SelectedIndex == -1)
                return;
            BinaryOperator filterCriteria = comboBoxEditFilterBy.SelectedIndex != 0 ? new BinaryOperator("Category", comboBoxEditFilterBy.Text, BinaryOperatorType.Equal) : null;
            DevAVNorthDataAdapter.FilterCriteria = filterCriteria;
            DevAVSouthDataAdapter.FilterCriteria = filterCriteria;
        }
        void comboBoxEditSortOrdering_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditSortOrdering.SelectedIndex == -1)
                return;
            SortingMode sortingMode = (SortingMode)comboBoxEditSortOrdering.SelectedIndex;
            foreach(Series series in chart.Series)
                series.SeriesPointsSorting = sortingMode;
            lciNorthSortingKey.Enabled = !sortingMode.Equals(SortingMode.None);
        }
        void comboBoxEditSortBy_SelectedIndexChanged(object sender, EventArgs e) {
            if(chart.Series.Count < 2)
                return;
            SortingMode sortingMode = (SortingMode)comboBoxEditSortOrdering.SelectedIndex;
            switch(comboBoxEditSortBy.SelectedIndex) {
                case 0:
                    UpdateSeriesSorting(sortingMode, SeriesPointKey.Argument, 0, 1);
                    break;
                case 1:
                    UpdateSeriesSorting(sortingMode, SeriesPointKey.Value_1, 0, 1);
                    break;
                case 2:
                    UpdateSeriesSorting(sortingMode, SeriesPointKey.Value_1, 1, 0);
                    break;
                default:
                    break;
            }
        }
        void comboBoxEditArgumentDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditArgumentDataMember.SelectedIndex == -1)
                return;
            DevAVNorthDataAdapter.DataMembers[ChartDataMemberType.Argument] = comboBoxEditArgumentDataMember.Text;
            DevAVSouthDataAdapter.DataMembers[ChartDataMemberType.Argument] = comboBoxEditArgumentDataMember.Text;
        }
        void comboBoxEditValueDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditValueDataMember.SelectedIndex == -1)
                return;
            UpdateValueDataMember(DevAVNorthDataAdapter);
            UpdateValueDataMember(DevAVSouthDataAdapter);
        }
        void UpdateValueDataMember(SummaryDataAdapter adapter) {
            adapter.DataMembers[ChartDataMemberType.Value] = comboBoxEditValueDataMember.Text;
            adapter.QualitativeSummaryOptions.SummaryFunction = string.Format("SUM([{0}])", comboBoxEditValueDataMember.Text);
        }
        void OnGridViewSelectionChanged(object sender, Data.SelectionChangedEventArgs e) {
            object[] selectedObjects = gridView1.GetSelectedRows().Select(row => gridView1.GetRow(row)).
                                                                Union(gridView2.GetSelectedRows().Select(row => gridView2.GetRow(row))).ToArray();
            chart.ReplaceSelectedItems(selectedObjects);
        }
        void UpdateSeriesSorting(SortingMode sortingMode, SeriesPointKey sortingKey, int applySeriesIndex, int resetSeriesIndex) {
            chart.Series[resetSeriesIndex].SeriesPointsSorting = SortingMode.None;
            chart.Series[applySeriesIndex].SeriesPointsSorting = sortingMode;
            chart.Series[applySeriesIndex].SeriesPointsSortingKey = sortingKey;
        }
    }
}
