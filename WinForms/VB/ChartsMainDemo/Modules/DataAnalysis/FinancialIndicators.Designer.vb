Namespace DevExpress.XtraCharts.Demos

    Partial Class FinancialIndicatorsDemo

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
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane2 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane3 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane4 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY3 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY4 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim constantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
            Dim constantLine2 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend2 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend3 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend4 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stockSeriesView1 As DevExpress.XtraCharts.StockSeriesView = New DevExpress.XtraCharts.StockSeriesView()
            Dim averageTrueRange1 As DevExpress.XtraCharts.AverageTrueRange = New DevExpress.XtraCharts.AverageTrueRange()
            Dim chaikinsVolatility1 As DevExpress.XtraCharts.ChaikinsVolatility = New DevExpress.XtraCharts.ChaikinsVolatility()
            Dim movingAverageConvergenceDivergence1 As DevExpress.XtraCharts.MovingAverageConvergenceDivergence = New DevExpress.XtraCharts.MovingAverageConvergenceDivergence()
            Dim williamsR1 As DevExpress.XtraCharts.WilliamsR = New DevExpress.XtraCharts.WilliamsR()
            Dim chartIntervalItem1 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem2 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem3 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem4 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem5 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem6 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.chartOptionsBar1 = New DevExpress.XtraCharts.UI.ChartFinancialIndicatorsBar()
            Me.trendLineBarCheckItem = New DevExpress.XtraCharts.UI.DrawTrendLineIndicatorBarItem()
            Me.fibbArcBarCheckItem = New DevExpress.XtraCharts.UI.DrawFibonacciArcsIndicatorBarItem()
            Me.fibbFansBarCheckItem = New DevExpress.XtraCharts.UI.DrawFibonacciFansIndicatorBarItem()
            Me.fibbRetrBarCheckItem = New DevExpress.XtraCharts.UI.DrawFibonacciRetracementIndicatorBarItem()
            Me.removeBarCheckItem = New DevExpress.XtraCharts.UI.RemoveIndicatorBarItem()
            Me.addChartIndicatorBarItem1 = New DevExpress.XtraCharts.UI.AddIndicatorBarItem()
            Me.commandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.chartAnnotationsBar1 = New DevExpress.XtraCharts.UI.ChartAnnotationsBar()
            Me.addTextAnnotationBarItem = New DevExpress.XtraCharts.UI.AddTextAnnotationBarItem()
            Me.addImageAnnotationBarItem = New DevExpress.XtraCharts.UI.AddImageAnnotationBarItem()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.selectSeriesRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectSeriesRepositoryItemComboBox()
            Me.changeSeriesViewRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox()
            Me.selectAxisMeasureUnitRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectAxisMeasureUnitRepositoryItemComboBox()
            Me.selectPeriodRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectPeriodRepositoryItemComboBox()
            Me.chartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController(Me.components)
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((constantLine1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((constantLine2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((averageTrueRange1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((chaikinsVolatility1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((movingAverageConvergenceDivergence1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((williamsR1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectSeriesRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.changeSeriesViewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectAxisMeasureUnitRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectPeriodRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
            Me.chart.CrosshairOptions.ShowOutOfRangePoints = True
            xyDiagram1.AxisX.DateTimeScaleOptions.WorkdaysOnly = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.MinorCount = 5
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "3"
            xyDiagram1.AxisX.VisualRange.Auto = False
            xyDiagram1.AxisX.VisualRange.AutoSideMargins = False
            xyDiagram1.AxisX.VisualRange.EndSideMargin = 0R
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "02/14/2020 00:00:00.000"
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "02/05/2020 00:00:00.000"
            xyDiagram1.AxisX.VisualRange.StartSideMargin = 0R
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 5R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 5R
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DefaultPane.LayoutOptions.RowSpan = 100
            xyDiagram1.DefaultPane.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagramPane1.LayoutOptions.RowSpan = 50
            xyDiagramPane1.Name = "atrPane"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane1.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane1.Tag = "AverageTrueRange"
            xyDiagramPane2.LayoutOptions.RowSpan = 50
            xyDiagramPane2.Name = "chvPane"
            xyDiagramPane2.PaneID = 1
            xyDiagramPane2.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane2.Tag = "ChaikinsVolatility"
            xyDiagramPane3.LayoutOptions.RowSpan = 50
            xyDiagramPane3.Name = "macdPane"
            xyDiagramPane3.PaneID = 2
            xyDiagramPane3.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane3.Tag = "MovingAverageConvergenceDivergence"
            xyDiagramPane4.LayoutOptions.RowSpan = 50
            xyDiagramPane4.Name = "wrPane"
            xyDiagramPane4.PaneID = 3
            xyDiagramPane4.Tag = "WilliamsR"
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1, xyDiagramPane2, xyDiagramPane3, xyDiagramPane4})
            xyDiagram1.RuntimePaneResize = True
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.Name = "atrAxisY"
            secondaryAxisY1.Tag = "AverageTrueRange"
            secondaryAxisY1.Title.Text = "ATR"
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.Name = "chVAxisY"
            secondaryAxisY2.Tag = "ChaikinsVolatility"
            secondaryAxisY2.Title.Text = "CHV"
            secondaryAxisY2.VisibleInPanesSerializable = "1"
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY3.AxisID = 2
            secondaryAxisY3.Name = "macdAxisY"
            secondaryAxisY3.Tag = "MovingAverageConvergenceDivergence"
            secondaryAxisY3.Title.Text = "MACD"
            secondaryAxisY3.VisibleInPanesSerializable = "2"
            secondaryAxisY3.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY4.AxisID = 3
            constantLine1.AxisValueSerializable = "-80"
            constantLine1.Name = "-80"
            constantLine1.ShowInLegend = False
            constantLine1.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far
            constantLine1.Title.ShowBelowLine = True
            constantLine2.AxisValueSerializable = "-20"
            constantLine2.Name = "-20"
            constantLine2.ShowInLegend = False
            constantLine2.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far
            secondaryAxisY4.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {constantLine1, constantLine2})
            secondaryAxisY4.Name = "wrAxisY"
            secondaryAxisY4.Tag = "WilliamsR"
            secondaryAxisY4.Title.Text = "%R"
            secondaryAxisY4.VisibleInPanesSerializable = "3"
            secondaryAxisY4.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY4.WholeRange.Auto = False
            secondaryAxisY4.WholeRange.MaxValueSerializable = "50"
            secondaryAxisY4.WholeRange.MinValueSerializable = "-150"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2, secondaryAxisY3, secondaryAxisY4})
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.DockTargetName = "Default Pane"
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend1.DockTargetName = "atrPane"
            legend1.Name = "atrLegend"
            legend1.Tag = "AverageTrueRange"
            legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend2.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend2.DockTargetName = "chvPane"
            legend2.Name = "chvLegend"
            legend2.Tag = "ChaikinsVolatility"
            legend3.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend3.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend3.DockTargetName = "wrPane"
            legend3.Name = "wrLegend"
            legend3.Tag = "WilliamsR"
            legend4.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend4.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend4.DockTargetName = "macdPane"
            legend4.Name = "macdLegend"
            legend4.Tag = "MovingAverageConvergenceDivergence"
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1, legend2, legend3, legend4})
            Me.chart.Location = New System.Drawing.Point(0, 24)
            Me.chart.Name = "chart"
            series1.ArgumentDataMember = "DateTimeStamp"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.Name = "USDJPU"
            series1.ValueDataMembersSerializable = "Low;High;Open;Close"
            averageTrueRange1.AxisYName = "atrAxisY"
            averageTrueRange1.LegendName = "atrLegend"
            averageTrueRange1.LegendText = "ATR (14)"
            averageTrueRange1.Name = "Average True Range"
            averageTrueRange1.PaneName = "atrPane"
            averageTrueRange1.ShowInLegend = True
            averageTrueRange1.Tag = "AverageTrueRange"
            chaikinsVolatility1.AxisYName = "chVAxisY"
            chaikinsVolatility1.LegendName = "chvLegend"
            chaikinsVolatility1.LegendText = "CHV (10)"
            chaikinsVolatility1.Name = "Chaikin's Volatility"
            chaikinsVolatility1.PaneName = "chvPane"
            chaikinsVolatility1.ShowInLegend = True
            chaikinsVolatility1.Tag = "ChaikinsVolatility"
            movingAverageConvergenceDivergence1.AxisYName = "macdAxisY"
            movingAverageConvergenceDivergence1.LegendName = "macdLegend"
            movingAverageConvergenceDivergence1.LegendText = "MACD (12, 26, 9)"
            movingAverageConvergenceDivergence1.Name = "Moving Average Convergence/Divergence"
            movingAverageConvergenceDivergence1.PaneName = "macdPane"
            movingAverageConvergenceDivergence1.ShowInLegend = True
            movingAverageConvergenceDivergence1.SignalLineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash
            movingAverageConvergenceDivergence1.Tag = "MovingAverageConvergenceDivergence"
            williamsR1.AxisYName = "wrAxisY"
            williamsR1.LegendName = "wrLegend"
            williamsR1.LegendText = "%R (14)"
            williamsR1.Name = "Williams %R"
            williamsR1.PaneName = "wrPane"
            williamsR1.ShowInLegend = True
            williamsR1.Tag = "WilliamsR"
            stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {averageTrueRange1, chaikinsVolatility1, movingAverageConvergenceDivergence1, williamsR1})
            stockSeriesView1.LineThickness = 1
            series1.View = stockSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chart.Size = New System.Drawing.Size(788, 654)
            Me.chart.TabIndex = 1
            AddHandler Me.chart.BeforeZoom, New DevExpress.XtraCharts.ChartBeforeZoomEventHandler(AddressOf Me.chart_BeforeZoom)
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            AddHandler Me.chart.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.chart_MouseUp)
            ' 
            ' barManager1
            ' 
            Me.barManager1.AllowCustomization = False
            Me.barManager1.AllowMoveBarOnToolbar = False
            Me.barManager1.AllowQuickCustomization = False
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.chartOptionsBar1, Me.chartAnnotationsBar1})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.trendLineBarCheckItem, Me.fibbArcBarCheckItem, Me.fibbFansBarCheckItem, Me.fibbRetrBarCheckItem, Me.addChartIndicatorBarItem1, Me.removeBarCheckItem, Me.addTextAnnotationBarItem, Me.addImageAnnotationBarItem})
            Me.barManager1.MaxItemId = 52
            Me.barManager1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.selectSeriesRepositoryItemComboBox1, Me.changeSeriesViewRepositoryItemComboBox1, Me.selectAxisMeasureUnitRepositoryItemComboBox1, Me.selectPeriodRepositoryItemComboBox1})
            ' 
            ' chartOptionsBar1
            ' 
            Me.chartOptionsBar1.Control = Me.chart
            Me.chartOptionsBar1.DockCol = 0
            Me.chartOptionsBar1.DockRow = 0
            Me.chartOptionsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartOptionsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.trendLineBarCheckItem), New DevExpress.XtraBars.LinkPersistInfo(Me.fibbArcBarCheckItem), New DevExpress.XtraBars.LinkPersistInfo(Me.fibbFansBarCheckItem), New DevExpress.XtraBars.LinkPersistInfo(Me.fibbRetrBarCheckItem), New DevExpress.XtraBars.LinkPersistInfo(Me.removeBarCheckItem), New DevExpress.XtraBars.LinkPersistInfo(Me.addChartIndicatorBarItem1, True)})
            Me.chartOptionsBar1.OptionsBar.AllowQuickCustomization = False
            Me.chartOptionsBar1.OptionsBar.DisableClose = True
            Me.chartOptionsBar1.OptionsBar.DisableCustomization = True
            Me.chartOptionsBar1.OptionsBar.DrawDragBorder = False
            ' 
            ' trendLineBarCheckItem
            ' 
            Me.trendLineBarCheckItem.Id = 30
            Me.trendLineBarCheckItem.Name = "trendLineBarCheckItem"
            AddHandler Me.trendLineBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' fibbArcBarCheckItem
            ' 
            Me.fibbArcBarCheckItem.Id = 31
            Me.fibbArcBarCheckItem.Name = "fibbArcBarCheckItem"
            AddHandler Me.fibbArcBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' fibbFansBarCheckItem
            ' 
            Me.fibbFansBarCheckItem.Id = 32
            Me.fibbFansBarCheckItem.Name = "fibbFansBarCheckItem"
            AddHandler Me.fibbFansBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' fibbRetrBarCheckItem
            ' 
            Me.fibbRetrBarCheckItem.Id = 33
            Me.fibbRetrBarCheckItem.Name = "fibbRetrBarCheckItem"
            AddHandler Me.fibbRetrBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' removeBarCheckItem
            ' 
            Me.removeBarCheckItem.Id = 35
            Me.removeBarCheckItem.Name = "removeBarCheckItem"
            AddHandler Me.removeBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' addChartIndicatorBarItem1
            ' 
            Me.addChartIndicatorBarItem1.DropDownControl = Me.commandBarGalleryDropDown10
            Me.addChartIndicatorBarItem1.Id = 34
            Me.addChartIndicatorBarItem1.Name = "addChartIndicatorBarItem1"
            ' 
            ' commandBarGalleryDropDown10
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown10.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown10.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown10.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown10.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown10.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown10.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown10.Gallery.ShowItemImage = False
            Me.commandBarGalleryDropDown10.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown10.Manager = Me.barManager1
            Me.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10"
            ' 
            ' chartAnnotationsBar1
            ' 
            Me.chartAnnotationsBar1.Control = Me.chart
            Me.chartAnnotationsBar1.DockCol = 1
            Me.chartAnnotationsBar1.DockRow = 0
            Me.chartAnnotationsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartAnnotationsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addTextAnnotationBarItem), New DevExpress.XtraBars.LinkPersistInfo(Me.addImageAnnotationBarItem)})
            ' 
            ' addTextAnnotationBarItem
            ' 
            Me.addTextAnnotationBarItem.Id = 49
            Me.addTextAnnotationBarItem.Name = "addTextAnnotationBarItem"
            ' 
            ' addImageAnnotationBarItem
            ' 
            Me.addImageAnnotationBarItem.Id = 50
            Me.addImageAnnotationBarItem.Name = "addImageAnnotationBarItem"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Manager = Me.barManager1
            Me.barDockControlTop.Size = New System.Drawing.Size(788, 24)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 678)
            Me.barDockControlBottom.Manager = Me.barManager1
            Me.barDockControlBottom.Size = New System.Drawing.Size(788, 0)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 24)
            Me.barDockControlLeft.Manager = Me.barManager1
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 654)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(788, 24)
            Me.barDockControlRight.Manager = Me.barManager1
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 654)
            ' 
            ' selectSeriesRepositoryItemComboBox1
            ' 
            Me.selectSeriesRepositoryItemComboBox1.AutoHeight = False
            Me.selectSeriesRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.selectSeriesRepositoryItemComboBox1.Items.AddRange(New Object() {"USDJPU"})
            Me.selectSeriesRepositoryItemComboBox1.Name = "selectSeriesRepositoryItemComboBox1"
            Me.selectSeriesRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' changeSeriesViewRepositoryItemComboBox1
            ' 
            Me.changeSeriesViewRepositoryItemComboBox1.AutoHeight = False
            Me.changeSeriesViewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.changeSeriesViewRepositoryItemComboBox1.Items.AddRange(New Object() {DevExpress.XtraCharts.ViewType.Stock, DevExpress.XtraCharts.ViewType.CandleStick, DevExpress.XtraCharts.ViewType.Area, DevExpress.XtraCharts.ViewType.Line, DevExpress.XtraCharts.ViewType.Bar})
            Me.changeSeriesViewRepositoryItemComboBox1.Name = "changeSeriesViewRepositoryItemComboBox1"
            Me.changeSeriesViewRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' selectAxisMeasureUnitRepositoryItemComboBox1
            ' 
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.AutoHeight = False
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            chartIntervalItem1.Caption = "1 day"
            chartIntervalItem1.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Day
            chartIntervalItem2.Caption = "1 week"
            chartIntervalItem2.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Week
            chartIntervalItem3.Caption = "1 month"
            chartIntervalItem3.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Items.AddRange(New Object() {chartIntervalItem1, chartIntervalItem2, chartIntervalItem3})
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Name = "selectAxisMeasureUnitRepositoryItemComboBox1"
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' selectPeriodRepositoryItemComboBox1
            ' 
            Me.selectPeriodRepositoryItemComboBox1.AutoHeight = False
            Me.selectPeriodRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            chartIntervalItem4.Caption = "6 month"
            chartIntervalItem4.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            chartIntervalItem4.MeasureUnitMultiplier = 6
            chartIntervalItem5.Caption = "1 year"
            chartIntervalItem5.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            chartIntervalItem6.Caption = "2 year"
            chartIntervalItem6.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            chartIntervalItem6.MeasureUnitMultiplier = 2
            Me.selectPeriodRepositoryItemComboBox1.Items.AddRange(New Object() {chartIntervalItem4, chartIntervalItem5, chartIntervalItem6})
            Me.selectPeriodRepositoryItemComboBox1.Name = "selectPeriodRepositoryItemComboBox1"
            Me.selectPeriodRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' chartBarController1
            ' 
            Me.chartBarController1.BarItems.Add(Me.trendLineBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.fibbArcBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.fibbFansBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.fibbRetrBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.addChartIndicatorBarItem1)
            Me.chartBarController1.BarItems.Add(Me.removeBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.addTextAnnotationBarItem)
            Me.chartBarController1.BarItems.Add(Me.addImageAnnotationBarItem)
            Me.chartBarController1.Control = Me.chart
            ' 
            ' FinancialIndicatorsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "FinancialIndicatorsDemo"
            Me.Size = New System.Drawing.Size(788, 678)
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((constantLine1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((constantLine2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((averageTrueRange1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((chaikinsVolatility1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((movingAverageConvergenceDivergence1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((williamsR1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectSeriesRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.changeSeriesViewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectAxisMeasureUnitRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectPeriodRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private chart As DevExpress.XtraCharts.ChartControl

        Private barManager1 As DevExpress.XtraBars.BarManager

        Private chartOptionsBar1 As DevExpress.XtraCharts.UI.ChartFinancialIndicatorsBar

        Private addChartIndicatorBarItem1 As DevExpress.XtraCharts.UI.AddIndicatorBarItem

        Private commandBarGalleryDropDown10 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private barDockControlTop As DevExpress.XtraBars.BarDockControl

        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl

        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl

        Private barDockControlRight As DevExpress.XtraBars.BarDockControl

        Private chartBarController1 As DevExpress.XtraCharts.UI.ChartBarController

        Private trendLineBarCheckItem As DevExpress.XtraCharts.UI.DrawTrendLineIndicatorBarItem

        Private fibbArcBarCheckItem As DevExpress.XtraCharts.UI.DrawFibonacciArcsIndicatorBarItem

        Private fibbFansBarCheckItem As DevExpress.XtraCharts.UI.DrawFibonacciFansIndicatorBarItem

        Private fibbRetrBarCheckItem As DevExpress.XtraCharts.UI.DrawFibonacciRetracementIndicatorBarItem

        Private removeBarCheckItem As DevExpress.XtraCharts.UI.RemoveIndicatorBarItem

        Private changeSeriesViewRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox

        Private chartAnnotationsBar1 As DevExpress.XtraCharts.UI.ChartAnnotationsBar

        Private addTextAnnotationBarItem As DevExpress.XtraCharts.UI.AddTextAnnotationBarItem

        Private addImageAnnotationBarItem As DevExpress.XtraCharts.UI.AddImageAnnotationBarItem

        Private selectAxisMeasureUnitRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.SelectAxisMeasureUnitRepositoryItemComboBox

        Private selectSeriesRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.SelectSeriesRepositoryItemComboBox

        Private selectPeriodRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.SelectPeriodRepositoryItemComboBox
    End Class
End Namespace
