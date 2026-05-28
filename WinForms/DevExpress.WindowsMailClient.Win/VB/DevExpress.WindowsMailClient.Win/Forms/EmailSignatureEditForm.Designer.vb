Namespace DevExpress.WindowsMailClient.Win.Forms

    Partial Class EmailSignatureEditForm

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

#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.signatureEditFormControl1 = New DevExpress.WindowsMailClient.Win.Forms.SignatureEditFormControl()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.toggleSwitch1 = New DevExpress.XtraEditors.ToggleSwitch()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.btnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.toggleSwitch1.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.panelControl1)
            Me.layoutControl1.Controls.Add(Me.labelControl2)
            Me.layoutControl1.Controls.Add(Me.toggleSwitch1)
            Me.layoutControl1.Controls.Add(Me.labelControl1)
            Me.layoutControl1.Controls.Add(Me.btnCancel)
            Me.layoutControl1.Controls.Add(Me.btnSave)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(2597, 358, 982, 549)
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(519, 507)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
            Me.panelControl1.Controls.Add(Me.signatureEditFormControl1)
            Me.panelControl1.Location = New System.Drawing.Point(25, 112)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(469, 337)
            Me.panelControl1.TabIndex = 10
            Me.signatureEditFormControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.signatureEditFormControl1.Location = New System.Drawing.Point(2, 2)
            Me.signatureEditFormControl1.Name = "signatureEditFormControl1"
            Me.signatureEditFormControl1.Size = New System.Drawing.Size(465, 333)
            Me.signatureEditFormControl1.TabIndex = 0
            Me.labelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 14F)
            Me.labelControl2.Appearance.Options.UseFont = True
            Me.labelControl2.Location = New System.Drawing.Point(25, 15)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(469, 27)
            Me.labelControl2.StyleController = Me.layoutControl1
            Me.labelControl2.TabIndex = 9
            Me.labelControl2.Text = "Email signature"
            Me.toggleSwitch1.Location = New System.Drawing.Point(25, 76)
            Me.toggleSwitch1.Name = "toggleSwitch1"
            Me.toggleSwitch1.Properties.AllowFocused = False
            Me.toggleSwitch1.Properties.OffText = "Off"
            Me.toggleSwitch1.Properties.OnText = "On"
            Me.toggleSwitch1.Size = New System.Drawing.Size(469, 24)
            Me.toggleSwitch1.StyleController = Me.layoutControl1
            Me.toggleSwitch1.TabIndex = 8
            AddHandler Me.toggleSwitch1.EditValueChanged, New System.EventHandler(AddressOf Me.toggleSwitch1_EditValueChanged)
            Me.labelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 10F)
            Me.labelControl1.Appearance.Options.UseFont = True
            Me.labelControl1.Location = New System.Drawing.Point(25, 49)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(469, 17)
            Me.labelControl1.StyleController = Me.layoutControl1
            Me.labelControl1.TabIndex = 7
            Me.labelControl1.Text = "Use an email signature"
            Me.btnCancel.Location = New System.Drawing.Point(259, 456)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(235, 30)
            Me.btnCancel.StyleController = Me.layoutControl1
            Me.btnCancel.TabIndex = 5
            Me.btnCancel.Text = "Cancel"
            AddHandler Me.btnCancel.Click, New System.EventHandler(AddressOf Me.btnClose_Click)
            Me.btnSave.Location = New System.Drawing.Point(25, 456)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(230, 30)
            Me.btnSave.StyleController = Me.layoutControl1
            Me.btnSave.TabIndex = 4
            Me.btnSave.Text = "Save"
            AddHandler Me.btnSave.Click, New System.EventHandler(AddressOf Me.btnSave_Click)
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.layoutControlItem2, Me.layoutControlItem4, Me.layoutControlItem5, Me.layoutControlItem6, Me.emptySpaceItem1, Me.layoutControlItem3})
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(519, 507)
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlItem1.Control = Me.btnSave
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 449)
            Me.layoutControlItem1.MinSize = New System.Drawing.Size(37, 26)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 2, 2, 2)
            Me.layoutControlItem1.Size = New System.Drawing.Size(252, 34)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            Me.layoutControlItem2.Control = Me.btnCancel
            Me.layoutControlItem2.Location = New System.Drawing.Point(252, 449)
            Me.layoutControlItem2.MinSize = New System.Drawing.Size(63, 26)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 20, 2, 2)
            Me.layoutControlItem2.Size = New System.Drawing.Size(257, 34)
            Me.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            Me.layoutControlItem4.Control = Me.labelControl1
            Me.layoutControlItem4.Location = New System.Drawing.Point(0, 39)
            Me.layoutControlItem4.MinSize = New System.Drawing.Size(173, 27)
            Me.layoutControlItem4.Name = "layoutControlItem4"
            Me.layoutControlItem4.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 5, 5)
            Me.layoutControlItem4.Size = New System.Drawing.Size(509, 27)
            Me.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem4.TextVisible = False
            Me.layoutControlItem5.Control = Me.toggleSwitch1
            Me.layoutControlItem5.Location = New System.Drawing.Point(0, 66)
            Me.layoutControlItem5.MinSize = New System.Drawing.Size(130, 39)
            Me.layoutControlItem5.Name = "layoutControlItem5"
            Me.layoutControlItem5.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 5, 10)
            Me.layoutControlItem5.Size = New System.Drawing.Size(509, 39)
            Me.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem5.TextVisible = False
            Me.layoutControlItem6.Control = Me.labelControl2
            Me.layoutControlItem6.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlItem6.MinSize = New System.Drawing.Size(170, 37)
            Me.layoutControlItem6.Name = "layoutControlItem6"
            Me.layoutControlItem6.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 10, 2)
            Me.layoutControlItem6.Size = New System.Drawing.Size(509, 39)
            Me.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.layoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem6.TextVisible = False
            Me.emptySpaceItem1.AllowHotTrack = False
            Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 483)
            Me.emptySpaceItem1.MinSize = New System.Drawing.Size(104, 14)
            Me.emptySpaceItem1.Name = "emptySpaceItem1"
            Me.emptySpaceItem1.Size = New System.Drawing.Size(509, 14)
            Me.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.Control = Me.panelControl1
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 105)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(20, 20, 2, 5)
            Me.layoutControlItem3.Size = New System.Drawing.Size(509, 344)
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(519, 507)
            Me.Controls.Add(Me.layoutControl1)
            Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "EmailSignatureEditForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "EmailSignatureEditForm"
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.toggleSwitch1.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem4), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem5), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem6), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.emptySpaceItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private btnCancel As DevExpress.XtraEditors.SimpleButton

        Private btnSave As DevExpress.XtraEditors.SimpleButton

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem

        Private toggleSwitch1 As DevExpress.XtraEditors.ToggleSwitch

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem

        Private layoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private layoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem

        Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private signatureEditFormControl1 As DevExpress.WindowsMailClient.Win.Forms.SignatureEditFormControl

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
