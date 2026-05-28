namespace DevExpress.XtraNavBar.Demos {
    partial class AddItemLinks {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddItemLinks));
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.button2 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.button3 = new DevExpress.XtraEditors.SimpleButton();
            this.button4 = new DevExpress.XtraEditors.SimpleButton();
            this.button5 = new DevExpress.XtraEditors.SimpleButton();
            this.imageComboBoxEdit1 = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).BeginInit();
            this.contentPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentPanel1
            // 
            this.contentPanel1.Controls.Add(this.panelControl1);
            this.contentPanel1.Controls.Add(this.navBarControl1);
            this.contentPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.contentPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.contentPanel1.Size = new System.Drawing.Size(527, 352);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Add New ItemLink to the Active Group";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.ItemDisabled.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemHotTracked.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemHotTracked.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.Appearance.ItemPressed.Options.UseTextOptions = true;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.navBarControl1.Appearance.ItemPressed.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1});
            this.navBarControl1.LargeImages = this.imageCollection1;
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInGroup;
            this.navBarControl1.Location = new System.Drawing.Point(4, 5);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 172;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(172, 343);
            this.navBarControl1.SmallImages = this.imageCollection2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 8;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.SelectedLinkChanged += new DevExpress.XtraNavBar.ViewInfo.NavBarSelectedLinkChangedEventHandler(this.navBarControl1_SelectedLinkChanged);
            this.navBarControl1.ActiveGroupChanged += new DevExpress.XtraNavBar.NavBarGroupEventHandler(this.navBarControl1_ActiveGroupChanged);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Small Links";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            this.navBarGroup1.SelectedLinkIndex = 0;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Home";
            this.navBarItem1.ImageOptions.LargeImageIndex = 0;
            this.navBarItem1.ImageOptions.SmallImageIndex = 0;
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Large Links";
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Small;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(23, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 28);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete Selected ItemLink from the Active Group";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(110, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "New Item Image:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(23, 72);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 28);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete Item for the Selected Link";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(23, 106);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(248, 28);
            this.button4.TabIndex = 13;
            this.button4.Text = "Add New SeparatorItem to the Active Group";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Appearance.Options.UseTextOptions = true;
            this.button5.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.button5.Location = new System.Drawing.Point(23, 141);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(248, 28);
            this.button5.TabIndex = 14;
            this.button5.Text = "Delete Last Separator from the Active Group";
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // imageComboBoxEdit1
            // 
            this.imageComboBoxEdit1.Location = new System.Drawing.Point(191, 186);
            this.imageComboBoxEdit1.Name = "imageComboBoxEdit1";
            this.imageComboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.imageComboBoxEdit1.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.imageComboBoxEdit1.Size = new System.Drawing.Size(80, 20);
            this.imageComboBoxEdit1.TabIndex = 13;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.button1);
            this.panelControl1.Controls.Add(this.imageComboBoxEdit1);
            this.panelControl1.Controls.Add(this.button5);
            this.panelControl1.Controls.Add(this.button4);
            this.panelControl1.Controls.Add(this.button3);
            this.panelControl1.Controls.Add(this.button2);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Location = new System.Drawing.Point(238, 5);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(286, 343);
            this.panelControl1.TabIndex = 15;
            // 
            // AddItemLinks
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "AddItemLinks";
            this.Size = new System.Drawing.Size(527, 352);
            this.Load += new System.EventHandler(this.AddItemLinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contentPanel1)).EndInit();
            this.contentPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageComboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraEditors.SimpleButton button2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.SimpleButton button3;
        private DevExpress.XtraEditors.SimpleButton button4;
        private DevExpress.XtraEditors.SimpleButton button5;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.XtraEditors.ImageComboBoxEdit imageComboBoxEdit1;
        private System.ComponentModel.IContainer components;
        private XtraEditors.PanelControl panelControl1;
    }
}
