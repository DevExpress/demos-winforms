using System;
using System.Drawing;
using DevExpress.DXperience.Demos;
using DevExpress.LookAndFeel;
using DevExpress.SalesDemo.Model;
using DevExpress.SalesDemo.Win;
using DevExpress.Utils.Frames;
using DevExpress.XtraCharts;
using DevExpress.XtraGauges.Core.Base;
using DevExpress.XtraGauges.Core.Drawing;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class AnalyticsModule : BaseModule {
        Series SalesBySectorSeries { get { return chartSalesbySecor.Series[0]; } }
        public AnalyticsModule() {
            InitializeComponent();
            Initialize();
            AssignShader();
        }
        void AssignShader() {
            var shader = new FlatBackgroundShader(LookAndFeel);
            needleFiscalYear.Shader = shader;
            needleFiscalToData.Shader = shader;
            arcScaleBackgroundLayerComponent3.Shader = shader;
            arcScaleBackgroundLayerComponent4.Shader = shader;
        }
        void Initialize() {
            IDataProvider dataProvider = DataSource.GetDataProvider();
            SalesBySectorSeries.DataSource = dataProvider.GetSalesBySector(new DateTime(), TutorialConstants.Now, GroupingPeriod.All);

            dailySalesPerformance.SetSalesPerformanceProvider(new DailySalesPerformance(dataProvider));
            monthlySalesPerformance.SetSalesPerformanceProvider(new MonthlySalesPerformance(dataProvider));

            Palette palette = ChartUtils.GeneratePalette();
            chartSalesbySecor.PaletteRepository.Add(palette.Name, palette);
            chartSalesbySecor.PaletteName = palette.Name;
            chartSalesbySecor.CustomDrawSeriesPoint += ChartUtils.CustomDrawPieSeriesPoint;


            int year = TutorialConstants.Today.Year;
            SalesGroup thisYearSales = dataProvider.GetTotalSalesByRange(new DateTime(year, 1, 1), TutorialConstants.Today);
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
        internal class FlatBackgroundShader : BaseColorShader {
            readonly Color backColorToReplace = Color.FromArgb(255, 255, 255);
            readonly Color borderColorToReplace = Color.FromArgb(243, 243, 243);
            Color backColor;
            Color borderColor;
            UserLookAndFeel lookAndFeel;
            public FlatBackgroundShader(UserLookAndFeel lookAndFeel) {
                this.lookAndFeel = lookAndFeel;
                lookAndFeel.StyleChanged += OnStyleChanged;
                UpdateColors();
            }
            void OnStyleChanged(object sender, EventArgs e) {
                UpdateColors();
            }
            private void UpdateColors() {
                backColor = LookAndFeelHelper.GetSystemColorEx(lookAndFeel, SystemColors.Control);
                bool isDarkSkin = FrameHelper.IsDarkSkin(lookAndFeel.ActiveLookAndFeel);
                double scale = isDarkSkin ? 1.2 : 0.95;
                borderColor = Color.FromArgb(Math.Min((int)(backColor.R * scale), 255), Math.Min((int)(backColor.G * scale), 255), Math.Min((int)(backColor.B * scale), 255));
            }
            protected override void OnDispose() {
                base.OnDispose();
                if(lookAndFeel != null) {
                    lookAndFeel.StyleChanged -= OnStyleChanged;
                    lookAndFeel = null;
                }
            }
            protected override void OnCreate() { }
            protected override void ProcessCore(ref Color sourceColor) {
                if(sourceColor == backColorToReplace)
                    sourceColor = backColor;
                if(sourceColor == borderColorToReplace)
                    sourceColor = borderColor;
            }
            protected override BaseObject CloneCore() {
                return new FlatBackgroundShader(lookAndFeel);
            }
            protected override string GetShaderTypeTag() {
                return "Empty";
            }
            protected override string GetShaderDataTag() {
                return string.Empty;
            }
            protected override void Assign(string shaderData) { }
        }
    }
}
