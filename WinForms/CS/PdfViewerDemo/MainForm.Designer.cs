
namespace DevExpress.XtraPdfViewer.Demos {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // gcDescription
            // 
            this.gcDescription.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gcDescription.Appearance.Options.UseFont = true;
            this.gcDescription.AppearanceDisabled.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gcDescription.AppearanceDisabled.Options.UseFont = true;
            this.gcDescription.AppearanceHovered.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gcDescription.AppearanceHovered.Options.UseFont = true;
            this.gcDescription.AppearancePressed.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.gcDescription.AppearancePressed.Options.UseFont = true;
            this.gcDescription.Location = new System.Drawing.Point(0, 0);
            this.gcDescription.Size = new System.Drawing.Size(884, 40);
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.OptionsPageCategories.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            // 
            // 
            // 
            this.ribbonControl1.SearchEditItem.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Left;
            this.ribbonControl1.SearchEditItem.EditWidth = 150;
            this.ribbonControl1.SearchEditItem.Id = -5000;
            this.ribbonControl1.SearchEditItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbonControl1.SearchEditItem.UseEditorPadding = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1398, 959);
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("MainForm.IconOptions.Icon")));
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
