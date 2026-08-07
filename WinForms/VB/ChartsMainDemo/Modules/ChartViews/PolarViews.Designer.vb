Namespace DevExpress.XtraCharts.Demos

    Partial Class PolarViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.PolarViewsDemo))
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarPointSeriesLabel1 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
            Dim polarPointSeriesView1 As DevExpress.XtraCharts.PolarPointSeriesView = New DevExpress.XtraCharts.PolarPointSeriesView()
            Dim circularMarkerSlideAnimation1 As DevExpress.XtraCharts.CircularMarkerSlideAnimation = New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
            Dim sideBySideBarSeriesLabel1 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarPointSeriesLabel2 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
            Dim polarLineSeriesView1 As DevExpress.XtraCharts.PolarLineSeriesView = New DevExpress.XtraCharts.PolarLineSeriesView()
            Dim circularSeriesUnwindFromCenterAnimation1 As DevExpress.XtraCharts.CircularSeriesUnwindFromCenterAnimation = New DevExpress.XtraCharts.CircularSeriesUnwindFromCenterAnimation()
            Dim circularMarkerWidenAnimation1 As DevExpress.XtraCharts.CircularMarkerWidenAnimation = New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
            Dim sideBySideBarSeriesLabel2 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle4 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim polarDiagram1 As DevExpress.XtraCharts.PolarDiagram = New DevExpress.XtraCharts.PolarDiagram()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarPointSeriesLabel3 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
            Dim polarAreaSeriesView1 As DevExpress.XtraCharts.PolarAreaSeriesView = New DevExpress.XtraCharts.PolarAreaSeriesView()
            Dim circularSeriesLinearUnwindAnimation1 As DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation = New DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation()
            Dim circularMarkerSlideAnimation2 As DevExpress.XtraCharts.CircularMarkerSlideAnimation = New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
            Dim sideBySideBarSeriesLabel3 As DevExpress.XtraCharts.SideBySideBarSeriesLabel = New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
            Dim chartTitle5 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle6 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim polarDiagram2 As DevExpress.XtraCharts.PolarDiagram = New DevExpress.XtraCharts.PolarDiagram()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarPointSeriesLabel4 As DevExpress.XtraCharts.RadarPointSeriesLabel = New DevExpress.XtraCharts.RadarPointSeriesLabel()
            Dim scatterPolarLineSeriesView1 As DevExpress.XtraCharts.ScatterPolarLineSeriesView = New DevExpress.XtraCharts.ScatterPolarLineSeriesView()
            Dim circularSeriesUnwindFromCenterAnimation2 As DevExpress.XtraCharts.CircularSeriesUnwindFromCenterAnimation = New DevExpress.XtraCharts.CircularSeriesUnwindFromCenterAnimation()
            Dim linearEasingFunction1 As DevExpress.XtraCharts.LinearEasingFunction = New DevExpress.XtraCharts.LinearEasingFunction()
            Dim circularMarkerWidenAnimation2 As DevExpress.XtraCharts.CircularMarkerWidenAnimation = New DevExpress.XtraCharts.CircularMarkerWidenAnimation()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim polarDiagram3 As DevExpress.XtraCharts.PolarDiagram = New DevExpress.XtraCharts.PolarDiagram()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim radarRangeAreaSeriesLabel1 As DevExpress.XtraCharts.RadarRangeAreaSeriesLabel = New DevExpress.XtraCharts.RadarRangeAreaSeriesLabel()
            Dim polarRangeAreaSeriesView1 As DevExpress.XtraCharts.PolarRangeAreaSeriesView = New DevExpress.XtraCharts.PolarRangeAreaSeriesView()
            Dim circularSeriesLinearUnwindAnimation2 As DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation = New DevExpress.XtraCharts.CircularSeriesLinearUnwindAnimation()
            Dim circularMarkerSlideAnimation3 As DevExpress.XtraCharts.CircularMarkerSlideAnimation = New DevExpress.XtraCharts.CircularMarkerSlideAnimation()
            Dim chartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentPoint = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentLine = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentArea = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentScatterLine = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentRangeArea = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.spinEditAxisLabelAngle = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditMarkerSize = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditMarkerVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.comboBoxEditMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEditFunction = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditStartAngle = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditRotationDirection = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupMarker = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMarkerVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemKind = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemFunction = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupDiagram = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemStartAngle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemRotationDirection = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemStyle = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelPoint = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelPoint_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartPoint = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelLine = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelLine_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartLine = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelArea = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelArea_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartArea = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelScatterLine = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelScatterLine_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartScatterLine = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelRangeArea = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelRangeArea_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartRangeArea = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentScatterLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentRangeArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.spinEditAxisLabelAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditMarkerVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditMarkerKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditFunction.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditStartAngle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditRotationDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMarkerVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemKind), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemFunction), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupDiagram), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemStartAngle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemRotationDirection), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemStyle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelPoint.SuspendLayout()
            Me.dockPanelPoint_Container.SuspendLayout()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarPointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelLine.SuspendLayout()
            Me.dockPanelLine_Container.SuspendLayout()
            CType((Me.chartLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarLineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelArea.SuspendLayout()
            Me.dockPanelArea_Container.SuspendLayout()
            CType((Me.chartArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((sideBySideBarSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelScatterLine.SuspendLayout()
            Me.dockPanelScatterLine_Container.SuspendLayout()
            CType((Me.chartScatterLine), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarPointSeriesLabel4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((scatterPolarLineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelRangeArea.SuspendLayout()
            Me.dockPanelRangeArea_Container.SuspendLayout()
            CType((Me.chartRangeArea), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarDiagram3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((radarRangeAreaSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((polarRangeAreaSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 538)
            ' 
            ' documentGroup
            ' 
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentPoint, Me.documentLine, Me.documentArea, Me.documentScatterLine, Me.documentRangeArea})
            ' 
            ' documentPoint
            ' 
            Me.documentPoint.Caption = "Point"
            Me.documentPoint.ControlName = "dockPanelPoint"
            Me.documentPoint.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentPoint.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentPoint.ImageOptions.SvgImage = CType((resources.GetObject("documentPoint.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentPoint.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentPoint.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentPoint.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentPoint.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentLine
            ' 
            Me.documentLine.Caption = "Line"
            Me.documentLine.ControlName = "dockPanelLine"
            Me.documentLine.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentLine.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentLine.ImageOptions.SvgImage = CType((resources.GetObject("documentLine.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentLine.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentLine.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentLine.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentLine.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentArea
            ' 
            Me.documentArea.Caption = "Area"
            Me.documentArea.ControlName = "dockPanelArea"
            Me.documentArea.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentArea.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentArea.ImageOptions.SvgImage = CType((resources.GetObject("documentArea.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentArea.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentArea.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentArea.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentArea.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentScatterLine
            ' 
            Me.documentScatterLine.Caption = "Scatter Line"
            Me.documentScatterLine.ControlName = "dockPanelScatterLine"
            Me.documentScatterLine.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentScatterLine.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentScatterLine.ImageOptions.SvgImage = CType((resources.GetObject("documentScatterLine.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentScatterLine.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentScatterLine.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentScatterLine.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentScatterLine.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' documentRangeArea
            ' 
            Me.documentRangeArea.Caption = "Range Area"
            Me.documentRangeArea.ControlName = "dockPanelRangeArea"
            Me.documentRangeArea.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentRangeArea.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentRangeArea.ImageOptions.SvgImage = CType((resources.GetObject("documentRangeArea.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentRangeArea.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentRangeArea.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentRangeArea.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentRangeArea.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.spinEditAxisLabelAngle)
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditMarkerSize)
            Me.layoutControl.Controls.Add(Me.checkEditMarkerVisible)
            Me.layoutControl.Controls.Add(Me.comboBoxEditMarkerKind)
            Me.layoutControl.Controls.Add(Me.comboBoxEditFunction)
            Me.layoutControl.Controls.Add(Me.spinEditStartAngle)
            Me.layoutControl.Controls.Add(Me.comboBoxEditRotationDirection)
            Me.layoutControl.Controls.Add(Me.comboBoxStyle)
            Me.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(576, 500, 1004, 761)
            Me.layoutControl.Root = Me.layoutControlGroupRoot
            Me.layoutControl.Size = New System.Drawing.Size(241, 538)
            Me.layoutControl.TabIndex = 2
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' spinEditAxisLabelAngle
            ' 
            Me.spinEditAxisLabelAngle.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditAxisLabelAngle.Location = New System.Drawing.Point(116, 238)
            Me.spinEditAxisLabelAngle.Name = "spinEditAxisLabelAngle"
            Me.spinEditAxisLabelAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditAxisLabelAngle.Properties.DisplayFormat.FormatString = "0°"
            Me.spinEditAxisLabelAngle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditAxisLabelAngle.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditAxisLabelAngle.Properties.IsFloatValue = False
            Me.spinEditAxisLabelAngle.Properties.Mask.EditMask = "N00"
            Me.spinEditAxisLabelAngle.Properties.MaxValue = New Decimal(New Integer() {360, 0, 0, 0})
            Me.spinEditAxisLabelAngle.Properties.MinValue = New Decimal(New Integer() {360, 0, 0, -2147483648})
            Me.spinEditAxisLabelAngle.Size = New System.Drawing.Size(113, 20)
            Me.spinEditAxisLabelAngle.StyleController = Me.layoutControl
            Me.spinEditAxisLabelAngle.TabIndex = 18
            AddHandler Me.spinEditAxisLabelAngle.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditAxisLabelAngle_EditValueChanged)
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.EditValue = True
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 214)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Show Series Labels"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditMarkerSize
            ' 
            Me.spinEditMarkerSize.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditMarkerSize.Location = New System.Drawing.Point(116, 328)
            Me.spinEditMarkerSize.Name = "spinEditMarkerSize"
            Me.spinEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMarkerSize.Properties.IsFloatValue = False
            Me.spinEditMarkerSize.Properties.Mask.EditMask = "N00"
            Me.spinEditMarkerSize.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditMarkerSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMarkerSize.Size = New System.Drawing.Size(113, 20)
            Me.spinEditMarkerSize.StyleController = Me.layoutControl
            Me.spinEditMarkerSize.TabIndex = 8
            ' 
            ' checkEditMarkerVisible
            ' 
            Me.checkEditMarkerVisible.EditValue = True
            Me.checkEditMarkerVisible.Location = New System.Drawing.Point(12, 304)
            Me.checkEditMarkerVisible.Name = "checkEditMarkerVisible"
            Me.checkEditMarkerVisible.Properties.Caption = "Visible"
            Me.checkEditMarkerVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditMarkerVisible.StyleController = Me.layoutControl
            Me.checkEditMarkerVisible.TabIndex = 6
            AddHandler Me.checkEditMarkerVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditMarkerVisible_CheckedChanged)
            ' 
            ' comboBoxEditMarkerKind
            ' 
            Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(116, 352)
            Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
            Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(113, 20)
            Me.comboBoxEditMarkerKind.StyleController = Me.layoutControl
            Me.comboBoxEditMarkerKind.TabIndex = 5
            ' 
            ' comboBoxEditFunction
            ' 
            Me.comboBoxEditFunction.Location = New System.Drawing.Point(116, 34)
            Me.comboBoxEditFunction.Name = "comboBoxEditFunction"
            Me.comboBoxEditFunction.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditFunction.Properties.Items.AddRange(New Object() {"Archimedean Spiral", "Cardioid", "Cartesian Folium"})
            Me.comboBoxEditFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditFunction.Size = New System.Drawing.Size(113, 20)
            Me.comboBoxEditFunction.StyleController = Me.layoutControl
            Me.comboBoxEditFunction.TabIndex = 13
            AddHandler Me.comboBoxEditFunction.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditFunction_SelectedIndexChanged)
            ' 
            ' spinEditStartAngle
            ' 
            Me.spinEditStartAngle.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.spinEditStartAngle.Location = New System.Drawing.Point(116, 148)
            Me.spinEditStartAngle.Name = "spinEditStartAngle"
            Me.spinEditStartAngle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditStartAngle.Properties.DisplayFormat.FormatString = "0°"
            Me.spinEditStartAngle.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditStartAngle.Properties.Increment = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditStartAngle.Properties.IsFloatValue = False
            Me.spinEditStartAngle.Properties.Mask.EditMask = "N00"
            Me.spinEditStartAngle.Properties.MaxValue = New Decimal(New Integer() {360, 0, 0, 0})
            Me.spinEditStartAngle.Size = New System.Drawing.Size(113, 20)
            Me.spinEditStartAngle.StyleController = Me.layoutControl
            Me.spinEditStartAngle.TabIndex = 17
            AddHandler Me.spinEditStartAngle.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditStartAngle_EditValueChanged)
            ' 
            ' comboBoxEditRotationDirection
            ' 
            Me.comboBoxEditRotationDirection.EditValue = "Counterclockwise"
            Me.comboBoxEditRotationDirection.Location = New System.Drawing.Point(116, 124)
            Me.comboBoxEditRotationDirection.Name = "comboBoxEditRotationDirection"
            Me.comboBoxEditRotationDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditRotationDirection.Properties.Items.AddRange(New Object() {"Counterclockwise", "Clockwise"})
            Me.comboBoxEditRotationDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditRotationDirection.Size = New System.Drawing.Size(113, 20)
            Me.comboBoxEditRotationDirection.StyleController = Me.layoutControl
            Me.comboBoxEditRotationDirection.TabIndex = 16
            AddHandler Me.comboBoxEditRotationDirection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditRotationDirection_SelectedIndexChanged)
            ' 
            ' comboBoxStyle
            ' 
            Me.comboBoxStyle.EditValue = "Polygon"
            Me.comboBoxStyle.Location = New System.Drawing.Point(116, 100)
            Me.comboBoxStyle.Name = "comboBoxStyle"
            Me.comboBoxStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxStyle.Properties.Items.AddRange(New Object() {"Circle", "Polygon"})
            Me.comboBoxStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxStyle.Size = New System.Drawing.Size(113, 20)
            Me.comboBoxStyle.StyleController = Me.layoutControl
            Me.comboBoxStyle.TabIndex = 14
            AddHandler Me.comboBoxStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditStyle_SelectedIndexChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupLabel, Me.layoutControlGroupMarker, Me.layoutControlGroupGeneral, Me.emptySpaceItem, Me.layoutControlGroupDiagram})
            Me.layoutControlGroupRoot.Name = "Root"
            Me.layoutControlGroupRoot.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 538)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.CustomizationFormText = "Label"
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItem1})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 180)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
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
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.spinEditAxisLabelAngle
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItemAxisLabelAngle"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItem1.Text = "Y-Axis Label Angle:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlGroupMarker
            ' 
            Me.layoutControlGroupMarker.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupMarker.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupMarker.CustomizationFormText = "Marker"
            Me.layoutControlGroupMarker.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMarker.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSize, Me.layoutControlItemMarkerVisible, Me.layoutControlItemKind})
            Me.layoutControlGroupMarker.Location = New System.Drawing.Point(0, 270)
            Me.layoutControlGroupMarker.Name = "layoutControlGroupMarker"
            Me.layoutControlGroupMarker.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupMarker.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMarker.Text = "Marker"
            ' 
            ' layoutControlItemSize
            ' 
            Me.layoutControlItemSize.Control = Me.spinEditMarkerSize
            Me.layoutControlItemSize.CustomizationFormText = "Size:"
            Me.layoutControlItemSize.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemSize.Name = "layoutControlItemSize"
            Me.layoutControlItemSize.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemSize.Text = "Size:"
            Me.layoutControlItemSize.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemMarkerVisible
            ' 
            Me.layoutControlItemMarkerVisible.Control = Me.checkEditMarkerVisible
            Me.layoutControlItemMarkerVisible.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItemMarkerVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemMarkerVisible.Name = "layoutControlItemMarkerVisible"
            Me.layoutControlItemMarkerVisible.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMarkerVisible.TextVisible = False
            ' 
            ' layoutControlItemKind
            ' 
            Me.layoutControlItemKind.Control = Me.comboBoxEditMarkerKind
            Me.layoutControlItemKind.CustomizationFormText = "Kind:"
            Me.layoutControlItemKind.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemKind.Name = "layoutControlItemKind"
            Me.layoutControlItemKind.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemKind.Text = "Kind:"
            Me.layoutControlItemKind.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemFunction})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 66)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemFunction
            ' 
            Me.layoutControlItemFunction.Control = Me.comboBoxEditFunction
            Me.layoutControlItemFunction.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemFunction.Name = "layoutControlItemFunction"
            Me.layoutControlItemFunction.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemFunction.Text = "Function:"
            Me.layoutControlItemFunction.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 384)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 154)
            ' 
            ' layoutControlGroupDiagram
            ' 
            Me.layoutControlGroupDiagram.CustomizationFormText = "Diagram"
            Me.layoutControlGroupDiagram.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupDiagram.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemStartAngle, Me.layoutControlItemRotationDirection, Me.layoutControlItemStyle})
            Me.layoutControlGroupDiagram.Location = New System.Drawing.Point(0, 66)
            Me.layoutControlGroupDiagram.Name = "layoutControlGroupDiagram"
            Me.layoutControlGroupDiagram.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupDiagram.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupDiagram.Text = "Diagram"
            ' 
            ' layoutControlItemStartAngle
            ' 
            Me.layoutControlItemStartAngle.Control = Me.spinEditStartAngle
            Me.layoutControlItemStartAngle.CustomizationFormText = "Start Angle In Degrees"
            Me.layoutControlItemStartAngle.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemStartAngle.Name = "layoutControlItemStartAngle"
            Me.layoutControlItemStartAngle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemStartAngle.Text = "Start Angle:"
            Me.layoutControlItemStartAngle.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemRotationDirection
            ' 
            Me.layoutControlItemRotationDirection.Control = Me.comboBoxEditRotationDirection
            Me.layoutControlItemRotationDirection.CustomizationFormText = "Rotation Direction"
            Me.layoutControlItemRotationDirection.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemRotationDirection.Name = "layoutControlItemRotationDirection"
            Me.layoutControlItemRotationDirection.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemRotationDirection.Text = "Rotation Direction:"
            Me.layoutControlItemRotationDirection.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' layoutControlItemStyle
            ' 
            Me.layoutControlItemStyle.Control = Me.comboBoxStyle
            Me.layoutControlItemStyle.CustomizationFormText = "Diagram Type:"
            Me.layoutControlItemStyle.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemStyle.Name = "layoutControlItemStyle"
            Me.layoutControlItemStyle.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemStyle.Text = "Style:"
            Me.layoutControlItemStyle.TextSize = New System.Drawing.Size(92, 13)
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowAutoHideButton = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.DockingOptions.ShowMaximizeButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelPoint, Me.dockPanelLine, Me.dockPanelArea, Me.dockPanelScatterLine, Me.dockPanelRangeArea})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelPoint
            ' 
            Me.dockPanelPoint.Controls.Add(Me.dockPanelPoint_Container)
            Me.dockPanelPoint.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelPoint.DockedAsTabbedDocument = True
            Me.dockPanelPoint.ID = New System.Guid("8e284b0c-614a-4ba6-a5df-95caa40e3055")
            Me.dockPanelPoint.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPoint.Name = "dockPanelPoint"
            Me.dockPanelPoint.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelPoint.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelPoint.Text = "Point"
            ' 
            ' dockPanelPoint_Container
            ' 
            Me.dockPanelPoint_Container.Controls.Add(Me.chartPoint)
            Me.dockPanelPoint_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPoint_Container.Name = "dockPanelPoint_Container"
            Me.dockPanelPoint_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelPoint_Container.TabIndex = 0
            ' 
            ' chartPoint
            ' 
            Me.chartPoint.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPoint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPoint.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartPoint.Legend.Name = "Default Legend"
            Me.chartPoint.Location = New System.Drawing.Point(0, 0)
            Me.chartPoint.Name = "chartPoint"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            radarPointSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarPointSeriesLabel1.TextPattern = "{V:N2}"
            series1.Label = radarPointSeriesLabel1
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series1.Name = "Function"
            series1.SeriesID = 0
            series1.ToolTipPointPattern = "{A}: {V:F2}"
            circularMarkerSlideAnimation1.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
            polarPointSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation1
            series1.View = polarPointSeriesView1
            Me.chartPoint.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1}
            sideBySideBarSeriesLabel1.TextPattern = "{V:y}"
            Me.chartPoint.SeriesTemplate.Label = sideBySideBarSeriesLabel1
            Me.chartPoint.Size = New System.Drawing.Size(788, 548)
            Me.chartPoint.TabIndex = 1
            Me.chartPoint.TabStop = False
            chartTitle1.Text = "Function in Polar Coordinates"
            chartTitle1.TitleID = 0
            chartTitle2.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle2.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle2.Text = ""
            chartTitle2.TextColor = System.Drawing.Color.Gray
            chartTitle2.TitleID = 1
            Me.chartPoint.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1, chartTitle2})
            ' 
            ' dockPanelLine
            ' 
            Me.dockPanelLine.Controls.Add(Me.dockPanelLine_Container)
            Me.dockPanelLine.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelLine.DockedAsTabbedDocument = True
            Me.dockPanelLine.ID = New System.Guid("2538843f-46dc-461f-9d4f-0a80098cad41")
            Me.dockPanelLine.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLine.Name = "dockPanelLine"
            Me.dockPanelLine.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelLine.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelLine.Text = "Line"
            ' 
            ' dockPanelLine_Container
            ' 
            Me.dockPanelLine_Container.Controls.Add(Me.chartLine)
            Me.dockPanelLine_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelLine_Container.Name = "dockPanelLine_Container"
            Me.dockPanelLine_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelLine_Container.TabIndex = 0
            ' 
            ' chartLine
            ' 
            Me.chartLine.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartLine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartLine.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartLine.Legend.Name = "Default Legend"
            Me.chartLine.Location = New System.Drawing.Point(0, 0)
            Me.chartLine.Name = "chartLine"
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            radarPointSeriesLabel2.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarPointSeriesLabel2.TextPattern = "{V:N2}"
            series2.Label = radarPointSeriesLabel2
            series2.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series2.Name = "Function"
            series2.SeriesID = 0
            series2.ToolTipPointPattern = "{A}: {V:F2}"
            polarLineSeriesView1.LineMarkerOptions.Size = 8
            polarLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            polarLineSeriesView1.SeriesAnimation = circularSeriesUnwindFromCenterAnimation1
            circularMarkerWidenAnimation1.BeginTime = System.TimeSpan.Parse("00:00:00.6000000")
            polarLineSeriesView1.SeriesPointAnimation = circularMarkerWidenAnimation1
            series2.View = polarLineSeriesView1
            Me.chartLine.SeriesSerializable = New DevExpress.XtraCharts.Series() {series2}
            sideBySideBarSeriesLabel2.TextPattern = "{V:y}"
            Me.chartLine.SeriesTemplate.Label = sideBySideBarSeriesLabel2
            Me.chartLine.Size = New System.Drawing.Size(788, 548)
            Me.chartLine.TabIndex = 1
            Me.chartLine.TabStop = False
            chartTitle3.Text = "Function in Polar Coordinates"
            chartTitle3.TitleID = 0
            chartTitle4.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle4.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle4.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle4.Text = ""
            chartTitle4.TextColor = System.Drawing.Color.Gray
            chartTitle4.TitleID = 1
            Me.chartLine.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle3, chartTitle4})
            ' 
            ' dockPanelArea
            ' 
            Me.dockPanelArea.Controls.Add(Me.dockPanelArea_Container)
            Me.dockPanelArea.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelArea.DockedAsTabbedDocument = True
            Me.dockPanelArea.ID = New System.Guid("e4e75fa6-253d-4606-926a-618ce80bfe99")
            Me.dockPanelArea.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelArea.Name = "dockPanelArea"
            Me.dockPanelArea.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelArea.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelArea.Text = "Area"
            ' 
            ' dockPanelArea_Container
            ' 
            Me.dockPanelArea_Container.Controls.Add(Me.chartArea)
            Me.dockPanelArea_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelArea_Container.Name = "dockPanelArea_Container"
            Me.dockPanelArea_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelArea_Container.TabIndex = 0
            ' 
            ' chartArea
            ' 
            Me.chartArea.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            polarDiagram1.AxisX.WholeRange.AutoSideMargins = False
            polarDiagram1.AxisX.WholeRange.EndSideMargin = 0R
            polarDiagram1.AxisX.WholeRange.StartSideMargin = 0R
            Me.chartArea.Diagram = polarDiagram1
            Me.chartArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartArea.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartArea.Legend.Name = "Default Legend"
            Me.chartArea.Location = New System.Drawing.Point(0, 0)
            Me.chartArea.Name = "chartArea"
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            radarPointSeriesLabel3.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarPointSeriesLabel3.TextPattern = "{V:N2}"
            series3.Label = radarPointSeriesLabel3
            series3.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series3.Name = "Function"
            series3.SeriesID = 0
            series3.ToolTipPointPattern = "{A}: {V:F2}"
            polarAreaSeriesView1.MarkerOptions.Size = 8
            polarAreaSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            circularSeriesLinearUnwindAnimation1.Direction = DevExpress.XtraCharts.AnimationDirection.FromTop
            polarAreaSeriesView1.SeriesAnimation = circularSeriesLinearUnwindAnimation1
            circularMarkerSlideAnimation2.BeginTime = System.TimeSpan.Parse("00:00:00.6000000")
            circularMarkerSlideAnimation2.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
            circularMarkerSlideAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.0100000")
            polarAreaSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation2
            series3.View = polarAreaSeriesView1
            Me.chartArea.SeriesSerializable = New DevExpress.XtraCharts.Series() {series3}
            sideBySideBarSeriesLabel3.TextPattern = "{V:y}"
            Me.chartArea.SeriesTemplate.Label = sideBySideBarSeriesLabel3
            Me.chartArea.Size = New System.Drawing.Size(788, 548)
            Me.chartArea.TabIndex = 1
            Me.chartArea.TabStop = False
            chartTitle5.Text = "Function in Polar Coordinates"
            chartTitle5.TitleID = 0
            chartTitle6.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle6.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle6.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle6.Text = ""
            chartTitle6.TextColor = System.Drawing.Color.Gray
            chartTitle6.TitleID = 1
            Me.chartArea.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle5, chartTitle6})
            ' 
            ' dockPanelScatterLine
            ' 
            Me.dockPanelScatterLine.Controls.Add(Me.dockPanelScatterLine_Container)
            Me.dockPanelScatterLine.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelScatterLine.DockedAsTabbedDocument = True
            Me.dockPanelScatterLine.ID = New System.Guid("99377c1d-0cb9-43c6-afe4-ac2ad33c1a66")
            Me.dockPanelScatterLine.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelScatterLine.Name = "dockPanelScatterLine"
            Me.dockPanelScatterLine.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelScatterLine.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelScatterLine.Text = "Scatter Line"
            ' 
            ' dockPanelScatterLine_Container
            ' 
            Me.dockPanelScatterLine_Container.Controls.Add(Me.chartScatterLine)
            Me.dockPanelScatterLine_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelScatterLine_Container.Name = "dockPanelScatterLine_Container"
            Me.dockPanelScatterLine_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelScatterLine_Container.TabIndex = 0
            ' 
            ' chartScatterLine
            ' 
            Me.chartScatterLine.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            polarDiagram2.AxisX.GridLines.MinorVisible = True
            polarDiagram2.AxisY.GridLines.MinorVisible = True
            Me.chartScatterLine.Diagram = polarDiagram2
            Me.chartScatterLine.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartScatterLine.Legend.Name = "Default Legend"
            Me.chartScatterLine.Legend.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartScatterLine.Location = New System.Drawing.Point(0, 0)
            Me.chartScatterLine.Name = "chartScatterLine"
            series4.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            radarPointSeriesLabel4.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarPointSeriesLabel4.TextPattern = "{V:N2}"
            series4.Label = radarPointSeriesLabel4
            series4.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[False]
            series4.Name = "Function"
            series4.SeriesID = 0
            series4.ToolTipPointPattern = "{A}: {V:N2}"
            scatterPolarLineSeriesView1.Closed = False
            scatterPolarLineSeriesView1.LineMarkerOptions.Size = 8
            scatterPolarLineSeriesView1.MarkerVisibility = DevExpress.Utils.DefaultBoolean.[True]
            circularSeriesUnwindFromCenterAnimation2.Duration = System.TimeSpan.Parse("00:00:01.6000000")
            circularSeriesUnwindFromCenterAnimation2.EasingFunction = linearEasingFunction1
            scatterPolarLineSeriesView1.SeriesAnimation = circularSeriesUnwindFromCenterAnimation2
            circularMarkerWidenAnimation2.BeginTime = System.TimeSpan.Parse("00:00:01")
            circularMarkerWidenAnimation2.PointDelay = System.TimeSpan.Parse("00:00:00.0050000")
            scatterPolarLineSeriesView1.SeriesPointAnimation = circularMarkerWidenAnimation2
            series4.View = scatterPolarLineSeriesView1
            Me.chartScatterLine.SeriesSerializable = New DevExpress.XtraCharts.Series() {series4}
            Me.chartScatterLine.Size = New System.Drawing.Size(788, 548)
            Me.chartScatterLine.TabIndex = 1
            Me.chartScatterLine.TabStop = False
            chartTitle7.Text = "Function in Polar Coordinates"
            chartTitle7.TitleID = 0
            chartTitle8.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle8.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle8.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle8.Text = ""
            chartTitle8.TextColor = System.Drawing.Color.Gray
            chartTitle8.TitleID = 1
            Me.chartScatterLine.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle7, chartTitle8})
            ' 
            ' dockPanelRangeArea
            ' 
            Me.dockPanelRangeArea.Controls.Add(Me.dockPanelRangeArea_Container)
            Me.dockPanelRangeArea.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelRangeArea.DockedAsTabbedDocument = True
            Me.dockPanelRangeArea.ID = New System.Guid("217a7578-62e0-497e-b182-dea9363e194e")
            Me.dockPanelRangeArea.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelRangeArea.Name = "dockPanelRangeArea"
            Me.dockPanelRangeArea.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelRangeArea.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelRangeArea.Text = "Range Area"
            ' 
            ' dockPanelRangeArea_Container
            ' 
            Me.dockPanelRangeArea_Container.Controls.Add(Me.chartRangeArea)
            Me.dockPanelRangeArea_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelRangeArea_Container.Name = "dockPanelRangeArea_Container"
            Me.dockPanelRangeArea_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelRangeArea_Container.TabIndex = 0
            ' 
            ' chartRangeArea
            ' 
            Me.chartRangeArea.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            polarDiagram3.AxisX.WholeRange.AutoSideMargins = False
            polarDiagram3.AxisX.WholeRange.EndSideMargin = 0R
            polarDiagram3.AxisX.WholeRange.StartSideMargin = 0R
            Me.chartRangeArea.Diagram = polarDiagram3
            Me.chartRangeArea.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartRangeArea.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartRangeArea.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
            Me.chartRangeArea.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartRangeArea.Legend.Name = "Default Legend"
            Me.chartRangeArea.Location = New System.Drawing.Point(0, 0)
            Me.chartRangeArea.Name = "chartRangeArea"
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            radarRangeAreaSeriesLabel1.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.HideOverlapped
            radarRangeAreaSeriesLabel1.TextPattern = "{V:F}"
            series5.Label = radarRangeAreaSeriesLabel1
            series5.Name = "Function"
            series5.SeriesID = 0
            series5.ToolTipPointPattern = "{A}: {V:F2}"
            polarRangeAreaSeriesView1.Marker1Visibility = DevExpress.Utils.DefaultBoolean.[True]
            polarRangeAreaSeriesView1.Marker2Visibility = DevExpress.Utils.DefaultBoolean.[True]
            polarRangeAreaSeriesView1.SeriesAnimation = circularSeriesLinearUnwindAnimation2
            circularMarkerSlideAnimation3.BeginTime = System.TimeSpan.Parse("00:00:00.4000000")
            circularMarkerSlideAnimation3.Direction = DevExpress.XtraCharts.CircularMarkerAnimationDirection.FromCenter
            circularMarkerSlideAnimation3.Duration = System.TimeSpan.Parse("00:00:00.8000000")
            polarRangeAreaSeriesView1.SeriesPointAnimation = circularMarkerSlideAnimation3
            series5.View = polarRangeAreaSeriesView1
            Me.chartRangeArea.SeriesSerializable = New DevExpress.XtraCharts.Series() {series5}
            Me.chartRangeArea.Size = New System.Drawing.Size(788, 548)
            Me.chartRangeArea.TabIndex = 2
            Me.chartRangeArea.TabStop = False
            chartTitle9.Text = "Function in Polar Coordinates"
            chartTitle9.TitleID = 0
            Me.chartRangeArea.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle9})
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
            Me.currentTabbedView.DocumentProperties.AllowClose = False
            Me.currentTabbedView.DocumentProperties.AllowDock = False
            Me.currentTabbedView.DocumentProperties.AllowDockFill = False
            Me.currentTabbedView.DocumentProperties.AllowFloat = False
            Me.currentTabbedView.DocumentProperties.AllowFloatOnDoubleClick = False
            Me.currentTabbedView.DocumentProperties.AllowTabReordering = False
            Me.currentTabbedView.DocumentProperties.ShowPinButton = False
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentPoint, Me.documentLine, Me.documentArea, Me.documentScatterLine, Me.documentRangeArea})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' PolarViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PolarViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentPoint), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentScatterLine), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentRangeArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.spinEditAxisLabelAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditMarkerVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditMarkerKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditFunction.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditStartAngle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditRotationDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMarkerVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemKind), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemFunction), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupDiagram), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemStartAngle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemRotationDirection), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemStyle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelPoint.ResumeLayout(False)
            Me.dockPanelPoint_Container.ResumeLayout(False)
            CType((radarPointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((polarPointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelLine.ResumeLayout(False)
            Me.dockPanelLine_Container.ResumeLayout(False)
            CType((radarPointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((polarLineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartLine), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelArea.ResumeLayout(False)
            Me.dockPanelArea_Container.ResumeLayout(False)
            CType((polarDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarPointSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((polarAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((sideBySideBarSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartArea), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelScatterLine.ResumeLayout(False)
            Me.dockPanelScatterLine_Container.ResumeLayout(False)
            CType((polarDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarPointSeriesLabel4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((scatterPolarLineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartScatterLine), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelRangeArea.ResumeLayout(False)
            Me.dockPanelRangeArea_Container.ResumeLayout(False)
            CType((polarDiagram3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((radarRangeAreaSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((polarRangeAreaSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartRangeArea), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private spinEditMarkerSize As DevExpress.XtraEditors.SpinEdit

        Private checkEditMarkerVisible As DevExpress.XtraEditors.CheckEdit

        Private comboBoxEditMarkerKind As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxEditFunction As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupMarker As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemSize As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMarkerVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemKind As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemFunction As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelPoint As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelPoint_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelLine As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelLine_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelArea As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelArea_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelScatterLine As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelScatterLine_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelRangeArea As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelRangeArea_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentPoint As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentLine As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentArea As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentScatterLine As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentRangeArea As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartPoint As DevExpress.XtraCharts.ChartControl

        Private chartLine As DevExpress.XtraCharts.ChartControl

        Private chartArea As DevExpress.XtraCharts.ChartControl

        Private chartScatterLine As DevExpress.XtraCharts.ChartControl

        Private chartRangeArea As DevExpress.XtraCharts.ChartControl

        Private spinEditStartAngle As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditRotationDirection As DevExpress.XtraEditors.ComboBoxEdit

        Private comboBoxStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupDiagram As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemStartAngle As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemRotationDirection As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemStyle As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditAxisLabelAngle As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
