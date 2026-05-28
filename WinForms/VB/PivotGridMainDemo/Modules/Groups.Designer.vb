Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class Groups

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
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim pivotGridGroup2 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim pivotGridGroup3 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceColumns = New DevExpress.XtraEditors.CheckEdit()
            Me.ceRows = New DevExpress.XtraEditors.CheckEdit()
            Me.ceData = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceColumns.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceRows.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceData.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            dataSourceColumnBinding1.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = dataSourceColumnBinding1
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 150
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            dataSourceColumnBinding2.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = dataSourceColumnBinding2
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 170
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Year"
            dataSourceColumnBinding3.ColumnName = "OrderDate"
            dataSourceColumnBinding3.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderDate.DataBinding = dataSourceColumnBinding3
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.UnboundFieldName = "fieldOrderDate"
            ' 
            ' fieldOrderDate1
            ' 
            Me.fieldOrderDate1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate1.AreaIndex = 1
            Me.fieldOrderDate1.Caption = "Quarter"
            dataSourceColumnBinding4.ColumnName = "OrderDate"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldOrderDate1.DataBinding = dataSourceColumnBinding4
            Me.fieldOrderDate1.Name = "fieldOrderDate1"
            Me.fieldOrderDate1.UnboundFieldName = "fieldOrderDate1"
            Me.fieldOrderDate1.ValueFormat.FormatString = "Quarter {0}"
            Me.fieldOrderDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldOrderDate2
            ' 
            Me.fieldOrderDate2.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate2.AreaIndex = 2
            Me.fieldOrderDate2.Caption = "Month"
            dataSourceColumnBinding5.ColumnName = "OrderDate"
            dataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderDate2.DataBinding = dataSourceColumnBinding5
            Me.fieldOrderDate2.Name = "fieldOrderDate2"
            Me.fieldOrderDate2.UnboundFieldName = "fieldOrderDate2"
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Order Amount"
            dataSourceColumnBinding6.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding6
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            dataSourceColumnBinding7.ColumnName = "Quantity"
            Me.fieldQuantity.DataBinding = dataSourceColumnBinding7
            Me.fieldQuantity.Name = "fieldQuantity"
            ' 
            ' fieldDiscount
            ' 
            Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldDiscount.AreaIndex = 2
            Me.fieldDiscount.Caption = "Discount (Avg)"
            Me.fieldDiscount.CellFormat.FormatString = "p"
            Me.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding8.ColumnName = "Discount"
            Me.fieldDiscount.DataBinding = dataSourceColumnBinding8
            Me.fieldDiscount.Name = "fieldDiscount"
            Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceColumns)
            Me.layoutControl1.Controls.Add(Me.ceRows)
            Me.layoutControl1.Controls.Add(Me.ceData)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(838, 330, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 387)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceColumns
            ' 
            Me.ceColumns.Location = New System.Drawing.Point(12, 34)
            Me.ceColumns.Name = "ceColumns"
            Me.ceColumns.Properties.AllowGrayed = True
            Me.ceColumns.Properties.Caption = "Collapse Column Groups"
            Me.ceColumns.Size = New System.Drawing.Size(175, 20)
            Me.ceColumns.StyleController = Me.layoutControl1
            Me.ceColumns.TabIndex = 6
            AddHandler Me.ceColumns.CheckedChanged, New System.EventHandler(AddressOf Me.ceColumns_CheckedChanged)
            AddHandler Me.ceColumns.CheckStateChanged, New System.EventHandler(AddressOf Me.CheckStateChanged)
            ' 
            ' ceRows
            ' 
            Me.ceRows.Location = New System.Drawing.Point(12, 58)
            Me.ceRows.Name = "ceRows"
            Me.ceRows.Properties.AllowGrayed = True
            Me.ceRows.Properties.Caption = "Collapse Row Groups"
            Me.ceRows.Size = New System.Drawing.Size(175, 20)
            Me.ceRows.StyleController = Me.layoutControl1
            Me.ceRows.TabIndex = 7
            AddHandler Me.ceRows.CheckedChanged, New System.EventHandler(AddressOf Me.ceRows_CheckedChanged)
            AddHandler Me.ceRows.CheckStateChanged, New System.EventHandler(AddressOf Me.CheckStateChanged)
            ' 
            ' ceData
            ' 
            Me.ceData.Location = New System.Drawing.Point(12, 82)
            Me.ceData.Name = "ceData"
            Me.ceData.Properties.AllowGrayed = True
            Me.ceData.Properties.Caption = "Collapse Data Groups"
            Me.ceData.Size = New System.Drawing.Size(175, 20)
            Me.ceData.StyleController = Me.layoutControl1
            Me.ceData.TabIndex = 8
            AddHandler Me.ceData.CheckedChanged, New System.EventHandler(AddressOf Me.ceData_CheckedChanged)
            AddHandler Me.ceData.CheckStateChanged, New System.EventHandler(AddressOf Me.CheckStateChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 387)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 114)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 273)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem1, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 114)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Collapsed State"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceColumns
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.ceRows
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceData
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldProductName, Me.fieldQuantity, Me.fieldExtendedPrice, Me.fieldDiscount, Me.fieldOrderDate, Me.fieldOrderDate1, Me.fieldOrderDate2})
            pivotGridGroup1.Fields.Add(Me.fieldCategoryName)
            pivotGridGroup1.Fields.Add(Me.fieldProductName)
            pivotGridGroup2.Fields.Add(Me.fieldOrderDate)
            pivotGridGroup2.Fields.Add(Me.fieldOrderDate1)
            pivotGridGroup2.Fields.Add(Me.fieldOrderDate2)
            pivotGridGroup3.Fields.Add(Me.fieldExtendedPrice)
            pivotGridGroup3.Fields.Add(Me.fieldQuantity)
            pivotGridGroup3.Fields.Add(Me.fieldDiscount)
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1, pivotGridGroup2, pivotGridGroup3})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(504, 416)
            Me.pivotGridControl1.TabIndex = 12
            AddHandler Me.pivotGridControl1.FieldAreaChanged, New DevExpress.XtraPivotGrid.PivotFieldEventHandler(AddressOf Me.pivotGridControl1_FieldAreaChanged)
            AddHandler Me.pivotGridControl1.FieldExpandedInFieldGroupChanged, New DevExpress.XtraPivotGrid.PivotFieldEventHandler(AddressOf Me.pivotGridControl1_FieldExpandedInFieldGroupChanged)
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            AddHandler Me.pivotGridControl1.CustomDrawFieldHeader, New DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(AddressOf Me.pivotGridControl1_CustomDrawFieldHeader)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(504, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 416)
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 416)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 416)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 387)
            ' 
            ' Groups
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "Groups"
            Me.Size = New System.Drawing.Size(704, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.Groups_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceColumns.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceRows.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceData.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private components As System.ComponentModel.IContainer = Nothing

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderDate1 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderDate2 As DevExpress.XtraPivotGrid.PivotGridField

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private ceColumns As DevExpress.XtraEditors.CheckEdit

        Private ceRows As DevExpress.XtraEditors.CheckEdit

        Private ceData As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
