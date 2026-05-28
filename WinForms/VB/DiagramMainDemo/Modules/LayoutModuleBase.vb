Imports System
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core.Layout

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class LayoutModuleBase
        Inherits DiagramTutorialControl

        Protected Property IsLoaded As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            IsLoaded = True
            RelayoutDiagram()
        End Sub

        Protected Sub RelayoutDiagram()
            If Diagram Is Nothing OrElse Not IsLoaded Then Return
            RelayoutDiagramCore()
            Call Application.DoEvents()
            Diagram.FitToPage()
        End Sub

        Protected Overridable Sub RelayoutDiagramCore()
        End Sub
    End Class
End Namespace
