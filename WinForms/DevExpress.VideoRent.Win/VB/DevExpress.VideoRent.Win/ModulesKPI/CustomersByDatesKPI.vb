Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraLayout
Imports DevExpress.Xpo
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.Filtering

Namespace DevExpress.VideoRent.Win.ModulesKPI
	Partial Public Class CustomersByDatesKPI
		Inherits ChartExportTutorialControl
		Private Const selectedRowsCount As Integer = 5
		Private Const customersChartTitleText As String = ConstStrings.CustomersDatesModule

		Private tooltipGrid As CustomerToolTipController
		Private tooltipChart As CustomerToolTipController
		Private tooltipDiscount As CustomerDiscountLevelToolTipController

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(customersChart.Diagram, XYDiagram)
			End Get
		End Property
		Protected Overrides ReadOnly Property MainChart() As ChartControl
			Get
				Return customersChart
			End Get
		End Property
		Protected Overrides ReadOnly Property MainLayoutControl() As LayoutControl
			Get
				Return layoutControl1
			End Get
		End Property
		Protected Overrides ReadOnly Property AllowFlipLayout() As Boolean
			Get
				Return True
			End Get
		End Property

		Public Sub New()
            InitializeComponent()
            SetDateFilter()
            customersGrid.BestFit()
			tooltipGrid = New CustomerToolTipController(customersGrid)
			tooltipChart = New CustomerToolTipController(customersChart)
			tooltipDiscount = New CustomerDiscountLevelToolTipController(customersChart)
		End Sub
		Private Sub AddConstantLine(ByVal axis As AxisY, ByVal level As CustomerDiscountLevel)
			Dim constantLine As New ConstantLine(level.ToString(), CInt(Fix(ReferenceData.GetDiscountLevelPayment(level))))
			constantLine.Title.Text = level.ToString() & " (" & (CInt(Fix(ReferenceData.GetDiscountLevelPayment(level)))).ToString() & ")"
			constantLine.ShowInLegend = False
			axis.ConstantLines.Add(constantLine)
		End Sub
		Private Sub AddSelection(ByVal selection As List(Of Point), ByVal rowIndex As Integer)
			For i As Integer = 0 To selectedRowsCount - 1
				selection.Add(New Point(0, rowIndex + i))
			Next i
		End Sub
		Private Sub SetColors(ByVal drawOptions As DrawOptions, ByVal colorIndex As Integer)
			Dim palleteEntry As PaletteEntry = customersChart.GetPaletteEntries(5)(colorIndex)
			drawOptions.Color = palleteEntry.Color
			Dim barDrawoptions As BarDrawOptions = TryCast(drawOptions, BarDrawOptions)
			If (Not Object.Equals(barDrawoptions, Nothing)) Then
				Dim gradientOptions As RectangleGradientFillOptions = TryCast(barDrawoptions.FillStyle.Options, RectangleGradientFillOptions)
				If (Not Object.Equals(gradientOptions, Nothing)) Then
					gradientOptions.Color2 = palleteEntry.Color2
				End If
			End If
		End Sub
		Private Sub CustomerKPI_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim selection As New List(Of Point)()
			AddSelection(selection, 0)
            AddSelection(selection, CInt(Fix(customersGrid.Cells.RowCount / 3)))
			AddSelection(selection, customersGrid.Cells.RowCount - selectedRowsCount)
			customersGrid.Cells.MultiSelection.SetSelection(selection.ToArray())
			customersChart.DataSource = customersGrid
			If (Not Object.Equals(Diagram, Nothing)) Then
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Basic)
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Occasional)
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Active)
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Prodigious)
			End If
		End Sub
		Private Sub SetDateFilter()
			receiptsCollection.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator("Date", PeriodManager.KPIPeriod.StartDate, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("Date", PeriodManager.KPIPeriod.EndDate, BinaryOperatorType.LessOrEqual))
		End Sub
        Private Sub receiptsCollection_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles receiptsCollection.ResolveSession
            e.Session = Session
        End Sub
        Private Sub customersChart_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles customersChart.BoundDataChanged
			If (Not Object.Equals(Diagram, Nothing)) AndAlso customersChart.Series.Count > 0 Then
				Dim isVerticalLabels As Boolean = customersChart.Series(0).Points.Count > 12
				If isVerticalLabels Then
					Diagram.AxisX.Label.Angle = -90
				Else
					Diagram.AxisX.Label.Angle = 0
				End If
				For Each series As Series In customersChart.Series
					If isVerticalLabels Then
						series.Label.TextOrientation = TextOrientation.BottomToTop
					Else
						series.Label.TextOrientation = TextOrientation.Horizontal
					End If
				Next series
				customersChart.Titles(0).Text = customersChartTitleText & " (" & customersChart.Series(0).Name & ")"
			End If
		End Sub
		Private Sub customersChart_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs) Handles customersChart.CustomDrawSeries
			Select Case customersChart.Series.IndexOf(e.Series)
				Case 1
					SetColors(e.LegendDrawOptions, 0)
				Case 2
					SetColors(e.LegendDrawOptions, 1)
				Case 3
					SetColors(e.LegendDrawOptions, 2)
				Case 4
					SetColors(e.LegendDrawOptions, 3)
				Case 5
					SetColors(e.LegendDrawOptions, 4)
			End Select
		End Sub
		Private Sub customersChart_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles customersChart.CustomDrawSeriesPoint
			If e.SeriesPoint.Values(0) >= CInt(Fix(ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Prodigious))) Then
				SetColors(e.SeriesDrawOptions, 0)
			ElseIf e.SeriesPoint.Values(0) >= CInt(Fix(ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Active))) Then
				SetColors(e.SeriesDrawOptions, 1)
			ElseIf e.SeriesPoint.Values(0) >= CInt(Fix(ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Occasional))) Then
				SetColors(e.SeriesDrawOptions, 2)
			ElseIf e.SeriesPoint.Values(0) >= CInt(Fix(ReferenceData.GetDiscountLevelPayment(CustomerDiscountLevel.Basic))) Then
				SetColors(e.SeriesDrawOptions, 3)
			Else
				SetColors(e.SeriesDrawOptions, 4)
			End If
		End Sub
		Private Sub customersChart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles customersChart.MouseMove
			Dim hitInfo As ChartHitInfo = customersChart.CalcHitInfo(e.X, e.Y)
			If (Not Object.Equals(hitInfo.SeriesPoint, Nothing)) Then
				Dim cell() As Integer = TryCast(hitInfo.SeriesPoint.Tag, Integer())
				If (Not Object.Equals(cell, Nothing)) AndAlso cell.Length = 2 Then
					Dim customer As Customer = TryCast(customersGrid.GetFieldValue(fieldCustomer, cell(1)), Customer)
					If (Not Object.Equals(customer, Nothing)) Then
						tooltipChart.ShowHint(customer, e.Location)
						Return
					End If
				End If
			End If
			tooltipChart.HideHint(True)
			If (Not Object.Equals(hitInfo.Series, Nothing)) Then
				Dim series As Series = TryCast(hitInfo.Series, Series)
				If (Not Object.Equals(series, Nothing)) Then
					Select Case series.Name
						Case "First-Time Renter"
							tooltipDiscount.ShowHint(CustomerDiscountLevel.FirstTime, e.Location)
							Return
						Case "Basic Renter"
							tooltipDiscount.ShowHint(CustomerDiscountLevel.Basic, e.Location)
							Return
						Case "Occasional Renter"
							tooltipDiscount.ShowHint(CustomerDiscountLevel.Occasional, e.Location)
							Return
						Case "Active Renter"
							tooltipDiscount.ShowHint(CustomerDiscountLevel.Active, e.Location)
							Return
						Case "Prodigious Renter"
							tooltipDiscount.ShowHint(CustomerDiscountLevel.Prodigious, e.Location)
							Return
					End Select
				End If
			End If
			tooltipDiscount.HideHint(True)
		End Sub
		Private Sub customersGrid_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles customersGrid.MouseMove
			Dim hitInfo As PivotGridHitInfo = customersGrid.CalcHitInfo(e.Location)
			If MustShowCustomerTooltip(hitInfo) Then
				Dim customer As Customer = TryCast(hitInfo.ValueInfo.Value, Customer)
				If (Not Object.Equals(customer, Nothing)) Then
					Dim location As Point = e.Location
					location.Offset(20, 20)
					tooltipGrid.ShowHint(customer, location)
				End If
			Else
				tooltipGrid.HideHint(True)
			End If
		End Sub
		Private Sub customersGrid_FieldTooltipShowing(ByVal sender As Object, ByVal e As PivotFieldTooltipShowingEventArgs) Handles customersGrid.FieldTooltipShowing
			Dim hitInfo As PivotGridHitInfo = e.HitInfo
			If MustShowCustomerTooltip(hitInfo) Then
				e.ShowTooltip = False
			End If
		End Sub
		Private Sub cbeSortMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbeSortMode.SelectedIndexChanged
			If cbeSortMode.SelectedIndex = 0 Then
				customersChart.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Value_1
				customersChart.SeriesTemplate.SeriesPointsSorting = SortingMode.Descending
			Else
				customersChart.SeriesTemplate.SeriesPointsSortingKey = SeriesPointKey.Argument
				customersChart.SeriesTemplate.SeriesPointsSorting = SortingMode.Ascending
			End If
		End Sub
		Private Function MustShowCustomerTooltip(ByVal hitInfo As PivotGridHitInfo) As Boolean
            Return Object.Equals(hitInfo.HitTest, PivotGridHitTest.Value) AndAlso Object.Equals(hitInfo.ValueInfo.Field, fieldCustomer)
		End Function
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			customersChart.BeginInit()
			Try
				Dim selection As Rectangle = customersGrid.Cells.Selection
				customersGrid.BeginUpdate()
				Try
					SetDateFilter()
				Finally
					customersGrid.EndUpdate()
				End Try
				customersGrid.Cells.Selection = selection
			Finally
				customersChart.EndInit()
			End Try
			customersGrid.BestFit()
		End Sub
	End Class
End Namespace
