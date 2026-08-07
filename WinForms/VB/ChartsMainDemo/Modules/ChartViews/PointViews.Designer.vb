Namespace DevExpress.XtraCharts.Demos

    Partial Class PointViewsDemo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.PointViewsDemo))
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView1 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView2 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series3 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView3 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series4 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesView4 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim chartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram2 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series5 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim bubbleSeriesLabel1 As DevExpress.XtraCharts.BubbleSeriesLabel = New DevExpress.XtraCharts.BubbleSeriesLabel()
            Dim bubbleSeriesView1 As DevExpress.XtraCharts.BubbleSeriesView = New DevExpress.XtraCharts.BubbleSeriesView()
            Dim bubbleSeriesLabel2 As DevExpress.XtraCharts.BubbleSeriesLabel = New DevExpress.XtraCharts.BubbleSeriesLabel()
            Dim bubbleSeriesView2 As DevExpress.XtraCharts.BubbleSeriesView = New DevExpress.XtraCharts.BubbleSeriesView()
            Dim chartTitle2 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle3 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.documentPoint = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentBubble = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.checkEditLabelVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.spinEditMarkerSize = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditMarkerKind = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditTransparency = New DevExpress.XtraEditors.SpinEdit()
            Me.comboBoxEditLabelPosition = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.spinEditMaxBubbleSize = New DevExpress.XtraEditors.SpinEdit()
            Me.spinEditMinBubbleSize = New DevExpress.XtraEditors.SpinEdit()
            Me.tbcPointCount = New DevExpress.XtraEditors.TrackBarControl()
            Me.layoutControlGroupRoot = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroupLabel = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemLabelVisible = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemPosition = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupMarker = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemKind = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemTransparency = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMaxBubbleSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMinBubbleSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroupPointCount = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemPointCount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager(Me.components)
            Me.dockPanelPoint = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelPoint_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartPoint = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelBubble = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelBubble_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartBubble = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.sidePanelOptions.SuspendLayout()
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tabPaneOptions.SuspendLayout()
            Me.tabNavigationPageOptions.SuspendLayout()
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentBubble), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditMarkerKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditTransparency.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEditLabelPosition.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMaxBubbleSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditMinBubbleSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbcPointCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tbcPointCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPosition), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemKind), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTransparency), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMaxBubbleSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMinBubbleSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupPointCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemPointCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelPoint.SuspendLayout()
            Me.dockPanelPoint_Container.SuspendLayout()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelBubble.SuspendLayout()
            Me.dockPanelBubble_Container.SuspendLayout()
            CType((Me.chartBubble), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.documentGroup.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() {Me.documentPoint, Me.documentBubble})
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
            ' documentBubble
            ' 
            Me.documentBubble.Caption = "Bubble"
            Me.documentBubble.ControlName = "dockPanelBubble"
            Me.documentBubble.FloatLocation = New System.Drawing.Point(0, 0)
            Me.documentBubble.FloatSize = New System.Drawing.Size(200, 200)
            Me.documentBubble.ImageOptions.SvgImage = CType((resources.GetObject("documentBubble.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.documentBubble.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.documentBubble.Properties.AllowClose = DevExpress.Utils.DefaultBoolean.[False]
            Me.documentBubble.Properties.AllowFloat = DevExpress.Utils.DefaultBoolean.[True]
            Me.documentBubble.Properties.AllowFloatOnDoubleClick = DevExpress.Utils.DefaultBoolean.[False]
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.checkEditLabelVisible)
            Me.layoutControl.Controls.Add(Me.spinEditMarkerSize)
            Me.layoutControl.Controls.Add(Me.comboBoxEditMarkerKind)
            Me.layoutControl.Controls.Add(Me.spinEditTransparency)
            Me.layoutControl.Controls.Add(Me.comboBoxEditLabelPosition)
            Me.layoutControl.Controls.Add(Me.spinEditMaxBubbleSize)
            Me.layoutControl.Controls.Add(Me.spinEditMinBubbleSize)
            Me.layoutControl.Controls.Add(Me.tbcPointCount)
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
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 148)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 20)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditMarkerSize
            ' 
            Me.spinEditMarkerSize.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditMarkerSize.Location = New System.Drawing.Point(105, 238)
            Me.spinEditMarkerSize.Name = "spinEditMarkerSize"
            Me.spinEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMarkerSize.Properties.IsFloatValue = False
            Me.spinEditMarkerSize.Properties.Mask.EditMask = "N00"
            Me.spinEditMarkerSize.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditMarkerSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMarkerSize.Size = New System.Drawing.Size(124, 20)
            Me.spinEditMarkerSize.StyleController = Me.layoutControl
            Me.spinEditMarkerSize.TabIndex = 8
            ' 
            ' comboBoxEditMarkerKind
            ' 
            Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(105, 262)
            Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
            Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(124, 20)
            Me.comboBoxEditMarkerKind.StyleController = Me.layoutControl
            Me.comboBoxEditMarkerKind.TabIndex = 5
            ' 
            ' spinEditTransparency
            ' 
            Me.spinEditTransparency.EditValue = New Decimal(New Integer() {135, 0, 0, 0})
            Me.spinEditTransparency.Location = New System.Drawing.Point(105, 34)
            Me.spinEditTransparency.Name = "spinEditTransparency"
            Me.spinEditTransparency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditTransparency.Properties.IsFloatValue = False
            Me.spinEditTransparency.Properties.Mask.EditMask = "N00"
            Me.spinEditTransparency.Properties.MaxValue = New Decimal(New Integer() {255, 0, 0, 0})
            Me.spinEditTransparency.Size = New System.Drawing.Size(124, 20)
            Me.spinEditTransparency.StyleController = Me.layoutControl
            Me.spinEditTransparency.TabIndex = 9
            AddHandler Me.spinEditTransparency.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditTransparencyEditValueChanged)
            ' 
            ' comboBoxEditLabelPosition
            ' 
            Me.comboBoxEditLabelPosition.EditValue = "Center"
            Me.comboBoxEditLabelPosition.Location = New System.Drawing.Point(105, 172)
            Me.comboBoxEditLabelPosition.Name = "comboBoxEditLabelPosition"
            Me.comboBoxEditLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditLabelPosition.Properties.Items.AddRange(New Object() {"Center", "Outside"})
            Me.comboBoxEditLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditLabelPosition.Size = New System.Drawing.Size(124, 20)
            Me.comboBoxEditLabelPosition.StyleController = Me.layoutControl
            Me.comboBoxEditLabelPosition.TabIndex = 10
            AddHandler Me.comboBoxEditLabelPosition.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditLabelPosition_SelectedIndexChanged)
            ' 
            ' spinEditMaxBubbleSize
            ' 
            Me.spinEditMaxBubbleSize.EditValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMaxBubbleSize.Location = New System.Drawing.Point(105, 58)
            Me.spinEditMaxBubbleSize.Name = "spinEditMaxBubbleSize"
            Me.spinEditMaxBubbleSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMaxBubbleSize.Properties.DisplayFormat.FormatString = "0  X-axis\'s tickmarks distances"
            Me.spinEditMaxBubbleSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMaxBubbleSize.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMaxBubbleSize.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditMaxBubbleSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMaxBubbleSize.Size = New System.Drawing.Size(124, 20)
            Me.spinEditMaxBubbleSize.StyleController = Me.layoutControl
            Me.spinEditMaxBubbleSize.TabIndex = 11
            Me.spinEditMaxBubbleSize.ToolTip = "X-axis's tickmarks distances"
            AddHandler Me.spinEditMaxBubbleSize.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditMaxBubbleSize_EditValueChanged)
            AddHandler Me.spinEditMaxBubbleSize.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.spinEditMaxBubbleSize_EditValueChanging)
            ' 
            ' spinEditMinBubbleSize
            ' 
            Me.spinEditMinBubbleSize.EditValue = New Decimal(New Integer() {8, 0, 0, 65536})
            Me.spinEditMinBubbleSize.Location = New System.Drawing.Point(105, 82)
            Me.spinEditMinBubbleSize.Name = "spinEditMinBubbleSize"
            Me.spinEditMinBubbleSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMinBubbleSize.Properties.DisplayFormat.FormatString = "0  X-axis\'s tickmarks distances"
            Me.spinEditMinBubbleSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMinBubbleSize.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMinBubbleSize.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditMinBubbleSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMinBubbleSize.Size = New System.Drawing.Size(124, 20)
            Me.spinEditMinBubbleSize.StyleController = Me.layoutControl
            Me.spinEditMinBubbleSize.TabIndex = 12
            Me.spinEditMinBubbleSize.ToolTip = "X-axis's tickmarks distances"
            AddHandler Me.spinEditMinBubbleSize.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditMinBubbleSize_EditValueChanged)
            AddHandler Me.spinEditMinBubbleSize.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.spinEditMinBubbleSize_EditValueChanging)
            ' 
            ' tbcPointCount
            ' 
            Me.tbcPointCount.EditValue = 3000
            Me.tbcPointCount.Location = New System.Drawing.Point(12, 328)
            Me.tbcPointCount.Name = "tbcPointCount"
            Me.tbcPointCount.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Buffered
            Me.tbcPointCount.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.tbcPointCount.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            trackBarLabel1.Label = "30K"
            trackBarLabel1.Value = 30000
            trackBarLabel2.Label = "15K"
            trackBarLabel2.Value = 15000
            trackBarLabel3.Label = "3K"
            trackBarLabel3.Value = 3000
            Me.tbcPointCount.Properties.Labels.AddRange(New DevExpress.XtraEditors.Repository.TrackBarLabel() {trackBarLabel1, trackBarLabel2, trackBarLabel3})
            Me.tbcPointCount.Properties.LargeChange = 1000
            Me.tbcPointCount.Properties.Maximum = 30000
            Me.tbcPointCount.Properties.Minimum = 3000
            Me.tbcPointCount.Properties.ShowLabels = True
            Me.tbcPointCount.Properties.ShowValueToolTip = True
            Me.tbcPointCount.Properties.SmallChange = 500
            Me.tbcPointCount.Properties.TickFrequency = 1000
            Me.tbcPointCount.Size = New System.Drawing.Size(217, 72)
            Me.tbcPointCount.StyleController = Me.layoutControl
            Me.tbcPointCount.TabIndex = 13
            Me.tbcPointCount.Value = 3000
            AddHandler Me.tbcPointCount.EditValueChanged, New System.EventHandler(AddressOf Me.tbcPointCount_EditValueChanged)
            ' 
            ' layoutControlGroupRoot
            ' 
            Me.layoutControlGroupRoot.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroupRoot.GroupBordersVisible = False
            Me.layoutControlGroupRoot.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroupLabel, Me.layoutControlGroupMarker, Me.layoutControlGroupGeneral, Me.emptySpaceItem, Me.layoutControlGroupPointCount})
            Me.layoutControlGroupRoot.Name = "layoutControlGroupRoot"
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
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemPosition})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 114)
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
            ' layoutControlItemPosition
            ' 
            Me.layoutControlItemPosition.Control = Me.comboBoxEditLabelPosition
            Me.layoutControlItemPosition.Enabled = False
            Me.layoutControlItemPosition.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemPosition.Name = "layoutControlItemPosition"
            Me.layoutControlItemPosition.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemPosition.Text = "Position"
            Me.layoutControlItemPosition.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlGroupMarker
            ' 
            Me.layoutControlGroupMarker.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupMarker.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupMarker.CustomizationFormText = "Marker"
            Me.layoutControlGroupMarker.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupMarker.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemSize, Me.layoutControlItemKind})
            Me.layoutControlGroupMarker.Location = New System.Drawing.Point(0, 204)
            Me.layoutControlGroupMarker.Name = "layoutControlGroupMarker"
            Me.layoutControlGroupMarker.Size = New System.Drawing.Size(241, 90)
            Me.layoutControlGroupMarker.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupMarker.Text = "Marker"
            ' 
            ' layoutControlItemSize
            ' 
            Me.layoutControlItemSize.Control = Me.spinEditMarkerSize
            Me.layoutControlItemSize.CustomizationFormText = "Size:"
            Me.layoutControlItemSize.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemSize.Name = "layoutControlItemSize"
            Me.layoutControlItemSize.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemSize.Text = "Size:"
            Me.layoutControlItemSize.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItemKind
            ' 
            Me.layoutControlItemKind.Control = Me.comboBoxEditMarkerKind
            Me.layoutControlItemKind.CustomizationFormText = "Kind:"
            Me.layoutControlItemKind.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemKind.Name = "layoutControlItemKind"
            Me.layoutControlItemKind.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemKind.Text = "Kind:"
            Me.layoutControlItemKind.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemTransparency, Me.layoutControlItemMaxBubbleSize, Me.layoutControlItemMinBubbleSize})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 114)
            Me.layoutControlGroupGeneral.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupGeneral.Text = "General"
            ' 
            ' layoutControlItemTransparency
            ' 
            Me.layoutControlItemTransparency.Control = Me.spinEditTransparency
            Me.layoutControlItemTransparency.CustomizationFormText = "Transparency"
            Me.layoutControlItemTransparency.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemTransparency.Name = "layoutControlItemTransparency"
            Me.layoutControlItemTransparency.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemTransparency.Text = "Transparency:"
            Me.layoutControlItemTransparency.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItemMaxBubbleSize
            ' 
            Me.layoutControlItemMaxBubbleSize.Control = Me.spinEditMaxBubbleSize
            Me.layoutControlItemMaxBubbleSize.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItemMaxBubbleSize.Name = "layoutControlItemMaxBubbleSize"
            Me.layoutControlItemMaxBubbleSize.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMaxBubbleSize.Text = "Max Bubble Size:"
            Me.layoutControlItemMaxBubbleSize.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItemMinBubbleSize
            ' 
            Me.layoutControlItemMinBubbleSize.Control = Me.spinEditMinBubbleSize
            Me.layoutControlItemMinBubbleSize.Location = New System.Drawing.Point(0, 48)
            Me.layoutControlItemMinBubbleSize.Name = "layoutControlItemMinBubbleSize"
            Me.layoutControlItemMinBubbleSize.Size = New System.Drawing.Size(221, 24)
            Me.layoutControlItemMinBubbleSize.Text = "Min Bubble Size:"
            Me.layoutControlItemMinBubbleSize.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' emptySpaceItem
            ' 
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 412)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 126)
            ' 
            ' layoutControlGroupPointCount
            ' 
            Me.layoutControlGroupPointCount.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupPointCount.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemPointCount})
            Me.layoutControlGroupPointCount.Location = New System.Drawing.Point(0, 294)
            Me.layoutControlGroupPointCount.Name = "layoutControlGroupPointCount"
            Me.layoutControlGroupPointCount.Size = New System.Drawing.Size(241, 118)
            Me.layoutControlGroupPointCount.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupPointCount.Text = "Number of Points per Series"
            ' 
            ' layoutControlItemPointCount
            ' 
            Me.layoutControlItemPointCount.Control = Me.tbcPointCount
            Me.layoutControlItemPointCount.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemPointCount.Name = "layoutControlItemPointCount"
            Me.layoutControlItemPointCount.Size = New System.Drawing.Size(221, 76)
            Me.layoutControlItemPointCount.Text = "Point Count in Each Sereis:"
            Me.layoutControlItemPointCount.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItemPointCount.TextVisible = False
            ' 
            ' dockManager
            ' 
            Me.dockManager.DockingOptions.FloatOnDblClick = False
            Me.dockManager.DockingOptions.ShowCloseButton = False
            Me.dockManager.Form = Me
            Me.dockManager.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() {Me.dockPanelPoint, Me.dockPanelBubble})
            Me.dockManager.TopZIndexControls.AddRange(New String() {"DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' dockPanelPoint
            ' 
            Me.dockPanelPoint.Controls.Add(Me.dockPanelPoint_Container)
            Me.dockPanelPoint.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelPoint.DockedAsTabbedDocument = True
            Me.dockPanelPoint.ID = New System.Guid("4ccbd7ef-2a17-43c1-8bb1-9d9dce303020")
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
            Me.chartPoint.CrosshairOptions.CrosshairLabelMode = DevExpress.XtraCharts.CrosshairLabelMode.ShowForNearestSeries
            Me.chartPoint.CrosshairOptions.HighlightPoints = False
            Me.chartPoint.CrosshairOptions.LinesMode = DevExpress.XtraCharts.CrosshairLinesMode.Free
            Me.chartPoint.CrosshairOptions.ShowArgumentLabels = True
            Me.chartPoint.CrosshairOptions.ShowCrosshairLabels = False
            Me.chartPoint.CrosshairOptions.ShowValueLabels = True
            Me.chartPoint.CrosshairOptions.ShowValueLine = True
            xyDiagram1.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Center
            xyDiagram1.AxisX.CrosshairAxisLabelOptions.Pattern = "{V:F0}"
            xyDiagram1.AxisX.GridLines.MinorVisible = True
            xyDiagram1.AxisX.GridLines.Visible = True
            xyDiagram1.AxisX.Label.TextPattern = "{A:F0}"
            xyDiagram1.AxisX.Title.Text = "Arguments"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Center
            xyDiagram1.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:F0}"
            xyDiagram1.AxisY.GridLines.MinorVisible = True
            xyDiagram1.AxisY.Label.TextPattern = "{V:F0}"
            xyDiagram1.AxisY.MinorCount = 4
            xyDiagram1.AxisY.Title.Text = "Values"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagram1.EnableAxisXZooming = True
            xyDiagram1.EnableAxisYScrolling = True
            xyDiagram1.EnableAxisYZooming = True
            Me.chartPoint.Diagram = xyDiagram1
            Me.chartPoint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPoint.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartPoint.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPoint.Legend.Name = "Default Legend"
            Me.chartPoint.Location = New System.Drawing.Point(0, 0)
            Me.chartPoint.Name = "chartPoint"
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel1.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            series1.Label = pointSeriesLabel1
            series1.Name = "Population 1"
            series1.SeriesID = 0
            pointSeriesView1.PointMarkerOptions.BorderVisible = False
            pointSeriesView1.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView1.PointMarkerOptions.Size = 5
            series1.View = pointSeriesView1
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel2.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            series2.Label = pointSeriesLabel2
            series2.Name = "Population 2"
            series2.SeriesID = 1
            pointSeriesView2.PointMarkerOptions.BorderVisible = False
            pointSeriesView2.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView2.PointMarkerOptions.Size = 5
            series2.View = pointSeriesView2
            series3.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            series3.Label = pointSeriesLabel3
            series3.Name = "Population 3"
            series3.SeriesID = 2
            pointSeriesView3.PointMarkerOptions.BorderVisible = False
            pointSeriesView3.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView3.PointMarkerOptions.Size = 5
            series3.View = pointSeriesView3
            series4.Name = "Population 4"
            series4.SeriesID = 3
            pointSeriesView4.PointMarkerOptions.BorderVisible = False
            pointSeriesView4.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView4.PointMarkerOptions.Size = 5
            series4.View = pointSeriesView4
            Me.chartPoint.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2, series3, series4}
            Me.chartPoint.Size = New System.Drawing.Size(788, 548)
            Me.chartPoint.TabIndex = 1
            Me.chartPoint.TabStop = False
            chartTitle1.Text = "Random Points Generator"
            chartTitle1.TitleID = 0
            Me.chartPoint.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle1})
            ' 
            ' dockPanelBubble
            ' 
            Me.dockPanelBubble.Controls.Add(Me.dockPanelBubble_Container)
            Me.dockPanelBubble.Dock = DevExpress.XtraBars.Docking.DockingStyle.Float
            Me.dockPanelBubble.DockedAsTabbedDocument = True
            Me.dockPanelBubble.ID = New System.Guid("76476733-9916-403e-aa39-c7d7ca3df63c")
            Me.dockPanelBubble.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelBubble.Name = "dockPanelBubble"
            Me.dockPanelBubble.OriginalSize = New System.Drawing.Size(200, 200)
            Me.dockPanelBubble.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelBubble.Text = "Bubble"
            ' 
            ' dockPanelBubble_Container
            ' 
            Me.dockPanelBubble_Container.Controls.Add(Me.chartBubble)
            Me.dockPanelBubble_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelBubble_Container.Name = "dockPanelBubble_Container"
            Me.dockPanelBubble_Container.Size = New System.Drawing.Size(788, 548)
            Me.dockPanelBubble_Container.TabIndex = 0
            ' 
            ' chartBubble
            ' 
            Me.chartBubble.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartBubble.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartBubble.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram2.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None
            xyDiagram2.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram2.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram2.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram2.AxisX.GridLines.Visible = True
            xyDiagram2.AxisX.Interlaced = True
            xyDiagram2.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram2.AxisX.Tickmarks.MinorVisible = False
            xyDiagram2.AxisX.Title.Text = "Year"
            xyDiagram2.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram2.AxisX.WholeRange.EndSideMargin = 0.8R
            xyDiagram2.AxisX.WholeRange.StartSideMargin = 0.8R
            xyDiagram2.AxisY.Label.TextPattern = "${V}M"
            xyDiagram2.AxisY.Title.Text = "Production Budget"
            xyDiagram2.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram2.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram2.AxisY.VisualRange.Auto = False
            xyDiagram2.AxisY.VisualRange.MaxValueSerializable = "9.6"
            xyDiagram2.AxisY.VisualRange.MinValueSerializable = "0.6"
            xyDiagram2.AxisY.WholeRange.Auto = False
            xyDiagram2.AxisY.WholeRange.MaxValueSerializable = "9.6"
            xyDiagram2.AxisY.WholeRange.MinValueSerializable = "0.6"
            Me.chartBubble.Diagram = xyDiagram2
            Me.chartBubble.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartBubble.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartBubble.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartBubble.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartBubble.Legend.Name = "Default Legend"
            Me.chartBubble.Location = New System.Drawing.Point(0, 0)
            Me.chartBubble.Name = "chartBubble"
            series5.ArgumentDataMember = "Year"
            series5.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            bubbleSeriesLabel1.TextPattern = "${W}B"
            series5.Label = bubbleSeriesLabel1
            series5.LegendTextPattern = "{A}"
            series5.Name = "Top 10 Films by Worldwide Grosses "
            series5.SeriesID = 0
            series5.ToolTipPointPattern = "Production budget: ${V}M" & Global.Microsoft.VisualBasic.Constants.vbLf & "Worldwide grosses: ${W}B"
            series5.ValueDataMembersSerializable = "Budget;Grosses"
            bubbleSeriesView1.AutoSize = False
            bubbleSeriesView1.ColorEach = True
            bubbleSeriesView1.MaxSize = 2.7R
            bubbleSeriesView1.MinSize = 0.8R
            bubbleSeriesView1.Transparency =(CByte((90)))
            series5.View = bubbleSeriesView1
            Me.chartBubble.SeriesSerializable = New DevExpress.XtraCharts.Series() {series5}
            bubbleSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartBubble.SeriesTemplate.Label = bubbleSeriesLabel2
            Me.chartBubble.SeriesTemplate.View = bubbleSeriesView2
            Me.chartBubble.Size = New System.Drawing.Size(788, 548)
            Me.chartBubble.TabIndex = 2
            chartTitle2.Text = "Highest-Grossing Films by Year"
            chartTitle2.TitleID = 0
            chartTitle3.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle3.DXAlignment = DevExpress.Drawing.DXStringAlignment.Far
            chartTitle3.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle3.Text = "From www.boxofficemojo.com"
            chartTitle3.TextColor = System.Drawing.Color.Gray
            chartTitle3.TitleID = 1
            Me.chartBubble.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle2, chartTitle3})
            Me.chartBubble.ToolTipEnabled = DevExpress.Utils.DefaultBoolean.[True]
            AddHandler Me.chartBubble.CustomDrawSeriesPoint, New DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(AddressOf Me.chartBubble_CustomDrawSeriesPoint)
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
            Me.currentTabbedView.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() {Me.documentPoint, Me.documentBubble})
            dockingContainer1.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer1})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' PointViewsDemo
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "PointViewsDemo"
            Me.Controls.SetChildIndex(Me.sidePanelOptions, 0)
            Me.sidePanelOptions.ResumeLayout(False)
            CType((Me.tabPaneOptions), System.ComponentModel.ISupportInitialize).EndInit()
            Me.tabPaneOptions.ResumeLayout(False)
            Me.tabNavigationPageOptions.ResumeLayout(False)
            CType((Me.documentGroup), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentPoint), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentBubble), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.checkEditLabelVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMarkerSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditMarkerKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditTransparency.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEditLabelPosition.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMaxBubbleSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditMinBubbleSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbcPointCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tbcPointCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupRoot), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupLabel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemLabelVisible), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPosition), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupMarker), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemKind), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTransparency), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMaxBubbleSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMinBubbleSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupPointCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemPointCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelPoint.ResumeLayout(False)
            Me.dockPanelPoint_Container.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelBubble.ResumeLayout(False)
            Me.dockPanelBubble_Container.ResumeLayout(False)
            CType((xyDiagram2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBubble), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private checkEditLabelVisible As DevExpress.XtraEditors.CheckEdit

        Private spinEditMarkerSize As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditMarkerKind As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlGroupRoot As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroupLabel As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemLabelVisible As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupMarker As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItemSize As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemKind As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupGeneral As DevExpress.XtraLayout.LayoutControlGroup

        Private emptySpaceItem As DevExpress.XtraLayout.EmptySpaceItem

        Private spinEditTransparency As DevExpress.XtraEditors.SpinEdit

        Private comboBoxEditLabelPosition As DevExpress.XtraEditors.ComboBoxEdit

        Private layoutControlItemPosition As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemTransparency As DevExpress.XtraLayout.LayoutControlItem

        Private spinEditMaxBubbleSize As DevExpress.XtraEditors.SpinEdit

        Private spinEditMinBubbleSize As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItemMaxBubbleSize As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItemMinBubbleSize As DevExpress.XtraLayout.LayoutControlItem

        Private dockManager As DevExpress.XtraBars.Docking.DockManager

        Private dockPanelPoint As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelPoint_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private dockPanelBubble As DevExpress.XtraBars.Docking.DockPanel

        Private dockPanelBubble_Container As DevExpress.XtraBars.Docking.ControlContainer

        Private documentManager As DevExpress.XtraBars.Docking2010.DocumentManager

        Private currentTabbedView As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView

        Private documentGroup As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup

        Private documentPoint As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private documentBubble As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document

        Private chartPoint As DevExpress.XtraCharts.ChartControl

        Private chartBubble As DevExpress.XtraCharts.ChartControl

        Private tbcPointCount As DevExpress.XtraEditors.TrackBarControl

        Private layoutControlItemPointCount As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroupPointCount As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
