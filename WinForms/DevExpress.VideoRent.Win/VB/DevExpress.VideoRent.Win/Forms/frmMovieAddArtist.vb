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
Imports DevExpress.VideoRent.Helpers

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieAddArtist
		Inherits frmAddBase
		Private movie As Movie
        Private fneedUpdateArtistsList As Boolean = False
        Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal movie As Movie, ByVal manager As IDXMenuManager)
            MyBase.New(parent, session, Nothing, manager)
            InitializeComponent()
            Me.movie = movie
            Text = String.Format(ConstStrings.AddArtistTo, movie.Title)
        End Sub
        Public ReadOnly Property MovieArtist() As MovieArtist
            Get
                Return TryCast(editObject, MovieArtist)
            End Get
        End Property
        Public ReadOnly Property NeedUpdateArtistsList() As Boolean
            Get
                Return fneedUpdateArtistsList
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
            ValidationProvider.SetValidationRule(lueArtist, ValidationRulesHelper.RuleIsNotBlank)
            ValidationProvider.SetValidationRule(lueLine, ValidationRulesHelper.RuleIsNotBlank)
        End Sub
        Private Sub InitEditors()
            EditorHelper.CreateArtistGridLookUpEdit(Session, lueArtist.Properties, Nothing)
            EditorHelper.CreateMovieArtistLineLookUpEdit(Session, lueLine.Properties, Nothing)
        End Sub
        Protected Overrides Sub SaveData()
            MyBase.SaveData()
            MovieArtist.Movie = movie
            MovieArtist.Artist = CType(lueArtist.EditValue, Artist)
            MovieArtist.Line = CType(lueLine.EditValue, MovieArtistLine)
            MovieArtist.Description = meDescription.Text
        End Sub
        Private Sub CloseArtistDetailForm(ByVal result As DialogResult, ByVal currentObject As Object)
            EditorHelper.CreateArtistGridLookUpEdit(Session, lueArtist.Properties, Nothing)
            lueArtist.EditValue = SessionHelper.GetObject(Of Artist)(CType(currentObject, Artist), Session)
            lueArtist.Refresh()
            fneedUpdateArtistsList = True
        End Sub
		Private Sub lueArtist_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lueArtist.ButtonClick
			If e.Button.Index <> 1 Then
				Return
			End If
			Using form As New frmArtistDetail(Me.FindForm(), Session, Nothing, lcMain.MenuManager, AddressOf CloseArtistDetailForm)
				form.ShowDialog()
			End Using
		End Sub
	End Class
End Namespace
