using System;
using System.Collections.Generic;
using DevExpress.Data.Utils;
using DevExpress.DXperience.Demos;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Views;

namespace DevExpress.XtraCharts.Demos {
    public partial class PanesDemo : ChartDemoModule {
        ChartControl activeChart = new ChartControl();

        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() { chartLinearLayout, chartGridLayout };
            }
        }
        internal override ChartControl ChartControl {
            get {
                return activeChart;
            }
        }

        public PanesDemo() {
            InitializeComponent();
            List<WebSitePerformanceIndicatorItem> data = GetData();
            chartLinearLayout.DataSource = data;
            chartGridLayout.DataSource = data;
        }
        List<WebSitePerformanceIndicatorItem> GetData() {
            List<WebSitePerformanceIndicatorItem> data = new List<WebSitePerformanceIndicatorItem>();
            DateTime lastDate = TutorialConstants.Now.AddDays(-1);
            NonCryptographicRandom random = TutorialConstants.Random;
            for(int i = 0; i < 30; i++) {
                int newVisitors = random.Next(18, 77);
                data.Add(new WebSitePerformanceIndicatorItem() {
                    ReportDate = lastDate.AddDays(-i),
                    TrafficTime = random.Next(3, 12),
                    ResponseTime = random.Next(40, 110),
                    AveragePageLoadTime = random.NextDouble() * 3 + 0.5,
                    MemoryUsage = random.Next(500, 2000),
                    CPUUsage = random.Next(10, 77),
                    ClientErrors = random.Next(2, 45),
                    ServerErrors = random.Next(2, 7),
                    NewVisitors = newVisitors,
                    ReturnVisitors = random.Next(10, newVisitors)
                });
            }
            return data;
        }
        void tabbedView_DocumentActivated(object sender, DocumentEventArgs e) {
            activeChart = ((DockPanel)e.Document.Control).ControlContainer.Controls[0] as ChartControl;
            activeChart.Animate();
        }
        void TabbedView_PopupMenuShowing(object sender, XtraBars.Docking2010.Views.PopupMenuShowingEventArgs e) {
            e.Cancel = e.GetDocument() != null;
        }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            documentManager.View.Controller.Activate(documentLinearPaneLayout);
        }

    }

    public class WebSitePerformanceIndicatorItem {
        public DateTime ReportDate { get; set; }
        public int TrafficTime { get; set; } //s
        public int ResponseTime { get; set; } //ms
        public double AveragePageLoadTime { get; set; } //s
        public int MemoryUsage { get; set; } //MB
        public int CPUUsage { get; set; } //percent
        public int ClientErrors { get; set; }
        public int ServerErrors { get; set; }
        public int NewVisitors { get; set; }
        public int ReturnVisitors { get; set; }
    }
}
