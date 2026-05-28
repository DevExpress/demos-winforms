using System;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.SalesDemo.Model;
using DevExpress.SalesDemo.Win.Modules;
using DevExpress.XtraCharts;
using DevExpress.DXperience.Demos;

namespace DevExpress.SalesDemo.Win {
    public static class ChartUtils {
        public static Palette GeneratePalette() {
            return new Palette("SalesPalette", PaletteScaleMode.Repeat, new PaletteEntry[] {
                new PaletteEntry(Color.FromArgb(0x46, 0x68, 0xA5)),
                new PaletteEntry(Color.FromArgb(0xA5, 0x46, 0x71)),
                new PaletteEntry(Color.FromArgb(0x49, 0xA4, 0xBE)),
                new PaletteEntry(Color.FromArgb(0x46, 0x9E, 0xA5)),
                new PaletteEntry(Color.FromArgb(0x58, 0x48, 0xA5)),
                new PaletteEntry(Color.FromArgb(0x94, 0x62, 0xAE)),
                new PaletteEntry(Color.FromArgb(0xFC, 0xC6, 0x53))
            });
        }
        public static void CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e) {
            if (e.Item.Axis is AxisY) {
                double value = ((double)e.Item.AxisValue);
                e.Item.Text = DoubleToShortString(value);
            }
            ChartControl chart = sender as ChartControl;
            if (chart == null)
                return;
            if (chart.LookAndFeel.ActiveSkinName == "Office 2016 Dark")
                e.Item.TextColor = Color.White;
        }
        public static void CustomDrawSeriesPointLegendMarker(object sender, CustomDrawSeriesPointEventArgs e) {
            Bitmap markerBitmap = CreateLegendMarker(e.LegendMarkerSize, e.LegendDrawOptions.Color);
            e.LegendMarkerImage = markerBitmap;
            e.DisposeLegendMarkerImage = true;
        }
        public static void CustomDrawPieSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            Bitmap markerBitmap = CreateLegendMarker(e.LegendMarkerSize, e.LegendDrawOptions.Color);
            e.LegendMarkerImage = markerBitmap;
            e.DisposeLegendMarkerImage = true;
            double value = e.SeriesPoint.Values[0];
            e.LabelText = "$" + DoubleToShortString(value);
            ChartControl chart = sender as ChartControl;
            if (chart == null)
                return;
            if (chart.LookAndFeel.ActiveSkinName == "Office 2016 Dark")
                e.LegendTextColor = Color.White;
        }
        public static void CustomDrawBarSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            double value = e.SeriesPoint.Values[0];
            if (value >= 1000000)
                e.LabelText = Math.Round(value / 1000000).ToString() + "M";
            else if (value >= 10000)
                e.LabelText = Math.Round(value / 1000).ToString() + "K";
        }

        static Bitmap CreateLegendMarker(Size size, Color color) {
            Bitmap bmp = new Bitmap(size.Width, size.Height);
            using (Graphics gr = Graphics.FromImage(bmp)) {
                using (Brush brush = new SolidBrush(color)) {
                    gr.FillRectangle(brush, new Rectangle(Point.Empty, size));
                }
            }
            return bmp;
        }
        static string DoubleToShortString(double value) {
            if (value >= 1000000)
                return Math.Round(value / 1000000).ToString() + "M";
            else if (value >= 1000)
                return Math.Round(value / 1000).ToString() + "K";
            else
                return value.ToString();
        }
    }

    public class DailySalesPerformance : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Day; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Area; } }
        public string ChartArgumentDataMember { get { return "StartOfPeriod"; } }
        public string ChartValueDataMember { get { return "TotalCost"; } }
        public string SalesValuesFormat { get { return "${0:N0}"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today.AddDays(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastWeekRange()); } }

        public DailySalesPerformance(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetDayRange(date);
            return dataProvider.GetSales(range.Start, range.End, GroupingPeriod.Hour);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost;
        }
    }

    public class MonthlySalesPerformance : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Month; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Area; } }
        public string ChartArgumentDataMember { get { return "StartOfPeriod"; } }
        public string ChartValueDataMember { get { return "TotalCost"; } }
        public string SalesValuesFormat { get { return "${0:N0}"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastYearRange()); } }

        public MonthlySalesPerformance(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetMonthRange(date);
            return dataProvider.GetSales(range.Start, range.End, GroupingPeriod.Day);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost;
        }
    }

    public class DailySalesByProduct : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Day; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public string ChartValueDataMember { get { return "TotalCost"; } }
        public string SalesValuesFormat { get { return "${0:N0}"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastWeekRange()); } }

        public DailySalesByProduct(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetDayRange(date);
            return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost;
        }
    }

    public class UnitSalesByProduct : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Month; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public string ChartValueDataMember { get { return "Units"; } }
        public string SalesValuesFormat { get { return "{0:N0} Units"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastYearRange()); } }

        public UnitSalesByProduct(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetMonthRange(date);
            return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).Units;
        }
    }

    public class ProductsSalesByRange : ISalesByRangeProvider {
        IDataProvider dataProvider;

        public ProductsSalesByRange(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }
        public IEnumerable<SalesGroup> GetSalesDataForItemForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSalesByProduct(start, end, GroupingPeriod.All);
        }
        public IEnumerable<SalesGroup> GetSalesDataForAllItemsForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSales(start, end, GroupingPeriod.Day);
        }
    }

    public class DailySalesBySector : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Day; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public string ChartValueDataMember { get { return "TotalCost"; } }
        public string SalesValuesFormat { get { return "${0:N0}"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastWeekRange()); } }

        public DailySalesBySector(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetDayRange(date);
            return dataProvider.GetSalesBySector(range.Start, range.End, GroupingPeriod.All);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost;
        }
    }

    public class UnitSalesBySector : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Month; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public string ChartValueDataMember { get { return "Units"; } }
        public string SalesValuesFormat { get { return "{0:N0} Units"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastYearRange()); } }

        public UnitSalesBySector(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetMonthRange(date);
            return dataProvider.GetSalesBySector(range.Start, range.End, GroupingPeriod.All);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).Units;
        }
    }

    public class SectorSalesByRange : ISalesByRangeProvider {
        IDataProvider dataProvider;

        public SectorSalesByRange(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }
        public IEnumerable<SalesGroup> GetSalesDataForItemForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSalesBySector(start, end, GroupingPeriod.All);
        }
        public IEnumerable<SalesGroup> GetSalesDataForAllItemsForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSales(start, end, GroupingPeriod.Day);
        }
    }

    public class DailySalesByRegion : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Day; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public string ChartValueDataMember { get { return "TotalCost"; } }
        public string SalesValuesFormat { get { return "${0:N0}"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetDayRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastWeekRange()); } }

        public DailySalesByRegion(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetDayRange(date);
            return dataProvider.GetSalesByRegion(range.Start, range.End, GroupingPeriod.All);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).TotalCost;
        }
    }

    public class UnitSalesByRegion : ISalesPerformanceProvider {
        IDataProvider dataProvider;

        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Month; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public string ChartValueDataMember { get { return "Units"; } }
        public string SalesValuesFormat { get { return "{0:N0} Units"; } }
        public double SalesValueFirst { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today)); } }
        public double SalesValueSecond { get { return GetTotalSales(DateTimeUtils.GetMonthRange(TutorialConstants.Today.AddMonths(-1))); } }
        public double SalesValueThird { get { return GetTotalSales(DateTimeUtils.GetLastYearRange()); } }

        public UnitSalesByRegion(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }

        public object GetChartData(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetMonthRange(date);
            return dataProvider.GetSalesByRegion(range.Start, range.End, GroupingPeriod.All);
        }
        double GetTotalSales(DateTimeRange range) {
            return (double)dataProvider.GetTotalSalesByRange(range.Start, range.End).Units;
        }
    }

    public class RegionSalesByRange : ISalesByRangeProvider {
        IDataProvider dataProvider;

        public RegionSalesByRange(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }
        public IEnumerable<SalesGroup> GetSalesDataForItemForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSalesByRegion(start, end, GroupingPeriod.All);
        }
        public IEnumerable<SalesGroup> GetSalesDataForAllItemsForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSales(start, end, GroupingPeriod.Day);
        }
    }

    public class ChannelsSalesByRange : ISalesByRangeProvider {
        IDataProvider dataProvider;

        public ChannelsSalesByRange(IDataProvider dataProvider) {
            this.dataProvider = dataProvider;
        }
        public IEnumerable<SalesGroup> GetSalesDataForItemForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSalesByChannel(start, end, GroupingPeriod.All);
        }
        public IEnumerable<SalesGroup> GetSalesDataForAllItemsForPeriod(DateTime start, DateTime end) {
            return dataProvider.GetSales(start, end, GroupingPeriod.Day);
        }
    }
}
