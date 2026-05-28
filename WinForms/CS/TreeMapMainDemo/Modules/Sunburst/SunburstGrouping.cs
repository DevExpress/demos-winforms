using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.TreeMap;
using DevExpress.Utils;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class SunburstGrouping : TreeMapDemoModuleWithOptions {
        SunburstFlatDataAdapter DataAdapter { get { return (SunburstFlatDataAdapter)sunburstControl1.DataAdapter; } }
        public override Control ActiveDemoModule { get { return sunburstControl1; } }

        public SunburstGrouping() {
            InitializeComponent();
            DataAdapter.DataSource = Utils.CreateDataSet("ChemicalElements.xml");
            sunburstControl1.Colorizer = new ChemicalElementColorizer() { LegendItemPattern = "{L} : {V}" };
            displayModeCBE.Properties.Items.AddRange(Enum.GetValues(typeof(SunburstLabelDisplayMode)));
            displayModeCBE.SelectedIndex = 1;
            InitializeControls(sunburstControl1);
        }

        void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            SuperToolTip stp = new SuperToolTip();
            SunburstItem item = (SunburstItem)e.SelectedObject;
            if(item.Children.Count == 0) {
                DataRowView element = (DataRowView)item.Tag;
                stp.Items.Add(new ToolTipTitleItem() { Text = string.Format("{0}", element["Name"]) });
                stp.Items.Add(new ToolTipSeparatorItem());
                stp.Items.Add(CreateToolTipItem(element, "AtomicNumber", "Atomic Number", ""));
                stp.Items.Add(CreateToolTipItem(element, "AtomicMass", "Atomic Mass", "u (±)"));
                stp.Items.Add(CreateToolTipItem(element, "Density", "Density", "g/cm³"));
                stp.Items.Add(CreateToolTipItem(element, "MeltingPoint", "Melting Point", "K"));
                stp.Items.Add(CreateToolTipItem(element, "BoilingPoint", "Boiling Point", "K"));
            }
            else {
                stp.Items.Add(new ToolTipTitleItem() { Text = item.Label });
                stp.Items.Add(new ToolTipSeparatorItem());
                stp.Items.Add(new ToolTipTitleItem() { Text = string.Format(CultureInfo.InvariantCulture, "{0} elements", ((IList)item.Tag).Count) });
            }
            e.SuperTip = stp;
        }
        ToolTipTitleItem CreateToolTipItem(DataRowView element, string fieldName, string caption, string unit) {
            string fieldValue = element[fieldName].ToString();
            string itemText = fieldValue == "–" ? string.Format(CultureInfo.InvariantCulture, "{0} = {1}", caption, fieldValue) : string.Format(CultureInfo.InvariantCulture, "{0} = {1} {2}", caption, fieldValue, unit);
            return new ToolTipTitleItem() { Text = itemText };
        }
        void displayModeCBE_SelectedIndexChanged(object sender, EventArgs e) {
            sunburstControl1.Label.DisplayMode = (SunburstLabelDisplayMode)displayModeCBE.SelectedItem;
            autoLayoutCE.Enabled = sunburstControl1.Label.DisplayMode != SunburstLabelDisplayMode.Radial;
            sunburstControl1.Label.AutoLayout = autoLayoutCE.Checked;
        }
        void autoLayoutCE_CheckedChanged(object sender, EventArgs e) {
            sunburstControl1.Label.AutoLayout = autoLayoutCE.Checked;
        }
    }

    public class ChemicalElementColorizer : SunburstPaletteColorizer {
        const string FBlock = "F-block", BlockColumn = "Block", FamilyColumn = "Family";
        Dictionary<string, Color> _colors;

        Dictionary<string, Color> Colors {
            get {
                if(_colors == null) {
                    _colors = new Dictionary<string, Color>();
                    _colors["S-block"] = Color.FromArgb(216, 103, 159);
                    _colors["P-block"] = Color.FromArgb(234, 202, 39);
                    _colors["D-block"] = Color.FromArgb(102, 156, 220);
                    _colors["F-block"] = Color.FromArgb(126, 171, 54);
                    _colors["Lanthanide"] = Color.FromArgb(145, 183, 46);
                    _colors["Actinide"] = Color.FromArgb(107, 160, 52);
                }
                return _colors;
            }
        }
        protected override Color GetItemColor(ISunburstItem item, SunburstItemGroupInfo group) {
            DataRowView row = (DataRowView)GetItemObject(item);
            string block = row[BlockColumn].ToString();
            string colorKey = block == FBlock && group.GroupLevel > 0 ? row[FamilyColumn].ToString() : block;
            return Colors[colorKey];
        }

        object GetItemObject(ISunburstItem item) {
            IList objects = item.Tag as IList;
            return objects != null ? objects[0] : item.Tag;
        }
    }
}
