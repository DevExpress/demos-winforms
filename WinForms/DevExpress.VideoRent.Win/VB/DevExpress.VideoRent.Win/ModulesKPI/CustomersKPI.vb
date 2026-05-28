Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraCharts
Imports DevExpress.XtraLayout
Imports DevExpress.XtraPivotGrid
Imports DevExpress.Data.PivotGrid
Imports DevExpress.Data.Filtering

Namespace DevExpress.VideoRent.Win.ModulesKPI
	Partial Public Class CustomersKPI
		Inherits ChartExportTutorialControl
		Private Const selectedRowsCount As Integer = 5

		Private inSelectionUpdate As Boolean
		Private tooltip As CustomerToolTipController
		Private tooltipDiscount As CustomerDiscountLevelToolTipController
		Private discountOverTimeGrid As PivotGridControl

		Private ReadOnly Property Diagram() As XYDiagram
			Get
				Return TryCast(discountChart.Diagram, XYDiagram)
			End Get
		End Property
		Protected Friend Overrides ReadOnly Property ChartViewType() As ViewType
			Get
				Return ViewType.FullStackedSplineArea
			End Get
		End Property
		Protected Overrides ReadOnly Property MainChart() As ChartControl
			Get
				Return discountChart
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
            tooltip = New CustomerToolTipController(discountGrid)
			tooltipDiscount = New CustomerDiscountLevelToolTipController(discountChart)
		End Sub
		Private Sub AddConstantLine(ByVal axis As AxisY, ByVal level As CustomerDiscountLevel)
			Dim constantLine As New ConstantLine(level.ToString(), CInt(Fix(ReferenceData.GetDiscountLevelPayment(level))))
			constantLine.Title.Text = level.ToString() & " (" & (CInt(Fix(ReferenceData.GetDiscountLevelPayment(level)))).ToString() & ")"
			constantLine.ShowInLegend = False
			axis.ConstantLines.Add(constantLine)
		End Sub
		Private Sub SetDateFilter()
			receiptsCollection.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator("Date", PeriodManager.KPIPeriod.StartDate, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("Date", PeriodManager.KPIPeriod.EndDate, BinaryOperatorType.LessOrEqual))
		End Sub
        Private Sub receiptsCollection_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles receiptsCollection.ResolveSession
            e.Session = Session
        End Sub
        Private Sub DiscountKPI_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			If (Not Object.Equals(Diagram, Nothing)) Then
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Basic)
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Occasional)
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Active)
				AddConstantLine(Diagram.AxisY, CustomerDiscountLevel.Prodigious)
			End If

			discountGrid.Cells.Selection = New Rectangle(0, 0, discountGrid.Cells.ColumnCount, selectedRowsCount)
			discountChart.DataSource = discountGrid

			discountOverTimeGrid = New PivotGridControl()
			discountOverTimeGrid.DataSource = receiptsCollection
			discountOverTimeGrid.OptionsChartDataSource.ProvideDataByColumns = False
			discountOverTimeGrid.OptionsChartDataSource.SelectionOnly = False
			discountOverTimeGrid.OptionsChartDataSource.ProvideColumnGrandTotals = False
			discountOverTimeGrid.OptionsChartDataSource.ProvideColumnTotals = False
			discountOverTimeGrid.OptionsChartDataSource.ProvideRowGrandTotals = False
			discountOverTimeGrid.OptionsChartDataSource.ProvideRowTotals = False
			discountOverTimeGrid.OptionsChartDataSource.ProvideColumnCustomTotals = False
			discountOverTimeGrid.OptionsChartDataSource.ProvideRowCustomTotals = False
            Dim paymentField As New PivotGridField("Payment", PivotArea.DataArea)
            paymentField.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            paymentField.CellFormat.FormatString = "f"
			paymentField.SummaryType = PivotSummaryType.Custom
			discountOverTimeGrid.Fields.Add(paymentField)
			discountOverTimeGrid.Fields.Add(New PivotGridField("Customer!", PivotArea.RowArea))
			Dim yearField As New PivotGridField("Date", PivotArea.ColumnArea)
			yearField.GroupInterval = PivotGroupInterval.DateYear
			yearField.RunningTotal = True
			Dim quarterField As New PivotGridField("Date", PivotArea.ColumnArea)
			quarterField.GroupInterval = PivotGroupInterval.DateQuarter
			quarterField.RunningTotal = True
			discountOverTimeGrid.Fields.Add(yearField)
			discountOverTimeGrid.Fields.Add(quarterField)
			AddHandler discountOverTimeGrid.CustomSummary, AddressOf pivotGrid_CustomSummary

			BindSeries(discountOverTimeGrid, CustomerDiscountLevel.FirstTime)
			BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Basic)
			BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Occasional)
			BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Active)
			BindSeries(discountOverTimeGrid, CustomerDiscountLevel.Prodigious)
		End Sub
        Private Sub BindSeries(ByVal pivotGrid As PivotGridControl, ByVal level As CustomerDiscountLevel)
            Dim series As Series = discountChart.Series(EditorHelper.GetStringByCustomerDiscountLevel(level))
            series.DataSource = pivotGrid
            series.ArgumentDataMember = "Arguments"
            series.ValueDataMembers(0) = "Values"
            series.DateTimeSummaryOptions.SummaryFunction = "COUNT()"
            series.FilterCriteria = New BinaryOperator("Values", CDec(level), BinaryOperatorType.Equal)
        End Sub
        Private Sub pivotGrid_CustomSummary(ByVal sender As Object, ByVal e As PivotGridCustomSummaryEventArgs)
			e.CustomValue = Customer.GetDiscount(CDec(e.SummaryValue.Summary))
		End Sub
		Private Sub SetColors(ByVal series As Series, ByVal drawOptions As DrawOptions, ByVal colorIndex As Integer)
			Dim palleteEntry As PaletteEntry = discountChart.GetPaletteEntries(5)(colorIndex)
			Dim view As ISupportTransparency = TryCast(series.View, ISupportTransparency)
			Dim transparency As Byte
			If (Not Object.Equals(view, Nothing)) Then
				transparency = view.Transparency
			Else
				transparency = Byte.MinValue
			End If
			transparency = CByte(Byte.MaxValue - transparency)
			drawOptions.Color = Color.FromArgb(transparency, palleteEntry.Color)
			Dim barDrawoptions As BarDrawOptions = TryCast(drawOptions, BarDrawOptions)
			If (Not Object.Equals(barDrawoptions, Nothing)) Then
				Dim gradientOptions As RectangleGradientFillOptions = TryCast(barDrawoptions.FillStyle.Options, RectangleGradientFillOptions)
				If (Not Object.Equals(gradientOptions, Nothing)) Then
					gradientOptions.Color2 = Color.FromArgb(transparency, palleteEntry.Color2)
				End If
			End If
		End Sub
		Private Sub SetColors(ByVal e As CustomDrawSeriesEventArgs, ByVal colorIndex As Integer)
			SetColors(e.Series, e.SeriesDrawOptions, colorIndex)
			SetColors(e.Series, e.LegendDrawOptions, colorIndex)
		End Sub
		Private Sub discountChart_CustomDrawSeries(ByVal sender As Object, ByVal e As CustomDrawSeriesEventArgs) Handles discountChart.CustomDrawSeries
			Select Case e.Series.Name
				Case "First-Time Renter"
					SetColors(e, 4)
				Case "Basic Renter"
					SetColors(e, 3)
				Case "Occasional Renter"
					SetColors(e, 2)
				Case "Active Renter"
					SetColors(e, 1)
				Case "Prodigious Renter"
					SetColors(e, 0)
			End Select
		End Sub
		Private Sub discountGrid_FocusedCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles discountGrid.FocusedCellChanged
			If inSelectionUpdate Then
				Return
			End If
			inSelectionUpdate = True
			If discountGrid.Cells.MultiSelection.SelectedCells.Count = 0 Then
				Dim selectedCells As New List(Of Point)()
				For x As Integer = 0 To discountGrid.Cells.ColumnCount - 1
					selectedCells.Add(New Point(x, discountGrid.Cells.FocusedCell.Y))
				Next x
				discountGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray())
			End If
			inSelectionUpdate = False
		End Sub
		Private Sub discountGrid_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles discountGrid.CellSelectionChanged
			If inSelectionUpdate Then
				Return
			End If
			inSelectionUpdate = True
			SetSelection(GetSelectedRows())
			inSelectionUpdate = False
		End Sub
		Private Function GetSelectedRows() As List(Of Integer)
			Dim selectedRows As New List(Of Integer)()
			For i As Integer = 0 To discountGrid.Cells.MultiSelection.SelectedCells.Count - 1
				If (Not selectedRows.Contains(discountGrid.Cells.MultiSelection.SelectedCells(i).Y)) Then
					selectedRows.Add(discountGrid.Cells.MultiSelection.SelectedCells(i).Y)
				End If
			Next i
			Return selectedRows
		End Function
		Private Sub SetSelection(ByVal selectedRows As List(Of Integer))
			Dim selectedCells As New List(Of Point)()
			For x As Integer = 0 To discountGrid.Cells.ColumnCount - 1
				For i As Integer = 0 To selectedRows.Count - 1
					selectedCells.Add(New Point(x, selectedRows(i)))
				Next i
			Next x
			discountGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray())
		End Sub
		Private Sub discountGrid_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles discountGrid.MouseMove
			Dim hitInfo As PivotGridHitInfo = discountGrid.CalcHitInfo(e.Location)
			If MustShowCustomerTooltip(hitInfo) Then
				Dim customer As Customer = TryCast(hitInfo.ValueInfo.Value, Customer)
				If (Not Object.Equals(customer, Nothing)) Then
					Dim location As Point = e.Location
					location.Offset(20, 20)
					tooltip.ShowHint(customer, location)
				End If
			Else
				tooltip.HideHint(True)
			End If
		End Sub
		Private Sub discountChart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles discountChart.MouseMove
			Dim hitInfo As ChartHitInfo = discountChart.CalcHitInfo(e.X, e.Y)
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
		Private Sub discountGrid_FieldTooltipShowing(ByVal sender As Object, ByVal e As PivotFieldTooltipShowingEventArgs) Handles discountGrid.FieldTooltipShowing
			Dim hitInfo As PivotGridHitInfo = e.HitInfo
			If MustShowCustomerTooltip(hitInfo) Then
				e.ShowTooltip = False
			End If
		End Sub
		Private Function MustShowCustomerTooltip(ByVal hitInfo As PivotGridHitInfo) As Boolean
            Return Object.Equals(hitInfo.HitTest, PivotGridHitTest.Value) AndAlso Object.Equals(hitInfo.ValueInfo.Field, fieldCustomer)
		End Function
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			discountChart.BeginInit()
			Try
				Dim selectedRows As List(Of Integer) = GetSelectedRows()
				discountGrid.BeginUpdate()
				Try
					SetDateFilter()
				Finally
					discountGrid.EndUpdate()
				End Try
				SetSelection(selectedRows)
			Finally
				discountChart.EndInit()
			End Try
		End Sub
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
				components.Dispose()
			End If
			If disposing Then
				If (Not Object.Equals(discountOverTimeGrid, Nothing)) Then
					discountOverTimeGrid.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub
	End Class
End Namespace
