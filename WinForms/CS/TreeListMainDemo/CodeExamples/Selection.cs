namespace Examples {
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;

    [CodeExampleClass("Selection", "Selection.cs")]
    public static class Selection {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.LoadData();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Multiple row/cell selection")]
        [CodeExampleUnderlineTokens("OptionsSelection", "SelectCells")]
        public static void CustomizingSelection(TreeList treeList) {
            // This property controls whether multi-select feature is enabled
            treeList.OptionsSelection.MultiSelect = true;
            // Controls whether multiple cells or rows can be selected
            // Available modes:
            //     CellSelect - Individual cells and blocks of cells can be selected.  
            //     RowSelect - Multiple rows can be selected using the mouse and keyboard. Individual cells cannot be selected.
            treeList.OptionsSelection.MultiSelectMode = TreeListMultiSelectMode.CellSelect;
            // select some cells after loading
            treeList.Load += (s, e) =>
            {
                treeList.ExpandAll();
                //
                var colNotes = treeList.Columns["Notes"];
                var colMark = treeList.Columns["Mark"];
                var jupiterNodes = treeList.Nodes[0].Nodes[0].Nodes;
                treeList.SelectCells(
                        startNode: jupiterNodes.FirstNode, startColumn: colNotes,
                        endNode: jupiterNodes.LastNode, endColumn: colMark);
            };
        }
    }
}
