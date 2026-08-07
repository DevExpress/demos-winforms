Namespace DevExpress.XtraCharts.Demos

    Partial Class SelectionDemo

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
        Private Overloads Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim hatchFillStyle1 As DevExpress.XtraTreeMap.HatchFillStyle = New DevExpress.XtraTreeMap.HatchFillStyle()
            Dim hatchFillStyle2 As DevExpress.XtraTreeMap.HatchFillStyle = New DevExpress.XtraTreeMap.HatchFillStyle()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim doughnutSeriesView1 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.labelSeriesDataMember = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupSelectionMode = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupSelectionMode = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciSelectionMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelBottomRoot = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanelBottomRight = New DevExpress.XtraEditors.SidePanel()
            Me.chartUrbanPopulationPercentage = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelBottomLeft = New DevExpress.XtraEditors.SidePanel()
            Me.treeMap = New DevExpress.XtraTreeMap.TreeMapControl()
            Me.sidePanelTopRoot = New DevExpress.XtraEditors.SidePanel()
            Me.sidePanelTopRight = New DevExpress.XtraEditors.SidePanel()
            Me.chartPopulationDynamic = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelTopLeft = New DevExpress.XtraEditors.SidePanel()
            Me.chartCountries = New DevExpress.XtraCharts.ChartControl()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupSelectionMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupSelectionMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciSelectionMode), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelBottomRoot.SuspendLayout()
            Me.sidePanelBottomRight.SuspendLayout()
            CType((Me.chartUrbanPopulationPercentage), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelBottomLeft.SuspendLayout()
            CType((Me.treeMap), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelTopRoot.SuspendLayout()
            Me.sidePanelTopRight.SuspendLayout()
            CType((Me.chartPopulationDynamic), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanelTopLeft.SuspendLayout()
            CType((Me.chartCountries), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnutSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(903, 0)
            Me.sidePanelOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.sidePanelOptions.Size = New System.Drawing.Size(117, 649)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(116, 649)
            Me.tabPaneOptions.Size = New System.Drawing.Size(116, 649)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(4)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(116, 616)
            ' 
            ' labelSeriesDataMember
            ' 
            Me.labelSeriesDataMember.Location = New System.Drawing.Point(12, 12)
            Me.labelSeriesDataMember.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
            Me.labelSeriesDataMember.Name = "labelSeriesDataMember"
            Me.labelSeriesDataMember.Size = New System.Drawing.Size(76, 13)
            Me.labelSeriesDataMember.TabIndex = 0
            Me.labelSeriesDataMember.Text = "Selection Mode:"
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupSelectionMode)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(843, 250, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(116, 616)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupSelectionMode
            ' 
            Me.radioGroupSelectionMode.AutoSizeInLayoutControl = True
            Me.radioGroupSelectionMode.EditValue = 2
            Me.radioGroupSelectionMode.Location = New System.Drawing.Point(12, 34)
            Me.radioGroupSelectionMode.Name = "radioGroupSelectionMode"
            Me.radioGroupSelectionMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupSelectionMode.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupSelectionMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupSelectionMode.Properties.Columns = 1
            Me.radioGroupSelectionMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Single"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Multiple"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Extended")})
            Me.radioGroupSelectionMode.Size = New System.Drawing.Size(92, 80)
            Me.radioGroupSelectionMode.StyleController = Me.layoutControl
            Me.radioGroupSelectionMode.TabIndex = 11
            AddHandler Me.radioGroupSelectionMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupSelectionMode_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1, Me.layoutControlGroupSelectionMode})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(116, 616)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 126)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(116, 490)
            ' 
            ' layoutControlGroupSelectionMode
            ' 
            Me.layoutControlGroupSelectionMode.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupSelectionMode.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupSelectionMode.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupSelectionMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciSelectionMode})
            Me.layoutControlGroupSelectionMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupSelectionMode.Name = "layoutControlGroupSelectionMode"
            Me.layoutControlGroupSelectionMode.Size = New System.Drawing.Size(116, 126)
            Me.layoutControlGroupSelectionMode.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupSelectionMode.Text = "Selection Mode"
            ' 
            ' lciSelectionMode
            ' 
            Me.lciSelectionMode.Control = Me.radioGroupSelectionMode
            Me.lciSelectionMode.Location = New System.Drawing.Point(0, 0)
            Me.lciSelectionMode.Name = "lciSelectionMode"
            Me.lciSelectionMode.Size = New System.Drawing.Size(96, 84)
            Me.lciSelectionMode.Text = "Selection Mode:"
            Me.lciSelectionMode.TextVisible = False
            ' 
            ' sidePanelBottomRoot
            ' 
            Me.sidePanelBottomRoot.Controls.Add(Me.sidePanelBottomRight)
            Me.sidePanelBottomRoot.Controls.Add(Me.sidePanelBottomLeft)
            Me.sidePanelBottomRoot.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.sidePanelBottomRoot.Location = New System.Drawing.Point(0, 433)
            Me.sidePanelBottomRoot.Name = "sidePanelBottomRoot"
            Me.sidePanelBottomRoot.Size = New System.Drawing.Size(903, 216)
            Me.sidePanelBottomRoot.TabIndex = 1
            Me.sidePanelBottomRoot.Text = "sidePanel1"
            ' 
            ' sidePanelBottomRight
            ' 
            Me.sidePanelBottomRight.Controls.Add(Me.chartUrbanPopulationPercentage)
            Me.sidePanelBottomRight.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanelBottomRight.Location = New System.Drawing.Point(420, 1)
            Me.sidePanelBottomRight.Name = "sidePanelBottomRight"
            Me.sidePanelBottomRight.Size = New System.Drawing.Size(483, 215)
            Me.sidePanelBottomRight.TabIndex = 1
            Me.sidePanelBottomRight.Text = "sidePanel1"
            ' 
            ' chartUrbanPopulationPercentage
            ' 
            Me.chartUrbanPopulationPercentage.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
            Me.chartUrbanPopulationPercentage.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
            xyDiagram1.AxisY.Label.TextPattern = "{V:0.}%"
            xyDiagram1.AxisY.Tickmarks.MinorVisible = False
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.Auto = False
            xyDiagram1.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisY.WholeRange.MaxValueSerializable = "100"
            xyDiagram1.AxisY.WholeRange.MinValueSerializable = "0"
            xyDiagram1.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram1.DefaultPane.BorderVisible = False
            Me.chartUrbanPopulationPercentage.Diagram = xyDiagram1
            Me.chartUrbanPopulationPercentage.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartUrbanPopulationPercentage.EmptyChartText.Text = "Select a country to see urban population percentage"
            Me.chartUrbanPopulationPercentage.Legend.Name = "Default Legend"
            Me.chartUrbanPopulationPercentage.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartUrbanPopulationPercentage.Location = New System.Drawing.Point(0, 0)
            Me.chartUrbanPopulationPercentage.Name = "chartUrbanPopulationPercentage"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series1.Name = "Series 1"
            series1.SeriesID = 0
            series2.Name = "Series 2"
            series2.SeriesID = 1
            Me.chartUrbanPopulationPercentage.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chartUrbanPopulationPercentage.Size = New System.Drawing.Size(483, 215)
            Me.chartUrbanPopulationPercentage.TabIndex = 0
            chartTitle1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 16F)
            chartTitle1.Text = "Urban Population Percentage"
            chartTitle1.TitleID = 0
            Me.chartUrbanPopulationPercentage.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chartUrbanPopulationPercentage.Click, New System.EventHandler(AddressOf Me.OnChartClick)
            ' 
            ' sidePanelBottomLeft
            ' 
            Me.sidePanelBottomLeft.Controls.Add(Me.treeMap)
            Me.sidePanelBottomLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanelBottomLeft.Location = New System.Drawing.Point(0, 1)
            Me.sidePanelBottomLeft.Name = "sidePanelBottomLeft"
            Me.sidePanelBottomLeft.Size = New System.Drawing.Size(420, 215)
            Me.sidePanelBottomLeft.TabIndex = 0
            Me.sidePanelBottomLeft.Text = "sidePanel1"
            ' 
            ' treeMap
            ' 
            Me.treeMap.Appearance.GroupStyle.TextGlowColor = System.Drawing.Color.Empty
            Me.treeMap.Appearance.HighlightedLeafStyle.FillStyle = hatchFillStyle1
            Me.treeMap.Appearance.SelectedLeafStyle.FillStyle = hatchFillStyle2
            Me.treeMap.BorderOptions.Visible = False
            Me.treeMap.Dock = System.Windows.Forms.DockStyle.Fill
            Me.treeMap.Location = New System.Drawing.Point(0, 0)
            Me.treeMap.Margin = New System.Windows.Forms.Padding(2)
            Me.treeMap.Name = "treeMap"
            Me.treeMap.SelectionMode = DevExpress.XtraTreeMap.ElementSelectionMode.Multiple
            Me.treeMap.Size = New System.Drawing.Size(419, 215)
            Me.treeMap.TabIndex = 0
            Me.treeMap.ToolTipLeafPattern = "{L}: {V:0.##}M km²"
            AddHandler Me.treeMap.SelectionChanged, New DevExpress.XtraTreeMap.SelectionChangedEventHandler(AddressOf Me.TreeMapSelectionChanged)
            ' 
            ' sidePanelTopRoot
            ' 
            Me.sidePanelTopRoot.Controls.Add(Me.sidePanelTopRight)
            Me.sidePanelTopRoot.Controls.Add(Me.sidePanelTopLeft)
            Me.sidePanelTopRoot.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanelTopRoot.Location = New System.Drawing.Point(0, 0)
            Me.sidePanelTopRoot.Name = "sidePanelTopRoot"
            Me.sidePanelTopRoot.Size = New System.Drawing.Size(903, 433)
            Me.sidePanelTopRoot.TabIndex = 2
            Me.sidePanelTopRoot.Text = "sidePanel1"
            ' 
            ' sidePanelTopRight
            ' 
            Me.sidePanelTopRight.Controls.Add(Me.chartPopulationDynamic)
            Me.sidePanelTopRight.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanelTopRight.Location = New System.Drawing.Point(420, 0)
            Me.sidePanelTopRight.Name = "sidePanelTopRight"
            Me.sidePanelTopRight.Size = New System.Drawing.Size(483, 433)
            Me.sidePanelTopRight.TabIndex = 1
            Me.sidePanelTopRight.Text = "sidePanel2"
            ' 
            ' chartPopulationDynamic
            ' 
            Me.chartPopulationDynamic.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnDataChanged
            Me.chartPopulationDynamic.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPopulationDynamic.CrosshairOptions.GroupHeaderPattern = "{A}"
            xyDiagram2.AxisX.Tickmarks.MinorVisible = False
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
            xyDiagram2.AxisY.Label.TextPattern = "{V}M"
            xyDiagram2.AxisY.Tickmarks.MinorVisible = False
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram2.DefaultPane.BorderVisible = False
            Me.chartPopulationDynamic.Diagram = xyDiagram2
            Me.chartPopulationDynamic.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPopulationDynamic.EmptyChartText.Text = "Select a country to see population dynamic"
            Me.chartPopulationDynamic.Legend.Name = "Default Legend"
            Me.chartPopulationDynamic.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPopulationDynamic.Location = New System.Drawing.Point(0, 0)
            Me.chartPopulationDynamic.Name = "chartPopulationDynamic"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
            series3.CrosshairLabelPattern = "{S}: {V:0.##}M"
            series3.Name = "Series 1"
            series3.SeriesID = 0
            series3.View = lineSeriesView1
            Me.chartPopulationDynamic.SeriesSerializable = New DevExpress.XtraCharts.Series() {series3}
            Me.chartPopulationDynamic.Size = New System.Drawing.Size(483, 433)
            Me.chartPopulationDynamic.TabIndex = 0
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 16F)
            chartTitle2.Text = "Population Dynamics"
            chartTitle2.TitleID = 0
            Me.chartPopulationDynamic.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            AddHandler Me.chartPopulationDynamic.Click, New System.EventHandler(AddressOf Me.OnChartClick)
            ' 
            ' sidePanelTopLeft
            ' 
            Me.sidePanelTopLeft.Controls.Add(Me.chartCountries)
            Me.sidePanelTopLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.sidePanelTopLeft.Location = New System.Drawing.Point(0, 0)
            Me.sidePanelTopLeft.Margin = New System.Windows.Forms.Padding(2)
            Me.sidePanelTopLeft.Name = "sidePanelTopLeft"
            Me.sidePanelTopLeft.Size = New System.Drawing.Size(420, 433)
            Me.sidePanelTopLeft.TabIndex = 0
            Me.sidePanelTopLeft.Text = "sidePanel1"
            ' 
            ' chartCountries
            ' 
            Me.chartCountries.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartCountries.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartCountries.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartCountries.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center
            Me.chartCountries.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartCountries.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartCountries.Legend.Name = "Default Legend"
            Me.chartCountries.Location = New System.Drawing.Point(0, 0)
            Me.chartCountries.Margin = New System.Windows.Forms.Padding(2)
            Me.chartCountries.Name = "chartCountries"
            Me.chartCountries.SelectionMode = DevExpress.XtraCharts.ElementSelectionMode.Multiple
            Me.chartCountries.SeriesSelectionMode = DevExpress.XtraCharts.SeriesSelectionMode.Point
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series4.LegendTextPattern = "{A}"
            series4.Name = "Countries Area"
            series4.SeriesID = 0
            doughnutSeriesView1.HoleRadiusPercent = 50
            doughnutSeriesView1.TotalLabel.TextPattern = "TOTAL" & Global.Microsoft.VisualBasic.Constants.vbLf & "{TV}M km²"
            doughnutSeriesView1.TotalLabel.Visible = True
            series4.View = doughnutSeriesView1
            Me.chartCountries.SeriesSerializable = New DevExpress.XtraCharts.Series() {series4}
            Me.chartCountries.Size = New System.Drawing.Size(419, 433)
            Me.chartCountries.TabIndex = 0
            chartTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 16F)
            chartTitle3.Text = "Top 10 Largest Countries by Area"
            chartTitle3.TitleID = 0
            Me.chartCountries.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3})
            AddHandler Me.chartCountries.ObjectSelected, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chartCountries_ObjectSelected)
            AddHandler Me.chartCountries.ObjectHotTracked, New DevExpress.XtraCharts.HotTrackEventHandler(AddressOf Me.chartCountries_ObjectHotTracked)
            AddHandler Me.chartCountries.Click, New System.EventHandler(AddressOf Me.OnChartClick)
            ' 
            ' SelectionDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanelTopRoot)
            Me.Controls.Add(Me.sidePanelBottomRoot)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "SelectionDemo"
            Me.Size = New System.Drawing.Size(1020, 649)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanelBottomRoot, 0)
            Me.Controls.SetChildIndex(Me.sidePanelTopRoot, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupSelectionMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupSelectionMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciSelectionMode), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelBottomRoot.ResumeLayout(False)
            Me.sidePanelBottomRight.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartUrbanPopulationPercentage), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelBottomLeft.ResumeLayout(False)
            CType((Me.treeMap), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelTopRoot.ResumeLayout(False)
            Me.sidePanelTopRight.ResumeLayout(False)
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPopulationDynamic), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanelTopLeft.ResumeLayout(False)
            CType((doughnutSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartCountries), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private labelSeriesDataMember As DevExpress.XtraEditors.LabelControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupSelectionMode As DevExpress.XtraLayout.LayoutControlGroup

        Private lciSelectionMode As DevExpress.XtraLayout.LayoutControlItem

        Private radioGroupSelectionMode As DevExpress.XtraEditors.RadioGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanelBottomRoot As DevExpress.XtraEditors.SidePanel

        Private sidePanelBottomRight As DevExpress.XtraEditors.SidePanel

        Private sidePanelBottomLeft As DevExpress.XtraEditors.SidePanel

        Private sidePanelTopRoot As DevExpress.XtraEditors.SidePanel

        Private sidePanelTopRight As DevExpress.XtraEditors.SidePanel

        Private sidePanelTopLeft As DevExpress.XtraEditors.SidePanel

        Private chartCountries As DevExpress.XtraCharts.ChartControl

        Private chartUrbanPopulationPercentage As DevExpress.XtraCharts.ChartControl

        Private chartPopulationDynamic As DevExpress.XtraCharts.ChartControl

        Private treeMap As DevExpress.XtraTreeMap.TreeMapControl
    End Class
End Namespace
