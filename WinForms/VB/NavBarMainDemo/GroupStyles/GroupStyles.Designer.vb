Namespace DevExpress.XtraNavBar.Demos

    Partial Class GroupStyles

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraNavBar.Demos.GroupStyles))
            Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.cbContactImage = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbLocalImage = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.cbContactStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.cbLocalStyle = New DevExpress.XtraEditors.ComboBoxEdit()
            Me.labelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.ceAllowSelectedLink = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel1.SuspendLayout()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.cbContactImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbLocalImage.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbContactStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cbLocalStyle.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceAllowSelectedLink.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' contentPanel1
            ' 
            Me.contentPanel1.Controls.Add(Me.panelControl1)
            Me.contentPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.contentPanel1.Padding = New System.Windows.Forms.Padding(3)
            Me.contentPanel1.Size = New System.Drawing.Size(565, 463)
            ' 
            ' navBarItem1
            ' 
            Me.navBarItem1.Caption = "Inbox"
            Me.navBarItem1.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem1.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem1.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem1.Name = "navBarItem1"
            ' 
            ' navBarItem2
            ' 
            Me.navBarItem2.Caption = "Outbox"
            Me.navBarItem2.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem2.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem2.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem2.Name = "navBarItem2"
            ' 
            ' navBarGroup1
            ' 
            Me.navBarGroup1.Caption = "Local"
            Me.navBarGroup1.Expanded = True
            Me.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
            Me.navBarGroup1.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarGroup1.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarGroup1.ImageOptions.SvgImage = CType((resources.GetObject("navBarGroup1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
            Me.navBarGroup1.Name = "navBarGroup1"
            ' 
            ' navBarItem3
            ' 
            Me.navBarItem3.Caption = "Sent Items"
            Me.navBarItem3.Enabled = False
            Me.navBarItem3.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem3.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem3.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem3.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem3.Name = "navBarItem3"
            ' 
            ' navBarItem4
            ' 
            Me.navBarItem4.Caption = "Deleted Items"
            Me.navBarItem4.Enabled = False
            Me.navBarItem4.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem4.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem4.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem4.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem4.Name = "navBarItem4"
            ' 
            ' navBarItem5
            ' 
            Me.navBarItem5.Caption = "Report"
            Me.navBarItem5.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem5.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem5.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem5.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem5.Name = "navBarItem5"
            ' 
            ' navBarItem6
            ' 
            Me.navBarItem6.Caption = "Calendar"
            Me.navBarItem6.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem6.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem6.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem6.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem6.Name = "navBarItem6"
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup2
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navBarGroup1, Me.navBarGroup2})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
            Me.navBarControl1.Location = New System.Drawing.Point(2, 2)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 191
            Me.navBarControl1.Size = New System.Drawing.Size(191, 428)
            Me.navBarControl1.StoreDefaultPaintStyleName = True
            Me.navBarControl1.TabIndex = 21
            Me.navBarControl1.Text = "navBarControl1"
            ' 
            ' navBarGroup2
            ' 
            Me.navBarGroup2.Caption = "Contacts"
            Me.navBarGroup2.Expanded = True
            Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
            Me.navBarGroup2.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarGroup2.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarGroup2.ImageOptions.SvgImage = CType((resources.GetObject("navBarGroup2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
            Me.navBarGroup2.Name = "navBarGroup2"
            ' 
            ' navBarItem7
            ' 
            Me.navBarItem7.Caption = "Task"
            Me.navBarItem7.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem7.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem7.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem7.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem7.Name = "navBarItem7"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.groupControl1.Controls.Add(Me.cbContactImage)
            Me.groupControl1.Controls.Add(Me.cbLocalImage)
            Me.groupControl1.Controls.Add(Me.labelControl3)
            Me.groupControl1.Controls.Add(Me.labelControl4)
            Me.groupControl1.Controls.Add(Me.cbContactStyle)
            Me.groupControl1.Controls.Add(Me.cbLocalStyle)
            Me.groupControl1.Controls.Add(Me.labelControl2)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Controls.Add(Me.ceAllowSelectedLink)
            Me.groupControl1.Location = New System.Drawing.Point(223, 9)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(320, 200)
            Me.groupControl1.TabIndex = 25
            Me.groupControl1.Text = "Properties"
            ' 
            ' cbContactImage
            ' 
            Me.cbContactImage.Location = New System.Drawing.Point(160, 160)
            Me.cbContactImage.Name = "cbContactImage"
            Me.cbContactImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbContactImage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbContactImage.Size = New System.Drawing.Size(136, 20)
            Me.cbContactImage.TabIndex = 8
            AddHandler Me.cbContactImage.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbContactImage_SelectedIndexChanged)
            ' 
            ' cbLocalImage
            ' 
            Me.cbLocalImage.Location = New System.Drawing.Point(160, 128)
            Me.cbLocalImage.Name = "cbLocalImage"
            Me.cbLocalImage.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbLocalImage.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbLocalImage.Size = New System.Drawing.Size(136, 20)
            Me.cbLocalImage.TabIndex = 7
            AddHandler Me.cbLocalImage.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbLocalImage_SelectedIndexChanged)
            ' 
            ' labelControl3
            ' 
            Me.labelControl3.Location = New System.Drawing.Point(24, 164)
            Me.labelControl3.Name = "labelControl3"
            Me.labelControl3.Size = New System.Drawing.Size(113, 13)
            Me.labelControl3.TabIndex = 6
            Me.labelControl3.Text = "'Contacts' group image:"
            ' 
            ' labelControl4
            ' 
            Me.labelControl4.Location = New System.Drawing.Point(24, 130)
            Me.labelControl4.Name = "labelControl4"
            Me.labelControl4.Size = New System.Drawing.Size(94, 13)
            Me.labelControl4.TabIndex = 5
            Me.labelControl4.Text = "'Local' group image:"
            ' 
            ' cbContactStyle
            ' 
            Me.cbContactStyle.Location = New System.Drawing.Point(160, 96)
            Me.cbContactStyle.Name = "cbContactStyle"
            Me.cbContactStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbContactStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbContactStyle.Size = New System.Drawing.Size(136, 20)
            Me.cbContactStyle.TabIndex = 4
            AddHandler Me.cbContactStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbContactStyle_SelectedIndexChanged)
            ' 
            ' cbLocalStyle
            ' 
            Me.cbLocalStyle.Location = New System.Drawing.Point(160, 64)
            Me.cbLocalStyle.Name = "cbLocalStyle"
            Me.cbLocalStyle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.cbLocalStyle.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
            Me.cbLocalStyle.Size = New System.Drawing.Size(136, 20)
            Me.cbLocalStyle.TabIndex = 3
            AddHandler Me.cbLocalStyle.SelectedIndexChanged, New System.EventHandler(AddressOf Me.cbLocalStyle_SelectedIndexChanged)
            ' 
            ' labelControl2
            ' 
            Me.labelControl2.Location = New System.Drawing.Point(24, 99)
            Me.labelControl2.Name = "labelControl2"
            Me.labelControl2.Size = New System.Drawing.Size(108, 13)
            Me.labelControl2.TabIndex = 2
            Me.labelControl2.Text = "'Contacts' group style:"
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(24, 66)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(89, 13)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "'Local' group style:"
            ' 
            ' ceAllowSelectedLink
            ' 
            Me.ceAllowSelectedLink.Location = New System.Drawing.Point(16, 32)
            Me.ceAllowSelectedLink.Name = "ceAllowSelectedLink"
            Me.ceAllowSelectedLink.Properties.Caption = "Allow Selected Link"
            Me.ceAllowSelectedLink.Size = New System.Drawing.Size(144, 20)
            Me.ceAllowSelectedLink.TabIndex = 0
            AddHandler Me.ceAllowSelectedLink.CheckedChanged, New System.EventHandler(AddressOf Me.ceAllowSelectedLink_CheckedChanged)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Controls.Add(Me.groupControl1)
            Me.panelControl1.Location = New System.Drawing.Point(7, 5)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(551, 451)
            Me.panelControl1.TabIndex = 26
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.navBarControl1)
            Me.panelControl2.Location = New System.Drawing.Point(3, 7)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(195, 432)
            Me.panelControl2.TabIndex = 26
            ' 
            ' GroupStyles
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "GroupStyles"
            Me.Size = New System.Drawing.Size(565, 463)
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel1.ResumeLayout(False)
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType((Me.cbContactImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbLocalImage.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbContactStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cbLocalStyle.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceAllowSelectedLink.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem

        Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl

        Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private ceAllowSelectedLink As DevExpress.XtraEditors.CheckEdit

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private labelControl2 As DevExpress.XtraEditors.LabelControl

        Private cbLocalStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private cbContactStyle As DevExpress.XtraEditors.ComboBoxEdit

        Private cbContactImage As DevExpress.XtraEditors.ComboBoxEdit

        Private cbLocalImage As DevExpress.XtraEditors.ComboBoxEdit

        Private labelControl3 As DevExpress.XtraEditors.LabelControl

        Private labelControl4 As DevExpress.XtraEditors.LabelControl

        Private components As System.ComponentModel.IContainer = Nothing

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
