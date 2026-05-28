Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Globalization
Imports DevExpress.Data.PivotGrid
Imports DevExpress.XtraCharts
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraLayout
Imports DevExpress.VideoRent.Win.Modules
Imports DevExpress.XtraGrid.Views.Base

Namespace DevExpress.VideoRent.Win.ModulesStatistics
	Partial Public Class MediaPerformanceStatistics
		Inherits ChartExportTutorialControl
		Private salesGrid As SalesPivotGridHelper
		Private mostRentedPivotGrid As MostRentedPivotGridHelper
        Private fselectedFormat As MovieItemFormat

        Protected Friend Overrides ReadOnly Property UseList() As Boolean
            Get
                Return False
            End Get
        End Property
        Protected Overrides ReadOnly Property MainChart() As ChartControl
            Get
                Return chart
            End Get
        End Property
        Protected Overrides ReadOnly Property AlternateChart() As ChartControl
            Get
                Return chartRevenues
            End Get
        End Property
        Protected Overrides ReadOnly Property MainLayoutControl() As LayoutControl
            Get
                Return layoutControl1
            End Get
        End Property
        Protected Overrides ReadOnly Property MainView() As ColumnView
            Get
                Return cardView1
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

            Me.salesGrid = New SalesPivotGridHelper()
            Me.chartRevenues.DataSource = Me.salesGrid.ChartDataSource

            Me.mostRentedPivotGrid = New MostRentedPivotGridHelper()
            Me.fselectedFormat = MovieItemFormat.DVD
        End Sub
        Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso ((Not Object.Equals(components, Nothing))) Then
                components.Dispose()
            End If
            If disposing Then
                salesGrid.Dispose()
                mostRentedPivotGrid.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
        Public Property SelectedFormat() As MovieItemFormat
            Get
                Return fselectedFormat
            End Get
            Set(ByVal value As MovieItemFormat)
                If fselectedFormat = value Then
                    Return
                End If
                fselectedFormat = value
                UpdateFormatStats()
            End Set
        End Property

        Protected Overrides Sub InitData()
            MyBase.InitData()
            Dim movieItems As New XPCollection(Of MovieItem)(Session)
            chart.DataSource = movieItems

            UpdateFormatStats()
            UpdateChartSelection()
        End Sub

        Private Function GetFormatFromHitInfo(ByVal hitInfo As ChartHitInfo) As Nullable(Of MovieItemFormat)
            If hitInfo.HitTest = ChartHitTest.Series AndAlso ((Not Object.Equals(hitInfo.SeriesPoint, Nothing))) AndAlso (Not String.IsNullOrEmpty(hitInfo.SeriesPoint.Argument)) Then
                Try
                    Dim format As MovieItemFormat = CType(System.Enum.Parse(GetType(MovieItemFormat), hitInfo.SeriesPoint.Argument), MovieItemFormat)
                    Return format
                Catch
                End Try
            End If
            Return Nothing
        End Function

        Private Sub chart_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseClick
            If e.Button = MouseButtons.Left OrElse Object.Equals(e.Button, MouseButtons.Middle) Then
                Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
                Dim format As Nullable(Of MovieItemFormat) = GetFormatFromHitInfo(hitInfo)
                If Object.Equals(format, Nothing) Then
                    Return
                End If
                SelectedFormat = format.Value
            End If
        End Sub
        Friend Overrides Sub RefreshData()
            MyBase.RefreshData()
            UpdateFormatStats()
            UpdateChartSelection()
        End Sub
        Private Sub UpdateFormatStats()
            Dim rents As New XPCollection(Of Rent)(Session, New GroupOperator(GroupOperatorType.And, New BinaryOperator("Item.Format", SelectedFormat, BinaryOperatorType.Equal), New BinaryOperator("Receipt.Date", DateTime.Now.AddYears(-1), BinaryOperatorType.GreaterOrEqual)))
            Me.salesGrid.DataSource = rents
            Me.chartRevenues.Titles(0).Text = String.Format(ConstStrings.MovieRevenues, SelectedFormat)
            Me.mostRentedPivotGrid.DataSource = rents
            Me.gridControl1.DataSource = Me.mostRentedPivotGrid.CreateSummaryDataSource()
            Me.cardView1.ViewCaption = String.Format(ConstStrings.MostRentedMovies, SelectedFormat)
        End Sub

        Private Sub UpdateChartSelection()
            chart.ClearSelection()
            Dim series As Series = chart.Series(0)
            chart.SetObjectSelection(FindSeriesPoint(series, SelectedFormat.ToString()))
        End Sub

        Private Function FindSeriesPoint(ByVal series As Series, ByVal argument As String) As SeriesPoint
            For Each pt As SeriesPoint In series.Points
                If pt.Argument = argument Then
                    Return pt
                End If
            Next pt
            Return Nothing
        End Function

        Private Sub chart_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chart.MouseMove
            Dim hitInfo As ChartHitInfo = chart.CalcHitInfo(e.Location)
            Dim format As Nullable(Of MovieItemFormat) = GetFormatFromHitInfo(hitInfo)
            If (Not Object.Equals(format, Nothing)) Then
                chart.Cursor = Cursors.Hand
            Else
                chart.Cursor = Cursors.Default
            End If
        End Sub

        Private Sub chart_MouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles chart.MouseLeave
            chart.Cursor = Cursors.Default
        End Sub

        Private Sub chartRevenues_BoundDataChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chartRevenues.BoundDataChanged
            Dim totalSeries As Series = chartRevenues.Series(SalesPivotGridHelper.TotalText)
            If (Not Object.Equals(totalSeries, Nothing)) Then
                totalSeries.ChangeView(ViewType.Bar)
                totalSeries.LabelsVisibility = Utils.DefaultBoolean.False
            End If
        End Sub

        Private Sub chart_ObjectHotTracked(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chart.ObjectHotTracked
            If (Not e.HitInfo.InSeries) Then
                e.Cancel = True
            End If
        End Sub

        Private Sub chart_ObjectSelected(ByVal sender As Object, ByVal e As HotTrackEventArgs) Handles chart.ObjectSelected
            If (Not e.HitInfo.InSeries) Then
                e.Cancel = True
            End If
        End Sub

        Private Sub cardView1_CalcFieldHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Card.FieldHeightEventArgs) Handles cardView1.CalcFieldHeight
            If e.Column IsNot colPhoto Then
                Return
            End If
            Dim img As Image = TryCast(cardView1.GetRowCellValue(e.RowHandle, e.Column), Image)
            If (Not Object.Equals(img, Nothing)) Then
                e.FieldHeight = Math.Min(img.Height, cardView1.ViewRect.Height - 100)
            End If
            If e.FieldHeight < 20 Then
                e.FieldHeight = 20
            End If
        End Sub
        Protected Overrides ReadOnly Property CurrentEditObject() As VideoRentBaseObject
            Get
                Dim row As PivotSummaryDataRow = TryCast(cardView1.GetRow(cardView1.FocusedRowHandle), PivotSummaryDataRow)
                If Object.Equals(row, Nothing) Then
                    Return Nothing
                End If
                Return mostRentedPivotGrid.GetMovie(row.RowIndex)
            End Get
        End Property
        Public Overrides Sub Edit()
            MyBase.Edit()
            If (Not IsDetailExist(CurrentEditObject.Oid)) Then
                ShowModuleDialog(New MovieDetail(Me.FindForm(), Session, TryCast(CurrentEditObject, Movie), MenuManager, AddressOf CloseDetailForm), True)
            End If
        End Sub
    End Class

    Friend Class SalesPivotGridHelper
        Implements IDisposable
        Public Const TotalText As String = ConstStrings.Total

        Private pivotGrid As PivotGridControl
        Private fieldMonth, fieldReceiptType As PivotGridField

        Public Sub New()
            Me.pivotGrid = New PivotGridControl()
            AddHandler pivotGrid.CustomGroupInterval, AddressOf salesGrid_CustomGroupInterval
            AddHandler pivotGrid.FieldValueDisplayText, AddressOf salesGrid_FieldValueDisplayText
            Me.pivotGrid.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near

            Me.pivotGrid.OptionsChartDataSource.ProvideColumnGrandTotals = False
            Me.pivotGrid.OptionsChartDataSource.SelectionOnly = False
            Me.pivotGrid.OptionsChartDataSource.ProvideDataByColumns = False

            Me.pivotGrid.Fields.Add("Payment", PivotArea.DataArea)
            Me.fieldMonth = Me.pivotGrid.Fields.Add("Receipt.Date", PivotArea.ColumnArea)
            Me.fieldMonth.GroupInterval = PivotGroupInterval.Custom
            Me.fieldReceiptType = Me.pivotGrid.Fields.Add("Receipt.Type", PivotArea.RowArea)
        End Sub

        Public ReadOnly Property ChartDataSource() As Object
            Get
                Return Me.pivotGrid
            End Get
        End Property

        Public Property DataSource() As Object
            Get
                Return Me.pivotGrid.DataSource
            End Get
            Set(ByVal value As Object)
                Me.pivotGrid.DataSource = value
            End Set
        End Property

        Private Sub salesGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If Object.Equals(e.Field, fieldMonth) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                e.DisplayText = valueAsDate.ToString("MMM yyyy")
            End If
            If Object.Equals(e.Field, fieldReceiptType) Then
                Dim valueAsReceiptType As ReceiptType = CType(e.Value, ReceiptType)
                e.DisplayText = EditorHelper.GetReceiptTypeString(valueAsReceiptType)
            End If
            If Object.Equals(e.Field, Nothing) Then
                e.DisplayText = TotalText
            End If
        End Sub

        Private Sub salesGrid_CustomGroupInterval(ByVal sender As Object, ByVal e As PivotCustomGroupIntervalEventArgs)
            If Object.Equals(e.Field, fieldMonth) Then
                Dim valueAsDate As DateTime = CDate(e.Value)
                e.GroupValue = New DateTime(valueAsDate.Year, valueAsDate.Month, 1)
            End If
        End Sub

#Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            If (Not Object.Equals(pivotGrid, Nothing)) Then
                RemoveHandler pivotGrid.CustomGroupInterval, AddressOf salesGrid_CustomGroupInterval
                RemoveHandler pivotGrid.FieldValueDisplayText, AddressOf salesGrid_FieldValueDisplayText
                pivotGrid.Fields.Clear()
                pivotGrid.Dispose()
            End If
        End Sub
#End Region
    End Class
    Friend Class MostRentedPivotGridHelper
        Implements IDisposable
        Private fpivotGrid As PivotGridControl
        Private fieldRentCount, fieldMovie As PivotGridField

        Public Sub New()
            Me.fpivotGrid = New PivotGridControl()
            AddHandler fpivotGrid.FieldValueDisplayText, AddressOf pivotGrid_FieldValueDisplayText

            Me.fpivotGrid.OptionsChartDataSource.SelectionOnly = False
            Me.fpivotGrid.OptionsChartDataSource.ProvideRowGrandTotals = False
            Me.fpivotGrid.OptionsDataField.FieldNaming = DataFieldNaming.Name

            Me.fieldRentCount = Me.fpivotGrid.Fields.Add("Payment", PivotArea.DataArea)
            Me.fieldRentCount.Name = "Payment_Sum"
            Me.fieldRentCount.SummaryType = PivotSummaryType.Count

            Me.fieldMovie = Me.fpivotGrid.Fields.Add("Item!.Movie", PivotArea.RowArea)
            Me.fieldMovie.Name = "Movie"
            Me.fieldMovie.SortBySummaryInfo.Field = Me.fieldRentCount
            Me.fieldMovie.SortOrder = PivotSortOrder.Descending
            Me.fieldMovie.TopValueCount = 5
        End Sub

        Public ReadOnly Property PivotGrid() As PivotGridControl
            Get
                Return fpivotGrid
            End Get
        End Property

        Public Function GetMovie(ByVal index As Integer) As Movie
            Return TryCast(fpivotGrid.GetFieldValue(fieldMovie, index), Movie)
        End Function

        Public Function CreateSummaryDataSource() As PivotSummaryDataSource
            Return Me.fpivotGrid.CreateSummaryDataSource()
        End Function

        Public Property DataSource() As Object
            Get
                Return Me.fpivotGrid.DataSource
            End Get
            Set(ByVal value As Object)
                Me.fpivotGrid.DataSource = value
            End Set
        End Property

        Private Sub pivotGrid_FieldValueDisplayText(ByVal sender As Object, ByVal e As PivotFieldDisplayTextEventArgs)
            If Object.Equals(e.Field, fieldMovie) Then
                Dim valueAsMovie As Movie = CType(e.Value, Movie)
                e.DisplayText = valueAsMovie.Title
            End If
        End Sub

#Region "IDisposable Members"
        Public Sub Dispose() Implements IDisposable.Dispose
            If (Not Object.Equals(fpivotGrid, Nothing)) Then
                RemoveHandler fpivotGrid.FieldValueDisplayText, AddressOf pivotGrid_FieldValueDisplayText
                fpivotGrid.Fields.Clear()
                fpivotGrid.Dispose()
            End If
        End Sub
#End Region
    End Class
End Namespace
