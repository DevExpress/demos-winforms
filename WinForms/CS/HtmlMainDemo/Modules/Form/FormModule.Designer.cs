using DevExpress.HTML.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    partial class FormModule {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModule));
            this.codeViewerPanel = new DevExpress.XtraEditors.SidePanel();
            this.templateViewer = new DevExpress.HTML.Demos.FormTemplateViewer();
            this.hostPanel = new DevExpress.XtraEditors.XtraUserControl();
            this.htmlTemplateCollection = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.defaultTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.aboutFormTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.contentTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.svgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.codeViewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).BeginInit();
            this.SuspendLayout();
            // 
            // codeViewerPanel
            // 
            this.codeViewerPanel.Controls.Add(this.templateViewer);
            this.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeViewerPanel.Location = new System.Drawing.Point(339, 0);
            this.codeViewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.codeViewerPanel.Name = "codeViewerPanel";
            this.codeViewerPanel.Size = new System.Drawing.Size(320, 405);
            this.codeViewerPanel.TabIndex = 1;
            this.codeViewerPanel.TabStop = false;
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(1, 0);
            this.templateViewer.Margin = new System.Windows.Forms.Padding(6);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(319, 405);
            this.templateViewer.TabIndex = 1;
            // 
            // hostPanel
            // 
            this.hostPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostPanel.Location = new System.Drawing.Point(0, 0);
            this.hostPanel.Margin = new System.Windows.Forms.Padding(0);
            this.hostPanel.Name = "hostPanel";
            this.hostPanel.Size = new System.Drawing.Size(339, 405);
            this.hostPanel.TabIndex = 0;
            this.hostPanel.TabStop = false;
            this.hostPanel.SizeChanged += new System.EventHandler(this.OnPanelSizeChanged);
            // 
            // htmlTemplateCollection
            // 
            this.htmlTemplateCollection.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.defaultTemplate,
            this.aboutFormTemplate,
            this.contentTemplate});
            // 
            // defaultTemplate
            // 
            this.defaultTemplate.Name = "defaultTemplate";
            this.defaultTemplate.PreviewType = typeof(DevExpress.XtraEditors.DirectXForm);
            this.defaultTemplate.Tag = "Default HTML-CSS Template";
            this.defaultTemplate.Template = resources.GetString("defaultTemplate.Template");
            // 
            // aboutFormTemplate
            // 
            this.aboutFormTemplate.Name = "aboutFormTemplate";
            this.aboutFormTemplate.PreviewType = typeof(DevExpress.XtraEditors.DirectXForm);
            this.aboutFormTemplate.Styles = resources.GetString("aboutFormTemplate.Styles");
            this.aboutFormTemplate.Template = resources.GetString("aboutFormTemplate.Template");
            // 
            // contentTemplate
            // 
            this.contentTemplate.Name = "contentTemplate";
            this.contentTemplate.Styles = resources.GetString("contentTemplate.Styles");
            this.contentTemplate.Template = "<div class=\"content\">\r\n\t<div class=\"test\">Click the button below to open this for" +
    "m.</div>\r\n\t<div class=\"btn-outline\" id=\"showform\">Show DirectX Form</div>\r\n</div" +
    ">";
            // 
            // svgImages
            // 
            this.svgImages.Add("Back", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Back"))));
            this.svgImages.Add("Close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Close"))));
            this.svgImages.Add("Forward", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Forward"))));
            this.svgImages.Add("Info", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Info"))));
            this.svgImages.Add("Search", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Search"))));
            this.svgImages.Add("User", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.User"))));
            this.svgImages.Add("Add", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Add"))));
            this.svgImages.Add("Logo", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.Logo"))));
            // 
            // FormModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hostPanel);
            this.Controls.Add(this.codeViewerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormModule";
            this.Size = new System.Drawing.Size(659, 405);
            this.codeViewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HtmlTemplate defaultTemplate;
        private HtmlTemplate aboutFormTemplate;
        private DevExpress.XtraEditors.SidePanel codeViewerPanel;
        private FormTemplateViewer templateViewer;
        private DevExpress.XtraEditors.XtraUserControl hostPanel;
        private DevExpress.Utils.SvgImageCollection svgImages;
        private HtmlTemplateCollection htmlTemplateCollection;
        private HtmlTemplate contentTemplate;
    }
}
