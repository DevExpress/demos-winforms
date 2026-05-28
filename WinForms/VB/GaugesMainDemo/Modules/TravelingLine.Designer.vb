Namespace DevExpress.XtraGauges.Demos

    Partial Class TravelingLine

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.layoutControl2 = New DevExpress.XtraLayout.LayoutControl()
            Me.travelingSpeed = New DevExpress.XtraEditors.TrackBarControl()
            Me.travelingText = New DevExpress.XtraEditors.TextEdit()
            Me.cbDirection = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.digitalGauge1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge()
            Me.digitalBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.timer = New System.Windows.Forms.Timer(Me.components)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl2.SuspendLayout()
            CType((Me.travelingSpeed), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.travelingSpeed.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.travelingText.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbDirection.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            Me.layoutControl1.Controls.Add(Me.gaugeControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(623, 404)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Controls.Add(Me.layoutControl2)
            Me.panelControl1.Location = New System.Drawing.Point(0, 304)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(623, 95)
            Me.panelControl1.TabIndex = 8
            ' 
            ' layoutControl2
            ' 
            Me.layoutControl2.Controls.Add(Me.travelingSpeed)
            Me.layoutControl2.Controls.Add(Me.travelingText)
            Me.layoutControl2.Controls.Add(Me.cbDirection)
            Me.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl2.Location = New System.Drawing.Point(2, 2)
            Me.layoutControl2.Name = "layoutControl2"
            Me.layoutControl2.Root = Me.layoutControlGroup2
            Me.layoutControl2.Size = New System.Drawing.Size(619, 91)
            Me.layoutControl2.TabIndex = 8
            Me.layoutControl2.Text = "layoutControl2"
            ' 
            ' travelingSpeed
            ' 
            Me.travelingSpeed.EditValue = Nothing
            Me.travelingSpeed.Location = New System.Drawing.Point(74, 5)
            Me.travelingSpeed.MaximumSize = New System.Drawing.Size(0, 35)
            Me.travelingSpeed.MinimumSize = New System.Drawing.Size(0, 35)
            Me.travelingSpeed.Name = "travelingSpeed"
            Me.travelingSpeed.Size = New System.Drawing.Size(230, 35)
            Me.travelingSpeed.StyleController = Me.layoutControl2
            Me.travelingSpeed.TabIndex = 7
            AddHandler Me.travelingSpeed.ValueChanged, New System.EventHandler(AddressOf Me.OnTravelingSpeedChanged)
            ' 
            ' travelingText
            ' 
            Me.travelingText.EditValue = "If you don't know where you are going, any road will take you there. "
            Me.travelingText.Location = New System.Drawing.Point(74, 58)
            Me.travelingText.Name = "travelingText"
            Me.travelingText.Size = New System.Drawing.Size(529, 20)
            Me.travelingText.StyleController = Me.layoutControl2
            Me.travelingText.TabIndex = 5
            AddHandler Me.travelingText.EditValueChanged, New System.EventHandler(AddressOf Me.OnTravelingTextChanged)
            ' 
            ' cbDirection
            ' 
            Me.cbDirection.EditValue = "Left"
            Me.cbDirection.Location = New System.Drawing.Point(383, 10)
            Me.cbDirection.Name = "cbDirection"
            Me.cbDirection.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbDirection.Properties.Items.AddRange(New Object() {"Left", "Right"})
            Me.cbDirection.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbDirection.Size = New System.Drawing.Size(220, 20)
            Me.cbDirection.StyleController = Me.layoutControl2
            Me.cbDirection.TabIndex = 6
            AddHandler Me.cbDirection.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnDirectionChanged)
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.AllowDrawBackground = False
            Me.layoutControlGroup2.CustomizationFormText = "layoutControlGroup2"
            Me.layoutControlGroup2.GroupBordersVisible = False
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem3})
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(619, 91)
            Me.layoutControlGroup2.TextVisible = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.travelingSpeed
            Me.layoutControlItem2.CustomizationFormText = "Speed:"
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 5, 5, 5)
            Me.layoutControlItem2.Size = New System.Drawing.Size(309, 55)
            Me.layoutControlItem2.Text = "Speed:"
            Me.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(46, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.travelingText
            Me.layoutControlItem4.CustomizationFormText = "Text:"
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 55)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 3, 3)
            Me.layoutControlItem4.Size = New System.Drawing.Size(619, 36)
            Me.layoutControlItem4.Text = "Text:"
            Me.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(46, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.cbDirection
            Me.layoutControlItem3.CustomizationFormText = "Direction:"
            Me.layoutControlItem3.Location = New System.Drawing.Point(309, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 10, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(310, 55)
            Me.layoutControlItem3.Text = "Direction:"
            Me.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(46, 13)
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.BackColor = System.Drawing.Color.Transparent
            Me.gaugeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.digitalGauge1})
            Me.gaugeControl1.LayoutPadding = New DevExpress.XtraGauges.Core.Base.Thickness(10)
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Margin = New System.Windows.Forms.Padding(0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(623, 291)
            Me.gaugeControl1.TabIndex = 4
            ' 
            ' digitalGauge1
            ' 
            Me.digitalGauge1.AppearanceOff.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#0A151A")
            Me.digitalGauge1.AppearanceOn.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#289FB8")
            Me.digitalGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent() {Me.digitalBackgroundLayerComponent1})
            Me.digitalGauge1.Bounds = New System.Drawing.Rectangle(10, 10, 603, 271)
            Me.digitalGauge1.DigitCount = 18
            Me.digitalGauge1.Name = "digitalGauge1"
            Me.digitalGauge1.Text = ""
            ' 
            ' digitalBackgroundLayerComponent1
            ' 
            Me.digitalBackgroundLayerComponent1.BottomRight = New DevExpress.XtraGauges.Core.Base.PointF2D(883.3251F, 99.9625F)
            Me.digitalBackgroundLayerComponent1.Name = "digitalBackgroundLayerComponent1"
            Me.digitalBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.DigitalBackgroundShapeSetType.Style21
            Me.digitalBackgroundLayerComponent1.TopLeft = New DevExpress.XtraGauges.Core.Base.PointF2D(20F, 0F)
            Me.digitalBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.AllowDrawBackground = False
            Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem5})
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(623, 404)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.gaugeControl1
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 8)
            Me.layoutControlItem1.Size = New System.Drawing.Size(623, 299)
            Me.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.panelControl1
            Me.layoutControlItem5.CustomizationFormText = "layoutControlItem5"
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 299)
            Me.layoutControlItem5.MaxSize = New System.Drawing.Size(0, 105)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(101, 105)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 5, 5)
            Me.layoutControlItem5.Size = New System.Drawing.Size(623, 105)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' timer
            ' 
            AddHandler Me.timer.Tick, New System.EventHandler(AddressOf Me.OnTimerTick)
            ' 
            ' TravelingLine
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "TravelingLine"
            Me.Size = New System.Drawing.Size(623, 404)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.layoutControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl2.ResumeLayout(False)
            CType((Me.travelingSpeed.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.travelingSpeed), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.travelingText.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbDirection.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalGauge1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.digitalBackgroundLayerComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private travelingSpeed As DevExpress.XtraEditors.TrackBarControl

        Private cbDirection As DevExpress.XtraEditors.ComboBoxEdit

        Private travelingText As DevExpress.XtraEditors.TextEdit

        Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private digitalGauge1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalGauge

        Private digitalBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Digital.DigitalBackgroundLayerComponent

        Private timer As System.Windows.Forms.Timer

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private layoutControl2 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    End Class
End Namespace
