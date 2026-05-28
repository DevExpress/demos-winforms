Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid

Namespace DevExpress.VideoRent.Win.Controls
	Public Interface IEditsContainer
		Event EditValueChanged As EventHandler
	End Interface
	Partial Public Class ucMovieCategoryPriceDetail
		Inherits XtraUserControl
		Implements IEditsContainer
		Private categoryPrice As MovieCategoryPrice
		Public Event EditValueChanged As EventHandler Implements IEditsContainer.EditValueChanged
		Public Sub New()
			MyBase.New()
			InitializeComponent()
		End Sub
		Public Sub New(ByVal categoryPrice As MovieCategoryPrice)
			Me.New()
			Init(categoryPrice)
		End Sub
		Public Sub SetLayoutManager(ByVal manager As IDXMenuManager)
			Me.lcMain.MenuManager = manager
			For Each item As Control In lcMain.Controls
				Dim edit As BaseEdit = TryCast(item, BaseEdit)
				If (Not Object.Equals(edit, Nothing)) Then
					edit.MenuManager = manager
				End If
			Next item
		End Sub
		Public Sub Init(ByVal categoryPrice As MovieCategoryPrice)
			InitData(categoryPrice)
			For Each item As Control In lcMain.Controls
				AddControl(item)
			Next item
		End Sub
		Protected Sub AddControl(ByVal item As Control)
			Dim edit As BaseEdit = TryCast(item, BaseEdit)
			If (Not Object.Equals(edit, Nothing)) Then
				edit.MenuManager = lcMain.MenuManager
				AddHandler edit.EditValueChanged, AddressOf edit_EditValueChanged
			End If
			Dim editsContainer As IEditsContainer = TryCast(item, IEditsContainer)
			If (Not Object.Equals(editsContainer, Nothing)) Then
				AddHandler editsContainer.EditValueChanged, AddressOf edit_EditValueChanged
			End If
		End Sub
		Public Sub InitData(ByVal categoryPrice As MovieCategoryPrice)
			If Object.Equals(categoryPrice, Nothing) Then
				Return
			End If
			Me.categoryPrice = categoryPrice
			seDays1Price.Value = categoryPrice.Days1RentPrice
			seDays2Price.Value = categoryPrice.Days2RentPrice
			seDays3Price.Value = categoryPrice.Days3RentPrice
			seDays4Price.Value = categoryPrice.Days4RentPrice
			seDays5Price.Value = categoryPrice.Days5RentPrice
			seDays6Price.Value = categoryPrice.Days6RentPrice
			seDays7Price.Value = categoryPrice.Days7RentPrice
			seLatePrice.Value = categoryPrice.LateRentPrice
			seDefaultDays.Value = categoryPrice.DefaultRentDays
		End Sub
		Public Sub SaveData()
			categoryPrice.Days1RentPrice = seDays1Price.Value
			categoryPrice.Days2RentPrice = seDays2Price.Value
			categoryPrice.Days3RentPrice = seDays3Price.Value
			categoryPrice.Days4RentPrice = seDays4Price.Value
			categoryPrice.Days5RentPrice = seDays5Price.Value
			categoryPrice.Days6RentPrice = seDays6Price.Value
			categoryPrice.Days7RentPrice = seDays7Price.Value
			categoryPrice.LateRentPrice = seLatePrice.Value
			categoryPrice.DefaultRentDays = CInt(Fix(seDefaultDays.Value))
		End Sub
		Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Object.Equals(EditValueChangedEvent, Nothing)) Then
                RaiseEvent EditValueChanged(sender, e)
			End If
		End Sub
	End Class
End Namespace
