Namespace DevExpress.XtraGauges.Demos

    Partial Class AnalogClock

        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                Me.lockTimerCounter += 1
                If Me.timer IsNot Nothing Then
                    Me.timer.[Stop]()
                    Me.timer.Dispose()
                    Me.timer = Nothing
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Component Designer generated code"
        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
            Me.scaleHours = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent()
            Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
            Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.scaleHours), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' timer
            ' 
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(438, 403)
            Me.gaugeControl1.TabIndex = 0
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 426, 391)
            Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent1})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.scaleHours})
            Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent1})
            ' 
            ' arcScaleBackgroundLayerComponent1
            ' 
            Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.scaleHours
            Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
            Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Clock
            Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' scaleHours
            ' 
            Me.scaleHours.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scaleHours.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scaleHours.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scaleHours.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.scaleHours.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 11F)
            Me.scaleHours.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
            Me.scaleHours.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.scaleHours.EndAngle = 270F
            Me.scaleHours.MajorTickCount = 13
            Me.scaleHours.MajorTickmark.FormatString = "{0:F0}"
            Me.scaleHours.MajorTickmark.ShapeOffset = -4F
            Me.scaleHours.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_2
            Me.scaleHours.MajorTickmark.ShowFirst = False
            Me.scaleHours.MajorTickmark.TextOffset = -15F
            Me.scaleHours.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.scaleHours.MaxValue = 12F
            Me.scaleHours.MinorTickCount = 4
            Me.scaleHours.MinorTickmark.ShapeOffset = -0.5F
            Me.scaleHours.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_1
            Me.scaleHours.Name = "arcScaleComponent1"
            Me.scaleHours.RadiusX = 90F
            Me.scaleHours.RadiusY = 90F
            Me.scaleHours.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:#404040;Style2:Gray]")
            Me.scaleHours.StartAngle = -90F
            ' 
            ' arcScaleEffectLayerComponent1
            ' 
            Me.arcScaleEffectLayerComponent1.ArcScale = Me.scaleHours
            Me.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent1"
            Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 1F)
            Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
            Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(210F, 105F)
            Me.arcScaleEffectLayerComponent1.ZOrder = -1000
            ' 
            ' arcScaleNeedleComponent1
            ' 
            Me.arcScaleNeedleComponent1.ArcScale = Me.scaleHours
            Me.arcScaleNeedleComponent1.EndOffset = 20F
            Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
            Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
            Me.arcScaleNeedleComponent1.ZOrder = -50
            ' 
            ' arcScaleNeedleComponent2
            ' 
            Me.arcScaleNeedleComponent2.ArcScale = Me.scaleHours
            Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
            Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
            Me.arcScaleNeedleComponent2.ZOrder = -49
            ' 
            ' arcScaleNeedleComponent3
            ' 
            Me.arcScaleNeedleComponent3.ArcScale = Me.scaleHours
            Me.arcScaleNeedleComponent3.EndOffset = -10F
            Me.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3"
            Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
            Me.arcScaleNeedleComponent3.ZOrder = -101
            ' 
            ' arcScaleSpindleCapComponent1
            ' 
            Me.arcScaleSpindleCapComponent1.ArcScale = Me.scaleHours
            Me.arcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent1"
            Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
            Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(20F, 20F)
            Me.arcScaleSpindleCapComponent1.ZOrder = -100
            ' 
            ' AnalogClock
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gaugeControl1)
            Me.Name = "AnalogClock"
            Me.Size = New System.Drawing.Size(438, 403)
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.scaleHours), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleEffectLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleNeedleComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleSpindleCapComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent

        Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent

        Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private timer As System.Windows.Forms.Timer

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent

        Private scaleHours As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent

        Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent

        Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    End Class
End Namespace
