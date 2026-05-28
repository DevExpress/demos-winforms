Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Data.Filtering
Imports DevExpress.XtraEditors
Imports DevExpress.Utils
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.VideoRent.Win.Forms

Namespace DevExpress.VideoRent.Win.Modules
	Partial Public Class Customers
		Inherits GridExportTutorialControl
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Overrides ReadOnly Property EditObjectName() As String
			Get
				Return ConstStrings.Customer
			End Get
		End Property
		Public Overrides ReadOnly Property EditObjectsName() As String
			Get
				Return ConstStrings.Customers
			End Get
		End Property
		Friend Overrides Sub RefreshData()
			MyBase.RefreshData()
			xcCustomers.Reload()
		End Sub
		Protected Overrides ReadOnly Property MainView() As ColumnView
			Get
				Return advBandedGridView1
			End Get
		End Property
		Protected Overrides ReadOnly Property CurrentView() As ColumnView
			Get
				Return TryCast(gridControl1.MainView, ColumnView)
			End Get
		End Property
		Protected Overrides ReadOnly Property AlternateView() As ColumnView
			Get
				Return gridView1
			End Get
		End Property
		Protected Overrides ReadOnly Property CurrentEditObject() As VideoRentBaseObject
			Get
				Return CurrentCustomer
			End Get
		End Property
		Protected Overrides ReadOnly Property Landscape() As Boolean
			Get
				Return True
			End Get
		End Property
		Private ReadOnly Property CurrentCustomer() As Customer
			Get
				If Object.Equals(CurrentView, Nothing) OrElse CurrentView.FocusedRowHandle < 0 Then
					Return Nothing
				End If
				Return TryCast(CurrentView.GetRow(CurrentView.FocusedRowHandle), Customer)
			End Get
		End Property
		Protected Overrides Sub InitData()
			MyBase.InitData()
			xcCustomers.Session = Session
			colGender.ColumnEdit = EditorHelper.CreateGenderImageComboBox(Nothing, False, gridControl1.RepositoryItems)
			colGender2.ColumnEdit = EditorHelper.CreateGenderImageComboBox(Nothing, True, gridControl1.RepositoryItems)
			colCustomerId.ColumnEdit = EditorHelper.CreateCardNumberTextEdit(gridControl1.RepositoryItems)
			colCardNumber.ColumnEdit = EditorHelper.CreateCardNumberTextEdit(gridControl1.RepositoryItems)
			colLevel.ColumnEdit = EditorHelper.CreateDiscountLevelImageComboBox(gridControl1.RepositoryItems)
			Dim TempGridViewImageTextToolTipController As GridViewImageTextToolTipController = New GridViewImageTextToolTipController(advBandedGridView1, "Photo")
            TempGridViewImageTextToolTipController = New GridViewImageTextToolTipController(gridView1, "Photo")
            TempGridViewImageTextToolTipController = New GridViewImageTextToolTipController(gridView1, "Comments", False)
			gridView1.Images = ElementHelper.ColumnHeaderIcons
			colGender2.ImageIndex = 2
		End Sub
		Protected Friend Overrides Function Delete() As Boolean
			If CurrentCustomer.AllowDelete Then
				Dim customerId As Guid = CurrentCustomer.Oid
				If MyBase.Delete() Then
					If (Not Object.Equals(LayoutManager.CurrentCustomer, Nothing)) AndAlso Object.Equals(LayoutManager.CurrentCustomerId, customerId) Then
						LayoutManager.CurrentCustomer = Nothing
					End If
				End If
			Else
				XtraMessageBox.Show(Me.FindForm(), String.Format(ConstStrings.CannotDeleteCustomer, CurrentCustomer.FullName), ConstStrings.Information, MessageBoxButtons.OK, MessageBoxIcon.Information)
			End If
			Return False
		End Function
		Protected Overrides Sub OnLoad(ByVal e As EventArgs)
			MyBase.OnLoad(e)
			gridControl1.ForceInitialize()
			CurrentView.FocusedRowHandle = GridControl.AutoFilterRowHandle
		End Sub
		Private Sub advBandedGridView1_CustomDrawColumnHeader(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawColumnHeader, gridView1.CustomDrawColumnHeader
			If (Not Object.Equals(e.Column, Nothing)) AndAlso Object.Equals(e.Column, CurrentView.FocusedColumn) Then
				e.Appearance.Font = ElementHelper.FontBold
			Else
				e.Appearance.Font = AppearanceObject.DefaultFont
			End If
		End Sub

		Private Sub advBandedGridView1_FocusedRowChanged(ByVal sender As Object, ByVal e As FocusedRowChangedEventArgs) Handles advBandedGridView1.FocusedRowChanged, gridView1.FocusedRowChanged
			InitFocusedRow()
		End Sub
		Private Sub InitFocusedRow()
			If CurrentView.FocusedRowHandle = GridControl.AutoFilterRowHandle Then
				MainView.FocusedColumn = colName1
				AlternateView.FocusedColumn = colName
			ElseIf CurrentView.FocusedRowHandle >= 0 Then
				CurrentView.FocusedColumn = Nothing
				CurrentView.Invalidate()
			End If
		End Sub
		Private Sub advBandedGridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As FocusedColumnChangedEventArgs) Handles advBandedGridView1.FocusedColumnChanged, gridView1.FocusedColumnChanged
			If CurrentView.FocusedRowHandle = GridControl.AutoFilterRowHandle Then
				CurrentView.Invalidate()
			End If
		End Sub
		Protected Overrides Sub CloseDetailFormAndReload(ByVal result As DialogResult, ByVal currentObject As Object)
			MyBase.CloseDetailFormAndReload(result, currentObject)
			If result = DialogResult.Cancel Then
				Return
			End If
			xcCustomers.Reload()
			WinHelper.GridViewFocusObject(CurrentView, TryCast(currentObject, VideoRentBaseObject))
		End Sub
		Private Sub EditCustomer()
			If (Not IsDetailExist(CurrentCustomer.Oid)) Then
                ShowModuleDialog(New CustomerDetail(Me.FindForm(), Session, CurrentCustomer, MenuManager, AddressOf CloseDetailForm))
			End If
		End Sub

		Private Sub AddCustomer()
			If (Not IsDetailExist(Guid.Empty)) Then
				ShowModuleDialog(New CustomerDetail(Me.FindForm(), Session, Nothing, MenuManager, AddressOf CloseDetailFormAndReload))
			End If
		End Sub
		Public Overrides Sub Add()
			MyBase.Add()
			AddCustomer()
		End Sub
		Public Overrides Sub Edit()
			MyBase.Edit()
			EditCustomer()
		End Sub
		Private Sub advBandedGridView1_CustomDrawCell(ByVal sender As Object, ByVal e As RowCellCustomDrawEventArgs) Handles advBandedGridView1.CustomDrawCell
			If e.Column IsNot colPhoto Then
				Return
			End If
			If Object.Equals(e.CellValue, Nothing) Then
				e.Cache.Graphics.DrawImage(ReferenceImages.UnknownPerson_Small, ImageCreator.GetZoomDestRectangle(e.Bounds, ReferenceImages.UnknownPerson_Small), New Rectangle(0, 0, ReferenceImages.UnknownPerson_Small.Width, ReferenceImages.UnknownPerson_Small.Height), GraphicsUnit.Pixel)
				e.Handled = True
			End If
		End Sub
		Protected Friend Overrides Sub ViewStylesPopup(ByVal sender As Object)
			MyBase.ViewStylesPopup(sender)
			ParentFormMain.MainViewButton.Caption = ConstStrings.AdvancedGrid
			ParentFormMain.AlternateViewButton.Caption = ConstStrings.SimpleGrid
		End Sub
		Protected Friend Overrides Sub DoViewChange(ByVal mainView As Boolean)
			Dim currentObject As VideoRentBaseObject = CurrentCustomer
			Dim filter As String = CurrentView.ActiveFilterString
			If mainView Then
				gridControl1.MainView = Me.MainView
			Else
				gridControl1.MainView = AlternateView
			End If
			InitFocusedRow()
			WinHelper.GridViewFocusObject(CurrentView, currentObject)
			CurrentView.ActiveFilterString = filter
		End Sub

		Private Sub advBandedGridView1_PopupMenuShowing(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs) Handles advBandedGridView1.PopupMenuShowing
			ObjectHelper.RemoveCustomizationItemsFromColumnMenu(e)
		End Sub
	End Class
End Namespace
