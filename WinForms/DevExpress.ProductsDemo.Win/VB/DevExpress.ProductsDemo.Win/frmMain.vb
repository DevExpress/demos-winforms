Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraNavBar
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraBars.Ribbon.Gallery
Imports DevExpress.XtraRichEdit
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils.About
Imports DevExpress.MailDemo.Win
Imports DevExpress.MailClient.Win
Imports DevExpress.MailClient.Win.Forms
Imports DevExpress.Demos
Imports DevExpress.Description.Controls
Imports DevExpress.XtraEditors.ColorWheel
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils.Taskbar.Core
Imports DevExpress.Utils.Taskbar

Namespace DevExpress.ProductsDemo.Win
	Partial Public Class frmMain
		Inherits RibbonForm

		Private modulesNavigator As ModulesNavigator
'INSTANT VB NOTE: The field zoomManager was renamed since Visual Basic does not allow fields to have the same name as other class members:
		Private zoomManager_Renamed As ZoomManager
		Private AllowCustomizationMenuList As New List(Of BarItem)()
		Private guideGenerator As GuideGenerator
		Public Sub New()
			TaskbarHelper.InitDemoJumpList(TaskbarAssistant.Default, Me)
			InitializeComponent()
			RibbonButtonsInitialize()
			modulesNavigator = New ModulesNavigator(ribbonControl1, pcMain)
			zoomManager_Renamed = New ZoomManager(ribbonControl1, modulesNavigator, beiZoom)
			InitNavBarItemLinks()
			NavigationInitialize()
			SetPageLayoutStyle()
			guideGenerator = New GuideGenerator()
			guideGenerator.CreateWhatsThisItem(ribbonControl1, Function()
				Return Me
			End Function)
		End Sub
		Private Sub NavigationInitialize()
			For Each link As NavBarItemLink In nbgModules.ItemLinks
				Dim item As New BarButtonItem(ribbonControl1.Manager, link.Item.Caption)
				item.Tag = link
				item.Glyph = link.Item.SmallImage
				AddHandler item.ItemClick, AddressOf item_ItemClick
				bsiNavigation.ItemLinks.Add(item)
			Next link
		End Sub

		Private Sub item_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
			nbgModules.SelectedLink = DirectCast(e.Item.Tag, NavBarItemLink)
		End Sub
		Private Sub RibbonButtonsInitialize()
			InitBarButtonItem(bbiNewTask, TagResources.TaskNew, My.Resources.NewTaskDescription)
			InitBarButtonItem(bbiEditTask, TagResources.TaskEdit, My.Resources.EditTaskDescription)
			InitBarButtonItem(bbiDeleteTask, TagResources.TaskDelete, My.Resources.DeleteTaskDescription)
			InitBarButtonItem(bbiTodayFlag, FlagStatus.Today, My.Resources.FlagTodayDescription)
			InitBarButtonItem(bbiTomorrowFlag, FlagStatus.Tomorrow, My.Resources.FlagTomorrowDescription)
			InitBarButtonItem(bbiThisWeekFlag, FlagStatus.ThisWeek, My.Resources.FlagThisWeekDescription)
			InitBarButtonItem(bbiNextWeekFlag, FlagStatus.NextWeek, My.Resources.FlagNextWeekDescription)
			InitBarButtonItem(bbiNoDateFlag, FlagStatus.NoDate, My.Resources.FlagNoDatekDescription)
			InitBarButtonItem(bbiCustomFlag, FlagStatus.Custom, My.Resources.FlagCustomDescription)
			InitBarButtonItem(bbiNewContact, TagResources.ContactNew, My.Resources.NewContactDescription)
			InitBarButtonItem(bbiEditContact, TagResources.ContactEdit, My.Resources.EditContactDescription)
			InitBarButtonItem(bbiDeleteContact, TagResources.ContactDelete, My.Resources.DeleteContactDescription)
			InitBarButtonItem(bbiFlipLayout, TagResources.FlipLayout, My.Resources.FlipLayoutDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(0), TagResources.TaskList, My.Resources.TaskListDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(1), TagResources.TaskToDoList, My.Resources.TaskToDoListDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(2), TagResources.TaskCompleted, My.Resources.TaskCompletedDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(3), TagResources.TaskToday, My.Resources.TaskTodayDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(4), TagResources.TaskPrioritized, My.Resources.TaskPrioritizedDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(5), TagResources.TaskOverdue, My.Resources.TaskOverdueDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(6), TagResources.TaskSimpleList, My.Resources.TaskSimpleListDescription)
			InitGalleryItem(rgbiCurrentViewTasks.Gallery.Groups(0).Items(7), TagResources.TaskDeferred, My.Resources.TaskDeferredDescription)
			InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(0), TagResources.ContactList, My.Resources.ContactListDescription)
			InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(1), TagResources.ContactAlphabetical, My.Resources.ContactAlphabeticalDescription)
			InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(2), TagResources.ContactByState, My.Resources.ContactByStateDescription)
			InitGalleryItem(rgbiCurrentView.Gallery.Groups(0).Items(3), TagResources.ContactCard, My.Resources.ContactCardDescription)
			bvbiSaveAs.Tag = TagResources.MenuSaveAs
			bvbiSaveAttachment.Tag = TagResources.MenuSaveAttachment
			bsiNavigation.Hint = My.Resources.NavigationDescription

			AllowCustomizationMenuList.Add(bsiNavigation)
			AllowCustomizationMenuList.Add(skinDropDownButtonItem1)
			ribbonControl1.Toolbar.ItemLinks.Add(skinDropDownButtonItem1)
			AllowCustomizationMenuList.Add(skinPaletteRibbonGalleryBarItem1)
			ribbonControl1.Toolbar.ItemLinks.Add(skinPaletteRibbonGalleryBarItem1)
		End Sub

		Private Sub InitGalleryItem(ByVal galleryItem As GalleryItem, ByVal tag As String, ByVal description As String)
			galleryItem.Tag = tag
			galleryItem.Hint = description
		End Sub
		Friend ReadOnly Property ZoomManager() As ZoomManager
			Get
				Return zoomManager_Renamed
			End Get
		End Property
		Friend ReadOnly Property SaveAsMenuItem() As BackstageViewButtonItem
			Get
				Return bvbiSaveAs
			End Get
		End Property
		Friend ReadOnly Property SaveAttachmentMenuItem() As BackstageViewButtonItem
			Get
				Return bvbiSaveAttachment
			End Get
		End Property
		Friend ReadOnly Property TaskGallery() As InRibbonGallery
			Get
				Return rgbiCurrentViewTasks.Gallery
			End Get
		End Property
		Friend ReadOnly Property FlagStatusMenu() As PopupMenu
			Get
				Return pmFlagStatus
			End Get
		End Property
		Private Sub InitBarButtonItem(ByVal buttonItem As DevExpress.XtraBars.BarButtonItem, ByVal tag As Object)
			InitBarButtonItem(buttonItem, tag, String.Empty)
		End Sub
		Private Sub InitBarButtonItem(ByVal buttonItem As DevExpress.XtraBars.BarButtonItem, ByVal tag As Object, ByVal description As String)
			AddHandler buttonItem.ItemClick, AddressOf bbi_ItemClick
			buttonItem.Hint = description
			buttonItem.Tag = tag
		End Sub
		Private Sub InitNavBarItemLinks()
			nbiGrid.Tag = New NavBarGroupTagObject("Tasks", GetType(DevExpress.ProductsDemo.Win.Modules.GridModule))
			nbiGridCardView.Tag = New NavBarGroupTagObject("Contacts", GetType(DevExpress.ProductsDemo.Win.Modules.Contacts))
			nbiSpreadsheet.Tag = New NavBarGroupTagObject("Spreadsheet", GetType(DevExpress.ProductsDemo.Win.Modules.SpreadsheetModule), RibbonControlColorScheme.Green)
			nbiWord.Tag = New NavBarGroupTagObject("Word", GetType(DevExpress.ProductsDemo.Win.Modules.WordModule), RibbonControlColorScheme.DarkBlue)
			nbiSnap.Tag = New NavBarGroupTagObject("Snap", GetType(DevExpress.ProductsDemo.Win.Modules.SnapModule), RibbonControlColorScheme.Teal)
			nbiReports.Tag = New NavBarGroupTagObject("Reports", GetType(DevExpress.ProductsDemo.Win.Modules.ReportsModule), RibbonControlColorScheme.Teal)
			nbiPivot.Tag = New NavBarGroupTagObject("Pivot", GetType(DevExpress.ProductsDemo.Win.Modules.PivotModuleNew))
			nbiCharts.Tag = New NavBarGroupTagObject("Charts", GetType(DevExpress.ProductsDemo.Win.Modules.AnalyticsModule))
			nbiScheduler.Tag = New NavBarGroupTagObject("Scheduler", GetType(DevExpress.ProductsDemo.Win.Modules.SchedulerModule), RibbonControlColorScheme.Purple)
			nbiPdf.Tag = New NavBarGroupTagObject("PdfViewer", GetType(DevExpress.ProductsDemo.Win.Modules.PdfViewerModule), RibbonControlColorScheme.Orange)
			nbiMaps.Tag = New NavBarGroupTagObject("Maps", GetType(DevExpress.ProductsDemo.Win.Modules.MapsModule), RibbonControlColorScheme.Red)
			nbgModules.SelectedLinkIndex = 0
		End Sub
		Friend Sub EnableLayoutButtons(ByVal enabled As Boolean)
			bbiFlipLayout.Enabled = enabled
		End Sub
		Friend Sub EnableEditContact(ByVal enabled As Boolean)
			bbiDeleteContact.Enabled = enabled
			bbiEditContact.Enabled = enabled
		End Sub
		Friend Sub EnabledFlagButtons(ByVal enabledCurrentTask As Boolean, ByVal enabledEdit As Boolean, ByVal task As Task)
			Dim list As New List(Of BarButtonItem) From {bbiTodayFlag, bbiTomorrowFlag, bbiThisWeekFlag, bbiNextWeekFlag, bbiNoDateFlag, bbiCustomFlag}
			For Each item As BarButtonItem In list
				item.Enabled = enabledCurrentTask
				If task IsNot Nothing Then
					item.Down = task.FlagStatus.Equals(item.Tag)
				Else
					item.Down = False
				End If
			Next item
			bbiDeleteTask.Enabled = enabledCurrentTask
			bbiEditTask.Enabled = enabledEdit
		End Sub
		Friend Sub EnableZoomControl(ByVal enabled As Boolean)
			beiZoom.Visibility = If(enabled, BarItemVisibility.Always, BarItemVisibility.Never)
		End Sub
        Friend Sub ShowInfo(ByVal count As Integer)
            If count < 0 Then
                bsiInfo.Caption = String.Empty
            Else
                bsiInfo.Caption = String.Format(My.Resources.InfoText, count)
            End If
            HtmlText = "Build Your Own Office" ' string.Format("{0}{1}", GetModuleName(), GetModulePartName());
        End Sub
        Private Function GetModuleName() As String
			If String.IsNullOrEmpty(modulesNavigator.CurrentModule.PartName) Then
				Return CurrentModuleName
			End If
			Return String.Format("<b>{0}</b>", CurrentModuleName)
		End Function
		Private Function GetModulePartName() As String
			If String.IsNullOrEmpty(modulesNavigator.CurrentModule.PartName) Then
				Return Nothing
			End If
			Return String.Format(" - {0}", modulesNavigator.CurrentModule.PartName)
		End Function
		Private Sub navBarControl1_SelectedLinkChanged(ByVal sender As Object, ByVal e As XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventArgs) Handles navBarControl1.SelectedLinkChanged
			If e.Link IsNot Nothing Then
				modulesNavigator.ChangeSelectedItem(e.Link, Nothing)
			End If
		End Sub
		Private Sub bbi_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
			modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
		End Sub
		Private Sub frmMain_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
			modulesNavigator.CurrentModule.SendKeyDown(e)
		End Sub
		Private Sub navBarControl1_NavPaneStateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles navBarControl1.NavPaneStateChanged
			SetPageLayoutStyle()
		End Sub
		Private Sub bvbiExit_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvbiExit.ItemClick
			Me.Close()
		End Sub

		Private Sub galleryControlGallery1_ItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles rgbiCurrentView.GalleryItemClick
			modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
		End Sub

		Private Sub backstageViewControl1_ItemClick(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles backstageViewControl1.ItemClick
			If modulesNavigator.CurrentModule Is Nothing Then
				Return
			End If
			modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
		End Sub
		Private Sub SetPageLayoutStyle()
			bbiNormal.Down = navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded
			bbiReading.Down = navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed
		End Sub

		Private Sub bbiNormal_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiNormal.ItemClick
			If bbiNormal.Down Then
				navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded
			Else
				bbiNormal.Down = True
			End If
		End Sub

		Private Sub bbiReading_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiReading.ItemClick
			If bbiReading.Down Then
				navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed
			Else
				bbiReading.Down = True
			End If
		End Sub

		Private Sub rgbiCurrentView_GalleryInitDropDownGallery(ByVal sender As Object, ByVal e As InplaceGalleryEventArgs) Handles rgbiCurrentViewTasks.GalleryInitDropDownGallery, rgbiCurrentView.GalleryInitDropDownGallery
			e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiManageView)
			e.PopupGallery.GalleryDropDown.ItemLinks.Add(bbiSaveCurrentView)
			e.PopupGallery.SynchWithInRibbonGallery = True
		End Sub

		Private Sub rgbiCurrentViewTasks_GalleryItemClick(ByVal sender As Object, ByVal e As GalleryItemClickEventArgs) Handles rgbiCurrentViewTasks.GalleryItemClick
			modulesNavigator.CurrentModule.ButtonClick(String.Format("{0}", e.Item.Tag))
		End Sub

		Private Sub bvtiPrint_SelectedChanged(ByVal sender As Object, ByVal e As BackstageViewItemEventArgs) Handles bvtiPrint.SelectedChanged
			If backstageViewControl1.SelectedTab Is bvtiPrint Then
				Me.printControl1.InitPrintingSystem()
			End If
		End Sub
		Private Sub ribbonControl1_BeforeApplicationButtonContentControlShow(ByVal sender As Object, ByVal e As EventArgs) Handles ribbonControl1.BeforeApplicationButtonContentControlShow
			If backstageViewControl1.SelectedTab Is bvtiPrint Then
				backstageViewControl1.SelectedTab = bvtiInfo
			End If
			bvtiPrint.Enabled = CurrentRichEdit IsNot Nothing OrElse CurrentPrintableComponent IsNot Nothing
			bvtiExport.Enabled = CurrentExportComponent IsNot Nothing
		End Sub
		Public ReadOnly Property CurrentPrintableComponent() As IPrintable
			Get
				Return modulesNavigator.CurrentModule.PrintableComponent
			End Get
		End Property
		Public ReadOnly Property CurrentExportComponent() As IPrintable
			Get
				Return modulesNavigator.CurrentModule.ExportComponent
			End Get
		End Property
		Public ReadOnly Property CurrentRichEdit() As RichEditControl
			Get
				Return modulesNavigator.CurrentModule.CurrentRichEdit
			End Get
		End Property
		Public ReadOnly Property CurrentModuleName() As String
			Get
				Return modulesNavigator.CurrentModule.ModuleName
			End Get
		End Property

		Private Sub ribbonControl1_ShowCustomizationMenu(ByVal sender As Object, ByVal e As RibbonCustomizationMenuEventArgs) Handles ribbonControl1.ShowCustomizationMenu
			e.CustomizationMenu.InitializeMenu()
			If e.Link Is Nothing OrElse Not AllowCustomizationMenuList.Contains(e.Link.Item) Then
				e.CustomizationMenu.RemoveLink(e.CustomizationMenu.ItemLinks(0))
			End If
		End Sub
		Public ReadOnly Property RibbonStatusBar() As RibbonStatusBar
			Get
				Return ribbonStatusBar1
			End Get
		End Property
		Friend Sub ShowReminder(ByVal reminders As List(Of Task))
			Dim allowReminders As Boolean = reminders IsNot Nothing AndAlso reminders.Count > 0
			bbiReminder.Visibility = If(allowReminders, BarItemVisibility.Always, BarItemVisibility.Never)
			bsiTemp.Visibility = If(allowReminders, BarItemVisibility.Never, BarItemVisibility.Always)
			If allowReminders Then
				bbiReminder.Caption = String.Format(My.Resources.ReminderText, reminders.Count)
				bbiReminder.Tag = reminders
			End If
		End Sub
		Public Sub ShowInfo(ByVal visible As Boolean)
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: bsiInfo.Visibility = bsiTemp.Visibility = visible ? BarItemVisibility.Always : BarItemVisibility.Never;
			bsiTemp.Visibility = If(visible, BarItemVisibility.Always, BarItemVisibility.Never)
			bsiInfo.Visibility = bsiTemp.Visibility
		End Sub

		Private Sub biPrintPreview_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles biPrintPreview.ItemClick
			ShowPrintPreview()
		End Sub
		Protected Sub ShowPrintPreview()
			If CurrentPrintableComponent Is Nothing Then
				Return
			End If
			Dim link As New PrintableComponentLink(New PrintingSystem())
			If modulesNavigator.CurrentModule.AllowRtfTitle Then
				link.RtfReportHeader = "{\rtf1\ansi\ansicpg1251\deff0\deflang1049{\fonttbl{\f0\fnil\fcharset0 Segoe UI;}}" & vbCrLf & _
"{\*\generator Msftedit 5.41.21.2510;}\viewkind4\uc1\pard\sa200\sl276\slmult1\qc\lang9\f0\fs32 " & CurrentModuleName & "\par" & vbCrLf & _
"}"
			End If
			link.Component = CurrentPrintableComponent
			link.CreateDocument()
			link.ShowRibbonPreviewDialog(Me.LookAndFeel)
		End Sub

		Friend Sub OnModuleShown(ByVal baseModule As BaseModule)
			rpgPrint.Visible = CurrentPrintableComponent IsNot Nothing
		End Sub

		Private Sub bbiReminder_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs) Handles bbiReminder.ItemClick
			Using frm As New frmReminders()
				frm.InitData(TryCast(bbiReminder.Tag, List(Of Task)))
				If frm.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK Then
					modulesNavigator.CurrentModule.FocusObject(frm.CurrentTask)
					modulesNavigator.CurrentModule.ButtonClick(TagResources.TaskEdit)
				End If
			End Using

		End Sub
	End Class
End Namespace
