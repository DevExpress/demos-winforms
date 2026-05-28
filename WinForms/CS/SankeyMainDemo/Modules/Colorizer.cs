using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils;
using DevExpress.XtraCharts.Sankey;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.XtraSankey.Demos {
    public partial class Colorizer : SankeyDemoModuleWithOptions {
        Dictionary<string, List<string>> continentCountriesPairs;
        readonly GradientColorizer gradientColorizer = new GradientColorizer();
        public override SankeyDiagramControl SankeyDiagramControl {
            get { return sankeyDiagramControl1; }
        }
        public Colorizer() {
            InitializeComponent();
            InitContinentCountriesPairs_ColorizerDemo();
            InitColorizerItems();
            InitNodeAlignmentItems();
            AddData();
        }
        void InitColorizerItems() {
            colorizerRadioGroup.Properties.Items.Add(new RadioGroupItem(new ContinentColorizer(continentCountriesPairs), "Continent Colorizer (Custom)"));
            colorizerRadioGroup.Properties.Items.Add(new RadioGroupItem(gradientColorizer, "Gradient Colorizer (Custom)"));
            colorizerRadioGroup.Properties.Items.Add(new RadioGroupItem(new SankeyPaletteColorizer(), "Palette Colorizer"));
            colorizerRadioGroup.Properties.Items.Add(new RadioGroupItem(new SankeyPaletteColorizer() { LinkColor = Color.Gray }, "Monochrome Link Colorizer"));
            colorizerRadioGroup.SelectedIndex = 0;
        }
        void InitNodeAlignmentItems() {
            nodeAlignmentRadioGroup.Properties.Items.Add(new RadioGroupItem(SankeyNodeAlignment.Far, "Far"));
            nodeAlignmentRadioGroup.Properties.Items.Add(new RadioGroupItem(SankeyNodeAlignment.Center, "Center"));
            nodeAlignmentRadioGroup.Properties.Items.Add(new RadioGroupItem(SankeyNodeAlignment.Near, "Near"));
            nodeAlignmentRadioGroup.SelectedIndex = 0;
        }
        void InitContinentCountriesPairs_ColorizerDemo() {
            continentCountriesPairs = new Dictionary<string, List<string>>();
            continentCountriesPairs.Add("North America", new List<string>() {
                "United States",
                "Canada",
                "Mexico",
            });
            continentCountriesPairs.Add("Asia", new List<string>() {
                "Japan",
                "South Korea",
            });
            continentCountriesPairs.Add("South America", new List<string>() {
                "Brazil",
                "Argentina",
            });
            continentCountriesPairs.Add("Australia", new List<string>() {
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
        }
        void AddData() {
            List<Export> dataSource = LargestExportPartners.GetData();
            Func<Export, string, bool> removeFunction = (Export e, string country) => {
                return continentCountriesPairs[country].Contains(e.Importer) || continentCountriesPairs[country].Contains(e.Exporter);
            };
            if(!NorthAmericaChE.Checked)
                dataSource.RemoveAll(x => removeFunction(x, "North America"));
            if(!SouthAmericaChE.Checked)
                dataSource.RemoveAll(x => removeFunction(x, "South America"));
            if(!AsiaChE.Checked)
                dataSource.RemoveAll(x => removeFunction(x, "Asia"));
            if(!AustraliaChE.Checked)
                dataSource.RemoveAll(x => removeFunction(x, "Australia"));
            if(!EuropeChE.Checked)
                dataSource.RemoveAll(x => removeFunction(x, "Europe"));
            UpdateMinMaxRangeColorizerValue(dataSource);
            sankeyDiagramControl1.DataSource = dataSource;
        }
        void UpdateMinMaxRangeColorizerValue(List<Export> dataSource) {
            if(dataSource.Count != 0) {
                Dictionary<string, double> exportCountryValues = new Dictionary<string, double>();
                Dictionary<string, double> importCountryValues = new Dictionary<string, double>();
                foreach(var export in dataSource) {
                    double exportValue;
                    if(exportCountryValues.TryGetValue(export.Exporter, out exportValue))
                        exportCountryValues[export.Exporter] = exportValue + export.Sum;
                    else exportCountryValues.Add(export.Exporter, export.Sum);

                    double importValue;
                    if(importCountryValues.TryGetValue(export.Importer, out importValue))
                        importCountryValues[export.Importer] += importValue + export.Sum;
                    else importCountryValues.Add(export.Importer, export.Sum);
                }
                var values = exportCountryValues.Values.ToList();
                values.AddRange(importCountryValues.Values.ToList());
                gradientColorizer.MinValue = values.Min();
                gradientColorizer.MaxValue = values.Max();
            }
        }
        void ChE_CheckedChanged(object sender, EventArgs e) {
            AddData();
        }
        void OnCustomizeNodeToolTip(object sender, CustomizeSankeyNodeToolTipEventArgs e) {
            var text = new StringBuilder();
            if(Math.Round(e.Node.SourceWeight, 3) != 0)
                text.Append(String.Format("Total import: ${0} billion", Math.Round(e.Node.SourceWeight * 1000, 2)));
            if(Math.Round(e.Node.TargetWeight, 3) != 0) {
                if(text.Length != 0)
                    text.AppendLine();
                text.Append(String.Format("Total export: ${0} billion", Math.Round(e.Node.TargetWeight * 1000, 2)));
            }
            e.Content = text.ToString();
        }
        void OnCustomizeLinkToolTip(object sender, CustomizeSankeyLinkToolTipEventArgs e) {
            e.Content = String.Format("${0} billion", Math.Round(e.Link.TotalWeight * 1000, 2));
        }
        void colorizerRadioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            sankeyDiagramControl1.Colorizer = (ISankeyColorizer)colorizerRadioGroup.Properties.Items[colorizerRadioGroup.SelectedIndex].Value;
        }
        void ResolveOverlappingChE_CheckedChanged(object sender, EventArgs e) {
            ((SankeyLinearLayoutAlgorithm)SankeyDiagramControl.LayoutAlgorithm).ResolveOverlapping = resolveOverlappingChE.Checked ? DefaultBoolean.True : DefaultBoolean.False;
        }
        void nodeAlignmentRadioGroup_SelectedIndexChanged(object sender, EventArgs e) {
            ((SankeyLinearLayoutAlgorithm)SankeyDiagramControl.LayoutAlgorithm).NodeAlignment = (SankeyNodeAlignment)nodeAlignmentRadioGroup.Properties.Items[nodeAlignmentRadioGroup.SelectedIndex].Value;
        }
    }

    class ContinentColorizer : ISankeyColorizer {
        Dictionary<string, Color> continentColorPairs = new Dictionary<string, Color>();
        Dictionary<string, List<string>> continentCountriesPairs = new Dictionary<string, List<string>>();
        public ContinentColorizer(Dictionary<string, List<string>> continentCountriesPairs) {
            continentColorPairs.Add("Asia", Color.FromArgb(245, 86, 74));
            continentColorPairs.Add("North America", Color.FromArgb(29, 178, 245));
            continentColorPairs.Add("South America", Color.FromArgb(151, 201, 92));
            continentColorPairs.Add("Australia", Color.FromArgb(198, 144, 83));
            continentColorPairs.Add("Europe", Color.FromArgb(255, 199, 32));
            this.continentCountriesPairs = continentCountriesPairs;
        }
        public ContinentColorizer(Dictionary<string, Color> continentColorPairs, Dictionary<string, List<string>> continentCountriesPairs) {
            this.continentColorPairs = continentColorPairs;
            this.continentCountriesPairs = continentCountriesPairs;
        }
        string GetContinentByCountry(string country) {
            if(continentColorPairs.ContainsKey(country))
                return country;
            foreach(var continentCountryPairs in continentCountriesPairs)
                if(continentCountryPairs.Value.Contains(country))
                    return continentCountryPairs.Key;
            return string.Empty;
        }
        Color ISankeyColorizer.GetLinkSourceColor(SankeyLink link) {
            string country = link.SourceNode.Tag.ToString();
            return GetContinentColor(GetContinentByCountry(country));
        }
        Color ISankeyColorizer.GetLinkTargetColor(SankeyLink link) {
            string country = link.TargetNode.Tag.ToString();
            return GetContinentColor(GetContinentByCountry(country));
        }
        Color ISankeyColorizer.GetNodeColor(SankeyNode info) {
            string country = info.Tag.ToString();
            return GetContinentColor(GetContinentByCountry(country));
        }
        Color GetContinentColor(string continent) {
            Color color;
            if(!string.IsNullOrEmpty(continent) && continentColorPairs.TryGetValue(continent, out color))
                return color;
            return Color.Empty;
        }
    }

    class GradientColorizer : ISankeyColorizer {
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        Color GetGradientColor(double percent) {
            Color color1 = Color.FromArgb(255, 96, 181, 204);
            Color color2 = Color.FromArgb(255, 230, 108, 125);
            percent = double.IsNaN(percent) ? 1 : percent;

            double resultRed = color1.R * (1.0 - percent) + color2.R * percent;
            double resultGreen = color1.G * (1.0 - percent) + color2.G * percent;
            double resultBlue = color1.B * (1.0 - percent) + color2.B * percent;
            return Color.FromArgb((byte)resultRed, (byte)resultGreen, (byte)resultBlue);
        }
        Color ISankeyColorizer.GetLinkSourceColor(SankeyLink link) {
            return GetGradientColor((link.SourceNode.TotalWeight - MinValue) / (MaxValue - MinValue));
        }
        Color ISankeyColorizer.GetLinkTargetColor(SankeyLink link) {
            return GetGradientColor((link.TargetNode.TotalWeight - MinValue) / (MaxValue - MinValue));
        }
        Color ISankeyColorizer.GetNodeColor(SankeyNode node) {
            return GetGradientColor((node.TotalWeight - MinValue) / (MaxValue - MinValue));
        }
    }
}
