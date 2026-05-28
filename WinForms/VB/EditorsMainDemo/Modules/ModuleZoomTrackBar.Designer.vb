Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleZoomTrackBar

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleZoomTrackBar))
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.lbValue = New DevExpress.XtraEditors.LabelControl()
            Me.seMiddle = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditUseMiddleValue = New DevExpress.XtraEditors.CheckEdit()
            Me.zoomTrackBarControl1 = New DevExpress.XtraEditors.ZoomTrackBarControl()
            Me.seLargeChange = New DevExpress.XtraEditors.SpinEdit()
            Me.seSmallChange = New DevExpress.XtraEditors.SpinEdit()
            Me.seMaximum = New DevExpress.XtraEditors.SpinEdit()
            Me.seMinimum = New DevExpress.XtraEditors.SpinEdit()
            Me.icbScrollThumbStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
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
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.seMiddle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditUseMiddleValue.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.zoomTrackBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.zoomTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seLargeChange.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seSmallChange.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMaximum.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMinimum.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbScrollThumbStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.lbValue)
            Me.layoutControl1.Controls.Add(Me.seMiddle)
            Me.layoutControl1.Controls.Add(Me.checkEditUseMiddleValue)
            Me.layoutControl1.Controls.Add(Me.zoomTrackBarControl1)
            Me.layoutControl1.Controls.Add(Me.seLargeChange)
            Me.layoutControl1.Controls.Add(Me.seSmallChange)
            Me.layoutControl1.Controls.Add(Me.seMaximum)
            Me.layoutControl1.Controls.Add(Me.seMinimum)
            Me.layoutControl1.Controls.Add(Me.icbScrollThumbStyle)
            Me.layoutControl1.Controls.Add(Me.checkEditVertical)
            Me.layoutControl1.Location = New System.Drawing.Point(60, 51)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(976, 241, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(644, 464)
            Me.layoutControl1.TabIndex = 7
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' lbValue
            ' 
            Me.lbValue.Appearance.Font = New System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.lbValue.Appearance.Options.UseFont = True
            Me.lbValue.Appearance.Options.UseTextOptions = True
            Me.lbValue.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbValue.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbValue.Location = New System.Drawing.Point(384, 337)
            Me.lbValue.Name = "lbValue"
            Me.lbValue.Size = New System.Drawing.Size(236, 14)
            Me.lbValue.StyleController = Me.layoutControl1
            Me.lbValue.TabIndex = 0
            ' 
            ' seMiddle
            ' 
            Me.seMiddle.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMiddle.Enabled = False
            Me.seMiddle.Location = New System.Drawing.Point(495, 242)
            Me.seMiddle.Name = "seMiddle"
            Me.seMiddle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMiddle.Properties.IsFloatValue = False
            Me.seMiddle.Properties.Mask.EditMask = "N00"
            Me.seMiddle.Size = New System.Drawing.Size(117, 20)
            Me.seMiddle.StyleController = Me.layoutControl1
            Me.seMiddle.TabIndex = 7
            AddHandler Me.seMiddle.EditValueChanged, New System.EventHandler(AddressOf Me.seMiddle_EditValueChanged)
            ' 
            ' checkEditUseMiddleValue
            ' 
            Me.checkEditUseMiddleValue.Location = New System.Drawing.Point(392, 102)
            Me.checkEditUseMiddleValue.Name = "checkEditUseMiddleValue"
            Me.checkEditUseMiddleValue.Properties.Caption = "Use Middle Value"
            Me.checkEditUseMiddleValue.Size = New System.Drawing.Size(220, 20)
            Me.checkEditUseMiddleValue.StyleController = Me.layoutControl1
            Me.checkEditUseMiddleValue.TabIndex = 2
            AddHandler Me.checkEditUseMiddleValue.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditUseMiddleValue_CheckedChanged)
            ' 
            ' zoomTrackBarControl1
            ' 
            Me.zoomTrackBarControl1.EditValue = 5
            Me.zoomTrackBarControl1.Location = New System.Drawing.Point(24, 234)
            Me.zoomTrackBarControl1.Name = "zoomTrackBarControl1"
            Me.zoomTrackBarControl1.Properties.Middle = 5
            Me.zoomTrackBarControl1.Size = New System.Drawing.Size(304, 16)
            Me.zoomTrackBarControl1.StyleController = Me.layoutControl1
            Me.zoomTrackBarControl1.TabIndex = 0
            Me.zoomTrackBarControl1.Value = 5
            AddHandler Me.zoomTrackBarControl1.EditValueChanged, New System.EventHandler(AddressOf Me.zoomTrackBarControl1_EditValueChanged)
            ' 
            ' seLargeChange
            ' 
            Me.seLargeChange.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seLargeChange.Location = New System.Drawing.Point(495, 214)
            Me.seLargeChange.Name = "seLargeChange"
            Me.seLargeChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seLargeChange.Properties.IsFloatValue = False
            Me.seLargeChange.Properties.Mask.EditMask = "N00"
            Me.seLargeChange.Size = New System.Drawing.Size(117, 20)
            Me.seLargeChange.StyleController = Me.layoutControl1
            Me.seLargeChange.TabIndex = 6
            AddHandler Me.seLargeChange.EditValueChanged, New System.EventHandler(AddressOf Me.seLargeChange_EditValueChanged)
            ' 
            ' seSmallChange
            ' 
            Me.seSmallChange.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seSmallChange.Location = New System.Drawing.Point(495, 186)
            Me.seSmallChange.Name = "seSmallChange"
            Me.seSmallChange.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seSmallChange.Properties.IsFloatValue = False
            Me.seSmallChange.Properties.Mask.EditMask = "N00"
            Me.seSmallChange.Size = New System.Drawing.Size(117, 20)
            Me.seSmallChange.StyleController = Me.layoutControl1
            Me.seSmallChange.TabIndex = 5
            AddHandler Me.seSmallChange.EditValueChanged, New System.EventHandler(AddressOf Me.seSmallChange_EditValueChanged)
            ' 
            ' seMaximum
            ' 
            Me.seMaximum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMaximum.Location = New System.Drawing.Point(495, 158)
            Me.seMaximum.Name = "seMaximum"
            Me.seMaximum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaximum.Properties.IsFloatValue = False
            Me.seMaximum.Properties.Mask.EditMask = "N00"
            Me.seMaximum.Size = New System.Drawing.Size(117, 20)
            Me.seMaximum.StyleController = Me.layoutControl1
            Me.seMaximum.TabIndex = 4
            AddHandler Me.seMaximum.EditValueChanged, New System.EventHandler(AddressOf Me.seMaximum_EditValueChanged)
            ' 
            ' seMinimum
            ' 
            Me.seMinimum.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMinimum.Location = New System.Drawing.Point(495, 130)
            Me.seMinimum.Name = "seMinimum"
            Me.seMinimum.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMinimum.Properties.IsFloatValue = False
            Me.seMinimum.Properties.Mask.EditMask = "N00"
            Me.seMinimum.Size = New System.Drawing.Size(117, 20)
            Me.seMinimum.StyleController = Me.layoutControl1
            Me.seMinimum.TabIndex = 3
            AddHandler Me.seMinimum.EditValueChanged, New System.EventHandler(AddressOf Me.seMinimum_EditValueChanged)
            ' 
            ' icbScrollThumbStyle
            ' 
            Me.icbScrollThumbStyle.Location = New System.Drawing.Point(495, 46)
            Me.icbScrollThumbStyle.Name = "icbScrollThumbStyle"
            Me.icbScrollThumbStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbScrollThumbStyle.Size = New System.Drawing.Size(117, 20)
            Me.icbScrollThumbStyle.StyleController = Me.layoutControl1
            Me.icbScrollThumbStyle.TabIndex = 0
            AddHandler Me.icbScrollThumbStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbScrollThumbStyle_SelectedIndexChanged)
            ' 
            ' checkEditVertical
            ' 
            Me.checkEditVertical.Location = New System.Drawing.Point(392, 74)
            Me.checkEditVertical.Name = "checkEditVertical"
            Me.checkEditVertical.Properties.Caption = "Vertical"
            Me.checkEditVertical.Size = New System.Drawing.Size(220, 20)
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
            Me.layoutControlGroup1.Size = New System.Drawing.Size(644, 464)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(360, 444)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.zoomTrackBarControl1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(0, 270)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(270, 22)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(308, 399)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(360, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(264, 292)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbScrollThumbStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 1)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(224, 26)
            Me.layoutControlItem2.Text = "Scroll Thumb Style:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.checkEditVertical
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 27)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(224, 28)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkEditUseMiddleValue
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 55)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(224, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.seMinimum
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 83)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(224, 28)
            Me.layoutControlItem5.Text = "Minimum:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.seMaximum
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 111)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(224, 28)
            Me.layoutControlItem6.Text = "Maximum:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.seSmallChange
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 139)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(224, 28)
            Me.layoutControlItem7.Text = "Small Change:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.seLargeChange
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 167)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(224, 28)
            Me.layoutControlItem8.Text = "Large Change:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.seMiddle
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 195)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem9.Size = New System.Drawing.Size(224, 26)
            Me.layoutControlItem9.Text = "Middle:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(91, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(224, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.CaptionImageOptions.SvgImage = CType((resources.GetObject("layoutControlGroup4.CaptionImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.layoutControlGroup4.CaptionImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(360, 292)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(264, 152)
            Me.layoutControlGroup4.Text = "Value"
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.lbValue
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(240, 107)
            Me.layoutControlItem10.TextVisible = False
            ' 
            ' ModuleZoomTrackBar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleZoomTrackBar"
            Me.Size = New System.Drawing.Size(906, 586)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleZoomTrackBar_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.seMiddle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditUseMiddleValue.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.zoomTrackBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.zoomTrackBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seLargeChange.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seSmallChange.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMaximum.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMinimum.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbScrollThumbStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private checkEditVertical As DevExpress.XtraEditors.CheckEdit

        Private zoomTrackBarControl1 As DevExpress.XtraEditors.ZoomTrackBarControl

        Private icbScrollThumbStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seMinimum As DevExpress.XtraEditors.SpinEdit

        Private seMaximum As DevExpress.XtraEditors.SpinEdit

        Private seSmallChange As DevExpress.XtraEditors.SpinEdit

        Private seLargeChange As DevExpress.XtraEditors.SpinEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private lbValue As DevExpress.XtraEditors.LabelControl

        Private seMiddle As DevExpress.XtraEditors.SpinEdit

        Private checkEditUseMiddleValue As DevExpress.XtraEditors.CheckEdit

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

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
