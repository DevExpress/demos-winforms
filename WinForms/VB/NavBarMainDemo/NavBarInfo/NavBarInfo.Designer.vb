Namespace DevExpress.XtraNavBar.Demos

    Partial Class NavBarInfo

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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DevExpress.XtraNavBar.Demos.NavBarInfo))
            Me.button1 = New DevExpress.XtraEditors.SimpleButton()
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
            Me.imageCollection1 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.imageCollection2 = New DevExpress.Utils.ImageCollection(Me.components)
            Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.contentPanel1.SuspendLayout()
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panelControl2.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' contentPanel1
            ' 
            Me.contentPanel1.Controls.Add(Me.button1)
            Me.contentPanel1.Controls.Add(Me.panelControl2)
            Me.contentPanel1.Margin = New System.Windows.Forms.Padding(2)
            Me.contentPanel1.Padding = New System.Windows.Forms.Padding(3)
            Me.contentPanel1.Size = New System.Drawing.Size(389, 428)
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(233, 21)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(114, 21)
            Me.button1.TabIndex = 23
            Me.button1.Text = "NavBar Info..."
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.button1_Click)
            ' 
            ' navBarControl1
            ' 
            Me.navBarControl1.ActiveGroup = Me.navBarGroup3
            Me.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.navBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.navBarGroup1, Me.navBarGroup2, Me.navBarGroup3})
            Me.navBarControl1.Items.AddRange(New DevExpress.XtraNavBar.NavBarItem() {Me.navBarItem1, Me.navBarItem2, Me.navBarItem3, Me.navBarItem4, Me.navBarItem5, Me.navBarItem6, Me.navBarItem7})
            Me.navBarControl1.LargeImages = Me.imageCollection1
            Me.navBarControl1.Location = New System.Drawing.Point(2, 2)
            Me.navBarControl1.Name = "navBarControl1"
            Me.navBarControl1.OptionsNavPane.ExpandedWidth = 182
            Me.navBarControl1.Size = New System.Drawing.Size(182, 409)
            Me.navBarControl1.SmallImages = Me.imageCollection2
            Me.navBarControl1.StoreDefaultPaintStyleName = True
            Me.navBarControl1.TabIndex = 29
            ' 
            ' navBarGroup3
            ' 
            Me.navBarGroup3.Caption = "Deleted"
            Me.navBarGroup3.Expanded = True
            Me.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup3.ImageOptions.LargeImageIndex = 3
            Me.navBarGroup3.ImageOptions.SmallImageIndex = 3
            Me.navBarGroup3.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem5), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
            Me.navBarGroup3.Name = "navBarGroup3"
            ' 
            ' navBarItem5
            ' 
            Me.navBarItem5.Caption = "Report"
            Me.navBarItem5.ImageOptions.LargeImageIndex = 4
            Me.navBarItem5.ImageOptions.SmallImageIndex = 4
            Me.navBarItem5.Name = "navBarItem5"
            ' 
            ' navBarItem4
            ' 
            Me.navBarItem4.Caption = "Deleted Items"
            Me.navBarItem4.Enabled = False
            Me.navBarItem4.ImageOptions.LargeImageIndex = 3
            Me.navBarItem4.ImageOptions.SmallImageIndex = 3
            Me.navBarItem4.Name = "navBarItem4"
            ' 
            ' navBarGroup1
            ' 
            Me.navBarGroup1.Caption = "Local"
            Me.navBarGroup1.Expanded = True
            Me.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText
            Me.navBarGroup1.ImageOptions.LargeImageIndex = 5
            Me.navBarGroup1.ImageOptions.SmallImageIndex = 5
            Me.navBarGroup1.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem1), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem2), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem3), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem4)})
            Me.navBarGroup1.Name = "navBarGroup1"
            ' 
            ' navBarItem1
            ' 
            Me.navBarItem1.Caption = "Inbox"
            Me.navBarItem1.ImageOptions.LargeImageIndex = 0
            Me.navBarItem1.ImageOptions.SmallImageIndex = 0
            Me.navBarItem1.Name = "navBarItem1"
            ' 
            ' navBarItem2
            ' 
            Me.navBarItem2.Caption = "Outbox"
            Me.navBarItem2.ImageOptions.LargeImageIndex = 1
            Me.navBarItem2.ImageOptions.SmallImageIndex = 1
            Me.navBarItem2.Name = "navBarItem2"
            ' 
            ' navBarItem3
            ' 
            Me.navBarItem3.Caption = "Sent Items"
            Me.navBarItem3.Enabled = False
            Me.navBarItem3.ImageOptions.LargeImageIndex = 2
            Me.navBarItem3.ImageOptions.SmallImageIndex = 2
            Me.navBarItem3.Name = "navBarItem3"
            ' 
            ' navBarGroup2
            ' 
            Me.navBarGroup2.Caption = "Contacts"
            Me.navBarGroup2.Expanded = True
            Me.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large
            Me.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList
            Me.navBarGroup2.ImageOptions.LargeImageIndex = 6
            Me.navBarGroup2.ImageOptions.SmallImageIndex = 6
            Me.navBarGroup2.ItemLinks.AddRange(New DevExpress.XtraNavBar.NavBarItemLink() {New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem6), New DevExpress.XtraNavBar.NavBarItemLink(Me.navBarItem7)})
            Me.navBarGroup2.Name = "navBarGroup2"
            ' 
            ' navBarItem6
            ' 
            Me.navBarItem6.Caption = "Calendar"
            Me.navBarItem6.ImageOptions.LargeImageIndex = 7
            Me.navBarItem6.ImageOptions.SmallImageIndex = 7
            Me.navBarItem6.Name = "navBarItem6"
            ' 
            ' navBarItem7
            ' 
            Me.navBarItem7.Caption = "Task"
            Me.navBarItem7.ImageOptions.LargeImageIndex = 8
            Me.navBarItem7.ImageOptions.SmallImageIndex = 8
            Me.navBarItem7.Name = "navBarItem7"
            ' 
            ' imageCollection1
            ' 
            Me.imageCollection1.ImageSize = New System.Drawing.Size(32, 32)
            Me.imageCollection1.ImageStream = CType((resources.GetObject("imageCollection1.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection1.InsertGalleryImage("newmail_32x32.png", "images/mail/newmail_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/newmail_32x32.png"), 0)
            Me.imageCollection1.Images.SetKeyName(0, "newmail_32x32.png")
            Me.imageCollection1.InsertGalleryImage("send_32x32.png", "images/mail/send_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/send_32x32.png"), 1)
            Me.imageCollection1.Images.SetKeyName(1, "send_32x32.png")
            Me.imageCollection1.InsertGalleryImage("emailtemplate_32x32.png", "images/mail/emailtemplate_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/emailtemplate_32x32.png"), 2)
            Me.imageCollection1.Images.SetKeyName(2, "emailtemplate_32x32.png")
            Me.imageCollection1.InsertGalleryImage("trash_32x32.png", "images/actions/trash_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/trash_32x32.png"), 3)
            Me.imageCollection1.Images.SetKeyName(3, "trash_32x32.png")
            Me.imageCollection1.InsertGalleryImage("content_32x32.png", "images/miscellaneous/content_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/miscellaneous/content_32x32.png"), 4)
            Me.imageCollection1.Images.SetKeyName(4, "content_32x32.png")
            Me.imageCollection1.InsertGalleryImage("mail_32x32.png", "images/mail/mail_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/mail_32x32.png"), 5)
            Me.imageCollection1.Images.SetKeyName(5, "mail_32x32.png")
            Me.imageCollection1.InsertGalleryImage("bocontact2_32x32.png", "images/business%20objects/bocontact2_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/business%20objects/bocontact2_32x32.png"), 6)
            Me.imageCollection1.Images.SetKeyName(6, "bocontact2_32x32.png")
            Me.imageCollection1.InsertGalleryImage("today_32x32.png", "images/scheduling/today_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/scheduling/today_32x32.png"), 7)
            Me.imageCollection1.Images.SetKeyName(7, "today_32x32.png")
            Me.imageCollection1.InsertGalleryImage("task_32x32.png", "images/tasks/task_32x32.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/tasks/task_32x32.png"), 8)
            Me.imageCollection1.Images.SetKeyName(8, "task_32x32.png")
            ' 
            ' imageCollection2
            ' 
            Me.imageCollection2.ImageStream = CType((resources.GetObject("imageCollection2.ImageStream")), DevExpress.Utils.ImageCollectionStreamer)
            Me.imageCollection2.InsertGalleryImage("newmail_16x16.png", "images/mail/newmail_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/newmail_16x16.png"), 0)
            Me.imageCollection2.Images.SetKeyName(0, "newmail_16x16.png")
            Me.imageCollection2.InsertGalleryImage("send_16x16.png", "images/mail/send_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/send_16x16.png"), 1)
            Me.imageCollection2.Images.SetKeyName(1, "send_16x16.png")
            Me.imageCollection2.InsertGalleryImage("emailtemplate_16x16.png", "images/mail/emailtemplate_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/emailtemplate_16x16.png"), 2)
            Me.imageCollection2.Images.SetKeyName(2, "emailtemplate_16x16.png")
            Me.imageCollection2.InsertGalleryImage("trash_16x16.png", "images/actions/trash_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/actions/trash_16x16.png"), 3)
            Me.imageCollection2.Images.SetKeyName(3, "trash_16x16.png")
            Me.imageCollection2.InsertGalleryImage("content_16x16.png", "images/miscellaneous/content_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/miscellaneous/content_16x16.png"), 4)
            Me.imageCollection2.Images.SetKeyName(4, "content_16x16.png")
            Me.imageCollection2.InsertGalleryImage("mail_16x16.png", "images/mail/mail_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/mail/mail_16x16.png"), 5)
            Me.imageCollection2.Images.SetKeyName(5, "mail_16x16.png")
            Me.imageCollection2.InsertGalleryImage("bocontact2_16x16.png", "images/business%20objects/bocontact2_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/business%20objects/bocontact2_16x16.png"), 6)
            Me.imageCollection2.Images.SetKeyName(6, "bocontact2_16x16.png")
            Me.imageCollection2.InsertGalleryImage("today_16x16.png", "images/scheduling/today_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/scheduling/today_16x16.png"), 7)
            Me.imageCollection2.Images.SetKeyName(7, "today_16x16.png")
            Me.imageCollection2.InsertGalleryImage("task_16x16.png", "images/tasks/task_16x16.png", DevExpress.Images.ImageResourceCache.[Default].GetImage("images/tasks/task_16x16.png"), 8)
            Me.imageCollection2.Images.SetKeyName(8, "task_16x16.png")
            ' 
            ' panelControl2
            ' 
            Me.panelControl2.Controls.Add(Me.navBarControl1)
            Me.panelControl2.Location = New System.Drawing.Point(8, 4)
            Me.panelControl2.Name = "panelControl2"
            Me.panelControl2.Size = New System.Drawing.Size(186, 413)
            Me.panelControl2.TabIndex = 31
            ' 
            ' NavBarInfo
            ' 
            Me.Appearance.Options.UseFont = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Name = "NavBarInfo"
            Me.Size = New System.Drawing.Size(389, 428)
            CType((Me.contentPanel1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.contentPanel1.ResumeLayout(False)
            CType((Me.navBarControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.imageCollection2), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.panelControl2), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panelControl2.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

#End Region
        Private button1 As DevExpress.XtraEditors.SimpleButton

        Private navBarControl1 As DevExpress.XtraNavBar.NavBarControl

        Private navBarGroup3 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem5 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem4 As DevExpress.XtraNavBar.NavBarItem

        Private navBarGroup1 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem1 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem2 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem3 As DevExpress.XtraNavBar.NavBarItem

        Private navBarGroup2 As DevExpress.XtraNavBar.NavBarGroup

        Private navBarItem6 As DevExpress.XtraNavBar.NavBarItem

        Private navBarItem7 As DevExpress.XtraNavBar.NavBarItem

        Private components As System.ComponentModel.IContainer

        Private imageCollection1 As DevExpress.Utils.ImageCollection

        Private imageCollection2 As DevExpress.Utils.ImageCollection

        Private panelControl2 As DevExpress.XtraEditors.PanelControl
    End Class
End Namespace
