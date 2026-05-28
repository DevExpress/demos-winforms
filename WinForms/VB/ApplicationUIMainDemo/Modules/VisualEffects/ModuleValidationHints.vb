Imports System
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Windows.Forms
Imports DevExpress.Data.Utils.Security
Imports DevExpress.Utils.VisualEffects

Namespace DevExpress.ApplicationUI.Demos.VisualEffects

    Public Partial Class ModuleValidationHints
        Inherits TutorialControl

        Public Sub New()
            InitializeComponent()
            CausesValidation = False
            AutoValidate = AutoValidate.EnableAllowFocusChange
            AddHandler tePassword.Validating, AddressOf OnPasswordValidating
            AddHandler tePhone.Validating, AddressOf OnPhoneValidating
            AddHandler teAge.Validating, AddressOf OnAgeValidating
            teName.Tag = vhName
            teUserName.Tag = vhUserName
            tePassword.Tag = vhPassword
            teAddress.Tag = vhAddress
            teAge.Tag = vhAge
            teEMail.Tag = vhEMail
            tePhone.Tag = vhPhone
        End Sub

        Protected Overrides Sub OnHandleCreated(ByVal e As EventArgs)
            MyBase.OnHandleCreated(e)
            UpdateCenteredControls(Me)
        End Sub

        Private Sub OnAgeValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            vhAge.Properties.State = CalcTextEditValidationState(teAge, e)
        End Sub

        Private Function CalcTextEditValidationState(ByVal edit As XtraEditors.TextEdit, ByVal e As CancelEventArgs) As ValidationHintState
            If edit.EditValue Is Nothing OrElse String.IsNullOrEmpty(edit.Text) Then Return ValidationHintState.Indeterminate
            Return If(e.Cancel, ValidationHintState.Invalid, ValidationHintState.Valid)
        End Function

        Private Sub OnPhoneValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            vhPhone.Properties.State = CalcTextEditValidationState(tePhone, e)
        End Sub

        Private Sub OnCheckButtonClick(ByVal sender As Object, ByVal e As EventArgs)
            dataLayoutControl.ValidateChildren()
        End Sub

        Private Sub OnInvalidValue(ByVal sender As Object, ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            Dim editor As Control = TryCast(sender, Control)
            If editor Is Nothing Then Return
            If editor Is tePassword Then OnInvalidPasswordValue(e)
            If editor Is teEMail Then OnInvalidEMailValue(e)
            If editor Is tePhone Then OnInvalidPhoneValue(e)
            Dim hint As ValidationHint = TryCast(editor.Tag, ValidationHint)
            If hint IsNot Nothing Then
                hint.Properties.InvalidState.Text = e.ErrorText
                e.ErrorText = Nothing
            End If
        End Sub

        Private Sub OnPasswordValidating(ByVal sender As Object, ByVal e As CancelEventArgs)
            If tePassword.EditValue IsNot Nothing AndAlso tePassword.EditValue.ToString().Length < 8 Then e.Cancel = True
        End Sub

        Private Sub OnInvalidPhoneValue(ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            If Equals(e.ErrorText, "Invalid Value") Then e.ErrorText = "Invalid phone number."
        End Sub

        Private Sub OnInvalidEMailValue(ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            If Equals(e.ErrorText, "Invalid Value") Then e.ErrorText = "Invalid e-mail."
        End Sub

        Private Sub OnInvalidPasswordValue(ByVal e As XtraEditors.Controls.InvalidValueExceptionEventArgs)
            If Equals(e.ErrorText, "Invalid Value") Then e.ErrorText = "Your password must be at least 8 characters."
        End Sub

        Protected Overrides ReadOnly Property AllowBorderRounding As Boolean?
            Get
                Return True
            End Get
        End Property
    End Class

    Public Class Customer

        <Required(ErrorMessage:="This field is required.")>
        Public Property Name As String

        <Required(ErrorMessage:="This field is required.")>
        Public Property UserName As String

        Private ReadOnly passwordData As SensitiveData = SensitiveData.CreateForCurrentUser()

        <DataType(DataType.Password, ErrorMessage:="Invalid password.")>
        <Required(ErrorMessage:="This field is required.")>
        Public Property Password As String
            Get
                Return passwordData.Text
            End Get

            Set(ByVal value As String)
                passwordData.Text = value
            End Set
        End Property

        <Range(20, 120, ErrorMessage:="Enter the age between 20 and 100.")>
        Public Property Age As Integer

        <Required(ErrorMessage:="This field is required.")>
        Public Property EMail As String

        Public Property Phone As String

        Public Property Address As String
    End Class
End Namespace
