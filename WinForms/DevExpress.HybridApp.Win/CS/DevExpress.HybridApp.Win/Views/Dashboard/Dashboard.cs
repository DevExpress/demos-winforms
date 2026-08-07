using System.Drawing;
using DevExpress.DevAV.ViewModels;
using DevExpress.Utils.MVVM.UI;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;

namespace DevExpress.DevAV.Views {
    [ViewType(DevAVDbViewModel.DashboardViewDocumentType)]
    public partial class DashboardView : XtraUserControl {
        public DashboardView() {
            InitializeComponent();
            if(!mvvmContext.IsDesignMode)
                InitBindings();
        }

        private void InitBindings() {
            var fluentAPI = mvvmContext.OfType<DashboardViewModel>();
            fluentAPI.SetObjectDataSourceBinding(salesBindingSource, x => x.DashboardOrders);
            fluentAPI.SetBinding(opportunitiesChartControl.Series[0], s => s.DataSource, x => x.SummaryOpportunities);

            fluentAPI.SetBinding(todayCostSimpleButton, x => x.Checked, x => x.SelectedGoodSoldPeriod, period => todayCostSimpleButton.Checked = period == GoodSoldPeriod.Today, btn => GoodSoldPeriod.Today);
            fluentAPI.SetBinding(monthCostSimpleButton, x => x.Checked, x => x.SelectedGoodSoldPeriod, period => monthCostSimpleButton.Checked = period == GoodSoldPeriod.ThisMonth, btn => GoodSoldPeriod.ThisMonth);
            fluentAPI.SetBinding(yearCostSimpleButton, x => x.Checked, x => x.SelectedGoodSoldPeriod, period => yearCostSimpleButton.Checked = period == GoodSoldPeriod.YTD, btn => GoodSoldPeriod.YTD);

            fluentAPI.SetBinding(costChartControl.Series[0], s => s.DataSource, x => x.CostSelectedItem);

            fluentAPI.SetBinding(todayRevenuesSimpleButton, x => x.Checked, x => x.SelectedRevenuePeriod, period => todayRevenuesSimpleButton.Checked = period == GoodSoldPeriod.Today, btn => GoodSoldPeriod.Today);
            fluentAPI.SetBinding(monthRevenuesSimpleButton, x => x.Checked, x => x.SelectedRevenuePeriod, period => monthRevenuesSimpleButton.Checked = period == GoodSoldPeriod.ThisMonth, btn => GoodSoldPeriod.ThisMonth);
            fluentAPI.SetBinding(yearRevenuesSimpleButton, x => x.Checked, x => x.SelectedRevenuePeriod, period => yearRevenuesSimpleButton.Checked = period == GoodSoldPeriod.YTD, btn => GoodSoldPeriod.YTD);

            fluentAPI.SetBinding(revenuesChartControl.Series[0], s => s.DataSource, x => x.SalesSummarySelectedItem);
        }

        private void revenuesChartControl_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            ChartControlLegendCustomPainter.Paint(e);
        }

        private void opportunitiesChartControl_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            ChartControlLegendCustomPainter.Paint(e);
        }
    }
    public class ChartControlLegendCustomPainter {
        public static void Paint(CustomDrawSeriesPointEventArgs e) {
            int imageSizeW = 18, imageSizeH = 14;
            var image = new Bitmap(imageSizeW, imageSizeH);
            using(var graphics = Graphics.FromImage(image)) {
                graphics.FillRectangle(new SolidBrush(e.LegendDrawOptions.Color), new Rectangle(new Point(0, 0), new Size(imageSizeW, imageSizeH)));
            }
            e.LegendMarkerImage = image;
            e.DisposeLegendMarkerImage = true;
            e.LegendMarkerVisible = true;
        }
    }
}
