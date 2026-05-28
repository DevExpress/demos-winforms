Namespace DevExpress.XtraLayout.Demos

    Partial Class EmployeeSales

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
            Me.components = New System.ComponentModel.Container()
            Dim gridFormatRule1 As DevExpress.XtraGrid.GridFormatRule = New DevExpress.XtraGrid.GridFormatRule()
            Dim formatConditionRule3ColorScale1 As DevExpress.XtraEditors.FormatConditionRule3ColorScale = New DevExpress.XtraEditors.FormatConditionRule3ColorScale()
            Dim lineSparklineView1 As DevExpress.Sparkline.LineSparklineView = New DevExpress.Sparkline.LineSparklineView()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraLayout.Demos.EmployeeSales))
            Dim buttonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Me.dsOrder = New DevExpress.XtraLayout.Demos.dsOrder()
            Me.bandGridControl = New DevExpress.XtraGrid.GridControl()
            Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
            Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
            Me.colProductName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn()
            Me.repositoryItemSparklineEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit()
            Me.layoutGridControl = New DevExpress.XtraGrid.GridControl()
            Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
            Me.lvcAddress = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colAddress = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.lvcCity = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colCity = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.lvcHomePhone = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_colHomePhone = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.lvcPhoto = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.layoutViewField_colPhoto = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.lvcFullName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.layoutViewField_layoutViewColumn19 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.lvcEdit = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
            Me.repositoryItemHypertextLabel1 = New DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel()
            Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
            Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
            Me.Group1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.Item1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.filteringUIContext1 = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.colorPickEdit1 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.FullNameFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.CategoryNameFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.filteringUIContext2 = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
            Me.colorPickEdit2 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit3 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit4 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.colorPickEdit5 = New DevExpress.XtraEditors.ColorPickEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForFullName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.ItemForCategoryName = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.dsOrder), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSparklineEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colAddress), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colCity), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colHomePhone), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_layoutViewColumn19), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemHypertextLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewField_layoutViewColumn1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Group1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Item1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filteringUIContext1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.colorPickEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.FullNameFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.CategoryNameFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filteringUIContext2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit3.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit4.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.colorPickEdit5.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForFullName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ItemForCategoryName), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dsOrder
            ' 
            Me.dsOrder.DataSetName = "dsOrder"
            Me.dsOrder.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' bandGridControl
            ' 
            Me.bandGridControl.DataMember = "CategoryProducts"
            Me.bandGridControl.DataSource = Me.dsOrder
            Me.bandGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.bandGridControl.Location = New System.Drawing.Point(0, 190)
            Me.bandGridControl.MainView = Me.bandedGridView1
            Me.bandGridControl.Name = "bandGridControl"
            Me.bandGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSparklineEdit1})
            Me.bandGridControl.Size = New System.Drawing.Size(705, 361)
            Me.bandGridControl.TabIndex = 7
            Me.bandGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.bandedGridView1})
            ' 
            ' bandedGridView1
            ' 
            Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1})
            Me.bandedGridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.bandedGridView1.Columns.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn() {Me.colProductName, Me.colCategoryName, Me.colUnitPrice, Me.colUnitsInStock})
            gridFormatRule1.Name = "Format0"
            gridFormatRule1.Rule = formatConditionRule3ColorScale1
            Me.bandedGridView1.FormatRules.Add(gridFormatRule1)
            Me.bandedGridView1.GridControl = Me.bandGridControl
            Me.bandedGridView1.Name = "bandedGridView1"
            Me.bandedGridView1.OptionsBehavior.Editable = False
            Me.bandedGridView1.OptionsCustomization.AllowFilter = False
            Me.bandedGridView1.OptionsDetail.EnableMasterViewMode = False
            Me.bandedGridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.bandedGridView1.OptionsView.ShowFooter = True
            Me.bandedGridView1.OptionsView.ShowGroupPanel = False
            Me.bandedGridView1.OptionsView.ShowIndicator = False
            AddHandler Me.bandedGridView1.CustomDrawCell, New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(AddressOf Me.bandedGridView1_CustomDrawCell)
            AddHandler Me.bandedGridView1.CustomUnboundColumnData, New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(AddressOf Me.gridView1_CustomUnboundColumnData)
            ' 
            ' gridBand1
            ' 
            Me.gridBand1.Caption = "Products"
            Me.gridBand1.Columns.Add(Me.colProductName)
            Me.gridBand1.Columns.Add(Me.colCategoryName)
            Me.gridBand1.Columns.Add(Me.colUnitPrice)
            Me.gridBand1.Columns.Add(Me.colUnitsInStock)
            Me.gridBand1.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Me.gridBand1.MinWidth = 250
            Me.gridBand1.Name = "gridBand1"
            Me.gridBand1.VisibleIndex = 0
            Me.gridBand1.Width = 900
            ' 
            ' colProductName
            ' 
            Me.colProductName.Caption = "Name"
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.Width = 450
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.Name = "colCategoryName"
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "Price"
            Me.colUnitPrice.DisplayFormat.FormatString = "c2"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.Width = 225
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.Caption = "Stock"
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.Width = 225
            ' 
            ' repositoryItemSparklineEdit1
            ' 
            Me.repositoryItemSparklineEdit1.Name = "repositoryItemSparklineEdit1"
            lineSparklineView1.HighlightMaxPoint = True
            lineSparklineView1.HighlightMinPoint = True
            lineSparklineView1.ScaleFactor = 1F
            Me.repositoryItemSparklineEdit1.View = lineSparklineView1
            ' 
            ' layoutGridControl
            ' 
            Me.layoutGridControl.DataMember = "Employees"
            Me.layoutGridControl.DataSource = Me.dsOrder
            Me.layoutGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutGridControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutGridControl.MainView = Me.layoutView1
            Me.layoutGridControl.Name = "layoutGridControl"
            Me.layoutGridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemPictureEdit1, Me.repositoryItemHypertextLabel1})
            Me.layoutGridControl.Size = New System.Drawing.Size(705, 189)
            Me.layoutGridControl.TabIndex = 4
            Me.layoutGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.layoutView1})
            ' 
            ' layoutView1
            ' 
            Me.layoutView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.layoutView1.CardCaptionFormat = "{6}"
            Me.layoutView1.CardMinSize = New System.Drawing.Size(270, 160)
            Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() {Me.lvcAddress, Me.lvcCity, Me.lvcHomePhone, Me.lvcPhoto, Me.lvcFullName, Me.lvcEdit})
            Me.layoutView1.GridControl = Me.layoutGridControl
            Me.layoutView1.Name = "layoutView1"
            Me.layoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto
            Me.layoutView1.OptionsCustomization.AllowFilter = False
            Me.layoutView1.OptionsCustomization.AllowSort = False
            Me.layoutView1.OptionsView.FocusRectStyle = DevExpress.XtraGrid.Views.Layout.FocusRectStyle.None
            Me.layoutView1.OptionsView.PartialCardsSimpleScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutView1.OptionsView.ShowCardExpandButton = False
            Me.layoutView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
            Me.layoutView1.OptionsView.ShowHeaderPanel = False
            Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row
            Me.layoutView1.TemplateCard = Me.layoutViewCard1
            AddHandler Me.layoutView1.CustomCardStyle, New DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventHandler(AddressOf Me.layoutView1_CustomCardStyle)
            AddHandler Me.layoutView1.CardClick, New DevExpress.XtraGrid.Views.Layout.Events.CardClickEventHandler(AddressOf Me.layoutView1_CardClick)
            AddHandler Me.layoutView1.ColumnFilterChanged, New System.EventHandler(AddressOf Me.layoutView1_ColumnFilterChanged)
            ' 
            ' lvcAddress
            ' 
            Me.lvcAddress.FieldName = "Address"
            Me.lvcAddress.LayoutViewField = Me.layoutViewField_colAddress
            Me.lvcAddress.Name = "lvcAddress"
            Me.lvcAddress.OptionsColumn.AllowEdit = False
            ' 
            ' layoutViewField_colAddress
            ' 
            Me.layoutViewField_colAddress.EditorPreferredWidth = 139
            Me.layoutViewField_colAddress.Location = New System.Drawing.Point(0, 44)
            Me.layoutViewField_colAddress.Name = "layoutViewField_colAddress"
            Me.layoutViewField_colAddress.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0)
            Me.layoutViewField_colAddress.Size = New System.Drawing.Size(143, 20)
            Me.layoutViewField_colAddress.TextVisible = False
            ' 
            ' lvcCity
            ' 
            Me.lvcCity.FieldName = "City"
            Me.lvcCity.LayoutViewField = Me.layoutViewField_colCity
            Me.lvcCity.Name = "lvcCity"
            Me.lvcCity.OptionsColumn.AllowEdit = False
            ' 
            ' layoutViewField_colCity
            ' 
            Me.layoutViewField_colCity.EditorPreferredWidth = 139
            Me.layoutViewField_colCity.Location = New System.Drawing.Point(0, 64)
            Me.layoutViewField_colCity.Name = "layoutViewField_colCity"
            Me.layoutViewField_colCity.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0)
            Me.layoutViewField_colCity.Size = New System.Drawing.Size(143, 20)
            Me.layoutViewField_colCity.TextVisible = False
            ' 
            ' lvcHomePhone
            ' 
            Me.lvcHomePhone.FieldName = "HomePhone"
            Me.lvcHomePhone.LayoutViewField = Me.layoutViewField_colHomePhone
            Me.lvcHomePhone.Name = "lvcHomePhone"
            Me.lvcHomePhone.OptionsColumn.AllowEdit = False
            ' 
            ' layoutViewField_colHomePhone
            ' 
            Me.layoutViewField_colHomePhone.EditorPreferredWidth = 139
            Me.layoutViewField_colHomePhone.Location = New System.Drawing.Point(0, 84)
            Me.layoutViewField_colHomePhone.Name = "layoutViewField_colHomePhone"
            Me.layoutViewField_colHomePhone.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0)
            Me.layoutViewField_colHomePhone.Size = New System.Drawing.Size(143, 20)
            Me.layoutViewField_colHomePhone.TextVisible = False
            ' 
            ' lvcPhoto
            ' 
            Me.lvcPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.lvcPhoto.FieldName = "Photo"
            Me.lvcPhoto.LayoutViewField = Me.layoutViewField_colPhoto
            Me.lvcPhoto.Name = "lvcPhoto"
            Me.lvcPhoto.OptionsColumn.AllowEdit = False
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' layoutViewField_colPhoto
            ' 
            Me.layoutViewField_colPhoto.EditorPreferredWidth = 99
            Me.layoutViewField_colPhoto.Location = New System.Drawing.Point(0, 0)
            Me.layoutViewField_colPhoto.Name = "layoutViewField_colPhoto"
            Me.layoutViewField_colPhoto.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 6, 2, 2)
            Me.layoutViewField_colPhoto.Size = New System.Drawing.Size(107, 122)
            Me.layoutViewField_colPhoto.StartNewLine = True
            Me.layoutViewField_colPhoto.TextVisible = False
            ' 
            ' lvcFullName
            ' 
            Me.lvcFullName.AppearanceCell.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.lvcFullName.AppearanceCell.Options.UseFont = True
            Me.lvcFullName.Caption = "Name"
            Me.lvcFullName.FieldName = "Name"
            Me.lvcFullName.LayoutViewField = Me.layoutViewField_layoutViewColumn19
            Me.lvcFullName.Name = "lvcFullName"
            Me.lvcFullName.OptionsColumn.AllowEdit = False
            Me.lvcFullName.UnboundExpression = "[FirstName] + ' ' + [LastName]"
            Me.lvcFullName.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            ' 
            ' layoutViewField_layoutViewColumn19
            ' 
            Me.layoutViewField_layoutViewColumn19.EditorPreferredWidth = 113
            Me.layoutViewField_layoutViewColumn19.Location = New System.Drawing.Point(0, 20)
            Me.layoutViewField_layoutViewColumn19.Name = "layoutViewField_layoutViewColumn19"
            Me.layoutViewField_layoutViewColumn19.Size = New System.Drawing.Size(117, 24)
            Me.layoutViewField_layoutViewColumn19.TextVisible = False
            ' 
            ' lvcEdit
            ' 
            Me.lvcEdit.Caption = "layoutViewColumn1"
            Me.lvcEdit.ColumnEdit = Me.repositoryItemHypertextLabel1
            Me.lvcEdit.FieldName = "lvcEdit"
            Me.lvcEdit.LayoutViewField = Me.layoutViewField_layoutViewColumn1
            Me.lvcEdit.Name = "lvcEdit"
            Me.lvcEdit.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
            ' 
            ' repositoryItemHypertextLabel1
            ' 
            Me.repositoryItemHypertextLabel1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemHypertextLabel1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.repositoryItemHypertextLabel1.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far
            Me.repositoryItemHypertextLabel1.ContextImageOptions.SvgImage = CType((resources.GetObject("repositoryItemHypertextLabel1.ContextImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.repositoryItemHypertextLabel1.ContextImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1"
            AddHandler Me.repositoryItemHypertextLabel1.Click, New System.EventHandler(AddressOf Me.repositoryItemHypertextLabel1_Click)
            ' 
            ' layoutViewField_layoutViewColumn1
            ' 
            Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 26
            Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(117, 0)
            Me.layoutViewField_layoutViewColumn1.MaxSize = New System.Drawing.Size(26, 26)
            Me.layoutViewField_layoutViewColumn1.MinSize = New System.Drawing.Size(26, 26)
            Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
            Me.layoutViewField_layoutViewColumn1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(26, 26)
            Me.layoutViewField_layoutViewColumn1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutViewField_layoutViewColumn1.TextVisible = False
            ' 
            ' layoutViewCard1
            ' 
            Me.layoutViewCard1.CustomizationFormText = "TemplateCard"
            Me.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.Group1, Me.layoutViewField_colPhoto})
            Me.layoutViewCard1.Name = "layoutViewCard1"
            Me.layoutViewCard1.OptionsItemText.TextToControlDistance = 5
            Me.layoutViewCard1.Text = "TemplateCard"
            ' 
            ' Group1
            ' 
            Me.Group1.CustomizationFormText = "Group1"
            Me.Group1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.Group1.GroupBordersVisible = False
            Me.Group1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutViewField_colHomePhone, Me.layoutViewField_layoutViewColumn19, Me.layoutViewField_colAddress, Me.layoutViewField_colCity, Me.emptySpaceItem4, Me.layoutViewField_layoutViewColumn1, Me.Item1})
            Me.Group1.Location = New System.Drawing.Point(107, 0)
            Me.Group1.Name = "Group1"
            Me.Group1.Size = New System.Drawing.Size(143, 122)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "Empty Space Item"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 104)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(143, 18)
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.CustomizationFormText = "Empty Space Item"
            Me.emptySpaceItem4.Location = New System.Drawing.Point(117, 26)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(26, 18)
            ' 
            ' Item1
            ' 
            Me.Item1.CustomizationFormText = "Item1"
            Me.Item1.Location = New System.Drawing.Point(0, 0)
            Me.Item1.MaxSize = New System.Drawing.Size(0, 20)
            Me.Item1.MinSize = New System.Drawing.Size(10, 20)
            Me.Item1.Name = "Item1"
            Me.Item1.Size = New System.Drawing.Size(117, 20)
            Me.Item1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' filteringUIContext1
            ' 
            Me.filteringUIContext1.Client = Me.layoutView1
            Me.filteringUIContext1.Control = Me.layoutControl1
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.colorPickEdit1)
            Me.layoutControl1.Controls.Add(Me.FullNameFilterUIEditorContainerEdit)
            Me.layoutControl1.Controls.Add(Me.CategoryNameFilterUIEditorContainerEdit)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit2)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit3)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit4)
            Me.layoutControl1.Controls.Add(Me.colorPickEdit5)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1526, 819, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 518)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' colorPickEdit1
            ' 
            Me.colorPickEdit1.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit1.Location = New System.Drawing.Point(12, 175)
            Me.colorPickEdit1.Name = "colorPickEdit1"
            Me.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit1.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit1.StyleController = Me.layoutControl1
            Me.colorPickEdit1.TabIndex = 11
            ' 
            ' FullNameFilterUIEditorContainerEdit
            ' 
            Me.FullNameFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext1, "FullName", True))
            Me.FullNameFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1"
            Me.FullNameFilterUIEditorContainerEdit.Location = New System.Drawing.Point(12, 34)
            Me.FullNameFilterUIEditorContainerEdit.Name = "FullNameFilterUIEditorContainerEdit"
            Me.FullNameFilterUIEditorContainerEdit.Properties.LookupOptions.LightView = DevExpress.Utils.DefaultBoolean.[True]
            Me.FullNameFilterUIEditorContainerEdit.Properties.LookupOptions.ShowSearchControl = DevExpress.Utils.DefaultBoolean.[False]
            Me.FullNameFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.[Default]
            Me.FullNameFilterUIEditorContainerEdit.Size = New System.Drawing.Size(175, 22)
            Me.FullNameFilterUIEditorContainerEdit.StyleController = Me.layoutControl1
            Me.FullNameFilterUIEditorContainerEdit.TabIndex = 7
            ' 
            ' CategoryNameFilterUIEditorContainerEdit
            ' 
            Me.CategoryNameFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext2, "CategoryName", True))
            Me.CategoryNameFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1"
            Me.CategoryNameFilterUIEditorContainerEdit.Location = New System.Drawing.Point(12, 102)
            Me.CategoryNameFilterUIEditorContainerEdit.Name = "CategoryNameFilterUIEditorContainerEdit"
            Me.CategoryNameFilterUIEditorContainerEdit.Properties.LookupOptions.LightView = DevExpress.Utils.DefaultBoolean.[True]
            Me.CategoryNameFilterUIEditorContainerEdit.Properties.LookupOptions.ShowSearchControl = DevExpress.Utils.DefaultBoolean.[False]
            Me.CategoryNameFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.[Default]
            Me.CategoryNameFilterUIEditorContainerEdit.Size = New System.Drawing.Size(175, 22)
            Me.CategoryNameFilterUIEditorContainerEdit.StyleController = Me.layoutControl1
            Me.CategoryNameFilterUIEditorContainerEdit.TabIndex = 10
            ' 
            ' filteringUIContext2
            ' 
            Me.filteringUIContext2.Client = Me.bandedGridView1
            Me.filteringUIContext2.Control = Me.layoutControl1
            ' 
            ' colorPickEdit2
            ' 
            Me.colorPickEdit2.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit2.Location = New System.Drawing.Point(12, 199)
            Me.colorPickEdit2.Name = "colorPickEdit2"
            Me.colorPickEdit2.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit2.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit2.StyleController = Me.layoutControl1
            Me.colorPickEdit2.TabIndex = 11
            ' 
            ' colorPickEdit3
            ' 
            Me.colorPickEdit3.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit3.Location = New System.Drawing.Point(12, 223)
            Me.colorPickEdit3.Name = "colorPickEdit3"
            Me.colorPickEdit3.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit3.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit3.StyleController = Me.layoutControl1
            Me.colorPickEdit3.TabIndex = 11
            ' 
            ' colorPickEdit4
            ' 
            Me.colorPickEdit4.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit4.Location = New System.Drawing.Point(12, 247)
            Me.colorPickEdit4.Name = "colorPickEdit4"
            Me.colorPickEdit4.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit4.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit4.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit4.StyleController = Me.layoutControl1
            Me.colorPickEdit4.TabIndex = 11
            ' 
            ' colorPickEdit5
            ' 
            Me.colorPickEdit5.EditValue = System.Drawing.Color.Empty
            Me.colorPickEdit5.Location = New System.Drawing.Point(12, 271)
            Me.colorPickEdit5.Name = "colorPickEdit5"
            Me.colorPickEdit5.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.colorPickEdit5.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.colorPickEdit5.Size = New System.Drawing.Size(175, 20)
            Me.colorPickEdit5.StyleController = Me.layoutControl1
            Me.colorPickEdit5.TabIndex = 11
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlGroup4, Me.emptySpaceItem3, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 518)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForFullName})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 68)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Employee "
            ' 
            ' ItemForFullName
            ' 
            Me.ItemForFullName.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.ItemForFullName.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForFullName.Control = Me.FullNameFilterUIEditorContainerEdit
            Me.ItemForFullName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForFullName.Name = "ItemForFullName"
            Me.ItemForFullName.Size = New System.Drawing.Size(179, 26)
            Me.ItemForFullName.StartNewLine = True
            Me.ItemForFullName.Text = "Full Name"
            Me.ItemForFullName.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForFullName.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.ItemForCategoryName})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 68)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(199, 73)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "Products"
            ' 
            ' ItemForCategoryName
            ' 
            Me.ItemForCategoryName.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.ItemForCategoryName.AppearanceItemCaption.Options.UseFont = True
            Me.ItemForCategoryName.Control = Me.CategoryNameFilterUIEditorContainerEdit
            Me.ItemForCategoryName.Location = New System.Drawing.Point(0, 0)
            Me.ItemForCategoryName.Name = "ItemForCategoryName"
            Me.ItemForCategoryName.Size = New System.Drawing.Size(179, 31)
            Me.ItemForCategoryName.StartNewLine = True
            Me.ItemForCategoryName.Text = "Category Name"
            Me.ItemForCategoryName.TextLocation = DevExpress.Utils.Locations.Top
            Me.ItemForCategoryName.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 303)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(199, 215)
            ' 
            ' layoutControlGroup2
            ' 
            buttonImageOptions1.SvgImage = CType((resources.GetObject("buttonImageOptions1.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            buttonImageOptions1.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup2.CustomHeaderButtons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Reset", False, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Reset", -1, True, Nothing, True, False, True, Nothing, -1)})
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 141)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 162)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Fill Colors"
            AddHandler Me.layoutControlGroup2.CustomButtonClick, New DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(AddressOf Me.layoutControlGroup2_CustomButtonClick)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.colorPickEdit1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem1.Text = "#1"
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.colorPickEdit2
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem2.Text = "#2"
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.colorPickEdit3
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem4.Text = "#3"
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.colorPickEdit4
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem5.Text = "#4"
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.colorPickEdit5
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem6.Text = "#5"
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(705, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 551)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 551)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 551)
            Me.tabPane1.TabIndex = 3
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 518)
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 246)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(295, 422)
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.AllowResize = False
            Me.sidePanel2.Controls.Add(Me.layoutGridControl)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Top
            Me.sidePanel2.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel2.MaximumSize = New System.Drawing.Size(0, 190)
            Me.sidePanel2.MinimumSize = New System.Drawing.Size(0, 190)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(705, 190)
            Me.sidePanel2.TabIndex = 8
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' EmployeeSales
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.bandGridControl)
            Me.Controls.Add(Me.sidePanel2)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "EmployeeSales"
            Me.Size = New System.Drawing.Size(905, 551)
            CType((Me.dsOrder), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bandedGridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSparklineEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colAddress), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colCity), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colHomePhone), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_colPhoto), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_layoutViewColumn19), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemHypertextLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewField_layoutViewColumn1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutViewCard1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Group1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Item1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filteringUIContext1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.colorPickEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.FullNameFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.CategoryNameFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filteringUIContext2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit3.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit4.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.colorPickEdit5.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForFullName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ItemForCategoryName), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsOrder As DevExpress.XtraLayout.Demos.dsOrder

        Private bandGridControl As DevExpress.XtraGrid.GridControl

        Private layoutGridControl As DevExpress.XtraGrid.GridControl

        Private layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView

        Private lvcAddress As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private lvcCity As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private lvcHomePhone As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private lvcPhoto As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private lvcFullName As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private filteringUIContext1 As DevExpress.Utils.Filtering.FilteringUIContext

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private FullNameFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForFullName As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private lvcEdit As DevExpress.XtraGrid.Columns.LayoutViewColumn

        Private repositoryItemHypertextLabel1 As DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel

        Private CategoryNameFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit

        Private filteringUIContext2 As DevExpress.Utils.Filtering.FilteringUIContext

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private ItemForCategoryName As DevExpress.XtraLayout.LayoutControlItem

        Private bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView

        Private colProductName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colUnitsInStock As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private colCategoryName As DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn

        Private repositoryItemSparklineEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSparklineEdit

        Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private colorPickEdit1 As DevExpress.XtraEditors.ColorPickEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private colorPickEdit2 As DevExpress.XtraEditors.ColorPickEdit

        Private colorPickEdit3 As DevExpress.XtraEditors.ColorPickEdit

        Private colorPickEdit4 As DevExpress.XtraEditors.ColorPickEdit

        Private colorPickEdit5 As DevExpress.XtraEditors.ColorPickEdit

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutViewField_colAddress As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colCity As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colHomePhone As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_colPhoto As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_layoutViewColumn19 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField

        Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

        Private Group1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private Item1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
