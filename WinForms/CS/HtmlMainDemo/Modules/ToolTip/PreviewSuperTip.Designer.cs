namespace DevExpress.HTML.Demos {
    partial class PreviewSuperTip {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewSuperTip));
            this.htmlTemplateCollection1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.htmlSimple = new DevExpress.Utils.Html.HtmlTemplate();
            this.templateStandardSuperTip = new DevExpress.Utils.Html.HtmlTemplate();
            this.SuspendLayout();
            // 
            // htmlTemplateCollection1
            // 
            this.htmlTemplateCollection1.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.htmlSimple,
            this.templateStandardSuperTip});
            // 
            // htmlSimple
            // 
            this.htmlSimple.Name = "htmlSimple";
            this.htmlSimple.PreviewType = typeof(DevExpress.Utils.ToolTipController);
            this.htmlSimple.Styles = resources.GetString("htmlSimple.Styles");
            this.htmlSimple.Tag = "Simple SuperTip";
            this.htmlSimple.Template = resources.GetString("htmlSimple.Template");
            // 
            // templateStandardSuperTip
            // 
            this.templateStandardSuperTip.Name = "templateStandardSuperTip";
            this.templateStandardSuperTip.PreviewType = typeof(DevExpress.Utils.ToolTipController);
            this.templateStandardSuperTip.Styles = resources.GetString("templateStandardSuperTip.Styles");
            this.templateStandardSuperTip.Tag = "Standard SuperTip Template";
            this.templateStandardSuperTip.Template = resources.GetString("templateStandardSuperTip.Template");
            // 
            // PreviewSuperTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PreviewSuperTip";
            this.Size = new System.Drawing.Size(714, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Utils.Html.HtmlTemplateCollection htmlTemplateCollection1;
        private Utils.Html.HtmlTemplate htmlSimple;
        private Utils.Html.HtmlTemplate templateStandardSuperTip;
    }
}
