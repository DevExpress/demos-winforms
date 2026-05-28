using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DevExpress.DentalClinic.View {
    public partial class DashboardView : XtraUserControl {
        public DashboardView() {
            InitializeComponent();
            dashboardViewer1.DashboardItemControlCreated += DashboardViewerDashboardItemControlCreated;
            dashboardViewer1.DashboardItemBeforeControlDisposed += DashboardViewerDashboardItemBeforeControlDisposed;
        }
        void DashboardViewerDashboardItemControlCreated(object sender, DashboardWin.DashboardItemControlEventArgs e) {
            ChartControl chart = e.ChartControl;
            if(chart != null) {
                chart.CustomDrawCrosshair += ChartCustomDrawCrosshair;
            }
        }
        void DashboardViewerDashboardItemBeforeControlDisposed(object sender, DashboardWin.DashboardItemControlEventArgs e) {
            ChartControl chart = e.ChartControl;
            if(chart != null) {
                chart.CustomDrawCrosshair -= ChartCustomDrawCrosshair;
            }
        }
        void ChartCustomDrawCrosshair(object sender, CustomDrawCrosshairEventArgs e) {
            foreach(var group in e.CrosshairElementGroups) {
                group.HeaderElement.Text = string.Empty;
            }
        }
    }
}
