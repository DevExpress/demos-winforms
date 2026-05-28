Imports DevExpress.DXperience.Demos.CodeDemo
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Localization
Imports DevExpress.DXperience.Demos.CodeDemo.Data
Imports SampleDataSourceFile = DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS

Namespace DevExpress.XtraGrid.Demos.CodeExamples

    <DevExpress.DXperience.Demos.CodeDemo.CodeExampleClass("Context menus", "ContextMenus.cs")>
    Public Module ContextMenus

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleSetUp>
        Public Function SetUp(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl) As Object()
            Dim gridControl As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl()
            Dim gridView As DevExpress.XtraGrid.Views.Grid.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            gridControl.MainView = gridView
            gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridControl.Parent = sampleHost
            gridControl.DataSource = DevExpress.DXperience.Demos.CodeDemo.Data.SampleData.GetData(6)
            Return New Object() {gridControl, gridView}
        End Function

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleTearDown>
        Public Sub TearDown(ByVal sampleHost As DevExpress.XtraEditors.XtraUserControl)
            TryCast(sampleHost.Controls(CInt((0))), DevExpress.XtraGrid.GridControl).Dispose()
        End Sub

#Region "Helpers"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleNestedClass("")>
        Public NotInheritable Class DemoHelper

            Public Shared Function GetIcon() As Image
                Dim img As System.Drawing.Image = New System.Drawing.Bitmap(16, 16)
                Using g As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(img)
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias
                    g.FillEllipse(System.Drawing.Brushes.Green, New System.Drawing.Rectangle(0, 0, img.Width - 1, img.Height - 1))
                End Using

                Return img
            End Function
        End Class

#End Region
#Region "Context menus"
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Prevent a popup menu from being shown"), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PopupMenuShowing", "Allow")>
        Public Sub PreventShowingPopupMenu(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' Hide a built-in popup menu for the Notes column
            AddHandler gridView.PopupMenuShowing, Sub(s, e)
                If e.HitInfo.Column IsNot Nothing AndAlso Equals(e.HitInfo.Column.FieldName, "Notes") Then e.Allow = False
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Remove items from the column header popup menu", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.ContextMenus.DemoHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PopupMenuShowing", "Remove"), DevExpress.DXperience.Demos.CodeDemo.CodeExampleHighlightTokens("GridStringId")>
        Public Sub RemoveContextMenuItems(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The PopupMenuShowing event fires each time a context menu is about to be displayed.
            '  You can handle the event to manage the popup menu's items
            AddHandler gridView.PopupMenuShowing, Sub(s, e)
                If e.HitInfo.InColumn AndAlso Equals(e.HitInfo.Column.FieldName, "ID") Then
                    ' Remove the Sort Ascending and Sort Descending items from the column header menu
                    e.Menu.Remove(DevExpress.XtraGrid.Localization.GridStringId.MenuColumnSortAscending)
                    e.Menu.Remove(DevExpress.XtraGrid.Localization.GridStringId.MenuColumnSortDescending)
                End If
            End Sub
        End Sub

        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleCase("Add items to the column header popup menu", New System.Type() {GetType(DevExpress.XtraGrid.Demos.CodeExamples.ContextMenus.DemoHelper)}), DevExpress.XtraGrid.Demos.CodeExamples.SampleDataCS>
        <DevExpress.DXperience.Demos.CodeDemo.CodeExampleUnderlineTokens("PopupMenuShowing")>
        Public Sub AddItemsToContextMenu(ByVal gridControl As DevExpress.XtraGrid.GridControl, ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
            ' The PopupMenuShowing event fires each time a context menu is about to be displayed.
            '  You can handle the event to manage the popup menu's items
            AddHandler gridView.PopupMenuShowing, Sub(s, e)
                ' Add a custom item to the column header menu
                If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                    Dim customItemClick As System.EventHandler = Nothing
                    Dim customItem As DevExpress.Utils.Menu.DXMenuItem = New DevExpress.Utils.Menu.DXMenuItem("CustomItem") With {.Image = DevExpress.XtraGrid.Demos.CodeExamples.ContextMenus.DemoHelper.GetIcon()}
                    customItemClick = Sub(sender, ea)
                        RemoveHandler customItem.Click, customItemClick
                        'your code here
                        Call DevExpress.XtraEditors.XtraMessageBox.Show("CustomItem is clicked")
                    End Sub
                    AddHandler customItem.Click, customItemClick
                    e.Menu.Items.Add(customItem)
                End If
            End Sub
        End Sub
#End Region
    End Module
End Namespace
