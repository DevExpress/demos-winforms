namespace DevExpress.XtraWizard.Demos {
    partial class frmMain {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.wizardControl1 = new DevExpress.XtraWizard.WizardControl();
            this.welcomeWizardPage1 = new DevExpress.XtraWizard.WelcomeWizardPage();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.wpPlayTune = new DevExpress.XtraWizard.WizardPage();
            this.lbcPlay = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sbPlay = new DevExpress.XtraEditors.SimpleButton();
            this.wpLongText = new DevExpress.XtraWizard.WizardPage();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ceLongText = new DevExpress.XtraEditors.CheckEdit();
            this.wpQuestion = new DevExpress.XtraWizard.WizardPage();
            this.ceNoAnswer = new DevExpress.XtraEditors.CheckEdit();
            this.ceYesAnswer = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.wpNoAnswer = new DevExpress.XtraWizard.WizardPage();
            this.lbcCancel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.wpProgress = new DevExpress.XtraWizard.WizardPage();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lbProgress = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.wpRobotTest = new DevExpress.XtraWizard.WizardPage();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.teRobotTest = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.completionWizardPage1 = new DevExpress.XtraWizard.CompletionWizardPage();
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).BeginInit();
            this.wizardControl1.SuspendLayout();
            this.welcomeWizardPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.wpPlayTune.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbcPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.wpLongText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceLongText.Properties)).BeginInit();
            this.wpQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceNoAnswer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceYesAnswer.Properties)).BeginInit();
            this.wpNoAnswer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            this.wpProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.wpRobotTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRobotTest.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // wizardControl1
            // 
            this.wizardControl1.AllowPagePadding = false;
            this.wizardControl1.Controls.Add(this.welcomeWizardPage1);
            this.wizardControl1.Controls.Add(this.wpPlayTune);
            this.wizardControl1.Controls.Add(this.wpLongText);
            this.wizardControl1.Controls.Add(this.wpQuestion);
            this.wizardControl1.Controls.Add(this.wpNoAnswer);
            this.wizardControl1.Controls.Add(this.wpProgress);
            this.wizardControl1.Controls.Add(this.wpRobotTest);
            this.wizardControl1.Controls.Add(this.completionWizardPage1);
            this.wizardControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wizardControl1.HeaderImageOptions.Image = global::DevExpress.XtraWizard.Demos.Properties.Resources.image_61x61;
            this.wizardControl1.ImageOptions.Image = global::DevExpress.XtraWizard.Demos.Properties.Resources.wizard_image;
            this.wizardControl1.ImageOptions.ImageWidth = 200;
            this.wizardControl1.Name = "wizardControl1";
            this.wizardControl1.Pages.AddRange(new DevExpress.XtraWizard.BaseWizardPage[] {
            this.welcomeWizardPage1,
            this.wpPlayTune,
            this.wpLongText,
            this.wpQuestion,
            this.wpNoAnswer,
            this.wpProgress,
            this.wpRobotTest,
            this.completionWizardPage1});
            this.wizardControl1.Size = new System.Drawing.Size(677, 432);
            this.wizardControl1.SelectedPageChanged += new DevExpress.XtraWizard.WizardPageChangedEventHandler(this.wizardControl1_SelectedPageChanged);
            this.wizardControl1.SelectedPageChanging += new DevExpress.XtraWizard.WizardPageChangingEventHandler(this.wizardControl1_SelectedPageChanging);
            this.wizardControl1.CancelClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_CancelClick);
            this.wizardControl1.FinishClick += new System.ComponentModel.CancelEventHandler(this.wizardControl1_FinishClick);
            this.wizardControl1.NextClick += new DevExpress.XtraWizard.WizardCommandButtonClickEventHandler(this.wizardControl1_NextClick);
            // 
            // welcomeWizardPage1
            // 
            this.welcomeWizardPage1.Controls.Add(this.pictureEdit2);
            this.welcomeWizardPage1.IntroductionText = "Thank you for your interest in the XtraWizard Suite. We hope you’ll have some fun" +
    " during the next few minutes and learn about our new product in the process.";
            this.welcomeWizardPage1.Name = "welcomeWizardPage1";
            this.welcomeWizardPage1.ProceedText = "To proceed with the tour, click Next.";
            this.welcomeWizardPage1.Size = new System.Drawing.Size(477, 293);
            this.welcomeWizardPage1.Text = "Welcome to the XtraWizard Product Features Tour";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit2.EditValue = global::DevExpress.XtraWizard.Demos.Properties.Resources.Have_fun_;
            this.pictureEdit2.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.AllowFocused = false;
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.pictureEdit2.Properties.ShowMenu = false;
            this.pictureEdit2.Size = new System.Drawing.Size(477, 293);
            this.pictureEdit2.TabIndex = 0;
            // 
            // wpPlayTune
            // 
            this.wpPlayTune.Controls.Add(this.lbcPlay);
            this.wpPlayTune.Controls.Add(this.panelControl3);
            this.wpPlayTune.DescriptionText = "To make this demo more entertaining, we would like to play a tune for you. Simply" +
    " choose your favorite track from the list below and click Play.";
            this.wpPlayTune.Name = "wpPlayTune";
            this.wpPlayTune.Padding = new System.Windows.Forms.Padding(16, 16, 16, 8);
            this.wpPlayTune.Size = new System.Drawing.Size(677, 321);
            this.wpPlayTune.Text = "Step 2 - Play a tune";
            // 
            // lbcPlay
            // 
            this.lbcPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbcPlay.Items.AddRange(new object[] {
            "Metallica - Enter Sandman",
            "Nirvana - Smells Like Teen Spirit",
            "Pet Shop Boys - West End Girls",
            "Run D.M.C. - Christmas in Hollis",
            "Spice Girls - Wannabe",
            "Backstreet Boys - Show Me the Meaning",
            "The Prodigy - Firestarter ",
            "The Beatles - Yellow Submarine",
            "The Rolling Stones - Angie",
            "Black Eyed Peas - Pump It",
            "Rihanna - Umbrella",
            "Linkin Park - From the Inside",
            "Madonna - Music",
            "Michael Jackson - Bad",
            "Kanye West - Stronger",
            "Gwen Stefani - 4 in the Morning"});
            this.lbcPlay.Location = new System.Drawing.Point(16, 16);
            this.lbcPlay.Name = "lbcPlay";
            this.lbcPlay.Size = new System.Drawing.Size(645, 260);
            this.lbcPlay.TabIndex = 0;
            this.lbcPlay.SelectedIndexChanged += new System.EventHandler(this.lbcPlay_SelectedIndexChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl3.Appearance.Options.UseBackColor = true;
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.sbPlay);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(16, 276);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(645, 37);
            this.panelControl3.TabIndex = 1;
            // 
            // sbPlay
            // 
            this.sbPlay.Enabled = false;
            this.sbPlay.Location = new System.Drawing.Point(271, 8);
            this.sbPlay.Name = "sbPlay";
            this.sbPlay.Size = new System.Drawing.Size(103, 24);
            this.sbPlay.TabIndex = 0;
            this.sbPlay.Text = "Play";
            this.sbPlay.Click += new System.EventHandler(this.sbPlay_Click);
            // 
            // wpLongText
            // 
            this.wpLongText.Controls.Add(this.memoEdit1);
            this.wpLongText.Controls.Add(this.panelControl1);
            this.wpLongText.DescriptionText = "Before proceeding, we want you to read and understand the following text, which i" +
    "s very long.";
            this.wpLongText.Name = "wpLongText";
            this.wpLongText.Padding = new System.Windows.Forms.Padding(16);
            this.wpLongText.Size = new System.Drawing.Size(677, 321);
            this.wpLongText.Text = "Step 3 – The Read Some Very Long Text step";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.EditValue = "";
            this.memoEdit1.Location = new System.Drawing.Point(16, 16);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.ReadOnly = true;
            this.memoEdit1.Size = new System.Drawing.Size(645, 258);
            this.memoEdit1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.ceLongText);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(16, 274);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(645, 31);
            this.panelControl1.TabIndex = 1;
            // 
            // ceLongText
            // 
            this.ceLongText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ceLongText.Location = new System.Drawing.Point(0, 11);
            this.ceLongText.Name = "ceLongText";
            this.ceLongText.Properties.Caption = "I have read and understand the very long text above. Maybe.";
            this.ceLongText.Size = new System.Drawing.Size(645, 20);
            this.ceLongText.TabIndex = 0;
            this.ceLongText.CheckedChanged += new System.EventHandler(this.ceLongText_CheckedChanged);
            // 
            // wpQuestion
            // 
            this.wpQuestion.Controls.Add(this.ceNoAnswer);
            this.wpQuestion.Controls.Add(this.ceYesAnswer);
            this.wpQuestion.Controls.Add(this.labelControl1);
            this.wpQuestion.DescriptionText = "";
            this.wpQuestion.Name = "wpQuestion";
            this.wpQuestion.Padding = new System.Windows.Forms.Padding(16);
            this.wpQuestion.Size = new System.Drawing.Size(677, 321);
            this.wpQuestion.Text = "Step 4 – Are  You Tired Yet?";
            // 
            // ceNoAnswer
            // 
            this.ceNoAnswer.EditValue = true;
            this.ceNoAnswer.Location = new System.Drawing.Point(58, 138);
            this.ceNoAnswer.Name = "ceNoAnswer";
            this.ceNoAnswer.Properties.Caption = "No, get me out of here.";
            this.ceNoAnswer.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceNoAnswer.Properties.RadioGroupIndex = 0;
            this.ceNoAnswer.Size = new System.Drawing.Size(208, 20);
            this.ceNoAnswer.TabIndex = 2;
            // 
            // ceYesAnswer
            // 
            this.ceYesAnswer.Location = new System.Drawing.Point(58, 100);
            this.ceYesAnswer.Name = "ceYesAnswer";
            this.ceYesAnswer.Properties.Caption = "Yes, sure.";
            this.ceYesAnswer.Properties.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.ceYesAnswer.Properties.RadioGroupIndex = 0;
            this.ceYesAnswer.Size = new System.Drawing.Size(159, 20);
            this.ceYesAnswer.TabIndex = 1;
            this.ceYesAnswer.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(16, 16);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(645, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Do you really want to proceed with the XtraWizard tour even after we made you rea" +
    "d that much text?";
            // 
            // wpNoAnswer
            // 
            this.wpNoAnswer.Controls.Add(this.lbcCancel);
            this.wpNoAnswer.Controls.Add(this.labelControl2);
            this.wpNoAnswer.Controls.Add(this.pictureEdit3);
            this.wpNoAnswer.DescriptionText = "";
            this.wpNoAnswer.Name = "wpNoAnswer";
            this.wpNoAnswer.Size = new System.Drawing.Size(677, 321);
            this.wpNoAnswer.Text = "Not so Fast!";
            // 
            // lbcCancel
            // 
            this.lbcCancel.Location = new System.Drawing.Point(16, 290);
            this.lbcCancel.Name = "lbcCancel";
            this.lbcCancel.Size = new System.Drawing.Size(278, 13);
            this.lbcCancel.TabIndex = 1;
            this.lbcCancel.Text = "If you really, really, really want to quit, just press Cancel.";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl2.Location = new System.Drawing.Point(16, 16);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(613, 26);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ha! Did you really think we would let you out so easy? No way! Please press Next " +
    "to continue. You will navigate through just a few more frames, we promise…";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureEdit3.EditValue = global::DevExpress.XtraWizard.Demos.Properties.Resources.Not_so_fast_;
            this.pictureEdit3.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.AllowFocused = false;
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.PictureAlignment = System.Drawing.ContentAlignment.BottomRight;
            this.pictureEdit3.Properties.ShowMenu = false;
            this.pictureEdit3.Size = new System.Drawing.Size(677, 321);
            this.pictureEdit3.TabIndex = 2;
            // 
            // wpProgress
            // 
            this.wpProgress.Controls.Add(this.progressBarControl1);
            this.wpProgress.Controls.Add(this.lbProgress);
            this.wpProgress.Controls.Add(this.labelControl4);
            this.wpProgress.DescriptionText = "";
            this.wpProgress.Name = "wpProgress";
            this.wpProgress.Padding = new System.Windows.Forms.Padding(16);
            this.wpProgress.Size = new System.Drawing.Size(677, 321);
            this.wpProgress.Text = "Step 5 – Time-consuming Operation";
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(81, 137);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(515, 18);
            this.progressBarControl1.TabIndex = 2;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.lbProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbProgress.Location = new System.Drawing.Point(16, 292);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(645, 13);
            this.lbProgress.TabIndex = 1;
            this.lbProgress.Text = "Thanks for your patience. To proceed, click Next.";
            this.lbProgress.Visible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl4.Location = new System.Drawing.Point(16, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(645, 26);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "To keep you with us just for a little bit longer, we are performing an important " +
    "time-consuming operation. See – you can\'t proceed until it\'s completed!";
            // 
            // wpRobotTest
            // 
            this.wpRobotTest.AllowBack = false;
            this.wpRobotTest.Controls.Add(this.panelControl2);
            this.wpRobotTest.Controls.Add(this.labelControl6);
            this.wpRobotTest.DescriptionText = "";
            this.wpRobotTest.Name = "wpRobotTest";
            this.wpRobotTest.Padding = new System.Windows.Forms.Padding(16);
            this.wpRobotTest.Size = new System.Drawing.Size(677, 321);
            this.wpRobotTest.Text = "Step 6 - Are You a Robot?";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl2.Controls.Add(this.pictureEdit1);
            this.panelControl2.Controls.Add(this.teRobotTest);
            this.panelControl2.Location = new System.Drawing.Point(130, 78);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(416, 167);
            this.panelControl2.TabIndex = 2;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::DevExpress.XtraWizard.Demos.Properties.Resources.devexpress123;
            this.pictureEdit1.Location = new System.Drawing.Point(65, 23);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Size = new System.Drawing.Size(287, 83);
            this.pictureEdit1.TabIndex = 2;
            // 
            // teRobotTest
            // 
            this.teRobotTest.Location = new System.Drawing.Point(65, 119);
            this.teRobotTest.Name = "teRobotTest";
            this.teRobotTest.Size = new System.Drawing.Size(287, 20);
            this.teRobotTest.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl6.Location = new System.Drawing.Point(16, 16);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(645, 13);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "To prove that you are a human, and not a spam bot, please enter the characters th" +
    "at you see in the image and press Next.";
            // 
            // completionWizardPage1
            // 
            this.completionWizardPage1.Name = "completionWizardPage1";
            this.completionWizardPage1.Size = new System.Drawing.Size(477, 316);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 432);
            this.Controls.Add(this.wizardControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmMain.IconOptions.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinForms Wizard Control - Wizard 97 Style";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.wizardControl1)).EndInit();
            this.wizardControl1.ResumeLayout(false);
            this.welcomeWizardPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.wpPlayTune.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbcPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.wpLongText.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceLongText.Properties)).EndInit();
            this.wpQuestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceNoAnswer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceYesAnswer.Properties)).EndInit();
            this.wpNoAnswer.ResumeLayout(false);
            this.wpNoAnswer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            this.wpProgress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.wpRobotTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teRobotTest.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraWizard.WizardControl wizardControl1;
        private DevExpress.XtraWizard.WelcomeWizardPage welcomeWizardPage1;
        private DevExpress.XtraWizard.WizardPage wpLongText;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraWizard.CompletionWizardPage completionWizardPage1;
        private DevExpress.XtraWizard.WizardPage wpQuestion;
        private DevExpress.XtraWizard.WizardPage wpNoAnswer;
        private DevExpress.XtraWizard.WizardPage wpProgress;
        private DevExpress.XtraWizard.WizardPage wpRobotTest;
        private DevExpress.XtraEditors.CheckEdit ceLongText;
        private DevExpress.XtraEditors.CheckEdit ceNoAnswer;
        private DevExpress.XtraEditors.CheckEdit ceYesAnswer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lbcCancel;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lbProgress;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit teRobotTest;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraWizard.WizardPage wpPlayTune;
        private DevExpress.XtraEditors.ListBoxControl lbcPlay;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton sbPlay;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
    }
}

