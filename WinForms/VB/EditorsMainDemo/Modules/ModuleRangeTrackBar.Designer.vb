Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleRangeTrackBar

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleRangeTrackBar))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lbValue = New DevExpress.XtraEditors.LabelControl()
            Me.seTickFrequency = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowCustomValue = New DevExpress.XtraEditors.CheckEdit()
            Me.seLargeChange = New DevExpress.XtraEditors.SpinEdit()
            Me.seSmallChange = New DevExpress.XtraEditors.SpinEdit()
            Me.ceShowValue = New DevExpress.XtraEditors.CheckEdit()
            Me.seMaximum = New DevExpress.XtraEditors.SpinEdit()
            Me.seMinimum = New DevExpress.XtraEditors.SpinEdit()
            Me.rangeTrackBarControl1 = New DevExpress.XtraEditors.RangeTrackBarControl()
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
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.seTickFrequency.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowCustomValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seLargeChange.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seSmallChange.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMaximum.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMinimum.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeTrackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.rangeTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.lbValue)
            Me.layoutControl1.Controls.Add(Me.seTickFrequency)
            Me.layoutControl1.Controls.Add(Me.ceShowCustomValue)
            Me.layoutControl1.Controls.Add(Me.seLargeChange)
            Me.layoutControl1.Controls.Add(Me.seSmallChange)
            Me.layoutControl1.Controls.Add(Me.ceShowValue)
            Me.layoutControl1.Controls.Add(Me.seMaximum)
            Me.layoutControl1.Controls.Add(Me.seMinimum)
            Me.layoutControl1.Controls.Add(Me.rangeTrackBarControl1)
            Me.layoutControl1.Controls.Add(Me.icbTickStyle)
            Me.layoutControl1.Controls.Add(Me.checkEditVertical)
            Me.layoutControl1.Location = New System.Drawing.Point(44, 36)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(885, 197, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(583, 437)
            Me.layoutControl1.TabIndex = 6
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' lbValue
            ' 
            Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.lbValue.Appearance.Options.UseFont = True
            Me.lbValue.Appearance.Options.UseTextOptions = True
            Me.lbValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbValue.Location = New System.Drawing.Point(346, 367)
            Me.lbValue.Name = "lbValue"
            Me.lbValue.Size = New System.Drawing.Size(222, 14)
            Me.lbValue.StyleController = Me.layoutControl1
            Me.lbValue.TabIndex = 0
            ' 
            ' seTickFrequency
            ' 
            Me.seTickFrequency.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seTickFrequency.Location = New System.Drawing.Point(442, 270)
            Me.seTickFrequency.Name = "seTickFrequency"
            Me.seTickFrequency.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seTickFrequency.Properties.IsFloatValue = False
            Me.seTickFrequency.Properties.Mask.EditMask = "N00"
            Me.seTickFrequency.Size = New System.Drawing.Size(118, 20)
            Me.seTickFrequency.StyleController = Me.layoutControl1
            Me.seTickFrequency.TabIndex = 17
            AddHandler Me.seTickFrequency.EditValueChanged, New System.EventHandler(AddressOf Me.seTickFrequency_EditValueChanged)
            ' 
            ' ceShowCustomValue
            ' 
            Me.ceShowCustomValue.EditValue = True
            Me.ceShowCustomValue.Location = New System.Drawing.Point(354, 130)
            Me.ceShowCustomValue.Name = "ceShowCustomValue"
            Me.ceShowCustomValue.Properties.Caption = "Show Custom Value"
            Me.ceShowCustomValue.Size = New System.Drawing.Size(206, 20)
            Me.ceShowCustomValue.StyleController = Me.layoutControl1
            Me.ceShowCustomValue.TabIndex = 19
            ' 
            ' seLargeChange
            ' 
            Me.seLargeChange.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seLargeChange.Location = New System.Drawing.Point(442, 242)
            Me.seLargeChange.Name = "seLargeChange"
            Me.seLargeChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seLargeChange.Properties.IsFloatValue = False
            Me.seLargeChange.Properties.Mask.EditMask = "N00"
            Me.seLargeChange.Size = New System.Drawing.Size(118, 20)
            Me.seLargeChange.StyleController = Me.layoutControl1
            Me.seLargeChange.TabIndex = 16
            AddHandler Me.seLargeChange.EditValueChanged, New System.EventHandler(AddressOf Me.seLargeChange_EditValueChanged)
            ' 
            ' seSmallChange
            ' 
            Me.seSmallChange.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seSmallChange.Location = New System.Drawing.Point(442, 214)
            Me.seSmallChange.Name = "seSmallChange"
            Me.seSmallChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seSmallChange.Properties.IsFloatValue = False
            Me.seSmallChange.Properties.Mask.EditMask = "N00"
            Me.seSmallChange.Size = New System.Drawing.Size(118, 20)
            Me.seSmallChange.StyleController = Me.layoutControl1
            Me.seSmallChange.TabIndex = 15
            AddHandler Me.seSmallChange.EditValueChanged, New System.EventHandler(AddressOf Me.seSmallChange_EditValueChanged)
            ' 
            ' ceShowValue
            ' 
            Me.ceShowValue.Location = New System.Drawing.Point(354, 102)
            Me.ceShowValue.Name = "ceShowValue"
            Me.ceShowValue.Properties.Caption = "Show Value ToolTip"
            Me.ceShowValue.Size = New System.Drawing.Size(206, 20)
            Me.ceShowValue.StyleController = Me.layoutControl1
            Me.ceShowValue.TabIndex = 18
            AddHandler Me.ceShowValue.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowValue_CheckedChanged)
            ' 
            ' seMaximum
            ' 
            Me.seMaximum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMaximum.Location = New System.Drawing.Point(442, 186)
            Me.seMaximum.Name = "seMaximum"
            Me.seMaximum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaximum.Properties.IsFloatValue = False
            Me.seMaximum.Properties.Mask.EditMask = "N00"
            Me.seMaximum.Size = New System.Drawing.Size(118, 20)
            Me.seMaximum.StyleController = Me.layoutControl1
            Me.seMaximum.TabIndex = 14
            AddHandler Me.seMaximum.EditValueChanged, New System.EventHandler(AddressOf Me.seMaximum_EditValueChanged)
            ' 
            ' seMinimum
            ' 
            Me.seMinimum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMinimum.Location = New System.Drawing.Point(442, 158)
            Me.seMinimum.Name = "seMinimum"
            Me.seMinimum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMinimum.Properties.IsFloatValue = False
            Me.seMinimum.Properties.Mask.EditMask = "N00"
            Me.seMinimum.Size = New System.Drawing.Size(118, 20)
            Me.seMinimum.StyleController = Me.layoutControl1
            Me.seMinimum.TabIndex = 13
            AddHandler Me.seMinimum.EditValueChanged, New System.EventHandler(AddressOf Me.seMinimum_EditValueChanged)
            ' 
            ' rangeTrackBarControl1
            ' 
            Me.rangeTrackBarControl1.EditValue = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 5)
            Me.rangeTrackBarControl1.Location = New System.Drawing.Point(24, 198)
            Me.rangeTrackBarControl1.Name = "rangeTrackBarControl1"
            Me.rangeTrackBarControl1.Size = New System.Drawing.Size(266, 45)
            Me.rangeTrackBarControl1.StyleController = Me.layoutControl1
            Me.rangeTrackBarControl1.TabIndex = 0
            Me.rangeTrackBarControl1.Value = New DevExpress.XtraEditors.Repository.TrackBarRange(0, 5)
            AddHandler Me.rangeTrackBarControl1.BeforeShowValueToolTip, New DevExpress.XtraEditors.TrackBarValueToolTipEventHandler(AddressOf Me.rangeTrackBarControl1_BeforeShowValueToolTip)
            AddHandler Me.rangeTrackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.rangeTrackBarControl1_EditValueChanged)
            ' 
            ' icbTickStyle
            ' 
            Me.icbTickStyle.Location = New System.Drawing.Point(442, 46)
            Me.icbTickStyle.Name = "icbTickStyle"
            Me.icbTickStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbTickStyle.Size = New System.Drawing.Size(118, 20)
            Me.icbTickStyle.StyleController = Me.layoutControl1
            Me.icbTickStyle.TabIndex = 0
            AddHandler Me.icbTickStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbTickStyle_SelectedIndexChanged)
            ' 
            ' checkEditVertical
            ' 
            Me.checkEditVertical.Location = New System.Drawing.Point(354, 74)
            Me.checkEditVertical.Name = "checkEditVertical"
            Me.checkEditVertical.Properties.Caption = "Vertical"
            Me.checkEditVertical.Size = New System.Drawing.Size(206, 20)
            Me.checkEditVertical.StyleController = Me.layoutControl1
            Me.checkEditVertical.TabIndex = 1
            AddHandler Me.checkEditVertical.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditVertical_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(592, 420)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(322, 400)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.rangeTrackBarControl1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(0, 270)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(270, 49)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(270, 355)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.layoutControlItem10, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(322, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(250, 322)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbTickStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 1)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(210, 26)
            Me.layoutControlItem2.Text = "Tick style:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEditVertical
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 27)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceShowValue
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 55)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceShowCustomValue
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 83)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seMinimum
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem6.Text = "Minimum:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seMaximum
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 139)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem7.Text = "Maximum:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.seSmallChange
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 167)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem8.Text = "Small Change:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.seLargeChange
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 195)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem9.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem9.Text = "Large Change:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.seTickFrequency
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 223)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem10.Size = New System.Drawing.Size(210, 28)
            Me.layoutControlItem10.Text = "Tick Frequency:"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(76, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(210, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(210, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.CaptionImageOptions.SvgImage = CType((resources.GetObject("layoutControlGroup4.CaptionImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.layoutControlGroup4.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem11})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(322, 322)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(250, 78)
            Me.layoutControlGroup4.Text = "Value"
            ' 
            ' layoutControlItem11
            ' 
            Me.layoutControlItem11.Control = Me.lbValue
            Me.layoutControlItem11.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem11.Name = "layoutControlItem11"
            Me.layoutControlItem11.Size = New System.Drawing.Size(226, 33)
            Me.layoutControlItem11.TextVisible = False
            ' 
            ' ModuleRangeTrackBar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleRangeTrackBar"
            Me.Size = New System.Drawing.Size(818, 595)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleRangeTrackBar_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.seTickFrequency.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowCustomValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seLargeChange.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seSmallChange.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMaximum.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMinimum.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.rangeTrackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem11), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private checkEditVertical As DevExpress.XtraEditors.CheckEdit

        Private rangeTrackBarControl1 As DevExpress.XtraEditors.RangeTrackBarControl

        Private icbTickStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seMinimum As DevExpress.XtraEditors.SpinEdit

        Private seMaximum As DevExpress.XtraEditors.SpinEdit

        Private seSmallChange As DevExpress.XtraEditors.SpinEdit

        Private seLargeChange As DevExpress.XtraEditors.SpinEdit

        Private seTickFrequency As DevExpress.XtraEditors.SpinEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private lbValue As DevExpress.XtraEditors.LabelControl

        Private ceShowCustomValue As DevExpress.XtraEditors.CheckEdit

        Private ceShowValue As DevExpress.XtraEditors.CheckEdit

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

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
