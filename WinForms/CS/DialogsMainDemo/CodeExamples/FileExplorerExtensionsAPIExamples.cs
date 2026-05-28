using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Dialogs.ContextMenu;
using DevExpress.Dialogs.Core.ViewModel;
using DevExpress.DXperience.Demos.CodeDemo;
using DevExpress.DXperience.Demos.CodeDemo.Data;
using DevExpress.DXperience.Demos.CodeDemo.Helpers;
using DevExpress.Internal;
using DevExpress.Utils.Html;
using DevExpress.XtraDialogs;
using DevExpress.XtraDialogs.Base;
using DevExpress.XtraDialogs.FileExplorerExtensions;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraTreeList;

namespace DevExpress.XtraDialogs.Demos.CodeExamples {
    [CodeExampleClass("How to extend the GridControl to List View", "FileExplorerExtensionsAPIExamples.cs")]
    public static class GridControlExtensionExample {
        static GridControlExtensionExample() {
            if(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0)
                DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize();
        }
        //
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var assistant = new FileExplorerAssistant(sampleHost.Container);
            assistant.BeginInit();
            assistant.Form = sampleHost;
            assistant.EndInit();

            var grid = new GridControl();
            var gridView = new GridView(grid);
            grid.MainView = gridView;
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            grid.Parent = sampleHost;
            string initialPath;
            string demoFilePath = DataDirectoryHelper.GetDataFile("DemoText.txt");
            if(demoFilePath != string.Empty)
                initialPath = System.IO.Path.GetDirectoryName(demoFilePath);
            else
                initialPath = DevExpress.Data.Utils.SafeEnvironment.DesktopDirectory;
            return new object[] { assistant, grid, initialPath };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var assistant = FileExplorerAssistant.FromControl(sampleHost);
            if(assistant != null) assistant.Dispose();
        }

        [CodeExampleCase("How to start via the CurrentPath")]
        [CodeExampleUnderlineTokens("CurrentPath")]
        public static void HowToUseCurrentPath(FileExplorerAssistant assistant, GridControl grid, string initialPath) {
            assistant.Attach(grid, x => {
                x.CurrentPath = DevExpress.Data.Utils.SafeEnvironment.MyDocuments;
            });
        }
        [CodeExampleCase("How to setup default sorting")]
        [CodeExampleUnderlineTokens("DefaultSorting")]
        public static void HowToSetUpDefaultSorting(FileExplorerAssistant assistant, GridControl grid, string initialPath) {
            assistant.Attach(grid, x => {
                x.CurrentPath = DevExpress.Data.Utils.SafeEnvironment.MyDocuments;
                // Name, DateModified, TypeName, Size
                x.DefaultSorting = "DateModified ASC; Name";
            });
        }
        [CodeExampleCase("How to prevent the item command from executing")]
        [CodeExampleUnderlineTokens("BeforeExecuteItemCommand")]
        public static void HowToPreventExecuteItemCommand(FileExplorerAssistant assistant, GridControl grid, string initialPath) {
            assistant.Attach(grid, x => {
                x.CurrentPath = initialPath;
                x.BeforeExecuteItemCommand += (s, e) => {
                    if(e.CommandName == ItemCommandNames.DeleteCommand) {
                        XtraMessageBox.Show(string.Format("{0} can not be deleted", e.Item.Name), "Warning");
                        e.Cancel = true;
                    }
                };
            });
        }
        [CodeExampleCase("How to remove items from the context menu")]
        [CodeExampleUnderlineTokens("ContextMenuShowing", "MenuItems")]
        public static void HowToRemoveItemsFromContextMenu(FileExplorerAssistant assistant, GridControl grid, string initialPath) {
            assistant.Attach(grid, x => {
                x.CurrentPath = initialPath;
                x.ContextMenuShowing += (s, e) => {
                    ContextMenuItem deleteCommandItem = e.MenuItems.FirstOrDefault(item => item.CommandName == ItemCommandNames.DeleteCommand);
                    ContextMenuItem cutCommandItem = e.MenuItems.FirstOrDefault(item => item.CommandName == ItemCommandNames.CutCommand);

                    e.MenuItems.Remove(deleteCommandItem);
                    e.MenuItems.Remove(cutCommandItem);
                };
            });
        }
        [CodeExampleCase("How to add custom commands to the context menu")]
        [CodeExampleUnderlineTokens("ContextMenuShowing", "MenuItems")]
        public static void HowToAddCustomCommandsToContextMenu(FileExplorerAssistant assistant, GridControl grid, string initialPath) {
            assistant.Attach(grid, x => {
                x.CurrentPath = initialPath;
                string customCommandName = "custom";
                x.ContextMenuShowing += (s, e) => {
                    e.MenuItems.AddCommand("Custom command", customCommandName);
                };
                x.BeforeExecuteItemCommand += (s, e) => {
                    if(e.CommandName == customCommandName) {
                        XtraMessageBox.Show("Custom command executed");
                        e.Cancel = true;
                    }
                };
            });
        }
        [CodeExampleCase("How to insert a SubItem into the context menu")]
        [CodeExampleUnderlineTokens("ContextMenuShowing", "MenuItems", "InsertSubItem", "Items")]
        public static void HowToInsertSubItemToContextMenu(FileExplorerAssistant assistant, GridControl grid, string initialPath) {
            assistant.Attach(grid, x => {
                x.CurrentPath = initialPath;
                string customCommandName = "custom";
                x.ContextMenuShowing += (s, e) => {
                    ContextMenuItem subItem = e.MenuItems.InsertSubItem(0, "Custom SubItem");
                    subItem.Items.AddCommand("Custom command", customCommandName);
                };
                x.BeforeExecuteItemCommand += (s, e) => {
                    if(e.CommandName == customCommandName) {
                        XtraMessageBox.Show("Custom command executed");
                        e.Cancel = true;
                    }
                };
            });
        }
    }
    [CodeExampleClass("How to extend the TreeList to Folders Tree", "FileExplorerExtensionsAPIExamples.cs")]
    public static class TreeListExtensionExample {
        static TreeListExtensionExample() {
            if(DevExpress.XtraTreeList.TreeList.AutoFilterNodeId < 0)
                DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize();
        }
        //
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var assistant = new FileExplorerAssistant(sampleHost.Container);
            assistant.BeginInit();
            assistant.Form = sampleHost;
            assistant.EndInit();
            var tree = new TreeList();
            tree.Dock = System.Windows.Forms.DockStyle.Fill;
            tree.Parent = sampleHost;
            return new object[] { assistant, tree };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var assistant = FileExplorerAssistant.FromControl(sampleHost);
            if(assistant != null) assistant.Dispose();
        }

        [CodeExampleCase("How to start via the specific path")]
        [CodeExampleUnderlineTokens("RootNodes")]
        public static void HowToUsePathNodes(FileExplorerAssistant assistant, TreeList tree) {
            assistant.Attach(tree, x => {
                x.RootNodes.Add(new PathNode(@"c:\"));
            });
        }
#pragma warning disable DX0019
        [CodeExampleCase("How to start via the special folder")]
        [CodeExampleUnderlineTokens("RootNodes")]
        public static void HowToUseRootNodes(FileExplorerAssistant assistant, TreeList tree) {
            assistant.Attach(tree, x => {
                x.RootNodes.Add(new EnvironmentSpecialFolderNode(Environment.SpecialFolder.MyComputer));
            });
        }
#pragma warning restore DX0019
    }

    [CodeExampleClass("How to extend the PanelControl to File Preview", "FileExplorerExtensionsAPIExamples.cs")]
    public static class PreviewPanelExtensionExample {
        static PreviewPanelExtensionExample() {
            if(DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0)
                DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize();
        }
        //
        [CodeExampleSetUp]
        public static object[] SetUp(XtraUserControl sampleHost) {
            var assistant = new FileExplorerAssistant(sampleHost.Container);
            assistant.BeginInit();
            assistant.Form = sampleHost;
            assistant.EndInit();

            var panel = new PanelControl();
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panel.Dock = DockStyle.Fill;
            panel.Parent = sampleHost;

            var sidePanel = new SidePanel();
            sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            sidePanel.Parent = sampleHost;
            sidePanel.Width = 400;

            var grid = new GridControl();
            var gridView = new GridView(grid);
            grid.MainView = gridView;
            grid.Dock = System.Windows.Forms.DockStyle.Fill;
            grid.Parent = sidePanel;

            string initialPath;
            string demoFilePath = DataDirectoryHelper.GetDataFile("DemoText.txt");
            if(demoFilePath != string.Empty)
                initialPath = System.IO.Path.GetDirectoryName(demoFilePath);
            else
                initialPath = DevExpress.Data.Utils.SafeEnvironment.DesktopDirectory;
            return new object[] { assistant, grid, panel, initialPath };
        }
        [CodeExampleTearDown]
        public static void TearDown(XtraUserControl sampleHost) {
            var assistant = FileExplorerAssistant.FromControl(sampleHost);
            if(assistant != null) assistant.Dispose();
        }

        [CodeExampleCase("How to use NavigationBinding to show a file preview")]
        [CodeExampleUnderlineTokens("NavigationBindings")]
        public static void HowToBindPreviewPanel(FileExplorerAssistant assistant, GridControl grid, PanelControl panel, string initialPath) {
            var gridExtension = assistant.Attach(grid, x => {
                x.CurrentPath = initialPath;
            });
            var previewExtension = assistant.Attach(panel);
            assistant.NavigationBindings.Add(new NavigationBinding() { Source = gridExtension, Target = previewExtension });
        }

        [CodeExampleCase("How to use a custom Preview Handler"), SvgPreviewHandlerCS]
        [CodeExampleUnderlineTokens("CustomizePreview")]
        public static void HowToUseCustomPreviewHandler(FileExplorerAssistant assistant, GridControl grid, PanelControl panel, string initialPath) {
            var gridExtension = assistant.Attach(grid, x => {
                x.CurrentPath = initialPath;
                x.ItemsType = DataSourceItemsType.Items;
                x.FilterString = "Svg files (*.svg)|*.svg";
            });
            var previewExtension = assistant.Attach(panel, x => {
                x.CustomizePreview += (s, e) => {
                    if(e.Item.Extension.ToLower() == ".svg")
                        e.CustomPreviewHandler = new SvgPreviewHandler();
                };
            });
            assistant.NavigationBindings.Add(new NavigationBinding() { Source = gridExtension, Target = previewExtension });
        }
    }
}
