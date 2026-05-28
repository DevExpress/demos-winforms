Namespace DevExpress.XtraCharts.Demos

    Partial Class SecondaryAxesDemo

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
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {(CObj((40R)))})
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {(CObj((30R)))})
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {(CObj((25R)))})
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {(CObj((22.5R)))})
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {(CObj((21.25R)))})
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("A", New Object() {(CObj((1700R)))})
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("B", New Object() {(CObj((900R)))})
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("C", New Object() {(CObj((500R)))})
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("D", New Object() {(CObj((300R)))})
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("E", New Object() {(CObj((200R)))})
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("F", New Object() {(CObj((150R)))})
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("G", New Object() {(CObj((125R)))})
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.radioGroupChartType = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupSeries2AxisX = New DevExpress.XtraEditors.RadioGroup()
            Me.radioGroupSeries2AxisY = New DevExpress.XtraEditors.RadioGroup()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItemBottom = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupChartType = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemChartType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupSeries2AxisX = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeries2AxisX = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupSeries2AxisY = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSeries2AxisY = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.radioGroupChartType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupSeries2AxisX.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.radioGroupSeries2AxisY.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupChartType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemChartType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupSeries2AxisX), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeries2AxisX), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupSeries2AxisY), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSeries2AxisY), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "{A}"
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Title.Text = "Axis X"
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Interlaced = True
            xyDiagram1.AxisY.Title.Text = "Axis Y"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chart.Legend.Margins.Bottom = 10
            Me.chart.Legend.Margins.Left = 10
            Me.chart.Legend.Margins.Right = 10
            Me.chart.Legend.Margins.Top = 10
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Location = New System.Drawing.Point(0, 0)
            Me.chart.Margin = New System.Windows.Forms.Padding(0)
            Me.chart.Name = "chart"
            pointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
            pointSeriesLabel1.TextPattern = "{A}: {V}"
            series1.Label = pointSeriesLabel1
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5})
            series1.View = lineSeriesView1
            pointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.JustifyAroundPoint
            pointSeriesLabel2.TextPattern = "{A}: {V}"
            series2.Label = pointSeriesLabel2
            series2.Name = "Series 2"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12})
            lineSeriesView2.LineMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            series2.View = lineSeriesView2
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chart.Size = New System.Drawing.Size(546, 571)
            Me.chart.TabIndex = 2
            Me.chart.TabStop = False
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.radioGroupChartType)
            Me.layoutControl.Controls.Add(Me.radioGroupSeries2AxisX)
            Me.layoutControl.Controls.Add(Me.radioGroupSeries2AxisY)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' radioGroupChartType
            ' 
            Me.radioGroupChartType.AutoSizeInLayoutControl = True
            Me.radioGroupChartType.Location = New System.Drawing.Point(12, 31)
            Me.radioGroupChartType.Name = "radioGroupChartType"
            Me.radioGroupChartType.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupChartType.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupChartType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupChartType.Properties.Columns = 1
            Me.radioGroupChartType.Size = New System.Drawing.Size(217, 8)
            Me.radioGroupChartType.StyleController = Me.layoutControl
            Me.radioGroupChartType.TabIndex = 4
            AddHandler Me.radioGroupChartType.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupChartType_SelectedIndexChanged)
            ' 
            ' radioGroupSeries2AxisX
            ' 
            Me.radioGroupSeries2AxisX.AutoSizeInLayoutControl = True
            Me.radioGroupSeries2AxisX.Location = New System.Drawing.Point(12, 82)
            Me.radioGroupSeries2AxisX.Name = "radioGroupSeries2AxisX"
            Me.radioGroupSeries2AxisX.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupSeries2AxisX.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupSeries2AxisX.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupSeries2AxisX.Properties.Columns = 1
            Me.radioGroupSeries2AxisX.Size = New System.Drawing.Size(217, 8)
            Me.radioGroupSeries2AxisX.StyleController = Me.layoutControl
            Me.radioGroupSeries2AxisX.TabIndex = 5
            AddHandler Me.radioGroupSeries2AxisX.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupSeries2AxisX_SelectedIndexChanged)
            ' 
            ' radioGroupSeries2AxisY
            ' 
            Me.radioGroupSeries2AxisY.AutoSizeInLayoutControl = True
            Me.radioGroupSeries2AxisY.Location = New System.Drawing.Point(12, 133)
            Me.radioGroupSeries2AxisY.Name = "radioGroupSeries2AxisY"
            Me.radioGroupSeries2AxisY.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.radioGroupSeries2AxisY.Properties.Appearance.Options.UseBackColor = True
            Me.radioGroupSeries2AxisY.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.radioGroupSeries2AxisY.Properties.Columns = 1
            Me.radioGroupSeries2AxisY.Size = New System.Drawing.Size(217, 8)
            Me.radioGroupSeries2AxisY.StyleController = Me.layoutControl
            Me.radioGroupSeries2AxisY.TabIndex = 6
            AddHandler Me.radioGroupSeries2AxisY.SelectedIndexChanged, New System.EventHandler(AddressOf Me.radioGroupSeries2AxisY_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItemBottom, Me.layoutControlGroupChartType, Me.layoutControlGroupSeries2AxisX, Me.layoutControlGroupSeries2AxisY})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' emptySpaceItemBottom
            ' 
            Me.emptySpaceItemBottom.AllowHotTrack = False
            Me.emptySpaceItemBottom.Location = New System.Drawing.Point(0, 153)
            Me.emptySpaceItemBottom.Name = "emptySpaceItem1"
            Me.emptySpaceItemBottom.Size = New System.Drawing.Size(241, 391)
            Me.emptySpaceItemBottom.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupChartType
            ' 
            Me.layoutControlGroupChartType.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupChartType.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemChartType})
            Me.layoutControlGroupChartType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupChartType.Name = "layoutControlGroupChartType"
            Me.layoutControlGroupChartType.Size = New System.Drawing.Size(241, 51)
            Me.layoutControlGroupChartType.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupChartType.Text = "Chart Type"
            ' 
            ' layoutControlItemChartType
            ' 
            Me.layoutControlItemChartType.Control = Me.radioGroupChartType
            Me.layoutControlItemChartType.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemChartType.Name = "layoutControlItemChartType"
            Me.layoutControlItemChartType.Size = New System.Drawing.Size(221, 12)
            Me.layoutControlItemChartType.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemChartType.TextVisible = False
            ' 
            ' layoutControlGroupSeries2AxisX
            ' 
            Me.layoutControlGroupSeries2AxisX.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupSeries2AxisX.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeries2AxisX})
            Me.layoutControlGroupSeries2AxisX.Location = New System.Drawing.Point(0, 51)
            Me.layoutControlGroupSeries2AxisX.Name = "layoutControlGroupSeries2AxisX"
            Me.layoutControlGroupSeries2AxisX.Size = New System.Drawing.Size(241, 51)
            Me.layoutControlGroupSeries2AxisX.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupSeries2AxisX.Text = "Series 2 Axis X"
            ' 
            ' layoutControlItemSeries2AxisX
            ' 
            Me.layoutControlItemSeries2AxisX.Control = Me.radioGroupSeries2AxisX
            Me.layoutControlItemSeries2AxisX.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeries2AxisX.Name = "layoutControlItemSeries2AxisX"
            Me.layoutControlItemSeries2AxisX.Size = New System.Drawing.Size(221, 12)
            Me.layoutControlItemSeries2AxisX.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemSeries2AxisX.TextVisible = False
            ' 
            ' layoutControlGroupSeries2AxisY
            ' 
            Me.layoutControlGroupSeries2AxisY.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupSeries2AxisY.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSeries2AxisY})
            Me.layoutControlGroupSeries2AxisY.Location = New System.Drawing.Point(0, 102)
            Me.layoutControlGroupSeries2AxisY.Name = "layoutControlGroupSeries2AxisY"
            Me.layoutControlGroupSeries2AxisY.Size = New System.Drawing.Size(241, 51)
            Me.layoutControlGroupSeries2AxisY.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupSeries2AxisY.Text = "Series 2 Axis Y"
            ' 
            ' layoutControlItemSeries2AxisY
            ' 
            Me.layoutControlItemSeries2AxisY.Control = Me.radioGroupSeries2AxisY
            Me.layoutControlItemSeries2AxisY.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSeries2AxisY.Name = "layoutControlItemSeries2AxisY"
            Me.layoutControlItemSeries2AxisY.Size = New System.Drawing.Size(221, 12)
            Me.layoutControlItemSeries2AxisY.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemSeries2AxisY.TextVisible = False
            ' 
            ' SecondaryAxesDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Name = "SecondaryAxesDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.chart, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.radioGroupChartType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupSeries2AxisX.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.radioGroupSeries2AxisY.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItemBottom), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupChartType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemChartType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupSeries2AxisX), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeries2AxisX), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupSeries2AxisY), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSeries2AxisY), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private radioGroupChartType As DevExpress.XtraEditors.RadioGroup

        Private radioGroupSeries2AxisX As DevExpress.XtraEditors.RadioGroup

        Private radioGroupSeries2AxisY As DevExpress.XtraEditors.RadioGroup

        Private layoutControlItemChartType As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemSeries2AxisX As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemSeries2AxisY As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItemBottom As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupChartType As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupSeries2AxisX As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupSeries2AxisY As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
