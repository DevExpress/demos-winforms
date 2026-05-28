Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Reports
	Partial Public Class ActiveCustomersListReport
		Inherits TimePeriodReportBase
		Public Sub New()
			InitializeComponent()
			DisplayName = ReportConstStrings.ActiveCustomersReport
		End Sub

		Private Sub calculatedFieldCustomerReceiptsCount_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs) Handles calcFieldCustomerReceiptsCount.GetValue
			Dim customer As Customer = TryCast(e.Row, Customer)

			Dim filter As CriteriaOperator = New GroupOperator(GroupOperatorType.And, New BinaryOperator("Date", CDate(Parameters(startDateParamName).Value), BinaryOperatorType.GreaterOrEqual), New BinaryOperator("Date", CDate(Parameters(endDateParamName).Value), BinaryOperatorType.LessOrEqual))

			Using receipts As New XPCollection(Of Receipt)(customer.Receipts, filter)
				If Object.Equals(customer, Nothing) Then
					e.Value = 0
				Else
					e.Value = receipts.Count
				End If
			End Using
		End Sub
		Private Sub xpCollectionCustomers_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionCustomers.ResolveSession
			e.Session = Session
		End Sub
		Private Sub xrPictureBoxPhoto_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrPictureBoxPhoto.BeforePrint
			Dim photo As XRPictureBox = TryCast(sender, XRPictureBox)
			If Object.Equals(photo.Image, Nothing) Then
				photo.Image = ReferenceImages.UnknownPerson
			End If
		End Sub
		Private Sub ActiveCustomersListReport_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint
			FilterString = "[calcFieldCustomerReceiptsCount] <> '0'"
			RemoveHandler Me.BeforePrint, AddressOf ActiveCustomersListReport_BeforePrint
		End Sub
	End Class
End Namespace
