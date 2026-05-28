Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon

Namespace DevExpress.MailClient.Win.Controls
    Partial Public Class ucContacts
        Inherits BaseControl

        Public Event CheckedChanged As EventHandler
        Private gallery As RibbonGalleryBarItem
        'bool lockItemCheck = false;
        Public Sub New()
            InitializeComponent()
            ceList.Tag = TagResources.ContactList
            ceAlphabetical.Tag = TagResources.ContactAlphabetical
            ceState.Tag = TagResources.ContactByState
            ceCards.Tag = TagResources.ContactCard
        End Sub
        Public Sub SynchronizeGalleryItems(ByVal gallery As RibbonGalleryBarItem)
            Me.gallery = gallery
            SetItemCheck(gallery.Gallery.GetAllItems())
            AddHandler gallery.GalleryItemCheckedChanged, AddressOf gallery_GalleryItemCheckedChanged
        End Sub

        Private Sub gallery_GalleryItemCheckedChanged(ByVal sender As Object, ByVal e As GalleryItemEventArgs)
            If e.Item.Checked Then
                UpdateCheckEditors(e.Item.Tag.ToString())
            End If
        End Sub

        Private Sub UpdateCheckEditors(ByVal checkTag As String)
            For Each control As Control In pcCheckControls.Controls
                Dim edit As CheckEdit = TryCast(control, CheckEdit)
                If edit IsNot Nothing AndAlso edit.Tag.Equals(checkTag) Then
                    edit.Checked = True
                    Exit For
                End If
            Next control
        End Sub

        Private Sub SetItemCheck(ByVal list As List(Of DevExpress.XtraBars.Ribbon.GalleryItem))
            Dim checkTag As String = String.Empty
            For Each control As Control In pcCheckControls.Controls
                Dim edit As CheckEdit = TryCast(control, CheckEdit)
                If edit IsNot Nothing AndAlso edit.Checked Then
                    checkTag = edit.Tag.ToString()
                    Exit For
                End If
            Next control
            For Each item As GalleryItem In list
                If item.Tag.Equals(checkTag) Then
                    item.Checked = True
                End If
            Next item
        End Sub
        Private Sub ce_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ceList.CheckedChanged, ceAlphabetical.CheckedChanged, ceState.CheckedChanged, ceCards.CheckedChanged
            Dim ce As CheckEdit = TryCast(sender, CheckEdit)
            If ce.Checked AndAlso CheckedChangedEvent IsNot Nothing Then
                SetItemCheck(gallery.Gallery.GetAllItems())
                RaiseEvent CheckedChanged(sender, EventArgs.Empty)
            End If
        End Sub

        Private Sub ucContacts_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
            labelControl1.Width = Me.Width
        End Sub
    End Class
End Namespace
