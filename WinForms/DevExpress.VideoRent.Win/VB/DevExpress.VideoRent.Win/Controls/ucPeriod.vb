Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Controls

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucPeriod
		Inherits XtraUserControl
		Private provider As DXValidationProvider
		Public Sub New()
			InitializeComponent()
		End Sub
        Public Sub InitData(ByVal Start As DateTime, ByVal EndEvent As DateTime)
            deStart.DateTime = Start
            deEnd.DateTime = EndEvent
            If EndEvent.Date <> DateTime.Today.Date Then
                Return
            End If
            For Each item As ImageComboBoxItem In icbPeriod.Properties.Items
                Dim expectDate As DateTime = DateTime.Today.Date.AddMonths(-Convert.ToInt32(item.Value))
                If Start.Date = expectDate Then
                    icbPeriod.EditValue = item.Value
                    Return
                End If
            Next item
        End Sub
		Public Function ValidateDates() As Boolean
			If (Not Object.Equals(provider, Nothing)) Then
				provider.Dispose()
			End If
			provider = New DXValidationProvider()
			Dim rule As New ConditionValidationRule()
			rule.ErrorText = ConstStrings.DateLess
			rule.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical
			rule.ConditionOperator = ConditionOperator.GreaterOrEqual
			rule.Value1 = StartDate
			provider.SetValidationRule(Me.deEnd, rule)
			Return provider.Validate()
		End Function
		Private lockChangeDate As Boolean = False
		Private Sub icbPeriod_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles icbPeriod.SelectedIndexChanged
			Dim val As Integer = Convert.ToInt32(icbPeriod.EditValue)
			If val = 0 Then
				Return
			End If
			lockChangeDate = True
			deStart.DateTime = DateTime.Today.AddMonths(-val)
			deEnd.DateTime = DateTime.Today
			lockChangeDate = False
		End Sub
		Public ReadOnly Property StartDate() As DateTime
			Get
				Return deStart.DateTime
			End Get
		End Property
		Public ReadOnly Property EndDate() As DateTime
			Get
				Return deEnd.DateTime
			End Get
		End Property

		Private Sub deStart_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles deStart.EditValueChanged
			If lockChangeDate Then
				Return
			End If
			icbPeriod.EditValue = 0
		End Sub

		Private Sub deEnd_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles deEnd.EditValueChanged
			If lockChangeDate Then
				Return
			End If
			icbPeriod.EditValue = 0
		End Sub
	End Class
End Namespace
