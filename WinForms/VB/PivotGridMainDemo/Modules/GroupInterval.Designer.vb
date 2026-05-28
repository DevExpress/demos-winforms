Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class GroupInterval

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
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.ceProductInterval = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbGroupInterval = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldProductAlphabetical = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutConverter1 = New DevExpress.XtraLayout.Converter.LayoutConverter(Me.components)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceProductInterval.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbGroupInterval.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' ceProductInterval
            ' 
            Me.ceProductInterval.Location = New System.Drawing.Point(12, 96)
            Me.ceProductInterval.Name = "ceProductInterval"
            Me.ceProductInterval.Properties.Caption = "Show Product Alphabetically"
            Me.ceProductInterval.Size = New System.Drawing.Size(175, 19)
            Me.ceProductInterval.StyleController = Me.layoutControl1
            Me.ceProductInterval.TabIndex = 3
            AddHandler Me.ceProductInterval.CheckedChanged, New System.EventHandler(AddressOf Me.ceProductInterval_CheckedChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceProductInterval)
            Me.layoutControl1.Controls.Add(Me.icbGroupInterval)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1097, 127, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 389)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbGroupInterval
            ' 
            Me.icbGroupInterval.EditValue = "imageComboBoxEdit1"
            Me.icbGroupInterval.Location = New System.Drawing.Point(12, 32)
            Me.icbGroupInterval.Name = "icbGroupInterval"
            Me.icbGroupInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbGroupInterval.Size = New System.Drawing.Size(175, 20)
            Me.icbGroupInterval.StyleController = Me.layoutControl1
            toolTipItem1.Text = "You can also select the group interval from the field header's context menu"
            superToolTip1.Items.Add(toolTipItem1)
            Me.icbGroupInterval.SuperTip = superToolTip1
            Me.icbGroupInterval.TabIndex = 2
            AddHandler Me.icbGroupInterval.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbGroupInterval_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 389)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 127)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 262)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 64)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "OrderDate Group Interval"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbGroupInterval
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 64)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(199, 63)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup4.Text = "ProductName Group Interval"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceProductInterval
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(179, 23)
            Me.layoutControlItem3.Text = "Alphabetical Group Interval"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldProductAlphabetical, Me.fieldProductName, Me.fieldExtendedPrice, Me.fieldOrderDate})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsMenu.ShowDateTimeGroupIntervalItems = DevExpress.XtraPivotGrid.DateTimeGroupIntervals.ExtendedIntervals
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(503, 416)
            Me.pivotGridControl1.TabIndex = 15
            AddHandler Me.pivotGridControl1.FieldValueDisplayText, New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(AddressOf Me.pivotGridControl1_FieldValueDisplayText)
            AddHandler Me.pivotGridControl1.MenuItemClick, New DevExpress.XtraPivotGrid.PivotGridMenuItemClickEventHandler(AddressOf Me.pivotGridControl1_MenuItemClick)
            ' 
            ' fieldProductAlphabetical
            ' 
            Me.fieldProductAlphabetical.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.fieldProductAlphabetical.Appearance.Header.Options.UseFont = True
            Me.fieldProductAlphabetical.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductAlphabetical.AreaIndex = 0
            Me.fieldProductAlphabetical.Caption = "Product Alphabetical"
            Me.fieldProductAlphabetical.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName", DevExpress.XtraPivotGrid.PivotGroupInterval.Alphabetical)
            Me.fieldProductAlphabetical.Name = "fieldProductAlphabetical"
            Me.fieldProductAlphabetical.Width = 170
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 155
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Extended Price")
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.Appearance.Header.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.fieldOrderDate.Appearance.Header.Options.UseFont = True
            Me.fieldOrderDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldOrderDate.AreaIndex = 0
            Me.fieldOrderDate.Caption = "Order Date"
            Me.fieldOrderDate.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateWeekYear)
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.Options.ShowGroupIntervalName = True
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(503, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 416)
            Me.sidePanel1.TabIndex = 16
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
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 389)
            ' 
            ' GroupInterval
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "GroupInterval"
            Me.Size = New System.Drawing.Size(703, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.GroupInterval_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceProductInterval.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbGroupInterval.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private icbGroupInterval As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceProductInterval As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldProductAlphabetical As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutConverter1 As DevExpress.XtraLayout.Converter.LayoutConverter

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
