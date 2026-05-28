using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Map;
using DevExpress.XtraCharts.Sankey;
using DevExpress.XtraMap;

namespace DevExpress.XtraSankey.Demos {
    public partial class Interaction : SankeyTutorialControl {
        readonly List<Export> data;
        readonly Dictionary<string, List<string>> continentCountriesPairs = new Dictionary<string, List<string>>();
        readonly Dictionary<string, Color> continentColorPairs = new Dictionary<string, Color>();

        Dictionary<string, List<Export>> countryNameExportPairs = new Dictionary<string, List<Export>>();
        Dictionary<string, MapItem> countryNameMapItemPairs = new Dictionary<string, MapItem>();
        Dictionary<Export, MapShape> exportMapArrowPairs = new Dictionary<Export, MapShape>();
        bool updateSelectedArrows = true;
        HashSet<Export> selectedExportItems = new HashSet<Export>();
        public override SankeyDiagramControl SankeyDiagramControl {
            get { return sankeyDiagramControl1; }
        }
        public Interaction() {
            InitializeComponent();
            InitContinentColorPairs();
            InitContinentCountriesPairs();
            data = OilTradeDataGenerator.GetData();
            sankeyDiagramControl1.DataSource = data;
            sankeyDiagramControl1.Colorizer = new ContinentColorizer(continentColorPairs, continentCountriesPairs);
            shapefileDataAdapter1.FileUri = Utils.GetFileUri("Countries.shp");
            backgroundLayer.Data = new ShapefileDataAdapter() { FileUri = Utils.GetFileUri("Countries.shp") };
            InitMapColorizer();
            updateSelectedArrows = false;
            gridControl1.DataSource = data;
            gridView1.ClearSelection();
            updateSelectedArrows = true;
        }
        void InitContinentColorPairs() {
            continentColorPairs.Add("North America", Color.FromArgb(29, 178, 245));
            continentColorPairs.Add("South and Central America", Color.FromArgb(151, 201, 92));
            continentColorPairs.Add("Europe", Color.FromArgb(255, 199, 32));
            continentColorPairs.Add("CIS", Color.FromArgb(44, 115, 255));
            continentColorPairs.Add("Middle East", Color.FromArgb(186, 85, 211));
            continentColorPairs.Add("West Africa", Color.FromArgb(255, 126, 32));
            continentColorPairs.Add("North Africa", Color.FromArgb(51, 204, 170));
            continentColorPairs.Add("Africa", Color.FromArgb(103, 113, 220));
            continentColorPairs.Add("Australasia", Color.FromArgb(198, 144, 83));
            continentColorPairs.Add("Asia Pacific", Color.FromArgb(245, 86, 74));
        }
        void InitContinentCountriesPairs() {
            continentCountriesPairs.Add("North America", new List<string>() {
                "United States",
                "Canada",
                "Mexico",
            });
            continentCountriesPairs.Add("South and Central America", new List<string>() {
                "Brazil",
                "Argentina",
            });
            continentCountriesPairs.Add("Australasia", new List<string>() {
                "Australia",
            });
            continentCountriesPairs.Add("Europe", new List<string>() {
                "Netherlands",
                "Germany",
                "United Kingdom",
                "Italy",
                "France",
                "Spain",
                "United Kingdom",
            });
            continentCountriesPairs.Add("Asia Pacific", new List<string>() {
                "Japan",
                "South Korea",
                "India",
                "Singapore",
                "Other Asia Pacific",
            });
            continentCountriesPairs.Add("Middle East", new List<string>() {
                "Saudi Arabia",
                "UAE",
                "United Arab Emirates",
                "Kuwait",
                "Iraq",
                //"Other Middle East",
            });
        }
        void InitMapColorizer() {
            KeyColorColorizer colorizer = (KeyColorColorizer)interactableItemsLayer.Colorizer;
            colorizer.Colors.AddRange(continentColorPairs.Values);
            foreach(var continentColorPair in continentColorPairs)
                colorizer.Keys.Add(new ColorizerKeyItem() { Key = continentColorPair.Key, Name = continentColorPair.Key });
        }
        void Adapter_ItemsLoaded(object sender, ItemsLoadedEventArgs e) {
            Dictionary<string, List<CoordPoint>> territoryNameCenterCoordPairs = GetTerritoryCenterPoints(e.Items);
            CreateArrows(territoryNameCenterCoordPairs);
            DisableUnknownItems(e.Items);
            mapControl1.ZoomToFit(e.Items, 0);
        }
        void DisableUnknownItems(IList<MapItem> mapItems) {
            foreach(var mapItem in mapItems) {
                string countryName = mapItem.Attributes["NAME"].Value.ToString();
                if(countryNameExportPairs.ContainsKey(countryName))
                    continue;
                countryName = mapItem.Attributes["CONTINENT"].Value.ToString();
                if(!countryNameExportPairs.ContainsKey(countryName))
                    mapItem.Visible = false;
            }
        }
        Dictionary<string, List<CoordPoint>> GetTerritoryCenterPoints(IList<MapItem> mapItems) {
            var territoryNameCenterCoordPairs = new Dictionary<string, List<CoordPoint>>();
            List<string> nodeNames = data.Select(export => export.Exporter)
                                               .Union(data.Select(export => export.Importer))
                                               .ToList();
            foreach(var mapItem in mapItems) {
                string countryName = mapItem.Attributes["NAME"].Value.ToString();
                if(!nodeNames.Contains(countryName))
                    countryName = mapItem.Attributes["CONTINENT"].Value.ToString();
#pragma warning disable CA1864
                if(!countryNameMapItemPairs.ContainsKey(countryName))
                    countryNameMapItemPairs.Add(countryName, mapItem);
#pragma warning restore CA1864
                List<CoordPoint> buffPoints = null;
                if(!territoryNameCenterCoordPairs.TryGetValue(countryName, out buffPoints)) {
                    buffPoints = new List<CoordPoint>();
                    territoryNameCenterCoordPairs.Add(countryName, buffPoints);
                }
                foreach(MapPathSegment segment in ((MapPath)mapItem).Segments)
                    buffPoints.AddRange(segment.Points);
            }
            return territoryNameCenterCoordPairs;
        }
        void CreateArrows(Dictionary<string, List<CoordPoint>> territoryNameCenterCoordPairs) {
            foreach(var export in data) {
                GeoPoint startPoint = GetAveragePoint(territoryNameCenterCoordPairs[export.Exporter]);
                GeoPoint endPoint = GetAveragePoint(territoryNameCenterCoordPairs[export.Importer]);

                var polyline = new MapPolyline();
                polyline.Points.AddRange(new GeoPoint[] {
                    startPoint,
                    endPoint
                });
                SetPolylineDrawOptions(polyline);
                mapItemStorage1.Items.Add(polyline);
                List<Export> exports = null;
                if(!countryNameExportPairs.TryGetValue(export.Exporter, out exports))
                    countryNameExportPairs.Add(export.Exporter, exports = new List<Export>());
                exports.Add(export);
                exportMapArrowPairs.Add(export, polyline);
            }
        }
        void SetPolylineDrawOptions(MapPolyline shape) {
            shape.EndLineCap.Visible = true;
            shape.IsGeodesic = true;
            shape.Fill = Color.FromArgb(255, 209, 28, 28);
            shape.Stroke = Color.FromArgb(255, 209, 28, 28);
            shape.StrokeWidth = 2;
            shape.Visible = false;
        }
        GeoPoint GetAveragePoint(List<CoordPoint> points) {
            double longitudeSum = 0, latitudeSum = 0;
            foreach(GeoPoint point in points) {
                longitudeSum += point.Longitude;
                latitudeSum += point.Latitude;
            }
            return new GeoPoint(latitudeSum / points.Count, longitudeSum / points.Count);
        }
        void HideAllUnselectedArrows() {
            if(exportMapArrowPairs.Count > 0) {
                foreach(var linkTagMapArrowPair in exportMapArrowPairs) {
                    if(selectedExportItems == null || !selectedExportItems.Contains(linkTagMapArrowPair.Key))
                        linkTagMapArrowPair.Value.Visible = false;
                }
            }
        }
        void SetArrowVisibilityByExport(IEnumerable<Export> items, bool visible) {
            MapShape shape = null;
            foreach(Export link in items) {
                if(exportMapArrowPairs.TryGetValue(link, out shape))
                    shape.Visible = visible;
            }
        }
        void UpdateSelection(Action action) {
            updateSelectedArrows = false;
            action();
            updateSelectedArrows = true;
            SetArrowVisibilityByExport(selectedExportItems, true);
            HideAllUnselectedArrows();
        }
        void SetGridSelectedItems() {
            selectedExportItems.Clear();
            gridView1.GetSelectedRows();
            foreach(int rowIndex in gridView1.GetSelectedRows())
                selectedExportItems.Add((Export)gridView1.GetRow(rowIndex));
        }
        void SetSankeySelectedItems() {
            selectedExportItems.Clear();
            foreach(var item in SankeyDiagramControl.SelectedItems) {
                var export = item as Export;
                if(export != null)
                    selectedExportItems.Add(export);
            }
        }
        void SetMapSelectedItems(IList<object> mapItems) {
            selectedExportItems.Clear();
            foreach(MapItem mapItem in mapItems) {
                string countryName = mapItem.Attributes["NAME"].Value.ToString();
                if(!countryNameExportPairs.ContainsKey(countryName))
                    countryName = mapItem.Attributes["CONTINENT"].Value.ToString();
                foreach(var export in countryNameExportPairs[countryName])
                    selectedExportItems.Add(export);
            }
        }
        void OnCustomizeNodeToolTip(object sender, CustomizeSankeyNodeToolTipEventArgs e) {
            var text = new StringBuilder();
            var totalImportAndExportText = new StringBuilder();
            if(e.Node.InputLinks != null && e.Node.InputLinks.Count > 0) {
                totalImportAndExportText.Append(string.Format("Total import: {0} million tonnes", e.Node.InputLinks.Select(link => link.TotalWeight).Sum()));
                totalImportAndExportText.AppendLine();
                text.Append("Import:");
                text.AppendLine();
                foreach(var inputLink in e.Node.InputLinks) {
                    text.Append(string.Format("{0} million tonnes from {1}", inputLink.TotalWeight, inputLink.SourceNode.Tag));
                    text.AppendLine();
                }
            }
            if(text.Length != 0)
                text.AppendLine();
            if(e.Node.OutputLinks != null && e.Node.OutputLinks.Count > 0) {
                totalImportAndExportText.Append(string.Format("Total export: {0} million tonnes", e.Node.OutputLinks.Select(link => link.TotalWeight).Sum()));
                totalImportAndExportText.AppendLine();
                text.Append("Export:");
                text.AppendLine();
                foreach(var outputLink in e.Node.OutputLinks) {
                    text.Append(string.Format("{0} million tonnes to {1}", outputLink.TotalWeight, outputLink.TargetNode.Tag));
                    text.AppendLine();
                }
            }
            if(totalImportAndExportText.Length != 0)
                totalImportAndExportText.AppendLine();
            e.Content = totalImportAndExportText.ToString() + text.ToString().TrimEnd('\n');
        }
        void OnCustomizeLinkToolTip(object sender, CustomizeSankeyLinkToolTipEventArgs e) {
            e.Content = e.Link.TotalWeight + " million tonnes";
        }
        void OnSankeyHighlightedItemsChanged(object sender, SankeyHighlightedItemsChangedEventArgs e) {
            var highlightedTags = e.HighlightedLinks.Select(x => (Export)x.Tags[0]);
            HideAllUnselectedArrows();
            SetArrowVisibilityByExport(highlightedTags, true);
        }
        void OnSankeySelectedItemsChanged(object sender, SankeySelectedItemsChangedEventArgs e) {
            if(!updateSelectedArrows)
                return;
            SetSankeySelectedItems();
            UpdateSelection(() => {
                gridView1.ClearSelection();
                interactableItemsLayer.SelectedItems.Clear();
                foreach(var export in selectedExportItems) {
                    gridView1.SelectRow(gridView1.FindRow(export));
                    var mapItem = countryNameMapItemPairs[export.Exporter];
                    if(!interactableItemsLayer.SelectedItems.Contains(mapItem))
                        interactableItemsLayer.SelectedItems.Add(mapItem);
                    mapItem = countryNameMapItemPairs[export.Importer];
                    if(!interactableItemsLayer.SelectedItems.Contains(mapItem))
                        interactableItemsLayer.SelectedItems.Add(mapItem);
                }
            });
        }
        void OnGridSelectionChanged(object sender, Data.SelectionChangedEventArgs e) {
            if(!updateSelectedArrows)
                return;
            SetGridSelectedItems();
            UpdateSelection(() => {
                SankeyDiagramControl.SelectedItems.Clear();
                interactableItemsLayer.SelectedItems.Clear();
                foreach(var export in selectedExportItems) {
                    SankeyDiagramControl.SelectedItems.Add(export);
                    var mapItem = countryNameMapItemPairs[export.Exporter];
                    if(!interactableItemsLayer.SelectedItems.Contains(mapItem))
                        interactableItemsLayer.SelectedItems.Add(mapItem);
                    mapItem = countryNameMapItemPairs[export.Importer];
                    if(!interactableItemsLayer.SelectedItems.Contains(mapItem))
                        interactableItemsLayer.SelectedItems.Add(mapItem);
                }
            });
        }
        void OnMapSelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            if(!updateSelectedArrows)
                return;
            SetMapSelectedItems(e.Selection);
            UpdateSelection(() => {
                gridView1.ClearSelection();
                SankeyDiagramControl.SelectedItems.Clear();
                foreach(var export in selectedExportItems) {
                    gridView1.SelectRow(gridView1.FindRow(export));
                    SankeyDiagramControl.SelectedItems.Add(export);
                }
            });
        }
        void mapControl1_Resize(object sender, EventArgs e) {
            mapControl1.ZoomToFitLayerItems(0);
        }
    }
}
