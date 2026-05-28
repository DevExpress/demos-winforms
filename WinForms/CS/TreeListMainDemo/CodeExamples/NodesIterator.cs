namespace Examples {
    using System;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Columns;
    using DevExpress.XtraTreeList.Nodes;
    using DevExpress.XtraTreeList.Nodes.Operations;

    [CodeExampleClass("Nodes iterator", "NodesIterator.cs")]
    public static class NodesIterator {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            treeList.Load += (s, e) => {
                treeList.Nodes[0].Expand();
                treeList.Nodes[0].Nodes[0].Expand();
            };
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Allow only one node at level to be expanded", new Type[] { typeof(OperationCollapseAllButThis) })]
        [CodeExampleUnderlineTokens("DoOperation", "DoLocalOperation", "OperationCollapseAllButThis"), CodeExampleVersionID(171)]
        public static void CollapseAllButThisIterator(TreeList treeList) {
            treeList.BeforeExpand += (sender, e) =>
            {
                OperationCollapseAllButThis op = new OperationCollapseAllButThis(e.Node);
                treeList.BeginUpdate();
                if(e.Node.ParentNode == null)
                    treeList.NodesIterator.DoOperation(op);
                else
                    treeList.NodesIterator.DoLocalOperation(op, e.Node.ParentNode.Nodes);
                treeList.EndUpdate();
            };
        }
        [CodeExampleCase("Allow only one node at level to be expanded(LINQ)")]
        [CodeExampleUnderlineTokens("Do", "DoLocal"), CodeExampleVersionID(171)]
        public static void CollapseAllButThisAction(TreeList treeList) {
            treeList.BeforeExpand += (sender, e) =>
            {
                Action<TreeListNode> collapseAllButThis = node =>
                {
                    if(!object.ReferenceEquals(node, e.Node))
                        node.Expanded = false;
                };
                treeList.BeginUpdate();
                if(e.Node.ParentNode == null)
                    treeList.NodesIterator.Do(collapseAllButThis);
                else
                    treeList.NodesIterator.DoLocal(collapseAllButThis, e.Node.ParentNode.Nodes);
                treeList.EndUpdate();
            };
        }
        [CodeExampleCase("Set value of child nodes when parent's value is changed")]
        [CodeExampleUnderlineTokens("CellValueChanged", "DoLocal"), CodeExampleVersionID(171)]
        public static void RecursiveCellChecking(TreeList treeList) {
            // Make the all the columns except Mark non-editable
            treeList.OptionsBehavior.Editable = true;
            TreeListColumn markColumn = treeList.Columns["Mark"];
            foreach(TreeListColumn column in treeList.Columns) {
                if(column == markColumn) 
                    continue;
                column.OptionsColumn.AllowEdit = false;
            }
            // Post the check value editor immediately
            markColumn.RealColumnEdit.EditValueChanged += (sender, e) =>
                treeList.PostEditor();

            // Proceed all the nested nodes
            treeList.CellValueChanged += (sender, e) =>
            {
                treeList.NodesIterator.DoLocal(
                        execute: node => node[e.Column] = e.Value,
                        nodes: e.Node.Nodes
                    );
                //
                TreeListNode parent = e.Node.ParentNode;
                bool markValue = object.Equals(e.Value, true);
                while(parent != null) {
                    if(markValue) {
                        bool allChildrenHasMark = true;
                        treeList.NodesIterator.DoLocal(
                            execute: node => allChildrenHasMark &= !object.Equals(node[e.Column], false),
                            nodes: parent.Nodes);
                        parent["Mark"] = allChildrenHasMark;
                    }
                    else {
                        parent["Mark"] = false;
                    }
                    parent = parent.ParentNode;
                }
            };
        }
        [CodeExampleNestedClass]
        public class OperationCollapseAllButThis : TreeListOperation {
            TreeListNode nodeCore;
            public OperationCollapseAllButThis(TreeListNode node) {
                nodeCore = node;
            }
            public override bool NeedsVisitChildren(TreeListNode node) {
                return true;
            }
            public override bool CanContinueIteration(TreeListNode node) {
                return true;
            }
            public override bool NeedsFullIteration {
                get { return false; }
            }
            public override void Execute(TreeListNode node) {
                if(node == nodeCore)
                    return;
                node.Expanded = false;
            }
        }
    }
}
