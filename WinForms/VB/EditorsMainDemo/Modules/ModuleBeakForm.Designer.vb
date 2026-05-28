Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleBeakForm

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
            Me.components = New System.ComponentModel.Container()
            Dim buttonImageOptions1 As DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions = New DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraEditors.Demos.ModuleBeakForm))
            Dim superToolTip1 As DevExpress.Utils.SuperToolTip = New DevExpress.Utils.SuperToolTip()
            Dim toolTipItem1 As DevExpress.Utils.ToolTipItem = New DevExpress.Utils.ToolTipItem()
            Me.cbeBeakLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.previewPanel = New DevExpress.XtraEditors.PanelControl()
            Me.prevewPanelHintLabel = New DevExpress.XtraEditors.LabelControl()
            Me.btnRemoveButton = New DevExpress.XtraEditors.SimpleButton()
            Me.btnAddButton = New DevExpress.XtraEditors.SimpleButton()
            Me.cbeButtonPanelAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceCloseOnOuterClick = New DevExpress.XtraEditors.CheckEdit()
            Me.borderColorEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.cbeButtonPanelLocation = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.ceShowButtonPanel = New DevExpress.XtraEditors.CheckEdit()
            Me.backColorEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.flyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.flyoutPanelHintLabel = New DevExpress.XtraEditors.LabelControl()
            Me.svgImageCollection1 = New DevExpress.Utils.SvgImageCollection(Me.components)
            CType((Me.cbeBeakLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.previewPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.previewPanel.SuspendLayout()
            CType((Me.cbeButtonPanelAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceCloseOnOuterClick.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.borderColorEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbeButtonPanelLocation.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowButtonPanel.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backColorEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.flyoutPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.flyoutPanel.SuspendLayout()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' cbeBeakLocation
            ' 
            Me.cbeBeakLocation.Location = New System.Drawing.Point(395, 53)
            Me.cbeBeakLocation.Name = "cbeBeakLocation"
            Me.cbeBeakLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeBeakLocation.Size = New System.Drawing.Size(154, 20)
            Me.cbeBeakLocation.StyleController = Me.layoutControl1
            Me.cbeBeakLocation.TabIndex = 5
            AddHandler Me.cbeBeakLocation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnBeakLocationChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.previewPanel)
            Me.layoutControl1.Controls.Add(Me.btnRemoveButton)
            Me.layoutControl1.Controls.Add(Me.btnAddButton)
            Me.layoutControl1.Controls.Add(Me.cbeBeakLocation)
            Me.layoutControl1.Controls.Add(Me.cbeButtonPanelAlignment)
            Me.layoutControl1.Controls.Add(Me.ceCloseOnOuterClick)
            Me.layoutControl1.Controls.Add(Me.borderColorEdit)
            Me.layoutControl1.Controls.Add(Me.cbeButtonPanelLocation)
            Me.layoutControl1.Controls.Add(Me.ceShowButtonPanel)
            Me.layoutControl1.Controls.Add(Me.backColorEdit)
            Me.layoutControl1.Location = New System.Drawing.Point(49, 17)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1043, 85, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(589, 344)
            Me.layoutControl1.TabIndex = 5
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' previewPanel
            ' 
            Me.previewPanel.Controls.Add(Me.prevewPanelHintLabel)
            Me.previewPanel.Location = New System.Drawing.Point(40, 172)
            Me.previewPanel.Name = "previewPanel"
            Me.previewPanel.Size = New System.Drawing.Size(193, 56)
            Me.previewPanel.TabIndex = 1
            AddHandler Me.previewPanel.MouseEnter, New System.EventHandler(AddressOf Me.OnPreviewPanelMouseEnter)
            ' 
            ' prevewPanelHintLabel
            ' 
            Me.prevewPanelHintLabel.Appearance.Options.UseTextOptions = True
            Me.prevewPanelHintLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.prevewPanelHintLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.prevewPanelHintLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.prevewPanelHintLabel.Location = New System.Drawing.Point(28, 11)
            Me.prevewPanelHintLabel.Name = "prevewPanelHintLabel"
            Me.prevewPanelHintLabel.Size = New System.Drawing.Size(133, 36)
            Me.prevewPanelHintLabel.TabIndex = 0
            Me.prevewPanelHintLabel.Text = "Move mouse here to show the Beak Form"
            ' 
            ' btnRemoveButton
            ' 
            Me.btnRemoveButton.Location = New System.Drawing.Point(431, 325)
            Me.btnRemoveButton.Name = "btnRemoveButton"
            Me.btnRemoveButton.Size = New System.Drawing.Size(118, 22)
            Me.btnRemoveButton.StyleController = Me.layoutControl1
            Me.btnRemoveButton.TabIndex = 13
            Me.btnRemoveButton.Text = "Remove Button"
            AddHandler Me.btnRemoveButton.Click, New System.EventHandler(AddressOf Me.OnRemoveButtonClick)
            ' 
            ' btnAddButton
            ' 
            Me.btnAddButton.Location = New System.Drawing.Point(313, 325)
            Me.btnAddButton.Name = "btnAddButton"
            Me.btnAddButton.Size = New System.Drawing.Size(114, 22)
            Me.btnAddButton.StyleController = Me.layoutControl1
            Me.btnAddButton.TabIndex = 12
            Me.btnAddButton.Text = "Add Button"
            AddHandler Me.btnAddButton.Click, New System.EventHandler(AddressOf Me.OnAddButtonClick)
            ' 
            ' cbeButtonPanelAlignment
            ' 
            Me.cbeButtonPanelAlignment.Location = New System.Drawing.Point(395, 297)
            Me.cbeButtonPanelAlignment.Name = "cbeButtonPanelAlignment"
            Me.cbeButtonPanelAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeButtonPanelAlignment.Properties.DropDownRows = 14
            Me.cbeButtonPanelAlignment.Size = New System.Drawing.Size(154, 20)
            Me.cbeButtonPanelAlignment.StyleController = Me.layoutControl1
            Me.cbeButtonPanelAlignment.TabIndex = 5
            AddHandler Me.cbeButtonPanelAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnButtonPanelAlignmentChanged)
            ' 
            ' ceCloseOnOuterClick
            ' 
            Me.ceCloseOnOuterClick.Location = New System.Drawing.Point(313, 137)
            Me.ceCloseOnOuterClick.Name = "ceCloseOnOuterClick"
            Me.ceCloseOnOuterClick.Properties.Caption = "Close On Outer Click"
            Me.ceCloseOnOuterClick.Size = New System.Drawing.Size(236, 20)
            Me.ceCloseOnOuterClick.StyleController = Me.layoutControl1
            Me.ceCloseOnOuterClick.TabIndex = 2
            AddHandler Me.ceCloseOnOuterClick.CheckedChanged, New System.EventHandler(AddressOf Me.OnCloseOnOuterClickFlagChanged)
            ' 
            ' borderColorEdit
            ' 
            Me.borderColorEdit.EditValue = System.Drawing.Color.Empty
            Me.borderColorEdit.Location = New System.Drawing.Point(395, 109)
            Me.borderColorEdit.Name = "borderColorEdit"
            Me.borderColorEdit.Properties.AutomaticBorderColor = System.Drawing.Color.Black
            Me.borderColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.borderColorEdit.Properties.AutomaticColorButtonCaption = "Reset Color"
            Me.borderColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.borderColorEdit.Size = New System.Drawing.Size(154, 20)
            Me.borderColorEdit.StyleController = Me.layoutControl1
            Me.borderColorEdit.TabIndex = 1
            AddHandler Me.borderColorEdit.ColorChanged, New System.EventHandler(AddressOf Me.OnBorderColorChanged)
            ' 
            ' cbeButtonPanelLocation
            ' 
            Me.cbeButtonPanelLocation.Location = New System.Drawing.Point(395, 269)
            Me.cbeButtonPanelLocation.Name = "cbeButtonPanelLocation"
            Me.cbeButtonPanelLocation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbeButtonPanelLocation.Size = New System.Drawing.Size(154, 20)
            Me.cbeButtonPanelLocation.StyleController = Me.layoutControl1
            Me.cbeButtonPanelLocation.TabIndex = 9
            AddHandler Me.cbeButtonPanelLocation.SelectedIndexChanged, New System.EventHandler(AddressOf Me.OnButtonPanelLocationChanged)
            ' 
            ' ceShowButtonPanel
            ' 
            Me.ceShowButtonPanel.Location = New System.Drawing.Point(313, 241)
            Me.ceShowButtonPanel.Name = "ceShowButtonPanel"
            Me.ceShowButtonPanel.Properties.Caption = "Show ButtonPanel"
            Me.ceShowButtonPanel.Size = New System.Drawing.Size(236, 20)
            Me.ceShowButtonPanel.StyleController = Me.layoutControl1
            Me.ceShowButtonPanel.TabIndex = 11
            AddHandler Me.ceShowButtonPanel.CheckedChanged, New System.EventHandler(AddressOf Me.OnShowButtonPanelFlagChanged)
            ' 
            ' backColorEdit
            ' 
            Me.backColorEdit.EditValue = System.Drawing.Color.Empty
            Me.backColorEdit.Location = New System.Drawing.Point(395, 81)
            Me.backColorEdit.Name = "backColorEdit"
            Me.backColorEdit.Properties.AutomaticBorderColor = System.Drawing.Color.Black
            Me.backColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.backColorEdit.Properties.AutomaticColorButtonCaption = "Reset Color"
            Me.backColorEdit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.backColorEdit.Size = New System.Drawing.Size(154, 20)
            Me.backColorEdit.StyleController = Me.layoutControl1
            Me.backColorEdit.TabIndex = 0
            AddHandler Me.backColorEdit.ColorChanged, New System.EventHandler(AddressOf Me.OnBackColorChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(581, 379)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.emptySpaceItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(281, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(280, 188)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup2.Text = "Appearance && Behavior Options"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.cbeBeakLocation
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem1.Text = "Beak Location:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.backColorEdit
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem2.Text = "Back Color:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.borderColorEdit
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem3.Text = "Border Color:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceCloseOnOuterClick
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 108)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(240, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(240, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(281, 188)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(280, 171)
            Me.layoutControlGroup3.Text = "ButtonPanel Appearance"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceShowButtonPanel
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(240, 26)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.cbeButtonPanelLocation
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(240, 28)
            Me.layoutControlItem6.Text = "Location:"
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.cbeButtonPanelAlignment
            Me.layoutControlItem7.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 6)
            Me.layoutControlItem7.Size = New System.Drawing.Size(240, 30)
            Me.layoutControlItem7.Text = "Alignment:"
            Me.layoutControlItem7.TextSize = New System.Drawing.Size(70, 13)
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.btnAddButton
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 84)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Size = New System.Drawing.Size(118, 26)
            Me.layoutControlItem8.TextVisible = False
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.btnRemoveButton
            Me.layoutControlItem9.Location = New System.Drawing.Point(118, 84)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Size = New System.Drawing.Size(122, 26)
            Me.layoutControlItem9.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem10})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(25, 25, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(281, 359)
            Me.layoutControlGroup4.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup4.Text = "Sample"
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Control = Me.previewPanel
            Me.layoutControlItem10.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem10.FillControlToClientArea = False
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem10.MaxSize = New System.Drawing.Size(197, 60)
            Me.layoutControlItem10.MinSize = New System.Drawing.Size(197, 60)
            Me.layoutControlItem10.Name = "layoutControlItem10"
            Me.layoutControlItem10.Size = New System.Drawing.Size(197, 298)
            Me.layoutControlItem10.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem10.TextVisible = False
            Me.layoutControlItem10.TrimClientAreaToControl = False
            ' 
            ' flyoutPanel
            ' 
            Me.flyoutPanel.Controls.Add(Me.flyoutPanelHintLabel)
            Me.flyoutPanel.Location = New System.Drawing.Point(27, 382)
            Me.flyoutPanel.Name = "flyoutPanel"
            Me.flyoutPanel.OptionsButtonPanel.AllowGlyphSkinning = True
            Me.flyoutPanel.OptionsButtonPanel.ButtonPanelHeight = 36
            buttonImageOptions1.SvgImage = CType((resources.GetObject("buttonImageOptions1.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            buttonImageOptions1.SvgImageSize = New System.Drawing.Size(16, 16)
            toolTipItem1.Text = "Exit"
            superToolTip1.Items.Add(toolTipItem1)
            Me.flyoutPanel.OptionsButtonPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.Utils.PeekFormButton("Button", False, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Exit", -1, True, superToolTip1, True, False, True, "Exit", -1, False)})
            Me.flyoutPanel.OptionsButtonPanel.ShowButtonPanel = True
            Me.flyoutPanel.OwnerControl = Me
            Me.flyoutPanel.Padding = New System.Windows.Forms.Padding(0, 36, 0, 0)
            Me.flyoutPanel.Size = New System.Drawing.Size(338, 120)
            Me.flyoutPanel.TabIndex = 2
            AddHandler Me.flyoutPanel.ButtonClick, New DevExpress.Utils.FlyoutPanelButtonClickEventHandler(AddressOf Me.OnFlyoutPanelButtonClick)
            ' 
            ' flyoutPanelHintLabel
            ' 
            Me.flyoutPanelHintLabel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.flyoutPanelHintLabel.Location = New System.Drawing.Point(90, 58)
            Me.flyoutPanelHintLabel.Name = "flyoutPanelHintLabel"
            Me.flyoutPanelHintLabel.Size = New System.Drawing.Size(152, 13)
            Me.flyoutPanelHintLabel.TabIndex = 0
            Me.flyoutPanelHintLabel.Text = "You can place any content here"
            ' 
            ' svgImageCollection1
            ' 
            Me.svgImageCollection1.Add("properties", "image://svgimages/setup/properties.svg")
            ' 
            ' ModuleBeakForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleBeakForm"
            Me.Size = New System.Drawing.Size(784, 527)
            CType((Me.cbeBeakLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.previewPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.previewPanel.ResumeLayout(False)
            CType((Me.cbeButtonPanelAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceCloseOnOuterClick.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.borderColorEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbeButtonPanelLocation.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowButtonPanel.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backColorEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.flyoutPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.flyoutPanel.ResumeLayout(False)
            Me.flyoutPanel.PerformLayout()
            CType((Me.svgImageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private prevewPanelHintLabel As DevExpress.XtraEditors.LabelControl

        Private flyoutPanel As DevExpress.Utils.FlyoutPanel

        Private flyoutPanelHintLabel As DevExpress.XtraEditors.LabelControl

        Private previewPanel As DevExpress.XtraEditors.PanelControl

        Private ceCloseOnOuterClick As DevExpress.XtraEditors.CheckEdit

        Private borderColorEdit As DevExpress.XtraEditors.ColorPickEdit

        Private backColorEdit As DevExpress.XtraEditors.ColorPickEdit

        Private cbeButtonPanelLocation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private cbeButtonPanelAlignment As DevExpress.XtraEditors.ImageComboBoxEdit

        Private ceShowButtonPanel As DevExpress.XtraEditors.CheckEdit

        Private btnRemoveButton As DevExpress.XtraEditors.SimpleButton

        Private btnAddButton As DevExpress.XtraEditors.SimpleButton

        Private cbeBeakLocation As DevExpress.XtraEditors.ImageComboBoxEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private svgImageCollection1 As DevExpress.Utils.SvgImageCollection
    End Class
End Namespace
