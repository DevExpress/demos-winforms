using System.Drawing;
using System.Windows.Forms;
using System.Data;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.Utils.DragDrop;
using System.Collections.Generic;
using DevExpress.Internal;

namespace DevExpress.XtraTreeList.Demos {
    public partial class TreeListDragDrop : TutorialControl {
        public override TreeList MainControl {
            get { return treeList1; }
        }
        public TreeListDragDrop() {
            InitializeComponent();
            InitProjectsData();
        }
        protected override string[] WhatsThisCodeFileNames { get { return new string[] { "TreeListMainDemo\\Modules\\DragDrop" }; } }
        protected override string WhatsThisXMLFileName { get { return "DragDrop"; } }
        void InitProjectsData() {
            DataSet dataSet = CreateDataSource();
            if(dataSet == null)
                return;
            listBoxControl.DataSource = dataSet.Tables[1].DefaultView;
            treeList1.DataSource = dataSet.Tables[0];
            treeList1.ExpandAll();
            DragDropManager.Default.DragOver += OnDragOver;
            DragDropManager.Default.DragDrop += OnDragDrop;
        }

        void OnDragDrop(object sender, DragDropEventArgs e) {
            if(object.ReferenceEquals(e.Source, e.Target))
                return;
            e.Handled = true;
            if(e.Action == DragDropActions.None || e.InsertType == InsertType.None)
                return;
            if(e.Target == treeList1)
                OnTreeListDrop(e);
            if(e.Target == listBoxControl)
                OnListBoxDrop(e);
            Cursor.Current = Cursors.Default;
        }
        //<listBoxControl>
        void OnListBoxDrop(DragDropEventArgs e) {
            DataView dataView = listBoxControl.DataSource as DataView;
            if(dataView == null)
                return;
            var nodes = e.GetData<IList<TreeListNode>>();
            if(nodes == null)
                return;
            int index = CalcDestItemIndex(e);
            treeList1.BeginUpdate();
            listBoxControl.BeginUpdate();
            listBoxControl.UnSelectAll();
            List<int> selectIndices = new List<int>();
            DropNode(nodes, dataView, selectIndices, ref index, e.Action == DragDropActions.Copy);
            for(int i = 0; i < selectIndices.Count; i++)
                listBoxControl.SetSelected(selectIndices[i], true);
            listBoxControl.EndUpdate();
            treeList1.EndUpdate();
        }
        //</listBoxControl>
        void DropNode(IEnumerable<TreeListNode> nodes, DataView dataView, List<int> selectIndices, ref int index, bool isCopy) {
            List<TreeListNode> _nodes = new List<TreeListNode>(nodes);
            foreach(TreeListNode node in _nodes) {
                if(node.HasChildren)
                    DropNode(node.Nodes, dataView, selectIndices, ref index, isCopy);
                DataRowView rowView = treeList1.GetRow(node.Id) as DataRowView;
                if(rowView == null)
                    return;
                var newRow = dataView.Table.NewRow();
                for(int i = 0; i < dataView.Table.Columns.Count; i++) {
                    var rowColumn = rowView.Row.Table.Columns[i];
                    var newRowColumn = newRow.Table.Columns[i];
                    newRow[newRowColumn] = rowView.Row[rowColumn];
                }
                dataView.Table.Rows.InsertAt(newRow, index);
                if(!isCopy)
                    treeList1.Nodes.Remove(node);
                selectIndices.Add(index++);
            }
        }
        int CalcDestItemIndex(DragDropEventArgs e) {
            Point hitPoint = listBoxControl.PointToClient(e.Location);
            int index = listBoxControl.IndexFromPoint(hitPoint);
            if(e.InsertType == InsertType.After)
                index += 1;
            if(index == -1 && listBoxControl.ItemCount == 0)
                return 0;
            return index;
        }
        //<treeList1>
        void OnTreeListDrop(DragDropEventArgs e) {
            DataView dataView = listBoxControl.DataSource as DataView;
            if(dataView == null)
                return;
            var items = e.GetData<IEnumerable<object>>();
            if(items == null)
                return;
            var destNode = GetDestNode(e.Location);
            int index = CalcDestNodeIndex(e, destNode);
            treeList1.BeginUpdate();
            listBoxControl.BeginUpdate();
            treeList1.Selection.UnselectAll();
            List<object> _items = new List<object>(items);
            foreach(object _item in _items) {
                DataRowView rowView = _item as DataRowView;
                TreeListNode node = treeList1.AppendNode(rowView.Row.ItemArray, index == -1000 ? destNode : null);
                if(index > -1) {
                    treeList1.MoveNode(node, destNode.ParentNode, true, index);
                    index++;
                }
                if(e.Action != DragDropActions.Copy)
                    dataView.Table.Rows.Remove(rowView.Row);
                treeList1.SelectNode(node);
                if(node.ParentNode != null)
                    node.ParentNode.Expand();
            }
            listBoxControl.EndUpdate();
            treeList1.EndUpdate();
        }
        //</treeList1>
        TreeListNode GetDestNode(Point hitPoint) {
            Point pt = treeList1.PointToClient(hitPoint);
            DevExpress.XtraTreeList.TreeListHitInfo ht = treeList1.CalcHitInfo(pt);
            TreeListNode destNode = ht.Node;
            if(destNode is TreeListAutoFilterNode)
                return null;
            return destNode;
        }
        int CalcDestNodeIndex(DragDropEventArgs e, TreeListNode destNode) {
            if(destNode == null)
                return -1;
            if(e.InsertType == InsertType.AsChild)
                return -1000;
            var nodes = destNode.ParentNode == null ? treeList1.Nodes : destNode.ParentNode.Nodes;
            int index = nodes.IndexOf(destNode);
            if(e.InsertType == InsertType.After)
                return ++index;
            return index;
        }
        void OnDragOver(object sender, DragOverEventArgs e) {
            if(object.ReferenceEquals(e.Source, e.Target))
                return;
            e.Default();
            if(e.InsertType == InsertType.None)
                return;
            e.Action = IsCopy(e.KeyState) ? DragDropActions.Copy : DragDropActions.Move;
            Cursor current = Cursors.No;
            if(e.Action != DragDropActions.None)
                current = Cursors.Default;
            e.Cursor = current;
        }
        bool IsCopy(DragDropKeyState key) {
            return (key & DragDropKeyState.Control) != 0;
        }

        DataSet CreateDataSource() {
            string DBFileName = DataDirectoryHelper.GetDataFile("EmployeesGroups.xml");
            if(DBFileName != "") {
                DataSet dataSet = new DataSet();
                dataSet.ReadXml(DBFileName);
                dataSet.Tables[0].Columns.Add("FullName", typeof(string), "FirstName + ' ' + LastName");
                var jobHunter = dataSet.Tables.Add("JobHunter");
                foreach(DataColumn column in dataSet.Tables[0].Columns)
                    jobHunter.Columns.Add(column.ColumnName, column.DataType, column.Expression);
                for(int i = 0; i < 10; i++) {
                    int id = dataSet.Tables[0].Rows.Count - 1;
                    var row = dataSet.Tables[0].Rows[id].ItemArray;
                    dataSet.Tables[0].Rows.RemoveAt(id);
                    jobHunter.Rows.Add(row);
                }
                return dataSet;
            }
            return null;
        }
    }
}
