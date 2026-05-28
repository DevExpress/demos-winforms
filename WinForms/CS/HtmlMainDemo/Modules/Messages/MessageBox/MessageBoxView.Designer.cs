using DevExpress.Utils.Html;

namespace DevExpress.HTML.Demos {
    partial class MessageBoxView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageBoxView));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.messageBoxResult = new DevExpress.HTML.Demos.MessageBoxResult();
            this.propertiesMessageBox = new DevExpress.HTML.Demos.MessageBoxProperties();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.hostMessage = new DevExpress.XtraEditors.XtraUserControl();
            this.buttonPanel = new DevExpress.Utils.Layout.TablePanel();
            this.showMessage = new DevExpress.XtraEditors.SimpleButton();
            this.sidePanel1 = new DevExpress.XtraEditors.SidePanel();
            this.templateViewer = new DevExpress.HTML.Demos.MessageBoxTemplateViewer();
            this.svgImages = new DevExpress.Utils.SvgImageCollection(this.components);
            this.htmlMessageTemplateCollection = new DevExpress.Utils.Html.HtmlTemplateCollection();
            this.confirmMessageTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            this.confirmMessageTemplate2 = new DevExpress.Utils.Html.HtmlTemplate();
            this.notificationMessageTemplate1 = new DevExpress.Utils.Html.HtmlTemplate();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.sidePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 5F)});
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.separatorControl1);
            this.tablePanel1.Controls.Add(this.hostMessage);
            this.tablePanel1.Controls.Add(this.buttonPanel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 1F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 170F)});
            this.tablePanel1.Size = new System.Drawing.Size(321, 471);
            this.tablePanel1.TabIndex = 14;
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel2.Controls.Add(this.messageBoxResult);
            this.tablePanel2.Controls.Add(this.propertiesMessageBox);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(3, 304);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 3);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel2.Size = new System.Drawing.Size(315, 164);
            this.tablePanel2.TabIndex = 12;
            // 
            // messageBoxResult
            // 
            this.tablePanel2.SetColumn(this.messageBoxResult, 1);
            this.messageBoxResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messageBoxResult.Location = new System.Drawing.Point(162, 4);
            this.messageBoxResult.Margin = new System.Windows.Forms.Padding(4);
            this.messageBoxResult.Name = "messageBoxResult";
            this.tablePanel2.SetRow(this.messageBoxResult, 0);
            this.messageBoxResult.Size = new System.Drawing.Size(150, 156);
            this.messageBoxResult.TabIndex = 1;
            // 
            // propertiesMessageBox
            // 
            this.tablePanel2.SetColumn(this.propertiesMessageBox, 0);
            this.propertiesMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertiesMessageBox.Location = new System.Drawing.Point(4, 4);
            this.propertiesMessageBox.Margin = new System.Windows.Forms.Padding(4);
            this.propertiesMessageBox.Name = "propertiesMessageBox";
            this.tablePanel2.SetRow(this.propertiesMessageBox, 0);
            this.propertiesMessageBox.Size = new System.Drawing.Size(150, 156);
            this.propertiesMessageBox.TabIndex = 0;
            // 
            // separatorControl1
            // 
            this.separatorControl1.AutoSizeMode = true;
            this.tablePanel1.SetColumn(this.separatorControl1, 0);
            this.separatorControl1.Location = new System.Drawing.Point(0, 300);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(0);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(0);
            this.tablePanel1.SetRow(this.separatorControl1, 2);
            this.separatorControl1.Size = new System.Drawing.Size(321, 1);
            this.separatorControl1.TabIndex = 11;
            // 
            // hostMessage
            // 
            this.tablePanel1.SetColumn(this.hostMessage, 0);
            this.hostMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hostMessage.Location = new System.Drawing.Point(0, 0);
            this.hostMessage.Margin = new System.Windows.Forms.Padding(0);
            this.hostMessage.Name = "hostMessage";
            this.tablePanel1.SetRow(this.hostMessage, 0);
            this.hostMessage.Size = new System.Drawing.Size(321, 200);
            this.hostMessage.TabIndex = 1;
            this.hostMessage.TabStop = false;
            // 
            // buttonPanel
            // 
            this.tablePanel1.SetColumn(this.buttonPanel, 0);
            this.buttonPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 180F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.buttonPanel.Controls.Add(this.showMessage);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPanel.Location = new System.Drawing.Point(2, 200);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.buttonPanel.Name = "buttonPanel";
            this.tablePanel1.SetRow(this.buttonPanel, 1);
            this.buttonPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 30F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.buttonPanel.Size = new System.Drawing.Size(317, 98);
            this.buttonPanel.TabIndex = 10;
            // 
            // showMessage
            // 
            this.buttonPanel.SetColumn(this.showMessage, 1);
            this.showMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showMessage.Location = new System.Drawing.Point(71, 2);
            this.showMessage.Margin = new System.Windows.Forms.Padding(2);
            this.showMessage.Name = "showMessage";
            this.buttonPanel.SetRow(this.showMessage, 0);
            this.showMessage.Size = new System.Drawing.Size(176, 26);
            this.showMessage.TabIndex = 6;
            this.showMessage.Text = "Show the MessageBox";
            this.showMessage.Click += new System.EventHandler(this.OnShowMessageBoxButtonClick);
            // 
            // sidePanel1
            // 
            this.sidePanel1.Controls.Add(this.templateViewer);
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(321, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(450, 471);
            this.sidePanel1.TabIndex = 13;
            this.sidePanel1.Text = "sidePanel1";
            // 
            // templateViewer
            // 
            this.templateViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateViewer.Location = new System.Drawing.Point(1, 0);
            this.templateViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.templateViewer.Name = "templateViewer";
            this.templateViewer.Size = new System.Drawing.Size(449, 471);
            this.templateViewer.TabIndex = 0;
            // 
            // svgImages
            // 
            this.svgImages.Add("close", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImages.close"))));
            // 
            // htmlMessageTemplateCollection
            // 
            this.htmlMessageTemplateCollection.AddRange(new DevExpress.Utils.Html.HtmlTemplate[] {
            this.confirmMessageTemplate1,
            this.confirmMessageTemplate2,
            this.notificationMessageTemplate1});
            // 
            // confirmMessageTemplate1
            // 
            this.confirmMessageTemplate1.Name = "confirmMessageTemplate1";
            this.confirmMessageTemplate1.PreviewType = typeof(DevExpress.XtraEditors.XtraMessageBox);
            this.confirmMessageTemplate1.Styles = resources.GetString("confirmMessageTemplate1.Styles");
            this.confirmMessageTemplate1.Tag = "Confirmation Message #1";
            this.confirmMessageTemplate1.Template = resources.GetString("confirmMessageTemplate1.Template");
            // 
            // confirmMessageTemplate2
            // 
            this.confirmMessageTemplate2.Name = "confirmMessageTemplate2";
            this.confirmMessageTemplate2.PreviewType = typeof(DevExpress.XtraEditors.XtraMessageBox);
            this.confirmMessageTemplate2.Styles = resources.GetString("confirmMessageTemplate2.Styles");
            this.confirmMessageTemplate2.Tag = "Confirmation Message #2";
            this.confirmMessageTemplate2.Template = resources.GetString("confirmMessageTemplate2.Template");
            // 
            // notificationMessageTemplate1
            // 
            this.notificationMessageTemplate1.Name = "notificationMessageTemplate1";
            this.notificationMessageTemplate1.PreviewType = typeof(DevExpress.XtraEditors.XtraMessageBox);
            this.notificationMessageTemplate1.Styles = resources.GetString("notificationMessageTemplate1.Styles");
            this.notificationMessageTemplate1.Tag = "Notification Message";
            this.notificationMessageTemplate1.Template = resources.GetString("notificationMessageTemplate1.Template");
            // 
            // MessageBoxView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tablePanel1);
            this.Controls.Add(this.sidePanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MessageBoxView";
            this.Size = new System.Drawing.Size(771, 471);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPanel)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.sidePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.svgImages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Utils.Layout.TablePanel tablePanel1;
        private Utils.Layout.TablePanel tablePanel2;
        private MessageBoxResult messageBoxResult;
        private MessageBoxProperties propertiesMessageBox;
        private XtraEditors.SeparatorControl separatorControl1;
        private XtraEditors.XtraUserControl hostMessage;
        private Utils.Layout.TablePanel buttonPanel;
        private XtraEditors.SimpleButton showMessage;
        private XtraEditors.SidePanel sidePanel1;
        private MessageBoxTemplateViewer templateViewer;
        private Utils.SvgImageCollection svgImages;
        private HtmlTemplateCollection htmlMessageTemplateCollection;
        private HtmlTemplate confirmMessageTemplate1;
        private HtmlTemplate confirmMessageTemplate2;
        private HtmlTemplate notificationMessageTemplate1;
    }
}
