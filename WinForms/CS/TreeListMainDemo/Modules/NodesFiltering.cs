using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.Data.Filtering;
using DevExpress.Internal;
using DevExpress.XtraBars;
using DevExpress.XtraTreeList.Nodes;

namespace DevExpress.XtraTreeList.Demos {
    public partial class NodesFiltering : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override bool AllowPrintOptions {
            get { return true; }
        }
        public override bool AllowGenerateReport {
            get { return false; }
        }
        protected override object Options {
            get { return treeList1.OptionsView; }
        }
        protected override string OptionsName {
            get { return "View Options"; }
        }
        public override TreeList MainControl {
            get { return treeList1; }
        }
        public NodesFiltering() {
            InitializeComponent();
            InitData();
            treeList1.BeginUpdate();
            treeList1.Columns["JobTitle"].AllNodesSummary = true;
            treeList1.Columns["JobTitle"].SummaryFooter = SummaryItemType.Count;
            treeList1.OptionsView.ShowSummaryFooter = true;
            treeList1.OptionsFind.Behavior = XtraEditors.FindPanelBehavior.Search;
            treeList1.OptionsFind.ParserKind = FindPanelParserKind.Exact;
            treeList1.OptionsFind.Condition = DevExpress.Data.Filtering.FilterCondition.Contains;
            treeList1.FindFilterText = "s Ma";
            treeList1.EndUpdate();
            ucFilterOptions1.InitData(MainControl);
            ucFindOptions1.InitData(MainControl);
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "TreeListMainDemo\\Modules\\NodesFiltering", "TreeListMainDemo\\Options\\ucFindOptions" }; } }
        protected override string WhatsThisXMLFileName { get { return "NodesFiltering"; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            treeList1.ShowFindPanel();
        }
        private void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.ExpandAll();
                treeList1.BestFitColumns();
            }
        }
        readonly string[] groups = new string[] { "Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales" };
        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e) {
            if(e.Node is TreeListAutoFilterNode)
                return;
            string groupName = (string)e.Node.GetValue("GroupName");
            if(!string.IsNullOrEmpty(groupName))
                e.NodeImageIndex = Array.FindIndex(groups, g => groupName.Contains(g));
        }
    }
}
