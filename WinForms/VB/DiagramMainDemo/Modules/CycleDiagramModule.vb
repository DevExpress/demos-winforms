Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Diagram.Core

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class CycleDiagramModule
        Inherits DiagramTutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            LoadDocument("CycleDiagram.xml")
            Diagram.OptionsView.Theme = DiagramThemes.Linear
        End Sub
    End Class
End Namespace
