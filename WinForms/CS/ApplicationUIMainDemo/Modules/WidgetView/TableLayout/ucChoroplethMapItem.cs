using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace DevExpress.ApplicationUI.Demos {
    public partial class ucChoroplethMapItem : XtraEditors.XtraUserControl {
        public ucChoroplethMapItem() {
            InitializeComponent();
            VectorItemsLayer baseLayer = new VectorItemsLayer();
            var dataAdapter = CreateShapefileDataAdapter();
            baseLayer.Data = dataAdapter;
            baseLayer.EnableHighlighting = false;
            baseLayer.SelectedItemStyle.StrokeWidth = 0;
            mapControl1.Layers.Add(baseLayer);
            VectorItemsLayer fileLayer = new VectorItemsLayer();
            dataAdapter = CreateShapefileDataAdapter();
            dataAdapter.ItemsLoaded += OnFileLoaded;
            fileLayer.Data = dataAdapter;
            fileLayer.Colorizer = CreateGDPColorizer();
            fileLayer.ToolTipPattern = "{NAME}";
            mapControl1.Layers.Add(fileLayer);
        }

        ShapefileDataAdapter CreateShapefileDataAdapter() {
            ShapefileDataAdapter adapter = new ShapefileDataAdapter();
            string path = DataLoader.GetRelativePath("USA.shp");
            if(!string.IsNullOrEmpty(path))
                adapter.FileUri = new System.Uri(path, System.UriKind.Absolute);
            return adapter;
        }
        void OnFileLoaded(object sender, ItemsLoadedEventArgs e) {
            foreach(var _item in e.Items) {
                MapItemAttribute attr = new MapItemAttribute();
                attr.Name = "RevenueYTD";
                var value = SalesPerformanceDataGenerator.Current.TotalSales.Where(d => string.Equals(d.State, _item.Attributes["NAME"].Value.ToString())).Sum(d => d.RevenueYTD);
                attr.Value = value;
                if(value == 0)
                    _item.Visible = false;
                _item.Attributes.Add(attr);
            }
        }
        GenericColorizerItemCollection<ColorizerColorItem> GetColorItems(List<Color> colors) {
            GenericColorizerItemCollection<ColorizerColorItem> result = new GenericColorizerItemCollection<ColorizerColorItem>();
            result.BeginUpdate();
            try {
                foreach(Color color in colors)
                    result.Add(new ColorizerColorItem(color));
            } finally {
                result.EndUpdate();
            }
            return result;
        }
        ChoroplethColorizer CreateGDPColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "RevenueYTD" };
            colorizer.RangeStops.AddRange(new List<double> { 0, 1000000, 2000000, 3000000, 4000000, 5000000, 6000000, 7000000, 8000000, 9000000, 10000000 });
            List<Color> colors = new List<Color> { Color.FromArgb(0x5F, 0x8B, 0x95), Color.FromArgb(0x79, 0x96, 0x89), Color.FromArgb(0xA2, 0xA8, 0x75), Color.FromArgb(0xCE, 0xBB, 0x5F),
                                                        Color.FromArgb(0xF2, 0xCB, 0x4E), Color.FromArgb(0xF1, 0xC1, 0x49), Color.FromArgb(0xE5, 0xA8, 0x4D), Color.FromArgb(0xD6, 0x86, 0x4E),
                                                        Color.FromArgb(0xC5, 0x64, 0x50), Color.FromArgb(0xBA, 0x4D, 0x51)};
            colorizer.ColorItems.AddRange(GetColorItems(colors));
            return colorizer;
        }
        MapItem item;
        void OnMapItemClick(object sender, MapItemClickEventArgs e) {
            var attr = e.Item.Attributes["RevenueYTD"];
            if(attr == null) {
                (mapControl1.Layers[1] as VectorItemsLayer).SelectedItem = item;
                return;
            }
            item = e.Item;
            SalesPerformanceDataGenerator.Current.Filter = e.Item.Attributes["NAME"].Value.ToString();
        }
    }

}
