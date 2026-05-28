Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class CompactLayout

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
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding8 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding9 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.salesPersonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.field = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.field1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField1 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridField3 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.groupLayout = New DevExpress.XtraEditors.RadioGroup()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.mainPanel.SuspendLayout()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.salesPersonBindingSource), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.groupLayout.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl1)
            Me.mainPanel.Controls.Add(Me.sidePanel1)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(702, 408)
            Me.mainPanel.TabIndex = 11
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.salesPersonBindingSource
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldOrderYear, Me.fieldCategoryName, Me.fieldQuantity, Me.fieldOrderQuarter, Me.fieldOrderMonth, Me.field, Me.field1, Me.pivotGridField1, Me.pivotGridField3})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsCustomization.CustomizationFormLayout = DevExpress.XtraPivotGrid.Customization.CustomizationFormLayout.BottomPanelOnly2by2
            Me.pivotGridControl1.OptionsCustomization.CustomizationFormStyle = DevExpress.XtraPivotGrid.Customization.CustomizationFormStyle.Excel2007
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsDataField.RowHeaderWidth = 90
            Me.pivotGridControl1.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.OptionsView.RowTotalsLocation = DevExpress.XtraPivotGrid.PivotRowTotalsLocation.Tree
            Me.pivotGridControl1.OptionsView.RowTreeOffset = 18
            Me.pivotGridControl1.OptionsView.RowTreeWidth = 50
            Me.pivotGridControl1.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl1.OptionsView.ShowDataHeaders = False
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.OptionsView.ShowRowHeaders = False
            Me.pivotGridControl1.OptionsView.ShowTotalsForSingleValues = True
            Me.pivotGridControl1.Size = New System.Drawing.Size(502, 408)
            Me.pivotGridControl1.TabIndex = 5
            AddHandler Me.pivotGridControl1.ShowCustomizationForm, New System.EventHandler(AddressOf Me.pivotGridControl1_ShowCustomizationForm)
            AddHandler Me.pivotGridControl1.HideCustomizationForm, New System.EventHandler(AddressOf Me.pivotGridControl1_HideCustomizationForm)
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            ' 
            ' salesPersonBindingSource
            ' 
            Me.salesPersonBindingSource.DataMember = "SalesPerson"
            Me.salesPersonBindingSource.DataSource = Me.dsSalesPerson1
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' fieldOrderYear
            ' 
            Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Order Year"
            dataSourceColumnBinding1.ColumnName = "OrderDate"
            dataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.DataBinding = dataSourceColumnBinding1
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldOrderYear.Width = 90
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 3
            Me.fieldCategoryName.Caption = "Category Name"
            dataSourceColumnBinding2.ColumnName = "CategoryName"
            Me.fieldCategoryName.DataBinding = dataSourceColumnBinding2
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 150
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 0
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding3.ColumnName = "Quantity"
            Me.fieldQuantity.DataBinding = dataSourceColumnBinding3
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Width = 130
            ' 
            ' fieldOrderQuarter
            ' 
            Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderQuarter.AreaIndex = 1
            Me.fieldOrderQuarter.Caption = "Order Quarter"
            dataSourceColumnBinding4.ColumnName = "OrderDate"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldOrderQuarter.DataBinding = dataSourceColumnBinding4
            Me.fieldOrderQuarter.Name = "fieldOrderQuarter"
            Me.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldOrderMonth
            ' 
            Me.fieldOrderMonth.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldOrderMonth.AreaIndex = 2
            Me.fieldOrderMonth.Caption = "Order Month"
            dataSourceColumnBinding5.ColumnName = "OrderDate"
            dataSourceColumnBinding5.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldOrderMonth.DataBinding = dataSourceColumnBinding5
            Me.fieldOrderMonth.Name = "fieldOrderMonth"
            ' 
            ' field
            ' 
            Me.field.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.field.AreaIndex = 4
            Me.field.Caption = "Product Name"
            dataSourceColumnBinding6.ColumnName = "ProductName"
            Me.field.DataBinding = dataSourceColumnBinding6
            Me.field.Name = "field"
            ' 
            ' field1
            ' 
            Me.field1.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.field1.AreaIndex = 1
            Me.field1.Caption = "Sales Person"
            dataSourceColumnBinding7.ColumnName = "Sales Person"
            Me.field1.DataBinding = dataSourceColumnBinding7
            Me.field1.Name = "field1"
            ' 
            ' pivotGridField1
            ' 
            Me.pivotGridField1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.pivotGridField1.AreaIndex = 1
            dataSourceColumnBinding8.ColumnName = "Extended Price"
            Me.pivotGridField1.DataBinding = dataSourceColumnBinding8
            Me.pivotGridField1.Name = "pivotGridField1"
            ' 
            ' pivotGridField3
            ' 
            Me.pivotGridField3.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.pivotGridField3.AreaIndex = 0
            dataSourceColumnBinding9.ColumnName = "Country"
            Me.pivotGridField3.DataBinding = dataSourceColumnBinding9
            Me.pivotGridField3.Name = "pivotGridField3"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(502, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 408)
            Me.sidePanel1.TabIndex = 6
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 408)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 408)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 379)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.groupLayout)
            Me.layoutControl1.Controls.Add(Me.simpleButton1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1108, 131, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 379)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' groupLayout
            ' 
            Me.groupLayout.AutoSizeInLayoutControl = True
            Me.groupLayout.Location = New System.Drawing.Point(12, 34)
            Me.groupLayout.Name = "groupLayout"
            Me.groupLayout.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.groupLayout.Properties.Appearance.Options.UseBackColor = True
            Me.groupLayout.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.groupLayout.Properties.Columns = 1
            Me.groupLayout.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(True, "Compact"), New DevExpress.XtraEditors.Controls.RadioGroupItem(False, "Full")})
            Me.groupLayout.Size = New System.Drawing.Size(175, 56)
            Me.groupLayout.StyleController = Me.layoutControl1
            Me.groupLayout.TabIndex = 1
            AddHandler Me.groupLayout.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroup1_SelectedIndexChanged)
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(12, 94)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(175, 22)
            Me.simpleButton1.StyleController = Me.layoutControl1
            Me.simpleButton1.TabIndex = 4
            Me.simpleButton1.Text = "Show Customization Form"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 379)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 128)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 251)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 128)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Pivot Layout"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.groupLayout
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 60)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.simpleButton1
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 60)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 26)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' CompactLayout
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Name = "CompactLayout"
            Me.Size = New System.Drawing.Size(702, 408)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CompactLayout_Load)
            CType((Me.mainPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.mainPanel.ResumeLayout(False)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.salesPersonBindingSource), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.groupLayout.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private salesPersonBindingSource As System.Windows.Forms.BindingSource

        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private groupLayout As DevExpress.XtraEditors.RadioGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private fieldOrderMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private field As DevExpress.XtraPivotGrid.PivotGridField

        Private field1 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField1 As DevExpress.XtraPivotGrid.PivotGridField

        Private pivotGridField3 As DevExpress.XtraPivotGrid.PivotGridField

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
