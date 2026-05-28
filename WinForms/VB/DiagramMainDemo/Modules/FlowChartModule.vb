Imports System
Imports System.ComponentModel
Imports System.Drawing

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class FlowChartModule
        Inherits DiagramTutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            LoadDocument("Flowchart.xml")
        End Sub
    End Class
End Namespace
