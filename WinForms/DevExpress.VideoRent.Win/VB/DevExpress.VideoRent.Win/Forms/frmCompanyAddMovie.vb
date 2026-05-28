Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmCompanyAddMovie
		Inherits frmAddBase
		Private company As Company
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal company As Company, ByVal manager As IDXMenuManager)
			MyBase.New(parent, session, Nothing, manager)
			InitializeComponent()
			Me.company = company
			Text = String.Format(ConstStrings.AddMovieTo, company.Name)
		End Sub
		Public ReadOnly Property MovieCompany() As MovieCompany
			Get
				Return TryCast(editObject, MovieCompany)
			End Get
		End Property
		Protected Overrides Sub CreateNewObject()
			MyBase.CreateNewObject()
			editObject = New MovieCompany(Session)
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			InitEditors()
		End Sub
		Private Sub InitEditors()
			EditorHelper.CreateMovieGridLookUpEdit(Session, lueMovie.Properties, Nothing)
		End Sub
		Protected Overrides Sub InitValidation()
			MyBase.InitValidation()
			ValidationProvider.SetValidationRule(lueMovie, ValidationRulesHelper.RuleIsNotBlank)
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()
			MovieCompany.Company = company
			MovieCompany.Movie = CType(lueMovie.EditValue, Movie)
			MovieCompany.Description = teDescription.Text
		End Sub
	End Class
End Namespace
