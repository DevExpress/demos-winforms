Namespace DevExpress.DevAV.Modules

    Partial Class Quotes

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
            Dim areaChartRangeControlClientView1 As DevExpress.XtraEditors.AreaChartRangeControlClientView = New DevExpress.XtraEditors.AreaChartRangeControlClientView()
            Me.rangeControl = New DevExpress.XtraEditors.RangeControl()
            Me.dateTimeChartRangeControlClient = New DevExpress.XtraEditors.DateTimeChartRangeControlClient()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.fieldPercentage = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.percentageProgressBar = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.fieldOpportunities = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldState = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biNewQuote = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biDelete = New DevExpress.XtraBars.BarButtonItem()
            Me.biMap = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiNewQuote = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiNewGroup = New DevExpress.XtraBars.BarButtonItem()
            Me.biChangeViewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddColumns = New DevExpress.XtraBars.BarCheckItem()
            Me.biReverseSort = New DevExpress.XtraBars.BarButtonItem()
            Me.biExpandCollapse = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintInvoice = New DevExpress.XtraBars.BarButtonItem()
            Me.biEdit = New DevExpress.XtraBars.BarButtonItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewCustomFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.biShowList = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.ribbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.mainRoundPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.roundedSkinPanelPnlView = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.rangeRoundPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.navigationRoundedPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dateTimeChartRangeControlClient), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.percentageProgressBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainRoundPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainRoundPanel.SuspendLayout()
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeRoundPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.rangeRoundPanel.SuspendLayout()
            CType((Me.navigationRoundedPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.rangeControl.AnimateOnDataChange = True
            Me.rangeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rangeControl.Client = Me.dateTimeChartRangeControlClient
            Me.rangeControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.rangeControl.Location = New System.Drawing.Point(1, 9)
            Me.rangeControl.MaximumSize = New System.Drawing.Size(0, 65)
            Me.rangeControl.MinimumSize = New System.Drawing.Size(32, 65)
            Me.rangeControl.Name = "rangeControl"
            Me.rangeControl.Size = New System.Drawing.Size(1101, 65)
            Me.rangeControl.TabIndex = 20
            Me.rangeControl.Text = "rangeControl1"
            Me.dateTimeChartRangeControlClient.DataProvider.TemplateView = areaChartRangeControlClientView1
            Me.dateTimeChartRangeControlClient.PaletteName = "Office2013-2"
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.CausesValidation = False
            Me.pivotGridControl.DataSource = Me.bindingSource
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldPercentage, Me.fieldOpportunities, Me.fieldCity, Me.fieldState})
            Me.pivotGridControl.Location = New System.Drawing.Point(163, 9)
            Me.pivotGridControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsSelection.MultiSelect = False
            Me.pivotGridControl.OptionsView.ColumnTotalsLocation = DevExpress.XtraPivotGrid.PivotTotalsLocation.Near
            Me.pivotGridControl.OptionsView.ShowColumnGrandTotalHeader = False
            Me.pivotGridControl.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.percentageProgressBar})
            Me.pivotGridControl.Size = New System.Drawing.Size(651, 473)
            Me.pivotGridControl.TabIndex = 20
            AddHandler Me.pivotGridControl.CustomCellValue, New System.EventHandler(Of DevExpress.XtraPivotGrid.PivotCellValueEventArgs)(AddressOf Me.pivotGridControl_CustomCellValue)
            Me.fieldPercentage.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldPercentage.Appearance.Cell.Options.UseTextOptions = True
            Me.fieldPercentage.Appearance.Cell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.fieldPercentage.Appearance.CellGrandTotal.Options.UseTextOptions = True
            Me.fieldPercentage.Appearance.CellGrandTotal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.fieldPercentage.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldPercentage.AreaIndex = 1
            Me.fieldPercentage.Caption = "Percentage"
            Me.fieldPercentage.FieldEdit = Me.percentageProgressBar
            Me.fieldPercentage.FieldName = "Opportunity"
            Me.fieldPercentage.Name = "fieldPercentage"
            Me.fieldPercentage.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldPercentage.Width = 400
            Me.percentageProgressBar.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.percentageProgressBar.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.percentageProgressBar.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.percentageProgressBar.EndColor = System.Drawing.Color.FromArgb((CInt(((CByte((47)))))), (CInt(((CByte((81)))))), (CInt(((CByte((165)))))))
            Me.percentageProgressBar.Name = "percentageProgressBar"
            Me.percentageProgressBar.[ReadOnly] = True
            Me.percentageProgressBar.ShowTitle = True
            Me.percentageProgressBar.StartColor = System.Drawing.Color.FromArgb((CInt(((CByte((47)))))), (CInt(((CByte((81)))))), (CInt(((CByte((165)))))))
            Me.fieldOpportunities.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldOpportunities.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldOpportunities.AreaIndex = 0
            Me.fieldOpportunities.Caption = "Opportunities"
            Me.fieldOpportunities.FieldName = "Total"
            Me.fieldOpportunities.Name = "fieldOpportunities"
            Me.fieldOpportunities.Width = 150
            Me.fieldCity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
            Me.fieldCity.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCity.AreaIndex = 1
            Me.fieldCity.Caption = "City"
            Me.fieldCity.FieldName = "CustomerStore.City"
            Me.fieldCity.Name = "fieldCity"
            Me.fieldCity.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldCity.Width = 94
            Me.fieldState.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.RowArea
            Me.fieldState.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldState.AreaIndex = 0
            Me.fieldState.Caption = "State"
            Me.fieldState.FieldName = "CustomerStore.State"
            Me.fieldState.Name = "fieldState"
            Me.fieldState.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldState.Width = 116
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biNewQuote, Me.biNewGroup, Me.biDelete, Me.biMap, Me.biNewSubItem, Me.biChangeViewSubItem, Me.biDataPaneSubItem, Me.bmiHideDetail, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.biResetView, Me.bmiShowList, Me.biAddColumns, Me.biReverseSort, Me.biExpandCollapse, Me.bmiNewQuote, Me.bmiNewGroup, Me.biPrintSubItem, Me.bmiPrintInvoice, Me.biEdit, Me.biViewSettings, Me.biNewCustomFilter, Me.hiItemsCount, Me.biShowList})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 11
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1273, 122)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.biNewQuote.Caption = "New Quote"
            Me.biNewQuote.Id = 1
            Me.biNewQuote.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewQuote.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewQuote.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewOpportunities.svg"
            Me.biNewQuote.Name = "biNewQuote"
            Me.biNewGroup.Caption = "New Group"
            Me.biNewGroup.Id = 2
            Me.biNewGroup.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewGroup.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewGroup.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.group-dx_desktop-regular-green-16.svg"
            Me.biNewGroup.Name = "biNewGroup"
            Me.biDelete.Caption = "Delete"
            Me.biDelete.Id = 3
            Me.biDelete.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biDelete.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_delete_16
            Me.biDelete.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDelete.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Delete.svg"
            Me.biDelete.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_delete_32
            Me.biDelete.Name = "biDelete"
            Me.biMap.Caption = "Opportunities Map"
            Me.biMap.Id = 8
            Me.biMap.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biMap.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_mapit_16
            Me.biMap.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMap.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biMap.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_mapit_32
            Me.biMap.Name = "biMap"
            Me.biNewSubItem.Caption = "New Items"
            Me.biNewSubItem.Id = 10
            Me.biNewSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewSubItem.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_new_item_16
            Me.biNewSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.arrow-tranding-up-more-dx_desktop-regular-g" & "reen-16.svg"
            Me.biNewSubItem.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_new_item_32
            Me.biNewSubItem.ImageOptions.LargeImageIndex = 29
            Me.biNewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewQuote), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiNewGroup)})
            Me.biNewSubItem.Name = "biNewSubItem"
            Me.biNewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiNewQuote.Caption = "New Quote"
            Me.bmiNewQuote.Id = 11
            Me.bmiNewQuote.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_new_opportunities_16
            Me.bmiNewQuote.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewQuote.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewOpportunities.svg?Size=16x16"
            Me.bmiNewQuote.Name = "bmiNewQuote"
            Me.bmiNewGroup.Caption = "New Group"
            Me.bmiNewGroup.Id = 12
            Me.bmiNewGroup.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_new_group_16
            Me.bmiNewGroup.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiNewGroup.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.group-dx_desktop-regular-green-16.svg"
            Me.bmiNewGroup.Name = "bmiNewGroup"
            Me.biChangeViewSubItem.Caption = "Change View"
            Me.biChangeViewSubItem.Id = 10
            Me.biChangeViewSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biChangeViewSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biChangeViewSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg"
            Me.biChangeViewSubItem.ImageOptions.LargeImageIndex = 40
            Me.biChangeViewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowList)})
            Me.biChangeViewSubItem.Name = "biChangeViewSubItem"
            Me.biChangeViewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiShowList.Caption = "List"
            Me.bmiShowList.GroupIndex = 3
            Me.bmiShowList.Id = 4
            Me.bmiShowList.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_list_32
            Me.bmiShowList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-list-16.png"
            Me.bmiShowList.Name = "bmiShowList"
            Me.biDataPaneSubItem.Caption = "Data Pane"
            Me.biDataPaneSubItem.Id = 10
            Me.biDataPaneSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biDataPaneSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-data-panel-16.png"
            Me.biDataPaneSubItem.ImageOptions.LargeImageIndex = 41
            Me.biDataPaneSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHorizontalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiVerticalLayout), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiHideDetail)})
            Me.biDataPaneSubItem.Name = "biDataPaneSubItem"
            Me.biDataPaneSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiHorizontalLayout.Caption = "Left"
            Me.bmiHorizontalLayout.GroupIndex = 2
            Me.bmiHorizontalLayout.Id = 6
            Me.bmiHorizontalLayout.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.bmiHorizontalLayout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHorizontalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16"
            Me.bmiHorizontalLayout.Name = "bmiHorizontalLayout"
            Me.bmiVerticalLayout.Caption = "Top"
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
            Me.biAddColumns.Caption = "Add Columns"
            Me.biAddColumns.Id = 5
            Me.biAddColumns.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biAddColumns.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biAddColumns.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.AddColumn.svg?Size=16x16"
            Me.biAddColumns.Name = "biAddColumns"
            AddHandler Me.biAddColumns.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biAddColumns_ItemCheckedChanged)
            Me.biReverseSort.Caption = "Reverse Sort"
            Me.biReverseSort.Id = 4
            Me.biReverseSort.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biReverseSort.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biReverseSort.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ReversSort.svg?Size=16x16"
            Me.biReverseSort.Name = "biReverseSort"
            AddHandler Me.biReverseSort.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biReverseSort_ItemClick)
            Me.biExpandCollapse.Caption = "Expand/Collapse"
            Me.biExpandCollapse.Id = 6
            Me.biExpandCollapse.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biExpandCollapse.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biExpandCollapse.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ExpandCollapse.svg?Size=16x16"
            Me.biExpandCollapse.Name = "biExpandCollapse"
            AddHandler Me.biExpandCollapse.ItemClick, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.biExpandCollapse_ItemClick)
            Me.biPrintSubItem.Caption = "Print"
            Me.biPrintSubItem.Enabled = False
            Me.biPrintSubItem.Id = 10
            Me.biPrintSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biPrintSubItem.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_print_16
            Me.biPrintSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biPrintSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Print.svg"
            Me.biPrintSubItem.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_print_32
            Me.biPrintSubItem.ImageOptions.LargeImageIndex = 30
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintInvoice)})
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiPrintInvoice.Caption = "Invoice"
            Me.bmiPrintInvoice.GroupIndex = 5
            Me.bmiPrintInvoice.Id = 6
            Me.bmiPrintInvoice.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_employee_task_list_16
            Me.bmiPrintInvoice.Name = "bmiPrintInvoice"
            Me.biEdit.Caption = "Edit"
            Me.biEdit.Id = 13
            Me.biEdit.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biEdit.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_edit_16
            Me.biEdit.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biEdit.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Edit.svg"
            Me.biEdit.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_edit_32
            Me.biEdit.Name = "biEdit"
            Me.biViewSettings.Caption = "View Settings"
            Me.biViewSettings.Id = 3
            Me.biViewSettings.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biViewSettings.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biViewSettings.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ViewSetting.svg"
            Me.biViewSettings.Name = "biViewSettings"
            Me.biNewCustomFilter.Caption = "Custom Filter"
            Me.biNewCustomFilter.Id = 8
            Me.biNewCustomFilter.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewCustomFilter.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_filter_16
            Me.biNewCustomFilter.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomFilter.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg"
            Me.biNewCustomFilter.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_filter_32
            Me.biNewCustomFilter.Name = "biNewCustomFilter"
            Me.hiItemsCount.Caption = "Records: 0"
            Me.hiItemsCount.Id = 9
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.biShowList.Caption = "List"
            Me.biShowList.Id = 10
            Me.biShowList.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biShowList.ImageOptions.Image = Global.DevExpress.DevAV.Properties.Resources.icon_list_16
            Me.biShowList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg"
            Me.biShowList.ImageOptions.LargeImage = Global.DevExpress.DevAV.Properties.Resources.icon_list_32
            Me.biShowList.Name = "biShowList"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup4, Me.ribbonPageGroup6})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewQuote)
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
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Actions"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowList)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biMap)
            Me.ribbonPageGroup4.MergeOrder = 0
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "View"
            Me.ribbonPageGroup6.AllowTextClipping = False
            Me.ribbonPageGroup6.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup6.ItemLinks.Add(Me.biNewCustomFilter)
            Me.ribbonPageGroup6.MergeOrder = 0
            Me.ribbonPageGroup6.Name = "ribbonPageGroup6"
            Me.ribbonPageGroup6.Text = "Find"
            Me.ribbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup5, Me.ribbonPageGroup7, Me.ribbonPageGroup8})
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
            Me.ribbonPageGroup8.AllowTextClipping = False
            Me.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup8.ItemLinks.Add(Me.biReverseSort)
            Me.ribbonPageGroup8.ItemLinks.Add(Me.biAddColumns)
            Me.ribbonPageGroup8.ItemLinks.Add(Me.biExpandCollapse)
            Me.ribbonPageGroup8.MergeOrder = 1
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonStatusBar.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 694)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1273, 37)
            Me.ribbonPage3.Name = "ribbonPage3"
            Me.mainRoundPanel.Controls.Add(Me.pivotGridControl)
            Me.mainRoundPanel.Controls.Add(Me.roundedSkinPanelPnlView)
            Me.mainRoundPanel.Controls.Add(Me.rangeRoundPanel)
            Me.mainRoundPanel.Controls.Add(Me.navigationRoundedPanel)
            Me.mainRoundPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainRoundPanel.Location = New System.Drawing.Point(0, 122)
            Me.mainRoundPanel.Name = "mainRoundPanel"
            Me.mainRoundPanel.Size = New System.Drawing.Size(1273, 572)
            Me.mainRoundPanel.TabIndex = 21
            Me.mainRoundPanel.Text = "roundedSkinPanel1"
            Me.roundedSkinPanelPnlView.AllowResize = DevExpress.Utils.DefaultBoolean.[True]
            Me.roundedSkinPanelPnlView.Dock = System.Windows.Forms.DockStyle.Right
            Me.roundedSkinPanelPnlView.Location = New System.Drawing.Point(815, 8)
            Me.roundedSkinPanelPnlView.MaximumSize = New System.Drawing.Size(600, 0)
            Me.roundedSkinPanelPnlView.MinimumSize = New System.Drawing.Size(450, 0)
            Me.roundedSkinPanelPnlView.Name = "roundedSkinPanelPnlView"
            Me.roundedSkinPanelPnlView.Size = New System.Drawing.Size(450, 475)
            Me.roundedSkinPanelPnlView.TabIndex = 0
            Me.rangeRoundPanel.Controls.Add(Me.rangeControl)
            Me.rangeRoundPanel.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.rangeRoundPanel.Location = New System.Drawing.Point(162, 483)
            Me.rangeRoundPanel.Name = "rangeRoundPanel"
            Me.rangeRoundPanel.Size = New System.Drawing.Size(1103, 81)
            Me.rangeRoundPanel.TabIndex = 1
            Me.navigationRoundedPanel.BorderStyle = DevExpress.XtraEditors.RoundedPanelBorderStyle.NoBorder
            Me.navigationRoundedPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.navigationRoundedPanel.Location = New System.Drawing.Point(8, 8)
            Me.navigationRoundedPanel.Name = "navigationRoundedPanel"
            Me.navigationRoundedPanel.Size = New System.Drawing.Size(154, 556)
            Me.navigationRoundedPanel.TabIndex = 21
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainRoundPanel)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "Quotes"
            Me.Size = New System.Drawing.Size(1273, 731)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dateTimeChartRangeControlClient), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.percentageProgressBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainRoundPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainRoundPanel.ResumeLayout(False)
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeRoundPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.rangeRoundPanel.ResumeLayout(False)
            CType((Me.navigationRoundedPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private bindingSource As System.Windows.Forms.BindingSource

        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private biNewQuote As DevExpress.XtraBars.BarButtonItem

        Private biNewGroup As DevExpress.XtraBars.BarButtonItem

        Private biDelete As DevExpress.XtraBars.BarButtonItem

        Private biMap As DevExpress.XtraBars.BarButtonItem

        Private biNewSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiNewQuote As DevExpress.XtraBars.BarButtonItem

        Private bmiNewGroup As DevExpress.XtraBars.BarButtonItem

        Private biChangeViewSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiShowList As DevExpress.XtraBars.BarCheckItem

        Private biDataPaneSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiHorizontalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiVerticalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiHideDetail As DevExpress.XtraBars.BarCheckItem

        Private biResetView As DevExpress.XtraBars.BarButtonItem

        Private biPrintSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiPrintInvoice As DevExpress.XtraBars.BarButtonItem

        Private biEdit As DevExpress.XtraBars.BarButtonItem

        Private biViewSettings As DevExpress.XtraBars.BarButtonItem

        Private biReverseSort As DevExpress.XtraBars.BarButtonItem

        Private biAddColumns As DevExpress.XtraBars.BarCheckItem

        Private biExpandCollapse As DevExpress.XtraBars.BarButtonItem

        Private biNewCustomFilter As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private hiItemsCount As DevExpress.XtraBars.BarHeaderItem

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldPercentage As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOpportunities As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldState As DevExpress.XtraPivotGrid.PivotGridField

        Private percentageProgressBar As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private ribbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private rangeControl As DevExpress.XtraEditors.RangeControl

        Private dateTimeChartRangeControlClient As DevExpress.XtraEditors.DateTimeChartRangeControlClient

        Private biShowList As DevExpress.XtraBars.BarButtonItem

        Private mainRoundPanel As DevExpress.XtraEditors.RoundedSkinPanel

        Private roundedSkinPanelPnlView As DevExpress.XtraEditors.RoundedSkinPanel

        Private rangeRoundPanel As DevExpress.XtraEditors.RoundedSkinPanel

        Private navigationRoundedPanel As DevExpress.XtraEditors.RoundedSkinPanel
    End Class
End Namespace
