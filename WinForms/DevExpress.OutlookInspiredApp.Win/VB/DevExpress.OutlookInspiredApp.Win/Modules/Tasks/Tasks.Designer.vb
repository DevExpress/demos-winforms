Namespace DevExpress.DevAV.Modules

    Partial Class Tasks

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
            Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.bsiDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biAllowResize = New DevExpress.XtraBars.BarButtonItem()
            Me.biPanelVisibility = New DevExpress.XtraBars.BarButtonItem()
            Me.biFixedPanel = New DevExpress.XtraBars.BarButtonItem()
            Me.bsiPanelVisibility = New DevExpress.XtraBars.BarSubItem()
            Me.bciPanelVisibilityDefault = New DevExpress.XtraBars.BarCheckItem()
            Me.bciPanelVisibilityBoth = New DevExpress.XtraBars.BarCheckItem()
            Me.bciPanelVisibilityChart = New DevExpress.XtraBars.BarCheckItem()
            Me.bciPanelVisibilityTree = New DevExpress.XtraBars.BarCheckItem()
            Me.bsiFixedPanel = New DevExpress.XtraBars.BarSubItem()
            Me.bciFixedPanelDefault = New DevExpress.XtraBars.BarCheckItem()
            Me.bciFixedPanelChart = New DevExpress.XtraBars.BarCheckItem()
            Me.bciFixedPanelNone = New DevExpress.XtraBars.BarCheckItem()
            Me.bciFixedPanelTree = New DevExpress.XtraBars.BarCheckItem()
            Me.biNewTask = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.modueLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.splitterItem = New DevExpress.XtraLayout.SplitterItem()
            Me.ganttControl = New DevExpress.XtraGantt.GanttControl()
            Me.colSubject = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDescription = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colRtfTextDescription = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colStartDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colDueDate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colStatus = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colPriority = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCompletion = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colReminder = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colReminderDateTime = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAssignedEmployee = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAssignedEmployeeId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colOwner = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colOwnerId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCustomerEmployee = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCustomerEmployeeId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colFollowUp = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colPrivate = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colCategory = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAttachedCollectionsChanged = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colOverdue = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAttachedFilesCount = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colAssignedEmployeesFullList = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.colId = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.roundedSkinPanelPnlView = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.modueLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitterItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ganttControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.bindingSource1.DataSource = GetType(DevExpress.DevAV.EmployeeTask)
            Me.ribbonControl.AutoHideEmptyItems = True
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.hiItemsCount, Me.biResetView, Me.bsiDataPaneSubItem, Me.bmiHideDetail, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.biAllowResize, Me.biPanelVisibility, Me.biFixedPanel, Me.bsiPanelVisibility, Me.bciPanelVisibilityDefault, Me.bciPanelVisibilityBoth, Me.bciPanelVisibilityChart, Me.bciPanelVisibilityTree, Me.bsiFixedPanel, Me.bciFixedPanelDefault, Me.bciFixedPanelChart, Me.bciFixedPanelNone, Me.bciFixedPanelTree, Me.biNewTask, Me.biDelete, Me.biEdit, Me.biViewSettings})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ribbonControl.MaxItemId = 33
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1280, 200)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar1
            Me.ribbonControl.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Above
            Me.hiItemsCount.Caption = "RECORDS: 0"
            Me.hiItemsCount.Id = 7
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.biResetView.Caption = "Reset View"
            Me.biResetView.Id = 12
            Me.biResetView.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biResetView.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ResetView.svg"
            Me.biResetView.Name = "biResetView"
            Me.bsiDataPaneSubItem.Caption = "Data Pane"
            Me.bsiDataPaneSubItem.Id = 14
            Me.bsiDataPaneSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bsiDataPaneSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bsiDataPaneSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.DataPanel.svg"
            Me.bsiDataPaneSubItem.ImageOptions.LargeImageIndex = 42
            Me.bsiDataPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHorizontalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiVerticalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHideDetail)})
            Me.bsiDataPaneSubItem.Name = "bsiDataPaneSubItem"
            Me.bsiDataPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
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
            Me.biAllowResize.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check
            Me.biAllowResize.Caption = "Allow Resize"
            Me.biAllowResize.Down = True
            Me.biAllowResize.Id = 15
            Me.biAllowResize.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAllowResize.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.AllowResize.svg"
            Me.biAllowResize.Name = "biAllowResize"
            AddHandler Me.biAllowResize.DownChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.OnAllowResizeDownChanged)
            Me.biPanelVisibility.Caption = "Panel Visibility"
            Me.biPanelVisibility.Id = 16
            Me.biPanelVisibility.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPanelVisibility.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelVisibility.svg"
            Me.biPanelVisibility.Name = "biPanelVisibility"
            Me.biFixedPanel.Caption = "Fixed Panel"
            Me.biFixedPanel.Id = 17
            Me.biFixedPanel.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biFixedPanel.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.FixedPanel.svg"
            Me.biFixedPanel.Name = "biFixedPanel"
            Me.bsiPanelVisibility.Caption = "Panel Visibility"
            Me.bsiPanelVisibility.Id = 19
            Me.bsiPanelVisibility.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bsiPanelVisibility.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bsiPanelVisibility.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelVisibility.svg"
            Me.bsiPanelVisibility.ImageOptions.LargeImageIndex = 43
            Me.bsiPanelVisibility.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bciPanelVisibilityDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.bciPanelVisibilityBoth), New DevExpress.XtraBars.LinkPersistInfo(Me.bciPanelVisibilityChart), New DevExpress.XtraBars.LinkPersistInfo(Me.bciPanelVisibilityTree)})
            Me.bsiPanelVisibility.Name = "bsiPanelVisibility"
            Me.bsiPanelVisibility.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bciPanelVisibilityDefault.Caption = "Default"
            Me.bciPanelVisibilityDefault.GroupIndex = 1
            Me.bciPanelVisibilityDefault.Id = 20
            Me.bciPanelVisibilityDefault.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciPanelVisibilityDefault.Name = "bciPanelVisibilityDefault"
            AddHandler Me.bciPanelVisibilityDefault.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciPanelVisibilityDefault_PanelVisibilityItemClick)
            Me.bciPanelVisibilityBoth.Caption = "Both"
            Me.bciPanelVisibilityBoth.GroupIndex = 1
            Me.bciPanelVisibilityBoth.Id = 21
            Me.bciPanelVisibilityBoth.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciPanelVisibilityBoth.Name = "bciPanelVisibilityBoth"
            AddHandler Me.bciPanelVisibilityBoth.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciPanelVisibilityBoth_PanelVisibilityItemClick)
            Me.bciPanelVisibilityChart.Caption = "Chart"
            Me.bciPanelVisibilityChart.GroupIndex = 1
            Me.bciPanelVisibilityChart.Id = 22
            Me.bciPanelVisibilityChart.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciPanelVisibilityChart.Name = "bciPanelVisibilityChart"
            AddHandler Me.bciPanelVisibilityChart.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciPanelVisibilityChart_PanelVisibilityItemClick)
            Me.bciPanelVisibilityTree.Caption = "Tree"
            Me.bciPanelVisibilityTree.GroupIndex = 1
            Me.bciPanelVisibilityTree.Id = 23
            Me.bciPanelVisibilityTree.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciPanelVisibilityTree.Name = "bciPanelVisibilityTree"
            AddHandler Me.bciPanelVisibilityTree.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciPanelVisibilityTree_PanelVisibilityItemClick)
            Me.bsiFixedPanel.Caption = "Fixed Panel"
            Me.bsiFixedPanel.Id = 24
            Me.bsiFixedPanel.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bsiFixedPanel.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.FixedPanel.svg"
            Me.bsiFixedPanel.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bciFixedPanelDefault), New DevExpress.XtraBars.LinkPersistInfo(Me.bciFixedPanelChart), New DevExpress.XtraBars.LinkPersistInfo(Me.bciFixedPanelNone), New DevExpress.XtraBars.LinkPersistInfo(Me.bciFixedPanelTree)})
            Me.bsiFixedPanel.Name = "bsiFixedPanel"
            Me.bciFixedPanelDefault.Caption = "Default"
            Me.bciFixedPanelDefault.GroupIndex = 3
            Me.bciFixedPanelDefault.Id = 25
            Me.bciFixedPanelDefault.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciFixedPanelDefault.Name = "bciFixedPanelDefault"
            AddHandler Me.bciFixedPanelDefault.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciFixedPanelDefault_FixedPanelItemClick)
            Me.bciFixedPanelChart.Caption = "Chart"
            Me.bciFixedPanelChart.GroupIndex = 3
            Me.bciFixedPanelChart.Id = 26
            Me.bciFixedPanelChart.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciFixedPanelChart.Name = "bciFixedPanelChart"
            AddHandler Me.bciFixedPanelChart.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciFixedPanelChart_FixedPanelItemClick)
            Me.bciFixedPanelNone.Caption = "None"
            Me.bciFixedPanelNone.GroupIndex = 3
            Me.bciFixedPanelNone.Id = 27
            Me.bciFixedPanelNone.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciFixedPanelNone.Name = "bciFixedPanelNone"
            AddHandler Me.bciFixedPanelNone.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciFixedPanelNone_FixedPanelItemClick)
            Me.bciFixedPanelTree.Caption = "Tree"
            Me.bciFixedPanelTree.GroupIndex = 3
            Me.bciFixedPanelTree.Id = 28
            Me.bciFixedPanelTree.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bciFixedPanelTree.Name = "bciFixedPanelTree"
            AddHandler Me.bciFixedPanelTree.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.bciFixedPanelTree_FixedPanelItemClick)
            Me.biNewTask.Caption = "New Task"
            Me.biNewTask.Id = 29
            Me.biNewTask.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewTask.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewTask.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewTask.svg"
            Me.biNewTask.Name = "biNewTask"
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 30
            Me.biDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biDelete.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.Name = "biDelete"
            Me.biEdit.Caption = "Edit"
            Me.biEdit.Id = 31
            Me.biEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biEdit.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biEdit.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg"
            Me.biEdit.Name = "biEdit"
            Me.biViewSettings.Caption = "View Settings"
            Me.biViewSettings.Id = 32
            Me.biViewSettings.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biViewSettings.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biViewSettings.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg"
            Me.biViewSettings.Name = "biViewSettings"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup4, Me.ribbonPageGroup5})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewTask)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "New"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biDelete)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "Delete"
            Me.ribbonPageGroup5.AllowTextClipping = False
            Me.ribbonPageGroup5.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup5.ItemLinks.Add(Me.biEdit)
            Me.ribbonPageGroup5.MergeOrder = 0
            Me.ribbonPageGroup5.Name = "ribbonPageGroup5"
            Me.ribbonPageGroup5.Text = "Actions"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup2, Me.ribbonPageGroup3})
            Me.ribbonPage2.Name = "ribbonPage2"
            Me.ribbonPage2.Text = "View"
            Me.ribbonPageGroup2.AllowTextClipping = False
            Me.ribbonPageGroup2.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biAllowResize)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.bsiPanelVisibility)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.bsiFixedPanel)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biViewSettings)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.biResetView)
            Me.ribbonPageGroup2.MergeOrder = 0
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "Current View"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.bsiDataPaneSubItem)
            Me.ribbonPageGroup3.MergeOrder = 1
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Layout"
            Me.ribbonStatusBar1.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar1.Location = New System.Drawing.Point(0, 763)
            Me.ribbonStatusBar1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ribbonStatusBar1.Name = "ribbonStatusBar1"
            Me.ribbonStatusBar1.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar1.Size = New System.Drawing.Size(1280, 37)
            Me.modueLayout.AllowCustomization = False
            Me.modueLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.modueLayout.Location = New System.Drawing.Point(0, 200)
            Me.modueLayout.Name = "modueLayout"
            Me.modueLayout.Root = Me.layoutControlGroup1
            Me.modueLayout.Size = New System.Drawing.Size(1280, 563)
            Me.modueLayout.TabIndex = 5
            Me.modueLayout.Text = "modueLayout"
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.splitterItem})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 12, 12, 12)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1280, 563)
            Me.layoutControlGroup1.TextVisible = False
            Me.splitterItem.CustomizationFormText = "splitterItem1"
            Me.splitterItem.Location = New System.Drawing.Point(0, 0)
            Me.splitterItem.Name = "splitterItem1"
            Me.splitterItem.Size = New System.Drawing.Size(1264, 539)
            Me.ganttControl.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() {Me.colSubject, Me.colDescription, Me.colRtfTextDescription, Me.colStartDate, Me.colDueDate, Me.colStatus, Me.colPriority, Me.colCompletion, Me.colReminder, Me.colReminderDateTime, Me.colAssignedEmployee, Me.colAssignedEmployeeId, Me.colOwner, Me.colOwnerId, Me.colCustomerEmployee, Me.colCustomerEmployeeId, Me.colFollowUp, Me.colPrivate, Me.colCategory, Me.colAttachedCollectionsChanged, Me.colOverdue, Me.colAttachedFilesCount, Me.colAssignedEmployeesFullList, Me.colId})
            Me.ganttControl.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.ganttControl.CustomizationFormBounds = New System.Drawing.Rectangle(1125, 303, 377, 383)
            Me.ganttControl.DataSource = Me.bindingSource1
            Me.ganttControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ganttControl.Location = New System.Drawing.Point(17, 17)
            Me.ganttControl.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.ganttControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.ganttControl.MinWidth = 22
            Me.ganttControl.Name = "ganttControl"
            Me.ganttControl.OptionsBehavior.Editable = False
            Me.ganttControl.OptionsBehavior.PopulateServiceColumns = True
            Me.ganttControl.OptionsSelection.MultiSelect = True
            Me.ganttControl.OptionsSelection.UseIndicatorForSelection = True
            Me.ganttControl.OptionsSplitter.OverlayResizeZoneThickness = 7
            Me.ganttControl.OptionsView.ShowBaselines = True
            Me.ganttControl.OptionsView.ShowHorzLines = True
            Me.ganttControl.Size = New System.Drawing.Size(700, 529)
            Me.ganttControl.SplitterPosition = 438
            Me.ganttControl.TabIndex = 1
            Me.ganttControl.TreeLevelWidth = 20
            Me.colSubject.FieldName = "Subject"
            Me.colSubject.MinWidth = 90
            Me.colSubject.Name = "colSubject"
            Me.colSubject.Visible = True
            Me.colSubject.VisibleIndex = 0
            Me.colSubject.Width = 90
            Me.colDescription.FieldName = "Description"
            Me.colDescription.MinWidth = 22
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Width = 72
            Me.colRtfTextDescription.FieldName = "RtfTextDescription"
            Me.colRtfTextDescription.MinWidth = 22
            Me.colRtfTextDescription.Name = "colRtfTextDescription"
            Me.colRtfTextDescription.Width = 83
            Me.colStartDate.FieldName = "StartDate"
            Me.colStartDate.MinWidth = 22
            Me.colStartDate.Name = "colStartDate"
            Me.colStartDate.SortOrder = System.Windows.Forms.SortOrder.Ascending
            Me.colStartDate.Visible = True
            Me.colStartDate.VisibleIndex = 2
            Me.colStartDate.Width = 119
            Me.colDueDate.FieldName = "DueDate"
            Me.colDueDate.MinWidth = 22
            Me.colDueDate.Name = "colDueDate"
            Me.colDueDate.Visible = True
            Me.colDueDate.VisibleIndex = 3
            Me.colDueDate.Width = 151
            Me.colStatus.FieldName = "Status"
            Me.colStatus.MinWidth = 22
            Me.colStatus.Name = "colStatus"
            Me.colStatus.Width = 83
            Me.colPriority.FieldName = "Priority"
            Me.colPriority.MinWidth = 22
            Me.colPriority.Name = "colPriority"
            Me.colPriority.Width = 83
            Me.colCompletion.FieldName = "Completion"
            Me.colCompletion.MinWidth = 22
            Me.colCompletion.Name = "colCompletion"
            Me.colCompletion.Width = 56
            Me.colReminder.FieldName = "Reminder"
            Me.colReminder.MinWidth = 22
            Me.colReminder.Name = "colReminder"
            Me.colReminder.Width = 83
            Me.colReminderDateTime.FieldName = "ReminderDateTime"
            Me.colReminderDateTime.MinWidth = 22
            Me.colReminderDateTime.Name = "colReminderDateTime"
            Me.colReminderDateTime.Width = 83
            Me.colAssignedEmployee.FieldName = "AssignedEmployee"
            Me.colAssignedEmployee.MinWidth = 22
            Me.colAssignedEmployee.Name = "colAssignedEmployee"
            Me.colAssignedEmployee.Visible = True
            Me.colAssignedEmployee.VisibleIndex = 1
            Me.colAssignedEmployee.Width = 154
            Me.colAssignedEmployeeId.FieldName = "AssignedEmployeeId"
            Me.colAssignedEmployeeId.MinWidth = 22
            Me.colAssignedEmployeeId.Name = "colAssignedEmployeeId"
            Me.colAssignedEmployeeId.Width = 83
            Me.colOwner.FieldName = "Owner"
            Me.colOwner.MinWidth = 22
            Me.colOwner.Name = "colOwner"
            Me.colOwner.Width = 83
            Me.colOwnerId.FieldName = "OwnerId"
            Me.colOwnerId.MinWidth = 22
            Me.colOwnerId.Name = "colOwnerId"
            Me.colOwnerId.Width = 83
            Me.colCustomerEmployee.FieldName = "CustomerEmployee"
            Me.colCustomerEmployee.MinWidth = 22
            Me.colCustomerEmployee.Name = "colCustomerEmployee"
            Me.colCustomerEmployee.Width = 83
            Me.colCustomerEmployeeId.FieldName = "CustomerEmployeeId"
            Me.colCustomerEmployeeId.MinWidth = 22
            Me.colCustomerEmployeeId.Name = "colCustomerEmployeeId"
            Me.colCustomerEmployeeId.Width = 83
            Me.colFollowUp.FieldName = "FollowUp"
            Me.colFollowUp.MinWidth = 22
            Me.colFollowUp.Name = "colFollowUp"
            Me.colFollowUp.Width = 83
            Me.colPrivate.FieldName = "Private"
            Me.colPrivate.MinWidth = 22
            Me.colPrivate.Name = "colPrivate"
            Me.colPrivate.Width = 83
            Me.colCategory.FieldName = "Category"
            Me.colCategory.MinWidth = 22
            Me.colCategory.Name = "colCategory"
            Me.colCategory.Width = 83
            Me.colAttachedCollectionsChanged.FieldName = "AttachedCollectionsChanged"
            Me.colAttachedCollectionsChanged.MinWidth = 22
            Me.colAttachedCollectionsChanged.Name = "colAttachedCollectionsChanged"
            Me.colAttachedCollectionsChanged.Width = 83
            Me.colOverdue.FieldName = "Overdue"
            Me.colOverdue.MinWidth = 22
            Me.colOverdue.Name = "colOverdue"
            Me.colOverdue.OptionsColumn.[ReadOnly] = True
            Me.colOverdue.Width = 83
            Me.colAttachedFilesCount.FieldName = "AttachedFilesCount"
            Me.colAttachedFilesCount.MinWidth = 22
            Me.colAttachedFilesCount.Name = "colAttachedFilesCount"
            Me.colAttachedFilesCount.OptionsColumn.[ReadOnly] = True
            Me.colAttachedFilesCount.Width = 83
            Me.colAssignedEmployeesFullList.FieldName = "AssignedEmployeesFullList"
            Me.colAssignedEmployeesFullList.MinWidth = 22
            Me.colAssignedEmployeesFullList.Name = "colAssignedEmployeesFullList"
            Me.colAssignedEmployeesFullList.OptionsColumn.[ReadOnly] = True
            Me.colAssignedEmployeesFullList.Width = 83
            Me.colId.FieldName = "Id"
            Me.colId.MinWidth = 22
            Me.colId.Name = "colId"
            Me.colId.Width = 83
            Me.roundedSkinPanel1.Controls.Add(Me.ganttControl)
            Me.roundedSkinPanel1.Controls.Add(Me.roundedSkinPanelPnlView)
            Me.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 200)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1280, 563)
            Me.roundedSkinPanel1.TabIndex = 8
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.roundedSkinPanelPnlView.Dock = System.Windows.Forms.DockStyle.Right
            Me.roundedSkinPanelPnlView.Location = New System.Drawing.Point(718, 16)
            Me.roundedSkinPanelPnlView.Name = "roundedSkinPanelPnlView"
            Me.roundedSkinPanelPnlView.Size = New System.Drawing.Size(546, 531)
            Me.roundedSkinPanelPnlView.TabIndex = 0
            Me.roundedSkinPanelPnlView.Text = "roundedSkinPanel2"
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.roundedSkinPanel1)
            Me.Controls.Add(Me.modueLayout)
            Me.Controls.Add(Me.ribbonStatusBar1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
            Me.Name = "Tasks"
            Me.Size = New System.Drawing.Size(1280, 800)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.modueLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.splitterItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ganttControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private ribbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private bindingSource1 As System.Windows.Forms.BindingSource

        Private modueLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private splitterItem As DevExpress.XtraLayout.SplitterItem

        Private ganttControl As DevExpress.XtraGantt.GanttControl

        Private colSubject As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colDescription As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colRtfTextDescription As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colStartDate As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colDueDate As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colStatus As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colPriority As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colCompletion As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colReminder As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colReminderDateTime As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colAssignedEmployee As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colAssignedEmployeeId As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colOwner As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colOwnerId As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colCustomerEmployee As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colCustomerEmployeeId As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colFollowUp As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colPrivate As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colCategory As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colAttachedCollectionsChanged As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colOverdue As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colAttachedFilesCount As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colAssignedEmployeesFullList As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private colId As DevExpress.XtraTreeList.Columns.TreeListColumn

        Private hiItemsCount As DevExpress.XtraBars.BarHeaderItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biResetView As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private bsiDataPaneSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiHorizontalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiVerticalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiHideDetail As DevExpress.XtraBars.BarCheckItem

        Private biAllowResize As DevExpress.XtraBars.BarButtonItem

        Private biPanelVisibility As DevExpress.XtraBars.BarButtonItem

        Private biFixedPanel As DevExpress.XtraBars.BarButtonItem

        Private bsiPanelVisibility As DevExpress.XtraBars.BarSubItem

        Private bciPanelVisibilityDefault As DevExpress.XtraBars.BarCheckItem

        Private bciPanelVisibilityBoth As DevExpress.XtraBars.BarCheckItem

        Private bciPanelVisibilityChart As DevExpress.XtraBars.BarCheckItem

        Private bciPanelVisibilityTree As DevExpress.XtraBars.BarCheckItem

        Private bsiFixedPanel As DevExpress.XtraBars.BarSubItem

        Private bciFixedPanelDefault As DevExpress.XtraBars.BarCheckItem

        Private bciFixedPanelChart As DevExpress.XtraBars.BarCheckItem

        Private bciFixedPanelNone As DevExpress.XtraBars.BarCheckItem

        Private bciFixedPanelTree As DevExpress.XtraBars.BarCheckItem

        Private biNewTask As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biDelete As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private biEdit As DevExpress.XtraBars.BarButtonItem

        Private biViewSettings As DevExpress.XtraBars.BarButtonItem

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private roundedSkinPanelPnlView As DevExpress.XtraEditors.RoundedSkinPanel
    End Class
End Namespace
