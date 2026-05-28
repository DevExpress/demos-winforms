using System;
using System.Drawing;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos {
    public partial class EmptyPointsDemo : ChartDemoModuleWithOptions {
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public EmptyPointsDemo() {
            InitializeComponent();
            chart.DataSource = WeatherInWashington.Data;
            PaletteName = Palettes.BlueGreen.Name;
            InitRadioGroup();
            UpdateEmptyPointOptions();
        }

        void InitRadioGroup() {
            radioGroupSeriesView.Properties.Items.AddRange(new RadioGroupItem[] {
                new RadioGroupItem(new ViewType[] { ViewType.Point, ViewType.StepLine, ViewType.Area }, "Point, Step Line and Area"),
                new RadioGroupItem(new ViewType[] { ViewType.Line, ViewType.Bar, ViewType.RangeBar }, "Line, Bar and Range Bar"),
                new RadioGroupItem(new ViewType[] { ViewType.Spline, ViewType.StepArea, ViewType.RangeArea }, "Spline, Step Area and Range Area")
            });
            radioGroupSeriesView.SelectedIndex = 0;
        }
        void radioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            ViewType[] viewTypes = (ViewType[])radioGroupSeriesView.EditValue;
            if(viewTypes == null || viewTypes.Length != chart.Series.Count)
                return;
            for(int i = 0; i < chart.Series.Count; i++) {
                Series series = chart.Series[i];
                ViewType viewType = viewTypes[i];
                series.ChangeView(viewType);
                if(i == chart.Series.Count - 1) {
                    if(viewType == ViewType.RangeArea || viewType == ViewType.RangeBar) {
                        series.ValueDataMembers.Clear();
                        series.ValueDataMembers.AddRange("DayTemperature", "NightTemperature");
                        series.CrosshairLabelPattern = "{S}: Day {V1}°C, Night {V2}°C";
                    }
                    else
                        series.CrosshairLabelPattern = "{S}: {V}°C";
                }
            }
            UpdateEmptyPointOptions();
            ChartControl.Animate();
        }
        void checkEdit1_CheckedChanged(object sender, EventArgs e) {
            UpdateEmptyPointOptions();
        }
        void UpdateEmptyPointOptions() {
            bool styleEnabled = checkEdit1.Checked;
            Palette palette = chart.PaletteRepository[chart.PaletteName];
            for(int i = 0; i < chart.Series.Count; i++) {
                PaletteEntry paletteEntry = palette[i];
                Series series = chart.Series[i];
                XYDiagramSeriesViewBase view = (XYDiagramSeriesViewBase)series.View;
                EmptyPointOptions emptyPointOptions = view.EmptyPointOptions;
                emptyPointOptions.ProcessPoints = ProcessEmptyPointsMode.Interpolate;
                if(styleEnabled) {
                    emptyPointOptions.Color = Color.FromArgb(100, paletteEntry.Color);
                    if(emptyPointOptions is LineEmptyPointOptions) {
                        LineEmptyPointOptions lineOptions = (LineEmptyPointOptions)emptyPointOptions;
                        lineOptions.LineStyle.DashStyle = DashStyle.Dash;
                        lineOptions.LineStyle.Thickness = ((LineSeriesView)view).LineStyle.Thickness;
                    }
                    else if(emptyPointOptions is AreaEmptyPointOptions) {
                        AreaEmptyPointOptions areaOptions = (AreaEmptyPointOptions)emptyPointOptions;
                        areaOptions.Border.Color = paletteEntry.Color;
                    }
                }
                else
                    emptyPointOptions.Color = Color.Empty;
            }
        }
    }
}
