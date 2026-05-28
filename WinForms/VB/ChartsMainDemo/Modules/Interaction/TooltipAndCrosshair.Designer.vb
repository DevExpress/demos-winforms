Namespace DevExpress.XtraCharts.Demos

    Partial Class TooltipAndCrosshairDemo

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then Me.components.Dispose()
            ' 				if (toolTipFreePosition != null)
            ' toolTipFreePosition.Dispose();
            ' if (toolTipMousePosition != null)
            ' toolTipMousePosition.Dispose();
            ' if (toolTipRelativePosition != null)
            ' toolTipRelativePosition.Dispose();
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim pieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim splineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.chartBar = New DevExpress.XtraCharts.ChartControl()
            Me.barChartToolTipController = New DevExpress.Utils.ToolTipController(Me.components)
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanel2 = New DevExpress.XtraEditors.SidePanel()
            Me.chartSpline = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.comboBoxEditTooltipPosition = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBOxEditShowArgumentLine = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditShowAxisXValues = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditShowLabel = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditShowValueLine = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditShowAxisYValues = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditTooltipType = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditShowContentIn = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditLabelMode = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lcgCommonOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciTooltipPosition = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciTooltipType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lcgLabelOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciShowLabel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciContentShowMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciLabelMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chartBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            Me.sidePanel2.SuspendLayout()
            CType((Me.chartSpline), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.comboBoxEditTooltipPosition.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBOxEditShowArgumentLine.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditShowAxisXValues.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowLabel.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditShowValueLine.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditShowAxisYValues.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditTooltipType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditShowContentIn.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditLabelMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgCommonOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTooltipPosition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciTooltipType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lcgLabelOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciShowLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciContentShowMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciLabelMode), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' chartBar
            ' 
            Me.chartBar.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartBar.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Title.Text = "Sale Volume (USD)"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chartBar.Diagram = xyDiagram1
            Me.chartBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartBar.Legend.Name = "Default Legend"
            Me.chartBar.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartBar.Location = New System.Drawing.Point(0, 0)
            Me.chartBar.Name = "chartBar"
            Me.chartBar.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.[Single]
            Me.chartBar.SeriesDataMember = "Category"
            Me.chartBar.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            series1.ArgumentDataMember = "Category"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series1.LegendName = "Default Legend"
            series1.Name = "Series 1"
            series1.SeriesPointsSorting = DevExpress.XtraCharts.SortingMode.Ascending
            series1.SeriesPointsSortingKey = DevExpress.XtraCharts.SeriesPointKey.Value_1
            series1.ValueDataMembersSerializable = "TotalIncome"
            sideBySideBarSeriesView1.ColorEach = True
            series1.View = sideBySideBarSeriesView1
            Me.chartBar.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Radial
            Me.chartBar.SeriesTemplate.Label = pieSeriesLabel1
            Me.chartBar.SeriesTemplate.LegendTextPattern = "{A}1111"
            Me.chartBar.SeriesTemplate.SeriesDataMember = "Category"
            Me.chartBar.SeriesTemplate.View = pieSeriesView1
            Me.chartBar.SeriesTemplate.Visible = False
            Me.chartBar.Size = New System.Drawing.Size(546, 292)
            Me.chartBar.TabIndex = 1
            Me.chartBar.TabStop = False
            chartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            chartTitle1.Text = "Annual Income (Thousands of USD)"
            Me.chartBar.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            Me.chartBar.ToolTipController = Me.barChartToolTipController
            Me.chartBar.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            AddHandler Me.chartBar.ObjectSelected, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chartBar_ObjectSelected)
            AddHandler Me.chartBar.SelectedItemsChanged, New DevExpress.XtraCharts.SelectedItemsChangedEventHandler(AddressOf Me.barChart_SelectedItemsChanged)
            AddHandler Me.chartBar.ObjectHotTracked, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chartBar_ObjectHotTracked)
            AddHandler Me.chartBar.Click, New System.EventHandler(AddressOf Me.OnChartClick)
            ' 
            ' barChartToolTipController
            ' 
            Me.barChartToolTipController.InitialDelay = 100
            AddHandler Me.barChartToolTipController.BeforeShow, New DevExpress.Utils.ToolTipControllerBeforeShowEventHandler(AddressOf Me.barChartToolTipController_BeforeShow)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.chartBar)
            Me.sidePanel1.Controls.Add(Me.sidePanel2)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 2
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' sidePanel2
            ' 
            Me.sidePanel2.Controls.Add(Me.chartSpline)
            Me.sidePanel2.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanel2.Location = New System.Drawing.Point(0, 292)
            Me.sidePanel2.Name = "sidePanel2"
            Me.sidePanel2.Size = New System.Drawing.Size(546, 279)
            Me.sidePanel2.TabIndex = 0
            Me.sidePanel2.Text = "sidePanel2"
            ' 
            ' chartSpline
            ' 
            Me.chartSpline.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartSpline.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries
            Me.chartSpline.CrosshairOptions.GroupHeaderPattern = "<b>{A:MMMM}</b>"
            Me.chartSpline.CrosshairOptions.HighlightPoints = False
            Me.chartSpline.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            xyDiagram2.AxisX.Tickmarks.MinorVisible = False
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram2.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:0.}"
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            Me.chartSpline.Diagram = xyDiagram2
            Me.chartSpline.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartSpline.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartSpline.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartSpline.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartSpline.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartSpline.Legend.CrosshairContentOffset = 0
            Me.chartSpline.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartSpline.Legend.HorizontalIndent = 15
            Me.chartSpline.Legend.MaxCrosshairContentWidth = 30
            Me.chartSpline.Legend.Name = "Default Legend"
            Me.chartSpline.Location = New System.Drawing.Point(0, 1)
            Me.chartSpline.Name = "chartSpline"
            Me.chartSpline.SeriesDataMember = "Product"
            Me.chartSpline.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartSpline.SeriesTemplate.ArgumentDataMember = "OrderDate"
            Me.chartSpline.SeriesTemplate.SeriesDataMember = "Product"
            Me.chartSpline.SeriesTemplate.ValueDataMembersSerializable = "Income"
            Me.chartSpline.SeriesTemplate.View = splineSeriesView1
            Me.chartSpline.Size = New System.Drawing.Size(546, 278)
            Me.chartSpline.TabIndex = 0
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 14F)
            chartTitle2.Text = "Income Dynamics (Thousands of USD)"
            Me.chartSpline.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            AddHandler Me.chartSpline.Click, New System.EventHandler(AddressOf Me.OnChartClick)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.comboBoxEditTooltipPosition)
            Me.layoutControl1.Controls.Add(Me.comboBOxEditShowArgumentLine)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditShowAxisXValues)
            Me.layoutControl1.Controls.Add(Me.checkEditShowLabel)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditShowValueLine)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditShowAxisYValues)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditTooltipType)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditShowContentIn)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditLabelMode)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(941, 150, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' comboBoxEditTooltipPosition
            ' 
            Me.comboBoxEditTooltipPosition.EditValue = "Mouse Pointer"
            Me.comboBoxEditTooltipPosition.Location = New System.Drawing.Point(109, 34)
            Me.comboBoxEditTooltipPosition.Name = "comboBoxEditTooltipPosition"
            Me.comboBoxEditTooltipPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditTooltipPosition.Properties.Items.AddRange(New Object() {"Mouse Pointer", "Relative", "Free"})
            Me.comboBoxEditTooltipPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditTooltipPosition.Size = New System.Drawing.Size(120, 20)
            Me.comboBoxEditTooltipPosition.StyleController = Me.layoutControl1
            Me.comboBoxEditTooltipPosition.TabIndex = 17
            AddHandler Me.comboBoxEditTooltipPosition.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditToolTipPosition_SelectedIndexChanged)
            ' 
            ' comboBOxEditShowArgumentLine
            ' 
            Me.comboBOxEditShowArgumentLine.EditValue = True
            Me.comboBOxEditShowArgumentLine.Location = New System.Drawing.Point(12, 196)
            Me.comboBOxEditShowArgumentLine.Name = "comboBOxEditShowArgumentLine"
            Me.comboBOxEditShowArgumentLine.Properties.Caption = "Show Argument Line"
            Me.comboBOxEditShowArgumentLine.Size = New System.Drawing.Size(217, 20)
            Me.comboBOxEditShowArgumentLine.StyleController = Me.layoutControl1
            Me.comboBOxEditShowArgumentLine.TabIndex = 18
            AddHandler Me.comboBOxEditShowArgumentLine.CheckedChanged, New System.EventHandler(AddressOf Me.comboBoxEditShowArgumentLine_CheckedChanged)
            ' 
            ' comboBoxEditShowAxisXValues
            ' 
            Me.comboBoxEditShowAxisXValues.Location = New System.Drawing.Point(12, 220)
            Me.comboBoxEditShowAxisXValues.Name = "comboBoxEditShowAxisXValues"
            Me.comboBoxEditShowAxisXValues.Properties.Caption = "Show Axis X Values"
            Me.comboBoxEditShowAxisXValues.Size = New System.Drawing.Size(217, 20)
            Me.comboBoxEditShowAxisXValues.StyleController = Me.layoutControl1
            Me.comboBoxEditShowAxisXValues.TabIndex = 19
            AddHandler Me.comboBoxEditShowAxisXValues.CheckedChanged, New System.EventHandler(AddressOf Me.comboBoxEditShowAxisXValues_CheckedChanged)
            ' 
            ' checkEditShowLabel
            ' 
            Me.checkEditShowLabel.EditValue = True
            Me.checkEditShowLabel.Location = New System.Drawing.Point(12, 172)
            Me.checkEditShowLabel.Name = "checkEditShowLabel"
            Me.checkEditShowLabel.Properties.Caption = "Show Label"
            Me.checkEditShowLabel.Size = New System.Drawing.Size(217, 20)
            Me.checkEditShowLabel.StyleController = Me.layoutControl1
            Me.checkEditShowLabel.TabIndex = 20
            AddHandler Me.checkEditShowLabel.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowLabel_CheckedChanged)
            ' 
            ' comboBoxEditShowValueLine
            ' 
            Me.comboBoxEditShowValueLine.Location = New System.Drawing.Point(12, 244)
            Me.comboBoxEditShowValueLine.Name = "comboBoxEditShowValueLine"
            Me.comboBoxEditShowValueLine.Properties.Caption = "Show Value Line"
            Me.comboBoxEditShowValueLine.Size = New System.Drawing.Size(217, 20)
            Me.comboBoxEditShowValueLine.StyleController = Me.layoutControl1
            Me.comboBoxEditShowValueLine.TabIndex = 23
            AddHandler Me.comboBoxEditShowValueLine.CheckedChanged, New System.EventHandler(AddressOf Me.comboBoxEditShowValueLine_CheckedChanged)
            ' 
            ' comboBoxEditShowAxisYValues
            ' 
            Me.comboBoxEditShowAxisYValues.Location = New System.Drawing.Point(12, 268)
            Me.comboBoxEditShowAxisYValues.Name = "comboBoxEditShowAxisYValues"
            Me.comboBoxEditShowAxisYValues.Properties.Caption = "Show Axis Y Values"
            Me.comboBoxEditShowAxisYValues.Size = New System.Drawing.Size(217, 20)
            Me.comboBoxEditShowAxisYValues.StyleController = Me.layoutControl1
            Me.comboBoxEditShowAxisYValues.TabIndex = 24
            AddHandler Me.comboBoxEditShowAxisYValues.CheckedChanged, New System.EventHandler(AddressOf Me.comboBoxEditShowAxisYValues_CheckedChanged)
            ' 
            ' comboBoxEditTooltipType
            ' 
            Me.comboBoxEditTooltipType.EditValue = "Image"
            Me.comboBoxEditTooltipType.Location = New System.Drawing.Point(109, 58)
            Me.comboBoxEditTooltipType.Name = "comboBoxEditTooltipType"
            Me.comboBoxEditTooltipType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditTooltipType.Properties.Items.AddRange(New Object() {"Image", "Text"})
            Me.comboBoxEditTooltipType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditTooltipType.Size = New System.Drawing.Size(120, 20)
            Me.comboBoxEditTooltipType.StyleController = Me.layoutControl1
            Me.comboBoxEditTooltipType.TabIndex = 25
            AddHandler Me.comboBoxEditTooltipType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditTooltipType_SelectedIndexChanged)
            ' 
            ' comboBoxEditShowContentIn
            ' 
            Me.comboBoxEditShowContentIn.EditValue = "Label"
            Me.comboBoxEditShowContentIn.Location = New System.Drawing.Point(109, 124)
            Me.comboBoxEditShowContentIn.Name = "comboBoxEditShowContentIn"
            Me.comboBoxEditShowContentIn.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditShowContentIn.Properties.Items.AddRange(New Object() {"Label", "Legend"})
            Me.comboBoxEditShowContentIn.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditShowContentIn.Size = New System.Drawing.Size(120, 20)
            Me.comboBoxEditShowContentIn.StyleController = Me.layoutControl1
            Me.comboBoxEditShowContentIn.TabIndex = 27
            AddHandler Me.comboBoxEditShowContentIn.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditShowContentIn_SelectedIndexChanged)
            ' 
            ' comboBoxEditLabelMode
            ' 
            Me.comboBoxEditLabelMode.EditValue = "For Nearest Series"
            Me.comboBoxEditLabelMode.Location = New System.Drawing.Point(109, 148)
            Me.comboBoxEditLabelMode.Name = "comboBoxEditLabelMode"
            Me.comboBoxEditLabelMode.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditLabelMode.Properties.Items.AddRange(New Object() {"For Nearest Series", "Common For All Series"})
            Me.comboBoxEditLabelMode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditLabelMode.Size = New System.Drawing.Size(120, 20)
            Me.comboBoxEditLabelMode.StyleController = Me.layoutControl1
            Me.comboBoxEditLabelMode.TabIndex = 28
            AddHandler Me.comboBoxEditLabelMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditLabelMode_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.lcgCommonOptions, Me.lcgLabelOptions})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.GroupStyle = DevExpress.Utils.GroupStyle.Light
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup3})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 300)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(241, 238)
            Me.layoutControlGroup2.Text = "Marker Kind"
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.GroupBordersVisible = False
            Me.layoutControlGroup3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Size = New System.Drawing.Size(241, 238)
            ' 
            ' lcgCommonOptions
            ' 
            Me.lcgCommonOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.lcgCommonOptions.AppearanceGroup.Options.UseBorderColor = True
            Me.lcgCommonOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgCommonOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciTooltipPosition, Me.lciTooltipType})
            Me.lcgCommonOptions.Location = New System.Drawing.Point(0, 0)
            Me.lcgCommonOptions.Name = "lcgCommonOptions"
            Me.lcgCommonOptions.Size = New System.Drawing.Size(241, 90)
            Me.lcgCommonOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgCommonOptions.Text = "Tooltip"
            ' 
            ' lciTooltipPosition
            ' 
            Me.lciTooltipPosition.Control = Me.comboBoxEditTooltipPosition
            Me.lciTooltipPosition.Location = New System.Drawing.Point(0, 0)
            Me.lciTooltipPosition.Name = "lciTooltipPosition"
            Me.lciTooltipPosition.Size = New System.Drawing.Size(221, 24)
            Me.lciTooltipPosition.Text = "Tooltip Position:"
            Me.lciTooltipPosition.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' lciTooltipType
            ' 
            Me.lciTooltipType.Control = Me.comboBoxEditTooltipType
            Me.lciTooltipType.Location = New System.Drawing.Point(0, 24)
            Me.lciTooltipType.Name = "lciTooltipType"
            Me.lciTooltipType.Size = New System.Drawing.Size(221, 24)
            Me.lciTooltipType.Text = "Tooltip Type:"
            Me.lciTooltipType.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' lcgLabelOptions
            ' 
            Me.lcgLabelOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.lcgLabelOptions.AppearanceGroup.Options.UseBorderColor = True
            Me.lcgLabelOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.lcgLabelOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.lciShowLabel, Me.layoutControlItem5, Me.layoutControlItem1, Me.layoutControlItem6, Me.lciContentShowMode, Me.lciLabelMode})
            Me.lcgLabelOptions.Location = New System.Drawing.Point(0, 90)
            Me.lcgLabelOptions.Name = "lcgLabelOptions"
            Me.lcgLabelOptions.Size = New System.Drawing.Size(241, 210)
            Me.lcgLabelOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.lcgLabelOptions.Text = "Crosshair"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboBoxEditShowAxisXValues
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' lciShowLabel
            ' 
            Me.lciShowLabel.Control = Me.checkEditShowLabel
            Me.lciShowLabel.Location = New System.Drawing.Point(0, 48)
            Me.lciShowLabel.Name = "lciShowLabel"
            Me.lciShowLabel.Size = New System.Drawing.Size(221, 24)
            Me.lciShowLabel.TextSize = New System.Drawing.Size(0, 0)
            Me.lciShowLabel.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.comboBoxEditShowValueLine
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.comboBOxEditShowArgumentLine
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.comboBoxEditShowAxisYValues
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 144)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' lciContentShowMode
            ' 
            Me.lciContentShowMode.Control = Me.comboBoxEditShowContentIn
            Me.lciContentShowMode.Location = New System.Drawing.Point(0, 0)
            Me.lciContentShowMode.Name = "lciContentShowMode"
            Me.lciContentShowMode.Size = New System.Drawing.Size(221, 24)
            Me.lciContentShowMode.Text = "Show Content In:"
            Me.lciContentShowMode.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' lciLabelMode
            ' 
            Me.lciLabelMode.Control = Me.comboBoxEditLabelMode
            Me.lciLabelMode.Location = New System.Drawing.Point(0, 24)
            Me.lciLabelMode.Name = "lciLabelMode"
            Me.lciLabelMode.Size = New System.Drawing.Size(221, 24)
            Me.lciLabelMode.Text = "Label Mode:"
            Me.lciLabelMode.TextSize = New System.Drawing.Size(85, 13)
            ' 
            ' TooltipAndCrosshairDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "TooltipAndCrosshairDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBar), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            Me.sidePanel2.ResumeLayout(False)
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartSpline), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.comboBoxEditTooltipPosition.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBOxEditShowArgumentLine.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditShowAxisXValues.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowLabel.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditShowValueLine.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditShowAxisYValues.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditTooltipType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditShowContentIn.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditLabelMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgCommonOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTooltipPosition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciTooltipType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lcgLabelOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciShowLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciContentShowMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciLabelMode), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private sidePanel2 As DevExpress.XtraEditors.SidePanel

        Private chartSpline As DevExpress.XtraCharts.ChartControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private comboBoxEditTooltipPosition As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private lcgCommonOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private lciTooltipPosition As DevExpress.XtraLayout.LayoutControlItem

        Private lcgLabelOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private comboBOxEditShowArgumentLine As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditShowAxisXValues As DevExpress.XtraEditors.CheckEdit

        Private checkEditShowLabel As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private lciShowLabel As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditShowValueLine As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditShowAxisYValues As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditTooltipType As DevExpress.XtraEditors.ComboBoxEdit

        Private lciTooltipType As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditShowContentIn As DevExpress.XtraEditors.ComboBoxEdit

        Private lciContentShowMode As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditLabelMode As DevExpress.XtraEditors.ComboBoxEdit

        Private lciLabelMode As DevExpress.XtraLayout.LayoutControlItem

        Private barChartToolTipController As DevExpress.Utils.ToolTipController
    End Class
End Namespace
