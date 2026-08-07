using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class LegendsDemo : ChartDemoModuleWithOptions {
        Legend MemoryLegend {
            get { return chart.Legends.Count > 0 ? chart.Legends[0] : null; }
        }
        Legend CpuLegend {
            get { return chart.Legends.Count > 1 ? chart.Legends[1] : null; }
        }
        Legend CustomLegend {
            get { return chart.Legends.Count > 2 ? chart.Legends[2] : null; }
        }

        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public LegendsDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            ChartControl.DataSource = new PerformanceDataSource();
            layoutControlGroupRoot.Spacing = layoutControlGroupLegendMode.Spacing = layoutControlGroupMarkerMode.Spacing = XtraLayout.Utils.Padding.Empty;
            radioGroupMarkerMode.SelectedIndex = (int)chart.Legend.MarkerMode;
            UpdateChartColors();
            ChartControl.EndInit();
        }

        List<Series> FindCpuSeries() {
            List<Series> cpuSeries = new List<Series>();
            foreach(Series series in ChartControl.Series)
                if((string)series.Tag == "CPU")
                    cpuSeries.Add(series);
            return cpuSeries;
        }
        List<Series> FindMemorySeries() {
            List<Series> cpuSeries = new List<Series>();
            foreach(Series series in ChartControl.Series)
                if((string)series.Tag == "Memory")
                    cpuSeries.Add(series);
            return cpuSeries;
        }
        void AssignLegendSeriesAndAlignment(List<Series> cpuSeries, Legend legend, LegendAlignmentHorizontal alignment) {
            chart.Legend.Visibility = DefaultBoolean.False;
            if(CustomLegend != null)
                CustomLegend.Visibility = DefaultBoolean.False;
            if(legend == null)
                return;
            legend.AlignmentHorizontal = alignment;
            foreach(Series series in cpuSeries) {
                series.Legend = legend;
                series.LegendTextPattern = string.Empty;
            }
        }
        void ResetSeparatedLegends(bool useCustomLegend) {
            List<Series> cpuSeries = FindCpuSeries();
            foreach(Series series in chart.Series) {
                series.Legend = null;
                series.LegendTextPattern = cpuSeries.Contains(series) ? "{S} CPU Usage" : "{S} Memory Utilization";
            }
            chart.Legend.Visibility = useCustomLegend ? DefaultBoolean.False : DefaultBoolean.True;
            if(CustomLegend != null)
                CustomLegend.Visibility = useCustomLegend ? DefaultBoolean.True : DefaultBoolean.False;
        }
        void UpdateChartColors() {
            List<Series> memorySeries = FindMemorySeries();
            PaletteEntry[] paletteEntries = ChartControl.GetPaletteEntries(3);
            for(int i = 0; i < memorySeries.Count; i++)
                memorySeries[i].View.Color = Color.FromArgb(135, paletteEntries[i].Color);

            if(CustomLegend == null)
                return;
            for(int i = 0; i < CustomLegend.CustomItems.Count; i++)
                CustomLegend.CustomItems[i].MarkerColor = paletteEntries[i].Color;
        }
        void radioGroupMarkerMode_SelectedIndexChanged(object sender, EventArgs e) {
            LegendMarkerMode markerMode = (LegendMarkerMode)radioGroupMarkerMode.EditValue;
            ChartControl.Legend.MarkerMode = markerMode;
            if(CpuLegend != null)
                CpuLegend.MarkerMode = markerMode;
            if(MemoryLegend != null)
                MemoryLegend.MarkerMode = markerMode;
        }
        void radioGroupLegendMode_SelectedIndexChanged(object sender, EventArgs e) {
            List<Series> cpuSeries = FindCpuSeries();
            List<Series> memorySeries = FindMemorySeries();
            LegendMode legendMode = (LegendMode)radioGroupLegendMode.EditValue;
            switch(legendMode) {
                case LegendMode.Common:
                    ResetSeparatedLegends(false);
                    break;
                case LegendMode.SeparateInsidePane:
                    AssignLegendSeriesAndAlignment(cpuSeries, CpuLegend, LegendAlignmentHorizontal.Left);
                    AssignLegendSeriesAndAlignment(memorySeries, MemoryLegend, LegendAlignmentHorizontal.Left);
                    break;
                case LegendMode.SeparateOutsidePane:
                    AssignLegendSeriesAndAlignment(cpuSeries, CpuLegend, LegendAlignmentHorizontal.RightOutside);
                    AssignLegendSeriesAndAlignment(memorySeries, MemoryLegend, LegendAlignmentHorizontal.RightOutside);
                    break;
                case LegendMode.CommonCustomItems:
                    ResetSeparatedLegends(true);
                    break;
            }
            UpdateControls(legendMode);
        }
        void UpdateControls(LegendMode legendMode) {
            bool optionEnable = !legendMode.Equals(LegendMode.CommonCustomItems);
            radioGroupCrosshairContentMode.Enabled = optionEnable;
            radioGroupMarkerMode.Enabled = optionEnable;
        }
        void radioGroupCrosshairContentMode_SelectedIndexChanged(object sender, EventArgs e) {
            CrosshairContentShowMode mode = (CrosshairContentShowMode)radioGroupCrosshairContentMode.EditValue;
            ChartControl.CrosshairOptions.ContentShowMode = mode;
        }

        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            UpdateChartColors();
        }
        protected internal override void OnChartDesignerClosed() {
            UpdateChartColors();
        }
    }

    enum LegendMode {
        Common,
        SeparateInsidePane,
        SeparateOutsidePane,
        CommonCustomItems
    }
}
