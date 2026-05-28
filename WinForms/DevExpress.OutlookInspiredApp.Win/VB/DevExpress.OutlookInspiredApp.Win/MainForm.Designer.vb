Namespace DevExpress.DevAV

    Partial Class MainForm

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.DevAV.MainForm))
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipTitleItem1 As DevExpress.Utils.ToolTipTitleItem = New DevExpress.Utils.ToolTipTitleItem()
            Dim transition1 As DevExpress.Utils.Animation.Transition = New DevExpress.Utils.Animation.Transition()
            Dim slideFadeTransition1 As DevExpress.Utils.Animation.SlideFadeTransition = New DevExpress.Utils.Animation.SlideFadeTransition()
            Me.modulesContainer = New DevExpress.XtraEditors.XtraUserControl()
            Me.notificationManager = New DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager(Me.components)
            Me.overviewControl = New DevExpress.DevAV.Modules.OverviewControl()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.backstageViewControl = New DevExpress.XtraBars.Ribbon.BackstageViewControl()
            Me.backstageViewClientControl1 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewClientControl2 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.backstageViewClientControl3 = New DevExpress.XtraBars.Ribbon.BackstageViewClientControl()
            Me.tabBackstageViewAbout = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.tabBackstageViewExport = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.tabBackstageViewPrint = New DevExpress.XtraBars.Ribbon.BackstageViewTabItem()
            Me.backstageViewItemSeparator1 = New DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator()
            Me.biBackstageViewGetStarted = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.biBackstageViewGetSupport = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.biBackstageViewBuyNow = New DevExpress.XtraBars.Ribbon.BackstageViewButtonItem()
            Me.bciShowChatControl = New DevExpress.XtraBars.BarCheckItem()
            Me.barNavigationItem = New DevExpress.XtraBars.BarSubItem()
            Me.biFolderPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiFolderNormal = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiFolderMinimized = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiFolderOff = New DevExpress.XtraBars.BarCheckItem()
            Me.biGetStarted = New DevExpress.XtraBars.BarButtonItem()
            Me.biGetSupport = New DevExpress.XtraBars.BarButtonItem()
            Me.biBuyNow = New DevExpress.XtraBars.BarButtonItem()
            Me.biAbout = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiNormal = New DevExpress.XtraBars.BarCheckItem()
            Me.beZoomLevel = New DevExpress.XtraBars.BarEditItem()
            Me.zoomLevelTrackBar = New DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar()
            Me.bbiReading = New DevExpress.XtraBars.BarCheckItem()
            Me.bbiZoomDialog = New DevExpress.XtraBars.BarButtonItem()
            Me.skinDropDownButtonItem1 = New DevExpress.XtraBars.SkinDropDownButtonItem()
            Me.skinPaletteRibbonGalleryBarItem1 = New DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem()
            Me.bciTrackWindowsAppMode = New DevExpress.XtraBars.BarCheckItem()
            Me.bciOriginalPalette = New DevExpress.XtraBars.BarCheckItem()
            Me.bciTrackWindowsAccentColor = New DevExpress.XtraBars.BarCheckItem()
            Me.bbiCustomColors = New DevExpress.XtraBars.BarButtonItem()
            Me.bbiCustomColors2 = New DevExpress.XtraBars.BarButtonItem()
            Me.fileBackstageViewButton = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.rpgAppearance = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.accentColorsRibbonPageGroup = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.transitionManager = New DevExpress.Utils.Animation.TransitionManager(Me.components)
            Me.mvvmContext = New DevExpress.Utils.MVVM.MVVMContext(Me.components)
            Me.accordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.chatControlPanel = New DevExpress.XtraEditors.SidePanel()
            CType((Me.notificationManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backstageViewControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.backstageViewControl.SuspendLayout()
            Me.backstageViewClientControl1.SuspendLayout()
            CType((Me.zoomLevelTrackBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.modulesContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modulesContainer.Location = New System.Drawing.Point(57, 121)
            Me.modulesContainer.Name = "modulesContainer"
            Me.modulesContainer.Size = New System.Drawing.Size(1011, 641)
            Me.modulesContainer.TabIndex = 2
            Me.notificationManager.ApplicationId = "devenv"
            Me.notificationManager.ApplicationName = "DevAV"
            Me.notificationManager.Notifications.AddRange(New DevExpress.XtraBars.ToastNotifications.IToastNotificationProperties() {New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf013", Global.DevExpress.DevAV.Properties.Resources.reports_360x664, Nothing, Global.DevExpress.DevAV.Properties.Resources.reports_96x96, Nothing, Nothing, Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, check out", "our WYSIWYG Reporting in the Sales Module", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.[Default], Nothing, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic), New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf014", Global.DevExpress.DevAV.Properties.Resources.map_360x664, Nothing, Global.DevExpress.DevAV.Properties.Resources.Map96x96, Nothing, Nothing, Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, take users ", "where they want to go with DevExpress Maps", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.[Default], Nothing, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic), New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf015", Global.DevExpress.DevAV.Properties.Resources.pdf_360x664, Nothing, Global.DevExpress.DevAV.Properties.Resources.pdf_96x96, Nothing, Nothing, Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, explore", "PDF-documents with DevExpress PDF Viewer", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.[Default], Nothing, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic), New DevExpress.XtraBars.ToastNotifications.ToastNotification("04d87d90-04d2-44a5-8d06-74dcf65cf016", Global.DevExpress.DevAV.Properties.Resources.Spreadsheet_360x664, Nothing, Global.DevExpress.DevAV.Properties.Resources.Spreadsheet_96x96, Nothing, Nothing, Nothing, "DevAV Tips & Tricks", "Become a UI Superhero, check out our", "straightforward and easy-to-use Spreadsheet", "Outlook Inspired App", DevExpress.XtraBars.ToastNotifications.ToastNotificationSound.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationDuration.[Default], Nothing, DevExpress.XtraBars.ToastNotifications.AppLogoCrop.[Default], DevExpress.XtraBars.ToastNotifications.ToastNotificationTemplate.Generic)})
            Me.overviewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.overviewControl.Location = New System.Drawing.Point(0, 0)
            Me.overviewControl.Name = "overviewControl"
            Me.overviewControl.Size = New System.Drawing.Size(878, 577)
            Me.overviewControl.TabIndex = 0
            Me.ribbonControl.ApplicationButtonDropDownControl = Me.backstageViewControl
            Me.ribbonControl.ApplicationButtonImageOptions.SvgImage = CType((resources.GetObject("ribbonControl.ApplicationButtonImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.ribbonControl.ApplicationButtonImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            toolTipTitleItem1.Text = "Hide navigation pane"
            superToolTip1.Items.Add(toolTipTitleItem1)
            Me.ribbonControl.ApplicationButtonSuperTip = superToolTip1
            Me.ribbonControl.CaptionBarItemLinks.Add(Me.bciShowChatControl)
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.bciShowChatControl, Me.ribbonControl.ExpandCollapseItem, Me.barNavigationItem, Me.biFolderPaneSubItem, Me.bmiFolderNormal, Me.bmiFolderMinimized, Me.bmiFolderOff, Me.biGetStarted, Me.biGetSupport, Me.biBuyNow, Me.biAbout, Me.bbiNormal, Me.beZoomLevel, Me.bbiReading, Me.bbiZoomDialog, Me.skinDropDownButtonItem1, Me.skinPaletteRibbonGalleryBarItem1, Me.bciTrackWindowsAppMode, Me.bciOriginalPalette, Me.bciTrackWindowsAccentColor, Me.bbiCustomColors, Me.bbiCustomColors2})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 21
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.OptionsMenuMinWidth = 220
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.fileBackstageViewButton, Me.ribbonPage2, Me.ribbonPage1})
            Me.ribbonControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.zoomLevelTrackBar})
            Me.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2019
            Me.ribbonControl.ShowToolbarCustomizeItem = False
            Me.ribbonControl.Size = New System.Drawing.Size(1368, 121)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl.Toolbar.ShowCustomizeItem = False
            Me.ribbonControl.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.[True]
            Me.backstageViewControl.Controls.Add(Me.backstageViewClientControl1)
            Me.backstageViewControl.Controls.Add(Me.backstageViewClientControl2)
            Me.backstageViewControl.Controls.Add(Me.backstageViewClientControl3)
            Me.backstageViewControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.backstageViewControl.Items.Add(Me.tabBackstageViewAbout)
            Me.backstageViewControl.Items.Add(Me.tabBackstageViewExport)
            Me.backstageViewControl.Items.Add(Me.tabBackstageViewPrint)
            Me.backstageViewControl.Items.Add(Me.backstageViewItemSeparator1)
            Me.backstageViewControl.Items.Add(Me.biBackstageViewGetStarted)
            Me.backstageViewControl.Items.Add(Me.biBackstageViewGetSupport)
            Me.backstageViewControl.Items.Add(Me.biBackstageViewBuyNow)
            Me.backstageViewControl.Location = New System.Drawing.Point(57, 121)
            Me.backstageViewControl.Name = "backstageViewControl"
            Me.backstageViewControl.OwnerControl = Me.ribbonControl
            Me.backstageViewControl.SelectedTab = Me.tabBackstageViewAbout
            Me.backstageViewControl.SelectedTabIndex = 0
            Me.backstageViewControl.Size = New System.Drawing.Size(1011, 641)
            Me.backstageViewControl.Style = DevExpress.XtraBars.Ribbon.BackstageViewStyle.Office2013
            Me.backstageViewControl.TabIndex = 6
            Me.backstageViewClientControl1.Controls.Add(Me.overviewControl)
            Me.backstageViewClientControl1.Location = New System.Drawing.Point(132, 63)
            Me.backstageViewClientControl1.Name = "backstageViewClientControl1"
            Me.backstageViewClientControl1.Size = New System.Drawing.Size(878, 577)
            Me.backstageViewClientControl1.TabIndex = 0
            Me.backstageViewClientControl2.Location = New System.Drawing.Point(132, 62)
            Me.backstageViewClientControl2.Name = "backstageViewClientControl2"
            Me.backstageViewClientControl2.Size = New System.Drawing.Size(979, 579)
            Me.backstageViewClientControl2.TabIndex = 1
            Me.backstageViewClientControl3.Location = New System.Drawing.Point(132, 62)
            Me.backstageViewClientControl3.Name = "backstageViewClientControl3"
            Me.backstageViewClientControl3.Size = New System.Drawing.Size(979, 579)
            Me.backstageViewClientControl3.TabIndex = 2
            Me.tabBackstageViewAbout.Caption = "About"
            Me.tabBackstageViewAbout.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.tabBackstageViewAbout.ContentControl = Me.backstageViewClientControl1
            Me.tabBackstageViewAbout.Name = "tabBackstageViewAbout"
            Me.tabBackstageViewAbout.Selected = True
            Me.tabBackstageViewExport.Caption = "Export"
            Me.tabBackstageViewExport.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.tabBackstageViewExport.ContentControl = Me.backstageViewClientControl2
            Me.tabBackstageViewExport.Name = "tabBackstageViewExport"
            Me.tabBackstageViewPrint.Caption = "Print"
            Me.tabBackstageViewPrint.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.tabBackstageViewPrint.ContentControl = Me.backstageViewClientControl3
            Me.tabBackstageViewPrint.Name = "tabBackstageViewPrint"
            Me.backstageViewItemSeparator1.Name = "backstageViewItemSeparator1"
            Me.biBackstageViewGetStarted.Caption = "Get Started"
            Me.biBackstageViewGetStarted.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.biBackstageViewGetStarted.Name = "biBackstageViewGetStarted"
            Me.biBackstageViewGetSupport.Caption = "Get Support"
            Me.biBackstageViewGetSupport.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.biBackstageViewGetSupport.Name = "biBackstageViewGetSupport"
            Me.biBackstageViewBuyNow.Caption = "Buy Now"
            Me.biBackstageViewBuyNow.CaptionHorizontalAlignment = DevExpress.Utils.Drawing.ItemHorizontalAlignment.Left
            Me.biBackstageViewBuyNow.Name = "biBackstageViewBuyNow"
            Me.bciShowChatControl.Caption = "AI Assistant"
            Me.bciShowChatControl.Id = 22
            Me.bciShowChatControl.ImageOptions.SvgImage = CType((resources.GetObject("bciShowChatControl.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.bciShowChatControl.Name = "bciShowChatControl"
            AddHandler Me.bciShowChatControl.CheckedChanged, AddressOf Me.bciShowChatControl_CheckedChanged
            Me.barNavigationItem.Caption = "Navigation"
            Me.barNavigationItem.Id = 2
            Me.barNavigationItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.barNavigationItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.barNavigationItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Navigation.svg"
            Me.barNavigationItem.ImageOptions.LargeImageIndex = 43
            Me.barNavigationItem.Name = "barNavigationItem"
            Me.barNavigationItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.biFolderPaneSubItem.Caption = "Folder Pane"
            Me.biFolderPaneSubItem.Id = 10
            Me.biFolderPaneSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biFolderPaneSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biFolderPaneSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.FolderPanel2.svg"
            Me.biFolderPaneSubItem.ImageOptions.LargeImageIndex = 42
            Me.biFolderPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiFolderNormal), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiFolderMinimized), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiFolderOff)})
            Me.biFolderPaneSubItem.Name = "biFolderPaneSubItem"
            Me.biFolderPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiFolderNormal.Caption = "Normal"
            Me.bmiFolderNormal.GroupIndex = 4
            Me.bmiFolderNormal.Id = 6
            Me.bmiFolderNormal.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiFolderNormal.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.panel-left-fill-dx_desktop-regular-blue-16." & "svg"
            Me.bmiFolderNormal.Name = "bmiFolderNormal"
            Me.bmiFolderMinimized.Caption = "Minimized"
            Me.bmiFolderMinimized.GroupIndex = 4
            Me.bmiFolderMinimized.Id = 7
            Me.bmiFolderMinimized.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiFolderMinimized.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.panel-left-minimized-fill-dx_desktop-regula" & "r-blue-16.svg"
            Me.bmiFolderMinimized.Name = "bmiFolderMinimized"
            Me.bmiFolderOff.Caption = "Off"
            Me.bmiFolderOff.GroupIndex = 4
            Me.bmiFolderOff.Id = 7
            Me.bmiFolderOff.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiFolderOff.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.panel-left-eye-off-dx_desktop-regular-black" & "-16.svg"
            Me.bmiFolderOff.Name = "bmiFolderOff"
            Me.biGetStarted.Caption = "Getting Started"
            Me.biGetStarted.Id = 3
            Me.biGetStarted.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biGetStarted.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetStarted.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.GettingStarted.svg"
            Me.biGetStarted.Name = "biGetStarted"
            Me.biGetSupport.Caption = "Support"
            Me.biGetSupport.Id = 4
            Me.biGetSupport.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biGetSupport.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biGetSupport.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Support.svg"
            Me.biGetSupport.Name = "biGetSupport"
            Me.biBuyNow.Caption = "Buy Now"
            Me.biBuyNow.Id = 5
            Me.biBuyNow.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biBuyNow.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biBuyNow.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Buy.svg"
            Me.biBuyNow.Name = "biBuyNow"
            Me.biAbout.Caption = "About"
            Me.biAbout.Id = 6
            Me.biAbout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biAbout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAbout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.About.svg"
            Me.biAbout.ItemShortcut = New DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F1)
            Me.biAbout.Name = "biAbout"
            Me.bbiNormal.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiNormal.BindableChecked = True
            Me.bbiNormal.Caption = "Normal"
            Me.bbiNormal.Checked = True
            Me.bbiNormal.Id = 8
            Me.bbiNormal.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.bbiNormal.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bbiNormal.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-normal-bottom-16.png"
            Me.bbiNormal.Name = "bbiNormal"
            Me.bbiNormal.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            Me.beZoomLevel.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.beZoomLevel.CaptionAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.beZoomLevel.Edit = Me.zoomLevelTrackBar
            Me.beZoomLevel.EditValue = 10
            Me.beZoomLevel.EditWidth = 150
            Me.beZoomLevel.Id = 9
            Me.beZoomLevel.Name = "beZoomLevel"
            Me.zoomLevelTrackBar.Alignment = DevExpress.Utils.VertAlignment.Center
            Me.zoomLevelTrackBar.AllowUseMiddleValue = True
            Me.zoomLevelTrackBar.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.zoomLevelTrackBar.Maximum = 20
            Me.zoomLevelTrackBar.Middle = 10
            Me.zoomLevelTrackBar.Minimum = 1
            Me.zoomLevelTrackBar.Name = "zoomLevelTrackBar"
            Me.bbiReading.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiReading.Caption = "Reading"
            Me.bbiReading.Id = 10
            Me.bbiReading.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
            Me.bbiReading.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bbiReading.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-reading-bottom-16.png"
            Me.bbiReading.Name = "bbiReading"
            Me.bbiReading.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            Me.bbiZoomDialog.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
            Me.bbiZoomDialog.Caption = "100%"
            Me.bbiZoomDialog.Id = 11
            Me.bbiZoomDialog.Name = "bbiZoomDialog"
            Me.bbiZoomDialog.SmallWithTextWidth = 50
            Me.skinDropDownButtonItem1.Id = 13
            Me.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1"
            Me.skinPaletteRibbonGalleryBarItem1.Caption = "Palettes"
            Me.skinPaletteRibbonGalleryBarItem1.Id = 15
            Me.skinPaletteRibbonGalleryBarItem1.Name = "skinPaletteRibbonGalleryBarItem1"
            Me.skinPaletteRibbonGalleryBarItem1.RememberLastCommand = True
            Me.bciTrackWindowsAppMode.Caption = "Track Window App Mode"
            Me.bciTrackWindowsAppMode.Id = 16
            Me.bciTrackWindowsAppMode.ImageOptions.ImageUri.Uri = "chart/treemap"
            Me.bciTrackWindowsAppMode.Name = "bciTrackWindowsAppMode"
            Me.bciOriginalPalette.Caption = "Original Palette"
            Me.bciOriginalPalette.Id = 17
            Me.bciOriginalPalette.Name = "bciOriginalPalette"
            Me.bciTrackWindowsAccentColor.Caption = "Track Window Accent Color"
            Me.bciTrackWindowsAccentColor.Id = 18
            Me.bciTrackWindowsAccentColor.Name = "bciTrackWindowsAccentColor"
            Me.bbiCustomColors.Caption = "Custom Colors"
            Me.bbiCustomColors.Id = 19
            Me.bbiCustomColors.Name = "bbiCustomColors"
            Me.bbiCustomColors2.Caption = "Custom Colors 2"
            Me.bbiCustomColors2.Id = 20
            Me.bbiCustomColors2.Name = "bbiCustomColors2"
            Me.fileBackstageViewButton.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1})
            Me.fileBackstageViewButton.Name = "fileBackstageViewButton"
            Me.fileBackstageViewButton.Text = "File"
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup4})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "Home"
            Me.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biGetStarted)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biGetSupport)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biBuyNow)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biAbout)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "DevExpress"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup3, Me.ribbonPageGroup2, Me.rpgAppearance, Me.accentColorsRibbonPageGroup})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "View"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barNavigationItem)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Module"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biFolderPaneSubItem)
            Me.ribbonPageGroup2.MergeOrder = 1
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Layout"
            Me.rpgAppearance.AllowTextClipping = False
            Me.rpgAppearance.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.rpgAppearance.ItemLinks.Add(Me.skinDropDownButtonItem1)
            Me.rpgAppearance.ItemLinks.Add(Me.skinPaletteRibbonGalleryBarItem1)
            Me.rpgAppearance.ItemLinks.Add(Me.bciTrackWindowsAppMode)
            Me.rpgAppearance.MergeOrder = 2
            Me.rpgAppearance.Name = "rpgAppearance"
            Me.rpgAppearance.Text = "Appearance"
            Me.accentColorsRibbonPageGroup.ItemLinks.Add(Me.bciOriginalPalette)
            Me.accentColorsRibbonPageGroup.ItemLinks.Add(Me.bciTrackWindowsAccentColor)
            Me.accentColorsRibbonPageGroup.ItemLinks.Add(Me.bbiCustomColors)
            Me.accentColorsRibbonPageGroup.ItemLinks.Add(Me.bbiCustomColors2)
            Me.accentColorsRibbonPageGroup.Name = "accentColorsRibbonPageGroup"
            Me.accentColorsRibbonPageGroup.Text = "Accent Colors"
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiNormal)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiReading)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.beZoomLevel)
            Me.ribbonStatusBar1.ItemLinks.Add(Me.bbiZoomDialog)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 762)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1368, 37)
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me.modulesContainer
            Me.dockManager.MenuManager = Me.ribbonControl
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
            Me.transitionManager.ShowWaitingIndicator = False
            transition1.Control = Me.modulesContainer
            slideFadeTransition1.Parameters.EffectOptions = DevExpress.Utils.Animation.PushEffectOptions.FromRight
            slideFadeTransition1.Parameters.FrameInterval = 5000
            transition1.TransitionType = slideFadeTransition1
            Me.transitionManager.Transitions.Add(transition1)
            Me.mvvmContext.ContainerControl = Me
            Me.mvvmContext.ViewModelType = GetType(DevExpress.DevAV.ViewModels.MainViewModel)
            Me.accordionControl1.AllowItemSelection = True
            Me.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.accordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement1})
            Me.accordionControl1.Location = New System.Drawing.Point(0, 49)
            Me.accordionControl1.MinimumSize = New System.Drawing.Size(0, 713)
            Me.accordionControl1.Name = "accordionControl1"
            Me.accordionControl1.OptionsFooter.ActiveGroupDisplayMode = DevExpress.XtraBars.Navigation.ActiveGroupDisplayMode.GroupHeaderAndContent
            Me.accordionControl1.OptionsHamburgerMenu.HighlightRootElements = DevExpress.Utils.DefaultBoolean.[True]
            Me.accordionControl1.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[False]
            Me.accordionControl1.OptionsMinimizing.CaptionShowMode = DevExpress.XtraBars.Navigation.CaptionShowMode.None
            Me.accordionControl1.OptionsMinimizing.State = DevExpress.XtraBars.Navigation.AccordionControlState.Minimized
            Me.accordionControl1.Size = New System.Drawing.Size(57, 713)
            Me.accordionControl1.TabIndex = 9
            Me.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
            Me.accordionControlElement1.ImageOptions.ImageUri.Uri = "Add"
            Me.accordionControlElement1.ImageOptions.SvgImageSize = New System.Drawing.Size(32, 32)
            Me.accordionControlElement1.Name = "accordionControlElement1"
            Me.accordionControlElement1.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement1.Text = "Element1"
            Me.chatControlPanel.Dock = System.Windows.Forms.DockStyle.Right
            Me.chatControlPanel.Location = New System.Drawing.Point(1068, 49)
            Me.chatControlPanel.MinimumSize = New System.Drawing.Size(0, 713)
            Me.chatControlPanel.Name = "chatControlPanel"
            Me.chatControlPanel.Size = New System.Drawing.Size(300, 713)
            Me.chatControlPanel.TabIndex = 1
            Me.chatControlPanel.Text = "AI Assistant"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1368, 799)
            Me.Controls.Add(Me.modulesContainer)
            Me.Controls.Add(Me.backstageViewControl)
            Me.Controls.Add(Me.chatControlPanel)
            Me.Controls.Add(Me.accordionControl1)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.IconOptions.Icon = CType((resources.GetObject("MainForm.IconOptions.Icon")), System.Drawing.Icon)
            Me.Name = "MainForm"
            Me.NavigationControl = Me.accordionControl1
            Me.NavigationControlLayoutMode = DevExpress.XtraBars.Ribbon.RibbonFormNavigationControlLayoutMode.StretchToFormTitle
            Me.Ribbon = Me.ribbonControl
            Me.SidePane = Me.chatControlPanel
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.StatusBar = Me.ribbonStatusBar1
            Me.Text = "DevAV"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType((Me.notificationManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backstageViewControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.backstageViewControl.ResumeLayout(False)
            Me.backstageViewClientControl1.ResumeLayout(False)
            CType((Me.zoomLevelTrackBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private rpgAppearance As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private transitionManager As DevExpress.Utils.Animation.TransitionManager

        Private notificationManager As DevExpress.XtraBars.ToastNotifications.ToastNotificationsManager

        Private modulesContainer As DevExpress.XtraEditors.XtraUserControl

        Private barNavigationItem As DevExpress.XtraBars.BarSubItem

        Private biGetStarted As DevExpress.XtraBars.BarButtonItem

        Private biGetSupport As DevExpress.XtraBars.BarButtonItem

        Private biBuyNow As DevExpress.XtraBars.BarButtonItem

        Private biAbout As DevExpress.XtraBars.BarButtonItem

        Private biFolderPaneSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiFolderNormal As DevExpress.XtraBars.BarCheckItem

        Private bmiFolderMinimized As DevExpress.XtraBars.BarCheckItem

        Private bmiFolderOff As DevExpress.XtraBars.BarCheckItem

        Private backstageViewControl As DevExpress.XtraBars.Ribbon.BackstageViewControl

        Private backstageViewClientControl1 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl

        Private backstageViewClientControl2 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl

        Private backstageViewClientControl3 As DevExpress.XtraBars.Ribbon.BackstageViewClientControl

        Private tabBackstageViewAbout As DevExpress.XtraBars.Ribbon.BackstageViewTabItem

        Private tabBackstageViewExport As DevExpress.XtraBars.Ribbon.BackstageViewTabItem

        Private tabBackstageViewPrint As DevExpress.XtraBars.Ribbon.BackstageViewTabItem

        Private backstageViewItemSeparator1 As DevExpress.XtraBars.Ribbon.BackstageViewItemSeparator

        Private biBackstageViewGetStarted As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem

        Private biBackstageViewGetSupport As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem

        Private biBackstageViewBuyNow As DevExpress.XtraBars.Ribbon.BackstageViewButtonItem

        Private overviewControl As DevExpress.DevAV.Modules.OverviewControl

        Private bbiNormal As DevExpress.XtraBars.BarCheckItem

        Private bbiReading As DevExpress.XtraBars.BarCheckItem

        Private beZoomLevel As DevExpress.XtraBars.BarEditItem

        Private zoomLevelTrackBar As DevExpress.XtraEditors.Repository.RepositoryItemZoomTrackBar

        Private bbiZoomDialog As DevExpress.XtraBars.BarButtonItem

        Private mvvmContext As DevExpress.Utils.MVVM.MVVMContext

        Private skinDropDownButtonItem1 As DevExpress.XtraBars.SkinDropDownButtonItem

        Private skinPaletteRibbonGalleryBarItem1 As DevExpress.XtraBars.SkinPaletteRibbonGalleryBarItem

        Private accordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private bciTrackWindowsAppMode As DevExpress.XtraBars.BarCheckItem

        Private accentColorsRibbonPageGroup As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private bciOriginalPalette As DevExpress.XtraBars.BarCheckItem

        Private bciTrackWindowsAccentColor As DevExpress.XtraBars.BarCheckItem

        Private bbiCustomColors As DevExpress.XtraBars.BarButtonItem

        Private bbiCustomColors2 As DevExpress.XtraBars.BarButtonItem

        Private fileBackstageViewButton As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private bciShowChatControl As DevExpress.XtraBars.BarCheckItem

        Private chatControlPanel As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
