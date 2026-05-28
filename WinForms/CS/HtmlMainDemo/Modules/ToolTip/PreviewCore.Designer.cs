namespace DevExpress.HTML.Demos {
    partial class PreviewCore {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreviewCore));
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.templateViewer = new DevExpress.HTML.Demos.ToolTipTemplateViewer();
            this.htmlContentControl1 = new DevExpress.XtraEditors.HtmlContentControl();
            this.bottomPanel = new DevExpress.Utils.Layout.TablePanel();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.propertiesPanel = new DevExpress.Utils.Layout.TablePanel();
            this.previewCoreProperties1 = new DevExpress.HTML.Demos.PreviewCoreControllerProperties();
            this.hostToolTip = new DevExpress.XtraEditors.XtraUserControl();
            this.htmlImageCollection = new DevExpress.Utils.SvgImageCollection(this.components);
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).BeginInit();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesPanel)).BeginInit();
            this.propertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlImageCollection)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.labelControl1);
            this.sidePanel1.Controls.Add(this.templateViewer);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(269, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(450, 467);
            this.sidePanel1.TabIndex = 0;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(0, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Visible = false;
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(1, 0);
            this.templateViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(449, 467);
            this.templateViewer.TabIndex = 0;
            // 
            // htmlContentControl1
            // 
            this.bottomPanel.SetColumn(this.htmlContentControl1, 1);
            this.htmlContentControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.htmlContentControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.htmlContentControl1.HtmlTemplate.Styles = resources.GetString("htmlContentControl1.HtmlTemplate.Styles");
            this.htmlContentControl1.HtmlTemplate.Template = resources.GetString("htmlContentControl1.HtmlTemplate.Template");
            this.htmlContentControl1.Location = new System.Drawing.Point(77, 2);
            this.htmlContentControl1.Margin = new System.Windows.Forms.Padding(2);
            this.htmlContentControl1.Name = "htmlContentControl1";
            this.bottomPanel.SetRow(this.htmlContentControl1, 0);
            this.htmlContentControl1.Size = new System.Drawing.Size(116, 66);
            this.htmlContentControl1.TabIndex = 1;
            this.htmlContentControl1.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.False;
            // 
            // bottomPanel
            // 
            this.bottomPanel.AutoSize = true;
            this.bottomPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 120F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.bottomPanel.Controls.Add(this.htmlContentControl1);
            this.bottomPanel.Controls.Add(this.separatorControl1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 204);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 70F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 1F)});
            this.bottomPanel.Size = new System.Drawing.Size(269, 101);
            this.bottomPanel.TabIndex = 1;
            // 
            // separatorControl1
            // 
            this.bottomPanel.SetColumn(this.separatorControl1, 0);
            this.bottomPanel.SetColumnSpan(this.separatorControl1, 3);
            this.separatorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.separatorControl1.Location = new System.Drawing.Point(0, 100);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.bottomPanel.SetRow(this.separatorControl1, 2);
            this.separatorControl1.Size = new System.Drawing.Size(270, 1);
            this.separatorControl1.TabIndex = 1;
            // 
            // propertiesPanel
            // 
            this.propertiesPanel.AutoSize = true;
            this.propertiesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.propertiesPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F)});
            this.propertiesPanel.Controls.Add(this.previewCoreProperties1);
            this.propertiesPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.propertiesPanel.Location = new System.Drawing.Point(0, 305);
            this.propertiesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.propertiesPanel.MinimumSize = new System.Drawing.Size(0, 100);
            this.propertiesPanel.Name = "propertiesPanel";
            this.propertiesPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F)});
            this.propertiesPanel.Size = new System.Drawing.Size(269, 162);
            this.propertiesPanel.TabIndex = 3;
            // 
            // previewCoreProperties1
            // 
            this.previewCoreProperties1.AutoSize = true;
            this.previewCoreProperties1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.propertiesPanel.SetColumn(this.previewCoreProperties1, 1);
            this.previewCoreProperties1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewCoreProperties1.Location = new System.Drawing.Point(139, 4);
            this.previewCoreProperties1.Margin = new System.Windows.Forms.Padding(4);
            this.previewCoreProperties1.Name = "previewCoreProperties1";
            this.propertiesPanel.SetRow(this.previewCoreProperties1, 0);
            this.previewCoreProperties1.Size = new System.Drawing.Size(127, 154);
            this.previewCoreProperties1.TabIndex = 0;
            // 
            // hostToolTip
            // 
            this.hostToolTip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostToolTip.Location = new System.Drawing.Point(0, 0);
            this.hostToolTip.Margin = new System.Windows.Forms.Padding(0);
            this.hostToolTip.Name = "hostToolTip";
            this.hostToolTip.Size = new System.Drawing.Size(269, 204);
            this.hostToolTip.TabIndex = 0;
            // 
            // PreviewCore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.hostToolTip);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.propertiesPanel);
            this.Controls.Add(this.sidePanel1);
            this.Name = "PreviewCore";
            this.Size = new System.Drawing.Size(719, 467);
            this.sidePanel1.ResumeLayout(false);
            this.sidePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlContentControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPanel)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertiesPanel)).EndInit();
            this.propertiesPanel.ResumeLayout(false);
            this.propertiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.htmlImageCollection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.SidePanel sidePanel1;
        private XtraEditors.XtraUserControl hostToolTip;
        private ToolTipTemplateViewer templateViewer;
        private Utils.Layout.TablePanel bottomPanel;
        private XtraEditors.SeparatorControl separatorControl1;
        private XtraEditors.LabelControl labelControl1;
        private Utils.Layout.TablePanel propertiesPanel;
        private PreviewCoreControllerProperties previewCoreProperties1;
        private Utils.SvgImageCollection htmlImageCollection;
        private XtraEditors.HtmlContentControl htmlContentControl1;
    }
}
