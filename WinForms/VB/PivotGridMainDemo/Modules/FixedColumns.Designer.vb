Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class FixedColumns

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
        Private Sub InitializeComponent()
            Dim dataSourceColumnBinding1 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding2 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding3 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim expressionDataBinding1 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim dataSourceColumnBinding4 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim dataSourceColumnBinding5 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim expressionDataBinding2 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim expressionDataBinding3 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim dataSourceColumnBinding6 As DevExpress.XtraPivotGrid.DataSourceColumnBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding()
            Dim expressionDataBinding4 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Dim expressionDataBinding5 As DevExpress.XtraPivotGrid.ExpressionDataBinding = New DevExpress.XtraPivotGrid.ExpressionDataBinding()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCategory = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldMin = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldProduct = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMax = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMedian = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldQuantity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fcFieldMin = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fcFieldMax = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.tabPane1 = New DevExpress.XtraBars.Navigation.TabPane()
            Me.tabNavigationPage1 = New DevExpress.XtraBars.Navigation.TabNavigationPage()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.rgPinColLocation = New DevExpress.XtraEditors.RadioGroup()
            Me.ceShowColumns = New DevExpress.XtraEditors.CheckEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPane1.SuspendLayout()
            Me.tabNavigationPage1.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.rgPinColLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowColumns.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            Me.fieldExtendedPrice.CellFormat.FormatString = "C"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            dataSourceColumnBinding1.ColumnName = "Extended Price"
            Me.fieldExtendedPrice.DataBinding = dataSourceColumnBinding1
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            ' 
            ' fieldYear
            ' 
            Me.fieldYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldYear.AreaIndex = 0
            Me.fieldYear.Caption = "Year"
            dataSourceColumnBinding2.ColumnName = "OrderDate"
            dataSourceColumnBinding2.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
            Me.fieldYear.DataBinding = dataSourceColumnBinding2
            Me.fieldYear.Name = "fieldYear"
            ' 
            ' fieldCategory
            ' 
            Me.fieldCategory.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldCategory.AreaIndex = 0
            Me.fieldCategory.Caption = "Category"
            dataSourceColumnBinding3.ColumnName = "CategoryName"
            Me.fieldCategory.DataBinding = dataSourceColumnBinding3
            Me.fieldCategory.Name = "fieldCategory"
            Me.fieldCategory.Width = 123
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldYear, Me.fieldExtendedPrice, Me.fieldCategory, Me.fieldMin, Me.fieldMonth, Me.fieldProduct, Me.fieldMax, Me.fieldMedian, Me.fieldQuantity, Me.fcFieldMin, Me.fcFieldMax})
            Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsCustomization.AllowFilter = False
            Me.pivotGridControl1.OptionsCustomization.AllowFilterBySummary = False
            Me.pivotGridControl1.OptionsCustomization.FilterPanelVisible = DevExpress.XtraPivotGrid.FilterPanelVisible.Never
            Me.pivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl1.OptionsMenu.EnableFormatRulesMenu = True
            Me.pivotGridControl1.OptionsMenu.ShowDateTimeGroupIntervalItems = DevExpress.XtraPivotGrid.DateTimeGroupIntervals.None
            Me.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(584, 432)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' fieldMin
            ' 
            Me.fieldMin.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldMin.Appearance.ValueGrandTotal.Options.UseTextOptions = True
            Me.fieldMin.Appearance.ValueGrandTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
            Me.fieldMin.Appearance.ValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.fieldMin.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldMin.AreaIndex = 1
            Me.fieldMin.Caption = "Min Month Sales"
            Me.fieldMin.CellFormat.FormatString = "C"
            Me.fieldMin.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            expressionDataBinding1.Expression = "Min(Aggr(Sum([fieldExtendedPrice]),[CategoryName],[ProductName],[fieldYear],[fiel" & "dMonth]))"
            Me.fieldMin.DataBinding = expressionDataBinding1
            Me.fieldMin.Name = "fieldMin"
            Me.fieldMin.Options.ShowTotals = False
            Me.fieldMin.Options.ShowValues = False
            Me.fieldMin.UnboundFieldName = "fieldMin"
            Me.fieldMin.Width = 60
            ' 
            ' fieldMonth
            ' 
            Me.fieldMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldMonth.AreaIndex = 1
            Me.fieldMonth.Caption = "Month"
            dataSourceColumnBinding4.ColumnName = "OrderDate"
            dataSourceColumnBinding4.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth
            Me.fieldMonth.DataBinding = dataSourceColumnBinding4
            Me.fieldMonth.Name = "fieldMonth"
            ' 
            ' fieldProduct
            ' 
            Me.fieldProduct.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldProduct.AreaIndex = 1
            Me.fieldProduct.Caption = "Product"
            dataSourceColumnBinding5.ColumnName = "ProductName"
            Me.fieldProduct.DataBinding = dataSourceColumnBinding5
            Me.fieldProduct.Name = "fieldProduct"
            ' 
            ' fieldMax
            ' 
            Me.fieldMax.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldMax.Appearance.ValueGrandTotal.Options.UseTextOptions = True
            Me.fieldMax.Appearance.ValueGrandTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
            Me.fieldMax.Appearance.ValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.fieldMax.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldMax.AreaIndex = 2
            Me.fieldMax.Caption = "Max Month Sales"
            Me.fieldMax.CellFormat.FormatString = "C"
            Me.fieldMax.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            expressionDataBinding2.Expression = "Max(Aggr(Sum([fieldExtendedPrice]),[CategoryName],[ProductName],[fieldYear],[fiel" & "dMonth]))"
            Me.fieldMax.DataBinding = expressionDataBinding2
            Me.fieldMax.Name = "fieldMax"
            Me.fieldMax.Options.ShowTotals = False
            Me.fieldMax.Options.ShowValues = False
            Me.fieldMax.UnboundFieldName = "fieldMax"
            Me.fieldMax.Width = 60
            ' 
            ' fieldMedian
            ' 
            Me.fieldMedian.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldMedian.Appearance.ValueGrandTotal.Options.UseTextOptions = True
            Me.fieldMedian.Appearance.ValueGrandTotal.TextOptions.Trimming = DevExpress.Utils.Trimming.Word
            Me.fieldMedian.Appearance.ValueGrandTotal.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.fieldMedian.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldMedian.AreaIndex = 3
            Me.fieldMedian.Caption = "Median Month Sales"
            Me.fieldMedian.CellFormat.FormatString = "C"
            Me.fieldMedian.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            expressionDataBinding3.Expression = "Median(Aggr(Sum([fieldExtendedPrice]),[CategoryName],[ProductName],[fieldYear],[f" & "ieldMonth]))"
            Me.fieldMedian.DataBinding = expressionDataBinding3
            Me.fieldMedian.Name = "fieldMedian"
            Me.fieldMedian.Options.ShowTotals = False
            Me.fieldMedian.Options.ShowValues = False
            Me.fieldMedian.UnboundFieldName = "fieldMedian"
            Me.fieldMedian.Width = 60
            ' 
            ' fieldQuantity
            ' 
            Me.fieldQuantity.AllowedAreas = DevExpress.XtraPivotGrid.PivotGridAllowedAreas.DataArea
            Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldQuantity.AreaIndex = 4
            dataSourceColumnBinding6.ColumnName = "Quantity"
            Me.fieldQuantity.DataBinding = dataSourceColumnBinding6
            Me.fieldQuantity.Name = "fieldQuantity"
            ' 
            ' fcFieldMin
            ' 
            Me.fcFieldMin.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fcFieldMin.AreaIndex = 5
            Me.fcFieldMin.CalculateHiddenSummaries = True
            Me.fcFieldMin.Caption = "Min Sales by Products"
            Me.fcFieldMin.CellFormat.FormatString = "C"
            Me.fcFieldMin.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            expressionDataBinding4.Expression = "Min(Aggr([fieldMin], [fieldCategory], [fieldProduct]))"
            Me.fcFieldMin.DataBinding = expressionDataBinding4
            Me.fcFieldMin.Name = "fcFieldMin"
            Me.fcFieldMin.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fcFieldMin.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.[False]
            Me.fcFieldMin.UnboundFieldName = "fcFieldMin"
            Me.fcFieldMin.Visible = False
            ' 
            ' fcFieldMax
            ' 
            Me.fcFieldMax.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fcFieldMax.AreaIndex = 4
            Me.fcFieldMax.CalculateHiddenSummaries = True
            Me.fcFieldMax.Caption = "Max Sales by Products"
            Me.fcFieldMax.CellFormat.FormatString = "C"
            Me.fcFieldMax.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            expressionDataBinding5.Expression = "Max(Aggr([fieldMax], [fieldCategory], [fieldProduct]))"
            Me.fcFieldMax.DataBinding = expressionDataBinding5
            Me.fcFieldMax.Name = "fcFieldMax"
            Me.fcFieldMax.Options.AllowDrag = DevExpress.Utils.DefaultBoolean.[False]
            Me.fcFieldMax.Options.AllowDragInCustomizationForm = DevExpress.Utils.DefaultBoolean.[False]
            Me.fcFieldMax.UnboundFieldName = "fcFieldMax"
            Me.fcFieldMax.Visible = False
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.tabPane1)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(584, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(200, 432)
            Me.sidePanel1.TabIndex = 1
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' tabPane1
            ' 
            Me.tabPane1.Controls.Add(Me.tabNavigationPage1)
            Me.tabPane1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.tabPane1.Location = New System.Drawing.Point(1, 0)
            Me.tabPane1.Name = "tabPane1"
            Me.tabPane1.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tabNavigationPage1})
            Me.tabPane1.RegularSize = New System.Drawing.Size(199, 432)
            Me.tabPane1.SelectedPage = Me.tabNavigationPage1
            Me.tabPane1.Size = New System.Drawing.Size(199, 432)
            Me.tabPane1.TabIndex = 0
            Me.tabPane1.Text = "tabPane1"
            ' 
            ' tabNavigationPage1
            ' 
            Me.tabNavigationPage1.Caption = "Options"
            Me.tabNavigationPage1.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPage1.Name = "tabNavigationPage1"
            Me.tabNavigationPage1.Size = New System.Drawing.Size(199, 403)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.rgPinColLocation)
            Me.layoutControl1.Controls.Add(Me.ceShowColumns)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(553, 465, 883, 561)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(199, 403)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' rgPinColLocation
            ' 
            Me.rgPinColLocation.AutoSizeInLayoutControl = True
            Me.rgPinColLocation.Location = New System.Drawing.Point(13, 83)
            Me.rgPinColLocation.Name = "rgPinColLocation"
            Me.rgPinColLocation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.rgPinColLocation.Properties.Appearance.Options.UseBackColor = True
            Me.rgPinColLocation.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.rgPinColLocation.Properties.Columns = 1
            Me.rgPinColLocation.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Left"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Right")})
            Me.rgPinColLocation.Size = New System.Drawing.Size(173, 56)
            Me.rgPinColLocation.StyleController = Me.layoutControl1
            Me.rgPinColLocation.TabIndex = 4
            AddHandler Me.rgPinColLocation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.RgPinColLocation_SelectedIndexChanged)
            ' 
            ' ceShowColumns
            ' 
            Me.ceShowColumns.AutoSizeInLayoutControl = True
            Me.ceShowColumns.EditValue = True
            Me.ceShowColumns.Location = New System.Drawing.Point(13, 35)
            Me.ceShowColumns.Name = "ceShowColumns"
            Me.ceShowColumns.Properties.Caption = "Show in scrollable area"
            Me.ceShowColumns.Size = New System.Drawing.Size(132, 20)
            Me.ceShowColumns.StyleController = Me.layoutControl1
            Me.ceShowColumns.TabIndex = 5
            AddHandler Me.ceShowColumns.CheckedChanged, New System.EventHandler(AddressOf Me.CeShowColumns_CheckedChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroup1})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.Root.Size = New System.Drawing.Size(199, 403)
            Me.Root.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 152)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(199, 251)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(9, 9, 9, 9)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(199, 152)
            Me.layoutControlGroup1.Text = "Pinned Columns"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.rgPinColLocation
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItem1.Size = New System.Drawing.Size(177, 84)
            Me.layoutControlItem1.Text = "Location"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(40, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.ceShowColumns
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(177, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' FixedColumns
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "FixedColumns"
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.FixedColumns_Load)
            CType((Me.pivotGridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((Me.tabPane1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPane1.ResumeLayout(False)
            Me.tabNavigationPage1.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.rgPinColLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowColumns.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCategory As DevExpress.XtraPivotGrid.PivotGridField

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private tabPane1 As DevExpress.XtraBars.Navigation.TabPane

        Private tabNavigationPage1 As DevExpress.XtraBars.Navigation.TabNavigationPage

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private rgPinColLocation As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private ceShowColumns As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private fieldMin As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldProduct As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMax As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMedian As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldQuantity As DevExpress.XtraPivotGrid.PivotGridField

        Private fcFieldMin As DevExpress.XtraPivotGrid.PivotGridField

        Private fcFieldMax As DevExpress.XtraPivotGrid.PivotGridField

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
