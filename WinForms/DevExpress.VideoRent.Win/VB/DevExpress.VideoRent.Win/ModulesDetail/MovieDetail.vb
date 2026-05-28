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
Imports System.Diagnostics
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.VideoRent.Win.Controls
Imports DevExpress.Utils
Imports DevExpress.VideoRent.Win.Forms

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class MovieDetail
		Inherits DetailBase
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal movie As Movie, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
			MyBase.New(parent, session, movie, manager, closeForm)
			InitializeComponent()
			If (Not Object.Equals(movie, Nothing)) Then
				Text =movie.Title
			Else
				Text =ConstStrings.NewMovie
			End If
		End Sub
		Protected Overrides ReadOnly Property HomeButtonCaption() As String
			Get
				Return ConstStrings.MovieList
			End Get
		End Property
		Public ReadOnly Property Movie() As Movie
			Get
				Return TryCast(editObject, Movie)
			End Get
		End Property
		Protected Overrides Sub InitData()
			MyBase.InitData()
			InitEditors()
			If Object.Equals(Movie, Nothing) Then
				Return
			End If
			If (Not Object.Equals(Movie.ReleaseDate, Nothing)) Then
				deReleaseDate.DateTime = Movie.ReleaseDate.Value
			End If
			ccbGenre.SetEditValue(Movie.Genre)
			icbRating.EditValue = Movie.Rating
			If Movie.RunTime.HasValue Then
				teRunTime.Time = New DateTime(Movie.RunTime.Value.Ticks)
			Else
				teRunTime.Time = New DateTime(0)
			End If
			ceIsColor.Checked = Movie.IsColor
			pePhoto.Image = Movie.Photo
			meTagline.Text = Movie.Tagline
			mePlot.Text = Movie.Plot
			teWebSite.Text = Movie.WebSite
			teAwards.Text = Movie.Awards
			teAspectRatio.Text = Movie.AspectRatio
			ccbCountries.SetEditValue(Movie.CountriesAsString)
			lueLanguage.EditValue = Movie.Language
			teTitle.Text = Movie.Title
			teDirectors.Text = Movie.Directors
			InitArtistGrid()
			InitCompanyGrid()
			lueCategory.EditValue = Movie.Category
			ucMovieFormatsInfo.Init(Movie.Category, Movie.Items, lcMain.MenuManager)
			ucPictureEditBar1.Init(pePhoto, LayoutManager)
		End Sub
		Protected Overrides Sub UpdateReadOnlyData()
			MyBase.UpdateReadOnlyData()
			lueCategory.Properties.Buttons(1).Enabled = Not [ReadOnly]
			If [ReadOnly] Then
				lciBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
			Else
				lciBar.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
			End If
		End Sub
		Private Sub InitEditors()
			ccbGenre.Properties.SetFlags(GetType(MovieGenre))
			EditorHelper.CreateRatingImageComboBox(icbRating.Properties, Nothing)
			EditorHelper.CreateLanguageLookUpEdit(Session, lueLanguage.Properties, Nothing)
			EditorHelper.CreateMovieCountriesCheckedComboBox(Session, ccbCountries.Properties)
			EditorHelper.CreateMovieCategoryLookUpEdit(Session, lueCategory.Properties, Nothing)
			pePhoto.Properties.NullText = ConstStrings.NoImageData
		End Sub
		Private Sub InitCompanyGrid()
			colCompany.ColumnEdit = EditorHelper.CreateCompanyLookUpEdit(Session, gcCompanies.RepositoryItems)
			gcCompanies.DataSource = Movie.Companies
			ucGridEditBarCompanies.Init(gvCompanies)
		End Sub
		Private Sub InitArtistGrid()
			colArtist.ColumnEdit = EditorHelper.CreateArtistGridLookUpEdit(Session, gcArtists.RepositoryItems)
			colLine.ColumnEdit = EditorHelper.CreateMovieArtistLineLookUpEdit(Session, gcArtists.RepositoryItems)
			Movie.Artists.Sorting.AddRange(New SortProperty() { New SortProperty("[Line.Name]", SortingDirection.Ascending), New SortProperty("[Artist.FullName]", SortingDirection.Ascending)})
			gcArtists.DataSource = Movie.Artists
			ucGridEditBarArtist.Init(gvArtist)
		End Sub
		Protected Overrides Sub InitValidation()
			ValidationProvider.SetValidationRule(teTitle, ValidationRulesHelper.RuleIsNotBlank)
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()

			gvArtist.CloseEditor()
			gvCompanies.CloseEditor()

			Movie.Title = teTitle.Text.Replace(Constants.vbCrLf, " ")
			Movie.Language = CType(lueLanguage.EditValue, Language)
			Movie.AspectRatio = teAspectRatio.Text
			Movie.Awards = teAwards.Text
			Movie.WebSite = teWebSite.Text
			Movie.Tagline = meTagline.Text
			Movie.Plot = mePlot.Text
			Movie.Photo = pePhoto.Image
			Movie.IsColor = ceIsColor.Checked
			Movie.RunTime = teRunTime.Time.TimeOfDay
			Movie.CountriesAsString = String.Format("{0}", ccbCountries.EditValue)
			If Movie.RunTime.Value.Ticks = 0 Then
				Movie.RunTime = Nothing
			End If
			Movie.Rating = CType(icbRating.EditValue, MovieRating)
			Movie.Genre = CType(ccbGenre.EditValue, MovieGenre)
			Movie.ReleaseDate = deReleaseDate.DateTime.Date
            If Object.Equals(Movie.ReleaseDate, DateTime.MinValue) Then
                Movie.ReleaseDate = Nothing
            End If
			Movie.Category = CType(lueCategory.EditValue, MovieCategory)
			CommitSession()
		End Sub
		Protected Overrides Function CreateNewObject() As VideoRentBaseObject
			MyBase.CreateNewObject()
			Return New Movie(Session, "New film")
		End Function
		Private Sub gvArtist_ValidateRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs) Handles gvArtist.ValidateRow
			CheckDirectors()
		End Sub
		Public Sub CheckDirectors()
			teDirectors.Text = String.Empty
			Dim directorLine As MovieArtistLine = MovieArtistLine.GetDirector(Session)
			If Object.Equals(directorLine, Nothing) Then
				Return
			End If
			Dim directors As New XPCollection(Of MovieArtist)(Session, False)
			For rowIndex As Integer = 0 To gvArtist.RowCount - 1
				Dim movieArtist As MovieArtist = TryCast(gvArtist.GetRow(rowIndex), MovieArtist)
                If Not movieArtist.Line.Equals(directorLine) Then
                    Continue For
                End If
				directors.Add(movieArtist)
			Next rowIndex
			directors.Sorting.Add(New SortProperty("[Artist.FullName]", SortingDirection.Ascending))
			For Each director As MovieArtist In directors
				teDirectors.Text &= ", " & director.Artist.FullName
			Next director
			If teDirectors.Text.Length <> 0 Then
				teDirectors.Text = teDirectors.Text.Remove(0, 2)
			End If
		End Sub
		Private Sub gvArtist_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gvArtist.CustomDrawCell
			If e.Column IsNot colArtist Then
				Return
			End If
			Dim mArtist As MovieArtist = TryCast(gvArtist.GetRow(e.RowHandle), MovieArtist)
			If Object.Equals(mArtist, Nothing) OrElse Object.Equals(mArtist.Line, Nothing) OrElse String.Format("{0}", mArtist.Line.Name).IndexOf(ReferenceData.DirectorString) <> 0 Then
				Return
			End If
			e.Appearance.Font = ElementHelper.FontBold
		End Sub
		Private Sub teWebSite_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles teWebSite.ButtonClick
			ObjectHelper.ShowWebSite(teWebSite.Text)
		End Sub
		Private Sub ucGridEditBarCompanies_AddRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBarCompanies.AddRecord
			Using form As New frmMovieAddCompany(FindForm(), Session, Movie, lcMain.MenuManager)
				If form.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				WinHelper.GridViewFocusObject(gvCompanies, form.MovieCompany)
			End Using
		End Sub
		Private ReadOnly Property CurrentMovieCompany() As MovieCompany
			Get
				Return TryCast(gvCompanies.GetRow(gvCompanies.FocusedRowHandle), MovieCompany)
			End Get
		End Property
		Private Sub ucGridEditBarCompanies_DeleteRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBarCompanies.DeleteRecord
			If (Not Object.Equals(CurrentMovieCompany, Nothing)) Then
				gvCompanies.HideEditor()
				gvCompanies.UpdateCurrentRow()
				ObjectHelper.SafeDelete(Me.FindForm(), CurrentMovieCompany, False)
			End If
		End Sub
		Private Sub ucGridEditBarArtist_AddRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBarArtist.AddRecord
			Using form As New frmMovieAddArtist(FindForm(), Session, Movie, lcMain.MenuManager)
				If form.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				If form.NeedUpdateArtistsList Then
					InitArtistGrid()
				End If
				WinHelper.GridViewFocusObject(gvArtist, form.MovieArtist)
				CheckDirectors()
			End Using
		End Sub
		Private ReadOnly Property CurrentMovieArtist() As MovieArtist
			Get
				Return TryCast(gvArtist.GetRow(gvArtist.FocusedRowHandle), MovieArtist)
			End Get
		End Property
		Private Sub ucGridEditBarArtist_DeleteRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBarArtist.DeleteRecord
			If (Not Object.Equals(CurrentMovieArtist, Nothing)) Then
				gvArtist.HideEditor()
				gvArtist.UpdateCurrentRow()
				If ObjectHelper.SafeDelete(Me.FindForm(), CurrentMovieArtist, False) Then
					CheckDirectors()
				End If
			End If
		End Sub
		Private Sub lueCategory_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles lueCategory.ButtonClick
			If e.Button.Index <> 1 Then
				Return
			End If
			Using form As New frmNewMovieCategory(Me.FindForm(), CType(lueCategory.Properties.DataSource, XPCollection(Of MovieCategory)), lcMain.MenuManager)
				form.ShowDialog(Me)
				If form.DialogResult = DialogResult.OK Then
					lueCategory.EditValue = form.MovieCategory
					ucMovieFormatsInfo.Init(form.MovieCategory, Movie.Items, lcMain.MenuManager)
				End If
			End Using
		End Sub
		Protected Friend Overrides Sub MovieAddItem()
			lcMain.FocusHelper.PlaceItemIntoView(lciFormatsInfo)
			MyBase.MovieAddItem()
			Using form As New frmMovieAddItems(Me.FindForm(), Session, Movie, lcMain.MenuManager)
				form.ShowDialog()
				If form.DialogResult = DialogResult.OK Then
					If (Not Object.Equals(form.MovieItems, Nothing)) AndAlso form.MovieItems.Count <> 0 Then
						Movie.Items.AddRange(form.MovieItems)
						UpdateActiveRibbonPageCaption()
					End If
					ucMovieFormatsInfo.Init(CType(lueCategory.EditValue, MovieCategory), Movie.Items, lcMain.MenuManager)
				End If
			End Using
		End Sub
		Protected Friend Overrides Sub MovieManageItems()
			lcMain.FocusHelper.PlaceItemIntoView(lciFormatsInfo)
			MyBase.MovieManageItems()
			Using form As New frmMovieItems(Session, Movie, lcMain.MenuManager)
				ObjectHelper.SetFormContainerSize(form, (CType(FindForm(), frmMain)).ChildContainer)
				ObjectHelper.ShowFormDialog(form, Me.FindForm())
				ucMovieFormatsInfo.Init(CType(lueCategory.EditValue, MovieCategory), Movie.Items, lcMain.MenuManager)
				UpdateActiveRibbonPageCaption()
			End Using
		End Sub
		Private Sub lueCategory_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lueCategory.EditValueChanged
			ucMovieFormatsInfo.Init(CType(lueCategory.EditValue, MovieCategory), Movie.Items, lcMain.MenuManager)
		End Sub
		Protected Friend Overrides Sub LoadPicture()
			MyBase.LoadPicture()
			ucPictureEditBar1.LoadPicture()
		End Sub
		Protected Friend Overrides Sub ClearPicture()
			MyBase.ClearPicture()
			ucPictureEditBar1.ClearPicture()
		End Sub
		Public Function GetTitleEditor() As MemoEdit
			Return teTitle
		End Function
		Public Function GetPhotoEditor() As PictureEdit
			Return pePhoto
		End Function
		Public Function GetRealiseDateEditor() As DateEdit
			Return deReleaseDate
		End Function
		Public Function GetRatingEditor() As ImageComboBoxEdit
			Return icbRating
		End Function
		Public Function GetGenreEditor() As CheckedComboBoxEdit
			Return ccbGenre
		End Function
		Public Function GetPlotEditor() As MemoEdit
			Return mePlot
		End Function
		Public Function GetTaglineEditor() As MemoEdit
			Return meTagline
		End Function
		Public Function GetAwardsEditor() As TextEdit
			Return teAwards
		End Function
		Public Function GetDirectorsEditor() As TextEdit
			Return teDirectors
		End Function
		Public Function GetArtistsEditor() As XtraGrid.GridControl
			Return gcArtists
		End Function
		Public Function GetArtistsEditorView() As XtraGrid.Views.Grid.GridView
			Return gvArtist
		End Function
		Public Function GetAspectRatioEditor() As TextEdit
			Return teAspectRatio
		End Function
		Public Function GetRunTimeEditor() As TimeEdit
			Return teRunTime
		End Function
		Public Function GetCountriesEditor() As CheckedComboBoxEdit
			Return ccbCountries
		End Function
		Public Function GetLanguageEditor() As LookUpEdit
			Return lueLanguage
		End Function
		Public Function GetWebSiteEditor() As TextEdit
			Return teWebSite
		End Function
		Public Function GetColorEditor() As CheckEdit
			Return ceIsColor
		End Function
		Public Function GetCompaniesEditor() As XtraGrid.GridControl
			Return gcCompanies
		End Function
		Public Function GetCompaniesEditorView() As XtraGrid.Views.Grid.GridView
			Return gvCompanies
		End Function
	End Class
End Namespace
