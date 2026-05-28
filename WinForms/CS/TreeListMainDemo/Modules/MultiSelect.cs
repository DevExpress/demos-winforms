using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraEditors;
using DevExpress.Data.Filtering;
using DevExpress.XtraEditors.Controls;
using System.Collections.Generic;
using DevExpress.Internal;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Columns;


namespace DevExpress.XtraTreeList.Demos {
    public partial class MultiSelect : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList MainControl {
            get { return treeList; }
        }
        public MultiSelect() {
            InitializeComponent();
            ucMultiSelectOptions1.InitData(MainControl);
            InitData();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "TreeListMainDemo\\Modules\\MultiSelect", "TreeListMainDemo\\Options\\ucMultiSelectOptions" }; } }
        protected override string WhatsThisXMLFileName { get { return "MultiSelect"; } }
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);
            InitSelection();
        }
        //<treeList>
        private void InitSelection() {
            if(treeList.Nodes.Count == 0)
                return;
            treeList.SelectCells(treeList.Nodes[0].Nodes[0].Nodes[3], treeList.VisibleColumns[1], treeList.Nodes[0].Nodes[3], treeList.VisibleColumns[3]);
            treeList.SelectCells(treeList.Nodes[0].Nodes[0].Nodes[3], treeList.VisibleColumns[6], treeList.Nodes[0].Nodes[3], treeList.VisibleColumns[6]);
        }
        //</treeList>
        private void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList.DataSource = dataSet.Tables[0].DefaultView;
                treeList.ExpandAll();
                treeList.BestFitColumns();
            }
        }
        string currentGroupName;
        private void treeList1_GetStateImage(object sender, GetStateImageEventArgs e) {
            if(treeList.IsAutoFilterNode(e.Node))
                return;
            string[] groupNames = new string[] { "Administration", "Inventory", "Manufacturing", "Quality", "Research", "Sales" };
            currentGroupName = (string)e.Node.GetValue("GroupName");
            e.NodeImageIndex = Array.FindIndex(groupNames, new Predicate<string>(IsCurrentGroupName));
        }
        private bool IsCurrentGroupName(string groupName) {
            if(currentGroupName != null)
                return currentGroupName.Contains(groupName);
            return false;
        }
    }
}

