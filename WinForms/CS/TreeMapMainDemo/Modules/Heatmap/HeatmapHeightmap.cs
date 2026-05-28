using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraCharts.Heatmap;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class HeatmapHeightmap : TreeMapDemoModuleWithOptions {
        public override Control ActiveDemoModule { get { return heatmapControl1; } }
        public HeatmapHeightmap() {
            InitializeComponent();
            SetDataAdapter();
            InitializeColorizers();
        }

        void SetDataAdapter() {
            Bitmap image = new Bitmap(Utils.GetRelativePath("Heightmap.jpg"));
            double[,] matrix = new double[image.Height, image.Width];
            for(int i = 0; i < image.Height; i++)
                for(int j = 0; j < image.Width; j++)
                    matrix[i, j] = image.GetPixel(j, i).ToArgb();
            heatmapControl1.DataAdapter = new HeatmapMatrixAdapter() {
                XArguments = HeatmapDataSourceGenerator.GetArray(image.Width),
                YArguments = HeatmapDataSourceGenerator.GetArray(image.Height),
                Values = matrix
            };
        }
        void InitializeColorizers() {
            XtraCharts.Palette palette = new XtraCharts.Palette("Heightmap") {
                Color.FromArgb(105, 168, 204),
                Color.FromArgb(125, 205, 168),
                Color.FromArgb(180, 224, 149),
                Color.FromArgb(253, 204, 138),
                Color.FromArgb(251, 167, 86),
                Color.FromArgb(225, 123, 49),
                Color.FromArgb(199, 73, 25),
                Color.FromArgb(180, 43, 1)
            };

            colorizerComboBox.Properties.Items.AddRange(new RadioGroupItem[3] {
                new RadioGroupItem(CreateRangeStopColorProvider(palette, false), "Range"),
                new RadioGroupItem(CreateRangeStopColorProvider(palette, true), "Approximated Range"),
                new RadioGroupItem(new HeatmapObjectColorProvider(), "Object")
            });
            colorizerComboBox.SelectedIndex = 0;
        }
        HeatmapRangeColorProvider CreateRangeStopColorProvider(XtraCharts.Palette palette, bool approximateColors) {
            HeatmapRangeColorProvider rangeColorProvider = new HeatmapRangeColorProvider() { Palette = palette, ApproximateColors = approximateColors };
            for(int i = 0; i <= 6; i++)
                rangeColorProvider.RangeStops.Add(new HeatmapRangeStop(0.14 * i, HeatmapRangeStopType.Percentage));
            rangeColorProvider.RangeStops.Add(new HeatmapRangeStop(1, HeatmapRangeStopType.Percentage));
            return rangeColorProvider;
        }
        void ColorizerComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            heatmapControl1.ColorProvider = (HeatmapColorProviderBase)colorizerComboBox.EditValue;
        }
        void navigationCheckEdit_CheckedChanged(object sender, EventArgs e) {
            bool navigationEnable = navigationCheckEdit.Checked;
            heatmapControl1.EnableAxisXZooming = navigationEnable;
            heatmapControl1.EnableAxisYZooming = navigationEnable;
            heatmapControl1.EnableAxisXScrolling = navigationEnable;
            heatmapControl1.EnableAxisYScrolling = navigationEnable;
        }
    }
}
