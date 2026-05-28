using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;

namespace DevExpress.XtraMap.Demos {

    public partial class ImportExport : MapTutorialControl {
        const string PoliticalToolTipPattern = "{NAME}";
        const string GdpToolTipPattern = "{NAME}: ${GDP_MD_EST:#,0}M";
        const string PopulationToolTipPattern = "{NAME}: {POP_EST:#,##0,,}M";

        ChoroplethColorizer politicalColorizer;
        ChoroplethColorizer gdpColorizer;
        ChoroplethColorizer populationColorizer;
        ColorScaleLegend gdpLegend;
        ColorListLegend populationLegend;
        LegendAlignment legendAlignment;

        ChoroplethColorizer PoliticalColorizer {
            get {
                if(politicalColorizer == null)
                    politicalColorizer = CreatePoliticalColorizer();
                return politicalColorizer;
            }
        }
        ChoroplethColorizer GdpColorizer {
            get {
                if(gdpColorizer == null)
                    gdpColorizer = CreateGDPColorizer();
                return gdpColorizer;
            }
        }
        ChoroplethColorizer PopulationColorizer {
            get {
                if(populationColorizer == null)
                    populationColorizer = CreatePopulationColorizer();
                return populationColorizer;
            }
        }
        ColorScaleLegend GdpLegend {
            get {
                if(gdpLegend == null)
                    gdpLegend = CreateGDPLegend();
                return gdpLegend;
            }
        }
        ColorListLegend PopulationLegend {
            get {
                if(populationLegend == null)
                    populationLegend = CreatePopulationLegend();
                return populationLegend;
            }
        }
        ItemsLayerLegend Legend {
            get { return MapControl.Legends.Count > 0 ? (ItemsLayerLegend)MapControl.Legends[0] : null; }
            set {
                if(MapControl.Legends.Count > 0)
                    MapControl.Legends.RemoveAt(0);
                if(value != null)
                    MapControl.Legends.Add(value);
            }
        }

        public override MapControl MapControl { get { return mapControl1; } }

        public ImportExport() {
            InitializeComponent();
            ShapefileDataAdapter.FileUri = DemoUtils.GetFileUri("Countries.shp");
            chkGDP.Checked = true;
        }

        ChoroplethColorizer CreatePoliticalColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new List<double> { 0, 9 });
            colorizer.PredefinedColorSchema = PredefinedColorSchema.Palette;
            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "MAP_COLOR" };
            colorizer.ApproximateColors = true;
            return colorizer;
        }
        ChoroplethColorizer CreateGDPColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new List<double> { 0, 3000, 10000, 18000, 28000, 44000, 82000, 185000, 1000000, 2500000, 15000000 });
            List<Color> colors = new List<Color> { Color.FromArgb(0x5F, 0x8B, 0x95), Color.FromArgb(0x79, 0x96, 0x89), Color.FromArgb(0xA2, 0xA8, 0x75), Color.FromArgb(0xCE, 0xBB, 0x5F),
                                                        Color.FromArgb(0xF2, 0xCB, 0x4E), Color.FromArgb(0xF1, 0xC1, 0x49), Color.FromArgb(0xE5, 0xA8, 0x4D), Color.FromArgb(0xD6, 0x86, 0x4E),
                                                        Color.FromArgb(0xC5, 0x64, 0x50), Color.FromArgb(0xBA, 0x4D, 0x51)};
            colorizer.ColorItems.AddRange(GetColorItems(colors));
            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "GDP_MD_EST" };
            colorizer.ApproximateColors = true;
            return colorizer;
        }
        GenericColorizerItemCollection<ColorizerColorItem> GetColorItems(List<Color> colors) {
            GenericColorizerItemCollection<ColorizerColorItem> result = new GenericColorizerItemCollection<ColorizerColorItem>();
            result.BeginUpdate();
            try {
                foreach(Color color in colors)
                    result.Add(new ColorizerColorItem(color));
            }
            finally {
                result.EndUpdate();
            }
            return result;
        }
        ColorScaleLegend CreateGDPLegend() {
            ColorScaleLegend legend = new ColorScaleLegend();
            legend.Header = "GDP by Countries";
            legend.Description = "In US dollars";
            legend.RangeStopsFormat = "0,B";
            legend.Layer = FileLayer;
            return legend;
        }
        ChoroplethColorizer CreatePopulationColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new List<double> { 0, 1000000, 2000000, 5000000, 10000000, 25000000, 50000000, 100000000, 1000000000, 1500000000 });
            colorizer.PredefinedColorSchema = PredefinedColorSchema.Gradient;
            colorizer.ValueProvider = new ShapeAttributeValueProvider() { AttributeName = "POP_EST" };
            colorizer.ApproximateColors = true;
            return colorizer;
        }
        ColorListLegend CreatePopulationLegend() {
            ColorListLegend legend = new ColorListLegend();
            legend.RangeStopsFormat = "0,,M";
            legend.Header = "";
            legend.Description = "";
            legend.Layer = FileLayer;
            return legend;
        }
        void UpdateMapColorizer(MapColorizer colorizer, string toolTipPattern) {
            FileLayer.Colorizer = colorizer;
            FileLayer.ToolTipPattern = toolTipPattern;
            UpdateLegendAligment();
        }
        void UpdateMapLegend(ItemsLayerLegend legend) {
            Legend = legend;
        }
        void MapMode_CheckedChanged(object sender, XtraBars.ItemClickEventArgs e) {
            if(chkPolitical.Checked) {
                UpdateMapLegend(null);
                UpdateMapColorizer(PoliticalColorizer, PoliticalToolTipPattern);
            }
            else if(chkGDP.Checked) {
                UpdateMapLegend(GdpLegend);
                UpdateMapColorizer(GdpColorizer, GdpToolTipPattern);
            }
            else {
                UpdateMapLegend(PopulationLegend);
                UpdateMapColorizer(PopulationColorizer, PopulationToolTipPattern);
            }
            bbLegendAlignment.Enabled = FileLayer.Colorizer != PoliticalColorizer;
        }
        LegendAlignment GetLegendAlignment(string value) {
            LegendAlignment alignment;
            Enum.TryParse<LegendAlignment>(value, out alignment);
            return alignment;
        }
        void UpdateLegendAligment() {
            ChoroplethColorizer choroplethColorizer = FileLayer.Colorizer as ChoroplethColorizer;
            if(choroplethColorizer != null && Legend != null) {
                Legend.Alignment = legendAlignment;
            }
        }
        void Export_ItemClick(object sender, ItemClickEventArgs e) {
            btnExportShape.Caption = "Export Shapes To " + e.Item.Caption;
            btnExportShape.Tag = e.Item.Tag;
        }
        void btnExportShape_ItemClick(object sender, XtraBars.ItemClickEventArgs e) {
            string format = (string)btnExportShape.Tag;
            saveFileDialog1.Filter = string.Format("{0} files (*.{1})|*.{1}", format.ToUpper(), format);
            saveFileDialog1.FileName = string.Empty;
            if(saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            switch(format) {
                case "shp": FileLayer.ExportToShp(saveFileDialog1.FileName, new ShpExportOptions() { ExportToDbf = true, ShapeType = ShapeType.Polygon }); break;
                case "kml": FileLayer.ExportToKml(saveFileDialog1.FileName); break;
                case "svg": FileLayer.ExportToSvg(saveFileDialog1.FileName); break;
            }
            XtraMessageBox.Show(ParentForm, string.Format("Shapes successfully exported to {0} file", saveFileDialog1.FileName), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        void ddLegendAligment_GalleryItemClick(object sender, XtraBars.Ribbon.GalleryItemClickEventArgs e) {
            legendAlignment = GetLegendAlignment(e.Item.Caption);
            UpdateLegendAligment();
        }
        protected override MiniMapLayerBase CreateMiniMapLayer() {
            ShapefileDataAdapter adapter = new ShapefileDataAdapter() { FileUri = DemoUtils.GetFileUri("Countries.shp") };
            return new MiniMapVectorItemsLayer() { Data = adapter };
        }
    }
}
