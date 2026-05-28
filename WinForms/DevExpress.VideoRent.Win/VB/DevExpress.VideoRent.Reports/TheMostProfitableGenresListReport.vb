Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.UI
Imports System.Globalization

Namespace DevExpress.VideoRent.Reports
	Partial Public Class TheMostProfitableGenresListReport
		Inherits TimePeriodReportBase
		Private genreTotalRevenue As Decimal
		Private groupGenreTotalRevenue As Decimal

		Public Sub New()
			InitializeComponent()
			DisplayName = ReportConstStrings.GenresReport
		End Sub

		Private Sub xpCollectionTheMostProfitableGenres_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionMovies.ResolveSession
			e.Session = Session
		End Sub
		Private Sub xrLabelTotalRevenue_SummaryGetResult(ByVal sender As Object, ByVal e As SummaryGetResultEventArgs) Handles xrLabelTotalRevenue.SummaryGetResult
			e.Handled = True
			e.Result = genreTotalRevenue
		End Sub
		Private Sub xrLabelTotalRevenue_SummaryRowChanged(ByVal sender As Object, ByVal e As EventArgs) Handles xrLabelTotalRevenue.SummaryRowChanged
			Dim movie As Movie = CType(GetCurrentRow(), Movie)
			Dim movieTotalRevenue As Decimal = Decimal.Zero
			For Each rent As Rent In movie.Rents
				If rent.RentedOn >= CDate(Parameters(startDateParamName).Value) AndAlso rent.RentedOn <= CDate(Parameters(endDateParamName).Value) Then
					movieTotalRevenue += rent.Payment
				End If
			Next rent
			genreTotalRevenue += movieTotalRevenue
			xrTableCellRevenue.Text = String.Format("Revenue: {0}{1}", CultureInfo.CurrentCulture.NumberFormat.CurrencySymbol, movieTotalRevenue)
		End Sub
		Private Sub xrLabelTotalRevenue_SummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles xrLabelTotalRevenue.SummaryReset
			genreTotalRevenue = Decimal.Zero
		End Sub
		Private Sub xrPictureBoxCover_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrPictureBoxCover.BeforePrint
			Dim photo As XRPictureBox = TryCast(sender, XRPictureBox)
			If Object.Equals(photo.Image, Nothing) Then
				photo.Image = ReferenceImages.UnknownMovie
			End If
		End Sub
		Private Sub GroupHeaderGenreGroup_SortingSummaryGetResult(ByVal sender As Object, ByVal e As GroupSortingSummaryGetResultEventArgs) Handles GroupHeaderGenreGroup.SortingSummaryGetResult
			e.Handled = True
			e.Result = groupGenreTotalRevenue
		End Sub
		Private Sub GroupHeaderGenreGroup_SortingSummaryReset(ByVal sender As Object, ByVal e As EventArgs) Handles GroupHeaderGenreGroup.SortingSummaryReset
			groupGenreTotalRevenue = Decimal.Zero
		End Sub
		Private Sub GroupHeaderGenreGroup_SortingSummaryRowChanged(ByVal sender As Object, ByVal e As GroupSortingSummaryRowChangedEventArgs) Handles GroupHeaderGenreGroup.SortingSummaryRowChanged
			Dim movie As Movie = TryCast(e.Row, Movie)
			If Object.Equals(movie, Nothing) Then
				Return
			End If
			Dim groupMovieTotalRevenue As Decimal = Decimal.Zero
			For Each rent As Rent In movie.Rents
				If rent.RentedOn >= CDate(Parameters(startDateParamName).Value) AndAlso rent.RentedOn <= CDate(Parameters(endDateParamName).Value) Then
					groupMovieTotalRevenue += rent.Payment
				End If
			Next rent
			groupGenreTotalRevenue += groupMovieTotalRevenue
		End Sub
	End Class
End Namespace
