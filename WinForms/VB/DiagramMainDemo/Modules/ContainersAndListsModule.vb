Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.Diagram.Core
Imports DevExpress.Utils

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class ContainersAndListsModule
        Inherits DiagramTutorialControl

        Public Sub New()
            InitializeComponent()
            diagramControl.OptionsView.PropertiesPanelVisibility = PropertiesPanelVisibility.Collapsed
            LoadDocument("ContainersAndLists.xml")
            AddHandler diagramControl.SizeChanged, AddressOf OnSizeChangedHandler
        End Sub

        Private Sub OnSizeChangedHandler(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagramControl = CType(sender, DiagramControl)
            RemoveHandler diagramControl.SizeChanged, AddressOf OnSizeChangedHandler
            diagramControl.FitToWidth()
            diagramControl.AlignCanvas(HorzAlignment.Center, VertAlignment.Top)
        End Sub
    End Class
End Namespace
