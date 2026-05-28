Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes

Namespace DevExpress.ApplicationUI.Demos

    Public Partial Class ucSolutionExplorer
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            InitTreeView(treeView)
            AddHandler treeView.CustomDrawNodeCell, AddressOf treeView_CustomDrawNodeCell
            AddHandler treeView.AfterCollapse, AddressOf treeView_AfterCollapse
            AddHandler treeView.AfterExpand, AddressOf treeView_AfterExpand
            AddAllNodes(iShow.Down)
        End Sub

        Public Shared Sub InitTreeView(ByVal treeView As TreeList)
            Dim column As TreeListColumn = treeView.Columns.Add()
            column.Visible = True
            treeView.OptionsView.ShowColumns = False
            treeView.OptionsView.ShowIndicator = False
            treeView.OptionsView.ShowVertLines = False
            treeView.OptionsView.ShowHorzLines = False
            treeView.OptionsBehavior.Editable = False
            treeView.OptionsSelection.EnableAppearanceFocusedCell = False
        End Sub

        Private Sub treeView_CustomDrawNodeCell(ByVal sender As Object, ByVal e As CustomDrawNodeCellEventArgs)
            If e.Node.Id = 1 Then e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        End Sub

        Private Sub SetIndex(ByVal node As TreeListNode, ByVal index As Integer, ByVal expand As Boolean)
            Dim newIndex As Integer = If(expand, index - 1, index + 1)
            If node.StateImageIndex = index Then node.StateImageIndex = newIndex
        End Sub

        Private Sub treeView_AfterExpand(ByVal sender As Object, ByVal e As NodeEventArgs)
            SetIndex(e.Node, 7, True)
            SetIndex(e.Node, 9, True)
        End Sub

        Private Sub treeView_AfterCollapse(ByVal sender As Object, ByVal e As NodeEventArgs)
            SetIndex(e.Node, 6, False)
            SetIndex(e.Node, 8, False)
        End Sub

        Private Sub AddAllNodes(ByVal showAll As Boolean)
            treeView.Nodes.Clear()
            treeView.AppendNode(New Object() {"Solution 'DockingDemo' (1 project)"}, -1, -1, -1, 3) '0
            treeView.AppendNode(New Object() {"DockingDemo"}, -1, -1, -1, 4) '1
            treeView.AppendNode(New Object() {"Properties"}, 1, -1, -1, 2) '2
            treeView.AppendNode(New Object() {"References"}, 1, -1, -1, 5) '3
            treeView.AppendNode(New Object() {"System"}, 3, -1, -1, 5)
            treeView.AppendNode(New Object() {"System.Drawing"}, 3, -1, -1, 5)
            treeView.AppendNode(New Object() {"System.Windows.Forms"}, 3, -1, -1, 5)
            treeView.AppendNode(New Object() {"DevExpress.Utils"}, 3, -1, -1, 5)
            treeView.AppendNode(New Object() {"DevExpress.XtraBars"}, 3, -1, -1, 5)
            treeView.AppendNode(New Object() {"DevExpress.XtraEditors"}, 3, -1, -1, 5)
            If showAll Then
                treeView.AppendNode(New Object() {"bin"}, 1, -1, -1, 9) '10
                treeView.AppendNode(New Object() {"Debug"}, 10, -1, -1, 9)
                treeView.AppendNode(New Object() {"Release"}, 10, -1, -1, 9)
                treeView.AppendNode(New Object() {"obj"}, 1, -1, -1, 9) '13
                treeView.AppendNode(New Object() {"Debug"}, 13, -1, -1, 9)
                treeView.AppendNode(New Object() {"Release"}, 13, -1, -1, 9)
            End If

            treeView.AppendNode(New Object() {"Modules"}, 1, -1, -1, 7) '16/10
            treeView.AppendNode(New Object() {"Resources"}, 1, -1, -1, 7) '17
            treeView.AppendNode(New Object() {"AssemblyInfo.cs"}, 2, -1, -1, 10)
            treeView.AppendNode(New Object() {"frmMain.cs"}, 1, -1, -1, 11) '19
            treeView.AppendNode(New Object() {"ucCodeEditor.cs"}, If(showAll, 16, 10), -1, -1, 12) '20
            treeView.AppendNode(New Object() {"ucSolutionExplorer.cs"}, If(showAll, 16, 10), -1, -1, 12) '21
            treeView.AppendNode(New Object() {"ucToolbox.cs"}, If(showAll, 16, 10), -1, -1, 12) '22
            If showAll Then
                treeView.AppendNode(New Object() {"frmMain.resx"}, 19, -1, -1, 13)
                treeView.AppendNode(New Object() {"ucCodeEditor.resx"}, 20, -1, -1, 13)
                treeView.AppendNode(New Object() {"ucSolutionExplorer.resx"}, 21, -1, -1, 13)
                treeView.AppendNode(New Object() {"ucToolbox.resx"}, 22, -1, -1, 13)
            End If

            treeView.ExpandAll()
        End Sub

        Public Event PropertiesItemClick As EventHandler

        Private Sub iShow_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            AddAllNodes(CType(e.Item, XtraBars.BarButtonItem).Down)
        End Sub

        Private Sub iProperties_ItemClick(ByVal sender As Object, ByVal e As XtraBars.ItemClickEventArgs)
            RaiseEvent PropertiesItemClick(sender, EventArgs.Empty)
        End Sub

        Public Event TreeViewItemClick As EventHandler

        Private Sub treeView_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            RaiseEvent TreeViewItemClick(sender, EventArgs.Empty)
        End Sub
    End Class
End Namespace
