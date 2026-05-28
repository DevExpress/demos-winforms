namespace DevExpress.XtraCharts.Demos {
    public partial class ColorizerDemo : ChartDemoModule {
        internal override bool PaletteButtonEnabled {
            get { return false; }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public ColorizerDemo() {
            InitializeComponent();
            Series series = ChartControl.Series[0];
            RangeColorizer rangeColorizer = new RangeColorizer();
            rangeColorizer.RangeStops.AddRange(new double[] { 22, 30, 38, 46, 54, 64 });
            rangeColorizer.LegendItemPattern = "{V1} - {V2} HPI";
            rangeColorizer.PaletteName = "ColorizerPalette";
            series.View.Colorizer = rangeColorizer;
            ((DataSourceAdapter)series.DataAdapter).DataSource = HpiDataReader.GetData();
        }
    }
}
