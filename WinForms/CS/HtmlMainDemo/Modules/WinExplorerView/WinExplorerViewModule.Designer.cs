using DevExpress.HTML.Demos;
using DevExpress.Utils;
using DevExpress.Utils.Html;
using DevExpress.XtraEditors;

namespace DevExpress.HTML.Demos {
    partial class WinExplorerViewModule {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WinExplorerViewModule));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.winExplorerView1 = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.popupDetails = new DevExpress.Utils.Html.HtmlTemplate();
            this.htmlTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.codeViewerPanel = new DevExpress.XtraEditors.SidePanel();
            this.templateViewer = new DevExpress.HTML.Demos.WinExplorerViewTemplateCodeViewer();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.codeViewerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.winExplorerView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(624, 501);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.winExplorerView1});
            // 
            // winExplorerView1
            // 
            this.winExplorerView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.winExplorerView1.Appearance.EmptySpace.Options.UseBackColor = true;
            this.winExplorerView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.winExplorerView1.GridControl = this.gridControl1;
            this.winExplorerView1.HtmlImages = this.svgImageCollection1;
            this.winExplorerView1.HtmlTemplates.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.popupDetails});
            this.winExplorerView1.Name = "winExplorerView1";
            this.winExplorerView1.OptionsHtmlTemplate.AllowContentSelection = DevExpress.Utils.DefaultBoolean.True;
            this.winExplorerView1.OptionsSelection.ItemSelectionMode = DevExpress.XtraGrid.Views.WinExplorer.IconItemSelectionMode.Press;
            this.winExplorerView1.OptionsView.ContentHorizontalAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.winExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.ExtraLarge;
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HorizontalIndent = 0;
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Styles = resources.GetString("winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Styles");
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Tag = "Card";
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template = resources.GetString("winExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template");
            this.winExplorerView1.OptionsViewStyles.ExtraLarge.VerticalIndent = 0;
            this.winExplorerView1.ViewCaptionHeight = 0;
            this.winExplorerView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnWinExplorerViewKeyDown);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.close"))));
            // 
            // popupDetails
            // 
            this.popupDetails.Name = "popupDetails";
            this.popupDetails.Styles = resources.GetString("popupDetails.Styles");
            this.popupDetails.Tag = "Popup Details";
            this.popupDetails.Template = resources.GetString("popupDetails.Template");
            // 
            // htmlTemplate1
            // 
            this.htmlTemplate1.Name = "htmlTemplate1";
            this.htmlTemplate1.Styles = resources.GetString("htmlTemplate1.Styles");
            this.htmlTemplate1.Template = resources.GetString("htmlTemplate1.Template");
            // 
            // codeViewerPanel
            // 
            this.codeViewerPanel.Controls.Add(this.templateViewer);
            this.codeViewerPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.codeViewerPanel.Location = new System.Drawing.Point(624, 0);
            this.codeViewerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.codeViewerPanel.Name = "codeViewerPanel";
            this.codeViewerPanel.Size = new System.Drawing.Size(277, 501);
            this.codeViewerPanel.TabIndex = 1;
            this.codeViewerPanel.Text = "sidePanel1";
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(1, 0);
            this.templateViewer.Margin = new System.Windows.Forms.Padding(6);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(276, 501);
            this.templateViewer.TabIndex = 0;
            // 
            // alertControl1
            // 
            this.alertControl1.AutoFormDelay = 2000;
            this.alertControl1.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alertControl1.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopLeft;
            this.alertControl1.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.Reveal;
            this.alertControl1.HtmlTemplate.Styles = resources.GetString("alertControl1.HtmlTemplate.Styles");
            this.alertControl1.HtmlTemplate.Template = "<div class=\"container\">\r\n    <div class=\"shadow\">${Text}</div>\r\n</div>";
            // 
            // WinExplorerViewModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.codeViewerPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WinExplorerViewModule";
            this.Size = new System.Drawing.Size(901, 501);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winExplorerView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.codeViewerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView winExplorerView1;
        private DevExpress.XtraEditors.SidePanel codeViewerPanel;
        private WinExplorerViewTemplateCodeViewer templateViewer;
        private HtmlTemplate popupDetails;
        private HtmlTemplate htmlTemplate1;
        private SvgImageCollection svgImageCollection1;
    }
}

