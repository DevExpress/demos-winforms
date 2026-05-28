Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleCalcEdit

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing Then
                If Me.components IsNot Nothing Then
                    Me.components.Dispose()
                End If
            End If

            MyBase.Dispose(disposing)
        End Sub

#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim editorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim editorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim serializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Dim serializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceShowCustomButtons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.sePrecision = New DevExpress.XtraEditors.SpinEdit()
            Me.calcEditSample = New DevExpress.XtraEditors.CalcEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceShowCustomButtons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowCloseButton.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.sePrecision.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.calcEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceShowCustomButtons)
            Me.layoutControl1.Controls.Add(Me.ceShowCloseButton)
            Me.layoutControl1.Controls.Add(Me.sePrecision)
            Me.layoutControl1.Controls.Add(Me.calcEditSample)
            Me.layoutControl1.Location = New System.Drawing.Point(25, 44)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1046, 136, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(487, 235)
            Me.layoutControl1.TabIndex = 4
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceShowCustomButtons
            ' 
            Me.ceShowCustomButtons.Location = New System.Drawing.Point(320, 184)
            Me.ceShowCustomButtons.Name = "ceShowCustomButtons"
            Me.ceShowCustomButtons.Properties.Caption = "Show custom buttons"
            Me.ceShowCustomButtons.Size = New System.Drawing.Size(176, 20)
            Me.ceShowCustomButtons.StyleController = Me.layoutControl1
            Me.ceShowCustomButtons.TabIndex = 0
            AddHandler Me.ceShowCustomButtons.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowCustomButtons_CheckedChanged)
            ' 
            ' ceShowCloseButton
            ' 
            Me.ceShowCloseButton.Location = New System.Drawing.Point(320, 81)
            Me.ceShowCloseButton.Name = "ceShowCloseButton"
            Me.ceShowCloseButton.Properties.Caption = "Show Close button"
            Me.ceShowCloseButton.Size = New System.Drawing.Size(176, 20)
            Me.ceShowCloseButton.StyleController = Me.layoutControl1
            Me.ceShowCloseButton.TabIndex = 14
            AddHandler Me.ceShowCloseButton.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowCloseButton_CheckedChanged)
            ' 
            ' sePrecision
            ' 
            Me.sePrecision.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.sePrecision.Location = New System.Drawing.Point(378, 53)
            Me.sePrecision.Name = "sePrecision"
            Me.sePrecision.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.sePrecision.Properties.IsFloatValue = False
            Me.sePrecision.Properties.Mask.EditMask = "N00"
            Me.sePrecision.Properties.MaxValue = New Decimal(New Integer() {28, 0, 0, 0})
            Me.sePrecision.Size = New System.Drawing.Size(118, 20)
            Me.sePrecision.StyleController = Me.layoutControl1
            Me.sePrecision.TabIndex = 13
            AddHandler Me.sePrecision.EditValueChanged, New System.EventHandler(AddressOf Me.sePrecision_EditValueChanged)
            ' 
            ' calcEditSample
            ' 
            Me.calcEditSample.EditValue = New Decimal(New Integer() {22, 0, 0, 65536})
            Me.calcEditSample.Location = New System.Drawing.Point(32, 117)
            Me.calcEditSample.Name = "calcEditSample"
            editorButtonImageOptions1.EnableTransparency = False
            editorButtonImageOptions2.EnableTransparency = False
            Me.calcEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Clear", -1, True, True, False, editorButtonImageOptions1, New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.C)), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "clear", Nothing, DevExpress.Utils.ToolTipAnchor.[Default]), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "^2", -1, True, True, True, editorButtonImageOptions2, New DevExpress.Utils.KeyShortcut((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.D2)), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "involution2", Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.calcEditSample.Size = New System.Drawing.Size(216, 22)
            Me.calcEditSample.StyleController = Me.layoutControl1
            Me.calcEditSample.TabIndex = 0
            AddHandler Me.calcEditSample.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.calcEditSample_ButtonClick)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(528, 237)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(288, 217)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.calcEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(151, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(220, 155)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 155)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(288, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(220, 131)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.sePrecision
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(180, 26)
            Me.layoutControlItem2.Text = "Precision:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(46, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceShowCloseButton
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem3.Size = New System.Drawing.Size(180, 26)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.emptySpaceItem2})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(288, 131)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(220, 86)
            Me.layoutControlGroup4.Text = "Custom buttons"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceShowCustomButtons
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Size = New System.Drawing.Size(180, 24)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(180, 1)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(180, 1)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleCalcEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleCalcEdit"
            Me.Size = New System.Drawing.Size(815, 507)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleCalcEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceShowCustomButtons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowCloseButton.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.sePrecision.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.calcEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private calcEditSample As DevExpress.XtraEditors.CalcEdit

        Private sePrecision As DevExpress.XtraEditors.SpinEdit

        Private ceShowCloseButton As DevExpress.XtraEditors.CheckEdit

        Private ceShowCustomButtons As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
