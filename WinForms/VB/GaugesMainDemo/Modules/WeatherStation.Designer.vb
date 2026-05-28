Namespace DevExpress.XtraGauges.Demos

    Partial Class WeatherStation

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
        Private Sub InitializeComponent()
            Dim xyDiagram1 As DevExpress.XtraCharts.XYDiagram = New DevExpress.XtraCharts.XYDiagram()
            Dim series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel1 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim splineSeriesView1 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Dim series2 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
            Dim pointSeriesLabel2 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim splineSeriesView2 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Dim pointSeriesLabel3 As DevExpress.XtraCharts.PointSeriesLabel = New DevExpress.XtraCharts.PointSeriesLabel()
            Dim splineSeriesView3 As DevExpress.XtraCharts.SplineSeriesView = New DevExpress.XtraCharts.SplineSeriesView()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.currentTempScale = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent()
            Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.linearScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.comboBoxEdit1 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.comboBoxEdit2 = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl3.SuspendLayout()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.currentTempScale), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevelComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((series2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((splineSeriesView3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.panelControl3)
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            Me.layoutControl1.Controls.Add(Me.panelControl2)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(674, 483)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' panelControl3
            ' 
            Me.panelControl3.Controls.Add(Me.gaugeControl1)
            Me.panelControl3.Location = New System.Drawing.Point(349, 74)
            Me.panelControl3.Name = "panelControl3"
            Me.panelControl3.Size = New System.Drawing.Size(325, 409)
            Me.panelControl3.TabIndex = 14
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(2, 2)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(321, 405)
            Me.gaugeControl1.TabIndex = 2
            ' 
            ' linearGauge1
            ' 
            Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayerComponent1})
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 309, 393)
            Me.linearGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent() {Me.linearScaleEffectLayerComponent1})
            Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevelComponent1})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.currentTempScale, Me.linearScaleComponent2})
            ' 
            ' linearScaleBackgroundLayerComponent1
            ' 
            Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.currentTempScale
            Me.linearScaleBackgroundLayerComponent1.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.125F)
            Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.497F, 0.875F)
            Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style6
            Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' currentTempScale
            ' 
            Me.currentTempScale.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.currentTempScale.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.currentTempScale.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.currentTempScale.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.currentTempScale.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7F)
            Me.currentTempScale.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.currentTempScale.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 32F)
            Me.currentTempScale.MajorTickCount = 6
            Me.currentTempScale.MajorTickmark.FormatString = "{0:F0}C°"
            Me.currentTempScale.MajorTickmark.ShapeOffset = 5F
            Me.currentTempScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_3
            Me.currentTempScale.MajorTickmark.TextOffset = 35F
            Me.currentTempScale.MaxValue = 100F
            Me.currentTempScale.MinorTickCount = 4
            Me.currentTempScale.MinorTickmark.ShapeOffset = 5F
            Me.currentTempScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_2
            Me.currentTempScale.Name = "scale1"
            Me.currentTempScale.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 218F)
            ' 
            ' linearScaleEffectLayerComponent1
            ' 
            Me.linearScaleEffectLayerComponent1.LinearScale = Me.currentTempScale
            Me.linearScaleEffectLayerComponent1.Name = "effect1"
            Me.linearScaleEffectLayerComponent1.ScaleEndPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 2F)
            Me.linearScaleEffectLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.15F)
            Me.linearScaleEffectLayerComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.OpacityShader("Opacity[0.5]")
            Me.linearScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.Linear_Style6
            Me.linearScaleEffectLayerComponent1.ZOrder = -1000
            ' 
            ' linearScaleLevelComponent1
            ' 
            Me.linearScaleLevelComponent1.LinearScale = Me.currentTempScale
            Me.linearScaleLevelComponent1.Name = "level1"
            Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style6
            Me.linearScaleLevelComponent1.ZOrder = -50
            ' 
            ' linearScaleComponent2
            ' 
            Me.linearScaleComponent2.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent2.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 7F)
            Me.linearScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
            Me.linearScaleComponent2.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 32F)
            Me.linearScaleComponent2.MajorTickCount = 6
            Me.linearScaleComponent2.MajorTickmark.Addend = 32F
            Me.linearScaleComponent2.MajorTickmark.FormatString = "{0:F0}F°"
            Me.linearScaleComponent2.MajorTickmark.Multiplier = 1.8F
            Me.linearScaleComponent2.MajorTickmark.ShapeOffset = -22F
            Me.linearScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_3
            Me.linearScaleComponent2.MajorTickmark.TextOffset = -35F
            Me.linearScaleComponent2.MaxValue = 100F
            Me.linearScaleComponent2.MinorTickCount = 4
            Me.linearScaleComponent2.MinorTickmark.ShapeOffset = -11F
            Me.linearScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style6_2
            Me.linearScaleComponent2.Name = "scale2"
            Me.linearScaleComponent2.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 218F)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.layoutControl2)
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.panelControl1.Size = New System.Drawing.Size(674, 45)
            Me.panelControl1.TabIndex = 12
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.AutoScroll = False
            Me.layoutControl2.Controls.Add(Me.labelControl1)
            Me.layoutControl2.Controls.Add(Me.comboBoxEdit1)
            Me.layoutControl2.Controls.Add(Me.comboBoxEdit2)
            Me.layoutControl2.Controls.Add(Me.simpleButton1)
            Me.layoutControl2.Controls.Add(Me.labelControl2)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(2, 10)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup2
            Me.layoutControl2.Size = New System.Drawing.Size(670, 33)
            Me.layoutControl2.TabIndex = 0
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.labelControl1.Location = New System.Drawing.Point(16, 5)
            Me.labelControl1.MaximumSize = New System.Drawing.Size(0, 20)
            Me.labelControl1.MinimumSize = New System.Drawing.Size(0, 20)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(83, 20)
            Me.labelControl1.StyleController = Me.layoutControl2
            Me.labelControl1.TabIndex = 8
            Me.labelControl1.Text = "Get Weather at"
            ' 
            ' comboBoxEdit1
            ' 
            Me.comboBoxEdit1.EditValue = "London(Offline data)"
            Me.comboBoxEdit1.Location = New System.Drawing.Point(106, 2)
            Me.comboBoxEdit1.Name = "comboBoxEdit1"
            Me.comboBoxEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit1.Properties.Items.AddRange(New Object() {"Delhi", "London", "London(Offline data)", "Los Angeles", "Moscow", "Oslo", "Rome", "Washington"})
            Me.comboBoxEdit1.Properties.Sorted = True
            Me.comboBoxEdit1.Size = New System.Drawing.Size(153, 20)
            Me.comboBoxEdit1.StyleController = Me.layoutControl2
            Me.comboBoxEdit1.TabIndex = 9
            ' 
            ' comboBoxEdit2
            ' 
            Me.comboBoxEdit2.EditValue = "Celsius"
            Me.comboBoxEdit2.Location = New System.Drawing.Point(294, 2)
            Me.comboBoxEdit2.Name = "comboBoxEdit2"
            Me.comboBoxEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboBoxEdit2.Properties.Items.AddRange(New Object() {"Fahrenheit", "Celsius"})
            Me.comboBoxEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboBoxEdit2.Size = New System.Drawing.Size(112, 20)
            Me.comboBoxEdit2.StyleController = Me.layoutControl2
            Me.comboBoxEdit2.TabIndex = 10
            ' 
            ' simpleButton1
            ' 
            Me.simpleButton1.Location = New System.Drawing.Point(487, 5)
            Me.simpleButton1.Name = "simpleButton1"
            Me.simpleButton1.Size = New System.Drawing.Size(167, 23)
            Me.simpleButton1.StyleController = Me.layoutControl2
            Me.simpleButton1.TabIndex = 6
            Me.simpleButton1.Text = "Get Weather"
            AddHandler Me.simpleButton1.Click, New System.EventHandler(AddressOf Me.simpleButton1_Click)
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Appearance.Options.UseTextOptions = True
            Me.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.labelControl2.Location = New System.Drawing.Point(263, 2)
            Me.labelControl2.MaximumSize = New System.Drawing.Size(0, 20)
            Me.labelControl2.MinimumSize = New System.Drawing.Size(0, 20)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(27, 20)
            Me.labelControl2.StyleController = Me.layoutControl2
            Me.labelControl2.TabIndex = 11
            Me.labelControl2.Text = "in"
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem7, Me.emptySpaceItem1, Me.layoutControlItem5})
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(670, 34)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.labelControl1
            Me.layoutControlItem6.CustomizationFormText = "layoutControlItem6"
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.MaxSize = New System.Drawing.Size(104, 34)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(104, 34)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 5, 5, 5)
            Me.layoutControlItem6.Size = New System.Drawing.Size(104, 34)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.comboBoxEdit1
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(104, 0)
            Me.layoutControlItem2.MaxSize = New System.Drawing.Size(157, 31)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(157, 31)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(157, 34)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.simpleButton1
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(482, 0)
            Me.layoutControlItem3.MaxSize = New System.Drawing.Size(188, 33)
            Me.layoutControlItem3.MinSize = New System.Drawing.Size(188, 33)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 16, 5, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(188, 34)
            Me.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.labelControl2
            Me.layoutControlItem7.CustomizationFormText = "layoutControlItem7"
            Me.layoutControlItem7.Location = New System.Drawing.Point(261, 0)
            Me.layoutControlItem7.MaxSize = New System.Drawing.Size(31, 31)
            Me.layoutControlItem7.MinSize = New System.Drawing.Size(31, 31)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Size = New System.Drawing.Size(31, 34)
            Me.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
            Me.emptySpaceItem1.Location = New System.Drawing.Point(408, 0)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(74, 34)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.comboBoxEdit2
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(292, 0)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(116, 31)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(116, 31)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(116, 34)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.chartControl1)
            Me.panelControl2.Location = New System.Drawing.Point(0, 74)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(337, 409)
            Me.panelControl2.TabIndex = 13
            ' 
            ' chartControl1
            ' 
            Me.chartControl1.AppearanceNameSerializable = "Light"
            Me.chartControl1.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.[False]
            Me.chartControl1.CacheToMemory = True
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            Me.chartControl1.Diagram = xyDiagram1
            Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl1.Location = New System.Drawing.Point(2, 2)
            Me.chartControl1.Name = "chartControl1"
            Me.chartControl1.PaletteName = "Aspect"
            pointSeriesLabel1.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series1.Label = pointSeriesLabel1
            series1.LegendTextPattern = "MinTemperature"
            series1.Name = "Series 2"
            series1.SeriesID = 0
            series1.View = splineSeriesView1
            pointSeriesLabel2.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            series2.Label = pointSeriesLabel2
            series2.LegendTextPattern = "MaxTemperature"
            series2.Name = "Series 1"
            series2.SeriesID = 1
            series2.View = splineSeriesView2
            Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series() {series1, series2}
            pointSeriesLabel3.LineVisibility = DevExpress.Utils.DefaultBoolean.[True]
            Me.chartControl1.SeriesTemplate.Label = pointSeriesLabel3
            Me.chartControl1.SeriesTemplate.View = splineSeriesView3
            Me.chartControl1.Size = New System.Drawing.Size(333, 405)
            Me.chartControl1.TabIndex = 1
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem1})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(674, 483)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.panelControl1
            Me.layoutControlItem8.CustomizationFormText = "layoutControlItem8"
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem8.MaxSize = New System.Drawing.Size(0, 49)
            Me.layoutControlItem8.MinSize = New System.Drawing.Size(101, 49)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(674, 49)
            Me.layoutControlItem8.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11F)
            Me.layoutControlItem9.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem9.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem9.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem9.Control = Me.panelControl2
            Me.layoutControlItem9.CustomizationFormText = "Min and Max temperature for next several days"
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 49)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 6, 4, 0)
            Me.layoutControlItem9.Size = New System.Drawing.Size(343, 434)
            Me.layoutControlItem9.Text = "Min and Max temperature for next several days"
            Me.layoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(314, 18)
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 11F)
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseFont = True
            Me.layoutControlItem1.AppearanceItemCaption.Options.UseTextOptions = True
            Me.layoutControlItem1.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.layoutControlItem1.Control = Me.panelControl3
            Me.layoutControlItem1.CustomizationFormText = "Current Temperature"
            Me.layoutControlItem1.Location = New System.Drawing.Point(343, 49)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(6, 0, 4, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(331, 434)
            Me.layoutControlItem1.Text = "Current Temperature"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(314, 18)
            ' 
            ' WeatherStation
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "WeatherStation"
            Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            Me.Size = New System.Drawing.Size(674, 499)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.panelControl3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl3.ResumeLayout(False)
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.currentTempScale), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevelComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.comboBoxEdit1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboBoxEdit2.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            CType((xyDiagram1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((series2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((pointSeriesLabel3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((splineSeriesView3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.chartControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private simpleButton1 As DevExpress.XtraEditors.SimpleButton

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private comboBoxEdit1 As DevExpress.XtraEditors.ComboBoxEdit

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private comboBoxEdit2 As DevExpress.XtraEditors.ComboBoxEdit

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private panelControl2 As DevExpress.XtraEditors.PanelControl

        Private panelControl3 As DevExpress.XtraEditors.PanelControl

        Private chartControl1 As DevExpress.XtraCharts.ChartControl

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private currentTempScale As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleEffectLayerComponent

        Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private linearScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
