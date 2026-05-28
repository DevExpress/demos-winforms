namespace DevExpress.XtraEditors.Demos {
    partial class ModuleTransitionManager {
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.Utils.Animation.Transition transition1 = new DevExpress.Utils.Animation.Transition();
            this.pictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.reviewImages = new DevExpress.XtraEditors.GroupControl();
            this.galleryControl = new DevExpress.XtraBars.Ribbon.GalleryControl();
            this.galleryControlClient = new DevExpress.XtraBars.Ribbon.GalleryControlClient();
            this.transitionParameters = new DevExpress.XtraEditors.GroupControl();
            this.ceBackground = new DevExpress.XtraEditors.ColorEdit();
            this.seFrameInterval = new DevExpress.XtraEditors.SpinEdit();
            this.seFrameCount = new DevExpress.XtraEditors.SpinEdit();
            this.seStripeCount = new DevExpress.XtraEditors.SpinEdit();
            this.checkUnCover = new DevExpress.XtraEditors.CheckEdit();
            this.checkInward = new DevExpress.XtraEditors.CheckEdit();
            this.checkVertical = new DevExpress.XtraEditors.CheckEdit();
            this.lbBackground = new DevExpress.XtraEditors.LabelControl();
            this.lbStripeCount = new DevExpress.XtraEditors.LabelControl();
            this.lbFrameCount = new DevExpress.XtraEditors.LabelControl();
            this.lbFrameInterval = new DevExpress.XtraEditors.LabelControl();
            this.cbEffectOptions = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.lbEffectOptions = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lbEasingFunction = new DevExpress.XtraEditors.LabelControl();
            this.cbTransitionType = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbEasingMode = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.cbEasingFunction = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbTransitionType = new DevExpress.XtraEditors.LabelControl();
            this.lbEasingMode = new DevExpress.XtraEditors.LabelControl();
            this.cbShowWaitIndicator = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.lbShowWaitIndicator = new DevExpress.XtraEditors.LabelControl();
            this.transitionManager = new DevExpress.Utils.Animation.TransitionManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reviewImages)).BeginInit();
            this.reviewImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).BeginInit();
            this.galleryControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transitionParameters)).BeginInit();
            this.transitionParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceBackground.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFrameInterval.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFrameCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seStripeCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUnCover.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInward.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkVertical.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEffectOptions.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransitionType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEasingMode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEasingFunction.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowWaitIndicator.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit
            // 
            this.pictureEdit.Location = new System.Drawing.Point(148, 43);
            this.pictureEdit.Name = "pictureEdit";
            this.pictureEdit.Size = new System.Drawing.Size(325, 325);
            this.pictureEdit.TabIndex = 0;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.xtraTabControl1.Size = new System.Drawing.Size(843, 436);
            this.xtraTabControl1.TabIndex = 14;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.xtraTabControl1.TabStop = false;
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.reviewImages);
            this.xtraTabPage1.Controls.Add(this.transitionParameters);
            this.xtraTabPage1.Controls.Add(this.groupControl1);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(841, 434);
            this.xtraTabPage1.Text = "xtraTabPage1";
            // 
            // reviewImages
            // 
            this.reviewImages.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.reviewImages.Appearance.Options.UseBackColor = true;
            this.reviewImages.Controls.Add(this.pictureEdit);
            this.reviewImages.Controls.Add(this.galleryControl);
            this.reviewImages.Location = new System.Drawing.Point(17, 15);
            this.reviewImages.Name = "reviewImages";
            this.reviewImages.Size = new System.Drawing.Size(493, 396);
            this.reviewImages.TabIndex = 23;
            this.reviewImages.Text = "Review Images";
            // 
            // galleryControl
            // 
            this.galleryControl.Controls.Add(this.galleryControlClient);
            // 
            // 
            // 
            this.galleryControl.Gallery.AllowMarqueeSelection = true;
            galleryItemGroup1.Caption = "Group1";
            galleryItem1.Caption = "Item1";
            galleryItem1.ImageOptions.Image = global::DevExpress.XtraEditors.Demos.Properties.Resources.product1;
            galleryItem2.Caption = "Item2";
            galleryItem2.ImageOptions.Image = global::DevExpress.XtraEditors.Demos.Properties.Resources.product2;
            galleryItem3.Caption = "Item3";
            galleryItem3.ImageOptions.Image = global::DevExpress.XtraEditors.Demos.Properties.Resources.product3;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2,
            galleryItem3});
            this.galleryControl.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.galleryControl.Gallery.ImageSize = new System.Drawing.Size(100, 90);
            this.galleryControl.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleRadio;
            this.galleryControl.Gallery.ItemSize = new System.Drawing.Size(100, 90);
            this.galleryControl.Gallery.ShowGroupCaption = false;
            this.galleryControl.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide;
            this.galleryControl.Gallery.ItemCheckedChanged += new DevExpress.XtraBars.Ribbon.GalleryItemEventHandler(this.galleryControlGallery_ItemCheckedChanged);
            this.galleryControl.Location = new System.Drawing.Point(18, 43);
            this.galleryControl.Name = "galleryControl";
            this.galleryControl.Size = new System.Drawing.Size(120, 325);
            this.galleryControl.TabIndex = 0;
            this.galleryControl.Text = "galleryControl1";
            // 
            // galleryControlClient
            // 
            this.galleryControlClient.GalleryControl = this.galleryControl;
            this.galleryControlClient.Location = new System.Drawing.Point(2, 2);
            this.galleryControlClient.Size = new System.Drawing.Size(116, 321);
            // 
            // transitionParameters
            // 
            this.transitionParameters.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.transitionParameters.Appearance.Options.UseBackColor = true;
            this.transitionParameters.Controls.Add(this.ceBackground);
            this.transitionParameters.Controls.Add(this.seFrameInterval);
            this.transitionParameters.Controls.Add(this.seFrameCount);
            this.transitionParameters.Controls.Add(this.seStripeCount);
            this.transitionParameters.Controls.Add(this.checkUnCover);
            this.transitionParameters.Controls.Add(this.checkInward);
            this.transitionParameters.Controls.Add(this.checkVertical);
            this.transitionParameters.Controls.Add(this.lbBackground);
            this.transitionParameters.Controls.Add(this.lbStripeCount);
            this.transitionParameters.Controls.Add(this.lbFrameCount);
            this.transitionParameters.Controls.Add(this.lbFrameInterval);
            this.transitionParameters.Controls.Add(this.cbEffectOptions);
            this.transitionParameters.Controls.Add(this.lbEffectOptions);
            this.transitionParameters.Location = new System.Drawing.Point(529, 190);
            this.transitionParameters.Name = "transitionParameters";
            this.transitionParameters.Size = new System.Drawing.Size(285, 221);
            this.transitionParameters.TabIndex = 23;
            this.transitionParameters.Text = "Transition parameters";
            // 
            // ceBackground
            // 
            this.ceBackground.EditValue = System.Drawing.Color.Empty;
            this.ceBackground.Location = new System.Drawing.Point(123, 121);
            this.ceBackground.Name = "ceBackground";
            this.ceBackground.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ceBackground.Size = new System.Drawing.Size(140, 20);
            this.ceBackground.TabIndex = 36;
            this.ceBackground.EditValueChanged += new System.EventHandler(this.ceBackground_EditValueChanged);
            // 
            // seFrameInterval
            // 
            this.seFrameInterval.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFrameInterval.Location = new System.Drawing.Point(123, 34);
            this.seFrameInterval.Name = "seFrameInterval";
            this.seFrameInterval.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFrameInterval.Properties.IsFloatValue = false;
            this.seFrameInterval.Properties.Mask.EditMask = "N00";
            this.seFrameInterval.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.seFrameInterval.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seFrameInterval.Size = new System.Drawing.Size(140, 20);
            this.seFrameInterval.TabIndex = 35;
            this.seFrameInterval.ValueChanged += new System.EventHandler(this.seFrameInterval_ValueChanged);
            // 
            // seFrameCount
            // 
            this.seFrameCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seFrameCount.Location = new System.Drawing.Point(123, 63);
            this.seFrameCount.Name = "seFrameCount";
            this.seFrameCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seFrameCount.Properties.IsFloatValue = false;
            this.seFrameCount.Properties.Mask.EditMask = "N00";
            this.seFrameCount.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.seFrameCount.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seFrameCount.Size = new System.Drawing.Size(140, 20);
            this.seFrameCount.TabIndex = 34;
            this.seFrameCount.ValueChanged += new System.EventHandler(this.seFrameCount_ValueChanged);
            // 
            // seStripeCount
            // 
            this.seStripeCount.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seStripeCount.Location = new System.Drawing.Point(123, 151);
            this.seStripeCount.Name = "seStripeCount";
            this.seStripeCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seStripeCount.Properties.IsFloatValue = false;
            this.seStripeCount.Properties.Mask.EditMask = "N00";
            this.seStripeCount.Properties.MaxValue = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.seStripeCount.Size = new System.Drawing.Size(140, 20);
            this.seStripeCount.TabIndex = 33;
            this.seStripeCount.ValueChanged += new System.EventHandler(this.seStripeCount_ValueChanged);
            // 
            // checkUnCover
            // 
            this.checkUnCover.Location = new System.Drawing.Point(188, 184);
            this.checkUnCover.Name = "checkUnCover";
            this.checkUnCover.Properties.Caption = "Uncover";
            this.checkUnCover.Size = new System.Drawing.Size(75, 20);
            this.checkUnCover.TabIndex = 32;
            this.checkUnCover.CheckedChanged += new System.EventHandler(this.checkUnCover_CheckedChanged);
            // 
            // checkInward
            // 
            this.checkInward.Location = new System.Drawing.Point(101, 184);
            this.checkInward.Name = "checkInward";
            this.checkInward.Properties.Caption = "Inward";
            this.checkInward.Size = new System.Drawing.Size(75, 20);
            this.checkInward.TabIndex = 31;
            this.checkInward.CheckedChanged += new System.EventHandler(this.checkInward_CheckedChanged);
            // 
            // checkVertical
            // 
            this.checkVertical.Location = new System.Drawing.Point(20, 184);
            this.checkVertical.Name = "checkVertical";
            this.checkVertical.Properties.Caption = "Vertical";
            this.checkVertical.Size = new System.Drawing.Size(75, 20);
            this.checkVertical.TabIndex = 30;
            this.checkVertical.CheckedChanged += new System.EventHandler(this.checkVertical_CheckedChanged);
            // 
            // lbBackground
            // 
            this.lbBackground.Location = new System.Drawing.Point(22, 124);
            this.lbBackground.Name = "lbBackground";
            this.lbBackground.Size = new System.Drawing.Size(60, 13);
            this.lbBackground.TabIndex = 24;
            this.lbBackground.Text = "Background:";
            // 
            // lbStripeCount
            // 
            this.lbStripeCount.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbStripeCount.Appearance.Options.UseBackColor = true;
            this.lbStripeCount.Location = new System.Drawing.Point(22, 154);
            this.lbStripeCount.Name = "lbStripeCount";
            this.lbStripeCount.Size = new System.Drawing.Size(62, 13);
            this.lbStripeCount.TabIndex = 22;
            this.lbStripeCount.Text = "Stripe count:";
            // 
            // lbFrameCount
            // 
            this.lbFrameCount.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbFrameCount.Appearance.Options.UseBackColor = true;
            this.lbFrameCount.Location = new System.Drawing.Point(22, 66);
            this.lbFrameCount.Name = "lbFrameCount";
            this.lbFrameCount.Size = new System.Drawing.Size(64, 13);
            this.lbFrameCount.TabIndex = 21;
            this.lbFrameCount.Text = "Frame count:";
            // 
            // lbFrameInterval
            // 
            this.lbFrameInterval.Location = new System.Drawing.Point(22, 37);
            this.lbFrameInterval.Name = "lbFrameInterval";
            this.lbFrameInterval.Size = new System.Drawing.Size(73, 13);
            this.lbFrameInterval.TabIndex = 16;
            this.lbFrameInterval.Text = "Frame interval:";
            // 
            // cbEffectOptions
            // 
            this.cbEffectOptions.EditValue = "";
            this.cbEffectOptions.Location = new System.Drawing.Point(123, 92);
            this.cbEffectOptions.Name = "cbEffectOptions";
            this.cbEffectOptions.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEffectOptions.Size = new System.Drawing.Size(140, 20);
            this.cbEffectOptions.TabIndex = 15;
            this.cbEffectOptions.SelectedIndexChanged += new System.EventHandler(this.cbEffectOptions_SelectedIndexChanged);
            // 
            // lbEffectOptions
            // 
            this.lbEffectOptions.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbEffectOptions.Appearance.Options.UseBackColor = true;
            this.lbEffectOptions.Location = new System.Drawing.Point(22, 95);
            this.lbEffectOptions.Name = "lbEffectOptions";
            this.lbEffectOptions.Size = new System.Drawing.Size(71, 13);
            this.lbEffectOptions.TabIndex = 14;
            this.lbEffectOptions.Text = "Effect options:";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Controls.Add(this.lbEasingFunction);
            this.groupControl1.Controls.Add(this.cbTransitionType);
            this.groupControl1.Controls.Add(this.cbEasingMode);
            this.groupControl1.Controls.Add(this.cbEasingFunction);
            this.groupControl1.Controls.Add(this.lbTransitionType);
            this.groupControl1.Controls.Add(this.lbEasingMode);
            this.groupControl1.Controls.Add(this.cbShowWaitIndicator);
            this.groupControl1.Controls.Add(this.lbShowWaitIndicator);
            this.groupControl1.Location = new System.Drawing.Point(529, 15);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(285, 158);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Transition properties";
            // 
            // lbEasingFunction
            // 
            this.lbEasingFunction.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbEasingFunction.Appearance.Options.UseBackColor = true;
            this.lbEasingFunction.Location = new System.Drawing.Point(22, 67);
            this.lbEasingFunction.Name = "lbEasingFunction";
            this.lbEasingFunction.Size = new System.Drawing.Size(77, 13);
            this.lbEasingFunction.TabIndex = 13;
            this.lbEasingFunction.Text = "Easing function:";
            // 
            // cbTransitionType
            // 
            this.cbTransitionType.EditValue = "";
            this.cbTransitionType.Location = new System.Drawing.Point(123, 121);
            this.cbTransitionType.Name = "cbTransitionType";
            this.cbTransitionType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbTransitionType.Size = new System.Drawing.Size(140, 20);
            this.cbTransitionType.TabIndex = 12;
            this.cbTransitionType.SelectedIndexChanged += new System.EventHandler(this.cbTransitionType_SelectedIndexChanged);
            // 
            // cbEasingMode
            // 
            this.cbEasingMode.EditValue = "";
            this.cbEasingMode.Location = new System.Drawing.Point(123, 35);
            this.cbEasingMode.Name = "cbEasingMode";
            this.cbEasingMode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEasingMode.Size = new System.Drawing.Size(140, 20);
            this.cbEasingMode.TabIndex = 10;
            this.cbEasingMode.SelectedIndexChanged += new System.EventHandler(this.cbEasingMode_SelectedIndexChanged);
            // 
            // cbEasingFunction
            // 
            this.cbEasingFunction.EditValue = "";
            this.cbEasingFunction.Location = new System.Drawing.Point(123, 64);
            this.cbEasingFunction.Name = "cbEasingFunction";
            this.cbEasingFunction.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbEasingFunction.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbEasingFunction.Size = new System.Drawing.Size(140, 20);
            this.cbEasingFunction.TabIndex = 9;
            // 
            // lbTransitionType
            // 
            this.lbTransitionType.Location = new System.Drawing.Point(22, 124);
            this.lbTransitionType.Name = "lbTransitionType";
            this.lbTransitionType.Size = new System.Drawing.Size(76, 13);
            this.lbTransitionType.TabIndex = 7;
            this.lbTransitionType.Text = "Transition type:";
            // 
            // lbEasingMode
            // 
            this.lbEasingMode.Location = new System.Drawing.Point(22, 38);
            this.lbEasingMode.Name = "lbEasingMode";
            this.lbEasingMode.Size = new System.Drawing.Size(64, 13);
            this.lbEasingMode.TabIndex = 6;
            this.lbEasingMode.Text = "Easing mode:";
            // 
            // cbShowWaitIndicator
            // 
            this.cbShowWaitIndicator.EditValue = "";
            this.cbShowWaitIndicator.Location = new System.Drawing.Point(123, 93);
            this.cbShowWaitIndicator.Name = "cbShowWaitIndicator";
            this.cbShowWaitIndicator.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbShowWaitIndicator.Size = new System.Drawing.Size(140, 20);
            this.cbShowWaitIndicator.TabIndex = 2;
            this.cbShowWaitIndicator.SelectedIndexChanged += new System.EventHandler(this.cbShowWaitIndicator_SelectedIndexChanged);
            // 
            // lbShowWaitIndicator
            // 
            this.lbShowWaitIndicator.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lbShowWaitIndicator.Appearance.Options.UseBackColor = true;
            this.lbShowWaitIndicator.Location = new System.Drawing.Point(22, 96);
            this.lbShowWaitIndicator.Name = "lbShowWaitIndicator";
            this.lbShowWaitIndicator.Size = new System.Drawing.Size(97, 13);
            this.lbShowWaitIndicator.TabIndex = 1;
            this.lbShowWaitIndicator.Text = "Show wait indicator:";
            // 
            // transitionManager
            // 
            transition1.Control = this.pictureEdit;
            this.transitionManager.Transitions.Add(transition1);
            // 
            // ModuleTransitionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "ModuleTransitionManager";
            this.Size = new System.Drawing.Size(843, 436);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.reviewImages)).EndInit();
            this.reviewImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.galleryControl)).EndInit();
            this.galleryControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transitionParameters)).EndInit();
            this.transitionParameters.ResumeLayout(false);
            this.transitionParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceBackground.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFrameInterval.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seFrameCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seStripeCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkUnCover.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkInward.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkVertical.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEffectOptions.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTransitionType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEasingMode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbEasingFunction.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbShowWaitIndicator.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.Animation.TransitionManager transitionManager;
        private XtraBars.Ribbon.GalleryControl galleryControl;
        private XtraBars.Ribbon.GalleryControlClient galleryControlClient;
        private PictureEdit pictureEdit;
        private GroupControl groupControl1;
        private LabelControl lbTransitionType;
        private LabelControl lbEasingMode;
        private ImageComboBoxEdit cbShowWaitIndicator;
        private LabelControl lbShowWaitIndicator;
        private LabelControl lbEasingFunction;
        private ImageComboBoxEdit cbTransitionType;
        private ImageComboBoxEdit cbEasingMode;
        private ComboBoxEdit cbEasingFunction;
        private LabelControl lbEffectOptions;
        private ImageComboBoxEdit cbEffectOptions;
        private LabelControl lbFrameInterval;
        private LabelControl lbFrameCount;
        private LabelControl lbStripeCount;
        private LabelControl lbBackground;
        private CheckEdit checkVertical;
        private CheckEdit checkInward;
        private GroupControl transitionParameters;
        private GroupControl reviewImages;
        private ColorEdit ceBackground;
        private SpinEdit seFrameInterval;
        private SpinEdit seFrameCount;
        private SpinEdit seStripeCount;
        private CheckEdit checkUnCover;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;

    }
}
