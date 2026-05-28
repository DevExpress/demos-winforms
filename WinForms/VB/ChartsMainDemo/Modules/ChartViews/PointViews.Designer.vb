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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraCharts.Demos.PointViewsDemo))
            Dim trackBarLabel1 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel2 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim trackBarLabel3 As DevExpress.XtraEditors.Repository.TrackBarLabel = New DevExpress.XtraEditors.Repository.TrackBarLabel()
            Dim xyDiagram5 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series11 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel7 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView9 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series12 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel8 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView10 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series13 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel9 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim pointSeriesView11 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim series14 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesView12 As DevExpress.XtraCharts.PointSeriesView = New DevExpress.XtraCharts.PointSeriesView()
            Dim chartTitle7 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim xyDiagram6 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series15 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim bubbleSeriesLabel5 As DevExpress.XtraCharts.BubbleSeriesLabel = New DevExpress.XtraCharts.BubbleSeriesLabel()
            Dim bubbleSeriesView5 As DevExpress.XtraCharts.BubbleSeriesView = New DevExpress.XtraCharts.BubbleSeriesView()
            Dim bubbleSeriesLabel6 As DevExpress.XtraCharts.BubbleSeriesLabel = New DevExpress.XtraCharts.BubbleSeriesLabel()
            Dim bubbleSeriesView6 As DevExpress.XtraCharts.BubbleSeriesView = New DevExpress.XtraCharts.BubbleSeriesView()
            Dim chartTitle8 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim chartTitle9 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
            Dim dockingContainer3 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer()
            Me.documentGroup = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup()
            Me.documentPoint = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
            Me.documentBubble = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document()
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
            Me.layoutControlItemPointCount = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroupGeneral = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItemTransparency = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMaxBubbleSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItemMinBubbleSize = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.dockManager = New DevExpress.XtraBars.Docking.DockManager()
            Me.dockPanelPoint = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelPoint_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartPoint = New DevExpress.XtraCharts.ChartControl()
            Me.dockPanelBubble = New DevExpress.XtraBars.Docking.DockPanel()
            Me.dockPanelBubble_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.chartBubble = New DevExpress.XtraCharts.ChartControl()
            Me.documentManager = New DevExpress.XtraBars.Docking2010.DocumentManager()
            Me.currentTabbedView = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView()
            Me.layoutControlGroupPointCount = New DevExpress.XtraLayout.LayoutControlGroup()
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
            CType((Me.layoutControlItemPointCount), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemTransparency), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMaxBubbleSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItemMinBubbleSize), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelPoint.SuspendLayout()
            Me.dockPanelPoint_Container.SuspendLayout()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesView12), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.dockPanelBubble.SuspendLayout()
            Me.dockPanelBubble_Container.SuspendLayout()
            CType((Me.chartBubble), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series15), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesLabel5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesView5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesLabel6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((bubbleSeriesView6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroupPointCount), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' tabNavigationPageOptions
            ' 
            Me.tabNavigationPageOptions.Controls.Add(Me.layoutControl)
            Me.tabNavigationPageOptions.Size = New System.Drawing.Size(241, 544)
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
            Me.layoutControl.Size = New System.Drawing.Size(241, 544)
            Me.layoutControl.TabIndex = 1
            Me.layoutControl.Text = "layoutControl1"
            ' 
            ' checkEditLabelVisible
            ' 
            Me.checkEditLabelVisible.Location = New System.Drawing.Point(12, 142)
            Me.checkEditLabelVisible.Name = "checkEditLabelVisible"
            Me.checkEditLabelVisible.Properties.Caption = "Visible"
            Me.checkEditLabelVisible.Size = New System.Drawing.Size(217, 19)
            Me.checkEditLabelVisible.StyleController = Me.layoutControl
            Me.checkEditLabelVisible.TabIndex = 4
            AddHandler Me.checkEditLabelVisible.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditLabelVisible_CheckedChanged)
            ' 
            ' spinEditMarkerSize
            ' 
            Me.spinEditMarkerSize.EditValue = New Decimal(New Integer() {10, 0, 0, 0})
            Me.spinEditMarkerSize.Location = New System.Drawing.Point(96, 228)
            Me.spinEditMarkerSize.Name = "spinEditMarkerSize"
            Me.spinEditMarkerSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatString = "0 px"
            Me.spinEditMarkerSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMarkerSize.Properties.IsFloatValue = False
            Me.spinEditMarkerSize.Properties.Mask.EditMask = "N00"
            Me.spinEditMarkerSize.Properties.MaxValue = New Decimal(New Integer() {30, 0, 0, 0})
            Me.spinEditMarkerSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
            Me.spinEditMarkerSize.Size = New System.Drawing.Size(133, 20)
            Me.spinEditMarkerSize.StyleController = Me.layoutControl
            Me.spinEditMarkerSize.TabIndex = 8
            ' 
            ' comboBoxEditMarkerKind
            ' 
            Me.comboBoxEditMarkerKind.Location = New System.Drawing.Point(96, 252)
            Me.comboBoxEditMarkerKind.Name = "comboBoxEditMarkerKind"
            Me.comboBoxEditMarkerKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditMarkerKind.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditMarkerKind.Size = New System.Drawing.Size(133, 20)
            Me.comboBoxEditMarkerKind.StyleController = Me.layoutControl
            Me.comboBoxEditMarkerKind.TabIndex = 5
            ' 
            ' spinEditTransparency
            ' 
            Me.spinEditTransparency.EditValue = New Decimal(New Integer() {135, 0, 0, 0})
            Me.spinEditTransparency.Location = New System.Drawing.Point(96, 31)
            Me.spinEditTransparency.Name = "spinEditTransparency"
            Me.spinEditTransparency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditTransparency.Properties.IsFloatValue = False
            Me.spinEditTransparency.Properties.Mask.EditMask = "N00"
            Me.spinEditTransparency.Properties.MaxValue = New Decimal(New Integer() {255, 0, 0, 0})
            Me.spinEditTransparency.Size = New System.Drawing.Size(133, 20)
            Me.spinEditTransparency.StyleController = Me.layoutControl
            Me.spinEditTransparency.TabIndex = 9
            AddHandler Me.spinEditTransparency.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditTransparencyEditValueChanged)
            ' 
            ' comboBoxEditLabelPosition
            ' 
            Me.comboBoxEditLabelPosition.EditValue = "Center"
            Me.comboBoxEditLabelPosition.Location = New System.Drawing.Point(96, 165)
            Me.comboBoxEditLabelPosition.Name = "comboBoxEditLabelPosition"
            Me.comboBoxEditLabelPosition.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEditLabelPosition.Properties.Items.AddRange(New Object() {"Center", "Outside"})
            Me.comboBoxEditLabelPosition.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEditLabelPosition.Size = New System.Drawing.Size(133, 20)
            Me.comboBoxEditLabelPosition.StyleController = Me.layoutControl
            Me.comboBoxEditLabelPosition.TabIndex = 10
            AddHandler Me.comboBoxEditLabelPosition.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboBoxEditLabelPosition_SelectedIndexChanged)
            ' 
            ' spinEditMaxBubbleSize
            ' 
            Me.spinEditMaxBubbleSize.EditValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMaxBubbleSize.Location = New System.Drawing.Point(96, 55)
            Me.spinEditMaxBubbleSize.Name = "spinEditMaxBubbleSize"
            Me.spinEditMaxBubbleSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMaxBubbleSize.Properties.DisplayFormat.FormatString = "0  X-axis\'s tickmarks distances"
            Me.spinEditMaxBubbleSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMaxBubbleSize.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMaxBubbleSize.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditMaxBubbleSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMaxBubbleSize.Size = New System.Drawing.Size(133, 20)
            Me.spinEditMaxBubbleSize.StyleController = Me.layoutControl
            Me.spinEditMaxBubbleSize.TabIndex = 11
            Me.spinEditMaxBubbleSize.ToolTip = "X-axis's tickmarks distances"
            AddHandler Me.spinEditMaxBubbleSize.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditMaxBubbleSize_EditValueChanged)
            AddHandler Me.spinEditMaxBubbleSize.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.spinEditMaxBubbleSize_EditValueChanging)
            ' 
            ' spinEditMinBubbleSize
            ' 
            Me.spinEditMinBubbleSize.EditValue = New Decimal(New Integer() {8, 0, 0, 65536})
            Me.spinEditMinBubbleSize.Location = New System.Drawing.Point(96, 79)
            Me.spinEditMinBubbleSize.Name = "spinEditMinBubbleSize"
            Me.spinEditMinBubbleSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinEditMinBubbleSize.Properties.DisplayFormat.FormatString = "0  X-axis\'s tickmarks distances"
            Me.spinEditMinBubbleSize.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.spinEditMinBubbleSize.Properties.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMinBubbleSize.Properties.MaxValue = New Decimal(New Integer() {5, 0, 0, 0})
            Me.spinEditMinBubbleSize.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 65536})
            Me.spinEditMinBubbleSize.Size = New System.Drawing.Size(133, 20)
            Me.spinEditMinBubbleSize.StyleController = Me.layoutControl
            Me.spinEditMinBubbleSize.TabIndex = 12
            Me.spinEditMinBubbleSize.ToolTip = "X-axis's tickmarks distances"
            AddHandler Me.spinEditMinBubbleSize.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditMinBubbleSize_EditValueChanged)
            AddHandler Me.spinEditMinBubbleSize.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.spinEditMinBubbleSize_EditValueChanging)
            ' 
            ' tbcPointCount
            ' 
            Me.tbcPointCount.EditValue = 3000
            Me.tbcPointCount.Location = New System.Drawing.Point(12, 315)
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
            Me.layoutControlGroupRoot.Size = New System.Drawing.Size(241, 544)
            Me.layoutControlGroupRoot.TextVisible = False
            ' 
            ' layoutControlGroupLabel
            ' 
            Me.layoutControlGroupLabel.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupLabel.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupLabel.CustomizationFormText = "Label"
            Me.layoutControlGroupLabel.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupLabel.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemLabelVisible, Me.layoutControlItemPosition})
            Me.layoutControlGroupLabel.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlGroupLabel.Name = "layoutControlGroupLabel"
            Me.layoutControlGroupLabel.Size = New System.Drawing.Size(241, 86)
            Me.layoutControlGroupLabel.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupLabel.Text = "Label"
            ' 
            ' layoutControlItemLabelVisible
            ' 
            Me.layoutControlItemLabelVisible.Control = Me.checkEditLabelVisible
            Me.layoutControlItemLabelVisible.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItemLabelVisible.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemLabelVisible.Name = "layoutControlItemLabelVisible"
            Me.layoutControlItemLabelVisible.Size = New System.Drawing.Size(221, 23)
            Me.layoutControlItemLabelVisible.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemLabelVisible.TextVisible = False
            ' 
            ' layoutControlItemPosition
            ' 
            Me.layoutControlItemPosition.Control = Me.comboBoxEditLabelPosition
            Me.layoutControlItemPosition.Enabled = False
            Me.layoutControlItemPosition.Location = New System.Drawing.Point(0, 23)
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
            Me.layoutControlGroupMarker.Location = New System.Drawing.Point(0, 197)
            Me.layoutControlGroupMarker.Name = "layoutControlGroupMarker"
            Me.layoutControlGroupMarker.Size = New System.Drawing.Size(241, 87)
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
            ' layoutControlItemPointCount
            ' 
            Me.layoutControlItemPointCount.Control = Me.tbcPointCount
            Me.layoutControlItemPointCount.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItemPointCount.Name = "layoutControlItemPointCount"
            Me.layoutControlItemPointCount.Size = New System.Drawing.Size(221, 76)
            Me.layoutControlItemPointCount.Text = "Point Count in Each Sereis:"
            Me.layoutControlItemPointCount.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItemPointCount.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItemPointCount.TextVisible = False
            ' 
            ' layoutControlGroupGeneral
            ' 
            Me.layoutControlGroupGeneral.AppearanceGroup.BorderColor = System.Drawing.Color.Transparent
            Me.layoutControlGroupGeneral.AppearanceGroup.Options.UseBorderColor = True
            Me.layoutControlGroupGeneral.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupGeneral.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemTransparency, Me.layoutControlItemMaxBubbleSize, Me.layoutControlItemMinBubbleSize})
            Me.layoutControlGroupGeneral.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroupGeneral.Name = "layoutControlGroupGeneral"
            Me.layoutControlGroupGeneral.Size = New System.Drawing.Size(241, 111)
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
            Me.emptySpaceItem.AllowHotTrack = False
            Me.emptySpaceItem.Location = New System.Drawing.Point(0, 399)
            Me.emptySpaceItem.Name = "emptySpaceItem"
            Me.emptySpaceItem.Size = New System.Drawing.Size(241, 145)
            Me.emptySpaceItem.TextSize = New System.Drawing.Size(0, 0)
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
            Me.dockPanelPoint.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelPoint.Text = "Point"
            ' 
            ' dockPanelPoint_Container
            ' 
            Me.dockPanelPoint_Container.Controls.Add(Me.chartPoint)
            Me.dockPanelPoint_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelPoint_Container.Name = "dockPanelPoint_Container"
            Me.dockPanelPoint_Container.Size = New System.Drawing.Size(788, 545)
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
            xyDiagram5.AxisX.Alignment = DevExpress.XtraCharts.AxisAlignment.Center
            xyDiagram5.AxisX.CrosshairAxisLabelOptions.Pattern = "{V:F0}"
            xyDiagram5.AxisX.GridLines.MinorVisible = True
            xyDiagram5.AxisX.GridLines.Visible = True
            xyDiagram5.AxisX.Title.Text = "Arguments"
            xyDiagram5.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram5.AxisX.Label.TextPattern = "{A:F0}"
            xyDiagram5.AxisY.Alignment = DevExpress.XtraCharts.AxisAlignment.Center
            xyDiagram5.AxisY.CrosshairAxisLabelOptions.Pattern = "{V:F0}"
            xyDiagram5.AxisY.GridLines.MinorVisible = True
            xyDiagram5.AxisY.MinorCount = 4
            xyDiagram5.AxisY.Title.Text = "Values"
            xyDiagram5.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram5.AxisY.Label.TextPattern = "{V:F0}"
            xyDiagram5.EnableAxisXScrolling = True
            xyDiagram5.EnableAxisXZooming = True
            xyDiagram5.EnableAxisYScrolling = True
            xyDiagram5.EnableAxisYZooming = True
            Me.chartPoint.Diagram = xyDiagram5
            Me.chartPoint.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartPoint.Legend.BackColor = System.Drawing.Color.Transparent
            Me.chartPoint.Legend.Border.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartPoint.Legend.Name = "Default Legend"
            Me.chartPoint.Location = New System.Drawing.Point(0, 0)
            Me.chartPoint.Name = "chartPoint"
            series11.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel7.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            series11.Label = pointSeriesLabel7
            series11.Name = "Population 1"
            pointSeriesView9.PointMarkerOptions.BorderVisible = False
            pointSeriesView9.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView9.PointMarkerOptions.Size = 5
            series11.View = pointSeriesView9
            series12.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel8.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            series12.Label = pointSeriesLabel8
            series12.Name = "Population 2"
            pointSeriesView10.PointMarkerOptions.BorderVisible = False
            pointSeriesView10.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView10.PointMarkerOptions.Size = 5
            series12.View = pointSeriesView10
            series13.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Numerical
            pointSeriesLabel9.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 6F)
            series13.Label = pointSeriesLabel9
            series13.Name = "Population 3"
            pointSeriesView11.PointMarkerOptions.BorderVisible = False
            pointSeriesView11.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView11.PointMarkerOptions.Size = 5
            series13.View = pointSeriesView11
            series14.Name = "Population 4"
            pointSeriesView12.PointMarkerOptions.BorderVisible = False
            pointSeriesView12.PointMarkerOptions.Kind = DevExpress.XtraCharts.MarkerKind.Square
            pointSeriesView12.PointMarkerOptions.Size = 5
            series14.View = pointSeriesView12
            Me.chartPoint.SeriesSerializable = New DevExpress.XtraCharts.Series() {series11, series12, series13, series14}
            Me.chartPoint.Size = New System.Drawing.Size(788, 545)
            Me.chartPoint.TabIndex = 1
            Me.chartPoint.TabStop = False
            chartTitle7.Text = "Random Points Generator"
            Me.chartPoint.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle7})
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
            Me.dockPanelBubble.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelBubble.Text = "Bubble"
            ' 
            ' dockPanelBubble_Container
            ' 
            Me.dockPanelBubble_Container.Controls.Add(Me.chartBubble)
            Me.dockPanelBubble_Container.Location = New System.Drawing.Point(0, 0)
            Me.dockPanelBubble_Container.Name = "dockPanelBubble_Container"
            Me.dockPanelBubble_Container.Size = New System.Drawing.Size(788, 545)
            Me.dockPanelBubble_Container.TabIndex = 0
            ' 
            ' chartBubble
            ' 
            Me.chartBubble.AnimationStartMode = DevExpress.XtraCharts.ChartAnimationMode.OnLoad
            Me.chartBubble.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartBubble.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.[False]
            xyDiagram6.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None
            xyDiagram6.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram6.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Year
            xyDiagram6.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Year
            xyDiagram6.AxisX.GridLines.Visible = True
            xyDiagram6.AxisX.Interlaced = True
            xyDiagram6.AxisX.Label.TextPattern = "{A:yyyy}"
            xyDiagram6.AxisX.Tickmarks.MinorVisible = False
            xyDiagram6.AxisX.Title.Text = "Year"
            xyDiagram6.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram6.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram6.AxisX.VisualRange.Auto = False
            xyDiagram6.AxisX.VisualRange.AutoSideMargins = False
            xyDiagram6.AxisX.VisualRange.MaxValueSerializable = "01/01/2016 00:00:00.000"
            xyDiagram6.AxisX.VisualRange.MinValueSerializable = "01/01/2007 00:00:00.000"
            xyDiagram6.AxisX.VisualRange.SideMarginsValue = 0.7R
            xyDiagram6.AxisX.WholeRange.Auto = False
            xyDiagram6.AxisX.WholeRange.AutoSideMargins = False
            xyDiagram6.AxisX.WholeRange.MaxValueSerializable = "01/01/2016 00:00:00.000"
            xyDiagram6.AxisX.WholeRange.MinValueSerializable = "01/01/2007 00:00:00.000"
            xyDiagram6.AxisX.WholeRange.SideMarginsValue = 0.8R
            xyDiagram6.AxisY.Label.TextPattern = "${V}M"
            xyDiagram6.AxisY.Title.Text = "Production Budget"
            xyDiagram6.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.[True]
            xyDiagram6.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram6.AxisY.VisualRange.Auto = False
            xyDiagram6.AxisY.VisualRange.MaxValueSerializable = "310"
            xyDiagram6.AxisY.VisualRange.MinValueSerializable = "130"
            xyDiagram6.AxisY.WholeRange.Auto = False
            xyDiagram6.AxisY.WholeRange.MaxValueSerializable = "370"
            xyDiagram6.AxisY.WholeRange.MinValueSerializable = "0"
            Me.chartBubble.Diagram = xyDiagram6
            Me.chartBubble.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartBubble.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartBubble.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartBubble.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartBubble.Legend.Name = "Default Legend"
            Me.chartBubble.Location = New System.Drawing.Point(0, 0)
            Me.chartBubble.Name = "chartBubble"
            series15.ArgumentDataMember = "Year"
            series15.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.DateTime
            bubbleSeriesLabel5.TextPattern = "${W}B"
            series15.Label = bubbleSeriesLabel5
            series15.LegendTextPattern = "{A}"
            series15.Name = "Top 10 Films by Worldwide Grosses "
            series15.ToolTipPointPattern = "Production budget: ${V}M" & Global.Microsoft.VisualBasic.Constants.vbLf & "Worldwide grosses: ${W}B"
            series15.ValueDataMembersSerializable = "Budget;Grosses"
            bubbleSeriesView5.AutoSize = False
            bubbleSeriesView5.ColorEach = True
            bubbleSeriesView5.MaxSize = 2.7R
            bubbleSeriesView5.MinSize = 0.8R
            bubbleSeriesView5.Transparency =(CByte((90)))
            series15.View = bubbleSeriesView5
            Me.chartBubble.SeriesSerializable = New DevExpress.XtraCharts.Series() {series15}
            bubbleSeriesLabel6.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartBubble.SeriesTemplate.Label = bubbleSeriesLabel6
            Me.chartBubble.SeriesTemplate.View = bubbleSeriesView6
            Me.chartBubble.Size = New System.Drawing.Size(788, 545)
            Me.chartBubble.TabIndex = 2
            chartTitle8.Text = "Highest-Grossing Films by Year"
            chartTitle9.Alignment = System.Drawing.StringAlignment.Far
            chartTitle9.Dock = DevExpress.XtraCharts.ChartTitleDockStyle.Bottom
            chartTitle9.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8F)
            chartTitle9.Text = "From www.boxofficemojo.com"
            chartTitle9.TextColor = System.Drawing.Color.Gray
            Me.chartBubble.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {chartTitle8, chartTitle9})
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
            dockingContainer3.Element = Me.documentGroup
            Me.currentTabbedView.RootContainer.Nodes.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DockingContainer() {dockingContainer3})
            Me.currentTabbedView.Style = DevExpress.XtraBars.Docking2010.Views.DockingViewStyle.Light
            AddHandler Me.currentTabbedView.DocumentActivated, New DevExpress.XtraBars.Docking2010.Views.DocumentEventHandler(AddressOf Me.tabbedView_DocumentActivated)
            ' 
            ' layoutControlGroupPointCount
            ' 
            Me.layoutControlGroupPointCount.GroupStyle = DevExpress.Utils.GroupStyle.Title
            Me.layoutControlGroupPointCount.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItemPointCount})
            Me.layoutControlGroupPointCount.Location = New System.Drawing.Point(0, 284)
            Me.layoutControlGroupPointCount.Name = "layoutControlGroupPointCount"
            Me.layoutControlGroupPointCount.Size = New System.Drawing.Size(241, 115)
            Me.layoutControlGroupPointCount.Spacing = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlGroupPointCount.Text = "Number of Points per Series"
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
            CType((Me.layoutControlItemPointCount), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupGeneral), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemTransparency), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMaxBubbleSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItemMinBubbleSize), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.dockManager), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelPoint.ResumeLayout(False)
            Me.dockPanelPoint_Container.ResumeLayout(False)
            CType((xyDiagram5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesView12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartPoint), System.ComponentModel.ISupportInitialize).EndInit()
            Me.dockPanelBubble.ResumeLayout(False)
            Me.dockPanelBubble_Container.ResumeLayout(False)
            CType((xyDiagram6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesLabel5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesView5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series15), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesLabel6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((bubbleSeriesView6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartBubble), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.documentManager), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTabbedView), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroupPointCount), System.ComponentModel.ISupportInitialize).EndInit()
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
