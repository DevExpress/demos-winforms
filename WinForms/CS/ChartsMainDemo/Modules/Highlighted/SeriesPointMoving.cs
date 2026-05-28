using System;
using System.Windows.Forms;

namespace DevExpress.XtraCharts.Demos {
    public partial class SeriesPointMovingDemo : ChartDemoModule {
        const double MinValue = 0;
        const double MaxRetailPriceValue = 500;
        const double MaxValue = 1000 * MaxRetailPriceValue;
        const int ItemProductionCost = 50;

        readonly DraggableDataModel dataSource;
        string seriesName;
        XYDiagramPaneBase currentPane;
        DraggableItem currentItem;

        internal override ChartControl ChartControl { get { return chart; } }

        public SeriesPointMovingDemo() {
            InitializeComponent();
            dataSource = DraggableDataModel.CreateModel(ItemProductionCost);
            chart.DataSource = dataSource;
            UpdateTotalIncome();
        }
        void UpdateTotalIncome() {
            chart.Legends[1].CustomItems[0].Text = string.Format("Total income: ${0}K", dataSource.TotalIncome.ToString("N0"));
        }
        void Chart_MouseDown(object sender, MouseEventArgs e) {
            ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
            if(hitInfo.SeriesPoint == null)
                return;
            seriesName = hitInfo.Series.ToString();
            if(seriesName == "Income" || seriesName == "Stock")
                return;
            currentItem = (DraggableItem)hitInfo.SeriesPoint.Tag;
            currentPane = GetPane(hitInfo.Series);
        }
        XYDiagramPaneBase GetPane(SeriesBase series) {
            XYDiagramSeriesViewBase view = series.View as XYDiagramSeriesViewBase;
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if(view != null && diagram != null)
                return view.Pane ?? diagram.DefaultPane;
            return null;
        }
        void Chart_MouseMove(object sender, MouseEventArgs e) {
            ChangeCursor(e);
            XYDiagram diagram = chart.Diagram as XYDiagram;
            if(currentItem != null && currentPane != null && diagram != null) {
                DiagramCoordinates coords = diagram.PointToDiagram(e.Location);
                if(!coords.IsEmpty && currentPane.Equals(coords.Pane)) {
                    SetNewPointValue(coords.NumericalValue);
                }
            }
        }
        void ChangeCursor(MouseEventArgs e) {
            if(currentItem == null) {
                ChartHitInfo hitInfo = chart.CalcHitInfo(e.Location);
                if(hitInfo.SeriesPoint != null && hitInfo.Series.ToString() != "Stock")
                    chart.Cursor = Cursors.SizeNS;
                else
                    chart.Cursor = Cursors.Default;
            }
        }
        void SetNewPointValue(double newValue) {
            if(newValue < MinValue || (newValue > MaxRetailPriceValue && seriesName == "Retail Price") || newValue > MaxValue)
                return;

            switch(seriesName) {
                case "Production":
                    dataSource.UpdateProduction(currentItem, newValue);
                    break;
                case "Demand":
                    dataSource.UpdateDemand(currentItem, newValue);
                    break;
                case "Retail Price":
                    dataSource.UpdateCost(currentItem, newValue);
                    break;
            }
            UpdateTotalIncome();
        }
        void Chart_MouseUp(object sender, MouseEventArgs e) {
            if(currentItem != null)
                chart.RefreshData();
            currentItem = null;
            currentPane = null;
            seriesName = null;
        }
        void Chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            if(e.Series.Name != seriesName || e.SeriesPoint.Tag != currentItem)
                return;
            LineDrawOptions drawOptions = e.SeriesDrawOptions as LineDrawOptions;
            drawOptions.Marker.Size += 6;
        }
        void SeriesPointMovingDemo_Load(object sender, EventArgs e) {
            flyoutPanel1.ShowPopup();
        }
        void button1_Click(object sender, EventArgs e) {
            flyoutPanel1.HidePopup();
        }
    }
}
