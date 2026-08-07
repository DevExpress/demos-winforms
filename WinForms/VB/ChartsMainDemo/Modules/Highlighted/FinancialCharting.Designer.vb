Namespace DevExpress.XtraCharts.Demos

    Partial Class FinancialChartingDemo

        Private components As System.ComponentModel.IContainer = Nothing

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Overloads Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim customAxisLabel1 As DevExpress.XtraCharts.CustomAxisLabel = New DevExpress.XtraCharts.CustomAxisLabel()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane2 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY3 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim legend2 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter1 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember1 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember2 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim dataSourceAdapter2 As DevExpress.XtraCharts.DataSourceAdapter = New DevExpress.XtraCharts.DataSourceAdapter()
            Dim dataMember3 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember4 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember5 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember6 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim dataMember7 As DevExpress.XtraCharts.DataMember = New DevExpress.XtraCharts.DataMember()
            Dim stockSeriesView1 As DevExpress.XtraCharts.StockSeriesView = New DevExpress.XtraCharts.StockSeriesView()
            Dim bollingerBands1 As DevExpress.XtraCharts.BollingerBands = New DevExpress.XtraCharts.BollingerBands()
            Dim movingAverageConvergenceDivergence1 As DevExpress.XtraCharts.MovingAverageConvergenceDivergence = New DevExpress.XtraCharts.MovingAverageConvergenceDivergence()
            Dim chaikinsVolatility1 As DevExpress.XtraCharts.ChaikinsVolatility = New DevExpress.XtraCharts.ChaikinsVolatility()
            Dim chartIntervalItem6 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem1 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem2 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem3 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem4 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem5 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem7 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem8 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Dim chartIntervalItem9 As DevExpress.XtraCharts.ChartIntervalItem = New DevExpress.XtraCharts.ChartIntervalItem()
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupIndicators = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.chart = New DevExpress.XtraCharts.ChartControl()
            Me.chartBarController1 = New DevExpress.XtraCharts.UI.ChartBarController(Me.components)
            Me.changeSeriesViewBarItem1 = New DevExpress.XtraCharts.UI.ChangeSeriesViewBarItem()
            Me.changeSeriesViewRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox()
            Me.trendLineBarCheckItem = New DevExpress.XtraCharts.UI.DrawTrendLineIndicatorBarItem()
            Me.fibbArcBarCheckItem = New DevExpress.XtraCharts.UI.DrawFibonacciArcsIndicatorBarItem()
            Me.fibbFansBarCheckItem = New DevExpress.XtraCharts.UI.DrawFibonacciFansIndicatorBarItem()
            Me.fibbRetrBarCheckItem = New DevExpress.XtraCharts.UI.DrawFibonacciRetracementIndicatorBarItem()
            Me.removeBarCheckItem = New DevExpress.XtraCharts.UI.RemoveIndicatorBarItem()
            Me.addIndicatorBarItem1 = New DevExpress.XtraCharts.UI.AddIndicatorBarItem()
            Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.selectAxisMeasureUnitBarItem1 = New DevExpress.XtraCharts.UI.SelectAxisMeasureUnitBarItem()
            Me.selectAxisMeasureUnitRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectAxisMeasureUnitRepositoryItemComboBox()
            Me.selectperiodBarItem1 = New DevExpress.XtraCharts.UI.SelectPeriodBarItem()
            Me.selectPeriodRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectPeriodRepositoryItemComboBox()
            Me.addTextAnnotationBarItem = New DevExpress.XtraCharts.UI.AddTextAnnotationBarItem()
            Me.addImageAnnotationBarItem = New DevExpress.XtraCharts.UI.AddImageAnnotationBarItem()
            Me.createFinancialChartRibbonPage1 = New DevExpress.XtraCharts.UI.CreateFinancialChartRibbonPage()
            Me.chartFinancialSeriesRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartFinancialSeriesRibbonPageGroup()
            Me.chartFinancialIndicatorsRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartFinancialIndicatorsRibbonPageGroup()
            Me.chartAnnotationsRibbonPageGroup1 = New DevExpress.XtraCharts.UI.ChartAnnotationsRibbonPageGroup()
            Me.selectSeriesRepositoryItemComboBox1 = New DevExpress.XtraCharts.UI.SelectSeriesRepositoryItemComboBox()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupIndicators), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bollingerBands1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((movingAverageConvergenceDivergence1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((chaikinsVolatility1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.chartBarController1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.changeSeriesViewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.commandBarGalleryDropDown8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectAxisMeasureUnitRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectPeriodRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.selectSeriesRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(177, 231, 650, 585)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(254, 518)
            Me.layoutControl.TabIndex = 0
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupIndicators})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(254, 518)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupIndicators
            ' 
            Me.layoutControlGroupIndicators.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupIndicators.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupIndicators.Name = "layoutControlGroupIndicators"
            Me.layoutControlGroupIndicators.Size = New System.Drawing.Size(254, 518)
            Me.layoutControlGroupIndicators.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupIndicators.Text = "Indicators"
            ' 
            ' timer
            ' 
            Me.timer.Interval = 30
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.timer_Tick)
            ' 
            ' chart
            ' 
            Me.chart.AutoLayout = False
            Me.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chart.CrosshairOptions.GroupHeaderPattern = "{A:d} {A:t}"
            Me.chart.CrosshairOptions.ShowArgumentLabels = True
            Me.chart.CrosshairOptions.ShowOnlyInFocusedPane = False
            Me.chart.CrosshairOptions.ShowOutOfRangePoints = True
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.Financial
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
            xyDiagram1.AxisX.DateTimeScaleOptions.SkipRangesWithoutPoints = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowStagger = False
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.MinIndent = 2
            xyDiagram1.AxisX.StickToEdge = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 2R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 2R
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Far
            customAxisLabel1.AxisValueSerializable = "1"
            customAxisLabel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((247)))))), (CInt(((CByte((138)))))), (CInt(((CByte((9)))))))
            customAxisLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            customAxisLabel1.Name = "CurrentValueCustomLabel"
            customAxisLabel1.TextColor = System.Drawing.Color.White
            xyDiagram1.AxisY.CustomLabels.AddRange(New DevExpress.XtraCharts.CustomAxisLabel() {customAxisLabel1})
            xyDiagram1.AxisY.Label.TextPattern = "${V:0.###}"
            xyDiagram1.AxisY.LabelVisibilityMode = DevExpress.XtraCharts.AxisLabelVisibilityMode.AutoGeneratedAndCustom
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.DefaultPane.LayoutOptions.RowSpan = 100
            xyDiagram1.DefaultPane.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagram1.DependentAxesYRange = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagramPane1.LayoutOptions.RowSpan = 50
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane1.ScrollBarOptions.XAxisScrollBarVisible = False
            xyDiagramPane1.Tag = "Moving Average Convergence Divergence"
            xyDiagramPane2.LayoutOptions.RowSpan = 65
            xyDiagramPane2.Name = "Pane 2"
            xyDiagramPane2.PaneID = 1
            xyDiagramPane2.Tag = "Chaikin's Volatility"
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1, xyDiagramPane2})
            xyDiagram1.RuntimePaneResize = True
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.Name = "VolumeAxisY"
            secondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY1.VisibleInPanesSerializable = "-1"
            secondaryAxisY1.WholeRange.AutoSideMargins = False
            secondaryAxisY1.WholeRange.EndSideMargin = 2000000R
            secondaryAxisY1.WholeRange.StartSideMargin = 2000000R
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.Name = "Secondary AxisY 1"
            secondaryAxisY2.Tag = "Moving Average Convergence Divergence"
            secondaryAxisY2.VisibleInPanesSerializable = "0"
            secondaryAxisY3.AxisID = 2
            secondaryAxisY3.Name = "Secondary AxisY 2"
            secondaryAxisY3.Tag = "Chaikin's Volatility"
            secondaryAxisY3.VisibleInPanesSerializable = "1"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2, secondaryAxisY3})
            xyDiagram1.ZoomingOptions.AxisXMaxZoomPercent = 100000R
            Me.chart.Diagram = xyDiagram1
            Me.chart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            Me.chart.Legend.Name = "Default Legend"
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend1.DockTargetName = "Pane 1"
            legend1.Name = "Legend1"
            legend1.Tag = "Chaikin's Volatility"
            legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Left
            legend2.DockTargetName = "Pane 2"
            legend2.Name = "Legend2"
            legend2.Tag = "Moving Average Convergence Divergence"
            Me.chart.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1, legend2})
            Me.chart.Location = New System.Drawing.Point(0, 150)
            Me.chart.Margin = New System.Windows.Forms.Padding(0)
            Me.chart.Name = "chart"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            dataMember1.ColumnName = "DateTimeStamp"
            dataMember2.ColumnName = "Volume"
            dataMember2.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Value
            dataSourceAdapter1.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember1, dataMember2})
            series1.DataAdapter = dataSourceAdapter1
            series1.DataSorted = True
            series1.Name = "Volume"
            sideBySideBarSeriesView1.AggregateFunction = DevExpress.XtraCharts.SeriesAggregateFunction.Sum
            sideBySideBarSeriesView1.AxisYName = "VolumeAxisY"
            sideBySideBarSeriesView1.BarWidth = 0.5R
            sideBySideBarSeriesView1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb((CInt(((CByte((224)))))), (CInt(((CByte((224)))))), (CInt(((CByte((224)))))))
            sideBySideBarSeriesView1.FillStyle.FillMode = DevExpress.XtraCharts.FillMode.Solid
            series1.View = sideBySideBarSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.CrosshairLabelPattern = "Open:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{OV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "High:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{HV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Low:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{LV:0.000}" & Global.Microsoft.VisualBasic.Constants.vbLf & "Close:" & Global.Microsoft.VisualBasic.Constants.vbTab & "{CV:0.000}"
            dataMember3.ColumnName = "DateTimeStamp"
            dataMember4.ColumnName = "Open"
            dataMember4.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Open
            dataMember5.ColumnName = "Close"
            dataMember5.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Close
            dataMember6.ColumnName = "Low"
            dataMember6.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.Low
            dataMember7.ColumnName = "High"
            dataMember7.DataMemberType = DevExpress.XtraCharts.ChartDataMemberType.High
            dataSourceAdapter2.DataMembers.AddRange(New DevExpress.XtraCharts.DataMember() {dataMember3, dataMember4, dataMember5, dataMember6, dataMember7})
            series2.DataAdapter = dataSourceAdapter2
            series2.DataSorted = True
            series2.Name = "Price"
            series2.ValueDataMembersSerializable = "Low;High;Open;Close"
            stockSeriesView1.AggregateFunction = DevExpress.XtraCharts.SeriesAggregateFunction.Financial
            bollingerBands1.LegendText = "BB (20, 2)"
            bollingerBands1.Name = "Bollinger Bands"
            bollingerBands1.ShowInLegend = True
            movingAverageConvergenceDivergence1.AxisYName = "Secondary AxisY 1"
            movingAverageConvergenceDivergence1.LegendName = "Legend1"
            movingAverageConvergenceDivergence1.LegendText = "MACD (12, 26, 9)"
            movingAverageConvergenceDivergence1.Name = "Moving Average Convergence Divergence"
            movingAverageConvergenceDivergence1.PaneName = "Pane 1"
            movingAverageConvergenceDivergence1.ShowInLegend = True
            movingAverageConvergenceDivergence1.SignalLineColor = System.Drawing.Color.LightGray
            movingAverageConvergenceDivergence1.Tag = "Moving Average Convergence Divergence"
            chaikinsVolatility1.AxisYName = "Secondary AxisY 2"
            chaikinsVolatility1.LegendName = "Legend2"
            chaikinsVolatility1.LegendText = "ChV (10)"
            chaikinsVolatility1.Name = "Chaikin's Volatility"
            chaikinsVolatility1.PaneName = "Pane 2"
            chaikinsVolatility1.ShowInLegend = True
            chaikinsVolatility1.Tag = "Chaikin's Volatility"
            stockSeriesView1.Indicators.AddRange(New DevExpress.XtraCharts.Indicator() {bollingerBands1, movingAverageConvergenceDivergence1, chaikinsVolatility1})
            stockSeriesView1.LineThickness = 1
            series2.View = stockSeriesView1
            Me.chart.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chart.Size = New System.Drawing.Size(1503, 323)
            Me.chart.TabIndex = 1
            AddHandler Me.chart.Zoom, New DevExpress.XtraCharts.ChartZoomEventHandler(AddressOf Me.chart_Zoom)
            AddHandler Me.chart.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chart_BoundDataChanged)
            AddHandler Me.chart.MouseUp, New System.Windows.Forms.MouseEventHandler(AddressOf Me.chart_MouseUp)
            ' 
            ' chartBarController1
            ' 
            Me.chartBarController1.BarItems.Add(Me.changeSeriesViewBarItem1)
            Me.chartBarController1.BarItems.Add(Me.trendLineBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.fibbArcBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.fibbFansBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.fibbRetrBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.removeBarCheckItem)
            Me.chartBarController1.BarItems.Add(Me.addIndicatorBarItem1)
            Me.chartBarController1.BarItems.Add(Me.selectAxisMeasureUnitBarItem1)
            Me.chartBarController1.BarItems.Add(Me.selectperiodBarItem1)
            Me.chartBarController1.BarItems.Add(Me.addTextAnnotationBarItem)
            Me.chartBarController1.BarItems.Add(Me.addImageAnnotationBarItem)
            Me.chartBarController1.Control = Me.chart
            ' 
            ' changeSeriesViewBarItem1
            ' 
            Me.changeSeriesViewBarItem1.Edit = Me.changeSeriesViewRepositoryItemComboBox1
            Me.changeSeriesViewBarItem1.EditValue = DevExpress.XtraCharts.ViewType.Stock
            Me.changeSeriesViewBarItem1.Id = 28
            Me.changeSeriesViewBarItem1.Name = "changeSeriesViewBarItem1"
            Me.changeSeriesViewBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.changeSeriesViewBarItem1.UseCommandCaption = True
            ' 
            ' changeSeriesViewRepositoryItemComboBox1
            ' 
            Me.changeSeriesViewRepositoryItemComboBox1.AutoHeight = False
            Me.changeSeriesViewRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.changeSeriesViewRepositoryItemComboBox1.Items.AddRange(New Object() {DevExpress.XtraCharts.ViewType.Stock, DevExpress.XtraCharts.ViewType.CandleStick})
            Me.changeSeriesViewRepositoryItemComboBox1.Name = "changeSeriesViewRepositoryItemComboBox1"
            Me.changeSeriesViewRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            AddHandler Me.changeSeriesViewRepositoryItemComboBox1.CloseUp, New DevExpress.XtraEditors.Controls.CloseUpEventHandler(AddressOf Me.CloseUp)
            AddHandler Me.changeSeriesViewRepositoryItemComboBox1.BeforePopup, New System.EventHandler(AddressOf Me.BeforePopup)
            ' 
            ' trendLineBarCheckItem
            ' 
            Me.trendLineBarCheckItem.Id = 29
            Me.trendLineBarCheckItem.Name = "trendLineBarCheckItem"
            Me.trendLineBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.trendLineBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' fibbArcBarCheckItem
            ' 
            Me.fibbArcBarCheckItem.Id = 30
            Me.fibbArcBarCheckItem.Name = "fibbArcBarCheckItem"
            Me.fibbArcBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.fibbArcBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' fibbFansBarCheckItem
            ' 
            Me.fibbFansBarCheckItem.Id = 31
            Me.fibbFansBarCheckItem.Name = "fibbFansBarCheckItem"
            Me.fibbFansBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.fibbFansBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' fibbRetrBarCheckItem
            ' 
            Me.fibbRetrBarCheckItem.Id = 32
            Me.fibbRetrBarCheckItem.Name = "fibbRetrBarCheckItem"
            Me.fibbRetrBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.fibbRetrBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' removeBarCheckItem
            ' 
            Me.removeBarCheckItem.Id = 33
            Me.removeBarCheckItem.Name = "removeBarCheckItem"
            Me.removeBarCheckItem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            AddHandler Me.removeBarCheckItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' addIndicatorBarItem1
            ' 
            Me.addIndicatorBarItem1.DropDownControl = Me.commandBarGalleryDropDown8
            Me.addIndicatorBarItem1.Id = 34
            Me.addIndicatorBarItem1.Name = "addIndicatorBarItem1"
            ' 
            ' commandBarGalleryDropDown8
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown8.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown8.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown8.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown8.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown8.Gallery.ShowItemImage = False
            Me.commandBarGalleryDropDown8.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
            Me.commandBarGalleryDropDown8.Ribbon = Me.ribbonControl1
            AddHandler Me.commandBarGalleryDropDown8.CloseUp, New System.EventHandler(AddressOf Me.CloseUp)
            AddHandler Me.commandBarGalleryDropDown8.BeforePopup, New System.ComponentModel.CancelEventHandler(AddressOf Me.BeforePopup)
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.AutoSizeItems = True
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControl1.ExpandCollapseItem, Me.changeSeriesViewBarItem1, Me.trendLineBarCheckItem, Me.fibbArcBarCheckItem, Me.fibbFansBarCheckItem, Me.fibbRetrBarCheckItem, Me.removeBarCheckItem, Me.addIndicatorBarItem1, Me.selectAxisMeasureUnitBarItem1, Me.selectperiodBarItem1, Me.addTextAnnotationBarItem, Me.addImageAnnotationBarItem})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 54
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.createFinancialChartRibbonPage1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.changeSeriesViewRepositoryItemComboBox1, Me.selectAxisMeasureUnitRepositoryItemComboBox1, Me.selectSeriesRepositoryItemComboBox1, Me.selectPeriodRepositoryItemComboBox1})
            Me.ribbonControl1.Size = New System.Drawing.Size(1503, 150)
            ' 
            ' selectAxisMeasureUnitBarItem1
            ' 
            Me.selectAxisMeasureUnitBarItem1.Edit = Me.selectAxisMeasureUnitRepositoryItemComboBox1
            chartIntervalItem6.Caption = "1 minute"
            chartIntervalItem6.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
            Me.selectAxisMeasureUnitBarItem1.EditValue = chartIntervalItem6
            Me.selectAxisMeasureUnitBarItem1.Id = 35
            Me.selectAxisMeasureUnitBarItem1.Name = "selectAxisMeasureUnitBarItem1"
            Me.selectAxisMeasureUnitBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.selectAxisMeasureUnitBarItem1.UseCommandCaption = True
            ' 
            ' selectAxisMeasureUnitRepositoryItemComboBox1
            ' 
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.AutoHeight = False
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            chartIntervalItem1.Caption = "15 minutes"
            chartIntervalItem1.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Minute
            chartIntervalItem1.MeasureUnitMultiplier = 15
            chartIntervalItem2.Caption = "1 hours"
            chartIntervalItem2.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
            chartIntervalItem3.Caption = "4 hours"
            chartIntervalItem3.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
            chartIntervalItem3.MeasureUnitMultiplier = 4
            chartIntervalItem4.Caption = "1 day"
            chartIntervalItem4.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Day
            chartIntervalItem5.Caption = "1 week"
            chartIntervalItem5.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Week
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Items.AddRange(New Object() {chartIntervalItem1, chartIntervalItem2, chartIntervalItem3, chartIntervalItem4, chartIntervalItem5})
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.Name = "selectAxisMeasureUnitRepositoryItemComboBox1"
            Me.selectAxisMeasureUnitRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            AddHandler Me.selectAxisMeasureUnitRepositoryItemComboBox1.CloseUp, New DevExpress.XtraEditors.Controls.CloseUpEventHandler(AddressOf Me.CloseUp)
            AddHandler Me.selectAxisMeasureUnitRepositoryItemComboBox1.BeforePopup, New System.EventHandler(AddressOf Me.BeforePopup)
            ' 
            ' selectperiodBarItem1
            ' 
            Me.selectperiodBarItem1.Edit = Me.selectPeriodRepositoryItemComboBox1
            Me.selectperiodBarItem1.EditValue = chartIntervalItem6
            Me.selectperiodBarItem1.Id = 135
            Me.selectperiodBarItem1.Name = "selectperiodBarItem1"
            Me.selectperiodBarItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.Caption
            Me.selectperiodBarItem1.UseCommandCaption = True
            ' 
            ' selectPeriodRepositoryItemComboBox1
            ' 
            Me.selectPeriodRepositoryItemComboBox1.AutoHeight = False
            Me.selectPeriodRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            chartIntervalItem7.Caption = "1 week"
            chartIntervalItem7.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Week
            chartIntervalItem8.Caption = "1 month"
            chartIntervalItem8.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            chartIntervalItem9.Caption = "3 month"
            chartIntervalItem9.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            chartIntervalItem9.MeasureUnitMultiplier = 3
            Me.selectPeriodRepositoryItemComboBox1.Items.AddRange(New Object() {chartIntervalItem7, chartIntervalItem8, chartIntervalItem9})
            Me.selectPeriodRepositoryItemComboBox1.Name = "selectPeriodRepositoryItemComboBox1"
            Me.selectPeriodRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' addTextAnnotationBarItem
            ' 
            Me.addTextAnnotationBarItem.Id = 46
            Me.addTextAnnotationBarItem.Name = "addTextAnnotationBarItem"
            AddHandler Me.addTextAnnotationBarItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' addImageAnnotationBarItem
            ' 
            Me.addImageAnnotationBarItem.Id = 47
            Me.addImageAnnotationBarItem.Name = "addImageAnnotationBarItem"
            AddHandler Me.addImageAnnotationBarItem.CheckedChanged, New DevExpress.XtraBars.ItemClickEventHandler(AddressOf Me.chartCommandBarCheckItem_CheckedChanged)
            ' 
            ' createFinancialChartRibbonPage1
            ' 
            Me.createFinancialChartRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.chartFinancialSeriesRibbonPageGroup1, Me.chartFinancialIndicatorsRibbonPageGroup1, Me.chartAnnotationsRibbonPageGroup1})
            Me.createFinancialChartRibbonPage1.Name = "createFinancialChartRibbonPage1"
            ' 
            ' chartFinancialSeriesRibbonPageGroup1
            ' 
            Me.chartFinancialSeriesRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartFinancialSeriesRibbonPageGroup1.ItemLinks.Add(Me.changeSeriesViewBarItem1)
            Me.chartFinancialSeriesRibbonPageGroup1.ItemLinks.Add(Me.selectAxisMeasureUnitBarItem1)
            Me.chartFinancialSeriesRibbonPageGroup1.ItemLinks.Add(Me.selectperiodBarItem1)
            Me.chartFinancialSeriesRibbonPageGroup1.Name = "chartFinancialSeriesRibbonPageGroup1"
            Me.chartFinancialSeriesRibbonPageGroup1.Text = "General"
            ' 
            ' chartFinancialIndicatorsRibbonPageGroup1
            ' 
            Me.chartFinancialIndicatorsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartFinancialIndicatorsRibbonPageGroup1.ItemLinks.Add(Me.trendLineBarCheckItem)
            Me.chartFinancialIndicatorsRibbonPageGroup1.ItemLinks.Add(Me.fibbArcBarCheckItem)
            Me.chartFinancialIndicatorsRibbonPageGroup1.ItemLinks.Add(Me.fibbFansBarCheckItem)
            Me.chartFinancialIndicatorsRibbonPageGroup1.ItemLinks.Add(Me.fibbRetrBarCheckItem)
            Me.chartFinancialIndicatorsRibbonPageGroup1.ItemLinks.Add(Me.removeBarCheckItem)
            Me.chartFinancialIndicatorsRibbonPageGroup1.ItemLinks.Add(Me.addIndicatorBarItem1, True)
            Me.chartFinancialIndicatorsRibbonPageGroup1.Name = "chartFinancialIndicatorsRibbonPageGroup1"
            ' 
            ' chartAnnotationsRibbonPageGroup1
            ' 
            Me.chartAnnotationsRibbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartAnnotationsRibbonPageGroup1.ItemLinks.Add(Me.addTextAnnotationBarItem)
            Me.chartAnnotationsRibbonPageGroup1.ItemLinks.Add(Me.addImageAnnotationBarItem)
            Me.chartAnnotationsRibbonPageGroup1.Name = "chartAnnotationsRibbonPageGroup1"
            ' 
            ' selectSeriesRepositoryItemComboBox1
            ' 
            Me.selectSeriesRepositoryItemComboBox1.AutoHeight = False
            Me.selectSeriesRepositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.selectSeriesRepositoryItemComboBox1.Items.AddRange(New Object() {"Volume", "Price"})
            Me.selectSeriesRepositoryItemComboBox1.Name = "selectSeriesRepositoryItemComboBox1"
            Me.selectSeriesRepositoryItemComboBox1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            ' 
            ' FinancialChartingDemo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.chart)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
            Me.Name = "FinancialChartingDemo"
            Me.Size = New System.Drawing.Size(1503, 473)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupIndicators), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bollingerBands1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((movingAverageConvergenceDivergence1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((chaikinsVolatility1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stockSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chart), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBarController1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.changeSeriesViewRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.commandBarGalleryDropDown8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectAxisMeasureUnitRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectPeriodRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.selectSeriesRepositoryItemComboBox1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupIndicators As DevExpress.XtraLayout.LayoutControlGroup

        Private timer As System.Windows.Forms.Timer

        Private chart As DevExpress.XtraCharts.ChartControl

        Private chartBarController1 As DevExpress.XtraCharts.UI.ChartBarController

        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl

        Private changeSeriesViewBarItem1 As DevExpress.XtraCharts.UI.ChangeSeriesViewBarItem

        Private changeSeriesViewRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.ChangeSeriesViewRepositoryItemComboBox

        Private addIndicatorBarItem1 As DevExpress.XtraCharts.UI.AddIndicatorBarItem

        Private selectAxisMeasureUnitBarItem1 As DevExpress.XtraCharts.UI.SelectAxisMeasureUnitBarItem

        Private selectperiodBarItem1 As DevExpress.XtraCharts.UI.SelectPeriodBarItem

        Private selectAxisMeasureUnitRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.SelectAxisMeasureUnitRepositoryItemComboBox

        Private createFinancialChartRibbonPage1 As DevExpress.XtraCharts.UI.CreateFinancialChartRibbonPage

        Private chartFinancialSeriesRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartFinancialSeriesRibbonPageGroup

        Private chartFinancialIndicatorsRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartFinancialIndicatorsRibbonPageGroup

        Private commandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown

        Private trendLineBarCheckItem As DevExpress.XtraCharts.UI.DrawTrendLineIndicatorBarItem

        Private fibbArcBarCheckItem As DevExpress.XtraCharts.UI.DrawFibonacciArcsIndicatorBarItem

        Private fibbFansBarCheckItem As DevExpress.XtraCharts.UI.DrawFibonacciFansIndicatorBarItem

        Private fibbRetrBarCheckItem As DevExpress.XtraCharts.UI.DrawFibonacciRetracementIndicatorBarItem

        Private removeBarCheckItem As DevExpress.XtraCharts.UI.RemoveIndicatorBarItem

        Private selectSeriesRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.SelectSeriesRepositoryItemComboBox

        Private addTextAnnotationBarItem As DevExpress.XtraCharts.UI.AddTextAnnotationBarItem

        Private addImageAnnotationBarItem As DevExpress.XtraCharts.UI.AddImageAnnotationBarItem

        Private selectPeriodRepositoryItemComboBox1 As DevExpress.XtraCharts.UI.SelectPeriodRepositoryItemComboBox

        Private chartAnnotationsRibbonPageGroup1 As DevExpress.XtraCharts.UI.ChartAnnotationsRibbonPageGroup
    End Class
End Namespace
