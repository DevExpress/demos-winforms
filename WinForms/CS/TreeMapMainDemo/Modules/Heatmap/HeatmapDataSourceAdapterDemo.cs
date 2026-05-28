using System.Windows.Forms;
using DevExpress.XtraCharts.Heatmap;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HeatmapDataSourceAdapterDemo : TreeMapTutorialControl {
        public override Control ActiveDemoModule { get { return heatmapControl1; } }
        public HeatmapDataSourceAdapterDemo() {
            InitializeComponent();
            ((HeatmapDataSourceAdapter)heatmapControl1.DataAdapter).DataSource = Utils.CreateDataSet("BalanceOfTrade.xml");
        }
    }
}
