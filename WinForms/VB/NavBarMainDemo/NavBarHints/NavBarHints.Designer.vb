Namespace DevExpress.XtraNavBar.Demos

    Partial Class NavBarHints

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraNavBar.Demos.NavBarHints))
            Me.navBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.navBarGroup3 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem5 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem4 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem1 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem2 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem3 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarGroup2 = New DevExpress.XtraNavBar.NavBarGroup()
            Me.navBarItem6 = New DevExpress.XtraNavBar.NavBarItem()
            Me.navBarItem7 = New DevExpress.XtraNavBar.NavBarItem()
            Me.groupControl1 = New DevExpress.XtraEditors.GroupControl()
            Me.ceCustomHint = New DevExpress.XtraEditors.CheckEdit()
            Me.seInterval = New DevExpress.XtraEditors.SpinEdit()
            Me.ceLinkHint = New DevExpress.XtraEditors.CheckEdit()
            Me.labelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.ceGroupHint = New DevExpress.XtraEditors.CheckEdit()
            Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel1.SuspendLayout()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupControl1.SuspendLayout()
            CType((Me.ceCustomHint.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.seInterval.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceLinkHint.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ceGroupHint.Properties), System.ComponentModel.ISupportInitialize).BeginInit()
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
            Me.contentPanel1.Size = New System.Drawing.Size(595, 436)
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup3
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
            Me.navBarControl1.Location = New System.Drawing.Point(2, 2)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 186
            Me.navBarControl1.Size = New System.Drawing.Size(186, 407)
            Me.navBarControl1.StoreDefaultPaintStyleName = True
            Me.navBarControl1.TabIndex = 28
            AddHandler Me.navBarControl1.GetHint, New DevExpress.XtraNavBar.NavBarGetHintEventHandler(AddressOf Me.navBarControl1_GetHint)
            ' 
            ' navBarGroup3
            ' 
            Me.navBarGroup3.Caption = "Deleted"
            Me.navBarGroup3.Expanded = True
            Me.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup3.Hint = "Deleted Group hint"
            Me.navBarGroup3.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarGroup3.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarGroup3.ImageOptions.SvgImage = CType((resources.GetObject("navBarGroup3.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
            Me.navBarGroup3.Name = "navBarGroup3"
            ' 
            ' navBarItem5
            ' 
            Me.navBarItem5.Caption = "Report"
            Me.navBarItem5.Hint = "Report hint"
            Me.navBarItem5.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem5.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem5.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem5.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem5.Name = "navBarItem5"
            ' 
            ' navBarItem4
            ' 
            Me.navBarItem4.Caption = "Deleted Items"
            Me.navBarItem4.Enabled = False
            Me.navBarItem4.Hint = "Deleted Items folder"
            Me.navBarItem4.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem4.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem4.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem4.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem4.Name = "navBarItem4"
            ' 
            ' navBarGroup1
            ' 
            Me.navBarGroup1.Caption = "Local"
            Me.navBarGroup1.Expanded = True
            Me.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
            Me.navBarGroup1.Hint = "Local Group hint"
            Me.navBarGroup1.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarGroup1.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarGroup1.ImageOptions.SvgImage = CType((resources.GetObject("navBarGroup1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
            Me.navBarGroup1.Name = "navBarGroup1"
            ' 
            ' navBarItem1
            ' 
            Me.navBarItem1.Caption = "Inbox"
            Me.navBarItem1.Hint = "Inbox folder"
            Me.navBarItem1.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem1.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem1.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem1.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem1.Name = "navBarItem1"
            ' 
            ' navBarItem2
            ' 
            Me.navBarItem2.Caption = "Outbox"
            Me.navBarItem2.Hint = "Outbox folder"
            Me.navBarItem2.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem2.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem2.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem2.Name = "navBarItem2"
            ' 
            ' navBarItem3
            ' 
            Me.navBarItem3.Caption = "Sent Items"
            Me.navBarItem3.Enabled = False
            Me.navBarItem3.Hint = "Sent Items folder"
            Me.navBarItem3.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem3.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem3.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem3.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem3.Name = "navBarItem3"
            ' 
            ' navBarGroup2
            ' 
            Me.navBarGroup2.Caption = "Contacts"
            Me.navBarGroup2.Expanded = True
            Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
            Me.navBarGroup2.Hint = "Contacts Group hint"
            Me.navBarGroup2.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarGroup2.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarGroup2.ImageOptions.SvgImage = CType((resources.GetObject("navBarGroup2.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7)})
            Me.navBarGroup2.Name = "navBarGroup2"
            ' 
            ' navBarItem6
            ' 
            Me.navBarItem6.Caption = "Calendar"
            Me.navBarItem6.Hint = "Calendar hint"
            Me.navBarItem6.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem6.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem6.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem6.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem6.Name = "navBarItem6"
            ' 
            ' navBarItem7
            ' 
            Me.navBarItem7.Caption = "Task"
            Me.navBarItem7.Hint = "Task hint"
            Me.navBarItem7.ImageOptions.LargeImageSize = New System.Drawing.Size(32, 32)
            Me.navBarItem7.ImageOptions.SmallImageSize = New System.Drawing.Size(16, 16)
            Me.navBarItem7.ImageOptions.SvgImage = CType((resources.GetObject("navBarItem7.ImageOptions.SvgImage")), DevExpress.Utils.Svg.SvgImage)
            Me.navBarItem7.Name = "navBarItem7"
            ' 
            ' groupControl1
            ' 
            Me.groupControl1.Anchor = System.Windows.Forms.AnchorStyles.Top
            Me.groupControl1.Controls.Add(Me.ceCustomHint)
            Me.groupControl1.Controls.Add(Me.seInterval)
            Me.groupControl1.Controls.Add(Me.ceLinkHint)
            Me.groupControl1.Controls.Add(Me.labelControl1)
            Me.groupControl1.Controls.Add(Me.ceGroupHint)
            Me.groupControl1.Location = New System.Drawing.Point(223, 12)
            Me.groupControl1.Name = "groupControl1"
            Me.groupControl1.Size = New System.Drawing.Size(320, 168)
            Me.groupControl1.TabIndex = 29
            Me.groupControl1.Text = "Properties"
            ' 
            ' ceCustomHint
            ' 
            Me.ceCustomHint.Location = New System.Drawing.Point(16, 128)
            Me.ceCustomHint.Name = "ceCustomHint"
            Me.ceCustomHint.Properties.Caption = "Custom Hint (GetHint event)"
            Me.ceCustomHint.Size = New System.Drawing.Size(224, 20)
            Me.ceCustomHint.TabIndex = 4
            ' 
            ' seInterval
            ' 
            Me.seInterval.EditValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seInterval.Location = New System.Drawing.Point(152, 88)
            Me.seInterval.Name = "seInterval"
            Me.seInterval.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.seInterval.Properties.Increment = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seInterval.Properties.IsFloatValue = False
            Me.seInterval.Properties.Mask.EditMask = "N00"
            Me.seInterval.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
            Me.seInterval.Properties.MinValue = New Decimal(New Integer() {100, 0, 0, 0})
            Me.seInterval.Size = New System.Drawing.Size(80, 20)
            Me.seInterval.TabIndex = 3
            AddHandler Me.seInterval.EditValueChanged, New System.EventHandler(AddressOf Me.seInterval_EditValueChanged)
            ' 
            ' ceLinkHint
            ' 
            Me.ceLinkHint.Location = New System.Drawing.Point(16, 56)
            Me.ceLinkHint.Name = "ceLinkHint"
            Me.ceLinkHint.Properties.Caption = "Show Link Hint"
            Me.ceLinkHint.Size = New System.Drawing.Size(144, 20)
            Me.ceLinkHint.TabIndex = 2
            AddHandler Me.ceLinkHint.CheckedChanged, New System.EventHandler(AddressOf Me.ceLinkHint_CheckedChanged)
            ' 
            ' labelControl1
            ' 
            Me.labelControl1.Location = New System.Drawing.Point(24, 90)
            Me.labelControl1.Name = "labelControl1"
            Me.labelControl1.Size = New System.Drawing.Size(93, 13)
            Me.labelControl1.TabIndex = 1
            Me.labelControl1.Text = "Show Hint Interval:"
            ' 
            ' ceGroupHint
            ' 
            Me.ceGroupHint.Location = New System.Drawing.Point(16, 32)
            Me.ceGroupHint.Name = "ceGroupHint"
            Me.ceGroupHint.Properties.Caption = "Show Group Hint"
            Me.ceGroupHint.Size = New System.Drawing.Size(144, 20)
            Me.ceGroupHint.TabIndex = 0
            AddHandler Me.ceGroupHint.CheckedChanged, New System.EventHandler(AddressOf Me.ceGroupHint_CheckedChanged)
            ' 
            ' panelControl1
            ' 
            Me.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.panelControl1.Controls.Add(Me.panelControl2)
            Me.panelControl1.Controls.Add(Me.groupControl1)
            Me.panelControl1.Location = New System.Drawing.Point(7, 8)
            Me.panelControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.panelControl1.Name = "panelControl1"
            Me.panelControl1.Size = New System.Drawing.Size(581, 417)
            Me.panelControl1.TabIndex = 30
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.navBarControl1)
            Me.panelControl2.Location = New System.Drawing.Point(3, 3)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(190, 411)
            Me.panelControl2.TabIndex = 30
            ' 
            ' NavBarHints
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "NavBarHints"
            Me.Size = New System.Drawing.Size(595, 436)
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel1.ResumeLayout(False)
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.groupControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupControl1.ResumeLayout(False)
            Me.groupControl1.PerformLayout()
            CType((Me.ceCustomHint.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.seInterval.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceLinkHint.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ceGroupHint.Properties), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl1.ResumeLayout(False)
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
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

        Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup

        Private groupControl1 As DevExpress.XtraEditors.GroupControl

        Private labelControl1 As DevExpress.XtraEditors.LabelControl

        Private ceGroupHint As DevExpress.XtraEditors.CheckEdit

        Private ceLinkHint As DevExpress.XtraEditors.CheckEdit

        Private seInterval As DevExpress.XtraEditors.SpinEdit

        Private ceCustomHint As DevExpress.XtraEditors.CheckEdit

        Private components As System.ComponentModel.IContainer = Nothing

        Private panelControl1 As DevExpress.XtraEditors.PanelControl

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
