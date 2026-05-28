using System;
using DevExpress.XtraCharts.Heatmap;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HeatmapLargeDataSource : TreeMapTutorialControl {
        readonly HeatmapDataSourceGenerator dataGenerator;

        HeatmapMatrixAdapter DataAdapter { get { return (HeatmapMatrixAdapter)heatmapControl1.DataAdapter; } }

        public HeatmapLargeDataSource() {
            InitializeComponent();

            dataGenerator = new HeatmapDataSourceGenerator();

            heatmapControl1.DataAdapter = new HeatmapMatrixAdapter() {
                XArguments = HeatmapDataSourceGenerator.GetArray(HeatmapDataSourceGenerator.SizeX),
                YArguments = HeatmapDataSourceGenerator.GetArray(HeatmapDataSourceGenerator.SizeY)
            };

            timer1.Interval = 100;
            timer1.Start();
        }

        void OnTimerTick(object sender, EventArgs e) {
            if(Visible) {
                DataAdapter.Values = dataGenerator.GetMatrix();
            }
        }
    }
}
