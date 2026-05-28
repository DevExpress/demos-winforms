using DevExpress.DXperience.Demos;

namespace DevExpress.XtraGrid.Demos {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSQLConnector));
            this.npMain = new DevExpress.DXperience.Demos.DescriptionLabel();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.sbExit = new DevExpress.XtraEditors.SimpleButton();
            this.sbAddRecords = new DevExpress.XtraEditors.SimpleButton();
            this.lbRecords = new DevExpress.XtraEditors.LabelControl();
            this.seRecordCount = new DevExpress.XtraEditors.SpinEdit();
            this.sbGenerateDB = new DevExpress.XtraEditors.SimpleButton();
            this.teServer = new DevExpress.XtraEditors.TextEdit();
            this.cbDatabase = new DevExpress.XtraEditors.ComboBoxEdit();
            this.radioGroup1 = new DevExpress.XtraEditors.RadioGroup();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.pnlMain = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seRecordCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).BeginInit();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // npMain
            // 
            resources.ApplyResources(this.npMain, "npMain");
            this.npMain.Name = "npMain";
            // 
            // progressBarControl1
            // 
            resources.ApplyResources(this.progressBarControl1, "progressBarControl1");
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Properties.Maximum = 99;
            this.progressBarControl1.StyleController = this.layoutControl1;
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowCustomization = false;
            this.layoutControl1.Controls.Add(this.progressBarControl1);
            this.layoutControl1.Controls.Add(this.sbExit);
            this.layoutControl1.Controls.Add(this.sbAddRecords);
            this.layoutControl1.Controls.Add(this.lbRecords);
            this.layoutControl1.Controls.Add(this.seRecordCount);
            this.layoutControl1.Controls.Add(this.sbGenerateDB);
            this.layoutControl1.Controls.Add(this.teServer);
            this.layoutControl1.Controls.Add(this.cbDatabase);
            this.layoutControl1.Controls.Add(this.radioGroup1);
            this.layoutControl1.Controls.Add(this.tePassword);
            this.layoutControl1.Controls.Add(this.teLogin);
            resources.ApplyResources(this.layoutControl1, "layoutControl1");
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            // 
            // sbExit
            // 
            resources.ApplyResources(this.sbExit, "sbExit");
            this.sbExit.Name = "sbExit";
            this.sbExit.StyleController = this.layoutControl1;
            this.sbExit.Click += new System.EventHandler(this.sbExit_Click);
            // 
            // sbAddRecords
            // 
            resources.ApplyResources(this.sbAddRecords, "sbAddRecords");
            this.sbAddRecords.Name = "sbAddRecords";
            this.sbAddRecords.StyleController = this.layoutControl1;
            this.sbAddRecords.Click += new System.EventHandler(this.sbAddRecords_Click);
            // 
            // lbRecords
            // 
            this.lbRecords.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("lbRecords.Appearance.Font")));
            this.lbRecords.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lbRecords.Appearance.Options.UseFont = true;
            this.lbRecords.Appearance.Options.UseForeColor = true;
            this.lbRecords.Appearance.Options.UseTextOptions = true;
            this.lbRecords.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            resources.ApplyResources(this.lbRecords, "lbRecords");
            this.lbRecords.Name = "lbRecords";
            this.lbRecords.StyleController = this.layoutControl1;
            // 
            // seRecordCount
            // 
            resources.ApplyResources(this.seRecordCount, "seRecordCount");
            this.seRecordCount.Name = "seRecordCount";
            this.seRecordCount.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.seRecordCount.Properties.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seRecordCount.Properties.IsFloatValue = false;
            this.seRecordCount.Properties.Mask.EditMask = resources.GetString("seRecordCount.Properties.Mask.EditMask");
            this.seRecordCount.Properties.Mask.UseMaskAsDisplayFormat = ((bool)(resources.GetObject("seRecordCount.Properties.Mask.UseMaskAsDisplayFormat")));
            this.seRecordCount.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.seRecordCount.Properties.MinValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.seRecordCount.StyleController = this.layoutControl1;
            // 
            // sbGenerateDB
            // 
            resources.ApplyResources(this.sbGenerateDB, "sbGenerateDB");
            this.sbGenerateDB.Name = "sbGenerateDB";
            this.sbGenerateDB.StyleController = this.layoutControl1;
            this.sbGenerateDB.Click += new System.EventHandler(this.sbGenerateDB_Click);
            // 
            // teServer
            // 
            resources.ApplyResources(this.teServer, "teServer");
            this.teServer.Name = "teServer";
            this.teServer.StyleController = this.layoutControl1;
            this.teServer.EditValueChanged += new System.EventHandler(this.teServer_EditValueChanged);
            // 
            // cbDatabase
            // 
            resources.ApplyResources(this.cbDatabase, "cbDatabase");
            this.cbDatabase.Name = "cbDatabase";
            this.cbDatabase.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("cbDatabase.Properties.Buttons"))))});
            this.cbDatabase.Properties.ReadOnly = true;
            this.cbDatabase.StyleController = this.layoutControl1;
            this.cbDatabase.QueryPopUp += new System.ComponentModel.CancelEventHandler(this.cbDatabase_QueryPopUp);
            this.cbDatabase.EditValueChanged += new System.EventHandler(this.cbDatabase_EditValueChanged);
            // 
            // radioGroup1
            // 
            resources.ApplyResources(this.radioGroup1, "radioGroup1");
            this.radioGroup1.Name = "radioGroup1";
            this.radioGroup1.Properties.Columns = 1;
            this.radioGroup1.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items"))), resources.GetString("radioGroup1.Properties.Items1")),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((object)(resources.GetObject("radioGroup1.Properties.Items2"))), resources.GetString("radioGroup1.Properties.Items3"))});
            this.radioGroup1.StyleController = this.layoutControl1;
            this.radioGroup1.SelectedIndexChanged += new System.EventHandler(this.radioGroup1_SelectedIndexChanged);
            // 
            // tePassword
            // 
            resources.ApplyResources(this.tePassword, "tePassword");
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.StyleController = this.layoutControl1;
            // 
            // teLogin
            // 
            resources.ApplyResources(this.teLogin, "teLogin");
            this.teLogin.Name = "teLogin";
            this.teLogin.StyleController = this.layoutControl1;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9,
            this.emptySpaceItem2,
            this.layoutControlItem10,
            this.emptySpaceItem4,
            this.layoutControlItem11,
            this.emptySpaceItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(495, 404);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teServer;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(228, 24);
            resources.ApplyResources(this.layoutControlItem1, "layoutControlItem1");
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cbDatabase;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(228, 24);
            resources.ApplyResources(this.layoutControlItem2, "layoutControlItem2");
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.radioGroup1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(228, 88);
            resources.ApplyResources(this.layoutControlItem3, "layoutControlItem3");
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teLogin;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 136);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(228, 24);
            resources.ApplyResources(this.layoutControlItem4, "layoutControlItem4");
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tePassword;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 160);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(228, 24);
            resources.ApplyResources(this.layoutControlItem5, "layoutControlItem5");
            this.layoutControlItem5.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lbRecords;
            this.layoutControlItem6.Location = new System.Drawing.Point(238, 0);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(23, 25);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 8);
            this.layoutControlItem6.Size = new System.Drawing.Size(237, 48);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.seRecordCount;
            this.layoutControlItem7.Location = new System.Drawing.Point(238, 48);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(237, 40);
            resources.ApplyResources(this.layoutControlItem7, "layoutControlItem7");
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 13);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.sbGenerateDB;
            this.layoutControlItem8.Location = new System.Drawing.Point(238, 88);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(237, 26);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.sbAddRecords;
            this.layoutControlItem9.Location = new System.Drawing.Point(238, 114);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(237, 26);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(238, 140);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(237, 20);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.sbExit;
            this.layoutControlItem10.Location = new System.Drawing.Point(238, 160);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 184);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(475, 186);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.progressBarControl1;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 370);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(475, 14);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(228, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(10, 184);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // pnlMain
            // 
            this.pnlMain.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pnlMain.Controls.Add(this.layoutControl1);
            resources.ApplyResources(this.pnlMain, "pnlMain");
            this.pnlMain.Name = "pnlMain";
            // 
            // frmSQLConnector
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.npMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSQLConnector";
            this.ShowInTaskbar = false;
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seRecordCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbDatabase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radioGroup1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMain)).EndInit();
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DescriptionLabel npMain;
        private DevExpress.XtraEditors.PanelControl pnlMain;
        private DevExpress.XtraEditors.SimpleButton sbGenerateDB;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraEditors.RadioGroup radioGroup1;
        private DevExpress.XtraEditors.TextEdit teServer;
        private DevExpress.XtraEditors.ComboBoxEdit cbDatabase;
        private DevExpress.XtraEditors.SpinEdit seRecordCount;
        private DevExpress.XtraEditors.SimpleButton sbExit;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.SimpleButton sbAddRecords;
        private DevExpress.XtraEditors.LabelControl lbRecords;
        private XtraLayout.LayoutControl layoutControl1;
        private XtraLayout.LayoutControlGroup Root;
        private XtraLayout.LayoutControlItem layoutControlItem1;
        private XtraLayout.LayoutControlItem layoutControlItem2;
        private XtraLayout.LayoutControlItem layoutControlItem3;
        private XtraLayout.LayoutControlItem layoutControlItem4;
        private XtraLayout.LayoutControlItem layoutControlItem5;
        private XtraLayout.LayoutControlItem layoutControlItem6;
        private XtraLayout.LayoutControlItem layoutControlItem7;
        private XtraLayout.LayoutControlItem layoutControlItem8;
        private XtraLayout.LayoutControlItem layoutControlItem9;
        private XtraLayout.EmptySpaceItem emptySpaceItem2;
        private XtraLayout.LayoutControlItem layoutControlItem10;
        private XtraLayout.EmptySpaceItem emptySpaceItem4;
        private XtraLayout.LayoutControlItem layoutControlItem11;
        private XtraLayout.EmptySpaceItem emptySpaceItem1;
    }
}
