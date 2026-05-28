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
Imports DevExpress.VideoRent.Win.Forms

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucPictureEditBar
		Inherits XtraUserControl
		Implements IXtraResizableControl
		Private edit As PictureEdit
		Private layoutManager As FormLayoutManager
		Public Sub New()
			InitializeComponent()
			bbiLoad.Glyph = ElementHelper.BarImages.Images(4)
			bbiClear.Glyph = ElementHelper.BarImages.Images(2)
		End Sub
		Public Sub Init(ByVal edit As PictureEdit, ByVal layoutManager As FormLayoutManager)
			Me.edit = edit
			Me.layoutManager = layoutManager
		End Sub
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			RaiseChanged()
		End Sub
		Private Sub LoadPicture(ByVal image As Image)
			edit.Image = image
		End Sub
		Public Sub LoadPicture()
			layoutManager.ShowOpenImageDialog(New frmOpenImageDialog.SetImageDelegate(AddressOf LoadPicture), Me.FindForm())
		End Sub
		Public Sub ClearPicture()
			edit.Image = Nothing
		End Sub
		Private Sub bbiLoad_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiLoad.ItemClick
			LoadPicture()
		End Sub
		Private Sub bbiClear_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiClear.ItemClick
			ClearPicture()
		End Sub
		#Region "IXtraResizableControl Members"
        Public Event Changed As EventHandler
		Protected Overridable Sub RaiseChanged()
			If (Not Object.Equals(ChangedEvent, Nothing)) Then
                RaiseEvent Changed(Me, EventArgs.Empty)
			End If
		End Sub
        Public ReadOnly Property IsCaptionVisible() As Boolean
            Get
                Return False
            End Get
        End Property
        Public ReadOnly Property MaxSize() As Size
            Get
                Return New Size(3000, ControlHeight)
            End Get
        End Property
        Public ReadOnly Property MinSize() As Size
            Get
                Return New Size(170, ControlHeight)
            End Get
        End Property
		Private ReadOnly Property ControlHeight() As Integer
			Get
				If Object.Equals(mainBar, Nothing) OrElse mainBar.Size.IsEmpty OrElse mainBar.Size.Height = 0 Then
					Return 25
				End If
				Return mainBar.Size.Height
			End Get
		End Property
		#End Region
	End Class
End Namespace
