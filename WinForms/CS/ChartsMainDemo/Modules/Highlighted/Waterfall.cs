using System;
using System.Drawing;
using DevExpress.Data.Filtering;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class WaterfallDemo : ChartDemoModuleWithOptions {
        WaterfallSeriesView WaterfallView { get { return chart.SeriesTemplate.View as WaterfallSeriesView; } }

        internal override bool PaletteButtonEnabled { get { return false; } }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public WaterfallDemo() {
            InitializeComponent();
            SetupCalculatedFields();
            ChartControl.DataSource = CsvReader.ReadCarbonData("carbon.csv");
            radioGroupDataView.SelectedIndex = 0;
        }

        void SetupCalculatedFields() {
            ChartControl.CalculatedFields.Add(new ChartCalculatedField() {
                DisplayName = "Calculated Contribution",
                Expression = "IIF([Factor] == \'Fuel/Industry\' Or [Factor] == \'Land-Use Emissions\' Or [Factor] == \'Imbalance\', [Contribution], -1 * [Contribution])",
                FieldType = ChartCalculatedFieldType.Double,
                Name = "CalculatedContribution"
            });
        }

        void SetupSeries(BinaryOperatorType binaryOperatorType, DefaultBoolean legendVisibility, Color risingColor, Color fallingColor) {
            ((SeriesTemplateAdapter)ChartControl.SeriesTemplate.DataAdapter).FilterCriteria = new BinaryOperator("Factor", "Imbalance", binaryOperatorType);
            if(WaterfallView != null) {
                WaterfallView.RisingBarColor = risingColor;
                WaterfallView.FallingBarColor = fallingColor;
            }
            ChartControl.Legend.Visibility = legendVisibility;
        }
        void RadioGroupTemperatureUnit_SelectedIndexChanged(object sender, EventArgs e) {
            if(radioGroupDataView.SelectedIndex == 0)
                SetupSeries(BinaryOperatorType.Equal, DefaultBoolean.False, Color.FromArgb(218, 88, 89), Color.FromArgb(146, 206, 181));
            else
                SetupSeries(BinaryOperatorType.NotEqual, DefaultBoolean.True, Color.Empty, Color.Empty);
        }
    }
}
