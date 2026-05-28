Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports DevExpress.XtraBars.Docking
Imports DevExpress.VideoRent.Win.Forms

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucScreens
		Inherits XtraUserControl
		Private pictures As XPCollection(Of MoviePicture)
		Private _parent As DockPanel
		Private currentMovie As Movie
		Private _parentForm As Form
		Public Sub New()
			InitializeComponent()
			bbiAdd.Glyph = ElementHelper.BarImages.Images(0)
			bbiDelete.Glyph = ElementHelper.BarImages.Images(2)
		End Sub
		Public Sub InitParent(ByVal panel As DockPanel)
			Me._parent = panel
			AddHandler _parent.DockChanged, AddressOf parent_DockChanged
		End Sub
		Public ReadOnly Property LayoutManager() As FormLayoutManager
			Get
				If TypeOf _parentForm Is frmMain Then
					Return (CType(_parentForm, frmMain)).LayoutManager
				End If
				Return Nothing
			End Get
		End Property
		Private Sub parent_DockChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (_parent.Dock = DockingStyle.Left OrElse Object.Equals(_parent.Dock, DockingStyle.Right)) Then
				layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Column
			Else
				layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row
			End If
		End Sub
		Private ReadOnly Property CurrentMoviePicture() As MoviePicture
			Get
				Return TryCast(layoutView1.GetRow(layoutView1.FocusedRowHandle), MoviePicture)
			End Get
		End Property
		Public Sub InitData(ByVal pictures As XPCollection(Of MoviePicture), ByVal movie As Movie, ByVal parentForm As Form)
			Me.pictures = pictures
			Me.currentMovie = movie
			Me._parentForm = parentForm
			UpdateCaption()
			gridControl1.DataSource = pictures
			ShowFocusRect()
			InitButtons()
		End Sub

		Private Sub UpdateCaption()
			If Object.Equals(pictures, Nothing) Then
				_parent.Text = ConstStrings.Screens
			Else
				_parent.Text = String.Format("{0} ({1})", ConstStrings.Screens, pictures.Count)
			End If
		End Sub

		Private Sub layoutView1_FocusedRowChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles layoutView1.FocusedRowChanged
			InitButtons()
		End Sub

	   Private Sub InitButtons()
		   bbiDelete.Enabled = Not Object.Equals(CurrentMoviePicture, Nothing)
		   bbiAdd.Enabled = Not Object.Equals(currentMovie, Nothing)
	   End Sub
		Private Sub AddNewScreen(ByVal image As Image)
			If Object.Equals(currentMovie, Nothing) Then
				Return
			End If
			Dim moviePicture As New MoviePicture(currentMovie.Session)
			moviePicture.Image = image
			moviePicture.Movie = currentMovie
			WinHelper.GridViewFocusObject(layoutView1, moviePicture)
			ShowFocusRect()
		End Sub
		Private Sub bbiAdd_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiAdd.ItemClick
			LayoutManager.ShowOpenImageDialog(New frmOpenImageDialog.SetImageDelegate(AddressOf AddNewScreen), _parentForm)
		End Sub

		Private Sub bbiDelete_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles bbiDelete.ItemClick
            If (Not Object.Equals(CurrentMoviePicture, Nothing)) AndAlso XtraMessageBox.Show(Me.FindForm(), String.Format(ConstStrings.DeleteRecord, ConstStrings.Photo), ConstStrings.Question, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Cursor.Current = Cursors.WaitCursor
                If ObjectHelper.SafeDelete(Me.FindForm(), CurrentMoviePicture, True) Then
                    UpdateCaption()
                    ShowFocusRect()
                End If
                Cursor.Current = Cursors.Default
            End If
		End Sub
		Private Sub ShowFocusRect()
			If (Not Object.Equals(CurrentMoviePicture, Nothing)) Then
				layoutView1.FocusedColumn = lvcImage
			End If
		End Sub
	End Class
End Namespace
