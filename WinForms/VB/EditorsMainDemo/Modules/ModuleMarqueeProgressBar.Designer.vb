Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleMarqueeProgressBar

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
            Me.teTitle = New DevExpress.XtraEditors.TextEdit()
            Me.checkEditPause = New DevExpress.XtraEditors.CheckEdit()
            Me.marqueeProgressBarControl1 = New DevExpress.XtraEditors.MarqueeProgressBarControl()
            Me.spinEditAnimationSpeed = New DevExpress.XtraEditors.SpinEdit()
            Me.checkEditVertical = New DevExpress.XtraEditors.CheckEdit()
            Me.checkEditShowTitle = New DevExpress.XtraEditors.CheckEdit()
            Me.icbProgressViewStyle = New DevExpress.XtraEditors.ImageComboBoxEdit()
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
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.teTitle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditPause.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.marqueeProgressBarControl1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinEditAnimationSpeed.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditVertical.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.checkEditShowTitle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbProgressViewStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
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
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.teTitle)
            Me.layoutControl1.Controls.Add(Me.checkEditPause)
            Me.layoutControl1.Controls.Add(Me.marqueeProgressBarControl1)
            Me.layoutControl1.Controls.Add(Me.spinEditAnimationSpeed)
            Me.layoutControl1.Controls.Add(Me.checkEditVertical)
            Me.layoutControl1.Controls.Add(Me.checkEditShowTitle)
            Me.layoutControl1.Controls.Add(Me.icbProgressViewStyle)
            Me.layoutControl1.Location = New System.Drawing.Point(29, 31)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1014, 140, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(692, 385)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' teTitle
            ' 
            Me.teTitle.Location = New System.Drawing.Point(477, 181)
            Me.teTitle.Name = "teTitle"
            Me.teTitle.Size = New System.Drawing.Size(182, 20)
            Me.teTitle.StyleController = Me.layoutControl1
            Me.teTitle.TabIndex = 10
            AddHandler Me.teTitle.EditValueChanged, New System.EventHandler(AddressOf Me.teTitle_EditValueChanged)
            ' 
            ' checkEditPause
            ' 
            Me.checkEditPause.Location = New System.Drawing.Point(384, 155)
            Me.checkEditPause.Name = "checkEditPause"
            Me.checkEditPause.Properties.Caption = "Pause"
            Me.checkEditPause.Size = New System.Drawing.Size(275, 20)
            Me.checkEditPause.StyleController = Me.layoutControl1
            Me.checkEditPause.TabIndex = 11
            AddHandler Me.checkEditPause.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditPause_CheckedChanged)
            ' 
            ' marqueeProgressBarControl1
            ' 
            Me.marqueeProgressBarControl1.EditValue = "Rebuild..."
            Me.marqueeProgressBarControl1.Location = New System.Drawing.Point(24, 194)
            Me.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1"
            Me.marqueeProgressBarControl1.Size = New System.Drawing.Size(296, 18)
            Me.marqueeProgressBarControl1.StyleController = Me.layoutControl1
            Me.marqueeProgressBarControl1.TabIndex = 0
            ' 
            ' spinEditAnimationSpeed
            ' 
            Me.spinEditAnimationSpeed.EditValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinEditAnimationSpeed.Location = New System.Drawing.Point(477, 73)
            Me.spinEditAnimationSpeed.Name = "spinEditAnimationSpeed"
            Me.spinEditAnimationSpeed.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.spinEditAnimationSpeed.Properties.IsFloatValue = False
            Me.spinEditAnimationSpeed.Properties.Mask.EditMask = "N00"
            Me.spinEditAnimationSpeed.Properties.MaxValue = New Decimal(New Integer() {500, 0, 0, 0})
            Me.spinEditAnimationSpeed.Properties.MinValue = New Decimal(New Integer() {20, 0, 0, 0})
            Me.spinEditAnimationSpeed.Size = New System.Drawing.Size(182, 20)
            Me.spinEditAnimationSpeed.StyleController = Me.layoutControl1
            Me.spinEditAnimationSpeed.TabIndex = 1
            AddHandler Me.spinEditAnimationSpeed.EditValueChanged, New System.EventHandler(AddressOf Me.spinEditAnimationSpeed_EditValueChanged)
            ' 
            ' checkEditVertical
            ' 
            Me.checkEditVertical.Location = New System.Drawing.Point(384, 101)
            Me.checkEditVertical.Name = "checkEditVertical"
            Me.checkEditVertical.Properties.Caption = "Vertical"
            Me.checkEditVertical.Size = New System.Drawing.Size(275, 20)
            Me.checkEditVertical.StyleController = Me.layoutControl1
            Me.checkEditVertical.TabIndex = 2
            AddHandler Me.checkEditVertical.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditVertical_CheckedChanged)
            ' 
            ' checkEditShowTitle
            ' 
            Me.checkEditShowTitle.Location = New System.Drawing.Point(384, 129)
            Me.checkEditShowTitle.Name = "checkEditShowTitle"
            Me.checkEditShowTitle.Properties.Caption = "Show title"
            Me.checkEditShowTitle.Size = New System.Drawing.Size(275, 20)
            Me.checkEditShowTitle.StyleController = Me.layoutControl1
            Me.checkEditShowTitle.TabIndex = 3
            AddHandler Me.checkEditShowTitle.CheckedChanged, New System.EventHandler(AddressOf Me.checkEditShowTitle_CheckedChanged)
            ' 
            ' icbProgressViewStyle
            ' 
            Me.icbProgressViewStyle.Location = New System.Drawing.Point(477, 45)
            Me.icbProgressViewStyle.Name = "icbProgressViewStyle"
            Me.icbProgressViewStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbProgressViewStyle.Size = New System.Drawing.Size(182, 20)
            Me.icbProgressViewStyle.StyleController = Me.layoutControl1
            Me.icbProgressViewStyle.TabIndex = 0
            AddHandler Me.icbProgressViewStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbProgressViewStyle_SelectedIndexChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(692, 385)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(352, 365)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.marqueeProgressBarControl1
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(300, 22)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(300, 320)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.emptySpaceItem1, Me.emptySpaceItem2})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(352, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(320, 365)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.icbProgressViewStyle
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(279, 26)
            Me.layoutControlItem2.Text = "Bar style:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.spinEditAnimationSpeed
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(279, 28)
            Me.layoutControlItem3.Text = "Animation Delay:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.checkEditVertical
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(279, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.checkEditShowTitle
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(279, 28)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.checkEditPause
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Size = New System.Drawing.Size(279, 24)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.teTitle
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 134)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem7.Size = New System.Drawing.Size(279, 26)
            Me.layoutControlItem7.Text = "Title:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(81, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 160)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(220, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(279, 152)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(279, 0)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(1, 0)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(1, 300)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(1, 312)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleMarqueeProgressBar
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleMarqueeProgressBar"
            Me.Size = New System.Drawing.Size(827, 636)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleMarqueeProgressBar_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.teTitle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditPause.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.marqueeProgressBarControl1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinEditAnimationSpeed.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditVertical.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.checkEditShowTitle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbProgressViewStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
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
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private marqueeProgressBarControl1 As DevExpress.XtraEditors.MarqueeProgressBarControl

        Private checkEditVertical As DevExpress.XtraEditors.CheckEdit

        Private checkEditShowTitle As DevExpress.XtraEditors.CheckEdit

        Private spinEditAnimationSpeed As DevExpress.XtraEditors.SpinEdit

        Private icbProgressViewStyle As DevExpress.XtraEditors.ImageComboBoxEdit

        Private teTitle As DevExpress.XtraEditors.TextEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private checkEditPause As DevExpress.XtraEditors.CheckEdit

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

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
