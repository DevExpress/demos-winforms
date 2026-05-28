Imports System
Imports DevExpress.Diagram.Core
Imports DevExpress.Utils

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class DocumentModuleBase
        Inherits DiagramTutorialControl

        Public Sub New()
            InitializeComponent()
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            Dim document = DocumentName
            If Not String.IsNullOrEmpty(document) Then LoadDocument(document)
            AddHandler diagramControl.SizeChanged, AddressOf OnSizeChangedHandler
            diagramControl.OptionsView.PropertiesPanelVisibility = PropertiesPanelVisibility.Collapsed
        End Sub

        Protected Overridable ReadOnly Property DocumentName As String
            Get
                Return String.Empty
            End Get
        End Property

        Private Sub OnSizeChangedHandler(ByVal sender As Object, ByVal e As EventArgs)
            Dim diagramControl = CType(sender, DiagramControl)
            RemoveHandler diagramControl.SizeChanged, AddressOf OnSizeChangedHandler
            diagramControl.FitToWidth()
            diagramControl.AlignCanvas(HorzAlignment.Center, VertAlignment.Top)
        End Sub
    End Class
End Namespace
