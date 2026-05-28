Namespace DevExpress.HTML.Demos

    Partial Class AlertControlProperties

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
            Me.icbShowingEffect = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.icbFormLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seFormMaxCount = New DevExpress.XtraEditors.SpinEdit()
            Me.seAutoFormDelay = New DevExpress.XtraEditors.SpinEdit()
            Me.icbFormDisplaySpeed = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.autoFormDelayItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.formDisplaySpeedItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.formLocationItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.formShowingEffectItem = New DevExpress.XtraLayout.LayoutControlItem()
            Me.formMaxCountItem = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbShowingEffect.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbFormLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seFormMaxCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seAutoFormDelay.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbFormDisplaySpeed.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.autoFormDelayItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.formDisplaySpeedItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.formLocationItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.formShowingEffectItem), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.formMaxCountItem), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.icbShowingEffect)
            Me.layoutControl1.Controls.Add(Me.icbFormLocation)
            Me.layoutControl1.Controls.Add(Me.seFormMaxCount)
            Me.layoutControl1.Controls.Add(Me.seAutoFormDelay)
            Me.layoutControl1.Controls.Add(Me.icbFormDisplaySpeed)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(564, 347, 1137, 700)
            Me.layoutControl1.Root = Me.Root
            Me.layoutControl1.Size = New System.Drawing.Size(272, 177)
            Me.layoutControl1.TabIndex = 20
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbShowingEffect
            ' 
            Me.icbShowingEffect.Location = New System.Drawing.Point(113, 40)
            Me.icbShowingEffect.Name = "icbShowingEffect"
            Me.icbShowingEffect.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowingEffect.Size = New System.Drawing.Size(140, 20)
            Me.icbShowingEffect.StyleController = Me.layoutControl1
            Me.icbShowingEffect.TabIndex = 4
            AddHandler Me.icbShowingEffect.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowingEffect_SelectedIndexChanged)
            ' 
            ' icbFormLocation
            ' 
            Me.icbFormLocation.Location = New System.Drawing.Point(113, 18)
            Me.icbFormLocation.Name = "icbFormLocation"
            Me.icbFormLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbFormLocation.Size = New System.Drawing.Size(140, 20)
            Me.icbFormLocation.StyleController = Me.layoutControl1
            Me.icbFormLocation.TabIndex = 3
            AddHandler Me.icbFormLocation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbFormLocation_SelectedIndexChanged)
            ' 
            ' seFormMaxCount
            ' 
            Me.seFormMaxCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seFormMaxCount.Location = New System.Drawing.Point(113, 106)
            Me.seFormMaxCount.Name = "seFormMaxCount"
            Me.seFormMaxCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seFormMaxCount.Properties.IsFloatValue = False
            Me.seFormMaxCount.Properties.MaskSettings.[Set]("mask", "N00")
            Me.seFormMaxCount.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seFormMaxCount.Size = New System.Drawing.Size(140, 20)
            Me.seFormMaxCount.StyleController = Me.layoutControl1
            Me.seFormMaxCount.TabIndex = 6
            AddHandler Me.seFormMaxCount.EditValueChanged, New System.EventHandler(AddressOf Me.seFormMaxCount_EditValueChanged)
            ' 
            ' seAutoFormDelay
            ' 
            Me.seAutoFormDelay.EditValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seAutoFormDelay.Location = New System.Drawing.Point(113, 84)
            Me.seAutoFormDelay.Name = "seAutoFormDelay"
            Me.seAutoFormDelay.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seAutoFormDelay.Properties.IsFloatValue = False
            Me.seAutoFormDelay.Properties.MaskSettings.[Set]("mask", "N00")
            Me.seAutoFormDelay.Properties.MaxValue = New Decimal(New Integer() {100000, 0, 0, 0})
            Me.seAutoFormDelay.Properties.MinValue = New Decimal(New Integer() {1000, 0, 0, 0})
            Me.seAutoFormDelay.Size = New System.Drawing.Size(140, 20)
            Me.seAutoFormDelay.StyleController = Me.layoutControl1
            Me.seAutoFormDelay.TabIndex = 0
            AddHandler Me.seAutoFormDelay.EditValueChanged, New System.EventHandler(AddressOf Me.seAutoFormDelay_EditValueChanged)
            ' 
            ' icbFormDisplaySpeed
            ' 
            Me.icbFormDisplaySpeed.Location = New System.Drawing.Point(113, 62)
            Me.icbFormDisplaySpeed.Name = "icbFormDisplaySpeed"
            Me.icbFormDisplaySpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbFormDisplaySpeed.Size = New System.Drawing.Size(140, 20)
            Me.icbFormDisplaySpeed.StyleController = Me.layoutControl1
            Me.icbFormDisplaySpeed.TabIndex = 2
            AddHandler Me.icbFormDisplaySpeed.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbFormDisplaySpeed_SelectedIndexChanged)
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.formDisplaySpeedItem, Me.formMaxCountItem, Me.formShowingEffectItem, Me.formLocationItem, Me.autoFormDelayItem})
            Me.Root.Name = "Root"
            Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(18, 18, 17, 17)
            Me.Root.Size = New System.Drawing.Size(272, 177)
            Me.Root.TextVisible = False
            ' 
            ' autoFormDelayItem
            ' 
            Me.autoFormDelayItem.Control = Me.seAutoFormDelay
            Me.autoFormDelayItem.Location = New System.Drawing.Point(0, 66)
            Me.autoFormDelayItem.Name = "autoFormDelayItem"
            Me.autoFormDelayItem.Size = New System.Drawing.Size(236, 22)
            Me.autoFormDelayItem.Text = "Delay:"
            Me.autoFormDelayItem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' formDisplaySpeedItem
            ' 
            Me.formDisplaySpeedItem.Control = Me.icbFormDisplaySpeed
            Me.formDisplaySpeedItem.Location = New System.Drawing.Point(0, 44)
            Me.formDisplaySpeedItem.Name = "formDisplaySpeedItem"
            Me.formDisplaySpeedItem.Size = New System.Drawing.Size(236, 22)
            Me.formDisplaySpeedItem.Text = "Animation Speed:"
            Me.formDisplaySpeedItem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' formLocationItem
            ' 
            Me.formLocationItem.Control = Me.icbFormLocation
            Me.formLocationItem.Location = New System.Drawing.Point(0, 0)
            Me.formLocationItem.Name = "formLocationItem"
            Me.formLocationItem.Size = New System.Drawing.Size(236, 22)
            Me.formLocationItem.Text = "Location:"
            Me.formLocationItem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' formShowingEffectItem
            ' 
            Me.formShowingEffectItem.Control = Me.icbShowingEffect
            Me.formShowingEffectItem.Location = New System.Drawing.Point(0, 22)
            Me.formShowingEffectItem.Name = "formShowingEffectItem"
            Me.formShowingEffectItem.Size = New System.Drawing.Size(236, 22)
            Me.formShowingEffectItem.Text = "Animation:"
            Me.formShowingEffectItem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' formMaxCountItem
            ' 
            Me.formMaxCountItem.Control = Me.seFormMaxCount
            Me.formMaxCountItem.Location = New System.Drawing.Point(0, 88)
            Me.formMaxCountItem.Name = "formMaxCountItem"
            Me.formMaxCountItem.Size = New System.Drawing.Size(236, 55)
            Me.formMaxCountItem.Text = "Alerts Max Count:"
            Me.formMaxCountItem.TextSize = New System.Drawing.Size(87, 13)
            ' 
            ' AlertControlProperties
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "AlertControlProperties"
            Me.Size = New System.Drawing.Size(272, 177)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbShowingEffect.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbFormLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seFormMaxCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seAutoFormDelay.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbFormDisplaySpeed.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.autoFormDelayItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.formDisplaySpeedItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.formLocationItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.formShowingEffectItem), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.formMaxCountItem), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private seAutoFormDelay As DevExpress.XtraEditors.SpinEdit

        Private icbFormDisplaySpeed As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbFormLocation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private icbShowingEffect As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seFormMaxCount As DevExpress.XtraEditors.SpinEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private autoFormDelayItem As DevExpress.XtraLayout.LayoutControlItem

        Private formDisplaySpeedItem As DevExpress.XtraLayout.LayoutControlItem

        Private formLocationItem As DevExpress.XtraLayout.LayoutControlItem

        Private formShowingEffectItem As DevExpress.XtraLayout.LayoutControlItem

        Private formMaxCountItem As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
