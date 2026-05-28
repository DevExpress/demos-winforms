using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.SalesDemo.Model;
using DevExpress.Sparkline;
using DevExpress.Utils.Drawing;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucSalesByRange : UserControl {
        DateTime currentDate;
        ISalesByRangeProvider provider;

        RangeControlSalesClient rangeControlSalesClient;

        Palette Palette { get { return pieChart.PaletteRepository[pieChart.PaletteName]; } }
        Series PieSeries { get { return pieChart.Series[0]; } }
        Series BarSeries { get { return barChart.Series[0]; } }

        public ucSalesByRange() {
            InitializeComponent();

            Palette chartPalette = ChartUtils.GeneratePalette();
            pieChart.PaletteRepository.Add(chartPalette.Name, chartPalette);
            pieChart.PaletteName = chartPalette.Name;
            pieChart.CustomDrawSeriesPoint += ChartUtils.CustomDrawSeriesPointLegendMarker;

            barChart.PaletteRepository.Add(chartPalette.Name, chartPalette);
            barChart.PaletteName = chartPalette.Name;
            barChart.CustomDrawAxisLabel += ChartUtils.CustomDrawAxisLabel;

            rangeControlSalesClient = new RangeControlSalesClient(Palette[3].Color);
        }


        public void SetSalesByRangeProvider(ISalesByRangeProvider provider) {
            this.provider = provider;
            currentDate = TutorialConstants.Today;

            rangeControl.Client = rangeControlSalesClient;
            rangeControl.RangeChanged += RangeControlRangeChanged;

            UpdateRangeControl(currentDate);
        }
        void RangeControlRangeChanged(object sender, RangeControlRangeEventArgs range) {
            DateTime start = new DateTime(currentDate.Year, currentDate.Month, (int)range.Range.Minimum + 1);
            DateTime end = new DateTime(currentDate.Year, currentDate.Month, (int)range.Range.Maximum + 1);
            IEnumerable<SalesGroup> productSales = provider.GetSalesDataForItemForPeriod(start, end);
            UpdateCharts(productSales);
            UpdateNextButton();
        }

        void UpdateCharts(IEnumerable<SalesGroup> productSales) {
            PieSeries.DataSource = productSales;
            BarSeries.DataSource = productSales;
        }

        void UpdateNextButton() {
            btnNext.Enabled = (currentDate < TutorialConstants.Today);
        }
        void UpdateRangeControl(DateTime dateTime) {
            DateTime start = new DateTime(dateTime.Year, dateTime.Month, 1);
            DateTime end = new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
            IEnumerable<SalesGroup> sales = provider.GetSalesDataForAllItemsForPeriod(start, end);
            rangeControlSalesClient.UpdateData(sales);
        }

        void btnPrev_Click(object sender, EventArgs e) {
            currentDate = currentDate.AddMonths(-1);
            UpdateRangeControl(currentDate);
            UpdateNextButton();
        }
        void btnNext_Click(object sender, EventArgs e) {
            currentDate = currentDate.AddMonths(1);
            if(currentDate > TutorialConstants.Today)
                currentDate = TutorialConstants.Today;
            UpdateRangeControl(currentDate);
            UpdateNextButton();
        }
    }

    public class RangeControlSalesClient : IRangeControlClient {
        const int rulerDeltaConst = 1;
        SparklineEdit currentSparkline;
        SalesGroup[] data;
        Color chartColor;
        int ItemsCount { get { return data.Length - 1; } }
        SalesGroup[] rulerValues = new SalesGroup[0];

        public RangeControlSalesClient(Color chartColor) {
            this.chartColor = chartColor;
            currentSparkline = CreateSparkline(chartColor);
        }
        public bool YearMonth = false;

        public void UpdateData(IEnumerable<SalesGroup> data) {
            this.data = data.ToArray();
            GenerateRuler();
            currentSparkline.Dispose();
            currentSparkline = CreateSparkline(chartColor);
            currentSparkline.Data = CreateSparklineData(data);
            RaiseRangeChanged();
        }

        void GenerateRuler() {
            if(YearMonth) GenerateYearMonthRuler();
            else GenerateRegularRuler();
        }

        void GenerateRegularRuler() {
            int count = ItemsCount / 3;
            this.rulerValues = new SalesGroup[count];
            for(int n = 0; n < count; n++) {
                int i = n * 3;
                if(i < data.Length)
                    rulerValues[n] = data[i];
            }
        }

        void GenerateYearMonthRuler() {
            Hashtable months = new Hashtable();
            foreach(SalesGroup sg in data) {
                DateTime dt = new DateTime(sg.StartOfPeriod.Year, sg.StartOfPeriod.Month, 1);
                if(months.Contains(dt)) continue;
                months[dt] = sg;
            }
            this.rulerValues = new SalesGroup[months.Count];
            int i = 0;
            foreach(DateTime dt in months.Keys.Cast<DateTime>().OrderBy(a => a)) {
                rulerValues[i++] = (SalesGroup)months[dt];
            }
        }

        SparklineEdit CreateSparkline(Color color) {
            SparklineEdit sparkline = new SparklineEdit();
            sparkline.Properties.View.Color = color;
            sparkline.BorderStyle = BorderStyles.NoBorder;
            return sparkline;
        }

        double[] CreateSparklineData(IEnumerable<SalesGroup> data) {
            double[] sparklineData = new double[data.Count()];
            int index = 0;
            foreach(SalesGroup sale in data)
                sparklineData[index++] = (double)sale.TotalCost;
            return sparklineData;
        }

        protected EventHandlerList Events = new EventHandlerList();
        static readonly object _rangeChanged = new object();
        protected void RaiseRangeChanged() {
            ClientRangeChangedEventHandler handler = Events[_rangeChanged] as ClientRangeChangedEventHandler;
            if(handler != null) handler(this, CreateRangeChangedArgs());
        }
        RangeControlClientRangeEventArgs CreateRangeChangedArgs() {
            RangeControlClientRangeEventArgs e = new RangeControlClientRangeEventArgs();
            e.Range = new RangeControlRange(0, data.Length - 1);
            e.InvalidateContent = true;
            return e;
        }
        #region IRangeControlClient Members
        protected virtual void DrawGraph(IGraphicsCache cache, Rectangle contentBounds) {
            contentBounds.Inflate(1, 1);
            currentSparkline.Size = contentBounds.Size;
            currentSparkline.Properties.View = new AreaSparklineView();
            using(Bitmap bitmap = new Bitmap(currentSparkline.Size.Width, currentSparkline.Size.Height)) {
                currentSparkline.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                cache.DrawImage(bitmap, contentBounds);
            }
        }

        bool IRangeControlClient.IsValid { get { return true; } }
        string IRangeControlClient.InvalidText { get { return "invalid"; } }
        object IRangeControlClient.GetOptions() { return this; }
        object IRangeControlClient.RulerDelta { get { return rulerDeltaConst; } }
        double IRangeControlClient.NormalizedRulerDelta { get { return (double)rulerDeltaConst / rulerValues.Length; } } // ItemsCount; } }
        int IRangeControlClient.RangeBoxTopIndent { get { return 0; } }
        int IRangeControlClient.RangeBoxBottomIndent { get { return 0; } }
        bool IRangeControlClient.IsCustomRuler { get { return false; } }

        bool IRangeControlClient.IsValidType(Type type) {
            return true;
        }
        event ClientRangeChangedEventHandler IRangeControlClient.RangeChanged {
            add { Events.AddHandler(_rangeChanged, value); }
            remove { Events.RemoveHandler(_rangeChanged, value); }
        }
        bool IRangeControlClient.SupportOrientation(RangeControlClientOrientation orientation) {
            return (orientation != RangeControlClientOrientation.Vertical);
        }
        bool IRangeControlClient.DrawRuler(RangeControlPaintEventArgs e) {
            return false;
        }
        string IRangeControlClient.RulerToString(int index) {
            if(index < rulerValues.Length)
                return rulerValues[index].StartOfPeriod.ToString(YearMonth ? "yyyy/MM" : "MM/dd");
            return string.Empty;
        }
        List<object> IRangeControlClient.GetRuler(RulerInfoArgs e) {
            return null;
        }
        object IRangeControlClient.GetValue(double normalizedValue) {
            return (int)(normalizedValue * ItemsCount);
        }
        double IRangeControlClient.GetNormalizedValue(object value) {
            if(value == null)
                return 0;
            return ((double)(int)value) / ItemsCount;
        }
        string IRangeControlClient.ValueToString(double normalizedValue) {
            TimeSpan timeSpan = data[data.Length - 1].StartOfPeriod - data[0].StartOfPeriod;
            double days = Math.Round(timeSpan.TotalDays * normalizedValue);
            DateTime date = data[0].StartOfPeriod.AddDays(days);
            return date.ToString(YearMonth ? "yyyy/MM" : "MM/dd");
        }
        void IRangeControlClient.DrawContent(RangeControlPaintEventArgs e) {
            DrawGraph(e.Cache, e.ContentBounds);
        }
        void IRangeControlClient.ValidateRange(NormalizedRangeInfo info) {
            int start = (int)(info.Range.Minimum * ItemsCount);
            int end = (int)(info.Range.Maximum * ItemsCount);
            if(end == start) end = start + 2;
            info.Range.Minimum = (double)start / ItemsCount;
            info.Range.Maximum = (double)end / ItemsCount;
        }
        double IRangeControlClient.ValidateScale(double newScale) {
            return 1.0;
        }
        void IRangeControlClient.OnRangeChanged(object rangeMinimum, object rangeMaximum) { }
        void IRangeControlClient.OnRangeControlChanged(IRangeControl rangeControl) { }
        void IRangeControlClient.OnResize() { }
        void IRangeControlClient.OnClick(RangeControlHitInfo hitInfo) { }
        void IRangeControlClient.Calculate(Rectangle contentRect) { }
        void IRangeControlClient.UpdatePressedInfo(RangeControlHitInfo hitInfo) { }
        void IRangeControlClient.UpdateHotInfo(RangeControlHitInfo hitInfo) { }

        //TODO
        public Rectangle CalculateSelectionBounds(RangeControlPaintEventArgs e, Rectangle rect) {
            return rect;
        }
        //TODO
        public void DrawSelection(RangeControlPaintEventArgs e) {
            ;
        }
        #endregion
    }

    public interface ISalesByRangeProvider {
        IEnumerable<SalesGroup> GetSalesDataForItemForPeriod(DateTime start, DateTime end);
        IEnumerable<SalesGroup> GetSalesDataForAllItemsForPeriod(DateTime start, DateTime end);
    }
}
