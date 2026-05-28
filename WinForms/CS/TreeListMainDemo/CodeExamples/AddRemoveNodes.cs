namespace Examples {
    using System;
    using System.Windows.Forms;
    using System.Xml;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Nodes;

    [CodeExampleClass("Add and remove nodes", "AddRemoveNodes.cs")]
    [CodeExampleUnderlineTokens("AppendNode", "DeleteNode", "DeleteSelectedNodes", "FocusedNode")]
    public static class AddRemoveNodes {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();

            //SimpleButton button = new SimpleButton();
            //button.Dock = DockStyle.Top;
            //button.Parent = sampleHost;
            //button.Height = button.CalcBestSize().Height;
            treeList.Load += (s, e) => {
                treeList.ExpandAll();
                treeList.Columns["Name"].BestFit();
            };

            return new object[] { treeList/*, button*/ };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Appending new nodes"), SpaceObjectCS]
        public static void AppendingNodes(TreeList treeList) {
            SimpleButton appendNodeButton = new SimpleButton() { Dock = DockStyle.Top, Parent = treeList.Parent, Text = "Append node" };
            // UI Binding
            appendNodeButton.Click += (sender, e) => {
                // Appending a new Node
                SpaceObject spaceObject = SpaceObject.New();
                spaceObject.ID = treeList.AllNodesCount;
                spaceObject.ParentID = (treeList.FocusedNode != null) ? treeList.FocusedNode.Id : -1;
                TreeListNode newNode = treeList.AppendNode(
                    nodeData: new object[] {
                        spaceObject.ID,
                        spaceObject.ParentID,
                        spaceObject.Name,
                        spaceObject.Notes,
                        spaceObject.MeanRadiusInKM,
                        spaceObject.MeanRadiusByEarth,
                        spaceObject.TypeOfObject,
                        spaceObject.Mark,
                        spaceObject.RecordDate
                    },
                    parentNode: treeList.FocusedNode
                );
                // Using the newly added node
                treeList.FocusedNode = newNode;
            };
        }
        [CodeExampleCase("Removing a focused node when Ctrl+Delete is pressed")]
        public static void RemovingNode(TreeList treeList) {
            SimpleButton deleteButton = new SimpleButton() { Dock = DockStyle.Top, Parent = treeList.Parent, Text = "Delete focused node" };
            // Delete node action with confirmation
            Action<TreeListNode> deleteNodeWithConfirmation = (node) => {
                if(node == null)
                    return;
                string msg = string.Format("The node {0} is about to be deleted. Do you want to proceed?", node["Name"]);
                if(XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    // Delete Node
                    treeList.DeleteNode(node);
                    // or you can use the TreeListNode.Remove() method
                    // node.Remove();
                }
            };
            // UI Bindings
            treeList.KeyDown += (sender, e) => {
                if(e.KeyCode == Keys.Delete && e.Modifiers == Keys.Control)
                    deleteNodeWithConfirmation(treeList.FocusedNode);
            };
            deleteButton.Click += (sender, e) => {
                deleteNodeWithConfirmation(treeList.FocusedNode);
            };
        }
        [CodeExampleCase("Removing selected nodes")]
        public static void RemovingSelectedNodes(TreeList treeList) {
            SimpleButton deleteButton = new SimpleButton() { Dock = DockStyle.Top, Parent = treeList.Parent, Text = "Delete selected nodes" };
            // Enable multi-selection
            treeList.OptionsSelection.MultiSelect = true;
            treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.RowSelect;
            // UI Binding
            deleteButton.Click += (sender, e) => {
                int count = treeList.Selection.Count;
                if(count == 0)
                    return;
                string msg = string.Format("{0} nodes is about to be deleted. Do you want to proceed?", count);
                if(XtraMessageBox.Show(msg, "Deleting node", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    // Delete selected nodes
                    treeList.DeleteSelectedNodes();
                }
            };
        }
        [CodeExampleCase("Use New Item Row to add nodes")]
        [CodeExampleUnderlineTokens("NewItemRowPosition")]
        public static void UseNewItemRowToAddNodes(TreeList treeList) {
            treeList.OptionsBehavior.Editable = true;
            // Display a New Item Row to add nodes to the TreeList.
            treeList.OptionsView.NewItemRowPosition = TreeListNewItemRowPosition.Top; // Available modes: Top, Bottom, None
        }
        [CodeExampleCase("Use node menu to add nodes")]
        [CodeExampleUnderlineTokens("ShowAddNodeItems")]
        public static void UseNodeMenuToAddRows(TreeList treeList) {
            treeList.OptionsBehavior.Editable = true;
            // Enable Add Node items in the node menu.
            treeList.OptionsMenu.ShowAddNodeItems = DevExpress.Utils.DefaultBoolean.True;
        }
        [CodeExampleCase("Init newly added nodes in a custom manner")]
        [CodeExampleUnderlineTokens("InitNewRow")]
        public static void UseNewItemRowToAddRows(TreeList treeList) {
            treeList.OptionsBehavior.Editable = true;
            treeList.OptionsView.NewItemRowPosition = TreeListNewItemRowPosition.Top;
            // Handle the InitNewRow event to initialize newly added nodes. To initialize row cells use the SetValue method.
            treeList.InitNewRow += (sender, e) => {
                e.SetValue("RecordDate", DateTime.Now);
            };
        }
    }
    [CodeExampleClass("Working with nodes", "AddRemoveNodes.cs")]
    [CodeExampleUnderlineTokens("Nodes", "AddNodes", "ExpandAll", "BestFitColumns")]
    public static class WorkingWithNodes {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Loading nodes from XML", new Type[] { typeof(FamilyXML) })]
        [CodeExampleHighlightTokens("Environment", "XmlDocument", "XmlNode", "SafeXml")]
        public static void LoadingNodesFromXML(TreeList treeList) {
            var xmlRoot = FamilyXML.Document.DocumentElement;
            // Initialize the TreeView control.
            treeList.OptionsView.AutoWidth = false;
            treeList.Columns.AddVisible("Member");
            treeList.Columns.AddVisible("name").Caption = "Name";
            TreeListNode treeRoot = treeList.Nodes.Add(xmlRoot.Name);
            // Use the TreeListNodeExtension.AddNode extension method
            treeRoot.AddNodes(xmlRoot, contentField: "name");
            // Expand all nodes
            treeList.ExpandAll();
            // Best fit the displayed data
            treeList.BestFitColumns();
        }
        [CodeExampleNestedClass]
        public sealed class FamilyXML {
            static string XML =
            @"<?xml version=""1.0""?>" +
                @"<family name=""Smiths"">" +
                    @"<grandfather name=""Bob"">" +
                        @"<father name=""Donald"">" +
                            @"<brother name=""Mike"">" +
                                @"<niece>Ann</niece>" +
                                @"<niece>Mary</niece>" +
                            @"</brother>" +
                            @"<me name=""Alex"">" +
                                @"<son>John</son>" +
                                @"<son>Adam</son>" +
                            @"</me>" +
                            @"<sister>Lise</sister>" +
                        @"</father>" +
                        @"<uncle name=""Sam"">" +
                            @"<cousinsister name=""Eva"">" +
                                @"<secondcousin>Amy</secondcousin>" +
                            @"</cousinsister>" +
                            @"<cousinbrother>Julian</cousinbrother>" +
                        @"</uncle>" +
                    @"</grandfather>" +
                @"</family>";

            static XmlDocument documenCore;
            public static XmlDocument Document {
                get {
                    if(documenCore == null)
                        documenCore = DevExpress.Utils.SafeXml.CreateDocument(XML);
                    return documenCore;
                }
            }
        }
    }
}
