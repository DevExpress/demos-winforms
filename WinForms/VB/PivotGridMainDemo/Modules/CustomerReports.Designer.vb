Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class CustomerReports

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
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.fieldOrderYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.rgReport = New DevExpress.XtraEditors.RadioGroup()
            Me.panelControl1layoutControl1ConvertedLayout = New DevExpress.XtraLayout.LayoutControl()
            Me.cbeQuarter = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbeYear = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.rgReportitem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cbeYearItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.cbeQuarteritem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dsReports1 = New DevExpress.XtraPivotGrid.Demos.dsReports()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldCompanyName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductAmount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.mainPanel = New DevExpress.XtraEditors.PanelControl()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.rgReport.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1layoutControl1ConvertedLayout.SuspendLayout()
            CType((Me.cbeQuarter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeYear.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rgReportitem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeYearItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeQuarteritem), System.ComponentModel.ISupportInitialize).BeginInit()
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
            ' fieldOrderYear
            ' 
            Me.fieldOrderYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderYear.AreaIndex = 0
            Me.fieldOrderYear.Caption = "Order Year"
            dataSourceColumnBinding1.ColumnName = "OrderDate"
            dataSourceColumnBinding1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldOrderYear.DataBinding = dataSourceColumnBinding1
            Me.fieldOrderYear.Name = "fieldOrderYear"
            Me.fieldOrderYear.SortOrder = DevExpress.XtraPivotGrid.PivotSortOrder.Descending
            Me.fieldOrderYear.UnboundFieldName = "fieldOrderYear"
            ' 
            ' fieldOrderQuarter
            ' 
            Me.fieldOrderQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderQuarter.AreaIndex = 1
            Me.fieldOrderQuarter.Caption = "Order Quarter"
            dataSourceColumnBinding2.ColumnName = "OrderDate"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldOrderQuarter.DataBinding = dataSourceColumnBinding2
            Me.fieldOrderQuarter.Name = "fieldOrderQuarter"
            Me.fieldOrderQuarter.UnboundFieldName = "fieldOrderQuarter"
            Me.fieldOrderQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldOrderQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
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
            Me.rgReport.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Customers"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Products (filtering)"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Top 2 Products"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Top 10 Customers")})
            Me.rgReport.Size = New System.Drawing.Size(175, 104)
            Me.rgReport.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.rgReport.TabIndex = 0
            AddHandler Me.rgReport.SelectedIndexChanged, New System.EventHandler(AddressOf Me.rgReport_SelectedIndexChanged)
            ' 
            ' panelControl1layoutControl1ConvertedLayout
            ' 
            Me.panelControl1layoutControl1ConvertedLayout.AllowCustomization = False
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.cbeQuarter)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.cbeYear)
            Me.panelControl1layoutControl1ConvertedLayout.Controls.Add(Me.rgReport)
            Me.panelControl1layoutControl1ConvertedLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1layoutControl1ConvertedLayout.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1layoutControl1ConvertedLayout.Name = "panelControl1layoutControl1ConvertedLayout"
            Me.panelControl1layoutControl1ConvertedLayout.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(152, 224, 712, 821)
            Me.panelControl1layoutControl1ConvertedLayout.Root = Me.layoutControlGroup1
            Me.panelControl1layoutControl1ConvertedLayout.Size = New System.Drawing.Size(199, 381)
            Me.panelControl1layoutControl1ConvertedLayout.TabIndex = 3
            ' 
            ' cbeQuarter
            ' 
            Me.cbeQuarter.EditValue = ""
            Me.cbeQuarter.Location = New System.Drawing.Point(59, 126)
            Me.cbeQuarter.Name = "cbeQuarter"
            Me.cbeQuarter.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeQuarter.Properties.Items.AddRange(New Object() {"(All)"})
            Me.cbeQuarter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeQuarter.Size = New System.Drawing.Size(129, 20)
            Me.cbeQuarter.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.cbeQuarter.TabIndex = 3
            AddHandler Me.cbeQuarter.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbeQuarter_SelectedIndexChanged)
            ' 
            ' cbeYear
            ' 
            Me.cbeYear.EditValue = ""
            Me.cbeYear.Location = New System.Drawing.Point(59, 102)
            Me.cbeYear.Name = "cbeYear"
            Me.cbeYear.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeYear.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbeYear.Size = New System.Drawing.Size(129, 20)
            Me.cbeYear.StyleController = Me.panelControl1layoutControl1ConvertedLayout
            Me.cbeYear.TabIndex = 1
            AddHandler Me.cbeYear.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbeYear_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup2})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 381)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 157)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 224)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.rgReportitem, Me.cbeYearItem, Me.cbeQuarteritem})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 157)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Customer Reports"
            ' 
            ' rgReportitem
            ' 
            Me.rgReportitem.Control = Me.rgReport
            Me.rgReportitem.FillControlToClientArea = False
            Me.rgReportitem.Location = New System.Drawing.Point(0, 0)
            Me.rgReportitem.Name = "rgReportitem"
            Me.rgReportitem.Size = New System.Drawing.Size(181, 72)
            Me.rgReportitem.TextLocation = DevExpress.Utils.Locations.Right
            Me.rgReportitem.TextSize = New System.Drawing.Size(0, 0)
            Me.rgReportitem.TextVisible = False
            ' 
            ' cbeYearItem
            ' 
            Me.cbeYearItem.Control = Me.cbeYear
            Me.cbeYearItem.CustomizationFormText = "Year:"
            Me.cbeYearItem.Location = New System.Drawing.Point(0, 72)
            Me.cbeYearItem.Name = "cbeYearItem"
            Me.cbeYearItem.Size = New System.Drawing.Size(181, 24)
            Me.cbeYearItem.Text = "Year:"
            Me.cbeYearItem.TextSize = New System.Drawing.Size(45, 13)
            ' 
            ' cbeQuarteritem
            ' 
            Me.cbeQuarteritem.Control = Me.cbeQuarter
            Me.cbeQuarteritem.Location = New System.Drawing.Point(0, 96)
            Me.cbeQuarteritem.Name = "cbeQuarteritem"
            Me.cbeQuarteritem.Size = New System.Drawing.Size(181, 24)
            Me.cbeQuarteritem.Text = "Quarter: "
            Me.cbeQuarteritem.TextLocation = DevExpress.Utils.Locations.Left
            Me.cbeQuarteritem.TextSize = New System.Drawing.Size(45, 13)
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
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.dsReports1.CustomerReports
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldCompanyName, Me.fieldProductName, Me.fieldProductAmount, Me.fieldOrderYear, Me.fieldOrderQuarter})
            pivotGridGroup1.Fields.Add(Me.fieldOrderYear)
            pivotGridGroup1.Fields.Add(Me.fieldOrderQuarter)
            Me.pivotGridControl1.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.Size = New System.Drawing.Size(502, 408)
            Me.pivotGridControl1.TabIndex = 3
            ' 
            ' fieldCompanyName
            ' 
            Me.fieldCompanyName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCompanyName.AreaIndex = 0
            Me.fieldCompanyName.Caption = "Customer"
            dataSourceColumnBinding3.ColumnName = "CompanyName"
            Me.fieldCompanyName.DataBinding = dataSourceColumnBinding3
            Me.fieldCompanyName.Name = "fieldCompanyName"
            Me.fieldCompanyName.Width = 150
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            dataSourceColumnBinding4.ColumnName = "ProductName"
            Me.fieldProductName.DataBinding = dataSourceColumnBinding4
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 186
            ' 
            ' fieldProductAmount
            ' 
            Me.fieldProductAmount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldProductAmount.AreaIndex = 0
            Me.fieldProductAmount.Caption = "Product Amount"
            Me.fieldProductAmount.CellFormat.FormatString = "c"
            Me.fieldProductAmount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding5.ColumnName = "ProductAmount"
            Me.fieldProductAmount.DataBinding = dataSourceColumnBinding5
            Me.fieldProductAmount.Name = "fieldProductAmount"
            Me.fieldProductAmount.Width = 130
            ' 
            ' mainPanel
            ' 
            Me.mainPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.mainPanel.Controls.Add(Me.pivotGridControl1)
            Me.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.mainPanel.Location = New System.Drawing.Point(0, 0)
            Me.mainPanel.Name = "mainPanel"
            Me.mainPanel.Size = New System.Drawing.Size(502, 408)
            Me.mainPanel.TabIndex = 11
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(502, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 408)
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 408)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 408)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.panelControl1layoutControl1ConvertedLayout)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 381)
            ' 
            ' CustomerReports
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.mainPanel)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CustomerReports"
            Me.Size = New System.Drawing.Size(702, 408)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CustomerReports_Load)
            CType((Me.rgReport.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1layoutControl1ConvertedLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1layoutControl1ConvertedLayout.ResumeLayout(False)
            CType((Me.cbeQuarter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeYear.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rgReportitem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeYearItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeQuarteritem), System.ComponentModel.ISupportInitialize).EndInit()
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

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCompanyName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductAmount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private cbeYear As DevExpress.XtraEditors.ComboBoxEdit

        Private cbeQuarter As DevExpress.XtraEditors.ComboBoxEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private mainPanel As DevExpress.XtraEditors.PanelControl

        Private rgReport As DevExpress.XtraEditors.RadioGroup

        Private panelControl1layoutControl1ConvertedLayout As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private rgReportitem As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private cbeYearItem As DevExpress.XtraLayout.LayoutControlItem

        Private cbeQuarteritem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
