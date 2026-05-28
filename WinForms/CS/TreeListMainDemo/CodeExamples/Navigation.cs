namespace Examples {
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.Utils;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;

    [CodeExampleClass("Keyboard Navigation", "Navigation.cs")]
    public static class Navigation {
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
        [CodeExampleCase("Expand/collapse nodes with left/right arrow keys")]
        [CodeExampleUnderlineTokens("OptionsNavigation", "AllowExpandCollapseWithArrowKeys"), CodeExampleVersionID(171)]
        public static void AllowExpandCollapseWithArrowKeys(TreeList treeList) {
            treeList.OptionsNavigation.AllowExpandCollapseWithArrowKeys = DefaultBoolean.True;
        }
    }
}
