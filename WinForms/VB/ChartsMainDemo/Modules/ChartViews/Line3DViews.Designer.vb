Namespace DevExpress.XtraCharts.Demos

    Partial Class Line3DViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.Line3DViewsDemo))
            Dim xyDiagram3D1 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim line3DSeriesLabel2 As DevExpress.XtraCharts.Line3DSeriesLabel = New DevExpress.XtraCharts.Line3DSeriesLabel()
            Dim line3DSeriesView2 As DevExpress.XtraCharts.Line3DSeriesView = New DevExpress.XtraCharts.Line3DSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim line3DSeriesLabel3 As DevExpress.XtraCharts.Line3DSeriesLabel = New DevExpress.XtraCharts.Line3DSeriesLabel()
            Dim line3DSeriesView3 As DevExpress.XtraCharts.Line3DSeriesView = New DevExpress.XtraCharts.Line3DSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D2 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim line3DSeriesLabel4 As DevExpress.XtraCharts.Line3DSeriesLabel = New DevExpress.XtraCharts.Line3DSeriesLabel()
            Dim stepLine3DSeriesView1 As DevExpress.XtraCharts.StepLine3DSeriesView = New DevExpress.XtraCharts.StepLine3DSeriesView()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D3 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim series6 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim line3DSeriesLabel6 As DevExpress.XtraCharts.Line3DSeriesLabel = New DevExpress.XtraCharts.Line3DSeriesLabel()
            Dim spline3DSeriesView2 As DevExpress.XtraCharts.Spline3DSeriesView = New DevExpress.XtraCharts.Spline3DSeriesView()
            Dim series7 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim line3DSeriesLabel7 As DevExpress.XtraCharts.Line3DSeriesLabel = New DevExpress.XtraCharts.Line3DSeriesLabel()
            Dim spline3DSeriesView3 As DevExpress.XtraCharts.Spline3DSeriesView = New DevExpress.XtraCharts.Spline3DSeriesView()
            Dim spline3DSeriesView4 As DevExpress.XtraCharts.Spline3DSeriesView = New DevExpress.XtraCharts.Spline3DSeriesView()
            Dim chartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D4 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim stackedLine3DSeriesLabel1 As DevExpress.XtraCharts.StackedLine3DSeriesLabel = New DevExpress.XtraCharts.StackedLine3DSeriesLabel()
            Dim stackedLine3DSeriesView1 As DevExpress.XtraCharts.StackedLine3DSeriesView = New DevExpress.XtraCharts.StackedLine3DSeriesView()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram3D5 As DevExpress.XtraCharts.XYDiagram3D = New DevExpress.XtraCharts.XYDiagram3D()
            Dim stackedLine3DSeriesLabel2 As DevExpress.XtraCharts.StackedLine3DSeriesLabel = New DevExpress.XtraCharts.StackedLine3DSeriesLabel()
            Dim fullStackedLine3DSeriesView1 As DevExpress.XtraCharts.FullStackedLine3DSeriesView = New DevExpress.XtraCharts.FullStackedLine3DSeriesView()
            Dim chartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentLine3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStepLine3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentSpline3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentStackedLine3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentFullStackedLine3D = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelLine3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelLine3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartLine3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStepLine3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStepLine3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStepLine3D = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelSpline3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelSpline3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartSpline = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelStackedLine3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelStackedLine3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartStackedLine = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelFullStackedLine3D = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelFullStackedLine3D_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartFulStackedLine = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditValueAsPercent = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditPerspectiveAngle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.simpleButtonRestoreDefaultAngles = New DevExpress.XtraEditors.SimpleButton()
            Me.checkEditInvertedStep = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItemInvertedStep = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupLabelOptions = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.LayoutControlItemValueAsPercent = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupCamera = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemPerspectiveAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRestoreDefaultAngles = New DevExpress.XtraLayout.LayoutControlItem()
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentLine3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStepLine3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentSpline3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentStackedLine3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentFullStackedLine3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelLine3D.SuspendLayout()
            Me.dockPanelLine3D_Container.SuspendLayout()
            CType((Me.chartLine3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStepLine3D.SuspendLayout()
            Me.dockPanelStepLine3D_Container.SuspendLayout()
            CType((Me.chartStepLine3D), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stepLine3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelSpline3D.SuspendLayout()
            Me.dockPanelSpline3D_Container.SuspendLayout()
            CType((Me.chartSpline), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((spline3DSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((line3DSeriesLabel7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((spline3DSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((spline3DSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelStackedLine3D.SuspendLayout()
            Me.dockPanelStackedLine3D_Container.SuspendLayout()
            CType((Me.chartStackedLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedLine3DSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedLine3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelFullStackedLine3D.SuspendLayout()
            Me.dockPanelFullStackedLine3D_Container.SuspendLayout()
            CType((Me.chartFulStackedLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram3D5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((stackedLine3DSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((fullStackedLine3DSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditInvertedStep.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LayoutControlItemInvertedStep), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabelOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.LayoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPerspectiveAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentLine3D, Me.documentStepLine3D, Me.documentSpline3D, Me.documentStackedLine3D, Me.documentFullStackedLine3D})
            ' 
            ' documentLine3D
            ' 
            Me.documentLine3D.Caption = "Line 3D"
            Me.documentLine3D.ControlName = "dockPanelLine3D"
            Me.documentLine3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentLine3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentLine3D.ImageOptions.SvgImage = CType((resources.GetObject("documentLine3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentLine3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentLine3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentLine3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentLine3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStepLine3D
            ' 
            Me.documentStepLine3D.Caption = "Step Line 3D"
            Me.documentStepLine3D.ControlName = "dockPanelStepLine3D"
            Me.documentStepLine3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStepLine3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStepLine3D.ImageOptions.SvgImage = CType((resources.GetObject("documentStepLine3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStepLine3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStepLine3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStepLine3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStepLine3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentSpline3D
            ' 
            Me.documentSpline3D.Caption = "Spline 3D"
            Me.documentSpline3D.ControlName = "dockPanelSpline3D"
            Me.documentSpline3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentSpline3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentSpline3D.ImageOptions.SvgImage = CType((resources.GetObject("documentSpline3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentSpline3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentSpline3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentSpline3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentSpline3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentStackedLine3D
            ' 
            Me.documentStackedLine3D.Caption = "Stacked Line 3D"
            Me.documentStackedLine3D.ControlName = "dockPanelStackedLine3D"
            Me.documentStackedLine3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentStackedLine3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentStackedLine3D.ImageOptions.SvgImage = CType((resources.GetObject("documentStackedLine3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentStackedLine3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentStackedLine3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentStackedLine3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentStackedLine3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentFullStackedLine3D
            ' 
            Me.documentFullStackedLine3D.Caption = "Full Stacked Line 3D"
            Me.documentFullStackedLine3D.ControlName = "dockPanelFullStackedLine3D"
            Me.documentFullStackedLine3D.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentFullStackedLine3D.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentFullStackedLine3D.ImageOptions.SvgImage = CType((resources.GetObject("documentFullStackedLine3D.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentFullStackedLine3D.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentFullStackedLine3D.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentFullStackedLine3D.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentFullStackedLine3D.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelLine3D, Me.dockPanelStepLine3D, Me.dockPanelSpline3D, Me.dockPanelStackedLine3D, Me.dockPanelFullStackedLine3D})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelLine3D
            ' 
            Me.dockPanelLine3D.Controls.Add(Me.dockPanelLine3D_Container)
            Me.dockPanelLine3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelLine3D.DockedAsTabbedDocument = True
            Me.dockPanelLine3D.ID = New System.Guid("1feacfba-c28e-4c74-b015-fb722e6284d7")
            Me.dockPanelLine3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLine3D.Name = "dockPanelLine3D"
            Me.dockPanelLine3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelLine3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelLine3D.Text = "Line 3D"
            ' 
            ' dockPanelLine3D_Container
            ' 
            Me.dockPanelLine3D_Container.Controls.Add(Me.chartLine3D)
            Me.dockPanelLine3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLine3D_Container.Name = "dockPanelLine3D_Container"
            Me.dockPanelLine3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelLine3D_Container.TabIndex = 0
            ' 
            ' chartLine3D
            ' 
            Me.chartLine3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D1.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram3D1.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram3D1.AxisY.NumericScaleOptions.GridSpacing = 50R
            xyDiagram3D1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram3D1.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & "1"
            xyDiagram3D1.RuntimeRotation = True
            xyDiagram3D1.RuntimeScrolling = True
            xyDiagram3D1.RuntimeZooming = True
            xyDiagram3D1.SeriesDistance = 0R
            xyDiagram3D1.VerticalScrollPercent = 6R
            xyDiagram3D1.ZoomPercent = 130
            Me.chartLine3D.Diagram = xyDiagram3D1
            Me.chartLine3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartLine3D.Legend.Name = "Default Legend"
            Me.chartLine3D.Location = New System.Drawing.Point(0, 0)
            Me.chartLine3D.Name = "chartLine3D"
            series2.ArgumentDataMember = "Date"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            line3DSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            line3DSeriesLabel2.TextPattern = "{V:F2}"
            series2.Label = line3DSeriesLabel2
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "South Africa"
            series2.ValueDataMembersSerializable = "South Africa"
            line3DSeriesView2.LineWidth = 2R
            series2.View = line3DSeriesView2
            series3.ArgumentDataMember = "Date"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            line3DSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            line3DSeriesLabel3.TextPattern = "{V:F2}"
            series3.Label = line3DSeriesLabel3
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series3.Name = "Poland"
            series3.ValueDataMembersSerializable = "Poland"
            line3DSeriesView3.LineWidth = 2R
            series3.View = line3DSeriesView3
            Me.chartLine3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2, series3}
            Me.chartLine3D.Size = New System.Drawing.Size(788, 548)
            Me.chartLine3D.TabIndex = 1
            chartTitle1.Text = "Coal Production, in Millions of Tonnes"
            chartTitle2.Alignment = System.Drawing.StringAlignment.Far
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = "From www.quandl.com"
            chartTitle2.TextColor = System.Drawing.Color.Gray
            Me.chartLine3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' dockPanelStepLine3D
            ' 
            Me.dockPanelStepLine3D.Controls.Add(Me.dockPanelStepLine3D_Container)
            Me.dockPanelStepLine3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStepLine3D.DockedAsTabbedDocument = True
            Me.dockPanelStepLine3D.ID = New System.Guid("6f7e5909-a918-4558-b11b-28e4a1d91835")
            Me.dockPanelStepLine3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStepLine3D.Name = "dockPanelStepLine3D"
            Me.dockPanelStepLine3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStepLine3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelStepLine3D.Text = "Step Line 3D"
            ' 
            ' dockPanelStepLine3D_Container
            ' 
            Me.dockPanelStepLine3D_Container.Controls.Add(Me.chartStepLine3D)
            Me.dockPanelStepLine3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStepLine3D_Container.Name = "dockPanelStepLine3D_Container"
            Me.dockPanelStepLine3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelStepLine3D_Container.TabIndex = 0
            ' 
            ' chartStepLine3D
            ' 
            Me.chartStepLine3D.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Month
            xyDiagram3D2.AxisX.Label.TextPattern = "{A:MMMM}"
            xyDiagram3D2.AxisY.Label.TextPattern = "{V:N1}"
            xyDiagram3D2.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram3D2.RotationMatrixSerializable = "0.766044437885284;-0.219846323132515;0.604022800922394;0;0;0.939692616462708;0.34" & "2020153999329;0;-0.642787635326386;-0.262002646923065;0.719846308231354;0;0;0;0;" & "1"
            xyDiagram3D2.RuntimeRotation = True
            xyDiagram3D2.RuntimeScrolling = True
            xyDiagram3D2.RuntimeZooming = True
            xyDiagram3D2.VerticalScrollPercent = 4R
            xyDiagram3D2.ZoomPercent = 140
            Me.chartStepLine3D.Diagram = xyDiagram3D2
            Me.chartStepLine3D.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStepLine3D.Legend.Name = "Default Legend"
            Me.chartStepLine3D.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartStepLine3D.Location = New System.Drawing.Point(0, 0)
            Me.chartStepLine3D.Name = "chartStepLine3D"
            series4.ArgumentDataMember = "Date"
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            line3DSeriesLabel4.TextPattern = "{V:#.00}"
            series4.Label = line3DSeriesLabel4
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series4.Name = "Gasoline Prices"
            series4.ValueDataMembersSerializable = "Price"
            stepLine3DSeriesView1.LineWidth = 1.2R
            series4.View = stepLine3DSeriesView1
            Me.chartStepLine3D.SeriesSerializable = New DevExpress.XtraCharts.Series() {series4}
            Me.chartStepLine3D.Size = New System.Drawing.Size(788, 548)
            Me.chartStepLine3D.TabIndex = 1
            chartTitle3.Text = "US Gasoline Prices in 2015"
            chartTitle4.Alignment = System.Drawing.StringAlignment.Far
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle4.Text = "From www.eia.gov"
            chartTitle4.TextColor = System.Drawing.Color.Gray
            chartTitle5.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 12F)
            chartTitle5.Text = "Dollars per Gallon"
            Me.chartStepLine3D.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3, chartTitle4, chartTitle5})
            ' 
            ' dockPanelSpline3D
            ' 
            Me.dockPanelSpline3D.Controls.Add(Me.dockPanelSpline3D_Container)
            Me.dockPanelSpline3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelSpline3D.DockedAsTabbedDocument = True
            Me.dockPanelSpline3D.ID = New System.Guid("1dc62d26-870f-4257-8468-44e6e26bf044")
            Me.dockPanelSpline3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelSpline3D.Name = "dockPanelSpline3D"
            Me.dockPanelSpline3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelSpline3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelSpline3D.Text = "Spline 3D"
            ' 
            ' dockPanelSpline3D_Container
            ' 
            Me.dockPanelSpline3D_Container.Controls.Add(Me.chartSpline)
            Me.dockPanelSpline3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelSpline3D_Container.Name = "dockPanelSpline3D_Container"
            Me.dockPanelSpline3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelSpline3D_Container.TabIndex = 0
            ' 
            ' chartSpline
            ' 
            Me.chartSpline.AccessibleRole = System.Windows.Forms.AccessibleRole.None
            Me.chartSpline.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D3.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D3.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram3D3.AxisY.NumericScaleOptions.AutoGrid = False
            xyDiagram3D3.AxisY.NumericScaleOptions.GridAlignment = DevExpress.XtraCharts.NumericGridAlignment.Tens
            xyDiagram3D3.AxisY.NumericScaleOptions.GridSpacing = 5R
            xyDiagram3D3.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram3D3.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D3.RuntimeRotation = True
            xyDiagram3D3.RuntimeScrolling = True
            xyDiagram3D3.RuntimeZooming = True
            xyDiagram3D3.VerticalScrollPercent = 6R
            xyDiagram3D3.ZoomPercent = 130
            Me.chartSpline.Diagram = xyDiagram3D3
            Me.chartSpline.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartSpline.Legend.Name = "Default Legend"
            Me.chartSpline.Location = New System.Drawing.Point(0, 0)
            Me.chartSpline.Name = "chartSpline"
            series6.ArgumentDataMember = "Date"
            series6.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            line3DSeriesLabel6.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            series6.Label = line3DSeriesLabel6
            series6.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series6.Name = "South Africa"
            series6.ValueDataMembersSerializable = "South Africa"
            spline3DSeriesView2.LineWidth = 2R
            series6.View = spline3DSeriesView2
            series7.ArgumentDataMember = "Date"
            series7.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            line3DSeriesLabel7.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            series7.Label = line3DSeriesLabel7
            series7.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series7.Name = "Poland"
            series7.ValueDataMembersSerializable = "Poland"
            spline3DSeriesView3.LineWidth = 2R
            series7.View = spline3DSeriesView3
            Me.chartSpline.SeriesSerializable = New DevExpress.XtraCharts.Series() {series6, series7}
            Me.chartSpline.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartSpline.SeriesTemplate.View = spline3DSeriesView4
            Me.chartSpline.Size = New System.Drawing.Size(788, 548)
            Me.chartSpline.TabIndex = 1
            chartTitle6.Text = "Coal Production, in Millions of Tonnes"
            chartTitle7.Alignment = System.Drawing.StringAlignment.Far
            chartTitle7.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle7.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle7.Text = "From www.quandl.com"
            chartTitle7.TextColor = System.Drawing.Color.Gray
            Me.chartSpline.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle6, chartTitle7})
            ' 
            ' dockPanelStackedLine3D
            ' 
            Me.dockPanelStackedLine3D.Controls.Add(Me.dockPanelStackedLine3D_Container)
            Me.dockPanelStackedLine3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelStackedLine3D.DockedAsTabbedDocument = True
            Me.dockPanelStackedLine3D.ID = New System.Guid("4fbf69ff-a2ed-4947-90b5-dbd65e039834")
            Me.dockPanelStackedLine3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedLine3D.Name = "dockPanelStackedLine3D"
            Me.dockPanelStackedLine3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelStackedLine3D.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelStackedLine3D.Text = "Stacked Line 3D"
            ' 
            ' dockPanelStackedLine3D_Container
            ' 
            Me.dockPanelStackedLine3D_Container.Controls.Add(Me.chartStackedLine)
            Me.dockPanelStackedLine3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelStackedLine3D_Container.Name = "dockPanelStackedLine3D_Container"
            Me.dockPanelStackedLine3D_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelStackedLine3D_Container.TabIndex = 0
            ' 
            ' chartStackedLine
            ' 
            Me.chartStackedLine.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D4.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D4.AxisY.Label.TextPattern = "${V}M"
            xyDiagram3D4.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D4.RuntimeRotation = True
            xyDiagram3D4.RuntimeScrolling = True
            xyDiagram3D4.RuntimeZooming = True
            xyDiagram3D4.VerticalScrollPercent = 4R
            xyDiagram3D4.ZoomPercent = 130
            Me.chartStackedLine.Diagram = xyDiagram3D4
            Me.chartStackedLine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartStackedLine.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartStackedLine.Legend.Name = "Default Legend"
            Me.chartStackedLine.Location = New System.Drawing.Point(0, 0)
            Me.chartStackedLine.Name = "chartStackedLine"
            Me.chartStackedLine.SeriesDataMember = "Region"
            Me.chartStackedLine.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartStackedLine.SeriesSorting = DevExpress.XtraCharts.SortingMode.Descending
            Me.chartStackedLine.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartStackedLine.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            stackedLine3DSeriesLabel1.TextPattern = "${V}M"
            Me.chartStackedLine.SeriesTemplate.Label = stackedLine3DSeriesLabel1
            Me.chartStackedLine.SeriesTemplate.SeriesDataMember = "Region"
            Me.chartStackedLine.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            Me.chartStackedLine.SeriesTemplate.View = stackedLine3DSeriesView1
            Me.chartStackedLine.Size = New System.Drawing.Size(788, 548)
            Me.chartStackedLine.TabIndex = 1
            chartTitle8.Text = "DevAV Sales"
            Me.chartStackedLine.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle8})
            ' 
            ' dockPanelFullStackedLine3D
            ' 
            Me.dockPanelFullStackedLine3D.Controls.Add(Me.dockPanelFullStackedLine3D_Container)
            Me.dockPanelFullStackedLine3D.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelFullStackedLine3D.DockedAsTabbedDocument = True
            Me.dockPanelFullStackedLine3D.ID = New System.Guid("8e5d0b1c-bc5d-41e3-bac5-247a58c7f250")
            Me.dockPanelFullStackedLine3D.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedLine3D.Name = "dockPanelFullStackedLine3D"
            Me.dockPanelFullStackedLine3D.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelFullStackedLine3D.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelFullStackedLine3D.Text = "Full Stacked Line 3D"
            ' 
            ' dockPanelFullStackedLine3D_Container
            ' 
            Me.dockPanelFullStackedLine3D_Container.Controls.Add(Me.chartFulStackedLine)
            Me.dockPanelFullStackedLine3D_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelFullStackedLine3D_Container.Name = "dockPanelFullStackedLine3D_Container"
            Me.dockPanelFullStackedLine3D_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelFullStackedLine3D_Container.TabIndex = 0
            ' 
            ' chartFulStackedLine
            ' 
            Me.chartFulStackedLine.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram3D5.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram3D5.AxisY.Label.TextPattern = "{V:P0}"
            xyDiagram3D5.AxisY.WholeRange.AutoSideMargins = False
            xyDiagram3D5.AxisY.WholeRange.SideMarginsValue = 0R
            xyDiagram3D5.RotationMatrixSerializable = "0.766044443118978;-0.219846310392954;0.604022773555054;0;0;0.939692620785908;0.34" & "2020143325669;0;-0.642787609686539;-0.262002630229385;0.719846310392954;0;0;0;0;" & "1"
            xyDiagram3D5.RuntimeRotation = True
            xyDiagram3D5.RuntimeScrolling = True
            xyDiagram3D5.RuntimeZooming = True
            xyDiagram3D5.VerticalScrollPercent = 4R
            xyDiagram3D5.ZoomPercent = 130
            Me.chartFulStackedLine.Diagram = xyDiagram3D5
            Me.chartFulStackedLine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartFulStackedLine.Legend.Direction = DevExpress.XtraCharts.LegendDirection.BottomToTop
            Me.chartFulStackedLine.Legend.Name = "Default Legend"
            Me.chartFulStackedLine.Location = New System.Drawing.Point(0, 0)
            Me.chartFulStackedLine.Name = "chartFulStackedLine"
            Me.chartFulStackedLine.SeriesDataMember = "Company"
            Me.chartFulStackedLine.SeriesSerializable = New DevExpress.XtraCharts.Series(-1) {}
            Me.chartFulStackedLine.SeriesTemplate.ArgumentDataMember = "Year"
            Me.chartFulStackedLine.SeriesTemplate.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            stackedLine3DSeriesLabel2.TextPattern = "{VP:P0}"
            Me.chartFulStackedLine.SeriesTemplate.Label = stackedLine3DSeriesLabel2
            Me.chartFulStackedLine.SeriesTemplate.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartFulStackedLine.SeriesTemplate.SeriesDataMember = "Company"
            Me.chartFulStackedLine.SeriesTemplate.ValueDataMembersSerializable = "Sales"
            fullStackedLine3DSeriesView1.LineWidth = 1R
            Me.chartFulStackedLine.SeriesTemplate.View = fullStackedLine3DSeriesView1
            Me.chartFulStackedLine.Size = New System.Drawing.Size(788, 545)
            Me.chartFulStackedLine.TabIndex = 1
            chartTitle9.Text = "Market Share Over Time"
            Me.chartFulStackedLine.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle9})
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
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentLine3D, Me.documentStepLine3D, Me.documentSpline3D, Me.documentStackedLine3D, Me.documentFullStackedLine3D})
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
            Me.layoutControl.Controls.Add(Me.checkEditInvertedStep)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(237, 228, 650, 400)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 3
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 93)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 19)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' checkEditValueAsPercent
            ' 
            Me.checkEditValueAsPercent.EditValue = True
            Me.checkEditValueAsPercent.Location = New System.Drawing.Point(12, 116)
            Me.checkEditValueAsPercent.Name = "checkEditValueAsPercent"
            Me.checkEditValueAsPercent.Properties.Caption = "Value as Percent"
            Me.checkEditValueAsPercent.Size = New System.Drawing.Size(217, 19)
            Me.checkEditValueAsPercent.StyleController = Me.layoutControl
            Me.checkEditValueAsPercent.TabIndex = 5
            ' 
            ' comboBoxEditPerspectiveAngle
            ' 
            Me.comboBoxEditPerspectiveAngle.Location = New System.Drawing.Point(105, 178)
            Me.comboBoxEditPerspectiveAngle.Name = "comboBoxEditPerspectiveAngle"
            Me.comboBoxEditPerspectiveAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditPerspectiveAngle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditPerspectiveAngle.Size = New System.Drawing.Size(124, 20)
            Me.comboBoxEditPerspectiveAngle.StyleController = Me.layoutControl
            Me.comboBoxEditPerspectiveAngle.TabIndex = 6
            ' 
            ' simpleButtonRestoreDefaultAngles
            ' 
            Me.simpleButtonRestoreDefaultAngles.Location = New System.Drawing.Point(12, 210)
            Me.simpleButtonRestoreDefaultAngles.Name = "simpleButtonRestoreDefaultAngles"
            Me.simpleButtonRestoreDefaultAngles.Size = New System.Drawing.Size(217, 22)
            Me.simpleButtonRestoreDefaultAngles.StyleController = Me.layoutControl
            Me.simpleButtonRestoreDefaultAngles.TabIndex = 7
            Me.simpleButtonRestoreDefaultAngles.Text = "Restore Default Angles"
            ' 
            ' checkEditInvertedStep
            ' 
            Me.checkEditInvertedStep.Location = New System.Drawing.Point(12, 31)
            Me.checkEditInvertedStep.Name = "checkEditInvertedStep"
            Me.checkEditInvertedStep.Properties.Caption = "Inverted Step"
            Me.checkEditInvertedStep.Size = New System.Drawing.Size(217, 19)
            Me.checkEditInvertedStep.StyleController = Me.layoutControl
            Me.checkEditInvertedStep.TabIndex = 0
            AddHandler Me.checkEditInvertedStep.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditInvertedStep_CheckedChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupGeneral, Me.layoutControlGroupLabelOptions, Me.emptySpaceItem, Me.layoutControlGroupCamera})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItemInvertedStep})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 62)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' LayoutControlItemInvertedStep
            ' 
            Me.LayoutControlItemInvertedStep.Control = Me.checkEditInvertedStep
            Me.LayoutControlItemInvertedStep.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItemInvertedStep.Name = "LayoutControlItemInvertedStep"
            Me.LayoutControlItemInvertedStep.Size = New System.Drawing.Size(221, 23)
            Me.LayoutControlItemInvertedStep.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItemInvertedStep.TextVisible = False
            ' 
            ' layoutControlGroupLabelOptions
            ' 
            Me.layoutControlGroupLabelOptions.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabelOptions.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabelOptions.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabelOptions.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.LayoutControlItemValueAsPercent})
            Me.layoutControlGroupLabelOptions.Location = New System.Drawing.Point(0, 62)
            Me.layoutControlGroupLabelOptions.Name = "layoutControlGroupLabelOptions"
            Me.layoutControlGroupLabelOptions.Size = New System.Drawing.Size(241, 85)
            Me.layoutControlGroupLabelOptions.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabelOptions.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemLabelVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' LayoutControlItemValueAsPercent
            ' 
            Me.LayoutControlItemValueAsPercent.Control = Me.checkEditValueAsPercent
            Me.LayoutControlItemValueAsPercent.Location = New System.Drawing.Point(0, 23)
            Me.LayoutControlItemValueAsPercent.Name = "LayoutControlItemValueAsPercent"
            Me.LayoutControlItemValueAsPercent.Size = New System.Drawing.Size(221, 23)
            Me.LayoutControlItemValueAsPercent.TextLocation = DevExpress.Utils.Locations.Left
            Me.LayoutControlItemValueAsPercent.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItemValueAsPercent.TextVisible = False
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 244)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 300)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
            ' 
            ' layoutControlGroupCamera
            ' 
            Me.layoutControlGroupCamera.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupCamera.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupCamera.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupCamera.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemPerspectiveAngle, Me.layoutControlItemRestoreDefaultAngles})
            Me.layoutControlGroupCamera.Location = New System.Drawing.Point(0, 147)
            Me.layoutControlGroupCamera.Name = "layoutControlGroupCamera"
            Me.layoutControlGroupCamera.Size = New System.Drawing.Size(241, 97)
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
            Me.layoutControlItemRestoreDefaultAngles.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemRestoreDefaultAngles.TextVisible = False
            ' 
            ' Line3DViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "Line3DViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentLine3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStepLine3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentSpline3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentStackedLine3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentFullStackedLine3D), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelLine3D.ResumeLayout(False)
            Me.dockPanelLine3D_Container.ResumeLayout(False)
            CType((xyDiagram3D1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartLine3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStepLine3D.ResumeLayout(False)
            Me.dockPanelStepLine3D_Container.ResumeLayout(False)
            CType((xyDiagram3D2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stepLine3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStepLine3D), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelSpline3D.ResumeLayout(False)
            Me.dockPanelSpline3D_Container.ResumeLayout(False)
            CType((xyDiagram3D3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((spline3DSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((line3DSeriesLabel7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((spline3DSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((spline3DSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartSpline), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelStackedLine3D.ResumeLayout(False)
            Me.dockPanelStackedLine3D_Container.ResumeLayout(False)
            CType((xyDiagram3D4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedLine3DSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedLine3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartStackedLine), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelFullStackedLine3D.ResumeLayout(False)
            Me.dockPanelFullStackedLine3D_Container.ResumeLayout(False)
            CType((xyDiagram3D5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((stackedLine3DSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((fullStackedLine3DSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartFulStackedLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditValueAsPercent.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditPerspectiveAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditInvertedStep.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LayoutControlItemInvertedStep), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabelOptions), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.LayoutControlItemValueAsPercent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupCamera), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPerspectiveAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRestoreDefaultAngles), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelLine3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelLine3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentLine3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStepLine3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentSpline3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentStackedLine3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentFullStackedLine3D As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private dockPanelStepLine3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStepLine3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelSpline3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelSpline3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelStackedLine3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelStackedLine3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelFullStackedLine3D As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelFullStackedLine3D_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private checkEditValueAsPercent As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditPerspectiveAngle As DevExpress.XtraEditors.ComboBoxEdit

        Private simpleButtonRestoreDefaultAngles As DevExpress.XtraEditors.SimpleButton

        Private checkEditInvertedStep As DevExpress.XtraEditors.CheckEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupCamera As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemPerspectiveAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemRestoreDefaultAngles As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private LayoutControlItemInvertedStep As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupLabelOptions As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private LayoutControlItemValueAsPercent As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private chartLine3D As DevExpress.XtraCharts.ChartControl

        Private chartStepLine3D As DevExpress.XtraCharts.ChartControl

        Private chartSpline As DevExpress.XtraCharts.ChartControl

        Private chartStackedLine As DevExpress.XtraCharts.ChartControl

        Private chartFulStackedLine As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace
