namespace DevExpress.AI.Demos {
    partial class MemoEditAIModule {
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
            DevExpress.AIIntegration.WinForms.LanguageInfo languageInfo1 = new DevExpress.AIIntegration.WinForms.LanguageInfo();
            DevExpress.AIIntegration.WinForms.LanguageInfo languageInfo2 = new DevExpress.AIIntegration.WinForms.LanguageInfo();
            DevExpress.AIIntegration.WinForms.LanguageInfo languageInfo3 = new DevExpress.AIIntegration.WinForms.LanguageInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemoEditAIModule));
            this.roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.ucDisclaimerPanel1 = new DevExpress.AI.Demos.ucDisclaimerPanel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRoundedSkinPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLabelControl1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPictureEdit2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciUcDisclaimerPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).BeginInit();
            this.roundedSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRoundedSkinPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPictureEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // roundedSkinPanel1
            // 
            this.roundedSkinPanel1.Controls.Add(this.memoEdit1);
            this.roundedSkinPanel1.Location = new System.Drawing.Point(0, 103);
            this.roundedSkinPanel1.Name = "roundedSkinPanel1";
            this.roundedSkinPanel1.Size = new System.Drawing.Size(468, 329);
            this.roundedSkinPanel1.TabIndex = 0;
            // 
            // memoEdit1
            // 
            languageInfo1.Culture = new System.Globalization.CultureInfo("en");
            languageInfo1.LanguageName = "English";
            languageInfo2.Culture = new System.Globalization.CultureInfo("de");
            languageInfo2.LanguageName = "German";
            languageInfo3.Culture = new System.Globalization.CultureInfo("fr");
            languageInfo3.LanguageName = "French";
            this.behaviorManager1.SetBehaviors(this.memoEdit1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.ExpandBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditExpandBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.ShortenBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditShortenBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditSummarizeBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected, DevExpress.AIIntegration.SummarizationMode.Abstractive))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.ExplainBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditExplainBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.ChangeToneBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditChangeToneBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.ProofreadBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditProofreadBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.ChangeStyleBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditChangeStyleBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditTranslateBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected, new DevExpress.AIIntegration.WinForms.LanguageInfo[] {
                        languageInfo1,
                        languageInfo2,
                        languageInfo3}))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.MemoEditCustomRequestBehaviorSource), null, "", DevExpress.AIIntegration.Extensions.TextRetrievalMode.AllTextIfNoneSelected)))});
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue");
            this.memoEdit1.Location = new System.Drawing.Point(17, 17);
            this.memoEdit1.MinimumSize = new System.Drawing.Size(32, 32);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.memoEdit1.Size = new System.Drawing.Size(434, 295);
            this.memoEdit1.StyleController = this.layoutControl2;
            this.memoEdit1.TabIndex = 4;
            // 
            // layoutControl2
            // 
            this.layoutControl2.AllowCustomization = false;
            this.layoutControl2.Controls.Add(this.ucDisclaimerPanel1);
            this.layoutControl2.Controls.Add(this.pictureEdit2);
            this.layoutControl2.Controls.Add(this.labelControl1);
            this.layoutControl2.Controls.Add(this.roundedSkinPanel1);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl2.Location = new System.Drawing.Point(0, 0);
            this.layoutControl2.MinimumSize = new System.Drawing.Size(400, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(758, 405, 934, 502);
            this.layoutControl2.OptionsCustomizationForm.ShowPropertyGrid = true;
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(784, 432);
            this.layoutControl2.TabIndex = 3;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // ucDisclaimerPanel1
            // 
            this.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            this.ucDisclaimerPanel1.Size = new System.Drawing.Size(784, 103);
            this.ucDisclaimerPanel1.TabIndex = 5;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = global::DevExpress.AI.Demos.Properties.Resources.ai_assistant_menu;
            this.pictureEdit2.Location = new System.Drawing.Point(487, 320);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit2.Size = new System.Drawing.Size(278, 93);
            this.pictureEdit2.StyleController = this.layoutControl2;
            this.pictureEdit2.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.AllowHtmlString = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Location = new System.Drawing.Point(487, 132);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(278, 172);
            this.labelControl1.StyleController = this.layoutControl2;
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = resources.GetString("labelControl1.Text");
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRoundedSkinPanel1,
            this.layoutControlGroup3,
            this.lciUcDisclaimerPanel1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(784, 432);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lciRoundedSkinPanel1
            // 
            this.lciRoundedSkinPanel1.Control = this.roundedSkinPanel1;
            this.lciRoundedSkinPanel1.Location = new System.Drawing.Point(0, 103);
            this.lciRoundedSkinPanel1.Name = "lciRoundedSkinPanel1";
            this.lciRoundedSkinPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciRoundedSkinPanel1.Size = new System.Drawing.Size(468, 329);
            this.lciRoundedSkinPanel1.TextVisible = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup3.GroupBordersVisible = false;
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLabelControl1,
            this.lciPictureEdit2});
            this.layoutControlGroup3.Location = new System.Drawing.Point(468, 103);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.Size = new System.Drawing.Size(316, 329);
            this.layoutControlGroup3.TextVisible = false;
            // 
            // lciLabelControl1
            // 
            this.lciLabelControl1.Control = this.labelControl1;
            this.lciLabelControl1.Location = new System.Drawing.Point(0, 0);
            this.lciLabelControl1.Name = "lciLabelControl1";
            this.lciLabelControl1.Size = new System.Drawing.Size(284, 198);
            this.lciLabelControl1.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 10, 10);
            this.lciLabelControl1.TextVisible = false;
            // 
            // lciPictureEdit2
            // 
            this.lciPictureEdit2.Control = this.pictureEdit2;
            this.lciPictureEdit2.Location = new System.Drawing.Point(0, 198);
            this.lciPictureEdit2.Name = "lciPictureEdit2";
            this.lciPictureEdit2.Size = new System.Drawing.Size(284, 99);
            this.lciPictureEdit2.TextVisible = false;
            // 
            // lciUcDisclaimerPanel1
            // 
            this.lciUcDisclaimerPanel1.Control = this.ucDisclaimerPanel1;
            this.lciUcDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.lciUcDisclaimerPanel1.Name = "lciUcDisclaimerPanel1";
            this.lciUcDisclaimerPanel1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciUcDisclaimerPanel1.Size = new System.Drawing.Size(784, 103);
            this.lciUcDisclaimerPanel1.TextVisible = false;
            // 
            // MemoEditAIModule
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl2);
            this.Name = "MemoEditAIModule";
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).EndInit();
            this.roundedSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRoundedSkinPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPictureEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private XtraEditors.MemoEdit memoEdit1;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel1;
        private XtraEditors.LabelControl labelControl1;
        private XtraLayout.LayoutControl layoutControl2;
        private XtraLayout.LayoutControlGroup layoutControlGroup1;
        private XtraEditors.PictureEdit pictureEdit2;
        private XtraLayout.LayoutControlItem lciPictureEdit2;
        private XtraLayout.LayoutControlItem lciLabelControl1;
        private XtraLayout.LayoutControlItem lciRoundedSkinPanel1;
        private XtraLayout.LayoutControlGroup layoutControlGroup3;
        private ucDisclaimerPanel ucDisclaimerPanel1;
        private XtraLayout.LayoutControlItem lciUcDisclaimerPanel1;
    }
}
