Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class FormatRules

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
            Dim pivotGridFormatRule1 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings1 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule2 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleValue1 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim formatRuleTotalTypeSettings1 As DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings = New DevExpress.XtraPivotGrid.FormatRuleTotalTypeSettings()
            Dim pivotGridFormatRule3 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleValue2 As DevExpress.XtraEditors.FormatConditionRuleValue = New DevExpress.XtraEditors.FormatConditionRuleValue()
            Dim formatRuleFieldIntersectionSettings2 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule4 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleIconSet1 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet1 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon1 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon2 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatRuleFieldIntersectionSettings3 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule5 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleIconSet2 As DevExpress.XtraEditors.FormatConditionRuleIconSet = New DevExpress.XtraEditors.FormatConditionRuleIconSet()
            Dim formatConditionIconSet2 As DevExpress.XtraEditors.FormatConditionIconSet = New DevExpress.XtraEditors.FormatConditionIconSet()
            Dim formatConditionIconSetIcon3 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatConditionIconSetIcon4 As DevExpress.XtraEditors.FormatConditionIconSetIcon = New DevExpress.XtraEditors.FormatConditionIconSetIcon()
            Dim formatRuleFieldIntersectionSettings4 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule6 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRule2ColorScale1 As DevExpress.XtraEditors.FormatConditionRule2ColorScale = New DevExpress.XtraEditors.FormatConditionRule2ColorScale()
            Dim formatRuleFieldIntersectionSettings5 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule7 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleTopBottom1 As DevExpress.XtraEditors.FormatConditionRuleTopBottom = New DevExpress.XtraEditors.FormatConditionRuleTopBottom()
            Dim formatRuleFieldIntersectionSettings6 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Me.fieldQuarter = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCountry = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice2 = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategoryName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.dsSalesPerson1 = New DevExpress.XtraPivotGrid.Demos.dsSalesPerson()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProductName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesPerson = New DevExpress.XtraPivotGrid.PivotGridField()
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldQuarter
            ' 
            Me.fieldQuarter.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldQuarter.AreaIndex = 1
            Me.fieldQuarter.Caption = "Order Quarter"
            Me.fieldQuarter.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateQuarter)
            Me.fieldQuarter.Name = "fieldQuarter"
            Me.fieldQuarter.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldQuarter.ValueFormat.FormatString = "Qtr {0}"
            Me.fieldQuarter.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            ' 
            ' fieldCountry
            ' 
            Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCountry.AreaIndex = 1
            Me.fieldCountry.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Country")
            Me.fieldCountry.Name = "fieldCountry"
            ' 
            ' fieldExtendedPrice2
            ' 
            Me.fieldExtendedPrice2.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice2.AreaIndex = 1
            Me.fieldExtendedPrice2.Caption = "Variation"
            Me.fieldExtendedPrice2.DataBinding = New DevExpress.XtraPivotGrid.DifferenceBinding(New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Extended Price"), DevExpress.XtraPivotGrid.CalculationPartitioningCriteria.RowValue, DevExpress.XtraPivotGrid.DifferenceTarget.Previous, DevExpress.XtraPivotGrid.DifferenceType.Absolute)
            Me.fieldExtendedPrice2.Name = "fieldExtendedPrice2"
            ' 
            ' fieldCategoryName
            ' 
            Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategoryName.AreaIndex = 0
            Me.fieldCategoryName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("CategoryName")
            Me.fieldCategoryName.Name = "fieldCategoryName"
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Order Amount"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Extended Price")
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' dsSalesPerson1
            ' 
            Me.dsSalesPerson1.DataSetName = "dsSalesPerson"
            Me.dsSalesPerson1.Locale = New System.Globalization.CultureInfo("en-US")
            Me.dsSalesPerson1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' pivotGridControl1
            '
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.ActiveFilterString = ""
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.pivotGridControl1.DataSource = Me.dsSalesPerson1.SalesPerson
            Me.pivotGridControl1.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.VisualAndText
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldQuarter, Me.fieldExtendedPrice, Me.fieldExtendedPrice2, Me.fieldYear, Me.fieldCategoryName, Me.fieldProductName, Me.fieldCountry, Me.fieldSalesPerson})
            pivotGridFormatRule1.Measure = Me.fieldExtendedPrice2
            pivotGridFormatRule1.Name = "AbsVarDataBar"
            formatConditionRuleDataBar1.Appearance.BackColor = System.Drawing.Color.YellowGreen
            formatConditionRuleDataBar1.Appearance.BackColor2 = System.Drawing.Color.White
            formatConditionRuleDataBar1.Appearance.BorderColor = System.Drawing.Color.SeaGreen
            formatConditionRuleDataBar1.Appearance.Options.UseBackColor = True
            formatConditionRuleDataBar1.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar1.AppearanceNegative.BackColor = System.Drawing.Color.White
            formatConditionRuleDataBar1.AppearanceNegative.BackColor2 = System.Drawing.Color.LightCoral
            formatConditionRuleDataBar1.AppearanceNegative.BorderColor = System.Drawing.Color.RosyBrown
            formatConditionRuleDataBar1.AppearanceNegative.Options.UseBackColor = True
            formatConditionRuleDataBar1.AppearanceNegative.Options.UseBorderColor = True
            formatConditionRuleDataBar1.PredefinedName = Nothing
            formatConditionRuleDataBar1.ShowBarOnly = True
            pivotGridFormatRule1.Rule = formatConditionRuleDataBar1
            formatRuleFieldIntersectionSettings1.Column = Me.fieldQuarter
            formatRuleFieldIntersectionSettings1.Row = Me.fieldCountry
            pivotGridFormatRule1.Settings = formatRuleFieldIntersectionSettings1
            pivotGridFormatRule2.Measure = Me.fieldExtendedPrice2
            pivotGridFormatRule2.Name = "AbsVarGreater0"
            formatConditionRuleValue1.Appearance.ForeColor = System.Drawing.Color.YellowGreen
            formatConditionRuleValue1.Appearance.Options.UseForeColor = True
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater
            formatConditionRuleValue1.Value1 = 0
            pivotGridFormatRule2.Rule = formatConditionRuleValue1
            pivotGridFormatRule2.Settings = formatRuleTotalTypeSettings1
            pivotGridFormatRule3.Measure = Me.fieldExtendedPrice2
            pivotGridFormatRule3.Name = "AbsVarLess0"
            formatConditionRuleValue2.Appearance.ForeColor = System.Drawing.Color.LightCoral
            formatConditionRuleValue2.Appearance.Options.UseForeColor = True
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Less
            formatConditionRuleValue2.Value1 = 0
            pivotGridFormatRule3.Rule = formatConditionRuleValue2
            formatRuleFieldIntersectionSettings2.Column = Me.fieldQuarter
            formatRuleFieldIntersectionSettings2.Row = Me.fieldCategoryName
            pivotGridFormatRule3.Settings = formatRuleFieldIntersectionSettings2
            pivotGridFormatRule4.Measure = Me.fieldExtendedPrice2
            pivotGridFormatRule4.Name = "Format4"
            formatConditionIconSet1.CategoryName = "Directional"
            formatConditionIconSetIcon1.PredefinedName = "Triangles3_1.png"
            formatConditionIconSetIcon2.PredefinedName = "Triangles3_3.png"
            formatConditionIconSetIcon2.Value = New Decimal(New Integer() {9999999, 0, 0, -2147483648})
            formatConditionIconSetIcon2.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon1)
            formatConditionIconSet1.Icons.Add(formatConditionIconSetIcon2)
            formatConditionIconSet1.Name = "Triangles3"
            formatConditionIconSet1.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
            formatConditionRuleIconSet1.IconSet = formatConditionIconSet1
            pivotGridFormatRule4.Rule = formatConditionRuleIconSet1
            formatRuleFieldIntersectionSettings3.Column = Me.fieldQuarter
            formatRuleFieldIntersectionSettings3.Row = Me.fieldCategoryName
            pivotGridFormatRule4.Settings = formatRuleFieldIntersectionSettings3
            pivotGridFormatRule4.StopIfTrue = True
            pivotGridFormatRule5.Measure = Me.fieldExtendedPrice2
            pivotGridFormatRule5.Name = "Format1"
            formatConditionIconSet2.CategoryName = "Directional"
            formatConditionIconSetIcon3.PredefinedName = "Arrows4_1.png"
            formatConditionIconSetIcon4.PredefinedName = "Arrows4_4.png"
            formatConditionIconSetIcon4.Value = New Decimal(New Integer() {99999999, 0, 0, -2147483648})
            formatConditionIconSetIcon4.ValueComparison = DevExpress.XtraEditors.FormatConditionComparisonType.GreaterOrEqual
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon3)
            formatConditionIconSet2.Icons.Add(formatConditionIconSetIcon4)
            formatConditionIconSet2.Name = "Arrows4Colored"
            formatConditionIconSet2.ValueType = DevExpress.XtraEditors.FormatConditionValueType.Number
            formatConditionRuleIconSet2.IconSet = formatConditionIconSet2
            pivotGridFormatRule5.Rule = formatConditionRuleIconSet2
            formatRuleFieldIntersectionSettings4.Column = Me.fieldQuarter
            pivotGridFormatRule5.Settings = formatRuleFieldIntersectionSettings4
            pivotGridFormatRule6.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule6.Name = "Format5"
            formatConditionRule2ColorScale1.PredefinedName = "Yellow, Green"
            pivotGridFormatRule6.Rule = formatConditionRule2ColorScale1
            formatRuleFieldIntersectionSettings5.Column = Me.fieldQuarter
            formatRuleFieldIntersectionSettings5.Row = Me.fieldCountry
            pivotGridFormatRule6.Settings = formatRuleFieldIntersectionSettings5
            pivotGridFormatRule7.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule7.Name = "Top 3 Sale"
            formatConditionRuleTopBottom1.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            formatConditionRuleTopBottom1.Appearance.Options.UseFont = True
            formatConditionRuleTopBottom1.Rank = New Decimal(New Integer() {3, 0, 0, 0})
            formatConditionRuleTopBottom1.RankType = DevExpress.XtraEditors.FormatConditionValueType.Number
            pivotGridFormatRule7.Rule = formatConditionRuleTopBottom1
            formatRuleFieldIntersectionSettings6.Column = Me.fieldQuarter
            formatRuleFieldIntersectionSettings6.Row = Me.fieldCountry
            pivotGridFormatRule7.Settings = formatRuleFieldIntersectionSettings6
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule1)
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule2)
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule3)
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule4)
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule5)
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule6)
            Me.pivotGridControl1.FormatRules.Add(pivotGridFormatRule7)
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = True
            Me.pivotGridControl1.OptionsView.ShowColumnGrandTotals = False
            Me.pivotGridControl1.OptionsView.ShowColumnTotals = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(704, 416)
            Me.pivotGridControl1.TabIndex = 12
            AddHandler Me.pivotGridControl1.Click, New System.EventHandler(AddressOf Me.pivotGridControl1_Click)
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Order Year"
            Me.fieldYear.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("OrderDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            Me.fieldYear.Name = "fieldYear"
            Me.fieldYear.UnboundFieldName = "fieldYear"
            ' 
            ' fieldProductName
            ' 
            Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldProductName.AreaIndex = 2
            Me.fieldProductName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ProductName")
            Me.fieldProductName.Name = "fieldProductName"
            Me.fieldProductName.Visible = False
            ' 
            ' fieldSalesPerson
            ' 
            Me.fieldSalesPerson.AreaIndex = 0
            Me.fieldSalesPerson.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Sales Person")
            Me.fieldSalesPerson.Name = "fieldSalesPerson"
            ' 
            ' FormatRules
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "FormatRules"
            Me.Size = New System.Drawing.Size(704, 416)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.StyleConditions_Load)
            CType((Me.dsSalesPerson1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dsSalesPerson1 As DevExpress.XtraPivotGrid.Demos.dsSalesPerson

        Private components As System.ComponentModel.IContainer = Nothing

        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldQuarter As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice2 As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategoryName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProductName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCountry As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesPerson As DevExpress.XtraPivotGrid.PivotGridField
    End Class
End Namespace
