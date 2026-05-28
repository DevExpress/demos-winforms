Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo.DB
Imports DevExpress.Utils.Menu

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmArtistAddMovie
		Inherits frmAddBase
		Private artist As Artist
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal artist As Artist, ByVal manager As IDXMenuManager)
			MyBase.New(parent, session, Nothing, manager)
			InitializeComponent()
			Me.artist = artist
			Text = String.Format(ConstStrings.AddMovieTo, artist.FullName)
		End Sub
		Public ReadOnly Property MovieArtist() As MovieArtist
			Get
				Return TryCast(editObject, MovieArtist)
			End Get
		End Property
		Protected Overrides Sub CreateNewObject()
			MyBase.CreateNewObject()
			editObject = New MovieArtist(Session)
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			InitEditors()
		End Sub
		Protected Overrides Sub InitValidation()
			ValidationProvider.SetValidationRule(lueMovie, ValidationRulesHelper.RuleIsNotBlank)
			ValidationProvider.SetValidationRule(lueLine, ValidationRulesHelper.RuleIsNotBlank)
		End Sub
		Private Sub InitEditors()
			EditorHelper.CreateMovieGridLookUpEdit(Session, lueMovie.Properties, Nothing)
			EditorHelper.CreateMovieArtistLineLookUpEdit(Session, lueLine.Properties, Nothing)
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()
			MovieArtist.Artist = artist
			MovieArtist.Movie = CType(lueMovie.EditValue, Movie)
			MovieArtist.Line = CType(lueLine.EditValue, MovieArtistLine)
			MovieArtist.Description = meDescription.Text
		End Sub
	End Class
End Namespace
