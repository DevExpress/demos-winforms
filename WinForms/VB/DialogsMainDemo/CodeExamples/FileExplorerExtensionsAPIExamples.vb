Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Dialogs.ContextMenu
Imports DevExpress.Dialogs.Core.ViewModel
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.DXperience.Demos.CodeDemo.Helpers
Imports DevExpress.Internal
Imports DevExpress.Utils.Html
Imports DevExpress.XtraDialogs
Imports DevExpress.XtraDialogs.Base
Imports DevExpress.XtraDialogs.FileExplorerExtensions
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTreeList

Namespace DevExpress.XtraDialogs.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("How to extend the GridControl to List View", "FileExplorerExtensionsAPIExamples.cs")>
    Public Module GridControlExtensionExample

        Sub New()
            If DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0 Then DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim assistant = New DevExpress.XtraDialogs.FileExplorerAssistant(sampleHost.Container)
            assistant.BeginInit()
            assistant.Form = sampleHost
            assistant.EndInit()
            Dim grid = New DevExpress.XtraGrid.GridControl()
            Dim gridView = New DevExpress.XtraGrid.Views.Grid.GridView(grid)
            grid.MainView = gridView
            grid.Dock = System.Windows.Forms.DockStyle.Fill
            grid.Parent = sampleHost
            Dim initialPath As String
            Dim demoFilePath As String = DevExpress.Internal.DataDirectoryHelper.GetDataFile("DemoText.txt")
            If Not Equals(demoFilePath, String.Empty) Then
                initialPath = System.IO.Path.GetDirectoryName(demoFilePath)
            Else
                initialPath = DevExpress.Data.Utils.SafeEnvironment.DesktopDirectory
            End If

            Return New Object() {assistant, grid, initialPath}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim assistant = DevExpress.XtraDialogs.FileExplorerAssistant.FromControl(sampleHost)
            If assistant IsNot Nothing Then assistant.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to start via the CurrentPath")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CurrentPath")>
        Public Sub HowToUseCurrentPath(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal initialPath As String)
            assistant.Attach(grid, Sub(x) x.CurrentPath = DevExpress.Data.Utils.SafeEnvironment.MyDocuments)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to setup default sorting")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("DefaultSorting")>
        Public Sub HowToSetUpDefaultSorting(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal initialPath As String)
            assistant.Attach(grid, Sub(x)
                x.CurrentPath = DevExpress.Data.Utils.SafeEnvironment.MyDocuments
                ' Name, DateModified, TypeName, Size
                x.DefaultSorting = "DateModified ASC; Name"
            End Sub)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to prevent the item command from executing")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("BeforeExecuteItemCommand")>
        Public Sub HowToPreventExecuteItemCommand(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal initialPath As String)
            assistant.Attach(grid, Sub(x)
                x.CurrentPath = initialPath
                AddHandler x.BeforeExecuteItemCommand, Sub(s, e)
                    If Equals(e.CommandName, DevExpress.XtraDialogs.Base.ItemCommandNames.DeleteCommand) Then
                        Call DevExpress.XtraEditors.XtraMessageBox.Show(String.Format("{0} can not be deleted", e.Item.Name), "Warning")
                        e.Cancel = True
                    End If
                End Sub
            End Sub)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to remove items from the context menu")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ContextMenuShowing", "MenuItems")>
        Public Sub HowToRemoveItemsFromContextMenu(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal initialPath As String)
            assistant.Attach(grid, Sub(x)
                x.CurrentPath = initialPath
                AddHandler x.ContextMenuShowing, Sub(s, e)
                    Dim deleteCommandItem As DevExpress.Dialogs.ContextMenu.ContextMenuItem = e.MenuItems.FirstOrDefault(Function(item) Equals(item.CommandName, DevExpress.XtraDialogs.Base.ItemCommandNames.DeleteCommand))
                    Dim cutCommandItem As DevExpress.Dialogs.ContextMenu.ContextMenuItem = e.MenuItems.FirstOrDefault(Function(item) Equals(item.CommandName, DevExpress.XtraDialogs.Base.ItemCommandNames.CutCommand))
                    e.MenuItems.Remove(deleteCommandItem)
                    e.MenuItems.Remove(cutCommandItem)
                End Sub
            End Sub)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to add custom commands to the context menu")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ContextMenuShowing", "MenuItems")>
        Public Sub HowToAddCustomCommandsToContextMenu(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal initialPath As String)
            assistant.Attach(grid, Sub(x)
                x.CurrentPath = initialPath
                Dim customCommandName As String = "custom"
                AddHandler x.ContextMenuShowing, Sub(s, e) e.MenuItems.AddCommand("Custom command", customCommandName)
                AddHandler x.BeforeExecuteItemCommand, Sub(s, e)
                    If Equals(e.CommandName, customCommandName) Then
                        Call DevExpress.XtraEditors.XtraMessageBox.Show("Custom command executed")
                        e.Cancel = True
                    End If
                End Sub
            End Sub)
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to insert a SubItem into the context menu")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("ContextMenuShowing", "MenuItems", "InsertSubItem", "Items")>
        Public Sub HowToInsertSubItemToContextMenu(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal initialPath As String)
            assistant.Attach(grid, Sub(x)
                x.CurrentPath = initialPath
                Dim customCommandName As String = "custom"
                AddHandler x.ContextMenuShowing, Sub(s, e)
                    Dim subItem As DevExpress.Dialogs.ContextMenu.ContextMenuItem = e.MenuItems.InsertSubItem(0, "Custom SubItem")
                    subItem.Items.AddCommand("Custom command", customCommandName)
                End Sub
                AddHandler x.BeforeExecuteItemCommand, Sub(s, e)
                    If Equals(e.CommandName, customCommandName) Then
                        Call DevExpress.XtraEditors.XtraMessageBox.Show("Custom command executed")
                        e.Cancel = True
                    End If
                End Sub
            End Sub)
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("How to extend the TreeList to Folders Tree", "FileExplorerExtensionsAPIExamples.cs")>
    Public Module TreeListExtensionExample

        Sub New()
            If DevExpress.XtraTreeList.TreeList.AutoFilterNodeId < 0 Then DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim assistant = New DevExpress.XtraDialogs.FileExplorerAssistant(sampleHost.Container)
            assistant.BeginInit()
            assistant.Form = sampleHost
            assistant.EndInit()
            Dim tree = New DevExpress.XtraTreeList.TreeList()
            tree.Dock = System.Windows.Forms.DockStyle.Fill
            tree.Parent = sampleHost
            Return New Object() {assistant, tree}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim assistant = DevExpress.XtraDialogs.FileExplorerAssistant.FromControl(sampleHost)
            If assistant IsNot Nothing Then assistant.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to start via the specific path")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RootNodes")>
        Public Sub HowToUsePathNodes(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal tree As DevExpress.XtraTreeList.TreeList)
            assistant.Attach(tree, Sub(x) x.RootNodes.Add(New DevExpress.XtraDialogs.FileExplorerExtensions.PathNode("c:\")))
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to start via the special folder")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("RootNodes")>
        Public Sub HowToUseRootNodes(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal tree As DevExpress.XtraTreeList.TreeList)
            assistant.Attach(tree, Sub(x) x.RootNodes.Add(New DevExpress.XtraDialogs.FileExplorerExtensions.EnvironmentSpecialFolderNode(System.Environment.SpecialFolder.MyComputer)))
        End Sub
    End Module

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("How to extend the PanelControl to File Preview", "FileExplorerExtensionsAPIExamples.cs")>
    Public Module PreviewPanelExtensionExample

        Sub New()
            If DevExpress.XtraGrid.GridControl.AutoFilterRowHandle < 0 Then DevExpress.XtraEditors.Base.XtraCommonDialog.ForceInitialize()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim assistant = New DevExpress.XtraDialogs.FileExplorerAssistant(sampleHost.Container)
            assistant.BeginInit()
            assistant.Form = sampleHost
            assistant.EndInit()
            Dim panel = New DevExpress.XtraEditors.PanelControl()
            panel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            panel.Dock = System.Windows.Forms.DockStyle.Fill
            panel.Parent = sampleHost
            Dim sidePanel = New DevExpress.XtraEditors.SidePanel()
            sidePanel.Dock = System.Windows.Forms.DockStyle.Left
            sidePanel.Parent = sampleHost
            sidePanel.Width = 400
            Dim grid = New DevExpress.XtraGrid.GridControl()
            Dim gridView = New DevExpress.XtraGrid.Views.Grid.GridView(grid)
            grid.MainView = gridView
            grid.Dock = System.Windows.Forms.DockStyle.Fill
            grid.Parent = sidePanel
            Dim initialPath As String
            Dim demoFilePath As String = DevExpress.Internal.DataDirectoryHelper.GetDataFile("DemoText.txt")
            If Not Equals(demoFilePath, String.Empty) Then
                initialPath = System.IO.Path.GetDirectoryName(demoFilePath)
            Else
                initialPath = DevExpress.Data.Utils.SafeEnvironment.DesktopDirectory
            End If

            Return New Object() {assistant, grid, panel, initialPath}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            Dim assistant = DevExpress.XtraDialogs.FileExplorerAssistant.FromControl(sampleHost)
            If assistant IsNot Nothing Then assistant.Dispose()
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to use NavigationBinding to show a file preview")>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("NavigationBindings")>
        Public Sub HowToBindPreviewPanel(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal initialPath As String)
            Dim gridExtension = assistant.Attach(grid, Sub(x) x.CurrentPath = initialPath)
            Dim previewExtension = assistant.Attach(panel)
            assistant.NavigationBindings.Add(New DevExpress.XtraDialogs.NavigationBinding() With {.Source = gridExtension, .Target = previewExtension})
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("How to use a custom Preview Handler"), DevExpress.XtraDialogs.Demos.CodeExamples.SvgPreviewHandlerCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("CustomizePreview")>
        Public Sub HowToUseCustomPreviewHandler(ByVal assistant As DevExpress.XtraDialogs.FileExplorerAssistant, ByVal grid As DevExpress.XtraGrid.GridControl, ByVal panel As DevExpress.XtraEditors.PanelControl, ByVal initialPath As String)
            Dim gridExtension = assistant.Attach(grid, Sub(x)
                x.CurrentPath = initialPath
                x.ItemsType = DevExpress.Dialogs.Core.ViewModel.DataSourceItemsType.Items
                x.FilterString = "Svg files (*.svg)|*.svg"
            End Sub)
            Dim previewExtension = assistant.Attach(panel, Sub(x)
                AddHandler x.CustomizePreview, Sub(s, e)
                    If Equals(e.Item.Extension.ToLower(), ".svg") Then e.CustomPreviewHandler = New DevExpress.DXperience.Demos.CodeDemo.Data.SvgPreviewHandler()
                End Sub
            End Sub)
            assistant.NavigationBindings.Add(New DevExpress.XtraDialogs.NavigationBinding() With {.Source = gridExtension, .Target = previewExtension})
        End Sub
    End Module
End Namespace
