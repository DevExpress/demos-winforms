Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class CalculatedFields

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
            Dim expressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding7 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding8 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding9 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding10 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldFirstName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldLastName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldOrderID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYearEndBonus = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantityBonus = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldUnitPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldEmployeeID = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.btnAddBonus = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.checkYearEndBonus = New DevExpress.XtraEditors.CheckEdit()
            Me.checkQuantityBonus = New DevExpress.XtraEditors.CheckEdit()
            Me.checkDataSourceValue = New DevExpress.XtraEditors.CheckEdit()
            Me.checkDisplayText = New DevExpress.XtraEditors.CheckEdit()
            Me.checkExpression = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.checkYearEndBonus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkQuantityBonus.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkDataSourceValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkDisplayText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkExpression.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldExtendedPrice, Me.fieldFirstName, Me.fieldLastName, Me.fieldOrderDate, Me.fieldQuarter, Me.fieldOrderID, Me.fieldQuantity, Me.fieldSalesPerson, Me.fieldYearEndBonus, Me.fieldQuantityBonus, Me.fieldUnitPrice, Me.fieldYear, Me.fieldEmployeeID})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsCustomization.AllowDrag = False
            Me.pivotGridControl.OptionsCustomization.AllowDragInCustomizationForm = False
            Me.pivotGridControl.OptionsCustomization.AllowExpand = False
            Me.pivotGridControl.OptionsCustomization.AllowFilterBySummary = False
            Me.pivotGridControl.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never
            Me.pivotGridControl.OptionsCustomization.AllowSortBySummary = False
            Me.pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl.OptionsFilter.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl.OptionsView.ShowColumnGrandTotalHeader = False
            Me.pivotGridControl.OptionsView.ShowColumnHeaders = False
            Me.pivotGridControl.OptionsView.ShowDataHeaders = False
            Me.pivotGridControl.OptionsView.ShowFilterHeaders = False
            Me.pivotGridControl.OptionsView.ShowRowGrandTotals = False
            Me.pivotGridControl.Size = New System.Drawing.Size(506, 416)
            Me.pivotGridControl.TabIndex = 0
            Me.pivotGridControl.TabStop = False
            AddHandler Me.pivotGridControl.FieldValueDisplayText, New DevExpress.XtraPivotGrid.PivotFieldDisplayTextEventHandler(AddressOf Me.pivotGridControlOnFieldValueDisplayText)
            AddHandler Me.pivotGridControl.CellDoubleClick, New DevExpress.XtraPivotGrid.PivotCellEventHandler(AddressOf Me.pivotGridControlOnCellDoubleClick)
            AddHandler Me.pivotGridControl.PopupMenuShowing, New DevExpress.XtraPivotGrid.PopupMenuShowingEventHandler(AddressOf Me.pivotGridControlOnPopupMenuShowing)
            AddHandler Me.pivotGridControl.CustomDrawFieldHeader, New DevExpress.XtraPivotGrid.PivotCustomDrawFieldHeaderEventHandler(AddressOf Me.pivotGridControlOnCustomDrawFieldHeader)
            AddHandler Me.pivotGridControl.CustomDrawFieldValue, New DevExpress.XtraPivotGrid.PivotCustomDrawFieldValueEventHandler(AddressOf Me.pivotGridControlOnCustomDrawFieldValue)
            AddHandler Me.pivotGridControl.MouseClick, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pivotGridControlOnMouseClick)
            AddHandler Me.pivotGridControl.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.pivotGridControlOnMouseMove)
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 2
            Me.fieldExtendedPrice.Caption = "Extended Price"
            Me.fieldExtendedPrice.CellFormat.FormatString = "c"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            expressionDataBinding1.Expression = "[fieldQuantity] * [fieldUnitPrice]"
            Me.fieldExtendedPrice.DataBinding = expressionDataBinding1
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Width = 82
            ' 
            ' fieldFirstName
            ' 
            Me.fieldFirstName.AreaIndex = 0
            dataSourceColumnBinding1.ColumnName = "FirstName"
            Me.fieldFirstName.DataBinding = dataSourceColumnBinding1
            Me.fieldFirstName.Name = "fieldFirstName"
            ' 
            ' fieldLastName
            ' 
            Me.fieldLastName.AreaIndex = 1
            dataSourceColumnBinding2.ColumnName = "LastName"
            Me.fieldLastName.DataBinding = dataSourceColumnBinding2
            Me.fieldLastName.Name = "fieldLastName"
            ' 
            ' fieldOrderDate
            ' 
            Me.fieldOrderDate.AreaIndex = 5
            dataSourceColumnBinding3.ColumnName = "OrderDate"
            Me.fieldOrderDate.DataBinding = dataSourceColumnBinding3
            Me.fieldOrderDate.Name = "fieldOrderDate"
            Me.fieldOrderDate.Visible = False
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Quarter"
            dataSourceColumnBinding4.ColumnName = "OrderDate"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter
            Me.fieldQuarter.DataBinding = dataSourceColumnBinding4
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldQuarter.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldQuarter.Width = 60
            ' 
            ' fieldOrderID
            ' 
            Me.fieldOrderID.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldOrderID.AreaIndex = 0
            Me.fieldOrderID.Caption = "Order Count"
            dataSourceColumnBinding5.ColumnName = "OrderID"
            Me.fieldOrderID.DataBinding = dataSourceColumnBinding5
            Me.fieldOrderID.Name = "fieldOrderID"
            Me.fieldOrderID.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.CountDistinct
            Me.fieldOrderID.Width = 71
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 1
            dataSourceColumnBinding6.ColumnName = "Quantity"
            Me.fieldQuantity.DataBinding = dataSourceColumnBinding6
            Me.fieldQuantity.Name = "fieldQuantity"
            Me.fieldQuantity.Width = 53
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.Caption = "Sales Person"
            dataSourceColumnBinding7.ColumnName = "EmployeeID"
            Me.fieldSalesPerson.DataBinding = dataSourceColumnBinding7
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            Me.fieldSalesPerson.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldSalesPerson.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldSalesPerson.Options.AllowFilter = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldSalesPerson.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.[True]
            Me.fieldSalesPerson.Options.AllowSort = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldSalesPerson.Options.ShowGrandTotal = False
            Me.fieldSalesPerson.Options.ShowTotals = False
            Me.fieldSalesPerson.Width = 116
            ' 
            ' fieldYearEndBonus
            ' 
            Me.fieldYearEndBonus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldYearEndBonus.AreaIndex = 3
            Me.fieldYearEndBonus.Caption = "Year End Bonus"
            Me.fieldYearEndBonus.CellFormat.FormatString = "c"
            Me.fieldYearEndBonus.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldYearEndBonus.Name = "fieldYearEndBonus"
            Me.fieldYearEndBonus.Width = 97
            ' 
            ' fieldQuantityBonus
            ' 
            Me.fieldQuantityBonus.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantityBonus.AreaIndex = 4
            Me.fieldQuantityBonus.Caption = "Quantity Bonus"
            Me.fieldQuantityBonus.CellFormat.FormatString = "c"
            Me.fieldQuantityBonus.CellFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.fieldQuantityBonus.Name = "fieldQuantityBonus"
            Me.fieldQuantityBonus.Width = 97
            ' 
            ' fieldUnitPrice
            ' 
            Me.fieldUnitPrice.AreaIndex = 2
            dataSourceColumnBinding8.ColumnName = "UnitPrice"
            Me.fieldUnitPrice.DataBinding = dataSourceColumnBinding8
            Me.fieldUnitPrice.Name = "fieldUnitPrice"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.AreaIndex = 3
            Me.fieldYear.Caption = "Year"
            dataSourceColumnBinding9.ColumnName = "OrderDate"
            dataSourceColumnBinding9.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = dataSourceColumnBinding9
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.Options.ShowInExpressionEditor = False
            Me.fieldYear.Options.ShowInFilter = False
            ' 
            ' fieldEmployeeID
            ' 
            Me.fieldEmployeeID.AreaIndex = 4
            dataSourceColumnBinding10.ColumnName = "EmployeeID"
            Me.fieldEmployeeID.DataBinding = dataSourceColumnBinding10
            Me.fieldEmployeeID.Name = "fieldEmployeeID"
            ' 
            ' btnAddBonus
            ' 
            Me.btnAddBonus.Location = New System.Drawing.Point(12, 196)
            Me.btnAddBonus.Name = "btnAddBonus"
            Me.btnAddBonus.Size = New System.Drawing.Size(175, 22)
            Me.btnAddBonus.StyleController = Me.layoutControl1
            Me.btnAddBonus.TabIndex = 4
            Me.btnAddBonus.Text = "Add New Bonus"
            AddHandler Me.btnAddBonus.Click, New System.EventHandler(AddressOf Me.buttonAddNewBonusOnClick)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.btnAddBonus)
            Me.layoutControl1.Controls.Add(Me.checkYearEndBonus)
            Me.layoutControl1.Controls.Add(Me.checkQuantityBonus)
            Me.layoutControl1.Controls.Add(Me.checkDataSourceValue)
            Me.layoutControl1.Controls.Add(Me.checkDisplayText)
            Me.layoutControl1.Controls.Add(Me.checkExpression)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1226, 139, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(199, 383)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' checkYearEndBonus
            ' 
            Me.checkYearEndBonus.Location = New System.Drawing.Point(12, 172)
            Me.checkYearEndBonus.Name = "checkYearEndBonus"
            Me.checkYearEndBonus.Properties.Caption = "Year-End Bonus"
            Me.checkYearEndBonus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.checkYearEndBonus.Size = New System.Drawing.Size(175, 20)
            Me.checkYearEndBonus.StyleController = Me.layoutControl1
            Me.checkYearEndBonus.TabIndex = 1
            AddHandler Me.checkYearEndBonus.CheckedChanged, New System.EventHandler(AddressOf Me.checkYearEndBonusOnCheckedChanged)
            ' 
            ' checkQuantityBonus
            ' 
            Me.checkQuantityBonus.Location = New System.Drawing.Point(12, 148)
            Me.checkQuantityBonus.Name = "checkQuantityBonus"
            Me.checkQuantityBonus.Properties.Caption = "Quantity Bonus"
            Me.checkQuantityBonus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.checkQuantityBonus.Size = New System.Drawing.Size(175, 20)
            Me.checkQuantityBonus.StyleController = Me.layoutControl1
            Me.checkQuantityBonus.TabIndex = 2
            AddHandler Me.checkQuantityBonus.CheckedChanged, New System.EventHandler(AddressOf Me.checkQuantityBonusOnCheckedChanged)
            ' 
            ' checkDataSourceValue
            ' 
            Me.checkDataSourceValue.Location = New System.Drawing.Point(12, 82)
            Me.checkDataSourceValue.Name = "checkDataSourceValue"
            Me.checkDataSourceValue.Properties.Caption = "Data Source Value"
            Me.checkDataSourceValue.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.checkDataSourceValue.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.checkDataSourceValue.Properties.RadioGroupIndex = 1
            Me.checkDataSourceValue.Size = New System.Drawing.Size(175, 20)
            Me.checkDataSourceValue.StyleController = Me.layoutControl1
            Me.checkDataSourceValue.TabIndex = 3
            Me.checkDataSourceValue.TabStop = False
            AddHandler Me.checkDataSourceValue.CheckedChanged, New System.EventHandler(AddressOf Me.checkDataSourceValueOnCheckedChanged)
            ' 
            ' checkDisplayText
            ' 
            Me.checkDisplayText.Location = New System.Drawing.Point(12, 58)
            Me.checkDisplayText.Name = "checkDisplayText"
            Me.checkDisplayText.Properties.Caption = "Display Text Event"
            Me.checkDisplayText.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.checkDisplayText.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.checkDisplayText.Properties.RadioGroupIndex = 1
            Me.checkDisplayText.Size = New System.Drawing.Size(175, 20)
            Me.checkDisplayText.StyleController = Me.layoutControl1
            Me.checkDisplayText.TabIndex = 1
            Me.checkDisplayText.TabStop = False
            AddHandler Me.checkDisplayText.CheckedChanged, New System.EventHandler(AddressOf Me.checkDisplayTextOnCheckedChanged)
            ' 
            ' checkExpression
            ' 
            Me.checkExpression.Location = New System.Drawing.Point(12, 34)
            Me.checkExpression.Name = "checkExpression"
            Me.checkExpression.Properties.Caption = "Calculated Field"
            Me.checkExpression.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio
            Me.checkExpression.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.checkExpression.Properties.RadioGroupIndex = 1
            Me.checkExpression.Size = New System.Drawing.Size(175, 20)
            Me.checkExpression.StyleController = Me.layoutControl1
            Me.checkExpression.TabIndex = 2
            Me.checkExpression.TabStop = False
            AddHandler Me.checkExpression.CheckedChanged, New System.EventHandler(AddressOf Me.checkExpressionOnCheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 383)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem3, Me.layoutControlItem5})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(199, 114)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup2.Text = "Sales Person"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkDisplayText
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkExpression
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.checkDataSourceValue
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem6, Me.layoutControlItem8})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(199, 116)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup3.Text = "Bonuses"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.checkQuantityBonus
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.checkYearEndBonus
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(179, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.btnAddBonus
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(179, 26)
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 230)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 153)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(506, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 416)
            Me.sidePanel1.TabIndex = 2
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
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 383)
            ' 
            ' CalculatedFields
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "CalculatedFields"
            Me.Size = New System.Drawing.Size(706, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.CalculatedFields_Load)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.checkYearEndBonus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkQuantityBonus.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkDataSourceValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkDisplayText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkExpression.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldFirstName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldLastName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldOrderID As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYearEndBonus As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantityBonus As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldUnitPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private checkExpression As DevExpress.XtraEditors.CheckEdit

        Private checkDataSourceValue As DevExpress.XtraEditors.CheckEdit

        Private checkDisplayText As DevExpress.XtraEditors.CheckEdit

        Private btnAddBonus As DevExpress.XtraEditors.SimpleButton

        Private checkYearEndBonus As DevExpress.XtraEditors.CheckEdit

        Private checkQuantityBonus As DevExpress.XtraEditors.CheckEdit

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldEmployeeID As DevExpress.XtraPivotGrid.PivotGridField

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private fieldOrderDate As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
