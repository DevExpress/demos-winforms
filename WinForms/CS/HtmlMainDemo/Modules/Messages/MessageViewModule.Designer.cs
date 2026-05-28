using DevExpress.Utils.Html;

namespace DevExpress.HTML.Demos {
    partial class MessageViewModule {
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
            this.pageMessageBox = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.viewMessageBox = new DevExpress.HTML.Demos.MessageBoxView();
            this.pageDialogBox = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.viewDialogBox = new DevExpress.HTML.Demos.DialogBoxView();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).BeginInit();
            this.tabPane.SuspendLayout();
            this.pageMessageBox.SuspendLayout();
            this.pageDialogBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.pageMessageBox);
            this.tabPane.Controls.Add(this.pageDialogBox);
            this.tabPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPane.Location = new System.Drawing.Point(0, 0);
            this.tabPane.Margin = new System.Windows.Forms.Padding(2);
            this.tabPane.Name = "tabPane";
            this.tabPane.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pageMessageBox,
            this.pageDialogBox});
            this.tabPane.RegularSize = new System.Drawing.Size(900, 467);
            this.tabPane.SelectedPage = this.pageMessageBox;
            this.tabPane.Size = new System.Drawing.Size(900, 467);
            this.tabPane.TabIndex = 13;
            this.tabPane.Text = "tabPane1";
            // 
            // pageMessageBox
            // 
            this.pageMessageBox.Caption = "MessageBox";
            this.pageMessageBox.Controls.Add(this.viewMessageBox);
            this.pageMessageBox.Margin = new System.Windows.Forms.Padding(2);
            this.pageMessageBox.Name = "pageMessageBox";
            this.pageMessageBox.Size = new System.Drawing.Size(900, 434);
            // 
            // viewMessageBox
            // 
            this.viewMessageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewMessageBox.Location = new System.Drawing.Point(0, 0);
            this.viewMessageBox.Margin = new System.Windows.Forms.Padding(1);
            this.viewMessageBox.Name = "viewMessageBox";
            this.viewMessageBox.Size = new System.Drawing.Size(900, 434);
            this.viewMessageBox.TabIndex = 0;
            // 
            // pageDialogBox
            // 
            this.pageDialogBox.Caption = "DialogBox";
            this.pageDialogBox.Controls.Add(this.viewDialogBox);
            this.pageDialogBox.Margin = new System.Windows.Forms.Padding(2);
            this.pageDialogBox.Name = "pageDialogBox";
            this.pageDialogBox.Size = new System.Drawing.Size(900, 430);
            // 
            // viewDialogBox
            // 
            this.viewDialogBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewDialogBox.Location = new System.Drawing.Point(0, 0);
            this.viewDialogBox.Margin = new System.Windows.Forms.Padding(1);
            this.viewDialogBox.Name = "viewDialogBox";
            this.viewDialogBox.Size = new System.Drawing.Size(900, 430);
            this.viewDialogBox.TabIndex = 0;
            // 
            // MessageViewModule
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabPane);
            this.Name = "MessageViewModule";
            this.Size = new System.Drawing.Size(900, 467);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane)).EndInit();
            this.tabPane.ResumeLayout(false);
            this.pageMessageBox.ResumeLayout(false);
            this.pageDialogBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private XtraBars.Navigation.TabPane tabPane;
        private XtraBars.Navigation.TabNavigationPage pageMessageBox;
        private XtraBars.Navigation.TabNavigationPage pageDialogBox;
        private MessageBoxView viewMessageBox;
        private DialogBoxView viewDialogBox;
    }
}
