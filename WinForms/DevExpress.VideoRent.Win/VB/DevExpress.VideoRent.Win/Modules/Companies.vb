Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.Xpo

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Companies
		Inherits GridExportTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub xcCompanies_ResolveSession(ByVal sender As Object, ByVal e As DevExpress.Xpo.ResolveSessionEventArgs)
			e.Session = Session
		End Sub
		Protected Overrides Sub RefreshGridDataSource()
			Dim current As VideoRentBaseObject = CurrentEditObject
			gridControl1.DataSource = New XPCollection(Of Company)(Session, Nothing, New DevExpress.Xpo.SortProperty("[MoviesCount]", DevExpress.Xpo.DB.SortingDirection.Descending), New DevExpress.Xpo.SortProperty("[Name]", DevExpress.Xpo.DB.SortingDirection.Ascending))
			WinHelper.GridViewFocusObject(MainView, current)
		End Sub
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			RefreshGridDataSource()
		End Sub
		Public Overrides ReadOnly Property EditObjectName() As String
			Get
				Return ConstStrings.Company
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectsName() As String
			Get
				Return ConstStrings.Companies
			End Get
		End Property
		Protected Overrides ReadOnly Property MainView() As ColumnView
			Get
				Return gridView1
			End Get
		End Property
		Protected Overrides ReadOnly Property CurrentEditObject() As VideoRentBaseObject
			Get
				Return CurrentCompany
			End Get
		End Property
		Private ReadOnly Property CurrentCompany() As Company
			Get
				If MainView.FocusedRowHandle < 0 Then
					Return Nothing
				End If
				Return TryCast(MainView.GetRow(MainView.FocusedRowHandle), Company)
			End Get
		End Property
		Protected Overrides Sub InitData()
			MyBase.InitData()
			colCountry.ColumnEdit = EditorHelper.CreateCountryLookUpEdit(Session, gridControl1.RepositoryItems, True)
			colType.ColumnEdit = EditorHelper.CreateCompanyTypeLookUpEdit(Session, Nothing, gridControl1.RepositoryItems, True)
		End Sub
		Public Overrides Sub Add()
			MyBase.Add()
			AddCompany()
		End Sub
		Public Overrides Sub Edit()
			MyBase.Edit()
			EditCompany()
		End Sub
		Protected Overrides Sub CloseDetailForm(ByVal result As DialogResult, ByVal currentObject As Object)
			MyBase.CloseDetailForm(result, currentObject)
			If result <> DialogResult.Cancel Then
				RefreshData()
			End If
		End Sub
		Protected Overrides Sub CloseDetailFormAndReload(ByVal result As DialogResult, ByVal currentObject As Object)
			MyBase.CloseDetailFormAndReload(result, currentObject)
			If result = DialogResult.Cancel Then
				Return
			End If
			RefreshData()
			WinHelper.GridViewFocusObject(MainView, TryCast(currentObject, VideoRentBaseObject))
		End Sub
		Private Sub AddCompany()
			If (Not IsDetailExist(Guid.Empty)) Then
				ShowModuleDialog(New CompanyDetail(Me.FindForm(), Session, Nothing, MenuManager, AddressOf CloseDetailFormAndReload))
			End If
		End Sub
		Private Sub EditCompany()
			If (Not IsDetailExist(CurrentCompany.Oid)) Then
				ShowModuleDialog(New CompanyDetail(Me.FindForm(), Session, CurrentCompany, MenuManager, AddressOf CloseDetailForm))
			End If
		End Sub

		Private Sub gridControl1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridControl1.MouseDown
			Dim info As GridHitInfo = gridView1.CalcHitInfo(New Point(e.X, e.Y))
			If info.InRow AndAlso Object.Equals(info.Column, colWebSite) Then
				Dim link As String = String.Format("{0}", gridView1.GetRowCellValue(info.RowHandle, info.Column))
				ObjectHelper.ShowWebSite(link)
			End If
		End Sub

		Private Sub layoutView1_CustomCardLayout(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventArgs) Handles layoutView1.CustomCardLayout
			Dim description As String = String.Format("{0}", (CType(sender, ColumnView)).GetRowCellValue(e.RowHandle, colDescription))
			If description = String.Empty Then
				e.CardDifferences.AddItemDifference("layoutViewField_layoutViewColumn1", DevExpress.XtraGrid.Views.Layout.LayoutItemDifferenceType.ItemVisibility, False)
			End If
		End Sub
	End Class
End Namespace
