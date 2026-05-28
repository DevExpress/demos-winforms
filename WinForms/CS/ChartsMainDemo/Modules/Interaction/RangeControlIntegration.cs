using System;

namespace DevExpress.XtraCharts.Demos {
    public partial class RangeControlIntegrationDemo : ChartDemoModule {
        XYDiagram Diagram {
            get { return chart.Diagram as XYDiagram; }
        }
        AxisBase AxisX {
            get { return Diagram != null ? Diagram.AxisX : null; }
        }
        Series SeriesGbpUsd {
            get { return chart.Series["GBPUSD"]; }
        }
        Series SeriesEurUsd {
            get { return chart.Series["EURUSD"]; }
        }

        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public RangeControlIntegrationDemo() {
            InitializeComponent();
            ChartControl.BeginInit();
            SeriesGbpUsd.DataSource = CsvReader.ReadFinancialData("GBPUSDDaily.csv");
            SeriesEurUsd.DataSource = CsvReader.ReadFinancialData("EURUSDDaily.csv");
            ChartControl.EndInit();
            TimeSpan offset = new TimeSpan(366 * 2, 0, 0, 0);
            AxisX.VisualRange.SetMinMaxValues((DateTime)AxisX.VisualRange.MaxValue - offset, (DateTime)AxisX.VisualRange.MaxValue);
        }

        void chart_CustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            int elementIndex = 0;
            foreach(CrosshairElementGroup crosshairGroup in e.CrosshairElementGroups) {
                foreach(CrosshairElement crosshairElement in crosshairGroup.CrosshairElements) {
                    CrosshairLabelElement labelElement = crosshairElement.LabelElement;
                    labelElement.MarkerSize = new System.Drawing.Size(0, 0);
                    labelElement.MarkerVisible = false;
                    labelElement.TextColor = chart.PaletteRepository[chart.PaletteName][elementIndex].Color;
                    elementIndex++;
                }
            }
        }
    }
}
