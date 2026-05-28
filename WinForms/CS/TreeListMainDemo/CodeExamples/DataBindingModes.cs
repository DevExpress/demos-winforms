namespace Examples {
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Nodes;

    [CodeExampleClass("Data-binding modes", "DataBindingModes.cs")]
    public static class DataBindingModes {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSourceChanged += (s, e) =>
            {
                if(treeList.DataSource is IEnumerable<SpaceObject>) {
                    treeList.ExpandAll();
                    treeList.Columns["Name"].BestFit();
                }
            };
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        [CodeExampleCase("Bound mode"), SpaceObjectCS]
        [CodeExampleUnderlineTokens("KeyFieldName", "ParentFieldName", "DataSource")]
        public static void InitializeDataBoundMode(TreeList treeList) {
            // Initialize the Data Source with list of self-references objects
            // All the columns will be created automatically
            // To generate Key/Parent columns(service columns) uncomment the following line
            // treeList.OptionsBehavior.PopulateServiceColumns = true;
            treeList.KeyFieldName = "ID";
            treeList.ParentFieldName = "ParentID";
            treeList.DataSource = SpaceObject.LoadData();
        }
        [CodeExampleCase("Unbound mode")]
        [CodeExampleUnderlineTokens("AppendNode")]
        public static void InitializeDataUnboundMode(TreeList treeList) {
            // Add the column
            treeList.Columns.AddVisible("Text");
            //  TreeList.AppendNode adds a new TreeListNode containing the specified values to the XtraTreeList.
            for(int i = 0; i < 5; i++) {
                TreeListNode node = treeList.AppendNode(new object[] { "Root Node " + i.ToString() }, parentNode: null);
                for(int j = i + 1; j < i + 3; j++)
                    treeList.AppendNode(new object[] { "Child Node " + j.ToString() }, parentNode: node);
            }
        }
        [CodeExampleCase("Virtual mode", new Type[] { typeof(VirtualData) })]
        [CodeExampleUnderlineTokens("DataSource")]
        public static void InitializeDataVirtualMode(TreeList treeList) {
            // Add the column
            treeList.Columns.AddVisible("Text");
            // Initialize the Data Source with object that implements IVirtualTreeListData interface
            treeList.DataSource = new VirtualData();
        }
        [CodeExampleNestedClass]
        public class VirtualData : TreeList.IVirtualTreeListData {
            const int LevelCapacity = 10;
            readonly int parentID;
            readonly int levelCore;
            public VirtualData() {
                parentID = 0;
            }
            VirtualData(string id, int parentID, int level) {
                this.parentID = parentID;
                this.levelCore = level;
                this.Text = "Level " + level.ToString() + ": Node" + id;
            }
            public string Text {
                get;
                set;
            }
            public int Level { get { return levelCore; } }
            void TreeList.IVirtualTreeListData.VirtualTreeGetCellValue(VirtualTreeGetCellValueInfo info) {
                var virtualData = ((VirtualData)info.Node);
                info.CellData = virtualData.Text;
            }
            void TreeList.IVirtualTreeListData.VirtualTreeSetCellValue(VirtualTreeSetCellValueInfo info) {
                var virtualData = ((VirtualData)info.Node);
                virtualData.Text = info.NewCellData.ToString();
            }
            void TreeList.IVirtualTreeListData.VirtualTreeGetChildNodes(VirtualTreeGetChildNodesInfo info) {
                if(parentID > 0 && int.MaxValue / parentID < LevelCapacity)
                    return;
                var virtualDataNode = ((VirtualData)info.Node);
                List<VirtualData> children = new List<VirtualData>();
                int startIndex = (parentID * LevelCapacity) + 1;
                for(int i = startIndex; i <= LevelCapacity - (2 * Level) + startIndex - 1; i++)
                    children.Add(new VirtualData(i.ToString(), i, virtualDataNode.Level + 1));
                info.Children = children;
            }
        }
    }
}
