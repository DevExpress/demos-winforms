Namespace DevExpress.XtraCharts.Demos

    Partial Class GanttViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.GanttViewsDemo))
            Dim ganttDiagram1 As DevExpress.XtraCharts.GanttDiagram = New DevExpress.XtraCharts.GanttDiagram()
            Dim constantLine1 As DevExpress.XtraCharts.ConstantLine = New DevExpress.XtraCharts.ConstantLine()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Market Analysis", New Object() {(CObj((New System.DateTime(2006, 8, 16, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 8, 23, 0, 0, 0, 0))))}, 0)
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature Planning", New Object() {(CObj((New System.DateTime(2006, 8, 23, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 8, 25, 0, 0, 0, 0))))}, 1)
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 1: Implementation", New Object() {(CObj((New System.DateTime(2006, 8, 25, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 10, 18, 0, 0, 0, 0))))}, 2)
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 1: Demos&Docs", New Object() {(CObj((New System.DateTime(2006, 10, 18, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 10, 26, 0, 0, 0, 0))))}, 7)
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 2: Implementation", New Object() {(CObj((New System.DateTime(2006, 9, 7, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 10, 18, 0, 0, 0, 0))))}, 3)
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 2: Demos&Docs", New Object() {(CObj((New System.DateTime(2006, 10, 18, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 10, 26, 0, 0, 0, 0))))}, 8)
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 3: Implementation", New Object() {(CObj((New System.DateTime(2006, 9, 21, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 10, 18, 0, 0, 0, 0))))}, 4)
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 3: Demos&Docs", New Object() {(CObj((New System.DateTime(2006, 10, 18, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 10, 26, 0, 0, 0, 0))))}, 9)
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Testing & Bug Fixing", New Object() {(CObj((New System.DateTime(2006, 10, 26, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 11, 10, 0, 0, 0, 0))))}, 10)
            Dim overlappedGanttSeriesView1 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Market Analysis", New Object() {(CObj((New System.DateTime(2006, 8, 16, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 8, 23, 0, 0, 0, 0))))}, 0)
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature Planning", New Object() {(CObj((New System.DateTime(2006, 8, 23, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 8, 25, 0, 0, 0, 0))))}, 1)
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 1: Implementation", New Object() {(CObj((New System.DateTime(2006, 8, 25, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 9, 25, 0, 0, 0, 0))))}, 2)
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 2: Implementation", New Object() {(CObj((New System.DateTime(2006, 9, 7, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 9, 25, 0, 0, 0, 0))))}, 3)
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Feature 3: Implementation", New Object() {(CObj((New System.DateTime(2006, 9, 21, 0, 0, 0, 0)))), (CObj((New System.DateTime(2006, 9, 25, 0, 0, 0, 0))))}, 4)
            Dim overlappedGanttSeriesView2 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
            Dim barGrowUpAnimation1 As DevExpress.XtraCharts.BarGrowUpAnimation = New DevExpress.XtraCharts.BarGrowUpAnimation()
            Dim overlappedGanttSeriesView3 As DevExpress.XtraCharts.OverlappedGanttSeriesView = New DevExpress.XtraCharts.OverlappedGanttSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim ganttDiagram2 As DevExpress.XtraCharts.GanttDiagram = New DevExpress.XtraCharts.GanttDiagram()
            Dim xyDiagramPane1 As DevExpress.XtraCharts.XYDiagramPane = New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisX1 As DevExpress.XtraCharts.SecondaryAxisX = New DevExpress.XtraCharts.SecondaryAxisX()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim rangeBarSeriesLabel1 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Project 1", New Object() {(CObj((New System.DateTime(2005, 3, 27, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 30, 0, 0, 0, 0))))}, 0)
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() {(CObj((New System.DateTime(2005, 3, 27, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 4, 29, 0, 0, 0, 0))))}, 1)
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() {(CObj((New System.DateTime(2005, 4, 19, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 30, 0, 0, 0, 0))))}, 2)
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() {(CObj((New System.DateTime(2005, 4, 18, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 7, 0, 0, 0, 0))))}, 3)
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() {(CObj((New System.DateTime(2005, 4, 17, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 6, 0, 0, 0, 0))))}, 4)
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() {(CObj((New System.DateTime(2005, 4, 23, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 12, 0, 0, 0, 0))))}, 6)
            Dim sideBySideGanttSeriesView1 As DevExpress.XtraCharts.SideBySideGanttSeriesView = New DevExpress.XtraCharts.SideBySideGanttSeriesView()
            Dim barGrowUpAnimation2 As DevExpress.XtraCharts.BarGrowUpAnimation = New DevExpress.XtraCharts.BarGrowUpAnimation()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim rangeBarSeriesLabel2 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Project 1", New Object() {(CObj((New System.DateTime(2005, 4, 22, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 6, 17, 0, 0, 0, 0))))}, 0)
            Dim seriesPoint22 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() {(CObj((New System.DateTime(2005, 4, 22, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 17, 0, 0, 0, 0))))}, 1)
            Dim seriesPoint23 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() {(CObj((New System.DateTime(2005, 5, 1, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 6, 10, 0, 0, 0, 0))))}, 2)
            Dim seriesPoint24 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() {(CObj((New System.DateTime(2005, 5, 8, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 28, 0, 0, 0, 0))))}, 3)
            Dim seriesPoint25 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() {(CObj((New System.DateTime(2005, 5, 9, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 30, 0, 0, 0, 0))))}, 4)
            Dim seriesPoint26 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() {(CObj((New System.DateTime(2005, 5, 28, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 6, 17, 0, 0, 0, 0))))}, 6)
            Dim sideBySideGanttSeriesView2 As DevExpress.XtraCharts.SideBySideGanttSeriesView = New DevExpress.XtraCharts.SideBySideGanttSeriesView()
            Dim barSlideAnimation1 As DevExpress.XtraCharts.BarSlideAnimation = New DevExpress.XtraCharts.BarSlideAnimation()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim rangeBarSeriesLabel3 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
            Dim seriesPoint27 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Project 2", New Object() {(CObj((New System.DateTime(2005, 3, 14, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 15, 0, 0, 0, 0))))}, 7)
            Dim seriesPoint28 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() {(CObj((New System.DateTime(2005, 3, 14, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 4, 23, 0, 0, 0, 0))))}, 8)
            Dim seriesPoint29 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() {(CObj((New System.DateTime(2005, 3, 21, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 4, 9, 0, 0, 0, 0))))}, 9)
            Dim seriesPoint30 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() {(CObj((New System.DateTime(2005, 3, 28, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 4, 16, 0, 0, 0, 0))))}, 10)
            Dim seriesPoint31 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() {(CObj((New System.DateTime(2005, 4, 4, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 4, 23, 0, 0, 0, 0))))}, 11)
            Dim seriesPoint32 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() {(CObj((New System.DateTime(2005, 4, 26, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 15, 0, 0, 0, 0))))}, 12)
            Dim sideBySideGanttSeriesView3 As DevExpress.XtraCharts.SideBySideGanttSeriesView = New DevExpress.XtraCharts.SideBySideGanttSeriesView()
            Dim barGrowUpAnimation3 As DevExpress.XtraCharts.BarGrowUpAnimation = New DevExpress.XtraCharts.BarGrowUpAnimation()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim rangeBarSeriesLabel4 As DevExpress.XtraCharts.RangeBarSeriesLabel = New DevExpress.XtraCharts.RangeBarSeriesLabel()
            Dim seriesPoint33 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Project 2", New Object() {(CObj((New System.DateTime(2005, 4, 11, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 6, 9, 0, 0, 0, 0))))}, 7)
            Dim seriesPoint34 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 1", New Object() {(CObj((New System.DateTime(2005, 4, 11, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 6, 0, 0, 0, 0))))}, 8)
            Dim seriesPoint35 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 2", New Object() {(CObj((New System.DateTime(2005, 4, 17, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 6, 0, 0, 0, 0))))}, 9)
            Dim seriesPoint36 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 3", New Object() {(CObj((New System.DateTime(2005, 4, 29, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 17, 0, 0, 0, 0))))}, 10)
            Dim seriesPoint37 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 4", New Object() {(CObj((New System.DateTime(2005, 5, 9, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 5, 25, 0, 0, 0, 0))))}, 11)
            Dim seriesPoint38 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("task 5", New Object() {(CObj((New System.DateTime(2005, 5, 25, 0, 0, 0, 0)))), (CObj((New System.DateTime(2005, 6, 9, 0, 0, 0, 0))))}, 12)
            Dim sideBySideGanttSeriesView4 As DevExpress.XtraCharts.SideBySideGanttSeriesView = New DevExpress.XtraCharts.SideBySideGanttSeriesView()
            Dim barSlideAnimation2 As DevExpress.XtraCharts.BarSlideAnimation = New DevExpress.XtraCharts.BarSlideAnimation()
            Dim sideBySideGanttSeriesView5 As DevExpress.XtraCharts.SideBySideGanttSeriesView = New DevExpress.XtraCharts.SideBySideGanttSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentGantt = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentGanttSideBySide = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelGantt = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelGantt_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartGantt = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelGanttSideBySide = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelGanttSideBySide_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartGanttSideBySide = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentGantt), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentGanttSideBySide), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelGantt.SuspendLayout()
            Me.dockPanelGantt_Container.SuspendLayout()
            CType((Me.chartGantt), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((ganttDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((overlappedGanttSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((overlappedGanttSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((overlappedGanttSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelGanttSideBySide.SuspendLayout()
            Me.dockPanelGanttSideBySide_Container.SuspendLayout()
            CType((Me.chartGanttSideBySide), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((ganttDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((secondaryAxisX1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((rangeBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideGanttSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((rangeBarSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideGanttSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((rangeBarSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideGanttSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((rangeBarSeriesLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideGanttSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideGanttSeriesView5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentGantt, Me.documentGanttSideBySide})
            ' 
            ' documentGantt
            ' 
            Me.documentGantt.Caption = "Gantt"
            Me.documentGantt.ControlName = "dockPanelGantt"
            Me.documentGantt.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentGantt.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentGantt.ImageOptions.SvgImage = CType((resources.GetObject("documentGantt.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentGantt.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentGantt.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentGantt.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentGantt.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentGanttSideBySide
            ' 
            Me.documentGanttSideBySide.Caption = "Gantt Side By Side"
            Me.documentGanttSideBySide.ControlName = "dockPanelGanttSideBySide"
            Me.documentGanttSideBySide.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentGanttSideBySide.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentGanttSideBySide.ImageOptions.SvgImage = CType((resources.GetObject("documentGanttSideBySide.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentGanttSideBySide.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentGanttSideBySide.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentGanttSideBySide.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentGanttSideBySide.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelGantt, Me.dockPanelGanttSideBySide})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelGantt
            ' 
            Me.dockPanelGantt.Controls.Add(Me.dockPanelGantt_Container)
            Me.dockPanelGantt.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelGantt.DockedAsTabbedDocument = True
            Me.dockPanelGantt.ID = New System.Guid("b9bfe265-09ff-4221-ada7-7d2d4d2c4237")
            Me.dockPanelGantt.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelGantt.Name = "dockPanelGantt"
            Me.dockPanelGantt.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelGantt.Size = New System.Drawing.Size(784, 409)
            Me.dockPanelGantt.Text = "Gantt"
            ' 
            ' dockPanelGantt_Container
            ' 
            Me.dockPanelGantt_Container.Controls.Add(Me.chartGantt)
            Me.dockPanelGantt_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelGantt_Container.Name = "dockPanelGantt_Container"
            Me.dockPanelGantt_Container.Size = New System.Drawing.Size(784, 409)
            Me.dockPanelGantt_Container.TabIndex = 0
            ' 
            ' chartGantt
            ' 
            Me.chartGantt.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartGantt.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            ganttDiagram1.AxisX.GridLines.Visible = True
            ganttDiagram1.AxisX.Title.Text = "Tasks"
            ganttDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            ganttDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            constantLine1.AxisValueSerializable = "09/25/2006 00:00:00.000"
            constantLine1.Name = "Progress Line"
            constantLine1.RuntimeMoving = True
            constantLine1.ShowInLegend = False
            constantLine1.Visible = False
            ganttDiagram1.AxisY.ConstantLines.AddRange(New DevExpress.XtraCharts.ConstantLine() {constantLine1})
            ganttDiagram1.AxisY.DateTimeScaleOptions.AutoGrid = False
            ganttDiagram1.AxisY.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            ganttDiagram1.AxisY.DateTimeScaleOptions.GridSpacing = 0.5R
            ganttDiagram1.AxisY.GridLines.MinorVisible = True
            ganttDiagram1.AxisY.Interlaced = True
            ganttDiagram1.AxisY.Label.TextPattern = "{V:m}"
            ganttDiagram1.AxisY.MinorCount = 4
            ganttDiagram1.AxisY.Title.Text = "Date"
            ganttDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            ganttDiagram1.AxisY.VisualRange.Auto = False
            ganttDiagram1.AxisY.VisualRange.AutoSideMargins = False
            ganttDiagram1.AxisY.VisualRange.EndSideMargin = 0R
            ganttDiagram1.AxisY.VisualRange.MaxValueSerializable = "11/16/2006 00:00:00.000"
            ganttDiagram1.AxisY.VisualRange.MinValueSerializable = "08/16/2006 00:00:00.000"
            ganttDiagram1.AxisY.VisualRange.SideMarginsValue = 0R
            ganttDiagram1.AxisY.VisualRange.StartSideMargin = 0R
            ganttDiagram1.AxisY.WholeRange.Auto = False
            ganttDiagram1.AxisY.WholeRange.AutoSideMargins = False
            ganttDiagram1.AxisY.WholeRange.EndSideMargin = 0R
            ganttDiagram1.AxisY.WholeRange.MaxValueSerializable = "11/16/2006 00:00:00.000"
            ganttDiagram1.AxisY.WholeRange.MinValueSerializable = "08/16/2006 00:00:00.000"
            ganttDiagram1.AxisY.WholeRange.SideMarginsValue = 0R
            ganttDiagram1.AxisY.WholeRange.StartSideMargin = 0R
            Me.chartGantt.Diagram = ganttDiagram1
            Me.chartGantt.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartGantt.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartGantt.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartGantt.Legend.Margins.Bottom = 10
            Me.chartGantt.Legend.Margins.Left = 10
            Me.chartGantt.Legend.Margins.Right = 10
            Me.chartGantt.Legend.Margins.Top = 10
            Me.chartGantt.Legend.Name = "Default Legend"
            Me.chartGantt.Location = New System.Drawing.Point(0, 0)
            Me.chartGantt.Name = "chartGantt"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "Planned"
            seriesPoint2.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(0)})
            seriesPoint3.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(1)})
            seriesPoint4.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(2)})
            seriesPoint5.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(1)})
            seriesPoint6.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(3)})
            seriesPoint7.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(1)})
            seriesPoint8.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(4)})
            seriesPoint9.Relations.AddRange(New DevExpress.XtraCharts.Relation() {New DevExpress.XtraCharts.TaskLink(7), New DevExpress.XtraCharts.TaskLink(8), New DevExpress.XtraCharts.TaskLink(9)})
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9})
            series1.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            series1.View = overlappedGanttSeriesView1
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "Completed"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14})
            series2.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            barGrowUpAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.8000000")
            overlappedGanttSeriesView2.Animation = barGrowUpAnimation1
            overlappedGanttSeriesView2.BarWidth = 0.30000001192092896R
            series2.View = overlappedGanttSeriesView2
            Me.chartGantt.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            Me.chartGantt.SeriesTemplate.View = overlappedGanttSeriesView3
            Me.chartGantt.Size = New System.Drawing.Size(784, 409)
            Me.chartGantt.TabIndex = 1
            Me.chartGantt.TabStop = False
            chartTitle1.Text = "R&D Schedule"
            Me.chartGantt.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            AddHandler Me.chartGantt.AnimationEnded, New DevExpress.XtraCharts.AnimationEndedEventHandler(AddressOf Me.chartGantt_AnimationEnded)
            AddHandler Me.chartGantt.ConstantLineMoved, New DevExpress.XtraCharts.ConstantLineMovedEventHandler(AddressOf Me.chartGantt_ConstantLineMoved)
            ' 
            ' dockPanelGanttSideBySide
            ' 
            Me.dockPanelGanttSideBySide.Controls.Add(Me.dockPanelGanttSideBySide_Container)
            Me.dockPanelGanttSideBySide.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelGanttSideBySide.DockedAsTabbedDocument = True
            Me.dockPanelGanttSideBySide.ID = New System.Guid("1524b144-2cef-4a10-bcb9-58e8916a3bf7")
            Me.dockPanelGanttSideBySide.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelGanttSideBySide.Name = "dockPanelGanttSideBySide"
            Me.dockPanelGanttSideBySide.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelGanttSideBySide.Size = New System.Drawing.Size(784, 409)
            Me.dockPanelGanttSideBySide.Text = "Gantt Side By Side"
            ' 
            ' dockPanelGanttSideBySide_Container
            ' 
            Me.dockPanelGanttSideBySide_Container.Controls.Add(Me.chartGanttSideBySide)
            Me.dockPanelGanttSideBySide_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelGanttSideBySide_Container.Name = "dockPanelGanttSideBySide_Container"
            Me.dockPanelGanttSideBySide_Container.Size = New System.Drawing.Size(784, 409)
            Me.dockPanelGanttSideBySide_Container.TabIndex = 0
            ' 
            ' chartGanttSideBySide
            ' 
            Me.chartGanttSideBySide.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartGanttSideBySide.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartGanttSideBySide.CrosshairOptions.HighlightPoints = False
            Me.chartGanttSideBySide.CrosshairOptions.ShowArgumentLine = False
            Me.chartGanttSideBySide.CrosshairOptions.ShowCrosshairLabels = False
            Me.chartGanttSideBySide.CrosshairOptions.ShowGroupHeaders = False
            Me.chartGanttSideBySide.CrosshairOptions.ShowValueLabels = True
            Me.chartGanttSideBySide.CrosshairOptions.ShowValueLine = True
            Me.chartGanttSideBySide.CrosshairOptions.SnapMode = DevExpress.XtraCharts.CrosshairSnapMode.NearestValue
            ganttDiagram2.AxisX.Title.Text = "Project 1"
            ganttDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            ganttDiagram2.AxisY.DateTimeScaleOptions.AutoGrid = False
            ganttDiagram2.AxisY.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            ganttDiagram2.AxisY.DateTimeScaleOptions.GridSpacing = 0.5R
            ganttDiagram2.AxisY.GridLines.MinorVisible = True
            ganttDiagram2.AxisY.Interlaced = True
            ganttDiagram2.AxisY.Label.TextPattern = "{V:m}"
            ganttDiagram2.AxisY.MinorCount = 4
            ganttDiagram2.AxisY.Title.Text = "Date"
            ganttDiagram2.AxisY.VisibleInPanesSerializable = "0"
            ganttDiagram2.DefaultPane.LayoutOptions.RowSpan = 100
            ganttDiagram2.PaneDistance = 3
            xyDiagramPane1.LayoutOptions.RowSpan = 125
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            ganttDiagram2.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() {xyDiagramPane1})
            secondaryAxisX1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisX1.AxisID = 0
            secondaryAxisX1.Name = "secondaryAxisX1"
            secondaryAxisX1.Reverse = True
            secondaryAxisX1.Title.Text = "Project 2"
            secondaryAxisX1.VisibleInPanesSerializable = "0"
            ganttDiagram2.SecondaryAxesX.AddRange(New DevExpress.XtraCharts.SecondaryAxisX() {secondaryAxisX1})
            Me.chartGanttSideBySide.Diagram = ganttDiagram2
            Me.chartGanttSideBySide.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartGanttSideBySide.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartGanttSideBySide.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartGanttSideBySide.Legend.DockTargetName = "Default Pane"
            Me.chartGanttSideBySide.Legend.Name = "Default Legend"
            Me.chartGanttSideBySide.Legend.Title.Text = "Project 1"
            Me.chartGanttSideBySide.Legend.Title.Visible = True
            legend1.BackColor = System.Drawing.Color.Transparent
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            legend1.DockTargetName = "Pane 1"
            legend1.Name = "Legend1"
            legend1.Title.Text = "Project 2"
            legend1.Title.Visible = True
            Me.chartGanttSideBySide.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1})
            Me.chartGanttSideBySide.Location = New System.Drawing.Point(0, 0)
            Me.chartGanttSideBySide.Name = "chartGanttSideBySide"
            rangeBarSeriesLabel1.Indent = 3
            rangeBarSeriesLabel1.TextPattern = "{V:m}"
            series3.Label = rangeBarSeriesLabel1
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series3.Name = "Original Plan"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20})
            series3.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            barGrowUpAnimation2.Duration = System.TimeSpan.Parse("00:00:00")
            barGrowUpAnimation2.Enabled = False
            sideBySideGanttSeriesView1.Animation = barGrowUpAnimation2
            series3.View = sideBySideGanttSeriesView1
            rangeBarSeriesLabel2.Indent = 3
            rangeBarSeriesLabel2.TextPattern = "{V:m}"
            series4.Label = rangeBarSeriesLabel2
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series4.Name = "Current Plan"
            series4.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26})
            series4.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            barSlideAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            sideBySideGanttSeriesView2.Animation = barSlideAnimation1
            series4.View = sideBySideGanttSeriesView2
            rangeBarSeriesLabel3.Indent = 3
            rangeBarSeriesLabel3.TextPattern = "{V:m}"
            series5.Label = rangeBarSeriesLabel3
            series5.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series5.LegendName = "Legend1"
            series5.Name = "Original Plan "
            series5.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32})
            series5.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            barGrowUpAnimation3.Duration = System.TimeSpan.Parse("00:00:00")
            barGrowUpAnimation3.Enabled = False
            sideBySideGanttSeriesView3.Animation = barGrowUpAnimation3
            sideBySideGanttSeriesView3.AxisXName = "secondaryAxisX1"
            sideBySideGanttSeriesView3.PaneName = "Pane 1"
            series5.View = sideBySideGanttSeriesView3
            rangeBarSeriesLabel4.Indent = 3
            rangeBarSeriesLabel4.TextPattern = "{V:m}"
            series6.Label = rangeBarSeriesLabel4
            series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series6.LegendName = "Legend1"
            series6.Name = "Current Plan"
            series6.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38})
            series6.ValueScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            barSlideAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.8000000")
            barSlideAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            sideBySideGanttSeriesView4.Animation = barSlideAnimation2
            sideBySideGanttSeriesView4.AxisXName = "secondaryAxisX1"
            sideBySideGanttSeriesView4.PaneName = "Pane 1"
            series6.View = sideBySideGanttSeriesView4
            Me.chartGanttSideBySide.SeriesSerializable = New DevExpress.XtraCharts.Series() {series3, series4, series5, series6}
            Me.chartGanttSideBySide.SeriesTemplate.View = sideBySideGanttSeriesView5
            Me.chartGanttSideBySide.Size = New System.Drawing.Size(784, 409)
            Me.chartGanttSideBySide.TabIndex = 1
            Me.chartGanttSideBySide.TabStop = False
            chartTitle2.Text = "Project Comparison"
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Left
            chartTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle3.Text = "Tasks"
            Me.chartGanttSideBySide.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2, chartTitle3})
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
            Me.currentTabbedView.DocumentProperties.AllowAnimation = False
            Me.currentTabbedView.DocumentProperties.AllowClose = False
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowInDocumentSelector = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentGantt, Me.documentGanttSideBySide})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' GanttViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.Name = "GanttViewsDemo"
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentGantt), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentGanttSideBySide), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelGantt.ResumeLayout(False)
            Me.dockPanelGantt_Container.ResumeLayout(False)
            CType((ganttDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((overlappedGanttSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((overlappedGanttSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((overlappedGanttSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartGantt), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelGanttSideBySide.ResumeLayout(False)
            Me.dockPanelGanttSideBySide_Container.ResumeLayout(False)
            CType((xyDiagramPane1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((secondaryAxisX1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((ganttDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((rangeBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideGanttSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((rangeBarSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideGanttSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((rangeBarSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideGanttSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((rangeBarSeriesLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideGanttSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideGanttSeriesView5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartGanttSideBySide), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelGantt As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelGantt_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelGanttSideBySide As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelGanttSideBySide_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentGantt As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentGanttSideBySide As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartGantt As DevExpress.XtraCharts.ChartControl

        Private chartGanttSideBySide As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
