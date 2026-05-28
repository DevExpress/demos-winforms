using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExpress.XtraCharts.Demos {
    public partial class UsingSeriesTemplatesDemo : ChartDemoModuleWithOptions {
        static SeriesPoint[] CalcStdDev(Series series, object argument, string[] functionArguments, DataSourceValues[] values, object[] colors) {
            double[] amount = new double[values.Length];
            double sum = 0.0;
            for(int i = 0; i < values.Length; i++) {
                amount[i] = Convert.ToDouble(values[i][functionArguments[0]]);
                sum += amount[i];
            }
            double averageAmount = sum / values.Length;
            double standardDeviationSquareSum = 0.0;
            for(int i = 0; i < values.Length; i++) {
                double deviation = amount[i] - averageAmount;
                standardDeviationSquareSum += deviation * deviation;
            }
            return new SeriesPoint[] { new SeriesPoint(argument, Math.Sqrt(standardDeviationSquareSum / values.Length)) };
        }

        readonly string[] dataMembers = new string[] { "Product", "Company", "Month" };

        SeriesTemplateSummaryAdapter SummaryDataAdapter { get { return (SeriesTemplateSummaryAdapter)chart.SeriesTemplate.DataAdapter; } }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public UsingSeriesTemplatesDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            SummaryDataAdapter.QualitativeSummaryOptions.SummaryFunction = string.Format("SUM([{0}])", comboBoxEditValueDataMember.Text);
            List<SaleItem> data = SaleItem.GetProductsByMonths();
            ChartControl.DataSource = data;
            gridControl.DataSource = data;
            gridControl.ForceInitialize();
            gridView.BestFitColumns();
            SummaryFunctionArgumentDescription argumentDescription = new SummaryFunctionArgumentDescription("Month", ScaleType.Numerical);
            ChartControl.RegisterSummaryFunction("STDDEV", "STDDEV", 1, new SummaryFunctionArgumentDescription[] { argumentDescription }, CalcStdDev);
            ChartControl.EndInit();
        }

        void comboBoxEditSeriesDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditSeriesDataMember.SelectedIndex == -1)
                return;
            string seriesDataMember = comboBoxEditSeriesDataMember.Text;
            SummaryDataAdapter.DataMembers[ChartDataMemberType.Series] = seriesDataMember;
            bool needUpdateSelectedItem = seriesDataMember == comboBoxEditArgumentDataMember.Text;
            comboBoxEditArgumentDataMember.Properties.Items.Clear();
            foreach(string member in dataMembers)
                if(member != seriesDataMember)
                    comboBoxEditArgumentDataMember.Properties.Items.Add(member);
            if(needUpdateSelectedItem)
                comboBoxEditArgumentDataMember.SelectedIndex = 0;
            chart.Legend.Title.Text = seriesDataMember;
        }
        void comboBoxEditArgumentDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            SummaryDataAdapter.DataMembers[ChartDataMemberType.Argument] = comboBoxEditArgumentDataMember.Text;
        }
        void comboBoxEditValueDataMember_SelectedIndexChanged(object sender, EventArgs e) {
            SummaryDataAdapter.DataMembers[ChartDataMemberType.Value] = comboBoxEditValueDataMember.Text;
            comboBoxEditSummaryFunction.SelectedIndex = 0;
            SummaryDataAdapter.QualitativeSummaryOptions.SummaryFunction = string.Format("SUM([{0}])", comboBoxEditValueDataMember.Text);
        }
        void comboBoxEditSummaryFunction_SelectedIndexChanged(object sender, EventArgs e) {
            string functionName = (string)comboBoxEditSummaryFunction.EditValue;
            int suffixIndex = functionName.IndexOf(" (Custom)");
            if(suffixIndex >= 0)
                functionName = functionName.Substring(0, suffixIndex);
            bool isSTDDEVFunction = false;
            switch(functionName) {
                case "SUM":
                    SetTitleText("Sales Volume");
                    SetAxisYTitle("Volume (USD)");
                    break;
                case "MIN":
                    SetTitleText("Minimal Order Amount");
                    SetAxisYTitle("Amount (USD)");
                    break;
                case "MAX":
                    SetTitleText("Maximal Order Amount");
                    SetAxisYTitle("Amount (USD)");
                    break;
                case "AVERAGE":
                    SetTitleText("Average Order Amount");
                    SetAxisYTitle("Amount (USD)");
                    break;
                case "STDDEV":
                    SetTitleText("Standard Deviation from Average Order Amount");
                    SetAxisYTitle("Deviation (USD)");
                    isSTDDEVFunction = true;
                    break;
            }
            SummaryDataAdapter.QualitativeSummaryOptions.SummaryFunction = string.Format("{0}([{1}])", functionName, comboBoxEditValueDataMember.Text);
            chart.SeriesTemplate.CrosshairLabelPattern = isSTDDEVFunction ? "{S:yyyy-MM-dd}: {V:F2}" : "{S:yyyy-MM-dd}: {V:#.##}";
            ChartControl.Animate();
        }
        void chart_BoundDataChanged(object sender, EventArgs e) {
            if(comboBoxEditSeriesDataMember.SelectedIndex == 2) {
                foreach(Series series in chart.Series) {
                    DateTime dt;
                    if(DateTime.TryParse(series.Name, out dt))
                        series.Name = dt.ToString("yyyy-MM-dd");
                }
            }
        }
        void gridView_SelectionChanged(object sender, Data.SelectionChangedEventArgs e) {
            object[] selectedObjects = gridView.GetSelectedRows().Select(row => gridView.GetRow(row)).ToArray();
            chart.ReplaceSelectedItems(selectedObjects);
        }
        void SetTitleText(string text) {
            if(chart.Titles.Count > 0)
                chart.Titles[0].Text = text;
        }
        void SetAxisYTitle(string text) {
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if(diagram != null)
                diagram.AxisY.Title.Text = text;
        }
    }
}
