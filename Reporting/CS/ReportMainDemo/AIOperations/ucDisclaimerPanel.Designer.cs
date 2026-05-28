namespace XtraReportsDemos.AIOperations {
    partial class ucDisclaimerPanel {
        void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDisclaimerPanel));
            this.roundedSkinPanel = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.noteLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.noteLabelControl = new DevExpress.XtraEditors.LabelControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciNoteLabelControl = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel)).BeginInit();
            this.roundedSkinPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.noteLayoutControl)).BeginInit();
            this.noteLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNoteLabelControl)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedSkinPanel
            // 
            this.roundedSkinPanel.Controls.Add(this.noteLayoutControl);
            this.roundedSkinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roundedSkinPanel.Location = new System.Drawing.Point(0, 0);
            this.roundedSkinPanel.Name = "roundedSkinPanel";
            this.roundedSkinPanel.Size = new System.Drawing.Size(723, 104);
            this.roundedSkinPanel.TabIndex = 0;
            // 
            // noteLayoutControl
            // 
            this.noteLayoutControl.AllowCustomization = false;
            this.noteLayoutControl.AutoScroll = false;
            this.noteLayoutControl.Controls.Add(this.noteLabelControl);
            this.noteLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLayoutControl.Location = new System.Drawing.Point(16, 16);
            this.noteLayoutControl.MinimumSize = new System.Drawing.Size(32, 32);
            this.noteLayoutControl.Name = "noteLayoutControl";
            this.noteLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(630, 0, 820, 753);
            this.noteLayoutControl.OptionsView.AutoSizeInLayoutControl = DevExpress.XtraLayout.AutoSizeModes.UseMinAndMaxSize;
            this.noteLayoutControl.OptionsView.RoundedPanelIntegrationMode = DevExpress.XtraLayout.RoundedPanelIntegrationMode.Manual;
            this.noteLayoutControl.Root = this.Root;
            this.noteLayoutControl.Size = new System.Drawing.Size(691, 72);
            this.noteLayoutControl.TabIndex = 0;
            this.noteLayoutControl.Text = "layoutControl1";
            // 
            // noteLabelControl
            // 
            this.noteLabelControl.Appearance.Options.UseTextOptions = true;
            this.noteLabelControl.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.noteLabelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.noteLabelControl.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.noteLabelControl.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.noteLabelControl.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("noteLabelControl.ImageOptions.SvgImage")));
            this.noteLabelControl.IndentBetweenImageAndText = 12;
            this.noteLabelControl.Location = new System.Drawing.Point(16, 16);
            this.noteLabelControl.Name = "noteLabelControl";
            this.noteLabelControl.Size = new System.Drawing.Size(659, 39);
            this.noteLabelControl.StyleController = this.noteLayoutControl;
            this.noteLabelControl.TabIndex = 6;
            this.noteLabelControl.Text = resources.GetString("noteLabelControl.Text");
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciNoteLabelControl});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(691, 72);
            this.Root.TextVisible = false;
            // 
            // lciNoteLabelControl
            // 
            this.lciNoteLabelControl.Control = this.noteLabelControl;
            this.lciNoteLabelControl.Location = new System.Drawing.Point(0, 0);
            this.lciNoteLabelControl.Name = "lciNoteLabelControl";
            this.lciNoteLabelControl.Size = new System.Drawing.Size(665, 46);
            this.lciNoteLabelControl.TextVisible = false;
            // 
            // ucDisclaimerPanel
            // 
            this.Controls.Add(this.roundedSkinPanel);
            this.Name = "ucDisclaimerPanel";
            this.Size = new System.Drawing.Size(723, 104);
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel)).EndInit();
            this.roundedSkinPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.noteLayoutControl)).EndInit();
            this.noteLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNoteLabelControl)).EndInit();
            this.ResumeLayout(false);

        }

        private DevExpress.XtraEditors.RoundedSkinPanel roundedSkinPanel;
        private DevExpress.XtraLayout.LayoutControl noteLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.LabelControl noteLabelControl;
        private DevExpress.XtraLayout.LayoutControlItem lciNoteLabelControl;
    }
}
