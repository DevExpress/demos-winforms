using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Utils;

namespace DevExpress.XtraTreeMap.Demos {
    public partial class Grouping : TreeMapDemoModuleWithOptions {

        TreeMapFlatDataAdapter DataAdapter { get { return (TreeMapFlatDataAdapter)treeMapControl1.DataAdapter; } }
        TreeMapPaletteColorizer Colorizer { get { return (TreeMapPaletteColorizer)treeMapControl1.Colorizer; } }
        public override Control ActiveDemoModule { get { return treeMapControl1; } }

        public Grouping() {
            InitializeComponent();
            FillGroupByComboBox();
            DataAdapter.DataSource = Utils.CreateDataSet("Billionares.xml");
            Colorizer.Palette = Palette.Office2016Palette;
            UpdateGrouping(true);
        }

        void UpdateGrouping(bool enableGrouping) {
            DataAdapter.GroupDataMembers.Clear();
            if(enableGrouping)
                foreach(string definition in ((GroupDefinitionInfo)groupByCBE.SelectedItem).Definitions)
                    DataAdapter.GroupDataMembers.Add(definition.Replace(" ", ""));
            Colorizer.ColorizeGroups = enableGrouping;
        }
        void toolTipController1_BeforeShow(object sender, ToolTipControllerShowEventArgs e) {
            TreeMapItem item = (TreeMapItem)e.SelectedObject;
            if(!item.IsGroup) {
                SuperToolTip superToolTip = new SuperToolTip();
                superToolTip.Items.Add(new ToolTipTitleItem() { Text = item.Label });
                superToolTip.Items.Add(new ToolTipSeparatorItem());
                DataRowView dataRowView = (DataRowView)item.Tag;
                superToolTip.Items.Add(new ToolTipItem() { Text = dataRowView["Residence"].ToString() + ", " + dataRowView["NetWorth"].ToString() + "B$" });
                e.SuperTip = superToolTip;
            }
        }
        void FillGroupByComboBox() {
            groupByCBE.Properties.Items.AddRange(GroupDefinitionInfo.GetDefinitions());
            groupByCBE.SelectedIndex = 0;
        }
        void groupByCBE_EditValueChanged(object sender, System.EventArgs e) {
            UpdateGrouping(enableGroupingCE.Checked);
        }
        void enableGroupingCE_CheckedChanged(object sender, EventArgs e) {
            bool enableGrouping = enableGroupingCE.Checked;
            groupByLCI.Enabled = enableGrouping;
            UpdateGrouping(enableGroupingCE.Checked);
        }
    }

    class GroupDefinitionInfo {
        public static GroupDefinitionInfo[] GetDefinitions() {
            return new GroupDefinitionInfo[3] {
                new GroupDefinitionInfo(new string[] { residenceGroupDefinition }),
                new GroupDefinitionInfo(new string[] { ageGroupDefinition }),
                new GroupDefinitionInfo(new string[] { residenceGroupDefinition, ageGroupDefinition })
            };
        }

        const string residenceGroupDefinition = "Residence", ageGroupDefinition = "Age Category";
        readonly string[] _definitions;

        public string[] Definitions { get { return _definitions; } }

        GroupDefinitionInfo(string[] definitions) {
            _definitions = definitions;
        }

        public override string ToString() {
            string definitionsString = string.Empty;
            for(int i = 0; i < Definitions.Length; i++) {
                if(!string.IsNullOrEmpty(definitionsString))
                    definitionsString += " And ";
                definitionsString += Definitions[i];
            }
            return definitionsString;
        }
    }
}
