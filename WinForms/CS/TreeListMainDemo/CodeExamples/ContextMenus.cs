namespace Examples {
    using System.Linq;
    using System.Windows.Forms;
    using DevExpress.DXperience.Demos.CodeDemo;
    using DevExpress.DXperience.Demos.CodeDemo.Data;
    using DevExpress.Utils.Menu;
    using DevExpress.XtraEditors;
    using DevExpress.XtraTreeList;
    using DevExpress.XtraTreeList.Localization;
    using DevExpress.XtraTreeList.Menu;

    [CodeExampleClass("Context menus", "ContextMenus.cs")]
    [CodeExampleUnderlineTokens("PopupMenuShowing", "MenuType")]
    public static class ContextMenusExamples {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            TreeList treeList = new TreeList();
            treeList.OptionsBehavior.Editable = false;
            treeList.Dock = System.Windows.Forms.DockStyle.Fill;
            treeList.Parent = sampleHost;
            treeList.DataSource = SpaceObject.GetData();
            treeList.Load += (s, e) =>
                treeList.ExpandAll();
            return new object[] { treeList };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            foreach(Control control in sampleHost.Controls)
                control.Dispose();
            sampleHost.Controls.Clear();
        }
        //
        [CodeExampleCase("Prevent a popup menu from being shown")]
        public static void PreventingMenuShow(TreeList treeList) {
            // The PopupMenuShowing event fires each time a context menu is about to be displayed.
            // You can handle the event to prevent a popup menu from being shown (e.Allow = false)
            treeList.PopupMenuShowing += (sender, e) =>
            {
                if(e.Menu.MenuType == TreeListMenuType.Column) {
                    TreeList owner = sender as TreeList;
                    TreeListHitInfo hitInfo = owner.CalcHitInfo(e.Point);
                    if(hitInfo.Column.VisibleIndex % 2 == 0)
                        e.Allow = false;
                }
            };
        }
        [CodeExampleCase("Manage the context menu's items")]
        public static void ManagingMenuItems(TreeList treeList) {
            // The PopupMenuShowing event fires each time a context menu is about to be displayed.
            // You can handle the event to manage the popup menu's items
            treeList.PopupMenuShowing += (sender, e) =>
            {
                if(e.Menu.MenuType == TreeListMenuType.Column) {
                    e.Menu.Remove(TreeListStringId.MenuColumnSortAscending);
                    e.Menu.Remove(TreeListStringId.MenuColumnSortDescending);
                }
            };
        }
    }
}
