using DevExpress.Utils.Html;

namespace DevExpress.HTML.Demos {
    partial class ToolTipViewModule {
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
            this.tabPane = new DevExpress.XtraBars.Navigation.TabPane();
            this.pageToolTip = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.previewToolTipView1 = new DevExpress.HTML.Demos.PreviewToolTip();
            this.pageDialogBox = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.previewSuperToolTip1 = new DevExpress.HTML.Demos.PreviewSuperTip();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).BeginInit();
            this.tabPane.SuspendLayout();
            this.pageToolTip.SuspendLayout();
            this.pageDialogBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.pageToolTip);
            this.tabPane.Controls.Add(this.pageDialogBox);
            this.tabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane.Location = new System.Drawing.Point(0, 0);
            this.tabPane.Name = "tabPane";
            this.tabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageToolTip,
            this.pageDialogBox});
            this.tabPane.RegularSize = new System.Drawing.Size(901, 466);
            this.tabPane.SelectedPage = this.pageToolTip;
            this.tabPane.Size = new System.Drawing.Size(901, 466);
            this.tabPane.TabIndex = 13;
            this.tabPane.Text = "tabPane1";
            // 
            // pageToolTip
            // 
            this.pageToolTip.Caption = "ToolTip";
            this.pageToolTip.Controls.Add(this.previewToolTipView1);
            this.pageToolTip.Name = "pageToolTip";
            this.pageToolTip.Size = new System.Drawing.Size(901, 433);
            // 
            // previewToolTipView1
            // 
            this.previewToolTipView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewToolTipView1.Location = new System.Drawing.Point(0, 0);
            this.previewToolTipView1.Margin = new System.Windows.Forms.Padding(1);
            this.previewToolTipView1.Name = "previewToolTipView1";
            this.previewToolTipView1.Size = new System.Drawing.Size(901, 433);
            this.previewToolTipView1.TabIndex = 0;
            // 
            // pageDialogBox
            // 
            this.pageDialogBox.Caption = "SuperToolTip";
            this.pageDialogBox.Controls.Add(this.previewSuperToolTip1);
            this.pageDialogBox.Name = "pageDialogBox";
            this.pageDialogBox.Size = new System.Drawing.Size(900, 434);
            // 
            // previewSuperToolTip1
            // 
            this.previewSuperToolTip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.previewSuperToolTip1.Location = new System.Drawing.Point(0, 0);
            this.previewSuperToolTip1.Margin = new System.Windows.Forms.Padding(6);
            this.previewSuperToolTip1.Name = "previewSuperToolTip1";
            this.previewSuperToolTip1.Size = new System.Drawing.Size(900, 434);
            this.previewSuperToolTip1.TabIndex = 0;
            // 
            // ToolTipViewModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ToolTipViewModule";
            this.Size = new System.Drawing.Size(901, 466);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).EndInit();
            this.tabPane.ResumeLayout(false);
            this.pageToolTip.ResumeLayout(false);
            this.pageDialogBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.TabPane tabPane;
        private XtraBars.Navigation.TabNavigationPage pageToolTip;
        private XtraBars.Navigation.TabNavigationPage pageDialogBox;
        private PreviewToolTip previewToolTipView1;
        private PreviewSuperTip previewSuperToolTip1;
    }
}
