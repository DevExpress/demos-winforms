Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class CircularLayoutModule
        Inherits LayoutModuleBase

        Public Sub New()
            InitializeComponent()
            LoadDocument("CircularLayoutDiagram.xml")
        End Sub

        Protected Overrides Sub RelayoutDiagramCore()
            Diagram.ApplyCircularLayout()
        End Sub

        Protected Overridable Sub CircularOrderGroupSelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs)
            RelayoutDiagram()
        End Sub

        Protected Overridable Sub TrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RelayoutDiagram()
        End Sub
    End Class
End Namespace
