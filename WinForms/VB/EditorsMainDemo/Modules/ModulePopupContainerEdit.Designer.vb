Namespace DevExpress.XtraEditors.Demos

    Partial Class ModulePopupContainerEdit

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
            Me.icbShowDropDown = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowPopupShadow = New DevExpress.XtraEditors.CheckEdit()
            Me.cePopupSizeable = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowPopupCloseButton = New DevExpress.XtraEditors.CheckEdit()
            Me.ceCloseOnOuterMouseClick = New DevExpress.XtraEditors.CheckEdit()
            Me.lbSample = New DevExpress.XtraEditors.LabelControl()
            Me.popupContainerEditSample = New DevExpress.XtraEditors.PopupContainerEdit()
            Me.popupContainerControlSample = New DevExpress.XtraEditors.PopupContainerControl()
            Me.splitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.ilbFont = New DevExpress.XtraEditors.ImageListBoxControl()
            Me.label2 = New DevExpress.XtraEditors.LabelControl()
            Me.clbStyle = New DevExpress.XtraEditors.CheckedListBoxControl()
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.seSize = New DevExpress.XtraEditors.SpinEdit()
            Me.label1 = New DevExpress.XtraEditors.LabelControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbShowDropDown.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowPopupShadow.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cePopupSizeable.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowPopupCloseButton.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCloseOnOuterMouseClick.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.popupContainerControlSample), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.popupContainerControlSample.SuspendLayout()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.splitContainerControl1.Panel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel1.SuspendLayout()
            CType((Me.splitContainerControl1.Panel2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.splitContainerControl1.Panel2.SuspendLayout()
            Me.splitContainerControl1.SuspendLayout()
            CType((Me.ilbFont), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.clbStyle), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seSize.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbShowDropDown)
            Me.layoutControl1.Controls.Add(Me.ceShowPopupShadow)
            Me.layoutControl1.Controls.Add(Me.cePopupSizeable)
            Me.layoutControl1.Controls.Add(Me.ceShowPopupCloseButton)
            Me.layoutControl1.Controls.Add(Me.ceCloseOnOuterMouseClick)
            Me.layoutControl1.Controls.Add(Me.lbSample)
            Me.layoutControl1.Controls.Add(Me.popupContainerEditSample)
            Me.layoutControl1.Location = New System.Drawing.Point(20, 25)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(976, 0, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(587, 251)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbShowDropDown
            ' 
            Me.icbShowDropDown.EditValue = "imageComboBoxEdit1"
            Me.icbShowDropDown.Location = New System.Drawing.Point(447, 156)
            Me.icbShowDropDown.Name = "icbShowDropDown"
            Me.icbShowDropDown.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbShowDropDown.Size = New System.Drawing.Size(91, 20)
            Me.icbShowDropDown.StyleController = Me.layoutControl1
            Me.icbShowDropDown.TabIndex = 0
            AddHandler Me.icbShowDropDown.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbShowDropDown_SelectedIndexChanged)
            ' 
            ' ceShowPopupShadow
            ' 
            Me.ceShowPopupShadow.Location = New System.Drawing.Point(352, 240)
            Me.ceShowPopupShadow.Name = "ceShowPopupShadow"
            Me.ceShowPopupShadow.Properties.Caption = "Show popup shadow"
            Me.ceShowPopupShadow.Size = New System.Drawing.Size(186, 20)
            Me.ceShowPopupShadow.StyleController = Me.layoutControl1
            Me.ceShowPopupShadow.TabIndex = 3
            AddHandler Me.ceShowPopupShadow.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowPopupShadow_CheckedChanged)
            ' 
            ' cePopupSizeable
            ' 
            Me.cePopupSizeable.Location = New System.Drawing.Point(352, 184)
            Me.cePopupSizeable.Name = "cePopupSizeable"
            Me.cePopupSizeable.Properties.Caption = "Popup sizeable"
            Me.cePopupSizeable.Size = New System.Drawing.Size(186, 20)
            Me.cePopupSizeable.StyleController = Me.layoutControl1
            Me.cePopupSizeable.TabIndex = 1
            AddHandler Me.cePopupSizeable.CheckedChanged, New System.EventHandler(AddressOf Me.cePopupSizeable_CheckedChanged)
            ' 
            ' ceShowPopupCloseButton
            ' 
            Me.ceShowPopupCloseButton.Location = New System.Drawing.Point(352, 212)
            Me.ceShowPopupCloseButton.Name = "ceShowPopupCloseButton"
            Me.ceShowPopupCloseButton.Properties.Caption = "Show Popup Close button"
            Me.ceShowPopupCloseButton.Size = New System.Drawing.Size(186, 20)
            Me.ceShowPopupCloseButton.StyleController = Me.layoutControl1
            Me.ceShowPopupCloseButton.TabIndex = 2
            AddHandler Me.ceShowPopupCloseButton.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowPopupCloseButton_CheckedChanged)
            ' 
            ' ceCloseOnOuterMouseClick
            ' 
            Me.ceCloseOnOuterMouseClick.Location = New System.Drawing.Point(352, 53)
            Me.ceCloseOnOuterMouseClick.Name = "ceCloseOnOuterMouseClick"
            Me.ceCloseOnOuterMouseClick.Properties.Caption = "Close on outer mouse click"
            Me.ceCloseOnOuterMouseClick.Size = New System.Drawing.Size(186, 20)
            Me.ceCloseOnOuterMouseClick.StyleController = Me.layoutControl1
            Me.ceCloseOnOuterMouseClick.TabIndex = 1
            AddHandler Me.ceCloseOnOuterMouseClick.CheckedChanged, New System.EventHandler(AddressOf Me.ceCloseOnOuterMouseClick_CheckedChanged)
            ' 
            ' lbSample
            ' 
            Me.lbSample.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbSample.Appearance.Options.UseFont = True
            Me.lbSample.Appearance.Options.UseTextOptions = True
            Me.lbSample.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.lbSample.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.lbSample.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lbSample.Location = New System.Drawing.Point(32, 53)
            Me.lbSample.Name = "lbSample"
            Me.lbSample.Size = New System.Drawing.Size(248, 13)
            Me.lbSample.StyleController = Me.layoutControl1
            Me.lbSample.TabIndex = 1
            Me.lbSample.Text = "Font Sample"
            ' 
            ' popupContainerEditSample
            ' 
            Me.popupContainerEditSample.EditValue = "popupContainerEdit1"
            Me.popupContainerEditSample.Location = New System.Drawing.Point(32, 155)
            Me.popupContainerEditSample.Name = "popupContainerEditSample"
            Me.popupContainerEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.popupContainerEditSample.Properties.PopupControl = Me.popupContainerControlSample
            Me.popupContainerEditSample.Size = New System.Drawing.Size(248, 20)
            Me.popupContainerEditSample.StyleController = Me.layoutControl1
            Me.popupContainerEditSample.TabIndex = 0
            AddHandler Me.popupContainerEditSample.QueryResultValue, New DevExpress.XtraEditors.Controls.QueryResultValueEventHandler(AddressOf Me.popupContainerEditSample_QueryResultValue)
            AddHandler Me.popupContainerEditSample.QueryPopUp, New System.ComponentModel.CancelEventHandler(AddressOf Me.popupContainerEditSample_QueryPopUp)
            ' 
            ' popupContainerControlSample
            ' 
            Me.popupContainerControlSample.Controls.Add(Me.splitContainerControl1)
            Me.popupContainerControlSample.Location = New System.Drawing.Point(20, 306)
            Me.popupContainerControlSample.Name = "popupContainerControlSample"
            Me.popupContainerControlSample.Padding = New System.Windows.Forms.Padding(4)
            Me.popupContainerControlSample.Size = New System.Drawing.Size(384, 225)
            Me.popupContainerControlSample.TabIndex = 2
            ' 
            ' splitContainerControl1
            ' 
            Me.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainerControl1.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2
            Me.splitContainerControl1.Location = New System.Drawing.Point(4, 4)
            Me.splitContainerControl1.Name = "splitContainerControl1"
            ' 
            ' splitContainerControl1.Panel1
            ' 
            Me.splitContainerControl1.Panel1.Controls.Add(Me.ilbFont)
            Me.splitContainerControl1.Panel1.Controls.Add(Me.label2)
            Me.splitContainerControl1.Panel1.Text = "splitContainerControl1_Panel1"
            ' 
            ' splitContainerControl1.Panel2
            ' 
            Me.splitContainerControl1.Panel2.Controls.Add(Me.clbStyle)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.label3)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.seSize)
            Me.splitContainerControl1.Panel2.Controls.Add(Me.label1)
            Me.splitContainerControl1.Panel2.Text = "splitContainerControl1_Panel2"
            Me.splitContainerControl1.Size = New System.Drawing.Size(376, 217)
            Me.splitContainerControl1.SplitterPosition = 107
            Me.splitContainerControl1.TabIndex = 0
            Me.splitContainerControl1.Text = "splitContainerControl1"
            ' 
            ' ilbFont
            ' 
            Me.ilbFont.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ilbFont.ItemHeight = 16
            Me.ilbFont.Location = New System.Drawing.Point(0, 17)
            Me.ilbFont.Name = "ilbFont"
            Me.ilbFont.Size = New System.Drawing.Size(259, 200)
            Me.ilbFont.TabIndex = 14
            AddHandler Me.ilbFont.DoubleClick, New System.EventHandler(AddressOf Me.ilbFont_DoubleClick)
            AddHandler Me.ilbFont.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.popupFont_KeyDown)
            ' 
            ' label2
            ' 
            Me.label2.Dock = System.Windows.Forms.DockStyle.Top
            Me.label2.Location = New System.Drawing.Point(0, 0)
            Me.label2.Name = "label2"
            Me.label2.Padding = New System.Windows.Forms.Padding(2)
            Me.label2.Size = New System.Drawing.Size(30, 17)
            Me.label2.TabIndex = 15
            Me.label2.Text = "Font:"
            ' 
            ' clbStyle
            ' 
            Me.clbStyle.CheckOnClick = True
            Me.clbStyle.Cursor = System.Windows.Forms.Cursors.[Default]
            Me.clbStyle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.clbStyle.ItemAutoHeight = True
            Me.clbStyle.Items.AddRange(New DevExpress.XtraEditors.Controls.CheckedListBoxItem() {New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Bold"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Italic"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Strikeout"), New DevExpress.XtraEditors.Controls.CheckedListBoxItem("Underline")})
            Me.clbStyle.Location = New System.Drawing.Point(0, 17)
            Me.clbStyle.Name = "clbStyle"
            Me.clbStyle.Size = New System.Drawing.Size(107, 163)
            Me.clbStyle.TabIndex = 17
            AddHandler Me.clbStyle.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.popupFont_KeyDown)
            ' 
            ' label3
            ' 
            Me.label3.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.label3.Location = New System.Drawing.Point(0, 180)
            Me.label3.Name = "label3"
            Me.label3.Padding = New System.Windows.Forms.Padding(2)
            Me.label3.Size = New System.Drawing.Size(27, 17)
            Me.label3.TabIndex = 19
            Me.label3.Text = "Size:"
            ' 
            ' seSize
            ' 
            Me.seSize.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.seSize.EditValue = New Decimal(New Integer() {7, 0, 0, 0})
            Me.seSize.Location = New System.Drawing.Point(0, 197)
            Me.seSize.Name = "seSize"
            Me.seSize.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seSize.Properties.MaxValue = New Decimal(New Integer() {50, 0, 0, 0})
            Me.seSize.Properties.MinValue = New Decimal(New Integer() {6, 0, 0, 0})
            Me.seSize.Properties.ValidateOnEnterKey = True
            Me.seSize.Size = New System.Drawing.Size(107, 20)
            Me.seSize.TabIndex = 18
            AddHandler Me.seSize.KeyDown, New System.Windows.Forms.KeyEventHandler(AddressOf Me.popupFont_KeyDown)
            ' 
            ' label1
            ' 
            Me.label1.Dock = System.Windows.Forms.DockStyle.Top
            Me.label1.Location = New System.Drawing.Point(0, 0)
            Me.label1.Name = "label1"
            Me.label1.Padding = New System.Windows.Forms.Padding(2)
            Me.label1.Size = New System.Drawing.Size(57, 17)
            Me.label1.TabIndex = 16
            Me.label1.Text = "Font Style:"
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(570, 293)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(320, 273)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.popupContainerEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 17)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(151, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(252, 194)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.lbSample
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(252, 17)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 211)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(252, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem3})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(320, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(230, 103)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceCloseOnOuterMouseClick
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.emptySpaceItem2})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(320, 103)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(230, 170)
            Me.layoutControlGroup4.Text = "Popup properties"
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.icbShowDropDown
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(190, 26)
            Me.layoutControlItem4.Text = "Show DropDown:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(83, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.cePopupSizeable
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceShowPopupCloseButton
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.ceShowPopupShadow
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem7.Size = New System.Drawing.Size(190, 26)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' emptySpaceItem2
            ' 
            Me.emptySpaceItem2.Location = New System.Drawing.Point(0, 108)
            Me.emptySpaceItem2.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem2.MinSize = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem2.Name = "emptySpaceItem2"
            Me.emptySpaceItem2.Size = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModulePopupContainerEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModulePopupContainerEdit"
            Me.Size = New System.Drawing.Size(785, 562)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModulePopupContainerEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbShowDropDown.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowPopupShadow.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cePopupSizeable.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowPopupCloseButton.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCloseOnOuterMouseClick.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.popupContainerControlSample), System.ComponentModel.ISupportInitialize).EndInit()
            Me.popupContainerControlSample.ResumeLayout(False)
            CType((Me.splitContainerControl1.Panel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel1.ResumeLayout(False)
            Me.splitContainerControl1.Panel1.PerformLayout()
            CType((Me.splitContainerControl1.Panel2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.Panel2.ResumeLayout(False)
            Me.splitContainerControl1.Panel2.PerformLayout()
            CType((Me.splitContainerControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.splitContainerControl1.ResumeLayout(False)
            CType((Me.ilbFont), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.clbStyle), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seSize.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private popupContainerEditSample As DevExpress.XtraEditors.PopupContainerEdit

        Private popupContainerControlSample As DevExpress.XtraEditors.PopupContainerControl

        Private splitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl

        Private label2 As DevExpress.XtraEditors.LabelControl

        Private ilbFont As DevExpress.XtraEditors.ImageListBoxControl

        Private label1 As DevExpress.XtraEditors.LabelControl

        Private label3 As DevExpress.XtraEditors.LabelControl

        Private clbStyle As DevExpress.XtraEditors.CheckedListBoxControl

        Private seSize As DevExpress.XtraEditors.SpinEdit

        Private lbSample As DevExpress.XtraEditors.LabelControl

        Private icbShowDropDown As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cePopupSizeable As DevExpress.XtraEditors.CheckEdit

        Private ceShowPopupShadow As DevExpress.XtraEditors.CheckEdit

        Private ceShowPopupCloseButton As DevExpress.XtraEditors.CheckEdit

        Private ceCloseOnOuterMouseClick As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
