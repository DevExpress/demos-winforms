Imports System
Imports System.Drawing
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Demos

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class MindMapTreeLayoutModule
        Inherits DevExpress.XtraDiagram.Demos.LayoutModuleBase

        Public Sub New()
            Me.InitializeComponent()
            Me.LoadDocument("MindMapTreeLayoutDiagram.xml")
            Me.Diagram.OptionsProtection.AllowUndoRedo = False
            AddHandler Me.Diagram.SelectionChanged, AddressOf Me.OnSelectionChanged
        End Sub

        Protected Overrides Sub RelayoutDiagramCore()
            Me.Diagram.ApplyMindMapTreeLayout()
        End Sub

        Protected Overridable Sub RadioGroupSelectedItemChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.RelayoutDiagram()
        End Sub

        Protected Overridable Sub TrackBarValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
            Me.RelayoutDiagram()
        End Sub

        Private Sub AddChild(ByVal sender As Object, ByVal e As System.EventArgs)
            Dim parent = TryCast(Me.diagramControl.PrimarySelection, DevExpress.XtraDiagram.DiagramItem)
            Dim size = DevExpress.Diagram.Demos.MindMapHelpers.GetSize(DevExpress.Diagram.Demos.OrgChartHelpers.GetItemLevel(parent) + 1)
            Dim child = New DevExpress.XtraDiagram.DiagramShape() With {.Shape = DevExpress.Diagram.Core.BasicShapes.Ellipse, .Width = CSng(size.Width), .Height = CSng(size.Height), .Content = "New Item"}
            child.Appearance.Font = New System.Drawing.Font("Segoe UI", DevExpress.Diagram.Demos.MindMapHelpers.GetFontSize(DevExpress.Diagram.Demos.OrgChartHelpers.GetItemLevel(parent) + 1))
            child.ThemeStyleId = DevExpress.Diagram.Demos.MindMapHelpers.GetMindMapStyle(child, parent)
            Me.Diagram.Items.Add(child)
            Dim connector = New DevExpress.XtraDiagram.DiagramConnector() With {.Type = DevExpress.Diagram.Core.ConnectorType.Curved, .ThemeStyleId = child.ThemeStyleId, .BeginItem = parent, .EndItem = child}
            connector.Appearance.BorderSize = 3
            Me.Diagram.Items.Add(connector)
            Me.RelayoutDiagramCore()
        End Sub

        Private Sub OnSelectionChanged(ByVal sender As Object, ByVal e As DevExpress.XtraDiagram.DiagramSelectionChangedEventArgs)
            Me.addChildButton.Enabled = TypeOf Me.Diagram.PrimarySelection Is DevExpress.XtraDiagram.DiagramShape
        End Sub
    End Class
End Namespace
