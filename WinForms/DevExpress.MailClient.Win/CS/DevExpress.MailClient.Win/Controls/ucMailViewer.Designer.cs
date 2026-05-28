namespace DevExpress.MailClient.Win {
    partial class ucMailViewer {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMailViewer));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lbDate = new DevExpress.XtraEditors.LabelControl();
            this.lbFrom = new DevExpress.XtraEditors.LabelControl();
            this.lbSubject = new DevExpress.XtraEditors.LabelControl();
            this.standaloneBarDockControl1 = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bbiReply = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReplyAll = new DevExpress.XtraBars.BarButtonItem();
            this.bbiForward = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pePhoto = new DevExpress.XtraEditors.PictureEdit();
            this.recMessage = new DevExpress.XtraRichEdit.RichEditControl();
            this.linkView = new DevExpress.XtraEditors.HyperLinkEdit();
            this.lgAll = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lgMessageInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcPicture = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkView.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgMessageInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            resources.ApplyResources(this.panelControl1, "panelControl1");
            this.panelControl1.Name = "panelControl1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.lbDate);
            this.layoutControl1.Controls.Add(this.lbFrom);
            this.layoutControl1.Controls.Add(this.lbSubject);
            this.layoutControl1.Controls.Add(this.standaloneBarDockControl1);
            this.layoutControl1.Controls.Add(this.pePhoto);
            this.layoutControl1.Controls.Add(this.recMessage);
            this.layoutControl1.Controls.Add(this.linkView);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1019, 197, 631, 772);
            this.layoutControl1.Root = this.lgAll;
            // 
            // lbDate
            // 
            this.lbDate.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbDate.Appearance.Options.UseForeColor = true;
            resources.ApplyResources(this.lbDate, "lbDate");
            this.lbDate.Name = "lbDate";
            this.lbDate.StyleController = this.layoutControl1;
            // 
            // lbFrom
            // 
            this.lbFrom.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbFrom.Appearance.Font")));
            this.lbFrom.Appearance.ForeColor = System.Drawing.Color.Gray;
            this.lbFrom.Appearance.Options.UseFont = true;
            this.lbFrom.Appearance.Options.UseForeColor = true;
            this.lbFrom.Appearance.Options.UseTextOptions = true;
            this.lbFrom.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lbFrom.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbFrom.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            resources.ApplyResources(this.lbFrom, "lbFrom");
            this.lbFrom.Name = "lbFrom";
            this.lbFrom.StyleController = this.layoutControl1;
            // 
            // lbSubject
            // 
            this.lbSubject.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbSubject.Appearance.Font")));
            this.lbSubject.Appearance.Options.UseFont = true;
            this.lbSubject.Appearance.Options.UseTextOptions = true;
            this.lbSubject.Appearance.TextOptions.Trimming = DevExpress.Utils.Trimming.EllipsisCharacter;
            this.lbSubject.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lbSubject.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap;
            resources.ApplyResources(this.lbSubject, "lbSubject");
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.StyleController = this.layoutControl1;
            // 
            // standaloneBarDockControl1
            // 
            this.standaloneBarDockControl1.CausesValidation = false;
            resources.ApplyResources(this.standaloneBarDockControl1, "standaloneBarDockControl1");
            this.standaloneBarDockControl1.Manager = this.barManager1;
            this.standaloneBarDockControl1.Name = "standaloneBarDockControl1";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.DockControls.Add(this.standaloneBarDockControl1);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiReply,
            this.bbiReplyAll,
            this.bbiForward});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiReply),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiReplyAll),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiForward)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.DrawDragBorder = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.StandaloneBarDockControl = this.standaloneBarDockControl1;
            resources.ApplyResources(this.bar2, "bar2");
            // 
            // bbiReply
            // 
            resources.ApplyResources(this.bbiReply, "bbiReply");
            this.bbiReply.Id = 0;
            this.bbiReply.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.Reply1;
            this.bbiReply.Name = "bbiReply";
            this.bbiReply.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiReply.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReply_ItemClick);
            // 
            // bbiReplyAll
            // 
            resources.ApplyResources(this.bbiReplyAll, "bbiReplyAll");
            this.bbiReplyAll.Id = 1;
            this.bbiReplyAll.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.ReplyAll1;
            this.bbiReplyAll.Name = "bbiReplyAll";
            this.bbiReplyAll.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiReplyAll.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReplyAll_ItemClick);
            // 
            // bbiForward
            // 
            resources.ApplyResources(this.bbiForward, "bbiForward");
            this.bbiForward.Id = 2;
            this.bbiForward.ImageOptions.SvgImage = global::DevExpress.MailClient.Win.Properties.Resources.Froward;
            this.bbiForward.Name = "bbiForward";
            this.bbiForward.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiForward.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiForward_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            resources.ApplyResources(this.barDockControlTop, "barDockControlTop");
            this.barDockControlTop.Manager = this.barManager1;
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            resources.ApplyResources(this.barDockControlBottom, "barDockControlBottom");
            this.barDockControlBottom.Manager = this.barManager1;
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            resources.ApplyResources(this.barDockControlLeft, "barDockControlLeft");
            this.barDockControlLeft.Manager = this.barManager1;
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            resources.ApplyResources(this.barDockControlRight, "barDockControlRight");
            this.barDockControlRight.Manager = this.barManager1;
            // 
            // pePhoto
            // 
            this.pePhoto.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.pePhoto, "pePhoto");
            this.pePhoto.Name = "pePhoto";
            this.pePhoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePhoto.Properties.NullText = resources.GetString("pePhoto.Properties.NullText");
            this.pePhoto.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pePhoto.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.pePhoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.pePhoto.StyleController = this.layoutControl1;
            // 
            // recMessage
            // 
            this.recMessage.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.recMessage.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.recMessage.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            resources.ApplyResources(this.recMessage, "recMessage");
            this.recMessage.MenuManager = this.barManager1;
            this.recMessage.Name = "recMessage";
            this.recMessage.ReadOnly = true;
            // 
            // linkView
            // 
            resources.ApplyResources(this.linkView, "linkView");
            this.linkView.Name = "linkView";
            this.linkView.Properties.AllowFocused = false;
            this.linkView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.linkView.Properties.Caption = resources.GetString("linkView.Properties.Caption");
            this.linkView.Properties.StartLinkOnClickingEmptySpace = false;
            this.linkView.StyleController = this.layoutControl1;
            // 
            // lgAll
            // 
            this.lgAll.AppearanceGroup.BackColor = System.Drawing.SystemColors.Window;
            this.lgAll.AppearanceGroup.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lgAll.AppearanceGroup.Options.UseBackColor = true;
            this.lgAll.AppearanceGroup.Options.UseForeColor = true;
            resources.ApplyResources(this.lgAll, "lgAll");
            this.lgAll.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lgAll.GroupBordersVisible = false;
            this.lgAll.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem2,
            this.lgMessageInfo});
            this.lgAll.Name = "lgAll";
            this.lgAll.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lgAll.Size = new System.Drawing.Size(588, 605);
            this.lgAll.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.recMessage;
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 129);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem3.Size = new System.Drawing.Size(588, 454);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.linkView;
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 583);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(588, 22);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lgMessageInfo
            // 
            resources.ApplyResources(this.lgMessageInfo, "lgMessageInfo");
            this.lgMessageInfo.GroupBordersVisible = false;
            this.lgMessageInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcPicture,
            this.layoutControlItem7,
            this.layoutControlItem6,
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.simpleSeparator1,
            this.layoutControlItem5});
            this.lgMessageInfo.Location = new System.Drawing.Point(0, 0);
            this.lgMessageInfo.Name = "lgMessageInfo";
            this.lgMessageInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lgMessageInfo.Size = new System.Drawing.Size(588, 129);
            this.lgMessageInfo.TextVisible = false;
            // 
            // lcPicture
            // 
            this.lcPicture.Control = this.pePhoto;
            resources.ApplyResources(this.lcPicture, "lcPicture");
            this.lcPicture.Location = new System.Drawing.Point(501, 28);
            this.lcPicture.MaxSize = new System.Drawing.Size(87, 100);
            this.lcPicture.MinSize = new System.Drawing.Size(87, 100);
            this.lcPicture.Name = "lcPicture";
            this.lcPicture.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcPicture.Size = new System.Drawing.Size(87, 100);
            this.lcPicture.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lcPicture.TextSize = new System.Drawing.Size(0, 0);
            this.lcPicture.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.lbDate;
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 28);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(501, 17);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lbFrom;
            resources.ApplyResources(this.layoutControlItem6, "layoutControlItem6");
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 45);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(501, 29);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lbSubject;
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(501, 24);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            resources.ApplyResources(this.emptySpaceItem1, "emptySpaceItem1");
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 98);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(501, 30);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            resources.ApplyResources(this.simpleSeparator1, "simpleSeparator1");
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 128);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(588, 1);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.standaloneBarDockControl1;
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(588, 28);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // ucMailViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ucMailViewer";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePhoto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linkView.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lgMessageInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraRichEdit.RichEditControl recMessage;
        private DevExpress.XtraEditors.HyperLinkEdit linkView;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup lgAll;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraEditors.PictureEdit pePhoto;
        private XtraLayout.LayoutControlItem lcPicture;
        private XtraBars.BarManager barManager1;
        private XtraBars.Bar bar2;
        private XtraBars.BarButtonItem bbiReply;
        private XtraBars.BarButtonItem bbiReplyAll;
        private XtraBars.BarButtonItem bbiForward;
        private XtraBars.BarDockControl barDockControlTop;
        private XtraBars.BarDockControl barDockControlBottom;
        private XtraBars.BarDockControl barDockControlLeft;
        private XtraBars.BarDockControl barDockControlRight;
        private XtraBars.StandaloneBarDockControl standaloneBarDockControl1;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.SimpleSeparator simpleSeparator1;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
        private XtraEditors.LabelControl lbSubject;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraEditors.LabelControl lbDate;
        private XtraEditors.LabelControl lbFrom;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlGroup lgMessageInfo;
    }
}
