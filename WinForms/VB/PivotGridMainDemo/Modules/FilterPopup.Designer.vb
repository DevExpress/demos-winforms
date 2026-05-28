Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class FilterPopup

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
        Private Sub InitializeComponent()
            Dim pivotGridStyleFormatCondition1 As DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition = New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim pivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldGroupCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldGroupProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldGroupYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldGroupQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldGroupMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.tableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
            Me.tcFilter = New DevExpress.XtraTab.XtraTabControl()
            Me.tabPageFieldFilter = New DevExpress.XtraTab.XtraTabPage()
            Me.pivotFilter = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.tabPageGroupFilter = New DevExpress.XtraTab.XtraTabPage()
            Me.pivotGroupFilter = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldGroupOrderAmount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.chkShowToolbar = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.chkInvertFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAllowTree = New DevExpress.XtraEditors.CheckEdit()
            Me.chkRadioMode = New DevExpress.XtraEditors.CheckEdit()
            Me.chkMultiSelection = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowOnlyAvailableItems = New DevExpress.XtraEditors.CheckEdit()
            Me.chkIncrementalSearch = New DevExpress.XtraEditors.CheckEdit()
            Me.chkAllowContextMenu = New DevExpress.XtraEditors.CheckEdit()
            Me.chkShowNewValues = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciAllowContextMenu = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciAllowTree = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciShowOnlyAvailable = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.tableLayoutPanel1.SuspendLayout()
            CType((Me.tcFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tcFilter.SuspendLayout()
            Me.tabPageFieldFilter.SuspendLayout()
            CType((Me.pivotFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPageGroupFilter.SuspendLayout()
            CType((Me.pivotGroupFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowToolbar.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.chkInvertFilter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAllowTree.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkRadioMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkMultiSelection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowOnlyAvailableItems.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkIncrementalSearch.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkAllowContextMenu.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chkShowNewValues.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAllowContextMenu), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAllowTree), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciShowOnlyAvailable), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' fieldGroupCategoryName
            ' 
            Me.fieldGroupCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldGroupCategoryName.AreaIndex = 0
            Me.fieldGroupCategoryName.Caption = "Category Name"
            Me.fieldGroupCategoryName.FieldName = "CategoryName"
            Me.fieldGroupCategoryName.Name = "fieldGroupCategoryName"
            Me.fieldGroupCategoryName.Width = 150
            ' 
            ' fieldGroupProductName
            ' 
            Me.fieldGroupProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldGroupProductName.AreaIndex = 1
            Me.fieldGroupProductName.Caption = "Product Name"
            Me.fieldGroupProductName.FieldName = "ProductName"
            Me.fieldGroupProductName.Name = "fieldGroupProductName"
            Me.fieldGroupProductName.Width = 170
            ' 
            ' fieldGroupYear
            ' 
            Me.fieldGroupYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldGroupYear.AreaIndex = 0
            Me.fieldGroupYear.Caption = "Year"
            Me.fieldGroupYear.FieldName = "OrderDate"
            Me.fieldGroupYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldGroupYear.Name = "fieldGroupYear"
            Me.fieldGroupYear.UnboundFieldName = "fieldGroupYear"
            ' 
            ' fieldGroupQuarter
            ' 
            Me.fieldGroupQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldGroupQuarter.AreaIndex = 1
            Me.fieldGroupQuarter.Caption = "Quarter"
            Me.fieldGroupQuarter.FieldName = "OrderDate"
            Me.fieldGroupQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldGroupQuarter.Name = "fieldGroupQuarter"
            Me.fieldGroupQuarter.UnboundFieldName = "fieldGroupQuarter"
            Me.fieldGroupQuarter.ValueFormat.FormatString = "Quarter {0}"
            Me.fieldGroupQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldGroupMonth
            ' 
            Me.fieldGroupMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldGroupMonth.AreaIndex = 2
            Me.fieldGroupMonth.Caption = "Month"
            Me.fieldGroupMonth.FieldName = "OrderDate"
            Me.fieldGroupMonth.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldGroupMonth.Name = "fieldGroupMonth"
            Me.fieldGroupMonth.UnboundFieldName = "fieldGroupMonth"
            ' 
            ' tableLayoutPanel1
            ' 
            Me.tableLayoutPanel1.ColumnCount = 1
            Me.tableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanel1.Controls.Add(Me.tcFilter, 0, 0)
            Me.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
            Me.tableLayoutPanel1.Name = "tableLayoutPanel1"
            Me.tableLayoutPanel1.RowCount = 1
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 521F))
            Me.tableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 521F))
            Me.tableLayoutPanel1.Size = New System.Drawing.Size(505, 521)
            Me.tableLayoutPanel1.TabIndex = 3
            ' 
            ' tcFilter
            ' 
            Me.tcFilter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tcFilter.Location = New System.Drawing.Point(3, 3)
            Me.tcFilter.Name = "tcFilter"
            Me.tcFilter.SelectedTabPage = Me.tabPageFieldFilter
            Me.tcFilter.Size = New System.Drawing.Size(499, 515)
            Me.tcFilter.TabIndex = 6
            Me.tcFilter.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tabPageFieldFilter, Me.tabPageGroupFilter})
            AddHandler Me.tcFilter.SelectedPageChanged, New DevExpress.XtraTab.TabPageChangedEventHandler(AddressOf Me.tcFilter_SelectedPageChanged)
            ' 
            ' tabPageFieldFilter
            ' 
            Me.tabPageFieldFilter.Controls.Add(Me.pivotFilter)
            Me.tabPageFieldFilter.Name = "tabPageFieldFilter"
            Me.tabPageFieldFilter.Size = New System.Drawing.Size(493, 487)
            Me.tabPageFieldFilter.Text = "Field Filter"
            ' 
            ' pivotFilter
            ' 
            Me.pivotFilter.ActiveFilterString = ""
            Me.pivotFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotFilter.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotFilter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotFilter.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldExtendedPrice, Me.fieldProductName, Me.fieldYear, Me.fieldCategoryName, Me.fieldQuantity})
            pivotGridStyleFormatCondition1.Expression = "[Extended Price] > 0"
            pivotGridStyleFormatCondition1.FieldName = ""
            Me.pivotFilter.FormatConditions.AddRange(New DevExpress.XtraPivotGrid.PivotGridStyleFormatCondition() {pivotGridStyleFormatCondition1})
            Me.pivotFilter.Location = New System.Drawing.Point(0, 0)
            Me.pivotFilter.Name = "pivotFilter"
            Me.pivotFilter.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never
            Me.pivotFilter.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Classic
            Me.pivotFilter.Size = New System.Drawing.Size(493, 487)
            Me.pivotFilter.TabIndex = 7
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 0
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.AreaIndex = 1
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' tabPageGroupFilter
            ' 
            Me.tabPageGroupFilter.Controls.Add(Me.pivotGroupFilter)
            Me.tabPageGroupFilter.Name = "tabPageGroupFilter"
            Me.tabPageGroupFilter.Size = New System.Drawing.Size(493, 487)
            Me.tabPageGroupFilter.Text = "Group Filter"
            ' 
            ' pivotGroupFilter
            ' 
            Me.pivotGroupFilter.ActiveFilterString = ""
            Me.pivotGroupFilter.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGroupFilter.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGroupFilter.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGroupFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGroupFilter.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldGroupCategoryName, Me.fieldGroupProductName, Me.fieldGroupOrderAmount, Me.fieldGroupYear, Me.fieldGroupQuarter, Me.fieldGroupMonth})
            pivotGridGroup1.Fields.Add(Me.fieldGroupCategoryName)
            pivotGridGroup1.Fields.Add(Me.fieldGroupProductName)
            pivotGridGroup1.Hierarchy = Nothing
            pivotGridGroup1.ShowNewValues = True
            pivotGridGroup2.Fields.Add(Me.fieldGroupYear)
            pivotGridGroup2.Fields.Add(Me.fieldGroupQuarter)
            pivotGridGroup2.Fields.Add(Me.fieldGroupMonth)
            pivotGridGroup2.Hierarchy = Nothing
            pivotGridGroup2.ShowNewValues = True
            Me.pivotGroupFilter.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1, pivotGridGroup2})
            Me.pivotGroupFilter.Location = New System.Drawing.Point(0, 0)
            Me.pivotGroupFilter.Name = "pivotGroupFilter"
            Me.pivotGroupFilter.OptionsFilterPopup.FieldFilterPopupMode = DevExpress.XtraPivotGrid.FieldFilterPopupMode.Classic
            Me.pivotGroupFilter.OptionsView.ShowFilterHeaders = False
            Me.pivotGroupFilter.Size = New System.Drawing.Size(493, 487)
            Me.pivotGroupFilter.TabIndex = 14
            ' 
            ' fieldGroupOrderAmount
            ' 
            Me.fieldGroupOrderAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldGroupOrderAmount.AreaIndex = 0
            Me.fieldGroupOrderAmount.Caption = "Order Amount"
            Me.fieldGroupOrderAmount.FieldName = "Extended Price"
            Me.fieldGroupOrderAmount.Name = "fieldGroupOrderAmount"
            ' 
            ' chkShowToolbar
            ' 
            Me.chkShowToolbar.EditValue = True
            Me.chkShowToolbar.Location = New System.Drawing.Point(11, 30)
            Me.chkShowToolbar.Name = "chkShowToolbar"
            Me.chkShowToolbar.Properties.Caption = "Show Toolbar"
            Me.chkShowToolbar.Size = New System.Drawing.Size(177, 19)
            Me.chkShowToolbar.StyleController = Me.layoutControl1
            Me.chkShowToolbar.TabIndex = 7
            AddHandler Me.chkShowToolbar.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowToolbar_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.chkInvertFilter)
            Me.layoutControl1.Controls.Add(Me.chkAllowTree)
            Me.layoutControl1.Controls.Add(Me.chkRadioMode)
            Me.layoutControl1.Controls.Add(Me.chkShowToolbar)
            Me.layoutControl1.Controls.Add(Me.chkMultiSelection)
            Me.layoutControl1.Controls.Add(Me.chkShowOnlyAvailableItems)
            Me.layoutControl1.Controls.Add(Me.chkIncrementalSearch)
            Me.layoutControl1.Controls.Add(Me.chkAllowContextMenu)
            Me.layoutControl1.Controls.Add(Me.chkShowNewValues)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1171, 443, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 494)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' chkInvertFilter
            ' 
            Me.chkInvertFilter.EditValue = True
            Me.chkInvertFilter.Location = New System.Drawing.Point(11, 251)
            Me.chkInvertFilter.Name = "chkInvertFilter"
            Me.chkInvertFilter.Properties.Caption = "Invert Filter"
            Me.chkInvertFilter.Size = New System.Drawing.Size(177, 19)
            Me.chkInvertFilter.StyleController = Me.layoutControl1
            Me.chkInvertFilter.TabIndex = 14
            AddHandler Me.chkInvertFilter.CheckedChanged, New System.EventHandler(AddressOf Me.chkInvertFilter_CheckedChanged)
            ' 
            ' chkAllowTree
            ' 
            Me.chkAllowTree.EditValue = True
            Me.chkAllowTree.Location = New System.Drawing.Point(11, 76)
            Me.chkAllowTree.Name = "chkAllowTree"
            Me.chkAllowTree.Properties.Caption = "Allow Tree"
            Me.chkAllowTree.Size = New System.Drawing.Size(177, 19)
            Me.chkAllowTree.StyleController = Me.layoutControl1
            Me.chkAllowTree.TabIndex = 2
            AddHandler Me.chkAllowTree.CheckedChanged, New System.EventHandler(AddressOf Me.chkAllowTree_CheckedChanged)
            ' 
            ' chkRadioMode
            ' 
            Me.chkRadioMode.EditValue = True
            Me.chkRadioMode.Location = New System.Drawing.Point(11, 228)
            Me.chkRadioMode.Name = "chkRadioMode"
            Me.chkRadioMode.Properties.Caption = "Radio Mode"
            Me.chkRadioMode.Size = New System.Drawing.Size(177, 19)
            Me.chkRadioMode.StyleController = Me.layoutControl1
            Me.chkRadioMode.TabIndex = 13
            AddHandler Me.chkRadioMode.CheckedChanged, New System.EventHandler(AddressOf Me.chkRadioMode_CheckedChanged)
            ' 
            ' chkMultiSelection
            ' 
            Me.chkMultiSelection.Location = New System.Drawing.Point(11, 205)
            Me.chkMultiSelection.Name = "chkMultiSelection"
            Me.chkMultiSelection.Properties.Caption = "Multi-Selection"
            Me.chkMultiSelection.Size = New System.Drawing.Size(177, 19)
            Me.chkMultiSelection.StyleController = Me.layoutControl1
            Me.chkMultiSelection.TabIndex = 10
            AddHandler Me.chkMultiSelection.CheckedChanged, New System.EventHandler(AddressOf Me.chkMultiSelection_CheckedChanged)
            ' 
            ' chkShowOnlyAvailableItems
            ' 
            Me.chkShowOnlyAvailableItems.EditValue = True
            Me.chkShowOnlyAvailableItems.Location = New System.Drawing.Point(11, 136)
            Me.chkShowOnlyAvailableItems.Name = "chkShowOnlyAvailableItems"
            Me.chkShowOnlyAvailableItems.Properties.Caption = "Show Only Available Items"
            Me.chkShowOnlyAvailableItems.Size = New System.Drawing.Size(177, 19)
            Me.chkShowOnlyAvailableItems.StyleController = Me.layoutControl1
            Me.chkShowOnlyAvailableItems.TabIndex = 12
            AddHandler Me.chkShowOnlyAvailableItems.CheckedChanged, New System.EventHandler(AddressOf Me.chkShowOnlyAvailableItems_CheckedChanged)
            ' 
            ' chkIncrementalSearch
            ' 
            Me.chkIncrementalSearch.Location = New System.Drawing.Point(11, 182)
            Me.chkIncrementalSearch.Name = "chkIncrementalSearch"
            Me.chkIncrementalSearch.Properties.Caption = "Incremental Search"
            Me.chkIncrementalSearch.Size = New System.Drawing.Size(177, 19)
            Me.chkIncrementalSearch.StyleController = Me.layoutControl1
            Me.chkIncrementalSearch.TabIndex = 11
            AddHandler Me.chkIncrementalSearch.CheckedChanged, New System.EventHandler(AddressOf Me.chkIncrementalSearch_CheckedChanged)
            ' 
            ' chkAllowContextMenu
            ' 
            Me.chkAllowContextMenu.EditValue = True
            Me.chkAllowContextMenu.Location = New System.Drawing.Point(11, 53)
            Me.chkAllowContextMenu.Name = "chkAllowContextMenu"
            Me.chkAllowContextMenu.Properties.Caption = "Allow Context Menu"
            Me.chkAllowContextMenu.Size = New System.Drawing.Size(177, 19)
            Me.chkAllowContextMenu.StyleController = Me.layoutControl1
            Me.chkAllowContextMenu.TabIndex = 0
            AddHandler Me.chkAllowContextMenu.CheckedChanged, New System.EventHandler(AddressOf Me.allowContextMenu_CheckedChanged)
            ' 
            ' chkShowNewValues
            ' 
            Me.chkShowNewValues.Location = New System.Drawing.Point(11, 159)
            Me.chkShowNewValues.Name = "chkShowNewValues"
            Me.chkShowNewValues.Properties.Caption = "Show New Field Values"
            Me.chkShowNewValues.Size = New System.Drawing.Size(177, 19)
            Me.chkShowNewValues.StyleController = Me.layoutControl1
            Me.chkShowNewValues.TabIndex = 8
            AddHandler Me.chkShowNewValues.CheckedChanged, New System.EventHandler(AddressOf Me.chkFilterTypeExcluded_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 494)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 281)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 213)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.lciAllowContextMenu, Me.lciAllowTree})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 106)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Filter Popup Options"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.chkShowToolbar
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciAllowContextMenu
            ' 
            Me.lciAllowContextMenu.Control = Me.chkAllowContextMenu
            Me.lciAllowContextMenu.Location = New System.Drawing.Point(0, 23)
            Me.lciAllowContextMenu.Name = "lciAllowContextMenu"
            Me.lciAllowContextMenu.Size = New System.Drawing.Size(181, 23)
            Me.lciAllowContextMenu.TextSize = New System.Drawing.Size(0, 0)
            Me.lciAllowContextMenu.TextVisible = False
            ' 
            ' lciAllowTree
            ' 
            Me.lciAllowTree.Control = Me.chkAllowTree
            Me.lciAllowTree.Location = New System.Drawing.Point(0, 46)
            Me.lciAllowTree.Name = "lciAllowTree"
            Me.lciAllowTree.Size = New System.Drawing.Size(181, 23)
            Me.lciAllowTree.TextSize = New System.Drawing.Size(0, 0)
            Me.lciAllowTree.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciShowOnlyAvailable, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 106)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 175)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Toolbar Buttons"
            ' 
            ' lciShowOnlyAvailable
            ' 
            Me.lciShowOnlyAvailable.Control = Me.chkShowOnlyAvailableItems
            Me.lciShowOnlyAvailable.Location = New System.Drawing.Point(0, 0)
            Me.lciShowOnlyAvailable.Name = "lciShowOnlyAvailable"
            Me.lciShowOnlyAvailable.Size = New System.Drawing.Size(181, 23)
            Me.lciShowOnlyAvailable.TextSize = New System.Drawing.Size(0, 0)
            Me.lciShowOnlyAvailable.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.chkShowNewValues
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.chkIncrementalSearch
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 46)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.chkMultiSelection
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 69)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.chkRadioMode
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 92)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.chkInvertFilter
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 115)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(505, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 521)
            Me.sidePanel1.TabIndex = 8
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.AllowCollapse = DevExpress.Utils.DefaultBoolean.[Default]
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 521)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 521)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 494)
            ' 
            ' FilterPopup
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tableLayoutPanel1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "FilterPopup"
            Me.Size = New System.Drawing.Size(705, 521)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FilterPopup_Load)
            AddHandler Me.VisibleChanged, New System.EventHandler(AddressOf Me.FilterPopup_VisibleChanged)
            Me.tableLayoutPanel1.ResumeLayout(False)
            CType((Me.tcFilter), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tcFilter.ResumeLayout(False)
            Me.tabPageFieldFilter.ResumeLayout(False)
            CType((Me.pivotFilter), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPageGroupFilter.ResumeLayout(False)
            CType((Me.pivotGroupFilter), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowToolbar.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.chkInvertFilter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAllowTree.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkRadioMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkMultiSelection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowOnlyAvailableItems.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkIncrementalSearch.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkAllowContextMenu.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chkShowNewValues.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAllowContextMenu), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAllowTree), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciShowOnlyAvailable), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

        Private chkAllowContextMenu As DevExpress.XtraEditors.CheckEdit

        Private chkAllowTree As DevExpress.XtraEditors.CheckEdit

        Private tcFilter As DevExpress.XtraTab.XtraTabControl

        Private tabPageFieldFilter As DevExpress.XtraTab.XtraTabPage

        Private tabPageGroupFilter As DevExpress.XtraTab.XtraTabPage

        Private pivotFilter As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGroupFilter As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldGroupCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldGroupProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldGroupOrderAmount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldGroupYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldGroupQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldGroupMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private chkShowToolbar As DevExpress.XtraEditors.CheckEdit

        Private chkShowOnlyAvailableItems As DevExpress.XtraEditors.CheckEdit

        Private chkMultiSelection As DevExpress.XtraEditors.CheckEdit

        Private chkIncrementalSearch As DevExpress.XtraEditors.CheckEdit

        Private chkShowNewValues As DevExpress.XtraEditors.CheckEdit

        Private chkInvertFilter As DevExpress.XtraEditors.CheckEdit

        Private chkRadioMode As DevExpress.XtraEditors.CheckEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private lciAllowContextMenu As DevExpress.XtraLayout.LayoutControlItem

        Private lciAllowTree As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private lciShowOnlyAvailable As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage
    End Class
End Namespace
