namespace DevExpress.AI.Demos {
    partial class PdfViewerAIModule {
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
            this.ucDisclaimerPanel1 = new DevExpress.AI.Demos.ucDisclaimerPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.pdfViewer1 = new DevExpress.XtraPdfViewer.PdfViewer();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUcDisclaimerPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).BeginInit();
            this.roundedSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDisclaimerPanel1
            // 
            this.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            this.ucDisclaimerPanel1.Size = new System.Drawing.Size(784, 103);
            this.ucDisclaimerPanel1.TabIndex = 5;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.roundedSkinPanel1);
            this.layoutControl1.Controls.Add(this.ucDisclaimerPanel1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(2862, 52, 835, 582);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(784, 432);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // roundedSkinPanel1
            // 
            this.roundedSkinPanel1.Controls.Add(this.pdfViewer1);
            this.roundedSkinPanel1.Location = new System.Drawing.Point(0, 103);
            this.roundedSkinPanel1.Name = "roundedSkinPanel1";
            this.roundedSkinPanel1.Size = new System.Drawing.Size(784, 329);
            this.roundedSkinPanel1.TabIndex = 1;
            this.roundedSkinPanel1.Text = "roundedSkinPanel1";
            // 
            // pdfViewer1
            // 
            languageInfo1.Culture = new System.Globalization.CultureInfo("en");
            languageInfo1.LanguageName = "English";
            languageInfo2.Culture = new System.Globalization.CultureInfo("es");
            languageInfo2.LanguageName = "Spanish";
            languageInfo3.Culture = new System.Globalization.CultureInfo("de");
            languageInfo3.LanguageName = "German";
            this.behaviorManager1.SetBehaviors(this.pdfViewer1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.SummarizeBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.PdfSummarizeBehaviorSource), DevExpress.AIIntegration.SummarizationMode.Abstractive))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.TranslateBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.PdfTranslateBehaviorSource), new DevExpress.AIIntegration.WinForms.LanguageInfo[] {
                        languageInfo1,
                        languageInfo2,
                        languageInfo3}))),
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.AIIntegration.WinForms.CustomRequestBehavior.Create(typeof(DevExpress.AIIntegration.WinForms.PdfCustomRequestBehaviorSource))))});
            this.pdfViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewer1.Location = new System.Drawing.Point(17, 17);
            this.pdfViewer1.MinimumSize = new System.Drawing.Size(32, 32);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(750, 295);
            this.pdfViewer1.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciUcDisclaimerPanel1,
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(784, 432);
            this.Root.TextVisible = false;
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
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.roundedSkinPanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 103);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(784, 329);
            this.layoutControlItem1.TextVisible = false;
            // 
            // PdfViewerAIModule
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl1);
            this.Name = "PdfViewerAIModule";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).EndInit();
            this.roundedSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private XtraPdfViewer.PdfViewer pdfViewer1;
        private Utils.Behaviors.BehaviorManager behaviorManager1;
        private ucDisclaimerPanel ucDisclaimerPanel1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem lciUcDisclaimerPanel1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
