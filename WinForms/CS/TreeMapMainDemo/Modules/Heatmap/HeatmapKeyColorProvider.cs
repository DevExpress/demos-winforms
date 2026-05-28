using System.Windows.Forms;
using DevExpress.Charts.Heatmap;
using DevExpress.Utils;
using DevExpress.XtraCharts.Heatmap;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HeatmapKeyColorProvider : TreeMapTutorialControl {
        public override Control ActiveDemoModule { get { return heatmapControl1; } }
        public HeatmapKeyColorProvider() {
            InitializeComponent();
            ((HeatmapDataSourceAdapter)heatmapControl1.DataAdapter).DataSource = Utils.CreateDataSet("PerformanceMonitoring.xml");
        }

        void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            HeatmapCell cell = (HeatmapCell)e.SelectedObject;
            SuperToolTip superToolTip = new SuperToolTip();
            superToolTip.Items.Add(new ToolTipItem() { Text = string.Format("Date: {0}", cell.XArgument) });
            superToolTip.Items.Add(new ToolTipItem() { Text = string.Format("Operation: {0}", cell.YArgument) });
            superToolTip.Items.Add(new ToolTipItem() { Text = string.Format("Response Time: {0}", cell.ColorValue) });
            e.SuperTip = superToolTip;
        }
    }
}
