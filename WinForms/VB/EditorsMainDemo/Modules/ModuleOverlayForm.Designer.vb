Namespace DevExpress.XtraEditors.Demos

    Partial Class ModuleOverlayForm

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
            Me.layoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.cbViewType = New DevExpress.XtraEditors.ImageComboBoxEdit()
            Me.backColorEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.btnShow = New DevExpress.XtraEditors.SimpleButton()
            Me.allowFadeInCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.allowFadeOutCheckEdit = New DevExpress.XtraEditors.CheckEdit()
            Me.foreColorEdit = New DevExpress.XtraEditors.ColorPickEdit()
            Me.spinOpacity = New DevExpress.XtraEditors.SpinEdit()
            Me.layoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlGroup5 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.liBackColor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liForeColor = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liOpacity = New DevExpress.XtraLayout.LayoutControlItem()
            Me.liViewType = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlGroup6 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem16 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl.SuspendLayout()
            CType((Me.cbViewType.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.backColorEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowFadeInCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.allowFadeOutCheckEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.foreColorEdit.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.spinOpacity.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liBackColor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liForeColor), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liOpacity), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.liViewType), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' layoutControl
            ' 
            Me.layoutControl.AllowCustomization = False
            Me.layoutControl.Controls.Add(Me.cbViewType)
            Me.layoutControl.Controls.Add(Me.backColorEdit)
            Me.layoutControl.Controls.Add(Me.btnShow)
            Me.layoutControl.Controls.Add(Me.allowFadeInCheckEdit)
            Me.layoutControl.Controls.Add(Me.allowFadeOutCheckEdit)
            Me.layoutControl.Controls.Add(Me.foreColorEdit)
            Me.layoutControl.Controls.Add(Me.spinOpacity)
            Me.layoutControl.HiddenItems.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem9, Me.layoutControlItem10})
            Me.layoutControl.Location = New System.Drawing.Point(237, 135)
            Me.layoutControl.Name = "layoutControl"
            Me.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(1014, 140, 650, 400)
            Me.layoutControl.OptionsView.UseParentAutoScaleFactor = True
            Me.layoutControl.Root = Me.layoutControlGroup4
            Me.layoutControl.Size = New System.Drawing.Size(320, 257)
            Me.layoutControl.TabIndex = 6
            Me.layoutControl.Text = "layoutControl2"
            ' 
            ' cbViewType
            ' 
            Me.cbViewType.Location = New System.Drawing.Point(139, 45)
            Me.cbViewType.Name = "cbViewType"
            Me.cbViewType.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbViewType.Size = New System.Drawing.Size(132, 20)
            Me.cbViewType.StyleController = Me.layoutControl
            Me.cbViewType.TabIndex = 17
            AddHandler Me.cbViewType.EditValueChanged, New System.EventHandler(AddressOf Me.OnViewTypeChanged)
            ' 
            ' backColorEdit
            ' 
            Me.backColorEdit.EditValue = System.Drawing.Color.Empty
            Me.backColorEdit.Location = New System.Drawing.Point(139, 69)
            Me.backColorEdit.Name = "backColorEdit"
            Me.backColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.backColorEdit.Properties.ColorDialogOptions.AllowTransparency = False
            Me.backColorEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Simple
            Me.backColorEdit.Size = New System.Drawing.Size(132, 20)
            Me.backColorEdit.StyleController = Me.layoutControl
            Me.backColorEdit.TabIndex = 4
            AddHandler Me.backColorEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnBackColorEditValueChanged)
            ' 
            ' btnShow
            ' 
            Me.btnShow.Location = New System.Drawing.Point(24, 242)
            Me.btnShow.Name = "btnShow"
            Me.btnShow.Size = New System.Drawing.Size(255, 22)
            Me.btnShow.StyleController = Me.layoutControl
            Me.btnShow.TabIndex = 12
            Me.btnShow.Text = "Show Preview"
            AddHandler Me.btnShow.Click, New System.EventHandler(AddressOf Me.OnShowClick)
            ' 
            ' allowFadeInCheckEdit
            ' 
            Me.allowFadeInCheckEdit.EditValue = True
            Me.allowFadeInCheckEdit.Location = New System.Drawing.Point(139, 141)
            Me.allowFadeInCheckEdit.Name = "allowFadeInCheckEdit"
            Me.allowFadeInCheckEdit.Properties.Caption = "Allow Fade In Effect"
            Me.allowFadeInCheckEdit.Size = New System.Drawing.Size(132, 20)
            Me.allowFadeInCheckEdit.StyleController = Me.layoutControl
            Me.allowFadeInCheckEdit.TabIndex = 13
            AddHandler Me.allowFadeInCheckEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnAllowFadeInEditValueChanged)
            ' 
            ' allowFadeOutCheckEdit
            ' 
            Me.allowFadeOutCheckEdit.EditValue = True
            Me.allowFadeOutCheckEdit.Location = New System.Drawing.Point(139, 165)
            Me.allowFadeOutCheckEdit.Name = "allowFadeOutCheckEdit"
            Me.allowFadeOutCheckEdit.Properties.Caption = "Allow Fade Out Effect"
            Me.allowFadeOutCheckEdit.Size = New System.Drawing.Size(132, 20)
            Me.allowFadeOutCheckEdit.StyleController = Me.layoutControl
            Me.allowFadeOutCheckEdit.TabIndex = 14
            AddHandler Me.allowFadeOutCheckEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnAllowFadeOutEditValueChanged)
            ' 
            ' foreColorEdit
            ' 
            Me.foreColorEdit.EditValue = System.Drawing.Color.Empty
            Me.foreColorEdit.Location = New System.Drawing.Point(139, 93)
            Me.foreColorEdit.Name = "foreColorEdit"
            Me.foreColorEdit.Properties.AutomaticColor = System.Drawing.Color.Black
            Me.foreColorEdit.Properties.ColorDialogType = DevExpress.XtraEditors.Popup.ColorDialogType.Simple
            Me.foreColorEdit.Size = New System.Drawing.Size(132, 20)
            Me.foreColorEdit.StyleController = Me.layoutControl
            Me.foreColorEdit.TabIndex = 4
            AddHandler Me.foreColorEdit.EditValueChanged, New System.EventHandler(AddressOf Me.OnForeColorEditValueChanged)
            ' 
            ' spinOpacity
            ' 
            Me.spinOpacity.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.spinOpacity.Location = New System.Drawing.Point(139, 117)
            Me.spinOpacity.Name = "spinOpacity"
            Me.spinOpacity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.spinOpacity.Properties.Mask.EditMask = "n0"
            Me.spinOpacity.Properties.MaxValue = New Decimal(New Integer() {255, 0, 0, 0})
            Me.spinOpacity.Size = New System.Drawing.Size(132, 20)
            Me.spinOpacity.StyleController = Me.layoutControl
            Me.spinOpacity.TabIndex = 16
            AddHandler Me.spinOpacity.EditValueChanged, New System.EventHandler(AddressOf Me.OnOpacityEditValueChanged)
            ' 
            ' layoutControlItem9
            ' 
            Me.layoutControlItem9.Location = New System.Drawing.Point(0, 91)
            Me.layoutControlItem9.Name = "layoutControlItem6"
            Me.layoutControlItem9.OptionsTableLayoutItem.RowIndex = 1
            Me.layoutControlItem9.Size = New System.Drawing.Size(158, 92)
            Me.layoutControlItem9.Text = "Opacity"
            Me.layoutControlItem9.TextSize = New System.Drawing.Size(84, 13)
            ' 
            ' layoutControlItem10
            ' 
            Me.layoutControlItem10.Location = New System.Drawing.Point(0, 183)
            Me.layoutControlItem10.Name = "layoutControlItem4"
            Me.layoutControlItem10.OptionsTableLayoutItem.RowIndex = 2
            Me.layoutControlItem10.Size = New System.Drawing.Size(158, 24)
            Me.layoutControlItem10.Text = "Background Color"
            Me.layoutControlItem10.TextSize = New System.Drawing.Size(84, 13)
            ' 
            ' layoutControlGroup4
            ' 
            Me.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup4.GroupBordersVisible = False
            Me.layoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlGroup5, Me.layoutControlGroup6})
            Me.layoutControlGroup4.Name = "Root"
            Me.layoutControlGroup4.Size = New System.Drawing.Size(303, 288)
            Me.layoutControlGroup4.TextVisible = False
            ' 
            ' layoutControlGroup5
            ' 
            Me.layoutControlGroup5.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.liBackColor, Me.liForeColor, Me.layoutControlItem13, Me.layoutControlItem14, Me.liOpacity, Me.liViewType})
            Me.layoutControlGroup5.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup5.Name = "layoutControlGroup3"
            Me.layoutControlGroup5.Padding = New DevExpress.XtraLayout.Utils.Padding(17, 17, 9, 17)
            Me.layoutControlGroup5.Size = New System.Drawing.Size(283, 197)
            Me.layoutControlGroup5.Text = "Properties"
            ' 
            ' liBackColor
            ' 
            Me.liBackColor.Control = Me.backColorEdit
            Me.liBackColor.Location = New System.Drawing.Point(0, 24)
            Me.liBackColor.Name = "liBackColor"
            Me.liBackColor.Size = New System.Drawing.Size(243, 24)
            Me.liBackColor.Text = "Background Color"
            Me.liBackColor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.liBackColor.TextSize = New System.Drawing.Size(107, 13)
            Me.liBackColor.TextToControlDistance = 0
            ' 
            ' liForeColor
            ' 
            Me.liForeColor.Control = Me.foreColorEdit
            Me.liForeColor.CustomizationFormText = "Foreground Color"
            Me.liForeColor.FillControlToClientArea = False
            Me.liForeColor.Location = New System.Drawing.Point(0, 48)
            Me.liForeColor.Name = "liForeColor"
            Me.liForeColor.OptionsTableLayoutItem.RowIndex = 1
            Me.liForeColor.Size = New System.Drawing.Size(243, 24)
            Me.liForeColor.Text = "Foreground Color"
            Me.liForeColor.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.liForeColor.TextLocation = DevExpress.Utils.Locations.Left
            Me.liForeColor.TextSize = New System.Drawing.Size(107, 13)
            Me.liForeColor.TextToControlDistance = 0
            ' 
            ' layoutControlItem13
            ' 
            Me.layoutControlItem13.AccessibleName = "Allow Fade Out Effect"
            Me.layoutControlItem13.Control = Me.allowFadeOutCheckEdit
            Me.layoutControlItem13.Location = New System.Drawing.Point(0, 120)
            Me.layoutControlItem13.Name = "layoutControlItem2"
            Me.layoutControlItem13.OptionsTableLayoutItem.RowIndex = 4
            Me.layoutControlItem13.Size = New System.Drawing.Size(243, 24)
            Me.layoutControlItem13.Text = " "
            Me.layoutControlItem13.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem13.TextSize = New System.Drawing.Size(107, 0)
            Me.layoutControlItem13.TextToControlDistance = 0
            ' 
            ' layoutControlItem14
            ' 
            Me.layoutControlItem14.AccessibleName = "Allow Fade In Effect"
            Me.layoutControlItem14.Control = Me.allowFadeInCheckEdit
            Me.layoutControlItem14.Location = New System.Drawing.Point(0, 96)
            Me.layoutControlItem14.Name = "layoutControlItem3"
            Me.layoutControlItem14.OptionsTableLayoutItem.RowIndex = 3
            Me.layoutControlItem14.Size = New System.Drawing.Size(243, 24)
            Me.layoutControlItem14.Text = " "
            Me.layoutControlItem14.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.layoutControlItem14.TextLocation = DevExpress.Utils.Locations.Left
            Me.layoutControlItem14.TextSize = New System.Drawing.Size(107, 0)
            Me.layoutControlItem14.TextToControlDistance = 0
            ' 
            ' liOpacity
            ' 
            Me.liOpacity.Control = Me.spinOpacity
            Me.liOpacity.FillControlToClientArea = False
            Me.liOpacity.Location = New System.Drawing.Point(0, 72)
            Me.liOpacity.Name = "liOpacity"
            Me.liOpacity.OptionsTableLayoutItem.RowIndex = 2
            Me.liOpacity.Size = New System.Drawing.Size(243, 24)
            Me.liOpacity.Text = "Opacity"
            Me.liOpacity.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.liOpacity.TextSize = New System.Drawing.Size(107, 13)
            Me.liOpacity.TextToControlDistance = 0
            ' 
            ' liViewType
            ' 
            Me.liViewType.Control = Me.cbViewType
            Me.liViewType.Location = New System.Drawing.Point(0, 0)
            Me.liViewType.Name = "liViewType"
            Me.liViewType.Size = New System.Drawing.Size(243, 24)
            Me.liViewType.Text = "View Type"
            Me.liViewType.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize
            Me.liViewType.TextSize = New System.Drawing.Size(107, 13)
            Me.liViewType.TextToControlDistance = 0
            ' 
            ' layoutControlGroup6
            ' 
            Me.layoutControlGroup6.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem16})
            Me.layoutControlGroup6.Location = New System.Drawing.Point(0, 197)
            Me.layoutControlGroup6.Name = "layoutControlGroup2"
            Me.layoutControlGroup6.Size = New System.Drawing.Size(283, 71)
            Me.layoutControlGroup6.Text = "Commands"
            ' 
            ' layoutControlItem16
            ' 
            Me.layoutControlItem16.Control = Me.btnShow
            Me.layoutControlItem16.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem16.Name = "layoutControlItem1"
            Me.layoutControlItem16.Size = New System.Drawing.Size(259, 26)
            Me.layoutControlItem16.TextVisible = False
            ' 
            ' ModuleOverlayForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl)
            Me.Name = "ModuleOverlayForm"
            Me.Size = New System.Drawing.Size(827, 636)
            CType((Me.layoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl.ResumeLayout(False)
            CType((Me.cbViewType.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.backColorEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowFadeInCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.allowFadeOutCheckEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.foreColorEdit.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.spinOpacity.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem9), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem10), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liBackColor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liForeColor), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem13), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem14), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liOpacity), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.liViewType), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem16), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private components As System.ComponentModel.IContainer = Nothing

        Private layoutControl As DevExpress.XtraLayout.LayoutControl

        Private backColorEdit As DevExpress.XtraEditors.ColorPickEdit

        Private btnShow As DevExpress.XtraEditors.SimpleButton

        Private allowFadeInCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private allowFadeOutCheckEdit As DevExpress.XtraEditors.CheckEdit

        Private foreColorEdit As DevExpress.XtraEditors.ColorPickEdit

        Private spinOpacity As DevExpress.XtraEditors.SpinEdit

        Private layoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlGroup5 As DevExpress.XtraLayout.LayoutControlGroup

        Private liBackColor As DevExpress.XtraLayout.LayoutControlItem

        Private liForeColor As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem

        Private liOpacity As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlGroup6 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControlItem16 As DevExpress.XtraLayout.LayoutControlItem

        Private cbViewType As DevExpress.XtraEditors.ImageComboBoxEdit

        Private liViewType As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
