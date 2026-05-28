using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class Colorizer : TreeMapDemoModuleWithOptions {
        const string GroupMember = "FieldOfActivity";
        readonly List<ITreeMapColorizer> colorizers = new List<ITreeMapColorizer>();

        TreeMapFlatDataAdapter DataAdapter { get { return (TreeMapFlatDataAdapter)treeMapControl1.DataAdapter; } }
        public override Control ActiveDemoModule { get { return treeMapControl1; } }

        public Colorizer() {
            InitializeComponent();
            DataAdapter.DataSource = Utils.CreateDataSet("USLargestCompanies2011.xml");
            InitializeColorizers();
        }
        void InitializeColorizers() {
            colorizers.Add(new TreeMapPaletteColorizer() { Palette = Palette.GreenYellowPalette, ColorizeGroups = true });
            TreeMapRangeColorizer rangeColorizer = new TreeMapRangeColorizer() {
                Palette = Palette.CreatePalette(Color.FromArgb(0xD8, 0x61, 0x0D), Color.FromArgb(0xEF, 0x80, 0x2B),
                                                                                        Color.FromArgb(0xFF, 0x9C, 0x11), Color.FromArgb(0xFF, 0xBB, 0x32), Color.FromArgb(0xFF, 0xCD, 0x7C))
            };
            rangeColorizer.RangeStops.AddRange(new double[] { 0, 59, 95, 300, 1300, 2500 });
            colorizers.Add(rangeColorizer);
            colorizers.Add(new TreeMapGradientColorizer() { StartColor = Color.FromArgb(0x33, 0x33, 0x33), EndColor = Color.FromArgb(0xEE, 0xEE, 0xEE) });
            colorizers.Add(new TreeMapGroupGradientColorizer() { Palette = Palette.InAFogPalette });

            treeMapControl1.Colorizer = colorizers[0];
            UpdateLegendParams();
        }
        void colorizerCBE_SelectedIndexChanged(object sender, EventArgs e) {
            treeMapControl1.Colorizer = colorizers[colorizerCBE.SelectedIndex];
            UpdateLegendParams();
        }
        void UpdateLegendParams() {
            LegendBase legend = treeMapControl1.Legend;
            if(treeMapControl1.Colorizer is TreeMapRangeColorizer) {
                legend.VerticalAlignment = LegendVerticalAlignment.Top;
                legend.HorizontalAlignment = LegendHorizontalAlignment.RightOutside;
                legend.Direction = LegendDirection.TopToBottom;
                legend.Title.Text = "Assets, $B";
            }
            else if(treeMapControl1.Colorizer is TreeMapPaletteColorizerBase) {
                legend.VerticalAlignment = LegendVerticalAlignment.BottomOutside;
                legend.HorizontalAlignment = LegendHorizontalAlignment.Center;
                legend.Direction = LegendDirection.LeftToRight;
                legend.HorizontalIndent = 30;
                legend.Title.Text = "Field Of Activity, $B";
                ((TreeMapPaletteColorizerBase)treeMapControl1.Colorizer).LegendItemPattern = "{L}: {V:#.#}";
            }
        }
        void enableGroupingCE_CheckedChanged(object sender, EventArgs e) {
            if(enableGroupingCE.Checked)
                DataAdapter.GroupDataMembers.Add(GroupMember);
            else
                DataAdapter.GroupDataMembers.Clear();
            ((TreeMapPaletteColorizer)colorizers[0]).ColorizeGroups = enableGroupingCE.Checked;
        }
    }
}
