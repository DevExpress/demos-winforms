Namespace DevExpress.XtraCharts.Demos

    Partial Class TornadoDemo

        Private components As System.ComponentModel.IContainer = Nothing

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
        Private Overloads Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim seriesTemplateAdapter1 As DevExpress.XtraCharts.SeriesTemplateAdapter = New DevExpress.XtraCharts.SeriesTemplateAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim stackedBarSeriesLabel1 As DevExpress.XtraCharts.StackedBarSeriesLabel = New DevExpress.XtraCharts.StackedBarSeriesLabel()
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Dim stackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditLabelIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditLabelOrientation = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditTotalLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditRangeBarLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemIndent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemOrientation = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRangeBarLabelPosition = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupTotalLabels = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemTotalLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditLabelIndent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditLabelOrientation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditTotalLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditRangeBarLabelPosition.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemIndent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemOrientation), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRangeBarLabelPosition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabels), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTotalLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(2)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.layoutControl1)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(602, 135, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl1.Controls.Add(Me.spinEditLabelIndent)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditLabelOrientation)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditTotalLabelVisible)
            Me.layoutControl1.Controls.Add(Me.comboBoxEditRangeBarLabelPosition)
            Me.layoutControl1.Location = New System.Drawing.Point(2, 2)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(434, 57, 1127, 704)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(237, 534)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 34)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(213, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl1
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditLabelIndent
            ' 
            Me.spinEditLabelIndent.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
            Me.spinEditLabelIndent.Enabled = False
            Me.spinEditLabelIndent.Location = New System.Drawing.Point(82, 106)
            Me.spinEditLabelIndent.Name = "spinEditLabelIndent"
            Me.spinEditLabelIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditLabelIndent.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditLabelIndent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditLabelIndent.Properties.IsFloatValue = False
            Me.spinEditLabelIndent.Properties.Mask.EditMask = "N00"
            Me.spinEditLabelIndent.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEditLabelIndent.Size = New System.Drawing.Size(143, 20)
            Me.spinEditLabelIndent.StyleController = Me.layoutControl1
            Me.spinEditLabelIndent.TabIndex = 12
            AddHandler Me.spinEditLabelIndent.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditLabelIndent_EditValueChanged)
            ' 
            ' comboBoxEditLabelOrientation
            ' 
            Me.comboBoxEditLabelOrientation.EditValue = "Horizontal"
            Me.comboBoxEditLabelOrientation.Enabled = False
            Me.comboBoxEditLabelOrientation.Location = New System.Drawing.Point(82, 82)
            Me.comboBoxEditLabelOrientation.Name = "comboBoxEditLabelOrientation"
            Me.comboBoxEditLabelOrientation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditLabelOrientation.Properties.Items.AddRange(New Object() {"Horizontal", "Top To Bottom", "Bottom To Top"})
            Me.comboBoxEditLabelOrientation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditLabelOrientation.Size = New System.Drawing.Size(143, 20)
            Me.comboBoxEditLabelOrientation.StyleController = Me.layoutControl1
            Me.comboBoxEditLabelOrientation.TabIndex = 13
            AddHandler Me.comboBoxEditLabelOrientation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditLabelOrientation_SelectedIndexChanged)
            ' 
            ' comboBoxEditTotalLabelVisible
            ' 
            Me.comboBoxEditTotalLabelVisible.EditValue = True
            Me.comboBoxEditTotalLabelVisible.Location = New System.Drawing.Point(12, 172)
            Me.comboBoxEditTotalLabelVisible.Name = "comboBoxEditTotalLabelVisible"
            Me.comboBoxEditTotalLabelVisible.Properties.Caption = "Visible"
            Me.comboBoxEditTotalLabelVisible.Size = New System.Drawing.Size(213, 20)
            Me.comboBoxEditTotalLabelVisible.StyleController = Me.layoutControl1
            Me.comboBoxEditTotalLabelVisible.TabIndex = 15
            AddHandler Me.comboBoxEditTotalLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.comboBoxEditTotalLabelVisible_CheckedChanged)
            ' 
            ' comboBoxEditRangeBarLabelPosition
            ' 
            Me.comboBoxEditRangeBarLabelPosition.EditValue = ""
            Me.comboBoxEditRangeBarLabelPosition.Enabled = False
            Me.comboBoxEditRangeBarLabelPosition.Location = New System.Drawing.Point(82, 58)
            Me.comboBoxEditRangeBarLabelPosition.Name = "comboBoxEditRangeBarLabelPosition"
            Me.comboBoxEditRangeBarLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditRangeBarLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditRangeBarLabelPosition.Size = New System.Drawing.Size(143, 20)
            Me.comboBoxEditRangeBarLabelPosition.StyleController = Me.layoutControl1
            Me.comboBoxEditRangeBarLabelPosition.TabIndex = 18
            AddHandler Me.comboBoxEditRangeBarLabelPosition.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditRangeBarLabelPosition_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupLabel, Me.emptySpaceItem, Me.layoutControlGroupTotalLabels})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(237, 534)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemIndent, Me.layoutControlItemOrientation, Me.layoutControlItemRangeBarLabelPosition})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(237, 138)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(217, 24)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' layoutControlItemIndent
            ' 
            Me.layoutControlItemIndent.Control = Me.spinEditLabelIndent
            Me.layoutControlItemIndent.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemIndent.Name = "layoutControlItemIndent"
            Me.layoutControlItemIndent.Size = New System.Drawing.Size(217, 24)
            Me.layoutControlItemIndent.Text = "Indent:"
            Me.layoutControlItemIndent.TextSize = New System.Drawing.Size(58, 13)
            ' 
            ' layoutControlItemOrientation
            ' 
            Me.layoutControlItemOrientation.Control = Me.comboBoxEditLabelOrientation
            Me.layoutControlItemOrientation.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemOrientation.Name = "layoutControlItemOrientation"
            Me.layoutControlItemOrientation.Size = New System.Drawing.Size(217, 24)
            Me.layoutControlItemOrientation.Text = "Orientation:"
            Me.layoutControlItemOrientation.TextSize = New System.Drawing.Size(58, 13)
            ' 
            ' layoutControlItemRangeBarLabelPosition
            ' 
            Me.layoutControlItemRangeBarLabelPosition.Control = Me.comboBoxEditRangeBarLabelPosition
            Me.layoutControlItemRangeBarLabelPosition.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemRangeBarLabelPosition.Name = "layoutControlItemRangeBarLabelPosition"
            Me.layoutControlItemRangeBarLabelPosition.Size = New System.Drawing.Size(217, 24)
            Me.layoutControlItemRangeBarLabelPosition.Text = "Position"
            Me.layoutControlItemRangeBarLabelPosition.TextSize = New System.Drawing.Size(58, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 204)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(237, 330)
            ' 
            ' layoutControlGroupTotalLabels
            ' 
            Me.layoutControlGroupTotalLabels.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabels.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemTotalLabelVisible})
            Me.layoutControlGroupTotalLabels.Location = New System.Drawing.Point(0, 138)
            Me.layoutControlGroupTotalLabels.Name = "layoutControlGroupTotalLabels"
            Me.layoutControlGroupTotalLabels.Size = New System.Drawing.Size(237, 66)
            Me.layoutControlGroupTotalLabels.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabels.Text = "Total Label"
            ' 
            ' layoutControlItemTotalLabelVisible
            ' 
            Me.layoutControlItemTotalLabelVisible.Control = Me.comboBoxEditTotalLabelVisible
            Me.layoutControlItemTotalLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemTotalLabelVisible.Name = "layoutControlItemTotalLabelVisible"
            Me.layoutControlItemTotalLabelVisible.Size = New System.Drawing.Size(217, 24)
            Me.layoutControlItemTotalLabelVisible.TextVisible = False
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.layoutControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ContentShowMode = DevExpress.XtraCharts.CrosshairContentShowMode.Label
            Me.chart.CrosshairOptions.HighlightPoints = False
            Me.chart.CrosshairOptions.ShowArgumentLine = False
            Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.LabelVisibilityMode = DevExpress.XtraCharts.AxisLabelVisibilityMode.AutoGeneratedAndCustom
            xyDiagram1.AxisX.Reverse = True
            xyDiagram1.AxisX.Title.Text = "Countries"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Label.TextPattern = "{V:0,,}"
            xyDiagram1.AxisY.Title.Text = "Population (Millions)"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.StackedBarTotalLabel.TextPattern = "{TV:0,,.0}"
            xyDiagram1.DefaultPane.StackedBarTotalLabel.Visible = True
            xyDiagram1.Rotated = True
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chart.Legend.Margins.Top = 0
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Padding.Top = 3
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            legend1.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            legend1.LegendID = 0
            legend1.Margins.Bottom = 0
            legend1.Name = "Legend 1"
            legend1.Padding.Bottom = 3
            legend1.Padding.Tag = ""
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1})
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            Me.chart.PaletteRepository.Add("Palette 1", New DevExpress.XtraCharts.Palette("Palette 1", DevExpress.XtraCharts.PaletteScaleMode.Repeat, New DevExpress.XtraCharts.PaletteEntry() {New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((68)))))), (CInt(((CByte((108))))))), System.Drawing.Color.FromArgb((CInt(((CByte((64)))))), (CInt(((CByte((68)))))), (CInt(((CByte((108)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((88)))))), (CInt(((CByte((89))))))), System.Drawing.Color.FromArgb((CInt(((CByte((218)))))), (CInt(((CByte((88)))))), (CInt(((CByte((89)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((220)))))), (CInt(((CByte((255))))))), System.Drawing.Color.FromArgb((CInt(((CByte((196)))))), (CInt(((CByte((220)))))), (CInt(((CByte((255)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((131)))))), (CInt(((CByte((213))))))), System.Drawing.Color.FromArgb((CInt(((CByte((84)))))), (CInt(((CByte((131)))))), (CInt(((CByte((213)))))))), New DevExpress.XtraCharts.PaletteEntry(System.Drawing.Color.FromArgb((CInt(((CByte((146)))))), (CInt(((CByte((206)))))), (CInt(((CByte((181))))))), System.Drawing.Color.FromArgb((CInt(((CByte((146)))))), (CInt(((CByte((206)))))), (CInt(((CByte((181))))))))}))
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chart.SeriesTemplate.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.SeriesTemplate.CrosshairLabelPattern = "{S}" & Global.Microsoft.VisualBasic.Constants.vbLf & "{V:0,,.0} million"
            dataMember1.ColumnName = "Country"
            dataMember2.ColumnName = "CalculatedPopulation"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataMember3.ColumnName = "GenderAge"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Series
            seriesTemplateAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3})
            Me.chart.SeriesTemplate.DataAdapter = seriesTemplateAdapter1
            stackedBarSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            stackedBarSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            stackedBarSeriesLabel1.TextPattern = "{V:0,,.0}"
            Me.chart.SeriesTemplate.Label = stackedBarSeriesLabel1
            Me.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            Me.chart.SeriesTemplate.ToolTipPointPattern = "{A} {S} - {PopulationString} million"
            Me.chart.SeriesTemplate.View = stackedBarSeriesView1
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 3
            chartTitle1.Text = "Population: Age Structure"
            chartTitle1.TitleID = 0
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle2.Text = "Data estimate for 2020"
            chartTitle2.TitleID = 1
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle3.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.25F)
            chartTitle3.Text = "From www.cia.gov"
            chartTitle3.TextColor = System.Drawing.Color.Gray
            chartTitle3.TitleID = 2
            Me.chart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2, chartTitle3})
            Me.chart.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            AddHandler Me.chart.CustomDrawSeriesPoint, New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(AddressOf Me.Chart_CustomDrawSeriesPoint)
            AddHandler Me.chart.CustomDrawAxisLabel, New DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(AddressOf Me.Chart_CustomDrawAxisLabel)
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.Chart_BoundDataChanged)
            AddHandler Me.chart.CustomizeStackedBarTotalLabel, New DevExpress.XtraCharts.CustomizeStackedBarTotalLabelEventHandler(AddressOf Me.Chart_CustomizeStackedBarTotalLabel)
            ' 
            ' TornadoDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "TornadoDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditLabelIndent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditLabelOrientation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditTotalLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditRangeBarLabelPosition.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemIndent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemOrientation), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRangeBarLabelPosition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabels), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTotalLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private spinEditLabelIndent As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditLabelOrientation As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditTotalLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditRangeBarLabelPosition As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemIndent As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemOrientation As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemRangeBarLabelPosition As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupTotalLabels As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemTotalLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private chart As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
