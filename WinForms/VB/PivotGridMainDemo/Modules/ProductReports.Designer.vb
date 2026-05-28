Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class ProductReports

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
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.rgReport = New DevExpress.XtraEditors.RadioGroup()
            Me.controlPanellayoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.cbeDate = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.ceDrillDown = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCategories = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dsReports1 = New DevExpress.XtraPivotGrid.Demos.dsReports()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShippedYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductSales = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShippedQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldShippedMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldAverageSale = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMinimumSale = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.rgReport.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.controlPanellayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.controlPanellayoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.cbeDate.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceDrillDown.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCategories.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsReports1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' rgReport
            ' 
            Me.rgReport.AutoSizeInLayoutControl = True
            Me.rgReport.Location = New System.Drawing.Point(11, 30)
            Me.rgReport.Name = "rgReport"
            Me.rgReport.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgReport.Properties.Appearance.Options.UseBackColor = True
            Me.rgReport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgReport.Properties.Columns = 1
            Me.rgReport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Category Sales"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Product Sales"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Interval Grouping"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Multiple Subtotals"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "Average Sales"), New DevExpress.XtraEditors.Controls.RadioGroupItem(5, "Top 3 Products")})
            Me.rgReport.Size = New System.Drawing.Size(177, 98)
            Me.rgReport.StyleController = Me.controlPanellayoutControl1ConvertedLayout
            Me.rgReport.TabIndex = 0
            AddHandler Me.rgReport.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgReport_SelectedIndexChanged)
            ' 
            ' controlPanellayoutControl1ConvertedLayout
            ' 
            Me.controlPanellayoutControl1ConvertedLayout.AllowCustomization = False
            Me.controlPanellayoutControl1ConvertedLayout.Controls.Add(Me.rgReport)
            Me.controlPanellayoutControl1ConvertedLayout.Controls.Add(Me.cbeDate)
            Me.controlPanellayoutControl1ConvertedLayout.Controls.Add(Me.ceDrillDown)
            Me.controlPanellayoutControl1ConvertedLayout.Controls.Add(Me.ceCategories)
            Me.controlPanellayoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.controlPanellayoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.controlPanellayoutControl1ConvertedLayout.Name = "controlPanellayoutControl1ConvertedLayout"
            Me.controlPanellayoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(217, 286, 781, 674)
            Me.controlPanellayoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.controlPanellayoutControl1ConvertedLayout.Size = New System.Drawing.Size(199, 398)
            Me.controlPanellayoutControl1ConvertedLayout.TabIndex = 15
            ' 
            ' cbeDate
            ' 
            Me.cbeDate.EditValue = ""
            Me.cbeDate.Location = New System.Drawing.Point(11, 171)
            Me.cbeDate.Name = "cbeDate"
            Me.cbeDate.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeDate.Properties.Items.AddRange(New Object() {"by Years", "by Quarters", "by Months", "by Years, Quarters, Months"})
            Me.cbeDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeDate.Size = New System.Drawing.Size(177, 20)
            Me.cbeDate.StyleController = Me.controlPanellayoutControl1ConvertedLayout
            Me.cbeDate.TabIndex = 3
            AddHandler Me.cbeDate.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbeDate_SelectedIndexChanged)
            ' 
            ' ceDrillDown
            ' 
            Me.ceDrillDown.AutoSizeInLayoutControl = True
            Me.ceDrillDown.EditValue = True
            Me.ceDrillDown.Location = New System.Drawing.Point(11, 232)
            Me.ceDrillDown.MinimumSize = New System.Drawing.Size(0, 26)
            Me.ceDrillDown.Name = "ceDrillDown"
            Me.ceDrillDown.Properties.Appearance.Options.UseTextOptions = True
            Me.ceDrillDown.Properties.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.ceDrillDown.Properties.Caption = "Show on Cell Double Click"
            Me.ceDrillDown.Size = New System.Drawing.Size(143, 26)
            Me.ceDrillDown.StyleController = Me.controlPanellayoutControl1ConvertedLayout
            Me.ceDrillDown.TabIndex = 0
            ' 
            ' ceCategories
            ' 
            Me.ceCategories.Location = New System.Drawing.Point(11, 132)
            Me.ceCategories.Name = "ceCategories"
            Me.ceCategories.Properties.Caption = "Show Categories"
            Me.ceCategories.Size = New System.Drawing.Size(177, 19)
            Me.ceCategories.StyleController = Me.controlPanellayoutControl1ConvertedLayout
            Me.ceCategories.TabIndex = 0
            AddHandler Me.ceCategories.CheckedChanged, New System.EventHandler(AddressOf Me.ceCategories_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup3, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 398)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 269)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 129)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 202)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Product Reports"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.rgReport
            Me.layoutControlItem1.CustomizationFormText = "RadioGroupItem"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(181, 102)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceCategories
            Me.layoutControlItem3.CustomizationFormText = "ShowCategories"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(181, 23)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.cbeDate
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 125)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(181, 40)
            Me.layoutControlItem4.Text = "Grouping Layout:"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.CustomizationFormText = "Drill Down Form"
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 202)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 67)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Drill Down Form"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceDrillDown
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(181, 30)
            Me.layoutControlItem2.Text = "Drill Down Form"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' dsReports1
            ' 
            Me.dsReports1.DataSetName = "dsReports"
            Me.dsReports1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsReports1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.ActiveFilterString = ""
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.pivotGridControl1.DataSource = Me.dsReports1.ProductReports
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCategoryName, Me.fieldProductName, Me.fieldShippedYear, Me.fieldProductSales, Me.fieldShippedQuarter, Me.fieldShippedMonth, Me.fieldAverageSale, Me.fieldMinimumSale})
            pivotGridGroup1.Hierarchy = Nothing
            pivotGridGroup1.ShowNewValues = True
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.Size = New System.Drawing.Size(566, 425)
            Me.pivotGridControl1.TabIndex = 3
            AddHandler Me.pivotGridControl1.FieldValueDisplayText, New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(AddressOf Me.pivotGridControl1_FieldValueDisplayText)
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            AddHandler Me.pivotGridControl1.CellDoubleClick, New DevExpress.XtraPivotGrid.PivotCellEventHandler(AddressOf Me.pivotGridControl1_CellDoubleClick)
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("CategoryName")
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 125
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 171
            ' 
            ' fieldShippedYear
            ' 
            Me.fieldShippedYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldShippedYear.AreaIndex = 0
            Me.fieldShippedYear.Caption = "Shipped Year"
            Me.fieldShippedYear.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            Me.fieldShippedYear.Name = "fieldShippedYear"
            ' 
            ' fieldProductSales
            ' 
            Me.fieldProductSales.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductSales.AreaIndex = 0
            Me.fieldProductSales.Caption = "Product Sales"
            Me.fieldProductSales.CellFormat.FormatString = "c"
            Me.fieldProductSales.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldProductSales.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductSales")
            Me.fieldProductSales.Name = "fieldProductSales"
            Me.fieldProductSales.Width = 130
            ' 
            ' fieldShippedQuarter
            ' 
            Me.fieldShippedQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldShippedQuarter.AreaIndex = 1
            Me.fieldShippedQuarter.Caption = "Shipped Quarter"
            Me.fieldShippedQuarter.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter)
            Me.fieldShippedQuarter.Name = "fieldShippedQuarter"
            Me.fieldShippedQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldShippedQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldShippedQuarter.Width = 130
            ' 
            ' fieldShippedMonth
            ' 
            Me.fieldShippedMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldShippedMonth.Caption = "Shipped Month"
            Me.fieldShippedMonth.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ShippedDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth)
            Me.fieldShippedMonth.Name = "fieldShippedMonth"
            Me.fieldShippedMonth.Visible = False
            Me.fieldShippedMonth.Width = 120
            ' 
            ' fieldAverageSale
            ' 
            Me.fieldAverageSale.Caption = "Average Sale"
            Me.fieldAverageSale.CellFormat.FormatString = "c"
            Me.fieldAverageSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldAverageSale.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductSales")
            Me.fieldAverageSale.Name = "fieldAverageSale"
            Me.fieldAverageSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldAverageSale.Visible = False
            ' 
            ' fieldMinimumSale
            ' 
            Me.fieldMinimumSale.Caption = "Minimum Sale"
            Me.fieldMinimumSale.CellFormat.FormatString = "c"
            Me.fieldMinimumSale.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldMinimumSale.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductSales")
            Me.fieldMinimumSale.Name = "fieldMinimumSale"
            Me.fieldMinimumSale.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Min
            Me.fieldMinimumSale.Visible = False
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl1)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(566, 425)
            Me.mainPanel.TabIndex = 13
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(566, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 425)
            Me.sidePanel1.TabIndex = 4
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 425)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 425)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.controlPanellayoutControl1ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 398)
            ' 
            ' ProductReports
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ProductReports"
            Me.Size = New System.Drawing.Size(766, 425)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ProductReports_Load)
            CType((Me.rgReport.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.controlPanellayoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.controlPanellayoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.cbeDate.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceDrillDown.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCategories.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsReports1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsReports1 As DevExpress.XtraPivotGrid.Demos.dsReports

        Private rgReport As DevExpress.XtraEditors.RadioGroup

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldShippedQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldShippedYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductSales As DevExpress.XtraPivotGrid.PivotGridField

        Private ceCategories As DevExpress.XtraEditors.CheckEdit

        Private fieldShippedMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldAverageSale As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMinimumSale As DevExpress.XtraPivotGrid.PivotGridField

        Private ceDrillDown As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private controlPanellayoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private cbeDate As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
