using DevExpress.HTML.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    partial class AlertControlModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlertControlModule));
            this.codeViewerPanel = new DevExpress.XtraEditors.SidePanel();
            this.templateViewer = new DevExpress.HTML.Demos.AlertControlTemplateViewer();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.svgImageCollection2 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.toastTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.glowTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.simpleTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.darkTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.showAlertButton = new DevExpress.XtraEditors.SimpleButton();
            this.mainPanel = new DevExpress.Utils.Layout.TablePanel();
            this.propertiesSeparator = new DevExpress.XtraEditors.SeparatorControl();
            this.htmlPreview = new DevExpress.XtraEditors.HtmlContentControl();
            this.buttonPanel = new DevExpress.Utils.Layout.TablePanel();
            this.propertiesPanel = new DevExpress.Utils.Layout.TablePanel();
            this.alertInfoProperties = new DevExpress.HTML.Demos.AlertInfoProperties();
            this.alertControlProperties = new DevExpress.HTML.Demos.AlertControlProperties();
            this.codeViewerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).BeginInit();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesSeparator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesPanel)).BeginInit();
            this.propertiesPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // codeViewerPanel
            // 
            this.codeViewerPanel.Controls.Add(this.templateViewer);
            this.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeViewerPanel.Location = new System.Drawing.Point(582, 0);
            this.codeViewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.codeViewerPanel.Name = "codeViewerPanel";
            this.codeViewerPanel.Size = new System.Drawing.Size(495, 612);
            this.codeViewerPanel.TabIndex = 1;
            this.codeViewerPanel.Text = "sidePanel1";
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(1, 0);
            this.templateViewer.Margin = new System.Windows.Forms.Padding(6);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(494, 612);
            this.templateViewer.TabIndex = 0;
            // 
            // alertControl1
            // 
            this.alertControl1.HtmlImages = this.svgImageCollection2;
            this.alertControl1.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.toastTemplate,
            this.glowTemplate,
            this.simpleTemplate,
            this.darkTemplate});
            // 
            // svgImageCollection2
            // 
            this.svgImageCollection2.Add("message_icon", "image://svgimages/outlook inspired/glyph_message.svg");
            this.svgImageCollection2.Add("message_image", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection2.Add("message_close", "image://svgimages/icon builder/actions_delete.svg");
            // 
            // toastTemplate
            // 
            this.toastTemplate.Name = "toastTemplate";
            this.toastTemplate.Styles = resources.GetString("toastTemplate.Styles");
            this.toastTemplate.Tag = "Toast";
            this.toastTemplate.Template = resources.GetString("toastTemplate.Template");
            // 
            // glowTemplate
            // 
            this.glowTemplate.Name = "glowTemplate";
            this.glowTemplate.Styles = resources.GetString("glowTemplate.Styles");
            this.glowTemplate.Tag = "Glow";
            this.glowTemplate.Template = resources.GetString("glowTemplate.Template");
            // 
            // simpleTemplate
            // 
            this.simpleTemplate.Name = "simpleTemplate";
            this.simpleTemplate.Styles = resources.GetString("simpleTemplate.Styles");
            this.simpleTemplate.Tag = "Simple";
            this.simpleTemplate.Template = resources.GetString("simpleTemplate.Template");
            // 
            // darkTemplate
            // 
            this.darkTemplate.Name = "darkTemplate";
            this.darkTemplate.Styles = resources.GetString("darkTemplate.Styles");
            this.darkTemplate.Tag = "Dark";
            this.darkTemplate.Template = "<div class=\"container\">\r\n    <div class=\"popup\">\r\n\t\t<div class=\"text\">${Text}</di" +
    "v>\r\n\t\t<div id=\"closeButton\" class=\"content close-button\">CLOSE</div>\r\n\t</div>\r\n<" +
    "/div>";
            // 
            // showAlertButton
            // 
            this.buttonPanel.SetColumn(this.showAlertButton, 1);
            this.showAlertButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showAlertButton.Location = new System.Drawing.Point(184, 2);
            this.showAlertButton.Margin = new System.Windows.Forms.Padding(2);
            this.showAlertButton.Name = "showAlertButton";
            this.buttonPanel.SetRow(this.showAlertButton, 0);
            this.showAlertButton.Size = new System.Drawing.Size(210, 23);
            this.showAlertButton.TabIndex = 6;
            this.showAlertButton.Text = "Show the Alert";
            this.showAlertButton.Click += new System.EventHandler(this.ShowAlertButton_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 500F)});
            this.mainPanel.Controls.Add(this.propertiesSeparator);
            this.mainPanel.Controls.Add(this.htmlPreview);
            this.mainPanel.Controls.Add(this.buttonPanel);
            this.mainPanel.Controls.Add(this.propertiesPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 36F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 177F)});
            this.mainPanel.Size = new System.Drawing.Size(582, 612);
            this.mainPanel.TabIndex = 6;
            // 
            // propertiesSeparator
            // 
            this.mainPanel.SetColumn(this.propertiesSeparator, 0);
            this.propertiesSeparator.Location = new System.Drawing.Point(0, 434);
            this.propertiesSeparator.Margin = new System.Windows.Forms.Padding(0);
            this.propertiesSeparator.Name = "propertiesSeparator";
            this.propertiesSeparator.Padding = new System.Windows.Forms.Padding(0);
            this.mainPanel.SetRow(this.propertiesSeparator, 3);
            this.propertiesSeparator.Size = new System.Drawing.Size(582, 2);
            this.propertiesSeparator.TabIndex = 11;
            // 
            // htmlPreview
            // 
            this.mainPanel.SetColumn(this.htmlPreview, 0);
            this.htmlPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlPreview.Location = new System.Drawing.Point(2, 32);
            this.htmlPreview.Margin = new System.Windows.Forms.Padding(2);
            this.htmlPreview.Name = "htmlPreview";
            this.mainPanel.SetRow(this.htmlPreview, 1);
            this.htmlPreview.Size = new System.Drawing.Size(578, 293);
            this.htmlPreview.TabIndex = 10;
            // 
            // buttonPanel
            // 
            this.mainPanel.SetColumn(this.buttonPanel, 0);
            this.buttonPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 400F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.buttonPanel.Controls.Add(this.showAlertButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(2, 327);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.mainPanel.SetRow(this.buttonPanel, 2);
            this.buttonPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 40F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.buttonPanel.Size = new System.Drawing.Size(578, 105);
            this.buttonPanel.TabIndex = 9;
            // 
            // propertiesPanel
            // 
            this.mainPanel.SetColumn(this.propertiesPanel, 0);
            this.propertiesPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.propertiesPanel.Controls.Add(this.alertInfoProperties);
            this.propertiesPanel.Controls.Add(this.alertControlProperties);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesPanel.Location = new System.Drawing.Point(2, 438);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesPanel.Name = "propertiesPanel";
            this.mainPanel.SetRow(this.propertiesPanel, 4);
            this.propertiesPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.propertiesPanel.Size = new System.Drawing.Size(578, 172);
            this.propertiesPanel.TabIndex = 8;
            // 
            // alertInfoProperties
            // 
            this.propertiesPanel.SetColumn(this.alertInfoProperties, 1);
            this.alertInfoProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertInfoProperties.Location = new System.Drawing.Point(292, 3);
            this.alertInfoProperties.Name = "alertInfoProperties";
            this.propertiesPanel.SetRow(this.alertInfoProperties, 0);
            this.alertInfoProperties.Size = new System.Drawing.Size(283, 166);
            this.alertInfoProperties.TabIndex = 0;
            // 
            // alertControlProperties
            // 
            this.propertiesPanel.SetColumn(this.alertControlProperties, 0);
            this.alertControlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alertControlProperties.Location = new System.Drawing.Point(3, 3);
            this.alertControlProperties.Name = "alertControlProperties";
            this.propertiesPanel.SetRow(this.alertControlProperties, 0);
            this.alertControlProperties.Size = new System.Drawing.Size(283, 166);
            this.alertControlProperties.TabIndex = 0;
            // 
            // AlertControlModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.codeViewerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AlertControlModule";
            this.Size = new System.Drawing.Size(1077, 612);
            this.codeViewerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainPanel)).EndInit();
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesSeparator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.propertiesPanel)).EndInit();
            this.propertiesPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SidePanel codeViewerPanel;
        private AlertControlTemplateViewer templateViewer;
        private DevExpress.HTML.Demos.AlertInfoProperties alertInfoProperties;
        private XtraBars.Alerter.AlertControl alertControl1;
        private HtmlTemplate darkTemplate;
        private HtmlTemplate simpleTemplate;
        private DevExpress.Utils.SvgImageCollection svgImageCollection2;
        private HtmlTemplate toastTemplate;
        private AlertControlProperties alertControlProperties;
        private SimpleButton showAlertButton;
        private Utils.Layout.TablePanel mainPanel;
        private HtmlTemplate glowTemplate;
        private Utils.Layout.TablePanel propertiesPanel;
        private Utils.Layout.TablePanel buttonPanel;
        private HtmlContentControl htmlPreview;
        private SeparatorControl propertiesSeparator;
    }
}

