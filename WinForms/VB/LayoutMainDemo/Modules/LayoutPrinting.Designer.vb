Namespace DevExpress.XtraLayout.Demos

    Partial Class LayoutPrinting

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraLayout.Demos.LayoutPrinting))
            Me.dsCategories = New DevExpress.XtraLayout.Demos.dsCategories()
            Me.gridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colDiscount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.colUnitPrice1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemCalcEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit()
            Me.colSubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantityPerUnit = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemSpinEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
            Me.repositoryItemProgressBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemProgressBar()
            Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.pictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.dragDropLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dragDropLayout.SuspendLayout()
            CType((Me.dsCategories), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dragDropLayout
            ' 
            Me.dragDropLayout.Controls.Add(Me.gridControl2)
            Me.dragDropLayout.Controls.Add(Me.gridControl1)
            Me.dragDropLayout.Controls.Add(Me.textEdit1)
            Me.dragDropLayout.Controls.Add(Me.pictureEdit1)
            Me.dragDropLayout.Controls.Add(Me.memoEdit1)
            Me.dragDropLayout.Controls.Add(Me.dataNavigator1)
            Me.dragDropLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(84, 80, 748, 613)
            Me.dragDropLayout.Root = Me.layoutControlGroup1
            Me.dragDropLayout.Size = New System.Drawing.Size(988, 604)
            Me.dragDropLayout.TabIndex = 0
            Me.dragDropLayout.Text = "layoutControl1"
            ' 
            ' dsCategories
            ' 
            Me.dsCategories.DataSetName = "dsCategories"
            Me.dsCategories.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' gridControl2
            ' 
            Me.gridControl2.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl2.DataMember = "Categories.CategoriesProducts.ProductsOrder_x0020_Details"
            Me.gridControl2.DataSource = Me.dsCategories
            Me.gridControl2.Location = New System.Drawing.Point(12, 356)
            Me.gridControl2.MainView = Me.gridView2
            Me.gridControl2.Name = "gridControl2"
            Me.gridControl2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit3, Me.repositoryItemCalcEdit1})
            Me.gridControl2.Size = New System.Drawing.Size(964, 236)
            Me.gridControl2.TabIndex = 9
            Me.gridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView2})
            ' 
            ' gridView2
            ' 
            Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colDiscount, Me.colOrderID, Me.colQuantity, Me.colUnitPrice1, Me.colSubTotal})
            Me.gridView2.GridControl = Me.gridControl2
            Me.gridView2.Name = "gridView2"
            Me.gridView2.OptionsMenu.ShowGroupSummaryEditorItem = True
            Me.gridView2.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView2.OptionsView.ShowFooter = True
            Me.gridView2.OptionsView.ShowGroupPanel = False
            Me.gridView2.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colUnitPrice1, DevExpress.Data.ColumnSortOrder.Ascending)})
            ' 
            ' colDiscount
            ' 
            Me.colDiscount.DisplayFormat.FormatString = "p"
            Me.colDiscount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colDiscount.FieldName = "Discount"
            Me.colDiscount.Name = "colDiscount"
            Me.colDiscount.Visible = True
            Me.colDiscount.VisibleIndex = 3
            Me.colDiscount.Width = 130
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.Caption = "Order ID"
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.OptionsFilter.AllowFilter = False
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            Me.colOrderID.Width = 146
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.Caption = "Quantity"
            Me.colQuantity.ColumnEdit = Me.repositoryItemSpinEdit3
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 2
            Me.colQuantity.Width = 133
            ' 
            ' repositoryItemSpinEdit3
            ' 
            Me.repositoryItemSpinEdit3.AutoHeight = False
            Me.repositoryItemSpinEdit3.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemSpinEdit3.Mask.EditMask = "N00"
            Me.repositoryItemSpinEdit3.Name = "repositoryItemSpinEdit3"
            ' 
            ' colUnitPrice1
            ' 
            Me.colUnitPrice1.Caption = "Unit Price"
            Me.colUnitPrice1.ColumnEdit = Me.repositoryItemCalcEdit1
            Me.colUnitPrice1.DisplayFormat.FormatString = "c"
            Me.colUnitPrice1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colUnitPrice1.FieldName = "UnitPrice"
            Me.colUnitPrice1.Name = "colUnitPrice1"
            Me.colUnitPrice1.Visible = True
            Me.colUnitPrice1.VisibleIndex = 1
            Me.colUnitPrice1.Width = 129
            ' 
            ' repositoryItemCalcEdit1
            ' 
            Me.repositoryItemCalcEdit1.AutoHeight = False
            Me.repositoryItemCalcEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemCalcEdit1.Name = "repositoryItemCalcEdit1"
            ' 
            ' colSubTotal
            ' 
            Me.colSubTotal.DisplayFormat.FormatString = "c"
            Me.colSubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.colSubTotal.FieldName = "SubTotal"
            Me.colSubTotal.Name = "colSubTotal"
            Me.colSubTotal.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "SubTotal", "Total = {0:c}")})
            Me.colSubTotal.Visible = True
            Me.colSubTotal.VisibleIndex = 4
            Me.colSubTotal.Width = 164
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.gridControl1.DataMember = "Categories.CategoriesProducts"
            Me.gridControl1.DataSource = Me.dsCategories
            Me.gridControl1.Location = New System.Drawing.Point(12, 202)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemSpinEdit1, Me.repositoryItemSpinEdit2, Me.repositoryItemProgressBar1})
            Me.gridControl1.Size = New System.Drawing.Size(964, 150)
            Me.gridControl1.TabIndex = 8
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colProductName, Me.colQuantityPerUnit, Me.colUnitPrice})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            Me.gridView1.OptionsDetail.ShowDetailTabs = False
            Me.gridView1.OptionsPrint.PrintSelectedRowsOnly = True
            Me.gridView1.OptionsPrint.SplitCellPreviewAcrossPages = True
            Me.gridView1.OptionsView.AllowHtmlDrawHeaders = True
            Me.gridView1.OptionsView.ShowDetailButtons = False
            Me.gridView1.OptionsView.ShowGroupPanel = False
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
            Me.colUnitPrice.ImageOptions.Image = CType((resources.GetObject("colUnitPrice.ImageOptions.Image")), System.Drawing.Image)
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 2
            Me.colUnitPrice.Width = 108
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
            ' repositoryItemSpinEdit2
            ' 
            Me.repositoryItemSpinEdit2.AutoHeight = False
            Me.repositoryItemSpinEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpinEdit2.Name = "repositoryItemSpinEdit2"
            ' 
            ' repositoryItemProgressBar1
            ' 
            Me.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1"
            Me.repositoryItemProgressBar1.ShowTitle = True
            ' 
            ' textEdit1
            ' 
            Me.textEdit1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.dsCategories, "Categories.CategoryName", True))
            Me.textEdit1.Location = New System.Drawing.Point(124, 45)
            Me.textEdit1.Name = "textEdit1"
            Me.textEdit1.Size = New System.Drawing.Size(652, 20)
            Me.textEdit1.StyleController = Me.dragDropLayout
            Me.textEdit1.TabIndex = 0
            ' 
            ' pictureEdit1
            ' 
            Me.pictureEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories, "Categories.Picture", True))
            Me.pictureEdit1.Location = New System.Drawing.Point(780, 45)
            Me.pictureEdit1.Name = "pictureEdit1"
            Me.pictureEdit1.Properties.[ReadOnly] = True
            Me.pictureEdit1.Size = New System.Drawing.Size(184, 118)
            Me.pictureEdit1.StyleController = Me.dragDropLayout
            Me.pictureEdit1.TabIndex = 6
            ' 
            ' memoEdit1
            ' 
            Me.memoEdit1.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.dsCategories, "Categories.Description", True))
            Me.memoEdit1.Location = New System.Drawing.Point(24, 85)
            Me.memoEdit1.Name = "memoEdit1"
            Me.memoEdit1.Size = New System.Drawing.Size(752, 78)
            Me.memoEdit1.StyleController = Me.dragDropLayout
            Me.memoEdit1.TabIndex = 7
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.Buttons.Append.Visible = False
            Me.dataNavigator1.Buttons.CancelEdit.Visible = False
            Me.dataNavigator1.Buttons.EndEdit.Visible = False
            Me.dataNavigator1.Buttons.NextPage.Visible = False
            Me.dataNavigator1.Buttons.PrevPage.Visible = False
            Me.dataNavigator1.Buttons.Remove.Visible = False
            Me.dataNavigator1.DataMember = "Categories"
            Me.dataNavigator1.DataSource = Me.dsCategories
            Me.dataNavigator1.Location = New System.Drawing.Point(780, 167)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(184, 19)
            Me.dataNavigator1.StyleController = Me.dragDropLayout
            Me.dataNavigator1.TabIndex = 3
            Me.dataNavigator1.Text = "dataNavigator1"
            Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            Me.dataNavigator1.TextStringFormat = "Category {0} of {1}"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3, Me.layoutControlItem4, Me.layoutControlItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(988, 604)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.CaptionImageOptions.ImageIndex = 5
            Me.layoutControlGroup3.CustomizationFormText = "Categories"
            Me.layoutControlGroup3.ExpandButtonVisible = True
            Me.layoutControlGroup3.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem2, Me.emptySpaceItem2})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(968, 190)
            Me.layoutControlGroup3.Text = "Categories"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.textEdit1
            Me.layoutControlItem1.CustomizationFormText = "&Category Name:   "
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(756, 24)
            Me.layoutControlItem1.Text = "&Category Name:   "
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.pictureEdit1
            Me.layoutControlItem7.CustomizationFormText = "Picture"
            Me.layoutControlItem7.Location = New System.Drawing.Point(756, 0)
            Me.layoutControlItem7.MaxSize = New System.Drawing.Size(188, 122)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(188, 122)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(188, 122)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.Text = "Picture"
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.memoEdit1
            Me.layoutControlItem8.CustomizationFormText = "&Description:"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(1, 1)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(756, 98)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.Text = "&Description:"
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(88, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.dataNavigator1
            Me.layoutControlItem2.CustomizationFormText = "DataNavigator"
            Me.layoutControlItem2.Location = New System.Drawing.Point(756, 122)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.OptionsPrint.AllowPrint = False
            Me.layoutControlItem2.Size = New System.Drawing.Size(188, 23)
            Me.layoutControlItem2.Text = "DataNavigator"
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2"
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 122)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(756, 23)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.gridControl2
            Me.layoutControlItem4.CustomizationFormText = "layoutListOrder"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 344)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(968, 240)
            Me.layoutControlItem4.Text = "layoutListOrder"
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.gridControl1
            Me.layoutControlItem3.CustomizationFormText = "layoutListProduct"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 190)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(968, 154)
            Me.layoutControlItem3.Text = "layoutListProduct"
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' LayoutPrinting
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "LayoutPrinting"
            Me.Size = New System.Drawing.Size(988, 604)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.LayoutPrinting_Load)
            CType((Me.dragDropLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dragDropLayout.ResumeLayout(False)
            CType((Me.dsCategories), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemCalcEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemSpinEdit2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemProgressBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.textEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pictureEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.memoEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private dsCategories As DevExpress.XtraLayout.Demos.dsCategories

        Private textEdit1 As DevExpress.XtraEditors.TextEdit

        Private pictureEdit1 As DevExpress.XtraEditors.PictureEdit

        Private memoEdit1 As DevExpress.XtraEditors.MemoEdit

        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private gridControl2 As DevExpress.XtraGrid.GridControl

        Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private colProductName As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantityPerUnit As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private colDiscount As DevExpress.XtraGrid.Columns.GridColumn

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice1 As DevExpress.XtraGrid.Columns.GridColumn

        Private colSubTotal As DevExpress.XtraGrid.Columns.GridColumn

        Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemProgressBar1 As DevExpress.XtraEditors.Repository.RepositoryItemProgressBar

        Private repositoryItemSpinEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemSpinEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit

        Private repositoryItemCalcEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCalcEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
