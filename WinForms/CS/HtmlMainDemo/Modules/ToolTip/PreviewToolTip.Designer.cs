namespace DevExpress.HTML.Demos {
    partial class PreviewToolTip {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewToolTip));
            this.htmlTemplateCollection1 = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.templateSimpleToolTip = new DevExpress.Utils.Html.HtmlTemplate();
            this.templateSimpleToolTipWithButton = new DevExpress.Utils.Html.HtmlTemplate();
            this.templateStandardToolTip = new DevExpress.Utils.Html.HtmlTemplate();
            this.SuspendLayout();
            // 
            // htmlTemplateCollection1
            // 
            this.htmlTemplateCollection1.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.templateSimpleToolTip,
            this.templateSimpleToolTipWithButton,
            this.templateStandardToolTip});
            // 
            // templateSimpleToolTip
            // 
            this.templateSimpleToolTip.Name = "templateSimpleToolTip";
            this.templateSimpleToolTip.Styles = resources.GetString("templateSimpleToolTip.Styles");
            this.templateSimpleToolTip.Tag = "Simple ToolTip";
            this.templateSimpleToolTip.Template = "<div class=\"container\">\r\n\t<div class=\"item title\">${Title}</div>\r\n\t<div class=\"it" +
    "em text\">${ToolTip}</div>\r\n</div>";
            // 
            // templateSimpleToolTipWithButton
            // 
            this.templateSimpleToolTipWithButton.Name = "templateSimpleToolTipWithButton";
            this.templateSimpleToolTipWithButton.Styles = resources.GetString("templateSimpleToolTipWithButton.Styles");
            this.templateSimpleToolTipWithButton.Tag = "Simple ToolTip With Button";
            this.templateSimpleToolTipWithButton.Template = resources.GetString("templateSimpleToolTipWithButton.Template");
            // 
            // templateStandardToolTip
            // 
            this.templateStandardToolTip.Name = "templateStandardToolTip";
            this.templateStandardToolTip.Styles = resources.GetString("templateStandardToolTip.Styles");
            this.templateStandardToolTip.Tag = "Standard Template";
            this.templateStandardToolTip.Template = resources.GetString("templateStandardToolTip.Template");
            // 
            // PreviewToolTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PreviewToolTip";
            this.Size = new System.Drawing.Size(726, 462);
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.Html.HtmlTemplateCollection htmlTemplateCollection1;
        private Utils.Html.HtmlTemplate templateSimpleToolTipWithButton;
        private Utils.Html.HtmlTemplate templateSimpleToolTip;
        private Utils.Html.HtmlTemplate templateStandardToolTip;
    }
}
