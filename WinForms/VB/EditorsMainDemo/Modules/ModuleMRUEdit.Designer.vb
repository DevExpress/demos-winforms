Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleMRUEdit

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
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.ceAllowAdding = New DevExpress.XtraEditors.CheckEdit()
            Me.ceShowCustomButtons = New DevExpress.XtraEditors.CheckEdit()
            Me.ceAllowRemoveItems = New DevExpress.XtraEditors.CheckEdit()
            Me.mruEditSample = New DevExpress.XtraEditors.MRUEdit()
            Me.seMaxItemCount = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ceAllowAdding.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceShowCustomButtons.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowRemoveItems.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.mruEditSample.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seMaxItemCount.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.ceAllowAdding)
            Me.layoutControl1.Controls.Add(Me.ceShowCustomButtons)
            Me.layoutControl1.Controls.Add(Me.ceAllowRemoveItems)
            Me.layoutControl1.Controls.Add(Me.mruEditSample)
            Me.layoutControl1.Controls.Add(Me.seMaxItemCount)
            Me.layoutControl1.Location = New System.Drawing.Point(28, 27)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(964, 27, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(517, 270)
            Me.layoutControl1.TabIndex = 3
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' ceAllowAdding
            ' 
            Me.ceAllowAdding.EditValue = True
            Me.ceAllowAdding.Location = New System.Drawing.Point(310, 212)
            Me.ceAllowAdding.Name = "ceAllowAdding"
            Me.ceAllowAdding.Properties.Caption = "Allow adding item to a mru list"
            Me.ceAllowAdding.Size = New System.Drawing.Size(186, 20)
            Me.ceAllowAdding.StyleController = Me.layoutControl1
            Me.ceAllowAdding.TabIndex = 0
            ' 
            ' ceShowCustomButtons
            ' 
            Me.ceShowCustomButtons.Location = New System.Drawing.Point(310, 109)
            Me.ceShowCustomButtons.Name = "ceShowCustomButtons"
            Me.ceShowCustomButtons.Properties.Caption = "Show custom buttons"
            Me.ceShowCustomButtons.Size = New System.Drawing.Size(186, 20)
            Me.ceShowCustomButtons.StyleController = Me.layoutControl1
            Me.ceShowCustomButtons.TabIndex = 2
            AddHandler Me.ceShowCustomButtons.CheckedChanged, New System.EventHandler(AddressOf Me.ceShowCustomButtons_CheckedChanged)
            ' 
            ' ceAllowRemoveItems
            ' 
            Me.ceAllowRemoveItems.Location = New System.Drawing.Point(310, 81)
            Me.ceAllowRemoveItems.Name = "ceAllowRemoveItems"
            Me.ceAllowRemoveItems.Properties.Caption = "Allow Remove MRU Items"
            Me.ceAllowRemoveItems.Size = New System.Drawing.Size(186, 20)
            Me.ceAllowRemoveItems.StyleController = Me.layoutControl1
            Me.ceAllowRemoveItems.TabIndex = 1
            AddHandler Me.ceAllowRemoveItems.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowRemoveItems_CheckedChanged)
            ' 
            ' mruEditSample
            ' 
            Me.mruEditSample.EditValue = "www.devexpress.com"
            Me.mruEditSample.Location = New System.Drawing.Point(32, 132)
            Me.mruEditSample.Name = "mruEditSample"
            editorButtonImageOptions1.EnableTransparency = False
            Me.mruEditSample.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo), New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open file", -1, True, True, False, editorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "Open file", Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
            Me.mruEditSample.Properties.Items.AddRange(New Object() {"www.devexpress.com", "www.devexpress.com/ClientCenter/Downloads/#Trials", "www.devexpress.com/ClientCenter/Purchase/"})
            Me.mruEditSample.Size = New System.Drawing.Size(206, 22)
            Me.mruEditSample.StyleController = Me.layoutControl1
            Me.mruEditSample.TabIndex = 0
            AddHandler Me.mruEditSample.AddingMRUItem, New DevExpress.XtraEditors.Controls.AddingMRUItemEventHandler(AddressOf Me.mruEditSample_AddingMRUItem)
            AddHandler Me.mruEditSample.ButtonClick, New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(AddressOf Me.mruEditSample_ButtonClick)
            ' 
            ' seMaxItemCount
            ' 
            Me.seMaxItemCount.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seMaxItemCount.Location = New System.Drawing.Point(397, 53)
            Me.seMaxItemCount.Name = "seMaxItemCount"
            Me.seMaxItemCount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seMaxItemCount.Properties.IsFloatValue = False
            Me.seMaxItemCount.Properties.Mask.EditMask = "N00"
            Me.seMaxItemCount.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seMaxItemCount.Size = New System.Drawing.Size(99, 20)
            Me.seMaxItemCount.StyleController = Me.layoutControl1
            Me.seMaxItemCount.TabIndex = 0
            AddHandler Me.seMaxItemCount.EditValueChanged, New System.EventHandler(AddressOf Me.seMaxItemCount_EditValueChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup2, Me.layoutControlGroup3, Me.layoutControlGroup4})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Size = New System.Drawing.Size(528, 265)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlGroup2
            ' 
            Me.layoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1})
            Me.layoutControlGroup2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup2.Name = "layoutControlGroup2"
            Me.layoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup2.Size = New System.Drawing.Size(278, 245)
            Me.layoutControlGroup2.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 30, 2, 2)
            Me.layoutControlGroup2.Text = "Sample"
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mruEditSample
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.layoutControlItem1.FillControlToClientArea = False
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(210, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(210, 184)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem1.TrimClientAreaToControl = False
            ' 
            ' layoutControlGroup3
            ' 
            Me.layoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4})
            Me.layoutControlGroup3.Location = New System.Drawing.Point(278, 0)
            Me.layoutControlGroup3.Name = "layoutControlGroup3"
            Me.layoutControlGroup3.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup3.Size = New System.Drawing.Size(230, 159)
            Me.layoutControlGroup3.Spacing = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 20)
            Me.layoutControlGroup3.Text = "Properties"
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.seMaxItemCount
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(190, 26)
            Me.layoutControlItem2.Text = "MaxItemCount:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(75, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.ceAllowRemoveItems
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(190, 28)
            Me.layoutControlItem3.TextVisible = False
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.ceShowCustomButtons
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem4.Size = New System.Drawing.Size(190, 26)
            Me.layoutControlItem4.TextVisible = False
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem5, Me.emptySpaceItem1})
            Me.layoutControlGroup4.Location = New System.Drawing.Point(278, 159)
            Me.layoutControlGroup4.Name = "layoutControlGroup4"
            Me.layoutControlGroup4.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 17, 17)
            Me.layoutControlGroup4.Size = New System.Drawing.Size(230, 86)
            Me.layoutControlGroup4.Text = "AddingMRUItem event"
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceAllowAdding
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Size = New System.Drawing.Size(190, 24)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' emptySpaceItem1
            ' 
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 24)
            Me.emptySpaceItem1.MaxSize = New System.Drawing.Size(0, 1)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(190, 1)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            ' 
            ' ModuleMRUEdit
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "ModuleMRUEdit"
            Me.Size = New System.Drawing.Size(799, 524)
            AddHandler Me.Load, New System.EventHandler(AddressOf Me.ModuleMRUEdit_Load)
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ceAllowAdding.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceShowCustomButtons.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowRemoveItems.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.mruEditSample.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seMaxItemCount.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private mruEditSample As DevExpress.XtraEditors.MRUEdit

        Private seMaxItemCount As DevExpress.XtraEditors.SpinEdit

        Private ceShowCustomButtons As DevExpress.XtraEditors.CheckEdit

        Private ceAllowAdding As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private ceAllowRemoveItems As DevExpress.XtraEditors.CheckEdit

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    End Class
End Namespace
