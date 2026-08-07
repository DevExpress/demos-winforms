Namespace DevExpress.XtraCharts.Demos

    Partial Class Pie3DDoughnut3DFunnel3DViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.Pie3DDoughnut3DFunnel3DViewsDemo))
            Dim simpleDiagram3D1 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pie3DSeriesLabel1 As DevExpress.XtraCharts.Pie3DSeriesLabel = New DevExpress.XtraCharts.Pie3DSeriesLabel()
            Dim seriesPoint1 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() {(CObj((17.0752R)))}, 0)
            Dim seriesPoint2 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() {(CObj((9.98467R)))}, 1)
            Dim seriesPoint3 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("USA", New Object() {(CObj((9.63142R)))}, 2)
            Dim seriesPoint4 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("China", New Object() {(CObj((9.59696R)))}, 3)
            Dim seriesPoint5 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() {(CObj((8.511965R)))}, 4)
            Dim seriesPoint6 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() {(CObj((7.68685R)))}, 5)
            Dim seriesPoint7 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("India", New Object() {(CObj((3.28759R)))}, 6)
            Dim seriesPoint8 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Others", New Object() {(CObj((81.2R)))}, 7)
            Dim pie3DSeriesView1 As DevExpress.XtraCharts.Pie3DSeriesView = New DevExpress.XtraCharts.Pie3DSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim simpleDiagram3D2 As DevExpress.XtraCharts.SimpleDiagram3D = New DevExpress.XtraCharts.SimpleDiagram3D()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim doughnut3DSeriesLabel1 As DevExpress.XtraCharts.Doughnut3DSeriesLabel = New DevExpress.XtraCharts.Doughnut3DSeriesLabel()
            Dim seriesPoint9 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() {(CObj((17.0752R)))}, 0)
            Dim seriesPoint10 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() {(CObj((9.98467R)))}, 1)
            Dim seriesPoint11 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("USA", New Object() {(CObj((9.63142R)))}, 2)
            Dim seriesPoint12 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("China", New Object() {(CObj((9.59696R)))}, 3)
            Dim seriesPoint13 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() {(CObj((8.511965R)))}, 4)
            Dim seriesPoint14 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() {(CObj((7.68685R)))}, 5)
            Dim seriesPoint15 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("India", New Object() {(CObj((3.28759R)))}, 6)
            Dim seriesPoint16 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Others", New Object() {(CObj((81.2R)))}, 7)
            Dim doughnut3DSeriesView1 As DevExpress.XtraCharts.Doughnut3DSeriesView = New DevExpress.XtraCharts.Doughnut3DSeriesView()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim funnelDiagram3D1 As DevExpress.XtraCharts.FunnelDiagram3D = New DevExpress.XtraCharts.FunnelDiagram3D()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim funnel3DSeriesLabel1 As DevExpress.XtraCharts.Funnel3DSeriesLabel = New DevExpress.XtraCharts.Funnel3DSeriesLabel()
            Dim seriesPoint17 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Visited a Website", New Object() {(CObj((9152R)))})
            Dim seriesPoint18 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Downloaded a Trial", New Object() {(CObj((6870R)))})
            Dim seriesPoint19 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Contacted to Support", New Object() {(CObj((5121R)))})
            Dim seriesPoint20 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Subscribed", New Object() {(CObj((2224R)))})
            Dim seriesPoint21 As DevExpress.XtraCharts.SeriesPoint = New DevExpress.XtraCharts.SeriesPoint("Renewed", New Object() {(CObj((1670R)))})
            Dim funnel3DSeriesView1 As DevExpress.XtraCharts.Funnel3DSeriesView = New DevExpress.XtraCharts.Funnel3DSeriesView()
            Dim funnel3DSeriesView2 As DevExpress.XtraCharts.Funnel3DSeriesView = New DevExpress.XtraCharts.Funnel3DSeriesView()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentPie3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentDoughnut3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFunnel3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelPie3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelPie3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartPie3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelDoughnut3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelDoughnut3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartDoughnut3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFunnel3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFunnel3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFunnel3D = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditPerspectiveAngle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.simpleButtonRestoreDefaultAngles = New DevExpress.XtraEditors.SimpleButton()
            Me.spinEditHoleRadius = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditExplodedPoints = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditHeightToWidthRatio = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditPointDistance = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditExplodedDistance = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditFunnelHoleRadius = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupPieDoughnutGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemDoughnutHoleRadius = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupExplodedDistance = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemExplodedPoints = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPosition = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemValueAsPercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupFunnelGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemPointDistance = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemHeightToWidthRatio = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemFunnelHoleRadius = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupCamera = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemPerspectiveAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRestoreDefaultAngles = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentPie3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentDoughnut3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFunnel3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelPie3D.SuspendLayout()
            Me.dockPanelPie3D_Container.SuspendLayout()
            CType((Me.chartPie3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((simpleDiagram3D1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pie3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pie3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelDoughnut3D.SuspendLayout()
            Me.dockPanelDoughnut3D_Container.SuspendLayout()
            CType((Me.chartDoughnut3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((simpleDiagram3D2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnut3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((doughnut3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFunnel3D.SuspendLayout()
            Me.dockPanelFunnel3D_Container.SuspendLayout()
            CType((Me.chartFunnel3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnelDiagram3D1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnel3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnel3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((funnel3DSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditHoleRadius.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditExplodedPoints.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditHeightToWidthRatio.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditPointDistance.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditLabelPosition.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditExplodedDistance.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditFunnelHoleRadius.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupPieDoughnutGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemDoughnutHoleRadius), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupExplodedDistance), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemExplodedPoints), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPosition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupFunnelGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPointDistance), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemHeightToWidthRatio), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemFunnelHoleRadius), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPerspectiveAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentPie3D, Me.documentDoughnut3D, Me.documentFunnel3D})
            ' 
            ' documentPie3D
            ' 
            Me.documentPie3D.Caption = "Pie 3D"
            Me.documentPie3D.ControlName = "dockPanelPie3D"
            Me.documentPie3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentPie3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentPie3D.ImageOptions.SvgImage = CType((resources.GetObject("documentPie3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentPie3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentPie3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentPie3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentPie3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentDoughnut3D
            ' 
            Me.documentDoughnut3D.Caption = "Doughnut 3D"
            Me.documentDoughnut3D.ControlName = "dockPanelDoughnut3D"
            Me.documentDoughnut3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentDoughnut3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentDoughnut3D.ImageOptions.SvgImage = CType((resources.GetObject("documentDoughnut3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentDoughnut3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentDoughnut3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentDoughnut3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentDoughnut3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFunnel3D
            ' 
            Me.documentFunnel3D.Caption = "Funnel 3D"
            Me.documentFunnel3D.ControlName = "dockPanelFunnel3D"
            Me.documentFunnel3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentFunnel3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFunnel3D.ImageOptions.SvgImage = CType((resources.GetObject("documentFunnel3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFunnel3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFunnel3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFunnel3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFunnel3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelPie3D, Me.dockPanelDoughnut3D, Me.dockPanelFunnel3D})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelPie3D
            ' 
            Me.dockPanelPie3D.Controls.Add(Me.dockPanelPie3D_Container)
            Me.dockPanelPie3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelPie3D.DockedAsTabbedDocument = True
            Me.dockPanelPie3D.ID = New System.Guid("7e379c16-fc83-4f40-9a2f-161f41dcd445")
            Me.dockPanelPie3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPie3D.Name = "dockPanelPie3D"
            Me.dockPanelPie3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelPie3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelPie3D.Text = "Pie 3D"
            ' 
            ' dockPanelPie3D_Container
            ' 
            Me.dockPanelPie3D_Container.Controls.Add(Me.chartPie3D)
            Me.dockPanelPie3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPie3D_Container.Name = "dockPanelPie3D_Container"
            Me.dockPanelPie3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelPie3D_Container.TabIndex = 0
            ' 
            ' chartPie3D
            ' 
            Me.chartPie3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            simpleDiagram3D1.LabelsResolveOverlappingMinIndent = 5
            simpleDiagram3D1.RotationMatrixSerializable = "0.965925826289068;0.258819045102521;0;0;-0.212012149896655;0.791240115236224;-0.5" & "73576436351046;0;-0.148452505549685;0.554032293222323;0.819152044288992;0;0;0;0;" & "1"
            simpleDiagram3D1.RuntimeRotation = True
            simpleDiagram3D1.RuntimeScrolling = True
            simpleDiagram3D1.RuntimeZooming = True
            Me.chartPie3D.Diagram = simpleDiagram3D1
            Me.chartPie3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPie3D.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartPie3D.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartPie3D.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartPie3D.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPie3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartPie3D.Legend.Name = "Default Legend"
            Me.chartPie3D.Location = New System.Drawing.Point(0, 0)
            Me.chartPie3D.Name = "chartPie3D"
            pie3DSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            pie3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Radial
            pie3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.[Default]
            pie3DSeriesLabel1.TextPattern = "{A}: {VP:P2}"
            series1.Label = pie3DSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.LegendTextPattern = "{A}"
            series1.Name = "Series 1"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series1.SeriesID = 0
            series1.View = pie3DSeriesView1
            Me.chartPie3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartPie3D.Size = New System.Drawing.Size(788, 548)
            Me.chartPie3D.TabIndex = 1
            chartTitle1.Indent = 10
            chartTitle1.Text = "Land Area by Country"
            chartTitle1.TitleID = 0
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www.nationmaster.com"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            chartTitle2.TitleID = 1
            Me.chartPie3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' dockPanelDoughnut3D
            ' 
            Me.dockPanelDoughnut3D.Controls.Add(Me.dockPanelDoughnut3D_Container)
            Me.dockPanelDoughnut3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelDoughnut3D.DockedAsTabbedDocument = True
            Me.dockPanelDoughnut3D.ID = New System.Guid("a60845bf-46cb-4dc4-8479-8abe2e400624")
            Me.dockPanelDoughnut3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelDoughnut3D.Name = "dockPanelDoughnut3D"
            Me.dockPanelDoughnut3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelDoughnut3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelDoughnut3D.Text = "Doughnut 3D"
            ' 
            ' dockPanelDoughnut3D_Container
            ' 
            Me.dockPanelDoughnut3D_Container.Controls.Add(Me.chartDoughnut3D)
            Me.dockPanelDoughnut3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelDoughnut3D_Container.Name = "dockPanelDoughnut3D_Container"
            Me.dockPanelDoughnut3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelDoughnut3D_Container.TabIndex = 0
            ' 
            ' chartDoughnut3D
            ' 
            Me.chartDoughnut3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            simpleDiagram3D2.LabelsResolveOverlappingMinIndent = 3
            simpleDiagram3D2.RotationMatrixSerializable = "0.965925826289068;0.258819045102521;0;0;-0.212012149896655;0.791240115236224;-0.5" & "73576436351046;0;-0.148452505549685;0.554032293222323;0.819152044288992;0;0;0;0;" & "1"
            simpleDiagram3D2.RuntimeRotation = True
            simpleDiagram3D2.RuntimeScrolling = True
            simpleDiagram3D2.RuntimeZooming = True
            Me.chartDoughnut3D.Diagram = simpleDiagram3D2
            Me.chartDoughnut3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartDoughnut3D.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartDoughnut3D.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartDoughnut3D.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartDoughnut3D.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartDoughnut3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartDoughnut3D.Legend.Name = "Default Legend"
            Me.chartDoughnut3D.Location = New System.Drawing.Point(0, 0)
            Me.chartDoughnut3D.Name = "chartDoughnut3D"
            doughnut3DSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F, DevExpress.Drawing.DXFontStyle.Bold)
            doughnut3DSeriesLabel1.Position = DevExpress.XtraCharts.PieSeriesLabelPosition.Radial
            doughnut3DSeriesLabel1.TextPattern = "{A}: {VP:P2}"
            series2.Label = doughnut3DSeriesLabel1
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.LegendTextPattern = "{A}"
            series2.Name = "Series 1"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16})
            series2.SeriesID = 0
            series2.View = doughnut3DSeriesView1
            Me.chartDoughnut3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
            Me.chartDoughnut3D.Size = New System.Drawing.Size(788, 548)
            Me.chartDoughnut3D.TabIndex = 1
            chartTitle3.Indent = 10
            chartTitle3.Text = "Land Area by Country"
            chartTitle3.TitleID = 0
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle4.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle4.Text = "From www.nationmaster.com"
            chartTitle4.TextColor = System.Drawing.Color.Gray
            chartTitle4.TitleID = 1
            Me.chartDoughnut3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3, chartTitle4})
            ' 
            ' dockPanelFunnel3D
            ' 
            Me.dockPanelFunnel3D.Controls.Add(Me.dockPanelFunnel3D_Container)
            Me.dockPanelFunnel3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFunnel3D.DockedAsTabbedDocument = True
            Me.dockPanelFunnel3D.ID = New System.Guid("9c19101a-e027-4676-8069-588cb77f9d5b")
            Me.dockPanelFunnel3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFunnel3D.Name = "dockPanelFunnel3D"
            Me.dockPanelFunnel3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFunnel3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelFunnel3D.Text = "Funnel 3D"
            ' 
            ' dockPanelFunnel3D_Container
            ' 
            Me.dockPanelFunnel3D_Container.Controls.Add(Me.chartFunnel3D)
            Me.dockPanelFunnel3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFunnel3D_Container.Name = "dockPanelFunnel3D_Container"
            Me.dockPanelFunnel3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelFunnel3D_Container.TabIndex = 0
            ' 
            ' chartFunnel3D
            ' 
            Me.chartFunnel3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            funnelDiagram3D1.RotationMatrixSerializable = "1;0;0;0;0;0.866025403784439;0.5;0;0;-0.5;0.866025403784439;0;0;0;0;1"
            funnelDiagram3D1.RuntimeRotation = True
            funnelDiagram3D1.RuntimeScrolling = True
            funnelDiagram3D1.RuntimeZooming = True
            Me.chartFunnel3D.Diagram = funnelDiagram3D1
            Me.chartFunnel3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFunnel3D.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartFunnel3D.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Bottom
            Me.chartFunnel3D.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartFunnel3D.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartFunnel3D.Legend.Name = "Default Legend"
            Me.chartFunnel3D.Location = New System.Drawing.Point(0, 0)
            Me.chartFunnel3D.Name = "chartFunnel3D"
            funnel3DSeriesLabel1.LineLength = 40
            funnel3DSeriesLabel1.TextPattern = "{A}: {VP:P0}"
            series3.Label = funnel3DSeriesLabel1
            series3.LegendTextPattern = "{A}"
            series3.Name = "Series 1"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() {seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21})
            series3.SeriesID = 0
            funnel3DSeriesView1.PointDistance = 10
            series3.View = funnel3DSeriesView1
            Me.chartFunnel3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series3}
            Me.chartFunnel3D.SeriesTemplate.View = funnel3DSeriesView2
            Me.chartFunnel3D.Size = New System.Drawing.Size(788, 548)
            Me.chartFunnel3D.TabIndex = 1
            chartTitle5.Text = "Website Visitor Trend"
            chartTitle5.TitleID = 0
            Me.chartFunnel3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle5})
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
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentPie3D, Me.documentDoughnut3D, Me.documentFunnel3D})
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
            Me.layoutControl.Controls.Add(Me.comboBoxEditPerspectiveAngle)
            Me.layoutControl.Controls.Add(Me.simpleButtonRestoreDefaultAngles)
            Me.layoutControl.Controls.Add(Me.spinEditHoleRadius)
            Me.layoutControl.Controls.Add(Me.comboBoxEditExplodedPoints)
            Me.layoutControl.Controls.Add(Me.comboBoxEditHeightToWidthRatio)
            Me.layoutControl.Controls.Add(Me.spinEditPointDistance)
            Me.layoutControl.Controls.Add(Me.comboBoxEditLabelPosition)
            Me.layoutControl.Controls.Add(Me.spinEditExplodedDistance)
            Me.layoutControl.Controls.Add(Me.spinEditFunnelHoleRadius)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(325, 182, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 262)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 3
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' checkEditValueAsPercent
            ' 
            Me.checkEditValueAsPercent.Location = New System.Drawing.Point(12, 286)
            Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
            Me.checkEditValueAsPercent.Properties.Caption = "Value as Percent"
            Me.checkEditValueAsPercent.Size = New System.Drawing.Size(217, 20)
            Me.checkEditValueAsPercent.StyleController = Me.layoutControl
            Me.checkEditValueAsPercent.TabIndex = 5
            ' 
            ' comboBoxEditPerspectiveAngle
            ' 
            Me.comboBoxEditPerspectiveAngle.Location = New System.Drawing.Point(137, 376)
            Me.comboBoxEditPerspectiveAngle.Name = "comboBoxEditPerspectiveAngle"
            Me.comboBoxEditPerspectiveAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditPerspectiveAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditPerspectiveAngle.Size = New System.Drawing.Size(92, 20)
            Me.comboBoxEditPerspectiveAngle.StyleController = Me.layoutControl
            Me.comboBoxEditPerspectiveAngle.TabIndex = 6
            ' 
            ' simpleButtonRestoreDefaultAngles
            ' 
            Me.simpleButtonRestoreDefaultAngles.Location = New System.Drawing.Point(12, 408)
            Me.simpleButtonRestoreDefaultAngles.Name = "simpleButtonRestoreDefaultAngles"
            Me.simpleButtonRestoreDefaultAngles.Size = New System.Drawing.Size(217, 22)
            Me.simpleButtonRestoreDefaultAngles.StyleController = Me.layoutControl
            Me.simpleButtonRestoreDefaultAngles.TabIndex = 7
            Me.simpleButtonRestoreDefaultAngles.Text = "Restore Default Angles"
            ' 
            ' spinEditHoleRadius
            ' 
            Me.spinEditHoleRadius.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditHoleRadius.Location = New System.Drawing.Point(137, 58)
            Me.spinEditHoleRadius.Name = "spinEditHoleRadius"
            Me.spinEditHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditHoleRadius.Properties.DisplayFormat.FormatString = "0\%"
            Me.spinEditHoleRadius.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditHoleRadius.Properties.IsFloatValue = False
            Me.spinEditHoleRadius.Properties.Mask.EditMask = "N00"
            Me.spinEditHoleRadius.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEditHoleRadius.Size = New System.Drawing.Size(92, 20)
            Me.spinEditHoleRadius.StyleController = Me.layoutControl
            Me.spinEditHoleRadius.TabIndex = 12
            ' 
            ' comboBoxEditExplodedPoints
            ' 
            Me.comboBoxEditExplodedPoints.Location = New System.Drawing.Point(137, 34)
            Me.comboBoxEditExplodedPoints.Name = "comboBoxEditExplodedPoints"
            Me.comboBoxEditExplodedPoints.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditExplodedPoints.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditExplodedPoints.Size = New System.Drawing.Size(92, 20)
            Me.comboBoxEditExplodedPoints.StyleController = Me.layoutControl
            Me.comboBoxEditExplodedPoints.TabIndex = 13
            AddHandler Me.comboBoxEditExplodedPoints.EditValueChanged, New System.EventHandler(AddressOf Me.comboBoxEditExplodedPoints_SelectedIndexChanged)
            ' 
            ' comboBoxEditHeightToWidthRatio
            ' 
            Me.comboBoxEditHeightToWidthRatio.Location = New System.Drawing.Point(137, 196)
            Me.comboBoxEditHeightToWidthRatio.Name = "comboBoxEditHeightToWidthRatio"
            Me.comboBoxEditHeightToWidthRatio.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditHeightToWidthRatio.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditHeightToWidthRatio.Size = New System.Drawing.Size(92, 20)
            Me.comboBoxEditHeightToWidthRatio.StyleController = Me.layoutControl
            Me.comboBoxEditHeightToWidthRatio.TabIndex = 5
            AddHandler Me.comboBoxEditHeightToWidthRatio.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditHeightToWidthRatio_SelectedIndexChanged)
            ' 
            ' spinEditPointDistance
            ' 
            Me.spinEditPointDistance.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditPointDistance.Location = New System.Drawing.Point(137, 172)
            Me.spinEditPointDistance.Name = "spinEditPointDistance"
            Me.spinEditPointDistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditPointDistance.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditPointDistance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditPointDistance.Properties.IsFloatValue = False
            Me.spinEditPointDistance.Properties.Mask.EditMask = "N00"
            Me.spinEditPointDistance.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditPointDistance.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditPointDistance.Size = New System.Drawing.Size(92, 20)
            Me.spinEditPointDistance.StyleController = Me.layoutControl
            Me.spinEditPointDistance.TabIndex = 8
            AddHandler Me.spinEditPointDistance.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditPointDistance_EditValueChanged)
            ' 
            ' comboBoxEditLabelPosition
            ' 
            Me.comboBoxEditLabelPosition.Location = New System.Drawing.Point(137, 310)
            Me.comboBoxEditLabelPosition.Name = "comboBoxEditLabelPosition"
            Me.comboBoxEditLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditLabelPosition.Size = New System.Drawing.Size(92, 20)
            Me.comboBoxEditLabelPosition.StyleController = Me.layoutControl
            Me.comboBoxEditLabelPosition.TabIndex = 14
            AddHandler Me.comboBoxEditLabelPosition.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditLabelPosition_SelectedIndexChanged)
            ' 
            ' spinEditExplodedDistance
            ' 
            Me.spinEditExplodedDistance.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditExplodedDistance.Location = New System.Drawing.Point(137, 82)
            Me.spinEditExplodedDistance.Name = "spinEditExplodedDistance"
            Me.spinEditExplodedDistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditExplodedDistance.Properties.DisplayFormat.FormatString = "0px"
            Me.spinEditExplodedDistance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditExplodedDistance.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEditExplodedDistance.Properties.IsFloatValue = False
            Me.spinEditExplodedDistance.Properties.Mask.EditMask = "N00"
            Me.spinEditExplodedDistance.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.spinEditExplodedDistance.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditExplodedDistance.Size = New System.Drawing.Size(92, 20)
            Me.spinEditExplodedDistance.StyleController = Me.layoutControl
            Me.spinEditExplodedDistance.TabIndex = 17
            AddHandler Me.spinEditExplodedDistance.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditExplodedDistance_EditValueChanged)
            ' 
            ' spinEditFunnelHoleRadius
            ' 
            Me.spinEditFunnelHoleRadius.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditFunnelHoleRadius.Location = New System.Drawing.Point(137, 148)
            Me.spinEditFunnelHoleRadius.Name = "spinEditFunnelHoleRadius"
            Me.spinEditFunnelHoleRadius.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditFunnelHoleRadius.Properties.DisplayFormat.FormatString = "0\%"
            Me.spinEditFunnelHoleRadius.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditFunnelHoleRadius.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.spinEditFunnelHoleRadius.Properties.IsFloatValue = False
            Me.spinEditFunnelHoleRadius.Properties.Mask.EditMask = "N00"
            Me.spinEditFunnelHoleRadius.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None
            Me.spinEditFunnelHoleRadius.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinEditFunnelHoleRadius.Size = New System.Drawing.Size(92, 20)
            Me.spinEditFunnelHoleRadius.StyleController = Me.layoutControl
            Me.spinEditFunnelHoleRadius.TabIndex = 18
            AddHandler Me.spinEditFunnelHoleRadius.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditFunnelHoleRadius_EditValueChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupPieDoughnutGeneral, Me.layoutControlGroupLabel, Me.emptySpaceItem, Me.layoutControlGroupFunnelGeneral, Me.layoutControlGroupCamera})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupPieDoughnutGeneral
            ' 
            Me.layoutControlGroupPieDoughnutGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupPieDoughnutGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupPieDoughnutGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupPieDoughnutGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemDoughnutHoleRadius, Me.layoutControlGroupExplodedDistance, Me.layoutControlItemExplodedPoints})
            Me.layoutControlGroupPieDoughnutGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupPieDoughnutGeneral.Name = "layoutControlGroupPieDoughnutGeneral"
            Me.layoutControlGroupPieDoughnutGeneral.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupPieDoughnutGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupPieDoughnutGeneral.Text = "General"
            ' 
            ' layoutControlItemDoughnutHoleRadius
            ' 
            Me.layoutControlItemDoughnutHoleRadius.Control = Me.spinEditHoleRadius
            Me.layoutControlItemDoughnutHoleRadius.CustomizationFormText = "HoleRadius (%)"
            Me.layoutControlItemDoughnutHoleRadius.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemDoughnutHoleRadius.Name = "layoutControlItemDoughnutHoleRadius"
            Me.layoutControlItemDoughnutHoleRadius.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemDoughnutHoleRadius.Text = "Hole Radius:"
            Me.layoutControlItemDoughnutHoleRadius.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlGroupExplodedDistance
            ' 
            Me.layoutControlGroupExplodedDistance.Control = Me.spinEditExplodedDistance
            Me.layoutControlGroupExplodedDistance.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlGroupExplodedDistance.Name = "layoutControlGroupExplodedDistanstance"
            Me.layoutControlGroupExplodedDistance.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlGroupExplodedDistance.Text = "Exploded Distanstance:"
            Me.layoutControlGroupExplodedDistance.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItemExplodedPoints
            ' 
            Me.layoutControlItemExplodedPoints.Control = Me.comboBoxEditExplodedPoints
            Me.layoutControlItemExplodedPoints.CustomizationFormText = "Exploded Points"
            Me.layoutControlItemExplodedPoints.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemExplodedPoints.Name = "layoutControlItemExplodedPoints"
            Me.layoutControlItemExplodedPoints.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemExplodedPoints.Text = "Exploded Points:"
            Me.layoutControlItemExplodedPoints.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemPosition, Me.layoutControlItemValueAsPercent})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 228)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' layoutControlItemPosition
            ' 
            Me.layoutControlItemPosition.Control = Me.comboBoxEditLabelPosition
            Me.layoutControlItemPosition.CustomizationFormText = "Label Position"
            Me.layoutControlItemPosition.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemPosition.Name = "layoutControlItemPosition"
            Me.layoutControlItemPosition.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPosition.Text = "Position:"
            Me.layoutControlItemPosition.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItemValueAsPercent
            ' 
            Me.layoutControlItemValueAsPercent.Control = Me.checkEditValueAsPercent
            Me.layoutControlItemValueAsPercent.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemValueAsPercent.Name = "layoutControlItemValueAsPercent"
            Me.layoutControlItemValueAsPercent.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemValueAsPercent.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItemValueAsPercent.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 442)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 96)
            ' 
            ' layoutControlGroupFunnelGeneral
            ' 
            Me.layoutControlGroupFunnelGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupFunnelGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupFunnelGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupFunnelGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemPointDistance, Me.layoutControlItemHeightToWidthRatio, Me.layoutControlItemFunnelHoleRadius})
            Me.layoutControlGroupFunnelGeneral.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlGroupFunnelGeneral.Name = "layoutControlGroupFunnelGeneral"
            Me.layoutControlGroupFunnelGeneral.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupFunnelGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupFunnelGeneral.Text = "General"
            ' 
            ' layoutControlItemPointDistance
            ' 
            Me.layoutControlItemPointDistance.Control = Me.spinEditPointDistance
            Me.layoutControlItemPointDistance.CustomizationFormText = "Size:"
            Me.layoutControlItemPointDistance.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemPointDistance.Name = "layoutControlItemPointDistance"
            Me.layoutControlItemPointDistance.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPointDistance.Text = "Point Distance:"
            Me.layoutControlItemPointDistance.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItemHeightToWidthRatio
            ' 
            Me.layoutControlItemHeightToWidthRatio.Control = Me.comboBoxEditHeightToWidthRatio
            Me.layoutControlItemHeightToWidthRatio.CustomizationFormText = "Kind:"
            Me.layoutControlItemHeightToWidthRatio.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemHeightToWidthRatio.Name = "layoutControlItemHeightToWidthRatio"
            Me.layoutControlItemHeightToWidthRatio.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemHeightToWidthRatio.Text = "Height / Width Ratio:"
            Me.layoutControlItemHeightToWidthRatio.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItemFunnelHoleRadius
            ' 
            Me.layoutControlItemFunnelHoleRadius.Control = Me.spinEditFunnelHoleRadius
            Me.layoutControlItemFunnelHoleRadius.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemFunnelHoleRadius.Name = "layoutControlItemFunnelHoleRadius"
            Me.layoutControlItemFunnelHoleRadius.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemFunnelHoleRadius.Text = "Hole Radius:"
            Me.layoutControlItemFunnelHoleRadius.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlGroupCamera
            ' 
            Me.layoutControlGroupCamera.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupCamera.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupCamera.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupCamera.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemPerspectiveAngle, Me.layoutControlItemRestoreDefaultAngles})
            Me.layoutControlGroupCamera.Location = New System.Drawing.Point(0, 342)
            Me.layoutControlGroupCamera.Name = "layoutControlGroupCamera"
            Me.layoutControlGroupCamera.Size = New System.Drawing.Size(241, 100)
            Me.layoutControlGroupCamera.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupCamera.Text = "Camera"
            ' 
            ' layoutControlItemPerspectiveAngle
            ' 
            Me.layoutControlItemPerspectiveAngle.Control = Me.comboBoxEditPerspectiveAngle
            Me.layoutControlItemPerspectiveAngle.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemPerspectiveAngle.Name = "layoutControlItemPerspectiveAngle"
            Me.layoutControlItemPerspectiveAngle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPerspectiveAngle.Text = "Perspective Angle:"
            Me.layoutControlItemPerspectiveAngle.TextSize = New System.Drawing.Size(113, 13)
            ' 
            ' layoutControlItemRestoreDefaultAngles
            ' 
            Me.layoutControlItemRestoreDefaultAngles.Control = Me.simpleButtonRestoreDefaultAngles
            Me.layoutControlItemRestoreDefaultAngles.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemRestoreDefaultAngles.Name = "layoutControlItemRestoreDefaultAngles"
            Me.layoutControlItemRestoreDefaultAngles.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 10, 2)
            Me.layoutControlItemRestoreDefaultAngles.Size = New System.Drawing.Size(221, 34)
            Me.layoutControlItemRestoreDefaultAngles.TextVisible = False
            ' 
            ' Pie3DDoughnut3DFunnel3DViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Pie3DDoughnut3DFunnel3DViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentPie3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentDoughnut3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFunnel3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelPie3D.ResumeLayout(False)
            Me.dockPanelPie3D_Container.ResumeLayout(False)
            CType((simpleDiagram3D1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pie3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pie3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPie3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelDoughnut3D.ResumeLayout(False)
            Me.dockPanelDoughnut3D_Container.ResumeLayout(False)
            CType((simpleDiagram3D2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnut3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((doughnut3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartDoughnut3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFunnel3D.ResumeLayout(False)
            Me.dockPanelFunnel3D_Container.ResumeLayout(False)
            CType((funnelDiagram3D1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((funnel3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((funnel3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((funnel3DSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFunnel3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditHoleRadius.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditExplodedPoints.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditHeightToWidthRatio.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditPointDistance.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditLabelPosition.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditExplodedDistance.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditFunnelHoleRadius.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupPieDoughnutGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemDoughnutHoleRadius), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupExplodedDistance), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemExplodedPoints), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPosition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupFunnelGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPointDistance), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemHeightToWidthRatio), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemFunnelHoleRadius), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPerspectiveAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelPie3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelPie3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentPie3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentDoughnut3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFunnel3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private dockPanelDoughnut3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelDoughnut3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFunnel3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFunnel3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditPerspectiveAngle As DevExpress.XtraEditors.ComboBoxEdit

        Private simpleButtonRestoreDefaultAngles As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupCamera As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemPerspectiveAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemRestoreDefaultAngles As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupPieDoughnutGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemValueAsPercent As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private spinEditHoleRadius As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditExplodedPoints As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemDoughnutHoleRadius As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemExplodedPoints As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditHeightToWidthRatio As DevExpress.XtraEditors.ComboBoxEdit

        Private spinEditPointDistance As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemHeightToWidthRatio As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemPointDistance As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditLabelPosition As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemPosition As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditExplodedDistance As DevExpress.XtraEditors.SpinEdit

        Private layoutControlGroupExplodedDistance As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupFunnelGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private spinEditFunnelHoleRadius As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemFunnelHoleRadius As DevExpress.XtraLayout.LayoutControlItem

        Private chartPie3D As DevExpress.XtraCharts.ChartControl

        Private chartDoughnut3D As DevExpress.XtraCharts.ChartControl

        Private chartFunnel3D As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
