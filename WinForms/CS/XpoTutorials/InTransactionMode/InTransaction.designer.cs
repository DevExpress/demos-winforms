namespace DevExpress.Xpo.Demos {
    partial class InTransactionMode {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            this.gclInTransactionModeMain = new DevExpress.XtraGrid.GridControl();
            this.gvlInTransactionMode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ceInTransactionMode = new DevExpress.XtraEditors.CheckEdit();
            this.sbCommit = new DevExpress.XtraEditors.SimpleButton();
            this.sbChangeAnyEmployee = new DevExpress.XtraEditors.SimpleButton();
            this.sbEmployees = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gclInTransactionModeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlInTransactionMode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ceInTransactionMode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gclInTransactionModeMain
            // 
            this.gclInTransactionModeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gclInTransactionModeMain.Location = new System.Drawing.Point(0, 59);
            this.gclInTransactionModeMain.MainView = this.gvlInTransactionMode;
            this.gclInTransactionModeMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gclInTransactionModeMain.Name = "gclInTransactionModeMain";
            this.gclInTransactionModeMain.Size = new System.Drawing.Size(915, 586);
            this.gclInTransactionModeMain.TabIndex = 2;
            this.gclInTransactionModeMain.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvlInTransactionMode});
            // 
            // gvlInTransactionMode
            // 
            this.gvlInTransactionMode.GridControl = this.gclInTransactionModeMain;
            this.gvlInTransactionMode.Name = "gvlInTransactionMode";
            this.gvlInTransactionMode.OptionsBehavior.Editable = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ceInTransactionMode);
            this.panelControl1.Controls.Add(this.sbCommit);
            this.panelControl1.Controls.Add(this.sbChangeAnyEmployee);
            this.panelControl1.Controls.Add(this.sbEmployees);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(915, 59);
            this.panelControl1.TabIndex = 3;
            // 
            // ceInTransactionMode
            // 
            this.ceInTransactionMode.Location = new System.Drawing.Point(28, 17);
            this.ceInTransactionMode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ceInTransactionMode.Name = "ceInTransactionMode";
            this.ceInTransactionMode.Properties.Caption = "InTransaction mode";
            this.ceInTransactionMode.Size = new System.Drawing.Size(143, 21);
            this.ceInTransactionMode.TabIndex = 11;
            this.ceInTransactionMode.CheckedChanged += new System.EventHandler(this.ceInTransactionMode_CheckedChanged);
            this.ceInTransactionMode.CheckStateChanged += new System.EventHandler(this.ceInTransactionMode_CheckStateChanged);
            // 
            // sbCommit
            // 
            this.sbCommit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbCommit.Enabled = false;
            this.sbCommit.Location = new System.Drawing.Point(541, 15);
            this.sbCommit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbCommit.Name = "sbCommit";
            this.sbCommit.Size = new System.Drawing.Size(140, 26);
            this.sbCommit.TabIndex = 10;
            this.sbCommit.Text = "Commit Changes";
            this.sbCommit.Click += new System.EventHandler(this.sbCommit_Click);
            // 
            // sbChangeAnyEmployee
            // 
            this.sbChangeAnyEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbChangeAnyEmployee.Location = new System.Drawing.Point(381, 15);
            this.sbChangeAnyEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbChangeAnyEmployee.Name = "sbChangeAnyEmployee";
            this.sbChangeAnyEmployee.Size = new System.Drawing.Size(153, 26);
            this.sbChangeAnyEmployee.TabIndex = 9;
            this.sbChangeAnyEmployee.Text = "Change Employee Data";
            this.sbChangeAnyEmployee.Click += new System.EventHandler(this.changeAnyEmployee_Click);
            // 
            // sbEmployees
            // 
            this.sbEmployees.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sbEmployees.Location = new System.Drawing.Point(755, 15);
            this.sbEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sbEmployees.Name = "sbEmployees";
            this.sbEmployees.Size = new System.Drawing.Size(140, 26);
            this.sbEmployees.TabIndex = 6;
            this.sbEmployees.Text = "Load Employees";
            this.sbEmployees.Click += new System.EventHandler(this.sbEmployees_Click);
            // 
            // InTransactionMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gclInTransactionModeMain);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InTransactionMode";
            this.Size = new System.Drawing.Size(915, 645);
            this.VisibleChanged += new System.EventHandler(this.InTransactionMode_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gclInTransactionModeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvlInTransactionMode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ceInTransactionMode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gclInTransactionModeMain;
        private DevExpress.XtraGrid.Views.Grid.GridView gvlInTransactionMode;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbEmployees;
        private DevExpress.XtraEditors.SimpleButton sbChangeAnyEmployee;
        private DevExpress.XtraEditors.SimpleButton sbCommit;
        private DevExpress.XtraEditors.CheckEdit ceInTransactionMode;
    }
}
