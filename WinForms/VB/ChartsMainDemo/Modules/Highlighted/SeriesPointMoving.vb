Imports System
Imports System.Windows.Forms

Namespace DevExpress.XtraCharts.Demos

    Public Partial Class SeriesPointMovingDemo
        Inherits ChartDemoModule

        Const MinValue As Double = 0

        Const MaxRetailPriceValue As Double = 500

        Const MaxValue As Double = 1000 * MaxRetailPriceValue

        Const ItemProductionCost As Integer = 50

        Private ReadOnly dataSource As DraggableDataModel

        Private seriesName As String

        Private currentPane As XYDiagramPaneBase

        Private currentItem As DraggableItem

        Friend Overrides ReadOnly Property ChartControl As ChartControl
            Get
                Return chart
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            dataSource = DraggableDataModel.CreateModel(ItemProductionCost)
            chart.DataSource = dataSource
            UpdateTotalIncome()
        End Sub

        Private Sub UpdateTotalIncome()
            chart.Legends(1).CustomItems(0).Text = String.Format("Total income: ${0}K", dataSource.TotalIncome.ToString("N0"))
        End Sub

        Private Sub Chart_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
            If hitInfo.SeriesPoint Is Nothing Then Return
            seriesName = hitInfo.Series.ToString()
            If Equals(seriesName, "Income") OrElse Equals(seriesName, "Stock") Then Return
            currentItem = CType(hitInfo.SeriesPoint.Tag, DraggableItem)
            currentPane = GetPane(hitInfo.Series)
        End Sub

        Private Function GetPane(ByVal series As SeriesBase) As XYDiagramPaneBase
            Dim view As XYDiagramSeriesViewBase = TryCast(series.View, XYDiagramSeriesViewBase)
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If view IsNot Nothing AndAlso diagram IsNot Nothing Then Return If(view.Pane, diagram.DefaultPane)
            Return Nothing
        End Function

        Private Sub Chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
            ChangeCursor(e)
            Dim diagram As XYDiagram = TryCast(chart.Diagram, XYDiagram)
            If currentItem IsNot Nothing AndAlso currentPane IsNot Nothing AndAlso diagram IsNot Nothing Then
                Dim coords As DiagramCoordinates = diagram.PointToDiagram(e.Location)
                If Not coords.IsEmpty AndAlso currentPane.Equals(coords.Pane) Then
                    SetNewPointValue(coords.NumericalValue)
                End If
            End If
        End Sub

        Private Sub ChangeCursor(ByVal e As MouseEventArgs)
            If currentItem Is Nothing Then
                Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
                If hitInfo.SeriesPoint IsNot Nothing AndAlso Not Equals(hitInfo.Series.ToString(), "Stock") Then
                    chart.Cursor = Cursors.SizeNS
                Else
                    chart.Cursor = Cursors.Default
                End If
            End If
        End Sub

        Private Sub SetNewPointValue(ByVal newValue As Double)
            If newValue < MinValue OrElse newValue > MaxRetailPriceValue AndAlso Equals(seriesName, "Retail Price") OrElse newValue > MaxValue Then Return
            Select Case seriesName
                Case "Production"
                    dataSource.UpdateProduction(currentItem, newValue)
                Case "Demand"
                    dataSource.UpdateDemand(currentItem, newValue)
                Case "Retail Price"
                    dataSource.UpdateCost(currentItem, newValue)
            End Select

            UpdateTotalIncome()
        End Sub

        Private Sub Chart_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If currentItem IsNot Nothing Then chart.RefreshData()
            currentItem = Nothing
            currentPane = Nothing
            seriesName = Nothing
        End Sub

        Private Sub Chart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs)
            If Not Equals(e.Series.Name, seriesName) OrElse e.SeriesPoint.Tag IsNot currentItem Then Return
            Dim drawOptions As LineDrawOptions = TryCast(e.SeriesDrawOptions, LineDrawOptions)
            drawOptions.Marker.Size += 6
        End Sub

        Private Sub SeriesPointMovingDemo_Load(ByVal sender As Object, ByVal e As EventArgs)
            flyoutPanel1.ShowPopup()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            flyoutPanel1.HidePopup()
        End Sub
    End Class
End Namespace
