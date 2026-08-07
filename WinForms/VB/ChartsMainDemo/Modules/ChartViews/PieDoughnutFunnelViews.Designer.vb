Namespace DevExpress.XtraCharts.Demos

    Partial Class PieDoughnutFunnelViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.PieDoughnutFunnelViewsDemo))
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pieSeriesLabel1 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() {(CObj((17.0752R)))}, 0)
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() {(CObj((9.98467R)))}, 1)
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("USA", New Object() {(CObj((9.63142R)))}, 2)
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("China", New Object() {(CObj((9.59696R)))}, 3)
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() {(CObj((8.511965R)))}, 4)
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() {(CObj((7.68685R)))}, 5)
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("India", New Object() {(CObj((3.28759R)))}, 6)
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Others", New Object() {(CObj((81.2R)))}, 7)
            Dim pieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim pieBurstAnimation1 As DevExpress.XtraCharts.PieBurstAnimation = New DevExpress.XtraCharts.PieBurstAnimation()
            Dim seriesTitle1 As DevExpress.XtraCharts.SeriesTitle = New DevExpress.XtraCharts.SeriesTitle()
            Dim pieSeriesLabel2 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView2 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim simpleDiagram1 As DevExpress.XtraCharts.SimpleDiagram = New DevExpress.XtraCharts.SimpleDiagram()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim funnelSeriesLabel1 As DevExpress.XtraCharts.FunnelSeriesLabel = New DevExpress.XtraCharts.FunnelSeriesLabel()
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Visited a Website", New Object() {(CObj((9152R)))})
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Downloaded a Trial", New Object() {(CObj((6870R)))})
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Contacted to Support", New Object() {(CObj((5121R)))})
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Subscribed", New Object() {(CObj((2224R)))})
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Renewed", New Object() {(CObj((1670R)))})
            Dim funnelSeriesView1 As DevExpress.XtraCharts.FunnelSeriesView = New DevExpress.XtraCharts.FunnelSeriesView()
            Dim pointSeriesView1 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim doughnutSeriesLabel1 As DevExpress.XtraCharts.DoughnutSeriesLabel = New DevExpress.XtraCharts.DoughnutSeriesLabel()
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() {(CObj((17.0752R)))}, 0)
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() {(CObj((9.98467R)))}, 1)
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("USA", New Object() {(CObj((9.63142R)))}, 2)
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("China", New Object() {(CObj((9.59696R)))}, 3)
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() {(CObj((8.511965R)))}, 4)
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() {(CObj((7.68685R)))}, 5)
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("India", New Object() {(CObj((3.28759R)))}, 6)
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Others", New Object() {(CObj((81.2R)))}, 7)
            Dim doughnutSeriesView1 As DevExpress.XtraCharts.DoughnutSeriesView = New DevExpress.XtraCharts.DoughnutSeriesView()
            Dim pieSeriesLabel3 As DevExpress.XtraCharts.PieSeriesLabel = New DevExpress.XtraCharts.PieSeriesLabel()
            Dim pieSeriesView3 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim legend1 As DevExpress.XtraCharts.Legend = New DevExpress.XtraCharts.Legend()
            Dim customLegendItem1 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim customLegendItem2 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim customLegendItem3 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim customLegendItem4 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim customLegendItem5 As DevExpress.XtraCharts.CustomLegendItem = New DevExpress.XtraCharts.CustomLegendItem()
            Dim nestedDoughnutSeriesLabel1 As DevExpress.XtraCharts.NestedDoughnutSeriesLabel = New DevExpress.XtraCharts.NestedDoughnutSeriesLabel()
            Dim nestedDoughnutSeriesView1 As DevExpress.XtraCharts.NestedDoughnutSeriesView = New DevExpress.XtraCharts.NestedDoughnutSeriesView()
            Dim pieWidenAnimation1 As DevExpress.XtraCharts.PieWidenAnimation = New DevExpress.XtraCharts.PieWidenAnimation()
            Dim chartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentPie = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentDoughnut = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentNestedDoughnut = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFunnel = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelPie = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelPie_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartPie = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFunnel = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFunnel_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFunnel = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelDoughnut = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelDoughnut_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartDoughnut = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelNestedDoughnut = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelNestedDoughnut_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartNestedDoughnut = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditPointDistance = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditAlignToCenter = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditHeightToWidthRatio = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditDoughnutHoleRadius = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditExplodedPoints = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.checkEditTotalLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditInnerIndent = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditAutoHeightToWidthRatio = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditGroupSeriesBy = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditNestedDoughnutHoleRadius = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlOptionsGroup = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPosition = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemValueAsPercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupPieDoughnutGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemExplodedPoints = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPieDoughnutHoleRadius = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupFunnelGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemAlignToCenter = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemAutoHeightToWidthRatio = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPointDistance = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemHeightToWidthRatio = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemGroupSeriesBy = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemInnerIndent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemNestedDoughnutHoleRadius = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupTotalLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemTotalLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentPie), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentDoughnut), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentNestedDoughnut), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFunnel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelPie.SuspendLayout()
            Me.dockPanelPie_Container.SuspendLayout()
            CType((Me.chartPie), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((seriesTitle1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFunnel.SuspendLayout()
            Me.dockPanelFunnel_Container.SuspendLayout()
            CType((Me.chartFunnel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((simpleDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnelSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnelSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelDoughnut.SuspendLayout()
            Me.dockPanelDoughnut_Container.SuspendLayout()
            CType((Me.chartDoughnut), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnutSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnutSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pieSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelNestedDoughnut.SuspendLayout()
            Me.dockPanelNestedDoughnut_Container.SuspendLayout()
            CType((Me.chartNestedDoughnut), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((customLegendItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((nestedDoughnutSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((nestedDoughnutSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditPointDistance.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAlignToCenter.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditHeightToWidthRatio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditDoughnutHoleRadius.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditExplodedPoints.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditLabelPosition.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditTotalLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditInnerIndent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditAutoHeightToWidthRatio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditGroupSeriesBy.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditNestedDoughnutHoleRadius.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlOptionsGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPosition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupPieDoughnutGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemExplodedPoints), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPieDoughnutHoleRadius), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupFunnelGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAlignToCenter), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemAutoHeightToWidthRatio), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPointDistance), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemHeightToWidthRatio), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemGroupSeriesBy), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemInnerIndent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemNestedDoughnutHoleRadius), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupTotalLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTotalLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentPie, Me.documentDoughnut, Me.documentNestedDoughnut, Me.documentFunnel})
            ' 
            ' documentPie
            ' 
            Me.documentPie.Caption = "Pie"
            Me.documentPie.ControlName = "dockPanelPie"
            Me.documentPie.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentPie.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentPie.ImageOptions.SvgImage = CType((resources.GetObject("documentPie.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentPie.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentPie.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentPie.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentPie.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentDoughnut
            ' 
            Me.documentDoughnut.Caption = "Doughnut"
            Me.documentDoughnut.ControlName = "dockPanelDoughnut"
            Me.documentDoughnut.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentDoughnut.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentDoughnut.ImageOptions.SvgImage = CType((resources.GetObject("documentDoughnut.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentDoughnut.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentDoughnut.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentDoughnut.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentDoughnut.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentNestedDoughnut
            ' 
            Me.documentNestedDoughnut.Caption = "Nested Doughnut"
            Me.documentNestedDoughnut.ControlName = "dockPanelNestedDoughnut"
            Me.documentNestedDoughnut.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentNestedDoughnut.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentNestedDoughnut.ImageOptions.SvgImage = CType((resources.GetObject("documentNestedDoughnut.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentNestedDoughnut.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentNestedDoughnut.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentNestedDoughnut.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentNestedDoughnut.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFunnel
            ' 
            Me.documentFunnel.Caption = "Funnel"
            Me.documentFunnel.ControlName = "dockPanelFunnel"
            Me.documentFunnel.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentFunnel.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFunnel.ImageOptions.SvgImage = CType((resources.GetObject("documentFunnel.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFunnel.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFunnel.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFunnel.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFunnel.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelPie, Me.dockPanelFunnel, Me.dockPanelDoughnut, Me.dockPanelNestedDoughnut})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelPie
            ' 
            Me.dockPanelPie.Controls.Add(Me.dockPanelPie_Container)
            Me.dockPanelPie.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelPie.DockedAsTabbedDocument = True
            Me.dockPanelPie.ID = New System.Guid("a5df3937-ad35-4ac8-ab55-7c4af20a0acd")
            Me.dockPanelPie.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPie.Name = "dockPanelPie"
            Me.dockPanelPie.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelPie.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelPie.Text = "Pie"
            ' 
            ' dockPanelPie_Container
            ' 
            Me.dockPanelPie_Container.Controls.Add(Me.chartPie)
            Me.dockPanelPie_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPie_Container.Name = "dockPanelPie_Container"
            Me.dockPanelPie_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelPie_Container.TabIndex = 0
            ' 
            ' chartPie
            ' 
            Me.chartPie.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPie.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPie.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartPie.Legend.Name = "Default Legend"
            Me.chartPie.Location = New System.Drawing.Point(0, 0)
            Me.chartPie.Name = "chartPie"
            Me.chartPie.RuntimeHitTesting = True
            pieSeriesLabel1.BackColor = System.Drawing.Color.Transparent
            pieSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            pieSeriesLabel1.ColumnIndent = 20
            pieSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            pieSeriesLabel1.LineLength = 30
            pieSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.TwoColumns
            pieSeriesLabel1.TextPattern = "{A}: {VP:P2}"
            series1.Label = pieSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.LegendTextPattern = "{A}"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series1.SeriesID = 0
            pieBurstAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.1000000")
            pieSeriesView1.Animation = pieBurstAnimation1
            pieSeriesView1.Rotation = 90
            pieSeriesView1.RuntimeExploding = True
            seriesTitle1.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            seriesTitle1.Text = "Total: {TV:#.##}M km²"
            seriesTitle1.TitleID = 0
            pieSeriesView1.Titles.AddRange(New DevExpress.XtraCharts.SeriesTitle() {seriesTitle1})
            series1.View = pieSeriesView1
            Me.chartPie.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            pieSeriesLabel2.TextPattern = "{VP:G2}"
            Me.chartPie.SeriesTemplate.Label = pieSeriesLabel2
            pieSeriesView2.Border.Color = System.Drawing.Color.FromArgb((CInt(((CByte((100)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.chartPie.SeriesTemplate.View = pieSeriesView2
            Me.chartPie.Size = New System.Drawing.Size(788, 548)
            Me.chartPie.TabIndex = 1
            Me.chartPie.TabStop = False
            chartTitle1.Indent = 10
            chartTitle1.Text = "Land Area by Country"
            chartTitle1.TitleID = 0
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www.nationmaster.com"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            chartTitle2.TitleID = 1
            Me.chartPie.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            AddHandler Me.chartPie.PieSeriesPointExploded, New DevExpress.XtraCharts.PieSeriesPointExplodedEventHandler(AddressOf Me.OnChartPieSeriesPointExploded)
            ' 
            ' dockPanelFunnel
            ' 
            Me.dockPanelFunnel.Controls.Add(Me.dockPanelFunnel_Container)
            Me.dockPanelFunnel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFunnel.DockedAsTabbedDocument = True
            Me.dockPanelFunnel.ID = New System.Guid("10770f99-ba24-4509-a47f-728243e548b7")
            Me.dockPanelFunnel.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFunnel.Name = "dockPanelFunnel"
            Me.dockPanelFunnel.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFunnel.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelFunnel.Text = "Funnel"
            ' 
            ' dockPanelFunnel_Container
            ' 
            Me.dockPanelFunnel_Container.Controls.Add(Me.chartFunnel)
            Me.dockPanelFunnel_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFunnel_Container.Name = "dockPanelFunnel_Container"
            Me.dockPanelFunnel_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelFunnel_Container.TabIndex = 0
            ' 
            ' chartFunnel
            ' 
            Me.chartFunnel.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            simpleDiagram1.Margins.Bottom = 10
            simpleDiagram1.Margins.Left = 10
            simpleDiagram1.Margins.Right = 10
            simpleDiagram1.Margins.Top = 10
            Me.chartFunnel.Diagram = simpleDiagram1
            Me.chartFunnel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFunnel.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartFunnel.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.chartFunnel.Legend.Name = "Default Legend"
            Me.chartFunnel.Location = New System.Drawing.Point(0, 0)
            Me.chartFunnel.Name = "chartFunnel"
            funnelSeriesLabel1.TextPattern = "{A}: {VP:P0}"
            series2.Label = funnelSeriesLabel1
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.LegendTextPattern = "{A}"
            series2.Name = "Series 1"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13})
            series2.SeriesID = 0
            series2.View = funnelSeriesView1
            Me.chartFunnel.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
            Me.chartFunnel.SeriesTemplate.ToolTipPointPattern = "{A}: {V} ({VP:0.0%})"
            Me.chartFunnel.SeriesTemplate.View = pointSeriesView1
            Me.chartFunnel.Size = New System.Drawing.Size(788, 548)
            Me.chartFunnel.TabIndex = 1
            chartTitle3.Text = "Website Visitor Trend"
            chartTitle3.TitleID = 0
            Me.chartFunnel.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3})
            ' 
            ' dockPanelDoughnut
            ' 
            Me.dockPanelDoughnut.Controls.Add(Me.dockPanelDoughnut_Container)
            Me.dockPanelDoughnut.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelDoughnut.DockedAsTabbedDocument = True
            Me.dockPanelDoughnut.ID = New System.Guid("e00a76f9-0255-458e-81b5-cec55ce064ad")
            Me.dockPanelDoughnut.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelDoughnut.Name = "dockPanelDoughnut"
            Me.dockPanelDoughnut.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelDoughnut.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelDoughnut.Text = "Doughnut"
            ' 
            ' dockPanelDoughnut_Container
            ' 
            Me.dockPanelDoughnut_Container.Controls.Add(Me.chartDoughnut)
            Me.dockPanelDoughnut_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelDoughnut_Container.Name = "dockPanelDoughnut_Container"
            Me.dockPanelDoughnut_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelDoughnut_Container.TabIndex = 0
            ' 
            ' chartDoughnut
            ' 
            Me.chartDoughnut.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartDoughnut.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartDoughnut.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartDoughnut.Legend.Name = "Default Legend"
            Me.chartDoughnut.Location = New System.Drawing.Point(0, 0)
            Me.chartDoughnut.Name = "chartDoughnut"
            Me.chartDoughnut.RuntimeHitTesting = True
            doughnutSeriesLabel1.BackColor = System.Drawing.Color.Transparent
            doughnutSeriesLabel1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            doughnutSeriesLabel1.ColumnIndent = 20
            doughnutSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            doughnutSeriesLabel1.LineLength = 30
            doughnutSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Radial
            doughnutSeriesLabel1.TextPattern = "{A}: {VP:P2}"
            series3.Label = doughnutSeriesLabel1
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series3.LegendTextPattern = "{A}"
            series3.Name = "Series 1"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21})
            series3.SeriesID = 0
            series3.ToolTipPointPattern = "{A}: {V:0.0}M km²"
            doughnutSeriesView1.Rotation = 90
            doughnutSeriesView1.RuntimeExploding = True
            doughnutSeriesView1.TotalLabel.TextPattern = "Total" & Global.Microsoft.VisualBasic.Constants.vbLf & "{TV:0.00}M km²" & Global.Microsoft.VisualBasic.Constants.vbLf
            doughnutSeriesView1.TotalLabel.Visible = True
            series3.View = doughnutSeriesView1
            Me.chartDoughnut.SeriesSerializable = New DevExpress.XtraCharts.Series() {series3}
            pieSeriesLabel3.TextPattern = "{VP:G2}"
            Me.chartDoughnut.SeriesTemplate.Label = pieSeriesLabel3
            pieSeriesView3.Border.Color = System.Drawing.Color.FromArgb((CInt(((CByte((100)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.chartDoughnut.SeriesTemplate.View = pieSeriesView3
            Me.chartDoughnut.Size = New System.Drawing.Size(788, 548)
            Me.chartDoughnut.TabIndex = 1
            Me.chartDoughnut.TabStop = False
            chartTitle4.Indent = 10
            chartTitle4.Text = "Land Area by Country"
            chartTitle4.TitleID = 0
            chartTitle5.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle5.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle5.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle5.Text = "From www.nationmaster.com"
            chartTitle5.TextColor = System.Drawing.Color.Gray
            chartTitle5.TitleID = 1
            Me.chartDoughnut.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle4, chartTitle5})
            Me.chartDoughnut.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            AddHandler Me.chartDoughnut.PieSeriesPointExploded, New DevExpress.XtraCharts.PieSeriesPointExplodedEventHandler(AddressOf Me.OnChartPieSeriesPointExploded)
            ' 
            ' dockPanelNestedDoughnut
            ' 
            Me.dockPanelNestedDoughnut.Controls.Add(Me.dockPanelNestedDoughnut_Container)
            Me.dockPanelNestedDoughnut.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelNestedDoughnut.DockedAsTabbedDocument = True
            Me.dockPanelNestedDoughnut.ID = New System.Guid("4e381da9-07d9-4f09-9819-e12f7f5ce043")
            Me.dockPanelNestedDoughnut.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelNestedDoughnut.Name = "dockPanelNestedDoughnut"
            Me.dockPanelNestedDoughnut.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelNestedDoughnut.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelNestedDoughnut.Text = "Nested Doughnut"
            ' 
            ' dockPanelNestedDoughnut_Container
            ' 
            Me.dockPanelNestedDoughnut_Container.Controls.Add(Me.chartNestedDoughnut)
            Me.dockPanelNestedDoughnut_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelNestedDoughnut_Container.Name = "dockPanelNestedDoughnut_Container"
            Me.dockPanelNestedDoughnut_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelNestedDoughnut_Container.TabIndex = 0
            ' 
            ' chartNestedDoughnut
            ' 
            Me.chartNestedDoughnut.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartNestedDoughnut.AutoLayout = False
            Me.chartNestedDoughnut.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartNestedDoughnut.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartNestedDoughnut.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartNestedDoughnut.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.chartNestedDoughnut.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartNestedDoughnut.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartNestedDoughnut.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartNestedDoughnut.Legend.EnableAntialiasing = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartNestedDoughnut.Legend.Margins.Bottom = 35
            Me.chartNestedDoughnut.Legend.Name = "Default Legend"
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            legend1.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            legend1.BackColor = System.Drawing.Color.Transparent
            legend1.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            customLegendItem1.CustomLegendItemID = 0
            customLegendItem1.MarkerImage.DXImage = CType((DevExpress.Drawing.DXImage.FromBase64String(resources.GetString("resource.DXImage"))), DevExpress.Drawing.DXBitmap)
            customLegendItem1.Name = "Custom Legend Item 3"
            customLegendItem1.Text = "0 - 14 years"
            customLegendItem2.CustomLegendItemID = 1
            customLegendItem2.MarkerImage.DXImage = CType((DevExpress.Drawing.DXImage.FromBase64String(resources.GetString("resource.DXImage1"))), DevExpress.Drawing.DXBitmap)
            customLegendItem2.Name = "Custom Legend Item 2"
            customLegendItem2.Text = "15 - 64 years"
            customLegendItem3.CustomLegendItemID = 2
            customLegendItem3.MarkerImage.DXImage = CType((DevExpress.Drawing.DXImage.FromBase64String(resources.GetString("resource.DXImage2"))), DevExpress.Drawing.DXBitmap)
            customLegendItem3.Name = "Custom Legend Item 1"
            customLegendItem3.Text = "65 years and older"
            customLegendItem4.CustomLegendItemID = 3
            customLegendItem4.MarkerImage.DXImage = CType((DevExpress.Drawing.DXImage.FromBase64String(resources.GetString("resource.DXImage3"))), DevExpress.Drawing.DXBitmap)
            customLegendItem4.Name = "Custom Legend Item 4"
            customLegendItem4.Text = "Male"
            customLegendItem5.CustomLegendItemID = 4
            customLegendItem5.MarkerImage.DXImage = CType((DevExpress.Drawing.DXImage.FromBase64String(resources.GetString("resource.DXImage4"))), DevExpress.Drawing.DXBitmap)
            customLegendItem5.Name = "Custom Legend Item 5"
            customLegendItem5.Text = "Female"
            legend1.CustomItems.AddRange(New DevExpress.XtraCharts.CustomLegendItem() {customLegendItem1, customLegendItem2, customLegendItem3, customLegendItem4, customLegendItem5})
            legend1.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            legend1.LegendID = 0
            legend1.Name = "Legend2"
            Me.chartNestedDoughnut.Legends.AddRange(New DevExpress.XtraCharts.Legend() {legend1})
            Me.chartNestedDoughnut.Location = New System.Drawing.Point(0, 0)
            Me.chartNestedDoughnut.Name = "chartNestedDoughnut"
            Me.chartNestedDoughnut.SeriesDataMember = "CountryGenderKey"
            Me.chartNestedDoughnut.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartNestedDoughnut.SeriesTemplate.ArgumentDataMember = "Age"
            Me.chartNestedDoughnut.SeriesTemplate.FilterString = "[Name] = 'United States' Or [Name] = 'Brazil' Or [Name] = 'Russia'"
            nestedDoughnutSeriesLabel1.TextPattern = "{V:G2}"
            Me.chartNestedDoughnut.SeriesTemplate.Label = nestedDoughnutSeriesLabel1
            Me.chartNestedDoughnut.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartNestedDoughnut.SeriesTemplate.LegendTextPattern = "{A}"
            Me.chartNestedDoughnut.SeriesTemplate.SeriesDataMember = "CountryGenderKey"
            Me.chartNestedDoughnut.SeriesTemplate.ShowInLegend = False
            Me.chartNestedDoughnut.SeriesTemplate.ToolTipHintDataMember = "Gender"
            Me.chartNestedDoughnut.SeriesTemplate.ToolTipPointPattern = "{HINT} : {VP:##.##%}"
            Me.chartNestedDoughnut.SeriesTemplate.ValueDataMembersSerializable = "Population"
            pieWidenAnimation1.PointDelay = System.TimeSpan.Parse("00:00:00.3000000")
            nestedDoughnutSeriesView1.Animation = pieWidenAnimation1
            Me.chartNestedDoughnut.SeriesTemplate.View = nestedDoughnutSeriesView1
            Me.chartNestedDoughnut.Size = New System.Drawing.Size(788, 548)
            Me.chartNestedDoughnut.TabIndex = 1
            Me.chartNestedDoughnut.TabStop = False
            chartTitle6.Text = "Population: Age Structure"
            chartTitle6.TitleID = 0
            chartTitle7.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle7.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle7.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle7.Text = "From www.cia.gov"
            chartTitle7.TextColor = System.Drawing.Color.Gray
            chartTitle7.TitleID = 1
            chartTitle8.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle8.Text = "Data estimate for 2020"
            chartTitle8.TitleID = 2
            Me.chartNestedDoughnut.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle6, chartTitle7, chartTitle8})
            Me.chartNestedDoughnut.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            AddHandler Me.chartNestedDoughnut.BoundDataChanged, New DevExpress.XtraCharts.BoundDataChangedEventHandler(AddressOf Me.chartNestedDoughnut_BoundDataChanged)
            ' 
            ' documentManager
            ' 
            Me.documentManager.ContainerControl = Me
            Me.documentManager.View = Me.currentTabbedView
            Me.documentManager.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.currentTabbedView})
            ' 
            ' currentTabbedView
            ' 
            Me.currentTabbedView.DocumentGroupProperties.CloseTabOnMiddleClick = DevExpress.XtraTabbedMdi.CloseTabOnMiddleClick.Never
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
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentPie, Me.documentDoughnut, Me.documentNestedDoughnut, Me.documentFunnel})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.checkEditValueAsPercent)
            Me.layoutControl.Controls.Add(Me.spinEditPointDistance)
            Me.layoutControl.Controls.Add(Me.checkEditAlignToCenter)
            Me.layoutControl.Controls.Add(Me.comboBoxEditHeightToWidthRatio)
            Me.layoutControl.Controls.Add(Me.spinEditDoughnutHoleRadius)
            Me.layoutControl.Controls.Add(Me.comboBoxEditExplodedPoints)
            Me.layoutControl.Controls.Add(Me.comboBoxEditLabelPosition)
            Me.layoutControl.Controls.Add(Me.checkEditTotalLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditInnerIndent)
            Me.layoutControl.Controls.Add(Me.checkEditAutoHeightToWidthRatio)
            Me.layoutControl.Controls.Add(Me.comboBoxEditGroupSeriesBy)
            Me.layoutControl.Controls.Add(Me.spinEditNestedDoughnutHoleRadius)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(602, 135, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 354)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' checkEditValueAsPercent
            ' 
            Me.checkEditValueAsPercent.EditValue = True
            Me.checkEditValueAsPercent.Location = New System.Drawing.Point(12, 378)
            Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
            Me.checkEditValueAsPercent.Properties.Caption = "Value as Percent"
            Me.checkEditValueAsPercent.Size = New System.Drawing.Size(217, 20)
            Me.checkEditValueAsPercent.StyleController = Me.layoutControl
            Me.checkEditValueAsPercent.TabIndex = 11
            Me.checkEditValueAsPercent.Visible = False
            ' 
            ' spinEditPointDistance
            ' 
            Me.spinEditPointDistance.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditPointDistance.Location = New System.Drawing.Point(104, 288)
            Me.spinEditPointDistance.Name = "spinEditPointDistance"
            Me.spinEditPointDistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditPointDistance.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditPointDistance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditPointDistance.Properties.IsFloatValue = False
            Me.spinEditPointDistance.Properties.Mask.EditMask = "N00"
            Me.spinEditPointDistance.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditPointDistance.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditPointDistance.Size = New System.Drawing.Size(125, 20)
            Me.spinEditPointDistance.StyleController = Me.layoutControl
            Me.spinEditPointDistance.TabIndex = 8
            ' 
            ' checkEditAlignToCenter
            ' 
            Me.checkEditAlignToCenter.Location = New System.Drawing.Point(12, 216)
            Me.checkEditAlignToCenter.Name = "checkEditAlignToCenter"
            Me.checkEditAlignToCenter.Properties.Caption = "Align to Center"
            Me.checkEditAlignToCenter.Size = New System.Drawing.Size(217, 20)
            Me.checkEditAlignToCenter.StyleController = Me.layoutControl
            Me.checkEditAlignToCenter.TabIndex = 6
            AddHandler Me.checkEditAlignToCenter.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAlignToCenter_CheckedChanged)
            ' 
            ' comboBoxEditHeightToWidthRatio
            ' 
            Me.comboBoxEditHeightToWidthRatio.Location = New System.Drawing.Point(104, 264)
            Me.comboBoxEditHeightToWidthRatio.Name = "comboBoxEditHeightToWidthRatio"
            Me.comboBoxEditHeightToWidthRatio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditHeightToWidthRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditHeightToWidthRatio.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditHeightToWidthRatio.StyleController = Me.layoutControl
            Me.comboBoxEditHeightToWidthRatio.TabIndex = 5
            AddHandler Me.comboBoxEditHeightToWidthRatio.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditHeightToWidthRatio_SelectedIndexChanged)
            ' 
            ' spinEditDoughnutHoleRadius
            ' 
            Me.spinEditDoughnutHoleRadius.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditDoughnutHoleRadius.Location = New System.Drawing.Point(104, 126)
            Me.spinEditDoughnutHoleRadius.Name = "spinEditDoughnutHoleRadius"
            Me.spinEditDoughnutHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditDoughnutHoleRadius.Properties.DisplayFormat.FormatString = "0\%"
            Me.spinEditDoughnutHoleRadius.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditDoughnutHoleRadius.Properties.EditFormat.FormatString = "0\%"
            Me.spinEditDoughnutHoleRadius.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditDoughnutHoleRadius.Properties.IsFloatValue = False
            Me.spinEditDoughnutHoleRadius.Properties.Mask.EditMask = "N00"
            Me.spinEditDoughnutHoleRadius.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEditDoughnutHoleRadius.Size = New System.Drawing.Size(125, 20)
            Me.spinEditDoughnutHoleRadius.StyleController = Me.layoutControl
            Me.spinEditDoughnutHoleRadius.TabIndex = 12
            AddHandler Me.spinEditDoughnutHoleRadius.EditValueChanged, New System.EventHandler(AddressOf Me.OnSpinEditHoleRadiusEditValueChanged)
            ' 
            ' comboBoxEditExplodedPoints
            ' 
            Me.comboBoxEditExplodedPoints.Location = New System.Drawing.Point(104, 150)
            Me.comboBoxEditExplodedPoints.Name = "comboBoxEditExplodedPoints"
            Me.comboBoxEditExplodedPoints.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditExplodedPoints.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditExplodedPoints.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditExplodedPoints.StyleController = Me.layoutControl
            Me.comboBoxEditExplodedPoints.TabIndex = 13
            AddHandler Me.comboBoxEditExplodedPoints.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditExplodedPoints_SelectedIndexChanged)
            ' 
            ' comboBoxEditLabelPosition
            ' 
            Me.comboBoxEditLabelPosition.Location = New System.Drawing.Point(104, 402)
            Me.comboBoxEditLabelPosition.Name = "comboBoxEditLabelPosition"
            Me.comboBoxEditLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditLabelPosition.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditLabelPosition.StyleController = Me.layoutControl
            Me.comboBoxEditLabelPosition.TabIndex = 14
            ' 
            ' checkEditTotalLabelVisible
            ' 
            Me.checkEditTotalLabelVisible.EditValue = True
            Me.checkEditTotalLabelVisible.Location = New System.Drawing.Point(12, 468)
            Me.checkEditTotalLabelVisible.Name = "checkEditTotalLabelVisible"
            Me.checkEditTotalLabelVisible.Properties.Caption = "Visible"
            Me.checkEditTotalLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditTotalLabelVisible.StyleController = Me.layoutControl
            Me.checkEditTotalLabelVisible.TabIndex = 15
            AddHandler Me.checkEditTotalLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.spinEditTotalLabelVisible_CheckedChanged)
            ' 
            ' spinEditInnerIndent
            ' 
            Me.spinEditInnerIndent.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditInnerIndent.Location = New System.Drawing.Point(104, 60)
            Me.spinEditInnerIndent.Name = "spinEditInnerIndent"
            Me.spinEditInnerIndent.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditInnerIndent.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditInnerIndent.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditInnerIndent.Properties.IsFloatValue = False
            Me.spinEditInnerIndent.Properties.Mask.EditMask = "N00"
            Me.spinEditInnerIndent.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditInnerIndent.Size = New System.Drawing.Size(125, 20)
            Me.spinEditInnerIndent.StyleController = Me.layoutControl
            Me.spinEditInnerIndent.TabIndex = 16
            AddHandler Me.spinEditInnerIndent.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditInnerIndent_EditValueChanged)
            ' 
            ' checkEditAutoHeightToWidthRatio
            ' 
            Me.checkEditAutoHeightToWidthRatio.Location = New System.Drawing.Point(12, 240)
            Me.checkEditAutoHeightToWidthRatio.Name = "checkEditAutoHeightToWidthRatio"
            Me.checkEditAutoHeightToWidthRatio.Properties.Caption = "Auto Height to Width Ratio"
            Me.checkEditAutoHeightToWidthRatio.Size = New System.Drawing.Size(217, 20)
            Me.checkEditAutoHeightToWidthRatio.StyleController = Me.layoutControl
            Me.checkEditAutoHeightToWidthRatio.TabIndex = 18
            AddHandler Me.checkEditAutoHeightToWidthRatio.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditAutoHeightToWidthRatio_CheckedChanged)
            ' 
            ' comboBoxEditGroupSeriesBy
            ' 
            Me.comboBoxEditGroupSeriesBy.EditValue = "Gender"
            Me.comboBoxEditGroupSeriesBy.Location = New System.Drawing.Point(104, 12)
            Me.comboBoxEditGroupSeriesBy.Name = "comboBoxEditGroupSeriesBy"
            Me.comboBoxEditGroupSeriesBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditGroupSeriesBy.Properties.Items.AddRange(New Object() {"Gender", "Age"})
            Me.comboBoxEditGroupSeriesBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditGroupSeriesBy.Size = New System.Drawing.Size(125, 20)
            Me.comboBoxEditGroupSeriesBy.StyleController = Me.layoutControl
            Me.comboBoxEditGroupSeriesBy.TabIndex = 17
            AddHandler Me.comboBoxEditGroupSeriesBy.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditGroupSeriesBy_SelectedIndexChanged)
            ' 
            ' spinEditNestedDoughnutHoleRadius
            ' 
            Me.spinEditNestedDoughnutHoleRadius.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditNestedDoughnutHoleRadius.Location = New System.Drawing.Point(104, 36)
            Me.spinEditNestedDoughnutHoleRadius.Name = "spinEditNestedDoughnutHoleRadius"
            Me.spinEditNestedDoughnutHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditNestedDoughnutHoleRadius.Properties.DisplayFormat.FormatString = "0\%"
            Me.spinEditNestedDoughnutHoleRadius.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditNestedDoughnutHoleRadius.Properties.IsFloatValue = False
            Me.spinEditNestedDoughnutHoleRadius.Properties.Mask.EditMask = "N00"
            Me.spinEditNestedDoughnutHoleRadius.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEditNestedDoughnutHoleRadius.Size = New System.Drawing.Size(125, 20)
            Me.spinEditNestedDoughnutHoleRadius.StyleController = Me.layoutControl
            Me.spinEditNestedDoughnutHoleRadius.TabIndex = 19
            AddHandler Me.spinEditNestedDoughnutHoleRadius.EditValueChanged, New System.EventHandler(AddressOf Me.OnSpinEditHoleRadiusEditValueChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlOptionsGroup, Me.layoutControlGroupPieDoughnutGeneral, Me.emptySpaceItem, Me.layoutControlGroupFunnelGeneral, Me.layoutControlItemGroupSeriesBy, Me.layoutControlItemInnerIndent, Me.layoutControlItemNestedDoughnutHoleRadius, Me.layoutControlGroupTotalLabel})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlOptionsGroup
            ' 
            Me.layoutControlOptionsGroup.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlOptionsGroup.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlOptionsGroup.CustomizationFormText = "Label"
            Me.layoutControlOptionsGroup.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlOptionsGroup.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemPosition, Me.layoutControlItemValueAsPercent})
            Me.layoutControlOptionsGroup.Location = New System.Drawing.Point(0, 320)
            Me.layoutControlOptionsGroup.Name = "layoutControlOptionsGroup"
            Me.layoutControlOptionsGroup.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlOptionsGroup.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlOptionsGroup.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' layoutControlItemPosition
            ' 
            Me.layoutControlItemPosition.Control = Me.comboBoxEditLabelPosition
            Me.layoutControlItemPosition.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemPosition.Name = "layoutControlItemPosition"
            Me.layoutControlItemPosition.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPosition.Text = "Position:"
            Me.layoutControlItemPosition.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemValueAsPercent
            ' 
            Me.layoutControlItemValueAsPercent.Control = Me.checkEditValueAsPercent
            Me.layoutControlItemValueAsPercent.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItemValueAsPercent.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemValueAsPercent.Name = "layoutControlItemValueAsPercent"
            Me.layoutControlItemValueAsPercent.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemValueAsPercent.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItemValueAsPercent.TextVisible = False
            ' 
            ' layoutControlGroupPieDoughnutGeneral
            ' 
            Me.layoutControlGroupPieDoughnutGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupPieDoughnutGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupPieDoughnutGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupPieDoughnutGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemExplodedPoints, Me.layoutControlItemPieDoughnutHoleRadius})
            Me.layoutControlGroupPieDoughnutGeneral.Location = New System.Drawing.Point(0, 92)
            Me.layoutControlGroupPieDoughnutGeneral.Name = "layoutControlGroupPieDoughnutGeneral"
            Me.layoutControlGroupPieDoughnutGeneral.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupPieDoughnutGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupPieDoughnutGeneral.Text = "General"
            ' 
            ' layoutControlItemExplodedPoints
            ' 
            Me.layoutControlItemExplodedPoints.Control = Me.comboBoxEditExplodedPoints
            Me.layoutControlItemExplodedPoints.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemExplodedPoints.Name = "layoutControlItemExplodedPoints"
            Me.layoutControlItemExplodedPoints.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemExplodedPoints.Text = "Exploded Points:"
            Me.layoutControlItemExplodedPoints.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemPieDoughnutHoleRadius
            ' 
            Me.layoutControlItemPieDoughnutHoleRadius.Control = Me.spinEditDoughnutHoleRadius
            Me.layoutControlItemPieDoughnutHoleRadius.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemPieDoughnutHoleRadius.Name = "layoutControlItemPieDoughnutHoleRadius"
            Me.layoutControlItemPieDoughnutHoleRadius.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPieDoughnutHoleRadius.Text = "Hole Radius:"
            Me.layoutControlItemPieDoughnutHoleRadius.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 500)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 38)
            ' 
            ' layoutControlGroupFunnelGeneral
            ' 
            Me.layoutControlGroupFunnelGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupFunnelGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupFunnelGeneral.CustomizationFormText = "Marker"
            Me.layoutControlGroupFunnelGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupFunnelGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemAlignToCenter, Me.layoutControlItemAutoHeightToWidthRatio, Me.layoutControlItemPointDistance, Me.layoutControlItemHeightToWidthRatio})
            Me.layoutControlGroupFunnelGeneral.Location = New System.Drawing.Point(0, 182)
            Me.layoutControlGroupFunnelGeneral.Name = "layoutControlGroupFunnelGeneral"
            Me.layoutControlGroupFunnelGeneral.Size = New System.Drawing.Size(241, 138)
            Me.layoutControlGroupFunnelGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupFunnelGeneral.Text = "General"
            Me.layoutControlGroupFunnelGeneral.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
            ' 
            ' layoutControlItemAlignToCenter
            ' 
            Me.layoutControlItemAlignToCenter.Control = Me.checkEditAlignToCenter
            Me.layoutControlItemAlignToCenter.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItemAlignToCenter.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemAlignToCenter.Name = "layoutControlItemAlignToCenter"
            Me.layoutControlItemAlignToCenter.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAlignToCenter.Text = "Align To Center"
            Me.layoutControlItemAlignToCenter.TextVisible = False
            ' 
            ' layoutControlItemAutoHeightToWidthRatio
            ' 
            Me.layoutControlItemAutoHeightToWidthRatio.Control = Me.checkEditAutoHeightToWidthRatio
            Me.layoutControlItemAutoHeightToWidthRatio.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemAutoHeightToWidthRatio.Name = "layoutControlItemAutoHeightToWidthRatio"
            Me.layoutControlItemAutoHeightToWidthRatio.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemAutoHeightToWidthRatio.TextVisible = False
            ' 
            ' layoutControlItemPointDistance
            ' 
            Me.layoutControlItemPointDistance.Control = Me.spinEditPointDistance
            Me.layoutControlItemPointDistance.CustomizationFormText = "Size:"
            Me.layoutControlItemPointDistance.Location = New System.Drawing.Point(0, 72)
            Me.layoutControlItemPointDistance.Name = "layoutControlItemPointDistance"
            Me.layoutControlItemPointDistance.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPointDistance.Text = "Point Distance:"
            Me.layoutControlItemPointDistance.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemHeightToWidthRatio
            ' 
            Me.layoutControlItemHeightToWidthRatio.Control = Me.comboBoxEditHeightToWidthRatio
            Me.layoutControlItemHeightToWidthRatio.CustomizationFormText = "Kind:"
            Me.layoutControlItemHeightToWidthRatio.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemHeightToWidthRatio.Name = "layoutControlItemHeightToWidthRatio"
            Me.layoutControlItemHeightToWidthRatio.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemHeightToWidthRatio.Text = "Height / Width:"
            Me.layoutControlItemHeightToWidthRatio.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemGroupSeriesBy
            ' 
            Me.layoutControlItemGroupSeriesBy.Control = Me.comboBoxEditGroupSeriesBy
            Me.layoutControlItemGroupSeriesBy.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemGroupSeriesBy.Name = "layoutControlItemGroupSeriesBy"
            Me.layoutControlItemGroupSeriesBy.Size = New System.Drawing.Size(241, 34)
            Me.layoutControlItemGroupSeriesBy.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 0)
            Me.layoutControlItemGroupSeriesBy.Text = "Group Series By:"
            Me.layoutControlItemGroupSeriesBy.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemInnerIndent
            ' 
            Me.layoutControlItemInnerIndent.Control = Me.spinEditInnerIndent
            Me.layoutControlItemInnerIndent.Location = New System.Drawing.Point(0, 58)
            Me.layoutControlItemInnerIndent.Name = "layoutControlItemInnerIndent"
            Me.layoutControlItemInnerIndent.Size = New System.Drawing.Size(241, 34)
            Me.layoutControlItemInnerIndent.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 10)
            Me.layoutControlItemInnerIndent.Text = "Inner Indent:"
            Me.layoutControlItemInnerIndent.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlItemNestedDoughnutHoleRadius
            ' 
            Me.layoutControlItemNestedDoughnutHoleRadius.Control = Me.spinEditNestedDoughnutHoleRadius
            Me.layoutControlItemNestedDoughnutHoleRadius.Location = New System.Drawing.Point(0, 34)
            Me.layoutControlItemNestedDoughnutHoleRadius.Name = "layoutControlItemNestedDoughnutHoleRadius"
            Me.layoutControlItemNestedDoughnutHoleRadius.Size = New System.Drawing.Size(241, 24)
            Me.layoutControlItemNestedDoughnutHoleRadius.Spacing = New DevExpress.XtraLayout.Utils.Padding(10, 10, 0, 0)
            Me.layoutControlItemNestedDoughnutHoleRadius.Text = "Hole Radius:"
            Me.layoutControlItemNestedDoughnutHoleRadius.TextSize = New System.Drawing.Size(80, 13)
            ' 
            ' layoutControlGroupTotalLabel
            ' 
            Me.layoutControlGroupTotalLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupTotalLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemTotalLabelVisible})
            Me.layoutControlGroupTotalLabel.Location = New System.Drawing.Point(0, 434)
            Me.layoutControlGroupTotalLabel.Name = "layoutControlGroupTotalLabel"
            Me.layoutControlGroupTotalLabel.Size = New System.Drawing.Size(241, 66)
            Me.layoutControlGroupTotalLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupTotalLabel.Text = "Total Label"
            ' 
            ' layoutControlItemTotalLabelVisible
            ' 
            Me.layoutControlItemTotalLabelVisible.Control = Me.checkEditTotalLabelVisible
            Me.layoutControlItemTotalLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemTotalLabelVisible.Name = "layoutControlItemTotalLabelVisible"
            Me.layoutControlItemTotalLabelVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemTotalLabelVisible.TextVisible = False
            ' 
            ' PieDoughnutFunnelViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PieDoughnutFunnelViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentPie), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentDoughnut), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentNestedDoughnut), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFunnel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelPie.ResumeLayout(False)
            Me.dockPanelPie_Container.ResumeLayout(False)
            CType((pieSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((seriesTitle1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPie), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFunnel.ResumeLayout(False)
            Me.dockPanelFunnel_Container.ResumeLayout(False)
            CType((simpleDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((funnelSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((funnelSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFunnel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelDoughnut.ResumeLayout(False)
            Me.dockPanelDoughnut_Container.ResumeLayout(False)
            CType((doughnutSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnutSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pieSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartDoughnut), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelNestedDoughnut.ResumeLayout(False)
            Me.dockPanelNestedDoughnut_Container.ResumeLayout(False)
            CType((customLegendItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((customLegendItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((legend1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((nestedDoughnutSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((nestedDoughnutSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartNestedDoughnut), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditPointDistance.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAlignToCenter.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditHeightToWidthRatio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditDoughnutHoleRadius.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditExplodedPoints.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditLabelPosition.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditTotalLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditInnerIndent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditAutoHeightToWidthRatio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditGroupSeriesBy.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditNestedDoughnutHoleRadius.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlOptionsGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPosition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupPieDoughnutGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemExplodedPoints), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPieDoughnutHoleRadius), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupFunnelGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAlignToCenter), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemAutoHeightToWidthRatio), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPointDistance), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemHeightToWidthRatio), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemGroupSeriesBy), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemInnerIndent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemNestedDoughnutHoleRadius), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupTotalLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTotalLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelPie As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelPie_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentPie As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentDoughnut As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentNestedDoughnut As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFunnel As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private dockPanelDoughnut As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelDoughnut_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelNestedDoughnut As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelNestedDoughnut_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFunnel As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFunnel_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit

        Private spinEditPointDistance As DevExpress.XtraEditors.SpinEdit

        Private checkEditAlignToCenter As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditHeightToWidthRatio As DevExpress.XtraEditors.ComboBoxEdit

        Private spinEditDoughnutHoleRadius As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditExplodedPoints As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditLabelPosition As DevExpress.XtraEditors.ComboBoxEdit

        Private checkEditTotalLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlOptionsGroup As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemValueAsPercent As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemPosition As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupPieDoughnutGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemPieDoughnutHoleRadius As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemExplodedPoints As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroupFunnelGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemPointDistance As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemAlignToCenter As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemHeightToWidthRatio As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditInnerIndent As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemInnerIndent As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemGroupSeriesBy As DevExpress.XtraLayout.LayoutControlItem

        Private checkEditAutoHeightToWidthRatio As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItemAutoHeightToWidthRatio As DevExpress.XtraLayout.LayoutControlItem

        Private chartPie As DevExpress.XtraCharts.ChartControl

        Private chartDoughnut As DevExpress.XtraCharts.ChartControl

        Private chartFunnel As DevExpress.XtraCharts.ChartControl

        Private layoutControlItemTotalLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditGroupSeriesBy As DevExpress.XtraEditors.ComboBoxEdit

        Private spinEditNestedDoughnutHoleRadius As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemNestedDoughnutHoleRadius As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupTotalLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private chartNestedDoughnut As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
