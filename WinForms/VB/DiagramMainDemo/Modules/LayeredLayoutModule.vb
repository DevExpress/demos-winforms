Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class LayeredLayoutModule
        Inherits LayoutModuleBase

        Public Sub New()
            InitializeComponent()
            LoadDocument("LayeredLayoutDiagram.xml")
        End Sub

        Protected Overrides Sub RelayoutDiagramCore()
            Diagram.ApplySugiyamaLayout()
        End Sub

        Protected Overridable Sub RadioGroupSelectedItemChanged(ByVal sender As Object, ByVal e As EventArgs)
            RelayoutDiagram()
        End Sub

        Protected Overridable Sub TrackBarValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            RelayoutDiagram()
        End Sub
    End Class
End Namespace
