using System;
using DevExpress.SalesDemo.Model;
using DevExpress.XtraCharts;

namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucSalesDashboard : BaseModule {
        Series SalesbySecorSeries { 
            get { return chartSalesbySecor.Series[0]; } 
        }
        public ucSalesDashboard() {
            InitializeComponent();
            Initialize();
        }
        void Initialize() {
            IDataProvider dataProvider = DataSource.GetDataProvider();
            SalesbySecorSeries.DataSource = dataProvider.GetSalesBySector(new DateTime(), DateTime.Now, GroupingPeriod.All);

            dailySalesPerformance.SetSalesPerformanceProvider(new DailySalesPerformance(dataProvider));
            monthlySalesPerformance.SetSalesPerformanceProvider(new MonthlySalesPerformance(dataProvider));

            Palette palette = ChartUtils.GeneratePalette();
            chartSalesbySecor.PaletteRepository.Add(palette.Name, palette);
            chartSalesbySecor.PaletteName = palette.Name;
            chartSalesbySecor.CustomDrawSeriesPoint += ChartUtils.CustomDrawPieSeriesPoint;


            int year = DateTime.Today.Year;
            SalesGroup thisYearSales = dataProvider.GetTotalSalesByRange(new DateTime(year, 1, 1), DateTime.Today);
            decimal fiscalToDataValue = thisYearSales.TotalCost;
            fiscalToData.Text = fiscalToDataValue.ToString("$0,0");
            needleFiscalToData.Value = (float)thisYearSales.TotalCost;
            decimal salesForecast = SalesForecastMaker.GetYtdForecast(fiscalToDataValue);
            linearScaleRangeBarForecast.Value = (float)(salesForecast / 1000000);

            int preYear = year - 1;
            SalesGroup prevYearSales = dataProvider.GetTotalSalesByRange(new DateTime(preYear, 1, 1), new DateTime(preYear, 12, DateTime.DaysInMonth(preYear, 12)));
            labelFiscalYear.Text = "FISCAL YEAR " + preYear.ToString();
            fiscalYear.Text = prevYearSales.TotalCost.ToString("$0,0");
            needleFiscalYear.Value = (float)prevYearSales.TotalCost;
        }
    }
}
