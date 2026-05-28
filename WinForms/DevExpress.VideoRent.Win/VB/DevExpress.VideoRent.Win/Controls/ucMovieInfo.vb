Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraLayout.Utils
Imports DevExpress.LookAndFeel

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieInfo
		Inherits XtraUserControl
		Public Event DoEdit As EventHandler
		Private tmr As Timer
		Public Sub New()
			InitializeComponent()
			If (Not Object.Equals(Me.FindForm(), Nothing)) Then
				AddHandler FindForm().SizeChanged, AddressOf ucMovieInfo_SizeChanged
			End If
		End Sub
		Private ReadOnly Property PictureTimer() As Timer
			Get
				If Object.Equals(tmr, Nothing) Then
					tmr = New Timer()
					tmr.Interval = 100
					tmr.Enabled = False
					AddHandler tmr.Tick, AddressOf tmr_Tick
				End If
				Return tmr
			End Get
		End Property
		Private Sub tmr_Tick(ByVal sender As Object, ByVal e As EventArgs)
			SizePhoto()
			PictureTimer.Stop()
		End Sub
		Public Sub Init(ByVal movie As Movie)
			If (Not Object.Equals(movie, Nothing)) Then
				pePhoto.Image = movie.Photo
			Else
				pePhoto.Image = Nothing
			End If
			If Object.Equals(movie, Nothing) Then
				lciInfo.Visibility = LayoutVisibility.Never
			Else
				lciInfo.Visibility = LayoutVisibility.Always
			End If
			If (Not Object.Equals(movie, Nothing)) Then
				lcInfo.Text =movie.GetFullMovieInfoHtml()
			Else
				lcInfo.Text =String.Empty
			End If
			SizePhoto()
			Me.Refresh()
		End Sub
		Private lockResize As Boolean = False
		Private Sub SizePhoto()
			If lockResize Then
				Return
			End If
			lockResize = True
			Dim img As Image = pePhoto.Image
			Try
				If Object.Equals(img, Nothing) Then
					lciPhoto.Visibility = LayoutVisibility.Never
					Return
				Else
					lciPhoto.Visibility = LayoutVisibility.Always
				End If
				lciInfo.Width = lcMain.Width - Math.Min(lciPhoto.Height * img.Width \ img.Height, img.Width)
			Finally
				lockResize = False
			End Try
		End Sub
		Private Sub pePhoto_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles pePhoto.Resize
            PictureTimer.Start()
		End Sub
		Private Sub ucMovieInfo_SizeChanged(ByVal sender As Object, ByVal e As EventArgs)
            PictureTimer.Start()
		End Sub
		Private Sub RaiseDoEdit()
			If (Not Object.Equals(DoEditEvent, Nothing)) Then
                RaiseEvent DoEdit(Me, EventArgs.Empty)
			End If
		End Sub
		Private Sub pePhoto_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles pePhoto.DoubleClick
			RaiseDoEdit()
		End Sub

		Private Sub lcInfo_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles lcInfo.DoubleClick
			RaiseDoEdit()
		End Sub
	End Class
End Namespace
