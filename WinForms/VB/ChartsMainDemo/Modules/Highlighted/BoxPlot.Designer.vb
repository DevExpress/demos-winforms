Namespace DevExpress.XtraCharts.Demos

    Partial Class BoxPlotDemo

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
            Dim layoutDefinition1 As DevExpress.XtraCharts.LayoutDefinition = New DevExpress.XtraCharts.LayoutDefinition()
            Dim layoutDefinition2 As DevExpress.XtraCharts.LayoutDefinition = New DevExpress.XtraCharts.LayoutDefinition()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisX1 As DevExpress.XtraCharts.SecondaryAxisX = New DevExpress.XtraCharts.SecondaryAxisX()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember5 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember6 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember7 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember8 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim boxPlotSeriesView1 As DevExpress.XtraCharts.BoxPlotSeriesView = New DevExpress.XtraCharts.BoxPlotSeriesView()
            Dim boxPlotSlideAnimation1 As DevExpress.XtraCharts.BoxPlotSlideAnimation = New DevExpress.XtraCharts.BoxPlotSlideAnimation()
            Dim xySeriesUnwindAnimation1 As DevExpress.XtraCharts.XYSeriesUnwindAnimation = New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter2 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember9 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember10 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember11 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember12 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember13 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember14 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember15 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember16 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim boxPlotSeriesView2 As DevExpress.XtraCharts.BoxPlotSeriesView = New DevExpress.XtraCharts.BoxPlotSeriesView()
            Dim boxPlotSlideAnimation2 As DevExpress.XtraCharts.BoxPlotSlideAnimation = New DevExpress.XtraCharts.BoxPlotSlideAnimation()
            Dim xySeriesUnwindAnimation2 As DevExpress.XtraCharts.XYSeriesUnwindAnimation = New DevExpress.XtraCharts.XYSeriesUnwindAnimation()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter3 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember17 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember18 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesView1 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim xyMarkerWidenAnimation1 As DevExpress.XtraCharts.XYMarkerWidenAnimation = New DevExpress.XtraCharts.XYMarkerWidenAnimation()
            Dim quadraticEasingFunction1 As DevExpress.XtraCharts.QuadraticEasingFunction = New DevExpress.XtraCharts.QuadraticEasingFunction()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter4 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember19 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember20 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim pointSeriesView2 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim xyMarkerWidenAnimation2 As DevExpress.XtraCharts.XYMarkerWidenAnimation = New DevExpress.XtraCharts.XYMarkerWidenAnimation()
            Dim quadraticEasingFunction2 As DevExpress.XtraCharts.QuadraticEasingFunction = New DevExpress.XtraCharts.QuadraticEasingFunction()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanel1 = New DevExpress.XtraEditors.SidePanel()
            Me.boxPlotChart = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.cheShowMeanLine = New DevExpress.XtraEditors.CheckEdit()
            Me.sbGenerate = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupMarkerMode = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.sidePanel1.SuspendLayout()
            CType((Me.boxPlotChart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisX1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((boxPlotSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((boxPlotSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.cheShowMeanLine.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMarkerMode), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl1)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.Root = Me.layoutControlGroup1
            Me.layoutControl.Size = New System.Drawing.Size(241, 542)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.emptySpaceItem1})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(241, 542)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(221, 522)
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' sidePanel1
            ' 
            Me.sidePanel1.Controls.Add(Me.boxPlotChart)
            Me.sidePanel1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.sidePanel1.Location = New System.Drawing.Point(0, 0)
            Me.sidePanel1.Name = "sidePanel1"
            Me.sidePanel1.Size = New System.Drawing.Size(546, 571)
            Me.sidePanel1.TabIndex = 5
            Me.sidePanel1.Text = "sidePanel1"
            ' 
            ' boxPlotChart
            ' 
            Me.boxPlotChart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisX.Label.TextPattern = "Experiment {V}"
            xyDiagram1.AxisX.LabelVisibilityMode = DevExpress.XtraCharts.AxisLabelVisibilityMode.AutoGeneratedAndCustom
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.Tickmarks.MinorVisible = False
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DefaultPane.RuntimeCollapse = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.DefaultPane.ScrollBarOptions.XAxisAnnotationOptions.ShowStrips = False
            xyDiagram1.DefaultPane.Title.Text = "Experiment History"
            xyDiagram1.DefaultPane.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.PaneLayout.AutoLayoutMode = DevExpress.XtraCharts.PaneAutoLayoutMode.Grid
            layoutDefinition1.Weight = 5R
            layoutDefinition2.SizeInPixels = 200
            layoutDefinition2.SizeMode = DevExpress.XtraCharts.PaneSizeMode.UseSizeInPixels
            xyDiagram1.PaneLayout.ColumnDefinitions.AddRange(New DevExpress.XtraCharts.LayoutDefinition() {layoutDefinition1, layoutDefinition2})
            xyDiagram1.PaneLayout.Direction = DevExpress.XtraCharts.PaneLayoutDirection.Horizontal
            xyDiagramPane1.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagramPane1.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagramPane1.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagramPane1.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane1.RuntimeCollapse = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagramPane1.Title.Text = "Current Experiment"
            xyDiagramPane1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1})
            secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisX1.AxisID = 0
            secondaryAxisX1.Label.Visible = False
            secondaryAxisX1.Name = "Secondary AxisX 1"
            secondaryAxisX1.Tickmarks.MinorVisible = False
            secondaryAxisX1.Tickmarks.Visible = False
            secondaryAxisX1.Title.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point)
            secondaryAxisX1.Title.Text = "Measurment Set 1"
            secondaryAxisX1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[Default]
            secondaryAxisX1.Title.WordWrap = True
            secondaryAxisX1.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisX1.VisibleInPanesSerializable = "0"
            secondaryAxisX1.WholeRange.Auto = False
            secondaryAxisX1.WholeRange.MaxValueSerializable = "4"
            secondaryAxisX1.WholeRange.MinValueSerializable = "-1"
            xyDiagram1.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() {secondaryAxisX1})
            Me.boxPlotChart.Diagram = xyDiagram1
            Me.boxPlotChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.boxPlotChart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.boxPlotChart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.boxPlotChart.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.boxPlotChart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.boxPlotChart.Legend.HorizontalIndent = 10
            Me.boxPlotChart.Legend.Name = "Default Legend"
            Me.boxPlotChart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.boxPlotChart.Location = New System.Drawing.Point(0, 0)
            Me.boxPlotChart.Name = "boxPlotChart"
            series1.CrosshairLabelPattern = "Minimum:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_Min: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Quartile 1:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_Q1: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Median:" & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_MDN: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Average:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_" & "AVG: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Quartile 3:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_Q3: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Maximum:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_MAX: 0.}"
            dataMember1.ColumnName = "ExperimentNumber"
            dataMember2.ColumnName = "Min"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMin
            dataMember3.ColumnName = "Quartile1"
            dataMember3.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotQuartile_1
            dataMember4.ColumnName = "Median"
            dataMember4.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMedian
            dataMember5.ColumnName = "Quartile3"
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotQuartile_3
            dataMember6.ColumnName = "Max"
            dataMember6.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMax
            dataMember7.ColumnName = "Mean"
            dataMember7.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMean
            dataMember8.ColumnName = "Outliers"
            dataMember8.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotOutliers
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2, dataMember3, dataMember4, dataMember5, dataMember6, dataMember7, dataMember8})
            series1.DataAdapter = dataSourceAdapter1
            series1.Name = "Data Set 1"
            boxPlotSlideAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop
            boxPlotSlideAnimation1.Duration = System.TimeSpan.Parse("00:00:00.8000000")
            boxPlotSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            boxPlotSeriesView1.Animation = boxPlotSlideAnimation1
            boxPlotSeriesView1.MeanLineAnimation = xySeriesUnwindAnimation1
            series1.View = boxPlotSeriesView1
            series2.CrosshairLabelPattern = "Minimum:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_Min: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Quartile 1:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_Q1: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Median:" & Global.Microsoft.VisualBasic.Constants.vbTab & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_MDN: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Average:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_" & "AVG: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Quartile 3:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_Q3: 0.}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Maximum:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{BP_MAX: 0.}"
            dataMember9.ColumnName = "ExperimentNumber"
            dataMember10.ColumnName = "Min"
            dataMember10.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMin
            dataMember11.ColumnName = "Quartile1"
            dataMember11.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotQuartile_1
            dataMember12.ColumnName = "Mean"
            dataMember12.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMean
            dataMember13.ColumnName = "Quartile3"
            dataMember13.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotQuartile_3
            dataMember14.ColumnName = "Max"
            dataMember14.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMax
            dataMember15.ColumnName = "Median"
            dataMember15.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotMedian
            dataMember16.ColumnName = "Outliers"
            dataMember16.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.BoxPlotOutliers
            dataSourceAdapter2.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember9, dataMember10, dataMember11, dataMember12, dataMember13, dataMember14, dataMember15, dataMember16})
            series2.DataAdapter = dataSourceAdapter2
            series2.Name = "Data Set 2"
            boxPlotSlideAnimation2.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop
            boxPlotSlideAnimation2.Duration = System.TimeSpan.Parse("00:00:00.8000000")
            boxPlotSlideAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            boxPlotSeriesView2.Animation = boxPlotSlideAnimation2
            boxPlotSeriesView2.MeanLineAnimation = xySeriesUnwindAnimation2
            series2.View = boxPlotSeriesView2
            series3.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            dataMember17.ColumnName = "Argument"
            dataMember18.ColumnName = "Value"
            dataMember18.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter3.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember17, dataMember18})
            series3.DataAdapter = dataSourceAdapter3
            series3.Name = "Series 1"
            series3.ShowInLegend = False
            pointSeriesView1.AxisXName = "Secondary AxisX 1"
            pointSeriesView1.PaneName = "Pane 1"
            pointSeriesView1.PointMarkerOptions.BorderVisible = False
            xyMarkerWidenAnimation1.Duration = System.TimeSpan.Parse("00:00:00.2000000")
            xyMarkerWidenAnimation1.EasingFunction = quadraticEasingFunction1
            xyMarkerWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.0010000")
            xyMarkerWidenAnimation1.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
            pointSeriesView1.SeriesPointAnimation = xyMarkerWidenAnimation1
            series3.View = pointSeriesView1
            series4.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            dataMember19.ColumnName = "Argument"
            dataMember20.ColumnName = "Value"
            dataMember20.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter4.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember19, dataMember20})
            series4.DataAdapter = dataSourceAdapter4
            series4.Name = "Series 2"
            series4.ShowInLegend = False
            pointSeriesView2.AxisXName = "Secondary AxisX 1"
            pointSeriesView2.PaneName = "Pane 1"
            pointSeriesView2.PointMarkerOptions.BorderVisible = False
            xyMarkerWidenAnimation2.Duration = System.TimeSpan.Parse("00:00:00.2000000")
            xyMarkerWidenAnimation2.EasingFunction = quadraticEasingFunction2
            xyMarkerWidenAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.0010000")
            xyMarkerWidenAnimation2.PointOrder = DevExpress.XtraCharts.PointAnimationOrder.Random
            pointSeriesView2.SeriesPointAnimation = xyMarkerWidenAnimation2
            series4.View = pointSeriesView2
            Me.boxPlotChart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4}
            Me.boxPlotChart.Size = New System.Drawing.Size(546, 571)
            Me.boxPlotChart.TabIndex = 4
            chartTitle1.Text = "Experiment Results"
            Me.boxPlotChart.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.boxPlotChart.AnimationEnded, New DevExpress.XtraCharts.AnimationEndedEventHandler(AddressOf Me.BoxPlotChart_AnimationEnded)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.cheShowMeanLine)
            Me.layoutControl1.Controls.Add(Me.sbGenerate)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(244, 313, 650, 400)
            Me.layoutControl1.Root = Me.layoutControlGroupRoot
            Me.layoutControl1.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' cheShowMeanLine
            ' 
            Me.cheShowMeanLine.Location = New System.Drawing.Point(12, 34)
            Me.cheShowMeanLine.Name = "cheShowMeanLine"
            Me.cheShowMeanLine.Properties.Caption = "Show Mean Line"
            Me.cheShowMeanLine.Size = New System.Drawing.Size(217, 20)
            Me.cheShowMeanLine.StyleController = Me.layoutControl1
            Me.cheShowMeanLine.TabIndex = 4
            AddHandler Me.cheShowMeanLine.CheckedChanged, New System.EventHandler(AddressOf Me.cheShowMeanLine_CheckedChanged)
            ' 
            ' sbGenerate
            ' 
            Me.sbGenerate.Location = New System.Drawing.Point(12, 72)
            Me.sbGenerate.Name = "sbGenerate"
            Me.sbGenerate.Size = New System.Drawing.Size(217, 22)
            Me.sbGenerate.StyleController = Me.layoutControl1
            Me.sbGenerate.TabIndex = 5
            Me.sbGenerate.Text = "Add New Data Set"
            AddHandler Me.sbGenerate.Click, New System.EventHandler(AddressOf Me.BtnGenerate_Click)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[False]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupMarkerMode, Me.emptySpaceItem})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupMarkerMode
            ' 
            Me.layoutControlGroupMarkerMode.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMarkerMode.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem2})
            Me.layoutControlGroupMarkerMode.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupMarkerMode.Name = "layoutControlGroupMarkerMode"
            Me.layoutControlGroupMarkerMode.Size = New System.Drawing.Size(241, 106)
            Me.layoutControlGroupMarkerMode.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMarkerMode.Text = "General "
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cheShowMeanLine
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.sbGenerate
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 38)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(221, 26)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.AllowHotTrack = False
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 14)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(10, 14)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(221, 14)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 106)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 432)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' BoxPlotDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.sidePanel1)
            Me.Name = "BoxPlotDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.Controls.SetChildIndex(Me.sidePanel1, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.sidePanel1.ResumeLayout(False)
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisX1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((boxPlotSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((boxPlotSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.boxPlotChart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.cheShowMeanLine.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMarkerMode), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private sidePanel1 As DevExpress.XtraEditors.SidePanel

        Private boxPlotChart As DevExpress.XtraCharts.ChartControl

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private cheShowMeanLine As DevExpress.XtraEditors.CheckEdit

        Private sbGenerate As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupMarkerMode As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
