using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.Utils;
using System.Drawing;
using DevExpress.XtraEditors;

namespace DevExpress.SalesDemo.Win.Modules {
    public enum SalesPerformanceMode { Day, Month }
    public enum SalesPerformanceChartType { Area, Bar }

    public partial class ucSalesPerformance : DevExpress.XtraEditors.XtraUserControl {
        ISalesPerformanceProvider provider;
        DateTime currentDate;

        Series Series { get { return chart.Series[0]; } }
        TextAnnotation Annotation { get { return (TextAnnotation)chart.Annotations[0]; } }
        XYDiagram Diagram { get { return ((XYDiagram)chart.Diagram); } }
        Palette ChartPalette { get { return chart.PaletteRepository[chart.PaletteName]; } }

        public ucSalesPerformance() {
            InitializeComponent();
            LoadResources();
            Palette palette = ChartUtils.GeneratePalette();
            chart.PaletteRepository.Add(palette.Name, palette);
            chart.PaletteName = palette.Name;
            chart.CustomDrawAxisLabel += ChartUtils.CustomDrawAxisYLabel;
            chart.CustomDrawSeriesPoint += ChartUtils.CustomDrawBarSeriesPoint;
        }

        public void SetSalesPerformanceProvider(ISalesPerformanceProvider provider) {
            this.provider = provider;
            Series.ArgumentDataMember = provider.ChartArgumentDataMember;
            Series.ValueDataMembers.AddRange(provider.ChartValueDataMember);
            switch (provider.ChartType) {
                case SalesPerformanceChartType.Area:
                    Series.ChangeView(ViewType.Area);
                    Diagram.AxisX.WholeRange.AutoSideMargins = false;
                    ((AreaSeriesView)Series.View).Border.Visibility = DefaultBoolean.False;
                    ((AreaSeriesView)Series.View).Transparency = 64;
                    break;
                case SalesPerformanceChartType.Bar:
                    Series.ChangeView(ViewType.Bar);
                    BarSeriesView view = ((BarSeriesView)Series.View);
                    BarSeriesLabel label = ((BarSeriesLabel)Series.Label);
                    view.ColorEach = true;
                    view.Transparency = 0;
                    view.Border.Visibility = DefaultBoolean.False;
                    label.Position = BarSeriesLabelPosition.TopInside;
                    label.Border.Visibility = DefaultBoolean.False;
                    label.FillStyle.FillMode = FillMode.Empty;
                    label.TextColor = Color.White;
                    label.Indent = 6;
                    label.EnableAntialiasing = Utils.DefaultBoolean.True;
                    Diagram.AxisX.WholeRange.AutoSideMargins = true;
                    Series.LabelsVisibility = DefaultBoolean.True;
                    break;
                default:
                    break;
            }
            switch (provider.Mode) {
                case SalesPerformanceMode.Day:
                    SetDayMode();
                    break;
                case SalesPerformanceMode.Month:
                    SetMonthMode();
                    break;
            }
            currentDate = DateTime.Today;
            UpdateSalesValues();
            UpdateChart(currentDate);
            UpdateNavigationButtons(true, true);
        }

        void LoadResources() {
            btnBack.Image = LoadImage("ArrowLeft.png");
            btnForward.Image = LoadImage("ArrowRight.png");
        }
        static System.Drawing.Image LoadImage(string imageName) {
            return Utils.ResourceImageHelper.CreateImageFromResources(Model.ModelAssemblyHelper.GetResourcePath(imageName), Model.ModelAssemblyHelper.ModelAssembly);
        }
        void UpdateNavigationButtons(bool updateCurrentButton, bool updatePreviousButton) {
            DateTime prevDate = DateTime.Today;
            switch (provider.Mode) {
                case SalesPerformanceMode.Day:
                    prevDate = DateTime.Today.AddDays(-1);
                    break;
                case SalesPerformanceMode.Month:
                    prevDate = DateTime.Today.AddMonths(-1);
                    break;
                default:
                    break;
            }
            bool isPreviousDate = (prevDate == currentDate);
            bool isCurentDate = (currentDate == DateTime.Today);
            btnForward.Enabled = !isCurentDate;
            if (updateCurrentButton)
                btnCurrentDate.Checked = isCurentDate;
            if (updatePreviousButton)
                btnPreviousDate.Checked = isPreviousDate;
        }
        void SetDayMode() {
            valuePresenter0.TitleText = "TODAY";
            valuePresenter1.TitleText = "YESTERDAY";
            valuePresenter2.TitleText = "LAST WEEK";
            btnCurrentDate.Text = "Today";
            btnPreviousDate.Text = "Yesterday";
            SetPaletteColorNumber(1);
            Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour;
            Diagram.AxisX.Label.TextPattern = "{A:t}";
            Diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum;
        }
        void SetMonthMode() {
            valuePresenter0.TitleText = "THIS MONTH";
            valuePresenter1.TitleText = "LAST MONTH";
            valuePresenter2.TitleText = "YTD";
            btnCurrentDate.Text = "This Month";
            btnPreviousDate.Text = "Last Month";
            SetPaletteColorNumber(4);
            Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Day;
            Diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Day;
            Diagram.AxisX.DateTimeScaleOptions.GridSpacing = 5;
            Diagram.AxisX.Label.TextPattern = "{A:M/d}";
            Diagram.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum;
        }
        void SetPaletteColorNumber(int baseColorNumber) {
            if (provider.ChartType == SalesPerformanceChartType.Area)
                chart.PaletteBaseColorNumber = baseColorNumber;
            if (baseColorNumber > 0) {
                int index = baseColorNumber - 1;
                valuePresenter0.ValueTextColor = ChartPalette[index].Color;
                valuePresenter1.ValueTextColor = ChartPalette[index].Color;
                valuePresenter2.ValueTextColor = ChartPalette[index].Color;
            }
        }
        void UpdateSalesValues() {
            valuePresenter0.ValueFormat = provider.SalesValuesFormat;
            valuePresenter1.ValueFormat = provider.SalesValuesFormat;
            valuePresenter2.ValueFormat = provider.SalesValuesFormat;
            valuePresenter0.Value = provider.SalesValueFirst;
            valuePresenter1.Value = provider.SalesValueSecond;
            valuePresenter2.Value = provider.SalesValueThird;
        }
        void UpdateChart(DateTime date) {
            Series.DataSource = provider.GetChartData(date);
            switch (provider.Mode) {
                case SalesPerformanceMode.Day:
                    Annotation.Text = date.ToString("d");
                    break;
                case SalesPerformanceMode.Month:
                    Annotation.Text = date.ToString("M/yyyy");
                    break;
            }
            if (Series.ActualArgumentScaleType == ScaleType.Qualitative)
                Diagram.AxisX.Label.TextPattern = "{A}";
        }
        DateTime ChangeDate(DateTime date, int dateDelta) {
            DateTime resultDate = date;
            if (dateDelta != 0) {
                switch (provider.Mode) {
                    case SalesPerformanceMode.Day:
                        resultDate = date.AddDays(dateDelta);
                        break;
                    case SalesPerformanceMode.Month:
                        resultDate = date.AddMonths(dateDelta);
                        break;
                }
            }
            if (resultDate > DateTime.Today)
                resultDate = DateTime.Today;
            return resultDate;
        }
        void ChangeDateAndUpdate(DateTime date, int dateDelta, bool updateCurrentButton, bool updatePreviousButton) {
            currentDate = ChangeDate(date, dateDelta);
            UpdateChart(currentDate);
            UpdateNavigationButtons(updateCurrentButton, updatePreviousButton);
        }

        void btnBackClick(object sender, EventArgs e) {
            ChangeDateAndUpdate(currentDate, -1, true, true);
        }
        void btnForwardClick(object sender, EventArgs e) {
            ChangeDateAndUpdate(currentDate, 1, true, true);
        }
        void btnPreviousDateClick(object sender, EventArgs e) {
            ChangeDateAndUpdate(DateTime.Today, -1, true, false);
        }
        void btnCurrentDateClick(object sender, EventArgs e) {
            ChangeDateAndUpdate(DateTime.Today, 0, false, true);
        }
    }

    public interface ISalesPerformanceProvider {
        SalesPerformanceMode Mode { get; }
        SalesPerformanceChartType ChartType { get; }
        string ChartArgumentDataMember { get; }
        string ChartValueDataMember { get; }
        object GetChartData(DateTime date);
        string SalesValuesFormat { get; }
        double SalesValueFirst { get; }
        double SalesValueSecond { get; }
        double SalesValueThird { get; }
    }
}
