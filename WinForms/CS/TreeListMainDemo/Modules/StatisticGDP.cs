using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using DevExpress.Data.Filtering;
using DevExpress.XtraMap;
using DevExpress.XtraTreeList.Columns;

namespace DevExpress.XtraTreeList.Demos {
    public partial class StatisticGDP : TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        List<HierarchicalStatisticInfo> statisticInfo;
        public StatisticGDP() {
            InitializeComponent();

            InitializeData();
            InitializeTreeList();
            InitializeComboBox();
            InitializeMap();

            this.LookAndFeel.StyleChanged += LookAndFeel_StyleChanged;
            mapControl1.BackColor = this.BackColor;
        }
        void InitializeData() {
            statisticInfo = DataReader.LoadHierarchical();
        }
        void StatisticGDP_Load(object sender, EventArgs e) {
            LoadTreeList();
        }
        void LookAndFeel_StyleChanged(object sender, EventArgs e) {
            mapControl1.BackColor = this.BackColor;
        }
        #region TreeList
        void InitializeTreeList() {
            treeList1.DataSource = statisticInfo;
            treeList1.BestFitColumns();

            treeList1.OptionsMenu.ShowConditionalFormattingItem = true;
            treeList1.ActiveFilterCriteria = new BinaryOperator("GDPBy2015", 450000000000.0, BinaryOperatorType.GreaterOrEqual);
        }
        void LoadTreeList() {
            treeList1.ForceInitialize();
            treeList1.BestFitColumns();
            treeList1.ExpandAll();

            treeList1.HorzScrollStep = tlcGDPBy2004.Width;
        }

        void treeList_SelectionChanged(object sender, EventArgs e) {

        }
        #endregion
        #region ComboBox
        List<SimpleComboBoxItem> years;
        void InitializeComboBox() {
            currentColumn = new CurrentColumns();
            years = treeList1.Columns.Where(column => (column.FieldName.Contains("GDPBy")))
                                     .Select(column => new SimpleComboBoxItem() { Caption = column.Caption, FieldName = column.FieldName })
                                     .ToList();
            var yearsWithoutFirstElement = years.Where(year => !year.FieldName.Contains("2004")).ToList();
            cbeSelectedYear.Properties.Items.AddRange(yearsWithoutFirstElement);

            selectedYearIndex = cbeSelectedYear.Properties.Items.Count - 1;
            cbeSelectedYear.SelectedIndex = cbeSelectedYear.Properties.Items.Count - 1;
        }
        int selectedYearIndex;
        CurrentColumns currentColumn;
        void cbeSelectedYear_SelectedIndexChanged(object sender, EventArgs e) {
            selectedYearIndex = cbeSelectedYear.SelectedIndex + 1;

            SimpleComboBoxItem year = years[selectedYearIndex];
            SimpleComboBoxItem prevYear = years[selectedYearIndex - 1];
            tlcGDPGrowth.UnboundExpression = string.Format("({0} - {1}) / {0}", year.FieldName, prevYear.FieldName);

            if(currentColumn.Column != null) {
                treeList1.Bands[currentColumn.Band.Name].Columns.Add(currentColumn.Column);
            }
            currentColumn.Column = treeList1.Columns[year.FieldName];
            currentColumn.Band = treeList1.Bands[currentColumn.Column.ParentBand.Name];

            bcStatistic.Columns.Clear();
            bcStatistic.Columns.Add(currentColumn.Column);
            bcStatistic.Columns.Add(tlcGDPGrowth);
            treeList1.FormatRules["Year"].Column = currentColumn.Column;

            if(continentView) {
                UpdateMapColorizer(GdpWorldColorizer, worldLayer, selectedYearIndex);
                UpdateMapLegend(GdpWorldLegend);
            }
            else {
                UpdateMapColorizer(GdpContinentColorizer, continentLayer, selectedYearIndex);
                UpdateMapLegend(GdpContinentLegend);
            }

        }
        class CurrentColumns {
            public TreeListColumn Column { get; set; }
            public TreeListBand Band { get; set; }
        }
        class SimpleComboBoxItem {
            public string FieldName { get; set; }
            public string Caption { get; set; }

            public override string ToString() {
                return Caption;
            }
        }
        #endregion
        #region Map
        const string GdpContinentToolTipPattern = "{Continent}: ${GDP_MD_EST:#,0}M";
        const string GdpCountryToolTipPattern = "{NAME}: ${GDP_MD_EST:#,0}M";
        ItemsLayerLegend Legend {
            get { return MapControl.Legends.Count > 0 ? (ItemsLayerLegend)MapControl.Legends[0] : null; }
            set {
                if(MapControl.Legends.Count > 0)
                    MapControl.Legends.RemoveAt(0);
                if(value != null)
                    MapControl.Legends.Add(value);
            }
        }
        public MapControl MapControl { get { return mapControl1; } }

        void InitializeMap() {
            this.continentsShapefile.FileUri = new Uri(Tutorials.FilePathUtils.FindFilePath(@"ShapeFiles\Continents.shp"));
            this.legendAlignment = LegendAlignment.BottomRight;
            SetupWorldLayer();

        }

        #region Legend Alignment
        LegendAlignment legendAlignment;
        LegendAlignment GetLegendAlignment(string value) {
            LegendAlignment alignment;
            Enum.TryParse<LegendAlignment>(value, out alignment);
            return alignment;
        }
        void UpdateLegendAligment() {
            ChoroplethColorizer choroplethColorizer = worldLayer.Colorizer as ChoroplethColorizer;
            if(choroplethColorizer != null && Legend != null) {
                Legend.Alignment = legendAlignment;
            }
        }
        #endregion

        void ContinentLayer_DataLoaded(object sender, DataLoadedEventArgs e) {
            var items = ((MapItemsLoadedEventArgs)e).Items;
            foreach(MapItem _item in items) {
                string shapeName = (string)_item.Attributes["Continent"].Value;
                if(shapeName == "Others") _item.Visible = false;
            }
        }
        void mapControl1_MapItemClick(object sender, MapItemClickEventArgs e) {
            if(!continentView)
                return;
            SetupContinentLayer(e.Item);
        }
        void btBackToWorld_Click(object sender, EventArgs e) {
            SetupWorldLayer();
        }

        #region Infrastructure
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

        bool continentView = true;
        void UpdateView(bool continentView) {
            this.continentView = continentView;
            worldLayer.Visible = continentView;
            btBackToWorld.Visible = !continentView;
            allCountriesOnSelectedContinentLayer.Visible = !continentView;
            continentLayer.Visible = !continentView;
        }
        void UpdateMapLegend(ItemsLayerLegend legend) {
            Legend = legend;
        }
        void UpdateMapColorizer(MapColorizer colorizer, VectorItemsLayer layer, int year) {
            ((HierarchicalValueProvider)((ChoroplethColorizer)colorizer).ValueProvider).YearIndex = year;
            layer.Colorizer = colorizer;
            //continentLayer.ToolTipPattern = GdpContinentToolTipPattern;
            //topCountriesLayer.ToolTipPattern = GdpCountryToolTipPattern;

            UpdateLegendAligment();
        }
        #endregion

        #region World Layer
        ChoroplethColorizer gdpWorldColorizerCore;
        ColorScaleLegend gdpWorldLegendCore;

        ChoroplethColorizer GdpWorldColorizer {
            get {
                if(gdpWorldColorizerCore == null)
                    gdpWorldColorizerCore = CreateGdpWorldColorizer();
                return gdpWorldColorizerCore;
            }
        }
        ChoroplethColorizer CreateGdpWorldColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new List<double> { 0, 5000, 10000, 15000, 20000, 25000 });
            List<Color> colors = new List<Color> {
                    Color.FromArgb(0x5F, 0x8B, 0x95), Color.FromArgb(0xA2, 0xA8, 0x75), Color.FromArgb(0xF2, 0xCB, 0x4E),
                    Color.FromArgb(0xE5, 0xA8, 0x4D), Color.FromArgb(0xBA, 0x4D, 0x51)
                };
            colorizer.ColorItems.AddRange(GetColorItems(colors));
            colorizer.ValueProvider = new HierarchicalValueProvider() { AttributeName = "Continent", StatisticInfo = statisticInfo, Round = 1000000000 /*Billion*/ };
            colorizer.ApproximateColors = true;
            return colorizer;
        }

        ColorScaleLegend GdpWorldLegend {
            get {
                if(gdpWorldLegendCore == null)
                    gdpWorldLegendCore = CreateGdpWorldLegend();
                return gdpWorldLegendCore;
            }
        }
        ColorScaleLegend CreateGdpWorldLegend() {
            ColorScaleLegend _legend = new ColorScaleLegend();
            _legend.Header = "GDP by Continents";
            _legend.Description = "In US dollars";
            _legend.RangeStopsFormat = "0,B";
            _legend.Layer = worldLayer;
            return _legend;
        }

        void SetupWorldLayer() {
            UpdateView(true);
            MapControl.ZoomToFitLayerItems(new LayerBase[] { worldLayer }, 0.15);
            UpdateMapLegend(GdpWorldLegend);
            UpdateMapColorizer(GdpWorldColorizer, worldLayer, selectedYearIndex);
        }
        #endregion

        #region Continent Layer
        ChoroplethColorizer gdpContinentColorizerCore;
        ColorScaleLegend gdpContinentLegendCore;
        ChoroplethColorizer GdpContinentColorizer {
            get {
                if(gdpContinentColorizerCore == null)
                    gdpContinentColorizerCore = CreateGdpContinentColorizer();
                return gdpContinentColorizerCore;
            }
        }
        ChoroplethColorizer CreateGdpContinentColorizer() {
            ChoroplethColorizer colorizer = new ChoroplethColorizer();
            colorizer.RangeStops.AddRange(new List<double> { 0, 500, 10000, 50000, 200000, 500000, 1000000 });
            List<Color> colors = new List<Color> {
                Color.FromArgb(0x79, 0x96, 0x89), Color.FromArgb(0xCE, 0xBB, 0x5F), Color.FromArgb(0xF1, 0xC1, 0x49),
                Color.FromArgb(0xD6, 0x86, 0x4E), Color.FromArgb(0xC5, 0x64, 0x50), Color.FromArgb(0xBA, 0x4D, 0x51)
            };
            colorizer.ColorItems.AddRange(GetColorItems(colors));
            colorizer.ValueProvider = new HierarchicalValueProvider() { AttributeName = "ADMIN", StatisticInfo = statisticInfo, Round = 10000000 };
            colorizer.ApproximateColors = true;
            return colorizer;
        }
        ColorScaleLegend GdpContinentLegend {
            get {
                if(gdpContinentLegendCore == null)
                    gdpContinentLegendCore = CreateGdpContinentLegend();
                return gdpContinentLegendCore;
            }
        }
        ColorScaleLegend CreateGdpContinentLegend() {
            ColorScaleLegend _legend = new ColorScaleLegend();
            _legend.Header = "GDP by Countries";
            _legend.Description = "In US dollars";
            _legend.RangeStopsFormat = "0,M";
            _legend.Layer = continentLayer;
            return _legend;
        }
        string selectedContinent;
        void SetupContinentLayer(MapItem _item) {
            UpdateView(false);
            this.selectedContinent = _item.Attributes["Continent"].Value.ToString();
            string continentShapeFileName = Path.Combine("ShapeFiles", selectedContinent + ".shp");
            allCountriesOnSelectedContinentLayer.Data = new ShapefileDataAdapter() {
                FileUri = new Uri(Tutorials.FilePathUtils.FindFilePath(continentShapeFileName))
            };
            PopulateTopItems();
            MapControl.ZoomToFitLayerItems(new LayerBase[] { continentLayer }, 0.15);

            UpdateMapLegend(GdpContinentLegend);
            UpdateMapColorizer(GdpContinentColorizer, continentLayer, selectedYearIndex);
        }
        void PopulateTopItems() {
            ShapefileDataAdapter data = new ShapefileDataAdapter() {
                FileUri = new Uri(Tutorials.FilePathUtils.FindFilePath(@"ShapeFiles\Countries.shp"))
            };
            data.ItemsLoaded += Data_ItemsLoaded;
            data.Load();
            MapItemStorage storage = new MapItemStorage();
            foreach(MapItem _item in ((IMapDataAdapter)data).Items)
                storage.Items.Add(_item);
            continentLayer.Data = storage;
        }
        void Data_ItemsLoaded(object sender, ItemsLoadedEventArgs e) {
            ((ShapefileDataAdapter)sender).ItemsLoaded -= Data_ItemsLoaded;
            for(int i = e.Items.Count - 1; i >= 0; i--)
                if(e.Items[i].Attributes["Continent"].Value.ToString() != selectedContinent)
                    e.Items.RemoveAt(i);
        }
        #endregion

        #endregion
    }

    public class HierarchicalValueProvider : ShapeAttributeValueProvider {
        int yearIndexCore;
        public List<HierarchicalStatisticInfo> StatisticInfo {
            get; internal set;
        }
        public int Round { get; set; }
        public int YearIndex {
            get { return yearIndexCore; }
            internal set {
                if(yearIndexCore == value)
                    return;
                yearIndexCore = value;
                RaiseChanged();
            }
        }
        protected override double GetValue(IColorizerElement _item) {
            MapShape shapeItem = _item as MapShape;
            if(shapeItem == null)
                return double.NaN;
            MapItemAttribute attr = shapeItem.Attributes[AttributeName];
            if(attr != null && attr.Value != null) {
                var hsi = StatisticInfo.Find(country => country.Name == attr.Value.ToString());
                if(hsi == null)
                    return double.NaN;
                double? gdp = hsi.Statistic[YearIndex].GDP;
                return gdp.HasValue ? gdp.Value / Round : double.NaN;
            }
            return double.NaN;
        }
    }
}
