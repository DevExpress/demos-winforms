Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace DevExpress.VideoRent.Reports
	Partial Public Class TopNFilmsReport
		Inherits TimePeriodReportBase

		Public Sub New()
			InitializeComponent()
			DisplayName = ReportConstStrings.TopFilmsReport
		End Sub

		Private Sub xpCollectionMovies_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionMovies.ResolveSession
			e.Session = Session
		End Sub
		Private Sub calculatedFieldRentsCount_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs) Handles calculatedFieldRentsCount.GetValue
			Dim movie As Movie = TryCast(e.Row, Movie)
			Dim filter As CriteriaOperator = New GroupOperator(GroupOperatorType.And, New BinaryOperator("RentedOn", CDate(Parameters(startDateParamName).Value), BinaryOperatorType.GreaterOrEqual), New BinaryOperator("RentedOn", CDate(Parameters(endDateParamName).Value), BinaryOperatorType.LessOrEqual))
            e.Value = CInt(Fix(Session.Evaluate(Session.GetClassInfo(Of Rent)(), CriteriaOperator.Parse("count()"), CriteriaOperator.Parse("Item.Movie.Oid = ?", movie.Oid) And filter)))
		End Sub
		Protected Overrides Function CreateClone() As XtraReport
			Dim clone As TopNFilmsReport = CType(MyBase.CreateClone(), TopNFilmsReport)
			clone.Session = Me.Session
			Return clone
		End Function
		Private Sub xrPictureBoxCover_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrPictureBoxCover.BeforePrint
			Dim photo As XRPictureBox = TryCast(sender, XRPictureBox)
			If Object.Equals(photo.Image, Nothing) Then
				photo.Image = ReferenceImages.UnknownMovie
			End If
		End Sub
		Private Sub TopNFilmsReport_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint
			FilterString = "[calculatedFieldRentsCount] <> '0'"
			RemoveHandler Me.BeforePrint, AddressOf TopNFilmsReport_BeforePrint
		End Sub
	End Class
End Namespace
