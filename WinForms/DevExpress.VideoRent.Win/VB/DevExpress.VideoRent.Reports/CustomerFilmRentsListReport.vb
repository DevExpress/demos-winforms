Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.XtraReports.Parameters
Imports System.Data
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI

Namespace DevExpress.VideoRent.Reports
	Public Enum ShowMode
		FullHistory
		NotReturnedRents
		ExpiredRents
	End Enum
	Partial Public Class CustomerFilmRentsListReport
		Inherits CustomerSelectionReportBase
		Private Const parameterName As String = "showModeParameter"

		Public Sub New()
			InitializeComponent()
			DisplayName = ReportConstStrings.FilmRentsReport
			Parameters(parameterName).Type = GetType(ShowMode)
			AddHandler ParametersRequestBeforeShow, AddressOf CustomerFilmRentsListReport_ParametersRequestBeforeShow
		End Sub

		Private Sub CustomerFilmRentsListReport_ParametersRequestBeforeShow(ByVal sender As Object, ByVal e As ParametersRequestEventArgs)
			For Each info As ParameterInfo In e.ParametersInformation
				If info.Parameter.Name = parameterName Then
					info.Editor = CreateShowModeEditor(New ShowMode() { ShowMode.FullHistory, ShowMode.NotReturnedRents, ShowMode.ExpiredRents }, New String() { "Complete History", "Non-Returned Rentals Only", "Expired Rentals Only" })
				End If
			Next info
		End Sub
		Private Function CreateShowModeEditor(ByVal values As Array, ByVal names() As String) As ImageComboBoxEdit
			Dim result As New ImageComboBoxEdit()
			Dim i As Integer = 0
			Do While i < values.Length AndAlso i < names.Length
				result.Properties.Items.Add(New ImageComboBoxItem(names(i), values.GetValue(i)))
				i += 1
			Loop
			Return result
		End Function
		Protected Overrides Sub OnParametersRequestSubmit(ByVal e As ParametersRequestEventArgs)
			MyBase.OnParametersRequestSubmit(e)

			Dim currentShowingVariant As Integer = CInt(Fix(Parameters(parameterName).Value))
			Select Case currentShowingVariant
				Case (0)
						DetailReportRents.FilterString = String.Empty
						Exit Select
				Case (1)
						DetailReportRents.FilterString = String.Format("[Active] = {0}", Boolean.TrueString)
						Exit Select
				Case (2)
						DetailReportRents.FilterString = String.Format("[IsOverdue] = {0}", Boolean.TrueString)
						Exit Select
				Case Else
						Throw New Exception("Invalid 'switch' branch.")
			End Select
		End Sub
		Private Sub xpCollectionCustomers_ResolveSession(ByVal sender As Object, ByVal e As ResolveSessionEventArgs) Handles xpCollectionCustomers.ResolveSession
			e.Session = Session
		End Sub
		Private Sub xrPictureBoxCustomerPhoto_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrPictureBoxCustomerPhoto.BeforePrint
			Dim photo As XRPictureBox = TryCast(sender, XRPictureBox)
			If Object.Equals(photo.Image, Nothing) Then
				photo.Image = ReferenceImages.UnknownPerson
			End If
		End Sub
		Private Sub xrPictureBoxPhoto_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrPictureBoxPhoto.BeforePrint
			Dim photo As XRPictureBox = TryCast(sender, XRPictureBox)
			If Object.Equals(photo.Image, Nothing) Then
				photo.Image = ReferenceImages.UnknownMovie
			End If
		End Sub
		Private Sub xrTableCellReturnedOn_BeforePrint(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles xrTableCellReturnedOn.BeforePrint
			Dim xrTblClReturnedOn As XRTableCell = TryCast(sender, XRTableCell)
			If String.IsNullOrEmpty(xrTblClReturnedOn.Text) Then
				xrTblClReturnedOn.Text = "Not yet returned."
			End If
		End Sub
	End Class
End Namespace
