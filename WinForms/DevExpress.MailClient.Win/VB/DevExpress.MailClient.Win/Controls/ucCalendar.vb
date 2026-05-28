Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.Skins
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraScheduler.UI

Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucCalendar
        Inherits NavPanePanel

        Private schedulerControl As SchedulerControl
        Private barController As SchedulerBarController

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub StateChanged(ByVal state As NavPaneState)
            Me.State = state
        End Sub
        Public Sub InitDateNavigator(ByVal schedulerControl As SchedulerControl)
            Me.schedulerControl = schedulerControl
            Me.dateNavigator1.SchedulerControl = schedulerControl
        End Sub
        Public Sub InitResourcesTree(ByVal storage As SchedulerStorage)
            If treeResources.Nodes.Count > 0 Then
                Return
            End If

            treeResources.BeginUnboundLoad()
            treeResources.AppendNode(New Object() { My.Resources.Work }, -1, CheckState.Checked)
            treeResources.AppendNode(New Object() { My.Resources.Personal }, -1, CheckState.Checked)

            For Each item As Resource In storage.Resources.Items
                Dim id As Integer = CInt((item.Id))
                Dim node As TreeListNode = treeResources.AppendNode(New Object() { item.Caption }, CalculateResourceCategory(id), id)
                node.CheckState = CheckState.Checked
            Next item
            treeResources.EndUnboundLoad()
            treeResources.ExpandAll()
        End Sub
        Public Sub InitBarController(ByVal scheduler As SchedulerControl)
            Me.barController.Control = scheduler
        End Sub
        Protected Function CalculateResourceCategory(ByVal resourceId As Integer) As Integer
            Return If(resourceId < 3, 0, 1)
        End Function
        Private Sub treeResources_AfterCheckNode(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeResources.AfterCheckNode
            For Each node As TreeListNode In e.Node.Nodes
                node.CheckState = e.Node.CheckState
            Next node
            If e.Node.ParentNode IsNot Nothing Then
                e.Node.ParentNode.CheckState = GetParentNodeState(e.Node.ParentNode.Nodes)
            End If

            Me.schedulerControl.ActiveView.LayoutChanged()
        End Sub
        Private Function GetParentNodeState(ByVal nodes As TreeListNodes) As CheckState
            Dim state_Field As CheckState = nodes(0).CheckState
            For Each node As TreeListNode In nodes
                If node.CheckState <> state_Field Then
                    Return CheckState.Indeterminate
                End If
            Next node
            Return state_Field
        End Function
        Public Function GetSelectedResourceIds() As List(Of Integer)
            Dim result As New List(Of Integer)()
            FillSelectedNodes(treeResources.Nodes(0), result)
            FillSelectedNodes(treeResources.Nodes(1), result)
            Return result
        End Function
        Private Sub FillSelectedNodes(ByVal node As TreeListNode, ByVal resourceIds As List(Of Integer))
            For Each item As TreeListNode In node.Nodes
                If item.CheckState = CheckState.Checked Then
                    resourceIds.Add(CInt((item.Tag)))
                End If
            Next item
        End Sub

        Private Sub treeResources_AfterCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeResources.AfterCollapse
            EndCalcTreeListHeight()
        End Sub

        Private Sub treeResources_AfterExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.NodeEventArgs) Handles treeResources.AfterExpand
            EndCalcTreeListHeight()
        End Sub
        Private Sub StartCalcTreeListHeight()
            treeResources.BeginUpdate()
        End Sub
        Private Sub CalcTreeListHeight()
            treeResources.Height = GetExpandedRowCount(treeResources.Nodes) * treeResources.ViewInfo.RowHeight + 2
        End Sub
        Private Sub EndCalcTreeListHeight()
            CalcTreeListHeight()
            treeResources.EndUpdate()
        End Sub
        Public Sub UpdateTreeListHeight()
            BeginInvoke(New MethodInvoker(AddressOf CalcTreeListHeight))
        End Sub
        Private Function GetExpandedRowCount(ByVal nodes As TreeListNodes) As Integer
            Dim count As Integer = 0
            For Each node As TreeListNode In nodes
                count += 1
                If node.Expanded Then
                    count += GetExpandedRowCount(node.Nodes)
                End If
            Next node
            Return count
        End Function

        Private Sub treeResources_BeforeCollapse(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeCollapseEventArgs) Handles treeResources.BeforeCollapse
            StartCalcTreeListHeight()
        End Sub

        Private Sub treeResources_BeforeExpand(ByVal sender As Object, ByVal e As DevExpress.XtraTreeList.BeforeExpandEventArgs) Handles treeResources.BeforeExpand
            StartCalcTreeListHeight()
        End Sub
        Protected Overrides Sub LookAndFeelStyleChanged()
            MyBase.LookAndFeelStyleChanged()
            CalcTreeListHeight()
        End Sub

        Public Sub SetBarController(ByVal barController As SchedulerBarController)
            Me.barController = barController
        End Sub
    End Class
End Namespace
