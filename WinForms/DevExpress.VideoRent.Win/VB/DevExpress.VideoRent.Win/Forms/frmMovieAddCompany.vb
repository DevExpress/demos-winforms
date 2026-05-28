Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Utils.Menu

Namespace DevExpress.VideoRent.Win.Forms
	Partial Public Class frmMovieAddCompany
		Inherits frmAddBase
		Private movie As Movie
		Public Sub New(ByVal parent As Form, ByVal session As UnitOfWork, ByVal movie As Movie, ByVal manager As IDXMenuManager)
			MyBase.New(parent, session, Nothing, manager)
			InitializeComponent()
			Me.movie = movie
			Text = String.Format(ConstStrings.AddCompanyTo, movie.Title)
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
		Protected Overrides Sub InitValidation()
			ValidationProvider.SetValidationRule(lueCompany, ValidationRulesHelper.RuleIsNotBlank)
		End Sub
		Private Sub InitEditors()
			EditorHelper.CreateCompanyLookUpEdit(Session, lueCompany.Properties, Nothing)
		End Sub
		Protected Overrides Sub SaveData()
			MyBase.SaveData()
			MovieCompany.Movie = movie
			MovieCompany.Company = CType(lueCompany.EditValue, Company)
			MovieCompany.Description = meDescription.Text
		End Sub
	End Class
End Namespace
