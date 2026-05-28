Namespace DevExpress.ProductsDemo.Win
	Partial Public Class frmMain
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
			Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem1 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem2 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem3 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem4 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem5 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem6 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem7 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem8 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
			Dim galleryItem9 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem10 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem11 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Dim galleryItem12 As New DevExpress.XtraBars.Ribbon.GalleryItem()
			Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
			Me.backstageViewControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
			Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.helpControl1 = New DevExpress.ProductsDemo.Win.Controls.HelpControl()
			Me.backstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.printControl1 = New DevExpress.ProductsDemo.Win.Controls.PrintControl()
			Me.backstageViewClientControl4 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
			Me.exportControl1 = New DevExpress.ProductsDemo.Win.Controls.ExportControl()
			Me.bvbiSaveAs = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvbiSaveAttachment = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bvtiInfo = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvtiExport = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
			Me.bvbiExit = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
			Me.bsiNavigation = New DevExpress.XtraBars.BarSubItem()
			Me.bsiInfo = New DevExpress.XtraBars.BarStaticItem()
			Me.beiZoom = New DevExpress.XtraBars.BarEditItem()
			Me.repositoryItemZoomTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
			Me.bbiNormal = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReading = New DevExpress.XtraBars.BarButtonItem()
			Me.bsiTemp = New DevExpress.XtraBars.BarStaticItem()
			Me.bbiManageView = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiSaveCurrentView = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiCurrentViewTasks = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.bbiTodayFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiTomorrowFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiThisWeekFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNextWeekFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNoDateFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiCustomFlag = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteTask = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiNewContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiEditContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiDeleteContact = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiFlipLayout = New DevExpress.XtraBars.BarButtonItem()
			Me.rgbiCurrentView = New DevExpress.XtraBars.RibbonGalleryBarItem()
			Me.biPrintPreview = New DevExpress.XtraBars.BarButtonItem()
			Me.bbiReminder = New DevExpress.XtraBars.BarButtonItem()
			Me.skinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
			Me.skinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
			Me.rpTasks = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgTasks = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgFollowUp = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpdCurrentViewTasks = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpContacts = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgContacts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgCurrentView = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgLayoutContacts = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpView = New DevExpress.XtraBars.Ribbon.RibbonPage()
			Me.rpgNavigation = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.prgAppearance = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.rpgPrint = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.repositoryItemDuration1 = New DevExpress.XtraScheduler.UI.RepositoryItemDuration()
			Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
			Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
			Me.nbgModules = New DevExpress.XtraNavBar.NavBarGroup()
			Me.nbiGrid = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiGridCardView = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiSpreadsheet = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiWord = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiSnap = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiReports = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiPivot = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiCharts = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiMaps = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiScheduler = New DevExpress.XtraNavBar.NavBarItem()
			Me.nbiPdf = New DevExpress.XtraNavBar.NavBarItem()
			Me.pcMain = New DevExpress.XtraEditors.PanelControl()
			Me.pmFlagStatus = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.backstageViewControl1.SuspendLayout()
			Me.backstageViewClientControl1.SuspendLayout()
			Me.backstageViewClientControl3.SuspendLayout()
			Me.backstageViewClientControl4.SuspendLayout()
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.pcMain, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.pcMain.SuspendLayout()
			CType(Me.pmFlagStatus, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' ribbonControl1
			' 
			Me.ribbonControl1.ApplicationButtonDropDownControl = Me.backstageViewControl1
			Me.ribbonControl1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() { (CType(resources.GetObject("ribbonControl1.Categories"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories1"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories2"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories3"), DevExpress.XtraBars.BarManagerCategory)), (CType(resources.GetObject("ribbonControl1.Categories4"), DevExpress.XtraBars.BarManagerCategory))})
			Me.ribbonControl1.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Teal
			Me.ribbonControl1.ExpandCollapseItem.Id = 0
			Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.ribbonControl1.SearchEditItem, Me.bsiNavigation, Me.bsiInfo, Me.beiZoom, Me.bbiNormal, Me.bbiReading, Me.bsiTemp, Me.bbiManageView, Me.bbiSaveCurrentView, Me.rgbiCurrentViewTasks, Me.bbiTodayFlag, Me.bbiTomorrowFlag, Me.bbiThisWeekFlag, Me.bbiNextWeekFlag, Me.bbiNoDateFlag, Me.bbiCustomFlag, Me.bbiNewTask, Me.bbiEditTask, Me.bbiDeleteTask, Me.bbiNewContact, Me.bbiEditContact, Me.bbiDeleteContact, Me.bbiFlipLayout, Me.rgbiCurrentView, Me.biPrintPreview, Me.bbiReminder, Me.skinDropDownButtonItem1, Me.skinPaletteRibbonGalleryBarItem1})
			resources.ApplyResources(Me.ribbonControl1, "ribbonControl1")
			Me.ribbonControl1.MaxItemId = 107
			Me.ribbonControl1.Name = "ribbonControl1"
			Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.rpTasks, Me.rpContacts, Me.rpView})
			Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemZoomTrackBar1, Me.repositoryItemSpinEdit1, Me.repositoryItemDuration1})
			Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
			Me.ribbonControl1.StatusBar = Me.ribbonStatusBar1
			Me.ribbonControl1.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.ribbonControl1.BeforeApplicationButtonContentControlShow += new System.EventHandler(this.ribbonControl1_BeforeApplicationButtonContentControlShow);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.ribbonControl1.ShowCustomizationMenu += new DevExpress.XtraBars.Ribbon.RibbonCustomizationMenuEventHandler(this.ribbonControl1_ShowCustomizationMenu);
			' 
			' backstageViewControl1
			' 
			Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl1)
			Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl3)
			Me.backstageViewControl1.Controls.Add(Me.backstageViewClientControl4)
			Me.backstageViewControl1.Items.Add(Me.bvbiSaveAs)
			Me.backstageViewControl1.Items.Add(Me.bvbiSaveAttachment)
			Me.backstageViewControl1.Items.Add(Me.bvtiInfo)
			Me.backstageViewControl1.Items.Add(Me.bvtiPrint)
			Me.backstageViewControl1.Items.Add(Me.bvtiExport)
			Me.backstageViewControl1.Items.Add(Me.bvbiExit)
			resources.ApplyResources(Me.backstageViewControl1, "backstageViewControl1")
			Me.backstageViewControl1.Name = "backstageViewControl1"
			Me.backstageViewControl1.OwnerControl = Me.ribbonControl1
			Me.backstageViewControl1.SelectedTab = Me.bvtiInfo
			Me.backstageViewControl1.SelectedTabIndex = 2
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.backstageViewControl1.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.backstageViewControl1_ItemClick);
			' 
			' backstageViewClientControl1
			' 
			Me.backstageViewClientControl1.Controls.Add(Me.helpControl1)
			resources.ApplyResources(Me.backstageViewClientControl1, "backstageViewClientControl1")
			Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
			' 
			' helpControl1
			' 
			resources.ApplyResources(Me.helpControl1, "helpControl1")
			Me.helpControl1.ForeColor = System.Drawing.Color.Transparent
			Me.helpControl1.Name = "helpControl1"
			' 
			' backstageViewClientControl3
			' 
			Me.backstageViewClientControl3.Controls.Add(Me.printControl1)
			resources.ApplyResources(Me.backstageViewClientControl3, "backstageViewClientControl3")
			Me.backstageViewClientControl3.Name = "backstageViewClientControl3"
			' 
			' printControl1
			' 
			resources.ApplyResources(Me.printControl1, "printControl1")
			Me.printControl1.ForeColor = System.Drawing.Color.Transparent
			Me.printControl1.Name = "printControl1"
			' 
			' backstageViewClientControl4
			' 
			Me.backstageViewClientControl4.Controls.Add(Me.exportControl1)
			resources.ApplyResources(Me.backstageViewClientControl4, "backstageViewClientControl4")
			Me.backstageViewClientControl4.Name = "backstageViewClientControl4"
			' 
			' exportControl1
			' 
			resources.ApplyResources(Me.exportControl1, "exportControl1")
			Me.exportControl1.ForeColor = System.Drawing.Color.Transparent
			Me.exportControl1.Name = "exportControl1"
			' 
			' bvbiSaveAs
			' 
			resources.ApplyResources(Me.bvbiSaveAs, "bvbiSaveAs")
			Me.bvbiSaveAs.Name = "bvbiSaveAs"
			' 
			' bvbiSaveAttachment
			' 
			resources.ApplyResources(Me.bvbiSaveAttachment, "bvbiSaveAttachment")
			Me.bvbiSaveAttachment.Name = "bvbiSaveAttachment"
			' 
			' bvtiInfo
			' 
			resources.ApplyResources(Me.bvtiInfo, "bvtiInfo")
			Me.bvtiInfo.ContentControl = Me.backstageViewClientControl1
			Me.bvtiInfo.Name = "bvtiInfo"
			Me.bvtiInfo.Selected = True
			' 
			' bvtiPrint
			' 
			resources.ApplyResources(Me.bvtiPrint, "bvtiPrint")
			Me.bvtiPrint.ContentControl = Me.backstageViewClientControl3
			Me.bvtiPrint.Name = "bvtiPrint"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.bvtiPrint.SelectedChanged += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvtiPrint_SelectedChanged);
			' 
			' bvtiExport
			' 
			resources.ApplyResources(Me.bvtiExport, "bvtiExport")
			Me.bvtiExport.ContentControl = Me.backstageViewClientControl4
			Me.bvtiExport.Name = "bvtiExport"
			' 
			' bvbiExit
			' 
			resources.ApplyResources(Me.bvbiExit, "bvbiExit")
			Me.bvbiExit.ImageOptions.ItemNormal.SvgImage = My.Resources.Close
			Me.bvbiExit.Name = "bvbiExit"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.bvbiExit.ItemClick += new DevExpress.XtraBars.Ribbon.BackstageViewItemEventHandler(this.bvbiExit_ItemClick);
			' 
			' bsiNavigation
			' 
			resources.ApplyResources(Me.bsiNavigation, "bsiNavigation")
			Me.bsiNavigation.Id = 16
			Me.bsiNavigation.ImageOptions.SvgImage = My.Resources.NavigationBar
			Me.bsiNavigation.Name = "bsiNavigation"
			' 
			' bsiInfo
			' 
			Me.bsiInfo.Id = 37
			Me.bsiInfo.Name = "bsiInfo"
			' 
			' beiZoom
			' 
			Me.beiZoom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.beiZoom.Edit = Me.repositoryItemZoomTrackBar1
			Me.beiZoom.EditValue = 10
			resources.ApplyResources(Me.beiZoom, "beiZoom")
			Me.beiZoom.Id = 38
			Me.beiZoom.Name = "beiZoom"
			' 
			' repositoryItemZoomTrackBar1
			' 
			Me.repositoryItemZoomTrackBar1.Alignment = DevExpress.Utils.VertAlignment.Center
			Me.repositoryItemZoomTrackBar1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.repositoryItemZoomTrackBar1.Maximum = 19
			Me.repositoryItemZoomTrackBar1.Middle = 10
			Me.repositoryItemZoomTrackBar1.Minimum = 1
			Me.repositoryItemZoomTrackBar1.Name = "repositoryItemZoomTrackBar1"
			' 
			' bbiNormal
			' 
			Me.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.bbiNormal.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiNormal, "bbiNormal")
			Me.bbiNormal.Id = 39
			Me.bbiNormal.ImageOptions.SvgImage = My.Resources.normal1
			Me.bbiNormal.Name = "bbiNormal"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.bbiNormal.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNormal_ItemClick);
			' 
			' bbiReading
			' 
			Me.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
			Me.bbiReading.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiReading, "bbiReading")
			Me.bbiReading.Id = 40
			Me.bbiReading.ImageOptions.SvgImage = My.Resources.reading1
			Me.bbiReading.Name = "bbiReading"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.bbiReading.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReading_ItemClick);
			' 
			' bsiTemp
			' 
			Me.bsiTemp.Id = 41
			Me.bsiTemp.Name = "bsiTemp"
			' 
			' bbiManageView
			' 
			resources.ApplyResources(Me.bbiManageView, "bbiManageView")
			Me.bbiManageView.Enabled = False
			Me.bbiManageView.Id = 42
			Me.bbiManageView.Name = "bbiManageView"
			' 
			' bbiSaveCurrentView
			' 
			resources.ApplyResources(Me.bbiSaveCurrentView, "bbiSaveCurrentView")
			Me.bbiSaveCurrentView.Enabled = False
			Me.bbiSaveCurrentView.Id = 43
			Me.bbiSaveCurrentView.Name = "bbiSaveCurrentView"
			' 
			' rgbiCurrentViewTasks
			' 
			resources.ApplyResources(Me.rgbiCurrentViewTasks, "rgbiCurrentViewTasks")
			' 
			' 
			' 
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Disabled.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.rgbiCurrentViewTasks.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentViewTasks.Gallery.ColumnCount = 4
			resources.ApplyResources(galleryItemGroup1, "galleryItemGroup1")
			resources.ApplyResources(galleryItem1, "galleryItem1")
			galleryItem1.ImageOptions.SvgImage = My.Resources.ListByDate
			galleryItem1.Tag = "TaskList"
			resources.ApplyResources(galleryItem2, "galleryItem2")
			galleryItem2.ImageOptions.SvgImage = My.Resources.ToDoList
			galleryItem2.Tag = "TaskToDoList"
			resources.ApplyResources(galleryItem3, "galleryItem3")
			galleryItem3.ImageOptions.SvgImage = My.Resources.Completed__2_
			galleryItem3.Tag = "TaskCompleted"
			resources.ApplyResources(galleryItem4, "galleryItem4")
			galleryItem4.Checked = True
			galleryItem4.ImageOptions.SvgImage = My.Resources.Today1
			galleryItem4.Tag = "TaskToday"
			resources.ApplyResources(galleryItem5, "galleryItem5")
			galleryItem5.ImageOptions.SvgImage = My.Resources.important
			galleryItem5.Tag = "TaskPrioritized"
			resources.ApplyResources(galleryItem6, "galleryItem6")
			galleryItem6.ImageOptions.SvgImage = My.Resources.Overdue
			galleryItem6.Tag = "TaskOverdue"
			resources.ApplyResources(galleryItem7, "galleryItem7")
			galleryItem7.ImageOptions.SvgImage = My.Resources.List
			galleryItem7.Tag = "TaskSimpleList"
			resources.ApplyResources(galleryItem8, "galleryItem8")
			galleryItem8.ImageOptions.SvgImage = My.Resources.Deferred
			galleryItem8.Tag = "TaskDeferred"
			galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6, galleryItem7, galleryItem8})
			Me.rgbiCurrentViewTasks.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
			Me.rgbiCurrentViewTasks.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.rgbiCurrentViewTasks.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
			Me.rgbiCurrentViewTasks.Gallery.RowCount = 2
			Me.rgbiCurrentViewTasks.Gallery.ShowItemText = True
			Me.rgbiCurrentViewTasks.Id = 44
			Me.rgbiCurrentViewTasks.Name = "rgbiCurrentViewTasks"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.rgbiCurrentViewTasks.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiCurrentViewTasks_GalleryItemClick);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.rgbiCurrentViewTasks.GalleryInitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.rgbiCurrentView_GalleryInitDropDownGallery);
			' 
			' bbiTodayFlag
			' 
			Me.bbiTodayFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiTodayFlag, "bbiTodayFlag")
			Me.bbiTodayFlag.Id = 45
			Me.bbiTodayFlag.ImageOptions.SvgImage = My.Resources.Today_Flag1
			Me.bbiTodayFlag.Name = "bbiTodayFlag"
			Me.bbiTodayFlag.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' bbiTomorrowFlag
			' 
			Me.bbiTomorrowFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiTomorrowFlag, "bbiTomorrowFlag")
			Me.bbiTomorrowFlag.Id = 46
			Me.bbiTomorrowFlag.ImageOptions.SvgImage = My.Resources.Tomorrow_Flag1
			Me.bbiTomorrowFlag.Name = "bbiTomorrowFlag"
			Me.bbiTomorrowFlag.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' bbiThisWeekFlag
			' 
			Me.bbiThisWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiThisWeekFlag, "bbiThisWeekFlag")
			Me.bbiThisWeekFlag.Id = 47
			Me.bbiThisWeekFlag.ImageOptions.SvgImage = My.Resources.ThisWeek_Flag1
			Me.bbiThisWeekFlag.Name = "bbiThisWeekFlag"
			Me.bbiThisWeekFlag.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' bbiNextWeekFlag
			' 
			Me.bbiNextWeekFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiNextWeekFlag, "bbiNextWeekFlag")
			Me.bbiNextWeekFlag.Id = 48
			Me.bbiNextWeekFlag.ImageOptions.SvgImage = My.Resources.NextWeek_Flag1
			Me.bbiNextWeekFlag.Name = "bbiNextWeekFlag"
			Me.bbiNextWeekFlag.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' bbiNoDateFlag
			' 
			Me.bbiNoDateFlag.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
			resources.ApplyResources(Me.bbiNoDateFlag, "bbiNoDateFlag")
			Me.bbiNoDateFlag.Id = 49
			Me.bbiNoDateFlag.ImageOptions.SvgImage = My.Resources.NoDate_Flag1
			Me.bbiNoDateFlag.Name = "bbiNoDateFlag"
			Me.bbiNoDateFlag.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' bbiCustomFlag
			' 
			resources.ApplyResources(Me.bbiCustomFlag, "bbiCustomFlag")
			Me.bbiCustomFlag.Id = 50
			Me.bbiCustomFlag.ImageOptions.SvgImage = My.Resources.Custom_Flag1
			Me.bbiCustomFlag.Name = "bbiCustomFlag"
			Me.bbiCustomFlag.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
			' 
			' bbiNewTask
			' 
			resources.ApplyResources(Me.bbiNewTask, "bbiNewTask")
			Me.bbiNewTask.Id = 54
			Me.bbiNewTask.ImageOptions.SvgImage = My.Resources.NewTask
			Me.bbiNewTask.Name = "bbiNewTask"
			' 
			' bbiEditTask
			' 
			resources.ApplyResources(Me.bbiEditTask, "bbiEditTask")
			Me.bbiEditTask.Id = 55
			Me.bbiEditTask.ImageOptions.SvgImage = My.Resources.EditTask
			Me.bbiEditTask.Name = "bbiEditTask"
			' 
			' bbiDeleteTask
			' 
			resources.ApplyResources(Me.bbiDeleteTask, "bbiDeleteTask")
			Me.bbiDeleteTask.Id = 56
			Me.bbiDeleteTask.ImageOptions.SvgImage = My.Resources.Delete
			Me.bbiDeleteTask.Name = "bbiDeleteTask"
			' 
			' bbiNewContact
			' 
			resources.ApplyResources(Me.bbiNewContact, "bbiNewContact")
			Me.bbiNewContact.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiNewContact.Id = 97
			Me.bbiNewContact.ImageOptions.SvgImage = My.Resources.NewContact
			Me.bbiNewContact.Name = "bbiNewContact"
			' 
			' bbiEditContact
			' 
			resources.ApplyResources(Me.bbiEditContact, "bbiEditContact")
			Me.bbiEditContact.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiEditContact.Id = 98
			Me.bbiEditContact.ImageOptions.SvgImage = My.Resources.EditContact
			Me.bbiEditContact.Name = "bbiEditContact"
			' 
			' bbiDeleteContact
			' 
			resources.ApplyResources(Me.bbiDeleteContact, "bbiDeleteContact")
			Me.bbiDeleteContact.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiDeleteContact.Id = 99
			Me.bbiDeleteContact.ImageOptions.SvgImage = My.Resources.Delete
			Me.bbiDeleteContact.Name = "bbiDeleteContact"
			' 
			' bbiFlipLayout
			' 
			resources.ApplyResources(Me.bbiFlipLayout, "bbiFlipLayout")
			Me.bbiFlipLayout.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiFlipLayout.Id = 100
			Me.bbiFlipLayout.ImageOptions.SvgImage = My.Resources.LayoutFlip
			Me.bbiFlipLayout.Name = "bbiFlipLayout"
			' 
			' rgbiCurrentView
			' 
			resources.ApplyResources(Me.rgbiCurrentView, "rgbiCurrentView")
			' 
			' 
			' 
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
			Me.rgbiCurrentView.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
			Me.rgbiCurrentView.Gallery.ColumnCount = 4
			resources.ApplyResources(galleryItemGroup2, "galleryItemGroup2")
			resources.ApplyResources(galleryItem9, "galleryItem9")
			galleryItem9.ImageOptions.SvgImage = My.Resources.List
			galleryItem9.Tag = "List"
			resources.ApplyResources(galleryItem10, "galleryItem10")
			galleryItem10.ImageOptions.SvgImage = My.Resources.SortAsc
			galleryItem10.Tag = "Alphabetical"
			resources.ApplyResources(galleryItem11, "galleryItem11")
			galleryItem11.ImageOptions.SvgImage = My.Resources.ByState
			galleryItem11.Tag = "ByState"
			resources.ApplyResources(galleryItem12, "galleryItem12")
			galleryItem12.Checked = True
			galleryItem12.ImageOptions.SvgImage = My.Resources.Card
			galleryItem12.Tag = "Card"
			galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { galleryItem9, galleryItem10, galleryItem11, galleryItem12})
			Me.rgbiCurrentView.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
			Me.rgbiCurrentView.Gallery.ImageSize = New System.Drawing.Size(32, 32)
			Me.rgbiCurrentView.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio
			Me.rgbiCurrentView.Gallery.RowCount = 1
			Me.rgbiCurrentView.Gallery.ShowItemText = True
			Me.rgbiCurrentView.Id = 101
			Me.rgbiCurrentView.Name = "rgbiCurrentView"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.rgbiCurrentView.GalleryItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.galleryControlGallery1_ItemClick);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.rgbiCurrentView.GalleryInitDropDownGallery += new DevExpress.XtraBars.Ribbon.InplaceGalleryEventHandler(this.rgbiCurrentView_GalleryInitDropDownGallery);
			' 
			' biPrintPreview
			' 
			resources.ApplyResources(Me.biPrintPreview, "biPrintPreview")
			Me.biPrintPreview.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.biPrintPreview.Id = 102
			Me.biPrintPreview.ImageOptions.SvgImage = My.Resources.PDFViewer_Preview
			Me.biPrintPreview.Name = "biPrintPreview"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.biPrintPreview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.biPrintPreview_ItemClick);
			' 
			' bbiReminder
			' 
			Me.bbiReminder.CategoryGuid = New System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537")
			Me.bbiReminder.Id = 103
			Me.bbiReminder.ImageOptions.SvgImage = My.Resources.reminder1
			Me.bbiReminder.Name = "bbiReminder"
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.bbiReminder.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReminder_ItemClick);
			' 
			' skinDropDownButtonItem1
			' 
			Me.skinDropDownButtonItem1.Id = 105
			Me.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1"
			' 
			' skinPaletteRibbonGalleryBarItem1
			' 
			resources.ApplyResources(Me.skinPaletteRibbonGalleryBarItem1, "skinPaletteRibbonGalleryBarItem1")
			Me.skinPaletteRibbonGalleryBarItem1.Id = 106
			Me.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1"
			' 
			' rpTasks
			' 
			Me.rpTasks.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgTasks, Me.rpgFollowUp, Me.rpdCurrentViewTasks})
			Me.rpTasks.Name = "rpTasks"
			Me.rpTasks.Tag = "Tasks"
			resources.ApplyResources(Me.rpTasks, "rpTasks")
			' 
			' rpgTasks
			' 
			Me.rpgTasks.ItemLinks.Add(Me.bbiNewTask)
			Me.rpgTasks.ItemLinks.Add(Me.bbiEditTask)
			Me.rpgTasks.ItemLinks.Add(Me.bbiDeleteTask, True)
			Me.rpgTasks.Name = "rpgTasks"
			Me.rpgTasks.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgTasks, "rpgTasks")
			' 
			' rpgFollowUp
			' 
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiTodayFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiTomorrowFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiThisWeekFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiNextWeekFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiNoDateFlag)
			Me.rpgFollowUp.ItemLinks.Add(Me.bbiCustomFlag)
			Me.rpgFollowUp.Name = "rpgFollowUp"
			Me.rpgFollowUp.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgFollowUp, "rpgFollowUp")
			' 
			' rpdCurrentViewTasks
			' 
			Me.rpdCurrentViewTasks.ItemLinks.Add(Me.rgbiCurrentViewTasks)
			Me.rpdCurrentViewTasks.Name = "rpdCurrentViewTasks"
			Me.rpdCurrentViewTasks.ShowCaptionButton = False
			resources.ApplyResources(Me.rpdCurrentViewTasks, "rpdCurrentViewTasks")
			' 
			' rpContacts
			' 
			Me.rpContacts.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgContacts, Me.rpgCurrentView, Me.rpgLayoutContacts})
			Me.rpContacts.Name = "rpContacts"
			Me.rpContacts.Tag = "Contacts"
			resources.ApplyResources(Me.rpContacts, "rpContacts")
			' 
			' rpgContacts
			' 
			Me.rpgContacts.ItemLinks.Add(Me.bbiNewContact)
			Me.rpgContacts.ItemLinks.Add(Me.bbiEditContact)
			Me.rpgContacts.ItemLinks.Add(Me.bbiDeleteContact, True)
			Me.rpgContacts.Name = "rpgContacts"
			Me.rpgContacts.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgContacts, "rpgContacts")
			' 
			' rpgCurrentView
			' 
			Me.rpgCurrentView.ItemLinks.Add(Me.rgbiCurrentView)
			Me.rpgCurrentView.Name = "rpgCurrentView"
			Me.rpgCurrentView.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgCurrentView, "rpgCurrentView")
			' 
			' rpgLayoutContacts
			' 
			Me.rpgLayoutContacts.ItemLinks.Add(Me.bbiFlipLayout)
			Me.rpgLayoutContacts.Name = "rpgLayoutContacts"
			Me.rpgLayoutContacts.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgLayoutContacts, "rpgLayoutContacts")
			' 
			' rpView
			' 
			Me.rpView.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.rpgNavigation, Me.prgAppearance, Me.rpgPrint})
			Me.rpView.Name = "rpView"
			resources.ApplyResources(Me.rpView, "rpView")
			' 
			' rpgNavigation
			' 
			Me.rpgNavigation.AllowTextClipping = False
			Me.rpgNavigation.ItemLinks.Add(Me.bsiNavigation)
			Me.rpgNavigation.Name = "rpgNavigation"
			Me.rpgNavigation.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgNavigation, "rpgNavigation")
			' 
			' prgAppearance
			' 
			Me.prgAppearance.ItemLinks.Add(Me.skinDropDownButtonItem1)
			Me.prgAppearance.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem1)
			Me.prgAppearance.Name = "prgAppearance"
			Me.prgAppearance.ShowCaptionButton = False
			resources.ApplyResources(Me.prgAppearance, "prgAppearance")
			' 
			' rpgPrint
			' 
			Me.rpgPrint.AllowTextClipping = False
			Me.rpgPrint.ItemLinks.Add(Me.biPrintPreview)
			Me.rpgPrint.Name = "rpgPrint"
			Me.rpgPrint.ShowCaptionButton = False
			resources.ApplyResources(Me.rpgPrint, "rpgPrint")
			' 
			' repositoryItemSpinEdit1
			' 
			resources.ApplyResources(Me.repositoryItemSpinEdit1, "repositoryItemSpinEdit1")
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default
			Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() { 200, 0, 0, 0})
			Me.repositoryItemSpinEdit1.MinValue = New Decimal(New Integer() { 10, 0, 0, 0})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' repositoryItemDuration1
			' 
			Me.repositoryItemDuration1.AllowNullInput = DevExpress.Utils.DefaultBoolean.False
			resources.ApplyResources(Me.repositoryItemDuration1, "repositoryItemDuration1")
			Me.repositoryItemDuration1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton((CType(resources.GetObject("repositoryItemDuration1.Buttons"), DevExpress.XtraEditors.Controls.ButtonPredefines)))})
			Me.repositoryItemDuration1.DisabledStateText = Nothing
			Me.repositoryItemDuration1.Name = "repositoryItemDuration1"
			Me.repositoryItemDuration1.ShowEmptyItem = True
			Me.repositoryItemDuration1.ValidateOnEnterKey = True
			' 
			' ribbonStatusBar1
			' 
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiInfo)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiNormal)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReading)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.beiZoom, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReminder, True)
			Me.ribbonStatusBar1.ItemLinks.Add(Me.bsiTemp, True)
			resources.ApplyResources(Me.ribbonStatusBar1, "ribbonStatusBar1")
			Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
			Me.ribbonStatusBar1.Ribbon = Me.ribbonControl1
			' 
			' navBarControl1
			' 
			Me.navBarControl1.ActiveGroup = Me.nbgModules
			resources.ApplyResources(Me.navBarControl1, "navBarControl1")
			Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() { Me.nbgModules})
			Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() { Me.nbiGrid, Me.nbiSpreadsheet, Me.nbiWord, Me.nbiSnap, Me.nbiReports, Me.nbiPivot, Me.nbiCharts, Me.nbiMaps, Me.nbiScheduler, Me.nbiGridCardView, Me.nbiPdf})
			Me.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInControl
			Me.navBarControl1.MenuManager = Me.ribbonControl1
			Me.navBarControl1.Name = "navBarControl1"
			Me.navBarControl1.NavigationPaneGroupClientHeight = 320
			Me.navBarControl1.OptionsNavPane.ExpandedWidth = (CInt(resources.GetObject("resource.ExpandedWidth")))
			Me.navBarControl1.OptionsNavPane.ShowOverflowButton = False
			Me.navBarControl1.OptionsNavPane.ShowOverflowPanel = False
			Me.navBarControl1.OptionsNavPane.ShowSplitter = False
			Me.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane
			Me.navBarControl1.StoreDefaultPaintStyleName = True
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.navBarControl1.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(this.navBarControl1_SelectedLinkChanged);
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.navBarControl1.NavPaneStateChanged += new System.EventHandler(this.navBarControl1_NavPaneStateChanged);
			' 
			' nbgModules
			' 
			resources.ApplyResources(Me.nbgModules, "nbgModules")
			Me.nbgModules.Expanded = True
			Me.nbgModules.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
			Me.nbgModules.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText
			Me.nbgModules.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGrid),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiGridCardView),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSpreadsheet),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiWord),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiSnap),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiReports),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPivot),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiCharts),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiMaps),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiScheduler),
				New DevExpress.XtraNavBar.NavBarItemLink(Me.nbiPdf)
			})
			Me.nbgModules.Name = "nbgModules"
			Me.nbgModules.NavigationPaneVisible = False
			Me.nbgModules.SelectedLinkIndex = 9
			' 
			' nbiGrid
			' 
			resources.ApplyResources(Me.nbiGrid, "nbiGrid")
			Me.nbiGrid.ImageOptions.SvgImage = My.Resources.GridTasks1
			Me.nbiGrid.Name = "nbiGrid"
			' 
			' nbiGridCardView
			' 
			resources.ApplyResources(Me.nbiGridCardView, "nbiGridCardView")
			Me.nbiGridCardView.ImageOptions.SvgImage = My.Resources.GridContacts1
			Me.nbiGridCardView.Name = "nbiGridCardView"
			' 
			' nbiSpreadsheet
			' 
			resources.ApplyResources(Me.nbiSpreadsheet, "nbiSpreadsheet")
			Me.nbiSpreadsheet.ImageOptions.SvgImage = My.Resources.Spreadsheet1
			Me.nbiSpreadsheet.Name = "nbiSpreadsheet"
			' 
			' nbiWord
			' 
			resources.ApplyResources(Me.nbiWord, "nbiWord")
			Me.nbiWord.ImageOptions.SvgImage = My.Resources.WordProcessing1
			Me.nbiWord.Name = "nbiWord"
			' 
			' nbiSnap
			' 
			resources.ApplyResources(Me.nbiSnap, "nbiSnap")
			Me.nbiSnap.ImageOptions.SvgImage = My.Resources.WYSIWYGReports1
			Me.nbiSnap.Name = "nbiSnap"
			' 
			' nbiReports
			' 
			resources.ApplyResources(Me.nbiReports, "nbiReports")
			Me.nbiReports.ImageOptions.SvgImage = My.Resources.BandedReports
			Me.nbiReports.Name = "nbiReports"
			' 
			' nbiPivot
			' 
			resources.ApplyResources(Me.nbiPivot, "nbiPivot")
			Me.nbiPivot.ImageOptions.SvgImage = My.Resources.Pivot1
			Me.nbiPivot.Name = "nbiPivot"
			' 
			' nbiCharts
			' 
			resources.ApplyResources(Me.nbiCharts, "nbiCharts")
			Me.nbiCharts.ImageOptions.SvgImage = My.Resources.Analytics1
			Me.nbiCharts.Name = "nbiCharts"
			' 
			' nbiMaps
			' 
			resources.ApplyResources(Me.nbiMaps, "nbiMaps")
			Me.nbiMaps.ImageOptions.SvgImage = My.Resources.WeatherMap1
			Me.nbiMaps.Name = "nbiMaps"
			' 
			' nbiScheduler
			' 
			resources.ApplyResources(Me.nbiScheduler, "nbiScheduler")
			Me.nbiScheduler.ImageOptions.SvgImage = My.Resources.Scheduler1
			Me.nbiScheduler.Name = "nbiScheduler"
			' 
			' nbiPdf
			' 
			resources.ApplyResources(Me.nbiPdf, "nbiPdf")
			Me.nbiPdf.ImageOptions.LargeImage = My.Resources.PDFViewer
			Me.nbiPdf.ImageOptions.SvgImage = My.Resources.PDFViewer_Preview
			Me.nbiPdf.Name = "nbiPdf"
			' 
			' pcMain
			' 
			Me.pcMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.pcMain.Controls.Add(Me.backstageViewControl1)
			resources.ApplyResources(Me.pcMain, "pcMain")
			Me.pcMain.Name = "pcMain"
			' 
			' pmFlagStatus
			' 
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiTodayFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiTomorrowFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiThisWeekFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiNextWeekFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiNoDateFlag)
			Me.pmFlagStatus.ItemLinks.Add(Me.bbiCustomFlag, True)
			Me.pmFlagStatus.Name = "pmFlagStatus"
			Me.pmFlagStatus.Ribbon = Me.ribbonControl1
			' 
			' frmMain
			' 
			resources.ApplyResources(Me, "$this")
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.Controls.Add(Me.pcMain)
			Me.Controls.Add(Me.navBarControl1)
			Me.Controls.Add(Me.ribbonStatusBar1)
			Me.Controls.Add(Me.ribbonControl1)
			Me.KeyPreview = True
			Me.Name = "frmMain"
			Me.Ribbon = Me.ribbonControl1
			Me.StatusBar = Me.ribbonStatusBar1
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
			CType(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.backstageViewControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.backstageViewControl1.ResumeLayout(False)
			Me.backstageViewClientControl1.ResumeLayout(False)
			Me.backstageViewClientControl3.ResumeLayout(False)
			Me.backstageViewClientControl4.ResumeLayout(False)
			CType(Me.repositoryItemZoomTrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemDuration1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.navBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.pcMain, System.ComponentModel.ISupportInitialize).EndInit()
			Me.pcMain.ResumeLayout(False)
			CType(Me.pmFlagStatus, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private WithEvents ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
		Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
		Private WithEvents navBarControl1 As DevExpress.XtraNavBar.NavBarControl
		Private pcMain As DevExpress.XtraEditors.PanelControl
		Private nbgModules As DevExpress.XtraNavBar.NavBarGroup
		Private rpTasks As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpView As DevExpress.XtraBars.Ribbon.RibbonPage
		Private rpgNavigation As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private prgAppearance As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bsiNavigation As DevExpress.XtraBars.BarSubItem
		Private WithEvents backstageViewControl1 As DevExpress.XtraBars.Ribbon.BackstageViewControl
		Private bvbiSaveAs As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private backstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private bvbiSaveAttachment As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private bvtiInfo As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private WithEvents bvbiExit As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem
		Private bsiInfo As DevExpress.XtraBars.BarStaticItem
		Private beiZoom As DevExpress.XtraBars.BarEditItem
		Private repositoryItemZoomTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar
		Private WithEvents bbiNormal As DevExpress.XtraBars.BarButtonItem
		Private WithEvents bbiReading As DevExpress.XtraBars.BarButtonItem
		Private bsiTemp As DevExpress.XtraBars.BarStaticItem
		Private bbiManageView As DevExpress.XtraBars.BarButtonItem
		Private bbiSaveCurrentView As DevExpress.XtraBars.BarButtonItem
		Private WithEvents rgbiCurrentViewTasks As DevExpress.XtraBars.RibbonGalleryBarItem
		Private rpdCurrentViewTasks As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private bbiTodayFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiTomorrowFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiThisWeekFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiNextWeekFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiNoDateFlag As DevExpress.XtraBars.BarButtonItem
		Private bbiCustomFlag As DevExpress.XtraBars.BarButtonItem
		Private rpgFollowUp As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private pmFlagStatus As DevExpress.XtraBars.PopupMenu
		Private backstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private printControl1 As DevExpress.ProductsDemo.Win.Controls.PrintControl
		Private WithEvents bvtiPrint As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private helpControl1 As DevExpress.ProductsDemo.Win.Controls.HelpControl
		Private backstageViewClientControl4 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl
		Private exportControl1 As DevExpress.ProductsDemo.Win.Controls.ExportControl
		Private bvtiExport As DevExpress.XtraBars.Ribbon.BackstageViewTabItem
		Private bbiNewTask As DevExpress.XtraBars.BarButtonItem
		Private bbiEditTask As DevExpress.XtraBars.BarButtonItem
		Private bbiDeleteTask As DevExpress.XtraBars.BarButtonItem
		Private rpgTasks As DevExpress.XtraBars.Ribbon.RibbonPageGroup
		Private repositoryItemDuration1 As DevExpress.XtraScheduler.UI.RepositoryItemDuration
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private nbiGrid As XtraNavBar.NavBarItem
		Private nbiSpreadsheet As XtraNavBar.NavBarItem
		Private nbiWord As XtraNavBar.NavBarItem
		Private nbiSnap As XtraNavBar.NavBarItem
		Private nbiReports As XtraNavBar.NavBarItem
		Private nbiPivot As XtraNavBar.NavBarItem
		Private nbiCharts As XtraNavBar.NavBarItem
		Private nbiMaps As XtraNavBar.NavBarItem
		Private nbiScheduler As XtraNavBar.NavBarItem
		Private nbiGridCardView As XtraNavBar.NavBarItem
		Private rpContacts As XtraBars.Ribbon.RibbonPage
		Private bbiNewContact As XtraBars.BarButtonItem
		Private bbiEditContact As XtraBars.BarButtonItem
		Private bbiDeleteContact As XtraBars.BarButtonItem
		Private bbiFlipLayout As XtraBars.BarButtonItem
		Private rpgContacts As XtraBars.Ribbon.RibbonPageGroup
		Private rpgCurrentView As XtraBars.Ribbon.RibbonPageGroup
		Private rpgLayoutContacts As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents rgbiCurrentView As XtraBars.RibbonGalleryBarItem
		Private nbiPdf As XtraNavBar.NavBarItem
		Private WithEvents biPrintPreview As XtraBars.BarButtonItem
		Private rpgPrint As XtraBars.Ribbon.RibbonPageGroup
		Private WithEvents bbiReminder As XtraBars.BarButtonItem
		Private skinDropDownButtonItem1 As XtraBars.SkinDropDownButtonItem
		Private skinPaletteRibbonGalleryBarItem1 As XtraBars.SkinPaletteRibbonGalleryBarItem
	End Class
End Namespace

