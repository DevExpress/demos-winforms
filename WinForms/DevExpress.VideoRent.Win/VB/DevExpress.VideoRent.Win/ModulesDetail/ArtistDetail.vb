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
Imports DevExpress.Utils.Menu
Imports DevExpress.Xpo.DB
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraEditors.DXErrorProvider

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class ArtistDetail
		Inherits DetailBase
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal artist As Artist, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
			MyBase.New(parent, session, artist, manager, closeForm)
			InitializeComponent()
			If (Not Object.Equals(artist, Nothing)) Then
				Text =artist.FullName
			Else
				Text =ConstStrings.NewActor
			End If
		End Sub
		Protected Overrides ReadOnly Property HomeButtonCaption() As String
			Get
				Return ConstStrings.ArtistList
			End Get
		End Property
		Public ReadOnly Property Artist() As Artist
			Get
				Return TryCast(editObject, Artist)
			End Get
		End Property
		Protected Overrides Sub InitData()
			MyBase.InitData()
			InitEditors()
			If Object.Equals(Artist, Nothing) Then
				Return
			End If
			teFirstName.Text = Artist.FirstName
			teLastName.Text = Artist.LastName
			cbeGender.EditValue = Artist.Gender
			teNickName.Text = Artist.NickName
			teBirthName.Text = Artist.BirthName
			If (Not Object.Equals(Artist.BirthDate, Nothing)) Then
				deBirthDate.DateTime = Artist.BirthDate.Value
			End If
			EditorHelper.CreateCountryLookUpEdit(Session, lueBirthCountry.Properties, Nothing)
			lueBirthCountry.EditValue = Artist.BirthCountry
			teBirthLocation.Text = Artist.BirthLocation
			meBiography.Text = Artist.Biography
			teLink.Text = Artist.Link
			ucPictureCollection1.Init(Artist, Session, LayoutManager, AddressOf InitDeleteButtonEnabled)
			InitMovies()
			InitDeleteButtonEnabled()
		End Sub
		Protected Overrides Function ValidateData() As Boolean
			Dim rule As ValidationRule = Nothing
			If String.IsNullOrEmpty(teFirstName.Text) AndAlso String.IsNullOrEmpty(teLastName.Text) Then
				rule = ValidationRulesHelper.RuleIsNotBlank
			End If
			ValidationProvider.SetValidationRule(teFirstName, rule)
			ValidationProvider.SetValidationRule(teLastName, rule)
			Return MyBase.ValidateData()
		End Function
		'protected override void InitValidation() {
		'    //ValidationProvider.SetValidationRule(
		'    //ValidationProvider.SetValidationRule(teFirstName, ValidationRulesHelper.RuleIsNotBlank);
		'    //ValidationProvider.SetValidationRule(teLastName, ValidationRulesHelper.RuleIsNotBlank);
		'}
		Private Sub InitEditors()
			EditorHelper.CreateGenderImageComboBox(cbeGender.Properties, Nothing)
		End Sub
		Private Sub InitMovies()
			colMovie.ColumnEdit = EditorHelper.CreateMovieGridLookUpEdit(Session, gcMovies.RepositoryItems)
			colLine.ColumnEdit = EditorHelper.CreateMovieArtistLineLookUpEdit(Session, gcMovies.RepositoryItems)
			Artist.Movies.Sorting.AddRange(New SortProperty() { New SortProperty("[Line.Name]", SortingDirection.Ascending), New SortProperty("[Movie.Title]", SortingDirection.Ascending)})
			gcMovies.DataSource = Artist.Movies
			ucGridEditBarMovies.Init(gvMovies)
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()

			gvMovies.CloseEditor()

			Artist.Link = teLink.Text
			Artist.Biography = meBiography.Text
			Artist.BirthLocation = teBirthLocation.Text
			Artist.BirthCountry = CType(lueBirthCountry.EditValue, Country)
			Artist.BirthDate = deBirthDate.DateTime
            If Object.Equals(Artist.BirthDate, DateTime.MinValue) Then
                Artist.BirthDate = Nothing
            End If
			Artist.BirthName = teBirthName.Text
			Artist.NickName = teNickName.Text
			Artist.Gender = CType(cbeGender.EditValue, PersonGender)
			Artist.LastName = teLastName.Text
			Artist.FirstName = teFirstName.Text
			CommitSession()
		End Sub
		Protected Overrides Function CreateNewObject() As VideoRentBaseObject
			MyBase.CreateNewObject()
			Return New Artist(Session)
		End Function
		Private ReadOnly Property CurrentMovieArtist() As MovieArtist
			Get
				Return TryCast(gvMovies.GetRow(gvMovies.FocusedRowHandle), MovieArtist)
			End Get
		End Property
		Private Sub ucGridEditBarMovies_AddRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBarMovies.AddRecord
			Using form As New frmArtistAddMovie(FindForm(), Session, Artist, lcMain.MenuManager)
				If form.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				WinHelper.GridViewFocusObject(gvMovies, form.MovieArtist)
			End Using
		End Sub

		Private Sub ucGridEditBarMovies_DeleteRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBarMovies.DeleteRecord
			If (Not Object.Equals(CurrentMovieArtist, Nothing)) Then
				gvMovies.HideEditor()
				gvMovies.UpdateCurrentRow()
				ObjectHelper.SafeDelete(Me.FindForm(), CurrentMovieArtist, False)
			End If
		End Sub
		Private Sub teLink_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teLink.ButtonClick
			Dim link As String = (CType(sender, TextEdit)).Text
			If String.IsNullOrEmpty(link) Then
				link = "http://www.imdb.com/find?s=nm&q=" & Artist.FirstName & "+" & Artist.LastName
			End If
			ObjectHelper.ShowWebSite(link)
		End Sub
		Protected Friend Overrides Sub AddPicture()
			ucPictureCollection1.AddPicture()
			InitDeleteButtonEnabled()
		End Sub
		Protected Friend Overrides Sub DeletePicture()
			ucPictureCollection1.DeletePicture()
			InitDeleteButtonEnabled()
		End Sub
		Private Sub InitDeleteButtonEnabled()
			If (Not Object.Equals(ParentFormMain, Nothing)) Then
				ParentFormMain.DeletePictureButton.Enabled = ucPictureCollection1.DeleteButtonEnabled
			End If
		End Sub
#If DebugTest Then
		Public Function GetFirstNameEditor() As TextEdit
			Return teFirstName
		End Function
		Public Function GetLastNameEditor() As TextEdit
			Return teLastName
		End Function
#End If
	End Class
End Namespace
