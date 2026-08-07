Imports DevExpress.DevAV.Common.Utils

Namespace DevExpress.DevAV.Modules

    Partial Class Employees

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

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim galleryItemGroup2 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem6 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem7 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem8 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem9 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem10 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges3 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges4 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biNewEmployee = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biMap = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiNewEmployee = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biChangeViewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintProfile = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSummary = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintDirectory = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintTaskList = New DevExpress.XtraBars.BarButtonItem()
            Me.biMailMerge = New DevExpress.XtraBars.BarButtonItem()
            Me.biEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.galleryQuickLetters = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biMeeting = New DevExpress.XtraBars.BarButtonItem()
            Me.biTask = New DevExpress.XtraBars.BarButtonItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.biReverseSort = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddColumns = New DevExpress.XtraBars.BarCheckItem()
            Me.biExpandCollapse = New DevExpress.XtraBars.BarButtonItem()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.biNewCustomFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colPrefix = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDepartment = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colFullName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colZipCode = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBirthDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHireDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colHomePhone = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colMobilePhone1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemImageComboBox2 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.layoutView = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colFullName1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colFullName1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colAddress1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colAddress1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colEmail1 = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colEmail1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.colMobilePhone = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colMobilePhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.Item1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.roundedSkinPanelPnlView = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.mainRoundedPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.navigationRoundedPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colFullName1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colAddress1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colEmail1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colMobilePhone), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Item1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainRoundedPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainRoundedPanel.SuspendLayout()
            CType((Me.navigationRoundedPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biNewEmployee, Me.biNewGroup, Me.biDelete, Me.biShowList, Me.biShowCard, Me.biMap, Me.biNewSubItem, Me.biChangeViewSubItem, Me.biDataPaneSubItem, Me.bmiHideDetail, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.biResetView, Me.bmiShowList, Me.bmiShowCard, Me.bmiNewEmployee, Me.bmiNewGroup, Me.biPrintSubItem, Me.biMailMerge, Me.bmiPrintProfile, Me.bmiPrintSummary, Me.bmiPrintDirectory, Me.bmiPrintTaskList, Me.biEdit, Me.galleryQuickLetters, Me.biMeeting, Me.biTask, Me.biViewSettings, Me.biReverseSort, Me.biAddColumns, Me.biExpandCollapse, Me.hiItemsCount})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 8
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1280, 122)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.biNewEmployee.Caption = "New Employee"
            Me.biNewEmployee.Id = 1
            Me.biNewEmployee.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewEmployee.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewEmployee.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg"
            Me.biNewEmployee.Name = "biNewEmployee"
            Me.biNewGroup.Caption = "New Group"
            Me.biNewGroup.Id = 2
            Me.biNewGroup.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewGroup.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewGroup.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg"
            Me.biNewGroup.Name = "biNewGroup"
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 3
            Me.biDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biDelete.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biShowList.Caption = "List"
            Me.biShowList.GroupIndex = 1
            Me.biShowList.Id = 4
            Me.biShowList.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biShowList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg"
            Me.biShowList.ImageOptions.LargeImageIndex = 37
            Me.biShowList.Name = "biShowList"
            Me.biShowCard.Caption = "Card"
            Me.biShowCard.GroupIndex = 1
            Me.biShowCard.Id = 5
            Me.biShowCard.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biShowCard.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowCard.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg"
            Me.biShowCard.Name = "biShowCard"
            Me.biMap.Caption = "Map It"
            Me.biMap.Id = 8
            Me.biMap.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biMap.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMap.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biMap.Name = "biMap"
            Me.biNewSubItem.Caption = "New Items"
            Me.biNewSubItem.Id = 10
            Me.biNewSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewItem.svg"
            Me.biNewSubItem.ImageOptions.LargeImageIndex = 29
            Me.biNewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewEmployee), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewGroup)})
            Me.biNewSubItem.Name = "biNewSubItem"
            Me.biNewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiNewEmployee.Caption = "New Employee"
            Me.bmiNewEmployee.Id = 11
            Me.bmiNewEmployee.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bmiNewEmployee.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewEmployee.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewEmploye.svg?Size=16x16"
            Me.bmiNewEmployee.Name = "bmiNewEmployee"
            Me.bmiNewGroup.Caption = "New Group"
            Me.bmiNewGroup.Id = 12
            Me.bmiNewGroup.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bmiNewGroup.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewGroup.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewGroup.svg?Size=16x16"
            Me.bmiNewGroup.Name = "bmiNewGroup"
            Me.biChangeViewSubItem.Caption = "Change View"
            Me.biChangeViewSubItem.Id = 10
            Me.biChangeViewSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biChangeViewSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biChangeViewSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg"
            Me.biChangeViewSubItem.ImageOptions.LargeImageIndex = 40
            Me.biChangeViewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowList), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowCard)})
            Me.biChangeViewSubItem.Name = "biChangeViewSubItem"
            Me.biChangeViewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiShowList.Caption = "List"
            Me.bmiShowList.GroupIndex = 3
            Me.bmiShowList.Id = 4
            Me.bmiShowList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg?Size=32x32"
            Me.bmiShowList.Name = "bmiShowList"
            Me.bmiShowCard.Caption = "Card"
            Me.bmiShowCard.GroupIndex = 3
            Me.bmiShowCard.Id = 5
            Me.bmiShowCard.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowCard.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg?Size=32x32"
            Me.bmiShowCard.ImageOptions.LargeImageIndex = 34
            Me.bmiShowCard.Name = "bmiShowCard"
            Me.biDataPaneSubItem.Caption = "Data Pane"
            Me.biDataPaneSubItem.Id = 10
            Me.biDataPaneSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biDataPaneSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDataPaneSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg"
            Me.biDataPaneSubItem.ImageOptions.LargeImageIndex = 41
            Me.biDataPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHorizontalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiVerticalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHideDetail)})
            Me.biDataPaneSubItem.Name = "biDataPaneSubItem"
            Me.biDataPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiHorizontalLayout.Caption = "Right"
            Me.bmiHorizontalLayout.GroupIndex = 2
            Me.bmiHorizontalLayout.Id = 6
            Me.bmiHorizontalLayout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bmiHorizontalLayout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHorizontalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16"
            Me.bmiHorizontalLayout.Name = "bmiHorizontalLayout"
            Me.bmiVerticalLayout.Caption = "Bottom"
            Me.bmiVerticalLayout.GroupIndex = 2
            Me.bmiVerticalLayout.Id = 7
            Me.bmiVerticalLayout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bmiVerticalLayout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiVerticalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16"
            Me.bmiVerticalLayout.Name = "bmiVerticalLayout"
            Me.bmiHideDetail.Caption = "Off"
            Me.bmiHideDetail.GroupIndex = 2
            Me.bmiHideDetail.Id = 7
            Me.bmiHideDetail.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bmiHideDetail.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHideDetail.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelOff.svg?Size=16x16"
            Me.bmiHideDetail.Name = "bmiHideDetail"
            Me.biResetView.Caption = "Reset View"
            Me.biResetView.Id = 9
            Me.biResetView.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biResetView.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biResetView.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg"
            Me.biResetView.Name = "biResetView"
            Me.biPrintSubItem.Caption = "Print"
            Me.biPrintSubItem.Id = 10
            Me.biPrintSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biPrintSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrintSubItem.ImageOptions.LargeImageIndex = 30
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintProfile), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSummary), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintDirectory), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintTaskList)})
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiPrintProfile.Caption = "Employee Profile"
            Me.bmiPrintProfile.GroupIndex = 5
            Me.bmiPrintProfile.Id = 6
            Me.bmiPrintProfile.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintProfile.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-profile-16.png"
            Me.bmiPrintProfile.Name = "bmiPrintProfile"
            Me.bmiPrintSummary.Caption = "Summary Report"
            Me.bmiPrintSummary.GroupIndex = 5
            Me.bmiPrintSummary.Id = 6
            Me.bmiPrintSummary.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintSummary.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-summary-16.png"
            Me.bmiPrintSummary.Name = "bmiPrintSummary"
            Me.bmiPrintDirectory.Caption = "Directory"
            Me.bmiPrintDirectory.GroupIndex = 5
            Me.bmiPrintDirectory.Id = 6
            Me.bmiPrintDirectory.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintDirectory.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-directory-16.png"
            Me.bmiPrintDirectory.Name = "bmiPrintDirectory"
            Me.bmiPrintTaskList.Caption = "Task List"
            Me.bmiPrintTaskList.GroupIndex = 5
            Me.bmiPrintTaskList.Id = 6
            Me.bmiPrintTaskList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintTaskList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-employee-task-list-16.png"
            Me.bmiPrintTaskList.Name = "bmiPrintTaskList"
            Me.biMailMerge.Caption = "Mail Merge"
            Me.biMailMerge.Id = 10
            Me.biMailMerge.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biMailMerge.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMailMerge.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.MailMerge.svg"
            Me.biMailMerge.Name = "biMailMerge"
            Me.biEdit.Caption = "Edit"
            Me.biEdit.Id = 13
            Me.biEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biEdit.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biEdit.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg"
            Me.biEdit.Name = "biEdit"
            Me.galleryQuickLetters.Caption = "Quick Letter"
            Me.galleryQuickLetters.Gallery.ColumnCount = 2
            Me.galleryQuickLetters.Gallery.DrawImageBackground = False
            galleryItemGroup2.Caption = "Group1"
            galleryItem6.Caption = "Thank You Note"
            galleryItem6.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem6.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-thank-16.png" & ""
            galleryItem7.Caption = "Employee Award"
            galleryItem7.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem7.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-award-16.png" & ""
            galleryItem8.Caption = "Service Excellence"
            galleryItem8.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem8.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-exellece-16." & "png"
            galleryItem9.Caption = "Probation Notice"
            galleryItem9.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem9.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-probation-no" & "tice-16.png"
            galleryItem10.Caption = "Welcome To DevAV"
            galleryItem10.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem10.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-employee-quick-welcome-16.p" & "ng"
            galleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem6, galleryItem7, galleryItem8, galleryItem9, galleryItem10})
            Me.galleryQuickLetters.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup2})
            Me.galleryQuickLetters.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges3.Bottom = -3
            skinPaddingEdges3.Top = -3
            Me.galleryQuickLetters.Gallery.ItemImagePadding = skinPaddingEdges3
            skinPaddingEdges4.Bottom = -1
            skinPaddingEdges4.Top = -1
            Me.galleryQuickLetters.Gallery.ItemTextPadding = skinPaddingEdges4
            Me.galleryQuickLetters.Gallery.ShowItemText = True
            Me.galleryQuickLetters.Id = 15
            Me.galleryQuickLetters.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.galleryQuickLetters.ImageOptions.ImageUri.Uri = "business%20objects/bo_document"
            Me.galleryQuickLetters.Name = "galleryQuickLetters"
            Me.biMeeting.Caption = "Meeting"
            Me.biMeeting.Id = 1
            Me.biMeeting.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biMeeting.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMeeting.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Meeting.svg"
            Me.biMeeting.Name = "biMeeting"
            Me.biTask.Caption = "Task"
            Me.biTask.Id = 2
            Me.biTask.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biTask.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biTask.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Task.svg"
            Me.biTask.Name = "biTask"
            Me.biViewSettings.Caption = "View Settings"
            Me.biViewSettings.Id = 3
            Me.biViewSettings.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biViewSettings.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biViewSettings.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg"
            Me.biViewSettings.Name = "biViewSettings"
            Me.biReverseSort.Caption = "Reverse Sort"
            Me.biReverseSort.Id = 4
            Me.biReverseSort.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biReverseSort.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biReverseSort.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ReversSort.svg?Size=16x16"
            Me.biReverseSort.Name = "biReverseSort"
            AddHandler Me.biReverseSort.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biReverseSort_ItemClick)
            Me.biAddColumns.Caption = "Add Columns"
            Me.biAddColumns.Id = 5
            Me.biAddColumns.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biAddColumns.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAddColumns.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.AddColumn.svg?Size=16x16"
            Me.biAddColumns.Name = "biAddColumns"
            AddHandler Me.biAddColumns.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biAddColumns_ItemCheckedChanged)
            Me.biExpandCollapse.Caption = "Expand/Collapse"
            Me.biExpandCollapse.Id = 6
            Me.biExpandCollapse.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biExpandCollapse.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biExpandCollapse.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ExpandCollapse.svg?Size=16x16"
            Me.biExpandCollapse.Name = "biExpandCollapse"
            AddHandler Me.biExpandCollapse.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biExpandCollapse_ItemClick)
            Me.hiItemsCount.Caption = "Records: 0"
            Me.hiItemsCount.Id = 7
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup8, Me.ribbonPageGroup4, Me.ribbonPageGroup6})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewEmployee)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewGroup)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewSubItem)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "New"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Delete"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biEdit)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biPrintSubItem)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biMeeting)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biTask)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biMailMerge)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Actions"
            Me.ribbonPageGroup8.AllowTextClipping = False
            Me.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup8.ItemLinks.Add(Me.galleryQuickLetters)
            Me.ribbonPageGroup8.MergeOrder = 0
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonPageGroup8.Text = "Quick Letter"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowList)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowCard)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMap)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "View"
            Me.ribbonPageGroup6.AllowTextClipping = False
            Me.ribbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup6.ItemLinks.Add(Me.biNewCustomFilter)
            Me.ribbonPageGroup6.MergeOrder = 0
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded
            Me.ribbonPageGroup6.Text = "Find"
            Me.biNewCustomFilter.Caption = "Custom Filter"
            Me.biNewCustomFilter.Id = 9
            Me.biNewCustomFilter.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewCustomFilter.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomFilter.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg"
            Me.biNewCustomFilter.Name = "biNewCustomFilter"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup5, Me.ribbonPageGroup7, Me.ribbonPageGroup9})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "View"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biChangeViewSubItem)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biViewSettings)
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biResetView)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.Text = "Current View"
            Me.ribbonPageGroup7.AllowTextClipping = False
            Me.ribbonPageGroup7.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup7.ItemLinks.Add(Me.biDataPaneSubItem)
            Me.ribbonPageGroup7.MergeOrder = 1
            Me.ribbonPageGroup7.Name = "ribbonPageGroup7"
            Me.ribbonPageGroup7.Text = "Layout"
            Me.ribbonPageGroup9.AllowTextClipping = False
            Me.ribbonPageGroup9.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biReverseSort)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biAddColumns)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biExpandCollapse)
            Me.ribbonPageGroup9.MergeOrder = 1
            Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
            Me.ribbonStatusBar.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 763)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1280, 37)
            Me.gridControl.DataSource = Me.bindingSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl.Location = New System.Drawing.Point(119, 9)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(12)
            Me.gridControl.MenuManager = Me.ribbonControl
            Me.gridControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1, Me.repositoryItemImageComboBox2, Me.repositoryItemMemoEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(652, 623)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.layoutView})
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Employee)
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPrefix, Me.colDepartment, Me.colFullName, Me.colAddress, Me.colCity, Me.colState, Me.colZipCode, Me.colEmail, Me.colBirthDate, Me.colHireDate, Me.colHomePhone, Me.colMobilePhone1, Me.colTitle})
            Me.gridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.GroupCount = 1
            Me.gridView.GroupFormat = "[#image]{1} {2}"
            Me.gridView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Id", Nothing, "")})
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsFind.AlwaysVisible = True
            Me.gridView.OptionsFind.FindNullPrompt = "Search Employees (Ctrl + F)"
            Me.gridView.OptionsFind.ShowClearButton = False
            Me.gridView.OptionsFind.ShowFindButton = False
            Me.gridView.OptionsSelection.MultiSelect = True
            Me.gridView.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.OptionsView.ShowIndicator = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDepartment, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.colPrefix.Caption = "Prefix"
            Me.colPrefix.FieldName = "Prefix"
            Me.colPrefix.ImageOptions.Alignment = System.Drawing.StringAlignment.Center
            Me.colPrefix.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colPrefix.Name = "colPrefix"
            Me.colPrefix.OptionsColumn.AllowFocus = False
            Me.colPrefix.OptionsColumn.AllowMove = False
            Me.colPrefix.OptionsColumn.AllowSize = False
            Me.colPrefix.OptionsColumn.FixedWidth = True
            Me.colPrefix.OptionsColumn.ShowCaption = False
            Me.colPrefix.Visible = True
            Me.colPrefix.VisibleIndex = 0
            Me.colPrefix.Width = 47
            Me.colDepartment.Caption = "Department"
            Me.colDepartment.FieldName = "Department"
            Me.colDepartment.Name = "colDepartment"
            Me.colDepartment.OptionsColumn.AllowFocus = False
            Me.colDepartment.Visible = True
            Me.colDepartment.VisibleIndex = 0
            Me.colFullName.Caption = "Full Name"
            Me.colFullName.FieldName = "FullNameBindable"
            Me.colFullName.Name = "colFullName"
            Me.colFullName.OptionsColumn.AllowFocus = False
            Me.colFullName.Visible = True
            Me.colFullName.VisibleIndex = 1
            Me.colFullName.Width = 133
            Me.colAddress.Caption = "Address"
            Me.colAddress.FieldName = "Address.Line"
            Me.colAddress.Name = "colAddress"
            Me.colAddress.OptionsColumn.AllowFocus = False
            Me.colAddress.Visible = True
            Me.colAddress.VisibleIndex = 2
            Me.colAddress.Width = 142
            Me.colCity.Caption = "City"
            Me.colCity.FieldName = "Address.City"
            Me.colCity.Name = "colCity"
            Me.colCity.OptionsColumn.AllowFocus = False
            Me.colCity.Visible = True
            Me.colCity.VisibleIndex = 3
            Me.colCity.Width = 113
            Me.colState.Caption = "State"
            Me.colState.FieldName = "Address.State"
            Me.colState.Name = "colState"
            Me.colState.OptionsColumn.AllowFocus = False
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 4
            Me.colState.Width = 73
            Me.colZipCode.Caption = "Zip Code"
            Me.colZipCode.FieldName = "Address.ZipCode"
            Me.colZipCode.Name = "colZipCode"
            Me.colZipCode.OptionsColumn.AllowFocus = False
            Me.colZipCode.Visible = True
            Me.colZipCode.VisibleIndex = 5
            Me.colZipCode.Width = 73
            Me.colEmail.Caption = "Email"
            Me.colEmail.FieldName = "Email"
            Me.colEmail.Name = "colEmail"
            Me.colEmail.OptionsColumn.AllowFocus = False
            Me.colEmail.Visible = True
            Me.colEmail.VisibleIndex = 6
            Me.colEmail.Width = 166
            Me.colBirthDate.Caption = "Birth Date"
            Me.colBirthDate.FieldName = "BirthDate"
            Me.colBirthDate.Name = "colBirthDate"
            Me.colBirthDate.OptionsColumn.AllowFocus = False
            Me.colHireDate.Caption = "Hire Date"
            Me.colHireDate.FieldName = "HireDate"
            Me.colHireDate.Name = "colHireDate"
            Me.colHireDate.OptionsColumn.AllowFocus = False
            Me.colHomePhone.Caption = "Home Phone"
            Me.colHomePhone.FieldName = "HomePhone"
            Me.colHomePhone.Name = "colHomePhone"
            Me.colHomePhone.OptionsColumn.AllowFocus = False
            Me.colMobilePhone1.Caption = "Mobile Phone"
            Me.colMobilePhone1.FieldName = "MobilePhone"
            Me.colMobilePhone1.Name = "colMobilePhone1"
            Me.colMobilePhone1.OptionsColumn.AllowFocus = False
            Me.colTitle.Caption = "Title"
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            Me.colTitle.OptionsColumn.AllowFocus = False
            Me.repositoryItemImageComboBox1.AutoHeight = False
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            Me.repositoryItemImageComboBox2.AutoHeight = False
            Me.repositoryItemImageComboBox2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemImageComboBox2.Name = "repositoryItemImageComboBox2"
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.layoutView.CardCaptionFormat = "{3}"
            Me.layoutView.CardMinSize = New System.Drawing.Size(292, 183)
            Me.layoutView.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.colPhoto, Me.colFullName1, Me.colAddress1, Me.colEmail1, Me.colMobilePhone})
            Me.layoutView.FieldCaptionFormat = "{0}"
            Me.layoutView.GridControl = Me.gridControl
            Me.layoutView.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colFullName1})
            Me.layoutView.Name = "layoutView"
            Me.layoutView.OptionsBehavior.AllowExpandCollapse = False
            Me.layoutView.OptionsBehavior.AllowRuntimeCustomization = False
            Me.layoutView.OptionsBehavior.Editable = False
            Me.layoutView.OptionsBehavior.[ReadOnly] = True
            Me.layoutView.OptionsFind.AlwaysVisible = True
            Me.layoutView.OptionsFind.FindNullPrompt = "Search Employees (Ctrl + F)"
            Me.layoutView.OptionsFind.ShowClearButton = False
            Me.layoutView.OptionsFind.ShowCloseButton = False
            Me.layoutView.OptionsFind.ShowFindButton = False
            Me.layoutView.OptionsItemText.TextToControlDistance = 2
            Me.layoutView.OptionsMultiRecordMode.MultiRowScrollBarOrientation = DevExpress.XtraGrid.Views.Layout.ScrollBarOrientation.Vertical
            Me.layoutView.OptionsSelection.MultiSelect = True
            Me.layoutView.OptionsView.AllowHotTrackFields = False
            Me.layoutView.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
            Me.layoutView.OptionsView.ShowHeaderPanel = False
            Me.layoutView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow
            Me.layoutView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colFullName1, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.layoutView.TemplateCard = Me.layoutViewCard1
            Me.colPhoto.AppearanceCell.Options.UseTextOptions = True
            Me.colPhoto.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.OptionsColumn.AllowEdit = False
            Me.colPhoto.OptionsColumn.AllowFocus = False
            Me.colPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colPhoto.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 106
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.MaxSize = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.MinSize = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 12, 2, 2)
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(120, 136)
            Me.layoutViewField_colPhoto.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_colPhoto.TextVisible = False
            Me.colFullName1.FieldName = "FullNameBindable"
            Me.colFullName1.LayoutViewField = Me.layoutViewField_colFullName1
            Me.colFullName1.Name = "colFullName1"
            Me.colFullName1.OptionsColumn.AllowFocus = False
            Me.layoutViewField_colFullName1.EditorPreferredWidth = 20
            Me.layoutViewField_colFullName1.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colFullName1.Name = "layoutViewField_colFullName1"
            Me.layoutViewField_colFullName1.Size = New System.Drawing.Size(272, 136)
            Me.layoutViewField_colFullName1.TextSize = New System.Drawing.Size(67, 13)
            Me.colAddress1.Caption = "Address"
            Me.colAddress1.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colAddress1.FieldName = "Address"
            Me.colAddress1.LayoutViewField = Me.layoutViewField_colAddress1
            Me.colAddress1.Name = "colAddress1"
            Me.colAddress1.OptionsColumn.AllowFocus = False
            Me.colAddress1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colAddress1.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colAddress1.EditorPreferredWidth = 148
            Me.layoutViewField_colAddress1.Location = New System.Drawing.Point(120, 0)
            Me.layoutViewField_colAddress1.Name = "layoutViewField_colAddress1"
            Me.layoutViewField_colAddress1.Size = New System.Drawing.Size(152, 36)
            Me.layoutViewField_colAddress1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colAddress1.TextSize = New System.Drawing.Size(48, 13)
            Me.colEmail1.Caption = "Email"
            Me.colEmail1.FieldName = "Email"
            Me.colEmail1.LayoutViewField = Me.layoutViewField_colEmail1
            Me.colEmail1.Name = "colEmail1"
            Me.colEmail1.OptionsColumn.AllowFocus = False
            Me.colEmail1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colEmail1.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colEmail1.EditorPreferredWidth = 148
            Me.layoutViewField_colEmail1.Location = New System.Drawing.Point(120, 36)
            Me.layoutViewField_colEmail1.Name = "layoutViewField_colEmail1"
            Me.layoutViewField_colEmail1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutViewField_colEmail1.Size = New System.Drawing.Size(152, 41)
            Me.layoutViewField_colEmail1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colEmail1.TextSize = New System.Drawing.Size(48, 13)
            Me.colMobilePhone.Caption = "Phone"
            Me.colMobilePhone.FieldName = "MobilePhone"
            Me.colMobilePhone.LayoutViewField = Me.layoutViewField_colMobilePhone
            Me.colMobilePhone.Name = "colMobilePhone"
            Me.colMobilePhone.OptionsColumn.AllowFocus = False
            Me.colMobilePhone.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colMobilePhone.OptionsFilter.AllowFilter = False
            Me.layoutViewField_colMobilePhone.EditorPreferredWidth = 148
            Me.layoutViewField_colMobilePhone.Location = New System.Drawing.Point(120, 77)
            Me.layoutViewField_colMobilePhone.Name = "layoutViewField_colMobilePhone"
            Me.layoutViewField_colMobilePhone.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 8, 2)
            Me.layoutViewField_colMobilePhone.Size = New System.Drawing.Size(152, 45)
            Me.layoutViewField_colMobilePhone.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutViewField_colMobilePhone.TextSize = New System.Drawing.Size(48, 13)
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutViewField_colAddress1, Me.layoutViewField_colEmail1, Me.layoutViewField_colPhoto, Me.layoutViewField_colMobilePhone, Me.Item1})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 2
            Me.layoutViewCard1.Text = "TemplateCard"
            Me.Item1.CustomizationFormText = "Item1"
            Me.Item1.Location = New System.Drawing.Point(120, 122)
            Me.Item1.Name = "Item1"
            Me.Item1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Item1.Size = New System.Drawing.Size(152, 14)
            Me.roundedSkinPanelPnlView.AllowResize = DevExpress.Utils.DefaultBoolean.[True]
            Me.roundedSkinPanelPnlView.Dock = System.Windows.Forms.DockStyle.Right
            Me.roundedSkinPanelPnlView.Location = New System.Drawing.Point(772, 8)
            Me.roundedSkinPanelPnlView.MaximumSize = New System.Drawing.Size(800, 0)
            Me.roundedSkinPanelPnlView.MinimumSize = New System.Drawing.Size(400, 0)
            Me.roundedSkinPanelPnlView.Name = "roundedSkinPanelPnlView"
            Me.roundedSkinPanelPnlView.Size = New System.Drawing.Size(500, 625)
            Me.roundedSkinPanelPnlView.TabIndex = 5
            Me.roundedSkinPanelPnlView.Text = "roundedSkinPanel1"
            Me.mainRoundedPanel.Controls.Add(Me.gridControl)
            Me.mainRoundedPanel.Controls.Add(Me.roundedSkinPanelPnlView)
            Me.mainRoundedPanel.Controls.Add(Me.navigationRoundedPanel)
            Me.mainRoundedPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainRoundedPanel.Location = New System.Drawing.Point(0, 122)
            Me.mainRoundedPanel.Name = "mainRoundedPanel"
            Me.mainRoundedPanel.Size = New System.Drawing.Size(1280, 641)
            Me.mainRoundedPanel.TabIndex = 6
            Me.mainRoundedPanel.Text = "roundedSkinPanel1"
            Me.navigationRoundedPanel.BorderStyle = DevExpress.XtraEditors.RoundedPanelBorderStyle.NoBorder
            Me.navigationRoundedPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.navigationRoundedPanel.Location = New System.Drawing.Point(8, 8)
            Me.navigationRoundedPanel.Name = "navigationRoundedPanel"
            Me.navigationRoundedPanel.Size = New System.Drawing.Size(110, 625)
            Me.navigationRoundedPanel.TabIndex = 6
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainRoundedPanel)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.MinimumSize = New System.Drawing.Size(700, 0)
            Me.Name = "Employees"
            Me.Size = New System.Drawing.Size(1280, 800)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemImageComboBox2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colFullName1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colAddress1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colEmail1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colMobilePhone), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Item1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainRoundedPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainRoundedPanel.ResumeLayout(False)
            CType((Me.navigationRoundedPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biNewEmployee As DevExpress.XtraBars.BarButtonItem

        Private biNewGroup As DevExpress.XtraBars.BarButtonItem

        Private biNewCustomFilter As DevExpress.XtraBars.BarButtonItem

        Private biDelete As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private bindingSource As System.Windows.Forms.BindingSource

        Private colDepartment As DevExpress.XtraGrid.Columns.GridColumn

        Private colFullName As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmail As DevExpress.XtraGrid.Columns.GridColumn

        Private colCity As DevExpress.XtraGrid.Columns.GridColumn

        Private colAddress As DevExpress.XtraGrid.Columns.GridColumn

        Private biShowList As DevExpress.XtraBars.BarCheckItem

        Private biShowCard As DevExpress.XtraBars.BarCheckItem

        Private bmiShowList As DevExpress.XtraBars.BarCheckItem

        Private bmiShowCard As DevExpress.XtraBars.BarCheckItem

        Private biMap As DevExpress.XtraBars.BarButtonItem

        Private bmiHorizontalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiVerticalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiHideDetail As DevExpress.XtraBars.BarCheckItem

        Private biNewSubItem As DevExpress.XtraBars.BarSubItem

        Private biChangeViewSubItem As DevExpress.XtraBars.BarSubItem

        Private biDataPaneSubItem As DevExpress.XtraBars.BarSubItem

        Private biPrintSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiPrintProfile As DevExpress.XtraBars.BarButtonItem

        Private bmiPrintSummary As DevExpress.XtraBars.BarButtonItem

        Private bmiPrintDirectory As DevExpress.XtraBars.BarButtonItem

        Private bmiPrintTaskList As DevExpress.XtraBars.BarButtonItem

        Private biMailMerge As DevExpress.XtraBars.BarButtonItem

        Private bmiNewEmployee As DevExpress.XtraBars.BarButtonItem

        Private bmiNewGroup As DevExpress.XtraBars.BarButtonItem

        Private biEdit As DevExpress.XtraBars.BarButtonItem

        Private biResetView As DevExpress.XtraBars.BarButtonItem

        Private layoutView As DevExpress.XtraGrid.Views.Layout.LayoutView

        Private colState As DevExpress.XtraGrid.Columns.GridColumn

        Private colZipCode As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private repositoryItemImageComboBox2 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private colPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colFullName1 As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colAddress1 As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colEmail1 As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private colMobilePhone As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private galleryQuickLetters As DevExpress.XtraBars.RibbonGalleryBarItem

        Private ribbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biMeeting As DevExpress.XtraBars.BarButtonItem

        Private biTask As DevExpress.XtraBars.BarButtonItem

        Private biViewSettings As DevExpress.XtraBars.BarButtonItem

        Private biReverseSort As DevExpress.XtraBars.BarButtonItem

        Private biAddColumns As DevExpress.XtraBars.BarCheckItem

        Private biExpandCollapse As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colFullName1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colAddress1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colEmail1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colMobilePhone As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

        Private Item1 As DevExpress.XtraLayout.EmptySpaceItem

        Private hiItemsCount As DevExpress.XtraBars.BarHeaderItem

        Private colBirthDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colHireDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colHomePhone As DevExpress.XtraGrid.Columns.GridColumn

        Private colMobilePhone1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrefix As DevExpress.XtraGrid.Columns.GridColumn

        Private roundedSkinPanelPnlView As DevExpress.XtraEditors.RoundedSkinPanel

        Private mainRoundedPanel As DevExpress.XtraEditors.RoundedSkinPanel

        Private navigationRoundedPanel As DevExpress.XtraEditors.RoundedSkinPanel
    End Class
End Namespace
