Namespace DevExpress.XtraCharts.Demos

    Partial Class LegendsDemo

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
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend2 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend3 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim customLegendItem1 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim customLegendItem2 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim customLegendItem3 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim areaSeriesView1 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim areaSeriesView2 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim areaSeriesView3 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim seriesKeyColorColorizer1 As DevExpress.XtraCharts.SeriesKeyColorColorizer = New DevExpress.XtraCharts.SeriesKeyColorColorizer()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupMarkerMode = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupLegendMode = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupCrosshairContentMode = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupMarkerMode = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemMarkerMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupLegendMode = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLegendMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupCrosshairContentMode = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemCrosshairContentMode = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupMarkerMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupLegendMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupCrosshairContentMode.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMarkerMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLegendMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLegendMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupCrosshairContentMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemCrosshairContentMode), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(764, 0)
            Me.sidePanelOptions.Size = New System.Drawing.Size(242, 574)
            ' 
            ' tabPaneOptions
            ' 
            Me.tabPaneOptions.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.tabPaneOptions.Appearance.Options.UseBackColor = True
            Me.tabPaneOptions.RegularSize = New System.Drawing.Size(241, 574)
            Me.tabPaneOptions.Size = New System.Drawing.Size(241, 574)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Margin = New System.Windows.Forms.Padding(0)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 541)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ContentShowMode = DevExpress.XtraCharts.CrosshairContentShowMode.Legend
            Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:%s} sec"
            Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
            Me.chart.Cursor = System.Windows.Forms.Cursors.[Default]
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Label.TextPattern = "{A:%s} sec"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "0"
            xyDiagram1.AxisX.VisualRange.Auto = False
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
            xyDiagram1.AxisX.VisualRange.EndSideMargin = 0R
            xyDiagram1.AxisX.VisualRange.StartSideMargin = 0R
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "00:00:09"
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "00:00:00"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Label.TextPattern = "{V}MiB"
            xyDiagram1.AxisY.Title.Text = ""
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "0"
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.MinorVisible = True
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Label.TextPattern = "{V:P0}"
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.VisibleInPanesSerializable = "-1"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.MaxCrosshairContentWidth = 70
            Me.chart.Legend.MaxHorizontalPercentage = 50R
            Me.chart.Legend.MaxVerticalPercentage = 50R
            Me.chart.Legend.Name = "Default Legend"
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend1.DockTargetName = "Pane 1"
            legend1.MaxCrosshairContentWidth = 70
            legend1.Name = "Legend1"
            legend1.Padding.Bottom = 10
            legend1.Padding.Left = 10
            legend1.Title.Text = "RAM Usage"
            legend1.Title.Visible = True
            legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend2.DockTargetName = "Default Pane"
            legend2.MaxCrosshairContentWidth = 60
            legend2.Name = "Legend2"
            legend2.Padding.Bottom = 10
            legend2.Padding.Left = 10
            legend2.Title.Text = "CPU Usage"
            legend2.Title.Visible = True
            legend3.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            legend3.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            customLegendItem1.Name = "Custom Legend Item 1"
            customLegendItem1.Text = "Process 1"
            customLegendItem2.Name = "Custom Legend Item 2"
            customLegendItem2.Text = "Process 2"
            customLegendItem3.Name = "Custom Legend Item 3"
            customLegendItem3.Text = "Process 3"
            legend3.CustomItems.AddRange(New DevExpress.XtraCharts.CustomLegendItem() {customLegendItem1, customLegendItem2, customLegendItem3})
            legend3.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            legend3.Name = "Legend3"
            legend3.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1, legend2, legend3})
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Name = "chart"
            series1.ArgumentDataMember = "Time"
            series1.CrosshairLabelPattern = "{V:P0}"
            series1.LegendName = "Legend2"
            series1.Name = "Process 1"
            series1.Tag = "CPU"
            series1.ValueDataMembersSerializable = "Process1CpuUsage"
            lineSeriesView1.AxisYName = "Secondary AxisY 1"
            series1.View = lineSeriesView1
            series2.ArgumentDataMember = "Time"
            series2.CrosshairLabelPattern = "{V:P0}"
            series2.LegendName = "Legend2"
            series2.Name = "Process 2"
            series2.Tag = "CPU"
            series2.ValueDataMembersSerializable = "Process2CpuUsage"
            lineSeriesView2.AxisYName = "Secondary AxisY 1"
            series2.View = lineSeriesView2
            series3.ArgumentDataMember = "Time"
            series3.CrosshairLabelPattern = "{V:P0}"
            series3.LegendName = "Legend2"
            series3.Name = "Process 3"
            series3.Tag = "CPU"
            series3.ValueDataMembersSerializable = "Process3CpuUsage"
            lineSeriesView3.AxisYName = "Secondary AxisY 1"
            series3.View = lineSeriesView3
            series4.ArgumentDataMember = "Time"
            series4.CrosshairLabelPattern = "{V:0.} MiB"
            series4.LegendName = "Legend1"
            series4.Name = "Process 1"
            series4.Tag = "Memory"
            series4.ValueDataMembersSerializable = "Process1Memory"
            areaSeriesView1.PaneName = "Pane 1"
            series4.View = areaSeriesView1
            series5.ArgumentDataMember = "Time"
            series5.CrosshairLabelPattern = "{V:0.} MiB"
            series5.LegendName = "Legend1"
            series5.Name = "Process 2"
            series5.Tag = "Memory"
            series5.ValueDataMembersSerializable = "Process2Memory"
            areaSeriesView2.PaneName = "Pane 1"
            series5.View = areaSeriesView2
            series6.ArgumentDataMember = "Time"
            series6.CrosshairLabelPattern = "{V:0.} MiB"
            series6.LegendName = "Legend1"
            series6.Name = "Process 3"
            series6.Tag = "Memory"
            series6.ValueDataMembersSerializable = "Process3Memory"
            areaSeriesView3.PaneName = "Pane 1"
            series6.View = areaSeriesView3
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4, series5, series6}
            sideBySideBarSeriesLabel1.TextPattern = "{V:yyyy}"
            Me.chart.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            seriesKeyColorColorizer1.Keys.Add("Process 1")
            seriesKeyColorColorizer1.Keys.Add("Process 2")
            seriesKeyColorColorizer1.Keys.Add("Process 3")
            Me.chart.SeriesTemplate.SeriesColorizer = seriesKeyColorColorizer1
            Me.chart.Size = New System.Drawing.Size(764, 574)
            Me.chart.TabIndex = 1
            Me.chart.TabStop = False
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupMarkerMode)
            Me.layoutControl.Controls.Add(Me.radioGroupLegendMode)
            Me.layoutControl.Controls.Add(Me.radioGroupCrosshairContentMode)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(244, 313, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 541)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupMarkerMode
            ' 
            Me.radioGroupMarkerMode.AutoSizeInLayoutControl = True
            Me.radioGroupMarkerMode.EditValue = 0
            Me.radioGroupMarkerMode.Location = New System.Drawing.Point(12, 34)
            Me.radioGroupMarkerMode.Name = "radioGroupMarkerMode"
            Me.radioGroupMarkerMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupMarkerMode.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupMarkerMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupMarkerMode.Properties.Columns = 1
            Me.radioGroupMarkerMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Marker"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Check Box"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Check Box and Marker"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Marker and Check Box"), New DevExpress.XtraEditors.Controls.RadioGroupItem(4, "None")})
            Me.radioGroupMarkerMode.Size = New System.Drawing.Size(217, 128)
            Me.radioGroupMarkerMode.StyleController = Me.layoutControl
            Me.radioGroupMarkerMode.TabIndex = 4
            AddHandler Me.radioGroupMarkerMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupMarkerMode_SelectedIndexChanged)
            ' 
            ' radioGroupLegendMode
            ' 
            Me.radioGroupLegendMode.AutoSizeInLayoutControl = True
            Me.radioGroupLegendMode.EditValue = 1
            Me.radioGroupLegendMode.Location = New System.Drawing.Point(12, 208)
            Me.radioGroupLegendMode.Name = "radioGroupLegendMode"
            Me.radioGroupLegendMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupLegendMode.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupLegendMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupLegendMode.Properties.Columns = 1
            Me.radioGroupLegendMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Single Legend"), New DevExpress.XtraEditors.Controls.RadioGroupItem(2, "Multiple Pane Bound, Out of Panes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Multiple Pane Bound, Within Panes"), New DevExpress.XtraEditors.Controls.RadioGroupItem(3, "Single Legend With Custom Items")})
            Me.radioGroupLegendMode.Size = New System.Drawing.Size(217, 104)
            Me.radioGroupLegendMode.StyleController = Me.layoutControl
            Me.radioGroupLegendMode.TabIndex = 5
            AddHandler Me.radioGroupLegendMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupLegendMode_SelectedIndexChanged)
            ' 
            ' radioGroupCrosshairContentMode
            ' 
            Me.radioGroupCrosshairContentMode.AutoSizeInLayoutControl = True
            Me.radioGroupCrosshairContentMode.EditValue = 1
            Me.radioGroupCrosshairContentMode.Location = New System.Drawing.Point(12, 358)
            Me.radioGroupCrosshairContentMode.Name = "radioGroupCrosshairContentMode"
            Me.radioGroupCrosshairContentMode.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupCrosshairContentMode.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupCrosshairContentMode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupCrosshairContentMode.Properties.Columns = 1
            Me.radioGroupCrosshairContentMode.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Label"), New DevExpress.XtraEditors.Controls.RadioGroupItem(1, "Legend")})
            Me.radioGroupCrosshairContentMode.Size = New System.Drawing.Size(217, 56)
            Me.radioGroupCrosshairContentMode.StyleController = Me.layoutControl
            Me.radioGroupCrosshairContentMode.TabIndex = 6
            AddHandler Me.radioGroupCrosshairContentMode.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupCrosshairContentMode_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupMarkerMode, Me.layoutControlGroupLegendMode, Me.emptySpaceItem, Me.layoutControlGroupCrosshairContentMode})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 541)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupMarkerMode
            ' 
            Me.layoutControlGroupMarkerMode.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMarkerMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemMarkerMode})
            Me.layoutControlGroupMarkerMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupMarkerMode.Name = "layoutControlGroupMarkerMode"
            Me.layoutControlGroupMarkerMode.Size = New System.Drawing.Size(241, 174)
            Me.layoutControlGroupMarkerMode.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMarkerMode.Text = "Marker Mode"
            ' 
            ' layoutControlItemMarkerMode
            ' 
            Me.layoutControlItemMarkerMode.Control = Me.radioGroupMarkerMode
            Me.layoutControlItemMarkerMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemMarkerMode.Name = "layoutControlItemMarkerMode"
            Me.layoutControlItemMarkerMode.Size = New System.Drawing.Size(221, 132)
            Me.layoutControlItemMarkerMode.TextVisible = False
            ' 
            ' layoutControlGroupLegendMode
            ' 
            Me.layoutControlGroupLegendMode.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLegendMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLegendMode})
            Me.layoutControlGroupLegendMode.Location = New System.Drawing.Point(0, 174)
            Me.layoutControlGroupLegendMode.Name = "layoutControlGroupLegendMode"
            Me.layoutControlGroupLegendMode.Size = New System.Drawing.Size(241, 150)
            Me.layoutControlGroupLegendMode.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLegendMode.Text = "Legend Mode"
            ' 
            ' layoutControlItemLegendMode
            ' 
            Me.layoutControlItemLegendMode.Control = Me.radioGroupLegendMode
            Me.layoutControlItemLegendMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLegendMode.Name = "layoutControlItemLegendMode"
            Me.layoutControlItemLegendMode.Size = New System.Drawing.Size(221, 108)
            Me.layoutControlItemLegendMode.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 426)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 115)
            ' 
            ' layoutControlGroupCrosshairContentMode
            ' 
            Me.layoutControlGroupCrosshairContentMode.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupCrosshairContentMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemCrosshairContentMode})
            Me.layoutControlGroupCrosshairContentMode.Location = New System.Drawing.Point(0, 324)
            Me.layoutControlGroupCrosshairContentMode.Name = "layoutControlGroupCrosshairContentMode"
            Me.layoutControlGroupCrosshairContentMode.Size = New System.Drawing.Size(241, 102)
            Me.layoutControlGroupCrosshairContentMode.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupCrosshairContentMode.Text = "Crosshair Content Mode"
            ' 
            ' layoutControlItemCrosshairContentMode
            ' 
            Me.layoutControlItemCrosshairContentMode.Control = Me.radioGroupCrosshairContentMode
            Me.layoutControlItemCrosshairContentMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemCrosshairContentMode.Name = "layoutControlItemCrosshairContentMode"
            Me.layoutControlItemCrosshairContentMode.Size = New System.Drawing.Size(221, 60)
            Me.layoutControlItemCrosshairContentMode.TextVisible = False
            ' 
            ' LegendsDemo
            ' 
            Me.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((128)))))), (CInt(((CByte((128)))))), (CInt(((CByte((255)))))))
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "LegendsDemo"
            Me.Size = New System.Drawing.Size(1006, 574)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupMarkerMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupLegendMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupCrosshairContentMode.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMarkerMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLegendMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLegendMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupCrosshairContentMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemCrosshairContentMode), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private radioGroupMarkerMode As DevExpress.XtraEditors.RadioGroup

        Private radioGroupLegendMode As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupMarkerMode As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemMarkerMode As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupLegendMode As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLegendMode As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private chart As DevExpress.XtraCharts.ChartControl

        Private radioGroupCrosshairContentMode As DevExpress.XtraEditors.RadioGroup

        Private layoutControlGroupCrosshairContentMode As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemCrosshairContentMode As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
