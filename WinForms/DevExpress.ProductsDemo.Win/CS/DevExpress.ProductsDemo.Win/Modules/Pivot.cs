using System;
using System.Data;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraCharts;
using DevExpress.SalesDemo.Model;
using DevExpress.SalesDemo.Win;
using DevExpress.SalesDemo.Win.Modules;

namespace DevExpress.ProductsDemo.Win.Modules {
    public partial class PivotModuleNew : BaseModule {
        protected override bool AutoMergeRibbon { get { return true; } }
        DateTimeRange currentRange, range;
        IDataProvider dataProvider;
        RangeControlSalesClient rangeControlClient; 
        public PivotModuleNew() {
            InitializeComponent();
            InitializePivot();
            Initialize();
            UpdateData();
            UpdateTiles();
            LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            LookAndFeel_StyleChanged(null, EventArgs.Empty);
        }

        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            //tiles.AppearanceItem.Normal.BackColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.Control);
            //tiles.AppearanceItem.Normal.ForeColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlText);
            //tiles.AppearanceItem.Normal.BorderColor = LookAndFeelHelper.GetSystemColor(LookAndFeel, SystemColors.ControlDark);
        }

        private void InitializePivot() {
            pivot.OptionsFilterPopup.FieldFilterPopupMode = FieldFilterPopupMode.Excel;
            pivot.Fields.Add(new PivotGridField("StartOfPeriod", PivotArea.RowArea) { Caption = "Year", GroupInterval = PivotGroupInterval.DateYear, TotalsVisibility = PivotTotalsVisibility.None });
            pivot.Fields.Add(new PivotGridField("StartOfPeriod", PivotArea.RowArea) { Caption = "Month", GroupInterval = PivotGroupInterval.DateMonth, TotalsVisibility = PivotTotalsVisibility.None });
            pivot.Fields.Add(new PivotGridField("GroupName", PivotArea.ColumnArea) { Caption = "Product"});
            pivot.Fields.Add(new PivotGridField("TotalCost", PivotArea.DataArea) { Caption = "Sales" });
            pivot.Fields.Add(new PivotGridField("Units", PivotArea.DataArea) { Caption = "Units" });
        }

        private void UpdateData() {
            this.rangeControl.RangeChanged -= rangeControl_RangeChanged;
            ucUnits.SetSalesPerformanceProvider(new UnitsByProductByDateRange(dataProvider, this.currentRange));
            ucSales.SetSalesPerformanceProvider(new SalesByProductByDateRange(dataProvider, this.currentRange));
            pivot.DataSource = dataProvider.GetSalesByProduct(currentRange.Start, currentRange.End, GroupingPeriod.Day).ToList();
            pivot.BestFit();
            this.rangeControl.RangeChanged += rangeControl_RangeChanged;
            ucUnits.Annotation.Text = "Units";//.Visible = false;
            //FreePosition fp;fp.doc
            ucUnits.Annotation.ShapePosition = new FreePosition() { DockCorner = XtraCharts.DockCorner.RightTop, DockTarget = ((XYDiagram)ucUnits.chart.Diagram).DefaultPane };
            ucSales.Annotation.Text = "Sales";//.Visible = false;
            ucSales.Annotation.ShapePosition = new FreePosition() { DockCorner = XtraCharts.DockCorner.LeftTop };
        }

        void Initialize() {
            this.dataProvider = DataSource.GetDataProvider();
            this.range = this.currentRange = DateTimeUtils.GetOneYearRange();
            ucSales.Diagram.AxisY.Visibility = Utils.DefaultBoolean.False;
            ucSales.Diagram.AxisX.Visibility = Utils.DefaultBoolean.False;
            ucUnits.Diagram.AxisY.Visibility = Utils.DefaultBoolean.False;
            ucUnits.Diagram.AxisX.Visibility = Utils.DefaultBoolean.False;
            ucUnits.Diagram.Margins.All = 0;
            ucUnits.Diagram.Rotated = true;
            ucUnits.chart.Legend.AlignmentVertical = LegendAlignmentVertical.Top;
            ucUnits.chart.Legend.AlignmentHorizontal = LegendAlignmentHorizontal.RightOutside;

            ucUnits.chart.Legend.Border.Visibility = Utils.DefaultBoolean.False;
            ucUnits.chart.Legend.Margins.Right = 0;
            ucUnits.chart.Legend.MarkerSize = new System.Drawing.Size(18, 18);
            ucUnits.chart.Legend.MarkerMode = LegendMarkerMode.None;
            ucUnits.chart.Legend.TextOffset = 8;
            ucUnits.chart.Legend.VerticalIndent = 4;
            ucUnits.chart.Legend.Visibility = Utils.DefaultBoolean.True;
            ucUnits.chart.Series[0].LegendTextPattern = "{A}";
            ucSales.Diagram.Margins.All = 0;

            Palette palette = ChartUtils.GeneratePalette();
            this.rangeControlClient = new RangeControlSalesClient(palette[3].Color);
            this.rangeControlClient.YearMonth = true;
            rangeControl.Client = this.rangeControlClient;
            IEnumerable<SalesGroup> sales = dataProvider.GetSales(range.Start, range.End, GroupingPeriod.Day);
            this.rangeControlClient.UpdateData(sales);

        }
        void UpdateTiles() {
            var ytd = DateTimeUtils.GetYtdRange();
            var ytdPrev = new DateTimeRange(ytd.Start.AddYears(-1), ytd.End.AddYears(-1));
            var ytdSales = dataProvider.GetTotalSalesByRange(ytd.Start, ytd.End);
            tiUnitSales.Elements[1].Text = ytdSales.Units.ToString("n0");
            tiDirectSales.Elements[1].Text = ytdSales.TotalCost.ToString("$#,##0,,M", CultureInfo.InvariantCulture);
            var ytdSalesPrev = dataProvider.GetTotalSalesByRange(ytdPrev.Start, ytdPrev.End);
            if(ytdSalesPrev.TotalCost != decimal.Zero) {
                decimal percents = (ytdSales.TotalCost - ytdSalesPrev.TotalCost) / ytdSalesPrev.TotalCost;
                tiRevenue.Elements[1].Text = string.Format("{1}{0:P1}", Math.Abs(percents), percents < 0 ? "-" : "+");
            }
            else tiRevenue.Elements[1].Text = "N/A";

            var sector = dataProvider.GetSalesBySector(ytd.Start, ytd.End, GroupingPeriod.All).OrderByDescending(q => q.TotalCost).FirstOrDefault();
            if(sector == null) {
                tiBestSector.Visible = false;
            }
            else {
                tiBestSector.Text = string.Format(tiBestSector.Text, sector.GroupName.ToUpper());
                tiBestSector.Elements[1].Text = sector.TotalCost.ToString("$#,##0,,M", CultureInfo.InvariantCulture);
            }
        }

        void rangeControl_RangeChanged(object sender, XtraEditors.RangeControlRangeEventArgs range) {
            DateTime start = this.range.Start.AddDays((int)range.Range.Minimum);
            DateTime end = this.range.Start.AddDays((int)range.Range.Maximum);
            this.currentRange = new DateTimeRange(start, end);
            UpdateData();
            
        }

    }
    public class SalesByProductByDateRange: ISalesPerformanceProvider {
        protected IDataProvider dataProvider;
        protected DateTimeRange range;
        public SalesPerformanceMode Mode { get { return SalesPerformanceMode.Month; } }
        public SalesPerformanceChartType ChartType { get { return SalesPerformanceChartType.Bar; } }
        public string ChartArgumentDataMember { get { return "GroupName"; } }
        public virtual string ChartValueDataMember { get { return "TotalCost"; } }
        public string SalesValuesFormat { get { return "${0:N0}"; } }
        public virtual double SalesValueFirst { get { return 0; } }
        public virtual double SalesValueSecond { get { return 0; } }
        public virtual double SalesValueThird { get { return 0; } }

        public SalesByProductByDateRange(IDataProvider dataProvider, DateTimeRange range) {
            this.range = range;
            this.dataProvider = dataProvider;
        }

        public virtual object GetChartData(DateTime date) {
            return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All);
        }
    }
    public class UnitsByProductByDateRange : SalesByProductByDateRange {
        public UnitsByProductByDateRange(IDataProvider dataProvider, DateTimeRange range) : base(dataProvider, range) { }
        public override object GetChartData(DateTime date) {
            return dataProvider.GetSalesByProduct(range.Start, range.End, GroupingPeriod.All);
        }
        public override string ChartValueDataMember { get { return "Units"; } }
    }

}
