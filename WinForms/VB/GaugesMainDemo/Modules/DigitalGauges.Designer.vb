Namespace DevExpress.XtraGauges.Demos

    Partial Class DigitalGauges

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
            Me.gaugeControl4 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge4 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl3 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.digitalGauge4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.gaugeControl4)
            Me.layoutControl1.Controls.Add(Me.gaugeControl3)
            Me.layoutControl1.Controls.Add(Me.gaugeControl2)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(764, 497)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' gaugeControl4
            ' 
            Me.gaugeControl4.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge4})
            Me.gaugeControl4.Location = New System.Drawing.Point(181, 344)
            Me.gaugeControl4.MaximumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl4.MinimumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl4.Name = "gaugeControl4"
            Me.gaugeControl4.Size = New System.Drawing.Size(581, 110)
            Me.gaugeControl4.TabIndex = 6
            ' 
            ' digitalGauge4
            ' 
            Me.digitalGauge4.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge4.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge4.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent4})
            Me.digitalGauge4.Bounds = New System.Drawing.Rectangle(6, 6, 569, 98)
            Me.digitalGauge4.DigitCount = 21
            Me.digitalGauge4.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.Matrix8x14
            Me.digitalGauge4.Name = "digitalGauge4"
            Me.digitalGauge4.Text = "All Symbols ... (√°←)"
            ' 
            ' digitalBackgroundLayerComponent4
            ' 
            Me.digitalBackgroundLayerComponent4.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(1028F, 124F)
            Me.digitalBackgroundLayerComponent4.Name = "digitalBackgroundLayerComponent7"
            Me.digitalBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent4.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent4.ZOrder = 1000
            ' 
            ' gaugeControl3
            ' 
            Me.gaugeControl3.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge3})
            Me.gaugeControl3.Location = New System.Drawing.Point(181, 230)
            Me.gaugeControl3.MaximumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl3.MinimumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl3.Name = "gaugeControl3"
            Me.gaugeControl3.Size = New System.Drawing.Size(581, 110)
            Me.gaugeControl3.TabIndex = 5
            ' 
            ' digitalGauge3
            ' 
            Me.digitalGauge3.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge3.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge3.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent3})
            Me.digitalGauge3.Bounds = New System.Drawing.Rectangle(6, 6, 569, 98)
            Me.digitalGauge3.DigitCount = 18
            Me.digitalGauge3.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.Matrix5x8
            Me.digitalGauge3.Name = "digitalGauge3"
            Me.digitalGauge3.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(40, 25, 40, 25)
            Me.digitalGauge3.Text = "+123 ABC abc  @-}-"
            ' 
            ' digitalBackgroundLayerComponent3
            ' 
            Me.digitalBackgroundLayerComponent3.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(580F, 98F)
            Me.digitalBackgroundLayerComponent3.Name = "digitalBackgroundLayerComponent7"
            Me.digitalBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent3.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(40F, 0F)
            Me.digitalBackgroundLayerComponent3.ZOrder = 1000
            ' 
            ' gaugeControl2
            ' 
            Me.gaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge2})
            Me.gaugeControl2.Location = New System.Drawing.Point(181, 116)
            Me.gaugeControl2.MaximumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl2.MinimumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl2.Name = "gaugeControl2"
            Me.gaugeControl2.Size = New System.Drawing.Size(581, 110)
            Me.gaugeControl2.TabIndex = 4
            ' 
            ' digitalGauge2
            ' 
            Me.digitalGauge2.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge2.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge2.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent2})
            Me.digitalGauge2.Bounds = New System.Drawing.Rectangle(6, 6, 569, 98)
            Me.digitalGauge2.DigitCount = 8
            Me.digitalGauge2.Name = "digitalGauge2"
            Me.digitalGauge2.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(50, 25, 50, 25)
            Me.digitalGauge2.Text = "+12.3 ABC"
            ' 
            ' digitalBackgroundLayerComponent2
            ' 
            Me.digitalBackgroundLayerComponent2.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(433.7F, 109.9625F)
            Me.digitalBackgroundLayerComponent2.Name = "digitalBackgroundLayerComponent7"
            Me.digitalBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent2.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(50F, 0F)
            Me.digitalBackgroundLayerComponent2.ZOrder = 1000
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(181, 2)
            Me.gaugeControl1.MaximumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl1.MinimumSize = New System.Drawing.Size(0, 110)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(581, 110)
            Me.gaugeControl1.TabIndex = 0
            ' 
            ' digitalGauge1
            ' 
            Me.digitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#00FFFFFF")
            Me.digitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:WhiteSmoke")
            Me.digitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 569, 98)
            Me.digitalGauge1.DigitCount = 5
            Me.digitalGauge1.DisplayMode = DevExpress.XtraGauges.Core.Model.DigitalGaugeDisplayMode.SevenSegment
            Me.digitalGauge1.Name = "digitalGauge1"
            Me.digitalGauge1.Padding = New DevExpress.XtraGauges.Core.Base.TextSpacing(25, 25, 25, 25)
            Me.digitalGauge1.Text = "1'234,5"
            ' 
            ' digitalBackgroundLayerComponent1
            ' 
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(256.375F, 116.075F)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent7"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style7
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(25F, 0F)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(764, 497)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(764, 114)
            Me.layoutControlItem1.Text = "1) Digits"
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(167, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.gaugeControl2
            Me.layoutControlItem2.CustomizationFormText = "Digits,Signs and latin Capital Letters"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 114)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(764, 114)
            Me.layoutControlItem2.Text = "2) Digits,Signs and Capital Letters"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(167, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.gaugeControl3
            Me.layoutControlItem3.CustomizationFormText = "Digits, some symbols and letters"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 228)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(764, 114)
            Me.layoutControlItem3.Text = "3) Digits, some symbols and letters"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(167, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.gaugeControl4
            Me.layoutControlItem4.CustomizationFormText = "All symbols"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 342)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(764, 155)
            Me.layoutControlItem4.Text = "4) All Font symbols"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(167, 13)
            ' 
            ' DigitalGauges
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "DigitalGauges"
            Me.Padding = New System.Windows.Forms.Padding(0, 8, 0, 8)
            Me.Size = New System.Drawing.Size(764, 513)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.digitalGauge4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private gaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private gaugeControl4 As DevExpress.XtraGauges.Win.GaugeControl

        Private gaugeControl3 As DevExpress.XtraGauges.Win.GaugeControl

        Private digitalGauge3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private digitalGauge4 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private digitalBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent
    End Class
End Namespace
