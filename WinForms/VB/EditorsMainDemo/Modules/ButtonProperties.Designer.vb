Namespace DevExpress.XtraEditors.Demos

    Partial Class ButtonProperties

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
            Me.teCaption = New DevExpress.XtraEditors.TextEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.icbAlignment = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.sbImageClear = New DevExpress.XtraEditors.SimpleButton()
            Me.sbImageLoad = New DevExpress.XtraEditors.SimpleButton()
            Me.teToolTip = New DevExpress.XtraEditors.TextEdit()
            Me.icbKind = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.seWidth = New DevExpress.XtraEditors.SpinEdit()
            Me.ceEnabled = New DevExpress.XtraEditors.CheckEdit()
            Me.ceVisible = New DevExpress.XtraEditors.CheckEdit()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.teCaption.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.icbAlignment.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.teToolTip.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.icbKind.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seWidth.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceEnabled.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceVisible.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' teCaption
            ' 
            Me.teCaption.EditValue = ""
            Me.teCaption.Location = New System.Drawing.Point(107, 18)
            Me.teCaption.Name = "teCaption"
            Me.teCaption.Size = New System.Drawing.Size(134, 20)
            Me.teCaption.StyleController = Me.layoutControl1
            Me.teCaption.TabIndex = 16
            AddHandler Me.teCaption.EditValueChanged, New System.EventHandler(AddressOf Me.teCaption_EditValueChanged)
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.icbAlignment)
            Me.layoutControl1.Controls.Add(Me.sbImageClear)
            Me.layoutControl1.Controls.Add(Me.sbImageLoad)
            Me.layoutControl1.Controls.Add(Me.teCaption)
            Me.layoutControl1.Controls.Add(Me.teToolTip)
            Me.layoutControl1.Controls.Add(Me.icbKind)
            Me.layoutControl1.Controls.Add(Me.seWidth)
            Me.layoutControl1.Controls.Add(Me.ceEnabled)
            Me.layoutControl1.Controls.Add(Me.ceVisible)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.MinimumSize = New System.Drawing.Size(250, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(663, 370, 650, 400)
            Me.layoutControl1.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(259, 258)
            Me.layoutControl1.TabIndex = 27
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' icbAlignment
            ' 
            Me.icbAlignment.EditValue = "imageComboBoxEdit1"
            Me.icbAlignment.Location = New System.Drawing.Point(107, 216)
            Me.icbAlignment.Name = "icbAlignment"
            Me.icbAlignment.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbAlignment.Properties.DropDownRows = 15
            Me.icbAlignment.Size = New System.Drawing.Size(134, 20)
            Me.icbAlignment.StyleController = Me.layoutControl1
            Me.icbAlignment.TabIndex = 26
            AddHandler Me.icbAlignment.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbAlignment_SelectedIndexChanged)
            ' 
            ' sbImageClear
            ' 
            Me.sbImageClear.Location = New System.Drawing.Point(170, 186)
            Me.sbImageClear.Name = "sbImageClear"
            Me.sbImageClear.Size = New System.Drawing.Size(71, 22)
            Me.sbImageClear.StyleController = Me.layoutControl1
            Me.sbImageClear.TabIndex = 25
            Me.sbImageClear.Text = "Clear"
            AddHandler Me.sbImageClear.Click, New System.EventHandler(AddressOf Me.sbImageClear_Click)
            ' 
            ' sbImageLoad
            ' 
            Me.sbImageLoad.Location = New System.Drawing.Point(107, 186)
            Me.sbImageLoad.Name = "sbImageLoad"
            Me.sbImageLoad.Size = New System.Drawing.Size(59, 22)
            Me.sbImageLoad.StyleController = Me.layoutControl1
            Me.sbImageLoad.TabIndex = 24
            Me.sbImageLoad.Text = "Load"
            AddHandler Me.sbImageLoad.Click, New System.EventHandler(AddressOf Me.sbImageLoad_Click)
            ' 
            ' teToolTip
            ' 
            Me.teToolTip.EditValue = ""
            Me.teToolTip.Location = New System.Drawing.Point(107, 46)
            Me.teToolTip.Name = "teToolTip"
            Me.teToolTip.Size = New System.Drawing.Size(134, 20)
            Me.teToolTip.StyleController = Me.layoutControl1
            Me.teToolTip.TabIndex = 17
            AddHandler Me.teToolTip.EditValueChanged, New System.EventHandler(AddressOf Me.teToolTip_EditValueChanged)
            ' 
            ' icbKind
            ' 
            Me.icbKind.EditValue = "imageComboBoxEdit1"
            Me.icbKind.Location = New System.Drawing.Point(107, 74)
            Me.icbKind.Name = "icbKind"
            Me.icbKind.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.icbKind.Properties.DropDownRows = 15
            Me.icbKind.Size = New System.Drawing.Size(134, 20)
            Me.icbKind.StyleController = Me.layoutControl1
            Me.icbKind.TabIndex = 18
            AddHandler Me.icbKind.SelectedIndexChanged, New System.EventHandler(AddressOf Me.icbKind_SelectedIndexChanged)
            ' 
            ' seWidth
            ' 
            Me.seWidth.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
            Me.seWidth.Location = New System.Drawing.Point(107, 102)
            Me.seWidth.Name = "seWidth"
            Me.seWidth.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seWidth.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.[Default]
            Me.seWidth.Properties.IsFloatValue = False
            Me.seWidth.Properties.Mask.EditMask = "N00"
            Me.seWidth.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seWidth.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, -2147483648})
            Me.seWidth.Size = New System.Drawing.Size(134, 20)
            Me.seWidth.StyleController = Me.layoutControl1
            Me.seWidth.TabIndex = 19
            AddHandler Me.seWidth.EditValueChanged, New System.EventHandler(AddressOf Me.seWidth_EditValueChanged)
            ' 
            ' ceEnabled
            ' 
            Me.ceEnabled.Location = New System.Drawing.Point(18, 130)
            Me.ceEnabled.Name = "ceEnabled"
            Me.ceEnabled.Properties.Caption = "Enabled"
            Me.ceEnabled.Size = New System.Drawing.Size(223, 20)
            Me.ceEnabled.StyleController = Me.layoutControl1
            Me.ceEnabled.TabIndex = 20
            AddHandler Me.ceEnabled.CheckedChanged, New System.EventHandler(AddressOf Me.ceEnabled_CheckedChanged)
            ' 
            ' ceVisible
            ' 
            Me.ceVisible.Location = New System.Drawing.Point(18, 158)
            Me.ceVisible.Name = "ceVisible"
            Me.ceVisible.Properties.Caption = "Visible"
            Me.ceVisible.Size = New System.Drawing.Size(223, 20)
            Me.ceVisible.StyleController = Me.layoutControl1
            Me.ceVisible.TabIndex = 21
            AddHandler Me.ceVisible.CheckedChanged, New System.EventHandler(AddressOf Me.ceVisible_CheckedChanged)
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem3, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.layoutControlItem7, Me.layoutControlItem8, Me.layoutControlItem9})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(16, 16, 16, 16)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(259, 258)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.teCaption
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 4)
            Me.layoutControlItem1.Size = New System.Drawing.Size(227, 26)
            Me.layoutControlItem1.Text = "Caption:"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.teToolTip
            Me.layoutControlItem2.Location = New System.Drawing.Point(0, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem2.Size = New System.Drawing.Size(227, 28)
            Me.layoutControlItem2.Text = "Tooltip:"
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem3
            ' 
            Me.layoutControlItem3.Control = Me.icbKind
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 54)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem3.Size = New System.Drawing.Size(227, 28)
            Me.layoutControlItem3.Text = "Kind:"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem4
            ' 
            Me.layoutControlItem4.Control = Me.seWidth
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 82)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem4.Size = New System.Drawing.Size(227, 28)
            Me.layoutControlItem4.Text = "Width:"
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem5
            ' 
            Me.layoutControlItem5.Control = Me.ceEnabled
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 110)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem5.Size = New System.Drawing.Size(227, 28)
            Me.layoutControlItem5.TextVisible = False
            ' 
            ' layoutControlItem6
            ' 
            Me.layoutControlItem6.Control = Me.ceVisible
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 138)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem6.Size = New System.Drawing.Size(227, 28)
            Me.layoutControlItem6.TextVisible = False
            ' 
            ' layoutControlItem7
            ' 
            Me.layoutControlItem7.Control = Me.sbImageClear
            Me.layoutControlItem7.Location = New System.Drawing.Point(152, 166)
            Me.layoutControlItem7.Name = "layoutControlItem7"
            Me.layoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem7.Size = New System.Drawing.Size(75, 30)
            Me.layoutControlItem7.TextVisible = False
            ' 
            ' layoutControlItem8
            ' 
            Me.layoutControlItem8.Control = Me.sbImageLoad
            Me.layoutControlItem8.Location = New System.Drawing.Point(0, 166)
            Me.layoutControlItem8.Name = "layoutControlItem8"
            Me.layoutControlItem8.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 4)
            Me.layoutControlItem8.Size = New System.Drawing.Size(152, 30)
            Me.layoutControlItem8.Text = "Image:"
            Me.layoutControlItem8.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Control = Me.icbAlignment
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 196)
            Me.layoutControlItem9.Name = "layoutControlItem9"
            Me.layoutControlItem9.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 4, 2)
            Me.layoutControlItem9.Size = New System.Drawing.Size(227, 30)
            Me.layoutControlItem9.Text = "Image Location:"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(77, 13)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.panelControl1.Appearance.Options.UseBackColor = True
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.layoutControl1)
            Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.panelControl1.Location = New System.Drawing.Point(0, 0)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(259, 258)
            Me.panelControl1.TabIndex = 22
            ' 
            ' ButtonProperties
            ' 
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
            Me.Controls.Add(Me.panelControl1)
            Me.Name = "ButtonProperties"
            Me.Size = New System.Drawing.Size(259, 258)
            CType((Me.teCaption.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.icbAlignment.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.teToolTip.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.icbKind.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seWidth.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceEnabled.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceVisible.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem7), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem8), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private teCaption As DevExpress.XtraEditors.TextEdit

        Private teToolTip As DevExpress.XtraEditors.TextEdit

        Private icbKind As DevExpress.XtraEditors.ImageComboBoxEdit

        Private seWidth As DevExpress.XtraEditors.SpinEdit

        Private ceEnabled As DevExpress.XtraEditors.CheckEdit

        Private ceVisible As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.Container = Nothing

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private sbImageLoad As DevExpress.XtraEditors.SimpleButton

        Private icbAlignment As DevExpress.XtraEditors.ImageComboBoxEdit

        Private sbImageClear As DevExpress.XtraEditors.SimpleButton

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
