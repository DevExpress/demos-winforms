using DevExpress.Utils.Html;

namespace DevExpress.HTML.Demos {
    partial class DialogBoxView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DialogBoxView));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.dialogTemplateViewer = new DevExpress.HTML.Demos.DialogBoxTemplateViewer();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.buttonPanel = new DevExpress.Utils.Layout.TablePanel();
            this.showDialog = new DevExpress.XtraEditors.SimpleButton();
            this.hostDialog = new DevExpress.XtraEditors.XtraUserControl();
            this.svgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.htmlDialogTemplateCollection = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.loginFormTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.feedbackFormTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.htmlContentTemplateCollection = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.loginTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.feedbackTemplate = new DevExpress.Utils.Html.HtmlTemplate();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).BeginInit();
            this.buttonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.dialogTemplateViewer);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(297, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(450, 350);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // dialogTemplateViewer
            // 
            this.dialogTemplateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dialogTemplateViewer.Location = new System.Drawing.Point(1, 0);
            this.dialogTemplateViewer.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dialogTemplateViewer.Name = "dialogTemplateViewer";
            this.dialogTemplateViewer.Size = new System.Drawing.Size(449, 350);
            this.dialogTemplateViewer.TabIndex = 0;
            this.dialogTemplateViewer.ActiveTemplateChanged += new System.EventHandler(this.OnActiveTemplateChanged);
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.buttonPanel);
            this.tablePanel1.Controls.Add(this.hostDialog);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F)});
            this.tablePanel1.Size = new System.Drawing.Size(297, 350);
            this.tablePanel1.TabIndex = 1;
            // 
            // buttonPanel
            // 
            this.tablePanel1.SetColumn(this.buttonPanel, 0);
            this.buttonPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 180F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.buttonPanel.Controls.Add(this.showDialog);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(2, 250);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.tablePanel1.SetRow(this.buttonPanel, 1);
            this.buttonPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.buttonPanel.Size = new System.Drawing.Size(293, 98);
            this.buttonPanel.TabIndex = 12;
            // 
            // showDialog
            // 
            this.buttonPanel.SetColumn(this.showDialog, 1);
            this.showDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showDialog.Location = new System.Drawing.Point(59, 2);
            this.showDialog.Margin = new System.Windows.Forms.Padding(2);
            this.showDialog.Name = "showDialog";
            this.buttonPanel.SetRow(this.showDialog, 0);
            this.showDialog.Size = new System.Drawing.Size(176, 26);
            this.showDialog.TabIndex = 6;
            this.showDialog.Text = "Show the DialogBox";
            this.showDialog.Click += new System.EventHandler(this.OnShowDialogBoxButtonClick);
            // 
            // hostDialog
            // 
            this.tablePanel1.SetColumn(this.hostDialog, 0);
            this.hostDialog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostDialog.Location = new System.Drawing.Point(0, 0);
            this.hostDialog.Margin = new System.Windows.Forms.Padding(0);
            this.hostDialog.Name = "hostDialog";
            this.tablePanel1.SetRow(this.hostDialog, 0);
            this.hostDialog.Size = new System.Drawing.Size(297, 250);
            this.hostDialog.TabIndex = 2;
            this.hostDialog.TabStop = false;
            // 
            // svgImages
            // 
            this.svgImages.Add("close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.close"))));
            this.svgImages.Add("pass", "image://svgimages/icon builder/security_key.svg");
            this.svgImages.Add("login", "image://svgimages/business objects/bo_lead.svg");
            // 
            // htmlDialogTemplateCollection
            // 
            this.htmlDialogTemplateCollection.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.loginFormTemplate,
            this.feedbackFormTemplate});
            // 
            // loginFormTemplate
            // 
            this.loginFormTemplate.Name = "loginFormTemplate";
            this.loginFormTemplate.Styles = resources.GetString("loginFormTemplate.Styles");
            this.loginFormTemplate.Tag = "Login Form";
            this.loginFormTemplate.Template = resources.GetString("loginFormTemplate.Template");
            // 
            // feedbackFormTemplate
            // 
            this.feedbackFormTemplate.Name = "feedbackFormTemplate";
            this.feedbackFormTemplate.Styles = resources.GetString("feedbackFormTemplate.Styles");
            this.feedbackFormTemplate.Tag = "Feedback Form";
            this.feedbackFormTemplate.Template = resources.GetString("feedbackFormTemplate.Template");
            // 
            // htmlContentTemplateCollection
            // 
            this.htmlContentTemplateCollection.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.loginTemplate,
            this.feedbackTemplate});
            // 
            // loginTemplate
            // 
            this.loginTemplate.Name = "loginTemplate";
            this.loginTemplate.Styles = resources.GetString("loginTemplate.Styles");
            this.loginTemplate.Template = resources.GetString("loginTemplate.Template");
            // 
            // feedbackTemplate
            // 
            this.feedbackTemplate.Name = "feedbackTemplate";
            this.feedbackTemplate.Styles = resources.GetString("feedbackTemplate.Styles");
            this.feedbackTemplate.Template = resources.GetString("feedbackTemplate.Template");
            // 
            // DialogBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DialogBoxView";
            this.Size = new System.Drawing.Size(747, 350);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private XtraEditors.SidePanel sidePanel1;
        private DialogBoxTemplateViewer dialogTemplateViewer;
        private Utils.Layout.TablePanel tablePanel1;
        private XtraEditors.XtraUserControl hostDialog;
        private Utils.SvgImageCollection svgImages;
        private Utils.Layout.TablePanel buttonPanel;
        private XtraEditors.SimpleButton showDialog;
        private HtmlTemplateCollection htmlDialogTemplateCollection;
        private HtmlTemplateCollection htmlContentTemplateCollection;
        private HtmlTemplate feedbackFormTemplate;
        private HtmlTemplate loginFormTemplate;
        private HtmlTemplate loginTemplate;
        private HtmlTemplate feedbackTemplate;
    }
}
