Namespace DevExpress.XtraGrid.Demos

    Partial Class SearchLookUpEditDemo

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.SearchLookUpEditDemo))
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim gridFormatRule2 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Me.colImage = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colTitle = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colSubtitle = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabPage0 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.filterConditionEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.parserKindEdit = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.autoSearchLookUpEdit = New DevExpress.XtraEditors.GridLookUpEdit()
            Me.entryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.autoSearchLookUpEditView = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.colText = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tabPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl()
            Me.panelControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.dsNWindProducts1 = New DevExpress.XtraGrid.Demos.dsNWindProducts()
            Me.searchLookUpEdit1 = New DevExpress.XtraGrid.Demos.SearchLookUpEditWithGlyph()
            Me.gridLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.tabPage2 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindCustomers1 = New DevExpress.XtraGrid.Demos.dsNWindCustomers()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSearchLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit()
            Me.repositoryItemSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCompanyName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colContactTitle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSearchLookUpEdit2 = New DevExpress.XtraGrid.Demos.RepositoryItemSearchLookUpEditWithGlyph()
            Me.repositoryItemSearchLookUpEdit2View = New DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colPhoto = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.gridBand2 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colFirstName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colLastName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colNotes = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabPage0.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.filterConditionEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.parserKindEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.autoSearchLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.entryBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.autoSearchLookUpEditView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage1.SuspendLayout()
            Me.xtraScrollableControl1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.dsNWindProducts1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.searchLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPage2.SuspendLayout()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsNWindCustomers1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSearchLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSearchLookUpEdit1View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSearchLookUpEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSearchLookUpEdit2View), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            resources.ApplyResources(Me.colImage, "colImage")
            ' 
            ' colTitle
            ' 
            Me.colTitle.FieldName = "Title"
            Me.colTitle.Name = "colTitle"
            resources.ApplyResources(Me.colTitle, "colTitle")
            ' 
            ' colSubtitle
            ' 
            Me.colSubtitle.FieldName = "Subtitle"
            Me.colSubtitle.Name = "colSubtitle"
            resources.ApplyResources(Me.colSubtitle, "colSubtitle")
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.ColumnEdit = Me.repositoryItemImageComboBox1
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.ImageOptions.Alignment = CType((resources.GetObject("colCategoryID.ImageOptions.Alignment")), System.Drawing.StringAlignment)
            Me.colCategoryID.ImageOptions.SvgImage = CType((resources.GetObject("colCategoryID.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colCategoryID.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colCategoryID.Name = "colCategoryID"
            Me.colCategoryID.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.[True]
            Me.colCategoryID.OptionsColumn.AllowMove = False
            Me.colCategoryID.OptionsColumn.AllowSize = False
            Me.colCategoryID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.colCategoryID.OptionsColumn.FixedWidth = True
            Me.colCategoryID.OptionsFilter.AllowFilter = False
            resources.ApplyResources(Me.colCategoryID, "colCategoryID")
            ' 
            ' repositoryItemImageComboBox1
            ' 
            resources.ApplyResources(Me.repositoryItemImageComboBox1, "repositoryItemImageComboBox1")
            Me.repositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemImageComboBox1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items1")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items3"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items4")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items6"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items7")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items9"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items10")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items12"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items13")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items14"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items15"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items16")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items17"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items18"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items19")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items20"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("repositoryItemImageComboBox1.Items21"), (CObj((resources.GetObject("repositoryItemImageComboBox1.Items22")))), (CInt((resources.GetObject("repositoryItemImageComboBox1.Items23")))))})
            Me.repositoryItemImageComboBox1.Name = "repositoryItemImageComboBox1"
            ' 
            ' colDiscontinued
            ' 
            resources.ApplyResources(Me.colDiscontinued, "colDiscontinued")
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabPage0)
            Me.tabPane1.Controls.Add(Me.tabPage1)
            Me.tabPane1.Controls.Add(Me.tabPage2)
            resources.ApplyResources(Me.tabPane1, "tabPane1")
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabPage0, Me.tabPage1, Me.tabPage2})
            Me.tabPane1.RegularSize = New System.Drawing.Size(715, 241)
            Me.tabPane1.SelectedPage = Me.tabPage0
            ' 
            ' tabPage0
            ' 
            resources.ApplyResources(Me.tabPage0, "tabPage0")
            Me.tabPage0.Controls.Add(Me.layoutControl1)
            Me.tabPage0.Controls.Add(Me.groupControl1)
            Me.tabPage0.Name = "tabPage0"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.filterConditionEdit)
            Me.layoutControl1.Controls.Add(Me.parserKindEdit)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.Root
            ' 
            ' filterConditionEdit
            ' 
            resources.ApplyResources(Me.filterConditionEdit, "filterConditionEdit")
            Me.filterConditionEdit.Name = "filterConditionEdit"
            Me.filterConditionEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("filterConditionEdit.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.filterConditionEdit.StyleController = Me.layoutControl1
            ' 
            ' parserKindEdit
            ' 
            resources.ApplyResources(Me.parserKindEdit, "parserKindEdit")
            Me.parserKindEdit.Name = "parserKindEdit"
            Me.parserKindEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("parserKindEdit.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.parserKindEdit.StyleController = Me.layoutControl1
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(283, 208)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 93)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(263, 95)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem1})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(263, 93)
            resources.ApplyResources(Me.layoutControlGroup1, "layoutControlGroup1")
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.filterConditionEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(239, 24)
            resources.ApplyResources(Me.layoutControlItem2, "layoutControlItem2")
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.parserKindEdit
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(239, 24)
            resources.ApplyResources(Me.layoutControlItem1, "layoutControlItem1")
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.AppearanceCaption.FontStyleDelta = CType((resources.GetObject("groupControl1.AppearanceCaption.FontStyleDelta")), System.Drawing.FontStyle)
            Me.groupControl1.AppearanceCaption.Options.UseFont = True
            Me.groupControl1.Controls.Add(Me.autoSearchLookUpEdit)
            resources.ApplyResources(Me.groupControl1, "groupControl1")
            Me.groupControl1.Name = "groupControl1"
            ' 
            ' autoSearchLookUpEdit
            ' 
            resources.ApplyResources(Me.autoSearchLookUpEdit, "autoSearchLookUpEdit")
            Me.autoSearchLookUpEdit.Name = "autoSearchLookUpEdit"
            Me.autoSearchLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
            Me.autoSearchLookUpEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("autoSearchLookUpEdit.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.autoSearchLookUpEdit.Properties.DataSource = Me.entryBindingSource
            Me.autoSearchLookUpEdit.Properties.DisplayMember = "Text"
            Me.autoSearchLookUpEdit.Properties.NullValuePrompt = resources.GetString("autoSearchLookUpEdit.Properties.NullValuePrompt")
            Me.autoSearchLookUpEdit.Properties.PopupView = Me.autoSearchLookUpEditView
            Me.autoSearchLookUpEdit.Properties.SearchMode = DevExpress.XtraEditors.Repository.GridLookUpSearchMode.AutoSearch
            Me.autoSearchLookUpEdit.Properties.ShowFooter = False
            Me.autoSearchLookUpEdit.Properties.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.TileView
            AddHandler Me.autoSearchLookUpEdit.AutoSearch, New DevExpress.XtraEditors.Controls.LookUpEditAutoSearchEventHandler(AddressOf Me.LookUpEdit_AutoSearch)
            ' 
            ' entryBindingSource
            ' 
            Me.entryBindingSource.DataSource = GetType(DevExpress.XtraGrid.Demos.WorldCities.Entry)
            ' 
            ' autoSearchLookUpEditView
            ' 
            Me.autoSearchLookUpEditView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTitle, Me.colSubtitle, Me.colText, Me.colImage})
            Me.autoSearchLookUpEditView.Name = "autoSearchLookUpEditView"
            Me.autoSearchLookUpEditView.OptionsBehavior.AllowMousePanning = False
            Me.autoSearchLookUpEditView.OptionsBehavior.AllowSmoothScrolling = True
            Me.autoSearchLookUpEditView.OptionsTiles.AllowPressAnimation = False
            Me.autoSearchLookUpEditView.OptionsTiles.GroupTextPadding = New System.Windows.Forms.Padding(12, 8, 12, 8)
            Me.autoSearchLookUpEditView.OptionsTiles.IndentBetweenGroups = 0
            Me.autoSearchLookUpEditView.OptionsTiles.IndentBetweenItems = 0
            Me.autoSearchLookUpEditView.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(12, 4, 12, 4)
            Me.autoSearchLookUpEditView.OptionsTiles.ItemSize = New System.Drawing.Size(248, 40)
            Me.autoSearchLookUpEditView.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
            Me.autoSearchLookUpEditView.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
            Me.autoSearchLookUpEditView.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
            Me.autoSearchLookUpEditView.OptionsTiles.RowCount = 0
            tableColumnDefinition1.Length.Type = DevExpress.XtraEditors.TableLayout.TableDefinitionLengthType.Pixel
            tableColumnDefinition1.Length.Value = 32R
            tableColumnDefinition2.Length.Value = 112R
            tableColumnDefinition2.PaddingLeft = 12
            Me.autoSearchLookUpEditView.TileColumns.Add(tableColumnDefinition1)
            Me.autoSearchLookUpEditView.TileColumns.Add(tableColumnDefinition2)
            Me.autoSearchLookUpEditView.TileRows.Add(tableRowDefinition1)
            Me.autoSearchLookUpEditView.TileRows.Add(tableRowDefinition2)
            tableSpan1.RowSpan = 2
            Me.autoSearchLookUpEditView.TileSpans.Add(tableSpan1)
            tileViewItemElement1.Column = Me.colImage
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            resources.ApplyResources(tileViewItemElement1, "tileViewItemElement1")
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.Column = Me.colTitle
            tileViewItemElement2.ColumnIndex = 1
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            resources.ApplyResources(tileViewItemElement2, "tileViewItemElement2")
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement3.Appearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.DisabledText
            tileViewItemElement3.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement3.Column = Me.colSubtitle
            tileViewItemElement3.ColumnIndex = 1
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement3.RowIndex = 1
            resources.ApplyResources(tileViewItemElement3, "tileViewItemElement3")
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            Me.autoSearchLookUpEditView.TileTemplate.Add(tileViewItemElement1)
            Me.autoSearchLookUpEditView.TileTemplate.Add(tileViewItemElement2)
            Me.autoSearchLookUpEditView.TileTemplate.Add(tileViewItemElement3)
            ' 
            ' colText
            ' 
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            resources.ApplyResources(Me.colText, "colText")
            ' 
            ' tabPage1
            ' 
            resources.ApplyResources(Me.tabPage1, "tabPage1")
            Me.tabPage1.Controls.Add(Me.xtraScrollableControl1)
            Me.tabPage1.Name = "tabPage1"
            ' 
            ' xtraScrollableControl1
            ' 
            Me.xtraScrollableControl1.Controls.Add(Me.panelControl1)
            resources.ApplyResources(Me.xtraScrollableControl1, "xtraScrollableControl1")
            Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.Controls.Add(Me.dataNavigator1)
            Me.panelControl1.Controls.Add(Me.searchLookUpEdit1)
            resources.ApplyResources(Me.panelControl1, "panelControl1")
            Me.panelControl1.Name = "panelControl1"
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            Me.dataNavigator1.DataSource = Me.dsNWindProducts1.Order_Details
            resources.ApplyResources(Me.dataNavigator1, "dataNavigator1")
            Me.dataNavigator1.Name = "dataNavigator1"
            ' 
            ' dsNWindProducts1
            ' 
            Me.dsNWindProducts1.DataSetName = "dsNWindProducts"
            Me.dsNWindProducts1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindProducts1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' searchLookUpEdit1
            ' 
            Me.searchLookUpEdit1.AllowDrop = True
            resources.ApplyResources(Me.searchLookUpEdit1, "searchLookUpEdit1")
            Me.searchLookUpEdit1.Name = "searchLookUpEdit1"
            Me.searchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("searchLookUpEdit1.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.searchLookUpEdit1.Properties.DataSource = Me.dsNWindProducts1.Products
            Me.searchLookUpEdit1.Properties.DisplayMember = "ProductName"
            Me.searchLookUpEdit1.Properties.PopupFormSize = New System.Drawing.Size(500, 0)
            Me.searchLookUpEdit1.Properties.PopupView = Me.gridLookUpEdit1View
            Me.searchLookUpEdit1.Properties.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemImageComboBox1})
            Me.searchLookUpEdit1.Properties.ValueMember = "ProductID"
            AddHandler Me.searchLookUpEdit1.AddNewValue, New DevExpress.XtraEditors.Controls.AddNewValueEventHandler(AddressOf Me.searchLookUpEdit1_AddNewValue)
            AddHandler Me.searchLookUpEdit1.ProcessNewValue, New DevExpress.XtraEditors.Controls.ProcessNewValueEventHandler(AddressOf Me.gridLookUpEdit1_ProcessNewValue)
            AddHandler Me.searchLookUpEdit1.EditValueChanged, New System.EventHandler(AddressOf Me.searchLookUpEdit1_EditValueChanged)
            ' 
            ' gridLookUpEdit1View
            ' 
            Me.gridLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colProductName, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colDiscontinued})
            Me.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            gridFormatRule1.ApplyToRow = True
            gridFormatRule1.Column = Me.colCategoryID
            gridFormatRule1.Name = "Format0"
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.RoyalBlue
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue1.Value1 = 1
            gridFormatRule1.Rule = formatConditionRuleValue1
            gridFormatRule2.ApplyToRow = True
            gridFormatRule2.Column = Me.colDiscontinued
            gridFormatRule2.Name = "Format1"
            formatConditionRuleValue2.Appearance.Font = CType((resources.GetObject("resource.Font")), System.Drawing.Font)
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.Gray
            formatConditionRuleValue2.Appearance.Options.UseFont = True
            formatConditionRuleValue2.Appearance.Options.UseForeColor = True
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Equal
            formatConditionRuleValue2.Value1 = True
            gridFormatRule2.Rule = formatConditionRuleValue2
            Me.gridLookUpEdit1View.FormatRules.Add(gridFormatRule1)
            Me.gridLookUpEdit1View.FormatRules.Add(gridFormatRule2)
            Me.gridLookUpEdit1View.Name = "gridLookUpEdit1View"
            Me.gridLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridLookUpEdit1View.OptionsFind.FindFilterColumns = "ProductName;QuantityPerUnit;UnitPrice"
            Me.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.gridLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.gridLookUpEdit1View.OptionsView.ShowIndicator = False
            ' 
            ' colProductName
            ' 
            resources.ApplyResources(Me.colProductName, "colProductName")
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            ' 
            ' colQuantityPerUnit
            ' 
            resources.ApplyResources(Me.colQuantityPerUnit, "colQuantityPerUnit")
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            ' 
            ' colUnitPrice
            ' 
            resources.ApplyResources(Me.colUnitPrice, "colUnitPrice")
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            ' 
            ' tabPage2
            ' 
            resources.ApplyResources(Me.tabPage2, "tabPage2")
            Me.tabPage2.Controls.Add(Me.gridControl1)
            Me.tabPage2.Name = "tabPage2"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.dsNWindCustomers1.Orders
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSearchLookUpEdit1, Me.repositoryItemSearchLookUpEdit2})
            Me.gridControl1.ShowOnlyPredefinedDetails = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' dsNWindCustomers1
            ' 
            Me.dsNWindCustomers1.DataSetName = "dsNWindCustomers"
            Me.dsNWindCustomers1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsNWindCustomers1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShipName})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            ' 
            ' colOrderID
            ' 
            resources.ApplyResources(Me.colOrderID, "colOrderID")
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            ' 
            ' colCustomerID
            ' 
            Me.colCustomerID.AppearanceHeader.Font = CType((resources.GetObject("colCustomerID.AppearanceHeader.Font")), System.Drawing.Font)
            Me.colCustomerID.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colCustomerID, "colCustomerID")
            Me.colCustomerID.ColumnEdit = Me.repositoryItemSearchLookUpEdit1
            Me.colCustomerID.FieldName = "CustomerID"
            Me.colCustomerID.Name = "colCustomerID"
            ' 
            ' repositoryItemSearchLookUpEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemSearchLookUpEdit1, "repositoryItemSearchLookUpEdit1")
            Me.repositoryItemSearchLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemSearchLookUpEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemSearchLookUpEdit1.DataSource = Me.dsNWindCustomers1.Customers
            Me.repositoryItemSearchLookUpEdit1.DisplayMember = "CompanyName"
            Me.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1"
            Me.repositoryItemSearchLookUpEdit1.PopupFormSize = New System.Drawing.Size(400, 0)
            Me.repositoryItemSearchLookUpEdit1.PopupView = Me.repositoryItemSearchLookUpEdit1View
            Me.repositoryItemSearchLookUpEdit1.ValueMember = "CustomerID"
            ' 
            ' repositoryItemSearchLookUpEdit1View
            ' 
            Me.repositoryItemSearchLookUpEdit1View.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCompanyName, Me.colContactName, Me.colContactTitle})
            Me.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View"
            Me.repositoryItemSearchLookUpEdit1View.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.AutoCalcPreviewLineCount = True
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowAutoFilterRow = True
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowIndicator = False
            Me.repositoryItemSearchLookUpEdit1View.OptionsView.ShowPreview = True
            AddHandler Me.repositoryItemSearchLookUpEdit1View.CalcPreviewText, New DevExpress.XtraGrid.Views.Grid.CalcPreviewTextEventHandler(AddressOf Me.repositoryItemGridLookUpEdit1View_CalcPreviewText)
            ' 
            ' colCompanyName
            ' 
            resources.ApplyResources(Me.colCompanyName, "colCompanyName")
            Me.colCompanyName.FieldName = "CompanyName"
            Me.colCompanyName.Name = "colCompanyName"
            ' 
            ' colContactName
            ' 
            resources.ApplyResources(Me.colContactName, "colContactName")
            Me.colContactName.FieldName = "ContactName"
            Me.colContactName.Name = "colContactName"
            ' 
            ' colContactTitle
            ' 
            resources.ApplyResources(Me.colContactTitle, "colContactTitle")
            Me.colContactTitle.FieldName = "ContactTitle"
            Me.colContactTitle.Name = "colContactTitle"
            ' 
            ' colEmployeeID
            ' 
            Me.colEmployeeID.AppearanceHeader.Font = CType((resources.GetObject("colEmployeeID.AppearanceHeader.Font")), System.Drawing.Font)
            Me.colEmployeeID.AppearanceHeader.Options.UseFont = True
            resources.ApplyResources(Me.colEmployeeID, "colEmployeeID")
            Me.colEmployeeID.ColumnEdit = Me.repositoryItemSearchLookUpEdit2
            Me.colEmployeeID.FieldName = "EmployeeID"
            Me.colEmployeeID.Name = "colEmployeeID"
            ' 
            ' repositoryItemSearchLookUpEdit2
            ' 
            resources.ApplyResources(Me.repositoryItemSearchLookUpEdit2, "repositoryItemSearchLookUpEdit2")
            Me.repositoryItemSearchLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemSearchLookUpEdit2.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemSearchLookUpEdit2.DataSource = Me.dsNWindCustomers1.Employees
            Me.repositoryItemSearchLookUpEdit2.DisplayMember = "Name"
            Me.repositoryItemSearchLookUpEdit2.Name = "repositoryItemSearchLookUpEdit2"
            Me.repositoryItemSearchLookUpEdit2.PopupFormSize = New System.Drawing.Size(400, 0)
            Me.repositoryItemSearchLookUpEdit2.PopupView = Me.repositoryItemSearchLookUpEdit2View
            Me.repositoryItemSearchLookUpEdit2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemMemoEdit1})
            Me.repositoryItemSearchLookUpEdit2.ValueMember = "EmployeeID"
            Me.repositoryItemSearchLookUpEdit2.ViewType = DevExpress.XtraEditors.Repository.GridLookUpViewType.AdvBandedView
            ' 
            ' repositoryItemSearchLookUpEdit2View
            ' 
            Me.repositoryItemSearchLookUpEdit2View.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1, Me.gridBand2})
            Me.repositoryItemSearchLookUpEdit2View.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colPhoto, Me.colFirstName, Me.colLastName, Me.colNotes})
            Me.repositoryItemSearchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
            Me.repositoryItemSearchLookUpEdit2View.Name = "repositoryItemSearchLookUpEdit2View"
            Me.repositoryItemSearchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ColumnAutoWidth = True
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ShowColumnHeaders = False
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ShowGroupPanel = False
            Me.repositoryItemSearchLookUpEdit2View.OptionsView.ShowIndicator = False
            ' 
            ' gridBand1
            ' 
            resources.ApplyResources(Me.gridBand1, "gridBand1")
            Me.gridBand1.Columns.Add(Me.colPhoto)
            Me.gridBand1.OptionsBand.FixedWidth = True
            Me.gridBand1.VisibleIndex = 0
            ' 
            ' colPhoto
            ' 
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            Me.colPhoto.RowCount = 4
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' gridBand2
            ' 
            resources.ApplyResources(Me.gridBand2, "gridBand2")
            Me.gridBand2.Columns.Add(Me.colFirstName)
            Me.gridBand2.Columns.Add(Me.colLastName)
            Me.gridBand2.Columns.Add(Me.colNotes)
            Me.gridBand2.VisibleIndex = 1
            ' 
            ' colFirstName
            ' 
            resources.ApplyResources(Me.colFirstName, "colFirstName")
            Me.colFirstName.FieldName = "FirstName"
            Me.colFirstName.Name = "colFirstName"
            ' 
            ' colLastName
            ' 
            resources.ApplyResources(Me.colLastName, "colLastName")
            Me.colLastName.FieldName = "LastName"
            Me.colLastName.Name = "colLastName"
            ' 
            ' colNotes
            ' 
            Me.colNotes.AutoFillDown = True
            resources.ApplyResources(Me.colNotes, "colNotes")
            Me.colNotes.ColumnEdit = Me.repositoryItemMemoEdit1
            Me.colNotes.FieldName = "Notes"
            Me.colNotes.Name = "colNotes"
            Me.colNotes.RowIndex = 1
            ' 
            ' repositoryItemMemoEdit1
            ' 
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            ' 
            ' colOrderDate
            ' 
            resources.ApplyResources(Me.colOrderDate, "colOrderDate")
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            ' 
            ' colRequiredDate
            ' 
            resources.ApplyResources(Me.colRequiredDate, "colRequiredDate")
            Me.colRequiredDate.FieldName = "RequiredDate"
            Me.colRequiredDate.Name = "colRequiredDate"
            ' 
            ' colShipName
            ' 
            resources.ApplyResources(Me.colShipName, "colShipName")
            Me.colShipName.FieldName = "ShipName"
            Me.colShipName.Name = "colShipName"
            ' 
            ' SearchLookUpEditDemo
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.tabPane1)
            Me.Name = "SearchLookUpEditDemo"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.GridLookUpEdit_Load)
            CType((Me.repositoryItemImageComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabPage0.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.filterConditionEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.parserKindEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            CType((Me.autoSearchLookUpEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.entryBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.autoSearchLookUpEditView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage1.ResumeLayout(False)
            Me.xtraScrollableControl1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.dsNWindProducts1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.searchLookUpEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPage2.ResumeLayout(False)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsNWindCustomers1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSearchLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSearchLookUpEdit1View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSearchLookUpEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSearchLookUpEdit2View), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private tabPage2 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panelControl1 As DevExpress.XtraEditors.GroupControl

        Private searchLookUpEdit1 As DevExpress.XtraGrid.Demos.SearchLookUpEditWithGlyph

        Private gridLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private dsNWindProducts1 As DevExpress.XtraGrid.Demos.dsNWindProducts

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn

        Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipName As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSearchLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit

        Private repositoryItemSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView

        Private colCompanyName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactName As DevExpress.XtraGrid.Columns.GridColumn

        Private colContactTitle As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSearchLookUpEdit2 As DevExpress.XtraGrid.Demos.RepositoryItemSearchLookUpEditWithGlyph

        Private repositoryItemSearchLookUpEdit2View As DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private gridBand2 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private colPhoto As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private colFirstName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colLastName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colNotes As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private dsNWindCustomers1 As DevExpress.XtraGrid.Demos.dsNWindCustomers

        Private components As System.ComponentModel.IContainer = Nothing

        Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl

        Private tabPage0 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private autoSearchLookUpEdit As DevExpress.XtraEditors.GridLookUpEdit

        Private entryBindingSource As System.Windows.Forms.BindingSource

        Private autoSearchLookUpEditView As DevExpress.XtraGrid.Views.Tile.TileView

        Private colTitle As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colSubtitle As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colText As DevExpress.XtraGrid.Columns.TileViewColumn

        Private colImage As DevExpress.XtraGrid.Columns.TileViewColumn

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private filterConditionEdit As DevExpress.XtraEditors.ImageComboBoxEdit

        Private parserKindEdit As DevExpress.XtraEditors.ImageComboBoxEdit

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
