
using DevExpress.XtraEditors.Internal;

namespace DevExpress.HTML.Demos
{
    partial class TemplateCodeViewer
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cssViewer = new DevExpress.XtraEditors.Internal.CssCodeViewer();
            this.htmlViewer = new DevExpress.XtraEditors.Internal.HtmlCodeViewer();
            this.mainLayoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.resetButton = new DevExpress.XtraEditors.SimpleButton();
            this.tabControl = new DevExpress.XtraTab.XtraTabControl();
            this.htmlPage = new DevExpress.XtraTab.XtraTabPage();
            this.cssPage = new DevExpress.XtraTab.XtraTabPage();
            this.iceTemplates = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTemplate = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTabs = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResetButton = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).BeginInit();
            this.mainLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).BeginInit();
            this.tabControl.SuspendLayout();
            this.htmlPage.SuspendLayout();
            this.cssPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iceTemplates.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTabs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResetButton)).BeginInit();
            this.SuspendLayout();
            // 
            // cssViewer
            // 
            this.cssViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cssViewer.Location = new System.Drawing.Point(0, 0);
            this.cssViewer.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.cssViewer.Name = "cssViewer";
            this.cssViewer.Size = new System.Drawing.Size(412, 382);
            this.cssViewer.TabIndex = 1;
            this.cssViewer.CodeChanged += new System.EventHandler(this.cssViewer_CodeChanged);
            // 
            // htmlViewer
            // 
            this.htmlViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlViewer.Location = new System.Drawing.Point(0, 0);
            this.htmlViewer.Margin = new System.Windows.Forms.Padding(10, 5, 5, 5);
            this.htmlViewer.Name = "htmlViewer";
            this.htmlViewer.Size = new System.Drawing.Size(412, 382);
            this.htmlViewer.TabIndex = 0;
            this.htmlViewer.CodeChanged += new System.EventHandler(this.htmlViewer_CodeChanged);
            // 
            // mainLayoutControl
            // 
            this.mainLayoutControl.AllowCustomization = false;
            this.mainLayoutControl.Controls.Add(this.resetButton);
            this.mainLayoutControl.Controls.Add(this.tabControl);
            this.mainLayoutControl.Controls.Add(this.iceTemplates);
            this.mainLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutControl.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutControl.Name = "mainLayoutControl";
            this.mainLayoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(893, 435, 650, 400);
            this.mainLayoutControl.Root = this.Root;
            this.mainLayoutControl.Size = new System.Drawing.Size(438, 504);
            this.mainLayoutControl.TabIndex = 2;
            this.mainLayoutControl.Text = "layoutControl1";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(12, 470);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(414, 22);
            this.resetButton.StyleController = this.mainLayoutControl;
            this.resetButton.TabIndex = 6;
            this.resetButton.Text = "Reset to Default";
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // tabControl
            // 
            this.tabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tabControl.Location = new System.Drawing.Point(12, 59);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedTabPage = this.htmlPage;
            this.tabControl.Size = new System.Drawing.Size(414, 407);
            this.tabControl.TabIndex = 5;
            this.tabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.htmlPage,
            this.cssPage});
            // 
            // htmlPage
            // 
            this.htmlPage.Controls.Add(this.htmlViewer);
            this.htmlPage.Name = "htmlPage";
            this.htmlPage.Size = new System.Drawing.Size(412, 382);
            this.htmlPage.Text = "HTML";
            // 
            // cssPage
            // 
            this.cssPage.Controls.Add(this.cssViewer);
            this.cssPage.Name = "cssPage";
            this.cssPage.Size = new System.Drawing.Size(412, 382);
            this.cssPage.Text = "CSS";
            // 
            // iceTemplates
            // 
            this.iceTemplates.Location = new System.Drawing.Point(12, 27);
            this.iceTemplates.Name = "iceTemplates";
            this.iceTemplates.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.iceTemplates.Size = new System.Drawing.Size(414, 20);
            this.iceTemplates.StyleController = this.mainLayoutControl;
            this.iceTemplates.TabIndex = 4;
            this.iceTemplates.SelectedIndexChanged += new System.EventHandler(this.iceTemplates_SelectedIndexChanged);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTemplate,
            this.lciTabs,
            this.lciResetButton});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(438, 504);
            this.Root.TextVisible = false;
            // 
            // lciTemplate
            // 
            this.lciTemplate.Control = this.iceTemplates;
            this.lciTemplate.Location = new System.Drawing.Point(0, 0);
            this.lciTemplate.Name = "lciTemplate";
            this.lciTemplate.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 1, 10);
            this.lciTemplate.Size = new System.Drawing.Size(418, 47);
            this.lciTemplate.Text = "Template:";
            this.lciTemplate.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciTemplate.TextSize = new System.Drawing.Size(48, 13);
            // 
            // lciTabs
            // 
            this.lciTabs.Control = this.tabControl;
            this.lciTabs.CustomizationFormText = "lciTabs";
            this.lciTabs.Location = new System.Drawing.Point(0, 47);
            this.lciTabs.Name = "lciTabs";
            this.lciTabs.Size = new System.Drawing.Size(418, 411);
            this.lciTabs.TextSize = new System.Drawing.Size(0, 0);
            this.lciTabs.TextVisible = false;
            // 
            // lciResetButton
            // 
            this.lciResetButton.Control = this.resetButton;
            this.lciResetButton.CustomizationFormText = "lciResetButton";
            this.lciResetButton.Location = new System.Drawing.Point(0, 458);
            this.lciResetButton.Name = "lciResetButton";
            this.lciResetButton.Size = new System.Drawing.Size(418, 26);
            this.lciResetButton.TextSize = new System.Drawing.Size(0, 0);
            this.lciResetButton.TextVisible = false;
            // 
            // TemplateCodeViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainLayoutControl);
            this.Name = "TemplateCodeViewer";
            this.Size = new System.Drawing.Size(438, 504);
            ((System.ComponentModel.ISupportInitialize)(this.mainLayoutControl)).EndInit();
            this.mainLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabControl)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.htmlPage.ResumeLayout(false);
            this.cssPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iceTemplates.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTabs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResetButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CssCodeViewer cssViewer;
        private HtmlCodeViewer htmlViewer;
        private XtraLayout.LayoutControl mainLayoutControl;
        private XtraEditors.SimpleButton resetButton;
        private XtraTab.XtraTabControl tabControl;
        private XtraTab.XtraTabPage htmlPage;
        private XtraTab.XtraTabPage cssPage;
        protected XtraEditors.ImageComboBoxEdit iceTemplates;
        private XtraLayout.LayoutControlGroup Root;
        protected XtraLayout.LayoutControlItem lciTemplate;
        private XtraLayout.LayoutControlItem lciTabs;
        private XtraLayout.LayoutControlItem lciResetButton;
    }
}
