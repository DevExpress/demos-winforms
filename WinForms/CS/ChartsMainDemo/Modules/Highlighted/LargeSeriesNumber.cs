using System;
using System.Drawing;

namespace DevExpress.XtraCharts.Demos {
    public partial class LargeSeriesNumberDemo : ChartDemoModule {
        const int UngrouppedSeriesCount = 11;

        int othersSeriesIndex;

        SeriesCollection Series { get { return chart.Series; } }

        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public LargeSeriesNumberDemo() {
            InitializeComponent();
            ChartControl.DataSource = SeaIceAreaDataReader.ReadDataFromFile();
        }

        void ChartControl_LegendItemChecked(object sender, LegendItemCheckedEventArgs e) {
            Series checkedSeries = e.CheckedElement as Series;
            if(checkedSeries == null || Series.IndexOf(checkedSeries) != othersSeriesIndex)
                return;
            for(int i = 0; i < Series.Count; i++)
                if(i < othersSeriesIndex)
                    Series[i].Visible = e.NewCheckState;
        }
        void ChartControl_BoundDataChanged(object sender, EventArgs e) {
            if(Series.Count == 0)
                return;
            int seriesCount = Series.Count;
            othersSeriesIndex = seriesCount - UngrouppedSeriesCount;
            Color color = chart.GetPaletteEntries(Series.Count)[0].Color;
            for(int i = 0; i < seriesCount; i++) {
                Series series = Series[i];
                series.View.Color = ColorUtils.ColorizerSeaIceSeries(color, seriesCount - i, LookAndFeel.ActiveSkinName);
                if(i < othersSeriesIndex)
                    Series[i].ShowInLegend = false;
                else if(i == othersSeriesIndex)
                    series.LegendTextPattern = "Others";
                else if(i == Series.Count - 1) {
                    LineSeriesView view = (LineSeriesView)series.View;
                    view.LineStyle.Thickness = 5;
                    view.FirstPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint;
                    view.FirstPoint.Label.TextPattern = "{FullDate:MM/dd/yyyy}\n{V:0.000M km²}";
                    view.LastPoint.LabelDisplayMode = SidePointDisplayMode.SeriesPoint;
                    view.LastPoint.Label.TextPattern = "{FullDate:MM/dd/yyyy}\n{V:0.000M km²}";
                }
            }
        }
        void UpdateSeriesColors() {
            Color color = chart.GetPaletteEntries(Series.Count)[0].Color;
            int seriesCount = Series.Count;
            for(int i = 0; i < seriesCount; i++)
                Series[i].View.Color = ColorUtils.ColorizerSeaIceSeries(color, seriesCount - i, LookAndFeel.ActiveSkinName);
        }

        protected override void OnLookAndFeelChanged() {
            base.OnLookAndFeelChanged();
            UpdateSeriesColors();
        }
        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            UpdateSeriesColors();
        }
    }
}
