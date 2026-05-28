using System;
using System.Collections.Generic;
using System.Runtime;
using DevExpress.XtraSplashScreen;

namespace DevExpress.XtraCharts.Demos {
    public partial class LargeDataSourceDemo : ChartDemoModuleWithOptions {
        const int InitialPointsCount = 2500000;

        int totalPointsCount = 0;
        int seriesIndex = 1;

        internal override ChartControl ChartControl {
            get { return chart; }
        }
        internal override bool ChartDesignerEnabled {
            get { return false; }
        }

        public LargeDataSourceDemo() {
            InitializeComponent();
            XYDiagram2D diagram = ChartControl.Diagram as DevExpress.XtraCharts.XYDiagram2D;
            diagram.ZoomingOptions.AxisXMaxZoomPercent = 100000000;
            diagram.ZoomingOptions.AxisYMaxZoomPercent = 100000000;
            totalPointsCount = 0;
            AddSeries(InitialPointsCount, false);
        }

        IOverlaySplashScreenHandle ShowProgressPanel() {
            return SplashScreenManager.ShowOverlayForm(this, OverlayWindowOptions.Default);
        }
        void CloseProgressPanel(IOverlaySplashScreenHandle handle) {
            SplashScreenManager.CloseOverlayForm(handle);
        }
        void AddSeries(int pointsCount, bool showProgressPanel) {
            IOverlaySplashScreenHandle progressPanelHandle = null;
            if(showProgressPanel)
                progressPanelHandle = ShowProgressPanel();
            try {
                Series series = new Series();
                series.Name = "Series " + seriesIndex++;
                ResamplingDataAdapter adapter = new ResamplingDataAdapter() { DataSorted = true };
                adapter.DataSource = LargeDataGenerator.GenerateSeriesDataSourceSine(pointsCount);
                adapter.SetDataMembers("Argument", "Value");
                series.DataAdapter = adapter;
                series.CrosshairLabelPattern = "{S}:\t{V:0.0}";
                series.View = new SwiftPlotSeriesView();
                ChartControl.Series.Add(series);
                totalPointsCount += pointsCount;
                ChartControl.Titles[1].Text = string.Format("Total Points Count: {0:#,0.}", totalPointsCount);
            }
            catch(OutOfMemoryException) {
                List<Series> seriesList = new List<Series>(chart.Series.ToArray());
                chart.Series.Clear();
                foreach(Series series in seriesList)
                    ((DataSourceAdapter)series.DataAdapter).DataSource = null;
                totalPointsCount = 0;
                GCSettings.LargeObjectHeapCompactionMode = GCLargeObjectHeapCompactionMode.CompactOnce;
                GC.Collect(2, GCCollectionMode.Forced);
                GC.WaitForFullGCComplete();
                AddSeries(pointsCount, showProgressPanel);
            }
            finally {
                if(progressPanelHandle != null)
                    CloseProgressPanel(progressPanelHandle);
            }
        }
        void btnAdd250K_Click(object sender, EventArgs e) {
            AddSeries(250000, true);
        }
        void btnAdd500K_Click(object sender, EventArgs e) {
            AddSeries(500000, true);
        }
        void btnAdd1M_Click(object sender, EventArgs e) {
            AddSeries(1000000, true);
        }
    }
}
