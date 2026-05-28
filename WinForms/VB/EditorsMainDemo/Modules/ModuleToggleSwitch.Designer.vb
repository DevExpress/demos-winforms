Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleToggleSwitch

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
            Me.tsTextOff = New DevExpress.XtraEditors.TextEdit()
            Me.comboAlign = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.tsTextOn = New DevExpress.XtraEditors.TextEdit()
            Me.btnToggleState = New DevExpress.XtraEditors.SimpleButton()
            Me.tsAllowThumbAnimation = New DevExpress.XtraEditors.CheckEdit()
            Me.tsAllowHTMLString = New DevExpress.XtraEditors.CheckEdit()
            Me.tsAllowMnemonics = New DevExpress.XtraEditors.CheckEdit()
            Me.toggleSwitch = New DevExpress.XtraEditors.ToggleSwitch()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.tsTextOff.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.comboAlign.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tsTextOn.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tsAllowThumbAnimation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tsAllowHTMLString.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.tsAllowMnemonics.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.toggleSwitch.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.tsTextOff)
            Me.layoutControl1.Controls.Add(Me.comboAlign)
            Me.layoutControl1.Controls.Add(Me.tsTextOn)
            Me.layoutControl1.Controls.Add(Me.btnToggleState)
            Me.layoutControl1.Controls.Add(Me.tsAllowThumbAnimation)
            Me.layoutControl1.Controls.Add(Me.tsAllowHTMLString)
            Me.layoutControl1.Controls.Add(Me.tsAllowMnemonics)
            Me.layoutControl1.Controls.Add(Me.toggleSwitch)
            Me.layoutControl1.Location = New System.Drawing.Point(39, 40)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1031, 204, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(734, 418)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' tsTextOff
            ' 
            Me.tsTextOff.EditValue = "Off"
            Me.tsTextOff.Location = New System.Drawing.Point(547, 257)
            Me.tsTextOff.Name = "tsTextOff"
            Me.tsTextOff.Size = New System.Drawing.Size(173, 20)
            Me.tsTextOff.StyleController = Me.layoutControl1
            Me.tsTextOff.TabIndex = 9
            AddHandler Me.tsTextOff.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.OffTextChanging)
            ' 
            ' comboAlign
            ' 
            Me.comboAlign.EditValue = "Near"
            Me.comboAlign.Location = New System.Drawing.Point(547, 285)
            Me.comboAlign.Name = "comboAlign"
            Me.comboAlign.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.comboAlign.Properties.Items.AddRange(New Object() {"Near", "Center", "Far"})
            Me.comboAlign.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.comboAlign.Size = New System.Drawing.Size(173, 20)
            Me.comboAlign.StyleController = Me.layoutControl1
            Me.comboAlign.TabIndex = 2
            AddHandler Me.comboAlign.SelectedIndexChanged, New System.EventHandler(AddressOf Me.comboAlign_SelectedIndexChanged)
            ' 
            ' tsTextOn
            ' 
            Me.tsTextOn.EditValue = "On"
            Me.tsTextOn.Location = New System.Drawing.Point(547, 229)
            Me.tsTextOn.Name = "tsTextOn"
            Me.tsTextOn.Size = New System.Drawing.Size(173, 20)
            Me.tsTextOn.StyleController = Me.layoutControl1
            Me.tsTextOn.TabIndex = 8
            AddHandler Me.tsTextOn.EditValueChanging, New DevExpress.XtraEditors.Controls.ChangingEventHandler(AddressOf Me.OnTextChanging)
            ' 
            ' btnToggleState
            ' 
            Me.btnToggleState.Location = New System.Drawing.Point(547, 130)
            Me.btnToggleState.Name = "btnToggleState"
            Me.btnToggleState.Size = New System.Drawing.Size(173, 22)
            Me.btnToggleState.StyleController = Me.layoutControl1
            Me.btnToggleState.TabIndex = 4
            Me.btnToggleState.Text = "Toggle"
            AddHandler Me.btnToggleState.Click, New System.EventHandler(AddressOf Me.btnToggleState_Click)
            ' 
            ' tsAllowThumbAnimation
            ' 
            Me.tsAllowThumbAnimation.EditValue = True
            Me.tsAllowThumbAnimation.Location = New System.Drawing.Point(484, 102)
            Me.tsAllowThumbAnimation.Name = "tsAllowThumbAnimation"
            Me.tsAllowThumbAnimation.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.tsAllowThumbAnimation.Properties.Appearance.Options.UseBackColor = True
            Me.tsAllowThumbAnimation.Properties.Caption = "Allow Thumb Animation "
            Me.tsAllowThumbAnimation.Size = New System.Drawing.Size(236, 20)
            Me.tsAllowThumbAnimation.StyleController = Me.layoutControl1
            Me.tsAllowThumbAnimation.TabIndex = 5
            AddHandler Me.tsAllowThumbAnimation.CheckedChanged, New System.EventHandler(AddressOf Me.tsAllowThumbAnimation_CheckedChanged)
            ' 
            ' tsAllowHTMLString
            ' 
            Me.tsAllowHTMLString.Location = New System.Drawing.Point(484, 74)
            Me.tsAllowHTMLString.Name = "tsAllowHTMLString"
            Me.tsAllowHTMLString.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.tsAllowHTMLString.Properties.Appearance.Options.UseBackColor = True
            Me.tsAllowHTMLString.Properties.Caption = "Allow HTML Draw"
            Me.tsAllowHTMLString.Size = New System.Drawing.Size(236, 20)
            Me.tsAllowHTMLString.StyleController = Me.layoutControl1
            Me.tsAllowHTMLString.TabIndex = 2
            AddHandler Me.tsAllowHTMLString.CheckedChanged, New System.EventHandler(AddressOf Me.tsAllowHTMLString_CheckedChanged)
            ' 
            ' tsAllowMnemonics
            ' 
            Me.tsAllowMnemonics.Location = New System.Drawing.Point(484, 46)
            Me.tsAllowMnemonics.Name = "tsAllowMnemonics"
            Me.tsAllowMnemonics.Properties.Caption = "Allow mnemonics"
            Me.tsAllowMnemonics.Size = New System.Drawing.Size(236, 20)
            Me.tsAllowMnemonics.StyleController = Me.layoutControl1
            Me.tsAllowMnemonics.TabIndex = 0
            AddHandler Me.tsAllowMnemonics.CheckedChanged, New System.EventHandler(AddressOf Me.tsAllowMnemonics_CheckedChanged)
            ' 
            ' toggleSwitch
            ' 
            Me.toggleSwitch.Location = New System.Drawing.Point(24, 189)
            Me.toggleSwitch.Name = "toggleSwitch"
            Me.toggleSwitch.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte((0))))
            Me.toggleSwitch.Properties.Appearance.Options.UseFont = True
            Me.toggleSwitch.Properties.AutoWidth = True
            Me.toggleSwitch.Properties.OffText = "Off"
            Me.toggleSwitch.Properties.OnText = "On"
            Me.toggleSwitch.Size = New System.Drawing.Size(182, 43)
            Me.toggleSwitch.StyleController = Me.layoutControl1
            Me.toggleSwitch.TabIndex = 1
            AddHandler Me.toggleSwitch.Resize, New System.EventHandler(AddressOf Me.tsResize)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(752, 401)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Size = New System.Drawing.Size(452, 381)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.toggleSwitch
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MaxSize = New System.Drawing.Size(400, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(400, 53)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(400, 336)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.emptySpaceItem1})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(452, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(280, 184)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Toggle state"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.tsAllowMnemonics
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 1)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.tsAllowHTMLString
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 27)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.tsAllowThumbAnimation
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 55)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.btnToggleState
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 83)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(240, 30)
            Me.layoutControlItem5.Text = "On / Off:"
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 0)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(240, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(240, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(452, 184)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(280, 197)
            Me.layoutControlGroup4.Text = "Toggle properties"
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.tsTextOn
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem6.Text = "Text On:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.tsTextOff
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem7.Text = "Text Off:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.comboAlign
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(240, 90)
            Me.layoutControlItem8.Text = "Alignment:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(51, 13)
            ' 
            ' ModuleToggleSwitch
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleToggleSwitch"
            Me.Size = New System.Drawing.Size(1024, 623)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.tsTextOff.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.comboAlign.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tsTextOn.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tsAllowThumbAnimation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tsAllowHTMLString.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.tsAllowMnemonics.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.toggleSwitch.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private tsAllowHTMLString As DevExpress.XtraEditors.CheckEdit

        Private tsAllowMnemonics As DevExpress.XtraEditors.CheckEdit

        Private btnToggleState As DevExpress.XtraEditors.SimpleButton

        Private comboAlign As DevExpress.XtraEditors.ComboBoxEdit

        Private toggleSwitch As DevExpress.XtraEditors.ToggleSwitch

        Private tsTextOff As DevExpress.XtraEditors.TextEdit

        Private tsTextOn As DevExpress.XtraEditors.TextEdit

        Private tsAllowThumbAnimation As DevExpress.XtraEditors.CheckEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
