namespace DevExpress.XtraPivotGrid.Demos.Modules {
    partial class frmSQLConnector {
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
            this.pnlButtons = new DevExpress.XtraEditors.PanelControl();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.sbGenerateDB = new DevExpress.XtraEditors.SimpleButton();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            this.sbTestConfiguration = new DevExpress.XtraEditors.SimpleButton();
            this.lblDBName = new DevExpress.XtraEditors.LabelControl();
            this.lbRecords = new DevExpress.XtraEditors.LabelControl();
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            this.seRecordCount = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.teServer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seRecordCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlButtons.Controls.Add(this.progressBarControl1);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(8, 203);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(529, 10);
            this.pnlButtons.TabIndex = 1;
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarControl1.Location = new System.Drawing.Point(0, 0);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Maximum = 99;
            this.progressBarControl1.Size = new System.Drawing.Size(529, 10);
            this.progressBarControl1.TabIndex = 0;
            // 
            // sbGenerateDB
            // 
            this.sbGenerateDB.Location = new System.Drawing.Point(291, 130);
            this.sbGenerateDB.Name = "sbGenerateDB";
            this.sbGenerateDB.Size = new System.Drawing.Size(219, 25);
            this.sbGenerateDB.TabIndex = 10;
            this.sbGenerateDB.Text = "Generate Table and ";
            this.sbGenerateDB.Click += new System.EventHandler(this.sbGenerateDB_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMain.Controls.Add(this.sbTestConfiguration);
            this.pnlMain.Controls.Add(this.lblDBName);
            this.pnlMain.Controls.Add(this.lbRecords);
            this.pnlMain.Controls.Add(this.sbExit);
            this.pnlMain.Controls.Add(this.seRecordCount);
            this.pnlMain.Controls.Add(this.labelControl6);
            this.pnlMain.Controls.Add(this.sbGenerateDB);
            this.pnlMain.Controls.Add(this.tePassword);
            this.pnlMain.Controls.Add(this.teLogin);
            this.pnlMain.Controls.Add(this.labelControl5);
            this.pnlMain.Controls.Add(this.labelControl4);
            this.pnlMain.Controls.Add(this.radioGroup1);
            this.pnlMain.Controls.Add(this.labelControl3);
            this.pnlMain.Controls.Add(this.teServer);
            this.pnlMain.Controls.Add(this.labelControl2);
            this.pnlMain.Controls.Add(this.labelControl1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(8, 8);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(529, 195);
            this.pnlMain.TabIndex = 2;
            // 
            // sbTestConfiguration
            // 
            this.sbTestConfiguration.Location = new System.Drawing.Point(291, 104);
            this.sbTestConfiguration.Name = "sbTestConfiguration";
            this.sbTestConfiguration.Size = new System.Drawing.Size(219, 23);
            this.sbTestConfiguration.TabIndex = 26;
            this.sbTestConfiguration.Text = "Test Configuration";
            this.sbTestConfiguration.Click += new System.EventHandler(this.sbTestConfiguration_Click);
            // 
            // lblDBName
            // 
            this.lblDBName.Location = new System.Drawing.Point(85, 43);
            this.lblDBName.Name = "lblDBName";
            this.lblDBName.Size = new System.Drawing.Size(56, 13);
            this.lblDBName.TabIndex = 24;
            this.lblDBName.Text = "<DBName>";
            // 
            // lbRecords
            // 
            this.lbRecords.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRecords.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRecords.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lbRecords.Location = new System.Drawing.Point(291, 17);
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.Size = new System.Drawing.Size(219, 57);
            this.lbRecords.TabIndex = 23;
            // 
            // sbExit
            // 
            this.sbExit.Location = new System.Drawing.Point(291, 158);
            this.sbExit.Name = "sbExit";
            this.sbExit.Size = new System.Drawing.Size(219, 25);
            this.sbExit.TabIndex = 12;
            this.sbExit.Text = "Cancel";
            this.sbExit.Click += new System.EventHandler(this.sbExit_Click);
            // 
            // seRecordCount
            // 
            this.seRecordCount.EditValue = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.seRecordCount.Location = new System.Drawing.Point(365, 80);
            this.seRecordCount.Name = "seRecordCount";
            this.seRecordCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seRecordCount.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seRecordCount.Properties.IsFloatValue = false;
            this.seRecordCount.Properties.Mask.EditMask = "n0";
            this.seRecordCount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.seRecordCount.Properties.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.seRecordCount.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seRecordCount.Size = new System.Drawing.Size(145, 20);
            this.seRecordCount.TabIndex = 5;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(291, 83);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(68, 13);
            this.labelControl6.TabIndex = 22;
            this.labelControl6.Text = "Record count:";
            // 
            // tePassword
            // 
            this.tePassword.Enabled = false;
            this.tePassword.Location = new System.Drawing.Point(85, 163);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(168, 20);
            this.tePassword.TabIndex = 4;
            // 
            // teLogin
            // 
            this.teLogin.EditValue = "sa";
            this.teLogin.Enabled = false;
            this.teLogin.Location = new System.Drawing.Point(85, 139);
            this.teLogin.Name = "teLogin";
            this.teLogin.Size = new System.Drawing.Size(168, 20);
            this.teLogin.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(21, 166);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(50, 13);
            this.labelControl5.TabIndex = 21;
            this.labelControl5.Text = "Password:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(21, 142);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(58, 13);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "Login name:";
            // 
            // radioGroup1
            // 
            this.radioGroup1.EditValue = 0;
            this.radioGroup1.Location = new System.Drawing.Point(21, 83);
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(0, "Windows authentication"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(1, "SQL Server authentication")});
            this.radioGroup1.Size = new System.Drawing.Size(232, 48);
            this.radioGroup1.TabIndex = 2;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(21, 67);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Connect using:";
            // 
            // teServer
            // 
            this.teServer.EditValue = "(local)";
            this.teServer.Location = new System.Drawing.Point(85, 14);
            this.teServer.Name = "teServer";
            this.teServer.Size = new System.Drawing.Size(168, 20);
            this.teServer.TabIndex = 0;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 17);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "SQL Server:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 14;
            this.labelControl1.Text = "Database:";
            // 
            // frmSQLConnector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 221);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSQLConnector";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Data Source Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.pnlButtons)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seRecordCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl pnlButtons;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.SimpleButton sbGenerateDB;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit teServer;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SpinEdit seRecordCount;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lbRecords;
        private DevExpress.XtraEditors.LabelControl lblDBName;
        private DevExpress.XtraEditors.SimpleButton sbTestConfiguration;
    }
}
