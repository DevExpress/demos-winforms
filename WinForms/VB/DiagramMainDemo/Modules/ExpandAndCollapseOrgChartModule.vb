Imports System
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.Diagram.Demos
Imports System.Drawing
Imports DevExpress.Diagram.Core

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class ExpandAndCollapseOrgChartModule
        Inherits DiagramTutorialControlBase

        Public Sub New()
            InitializeComponent()
            employeeBindingSource.DataSource = GetOrgChartEmployees()
        End Sub

        Private Sub OnItemsGenerated(ByVal sender As Object, ByVal e As DiagramItemsGeneratedEventArgs)
            For Each item In e.GeneratedItems
                item.ThemeStyleId = OrgChartHelpers.GetStyleID(item)
            Next
        End Sub

        Private Sub LayoutKindChanged(ByVal sender As Object, ByVal e As EventArgs)
            Dim layoutKind = CType(layoutKindGroup.RadioGroup.Properties.Items(layoutKindGroup.RadioGroup.SelectedIndex).Value, DiagramLayoutKind)
            If Equals(layoutKind, DiagramLayoutKind.OrgChart) Then diagramControl.ApplyOrgChartLayout()
            If Equals(layoutKind, DiagramLayoutKind.Tree) Then diagramControl.ApplyTreeLayout()
            If Equals(layoutKind, DiagramLayoutKind.TipOverTree) Then diagramControl.ApplyTipOverTreeLayout()
            If Equals(layoutKind, DiagramLayoutKind.MindMapTree) Then diagramControl.ApplyMindMapTreeLayout()
            diagramOrgChartController1.LayoutKind = layoutKind
            diagramControl.FitToItems(diagramControl.Items)
        End Sub

        Private Sub FitToItems(ByVal sender As Object, ByVal e As EventArgs)
            diagramControl.FitToItems(diagramControl.Items)
        End Sub
    End Class
End Namespace
