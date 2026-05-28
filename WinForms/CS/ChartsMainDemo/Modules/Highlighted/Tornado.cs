using System;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace DevExpress.XtraCharts.Demos {
    public partial class TornadoDemo : ChartDemoModuleLabelViews {
        class StackedBarLabelPositionItem {
            readonly string text;
            readonly BarSeriesLabelPosition position;

            public BarSeriesLabelPosition Position { get { return position; } }

            public StackedBarLabelPositionItem(string text, BarSeriesLabelPosition position) {
                this.text = text;
                this.position = position;
            }
            public override string ToString() {
                return text;
            }
        }

        public class TwoKeyColorizer : SeriesColorizerBase {
            readonly char separator;
            readonly Dictionary<string, int> firstKeys;
            readonly Dictionary<string, int> secondaryKeys;
            readonly ChartControl chart;

            public TwoKeyColorizer(ChartControl chart, char separator, Dictionary<string, int> firstKeys, Dictionary<string, int> secondaryKeys) {
                this.chart = chart;
                this.separator = separator;
                this.firstKeys = firstKeys;
                this.secondaryKeys = secondaryKeys;
            }
            public override Color GetSeriesColor(object seriesKey, Palette palette) {
                string name = seriesKey.ToString();
                string[] keys = name.Split(separator);
                if(keys.Length == 2) {
                    keys[1] = keys[1].TrimStart();
                    int index1, index2;
                    if(firstKeys.TryGetValue(keys[0], out index1) && secondaryKeys.TryGetValue(keys[1], out index2)) {
                        PaletteEntry[] entries = chart.GetPaletteEntries(palette.Count * secondaryKeys.Count);
                        return entries[index1 + index2 * palette.Count].Color;
                    }
                }
                return Color.Empty;
            }
            protected override ChartElement CreateObjectForClone() {
                return new TwoKeyColorizer(chart, separator, firstKeys, secondaryKeys);
            }
        }
        internal override bool ChartDesignerEnabled { get { return false; } }
        internal override ChartControl ChartControl { get { return chart; } }
        protected override LayoutControl OptionsLayoutControl { get { return layoutControl1; } }
        protected override CheckEdit LabelVisibleCheckEdit { get { return checkEditLabelVisible; } }
        internal override List<ChartControl> ChartControls { get { return new List<ChartControl>() { chart }; } }
        protected override DefaultBoolean ToolTipEnabled { get { return LabelVisibleCheckEdit.Checked ? DefaultBoolean.False : DefaultBoolean.True; } }

        public TornadoDemo() {
            InitializeComponent();
            InitializePositionComboBox();
            InitializeCalculatedFields();
            ChartControl.SeriesTemplate.SeriesColorizer = ConstructGenderColorizer();
            ChartControl.DataSource = AgeStructureDataReader.GetGenderAgeItemsWithPopulation();
        }
        void InitializeCalculatedFields() {
            ChartControl.CalculatedFields.Add(new ChartCalculatedField() {
                DisplayName = "Calculated Population",
                Expression = "IIF ([GenderAge.Gender] == \'Male\', [Population] * -1, [Population])",
                FieldType = ChartCalculatedFieldType.Double,
                Name = "CalculatedPopulation"
            });
        }
        void InitializePositionComboBox() {
            StackedBarLabelPositionItem center = new StackedBarLabelPositionItem("Center", BarSeriesLabelPosition.Center);
            StackedBarLabelPositionItem topInside = new StackedBarLabelPositionItem("Top Inside", BarSeriesLabelPosition.TopInside);
            StackedBarLabelPositionItem bottomInside = new StackedBarLabelPositionItem("Bottom Inside", BarSeriesLabelPosition.BottomInside);
            comboBoxEditRangeBarLabelPosition.Properties.Items.Add(center);
            comboBoxEditRangeBarLabelPosition.Properties.Items.Add(topInside);
            comboBoxEditRangeBarLabelPosition.Properties.Items.Add(bottomInside);
            comboBoxEditRangeBarLabelPosition.SelectedItem = center;
        }
        SeriesColorizerBase ConstructGenderColorizer() {
            Dictionary<string, int> firstKeys = new Dictionary<string, int>();
            firstKeys.Add("Male", 0);
            firstKeys.Add("Female", 1);
            Dictionary<string, int> secondaryKeys = new Dictionary<string, int>();
            secondaryKeys.Add("0-14 years", 0);
            secondaryKeys.Add("15-64 years", 1);
            secondaryKeys.Add("65 years and older", 2);
            return new TwoKeyColorizer(ChartControl, ':', firstKeys, secondaryKeys);
        }
        void Chart_CustomDrawAxisLabel(object sender, CustomDrawAxisLabelEventArgs e) {
            double axisValue;
            if(Double.TryParse(e.Item.AxisValue.ToString(), out axisValue) && axisValue < 0)
                e.Item.Text = (-axisValue).ToString("0,,");
        }
        void checkEditLabelVisible_CheckedChanged(object sender, EventArgs e) {
            SetLabelVisibility(layoutControlItemIndent, layoutControlItemOrientation, layoutControlItemRangeBarLabelPosition);
            UpdateStackedBarLabelIndent((StackedBarSeriesLabel)chart.SeriesTemplate.Label);
        }
        void comboBoxEditRangeBarLabelPosition_SelectedIndexChanged(object sender, EventArgs e) {
            BarSeriesLabelPosition position = ((StackedBarLabelPositionItem)comboBoxEditRangeBarLabelPosition.SelectedItem).Position;
            StackedBarSeriesLabel label = (StackedBarSeriesLabel)chart.SeriesTemplate.Label;
            label.Position = position;
            UpdateStackedBarLabelIndent(label);
        }
        void comboBoxEditLabelOrientation_SelectedIndexChanged(object sender, EventArgs e) {
            ChartControl.SeriesTemplate.Label.TextOrientation = (TextOrientation)comboBoxEditLabelOrientation.SelectedIndex;
        }
        void spinEditLabelIndent_EditValueChanged(object sender, EventArgs e) {
            BarSeriesLabel label = ChartControl.SeriesTemplate.Label as BarSeriesLabel;
            if(label != null)
                label.Indent = (int)spinEditLabelIndent.Value;
        }
        void comboBoxEditTotalLabelVisible_CheckedChanged(object sender, EventArgs e) {
            XYDiagram xyDiagram = ChartControl.Diagram as XYDiagram;
            if(xyDiagram != null) {
                StackedBarTotalLabel label = xyDiagram.DefaultPane.StackedBarTotalLabel;
                label.Visible = comboBoxEditTotalLabelVisible.Checked;
            }
        }
        void UpdateStackedBarLabelIndent(StackedBarSeriesLabel stackedBarSeriesLabel) {
            bool isCenterPosition = stackedBarSeriesLabel.Position.Equals(BarSeriesLabelPosition.Center);
            layoutControlItemIndent.Enabled = !isCenterPosition && checkEditLabelVisible.Checked;
            if(!isCenterPosition)
                spinEditLabelIndent.Value = stackedBarSeriesLabel.Indent;
        }
        void Chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            double number;
            if(Double.TryParse(e.LabelText, out number) && number < 0)
                e.LabelText = (-number).ToString();
        }
        void Chart_CustomizeStackedBarTotalLabel(object sender, CustomizeStackedBarTotalLabelEventArgs e) {
            double number;
            if(Double.TryParse(e.Text, out number) && number < 0)
                e.Text = (-number).ToString() + " M";
            if(number >= 0)
                e.Text += " M";
        }
        protected override void OnPaletteChanged() {
            base.OnPaletteChanged();
            chart.RefreshData();
        }

        void Chart_BoundDataChanged(object sender, EventArgs e) {
            if(chart.Series.Count > 0)
                foreach(Series series in chart.Series)
                    if(((GenderAgeInfo)series.Tag).Gender == "Male")
                        series.Legend = chart.Legends[0];
        }
    }
}
