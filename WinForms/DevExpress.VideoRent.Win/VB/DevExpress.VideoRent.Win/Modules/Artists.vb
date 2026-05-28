Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.VideoRent.Win.Forms
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Card.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Xpo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Artists
		Inherits GridExportTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property EditObjectName() As String
			Get
				Return ConstStrings.Artist
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectsName() As String
			Get
				Return ConstStrings.Artists
			End Get
		End Property
		Protected Overrides ReadOnly Property MainView() As ColumnView
			Get
				Return gridView1
			End Get
		End Property
		Protected Overrides ReadOnly Property CurrentEditObject() As VideoRentBaseObject
			Get
				Return CurrentArtist
			End Get
		End Property
		Protected Overrides ReadOnly Property Landscape() As Boolean
			Get
				Return True
			End Get
		End Property
		Private ReadOnly Property CurrentArtist() As Artist
			Get
				If MainView.FocusedRowHandle < 0 Then
					Return Nothing
				End If
				Return TryCast(MainView.GetRow(MainView.FocusedRowHandle), Artist)
			End Get
		End Property
		Protected Overrides Sub RefreshGridDataSource()
			Dim current As VideoRentBaseObject = CurrentEditObject
			gridControl1.DataSource = New XPCollection(Of Artist)(Session, Nothing, New DevExpress.Xpo.SortProperty("[LastName]", DevExpress.Xpo.DB.SortingDirection.Ascending))
			WinHelper.GridViewFocusObject(MainView, current)
		End Sub
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			RefreshGridDataSource()
		End Sub
		Protected Overrides Sub InitData()
			MyBase.InitData()
			colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(gridControl1.RepositoryItems)
			colBirthCountry.ColumnEdit = EditorHelper.CreateCountryLookUpEdit(Session, gridControl1.RepositoryItems, True)
			Dim TempGridViewImageTextToolTipController As GridViewImageTextToolTipController = New GridViewImageTextToolTipController(gridView1, "Biography", False)
		End Sub
		Public Overrides Sub EditOptions()
			MyBase.EditOptions()
			Using frm As New frmArtistGridOptions(Me.FindForm(), gridView1)
				frm.ShowDialog(Me)
			End Using
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
		Private Sub EditArtist()
			If (Not IsDetailExist(CurrentArtist.Oid)) Then
				ShowModuleDialog(New ArtistDetail(Me.FindForm(), Session, CurrentArtist, MenuManager, AddressOf CloseDetailForm))
			End If
		End Sub
		Private Sub AddArtist()
			If (Not IsDetailExist(Guid.Empty)) Then
				ShowModuleDialog(New ArtistDetail(Me.FindForm(), Session, Nothing, MenuManager, AddressOf CloseDetailFormAndReload))
			End If
		End Sub
		Public Overrides Sub Add()
			MyBase.Add()
			AddArtist()
		End Sub
		Public Overrides Sub Edit()
			MyBase.Edit()
			EditArtist()
		End Sub

		Private Sub cardView1_CalcFieldHeight(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Card.FieldHeightEventArgs) Handles cardView1.CalcFieldHeight
			Dim maxHeigh As Integer = gridControl1.Height \ 2
			If e.FieldHeight > maxHeigh Then
				e.FieldHeight = maxHeigh
			End If
		End Sub
	End Class
End Namespace
