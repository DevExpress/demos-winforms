Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class AutomaticTotals

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
            Dim pivotGridCustomTotal1 As DevExpress.XtraPivotGrid.PivotGridCustomTotal = New DevExpress.XtraPivotGrid.PivotGridCustomTotal()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.clbOptions = New DevExpress.XtraEditors.CheckedListBoxControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbField = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbSummaryType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.clbOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbField.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbSummaryType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
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
            ' clbOptions
            ' 
            Me.clbOptions.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.clbOptions.CheckOnClick = True
            Me.clbOptions.ItemHeight = 17
            Me.clbOptions.Location = New System.Drawing.Point(12, 150)
            Me.clbOptions.Name = "clbOptions"
            Me.clbOptions.Size = New System.Drawing.Size(175, 371)
            Me.clbOptions.StyleController = Nothing
            Me.clbOptions.TabIndex = 0
            AddHandler Me.clbOptions.ItemCheck, New DevExpress.XtraEditors.Controls.ItemCheckEventHandler(AddressOf Me.clbOptions_ItemCheck)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.clbOptions)
            Me.layoutControl1.Controls.Add(Me.icbField)
            Me.layoutControl1.Controls.Add(Me.icbSummaryType)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(96, 187, 957, 951)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 533)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbField
            ' 
            Me.icbField.EditValue = "imageComboBoxEdit1"
            Me.icbField.Location = New System.Drawing.Point(12, 47)
            Me.icbField.Name = "icbField"
            Me.icbField.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbField.Size = New System.Drawing.Size(175, 20)
            Me.icbField.StyleController = Me.layoutControl1
            Me.icbField.TabIndex = 0
            AddHandler Me.icbField.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbField_SelectedIndexChanged)
            ' 
            ' icbSummaryType
            ' 
            Me.icbSummaryType.EditValue = "imageComboBoxEdit1"
            Me.icbSummaryType.Location = New System.Drawing.Point(12, 87)
            Me.icbSummaryType.Name = "icbSummaryType"
            Me.icbSummaryType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbSummaryType.Properties.DropDownRows = 10
            Me.icbSummaryType.Size = New System.Drawing.Size(175, 20)
            Me.icbSummaryType.StyleController = Me.layoutControl1
            Me.icbSummaryType.TabIndex = 6
            AddHandler Me.icbSummaryType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbSummaryType_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 533)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 119)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 414)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Totals Visibility"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.clbOptions
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 375)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 119)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Summary Settings"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbField
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(179, 40)
            Me.layoutControlItem2.Text = "Field"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(68, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbSummaryType
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 40)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(179, 40)
            Me.layoutControlItem3.Text = "SummaryType"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(68, 13)
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear, Me.fieldCategoryName, Me.fieldProductName, Me.fieldQuarter, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldExtendedPrice})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsDataField.Area = DevExpress.XtraPivotGrid.PivotDataArea.ColumnArea
            Me.pivotGridControl1.OptionsDataField.AreaIndex = 2
            Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGridControl1.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(726, 560)
            Me.pivotGridControl1.TabIndex = 14
            AddHandler Me.pivotGridControl1.CustomSummary, New DevExpress.XtraPivotGrid.PivotGridCustomSummaryEventHandler(AddressOf Me.pivotGridControl1_CustomSummary)
            AddHandler Me.pivotGridControl1.FieldValueImageIndex, New DevExpress.XtraPivotGrid.PivotFieldImageIndexEventHandler(AddressOf Me.pivotGridControl1_FieldValueImageIndex)
            AddHandler Me.pivotGridControl1.CustomDrawFieldHeader, New DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(AddressOf Me.pivotGridControl1_CustomDrawFieldHeader)
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            Me.fieldYear.FieldName = "OrderDate"
            Me.fieldYear.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.Caption = "Category Name"
            Me.fieldCategoryName.FieldName = "CategoryName"
            Me.fieldCategoryName.Name = "fieldCategoryName"
            Me.fieldCategoryName.Width = 135
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProductName.AreaIndex = 1
            Me.fieldProductName.Caption = "Product Name"
            Me.fieldProductName.FieldName = "ProductName"
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Width = 170
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            Me.fieldQuarter.FieldName = "OrderDate"
            Me.fieldQuarter.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.TotalValueFormat.FormatString = "Quarter {0} Total"
            Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuarter.UnboundFieldName = "fieldQuarter"
            Me.fieldQuarter.ValueFormat.FormatString = "Quarter {0}"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldUnitPrice
            ' 
            Me.fieldUnitPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldUnitPrice.AreaIndex = 0
            Me.fieldUnitPrice.Caption = "Unit Price"
            Me.fieldUnitPrice.CellFormat.FormatString = "c"
            Me.fieldUnitPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            pivotGridCustomTotal1.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            pivotGridCustomTotal1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.StdDev
            Me.fieldUnitPrice.CustomTotals.AddRange(New DevExpress.XtraPivotGrid.PivotGridCustomTotal() {pivotGridCustomTotal1})
            Me.fieldUnitPrice.FieldName = "UnitPrice"
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            Me.fieldUnitPrice.Options.ShowSummaryTypeName = True
            Me.fieldUnitPrice.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Max
            Me.fieldUnitPrice.ValueFormat.FormatString = "c"
            Me.fieldUnitPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            Me.fieldQuantity.Caption = "Quantity"
            Me.fieldQuantity.CellFormat.FormatString = "#.##"
            Me.fieldQuantity.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuantity.FieldName = "Quantity"
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Options.ShowSummaryTypeName = True
            Me.fieldQuantity.ValueFormat.FormatString = "#.##"
            Me.fieldQuantity.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldDiscount
            ' 
            Me.fieldDiscount.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldDiscount.AreaIndex = 2
            Me.fieldDiscount.Caption = "Discount"
            Me.fieldDiscount.CellFormat.FormatString = "p"
            Me.fieldDiscount.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldDiscount.FieldName = "Discount"
            Me.fieldDiscount.Name = "fieldDiscount"
            Me.fieldDiscount.Options.ShowSummaryTypeName = True
            Me.fieldDiscount.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
            Me.fieldDiscount.ValueFormat.FormatString = "p"
            Me.fieldDiscount.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 3
            Me.fieldExtendedPrice.Caption = "Extended Price"
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.FieldName = "Extended Price"
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Options.ShowInCustomizationForm = False
            Me.fieldExtendedPrice.ValueFormat.FormatString = "c"
            Me.fieldExtendedPrice.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.Visible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(726, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 560)
            Me.sidePanel1.TabIndex = 15
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
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 560)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 560)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 533)
            ' 
            ' AutomaticTotals
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "AutomaticTotals"
            Me.Size = New System.Drawing.Size(926, 560)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.AutomaticTotals_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.clbOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbField.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbSummaryType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
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

        Private icbField As DevExpress.XtraEditors.ImageComboBoxEdit

        Private clbOptions As DevExpress.XtraEditors.CheckedListBoxControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private icbSummaryType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Public layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
