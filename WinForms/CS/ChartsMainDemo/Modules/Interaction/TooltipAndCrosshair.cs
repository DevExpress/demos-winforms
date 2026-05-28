using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DevExpress.Drawing;
using DevExpress.Utils;

namespace DevExpress.XtraCharts.Demos {
    public partial class TooltipAndCrosshairDemo : ChartDemoModuleWithOptions {
        static readonly Size DefaultToolTipChartSize = new Size(300, 200);

        ChartControl focusedChart;
        ChartControl chartBar;
        readonly ToolTipMousePosition toolTipMousePosition = new ToolTipMousePosition();
        readonly ToolTipRelativePosition toolTipRelativePosition = new ToolTipRelativePosition();
        readonly ToolTipFreePosition toolTipFreePosition = new ToolTipFreePosition();
        Size toolTipChartSize = DefaultToolTipChartSize;
        bool tooltipShowImage = true;

        CrosshairOptions CrosshairOptions {
            get { return chartSpline.CrosshairOptions; }
        }
        internal override ChartControl ChartControl {
            get { return focusedChart; }
        }
        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartBar,
                    chartSpline
                };
            }
        }

        public TooltipAndCrosshairDemo() {
            InitializeComponent();
            List<CategorySaleItem> items = SaleItem.GetProductsCategoriesByMonth();
            chartBar.DataSource = items;
            chartBar.SelectedItems.Add(items[4]);
            chartSpline.SeriesTemplate.DateTimeSummaryOptions.SummaryFunction = "SUM([Income])";
            toolTipFreePosition.DockTarget = ((XYDiagram2D)chartBar.Diagram).DefaultPane;
            comboBoxEditTooltipPosition.SelectedIndex = 1;
            focusedChart = chartBar;
        }

        SuperToolTip Create(CategorySaleItem categorySaleItem) {
            SuperToolTip superTip = new SuperToolTip();
            ToolTipTitleItem title = new ToolTipTitleItem() { Text = categorySaleItem.Category };
            title.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            superTip.Items.Add(title);
            superTip.Items.Add(new ToolTipSeparatorItem());
            foreach(KeyValuePair<string, double> item in categorySaleItem.ProductIncome)
                superTip.Items.Add(new ToolTipItem { Text = String.Format("{0}: {1}", item.Key, item.Value) });
            return superTip;
        }
        void UpdateSplineChartColors(CategorySaleItem item) {
            Color splineChartBaseColor = GetColorFromPaletteByNumber(item.OrderIndex);
            int seriesCount = chartSpline.Series.Count;
            for(int i = 0; i < seriesCount; i++)
                chartSpline.Series[i].View.Color = ColorUtils.ConvertColor(splineChartBaseColor, i, seriesCount);
        }
        Color GetColorFromPaletteByNumber(int colorNumber) {
            if(chartBar.Series.Count == 0)
                return Color.Empty;
            PaletteEntry[] entries = chartBar.GetPaletteEntries(chartBar.Series[0].Points.Count);
            return entries[colorNumber].Color;
        }
        Image CreateChart(List<SaleItem> toolTipChartDataSource, string chartTitleText, Color seriesColor) {
            ChartControl chart = new ChartControl();
            chart.Size = toolTipChartSize;
            chart.BorderOptions.Visibility = DefaultBoolean.False;
            chart.DataSource = toolTipChartDataSource;
            Series series = new Series("Products Income", ViewType.Bar);
            series.ValueDataMembers.AddRange("Income");
            series.ArgumentDataMember = "Product";
            series.LabelsVisibility = DefaultBoolean.False;
            series.View.Color = seriesColor;
            series.ArgumentScaleType = ScaleType.Qualitative;
            series.QualitativeSummaryOptions.SummaryFunction = "SUM([Income])";
            chart.Series.Add(series);
            chart.Legend.Visibility = DefaultBoolean.False;
            XYDiagram xyDiagram = (XYDiagram)chart.Diagram;
            xyDiagram.AxisY.WholeRange.AlwaysShowZeroLevel = false;
            xyDiagram.AxisX.Label.DXFont = new DXFont("Tahoma", 7);
            xyDiagram.AxisX.QualitativeScaleOptions.AutoGrid = false;
            xyDiagram.AxisX.Tickmarks.MinorVisible = false;
            chart.Titles.Add(new ChartTitle() { Text = chartTitleText, DXFont = new DXFont("Tahoma", 12) });
            Image chartAsImage;
            using(MemoryStream stream = new MemoryStream()) {
                chart.ExportToImage(stream, DXImageFormat.Png);
                chartAsImage = new Bitmap(stream);
            }
            return chartAsImage;
        }

        void comboBoxEditToolTipPosition_SelectedIndexChanged(object sender, EventArgs e) {
            switch(comboBoxEditTooltipPosition.SelectedIndex) {
                case 0:
                    chartBar.ToolTipOptions.ToolTipPosition = toolTipMousePosition;
                    barChartToolTipController.ShowBeak = true;
                    break;
                case 1:
                    chartBar.ToolTipOptions.ToolTipPosition = toolTipRelativePosition;
                    barChartToolTipController.ShowBeak = true;
                    break;
                case 2:
                    chartBar.ToolTipOptions.ToolTipPosition = toolTipFreePosition;
                    barChartToolTipController.ShowBeak = false;
                    break;
            }
        }
        void comboBoxEditTooltipType_SelectedIndexChanged(object sender, EventArgs e) {
            tooltipShowImage = comboBoxEditTooltipType.SelectedIndex == 0;
        }
        void checkEditShowLabel_CheckedChanged(object sender, EventArgs e) {
            CrosshairOptions.ShowCrosshairLabels = checkEditShowLabel.Checked;
        }
        void comboBoxEditShowAxisXValues_CheckedChanged(object sender, EventArgs e) {
            CrosshairOptions.ShowArgumentLabels = comboBoxEditShowAxisXValues.Checked;
        }
        void comboBoxEditShowAxisYValues_CheckedChanged(object sender, EventArgs e) {
            CrosshairOptions.ShowValueLabels = comboBoxEditShowAxisYValues.Checked;
        }
        void comboBoxEditShowArgumentLine_CheckedChanged(object sender, EventArgs e) {
            CrosshairOptions.ShowArgumentLine = comboBOxEditShowArgumentLine.Checked;
        }
        void comboBoxEditShowValueLine_CheckedChanged(object sender, EventArgs e) {
            CrosshairOptions.ShowValueLine = comboBoxEditShowValueLine.Checked;
        }
        void comboBoxEditShowContentIn_SelectedIndexChanged(object sender, EventArgs e) {
            bool isLabelMode = comboBoxEditShowContentIn.SelectedIndex == 0;
            CrosshairOptions.ContentShowMode = isLabelMode ? CrosshairContentShowMode.Label : CrosshairContentShowMode.Legend;
            lciShowLabel.Enabled = isLabelMode;
            lciLabelMode.Enabled = isLabelMode;
            if(!isLabelMode)
                comboBoxEditLabelMode.SelectedIndex = 1;

        }
        void comboBoxEditLabelMode_SelectedIndexChanged(object sender, EventArgs e) {
            if(comboBoxEditLabelMode.SelectedIndex == -1)
                return;
            CrosshairOptions.CrosshairLabelMode = comboBoxEditLabelMode.SelectedIndex == 0 ? CrosshairLabelMode.ShowForNearestSeries : CrosshairLabelMode.ShowCommonForAllSeries;
        }
        void barChart_SelectedItemsChanged(object sender, SelectedItemsChangedEventArgs e) {
            if(e.NewItems == null || e.NewItems.Count == 0)
                return;
            CategorySaleItem item = e.NewItems[0] as CategorySaleItem;
            if(item == null)
                return;
            chartSpline.BeginInit();
            chartSpline.DataSource = item.SaleItems;
            chartSpline.EndInit();
            UpdateSplineChartColors(item);
            chartSpline.Animate();
        }
        void barChartToolTipController_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            ToolTipController controller = sender as ToolTipController;
            SeriesPoint seriesPoint = controller.ActiveObject as SeriesPoint;
            if(seriesPoint == null)
                return;
            CategorySaleItem categorySaleItem = seriesPoint.Tag as CategorySaleItem;
            if(categorySaleItem == null)
                return;
            if(tooltipShowImage) {
                e.ToolTipType = ToolTipType.Standard;
                e.ToolTipImage = CreateChart(categorySaleItem.SaleItems, categorySaleItem.Category, GetColorFromPaletteByNumber(categorySaleItem.OrderIndex));
                e.ToolTip = "";
            }
            else {
                e.ToolTipType = ToolTipType.SuperTip;
                e.SuperTip = Create(categorySaleItem);
            }
        }
        void chartBar_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            e.Cancel = true;
        }
        void chartBar_ObjectSelected(object sender, HotTrackEventArgs e) {
            e.Cancel = !(e.Object is Series);
        }
        void OnChartClick(object sender, EventArgs e) {
            focusedChart = (ChartControl)sender;
        }

        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            if(chartBar.SelectedItems.Count > 0)
                UpdateSplineChartColors((CategorySaleItem)chartBar.SelectedItems[0]);
        }
        protected override void ScaleControl(SizeF factor, BoundsSpecified specified) {
            base.ScaleControl(factor, specified);
            int width = (int)Math.Round(DefaultToolTipChartSize.Width * factor.Width);
            int height = (int)Math.Round(DefaultToolTipChartSize.Height * factor.Height);
            toolTipChartSize = new Size(width, height);
        }
    }
}
