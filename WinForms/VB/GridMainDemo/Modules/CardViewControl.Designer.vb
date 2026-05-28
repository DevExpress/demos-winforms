Namespace DevExpress.XtraGrid.Demos

    Partial Class CardViewControl

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.CardViewControl))
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.cardView1 = New DevExpress.XtraGrid.Views.Card.CardView()
            Me.colTrademark = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colModification = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colCategory = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colBodyStyle = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoExEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
            Me.colDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInStock = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ceAutoHorzWidth = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.sbRecords = New DevExpress.XtraEditors.SimpleButton()
            Me.ceMultiSelect = New DevExpress.XtraEditors.CheckEdit()
            Me.seMaxColumns = New DevExpress.XtraEditors.SpinEdit()
            Me.seMaxRows = New DevExpress.XtraEditors.SpinEdit()
            Me.ceButtons = New DevExpress.XtraEditors.CheckEdit()
            Me.icbFormat = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceCustomize = New DevExpress.XtraEditors.CheckEdit()
            Me.ceFiltering = New DevExpress.XtraEditors.CheckEdit()
            Me.ceImage = New DevExpress.XtraEditors.CheckEdit()
            Me.ceSorting = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem11 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup7 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem9 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.pnlGrid = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAutoHorzWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceMultiSelect.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMaxColumns.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMaxRows.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceButtons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbFormat.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCustomize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceFiltering.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceSorting.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.pnlGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlGrid.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' gridControl1
            ' 
            resources.ApplyResources(Me.gridControl1, "gridControl1")
            Me.gridControl1.MainView = Me.cardView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoExEdit1, Me.repositoryItemPictureEdit1})
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.cardView1})
            ' 
            ' cardView1
            ' 
            Me.cardView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            resources.ApplyResources(Me.cardView1, "cardView1")
            Me.cardView1.CardWidth = 300
            Me.cardView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colTrademark, Me.colName, Me.colModification, Me.colCategory, Me.colBodyStyle, Me.colPhoto, Me.colDescription, Me.colDeliveryDate, Me.colPrice, Me.colInStock})
            Me.cardView1.GridControl = Me.gridControl1
            Me.cardView1.Name = "cardView1"
            Me.cardView1.OptionsBehavior.FieldAutoHeight = True
            AddHandler Me.cardView1.CustomCardCaptionImage, New DevExpress.XtraGrid.Views.Card.CardCaptionImageEventHandler(AddressOf Me.cardView1_CustomCardCaptionImage)
            AddHandler Me.cardView1.SelectionChanged, New DevExpress.Data.SelectionChangedEventHandler(AddressOf Me.cardView1_SelectionChanged)
            AddHandler Me.cardView1.ValidatingEditor, New DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(AddressOf Me.cardView1_ValidatingEditor)
            AddHandler Me.cardView1.Layout, New System.EventHandler(AddressOf Me.cardView1_Layout)
            ' 
            ' colTrademark
            ' 
            Me.colTrademark.FieldName = "Trademark"
            Me.colTrademark.Name = "colTrademark"
            resources.ApplyResources(Me.colTrademark, "colTrademark")
            ' 
            ' colName
            ' 
            Me.colName.FieldName = "Name"
            Me.colName.Name = "colName"
            resources.ApplyResources(Me.colName, "colName")
            ' 
            ' colModification
            ' 
            Me.colModification.FieldName = "Modification"
            Me.colModification.Name = "colModification"
            resources.ApplyResources(Me.colModification, "colModification")
            ' 
            ' colCategory
            ' 
            Me.colCategory.FieldName = "Category"
            Me.colCategory.Name = "colCategory"
            resources.ApplyResources(Me.colCategory, "colCategory")
            ' 
            ' colBodyStyle
            ' 
            Me.colBodyStyle.FieldName = "BodyStyle"
            Me.colBodyStyle.Name = "colBodyStyle"
            resources.ApplyResources(Me.colBodyStyle, "colBodyStyle")
            ' 
            ' colPhoto
            ' 
            Me.colPhoto.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.colPhoto.FieldName = "Photo"
            Me.colPhoto.Name = "colPhoto"
            resources.ApplyResources(Me.colPhoto, "colPhoto")
            ' 
            ' repositoryItemPictureEdit1
            ' 
            Me.repositoryItemPictureEdit1.CustomHeight = 110
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.repositoryItemPictureEdit1.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic
            Me.repositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
            ' 
            ' colDescription
            ' 
            Me.colDescription.ColumnEdit = Me.repositoryItemMemoExEdit1
            Me.colDescription.FieldName = "Description"
            Me.colDescription.Name = "colDescription"
            resources.ApplyResources(Me.colDescription, "colDescription")
            ' 
            ' repositoryItemMemoExEdit1
            ' 
            resources.ApplyResources(Me.repositoryItemMemoExEdit1, "repositoryItemMemoExEdit1")
            Me.repositoryItemMemoExEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("repositoryItemMemoExEdit1.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.repositoryItemMemoExEdit1.Name = "repositoryItemMemoExEdit1"
            Me.repositoryItemMemoExEdit1.PopupFormSize = New System.Drawing.Size(350, 150)
            ' 
            ' colDeliveryDate
            ' 
            Me.colDeliveryDate.FieldName = "DeliveryDate"
            Me.colDeliveryDate.Name = "colDeliveryDate"
            ' 
            ' colPrice
            ' 
            Me.colPrice.FieldName = "Price"
            Me.colPrice.Name = "colPrice"
            resources.ApplyResources(Me.colPrice, "colPrice")
            ' 
            ' colInStock
            ' 
            Me.colInStock.FieldName = "InStock"
            Me.colInStock.Name = "colInStock"
            resources.ApplyResources(Me.colInStock, "colInStock")
            ' 
            ' ceAutoHorzWidth
            ' 
            resources.ApplyResources(Me.ceAutoHorzWidth, "ceAutoHorzWidth")
            Me.ceAutoHorzWidth.Name = "ceAutoHorzWidth"
            Me.ceAutoHorzWidth.Properties.Caption = resources.GetString("ceAutoHorzWidth.Properties.Caption")
            Me.ceAutoHorzWidth.StyleController = Me.layoutControl1
            AddHandler Me.ceAutoHorzWidth.CheckedChanged, New System.EventHandler(AddressOf Me.ceAutoHorzWidth_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.sbRecords)
            Me.layoutControl1.Controls.Add(Me.ceMultiSelect)
            Me.layoutControl1.Controls.Add(Me.seMaxColumns)
            Me.layoutControl1.Controls.Add(Me.seMaxRows)
            Me.layoutControl1.Controls.Add(Me.ceAutoHorzWidth)
            Me.layoutControl1.Controls.Add(Me.ceButtons)
            Me.layoutControl1.Controls.Add(Me.icbFormat)
            Me.layoutControl1.Controls.Add(Me.ceCustomize)
            Me.layoutControl1.Controls.Add(Me.ceFiltering)
            Me.layoutControl1.Controls.Add(Me.ceImage)
            Me.layoutControl1.Controls.Add(Me.ceSorting)
            resources.ApplyResources(Me.layoutControl1, "layoutControl1")
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1256, 291, 1017, 646)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            ' 
            ' sbRecords
            ' 
            resources.ApplyResources(Me.sbRecords, "sbRecords")
            Me.sbRecords.Name = "sbRecords"
            Me.sbRecords.StyleController = Me.layoutControl1
            AddHandler Me.sbRecords.Click, New System.EventHandler(AddressOf Me.sbRecords_Click)
            ' 
            ' ceMultiSelect
            ' 
            resources.ApplyResources(Me.ceMultiSelect, "ceMultiSelect")
            Me.ceMultiSelect.Name = "ceMultiSelect"
            Me.ceMultiSelect.Properties.Caption = resources.GetString("ceMultiSelect.Properties.Caption")
            Me.ceMultiSelect.StyleController = Me.layoutControl1
            AddHandler Me.ceMultiSelect.CheckedChanged, New System.EventHandler(AddressOf Me.ceMultiSelect_CheckedChanged)
            ' 
            ' seMaxColumns
            ' 
            resources.ApplyResources(Me.seMaxColumns, "seMaxColumns")
            Me.seMaxColumns.Name = "seMaxColumns"
            Me.seMaxColumns.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaxColumns.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seMaxColumns.Properties.IsFloatValue = False
            Me.seMaxColumns.Properties.Mask.EditMask = resources.GetString("seMaxColumns.Properties.Mask.EditMask")
            Me.seMaxColumns.Properties.MaxValue = New Decimal(New Integer() {7, 0, 0, 0})
            Me.seMaxColumns.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.seMaxColumns.Properties.ValidateOnEnterKey = True
            Me.seMaxColumns.StyleController = Me.layoutControl1
            AddHandler Me.seMaxColumns.EditValueChanged, New System.EventHandler(AddressOf Me.seMaxColumns_EditValueChanged)
            ' 
            ' seMaxRows
            ' 
            resources.ApplyResources(Me.seMaxRows, "seMaxRows")
            Me.seMaxRows.Name = "seMaxRows"
            Me.seMaxRows.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaxRows.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seMaxRows.Properties.IsFloatValue = False
            Me.seMaxRows.Properties.Mask.EditMask = resources.GetString("seMaxRows.Properties.Mask.EditMask")
            Me.seMaxRows.Properties.MaxValue = New Decimal(New Integer() {7, 0, 0, 0})
            Me.seMaxRows.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.seMaxRows.Properties.ValidateOnEnterKey = True
            Me.seMaxRows.StyleController = Me.layoutControl1
            AddHandler Me.seMaxRows.EditValueChanged, New System.EventHandler(AddressOf Me.seMaxRows_EditValueChanged)
            ' 
            ' ceButtons
            ' 
            resources.ApplyResources(Me.ceButtons, "ceButtons")
            Me.ceButtons.Name = "ceButtons"
            Me.ceButtons.Properties.Caption = resources.GetString("ceButtons.Properties.Caption")
            Me.ceButtons.StyleController = Me.layoutControl1
            AddHandler Me.ceButtons.CheckedChanged, New System.EventHandler(AddressOf Me.ceButtons_CheckedChanged)
            ' 
            ' icbFormat
            ' 
            resources.ApplyResources(Me.icbFormat, "icbFormat")
            Me.icbFormat.Name = "icbFormat"
            Me.icbFormat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(CType((resources.GetObject("icbFormat.Properties.Buttons")), DevExpress.XtraEditors.Controls.ButtonPredefines))})
            Me.icbFormat.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items"), resources.GetString("icbFormat.Properties.Items1"), (CInt((resources.GetObject("icbFormat.Properties.Items2"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items3"), resources.GetString("icbFormat.Properties.Items4"), (CInt((resources.GetObject("icbFormat.Properties.Items5"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items6"), resources.GetString("icbFormat.Properties.Items7"), (CInt((resources.GetObject("icbFormat.Properties.Items8"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items9"), resources.GetString("icbFormat.Properties.Items10"), (CInt((resources.GetObject("icbFormat.Properties.Items11"))))), New DevExpress.XtraEditors.Controls.ImageComboBoxItem(resources.GetString("icbFormat.Properties.Items12"), resources.GetString("icbFormat.Properties.Items13"), (CInt((resources.GetObject("icbFormat.Properties.Items14")))))})
            Me.icbFormat.StyleController = Me.layoutControl1
            AddHandler Me.icbFormat.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbFormat_SelectedIndexChanged)
            ' 
            ' ceCustomize
            ' 
            resources.ApplyResources(Me.ceCustomize, "ceCustomize")
            Me.ceCustomize.Name = "ceCustomize"
            Me.ceCustomize.Properties.Caption = resources.GetString("ceCustomize.Properties.Caption")
            Me.ceCustomize.StyleController = Me.layoutControl1
            AddHandler Me.ceCustomize.CheckedChanged, New System.EventHandler(AddressOf Me.ceCustomize_CheckedChanged)
            ' 
            ' ceFiltering
            ' 
            resources.ApplyResources(Me.ceFiltering, "ceFiltering")
            Me.ceFiltering.Name = "ceFiltering"
            Me.ceFiltering.Properties.Caption = resources.GetString("ceFiltering.Properties.Caption")
            Me.ceFiltering.StyleController = Me.layoutControl1
            AddHandler Me.ceFiltering.CheckedChanged, New System.EventHandler(AddressOf Me.ceFiltering_CheckedChanged)
            ' 
            ' ceImage
            ' 
            resources.ApplyResources(Me.ceImage, "ceImage")
            Me.ceImage.Name = "ceImage"
            Me.ceImage.Properties.Caption = resources.GetString("ceImage.Properties.Caption")
            Me.ceImage.StyleController = Me.layoutControl1
            AddHandler Me.ceImage.CheckedChanged, New System.EventHandler(AddressOf Me.ceImage_CheckedChanged)
            ' 
            ' ceSorting
            ' 
            resources.ApplyResources(Me.ceSorting, "ceSorting")
            Me.ceSorting.Name = "ceSorting"
            Me.ceSorting.Properties.Caption = resources.GetString("ceSorting.Properties.Caption")
            Me.ceSorting.StyleController = Me.layoutControl1
            AddHandler Me.ceSorting.CheckedChanged, New System.EventHandler(AddressOf Me.ceSorting_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup5, Me.layoutControlGroup6, Me.layoutControlGroup7, Me.layoutControlGroup2, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 569)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem3})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup5"
            Me.layoutControlGroup5.Size = New System.Drawing.Size(249, 124)
            Me.layoutControlGroup5.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup5, "layoutControlGroup5")
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceFiltering
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.ceSorting
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.ceCustomize
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' emptySpaceItem3
            ' 
            Me.emptySpaceItem3.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem3.Name = "emptySpaceItem3"
            Me.emptySpaceItem3.Size = New System.Drawing.Size(229, 10)
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem2, Me.emptySpaceItem11})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 124)
            Me.layoutControlGroup6.Name = "layoutControlGroup6"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(249, 124)
            Me.layoutControlGroup6.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup6, "layoutControlGroup6")
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceButtons
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbFormat
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.layoutControlItem3, "layoutControlItem3")
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceImage
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem11
            ' 
            Me.emptySpaceItem11.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem11.Name = "emptySpaceItem11"
            Me.emptySpaceItem11.Size = New System.Drawing.Size(229, 10)
            ' 
            ' layoutControlGroup7
            ' 
            Me.layoutControlGroup7.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup7.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem9, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem5})
            Me.layoutControlGroup7.Location = New System.Drawing.Point(0, 248)
            Me.layoutControlGroup7.Name = "layoutControlGroup7"
            Me.layoutControlGroup7.Size = New System.Drawing.Size(249, 124)
            Me.layoutControlGroup7.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup7, "layoutControlGroup7")
            ' 
            ' emptySpaceItem9
            ' 
            Me.emptySpaceItem9.Location = New System.Drawing.Point(0, 48)
            Me.emptySpaceItem9.Name = "emptySpaceItem9"
            Me.emptySpaceItem9.Size = New System.Drawing.Size(229, 10)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seMaxRows
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.layoutControlItem6, "layoutControlItem6")
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seMaxColumns
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(229, 24)
            resources.ApplyResources(Me.layoutControlItem7, "layoutControlItem7")
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceAutoHorzWidth
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8, Me.layoutControlItem11})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 372)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 92)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            resources.ApplyResources(Me.layoutControlGroup2, "layoutControlGroup2")
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.ceMultiSelect
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.sbRecords
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 464)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(249, 105)
            ' 
            ' timer1
            ' 
            Me.timer1.Interval = 500
            ' 
            ' navigationPane1
            ' 
            Me.navigationPane1.Controls.Add(Me.navigationPage1)
            resources.ApplyResources(Me.navigationPane1, "navigationPane1")
            Me.navigationPane1.Name = "navigationPane1"
            Me.navigationPane1.PageProperties.AppearanceCaption.Options.UseTextOptions = True
            Me.navigationPane1.PageProperties.AppearanceCaption.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text
            Me.navigationPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.navigationPage1})
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 602)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            ' 
            ' navigationPage1
            ' 
            resources.ApplyResources(Me.navigationPage1, "navigationPage1")
            Me.navigationPage1.Controls.Add(Me.layoutControl1)
            Me.navigationPage1.ImageOptions.ImageUri.Uri = "New"
            Me.navigationPage1.Name = "navigationPage1"
            ' 
            ' pnlGrid
            ' 
            Me.pnlGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlGrid.Controls.Add(Me.gridControl1)
            resources.ApplyResources(Me.pnlGrid, "pnlGrid")
            Me.pnlGrid.Name = "pnlGrid"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            resources.ApplyResources(Me.sidePanel1, "sidePanel1")
            Me.sidePanel1.Name = "sidePanel1"
            ' 
            ' CardViewControl
            ' 
            resources.ApplyResources(Me, "$this")
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pnlGrid)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CardViewControl"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CardView_Load)
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cardView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoExEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAutoHorzWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceMultiSelect.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMaxColumns.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMaxRows.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceButtons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbFormat.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCustomize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceFiltering.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceSorting.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
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

        Private timer1 As System.Windows.Forms.Timer

        Private cardView1 As DevExpress.XtraGrid.Views.Card.CardView

        Private ceCustomize As DevExpress.XtraEditors.CheckEdit

        Private repositoryItemMemoExEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private ceImage As DevExpress.XtraEditors.CheckEdit

        Private ceButtons As DevExpress.XtraEditors.CheckEdit

        Private icbFormat As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seMaxColumns As DevExpress.XtraEditors.SpinEdit

        Private ceAutoHorzWidth As DevExpress.XtraEditors.CheckEdit

        Private seMaxRows As DevExpress.XtraEditors.SpinEdit

        Private ceMultiSelect As DevExpress.XtraEditors.CheckEdit

        Private sbRecords As DevExpress.XtraEditors.SimpleButton

        Private ceSorting As DevExpress.XtraEditors.CheckEdit

        Private ceFiltering As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private pnlGrid As DevExpress.XtraEditors.PanelControl

        Private colTrademark As DevExpress.XtraGrid.Columns.GridColumn

        Private colName As DevExpress.XtraGrid.Columns.GridColumn

        Private colModification As DevExpress.XtraGrid.Columns.GridColumn

        Private colCategory As DevExpress.XtraGrid.Columns.GridColumn

        Private colBodyStyle As DevExpress.XtraGrid.Columns.GridColumn

        Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn

        Private colDescription As DevExpress.XtraGrid.Columns.GridColumn

        Private colDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colInStock As DevExpress.XtraGrid.Columns.GridColumn

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem11 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup7 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem9 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
