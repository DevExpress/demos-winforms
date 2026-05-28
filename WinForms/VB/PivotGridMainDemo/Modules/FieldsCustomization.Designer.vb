Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class FieldsCustomization

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
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding8 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding9 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbCustomizationStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.sbCustomizationForm = New DevExpress.XtraEditors.SimpleButton()
            Me.ceSearchBox = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowSort = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowFilter = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciAllowSort = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciAllowFilter = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbCustomizationStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceSearchBox.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowSort.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowFilter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAllowSort), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciAllowFilter), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldCountry.AreaIndex = 0
            dataSourceColumnBinding1.ColumnName = "Country"
            Me.fieldCountry.DataBinding = dataSourceColumnBinding1
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesPerson.AreaIndex = 1
            dataSourceColumnBinding2.ColumnName = "Sales Person"
            Me.fieldSalesPerson.DataBinding = dataSourceColumnBinding2
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            Me.fieldSalesPerson.Width = 130
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Order Year"
            dataSourceColumnBinding3.ColumnName = "OrderDate"
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = dataSourceColumnBinding3
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            Me.fieldYear.Width = 120
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldQuarter.AreaIndex = 0
            Me.fieldQuarter.Caption = "Order Quarter"
            dataSourceColumnBinding4.ColumnName = "OrderDate"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.DataBinding = dataSourceColumnBinding4
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuarter.Width = 140
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Order Amount"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding5.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding5
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            dataSourceColumnBinding6.ColumnName = "Quantity"
            Me.fieldQuantity.DataBinding = dataSourceColumnBinding6
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Visible = False
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Caption = "Product Name"
            dataSourceColumnBinding7.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = dataSourceColumnBinding7
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Visible = False
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 1
            Me.fieldCategoryName.Caption = "Category Name"
            dataSourceColumnBinding8.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = dataSourceColumnBinding8
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 139
            ' 
            ' fieldOrderID
            ' 
            dataSourceColumnBinding9.ColumnName = "OrderID"
            Me.fieldOrderID.DataBinding = dataSourceColumnBinding9
            Me.fieldOrderID.Name = "fieldOrderID"
            Me.fieldOrderID.Visible = False
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCountry, Me.fieldSalesPerson, Me.fieldYear, Me.fieldQuarter, Me.fieldExtendedPrice, Me.fieldQuantity, Me.fieldProductName, Me.fieldCategoryName, Me.fieldOrderID})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsCustomization.CustomizationFormSnapMode = CType(((((DevExpress.Utils.Controls.SnapMode.OwnerControl Or DevExpress.Utils.Controls.SnapMode.OwnerForm) Or DevExpress.Utils.Controls.SnapMode.Screens) Or DevExpress.Utils.Controls.SnapMode.SnapForms)), DevExpress.Utils.Controls.SnapMode)
            Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Size = New System.Drawing.Size(497, 416)
            Me.pivotGridControl1.TabIndex = 12
            AddHandler Me.pivotGridControl1.ShowCustomizationForm, New System.EventHandler(AddressOf Me.pivotGridControl1_ShowCustomizationForm)
            AddHandler Me.pivotGridControl1.HideCustomizationForm, New System.EventHandler(AddressOf Me.pivotGridControl1_HideCustomizationForm)
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(497, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(210, 416)
            Me.sidePanel1.TabIndex = 13
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(209, 416)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(209, 416)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(209, 387)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbCustomizationStyle)
            Me.layoutControl1.Controls.Add(Me.sbCustomizationForm)
            Me.layoutControl1.Controls.Add(Me.ceSearchBox)
            Me.layoutControl1.Controls.Add(Me.ceAllowSort)
            Me.layoutControl1.Controls.Add(Me.ceAllowFilter)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1109, 139, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(209, 387)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbCustomizationStyle
            ' 
            Me.icbCustomizationStyle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.icbCustomizationStyle.EditValue = "imageComboBoxEdit1"
            Me.icbCustomizationStyle.Location = New System.Drawing.Point(12, 74)
            Me.icbCustomizationStyle.Name = "icbCustomizationStyle"
            Me.icbCustomizationStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbCustomizationStyle.Properties.DropDownRows = 10
            Me.icbCustomizationStyle.Size = New System.Drawing.Size(185, 20)
            Me.icbCustomizationStyle.StyleController = Me.layoutControl1
            Me.icbCustomizationStyle.TabIndex = 8
            AddHandler Me.icbCustomizationStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbCustomizationStyle_SelectedIndexChanged)
            ' 
            ' sbCustomizationForm
            ' 
            Me.sbCustomizationForm.Location = New System.Drawing.Point(12, 34)
            Me.sbCustomizationForm.Name = "sbCustomizationForm"
            Me.sbCustomizationForm.Size = New System.Drawing.Size(185, 20)
            Me.sbCustomizationForm.StyleController = Me.layoutControl1
            Me.sbCustomizationForm.TabIndex = 0
            AddHandler Me.sbCustomizationForm.Click, New System.EventHandler(AddressOf Me.sbCustomizationForm_Click)
            ' 
            ' ceSearchBox
            ' 
            Me.ceSearchBox.Location = New System.Drawing.Point(12, 146)
            Me.ceSearchBox.Name = "ceSearchBox"
            Me.ceSearchBox.Properties.Caption = "Show Search Box"
            Me.ceSearchBox.Size = New System.Drawing.Size(185, 20)
            Me.ceSearchBox.StyleController = Me.layoutControl1
            Me.ceSearchBox.TabIndex = 9
            AddHandler Me.ceSearchBox.CheckedChanged, New System.EventHandler(AddressOf Me.OnSearchBoxVisibilityChanged)
            ' 
            ' ceAllowSort
            ' 
            Me.ceAllowSort.Location = New System.Drawing.Point(12, 122)
            Me.ceAllowSort.Name = "ceAllowSort"
            Me.ceAllowSort.Properties.Caption = "Allow Sorting in Field List"
            Me.ceAllowSort.Size = New System.Drawing.Size(185, 20)
            Me.ceAllowSort.StyleController = Me.layoutControl1
            Me.ceAllowSort.TabIndex = 10
            AddHandler Me.ceAllowSort.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowSort_CheckedChanged)
            ' 
            ' ceAllowFilter
            ' 
            Me.ceAllowFilter.Location = New System.Drawing.Point(12, 98)
            Me.ceAllowFilter.Name = "ceAllowFilter"
            Me.ceAllowFilter.Properties.Caption = "Allow Filtering in Field List"
            Me.ceAllowFilter.Size = New System.Drawing.Size(185, 20)
            Me.ceAllowFilter.StyleController = Me.layoutControl1
            Me.ceAllowFilter.TabIndex = 11
            AddHandler Me.ceAllowFilter.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowFilter_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(209, 387)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 178)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(209, 209)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.lciAllowSort, Me.lciAllowFilter})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(209, 178)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Customization Form"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbCustomizationStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(189, 40)
            Me.layoutControlItem2.Text = "Customization Style:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(98, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.sbCustomizationForm
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(189, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceSearchBox
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 112)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(189, 24)
            Me.layoutControlItem4.Text = "Show Search Box:"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' lciAllowSort
            ' 
            Me.lciAllowSort.Control = Me.ceAllowSort
            Me.lciAllowSort.Location = New System.Drawing.Point(0, 88)
            Me.lciAllowSort.Name = "lciAllowSort"
            Me.lciAllowSort.Size = New System.Drawing.Size(189, 24)
            Me.lciAllowSort.TextSize = New System.Drawing.Size(0, 0)
            Me.lciAllowSort.TextVisible = False
            ' 
            ' lciAllowFilter
            ' 
            Me.lciAllowFilter.Control = Me.ceAllowFilter
            Me.lciAllowFilter.Location = New System.Drawing.Point(0, 64)
            Me.lciAllowFilter.Name = "lciAllowFilter"
            Me.lciAllowFilter.Size = New System.Drawing.Size(189, 24)
            Me.lciAllowFilter.TextSize = New System.Drawing.Size(0, 0)
            Me.lciAllowFilter.TextVisible = False
            ' 
            ' FieldsCustomization
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "FieldsCustomization"
            Me.Size = New System.Drawing.Size(707, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FieldsCustomization_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbCustomizationStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceSearchBox.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowSort.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowFilter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAllowSort), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciAllowFilter), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private sbCustomizationForm As DevExpress.XtraEditors.SimpleButton

        Private components As System.ComponentModel.IContainer = Nothing

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderID As DevExpress.XtraPivotGrid.PivotGridField

        Private icbCustomizationStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private ceSearchBox As DevExpress.XtraEditors.CheckEdit

        Private ceAllowFilter As DevExpress.XtraEditors.CheckEdit

        Private lciAllowFilter As DevExpress.XtraLayout.LayoutControlItem

        Private ceAllowSort As DevExpress.XtraEditors.CheckEdit

        Private lciAllowSort As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
