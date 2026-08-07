Namespace DevExpress.XtraCharts.Demos

    Partial Class Bar3DViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.Bar3DViewsDemo))
            Dim xyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim bar3DSeriesLabel1 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
            Dim sideBySideBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideBar3DSeriesView = New DevExpress.XtraCharts.SideBySideBar3DSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D2 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim bar3DSeriesLabel2 As DevExpress.XtraCharts.Bar3DSeriesLabel = New DevExpress.XtraCharts.Bar3DSeriesLabel()
            Dim manhattanBarSeriesView1 As DevExpress.XtraCharts.ManhattanBarSeriesView = New DevExpress.XtraCharts.ManhattanBarSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D3 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim stackedBar3DSeriesLabel1 As DevExpress.XtraCharts.StackedBar3DSeriesLabel = New DevExpress.XtraCharts.StackedBar3DSeriesLabel()
            Dim stackedBar3DSeriesView1 As DevExpress.XtraCharts.StackedBar3DSeriesView = New DevExpress.XtraCharts.StackedBar3DSeriesView()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D4 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim stackedBar3DSeriesLabel2 As DevExpress.XtraCharts.StackedBar3DSeriesLabel = New DevExpress.XtraCharts.StackedBar3DSeriesLabel()
            Dim sideBySideStackedBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideStackedBar3DSeriesView = New DevExpress.XtraCharts.SideBySideStackedBar3DSeriesView()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D5 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim fullStackedBar3DSeriesView1 As DevExpress.XtraCharts.FullStackedBar3DSeriesView = New DevExpress.XtraCharts.FullStackedBar3DSeriesView()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D6 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim fullStackedBar3DSeriesLabel1 As DevExpress.XtraCharts.FullStackedBar3DSeriesLabel = New DevExpress.XtraCharts.FullStackedBar3DSeriesLabel()
            Dim sideBySideFullStackedBar3DSeriesView1 As DevExpress.XtraCharts.SideBySideFullStackedBar3DSeriesView = New DevExpress.XtraCharts.SideBySideFullStackedBar3DSeriesView()
            Dim chartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle10 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle11 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentBar3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentManhattanBar = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStackedBar3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStackedBar3DSideBySide = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFullStackedBar3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFullStackedBar3DSideBySide = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelBar3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelBar3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartBar3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelManhattanBar = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelManhattanBar_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartManhattanBar3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStackedBar3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStackedBar3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStackedBar3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStackedBar3DSideBySide = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStackedBar3DSideBySide_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStackedBar3DSideBySide = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFullStackedBar3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFullStackedBar3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFullStackedBar3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFullStackedBar3DSideBySide = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFullStackedBar3DSideBySide_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFullStackedBar3DSideBySide = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditPerspectiveAngle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.simpleButtonRestoreDefaultAngles = New DevExpress.XtraEditors.SimpleButton()
            Me.checkEditShowFacet = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEdit3DModel = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditGroupSeriesBy = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemShowFacet = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGroupSeriesBy = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3DModel = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemValueAsPercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupCamera = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupPerspectiveAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRestoreDefaultAngles = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManhattanBar), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStackedBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFullStackedBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFullStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelBar3D.SuspendLayout()
            Me.dockPanelBar3D_Container.SuspendLayout()
            CType((Me.chartBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bar3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBar3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelManhattanBar.SuspendLayout()
            Me.dockPanelManhattanBar_Container.SuspendLayout()
            CType((Me.chartManhattanBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bar3DSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((manhattanBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStackedBar3D.SuspendLayout()
            Me.dockPanelStackedBar3D_Container.SuspendLayout()
            CType((Me.chartStackedBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBar3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStackedBar3DSideBySide.SuspendLayout()
            Me.dockPanelStackedBar3DSideBySide_Container.SuspendLayout()
            CType((Me.chartStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedBar3DSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideStackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFullStackedBar3D.SuspendLayout()
            Me.dockPanelFullStackedBar3D_Container.SuspendLayout()
            CType((Me.chartFullStackedBar3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((fullStackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFullStackedBar3DSideBySide.SuspendLayout()
            Me.dockPanelFullStackedBar3DSideBySide_Container.SuspendLayout()
            CType((Me.chartFullStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((fullStackedBar3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideFullStackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowFacet.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEdit3DModel.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditGroupSeriesBy.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemShowFacet), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGroupSeriesBy), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3DModel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupPerspectiveAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(721, 0)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentBar3D, Me.documentManhattanBar, Me.documentStackedBar3D, Me.documentStackedBar3DSideBySide, Me.documentFullStackedBar3D, Me.documentFullStackedBar3DSideBySide})
            ' 
            ' documentBar3D
            ' 
            Me.documentBar3D.Caption = "Bar3D"
            Me.documentBar3D.ControlName = "dockPanelBar3D"
            Me.documentBar3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentBar3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentBar3D.ImageOptions.SvgImage = CType((resources.GetObject("documentBar3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentBar3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentBar3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentBar3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentBar3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentManhattanBar
            ' 
            Me.documentManhattanBar.Caption = "Manhattan Bar3D"
            Me.documentManhattanBar.ControlName = "dockPanelManhattanBar"
            Me.documentManhattanBar.FloatLocation = New System.Drawing.Point(113, 130)
            Me.documentManhattanBar.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentManhattanBar.ImageOptions.SvgImage = CType((resources.GetObject("documentManhattanBar.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentManhattanBar.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentManhattanBar.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentManhattanBar.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentManhattanBar.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStackedBar3D
            ' 
            Me.documentStackedBar3D.Caption = "Stacked Bar3D"
            Me.documentStackedBar3D.ControlName = "dockPanelStackedBar3D"
            Me.documentStackedBar3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStackedBar3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStackedBar3D.ImageOptions.SvgImage = CType((resources.GetObject("documentStackedBar3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStackedBar3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStackedBar3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStackedBar3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStackedBar3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStackedBar3DSideBySide
            ' 
            Me.documentStackedBar3DSideBySide.Caption = "Stacked Bar3D Side By Side"
            Me.documentStackedBar3DSideBySide.ControlName = "dockPanelStackedBar3DSideBySide"
            Me.documentStackedBar3DSideBySide.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStackedBar3DSideBySide.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStackedBar3DSideBySide.ImageOptions.SvgImage = CType((resources.GetObject("documentStackedBar3DSideBySide.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStackedBar3DSideBySide.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStackedBar3DSideBySide.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStackedBar3DSideBySide.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStackedBar3DSideBySide.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFullStackedBar3D
            ' 
            Me.documentFullStackedBar3D.Caption = "Full Stacked Bar3D"
            Me.documentFullStackedBar3D.ControlName = "dockPanelFullStackedBar3D"
            Me.documentFullStackedBar3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentFullStackedBar3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFullStackedBar3D.ImageOptions.SvgImage = CType((resources.GetObject("documentFullStackedBar3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFullStackedBar3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFullStackedBar3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFullStackedBar3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFullStackedBar3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFullStackedBar3DSideBySide
            ' 
            Me.documentFullStackedBar3DSideBySide.Caption = "Full Stacked Bar3D SideBy Side"
            Me.documentFullStackedBar3DSideBySide.ControlName = "dockPanelFullStackedBar3DSideBySide"
            Me.documentFullStackedBar3DSideBySide.FloatLocation = New System.Drawing.Point(464, 120)
            Me.documentFullStackedBar3DSideBySide.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFullStackedBar3DSideBySide.ImageOptions.SvgImage = CType((resources.GetObject("documentFullStackedBar3DSideBySide.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFullStackedBar3DSideBySide.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFullStackedBar3DSideBySide.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFullStackedBar3DSideBySide.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFullStackedBar3DSideBySide.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelBar3D, Me.dockPanelManhattanBar, Me.dockPanelStackedBar3D, Me.dockPanelStackedBar3DSideBySide, Me.dockPanelFullStackedBar3D, Me.dockPanelFullStackedBar3DSideBySide})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelBar3D
            ' 
            Me.dockPanelBar3D.Controls.Add(Me.dockPanelBar3D_Container)
            Me.dockPanelBar3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelBar3D.DockedAsTabbedDocument = True
            Me.dockPanelBar3D.ID = New System.Guid("c1ccc590-2ae1-464b-b3cd-58e2eced7315")
            Me.dockPanelBar3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelBar3D.Name = "dockPanelBar3D"
            Me.dockPanelBar3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelBar3D.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelBar3D.Text = "Bar3D"
            ' 
            ' dockPanelBar3D_Container
            ' 
            Me.dockPanelBar3D_Container.Controls.Add(Me.chartBar3D)
            Me.dockPanelBar3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelBar3D_Container.Name = "dockPanelBar3D_Container"
            Me.dockPanelBar3D_Container.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelBar3D_Container.TabIndex = 0
            ' 
            ' chartBar3D
            ' 
            Me.chartBar3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D1.AxisY.Interlaced = False
            xyDiagram3D1.AxisY.Label.TextPattern = "${V}M"
            xyDiagram3D1.AxisY.MinorCount = 2
            xyDiagram3D1.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D1.RuntimeRotation = True
            xyDiagram3D1.RuntimeScrolling = True
            xyDiagram3D1.RuntimeZooming = True
            xyDiagram3D1.VerticalScrollPercent = 6R
            xyDiagram3D1.ZoomPercent = 130
            Me.chartBar3D.Diagram = xyDiagram3D1
            Me.chartBar3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartBar3D.Legend.Name = "Default Legend"
            Me.chartBar3D.Location = New System.Drawing.Point(0, 0)
            Me.chartBar3D.Name = "chartBar3D"
            Me.chartBar3D.SeriesDataMember = "Year"
            Me.chartBar3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartBar3D.SeriesTemplate.ArgumentDataMember = "Region"
            bar3DSeriesLabel1.TextPattern = "{V:F2}"
            Me.chartBar3D.SeriesTemplate.Label = bar3DSeriesLabel1
            Me.chartBar3D.SeriesTemplate.SeriesDataMember = "Year"
            Me.chartBar3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            Me.chartBar3D.SeriesTemplate.View = sideBySideBar3DSeriesView1
            Me.chartBar3D.Size = New System.Drawing.Size(963, 548)
            Me.chartBar3D.TabIndex = 1
            chartTitle1.Text = "DevAV Sales by Regions"
            chartTitle1.TitleID = 0
            Me.chartBar3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' dockPanelManhattanBar
            ' 
            Me.dockPanelManhattanBar.Controls.Add(Me.dockPanelManhattanBar_Container)
            Me.dockPanelManhattanBar.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelManhattanBar.DockedAsTabbedDocument = True
            Me.dockPanelManhattanBar.FloatLocation = New System.Drawing.Point(113, 130)
            Me.dockPanelManhattanBar.ID = New System.Guid("633c6214-6432-435a-9de2-682e0d9c7eda")
            Me.dockPanelManhattanBar.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelManhattanBar.Name = "dockPanelManhattanBar"
            Me.dockPanelManhattanBar.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelManhattanBar.SavedIndex = 0
            Me.dockPanelManhattanBar.SavedMdiDocument = True
            Me.dockPanelManhattanBar.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelManhattanBar.Text = "Manhattan Bar3D"
            ' 
            ' dockPanelManhattanBar_Container
            ' 
            Me.dockPanelManhattanBar_Container.Controls.Add(Me.chartManhattanBar3D)
            Me.dockPanelManhattanBar_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelManhattanBar_Container.Name = "dockPanelManhattanBar_Container"
            Me.dockPanelManhattanBar_Container.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelManhattanBar_Container.TabIndex = 0
            ' 
            ' chartManhattanBar3D
            ' 
            Me.chartManhattanBar3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D2.AxisY.Label.TextPattern = "${V}M"
            xyDiagram3D2.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram3D2.AxisY.NumericScaleOptions.GridSpacing = 100R
            xyDiagram3D2.RotationType = DevExpress.XtraCharts.RotationType.UseAngles
            xyDiagram3D2.RuntimeRotation = True
            xyDiagram3D2.RuntimeScrolling = True
            xyDiagram3D2.RuntimeZooming = True
            xyDiagram3D2.VerticalScrollPercent = 6R
            xyDiagram3D2.ZoomPercent = 130
            Me.chartManhattanBar3D.Diagram = xyDiagram3D2
            Me.chartManhattanBar3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartManhattanBar3D.Legend.Name = "Default Legend"
            Me.chartManhattanBar3D.Location = New System.Drawing.Point(0, 0)
            Me.chartManhattanBar3D.Name = "chartManhattanBar3D"
            Me.chartManhattanBar3D.SeriesDataMember = "Year"
            Me.chartManhattanBar3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartManhattanBar3D.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
            Me.chartManhattanBar3D.SeriesTemplate.ArgumentDataMember = "Region"
            bar3DSeriesLabel2.TextPattern = "{V:n2}"
            Me.chartManhattanBar3D.SeriesTemplate.Label = bar3DSeriesLabel2
            Me.chartManhattanBar3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartManhattanBar3D.SeriesTemplate.SeriesDataMember = "Year"
            Me.chartManhattanBar3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            Me.chartManhattanBar3D.SeriesTemplate.View = manhattanBarSeriesView1
            Me.chartManhattanBar3D.Size = New System.Drawing.Size(963, 548)
            Me.chartManhattanBar3D.TabIndex = 1
            chartTitle2.Text = "DevAV Sales by Regions"
            chartTitle2.TitleID = 0
            Me.chartManhattanBar3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2})
            ' 
            ' dockPanelStackedBar3D
            ' 
            Me.dockPanelStackedBar3D.Controls.Add(Me.dockPanelStackedBar3D_Container)
            Me.dockPanelStackedBar3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStackedBar3D.DockedAsTabbedDocument = True
            Me.dockPanelStackedBar3D.ID = New System.Guid("f5b96f50-5813-410f-9864-a8896cd84fe4")
            Me.dockPanelStackedBar3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedBar3D.Name = "dockPanelStackedBar3D"
            Me.dockPanelStackedBar3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStackedBar3D.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelStackedBar3D.Text = "Stacked Bar3D"
            ' 
            ' dockPanelStackedBar3D_Container
            ' 
            Me.dockPanelStackedBar3D_Container.Controls.Add(Me.chartStackedBar3D)
            Me.dockPanelStackedBar3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedBar3D_Container.Name = "dockPanelStackedBar3D_Container"
            Me.dockPanelStackedBar3D_Container.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelStackedBar3D_Container.TabIndex = 0
            ' 
            ' chartStackedBar3D
            ' 
            Me.chartStackedBar3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D3.AxisY.Label.TextPattern = "{V:0,,}M"
            xyDiagram3D3.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D3.RuntimeRotation = True
            xyDiagram3D3.RuntimeScrolling = True
            xyDiagram3D3.RuntimeZooming = True
            xyDiagram3D3.VerticalScrollPercent = 4R
            xyDiagram3D3.ZoomPercent = 150
            Me.chartStackedBar3D.Diagram = xyDiagram3D3
            Me.chartStackedBar3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStackedBar3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartStackedBar3D.Legend.Name = "Default Legend"
            Me.chartStackedBar3D.Location = New System.Drawing.Point(0, 0)
            Me.chartStackedBar3D.Name = "chartStackedBar3D"
            Me.chartStackedBar3D.SeriesDataMember = "Age"
            Me.chartStackedBar3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartStackedBar3D.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
            Me.chartStackedBar3D.SeriesTemplate.ArgumentDataMember = "Country"
            stackedBar3DSeriesLabel1.TextPattern = "{V:0,,.0}"
            Me.chartStackedBar3D.SeriesTemplate.Label = stackedBar3DSeriesLabel1
            Me.chartStackedBar3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartStackedBar3D.SeriesTemplate.SeriesDataMember = "Age"
            Me.chartStackedBar3D.SeriesTemplate.ValueDataMembersSerializable = "Population"
            Me.chartStackedBar3D.SeriesTemplate.View = stackedBar3DSeriesView1
            Me.chartStackedBar3D.Size = New System.Drawing.Size(963, 548)
            Me.chartStackedBar3D.TabIndex = 2
            chartTitle3.Text = "Female Age Structure"
            chartTitle3.TitleID = 0
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle4.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle4.Text = "From www.cia.gov"
            chartTitle4.TextColor = System.Drawing.Color.Gray
            chartTitle4.TitleID = 1
            Me.chartStackedBar3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3, chartTitle4})
            ' 
            ' dockPanelStackedBar3DSideBySide
            ' 
            Me.dockPanelStackedBar3DSideBySide.Controls.Add(Me.dockPanelStackedBar3DSideBySide_Container)
            Me.dockPanelStackedBar3DSideBySide.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStackedBar3DSideBySide.DockedAsTabbedDocument = True
            Me.dockPanelStackedBar3DSideBySide.ID = New System.Guid("26d1bbda-eb65-46fb-8bff-18e0942f74c8")
            Me.dockPanelStackedBar3DSideBySide.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedBar3DSideBySide.Name = "dockPanelStackedBar3DSideBySide"
            Me.dockPanelStackedBar3DSideBySide.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStackedBar3DSideBySide.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelStackedBar3DSideBySide.Text = "Stacked Bar3D Side By Side"
            ' 
            ' dockPanelStackedBar3DSideBySide_Container
            ' 
            Me.dockPanelStackedBar3DSideBySide_Container.Controls.Add(Me.chartStackedBar3DSideBySide)
            Me.dockPanelStackedBar3DSideBySide_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedBar3DSideBySide_Container.Name = "dockPanelStackedBar3DSideBySide_Container"
            Me.dockPanelStackedBar3DSideBySide_Container.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelStackedBar3DSideBySide_Container.TabIndex = 0
            ' 
            ' chartStackedBar3DSideBySide
            ' 
            Me.chartStackedBar3DSideBySide.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D4.AxisX.Label.MaxWidth = 60
            xyDiagram3D4.AxisY.Label.TextPattern = "{V:0,,}M"
            xyDiagram3D4.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D4.RuntimeRotation = True
            xyDiagram3D4.RuntimeScrolling = True
            xyDiagram3D4.RuntimeZooming = True
            xyDiagram3D4.VerticalScrollPercent = 4R
            xyDiagram3D4.ZoomPercent = 130
            Me.chartStackedBar3DSideBySide.Diagram = xyDiagram3D4
            Me.chartStackedBar3DSideBySide.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStackedBar3DSideBySide.Legend.MaxHorizontalPercentage = 75R
            Me.chartStackedBar3DSideBySide.Legend.Name = "Default Legend"
            Me.chartStackedBar3DSideBySide.Location = New System.Drawing.Point(0, 0)
            Me.chartStackedBar3DSideBySide.Name = "chartStackedBar3DSideBySide"
            Me.chartStackedBar3DSideBySide.SeriesDataMember = "GenderAge"
            Me.chartStackedBar3DSideBySide.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartStackedBar3DSideBySide.SeriesTemplate.ArgumentDataMember = "Country"
            stackedBar3DSeriesLabel2.TextPattern = "{V:0,,.000}"
            Me.chartStackedBar3DSideBySide.SeriesTemplate.Label = stackedBar3DSeriesLabel2
            Me.chartStackedBar3DSideBySide.SeriesTemplate.SeriesDataMember = "GenderAge"
            Me.chartStackedBar3DSideBySide.SeriesTemplate.ValueDataMembersSerializable = "Population"
            Me.chartStackedBar3DSideBySide.SeriesTemplate.View = sideBySideStackedBar3DSeriesView1
            Me.chartStackedBar3DSideBySide.Size = New System.Drawing.Size(963, 548)
            Me.chartStackedBar3DSideBySide.TabIndex = 2
            chartTitle5.Text = "Population: Age Structure"
            chartTitle5.TitleID = 0
            chartTitle6.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle6.Text = "Data estimate for 2020"
            chartTitle6.TitleID = 1
            chartTitle7.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle7.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle7.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle7.Text = "From www.cia.gov"
            chartTitle7.TextColor = System.Drawing.Color.Gray
            chartTitle7.TitleID = 2
            Me.chartStackedBar3DSideBySide.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle5, chartTitle6, chartTitle7})
            ' 
            ' dockPanelFullStackedBar3D
            ' 
            Me.dockPanelFullStackedBar3D.Controls.Add(Me.dockPanelFullStackedBar3D_Container)
            Me.dockPanelFullStackedBar3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFullStackedBar3D.DockedAsTabbedDocument = True
            Me.dockPanelFullStackedBar3D.ID = New System.Guid("c48085c5-1762-4939-919c-dd92261ae589")
            Me.dockPanelFullStackedBar3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedBar3D.Name = "dockPanelFullStackedBar3D"
            Me.dockPanelFullStackedBar3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFullStackedBar3D.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelFullStackedBar3D.Text = "Full Stacked Bar3D"
            ' 
            ' dockPanelFullStackedBar3D_Container
            ' 
            Me.dockPanelFullStackedBar3D_Container.Controls.Add(Me.chartFullStackedBar3D)
            Me.dockPanelFullStackedBar3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedBar3D_Container.Name = "dockPanelFullStackedBar3D_Container"
            Me.dockPanelFullStackedBar3D_Container.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelFullStackedBar3D_Container.TabIndex = 0
            ' 
            ' chartFullStackedBar3D
            ' 
            Me.chartFullStackedBar3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D5.AxisY.Label.TextPattern = "{V:P0}"
            xyDiagram3D5.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram3D5.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram3D5.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram3D5.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D5.RuntimeRotation = True
            xyDiagram3D5.RuntimeScrolling = True
            xyDiagram3D5.RuntimeZooming = True
            xyDiagram3D5.VerticalScrollPercent = 6R
            xyDiagram3D5.ZoomPercent = 130
            Me.chartFullStackedBar3D.Diagram = xyDiagram3D5
            Me.chartFullStackedBar3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFullStackedBar3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartFullStackedBar3D.Legend.Name = "Default Legend"
            Me.chartFullStackedBar3D.Location = New System.Drawing.Point(0, 0)
            Me.chartFullStackedBar3D.Name = "chartFullStackedBar3D"
            Me.chartFullStackedBar3D.SeriesDataMember = "ProductCategory"
            Me.chartFullStackedBar3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartFullStackedBar3D.SeriesTemplate.ArgumentDataMember = "Region"
            Me.chartFullStackedBar3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartFullStackedBar3D.SeriesTemplate.SeriesDataMember = "ProductCategory"
            Me.chartFullStackedBar3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            Me.chartFullStackedBar3D.SeriesTemplate.View = fullStackedBar3DSeriesView1
            Me.chartFullStackedBar3D.Size = New System.Drawing.Size(963, 548)
            Me.chartFullStackedBar3D.TabIndex = 1
            chartTitle8.Text = "DevAV Sales Mix by Region"
            chartTitle8.TitleID = 0
            Me.chartFullStackedBar3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle8})
            ' 
            ' dockPanelFullStackedBar3DSideBySide
            ' 
            Me.dockPanelFullStackedBar3DSideBySide.Controls.Add(Me.dockPanelFullStackedBar3DSideBySide_Container)
            Me.dockPanelFullStackedBar3DSideBySide.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFullStackedBar3DSideBySide.DockedAsTabbedDocument = True
            Me.dockPanelFullStackedBar3DSideBySide.FloatLocation = New System.Drawing.Point(464, 120)
            Me.dockPanelFullStackedBar3DSideBySide.ID = New System.Guid("76cb9e9e-9217-41e9-96c5-dcb7fbdaa710")
            Me.dockPanelFullStackedBar3DSideBySide.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedBar3DSideBySide.Name = "dockPanelFullStackedBar3DSideBySide"
            Me.dockPanelFullStackedBar3DSideBySide.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFullStackedBar3DSideBySide.SavedIndex = 4
            Me.dockPanelFullStackedBar3DSideBySide.SavedMdiDocument = True
            Me.dockPanelFullStackedBar3DSideBySide.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelFullStackedBar3DSideBySide.Text = "Full Stacked Bar3D SideBy Side"
            ' 
            ' dockPanelFullStackedBar3DSideBySide_Container
            ' 
            Me.dockPanelFullStackedBar3DSideBySide_Container.Controls.Add(Me.chartFullStackedBar3DSideBySide)
            Me.dockPanelFullStackedBar3DSideBySide_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedBar3DSideBySide_Container.Name = "dockPanelFullStackedBar3DSideBySide_Container"
            Me.dockPanelFullStackedBar3DSideBySide_Container.Size = New System.Drawing.Size(963, 548)
            Me.dockPanelFullStackedBar3DSideBySide_Container.TabIndex = 0
            ' 
            ' chartFullStackedBar3DSideBySide
            ' 
            Me.chartFullStackedBar3DSideBySide.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D6.AxisX.Label.MaxWidth = 60
            xyDiagram3D6.AxisY.Label.TextPattern = "{VP:P0}"
            xyDiagram3D6.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram3D6.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram3D6.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram3D6.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D6.RuntimeRotation = True
            xyDiagram3D6.RuntimeScrolling = True
            xyDiagram3D6.RuntimeZooming = True
            xyDiagram3D6.VerticalScrollPercent = 6R
            xyDiagram3D6.ZoomPercent = 140
            Me.chartFullStackedBar3DSideBySide.Diagram = xyDiagram3D6
            Me.chartFullStackedBar3DSideBySide.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFullStackedBar3DSideBySide.Legend.Name = "Default Legend"
            Me.chartFullStackedBar3DSideBySide.Location = New System.Drawing.Point(0, 0)
            Me.chartFullStackedBar3DSideBySide.Name = "chartFullStackedBar3DSideBySide"
            Me.chartFullStackedBar3DSideBySide.SeriesDataMember = "GenderAge"
            Me.chartFullStackedBar3DSideBySide.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartFullStackedBar3DSideBySide.SeriesTemplate.ArgumentDataMember = "Country"
            fullStackedBar3DSeriesLabel1.TextPattern = "{VP:P0}"
            Me.chartFullStackedBar3DSideBySide.SeriesTemplate.Label = fullStackedBar3DSeriesLabel1
            Me.chartFullStackedBar3DSideBySide.SeriesTemplate.SeriesDataMember = "GenderAge"
            Me.chartFullStackedBar3DSideBySide.SeriesTemplate.ValueDataMembersSerializable = "Population"
            Me.chartFullStackedBar3DSideBySide.SeriesTemplate.View = sideBySideFullStackedBar3DSeriesView1
            Me.chartFullStackedBar3DSideBySide.Size = New System.Drawing.Size(963, 548)
            Me.chartFullStackedBar3DSideBySide.TabIndex = 2
            chartTitle9.Text = "Population: Age Structure"
            chartTitle9.TitleID = 0
            chartTitle10.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle10.Text = "Data estimate for 2020"
            chartTitle10.TitleID = 1
            chartTitle11.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle11.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle11.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle11.Text = "From www.cia.gov"
            chartTitle11.TextColor = System.Drawing.Color.Gray
            chartTitle11.TitleID = 2
            Me.chartFullStackedBar3DSideBySide.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle9, chartTitle10, chartTitle11})
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
            Me.currentTabbedView.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() {Me.documentGroup})
            Me.currentTabbedView.DocumentProperties.AllowAnimation = False
            Me.currentTabbedView.DocumentProperties.AllowClose = False
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentBar3D, Me.documentStackedBar3D, Me.documentStackedBar3DSideBySide, Me.documentFullStackedBar3D, Me.documentFullStackedBar3DSideBySide, Me.documentManhattanBar})
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
            Me.layoutControl.Controls.Add(Me.checkEditShowFacet)
            Me.layoutControl.Controls.Add(Me.comboBoxEdit3DModel)
            Me.layoutControl.Controls.Add(Me.comboBoxEditGroupSeriesBy)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(371, 203, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 148)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' checkEditValueAsPercent
            ' 
            Me.checkEditValueAsPercent.Location = New System.Drawing.Point(12, 172)
            Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
            Me.checkEditValueAsPercent.Properties.Caption = "Value as Percent"
            Me.checkEditValueAsPercent.Size = New System.Drawing.Size(217, 20)
            Me.checkEditValueAsPercent.StyleController = Me.layoutControl
            Me.checkEditValueAsPercent.TabIndex = 5
            ' 
            ' comboBoxEditPerspectiveAngle
            ' 
            Me.comboBoxEditPerspectiveAngle.Location = New System.Drawing.Point(114, 238)
            Me.comboBoxEditPerspectiveAngle.Name = "comboBoxEditPerspectiveAngle"
            Me.comboBoxEditPerspectiveAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditPerspectiveAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditPerspectiveAngle.Size = New System.Drawing.Size(115, 20)
            Me.comboBoxEditPerspectiveAngle.StyleController = Me.layoutControl
            Me.comboBoxEditPerspectiveAngle.TabIndex = 6
            ' 
            ' simpleButtonRestoreDefaultAngles
            ' 
            Me.simpleButtonRestoreDefaultAngles.Location = New System.Drawing.Point(12, 270)
            Me.simpleButtonRestoreDefaultAngles.Name = "simpleButtonRestoreDefaultAngles"
            Me.simpleButtonRestoreDefaultAngles.Size = New System.Drawing.Size(217, 22)
            Me.simpleButtonRestoreDefaultAngles.StyleController = Me.layoutControl
            Me.simpleButtonRestoreDefaultAngles.TabIndex = 7
            Me.simpleButtonRestoreDefaultAngles.Text = "Restore Default Angles"
            ' 
            ' checkEditShowFacet
            ' 
            Me.checkEditShowFacet.Location = New System.Drawing.Point(12, 82)
            Me.checkEditShowFacet.Name = "checkEditShowFacet"
            Me.checkEditShowFacet.Properties.Caption = "Show Facet"
            Me.checkEditShowFacet.Size = New System.Drawing.Size(217, 20)
            Me.checkEditShowFacet.StyleController = Me.layoutControl
            Me.checkEditShowFacet.TabIndex = 0
            AddHandler Me.checkEditShowFacet.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowFacet_CheckedChanged)
            ' 
            ' comboBoxEdit3DModel
            ' 
            Me.comboBoxEdit3DModel.Location = New System.Drawing.Point(114, 58)
            Me.comboBoxEdit3DModel.Name = "comboBoxEdit3DModel"
            Me.comboBoxEdit3DModel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit3DModel.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit3DModel.Size = New System.Drawing.Size(115, 20)
            Me.comboBoxEdit3DModel.StyleController = Me.layoutControl
            Me.comboBoxEdit3DModel.TabIndex = 2
            ' 
            ' comboBoxEditGroupSeriesBy
            ' 
            Me.comboBoxEditGroupSeriesBy.EditValue = "Age"
            Me.comboBoxEditGroupSeriesBy.Location = New System.Drawing.Point(114, 34)
            Me.comboBoxEditGroupSeriesBy.Name = "comboBoxEditGroupSeriesBy"
            Me.comboBoxEditGroupSeriesBy.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditGroupSeriesBy.Properties.Items.AddRange(New Object() {"Gender", "Age"})
            Me.comboBoxEditGroupSeriesBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditGroupSeriesBy.Size = New System.Drawing.Size(115, 20)
            Me.comboBoxEditGroupSeriesBy.StyleController = Me.layoutControl
            Me.comboBoxEditGroupSeriesBy.TabIndex = 3
            AddHandler Me.comboBoxEditGroupSeriesBy.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditGroupSeriesBy_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.layoutControlGroupLabel, Me.emptySpaceItem, Me.layoutControlGroupCamera})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemShowFacet, Me.layoutControlGroupGroupSeriesBy, Me.layoutControlItem3DModel})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemShowFacet
            ' 
            Me.layoutControlItemShowFacet.Control = Me.checkEditShowFacet
            Me.layoutControlItemShowFacet.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemShowFacet.Name = "layoutControlItemShowFacet"
            Me.layoutControlItemShowFacet.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemShowFacet.TextVisible = False
            ' 
            ' layoutControlGroupGroupSeriesBy
            ' 
            Me.layoutControlGroupGroupSeriesBy.Control = Me.comboBoxEditGroupSeriesBy
            Me.layoutControlGroupGroupSeriesBy.CustomizationFormText = "Series Group By"
            Me.layoutControlGroupGroupSeriesBy.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGroupSeriesBy.Name = "layoutControlGroupGroupSeriesBy"
            Me.layoutControlGroupGroupSeriesBy.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlGroupGroupSeriesBy.Text = "Group Series By:"
            Me.layoutControlGroupGroupSeriesBy.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' layoutControlItem3DModel
            ' 
            Me.layoutControlItem3DModel.Control = Me.comboBoxEdit3DModel
            Me.layoutControlItem3DModel.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem3DModel.Name = "layoutControlItem3DModel"
            Me.layoutControlItem3DModel.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem3DModel.Text = "3D Model:"
            Me.layoutControlItem3DModel.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemValueAsPercent})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 90)
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
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 304)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 234)
            ' 
            ' layoutControlGroupCamera
            ' 
            Me.layoutControlGroupCamera.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupCamera.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupCamera.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupCamera.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupPerspectiveAngle, Me.layoutControlItemRestoreDefaultAngles})
            Me.layoutControlGroupCamera.Location = New System.Drawing.Point(0, 204)
            Me.layoutControlGroupCamera.Name = "layoutControlGroupCamera"
            Me.layoutControlGroupCamera.Size = New System.Drawing.Size(241, 100)
            Me.layoutControlGroupCamera.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupCamera.Text = "Camera"
            ' 
            ' layoutControlGroupPerspectiveAngle
            ' 
            Me.layoutControlGroupPerspectiveAngle.Control = Me.comboBoxEditPerspectiveAngle
            Me.layoutControlGroupPerspectiveAngle.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupPerspectiveAngle.Name = "layoutControlGroupPerspectiveAngle"
            Me.layoutControlGroupPerspectiveAngle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlGroupPerspectiveAngle.Text = "Perspective Angle:"
            Me.layoutControlGroupPerspectiveAngle.TextSize = New System.Drawing.Size(90, 13)
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
            ' Bar3DViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Bar3DViewsDemo"
            Me.Size = New System.Drawing.Size(963, 571)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManhattanBar), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStackedBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFullStackedBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFullStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelBar3D.ResumeLayout(False)
            Me.dockPanelBar3D_Container.ResumeLayout(False)
            CType((xyDiagram3D1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bar3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBar3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelManhattanBar.ResumeLayout(False)
            Me.dockPanelManhattanBar_Container.ResumeLayout(False)
            CType((xyDiagram3D2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bar3DSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((manhattanBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartManhattanBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStackedBar3D.ResumeLayout(False)
            Me.dockPanelStackedBar3D_Container.ResumeLayout(False)
            CType((xyDiagram3D3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBar3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStackedBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStackedBar3DSideBySide.ResumeLayout(False)
            Me.dockPanelStackedBar3DSideBySide_Container.ResumeLayout(False)
            CType((xyDiagram3D4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedBar3DSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideStackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFullStackedBar3D.ResumeLayout(False)
            Me.dockPanelFullStackedBar3D_Container.ResumeLayout(False)
            CType((xyDiagram3D5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((fullStackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFullStackedBar3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFullStackedBar3DSideBySide.ResumeLayout(False)
            Me.dockPanelFullStackedBar3DSideBySide_Container.ResumeLayout(False)
            CType((xyDiagram3D6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((fullStackedBar3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideFullStackedBar3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFullStackedBar3DSideBySide), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowFacet.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEdit3DModel.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditGroupSeriesBy.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemShowFacet), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGroupSeriesBy), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3DModel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupPerspectiveAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelBar3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelBar3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentBar3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditPerspectiveAngle As DevExpress.XtraEditors.ComboBoxEdit

        Private simpleButtonRestoreDefaultAngles As DevExpress.XtraEditors.SimpleButton

        Private checkEditShowFacet As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupCamera As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupPerspectiveAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemRestoreDefaultAngles As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemShowFacet As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemValueAsPercent As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private comboBoxEdit3DModel As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItem3DModel As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGroupSeriesBy As DevExpress.XtraLayout.LayoutControlItem

        Private documentStackedBar3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStackedBar3DSideBySide As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFullStackedBar3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFullStackedBar3DSideBySide As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartBar3D As DevExpress.XtraCharts.ChartControl

        Private dockPanelManhattanBar As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelManhattanBar_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStackedBar3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStackedBar3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStackedBar3DSideBySide As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStackedBar3DSideBySide_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFullStackedBar3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFullStackedBar3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFullStackedBar3DSideBySide As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFullStackedBar3DSideBySide_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private chartManhattanBar3D As DevExpress.XtraCharts.ChartControl

        Private chartStackedBar3D As DevExpress.XtraCharts.ChartControl

        Private chartStackedBar3DSideBySide As DevExpress.XtraCharts.ChartControl

        Private chartFullStackedBar3D As DevExpress.XtraCharts.ChartControl

        Private documentManhattanBar As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartFullStackedBar3DSideBySide As DevExpress.XtraCharts.ChartControl

        Private comboBoxEditGroupSeriesBy As DevExpress.XtraEditors.ComboBoxEdit
    End Class
End Namespace
