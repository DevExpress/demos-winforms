namespace DevExpress.XtraLayout.Demos.Modules.XtraLayoutPanel {
    partial class LoginView {
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
            this.stackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.labelCaption = new DevExpress.XtraEditors.LabelControl();
            this.labelLogin = new DevExpress.XtraEditors.LabelControl();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelPassword = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.linkLostPassword = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.buttonStackPanel = new DevExpress.Utils.Layout.StackPanel();
            this.btnSignIn = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogIn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).BeginInit();
            this.stackPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).BeginInit();
            this.buttonStackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // stackPanel
            // 
            this.stackPanel.Controls.Add(this.labelCaption);
            this.stackPanel.Controls.Add(this.labelLogin);
            this.stackPanel.Controls.Add(this.teLogin);
            this.stackPanel.Controls.Add(this.labelPassword);
            this.stackPanel.Controls.Add(this.tePassword);
            this.stackPanel.Controls.Add(this.linkLostPassword);
            this.stackPanel.Controls.Add(this.buttonStackPanel);
            this.stackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stackPanel.LayoutDirection = DevExpress.Utils.Layout.StackPanelLayoutDirection.TopDown;
            this.stackPanel.Location = new System.Drawing.Point(0, 0);
            this.stackPanel.Name = "stackPanel";
            this.stackPanel.Size = new System.Drawing.Size(363, 369);
            this.stackPanel.TabIndex = 0;
            this.stackPanel.UseSkinIndents = true;
            // 
            // labelCaption
            // 
            this.labelCaption.Appearance.FontSizeDelta = 8;
            this.labelCaption.Appearance.Options.UseFont = true;
            this.labelCaption.Location = new System.Drawing.Point(155, 12);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(52, 27);
            this.labelCaption.TabIndex = 0;
            this.labelCaption.Text = "Login";
            // 
            // labelLogin
            // 
            this.labelLogin.Appearance.FontSizeDelta = 2;
            this.labelLogin.Appearance.Options.UseFont = true;
            this.labelLogin.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelLogin.Location = new System.Drawing.Point(74, 43);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(214, 17);
            this.labelLogin.TabIndex = 1;
            this.labelLogin.Text = "Login";
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(74, 64);
            this.teLogin.Name = "teLogin";
            this.teLogin.Properties.Appearance.FontSizeDelta = 4;
            this.teLogin.Properties.Appearance.Options.UseFont = true;
            this.teLogin.Properties.UseSystemPasswordChar = true;
            this.teLogin.Size = new System.Drawing.Size(214, 26);
            this.teLogin.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.Appearance.FontSizeDelta = 2;
            this.labelPassword.Appearance.Options.UseFont = true;
            this.labelPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelPassword.Location = new System.Drawing.Point(74, 94);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(214, 17);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(74, 115);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.Appearance.FontSizeDelta = 4;
            this.tePassword.Properties.Appearance.Options.UseFont = true;
            this.tePassword.Properties.UseSystemPasswordChar = true;
            this.tePassword.Size = new System.Drawing.Size(214, 26);
            this.tePassword.TabIndex = 4;
            // 
            // linkLostPassword
            // 
            this.linkLostPassword.Appearance.FontSizeDelta = 1;
            this.linkLostPassword.Appearance.Options.UseFont = true;
            this.linkLostPassword.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.linkLostPassword.Location = new System.Drawing.Point(74, 145);
            this.linkLostPassword.Name = "linkLostPassword";
            this.linkLostPassword.Size = new System.Drawing.Size(214, 14);
            this.linkLostPassword.TabIndex = 5;
            this.linkLostPassword.Text = "Lost your Password?";
            // 
            // buttonStackPanel
            // 
            this.buttonStackPanel.Controls.Add(this.btnSignIn);
            this.buttonStackPanel.Controls.Add(this.btnLogIn);
            this.buttonStackPanel.Location = new System.Drawing.Point(61, 163);
            this.buttonStackPanel.Name = "buttonStackPanel";
            this.buttonStackPanel.Size = new System.Drawing.Size(240, 49);
            this.buttonStackPanel.TabIndex = 6;
            this.buttonStackPanel.UseSkinIndents = true;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(13, 11);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(105, 26);
            this.buttonStackPanel.SetStretched(this.btnSignIn, true);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign In";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(122, 11);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(105, 26);
            this.buttonStackPanel.SetStretched(this.btnLogIn, true);
            this.btnLogIn.TabIndex = 1;
            this.btnLogIn.Text = "Log In";
            // 
            // LoginView
            // 
            this.ClientSize = new System.Drawing.Size(363, 369);
            this.Controls.Add(this.stackPanel);
            this.Name = "LoginView";
            ((System.ComponentModel.ISupportInitialize)(this.stackPanel)).EndInit();
            this.stackPanel.ResumeLayout(false);
            this.stackPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonStackPanel)).EndInit();
            this.buttonStackPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.StackPanel stackPanel;
        private DevExpress.XtraEditors.LabelControl labelCaption;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.HyperlinkLabelControl linkLostPassword;
        private XtraEditors.LabelControl labelLogin;
        private XtraEditors.LabelControl labelPassword;
        private XtraEditors.SimpleButton btnSignIn;
        private DevExpress.Utils.Layout.StackPanel buttonStackPanel;
        private XtraEditors.SimpleButton btnLogIn;
    }
}
