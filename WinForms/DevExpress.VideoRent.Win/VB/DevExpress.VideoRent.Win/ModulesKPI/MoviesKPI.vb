Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraLayout
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace DevExpress.VideoRent.Win.ModulesKPI
	Partial Public Class MoviesKPI
		Inherits ChartExportTutorialControl
		Private Const selectedRowsCount As Integer = 5

		Private tooltip As MovieToolTipController
		Private inSelectionUpdate As Boolean

		Protected Friend Overrides ReadOnly Property ChartViewType() As ViewType
			Get
				Return ViewType.Spline
			End Get
		End Property
		Protected Overrides ReadOnly Property MainChart() As ChartControl
			Get
				Return profitChart
			End Get
		End Property
		Protected Overrides ReadOnly Property MainLayoutControl() As LayoutControl
			Get
				Return layoutControl1
			End Get
		End Property
		Protected Overrides ReadOnly Property AllowRotateLayout() As Boolean
			Get
				Return True
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
            profitGrid.BestFit()
			tooltip = New MovieToolTipController(profitGrid)
		End Sub
		Private Sub SetDateFilter()
			rentsCollection.Criteria = New GroupOperator(GroupOperatorType.And, New BinaryOperator("RentedOn", PeriodManager.KPIPeriod.StartDate, BinaryOperatorType.GreaterOrEqual), New BinaryOperator("RentedOn", PeriodManager.KPIPeriod.EndDate, BinaryOperatorType.LessOrEqual))
		End Sub
        Private Sub rentsCollection_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles rentsCollection.ResolveSession
            e.Session = Session
        End Sub
        Private Sub MovieKPI_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			profitGrid.Cells.Selection = New Rectangle(0, 0, profitGrid.Cells.ColumnCount, selectedRowsCount)
			profitChart.DataSource = profitGrid
		End Sub
		Private Sub UpdateSelection()
			If inSelectionUpdate Then
				Return
			End If
			inSelectionUpdate = True
			SetSelection(GetSelectedRows())
			inSelectionUpdate = False
		End Sub
		Private Function GetSelectedRows() As List(Of Integer)
			Dim selectedRows As New List(Of Integer)()
			For i As Integer = 0 To profitGrid.Cells.MultiSelection.SelectedCells.Count - 1
				If (Not selectedRows.Contains(profitGrid.Cells.MultiSelection.SelectedCells(i).Y)) Then
					selectedRows.Add(profitGrid.Cells.MultiSelection.SelectedCells(i).Y)
				End If
			Next i
			Return selectedRows
		End Function
		Private Sub SetSelection(ByVal selectedRows As List(Of Integer))
			Dim selectedCells As New List(Of Point)()
			For x As Integer = 0 To profitGrid.Cells.ColumnCount - 1
				For i As Integer = 0 To selectedRows.Count - 1
					selectedCells.Add(New Point(x, selectedRows(i)))
				Next i
			Next x
			profitGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray())
		End Sub
		Private Sub profitGrid_FocusedCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles profitGrid.FocusedCellChanged
			If inSelectionUpdate Then
				Return
			End If
			inSelectionUpdate = True
			If profitGrid.Cells.MultiSelection.SelectedCells.Count = 0 Then
				Dim selectedCells As New List(Of Point)()
				For x As Integer = 0 To profitGrid.Cells.ColumnCount - 1
					selectedCells.Add(New Point(x, profitGrid.Cells.FocusedCell.Y))
				Next x
				profitGrid.Cells.MultiSelection.SetSelection(selectedCells.ToArray())
			End If
			inSelectionUpdate = False
		End Sub
		Private Sub profitGrid_CellSelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles profitGrid.CellSelectionChanged
			UpdateSelection()
		End Sub
		Private Sub profitGrid_FieldExpandedInFieldGroupChanged(ByVal sender As Object, ByVal e As PivotFieldEventArgs) Handles profitGrid.FieldExpandedInFieldGroupChanged
			UpdateSelection()
		End Sub
		Private Sub profitGrid_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles profitGrid.MouseMove
			Dim hitInfo As PivotGridHitInfo = profitGrid.CalcHitInfo(e.Location)
			If MustShowMovieTooltip(hitInfo) Then
				Dim movie As Movie = CType(hitInfo.ValueInfo.Value, Movie)
				Dim location As Point = e.Location
				location.Offset(20, 20)
				tooltip.ShowHint(movie, location)
			Else
				tooltip.HideHint(True)
			End If
		End Sub
		Private Sub profitGrid_FieldTooltipShowing(ByVal sender As Object, ByVal e As PivotFieldTooltipShowingEventArgs) Handles profitGrid.FieldTooltipShowing
			Dim info As PivotGridHitInfo = e.HitInfo
			If MustShowMovieTooltip(info) Then
				e.ShowTooltip = False
			End If
		End Sub
		Private Function MustShowMovieTooltip(ByVal info As PivotGridHitInfo) As Boolean
            Return Object.Equals(info.HitTest, PivotGridHitTest.Value) AndAlso Object.Equals(info.ValueInfo.Field, fieldMovie)
		End Function
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			profitChart.BeginInit()
			Try
				Dim selectedRows As List(Of Integer) = GetSelectedRows()
				profitGrid.BeginUpdate()
				Try
					SetDateFilter()
				Finally
					profitGrid.EndUpdate()
				End Try
				SetSelection(selectedRows)
			Finally
				profitChart.EndInit()
			End Try
			profitGrid.BestFit()
		End Sub
	End Class
End Namespace
