using System.Windows.Forms;

namespace DevExpress.AI.Demos {
    partial class ReportDesignerAIModule {
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
            this.ucDisclaimerPanel1 = new DevExpress.AI.Demos.ucDisclaimerPanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.roundedSkinPanel1 = new DevExpress.XtraEditors.RoundedSkinPanel();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnRunDesigner = new DevExpress.XtraEditors.SimpleButton();
            this.lblTitle = new DevExpress.XtraEditors.LabelControl();
            this.galleryContainerPanel = new System.Windows.Forms.Panel();
            this.gallery = new DevExpress.DXperience.Demos.FeatureGalleryControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciUcDisclaimerPanel1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).BeginInit();
            this.roundedSkinPanel1.SuspendLayout();
            this.tableLayoutPanel.SuspendLayout();
            this.galleryContainerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucDisclaimerPanel1
            // 
            this.ucDisclaimerPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucDisclaimerPanel1.Location = new System.Drawing.Point(0, 0);
            this.ucDisclaimerPanel1.Name = "ucDisclaimerPanel1";
            this.ucDisclaimerPanel1.Size = new System.Drawing.Size(784, 308);
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
            this.roundedSkinPanel1.Controls.Add(this.tableLayoutPanel);
            this.roundedSkinPanel1.Location = new System.Drawing.Point(0, 308);
            this.roundedSkinPanel1.Name = "roundedSkinPanel1";
            this.roundedSkinPanel1.Size = new System.Drawing.Size(784, 124);
            this.roundedSkinPanel1.TabIndex = 1;
            this.roundedSkinPanel1.Text = "roundedSkinPanel1";
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.btnRunDesigner, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lblTitle, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.galleryContainerPanel, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(34, 34);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.MinimumSize = new System.Drawing.Size(64, 64);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(716, 64);
            this.tableLayoutPanel.TabIndex = 1;
            // 
            // btnRunDesigner
            // 
            this.btnRunDesigner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRunDesigner.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnRunDesigner.Appearance.Options.UseBackColor = true;
            this.btnRunDesigner.AutoSize = true;
            this.btnRunDesigner.Location = new System.Drawing.Point(271, 57);
            this.btnRunDesigner.Margin = new System.Windows.Forms.Padding(0, 27, 0, 54);
            this.btnRunDesigner.Name = "btnRunDesigner";
            this.btnRunDesigner.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);
            this.btnRunDesigner.Size = new System.Drawing.Size(174, 56);
            this.btnRunDesigner.TabIndex = 2;
            this.btnRunDesigner.Text = "Run Designer";
            this.btnRunDesigner.Click += new System.EventHandler(this.runDesignerBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.Appearance.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Appearance.Options.UseFont = true;
            this.lblTitle.Appearance.Options.UseTextOptions = true;
            this.lblTitle.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTitle.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTitle.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.lblTitle.Location = new System.Drawing.Point(91, -48);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0, 54, 0, 27);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(534, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "AI-powered Report Designer";
            // 
            // galleryContainerPanel
            // 
            this.galleryContainerPanel.AutoScroll = true;
            this.galleryContainerPanel.AutoSize = true;
            this.galleryContainerPanel.Controls.Add(this.gallery);
            this.galleryContainerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.galleryContainerPanel.Location = new System.Drawing.Point(3, 27);
            this.galleryContainerPanel.Name = "galleryContainerPanel";
            this.galleryContainerPanel.Size = new System.Drawing.Size(710, 0);
            this.galleryContainerPanel.TabIndex = 4;
            // 
            // gallery
            // 
            this.gallery.AutoSize = true;
            this.gallery.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gallery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gallery.Location = new System.Drawing.Point(0, 0);
            this.gallery.Margin = new System.Windows.Forms.Padding(0);
            this.gallery.Name = "gallery";
            this.gallery.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.gallery.Size = new System.Drawing.Size(710, 0);
            this.gallery.TabIndex = 3;
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
            this.lciUcDisclaimerPanel1.Size = new System.Drawing.Size(784, 308);
            this.lciUcDisclaimerPanel1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.roundedSkinPanel1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 308);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(784, 124);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ReportDesignerAIModule
            // 
            this.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Appearance.Options.UseFont = true;
            this.Controls.Add(this.layoutControl1);
            this.Resize += new System.EventHandler(this.OnResize);
            this.Name = "ReportDesignerAIModule";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.roundedSkinPanel1)).EndInit();
            this.roundedSkinPanel1.ResumeLayout(false);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.galleryContainerPanel.ResumeLayout(false);
            this.galleryContainerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUcDisclaimerPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private ucDisclaimerPanel ucDisclaimerPanel1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem lciUcDisclaimerPanel1;
        private XtraEditors.RoundedSkinPanel roundedSkinPanel1;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private DXperience.Demos.FeatureGalleryControl gallery;
        private DevExpress.XtraEditors.LabelControl lblTitle;
        private DevExpress.XtraEditors.SimpleButton btnRunDesigner;
        private Panel galleryContainerPanel;
        private TableLayoutPanel tableLayoutPanel;
    }
}
