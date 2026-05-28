using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Localization;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS;

namespace DevExpress.XtraGrid.Demos.CodeExamples {
    [CodeExampleClass("Context menus", "ContextMenus.cs")]
    public static class ContextMenus {
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            GridControl gridControl = new GridControl();
            GridView gridView = new GridView();
            gridControl.MainView = gridView;
            gridControl.Dock = DockStyle.Fill;
            gridControl.Parent = sampleHost;
            gridControl.DataSource = SampleData.GetData(6);
            return new object[] { gridControl, gridView };
        }

        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            (sampleHost.Controls[0] as GridControl).Dispose();
        }
        
        #region Helpers

        [CodeExampleNestedClass("")]
        public static class DemoHelper {

            public static Image GetIcon() {
                Image img = new Bitmap(16, 16);
                using (Graphics g = Graphics.FromImage(img)) {
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    g.FillEllipse(Brushes.Green, new Rectangle(0, 0, img.Width - 1, img.Height - 1));
                }
                return img;
            }
        }

        #endregion

        #region Context menus

        [CodeExampleCase("Prevent a popup menu from being shown"), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("PopupMenuShowing", "Allow")]
        public static void PreventShowingPopupMenu(GridControl gridControl, GridView gridView) {
            // Hide a built-in popup menu for the Notes column
            gridView.PopupMenuShowing += (s, e) => {
                if (e.HitInfo.Column != null && e.HitInfo.Column.FieldName == "Notes")
                    e.Allow = false;
            };
        }

        [CodeExampleCase("Remove items from the column header popup menu", new Type[] {typeof(DemoHelper) }), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("PopupMenuShowing", "Remove"), CodeExampleHighlightTokens("GridStringId")]
        public static void RemoveContextMenuItems(GridControl gridControl, GridView gridView) {            
            // The PopupMenuShowing event fires each time a context menu is about to be displayed.
            //  You can handle the event to manage the popup menu's items
            gridView.PopupMenuShowing += (s, e) => {
                if (e.HitInfo.InColumn && e.HitInfo.Column.FieldName == "ID") {
                    // Remove the Sort Ascending and Sort Descending items from the column header menu
                    e.Menu.Remove(GridStringId.MenuColumnSortAscending);
                    e.Menu.Remove(GridStringId.MenuColumnSortDescending);
                }
            };
        }
        [CodeExampleCase("Add items to the column header popup menu", new Type[] { typeof(DemoHelper) }), SampleDataSourceFile]
        [CodeExampleUnderlineTokens("PopupMenuShowing")]
        public static void AddItemsToContextMenu(GridControl gridControl, GridView gridView) {
            // The PopupMenuShowing event fires each time a context menu is about to be displayed.
            //  You can handle the event to manage the popup menu's items
            gridView.PopupMenuShowing += (s, e) => {
                // Add a custom item to the column header menu
                if (e.MenuType == GridMenuType.Column) {
                    EventHandler customItemClick = null;
                    DXMenuItem customItem = new DXMenuItem("CustomItem") { Image = DemoHelper.GetIcon() };
                    customItemClick = (sender, ea) => {
                        customItem.Click -= customItemClick;
                        //your code here
                        XtraMessageBox.Show("CustomItem is clicked");
                    };
                    customItem.Click += customItemClick;
                    e.Menu.Items.Add(customItem);
                }
            };
        }

        #endregion
    }
}
