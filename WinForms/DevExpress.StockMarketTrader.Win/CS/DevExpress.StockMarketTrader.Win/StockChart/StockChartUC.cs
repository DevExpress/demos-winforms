using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Svg;
using DevExpress.XtraBars;
using DevExpress.XtraCharts;

namespace DevExpress.StockMarketTrader {
    public partial class StockChartUC : UserControl {
        const string PriceSeriesName = "Price";
        const string VolumeSeriesName = "Volume";
        const int MinCandleCount = 20;

        readonly List<PeriodItem> periods = new List<PeriodItem>() { new PeriodItem("1 Week", 5), new PeriodItem("2 Week", 10), new PeriodItem("1 Month", 20) };
        int daysCount = 105;

        XYDiagram Diagram { get { return (XYDiagram)stockChart.Diagram; } }
        Series PriceSeries { get { return stockChart.Series[PriceSeriesName]; } }
        FinancialSeriesViewBase PriceSeriesView { get { return (FinancialSeriesViewBase)PriceSeries.View; } }
        SideBySideBarSeriesView VolumeSeriesView { get { return (SideBySideBarSeriesView)stockChart.Series[VolumeSeriesName].View; } }

        public StockChartUC() {
            InitializeComponent();
            barStaticItemPeriod.LeftIndent = 11;
            this.stockChart.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            LookAndFeel_StyleChanged(null, null);
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            XYDiagram xYDiagram = stockChart.Diagram as XYDiagram;
            CustomAxisLabel customAxisLabel = xYDiagram.AxisY.CustomLabels[0];
            customAxisLabel.BackColor = Skins.CommonSkins.GetSkin(stockChart.LookAndFeel).SvgPalettes[ObjectState.Normal].GetColor("Gray");
            customAxisLabel.TextColor = Skins.CommonSkins.GetSkin(stockChart.LookAndFeel).SvgPalettes[ObjectState.Normal].GetColor("White");
        }
        void StockChartUC_Load(object sender, EventArgs e) {
            if(StockMarketView.defaultViewModel == null)
                return;
            volumesBarCheckItem.ImageOptions.SvgImage = SvgResources.GetSvgImage("Bars");
            barCheckItem3.ImageOptions.SvgImage = SvgResources.GetSvgImage("6m");
            barCheckItem4.ImageOptions.SvgImage = SvgResources.GetSvgImage("1y");
            barCheckItem5.ImageOptions.SvgImage = SvgResources.GetSvgImage("1-5y");
            barCheckItem6.ImageOptions.SvgImage = SvgResources.GetSvgImage("2y");
            barCheckItem7.ImageOptions.SvgImage = SvgResources.GetSvgImage("4y");
            OnPeriodChanged(barCheckItem7, null);
        }
        void OnShowVolumeChartChanged(object sender, ItemClickEventArgs e) {
            Diagram.Panes[0].Visibility = volumesBarCheckItem.Checked ? ChartElementVisibility.Visible : ChartElementVisibility.Hidden;
        }
        void OnPeriodChanged(object sender, ItemClickEventArgs e) {
            BarCheckItem barCheckItem = sender as BarCheckItem;
            if(barCheckItem != null && barCheckItem.Checked != false) {
                daysCount = (int)barCheckItem.Tag;
                repositoryItemComboBoxPeriod.Items.Clear();
                foreach(PeriodItem periodItem in periods) {
                    int numberOfCandles = daysCount / periodItem.Ticks;
                    if(numberOfCandles >= MinCandleCount)
                        repositoryItemComboBoxPeriod.Items.Add(periodItem);
                }
                comboBoxBarEditItem.EditValue = repositoryItemComboBoxPeriod.Items[0];
                OnTicksChanged(comboBoxBarEditItem, null);
            }
        }
        void OnTicksChanged(object sender, EventArgs e) {
            if(!ViewModel.RealTimeDataViewModel.IsReady) return;
            BarEditItem barEditItem = sender as BarEditItem;
            if(barEditItem != null && barEditItem.Name == "comboBoxBarEditItem") {
                var vm = StockMarketView.defaultViewModel;
                if(vm != null) {
                    int numberOfTicks = ((PeriodItem)barEditItem.EditValue).Ticks;
                    int newCandlesCount = daysCount / numberOfTicks;
                    if(vm.Ticks != numberOfTicks || vm.CandlesCount != newCandlesCount) {
                        vm.SetTicks(numberOfTicks);
                        vm.CandlesCount = newCandlesCount;
                        vm.OnCandlesCountChanged();
                    }
                }
            }
            UpdateSeriesView();
        }
        void UpdateSeriesView() {
            if(comboBoxBarEditItem.EditValue != null) {
                switch(comboBoxBarEditItem.EditValue.ToString()) {
                    case "1 week":
                        Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week;
                        PriceSeriesView.LevelLineLength = 0.3;
                        VolumeSeriesView.BarWidth = 0.8D;
                        break;
                    case "2 week":
                        Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Week;
                        PriceSeriesView.LevelLineLength = 0.6;
                        VolumeSeriesView.BarWidth = 1.6D;
                        break;
                    case "1 month":
                        Diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
                        PriceSeriesView.LevelLineLength = 0.3;
                        VolumeSeriesView.BarWidth = 0.8D;
                        break;
                }
            }
        }
        void stockChart_BoundDataChanged(object sender, EventArgs e) {
            if(PriceSeries.Points.Count > 0) {
                Diagram.AxisY.CustomLabels[0].AxisValue = PriceSeries.Points[PriceSeries.Points.Count - 1].Values[3];
                Diagram.AxisY.CustomLabels[0].Name = String.Format("${0:F1}", Diagram.AxisY.CustomLabels[0].AxisValue);
            }
        }
    }
    public class PeriodItem {
        public PeriodItem(string caption, int ticks) {
            Caption = caption;
            Ticks = ticks;
        }
        public override string ToString() {
            return Caption;
        }
        public string Caption {
            get;
            private set;
        }
        public int Ticks {
            get;
            private set;
        }
    }
    //
    public class SvgResources {
        const string prefix = "DevExpress.StockMarketTrader.ImagesSvg.";
        const string ext = ".svg";
        readonly static Dictionary<string, SvgImage> svgImages = new Dictionary<string, SvgImage>(20);
        public static SvgImage GetSvgImage(string imageName) {
            SvgImage svgImage;
            if(!svgImages.TryGetValue(imageName, out svgImage)) {
                svgImage = ResourceImageHelper.CreateSvgImageFromResources(prefix + imageName + ext, typeof(SvgResources).Assembly);
                svgImages.Add(imageName, svgImage);
            }
            return svgImage;
        }
    }
}
