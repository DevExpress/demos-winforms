Namespace DevExpress.XtraNavBar.Demos

    Partial Class HitInfo

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraNavBar.Demos.HitInfo))
            Me.label3 = New DevExpress.XtraEditors.LabelControl()
            Me.label4 = New DevExpress.XtraEditors.LabelControl()
            Me.label5 = New DevExpress.XtraEditors.LabelControl()
            Me.label6 = New DevExpress.XtraEditors.LabelControl()
            Me.label7 = New DevExpress.XtraEditors.LabelControl()
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
            Me.lbHitTest = New DevExpress.XtraEditors.TextEdit()
            Me.lbGroup = New DevExpress.XtraEditors.TextEdit()
            Me.lbLink = New DevExpress.XtraEditors.TextEdit()
            Me.lbPoint = New DevExpress.XtraEditors.TextEdit()
            Me.lbClick = New DevExpress.XtraEditors.MemoEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel1.SuspendLayout()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbHitTest.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbGroup.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbLink.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbPoint.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.lbClick.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl1.SuspendLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' contentPanel1
            ' 
            Me.contentPanel1.Controls.Add(Me.panelControl2)
            Me.contentPanel1.Controls.Add(Me.panelControl1)
            Me.contentPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.contentPanel1.Padding = New System.Windows.Forms.Padding(3)
            Me.contentPanel1.Size = New System.Drawing.Size(554, 391)
            ' 
            ' label3
            ' 
            Me.label3.Location = New System.Drawing.Point(26, 1)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(38, 13)
            Me.label3.TabIndex = 6
            Me.label3.Text = "HitTest:"
            ' 
            ' label4
            ' 
            Me.label4.Location = New System.Drawing.Point(26, 26)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(33, 13)
            Me.label4.TabIndex = 7
            Me.label4.Text = "Group:"
            ' 
            ' label5
            ' 
            Me.label5.Location = New System.Drawing.Point(26, 50)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(22, 13)
            Me.label5.TabIndex = 8
            Me.label5.Text = "Link:"
            ' 
            ' label6
            ' 
            Me.label6.Appearance.Options.UseTextOptions = True
            Me.label6.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
            Me.label6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.label6.Location = New System.Drawing.Point(26, 104)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(74, 48)
            Me.label6.TabIndex = 10
            Me.label6.Text = "Last Link Clicked:"
            ' 
            ' label7
            ' 
            Me.label7.Location = New System.Drawing.Point(26, 74)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(28, 13)
            Me.label7.TabIndex = 9
            Me.label7.Text = "Point:"
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup2
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navBarGroup1, Me.navBarGroup2})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
            Me.navBarControl1.Location = New System.Drawing.Point(2, 2)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 193
            Me.navBarControl1.Size = New System.Drawing.Size(193, 376)
            Me.navBarControl1.StoreDefaultPaintStyleName = True
            Me.navBarControl1.TabIndex = 0
            Me.navBarControl1.Text = "navBarControl1"
            AddHandler Me.navBarControl1.LinkClicked, New DevExpress.XtraNavBar.NavBarLinkEventHandler(AddressOf Me.navBarControl1_LinkClicked)
            AddHandler Me.navBarControl1.MouseLeave, New System.EventHandler(AddressOf Me.navBarControl1_MouseLeave)
            AddHandler Me.navBarControl1.MouseMove, New System.Windows.Forms.MouseEventHandler(AddressOf Me.navBarControl1_MouseMove)
            ' 
            ' navBarGroup2
            ' 
            Me.navBarGroup2.Caption = "Contacts"
            Me.navBarGroup2.Expanded = True
            Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
            Me.navBarGroup2.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarGroup2.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarGroup2.ImageOptions.SvgImage = CType((resources.GetObject("navBarGroup2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5)})
            Me.navBarGroup2.Name = "navBarGroup2"
            ' 
            ' navBarItem6
            ' 
            Me.navBarItem6.Caption = "Calendar"
            Me.navBarItem6.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem6.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem6.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem6.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem6.Name = "navBarItem6"
            ' 
            ' navBarItem7
            ' 
            Me.navBarItem7.Caption = "Task"
            Me.navBarItem7.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem7.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem7.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem7.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem7.Name = "navBarItem7"
            ' 
            ' navBarItem5
            ' 
            Me.navBarItem5.Caption = "Report"
            Me.navBarItem5.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem5.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem5.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem5.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem5.Name = "navBarItem5"
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
            ' lbHitTest
            ' 
            Me.lbHitTest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbHitTest.Location = New System.Drawing.Point(106, 0)
            Me.lbHitTest.Name = "lbHitTest"
            Me.lbHitTest.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte((204))))
            Me.lbHitTest.Properties.Appearance.Options.UseFont = True
            Me.lbHitTest.Properties.[ReadOnly] = True
            Me.lbHitTest.Size = New System.Drawing.Size(229, 20)
            Me.lbHitTest.TabIndex = 1
            ' 
            ' lbGroup
            ' 
            Me.lbGroup.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbGroup.Location = New System.Drawing.Point(106, 24)
            Me.lbGroup.Name = "lbGroup"
            Me.lbGroup.Properties.[ReadOnly] = True
            Me.lbGroup.Size = New System.Drawing.Size(229, 20)
            Me.lbGroup.TabIndex = 2
            ' 
            ' lbLink
            ' 
            Me.lbLink.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbLink.Location = New System.Drawing.Point(106, 48)
            Me.lbLink.Name = "lbLink"
            Me.lbLink.Properties.[ReadOnly] = True
            Me.lbLink.Size = New System.Drawing.Size(229, 20)
            Me.lbLink.TabIndex = 3
            ' 
            ' lbPoint
            ' 
            Me.lbPoint.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbPoint.Location = New System.Drawing.Point(106, 72)
            Me.lbPoint.Name = "lbPoint"
            Me.lbPoint.Properties.[ReadOnly] = True
            Me.lbPoint.Size = New System.Drawing.Size(229, 20)
            Me.lbPoint.TabIndex = 4
            ' 
            ' lbClick
            ' 
            Me.lbClick.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right)), System.Windows.Forms.AnchorStyles)
            Me.lbClick.Location = New System.Drawing.Point(106, 104)
            Me.lbClick.Name = "lbClick"
            Me.lbClick.Properties.Appearance.BackColor = System.Drawing.SystemColors.Info
            Me.lbClick.Properties.Appearance.Options.UseBackColor = True
            Me.lbClick.Properties.[ReadOnly] = True
            Me.lbClick.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None
            Me.lbClick.Size = New System.Drawing.Size(229, 48)
            Me.lbClick.TabIndex = 5
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.label3)
            Me.panelControl1.Controls.Add(Me.lbClick)
            Me.panelControl1.Controls.Add(Me.label4)
            Me.panelControl1.Controls.Add(Me.lbPoint)
            Me.panelControl1.Controls.Add(Me.label5)
            Me.panelControl1.Controls.Add(Me.lbLink)
            Me.panelControl1.Controls.Add(Me.label6)
            Me.panelControl1.Controls.Add(Me.lbGroup)
            Me.panelControl1.Controls.Add(Me.label7)
            Me.panelControl1.Controls.Add(Me.lbHitTest)
            Me.panelControl1.Location = New System.Drawing.Point(206, 5)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(341, 378)
            Me.panelControl1.TabIndex = 11
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.navBarControl1)
            Me.panelControl2.Location = New System.Drawing.Point(4, 3)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(197, 380)
            Me.panelControl2.TabIndex = 12
            ' 
            ' HitInfo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "HitInfo"
            Me.Size = New System.Drawing.Size(554, 391)
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel1.ResumeLayout(False)
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbHitTest.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbGroup.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbLink.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbPoint.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.lbClick.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            Me.panelControl1.PerformLayout()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private label3 As DevExpress.XtraEditors.LabelControl

        Private label4 As DevExpress.XtraEditors.LabelControl

        Private label5 As DevExpress.XtraEditors.LabelControl

        Private label6 As DevExpress.XtraEditors.LabelControl

        Private label7 As DevExpress.XtraEditors.LabelControl

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl

        Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem

        Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem

        Private lbHitTest As DevExpress.XtraEditors.TextEdit

        Private lbGroup As DevExpress.XtraEditors.TextEdit

        Private lbLink As DevExpress.XtraEditors.TextEdit

        Private lbPoint As DevExpress.XtraEditors.TextEdit

        Private lbClick As DevExpress.XtraEditors.MemoEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
