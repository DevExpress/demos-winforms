using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Data.Utils;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos {
    public partial class HistogramDemo : ChartDemoModuleWithOptions {
        internal override ChartControl ChartControl {
            get {
                return chart;
            }
        }

        public HistogramDemo() {
            InitializeComponent();
            FillIntervalDivisionModeComboBox();
            FillChartTypes();
            AddData();
            ColorizeSeries();
            radioGroup1.SelectedIndex = 0;
            comboBoxEdit1.SelectedIndex = 1;
            trackBar1.Value = 5;
            trackBar2.Value = 80;
            trackBar3.Value = 3;
        }
        void AddData() {
            NonCryptographicRandom random = NonCryptographicRandom.System;
            List<SimpleDataPoint[]> points = new List<SimpleDataPoint[]>() {
                PointGenerator.GenerateCluster(random, random.Next(20, 70), random.Next(120, 180), random.Next(0, 10), random.Next(70, 120), 2000),
                PointGenerator.GenerateCluster(random, random.Next(0, 10), random.Next(70, 120), random.Next(40, 80), random.Next(160, 200), 2000),
                PointGenerator.GenerateCluster(random, random.Next(60, 100), random.Next(160, 200), random.Next(40, 80), random.Next(160, 200), 2000),
            };
            for(int i = 0; i < points.Count; i++) {
                ((DataSourceAdapter)chart.Series[i * 2].DataAdapter).DataSource = points[i];
                ((DataSourceAdapter)chart.Series[i * 2 + 1].DataAdapter).DataSource = points[i];
            }
        }
        void ColorizeSeries() {
            PaletteEntry[] paletteEntries = ChartControl.GetPaletteEntries(3);
            for(int i = 0; i < chart.Series.Count; i++)
                chart.Series[i].View.Color = Color.FromArgb(100, paletteEntries[i / 2].Color);
        }
        void FillIntervalDivisionModeComboBox() {
            comboBoxEdit1.Properties.Items.AddRange(new List<IntervalDivisionMode>() {
                IntervalDivisionMode.Auto,
                IntervalDivisionMode.Width,
                IntervalDivisionMode.Count
            });
        }
        void FillChartTypes() {
            RadioGroupItemCollection items = radioGroup1.Properties.Items;
            items.Add(new RadioGroupItem(ViewType.RangeBar, "Range Bar"));
            items.Add(new RadioGroupItem(ViewType.SplineArea, "Spline Area"));
        }
        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            ColorizeSeries();
        }
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e) {
            if(chart == null)
                return;
            IntervalDivisionMode mode = (IntervalDivisionMode)comboBoxEdit1.EditValue;
            ((XYDiagram)chart.Diagram).SecondaryAxesX[0].NumericScaleOptions.IntervalOptions.DivisionMode = mode;
            switch(mode) {
                case IntervalDivisionMode.Auto:
                    layoutControlGroup3.Enabled = false;
                    layoutControlGroup4.Enabled = false;
                    break;
                case IntervalDivisionMode.Width:
                    layoutControlGroup3.Enabled = true;
                    layoutControlGroup4.Enabled = false;
                    break;
                case IntervalDivisionMode.Count:
                    layoutControlGroup3.Enabled = false;
                    layoutControlGroup4.Enabled = true;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            ViewType newViewType = (ViewType)radioGroup1.Properties.Items[radioGroup1.SelectedIndex].Value;
            for(int i = 1; i < chart.Series.Count; i += 2) {
                Series series = chart.Series[i];
                series.ChangeView(newViewType);
                BarSeriesView rangeSeriesView = series.View as BarSeriesView;
                if(rangeSeriesView != null) {
                    rangeSeriesView.BarWidth = 1;
                    series.CrosshairLabelPattern = "{A}: {V2}";
                }
                else
                    series.CrosshairLabelPattern = "{A}: {V}";
            }
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e) {
            double width = trackBar1.Value;
            ((XYDiagram)chart.Diagram).SecondaryAxesX[0].NumericScaleOptions.IntervalOptions.Width = width;
        }
        private void trackBar2_ValueChanged(object sender, EventArgs e) {
            int count = trackBar2.Value;
            ((XYDiagram)chart.Diagram).SecondaryAxesX[0].NumericScaleOptions.IntervalOptions.Count = count;
        }
        private void trackBar3_ValueChanged(object sender, EventArgs e) {
            int count = trackBar3.Value;
            for(int i = 0; i < chart.Series.Count; i++)
                chart.Series[i].Visible = count * 2 > i;
        }
        private void simpleButton1_Click(object sender, EventArgs e) {
            AddData();
        }
    }
}
