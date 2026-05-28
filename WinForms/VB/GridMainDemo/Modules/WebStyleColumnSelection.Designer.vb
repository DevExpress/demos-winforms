Namespace DevExpress.XtraGrid.Demos

    Partial Class WebStyleColumnSelection

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGrid.Demos.WebStyleColumnSelection))
            Me.repositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrder = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colProduct = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            Me.cePrintSelectedRowsOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceBindSelection = New DevExpress.XtraEditors.CheckEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.icbShowCheckBoxSelectorInGroupRow = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowCheckBoxSelectorInPrintExport = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbShowCheckBoxSelectorInHeader = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.navigationPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.navigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePrintSelectedRowsOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.ceBindSelection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbShowCheckBoxSelectorInGroupRow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbShowCheckBoxSelectorInPrintExport.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbShowCheckBoxSelectorInHeader.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.navigationPane1.SuspendLayout()
            Me.navigationPage1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' repositoryItemTextEdit1
            ' 
            Me.repositoryItemTextEdit1.AutoHeight = False
            Me.repositoryItemTextEdit1.Mask.EditMask = "p"
            Me.repositoryItemTextEdit1.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Me.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Buttons.CancelEdit.Visible = False
            Me.gridControl1.EmbeddedNavigator.Buttons.EndEdit.Visible = False
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemLookUpEdit1, Me.repositoryItemCalcEdit1, Me.repositoryItemSpinEdit1, Me.repositoryItemTextEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(559, 409)
            Me.gridControl1.TabIndex = 8
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrder, Me.colProduct, Me.colUnitPrice, Me.colQuantity, Me.colDiscount, Me.colTotal})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.GroupCount = 1
            Me.gridView1.Images = Me.svgImageCollection1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsBehavior.AutoExpandAllGroups = True
            Me.gridView1.OptionsBehavior.Editable = False
            Me.gridView1.OptionsClipboard.ClipboardMode = DevExpress.Export.ClipboardMode.Formatted
            Me.gridView1.OptionsDetail.EnableMasterViewMode = False
            Me.gridView1.OptionsFind.AlwaysVisible = True
            Me.gridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
            Me.gridView1.OptionsSelection.MultiSelect = True
            Me.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsSelection.ShowCheckBoxSelectorInPrintExport = DevExpress.Utils.DefaultBoolean.[True]
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.ShowFooter = True
            Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colOrder, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colOrder
            ' 
            Me.colOrder.Caption = "Order #"
            Me.colOrder.FieldName = "OrderID"
            Me.colOrder.ImageOptions.SvgImage = CType((resources.GetObject("colOrder.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.colOrder.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.colOrder.Name = "colOrder"
            Me.colOrder.Width = 86
            ' 
            ' colProduct
            ' 
            Me.colProduct.Caption = "Product"
            Me.colProduct.ColumnEdit = Me.repositoryItemLookUpEdit1
            Me.colProduct.FieldName = "ProductID"
            Me.colProduct.ImageOptions.ImageIndex = 3
            Me.colProduct.Name = "colProduct"
            Me.colProduct.Visible = True
            Me.colProduct.VisibleIndex = 1
            Me.colProduct.Width = 146
            ' 
            ' repositoryItemLookUpEdit1
            ' 
            Me.repositoryItemLookUpEdit1.AutoHeight = False
            Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Product Name")})
            Me.repositoryItemLookUpEdit1.DisplayMember = "ProductName"
            Me.repositoryItemLookUpEdit1.DropDownRows = 10
            Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
            Me.repositoryItemLookUpEdit1.PopupWidth = 220
            Me.repositoryItemLookUpEdit1.ShowHeader = False
            Me.repositoryItemLookUpEdit1.ValueMember = "ProductID"
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "Unit Price"
            Me.colUnitPrice.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colUnitPrice.DisplayFormat.FormatString = "c"
            Me.colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.ImageOptions.ImageIndex = 2
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, DevExpress.Data.SummaryMode.Selection, "UnitPrice", "SUM={0:c}")})
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 3
            Me.colUnitPrice.Width = 85
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Mask.EditMask = "c"
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.Caption = "Quantity"
            Me.colQuantity.ColumnEdit = Me.repositoryItemSpinEdit1
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.ImageOptions.ImageIndex = 4
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 2
            Me.colQuantity.Width = 82
            ' 
            ' repositoryItemSpinEdit1
            ' 
            Me.repositoryItemSpinEdit1.AutoHeight = False
            Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit1.IsFloatValue = False
            Me.repositoryItemSpinEdit1.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.Caption = "Discount"
            Me.colDiscount.ColumnEdit = Me.repositoryItemTextEdit1
            Me.colDiscount.DisplayFormat.FormatString = "p"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.ImageOptions.ImageIndex = 0
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Average, DevExpress.Data.SummaryMode.Mixed, "Discount", "AVG={0:p}")})
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 4
            Me.colDiscount.Width = 80
            ' 
            ' colTotal
            ' 
            Me.colTotal.Caption = "<b><u>Total"
            Me.colTotal.DisplayFormat.FormatString = "c"
            Me.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colTotal.FieldName = "Total"
            Me.colTotal.ImageOptions.ImageIndex = 1
            Me.colTotal.Name = "colTotal"
            Me.colTotal.OptionsColumn.AllowEdit = False
            Me.colTotal.ShowUnboundExpressionMenu = True
            Me.colTotal.UnboundDataType = GetType(Decimal)
            Me.colTotal.UnboundExpression = "[UnitPrice] * [Quantity] * (1 - [Discount])"
            Me.colTotal.Visible = True
            Me.colTotal.VisibleIndex = 5
            Me.colTotal.Width = 109
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("Discount", CType((resources.GetObject("svgImageCollection1.Discount")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Sales", CType((resources.GetObject("svgImageCollection1.Sales")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("UnitPrice", CType((resources.GetObject("svgImageCollection1.UnitPrice")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Product", CType((resources.GetObject("svgImageCollection1.Product")), DevExpress.Utils.Svg.SvgImage))
            Me.svgImageCollection1.Add("Quantity", CType((resources.GetObject("svgImageCollection1.Quantity")), DevExpress.Utils.Svg.SvgImage))
            ' 
            ' cePrintSelectedRowsOnly
            ' 
            Me.cePrintSelectedRowsOnly.Location = New System.Drawing.Point(12, 240)
            Me.cePrintSelectedRowsOnly.Name = "cePrintSelectedRowsOnly"
            Me.cePrintSelectedRowsOnly.Properties.Caption = "Print Selected Rows Only"
            Me.cePrintSelectedRowsOnly.Size = New System.Drawing.Size(225, 20)
            Me.cePrintSelectedRowsOnly.StyleController = Me.layoutControl2
            Me.cePrintSelectedRowsOnly.TabIndex = 12
            AddHandler Me.cePrintSelectedRowsOnly.CheckedChanged, New System.EventHandler(AddressOf Me.cePrintSelectedRowsOnly_CheckedChanged)
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AllowCustomization = False
            Me.layoutControl2.Controls.Add(Me.ceBindSelection)
            Me.layoutControl2.Controls.Add(Me.simpleButton1)
            Me.layoutControl2.Controls.Add(Me.cePrintSelectedRowsOnly)
            Me.layoutControl2.Controls.Add(Me.icbShowCheckBoxSelectorInGroupRow)
            Me.layoutControl2.Controls.Add(Me.icbShowCheckBoxSelectorInPrintExport)
            Me.layoutControl2.Controls.Add(Me.icbShowCheckBoxSelectorInHeader)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1032, 180, 450, 350)
            Me.layoutControl2.Root = Me.layoutControlGroup3
            Me.layoutControl2.Size = New System.Drawing.Size(249, 376)
            Me.layoutControl2.TabIndex = 0
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' ceBindSelection
            ' 
            Me.ceBindSelection.Location = New System.Drawing.Point(12, 12)
            Me.ceBindSelection.Name = "ceBindSelection"
            Me.ceBindSelection.Properties.Caption = "Bind Selection to Data Source"
            Me.ceBindSelection.Size = New System.Drawing.Size(225, 20)
            Me.ceBindSelection.StyleController = Me.layoutControl2
            Me.ceBindSelection.TabIndex = 14
            AddHandler Me.ceBindSelection.CheckedChanged, New System.EventHandler(AddressOf Me.ceBindSelection_CheckedChanged)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 264)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(225, 22)
            Me.simpleButton1.StyleController = Me.layoutControl2
            Me.simpleButton1.TabIndex = 13
            Me.simpleButton1.Text = "Print Preview"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' icbShowCheckBoxSelectorInGroupRow
            ' 
            Me.icbShowCheckBoxSelectorInGroupRow.Location = New System.Drawing.Point(12, 94)
            Me.icbShowCheckBoxSelectorInGroupRow.Name = "icbShowCheckBoxSelectorInGroupRow"
            Me.icbShowCheckBoxSelectorInGroupRow.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInGroupRow.Size = New System.Drawing.Size(225, 20)
            Me.icbShowCheckBoxSelectorInGroupRow.StyleController = Me.layoutControl2
            Me.icbShowCheckBoxSelectorInGroupRow.TabIndex = 9
            AddHandler Me.icbShowCheckBoxSelectorInGroupRow.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowCheckBoxSelectorInGroupRow_SelectedIndexChanged)
            ' 
            ' icbShowCheckBoxSelectorInPrintExport
            ' 
            Me.icbShowCheckBoxSelectorInPrintExport.Location = New System.Drawing.Point(12, 174)
            Me.icbShowCheckBoxSelectorInPrintExport.Name = "icbShowCheckBoxSelectorInPrintExport"
            Me.icbShowCheckBoxSelectorInPrintExport.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInPrintExport.Size = New System.Drawing.Size(225, 20)
            Me.icbShowCheckBoxSelectorInPrintExport.StyleController = Me.layoutControl2
            Me.icbShowCheckBoxSelectorInPrintExport.TabIndex = 11
            AddHandler Me.icbShowCheckBoxSelectorInPrintExport.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowCheckBoxSelectorInPrintExport_SelectedIndexChanged)
            ' 
            ' icbShowCheckBoxSelectorInHeader
            ' 
            Me.icbShowCheckBoxSelectorInHeader.Location = New System.Drawing.Point(12, 134)
            Me.icbShowCheckBoxSelectorInHeader.Name = "icbShowCheckBoxSelectorInHeader"
            Me.icbShowCheckBoxSelectorInHeader.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowCheckBoxSelectorInHeader.Size = New System.Drawing.Size(225, 20)
            Me.icbShowCheckBoxSelectorInHeader.StyleController = Me.layoutControl2
            Me.icbShowCheckBoxSelectorInHeader.TabIndex = 10
            AddHandler Me.icbShowCheckBoxSelectorInHeader.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowCheckBoxSelectorInColumnHeader_SelectedIndexChanged)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem4, Me.layoutControlGroup1, Me.layoutControlGroup2, Me.layoutControlItem6})
            Me.layoutControlGroup3.Name = "Root"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(249, 376)
            Me.layoutControlGroup3.TextVisible = False
            ' 
            ' emptySpaceItem4
            ' 
            Me.emptySpaceItem4.Location = New System.Drawing.Point(0, 298)
            Me.emptySpaceItem4.Name = "emptySpaceItem4"
            Me.emptySpaceItem4.Size = New System.Drawing.Size(249, 78)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 44)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(249, 162)
            Me.layoutControlGroup1.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Text = "Show Check Box Selector In"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbShowCheckBoxSelectorInGroupRow
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(229, 40)
            Me.layoutControlItem2.Text = "Group Row:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbShowCheckBoxSelectorInHeader
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(229, 40)
            Me.layoutControlItem3.Text = "Column Header:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbShowCheckBoxSelectorInPrintExport
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 80)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(229, 40)
            Me.layoutControlItem4.Text = "Print && Export:"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 206)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(249, 92)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Printing"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cePrintSelectedRowsOnly
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(229, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.simpleButton1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(229, 26)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceBindSelection
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(249, 44)
            Me.layoutControlItem6.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
            Me.layoutControlItem6.TextVisible = False
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
            Me.navigationPane1.RegularSize = New System.Drawing.Size(249, 409)
            Me.navigationPane1.SelectedPage = Me.navigationPage1
            Me.navigationPane1.Size = New System.Drawing.Size(249, 409)
            Me.navigationPane1.TabIndex = 10
            ' 
            ' navigationPage1
            ' 
            Me.navigationPage1.Caption = "Options"
            Me.navigationPage1.Controls.Add(Me.layoutControl2)
            Me.navigationPage1.Name = "navigationPage1"
            Me.navigationPage1.Size = New System.Drawing.Size(249, 376)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.gridControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(559, 409)
            Me.panelControl1.TabIndex = 11
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.navigationPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(559, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(250, 409)
            Me.sidePanel1.TabIndex = 9
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' WebStyleColumnSelection
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.panelControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "WebStyleColumnSelection"
            Me.Size = New System.Drawing.Size(809, 409)
            CType((Me.repositoryItemTextEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemLookUpEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePrintSelectedRowsOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.ceBindSelection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbShowCheckBoxSelectorInGroupRow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbShowCheckBoxSelectorInPrintExport.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbShowCheckBoxSelectorInHeader.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.navigationPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.navigationPane1.ResumeLayout(False)
            Me.navigationPage1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private repositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colOrder As DevExpress.XtraGrid.Columns.GridColumn

        Private colProduct As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private colTotal As DevExpress.XtraGrid.Columns.GridColumn

        Private icbShowCheckBoxSelectorInPrintExport As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbShowCheckBoxSelectorInHeader As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbShowCheckBoxSelectorInGroupRow As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cePrintSelectedRowsOnly As DevExpress.XtraEditors.CheckEdit

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private navigationPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private navigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private ceBindSelection As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
