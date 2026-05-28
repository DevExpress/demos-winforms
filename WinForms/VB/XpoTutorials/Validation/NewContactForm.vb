Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.Xpo.Demos
    Partial Public Class NewContactForm
        Inherits DevExpress.XtraEditors.XtraForm
        '<gridControl1>
        Private theContact As Contact
        Private theDXErrorProvider As DXErrorProvider
        '</gridControl1>

        '<gridControl1>
        Public Sub New(ByVal theContact As Contact, ByVal theDXErrorProvider As DXErrorProvider)
            Me.theContact = theContact
            Me.theDXErrorProvider = theDXErrorProvider
            '
            ' Required for Windows Form Designer support
            '
            InitializeComponent()
            InitBindings()
            InitErrorProvider()
        End Sub

        ' Initializes the DXErrorProvider
        Private Sub InitErrorProvider()
            theDXErrorProvider.ContainerControl = Me
            theDXErrorProvider.DataSource = theContact
        End Sub
        '</gridControl1>

        Private Sub InitBindings()
            teFirstName.DataBindings.Add("EditValue", theContact, "FirstName")
            teLastName.DataBindings.Add("EditValue", theContact, "LastName")
            teAddress.DataBindings.Add("EditValue", theContact, "Address")
            tePhone.DataBindings.Add("EditValue", theContact, "PhoneNumber")
            teEmail.DataBindings.Add("EditValue", theContact, "Email")
        End Sub

        Private Sub UpdateOkButtonState()
            For Each control As Control In Controls
                If theDXErrorProvider.GetError(control) <> String.Empty AndAlso theDXErrorProvider.GetErrorType(control) = ErrorType.Critical Then
                    sbOk.Enabled = False
                    Return
                End If
            Next control
            sbOk.Enabled = True
        End Sub

        Private Sub teFirstName_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles teFirstName.Validated, teLastName.Validated
            UpdateOkButtonState()
        End Sub
    End Class
End Namespace
