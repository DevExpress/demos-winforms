Namespace DevExpress.XtraGauges.Demos

    Partial Class InteractionFeature

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge12 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent()
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge12 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.linearGauge12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.circularGauge12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
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
            ' gaugeControl2
            ' 
            Me.gaugeControl2.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge12})
            Me.gaugeControl2.Location = New System.Drawing.Point(312, 12)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(277, 456)
            Me.gaugeControl2.TabIndex = 5
            AddHandler Me.gaugeControl2.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gaugeControl2_MouseDown)
            AddHandler Me.gaugeControl2.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gaugeControl2_MouseMove)
            ' 
            ' linearGauge12
            ' 
            Me.linearGauge12.AutoSize = DevExpress.Utils.DefaultBoolean.[False]
            Me.linearGauge12.Bounds = New System.Drawing.Rectangle(6, 6, 265, 444)
            Me.linearGauge12.Name = "linearGauge12"
            Me.linearGauge12.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent() {Me.linearScaleRangeBarComponent1})
            Me.linearGauge12.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.linearScaleComponent1})
            ' 
            ' linearScaleRangeBarComponent1
            ' 
            Me.linearScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#E73141")
            Me.linearScaleRangeBarComponent1.EndOffset = 1F
            Me.linearScaleRangeBarComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleRangeBarComponent1.Name = "linearGauge2_RangeBar1"
            Me.linearScaleRangeBarComponent1.StartOffset = -1F
            Me.linearScaleRangeBarComponent1.ZOrder = -100
            ' 
            ' linearScaleComponent1
            ' 
            Me.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceScale.Brush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.linearScaleComponent1.AppearanceScale.Width = 4F
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 20F)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -7F
            Me.linearScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(1.1F, 1F)
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.linearScaleComponent1.MajorTickmark.TextOffset = -20F
            Me.linearScaleComponent1.MaxValue = 100F
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -14F
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.linearScaleComponent1.MinorTickmark.ShowTick = False
            Me.linearScaleComponent1.Name = "scale2"
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 230F)
            Me.linearScaleComponent1.Value = 20F
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge12})
            Me.gaugeControl1.Location = New System.Drawing.Point(12, 12)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(276, 456)
            Me.gaugeControl1.TabIndex = 4
            AddHandler Me.gaugeControl1.MouseDown, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gaugeControl1_MouseDown)
            AddHandler Me.gaugeControl1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.gaugeControl1_MouseMove)
            ' 
            ' circularGauge12
            ' 
            Me.circularGauge12.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge12.Bounds = New System.Drawing.Rectangle(6, 6, 264, 444)
            Me.circularGauge12.Name = "circularGauge12"
            Me.circularGauge12.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1})
            Me.circularGauge12.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            ' 
            ' arcScaleBackgroundLayerComponent1
            ' 
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleBackgroundLayerComponent1.Name = "bg"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style27
            Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(200F, 200F)
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 10F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#999999")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent1.EndAngle = 60F
            Me.arcScaleComponent1.MajorTickmark.AllowTickOverlap = True
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -2F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScaleComponent1.MajorTickmark.TextOffset = 18F
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 100F
            Me.arcScaleComponent1.MinorTickCount = 4
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = 4F
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style27_1
            Me.arcScaleComponent1.MinorTickmark.ShowTick = False
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.StartAngle = -240F
            Me.arcScaleComponent1.Value = 50F
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleNeedleComponent1.EndOffset = 8F
            Me.arcScaleNeedleComponent1.Name = "needle"
            Me.arcScaleNeedleComponent1.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:Red;Style2:Red]")
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style27
            Me.arcScaleNeedleComponent1.StartOffset = -6F
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(601, 480)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12)
            Me.layoutControlItem1.Size = New System.Drawing.Size(300, 480)
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gaugeControl2
            Me.layoutControlItem2.CustomizationFormText = "layoutControlItem2"
            Me.layoutControlItem2.Location = New System.Drawing.Point(300, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(12, 12, 12, 12)
            Me.layoutControlItem2.Size = New System.Drawing.Size(301, 480)
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' InteractionFeature
            ' 
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "InteractionFeature"
            Me.Size = New System.Drawing.Size(601, 480)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.linearGauge12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.linearScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.circularGauge12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private linearGauge12 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge

        Private linearScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleRangeBarComponent

        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent

        Private circularGauge12 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    End Class
End Namespace
