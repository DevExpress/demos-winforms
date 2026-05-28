namespace DevExpress.RealtorWorld.Win {
    partial class ucHomeDetail {
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcFeatures = new DevExpress.XtraEditors.LabelControl();
            this.peAgent = new DevExpress.XtraEditors.PictureEdit();
            this.lcAgent = new DevExpress.XtraEditors.LabelControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciHome = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.imageSlider = new DevExpress.XtraEditors.Controls.ImageSlider();
            this.pnlData = new DevExpress.XtraEditors.PanelControl();
            this.pnlLayout = new DevExpress.XtraEditors.PanelControl();
            this.pnlSeparator = new DevExpress.XtraEditors.PanelControl();
            this.peLayout = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peAgent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlData)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlLayout)).BeginInit();
            this.pnlLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLayout.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomization = false;
            this.lcMain.Controls.Add(this.lcFeatures);
            this.lcMain.Controls.Add(this.peAgent);
            this.lcMain.Controls.Add(this.lcAgent);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.lcMain.Location = new System.Drawing.Point(2, 2);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(671, 353, 450, 350);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(606, 404);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lcFeatures
            // 
            this.lcFeatures.AllowHtmlString = true;
            this.lcFeatures.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lcFeatures.Location = new System.Drawing.Point(4, 4);
            this.lcFeatures.Name = "lcFeatures";
            this.lcFeatures.Size = new System.Drawing.Size(598, 1);
            this.lcFeatures.StyleController = this.lcMain;
            this.lcFeatures.TabIndex = 17;
            // 
            // peAgent
            // 
            this.peAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peAgent.Location = new System.Drawing.Point(395, 11);
            this.peAgent.Name = "peAgent";
            this.peAgent.Properties.AllowFocused = false;
            this.peAgent.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAgent.Properties.PictureAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.peAgent.Properties.PictureInterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.peAgent.Properties.ShowMenu = false;
            this.peAgent.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
            this.peAgent.Size = new System.Drawing.Size(209, 196);
            this.peAgent.StyleController = this.lcMain;
            this.peAgent.TabIndex = 18;
            this.peAgent.DoubleClick += new System.EventHandler(this.peAgent_DoubleClick);
            // 
            // lcAgent
            // 
            this.lcAgent.AllowHtmlString = true;
            this.lcAgent.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lcAgent.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lcAgent.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lcAgent.Location = new System.Drawing.Point(2, 11);
            this.lcAgent.Name = "lcAgent";
            this.lcAgent.Size = new System.Drawing.Size(389, 391);
            this.lcAgent.StyleController = this.lcMain;
            this.lcAgent.TabIndex = 19;
            this.lcAgent.DoubleClick += new System.EventHandler(this.peAgent_DoubleClick);
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "layoutControlGroup1";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciHome,
            this.layoutControlItem3,
            this.layoutControlItem1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMain.Size = new System.Drawing.Size(606, 404);
            this.lcgMain.Text = "lcgMain";
            this.lcgMain.TextVisible = false;
            // 
            // lciHome
            // 
            this.lciHome.Control = this.lcFeatures;
            this.lciHome.CustomizationFormText = "layoutControlItem2";
            this.lciHome.Location = new System.Drawing.Point(0, 0);
            this.lciHome.Name = "lciHome";
            this.lciHome.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciHome.Size = new System.Drawing.Size(606, 9);
            this.lciHome.Text = "Features:";
            this.lciHome.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciHome.TextSize = new System.Drawing.Size(0, 0);
            this.lciHome.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.lcAgent;
            this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 9);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(4, 4);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(393, 395);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.Text = "layoutControlItem3";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.peAgent;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(393, 9);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(213, 200);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(213, 200);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(213, 395);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // imageSlider
            // 
            this.imageSlider.CurrentImageIndex = -1;
            this.imageSlider.Dock = System.Windows.Forms.DockStyle.Top;
            this.imageSlider.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            this.imageSlider.Location = new System.Drawing.Point(0, 0);
            this.imageSlider.Name = "imageSlider";
            this.imageSlider.Size = new System.Drawing.Size(610, 400);
            this.imageSlider.TabIndex = 16;
            this.imageSlider.UseDisabledStatePainter = true;
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlData.Controls.Add(this.pnlLayout);
            this.pnlData.Controls.Add(this.pnlSeparator);
            this.pnlData.Controls.Add(this.imageSlider);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlData.Location = new System.Drawing.Point(10, 0);
            this.pnlData.Name = "pnlData";
            this.pnlData.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlData.Size = new System.Drawing.Size(620, 818);
            this.pnlData.TabIndex = 19;
            // 
            // pnlLayout
            // 
            this.pnlLayout.Controls.Add(this.lcMain);
            this.pnlLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayout.Location = new System.Drawing.Point(0, 410);
            this.pnlLayout.Name = "pnlLayout";
            this.pnlLayout.Size = new System.Drawing.Size(610, 408);
            this.pnlLayout.TabIndex = 18;
            // 
            // pnlSeparator
            // 
            this.pnlSeparator.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparator.Location = new System.Drawing.Point(0, 400);
            this.pnlSeparator.Name = "pnlSeparator";
            this.pnlSeparator.Size = new System.Drawing.Size(610, 10);
            this.pnlSeparator.TabIndex = 17;
            // 
            // peLayout
            // 
            this.peLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peLayout.Location = new System.Drawing.Point(630, 0);
            this.peLayout.Name = "peLayout";
            this.peLayout.Properties.AllowFocused = false;
            this.peLayout.Properties.EnableLODImages = true;
            this.peLayout.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            this.peLayout.Properties.ShowMenu = false;
            this.peLayout.Properties.ShowScrollBars = true;
            this.peLayout.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;
            this.peLayout.Size = new System.Drawing.Size(387, 818);
            this.peLayout.TabIndex = 18;
            this.peLayout.DoubleClick += new System.EventHandler(this.peLayout_DoubleClick);
            // 
            // ucHomeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.peLayout);
            this.Controls.Add(this.pnlData);
            this.Name = "ucHomeDetail";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Size = new System.Drawing.Size(1017, 818);
            this.VisibleChanged += new System.EventHandler(this.ucHomeDetail_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peAgent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlData)).EndInit();
            this.pnlData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlLayout)).EndInit();
            this.pnlLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peLayout.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.Controls.ImageSlider imageSlider;
        private DevExpress.XtraEditors.LabelControl lcFeatures;
        private DevExpress.XtraLayout.LayoutControlItem lciHome;
        private DevExpress.XtraEditors.PictureEdit peLayout;
        private DevExpress.XtraEditors.PanelControl pnlData;
        private DevExpress.XtraEditors.PanelControl pnlSeparator;
        private DevExpress.XtraEditors.LabelControl lcAgent;
        private DevExpress.XtraEditors.PictureEdit peAgent;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.PanelControl pnlLayout;
    }
}
