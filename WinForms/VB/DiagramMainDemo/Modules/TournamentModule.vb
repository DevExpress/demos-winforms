Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Routing
Imports DevExpress.Diagram.Demos
Imports DevExpress.XtraEditors

Namespace DevExpress.XtraDiagram.Demos

    Public Partial Class TournamentModule
        Inherits DiagramTutorialControl

        Private ReadOnly backgroundBrush As Brush = New SolidBrush(Color.FromArgb(&H27, &H50, &H83))

        Public Sub New()
            MyBase.New(False, False)
            Dim viewModel = New TournamentViewModel()
            InitializeComponent()
            SubscribeDiagramEvents()
            TryCast(diagramControl, IDiagramControl).Controller.RegisterRoutingStrategy(ConnectorType.RightAngle, New RightAngleRoutingStrategy() With {.ItemMargin = CInt(diagramControl.OptionsTreeLayout.HorizontalSpacing) \ 2})
            diagramDataBindingController1.BeginInit()
            tournamentsBindingSource.DataSource = viewModel.Games
            relationshipInfoBindingSource.DataSource = viewModel.Relationships
            diagramDataBindingController1.EndInit()
            diagramControl.FitToDrawing()
        End Sub

        Private Sub SubscribeDiagramEvents()
            AddHandler diagramControl.ItemContentChanged, AddressOf DiagramControl_ItemContentChanged
            AddHandler diagramControl.MouseDoubleClick, AddressOf DiagramControl_MouseDoubleClick
            AddHandler diagramControl.CustomDrawBackground, AddressOf DiagramControl_CustomDrawBackground
        End Sub

        Private Sub DiagramControl_CustomDrawBackground(ByVal sender As Object, ByVal e As CustomDrawBackgroundEventArgs)
            e.GraphicsCache.FillRectangle(backgroundBrush, e.TotalBounds)
        End Sub

        Private Sub DiagramControl_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim clickedItem = TryCast(diagramControl.CalcHitItem(e.Location), DiagramItem)
            If clickedItem Is Nothing Then Return
            Dim commandContainer = TryCast(clickedItem.ParentItem, DiagramContainer)
            If commandContainer IsNot Nothing Then
                Dim resultShape = commandContainer.Items.OfType(Of DiagramShape)().LastOrDefault()
                If resultShape IsNot Nothing Then
                    diagramControl.SelectItem(resultShape)
                    diagramControl.Commands.Execute(DiagramCommandsBase.EditCommand)
                End If
            End If
        End Sub

        Private Sub DiagramControl_ItemContentChanged(ByVal sender As Object, ByVal e As DiagramItemContentChangedEventArgs)
            Dim newValue As Integer = 0
            If Not Integer.TryParse(e.NewValue, newValue) Then
                XtraMessageBox.Show("The value should be a number.", "Invalid value")
                Dim shape = TryCast(e.Item, DiagramShape)
                If shape IsNot Nothing Then shape.Content = e.OldValue
            End If
        End Sub
    End Class
End Namespace
