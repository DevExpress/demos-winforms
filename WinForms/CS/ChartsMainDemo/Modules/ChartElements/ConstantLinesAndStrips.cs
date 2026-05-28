using System.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class ConstantLinesAndStripsDemo : ChartDemoModule {
        readonly ConstantLine optimalTemperatureDefaultLine;
        readonly TemperatureData temperatureData = new TemperatureData();

        internal override bool PaletteButtonEnabled {
            get { return false; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public ConstantLinesAndStripsDemo() {
            InitializeComponent();
            AutoMergeRibbon = true;
            ChartControl.BeginInit();
            Series series = new Series("Surface Temperature", ViewType.Spline);
            series.BindToData(temperatureData.Data, "TimeStamp", "Temperature");
            SplineSeriesView splineView = (SplineSeriesView)series.View;
            splineView.Color = Color.FromArgb(255, 147, 8, 255);
            splineView.LineMarkerOptions.Size = 1;
            series.CheckableInLegend = false;
            series.CrosshairLabelPattern = "{V:0.##}°C";
            ChartControl.Series.Add(series);
            ChartControl.PaletteBaseColorNumber = 5;
            ChartControl.BorderOptions.Visibility = DefaultBoolean.False;
            ChartControl.Legend.Border.Visibility = DefaultBoolean.False;
            ChartControl.Legend.BackColor = Color.Transparent;
            ChartControl.ConstantLineMoved += ChartControl_ConstantLineMoved;

            XYDiagram diagram = new XYDiagram();
            ChartControl.Diagram = diagram;
            diagram.EnableAxisXScrolling = true;
            diagram.EnableAxisXZooming = true;
            diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Second;
            diagram.AxisX.WholeRange.AutoSideMargins = false;
            diagram.AxisX.WholeRange.SideMarginsValue = 0;
            diagram.ZoomingOptions.AxisXMaxZoomPercent = 200;
            diagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            diagram.AxisY.Interlaced = false;

            double edge1 = temperatureData.OptimalTemperature + 30;
            double edge2 = temperatureData.MaxTemperaturePoint.Temperature;
            Strip extremelyHighTemperatureStrip = new Strip("Extremely High Temperature", edge1, edge2) {
                Color = Color.FromArgb(150, 209, 99, 73),
            };
            diagram.AxisY.Strips.Add(extremelyHighTemperatureStrip);

            edge1 = temperatureData.OptimalTemperature + 10;
            edge2 = temperatureData.OptimalTemperature + 30;
            Strip highTemperatureStrip = new Strip("High Temperature", edge1, edge2) {
                Color = Color.FromArgb(150, 209, 144, 73),
            };
            diagram.AxisY.Strips.Add(highTemperatureStrip);

            edge1 = temperatureData.OptimalTemperature - 10;
            edge2 = temperatureData.OptimalTemperature + 10;
            Strip normalTemperatureStrip = new Strip("Normal Temperature", edge1, edge2) {
                Color = Color.FromArgb(150, 143, 176, 140),
            };
            diagram.AxisY.Strips.Add(normalTemperatureStrip);

            edge2 = temperatureData.OptimalTemperature - 10;
            edge1 = temperatureData.MinTemperaturePoint.Temperature;
            Strip lowTemperatureStrip = new Strip("Low Temperature", edge1, edge2) {
                Color = Color.FromArgb(150, 140, 173, 174),
            };
            diagram.AxisY.Strips.Add(lowTemperatureStrip);

            optimalTemperatureDefaultLine = new ConstantLine("Optimal Temperature", temperatureData.OptimalTemperature);
            optimalTemperatureDefaultLine.ShowBehind = true;
            optimalTemperatureDefaultLine.RuntimeMoving = true;
            optimalTemperatureDefaultLine.Title.Alignment = ConstantLineTitleAlignment.Far;
            diagram.AxisY.ConstantLines.Add(optimalTemperatureDefaultLine);

            ChartControl.Legend.MarkerMode = LegendMarkerMode.CheckBoxAndMarker;
            ChartControl.CrosshairOptions.ShowArgumentLabels = true;
            ChartTitle title = new ChartTitle() {
                Text = "Operating Surface Temperature"
            };
            ChartControl.Titles.Add(title);
            ChartControl.AnimationStartMode = ChartAnimationMode.OnLoad;
            ChartControl.EndInit();
        }

        void ChartControl_ConstantLineMoved(object sender, ConstantLineMovedEventArgs e) {
            if(e.ConstantLine != optimalTemperatureDefaultLine)
                return;
            if((double)e.ConstantLine.AxisValue > temperatureData.OptimalTemperature + 10)
                e.ConstantLine.AxisValue = temperatureData.OptimalTemperature + 10;
            if((double)e.ConstantLine.AxisValue < temperatureData.OptimalTemperature - 10)
                e.ConstantLine.AxisValue = temperatureData.OptimalTemperature - 10;
        }
    }
}
