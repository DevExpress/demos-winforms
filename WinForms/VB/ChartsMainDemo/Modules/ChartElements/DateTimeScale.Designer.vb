Namespace DevExpress.XtraCharts.Demos

    Partial Class DateTimeScaleDemo

        Private components As System.ComponentModel.IContainer = Nothing

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stockSeriesView1 As DevExpress.XtraCharts.StockSeriesView = New DevExpress.XtraCharts.StockSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEditScaleMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditMeasureUnit = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkEditAutoGrid = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditGridAlignment = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditMeasureUnitFactor = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditMinorTickMarksCount = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditGridSpacing = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditAggregateFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditGridOffset = New DevExpress.XtraEditors.SpinEdit()
            Me.radioGroupView = New DevExpress.XtraEditors.RadioGroup()
            Me.spinEditStartHour = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditEndHour = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditExcludeWeekends = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditExcludeHolidays = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditWorkTimeOnly = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupScale = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemAggregateFunction = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMeasureUnitFactor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMeasureUnit = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemScaleMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGrid = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemGridSpacing = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemGridAlignment = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAutoGrid = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMinorTickMarksCount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemGridOffset = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupView = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemView = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupWorkTimeOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemStartWorkHour = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemEndWorkHour = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemExcludeWeekends = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemExcludeHolidays = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemWorkTimeOnly = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.comboBoxEditScaleMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditMeasureUnit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAutoGrid.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditGridAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMeasureUnitFactor.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMinorTickMarksCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditGridSpacing.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditAggregateFunction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditGridOffset.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupView.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditStartHour.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditEndHour.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditExcludeWeekends.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditExcludeHolidays.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupScale), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAggregateFunction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMeasureUnitFactor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMeasureUnit), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemScaleMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemGridSpacing), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemGridAlignment), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAutoGrid), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMinorTickMarksCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemGridOffset), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupWorkTimeOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemStartWorkHour), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemEndWorkHour), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemExcludeWeekends), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemExcludeHolidays), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemWorkTimeOnly), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.comboBoxEditScaleMode)
            Me.layoutControl.Controls.Add(Me.comboBoxEditMeasureUnit)
            Me.layoutControl.Controls.Add(Me.checkEditAutoGrid)
            Me.layoutControl.Controls.Add(Me.comboBoxEditGridAlignment)
            Me.layoutControl.Controls.Add(Me.spinEditMeasureUnitFactor)
            Me.layoutControl.Controls.Add(Me.spinEditMinorTickMarksCount)
            Me.layoutControl.Controls.Add(Me.spinEditGridSpacing)
            Me.layoutControl.Controls.Add(Me.comboBoxEditAggregateFunction)
            Me.layoutControl.Controls.Add(Me.spinEditGridOffset)
            Me.layoutControl.Controls.Add(Me.radioGroupView)
            Me.layoutControl.Controls.Add(Me.spinEditStartHour)
            Me.layoutControl.Controls.Add(Me.spinEditEndHour)
            Me.layoutControl.Controls.Add(Me.checkEditExcludeWeekends)
            Me.layoutControl.Controls.Add(Me.checkEditExcludeHolidays)
            Me.layoutControl.Controls.Add(Me.checkEditWorkTimeOnly)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(605, 330, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' comboBoxEditScaleMode
            ' 
            Me.comboBoxEditScaleMode.Location = New System.Drawing.Point(126, 112)
            Me.comboBoxEditScaleMode.Name = "comboBoxEditScaleMode"
            Me.comboBoxEditScaleMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditScaleMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditScaleMode.Size = New System.Drawing.Size(103, 20)
            Me.comboBoxEditScaleMode.StyleController = Me.layoutControl
            Me.comboBoxEditScaleMode.TabIndex = 4
            AddHandler Me.comboBoxEditScaleMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditScaleMode_SelectedIndexChanged)
            ' 
            ' comboBoxEditMeasureUnit
            ' 
            Me.comboBoxEditMeasureUnit.Location = New System.Drawing.Point(126, 136)
            Me.comboBoxEditMeasureUnit.Name = "comboBoxEditMeasureUnit"
            Me.comboBoxEditMeasureUnit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMeasureUnit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMeasureUnit.Size = New System.Drawing.Size(103, 20)
            Me.comboBoxEditMeasureUnit.StyleController = Me.layoutControl
            Me.comboBoxEditMeasureUnit.TabIndex = 5
            AddHandler Me.comboBoxEditMeasureUnit.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditMeasureUnit_SelectedIndexChanged)
            ' 
            ' checkEditAutoGrid
            ' 
            Me.checkEditAutoGrid.Location = New System.Drawing.Point(12, 247)
            Me.checkEditAutoGrid.Name = "checkEditAutoGrid"
            Me.checkEditAutoGrid.Properties.Caption = "Auto Grid"
            Me.checkEditAutoGrid.Size = New System.Drawing.Size(217, 19)
            Me.checkEditAutoGrid.StyleController = Me.layoutControl
            Me.checkEditAutoGrid.TabIndex = 6
            AddHandler Me.checkEditAutoGrid.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAutoGrid_CheckedChanged)
            ' 
            ' comboBoxEditGridAlignment
            ' 
            Me.comboBoxEditGridAlignment.Location = New System.Drawing.Point(126, 270)
            Me.comboBoxEditGridAlignment.Name = "comboBoxEditGridAlignment"
            Me.comboBoxEditGridAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditGridAlignment.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditGridAlignment.Size = New System.Drawing.Size(103, 20)
            Me.comboBoxEditGridAlignment.StyleController = Me.layoutControl
            Me.comboBoxEditGridAlignment.TabIndex = 7
            AddHandler Me.comboBoxEditGridAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditGridAlignment_SelectedIndexChanged)
            ' 
            ' spinEditMeasureUnitFactor
            ' 
            Me.spinEditMeasureUnitFactor.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMeasureUnitFactor.Location = New System.Drawing.Point(126, 160)
            Me.spinEditMeasureUnitFactor.Name = "spinEditMeasureUnitFactor"
            Me.spinEditMeasureUnitFactor.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMeasureUnitFactor.Properties.IsFloatValue = False
            Me.spinEditMeasureUnitFactor.Properties.Mask.EditMask = "N00"
            Me.spinEditMeasureUnitFactor.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinEditMeasureUnitFactor.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMeasureUnitFactor.Size = New System.Drawing.Size(103, 20)
            Me.spinEditMeasureUnitFactor.StyleController = Me.layoutControl
            Me.spinEditMeasureUnitFactor.TabIndex = 9
            AddHandler Me.spinEditMeasureUnitFactor.ValueChanged, New System.EventHandler(AddressOf Me.spinEditMeasureUnitFactor_ValueChanged)
            ' 
            ' spinEditMinorTickMarksCount
            ' 
            Me.spinEditMinorTickMarksCount.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMinorTickMarksCount.Location = New System.Drawing.Point(126, 342)
            Me.spinEditMinorTickMarksCount.Name = "spinEditMinorTickMarksCount"
            Me.spinEditMinorTickMarksCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMinorTickMarksCount.Properties.IsFloatValue = False
            Me.spinEditMinorTickMarksCount.Properties.Mask.EditMask = "N00"
            Me.spinEditMinorTickMarksCount.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinEditMinorTickMarksCount.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMinorTickMarksCount.Size = New System.Drawing.Size(103, 20)
            Me.spinEditMinorTickMarksCount.StyleController = Me.layoutControl
            Me.spinEditMinorTickMarksCount.TabIndex = 10
            AddHandler Me.spinEditMinorTickMarksCount.ValueChanged, New System.EventHandler(AddressOf Me.spinEditMinorTickMarksCount_ValueChanged)
            ' 
            ' spinEditGridSpacing
            ' 
            Me.spinEditGridSpacing.EditValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.spinEditGridSpacing.Location = New System.Drawing.Point(126, 294)
            Me.spinEditGridSpacing.Name = "spinEditGridSpacing"
            Me.spinEditGridSpacing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditGridSpacing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditGridSpacing.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEditGridSpacing.Properties.IsFloatValue = False
            Me.spinEditGridSpacing.Properties.Mask.EditMask = "N00"
            Me.spinEditGridSpacing.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinEditGridSpacing.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinEditGridSpacing.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditGridSpacing.Size = New System.Drawing.Size(103, 20)
            Me.spinEditGridSpacing.StyleController = Me.layoutControl
            Me.spinEditGridSpacing.TabIndex = 8
            AddHandler Me.spinEditGridSpacing.ValueChanged, New System.EventHandler(AddressOf Me.spinEditGridSpacing_ValueChanged)
            ' 
            ' comboBoxEditAggregateFunction
            ' 
            Me.comboBoxEditAggregateFunction.Location = New System.Drawing.Point(126, 184)
            Me.comboBoxEditAggregateFunction.Name = "comboBoxEditAggregateFunction"
            Me.comboBoxEditAggregateFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditAggregateFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditAggregateFunction.Size = New System.Drawing.Size(103, 20)
            Me.comboBoxEditAggregateFunction.StyleController = Me.layoutControl
            Me.comboBoxEditAggregateFunction.TabIndex = 11
            AddHandler Me.comboBoxEditAggregateFunction.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditAggregateFunction_SelectedIndexChanged)
            ' 
            ' spinEditGridOffset
            ' 
            Me.spinEditGridOffset.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditGridOffset.Location = New System.Drawing.Point(126, 318)
            Me.spinEditGridOffset.Name = "spinEditGridOffset"
            Me.spinEditGridOffset.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditGridOffset.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditGridOffset.Properties.IsFloatValue = False
            Me.spinEditGridOffset.Properties.Mask.EditMask = "N00"
            Me.spinEditGridOffset.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.spinEditGridOffset.Properties.MinValue = New Decimal(New Integer() {50, 0, 0, -2147483648})
            Me.spinEditGridOffset.Size = New System.Drawing.Size(103, 20)
            Me.spinEditGridOffset.StyleController = Me.layoutControl
            Me.spinEditGridOffset.TabIndex = 12
            AddHandler Me.spinEditGridOffset.ValueChanged, New System.EventHandler(AddressOf Me.spinEditGridOffset_ValueChanged)
            ' 
            ' radioGroupView
            ' 
            Me.radioGroupView.AutoSizeInLayoutControl = True
            Me.radioGroupView.Location = New System.Drawing.Point(12, 31)
            Me.radioGroupView.Name = "radioGroupView"
            Me.radioGroupView.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupView.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupView.Properties.Columns = 1
            Me.radioGroupView.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Price"), New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Sales Volume")})
            Me.radioGroupView.Size = New System.Drawing.Size(217, 38)
            Me.radioGroupView.TabIndex = 13
            AddHandler Me.radioGroupView.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupView_SelectedIndexChanged)
            ' 
            ' spinEditStartHour
            ' 
            Me.spinEditStartHour.EditValue = New Decimal(New Integer() {8, 0, 0, 0})
            Me.spinEditStartHour.Location = New System.Drawing.Point(126, 428)
            Me.spinEditStartHour.Name = "spinEditStartHour"
            Me.spinEditStartHour.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditStartHour.Properties.DisplayFormat.FormatString = "0:\0\0"
            Me.spinEditStartHour.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditStartHour.Properties.IsFloatValue = False
            Me.spinEditStartHour.Properties.Mask.EditMask = "N00"
            Me.spinEditStartHour.Properties.MaxValue = New Decimal(New Integer() {11, 0, 0, 0})
            Me.spinEditStartHour.Size = New System.Drawing.Size(103, 20)
            Me.spinEditStartHour.StyleController = Me.layoutControl
            Me.spinEditStartHour.TabIndex = 14
            AddHandler Me.spinEditStartHour.ValueChanged, New System.EventHandler(AddressOf Me.spinEditStartHour_ValueChanged)
            ' 
            ' spinEditEndHour
            ' 
            Me.spinEditEndHour.EditValue = New Decimal(New Integer() {18, 0, 0, 0})
            Me.spinEditEndHour.Location = New System.Drawing.Point(126, 452)
            Me.spinEditEndHour.Name = "spinEditEndHour"
            Me.spinEditEndHour.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditEndHour.Properties.DisplayFormat.FormatString = "0:\0\0"
            Me.spinEditEndHour.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditEndHour.Properties.IsFloatValue = False
            Me.spinEditEndHour.Properties.Mask.EditMask = "N00"
            Me.spinEditEndHour.Properties.MaxValue = New Decimal(New Integer() {23, 0, 0, 0})
            Me.spinEditEndHour.Properties.MinValue = New Decimal(New Integer() {12, 0, 0, 0})
            Me.spinEditEndHour.Size = New System.Drawing.Size(103, 20)
            Me.spinEditEndHour.StyleController = Me.layoutControl
            Me.spinEditEndHour.TabIndex = 15
            AddHandler Me.spinEditEndHour.ValueChanged, New System.EventHandler(AddressOf Me.spinEditEndHour_ValueChanged)
            ' 
            ' checkEditExcludeWeekends
            ' 
            Me.checkEditExcludeWeekends.Location = New System.Drawing.Point(12, 476)
            Me.checkEditExcludeWeekends.Name = "checkEditExcludeWeekends"
            Me.checkEditExcludeWeekends.Properties.Caption = "Exclude Weekends"
            Me.checkEditExcludeWeekends.Size = New System.Drawing.Size(217, 19)
            Me.checkEditExcludeWeekends.StyleController = Me.layoutControl
            Me.checkEditExcludeWeekends.TabIndex = 16
            AddHandler Me.checkEditExcludeWeekends.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditExcludeWeekends_CheckedChanged)
            ' 
            ' checkEditExcludeHolidays
            ' 
            Me.checkEditExcludeHolidays.Location = New System.Drawing.Point(12, 499)
            Me.checkEditExcludeHolidays.Name = "checkEditExcludeHolidays"
            Me.checkEditExcludeHolidays.Properties.Caption = "Exclude Holidays"
            Me.checkEditExcludeHolidays.Size = New System.Drawing.Size(217, 19)
            Me.checkEditExcludeHolidays.StyleController = Me.layoutControl
            Me.checkEditExcludeHolidays.TabIndex = 17
            Me.checkEditExcludeHolidays.ToolTip = "Exclude 1 May and 1 January"
            AddHandler Me.checkEditExcludeHolidays.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditExcludeHolidays_CheckedChanged)
            ' 
            ' checkEditWorkTimeOnly
            ' 
            Me.checkEditWorkTimeOnly.Location = New System.Drawing.Point(12, 405)
            Me.checkEditWorkTimeOnly.Name = "checkEditWorkTimeOnly"
            Me.checkEditWorkTimeOnly.Properties.Caption = "Work Time Only"
            Me.checkEditWorkTimeOnly.Size = New System.Drawing.Size(217, 19)
            Me.checkEditWorkTimeOnly.StyleController = Me.layoutControl
            Me.checkEditWorkTimeOnly.TabIndex = 18
            AddHandler Me.checkEditWorkTimeOnly.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditWorkTimeOnly_CheckedChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupScale, Me.layoutControlGroupGrid, Me.emptySpaceItem, Me.layoutControlGroupView, Me.layoutControlGroupWorkTimeOptions})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupScale
            ' 
            Me.layoutControlGroupScale.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupScale.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemAggregateFunction, Me.layoutControlItemMeasureUnitFactor, Me.layoutControlItemMeasureUnit, Me.layoutControlItemScaleMode})
            Me.layoutControlGroupScale.Location = New System.Drawing.Point(0, 81)
            Me.layoutControlGroupScale.Name = "layoutControlGroupScale"
            Me.layoutControlGroupScale.Size = New System.Drawing.Size(241, 135)
            Me.layoutControlGroupScale.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupScale.Text = "Scale"
            ' 
            ' layoutControlItemAggregateFunction
            ' 
            Me.layoutControlItemAggregateFunction.Control = Me.comboBoxEditAggregateFunction
            Me.layoutControlItemAggregateFunction.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemAggregateFunction.Name = "layoutControlItemAggregateFunction"
            Me.layoutControlItemAggregateFunction.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAggregateFunction.Text = "Aggregate Function:"
            Me.layoutControlItemAggregateFunction.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemMeasureUnitFactor
            ' 
            Me.layoutControlItemMeasureUnitFactor.Control = Me.spinEditMeasureUnitFactor
            Me.layoutControlItemMeasureUnitFactor.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemMeasureUnitFactor.Name = "layoutControlItemMeasureUnitFactor"
            Me.layoutControlItemMeasureUnitFactor.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMeasureUnitFactor.Text = "Unit Multiplier:"
            Me.layoutControlItemMeasureUnitFactor.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemMeasureUnit
            ' 
            Me.layoutControlItemMeasureUnit.Control = Me.comboBoxEditMeasureUnit
            Me.layoutControlItemMeasureUnit.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemMeasureUnit.Name = "layoutControlItemMeasureUnit"
            Me.layoutControlItemMeasureUnit.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMeasureUnit.Text = "Measurement Unit: "
            Me.layoutControlItemMeasureUnit.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemScaleMode
            ' 
            Me.layoutControlItemScaleMode.Control = Me.comboBoxEditScaleMode
            Me.layoutControlItemScaleMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemScaleMode.Name = "layoutControlItemScaleMode"
            Me.layoutControlItemScaleMode.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemScaleMode.Text = "Scale Mode:"
            Me.layoutControlItemScaleMode.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlGroupGrid
            ' 
            Me.layoutControlGroupGrid.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGrid.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemGridSpacing, Me.layoutControlItemGridAlignment, Me.layoutControlItemAutoGrid, Me.layoutControlItemMinorTickMarksCount, Me.layoutControlItemGridOffset})
            Me.layoutControlGroupGrid.Location = New System.Drawing.Point(0, 216)
            Me.layoutControlGroupGrid.Name = "layoutControlGroupGrid"
            Me.layoutControlGroupGrid.Size = New System.Drawing.Size(241, 158)
            Me.layoutControlGroupGrid.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGrid.Text = "Grid"
            ' 
            ' layoutControlItemGridSpacing
            ' 
            Me.layoutControlItemGridSpacing.Control = Me.spinEditGridSpacing
            Me.layoutControlItemGridSpacing.Location = New System.Drawing.Point(0, 47)
            Me.layoutControlItemGridSpacing.Name = "layoutControlItemGridSpacing"
            Me.layoutControlItemGridSpacing.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemGridSpacing.Text = "Grid Spacing:"
            Me.layoutControlItemGridSpacing.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemGridAlignment
            ' 
            Me.layoutControlItemGridAlignment.Control = Me.comboBoxEditGridAlignment
            Me.layoutControlItemGridAlignment.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItemGridAlignment.Name = "layoutControlItemGridAlignment"
            Me.layoutControlItemGridAlignment.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemGridAlignment.Text = "Grid Alignment:"
            Me.layoutControlItemGridAlignment.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemAutoGrid
            ' 
            Me.layoutControlItemAutoGrid.Control = Me.checkEditAutoGrid
            Me.layoutControlItemAutoGrid.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemAutoGrid.Name = "layoutControlItemAutoGrid"
            Me.layoutControlItemAutoGrid.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemAutoGrid.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemAutoGrid.TextVisible = False
            ' 
            ' layoutControlItemMinorTickMarksCount
            ' 
            Me.layoutControlItemMinorTickMarksCount.Control = Me.spinEditMinorTickMarksCount
            Me.layoutControlItemMinorTickMarksCount.Location = New System.Drawing.Point(0, 95)
            Me.layoutControlItemMinorTickMarksCount.Name = "layoutControlItemMinorTickMarksCount"
            Me.layoutControlItemMinorTickMarksCount.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMinorTickMarksCount.Text = "Minor Tickmarks Count:"
            Me.layoutControlItemMinorTickMarksCount.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemGridOffset
            ' 
            Me.layoutControlItemGridOffset.Control = Me.spinEditGridOffset
            Me.layoutControlItemGridOffset.Location = New System.Drawing.Point(0, 71)
            Me.layoutControlItemGridOffset.Name = "layoutControlItemGridOffset"
            Me.layoutControlItemGridOffset.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemGridOffset.Text = "Grid Offset:"
            Me.layoutControlItemGridOffset.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 530)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 14)
            Me.emptySpaceItem.Text = "emptySpaceItemBottom"
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupView
            ' 
            Me.layoutControlGroupView.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupView.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemView})
            Me.layoutControlGroupView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupView.Name = "layoutControlGroupView"
            Me.layoutControlGroupView.Size = New System.Drawing.Size(241, 81)
            Me.layoutControlGroupView.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupView.Text = "View"
            ' 
            ' layoutControlItemView
            ' 
            Me.layoutControlItemView.Control = Me.radioGroupView
            Me.layoutControlItemView.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemView.Name = "layoutControlItemView"
            Me.layoutControlItemView.Size = New System.Drawing.Size(221, 42)
            Me.layoutControlItemView.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemView.TextVisible = False
            ' 
            ' layoutControlGroupWorkTimeOptions
            ' 
            Me.layoutControlGroupWorkTimeOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupWorkTimeOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemStartWorkHour, Me.layoutControlItemEndWorkHour, Me.layoutControlItemExcludeWeekends, Me.layoutControlItemExcludeHolidays, Me.layoutControlItemWorkTimeOnly})
            Me.layoutControlGroupWorkTimeOptions.Location = New System.Drawing.Point(0, 374)
            Me.layoutControlGroupWorkTimeOptions.Name = "layoutControlGroupWorkTimeOptions"
            Me.layoutControlGroupWorkTimeOptions.Size = New System.Drawing.Size(241, 156)
            Me.layoutControlGroupWorkTimeOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupWorkTimeOptions.Text = "Work Time Options"
            ' 
            ' layoutControlItemStartWorkHour
            ' 
            Me.layoutControlItemStartWorkHour.Control = Me.spinEditStartHour
            Me.layoutControlItemStartWorkHour.Location = New System.Drawing.Point(0, 23)
            Me.layoutControlItemStartWorkHour.Name = "layoutControlItemStartWorkHour"
            Me.layoutControlItemStartWorkHour.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemStartWorkHour.Text = "Start Work Hour:"
            Me.layoutControlItemStartWorkHour.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemEndWorkHour
            ' 
            Me.layoutControlItemEndWorkHour.Control = Me.spinEditEndHour
            Me.layoutControlItemEndWorkHour.Location = New System.Drawing.Point(0, 47)
            Me.layoutControlItemEndWorkHour.Name = "layoutControlItemEndWorkHour"
            Me.layoutControlItemEndWorkHour.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemEndWorkHour.Text = "End Work Hour:"
            Me.layoutControlItemEndWorkHour.TextSize = New System.Drawing.Size(111, 13)
            ' 
            ' layoutControlItemExcludeWeekends
            ' 
            Me.layoutControlItemExcludeWeekends.Control = Me.checkEditExcludeWeekends
            Me.layoutControlItemExcludeWeekends.Location = New System.Drawing.Point(0, 71)
            Me.layoutControlItemExcludeWeekends.Name = "layoutControlItemExcludeWeekends"
            Me.layoutControlItemExcludeWeekends.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemExcludeWeekends.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemExcludeWeekends.TextVisible = False
            ' 
            ' layoutControlItemExcludeHolidays
            ' 
            Me.layoutControlItemExcludeHolidays.Control = Me.checkEditExcludeHolidays
            Me.layoutControlItemExcludeHolidays.Location = New System.Drawing.Point(0, 94)
            Me.layoutControlItemExcludeHolidays.Name = "layoutControlItemExcludeHolidays"
            Me.layoutControlItemExcludeHolidays.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemExcludeHolidays.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemExcludeHolidays.TextVisible = False
            ' 
            ' layoutControlItemWorkTimeOnly
            ' 
            Me.layoutControlItemWorkTimeOnly.Control = Me.checkEditWorkTimeOnly
            Me.layoutControlItemWorkTimeOnly.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemWorkTimeOnly.Name = "layoutControlItemWorkTimeOnly"
            Me.layoutControlItemWorkTimeOnly.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemWorkTimeOnly.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemWorkTimeOnly.TextVisible = False
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "{A: g}"
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.MinorCount = 3
            xyDiagram1.AxisX.Title.Text = "Date"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V:0.##}"
            xyDiagram1.AxisY.Title.Text = "United States Dollars"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.ZoomingOptions.AxisXMaxZoomPercent = 50000R
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.CrosshairLabelPattern = "${V:0,.}K"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "Sales Volume"
            series2.CrosshairLabelPattern = "Open: ${OV:0.00}" & Global.Microsoft.VisualBasic.Constants.vbLf & "High: ${HV:0.00}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Low: ${LV:0.00}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Close: ${CV:0.00}"
            series2.Name = "Price"
            series2.View = stockSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 2
            Me.chart.TabStop = False
            chartTitle1.Text = "Orders"
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chart.AxisScaleChanged, New System.EventHandler(Of DevExpress.XtraCharts.AxisScaleChangedEventArgs)(AddressOf Me.chart_AxisScaleChanged)
            ' 
            ' DateTimeScaleDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "DateTimeScaleDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.comboBoxEditScaleMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditMeasureUnit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAutoGrid.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditGridAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMeasureUnitFactor.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMinorTickMarksCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditGridSpacing.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditAggregateFunction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditGridOffset.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupView.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditStartHour.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditEndHour.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditExcludeWeekends.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditExcludeHolidays.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditWorkTimeOnly.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupScale), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAggregateFunction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMeasureUnitFactor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMeasureUnit), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemScaleMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemGridSpacing), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemGridAlignment), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAutoGrid), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMinorTickMarksCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemGridOffset), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupWorkTimeOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemStartWorkHour), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemEndWorkHour), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemExcludeWeekends), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemExcludeHolidays), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemWorkTimeOnly), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private chart As DevExpress.XtraCharts.ChartControl

        Private comboBoxEditScaleMode As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditMeasureUnit As DevExpress.XtraEditors.ComboBoxEdit

        Private checkEditAutoGrid As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditGridAlignment As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemScaleMode As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMeasureUnit As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAutoGrid As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemGridAlignment As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemGridSpacing As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditMeasureUnitFactor As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemMeasureUnitFactor As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditMinorTickMarksCount As DevExpress.XtraEditors.SpinEdit

        Private spinEditGridSpacing As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemMinorTickMarksCount As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditAggregateFunction As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupScale As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemAggregateFunction As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGrid As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private spinEditGridOffset As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemGridOffset As DevExpress.XtraLayout.LayoutControlItem

        Private radioGroupView As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupView As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemView As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditStartHour As DevExpress.XtraEditors.SpinEdit

        Private spinEditEndHour As DevExpress.XtraEditors.SpinEdit

        Private checkEditExcludeWeekends As DevExpress.XtraEditors.CheckEdit

        Private checkEditExcludeHolidays As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupWorkTimeOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemStartWorkHour As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemEndWorkHour As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemExcludeWeekends As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemExcludeHolidays As DevExpress.XtraLayout.LayoutControlItem

        Private checkEditWorkTimeOnly As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItemWorkTimeOnly As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
