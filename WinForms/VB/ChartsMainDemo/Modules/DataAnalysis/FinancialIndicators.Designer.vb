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
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane5 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane6 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane7 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane8 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY5 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY6 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY7 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY8 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim constantLine3 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
            Dim constantLine4 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
            Dim legend5 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend6 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend7 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend8 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stockSeriesView2 As DevExpress.XtraCharts.StockSeriesView = New DevExpress.XtraCharts.StockSeriesView()
            Dim averageTrueRange2 As DevExpress.XtraCharts.AverageTrueRange = New DevExpress.XtraCharts.AverageTrueRange()
            Dim chaikinsVolatility2 As DevExpress.XtraCharts.ChaikinsVolatility = New DevExpress.XtraCharts.ChaikinsVolatility()
            Dim movingAverageConvergenceDivergence2 As DevExpress.XtraCharts.MovingAverageConvergenceDivergence = New DevExpress.XtraCharts.MovingAverageConvergenceDivergence()
            Dim williamsR2 As DevExpress.XtraCharts.WilliamsR = New DevExpress.XtraCharts.WilliamsR()
            Dim chartIntervalItem7 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem8 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem9 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem10 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem11 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem12 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
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
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.chartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController(Me.components)
            Me.selectSeriesRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectSeriesRepositoryItemComboBox()
            Me.changeSeriesViewRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox()
            Me.chartAnnotationsBar1 = New DevExpress.XtraCharts.UI.ChartAnnotationsBar()
            Me.addTextAnnotationBarItem = New DevExpress.XtraCharts.UI.AddTextAnnotationBarItem()
            Me.addImageAnnotationBarItem = New DevExpress.XtraCharts.UI.AddImageAnnotationBarItem()
            Me.selectAxisMeasureUnitRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectAxisMeasureUnitRepositoryItemComboBox()
            Me.selectPeriodRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectPeriodRepositoryItemComboBox()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((averageTrueRange2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((chaikinsVolatility2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((movingAverageConvergenceDivergence2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((williamsR2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectSeriesRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.changeSeriesViewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectAxisMeasureUnitRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectPeriodRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chart
            ' 
            Me.chart.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
            Me.chart.CrosshairOptions.ShowOutOfRangePoints = True
            xyDiagram2.AxisX.GridLines.Visible = True
            xyDiagram2.AxisX.DateTimeScaleOptions.WorkdaysOnly = True
            xyDiagram2.AxisX.MinorCount = 5
            xyDiagram2.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisX.VisibleInPanesSerializable = "3"
            xyDiagram2.AxisX.VisualRange.Auto = False
            xyDiagram2.AxisX.VisualRange.AutoSideMargins = False
            xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "02/14/2020 00:00:00.000"
            xyDiagram2.AxisX.VisualRange.MinValueSerializable = "02/05/2020 00:00:00.000"
            xyDiagram2.AxisX.VisualRange.SideMarginsValue = 0R
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisX.WholeRange.SideMarginsValue = 5R
            xyDiagram2.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram2.DefaultPane.LayoutOptions.RowSpan = 100
            xyDiagram2.DefaultPane.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagram2.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.EnableAxisXScrolling = True
            xyDiagram2.EnableAxisXZooming = True
            xyDiagramPane5.LayoutOptions.RowSpan = 50
            xyDiagramPane5.Name = "atrPane"
            xyDiagramPane5.PaneID = 0
            xyDiagramPane5.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane5.Tag = "AverageTrueRange"
            xyDiagramPane6.LayoutOptions.RowSpan = 50
            xyDiagramPane6.Name = "chvPane"
            xyDiagramPane6.PaneID = 1
            xyDiagramPane6.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane6.Tag = "ChaikinsVolatility"
            xyDiagramPane7.LayoutOptions.RowSpan = 50
            xyDiagramPane7.Name = "macdPane"
            xyDiagramPane7.PaneID = 2
            xyDiagramPane7.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane7.Tag = "MovingAverageConvergenceDivergence"
            xyDiagramPane8.LayoutOptions.RowSpan = 50
            xyDiagramPane8.Name = "wrPane"
            xyDiagramPane8.PaneID = 3
            xyDiagramPane8.Tag = "WilliamsR"
            xyDiagram2.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane5, xyDiagramPane6, xyDiagramPane7, xyDiagramPane8})
            xyDiagram2.RuntimePaneResize = True
            secondaryAxisY5.AxisID = 0
            secondaryAxisY5.Name = "atrAxisY"
            secondaryAxisY5.Tag = "AverageTrueRange"
            secondaryAxisY5.Title.Text = "ATR"
            secondaryAxisY5.VisibleInPanesSerializable = "0"
            secondaryAxisY5.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY6.AxisID = 1
            secondaryAxisY6.Name = "chVAxisY"
            secondaryAxisY6.Tag = "ChaikinsVolatility"
            secondaryAxisY6.Title.Text = "CHV"
            secondaryAxisY6.VisibleInPanesSerializable = "1"
            secondaryAxisY6.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY7.AxisID = 2
            secondaryAxisY7.Name = "macdAxisY"
            secondaryAxisY7.Tag = "MovingAverageConvergenceDivergence"
            secondaryAxisY7.Title.Text = "MACD"
            secondaryAxisY7.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY8.AxisID = 3
            constantLine3.AxisValueSerializable = "-80"
            constantLine3.Name = "-80"
            constantLine3.ShowInLegend = False
            constantLine3.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far
            constantLine3.Title.ShowBelowLine = True
            constantLine4.AxisValueSerializable = "-20"
            constantLine4.Name = "-20"
            constantLine4.ShowInLegend = False
            constantLine4.Title.Alignment = DevExpress.XtraCharts.ConstantLineTitleAlignment.Far
            secondaryAxisY8.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {constantLine3, constantLine4})
            secondaryAxisY8.Name = "wrAxisY"
            secondaryAxisY8.Tag = "WilliamsR"
            secondaryAxisY8.Title.Text = "%R"
            secondaryAxisY8.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY8.WholeRange.Auto = False
            secondaryAxisY8.WholeRange.MaxValueSerializable = "50"
            secondaryAxisY8.WholeRange.MinValueSerializable = "-150"
            xyDiagram2.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY5, secondaryAxisY6, secondaryAxisY7, secondaryAxisY8})
            Me.chart.Diagram = xyDiagram2
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.DockTargetName = "Default Pane"
            Me.chart.Legend.Name = "Default Legend"
            Me.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend5.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend5.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend5.DockTargetName = "atrPane"
            legend5.Name = "atrLegend"
            legend5.Tag = "AverageTrueRange"
            legend6.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend6.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend6.DockTargetName = "chvPane"
            legend6.Name = "chvLegend"
            legend6.Tag = "ChaikinsVolatility"
            legend7.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend7.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend7.DockTargetName = "wrPane"
            legend7.Name = "wrLegend"
            legend7.Tag = "WilliamsR"
            legend8.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend8.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            legend8.DockTargetName = "macdPane"
            legend8.Name = "macdLegend"
            legend8.Tag = "MovingAverageConvergenceDivergence"
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend5, legend6, legend7, legend8})
            Me.chart.Location = New System.Drawing.Point(0, 24)
            Me.chart.Name = "chart"
            series2.ArgumentDataMember = "DateTimeStamp"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.Name = "USDJPU"
            series2.ValueDataMembersSerializable = "Low;High;Open;Close"
            averageTrueRange2.AxisYName = "atrAxisY"
            averageTrueRange2.LegendName = "atrLegend"
            averageTrueRange2.LegendText = "ATR (14)"
            averageTrueRange2.Name = "Average True Range"
            averageTrueRange2.PaneName = "atrPane"
            averageTrueRange2.ShowInLegend = True
            averageTrueRange2.Tag = "AverageTrueRange"
            chaikinsVolatility2.AxisYName = "chVAxisY"
            chaikinsVolatility2.LegendName = "chvLegend"
            chaikinsVolatility2.LegendText = "CHV (10)"
            chaikinsVolatility2.Name = "Chaikin's Volatility"
            chaikinsVolatility2.PaneName = "chvPane"
            chaikinsVolatility2.ShowInLegend = True
            chaikinsVolatility2.Tag = "ChaikinsVolatility"
            movingAverageConvergenceDivergence2.AxisYName = "macdAxisY"
            movingAverageConvergenceDivergence2.LegendName = "macdLegend"
            movingAverageConvergenceDivergence2.LegendText = "MACD (12, 26, 9)"
            movingAverageConvergenceDivergence2.Name = "Moving Average Convergence/Divergence"
            movingAverageConvergenceDivergence2.PaneName = "macdPane"
            movingAverageConvergenceDivergence2.ShowInLegend = True
            movingAverageConvergenceDivergence2.SignalLineStyle.DashStyle = DevExpress.XtraCharts.DashStyle.Dash
            movingAverageConvergenceDivergence2.Tag = "MovingAverageConvergenceDivergence"
            williamsR2.AxisYName = "wrAxisY"
            williamsR2.LegendName = "wrLegend"
            williamsR2.LegendText = "%R (14)"
            williamsR2.Name = "Williams %R"
            williamsR2.PaneName = "wrPane"
            williamsR2.ShowInLegend = True
            williamsR2.Tag = "WilliamsR"
            stockSeriesView2.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {averageTrueRange2, chaikinsVolatility2, movingAverageConvergenceDivergence2, williamsR2})
            stockSeriesView2.LineThickness = 1
            series2.View = stockSeriesView2
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
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
            Me.chartOptionsBar1.DockCol = 2
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
            ' fibbArcBarCheckItem2
            ' 
            Me.fibbArcBarCheckItem.Id = 31
            Me.fibbArcBarCheckItem.Name = "fibbArcBarCheckItem2"
            AddHandler Me.fibbArcBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' fibbFansBarCheckItem3
            ' 
            Me.fibbFansBarCheckItem.Id = 32
            Me.fibbFansBarCheckItem.Name = "fibbFansBarCheckItem3"
            AddHandler Me.fibbFansBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' fibbRetrBarCheckItem4
            ' 
            Me.fibbRetrBarCheckItem.Id = 33
            Me.fibbRetrBarCheckItem.Name = "fibbRetrBarCheckItem4"
            AddHandler Me.fibbRetrBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.checkItem_CheckedChanged)
            ' 
            ' removeBarCheckItem5
            ' 
            Me.removeBarCheckItem.Id = 35
            Me.removeBarCheckItem.Name = "removeBarCheckItem5"
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
            ' chartAnnotationsBar1
            ' 
            Me.chartAnnotationsBar1.Control = Me.chart
            Me.chartAnnotationsBar1.DockCol = 3
            Me.chartAnnotationsBar1.DockRow = 0
            Me.chartAnnotationsBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.chartAnnotationsBar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.addTextAnnotationBarItem), New DevExpress.XtraBars.LinkPersistInfo(Me.addImageAnnotationBarItem)})
            ' 
            ' addTextAnnotationBarItem1
            ' 
            Me.addTextAnnotationBarItem.Id = 49
            Me.addTextAnnotationBarItem.Name = "addTextAnnotationBarItem1"
            ' 
            ' addImageAnnotationBarItem1
            ' 
            Me.addImageAnnotationBarItem.Id = 50
            Me.addImageAnnotationBarItem.Name = "addImageAnnotationBarItem1"
            ' 
            ' selectAxisMeasureUnitRepositoryItemComboBox1
            ' 
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.AutoHeight = False
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            chartIntervalItem7.Caption = "1 day"
            chartIntervalItem7.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Day
            chartIntervalItem8.Caption = "1 week"
            chartIntervalItem8.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Week
            chartIntervalItem9.Caption = "1 month"
            chartIntervalItem9.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Items.AddRange(New Object() {chartIntervalItem7, chartIntervalItem8, chartIntervalItem9})
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Name = "selectAxisMeasureUnitRepositoryItemComboBox1"
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' selectPeriodRepositoryItemComboBox1
            ' 
            Me.selectPeriodRepositoryItemComboBox1.AutoHeight = False
            Me.selectPeriodRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            chartIntervalItem10.Caption = "6 month"
            chartIntervalItem10.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            chartIntervalItem10.MeasureUnitMultiplier = 6
            chartIntervalItem11.Caption = "1 year"
            chartIntervalItem11.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            chartIntervalItem12.Caption = "2 year"
            chartIntervalItem12.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            chartIntervalItem12.MeasureUnitMultiplier = 2
            Me.selectPeriodRepositoryItemComboBox1.Items.AddRange(New Object() {chartIntervalItem10, chartIntervalItem11, chartIntervalItem12})
            Me.selectPeriodRepositoryItemComboBox1.Name = "selectPeriodRepositoryItemComboBox1"
            Me.selectPeriodRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
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
            CType((xyDiagramPane5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((averageTrueRange2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((chaikinsVolatility2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((movingAverageConvergenceDivergence2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((williamsR2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.barManager1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectSeriesRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.changeSeriesViewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectAxisMeasureUnitRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectPeriodRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
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
