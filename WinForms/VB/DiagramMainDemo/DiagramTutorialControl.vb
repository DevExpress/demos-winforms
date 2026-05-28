Imports System.Linq
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class DiagramTutorialControl
        Inherits DiagramTutorialControlBase

        Public Sub New()
            Me.New(True, True)
        End Sub

        Protected Overrides ReadOnly Property Ribbon As RibbonControl
            Get
                Return If(containerControl Is Nothing, Nothing, containerControl.Controls.OfType(Of RibbonControl)().FirstOrDefault())
            End Get
        End Property

        Protected Sub New(ByVal createRibbon As Boolean, ByVal createDocking As Boolean)
            InitializeComponent()
            If createRibbon Then Diagram.CreateRibbon()
            If createDocking Then
                Diagram.CreateDocking(Docking.DockingMode.All)
                SubscribePanAndZoomEvents()
            End If
        End Sub

        Protected Overrides Sub CreateDockingWithPanAndZoom()
        End Sub
    End Class
End Namespace
