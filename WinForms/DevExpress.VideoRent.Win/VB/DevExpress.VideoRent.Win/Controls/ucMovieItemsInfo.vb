Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraLayout
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraCharts
Imports DevExpress.Data.Helpers

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieItemsInfo
		Inherits XtraUserControl
		Private countInfo As MovieItem.CountInfo
		Private formatsAndAll() As Nullable(Of MovieItemFormat)

		Public Sub New()
			InitializeComponent()
		End Sub

		Private ReadOnly Property FormatSeries() As Series
			Get
				Return ccFormatsInfo.Series(0)
			End Get
		End Property
		Private ReadOnly Property RentalSalesInfoSeries() As Series
			Get
				Return ccFormatsInfo.Series(1)
			End Get
		End Property

		Public Sub Init(ByVal category As MovieCategory, ByVal items As XPCollection(Of MovieItem), ByVal manager As IDXMenuManager)
			tcFormats.BeginUpdate()
			Try
				lcMain.MenuManager = manager
				countInfo = New MovieItem.CountInfo(items)
				If Object.Equals(countInfo.LastRentedOn, Nothing) Then
					teLastRentedOn.Text = String.Empty
				Else
					teLastRentedOn.Text = countInfo.LastRentedOn.Value.ToString()
				End If
				For i As Integer = tcFormats.TabPages.Count - 1 To 0 Step -1
					tcFormats.TabPages(i).Dispose()
				Next i
				tcFormats.Images = ElementHelper.DiskIcons
				Dim formats() As MovieItemFormat = CType(System.Enum.GetValues(GetType(MovieItemFormat)), MovieItemFormat())
				formatsAndAll = New Nullable(Of MovieItemFormat)(formats.Length){}
				For i As Integer = 0 To formats.Length - 1
					formatsAndAll(i) = formats(i)
				Next i
				formatsAndAll(formatsAndAll.Length - 1) = Nothing
				InitFormatSeries(formats)
				For Each format As Nullable(Of MovieItemFormat) In formatsAndAll
					Dim tab As New XtraTab.XtraTabPage()
					Dim categoryPrice As MovieCategoryPrice
					If Object.Equals(format, Nothing) Then
						categoryPrice = Nothing
					Else
						categoryPrice = category.GetPrice(format.Value)
					End If
					Dim ucInfo As New ucRentalSalesInfo(categoryPrice, countInfo, format, lcMain.MenuManager)
					tab.Text = ElementHelper.MovieItemFormatName(format)
					If Object.Equals(format, Nothing) Then
						tab.ImageIndex = -1
					Else
						tab.ImageIndex = CInt(Fix(format)) - 1
					End If
					tab.Controls.Add(ucInfo)
					ucInfo.Dock = DockStyle.Fill
					tab.Padding = New System.Windows.Forms.Padding(12)
					tcFormats.TabPages.Add(tab)
				Next format
			Finally
				tcFormats.EndUpdate()
			End Try
		End Sub
		Private Sub InitFormatSeries(ByVal formats() As MovieItemFormat)
			If Object.Equals(FormatSeries, Nothing) Then
				Return
			End If
			FormatSeries.Points.Clear()
			For i As Integer = 0 To formats.Length - 1
				FormatSeries.Points.Add(New SeriesPoint(formats(i), countInfo.WithFormat(i)))
			Next i
		End Sub
		Private Sub InitRentalSalesInfoSeries(ByVal format As Nullable(Of MovieItemFormat))
			If Object.Equals(RentalSalesInfoSeries, Nothing) Then
				Return
			End If
			RentalSalesInfoSeries.Points.Clear()
			Dim statuses() As MovieItemStatus = countInfo.Statuses
			If Object.Equals(format, Nothing) Then
				For i As Integer = 0 To statuses.Length - 1
					RentalSalesInfoSeries.Points.Add(New SeriesPoint(statuses(i), countInfo.WithStatus(i)))
				Next i
			Else
				Dim formatIndex As Integer = countInfo.FormatIndex(format.Value)
				For i As Integer = 0 To statuses.Length - 1
					RentalSalesInfoSeries.Points.Add(New SeriesPoint(statuses(i), countInfo.WithFormatAndStatus(formatIndex, i)))
				Next i
			End If
			Dim salesInfoSeriesView As DoughnutSeriesView = (CType(RentalSalesInfoSeries.View, DoughnutSeriesView))
			If (Not Object.Equals(salesInfoSeriesView, Nothing)) Then
				salesInfoSeriesView.Titles(0).Text = ElementHelper.MovieItemFormatName(format)
			End If
		End Sub
		Private Sub ExplodeFormatSeries(ByVal format As Nullable(Of MovieItemFormat))
			Dim formatSeriesView As DoughnutSeriesView = (CType(FormatSeries.View, DoughnutSeriesView))
			If (Not Object.Equals(formatSeriesView, Nothing)) Then
				formatSeriesView.ExplodedPoints.Clear()
				If Object.Equals(format, Nothing) Then
					formatSeriesView.ExplodeMode = PieExplodeMode.All
				Else
					Dim index As Integer = countInfo.FormatIndex(format.Value)
					formatSeriesView.ExplodedPoints.Add(FormatSeries.Points(index))
				End If
			End If
		End Sub
		Private Sub tcFormats_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles tcFormats.SelectedPageChanged
			If tcFormats.SelectedTabPageIndex >= 0 Then
				Dim format As Nullable(Of MovieItemFormat) = formatsAndAll(tcFormats.SelectedTabPageIndex)
				InitRentalSalesInfoSeries(format)
				ExplodeFormatSeries(format)
			End If
		End Sub
		Private Sub ccFormatsInfo_PieSeriesPointExploded(ByVal sender As Object, ByVal e As PieSeriesPointExplodedEventArgs) Handles ccFormatsInfo.PieSeriesPointExploded
			If e.Dragged AndAlso e.Exploded AndAlso Object.Equals(e.Series, FormatSeries) Then
				tcFormats.SelectedTabPageIndex = FormatSeries.Points.IndexOf(e.Point)
			End If
		End Sub

		Private Sub ccFormatsInfo_CustomDrawSeriesPoint(ByVal sender As Object, ByVal e As CustomDrawSeriesPointEventArgs) Handles ccFormatsInfo.CustomDrawSeriesPoint
            If e.SeriesPoint.Argument = MovieItemStatus.Active.ToString() Then
                e.LabelText = String.Format("{1}: {0}", e.SeriesPoint.Values(0), e.SeriesPoint.Argument)
            Else
                e.LabelText = String.Format("{1}: {0}", e.SeriesPoint.Values(0), MasterDetailHelper.SplitPascalCaseString(e.SeriesPoint.Argument))
            End If
		End Sub
	End Class
End Namespace
