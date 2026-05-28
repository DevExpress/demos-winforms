namespace DevExpress.VideoRent.Win.Forms {
    partial class frmCreateInitialDB {
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.notePanel = new DevExpress.Utils.Frames.NotePanel8_1();
            this.vbwRentsHistory = new DevExpress.VideoRent.Win.VisualBackgroundWorker();
            this.ceGenerateRentsHistory = new DevExpress.XtraEditors.CheckEdit();
            this.vbwCreatingDb = new DevExpress.VideoRent.Win.VisualBackgroundWorker();
            this.lciGenerateRentsHistory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciRentsHistory = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCreatingDB = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vbwRentsHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGenerateRentsHistory.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbwCreatingDb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGenerateRentsHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRentsHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCreatingDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.AllowCustomization = false;
            this.lcMain.AutoScroll = false;
            this.lcMain.Controls.Add(this.notePanel);
            this.lcMain.Controls.Add(this.vbwRentsHistory);
            this.lcMain.Controls.Add(this.ceGenerateRentsHistory);
            this.lcMain.Controls.Add(this.vbwCreatingDb);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.HiddenItems.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGenerateRentsHistory});
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(416, 138);
            this.lcMain.TabIndex = 1;
            this.lcMain.Text = "layoutControl1";
            // 
            // notePanel
            // 
            this.notePanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.notePanel.Location = new System.Drawing.Point(12, 12);
            this.notePanel.MaxRows = 10;
            this.notePanel.Name = "notePanel";
            this.notePanel.Size = new System.Drawing.Size(392, 50);
            this.notePanel.TabIndex = 17;
            this.notePanel.TabStop = false;
            // 
            // vbwRentsHistory
            // 
            this.vbwRentsHistory.Location = new System.Drawing.Point(138, 103);
            this.vbwRentsHistory.Name = "vbwRentsHistory";
            this.vbwRentsHistory.Properties.ShowTitle = true;
            this.vbwRentsHistory.Size = new System.Drawing.Size(266, 20);
            this.vbwRentsHistory.StyleController = this.lcMain;
            this.vbwRentsHistory.TabIndex = 0;
            // 
            // ceGenerateRentsHistory
            // 
            this.ceGenerateRentsHistory.EditValue = true;
            this.ceGenerateRentsHistory.Enabled = false;
            this.ceGenerateRentsHistory.Location = new System.Drawing.Point(12, 264);
            this.ceGenerateRentsHistory.Name = "ceGenerateRentsHistory";
            this.ceGenerateRentsHistory.Properties.Caption = "Generate rents history";
            this.ceGenerateRentsHistory.Size = new System.Drawing.Size(420, 19);
            this.ceGenerateRentsHistory.StyleController = this.lcMain;
            this.ceGenerateRentsHistory.TabIndex = 13;
            this.ceGenerateRentsHistory.CheckedChanged += new System.EventHandler(this.ceGenerateRentsHistory_CheckedChanged);
            // 
            // vbwCreatingDb
            // 
            this.vbwCreatingDb.Location = new System.Drawing.Point(138, 79);
            this.vbwCreatingDb.Name = "vbwCreatingDb";
            this.vbwCreatingDb.Properties.ShowTitle = true;
            this.vbwCreatingDb.Size = new System.Drawing.Size(266, 20);
            this.vbwCreatingDb.StyleController = this.lcMain;
            this.vbwCreatingDb.TabIndex = 7;
            // 
            // lciGenerateRentsHistory
            // 
            this.lciGenerateRentsHistory.Control = this.ceGenerateRentsHistory;
            this.lciGenerateRentsHistory.CustomizationFormText = "lciGenerateRentsHistory";
            this.lciGenerateRentsHistory.Location = new System.Drawing.Point(0, 252);
            this.lciGenerateRentsHistory.Name = "lciGenerateRentsHistory";
            this.lciGenerateRentsHistory.Size = new System.Drawing.Size(424, 22);
            this.lciGenerateRentsHistory.Text = "lciGenerateRentsHistory";
            this.lciGenerateRentsHistory.TextSize = new System.Drawing.Size(0, 0);
            this.lciGenerateRentsHistory.TextToControlDistance = 0;
            this.lciGenerateRentsHistory.TextVisible = false;
            // 
            // lcgMain
            // 
            this.lcgMain.CustomizationFormText = "Root";
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRentsHistory,
            this.lciCreatingDB,
            this.layoutControlItem1,
            this.emptySpaceItem7,
            this.simpleSeparator1});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(416, 138);
            this.lcgMain.Text = "Root";
            this.lcgMain.TextVisible = false;
            // 
            // lciRentsHistory
            // 
            this.lciRentsHistory.Control = this.vbwRentsHistory;
            this.lciRentsHistory.CustomizationFormText = "Generating data:";
            this.lciRentsHistory.Location = new System.Drawing.Point(0, 91);
            this.lciRentsHistory.MaxSize = new System.Drawing.Size(0, 24);
            this.lciRentsHistory.MinSize = new System.Drawing.Size(180, 24);
            this.lciRentsHistory.Name = "lciRentsHistory";
            this.lciRentsHistory.Size = new System.Drawing.Size(396, 27);
            this.lciRentsHistory.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRentsHistory.Text = "Generating data:";
            this.lciRentsHistory.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciRentsHistory.TextSize = new System.Drawing.Size(121, 13);
            this.lciRentsHistory.TextToControlDistance = 5;
            // 
            // lciCreatingDB
            // 
            this.lciCreatingDB.Control = this.vbwCreatingDb;
            this.lciCreatingDB.CustomizationFormText = "lciCreateDB";
            this.lciCreatingDB.Location = new System.Drawing.Point(0, 67);
            this.lciCreatingDB.MaxSize = new System.Drawing.Size(0, 24);
            this.lciCreatingDB.MinSize = new System.Drawing.Size(180, 24);
            this.lciCreatingDB.Name = "lciCreatingDB";
            this.lciCreatingDB.Size = new System.Drawing.Size(396, 24);
            this.lciCreatingDB.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCreatingDB.Text = "Creating database:";
            this.lciCreatingDB.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCreatingDB.TextSize = new System.Drawing.Size(121, 13);
            this.lciCreatingDB.TextToControlDistance = 5;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.notePanel;
            this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(396, 54);
            this.layoutControlItem1.Text = "layoutControlItem1";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextToControlDistance = 0;
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.CustomizationFormText = "emptySpaceItem7";
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 54);
            this.emptySpaceItem7.MaxSize = new System.Drawing.Size(0, 11);
            this.emptySpaceItem7.MinSize = new System.Drawing.Size(10, 11);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(396, 11);
            this.emptySpaceItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem7.Text = "emptySpaceItem7";
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 65);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(396, 2);
            this.simpleSeparator1.Text = "simpleSeparator1";
            // 
            // frmCreateInitialDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 138);
            this.Controls.Add(this.lcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmCreateInitialDB";
            this.Text = "Create Database";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vbwRentsHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceGenerateRentsHistory.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vbwCreatingDb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGenerateRentsHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRentsHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCreatingDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VisualBackgroundWorker vbwRentsHistory;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciRentsHistory;
        private VisualBackgroundWorker vbwCreatingDb;
        private DevExpress.XtraLayout.LayoutControlItem lciCreatingDB;
        private DevExpress.XtraEditors.CheckEdit ceGenerateRentsHistory;
        private DevExpress.XtraLayout.LayoutControlItem lciGenerateRentsHistory;
        private DevExpress.Utils.Frames.NotePanel8_1 notePanel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    }
}
