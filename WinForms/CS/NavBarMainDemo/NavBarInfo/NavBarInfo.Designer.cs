namespace DevExpress.XtraNavBar.Demos {
    partial class NavBarInfo {
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if(disposing) {
                if(components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBarInfo));
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).BeginInit();
            this.contentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel1
            // 
            this.contentPanel1.Controls.Add(this.button1);
            this.contentPanel1.Controls.Add(this.panelControl2);
            this.contentPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel1.Size = new System.Drawing.Size(389, 428);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 21);
            this.button1.TabIndex = 23;
            this.button1.Text = "NavBar Info...";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup3;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7});
            this.navBarControl1.LargeImages = this.imageCollection1;
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 182;
            this.navBarControl1.Size = new System.Drawing.Size(182, 409);
            this.navBarControl1.SmallImages = this.imageCollection2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 29;
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Deleted";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup3.ImageOptions.LargeImageIndex = 3;
            this.navBarGroup3.ImageOptions.SmallImageIndex = 3;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Report";
            this.navBarItem5.ImageOptions.LargeImageIndex = 4;
            this.navBarItem5.ImageOptions.SmallImageIndex = 4;
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Deleted Items";
            this.navBarItem4.Enabled = false;
            this.navBarItem4.ImageOptions.LargeImageIndex = 3;
            this.navBarItem4.ImageOptions.SmallImageIndex = 3;
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Local";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ImageOptions.LargeImageIndex = 5;
            this.navBarGroup1.ImageOptions.SmallImageIndex = 5;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Inbox";
            this.navBarItem1.ImageOptions.LargeImageIndex = 0;
            this.navBarItem1.ImageOptions.SmallImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Outbox";
            this.navBarItem2.ImageOptions.LargeImageIndex = 1;
            this.navBarItem2.ImageOptions.SmallImageIndex = 1;
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Sent Items";
            this.navBarItem3.Enabled = false;
            this.navBarItem3.ImageOptions.LargeImageIndex = 2;
            this.navBarItem3.ImageOptions.SmallImageIndex = 2;
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Contacts";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.navBarGroup2.ImageOptions.LargeImageIndex = 6;
            this.navBarGroup2.ImageOptions.SmallImageIndex = 6;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Calendar";
            this.navBarItem6.ImageOptions.LargeImageIndex = 7;
            this.navBarItem6.ImageOptions.SmallImageIndex = 7;
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Task";
            this.navBarItem7.ImageOptions.LargeImageIndex = 8;
            this.navBarItem7.ImageOptions.SmallImageIndex = 8;
            this.navBarItem7.Name = "navBarItem7";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.InsertGalleryImage("newmail_32x32.png", "images/mail/newmail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/newmail_32x32.png"), 0);
            this.imageCollection1.Images.SetKeyName(0, "newmail_32x32.png");
            this.imageCollection1.InsertGalleryImage("send_32x32.png", "images/mail/send_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/send_32x32.png"), 1);
            this.imageCollection1.Images.SetKeyName(1, "send_32x32.png");
            this.imageCollection1.InsertGalleryImage("emailtemplate_32x32.png", "images/mail/emailtemplate_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/emailtemplate_32x32.png"), 2);
            this.imageCollection1.Images.SetKeyName(2, "emailtemplate_32x32.png");
            this.imageCollection1.InsertGalleryImage("trash_32x32.png", "images/actions/trash_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/trash_32x32.png"), 3);
            this.imageCollection1.Images.SetKeyName(3, "trash_32x32.png");
            this.imageCollection1.InsertGalleryImage("content_32x32.png", "images/miscellaneous/content_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/content_32x32.png"), 4);
            this.imageCollection1.Images.SetKeyName(4, "content_32x32.png");
            this.imageCollection1.InsertGalleryImage("mail_32x32.png", "images/mail/mail_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_32x32.png"), 5);
            this.imageCollection1.Images.SetKeyName(5, "mail_32x32.png");
            this.imageCollection1.InsertGalleryImage("bocontact2_32x32.png", "images/business%20objects/bocontact2_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bocontact2_32x32.png"), 6);
            this.imageCollection1.Images.SetKeyName(6, "bocontact2_32x32.png");
            this.imageCollection1.InsertGalleryImage("today_32x32.png", "images/scheduling/today_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/today_32x32.png"), 7);
            this.imageCollection1.Images.SetKeyName(7, "today_32x32.png");
            this.imageCollection1.InsertGalleryImage("task_32x32.png", "images/tasks/task_32x32.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_32x32.png"), 8);
            this.imageCollection1.Images.SetKeyName(8, "task_32x32.png");
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.InsertGalleryImage("newmail_16x16.png", "images/mail/newmail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/newmail_16x16.png"), 0);
            this.imageCollection2.Images.SetKeyName(0, "newmail_16x16.png");
            this.imageCollection2.InsertGalleryImage("send_16x16.png", "images/mail/send_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/send_16x16.png"), 1);
            this.imageCollection2.Images.SetKeyName(1, "send_16x16.png");
            this.imageCollection2.InsertGalleryImage("emailtemplate_16x16.png", "images/mail/emailtemplate_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/emailtemplate_16x16.png"), 2);
            this.imageCollection2.Images.SetKeyName(2, "emailtemplate_16x16.png");
            this.imageCollection2.InsertGalleryImage("trash_16x16.png", "images/actions/trash_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/trash_16x16.png"), 3);
            this.imageCollection2.Images.SetKeyName(3, "trash_16x16.png");
            this.imageCollection2.InsertGalleryImage("content_16x16.png", "images/miscellaneous/content_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/miscellaneous/content_16x16.png"), 4);
            this.imageCollection2.Images.SetKeyName(4, "content_16x16.png");
            this.imageCollection2.InsertGalleryImage("mail_16x16.png", "images/mail/mail_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/mail/mail_16x16.png"), 5);
            this.imageCollection2.Images.SetKeyName(5, "mail_16x16.png");
            this.imageCollection2.InsertGalleryImage("bocontact2_16x16.png", "images/business%20objects/bocontact2_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/business%20objects/bocontact2_16x16.png"), 6);
            this.imageCollection2.Images.SetKeyName(6, "bocontact2_16x16.png");
            this.imageCollection2.InsertGalleryImage("today_16x16.png", "images/scheduling/today_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/scheduling/today_16x16.png"), 7);
            this.imageCollection2.Images.SetKeyName(7, "today_16x16.png");
            this.imageCollection2.InsertGalleryImage("task_16x16.png", "images/tasks/task_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("images/tasks/task_16x16.png"), 8);
            this.imageCollection2.Images.SetKeyName(8, "task_16x16.png");
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.navBarControl1);
            this.panelControl2.Location = new System.Drawing.Point(8, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(186, 413);
            this.panelControl2.TabIndex = 31;
            // 
            // NavBarInfo
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "NavBarInfo";
            this.Size = new System.Drawing.Size(389, 428);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).EndInit();
            this.contentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private System.ComponentModel.IContainer components;
        private Utils.ImageCollection imageCollection1;
        private Utils.ImageCollection imageCollection2;
        private XtraEditors.PanelControl panelControl2;

    }
}
