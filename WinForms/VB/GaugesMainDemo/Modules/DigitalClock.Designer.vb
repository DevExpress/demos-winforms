Namespace DevExpress.XtraGauges.Demos

    Partial Class DigitalClock

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
            Me.digitalGauge2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            CType((Me.digitalGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' timer
            ' 
            Me.timer.Interval = 500
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge2})
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(390, 300)
            Me.gaugeControl1.TabIndex = 0
            ' 
            ' digitalGauge2
            ' 
            Me.digitalGauge2.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge2.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.digitalGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 378, 288)
            Me.digitalGauge2.DigitCount = 6
            Me.digitalGauge2.Name = "digitalGauge2"
            Me.digitalGauge2.Text = "00,000"
            ' 
            ' digitalBackgroundLayerComponent1
            ' 
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(307.775F, 99.9625F)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' DigitalClock
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gaugeControl1)
            Me.Name = "DigitalClock"
            Me.Size = New System.Drawing.Size(390, 300)
            CType((Me.digitalGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private timer As System.Windows.Forms.Timer

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    End Class
End Namespace
