using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraTreeMap;

namespace DevExpress.XtraCharts.Demos {
    public partial class SelectionDemo : ChartDemoModuleWithOptions {
        ChartControl focusedChart;
        bool blockTreeMapSelectionCallback = false;
        bool blockChartSelectionCallback = false;

        internal override ChartControl ChartControl {
            get { return focusedChart; }
        }
        internal override List<ChartControl> ChartControls {
            get {
                return new List<ChartControl>() {
                    chartCountries,
                    chartUrbanPopulationPercentage,
                    chartPopulationDynamic
                };
            }
        }
        internal override object ExportedObject {
            get { return null; }
        }

        public SelectionDemo() {
            InitializeComponent();
            InitializeCountriesChart();
            InitializeTreeMap();
        }

        void InitializeCountriesChart() {
            focusedChart = chartCountries;
            chartCountries.BeginInit();
            Series doughnutSeries = chartCountries.Series["Countries Area"];
            doughnutSeries.BindToData(CountriesInfo.DataSource, "Name", "AreaMSqrKilometers");
            CountryStatisticInfo chinaInfo = CountriesInfo.DataSource[2];
            chartCountries.SelectedItems.Add(chinaInfo);
            chartCountries.EndInit();
            UpdatePopulationDynamicCharts(new List<CountryStatisticInfo>() { chinaInfo });
            chartCountries.SelectedItemsChanged += chartCountries_SelectedItemsChanged;
        }
        void InitializeTreeMap() {
            TreeMapFlatDataAdapter dataAdapter = new TreeMapFlatDataAdapter();
            dataAdapter.DataSource = CountriesInfo.DataSource;
            dataAdapter.ValueDataMember = nameof(CountryStatisticInfo.AreaMSqrKilometers);
            dataAdapter.LabelDataMember = nameof(CountryStatisticInfo.Name);

            XtraTreeMap.Palette palette = new XtraTreeMap.Palette();
            foreach(var entry in chartCountries.GetPaletteEntries(11))
                palette.Add(entry.Color);
            this.treeMap.Colorizer = new TreeMapPaletteColorizer() { Palette = palette };
            this.treeMap.DataAdapter = dataAdapter;
        }
        void UpdatePopulationDynamicCharts(IList selectedItems) {
            chartPopulationDynamic.Series.Clear();
            chartUrbanPopulationPercentage.Series.Clear();
            PaletteEntry[] entries = chartCountries.GetPaletteEntries(11);
            foreach(CountryStatisticInfo info in selectedItems) {
                Series populationDynamic = new Series(info.Name, ViewType.Line);
                LineSeriesView lineView = (LineSeriesView)populationDynamic.View;
                lineView.MarkerVisibility = DefaultBoolean.True;
                int selectedIndex = CountriesInfo.DataSource.IndexOf(info);
                Color color = entries[selectedIndex].Color;
                lineView.Color = color;
                lineView.SeriesPointAnimation = new XYMarkerSlideAnimation();
                populationDynamic.CrosshairLabelPattern = "{S}: {V:0.##}M";
                populationDynamic.ArgumentScaleType = ScaleType.Qualitative;
                populationDynamic.BindToData(info.PopulationDynamic, "Year", "PopulationMillionsOfPeople");
                chartPopulationDynamic.Series.Add(populationDynamic);
                Series urban = new Series(info.Name, ViewType.Bar);
                urban.CrosshairLabelPattern = "{S}: {V:0.}%";
                urban.ArgumentScaleType = ScaleType.Qualitative;
                urban.BindToData(info.PopulationDynamic, "Year", "UrbanPercent");
                SideBySideBarSeriesView urbanView = (SideBySideBarSeriesView)urban.View;
                urbanView.Color = color;
                chartUrbanPopulationPercentage.Series.Add(urban);
            }
        }
        void SelectCountriesOnTreeMap(List<CountryStatisticInfo> infos) {
            blockTreeMapSelectionCallback = true;
            treeMap.SelectedItems.Clear();
            foreach(var info in infos)
                this.treeMap.SelectedItems.Add(info);
            blockTreeMapSelectionCallback = false;
        }
        void chartCountries_ObjectHotTracked(object sender, HotTrackEventArgs e) {
            if(!(e.Object is Series))
                e.Cancel = true;
        }
        void chartCountries_ObjectSelected(object sender, HotTrackEventArgs e) {
            if(!(e.Object is Series))
                e.Cancel = true;
        }
        void chartCountries_SelectedItemsChanged(object sender, SelectedItemsChangedEventArgs e) {
            if(blockChartSelectionCallback)
                return;
            List<CountryStatisticInfo> infos = new List<CountryStatisticInfo>();
            foreach(CountryStatisticInfo info in chartCountries.SelectedItems)
                infos.Add(info);
            foreach(CountryStatisticInfo oldItem in e.OldItems)
                infos.Remove(oldItem);
            foreach(CountryStatisticInfo newItem in e.NewItems) {
                if(!infos.Contains(newItem))
                    infos.Add(newItem);
            }
            UpdatePopulationDynamicCharts(infos);
            SelectCountriesOnTreeMap(infos);
        }
        void OnChartClick(object sender, EventArgs e) {
            focusedChart = (ChartControl)sender;
        }
        void radioGroupSelectionMode_SelectedIndexChanged(object sender, EventArgs e) {
            
            ElementSelectionMode selectionMode = (ElementSelectionMode)radioGroupSelectionMode.EditValue;
            if(selectionMode.Equals(ElementSelectionMode.Single) && chartCountries.SelectedItems.Count > 1)
                UpdateChartCountries();
            chartCountries.SelectionMode = selectionMode;
            this.treeMap.SelectionMode = (XtraTreeMap.ElementSelectionMode)radioGroupSelectionMode.EditValue;
        }
        void UpdateChartCountries() {
            List<CountryStatisticInfo> infos = new List<CountryStatisticInfo>() { (CountryStatisticInfo)(chartCountries.SelectedItems[0]) };
            chartCountries.SelectedItems.Clear();
            chartCountries.SelectedItems.Add(infos[0]);
        }
        void TreeMapSelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (blockTreeMapSelectionCallback)
                return;

            blockChartSelectionCallback = true;
            chartCountries.SelectedItems.Clear();
            foreach (CountryStatisticInfo info in e.SelectedItems)
                chartCountries.SelectedItems.Add(info);
            blockChartSelectionCallback = false;
        }
        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            UpdatePopulationDynamicCharts(chartCountries.SelectedItems);
        }
    }
}
