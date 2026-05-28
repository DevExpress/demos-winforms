using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;
using DevExpress.XtraCharts;
using DevExpress.XtraMap;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class Selection : TreeMapTutorialControl {
        const byte AlphaColor = 128;
        const string ChartTitle = "GDP Dynamic";
        bool isSelectionLocked = false;
        readonly List<CountryStatisticInfo> countries;

        VectorItemsLayer BackgroundLayer { get { return (VectorItemsLayer)mapControl.Layers["BackgroundLayer"]; } }
        VectorItemsLayer DataLayer { get { return (VectorItemsLayer)mapControl.Layers["FileLayer"]; } }
        TreeMapFlatDataAdapter DataAdapter { get { return (TreeMapFlatDataAdapter)treeMapControl1.DataAdapter; } }
        ChoroplethColorizer MapColorizer { get { return (ChoroplethColorizer)DataLayer.Colorizer; } }
        TreeMapPaletteColorizer TreeMapColorizer { get { return (TreeMapPaletteColorizer)treeMapControl1.Colorizer; } }
        Series ChartSeries { get { return chartControl1.Series[0]; } }
        public override Control ActiveDemoModule { get { return treeMapControl1; } }

        public Selection() {
            InitializeComponent();
            countries = CountriesInfoDataReader.Load();
            BackgroundLayer.Data = CreateShapefileDataAdapter();
            DataLayer.Data = CreateShapefileDataAdapter();
            DataLayer.DataLoaded += FileLayer_DataLoaded;
            DataAdapter.DataSource = countries;
            InitializeColorizers();
        }

        void InitializeColorizers() {
            TreeMapColorizer.Palette = Palette.CreatePalette(PaletteHelper.SelectionDemoPalette);
            foreach(Color color in PaletteHelper.SelectionDemoPalette)
                MapColorizer.ColorItems.Add(new ColorizerColorItem(color));
        }
        ShapefileDataAdapter CreateShapefileDataAdapter() {
            ShapefileDataAdapter adapter = new ShapefileDataAdapter();
            adapter.FileUri = new Uri("file:\\\\" + Utils.GetRelativePath("CountriesGDP.shp"), UriKind.RelativeOrAbsolute);
            return adapter;
        }
        void SetMapItems(IEnumerable<MapItem> layerMapItemCollection) {
            foreach(MapItem item in layerMapItemCollection) {
                string shapeName = (string)item.Attributes["NAME"].Value;
                if(shapeName == "Others")
                    item.Visible = false;
                CountryStatisticInfo countryInfo = countries.Find(info => info.Name == shapeName);
                if(countryInfo != null) {
                    countryInfo.Shape = item;
                    item.Attributes.Add(new MapItemAttribute() { Name = "CountryInfo", Type = typeof(CountryStatisticInfo), Value = countryInfo });
                    if(countryInfo.Name == "United States")
                        DataLayer.SelectedItem = item;
                }
            }
        }
        void UpdateChart(CountryStatisticInfo countryInfo) {
            if(countryInfo != null) {
                ChartSeries.DataSource = countryInfo.GDPDynamic;
                ChartSeries.View.Color = Color.FromArgb(AlphaColor, PaletteHelper.SelectionDemoPalette[countryInfo.ColorIndex]);
                chartControl1.Titles[0].Text = countryInfo.Name + " " + ChartTitle;
            }
            else {
                ChartSeries.DataSource = null;
                chartControl1.Titles[0].Text = String.Empty;
            }
        }
        void FileLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            SetMapItems(((MapItemsLoadedEventArgs)e).Items);
            mapControl.EnableZooming = true;
            mapControl.ZoomToFitLayerItems();
            mapControl.EnableZooming = false;
        }
        void mapControl_SelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            CountryStatisticInfo countryInfo = GetMapSelectedCountryInfo();
            UpdateSelection(countryInfo, (country) => {
                treeMapControl1.SelectedItems.Clear();
                if(country != null)
                    treeMapControl1.SelectedItems.Add(country);
            });
        }
        void treeMapControl_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            CountryStatisticInfo countryInfo = GetTreeMapSelectedCountryInfo();
            UpdateSelection(countryInfo, (country) => {
                DataLayer.SelectedItems.Clear();
                if(country != null)
                    DataLayer.SelectedItems.Add(country.Shape);
            });
        }
        void layoutControl_ClientSizeChanged(object sender, EventArgs e) {
            mapControl.EnableZooming = true;
            mapControl.ZoomToFitLayerItems();
            mapControl.EnableZooming = false;
        }
        CountryStatisticInfo GetTreeMapSelectedCountryInfo() {
            if(treeMapControl1.SelectedItems.Count > 0)
                return (CountryStatisticInfo)treeMapControl1.SelectedItems[0];
            return null;
        }
        CountryStatisticInfo GetMapSelectedCountryInfo() {
            if(DataLayer.SelectedItems.Count > 0) {
                MapItem mapItem = (MapItem)DataLayer.SelectedItems[0];
                return (CountryStatisticInfo)mapItem.Attributes["CountryInfo"].Value;
            }
            return null;
        }
        void UpdateSelection(CountryStatisticInfo countryInfo, Action<CountryStatisticInfo> action) {
            if(!isSelectionLocked) {
                isSelectionLocked = true;
                try {
                    action(countryInfo);
                    UpdateChart(countryInfo);
                }
                finally {
                    isSelectionLocked = false;
                }
            }
        }
    }

    public class CountryStatisticInfo {
        readonly string _name;
        readonly string _continent;
        readonly List<GDPStatisticByYear> _statistic;
        readonly double _gdp;
        readonly int _colorIndex;
        MapItem _shape;

        public string Name { get { return _name; } }
        public string Continent { get { return _continent; } }
        public List<GDPStatisticByYear> GDPDynamic { get { return _statistic; } }
        public double GDP { get { return _gdp; } }
        public int ColorIndex { get { return _colorIndex; } }
        public MapItem Shape { get { return _shape; } set { _shape = value; } }

        public CountryStatisticInfo(string name, string continent, double gdp, int colorIndex, List<GDPStatisticByYear> statistic) {
            _name = name;
            _continent = continent;
            _gdp = gdp;
            _colorIndex = colorIndex;
            _statistic = statistic;
        }
    }

    public class GDPStatisticByYear {
        readonly int _year;
        readonly double _gdp;

        public int Year { get { return _year; } }
        public double GDP { get { return _gdp; } }

        public GDPStatisticByYear(int year, double gdp) {
            _year = year;
            _gdp = gdp;
        }
    }

    class CountriesInfoDataReader {
        static List<GDPStatisticByYear> LoadStatistic(XElement exportOfGoodsDynamic) {
            List<GDPStatisticByYear> statistic = new List<GDPStatisticByYear>();
            foreach(XElement exportOfGoodsDynamicItem in exportOfGoodsDynamic.Elements("GDPByYear")) {
                int year = int.Parse(exportOfGoodsDynamicItem.Element("Year").Value);
                double exportOfGoodsPercent = double.Parse(exportOfGoodsDynamicItem.Element("GDP").Value, CultureInfo.InvariantCulture);
                GDPStatisticByYear popDynamicItem = new GDPStatisticByYear(year, exportOfGoodsPercent);
                statistic.Add(popDynamicItem);
            }
            return statistic;
        }
        public static List<CountryStatisticInfo> Load() {
            List<CountryStatisticInfo> data = new List<CountryStatisticInfo>();
            try {
                XDocument Top10LargestCountries_xml = XDocument.Load(Utils.GetRelativePath("CountriesGDPByYears.xml"));
                foreach(XElement countryInfo in Top10LargestCountries_xml.Root.Elements("CountryInfo")) {
                    string name = countryInfo.Element("Name").Value;
                    string gdp = countryInfo.Element("GDP").Value;
                    string continent = countryInfo.Element("Continent").Value;
                    string colorIndex = countryInfo.Element("ColorIndex").Value;
                    List<GDPStatisticByYear> statistic = LoadStatistic(countryInfo.Element("Statistic"));
                    CountryStatisticInfo countryInfoInstance = new CountryStatisticInfo(name, continent, Convert.ToDouble(gdp), Convert.ToInt32(colorIndex), statistic);
                    data.Add(countryInfoInstance);
                }
            }
            catch {
            }
            return data;
        }
    }
}
