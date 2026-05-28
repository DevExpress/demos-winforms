Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Localization
Imports DevExpress.XtraTreeList.Menu

Namespace Examples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Context menus", "ContextMenus.cs")>
    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PopupMenuShowing", "MenuType")>
    Public Module ContextMenusExamples

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim treeList As DevExpress.XtraTreeList.TreeList = New DevExpress.XtraTreeList.TreeList()
            treeList.OptionsBehavior.Editable = False
            treeList.Dock = System.Windows.Forms.DockStyle.Fill
            treeList.Parent = sampleHost
            treeList.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SpaceObject.GetData()
            AddHandler treeList.Load, Sub(s, e) treeList.ExpandAll()
            Return New Object() {treeList}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            For Each control As System.Windows.Forms.Control In sampleHost.Controls
                control.Dispose()
            Next

            sampleHost.Controls.Clear()
        End Sub

        '
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent a popup menu from being shown")>
        Public Sub PreventingMenuShow(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' The PopupMenuShowing event fires each time a context menu is about to be displayed.
            ' You can handle the event to prevent a popup menu from being shown (e.Allow = false)
            AddHandler treeList.PopupMenuShowing, Sub(sender, e)
                If e.Menu.MenuType = DevExpress.XtraTreeList.Menu.TreeListMenuType.Column Then
                    Dim owner As DevExpress.XtraTreeList.TreeList = TryCast(sender, DevExpress.XtraTreeList.TreeList)
                    Dim hitInfo As DevExpress.XtraTreeList.TreeListHitInfo = owner.CalcHitInfo(e.Point)
                    If hitInfo.Column.VisibleIndex Mod 2 = 0 Then e.Allow = False
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Manage the context menu's items")>
        Public Sub ManagingMenuItems(ByVal treeList As DevExpress.XtraTreeList.TreeList)
            ' The PopupMenuShowing event fires each time a context menu is about to be displayed.
            ' You can handle the event to manage the popup menu's items
            AddHandler treeList.PopupMenuShowing, Sub(sender, e)
                If e.Menu.MenuType = DevExpress.XtraTreeList.Menu.TreeListMenuType.Column Then
                    e.Menu.Remove(DevExpress.XtraTreeList.Localization.TreeListStringId.MenuColumnSortAscending)
                    e.Menu.Remove(DevExpress.XtraTreeList.Localization.TreeListStringId.MenuColumnSortDescending)
                End If
            End Sub
        End Sub
    End Module
End Namespace
