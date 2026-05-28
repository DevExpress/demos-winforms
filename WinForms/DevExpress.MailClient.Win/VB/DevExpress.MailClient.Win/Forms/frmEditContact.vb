Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.MailClient.Win.Forms
    Partial Public Class frmEditContact
        Inherits XtraForm

        Private contact, bindingContact As Contact
        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(ByVal contact As Contact, ByVal menuManager As IDXMenuManager)
            InitializeComponent()
            Me.contact = contact
            Me.bindingContact = contact.Clone()
            InitEditors()
            InitMenuManager(menuManager)
            If bindingContact.Photo IsNot Nothing Then
                pePhoto.Image = TryCast(bindingContact.Photo.Clone(), Image)
            End If
            teFirstName.DataBindings.Add("Text", bindingContact.FullName, "FirstName")
            teLastName.DataBindings.Add("Text", bindingContact.FullName, "LastName")
            teMiddleName.DataBindings.Add("Text", bindingContact.FullName, "MiddleName")
            icbTitle.DataBindings.Add("EditValue", bindingContact.FullName, "Title")
            meLine.DataBindings.Add("Text", bindingContact.Address, "AddressLine")
            cbeState.DataBindings.Add("Text", bindingContact.Address, "State")
            cbeCity.DataBindings.Add("Text", bindingContact.Address, "City")
            teZip.DataBindings.Add("Text", bindingContact.Address, "Zip")
            teEmail.DataBindings.Add("Text", bindingContact, "Email")
            tePhone.DataBindings.Add("Text", bindingContact, "Phone")
            deBirthDate.DataBindings.Add("DateTime", bindingContact, "BindingBirthDate")
            memoEdit1.DataBindings.Add("Text", bindingContact, "Note")
            UpdateCaption()
            InitValidationProvider()
        End Sub

        Private Sub InitValidationProvider()
            dxValidationProvider1.SetValidationRule(teFirstName, ValidationRulesHelper.RuleIsNotBlank)
            dxValidationProvider1.SetValidationRule(teLastName, ValidationRulesHelper.RuleIsNotBlank)
        End Sub
        Private Sub UpdateCaption()
            Text = bindingContact.Name
        End Sub
        Private Sub InitMenuManager(ByVal menuManager As IDXMenuManager)
            For Each ctrl As Control In lcMain.Controls
                Dim edit As BaseEdit = TryCast(ctrl, BaseEdit)
                If edit IsNot Nothing Then
                    edit.MenuManager = menuManager
                End If
            Next ctrl
        End Sub
        Private Sub InitEditors()
            EditorHelper.InitTitleComboBox(icbTitle.Properties)
            cbeCity.Properties.Items.AddRange(EditorHelper.GetCities())
            cbeState.Properties.Items.AddRange(EditorHelper.GetStates())
        End Sub
        Private Sub sbOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sbOK.Click
            bindingContact.Photo = pePhoto.Image
            contact.Assign(bindingContact)
        End Sub

    End Class
End Namespace
