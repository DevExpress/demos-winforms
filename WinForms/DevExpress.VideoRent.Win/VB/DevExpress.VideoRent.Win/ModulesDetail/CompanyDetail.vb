Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class CompanyDetail
		Inherits DetailBase
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal company As Company, ByVal manager As IDXMenuManager, ByVal closeForm As CloseDetailForm)
			MyBase.New(parent, session, company, manager, closeForm)
			InitializeComponent()
			If (Not Object.Equals(company, Nothing)) Then
				Text =company.Name
			Else
				Text =ConstStrings.NewCompany
			End If
		End Sub
		Protected Overrides ReadOnly Property HomeButtonCaption() As String
			Get
				Return ConstStrings.CompanyList
			End Get
		End Property
		Public ReadOnly Property Company() As Company
			Get
				Return TryCast(editObject, Company)
			End Get
		End Property
		Protected Overrides Sub InitData()
			MyBase.InitData()
			InitEditors()
			If Object.Equals(Company, Nothing) Then
				Return
			End If
			teName.Text = Company.Name
			lueType.EditValue = Company.Type
			beWebSite.Text = Company.WebSite
			lueCountry.EditValue = Company.Country
			InitMoviesGrid()
		End Sub
		Private Sub InitEditors()
			EditorHelper.CreateCompanyTypeLookUpEdit(Session, lueType.Properties, Nothing)
			EditorHelper.CreateCountryLookUpEdit(Session, lueCountry.Properties, Nothing)
		End Sub
		Private Sub InitMoviesGrid()
			colMovie.ColumnEdit = EditorHelper.CreateMovieGridLookUpEdit(Session, gcMovies.RepositoryItems)
			gcMovies.DataSource = Company.Movies
			ucGridEditBar.Init(gvMovies)
		End Sub
		Protected Overrides Sub InitValidation()
			ValidationProvider.SetValidationRule(teName, ValidationRulesHelper.RuleIsNotBlank)
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()
			Company.Name = teName.Text
			Company.Type = CType(lueType.EditValue, CompanyType)
			Company.WebSite = beWebSite.Text
			Company.Country = CType(lueCountry.EditValue, Country)
			CommitSession()
		End Sub
		Protected Overrides Function CreateNewObject() As VideoRentBaseObject
			MyBase.CreateNewObject()
			Return New Company(Session, ConstStrings.NewCompany)
		End Function
		Private ReadOnly Property CurrentMovieCompany() As MovieCompany
			Get
				Return TryCast(gvMovies.GetRow(gvMovies.FocusedRowHandle), MovieCompany)
			End Get
		End Property
		Private Sub ucGridEditBar_DeleteRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBar.DeleteRecord
			If (Not Object.Equals(CurrentMovieCompany, Nothing)) Then
				gvMovies.HideEditor()
				gvMovies.UpdateCurrentRow()
				ObjectHelper.SafeDelete(Me.FindForm(), CurrentMovieCompany, False)
			End If
		End Sub
		Private Sub ucGridEditBar_AddRecord(ByVal sender As Object, ByVal e As EventArgs) Handles ucGridEditBar.AddRecord
			Using form As New frmCompanyAddMovie(Me.FindForm(), Session, Company, lcMain.MenuManager)
				If form.ShowDialog() = DialogResult.Cancel Then
					Return
				End If
				WinHelper.GridViewFocusObject(gvMovies, form.MovieCompany)
			End Using
		End Sub
		Private Sub beWebSite_ButtonClick(ByVal sender As Object, ByVal e As ButtonPressedEventArgs) Handles beWebSite.ButtonClick
			ObjectHelper.ShowWebSite(beWebSite.Text)
		End Sub

		Private Sub lueCountry_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lueCountry.EditValueChanged
			Dim country As Country = TryCast(lueCountry.EditValue, Country)
			If Object.Equals(country, Nothing) Then
				peFlag.Image = Nothing
			Else
				peFlag.Image = country.Flag
			End If
		End Sub
	End Class
End Namespace
