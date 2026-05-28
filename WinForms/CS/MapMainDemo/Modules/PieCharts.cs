using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DevExpress.XtraMap.Demos {
    public partial class PieCharts : MapTutorialControl {
        MapCallout Tooltip => (MapCallout)tooptipMapItemStorage.Items[0];
        public override MapControl MapControl {
            get { return mapControl; }
        }
        public PieCharts() {
            InitializeComponent();
            ChangePieItemSize();
            PrepareDataSources();
        }
        void PrepareDataSources() {
            shapefileDataAdapter.FileUri = DemoUtils.GetFileUri("EUR.shp");
            EnergyStatistics energyStatistics = new EnergyStatistics();
            pieChartDataAdapter.DataSource = energyStatistics.EnergyUnits;
        }
        void ChangePieItemSize() {
            pieChartDataAdapter.ItemMaxSize = pieSizeRangeTrackBar.Value.Maximum;
            pieChartDataAdapter.ItemMinSize = pieSizeRangeTrackBar.Value.Minimum;
        }
        void ShowTooltipCallout(EnergyCountry country) {
            Tooltip.Visible = true;
            Tooltip.Location = country.Location;
            int idx = pieDataRadioGroup.SelectedIndex;
            IEnumerable<string> energyTypes = country.EnergyUnits.Select((item) => $"{item.Key}: <b>{item.Value[idx]}</b>");
            Tooltip.Text = $"<size=+4>{country.Name}</size><br/>" + string.Join("<br/>", energyTypes);
        }
        void HideTooltipCallout() {
            Tooltip.Visible = false;
        }
        void MapControlSelectionChanged(object sender, MapSelectionChangedEventArgs e) {
            if(e.Selection.Count == 0) {
                HideTooltipCallout();
                return;
            }
            EnergyUnit energyUnit = e.Selection[0] as EnergyUnit;
            if(energyUnit != null) {
                EnergyCountry focusedCountry = energyUnit.Country;
                ShowTooltipCallout(focusedCountry);
                return;
            }
            if(e.Selection[0] == Tooltip)
                return;
            HideTooltipCallout();
        }
        void PieDataRadioGroupSelectedIndexChanged(object sender, EventArgs e) {
            string mappingValue = pieDataRadioGroup.Properties.Items[pieDataRadioGroup.SelectedIndex].Description;
            pieChartDataAdapter.Mappings.Value = mappingValue;
        }
        void PieSizeRangeTrackBarValueChanged(object sender, EventArgs e) {
            ChangePieItemSize();
        }
        void LegendTypeRadioGroupSelectedIndexChanged(object sender, EventArgs e) {
            SizeLegend sizeLegend = (SizeLegend)mapControl.Legends[1];
            sizeLegend.Type = (SizeLegendType)legendTypeRadioGroup.SelectedIndex;
        }
    }


    public class EnergyUnit {
        public string EnergyType { get; private set; }
        public EnergyCountry Country { get; private set; }
        public double Production { get; set; }
        public double Import { get; set; }

        public double this[int i] => i == 0 ? Production : Import;
        public string CountryName => Country.Name;
        public GeoPoint Location => Country.Location;
        public EnergyUnit(string energyType, EnergyCountry country) {
            EnergyType = energyType;
            Country = country;
        }
    }

    public class EnergyCountry {
        public string Name { get; private set; }
        public GeoPoint Location { get; private set; }
        public Dictionary<string, EnergyUnit> EnergyUnits;
        public EnergyCountry(string name, GeoPoint location) {
            Name = name;
            Location = location;
            EnergyUnits = new Dictionary<string, EnergyUnit>();
        }
    }

    public class EnergyStatistics {
        public List<EnergyUnit> EnergyUnits = new List<EnergyUnit>();
        public Dictionary<string, EnergyCountry> Countries = new Dictionary<string, EnergyCountry>();

        public EnergyStatistics() {
            DataSet dataSet = new DataSet();
            string path = DemoUtils.GetRelativePath("EuropeEnergyStatictics.xml");
            dataSet.ReadXml(path);
            DataTable source = dataSet.Tables[0];

            foreach(DataRow row in source.Rows) {
                string countryName = row.Field<string>("Country");
                EnergyCountry country = null;
                if(!Countries.TryGetValue(countryName, out country)) {
                    GeoPoint location = new GeoPoint(row.Field<double>("Latitude"), row.Field<double>("Longitude"));
                    country = new EnergyCountry(countryName, location);
                    Countries.Add(countryName, country);
                }
                string energyType = row.Field<string>("EnergyType");
                EnergyUnit energyUnit = null;
                if(!country.EnergyUnits.TryGetValue(energyType, out energyUnit)) {
                    energyUnit = new EnergyUnit(energyType, country);
                    country.EnergyUnits.Add(energyType, energyUnit);
                    EnergyUnits.Add(energyUnit);
                }
                if(!row.IsNull("Production")) {
                    energyUnit.Production += row.Field<double>("Production");
                }
                if(!row.IsNull("Import")) {
                    energyUnit.Import += row.Field<double>("Import");
                }
            }
        }
    }
}
