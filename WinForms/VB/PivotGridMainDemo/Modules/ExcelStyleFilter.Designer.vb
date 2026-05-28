Imports DevExpress.Utils.Filtering

Namespace DevExpress.XtraPivotGrid.Demos.Modules

    Partial Class ExcelStyleFilter

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
            Me.components = New System.ComponentModel.Container()
            Dim pivotGridFormatRule1 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar1 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings1 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule2 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar2 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings2 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule3 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar3 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings3 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule4 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar4 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings4 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule5 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar5 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings5 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridFormatRule6 As DevExpress.XtraPivotGrid.PivotGridFormatRule = New DevExpress.XtraPivotGrid.PivotGridFormatRule()
            Dim formatConditionRuleDataBar6 As DevExpress.XtraEditors.FormatConditionRuleDataBar = New DevExpress.XtraEditors.FormatConditionRuleDataBar()
            Dim formatRuleFieldIntersectionSettings6 As DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings = New DevExpress.XtraPivotGrid.FormatRuleFieldIntersectionSettings()
            Dim pivotGridGroup1 As DevExpress.XtraPivotGrid.PivotGridGroup = New DevExpress.XtraPivotGrid.PivotGridGroup()
            Me.fieldExtendedPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesYear = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldName = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesMonth = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesDay = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldTrademark = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.pivotGridControl = New DevExpress.XtraPivotGrid.PivotGridControl()
            Me.fieldDiscount = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldCylinders = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldHorsepower = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldDoors = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldBodyStyle = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldModification = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMPGCity = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldMPGHighway = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldSalesDate = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.fieldModelPrice = New DevExpress.XtraPivotGrid.PivotGridField()
            Me.accordionControl = New DevExpress.XtraBars.Navigation.AccordionControl()
            Me.accordionContentContainer15 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.fieldSalesDateFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.filteringUIContext = New DevExpress.Utils.Filtering.FilteringUIContext(Me.components)
            Me.accordionContentContainer16 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.fieldModelPriceFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.accordionContentContainer9 = New DevExpress.XtraBars.Navigation.AccordionContentContainer()
            Me.fieldBodyStyleFilterUIEditorContainerEdit = New DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit()
            Me.accordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement17 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement10 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.accordionControlElement16 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionControl.SuspendLayout()
            Me.accordionContentContainer15.SuspendLayout()
            CType((Me.fieldSalesDateFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.filteringUIContext), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionContentContainer16.SuspendLayout()
            CType((Me.fieldModelPriceFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.accordionContentContainer9.SuspendLayout()
            CType((Me.fieldBodyStyleFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' fieldExtendedPrice
            ' 
            Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
            Me.fieldExtendedPrice.AreaIndex = 0
            Me.fieldExtendedPrice.Caption = "Extended Price"
            Me.fieldExtendedPrice.CellFormat.FormatString = "c0"
            Me.fieldExtendedPrice.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.fieldExtendedPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ModelPrice")
            Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
            Me.fieldExtendedPrice.Options.AllowFilterBySummary = DevExpress.Utils.DefaultBoolean.[False]
            Me.fieldExtendedPrice.UnboundFieldName = "fieldExtendedPrice"
            ' 
            ' fieldSalesYear
            ' 
            Me.fieldSalesYear.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesYear.AreaIndex = 0
            Me.fieldSalesYear.Caption = "Year"
            Me.fieldSalesYear.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("SalesDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear)
            Me.fieldSalesYear.Name = "fieldSalesYear"
            Me.fieldSalesYear.UnboundFieldName = "fieldSalesYear"
            ' 
            ' fieldName
            ' 
            Me.fieldName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldName.AreaIndex = 1
            Me.fieldName.Caption = "Name"
            Me.fieldName.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Name")
            Me.fieldName.Name = "fieldName"
            ' 
            ' fieldSalesMonth
            ' 
            Me.fieldSalesMonth.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesMonth.AreaIndex = 1
            Me.fieldSalesMonth.Caption = "Month"
            Me.fieldSalesMonth.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("SalesDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateMonth)
            Me.fieldSalesMonth.Name = "fieldSalesMonth"
            ' 
            ' fieldSalesDay
            ' 
            Me.fieldSalesDay.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
            Me.fieldSalesDay.AreaIndex = 2
            Me.fieldSalesDay.Caption = "Day"
            Me.fieldSalesDay.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("SalesDate", DevExpress.XtraPivotGrid.PivotGroupInterval.DateDay)
            Me.fieldSalesDay.Name = "fieldSalesDay"
            Me.fieldSalesDay.UnboundFieldName = "fieldSalesDay"
            ' 
            ' fieldTrademark
            ' 
            Me.fieldTrademark.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
            Me.fieldTrademark.AreaIndex = 0
            Me.fieldTrademark.Caption = "Trademark"
            Me.fieldTrademark.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Trademark")
            Me.fieldTrademark.Name = "fieldTrademark"
            Me.fieldTrademark.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.DisplayText
            ' 
            ' pivotGridControl
            ' 
            Me.pivotGridControl.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
            Me.pivotGridControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pivotGridControl.DefaultFilterEditorView = DevExpress.XtraEditors.FilterEditorViewMode.Visual
            Me.pivotGridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pivotGridControl.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.fieldExtendedPrice, Me.fieldName, Me.fieldSalesYear, Me.fieldTrademark, Me.fieldDiscount, Me.fieldCylinders, Me.fieldHorsepower, Me.fieldDoors, Me.fieldBodyStyle, Me.fieldSalesMonth, Me.fieldSalesDay, Me.fieldModification, Me.fieldMPGCity, Me.fieldMPGHighway, Me.fieldSalesDate, Me.fieldModelPrice})
            pivotGridFormatRule1.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule1.Name = "Format0"
            formatConditionRuleDataBar1.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar1.PredefinedName = "Blue Gradient"
            pivotGridFormatRule1.Rule = formatConditionRuleDataBar1
            formatRuleFieldIntersectionSettings1.Column = Me.fieldSalesYear
            formatRuleFieldIntersectionSettings1.Row = Me.fieldName
            pivotGridFormatRule1.Settings = formatRuleFieldIntersectionSettings1
            pivotGridFormatRule2.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule2.Name = "Format1"
            formatConditionRuleDataBar2.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar2.PredefinedName = "Blue Gradient"
            pivotGridFormatRule2.Rule = formatConditionRuleDataBar2
            formatRuleFieldIntersectionSettings2.Column = Me.fieldSalesMonth
            formatRuleFieldIntersectionSettings2.Row = Me.fieldName
            pivotGridFormatRule2.Settings = formatRuleFieldIntersectionSettings2
            pivotGridFormatRule3.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule3.Name = "Format2"
            formatConditionRuleDataBar3.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar3.PredefinedName = "Blue Gradient"
            pivotGridFormatRule3.Rule = formatConditionRuleDataBar3
            formatRuleFieldIntersectionSettings3.Column = Me.fieldSalesDay
            formatRuleFieldIntersectionSettings3.Row = Me.fieldName
            pivotGridFormatRule3.Settings = formatRuleFieldIntersectionSettings3
            pivotGridFormatRule4.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule4.Name = "Format3"
            formatConditionRuleDataBar4.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar4.PredefinedName = "Coral Gradient"
            pivotGridFormatRule4.Rule = formatConditionRuleDataBar4
            formatRuleFieldIntersectionSettings4.Column = Me.fieldSalesYear
            formatRuleFieldIntersectionSettings4.Row = Me.fieldTrademark
            pivotGridFormatRule4.Settings = formatRuleFieldIntersectionSettings4
            pivotGridFormatRule5.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule5.Name = "Format4"
            formatConditionRuleDataBar5.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar5.PredefinedName = "Coral Gradient"
            pivotGridFormatRule5.Rule = formatConditionRuleDataBar5
            formatRuleFieldIntersectionSettings5.Column = Me.fieldSalesMonth
            formatRuleFieldIntersectionSettings5.Row = Me.fieldTrademark
            pivotGridFormatRule5.Settings = formatRuleFieldIntersectionSettings5
            pivotGridFormatRule6.Measure = Me.fieldExtendedPrice
            pivotGridFormatRule6.Name = "Format5"
            formatConditionRuleDataBar6.Appearance.Options.UseBorderColor = True
            formatConditionRuleDataBar6.PredefinedName = "Coral Gradient"
            pivotGridFormatRule6.Rule = formatConditionRuleDataBar6
            formatRuleFieldIntersectionSettings6.Column = Me.fieldSalesDay
            formatRuleFieldIntersectionSettings6.Row = Me.fieldTrademark
            pivotGridFormatRule6.Settings = formatRuleFieldIntersectionSettings6
            Me.pivotGridControl.FormatRules.Add(pivotGridFormatRule1)
            Me.pivotGridControl.FormatRules.Add(pivotGridFormatRule2)
            Me.pivotGridControl.FormatRules.Add(pivotGridFormatRule3)
            Me.pivotGridControl.FormatRules.Add(pivotGridFormatRule4)
            Me.pivotGridControl.FormatRules.Add(pivotGridFormatRule5)
            Me.pivotGridControl.FormatRules.Add(pivotGridFormatRule6)
            pivotGridGroup1.Fields.Add(Me.fieldSalesYear)
            pivotGridGroup1.Fields.Add(Me.fieldSalesMonth)
            pivotGridGroup1.Fields.Add(Me.fieldSalesDay)
            Me.pivotGridControl.Groups.AddRange(New DevExpress.XtraPivotGrid.PivotGridGroup() {pivotGridGroup1})
            Me.pivotGridControl.Location = New System.Drawing.Point(0, 0)
            Me.pivotGridControl.Margin = New System.Windows.Forms.Padding(0)
            Me.pivotGridControl.Name = "pivotGridControl"
            Me.pivotGridControl.OptionsCustomization.AllowDrag = False
            Me.pivotGridControl.OptionsCustomization.AllowDragInCustomizationForm = False
            Me.pivotGridControl.OptionsCustomization.AllowHideFields = DevExpress.XtraPivotGrid.AllowHideFieldsType.Never
            Me.pivotGridControl.OptionsLayout.StoreFormatRules = True
            Me.pivotGridControl.OptionsMenu.EnableFormatRulesMenu = True
            Me.pivotGridControl.OptionsView.AllowHtmlDrawHeaders = True
            Me.pivotGridControl.OptionsView.FilterCriteriaDisplayStyle = DevExpress.XtraEditors.FilterCriteriaDisplayStyle.Visual
            Me.pivotGridControl.Size = New System.Drawing.Size(398, 345)
            Me.pivotGridControl.TabIndex = 7
            AddHandler Me.pivotGridControl.FilterPopupExcelData, New DevExpress.XtraPivotGrid.FilterPopupExcelDataEventHandler(AddressOf Me.OnFilterPopupExcelData)
            ' 
            ' fieldDiscount
            ' 
            Me.fieldDiscount.AreaIndex = 0
            Me.fieldDiscount.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Discount")
            Me.fieldDiscount.Name = "fieldDiscount"
            Me.fieldDiscount.Visible = False
            ' 
            ' fieldCylinders
            ' 
            Me.fieldCylinders.AreaIndex = 0
            Me.fieldCylinders.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Cylinders")
            Me.fieldCylinders.Name = "fieldCylinders"
            Me.fieldCylinders.Visible = False
            ' 
            ' fieldHorsepower
            ' 
            Me.fieldHorsepower.AreaIndex = 0
            Me.fieldHorsepower.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Horsepower")
            Me.fieldHorsepower.Name = "fieldHorsepower"
            Me.fieldHorsepower.Visible = False
            ' 
            ' fieldDoors
            ' 
            Me.fieldDoors.AreaIndex = 1
            Me.fieldDoors.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Doors")
            Me.fieldDoors.Name = "fieldDoors"
            Me.fieldDoors.Visible = False
            ' 
            ' fieldBodyStyle
            ' 
            Me.fieldBodyStyle.AreaIndex = 1
            Me.fieldBodyStyle.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("BodyStyle")
            Me.fieldBodyStyle.Name = "fieldBodyStyle"
            ' 
            ' fieldModification
            ' 
            Me.fieldModification.AreaIndex = 0
            Me.fieldModification.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("Modification")
            Me.fieldModification.Name = "fieldModification"
            ' 
            ' fieldMPGCity
            ' 
            Me.fieldMPGCity.AreaIndex = 4
            Me.fieldMPGCity.Caption = "MPG <b>City"
            Me.fieldMPGCity.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("MPGCity")
            Me.fieldMPGCity.Name = "fieldMPGCity"
            ' 
            ' fieldMPGHighway
            ' 
            Me.fieldMPGHighway.AreaIndex = 5
            Me.fieldMPGHighway.Caption = "MPG <b>Highway"
            Me.fieldMPGHighway.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("MPGHighway")
            Me.fieldMPGHighway.Name = "fieldMPGHighway"
            ' 
            ' fieldSalesDate
            ' 
            Me.fieldSalesDate.AreaIndex = 2
            Me.fieldSalesDate.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("SalesDate", DevExpress.XtraPivotGrid.PivotGroupInterval.[Date])
            Me.fieldSalesDate.Name = "fieldSalesDate"
            Me.fieldSalesDate.UnboundFieldName = "fieldSalesDate"
            ' 
            ' fieldModelPrice
            ' 
            Me.fieldModelPrice.AreaIndex = 3
            Me.fieldModelPrice.DataBinding = New DevExpress.XtraPivotGrid.DataSourceColumnBinding("ModelPrice")
            Me.fieldModelPrice.Name = "fieldModelPrice"
            ' 
            ' accordionControl
            ' 
            Me.accordionControl.Controls.Add(Me.accordionContentContainer15)
            Me.accordionControl.Controls.Add(Me.accordionContentContainer16)
            Me.accordionControl.Controls.Add(Me.accordionContentContainer9)
            Me.accordionControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.accordionControl.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement1})
            Me.accordionControl.ExpandElementMode = DevExpress.XtraBars.Navigation.ExpandElementMode.Multiple
            Me.accordionControl.ExpandGroupOnHeaderClick = False
            Me.accordionControl.ExpandItemOnHeaderClick = False
            Me.accordionControl.Location = New System.Drawing.Point(11, 10)
            Me.accordionControl.Name = "accordionControl"
            Me.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch
            Me.accordionControl.ShowGroupExpandButtons = False
            Me.accordionControl.ShowItemExpandButtons = False
            Me.accordionControl.Size = New System.Drawing.Size(287, 325)
            Me.accordionControl.TabIndex = 9
            Me.accordionControl.Text = "Filters"
            ' 
            ' accordionContentContainer15
            ' 
            Me.accordionContentContainer15.Controls.Add(Me.fieldSalesDateFilterUIEditorContainerEdit)
            Me.accordionContentContainer15.Name = "accordionContentContainer15"
            Me.accordionContentContainer15.Padding = New System.Windows.Forms.Padding(-1)
            Me.accordionContentContainer15.Size = New System.Drawing.Size(270, 40)
            Me.accordionContentContainer15.TabIndex = 15
            ' 
            ' fieldSalesDateFilterUIEditorContainerEdit
            ' 
            Me.fieldSalesDateFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext, "fieldSalesDate", True))
            Me.fieldSalesDateFilterUIEditorContainerEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fieldSalesDateFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1"
            Me.fieldSalesDateFilterUIEditorContainerEdit.Location = New System.Drawing.Point(17, 2)
            Me.fieldSalesDateFilterUIEditorContainerEdit.Name = "fieldSalesDateFilterUIEditorContainerEdit"
            Me.fieldSalesDateFilterUIEditorContainerEdit.Properties.DateTimeRangeOptions.ItemCount = 9
            Me.fieldSalesDateFilterUIEditorContainerEdit.Properties.DateTimeRangeUIEditorType = DevExpress.Utils.Filtering.DateTimeRangeUIEditorType.[Default]
            Me.fieldSalesDateFilterUIEditorContainerEdit.Size = New System.Drawing.Size(245, 22)
            Me.fieldSalesDateFilterUIEditorContainerEdit.TabIndex = 0
            ' 
            ' filteringUIContext
            ' 
            Me.filteringUIContext.Client = Me.pivotGridControl
            Me.filteringUIContext.Control = Me.accordionControl
            ' 
            ' accordionContentContainer16
            ' 
            Me.accordionContentContainer16.Controls.Add(Me.fieldModelPriceFilterUIEditorContainerEdit)
            Me.accordionContentContainer16.Name = "accordionContentContainer16"
            Me.accordionContentContainer16.Padding = New System.Windows.Forms.Padding(-1)
            Me.accordionContentContainer16.Size = New System.Drawing.Size(180, 40)
            Me.accordionContentContainer16.TabIndex = 16
            ' 
            ' fieldModelPriceFilterUIEditorContainerEdit
            ' 
            Me.fieldModelPriceFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext, "fieldModelPrice", True))
            Me.fieldModelPriceFilterUIEditorContainerEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fieldModelPriceFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1"
            Me.fieldModelPriceFilterUIEditorContainerEdit.Location = New System.Drawing.Point(17, 2)
            Me.fieldModelPriceFilterUIEditorContainerEdit.Name = "fieldModelPriceFilterUIEditorContainerEdit"
            Me.fieldModelPriceFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.[Default]
            Me.fieldModelPriceFilterUIEditorContainerEdit.Properties.UseFlags = True
            Me.fieldModelPriceFilterUIEditorContainerEdit.Size = New System.Drawing.Size(155, 22)
            Me.fieldModelPriceFilterUIEditorContainerEdit.TabIndex = 0
            ' 
            ' accordionContentContainer9
            ' 
            Me.accordionContentContainer9.Controls.Add(Me.fieldBodyStyleFilterUIEditorContainerEdit)
            Me.accordionContentContainer9.Name = "accordionContentContainer9"
            Me.accordionContentContainer9.Padding = New System.Windows.Forms.Padding(-1)
            Me.accordionContentContainer9.Size = New System.Drawing.Size(180, 40)
            Me.accordionContentContainer9.TabIndex = 9
            ' 
            ' fieldBodyStyleFilterUIEditorContainerEdit
            ' 
            Me.fieldBodyStyleFilterUIEditorContainerEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", Me.filteringUIContext, "fieldBodyStyle", True))
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Dock = System.Windows.Forms.DockStyle.Fill
            Me.fieldBodyStyleFilterUIEditorContainerEdit.EditValue = "filterUIEditorContainerEdit1"
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Location = New System.Drawing.Point(17, 2)
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Name = "fieldBodyStyleFilterUIEditorContainerEdit"
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Properties.LookupOptions.ItemCount = 9
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Properties.LookupUIEditorType = DevExpress.Utils.Filtering.LookupUIEditorType.[Default]
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Properties.UseFlags = True
            Me.fieldBodyStyleFilterUIEditorContainerEdit.Size = New System.Drawing.Size(155, 22)
            Me.fieldBodyStyleFilterUIEditorContainerEdit.TabIndex = 0
            ' 
            ' accordionControlElement1
            ' 
            Me.accordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.accordionControlElement17, Me.accordionControlElement10, Me.accordionControlElement16})
            Me.accordionControlElement1.Expanded = True
            Me.accordionControlElement1.HeaderVisible = False
            Me.accordionControlElement1.Name = "accordionControlElement1"
            ' 
            ' accordionControlElement17
            ' 
            Me.accordionControlElement17.ContentContainer = Me.accordionContentContainer16
            Me.accordionControlElement17.Expanded = True
            Me.accordionControlElement17.Name = "accordionControlElement17"
            Me.accordionControlElement17.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement17.Text = "Model Price"
            ' 
            ' accordionControlElement10
            ' 
            Me.accordionControlElement10.ContentContainer = Me.accordionContentContainer9
            Me.accordionControlElement10.Expanded = True
            Me.accordionControlElement10.Name = "accordionControlElement10"
            Me.accordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement10.Text = "Body Style"
            ' 
            ' accordionControlElement16
            ' 
            Me.accordionControlElement16.ContentContainer = Me.accordionContentContainer15
            Me.accordionControlElement16.Expanded = True
            Me.accordionControlElement16.Name = "accordionControlElement16"
            Me.accordionControlElement16.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
            Me.accordionControlElement16.Text = "Sales Date"
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.AllowResize = False
            Me.sidePanel1.Controls.Add(Me.accordionControl)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right
            Me.sidePanel1.Location = New System.Drawing.Point(398, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Padding = New System.Windows.Forms.Padding(10, 10, 10, 10)
            Me.sidePanel1.Size = New System.Drawing.Size(308, 345)
            Me.sidePanel1.TabIndex = 12
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' ExcelStyleFilter
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.pivotGridControl)
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "ExcelStyleFilter"
            Me.Size = New System.Drawing.Size(706, 345)
            CType((Me.pivotGridControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.accordionControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionControl.ResumeLayout(False)
            Me.accordionContentContainer15.ResumeLayout(False)
            CType((Me.fieldSalesDateFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.filteringUIContext), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionContentContainer16.ResumeLayout(False)
            CType((Me.fieldModelPriceFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.accordionContentContainer9.ResumeLayout(False)
            CType((Me.fieldBodyStyleFilterUIEditorContainerEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private pivotGridControl As DevExpress.XtraPivotGrid.PivotGridControl

        Private fieldTrademark As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesYear As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldName As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldExtendedPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDiscount As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldCylinders As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldHorsepower As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldDoors As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldBodyStyle As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesMonth As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesDay As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldModification As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMPGCity As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldMPGHighway As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldSalesDate As DevExpress.XtraPivotGrid.PivotGridField

        Private fieldModelPrice As DevExpress.XtraPivotGrid.PivotGridField

        Private filteringUIContext As DevExpress.Utils.Filtering.FilteringUIContext

        Private accordionControl As DevExpress.XtraBars.Navigation.AccordionControl

        Private accordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionContentContainer15 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private fieldSalesDateFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit

        Private accordionContentContainer16 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private fieldModelPriceFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit

        Private accordionContentContainer9 As DevExpress.XtraBars.Navigation.AccordionContentContainer

        Private fieldBodyStyleFilterUIEditorContainerEdit As DevExpress.XtraEditors.Filtering.FilterUIEditorContainerEdit

        Private accordionControlElement17 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement10 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private accordionControlElement16 As DevExpress.XtraBars.Navigation.AccordionControlElement

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel
    End Class
End Namespace
