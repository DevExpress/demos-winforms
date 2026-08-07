using System;
using System.Data;
using System.Drawing;
using System.Globalization;
using DevExpress.DXperience.Demos;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos {
    public partial class SegmentColorizerDemo : ChartDemoModuleWithOptions {
        const string FahrenheitPattern = "{V:F1}°F";
        const string CelsiusPattern = "{V:F1}°C";
        readonly double[] celsiusRangeStops = new double[] { -40, -35, -30, -25, -20, -15, -10, -5, 0, 5, 10, 15, 20, 25, 30 };
        readonly double[] fahrenheitRangeStops = new double[] { -40, -31, -22, -13, -4, 5, 14, 23, 32, 41, 50, 59, 68, 77, 86 };

        double[] ActualRangeStops { get { return radioGroupTemperatureUnit.SelectedIndex == 0 ? fahrenheitRangeStops : celsiusRangeStops; } }
        KeyColorColorizer KeyColorColorizer { get { return (KeyColorColorizer)View.Colorizer; } }
        Series Series { get { return chart.Series[0]; } }
        LineSeriesView View { get { return (LineSeriesView)Series.View; } }
        internal override bool PaletteButtonEnabled { get { return false; } }
        internal override bool ChartDesignerEnabled { get { return false; } }
        internal override ChartControl ChartControl { get { return chart; } }

        public SegmentColorizerDemo() {
            InitializeComponent();
            InitializeControls();
            UpdateSegmentColorizer();
            KeyColorColorizer.KeyProvider = new MonthKeyProvider();
            chart.DataSource = PrepareData(Utils.LoadDataTableFromXml("CityWeather.xml", "CityWeather"));
        }

        SegmentColorizerBase CreateRangeColorizer() {
            Palette palette = new Palette("TemperaturePalette", new PaletteEntry[] { new PaletteEntry(Color.DarkBlue), new PaletteEntry(Color.SteelBlue),
                                                                    new PaletteEntry(Color.LightBlue), new PaletteEntry(Color.Yellow), new PaletteEntry(Color.OrangeRed) });
            RangeSegmentColorizer colorizer = new RangeSegmentColorizer() { LegendItemPattern = "{V1}..{V2}", Palette = palette };
            colorizer.RangeStops.AddRange(ActualRangeStops);
            return colorizer;
        }
        SegmentColorizerBase CreateTrendColorizer() {
            return new TrendSegmentColorizer() {
                RisingTrendColor = Color.Red,
                FallingTrendColor = Color.Blue,
                RisingTrendLegendText = "Temperature Rise",
                FallingTrendLegendText = "Temperature Decrease"
            };
        }
        DataTable PrepareData(DataTable table) {
            foreach(DataRow row in table.Rows) {
                DateTime date = (DateTime)row[0];
                row[0] = new DateTime(TutorialConstants.Now.Year - 1, date.Month, date.Day);
            }
            return table;
        }
        void InitializeControls() {
            radioGroupTemperatureUnit.SelectedIndex = 0;
            RadioGroupItemCollection items = radioGroupColorizerType.Properties.Items;
            items.Add(new RadioGroupItem(CreateRangeColorizer(), "Range"));
            items.Add(new RadioGroupItem(CreateTrendColorizer(), "Trend"));
            items.Add(new RadioGroupItem(new PointBasedSegmentColorizer(), "Point Based"));
            radioGroupColorizerType.SelectedIndex = 0;
            items = radioGroupChartType.Properties.Items;
            items.Add(new RadioGroupItem(ViewType.Line, "Line"));
            items.Add(new RadioGroupItem(ViewType.Spline, "Spline"));
            items.Add(new RadioGroupItem(ViewType.Area, "Area"));
            items.Add(new RadioGroupItem(ViewType.SplineArea, "Spline Area"));
            radioGroupChartType.SelectedIndex = 0;
        }
        void radioGroupChartType_SelectedIndexChanged(object sender, EventArgs e) {
            chart.Series[0].ChangeView((ViewType)radioGroupChartType.EditValue);
        }
        void radioGroupColorizerType_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateSegmentColorizer();
        }
        void UpdateSegmentColorizer() {
            SegmentColorizerBase selectedColorizer = (SegmentColorizerBase)radioGroupColorizerType.EditValue;
            View.SegmentColorizer = selectedColorizer;
            bool isPointBasedSegmentColorizer = selectedColorizer is PointBasedSegmentColorizer;
            KeyColorColorizer.ShowInLegend = isPointBasedSegmentColorizer;
            View.MarkerVisibility = Utils.CovertBoolToDefaultBoolean(isPointBasedSegmentColorizer);
            chart.Legend.MaxVerticalPercentage = isPointBasedSegmentColorizer ? 28 : 30;
            UpdateRangeStops(selectedColorizer);
        }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            ((DataSourceAdapter)Series.DataAdapter).DataMembers[ChartDataMemberType.Value] = (string)radioGroupTemperatureUnit.EditValue;
            ((XYDiagram)chart.Diagram).AxisY.Label.TextPattern = radioGroupTemperatureUnit.SelectedIndex == 0 ? FahrenheitPattern : CelsiusPattern;
            UpdateRangeStops(View.SegmentColorizer);
        }
        void UpdateRangeStops(SegmentColorizerBase colorizer) {
            RangeSegmentColorizer rangeColorizer = colorizer as RangeSegmentColorizer;
            if(rangeColorizer != null) {
                rangeColorizer.RangeStops.Clear();
                rangeColorizer.RangeStops.AddRange(ActualRangeStops);
            }
        }
    }

    public class MonthKeyProvider : IColorizerKeyProvider {
        readonly CultureInfo cultureInfo = CultureInfo.CreateSpecificCulture("en-US");
        object IColorizerKeyProvider.GetKey(object colorKey) {
            return string.Format(cultureInfo, "{0:MMMM}", colorKey);
        }
    }
}
