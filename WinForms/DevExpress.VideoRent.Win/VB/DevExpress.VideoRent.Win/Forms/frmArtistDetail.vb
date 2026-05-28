Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.VideoRent.Win.Modules
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmArtistDetail
		Inherits frmDetailBase
		Private artists As ArtistDetail = Nothing
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal artist As Artist, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
			MyBase.New(parent)
			InitializeComponent()
			AddArtistDetail(parent, session, artist, manager, closeForm)
		End Sub

		Private Sub AddArtistDetail(ByVal parent As Form, ByVal session As UnitOfWork, ByVal artist As Artist, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
			artists = New ArtistDetail(parent, session, artist, manager, closeForm)
			artists.Dock = DockStyle.Fill
			Me.Controls.Add(artists)
			artists.BringToFront()
			Text = artists.PageCaption
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()
			If artists.SaveAndClose() Then
				Me.Close()
			End If
		End Sub
	End Class
End Namespace

