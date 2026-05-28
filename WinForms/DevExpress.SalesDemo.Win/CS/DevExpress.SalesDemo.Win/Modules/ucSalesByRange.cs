using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.SalesDemo.Model;
using DevExpress.Sparkline;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraGauges.Core.Base;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Win.Gauges.Circular;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucSalesByRange : DevExpress.XtraEditors.XtraUserControl {
        DateTime currentDate;
        ISalesByRangeProvider provider;

        RangeControlSalesClient rangeControlSalesClient;

        Palette Palette { get { return pieChart.PaletteRepository[pieChart.PaletteName]; } }
        Series PieSeries { get { return pieChart.Series[0]; } }
        Series BarSeries { get { return barChart.Series[0]; } }

        public ucSalesByRange() {
            InitializeComponent();
            LoadResources();

            Palette palette = ChartUtils.GeneratePalette();
            pieChart.PaletteRepository.Add(palette.Name, palette);
            pieChart.PaletteName = palette.Name;
            pieChart.CustomDrawSeriesPoint += ChartUtils.CustomDrawSeriesPointLegendMarker;

            barChart.PaletteRepository.Add(palette.Name, palette);
            barChart.PaletteName = palette.Name;
            barChart.CustomDrawAxisLabel += ChartUtils.CustomDrawAxisYLabel;
            
            rangeControlSalesClient = new RangeControlSalesClient(Palette[3].Color);
        }

        public void SetSalesByRangeProvider(ISalesByRangeProvider provider) {
            this.provider = provider;
            currentDate = DateTime.Today;

            rangeControl.Client = rangeControlSalesClient;
            rangeControl.RangeChanged += RangeControlRangeChanged;
            
            UpdateRangeControl(currentDate);
        }
        void LoadResources() {
            btnPrev.Image = LoadImage("ArrowLeft.png");
            btnNext.Image = LoadImage("ArrowRight.png");
        }
        static System.Drawing.Image LoadImage(string imageName) {
            return Utils.ResourceImageHelper.CreateImageFromResources(Model.ModelAssemblyHelper.GetResourcePath(imageName), Model.ModelAssemblyHelper.ModelAssembly);
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
            btnNext.Enabled = (currentDate < DateTime.Today);
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
            if (currentDate > DateTime.Today)
                currentDate = DateTime.Today;
            UpdateRangeControl(currentDate);
            UpdateNextButton();
        }
    }

    public class RangeControlSalesClient : IRangeControlClient {
        const int rulerDeltaConst = 1;
        EventHandlerList events;
        SparklineEdit currentSparkline;
        SalesGroup[] data;
        Color chartColor;

        int ItemsCount { get { return data != null ? data.Count() - 1 : 0; } }

        public RangeControlSalesClient(Color chartColor) {
            this.chartColor = chartColor;
            currentSparkline = CreateSparkline(chartColor);
        }

        public void UpdateData(IEnumerable<SalesGroup> salesData) {
            if (salesData == null)
                data = null;
            else
                data = salesData.ToArray();
            currentSparkline.Dispose();
            currentSparkline = CreateSparkline(chartColor);
            currentSparkline.Data = CreateSparklineData(salesData);
            RaiseRangeChanged();
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
            foreach (SalesGroup sale in data)
                sparklineData[index++] = (double)sale.TotalCost;
            return sparklineData;
        }

        protected EventHandlerList Events {
            get {
                if (events == null)
                    events = new EventHandlerList();
                return events;
            }
        }

        private static readonly object rangeChanged = new object();

        protected void RaiseRangeChanged() {
            ClientRangeChangedEventHandler handler = Events[rangeChanged] as ClientRangeChangedEventHandler;
            if (handler != null) {
                RangeControlClientRangeEventArgs e = new RangeControlClientRangeEventArgs();
                e.Range = new RangeControlRange(0, Math.Max(ItemsCount,0));
                e.InvalidateContent = true;
                handler(this, e);
            }
        }

        #region IRangeControlClient Members
        protected virtual void DrawGraph(Graphics graphics, Rectangle contentBounds) {
            graphics.Clear(Color.Transparent);
            contentBounds.Inflate(1, 1);
            currentSparkline.Size = contentBounds.Size;
            currentSparkline.Properties.View = new AreaSparklineView();
            using (Bitmap bitmap = new Bitmap(currentSparkline.Size.Width, currentSparkline.Size.Height)) {
                currentSparkline.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                graphics.DrawImage(bitmap, contentBounds.X, contentBounds.Y);
            }
        }

        bool IRangeControlClient.IsValid { get { return true; } }
        string IRangeControlClient.InvalidText { get { return "invalid"; } }
        object IRangeControlClient.GetOptions() { return this; }
        object IRangeControlClient.RulerDelta { get { return rulerDeltaConst; } }
        double IRangeControlClient.NormalizedRulerDelta { get { return (double)rulerDeltaConst / ItemsCount; } }
        int IRangeControlClient.RangeBoxTopIndent { get { return 0; } }
        int IRangeControlClient.RangeBoxBottomIndent { get { return 0; } }
        bool IRangeControlClient.IsCustomRuler { get { return false; } }

        bool IRangeControlClient.IsValidType(Type type) {
            return true;
        }
        event ClientRangeChangedEventHandler IRangeControlClient.RangeChanged {
            add { Events.AddHandler(rangeChanged, value); }
            remove { Events.RemoveHandler(rangeChanged, value); }
        }
        bool IRangeControlClient.SupportOrientation(RangeControlClientOrientation orientation) {
            return (orientation != RangeControlClientOrientation.Vertical);
        }
        bool IRangeControlClient.DrawRuler(RangeControlPaintEventArgs e) {
            return false;
        }
        string IRangeControlClient.RulerToString(int index) {
            if (data != null && index < data.Count()) {
                if ((index % 5) == 0)
                    return data[index].StartOfPeriod.ToString("MM/dd");
            }
            return string.Empty;
        }
        List<object> IRangeControlClient.GetRuler(RulerInfoArgs e) {
            return null;
        }
        object IRangeControlClient.GetValue(double normalizedValue) {
            int index = (int)(normalizedValue * ItemsCount);
            return index;
        }
        double IRangeControlClient.GetNormalizedValue(object value) {
            if (value == null)
                return 0;
            int index = (int)value;
            return ((double)index) / ItemsCount;
        }
        string IRangeControlClient.ValueToString(double normalizedValue) {
            if (ItemsCount < 1)
                return string.Empty;
            TimeSpan timeSpan = data[data.Count() - 1].StartOfPeriod - data[0].StartOfPeriod;
            double days = Math.Round(timeSpan.TotalDays * normalizedValue);
            DateTime date = data[0].StartOfPeriod.AddDays(days);
            return date.ToString("MM/dd");
        }
        void IRangeControlClient.DrawContent(RangeControlPaintEventArgs e) {
            DrawGraph(e.Graphics, e.ContentBounds);
        }
        void IRangeControlClient.ValidateRange(NormalizedRangeInfo info) {
            int start = (int)(info.Range.Minimum * ItemsCount);
            int end = (int)(info.Range.Maximum * ItemsCount);
            if (end == start) end = start + 2;

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

        Rectangle IRangeControlClient.CalculateSelectionBounds(RangeControlPaintEventArgs e, Rectangle rect) {
            return rect;
        }

        void IRangeControlClient.DrawSelection(RangeControlPaintEventArgs e) {
            
        }
        #endregion
    }

    public interface ISalesByRangeProvider {
        IEnumerable<SalesGroup> GetSalesDataForItemForPeriod(DateTime start, DateTime end);
        IEnumerable<SalesGroup> GetSalesDataForAllItemsForPeriod(DateTime start, DateTime end);
    }
}
