Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraReports.UI
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Reports
	Partial Public Class CustomerInfoCardReport
		Inherits CustomerSelectionReportBase
		Public Sub New()
			InitializeComponent()
			DisplayName = ReportConstStrings.CustomerCardsReport
		End Sub

		Private Sub xrBarCodeCustomer_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrBarCodeCustomerId.BeforePrint
			Dim barCode As XRBarCode = TryCast(sender, XRBarCode)
			Dim customer As Customer = TryCast(GetCurrentRow(), Customer)
			barCode.Text = String.Format("{0:d6}", customer.CustomerId)
		End Sub
		Private Sub xpCollectionCustomers_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionCustomers.ResolveSession
			e.Session = Session
		End Sub
		Private Sub xrPictBoxPhoto_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrPictBoxPhoto.BeforePrint
			Dim photo As XRPictureBox = TryCast(sender, XRPictureBox)
			If Object.Equals(photo.Image, Nothing) Then
				photo.Image = ReferenceImages.UnknownPerson
			End If
		End Sub
	End Class
End Namespace
