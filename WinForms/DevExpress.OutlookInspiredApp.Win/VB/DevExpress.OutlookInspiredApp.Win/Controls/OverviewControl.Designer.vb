Namespace DevExpress.DevAV.Modules

    Partial Class OverviewControl

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
            Me.buttonsPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.logo = New DevExpress.XtraEditors.PictureEdit()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.descriptionLabel = New DevExpress.XtraEditors.LabelControl()
            Me.ItemForDescription = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.logo.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            CType((Me.ItemForDescription), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            Me.buttonsPanel.AllowGlyphSkinning = False
            Me.buttonsPanel.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 11.25F)
            Me.buttonsPanel.AppearanceButton.Hovered.Options.UseFont = True
            Me.buttonsPanel.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 11.25F)
            Me.buttonsPanel.AppearanceButton.Normal.Options.UseFont = True
            Me.buttonsPanel.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI", 11.25F)
            Me.buttonsPanel.AppearanceButton.Pressed.Options.UseFont = True
            Me.buttonsPanel.ButtonInterval = 40
            Me.buttonsPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Getting Started", Global.DevExpress.DevAV.Properties.Resources.Overview_GettingStarted, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Support", Global.DevExpress.DevAV.Properties.Resources.Overview_FreeSupport, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Buy Now", Global.DevExpress.DevAV.Properties.Resources.Overview_Buy, -1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, -1)})
            Me.buttonsPanel.Location = New System.Drawing.Point(24, 477)
            Me.buttonsPanel.MaximumSize = New System.Drawing.Size(0, 128)
            Me.buttonsPanel.MinimumSize = New System.Drawing.Size(0, 128)
            Me.buttonsPanel.Name = "buttonsPanel"
            Me.buttonsPanel.Size = New System.Drawing.Size(1032, 128)
            Me.buttonsPanel.TabIndex = 3
            Me.buttonsPanel.UseButtonBackgroundImages = False
            Me.layoutControlGroup1.CustomizationFormText = "Root"
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.ItemForDescription, Me.layoutControlItem3})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "Root"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(24, 24, 24, 24)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(1080, 710)
            Me.layoutControlGroup1.Text = "Root"
            Me.layoutControlGroup1.TextVisible = False
            Me.layoutControlItem1.Control = Me.logo
            Me.layoutControlItem1.ControlAlignment = System.Drawing.ContentAlignment.BottomRight
            Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 581)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem1.Size = New System.Drawing.Size(1032, 81)
            Me.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment
            Me.layoutControlItem1.Text = "layoutControlItem1"
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextToControlDistance = 0
            Me.layoutControlItem1.TextVisible = False
            Me.logo.EditValue = Global.DevExpress.DevAV.Properties.Resources.Overview_Logo
            Me.logo.Location = New System.Drawing.Point(24, 605)
            Me.logo.Name = "logo"
            Me.logo.Properties.AllowFocused = False
            Me.logo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.logo.Properties.Appearance.Options.UseBackColor = True
            Me.logo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.logo.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomRight
            Me.logo.Properties.ShowMenu = False
            Me.logo.Size = New System.Drawing.Size(1032, 81)
            Me.logo.StyleController = Me.layoutControl1
            Me.logo.TabIndex = 16
            Me.layoutControl1.AllowCustomization = False
            Me.layoutControl1.Controls.Add(Me.buttonsPanel)
            Me.layoutControl1.Controls.Add(Me.descriptionLabel)
            Me.layoutControl1.Controls.Add(Me.logo)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(1080, 710)
            Me.layoutControl1.TabIndex = 2
            Me.layoutControl1.Text = "layoutControl1"
            Me.descriptionLabel.AllowHtmlString = True
            Me.descriptionLabel.Appearance.Font = New System.Drawing.Font("Segoe UI Light", 18F)
            Me.descriptionLabel.Appearance.Image = Global.DevExpress.DevAV.Properties.Resources.Jolt_Logo
            Me.descriptionLabel.Appearance.ImageAlign = System.Drawing.ContentAlignment.TopRight
            Me.descriptionLabel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.descriptionLabel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.descriptionLabel.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.descriptionLabel.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.descriptionLabel.Location = New System.Drawing.Point(24, 24)
            Me.descriptionLabel.Name = "descriptionLabel"
            Me.descriptionLabel.Size = New System.Drawing.Size(1032, 453)
            Me.descriptionLabel.StyleController = Me.layoutControl1
            Me.descriptionLabel.TabIndex = 16
            Me.descriptionLabel.Text = "UI SuperHero"
            Me.ItemForDescription.Control = Me.descriptionLabel
            Me.ItemForDescription.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter
            Me.ItemForDescription.CustomizationFormText = "layoutControlItem2"
            Me.ItemForDescription.Location = New System.Drawing.Point(0, 0)
            Me.ItemForDescription.MinSize = New System.Drawing.Size(1, 1)
            Me.ItemForDescription.Name = "layoutControlItem2"
            Me.ItemForDescription.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.ItemForDescription.Size = New System.Drawing.Size(1032, 453)
            Me.ItemForDescription.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
            Me.ItemForDescription.Text = "layoutControlItem2"
            Me.ItemForDescription.TextSize = New System.Drawing.Size(0, 0)
            Me.ItemForDescription.TextToControlDistance = 0
            Me.ItemForDescription.TextVisible = False
            Me.layoutControlItem3.Control = Me.buttonsPanel
            Me.layoutControlItem3.CustomizationFormText = "layoutControlItem3"
            Me.layoutControlItem3.Location = New System.Drawing.Point(0, 453)
            Me.layoutControlItem3.Name = "layoutControlItem3"
            Me.layoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
            Me.layoutControlItem3.Size = New System.Drawing.Size(1032, 128)
            Me.layoutControlItem3.Text = "layoutControlItem3"
            Me.layoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem3.TextToControlDistance = 0
            Me.layoutControlItem3.TextVisible = False
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "OverviewControl"
            Me.Size = New System.Drawing.Size(1080, 710)
            CType((Me.layoutControlGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.logo.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            CType((Me.ItemForDescription), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.layoutControlItem3), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl

        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem

        Private logo As DevExpress.XtraEditors.PictureEdit

        Private descriptionLabel As DevExpress.XtraEditors.LabelControl

        Private ItemForDescription As DevExpress.XtraLayout.LayoutControlItem

        Private buttonsPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel

        Private layoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
