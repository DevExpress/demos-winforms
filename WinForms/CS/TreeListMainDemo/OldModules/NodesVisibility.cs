using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.Internal;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraEditors;


namespace DevExpress.XtraTreeList.Demos {
    public partial class NodesVisibility : DevExpress.XtraTreeList.Demos.TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        public NodesVisibility() {
            InitializeComponent();
            InitData();
            InitListBox();
            treeList1.Columns["Check"].VisibleIndex = -1;
            treeList1.BestFitColumns();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "NodesVisibility" }; } }
        protected override string WhatsThisXMLFileName { get { return "NodesVisibility"; } }
        private void InitData() {
            string DBFileName = DataDirectoryHelper.GetDataFile("Departments.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                treeList1.DataSource = dataSet.Tables[0].DefaultView;
                treeList1.PopulateColumns();
                treeList1.ExpandAll();
            }
        }
        //<treeList1>
        private void InitListBox() {
            TreeListNode lastNode = treeList1.Nodes[0].Nodes[2].Nodes[1].LastNode;
            listBoxControl1.Items.Add(lastNode.GetDisplayText(0));
            lastNode.Visible = false;
        }

        private void treeList1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e) {
            if(e.Clicks != 2) return;
            TreeListHitInfo hi = treeList1.CalcHitInfo(new Point(e.X, e.Y));
            TreeListNode node = hi.Node;
            if(node != null) {
                listBoxControl1.Items.Add(node.GetDisplayText(0));
                node.Visible = false;
            }
        }
        //</treeList1>

        //<listBoxControl1>
        private void listBoxControl1_DoubleClick(object sender, System.EventArgs e) {
            string selectedValue = (string)listBoxControl1.SelectedValue;
            if(selectedValue == null) return;
            TreeListNode node = treeList1.FindNodeByFieldValue(treeList1.Columns[0].FieldName, selectedValue);
            if(node.ParentNode != null && !node.ParentNode.Visible) {
                XtraMessageBox.Show(this, "Please make the node's parent visible before");
                return;
            }
            node.Visible = true;
            listBoxControl1.Items.Remove(selectedValue);
        }
        private void listBoxControl1_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e) {
            string _item = e.Item as string;
            TreeListNode _node = treeList1.FindNodeByFieldValue(treeList1.Columns[0].FieldName, _item);
            if(_node.ParentNode != null && !_node.ParentNode.Visible) e.Appearance.ForeColor = Color.Gray;
        }
        //</listBoxControl1>
    }
}

