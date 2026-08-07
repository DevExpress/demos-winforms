Namespace DevExpress.XtraCharts.Demos

    Partial Class Area3DViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.Area3DViewsDemo))
            Dim xyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim area3DSeriesLabel1 As DevExpress.XtraCharts.Area3DSeriesLabel = New DevExpress.XtraCharts.Area3DSeriesLabel()
            Dim area3DSeriesView1 As DevExpress.XtraCharts.Area3DSeriesView = New DevExpress.XtraCharts.Area3DSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D2 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim rangeArea3DSeriesLabel1 As DevExpress.XtraCharts.RangeArea3DSeriesLabel = New DevExpress.XtraCharts.RangeArea3DSeriesLabel()
            Dim rangeArea3DSeriesView1 As DevExpress.XtraCharts.RangeArea3DSeriesView = New DevExpress.XtraCharts.RangeArea3DSeriesView()
            Dim overlappedRangeBarSeriesView1 As DevExpress.XtraCharts.OverlappedRangeBarSeriesView = New DevExpress.XtraCharts.OverlappedRangeBarSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D3 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim area3DSeriesLabel2 As DevExpress.XtraCharts.Area3DSeriesLabel = New DevExpress.XtraCharts.Area3DSeriesLabel()
            Dim stepArea3DSeriesView1 As DevExpress.XtraCharts.StepArea3DSeriesView = New DevExpress.XtraCharts.StepArea3DSeriesView()
            Dim stepArea3DSeriesView2 As DevExpress.XtraCharts.StepArea3DSeriesView = New DevExpress.XtraCharts.StepArea3DSeriesView()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D4 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim splineArea3DSeriesView1 As DevExpress.XtraCharts.SplineArea3DSeriesView = New DevExpress.XtraCharts.SplineArea3DSeriesView()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D5 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim stackedArea3DSeriesLabel1 As DevExpress.XtraCharts.StackedArea3DSeriesLabel = New DevExpress.XtraCharts.StackedArea3DSeriesLabel()
            Dim stackedArea3DSeriesView1 As DevExpress.XtraCharts.StackedArea3DSeriesView = New DevExpress.XtraCharts.StackedArea3DSeriesView()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D6 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim stackedArea3DSeriesLabel2 As DevExpress.XtraCharts.StackedArea3DSeriesLabel = New DevExpress.XtraCharts.StackedArea3DSeriesLabel()
            Dim stackedSplineArea3DSeriesView1 As DevExpress.XtraCharts.StackedSplineArea3DSeriesView = New DevExpress.XtraCharts.StackedSplineArea3DSeriesView()
            Dim chartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D7 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim fullStackedArea3DSeriesView1 As DevExpress.XtraCharts.FullStackedArea3DSeriesView = New DevExpress.XtraCharts.FullStackedArea3DSeriesView()
            Dim chartTitle10 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D8 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim fullStackedSplineArea3DSeriesView1 As DevExpress.XtraCharts.FullStackedSplineArea3DSeriesView = New DevExpress.XtraCharts.FullStackedSplineArea3DSeriesView()
            Dim chartTitle11 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentRangeArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStepArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentSplineArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStackedArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStackedSplineArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFullStackedArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFullStackedSplineArea3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditTransparency = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditInvertedStep = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditPerspectiveAngle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.simpleButtonRestoreDefaultAngles = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemInvertedStep = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemTransparency = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemValueAsPercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupCamera = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemPerspectiveAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRestoreDefaultAngles = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelRangeArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelRangeArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartRangeArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStepArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStepArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStepArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelSplineArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelSplineArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartSplineArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStackedArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStackedArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStackedArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStackedSplineArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStackedSplineArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStackedSplineArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFullStackedArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFullStackedArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFullStackedArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFullStackedSplineArea3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFullStackedSplineArea3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFullStackedSplineArea3D = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentRangeArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStepArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentSplineArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStackedArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStackedSplineArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFullStackedArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFullStackedSplineArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditTransparency.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditInvertedStep.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemInvertedStep), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTransparency), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPerspectiveAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelArea3D.SuspendLayout()
            Me.dockPanelArea3D_Container.SuspendLayout()
            CType((Me.chartArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((area3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((area3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelRangeArea3D.SuspendLayout()
            Me.dockPanelRangeArea3D_Container.SuspendLayout()
            CType((Me.chartRangeArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((rangeArea3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((rangeArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((overlappedRangeBarSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStepArea3D.SuspendLayout()
            Me.dockPanelStepArea3D_Container.SuspendLayout()
            CType((Me.chartStepArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((area3DSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stepArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stepArea3DSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelSplineArea3D.SuspendLayout()
            Me.dockPanelSplineArea3D_Container.SuspendLayout()
            CType((Me.chartSplineArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStackedArea3D.SuspendLayout()
            Me.dockPanelStackedArea3D_Container.SuspendLayout()
            CType((Me.chartStackedArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedArea3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStackedSplineArea3D.SuspendLayout()
            Me.dockPanelStackedSplineArea3D_Container.SuspendLayout()
            CType((Me.chartStackedSplineArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedArea3DSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedSplineArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFullStackedArea3D.SuspendLayout()
            Me.dockPanelFullStackedArea3D_Container.SuspendLayout()
            CType((Me.chartFullStackedArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((fullStackedArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFullStackedSplineArea3D.SuspendLayout()
            Me.dockPanelFullStackedSplineArea3D_Container.SuspendLayout()
            CType((Me.chartFullStackedSplineArea3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((fullStackedSplineArea3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' sidePanelOptions
            ' 
            Me.sidePanelOptions.Location = New System.Drawing.Point(847, 0)
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentArea3D, Me.documentRangeArea3D, Me.documentStepArea3D, Me.documentSplineArea3D, Me.documentStackedArea3D, Me.documentStackedSplineArea3D, Me.documentFullStackedArea3D, Me.documentFullStackedSplineArea3D})
            ' 
            ' documentArea3D
            ' 
            Me.documentArea3D.Caption = "Area3D"
            Me.documentArea3D.ControlName = "dockPanelArea3D"
            Me.documentArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentRangeArea3D
            ' 
            Me.documentRangeArea3D.Caption = "Range Area3D"
            Me.documentRangeArea3D.ControlName = "dockPanelRangeArea3D"
            Me.documentRangeArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentRangeArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentRangeArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentRangeArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentRangeArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentRangeArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentRangeArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentRangeArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStepArea3D
            ' 
            Me.documentStepArea3D.Caption = "Step Area3D"
            Me.documentStepArea3D.ControlName = "dockPanelStepArea3D"
            Me.documentStepArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStepArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStepArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentStepArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStepArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStepArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStepArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStepArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentSplineArea3D
            ' 
            Me.documentSplineArea3D.Caption = "Spline Area3D"
            Me.documentSplineArea3D.ControlName = "dockPanelSplineArea3D"
            Me.documentSplineArea3D.FloatLocation = New System.Drawing.Point(265, 127)
            Me.documentSplineArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentSplineArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentSplineArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentSplineArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentSplineArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentSplineArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentSplineArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStackedArea3D
            ' 
            Me.documentStackedArea3D.Caption = "Stacked Area3D"
            Me.documentStackedArea3D.ControlName = "dockPanelStackedArea3D"
            Me.documentStackedArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStackedArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStackedArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentStackedArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStackedArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStackedArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStackedArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStackedArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStackedSplineArea3D
            ' 
            Me.documentStackedSplineArea3D.Caption = "Stacked Spline Area3D"
            Me.documentStackedSplineArea3D.ControlName = "dockPanelStackedSplineArea3D"
            Me.documentStackedSplineArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStackedSplineArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStackedSplineArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentStackedSplineArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStackedSplineArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStackedSplineArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStackedSplineArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStackedSplineArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFullStackedArea3D
            ' 
            Me.documentFullStackedArea3D.Caption = "Full Stacked Area3D"
            Me.documentFullStackedArea3D.ControlName = "dockPanelFullStackedArea3D"
            Me.documentFullStackedArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentFullStackedArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFullStackedArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentFullStackedArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFullStackedArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFullStackedArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFullStackedArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFullStackedArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFullStackedSplineArea3D
            ' 
            Me.documentFullStackedSplineArea3D.Caption = "Full Stacked Spline Area3D"
            Me.documentFullStackedSplineArea3D.ControlName = "dockPanelFullStackedSplineArea3D"
            Me.documentFullStackedSplineArea3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentFullStackedSplineArea3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFullStackedSplineArea3D.ImageOptions.SvgImage = CType((resources.GetObject("documentFullStackedSplineArea3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFullStackedSplineArea3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFullStackedSplineArea3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFullStackedSplineArea3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFullStackedSplineArea3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditTransparency)
            Me.layoutControl.Controls.Add(Me.checkEditInvertedStep)
            Me.layoutControl.Controls.Add(Me.checkEditValueAsPercent)
            Me.layoutControl.Controls.Add(Me.comboBoxEditPerspectiveAngle)
            Me.layoutControl.Controls.Add(Me.simpleButtonRestoreDefaultAngles)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(234, 257, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 124)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 3
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditTransparency
            ' 
            Me.spinEditTransparency.EditValue = New Decimal(New Integer() {135, 0, 0, 0})
            Me.spinEditTransparency.Location = New System.Drawing.Point(114, 58)
            Me.spinEditTransparency.Name = "spinEditTransparency"
            Me.spinEditTransparency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditTransparency.Properties.IsFloatValue = False
            Me.spinEditTransparency.Properties.Mask.EditMask = "N00"
            Me.spinEditTransparency.Properties.MaxValue = New Decimal(New Integer() {255, 0, 0, 0})
            Me.spinEditTransparency.Size = New System.Drawing.Size(115, 20)
            Me.spinEditTransparency.StyleController = Me.layoutControl
            Me.spinEditTransparency.TabIndex = 0
            AddHandler Me.spinEditTransparency.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditTransparency_EditValueChanged)
            ' 
            ' checkEditInvertedStep
            ' 
            Me.checkEditInvertedStep.Location = New System.Drawing.Point(12, 34)
            Me.checkEditInvertedStep.Name = "checkEditInvertedStep"
            Me.checkEditInvertedStep.Properties.Caption = "Inverted Step"
            Me.checkEditInvertedStep.Size = New System.Drawing.Size(217, 20)
            Me.checkEditInvertedStep.StyleController = Me.layoutControl
            Me.checkEditInvertedStep.TabIndex = 2
            AddHandler Me.checkEditInvertedStep.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditInvertedStep_CheckedChanged)
            ' 
            ' checkEditValueAsPercent
            ' 
            Me.checkEditValueAsPercent.Location = New System.Drawing.Point(12, 148)
            Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
            Me.checkEditValueAsPercent.Properties.Caption = "Value As Percent"
            Me.checkEditValueAsPercent.Size = New System.Drawing.Size(217, 20)
            Me.checkEditValueAsPercent.StyleController = Me.layoutControl
            Me.checkEditValueAsPercent.TabIndex = 5
            ' 
            ' comboBoxEditPerspectiveAngle
            ' 
            Me.comboBoxEditPerspectiveAngle.Location = New System.Drawing.Point(114, 214)
            Me.comboBoxEditPerspectiveAngle.Name = "comboBoxEditPerspectiveAngle"
            Me.comboBoxEditPerspectiveAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditPerspectiveAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditPerspectiveAngle.Size = New System.Drawing.Size(115, 20)
            Me.comboBoxEditPerspectiveAngle.StyleController = Me.layoutControl
            Me.comboBoxEditPerspectiveAngle.TabIndex = 6
            ' 
            ' simpleButtonRestoreDefaultAngles
            ' 
            Me.simpleButtonRestoreDefaultAngles.Location = New System.Drawing.Point(12, 246)
            Me.simpleButtonRestoreDefaultAngles.Name = "simpleButtonRestoreDefaultAngles"
            Me.simpleButtonRestoreDefaultAngles.Size = New System.Drawing.Size(217, 22)
            Me.simpleButtonRestoreDefaultAngles.StyleController = Me.layoutControl
            Me.simpleButtonRestoreDefaultAngles.TabIndex = 7
            Me.simpleButtonRestoreDefaultAngles.Text = "Restore Default Angles"
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.layoutControlGroupLabel, Me.emptySpaceItem, Me.layoutControlGroupCamera})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemInvertedStep, Me.layoutControlItemTransparency})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemInvertedStep
            ' 
            Me.layoutControlItemInvertedStep.Control = Me.checkEditInvertedStep
            Me.layoutControlItemInvertedStep.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemInvertedStep.Name = "layoutControlItemInvertedStep"
            Me.layoutControlItemInvertedStep.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemInvertedStep.TextVisible = False
            ' 
            ' layoutControlItemTransparency
            ' 
            Me.layoutControlItemTransparency.Control = Me.spinEditTransparency
            Me.layoutControlItemTransparency.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemTransparency.Name = "layoutControlItemTransparency"
            Me.layoutControlItemTransparency.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemTransparency.Text = "Transparency:"
            Me.layoutControlItemTransparency.TextSize = New System.Drawing.Size(90, 13)
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemVisible, Me.layoutControlItemValueAsPercent})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 90)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemVisible
            ' 
            Me.layoutControlItemVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemVisible.Name = "layoutControlItemVisible"
            Me.layoutControlItemVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemVisible.TextVisible = False
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
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 280)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 258)
            ' 
            ' layoutControlGroupCamera
            ' 
            Me.layoutControlGroupCamera.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupCamera.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupCamera.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupCamera.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemPerspectiveAngle, Me.layoutControlItemRestoreDefaultAngles})
            Me.layoutControlGroupCamera.Location = New System.Drawing.Point(0, 180)
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
            Me.layoutControlItemPerspectiveAngle.TextSize = New System.Drawing.Size(90, 13)
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
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelArea3D, Me.dockPanelRangeArea3D, Me.dockPanelStepArea3D, Me.dockPanelSplineArea3D, Me.dockPanelStackedArea3D, Me.dockPanelStackedSplineArea3D, Me.dockPanelFullStackedArea3D, Me.dockPanelFullStackedSplineArea3D})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelArea3D
            ' 
            Me.dockPanelArea3D.Controls.Add(Me.dockPanelArea3D_Container)
            Me.dockPanelArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelArea3D.DockedAsTabbedDocument = True
            Me.dockPanelArea3D.ID = New System.Guid("f9000135-0394-46de-8334-2c5745c330bf")
            Me.dockPanelArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelArea3D.Name = "dockPanelArea3D"
            Me.dockPanelArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelArea3D.Text = "Area3D"
            ' 
            ' dockPanelArea3D_Container
            ' 
            Me.dockPanelArea3D_Container.Controls.Add(Me.chartArea3D)
            Me.dockPanelArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelArea3D_Container.Name = "dockPanelArea3D_Container"
            Me.dockPanelArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelArea3D_Container.TabIndex = 0
            ' 
            ' chartArea3D
            ' 
            Me.chartArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D1.AxisX.GridLines.Visible = True
            xyDiagram3D1.AxisX.Label.MaxWidth = 70
            xyDiagram3D1.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram3D1.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram3D1.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram3D1.AxisY.Label.TextPattern = "${V}K"
            xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram3D1.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Hundreds
            xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram3D1.RotationMatrixSerializable = "0.77646940946579;-0.219846308231354;0.590561509132385;0;0.00596907455474138;0.939" & "692616462708;0.341968059539795;0;-0.630126714706421;-0.262002617120743;0.7309548" & "85482788;0;0;0;0;1"
            xyDiagram3D1.RuntimeRotation = True
            xyDiagram3D1.RuntimeScrolling = True
            xyDiagram3D1.RuntimeZooming = True
            xyDiagram3D1.VerticalScrollPercent = 7R
            xyDiagram3D1.ZoomPercent = 135
            Me.chartArea3D.Diagram = xyDiagram3D1
            Me.chartArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartArea3D.Legend.Name = "Default Legend"
            Me.chartArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartArea3D.Name = "chartArea3D"
            Me.chartArea3D.SeriesDataMember = "Company"
            Me.chartArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartArea3D.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartArea3D.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            area3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartArea3D.SeriesTemplate.Label = area3DSeriesLabel1
            Me.chartArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartArea3D.SeriesTemplate.SeriesDataMember = "Company"
            Me.chartArea3D.SeriesTemplate.ValueDataMembersSerializable = "Costs"
            Me.chartArea3D.SeriesTemplate.View = area3DSeriesView1
            Me.chartArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartArea3D.TabIndex = 7
            chartTitle1.Text = "Outside Vendor Costs"
            chartTitle1.TitleID = 0
            Me.chartArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' dockPanelRangeArea3D
            ' 
            Me.dockPanelRangeArea3D.Controls.Add(Me.dockPanelRangeArea3D_Container)
            Me.dockPanelRangeArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelRangeArea3D.DockedAsTabbedDocument = True
            Me.dockPanelRangeArea3D.ID = New System.Guid("32bdfa03-21fa-4cac-9a2b-4f63cc4e4d56")
            Me.dockPanelRangeArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelRangeArea3D.Name = "dockPanelRangeArea3D"
            Me.dockPanelRangeArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelRangeArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelRangeArea3D.Text = "Range Area3D"
            ' 
            ' dockPanelRangeArea3D_Container
            ' 
            Me.dockPanelRangeArea3D_Container.Controls.Add(Me.chartRangeArea3D)
            Me.dockPanelRangeArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelRangeArea3D_Container.Name = "dockPanelRangeArea3D_Container"
            Me.dockPanelRangeArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelRangeArea3D_Container.TabIndex = 0
            ' 
            ' chartRangeArea3D
            ' 
            Me.chartRangeArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D2.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram3D2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            xyDiagram3D2.AxisX.DateTimeScaleOptions.GridSpacing = 2R
            xyDiagram3D2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            xyDiagram3D2.AxisX.Label.TextPattern = "{A:MMMM}"
            xyDiagram3D2.AxisY.Label.TextPattern = "${V}"
            xyDiagram3D2.AxisY.VisualRange.Auto = False
            xyDiagram3D2.AxisY.VisualRange.MaxValueSerializable = "9.8"
            xyDiagram3D2.AxisY.VisualRange.MinValueSerializable = "1.1"
            xyDiagram3D2.AxisY.WholeRange.Auto = False
            xyDiagram3D2.AxisY.WholeRange.MaxValueSerializable = "9.8"
            xyDiagram3D2.AxisY.WholeRange.MinValueSerializable = "1.1"
            xyDiagram3D2.HorizontalScrollPercent = -2R
            xyDiagram3D2.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & "1"
            xyDiagram3D2.RuntimeRotation = True
            xyDiagram3D2.RuntimeScrolling = True
            xyDiagram3D2.RuntimeZooming = True
            xyDiagram3D2.VerticalScrollPercent = 4R
            xyDiagram3D2.ZoomPercent = 160
            Me.chartRangeArea3D.Diagram = xyDiagram3D2
            Me.chartRangeArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartRangeArea3D.Legend.Name = "Default Legend"
            Me.chartRangeArea3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartRangeArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartRangeArea3D.Name = "chartRangeArea3D"
            series1.ArgumentDataMember = "Date"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            rangeArea3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            rangeArea3DSeriesLabel1.TextPattern = "{V:F2}"
            series1.Label = rangeArea3DSeriesLabel1
            series1.Name = "OK WTI"
            series1.SeriesID = 0
            series1.ValueDataMembersSerializable = "Min;Max"
            series1.View = rangeArea3DSeriesView1
            Me.chartRangeArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            Me.chartRangeArea3D.SeriesTemplate.View = overlappedRangeBarSeriesView1
            Me.chartRangeArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartRangeArea3D.TabIndex = 1
            chartTitle2.Text = "Crude Oil Prices in 2015"
            chartTitle2.TitleID = 0
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle3.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle3.Text = "From www.eia.gov"
            chartTitle3.TextColor = System.Drawing.Color.Gray
            chartTitle3.TitleID = 1
            Me.chartRangeArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2, chartTitle3})
            ' 
            ' dockPanelStepArea3D
            ' 
            Me.dockPanelStepArea3D.Controls.Add(Me.dockPanelStepArea3D_Container)
            Me.dockPanelStepArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStepArea3D.DockedAsTabbedDocument = True
            Me.dockPanelStepArea3D.ID = New System.Guid("eae3ef35-8e40-4621-ae7f-c2b586e92f0e")
            Me.dockPanelStepArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStepArea3D.Name = "dockPanelStepArea3D"
            Me.dockPanelStepArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStepArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelStepArea3D.Text = "Step Area3D"
            ' 
            ' dockPanelStepArea3D_Container
            ' 
            Me.dockPanelStepArea3D_Container.Controls.Add(Me.chartStepArea3D)
            Me.dockPanelStepArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStepArea3D_Container.Name = "dockPanelStepArea3D_Container"
            Me.dockPanelStepArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelStepArea3D_Container.TabIndex = 0
            ' 
            ' chartStepArea3D
            ' 
            Me.chartStepArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D3.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram3D3.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Month
            xyDiagram3D3.AxisX.DateTimeScaleOptions.GridSpacing = 2R
            xyDiagram3D3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            xyDiagram3D3.AxisX.Label.MaxWidth = 70
            xyDiagram3D3.AxisX.Label.TextPattern = "{A:MMMM}"
            xyDiagram3D3.AxisY.Label.TextPattern = "{V:N1}"
            xyDiagram3D3.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram3D3.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D3.RuntimeRotation = True
            xyDiagram3D3.RuntimeScrolling = True
            xyDiagram3D3.RuntimeZooming = True
            xyDiagram3D3.VerticalScrollPercent = 5R
            xyDiagram3D3.ZoomPercent = 150
            Me.chartStepArea3D.Diagram = xyDiagram3D3
            Me.chartStepArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStepArea3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartStepArea3D.Legend.Name = "Default Legend"
            Me.chartStepArea3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartStepArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartStepArea3D.Name = "chartStepArea3D"
            series2.ArgumentDataMember = "Date"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            area3DSeriesLabel2.TextPattern = "{V:F2}"
            series2.Label = area3DSeriesLabel2
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.Name = "Gasoline Prices"
            series2.SeriesID = 0
            series2.ValueDataMembersSerializable = "Price"
            stepArea3DSeriesView1.AreaWidth = 1R
            series2.View = stepArea3DSeriesView1
            Me.chartStepArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
            Me.chartStepArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartStepArea3D.SeriesTemplate.View = stepArea3DSeriesView2
            Me.chartStepArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartStepArea3D.TabIndex = 1
            chartTitle4.Text = "US Gasoline Prices in 2015"
            chartTitle4.TitleID = 0
            chartTitle5.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle5.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle5.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle5.Text = "From www.eia.gov"
            chartTitle5.TextColor = System.Drawing.Color.Gray
            chartTitle5.TitleID = 1
            chartTitle6.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle6.Text = "Dollars per Gallon"
            chartTitle6.TitleID = 2
            Me.chartStepArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle4, chartTitle5, chartTitle6})
            ' 
            ' dockPanelSplineArea3D
            ' 
            Me.dockPanelSplineArea3D.Controls.Add(Me.dockPanelSplineArea3D_Container)
            Me.dockPanelSplineArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelSplineArea3D.DockedAsTabbedDocument = True
            Me.dockPanelSplineArea3D.FloatLocation = New System.Drawing.Point(265, 127)
            Me.dockPanelSplineArea3D.ID = New System.Guid("97f12c86-492e-4ab0-827c-492f86128fde")
            Me.dockPanelSplineArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelSplineArea3D.Name = "dockPanelSplineArea3D"
            Me.dockPanelSplineArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelSplineArea3D.SavedIndex = 3
            Me.dockPanelSplineArea3D.SavedMdiDocument = True
            Me.dockPanelSplineArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelSplineArea3D.Text = "Spline Area3D"
            ' 
            ' dockPanelSplineArea3D_Container
            ' 
            Me.dockPanelSplineArea3D_Container.Controls.Add(Me.chartSplineArea3D)
            Me.dockPanelSplineArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelSplineArea3D_Container.Name = "dockPanelSplineArea3D_Container"
            Me.dockPanelSplineArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelSplineArea3D_Container.TabIndex = 0
            ' 
            ' chartSplineArea3D
            ' 
            Me.chartSplineArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D4.AxisX.GridLines.Visible = True
            xyDiagram3D4.AxisX.Label.MaxWidth = 70
            xyDiagram3D4.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram3D4.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram3D4.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram3D4.AxisY.Label.TextPattern = "${V}K"
            xyDiagram3D4.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram3D4.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Hundreds
            xyDiagram3D4.AxisY.VisualRange.Auto = False
            xyDiagram3D4.AxisY.VisualRange.MaxValueSerializable = "9.7"
            xyDiagram3D4.AxisY.VisualRange.MinValueSerializable = "0.6"
            xyDiagram3D4.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram3D4.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D4.RuntimeRotation = True
            xyDiagram3D4.RuntimeScrolling = True
            xyDiagram3D4.RuntimeZooming = True
            xyDiagram3D4.VerticalScrollPercent = 7R
            xyDiagram3D4.ZoomPercent = 135
            Me.chartSplineArea3D.Diagram = xyDiagram3D4
            Me.chartSplineArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartSplineArea3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartSplineArea3D.Legend.Name = "Default Legend"
            Me.chartSplineArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartSplineArea3D.Name = "chartSplineArea3D"
            Me.chartSplineArea3D.SeriesDataMember = "Company"
            Me.chartSplineArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartSplineArea3D.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartSplineArea3D.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chartSplineArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartSplineArea3D.SeriesTemplate.SeriesDataMember = "Company"
            Me.chartSplineArea3D.SeriesTemplate.ValueDataMembersSerializable = "Costs"
            Me.chartSplineArea3D.SeriesTemplate.View = splineArea3DSeriesView1
            Me.chartSplineArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartSplineArea3D.TabIndex = 8
            chartTitle7.Text = "Outside Vendor Costs"
            chartTitle7.TitleID = 0
            Me.chartSplineArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle7})
            ' 
            ' dockPanelStackedArea3D
            ' 
            Me.dockPanelStackedArea3D.Controls.Add(Me.dockPanelStackedArea3D_Container)
            Me.dockPanelStackedArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStackedArea3D.DockedAsTabbedDocument = True
            Me.dockPanelStackedArea3D.ID = New System.Guid("88cf4215-2f17-4247-a814-4fa4cf63815e")
            Me.dockPanelStackedArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedArea3D.Name = "dockPanelStackedArea3D"
            Me.dockPanelStackedArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStackedArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelStackedArea3D.Text = "Stacked Area3D"
            ' 
            ' dockPanelStackedArea3D_Container
            ' 
            Me.dockPanelStackedArea3D_Container.Controls.Add(Me.chartStackedArea3D)
            Me.dockPanelStackedArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedArea3D_Container.Name = "dockPanelStackedArea3D_Container"
            Me.dockPanelStackedArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelStackedArea3D_Container.TabIndex = 0
            ' 
            ' chartStackedArea3D
            ' 
            Me.chartStackedArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D5.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D5.AxisY.Label.TextPattern = "${V}M"
            xyDiagram3D5.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D5.RuntimeRotation = True
            xyDiagram3D5.RuntimeScrolling = True
            xyDiagram3D5.RuntimeZooming = True
            xyDiagram3D5.VerticalScrollPercent = 6R
            xyDiagram3D5.ZoomPercent = 140
            Me.chartStackedArea3D.Diagram = xyDiagram3D5
            Me.chartStackedArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStackedArea3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartStackedArea3D.Legend.Name = "Default Legend"
            Me.chartStackedArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartStackedArea3D.Name = "chartStackedArea3D"
            Me.chartStackedArea3D.SeriesDataMember = "Region"
            Me.chartStackedArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartStackedArea3D.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
            Me.chartStackedArea3D.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartStackedArea3D.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            stackedArea3DSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            stackedArea3DSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            Me.chartStackedArea3D.SeriesTemplate.Label = stackedArea3DSeriesLabel1
            Me.chartStackedArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartStackedArea3D.SeriesTemplate.SeriesDataMember = "Region"
            Me.chartStackedArea3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            Me.chartStackedArea3D.SeriesTemplate.View = stackedArea3DSeriesView1
            Me.chartStackedArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartStackedArea3D.TabIndex = 2
            chartTitle8.Text = "DevAV Sales"
            chartTitle8.TitleID = 0
            Me.chartStackedArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle8})
            ' 
            ' dockPanelStackedSplineArea3D
            ' 
            Me.dockPanelStackedSplineArea3D.Controls.Add(Me.dockPanelStackedSplineArea3D_Container)
            Me.dockPanelStackedSplineArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStackedSplineArea3D.DockedAsTabbedDocument = True
            Me.dockPanelStackedSplineArea3D.ID = New System.Guid("d93b85ac-84e1-4ef1-bad1-31d21411b6b1")
            Me.dockPanelStackedSplineArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedSplineArea3D.Name = "dockPanelStackedSplineArea3D"
            Me.dockPanelStackedSplineArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStackedSplineArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelStackedSplineArea3D.Text = "Stacked Spline Area3D"
            ' 
            ' dockPanelStackedSplineArea3D_Container
            ' 
            Me.dockPanelStackedSplineArea3D_Container.Controls.Add(Me.chartStackedSplineArea3D)
            Me.dockPanelStackedSplineArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedSplineArea3D_Container.Name = "dockPanelStackedSplineArea3D_Container"
            Me.dockPanelStackedSplineArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelStackedSplineArea3D_Container.TabIndex = 0
            ' 
            ' chartStackedSplineArea3D
            ' 
            Me.chartStackedSplineArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D6.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D6.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram3D6.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram3D6.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram3D6.AxisY.Interlaced = False
            xyDiagram3D6.AxisY.Label.TextPattern = "${V}M"
            xyDiagram3D6.AxisY.MinorCount = 2
            xyDiagram3D6.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D6.RuntimeRotation = True
            xyDiagram3D6.RuntimeScrolling = True
            xyDiagram3D6.RuntimeZooming = True
            xyDiagram3D6.VerticalScrollPercent = 6R
            xyDiagram3D6.ZoomPercent = 140
            Me.chartStackedSplineArea3D.Diagram = xyDiagram3D6
            Me.chartStackedSplineArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStackedSplineArea3D.Legend.Name = "Default Legend"
            Me.chartStackedSplineArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartStackedSplineArea3D.Name = "chartStackedSplineArea3D"
            Me.chartStackedSplineArea3D.SeriesDataMember = "Region"
            Me.chartStackedSplineArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartStackedSplineArea3D.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartStackedSplineArea3D.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            stackedArea3DSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            Me.chartStackedSplineArea3D.SeriesTemplate.Label = stackedArea3DSeriesLabel2
            Me.chartStackedSplineArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartStackedSplineArea3D.SeriesTemplate.SeriesDataMember = "Region"
            Me.chartStackedSplineArea3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            stackedSplineArea3DSeriesView1.AreaWidth = 1R
            Me.chartStackedSplineArea3D.SeriesTemplate.View = stackedSplineArea3DSeriesView1
            Me.chartStackedSplineArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartStackedSplineArea3D.TabIndex = 3
            chartTitle9.Text = "DevAV Sales"
            chartTitle9.TitleID = 0
            Me.chartStackedSplineArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle9})
            ' 
            ' dockPanelFullStackedArea3D
            ' 
            Me.dockPanelFullStackedArea3D.Controls.Add(Me.dockPanelFullStackedArea3D_Container)
            Me.dockPanelFullStackedArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFullStackedArea3D.DockedAsTabbedDocument = True
            Me.dockPanelFullStackedArea3D.ID = New System.Guid("ba374859-c864-42c1-875a-4078d9200d94")
            Me.dockPanelFullStackedArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedArea3D.Name = "dockPanelFullStackedArea3D"
            Me.dockPanelFullStackedArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFullStackedArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelFullStackedArea3D.Text = "Full Stacked Area3D"
            ' 
            ' dockPanelFullStackedArea3D_Container
            ' 
            Me.dockPanelFullStackedArea3D_Container.Controls.Add(Me.chartFullStackedArea3D)
            Me.dockPanelFullStackedArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedArea3D_Container.Name = "dockPanelFullStackedArea3D_Container"
            Me.dockPanelFullStackedArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelFullStackedArea3D_Container.TabIndex = 0
            ' 
            ' chartFullStackedArea3D
            ' 
            Me.chartFullStackedArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D7.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D7.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram3D7.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram3D7.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram3D7.AxisY.Label.TextPattern = "{V:P0}"
            xyDiagram3D7.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram3D7.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram3D7.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram3D7.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D7.RuntimeRotation = True
            xyDiagram3D7.RuntimeScrolling = True
            xyDiagram3D7.RuntimeZooming = True
            xyDiagram3D7.VerticalScrollPercent = 5R
            xyDiagram3D7.ZoomPercent = 130
            Me.chartFullStackedArea3D.Diagram = xyDiagram3D7
            Me.chartFullStackedArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFullStackedArea3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartFullStackedArea3D.Legend.Name = "Default Legend"
            Me.chartFullStackedArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartFullStackedArea3D.Name = "chartFullStackedArea3D"
            Me.chartFullStackedArea3D.SeriesDataMember = "Company"
            Me.chartFullStackedArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartFullStackedArea3D.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartFullStackedArea3D.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chartFullStackedArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartFullStackedArea3D.SeriesTemplate.SeriesDataMember = "Company"
            Me.chartFullStackedArea3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            fullStackedArea3DSeriesView1.AreaWidth = 1R
            Me.chartFullStackedArea3D.SeriesTemplate.View = fullStackedArea3DSeriesView1
            Me.chartFullStackedArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartFullStackedArea3D.TabIndex = 1
            chartTitle10.Text = "Market Share Over Time"
            chartTitle10.TitleID = 0
            Me.chartFullStackedArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle10})
            ' 
            ' dockPanelFullStackedSplineArea3D
            ' 
            Me.dockPanelFullStackedSplineArea3D.Controls.Add(Me.dockPanelFullStackedSplineArea3D_Container)
            Me.dockPanelFullStackedSplineArea3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFullStackedSplineArea3D.DockedAsTabbedDocument = True
            Me.dockPanelFullStackedSplineArea3D.ID = New System.Guid("be465f3f-4f0e-41c2-bfc0-46d61a61d530")
            Me.dockPanelFullStackedSplineArea3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedSplineArea3D.Name = "dockPanelFullStackedSplineArea3D"
            Me.dockPanelFullStackedSplineArea3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFullStackedSplineArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelFullStackedSplineArea3D.Text = "Full Stacked Spline Area3D"
            ' 
            ' dockPanelFullStackedSplineArea3D_Container
            ' 
            Me.dockPanelFullStackedSplineArea3D_Container.Controls.Add(Me.chartFullStackedSplineArea3D)
            Me.dockPanelFullStackedSplineArea3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedSplineArea3D_Container.Name = "dockPanelFullStackedSplineArea3D_Container"
            Me.dockPanelFullStackedSplineArea3D_Container.Size = New System.Drawing.Size(1089, 548)
            Me.dockPanelFullStackedSplineArea3D_Container.TabIndex = 0
            ' 
            ' chartFullStackedSplineArea3D
            ' 
            Me.chartFullStackedSplineArea3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D8.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D8.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram3D8.AxisX.WholeRange.EndSideMargin = 0R
            xyDiagram3D8.AxisX.WholeRange.StartSideMargin = 0R
            xyDiagram3D8.AxisY.Interlaced = False
            xyDiagram3D8.AxisY.Label.TextPattern = "{V:P0}"
            xyDiagram3D8.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram3D8.AxisY.WholeRange.EndSideMargin = 0R
            xyDiagram3D8.AxisY.WholeRange.StartSideMargin = 0R
            xyDiagram3D8.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D8.RuntimeRotation = True
            xyDiagram3D8.RuntimeScrolling = True
            xyDiagram3D8.RuntimeZooming = True
            xyDiagram3D8.VerticalScrollPercent = 5R
            xyDiagram3D8.ZoomPercent = 130
            Me.chartFullStackedSplineArea3D.Diagram = xyDiagram3D8
            Me.chartFullStackedSplineArea3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFullStackedSplineArea3D.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartFullStackedSplineArea3D.Legend.Name = "Default Legend"
            Me.chartFullStackedSplineArea3D.Location = New System.Drawing.Point(0, 0)
            Me.chartFullStackedSplineArea3D.Name = "chartFullStackedSplineArea3D"
            Me.chartFullStackedSplineArea3D.SeriesDataMember = "Company"
            Me.chartFullStackedSplineArea3D.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartFullStackedSplineArea3D.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartFullStackedSplineArea3D.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            Me.chartFullStackedSplineArea3D.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartFullStackedSplineArea3D.SeriesTemplate.SeriesDataMember = "Company"
            Me.chartFullStackedSplineArea3D.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            fullStackedSplineArea3DSeriesView1.AreaWidth = 1R
            Me.chartFullStackedSplineArea3D.SeriesTemplate.View = fullStackedSplineArea3DSeriesView1
            Me.chartFullStackedSplineArea3D.Size = New System.Drawing.Size(1089, 548)
            Me.chartFullStackedSplineArea3D.TabIndex = 2
            chartTitle11.Text = "Market Share Over Time"
            chartTitle11.TitleID = 0
            Me.chartFullStackedSplineArea3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle11})
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
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentArea3D, Me.documentRangeArea3D, Me.documentStepArea3D, Me.documentStackedArea3D, Me.documentStackedSplineArea3D, Me.documentFullStackedArea3D, Me.documentFullStackedSplineArea3D, Me.documentSplineArea3D})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.documentManager_DocumentActivate)
            ' 
            ' Area3DViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Area3DViewsDemo"
            Me.Size = New System.Drawing.Size(1089, 571)
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentRangeArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStepArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentSplineArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStackedArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStackedSplineArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFullStackedArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFullStackedSplineArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditTransparency.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditInvertedStep.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemInvertedStep), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTransparency), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPerspectiveAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelArea3D.ResumeLayout(False)
            Me.dockPanelArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((area3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((area3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelRangeArea3D.ResumeLayout(False)
            Me.dockPanelRangeArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((rangeArea3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((rangeArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((overlappedRangeBarSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartRangeArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStepArea3D.ResumeLayout(False)
            Me.dockPanelStepArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((area3DSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stepArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stepArea3DSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStepArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelSplineArea3D.ResumeLayout(False)
            Me.dockPanelSplineArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartSplineArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStackedArea3D.ResumeLayout(False)
            Me.dockPanelStackedArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedArea3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStackedArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStackedSplineArea3D.ResumeLayout(False)
            Me.dockPanelStackedSplineArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedArea3DSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedSplineArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStackedSplineArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFullStackedArea3D.ResumeLayout(False)
            Me.dockPanelFullStackedArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((fullStackedArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFullStackedArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFullStackedSplineArea3D.ResumeLayout(False)
            Me.dockPanelFullStackedSplineArea3D_Container.ResumeLayout(False)
            CType((xyDiagram3D8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((fullStackedSplineArea3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFullStackedSplineArea3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private spinEditTransparency As DevExpress.XtraEditors.SpinEdit

        Private checkEditInvertedStep As DevExpress.XtraEditors.CheckEdit

        Private checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemTransparency As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemInvertedStep As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemValueAsPercent As DevExpress.XtraLayout.LayoutControlItem

        Private comboBoxEditPerspectiveAngle As DevExpress.XtraEditors.ComboBoxEdit

        Private simpleButtonRestoreDefaultAngles As DevExpress.XtraEditors.SimpleButton

        Private layoutControlGroupCamera As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemPerspectiveAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemRestoreDefaultAngles As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private dockPanelRangeArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelRangeArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStepArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStepArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelSplineArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelSplineArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStackedArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStackedArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStackedSplineArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStackedSplineArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFullStackedArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFullStackedArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFullStackedSplineArea3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFullStackedSplineArea3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentRangeArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStepArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentSplineArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStackedArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStackedSplineArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFullStackedArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFullStackedSplineArea3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartRangeArea3D As DevExpress.XtraCharts.ChartControl

        Private chartStepArea3D As DevExpress.XtraCharts.ChartControl

        Private chartSplineArea3D As DevExpress.XtraCharts.ChartControl

        Private chartArea3D As DevExpress.XtraCharts.ChartControl

        Private chartStackedArea3D As DevExpress.XtraCharts.ChartControl

        Private chartStackedSplineArea3D As DevExpress.XtraCharts.ChartControl

        Private chartFullStackedArea3D As DevExpress.XtraCharts.ChartControl

        Private chartFullStackedSplineArea3D As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
