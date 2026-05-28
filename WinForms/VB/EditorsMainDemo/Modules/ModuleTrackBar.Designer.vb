Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleTrackBar

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.seLabelDistance = New DevExpress.XtraEditors.SpinEdit()
            Me.seTickFrequency = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowTickLabels = New DevExpress.XtraEditors.CheckEdit()
            Me.seLargeChange = New DevExpress.XtraEditors.SpinEdit()
            Me.seSmallChange = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowCustomValue = New DevExpress.XtraEditors.CheckEdit()
            Me.seMaximum = New DevExpress.XtraEditors.SpinEdit()
            Me.trackBarControl1 = New DevExpress.XtraEditors.TrackBarControl()
            Me.seMinimum = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowValue = New DevExpress.XtraEditors.CheckEdit()
            Me.icbTickStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.checkEditVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.seLabelDistance.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seTickFrequency.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowTickLabels.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seLargeChange.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seSmallChange.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowCustomValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMaximum.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMinimum.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbTickStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditVertical.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.seLabelDistance)
            Me.layoutControl1.Controls.Add(Me.seTickFrequency)
            Me.layoutControl1.Controls.Add(Me.ceShowTickLabels)
            Me.layoutControl1.Controls.Add(Me.seLargeChange)
            Me.layoutControl1.Controls.Add(Me.seSmallChange)
            Me.layoutControl1.Controls.Add(Me.ceShowCustomValue)
            Me.layoutControl1.Controls.Add(Me.seMaximum)
            Me.layoutControl1.Controls.Add(Me.trackBarControl1)
            Me.layoutControl1.Controls.Add(Me.seMinimum)
            Me.layoutControl1.Controls.Add(Me.ceShowValue)
            Me.layoutControl1.Controls.Add(Me.icbTickStyle)
            Me.layoutControl1.Controls.Add(Me.checkEditVertical)
            Me.layoutControl1.Location = New System.Drawing.Point(67, 48)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1106, 138, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(555, 412)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' seLabelDistance
            ' 
            Me.seLabelDistance.EditValue = New Decimal(New Integer() {2, 0, 0, 0})
            Me.seLabelDistance.Enabled = False
            Me.seLabelDistance.Location = New System.Drawing.Point(412, 326)
            Me.seLabelDistance.Name = "seLabelDistance"
            Me.seLabelDistance.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seLabelDistance.Properties.IsFloatValue = False
            Me.seLabelDistance.Properties.Mask.EditMask = "N00"
            Me.seLabelDistance.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.seLabelDistance.Properties.MinValue = New Decimal(New Integer() {5, 0, 0, -2147483648})
            Me.seLabelDistance.Size = New System.Drawing.Size(128, 20)
            Me.seLabelDistance.StyleController = Me.layoutControl1
            Me.seLabelDistance.TabIndex = 10
            AddHandler Me.seLabelDistance.EditValueChanged, New System.EventHandler(AddressOf Me.seLabelDistance_EditValueChanged)
            ' 
            ' seTickFrequency
            ' 
            Me.seTickFrequency.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seTickFrequency.Location = New System.Drawing.Point(412, 298)
            Me.seTickFrequency.Name = "seTickFrequency"
            Me.seTickFrequency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seTickFrequency.Properties.IsFloatValue = False
            Me.seTickFrequency.Properties.Mask.EditMask = "N00"
            Me.seTickFrequency.Size = New System.Drawing.Size(128, 20)
            Me.seTickFrequency.StyleController = Me.layoutControl1
            Me.seTickFrequency.TabIndex = 9
            AddHandler Me.seTickFrequency.EditValueChanged, New System.EventHandler(AddressOf Me.seTickFrequency_EditValueChanged)
            ' 
            ' ceShowTickLabels
            ' 
            Me.ceShowTickLabels.AllowDrop = True
            Me.ceShowTickLabels.Location = New System.Drawing.Point(324, 158)
            Me.ceShowTickLabels.Name = "ceShowTickLabels"
            Me.ceShowTickLabels.Properties.Caption = "Show Labels"
            Me.ceShowTickLabels.Size = New System.Drawing.Size(216, 20)
            Me.ceShowTickLabels.StyleController = Me.layoutControl1
            Me.ceShowTickLabels.TabIndex = 4
            AddHandler Me.ceShowTickLabels.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowTickLabels_CheckedChanged)
            ' 
            ' seLargeChange
            ' 
            Me.seLargeChange.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seLargeChange.Location = New System.Drawing.Point(412, 270)
            Me.seLargeChange.Name = "seLargeChange"
            Me.seLargeChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seLargeChange.Properties.IsFloatValue = False
            Me.seLargeChange.Properties.Mask.EditMask = "N00"
            Me.seLargeChange.Size = New System.Drawing.Size(128, 20)
            Me.seLargeChange.StyleController = Me.layoutControl1
            Me.seLargeChange.TabIndex = 8
            AddHandler Me.seLargeChange.EditValueChanged, New System.EventHandler(AddressOf Me.seLargeChange_EditValueChanged)
            ' 
            ' seSmallChange
            ' 
            Me.seSmallChange.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seSmallChange.Location = New System.Drawing.Point(412, 242)
            Me.seSmallChange.Name = "seSmallChange"
            Me.seSmallChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seSmallChange.Properties.IsFloatValue = False
            Me.seSmallChange.Properties.Mask.EditMask = "N00"
            Me.seSmallChange.Size = New System.Drawing.Size(128, 20)
            Me.seSmallChange.StyleController = Me.layoutControl1
            Me.seSmallChange.TabIndex = 7
            AddHandler Me.seSmallChange.EditValueChanged, New System.EventHandler(AddressOf Me.seSmallChange_EditValueChanged)
            ' 
            ' ceShowCustomValue
            ' 
            Me.ceShowCustomValue.EditValue = True
            Me.ceShowCustomValue.Location = New System.Drawing.Point(324, 130)
            Me.ceShowCustomValue.Name = "ceShowCustomValue"
            Me.ceShowCustomValue.Properties.Caption = "Show Custom Value"
            Me.ceShowCustomValue.Size = New System.Drawing.Size(216, 20)
            Me.ceShowCustomValue.StyleController = Me.layoutControl1
            Me.ceShowCustomValue.TabIndex = 3
            ' 
            ' seMaximum
            ' 
            Me.seMaximum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMaximum.Location = New System.Drawing.Point(412, 214)
            Me.seMaximum.Name = "seMaximum"
            Me.seMaximum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaximum.Properties.IsFloatValue = False
            Me.seMaximum.Properties.Mask.EditMask = "N00"
            Me.seMaximum.Size = New System.Drawing.Size(128, 20)
            Me.seMaximum.StyleController = Me.layoutControl1
            Me.seMaximum.TabIndex = 6
            AddHandler Me.seMaximum.EditValueChanged, New System.EventHandler(AddressOf Me.seMaximum_EditValueChanged)
            ' 
            ' trackBarControl1
            ' 
            Me.trackBarControl1.EditValue = Nothing
            Me.trackBarControl1.Location = New System.Drawing.Point(24, 185)
            Me.trackBarControl1.Name = "trackBarControl1"
            Me.trackBarControl1.Properties.LabelAppearance.Options.UseTextOptions = True
            Me.trackBarControl1.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.trackBarControl1.Properties.ShowValueToolTip = True
            Me.trackBarControl1.Size = New System.Drawing.Size(236, 45)
            Me.trackBarControl1.StyleController = Me.layoutControl1
            Me.trackBarControl1.TabIndex = 0
            AddHandler Me.trackBarControl1.BeforeShowValueToolTip, New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(AddressOf Me.trackBarControl1_BeforeShowValueToolTip)
            ' 
            ' seMinimum
            ' 
            Me.seMinimum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMinimum.Location = New System.Drawing.Point(412, 186)
            Me.seMinimum.Name = "seMinimum"
            Me.seMinimum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMinimum.Properties.IsFloatValue = False
            Me.seMinimum.Properties.Mask.EditMask = "N00"
            Me.seMinimum.Size = New System.Drawing.Size(128, 20)
            Me.seMinimum.StyleController = Me.layoutControl1
            Me.seMinimum.TabIndex = 5
            AddHandler Me.seMinimum.EditValueChanged, New System.EventHandler(AddressOf Me.seMinimum_EditValueChanged)
            ' 
            ' ceShowValue
            ' 
            Me.ceShowValue.Location = New System.Drawing.Point(324, 102)
            Me.ceShowValue.Name = "ceShowValue"
            Me.ceShowValue.Properties.Caption = "Show Value ToolTip"
            Me.ceShowValue.Size = New System.Drawing.Size(216, 20)
            Me.ceShowValue.StyleController = Me.layoutControl1
            Me.ceShowValue.TabIndex = 2
            AddHandler Me.ceShowValue.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowValue_CheckedChanged)
            ' 
            ' icbTickStyle
            ' 
            Me.icbTickStyle.Location = New System.Drawing.Point(412, 46)
            Me.icbTickStyle.Name = "icbTickStyle"
            Me.icbTickStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbTickStyle.Size = New System.Drawing.Size(128, 20)
            Me.icbTickStyle.StyleController = Me.layoutControl1
            Me.icbTickStyle.TabIndex = 0
            AddHandler Me.icbTickStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbTickStyle_SelectedIndexChanged)
            ' 
            ' checkEditVertical
            ' 
            Me.checkEditVertical.Location = New System.Drawing.Point(324, 74)
            Me.checkEditVertical.Name = "checkEditVertical"
            Me.checkEditVertical.Properties.Caption = "Vertical"
            Me.checkEditVertical.Size = New System.Drawing.Size(216, 20)
            Me.checkEditVertical.StyleController = Me.layoutControl1
            Me.checkEditVertical.TabIndex = 1
            AddHandler Me.checkEditVertical.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditVertical_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(572, 395)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(292, 375)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.trackBarControl1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(0, 240)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(240, 49)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(240, 330)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.layoutControlItem11, Me.layoutControlItem12, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(292, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 9)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(260, 375)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbTickStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 1)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(220, 26)
            Me.layoutControlItem2.Text = "Tick style:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEditVertical
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 27)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceShowValue
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 55)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceShowCustomValue
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 83)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceShowTickLabels
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seMinimum
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 139)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem7.Text = "Minimum:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.seMaximum
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 167)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem8.Text = "Maximum:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.seSmallChange
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 195)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem9.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem9.Text = "Small Change:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.seLargeChange
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 223)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem10.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem10.Text = "Large Change:"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.seTickFrequency
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 251)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem11.Size = New System.Drawing.Size(220, 28)
            Me.layoutControlItem11.Text = "Tick Frequency:"
            Me.layoutControlItem11.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem12
            ' 
            Me.layoutControlItem12.Control = Me.seLabelDistance
            Me.layoutControlItem12.Location = New System.Drawing.Point(0, 279)
            Me.layoutControlItem12.Name = "layoutControlItem12"
            Me.layoutControlItem12.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem12.Size = New System.Drawing.Size(220, 51)
            Me.layoutControlItem12.Text = "Label Distance:"
            Me.layoutControlItem12.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleTrackBar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleTrackBar"
            Me.Size = New System.Drawing.Size(878, 648)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleTrackBar_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.seLabelDistance.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seTickFrequency.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowTickLabels.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seLargeChange.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seSmallChange.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowCustomValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMaximum.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.trackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMinimum.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbTickStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditVertical.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem12), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private checkEditVertical As DevExpress.XtraEditors.CheckEdit

        Private trackBarControl1 As DevExpress.XtraEditors.TrackBarControl

        Private icbTickStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seMinimum As DevExpress.XtraEditors.SpinEdit

        Private seMaximum As DevExpress.XtraEditors.SpinEdit

        Private seSmallChange As DevExpress.XtraEditors.SpinEdit

        Private seLargeChange As DevExpress.XtraEditors.SpinEdit

        Private seTickFrequency As DevExpress.XtraEditors.SpinEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private ceShowValue As DevExpress.XtraEditors.CheckEdit

        Private ceShowCustomValue As DevExpress.XtraEditors.CheckEdit

        Private seLabelDistance As DevExpress.XtraEditors.SpinEdit

        Private ceShowTickLabels As DevExpress.XtraEditors.CheckEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
