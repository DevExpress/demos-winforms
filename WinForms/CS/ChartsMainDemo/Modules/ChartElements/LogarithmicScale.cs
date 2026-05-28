namespace DevExpress.XtraCharts.Demos {
    public partial class LogarithmicScaleDemo : ChartDemoModule {
        readonly Series headphone1Spl90;
        readonly Series headphone1Spl100;
        readonly Series headphone2Spl90;
        readonly Series headphone2Spl100;

        internal override ChartControl ChartControl {
            get { return chart; }
        }
        internal override bool ChartDesignerEnabled {
            get { return false; }
        }

        public LogarithmicScaleDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            headphone1Spl90 = ChartControl.Series["Headphones 1 90 dB SPL"];
            headphone1Spl100 = ChartControl.Series["Headphones 1 100 dB SPL"];
            headphone2Spl90 = ChartControl.Series["Headphones 2 90 dB SPL"];
            headphone2Spl100 = ChartControl.Series["Headphones 2 100 dB SPL"];
            headphone1Spl90.SetDataMembers("Frequency", "Spl90Db");
            headphone1Spl100.SetDataMembers("Frequency", "Spl100Db");
            headphone2Spl90.SetDataMembers("Frequency", "Spl90Db");
            headphone2Spl100.SetDataMembers("Frequency", "Spl100Db");
            headphone1Spl90.FilterString = "[HeadphonesName] = 'Headphones 1'";
            headphone1Spl100.FilterString = "[HeadphonesName] = 'Headphones 1'";
            headphone2Spl90.FilterString = "[HeadphonesName] = 'Headphones 2'";
            headphone2Spl100.FilterString = "[HeadphonesName] = 'Headphones 2'";
            ChartControl.DataSource = HeadphoneComparisonDataReader.ReadDataFromFile();
            ColorizeSeries();
            ChartControl.EndInit();
        }

        void ColorizeSeries() {
            Palette palette = ChartControl.PaletteRepository[ChartControl.PaletteName];
            PaletteEntry[] paletteEntries = ChartControl.GetPaletteEntries(palette.Count + 2);
            headphone1Spl90.View.Color = paletteEntries[0].Color;
            headphone1Spl100.View.Color = paletteEntries[palette.Count].Color;
            headphone2Spl90.View.Color = paletteEntries[1].Color;
            headphone2Spl100.View.Color = paletteEntries[palette.Count + 1].Color;
        }

        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            ColorizeSeries();
        }
    }

}
