Namespace DevExpress.DevAV.Modules

    Partial Class Orders

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
            Dim gridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
            Dim tableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
            Dim tableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition4 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition5 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableRowDefinition6 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
            Dim tableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
            Dim tileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement7 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement8 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement9 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim tileViewItemElement10 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim galleryItemGroup1 As DevExpress.XtraBars.Ribbon.GalleryItemGroup = New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItem1 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem2 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem3 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem4 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem5 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim galleryItem6 As DevExpress.XtraBars.Ribbon.GalleryItem = New DevExpress.XtraBars.Ribbon.GalleryItem()
            Dim skinPaddingEdges1 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges2 As DevExpress.Skins.SkinPaddingEdges = New DevExpress.Skins.SkinPaddingEdges()
            Me.gridViewOrderItems = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductUnits = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProductPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl = New DevExpress.XtraGrid.GridControl()
            Me.bindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.gridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colCustomer = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPaymentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipmentStatus = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInvoiceNumber = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotalAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colStore = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipDate1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShippingAmount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colPaymentTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colRefundTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colShipmentCourier = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colId1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
            Me.repositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
            Me.tileViewOrderItems = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.tileViewColumnProductName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumnProductUnits = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumnProductPrice = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumnDiscount = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumnTotal = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.tileViewColumnProductImage = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.ribbonControl = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.biNewOrder = New DevExpress.XtraBars.BarButtonItem()
            Me.biShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.biMap = New DevExpress.XtraBars.BarButtonItem()
            Me.biChangeViewSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiShowMasterDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiShowList = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.biDataPaneSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiHorizontalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiVerticalLayout = New DevExpress.XtraBars.BarCheckItem()
            Me.bmiHideDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biResetView = New DevExpress.XtraBars.BarButtonItem()
            Me.biPrintSubItem = New DevExpress.XtraBars.BarSubItem()
            Me.bmiPrintInvoice = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSalesSummary = New DevExpress.XtraBars.BarButtonItem()
            Me.bmiPrintSalesAnalysis = New DevExpress.XtraBars.BarButtonItem()
            Me.galleryQuickReports = New DevExpress.XtraBars.RibbonGalleryBarItem()
            Me.biViewSettings = New DevExpress.XtraBars.BarButtonItem()
            Me.biReverseSort = New DevExpress.XtraBars.BarButtonItem()
            Me.biAddColumns = New DevExpress.XtraBars.BarCheckItem()
            Me.biExpandCollapse = New DevExpress.XtraBars.BarButtonItem()
            Me.biNewCustomFilter = New DevExpress.XtraBars.BarButtonItem()
            Me.hiItemsCount = New DevExpress.XtraBars.BarHeaderItem()
            Me.biShowMasterDetail = New DevExpress.XtraBars.BarCheckItem()
            Me.biShowCard = New DevExpress.XtraBars.BarCheckItem()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup8 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup6 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup5 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup7 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup9 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonStatusBar = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
            Me.roundedSkinPanel1 = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.roundedSkinPanelPnlView = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.navigationRoundedPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridViewOrderItems), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tileViewOrderItems), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel1.SuspendLayout()
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationRoundedPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.gridViewOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProduct, Me.colProductUnits, Me.colProductPrice, Me.colDiscount, Me.colTotal, Me.colId})
            Me.gridViewOrderItems.GridControl = Me.gridControl
            Me.gridViewOrderItems.Name = "gridViewOrderItems"
            Me.gridViewOrderItems.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridViewOrderItems.OptionsView.ShowFooter = True
            Me.gridViewOrderItems.OptionsView.ShowGroupPanel = False
            Me.gridViewOrderItems.OptionsView.ShowIndicator = False
            Me.gridViewOrderItems.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.colProduct.Caption = "<b>PRODUCT</b>"
            Me.colProduct.FieldName = "Product.Name"
            Me.colProduct.Name = "colProduct"
            Me.colProduct.OptionsColumn.AllowFocus = False
            Me.colProduct.Visible = True
            Me.colProduct.VisibleIndex = 0
            Me.colProductUnits.Caption = "Units"
            Me.colProductUnits.FieldName = "ProductUnits"
            Me.colProductUnits.Name = "colProductUnits"
            Me.colProductUnits.OptionsColumn.AllowFocus = False
            Me.colProductUnits.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "ProductUnits", "SUM={0}")})
            Me.colProductUnits.Visible = True
            Me.colProductUnits.VisibleIndex = 1
            Me.colProductPrice.Caption = "Unit Price"
            Me.colProductPrice.DisplayFormat.FormatString = "c"
            Me.colProductPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colProductPrice.FieldName = "ProductPrice"
            Me.colProductPrice.Name = "colProductPrice"
            Me.colProductPrice.OptionsColumn.AllowFocus = False
            Me.colProductPrice.Visible = True
            Me.colProductPrice.VisibleIndex = 2
            Me.colDiscount.Caption = "Discount"
            Me.colDiscount.DisplayFormat.FormatString = "c"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.OptionsColumn.AllowFocus = False
            Me.colDiscount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, "Discount", "AVG={0:c}")})
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 3
            Me.colTotal.Caption = "Total"
            Me.colTotal.DisplayFormat.FormatString = "c"
            Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal.FieldName = "Total"
            Me.colTotal.Name = "colTotal"
            Me.colTotal.OptionsColumn.AllowFocus = False
            Me.colTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", "SUM={0:c}")})
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 4
            Me.colId.FieldName = "Id"
            Me.colId.Name = "colId"
            Me.colId.OptionsColumn.AllowFocus = False
            Me.gridControl.DataSource = Me.bindingSource
            Me.gridControl.Dock = System.Windows.Forms.DockStyle.Fill
            gridLevelNode1.LevelTemplate = Me.gridViewOrderItems
            gridLevelNode1.RelationName = "OrderItems"
            Me.gridControl.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {gridLevelNode1})
            Me.gridControl.Location = New System.Drawing.Point(169, 9)
            Me.gridControl.MainView = Me.gridView
            Me.gridControl.Margin = New System.Windows.Forms.Padding(12)
            Me.gridControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.gridControl.Name = "gridControl"
            Me.gridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemMemoEdit1, Me.repositoryItemPictureEdit1})
            Me.gridControl.ShowOnlyPredefinedDetails = True
            Me.gridControl.Size = New System.Drawing.Size(595, 554)
            Me.gridControl.TabIndex = 1
            Me.gridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView, Me.tileViewOrderItems, Me.gridViewOrderItems})
            Me.bindingSource.DataSource = GetType(DevExpress.DevAV.Order)
            Me.gridView.AutoFillColumn = Me.colCustomer
            Me.gridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPaymentStatus, Me.colShipmentStatus, Me.colInvoiceNumber, Me.colOrderDate, Me.colTotalAmount, Me.colStore, Me.colCustomer, Me.colShipDate1, Me.colShippingAmount, Me.colPaymentTotal, Me.colRefundTotal, Me.colShipmentCourier, Me.colId1})
            Me.gridView.DetailVerticalIndent = 2
            Me.gridView.GridControl = Me.gridControl
            Me.gridView.Name = "gridView"
            Me.gridView.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView.OptionsBehavior.Editable = False
            Me.gridView.OptionsBehavior.[ReadOnly] = True
            Me.gridView.OptionsDetail.AllowZoomDetail = False
            Me.gridView.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded
            Me.gridView.OptionsDetail.ShowDetailTabs = False
            Me.gridView.OptionsDetail.SmartDetailExpandButtonMode = DevExpress.XtraGrid.Views.Grid.DetailExpandButtonMode.AlwaysEnabled
            Me.gridView.OptionsDetail.SmartDetailHeight = True
            Me.gridView.OptionsFind.AlwaysVisible = True
            Me.gridView.OptionsFind.FindNullPrompt = "Search Orders (Ctrl + F)"
            Me.gridView.OptionsFind.ShowClearButton = False
            Me.gridView.OptionsFind.ShowFindButton = False
            Me.gridView.OptionsMenu.ShowConditionalFormattingItem = True
            Me.gridView.OptionsView.ShowGroupPanel = False
            Me.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
            Me.gridView.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrderDate, DevExpress.Data.ColumnSortOrder.Ascending)})
            Me.colCustomer.Caption = "Company"
            Me.colCustomer.FieldName = "Customer.Name"
            Me.colCustomer.Name = "colCustomer"
            Me.colCustomer.OptionsColumn.AllowFocus = False
            Me.colCustomer.Visible = True
            Me.colCustomer.VisibleIndex = 5
            Me.colCustomer.Width = 88
            Me.colPaymentStatus.FieldName = "PaymentStatus"
            Me.colPaymentStatus.Name = "colPaymentStatus"
            Me.colPaymentStatus.OptionsColumn.AllowFocus = False
            Me.colPaymentStatus.OptionsColumn.AllowMove = False
            Me.colPaymentStatus.OptionsColumn.FixedWidth = True
            Me.colPaymentStatus.OptionsColumn.ShowCaption = False
            Me.colPaymentStatus.Visible = True
            Me.colPaymentStatus.VisibleIndex = 0
            Me.colPaymentStatus.Width = 40
            Me.colShipmentStatus.FieldName = "ShipmentStatus"
            Me.colShipmentStatus.Name = "colShipmentStatus"
            Me.colShipmentStatus.OptionsColumn.AllowFocus = False
            Me.colShipmentStatus.OptionsColumn.AllowMove = False
            Me.colShipmentStatus.OptionsColumn.FixedWidth = True
            Me.colShipmentStatus.OptionsColumn.ShowCaption = False
            Me.colShipmentStatus.Visible = True
            Me.colShipmentStatus.VisibleIndex = 1
            Me.colShipmentStatus.Width = 40
            Me.colInvoiceNumber.Caption = "Invoice #"
            Me.colInvoiceNumber.FieldName = "InvoiceNumber"
            Me.colInvoiceNumber.Name = "colInvoiceNumber"
            Me.colInvoiceNumber.OptionsColumn.AllowFocus = False
            Me.colInvoiceNumber.Visible = True
            Me.colInvoiceNumber.VisibleIndex = 2
            Me.colInvoiceNumber.Width = 70
            Me.colOrderDate.Caption = "Order Date"
            Me.colOrderDate.FieldName = "OrderDate"
            Me.colOrderDate.Name = "colOrderDate"
            Me.colOrderDate.OptionsColumn.AllowFocus = False
            Me.colOrderDate.Visible = True
            Me.colOrderDate.VisibleIndex = 3
            Me.colOrderDate.Width = 78
            Me.colTotalAmount.Caption = "Order Total"
            Me.colTotalAmount.DisplayFormat.FormatString = "c"
            Me.colTotalAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotalAmount.FieldName = "TotalAmount"
            Me.colTotalAmount.Name = "colTotalAmount"
            Me.colTotalAmount.OptionsColumn.AllowFocus = False
            Me.colTotalAmount.Visible = True
            Me.colTotalAmount.VisibleIndex = 8
            Me.colTotalAmount.Width = 90
            Me.colStore.Caption = "Store"
            Me.colStore.FieldName = "Store.CrestCity"
            Me.colStore.Name = "colStore"
            Me.colStore.OptionsColumn.AllowFocus = False
            Me.colStore.Visible = True
            Me.colStore.VisibleIndex = 6
            Me.colStore.Width = 80
            Me.colShipDate1.Caption = "Ship Date"
            Me.colShipDate1.FieldName = "ShipDate"
            Me.colShipDate1.Name = "colShipDate1"
            Me.colShipDate1.OptionsColumn.AllowFocus = False
            Me.colShipDate1.Visible = True
            Me.colShipDate1.VisibleIndex = 4
            Me.colShipDate1.Width = 78
            Me.colShippingAmount.Caption = "Shipping Amount"
            Me.colShippingAmount.DisplayFormat.FormatString = "c"
            Me.colShippingAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colShippingAmount.FieldName = "ShippingAmount"
            Me.colShippingAmount.Name = "colShippingAmount"
            Me.colShippingAmount.OptionsColumn.AllowFocus = False
            Me.colShippingAmount.Visible = True
            Me.colShippingAmount.VisibleIndex = 7
            Me.colShippingAmount.Width = 110
            Me.colPaymentTotal.Caption = "Payment Total"
            Me.colPaymentTotal.DisplayFormat.FormatString = "c"
            Me.colPaymentTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colPaymentTotal.FieldName = "PaymentTotal"
            Me.colPaymentTotal.Name = "colPaymentTotal"
            Me.colPaymentTotal.OptionsColumn.AllowFocus = False
            Me.colPaymentTotal.Visible = True
            Me.colPaymentTotal.VisibleIndex = 9
            Me.colPaymentTotal.Width = 90
            Me.colRefundTotal.Caption = "Refund Total"
            Me.colRefundTotal.DisplayFormat.FormatString = "c"
            Me.colRefundTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colRefundTotal.FieldName = "RefundTotal"
            Me.colRefundTotal.Name = "colRefundTotal"
            Me.colRefundTotal.OptionsColumn.AllowFocus = False
            Me.colShipmentCourier.Caption = "Shipment Courier"
            Me.colShipmentCourier.FieldName = "ShipmentCourier"
            Me.colShipmentCourier.Name = "colShipmentCourier"
            Me.colShipmentCourier.OptionsColumn.AllowFocus = False
            Me.colId1.FieldName = "Id"
            Me.colId1.Name = "colId1"
            Me.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1"
            Me.repositoryItemPictureEdit1.Name = "repositoryItemPictureEdit1"
            Me.tileViewOrderItems.Appearance.EmptySpace.BackColor = System.Drawing.Color.Transparent
            Me.tileViewOrderItems.Appearance.EmptySpace.Options.UseBackColor = True
            Me.tileViewOrderItems.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tileViewColumnProductName, Me.tileViewColumnProductUnits, Me.tileViewColumnProductPrice, Me.tileViewColumnDiscount, Me.tileViewColumnTotal, Me.tileViewColumnProductImage})
            Me.tileViewOrderItems.DetailHeight = 190
            Me.tileViewOrderItems.GridControl = Me.gridControl
            Me.tileViewOrderItems.Name = "tileViewOrderItems"
            Me.tileViewOrderItems.OptionsTiles.AllowPressAnimation = False
            Me.tileViewOrderItems.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None
            Me.tileViewOrderItems.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(10, 4, 10, 4)
            Me.tileViewOrderItems.OptionsTiles.ItemSize = New System.Drawing.Size(334, 157)
            tableColumnDefinition1.Length.Value = 131R
            tableColumnDefinition2.Length.Value = 95R
            tableColumnDefinition2.PaddingLeft = 15
            tableColumnDefinition3.Length.Value = 92R
            Me.tileViewOrderItems.TileColumns.Add(tableColumnDefinition1)
            Me.tileViewOrderItems.TileColumns.Add(tableColumnDefinition2)
            Me.tileViewOrderItems.TileColumns.Add(tableColumnDefinition3)
            tableRowDefinition1.Length.Value = 18R
            tableRowDefinition2.Length.Value = 15R
            tableRowDefinition3.Length.Value = 15R
            tableRowDefinition4.Length.Value = 15R
            tableRowDefinition5.Length.Value = 13R
            tableRowDefinition6.Length.Value = 15R
            Me.tileViewOrderItems.TileRows.Add(tableRowDefinition1)
            Me.tileViewOrderItems.TileRows.Add(tableRowDefinition2)
            Me.tileViewOrderItems.TileRows.Add(tableRowDefinition3)
            Me.tileViewOrderItems.TileRows.Add(tableRowDefinition4)
            Me.tileViewOrderItems.TileRows.Add(tableRowDefinition5)
            Me.tileViewOrderItems.TileRows.Add(tableRowDefinition6)
            tableSpan1.ColumnSpan = 3
            tableSpan2.RowIndex = 1
            tableSpan2.RowSpan = 5
            Me.tileViewOrderItems.TileSpans.Add(tableSpan1)
            Me.tileViewOrderItems.TileSpans.Add(tableSpan2)
            tileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement1.Appearance.Normal.Options.UseFont = True
            tileViewItemElement1.Column = Me.tileViewColumnProductName
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement1.Text = "tileViewColumnProductName"
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement2.Column = Me.tileViewColumnProductImage
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement2.RowIndex = 1
            tileViewItemElement2.Text = "tileViewColumnProductImage"
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement3.Appearance.Normal.Options.UseFont = True
            tileViewItemElement3.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement3.ColumnIndex = 1
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement3.RowIndex = 1
            tileViewItemElement3.Text = "Units:"
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement4.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement4.Appearance.Normal.Options.UseFont = True
            tileViewItemElement4.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement4.ColumnIndex = 1
            tileViewItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement4.RowIndex = 2
            tileViewItemElement4.Text = "Unit Price:"
            tileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            tileViewItemElement5.Appearance.Normal.Options.UseFont = True
            tileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
            tileViewItemElement5.ColumnIndex = 1
            tileViewItemElement5.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement5.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement5.RowIndex = 3
            tileViewItemElement5.Text = "Discount:"
            tileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement6.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement6.Appearance.Normal.Options.UseFont = True
            tileViewItemElement6.ColumnIndex = 1
            tileViewItemElement6.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement6.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement6.RowIndex = 4
            tileViewItemElement6.Text = "Sub Total:"
            tileViewItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement7.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement7.Appearance.Normal.Options.UseFont = True
            tileViewItemElement7.Column = Me.tileViewColumnProductUnits
            tileViewItemElement7.ColumnIndex = 2
            tileViewItemElement7.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement7.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement7.RowIndex = 1
            tileViewItemElement7.Text = "tileViewColumnProductUnits"
            tileViewItemElement7.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement8.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement8.Appearance.Normal.Options.UseFont = True
            tileViewItemElement8.Column = Me.tileViewColumnProductPrice
            tileViewItemElement8.ColumnIndex = 2
            tileViewItemElement8.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement8.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement8.RowIndex = 2
            tileViewItemElement8.Text = "tileViewColumnProductPrice"
            tileViewItemElement8.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement9.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement9.Appearance.Normal.Options.UseFont = True
            tileViewItemElement9.Column = Me.tileViewColumnDiscount
            tileViewItemElement9.ColumnIndex = 2
            tileViewItemElement9.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement9.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement9.RowIndex = 3
            tileViewItemElement9.Text = "tileViewColumnDiscount"
            tileViewItemElement9.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            tileViewItemElement10.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            tileViewItemElement10.Appearance.Normal.Options.UseFont = True
            tileViewItemElement10.Column = Me.tileViewColumnTotal
            tileViewItemElement10.ColumnIndex = 2
            tileViewItemElement10.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
            tileViewItemElement10.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            tileViewItemElement10.RowIndex = 4
            tileViewItemElement10.Text = "tileViewColumnTotal"
            tileViewItemElement10.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement1)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement2)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement3)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement4)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement5)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement6)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement7)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement8)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement9)
            Me.tileViewOrderItems.TileTemplate.Add(tileViewItemElement10)
            Me.tileViewColumnProductName.Caption = "Product"
            Me.tileViewColumnProductName.FieldName = "Product.Name"
            Me.tileViewColumnProductName.Name = "tileViewColumnProductName"
            Me.tileViewColumnProductName.Visible = True
            Me.tileViewColumnProductName.VisibleIndex = 0
            Me.tileViewColumnProductUnits.Caption = "Units"
            Me.tileViewColumnProductUnits.FieldName = "ProductUnits"
            Me.tileViewColumnProductUnits.Name = "tileViewColumnProductUnits"
            Me.tileViewColumnProductUnits.Visible = True
            Me.tileViewColumnProductUnits.VisibleIndex = 1
            Me.tileViewColumnProductPrice.Caption = "Unit Price"
            Me.tileViewColumnProductPrice.DisplayFormat.FormatString = "c"
            Me.tileViewColumnProductPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.tileViewColumnProductPrice.FieldName = "ProductPrice"
            Me.tileViewColumnProductPrice.Name = "tileViewColumnProductPrice"
            Me.tileViewColumnProductPrice.Visible = True
            Me.tileViewColumnProductPrice.VisibleIndex = 2
            Me.tileViewColumnDiscount.Caption = "Discount"
            Me.tileViewColumnDiscount.DisplayFormat.FormatString = "c"
            Me.tileViewColumnDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.tileViewColumnDiscount.FieldName = "Discount"
            Me.tileViewColumnDiscount.Name = "tileViewColumnDiscount"
            Me.tileViewColumnDiscount.Visible = True
            Me.tileViewColumnDiscount.VisibleIndex = 3
            Me.tileViewColumnTotal.Caption = "Total"
            Me.tileViewColumnTotal.DisplayFormat.FormatString = "c"
            Me.tileViewColumnTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.tileViewColumnTotal.FieldName = "Total"
            Me.tileViewColumnTotal.Name = "tileViewColumnTotal"
            Me.tileViewColumnTotal.Visible = True
            Me.tileViewColumnTotal.VisibleIndex = 4
            Me.tileViewColumnProductImage.Caption = "Image"
            Me.tileViewColumnProductImage.ColumnEdit = Me.repositoryItemPictureEdit1
            Me.tileViewColumnProductImage.FieldName = "Product.ProductImage"
            Me.tileViewColumnProductImage.Name = "tileViewColumnProductImage"
            Me.tileViewColumnProductImage.Visible = True
            Me.tileViewColumnProductImage.VisibleIndex = 5
            Me.ribbonControl.CommandLayout = DevExpress.XtraBars.Ribbon.CommandLayout.Simplified
            Me.ribbonControl.ExpandCollapseItem.Id = 0
            Me.ribbonControl.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl.ExpandCollapseItem, Me.biNewOrder, Me.biShowList, Me.biMap, Me.biChangeViewSubItem, Me.biDataPaneSubItem, Me.bmiHideDetail, Me.bmiHorizontalLayout, Me.bmiVerticalLayout, Me.biResetView, Me.bmiShowList, Me.biPrintSubItem, Me.bmiPrintInvoice, Me.galleryQuickReports, Me.biViewSettings, Me.biReverseSort, Me.biAddColumns, Me.biExpandCollapse, Me.biNewCustomFilter, Me.bmiPrintSalesSummary, Me.bmiPrintSalesAnalysis, Me.hiItemsCount, Me.biShowMasterDetail, Me.biShowCard, Me.bmiShowMasterDetail, Me.bmiShowCard})
            Me.ribbonControl.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl.MaxItemId = 16
            Me.ribbonControl.Name = "ribbonControl"
            Me.ribbonControl.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1, Me.ribbonPage2})
            Me.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonControl.Size = New System.Drawing.Size(1273, 122)
            Me.ribbonControl.StatusBar = Me.ribbonStatusBar
            Me.biNewOrder.Caption = "New Order"
            Me.biNewOrder.Id = 1
            Me.biNewOrder.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewOrder.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewOrder.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.NewOrder.svg"
            Me.biNewOrder.Name = "biNewOrder"
            Me.biShowList.Caption = "List"
            Me.biShowList.GroupIndex = 1
            Me.biShowList.Id = 4
            Me.biShowList.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biShowList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.List.svg"
            Me.biShowList.Name = "biShowList"
            Me.biMap.Caption = "Shipping Map"
            Me.biMap.Id = 8
            Me.biMap.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biMap.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biMap.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Mapit.svg"
            Me.biMap.Name = "biMap"
            Me.biChangeViewSubItem.Caption = "Change View"
            Me.biChangeViewSubItem.Id = 10
            Me.biChangeViewSubItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biChangeViewSubItem.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biChangeViewSubItem.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.ChangeView.svg"
            Me.biChangeViewSubItem.ImageOptions.LargeImageIndex = 40
            Me.biChangeViewSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowMasterDetail), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowList), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiShowCard)})
            Me.biChangeViewSubItem.Name = "biChangeViewSubItem"
            Me.biChangeViewSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiShowMasterDetail.Caption = "Details"
            Me.bmiShowMasterDetail.GroupIndex = 3
            Me.bmiShowMasterDetail.Id = 13
            Me.bmiShowMasterDetail.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowMasterDetail.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Detailed.svg"
            Me.bmiShowMasterDetail.Name = "bmiShowMasterDetail"
            Me.bmiShowList.Caption = "List"
            Me.bmiShowList.GroupIndex = 3
            Me.bmiShowList.Id = 4
            Me.bmiShowList.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowList.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-list-16.png"
            Me.bmiShowList.Name = "bmiShowList"
            Me.bmiShowCard.Caption = "Card"
            Me.bmiShowCard.GroupIndex = 3
            Me.bmiShowCard.Id = 15
            Me.bmiShowCard.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiShowCard.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.icon-card-16.png"
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
            Me.bmiHorizontalLayout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiHorizontalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelRight.svg?Size=16x16"
            Me.bmiHorizontalLayout.Name = "bmiHorizontalLayout"
            Me.bmiVerticalLayout.Caption = "Bottom"
            Me.bmiVerticalLayout.GroupIndex = 2
            Me.bmiVerticalLayout.Id = 7
            Me.bmiVerticalLayout.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiVerticalLayout.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PanelBottom.svg?Size=16x16"
            Me.bmiVerticalLayout.Name = "bmiVerticalLayout"
            Me.bmiHideDetail.Caption = "Off"
            Me.bmiHideDetail.GroupIndex = 2
            Me.bmiHideDetail.Id = 7
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
            Me.biPrintSubItem.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintInvoice), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSalesSummary), New DevExpress.XtraBars.LinkPersistInfo(Me.bmiPrintSalesAnalysis)})
            Me.biPrintSubItem.Name = "biPrintSubItem"
            Me.biPrintSubItem.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.bmiPrintInvoice.Caption = "Invoice"
            Me.bmiPrintInvoice.GroupIndex = 5
            Me.bmiPrintInvoice.Id = 6
            Me.bmiPrintInvoice.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintInvoice.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-sales-invoice-16.png"
            Me.bmiPrintInvoice.Name = "bmiPrintInvoice"
            Me.bmiPrintSalesSummary.Caption = "Summary Report"
            Me.bmiPrintSalesSummary.Id = 9
            Me.bmiPrintSalesSummary.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintSalesSummary.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-sales-report-16.png"
            Me.bmiPrintSalesSummary.Name = "bmiPrintSalesSummary"
            Me.bmiPrintSalesAnalysis.Caption = "Sales Analysis"
            Me.bmiPrintSalesAnalysis.Id = 10
            Me.bmiPrintSalesAnalysis.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.bmiPrintSalesAnalysis.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.PrintItems.icon-sales-by-store-16.png"
            Me.bmiPrintSalesAnalysis.Name = "bmiPrintSalesAnalysis"
            Me.galleryQuickReports.Caption = "Quick Reports"
            Me.galleryQuickReports.Gallery.ColumnCount = 2
            Me.galleryQuickReports.Gallery.DrawImageBackground = False
            galleryItemGroup1.Caption = "Group1"
            galleryItem1.Caption = "Revenue Report"
            galleryItem1.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem1.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-sales-quick-report-16.png"
            galleryItem2.Caption = "Follow Up"
            galleryItem2.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem2.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-sales-quick-thankyou-16.png" & ""
            galleryItem3.Caption = "Revenue Analysis"
            galleryItem3.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem3.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.QuickItems.icon-sales-quick-summary-16.png"
            galleryItem4.Caption = "Invoice (DOC)"
            galleryItem4.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem4.ImageOptions.ImageUri.Uri = "ExportToDOC;Size16x16"
            galleryItem5.Caption = "Invoice (XLS)"
            galleryItem5.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem5.ImageOptions.ImageUri.Uri = "ExportToXLS;Size16x16"
            galleryItem6.Caption = "Invoice (PDF)"
            galleryItem6.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            galleryItem6.ImageOptions.ImageUri.Uri = "ExportToPDF;Size16x16"
            galleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() {galleryItem1, galleryItem2, galleryItem3, galleryItem4, galleryItem5, galleryItem6})
            Me.galleryQuickReports.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() {galleryItemGroup1})
            Me.galleryQuickReports.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            skinPaddingEdges1.Bottom = -3
            skinPaddingEdges1.Top = -3
            Me.galleryQuickReports.Gallery.ItemImagePadding = skinPaddingEdges1
            skinPaddingEdges2.Bottom = -1
            skinPaddingEdges2.Top = -1
            Me.galleryQuickReports.Gallery.ItemTextPadding = skinPaddingEdges2
            Me.galleryQuickReports.Gallery.ShowItemText = True
            Me.galleryQuickReports.Id = 15
            Me.galleryQuickReports.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.galleryQuickReports.ImageOptions.ImageUri.Uri = "business%20objects/bo_document"
            Me.galleryQuickReports.Name = "galleryQuickReports"
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
            Me.biNewCustomFilter.Caption = "Custom Filter"
            Me.biNewCustomFilter.Id = 8
            Me.biNewCustomFilter.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biNewCustomFilter.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biNewCustomFilter.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Filter.svg"
            Me.biNewCustomFilter.Name = "biNewCustomFilter"
            Me.hiItemsCount.Caption = "Records: 0"
            Me.hiItemsCount.Id = 7
            Me.hiItemsCount.Name = "hiItemsCount"
            Me.biShowMasterDetail.Caption = "Detail"
            Me.biShowMasterDetail.GroupIndex = 1
            Me.biShowMasterDetail.Id = 11
            Me.biShowMasterDetail.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biShowMasterDetail.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowMasterDetail.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Detailed.svg"
            Me.biShowMasterDetail.Name = "biShowMasterDetail"
            Me.biShowCard.Caption = "Card"
            Me.biShowCard.GroupIndex = 1
            Me.biShowCard.Id = 12
            Me.biShowCard.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[False]
            Me.biShowCard.ImageOptions.ImageUri.ResourceType = GetType(DevExpress.DevAV.MainForm)
            Me.biShowCard.ImageOptions.ImageUri.Uri = "resource://DevExpress.DevAV.Resources.Card.svg"
            Me.biShowCard.Name = "biShowCard"
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup3, Me.ribbonPageGroup8, Me.ribbonPageGroup4, Me.ribbonPageGroup6})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "Home"
            Me.ribbonPageGroup1.AllowTextClipping = False
            Me.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup1.ItemLinks.Add(Me.biNewOrder)
            Me.ribbonPageGroup1.MergeOrder = 0
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "New"
            Me.ribbonPageGroup3.AllowTextClipping = False
            Me.ribbonPageGroup3.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup3.ItemLinks.Add(Me.biPrintSubItem)
            Me.ribbonPageGroup3.MergeOrder = 0
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "Actions"
            Me.ribbonPageGroup8.AllowTextClipping = False
            Me.ribbonPageGroup8.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup8.ItemLinks.Add(Me.galleryQuickReports)
            Me.ribbonPageGroup8.MergeOrder = 0
            Me.ribbonPageGroup8.Name = "ribbonPageGroup8"
            Me.ribbonPageGroup8.Text = "Quick Reports"
            Me.ribbonPageGroup4.AllowTextClipping = False
            Me.ribbonPageGroup4.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.ribbonPageGroup4.ItemLinks.Add(Me.biShowMasterDetail)
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
            Me.ribbonPageGroup6.Text = "Find"
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
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biReverseSort)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biAddColumns)
            Me.ribbonPageGroup9.ItemLinks.Add(Me.biExpandCollapse)
            Me.ribbonPageGroup9.MergeOrder = 1
            Me.ribbonPageGroup9.Name = "ribbonPageGroup9"
            Me.ribbonStatusBar.ItemLinks.Add(Me.hiItemsCount)
            Me.ribbonStatusBar.Location = New System.Drawing.Point(0, 694)
            Me.ribbonStatusBar.Name = "ribbonStatusBar"
            Me.ribbonStatusBar.Ribbon = Me.ribbonControl
            Me.ribbonStatusBar.Size = New System.Drawing.Size(1273, 37)
            Me.roundedSkinPanel1.Controls.Add(Me.gridControl)
            Me.roundedSkinPanel1.Controls.Add(Me.roundedSkinPanelPnlView)
            Me.roundedSkinPanel1.Controls.Add(Me.navigationRoundedPanel)
            Me.roundedSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel1.Location = New System.Drawing.Point(0, 122)
            Me.roundedSkinPanel1.Name = "roundedSkinPanel1"
            Me.roundedSkinPanel1.Size = New System.Drawing.Size(1273, 572)
            Me.roundedSkinPanel1.TabIndex = 8
            Me.roundedSkinPanel1.Text = "roundedSkinPanel1"
            Me.roundedSkinPanelPnlView.AllowResize = DevExpress.Utils.DefaultBoolean.[True]
            Me.roundedSkinPanelPnlView.Dock = System.Windows.Forms.DockStyle.Right
            Me.roundedSkinPanelPnlView.Location = New System.Drawing.Point(765, 8)
            Me.roundedSkinPanelPnlView.MaximumSize = New System.Drawing.Size(700, 0)
            Me.roundedSkinPanelPnlView.MinimumSize = New System.Drawing.Size(400, 0)
            Me.roundedSkinPanelPnlView.Name = "roundedSkinPanelPnlView"
            Me.roundedSkinPanelPnlView.Size = New System.Drawing.Size(500, 556)
            Me.roundedSkinPanelPnlView.TabIndex = 0
            Me.navigationRoundedPanel.BorderStyle = DevExpress.XtraEditors.RoundedPanelBorderStyle.NoBorder
            Me.navigationRoundedPanel.Dock = System.Windows.Forms.DockStyle.Left
            Me.navigationRoundedPanel.Location = New System.Drawing.Point(8, 8)
            Me.navigationRoundedPanel.Name = "navigationRoundedPanel"
            Me.navigationRoundedPanel.Size = New System.Drawing.Size(160, 556)
            Me.navigationRoundedPanel.TabIndex = 2
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.roundedSkinPanel1)
            Me.Controls.Add(Me.ribbonControl)
            Me.Controls.Add(Me.ribbonStatusBar)
            Me.Margin = New System.Windows.Forms.Padding(6)
            Me.Name = "Orders"
            Me.Size = New System.Drawing.Size(1273, 731)
            CType((Me.mvvmContext), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridViewOrderItems), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.bindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemMemoEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemPictureEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tileViewOrderItems), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.roundedSkinPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel1.ResumeLayout(False)
            CType((Me.roundedSkinPanelPnlView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationRoundedPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private gridControl As DevExpress.XtraGrid.GridControl

        Private gridView As DevExpress.XtraGrid.Views.Grid.GridView

        Private bindingSource As System.Windows.Forms.BindingSource

        Private repositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit

        Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn

        Private colTotalAmount As DevExpress.XtraGrid.Columns.GridColumn

        Private gridViewOrderItems As DevExpress.XtraGrid.Views.Grid.GridView

        Private colProduct As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductUnits As DevExpress.XtraGrid.Columns.GridColumn

        Private colProductPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private colTotal As DevExpress.XtraGrid.Columns.GridColumn

        Private colId As DevExpress.XtraGrid.Columns.GridColumn

        Private ribbonControl As DevExpress.XtraBars.Ribbon.RibbonControl

        Private biNewOrder As DevExpress.XtraBars.BarButtonItem

        Private biShowList As DevExpress.XtraBars.BarCheckItem

        Private biShowMasterDetail As DevExpress.XtraBars.BarCheckItem

        Private biShowCard As DevExpress.XtraBars.BarCheckItem

        Private biMap As DevExpress.XtraBars.BarButtonItem

        Private biChangeViewSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiShowList As DevExpress.XtraBars.BarCheckItem

        Private bmiShowMasterDetail As DevExpress.XtraBars.BarCheckItem

        Private bmiShowCard As DevExpress.XtraBars.BarCheckItem

        Private biDataPaneSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiHorizontalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiVerticalLayout As DevExpress.XtraBars.BarCheckItem

        Private bmiHideDetail As DevExpress.XtraBars.BarCheckItem

        Private biResetView As DevExpress.XtraBars.BarButtonItem

        Private biPrintSubItem As DevExpress.XtraBars.BarSubItem

        Private bmiPrintInvoice As DevExpress.XtraBars.BarButtonItem

        Private bmiPrintSalesSummary As DevExpress.XtraBars.BarButtonItem

        Private bmiPrintSalesAnalysis As DevExpress.XtraBars.BarButtonItem

        Private galleryQuickReports As DevExpress.XtraBars.RibbonGalleryBarItem

        Private biViewSettings As DevExpress.XtraBars.BarButtonItem

        Private biReverseSort As DevExpress.XtraBars.BarButtonItem

        Private biAddColumns As DevExpress.XtraBars.BarCheckItem

        Private biExpandCollapse As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup8 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup6 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private ribbonPageGroup5 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup7 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonPageGroup9 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private ribbonStatusBar As DevExpress.XtraBars.Ribbon.RibbonStatusBar

        Private hiItemsCount As DevExpress.XtraBars.BarHeaderItem

        Private colInvoiceNumber As DevExpress.XtraGrid.Columns.GridColumn

        Private colStore As DevExpress.XtraGrid.Columns.GridColumn

        Private colCustomer As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipDate1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colShippingAmount As DevExpress.XtraGrid.Columns.GridColumn

        Private biNewCustomFilter As DevExpress.XtraBars.BarButtonItem

        Private colPaymentTotal As DevExpress.XtraGrid.Columns.GridColumn

        Private colPaymentStatus As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipmentStatus As DevExpress.XtraGrid.Columns.GridColumn

        Private colRefundTotal As DevExpress.XtraGrid.Columns.GridColumn

        Private colShipmentCourier As DevExpress.XtraGrid.Columns.GridColumn

        Private tileViewOrderItems As DevExpress.XtraGrid.Views.Tile.TileView

        Private tileViewColumnProductName As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumnProductImage As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumnProductUnits As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumnProductPrice As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumnDiscount As DevExpress.XtraGrid.Columns.TileViewColumn

        Private tileViewColumnTotal As DevExpress.XtraGrid.Columns.TileViewColumn

        Private repositoryItemPictureEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit

        Private colId1 As DevExpress.XtraGrid.Columns.GridColumn

        Private roundedSkinPanel1 As DevExpress.XtraEditors.RoundedSkinPanel

        Private roundedSkinPanelPnlView As DevExpress.XtraEditors.RoundedSkinPanel

        Private navigationRoundedPanel As DevExpress.XtraEditors.RoundedSkinPanel
    End Class
End Namespace
