using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace DevExpress.ApplicationUI.Demos {
    public partial class MaximizedWidgetControl : XtraEditors.XtraUserControl {
        Timer updateTimer = new Timer();
        int index = 0;
        public MaximizedWidgetControl() {
            InitializeComponent();
            if(components != null)
                components.Add(updateTimer);
            updateTimer.Interval = 1000;
            updateTimer.Tick += OnTimerTick;
            updateTimer.Start();
            for(int i = 0; i < 30; i++)
                AddNewSeriesPoint();
        }
        void OnTimerTick(object sender, EventArgs e) {
            AddNewSeriesPoint();
        }
        const int BeginDate = 40000;
        protected void AddNewSeriesPoint() {
            if(IsDisposed) {
                updateTimer.Stop(); 
                return;
            }
            chartControl1.BeginInit();
            chartControl2.BeginInit();
            StockData data = StockDataCreator.GetData(index);
            var points1 = chartControl1.Series[0].Points;
            SeriesPoint seriesPoint1 = new SeriesPoint(data.Date, (object)data.LowPrice, (object)data.HighPrice, (object)data.OpenPrice, (object)data.ClosePrice);
            points1.Add(seriesPoint1);
            int date = BeginDate;
            if(index > 40)
                date = BeginDate + index - 30;
            (chartControl1.Diagram as IXYDiagram2D).AxisX.WholeRange.SetMinMaxValues(DateTime.FromOADate(date), data.Date);
            (chartControl2.Diagram as IXYDiagram2D).AxisX.WholeRange.SetMinMaxValues(DateTime.FromOADate(date), data.Date);
            index++;
            var points2 = chartControl2.Series[0].Points;
            SeriesPoint seriesPoint2 = new SeriesPoint(data.Date, data.Volumne);
            points2.Add(seriesPoint2);
            Cleanup(points1, points2);
            chartControl1.EndInit();
            chartControl2.EndInit();
        }
        void Cleanup(SeriesPointCollection points1, SeriesPointCollection points2) {
            if(index > 40) {
                points1.RemoveAt(0);
                points2.RemoveAt(0);
            }
        }
    }
}
