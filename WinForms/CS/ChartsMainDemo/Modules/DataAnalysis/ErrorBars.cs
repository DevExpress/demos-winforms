using System;
using System.Drawing;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraCharts.Demos {
    public partial class ErrorBarsDemo : ChartDemoModuleWithOptions {
        readonly Color indicatorColor = Color.Black;

        Series Series {
            get {
                if(ChartControl.Series.Count == 0)
                    return null;
                return ChartControl.Series[0];
            }
        }
        XYDiagram2DSeriesViewBase SeriesView {
            get {
                if(Series == null)
                    return null;
                XYDiagram2DSeriesViewBase seriesView = Series.View as XYDiagram2DSeriesViewBase;
                return seriesView != null ? seriesView : null;
            }
        }
        ErrorBars ErrorBars {
            get {
                if(SeriesView == null || SeriesView.Indicators.Count == 0)
                    return null;
                ErrorBars errorBars = SeriesView.Indicators[0] as ErrorBars;
                return errorBars != null ? errorBars : null;
            }
        }
        internal override ChartControl ChartControl {
            get { return chart; }
        }

        public ErrorBarsDemo() {
            InitializeComponent();
            FillErrorBarsKindRadioGroup();
            ChartControl.BeginInit();
            FillDataSet();
            ChartControl.EndInit();
        }

        void FillErrorBarsKindRadioGroup() {
            FixedValueErrorBars fixedValuesErrorBars = new FixedValueErrorBars() {
                NegativeError = 1,
                PositiveError = 3,
                Color = indicatorColor,
                Animation = CreateAnimation()
            };
            PercentageErrorBars percentageErrorBars = new PercentageErrorBars() {
                Percent = 10,
                Color = indicatorColor,
                Animation = CreateAnimation()
            };
            StandardDeviationErrorBars stdevErrorBars = new StandardDeviationErrorBars() {
                Multiplier = 1,
                Color = indicatorColor,
                Animation = CreateAnimation()
            };
            StandardErrorBars stdErrErrorBars = new StandardErrorBars() {
                Color = indicatorColor,
                Animation = CreateAnimation()
            };
            DataSourceBasedErrorBars dataSourceErrorBars = new DataSourceBasedErrorBars() {
                NegativeErrorDataMember = "Table1.NegativeError",
                PositiveErrorDataMember = "Table1.PositiveError",
                Color = indicatorColor,
                Animation = CreateAnimation()
            };
            radioGroupErrorBarsKind.Properties.Items.Add(new RadioGroupItem(fixedValuesErrorBars, "Fixed Values"));
            radioGroupErrorBarsKind.Properties.Items.Add(new RadioGroupItem(percentageErrorBars, "Percentage"));
            radioGroupErrorBarsKind.Properties.Items.Add(new RadioGroupItem(stdevErrorBars, "Standard Deviation(s)"));
            radioGroupErrorBarsKind.Properties.Items.Add(new RadioGroupItem(stdErrErrorBars, "Standard Error"));
            radioGroupErrorBarsKind.Properties.Items.Add(new RadioGroupItem(dataSourceErrorBars, "Data Source"));
            radioGroupErrorBarsKind.SelectedIndex = 0;
        }
        void FillDataSet() {
            System.Data.DataTable table = dataSet.Tables[0];
            table.Rows.Add("A", 20, 5, 8);
            table.Rows.Add("B", 50, 3, 5);
            table.Rows.Add("C", 40, 20, 10);
            table.Rows.Add("D", 22, 15, 5);
            table.Rows.Add("E", 30, 5, 8);
            table.Rows.Add("F", 45, 5, 4);
            table.Rows.Add("G", 35, 5, 3);
            table.Rows.Add("H", 28, 4, 2);
            table.Rows.Add("I", 46, 6, 4);
            table.Rows.Add("J", 27, 8, 20);
            table.Rows.Add("K", 20, 5, 8);
            table.Rows.Add("L", 50, 3, 5);
            table.Rows.Add("M", 40, 20, 10);
            table.Rows.Add("N", 22, 15, 5);
            table.Rows.Add("O", 30, 5, 8);
            table.Rows.Add("P", 45, 5, 2);
            table.Rows.Add("Q", 35, 5, 5);
            table.Rows.Add("R", 28, 4, 4);
            table.Rows.Add("S", 46, 6, 5);
            table.Rows.Add("T", 27, 8, 8);
        }
        void SetDirection() {
            if(ErrorBars == null)
                return;
            ErrorBars.Direction = (ErrorBarDirection)radioGroupDirection.EditValue;
        }
        void SetEndStyle() {
            if(ErrorBars == null)
                return;
            ErrorBars.EndStyle = (ErrorBarEndStyle)radioGroupEndStyle.EditValue;

        }
        IndicatorSlideAnimation CreateAnimation() {
            return new IndicatorSlideAnimation() {
                Duration = new TimeSpan(0, 0, 2),
                Direction = AnimationDirection.FromBottom,
                EasingFunction = new ElasticEasingFunction() {
                    OscillationCount = 1,
                    EasingMode = EasingMode.InOut
                }
            };
        }
        void radioGroupSeriesView_SelectedIndexChanged(object sender, EventArgs e) {
            if(Series == null)
                return;
            ChartControl.BeginInit();
            Series.ChangeView((ViewType)radioGroupSeriesView.EditValue);
            ChartControl.EndInit();
            ChartControl.Animate();
        }
        void radioGroupErrorBarsKind_SelectedIndexChanged(object sender, EventArgs e) {
            if(SeriesView == null)
                return;
            SeriesView.Indicators.Clear();
            SeriesView.Indicators.Add((Indicator)radioGroupErrorBarsKind.EditValue);
            SetDirection();
            SetEndStyle();
        }
        void radioGroupEndStyle_SelectedIndexChanged(object sender, EventArgs e) {
            SetEndStyle();
        }
        void radioGroupDirection_SelectedIndexChanged(object sender, EventArgs e) {
            SetDirection();
        }
    }
}
