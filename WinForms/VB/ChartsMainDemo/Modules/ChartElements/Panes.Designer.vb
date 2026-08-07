Namespace DevExpress.XtraCharts.Demos

    Partial Class PanesDemo

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
            Dim secondaryAxisY1 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY3 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stackedBarSeriesView1 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stackedBarSeriesView2 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView1 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView2 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView1 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim layoutDefinition1 As DevExpress.XtraCharts.LayoutDefinition = New DevExpress.XtraCharts.LayoutDefinition()
            Dim layoutDefinition2 As DevExpress.XtraCharts.LayoutDefinition = New DevExpress.XtraCharts.LayoutDefinition()
            Dim xyDiagramPane3 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane4 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane5 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane6 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY4 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY5 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY6 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY7 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY8 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY9 As DevExpress.XtraCharts.SecondaryAxisY = New DevExpress.XtraCharts.SecondaryAxisY()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView3 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView4 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series8 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stackedBarSeriesView3 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series9 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim stackedBarSeriesView4 As DevExpress.XtraCharts.StackedBarSeriesView = New DevExpress.XtraCharts.StackedBarSeriesView()
            Dim series10 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim sideBySideBarSeriesView2 As DevExpress.XtraCharts.SideBySideBarSeriesView = New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim series11 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView5 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series12 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView6 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim series13 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim areaSeriesView1 As DevExpress.XtraCharts.AreaSeriesView = New DevExpress.XtraCharts.AreaSeriesView()
            Dim series14 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim lineSeriesView7 As DevExpress.XtraCharts.LineSeriesView = New DevExpress.XtraCharts.LineSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentLinearPaneLayout = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentGridPaneLayout = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelLinearPaneLayout = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelLinearPaneLayout_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartLinearLayout = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelGridPaneLayout = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelGridPaneLayout_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartGridLayout = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentLinearPaneLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentGridPaneLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelLinearPaneLayout.SuspendLayout()
            Me.dockPanelLinearPaneLayout_Container.SuspendLayout()
            CType((Me.chartLinearLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelGridPaneLayout.SuspendLayout()
            Me.dockPanelGridPaneLayout_Container.SuspendLayout()
            CType((Me.chartGridLayout), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisY9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBarSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((lineSeriesView7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentLinearPaneLayout, Me.documentGridPaneLayout})
            ' 
            ' documentLinearPaneLayout
            ' 
            Me.documentLinearPaneLayout.Caption = "Linear Pane Layout"
            Me.documentLinearPaneLayout.ControlName = "dockPanelLinearPaneLayout"
            Me.documentLinearPaneLayout.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentLinearPaneLayout.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentLinearPaneLayout.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentLinearPaneLayout.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentLinearPaneLayout.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentLinearPaneLayout.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentGridPaneLayout
            ' 
            Me.documentGridPaneLayout.Caption = "Grid Pane Layout"
            Me.documentGridPaneLayout.ControlName = "dockPanelGridPaneLayout"
            Me.documentGridPaneLayout.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentGridPaneLayout.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentGridPaneLayout.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentGridPaneLayout.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentGridPaneLayout.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentGridPaneLayout.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelLinearPaneLayout, Me.dockPanelGridPaneLayout})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelLinearPaneLayout
            ' 
            Me.dockPanelLinearPaneLayout.Controls.Add(Me.dockPanelLinearPaneLayout_Container)
            Me.dockPanelLinearPaneLayout.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelLinearPaneLayout.DockedAsTabbedDocument = True
            Me.dockPanelLinearPaneLayout.ID = New System.Guid("725e8926-1ab5-44ae-8416-9085df9d2820")
            Me.dockPanelLinearPaneLayout.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLinearPaneLayout.Name = "dockPanelLinearPaneLayout"
            Me.dockPanelLinearPaneLayout.Options.ShowCloseButton = False
            Me.dockPanelLinearPaneLayout.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelLinearPaneLayout.Size = New System.Drawing.Size(924, 548)
            Me.dockPanelLinearPaneLayout.Text = "Linear Pane Layout"
            ' 
            ' dockPanelLinearPaneLayout_Container
            ' 
            Me.dockPanelLinearPaneLayout_Container.Controls.Add(Me.chartLinearLayout)
            Me.dockPanelLinearPaneLayout_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLinearPaneLayout_Container.Name = "dockPanelLinearPaneLayout_Container"
            Me.dockPanelLinearPaneLayout_Container.Size = New System.Drawing.Size(924, 548)
            Me.dockPanelLinearPaneLayout_Container.TabIndex = 0
            ' 
            ' chartLinearLayout
            ' 
            Me.chartLinearLayout.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartLinearLayout.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartLinearLayout.CrosshairOptions.GroupHeaderPattern = "{A:M/d/yy}"
            Me.chartLinearLayout.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chartLinearLayout.CrosshairOptions.ShowOnlyInFocusedPane = False
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Day
            xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 6R
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.AxisX.VisibleInPanesSerializable = "1"
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram1.AxisX.WholeRange.EndSideMargin = 0.5R
            xyDiagram1.AxisX.WholeRange.StartSideMargin = 0.5R
            xyDiagram1.AxisY.Interlaced = True
            xyDiagram1.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.DefaultPane.Title.Text = "Visitors"
            xyDiagram1.DefaultPane.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.Margins.Bottom = 15
            xyDiagram1.Margins.Left = 15
            xyDiagram1.Margins.Right = 15
            xyDiagram1.Margins.Top = 10
            xyDiagram1.PaneDistance = 20
            xyDiagramPane1.Name = "User Traffic / Average Response Time"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane1.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagramPane2.Name = "Average Page Load Time"
            xyDiagramPane2.PaneID = 1
            xyDiagramPane2.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1, xyDiagramPane2})
            xyDiagram1.RuntimePaneResize = True
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Interlaced = True
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.Name = "AverageResponseTime"
            secondaryAxisY2.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY2.VisibleInPanesSerializable = "0"
            secondaryAxisY3.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY3.AxisID = 2
            secondaryAxisY3.GridLines.Visible = True
            secondaryAxisY3.Interlaced = True
            secondaryAxisY3.Name = "AveragePageLoadTime"
            secondaryAxisY3.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY3.VisibleInPanesSerializable = "1"
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY1, secondaryAxisY2, secondaryAxisY3})
            Me.chartLinearLayout.Diagram = xyDiagram1
            Me.chartLinearLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartLinearLayout.Legend.Name = "Default Legend"
            Me.chartLinearLayout.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartLinearLayout.Location = New System.Drawing.Point(0, 0)
            Me.chartLinearLayout.Name = "chartLinearLayout"
            series1.ArgumentDataMember = "ReportDate"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.Name = "New Visitors"
            series1.SeriesID = 0
            series1.ValueDataMembersSerializable = "NewVisitors"
            series1.View = stackedBarSeriesView1
            series2.ArgumentDataMember = "ReportDate"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series2.Name = "Return Visitors"
            series2.SeriesID = 1
            series2.ValueDataMembersSerializable = "ReturnVisitors"
            series2.View = stackedBarSeriesView2
            series3.ArgumentDataMember = "ReportDate"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series3.CrosshairLabelPattern = "{S} : {V} per sec"
            series3.Name = "Unique Users"
            series3.SeriesID = 2
            series3.ValueDataMembersSerializable = "TrafficTime"
            lineSeriesView1.AxisYName = "Secondary AxisY 1"
            lineSeriesView1.PaneName = "User Traffic / Average Response Time"
            series3.View = lineSeriesView1
            series4.ArgumentDataMember = "ReportDate"
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series4.CrosshairLabelPattern = "{S} : {V} ms"
            series4.Name = "Average Response Time"
            series4.SeriesID = 3
            series4.ValueDataMembersSerializable = "ResponseTime"
            lineSeriesView2.AxisYName = "AverageResponseTime"
            lineSeriesView2.PaneName = "User Traffic / Average Response Time"
            series4.View = lineSeriesView2
            series5.ArgumentDataMember = "ReportDate"
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series5.CrosshairLabelPattern = "{S} : {V:0.##} sec"
            series5.Name = "Average Page Load Time"
            series5.SeriesID = 4
            series5.ValueDataMembersSerializable = "AveragePageLoadTime"
            sideBySideBarSeriesView1.AxisYName = "AveragePageLoadTime"
            sideBySideBarSeriesView1.PaneName = "Average Page Load Time"
            series5.View = sideBySideBarSeriesView1
            Me.chartLinearLayout.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4, series5}
            Me.chartLinearLayout.Size = New System.Drawing.Size(924, 548)
            Me.chartLinearLayout.TabIndex = 1
            Me.chartLinearLayout.TabStop = False
            chartTitle1.DXAlignment = DevExpress.Drawing.DXStringAlignment.Near
            chartTitle1.Text = "Website Performance Indicators By Last Month"
            chartTitle1.TitleID = 0
            Me.chartLinearLayout.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' dockPanelGridPaneLayout
            ' 
            Me.dockPanelGridPaneLayout.Controls.Add(Me.dockPanelGridPaneLayout_Container)
            Me.dockPanelGridPaneLayout.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelGridPaneLayout.DockedAsTabbedDocument = True
            Me.dockPanelGridPaneLayout.ID = New System.Guid("df66abdc-5d54-4bd8-a3c5-d11286024fa1")
            Me.dockPanelGridPaneLayout.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelGridPaneLayout.Name = "dockPanelGridPaneLayout"
            Me.dockPanelGridPaneLayout.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelGridPaneLayout.Size = New System.Drawing.Size(924, 548)
            Me.dockPanelGridPaneLayout.Text = "Grid Pane Layout"
            ' 
            ' dockPanelGridPaneLayout_Container
            ' 
            Me.dockPanelGridPaneLayout_Container.Controls.Add(Me.chartGridLayout)
            Me.dockPanelGridPaneLayout_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelGridPaneLayout_Container.Name = "dockPanelGridPaneLayout_Container"
            Me.dockPanelGridPaneLayout_Container.Size = New System.Drawing.Size(924, 548)
            Me.dockPanelGridPaneLayout_Container.TabIndex = 0
            ' 
            ' chartGridLayout
            ' 
            Me.chartGridLayout.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartGridLayout.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartGridLayout.CrosshairOptions.GroupHeaderPattern = "{A:M/d/yy}"
            Me.chartGridLayout.CrosshairOptions.ShowOnlyInFocusedPane = False
            xyDiagram2.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Day
            xyDiagram2.AxisX.DateTimeScaleOptions.GridSpacing = 6R
            xyDiagram2.AxisX.GridLines.Visible = True
            xyDiagram2.AxisX.Label.ResolveOverlappingOptions.AllowRotate = False
            xyDiagram2.AxisX.Tickmarks.MinorVisible = False
            xyDiagram2.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisX.VisibleInPanesSerializable = "6;7"
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 1R
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 1R
            xyDiagram2.AxisY.Interlaced = True
            xyDiagram2.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram2.AxisY.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram2.DefaultPane.LayoutOptions.RowSpan = 2
            xyDiagram2.DefaultPane.Title.Text = "User Traffic / Average Response Time"
            xyDiagram2.DefaultPane.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.EnableAxisXScrolling = True
            xyDiagram2.EnableAxisXZooming = True
            xyDiagram2.Margins.Bottom = 15
            xyDiagram2.Margins.Left = 15
            xyDiagram2.Margins.Right = 15
            xyDiagram2.Margins.Top = 10
            xyDiagram2.PaneDistance = 20
            xyDiagram2.PaneLayout.AutoLayoutMode = DevExpress.XtraCharts.PaneAutoLayoutMode.Grid
            layoutDefinition1.Weight = 5R
            layoutDefinition2.Weight = 3R
            xyDiagram2.PaneLayout.ColumnDefinitions.AddRange(New DevExpress.XtraCharts.LayoutDefinition() {layoutDefinition1, layoutDefinition2})
            xyDiagramPane3.Name = "Visitors"
            xyDiagramPane3.PaneID = 6
            xyDiagramPane3.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagramPane4.Name = "Average Page Load Time"
            xyDiagramPane4.PaneID = 5
            xyDiagramPane4.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagramPane5.Name = "HTTP Error Status Codes"
            xyDiagramPane5.PaneID = 3
            xyDiagramPane5.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagramPane6.Name = "Memory / CPU usage"
            xyDiagramPane6.PaneID = 7
            xyDiagramPane6.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane3, xyDiagramPane4, xyDiagramPane5, xyDiagramPane6})
            xyDiagram2.RuntimePaneCollapse = False
            xyDiagram2.RuntimePaneResize = True
            secondaryAxisY4.AxisID = 0
            secondaryAxisY4.Name = "AverageResponseTime"
            secondaryAxisY4.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY4.VisibleInPanesSerializable = "-1"
            secondaryAxisY5.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY5.AxisID = 1
            secondaryAxisY5.GridLines.Visible = True
            secondaryAxisY5.Interlaced = True
            secondaryAxisY5.Name = "Memory"
            secondaryAxisY5.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY5.VisibleInPanesSerializable = "7"
            secondaryAxisY6.AxisID = 2
            secondaryAxisY6.Name = "CPU"
            secondaryAxisY6.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY6.VisibleInPanesSerializable = "7"
            secondaryAxisY7.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY7.AxisID = 3
            secondaryAxisY7.GridLines.Visible = True
            secondaryAxisY7.Interlaced = True
            secondaryAxisY7.Name = "AveragePageLoadTime"
            secondaryAxisY7.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY7.VisibleInPanesSerializable = "5"
            secondaryAxisY8.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY8.AxisID = 4
            secondaryAxisY8.GridLines.Visible = True
            secondaryAxisY8.Interlaced = True
            secondaryAxisY8.Name = "HTTPErrorStatusCodes"
            secondaryAxisY8.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY8.VisibleInPanesSerializable = "3"
            secondaryAxisY9.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY9.AxisID = 5
            secondaryAxisY9.GridLines.Visible = True
            secondaryAxisY9.Interlaced = True
            secondaryAxisY9.Name = "Visitors"
            secondaryAxisY9.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            secondaryAxisY9.VisibleInPanesSerializable = "6"
            xyDiagram2.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() {secondaryAxisY4, secondaryAxisY5, secondaryAxisY6, secondaryAxisY7, secondaryAxisY8, secondaryAxisY9})
            xyDiagram2.ZoomingOptions.AxisXMaxZoomPercent = 500R
            Me.chartGridLayout.Diagram = xyDiagram2
            Me.chartGridLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartGridLayout.Legend.Name = "Default Legend"
            Me.chartGridLayout.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartGridLayout.Location = New System.Drawing.Point(0, 0)
            Me.chartGridLayout.Name = "chartGridLayout"
            series6.ArgumentDataMember = "ReportDate"
            series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series6.CrosshairLabelPattern = "{S} : {V} per sec"
            series6.Name = "Unique Users"
            series6.SeriesID = 0
            series6.ValueDataMembersSerializable = "TrafficTime"
            series6.View = lineSeriesView3
            series7.ArgumentDataMember = "ReportDate"
            series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series7.CrosshairLabelPattern = "{S} : {V} ms"
            series7.Name = "Average Response Time"
            series7.SeriesID = 1
            series7.ValueDataMembersSerializable = "ResponseTime"
            lineSeriesView4.AxisYName = "AverageResponseTime"
            series7.View = lineSeriesView4
            series8.ArgumentDataMember = "ReportDate"
            series8.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series8.Name = "New Visitors"
            series8.SeriesID = 2
            series8.ValueDataMembersSerializable = "NewVisitors"
            stackedBarSeriesView3.AxisYName = "Visitors"
            stackedBarSeriesView3.PaneName = "Visitors"
            series8.View = stackedBarSeriesView3
            series9.ArgumentDataMember = "ReportDate"
            series9.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series9.Name = "Return Visitors"
            series9.SeriesID = 3
            series9.ValueDataMembersSerializable = "ReturnVisitors"
            stackedBarSeriesView4.AxisYName = "Visitors"
            stackedBarSeriesView4.PaneName = "Visitors"
            series9.View = stackedBarSeriesView4
            series10.ArgumentDataMember = "ReportDate"
            series10.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series10.CrosshairLabelPattern = "{S} : {V:0.##} sec"
            series10.Name = "Average Page Load Time"
            series10.SeriesID = 4
            series10.ValueDataMembersSerializable = "AveragePageLoadTime"
            sideBySideBarSeriesView2.AxisYName = "AveragePageLoadTime"
            sideBySideBarSeriesView2.PaneName = "Average Page Load Time"
            series10.View = sideBySideBarSeriesView2
            series11.ArgumentDataMember = "ReportDate"
            series11.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series11.Name = "Client Errors"
            series11.SeriesID = 5
            series11.ValueDataMembersSerializable = "ClientErrors"
            lineSeriesView5.AxisYName = "HTTPErrorStatusCodes"
            lineSeriesView5.PaneName = "HTTP Error Status Codes"
            series11.View = lineSeriesView5
            series12.ArgumentDataMember = "ReportDate"
            series12.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series12.Name = "Server Errors"
            series12.SeriesID = 6
            series12.ValueDataMembersSerializable = "ServerErrors"
            lineSeriesView6.AxisYName = "HTTPErrorStatusCodes"
            lineSeriesView6.PaneName = "HTTP Error Status Codes"
            series12.View = lineSeriesView6
            series13.ArgumentDataMember = "ReportDate"
            series13.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series13.CrosshairLabelPattern = "{S} : {V} MB"
            series13.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series13.Name = "Memory"
            series13.SeriesID = 7
            series13.ValueDataMembersSerializable = "MemoryUsage"
            areaSeriesView1.AxisYName = "Memory"
            areaSeriesView1.PaneName = "Memory / CPU usage"
            series13.View = areaSeriesView1
            series14.ArgumentDataMember = "ReportDate"
            series14.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series14.CrosshairLabelPattern = "{S} : {V}%"
            series14.Name = "CPU"
            series14.SeriesID = 8
            series14.ValueDataMembersSerializable = "CPUUsage"
            lineSeriesView7.AxisYName = "CPU"
            lineSeriesView7.PaneName = "Memory / CPU usage"
            series14.View = lineSeriesView7
            Me.chartGridLayout.SeriesSerializable = New DevExpress.XtraCharts.Series() {series6, series7, series8, series9, series10, series11, series12, series13, series14}
            Me.chartGridLayout.Size = New System.Drawing.Size(924, 548)
            Me.chartGridLayout.TabIndex = 1
            Me.chartGridLayout.TabStop = False
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Near
            chartTitle2.Text = "Website Performance Indicators By Last Month"
            chartTitle2.TitleID = 0
            Me.chartGridLayout.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            Me.chartGridLayout.ToolTipOptions.ShowForPoints = False
            ' 
            ' documentManager
            ' 
            Me.documentManager.ContainerControl = Me
            Me.documentManager.View = Me.currentTabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.currentTabbedView})
            ' 
            ' currentTabbedView
            ' 
            Me.currentTabbedView.DocumentGroupProperties.HeaderButtons = DevExpress.XtraTab.TabButtons.None
            Me.currentTabbedView.DocumentGroupProperties.ShowDocumentSelectorButton = False
            Me.currentTabbedView.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup})
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowInDocumentSelector = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentLinearPaneLayout, Me.documentGridPaneLayout})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            AddHandler Me.currentTabbedView.PopupMenuShowing, New DevExpress.XtraBars.Docking2010.Views.PopupMenuShowingEventHandler(AddressOf Me.TabbedView_PopupMenuShowing)
            ' 
            ' PanesDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PanesDemo"
            Me.Size = New System.Drawing.Size(924, 571)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentLinearPaneLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentGridPaneLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelLinearPaneLayout.ResumeLayout(False)
            Me.dockPanelLinearPaneLayout_Container.ResumeLayout(False)
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartLinearLayout), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelGridPaneLayout.ResumeLayout(False)
            Me.dockPanelGridPaneLayout_Container.ResumeLayout(False)
            CType((xyDiagramPane3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagramPane6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisY9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBarSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((areaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((lineSeriesView7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartGridLayout), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelLinearPaneLayout As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelLinearPaneLayout_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentLinearPaneLayout As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentGridPaneLayout As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private dockPanelGridPaneLayout As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelGridPaneLayout_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private chartGridLayout As DevExpress.XtraCharts.ChartControl

        Private chartLinearLayout As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
