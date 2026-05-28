Namespace DevExpress.AI.Demos

    Partial Class ucDisclaimerPanel

        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.AI.Demos.ucDisclaimerPanel))
            Me.roundedSkinPanel = New DevExpress.XtraEditors.RoundedSkinPanel()
            Me.noteLayoutControl = New DevExpress.XtraLayout.LayoutControl()
            Me.noteLabelControl = New DevExpress.XtraEditors.LabelControl()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.lciNoteLabelControl = New DevExpress.XtraLayout.LayoutControlItem()
            CType((Me.roundedSkinPanel), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.roundedSkinPanel.SuspendLayout()
            CType((Me.noteLayoutControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.noteLayoutControl.SuspendLayout()
            CType((Me.Root), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lciNoteLabelControl), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' roundedSkinPanel
            ' 
            Me.roundedSkinPanel.Controls.Add(Me.noteLayoutControl)
            Me.roundedSkinPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.roundedSkinPanel.Location = New System.Drawing.Point(0, 0)
            Me.roundedSkinPanel.Name = "roundedSkinPanel"
            Me.roundedSkinPanel.Size = New System.Drawing.Size(723, 104)
            Me.roundedSkinPanel.TabIndex = 0
            ' 
            ' noteLayoutControl
            ' 
            Me.noteLayoutControl.AllowCustomization = False
            Me.noteLayoutControl.AutoScroll = False
            Me.noteLayoutControl.Controls.Add(Me.noteLabelControl)
            Me.noteLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.noteLayoutControl.Location = New System.Drawing.Point(16, 16)
            Me.noteLayoutControl.MinimumSize = New System.Drawing.Size(32, 32)
            Me.noteLayoutControl.Name = "noteLayoutControl"
            Me.noteLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(630, 0, 820, 753)
            Me.noteLayoutControl.OptionsView.AutoSizeInLayoutControl = DevExpress.XtraLayout.AutoSizeModes.UseMinAndMaxSize
            Me.noteLayoutControl.OptionsView.RoundedPanelIntegrationMode = DevExpress.XtraLayout.RoundedPanelIntegrationMode.Manual
            Me.noteLayoutControl.Root = Me.Root
            Me.noteLayoutControl.Size = New System.Drawing.Size(691, 72)
            Me.noteLayoutControl.TabIndex = 0
            Me.noteLayoutControl.Text = "layoutControl1"
            ' 
            ' noteLabelControl
            ' 
            Me.noteLabelControl.Appearance.Options.UseTextOptions = True
            Me.noteLabelControl.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.noteLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical
            Me.noteLabelControl.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
            Me.noteLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft
            Me.noteLabelControl.ImageOptions.SvgImage = CType((resources.GetObject("noteLabelControl.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.noteLabelControl.IndentBetweenImageAndText = 12
            Me.noteLabelControl.Location = New System.Drawing.Point(16, 16)
            Me.noteLabelControl.Name = "noteLabelControl"
            Me.noteLabelControl.Size = New System.Drawing.Size(659, 39)
            Me.noteLabelControl.StyleController = Me.noteLayoutControl
            Me.noteLabelControl.TabIndex = 6
            Me.noteLabelControl.Text = resources.GetString("noteLabelControl.Text")
            ' 
            ' Root
            ' 
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.lciNoteLabelControl})
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(691, 72)
            Me.Root.TextVisible = False
            ' 
            ' lciNoteLabelControl
            ' 
            Me.lciNoteLabelControl.Control = Me.noteLabelControl
            Me.lciNoteLabelControl.Location = New System.Drawing.Point(0, 0)
            Me.lciNoteLabelControl.Name = "lciNoteLabelControl"
            Me.lciNoteLabelControl.Size = New System.Drawing.Size(665, 46)
            Me.lciNoteLabelControl.TextVisible = False
            ' 
            ' ucDisclaimerPanel
            ' 
            Me.Controls.Add(Me.roundedSkinPanel)
            Me.Name = "ucDisclaimerPanel"
            Me.Size = New System.Drawing.Size(723, 104)
            CType((Me.roundedSkinPanel), System.ComponentModel.ISupportInitialize).EndInit()
            Me.roundedSkinPanel.ResumeLayout(False)
            CType((Me.noteLayoutControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.noteLayoutControl.ResumeLayout(False)
            CType((Me.Root), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lciNoteLabelControl), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

        Private roundedSkinPanel As DevExpress.XtraEditors.RoundedSkinPanel

        Private noteLayoutControl As DevExpress.XtraLayout.LayoutControl

        Private Root As DevExpress.XtraLayout.LayoutControlGroup

        Private noteLabelControl As DevExpress.XtraEditors.LabelControl

        Private lciNoteLabelControl As DevExpress.XtraLayout.LayoutControlItem
    End Class
End Namespace
