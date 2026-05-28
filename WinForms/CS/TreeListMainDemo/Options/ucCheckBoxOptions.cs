using System;
using System.ComponentModel;
using System.Drawing;

namespace DevExpress.XtraTreeList.Demos.Options {
    public partial class ucCheckBoxOptions : ucDefault {
        public ucCheckBoxOptions() {
            InitializeComponent();
            layoutControl.UseLocalBindingContext = true;
            treeList1.BeforeFocusNode += OnBeforeFocusNode;
            treeList1.ActiveFilterString = "[Checked] = TRUE";
            treeList1.BackColor = Color.Transparent;
            treeList1.NodeCellStyle += OnNodeCellStyle;
        }
        void OnNodeCellStyle(object sender, GetCustomNodeCellStyleEventArgs e) {
            if(e.Node.Level == 0) {
                e.Appearance.FontSizeDelta += 1;
                e.Appearance.FontStyleDelta = FontStyle.Bold;
            }
            if(e.Node.Level == 1 && e.Node.Nodes.Count > 0)
                e.Appearance.FontStyleDelta = FontStyle.Bold;
        }
        void OnBeforeFocusNode(object sender, BeforeFocusNodeEventArgs e) {
            e.CanFocus = false;
        }
        //<layoutControl.lgOptions>
        protected override void InitDataCore() {
            imbShowCheckBoxes.Properties.AddEnum<ShowCheckBoxes>();
            imbShowCheckBoxes.SelectedIndex = 0;
            imbShowCheckBoxes.SelectedIndexChanged += OnSelectedIndexChanged;
            ceAllowRecursiveNodeChecking.Checked = TreeList.OptionsBehavior.AllowRecursiveNodeChecking;
            ceAllowRecursiveNodeChecking.CheckedChanged += OnCheckedChanged;
        }
        void OnCheckedChanged(object sender, EventArgs e) {
            TreeList.OptionsBehavior.AllowRecursiveNodeChecking = ceAllowRecursiveNodeChecking.Checked;
        }
        void OnSelectedIndexChanged(object sender, EventArgs e) {
            TreeList.BeginUpdate();
            switch((ShowCheckBoxes)imbShowCheckBoxes.SelectedIndex) {
                case ShowCheckBoxes.None:
                    TreeList.OptionsView.RootCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[1].Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[1].Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[1].Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[3].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    break;
                case ShowCheckBoxes.All:
                    TreeList.OptionsView.RootCheckBoxStyle = NodeCheckBoxStyle.Check;
                    TreeList.Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check;
                    TreeList.Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check;
                    TreeList.Nodes[1].Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[1].Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[1].Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[3].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    break;
                default:
                    TreeList.OptionsView.RootCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Check;
                    TreeList.Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Default;
                    TreeList.Nodes[1].Nodes[0].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[1].Nodes[1].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[1].Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[2].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    TreeList.Nodes[3].ChildrenCheckBoxStyle = NodeCheckBoxStyle.Radio;
                    break;
            }
            TreeList.EndUpdate();
        }
        //</layoutControl.lgOptions>
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            treeList1.ExpandAll();
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object DataSource {
            get { return treeList1.DataSource; }
            set { treeList1.DataSource = value; }
        }
    }
    enum ShowCheckBoxes { Default, All, None }
}
