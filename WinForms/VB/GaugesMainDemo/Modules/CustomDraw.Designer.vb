Namespace DevExpress.XtraGauges.Demos

    Partial Class CustomDrawFeature

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceAllowCustomDraw = New DevExpress.XtraEditors.CheckEdit()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayer = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScale = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevel = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayer = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScale = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedle = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceAllowCustomDraw.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleBackgroundLayer), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScale), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleLevel), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayer), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScale), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.ceAllowCustomDraw)
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(601, 480)
            Me.layoutControl1.TabIndex = 1
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceAllowCustomDraw
            ' 
            Me.ceAllowCustomDraw.Location = New System.Drawing.Point(12, 12)
            Me.ceAllowCustomDraw.Name = "ceAllowCustomDraw"
            Me.ceAllowCustomDraw.Properties.Caption = "Handle CustomDraw events"
            Me.ceAllowCustomDraw.Size = New System.Drawing.Size(577, 20)
            Me.ceAllowCustomDraw.StyleController = Me.layoutControl1
            Me.ceAllowCustomDraw.TabIndex = 6
            AddHandler Me.ceAllowCustomDraw.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowCustomDraw_CheckedChanged)
            ' 
            ' gaugeControl2
            ' 
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
            Me.gaugeControl2.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gaugeControl2.Location = New System.Drawing.Point(302, 36)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(287, 432)
            Me.gaugeControl2.TabIndex = 5
            ' 
            ' linearGauge1
            ' 
            Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.linearScaleBackgroundLayer})
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(25, 25, 237, 382)
            Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.linearScaleLevel})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScale})
            ' 
            ' linearScaleBackgroundLayer
            ' 
            Me.linearScaleBackgroundLayer.LinearScale = Me.linearScale
            Me.linearScaleBackgroundLayer.Name = "Gauge0_BackgroundLayer1"
            Me.linearScaleBackgroundLayer.ZOrder = 1000
            ' 
            ' linearScale
            ' 
            Me.linearScale.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScale.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScale.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScale.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScale.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.linearScale.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 35F)
            Me.linearScale.MajorTickCount = 6
            Me.linearScale.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScale.MajorTickmark.ShapeOffset = -20F
            Me.linearScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_1
            Me.linearScale.MajorTickmark.TextOffset = -32F
            Me.linearScale.MaxValue = 100F
            Me.linearScale.MinorTickCount = 4
            Me.linearScale.MinorTickmark.ShapeOffset = -14F
            Me.linearScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style1_2
            Me.linearScale.Name = "Gauge0_Scale1"
            Me.linearScale.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 215F)
            ' 
            ' linearScaleLevel
            ' 
            Me.linearScaleLevel.LinearScale = Me.linearScale
            Me.linearScaleLevel.Name = "Gauge0_Level1"
            Me.linearScaleLevel.ZOrder = -50
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(25)
            Me.gaugeControl1.Location = New System.Drawing.Point(12, 36)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(286, 432)
            Me.gaugeControl1.TabIndex = 4
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayer})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(25, 25, 236, 382)
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedle})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScale})
            ' 
            ' arcScaleBackgroundLayer
            ' 
            Me.arcScaleBackgroundLayer.ArcScale = Me.arcScale
            Me.arcScaleBackgroundLayer.Name = "Gauge0_BackgroundLayer1"
            Me.arcScaleBackgroundLayer.ZOrder = 1000
            ' 
            ' arcScale
            ' 
            Me.arcScale.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScale.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScale.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScale.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScale.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.arcScale.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.arcScale.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScale.EndAngle = 60F
            Me.arcScale.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScale.MajorTickmark.ShapeOffset = -3.5F
            Me.arcScale.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
            Me.arcScale.MajorTickmark.TextOffset = -15F
            Me.arcScale.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScale.MaxValue = 100F
            Me.arcScale.MinorTickCount = 4
            Me.arcScale.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
            Me.arcScale.Name = "Gauge0_Scale1"
            Me.arcScale.StartAngle = -240F
            Me.arcScale.Value = 50F
            ' 
            ' arcScaleNeedle
            ' 
            Me.arcScaleNeedle.ArcScale = Me.arcScale
            Me.arcScaleNeedle.Name = "Gauge0_Needle1"
            Me.arcScaleNeedle.StartOffset = -4.4F
            Me.arcScaleNeedle.ZOrder = -50
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 480)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(290, 436)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gaugeControl2
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(290, 24)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(291, 436)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceAllowCustomDraw
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(581, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' CustomDrawFeature
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "CustomDrawFeature"
            Me.Size = New System.Drawing.Size(601, 480)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceAllowCustomDraw.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleBackgroundLayer), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScale), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleLevel), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayer), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScale), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleBackgroundLayer As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent

        Private linearScale As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private linearScaleLevel As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayer As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScale As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedle As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private ceAllowCustomDraw As DevExpress.XtraEditors.CheckEdit

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
