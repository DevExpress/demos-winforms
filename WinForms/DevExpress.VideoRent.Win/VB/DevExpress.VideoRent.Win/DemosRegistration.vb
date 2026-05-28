Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking
Imports DevExpress.Xpo
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.VideoRent.Win.Modules

Namespace DevExpress.VideoRent.Win
	Public Class DemosInfo
		Inherits ModulesInfo
		Public Shared Sub ShowModule(ByVal parent As frmMain, ByVal name As String, ByVal group As PanelControl, ByVal session As UnitOfWork)
			Dim item As ModuleInfo = DemosInfo.GetItem(name)
			Dim currentCursor As Cursor = Cursor.Current
			Cursor.Current = Cursors.WaitCursor
			Try
				Dim oldTutorial As TutorialControlBase = Nothing
				If (Not Object.Equals(Instance.CurrentModuleBase, Nothing)) Then
					If Instance.CurrentModuleBase.Name = name Then
						Return
					End If
					oldTutorial = Instance.CurrentModuleBase.TModule
					Instance.CurrentModuleBase.ModuleDispose()
				End If

				Dim tutorial As TutorialControl = TryCast(item.TModule, TutorialControl)
				tutorial.Bounds = group.DisplayRectangle
				Instance.CurrentModuleBase = item
				tutorial.Visible = False
				group.Controls.Add(tutorial)
				tutorial.Dock = DockStyle.Fill

				'-----Init----
				WinHelper.CloseCustomizationForm(oldTutorial)
				'-------------

				'-----Set----
				tutorial.SetSession(session)
				tutorial.SetParent(parent)
				tutorial.TutorialName = name
				parent.ChartAppearanceManager.ViewType = tutorial.ChartViewType
				tutorial.CheckChartStyles(parent.ChartAppearanceManager)
				tutorial.ShowTutorial()
				'------------

				tutorial.Visible = True
				tutorial.BringToFront()
				item.WasShown = True
				If (Not Object.Equals(oldTutorial, Nothing)) Then
					oldTutorial.DumpActiveDetailControl()
					oldTutorial.HideElements()
				End If
			Finally
				Cursor.Current = currentCursor
			End Try
			RaiseModuleChanged()
		End Sub
	End Class
	Public Class RibbonViewMenu
		Public Shared Sub CreateNavigationMenu(ByVal menu As BarSubItem, ByVal navBar As NavBarControl, ByVal manager As BarManager)
			For Each group As NavBarGroup In navBar.Groups
				menu.ItemLinks.Add(CreateBarSubItem(manager, group))
			Next group
		End Sub
		Private Shared Function CreateBarSubItem(ByVal manager As BarManager, ByVal group As NavBarGroup) As BarItem
			Dim item As New BarSubItem(manager, group.Caption)
			'item.Glyph = group.GetImage();
			AddHandler item.Popup, AddressOf item_Popup
			For Each link As NavBarItemLink In group.ItemLinks
				item.ItemLinks.Add(CreateBarButtonItem(manager, link))
			Next link
			Return item
		End Function
		Private Shared Sub item_Popup(ByVal sender As Object, ByVal e As EventArgs)
			Dim menu As BarSubItem = TryCast(sender, BarSubItem)
			For Each link As BarItemLink In menu.ItemLinks
				CType(link.Item, BarButtonItem).Down = ModulesInfo.Instance.CurrentModuleBase Is GetModuleInfoBarItemLink(link)
			Next link
		End Sub
		Private Shared Function GetModuleInfoBarItemLink(ByVal link As BarItemLink) As ModuleInfo
			Dim nLink As NavBarItemLink = TryCast(link.Item.Tag, NavBarItemLink)
			If Object.Equals(nLink, Nothing) Then
				Return Nothing
			End If
			Return TryCast(nLink.Item.Tag, ModuleInfo)
		End Function
		Private Shared Function CreateBarButtonItem(ByVal manager As BarManager, ByVal link As NavBarItemLink) As BarButtonItem
			Dim item As New BarButtonItem(manager, link.Item.Caption)
			item.Glyph = link.Item.SmallImage
			AddHandler item.ItemClick, AddressOf item_ItemClick
			item.Tag = link
			item.ButtonStyle = BarButtonStyle.Check
			Return item
		End Function
		Private Shared Sub item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			Dim link As NavBarItemLink = CType(e.Item.Tag, NavBarItemLink)
			link.NavBar.SelectedLink = link
			link.NavBar.GetViewInfo().MakeLinkVisible(link)
		End Sub
	End Class
	Public Class RibbonMenuController
		Private parent As frmMain = Nothing
        Private fcurrentControl As TutorialControl
        Public ReadOnly Property Ribbon() As RibbonControl
            Get
                If Object.Equals(parent, Nothing) Then
                    Return Nothing
                End If
                Return parent.RibbonControl
            End Get
        End Property
        Public Property CurrentControl() As TutorialControl
            Get
                Return fcurrentControl
            End Get
            Set(ByVal value As TutorialControl)
                If fcurrentControl Is value Then
                    Return
                End If
                fcurrentControl = value
                If (Not Object.Equals(CurrentControl, Nothing)) Then
                    InitRibbonMenu()
                End If
            End Set
        End Property
		Friend Sub AddPageForControl(ByVal tutorialControl As TutorialControl)
			For Each page As RibbonPage In Ribbon.TotalPageCategory.Pages
				If Object.Equals(page.Tag, Nothing) Then
					Continue For
				End If
				If page.Tag.Equals(tutorialControl.TypeName) Then
					tutorialControl.ActiveRibbonPage = page
					page.Text = ConstStrings.DefaultPageName
					page.Tag = tutorialControl
					Exit For
				End If
			Next page
		End Sub
		Friend Sub CreateDetailRibbon()
			For Each page As RibbonPage In Ribbon.TotalPageCategory.Pages
				If Object.Equals(page.Tag, Nothing) OrElse Object.Equals(CurrentControl.ActiveDetailControl, Nothing) OrElse (Not Object.Equals(CurrentControl.ActiveDetailControl.ActiveRibbonPage, Nothing)) Then
					Continue For
				End If
				If page.Tag.Equals(CurrentControl.DetailTypeName) Then
					CurrentControl.ActiveDetailControl.CreateActiveRibbonPage(page)
				End If
			Next page
		End Sub
		Private lockPageChanging As Boolean = False
		Friend Sub UpdateMenu()
			lockPageChanging = True
			For Each page As RibbonPage In Ribbon.TotalPageCategory.Pages
				If Object.Equals(page.Tag, Nothing) Then
					Continue For
				End If
				page.Visible = CurrentControl.IsSuitablePage(page)
				If page.Visible AndAlso page.Tag.Equals(CurrentControl) Then
					parent.RibbonControl.SelectedPage = page
				End If
			Next page
			lockPageChanging = False
		End Sub
		Private Sub InitRibbonMenu()
			UpdateMenu()
			parent.AddButton.Hint = String.Format(ConstStrings.AddButtonHint, CurrentControl.EditObjectName)
			parent.EditButton.Hint = String.Format(ConstStrings.EditButtonHint, CurrentControl.EditObjectName)
			parent.DeleteButton.Hint = String.Format(ConstStrings.DeleteButtonHint, CurrentControl.EditObjectName)
			If Object.Equals(CurrentControl.EditObjectName, String.Empty) Then
				parent.RefreshButton.Hint = ConstStrings.RefreshDefaultButtonHint
			Else
				parent.RefreshButton.Hint = String.Format(ConstStrings.RefreshButtonHint, CurrentControl.EditObjectName)
			End If
			parent.PrevButton.Hint = String.Format(ConstStrings.PrevButtonHint, CurrentControl.EditObjectName)
			parent.NextButton.Hint = String.Format(ConstStrings.NextButtonHint, CurrentControl.EditObjectName)
			parent.OptionsButton.Hint = String.Format(ConstStrings.EditViewOptions, CurrentControl.EditObjectName)
			If (Not String.IsNullOrEmpty(CurrentControl.EditObjectName)) AndAlso CurrentControl.UseList Then
				parent.PrintPreviewButton.Hint = String.Format(ConstStrings.PrintPreviewButtonHint, CurrentControl.EditObjectName, ObjectHelper.GetArticleByWord(CurrentControl.EditObjectName))
				parent.ExportButton.Hint = String.Format(ConstStrings.ExportButtonHint, CurrentControl.EditObjectName)
				parent.HomeButton.Hint = String.Format(ConstStrings.HomeButtonHint, CurrentControl.EditObjectName)
			Else
				parent.PrintPreviewButton.Hint = ConstStrings.PrintPreviewButtonHintDefault
				parent.ExportButton.Hint = ConstStrings.ExportButtonHintDefault
				parent.HomeButton.Hint = String.Empty
			End If
		End Sub
		Public Sub New(ByVal parent As frmMain)
			Me.parent = parent
			InitRibbonElementsImages()
			InitButtonActions()
			InitStatusBar()
			AddHandler parent.RibbonControl.SelectedPageChanging, AddressOf RibbonControl_SelectedPageChanging
		End Sub
		Private activeControl As Control = Nothing
		Private Sub RibbonControl_SelectedPageChanging(ByVal sender As Object, ByVal e As RibbonPageChangingEventArgs)
			If lockPageChanging Then
				Return
			End If
			Dim control As Control = TryCast(e.Page.Tag, Control)
			If Object.Equals(control, Nothing) Then
				Return
			End If
			If (Not control.Visible) Then
				control.Show()
			End If
			control.BringToFront()
			If (Not Object.Equals(control, activeControl)) Then
				WinHelper.CloseCustomizationForm(CurrentControl)
			End If
			activeControl = control

			lockPageChanging = True
			Try
				Dim tControl As TutorialControlBase = TryCast(control, TutorialControlBase)
				If (Not Object.Equals(tControl, Nothing)) Then
					tControl.ActiveDetailControl = Nothing
				End If
				Dim dControl As DetailBase = TryCast(control, DetailBase)
				If (Not Object.Equals(dControl, Nothing)) Then
					CurrentControl.ActiveDetailControl = dControl
				End If
			Finally
				lockPageChanging = False
			End Try
		End Sub
		Public Shared Sub SetBarButtonImage(ByVal item As BarItem, ByVal name As String)
			item.LargeGlyph = ElementHelper.GetImage(name, ImageSize.Large32)
			item.Glyph = ElementHelper.GetImage(name, ImageSize.Small16)
		End Sub
		Private Sub InitRibbonElementsImages()
			SetBarButtonImage(parent.AddButton, "Add")
			SetBarButtonImage(parent.EditButton, "Edit")
			SetBarButtonImage(parent.DeleteButton, "Delete")
			SetBarButtonImage(parent.PrevButton, "Previous")
			SetBarButtonImage(parent.NextButton, "Next")
			SetBarButtonImage(parent.OptionsButton, "View")
			SetBarButtonImage(parent.CurrentCustomerButton, "Person")
			SetBarButtonImage(parent.ChangeCustomerButton, "UserKey")
			SetBarButtonImage(parent.RentButton, "Order")
			SetBarButtonImage(parent.ActiveRentButton, "ActiveRents")
			SetBarButtonImage(parent.ReturnButton, "Return")
			SetBarButtonImage(parent.SaveButton, "Save")
			SetBarButtonImage(parent.SaveAndCloseButton, "SaveAndClose")
			SetBarButtonImage(parent.CloseButton, "Close")
			SetBarButtonImage(parent.LoadPictureButton, "Open")
			SetBarButtonImage(parent.ClearPictureButton, "Delete")
			SetBarButtonImage(parent.AddPictureButton, "New")
			SetBarButtonImage(parent.DeletePictureButton, "Delete")
			SetBarButtonImage(parent.MovieAddItemButton, "AddItem")
			SetBarButtonImage(parent.MovieManageItemsButton, "ManageItems")
			SetBarButtonImage(parent.LayoutOptionsButton, "LayoutOptions")
			SetBarButtonImage(parent.ViewStylesMenu, "Views")
			SetBarButtonImage(parent.CloseDetailsButton, "CloseDetails")
			SetBarButtonImage(parent.ChartPaletteButton, "Palette")
			SetBarButtonImage(parent.MovieCategoriesButton, "Categories")
			SetBarButtonImage(parent.RefreshButton, "Refresh")
			SetBarButtonImage(parent.HomeButton, "Home")
			SetBarButtonImage(parent.PrintPreviewButton, "Preview")
			SetBarButtonImage(parent.ExportButton, "Export")
			SetBarButtonImage(parent.ExportToPDFButton, "ExportToPDF")
			SetBarButtonImage(parent.ExportToXMLButton, "ExportToXML")
			SetBarButtonImage(parent.ExportToHTMLButton, "ExportToHTML")
			SetBarButtonImage(parent.ExportToMHTButton, "ExportToMHT")
			SetBarButtonImage(parent.ExportToXLSButton, "ExportToExcel")
			SetBarButtonImage(parent.ExportToXLSXButton, "ExportToExcel")
			SetBarButtonImage(parent.ExportToRTFButton, "ExportToRTF")
			SetBarButtonImage(parent.ExportToImageButton, "ExportToIMG")
			SetBarButtonImage(parent.ExportToTextButton, "ExportToTXT")
			SetBarButtonImage(parent.RotateLayoutButton, "LayoutRotate")
			SetBarButtonImage(parent.FlipLayoutButton, "LayoutFlip")
			SetBarButtonImage(parent.PeriodButton, "Period")
			SetBarButtonImage(parent.ReceiptPeriodButton, "Period")
		End Sub
		Private Sub InitButtonActions()
            AddHandler parent.AddButton.ItemClick, AddressOf AnonymousMethod1
            AddHandler parent.EditButton.ItemClick, AddressOf AnonymousMethod2
            AddHandler parent.DeleteButton.ItemClick, AddressOf AnonymousMethod3
            AddHandler parent.PrevButton.ItemClick, AddressOf AnonymousMethod4
            AddHandler parent.NextButton.ItemClick, AddressOf AnonymousMethod5
            AddHandler parent.OptionsButton.ItemClick, AddressOf AnonymousMethod6
            AddHandler parent.CurrentCustomerButton.ItemClick, AddressOf AnonymousMethod7
            AddHandler parent.ChangeCustomerButton.ItemClick, AddressOf AnonymousMethod8
            AddHandler parent.RentButton.ItemClick, AddressOf AnonymousMethod9
            AddHandler parent.ReturnButton.ItemClick, AddressOf AnonymousMethod10
            AddHandler parent.ActiveRentButton.ItemClick, AddressOf AnonymousMethod11
            AddHandler parent.SaveButton.ItemClick, AddressOf AnonymousMethod12
            AddHandler parent.SaveAndCloseButton.ItemClick, AddressOf AnonymousMethod13
            AddHandler parent.CloseButton.ItemClick, AddressOf AnonymousMethod14
            AddHandler parent.LoadPictureButton.ItemClick, AddressOf AnonymousMethod15
            AddHandler parent.ClearPictureButton.ItemClick, AddressOf AnonymousMethod16
            AddHandler parent.MovieAddItemButton.ItemClick, AddressOf AnonymousMethod17
            AddHandler parent.MovieManageItemsButton.ItemClick, AddressOf AnonymousMethod18
            AddHandler parent.AddPictureButton.ItemClick, AddressOf AnonymousMethod19
            AddHandler parent.DeletePictureButton.ItemClick, AddressOf AnonymousMethod20
            AddHandler parent.ViewStylesMenu.Popup, AddressOf ViewStylesMenu_Popup
            AddHandler parent.MainViewButton.ItemClick, AddressOf AnonymousMethod21
            AddHandler parent.AlternateViewButton.ItemClick, AddressOf AnonymousMethod22
            AddHandler parent.CloseDetailsButton.ItemClick, AddressOf AnonymousMethod23
            AddHandler parent.MovieCategoriesButton.ItemClick, AddressOf AnonymousMethod24
            AddHandler parent.RefreshButton.ItemClick, AddressOf AnonymousMethod25
            AddHandler parent.HomeButton.ItemClick, AddressOf AnonymousMethod26
            AddHandler parent.PrintPreviewButton.ItemClick, AddressOf AnonymousMethod27
            AddHandler parent.ExportToPDFButton.ItemClick, AddressOf AnonymousMethod28
            AddHandler parent.ExportToXMLButton.ItemClick, AddressOf AnonymousMethod29
            AddHandler parent.ExportToHTMLButton.ItemClick, AddressOf AnonymousMethod30
            AddHandler parent.ExportToMHTButton.ItemClick, AddressOf AnonymousMethod31
            AddHandler parent.ExportToXLSButton.ItemClick, AddressOf AnonymousMethod32
            AddHandler parent.ExportToXLSXButton.ItemClick, AddressOf AnonymousMethod33
            AddHandler parent.ExportToRTFButton.ItemClick, AddressOf AnonymousMethod34
            AddHandler parent.ExportToImageButton.ItemClick, AddressOf AnonymousMethod35
            AddHandler parent.ExportToTextButton.ItemClick, AddressOf AnonymousMethod36
            AddHandler parent.RotateLayoutButton.ItemClick, AddressOf AnonymousMethod37
            AddHandler parent.FlipLayoutButton.ItemClick, AddressOf AnonymousMethod38
		End Sub
		
		Private Sub AnonymousMethod1(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.Add()
        End Sub
		
        Private Sub AnonymousMethod2(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.Edit()
        End Sub
		
        Private Sub AnonymousMethod3(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.Delete()
        End Sub
		
		Private Sub AnonymousMethod4(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			CurrentControl.Prev()
		End Sub
		
        Private Sub AnonymousMethod5(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.Next()
        End Sub
		
        Private Sub AnonymousMethod6(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.EditOptions()
        End Sub
		
        Private Sub AnonymousMethod7(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.SetCurrentCustomer()
        End Sub
		
        Private Sub AnonymousMethod8(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            parent.LayoutManager.ShowFindCustomerForm(parent, parent.MenuManager)
        End Sub
		
        Private Sub AnonymousMethod9(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.RentMovie()
        End Sub
		
        Private Sub AnonymousMethod10(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ReturnMovie()
        End Sub
		
        Private Sub AnonymousMethod11(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.CheckActiveItems()
        End Sub
		
        Private Sub AnonymousMethod12(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.DetailSave()
        End Sub
		
        Private Sub AnonymousMethod13(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.DetailSaveAndClose()
        End Sub
		
        Private Sub AnonymousMethod14(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.DetailClose()
        End Sub
		
        Private Sub AnonymousMethod15(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.LoadPicture()
        End Sub
		
        Private Sub AnonymousMethod16(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ClearPicture()
        End Sub
		
        Private Sub AnonymousMethod17(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.MovieAddItem()
        End Sub
		
        Private Sub AnonymousMethod18(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.MovieManageItems()
        End Sub
		
        Private Sub AnonymousMethod19(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.AddPicture()
        End Sub
		
        Private Sub AnonymousMethod20(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.DeletePicture()
        End Sub
		
        Private Sub AnonymousMethod21(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.DoViewChange(True)
        End Sub
		
        Private Sub AnonymousMethod22(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.DoViewChange(False)
        End Sub
		
        Private Sub AnonymousMethod23(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.CloseAllDetails()
        End Sub
		
        Private Sub AnonymousMethod24(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ShowMovieCategories()
        End Sub
		
        Private Sub AnonymousMethod25(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.RefreshData()
        End Sub
		
        Private Sub AnonymousMethod26(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ShowMasterModule()
        End Sub
		
        Private Sub AnonymousMethod27(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.PrintPreview()
        End Sub
		
        Private Sub AnonymousMethod28(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToPDF()
        End Sub
		
        Private Sub AnonymousMethod29(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToXML()
        End Sub
		
        Private Sub AnonymousMethod30(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToHTML()
        End Sub
		
        Private Sub AnonymousMethod31(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToMHT()
        End Sub
		
        Private Sub AnonymousMethod32(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToXLS()
        End Sub
		
        Private Sub AnonymousMethod33(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToXLSX()
        End Sub
		
        Private Sub AnonymousMethod34(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToRTF()
        End Sub
		
        Private Sub AnonymousMethod35(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToImage()
        End Sub
		
        Private Sub AnonymousMethod36(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.ExportToText()
        End Sub
		
        Private Sub AnonymousMethod37(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.RotateLayout()
        End Sub
		
        Private Sub AnonymousMethod38(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            CurrentControl.FlipLayout()
        End Sub

		Private Sub ViewStylesMenu_Popup(ByVal sender As Object, ByVal e As EventArgs)
			CurrentControl.ViewStylesPopup(sender)
		End Sub
		Friend Sub CalcDetailFormItemsEnabling(ByVal allow As Boolean, ByVal first As Boolean, ByVal last As Boolean)
			parent.DeleteButton.Enabled = allow
			parent.EditButton.Enabled = parent.DeleteButton.Enabled
			parent.PrevButton.Enabled = allow AndAlso Not first
			parent.NextButton.Enabled = allow AndAlso Not last
		End Sub
		Friend Sub CalcCustomerItemsEnabling(ByVal allow As Boolean)
			parent.CurrentCustomerButton.Enabled = allow
		End Sub
		Friend Sub CalcCloseAllDetails()
			parent.CloseDetailsButton.Enabled = CurrentControl.IsDetailsExist
		End Sub
		Friend Sub CalcRentItemsEnabling(ByVal allowRent As Boolean, ByVal allowReturn As Boolean)
			'TODO parent.RentButton.Enabled = allowRent;
			parent.RentButton.Enabled = False 'for the future use
			parent.ReturnButton.Enabled = allowReturn
		End Sub
		Friend Sub CalcRentItemsEnablingEx(ByVal allowCheck As Boolean)
			parent.ActiveRentButton.Enabled = allowCheck
		End Sub
		Private Sub InitStatusBar()
			Dim link As BarItemLink = parent.MainStatusBar.ItemLinks.Add(parent.ChangeCustomerButton)
			link.Item.Alignment = BarItemLinkAlignment.Right
			link.UserCaption = ""
			link.UserDefine = BarLinkUserDefines.Caption
		End Sub
	End Class
End Namespace
