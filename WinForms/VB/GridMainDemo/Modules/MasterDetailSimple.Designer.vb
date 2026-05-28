Imports DevExpress.Export

Namespace DevExpress.XtraGrid.Demos

    Partial Class MasterDetailSimple

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.MasterDetailSimple))
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitsInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colUnitsOnOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colReorderLevel = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.dsNWindCategories1 = New DevExpress.XtraGrid.Demos.dsNWindCategories()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPicture = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.sbExpandDetails = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceShowEmbeddedDetailIndent = New DevExpress.XtraEditors.CheckEdit()
            Me.icbDetailMode = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.sbBestFit = New DevExpress.XtraEditors.SimpleButton()
            Me.seRowHeight = New DevExpress.XtraEditors.SpinEdit()
            Me.ceRowAutoHeight = New DevExpress.XtraEditors.CheckEdit()
            Me.ceEnabledMasterViewMode = New DevExpress.XtraEditors.ToggleSwitch()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsNWindCategories1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceShowEmbeddedDetailIndent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbDetailMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seRowHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceRowAutoHeight.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceEnabledMasterViewMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colQuantityPerUnit, Me.colUnitPrice, Me.colUnitsInStock, Me.colUnitsOnOrder, Me.colReorderLevel, Me.colDiscontinued})
            Me.gridView2.GridControl = Me.gridControl1
            Me.gridView2.GroupCount = 1
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView2.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDiscontinued, DevExpress.Data.ColumnSortOrder.Ascending)})
            AddHandler Me.gridView2.CustomRowCellEditForEditing, New DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(AddressOf Me.gridView2_CustomRowCellEditForEditing)
            ' 
            ' colProductName
            ' 
            Me.colProductName.FieldName = "ProductName"
            Me.colProductName.Name = "colProductName"
            Me.colProductName.Visible = True
            Me.colProductName.VisibleIndex = 0
            Me.colProductName.Width = 199
            ' 
            ' colQuantityPerUnit
            ' 
            Me.colQuantityPerUnit.FieldName = "QuantityPerUnit"
            Me.colQuantityPerUnit.Name = "colQuantityPerUnit"
            Me.colQuantityPerUnit.Visible = True
            Me.colQuantityPerUnit.VisibleIndex = 1
            Me.colQuantityPerUnit.Width = 104
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.ImageOptions.SvgImage = CType((resources.GetObject("colUnitPrice.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colUnitPrice.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            Me.colUnitPrice.Width = 95
            ' 
            ' colUnitsInStock
            ' 
            Me.colUnitsInStock.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsInStock.FieldName = "UnitsInStock"
            Me.colUnitsInStock.Name = "colUnitsInStock"
            Me.colUnitsInStock.Visible = True
            Me.colUnitsInStock.VisibleIndex = 3
            Me.colUnitsInStock.Width = 95
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colUnitsOnOrder
            ' 
            Me.colUnitsOnOrder.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colUnitsOnOrder.FieldName = "UnitsOnOrder"
            Me.colUnitsOnOrder.Name = "colUnitsOnOrder"
            Me.colUnitsOnOrder.Visible = True
            Me.colUnitsOnOrder.VisibleIndex = 4
            Me.colUnitsOnOrder.Width = 95
            ' 
            ' colReorderLevel
            ' 
            Me.colReorderLevel.Caption = "Reorder <b>Level"
            Me.colReorderLevel.ColumnEdit = Me.repositoryItemProgressBar1
            Me.colReorderLevel.FieldName = "ReorderLevel"
            Me.colReorderLevel.Name = "colReorderLevel"
            Me.colReorderLevel.Visible = True
            Me.colReorderLevel.VisibleIndex = 5
            Me.colReorderLevel.Width = 95
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' colDiscontinued
            ' 
            Me.colDiscontinued.FieldName = "Discontinued"
            Me.colDiscontinued.Name = "colDiscontinued"
            Me.colDiscontinued.Visible = True
            Me.colDiscontinued.VisibleIndex = 6
            Me.colDiscontinued.Width = 106
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataMember = "Categories"
            Me.gridControl1.DataSource = Me.dsNWindCategories1
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.gridView2
            gridLevelNode1.RelationName = "CategoriesProducts"
            Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2, Me.repositoryItemProgressBar1, Me.repositoryItemPictureEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(634, 550)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1, Me.gridView2})
            ' 
            ' dsNWindCategories1
            ' 
            Me.dsNWindCategories1.DataSetName = "dsNWindCategories"
            Me.dsNWindCategories1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCategoryID, Me.colCategoryName, Me.colDescription, Me.colPicture})
            Me.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
            Me.gridView1.OptionsDetail.ShowDetailTabs = False
            Me.gridView1.OptionsDetail.ShowEmbeddedDetailIndent = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsPrint.ExpandAllDetails = True
            Me.gridView1.OptionsPrint.PrintDetails = True
            Me.gridView1.OptionsView.ColumnAutoWidth = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
            Me.gridView1.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.RowHeight = 60
            AddHandler Me.gridView1.MasterRowExpanded, New DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(AddressOf Me.gridView1_MasterRowExpanded)
            ' 
            ' colCategoryID
            ' 
            Me.colCategoryID.FieldName = "CategoryID"
            Me.colCategoryID.Name = "colCategoryID"
            ' 
            ' colCategoryName
            ' 
            Me.colCategoryName.FieldName = "CategoryName"
            Me.colCategoryName.ImageOptions.SvgImage = CType((resources.GetObject("colCategoryName.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colCategoryName.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colCategoryName.Name = "colCategoryName"
            Me.colCategoryName.Visible = True
            Me.colCategoryName.VisibleIndex = 1
            Me.colCategoryName.Width = 148
            ' 
            ' colDescription
            ' 
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            Me.colDescription.Visible = True
            Me.colDescription.VisibleIndex = 2
            Me.colDescription.Width = 297
            ' 
            ' colPicture
            ' 
            Me.colPicture.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPicture.FieldName = "Picture"
            Me.colPicture.Name = "colPicture"
            Me.colPicture.OptionsFilter.AllowFilter = False
            Me.colPicture.Visible = True
            Me.colPicture.VisibleIndex = 0
            Me.colPicture.Width = 190
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' repositoryItemSpinEdit2
            ' 
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit2.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.repositoryItemSpinEdit2.IsFloatValue = False
            Me.repositoryItemSpinEdit2.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit2.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' sbExpandDetails
            ' 
            Me.sbExpandDetails.Location = New System.Drawing.Point(12, 162)
            Me.sbExpandDetails.Name = "sbExpandDetails"
            Me.sbExpandDetails.Size = New System.Drawing.Size(225, 22)
            Me.sbExpandDetails.StyleController = Me.layoutControl1
            Me.sbExpandDetails.TabIndex = 0
            Me.sbExpandDetails.Text = "Expand All Details"
            AddHandler Me.sbExpandDetails.Click, New System.EventHandler(AddressOf Me.sbExpandDetails_Click)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceShowEmbeddedDetailIndent)
            Me.layoutControl1.Controls.Add(Me.icbDetailMode)
            Me.layoutControl1.Controls.Add(Me.sbExpandDetails)
            Me.layoutControl1.Controls.Add(Me.sbBestFit)
            Me.layoutControl1.Controls.Add(Me.seRowHeight)
            Me.layoutControl1.Controls.Add(Me.ceRowAutoHeight)
            Me.layoutControl1.Controls.Add(Me.ceEnabledMasterViewMode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1024, 471, 450, 350)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(249, 517)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceShowEmbeddedDetailIndent
            ' 
            Me.ceShowEmbeddedDetailIndent.Location = New System.Drawing.Point(12, 138)
            Me.ceShowEmbeddedDetailIndent.Name = "ceShowEmbeddedDetailIndent"
            Me.ceShowEmbeddedDetailIndent.Properties.Caption = "Show Embedded Detail Indent"
            Me.ceShowEmbeddedDetailIndent.Size = New System.Drawing.Size(225, 20)
            Me.ceShowEmbeddedDetailIndent.StyleController = Me.layoutControl1
            Me.ceShowEmbeddedDetailIndent.TabIndex = 5
            AddHandler Me.ceShowEmbeddedDetailIndent.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowEmbeddedDetailIndent_CheckedChanged)
            ' 
            ' icbDetailMode
            ' 
            Me.icbDetailMode.Location = New System.Drawing.Point(12, 114)
            Me.icbDetailMode.Name = "icbDetailMode"
            Me.icbDetailMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbDetailMode.Size = New System.Drawing.Size(225, 20)
            Me.icbDetailMode.StyleController = Me.layoutControl1
            Me.icbDetailMode.TabIndex = 4
            AddHandler Me.icbDetailMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbDetailMode_SelectedIndexChanged)
            ' 
            ' sbBestFit
            ' 
            Me.sbBestFit.Location = New System.Drawing.Point(12, 294)
            Me.sbBestFit.Name = "sbBestFit"
            Me.sbBestFit.Size = New System.Drawing.Size(225, 22)
            Me.sbBestFit.StyleController = Me.layoutControl1
            Me.sbBestFit.TabIndex = 0
            Me.sbBestFit.Text = "Columns Best Fit"
            AddHandler Me.sbBestFit.Click, New System.EventHandler(AddressOf Me.sbBestFit_Click)
            ' 
            ' seRowHeight
            ' 
            Me.seRowHeight.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.seRowHeight.Location = New System.Drawing.Point(12, 246)
            Me.seRowHeight.Name = "seRowHeight"
            Me.seRowHeight.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.seRowHeight.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seRowHeight.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.seRowHeight.Properties.IsFloatValue = False
            Me.seRowHeight.Properties.Mask.EditMask = "N00"
            Me.seRowHeight.Properties.MaxValue = New Decimal(New Integer() {180, 0, 0, 0})
            Me.seRowHeight.Properties.MinValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.seRowHeight.Size = New System.Drawing.Size(225, 20)
            Me.seRowHeight.StyleController = Me.layoutControl1
            Me.seRowHeight.TabIndex = 1
            AddHandler Me.seRowHeight.EditValueChanged, New System.EventHandler(AddressOf Me.seRowHeight_EditValueChanged)
            ' 
            ' ceRowAutoHeight
            ' 
            Me.ceRowAutoHeight.Location = New System.Drawing.Point(12, 270)
            Me.ceRowAutoHeight.Name = "ceRowAutoHeight"
            Me.ceRowAutoHeight.Properties.Caption = "Row Auto Height"
            Me.ceRowAutoHeight.Size = New System.Drawing.Size(225, 20)
            Me.ceRowAutoHeight.StyleController = Me.layoutControl1
            Me.ceRowAutoHeight.TabIndex = 2
            AddHandler Me.ceRowAutoHeight.CheckedChanged, New System.EventHandler(AddressOf Me.ceRowAutoHeight_CheckedChanged)
            ' 
            ' ceEnabledMasterViewMode
            ' 
            Me.ceEnabledMasterViewMode.Location = New System.Drawing.Point(12, 34)
            Me.ceEnabledMasterViewMode.Name = "ceEnabledMasterViewMode"
            Me.ceEnabledMasterViewMode.Properties.Appearance.FontStyleDelta = System.Drawing.FontStyle.Bold
            Me.ceEnabledMasterViewMode.Properties.Appearance.Options.UseFont = True
            Me.ceEnabledMasterViewMode.Properties.OffText = "Off"
            Me.ceEnabledMasterViewMode.Properties.OnText = "On"
            Me.ceEnabledMasterViewMode.Size = New System.Drawing.Size(225, 18)
            Me.ceEnabledMasterViewMode.StyleController = Me.layoutControl1
            Me.ceEnabledMasterViewMode.TabIndex = 3
            AddHandler Me.ceEnabledMasterViewMode.Toggled, New System.EventHandler(AddressOf Me.ceEnabledMasterViewMode_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem2, Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 517)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 328)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(249, 189)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3, Me.layoutControlItem7, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 132)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Detail"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.AllowHtmlStringInCaption = True
            Me.layoutControlItem3.Control = Me.icbDetailMode
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 40)
            Me.layoutControlItem3.Text = "Detail Mode:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(60, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceShowEmbeddedDetailIndent
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.sbExpandDetails
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 64)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Master-Detail"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceEnabledMasterViewMode
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(229, 22)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem1, Me.layoutControlItem4})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 196)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(249, 132)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "Rows"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.sbBestFit
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.seRowHeight
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 40)
            Me.layoutControlItem1.Text = "Row Height:"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(60, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceRowAutoHeight
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            Me.navigationPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navigationPane1.Location = New System.Drawing.Point(1, 0)
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 550)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 550)
            Me.navigationPane1.TabIndex = 15
            Me.navigationPane1.Text = "navigationPane1"
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(249, 517)
            ' 
            ' pnlGrid
            ' 
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            Me.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlGrid.Location = New System.Drawing.Point(0, 0)
            Me.pnlGrid.Name = "pnlGrid"
            Me.pnlGrid.Size = New System.Drawing.Size(634, 550)
            Me.pnlGrid.TabIndex = 16
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(634, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 550)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' MasterDetailSimple
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "MasterDetailSimple"
            Me.Size = New System.Drawing.Size(884, 550)
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsNWindCategories1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceShowEmbeddedDetailIndent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbDetailMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seRowHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceRowAutoHeight.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceEnabledMasterViewMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlGrid.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private dsNWindCategories1 As DevExpress.XtraGrid.Demos.dsNWindCategories

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsInStock As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitsOnOrder As DevExpress.XtraGrid.Columns.GridColumn

        Private colReorderLevel As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn

        Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn

        Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn

        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

        Private colPicture As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private sbBestFit As DevExpress.XtraEditors.SimpleButton

        Private ceRowAutoHeight As DevExpress.XtraEditors.CheckEdit

        Private seRowHeight As DevExpress.XtraEditors.SpinEdit

        Private sbExpandDetails As DevExpress.XtraEditors.SimpleButton

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private pnlGrid As DevExpress.XtraEditors.PanelControl

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private ceShowEmbeddedDetailIndent As DevExpress.XtraEditors.CheckEdit

        Private icbDetailMode As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private ceEnabledMasterViewMode As DevExpress.XtraEditors.ToggleSwitch

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
