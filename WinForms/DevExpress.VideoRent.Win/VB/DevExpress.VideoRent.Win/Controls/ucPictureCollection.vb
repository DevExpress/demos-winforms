Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Controls
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucPictureCollection
		Inherits XtraUserControl
		Implements IXtraResizableControl
		Public Delegate Sub RefreshButtons()
		Private collection As XPCollection(Of ArtistPicture)
		Private layoutManager As FormLayoutManager
		Private session As UnitOfWork
		Private currentArtist As Artist
        Private _RefreshButtons As RefreshButtons
        Private fcurrentRecord As Integer = -2
        Public Sub New()
            InitializeComponent()
            bbiAdd.Glyph = ElementHelper.BarImages.Images(0)
            bbiDelete.Glyph = ElementHelper.BarImages.Images(2)
            bbiPrev.Glyph = ElementHelper.BarImages.Images(6)
            bbiNext.Glyph = ElementHelper.BarImages.Images(7)
            peImage.Properties.NullText = ConstStrings.NoImageData
        End Sub
        Private ReadOnly Property CurrentEditObject() As ArtistPicture
            Get
                If fcurrentRecord < 0 Then
                    Return Nothing
                End If
                Return collection(fcurrentRecord)
            End Get
        End Property
        Private Property CurrentRecord() As Integer
            Get
                Return fcurrentRecord
            End Get
            Set(ByVal value As Integer)
                If value > collection.Count - 1 Then
                    value = collection.Count - 1
                End If
                If collection.Count > 0 AndAlso value < 0 Then
                    value = 0
                End If
                If fcurrentRecord = value Then
                    Return
                End If
                fcurrentRecord = value
                RefreshImage()
            End Set
        End Property
		Public ReadOnly Property DeleteButtonEnabled() As Boolean
			Get
				Return CurrentRecord >= 0
			End Get
		End Property
		Private Sub RefreshImage()
			If CurrentRecord >= 0 Then
				peImage.Image = collection(CurrentRecord).Image
			Else
				peImage.Image = Nothing
			End If
			bsiRecords.Caption = String.Format(ConstStrings.PhotoOf, CurrentRecord + 1, collection.Count)
			bbiPrev.Enabled = CurrentRecord > 0
			bbiNext.Enabled = CurrentRecord >= 0 AndAlso CurrentRecord < collection.Count - 1
			bbiDelete.Enabled = DeleteButtonEnabled
            If (Not Object.Equals(_RefreshButtons, Nothing)) Then
                _RefreshButtons()
            End If
		End Sub
		#Region "IXtraResizableControl Members"

        Public Event Changed As EventHandler
		Protected Overridable Sub RaiseChanged()
            RaiseEvent Changed(Me, EventArgs.Empty)
		End Sub
        Public ReadOnly Property IsCaptionVisible() As Boolean
            Get
                Return False
			End Get
		End Property
        Public ReadOnly Property MaxSize() As Size
            Get
                Return New Size(600, 1000)
            End Get
        End Property
        Public ReadOnly Property MinSize() As Size
            Get
                Return New Size(200, 200)
            End Get
        End Property

		#End Region

		Public Sub Init(ByVal artist As Artist, ByVal session As UnitOfWork, ByVal manager As FormLayoutManager, ByVal refreshButtons As RefreshButtons)
			Me.currentArtist = artist
			Me.collection = artist.Pictures
			Me.session = session
			Me.layoutManager = manager
            Me._RefreshButtons = refreshButtons
			If collection.Count > 0 Then
				CurrentRecord = 0
			Else
				CurrentRecord = -1
			End If
		End Sub

		Private Sub bbiPrev_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiPrev.ItemClick
			CurrentRecord -= 1
		End Sub

		Private Sub bbiNext_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiNext.ItemClick
			CurrentRecord += 1
		End Sub
		Private Sub AddNewPhoto(ByVal image As Image)
			currentArtist.AddPicture(image)
			CurrentRecord = collection.Count - 1
		End Sub
		Public Sub AddPicture()
			layoutManager.ShowOpenImageDialog(New DevExpress.VideoRent.Win.Forms.frmOpenImageDialog.SetImageDelegate(AddressOf AddNewPhoto), Me.FindForm())
		End Sub
		Public Sub DeletePicture()
            If (Not Object.Equals(CurrentEditObject, Nothing)) AndAlso XtraMessageBox.Show(Me.FindForm(), String.Format(ConstStrings.DeleteRecord, ConstStrings.Photo), ConstStrings.Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                If ObjectHelper.SafeDelete(Me.FindForm(), CurrentEditObject, False) Then
                    If CurrentRecord = 0 Then
                        CurrentRecord = -1
                    Else
                        CurrentRecord = CurrentRecord - 1
                    End If
                    RefreshImage()
                End If
            End If
		End Sub
		Private Sub bbiAdd_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
			AddPicture()
		End Sub

		Private Sub bbiDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
			DeletePicture()
		End Sub
	End Class
End Namespace
