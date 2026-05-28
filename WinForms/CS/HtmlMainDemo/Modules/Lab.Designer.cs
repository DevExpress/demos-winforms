
namespace DevExpress.HTML.Demos {
    partial class Lab {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab));
            this.htmlCodeViewer = new DevExpress.XtraEditors.Internal.HtmlCodeViewer();
            this.cssCodeViewer = new DevExpress.XtraEditors.Internal.CssCodeViewer();
            this.htmlContentControl = new DevExpress.HTML.Demos.CustomHtmlControl();
            this.textEditPhone = new DevExpress.XtraEditors.TextEdit();
            this.textEditEmail = new DevExpress.XtraEditors.TextEdit();
            this.textEditFullName = new DevExpress.XtraEditors.TextEdit();
            this.textEditDisplayName = new DevExpress.XtraEditors.TextEdit();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.leftPanel = new DevExpress.XtraEditors.SidePanel();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.resetButton = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciResetButton = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.htmlCodeViewerLCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cssCodeViewerLCG = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).BeginInit();
            this.htmlContentControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDisplayName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResetButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlCodeViewerLCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cssCodeViewerLCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // htmlCodeViewer
            // 
            this.htmlCodeViewer.EnableIXtraResizeableControlInterfaceProxy = false;
            this.htmlCodeViewer.Location = new System.Drawing.Point(13, 36);
            this.htmlCodeViewer.Name = "htmlCodeViewer";
            this.htmlCodeViewer.Size = new System.Drawing.Size(471, 572);
            this.htmlCodeViewer.TabIndex = 1;
            // 
            // cssCodeViewer
            // 
            this.cssCodeViewer.EnableIXtraResizeableControlInterfaceProxy = false;
            this.cssCodeViewer.Location = new System.Drawing.Point(13, 36);
            this.cssCodeViewer.Name = "cssCodeViewer";
            this.cssCodeViewer.Size = new System.Drawing.Size(471, 572);
            this.cssCodeViewer.TabIndex = 2;
            // 
            // htmlContentControl
            // 
            this.htmlContentControl.Controls.Add(this.textEditPhone);
            this.htmlContentControl.Controls.Add(this.textEditEmail);
            this.htmlContentControl.Controls.Add(this.textEditFullName);
            this.htmlContentControl.Controls.Add(this.textEditDisplayName);
            this.htmlContentControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl.HtmlImages = this.svgImageCollection1;
            this.htmlContentControl.HtmlTemplate.Styles = resources.GetString("htmlContentControl.HtmlTemplate.Styles");
            this.htmlContentControl.HtmlTemplate.Template = resources.GetString("htmlContentControl.HtmlTemplate.Template");
            this.htmlContentControl.Location = new System.Drawing.Point(10, 10);
            this.htmlContentControl.Name = "htmlContentControl";
            this.htmlContentControl.Size = new System.Drawing.Size(539, 627);
            this.htmlContentControl.TabIndex = 0;
            // 
            // textEditPhone
            // 
            this.textEditPhone.EditValue = "(562) 559-5830";
            this.textEditPhone.Location = new System.Drawing.Point(291, 290);
            this.textEditPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditPhone.Name = "textEditPhone";
            this.textEditPhone.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditPhone.Properties.Appearance.Options.UseFont = true;
            this.textEditPhone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditPhone.Size = new System.Drawing.Size(201, 18);
            this.textEditPhone.TabIndex = 7;
            // 
            // textEditEmail
            // 
            this.textEditEmail.EditValue = "leahs@dx-email.com";
            this.textEditEmail.Location = new System.Drawing.Point(47, 290);
            this.textEditEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditEmail.Name = "textEditEmail";
            this.textEditEmail.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditEmail.Properties.Appearance.Options.UseFont = true;
            this.textEditEmail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditEmail.Size = new System.Drawing.Size(202, 18);
            this.textEditEmail.TabIndex = 6;
            // 
            // textEditFullName
            // 
            this.textEditFullName.EditValue = "Leah Simpson";
            this.textEditFullName.Location = new System.Drawing.Point(291, 181);
            this.textEditFullName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditFullName.Name = "textEditFullName";
            this.textEditFullName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditFullName.Properties.Appearance.Options.UseFont = true;
            this.textEditFullName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditFullName.Size = new System.Drawing.Size(201, 18);
            this.textEditFullName.TabIndex = 5;
            // 
            // textEditDisplayName
            // 
            this.textEditDisplayName.EditValue = "Leah Test Coordinator";
            this.textEditDisplayName.Location = new System.Drawing.Point(47, 181);
            this.textEditDisplayName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textEditDisplayName.Name = "textEditDisplayName";
            this.textEditDisplayName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEditDisplayName.Properties.Appearance.Options.UseFont = true;
            this.textEditDisplayName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.textEditDisplayName.Size = new System.Drawing.Size(202, 18);
            this.textEditDisplayName.TabIndex = 4;
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("employee", "image://svgimages/business objects/bo_lead.svg");
            this.svgImageCollection1.Add("phone", "image://svgimages/outlook inspired/glyph_phone.svg");
            this.svgImageCollection1.Add("contact", "image://svgimages/business objects/bo_contact.svg");
            this.svgImageCollection1.Add("message", "image://svgimages/outlook inspired/glyph_message.svg");
            this.svgImageCollection1.Add("signin", "image://svgimages/scheduling/timezones.svg");
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.layoutControl1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.leftPanel.Location = new System.Drawing.Point(559, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(498, 647);
            this.leftPanel.TabIndex = 2;
            this.leftPanel.Text = "sidePanel1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.htmlCodeViewer);
            this.layoutControl1.Controls.Add(this.cssCodeViewer);
            this.layoutControl1.Controls.Add(this.resetButton);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(1, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1172, 221, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(497, 647);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 613);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(473, 22);
            this.resetButton.StyleController = this.layoutControl1;
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset To Default";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciResetButton,
            this.tabbedControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(497, 647);
            this.Root.TextVisible = false;
            // 
            // lciResetButton
            // 
            this.lciResetButton.Control = this.resetButton;
            this.lciResetButton.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lciResetButton.CustomizationFormText = "lciResetButton";
            this.lciResetButton.Location = new System.Drawing.Point(0, 601);
            this.lciResetButton.Name = "lciResetButton";
            this.lciResetButton.Size = new System.Drawing.Size(477, 26);
            this.lciResetButton.TextVisible = false;
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.tabbedControlGroup1.Name = "tabbedControlGroup1";
            this.tabbedControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.tabbedControlGroup1.SelectedTabPage = this.htmlCodeViewerLCG;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(477, 601);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.htmlCodeViewerLCG,
            this.cssCodeViewerLCG});
            // 
            // htmlCodeViewerLCG
            // 
            this.htmlCodeViewerLCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.htmlCodeViewerLCG.Location = new System.Drawing.Point(0, 0);
            this.htmlCodeViewerLCG.Name = "htmlCodeViewerLCG";
            this.htmlCodeViewerLCG.Size = new System.Drawing.Size(471, 572);
            this.htmlCodeViewerLCG.Text = "HTML";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.htmlCodeViewer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem1.Size = new System.Drawing.Size(471, 572);
            this.layoutControlItem1.TextVisible = false;
            // 
            // cssCodeViewerLCG
            // 
            this.cssCodeViewerLCG.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.cssCodeViewerLCG.Location = new System.Drawing.Point(0, 0);
            this.cssCodeViewerLCG.Name = "cssCodeViewerLCG";
            this.cssCodeViewerLCG.Size = new System.Drawing.Size(471, 572);
            this.cssCodeViewerLCG.Text = "CSS";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cssCodeViewer;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.layoutControlItem2.Size = new System.Drawing.Size(471, 572);
            this.layoutControlItem2.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.htmlContentControl);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(10);
            this.panelControl1.Size = new System.Drawing.Size(559, 647);
            this.panelControl1.TabIndex = 8;
            // 
            // Lab
            // 
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.leftPanel);
            this.Name = "Lab";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Size = new System.Drawing.Size(1057, 647);
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl)).EndInit();
            this.htmlContentControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditPhone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditFullName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDisplayName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.leftPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResetButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htmlCodeViewerLCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cssCodeViewerLCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private XtraEditors.Internal.HtmlCodeViewer htmlCodeViewer;
        private XtraEditors.Internal.CssCodeViewer cssCodeViewer;
        private CustomHtmlControl htmlContentControl;
        private XtraEditors.SidePanel leftPanel;
        private System.Windows.Forms.Timer delayTimer;
        private XtraEditors.TextEdit textEditPhone;
        private XtraEditors.TextEdit textEditEmail;
        private XtraEditors.TextEdit textEditFullName;
        private XtraEditors.TextEdit textEditDisplayName;
        private Utils.SvgImageCollection svgImageCollection1;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraEditors.SimpleButton resetButton;
        private XtraLayout.LayoutControlItem lciResetButton;
        private XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private XtraLayout.LayoutControlGroup htmlCodeViewerLCG;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlGroup cssCodeViewerLCG;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraEditors.PanelControl panelControl1;
    }
}
