using System;
using System.Data;
using System.Drawing;

namespace DevExpress.XtraMap.Demos {
    public partial class HeatMap : FooteredMapTutorialControl {
        HeatmapDataSourceAdapter Adapter { get { return (HeatmapDataSourceAdapter)heatmapProvider1.PointSource; } }
        ChoroplethColorizer ActualColorizer {
            get { return heatmapProvider1.Colorizer; }
            set { heatmapProvider1.Colorizer = value; }
        }

        protected override Image CopyrightImage { get { return DemoUtils.AzureLogo; } }
        protected override string CopyrightText { get { return DemoUtils.AzureCopyright; } }
        public override MapControl MapControl { get { return mapControl1; } }

        public HeatMap() {
            InitializeComponent();
            DemoUtils.SetAzureMapDataProviderKey(AzureMapDataProvider);
            tabPaneOptions.AllowCollapse = Utils.DefaultBoolean.True;
            paletteRadioGroup.SelectedIndex = 1;
            LoadData();
        }

        void LoadData() {
            DataSet xmlDataSet = new DataSet("XML DataSet");
            xmlDataSet.ReadXml(DemoUtils.GetRelativePath("Earthquakes.xml"));
            Adapter.DataSource = xmlDataSet.Tables["Row"];
        }

        void OnLegendItemCreating(object sender, LegendItemCreatingEventArgs e) {
            int endIndex = ActualColorizer != null ? ActualColorizer.ColorItems.Count - 1 : 3;
            if(e.Index == 0)
                e.Item.Text = "low";
            else if(e.Index == endIndex)
                e.Item.Text = "high";
            else
                e.Item.Text = " ";
        }
        void OnTrackBarControlEditValueChanged(object sender, EventArgs e) {
            ((HeatmapDensityBasedAlgorithm)heatmapProvider1.Algorithm).PointRadius = (int)mfTrackBarControl1.EditValue;
        }
        void OnPaletteTypeSelectedIndexChanged(object sender, EventArgs e) {
            ActualColorizer = ObtainColorizer(paletteRadioGroup.SelectedIndex);
        }
        ChoroplethColorizer ObtainColorizer(int index) {
            switch(index) {
                case 1:
                    return CreateHotColorizer();
                case 2:
                    return CreateColdColorizer();
                default:
                    return null;
            }
        }
        ChoroplethColorizer CreateHotColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new double[] { 0.1, 0.2, 0.7, 1 });
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(50, 128, 255, 0)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 255, 255, 0)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 234, 72, 58)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 162, 36, 25)));
            colorizer.ApproximateColors = true;
            return colorizer;
        }
        ChoroplethColorizer CreateColdColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new double[] { 0, 0.2, 0.4, 0.6, 0.8, 1 });
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(0, 33, 102, 172)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 103, 169, 207)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 209, 229, 240)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 253, 219, 199)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 239, 138, 98)));
            colorizer.ColorItems.Add(new ColorizerColorItem(Color.FromArgb(255, 178, 24, 43)));
            colorizer.ApproximateColors = true;
            return colorizer;
        }
        protected override void InitRibbon() {
            base.InitRibbon();
            ChkShowMinimap.Enabled = false;
        }
    }
}
