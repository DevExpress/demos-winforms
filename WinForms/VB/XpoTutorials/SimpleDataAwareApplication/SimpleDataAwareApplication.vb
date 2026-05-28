Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Xpo

Namespace DevExpress.Xpo.Demos
    Partial Public Class SimpleDataAwareApplication
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
        Private Sub SimpleDataAwareApplication_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' If the 'Customer' table is empty, adds new records and reloads the xpCustomers collection.
            If xpCustomers.Count = 0 Then
                CreateCustomers()
                xpCustomers.Reload()
            End If
        End Sub

        Public Overrides Sub ReloadData()
            xpCustomers.Reload()
        End Sub
    End Class
End Namespace
