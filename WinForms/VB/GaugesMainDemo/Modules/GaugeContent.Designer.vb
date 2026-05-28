Namespace DevExpress.XtraGauges.Demos

    Partial Class GaugeContent

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraGauges.Demos.GaugeContent))
            Me.gaugeControl = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
            Me.imageIndicatorComponent = New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent()
            Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent()
            Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent()
            Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageIndicatorComponent), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.labelComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' gaugeControl
            ' 
            Me.gaugeControl.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl.ColorScheme.Color = System.Drawing.Color.BurlyWood
            Me.gaugeControl.ColorScheme.TargetElements = CType((((DevExpress.XtraGauges.Core.Base.TargetElement.RangeBar Or DevExpress.XtraGauges.Core.Base.TargetElement.ImageIndicator) Or DevExpress.XtraGauges.Core.Base.TargetElement.Label)), DevExpress.XtraGauges.Core.Base.TargetElement)
            Me.gaugeControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gaugeControl.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
            Me.gaugeControl.LayoutInterval = 0
            Me.gaugeControl.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(3, -3, 3, 13)
            Me.gaugeControl.Location = New System.Drawing.Point(0, 22)
            Me.gaugeControl.Margin = New System.Windows.Forms.Padding(0)
            Me.gaugeControl.Name = "gaugeControl"
            Me.gaugeControl.Size = New System.Drawing.Size(672, 415)
            Me.gaugeControl.TabIndex = 1
            ' 
            ' circularGauge1
            ' 
            Me.circularGauge1.Bounds = New System.Drawing.Rectangle(3, -3, 666, 405)
            Me.circularGauge1.Images.AddRange(New DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent() {Me.imageIndicatorComponent})
            Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent1})
            Me.circularGauge1.Name = "circularGauge1"
            Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.arcScaleRangeBarComponent1})
            Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1})
            ' 
            ' imageIndicatorComponent
            ' 
            Me.imageIndicatorComponent.Image = CType((resources.GetObject("imageIndicatorComponent.Image")), System.Drawing.Image)
            Me.imageIndicatorComponent.Name = "circularGauge1_ImageIndicator1"
            Me.imageIndicatorComponent.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(123F, 125F)
            Me.imageIndicatorComponent.ZOrder = -1001
            ' 
            ' labelComponent1
            ' 
            Me.labelComponent1.AppearanceText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 18F)
            Me.labelComponent1.Name = "circularGauge3_Label1"
            Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205F, 93F)
            Me.labelComponent1.Size = New System.Drawing.SizeF(50F, 40F)
            Me.labelComponent1.Text = "50"
            Me.labelComponent1.ZOrder = -1001
            ' 
            ' arcScaleRangeBarComponent1
            ' 
            Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent1
            Me.arcScaleRangeBarComponent1.Name = "circularGauge3_RangeBar2"
            Me.arcScaleRangeBarComponent1.RoundedCaps = True
            Me.arcScaleRangeBarComponent1.ShowBackground = True
            Me.arcScaleRangeBarComponent1.StartOffset = 79F
            Me.arcScaleRangeBarComponent1.ZOrder = -10
            ' 
            ' arcScaleComponent1
            ' 
            Me.arcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.arcScaleComponent1.AppearanceTickmarkText.DXFont = New DevExpress.Drawing.DXFont("Tahoma", 8.5F)
            Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125F, 125F)
            Me.arcScaleComponent1.EndAngle = -40F
            Me.arcScaleComponent1.MajorTickCount = 0
            Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -14F
            Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
            Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
            Me.arcScaleComponent1.MaxValue = 100F
            Me.arcScaleComponent1.MinorTickCount = 0
            Me.arcScaleComponent1.MinorTickmark.ShapeOffset = -7F
            Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
            Me.arcScaleComponent1.Name = "scale1"
            Me.arcScaleComponent1.RadiusX = 98F
            Me.arcScaleComponent1.RadiusY = 98F
            Me.arcScaleComponent1.StartAngle = -275F
            Me.arcScaleComponent1.Value = 50F
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Appearance.Options.UseTextOptions = True
            Me.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.labelControl1.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter
            Me.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.labelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.labelControl1.Location = New System.Drawing.Point(0, 0)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(672, 22)
            Me.labelControl1.TabIndex = 2
            Me.labelControl1.Text = "labelControl1"
            ' 
            ' GaugeContent
            ' 
            Me.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.gaugeControl)
            Me.Controls.Add(Me.labelControl1)
            Me.Name = "GaugeContent"
            Me.Size = New System.Drawing.Size(672, 437)
            CType((Me.circularGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageIndicatorComponent), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.labelComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleRangeBarComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.arcScaleComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private gaugeControl As DevExpress.XtraGauges.Win.GaugeControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge

        Private imageIndicatorComponent As DevExpress.XtraGauges.Win.Base.ImageIndicatorComponent

        Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent

        Private arcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent

        Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    End Class
End Namespace
