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
Imports DevExpress.XtraLayout
Imports DevExpress.XtraGrid
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering

Namespace DevExpress.VideoRent.Win.Controls
	Partial Public Class ucMovieCategoryDetail
		Inherits XtraUserControl
		Implements IEditsContainer
		Private _CategoryVar As MovieCategory
		Private allCategories As XPCollection(Of MovieCategory)
		Public Event EditValueChanged As EventHandler Implements IEditsContainer.EditValueChanged
		Private editValueChangedDelegate As EventHandler
		Public Sub New()
			MyBase.New()
			InitializeComponent()
			editValueChangedDelegate = New EventHandler(AddressOf edit_EditValueChanged)
			InitTabPages()
			lcMain.Images = ElementHelper.DiskIcons
			For Each item As Control In lcMain.Controls
				AddControl(item)
			Next item
		End Sub
		Public Sub SetFocus()
			teName.Focus()
		End Sub
		Public Sub SetLayoutManager(ByVal manager As IDXMenuManager)
			Me.lcMain.MenuManager = manager
			For Each item As Control In lcMain.Controls
				Dim edit As BaseEdit = TryCast(item, BaseEdit)
				If (Not Object.Equals(edit, Nothing)) Then
					edit.MenuManager = manager
				End If
				Dim price As ucMovieCategoryPriceDetail = TryCast(item, ucMovieCategoryPriceDetail)
				If (Not Object.Equals(price, Nothing)) Then
					price.SetLayoutManager(manager)
				End If
			Next item
		End Sub
		Public Sub Init(ByVal category As MovieCategory, ByVal allCategories As XPCollection(Of MovieCategory))
			Me._CategoryVar = category
			Me.allCategories = allCategories
			InitData()
			InitValidation()
		End Sub
		Protected Sub AddControl(ByVal item As Control)
			Dim edit As BaseEdit = TryCast(item, BaseEdit)
			If (Not Object.Equals(edit, Nothing)) Then
				edit.MenuManager = lcMain.MenuManager
				AddHandler edit.EditValueChanged, editValueChangedDelegate
			End If
			Dim editsContainer As IEditsContainer = TryCast(item, IEditsContainer)
			If (Not Object.Equals(editsContainer, Nothing)) Then
				AddHandler editsContainer.EditValueChanged, editValueChangedDelegate
			End If
		End Sub
		Protected Sub RemoveControl(ByVal item As Control)
			Dim edit As BaseEdit = TryCast(item, BaseEdit)
			If (Not Object.Equals(edit, Nothing)) Then
				edit.MenuManager = lcMain.MenuManager
				RemoveHandler edit.EditValueChanged, editValueChangedDelegate
			End If
			Dim editsContainer As IEditsContainer = TryCast(item, IEditsContainer)
			If (Not Object.Equals(editsContainer, Nothing)) Then
				RemoveHandler editsContainer.EditValueChanged, editValueChangedDelegate
			End If
			Dim grid As GridControl = TryCast(item, GridControl)
			If (Not Object.Equals(grid, Nothing)) Then
				grid.MenuManager = lcMain.MenuManager
			End If
		End Sub
		Private Sub InitValidation()
			Dim ruleUniqueName As New ConditionValidationRule()
			ruleUniqueName.ConditionOperator = ConditionOperator.NotAnyOf
			ruleUniqueName.Values.Add(Nothing)
			ruleUniqueName.Values.Add(String.Empty)
            For Each _category As MovieCategory In allCategories
                If _category.Equals(Me._CategoryVar) Then
                Continue For
                End If
                ruleUniqueName.Values.Add(_category.Name)
            Next _category
			ruleUniqueName.ErrorText = ConstStrings.RuleUniqueName
			ruleUniqueName.ErrorType = ErrorType.Critical
			validationProvider.SetValidationRule(teName, ruleUniqueName)
		End Sub
		Private Sub InitTabPages()
			For i As Integer = tcgMain.TabPages.Count - 1 To 0 Step -1
				tcgMain.RemoveTabPage(tcgMain.TabPages(i))
			Next i
			Dim formats() As MovieItemFormat = CType(System.Enum.GetValues(GetType(MovieItemFormat)), MovieItemFormat())
			For i As Integer = 0 To formats.Length - 1
				Dim format As MovieItemFormat = formats(i)
				Dim tab As LayoutGroup = tcgMain.AddTabPage()
				tab.CaptionImageIndex = i
				tab.Text = format.ToString()
				Dim item As LayoutControlItem = TryCast(tab.AddItem(), LayoutControlItem)
				Dim ucPrices As New ucMovieCategoryPriceDetail(Nothing)
				ucPrices.Tag = format
				item.Control = ucPrices
				item.TextVisible = False
				AddControl(ucPrices)
			Next i
			tcgMain.SelectedTabPageIndex = 0
		End Sub
		Private Sub InitData()
			teName.Text = Me._CategoryVar.Name
			For Each ctrl As Control In lcMain.Controls
				Dim ucPrice As ucMovieCategoryPriceDetail = TryCast(ctrl, ucMovieCategoryPriceDetail)
				If (Not Object.Equals(ucPrice, Nothing)) Then
					Dim format As MovieItemFormat = CType(ucPrice.Tag, MovieItemFormat)
					ucPrice.InitData(_CategoryVar.GetPrice(format))
				End If
			Next ctrl
		End Sub
		Public Function ValidateData() As Boolean
			Return validationProvider.Validate()
		End Function
		Public Sub SaveData()
			If Object.Equals(Me._CategoryVar, Nothing) Then
				Return
			End If
			Me._CategoryVar.Name = teName.Text
			For Each ctrl As Control In lcMain.Controls
				Dim ucPrice As ucMovieCategoryPriceDetail = TryCast(ctrl, ucMovieCategoryPriceDetail)
				If (Not Object.Equals(ucPrice, Nothing)) Then
					ucPrice.SaveData()
				End If
			Next ctrl
		End Sub
		Private Sub edit_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
			If (Not Object.Equals(EditValueChangedEvent, Nothing)) Then
                RaiseEvent EditValueChanged(sender, e)
			End If
		End Sub
		Public Shared Function CreateNewMovieCategory(ByVal session As Session, ByVal categories As XPBaseCollection) As MovieCategory
			Dim name As String = ConstStrings.NewCategory
			Dim suffix As Integer = 0
			Dim nameWithSuffix As String
			Do
				If suffix = 0 Then
					nameWithSuffix = name & (String.Empty)
				Else
					nameWithSuffix = name & ("(" & suffix.ToString() & ")")
				End If
				categories.Filter = CriteriaOperator.Parse("Name = ?", nameWithSuffix)
				If categories.Count = 0 Then
					Exit Do
				End If
				suffix += 1
			Loop
			categories.Filter = Nothing
			Return New MovieCategory(session, nameWithSuffix)
		End Function
	End Class
End Namespace
