Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms

Namespace DevExpress.Xpo.Demos
    Partial Public Class Validation
        Inherits TutorialControl
        Public Sub New()

            InitializeComponent()
        End Sub
        Public Overrides Property SetNewWhatsThisPadding() As Boolean
            Get
                Return True
            End Get
            Set(ByVal value As Boolean)
                MyBase.SetNewWhatsThisPadding() = value
            End Set
        End Property
        Private Sub Validation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            gridControl1.DataSource = xpContacts
            gridView1.Columns("Oid").Visible = False
        End Sub

        '<sbAddContact>
        Private Sub sbAddContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbAddContact.Click
            Dim theContact As Contact = New Contact(unitOfWork1)
            Dim contactForm As NewContactForm = New NewContactForm(theContact, dxErrorProvider)
            If contactForm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
                unitOfWork1.CommitChanges()
                xpContacts.Add(theContact)
            Else
                unitOfWork1.Delete(theContact)
            End If
        End Sub
        '</sbAddContact>

        '<sbRemoveContact>
        Private Sub sbRemoveContact_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles sbRemoveContact.Click
            If gridView1.FocusedRowHandle < 0 Then
                Return
            End If
            Dim contact As Contact = (CType(xpContacts(gridView1.FocusedRowHandle), Contact))
            unitOfWork1.Delete(contact)
            unitOfWork1.CommitChanges()
        End Sub
        '</sbRemoveContact>

        Private Sub bSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles bSave.Click
            SaveChanges(unitOfWork1)
        End Sub
    End Class
End Namespace
