using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.SalesDemo.Model;
using DevExpress.Utils;
using DevExpress.XtraCharts;
using DevExpress.XtraLayout;

namespace DevExpress.SalesDemo.Win.Modules {
    public partial class ucChannels : BaseModule {
        IDataProvider dataProvider;
        DateTime currentDate;
        Palette palette;

        TextAnnotation ChartAnnotation { get { return (TextAnnotation)chart.Annotations[0]; } }
        Palette Palette {
            get {
                if (palette == null)
                    palette = ChartUtils.GeneratePalette();
                return palette;
            }
        }

        public ucChannels() {
            InitializeComponent();
            LoadResources();
            Initialize();
        }

        void LoadResources() {
            btnPrev.Image = LoadImage("ArrowLeft.png");
            btnNext.Image = LoadImage("ArrowRight.png");
        }
        static System.Drawing.Image LoadImage(string imageName) {
            return Utils.ResourceImageHelper.CreateImageFromResources(Model.ModelAssemblyHelper.GetResourcePath(imageName), Model.ModelAssemblyHelper.ModelAssembly);
        }
        void Initialize() {
            InitializeChart();

            dataProvider = DataSource.GetDataProvider();
            ucSalesByRange.SetSalesByRangeProvider(new ChannelsSalesByRange(dataProvider));

            currentDate = DateTime.Today;
            UpdateSales(currentDate);
        }
        void InitializeChart() {
            chart.BeginInit();
            chart.SeriesDataMember = "GroupName";
            chart.SeriesTemplate.ArgumentDataMember = "StartOfPeriod";
            chart.SeriesTemplate.ValueDataMembers.AddRange("TotalCost");
            chart.SeriesTemplate.View = new LineSeriesView() { MarkerVisibility = DefaultBoolean.True };
            chart.CustomDrawAxisLabel += new CustomDrawAxisLabelEventHandler(ChartUtils.CustomDrawAxisYLabel);
            Axis2D axisX = ((XYDiagram)chart.Diagram).AxisX;
            axisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Hour;
            axisX.Label.TextPattern = "{A:t}";
            axisX.WholeRange.AutoSideMargins = false;
            axisX.WholeRange.SideMarginsValue = 0;
            chart.PaletteRepository.Add(Palette.Name, Palette);
            chart.PaletteName = Palette.Name;
            chart.EndInit();
        }
        void UpdateSales(DateTime date) {
            DateTimeRange range = DateTimeUtils.GetDayRange(date);
            UpdateChart(range);
            UpdateSalesInfo(range);
            btnNext.Enabled = (currentDate < DateTime.Today);
        }
        List<SalesGroup> GetTotalSales(DateTimeRange range) {
            SalesGroup total = dataProvider.GetTotalSalesByRange(range.Start, range.End);
            IEnumerable<SalesGroup> sales = dataProvider.GetSalesByChannel(range.Start, range.End, GroupingPeriod.All);
            List<SalesGroup> resultSales = new List<SalesGroup>(sales);
            resultSales.Insert(0, total);
            return resultSales;
        }
        void CreateTableLayoutInfoControls(int controlsCount) {
            tableLayoutInfo.BeginUpdate();
            tableLayoutInfo.Clear(true);
            tableLayoutInfo.OptionsTableLayoutGroup.ColumnDefinitions.Clear();
            for(int i = 0; i < controlsCount; i++)
                tableLayoutInfo.OptionsTableLayoutGroup.ColumnDefinitions.Add(new XtraLayout.ColumnDefinition(tableLayoutInfo, 100F / (float)controlsCount, SizeType.Percent));
            for(int i = 0; i < controlsCount; i++) {
                ucValuePresenter valuePresenter = new ucValuePresenter { ValueFormat = "${0:N0}", Dock = DockStyle.Fill };
                if(i > 0)
                    valuePresenter.ValueTextColor = Palette[(i - 1) % Palette.Count].Color;
                LayoutControlItem item = new LayoutControlItem();
                item.TextVisible = false;
                item.Control = valuePresenter;
                item.OptionsTableLayoutItem.ColumnIndex = i;
                tableLayoutInfo.AddItem(item);
            }
            tableLayoutInfo.EndUpdate();
        }
        void UpdateSalesInfo(DateTimeRange range) {
            List<SalesGroup> totalSales = GetTotalSales(range);
            int totalSalesCount = totalSales.Count;

            if(tableLayoutInfo.OptionsTableLayoutGroup.ColumnCount != totalSalesCount)
                CreateTableLayoutInfoControls(totalSalesCount);

            for(int i = 0; i < totalSalesCount; i++) {
                ucValuePresenter valuePresenter = (ucValuePresenter)(tableLayoutInfo.Items[i] as LayoutControlItem).Control;
                valuePresenter.TitleText = totalSales[i].GroupName;
                valuePresenter.Value = (double)totalSales[i].TotalCost;
            }
        }
        void UpdateChart(DateTimeRange range) {
            chart.DataSource = dataProvider.GetSalesByChannel(range.Start, range.End, GroupingPeriod.Hour);
            ChartAnnotation.Text = range.Start.ToString("d");
        }
        DateTime ChangeDate(DateTime date, int days) {
            DateTime newDate = date.AddDays(days);
            if (newDate > DateTime.Today)
                newDate = DateTime.Today;
            return newDate;
        }
        void btnPrev_Click(object sender, EventArgs e) {
            currentDate = ChangeDate(currentDate, -1);
            UpdateSales(currentDate);
        }

        void btnNext_Click(object sender, EventArgs e) {
            currentDate = ChangeDate(currentDate, 1);
            UpdateSales(currentDate);
        }
    }
}
